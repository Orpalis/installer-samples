using System;
using System.Drawing;
using System.Collections.Generic;


namespace Csharp_Forms_Processing
{
    public class ProcessForms
    {

        public bool m_IsProcessed; //Whether current loaded images have been processed or not
        public bool m_ImagesLoaded; //Whether Images were loaded or not
        public int m_NumberOfImages; //Number of Total Filled Forms
        public List<FilledForm> m_FilledForms;
        public TemplateForm m_TemplateForm = new TemplateForm();
        Form1 m_Form;

        //Constructor
        //Takes reference to main form (Form1)
        public ProcessForms(Form1 FormRef)
        {
            m_ImagesLoaded = false;
            m_IsProcessed = false;
            m_FilledForms = new List<FilledForm>();
            m_Form = FormRef;
            m_NumberOfImages = 0;
        }

        //Returns whether TemplateForm is loaded or not
        public bool IsTemplateFormLoaded()
        {
            if (m_TemplateForm.m_Image == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Creates a Filled Form and adds it to m_FilledForms list
        public void CreateFilledForms()
        {

        }

        //Clears the Template Form Data
        //Clears the Template Form relevant GUI
        //Called upon request of change of Template Form Image (Load Form Button)
        public void ClearTemplate()
        {
            m_TemplateForm.Clear();
            m_Form.oGdPictureImaging.ReleaseGdPictureImage(m_TemplateForm.m_Image);
            m_TemplateForm.m_Image = 0;
            if (m_TemplateForm.m_AnchorID != IntPtr.Zero)
            {
                m_Form.oGdPictureImaging.DeleteAnchorTemplate((IntPtr)m_TemplateForm.m_AnchorID);
            }
            m_TemplateForm.m_AnchorID = IntPtr.Zero;
        }

        //Clears Filled Forms Data
        //Called upon going back to Template Form Set Up after Processing Filled Forms
        //Called upon the Clear Images Button event
        public void ReInitializeForms()
        {
            m_ImagesLoaded = false;
            m_IsProcessed = false;
            FilledForm FilledFormInstance = default(FilledForm);
            foreach (FilledForm tempLoopVar_FilledFormInstance in m_FilledForms)
            {
                FilledFormInstance = tempLoopVar_FilledFormInstance;
                m_Form.oGdPictureImaging.ReleaseGdPictureImage(FilledFormInstance.m_Image);
                FilledFormInstance.m_Image = 0;
            }
            m_FilledForms.Clear();
            m_NumberOfImages = 0;
        }

        //Adds a new Filled Form
        public void AddForm(int ImageID)
        {
            FilledForm f = new FilledForm(ImageID, m_TemplateForm.m_NumberOfFields, ref m_TemplateForm.m_Fields);
            m_FilledForms.Add(f);
        }

        //Calculates the Anchor Search Area
        //Search Area coordinates:
        // Left = AnchorLeft- AnchorWidth/2
        // Top = AnchorTop - AnchorHeight/2
        // Width = AnchorWidth * 2
        // Height = AnchorHeight * 2
        private Rectangle CalculateAnchorSearchArea()
        {
            Rectangle RECT = new Rectangle();
            RECT.Width = System.Convert.ToInt32(2.5 * m_Form.formViewer.HorizontalResolution);
            RECT.Height = System.Convert.ToInt32(2.5 * m_Form.formViewer.VerticalResolution);
            RECT.X = System.Convert.ToInt32((m_TemplateForm.m_AnchorPosition.X + m_TemplateForm.m_AnchorPosition.Width / 2) - (RECT.Width / 2));
            RECT.Y = System.Convert.ToInt32((m_TemplateForm.m_AnchorPosition.Y + m_TemplateForm.m_AnchorPosition.Height / 2) - (RECT.Height / 2));
            return RECT;
        }

        //Performs the main OMR process
        public void ProcessOMR()
        {
            //Calculate Anchor Search Area
            Rectangle SearchArea = CalculateAnchorSearchArea();

            Rectangle NewFoundAnchor = new Rectangle();
            double Accuracy = default(double);
            FilledForm filledForm = default(FilledForm);
            //Loop through filled forms
            foreach (FilledForm tempLoopVar_filledForm in m_FilledForms)
            {
                filledForm = tempLoopVar_filledForm;
                //1. Find Anchor Position and Update Filled Form
                System.Int32 temp_PosLeft = NewFoundAnchor.X;
                System.Int32 temp_PosTop = NewFoundAnchor.Y;
                System.Int32 temp_PosWidth = NewFoundAnchor.Width;
                System.Int32 temp_PosHeight = NewFoundAnchor.Height;
                GdPicture14.GdPictureStatus a = m_Form.oGdPictureImaging.FindAnchor(filledForm.m_Image, (IntPtr)m_TemplateForm.m_AnchorID, GdPicture14.OMRMode.FavorSpeed, SearchArea.X, SearchArea.Y, SearchArea.Width, SearchArea.Height, ref temp_PosLeft, ref temp_PosTop, ref temp_PosWidth, ref temp_PosHeight, ref Accuracy);
                NewFoundAnchor.X = temp_PosLeft;
                NewFoundAnchor.Y = temp_PosTop;
                NewFoundAnchor.Width = temp_PosWidth;
                NewFoundAnchor.Height = temp_PosHeight;

                //2. Update the locations of the Fields according to the translation calculated by the new Anchor
                filledForm.AdjustFieldsAccordingToAnchor(NewFoundAnchor, m_TemplateForm.m_AnchorPosition);

                //3. Do OMR Processing
                if (m_TemplateForm.m_IsCircular == true) //If Field is Circulate
                {
                    if (m_TemplateForm.m_UseConfidence == true) //If Confidence is to be used
                    {
                        filledForm.Results = m_Form.oGdPictureImaging.OMRDetectMarks(filledForm.m_Image, filledForm.Fields, m_TemplateForm.m_NumberOfFields, m_TemplateForm.m_Sensitivity, filledForm.Confidence, m_TemplateForm.m_HasCharacter);
                    }
                    else
                    {
                        filledForm.Results = m_Form.oGdPictureImaging.OMRDetectMarks(filledForm.m_Image, filledForm.Fields, m_TemplateForm.m_NumberOfFields, m_TemplateForm.m_HasCharacter);
                    }
                }
                else //Oval shaped Fields
                {
                    if (m_TemplateForm.m_UseConfidence == true) //If Confidence is to be used
                    {
                        filledForm.Results = m_Form.oGdPictureImaging.OMRDetectOvalMarks(filledForm.m_Image, filledForm.Fields, m_TemplateForm.m_NumberOfFields, m_TemplateForm.m_Sensitivity, filledForm.Confidence, m_TemplateForm.m_HasCharacter);
                    }
                    else
                    {
                        filledForm.Results = m_Form.oGdPictureImaging.OMRDetectOvalMarks(filledForm.m_Image, filledForm.Fields, m_TemplateForm.m_NumberOfFields, m_TemplateForm.m_HasCharacter);
                    }
                }

                //Ignore results that are less than confidence
                if (m_TemplateForm.m_UseConfidence == true) //If Confidence is to be used
                {
                    for (int k = 0; k <= m_TemplateForm.m_NumberOfFields - 1; k++)
                    {
                        if (filledForm.Confidence[k] < m_TemplateForm.m_MinimumConfidence)
                        {
                            filledForm.Confidence[k] = 0;
                        }
                    }
                }
            }
        }
    }

}
