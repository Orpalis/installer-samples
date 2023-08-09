Option Explicit On
Option Strict On

Public Class TemplateForm

    Public m_Image As Integer 'Template Form Image Identifier
    'Anchor ID and Positions
    Public m_AnchorID As IntPtr
    Public m_AnchorPosition As Rectangle

    'List to contain Field Positions
    Public m_Fields As List(Of Rectangle)

    'OMR Recognition Process Options
    Public m_IsCircular As Boolean 'Whether OMR fields are circular and checkboxes(True) or Oval(False)
    Public m_HasCharacter As Boolean 'Whether OMR field has a character inside of it or it is empty
    Public m_UseConfidence As Boolean 'Whether to use Confidence in the OMR Recognition Process or not
    Public m_Sensitivity As Double 'Amount of Sinsitivity to be used in OMR Recognition Process if m_UseConfidence is set to True
    Public m_MinimumConfidence As Integer 'Minimum Confidence to accept a value as CHECKED

    'Counters
    Public m_NumberOfFields As Integer

    Public Sub New()
        m_AnchorPosition = New Rectangle(0, 0, 0, 0)
        m_Fields = New List(Of Rectangle)
        m_IsCircular = True
        m_HasCharacter = False
        m_UseConfidence = False
        m_Sensitivity = 0.5
        'Initialize Counters
        m_NumberOfFields = 0
    End Sub

    Public Sub Clear()
        'NOTE IMPORTANT: m_Image and m_AnchorID have to be cleared outside the scope of the object, because they are owned by oGdPictureImaging
        'which is a member of the GUIManager instance
        m_AnchorPosition = New Rectangle(0, 0, 0, 0)

        m_IsCircular = True
        m_HasCharacter = False
        m_UseConfidence = False
        m_Sensitivity = 0.5
        m_NumberOfFields = 0
        m_Fields.Clear()
    End Sub

    '- To be called each time a new Rectangle is drawn (Handled by MouseUp Event in the TemplateForm GdViewer)
    '- If multiple fields are added with one Rectangle, the MouseUp event will split those accordingly to the desired number of fields, 
    '   and AddField will be called multiple times.
    Public Sub AddField(ByVal Rect As Rectangle)
        m_Fields.Add(Rect)
        m_NumberOfFields += 1
    End Sub

    'Updates a Fields info
    'Called upon RegionEdited By User
    Public Sub UpdateField(ByVal FieldNumber As Integer, ByVal RECT As Rectangle)
        Dim r As Rectangle = m_Fields(FieldNumber)
        r.X = RECT.X
        r.Y = RECT.Y
        r.Width = RECT.Width
        r.Height = RECT.Height
        m_Fields(FieldNumber) = r
    End Sub

    'Update Anchor, to be called on creation of Anchor, and any change occuring to the Anchor Rectangle (Handled by RegionEditedByUser event)
    Public Sub UpdateAnchor(ByVal Anchor As IntPtr, ByVal Position As Rectangle)
        m_AnchorID = Anchor
        m_AnchorPosition = Position
    End Sub
End Class
