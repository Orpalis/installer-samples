<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tcLeftPanel = New System.Windows.Forms.TabControl()
        Me.tpThumbnails = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.thumbnailPanelToolstrip = New System.Windows.Forms.ToolStrip()
        Me.btnThumbSize = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LargeThumbnailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumThumbnailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallThumbnailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThumbnailEx1 = New GdPicture14.ThumbnailEx()
        Me.tpDocumentCleanUp = New System.Windows.Forms.TabPage()
        Me.pDocumentCleanUp = New System.Windows.Forms.Panel()
        Me.tbEffectsParameters = New System.Windows.Forms.TabControl()
        Me.tpAutoDeskewParameters = New System.Windows.Forms.TabPage()
        Me.chkAutoDeskewOptimistic = New System.Windows.Forms.CheckBox()
        Me.nAutoDeskewAngleStep = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pAutoDeskewBackColor = New System.Windows.Forms.PictureBox()
        Me.nAutoDeskewMaxAngleOfResearch = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpAutoTextInvert = New System.Windows.Forms.TabPage()
        Me.nAutoInvertTextMaxLinesThickness = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkAutoTextInvertConnectedToLines = New System.Windows.Forms.CheckBox()
        Me.chkAutoTextInvertFixBackground = New System.Windows.Forms.CheckBox()
        Me.nAutoInvertTextMaxBlackPercent = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nAutoInvertTextMinBlackPercent = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nAutoInvertTextMinObjectHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nAutoInvertTextMinObjectWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tpCropBlackBorders = New System.Windows.Forms.TabPage()
        Me.nCropBlackBordersSkipLinesCount = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nCropBlackBordersConfidence = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tpCropBorders = New System.Windows.Forms.TabPage()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cbCropBordersImageContext = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.nCropBordersHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nCropBordersWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nCropBordersTop = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nCropBordersLeft = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbCropBordersReferencePoint = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nCropBordersConfidence = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tpDeleteBlackBorders = New System.Windows.Forms.TabPage()
        Me.chkDeleteBlackBordersEffectSkewedBorders = New System.Windows.Forms.CheckBox()
        Me.nDeleteBlackBorderEffectMargin = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tpMedian = New System.Windows.Forms.TabPage()
        Me.nMedianEffectKernelSize = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tpRemoveBlob = New System.Windows.Forms.TabPage()
        Me.nRemoveBlobEffectMaxFillPercent = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.nRemoveBlobEffectMinFillPercent = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.nRemoveBlobEffectMaxBlobHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nRemoveBlobEffectMaxBlobWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nRemoveBlobEffectMinBlobHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.nRemoveBlobEffectMinBlobWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tpRemoveLines = New System.Windows.Forms.TabPage()
        Me.chkRemoveLinesEffectReconnectBrokenCharacters = New System.Windows.Forms.CheckBox()
        Me.nRemoveLinesEffectMaxInterception = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.nRemoveLinesEffectMinLineLength = New System.Windows.Forms.NumericUpDown()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.nRemoveLinesEffectMaxLineThickness = New System.Windows.Forms.NumericUpDown()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.nRemoveLinesEffectMaxLineGap = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbRemoveLinesEffectOrientation = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tpBitonalDespeckle = New System.Windows.Forms.TabPage()
        Me.chkBitonalDespeckleEffectFixText = New System.Windows.Forms.CheckBox()
        Me.tpBitonalSkeletonize = New System.Windows.Forms.TabPage()
        Me.nBitonalSkeletonizeEffectRepetition = New System.Windows.Forms.NumericUpDown()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tpBitonalVigorousDespeckle = New System.Windows.Forms.TabPage()
        Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI = New System.Windows.Forms.CheckBox()
        Me.tpBitonalDilate = New System.Windows.Forms.TabPage()
        Me.nBitonalDilateEffectKernelSize = New System.Windows.Forms.NumericUpDown()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tpRemoveHolePunch = New System.Windows.Forms.TabPage()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cbRemoveHolePunchEffectMargins = New System.Windows.Forms.ComboBox()
        Me.tpDespeckleAdvanced = New System.Windows.Forms.TabPage()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.nDespeckleStrength = New System.Windows.Forms.NumericUpDown()
        Me.cbDespeckleType = New System.Windows.Forms.ComboBox()
        Me.pDirectEffects = New System.Windows.Forms.Panel()
        Me.btnMoveEffectDown = New System.Windows.Forms.Button()
        Me.btnMoveEffectUp = New System.Windows.Forms.Button()
        Me.btnRemoveAllEffects = New System.Windows.Forms.Button()
        Me.btnRemoveEffect = New System.Windows.Forms.Button()
        Me.lstEffects = New System.Windows.Forms.ListBox()
        Me.btnAddEffect = New System.Windows.Forms.Button()
        Me.cbDocumentCleanUpEffects = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnApplyEffects = New System.Windows.Forms.Button()
        Me.btnResetEffects = New System.Windows.Forms.Button()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblSnapInPanel = New System.Windows.Forms.Label()
        Me.pSnapInButtons = New System.Windows.Forms.Panel()
        Me.btnSnapInThumbnails = New System.Windows.Forms.Button()
        Me.btnSnapInDocumentCleanUp = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GdViewerPreview = New GdPicture14.GdViewer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.statusbar = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pMain = New System.Windows.Forms.Panel()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnMouseMode = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaZoomingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagnifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFirstPage = New System.Windows.Forms.ToolStripButton()
        Me.btnPreviousPage = New System.Windows.Forms.ToolStripButton()
        Me.tbCurrentPage = New System.Windows.Forms.ToolStripTextBox()
        Me.lblPageCount = New System.Windows.Forms.ToolStripLabel()
        Me.btnNextPage = New System.Windows.Forms.ToolStripButton()
        Me.btnLastPage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.cbZoom = New System.Windows.Forms.ToolStripComboBox()
        Me.btnZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFitWidth = New System.Windows.Forms.ToolStripButton()
        Me.btnFitPage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRotateLeft = New System.Windows.Forms.ToolStripButton()
        Me.btnRotateRight = New System.Windows.Forms.ToolStripButton()
        Me.btnFlipX = New System.Windows.Forms.ToolStripButton()
        Me.btnFlipY = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAbout = New System.Windows.Forms.ToolStripButton()
        Me.mainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCopyToClipboard = New System.Windows.Forms.ToolStripButton()
        Me.btnImportFromClipboard = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tcLeftPanel.SuspendLayout
        Me.tpThumbnails.SuspendLayout
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout
        Me.ToolStripContainer1.ContentPanel.SuspendLayout
        Me.ToolStripContainer1.SuspendLayout
        Me.thumbnailPanelToolstrip.SuspendLayout
        Me.tpDocumentCleanUp.SuspendLayout
        Me.pDocumentCleanUp.SuspendLayout
        Me.tbEffectsParameters.SuspendLayout
        Me.tpAutoDeskewParameters.SuspendLayout
        CType(Me.nAutoDeskewAngleStep,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pAutoDeskewBackColor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nAutoDeskewMaxAngleOfResearch,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpAutoTextInvert.SuspendLayout
        CType(Me.nAutoInvertTextMaxLinesThickness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nAutoInvertTextMaxBlackPercent,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nAutoInvertTextMinBlackPercent,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nAutoInvertTextMinObjectHeight,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nAutoInvertTextMinObjectWidth,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpCropBlackBorders.SuspendLayout
        CType(Me.nCropBlackBordersSkipLinesCount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nCropBlackBordersConfidence,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpCropBorders.SuspendLayout
        CType(Me.nCropBordersHeight,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nCropBordersWidth,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nCropBordersTop,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nCropBordersLeft,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nCropBordersConfidence,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpDeleteBlackBorders.SuspendLayout
        CType(Me.nDeleteBlackBorderEffectMargin,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpMedian.SuspendLayout
        CType(Me.nMedianEffectKernelSize,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpRemoveBlob.SuspendLayout
        CType(Me.nRemoveBlobEffectMaxFillPercent,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nRemoveBlobEffectMinFillPercent,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nRemoveBlobEffectMaxBlobHeight,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nRemoveBlobEffectMaxBlobWidth,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nRemoveBlobEffectMinBlobHeight,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nRemoveBlobEffectMinBlobWidth,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpRemoveLines.SuspendLayout
        CType(Me.nRemoveLinesEffectMaxInterception,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nRemoveLinesEffectMinLineLength,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nRemoveLinesEffectMaxLineThickness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nRemoveLinesEffectMaxLineGap,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpBitonalDespeckle.SuspendLayout
        Me.tpBitonalSkeletonize.SuspendLayout
        CType(Me.nBitonalSkeletonizeEffectRepetition,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpBitonalVigorousDespeckle.SuspendLayout
        Me.tpBitonalDilate.SuspendLayout
        CType(Me.nBitonalDilateEffectKernelSize,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpRemoveHolePunch.SuspendLayout
        Me.tpDespeckleAdvanced.SuspendLayout
        CType(Me.nDespeckleStrength,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pDirectEffects.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.scMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.scMain.Panel1.SuspendLayout
        Me.scMain.Panel2.SuspendLayout
        Me.scMain.SuspendLayout
        Me.Panel6.SuspendLayout
        Me.Panel9.SuspendLayout
        Me.Panel7.SuspendLayout
        Me.pSnapInButtons.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel5.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.statusbar.SuspendLayout
        Me.pMain.SuspendLayout
        Me.mainToolStrip.SuspendLayout
        Me.SuspendLayout
        '
        'tcLeftPanel
        '
        Me.tcLeftPanel.Controls.Add(Me.tpThumbnails)
        Me.tcLeftPanel.Controls.Add(Me.tpDocumentCleanUp)
        Me.tcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcLeftPanel.Location = New System.Drawing.Point(0, 49)
        Me.tcLeftPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.tcLeftPanel.Multiline = true
        Me.tcLeftPanel.Name = "tcLeftPanel"
        Me.tcLeftPanel.Padding = New System.Drawing.Point(0, 0)
        Me.tcLeftPanel.SelectedIndex = 0
        Me.tcLeftPanel.Size = New System.Drawing.Size(397, 1014)
        Me.tcLeftPanel.TabIndex = 1
        '
        'tpThumbnails
        '
        Me.tpThumbnails.BackColor = System.Drawing.SystemColors.Control
        Me.tpThumbnails.Controls.Add(Me.ToolStripContainer1)
        Me.tpThumbnails.Location = New System.Drawing.Point(4, 29)
        Me.tpThumbnails.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpThumbnails.Name = "tpThumbnails"
        Me.tpThumbnails.Size = New System.Drawing.Size(389, 981)
        Me.tpThumbnails.TabIndex = 0
        Me.tpThumbnails.Text = "Thumbnails"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.thumbnailPanelToolstrip)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ThumbnailEx1)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(389, 925)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(389, 981)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'thumbnailPanelToolstrip
        '
        Me.thumbnailPanelToolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.thumbnailPanelToolstrip.Dock = System.Windows.Forms.DockStyle.None
        Me.thumbnailPanelToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.thumbnailPanelToolstrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.thumbnailPanelToolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThumbSize})
        Me.thumbnailPanelToolstrip.Location = New System.Drawing.Point(0, 0)
        Me.thumbnailPanelToolstrip.Name = "thumbnailPanelToolstrip"
        Me.thumbnailPanelToolstrip.Padding = New System.Windows.Forms.Padding(0)
        Me.thumbnailPanelToolstrip.Size = New System.Drawing.Size(389, 31)
        Me.thumbnailPanelToolstrip.Stretch = true
        Me.thumbnailPanelToolstrip.TabIndex = 0
        '
        'btnThumbSize
        '
        Me.btnThumbSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnThumbSize.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LargeThumbnailsToolStripMenuItem1, Me.MediumThumbnailsToolStripMenuItem1, Me.SmallThumbnailsToolStripMenuItem1})
        Me.btnThumbSize.Image = CType(resources.GetObject("btnThumbSize.Image"),System.Drawing.Image)
        Me.btnThumbSize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThumbSize.Name = "btnThumbSize"
        Me.btnThumbSize.Size = New System.Drawing.Size(42, 28)
        Me.btnThumbSize.Text = "btnThumbnailSize"
        Me.btnThumbSize.ToolTipText = "Thumbnail size"
        '
        'LargeThumbnailsToolStripMenuItem1
        '
        Me.LargeThumbnailsToolStripMenuItem1.Checked = true
        Me.LargeThumbnailsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LargeThumbnailsToolStripMenuItem1.Name = "LargeThumbnailsToolStripMenuItem1"
        Me.LargeThumbnailsToolStripMenuItem1.Size = New System.Drawing.Size(255, 30)
        Me.LargeThumbnailsToolStripMenuItem1.Text = "Large thumbnails"
        '
        'MediumThumbnailsToolStripMenuItem1
        '
        Me.MediumThumbnailsToolStripMenuItem1.Name = "MediumThumbnailsToolStripMenuItem1"
        Me.MediumThumbnailsToolStripMenuItem1.Size = New System.Drawing.Size(255, 30)
        Me.MediumThumbnailsToolStripMenuItem1.Text = "Medium thumbnails"
        '
        'SmallThumbnailsToolStripMenuItem1
        '
        Me.SmallThumbnailsToolStripMenuItem1.Name = "SmallThumbnailsToolStripMenuItem1"
        Me.SmallThumbnailsToolStripMenuItem1.Size = New System.Drawing.Size(255, 30)
        Me.SmallThumbnailsToolStripMenuItem1.Text = "Small thumbnails"
        '
        'ThumbnailEx1
        '
        Me.ThumbnailEx1.AllowDropFiles = false
        Me.ThumbnailEx1.AllowMoveItems = false
        Me.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control
        Me.ThumbnailEx1.CheckBoxes = false
        Me.ThumbnailEx1.CheckBoxesMarginLeft = 0
        Me.ThumbnailEx1.CheckBoxesMarginTop = 0
        Me.ThumbnailEx1.DefaultItemTextPrefix = "Page "
        Me.ThumbnailEx1.DisplayAnnotations = true
        Me.ThumbnailEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThumbnailEx1.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        Me.ThumbnailEx1.HotTracking = false
        Me.ThumbnailEx1.Location = New System.Drawing.Point(0, 0)
        Me.ThumbnailEx1.LockGdViewerEvents = false
        Me.ThumbnailEx1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ThumbnailEx1.MultiSelect = false
        Me.ThumbnailEx1.Name = "ThumbnailEx1"
        Me.ThumbnailEx1.OwnDrop = false
        Me.ThumbnailEx1.PauseThumbsLoading = false
        Me.ThumbnailEx1.PdfIncreaseTextContrast = false
        Me.ThumbnailEx1.PreloadAllItems = true
        Me.ThumbnailEx1.RotateExif = true
        Me.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(CType(CType(51,Byte),Integer), CType(CType(153,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.ThumbnailEx1.ShowText = true
        Me.ThumbnailEx1.Size = New System.Drawing.Size(389, 925)
        Me.ThumbnailEx1.TabIndex = 0
        Me.ThumbnailEx1.TextMarginLeft = 0
        Me.ThumbnailEx1.TextMarginTop = 0
        Me.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical
        Me.ThumbnailEx1.ThumbnailBorder = true
        Me.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Gray
        Me.ThumbnailEx1.ThumbnailSize = New System.Drawing.Size(256, 256)
        Me.ThumbnailEx1.ThumbnailSpacing = New System.Drawing.Size(0, 0)
        Me.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        '
        'tpDocumentCleanUp
        '
        Me.tpDocumentCleanUp.BackColor = System.Drawing.SystemColors.Control
        Me.tpDocumentCleanUp.Controls.Add(Me.pDocumentCleanUp)
        Me.tpDocumentCleanUp.Location = New System.Drawing.Point(4, 29)
        Me.tpDocumentCleanUp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpDocumentCleanUp.Name = "tpDocumentCleanUp"
        Me.tpDocumentCleanUp.Size = New System.Drawing.Size(389, 981)
        Me.tpDocumentCleanUp.TabIndex = 1
        Me.tpDocumentCleanUp.Text = "Clean Up"
        '
        'pDocumentCleanUp
        '
        Me.pDocumentCleanUp.Controls.Add(Me.tbEffectsParameters)
        Me.pDocumentCleanUp.Controls.Add(Me.pDirectEffects)
        Me.pDocumentCleanUp.Controls.Add(Me.Panel1)
        Me.pDocumentCleanUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDocumentCleanUp.Location = New System.Drawing.Point(0, 0)
        Me.pDocumentCleanUp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pDocumentCleanUp.Name = "pDocumentCleanUp"
        Me.pDocumentCleanUp.Size = New System.Drawing.Size(389, 981)
        Me.pDocumentCleanUp.TabIndex = 1
        '
        'tbEffectsParameters
        '
        Me.tbEffectsParameters.Controls.Add(Me.tpAutoDeskewParameters)
        Me.tbEffectsParameters.Controls.Add(Me.tpAutoTextInvert)
        Me.tbEffectsParameters.Controls.Add(Me.tpCropBlackBorders)
        Me.tbEffectsParameters.Controls.Add(Me.tpCropBorders)
        Me.tbEffectsParameters.Controls.Add(Me.tpDeleteBlackBorders)
        Me.tbEffectsParameters.Controls.Add(Me.tpMedian)
        Me.tbEffectsParameters.Controls.Add(Me.tpRemoveBlob)
        Me.tbEffectsParameters.Controls.Add(Me.tpRemoveLines)
        Me.tbEffectsParameters.Controls.Add(Me.tpBitonalDespeckle)
        Me.tbEffectsParameters.Controls.Add(Me.tpBitonalSkeletonize)
        Me.tbEffectsParameters.Controls.Add(Me.tpBitonalVigorousDespeckle)
        Me.tbEffectsParameters.Controls.Add(Me.tpBitonalDilate)
        Me.tbEffectsParameters.Controls.Add(Me.tpRemoveHolePunch)
        Me.tbEffectsParameters.Controls.Add(Me.tpDespeckleAdvanced)
        Me.tbEffectsParameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbEffectsParameters.Location = New System.Drawing.Point(0, 342)
        Me.tbEffectsParameters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEffectsParameters.Multiline = true
        Me.tbEffectsParameters.Name = "tbEffectsParameters"
        Me.tbEffectsParameters.SelectedIndex = 0
        Me.tbEffectsParameters.Size = New System.Drawing.Size(389, 594)
        Me.tbEffectsParameters.TabIndex = 6
        '
        'tpAutoDeskewParameters
        '
        Me.tpAutoDeskewParameters.Controls.Add(Me.chkAutoDeskewOptimistic)
        Me.tpAutoDeskewParameters.Controls.Add(Me.nAutoDeskewAngleStep)
        Me.tpAutoDeskewParameters.Controls.Add(Me.Label3)
        Me.tpAutoDeskewParameters.Controls.Add(Me.Label2)
        Me.tpAutoDeskewParameters.Controls.Add(Me.pAutoDeskewBackColor)
        Me.tpAutoDeskewParameters.Controls.Add(Me.nAutoDeskewMaxAngleOfResearch)
        Me.tpAutoDeskewParameters.Controls.Add(Me.Label1)
        Me.tpAutoDeskewParameters.Location = New System.Drawing.Point(4, 129)
        Me.tpAutoDeskewParameters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpAutoDeskewParameters.Name = "tpAutoDeskewParameters"
        Me.tpAutoDeskewParameters.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpAutoDeskewParameters.Size = New System.Drawing.Size(381, 461)
        Me.tpAutoDeskewParameters.TabIndex = 0
        Me.tpAutoDeskewParameters.Text = "Auto deskew"
        Me.tpAutoDeskewParameters.UseVisualStyleBackColor = true
        '
        'chkAutoDeskewOptimistic
        '
        Me.chkAutoDeskewOptimistic.AutoSize = true
        Me.chkAutoDeskewOptimistic.Location = New System.Drawing.Point(14, 131)
        Me.chkAutoDeskewOptimistic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkAutoDeskewOptimistic.Name = "chkAutoDeskewOptimistic"
        Me.chkAutoDeskewOptimistic.Size = New System.Drawing.Size(104, 24)
        Me.chkAutoDeskewOptimistic.TabIndex = 8
        Me.chkAutoDeskewOptimistic.Text = "Optimistic"
        Me.chkAutoDeskewOptimistic.UseVisualStyleBackColor = true
        '
        'nAutoDeskewAngleStep
        '
        Me.nAutoDeskewAngleStep.DecimalPlaces = 2
        Me.nAutoDeskewAngleStep.Location = New System.Drawing.Point(188, 91)
        Me.nAutoDeskewAngleStep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nAutoDeskewAngleStep.Name = "nAutoDeskewAngleStep"
        Me.nAutoDeskewAngleStep.Size = New System.Drawing.Size(78, 26)
        Me.nAutoDeskewAngleStep.TabIndex = 7
        Me.nAutoDeskewAngleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(9, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Angle step"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Back color"
        '
        'pAutoDeskewBackColor
        '
        Me.pAutoDeskewBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pAutoDeskewBackColor.Location = New System.Drawing.Point(188, 49)
        Me.pAutoDeskewBackColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pAutoDeskewBackColor.Name = "pAutoDeskewBackColor"
        Me.pAutoDeskewBackColor.Size = New System.Drawing.Size(30, 31)
        Me.pAutoDeskewBackColor.TabIndex = 4
        Me.pAutoDeskewBackColor.TabStop = false
        '
        'nAutoDeskewMaxAngleOfResearch
        '
        Me.nAutoDeskewMaxAngleOfResearch.DecimalPlaces = 2
        Me.nAutoDeskewMaxAngleOfResearch.Location = New System.Drawing.Point(188, 9)
        Me.nAutoDeskewMaxAngleOfResearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nAutoDeskewMaxAngleOfResearch.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nAutoDeskewMaxAngleOfResearch.Name = "nAutoDeskewMaxAngleOfResearch"
        Me.nAutoDeskewMaxAngleOfResearch.Size = New System.Drawing.Size(78, 26)
        Me.nAutoDeskewMaxAngleOfResearch.TabIndex = 1
        Me.nAutoDeskewMaxAngleOfResearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Max angle of research"
        '
        'tpAutoTextInvert
        '
        Me.tpAutoTextInvert.Controls.Add(Me.nAutoInvertTextMaxLinesThickness)
        Me.tpAutoTextInvert.Controls.Add(Me.Label8)
        Me.tpAutoTextInvert.Controls.Add(Me.chkAutoTextInvertConnectedToLines)
        Me.tpAutoTextInvert.Controls.Add(Me.chkAutoTextInvertFixBackground)
        Me.tpAutoTextInvert.Controls.Add(Me.nAutoInvertTextMaxBlackPercent)
        Me.tpAutoTextInvert.Controls.Add(Me.Label7)
        Me.tpAutoTextInvert.Controls.Add(Me.nAutoInvertTextMinBlackPercent)
        Me.tpAutoTextInvert.Controls.Add(Me.Label6)
        Me.tpAutoTextInvert.Controls.Add(Me.nAutoInvertTextMinObjectHeight)
        Me.tpAutoTextInvert.Controls.Add(Me.Label5)
        Me.tpAutoTextInvert.Controls.Add(Me.nAutoInvertTextMinObjectWidth)
        Me.tpAutoTextInvert.Controls.Add(Me.Label4)
        Me.tpAutoTextInvert.Location = New System.Drawing.Point(4, 129)
        Me.tpAutoTextInvert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpAutoTextInvert.Name = "tpAutoTextInvert"
        Me.tpAutoTextInvert.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpAutoTextInvert.Size = New System.Drawing.Size(381, 461)
        Me.tpAutoTextInvert.TabIndex = 1
        Me.tpAutoTextInvert.Text = "Auto text invert"
        Me.tpAutoTextInvert.UseVisualStyleBackColor = true
        '
        'nAutoInvertTextMaxLinesThickness
        '
        Me.nAutoInvertTextMaxLinesThickness.Location = New System.Drawing.Point(156, 240)
        Me.nAutoInvertTextMaxLinesThickness.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nAutoInvertTextMaxLinesThickness.Name = "nAutoInvertTextMaxLinesThickness"
        Me.nAutoInvertTextMaxLinesThickness.Size = New System.Drawing.Size(98, 26)
        Me.nAutoInvertTextMaxLinesThickness.TabIndex = 11
        Me.nAutoInvertTextMaxLinesThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(9, 243)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Max lines thickness"
        '
        'chkAutoTextInvertConnectedToLines
        '
        Me.chkAutoTextInvertConnectedToLines.AutoSize = true
        Me.chkAutoTextInvertConnectedToLines.Location = New System.Drawing.Point(14, 205)
        Me.chkAutoTextInvertConnectedToLines.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkAutoTextInvertConnectedToLines.Name = "chkAutoTextInvertConnectedToLines"
        Me.chkAutoTextInvertConnectedToLines.Size = New System.Drawing.Size(167, 24)
        Me.chkAutoTextInvertConnectedToLines.TabIndex = 9
        Me.chkAutoTextInvertConnectedToLines.Text = "Connected to lines"
        Me.chkAutoTextInvertConnectedToLines.UseVisualStyleBackColor = true
        '
        'chkAutoTextInvertFixBackground
        '
        Me.chkAutoTextInvertFixBackground.AutoSize = true
        Me.chkAutoTextInvertFixBackground.Location = New System.Drawing.Point(14, 169)
        Me.chkAutoTextInvertFixBackground.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkAutoTextInvertFixBackground.Name = "chkAutoTextInvertFixBackground"
        Me.chkAutoTextInvertFixBackground.Size = New System.Drawing.Size(143, 24)
        Me.chkAutoTextInvertFixBackground.TabIndex = 8
        Me.chkAutoTextInvertFixBackground.Text = "Fix background"
        Me.chkAutoTextInvertFixBackground.UseVisualStyleBackColor = true
        '
        'nAutoInvertTextMaxBlackPercent
        '
        Me.nAutoInvertTextMaxBlackPercent.Location = New System.Drawing.Point(156, 129)
        Me.nAutoInvertTextMaxBlackPercent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nAutoInvertTextMaxBlackPercent.Name = "nAutoInvertTextMaxBlackPercent"
        Me.nAutoInvertTextMaxBlackPercent.Size = New System.Drawing.Size(98, 26)
        Me.nAutoInvertTextMaxBlackPercent.TabIndex = 7
        Me.nAutoInvertTextMaxBlackPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(9, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Max black percent"
        '
        'nAutoInvertTextMinBlackPercent
        '
        Me.nAutoInvertTextMinBlackPercent.Location = New System.Drawing.Point(156, 89)
        Me.nAutoInvertTextMinBlackPercent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nAutoInvertTextMinBlackPercent.Name = "nAutoInvertTextMinBlackPercent"
        Me.nAutoInvertTextMinBlackPercent.Size = New System.Drawing.Size(98, 26)
        Me.nAutoInvertTextMinBlackPercent.TabIndex = 5
        Me.nAutoInvertTextMinBlackPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(9, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Min black percent"
        '
        'nAutoInvertTextMinObjectHeight
        '
        Me.nAutoInvertTextMinObjectHeight.Location = New System.Drawing.Point(156, 49)
        Me.nAutoInvertTextMinObjectHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nAutoInvertTextMinObjectHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nAutoInvertTextMinObjectHeight.Name = "nAutoInvertTextMinObjectHeight"
        Me.nAutoInvertTextMinObjectHeight.Size = New System.Drawing.Size(98, 26)
        Me.nAutoInvertTextMinObjectHeight.TabIndex = 3
        Me.nAutoInvertTextMinObjectHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(9, 52)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Min object height"
        '
        'nAutoInvertTextMinObjectWidth
        '
        Me.nAutoInvertTextMinObjectWidth.Location = New System.Drawing.Point(156, 9)
        Me.nAutoInvertTextMinObjectWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nAutoInvertTextMinObjectWidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nAutoInvertTextMinObjectWidth.Name = "nAutoInvertTextMinObjectWidth"
        Me.nAutoInvertTextMinObjectWidth.Size = New System.Drawing.Size(98, 26)
        Me.nAutoInvertTextMinObjectWidth.TabIndex = 1
        Me.nAutoInvertTextMinObjectWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(9, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Min object width"
        '
        'tpCropBlackBorders
        '
        Me.tpCropBlackBorders.Controls.Add(Me.nCropBlackBordersSkipLinesCount)
        Me.tpCropBlackBorders.Controls.Add(Me.Label10)
        Me.tpCropBlackBorders.Controls.Add(Me.nCropBlackBordersConfidence)
        Me.tpCropBlackBorders.Controls.Add(Me.Label9)
        Me.tpCropBlackBorders.Location = New System.Drawing.Point(4, 129)
        Me.tpCropBlackBorders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpCropBlackBorders.Name = "tpCropBlackBorders"
        Me.tpCropBlackBorders.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpCropBlackBorders.Size = New System.Drawing.Size(381, 461)
        Me.tpCropBlackBorders.TabIndex = 2
        Me.tpCropBlackBorders.Text = "Crop black borders"
        Me.tpCropBlackBorders.UseVisualStyleBackColor = true
        '
        'nCropBlackBordersSkipLinesCount
        '
        Me.nCropBlackBordersSkipLinesCount.Location = New System.Drawing.Point(141, 49)
        Me.nCropBlackBordersSkipLinesCount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nCropBlackBordersSkipLinesCount.Name = "nCropBlackBordersSkipLinesCount"
        Me.nCropBlackBordersSkipLinesCount.Size = New System.Drawing.Size(78, 26)
        Me.nCropBlackBordersSkipLinesCount.TabIndex = 5
        Me.nCropBlackBordersSkipLinesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(9, 52)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Skip lines count"
        '
        'nCropBlackBordersConfidence
        '
        Me.nCropBlackBordersConfidence.DecimalPlaces = 2
        Me.nCropBlackBordersConfidence.Location = New System.Drawing.Point(141, 9)
        Me.nCropBlackBordersConfidence.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nCropBlackBordersConfidence.Name = "nCropBlackBordersConfidence"
        Me.nCropBlackBordersConfidence.Size = New System.Drawing.Size(78, 26)
        Me.nCropBlackBordersConfidence.TabIndex = 3
        Me.nCropBlackBordersConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(9, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Confidence"
        '
        'tpCropBorders
        '
        Me.tpCropBorders.Controls.Add(Me.Label38)
        Me.tpCropBorders.Controls.Add(Me.cbCropBordersImageContext)
        Me.tpCropBorders.Controls.Add(Me.Label17)
        Me.tpCropBorders.Controls.Add(Me.nCropBordersHeight)
        Me.tpCropBorders.Controls.Add(Me.Label16)
        Me.tpCropBorders.Controls.Add(Me.nCropBordersWidth)
        Me.tpCropBorders.Controls.Add(Me.Label15)
        Me.tpCropBorders.Controls.Add(Me.nCropBordersTop)
        Me.tpCropBorders.Controls.Add(Me.Label14)
        Me.tpCropBorders.Controls.Add(Me.nCropBordersLeft)
        Me.tpCropBorders.Controls.Add(Me.Label13)
        Me.tpCropBorders.Controls.Add(Me.cbCropBordersReferencePoint)
        Me.tpCropBorders.Controls.Add(Me.Label12)
        Me.tpCropBorders.Controls.Add(Me.nCropBordersConfidence)
        Me.tpCropBorders.Controls.Add(Me.Label11)
        Me.tpCropBorders.Location = New System.Drawing.Point(4, 129)
        Me.tpCropBorders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpCropBorders.Name = "tpCropBorders"
        Me.tpCropBorders.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpCropBorders.Size = New System.Drawing.Size(381, 461)
        Me.tpCropBorders.TabIndex = 3
        Me.tpCropBorders.Text = "Crop borders"
        Me.tpCropBorders.UseVisualStyleBackColor = true
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(13, 321)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(452, 121)
        Me.Label38.TabIndex = 18
        Me.Label38.Text = resources.GetString("Label38.Text")
        '
        'cbCropBordersImageContext
        '
        Me.cbCropBordersImageContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCropBordersImageContext.Enabled = false
        Me.cbCropBordersImageContext.FormattingEnabled = true
        Me.cbCropBordersImageContext.Location = New System.Drawing.Point(142, 251)
        Me.cbCropBordersImageContext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbCropBordersImageContext.Name = "cbCropBordersImageContext"
        Me.cbCropBordersImageContext.Size = New System.Drawing.Size(180, 28)
        Me.cbCropBordersImageContext.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(9, 255)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Image context"
        '
        'nCropBordersHeight
        '
        Me.nCropBordersHeight.Enabled = false
        Me.nCropBordersHeight.Location = New System.Drawing.Point(142, 211)
        Me.nCropBordersHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nCropBordersHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nCropBordersHeight.Name = "nCropBordersHeight"
        Me.nCropBordersHeight.Size = New System.Drawing.Size(98, 26)
        Me.nCropBordersHeight.TabIndex = 15
        Me.nCropBordersHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(9, 214)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 20)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Height"
        '
        'nCropBordersWidth
        '
        Me.nCropBordersWidth.Enabled = false
        Me.nCropBordersWidth.Location = New System.Drawing.Point(142, 171)
        Me.nCropBordersWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nCropBordersWidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nCropBordersWidth.Name = "nCropBordersWidth"
        Me.nCropBordersWidth.Size = New System.Drawing.Size(98, 26)
        Me.nCropBordersWidth.TabIndex = 13
        Me.nCropBordersWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Location = New System.Drawing.Point(9, 174)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 20)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Width"
        '
        'nCropBordersTop
        '
        Me.nCropBordersTop.Enabled = false
        Me.nCropBordersTop.Location = New System.Drawing.Point(142, 131)
        Me.nCropBordersTop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nCropBordersTop.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nCropBordersTop.Name = "nCropBordersTop"
        Me.nCropBordersTop.Size = New System.Drawing.Size(98, 26)
        Me.nCropBordersTop.TabIndex = 11
        Me.nCropBordersTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(9, 134)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Top"
        '
        'nCropBordersLeft
        '
        Me.nCropBordersLeft.Enabled = false
        Me.nCropBordersLeft.Location = New System.Drawing.Point(142, 91)
        Me.nCropBordersLeft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nCropBordersLeft.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nCropBordersLeft.Name = "nCropBordersLeft"
        Me.nCropBordersLeft.Size = New System.Drawing.Size(98, 26)
        Me.nCropBordersLeft.TabIndex = 9
        Me.nCropBordersLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(9, 94)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 20)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Left"
        '
        'cbCropBordersReferencePoint
        '
        Me.cbCropBordersReferencePoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCropBordersReferencePoint.FormattingEnabled = true
        Me.cbCropBordersReferencePoint.Location = New System.Drawing.Point(142, 49)
        Me.cbCropBordersReferencePoint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbCropBordersReferencePoint.Name = "cbCropBordersReferencePoint"
        Me.cbCropBordersReferencePoint.Size = New System.Drawing.Size(180, 28)
        Me.cbCropBordersReferencePoint.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(9, 54)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Reference point"
        '
        'nCropBordersConfidence
        '
        Me.nCropBordersConfidence.DecimalPlaces = 2
        Me.nCropBordersConfidence.Location = New System.Drawing.Point(142, 9)
        Me.nCropBordersConfidence.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nCropBordersConfidence.Name = "nCropBordersConfidence"
        Me.nCropBordersConfidence.Size = New System.Drawing.Size(78, 26)
        Me.nCropBordersConfidence.TabIndex = 5
        Me.nCropBordersConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(9, 12)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Confidence"
        '
        'tpDeleteBlackBorders
        '
        Me.tpDeleteBlackBorders.Controls.Add(Me.chkDeleteBlackBordersEffectSkewedBorders)
        Me.tpDeleteBlackBorders.Controls.Add(Me.nDeleteBlackBorderEffectMargin)
        Me.tpDeleteBlackBorders.Controls.Add(Me.Label18)
        Me.tpDeleteBlackBorders.Location = New System.Drawing.Point(4, 129)
        Me.tpDeleteBlackBorders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpDeleteBlackBorders.Name = "tpDeleteBlackBorders"
        Me.tpDeleteBlackBorders.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpDeleteBlackBorders.Size = New System.Drawing.Size(381, 461)
        Me.tpDeleteBlackBorders.TabIndex = 4
        Me.tpDeleteBlackBorders.Text = "Delete black borders"
        Me.tpDeleteBlackBorders.UseVisualStyleBackColor = true
        '
        'chkDeleteBlackBordersEffectSkewedBorders
        '
        Me.chkDeleteBlackBordersEffectSkewedBorders.AutoSize = true
        Me.chkDeleteBlackBordersEffectSkewedBorders.Location = New System.Drawing.Point(14, 49)
        Me.chkDeleteBlackBordersEffectSkewedBorders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkDeleteBlackBordersEffectSkewedBorders.Name = "chkDeleteBlackBordersEffectSkewedBorders"
        Me.chkDeleteBlackBordersEffectSkewedBorders.Size = New System.Drawing.Size(150, 24)
        Me.chkDeleteBlackBordersEffectSkewedBorders.TabIndex = 11
        Me.chkDeleteBlackBordersEffectSkewedBorders.Text = "Skewed borders"
        Me.chkDeleteBlackBordersEffectSkewedBorders.UseVisualStyleBackColor = true
        '
        'nDeleteBlackBorderEffectMargin
        '
        Me.nDeleteBlackBorderEffectMargin.Location = New System.Drawing.Point(76, 9)
        Me.nDeleteBlackBorderEffectMargin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nDeleteBlackBorderEffectMargin.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nDeleteBlackBorderEffectMargin.Name = "nDeleteBlackBorderEffectMargin"
        Me.nDeleteBlackBorderEffectMargin.Size = New System.Drawing.Size(98, 26)
        Me.nDeleteBlackBorderEffectMargin.TabIndex = 10
        Me.nDeleteBlackBorderEffectMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Location = New System.Drawing.Point(9, 12)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 20)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Margin"
        '
        'tpMedian
        '
        Me.tpMedian.Controls.Add(Me.nMedianEffectKernelSize)
        Me.tpMedian.Controls.Add(Me.Label19)
        Me.tpMedian.Location = New System.Drawing.Point(4, 129)
        Me.tpMedian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpMedian.Name = "tpMedian"
        Me.tpMedian.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpMedian.Size = New System.Drawing.Size(381, 461)
        Me.tpMedian.TabIndex = 5
        Me.tpMedian.Text = "Median"
        Me.tpMedian.UseVisualStyleBackColor = true
        '
        'nMedianEffectKernelSize
        '
        Me.nMedianEffectKernelSize.Location = New System.Drawing.Point(104, 9)
        Me.nMedianEffectKernelSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nMedianEffectKernelSize.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nMedianEffectKernelSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nMedianEffectKernelSize.Name = "nMedianEffectKernelSize"
        Me.nMedianEffectKernelSize.Size = New System.Drawing.Size(98, 26)
        Me.nMedianEffectKernelSize.TabIndex = 12
        Me.nMedianEffectKernelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nMedianEffectKernelSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Location = New System.Drawing.Point(9, 12)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 20)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Kernel size"
        '
        'tpRemoveBlob
        '
        Me.tpRemoveBlob.Controls.Add(Me.nRemoveBlobEffectMaxFillPercent)
        Me.tpRemoveBlob.Controls.Add(Me.Label25)
        Me.tpRemoveBlob.Controls.Add(Me.nRemoveBlobEffectMinFillPercent)
        Me.tpRemoveBlob.Controls.Add(Me.Label24)
        Me.tpRemoveBlob.Controls.Add(Me.nRemoveBlobEffectMaxBlobHeight)
        Me.tpRemoveBlob.Controls.Add(Me.Label23)
        Me.tpRemoveBlob.Controls.Add(Me.nRemoveBlobEffectMaxBlobWidth)
        Me.tpRemoveBlob.Controls.Add(Me.Label22)
        Me.tpRemoveBlob.Controls.Add(Me.nRemoveBlobEffectMinBlobHeight)
        Me.tpRemoveBlob.Controls.Add(Me.Label21)
        Me.tpRemoveBlob.Controls.Add(Me.nRemoveBlobEffectMinBlobWidth)
        Me.tpRemoveBlob.Controls.Add(Me.Label20)
        Me.tpRemoveBlob.Location = New System.Drawing.Point(4, 129)
        Me.tpRemoveBlob.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpRemoveBlob.Name = "tpRemoveBlob"
        Me.tpRemoveBlob.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpRemoveBlob.Size = New System.Drawing.Size(381, 461)
        Me.tpRemoveBlob.TabIndex = 6
        Me.tpRemoveBlob.Text = "Remove blob"
        Me.tpRemoveBlob.UseVisualStyleBackColor = true
        '
        'nRemoveBlobEffectMaxFillPercent
        '
        Me.nRemoveBlobEffectMaxFillPercent.Location = New System.Drawing.Point(130, 209)
        Me.nRemoveBlobEffectMaxFillPercent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveBlobEffectMaxFillPercent.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nRemoveBlobEffectMaxFillPercent.Name = "nRemoveBlobEffectMaxFillPercent"
        Me.nRemoveBlobEffectMaxFillPercent.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveBlobEffectMaxFillPercent.TabIndex = 21
        Me.nRemoveBlobEffectMaxFillPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nRemoveBlobEffectMaxFillPercent.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Location = New System.Drawing.Point(9, 212)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 20)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Max fill percent"
        '
        'nRemoveBlobEffectMinFillPercent
        '
        Me.nRemoveBlobEffectMinFillPercent.Location = New System.Drawing.Point(130, 169)
        Me.nRemoveBlobEffectMinFillPercent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveBlobEffectMinFillPercent.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nRemoveBlobEffectMinFillPercent.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nRemoveBlobEffectMinFillPercent.Name = "nRemoveBlobEffectMinFillPercent"
        Me.nRemoveBlobEffectMinFillPercent.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveBlobEffectMinFillPercent.TabIndex = 19
        Me.nRemoveBlobEffectMinFillPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nRemoveBlobEffectMinFillPercent.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label24
        '
        Me.Label24.AutoSize = true
        Me.Label24.Location = New System.Drawing.Point(9, 172)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 20)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "Min fill percent"
        '
        'nRemoveBlobEffectMaxBlobHeight
        '
        Me.nRemoveBlobEffectMaxBlobHeight.Location = New System.Drawing.Point(130, 129)
        Me.nRemoveBlobEffectMaxBlobHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveBlobEffectMaxBlobHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nRemoveBlobEffectMaxBlobHeight.Name = "nRemoveBlobEffectMaxBlobHeight"
        Me.nRemoveBlobEffectMaxBlobHeight.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveBlobEffectMaxBlobHeight.TabIndex = 17
        Me.nRemoveBlobEffectMaxBlobHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Location = New System.Drawing.Point(9, 132)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(120, 20)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "Max blob height"
        '
        'nRemoveBlobEffectMaxBlobWidth
        '
        Me.nRemoveBlobEffectMaxBlobWidth.Location = New System.Drawing.Point(130, 89)
        Me.nRemoveBlobEffectMaxBlobWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveBlobEffectMaxBlobWidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nRemoveBlobEffectMaxBlobWidth.Name = "nRemoveBlobEffectMaxBlobWidth"
        Me.nRemoveBlobEffectMaxBlobWidth.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveBlobEffectMaxBlobWidth.TabIndex = 15
        Me.nRemoveBlobEffectMaxBlobWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Location = New System.Drawing.Point(9, 92)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(113, 20)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Max blob width"
        '
        'nRemoveBlobEffectMinBlobHeight
        '
        Me.nRemoveBlobEffectMinBlobHeight.Location = New System.Drawing.Point(130, 49)
        Me.nRemoveBlobEffectMinBlobHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveBlobEffectMinBlobHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nRemoveBlobEffectMinBlobHeight.Name = "nRemoveBlobEffectMinBlobHeight"
        Me.nRemoveBlobEffectMinBlobHeight.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveBlobEffectMinBlobHeight.TabIndex = 13
        Me.nRemoveBlobEffectMinBlobHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Location = New System.Drawing.Point(9, 52)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 20)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Min blob height"
        '
        'nRemoveBlobEffectMinBlobWidth
        '
        Me.nRemoveBlobEffectMinBlobWidth.Location = New System.Drawing.Point(130, 9)
        Me.nRemoveBlobEffectMinBlobWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveBlobEffectMinBlobWidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nRemoveBlobEffectMinBlobWidth.Name = "nRemoveBlobEffectMinBlobWidth"
        Me.nRemoveBlobEffectMinBlobWidth.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveBlobEffectMinBlobWidth.TabIndex = 11
        Me.nRemoveBlobEffectMinBlobWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Location = New System.Drawing.Point(9, 12)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 20)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Min blob width"
        '
        'tpRemoveLines
        '
        Me.tpRemoveLines.Controls.Add(Me.chkRemoveLinesEffectReconnectBrokenCharacters)
        Me.tpRemoveLines.Controls.Add(Me.nRemoveLinesEffectMaxInterception)
        Me.tpRemoveLines.Controls.Add(Me.Label30)
        Me.tpRemoveLines.Controls.Add(Me.nRemoveLinesEffectMinLineLength)
        Me.tpRemoveLines.Controls.Add(Me.Label29)
        Me.tpRemoveLines.Controls.Add(Me.nRemoveLinesEffectMaxLineThickness)
        Me.tpRemoveLines.Controls.Add(Me.Label28)
        Me.tpRemoveLines.Controls.Add(Me.nRemoveLinesEffectMaxLineGap)
        Me.tpRemoveLines.Controls.Add(Me.Label27)
        Me.tpRemoveLines.Controls.Add(Me.cbRemoveLinesEffectOrientation)
        Me.tpRemoveLines.Controls.Add(Me.Label26)
        Me.tpRemoveLines.Location = New System.Drawing.Point(4, 129)
        Me.tpRemoveLines.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpRemoveLines.Name = "tpRemoveLines"
        Me.tpRemoveLines.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpRemoveLines.Size = New System.Drawing.Size(381, 461)
        Me.tpRemoveLines.TabIndex = 7
        Me.tpRemoveLines.Text = "Remove lines"
        Me.tpRemoveLines.UseVisualStyleBackColor = true
        '
        'chkRemoveLinesEffectReconnectBrokenCharacters
        '
        Me.chkRemoveLinesEffectReconnectBrokenCharacters.AutoSize = true
        Me.chkRemoveLinesEffectReconnectBrokenCharacters.Location = New System.Drawing.Point(14, 211)
        Me.chkRemoveLinesEffectReconnectBrokenCharacters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkRemoveLinesEffectReconnectBrokenCharacters.Name = "chkRemoveLinesEffectReconnectBrokenCharacters"
        Me.chkRemoveLinesEffectReconnectBrokenCharacters.Size = New System.Drawing.Size(245, 24)
        Me.chkRemoveLinesEffectReconnectBrokenCharacters.TabIndex = 20
        Me.chkRemoveLinesEffectReconnectBrokenCharacters.Text = "Reconnect broken characters"
        Me.chkRemoveLinesEffectReconnectBrokenCharacters.UseVisualStyleBackColor = true
        '
        'nRemoveLinesEffectMaxInterception
        '
        Me.nRemoveLinesEffectMaxInterception.Location = New System.Drawing.Point(165, 171)
        Me.nRemoveLinesEffectMaxInterception.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveLinesEffectMaxInterception.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nRemoveLinesEffectMaxInterception.Name = "nRemoveLinesEffectMaxInterception"
        Me.nRemoveLinesEffectMaxInterception.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveLinesEffectMaxInterception.TabIndex = 19
        Me.nRemoveLinesEffectMaxInterception.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nRemoveLinesEffectMaxInterception.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.AutoSize = true
        Me.Label30.Location = New System.Drawing.Point(8, 174)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(125, 20)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "Max interception"
        '
        'nRemoveLinesEffectMinLineLength
        '
        Me.nRemoveLinesEffectMinLineLength.Location = New System.Drawing.Point(166, 131)
        Me.nRemoveLinesEffectMinLineLength.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveLinesEffectMinLineLength.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nRemoveLinesEffectMinLineLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nRemoveLinesEffectMinLineLength.Name = "nRemoveLinesEffectMinLineLength"
        Me.nRemoveLinesEffectMinLineLength.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveLinesEffectMinLineLength.TabIndex = 17
        Me.nRemoveLinesEffectMinLineLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nRemoveLinesEffectMinLineLength.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label29
        '
        Me.Label29.AutoSize = true
        Me.Label29.Location = New System.Drawing.Point(9, 134)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(110, 20)
        Me.Label29.TabIndex = 16
        Me.Label29.Text = "Min line length"
        '
        'nRemoveLinesEffectMaxLineThickness
        '
        Me.nRemoveLinesEffectMaxLineThickness.Location = New System.Drawing.Point(166, 91)
        Me.nRemoveLinesEffectMaxLineThickness.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveLinesEffectMaxLineThickness.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nRemoveLinesEffectMaxLineThickness.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nRemoveLinesEffectMaxLineThickness.Name = "nRemoveLinesEffectMaxLineThickness"
        Me.nRemoveLinesEffectMaxLineThickness.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveLinesEffectMaxLineThickness.TabIndex = 15
        Me.nRemoveLinesEffectMaxLineThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.Location = New System.Drawing.Point(9, 94)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(145, 20)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Max line thicknesss"
        '
        'nRemoveLinesEffectMaxLineGap
        '
        Me.nRemoveLinesEffectMaxLineGap.Location = New System.Drawing.Point(166, 51)
        Me.nRemoveLinesEffectMaxLineGap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRemoveLinesEffectMaxLineGap.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nRemoveLinesEffectMaxLineGap.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nRemoveLinesEffectMaxLineGap.Name = "nRemoveLinesEffectMaxLineGap"
        Me.nRemoveLinesEffectMaxLineGap.Size = New System.Drawing.Size(98, 26)
        Me.nRemoveLinesEffectMaxLineGap.TabIndex = 13
        Me.nRemoveLinesEffectMaxLineGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.Location = New System.Drawing.Point(9, 54)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 20)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Max line gap"
        '
        'cbRemoveLinesEffectOrientation
        '
        Me.cbRemoveLinesEffectOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRemoveLinesEffectOrientation.FormattingEnabled = true
        Me.cbRemoveLinesEffectOrientation.Location = New System.Drawing.Point(166, 9)
        Me.cbRemoveLinesEffectOrientation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbRemoveLinesEffectOrientation.Name = "cbRemoveLinesEffectOrientation"
        Me.cbRemoveLinesEffectOrientation.Size = New System.Drawing.Size(180, 28)
        Me.cbRemoveLinesEffectOrientation.TabIndex = 9
        '
        'Label26
        '
        Me.Label26.AutoSize = true
        Me.Label26.Location = New System.Drawing.Point(9, 14)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 20)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Orientation"
        '
        'tpBitonalDespeckle
        '
        Me.tpBitonalDespeckle.Controls.Add(Me.chkBitonalDespeckleEffectFixText)
        Me.tpBitonalDespeckle.Location = New System.Drawing.Point(4, 129)
        Me.tpBitonalDespeckle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpBitonalDespeckle.Name = "tpBitonalDespeckle"
        Me.tpBitonalDespeckle.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpBitonalDespeckle.Size = New System.Drawing.Size(381, 461)
        Me.tpBitonalDespeckle.TabIndex = 8
        Me.tpBitonalDespeckle.Text = "Bitonal despeckle"
        Me.tpBitonalDespeckle.UseVisualStyleBackColor = true
        '
        'chkBitonalDespeckleEffectFixText
        '
        Me.chkBitonalDespeckleEffectFixText.AutoSize = true
        Me.chkBitonalDespeckleEffectFixText.Location = New System.Drawing.Point(9, 9)
        Me.chkBitonalDespeckleEffectFixText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkBitonalDespeckleEffectFixText.Name = "chkBitonalDespeckleEffectFixText"
        Me.chkBitonalDespeckleEffectFixText.Size = New System.Drawing.Size(85, 24)
        Me.chkBitonalDespeckleEffectFixText.TabIndex = 0
        Me.chkBitonalDespeckleEffectFixText.Text = "Fix text"
        Me.chkBitonalDespeckleEffectFixText.UseVisualStyleBackColor = true
        '
        'tpBitonalSkeletonize
        '
        Me.tpBitonalSkeletonize.Controls.Add(Me.nBitonalSkeletonizeEffectRepetition)
        Me.tpBitonalSkeletonize.Controls.Add(Me.Label31)
        Me.tpBitonalSkeletonize.Location = New System.Drawing.Point(4, 129)
        Me.tpBitonalSkeletonize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpBitonalSkeletonize.Name = "tpBitonalSkeletonize"
        Me.tpBitonalSkeletonize.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpBitonalSkeletonize.Size = New System.Drawing.Size(381, 461)
        Me.tpBitonalSkeletonize.TabIndex = 9
        Me.tpBitonalSkeletonize.Text = "Bitonal skeletonize"
        Me.tpBitonalSkeletonize.UseVisualStyleBackColor = true
        '
        'nBitonalSkeletonizeEffectRepetition
        '
        Me.nBitonalSkeletonizeEffectRepetition.Location = New System.Drawing.Point(100, 9)
        Me.nBitonalSkeletonizeEffectRepetition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nBitonalSkeletonizeEffectRepetition.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nBitonalSkeletonizeEffectRepetition.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nBitonalSkeletonizeEffectRepetition.Name = "nBitonalSkeletonizeEffectRepetition"
        Me.nBitonalSkeletonizeEffectRepetition.Size = New System.Drawing.Size(98, 26)
        Me.nBitonalSkeletonizeEffectRepetition.TabIndex = 17
        Me.nBitonalSkeletonizeEffectRepetition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = true
        Me.Label31.Location = New System.Drawing.Point(9, 12)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(82, 20)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "Repetition"
        '
        'tpBitonalVigorousDespeckle
        '
        Me.tpBitonalVigorousDespeckle.Controls.Add(Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI)
        Me.tpBitonalVigorousDespeckle.Location = New System.Drawing.Point(4, 129)
        Me.tpBitonalVigorousDespeckle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpBitonalVigorousDespeckle.Name = "tpBitonalVigorousDespeckle"
        Me.tpBitonalVigorousDespeckle.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpBitonalVigorousDespeckle.Size = New System.Drawing.Size(381, 461)
        Me.tpBitonalVigorousDespeckle.TabIndex = 10
        Me.tpBitonalVigorousDespeckle.Text = "Bitonal Vigorous despeckle"
        Me.tpBitonalVigorousDespeckle.UseVisualStyleBackColor = true
        '
        'chkBitonalVigorousDespeckleEffectCheckForDotOfI
        '
        Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI.AutoSize = true
        Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Location = New System.Drawing.Point(9, 9)
        Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Name = "chkBitonalVigorousDespeckleEffectCheckForDotOfI"
        Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Size = New System.Drawing.Size(236, 24)
        Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI.TabIndex = 1
        Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Text = "Detect dots of I and J letters"
        Me.chkBitonalVigorousDespeckleEffectCheckForDotOfI.UseVisualStyleBackColor = true
        '
        'tpBitonalDilate
        '
        Me.tpBitonalDilate.Controls.Add(Me.nBitonalDilateEffectKernelSize)
        Me.tpBitonalDilate.Controls.Add(Me.Label32)
        Me.tpBitonalDilate.Location = New System.Drawing.Point(4, 129)
        Me.tpBitonalDilate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpBitonalDilate.Name = "tpBitonalDilate"
        Me.tpBitonalDilate.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpBitonalDilate.Size = New System.Drawing.Size(381, 461)
        Me.tpBitonalDilate.TabIndex = 11
        Me.tpBitonalDilate.Text = "Bitonal dliate"
        Me.tpBitonalDilate.UseVisualStyleBackColor = true
        '
        'nBitonalDilateEffectKernelSize
        '
        Me.nBitonalDilateEffectKernelSize.Location = New System.Drawing.Point(104, 9)
        Me.nBitonalDilateEffectKernelSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nBitonalDilateEffectKernelSize.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nBitonalDilateEffectKernelSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nBitonalDilateEffectKernelSize.Name = "nBitonalDilateEffectKernelSize"
        Me.nBitonalDilateEffectKernelSize.Size = New System.Drawing.Size(98, 26)
        Me.nBitonalDilateEffectKernelSize.TabIndex = 14
        Me.nBitonalDilateEffectKernelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nBitonalDilateEffectKernelSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label32
        '
        Me.Label32.AutoSize = true
        Me.Label32.Location = New System.Drawing.Point(9, 12)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(86, 20)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Kernel size"
        '
        'tpRemoveHolePunch
        '
        Me.tpRemoveHolePunch.Controls.Add(Me.Label35)
        Me.tpRemoveHolePunch.Controls.Add(Me.cbRemoveHolePunchEffectMargins)
        Me.tpRemoveHolePunch.Location = New System.Drawing.Point(4, 129)
        Me.tpRemoveHolePunch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpRemoveHolePunch.Name = "tpRemoveHolePunch"
        Me.tpRemoveHolePunch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpRemoveHolePunch.Size = New System.Drawing.Size(381, 461)
        Me.tpRemoveHolePunch.TabIndex = 12
        Me.tpRemoveHolePunch.Text = "Remove hole punch"
        Me.tpRemoveHolePunch.UseVisualStyleBackColor = true
        '
        'Label35
        '
        Me.Label35.AutoSize = true
        Me.Label35.Location = New System.Drawing.Point(9, 14)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(65, 20)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "Margins"
        '
        'cbRemoveHolePunchEffectMargins
        '
        Me.cbRemoveHolePunchEffectMargins.FormattingEnabled = true
        Me.cbRemoveHolePunchEffectMargins.Location = New System.Drawing.Point(76, 9)
        Me.cbRemoveHolePunchEffectMargins.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbRemoveHolePunchEffectMargins.Name = "cbRemoveHolePunchEffectMargins"
        Me.cbRemoveHolePunchEffectMargins.Size = New System.Drawing.Size(322, 28)
        Me.cbRemoveHolePunchEffectMargins.TabIndex = 0
        '
        'tpDespeckleAdvanced
        '
        Me.tpDespeckleAdvanced.Controls.Add(Me.Label37)
        Me.tpDespeckleAdvanced.Controls.Add(Me.Label36)
        Me.tpDespeckleAdvanced.Controls.Add(Me.nDespeckleStrength)
        Me.tpDespeckleAdvanced.Controls.Add(Me.cbDespeckleType)
        Me.tpDespeckleAdvanced.Location = New System.Drawing.Point(4, 129)
        Me.tpDespeckleAdvanced.Name = "tpDespeckleAdvanced"
        Me.tpDespeckleAdvanced.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDespeckleAdvanced.Size = New System.Drawing.Size(381, 461)
        Me.tpDespeckleAdvanced.TabIndex = 13
        Me.tpDespeckleAdvanced.Text = "Despeckle"
        Me.tpDespeckleAdvanced.UseVisualStyleBackColor = true
        '
        'Label37
        '
        Me.Label37.AutoSize = true
        Me.Label37.Location = New System.Drawing.Point(6, 29)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(49, 20)
        Me.Label37.TabIndex = 3
        Me.Label37.Text = "Mode"
        '
        'Label36
        '
        Me.Label36.AutoSize = true
        Me.Label36.Location = New System.Drawing.Point(6, 70)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(71, 20)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Strength"
        '
        'nDespeckleStrength
        '
        Me.nDespeckleStrength.Location = New System.Drawing.Point(294, 68)
        Me.nDespeckleStrength.Name = "nDespeckleStrength"
        Me.nDespeckleStrength.Size = New System.Drawing.Size(76, 26)
        Me.nDespeckleStrength.TabIndex = 1
        '
        'cbDespeckleType
        '
        Me.cbDespeckleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDespeckleType.FormattingEnabled = true
        Me.cbDespeckleType.Location = New System.Drawing.Point(81, 26)
        Me.cbDespeckleType.Name = "cbDespeckleType"
        Me.cbDespeckleType.Size = New System.Drawing.Size(289, 28)
        Me.cbDespeckleType.TabIndex = 0
        '
        'pDirectEffects
        '
        Me.pDirectEffects.AutoSize = true
        Me.pDirectEffects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pDirectEffects.Controls.Add(Me.btnMoveEffectDown)
        Me.pDirectEffects.Controls.Add(Me.btnMoveEffectUp)
        Me.pDirectEffects.Controls.Add(Me.btnRemoveAllEffects)
        Me.pDirectEffects.Controls.Add(Me.btnRemoveEffect)
        Me.pDirectEffects.Controls.Add(Me.lstEffects)
        Me.pDirectEffects.Controls.Add(Me.btnAddEffect)
        Me.pDirectEffects.Controls.Add(Me.cbDocumentCleanUpEffects)
        Me.pDirectEffects.Dock = System.Windows.Forms.DockStyle.Top
        Me.pDirectEffects.Location = New System.Drawing.Point(0, 0)
        Me.pDirectEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pDirectEffects.Name = "pDirectEffects"
        Me.pDirectEffects.Size = New System.Drawing.Size(389, 342)
        Me.pDirectEffects.TabIndex = 4
        '
        'btnMoveEffectDown
        '
        Me.btnMoveEffectDown.Location = New System.Drawing.Point(39, 302)
        Me.btnMoveEffectDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMoveEffectDown.Name = "btnMoveEffectDown"
        Me.btnMoveEffectDown.Size = New System.Drawing.Size(84, 35)
        Me.btnMoveEffectDown.TabIndex = 10
        Me.btnMoveEffectDown.Text = "Down"
        Me.btnMoveEffectDown.UseVisualStyleBackColor = true
        '
        'btnMoveEffectUp
        '
        Me.btnMoveEffectUp.Location = New System.Drawing.Point(132, 302)
        Me.btnMoveEffectUp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMoveEffectUp.Name = "btnMoveEffectUp"
        Me.btnMoveEffectUp.Size = New System.Drawing.Size(84, 35)
        Me.btnMoveEffectUp.TabIndex = 9
        Me.btnMoveEffectUp.Text = "Up"
        Me.btnMoveEffectUp.UseVisualStyleBackColor = true
        '
        'btnRemoveAllEffects
        '
        Me.btnRemoveAllEffects.Location = New System.Drawing.Point(346, 302)
        Me.btnRemoveAllEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRemoveAllEffects.Name = "btnRemoveAllEffects"
        Me.btnRemoveAllEffects.Size = New System.Drawing.Size(112, 35)
        Me.btnRemoveAllEffects.TabIndex = 8
        Me.btnRemoveAllEffects.Text = "Remove all"
        Me.btnRemoveAllEffects.UseVisualStyleBackColor = true
        '
        'btnRemoveEffect
        '
        Me.btnRemoveEffect.Location = New System.Drawing.Point(225, 302)
        Me.btnRemoveEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRemoveEffect.Name = "btnRemoveEffect"
        Me.btnRemoveEffect.Size = New System.Drawing.Size(112, 35)
        Me.btnRemoveEffect.TabIndex = 7
        Me.btnRemoveEffect.Text = "Remove"
        Me.btnRemoveEffect.UseVisualStyleBackColor = true
        '
        'lstEffects
        '
        Me.lstEffects.FormattingEnabled = true
        Me.lstEffects.ItemHeight = 20
        Me.lstEffects.Location = New System.Drawing.Point(4, 46)
        Me.lstEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstEffects.Name = "lstEffects"
        Me.lstEffects.Size = New System.Drawing.Size(452, 244)
        Me.lstEffects.TabIndex = 6
        '
        'btnAddEffect
        '
        Me.btnAddEffect.Location = New System.Drawing.Point(346, 3)
        Me.btnAddEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddEffect.Name = "btnAddEffect"
        Me.btnAddEffect.Size = New System.Drawing.Size(112, 35)
        Me.btnAddEffect.TabIndex = 3
        Me.btnAddEffect.Text = "Add to list"
        Me.btnAddEffect.UseVisualStyleBackColor = true
        '
        'cbDocumentCleanUpEffects
        '
        Me.cbDocumentCleanUpEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumentCleanUpEffects.FormattingEnabled = true
        Me.cbDocumentCleanUpEffects.Location = New System.Drawing.Point(4, 5)
        Me.cbDocumentCleanUpEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbDocumentCleanUpEffects.Name = "cbDocumentCleanUpEffects"
        Me.cbDocumentCleanUpEffects.Size = New System.Drawing.Size(332, 28)
        Me.cbDocumentCleanUpEffects.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoSize = true
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.btnApplyEffects)
        Me.Panel1.Controls.Add(Me.btnResetEffects)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 936)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 45)
        Me.Panel1.TabIndex = 5
        '
        'btnApplyEffects
        '
        Me.btnApplyEffects.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnApplyEffects.Location = New System.Drawing.Point(272, 5)
        Me.btnApplyEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApplyEffects.Name = "btnApplyEffects"
        Me.btnApplyEffects.Size = New System.Drawing.Size(112, 35)
        Me.btnApplyEffects.TabIndex = 0
        Me.btnApplyEffects.Text = "Apply"
        Me.btnApplyEffects.UseVisualStyleBackColor = true
        '
        'btnResetEffects
        '
        Me.btnResetEffects.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnResetEffects.Location = New System.Drawing.Point(151, 5)
        Me.btnResetEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnResetEffects.Name = "btnResetEffects"
        Me.btnResetEffects.Size = New System.Drawing.Size(112, 35)
        Me.btnResetEffects.TabIndex = 1
        Me.btnResetEffects.Text = "Reset"
        Me.btnResetEffects.UseVisualStyleBackColor = true
        '
        'scMain
        '
        Me.scMain.BackColor = System.Drawing.SystemColors.Control
        Me.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.scMain.Name = "scMain"
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.scMain.Panel1.Controls.Add(Me.Panel6)
        Me.scMain.Panel1MinSize = 256
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.SplitContainer1)
        Me.scMain.Panel2MinSize = 200
        Me.scMain.Size = New System.Drawing.Size(1896, 1065)
        Me.scMain.SplitterDistance = 447
        Me.scMain.SplitterWidth = 6
        Me.scMain.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.pSnapInButtons)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(445, 1063)
        Me.Panel6.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Controls.Add(Me.tcLeftPanel)
        Me.Panel9.Controls.Add(Me.Panel7)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(48, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(397, 1063)
        Me.Panel9.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.lblSnapInPanel)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(397, 49)
        Me.Panel7.TabIndex = 6
        '
        'lblSnapInPanel
        '
        Me.lblSnapInPanel.AutoSize = true
        Me.lblSnapInPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSnapInPanel.Location = New System.Drawing.Point(9, 12)
        Me.lblSnapInPanel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSnapInPanel.Name = "lblSnapInPanel"
        Me.lblSnapInPanel.Size = New System.Drawing.Size(113, 22)
        Me.lblSnapInPanel.TabIndex = 0
        Me.lblSnapInPanel.Text = "Thumbnails"
        '
        'pSnapInButtons
        '
        Me.pSnapInButtons.AutoSize = true
        Me.pSnapInButtons.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInThumbnails)
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInDocumentCleanUp)
        Me.pSnapInButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.pSnapInButtons.Location = New System.Drawing.Point(0, 0)
        Me.pSnapInButtons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pSnapInButtons.Name = "pSnapInButtons"
        Me.pSnapInButtons.Size = New System.Drawing.Size(48, 1063)
        Me.pSnapInButtons.TabIndex = 4
        '
        'btnSnapInThumbnails
        '
        Me.btnSnapInThumbnails.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInThumbnails.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSnapInThumbnails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInThumbnails.Image = CType(resources.GetObject("btnSnapInThumbnails.Image"),System.Drawing.Image)
        Me.btnSnapInThumbnails.Location = New System.Drawing.Point(0, 0)
        Me.btnSnapInThumbnails.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInThumbnails.Name = "btnSnapInThumbnails"
        Me.btnSnapInThumbnails.Size = New System.Drawing.Size(48, 49)
        Me.btnSnapInThumbnails.TabIndex = 0
        Me.btnSnapInThumbnails.UseVisualStyleBackColor = false
        '
        'btnSnapInDocumentCleanUp
        '
        Me.btnSnapInDocumentCleanUp.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInDocumentCleanUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.btnSnapInDocumentCleanUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInDocumentCleanUp.Image = CType(resources.GetObject("btnSnapInDocumentCleanUp.Image"),System.Drawing.Image)
        Me.btnSnapInDocumentCleanUp.Location = New System.Drawing.Point(0, 48)
        Me.btnSnapInDocumentCleanUp.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInDocumentCleanUp.Name = "btnSnapInDocumentCleanUp"
        Me.btnSnapInDocumentCleanUp.Size = New System.Drawing.Size(48, 49)
        Me.btnSnapInDocumentCleanUp.TabIndex = 1
        Me.btnSnapInDocumentCleanUp.UseVisualStyleBackColor = false
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = true
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1441, 1063)
        Me.SplitContainer1.SplitterDistance = 755
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GdViewer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 1014)
        Me.Panel2.TabIndex = 1
        '
        'GdViewer1
        '
        Me.GdViewer1.AllowDropFile = false
        Me.GdViewer1.AnimateGIF = true
        Me.GdViewer1.AnnotationDropShadow = true
        Me.GdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.GdViewer1.AnnotationResizeRotateHandlesScale = 1!
        Me.GdViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.GdViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.GdViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GdViewer1.BackgroundImage = Nothing
        Me.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GdViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GdViewer1.ContinuousViewMode = false
        Me.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityAutomatic
        Me.GdViewer1.DisplayQualityAuto = true
        Me.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.GdViewer1.EnableDeferredPainting = true
        Me.GdViewer1.EnabledProgressBar = true
        Me.GdViewer1.EnableICM = false
        Me.GdViewer1.EnableMenu = true
        Me.GdViewer1.EnableMouseWheel = true
        Me.GdViewer1.EnableTextSelection = true
        Me.GdViewer1.ForceScrollBars = false
        Me.GdViewer1.ForceTemporaryMode = false
        Me.GdViewer1.ForeColor = System.Drawing.Color.Black
        Me.GdViewer1.Gamma = 1!
        Me.GdViewer1.HQAnnotationRendering = true
        Me.GdViewer1.IgnoreDocumentResolution = false
        Me.GdViewer1.KeepDocumentPosition = false
        Me.GdViewer1.Location = New System.Drawing.Point(0, 0)
        Me.GdViewer1.LockViewer = false
        Me.GdViewer1.MagnifierHeight = 90
        Me.GdViewer1.MagnifierWidth = 160
        Me.GdViewer1.MagnifierZoomX = 2!
        Me.GdViewer1.MagnifierZoomY = 2!
        Me.GdViewer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
        Me.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom
        Me.GdViewer1.Name = "GdViewer1"
        Me.GdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView
        Me.GdViewer1.PdfDisplayFormField = true
        Me.GdViewer1.PdfEnableFileLinks = true
        Me.GdViewer1.PdfEnableLinks = true
        Me.GdViewer1.PdfIncreaseTextContrast = false
        Me.GdViewer1.PdfShowDialogForPassword = true
        Me.GdViewer1.PdfShowOpenFileDialogForDecryption = true
        Me.GdViewer1.PdfVerifyDigitalCertificates = false
        Me.GdViewer1.RectBorderColor = System.Drawing.Color.Black
        Me.GdViewer1.RectBorderSize = 1
        Me.GdViewer1.RectIsEditable = true
        Me.GdViewer1.RegionsAreEditable = true
        Me.GdViewer1.RenderGdPictureAnnots = true
        Me.GdViewer1.ScrollBars = true
        Me.GdViewer1.ScrollLargeChange = CType(50,Short)
        Me.GdViewer1.ScrollSmallChange = CType(1,Short)
        Me.GdViewer1.SilentMode = true
        Me.GdViewer1.Size = New System.Drawing.Size(755, 1014)
        Me.GdViewer1.TabIndex = 0
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 0.001R
        Me.GdViewer1.ZoomCenterAtMousePosition = false
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer1.ZoomStep = 25
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(755, 49)
        Me.Panel3.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label33.Location = New System.Drawing.Point(0, 0)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(755, 49)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "BEFORE"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GdViewerPreview)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 49)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(680, 1014)
        Me.Panel5.TabIndex = 3
        '
        'GdViewerPreview
        '
        Me.GdViewerPreview.AllowDropFile = false
        Me.GdViewerPreview.AnimateGIF = true
        Me.GdViewerPreview.AnnotationDropShadow = true
        Me.GdViewerPreview.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.GdViewerPreview.AnnotationResizeRotateHandlesScale = 1!
        Me.GdViewerPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.GdViewerPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.GdViewerPreview.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GdViewerPreview.BackgroundImage = Nothing
        Me.GdViewerPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GdViewerPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GdViewerPreview.ContinuousViewMode = false
        Me.GdViewerPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdViewerPreview.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityAutomatic
        Me.GdViewerPreview.DisplayQualityAuto = true
        Me.GdViewerPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GdViewerPreview.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.GdViewerPreview.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.GdViewerPreview.EnableDeferredPainting = true
        Me.GdViewerPreview.EnabledProgressBar = true
        Me.GdViewerPreview.EnableICM = false
        Me.GdViewerPreview.EnableMenu = false
        Me.GdViewerPreview.EnableMouseWheel = true
        Me.GdViewerPreview.EnableTextSelection = true
        Me.GdViewerPreview.ForceScrollBars = false
        Me.GdViewerPreview.ForceTemporaryMode = false
        Me.GdViewerPreview.ForeColor = System.Drawing.Color.Black
        Me.GdViewerPreview.Gamma = 1!
        Me.GdViewerPreview.HQAnnotationRendering = true
        Me.GdViewerPreview.IgnoreDocumentResolution = false
        Me.GdViewerPreview.KeepDocumentPosition = false
        Me.GdViewerPreview.Location = New System.Drawing.Point(0, 0)
        Me.GdViewerPreview.LockViewer = false
        Me.GdViewerPreview.MagnifierHeight = 90
        Me.GdViewerPreview.MagnifierWidth = 160
        Me.GdViewerPreview.MagnifierZoomX = 2!
        Me.GdViewerPreview.MagnifierZoomY = 2!
        Me.GdViewerPreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GdViewerPreview.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.GdViewerPreview.MouseMode = GdPicture14.ViewerMouseMode.MouseModeDefault
        Me.GdViewerPreview.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeDisabled
        Me.GdViewerPreview.Name = "GdViewerPreview"
        Me.GdViewerPreview.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView
        Me.GdViewerPreview.PdfDisplayFormField = true
        Me.GdViewerPreview.PdfEnableFileLinks = true
        Me.GdViewerPreview.PdfEnableLinks = true
        Me.GdViewerPreview.PdfIncreaseTextContrast = false
        Me.GdViewerPreview.PdfShowDialogForPassword = true
        Me.GdViewerPreview.PdfShowOpenFileDialogForDecryption = true
        Me.GdViewerPreview.PdfVerifyDigitalCertificates = false
        Me.GdViewerPreview.RectBorderColor = System.Drawing.Color.Black
        Me.GdViewerPreview.RectBorderSize = 1
        Me.GdViewerPreview.RectIsEditable = true
        Me.GdViewerPreview.RegionsAreEditable = true
        Me.GdViewerPreview.RenderGdPictureAnnots = true
        Me.GdViewerPreview.ScrollBars = true
        Me.GdViewerPreview.ScrollLargeChange = CType(50,Short)
        Me.GdViewerPreview.ScrollSmallChange = CType(1,Short)
        Me.GdViewerPreview.SilentMode = true
        Me.GdViewerPreview.Size = New System.Drawing.Size(680, 1014)
        Me.GdViewerPreview.TabIndex = 1
        Me.GdViewerPreview.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewerPreview.Zoom = 0.001R
        Me.GdViewerPreview.ZoomCenterAtMousePosition = false
        Me.GdViewerPreview.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewerPreview.ZoomStep = 25
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label34)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(680, 49)
        Me.Panel4.TabIndex = 2
        '
        'Label34
        '
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label34.Location = New System.Drawing.Point(0, 0)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(680, 49)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "AFTER"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'statusbar
        '
        Me.statusbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.statusbar.Location = New System.Drawing.Point(0, 1100)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.statusbar.Size = New System.Drawing.Size(1896, 22)
        Me.statusbar.TabIndex = 3
        Me.statusbar.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'pMain
        '
        Me.pMain.Controls.Add(Me.scMain)
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(0, 35)
        Me.pMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(1896, 1065)
        Me.pMain.TabIndex = 6
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"),System.Drawing.Image)
        Me.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(182, 32)
        Me.btnOpen.Text = "Open document"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Margin = New System.Windows.Forms.Padding(5, 0, 10, 0)
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 35)
        '
        'btnClose
        '
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"),System.Drawing.Image)
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 32)
        Me.btnClose.Text = "Close document"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"),System.Drawing.Image)
        Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(28, 32)
        Me.btnPrint.Text = "Print document"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 35)
        '
        'btnSettings
        '
        Me.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"),System.Drawing.Image)
        Me.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(28, 32)
        Me.btnSettings.Text = "Viewer settings"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 35)
        '
        'btnMouseMode
        '
        Me.btnMouseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMouseMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.AreaSelectionToolStripMenuItem, Me.PanToolStripMenuItem, Me.AreaZoomingToolStripMenuItem, Me.MagnifierToolStripMenuItem})
        Me.btnMouseMode.Image = CType(resources.GetObject("btnMouseMode.Image"),System.Drawing.Image)
        Me.btnMouseMode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMouseMode.Name = "btnMouseMode"
        Me.btnMouseMode.Size = New System.Drawing.Size(42, 32)
        Me.btnMouseMode.Text = "Mouse mode"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.CheckOnClick = true
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(208, 30)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'AreaSelectionToolStripMenuItem
        '
        Me.AreaSelectionToolStripMenuItem.CheckOnClick = true
        Me.AreaSelectionToolStripMenuItem.Name = "AreaSelectionToolStripMenuItem"
        Me.AreaSelectionToolStripMenuItem.Size = New System.Drawing.Size(208, 30)
        Me.AreaSelectionToolStripMenuItem.Text = "Area selection"
        '
        'PanToolStripMenuItem
        '
        Me.PanToolStripMenuItem.Checked = true
        Me.PanToolStripMenuItem.CheckOnClick = true
        Me.PanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PanToolStripMenuItem.Name = "PanToolStripMenuItem"
        Me.PanToolStripMenuItem.Size = New System.Drawing.Size(208, 30)
        Me.PanToolStripMenuItem.Text = "Pan"
        '
        'AreaZoomingToolStripMenuItem
        '
        Me.AreaZoomingToolStripMenuItem.CheckOnClick = true
        Me.AreaZoomingToolStripMenuItem.Name = "AreaZoomingToolStripMenuItem"
        Me.AreaZoomingToolStripMenuItem.Size = New System.Drawing.Size(208, 30)
        Me.AreaZoomingToolStripMenuItem.Text = "Area zooming"
        '
        'MagnifierToolStripMenuItem
        '
        Me.MagnifierToolStripMenuItem.CheckOnClick = true
        Me.MagnifierToolStripMenuItem.Name = "MagnifierToolStripMenuItem"
        Me.MagnifierToolStripMenuItem.Size = New System.Drawing.Size(208, 30)
        Me.MagnifierToolStripMenuItem.Text = "Magnifier"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Margin = New System.Windows.Forms.Padding(5, 0, 10, 0)
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 35)
        '
        'btnFirstPage
        '
        Me.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFirstPage.Image = CType(resources.GetObject("btnFirstPage.Image"),System.Drawing.Image)
        Me.btnFirstPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(28, 32)
        Me.btnFirstPage.Text = "Go to first page"
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPreviousPage.Image = CType(resources.GetObject("btnPreviousPage.Image"),System.Drawing.Image)
        Me.btnPreviousPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(28, 32)
        Me.btnPreviousPage.Text = "Go to previous page"
        '
        'tbCurrentPage
        '
        Me.tbCurrentPage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbCurrentPage.Name = "tbCurrentPage"
        Me.tbCurrentPage.Size = New System.Drawing.Size(58, 35)
        Me.tbCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPageCount
        '
        Me.lblPageCount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPageCount.Name = "lblPageCount"
        Me.lblPageCount.Size = New System.Drawing.Size(37, 32)
        Me.lblPageCount.Text = "/ X"
        '
        'btnNextPage
        '
        Me.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNextPage.Image = CType(resources.GetObject("btnNextPage.Image"),System.Drawing.Image)
        Me.btnNextPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(28, 32)
        Me.btnNextPage.Text = "Go to next page"
        '
        'btnLastPage
        '
        Me.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLastPage.Image = CType(resources.GetObject("btnLastPage.Image"),System.Drawing.Image)
        Me.btnLastPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(28, 32)
        Me.btnLastPage.Text = "Go to last page"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'btnZoomOut
        '
        Me.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomOut.Image = CType(resources.GetObject("btnZoomOut.Image"),System.Drawing.Image)
        Me.btnZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(28, 32)
        Me.btnZoomOut.Text = "Zoom out"
        '
        'cbZoom
        '
        Me.cbZoom.DropDownWidth = 200
        Me.cbZoom.Name = "cbZoom"
        Me.cbZoom.Size = New System.Drawing.Size(110, 35)
        '
        'btnZoomIn
        '
        Me.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomIn.Image = CType(resources.GetObject("btnZoomIn.Image"),System.Drawing.Image)
        Me.btnZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(28, 32)
        Me.btnZoomIn.Text = "Zoom In"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 35)
        '
        'btnFitWidth
        '
        Me.btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFitWidth.Image = CType(resources.GetObject("btnFitWidth.Image"),System.Drawing.Image)
        Me.btnFitWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFitWidth.Name = "btnFitWidth"
        Me.btnFitWidth.Size = New System.Drawing.Size(28, 32)
        Me.btnFitWidth.Text = "Adjust to page width"
        '
        'btnFitPage
        '
        Me.btnFitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFitPage.Image = CType(resources.GetObject("btnFitPage.Image"),System.Drawing.Image)
        Me.btnFitPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFitPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFitPage.Name = "btnFitPage"
        Me.btnFitPage.Size = New System.Drawing.Size(28, 32)
        Me.btnFitPage.Text = "Adjust to whole page"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 35)
        '
        'btnRotateLeft
        '
        Me.btnRotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRotateLeft.Image = CType(resources.GetObject("btnRotateLeft.Image"),System.Drawing.Image)
        Me.btnRotateLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRotateLeft.Name = "btnRotateLeft"
        Me.btnRotateLeft.Size = New System.Drawing.Size(28, 32)
        Me.btnRotateLeft.Text = "Rotate left"
        '
        'btnRotateRight
        '
        Me.btnRotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRotateRight.Image = CType(resources.GetObject("btnRotateRight.Image"),System.Drawing.Image)
        Me.btnRotateRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRotateRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRotateRight.Name = "btnRotateRight"
        Me.btnRotateRight.Size = New System.Drawing.Size(28, 32)
        Me.btnRotateRight.Text = "Rotate right"
        '
        'btnFlipX
        '
        Me.btnFlipX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFlipX.Image = CType(resources.GetObject("btnFlipX.Image"),System.Drawing.Image)
        Me.btnFlipX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFlipX.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFlipX.Name = "btnFlipX"
        Me.btnFlipX.Size = New System.Drawing.Size(28, 32)
        Me.btnFlipX.Text = "Vertical flip"
        '
        'btnFlipY
        '
        Me.btnFlipY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFlipY.Image = CType(resources.GetObject("btnFlipY.Image"),System.Drawing.Image)
        Me.btnFlipY.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFlipY.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFlipY.Name = "btnFlipY"
        Me.btnFlipY.Size = New System.Drawing.Size(28, 32)
        Me.btnFlipY.Text = "Horizontal flip"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 35)
        '
        'btnAbout
        '
        Me.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"),System.Drawing.Image)
        Me.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(28, 32)
        Me.btnAbout.Text = "About"
        '
        'mainToolStrip
        '
        Me.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.ToolStripSeparator9, Me.btnClose, Me.btnPrint, Me.btnSave, Me.ToolStripSeparator3, Me.btnCopyToClipboard, Me.btnImportFromClipboard, Me.ToolStripSeparator7, Me.btnSettings, Me.ToolStripSeparator8, Me.btnMouseMode, Me.ToolStripSeparator6, Me.btnFirstPage, Me.btnPreviousPage, Me.tbCurrentPage, Me.lblPageCount, Me.btnNextPage, Me.btnLastPage, Me.ToolStripSeparator1, Me.btnZoomOut, Me.cbZoom, Me.btnZoomIn, Me.ToolStripSeparator2, Me.btnFitWidth, Me.btnFitPage, Me.ToolStripSeparator5, Me.btnRotateLeft, Me.btnRotateRight, Me.btnFlipX, Me.btnFlipY, Me.ToolStripSeparator4, Me.btnAbout})
        Me.mainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainToolStrip.Name = "mainToolStrip"
        Me.mainToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.mainToolStrip.Size = New System.Drawing.Size(1896, 35)
        Me.mainToolStrip.TabIndex = 5
        Me.mainToolStrip.Text = "ToolStrip1"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"),System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(28, 32)
        Me.btnSave.Text = "Save"
        '
        'btnCopyToClipboard
        '
        Me.btnCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopyToClipboard.Image = CType(resources.GetObject("btnCopyToClipboard.Image"),System.Drawing.Image)
        Me.btnCopyToClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopyToClipboard.Name = "btnCopyToClipboard"
        Me.btnCopyToClipboard.Size = New System.Drawing.Size(28, 32)
        Me.btnCopyToClipboard.Text = "Copy to clipboard"
        '
        'btnImportFromClipboard
        '
        Me.btnImportFromClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImportFromClipboard.Image = CType(resources.GetObject("btnImportFromClipboard.Image"),System.Drawing.Image)
        Me.btnImportFromClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnImportFromClipboard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImportFromClipboard.Name = "btnImportFromClipboard"
        Me.btnImportFromClipboard.Size = New System.Drawing.Size(28, 32)
        Me.btnImportFromClipboard.Text = "Import from clipboard"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 35)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1896, 1122)
        Me.Controls.Add(Me.pMain)
        Me.Controls.Add(Me.mainToolStrip)
        Me.Controls.Add(Me.statusbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GdPicture .NET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tcLeftPanel.ResumeLayout(false)
        Me.tpThumbnails.ResumeLayout(false)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(false)
        Me.ToolStripContainer1.ResumeLayout(false)
        Me.ToolStripContainer1.PerformLayout
        Me.thumbnailPanelToolstrip.ResumeLayout(false)
        Me.thumbnailPanelToolstrip.PerformLayout
        Me.tpDocumentCleanUp.ResumeLayout(false)
        Me.pDocumentCleanUp.ResumeLayout(false)
        Me.pDocumentCleanUp.PerformLayout
        Me.tbEffectsParameters.ResumeLayout(false)
        Me.tpAutoDeskewParameters.ResumeLayout(false)
        Me.tpAutoDeskewParameters.PerformLayout
        CType(Me.nAutoDeskewAngleStep,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pAutoDeskewBackColor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nAutoDeskewMaxAngleOfResearch,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpAutoTextInvert.ResumeLayout(false)
        Me.tpAutoTextInvert.PerformLayout
        CType(Me.nAutoInvertTextMaxLinesThickness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nAutoInvertTextMaxBlackPercent,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nAutoInvertTextMinBlackPercent,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nAutoInvertTextMinObjectHeight,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nAutoInvertTextMinObjectWidth,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpCropBlackBorders.ResumeLayout(false)
        Me.tpCropBlackBorders.PerformLayout
        CType(Me.nCropBlackBordersSkipLinesCount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nCropBlackBordersConfidence,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpCropBorders.ResumeLayout(false)
        Me.tpCropBorders.PerformLayout
        CType(Me.nCropBordersHeight,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nCropBordersWidth,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nCropBordersTop,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nCropBordersLeft,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nCropBordersConfidence,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpDeleteBlackBorders.ResumeLayout(false)
        Me.tpDeleteBlackBorders.PerformLayout
        CType(Me.nDeleteBlackBorderEffectMargin,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpMedian.ResumeLayout(false)
        Me.tpMedian.PerformLayout
        CType(Me.nMedianEffectKernelSize,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpRemoveBlob.ResumeLayout(false)
        Me.tpRemoveBlob.PerformLayout
        CType(Me.nRemoveBlobEffectMaxFillPercent,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nRemoveBlobEffectMinFillPercent,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nRemoveBlobEffectMaxBlobHeight,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nRemoveBlobEffectMaxBlobWidth,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nRemoveBlobEffectMinBlobHeight,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nRemoveBlobEffectMinBlobWidth,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpRemoveLines.ResumeLayout(false)
        Me.tpRemoveLines.PerformLayout
        CType(Me.nRemoveLinesEffectMaxInterception,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nRemoveLinesEffectMinLineLength,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nRemoveLinesEffectMaxLineThickness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nRemoveLinesEffectMaxLineGap,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpBitonalDespeckle.ResumeLayout(false)
        Me.tpBitonalDespeckle.PerformLayout
        Me.tpBitonalSkeletonize.ResumeLayout(false)
        Me.tpBitonalSkeletonize.PerformLayout
        CType(Me.nBitonalSkeletonizeEffectRepetition,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpBitonalVigorousDespeckle.ResumeLayout(false)
        Me.tpBitonalVigorousDespeckle.PerformLayout
        Me.tpBitonalDilate.ResumeLayout(false)
        Me.tpBitonalDilate.PerformLayout
        CType(Me.nBitonalDilateEffectKernelSize,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpRemoveHolePunch.ResumeLayout(false)
        Me.tpRemoveHolePunch.PerformLayout
        Me.tpDespeckleAdvanced.ResumeLayout(false)
        Me.tpDespeckleAdvanced.PerformLayout
        CType(Me.nDespeckleStrength,System.ComponentModel.ISupportInitialize).EndInit
        Me.pDirectEffects.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.scMain.Panel1.ResumeLayout(false)
        Me.scMain.Panel2.ResumeLayout(false)
        CType(Me.scMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.scMain.ResumeLayout(false)
        Me.Panel6.ResumeLayout(false)
        Me.Panel6.PerformLayout
        Me.Panel9.ResumeLayout(false)
        Me.Panel7.ResumeLayout(false)
        Me.Panel7.PerformLayout
        Me.pSnapInButtons.ResumeLayout(false)
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel5.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        Me.statusbar.ResumeLayout(false)
        Me.statusbar.PerformLayout
        Me.pMain.ResumeLayout(false)
        Me.mainToolStrip.ResumeLayout(false)
        Me.mainToolStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ThumbnailEx1 As GdPicture14.ThumbnailEx
    Friend WithEvents tcLeftPanel As System.Windows.Forms.TabControl
    Friend WithEvents tpThumbnails As System.Windows.Forms.TabPage
    Friend WithEvents tpDocumentCleanUp As System.Windows.Forms.TabPage
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents GdViewer1 As GdPicture14.GdViewer
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
    Friend WithEvents pMain As System.Windows.Forms.Panel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pDocumentCleanUp As System.Windows.Forms.Panel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents thumbnailPanelToolstrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnSnapInThumbnails As System.Windows.Forms.Button
    Friend WithEvents btnSnapInDocumentCleanUp As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents pSnapInButtons As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblSnapInPanel As System.Windows.Forms.Label
    Friend WithEvents btnThumbSize As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LargeThumbnailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumThumbnailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallThumbnailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pDirectEffects As System.Windows.Forms.Panel
    Friend WithEvents cbDocumentCleanUpEffects As System.Windows.Forms.ComboBox
    Friend WithEvents btnResetEffects As System.Windows.Forms.Button
    Friend WithEvents btnApplyEffects As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnMouseMode As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaZoomingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagnifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFirstPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPreviousPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbCurrentPage As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblPageCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnNextPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLastPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnZoomOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbZoom As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnZoomIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFitWidth As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFitPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRotateLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRotateRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFlipX As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFlipY As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents mainToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAddEffect As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAllEffects As System.Windows.Forms.Button
    Friend WithEvents btnRemoveEffect As System.Windows.Forms.Button
    Friend WithEvents lstEffects As System.Windows.Forms.ListBox
    Friend WithEvents tbEffectsParameters As System.Windows.Forms.TabControl
    Friend WithEvents tpAutoDeskewParameters As System.Windows.Forms.TabPage
    Friend WithEvents tpAutoTextInvert As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GdViewerPreview As GdPicture14.GdViewer
    Friend WithEvents nAutoDeskewMaxAngleOfResearch As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pAutoDeskewBackColor As System.Windows.Forms.PictureBox
    Friend WithEvents nAutoDeskewAngleStep As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkAutoDeskewOptimistic As System.Windows.Forms.CheckBox
    Friend WithEvents nAutoInvertTextMinObjectHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nAutoInvertTextMinObjectWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nAutoInvertTextMaxBlackPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nAutoInvertTextMinBlackPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkAutoTextInvertFixBackground As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutoTextInvertConnectedToLines As System.Windows.Forms.CheckBox
    Friend WithEvents nAutoInvertTextMaxLinesThickness As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tpCropBlackBorders As System.Windows.Forms.TabPage
    Friend WithEvents nCropBlackBordersConfidence As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nCropBlackBordersSkipLinesCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tpCropBorders As System.Windows.Forms.TabPage
    Friend WithEvents nCropBordersConfidence As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbCropBordersReferencePoint As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents nCropBordersHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents nCropBordersWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents nCropBordersTop As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents nCropBordersLeft As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbCropBordersImageContext As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tpDeleteBlackBorders As System.Windows.Forms.TabPage
    Friend WithEvents nDeleteBlackBorderEffectMargin As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkDeleteBlackBordersEffectSkewedBorders As System.Windows.Forms.CheckBox
    Friend WithEvents tpMedian As System.Windows.Forms.TabPage
    Friend WithEvents nMedianEffectKernelSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tpRemoveBlob As System.Windows.Forms.TabPage
    Friend WithEvents nRemoveBlobEffectMaxFillPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents nRemoveBlobEffectMinFillPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents nRemoveBlobEffectMaxBlobHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents nRemoveBlobEffectMaxBlobWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents nRemoveBlobEffectMinBlobHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents nRemoveBlobEffectMinBlobWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tpRemoveLines As System.Windows.Forms.TabPage
    Friend WithEvents cbRemoveLinesEffectOrientation As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents nRemoveLinesEffectMaxLineGap As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents nRemoveLinesEffectMaxLineThickness As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents nRemoveLinesEffectMinLineLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents nRemoveLinesEffectMaxInterception As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents chkRemoveLinesEffectReconnectBrokenCharacters As System.Windows.Forms.CheckBox
    Friend WithEvents tpBitonalDespeckle As System.Windows.Forms.TabPage
    Friend WithEvents chkBitonalDespeckleEffectFixText As System.Windows.Forms.CheckBox
    Friend WithEvents tpBitonalSkeletonize As System.Windows.Forms.TabPage
    Friend WithEvents nBitonalSkeletonizeEffectRepetition As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents tpBitonalVigorousDespeckle As System.Windows.Forms.TabPage
    Friend WithEvents chkBitonalVigorousDespeckleEffectCheckForDotOfI As System.Windows.Forms.CheckBox
    Friend WithEvents tpBitonalDilate As System.Windows.Forms.TabPage
    Friend WithEvents nBitonalDilateEffectKernelSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tpRemoveHolePunch As System.Windows.Forms.TabPage
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cbRemoveHolePunchEffectMargins As System.Windows.Forms.ComboBox
    Friend WithEvents btnMoveEffectUp As System.Windows.Forms.Button
    Friend WithEvents btnMoveEffectDown As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopyToClipboard As ToolStripButton
    Friend WithEvents btnImportFromClipboard As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tpDespeckleAdvanced As TabPage
    Friend WithEvents nDespeckleStrength As NumericUpDown
    Friend WithEvents cbDespeckleType As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label38 As Label
End Class
