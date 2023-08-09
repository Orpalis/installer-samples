using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using GdPicture14;
using System.IO;


//GUIManager controls all the GUI and the communication between UI elements and internal resources
namespace Csharp_Forms_Processing
{
    public class GUIManager
    {

        //Structure to Hold Anchor Region and OMR Fields Viewer Regions
        public struct ViewerRegions
        {
            //Anchor Region
            public int AnchorRegion;
            //Field Regions
            public List<int> FieldRegions;
        }

        //Template Anchor and Field Viewer Regions
        private ViewerRegions m_TemplateRegions;
        //Filled Form Anchor and Field Regions
        private ViewerRegions m_FilledFormsRegions;

        //ProcessForms instance for Anchor and OMR processing functions
        private ProcessForms m_ProcessForms;

        //Variable to indicate which stage of the Template Form Set Up is currentely selected
        //1. Load Template Form
        //2. Select Anchor
        //3. Add Fields
        //4. Add Single Field
        //5. Add Multiple Field
        int m_CurrentStage;
        //Variable to indicate which stage of the Template Form Set Up is most reached
        int m_StageReached;

        //Variable to see if Anchor Region has been drawn or not
        bool m_IsAnchorSet;

        //Structure to indicate how Field Regions are related to each other
        //Single Fields will have values 1 and 1
        public struct FieldsGrouping
        {
            public FieldsGrouping(int Q, int F)
            {
                NumberOfFields = F;
                NumberOfQuestion = Q;
            }
            //Number of Questions in this instance
            public int NumberOfQuestion;
            //Number of Fields Per Question In this instance
            public int NumberOfFields;
        }

        //List of RegionCount that will be used to display results
        //Each added field whether multiple or single will add a new element to the list indicating the Fields Grouping
        //Single Fields will indicate 1 question and 1 field
        List<FieldsGrouping> m_FieldsGrouping;

        //Variables to Hold Number Of Questions and Number of Fields Per Question in Each Multiple Field
        int m_NumberOfQuestions;
        int m_NumberOfFieldsPerQuestion;

        //Reference to Main Form (Form1)
        public readonly Form1 m_Form;
        //Constructor: Passing Main Form to GUIManager As Reference
        public GUIManager(Form1 FormReference)
        {
            m_Form = FormReference;
            m_ProcessForms = new ProcessForms(FormReference);
            m_FilledFormsRegions.FieldRegions = new List<int>();
            m_TemplateRegions.FieldRegions = new List<int>();
            m_FieldsGrouping = new List<FieldsGrouping>();
            m_CurrentStage = 0;
            m_StageReached = 0;
            m_IsAnchorSet = false;
            m_NumberOfQuestions = 0;
            m_NumberOfFieldsPerQuestion = 0;
        }

        //New Project
        public void NewProject()
        {
            ClearFilledForms();
            ClearTemplateForm();
            ClearResources();
            m_Form.TableLayoutPanelData.Controls.Remove(m_Form.processFormsPanel);
            m_Form.TableLayoutPanelData.Controls.Remove(m_Form.formSetUpPanel);
            m_Form.formSetUpButton.FlatStyle = FlatStyle.System;
            m_Form.processFormsButton.FlatStyle = FlatStyle.System;
            m_Form.formSetUpButton.Visible = true;
            m_Form.processFormsButton.Visible = true;
        }

        //Close Project
        public void CloseProject()
        {
            ClearFilledForms();
            ClearTemplateForm();
            ClearResources();
            m_Form.formSetUpButton.Visible = false;
            m_Form.processFormsButton.Visible = false;
            m_Form.TableLayoutPanelData.Controls.Remove(m_Form.processFormsPanel);
            m_Form.TableLayoutPanelData.Controls.Remove(m_Form.formSetUpPanel);
        }

        //Clear ALL GUI Resources
        public void ClearResources()
        {
            //Clearing Template Viewer regions
            m_Form.formViewer.RemoveAllRegions();
            //Clearing Template Image
            m_Form.formViewer.Clear();
            m_Form.formViewer.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
            //Resetting GUI Resources
            m_Form.hasCharacter.Checked = false;
            m_Form.checkORCircle.Checked = true;
            m_Form.oval.Checked = false;
            m_Form.sensitivity.Value = 50;
            m_Form.minConfidenceValue.Value = 50;
            m_Form.useConfidence.Checked = false;
            m_Form.selectAnchorButton.Visible = false;
            m_Form.addFieldsButton.Visible = false;
            m_IsAnchorSet = false;
            //Restting counters
            m_NumberOfQuestions = 0;
            m_NumberOfFieldsPerQuestion = 0;
            m_FieldsGrouping.Clear();
        }

