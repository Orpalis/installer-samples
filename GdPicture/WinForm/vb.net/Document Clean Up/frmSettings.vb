Option Strict On
Option Explicit On

Imports GdPicture14

Public Class frmSettings

    Private ReadOnly _owner As GdViewer

    Private ReadOnly _mouseWheelModes As New Dictionary(Of ViewerMouseWheelMode, String) From {
        {ViewerMouseWheelMode.MouseWheelModeZoom, "Zoom"},
        {ViewerMouseWheelMode.MouseWheelModeVerticalScroll, "Scroll"},
        {ViewerMouseWheelMode.MouseWheelModePageChange, "Page change"}
    }
    Private ReadOnly _documentAlignments As New Dictionary(Of ViewerDocumentAlignment, String) From {
        {ViewerDocumentAlignment.DocumentAlignmentBottomCenter, "Bottom center"},
        {ViewerDocumentAlignment.DocumentAlignmentBottomLeft, "Bottom left"},
        {ViewerDocumentAlignment.DocumentAlignmentBottomRight, "Bottom right"},
        {ViewerDocumentAlignment.DocumentAlignmentMiddleCenter, "Middle center"},
        {ViewerDocumentAlignment.DocumentAlignmentMiddleLeft, "Middle left"},
        {ViewerDocumentAlignment.DocumentAlignmentMiddleRight, "Middle right"},
        {ViewerDocumentAlignment.DocumentAlignmentTopCenter, "Top center"},
        {ViewerDocumentAlignment.DocumentAlignmentTopLeft, "Top left"},
        {ViewerDocumentAlignment.DocumentAlignmentTopRight, "Top right"}
    }
    Private ReadOnly _documentPositions As New Dictionary(Of ViewerDocumentPosition, String) From {
        {ViewerDocumentPosition.DocumentPositionBottomCenter, "Bottom center"},
        {ViewerDocumentPosition.DocumentPositionBottomLeft, "Bottom left"},
        {ViewerDocumentPosition.DocumentPositionBottomRight, "Bottom right"},
        {ViewerDocumentPosition.DocumentPositionMiddleCenter, "Middle center"},
        {ViewerDocumentPosition.DocumentPositionMiddleLeft, "Middle left"},
        {ViewerDocumentPosition.DocumentPositionMiddleRight, "Middle right"},
        {ViewerDocumentPosition.DocumentPositionTopCenter, "Top center"},
        {ViewerDocumentPosition.DocumentPositionTopLeft, "Top left"},
        {ViewerDocumentPosition.DocumentPositionTopRight, "Top right"}
    }
    Private ReadOnly _displayQualities As New Dictionary(Of DisplayQuality, String) From {
        {DisplayQuality.DisplayQualityLow, "Low"},
        {DisplayQuality.DisplayQualityBilinear, "Bilinear"},
        {DisplayQuality.DisplayQualityBicubic, "Bicubic"},
        {DisplayQuality.DisplayQualityBilinearHQ, "Bilinear HQ"},
        {DisplayQuality.DisplayQualityBicubicHQ, "Bicubic HQ"},
        {DisplayQuality.DisplayQualityAutomatic, "Automatic"}
    }
    Private ReadOnly _displayPageModes As New Dictionary(Of PageDisplayMode, String) From {
        {PageDisplayMode.MultiplePagesView, "Multiple pages"},
        {PageDisplayMode.SinglePageView, "Single page"}
    }

    Public Sub New(ByVal owner As GdViewer)
        InitializeComponent()
        _owner = owner
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In _mouseWheelModes
            cbMouseWheelMode.Items.Add(item.Value)
        Next
        For Each item In _documentAlignments
            cbDocumentAlignment.Items.Add(item.Value)
        Next
        For Each item In _documentPositions
            cbDocumentPosition.Items.Add(item.Value)
        Next
        For Each item In _displayQualities
            cbDisplayQuality.Items.Add(item.Value)
        Next
        For Each item In _displayPageModes
            cbPageDisplayMode.Items.Add(item.Value)
        Next
        
        cbMouseWheelMode.SelectedIndex = CType(_owner.MouseWheelMode, Integer)
        cbDocumentAlignment.SelectedItem = _documentAlignments(_owner.DocumentAlignment)
        cbDocumentPosition.SelectedItem = _documentPositions(_owner.DocumentPosition)
        cbDisplayQuality.SelectedItem = _displayQualities(_owner.DisplayQuality)
        cbPageDisplayMode.SelectedItem = _displayPageModes(_owner.PageDisplayMode)
        txtZoomStep.Text = CStr(_owner.ZoomStep)
        chkContinuousViewMode.Checked = _owner.ContinuousViewMode
        chkEnableMenu.Checked = _owner.EnableMenu
        PictureBox1.BackColor = _owner.BackColor
        chkIgnoreDocumentResolution.Checked = _owner.IgnoreDocumentResolution
        chkEnableDeferredPainting.Checked = _owner.EnableDeferredPainting

        chkAnnotationsDropShadow.Checked = _owner.AnnotationDropShadow
        chkHQAnnotationsRendering.Checked = _owner.HQAnnotationRendering

        chkEnableICM.Checked = _owner.EnableICM
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Using colorDialog As New ColorDialog
            If colorDialog.ShowDialog() = DialogResult.OK Then
                PictureBox1.BackColor = colorDialog.Color
            End If
        End Using
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        _owner.MouseWheelMode = _mouseWheelModes.FirstOrDefault(Function(x) x.Value.Contains(cbMouseWheelMode.SelectedItem.ToString())).Key
        _owner.DocumentAlignment = _documentAlignments.FirstOrDefault(Function(x) x.Value.Contains(cbDocumentAlignment.SelectedItem.ToString())).Key
        _owner.DocumentPosition = _documentPositions.FirstOrDefault(Function(x) x.Value.Contains(cbDocumentPosition.SelectedItem.ToString())).Key
        _owner.DisplayQuality = _displayQualities.FirstOrDefault(Function(x) x.Value.Contains(cbDisplayQuality.SelectedItem.ToString())).Key
        _owner.PageDisplayMode = _displayPageModes.FirstOrDefault(Function(x) x.Value.Contains(cbPageDisplayMode.SelectedItem.ToString())).Key
        _owner.ZoomStep = CInt(txtZoomStep.Text)
        _owner.ContinuousViewMode = chkContinuousViewMode.Checked
        _owner.EnableMenu = chkEnableMenu.Checked
        _owner.BackColor = PictureBox1.BackColor
        _owner.IgnoreDocumentResolution = chkIgnoreDocumentResolution.Checked
        _owner.EnableDeferredPainting = chkEnableDeferredPainting.Checked

        _owner.AnnotationDropShadow = chkAnnotationsDropShadow.Checked
        _owner.HQAnnotationRendering = chkHQAnnotationsRendering.Checked

        _owner.EnableICM = chkEnableICM.Checked

        Me.Close()
    End Sub

End Class