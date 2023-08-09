Option Strict On
Option Explicit On

Imports GdPicture14

Public Class Form1

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        TextBox3.Text = Application.StartupPath & "\"
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "PDF Document (*.pdf)|*.pdf"
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
        Dim oGdPicturePDFSrc As New GdPicturePDF

        Button3.Enabled = False

        Dim oLicenseManager As New GdPicture14.LicenseManager 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.

        Try 'prevent for overflow exception
            SplitEach = CInt(Val(TextBox1.Text))
        Catch ex As Exception

        End Try

        If SplitEach > 0 Then

            If oGdPicturePDFSrc.LoadFromFile(sImagepath, False) = GdPictureStatus.OK Then

                'Check for encryption
                If oGdPicturePDFSrc.IsEncrypted() Then
                    If oGdPicturePDFSrc.SetPassword("") <> GdPictureStatus.OK Then
                        If oGdPicturePDFSrc.SetPassword(InputBox("Password: ", "Password protected document")) <> GdPictureStatus.OK Then
                            MsgBox("Can not uncrypt document")
                            oGdPicturePDFSrc.CloseDocument()
                            Return
                        End If
                    End If
                End If

                'Checking if the document is  multipage 
                Dim PageCount As Integer = oGdPicturePDFSrc.GetPageCount
                If PageCount > 1 Then
                    'Getting the initial compression scheme
                    Dim CurrentPage As Integer = 0
                    Dim OutputFilePath As String
                    Dim OutputFileCount As Integer = CInt(Math.Ceiling(PageCount / SplitEach))

                    ProgressBar1.Maximum = PageCount

                    For i As Integer = 1 To OutputFileCount
                        Dim oGdPicturePDFDest As New GdPicturePDF
                        oGdPicturePDFDest.NewPDF()
                        OutputFilePath = OutputFolder + "split" + Str(i) + ".pdf"

                        For j As Integer = 1 To SplitEach
                            CurrentPage = CurrentPage + 1
                            If CurrentPage <= PageCount And Status = GdPictureStatus.OK Then
                                oGdPicturePDFDest.ClonePage(oGdPicturePDFSrc, CurrentPage)
                                ProgressBar1.Value = CurrentPage
                                Application.DoEvents()
                            End If
                        Next
                        oGdPicturePDFDest.RemoveUnusedResources()
                        oGdPicturePDFDest.SaveToFile(OutputFilePath, True)
                        oGdPicturePDFDest.CloseDocument()
                    Next

                    If Status = GdPictureStatus.OK Then
                        MsgBox("Success !")
                    Else
                        MsgBox("Error: " + Status.ToString)
                    End If
                Else
                    MsgBox("Error, The PDF is not a multipage document.")
                End If

                oGdPicturePDFSrc.CloseDocument()
            Else
                MsgBox("Error, Can't open document: " + sImagepath)
            End If
        Else
            MsgBox("Error, Incorrect value for split each.")
        End If
        Button3.Enabled = True
    End Sub
End Class