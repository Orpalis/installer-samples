Imports GdPicture14

Public Class Form1

    Private _gdPictureImaging As GdPictureImaging

    Private _gdPictureOcr As GdPictureOCR

    Private _ocrSpecialContext As OCRSpecialContext

    Private _document As Ocr.Document

    Private Const PdfRasterizationResolution As Integer = 300

    Private ReadOnly InitialText As String = ""

    Private Shared ReadOnly OcrContextMap As OCRContext() =
    {
        OCRContext.OCRContextDocument,
        OCRContext.OCRContextSingleColumn,
        OCRContext.OCRContextSingleBlock,
        OCRContext.OCRContextSingleBlockVertical,
        OCRContext.OCRContextSingleLine,
        OCRContext.OCRContextSingleWord,
        OCRContext.OCRContextSingleWordCircle,
        OCRContext.OCRContextSingleChar,
        OCRContext.OCRContextSparseText,
        OCRContext.OCRContextRawLine,
        OCRContext.OCRContextSegmentationOnly
    }

    Private Shared ReadOnly OcrModeMap As OCRMode() =
    {
        OCRMode.FavorAccuracy,
        OCRMode.FavorSpeed
    }


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSettings()

        Dim licenseManager As GdPicture14.LicenseManager = New GdPicture14.LicenseManager()
        licenseManager.RegisterKEY("XXX") ' Please replace XXX by a demo or commercial key.

        _gdPictureImaging = New GdPictureImaging()
        _gdPictureOcr = New GdPictureOCR()
        _document = New Ocr.Document(_gdPictureImaging, _gdPictureOcr)

        If tbResouceFolder.Text.Length = 0 Then
            tbResouceFolder.Text = licenseManager.GetRedistPath() & "OCR\"
        End If

        Dim resourceLanguage As OCRLanguage
        If [Enum].TryParse(Of OCRLanguage)(My.Settings.Language, resourceLanguage) Then
            UpdateLanguages(tbResouceFolder.Text, New OCRLanguage() {resourceLanguage})
        Else
            UpdateLanguages(tbResouceFolder.Text, New OCRLanguage() {OCRLanguage.English})
        End If

        UpdateControlsDocumentClosed()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SaveSettings()
    End Sub


    Private Sub LoadSettings()
        tbResouceFolder.Text = My.Settings.ResourceFolder
        chkEnableVigorousDespeckle.Checked = My.Settings.EnableVigorousDespeckle
        cbDeskew.Checked = My.Settings.Deskew
        chkEnablePreprocessing.Checked = My.Settings.EnablePreprocessing
        cbDetectOrientation.Checked = My.Settings.DetectOrientation
        cbContext.SelectedIndex = My.Settings.Context
        cbMode.SelectedIndex = My.Settings.Mode
        cbCharacterSet.SelectedIndex = My.Settings.CharacterSet
        cbKeepLineBreaks.Checked = My.Settings.KeepLineBreaks
        cbFormat.SelectedIndex = My.Settings.OutputFormat
    End Sub


    Private Sub SaveSettings()
        My.Settings.ResourceFolder = tbResouceFolder.Text
        Dim languages As OCRLanguage() = GetSelectedLanguages()
        If languages Is Nothing Then
            My.Settings.Language = ""
        Else
            My.Settings.Language = languages(0).ToString()
            For i As Integer = 1 To languages.Length - 1
                My.Settings.Language += "|"
                My.Settings.Language += languages(i)
            Next
        End If

        My.Settings.EnableVigorousDespeckle = chkEnableVigorousDespeckle.Checked
        My.Settings.Deskew = cbDeskew.Checked
        My.Settings.EnablePreprocessing = chkEnablePreprocessing.Checked
        My.Settings.DetectOrientation = cbDetectOrientation.Checked
        My.Settings.Context = cbContext.SelectedIndex
        My.Settings.Mode = cbMode.SelectedIndex
        My.Settings.CharacterSet = cbCharacterSet.SelectedIndex
        My.Settings.KeepLineBreaks = cbKeepLineBreaks.Checked
        My.Settings.OutputFormat = cbFormat.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Function GetSelectedLanguages() As OCRLanguage()
        If lbLanguages.SelectedItems.Count = 0 Then
            Return Nothing
        End If

        Dim languages As OCRLanguage() = New OCRLanguage(lbLanguages.SelectedItems.Count - 1) {}
        Dim index As Integer = 0
        For Each selectedItem In lbLanguages.SelectedItems
            languages(Math.Min(System.Threading.Interlocked.Increment(index), index - 1)) = CType([Enum].Parse(GetType(OCRLanguage), selectedItem.ToString()), OCRLanguage)
        Next

        Return languages
    End Function

    Private Sub UpdateLanguages(ByVal resourceFolder As String, ByVal selectedLanguages As OCRLanguage())
        lbLanguages.Items.Clear()
        _gdPictureOcr.ResourceFolder = resourceFolder
        Dim languages As IList(Of OCRLanguage) = _gdPictureOcr.GetAvailableLanguages()
        If languages IsNot Nothing Then
            For Each availableLanguage In languages
                Dim index As Integer = lbLanguages.Items.Add(availableLanguage)
                If selectedLanguages IsNot Nothing AndAlso selectedLanguages.Contains(availableLanguage) Then
                    lbLanguages.SetSelected(index, True)
                End If
            Next
        End If
    End Sub


    Private Sub DisplayBoxes()
        Dim blocks As Rectangle() = If(blocksToolStripMenuItem.Checked, _document.BlocksBoundingBoxes, Nothing)
        Dim paragraphs As Rectangle() = If(paragraphsToolStripMenuItem.Checked, _document.ParagraphsBoundingBoxes, Nothing)
        Dim textLines As Rectangle() = If(textLinesToolStripMenuItem.Checked, _document.TextLinesBoundingBoxes, Nothing)
        Dim words As Rectangle() = If(wordsToolStripMenuItem.Checked, _document.WordsBoundingBoxes, Nothing)
        Dim characters As Rectangle() = If(charactersToolStripMenuItem.Checked, _document.CharactersBoundingBoxes, Nothing)
        Ocr.Utilities.MarkRegions(gdViewer1, blocks, paragraphs, textLines, words, characters, _gdPictureImaging.GetHorizontalResolution(_document.ImageId), _gdPictureImaging.GetVerticalResolution(_document.ImageId))
    End Sub


    Private Sub DisplayError(ByVal errorCode As GdPictureStatus)
        MessageBox.Show("The operation failed with error code " & errorCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Function GetCharacterSet() As String
        Select Case cbCharacterSet.SelectedIndex
            Case 1
                Return "0123456789.,"
            Case Else
                Return ""
        End Select
    End Function


    Private Sub UpdateControlsOcrResultCreated()
        If Not _document.HasOcr Then
            DisplayError(_gdPictureOcr.GetStat())
        Else
            DisplayBoxes()
            rtbText.Text = _document.OCRResult
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub UpdateControlsOcrResultDiscarded()
        rtbText.Text = ""
        gdViewer1.RemoveAllRegions()
        btnSave.Enabled = False
    End Sub

    Private Sub UpdateControlsDocumentLoaded()
        gdViewer1.DisplayFromGdPictureImage(_document.ImageId)
        closeToolStripMenuItem.Enabled = True
        viewToolStripMenuItem.Enabled = True
        rotateToolStripMenuItem.Enabled = True
        imageEnhancementToolStripMenuItem.Enabled = True
        ocrToolStripMenuItem.Enabled = True
        updateImageInfo()
    End Sub

    Private Sub UpdateControlsDocumentClosed()
        Text = InitialText
        UpdateControlsOcrResultDiscarded()
        gdViewer1.CloseDocument()
        closeToolStripMenuItem.Enabled = False
        viewToolStripMenuItem.Enabled = False
        rotateToolStripMenuItem.Enabled = False
        imageEnhancementToolStripMenuItem.Enabled = False
        ocrToolStripMenuItem.Enabled = False
        updateImageInfo()
    End Sub

    Private Sub openToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles openToolStripMenuItem.Click
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
        If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
            _document.Close()
            UpdateControlsDocumentClosed()
            gdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
            Cursor.Current = Cursors.WaitCursor
            Dim bSuccess As Boolean = _document.Load(openFileDialog.FileName, cbDetectOrientation.Checked, cbDeskew.Checked, PdfRasterizationResolution)
            Cursor.Current = Cursors.[Default]
            If bSuccess Then
                UpdateControlsDocumentLoaded()
            Else
                MessageBox.Show("Failed to load " & openFileDialog.FileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub closeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles closeToolStripMenuItem.Click
        _document.Close()
        UpdateControlsDocumentClosed()
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        _document.Close()
        UpdateControlsDocumentClosed()
        Close()
    End Sub

    Private Sub zoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles zoomInToolStripMenuItem.Click
        gdViewer1.ZoomIN()
    End Sub

    Private Sub zoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles zoomOutToolStripMenuItem.Click
        gdViewer1.ZoomOUT()
    End Sub

    Private Sub toolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem2.Click
        gdViewer1.IgnoreDocumentResolution = False
        gdViewer1.Zoom = 1
    End Sub

    Private Sub ignoreResolutionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ignoreResolutionToolStripMenuItem.Click
        gdViewer1.IgnoreDocumentResolution = True
        gdViewer1.Zoom = 1
    End Sub

    Private Sub blocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles blocksToolStripMenuItem.Click
        DisplayBoxes()
    End Sub

    Private Sub paragraphsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles paragraphsToolStripMenuItem.Click
        DisplayBoxes()
    End Sub

    Private Sub textLinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles textLinesToolStripMenuItem.Click
        DisplayBoxes()
    End Sub

    Private Sub wordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles wordsToolStripMenuItem.Click
        DisplayBoxes()
    End Sub

    Private Sub charactersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles charactersToolStripMenuItem.Click
        DisplayBoxes()
    End Sub


    Private Sub rotateRight90ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rotateRight90ToolStripMenuItem.Click
        If _document.IsOpen Then
            _document.DiscardOcrResult()
            UpdateControlsOcrResultDiscarded()
            Dim errorCode As GdPictureStatus = _gdPictureImaging.Rotate(_document.ImageId, RotateFlipType.Rotate90FlipNone)
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            updateImageInfo()
        End If
    End Sub

    Private Sub rotateLeft90ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rotateLeft90ToolStripMenuItem.Click
        If _document.IsOpen Then
            _document.DiscardOcrResult()
            UpdateControlsOcrResultDiscarded()
            Dim errorCode As GdPictureStatus = _gdPictureImaging.Rotate(_document.ImageId, RotateFlipType.Rotate270FlipNone)
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            updateImageInfo()
        End If
    End Sub

    Private Sub rotate180ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rotate180ToolStripMenuItem.Click
        If _document.IsOpen Then
            _document.DiscardOcrResult()
            UpdateControlsOcrResultDiscarded()
            Dim errorCode As GdPictureStatus = _gdPictureImaging.Rotate(_document.ImageId, RotateFlipType.Rotate180FlipNone)
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            updateImageInfo()
        End If
    End Sub


    Private Sub deskewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles deskewToolStripMenuItem.Click
        If _document.IsOpen Then
            _document.DiscardOcrResult()
            UpdateControlsOcrResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.AutoDeskew(_document.ImageId)
            Cursor.Current = Cursors.[Default]
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            updateImageInfo()
        End If
    End Sub

    Private Sub automaticRotationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles automaticRotationToolStripMenuItem.Click
        If _document.IsOpen Then
            _document.DiscardOcrResult()
            UpdateControlsOcrResultDiscarded()
            SetOcrParameters(0, 0, _gdPictureImaging.GetWidth(_document.ImageId), _gdPictureImaging.GetHeight(_document.ImageId))
            Cursor.Current = Cursors.WaitCursor
            _gdPictureOcr.SetImage(_document.ImageId)
            Dim orientationAngle As Integer = _gdPictureOcr.GetOrientation()
            Dim errorCode As GdPictureStatus = _gdPictureOcr.GetStat()
            If errorCode = GdPictureStatus.OK AndAlso orientationAngle <> 0 Then
                Dim correctOrientationAngle As Integer = 360 - orientationAngle
                errorCode = _gdPictureImaging.RotateAngle(_document.ImageId, CSng(correctOrientationAngle))
            End If

            Cursor.Current = Cursors.[Default]
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            updateImageInfo()
        End If
    End Sub

    Private Sub bitonalDespeckleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles bitonalDespeckleToolStripMenuItem.Click
        If _document.IsOpen Then
            _document.DiscardOcrResult()
            UpdateControlsOcrResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = GdPictureStatus.OK
            If _gdPictureImaging.GetBitDepth(_document.ImageId) <> 1 Then
                errorCode = _gdPictureImaging.ConvertTo1BppAT(_document.ImageId)
            End If

            errorCode = _gdPictureImaging.FxBitonalDespeckleAdvanced(_document.ImageId, DespeckleType.FourConnected, 5)
            Cursor.Current = Cursors.[Default]
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            updateImageInfo()
        End If
    End Sub

    Private Sub borderRemovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles borderRemovalToolStripMenuItem.Click
        If _document.IsOpen Then
            _document.DiscardOcrResult()
            UpdateControlsOcrResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = GdPictureStatus.OK
            If _gdPictureImaging.GetBitDepth(_document.ImageId) <> 1 Then
                errorCode = _gdPictureImaging.ConvertTo1BppAT(_document.ImageId)
            End If

            errorCode = _gdPictureImaging.DeleteBlackBorders(_document.ImageId, 0, True)
            Cursor.Current = Cursors.[Default]
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            updateImageInfo()
        End If
    End Sub

    Private Sub scaleTo300DPIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles scaleTo300DPIToolStripMenuItem.Click
        If _document.IsOpen Then
            _document.DiscardOcrResult()
            UpdateControlsOcrResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.Scale(_document.ImageId, (300.0F / _gdPictureImaging.GetVerticalResolution(_document.ImageId)) * 100, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic)
            Cursor.Current = Cursors.[Default]
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            updateImageInfo()
        End If
    End Sub

    Private Sub readToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles readToolStripMenuItem.Click
        If _document.IsOpen Then
            _document.DiscardOcrResult()
            UpdateControlsOcrResultDiscarded()
            StartOCR(0, 0, 0, 0)
        End If
    End Sub

    Private Sub readzoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles readzoneToolStripMenuItem.Click
        If _document.IsOpen Then
            If gdViewer1.IsRect() Then
                _document.DiscardOcrResult()
                UpdateControlsOcrResultDiscarded()
                Dim left As Integer = 0
                Dim top As Integer = 0
                Dim width As Integer = 0
                Dim height As Integer = 0
                gdViewer1.GetRectCoordinatesOnDocument(left, top, width, height)
                StartOCR(left, top, width, height)
            Else
                MessageBox.Show("Please draw a region of interest into the viewer in order to specify the zone to read.")
            End If
        End If
    End Sub

    Private Sub btnBrowseResourceFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseResourceFolder.Click
        Dim folderBrowserDialog = New FolderBrowserDialog With {.SelectedPath = tbResouceFolder.Text}
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            tbResouceFolder.Text = folderBrowserDialog.SelectedPath
            UpdateLanguages(tbResouceFolder.Text, GetSelectedLanguages())
        End If
    End Sub

    Private Sub btnClearSelection_Click(sender As Object, e As EventArgs) Handles btnClearSelection.Click
        lbLanguages.ClearSelected()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If _document.HasOcr Then
            Using saveFileDialog As SaveFileDialog = New SaveFileDialog()
                Select Case cbFormat.SelectedIndex
                    Case 0, 1
                        saveFileDialog.Filter = "Text Files | *.txt"
                    Case 2
                        saveFileDialog.Filter = "Html Files | *.html"
                    Case Else
                        saveFileDialog.Filter = "Word Document | *.docx"
                End Select

                If saveFileDialog.ShowDialog(Me) = DialogResult.OK Then
                    Cursor.Current = Cursors.WaitCursor
                    Dim status As GdPictureStatus
                    Select Case cbFormat.SelectedIndex
                        Case 0
                            status = _gdPictureOcr.SaveAsText(_document.OcrResultId, saveFileDialog.FileName, OCROutputTextFormat.Utf8, cbKeepLineBreaks.Checked)
                        Case 1
                            status = _gdPictureOcr.SaveAsText(_document.OcrResultId, saveFileDialog.FileName, OCROutputTextFormat.Utf16, cbKeepLineBreaks.Checked)
                        Case 2
                            status = _gdPictureOcr.SaveAsHTML(_document.OcrResultId, saveFileDialog.FileName, cbKeepLineBreaks.Checked)
                        Case Else
                            status = _gdPictureOcr.SaveAsDOCX(_document.OcrResultId, saveFileDialog.FileName, cbKeepLineBreaks.Checked)
                    End Select

                    Cursor.Current = Cursors.[Default]
                    If status <> GdPictureStatus.OK Then
                        DisplayError(status)
                    Else
                        Process.Start(saveFileDialog.FileName)
                    End If
                End If
            End Using
        End If
    End Sub


    Private Sub StartOCR(ByVal roiLeft As Integer, ByVal roiTop As Integer, ByVal roiWidth As Integer, ByVal roiHeight As Integer)
        SetOcrParameters(roiLeft, roiTop, roiWidth, roiHeight)
        Cursor.Current = Cursors.WaitCursor
        Dim stopWatch As Stopwatch = New Stopwatch()
        stopWatch.Start()
        _document.OcrResultId = _gdPictureOcr.RunOCR(_ocrSpecialContext)
        stopWatch.[Stop]()
        If _gdPictureOcr.GetStat() = GdPictureStatus.OK Then
            Me.Text = InitialText & " - Elapsed: " + stopWatch.Elapsed.ToString() & ". Average confidence: " + _gdPictureOcr.GetAverageWordConfidence(_document.OcrResultId).ToString() & " %"
        Else
            Me.Text = InitialText
        End If

        Cursor.Current = Cursors.[Default]
        UpdateControlsOcrResultCreated()
    End Sub


    Private Sub SetOcrParameters(ByVal roiLeft As Integer, ByVal roiTop As Integer, ByVal roiWidth As Integer, ByVal roiHeight As Integer)
        _gdPictureOcr.SetImage(_document.ImageId)

        If cbContext.SelectedIndex <= 10 Then
            _gdPictureOcr.Context = OcrContextMap(cbContext.SelectedIndex)
            _ocrSpecialContext = OCRSpecialContext.None
        Else
            'special contexts
            If (cbContext.SelectedIndex = 11) Then
                _ocrSpecialContext = OCRSpecialContext.OneOrTwoNumerics
            ElseIf (cbContext.SelectedIndex = 12) Then
                _ocrSpecialContext = OCRSpecialContext.SingleLineNumerics
            ElseIf (cbContext.SelectedIndex = 13) Then
                _ocrSpecialContext = OCRSpecialContext.MRZ
            ElseIf (cbContext.SelectedIndex = 14) Then
                _ocrSpecialContext = OCRSpecialContext.MICRLineE13B
            ElseIf (cbContext.SelectedIndex = 15) Then
                _ocrSpecialContext = OCRSpecialContext.MICRLineCMC7
            ElseIf (cbContext.SelectedIndex = 16) Then
                _ocrSpecialContext = OCRSpecialContext.NumericLineML
            ElseIf (cbContext.SelectedIndex = 17) Then
                _ocrSpecialContext = OCRSpecialContext.HandwrittenNumericBoxML
            End If
        End If

        _gdPictureOcr.EnableVigorousDespeckle = chkEnableVigorousDespeckle.Checked
        _gdPictureOcr.LanguageModelPenaltyNonDictWords = CSng(tbNonDictWords.Value) / 100
        _gdPictureOcr.LanguageModelPenaltyNonFreqDictWords = CSng(tbNonFreqWords.Value) / 100
        _gdPictureOcr.ResourceFolder = tbResouceFolder.Text
        _gdPictureOcr.LoadMainDictionary = chkLoadMainDict.Checked
        _gdPictureOcr.LoadFreqWordsDictionary = chkLoadFreqWordsDict.Checked
        _gdPictureOcr.EnableOrientationDetection = cbDetectOrientation.Checked
        _gdPictureOcr.EnableSkewDetection = cbDeskew.Checked
        _gdPictureOcr.EnablePreprocessing = chkEnablePreprocessing.Checked
        _gdPictureOcr.ResetSelectedDictionaries()

        Dim selectedLanguages As OCRLanguage() = GetSelectedLanguages()
        If selectedLanguages IsNot Nothing Then
            For Each language As OCRLanguage In selectedLanguages
                _gdPictureOcr.AddLanguage(language)
            Next
        Else
            _gdPictureOcr.AddLanguage(OCRLanguage.English)
        End If

        _gdPictureOcr.OCRMode = OcrModeMap(cbMode.SelectedIndex)
        _gdPictureOcr.CharacterSet = GetCharacterSet()
        _gdPictureOcr.SetROI(roiLeft, roiTop, roiWidth, roiHeight)
    End Sub

    Private Sub updateImageInfo()
        If _document.IsOpen Then
            tsImageInfo.Text = "Image properties :: width: " & _gdPictureImaging.GetWidth(_document.ImageId) & "." &
                                   " height: " & _gdPictureImaging.GetHeight(_document.ImageId) & "." &
                                   " horizontal resolution: " & _gdPictureImaging.GetHorizontalResolution(_document.ImageId) & " dpi." &
                                   " vertical resolution: " & _gdPictureImaging.GetVerticalResolution(_document.ImageId) & " dpi." &
                                   " bit depth: " & _gdPictureImaging.GetBitDepth(_document.ImageId) & " bpp."
        Else
            tsImageInfo.Text = ""
        End If

    End Sub

End Class
