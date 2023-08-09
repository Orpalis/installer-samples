Option Strict On
Option Explicit On

Imports System.IO
Imports GdPicture14

Public Class Form1

    Private ReadOnly _nativePdf As New GdPicturePDF
    Private _cancellationPending As Boolean

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.

        txtDictsPath.Text = oLicenseManager.GetRedistPath() + "OCR\"

        AddHandler _nativePdf.OcrPagesProgress, AddressOf Me.OcrPagesProgress
        AddHandler _nativePdf.BeforePageOcr, AddressOf Me.BeforePageOcr
        AddHandler _nativePdf.OcrPagesDone, AddressOf Me.OcrPagesDone
    End Sub

    Private Sub txtDictsPath_TextChanged(sender As Object, e As EventArgs) Handles txtDictsPath.TextChanged
        If Directory.Exists(txtDictsPath.Text) Then
            Dim d As New DirectoryInfo(txtDictsPath.Text)
            Dim files As FileInfo() = d.GetFiles("*.traineddata")
            For Each file As FileInfo In files
                cmbLang.Items.Add(Path.GetFileNameWithoutExtension(file.Name))
            Next
        End If
    End Sub

    Private Sub BeforePageOcr(ByVal pageNo As Integer, ByRef cancel As Boolean)
        If _nativePdf.PageHasText(False) Then
            If MessageBox.Show("The page " + pageNo.ToString() + " of the pdf already has text. Do you want to skip it?", "The page has text", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.Yes Then
                cancel = True
            End If
        End If
    End Sub

    Private Sub OcrPagesProgress(ByVal status As GdPictureStatus, ByVal pageNo As Integer, ByVal processed As Integer, ByVal count As Integer, ByRef cancel As Boolean)
        ProgressBar1.Maximum = count
        ProgressBar1.Value = processed
        If status <> GdPictureStatus.OK Then
            If Not _cancellationPending Then
                If MessageBox.Show("An error occured on page " + pageNo.ToString() + ". Do you want to cancel the process? Status: " + status.ToString(), "error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.Yes Then
                    cancel = True
                    _cancellationPending = True
                End If
            End If

        End If
    End Sub

    Private Sub OcrPagesDone(ByVal status As GdPictureStatus)
        If status = GdPictureStatus.OK Then
            Dim outputFilePath As String = txtInputFile.Text.Substring(0, txtInputFile.Text.Length - 4) + "_ocr.pdf"

            If chkIncSave.Checked Then
                status = _nativePdf.SaveToFileInc(outputFilePath)
            Else
                status = _nativePdf.SaveToFile(outputFilePath, True)
            End If

            If status <> GdPictureStatus.OK Then
                MessageBox.Show("Can't save file " + outputFilePath + " . Error: " + status.ToString())
            Else
                Process.Start(outputFilePath)
            End If
            MessageBox.Show("Done! Please check file " + outputFilePath)
        Else
            MessageBox.Show("An error occured. Status: " + status.ToString())
        End If

        _nativePdf.CloseDocument()
        UnlockUi()
    End Sub

    Private Sub LockUi()
        Me.Enabled = False
        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
    End Sub

    Private Sub UnlockUi()
        Me.Enabled = True
        ProgressBar1.Visible = False
    End Sub

    Private Sub btStartOCR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btStartOCR.Click
        If txtInputFile.Text <> "" Then
            If cmbLang.Text <> "" Then
                Dim resolution As Single = Single.Parse(txtDPI.Text)

                If _nativePdf.LoadFromFile(txtInputFile.Text, False) = GdPictureStatus.OK Then
                    If _nativePdf.IsEncrypted() Then
                        'PDF is encrypted, try to decrypt by using empty password
                        If Not _nativePdf.SetPassword("") <> GdPictureStatus.OK Then
                            MessageBox.Show("This PDF is password protected", "operation cancelled", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            _nativePdf.CloseDocument()
                            Return
                        End If
                    End If

                    LockUi()
                    _cancellationPending = False

                    Dim threadCount As Integer
                    If chkMultithread.Checked Then
                        threadCount = 0 '0 means automatic number of thread computation
                    Else
                        threadCount = 1
                    End If

                    _nativePdf.OcrPages("*", threadCount, cmbLang.Text, txtDictsPath.Text, "", resolution)
                Else
                    MessageBox.Show("Can't open file: " & txtInputFile.Text)
                End If
            Else
                MessageBox.Show("Please, select a language to recognize.")
            End If
        Else
            MessageBox.Show("Please, select a file to convert.")
        End If
    End Sub

    Private Sub btBrowsInput_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btBrowsInput.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "PDF Document (*.pdf)|*.pdf"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtInputFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btBrowsOCRDict_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btBrowsOCRDict.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtDictsPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

End Class