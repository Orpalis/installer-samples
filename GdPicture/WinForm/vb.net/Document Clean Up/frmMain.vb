Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports GdPicture14
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Text
Imports DocumentCleanUp.DocumentCleanUp

Public Class frmMain

    Private Enum ZoomMode
        Zoom50
        Zoom100
        Zoom150
        Zoom200
        ZoomSelectedArea
        ZoomFitToViewer
        ZoomFitWidth
        ZoomFitHeight
    End Enum

    Private ReadOnly _gdPictureImaging As New GdPictureImaging
    Private _currentImage As Integer
    Private _currentDocumentCleanUpPreview As Integer

    Private ReadOnly _documentCleanUpEffects As DocumentCleanUpEffects = New DocumentCleanUpEffects()
    Private ReadOnly _documentCleanUpEffectsQueue As BindingList(Of ADocumentCleanUpEffect) = New BindingList(Of ADocumentCleanUpEffect)()

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim oLicenceManager As New GdPicture14.LicenseManager()
        oLicenceManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.

        tcLeftPanel.Appearance = TabAppearance.FlatButtons
        tcLeftPanel.ItemSize = New Size(0, 1)
        tcLeftPanel.SizeMode = TabSizeMode.Fixed
        SelectSnapIn(0, "Thumbnails")

        tbEffectsParameters.Appearance = TabAppearance.FlatButtons
        tbEffectsParameters.ItemSize = New Size(0, 1)
        tbEffectsParameters.SizeMode = TabSizeMode.Fixed

        Dim zoomModes As New Dictionary(Of ZoomMode, String) From {
            {ZoomMode.Zoom50, "50%"},
            {ZoomMode.Zoom100, "100%"},
            {ZoomMode.Zoom150, "150%"},
            {ZoomMode.Zoom200, "200%"},
            {ZoomMode.ZoomSelectedArea, "Zoom to selected area"},
            {ZoomMode.ZoomFitToViewer, "Fit to viewer"},
            {ZoomMode.ZoomFitWidth, "Fit to viewer width"},
            {ZoomMode.ZoomFitHeight, "Fit to viewer height"}
        }
        For Each item In zoomModes
            cbZoom.Items.Add(item.Value)
        Next

        Dim despeckleForce As New List(Of KeyValuePair(Of DespeckleType, String)) From {
            New KeyValuePair(Of DespeckleType, String)(DespeckleType.FourConnected, "Four connected"),
            New KeyValuePair(Of DespeckleType, String)(DespeckleType.FourConnectedNeighborhood, "Four connected neighborhood"),
            New KeyValuePair(Of DespeckleType, String)(DespeckleType.FourConnectedWhite, "Four connected white"),
            New KeyValuePair(Of DespeckleType, String)(DespeckleType.FourConnectedNeighborhoodWhite, "Four connected neighborhood white"),
            New KeyValuePair(Of DespeckleType, String)(DespeckleType.Connected, "Connected"),
            New KeyValuePair(Of DespeckleType, String)(DespeckleType.ConnectedNeighborhood, "Connected neighborhood"),
            New KeyValuePair(Of DespeckleType, String)(DespeckleType.ConnectedWhite, "Connected white"),
            New KeyValuePair(Of DespeckleType, String)(DespeckleType.ConnectedNeighborhoodWhite, "Connected neighborhood white")
        }
        cbDespeckleType.DisplayMember = "Value"
        cbDespeckleType.ValueMember = "Key"
        cbDespeckleType.DataSource = despeckleForce

        Dim referencePoints As New List(Of KeyValuePair(Of ReferencePoint, String)) From {
            New KeyValuePair(Of ReferencePoint, String)(ReferencePoint.ReferencePointBottomLeft, "Bottom Left"),
            New KeyValuePair(Of ReferencePoint, String)(ReferencePoint.ReferencePointBottomRight, "Bottom Right"),
            New KeyValuePair(Of ReferencePoint, String)(ReferencePoint.ReferencePointTopLeft, "Top Left"),
            New KeyValuePair(Of ReferencePoint, String)(ReferencePoint.ReferencePointTopRight, "Top Right")
        }
        cbCropBordersReferencePoint.DisplayMember = "Value"
        cbCropBordersReferencePoint.ValueMember = "Key"
        cbCropBordersReferencePoint.DataSource = referencePoints

        Dim imageContexts As New List(Of KeyValuePair(Of ImagingContext, String)) From {
            New KeyValuePair(Of ImagingContext, String)(ImagingContext.ContextDocument, "Document"),
            New KeyValuePair(Of ImagingContext, String)(ImagingContext.ContextPhoto, "Photo")
        }
        cbCropBordersImageContext.DisplayMember = "Value"
        cbCropBordersImageContext.ValueMember = "Key"
        cbCropBordersImageContext.DataSource = imageContexts

        Dim punchHoleMargins As New List(Of KeyValuePair(Of HolePunchMargins, String)) From {
            New KeyValuePair(Of HolePunchMargins, String)(HolePunchMargins.MarginLeft, "Left"),
            New KeyValuePair(Of HolePunchMargins, String)(HolePunchMargins.MarginTop, "Top"),
            New KeyValuePair(Of HolePunchMargins, String)(HolePunchMargins.MarginBottom, "Bottom"),
            New KeyValuePair(Of HolePunchMargins, String)(HolePunchMargins.MarginRight, "Right"),
            New KeyValuePair(Of HolePunchMargins, String)(HolePunchMargins.MarginLeft Or HolePunchMargins.MarginRight, "Left + Right"),
            New KeyValuePair(Of HolePunchMargins, String)(HolePunchMargins.MarginTop Or HolePunchMargins.MarginBottom, "Top + Bottom"),
            New KeyValuePair(Of HolePunchMargins, String)(HolePunchMargins.MarginTop Or HolePunchMargins.MarginBottom Or HolePunchMargins.MarginLeft Or HolePunchMargins.MarginRight, "All")
        }
        cbRemoveHolePunchEffectMargins.DisplayMember = "Value"
        cbRemoveHolePunchEffectMargins.ValueMember = "Key"
        cbRemoveHolePunchEffectMargins.DataSource = punchHoleMargins

        Dim lineOrientations As New List(Of KeyValuePair(Of LineRemoveOrientation, String)) From {
            New KeyValuePair(Of LineRemoveOrientation, String)(LineRemoveOrientation.Horizontal, "Horizontal"),
            New KeyValuePair(Of LineRemoveOrientation, String)(LineRemoveOrientation.Vertical, "Vertical")
        }
        cbRemoveLinesEffectOrientation.DisplayMember = "Value"
        cbRemoveLinesEffectOrientation.ValueMember = "Key"
        cbRemoveLinesEffectOrientation.DataSource = lineOrientations

        cbDocumentCleanUpEffects.DataSource = New BindingSource(_documentCleanUpEffects.List, Nothing)
        cbDocumentCleanUpEffects.DisplayMember = "Name"
        cbDocumentCleanUpEffects.SelectedIndex = -1

        lstEffects.DataSource = New BindingSource(_documentCleanUpEffectsQueue, Nothing)
        lstEffects.DisplayMember = "Name"
        lstEffects.SelectedIndex = -1

        GdViewer1.RemoveItemMenu(8)
        GdViewer1.RemoveItemMenu(27)

        UpdateMainUi()
    End Sub

    Private Sub UpdateMainUi()
        Me.Text = "GdPicture.NET " & GetType(GdPictureImaging).Assembly.GetName().Version.ToString() & " - Document Clean Up Demo"
        If GdViewer1.PageCount = 0 Then
            btnClose.Enabled = False
            btnPrint.Enabled = False
            btnSave.Enabled = False
            btnFirstPage.Enabled = False
            btnPreviousPage.Enabled = False
            tbCurrentPage.Enabled = False
            lblPageCount.Enabled = False
            btnNextPage.Enabled = False
            btnLastPage.Enabled = False
            btnZoomOut.Enabled = False
            cbZoom.Enabled = False
            btnZoomIn.Enabled = False
            btnFitPage.Enabled = False
            btnFitWidth.Enabled = False
            btnRotateLeft.Enabled = False
            btnRotateRight.Enabled = False
            btnFlipX.Enabled = False
            btnFlipY.Enabled = False
            tbCurrentPage.Text = "0"
            lblPageCount.Text = "/ 0"
            cbZoom.SelectedIndex = -1
            pDocumentCleanUp.Enabled = False
        Else
            btnClose.Enabled = True
            btnPrint.Enabled = True
            btnSave.Enabled = True
            btnFirstPage.Enabled = True
            btnPreviousPage.Enabled = True
            tbCurrentPage.Enabled = True
            lblPageCount.Enabled = True
            btnNextPage.Enabled = True
            btnLastPage.Enabled = True
            btnZoomOut.Enabled = True
            cbZoom.Enabled = True
            btnZoomIn.Enabled = True
            btnFitPage.Enabled = True
            btnFitWidth.Enabled = True
            btnRotateLeft.Enabled = True
            btnRotateRight.Enabled = True
            btnFlipX.Enabled = True
            btnFlipY.Enabled = True
            pDocumentCleanUp.Enabled = True
            UpdateaNavigationToolbar()
        End If
    End Sub

    Private Sub UpdateaNavigationToolbar()
        Dim currentPage As Integer = GdViewer1.CurrentPage()
        tbCurrentPage.Text = currentPage.ToString()
        lblPageCount.Text = "/ " & GdViewer1.PageCount.ToString()
        If currentPage = 1 Then
            btnFirstPage.Enabled = False
            btnPreviousPage.Enabled = False
        Else
            btnFirstPage.Enabled = True
            btnPreviousPage.Enabled = True
        End If
        If currentPage = GdViewer1.PageCount Then
            btnNextPage.Enabled = False
            btnLastPage.Enabled = False
        Else
            btnNextPage.Enabled = True
            btnLastPage.Enabled = True
        End If
        cbZoom.Text = String.Format(CultureInfo.InvariantCulture, "{0:#0.##%}", GdViewer1.Zoom)

        btnFlipX.Enabled = GdViewer1.GetDocumentType() = DocumentType.DocumentTypeBitmap
        btnFlipY.Enabled = GdViewer1.GetDocumentType() = DocumentType.DocumentTypeBitmap

        Dim widthInches, heightInches As Double

        If GdViewer1.GetDocumentType = DocumentType.DocumentTypePDF Then
            widthInches = GdViewer1.PdfGetPageWidth / 72
            heightInches = GdViewer1.PdfGetPageHeight / 72
        Else
            widthInches = GdViewer1.PageWidth / GdViewer1.HorizontalResolution
            heightInches = GdViewer1.PageHeight / GdViewer1.VerticalResolution
        End If

        Me.ToolStripStatusLabel1.Text = "Type: " + GetDocumentTypeLabel() + "  -  " +
                                        "Page Size (inches): " + Trim(Str(Math.Round(widthInches, 2))) + " × " + Trim(Str(Math.Round(heightInches, 2))) + "  -  " +
                                        "Page Size (pixels): " + Trim(Str(GdViewer1.PageWidth)) + " × " + Trim(Str(GdViewer1.PageHeight)) + "  -  " +
                                        "Horizontal resolution: " + Trim(Str(Math.Round(GdViewer1.HorizontalResolution, 2))) + " DPI  -  " +
                                        "Vertical resolution: " + Trim(Str(Math.Round(GdViewer1.VerticalResolution, 2))) + " DPI"
    End Sub

    Private Function GetDocumentTypeLabel() As String
        Dim result As String = ""
        Select Case GdViewer1.GetDocumentType()
            Case DocumentType.DocumentTypeBitmap
                result = "Image"
            Case DocumentType.DocumentTypeMetaFile
                result = "Metafile"
            Case DocumentType.DocumentTypePDF
                result = "PDF"
            Case DocumentType.DocumentTypeSVG
                result = "SVG"
            Case DocumentType.DocumentTypeTXT
                result = "Text file"
            Case DocumentType.DocumentTypeUnknown
                result = "Unknown"
        End Select
        Return result
    End Function

    Private Sub CloseDocument()
        If _currentImage <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_currentImage)
            _currentImage = 0
        End If
        If _currentDocumentCleanUpPreview <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_currentDocumentCleanUpPreview)
            _currentDocumentCleanUpPreview = 0
        End If
        GdViewer1.CloseDocument()
        GdViewerPreview.CloseDocument()
        ThumbnailEx1.ClearAllItems()
        UpdateMainUi()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOpen.Click
        CloseDocument()

        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeShrinkToViewerWidth
        GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter
        GdViewerPreview.ZoomMode = GdViewer1.ZoomMode
        GdViewerPreview.DocumentAlignment = GdViewer1.DocumentAlignment

        _currentImage = _gdPictureImaging.CreateGdPictureImageFromFile("")
        Dim status As GdPictureStatus = _gdPictureImaging.GetStat()
        If status <> GdPictureStatus.OK Then
            MessageBox.Show(Me, "Cannot open file : " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If _currentImage <> 0 Then
            GdViewer1.DisplayFromGdPictureImage(_currentImage)
            ThumbnailEx1.LoadFromGdViewer(GdViewer1)
            GdViewer1.Focus()
        End If
        UpdateMainUi()
    End Sub

    Private Sub btnFirstPage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFirstPage.Click
        GdViewer1.DisplayFirstPage()
    End Sub

    Private Sub btnPreviousPage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPreviousPage.Click
        GdViewer1.DisplayPreviousPage()
    End Sub

    Private Sub btnNextPage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNextPage.Click
        GdViewer1.DisplayNextPage()
    End Sub

    Private Sub btnLastPage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLastPage.Click
        GdViewer1.DisplayLastPage()
    End Sub

    Private Sub tbCurrentPage_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbCurrentPage.Leave
        Dim page As Integer = 0
        If Integer.TryParse(tbCurrentPage.Text, page) Then
            If page > 0 And page <= GdViewer1.PageCount Then
                GdViewer1.DisplayPage(page)
                UpdateaNavigationToolbar()
            End If
        End If
    End Sub

    Private Sub GdViewer1_PageChanged() Handles GdViewer1.PageChanged
        UpdateaNavigationToolbar()
    End Sub

    Private Sub ChangeZoomValue()
        If cbZoom.SelectedIndex <> -1 Then
            Select Case CType(cbZoom.SelectedIndex, ZoomMode)
                Case ZoomMode.Zoom50
                    GdViewer1.Zoom = 50.0F / 100
                Case ZoomMode.Zoom100
                    GdViewer1.Zoom = 100.0F / 100
                Case ZoomMode.Zoom150
                    GdViewer1.Zoom = 150.0F / 100
                Case ZoomMode.Zoom200
                    GdViewer1.Zoom = 250.0F / 100
                Case ZoomMode.ZoomSelectedArea
                    If GdViewer1.IsRect() Then
                        GdViewer1.ZoomRect()
                    Else
                        GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection
                        GdViewer1.Focus()
                    End If
                Case ZoomMode.ZoomFitToViewer
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
                Case ZoomMode.ZoomFitWidth
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer
                Case ZoomMode.ZoomFitHeight
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeHeightViewer
            End Select
        Else
            If (IsNumeric(Regex.Replace(cbZoom.Text, "[^0-9,.]", ""))) Then
                GdViewer1.Zoom = Val(Regex.Replace(cbZoom.Text, "[^0-9,.]", "")) / 100
            End If
        End If
        GdViewerPreview.Zoom = GdViewer1.Zoom
        UpdateaNavigationToolbar()
    End Sub

    Private Sub cbZoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbZoom.SelectedIndexChanged
        ChangeZoomValue()
    End Sub

    Private Sub GdViewer1_AfterZoomChange() Handles GdViewer1.AfterZoomChange
        UpdateaNavigationToolbar()
        GdViewerPreview.Zoom = GdViewer1.Zoom
        If GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming Then
            GdViewer1.MouseMode = ViewerMouseMode.MouseModePan
        End If
    End Sub

    Private Sub btnZoomOut_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnZoomOut.Click
        GdViewer1.ZoomOUT()
        GdViewerPreview.Zoom = GdViewer1.Zoom
    End Sub

    Private Sub btnZoomIn_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnZoomIn.Click
        GdViewer1.ZoomIN()
        GdViewerPreview.Zoom = GdViewer1.Zoom
    End Sub

    Private Sub cbZoom_TextUpdate(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbZoom.Validating
        ChangeZoomValue()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAbout.Click
        Using frmAbout As New frmAbout()
            frmAbout.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPrint.Click
        If GdViewer1.PageCount = 0 Then
            Return
        End If
        Using f As New frmPrint(GdViewer1)
            f.ShowDialog(Me)
            If f.DialogResult <> DialogResult.OK Then
                Return
            End If
            Dim printSettings As frmPrint.PrintSettings = f.printConfiguration
            If Not GdViewer1.PrintSetActivePrinter(printSettings.Printer) Then
                Return
            End If
            GdViewer1.PrintSetDocumentName("GdPicture Print Job " + DateTime.Now.ToString("yyyy-MM-dd HH\mm"))
            GdViewer1.PrintSetAlignment(printSettings.PrintAlignment)
            Select Case printSettings.Orientation
                Case frmPrint.PrintOrientation.AutoDetection
                    GdViewer1.PrintSetAutoRotation(True)
                    Exit Select
                Case frmPrint.PrintOrientation.Portrait
                    GdViewer1.PrintSetAutoRotation(False)
                    GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationPortrait)
                    Exit Select
                Case frmPrint.PrintOrientation.Paysage
                    GdViewer1.PrintSetAutoRotation(False)
                    GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationLandscape)
                    Exit Select
            End Select
            GdViewer1.PrintSetCopies(printSettings.Copies)
            If printSettings.Copies > 1 Then
                GdViewer1.PrintSetCollate(printSettings.Collate)
            End If
            Select Case printSettings.PagesToPrint
                Case frmPrint.PagesToPrint.All
                    GdViewer1.PrintSetFromToPage(1, GdViewer1.PageCount)
                    GdViewer1.Print(printSettings.PrintSize)
                    Exit Select
                Case frmPrint.PagesToPrint.Current
                    GdViewer1.PrintSetFromToPage(GdViewer1.CurrentPage, GdViewer1.CurrentPage)
                    GdViewer1.Print(printSettings.PrintSize)
                    Exit Select
                Case frmPrint.PagesToPrint.Selection
                    Dim range As String = GetSelectedItemAsRange()
                    If Not String.IsNullOrWhiteSpace(range) Then
                        GdViewer1.PrintSetPageSelection(range)
                        GdViewer1.Print(printSettings.PrintSize)
                    End If
                    Exit Select
                Case frmPrint.PagesToPrint.Range
                    If printSettings.PageRange IsNot Nothing And printSettings.PageRange <> String.Empty Then
                        If printSettings.PageRange.Contains("-") Then
                            Dim pageStart As Integer = 0
                            If Integer.TryParse(printSettings.PageRange.Split("-"c)(0), pageStart) Then
                                Dim pageEnd As Integer = 0
                                If Integer.TryParse(printSettings.PageRange.Split("-"c)(1), pageEnd) Then
                                    If pageEnd < pageStart Then
                                        GdViewer1.PrintSetFromToPage(pageEnd, pageStart)
                                        GdViewer1.Print(printSettings.PrintSize)
                                    Else
                                        GdViewer1.PrintSetFromToPage(pageStart, pageEnd)
                                        GdViewer1.Print(printSettings.PrintSize)
                                    End If
                                Else
                                    MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                                End If
                            Else
                                MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                            End If
                        Else
                            Dim page As Integer = 0
                            If Integer.TryParse(printSettings.PageRange, page) Then
                                GdViewer1.PrintSetFromToPage(page, page)
                                GdViewer1.Print(printSettings.PrintSize)
                            Else
                                MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                            End If
                        End If
                    Else
                        MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End If
                    Exit Select
            End Select
        End Using
    End Sub

    Private Function GetSelectedItemAsRange() As String
        Dim count As Integer = 0
        For i As Integer = 0 To ThumbnailEx1.ItemCount - 1
            If ThumbnailEx1.GetItemCheckState(i) = True Then
                count += 1
            End If
        Next
        If count = 0 Then
            If MessageBox.Show("No page has been selected, do you want to save all pages?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                For i As Integer = 0 To ThumbnailEx1.ItemCount - 1
                    ThumbnailEx1.SetItemCheckState(i, True)
                Next
                count = ThumbnailEx1.ItemCount
            End If
        End If
        If count > 0 Then
            Dim sb As New StringBuilder
            For i As Integer = 0 To ThumbnailEx1.ItemCount
                If ThumbnailEx1.GetItemCheckState(i) = True Then
                    If sb.Length <> 0 Then
                        sb.Append(";")
                    End If
                    sb.Append(i + 1)
                End If
            Next

            Return sb.ToString()
        Else
            Return ""
        End If
    End Function

    Private Sub btnRotateLeft_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRotateLeft.Click
        GdViewer1.Rotate(RotateFlipType.Rotate270FlipNone)
        GdViewerPreview.Rotate(RotateFlipType.Rotate270FlipNone)
    End Sub

    Private Sub btnRotateRight_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRotateRight.Click
        GdViewer1.Rotate(RotateFlipType.Rotate90FlipNone)
        GdViewerPreview.Rotate(RotateFlipType.Rotate90FlipNone)
    End Sub

    Private Sub btnFlipX_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFlipX.Click
        GdViewer1.Rotate(RotateFlipType.RotateNoneFlipX)
        GdViewerPreview.Rotate(RotateFlipType.RotateNoneFlipX)
    End Sub

    Private Sub btnFlipY_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFlipY.Click
        GdViewer1.Rotate(RotateFlipType.RotateNoneFlipY)
        GdViewerPreview.Rotate(RotateFlipType.RotateNoneFlipY)
    End Sub

    Private Sub GdViewer1_TransferEnded(ByVal status As GdPictureStatus, ByVal download As System.Boolean) Handles GdViewer1.TransferEnded
        GdViewer1.Focus()
        ThumbnailEx1.LoadFromGdViewer(GdViewer1)
        UpdateMainUi()
    End Sub

    Private Sub cbZoom_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbZoom.Validating
        ChangeZoomValue()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        CloseDocument()
        UpdateMainUi()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSettings.Click
        Using frmSettings As New frmSettings(GdViewer1)
            frmSettings.ShowDialog(Me)
        End Using

        GdViewerPreview.DocumentAlignment = GdViewer1.DocumentAlignment
        GdViewerPreview.DocumentPosition = GdViewer1.DocumentPosition
        GdViewerPreview.DisplayQuality = GdViewer1.DisplayQuality
        GdViewerPreview.DisplayQualityAuto = GdViewer1.DisplayQualityAuto
        GdViewerPreview.BackColor = GdViewer1.BackColor
        GdViewerPreview.IgnoreDocumentResolution = GdViewer1.IgnoreDocumentResolution
        GdViewerPreview.AnnotationDropShadow = GdViewer1.AnnotationDropShadow
        GdViewerPreview.HQAnnotationRendering = GdViewer1.HQAnnotationRendering
        GdViewerPreview.EnableICM = GdViewer1.EnableICM

        ThumbnailEx1.PdfIncreaseTextContrast = GdViewer1.PdfIncreaseTextContrast
        UpdateaNavigationToolbar()
    End Sub

    Private Sub btnFitWidth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFitWidth.Click
        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer
        GdViewerPreview.ZoomMode = GdViewer1.ZoomMode
    End Sub

    Private Sub btnFitPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFitPage.Click
        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
        GdViewerPreview.ZoomMode = GdViewer1.ZoomMode
    End Sub

    Private Sub SelectSnapIn(ByVal num As Integer, ByVal title As String)
        tcLeftPanel.SelectedIndex = num
        lblSnapInPanel.Text = title
        For i As Integer = 0 To pSnapInButtons.Controls.Count - 1
            If i = num Then
                pSnapInButtons.Controls(i).BackColor = SystemColors.Control
                CType(pSnapInButtons.Controls(i), Button).FlatAppearance.BorderColor = SystemColors.Control
            Else
                pSnapInButtons.Controls(i).BackColor = SystemColors.AppWorkspace
                CType(pSnapInButtons.Controls(i), Button).FlatAppearance.BorderColor = SystemColors.AppWorkspace
            End If
        Next
    End Sub

    Private Sub btnSnapInThumbnails_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSnapInThumbnails.Click
        SelectSnapIn(0, "Thumbnails")
    End Sub

    Private Sub btnSnapInDocumentCleanUp_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSnapInDocumentCleanUp.Click
        SelectSnapIn(1, "Document clean up")
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles DefaultToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeDefault
        GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeDefault
        DefaultToolStripMenuItem.Checked = True
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub AreaSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AreaSelectionToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection
        GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeDefault
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = True
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub PanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles PanToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModePan
        GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeDefault
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = True
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub AreaZoomingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AreaZoomingToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming
        GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeDefault
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = True
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub MagnifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MagnifierToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeMagnifier
        GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeMagnifier
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = True
        GdViewer1.Focus()
    End Sub

    Private Sub SmallThumbnailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SmallThumbnailsToolStripMenuItem1.Click
        ThumbnailEx1.ThumbnailSize = New Size(64, 64)
        SmallThumbnailsToolStripMenuItem1.Checked = True
        MediumThumbnailsToolStripMenuItem1.Checked = False
        LargeThumbnailsToolStripMenuItem1.Checked = False
    End Sub

    Private Sub MediumThumbnailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MediumThumbnailsToolStripMenuItem1.Click
        ThumbnailEx1.ThumbnailSize = New Size(128, 128)
        SmallThumbnailsToolStripMenuItem1.Checked = False
        MediumThumbnailsToolStripMenuItem1.Checked = True
        LargeThumbnailsToolStripMenuItem1.Checked = False
    End Sub

    Private Sub LargeThumbnailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles LargeThumbnailsToolStripMenuItem1.Click
        ThumbnailEx1.ThumbnailSize = New Size(256, 256)
        SmallThumbnailsToolStripMenuItem1.Checked = False
        MediumThumbnailsToolStripMenuItem1.Checked = False
        LargeThumbnailsToolStripMenuItem1.Checked = True
    End Sub

    Private Sub ResetDocumentCleanUpValues()
        _documentCleanUpEffectsQueue.Clear()
        ChangeDocumentCleanUpValues()
        UpdateEffectUi()
    End Sub

    Private Sub CreateDocumentCleanUpPreviewImage()
        If _currentImage = 0 Then
            Return
        End If
        If _currentDocumentCleanUpPreview <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_currentDocumentCleanUpPreview)
            GdViewerPreview.CloseDocument()
        End If
        _currentDocumentCleanUpPreview = _gdPictureImaging.CreateClonedGdPictureImage(_currentImage)
    End Sub

    Private Sub DisplayDocumentCleanUpPreviewImage()
        If _currentDocumentCleanUpPreview <> 0 Then
            GdViewerPreview.DisplayFromGdPictureImage(_currentDocumentCleanUpPreview)
            GdViewerPreview.SetVScrollBarPosition(GdViewer1.GetVScrollBarPosition())
            GdViewerPreview.SetHScrollBarPosition(GdViewer1.GetHScrollBarPosition())
        End If
    End Sub

    Private Sub ChangeDocumentCleanUpValues()
        CreateDocumentCleanUpPreviewImage()
        If _currentDocumentCleanUpPreview <> 0 Then
            ApplyDocumentCleanUpValues(_currentDocumentCleanUpPreview)
            DisplayDocumentCleanUpPreviewImage()
        End If
    End Sub

    Private Sub ApplyDocumentCleanUpValues(ByVal image As Integer)
        Dim status As GdPictureStatus = GdPictureStatus.Aborted
        For Each item In _documentCleanUpEffectsQueue
            Select Case item.GetType()
                Case GetType(AutoDeskewEffect)
                    Dim params As AutoDeskewEffectParameters = CType(item.Parameters, AutoDeskewEffectParameters)
                    status = _gdPictureImaging.AutoDeskew(image, params.MaxAngleOfResearch, params.BackColor, params.AngleStep, params.Optimistic)
                Case GetType(AutoInvertEffect)
                    If _gdPictureImaging.IsNegative(image) Then
                        _gdPictureImaging.FxNegative(image)
                    End If
                Case GetType(AutoTextInvertEffect)
                    Dim params As AutoTextInvertEffectParameters = CType(item.Parameters, AutoTextInvertEffectParameters)
                    status = _gdPictureImaging.AutoTextInvert(image, params.MinObjectWidth, params.MinObjectHeight, params.MinBlackPercent, params.MaxBlackPercent, params.FixBackground, params.ConnectedToLines, params.MaxLinesThickness)
                Case GetType(CropBlackBordersEffect)
                    Dim params As CropBlackBordersEffectParameters = CType(item.Parameters, CropBlackBordersEffectParameters)
                    status = _gdPictureImaging.CropBlackBorders(image, params.Confidence, params.SkipLinesCount)
                Case GetType(CropBlackBordersExEffect)
                    Dim params As CropBlackBordersEffectExParameters = CType(item.Parameters, CropBlackBordersEffectExParameters)
                    status = _gdPictureImaging.CropBlackBordersEx(image, params.Confidence, params.SkipLinesCount)
                Case GetType(CropBordersEffect)
                    Dim params As CropBordersEffectParameters = CType(item.Parameters, CropBordersEffectParameters)
                    status = _gdPictureImaging.CropBorders(image, params.Confidence, params.PixelReference, params.Left, params.Top, params.Width, params.Height, params.Context)
                    If status = GdPictureStatus.OK Then
                        status = _gdPictureImaging.Crop(image, params.Left, params.Top, params.Width, params.Height)
                    End If
                Case GetType(CropWhiteBordersEffect)
                    Dim params As CropWhiteBordersEffectParameters = CType(item.Parameters, CropWhiteBordersEffectParameters)
                    status = _gdPictureImaging.CropWhiteBorders(image, params.Confidence, params.SkipLinesCount)
                Case GetType(DeleteBlackBordersEffect)
                    Dim params As DeleteBlackBordersEffectParameters = CType(item.Parameters, DeleteBlackBordersEffectParameters)
                    status = _gdPictureImaging.DeleteBlackBorders(image, params.Margin, params.SkewedBorders)
                Case GetType(DespeckleEffect)
                    status = _gdPictureImaging.FxDespeckle(image)
                Case GetType(DespeckleMoreEffect)
                    status = _gdPictureImaging.FxDespeckleMore(image)
                Case GetType(DespeckleAdvancedEffect)
                    Dim params As DespeckAdvancedParameters = CType(item.Parameters, DespeckAdvancedParameters)
                    status = _gdPictureImaging.FxBitonalDespeckleAdvanced(image, params.DespeckleMode, params.Strength)
                Case GetType(MedianEffect)
                    Dim params As MedianEffectParameters = CType(item.Parameters, MedianEffectParameters)
                    status = _gdPictureImaging.FxMedian(image, params.KernelSize)
                Case GetType(RemoveBlobEffect)
                    Dim params As RemoveBlobEffectParameters = CType(item.Parameters, RemoveBlobEffectParameters)
                    status = _gdPictureImaging.RemoveBlob(image, params.MinBlobWidth, params.MinBlobHeight, params.MaxBlobWidth, params.MaxBlobHeight, params.MinFillPercent, params.MaxFillPercent)
                Case GetType(RemoveHolePunchEffect)
                    Dim params As RemoveHolePunchEffectParameters = CType(item.Parameters, RemoveHolePunchEffectParameters)
                    status = _gdPictureImaging.RemoveHolePunch(image, params.Margins)
                Case GetType(RemoveLinesEffect)
                    Dim params As RemoveLinesEffectParameters = CType(item.Parameters, RemoveLinesEffectParameters)
                    status = _gdPictureImaging.RemoveLines(image, params.Orientation, params.MaxLineGap, params.MaxLineThickness, params.MinLineLength, params.MaxInterception, params.ReConnectBrokenCharacters)
                Case GetType(RemoveStapleMarkEffect)
                    status = _gdPictureImaging.RemoveStapleMark(image)
                Case GetType(BitonalClose8Effect)
                    status = _gdPictureImaging.FxBitonalClose8(image)
                Case GetType(BitonalDespeckleEffect)
                    Dim params As BitonalDespeckleEffectParameters = CType(item.Parameters, BitonalDespeckleEffectParameters)
                    status = _gdPictureImaging.FxBitonalDespeckle(image, params.FixText)
                Case GetType(BitonalDespeckleMoreEffect)
                    Dim params As BitonalDespeckleMoreEffectParameters = CType(item.Parameters, BitonalDespeckleMoreEffectParameters)
                    status = _gdPictureImaging.FxBitonalDespeckleMore(image, params.FixText)
                Case GetType(BitonalOutlineEffect)
                    status = _gdPictureImaging.FxBitonalOutline(image)
                Case GetType(BitonalSkeletonizeEffect)
                    Dim params As BitonalSkeletonizeEffectParameters = CType(item.Parameters, BitonalSkeletonizeEffectParameters)
                    status = _gdPictureImaging.FxBitonalSkeletonize(image, params.Repetition)
                Case GetType(BitonalVigorousDespeckleEffect)
                    Dim params As BitonalVigorousDespeckleEffectParameters = CType(item.Parameters, BitonalVigorousDespeckleEffectParameters)
                    status = _gdPictureImaging.FxBitonalVigorousDespeckle(image, params.CheckForDotOfI)
                Case GetType(BitonalDilateEFfect)
                    Dim params As BitonalDilateEffectParameters = CType(item.Parameters, BitonalDilateEffectParameters)
                    status = _gdPictureImaging.FxBitonalDilate(image, params.KernelSize)
                Case GetType(BitonalDilate4EFfect)
                    status = _gdPictureImaging.FxBitonalDilate4(image)
                Case GetType(BitonalDilate8EFfect)
                    status = _gdPictureImaging.FxBitonalDilate8(image)
                Case GetType(BitonalDilateHEFfect)
                    status = _gdPictureImaging.FxBitonalDilateH(image)
                Case GetType(BitonalDilateVEFfect)
                    status = _gdPictureImaging.FxBitonalDilateV(image)
                Case GetType(BitonalErodeEFfect)
                    Dim params As BitonalErodeEffectParameters = CType(item.Parameters, BitonalErodeEffectParameters)
                    status = _gdPictureImaging.FxBitonalErode(image, params.KernelSize)
                Case GetType(BitonalErode4EFfect)
                    status = _gdPictureImaging.FxBitonalErode4(image)
                Case GetType(BitonalErode8EFfect)
                    status = _gdPictureImaging.FxBitonalErode8(image)
                Case GetType(BitonalErodeVEFfect)
                    status = _gdPictureImaging.FxBitonalErodeV(image)
                Case GetType(BitonalFillHolesHEFfect)
                    status = _gdPictureImaging.FxBitonalFillHolesH(image)
                Case GetType(BitonalFillHolesHVEFfect)
                    status = _gdPictureImaging.FxBitonalFillHolesHV(image)
                Case GetType(BitonalFillHolesVEFfect)
                    status = _gdPictureImaging.FxBitonalFillHolesV(image)
                Case GetType(BitonalOpen8EFfect)
                    status = _gdPictureImaging.FxBitonalOpen8(image)
                Case GetType(BitonalRemoveIsolatedDots2x2EFfect)
                    status = _gdPictureImaging.FxBitonalRemoveIsolatedDots2x2(image)
                Case GetType(BitonalRemoveIsolatedDots4EFfect)
                    status = _gdPictureImaging.FxBitonalRemoveIsolatedDots4(image)
                Case GetType(BitonalRemoveIsolatedDots8EFfect)
                    status = _gdPictureImaging.FxBitonalRemoveIsolatedDots8(image)
            End Select
            If status <> GdPictureStatus.OK Then
                MessageBox.Show(Me, "Cannot apply effect " + item.Name + ": " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next
    End Sub

    Private Sub btnResetEffects_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnResetEffects.Click
        ResetDocumentCleanUpValues()
    End Sub

    Private Sub btnCopyToClipboard_Click(sender As Object, e As EventArgs) Handles btnCopyToClipboard.Click
        _gdPictureImaging.CopyToClipboard(_currentImage)
    End Sub

    Private Sub btnImportFromClipboard_Click(sender As Object, e As EventArgs) Handles btnImportFromClipboard.Click
        CloseDocument()
        _currentImage = _gdPictureImaging.CreateGdPictureImageFromClipboard()
        If _currentImage = 0 Then
            MessageBox.Show("There is no bitmap in the clipboard")
        Else
            GdViewer1.DisplayFromGdPictureImage(_currentImage)
        End If
        UpdateMainUi()
    End Sub

    Private Sub btnApplyEffects_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnApplyEffects.Click
        If GdViewer1.IsRect() Then
            Dim roiLeft As Integer = 0
            Dim roiWidth As Integer = 0
            Dim roiTop As Integer = 0
            Dim roiHeight As Integer = 0
            GdViewer1.GetRectCoordinatesOnDocument(roiLeft, roiTop, roiWidth, roiHeight)
            If roiHeight <> 0 And roiWidth <> 0 Then
                _gdPictureImaging.SetROI(roiLeft, roiTop, roiWidth, roiHeight)
            End If
        Else
            _gdPictureImaging.ResetROI()
        End If
        CreateDocumentCleanUpPreviewImage()
        ApplyDocumentCleanUpValues(_currentDocumentCleanUpPreview)
        _gdPictureImaging.ResetROI()
        GdViewer1.ClearRect()
        DisplayDocumentCleanUpPreviewImage()
        UpdateEffectUi()
    End Sub

    Private Sub lstEffects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lstEffects.SelectedIndexChanged
        UpdateEffectUi()
    End Sub

    Private Sub SplitContainer1_Resize(ByVal sender As System.Object, ByVal e As EventArgs) Handles SplitContainer1.Resize
        SplitContainer1.SplitterDistance = CInt(SplitContainer1.Width / 2)
    End Sub

    Private Sub btnAddEffect_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAddEffect.Click
        If cbDocumentCleanUpEffects.SelectedIndex <> -1 Then
            _documentCleanUpEffectsQueue.Add(_documentCleanUpEffects.List.Item(cbDocumentCleanUpEffects.SelectedIndex).Clone())
            lstEffects.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnRemoveEffect_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRemoveEffect.Click
        If lstEffects.SelectedIndex <> -1 Then
            _documentCleanUpEffectsQueue.RemoveAt(lstEffects.SelectedIndex)
        End If
    End Sub

    Private Sub btnRemoveAllEffects_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRemoveAllEffects.Click
        _documentCleanUpEffectsQueue.Clear()
    End Sub

    Private Sub pAutoDeskewBackColor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pAutoDeskewBackColor.Click
        Using colorDialog As New ColorDialog
            If colorDialog.ShowDialog() = DialogResult.OK Then
                pAutoDeskewBackColor.BackColor = colorDialog.Color
            End If
        End Using
    End Sub

    Private Sub GdViewer1_ScrollViewer() Handles GdViewer1.ScrollViewer
        GdViewerPreview.SetHVScrollBarPosition(GdViewer1.GetHScrollBarPosition(), GdViewer1.GetVScrollBarPosition())
    End Sub

    Private Sub UpdateEffectUi()
        tbEffectsParameters.Visible = lstEffects.SelectedIndex <> -1
        If lstEffects.SelectedIndex <> -1 Then
            Dim effect As ADocumentCleanUpEffect = _documentCleanUpEffectsQueue(lstEffects.SelectedIndex)
            Select Case effect.GetType()
                Case GetType(AutoDeskewEffect)
                    nAutoDeskewMaxAngleOfResearch.DataBindings.Clear()
                    nAutoDeskewMaxAngleOfResearch.DataBindings.Add(New Binding("Value", effect.Parameters, "MaxAngleOfResearch"))
                    pAutoDeskewBackColor.DataBindings.Clear()
                    pAutoDeskewBackColor.DataBindings.Add("BackColor", effect.Parameters, "BackColor", True, DataSourceUpdateMode.OnPropertyChanged)
                    nAutoDeskewAngleStep.DataBindings.Clear()
                    nAutoDeskewAngleStep.DataBindings.Add("Value", effect.Parameters, "AngleStep")
                    chkAutoDeskewOptimistic.DataBindings.Clear()
                    chkAutoDeskewOptimistic.DataBindings.Add("Checked", effect.Parameters, "Optimistic")
                    tbEffectsParameters.SelectedTab = tpAutoDeskewParameters
                Case GetType(AutoTextInvertEffect)
                    nAutoInvertTextMinObjectWidth.DataBindings.Clear()
                    nAutoInvertTextMinObjectWidth.DataBindings.Add("Value", effect.Parameters, "MinObjectWidth")
                    nAutoInvertTextMinObjectHeight.DataBindings.Clear()
                    nAutoInvertTextMinObjectHeight.DataBindings.Add("Value", effect.Parameters, "MinObjectHeight")
                    nAutoInvertTextMinBlackPercent.DataBindings.Clear()
                    nAutoInvertTextMinBlackPercent.DataBindings.Add("Value", effect.Parameters, "MinBlackPercent")
                    nAutoInvertTextMaxBlackPercent.DataBindings.Clear()
                    nAutoInvertTextMaxBlackPercent.DataBindings.Add("Value", effect.Parameters, "MaxBlackPercent")
                    chkAutoTextInvertFixBackground.DataBindings.Clear()
                    chkAutoTextInvertFixBackground.DataBindings.Add("Checked", effect.Parameters, "FixBackground")
                    chkAutoTextInvertConnectedToLines.DataBindings.Clear()
                    chkAutoTextInvertConnectedToLines.DataBindings.Add("Checked", effect.Parameters, "ConnectedToLines")
                    nAutoInvertTextMaxLinesThickness.DataBindings.Clear()
                    nAutoInvertTextMaxLinesThickness.DataBindings.Add("Value", effect.Parameters, "MaxLinesThickness")
                    tbEffectsParameters.SelectedTab = tpAutoTextInvert
                Case GetType(CropBlackBordersEffect), GetType(CropBlackBordersExEffect), GetType(CropWhiteBordersEffect)
                    nCropBlackBordersConfidence.DataBindings.Clear()
                    nCropBlackBordersConfidence.DataBindings.Add("Value", effect.Parameters, "Confidence")
                    nCropBlackBordersSkipLinesCount.DataBindings.Clear()
                    nCropBlackBordersSkipLinesCount.DataBindings.Add("Value", effect.Parameters, "SkipLinesCount")
                    tbEffectsParameters.SelectedTab = tpCropBlackBorders
                Case GetType(CropBordersEffect)
                    nCropBordersConfidence.DataBindings.Clear()
                    nCropBordersConfidence.DataBindings.Add("Value", effect.Parameters, "Confidence")
                    cbCropBordersReferencePoint.DataBindings.Clear()
                    cbCropBordersReferencePoint.DataBindings.Add("SelectedValue", effect.Parameters, "PixelReference")
                    nCropBordersLeft.DataBindings.Clear()
                    nCropBordersLeft.DataBindings.Add("Value", effect.Parameters, "Left")
                    nCropBordersTop.DataBindings.Clear()
                    nCropBordersTop.DataBindings.Add("Value", effect.Parameters, "Top")
                    nCropBordersWidth.DataBindings.Clear()
                    nCropBordersWidth.DataBindings.Add("Value", effect.Parameters, "Width")
                    nCropBordersHeight.DataBindings.Clear()
                    nCropBordersHeight.DataBindings.Add("Value", effect.Parameters, "Height")
                    cbCropBordersImageContext.DataBindings.Clear()
                    cbCropBordersImageContext.DataBindings.Add("SelectedValue", effect.Parameters, "Context")
                    tbEffectsParameters.SelectedTab = tpCropBorders
                Case GetType(DeleteBlackBordersEffect)
                    nDeleteBlackBorderEffectMargin.DataBindings.Clear()
                    nDeleteBlackBorderEffectMargin.DataBindings.Add("Value", effect.Parameters, "Margin")
                    chkDeleteBlackBordersEffectSkewedBorders.DataBindings.Clear()
                    chkDeleteBlackBordersEffectSkewedBorders.DataBindings.Add("Checked", effect.Parameters, "SkewedBorders")
                    tbEffectsParameters.SelectedTab = tpDeleteBlackBorders
                Case GetType(DespeckleAdvancedEffect)
                    cbDespeckleType.DataBindings.Clear()
                    cbDespeckleType.DataBindings.Add("SelectedValue", effect.Parameters, "DespeckleMode")
                    nDespeckleStrength.DataBindings.Clear()
                    nDespeckleStrength.DataBindings.Add("Value", effect.Parameters, "Strength")
                    tbEffectsParameters.SelectedTab = tpDespeckleAdvanced
                Case GetType(MedianEffect)
                    nMedianEffectKernelSize.DataBindings.Clear()
                    nMedianEffectKernelSize.DataBindings.Add("Value", effect.Parameters, "KernelSize")
                    tbEffectsParameters.SelectedTab = tpMedian
                Case GetType(RemoveBlobEffect)
                    nRemoveBlobEffectMinBlobWidth.DataBindings.Clear()
                    nRemoveBlobEffectMinBlobWidth.DataBindings.Add("Value", effect.Parameters, "MinBlobWidth")
                    nRemoveBlobEffectMinBlobHeight.DataBindings.Clear()
                    nRemoveBlobEffectMinBlobHeight.DataBindings.Add("Value", effect.Parameters, "MinBlobHeight")
                    nRemoveBlobEffectMaxBlobWidth.DataBindings.Clear()
                    nRemoveBlobEffectMaxBlobWidth.DataBindings.Add("Value", effect.Parameters, "MaxBlobWidth")
                    nRemoveBlobEffectMaxBlobHeight.DataBindings.Clear()
                    nRemoveBlobEffectMaxBlobHeight.DataBindings.Add("Value", effect.Parameters, "MaxBlobHeight")
                    nRemoveBlobEffectMinFillPercent.DataBindings.Clear()
                    nRemoveBlobEffectMinFillPercent.DataBindings.Add("Value", effect.Parameters, "MinFillPercent")
                    nRemoveBlobEffectMaxFillPercent.DataBindings.Clear()
                    nRemoveBlobEffectMaxFillPercent.DataBindings.Add("Value", effect.Parameters, "MaxFillPercent")
                    tbEffectsParameters.SelectedTab = tpRemoveBlob
                Case GetType(RemoveHolePunchEffect)
                    cbRemoveHolePunchEffectMargins.DataBindings.Clear()
                    cbRemoveHolePunchEffectMargins.DataBindings.Add("SelectedValue", effect.Parameters, "Margins")
                    tbEffectsParameters.SelectedTab = tpRemoveHolePunch
                Case GetType(RemoveLinesEffect)
                    cbRemoveLinesEffectOrientation.DataBindings.Clear()
                    cbRemoveLinesEffectOrientation.DataBindings.Add("SelectedValue", effect.Parameters, "Orientation")
                    nRemoveLinesEffectMaxLineGap.DataBindings.Clear()
                    nRemoveLinesEffectMaxLineGap.DataBindings.Add("Value", effect.Parameters, "MaxLineGap")
                    nRemoveLinesEffectMaxLineThickness.DataBindings.Clear()
                    nRemoveLinesEffectMaxLineThickness.DataBindings.Add("Value", effect.Parameters, "MaxLineThickness")
                    nRemoveLinesEffectMinLineLength.DataBindings.Clear()
                    nRemoveLinesEffectMinLineLength.DataBindings.Add("Value", effect.Parameters, "MinLineLength")
                    nRemoveLinesEffectMaxInterception.DataBindings.Clear()
                    nRemoveLinesEffectMaxInterception.DataBindings.Add("Value", effect.Parameters, "MaxInterception")
                    chkRemoveLinesEffectReconnectBrokenCharacters.DataBindings.Clear()
                    chkRemoveLinesEffectReconnectBrokenCharacters.DataBindings.Add("Checked", effect.Parameters, "ReConnectBrokenCharacters")
                    tbEffectsParameters.SelectedTab = tpRemoveLines
                Case GetType(BitonalDespeckleEffect), GetType(BitonalDespeckleMoreEffect)
                    chkBitonalDespeckleEffectFixText.DataBindings.Clear()
                    chkBitonalDespeckleEffectFixText.DataBindings.Add("Checked", effect.Parameters, "FixText")
                    tbEffectsParameters.SelectedTab = tpBitonalDespeckle
                Case GetType(BitonalSkeletonizeEffect)
                    nBitonalSkeletonizeEffectRepetition.DataBindings.Clear()
                    nBitonalSkeletonizeEffectRepetition.DataBindings.Add("Value", effect.Parameters, "Repetition")
                    tbEffectsParameters.SelectedTab = tpBitonalSkeletonize
                Case GetType(BitonalVigorousDespeckleEffect)
                    chkBitonalVigorousDespeckleEffectCheckForDotOfI.DataBindings.Clear()
                    chkBitonalVigorousDespeckleEffectCheckForDotOfI.DataBindings.Add("Checked", effect.Parameters, "CheckForDotOfI")
                    tbEffectsParameters.SelectedTab = tpBitonalVigorousDespeckle
                Case GetType(BitonalDilateEFfect), GetType(BitonalErodeEFfect)
                    nBitonalDilateEffectKernelSize.DataBindings.Clear()
                    nBitonalDilateEffectKernelSize.DataBindings.Add("Value", effect.Parameters, "KernelSize")
                    tbEffectsParameters.SelectedTab = tpBitonalDilate
                Case Else
                    tbEffectsParameters.Visible = False
            End Select
        End If
    End Sub

    Private Sub btnMoveEffectUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveEffectUp.Click
        If lstEffects.SelectedIndex = -1 Then
            Return
        End If
        Dim item As ADocumentCleanUpEffect = _documentCleanUpEffectsQueue(lstEffects.SelectedIndex)
        Dim index As Integer = _documentCleanUpEffectsQueue.IndexOf(item)
        If index = 0 Then
            Return
        End If
        _documentCleanUpEffectsQueue.RemoveAt(index)
        _documentCleanUpEffectsQueue.Insert(index - 1, item)
        lstEffects.SelectedIndex = -1
    End Sub

    Private Sub btnMoveEffectDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveEffectDown.Click
        If lstEffects.SelectedIndex = -1 Then
            Return
        End If
        Dim item As ADocumentCleanUpEffect = _documentCleanUpEffectsQueue(lstEffects.SelectedIndex)
        Dim index As Integer = _documentCleanUpEffectsQueue.IndexOf(item)
        If index = _documentCleanUpEffectsQueue.Count - 1 Then
            Return
        End If
        _documentCleanUpEffectsQueue.RemoveAt(index)
        _documentCleanUpEffectsQueue.Insert(index + 1, item)
        lstEffects.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    Using f As New frmSave(_currentDocumentCleanUpPreview)
      f.ShowDialog(Me)
    End Using
  End Sub
End Class
