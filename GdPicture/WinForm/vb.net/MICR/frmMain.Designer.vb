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
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.gdViewer1 = New GdPicture14.GdViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.autoDeskewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rotate90ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToInputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.testsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nupMinAcc = New System.Windows.Forms.NumericUpDown()
        Me.cmbFont = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbContext = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbWhiteList = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.nupdownSymbols = New System.Windows.Forms.NumericUpDown()
        Me.lbWhitelIST = New System.Windows.Forms.Label()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nupMinAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupdownSymbols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.splitContainer2)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.txtResults)
        Me.splitContainer1.Size = New System.Drawing.Size(1139, 593)
        Me.splitContainer1.SplitterDistance = 436
        Me.splitContainer1.TabIndex = 2
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Name = "splitContainer2"
        Me.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.gdViewer1)
        Me.splitContainer2.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.splitContainer2.Panel2.Controls.Add(Me.nupMinAcc)
        Me.splitContainer2.Panel2.Controls.Add(Me.cmbFont)
        Me.splitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.splitContainer2.Panel2.Controls.Add(Me.cmbContext)
        Me.splitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.splitContainer2.Panel2.Controls.Add(Me.cmbWhiteList)
        Me.splitContainer2.Panel2.Controls.Add(Me.label1)
        Me.splitContainer2.Panel2.Controls.Add(Me.nupdownSymbols)
        Me.splitContainer2.Panel2.Controls.Add(Me.lbWhitelIST)
        Me.splitContainer2.Size = New System.Drawing.Size(1139, 436)
        Me.splitContainer2.SplitterDistance = 410
        Me.splitContainer2.SplitterWidth = 1
        Me.splitContainer2.TabIndex = 3
        '
        'gdViewer1
        '
        Me.gdViewer1.AllowDropFile = False
        Me.gdViewer1.AnimateGIF = False
        Me.gdViewer1.AnnotationDropShadow = True
        Me.gdViewer1.AnnotationEnableMultiSelect = True
        Me.gdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gdViewer1.AnnotationResizeRotateHandlesScale = 1.0!
        Me.gdViewer1.AnnotationSelectionLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gdViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.gdViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.gdViewer1.BackColor = System.Drawing.Color.Black
        Me.gdViewer1.BackgroundImage = Nothing
        Me.gdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gdViewer1.ClipAnnotsToPageBounds = True
        Me.gdViewer1.ClipRegionsToPageBounds = True
        Me.gdViewer1.ContinuousViewMode = True
        Me.gdViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.gdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.gdViewer1.DisplayQualityAuto = False
        Me.gdViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.gdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.gdViewer1.DrawPageBorders = True
        Me.gdViewer1.EnableDeferredPainting = True
        Me.gdViewer1.EnabledProgressBar = True
        Me.gdViewer1.EnableICM = False
        Me.gdViewer1.EnableMenu = True
        Me.gdViewer1.EnableMouseWheel = True
        Me.gdViewer1.EnableTextSelection = True
        Me.gdViewer1.ForceScrollBars = False
        Me.gdViewer1.ForceTemporaryMode = False
        Me.gdViewer1.ForeColor = System.Drawing.Color.Black
        Me.gdViewer1.Gamma = 1.0!
        Me.gdViewer1.HQAnnotationRendering = True
        Me.gdViewer1.IgnoreDocumentResolution = False
        Me.gdViewer1.KeepDocumentPosition = False
        Me.gdViewer1.Location = New System.Drawing.Point(0, 24)
        Me.gdViewer1.LockViewer = False
        Me.gdViewer1.MagnifierHeight = 90
        Me.gdViewer1.MagnifierWidth = 160
        Me.gdViewer1.MagnifierZoomX = 2.0!
        Me.gdViewer1.MagnifierZoomY = 2.0!
        Me.gdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.gdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
        Me.gdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom
        Me.gdViewer1.Name = "gdViewer1"
        Me.gdViewer1.PageBordersColor = System.Drawing.Color.Black
        Me.gdViewer1.PageBordersPenSize = 1
        Me.gdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView
        Me.gdViewer1.PdfDisplayFormField = True
        Me.gdViewer1.PdfEnableFileLinks = True
        Me.gdViewer1.PdfEnableLinks = True
        Me.gdViewer1.PdfIncreaseTextContrast = False
        Me.gdViewer1.PdfShowDialogForPassword = True
        Me.gdViewer1.PdfShowOpenFileDialogForDecryption = True
        Me.gdViewer1.PdfVerifyDigitalCertificates = False
        Me.gdViewer1.PreserveViewRotation = True
        Me.gdViewer1.RectBorderColor = System.Drawing.Color.Black
        Me.gdViewer1.RectBorderSize = 1
        Me.gdViewer1.RectIsEditable = True
        Me.gdViewer1.RegionsAreEditable = True
        Me.gdViewer1.RenderGdPictureAnnots = True
        Me.gdViewer1.ScrollBars = True
        Me.gdViewer1.ScrollLargeChange = CType(50, Short)
        Me.gdViewer1.ScrollSmallChange = CType(1, Short)
        Me.gdViewer1.SilentMode = True
        Me.gdViewer1.Size = New System.Drawing.Size(1139, 386)
        Me.gdViewer1.TabIndex = 1
        Me.gdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.gdViewer1.Zoom = 0.001R
        Me.gdViewer1.ZoomCenterAtMousePosition = False
        Me.gdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.gdViewer1.ZoomStep = 25
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditToolStripMenuItem, Me.testsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1139, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.closeToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem2.Text = "Open..."
        '
        'closeToolStripMenuItem
        '
        Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
        Me.closeToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.closeToolStripMenuItem.Text = "Close"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.autoDeskewToolStripMenuItem, Me.Rotate90ToolStripMenuItem, Me.ResetToInputToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'autoDeskewToolStripMenuItem
        '
        Me.autoDeskewToolStripMenuItem.Name = "autoDeskewToolStripMenuItem"
        Me.autoDeskewToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.autoDeskewToolStripMenuItem.Text = "Auto-Deskew"
        '
        'Rotate90ToolStripMenuItem
        '
        Me.Rotate90ToolStripMenuItem.Name = "Rotate90ToolStripMenuItem"
        Me.Rotate90ToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.Rotate90ToolStripMenuItem.Text = "Rotate 90"
        '
        'ResetToInputToolStripMenuItem
        '
        Me.ResetToInputToolStripMenuItem.Name = "ResetToInputToolStripMenuItem"
        Me.ResetToInputToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ResetToInputToolStripMenuItem.Text = "Reset to Input"
        '
        'testsToolStripMenuItem
        '
        Me.testsToolStripMenuItem.Name = "testsToolStripMenuItem"
        Me.testsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.testsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.testsToolStripMenuItem.Text = "Start!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(893, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Min accuracy:"
        '
        'nupMinAcc
        '
        Me.nupMinAcc.Location = New System.Drawing.Point(973, 4)
        Me.nupMinAcc.Name = "nupMinAcc"
        Me.nupMinAcc.Size = New System.Drawing.Size(44, 20)
        Me.nupMinAcc.TabIndex = 9
        Me.nupMinAcc.Value = New Decimal(New Integer() {70, 0, 0, 0})
        '
        'cmbFont
        '
        Me.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFont.FormattingEnabled = True
        Me.cmbFont.Items.AddRange(New Object() {"CMC7", "E13B"})
        Me.cmbFont.Location = New System.Drawing.Point(798, 2)
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Size = New System.Drawing.Size(84, 21)
        Me.cmbFont.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(761, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Font:"
        '
        'cmbContext
        '
        Me.cmbContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContext.FormattingEnabled = True
        Me.cmbContext.Items.AddRange(New Object() {"Document", "Line Finding"})
        Me.cmbContext.Location = New System.Drawing.Point(603, 2)
        Me.cmbContext.Name = "cmbContext"
        Me.cmbContext.Size = New System.Drawing.Size(144, 21)
        Me.cmbContext.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(552, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Context:"
        '
        'cmbWhiteList
        '
        Me.cmbWhiteList.FormattingEnabled = True
        Me.cmbWhiteList.Items.AddRange(New Object() {"0123456789/<#>^", "0123456789/<#>^ABCDEFGHIJKLMNOPQRSTUVWXYZ", "0123456789ABCD"})
        Me.cmbWhiteList.Location = New System.Drawing.Point(70, 3)
        Me.cmbWhiteList.Name = "cmbWhiteList"
        Me.cmbWhiteList.Size = New System.Drawing.Size(315, 21)
        Me.cmbWhiteList.TabIndex = 4
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(403, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Expected Items:"
        '
        'nupdownSymbols
        '
        Me.nupdownSymbols.Location = New System.Drawing.Point(492, 4)
        Me.nupdownSymbols.Name = "nupdownSymbols"
        Me.nupdownSymbols.Size = New System.Drawing.Size(44, 20)
        Me.nupdownSymbols.TabIndex = 2
        '
        'lbWhitelIST
        '
        Me.lbWhitelIST.AutoSize = True
        Me.lbWhitelIST.Location = New System.Drawing.Point(7, 7)
        Me.lbWhitelIST.Name = "lbWhitelIST"
        Me.lbWhitelIST.Size = New System.Drawing.Size(57, 13)
        Me.lbWhitelIST.TabIndex = 0
        Me.lbWhitelIST.Text = "White List:"
        '
        'txtResults
        '
        Me.txtResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResults.Location = New System.Drawing.Point(0, 0)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(1139, 153)
        Me.txtResults.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 593)
        Me.Controls.Add(Me.splitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "GdPicture.NET - MICR Demo  -  http://www.gdpicture.com"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel1.PerformLayout()
        Me.splitContainer2.Panel2.ResumeLayout(False)
        Me.splitContainer2.Panel2.PerformLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nupMinAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupdownSymbols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents splitContainer2 As System.Windows.Forms.SplitContainer
    Private WithEvents gdViewer1 As GdPicture14.GdViewer
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents nupMinAcc As System.Windows.Forms.NumericUpDown
    Private WithEvents cmbFont As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cmbContext As System.Windows.Forms.ComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents cmbWhiteList As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents nupdownSymbols As System.Windows.Forms.NumericUpDown
    Private WithEvents lbWhitelIST As System.Windows.Forms.Label
    Private WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents closeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents autoDeskewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Rotate90ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToInputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents testsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
