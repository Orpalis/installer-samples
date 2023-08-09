Imports GdPicture14

Public Class frmProperties

    Private Sub frmProperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ImageID As Integer = frmMain.getNativeImage()
        Using oGdPictureImaging As New GdPictureImaging
            Dim tagsCount As Integer = oGdPictureImaging.DicomGetTagsCount(ImageID)
            For i As Integer = 0 To tagsCount - 1
                Dim tagID As String = "<" + Hex(oGdPictureImaging.DicomGetTagGroup(ImageID, i)).PadLeft(4, "0"c) + "," + Hex(oGdPictureImaging.DicomGetTagElement(ImageID, i)).PadLeft(4, "0"c) + ">"
                DataGridView1.Rows.Add(New Object() {tagID, oGdPictureImaging.DicomGetTagDescription(ImageID, i), oGdPictureImaging.DicomGetTagValue(ImageID, i)})
            Next
        End Using
    End Sub

End Class