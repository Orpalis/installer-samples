Option Strict On
Option Explicit On

Imports System.IO
Imports GdPicture14

Public Class Form1

    Private ReadOnly _nativePdf As New GdPicturePDF
    Private _cancellationPending As Boolean


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager()
        oLicenseManager.RegisterKEY("XXX") 'Please replace XXX by a valid demo or commercial key.

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
        'nothing to do
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
            Dim outputFilePath As String = Path.ChangeExtension(txtInputFile.Text, "pdf")
            status = _nativePdf.SaveToFile(outputFilePath, True)
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
        If Not String.IsNullOrEmpty(txtInputFile.Text) Then
            If Not String.IsNullOrEmpty(cmbLang.Text) Then

                Using gdpictureImaging As New GdPictureImaging
                    Dim imageID As Integer = gdpictureImaging.CreateGdPictureImageFromFile(txtInputFile.Text)
                    If gdpictureImaging.GetStat = GdPictureStatus.OK Then
                        Dim resolution As Single = Math.Max(200, gdpictureImaging.GetVerticalResolution(imageID))
                        _nativePdf.NewPDF(PdfConformance.PDF_A_1b)
                        For i As Integer = 1 To gdpictureImaging.GetPageCount(imageID)
                            If gdpictureImaging.SelectPage(imageID, i) = GdPictureStatus.OK Then
                                _nativePdf.AddImageFromGdPictureImage(imageID, False, True)
                            End If
                        Next
                        gdpictureImaging.ReleaseGdPictureImage(imageID)

                        LockUi()
                        _cancellationPending = False

                        Dim threadCount As Integer
                        If chkMultithread.Checked Then
                            threadCount = 0 '0 means automatic number of thread computation
                        Else
                            threadCount = 1
                        End If

                        Dim oCRMode As OCRMode
                        If chkFavorAccuracy.Checked Then
                            oCRMode = OCRMode.FavorAccuracy 'automatic
                        Else
                            oCRMode = OCRMode.FavorSpeed 'faster
                        End If

                        _nativePdf.OcrPages("*", threadCount, cmbLang.Text, txtDictsPath.Text, "", resolution, oCRMode, 0, False)
                    Else
                        MessageBox.Show("Can't open file: " + txtInputFile.Text + " status: " + gdpictureImaging.GetStat().ToString())
                    End If

                End Using

            Else
                MessageBox.Show("Please, select a language to recognize.")
            End If
        Else
            MessageBox.Show("Please, select a file to convert.")
        End If
    End Sub


    Private Sub btBrowsInput_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btBrowsInput.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Tiff Image Files(*.TIF;*.TIFF)|*.TIF;*.TIFF|All files (*.*)|*.*"
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