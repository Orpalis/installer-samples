Option Strict On
Option Explicit On

Imports GdPicture14

Public Class Form1
    Private oGdPictureImaging As New GdPictureImaging



    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        TextBox3.Text = Application.StartupPath & "\"
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "TIFF Image (*.tif)|*.tif"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox3.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sImagepath As String = TextBox2.Text
        Dim SplitEach As Integer = 0
        Dim OutputFolder As String = TextBox3.Text
        Dim Status As GdPictureStatus = GdPictureStatus.OK

        Button3.Enabled = False

        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.

        Try 'prevent for overflow exception
            SplitEach = CInt(Val(TextBox1.Text))
        Catch ex As Exception

        End Try

        If SplitEach > 0 Then
            oGdPictureImaging.TiffOpenMultiPageForWrite(False) ' For best performences
            Dim SrcTiff As Integer = oGdPictureImaging.CreateGdPictureImageFromFile(sImagepath)

            If SrcTiff <> 0 Then
                'Checking if the image is a multipage tiff
                If oGdPictureImaging.TiffIsMultiPage(SrcTiff) Then
                    'Getting the initial compression sheme
                    Dim TiffCompression As TiffCompression = oGdPictureImaging.GetTiffCompression(SrcTiff)
                    Dim PageCount As Integer = oGdPictureImaging.TiffGetPageCount(SrcTiff)
                    Dim CurrentPage As Integer = 0
                    Dim OutputFilePath As String
                    Dim OutputFileCount As Integer = CInt(Math.Ceiling(PageCount / SplitEach))

                    ProgressBar1.Maximum = PageCount


                    For i As Integer = 1 To OutputFileCount
                        Dim TiffOutputID As Integer

                        OutputFilePath = OutputFolder + "split" + Str(i) + ".tif"

                        For j As Integer = 1 To SplitEach
                            CurrentPage = CurrentPage + 1
                            If CurrentPage <= PageCount And Status = GdPictureStatus.OK Then
                                oGdPictureImaging.TiffSelectPage(SrcTiff, CurrentPage)
                                If j = 1 Then
                                    TiffOutputID = oGdPictureImaging.CreateClonedGdPictureImage(SrcTiff) 'This image must be released at the end of the multipage TIFF generation !!
                                    Status = oGdPictureImaging.TiffSaveAsMultiPageFile(TiffOutputID, OutputFilePath, TiffCompression)
                                Else
                                    Status = oGdPictureImaging.TiffAddToMultiPageFile(TiffOutputID, SrcTiff)
                                End If
                                ProgressBar1.Value = CurrentPage
                                Application.DoEvents()
                            End If
                        Next
                        oGdPictureImaging.TiffCloseMultiPageFile(TiffOutputID)
                        oGdPictureImaging.ReleaseGdPictureImage(TiffOutputID)
                    Next

                    If Status = GdPictureStatus.OK Then
                        MsgBox("Success !")
                    Else
                        MsgBox("Error: " + Status.ToString)
                    End If
                Else
                    MsgBox("Error, The image is not a multipage tiff.")
                End If

                oGdPictureImaging.ReleaseGdPictureImage(SrcTiff)
            Else
                MsgBox("Error, Can't open image: " + sImagepath)
            End If
        Else
            MsgBox("Error, Incorrect value for split each.")
        End If
        Button3.Enabled = True
    End Sub
End Class