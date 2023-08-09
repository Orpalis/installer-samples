Imports GdPicture14

Public Class Form1

    Dim _gdPictureImaging As GdPictureImaging
    Dim _gdPictureSegmenter As GdPictureSegmenter
    Dim _document As Document
    Dim _resultID As String
    Dim pdfRasterizationResolution As Integer = 300
    Dim _initialText As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim licenseManager As LicenseManager = New LicenseManager
        licenseManager.RegisterKEY("XXX") 'Please replace XXX by a valid demo or commercial key.
        _gdPictureImaging = New GdPictureImaging
        _gdPictureSegmenter = New GdPictureSegmenter
        _document = New Document(_gdPictureImaging)

        UpdateControlsDocumentClosed()
    End Sub

    Private Sub StartSegmentation()
        Cursor.Current = Cursors.WaitCursor
        Dim stopWatch As Stopwatch = New Stopwatch
        stopWatch.Start()
        Dim status As GdPictureStatus
        ReleaseResult()
        If _document.IsOpen Then
            _gdPictureSegmenter.SetImage(_document.ImageId)
            _gdPictureSegmenter.SegmentationMode = SegmentationMode.PageLayout
            _resultID = _gdPictureSegmenter.RunSegmentation
            status = _gdPictureSegmenter.GetStat
            stopWatch.Stop()

            If status = GdPictureStatus.OK Then
                Me.Text = _initialText + " - Elapsed: " + stopWatch.Elapsed.ToString
            Else
                Me.Text = _initialText
            End If

            Cursor.Current = Cursors.Default
            UpdateControlsSegmentationResultCreated()
        Else
            status = GdPictureStatus.Aborted
        End If

    End Sub

    Private Sub UpdateControlsSegmentationResultCreated()
        DisplayBoxes()
    End Sub

    Private Sub DisplayBoxes()
        Utilities.MarkRegions(_gdPictureSegmenter,
                              _resultID,
                              gdViewer1,
                              blocksToolStripMenuItem.Checked,
                              paragraphsToolStripMenuItem.Checked,
                              textLinesToolStripMenuItem.Checked,
                              wordsToolStripMenuItem.Checked,
                              charactersToolStripMenuItem.Checked,
                              chkShowText.Checked,
                              chkShowBitmap.Checked,
                              chkShowLines.Checked,
                              _gdPictureImaging.GetHorizontalResolution(_document.ImageId),
                              _gdPictureImaging.GetVerticalResolution(_document.ImageId))
    End Sub

    Private Sub DisplayError(ByVal errorCode As GdPictureStatus)
        MessageBox.Show("The operation failed with error code " + errorCode.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub UpdateControlsSegmentationResultDiscarded()
        gdViewer1.RemoveAllRegions()
    End Sub

    Private Sub UpdateControlsDocumentLoaded()
        gdViewer1.DisplayFromGdPictureImage(_document.ImageId)
        closeToolStripMenuItem.Enabled = True
        viewToolStripMenuItem.Enabled = True
        rotateToolStripMenuItem.Enabled = True
        imageEnhancementToolStripMenuItem.Enabled = True
        SegmentationToolStripMenuItem.Enabled = True
        UpdateImageInfo()
    End Sub

    Private Sub UpdateControlsDocumentClosed()
        Me.Text = _initialText
        UpdateControlsSegmentationResultDiscarded()
        gdViewer1.CloseDocument()
        closeToolStripMenuItem.Enabled = False
        viewToolStripMenuItem.Enabled = False
        rotateToolStripMenuItem.Enabled = False
        imageEnhancementToolStripMenuItem.Enabled = False
        SegmentationToolStripMenuItem.Enabled = False
        UpdateImageInfo()
    End Sub

    Private Sub UpdateImageInfo()
        If _document.IsOpen Then
            tsImageInfo.Text = "Image properties :: width: " & (_gdPictureImaging.GetWidth(_document.ImageId).ToString() _
                & ("." & (" height: " & (_gdPictureImaging.GetHeight(_document.ImageId).ToString() & ("." & (" horizontal resolution: " _
                & (_gdPictureImaging.GetHorizontalResolution(_document.ImageId).ToString() & (" dpi." & (" vertical resolution: " _
                & (_gdPictureImaging.GetVerticalResolution(_document.ImageId).ToString() & (" dpi." & (" bit depth: " _
                & (_gdPictureImaging.GetBitDepth(_document.ImageId) & " bpp.")))))))))))))
        Else
            tsImageInfo.Text = ""
        End If

    End Sub

    Private Sub ReleaseResult()
        If Not String.IsNullOrWhiteSpace(_resultID) Then
            _gdPictureSegmenter.ReleaseSegmentationResult(_resultID)
            _resultID = Nothing
        End If

    End Sub

    Private Sub openToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles openToolStripMenuItem.Click
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog
        If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
            _document.Close()
            UpdateControlsDocumentClosed()
            gdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
            Cursor.Current = Cursors.WaitCursor
            Dim bSuccess As Boolean = _document.Load(openFileDialog.FileName, pdfRasterizationResolution)
            Cursor.Current = Cursors.Default
            If bSuccess Then
                UpdateControlsDocumentLoaded()
            Else
                MessageBox.Show("Failed to load " + openFileDialog.FileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub rotateRight90ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles rotateRight90ToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Dim errorCode As GdPictureStatus = _gdPictureImaging.Rotate(_document.ImageId, RotateFlipType.Rotate90FlipNone)
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
        End If
    End Sub

    Private Sub rotateLeft90ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles rotateLeft90ToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Dim errorCode As GdPictureStatus = _gdPictureImaging.Rotate(_document.ImageId, RotateFlipType.Rotate270FlipNone)
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
        End If
    End Sub

    Private Sub rotate180ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles rotate180ToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Dim errorCode As GdPictureStatus = _gdPictureImaging.Rotate(_document.ImageId, RotateFlipType.Rotate180FlipNone)
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
        End If
    End Sub

    Private Sub automaticCleanupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles automaticCleanupToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.RemoveHolePunch(_document.ImageId)
            If (errorCode = GdPictureStatus.OK) Then
                errorCode = _gdPictureImaging.DeleteBlackBorders(_document.ImageId, 0, False)
                If (errorCode = GdPictureStatus.OK) Then
                    errorCode = _gdPictureImaging.AutoDeskew(_document.ImageId)
                    'todo: implement a correct generic despeckle.
                End If

            End If

            Cursor.Current = Cursors.Default
            If (errorCode <> GdPictureStatus.OK) Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            UpdateImageInfo()
        End If
    End Sub

    Private Sub removePunchHolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles removePunchHolesToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.RemoveHolePunch(_document.ImageId)
            Cursor.Current = Cursors.Default
            If (errorCode <> GdPictureStatus.OK) Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
        End If
    End Sub

    Private Sub eraseBlackBordersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles eraseBlackBordersToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.DeleteBlackBorders(_document.ImageId, 0, False)
            Cursor.Current = Cursors.Default
            If (errorCode <> GdPictureStatus.OK) Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
        End If
    End Sub

    Private Sub deskewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles deskewToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.AutoDeskew(_document.ImageId)
            Cursor.Current = Cursors.Default
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
        End If
    End Sub

    Private Sub bitonalDespeckleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles bitonalDespeckleToolStripMenuItem.Click
        If _document.IsOpen Then
            If _gdPictureImaging.GetBitDepth(_document.ImageId) <> 1 Then
                MessageBox.Show("This operation can be performed  on 1bpp image only.")
                Return
            End If

            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = GdPictureStatus.OK
            errorCode = _gdPictureImaging.FxBitonalDespeckleAdvanced(_document.ImageId, DespeckleType.FourConnected, 5)
            Cursor.Current = Cursors.Default
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
        End If
    End Sub

    Private Sub medianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles medianToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.FxDespeckle(_document.ImageId)
            Cursor.Current = Cursors.Default
            If (errorCode <> GdPictureStatus.OK) Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
        End If
    End Sub

    Private Sub scaleTo300DPIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles scaleTo300DPIToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.Scale(_document.ImageId, 300.0! / _gdPictureImaging.GetVerticalResolution(_document.ImageId) * 100, Drawing2D.InterpolationMode.HighQualityBicubic)
            Cursor.Current = Cursors.Default
            If errorCode <> GdPictureStatus.OK Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            UpdateImageInfo()
        End If
    End Sub

    Private Sub scaleTo200ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles scaleTo200ToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.Scale(_document.ImageId, 200, Drawing2D.InterpolationMode.HighQualityBicubic)
            Cursor.Current = Cursors.Default
            If (errorCode <> GdPictureStatus.OK) Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            UpdateImageInfo()
        End If
    End Sub

    Private Sub sauvolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles sauvolaToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.ConvertTo1BppSauvola(_document.ImageId, 0.35!)
            Cursor.Current = Cursors.Default
            If (errorCode <> GdPictureStatus.OK) Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            UpdateImageInfo()
        End If
    End Sub

    Private Sub otsuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles otsuToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.ConvertTo1BppAT(_document.ImageId, 50)
            Cursor.Current = Cursors.Default
            If (errorCode <> GdPictureStatus.OK) Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            UpdateImageInfo()
        End If
    End Sub

    Private Sub bradleyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles bradleyToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            Cursor.Current = Cursors.WaitCursor
            Dim errorCode As GdPictureStatus = _gdPictureImaging.ConvertTo1BppBradley(_document.ImageId, 38)
            Cursor.Current = Cursors.Default
            If (errorCode <> GdPictureStatus.OK) Then
                DisplayError(errorCode)
            End If

            gdViewer1.Redraw()
            UpdateImageInfo()
        End If
    End Sub

    Private Sub readToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles readToolStripMenuItem.Click
        If _document.IsOpen Then
            ReleaseResult()
            UpdateControlsSegmentationResultDiscarded()
            StartSegmentation()
        End If
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

    Private Sub chkShowBitmap_Click(sender As Object, e As EventArgs) Handles chkShowBitmap.Click
        DisplayBoxes()
    End Sub

    Private Sub chkShowText_Click(sender As Object, e As EventArgs) Handles chkShowText.Click
        DisplayBoxes()
    End Sub

    Private Sub chkShowLines_Click(sender As Object, e As EventArgs) Handles chkShowLines.Click
        DisplayBoxes()
    End Sub
End Class
