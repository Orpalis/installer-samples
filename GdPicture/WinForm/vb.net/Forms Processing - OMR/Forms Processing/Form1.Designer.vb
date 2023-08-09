<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanelButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.processFormsButton = New System.Windows.Forms.Button()
        Me.formSetUpButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanelData = New System.Windows.Forms.TableLayoutPanel()
        Me.processFormsPanel = New System.Windows.Forms.Panel()
        Me.processFormsTableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.omrImagesButton = New System.Windows.Forms.Button()
        Me.clearImagesButton = New System.Windows.Forms.Button()
        Me.loadImagesButton = New System.Windows.Forms.Button()
        Me.imagesViewer = New GdPicture14.GdViewer()
        Me.resultsTextBox = New System.Windows.Forms.RichTextBox()
        Me.formSetUpPanel = New System.Windows.Forms.Panel()
        Me.formSetUpTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.drawRectanglesButton = New System.Windows.Forms.Button()
        Me.addFieldsButton = New System.Windows.Forms.Button()
        Me.selectAnchorButton = New System.Windows.Forms.Button()
        Me.loadFormButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.settingsTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hasCharacter = New System.Windows.Forms.CheckBox()
        Me.oval = New System.Windows.Forms.RadioButton()
        Me.checkORCircle = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.useConfidence = New System.Windows.Forms.CheckBox()
        Me.confidenceGroup = New System.Windows.Forms.GroupBox()
        Me.sensitivityValue = New System.Windows.Forms.Label()
        Me.minConfidenceValue = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sensitivity = New System.Windows.Forms.HScrollBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.formViewer = New GdPicture14.GdViewer()
        Me.addFieldsPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totalNumberOfFieldsLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.addMultipleFieldsButton = New System.Windows.Forms.Button()
        Me.addSingleFieldButon = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanelButtons.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.processFormsPanel.SuspendLayout()
        Me.processFormsTableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.formSetUpPanel.SuspendLayout()
        Me.formSetUpTableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.settingsTableLayoutPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.confidenceGroup.SuspendLayout()
        CType(Me.minConfidenceValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addFieldsPanel.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1562, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ZToolStripMenuItem
        '
        Me.ZToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.CloseProjectToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ZToolStripMenuItem.Name = "ZToolStripMenuItem"
        Me.ZToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.ZToolStripMenuItem.Text = "File"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.NewProjectToolStripMenuItem.Text = "New Project"
        '
        'CloseProjectToolStripMenuItem
        '
        Me.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem"
        Me.CloseProjectToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.CloseProjectToolStripMenuItem.Text = "Close Project"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TableLayoutPanelButtons
        '
        Me.TableLayoutPanelButtons.ColumnCount = 1
        Me.TableLayoutPanelButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelButtons.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanelButtons.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanelButtons.Name = "TableLayoutPanelButtons"
        Me.TableLayoutPanelButtons.RowCount = 1
        Me.TableLayoutPanelButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelButtons.Size = New System.Drawing.Size(1562, 75)
        Me.TableLayoutPanelButtons.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.processFormsButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.formSetUpButton, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1556, 69)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'processFormsButton
        '
        Me.processFormsButton.BackColor = System.Drawing.Color.Teal
        Me.processFormsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.processFormsButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.processFormsButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.processFormsButton.Location = New System.Drawing.Point(781, 3)
        Me.processFormsButton.Name = "processFormsButton"
        Me.processFormsButton.Size = New System.Drawing.Size(772, 63)
        Me.processFormsButton.TabIndex = 1
        Me.processFormsButton.Text = "Stage Two: Process Forms"
        Me.processFormsButton.UseVisualStyleBackColor = False
        Me.processFormsButton.Visible = False
        '
        'formSetUpButton
        '
        Me.formSetUpButton.BackColor = System.Drawing.Color.Teal
        Me.formSetUpButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formSetUpButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.formSetUpButton.Location = New System.Drawing.Point(3, 3)
        Me.formSetUpButton.Name = "formSetUpButton"
        Me.formSetUpButton.Size = New System.Drawing.Size(772, 63)
        Me.formSetUpButton.TabIndex = 0
        Me.formSetUpButton.Text = "Stage One: Form Set Up"
        Me.formSetUpButton.UseVisualStyleBackColor = False
        Me.formSetUpButton.Visible = False
        '
        'TableLayoutPanelData
        '
        Me.TableLayoutPanelData.ColumnCount = 1
        Me.TableLayoutPanelData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelData.Location = New System.Drawing.Point(0, 103)
        Me.TableLayoutPanelData.Name = "TableLayoutPanelData"
        Me.TableLayoutPanelData.RowCount = 1
        Me.TableLayoutPanelData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelData.Size = New System.Drawing.Size(1562, 647)
        Me.TableLayoutPanelData.TabIndex = 2
        '
        'processFormsPanel
        '
        Me.processFormsPanel.Controls.Add(Me.processFormsTableLayoutPanel5)
        Me.processFormsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.processFormsPanel.Location = New System.Drawing.Point(3, 3)
        Me.processFormsPanel.Name = "processFormsPanel"
        Me.processFormsPanel.Size = New System.Drawing.Size(1361, 641)
        Me.processFormsPanel.TabIndex = 0
        '
        'processFormsTableLayoutPanel5
        '
        Me.processFormsTableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.processFormsTableLayoutPanel5.ColumnCount = 3
        Me.processFormsTableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.processFormsTableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.processFormsTableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341.0!))
        Me.processFormsTableLayoutPanel5.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.processFormsTableLayoutPanel5.Controls.Add(Me.imagesViewer, 1, 0)
        Me.processFormsTableLayoutPanel5.Controls.Add(Me.resultsTextBox, 2, 0)
        Me.processFormsTableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.processFormsTableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.processFormsTableLayoutPanel5.Name = "processFormsTableLayoutPanel5"
        Me.processFormsTableLayoutPanel5.RowCount = 1
        Me.processFormsTableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.processFormsTableLayoutPanel5.Size = New System.Drawing.Size(1361, 641)
        Me.processFormsTableLayoutPanel5.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ListBox1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(294, 629)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(282, 389)
        Me.ListBox1.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.omrImagesButton, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.clearImagesButton, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.loadImagesButton, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(6, 404)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(281, 217)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'omrImagesButton
        '
        Me.omrImagesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.omrImagesButton.Location = New System.Drawing.Point(3, 145)
        Me.omrImagesButton.Name = "omrImagesButton"
        Me.omrImagesButton.Size = New System.Drawing.Size(275, 69)
        Me.omrImagesButton.TabIndex = 2
        Me.omrImagesButton.Text = "OMR Images"
        Me.omrImagesButton.UseVisualStyleBackColor = True
        '
        'clearImagesButton
        '
        Me.clearImagesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clearImagesButton.Location = New System.Drawing.Point(3, 74)
        Me.clearImagesButton.Name = "clearImagesButton"
        Me.clearImagesButton.Size = New System.Drawing.Size(275, 65)
        Me.clearImagesButton.TabIndex = 1
        Me.clearImagesButton.Text = "Clear Images"
        Me.clearImagesButton.UseVisualStyleBackColor = True
        '
        'loadImagesButton
        '
        Me.loadImagesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loadImagesButton.Location = New System.Drawing.Point(3, 3)
        Me.loadImagesButton.Name = "loadImagesButton"
        Me.loadImagesButton.Size = New System.Drawing.Size(275, 65)
        Me.loadImagesButton.TabIndex = 0
        Me.loadImagesButton.Text = "Load Images"
        Me.loadImagesButton.UseVisualStyleBackColor = True
        '
        'imagesViewer
        '
        Me.imagesViewer.AllowDropFile = False
        Me.imagesViewer.AnimateGIF = False
        Me.imagesViewer.AnnotationDropShadow = true
        Me.imagesViewer.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.imagesViewer.AnnotationResizeRotateHandlesScale = 1.0!
        Me.imagesViewer.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.imagesViewer.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.imagesViewer.BackColor = System.Drawing.Color.Black
        Me.imagesViewer.BackgroundImage = Nothing
        Me.imagesViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.imagesViewer.ContinuousViewMode = True
        Me.imagesViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.imagesViewer.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.imagesViewer.DisplayQualityAuto = False
        Me.imagesViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imagesViewer.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.imagesViewer.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.imagesViewer.EnableDeferredPainting = True
        Me.imagesViewer.EnabledProgressBar = True
        Me.imagesViewer.EnableICM = False
        Me.imagesViewer.EnableMenu = False
        Me.imagesViewer.EnableMouseWheel = True
        Me.imagesViewer.EnableTextSelection = True
        Me.imagesViewer.ForceScrollBars = False
        Me.imagesViewer.ForeColor = System.Drawing.Color.Black
        Me.imagesViewer.Gamma = 1.0!
        Me.imagesViewer.HQAnnotationRendering = True
        Me.imagesViewer.IgnoreDocumentResolution = False
        Me.imagesViewer.KeepDocumentPosition = False
        Me.imagesViewer.Location = New System.Drawing.Point(309, 6)
        Me.imagesViewer.LockViewer = False
        Me.imagesViewer.MagnifierHeight = 90
        Me.imagesViewer.MagnifierWidth = 160
        Me.imagesViewer.MagnifierZoomX = 2.0!
        Me.imagesViewer.MagnifierZoomY = 2.0!
        Me.imagesViewer.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.imagesViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
        Me.imagesViewer.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom
        Me.imagesViewer.Name = "imagesViewer"
        Me.imagesViewer.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView
        Me.imagesViewer.PdfDisplayFormField = True
        Me.imagesViewer.PdfEnableFileLinks = True
        Me.imagesViewer.PdfEnableLinks = True
        Me.imagesViewer.PdfIncreaseTextContrast = False
        Me.imagesViewer.PdfShowDialogForPassword = True
        Me.imagesViewer.PdfShowOpenFileDialogForDecryption = True
        Me.imagesViewer.PdfVerifyDigitalCertificates = False
        Me.imagesViewer.RectBorderColor = System.Drawing.Color.Black
        Me.imagesViewer.RectBorderSize = 1
        Me.imagesViewer.RectIsEditable = True
        Me.imagesViewer.RegionsAreEditable = True
        Me.imagesViewer.RenderGdPictureAnnots = True
        Me.imagesViewer.ScrollBars = True
        Me.imagesViewer.ScrollLargeChange = CType(50, Short)
        Me.imagesViewer.ScrollSmallChange = CType(1, Short)
        Me.imagesViewer.SilentMode = True
        Me.imagesViewer.Size = New System.Drawing.Size(702, 629)
        Me.imagesViewer.TabIndex = 0
        Me.imagesViewer.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.imagesViewer.Zoom = 1.0R
        Me.imagesViewer.ZoomCenterAtMousePosition = False
        Me.imagesViewer.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100
        Me.imagesViewer.ZoomStep = 25
        '
        'resultsTextBox
        '
        Me.resultsTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.resultsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultsTextBox.Location = New System.Drawing.Point(1020, 6)
        Me.resultsTextBox.Name = "resultsTextBox"
        Me.resultsTextBox.Size = New System.Drawing.Size(335, 629)
        Me.resultsTextBox.TabIndex = 1
        Me.resultsTextBox.Text = ""
        '
        'formSetUpPanel
        '
        Me.formSetUpPanel.Controls.Add(Me.formSetUpTableLayoutPanel)
        Me.formSetUpPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formSetUpPanel.Location = New System.Drawing.Point(3, 3)
        Me.formSetUpPanel.Name = "formSetUpPanel"
        Me.formSetUpPanel.Size = New System.Drawing.Size(1361, 641)
        Me.formSetUpPanel.TabIndex = 0
        '
        'formSetUpTableLayoutPanel
        '
        Me.formSetUpTableLayoutPanel.BackColor = System.Drawing.Color.White
        Me.formSetUpTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.formSetUpTableLayoutPanel.ColumnCount = 1
        Me.formSetUpTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1385.0!))
        Me.formSetUpTableLayoutPanel.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.formSetUpTableLayoutPanel.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.formSetUpTableLayoutPanel.Controls.Add(Me.addFieldsPanel, 0, 1)
        Me.formSetUpTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formSetUpTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.formSetUpTableLayoutPanel.Name = "formSetUpTableLayoutPanel"
        Me.formSetUpTableLayoutPanel.RowCount = 3
        Me.formSetUpTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.formSetUpTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.formSetUpTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540.0!))
        Me.formSetUpTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.formSetUpTableLayoutPanel.Size = New System.Drawing.Size(1361, 641)
        Me.formSetUpTableLayoutPanel.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.drawRectanglesButton, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.addFieldsButton, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.selectAnchorButton, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.loadFormButton, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1379, 41)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'drawRectanglesButton
        '
        Me.drawRectanglesButton.BackColor = System.Drawing.Color.Teal
        Me.drawRectanglesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.drawRectanglesButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.drawRectanglesButton.Location = New System.Drawing.Point(1035, 3)
        Me.drawRectanglesButton.Name = "drawRectanglesButton"
        Me.drawRectanglesButton.Size = New System.Drawing.Size(341, 35)
        Me.drawRectanglesButton.TabIndex = 3
        Me.drawRectanglesButton.Text = "4. Draw Rectangles"
        Me.drawRectanglesButton.UseVisualStyleBackColor = False
        Me.drawRectanglesButton.Visible = False
        '
        'addFieldsButton
        '
        Me.addFieldsButton.BackColor = System.Drawing.Color.Teal
        Me.addFieldsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.addFieldsButton.Location = New System.Drawing.Point(691, 3)
        Me.addFieldsButton.Name = "addFieldsButton"
        Me.addFieldsButton.Size = New System.Drawing.Size(338, 35)
        Me.addFieldsButton.TabIndex = 2
        Me.addFieldsButton.Text = "3. Add Fields"
        Me.addFieldsButton.UseVisualStyleBackColor = False
        Me.addFieldsButton.Visible = False
        '
        'selectAnchorButton
        '
        Me.selectAnchorButton.BackColor = System.Drawing.Color.Teal
        Me.selectAnchorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.selectAnchorButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.selectAnchorButton.Location = New System.Drawing.Point(347, 3)
        Me.selectAnchorButton.Name = "selectAnchorButton"
        Me.selectAnchorButton.Size = New System.Drawing.Size(338, 35)
        Me.selectAnchorButton.TabIndex = 1
        Me.selectAnchorButton.Text = "2. Select Anchor"
        Me.selectAnchorButton.UseVisualStyleBackColor = False
        Me.selectAnchorButton.Visible = False
        '
        'loadFormButton
        '
        Me.loadFormButton.BackColor = System.Drawing.Color.Teal
        Me.loadFormButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loadFormButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.loadFormButton.Location = New System.Drawing.Point(3, 3)
        Me.loadFormButton.Name = "loadFormButton"
        Me.loadFormButton.Size = New System.Drawing.Size(338, 35)
        Me.loadFormButton.TabIndex = 0
        Me.loadFormButton.Text = "1. Load Form"
        Me.loadFormButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 406.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.settingsTableLayoutPanel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.formViewer, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 105)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1349, 534)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'settingsTableLayoutPanel
        '
        Me.settingsTableLayoutPanel.ColumnCount = 1
        Me.settingsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.settingsTableLayoutPanel.Controls.Add(Me.GroupBox1, 0, 0)
        Me.settingsTableLayoutPanel.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.settingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.settingsTableLayoutPanel.Location = New System.Drawing.Point(6, 6)
        Me.settingsTableLayoutPanel.Name = "settingsTableLayoutPanel"
        Me.settingsTableLayoutPanel.RowCount = 2
        Me.settingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.80077!))
        Me.settingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.19923!))
        Me.settingsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.settingsTableLayoutPanel.Size = New System.Drawing.Size(400, 522)
        Me.settingsTableLayoutPanel.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hasCharacter)
        Me.GroupBox1.Controls.Add(Me.oval)
        Me.GroupBox1.Controls.Add(Me.checkORCircle)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fields' Type"
        '
        'hasCharacter
        '
        Me.hasCharacter.AutoSize = True
        Me.hasCharacter.BackColor = System.Drawing.Color.Transparent
        Me.hasCharacter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.hasCharacter.Location = New System.Drawing.Point(26, 114)
        Me.hasCharacter.Name = "hasCharacter"
        Me.hasCharacter.Size = New System.Drawing.Size(121, 21)
        Me.hasCharacter.TabIndex = 2
        Me.hasCharacter.Text = "Has Character"
        Me.hasCharacter.UseVisualStyleBackColor = False
        '
        'oval
        '
        Me.oval.AutoSize = True
        Me.oval.BackColor = System.Drawing.Color.Transparent
        Me.oval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.oval.Location = New System.Drawing.Point(26, 60)
        Me.oval.Name = "oval"
        Me.oval.Size = New System.Drawing.Size(58, 21)
        Me.oval.TabIndex = 1
        Me.oval.Text = "Oval"
        Me.oval.UseVisualStyleBackColor = False
        '
        'checkORCircle
        '
        Me.checkORCircle.AutoSize = True
        Me.checkORCircle.BackColor = System.Drawing.Color.Transparent
        Me.checkORCircle.Checked = True
        Me.checkORCircle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.checkORCircle.Location = New System.Drawing.Point(26, 33)
        Me.checkORCircle.Name = "checkORCircle"
        Me.checkORCircle.Size = New System.Drawing.Size(151, 21)
        Me.checkORCircle.TabIndex = 0
        Me.checkORCircle.TabStop = True
        Me.checkORCircle.Text = "Circle or Check Box"
        Me.checkORCircle.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.useConfidence, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.confidenceGroup, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 169)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.28572!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.71429!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(394, 171)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'useConfidence
        '
        Me.useConfidence.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.useConfidence.AutoSize = True
        Me.useConfidence.BackColor = System.Drawing.Color.Transparent
        Me.useConfidence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.useConfidence.Location = New System.Drawing.Point(4, 10)
        Me.useConfidence.Name = "useConfidence"
        Me.useConfidence.Size = New System.Drawing.Size(130, 21)
        Me.useConfidence.TabIndex = 0
        Me.useConfidence.Text = "Use Confidence"
        Me.useConfidence.UseVisualStyleBackColor = False
        '
        'confidenceGroup
        '
        Me.confidenceGroup.Controls.Add(Me.sensitivityValue)
        Me.confidenceGroup.Controls.Add(Me.minConfidenceValue)
        Me.confidenceGroup.Controls.Add(Me.Label8)
        Me.confidenceGroup.Controls.Add(Me.Label7)
        Me.confidenceGroup.Controls.Add(Me.sensitivity)
        Me.confidenceGroup.Controls.Add(Me.Label6)
        Me.confidenceGroup.Controls.Add(Me.Label5)
        Me.confidenceGroup.Enabled = False
        Me.confidenceGroup.Location = New System.Drawing.Point(4, 45)
        Me.confidenceGroup.Name = "confidenceGroup"
        Me.confidenceGroup.Size = New System.Drawing.Size(385, 122)
        Me.confidenceGroup.TabIndex = 1
        Me.confidenceGroup.TabStop = False
        '
        'sensitivityValue
        '
        Me.sensitivityValue.AutoSize = True
        Me.sensitivityValue.Location = New System.Drawing.Point(82, 24)
        Me.sensitivityValue.Name = "sensitivityValue"
        Me.sensitivityValue.Size = New System.Drawing.Size(24, 17)
        Me.sensitivityValue.TabIndex = 6
        Me.sensitivityValue.Text = "50"
        '
        'minConfidenceValue
        '
        Me.minConfidenceValue.Location = New System.Drawing.Point(256, 91)
        Me.minConfidenceValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.minConfidenceValue.Name = "minConfidenceValue"
        Me.minConfidenceValue.Size = New System.Drawing.Size(120, 22)
        Me.minConfidenceValue.TabIndex = 5
        Me.minConfidenceValue.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(7, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(256, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Minimum Confidence To Consider Filled"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(307, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "100"
        '
        'sensitivity
        '
        Me.sensitivity.LargeChange = 2
        Me.sensitivity.Location = New System.Drawing.Point(74, 51)
        Me.sensitivity.Name = "sensitivity"
        Me.sensitivity.Size = New System.Drawing.Size(230, 21)
        Me.sensitivity.TabIndex = 2
        Me.sensitivity.Value = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(55, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(7, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sensitivity"
        '
        'formViewer
        '
        Me.formViewer.AllowDropFile = False
        Me.formViewer.AnimateGIF = False
        Me.formViewer.AnnotationDropShadow = true
        Me.formViewer.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.formViewer.AnnotationResizeRotateHandlesScale = 1.0!
        Me.formViewer.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.formViewer.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.formViewer.BackColor = System.Drawing.Color.Black
        Me.formViewer.BackgroundImage = Nothing
        Me.formViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.formViewer.ContinuousViewMode = True
        Me.formViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.formViewer.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.formViewer.DisplayQualityAuto = False
        Me.formViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formViewer.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.formViewer.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.formViewer.EnableDeferredPainting = True
        Me.formViewer.EnabledProgressBar = True
        Me.formViewer.EnableICM = False
        Me.formViewer.EnableMenu = False
        Me.formViewer.EnableMouseWheel = True
        Me.formViewer.EnableTextSelection = True
        Me.formViewer.ForceScrollBars = False
        Me.formViewer.ForeColor = System.Drawing.Color.Black
        Me.formViewer.Gamma = 1.0!
        Me.formViewer.HQAnnotationRendering = True
        Me.formViewer.IgnoreDocumentResolution = False
        Me.formViewer.KeepDocumentPosition = False
        Me.formViewer.Location = New System.Drawing.Point(415, 6)
        Me.formViewer.LockViewer = False
        Me.formViewer.MagnifierHeight = 90
        Me.formViewer.MagnifierWidth = 160
        Me.formViewer.MagnifierZoomX = 2.0!
        Me.formViewer.MagnifierZoomY = 2.0!
        Me.formViewer.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
        Me.formViewer.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom
        Me.formViewer.Name = "formViewer"
        Me.formViewer.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView
        Me.formViewer.PdfDisplayFormField = True
        Me.formViewer.PdfEnableFileLinks = True
        Me.formViewer.PdfEnableLinks = True
        Me.formViewer.PdfIncreaseTextContrast = False
        Me.formViewer.PdfShowDialogForPassword = True
        Me.formViewer.PdfShowOpenFileDialogForDecryption = True
        Me.formViewer.PdfVerifyDigitalCertificates = False
        Me.formViewer.RectBorderColor = System.Drawing.Color.Black
        Me.formViewer.RectBorderSize = 1
        Me.formViewer.RectIsEditable = True
        Me.formViewer.RegionsAreEditable = True
        Me.formViewer.RenderGdPictureAnnots = True
        Me.formViewer.ScrollBars = True
        Me.formViewer.ScrollLargeChange = CType(50, Short)
        Me.formViewer.ScrollSmallChange = CType(1, Short)
        Me.formViewer.SilentMode = True
        Me.formViewer.Size = New System.Drawing.Size(928, 522)
        Me.formViewer.TabIndex = 0
        Me.formViewer.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.formViewer.Zoom = 1.0R
        Me.formViewer.ZoomCenterAtMousePosition = False
        Me.formViewer.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100
        Me.formViewer.ZoomStep = 25
        '
        'addFieldsPanel
        '
        Me.addFieldsPanel.ColumnCount = 4
        Me.addFieldsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.addFieldsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.addFieldsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.addFieldsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.addFieldsPanel.Controls.Add(Me.TableLayoutPanel10, 3, 0)
        Me.addFieldsPanel.Controls.Add(Me.Label1, 0, 0)
        Me.addFieldsPanel.Controls.Add(Me.Label2, 1, 0)
        Me.addFieldsPanel.Controls.Add(Me.TableLayoutPanel9, 2, 0)
        Me.addFieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addFieldsPanel.Location = New System.Drawing.Point(6, 59)
        Me.addFieldsPanel.Name = "addFieldsPanel"
        Me.addFieldsPanel.RowCount = 1
        Me.addFieldsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.addFieldsPanel.Size = New System.Drawing.Size(1379, 37)
        Me.addFieldsPanel.TabIndex = 3
        Me.addFieldsPanel.Visible = False
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.totalNumberOfFieldsLabel, 1, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(1035, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(338, 31)
        Me.TableLayoutPanel10.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Total Number of Fields:"
        '
        'totalNumberOfFieldsLabel
        '
        Me.totalNumberOfFieldsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.totalNumberOfFieldsLabel.AutoSize = True
        Me.totalNumberOfFieldsLabel.Location = New System.Drawing.Point(182, 7)
        Me.totalNumberOfFieldsLabel.Name = "totalNumberOfFieldsLabel"
        Me.totalNumberOfFieldsLabel.Size = New System.Drawing.Size(16, 17)
        Me.totalNumberOfFieldsLabel.TabIndex = 5
        Me.totalNumberOfFieldsLabel.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 1
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.addMultipleFieldsButton, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.addSingleFieldButon, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(691, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(338, 31)
        Me.TableLayoutPanel9.TabIndex = 2
        '
        'addMultipleFieldsButton
        '
        Me.addMultipleFieldsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addMultipleFieldsButton.Location = New System.Drawing.Point(172, 3)
        Me.addMultipleFieldsButton.Name = "addMultipleFieldsButton"
        Me.addMultipleFieldsButton.Size = New System.Drawing.Size(163, 25)
        Me.addMultipleFieldsButton.TabIndex = 6
        Me.addMultipleFieldsButton.Text = "Add Multiple Fields"
        Me.addMultipleFieldsButton.UseVisualStyleBackColor = True
        '
        'addSingleFieldButon
        '
        Me.addSingleFieldButon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addSingleFieldButon.Location = New System.Drawing.Point(3, 3)
        Me.addSingleFieldButon.Name = "addSingleFieldButon"
        Me.addSingleFieldButon.Size = New System.Drawing.Size(163, 25)
        Me.addSingleFieldButon.TabIndex = 5
        Me.addSingleFieldButon.Text = "Add Single Field"
        Me.addSingleFieldButon.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Button1, 3, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(153, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 94)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "4. Draw Rectangles"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(685, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(335, 8)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "3. Settings..."
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Button3, 3, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Teal
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(153, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 94)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "4. Draw Rectangles"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Teal
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(685, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(335, 8)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "3. Settings..."
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1562, 750)
        Me.Controls.Add(Me.TableLayoutPanelData)
        Me.Controls.Add(Me.TableLayoutPanelButtons)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Forms Processing Demo  -  http://www.gdpicture.com"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanelButtons.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.processFormsPanel.ResumeLayout(False)
        Me.processFormsTableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.formSetUpPanel.ResumeLayout(False)
        Me.formSetUpTableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.settingsTableLayoutPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.confidenceGroup.ResumeLayout(False)
        Me.confidenceGroup.PerformLayout()
        CType(Me.minConfidenceValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addFieldsPanel.ResumeLayout(False)
        Me.addFieldsPanel.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TableLayoutPanelButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents processFormsButton As System.Windows.Forms.Button
    Friend WithEvents formSetUpButton As System.Windows.Forms.Button
    Friend WithEvents NewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanelData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents formSetUpPanel As System.Windows.Forms.Panel
    Friend WithEvents formSetUpTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents drawRectanglesButton As System.Windows.Forms.Button
    Friend WithEvents addFieldsButton As System.Windows.Forms.Button
    Friend WithEvents selectAnchorButton As System.Windows.Forms.Button
    Friend WithEvents loadFormButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents settingsTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents hasCharacter As System.Windows.Forms.CheckBox
    Friend WithEvents oval As System.Windows.Forms.RadioButton
    Friend WithEvents checkORCircle As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents useConfidence As System.Windows.Forms.CheckBox
    Friend WithEvents confidenceGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sensitivity As System.Windows.Forms.HScrollBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents minConfidenceValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents formViewer As GdPicture14.GdViewer
    Friend WithEvents sensitivityValue As System.Windows.Forms.Label
    Friend WithEvents processFormsPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents omrImagesButton As System.Windows.Forms.Button
    Friend WithEvents clearImagesButton As System.Windows.Forms.Button
    Friend WithEvents loadImagesButton As System.Windows.Forms.Button
    Friend WithEvents imagesViewer As GdPicture14.GdViewer
    Friend WithEvents resultsTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents addFieldsPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents addMultipleFieldsButton As System.Windows.Forms.Button
    Friend WithEvents addSingleFieldButon As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents totalNumberOfFieldsLabel As System.Windows.Forms.Label
    Friend WithEvents processFormsTableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel

End Class
