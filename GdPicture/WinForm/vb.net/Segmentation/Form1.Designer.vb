<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ignoreResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.blocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.paragraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.textLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.wordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.charactersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.chkShowBitmap = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkShowText = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkShowLines = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotateRight90ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotateLeft90ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotate180ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imageEnhancementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.automaticCleanupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.removePunchHolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eraseBlackBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.deskewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bitonalDespeckleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.medianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.scaleTo300DPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.scaleTo200ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.thresholdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sauvolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.otsuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bradleyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegmentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.readToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsImageInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gdViewer1 = New GdPicture14.GdViewer()
        Me.menuStrip1.SuspendLayout
        Me.statusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'menuStrip1
        '
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.viewToolStripMenuItem, Me.rotateToolStripMenuItem, Me.imageEnhancementToolStripMenuItem, Me.SegmentationToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.menuStrip1.Size = New System.Drawing.Size(822, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.closeToolStripMenuItem, Me.toolStripSeparator3, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.openToolStripMenuItem.Text = "&Open..."
        '
        'closeToolStripMenuItem
        '
        Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
        Me.closeToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.closeToolStripMenuItem.Text = "&Close"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(109, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'viewToolStripMenuItem
        '
        Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.zoomInToolStripMenuItem, Me.zoomOutToolStripMenuItem, Me.toolStripMenuItem2, Me.ignoreResolutionToolStripMenuItem, Me.toolStripSeparator1, Me.blocksToolStripMenuItem, Me.paragraphsToolStripMenuItem, Me.textLinesToolStripMenuItem, Me.wordsToolStripMenuItem, Me.charactersToolStripMenuItem, Me.toolStripMenuItem3, Me.chkShowBitmap, Me.chkShowText, Me.chkShowLines})
        Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
        Me.viewToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.viewToolStripMenuItem.Text = "&View"
        '
        'zoomInToolStripMenuItem
        '
        Me.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem"
        Me.zoomInToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.zoomInToolStripMenuItem.Text = "Zoom &in"
        '
        'zoomOutToolStripMenuItem
        '
        Me.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem"
        Me.zoomOutToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.zoomOutToolStripMenuItem.Text = "Zoom &out"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(203, 22)
        Me.toolStripMenuItem2.Text = "&100%"
        '
        'ignoreResolutionToolStripMenuItem
        '
        Me.ignoreResolutionToolStripMenuItem.Name = "ignoreResolutionToolStripMenuItem"
        Me.ignoreResolutionToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ignoreResolutionToolStripMenuItem.Text = "100% (ignore resolution)"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'blocksToolStripMenuItem
        '
        Me.blocksToolStripMenuItem.Checked = true
        Me.blocksToolStripMenuItem.CheckOnClick = true
        Me.blocksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.blocksToolStripMenuItem.Name = "blocksToolStripMenuItem"
        Me.blocksToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.blocksToolStripMenuItem.Text = "&Blocks"
        '
        'paragraphsToolStripMenuItem
        '
        Me.paragraphsToolStripMenuItem.Checked = true
        Me.paragraphsToolStripMenuItem.CheckOnClick = true
        Me.paragraphsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.paragraphsToolStripMenuItem.Name = "paragraphsToolStripMenuItem"
        Me.paragraphsToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.paragraphsToolStripMenuItem.Text = "&Paragraphs"
        '
        'textLinesToolStripMenuItem
        '
        Me.textLinesToolStripMenuItem.Checked = true
        Me.textLinesToolStripMenuItem.CheckOnClick = true
        Me.textLinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.textLinesToolStripMenuItem.Name = "textLinesToolStripMenuItem"
        Me.textLinesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.textLinesToolStripMenuItem.Text = "Text &lines"
        '
        'wordsToolStripMenuItem
        '
        Me.wordsToolStripMenuItem.Checked = true
        Me.wordsToolStripMenuItem.CheckOnClick = true
        Me.wordsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem"
        Me.wordsToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.wordsToolStripMenuItem.Text = "&Words"
        '
        'charactersToolStripMenuItem
        '
        Me.charactersToolStripMenuItem.Checked = true
        Me.charactersToolStripMenuItem.CheckOnClick = true
        Me.charactersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem"
        Me.charactersToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.charactersToolStripMenuItem.Text = "&Characters"
        '
        'toolStripMenuItem3
        '
        Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
        Me.toolStripMenuItem3.Size = New System.Drawing.Size(200, 6)
        '
        'chkShowBitmap
        '
        Me.chkShowBitmap.Checked = true
        Me.chkShowBitmap.CheckOnClick = true
        Me.chkShowBitmap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowBitmap.Name = "chkShowBitmap"
        Me.chkShowBitmap.Size = New System.Drawing.Size(203, 22)
        Me.chkShowBitmap.Text = "Bitmap"
        '
        'chkShowText
        '
        Me.chkShowText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkShowText.Checked = true
        Me.chkShowText.CheckOnClick = true
        Me.chkShowText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowText.Name = "chkShowText"
        Me.chkShowText.Size = New System.Drawing.Size(203, 22)
        Me.chkShowText.Text = "Text"
        '
        'chkShowLines
        '
        Me.chkShowLines.Checked = true
        Me.chkShowLines.CheckOnClick = true
        Me.chkShowLines.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowLines.Name = "chkShowLines"
        Me.chkShowLines.Size = New System.Drawing.Size(203, 22)
        Me.chkShowLines.Text = "Lines"
        '
        'rotateToolStripMenuItem
        '
        Me.rotateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rotateRight90ToolStripMenuItem, Me.rotateLeft90ToolStripMenuItem, Me.rotate180ToolStripMenuItem})
        Me.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem"
        Me.rotateToolStripMenuItem.Size = New System.Drawing.Size(53, 22)
        Me.rotateToolStripMenuItem.Text = "&Rotate"
        '
        'rotateRight90ToolStripMenuItem
        '
        Me.rotateRight90ToolStripMenuItem.Name = "rotateRight90ToolStripMenuItem"
        Me.rotateRight90ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.rotateRight90ToolStripMenuItem.Text = "Rotate &right 90°"
        '
        'rotateLeft90ToolStripMenuItem
        '
        Me.rotateLeft90ToolStripMenuItem.Name = "rotateLeft90ToolStripMenuItem"
        Me.rotateLeft90ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.rotateLeft90ToolStripMenuItem.Text = "Rotate &left 90°"
        '
        'rotate180ToolStripMenuItem
        '
        Me.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem"
        Me.rotate180ToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.rotate180ToolStripMenuItem.Text = "Rotate &180°"
        '
        'imageEnhancementToolStripMenuItem
        '
        Me.imageEnhancementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.automaticCleanupToolStripMenuItem, Me.toolStripMenuItem1, Me.removePunchHolesToolStripMenuItem, Me.eraseBlackBordersToolStripMenuItem, Me.deskewToolStripMenuItem, Me.bitonalDespeckleToolStripMenuItem, Me.medianToolStripMenuItem, Me.scaleTo300DPIToolStripMenuItem, Me.scaleTo200ToolStripMenuItem, Me.thresholdToolStripMenuItem})
        Me.imageEnhancementToolStripMenuItem.Name = "imageEnhancementToolStripMenuItem"
        Me.imageEnhancementToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.imageEnhancementToolStripMenuItem.Text = "Image &Enhancement"
        '
        'automaticCleanupToolStripMenuItem
        '
        Me.automaticCleanupToolStripMenuItem.Name = "automaticCleanupToolStripMenuItem"
        Me.automaticCleanupToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.automaticCleanupToolStripMenuItem.Text = "Automatic Document Clean-up"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(238, 6)
        '
        'removePunchHolesToolStripMenuItem
        '
        Me.removePunchHolesToolStripMenuItem.Name = "removePunchHolesToolStripMenuItem"
        Me.removePunchHolesToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.removePunchHolesToolStripMenuItem.Text = "Remove Punch Holes"
        '
        'eraseBlackBordersToolStripMenuItem
        '
        Me.eraseBlackBordersToolStripMenuItem.Name = "eraseBlackBordersToolStripMenuItem"
        Me.eraseBlackBordersToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.eraseBlackBordersToolStripMenuItem.Text = "Erase Black Borders"
        '
        'deskewToolStripMenuItem
        '
        Me.deskewToolStripMenuItem.Name = "deskewToolStripMenuItem"
        Me.deskewToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.deskewToolStripMenuItem.Text = "Automatic Deskew"
        '
        'bitonalDespeckleToolStripMenuItem
        '
        Me.bitonalDespeckleToolStripMenuItem.Name = "bitonalDespeckleToolStripMenuItem"
        Me.bitonalDespeckleToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.bitonalDespeckleToolStripMenuItem.Text = "Bitonal Despeckle"
        '
        'medianToolStripMenuItem
        '
        Me.medianToolStripMenuItem.Name = "medianToolStripMenuItem"
        Me.medianToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.medianToolStripMenuItem.Text = "Median "
        '
        'scaleTo300DPIToolStripMenuItem
        '
        Me.scaleTo300DPIToolStripMenuItem.Name = "scaleTo300DPIToolStripMenuItem"
        Me.scaleTo300DPIToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.scaleTo300DPIToolStripMenuItem.Text = "Scale to 300 DPI"
        '
        'scaleTo200ToolStripMenuItem
        '
        Me.scaleTo200ToolStripMenuItem.Name = "scaleTo200ToolStripMenuItem"
        Me.scaleTo200ToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.scaleTo200ToolStripMenuItem.Text = "Scale to 200 %"
        '
        'thresholdToolStripMenuItem
        '
        Me.thresholdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sauvolaToolStripMenuItem, Me.otsuToolStripMenuItem, Me.bradleyToolStripMenuItem})
        Me.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem"
        Me.thresholdToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.thresholdToolStripMenuItem.Text = "Threshold"
        '
        'sauvolaToolStripMenuItem
        '
        Me.sauvolaToolStripMenuItem.Name = "sauvolaToolStripMenuItem"
        Me.sauvolaToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.sauvolaToolStripMenuItem.Text = "Sauvola"
        '
        'otsuToolStripMenuItem
        '
        Me.otsuToolStripMenuItem.Name = "otsuToolStripMenuItem"
        Me.otsuToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.otsuToolStripMenuItem.Text = "Otsu"
        '
        'bradleyToolStripMenuItem
        '
        Me.bradleyToolStripMenuItem.Name = "bradleyToolStripMenuItem"
        Me.bradleyToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.bradleyToolStripMenuItem.Text = "Bradley"
        '
        'SegmentationToolStripMenuItem
        '
        Me.SegmentationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.readToolStripMenuItem})
        Me.SegmentationToolStripMenuItem.Name = "SegmentationToolStripMenuItem"
        Me.SegmentationToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.SegmentationToolStripMenuItem.Text = "Segmentation"
        '
        'readToolStripMenuItem
        '
        Me.readToolStripMenuItem.Name = "readToolStripMenuItem"
        Me.readToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.readToolStripMenuItem.Text = "Start"
        '
        'statusStrip1
        '
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsImageInfo})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 668)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(822, 22)
        Me.statusStrip1.TabIndex = 13
        Me.statusStrip1.Text = "statusStrip1"
        '
        'tsImageInfo
        '
        Me.tsImageInfo.Name = "tsImageInfo"
        Me.tsImageInfo.Size = New System.Drawing.Size(0, 17)
        '
        'gdViewer1
        '
        Me.gdViewer1.AllowDropFile = false
        Me.gdViewer1.AnimateGIF = false
        Me.gdViewer1.AnnotationDropShadow = true
        Me.gdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.gdViewer1.AnnotationResizeRotateHandlesScale = 1!
        Me.gdViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.gdViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.gdViewer1.BackColor = System.Drawing.Color.Gray
        Me.gdViewer1.BackgroundImage = Nothing
        Me.gdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gdViewer1.ContinuousViewMode = true
        Me.gdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.gdViewer1.DisplayQualityAuto = false
        Me.gdViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.gdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.gdViewer1.EnableDeferredPainting = true
        Me.gdViewer1.EnabledProgressBar = true
        Me.gdViewer1.EnableICM = false
        Me.gdViewer1.EnableMenu = true
        Me.gdViewer1.EnableMouseWheel = true
        Me.gdViewer1.EnableTextSelection = true
        Me.gdViewer1.ForceScrollBars = false
        Me.gdViewer1.ForceTemporaryMode = false
        Me.gdViewer1.ForeColor = System.Drawing.Color.Black
        Me.gdViewer1.Gamma = 1!
        Me.gdViewer1.HQAnnotationRendering = true
        Me.gdViewer1.IgnoreDocumentResolution = false
        Me.gdViewer1.KeepDocumentPosition = false
        Me.gdViewer1.Location = New System.Drawing.Point(0, 24)
        Me.gdViewer1.LockViewer = false
        Me.gdViewer1.MagnifierHeight = 90
        Me.gdViewer1.MagnifierWidth = 160
        Me.gdViewer1.MagnifierZoomX = 2!
        Me.gdViewer1.MagnifierZoomY = 2!
        Me.gdViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.gdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection
        Me.gdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom
        Me.gdViewer1.Name = "gdViewer1"
        Me.gdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView
        Me.gdViewer1.PdfDisplayFormField = true
        Me.gdViewer1.PdfEnableFileLinks = true
        Me.gdViewer1.PdfEnableLinks = true
        Me.gdViewer1.PdfIncreaseTextContrast = false
        Me.gdViewer1.PdfShowDialogForPassword = true
        Me.gdViewer1.PdfShowOpenFileDialogForDecryption = true
        Me.gdViewer1.PdfVerifyDigitalCertificates = false
        Me.gdViewer1.RectBorderColor = System.Drawing.Color.Black
        Me.gdViewer1.RectBorderSize = 1
        Me.gdViewer1.RectIsEditable = true
        Me.gdViewer1.RegionsAreEditable = true
        Me.gdViewer1.RenderGdPictureAnnots = true
        Me.gdViewer1.ScrollBars = true
        Me.gdViewer1.ScrollLargeChange = CType(50,Short)
        Me.gdViewer1.ScrollSmallChange = CType(1,Short)
        Me.gdViewer1.SilentMode = true
        Me.gdViewer1.Size = New System.Drawing.Size(822, 644)
        Me.gdViewer1.TabIndex = 14
        Me.gdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.gdViewer1.Zoom = 1R
        Me.gdViewer1.ZoomCenterAtMousePosition = false
        Me.gdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100
        Me.gdViewer1.ZoomStep = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 690)
        Me.Controls.Add(Me.gdViewer1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET Segmentation Demo"
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        Me.statusStrip1.ResumeLayout(false)
        Me.statusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents openToolStripMenuItem As ToolStripMenuItem
    Private WithEvents closeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripSeparator3 As ToolStripSeparator
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents viewToolStripMenuItem As ToolStripMenuItem
    Private WithEvents zoomInToolStripMenuItem As ToolStripMenuItem
    Private WithEvents zoomOutToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As ToolStripMenuItem
    Private WithEvents ignoreResolutionToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripSeparator1 As ToolStripSeparator
    Private WithEvents blocksToolStripMenuItem As ToolStripMenuItem
    Private WithEvents paragraphsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents textLinesToolStripMenuItem As ToolStripMenuItem
    Private WithEvents wordsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents charactersToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem3 As ToolStripSeparator
    Private WithEvents chkShowBitmap As ToolStripMenuItem
    Private WithEvents chkShowText As ToolStripMenuItem
    Private WithEvents chkShowLines As ToolStripMenuItem
    Private WithEvents rotateToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotateRight90ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotateLeft90ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotate180ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents imageEnhancementToolStripMenuItem As ToolStripMenuItem
    Private WithEvents automaticCleanupToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As ToolStripSeparator
    Private WithEvents removePunchHolesToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eraseBlackBordersToolStripMenuItem As ToolStripMenuItem
    Private WithEvents deskewToolStripMenuItem As ToolStripMenuItem
    Private WithEvents bitonalDespeckleToolStripMenuItem As ToolStripMenuItem
    Private WithEvents medianToolStripMenuItem As ToolStripMenuItem
    Private WithEvents scaleTo300DPIToolStripMenuItem As ToolStripMenuItem
    Private WithEvents scaleTo200ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents thresholdToolStripMenuItem As ToolStripMenuItem
    Private WithEvents sauvolaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents otsuToolStripMenuItem As ToolStripMenuItem
    Private WithEvents bradleyToolStripMenuItem As ToolStripMenuItem
    Private WithEvents SegmentationToolStripMenuItem As ToolStripMenuItem
    Private WithEvents readToolStripMenuItem As ToolStripMenuItem
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents tsImageInfo As ToolStripStatusLabel
    Private WithEvents gdViewer1 As GdPicture14.GdViewer
End Class