        //Clearing Filled forms and their related GUI
        public void ClearFilledForms()
        {
            m_ProcessForms.ReInitializeForms();
            ClearFilledFormsGUI();
        }

        //Clears Filled Forms related GUI
        private void ClearFilledFormsGUI()
        {
            m_Form.imagesViewer.RemoveAllRegions();
            m_Form.imagesViewer.Clear();
            m_FilledFormsRegions.AnchorRegion = 0;
            m_FilledFormsRegions.FieldRegions.Clear();
            m_Form.ListBox1.Items.Clear();
            m_Form.resultsTextBox.Clear();
        }

        //Clearing Template Form and its related GUI and resources
        public void ClearTemplateForm()
        {
            m_ProcessForms.ClearTemplate();
            ClearTemplateFormGUI();
        }

        //Clears Template Form related GUI and resources
        private void ClearTemplateFormGUI()
        {
            m_Form.formViewer.RemoveAllRegions();
            m_Form.formViewer.Clear();
            m_TemplateRegions.AnchorRegion = 0;
            m_TemplateRegions.FieldRegions.Clear();
            ClearResources();
        }


        //Sets all OMR Field Regions to Uneditable
        private void DisableTemplateViewerFieldsRegions()
        {
            int RegionID = default(int);
            foreach (int tempLoopVar_RegionID in m_TemplateRegions.FieldRegions)
            {
                RegionID = tempLoopVar_RegionID;
                m_Form.formViewer.SetRegionEditable(RegionID, false);
            }
        }

        //Sets all OMR Field Regions to Editable
        private void EnableTemplateViewerFieldsRegions()
        {
            int RegionID = default(int);
            foreach (int tempLoopVar_RegionID in m_TemplateRegions.FieldRegions)
            {
                RegionID = tempLoopVar_RegionID;
                m_Form.formViewer.SetRegionEditable(RegionID, true);
            }
        }

