Option Explicit On
Option Strict On

Public Class ProcessForms

    Public m_IsProcessed As Boolean 'Whether current loaded images have been processed or not
    Public m_ImagesLoaded As Boolean 'Whether Images were loaded or not
    Public m_NumberOfImages As Integer 'Number of Total Filled Forms 
    Public m_FilledForms As List(Of FilledForm)
    Public m_TemplateForm As New TemplateForm
    Dim m_Form As Form1

    'Constructor
    'Takes reference to main form (Form1)
    Public Sub New(ByRef FormRef As Form1)
        m_ImagesLoaded = False
        m_IsProcessed = False
        m_FilledForms = New List(Of FilledForm)
        m_Form = FormRef
        m_NumberOfImages = 0
    End Sub

    'Returns whether TemplateForm is loaded or not
    Public Function IsTemplateFormLoaded() As Boolean
        If m_TemplateForm.m_Image = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Creates a Filled Form and adds it to m_FilledForms list
    Public Sub CreateFilledForms()

    End Sub

    'Clears the Template Form Data
    'Clears the Template Form relevant GUI
    'Called upon request of change of Template Form Image (Load Form Button)
    Public Sub ClearTemplate()
        m_TemplateForm.Clear()
        m_Form.oGdPictureImaging.ReleaseGdPictureImage(m_TemplateForm.m_Image)
        m_TemplateForm.m_Image = 0
        If m_TemplateForm.m_AnchorID <> IntPtr.Zero Then
            m_Form.oGdPictureImaging.DeleteAnchorTemplate(m_TemplateForm.m_AnchorID)
            m_TemplateForm.m_AnchorID = IntPtr.Zero
        End If
    End Sub

    'Clears Filled Forms Data
    'Called upon going back to Template Form Set Up after Processing Filled Forms
    'Called upon the Clear Images Button event
    Public Sub ReInitializeForms()
        m_ImagesLoaded = False
        m_IsProcessed = False
        Dim FilledFormInstance As FilledForm
        For Each FilledFormInstance In m_FilledForms
            m_Form.oGdPictureImaging.ReleaseGdPictureImage(FilledFormInstance.m_Image)
            FilledFormInstance.m_Image = 0
        Next
        m_FilledForms.Clear()
        m_NumberOfImages = 0
    End Sub

    'Adds a new Filled Form
    Public Sub AddForm(ByVal ImageID As Integer)
        Dim f As New FilledForm(ImageID, m_TemplateForm.m_NumberOfFields, m_TemplateForm.m_Fields)
        m_FilledForms.Add(f)
    End Sub

    'Calculates the Anchor Search Area
    'Search Area coordinates:
    ' Left = AnchorLeft- AnchorWidth/2
    ' Top = AnchorTop - AnchorHeight/2
    ' Width = AnchorWidth * 2
    ' Height = AnchorHeight * 2
    Private Function CalculateAnchorSearchArea() As Rectangle
        Dim RECT As Rectangle
        RECT.Width = CInt(2.5 * m_Form.formViewer.HorizontalResolution)
        RECT.Height = CInt(2.5 * m_Form.formViewer.VerticalResolution)
        RECT.X = CInt((m_TemplateForm.m_AnchorPosition.X + m_TemplateForm.m_AnchorPosition.Width / 2) - (RECT.Width / 2))
        RECT.Y = CInt((m_TemplateForm.m_AnchorPosition.Y + m_TemplateForm.m_AnchorPosition.Height / 2) - (RECT.Height / 2))
        Return RECT
    End Function

    'Performs the main OMR process
    Public Sub ProcessOMR()
        'Calculate Anchor Search Area
        Dim SearchArea As Rectangle = CalculateAnchorSearchArea()

        Dim NewFoundAnchor As Rectangle
        Dim Accuracy As Double
        Dim filledForm As FilledForm
        'Loop through filled forms
        For Each filledForm In m_FilledForms
            '1. Find Anchor Position and Update Filled Form
            Dim a As GdPicture14.GdPictureStatus = m_Form.oGdPictureImaging.FindAnchor(filledForm.m_Image, m_TemplateForm.m_AnchorID, GdPicture14.OMRMode.FavorSpeed,
                                                SearchArea.X, SearchArea.Y, SearchArea.Width, SearchArea.Height,
                                                NewFoundAnchor.X, NewFoundAnchor.Y, NewFoundAnchor.Width, NewFoundAnchor.Height, Accuracy)

            '2. Update the locations of the Fields according to the translation calculated by the new Anchor
            filledForm.AdjustFieldsAccordingToAnchor(NewFoundAnchor, m_TemplateForm.m_AnchorPosition)

            '3. Do OMR Processing
            If m_TemplateForm.m_IsCircular = True Then 'If Field is Circulate
                If m_TemplateForm.m_UseConfidence = True Then 'If Confidence is to be used
                    filledForm.Results = m_Form.oGdPictureImaging.OMRDetectMarks(filledForm.m_Image, filledForm.Fields,
                                           m_TemplateForm.m_NumberOfFields, m_TemplateForm.m_Sensitivity,
                                           filledForm.Confidence, m_TemplateForm.m_HasCharacter)
                Else
                    filledForm.Results = m_Form.oGdPictureImaging.OMRDetectMarks(filledForm.m_Image, filledForm.Fields,
                                          m_TemplateForm.m_NumberOfFields, m_TemplateForm.m_HasCharacter)
                End If
            Else 'Oval shaped Fields
                If m_TemplateForm.m_UseConfidence = True Then 'If Confidence is to be used
                    filledForm.Results = m_Form.oGdPictureImaging.OMRDetectOvalMarks(filledForm.m_Image, filledForm.Fields,
                                          m_TemplateForm.m_NumberOfFields, m_TemplateForm.m_Sensitivity,
                                          filledForm.Confidence, m_TemplateForm.m_HasCharacter)
                Else
                    filledForm.Results = m_Form.oGdPictureImaging.OMRDetectOvalMarks(filledForm.m_Image, filledForm.Fields,
                                           m_TemplateForm.m_NumberOfFields, m_TemplateForm.m_HasCharacter)
                End If
            End If

            'Ignore results that are less than confidence
            If m_TemplateForm.m_UseConfidence = True Then 'If Confidence is to be used
                For k As Integer = 0 To m_TemplateForm.m_NumberOfFields - 1
                    If filledForm.Confidence(k) < m_TemplateForm.m_MinimumConfidence Then
                        filledForm.Confidence(k) = 0
                    End If
                Next
            End If
        Next
    End Sub
End Class
