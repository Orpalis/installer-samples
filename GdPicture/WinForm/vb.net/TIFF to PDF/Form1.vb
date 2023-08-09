Imports GdPicture14
Imports System.IO

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager()
        oLicenseManager.RegisterKEY("XXX") 'Please replace XXX by a valid commercial or demo key.
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBrowsSrcFile.Click
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "TIFF File (*.tif)|*.tif;*.tiff"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtInputFile.Text = OpenFileDialog1.FileName
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBrowsDstFolder.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDstFolder.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click
        Try
            ProgressBar1.Value = 0
            ProgressBar1.Visible = True
            Using oGdPictureImaging As New GdPictureImaging

                If String.IsNullOrWhiteSpace(txtInputFile.Text) Then
                    MessageBox.Show("Please select an input image.")
                    Return
                End If

                If String.IsNullOrWhiteSpace(txtDstFolder.Text) Then
                    MessageBox.Show("Please select a valid destination folder.")
                    Return
                End If

                Dim ImageID As Integer = oGdPictureImaging.CreateGdPictureImageFromFile(txtInputFile.Text)

                If ImageID = 0 Then
                    MessageBox.Show(oGdPictureImaging.GetStat().ToString())
                    oGdPictureImaging.ReleaseGdPictureImage(ImageID)
                    Return
                End If

                Dim pageCount As Integer = oGdPictureImaging.GetPageCount(ImageID)

                Using oGdPicturePDF As New GdPicturePDF
                    If chkPdfa.Checked Then
                        oGdPicturePDF.NewPDF(PdfConformance.PDF_A_1b)
                    Else
                        oGdPicturePDF.NewPDF()
                    End If

                    ProgressBar1.Maximum = pageCount

                    Dim advancedCompression As PdfAdvancedImageCompression

                    If chkEnableMRC.Checked Then
                        advancedCompression = PdfAdvancedImageCompression.PdfAdvancedImageCompressionMRC
                    ElseIf chkEnableColorDetection.Checked Then
                        advancedCompression = PdfAdvancedImageCompression.PdfAdvancedImageCompressionColorDetection
                    Else
                        advancedCompression = PdfAdvancedImageCompression.PdfAdvancedImageCompressionNone
                    End If

                    oGdPicturePDF.SetCompressionForBitonalImage(PdfCompression.PdfCompressionJBIG2)
                    oGdPicturePDF.SetCompressionForColorImage(PdfCompression.PdfCompressionJPEG)

                    For pageNo As Integer = 1 To pageCount
                        oGdPictureImaging.SelectPage(ImageID, pageNo)
                        oGdPicturePDF.AddImageFromGdPictureImage(ImageID, advancedCompression)

                        If oGdPicturePDF.GetStat() <> GdPictureStatus.OK Then
                            MessageBox.Show("Error adding bitmap to the PDF. Status: " + oGdPicturePDF.GetStat().ToString())
                            oGdPicturePDF.CloseDocument()
                            oGdPictureImaging.ReleaseGdPictureImage(ImageID)
                            Return
                        End If

                        ProgressBar1.Value = pageNo
                        Application.DoEvents()
                    Next pageNo

                    Dim dstFile As String = txtDstFolder.Text + Path.GetFileNameWithoutExtension(txtInputFile.Text) + ".pdf"
                    oGdPicturePDF.SaveToFile(dstFile)

                    If oGdPicturePDF.GetStat() <> GdPictureStatus.OK Then
                        MessageBox.Show("Error saving PDF. Status: " + oGdPicturePDF.GetStat().ToString())
                    Else
                        MessageBox.Show(dstFile + " has been successfully  created.")
                    End If

                    oGdPicturePDF.CloseDocument()
                    oGdPictureImaging.ReleaseGdPictureImage(ImageID)
                End Using
            End Using

        Finally
            ProgressBar1.Visible = False
        End Try
    End Sub
End Class
