Option Explicit On
Option Strict On

Public Class FilledForm

    Public m_Image As Integer 'Image, has to be cleared by owner
    Public m_FoundAnchor As Rectangle 'Position of Anchor on FilledForm
    Public Fields() As Rectangle 'Rectangles Surrounding the OMR fields
    Dim m_NumberOfFields As Integer
    Public Results() As Integer 'Array to hold results of OMR image
    Public Confidence() As Integer ' Array for confidence of each field result

    'Constructor
    Public Sub New(ByRef Image As Integer, ByVal NumberOfFields As Integer, ByRef TemplateFields As List(Of Rectangle))
        m_Image = Image
        m_NumberOfFields = NumberOfFields
        ReDim Fields(NumberOfFields)
        ReDim Results(NumberOfFields)
        ReDim Confidence(NumberOfFields)
        CopyFieldsFromTemplate(TemplateFields)
    End Sub

    'Copies the Coordinates of the OMR Fields from the TemplateForm
    Public Sub CopyFieldsFromTemplate(ByRef TemplateFields As List(Of Rectangle))
        Dim rect As Rectangle
        Dim counter As Integer = 0

        For Each rect In TemplateFields
            Fields(counter) = rect
            counter += 1
        Next
    End Sub

    'Adjust the Field Positions in the Form depending on the location the anchor was found on it
    Public Sub AdjustFieldsAccordingToAnchor(ByVal NewAnchorPosition As Rectangle, ByVal TemplateAnchorPosition As Rectangle)
        m_FoundAnchor = NewAnchorPosition
        'Calculate Difference in Position between Anchor Found on Filled Form and Original Anchor On Template Form
        Dim Left As Integer = NewAnchorPosition.X - TemplateAnchorPosition.X
        Dim Top As Integer = NewAnchorPosition.Y - TemplateAnchorPosition.Y

        'Add Difference to Current Filled Form Fields Positions
        For i As Integer = 0 To m_NumberOfFields
            Fields(i).X += Left
            Fields(i).Y += Top
        Next
    End Sub
End Class
