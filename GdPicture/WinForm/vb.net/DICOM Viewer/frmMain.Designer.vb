Imports GdPicture14
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            GdViewer1.CloseDocument()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GotoFirstPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GotoPreviousPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GotoNextPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GotoLastPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rotate90ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rotate180ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rotate270ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouseModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThumbnailsSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Small64X64ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Medium128X128ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Large256256ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LevelWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableWindowLevelingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ThumbnailEx1 = New GdPicture14.ThumbnailEx()
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PageToolStripMenuItem, Me.RotationToolStripMenuItem, Me.MouseModeToolStripMenuItem, Me.AnimateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1371, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.OpenDirectoryToolStripMenuItem, Me.ToolStripMenuItem10, Me.ToolStripMenuProperties, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.OpenToolStripMenuItem.Text = "Open Single File..."
        '
        'OpenDirectoryToolStripMenuItem
        '
        Me.OpenDirectoryToolStripMenuItem.Name = "OpenDirectoryToolStripMenuItem"
        Me.OpenDirectoryToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.OpenDirectoryToolStripMenuItem.Text = "Open Directory..."
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(201, 26)
        Me.ToolStripMenuItem10.Text = "Print..."
        '
        'ToolStripMenuProperties
        '
        Me.ToolStripMenuProperties.Name = "ToolStripMenuProperties"
        Me.ToolStripMenuProperties.Size = New System.Drawing.Size(201, 26)
        Me.ToolStripMenuProperties.Text = "Properties..."
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PageToolStripMenuItem
        '
        Me.PageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GotoFirstPageToolStripMenuItem, Me.GotoPreviousPageToolStripMenuItem, Me.GotoNextPageToolStripMenuItem, Me.GotoLastPageToolStripMenuItem})
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.PageToolStripMenuItem.Text = "Frames"
        '
        'GotoFirstPageToolStripMenuItem
        '
        Me.GotoFirstPageToolStripMenuItem.Name = "GotoFirstPageToolStripMenuItem"
        Me.GotoFirstPageToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.GotoFirstPageToolStripMenuItem.Text = "Goto First Frame"
        '
        'GotoPreviousPageToolStripMenuItem
        '
        Me.GotoPreviousPageToolStripMenuItem.Name = "GotoPreviousPageToolStripMenuItem"
        Me.GotoPreviousPageToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.GotoPreviousPageToolStripMenuItem.Text = "Goto Previous Frame"
        '
        'GotoNextPageToolStripMenuItem
        '
        Me.GotoNextPageToolStripMenuItem.Name = "GotoNextPageToolStripMenuItem"
        Me.GotoNextPageToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.GotoNextPageToolStripMenuItem.Text = "Goto Next Frame"
        '
        'GotoLastPageToolStripMenuItem
        '
        Me.GotoLastPageToolStripMenuItem.Name = "GotoLastPageToolStripMenuItem"
        Me.GotoLastPageToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.GotoLastPageToolStripMenuItem.Text = "Goto Last Frame"
        '
        'RotationToolStripMenuItem
        '
        Me.RotationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Rotate90ToolStripMenuItem, Me.Rotate180ToolStripMenuItem, Me.Rotate270ToolStripMenuItem, Me.FlipXToolStripMenuItem, Me.FlipYToolStripMenuItem})
        Me.RotationToolStripMenuItem.Name = "RotationToolStripMenuItem"
        Me.RotationToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.RotationToolStripMenuItem.Text = "Rotation"
        '
        'Rotate90ToolStripMenuItem
        '
        Me.Rotate90ToolStripMenuItem.Name = "Rotate90ToolStripMenuItem"
        Me.Rotate90ToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.Rotate90ToolStripMenuItem.Text = "Rotate 90°"
        '
        'Rotate180ToolStripMenuItem
        '
        Me.Rotate180ToolStripMenuItem.Name = "Rotate180ToolStripMenuItem"
        Me.Rotate180ToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.Rotate180ToolStripMenuItem.Text = "Rotate 180°"
        '
        'Rotate270ToolStripMenuItem
        '
        Me.Rotate270ToolStripMenuItem.Name = "Rotate270ToolStripMenuItem"
        Me.Rotate270ToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.Rotate270ToolStripMenuItem.Text = "Rotate 270°"
        '
        'FlipXToolStripMenuItem
        '
        Me.FlipXToolStripMenuItem.Name = "FlipXToolStripMenuItem"
        Me.FlipXToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.FlipXToolStripMenuItem.Text = "Flip X"
        '
        'FlipYToolStripMenuItem
        '
        Me.FlipYToolStripMenuItem.Name = "FlipYToolStripMenuItem"
        Me.FlipYToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.FlipYToolStripMenuItem.Text = "Flip Y"
        '
        'MouseModeToolStripMenuItem
        '
        Me.MouseModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThumbnailsSizeToolStripMenuItem, Me.LevelWindowsToolStripMenuItem, Me.EnableWindowLevelingToolStripMenuItem})
        Me.MouseModeToolStripMenuItem.Name = "MouseModeToolStripMenuItem"
        Me.MouseModeToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.MouseModeToolStripMenuItem.Text = "Options"
        '
        'ThumbnailsSizeToolStripMenuItem
        '
        Me.ThumbnailsSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Small64X64ToolStripMenuItem, Me.Medium128X128ToolStripMenuItem, Me.Large256256ToolStripMenuItem})
        Me.ThumbnailsSizeToolStripMenuItem.Name = "ThumbnailsSizeToolStripMenuItem"
        Me.ThumbnailsSizeToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.ThumbnailsSizeToolStripMenuItem.Text = "Thumbnails Size"
        '
        'Small64X64ToolStripMenuItem
        '
        Me.Small64X64ToolStripMenuItem.Name = "Small64X64ToolStripMenuItem"
        Me.Small64X64ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.Small64X64ToolStripMenuItem.Text = "Small (64 x 64)"
        '
        'Medium128X128ToolStripMenuItem
        '
        Me.Medium128X128ToolStripMenuItem.Name = "Medium128X128ToolStripMenuItem"
        Me.Medium128X128ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.Medium128X128ToolStripMenuItem.Text = "Medium (128 x 128)"
        '
        'Large256256ToolStripMenuItem
        '
        Me.Large256256ToolStripMenuItem.Checked = True
        Me.Large256256ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Large256256ToolStripMenuItem.Name = "Large256256ToolStripMenuItem"
        Me.Large256256ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.Large256256ToolStripMenuItem.Text = "Large (256 * 256)"
        '
        'LevelWindowsToolStripMenuItem
        '
        Me.LevelWindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreDefaultToolStripMenuItem})
        Me.LevelWindowsToolStripMenuItem.Name = "LevelWindowsToolStripMenuItem"
        Me.LevelWindowsToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.LevelWindowsToolStripMenuItem.Text = "Level Window"
        '
        'RestoreDefaultToolStripMenuItem
        '
        Me.RestoreDefaultToolStripMenuItem.Name = "RestoreDefaultToolStripMenuItem"
        Me.RestoreDefaultToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.RestoreDefaultToolStripMenuItem.Text = "Restore Default"
        '
        'EnableWindowLevelingToolStripMenuItem
        '
        Me.EnableWindowLevelingToolStripMenuItem.Checked = True
        Me.EnableWindowLevelingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableWindowLevelingToolStripMenuItem.Name = "EnableWindowLevelingToolStripMenuItem"
        Me.EnableWindowLevelingToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.EnableWindowLevelingToolStripMenuItem.Text = "Enable Window Leveling"
        '
        'AnimateToolStripMenuItem
        '
        Me.AnimateToolStripMenuItem.Name = "AnimateToolStripMenuItem"
        Me.AnimateToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.AnimateToolStripMenuItem.Text = "Animate"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 678)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1371, 25)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(75, 20)
        Me.ToolStripStatusLabel1.Text = "Welcome!"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ThumbnailEx1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GdViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1371, 650)
        Me.SplitContainer1.SplitterDistance = 204
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 9
        '
        'ThumbnailEx1
        '
        Me.ThumbnailEx1.AllowDropFiles = False
        Me.ThumbnailEx1.AllowMoveItems = False
        Me.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control
        Me.ThumbnailEx1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ThumbnailEx1.CheckBoxes = False
        Me.ThumbnailEx1.CheckBoxesMarginLeft = 0
        Me.ThumbnailEx1.CheckBoxesMarginTop = 0
        Me.ThumbnailEx1.DefaultItemTextPrefix = "Page "
        Me.ThumbnailEx1.DisplayAnnotations = True
        Me.ThumbnailEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThumbnailEx1.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        Me.ThumbnailEx1.HotTracking = False
        Me.ThumbnailEx1.Location = New System.Drawing.Point(0, 0)
        Me.ThumbnailEx1.LockGdViewerEvents = False
        Me.ThumbnailEx1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ThumbnailEx1.MultiSelect = False
        Me.ThumbnailEx1.Name = "ThumbnailEx1"
        Me.ThumbnailEx1.OwnDrop = False
        Me.ThumbnailEx1.PauseThumbsLoading = False
        Me.ThumbnailEx1.PdfIncreaseTextContrast = False
        Me.ThumbnailEx1.PreloadAllItems = True
        Me.ThumbnailEx1.RotateExif = True
        Me.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThumbnailEx1.ShowText = True
        Me.ThumbnailEx1.Size = New System.Drawing.Size(204, 650)
        Me.ThumbnailEx1.TabIndex = 1
        Me.ThumbnailEx1.TextMarginLeft = 0
        Me.ThumbnailEx1.TextMarginTop = 0
        Me.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical
        Me.ThumbnailEx1.ThumbnailBorder = True
        Me.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Black
        Me.ThumbnailEx1.ThumbnailSize = New System.Drawing.Size(256, 256)
        Me.ThumbnailEx1.ThumbnailSpacing = New System.Drawing.Size(0, 0)
        Me.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        '
        'GdViewer1
        '
        Me.GdViewer1.AllowDropFile = False
        Me.GdViewer1.AnimateGIF = False
        Me.GdViewer1.AnnotationDropShadow = true
        Me.GdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GdViewer1.AnnotationResizeRotateHandlesScale = 1.0!
        Me.GdViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.GdViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.GdViewer1.BackColor = System.Drawing.Color.Black
        Me.GdViewer1.BackgroundImage = Nothing
        Me.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GdViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GdViewer1.ContinuousViewMode = False
        Me.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.GdViewer1.DisplayQualityAuto = False
        Me.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.GdViewer1.EnableDeferredPainting = True
        Me.GdViewer1.EnabledProgressBar = True
        Me.GdViewer1.EnableICM = False
        Me.GdViewer1.EnableMenu = False
        Me.GdViewer1.EnableMouseWheel = True
        Me.GdViewer1.EnableTextSelection = True
        Me.GdViewer1.ForceScrollBars = False
        Me.GdViewer1.ForeColor = System.Drawing.Color.Black
        Me.GdViewer1.Gamma = 1.0!
        Me.GdViewer1.HQAnnotationRendering = True
        Me.GdViewer1.IgnoreDocumentResolution = False
        Me.GdViewer1.KeepDocumentPosition = True
        Me.GdViewer1.Location = New System.Drawing.Point(0, 0)
        Me.GdViewer1.LockViewer = False
        Me.GdViewer1.MagnifierHeight = 90
        Me.GdViewer1.MagnifierWidth = 160
        Me.GdViewer1.MagnifierZoomX = 2.0!
        Me.GdViewer1.MagnifierZoomY = 2.0!
        Me.GdViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModeDefault
        Me.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeVerticalScroll
        Me.GdViewer1.Name = "GdViewer1"
        Me.GdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView
        Me.GdViewer1.PdfDisplayFormField = True
        Me.GdViewer1.PdfEnableFileLinks = True
        Me.GdViewer1.PdfEnableLinks = True
        Me.GdViewer1.PdfIncreaseTextContrast = False
        Me.GdViewer1.PdfShowDialogForPassword = True
        Me.GdViewer1.PdfShowOpenFileDialogForDecryption = True
        Me.GdViewer1.PdfVerifyDigitalCertificates = False
        Me.GdViewer1.RectBorderColor = System.Drawing.Color.Black
        Me.GdViewer1.RectBorderSize = 1
        Me.GdViewer1.RectIsEditable = True
        Me.GdViewer1.RegionsAreEditable = True
        Me.GdViewer1.RenderGdPictureAnnots = True
        Me.GdViewer1.ScrollBars = True
        Me.GdViewer1.ScrollLargeChange = CType(50, Short)
        Me.GdViewer1.ScrollSmallChange = CType(1, Short)
        Me.GdViewer1.SilentMode = True
        Me.GdViewer1.Size = New System.Drawing.Size(1162, 650)
        Me.GdViewer1.TabIndex = 3
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 0.001R
        Me.GdViewer1.ZoomCenterAtMousePosition = False
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer1.ZoomStep = 25
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 703)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "GdPicture.NET - DICOM Viewer Sample  -  http://www.gdpicture.com"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GotoFirstPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GotoPreviousPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GotoNextPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GotoLastPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RotationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Rotate90ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Rotate180ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Rotate270ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlipXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MouseModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuProperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThumbnailsSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Small64X64ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Medium128X128ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Large256256ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlipYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ThumbnailEx1 As GdPicture14.ThumbnailEx
    Friend WithEvents GdViewer1 As GdPicture14.GdViewer
    Friend WithEvents LevelWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreDefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents EnableWindowLevelingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
