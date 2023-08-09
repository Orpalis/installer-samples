Option Strict On
Option Explicit On

Imports System.Drawing.Drawing2D
Imports GdPicture14
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Text

Public Class FrmMain

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim oLicenceManager As New GdPicture14.LicenseManager()
        oLicenceManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.

        tcLeftPanel.Appearance = TabAppearance.FlatButtons
        tcLeftPanel.ItemSize = New Size(0, 1)
        tcLeftPanel.SizeMode = TabSizeMode.Fixed
        SelectSnapIn(1, "Image properties")

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

        For Each item In _interPolationModes
            cbResampling.Items.Add(item.Value)
        Next
        cbResampling.SelectedIndex = 6

        For Each item In _pixelConversions
            cbPixelConversion.Items.Add(item.Value)
        Next
        cbPixelConversion.SelectedIndex = -1

        For Each item In _swapColors
            cbSwapColor.Items.Add(item.Value)
        Next
        cbSwapColor.SelectedIndex = -1

        For Each item In _directEffects
            cbDirectEffects.Items.Add(item.Value)
        Next
        cbDirectEffects.SelectedIndex = -1

        For Each item In _configurableEffects
            cbConfigurableEffects.Items.Add(item.Value)
        Next
        cbConfigurableEffects.SelectedIndex = -1

        For Each item In _convolutionMatrixFilters
            cbConvolutionMatrix.Items.Add(item.Value)
        Next
        cbConvolutionMatrix.SelectedIndex = -1

        UpdateMainUi()
    End Sub

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

    Private ReadOnly _interPolationModes As New Dictionary(Of InterpolationMode, String) From {
        {InterpolationMode.Low, "Low"},
        {InterpolationMode.High, "High"},
        {InterpolationMode.Bilinear, "Bilinear"},
        {InterpolationMode.Bicubic, "Bicubic"},
        {InterpolationMode.NearestNeighbor, "Nearest Neighbor"},
        {InterpolationMode.HighQualityBilinear, "High Quality Bilinear"},
        {InterpolationMode.HighQualityBicubic, "High Quality Bicubic"}
    }

    Private ReadOnly _pixelConversions As New Dictionary(Of Integer, String) From {
        {0, "1-bit per pixel (Linear)"},
        {1, "1-bit per pixel (Adaptive)"},
        {2, "1-bit per pixel (Nearest color)"},
        {3, "1-bit per pixel (Ordered dither)"},
        {4, "1-bit per pixel (Burke)"},
        {5, "1-bit per pixel (Stucki)"},
        {6, "1-bit per pixel (Floyd Steinberg)"},
        {7, "1-bit per pixel (Sauvola)"},
        {8, "1-bit per pixel (Bradley)"},
        {9, "4-bits per pixel (Indexed)"},
        {10, "4-bits per pixel (Quantized)"},
        {11, "8-bits per pixel (Grayscale)"},
        {12, "8-bits per pixel (Color)"},
        {13, "16-bits per pixel (RGB555)"},
        {14, "16-bits per pixel (RGB565)"},
        {15, "24-bits per pixel (RGB)"},
        {16, "32-bits per pixel (RGB)"},
        {17, "32-bits per pixel (ARGB)"},
        {18, "32-bits per pixel (PARGB)"},
        {19, "48-bits per pixel (RGB)"},
        {20, "64-bits per pixel (ARGB)"},
        {21, "64-bits per pixel (PARGB)"}
    }

    Private ReadOnly _swapColors As New Dictionary(Of Integer, String) From {
        {0, "RGB to BGR"},
        {1, "RGB to BRG"},
        {2, "RGB to GBR"},
        {3, "RGB to GRB"},
        {4, "RGB to RBG"}
    }

    Private ReadOnly _directEffects As New Dictionary(Of Integer, String) From {
        {0, "Add noise"},
        {1, "Aqua"},
        {2, "Blur"},
        {3, "Connected contour"},
        {4, "Contour"},
        {5, "Diffuse"},
        {6, "Diffuse more"},
        {7, "Dilate"},
        {8, "Edge detect (Prewitt)"},
        {9, "Edge detect (Sobel)"},
        {10, "Edge enhance"},
        {11, "Emboss"},
        {12, "Emboss more"},
        {13, "Engrave"},
        {14, "Engrave more"},
        {15, "Equalize intensity"},
        {16, "Erode"},
        {17, "Fire"},
        {18, "Grayscale"},
        {19, "Mirror rounded"},
        {20, "Negative"},
        {21, "Pixelize"},
        {22, "Red eyes correction"},
        {23, "Relief"},
        {24, "Scan line"},
        {25, "Sepia"},
        {26, "Sharpen"},
        {27, "Sharpen more"},
        {28, "Smooth"},
        {29, "Stretch contrast"}
    }

    Private ReadOnly _configurableEffects As New Dictionary(Of Integer, String) From {
        {0, "Colorize"},
        {1, "Flood fill"},
        {2, "Gaussian blur"},
        {3, "Halo"},
        {4, "Max"},
        {5, "Median"},
        {6, "Min"},
        {7, "Remove background chromakey"},
        {8, "Soften"},
        {9, "Substract background"},
        {10, "Swirl"},
        {11, "Twirl"},
        {12, "Waves (horizontal)"},
        {13, "Waves (vertical)"}
    }

    Private ReadOnly _convolutionMatrixFilters As New Dictionary(Of Integer, String) From {
        {0, "Sharpen"},
        {1, "Blur"},
        {2, "Edge Enhance"},
        {3, "Edge Detect"},
        {4, "Emboss"}
    }

    Private ReadOnly _gdPictureImaging As New GdPictureImaging
    Private _currentImage As Integer
    Private _currentAdjustmentPreview As Integer
    Private _currentRotationPreview As Integer
    Private _currentColorChannelsPreview As Integer
    Private _currentEffectsPreview As Integer

    Private Sub UpdateMainUi()
        Me.Text = "GdPicture.NET " & GetType(GdPictureImaging).Assembly.GetName().Version.ToString() & " - Image Processing Demo"
        If GdViewer1.PageCount = 0 Then
            btnClose.Enabled = False
            btnPrint.Enabled = False
            btnSave.Enabled = False
            btnCopyToClipboard.Enabled = False
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
            cbZoom.SelectedIndex = -1
            tbCurrentPage.Text = "0"
            lblPageCount.Text = "/ 0"
            rotationPeviewViewer.Visible = False
            adjustPeviewViewer.Enabled = False
            pTransform.Enabled = False
            pAdjustment.Enabled = False
            pImageProperties.Enabled = False
            pColorOperations.Enabled = False
            Me.lblImageInfo.Text = "Ready"
            cbPixelConversion.SelectedIndex = -1
            cbResampling.SelectedIndex = 6
            pEffects.Enabled = False
        Else
            btnClose.Enabled = True
            btnPrint.Enabled = True
            btnSave.Enabled = True
            btnCopyToClipboard.Enabled = True
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
            UpdateaNavigationToolbar()
            pTransform.Enabled = True
            pAdjustment.Enabled = True
            pImageProperties.Enabled = True
            pColorOperations.Enabled = True
            pEffects.Enabled = True
        End If
        ResetAdjustmentValues()
        PopulateImageProperties()
        ResetSizeValues()
        ResetRotationValues()
        ResetColorOperationsValues()
        ResetEffectsValues()
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

        Me.lblImageInfo.Text = "Horizontal resolution: " + Trim(Str(Math.Round(GdViewer1.HorizontalResolution, 2))) + " DPI  -  " +
                               "Vertical resolution: " + Trim(Str(Math.Round(GdViewer1.VerticalResolution, 2))) + " DPI"

        lblImageSize.Text = Trim(CStr(_gdPictureImaging.GetWidth(_currentImage))) + " × " + Trim(CStr(_gdPictureImaging.GetHeight(_currentImage)))
    End Sub

    Private Sub CloseDocument()
        If _currentImage <> 0 Then
            GdViewer1.CloseDocument()
            ThumbnailEx1.ClearAllItems()
            _gdPictureImaging.ReleaseGdPictureImage(_currentImage)
            _currentImage = 0
        End If
        If _currentAdjustmentPreview <> 0 Then
            rotationPeviewViewer.Image = Nothing
            _gdPictureImaging.ReleaseGdPictureImage(_currentAdjustmentPreview)
            _currentAdjustmentPreview = 0
        End If
        If _currentRotationPreview <> 0 Then
            adjustPeviewViewer.Image = Nothing
            _gdPictureImaging.ReleaseGdPictureImage(_currentRotationPreview)
            _currentRotationPreview = 0
        End If
        If _currentColorChannelsPreview <> 0 Then
            colorChannelPreviewViewer.Image = Nothing
            _gdPictureImaging.ReleaseGdPictureImage(_currentColorChannelsPreview)
            _currentColorChannelsPreview = 0
        End If
        If _currentEffectsPreview <> 0 Then
            GdViewer2.CloseDocument()
            _gdPictureImaging.ReleaseGdPictureImage(_currentEffectsPreview)
            _currentEffectsPreview = 0
        End If

        UpdateMainUi()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
        CloseDocument()

        GdViewer1.ZoomMode = ViewerZoomMode.ZoomMode100
        GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter

        _currentImage = _gdPictureImaging.CreateGdPictureImageFromFile("")
        Dim status As GdPictureStatus = _gdPictureImaging.GetStat()
        If status <> GdPictureStatus.OK Then
            MessageBox.Show(Me, "Cannot open file : " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If _currentImage <> 0 Then
            GdViewer1.DisplayFromGdPictureImage(_currentImage)
            GdViewer1.Focus()
            ThumbnailEx1.LoadFromGdViewer(GdViewer1)
        End If
        UpdateMainUi()
    End Sub

    Private Sub GdViewer1_PageChanged() Handles GdViewer1.PageChanged
        UpdateaNavigationToolbar()
        Select Case tcLeftPanel.SelectedTab.Name
            Case tpAdjustment.Name
                ResetAdjustmentValues()
            Case tpColorOperations.Name
                ResetColorOperationsValues()
            Case tpEffects.Name
                ResetEffectsValues()
            Case tpTransform.Name
                ResetRotationValues()
                ResetSizeValues()
        End Select
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
        UpdateaNavigationToolbar()
    End Sub

    Private Sub cbZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbZoom.SelectedIndexChanged
        ChangeZoomValue()
    End Sub

    Private Sub GdViewer1_AfterZoomChange() Handles GdViewer1.AfterZoomChange
        UpdateaNavigationToolbar()
        If GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming Then
            GdViewer1.MouseMode = ViewerMouseMode.MouseModePan
        End If
    End Sub

    Private Sub btnZoomOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZoomOut.Click
        GdViewer1.ZoomOUT()
    End Sub

    Private Sub btnZoomIn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnZoomIn.Click
        GdViewer1.ZoomIN()
    End Sub

    Private Sub cbZoom_TextUpdate(ByVal sender As Object, ByVal e As EventArgs) Handles cbZoom.Validating
        ChangeZoomValue()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAbout.Click
        Using frmAbout As New frmAbout()
            frmAbout.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
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

    Private Sub cbZoom_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbZoom.Validating
        ChangeZoomValue()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        CloseDocument()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSettings.Click
        Using frmSettings As New frmSettings(GdViewer1)
            frmSettings.ShowDialog(Me)
        End Using
        ThumbnailEx1.PdfIncreaseTextContrast = GdViewer1.PdfIncreaseTextContrast
        UpdateaNavigationToolbar()
    End Sub

    Private Sub btnFitWidth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFitWidth.Click
        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer
    End Sub

    Private Sub btnFitPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFitPage.Click
        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
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

    Private Sub btnSnapInImageProperties_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSnapInImageProperties.Click
        SelectSnapIn(1, "Image properties")
    End Sub

    Private Sub btnSnapInAdjustment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSnapInAdjustment.Click
        CreateAdjustmentPreviewImage()
        DisplayAdjustmentPreviewImage()
        SelectSnapIn(2, "Adjustment")
    End Sub

    Private Sub btnSnapInTransform_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSnapInTransform.Click
        CreateRotationPreviewImage()
        DisplayRotationPreviewImage()
        SelectSnapIn(3, "Transform")
    End Sub

    Private Sub btnSnapInColorOperations_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSnapInColorOperations.Click
        CreateColorChannelsPreviewImage()
        DisplayColorChannelsPreviewImage()
        SelectSnapIn(4, "Color operations")
    End Sub

    Private Sub btnSnapInEffects_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSnapInEffects.Click
        CreateEffectsPreviewImage()
        DisplayEffectsPreviewImage()
        SelectSnapIn(5, "Effects")
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DefaultToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeDefault
        DefaultToolStripMenuItem.Checked = True
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub AreaSelectionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AreaSelectionToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = True
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub PanToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PanToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModePan
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = True
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub AreaZoomingToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AreaZoomingToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = True
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub MagnifierToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MagnifierToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeMagnifier
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = True
        GdViewer1.Focus()
    End Sub

    Private Sub tbBrightness_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbBrightness.ValueChanged
        lblBrightness.Text = tbBrightness.Value.ToString()
        ChangeAdjustementValues()
    End Sub

    Private Sub tbContrast_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbContrast.ValueChanged
        lblContrast.Text = tbContrast.Value.ToString()
        ChangeAdjustementValues()
    End Sub

    Private Sub tbSaturation_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbSaturation.ValueChanged
        lblSaturation.Text = tbSaturation.Value.ToString()
        ChangeAdjustementValues()
    End Sub

    Private Sub tbGamma_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbGamma.ValueChanged
        lblGamma.Text = tbGamma.Value.ToString()
        ChangeAdjustementValues()
    End Sub

    Private Sub tbRed_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbRed.ValueChanged
        lblRed.Text = tbRed.Value.ToString()
        ChangeAdjustementValues()
    End Sub

    Private Sub tbGreen_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbGreen.ValueChanged
        lblGreen.Text = tbGreen.Value.ToString()
        ChangeAdjustementValues()
    End Sub

    Private Sub tbBlue_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbBlue.ValueChanged
        lblBlue.Text = tbBlue.Value.ToString()
        ChangeAdjustementValues()
    End Sub

    Private Sub ResetAdjustmentValues()
        tbBrightness.Value = 0
        tbContrast.Value = 0
        tbSaturation.Value = 0
        tbGamma.Value = 0
        tbRed.Value = 0
        tbGreen.Value = 0
        tbBlue.Value = 0
        ChangeAdjustementValues()
    End Sub

    Private Sub ChangeAdjustementValues()
        CreateAdjustmentPreviewImage()
        If _currentAdjustmentPreview <> 0 Then
            If _gdPictureImaging.SetBCSG(_currentAdjustmentPreview, tbBrightness.Value, tbContrast.Value, tbSaturation.Value, tbGamma.Value) = GdPictureStatus.OK Then
                _gdPictureImaging.AdjustRGB(_currentAdjustmentPreview, tbRed.Value, tbGreen.Value, tbBlue.Value)
            End If
            DisplayAdjustmentPreviewImage()
        End If
    End Sub

    Private Sub CreateAdjustmentPreviewImage()
        If _currentImage = 0 Then
            Return
        End If
        If _currentAdjustmentPreview <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_currentAdjustmentPreview)
            adjustPeviewViewer.Image = Nothing
            _currentAdjustmentPreview = 0
        End If
        _currentAdjustmentPreview = _gdPictureImaging.CreateThumbnailHQ(_currentImage, adjustPeviewViewer.Width, adjustPeviewViewer.Height, Color.Transparent)
    End Sub

    Private Sub DisplayAdjustmentPreviewImage()
        If _currentAdjustmentPreview <> 0 Then
            adjustPeviewViewer.Image = _gdPictureImaging.GetBitmapFromGdPictureImage(_currentAdjustmentPreview)
            adjustPeviewViewer.Visible = True
        Else
            adjustPeviewViewer.Visible = False
        End If
    End Sub

    Private Sub pAdjustPreview_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles pAdjustPreview.Resize
        ChangeAdjustementValues()
    End Sub

    Private Sub btnApplyAdjustment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplyAdjustment.Click
        If _currentImage <> 0 Then
            If _gdPictureImaging.SetBCSG(_currentImage, tbBrightness.Value, tbContrast.Value, tbSaturation.Value, tbGamma.Value) = GdPictureStatus.OK Then
                If _gdPictureImaging.AdjustRGB(_currentImage, tbRed.Value, tbGreen.Value, tbBlue.Value) = GdPictureStatus.OK Then
                    GdViewer1.Redraw()
                    CreateAdjustmentPreviewImage()
                    ResetAdjustmentValues()
                End If
            End If
        End If
    End Sub

    Private Sub btnResetAdjustment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetAdjustment.Click
        ResetAdjustmentValues()
    End Sub

    Private Sub btnImportFromClipboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportFromClipboard.Click
        CloseDocument()
        _currentImage = _gdPictureImaging.CreateGdPictureImageFromClipboard()
        If _currentImage = 0 Then
            MessageBox.Show("There is no bitmap in the clipboard")
        Else
            GdViewer1.DisplayFromGdPictureImage(_currentImage)
        End If
        UpdateMainUi()
    End Sub

    Private Sub btnCopyToClipboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCopyToClipboard.Click
        _gdPictureImaging.CopyToClipboard(_currentImage)
    End Sub

    Private Sub PopulateImageProperties()
        tvImageProperties.Nodes.Clear()
        If _currentImage = 0 Then
            Return
        End If

        Dim tnGlobals As TreeNode = New TreeNode("Globals properties")
        tnGlobals.Nodes.Add("Bit depth: " + _gdPictureImaging.GetBitDepth(_currentImage).ToString())
        tnGlobals.Nodes.Add("Height: " + _gdPictureImaging.GetHeight(_currentImage).ToString() + " px")
        tnGlobals.Nodes.Add("Width: " + _gdPictureImaging.GetWidth(_currentImage).ToString() + " px")
        tnGlobals.Nodes.Add("Height: " + _gdPictureImaging.GetHeightInches(_currentImage).ToString() + " inches")
        tnGlobals.Nodes.Add("Width: " + _gdPictureImaging.GetWidthInches(_currentImage).ToString() + " inches")
        tnGlobals.Nodes.Add("Color space: " + _gdPictureImaging.GetImageColorSpace(_currentImage).ToString().Replace("ImageColorSpace", ""))
        tnGlobals.Nodes.Add("Image format: " + _gdPictureImaging.GetImageFormat(_currentImage).ToString().Replace("DocumentFormat", ""))
        tnGlobals.Nodes.Add("Pixel format: " + _gdPictureImaging.GetPixelFormat(_currentImage).ToString().Replace("Format", ""))
        tnGlobals.Nodes.Add("Tiff compression: " + _gdPictureImaging.GetTiffCompression(_currentImage).ToString().Replace("TiffCompression", ""))
        tnGlobals.Nodes.Add("Horizontal resolution: " + _gdPictureImaging.GetHorizontalResolution(_currentImage).ToString() + " DPI")
        tnGlobals.Nodes.Add("Vertical resolution: " + _gdPictureImaging.GetVerticalResolution(_currentImage).ToString() + " DPI")
        tnGlobals.Nodes.Add("Pixel format has alpha component: " + _gdPictureImaging.IsPixelFormatHasAlpha(_currentImage).ToString())
        tnGlobals.Nodes.Add("Pixel format is indexed: " + _gdPictureImaging.IsPixelFormatIndexed(_currentImage).ToString())
        tvImageProperties.Nodes.Add(tnGlobals)
        tnGlobals.Expand()

        Dim tnExifs As TreeNode = New TreeNode("EXIF tags")
        For i = 1 To _gdPictureImaging.TagCount(_currentImage)
            Dim tnExifTag As TreeNode = New TreeNode(_gdPictureImaging.TagGetName(_currentImage, i) & ": " & _gdPictureImaging.TagGetValueString(_currentImage, i))
            tnExifs.Nodes.Add(tnExifTag)
        Next i
        tvImageProperties.Nodes.Add(tnExifs)

        Dim tnIptc As TreeNode = New TreeNode("IPTC tags")
        For i = 1 To _gdPictureImaging.IPTCCount(_currentImage)
            Dim tnIptcTag As TreeNode = New TreeNode(_gdPictureImaging.IPTCGetID(_currentImage, i).ToString & ": " & _gdPictureImaging.IPTCGetValueString(_currentImage, i))
            tnIptc.Nodes.Add(tnIptcTag)
        Next i
        tvImageProperties.Nodes.Add(tnIptc)
    End Sub

    Private Sub GdViewer1_MouseMove(ByVal sender As Object, ByVal e As Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseMove
        lblMousePosition.Text = GdViewer1.GetMouseLeftInDocument() & ", " & GdViewer1.GetMouseTopInDocument()
    End Sub

    Private Sub ResetSizeValues()
        nWidth.Value = 1
        nHeight.Value = 1
        nDocumentWidth.Value = 1
        nDocumentHeight.Value = 1
        nHorizontalResolution.Value = 1
        nVerticalResolution.Value = 1
        nScalePercent.Value = 100
        chkKeepAspectRatio.Checked = True
        cbResampling.SelectedIndex = 6
        rbScalePercent.Checked = True
        If _currentImage <> 0 Then
            nWidth.Value = _gdPictureImaging.GetWidth(_currentImage)
            nHeight.Value = _gdPictureImaging.GetHeight(_currentImage)
            nDocumentWidth.Value = CType(_gdPictureImaging.GetWidthInches(_currentImage), Decimal)
            nDocumentHeight.Value = CType(_gdPictureImaging.GetHeightInches(_currentImage), Decimal)
            nHorizontalResolution.Value = CType(_gdPictureImaging.GetHorizontalResolution(_currentImage), Decimal)
            nVerticalResolution.Value = CType(_gdPictureImaging.GetVerticalResolution(_currentImage), Decimal)
        End If
    End Sub

    Private Sub btnResetSize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetSize.Click
        ResetSizeValues()
    End Sub

    Private Sub rbScalePercent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbScalePercent.CheckedChanged
        nScalePercent.Enabled = rbScalePercent.Checked
        chkKeepAspectRatio.Enabled = Not rbScalePercent.Checked
        gpPixelDimensions.Enabled = Not rbScalePercent.Checked
        gpDocumentSize.Enabled = Not rbScalePercent.Checked
    End Sub

    Private Sub nScalePercent_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nScalePercent.ValueChanged
        UpdateScalePercentValue()
    End Sub

    Private Sub nScalePercent_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nScalePercent.KeyUp
        UpdateScalePercentValue()
    End Sub

    Private Sub UpdateScalePercentValue()
        If _currentImage <> 0 Then
            Dim originalWidth As Integer = _gdPictureImaging.GetWidth(_currentImage)
            Dim originalHeight As Integer = _gdPictureImaging.GetHeight(_currentImage)
            nWidth.Value = Math.Max(nWidth.Minimum, originalWidth * (nScalePercent.Value / 100))
            nHeight.Value = Math.Max(nHeight.Minimum, originalHeight * (nScalePercent.Value / 100))
            nDocumentWidth.Value = Math.Max(nDocumentWidth.Minimum, nWidth.Value / nHorizontalResolution.Value)
            nDocumentHeight.Value = Math.Max(nDocumentHeight.Minimum, nHeight.Value / nVerticalResolution.Value)
        End If
    End Sub

    Private Sub nWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nWidth.ValueChanged
        UpdateWidthValue()
    End Sub

    Private Sub nWidth_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nWidth.KeyUp
        UpdateWidthValue()
    End Sub

    Private Sub UpdateWidthValue()
        If _currentImage <> 0 And chkKeepAspectRatio.Checked And rbResize.Checked Then
            Dim originalWidth As Integer = _gdPictureImaging.GetWidth(_currentImage)
            Dim originalHeight As Integer = _gdPictureImaging.GetHeight(_currentImage)
            nHeight.Value = Math.Max(nHeight.Minimum, originalHeight * (nWidth.Value / originalWidth))
            nDocumentWidth.Value = Math.Max(nDocumentWidth.Minimum, nWidth.Value / nHorizontalResolution.Value)
        End If
    End Sub

    Private Sub nHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nHeight.ValueChanged
        UpdateHeightValue()
    End Sub

    Private Sub nHeight_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nHeight.KeyUp
        UpdateHeightValue()
    End Sub

    Private Sub UpdateHeightValue()
        If _currentImage <> 0 And chkKeepAspectRatio.Checked And rbResize.Checked Then
            Dim originalWidth As Integer = _gdPictureImaging.GetWidth(_currentImage)
            Dim originalHeight As Integer = _gdPictureImaging.GetHeight(_currentImage)
            nWidth.Value = Math.Max(nWidth.Minimum, originalWidth * (nHeight.Value / originalHeight))
            nDocumentHeight.Value = Math.Max(nDocumentHeight.Minimum, nHeight.Value / nVerticalResolution.Value)
        End If
    End Sub

    Private Sub nHorizontalResolution_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nHorizontalResolution.KeyUp
        UpdateHorizontalValue()
    End Sub

    Private Sub nHorizontalResolution_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nHorizontalResolution.ValueChanged
        UpdateHorizontalValue()
    End Sub

    Private Sub UpdateHorizontalValue()
        If rbResize.Checked Then
            nDocumentWidth.Value = Math.Max(nDocumentWidth.Minimum, nWidth.Value / nHorizontalResolution.Value)
        End If
    End Sub

    Private Sub nVerticalResolution_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nVerticalResolution.KeyUp
        UpdateVerticalValue()
    End Sub

    Private Sub nVerticalResolution_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nVerticalResolution.ValueChanged
        UpdateVerticalValue()
    End Sub

    Private Sub UpdateVerticalValue()
        If rbResize.Checked Then
            nDocumentHeight.Value = Math.Max(nDocumentHeight.Minimum, nHeight.Value / nVerticalResolution.Value)
        End If
    End Sub

    Private Sub nDocumentWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nDocumentWidth.ValueChanged
        UpdateDocumentWidthValue()
    End Sub

    Private Sub nDocumentWidth_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nDocumentWidth.KeyUp
        UpdateDocumentWidthValue()
    End Sub

    Private Sub UpdateDocumentWidthValue()
        If rbResize.Checked Then
            nWidth.Value = Math.Max(nWidth.Minimum, nHorizontalResolution.Value * nDocumentWidth.Value)
        End If
    End Sub

    Private Sub nDocumentHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nDocumentHeight.ValueChanged
        UpdateDocumentHeightValue()
    End Sub

    Private Sub nDocumentHeight_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nDocumentHeight.KeyUp
        UpdateDocumentHeightValue()
    End Sub

    Private Sub UpdateDocumentHeightValue()
        If rbResize.Checked Then
            nHeight.Value = Math.Max(nHeight.Minimum, nVerticalResolution.Value * nDocumentHeight.Value)
        End If
    End Sub

    Private Sub btnApplySize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplySize.Click
        Dim status As GdPictureStatus
        If rbScalePercent.Checked Then
            status = _gdPictureImaging.Scale(_currentImage, nScalePercent.Value, _interPolationModes.ElementAt(cbResampling.SelectedIndex).Key)
        Else
            Dim currentWidth As Integer = _gdPictureImaging.GetWidth(_currentImage)
            Dim currentHeight As Integer = _gdPictureImaging.GetHeight(_currentImage)
            status = GdPictureStatus.OK
            If currentWidth <> CInt(nWidth.Value) Or currentHeight <> CInt(nHeight.Value) Then
                status = _gdPictureImaging.Resize(_currentImage, CInt(nWidth.Value), CInt(nHeight.Value), _interPolationModes.ElementAt(cbResampling.SelectedIndex).Key)
            End If
            If status = GdPictureStatus.OK Then
                _gdPictureImaging.SetHorizontalResolution(_currentImage, nHorizontalResolution.Value)
                _gdPictureImaging.SetVerticalResolution(_currentImage, nVerticalResolution.Value)
            End If
        End If
        If status = GdPictureStatus.OK Then
            UpdateMainUi()
            GdViewer1.Redraw()
        Else
            MessageBox.Show(Me, "Error resizing image: " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnApplyRotation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplyRotation.Click
        Dim status As GdPictureStatus
        status = ApplyRotationValues(_currentImage)
        If status <> GdPictureStatus.OK Then
            MessageBox.Show(Me, "Error rotating image: " + _gdPictureImaging.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            GdViewer1.Redraw()
            UpdateMainUi()
            ResetRotationValues()
            CreateRotationPreviewImage()
            DisplayRotationPreviewImage()
        End If
    End Sub

    Private Sub nRotationAngle_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nRotationAngle.ValueChanged
        ChangeCustomRotationValues()
    End Sub

    Private Sub nRotationAngle_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nRotationAngle.KeyUp
        ChangeCustomRotationValues()
    End Sub

    Private Sub CreateRotationPreviewImage()
        If _currentImage = 0 Then
            Return
        End If
        If _currentRotationPreview <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_currentRotationPreview)
            rotationPeviewViewer.Image = Nothing
        End If

        Dim currentWidth As Integer = _gdPictureImaging.GetWidth(_currentImage)
        Dim currentHeight As Integer = _gdPictureImaging.GetHeight(_currentImage)
        If rotationPeviewViewer.Width < rotationPeviewViewer.Height Then
            Dim newHeight As Integer = CInt(currentHeight / (currentWidth / rotationPeviewViewer.Width))
            _currentRotationPreview = _gdPictureImaging.CreateThumbnailHQ(_currentImage, rotationPeviewViewer.Width, newHeight, Color.Transparent)
        Else
            Dim newWidth As Integer = CInt(currentWidth / (currentHeight / rotationPeviewViewer.Height))
            _currentRotationPreview = _gdPictureImaging.CreateThumbnailHQ(_currentImage, newWidth, rotationPeviewViewer.Height, Color.Transparent)
        End If
    End Sub

    Private Sub DisplayRotationPreviewImage()
        If _currentRotationPreview <> 0 Then
            rotationPeviewViewer.Image = _gdPictureImaging.GetBitmapFromGdPictureImage(_currentRotationPreview)
            rotationPeviewViewer.Visible = True
        Else
            rotationPeviewViewer.Visible = False
        End If
    End Sub

    Private Sub ChangeCustomRotationValues()
        Dim status As GdPictureStatus = GdPictureStatus.Aborted
        CreateRotationPreviewImage()
        If _currentRotationPreview <> 0 Then
            status = ApplyRotationValues(_currentRotationPreview)
            If status = GdPictureStatus.OK Then
                If Not chkKeepImageDimensionRotation.Checked Then
                    Dim currentWidth As Integer = _gdPictureImaging.GetWidth(_currentRotationPreview)
                    Dim currentHeight As Integer = _gdPictureImaging.GetHeight(_currentRotationPreview)
                    If rotationPeviewViewer.Width < rotationPeviewViewer.Height Then
                        Dim newHeight As Integer = CInt(currentHeight / (currentWidth / rotationPeviewViewer.Width))
                        _gdPictureImaging.Resize(_currentRotationPreview, rotationPeviewViewer.Width, newHeight, InterpolationMode.HighQualityBicubic)
                    Else
                        Dim newWidth As Integer = CInt(currentWidth / (currentHeight / rotationPeviewViewer.Height))
                        _gdPictureImaging.Resize(_currentRotationPreview, newWidth, rotationPeviewViewer.Height, InterpolationMode.HighQualityBicubic)
                    End If
                End If
            End If
            DisplayRotationPreviewImage()
        End If
    End Sub

    Private Function ApplyRotationValues(ByVal image As Integer) As GdPictureStatus
        Dim status As GdPictureStatus = GdPictureStatus.Aborted
        If rbRotateCustomAngle.Checked Then
            If chkKeepImageDimensionRotation.Checked Then
                If chkRotateFromCenter.Checked Then
                    status = _gdPictureImaging.RotateAnglePreserveDimensionsCenterBackColor(image, nRotationAngle.Value, pbRotationBackColor.BackColor)
                Else
                    status = _gdPictureImaging.RotateAnglePreserveDimensionsBackColor(image, nRotationAngle.Value, pbRotationBackColor.BackColor)
                End If
            Else
                status = _gdPictureImaging.RotateAngleBackColor(image, nRotationAngle.Value, pbRotationBackColor.BackColor)
            End If
        ElseIf rbRotateLeft.Checked Then
            status = _gdPictureImaging.Rotate(image, RotateFlipType.Rotate270FlipNone)
        ElseIf rbRotateRight.Checked Then
            status = _gdPictureImaging.Rotate(image, RotateFlipType.Rotate90FlipNone)
        ElseIf rbFlipHorizontal.Checked Then
            status = _gdPictureImaging.Rotate(image, RotateFlipType.RotateNoneFlipX)
        ElseIf rbFlipVertical.Checked Then
            status = _gdPictureImaging.Rotate(image, RotateFlipType.RotateNoneFlipY)
        End If
        Return status
    End Function

    Private Sub pRotationPreview_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles pRotationPreview.Resize
        ChangeCustomRotationValues()
    End Sub

    Private Sub ResetRotationValues()
        nRotationAngle.Value = 0
        chkRotateFromCenter.Checked = True
        chkKeepImageDimensionRotation.Checked = True
        pbRotationBackColor.BackColor = Color.Black
        rbRotateCustomAngle.Checked = False
        rbRotateLeft.Checked = False
        rbRotateRight.Checked = False
        rbFlipVertical.Checked = False
        rbFlipHorizontal.Checked = False
        UpdateRotationUi()
        ChangeCustomRotationValues()
    End Sub

    Private Sub chkKeepImageDimensionRotation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkKeepImageDimensionRotation.CheckedChanged
        chkRotateFromCenter.Enabled = chkKeepImageDimensionRotation.Checked
        ChangeCustomRotationValues()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbRotationBackColor.Click
        Using colorDialog As New ColorDialog
            If colorDialog.ShowDialog() = DialogResult.OK Then
                pbRotationBackColor.BackColor = colorDialog.Color
            End If
        End Using
    End Sub

    Private Sub btnApplyPixelConversion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplyPixelConversion.Click
        If _currentImage = 0 Then
            Return
        End If
        Dim status As GdPictureStatus
        Select Case cbPixelConversion.SelectedIndex
            Case 0 ' 1-bit per pixel (Linear)
                status = _gdPictureImaging.ConvertTo1Bpp(_currentImage)
            Case 1 ' 1-bit per pixel (Otsu)
                status = _gdPictureImaging.ConvertTo1BppAT(_currentImage)
            Case 2 ' 1-bit per pixel (Nearest color)
                status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.NearestColor)
            Case 3 ' 1-bit per pixel (Ordered Dither)
                status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.OrderedDither)
            Case 4 ' 1-bit per pixel (Burke)
                status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.Burke)
            Case 5 ' 1-bit per pixel (Stucki)
                status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.Stucki)
            Case 6 ' 1-bit per pixel (Floyd Steinberg)
                status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.FloydSteinberg)
            Case 7 ' 1-bit per pixel (Sauvola)
                status = _gdPictureImaging.ConvertTo1BppSauvola(_currentImage, 0.35)
            Case 8 ' 1-bit per pixel (Bradley)
                status = _gdPictureImaging.ConvertTo1BppBradley(_currentImage, 38)
            Case 9 ' 4-bits per pixel (indexed)
                status = _gdPictureImaging.ConvertTo4Bpp16(_currentImage)
            Case 10 ' 4-bits per pixel (quantized)
                status = _gdPictureImaging.ConvertTo4BppQ(_currentImage)
            Case 11 ' 8-bits per pixel (Grayscale)
                status = _gdPictureImaging.ConvertTo8BppGrayScale(_currentImage)
            Case 12 ' 8-bits per pixel (Color)
                status = _gdPictureImaging.ConvertTo8BppQ(_currentImage)
            Case 13 ' 16-bits per pixel (RGB555)
                status = _gdPictureImaging.ConvertTo16BppRGB555(_currentImage)
            Case 14 ' 16-bits per pixel (RGB565)
                status = _gdPictureImaging.ConvertTo16BppRGB565(_currentImage)
            Case 15 ' 24-bits per pixel (RGB)
                status = _gdPictureImaging.ConvertTo24BppRGB(_currentImage)
            Case 16 ' 32-bits per pixel (RGB)
                status = _gdPictureImaging.ConvertTo32BppRGB(_currentImage)
            Case 17 ' 32-bits per pixel (ARGB)
                status = _gdPictureImaging.ConvertTo32BppARGB(_currentImage)
            Case 18 ' 32-bits per pixel (PARGB)
                status = _gdPictureImaging.ConvertTo32BppPARGB(_currentImage)
            Case 19 ' 48-bits per pixel (RGB)
                status = _gdPictureImaging.ConvertTo64BppARGB(_currentImage)
            Case 20 ' 64-bits per pixel (ARGB)
                status = _gdPictureImaging.ConvertTo64BppARGB(_currentImage)
            Case 21 ' 64-bits per pixel (PARGB)
                status = _gdPictureImaging.ConvertTo64BppPARGB(_currentImage)
        End Select
        If status <> GdPictureStatus.OK Then
            MessageBox.Show(Me, "Error: " + _gdPictureImaging.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            GdViewer1.Redraw()
            UpdateMainUi()
        End If
    End Sub

    Private Sub tbScaleRed_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbScaleRed.ValueChanged
        lblScaleRed.Text = ((tbScaleRed.Value - 100) + (tbScaleRed.Value - 100) Mod 100).ToString() + "%"
        ChangeColorChannelsValues()
    End Sub

    Private Sub tbScaleGreen_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbScaleGreen.ValueChanged
        lblScaleGreen.Text = ((tbScaleGreen.Value - 100) + (tbScaleGreen.Value - 100) Mod 100).ToString() + "%"
        ChangeColorChannelsValues()
    End Sub

    Private Sub tbScaleBlue_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbScaleBlue.ValueChanged
        lblScaleBlue.Text = ((tbScaleBlue.Value - 100) + (tbScaleBlue.Value - 100) Mod 100).ToString() + "%"
        ChangeColorChannelsValues()
    End Sub

    Private Sub pColorChannelsViewer_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles pColorChannelsViewer.Resize
        ChangeColorChannelsValues()
    End Sub

    Private Sub rbSwapColor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbSwapColor.CheckedChanged
        UpdateColorChannelsManipulationUi()
        ChangeColorChannelsValues()
    End Sub

    Private Sub rbKeepComponent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbKeepComponent.CheckedChanged
        UpdateColorChannelsManipulationUi()
        ChangeColorChannelsValues()
    End Sub

    Private Sub rbScaleComponent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbScaleComponent.CheckedChanged
        UpdateColorChannelsManipulationUi()
        ChangeColorChannelsValues()
    End Sub

    Private Sub rbRemoveComponent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRemoveComponent.CheckedChanged
        UpdateColorChannelsManipulationUi()
        ChangeColorChannelsValues()
    End Sub

    Private Sub UpdateColorChannelsManipulationUi()
        pSwapColors.Enabled = rbSwapColor.Checked
        pKeepComponent.Enabled = rbKeepComponent.Checked
        pScaleColors.Enabled = rbScaleComponent.Checked
        pRemoveComponent.Enabled = rbRemoveComponent.Checked
    End Sub

    Private Sub CreateColorChannelsPreviewImage()
        If _currentImage = 0 Then
            Return
        End If
        If _currentColorChannelsPreview <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_currentColorChannelsPreview)
            colorChannelPreviewViewer.Image = Nothing
        End If
        _currentColorChannelsPreview = _gdPictureImaging.CreateThumbnailHQ(_currentImage, colorChannelPreviewViewer.Width, colorChannelPreviewViewer.Height, Color.Transparent)
    End Sub

    Private Sub DisplayColorChannelsPreviewImage()
        If _currentColorChannelsPreview <> 0 Then
            colorChannelPreviewViewer.Image = _gdPictureImaging.GetBitmapFromGdPictureImage(_currentColorChannelsPreview)
            colorChannelPreviewViewer.Visible = True
        Else
            colorChannelPreviewViewer.Visible = False
        End If
    End Sub

    Private Sub ChangeColorChannelsValues()
        CreateColorChannelsPreviewImage()
        If _currentColorChannelsPreview <> 0 Then
            ApplyColorChannelsValues(_currentColorChannelsPreview)
            DisplayColorChannelsPreviewImage()
        End If
    End Sub

    Private Function ApplyColorChannelsValues(ByVal image As Integer) As GdPictureStatus
        Dim status As GdPictureStatus = GdPictureStatus.Aborted
        If rbSwapColor.Checked Then
            Select Case cbSwapColor.SelectedIndex
                Case 0
                    status = _gdPictureImaging.SwapColorsRGBtoBGR(image)
                Case 1
                    status = _gdPictureImaging.SwapColorsRGBtoBRG(image)
                Case 2
                    status = _gdPictureImaging.SwapColorsRGBtoGBR(image)
                Case 3
                    status = _gdPictureImaging.SwapColorsRGBtoGRB(image)
                Case 4
                    status = _gdPictureImaging.SwapColorsRGBtoRBG(image)
            End Select
        ElseIf rbKeepComponent.Checked Then
            If rbKeepBlue.Checked Then
                status = _gdPictureImaging.KeepBlueComponent(image)
            ElseIf rbKeepGreen.Checked Then
                status = _gdPictureImaging.KeepGreenComponent(image)
            ElseIf rbKeepRed.Checked Then
                status = _gdPictureImaging.KeepRedComponent(image)
            End If
        ElseIf rbScaleComponent.Checked Then
            status = _gdPictureImaging.ScaleBlueComponent(image, CSng(tbScaleBlue.Value / 100))
            If status = GdPictureStatus.OK Then
                status = _gdPictureImaging.ScaleGreenComponent(image, CSng(tbScaleGreen.Value / 100))
                If status = GdPictureStatus.OK Then
                    status = _gdPictureImaging.ScaleRedComponent(image, CSng(tbScaleRed.Value / 100))
                End If
            End If
        ElseIf rbRemoveComponent.Checked Then
            If rbRemoveBlue.Checked Then
                status = _gdPictureImaging.RemoveBlueComponent(image)
            ElseIf rbRemoveGreen.Checked Then
                status = _gdPictureImaging.RemoveGreenComponent(image)
            ElseIf rbRemoveRed.Checked Then
                status = _gdPictureImaging.RemoveRedComponent(image)
            End If
        End If
        Return status
    End Function

    Private Sub btnResetColorChannels_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetColorChannels.Click
        ResetColorOperationsValues()
        ChangeColorChannelsValues()
    End Sub

    Private Sub btnApplyColorChannels_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplyColorChannels.Click
        Dim status As GdPictureStatus
        status = ApplyColorChannelsValues(_currentImage)
        If status = GdPictureStatus.OK Then
            GdViewer1.Redraw()
            UpdateMainUi()
            CreateColorChannelsPreviewImage()
            DisplayColorChannelsPreviewImage()
        End If
    End Sub

    Private Sub rbKeepRed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbKeepRed.CheckedChanged
        ChangeColorChannelsValues()
    End Sub

    Private Sub rbKeepGreen_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbKeepGreen.CheckedChanged
        ChangeColorChannelsValues()
    End Sub

    Private Sub rbKeepBlue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbKeepBlue.CheckedChanged
        ChangeColorChannelsValues()
    End Sub

    Private Sub rbRemoveRed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRemoveRed.CheckedChanged
        ChangeColorChannelsValues()
    End Sub

    Private Sub rbRemoveGreen_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRemoveGreen.CheckedChanged
        ChangeColorChannelsValues()
    End Sub

    Private Sub rbRemoveBlue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRemoveBlue.CheckedChanged
        ChangeColorChannelsValues()
    End Sub

    Private Sub cbSwapColor_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSwapColor.SelectedIndexChanged
        ChangeColorChannelsValues()
    End Sub

    Private Sub ResetColorOperationsValues()
        rbSwapColor.Checked = True
        cbSwapColor.SelectedIndex = -1
        tbScaleRed.Value = 100
        tbScaleGreen.Value = 100
        tbScaleBlue.Value = 100
        rbRemoveBlue.Checked = False
        rbRemoveGreen.Checked = False
        rbRemoveBlue.Checked = False
        rbKeepBlue.Checked = False
        rbKeepGreen.Checked = False
        rbKeepRed.Checked = False
        rbSwapColor.Checked = True
        ChangeColorChannelsValues()
    End Sub

    Private Sub ResetEffectsValues()
        cbDirectEffects.SelectedIndex = -1
        cbConfigurableEffects.SelectedIndex = -1
        cbConvolutionMatrix.SelectedIndex = -1
        rbDirectEffects.Checked = True
        nHueEffect.Value = 50
        nSaturationEffect.Value = 50
        nLuminosityEffect.Value = 25
        nKernelSizeEffect.Value = 1
        If _currentImage = 0 Then
            nLeftEffect.Value = 1
        Else
            nLeftEffect.Value = CDec(Math.Round(_gdPictureImaging.GetWidth(_currentImage) / 2))
        End If
        If _currentImage = 0 Then
            nTopEffect.Value = 1
        Else
            nTopEffect.Value = CDec(Math.Round(_gdPictureImaging.GetHeight(_currentImage) / 2))
        End If
        nRadiusEffect.Value = 15
        nWidthEffect.Value = 20
        nHeightEffect.Value = 15
        cbComponentEffect.SelectedIndex = 0
        nVariationEffect.Value = 240
        nMinKeyValueEffect.Value = 50
        nSoftenValueEffect.Value = 25
        nRollingBallSizeEffect.Value = 50
        chkLightBackgroundEffect.Checked = True
        nFactorEffect.Value = 30
        nFloodFillEffectXStart.Value = 1
        nFloodFillEffectYStart.Value = 1
        pbFloodFillEffectColor.BackColor = Color.Black
    End Sub

    Private Sub CreateEffectsPreviewImage()
        If _currentImage = 0 Then
            Return
        End If
        If _currentEffectsPreview <> 0 Then
            GdViewer2.CloseDocument()
            _gdPictureImaging.ReleaseGdPictureImage(_currentEffectsPreview)
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
        End If
        _currentEffectsPreview = _gdPictureImaging.CreateClonedGdPictureImage(_currentImage)
    End Sub

    Private Sub DisplayEffectsPreviewImage()
        If _currentEffectsPreview <> 0 Then
            GdViewer2.DisplayFromGdPictureImage(_currentEffectsPreview)
        Else
            GdViewer2.CloseDocument()
        End If
    End Sub

    Private Sub ChangeEffectsValues()
        CreateEffectsPreviewImage()
        If _currentEffectsPreview <> 0 Then
            ApplyEffectValues(_currentEffectsPreview)
            DisplayEffectsPreviewImage()
        End If
    End Sub

    Private Sub pEffectsPreview_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles pEffectsPreview.Resize
        ChangeEffectsValues()
    End Sub

    Private Sub btnResetEffects_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetEffects.Click
        ResetEffectsValues()
    End Sub

    Private Sub btnApplyEffects_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApplyEffects.Click
        Dim status As GdPictureStatus
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
        status = ApplyEffectValues(_currentImage)
        If status = GdPictureStatus.OK Then
            GdViewer1.Redraw()
            UpdateMainUi()
            _gdPictureImaging.ResetROI()
            GdViewer1.ClearRect()
            CreateEffectsPreviewImage()
            DisplayEffectsPreviewImage()
        End If
    End Sub

    Private Function ApplyEffectValues(ByVal image As Integer) As GdPictureStatus
        Dim status As GdPictureStatus = GdPictureStatus.Aborted
        If rbDirectEffects.Checked Then
            Select Case cbDirectEffects.SelectedIndex
                Case 0 ' Add noise
                    status = _gdPictureImaging.FxAddNoise(image)
                Case 1 ' Aqua
                    status = _gdPictureImaging.FxAqua(image)
                Case 2 ' Blur
                    status = _gdPictureImaging.FxBlur(image)
                Case 3 ' Connected contour
                    status = _gdPictureImaging.FxConnectedContour(image)
                Case 4 ' Contour
                    status = _gdPictureImaging.FxContour(image)
                Case 5 ' Diffuse
                    status = _gdPictureImaging.FxDiffuse(image)
                Case 6 ' Diffuse more
                    status = _gdPictureImaging.FxDiffuseMore(image)
                Case 7 ' Dilate
                    status = _gdPictureImaging.FxDilate(image)
                Case 8 ' Edge detect (Prewitt)
                    status = _gdPictureImaging.FxPrewittEdgeDetect(image)
                Case 9 ' Edge detect (Sobel)
                    status = _gdPictureImaging.FxSobelEdgeDetect(image)
                Case 10 ' Edge enhance
                    status = _gdPictureImaging.FxEdgeEnhance(image)
                Case 11 ' Emboss
                    status = _gdPictureImaging.FxEmboss(image)
                Case 12 ' Emboss more
                    status = _gdPictureImaging.FxEmbossMore(image)
                Case 13 ' Engrave
                    status = _gdPictureImaging.FxEngrave(image)
                Case 14 ' Engrave more
                    status = _gdPictureImaging.FxEngraveMore(image)
                Case 15 ' Equalize intensity
                    status = _gdPictureImaging.FxEqualizeIntensity(image)
                Case 16 ' Erode
                    status = _gdPictureImaging.FxErode(image)
                Case 17 ' Fire
                    status = _gdPictureImaging.FxFire(image)
                Case 18 ' Grayscale
                    status = _gdPictureImaging.FxGrayscale(image)
                Case 19 ' Mirror rounded
                    status = _gdPictureImaging.FxMirrorRounded(image)
                Case 20 ' Negative
                    status = _gdPictureImaging.FxNegative(image)
                Case 21 ' Pixelize
                    status = _gdPictureImaging.FxPixelize(image)
                Case 22 ' Red eyes correction
                    status = _gdPictureImaging.FxRedEyesCorrection(image)
                Case 23 ' Relief
                    status = _gdPictureImaging.FxRelief(image)
                Case 24 ' Scan line
                    status = _gdPictureImaging.FxScanLine(image)
                Case 25 ' Sepia
                    status = _gdPictureImaging.FxSepia(image)
                Case 26 ' Sharpen
                    status = _gdPictureImaging.FxSharpen(image)
                Case 27 ' Sharpen more
                    status = _gdPictureImaging.FxSharpenMore(image)
                Case 28 ' Smooth
                    status = _gdPictureImaging.FxSmooth(image)
                Case 29 ' Stretch contrast
                    status = _gdPictureImaging.FxStretchContrast(image)
            End Select
        ElseIf rbConfigurableEffects.Checked Then
            Select Case cbConfigurableEffects.SelectedIndex
                Case 0 ' Colorize
                    status = _gdPictureImaging.FxColorize(image, nHueEffect.Value, nSaturationEffect.Value, nLuminosityEffect.Value)
                Case 1 ' Flood fill
                    status = _gdPictureImaging.FloodFill(image, CInt(nFloodFillEffectXStart.Value), CInt(nFloodFillEffectYStart.Value), pbFloodFillEffectColor.BackColor)
                Case 2 ' Gaussian blur
                    status = _gdPictureImaging.FxGaussian(image, CInt(nKernelSizeEffect.Value))
                Case 3 ' Halo
                    status = _gdPictureImaging.FxHalo(image, CInt(nLeftEffect.Value), CInt(nTopEffect.Value), CInt(nRadiusEffect.Value))
                Case 4 ' Max
                    status = _gdPictureImaging.FxMax(image, CInt(nKernelSizeEffect.Value))
                Case 5 ' Median
                    status = _gdPictureImaging.FxMedian(image, CInt(nKernelSizeEffect.Value))
                Case 6 ' Min
                    status = _gdPictureImaging.FxMin(image, CInt(nKernelSizeEffect.Value))
                Case 7 ' Remove background chromakey
                    status = _gdPictureImaging.fxRemoveBackgroundChromaKey(image, CType(cbComponentEffect.SelectedIndex, ColorKey), CInt(nVariationEffect.Value), CInt(nMinKeyValueEffect.Value))
                Case 8 ' Soften
                    status = _gdPictureImaging.FxSoften(image, CInt(nSoftenValueEffect.Value))
                Case 9 ' Substract background
                    status = _gdPictureImaging.FxSubtractBackground(image, CInt(nRollingBallSizeEffect.Value), chkLightBackgroundEffect.Checked)
                Case 10 ' Swirl
                    status = _gdPictureImaging.FxSwirl(image, nFactorEffect.Value)
                Case 11 ' Twirl
                    status = _gdPictureImaging.FxTwirl(image, nFactorEffect.Value)
                Case 12 ' Waves (horizontal)
                    status = _gdPictureImaging.FxhWaves(image, CInt(nWidthEffect.Value), CInt(nHeightEffect.Value))
                Case 13 ' Waves (vertical)
                    status = _gdPictureImaging.FxvWaves(image, CInt(nWidthEffect.Value), CInt(nHeightEffect.Value))
            End Select
        ElseIf rbConvolutionMatrix.Checked Then
            Select Case cbConvolutionMatrix.SelectedIndex
                Case 0 ' Sharpen
                    ' Convolution matrix for sharpen filter is :
                    '  0 -1  0
                    ' -1  5 -1
                    '  0 -1  0
                    Dim matrix As Single(,) = {{0, -1, 0}, {-1, 5, -1}, {0, -1, 0}}
                    status = _gdPictureImaging.FxConvolution(image, matrix, True)
                Case 1 ' Blur
                    ' Convolution matrix for blur filter is :
                    '  1  1  1
                    '  1  1  1
                    '  1  1  1
                    Dim matrix As Single(,) = {{1, 1, 1}, {1, 1, 1}, {1, 1, 1}}
                    status = _gdPictureImaging.FxConvolution(image, matrix, True)
                Case 2 ' Edge Enhance
                    ' Convolution matrix for edge enhance filter is :
                    '  0  0  0
                    ' -1  1  0
                    '  0  0  0
                    Dim matrix As Single(,) = {{0, 0, 0}, {-1, 1, 0}, {0, 0, 0}}
                    status = _gdPictureImaging.FxConvolution(image, matrix, True)
                Case 3 ' Edge Detect
                    ' Convolution matrix for edge detect filter is :
                    '  0  1  0
                    '  1 -4  1
                    '  0  1  0
                    Dim matrix As Single(,) = {{0, 1, 0}, {1, -4, 1}, {0, 1, 0}}
                    status = _gdPictureImaging.FxConvolution(image, matrix, True)
                Case 4 ' Emboss
                    ' Convolution matrix for emboss filter is :
                    ' -2 -1  0
                    ' -1  1  1
                    '  0  1  2
                    Dim matrix As Single(,) = {{-2, -1, 0}, {-1, 1, 1}, {0, 1, 2}}
                    status = _gdPictureImaging.FxConvolution(image, matrix, True)
            End Select
        End If
        Return status
    End Function

    Private Sub cbEffects_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDirectEffects.SelectedIndexChanged
        ChangeEffectsValues()
    End Sub

    Private Sub rbDirectEffects_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbDirectEffects.CheckedChanged
        UpdateEffectsUi()
    End Sub

    Private Sub rbConfigurableEffects_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbConfigurableEffects.CheckedChanged
        UpdateEffectsUi()
    End Sub

    Private Sub rbConvolutionMatrix_CheckedChanged(sender As Object, e As EventArgs) Handles rbConvolutionMatrix.CheckedChanged
        UpdateEffectsUi()
    End Sub

    Private Sub cbConvolutionMatrix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbConvolutionMatrix.SelectedIndexChanged
        ChangeEffectsValues()
    End Sub

    Private Sub UpdateEffectsUi()
        pDirectEffects.Enabled = rbDirectEffects.Checked
        cbConvolutionMatrix.Enabled = rbConvolutionMatrix.Checked
        cbDirectEffects.SelectedIndex = -1
        cbConvolutionMatrix.SelectedIndex = -1
        pConfigurableEffects.Enabled = rbConfigurableEffects.Checked
        cbConfigurableEffects.SelectedIndex = -1
        UpdateConfigurableEffectUi()
    End Sub

    Private Sub cbConfigurableEffects_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbConfigurableEffects.SelectedIndexChanged
        UpdateConfigurableEffectUi()
        ChangeEffectsValues()
    End Sub

    Private Sub UpdateConfigurableEffectUi()
        pColorizeEffect.Enabled = False
        pKernelSizeEffect.Enabled = False
        pHaloEffect.Enabled = False
        pWavesEffect.Enabled = False
        pRemoveBackgroundChromokeyEffect.Enabled = False
        pSoftenValueEffect.Enabled = False
        pSubstractBackgroundEffect.Enabled = False
        pFactorEffect.Enabled = False
        pFloodFillEffect.Enabled = False
        Select Case cbConfigurableEffects.SelectedIndex
            Case 0 ' Colorize
                pColorizeEffect.Enabled = True
            Case 1 ' Flood fill
                pFloodFillEffect.Enabled = True
            Case 2 ' Gaussian blur
                pKernelSizeEffect.Enabled = True
                nKernelSizeEffect.Maximum = 10
            Case 3 ' Halo
                pHaloEffect.Enabled = True
            Case 4 ' Max
                pKernelSizeEffect.Enabled = True
                If _currentImage = 0 Then
                    nKernelSizeEffect.Maximum = 1
                Else
                    nKernelSizeEffect.Maximum = CDec(_gdPictureImaging.GetWidth(_currentImage) / 2)
                End If
            Case 5 ' Median
                pKernelSizeEffect.Enabled = True
                nKernelSizeEffect.Maximum = 60
            Case 6 ' Min
                pKernelSizeEffect.Enabled = True
                If _currentImage = 0 Then
                    nKernelSizeEffect.Maximum = 1
                Else
                    nKernelSizeEffect.Maximum = CDec(_gdPictureImaging.GetWidth(_currentImage) / 2)
                End If
            Case 7 ' Remove background chromakey
                pRemoveBackgroundChromokeyEffect.Enabled = True
            Case 8 ' Soften
                pSoftenValueEffect.Enabled = True
            Case 9 ' Substract background
                pSubstractBackgroundEffect.Enabled = True
            Case 10 ' Swirl
                pFactorEffect.Enabled = True
            Case 11 ' Twirl
                pFactorEffect.Enabled = True
            Case 12 ' Waves (horizontal)
                pWavesEffect.Enabled = True
            Case 13 ' Waves (vertical)
                pWavesEffect.Enabled = True
        End Select
    End Sub

    Private Sub nHueEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nHueEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nSaturationEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nSaturationEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nLuminosityEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nLuminosityEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nKernelSizeEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nKernelSizeEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nLeftEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nLeftEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nTopEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nTopEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nRadiusEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nRadiusEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nWidthEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nWidthEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nHeightEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nHeightEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub cbComponentEffect_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbComponentEffect.SelectedIndexChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nVariationEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nVariationEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nMinKeyValueEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nMinKeyValueEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nSoftenValueEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nSoftenValueEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nRollingBallSizeEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nRollingBallSizeEffect.ValueChanged
        If nRollingBallSizeEffect.Value > 900 Then nRollingBallSizeEffect.Value = 900
        ChangeEffectsValues()
    End Sub

    Private Sub chkLightBackgroundEffect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkLightBackgroundEffect.CheckedChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nFactorEffect_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nFactorEffect.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub chkRotateFromCenter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkRotateFromCenter.CheckedChanged
        ChangeCustomRotationValues()
    End Sub

    Private Sub pbFloodFillEffectColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbFloodFillEffectColor.Click
        Using colorDialog As New ColorDialog
            If colorDialog.ShowDialog() = DialogResult.OK Then
                pbFloodFillEffectColor.BackColor = colorDialog.Color
            End If
        End Using
    End Sub

    Private Sub nFloodFillEffectXStart_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nFloodFillEffectXStart.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nFloodFillEffectYStart_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nFloodFillEffectYStart.ValueChanged
        ChangeEffectsValues()
    End Sub

    Private Sub pbFloodFillEffectColor_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pbFloodFillEffectColor.BackColorChanged
        ChangeEffectsValues()
    End Sub

    Private Sub nHueEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nHueEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nSaturationEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nSaturationEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nLuminosityEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nLuminosityEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nKernelSizeEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nKernelSizeEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nLeftEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nLeftEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nTopEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nTopEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nRadiusEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nRadiusEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nWidthEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nWidthEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nHeightEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nHeightEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nVariationEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nVariationEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nMinKeyValueEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nMinKeyValueEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nSoftenValueEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nSoftenValueEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nRollingBallSizeEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nRollingBallSizeEffect.KeyUp
        'ChangeEffectsValues()
    End Sub

    Private Sub nFactorEffect_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nFactorEffect.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nFloodFillEffectXStart_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nFloodFillEffectXStart.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub nFloodFillEffectYStart_KeyUp(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles nFloodFillEffectYStart.KeyUp
        ChangeEffectsValues()
    End Sub

    Private Sub rbRotateLeft_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRotateLeft.CheckedChanged
        UpdateRotationUi()
    End Sub

    Private Sub rbRotateRight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRotateRight.CheckedChanged
        UpdateRotationUi()
    End Sub

    Private Sub rbFlipHorizontal_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbFlipHorizontal.CheckedChanged
        UpdateRotationUi()
    End Sub

    Private Sub rbFlipVertical_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbFlipVertical.CheckedChanged
        UpdateRotationUi()
    End Sub

    Private Sub rbRotateCustomAngle_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRotateCustomAngle.CheckedChanged
        UpdateRotationUi()
    End Sub

    Private Sub UpdateRotationUi()
        chkRotateFromCenter.Enabled = rbRotateCustomAngle.Checked
        chkKeepImageDimensionRotation.Enabled = rbRotateCustomAngle.Checked
        lblCustomRotationBackgroundColor.Enabled = rbRotateCustomAngle.Checked
        pbRotationBackColor.Enabled = rbRotateCustomAngle.Checked
        nRotationAngle.Enabled = rbRotateCustomAngle.Checked
        ChangeCustomRotationValues()
    End Sub

    Private Sub pbRotationBackColor_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pbRotationBackColor.BackColorChanged
        ChangeCustomRotationValues()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Using f As New frmSave(_currentImage)
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnSnapInThumbnails_Click(sender As Object, e As EventArgs) Handles btnSnapInThumbnails.Click
        SelectSnapIn(0, "Thumbnails")
    End Sub

    Private Sub GdViewer1_TransferEnded(status As GdPictureStatus, Download As Boolean) Handles GdViewer1.TransferEnded
        GdViewer1.Focus()
        ThumbnailEx1.LoadFromGdViewer(GdViewer1)
        UpdateMainUi()
    End Sub

    Private Sub SmallThumbnailsToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SmallThumbnailsToolStripMenuItem1.Click
        ThumbnailEx1.ThumbnailSize = New Size(64, 64)
        SmallThumbnailsToolStripMenuItem1.Checked = True
        MediumThumbnailsToolStripMenuItem1.Checked = False
        LargeThumbnailsToolStripMenuItem1.Checked = False
    End Sub

    Private Sub MediumThumbnailsToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MediumThumbnailsToolStripMenuItem1.Click
        ThumbnailEx1.ThumbnailSize = New Size(128, 128)
        SmallThumbnailsToolStripMenuItem1.Checked = False
        MediumThumbnailsToolStripMenuItem1.Checked = True
        LargeThumbnailsToolStripMenuItem1.Checked = False
    End Sub

    Private Sub LargeThumbnailsToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LargeThumbnailsToolStripMenuItem1.Click
        ThumbnailEx1.ThumbnailSize = New Size(256, 256)
        SmallThumbnailsToolStripMenuItem1.Checked = False
        MediumThumbnailsToolStripMenuItem1.Checked = False
        LargeThumbnailsToolStripMenuItem1.Checked = True
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

    Private Sub btnFirstPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirstPage.Click
        GdViewer1.DisplayFirstPage()
    End Sub

    Private Sub btnPreviousPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreviousPage.Click
        GdViewer1.DisplayPreviousPage()
    End Sub

    Private Sub btnNextPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNextPage.Click
        GdViewer1.DisplayNextPage()
    End Sub

    Private Sub btnLastPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLastPage.Click
        GdViewer1.DisplayLastPage()
    End Sub

    Private Sub tbCurrentPage_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tbCurrentPage.Leave
        Dim page As Integer = 0
        If Integer.TryParse(tbCurrentPage.Text, page) Then
            If page > 0 And page <= GdViewer1.PageCount Then
                GdViewer1.DisplayPage(page)
                UpdateaNavigationToolbar()
            End If
        End If
    End Sub

End Class
