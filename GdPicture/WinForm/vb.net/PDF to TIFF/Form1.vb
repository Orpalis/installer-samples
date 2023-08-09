Option Explicit On
Option Strict On

Imports GdPicture14

Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "PDF Document (*.pdf)|*.pdf"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
        ComboBox1.Text = "AUTO"
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then

            Dim MultiTiffID As Integer
            Dim CompressionScheme As GdPicture14.TiffCompression
            Dim Status As GdPicture14.GdPictureStatus = GdPicture14.GdPictureStatus.OK

            Select Case ComboBox1.Text
                Case "AUTO"
                    CompressionScheme = GdPicture14.TiffCompression.TiffCompressionAUTO
                Case "JPEG"
                    CompressionScheme = GdPicture14.TiffCompression.TiffCompressionJPEG
                Case "CCITT3"
                    CompressionScheme = GdPicture14.TiffCompression.TiffCompressionCCITT3
                Case "CCITT4"
                    CompressionScheme = GdPicture14.TiffCompression.TiffCompressionCCITT4
                Case "LZW"
                    CompressionScheme = GdPicture14.TiffCompression.TiffCompressionLZW
                Case "RLE"
                    CompressionScheme = GdPicture14.TiffCompression.TiffCompressionRLE
                Case "NONE"
                    CompressionScheme = GdPicture14.TiffCompression.TiffCompressionNONE
                Case "ZIP"
                    CompressionScheme = GdPicture14.TiffCompression.TiffCompressionDEFLATE
            End Select


            Using oGdPicturePDF As New GdPicture14.GdPicturePDF
                Dim InputFilePath As String = TextBox1.Text
                If oGdPicturePDF.LoadFromFile(InputFilePath, False) = GdPicture14.GdPictureStatus.OK Then
                    ProgressBar1.Maximum = oGdPicturePDF.GetPageCount
                    Dim DPI As Integer = CInt(Val(TextBox2.Text))
                    Dim OutputFilePath As String = Mid(InputFilePath, 1, Len(InputFilePath) - 3) + "tif"

                    Using oGdPictureImaging As New GdPicture14.GdPictureImaging
                        For i As Integer = 1 To oGdPicturePDF.GetPageCount
                            If Status = GdPicture14.GdPictureStatus.OK Then
                                oGdPicturePDF.SelectPage(i)
                                Dim RasterizedPageID As Integer = oGdPicturePDF.RenderPageToGdPictureImageEx(DPI, True)

                                'CCITT3 & CCITT4 compression support only bitonal (1 bpp) images !!
                                If CompressionScheme = GdPicture14.TiffCompression.TiffCompressionCCITT3 Or CompressionScheme = GdPicture14.TiffCompression.TiffCompressionCCITT4 Then
                                    oGdPictureImaging.ConvertTo1BppSauvola(RasterizedPageID, 0.35)
                                End If

                                If i = 1 Then
                                    MultiTiffID = RasterizedPageID 'Warning: this image must be released at the end!!!!
                                    Status = oGdPictureImaging.TiffSaveAsMultiPageFile(MultiTiffID, OutputFilePath, CompressionScheme)
                                Else
                                    Status = oGdPictureImaging.TiffAddToMultiPageFile(MultiTiffID, RasterizedPageID)
                                    oGdPictureImaging.ReleaseGdPictureImage(RasterizedPageID)
                                End If
                            End If
                            ProgressBar1.Value = i
                        Next

                        oGdPictureImaging.TiffCloseMultiPageFile(MultiTiffID)
                        oGdPictureImaging.ReleaseGdPictureImage(MultiTiffID)

                    End Using

                    If Status = GdPicture14.GdPictureStatus.OK Then
                        MsgBox("The image " + OutputFilePath + " has been correctly created")
                    Else
                        MsgBox("Error: " + Status.ToString)
                    End If
                    oGdPicturePDF.CloseDocument()
                Else
                    MsgBox("Can't open file: " & InputFilePath)
                End If
            End Using
        Else
            MsgBox("Please, select a file to convert.")
        End If
    End Sub
End Class