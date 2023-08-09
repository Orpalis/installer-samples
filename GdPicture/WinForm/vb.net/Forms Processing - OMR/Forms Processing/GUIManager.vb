Option Strict On
Option Explicit On


Imports GdPicture14
Imports System.IO
'GUIManager controls all the GUI and the communication between UI elements and internal resources
Public Class GUIManager

    'Structure to Hold Anchor Region and OMR Fields Viewer Regions
    Public Structure ViewerRegions
        'Anchor Region
        Public AnchorRegion As Integer
        'Field Regions
        Public FieldRegions As List(Of Integer)
    End Structure

    'Template Anchor and Field Viewer Regions
    Private m_TemplateRegions As ViewerRegions
    'Filled Form Anchor and Field Regions
    Private m_FilledFormsRegions As ViewerRegions

    'ProcessForms instance for Anchor and OMR processing functions
    Private m_ProcessForms As ProcessForms

    'Variable to indicate which stage of the Template Form Set Up is currentely selected
    '1. Load Template Form
    '2. Select Anchor
    '3. Add Fields
    '4. Add Single Field
    '5. Add Multiple Field
    Dim m_CurrentStage As Integer
    'Variable to indicate which stage of the Template Form Set Up is most reached
    Dim m_StageReached As Integer

    'Variable to see if Anchor Region has been drawn or not
    Dim m_IsAnchorSet As Boolean

    'Structure to indicate how Field Regions are related to each other
    'Single Fields will have values 1 and 1
    Public Structure FieldsGrouping
        Public Sub New(ByVal Q As Integer, ByVal F As Integer)
            NumberOfFields = F
            NumberOfQuestion = Q
        End Sub
        'Number of Questions in this instance
        Public NumberOfQuestion As Integer
        'Number of Fields Per Question In this instance
        Public NumberOfFields As Integer
    End Structure

    'List of RegionCount that will be used to display results
    'Each added field whether multiple or single will add a new element to the list indicating the Fields Grouping
    'Single Fields will indicate 1 question and 1 field
    Dim m_FieldsGrouping As List(Of FieldsGrouping)

    'Variables to Hold Number Of Questions and Number of Fields Per Question in Each Multiple Field 
    Dim m_NumberOfQuestions As Integer
    Dim m_NumberOfFieldsPerQuestion As Integer

    'Reference to Main Form (Form1)
    Dim m_Form As Form1
    'Constructor: Passing Main Form to GUIManager As Reference
    Public Sub New(ByRef FormReference As Form1)
        m_Form = FormReference
        m_ProcessForms = New ProcessForms(FormReference)
        m_FilledFormsRegions.FieldRegions = New List(Of Integer)
        m_TemplateRegions.FieldRegions = New List(Of Integer)
        m_FieldsGrouping = New List(Of FieldsGrouping)
        m_CurrentStage = 0
        m_StageReached = 0
        m_IsAnchorSet = False
        m_NumberOfQuestions = 0
        m_NumberOfFieldsPerQuestion = 0
    End Sub

    'New Project
    Public Sub NewProject()
        ClearFilledForms()
        ClearTemplateForm()
        ClearResources()
        m_Form.TableLayoutPanelData.Controls.Remove(m_Form.processFormsPanel)
        m_Form.TableLayoutPanelData.Controls.Remove(m_Form.formSetUpPanel)
        m_Form.formSetUpButton.FlatStyle = FlatStyle.System
        m_Form.processFormsButton.FlatStyle = FlatStyle.System
        m_Form.formSetUpButton.Visible = True
        m_Form.processFormsButton.Visible = True
    End Sub

    'Close Project
    Public Sub CloseProject()
        ClearFilledForms()
        ClearTemplateForm()
        ClearResources()
        m_Form.formSetUpButton.Visible = False
        m_Form.processFormsButton.Visible = False
        m_Form.TableLayoutPanelData.Controls.Remove(m_Form.processFormsPanel)
        m_Form.TableLayoutPanelData.Controls.Remove(m_Form.formSetUpPanel)
    End Sub

    'Clear ALL GUI Resources
    Public Sub ClearResources()
        'Clearing Template Viewer regions
        m_Form.formViewer.RemoveAllRegions()
        'Clearing Template Image
        m_Form.formViewer.Clear()
        m_Form.formViewer.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
        'Resetting GUI Resources
        m_Form.hasCharacter.Checked = False
        m_Form.checkORCircle.Checked = True
        m_Form.oval.Checked = False
        m_Form.sensitivity.Value = 50
        m_Form.minConfidenceValue.Value = 50
        m_Form.useConfidence.Checked = False
        m_Form.selectAnchorButton.Visible = False
        m_Form.addFieldsButton.Visible = False
        m_IsAnchorSet = False
        'Restting counters
        m_NumberOfQuestions = 0
        m_NumberOfFieldsPerQuestion = 0
        m_FieldsGrouping.Clear()
    End Sub

    'Clearing Filled forms and their related GUI
    Public Sub ClearFilledForms()
        m_ProcessForms.ReInitializeForms()
        ClearFilledFormsGUI()
    End Sub

    'Clears Filled Forms related GUI
    Private Sub ClearFilledFormsGUI()
        m_Form.imagesViewer.RemoveAllRegions()
        m_Form.imagesViewer.Clear()
        m_FilledFormsRegions.AnchorRegion = 0
        m_FilledFormsRegions.FieldRegions.Clear()
        m_Form.ListBox1.Items.Clear()
        m_Form.resultsTextBox.Clear()
    End Sub

    'Clearing Template Form and its related GUI and resources
    Public Sub ClearTemplateForm()
        m_ProcessForms.ClearTemplate()
        ClearTemplateFormGUI()
    End Sub

    'Clears Template Form related GUI and resources
    Private Sub ClearTemplateFormGUI()
        m_Form.formViewer.RemoveAllRegions()
        m_Form.formViewer.Clear()
        m_TemplateRegions.AnchorRegion = 0
        m_TemplateRegions.FieldRegions.Clear()
        ClearResources()
    End Sub


    'Sets all OMR Field Regions to Uneditable
    Private Sub DisableTemplateViewerFieldsRegions()
        Dim RegionID As Integer
        For Each RegionID In m_TemplateRegions.FieldRegions
            m_Form.formViewer.SetRegionEditable(RegionID, False)
        Next
    End Sub

    'Sets all OMR Field Regions to Editable
    Private Sub EnableTemplateViewerFieldsRegions()
        Dim RegionID As Integer
        For Each RegionID In m_TemplateRegions.FieldRegions
            m_Form.formViewer.SetRegionEditable(RegionID, True)
        Next
    End Sub

    Public Function RegionToBeDrawn() As Boolean
        'Check if Field Regions have to be drawn but have not been yet
        'We implement this by checking if the current stage is Add Single Region = 4 or Add Multiple Region = 5
        If m_CurrentStage = 4 Or m_CurrentStage = 5 Then
            MessageBox.Show("You still have to draw your region!!", " ", MessageBoxButtons.OK, MessageBoxIcon.None, _
            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            Return True
        End If
        Return False
    End Function

    '''''''''''''EVENTS HANDLERS'''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''
    'Form Set Up GUI Events
    '

    'Function to Handle Clicking the Form Setup Button click
    Public Sub OpenFormSetUP()
        'Check if Field Regions have to be drawn but have not been yet
        If RegionToBeDrawn() Then
            Return
        End If
        'Checking whether Filled Forms Have been loaded and Processed
        'If Filled Forms have been processed, asking user if he is willing to lose proccssed data and information
        If m_ProcessForms.m_IsProcessed = True Then
            If MessageBox.Show("You will lose processed data if you return to Form Setup, are you sure?", "Cancel Results?", MessageBoxButtons.OKCancel, _
                        Nothing, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.OK Then
                'Clearing Filled Forms and their GUI resources
                ClearFilledForms()
            Else
                Return
            End If
        End If

        'Removing the Processing Forms GUI Panel
        m_Form.TableLayoutPanelData.Controls.Remove(m_Form.processFormsPanel)
        'Reinstating the Form SetuUp GUI Panel
        m_Form.TableLayoutPanelData.Controls.Add(m_Form.formSetUpPanel)


        'Adjusting Button Styles
        m_Form.formSetUpButton.FlatStyle = FlatStyle.Flat
        m_Form.processFormsButton.FlatStyle = FlatStyle.System

        'Prompting User to Load Template Form Image if no such Image is available (First time in the project)
        If Not m_ProcessForms.IsTemplateFormLoaded() Then
            LoadTemplateForm()
        End If
    End Sub

    'Handles LoadForm button
    'Prompts User to select Template Form Image
    Public Sub LoadTemplateForm()
        'Check if Field Regions have to be drawn but have not been yet
        If RegionToBeDrawn() Then
            Return
        End If

        'Asking user if he wants to cancel his Template Form Set Up
        If m_ProcessForms.m_TemplateForm.m_Image <> 0 Then
            If MessageBox.Show("Are you sure you want to cancel your current template form set up?", "Cancel Form?", MessageBoxButtons.OKCancel, _
                        Nothing, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.OK Then
                ClearTemplateForm()
            Else
                Return
            End If
        End If

        'Adjusting Button Styles
        m_Form.loadFormButton.FlatStyle = FlatStyle.Flat
        m_Form.selectAnchorButton.FlatStyle = FlatStyle.System
        m_Form.addFieldsButton.FlatStyle = FlatStyle.System

        'Making the regions uneditable
        DisableTemplateViewerFieldsRegions()
        m_Form.addFieldsPanel.Visible = False
        m_Form.formViewer.SetRegionEditable(m_TemplateRegions.AnchorRegion, False)

        'Loading Image
        m_ProcessForms.m_TemplateForm.m_Image = m_Form.oGdPictureImaging.CreateGdPictureImageFromFile("")
        If m_ProcessForms.m_TemplateForm.m_Image <> 0 Then
            m_Form.formViewer.DisplayFromGdPictureImage(m_ProcessForms.m_TemplateForm.m_Image)
        Else
            MessageBox.Show("Error:" + m_Form.oGdPictureImaging.GetStat().ToString())
            Return
        End If

        m_CurrentStage = 1
        m_StageReached = 1
        m_IsAnchorSet = False
        m_Form.selectAnchorButton.Visible = True
        'Moving to next Stage, prompting the user to select anchor
        SelectAnchor()
    End Sub

    'Sets the current state to the Anchor Selection on the Template Form
    Public Sub SelectAnchor()
        'Check if Field Regions have to be drawn but have not been yet
        If RegionToBeDrawn() Then
            Return
        End If
        'Disabling Fields Regions (if they exist) to bring focus only to Anchor Region
        DisableTemplateViewerFieldsRegions()

        'Changing button styles
        m_Form.loadFormButton.FlatStyle = FlatStyle.System
        m_Form.selectAnchorButton.FlatStyle = FlatStyle.Flat
        m_Form.addFieldsButton.FlatStyle = FlatStyle.System
        'Changing current stage in Template Form Set Up
        m_CurrentStage = 2 'Select Anchor State
        'Changing Max stage reached in Template Form Set Up
        If m_StageReached < 2 Then 'If first time Select Anchor has been reached
            m_StageReached = 2
        End If

        m_Form.addFieldsPanel.Visible = False
        m_Form.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection
        If m_IsAnchorSet = True Then
            m_Form.formViewer.SetRegionEditable(m_TemplateRegions.AnchorRegion, True)
        End If
    End Sub

    'Sets the current state to the Anchor Selection on the Template Form
    Public Sub AddFields()
        'Check if Field Regions have to be drawn but have not been yet
        If RegionToBeDrawn() Then
            Return
        End If
        EnableTemplateViewerFieldsRegions()

        m_Form.addFieldsPanel.Visible = True
        'Changing button styles
        m_Form.loadFormButton.FlatStyle = FlatStyle.System
        m_Form.selectAnchorButton.FlatStyle = FlatStyle.System
        m_Form.addFieldsButton.FlatStyle = FlatStyle.Flat

        'Changing current stage in Template Form Set Up
        m_CurrentStage = 3 'Add Fields Stage
        'Changing Max stage reached in Template Form Set Up
        If m_StageReached < 3 Then 'If first time Add Fields has been reached
            m_StageReached = 3
        End If
        m_Form.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
        If m_IsAnchorSet = True Then
            m_Form.formViewer.SetRegionEditable(m_TemplateRegions.AnchorRegion, False)
        End If
    End Sub

    'Loading new Form
    'Clears old form GUI and Data if form already exists upon approval of the user
    Public Sub OpenProcessForms()
        If m_ProcessForms.m_TemplateForm.m_NumberOfFields = 0 Then
            MessageBox.Show("You have not added any OMR Field Regions", " ", MessageBoxButtons.OK, MessageBoxIcon.None, _
            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            Return
        End If
        'Removing Form Set Up Panel
        m_Form.TableLayoutPanelData.Controls.Remove(m_Form.formSetUpPanel)
        'Reinstating Process Forms Panel
        m_Form.TableLayoutPanelData.Controls.Add(m_Form.processFormsPanel)
        'Changing Button Styles
        m_Form.formSetUpButton.FlatStyle = FlatStyle.System
        m_Form.processFormsButton.FlatStyle = FlatStyle.Flat


    End Sub

    'Handles checlOrCircle click event
    Public Sub CheckOrCircle_CheckedChanged()
        If m_Form.checkORCircle.Checked = True Then
            m_ProcessForms.m_TemplateForm.m_IsCircular = True
        Else
            m_ProcessForms.m_TemplateForm.m_IsCircular = False
        End If
    End Sub

    'Handles oval click event
    Public Sub Oval_CheckedChanged()
        If m_Form.oval.Checked = True Then
            m_ProcessForms.m_TemplateForm.m_IsCircular = False
        Else
            m_ProcessForms.m_TemplateForm.m_IsCircular = True
        End If
    End Sub

    'Handles HasCharacter click event
    Public Sub HasCharacter_CheckedChanged()
        If m_Form.hasCharacter.Checked = True Then
            m_ProcessForms.m_TemplateForm.m_HasCharacter = True
        Else
            m_ProcessForms.m_TemplateForm.m_HasCharacter = False
        End If
    End Sub

    'Handles UseConfice click event
    Public Sub UseConfidence_CheckedChanged()
        If m_Form.useConfidence.Checked = True Then
            m_ProcessForms.m_TemplateForm.m_UseConfidence = True
            m_Form.confidenceGroup.Enabled = True
        Else
            m_ProcessForms.m_TemplateForm.m_UseConfidence = False
            m_Form.confidenceGroup.Enabled = False
        End If
    End Sub

    'Handles Sensitivity scroll event
    Public Sub Sensitivity_Scroll()
        m_ProcessForms.m_TemplateForm.m_Sensitivity = m_Form.sensitivity.Value / 100
        m_Form.sensitivityValue.Text = m_Form.sensitivity.Value.ToString
    End Sub

    'Handles Min Confidence Value Change
    Public Sub MinConfidenceValue_Changed()
        m_ProcessForms.m_TemplateForm.m_MinimumConfidence = CInt(m_Form.minConfidenceValue.Value)
    End Sub

    'Handles Add Single Field Button Click
    Public Sub AddSingleField()
        If RegionToBeDrawn() Then
            Return
        End If
        'Setting Template Form Setup Stage
        m_CurrentStage = 4 'Add Multiple Fields Stage
        DisableTemplateViewerFieldsRegions()
        m_Form.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection
        m_Form.oGdPictureImaging.SetTransparency(m_ProcessForms.m_TemplateForm.m_Image, -150)
        m_Form.formViewer.Redraw()
        m_FieldsGrouping.Add(New FieldsGrouping(1, 1))
    End Sub

    'Handles Add Multiple Fields Button Click
    Public Sub AddMultipleFields()
        If RegionToBeDrawn() Then
            Return
        End If

        'Instating Add Mulitple Fields Dialog To Gather information about number of questions and number of fields per question
        Dim AddFieldsDialog As New AddMultipleOMRFieldDialog
        m_Form.Enabled = False

        Dim Result As DialogResult = AddFieldsDialog.ShowDialog()
        m_Form.Enabled = True
        If Result = DialogResult.Cancel Then
            Return
        End If
        'Setting Template Form Setup Stage
        m_CurrentStage = 5 'Add Multiple Fields Stage

        'Update Number of Question and Number of Fields Per Question
        m_NumberOfQuestions = CInt(AddFieldsDialog.numberOfQuestions.Value)
        m_NumberOfFieldsPerQuestion = CInt(AddFieldsDialog.numberOfFieldsPerQuestion.Value)
        m_FieldsGrouping.Add(New FieldsGrouping(m_NumberOfQuestions, m_NumberOfFieldsPerQuestion))
        'Disabling all previous regions
        DisableTemplateViewerFieldsRegions()
        'Setting Mouse To Area Selection
        m_Form.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection
        m_Form.oGdPictureImaging.SetTransparency(m_ProcessForms.m_TemplateForm.m_Image, -150)
        m_Form.formViewer.Redraw()
    End Sub

    'Handles Mouse Up Event on the Template Form Viewer
    Public Sub MouseUP()
        If m_CurrentStage = 2 Then 'If it is Select Anchor Stage
            If m_Form.formViewer.IsRect Then 'If an Anchor Region has been selected
                If m_IsAnchorSet = True Then 'If there was a previous Anchor Set, delete it
                    m_Form.formViewer.RemoveRegionByID(m_TemplateRegions.AnchorRegion)
                    If m_ProcessForms.m_TemplateForm.m_AnchorID <> IntPtr.Zero Then
                        m_Form.oGdPictureImaging.DeleteAnchorTemplate(m_ProcessForms.m_TemplateForm.m_AnchorID)
                    End If
                    m_IsAnchorSet = False
                End If
                'Variables to hold Anchor Region Location
                Dim AnchorLeft As Integer
                Dim AnchorTop As Integer
                Dim AnchorWidth As Integer
                Dim AnchorHeight As Integer

                'Getting the coordinates of the Rectangle Of Selection on the Document Displayed
                m_Form.formViewer.GetRectCoordinatesOnDocument(AnchorLeft, AnchorTop, AnchorWidth, AnchorHeight)
                'Clearing the Rectangle Of Selection
                m_Form.formViewer.ClearRect()

                'Adding a Region in Place of the Rectangle of Selection
                m_TemplateRegions.AnchorRegion = m_Form.formViewer.AddRegion("anchor", AnchorLeft, AnchorTop, _
                                                        AnchorWidth, AnchorHeight, _
                                                        GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Green)
                m_Form.formViewer.SetRegionBorderWidth(m_TemplateRegions.AnchorRegion, 1)
                m_Form.formViewer.SetRegionBorderColor(m_TemplateRegions.AnchorRegion, Color.Blue)
                m_Form.formViewer.Redraw()

                'Creating a new AnchorID
                Dim AnchorID As IntPtr = m_Form.oGdPictureImaging.CreateAnchorTemplate(m_ProcessForms.m_TemplateForm.m_Image,
                                                                                            AnchorLeft,
                                                                                            AnchorTop,
                                                                                            AnchorWidth,
                                                                                            AnchorHeight)
                'Checking if Creating Anchor Succeeded
                If AnchorID = IntPtr.Zero Then
                    MessageBox.Show("Error" + m_Form.oGdPictureImaging.GetStat().ToString())
                    m_Form.formViewer.RemoveRegionByID(m_TemplateRegions.AnchorRegion)
                    Return
                End If


                'Update Anchor Information in Tempalte Form
                Dim RECT As Rectangle
                RECT.X = m_Form.formViewer.GetRegionLeftPixels(m_TemplateRegions.AnchorRegion)
                RECT.Y = m_Form.formViewer.GetRegionTopPixels(m_TemplateRegions.AnchorRegion)
                RECT.Width = m_Form.formViewer.GetRegionWidthPixels(m_TemplateRegions.AnchorRegion)
                RECT.Height = m_Form.formViewer.GetRegionHeightPixels(m_TemplateRegions.AnchorRegion)
                m_ProcessForms.m_TemplateForm.UpdateAnchor(AnchorID, RECT)


                'm_FormSettings.UpdateAnchorSearchArea()
                m_IsAnchorSet = True
                m_Form.addFieldsButton.Visible = True
                'drawRectanglesButton.Visible = True

            End If
        End If
        If m_CurrentStage = 4 Then 'Add Single Region
            If m_Form.formViewer.IsRect Then 'If a Rectangle Of Selection has been made
                Dim Left As Integer
                Dim Top As Integer
                Dim Width As Integer
                Dim Height As Integer
                'Getting the Rectangle Of Selection Coordinates
                m_Form.formViewer.GetRectCoordinatesOnDocument(Left, Top, Width, Height)
                'Clearing the Rectangle Of Selection
                m_Form.formViewer.ClearRect()

                Dim NumberOfCurrentRegion As Integer = m_ProcessForms.m_TemplateForm.m_NumberOfFields + 1

                'Adding a Region in place of the Rectangle (OMR Field)
                m_TemplateRegions.FieldRegions.Add(m_Form.formViewer.AddRegion(NumberOfCurrentRegion.ToString(), Left, Top, _
                                                        Width, Height, GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, _
                                                        Color.Aqua))

                m_Form.formViewer.SetRegionBorderWidth(m_TemplateRegions.FieldRegions(NumberOfCurrentRegion - 1), 1)
                m_Form.formViewer.SetRegionBorderColor(m_TemplateRegions.FieldRegions(NumberOfCurrentRegion - 1), Color.Red)
                m_Form.formViewer.Redraw()

                'Adding Field Information To Template
                Dim RECT As Rectangle
                RECT.X = Left
                RECT.Y = Top
                RECT.Width = Width
                RECT.Height = Height
                m_ProcessForms.m_TemplateForm.AddField(RECT)
                m_Form.totalNumberOfFieldsLabel.Text = m_ProcessForms.m_TemplateForm.m_NumberOfFields.ToString()

                m_CurrentStage = 3 'Setting Current Stage Back To Add Fields
                m_Form.formViewer.MouseMode = ViewerMouseMode.MouseModePan
                m_Form.oGdPictureImaging.SetTransparency(m_ProcessForms.m_TemplateForm.m_Image, 255)
                m_Form.formViewer.Redraw()
                'Enabling All Regions for Editing
                EnableTemplateViewerFieldsRegions()
            End If
        End If
        If m_CurrentStage = 5 Then 'Add Multiple OMR Fields at once
            If m_Form.formViewer.IsRect Then 'If a Rectangle Of Selection has been made
                Dim Left As Integer
                Dim Top As Integer
                Dim Width As Integer
                Dim Height As Integer
                'Getting the Rectangle Of Selection Coordinates
                m_Form.formViewer.GetRectCoordinatesOnDocument(Left, Top, Width, Height)
                'Clearing the Rectangle Of Selection
                m_Form.formViewer.ClearRect()

                'Now we need to segment the rect according to the Number of Questions and Number of Fields Per Question
                'Number of Field Regions = Number Of Questions * Number of Fields Per Question
                'EXAMPLE: If Bellow rectangle contains 2 questions and 3 fields per question
                '**********
                '*        *
                '*        *
                '*        *
                '*   1    * 1 Question 1 Field
                '*        * 
                '*        *
                '*        *
                '**********
                'AFTER SEGMENTATION IT WILL BECOME
                '**********
                '*  *  *  *
                '*11*12*13* 
                '*  *  *  *
                '********** 2 Questions 3 Fields Each
                '*  *  *  *
                '*21*22*23*
                '*  *  *  *
                '**********
                'The above is accomplished via the Following Formulas:
                'LEFT, TOP, WIDTH, HEIGHT are the dimenstions of the Original BIG region
                'sW and sH are the width and height of the small regions (equal over all)
                'Sep is the seperation Horizontally and Vertically between Regions: CONSTANT at 2
                'sLeft(i), sTop(i) are the Left and Top of each small region
                'smW = (Width / Number of Fields Per Question)
                'smH = (Height/ Number of Questions)
                'smLeft(i) = LEFT + (smW * (i  mod Number Of Fields Per Question))
                'smTop(i)  = TOP  + (smH * QuestionLevel)
                Dim smW As Integer = CInt(Math.Floor((CSng(Width) / m_NumberOfFieldsPerQuestion) + 0.5))
                Dim smH As Integer = CInt(Math.Floor((CSng(Height) / m_NumberOfQuestions) + 0.5))

                Dim CurrentNumberOfRegions As Integer = m_NumberOfFieldsPerQuestion * m_NumberOfQuestions

                Dim QuestionLevel As Integer = 0
                'Adding Regions in place of the Rectangle (OMR Field)
                For i As Integer = 0 To CurrentNumberOfRegions - 1
                    Dim NumberOfCurrentRegion As Integer = m_ProcessForms.m_TemplateForm.m_NumberOfFields + 1
                    Dim Loc As Integer = i Mod m_NumberOfFieldsPerQuestion
                    Dim smLeft As Integer = Left + (smW * Loc)

                    If i <> 0 And i Mod m_NumberOfFieldsPerQuestion = 0 Then
                        QuestionLevel += 1
                    End If
                    Dim smTop As Integer = Top + (smH * QuestionLevel)
                    Dim RegionID As Integer = m_Form.formViewer.AddRegion(NumberOfCurrentRegion.ToString(), smLeft, smTop, _
                                                       smW, smH, GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, _
                                                       Color.Aqua)
                    m_TemplateRegions.FieldRegions.Add(RegionID)
                    m_Form.formViewer.SetRegionBorderWidth(RegionID, 1)
                    m_Form.formViewer.SetRegionBorderColor(RegionID, Color.Red)

                    'Adding Field Information To Template
                    Dim RECT As Rectangle
                    RECT.X = smLeft
                    RECT.Y = smTop
                    RECT.Width = smW
                    RECT.Height = smH
                    m_ProcessForms.m_TemplateForm.AddField(RECT)
                Next
                m_Form.formViewer.Redraw()
                'Updating total number of fields label
                m_Form.totalNumberOfFieldsLabel.Text = m_ProcessForms.m_TemplateForm.m_NumberOfFields.ToString()
                m_CurrentStage = 3 'Setting Current Stage Back To Add Fields
                'Setting Mouse Mode to Pan
                m_Form.formViewer.MouseMode = ViewerMouseMode.MouseModePan
                m_NumberOfFieldsPerQuestion = 0
                m_NumberOfQuestions = 0
                m_Form.oGdPictureImaging.SetTransparency(m_ProcessForms.m_TemplateForm.m_Image, 255)
                m_Form.formViewer.Redraw()
                'Enabling All Regions For Editing
                EnableTemplateViewerFieldsRegions()
            End If
        End If
    End Sub

    'Handles Region Edited By User
    'For Regions of the Template Form, Regions on the Filled Forms are LOCKED, thus cannot be edited
    Public Sub RegionEditedByUser(ByVal RegionID As Integer)
        If m_CurrentStage = 2 Then 'Set Anchor and Edit Anchor Stage

            'Getting the Region's New Coordinates
            Dim RECT As Rectangle
            RECT.Width = m_Form.formViewer.GetRegionWidthPixels(RegionID)
            RECT.Height = m_Form.formViewer.GetRegionHeightPixels(RegionID)
            RECT.X = m_Form.formViewer.GetRegionLeftPixels(RegionID)
            RECT.Y = m_Form.formViewer.GetRegionTopPixels(RegionID)

            'Deleting the Anchor ID if it exists and creating a new one with the new coordinates
            If m_ProcessForms.m_TemplateForm.m_AnchorID <> IntPtr.Zero Then m_Form.oGdPictureImaging.DeleteAnchorTemplate(m_ProcessForms.m_TemplateForm.m_AnchorID)
            Dim AnchorID As IntPtr = m_Form.oGdPictureImaging.CreateAnchorTemplate(m_ProcessForms.m_TemplateForm.m_Image,
                                                                                        RECT.X,
                                                                                        RECT.Y,
                                                                                        RECT.Width,
                                                                                        RECT.Height)
            If AnchorID = IntPtr.Zero Then
                MessageBox.Show("Error" + m_Form.oGdPictureImaging.GetStat().ToString())
                m_Form.formViewer.RemoveRegionByID(RegionID)
                Return
            End If

            'Update Anchorin the Template Form
            m_ProcessForms.m_TemplateForm.UpdateAnchor(AnchorID, RECT)

        Else 'Region Edited is a Field Region
            Dim i As Integer
            Dim pos As Integer = 0
            'Finding which Field corresponds to to the Region being edited
            'We loop through Filled Region IDs and compare the Edited Region ID to them
            For Each i In m_TemplateRegions.FieldRegions
                If i = RegionID Then
                    Exit For
                End If
                pos += 1
            Next
            'Getting the coordinates of the Region After being edited
            Dim RECT As Rectangle
            RECT.Width = m_Form.formViewer.GetRegionWidthPixels(RegionID)
            RECT.Height = m_Form.formViewer.GetRegionHeightPixels(RegionID)
            RECT.X = m_Form.formViewer.GetRegionLeftPixels(RegionID)
            RECT.Y = m_Form.formViewer.GetRegionTopPixels(RegionID)
            'Updating the Field info in the Template Form
            m_ProcessForms.m_TemplateForm.UpdateField(pos, RECT)
        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''
    'Handling of Process Forms Events
    ''''''''''''''''''''''''''''''''''''''''''
    '
    'Handles the click of Load Images Button
    Public Sub LoadImagesButton_Click()
        'If Images have been previously loaded, clear them
        If m_ProcessForms.m_ImagesLoaded = True Then
            ClearFilledForms()
        End If
        'Showint the open Dialog
        m_Form.OpenFileDialog1.Multiselect = True
        If m_Form.OpenFileDialog1.ShowDialog(m_Form) = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        For Each item As String In m_Form.OpenFileDialog1.FileNames
            'If file in folder is an image
            If GdPictureDocumentUtilities.GetDocumentFormat(item) <> GdPicture14.DocumentFormat.DocumentFormatUNKNOWN Then
                'Add Image Name to ListBox1
                m_Form.ListBox1.Items.Add(Path.GetFileNameWithoutExtension(item))
                'Create GdPicture Image
                Dim ImageID As Integer = m_Form.oGdPictureImaging.CreateGdPictureImageFromFile(item)
                'If GdPictureImage failed to create display error, and take out image name from ListBox
                If ImageID = 0 Then
                    MessageBox.Show("Error" + m_Form.oGdPictureImaging.GetStat().ToString())
                    m_Form.ListBox1.Items.Remove(Path.GetFileNameWithoutExtension(item))
                Else 'If GdPictureImage creation succeeded
                    'Add New Form and append Number of Filled Forms available
                    m_ProcessForms.AddForm(ImageID)
                    m_ProcessForms.m_NumberOfImages += 1
                End If
            End If
        Next
        'Setting Images Loaded to True
        If m_ProcessForms.m_NumberOfImages <> 0 Then
            m_ProcessForms.m_ImagesLoaded = True
        End If
    End Sub

    'Handles ListBox1 Selected Index Changed
    Public Sub ListBox1_SelectedIndexChanged()
        If m_Form.ListBox1.SelectedIndex <> -1 Then
            m_Form.imagesViewer.CloseDocument()
            'Clearing Filled Form RegionIDs
            m_FilledFormsRegions.FieldRegions.Clear()
            'Clearing Filled Form Regions from ImagesViewer
            m_Form.imagesViewer.RemoveAllRegions()
            'Displaying the selected Image
            m_Form.imagesViewer.DisplayFromGdPictureImage(m_ProcessForms.m_FilledForms(m_Form.ListBox1.SelectedIndex).m_Image)
            'If there is processed information:
            'Display Found Anchor Position
            'Display Filled Form Regions Shifted By Found Anchor Position
            If m_ProcessForms.m_IsProcessed = True Then
                'Add Regions
                Dim RECT As Rectangle
                For Each RECT In m_ProcessForms.m_FilledForms(m_Form.ListBox1.SelectedIndex).Fields
                    Dim RegionID As Integer = m_Form.imagesViewer.AddRegion("", RECT.X, RECT.Y, RECT.Width, RECT.Height, _
                    GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, _
                                                        Color.Aqua)
                    m_FilledFormsRegions.FieldRegions.Add(RegionID)

                    m_Form.imagesViewer.SetRegionBorderWidth(RegionID, 1)
                    m_Form.imagesViewer.SetRegionBorderColor(RegionID, Color.Red)
                    m_Form.imagesViewer.SetRegionEditable(RegionID, False)
                Next
                'Copy Filled Form Anchor Region 
                RECT = m_ProcessForms.m_FilledForms(m_Form.ListBox1.SelectedIndex).m_FoundAnchor
                'Drawing the Anchor Region
                m_FilledFormsRegions.AnchorRegion = m_Form.imagesViewer.AddRegion("", RECT.X, RECT.Y, RECT.Width, RECT.Height, _
                                                                                  GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Green)
                m_Form.imagesViewer.SetRegionBorderWidth(m_FilledFormsRegions.AnchorRegion, 1)
                m_Form.imagesViewer.SetRegionBorderColor(m_FilledFormsRegions.AnchorRegion, Color.Blue)
                m_Form.imagesViewer.SetRegionEditable(m_FilledFormsRegions.AnchorRegion, False)
                m_Form.imagesViewer.Redraw()

                'Clearing the Previous results
                m_Form.resultsTextBox.Clear()

                Dim ResPos As Integer = 0
                Dim counter As Integer = 0
                Dim pos As FieldsGrouping
                'Loop Through the Groupings of the Fields
                For Each pos In m_FieldsGrouping
                    counter += 1
                    Dim TotalFieldsNumber As Integer = pos.NumberOfQuestion * pos.NumberOfFields
                    Dim QuestionCounter As Integer = 0
                    m_Form.resultsTextBox.Text += Environment.NewLine
                    'For each new Grouped Fields, Write a new Region
                    m_Form.resultsTextBox.Text = m_Form.resultsTextBox.Text + "Region Number: '" + counter.ToString() + "'"

                    Dim LastResult As Integer = ResPos + TotalFieldsNumber
                    'Loop through Results Array of Filled Form
                    For i As Integer = ResPos To LastResult - 1
                        'If current result belongs to a new question
                        'Enter a new line
                        'Enter Q and the number of the qestion
                        If (i - ResPos) Mod pos.NumberOfFields = 0 Then
                            m_Form.resultsTextBox.Text += Environment.NewLine
                            QuestionCounter += 1
                            m_Form.resultsTextBox.Text = m_Form.resultsTextBox.Text + "'Q" + QuestionCounter.ToString + "': "
                        End If
                        'Print the results of the fields of the current question
                        m_Form.resultsTextBox.Text = m_Form.resultsTextBox.Text + m_ProcessForms.m_FilledForms(m_Form.ListBox1.SelectedIndex).Results(i).ToString()
                    Next i
                    ResPos += TotalFieldsNumber
                Next
            End If
        End If
    End Sub

    'Handles the OMR Images Button Click
    'Calls Upon the main OMR process
    Public Sub OMRImagesButton_Click()
        If m_ProcessForms.m_IsProcessed = True Then
            Return
        End If
        If m_ProcessForms.m_NumberOfImages = 0 Then
            Return
        End If

        m_ProcessForms.ProcessOMR()
        m_ProcessForms.m_IsProcessed = True
        m_Form.ListBox1.SelectedIndex = 0
    End Sub

End Class