        public bool RegionToBeDrawn()
        {
            //Check if Field Regions have to be drawn but have not been yet
            //We implement this by checking if the current stage is Add Single Region = 4 or Add Multiple Region = 5
            if (m_CurrentStage == 4 | m_CurrentStage == 5)
            {
                MessageBox.Show("You still have to draw your region!!", " ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                return true;
            }
            return false;
        }

        ///''''''''''EVENTS HANDLERS'''''''''''''''''
        ///''''''''''''''''''''''''''''''''''''''''''
        //Form Set Up GUI Events
        //

        //Function to Handle Clicking the Form Setup Button click
        public void OpenFormSetUP()
        {
            //Check if Field Regions have to be drawn but have not been yet
            if (RegionToBeDrawn())
            {
                return;
            }
            //Checking whether Filled Forms Have been loaded and Processed
            //If Filled Forms have been processed, asking user if he is willing to lose proccssed data and information
            if (m_ProcessForms.m_IsProcessed == true)
            {
                if (MessageBox.Show("You will lose processed data if you return to Form Setup, are you sure?", "Cancel Results?", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
                {
                    //Clearing Filled Forms and their GUI resources
                    ClearFilledForms();
                }
                else
                {
                    return;
                }
            }

            //Removing the Processing Forms GUI Panel
            m_Form.TableLayoutPanelData.Controls.Remove(m_Form.processFormsPanel);
            //Reinstating the Form SetuUp GUI Panel
            m_Form.TableLayoutPanelData.Controls.Add(m_Form.formSetUpPanel);


            //Adjusting Button Styles
            m_Form.formSetUpButton.FlatStyle = FlatStyle.Flat;
            m_Form.processFormsButton.FlatStyle = FlatStyle.System;

            //Prompting User to Load Template Form Image if no such Image is available (First time in the project)
            if (!m_ProcessForms.IsTemplateFormLoaded())
            {
                LoadTemplateForm();
            }
        }

        //Handles LoadForm button
        //Prompts User to select Template Form Image
        public void LoadTemplateForm()
        {
            //Check if Field Regions have to be drawn but have not been yet
            if (RegionToBeDrawn())
            {
                return;
            }

            //Asking user if he wants to cancel his Template Form Set Up
            if (m_ProcessForms.m_TemplateForm.m_Image != 0)
            {
                if (MessageBox.Show("Are you sure you want to cancel your current template form set up?", "Cancel Form?", MessageBoxButtons.OKCancel, MessageBoxIcon.None) == System.Windows.Forms.DialogResult.OK)
                {
                    ClearTemplateForm();
                }
                else
                {
                    return;
                }
            }

            //Adjusting Button Styles
            m_Form.loadFormButton.FlatStyle = FlatStyle.Flat;
            m_Form.selectAnchorButton.FlatStyle = FlatStyle.System;
            m_Form.addFieldsButton.FlatStyle = FlatStyle.System;

            //Making the regions uneditable
            DisableTemplateViewerFieldsRegions();
            m_Form.addFieldsPanel.Visible = false;
            m_Form.formViewer.SetRegionEditable(m_TemplateRegions.AnchorRegion, false);

            //Loading Image
            m_ProcessForms.m_TemplateForm.m_Image = m_Form.oGdPictureImaging.CreateGdPictureImageFromFile("");
            if (m_ProcessForms.m_TemplateForm.m_Image != 0)
            {
                m_Form.formViewer.DisplayFromGdPictureImage(m_ProcessForms.m_TemplateForm.m_Image);
            }
            else
            {
                MessageBox.Show("Error:" + m_Form.oGdPictureImaging.GetStat().ToString());
                return;
            }

            m_CurrentStage = 1;
            m_StageReached = 1;
            m_IsAnchorSet = false;
            m_Form.selectAnchorButton.Visible = true;
            //Moving to next Stage, prompting the user to select anchor
            SelectAnchor();
        }

        //Sets the current state to the Anchor Selection on the Template Form
        public void SelectAnchor()
        {
            //Check if Field Regions have to be drawn but have not been yet
            if (RegionToBeDrawn())
            {
                return;
            }
            //Disabling Fields Regions (if they exist) to bring focus only to Anchor Region
            DisableTemplateViewerFieldsRegions();

            //Changing button styles
            m_Form.loadFormButton.FlatStyle = FlatStyle.System;
            m_Form.selectAnchorButton.FlatStyle = FlatStyle.Flat;
            m_Form.addFieldsButton.FlatStyle = FlatStyle.System;
            //Changing current stage in Template Form Set Up
            m_CurrentStage = 2; //Select Anchor State
            //Changing Max stage reached in Template Form Set Up
            if (m_StageReached < 2) //If first time Select Anchor has been reached
            {
                m_StageReached = 2;
            }

            m_Form.addFieldsPanel.Visible = false;
            m_Form.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection;
            if (m_IsAnchorSet == true)
            {
                m_Form.formViewer.SetRegionEditable(m_TemplateRegions.AnchorRegion, true);
            }
        }

        //Sets the current state to the Anchor Selection on the Template Form
        public void AddFields()
        {
            //Check if Field Regions have to be drawn but have not been yet
            if (RegionToBeDrawn())
            {
                return;
            }
            EnableTemplateViewerFieldsRegions();

            m_Form.addFieldsPanel.Visible = true;
            //Changing button styles
            m_Form.loadFormButton.FlatStyle = FlatStyle.System;
            m_Form.selectAnchorButton.FlatStyle = FlatStyle.System;
            m_Form.addFieldsButton.FlatStyle = FlatStyle.Flat;

            //Changing current stage in Template Form Set Up
            m_CurrentStage = 3; //Add Fields Stage
            //Changing Max stage reached in Template Form Set Up
            if (m_StageReached < 3) //If first time Add Fields has been reached
            {
                m_StageReached = 3;
            }
            m_Form.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            if (m_IsAnchorSet == true)
            {
                m_Form.formViewer.SetRegionEditable(m_TemplateRegions.AnchorRegion, false);
            }
        }

        //Loading new Form
        //Clears old form GUI and Data if form already exists upon approval of the user
        public void OpenProcessForms()
        {
            if (m_ProcessForms.m_TemplateForm.m_NumberOfFields == 0)
            {
                MessageBox.Show("You have not added any OMR Field Regions", " ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                return;
            }
            //Removing Form Set Up Panel
            m_Form.TableLayoutPanelData.Controls.Remove(m_Form.formSetUpPanel);
            //Reinstating Process Forms Panel
            m_Form.TableLayoutPanelData.Controls.Add(m_Form.processFormsPanel);
            //Changing Button Styles
            m_Form.formSetUpButton.FlatStyle = FlatStyle.System;
            m_Form.processFormsButton.FlatStyle = FlatStyle.Flat;


        }

        //Handles checlOrCircle click event
        public void CheckOrCircle_CheckedChanged()
        {
            if (m_Form.checkORCircle.Checked == true)
            {
                m_ProcessForms.m_TemplateForm.m_IsCircular = true;
            }
            else
            {
                m_ProcessForms.m_TemplateForm.m_IsCircular = false;
            }
        }

        //Handles oval click event
        public void Oval_CheckedChanged()
        {
            if (m_Form.oval.Checked == true)
            {
                m_ProcessForms.m_TemplateForm.m_IsCircular = false;
            }
            else
            {
                m_ProcessForms.m_TemplateForm.m_IsCircular = true;
            }
        }

        //Handles HasCharacter click event
        public void HasCharacter_CheckedChanged()
        {
            if (m_Form.hasCharacter.Checked == true)
            {
                m_ProcessForms.m_TemplateForm.m_HasCharacter = true;
            }
            else
            {
                m_ProcessForms.m_TemplateForm.m_HasCharacter = false;
            }
        }

        //Handles UseConfice click event
        public void UseConfidence_CheckedChanged()
        {
            if (m_Form.useConfidence.Checked == true)
            {
                m_ProcessForms.m_TemplateForm.m_UseConfidence = true;
                m_Form.confidenceGroup.Enabled = true;
            }
            else
            {
                m_ProcessForms.m_TemplateForm.m_UseConfidence = false;
                m_Form.confidenceGroup.Enabled = false;
            }
        }

        //Handles Sensitivity scroll event
        public void Sensitivity_Scroll()
        {
            m_ProcessForms.m_TemplateForm.m_Sensitivity = m_Form.sensitivity.Value / 100;
            m_Form.sensitivityValue.Text = m_Form.sensitivity.Value.ToString();
        }

        //Handles Min Confidence Value Change
        public void MinConfidenceValue_Changed()
        {
            m_ProcessForms.m_TemplateForm.m_MinimumConfidence = (int)m_Form.minConfidenceValue.Value;
        }

        //Handles Add Single Field Button Click
        public void AddSingleField()
        {
            if (RegionToBeDrawn())
            {
                return;
            }
            //Setting Template Form Setup Stage
            m_CurrentStage = 4; //Add Multiple Fields Stage
            DisableTemplateViewerFieldsRegions();
            m_Form.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection;
            m_Form.oGdPictureImaging.SetTransparency(m_ProcessForms.m_TemplateForm.m_Image, -150);
            m_Form.formViewer.Redraw();
            m_FieldsGrouping.Add(new FieldsGrouping(1, 1));
        }

        //Handles Add Multiple Fields Button Click
        public void AddMultipleFields()
        {
            if (RegionToBeDrawn())
            {
                return;
            }

            //Instating Add Mulitple Fields Dialog To Gather information about number of questions and number of fields per question
            AddMultipleOMRFieldDialog AddFieldsDialog = new AddMultipleOMRFieldDialog();
            m_Form.Enabled = false;

            DialogResult Result = AddFieldsDialog.ShowDialog();
            m_Form.Enabled = true;
            if (Result == DialogResult.Cancel)
            {
                return;
            }
            //Setting Template Form Setup Stage
            m_CurrentStage = 5; //Add Multiple Fields Stage

            //Update Number of Question and Number of Fields Per Question
            m_NumberOfQuestions = (int)AddFieldsDialog.numberOfQuestions.Value;
            m_NumberOfFieldsPerQuestion = (int)AddFieldsDialog.numberOfFieldsPerQuestion.Value;
            m_FieldsGrouping.Add(new FieldsGrouping(m_NumberOfQuestions, m_NumberOfFieldsPerQuestion));
            //Disabling all previous regions
            DisableTemplateViewerFieldsRegions();
            //Setting Mouse To Area Selection
            m_Form.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection;
            m_Form.oGdPictureImaging.SetTransparency(m_ProcessForms.m_TemplateForm.m_Image, -150);
            m_Form.formViewer.Redraw();
        }

        //Handles Mouse Up Event on the Template Form Viewer
        public void MouseUP()
        {
            if (m_CurrentStage == 2) //If it is Select Anchor Stage
            {
                if (m_Form.formViewer.IsRect()) //If an Anchor Region has been selected
                {
                    if (m_IsAnchorSet == true) //If there was a previous Anchor Set, delete it
                    {
                        m_Form.formViewer.RemoveRegionByID(m_TemplateRegions.AnchorRegion);
                        if (m_ProcessForms.m_TemplateForm.m_AnchorID != IntPtr.Zero)
                        {
                            m_Form.oGdPictureImaging.DeleteAnchorTemplate((IntPtr)m_ProcessForms.m_TemplateForm.m_AnchorID);
                        }
                        m_IsAnchorSet = false;
                    }
                    //Variables to hold Anchor Region Location
                    int AnchorLeft = default(int);
                    int AnchorTop = default(int);
                    int AnchorWidth = default(int);
                    int AnchorHeight = default(int);

                    //Getting the coordinates of the Rectangle Of Selection on the Document Displayed
                    m_Form.formViewer.GetRectCoordinatesOnDocument(ref AnchorLeft, ref AnchorTop, ref AnchorWidth, ref AnchorHeight);
                    //Clearing the Rectangle Of Selection
                    m_Form.formViewer.ClearRect();

                    //Adding a Region in Place of the Rectangle of Selection
                    m_TemplateRegions.AnchorRegion = m_Form.formViewer.AddRegion("anchor", AnchorLeft, AnchorTop, AnchorWidth, AnchorHeight, GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Green);
                    m_Form.formViewer.SetRegionBorderWidth(m_TemplateRegions.AnchorRegion, 1);
                    m_Form.formViewer.SetRegionBorderColor(m_TemplateRegions.AnchorRegion, Color.Blue);
                    m_Form.formViewer.Redraw();

                    //Creating a new AnchorID
                    IntPtr AnchorID = m_Form.oGdPictureImaging.CreateAnchorTemplate(m_ProcessForms.m_TemplateForm.m_Image, AnchorLeft, AnchorTop, AnchorWidth, AnchorHeight);
                    //Checking if Creating Anchor Succeeded
                    if (AnchorID == IntPtr.Zero)
                    {
                        MessageBox.Show("Error" + m_Form.oGdPictureImaging.GetStat().ToString());
                        m_Form.formViewer.RemoveRegionByID(m_TemplateRegions.AnchorRegion);
                        return;
                    }


                    //Update Anchor Information in Tempalte Form
                    Rectangle RECT = new Rectangle
                    {
                        X = m_Form.formViewer.GetRegionLeftPixels(m_TemplateRegions.AnchorRegion),
                        Y = m_Form.formViewer.GetRegionTopPixels(m_TemplateRegions.AnchorRegion),
                        Width = m_Form.formViewer.GetRegionWidthPixels(m_TemplateRegions.AnchorRegion),
                        Height = m_Form.formViewer.GetRegionHeightPixels(m_TemplateRegions.AnchorRegion)
                    };
                    m_ProcessForms.m_TemplateForm.UpdateAnchor(AnchorID, RECT);


                    //m_FormSettings.UpdateAnchorSearchArea()
                    m_IsAnchorSet = true;
                    m_Form.addFieldsButton.Visible = true;
                    //drawRectanglesButton.Visible = True

                }
            }
            if (m_CurrentStage == 4) //Add Single Region
            {
                if (m_Form.formViewer.IsRect()) //If a Rectangle Of Selection has been made
                {
                    int Left = default(int);
                    int Top = default(int);
                    int Width = default(int);
                    int Height = default(int);
                    //Getting the Rectangle Of Selection Coordinates
                    m_Form.formViewer.GetRectCoordinatesOnDocument(ref Left, ref Top, ref Width, ref Height);
                    //Clearing the Rectangle Of Selection
                    m_Form.formViewer.ClearRect();

                    int NumberOfCurrentRegion = m_ProcessForms.m_TemplateForm.m_NumberOfFields + 1;

                    //Adding a Region in place of the Rectangle (OMR Field)
                    m_TemplateRegions.FieldRegions.Add(m_Form.formViewer.AddRegion(NumberOfCurrentRegion.ToString(), Left, Top, Width, Height, GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Aqua));

                    m_Form.formViewer.SetRegionBorderWidth(m_TemplateRegions.FieldRegions[NumberOfCurrentRegion - 1], 1);
                    m_Form.formViewer.SetRegionBorderColor(m_TemplateRegions.FieldRegions[NumberOfCurrentRegion - 1], Color.Red);
                    m_Form.formViewer.Redraw();

                    //Adding Field Information To Template
                    Rectangle RECT = new Rectangle();
                    RECT.X = Left;
                    RECT.Y = Top;
                    RECT.Width = Width;
                    RECT.Height = Height;
                    m_ProcessForms.m_TemplateForm.AddField(RECT);
                    m_Form.totalNumberOfFieldsLabel.Text = m_ProcessForms.m_TemplateForm.m_NumberOfFields.ToString();

                    m_CurrentStage = 3; //Setting Current Stage Back To Add Fields
                    m_Form.formViewer.MouseMode = ViewerMouseMode.MouseModePan;
                    m_Form.oGdPictureImaging.SetTransparency(m_ProcessForms.m_TemplateForm.m_Image, 255);
                    m_Form.formViewer.Redraw();
                    //Enabling All Regions for Editing
                    EnableTemplateViewerFieldsRegions();
                }
            }
            if (m_CurrentStage == 5) //Add Multiple OMR Fields at once
            {
                if (m_Form.formViewer.IsRect()) //If a Rectangle Of Selection has been made
                {
                    int Left = default(int);
                    int Top = default(int);
                    int Width = default(int);
                    int Height = default(int);
                    //Getting the Rectangle Of Selection Coordinates
                    m_Form.formViewer.GetRectCoordinatesOnDocument(ref Left, ref Top, ref Width, ref Height);
                    //Clearing the Rectangle Of Selection
                    m_Form.formViewer.ClearRect();

                    //Now we need to segment the rect according to the Number of Questions and Number of Fields Per Question
                    //Number of Field Regions = Number Of Questions * Number of Fields Per Question
                    //EXAMPLE: If Bellow rectangle contains 2 questions and 3 fields per question
                    //**********
                    //*        *
                    //*        *
                    //*        *
                    //*   1    * 1 Question 1 Field
                    //*        *
                    //*        *
                    //*        *
                    //**********
                    //AFTER SEGMENTATION IT WILL BECOME
                    //**********
                    //*  *  *  *
                    //*11*12*13*
                    //*  *  *  *
                    //********** 2 Questions 3 Fields Each
                    //*  *  *  *
                    //*21*22*23*
                    //*  *  *  *
                    //**********
                    //The above is accomplished via the Following Formulas:
                    //LEFT, TOP, WIDTH, HEIGHT are the dimenstions of the Original BIG region
                    //sW and sH are the width and height of the small regions (equal over all)
                    //Sep is the seperation Horizontally and Vertically between Regions: CONSTANT at 2
                    //sLeft(i), sTop(i) are the Left and Top of each small region
                    //smW = (Width / Number of Fields Per Question)
                    //smH = (Height/ Number of Questions)
                    //smLeft(i) = LEFT + (smW * (i  mod Number Of Fields Per Question))
                    //smTop(i)  = TOP  + (smH * QuestionLevel)
                    int smW = (int)(Math.Floor(((Width) / m_NumberOfFieldsPerQuestion) + 0.5));
                    int smH = (int)(Math.Floor(((Height) / m_NumberOfQuestions) + 0.5));

                    int CurrentNumberOfRegions = m_NumberOfFieldsPerQuestion * m_NumberOfQuestions;

                    int QuestionLevel = 0;
                    //Adding Regions in place of the Rectangle (OMR Field)
                    for (int i = 0; i <= CurrentNumberOfRegions - 1; i++)
                    {
                        int NumberOfCurrentRegion = m_ProcessForms.m_TemplateForm.m_NumberOfFields + 1;
                        int Loc = i % m_NumberOfFieldsPerQuestion;
                        int smLeft = Left + (smW * Loc);

                        if (i != 0 & i % m_NumberOfFieldsPerQuestion == 0)
                        {
                            QuestionLevel++;
                        }
                        int smTop = Top + (smH * QuestionLevel);
                        int RegionID = m_Form.formViewer.AddRegion(NumberOfCurrentRegion.ToString(), smLeft, smTop, smW, smH, GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Aqua);
                        m_TemplateRegions.FieldRegions.Add(RegionID);
                        m_Form.formViewer.SetRegionBorderWidth(RegionID, 1);
                        m_Form.formViewer.SetRegionBorderColor(RegionID, Color.Red);

                        //Adding Field Information To Template
                        Rectangle RECT = new Rectangle();
                        RECT.X = smLeft;
                        RECT.Y = smTop;
                        RECT.Width = smW;
                        RECT.Height = smH;
                        m_ProcessForms.m_TemplateForm.AddField(RECT);
                    }
                    m_Form.formViewer.Redraw();
                    //Updating total number of fields label
                    m_Form.totalNumberOfFieldsLabel.Text = m_ProcessForms.m_TemplateForm.m_NumberOfFields.ToString();
                    m_CurrentStage = 3; //Setting Current Stage Back To Add Fields
                    //Setting Mouse Mode to Pan
                    m_Form.formViewer.MouseMode = ViewerMouseMode.MouseModePan;
                    m_NumberOfFieldsPerQuestion = 0;
                    m_NumberOfQuestions = 0;
                    m_Form.oGdPictureImaging.SetTransparency(m_ProcessForms.m_TemplateForm.m_Image, 255);
                    m_Form.formViewer.Redraw();
                    //Enabling All Regions For Editing
                    EnableTemplateViewerFieldsRegions();
                }
            }
        }

        //Handles Region Edited By User
        //For Regions of the Template Form, Regions on the Filled Forms are LOCKED, thus cannot be edited
        public void RegionEditedByUser(int RegionID)
        {
            if (m_CurrentStage == 2) //Set Anchor and Edit Anchor Stage
            {

                //Getting the Region's New Coordinates
                Rectangle RECT = new Rectangle();
                RECT.Width = m_Form.formViewer.GetRegionWidthPixels(RegionID);
                RECT.Height = m_Form.formViewer.GetRegionHeightPixels(RegionID);
                RECT.X = m_Form.formViewer.GetRegionLeftPixels(RegionID);
                RECT.Y = m_Form.formViewer.GetRegionTopPixels(RegionID);

                //Deleting the Anchor ID if it exists and creating a new one with the new coordinates
                if (m_ProcessForms.m_TemplateForm.m_AnchorID != IntPtr.Zero)
                {
                    m_Form.oGdPictureImaging.DeleteAnchorTemplate((IntPtr)m_ProcessForms.m_TemplateForm.m_AnchorID);
                }
                IntPtr AnchorID = m_Form.oGdPictureImaging.CreateAnchorTemplate(m_ProcessForms.m_TemplateForm.m_Image, RECT.X, RECT.Y, RECT.Width, RECT.Height);
                if (AnchorID == IntPtr.Zero)
                {
                    MessageBox.Show("Error" + m_Form.oGdPictureImaging.GetStat().ToString());
                    m_Form.formViewer.RemoveRegionByID(RegionID);
                    return;
                }

                //Update Anchorin the Template Form
                m_ProcessForms.m_TemplateForm.UpdateAnchor(AnchorID, RECT);

            }
            else //Region Edited is a Field Region
            {
                int i = default(int);
                int pos = 0;
                //Finding which Field corresponds to to the Region being edited
                //We loop through Filled Region IDs and compare the Edited Region ID to them
                foreach (int tempLoopVar_i in m_TemplateRegions.FieldRegions)
                {
                    i = tempLoopVar_i;
                    if (i == RegionID)
                    {
                        break;
                    }
                    pos++;
                }
                //Getting the coordinates of the Region After being edited
                Rectangle RECT = new Rectangle();
                RECT.Width = m_Form.formViewer.GetRegionWidthPixels(RegionID);
                RECT.Height = m_Form.formViewer.GetRegionHeightPixels(RegionID);
                RECT.X = m_Form.formViewer.GetRegionLeftPixels(RegionID);
                RECT.Y = m_Form.formViewer.GetRegionTopPixels(RegionID);
                //Updating the Field info in the Template Form
                m_ProcessForms.m_TemplateForm.UpdateField(pos, RECT);
            }
        }

        //'''''''''''''''''''''''''''''''''''''''
        //Handling of Process Forms Events
        //'''''''''''''''''''''''''''''''''''''''
        //
        //Handles the click of Load Images Button
        public void LoadImagesButton_Click()
        {
            //If Images have been previously loaded, clear them
            if (m_ProcessForms.m_ImagesLoaded == true)
            {
                ClearFilledForms();
            }
            //Showint the open Dialog
            m_Form.OpenFileDialog1.Multiselect = true;
            if (m_Form.OpenFileDialog1.ShowDialog(m_Form) == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            foreach (string item in m_Form.OpenFileDialog1.FileNames)
            {
                //If file in folder is an image
                if (GdPictureDocumentUtilities.GetDocumentFormatFromFileName(item) != GdPicture14.DocumentFormat.DocumentFormatUNKNOWN)
                //if (m_Form.oGdPictureImaging.GetDocumentFormatFromFile(item) != GdPicture14.DocumentFormat.DocumentFormatUNKNOWN)
                {
                    //Add Image Name to ListBox1
                    m_Form.ListBox1.Items.Add(Path.GetFileNameWithoutExtension(item));
                    //Create GdPicture Image
                    int ImageID = m_Form.oGdPictureImaging.CreateGdPictureImageFromFile(item);
                    //If GdPictureImage failed to create display error, and take out image name from ListBox
                    if (ImageID == 0)
                    {
                        MessageBox.Show("Error" + m_Form.oGdPictureImaging.GetStat().ToString());
                        m_Form.ListBox1.Items.Remove(Path.GetFileNameWithoutExtension(item));
                    }
                    else //If GdPictureImage creation succeeded
                    {
                        //Add New Form and append Number of Filled Forms available
                        m_ProcessForms.AddForm(ImageID);
                        m_ProcessForms.m_NumberOfImages++;
                    }
                }
            }
            //Setting Images Loaded to True
            if (m_ProcessForms.m_NumberOfImages != 0)
            {
                m_ProcessForms.m_ImagesLoaded = true;
            }
        }

        //Handles ListBox1 Selected Index Changed
        public void ListBox1_SelectedIndexChanged()
        {
            if (m_Form.ListBox1.SelectedIndex != -1)
            {
                m_Form.imagesViewer.CloseDocument();
                //Clearing Filled Form RegionIDs
                m_FilledFormsRegions.FieldRegions.Clear();
                //Clearing Filled Form Regions from ImagesViewer
                m_Form.imagesViewer.RemoveAllRegions();
                //Displaying the selected Image
                m_Form.imagesViewer.DisplayFromGdPictureImage(System.Convert.ToInt32(m_ProcessForms.m_FilledForms[m_Form.ListBox1.SelectedIndex].m_Image));
                //If there is processed information:
                //Display Found Anchor Position
                //Display Filled Form Regions Shifted By Found Anchor Position
                if (m_ProcessForms.m_IsProcessed == true)
                {
                    //Add Regions
                    Rectangle RECT = new Rectangle();
                    foreach (Rectangle tempLoopVar_RECT in m_ProcessForms.m_FilledForms[m_Form.ListBox1.SelectedIndex].Fields)
                    {
                        RECT = tempLoopVar_RECT;
                        int RegionID = m_Form.imagesViewer.AddRegion("", RECT.X, RECT.Y, RECT.Width, RECT.Height, GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Aqua);
                        m_FilledFormsRegions.FieldRegions.Add(RegionID);

                        m_Form.imagesViewer.SetRegionBorderWidth(RegionID, 1);
                        m_Form.imagesViewer.SetRegionBorderColor(RegionID, Color.Red);
                        m_Form.imagesViewer.SetRegionEditable(RegionID, false);
                    }
                    //Copy Filled Form Anchor Region
                    RECT = m_ProcessForms.m_FilledForms[m_Form.ListBox1.SelectedIndex].m_FoundAnchor;
                    //Drawing the Anchor Region
                    m_FilledFormsRegions.AnchorRegion = m_Form.imagesViewer.AddRegion("", RECT.X, RECT.Y, RECT.Width, RECT.Height, GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Green);
                    m_Form.imagesViewer.SetRegionBorderWidth(m_FilledFormsRegions.AnchorRegion, 1);
                    m_Form.imagesViewer.SetRegionBorderColor(m_FilledFormsRegions.AnchorRegion, Color.Blue);
                    m_Form.imagesViewer.SetRegionEditable(m_FilledFormsRegions.AnchorRegion, false);
                    m_Form.imagesViewer.Redraw();

                    //Clearing the Previous results
                    m_Form.resultsTextBox.Clear();

                    int ResPos = 0;
                    int counter = 0;
                    FieldsGrouping pos = new FieldsGrouping();
                    //Loop Through the Groupings of the Fields
                    foreach (FieldsGrouping tempLoopVar_pos in m_FieldsGrouping)
                    {
                        pos = tempLoopVar_pos;
                        counter++;
                        int TotalFieldsNumber = pos.NumberOfQuestion * pos.NumberOfFields;
                        int QuestionCounter = 0;
                        m_Form.resultsTextBox.Text += Environment.NewLine;
                        //For each new Grouped Fields, Write a new Region
                        m_Form.resultsTextBox.Text = m_Form.resultsTextBox.Text + "Region Number: \'" + counter.ToString() + "\'";

                        int LastResult = ResPos + TotalFieldsNumber;
                        //Loop through Results Array of Filled Form
                        for (int i = ResPos; i <= LastResult - 1; i++)
                        {
                            //If current result belongs to a new question
                            //Enter a new line
                            //Enter Q and the number of the qestion
                            if ((i - ResPos) % pos.NumberOfFields == 0)
                            {
                                m_Form.resultsTextBox.Text += Environment.NewLine;
                                QuestionCounter++;
                                m_Form.resultsTextBox.Text = m_Form.resultsTextBox.Text + "\'Q" + QuestionCounter.ToString() + "\': ";
                            }
                            //Print the results of the fields of the current question
                            m_Form.resultsTextBox.Text = m_Form.resultsTextBox.Text + m_ProcessForms.m_FilledForms[m_Form.ListBox1.SelectedIndex].Results[i].ToString();
                        }
                        ResPos += TotalFieldsNumber;
                    }
                }
            }
        }

        //Handles the OMR Images Button Click
        //Calls Upon the main OMR process
        public void OMRImagesButton_Click()
        {
            if (m_ProcessForms.m_IsProcessed == true)
            {
                return;
            }
            if (m_ProcessForms.m_NumberOfImages == 0)
            {
                return;
            }

            m_ProcessForms.ProcessOMR();
            m_ProcessForms.m_IsProcessed = true;
            m_Form.ListBox1.SelectedIndex = 0;
        }

    }

}
