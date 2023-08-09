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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Binarization = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.scroll3Panel = New System.Windows.Forms.TableLayoutPanel()
        Me.txtKernelVal = New System.Windows.Forms.TextBox()
        Me.scrlKernelParam = New System.Windows.Forms.HScrollBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.scroll2Panel = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMinDifVal = New System.Windows.Forms.TextBox()
        Me.scrlContrastParam = New System.Windows.Forms.HScrollBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.scroll1Panel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtThresholdMin = New System.Windows.Forms.Label()
        Me.scrlThresoldParam = New System.Windows.Forms.HScrollBar()
        Me.txtThresholdMax = New System.Windows.Forms.Label()
        Me.txtThreshVal = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.scroll3Panel.SuspendLayout()
        Me.scroll2Panel.SuspendLayout()
        Me.scroll1Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1108, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GdViewer1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1108, 643)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 999.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.Binarization, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.comboBox1, 1, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(6, 4)
        Me.tableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(1096, 46)
        Me.tableLayoutPanel2.TabIndex = 1
        '
        'Binarization
        '
        Me.Binarization.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Binarization.AutoSize = True
        Me.Binarization.Location = New System.Drawing.Point(19, 14)
        Me.Binarization.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Binarization.Name = "Binarization"
        Me.Binarization.Size = New System.Drawing.Size(82, 17)
        Me.Binarization.TabIndex = 0
        Me.Binarization.Text = "Binarization"
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"None", "Linear", "Adaptive (Otsu)", "Order Dither", "Burke", "Stucki", "FloydStienberg", "Sauvola", "Bradley"})
        Me.comboBox1.Location = New System.Drawing.Point(125, 5)
        Me.comboBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(303, 24)
        Me.comboBox1.TabIndex = 1
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
        Me.GdViewer1.ContinuousViewMode = True
        Me.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.GdViewer1.DisplayQualityAuto = False
        Me.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.GdViewer1.EnableDeferredPainting = True
        Me.GdViewer1.EnabledProgressBar = True
        Me.GdViewer1.EnableICM = False
        Me.GdViewer1.EnableMenu = True
        Me.GdViewer1.EnableMouseWheel = True
        Me.GdViewer1.EnableTextSelection = True
        Me.GdViewer1.ForceScrollBars = False
        Me.GdViewer1.ForeColor = System.Drawing.Color.Black
        Me.GdViewer1.Gamma = 1.0!
        Me.GdViewer1.HQAnnotationRendering = True
        Me.GdViewer1.IgnoreDocumentResolution = False
        Me.GdViewer1.KeepDocumentPosition = False
        Me.GdViewer1.Location = New System.Drawing.Point(6, 56)
        Me.GdViewer1.LockViewer = False
        Me.GdViewer1.MagnifierHeight = 90
        Me.GdViewer1.MagnifierWidth = 160
        Me.GdViewer1.MagnifierZoomX = 2.0!
        Me.GdViewer1.MagnifierZoomY = 2.0!
        Me.GdViewer1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
        Me.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom
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
        Me.GdViewer1.Size = New System.Drawing.Size(1096, 455)
        Me.GdViewer1.TabIndex = 0
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 1.0R
        Me.GdViewer1.ZoomCenterAtMousePosition = False
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100
        Me.GdViewer1.ZoomStep = 25
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.scroll3Panel, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.scroll2Panel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.scroll1Panel, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 517)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1095, 122)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'scroll3Panel
        '
        Me.scroll3Panel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scroll3Panel.ColumnCount = 5
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.27928!))
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.72072!))
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257.0!))
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.scroll3Panel.Controls.Add(Me.txtKernelVal, 4, 0)
        Me.scroll3Panel.Controls.Add(Me.scrlKernelParam, 2, 0)
        Me.scroll3Panel.Controls.Add(Me.Label5, 1, 0)
        Me.scroll3Panel.Controls.Add(Me.Label3, 0, 0)
        Me.scroll3Panel.Controls.Add(Me.Label7, 3, 0)
        Me.scroll3Panel.Location = New System.Drawing.Point(4, 74)
        Me.scroll3Panel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.scroll3Panel.Name = "scroll3Panel"
        Me.scroll3Panel.RowCount = 1
        Me.scroll3Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scroll3Panel.Size = New System.Drawing.Size(539, 34)
        Me.scroll3Panel.TabIndex = 2
        '
        'txtKernelVal
        '
        Me.txtKernelVal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtKernelVal.Enabled = False
        Me.txtKernelVal.Location = New System.Drawing.Point(429, 6)
        Me.txtKernelVal.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtKernelVal.Name = "txtKernelVal"
        Me.txtKernelVal.Size = New System.Drawing.Size(99, 22)
        Me.txtKernelVal.TabIndex = 5
        Me.txtKernelVal.Text = "2"
        '
        'scrlKernelParam
        '
        Me.scrlKernelParam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scrlKernelParam.LargeChange = 1
        Me.scrlKernelParam.Location = New System.Drawing.Point(117, 4)
        Me.scrlKernelParam.Maximum = 5
        Me.scrlKernelParam.Name = "scrlKernelParam"
        Me.scrlKernelParam.Size = New System.Drawing.Size(253, 26)
        Me.scrlKernelParam.TabIndex = 3
        Me.scrlKernelParam.Value = 2
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 34)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Smooth Kernel"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 8)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "5"
        '
        'scroll2Panel
        '
        Me.scroll2Panel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scroll2Panel.ColumnCount = 5
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.81818!))
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.scroll2Panel.Controls.Add(Me.txtMinDifVal, 4, 0)
        Me.scroll2Panel.Controls.Add(Me.scrlContrastParam, 2, 0)
        Me.scroll2Panel.Controls.Add(Me.Label4, 1, 0)
        Me.scroll2Panel.Controls.Add(Me.Label2, 0, 0)
        Me.scroll2Panel.Controls.Add(Me.Label6, 3, 0)
        Me.scroll2Panel.Location = New System.Drawing.Point(551, 13)
        Me.scroll2Panel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.scroll2Panel.Name = "scroll2Panel"
        Me.scroll2Panel.RowCount = 1
        Me.scroll2Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scroll2Panel.Size = New System.Drawing.Size(540, 34)
        Me.scroll2Panel.TabIndex = 1
        '
        'txtMinDifVal
        '
        Me.txtMinDifVal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMinDifVal.Enabled = False
        Me.txtMinDifVal.Location = New System.Drawing.Point(442, 6)
        Me.txtMinDifVal.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtMinDifVal.Name = "txtMinDifVal"
        Me.txtMinDifVal.Size = New System.Drawing.Size(88, 22)
        Me.txtMinDifVal.TabIndex = 5
        Me.txtMinDifVal.Text = "50"
        '
        'scrlContrastParam
        '
        Me.scrlContrastParam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scrlContrastParam.LargeChange = 1
        Me.scrlContrastParam.Location = New System.Drawing.Point(139, 4)
        Me.scrlContrastParam.Maximum = 255
        Me.scrlContrastParam.Name = "scrlContrastParam"
        Me.scrlContrastParam.Size = New System.Drawing.Size(247, 26)
        Me.scrlContrastParam.TabIndex = 3
        Me.scrlContrastParam.Value = 50
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contrast Dif. Min"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(390, 8)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "255"
        '
        'scroll1Panel
        '
        Me.scroll1Panel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scroll1Panel.ColumnCount = 5
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257.0!))
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.scroll1Panel.Controls.Add(Me.Label1, 0, 0)
        Me.scroll1Panel.Controls.Add(Me.txtThresholdMin, 1, 0)
        Me.scroll1Panel.Controls.Add(Me.scrlThresoldParam, 2, 0)
        Me.scroll1Panel.Controls.Add(Me.txtThresholdMax, 3, 0)
        Me.scroll1Panel.Controls.Add(Me.txtThreshVal, 4, 0)
        Me.scroll1Panel.Location = New System.Drawing.Point(4, 13)
        Me.scroll1Panel.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.scroll1Panel.Name = "scroll1Panel"
        Me.scroll1Panel.RowCount = 1
        Me.scroll1Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.scroll1Panel.Size = New System.Drawing.Size(539, 34)
        Me.scroll1Panel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Threshold"
        '
        'txtThresholdMin
        '
        Me.txtThresholdMin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtThresholdMin.AutoSize = True
        Me.txtThresholdMin.Location = New System.Drawing.Point(84, 8)
        Me.txtThresholdMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtThresholdMin.Name = "txtThresholdMin"
        Me.txtThresholdMin.Size = New System.Drawing.Size(16, 17)
        Me.txtThresholdMin.TabIndex = 1
        Me.txtThresholdMin.Text = "0"
        '
        'scrlThresoldParam
        '
        Me.scrlThresoldParam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scrlThresoldParam.LargeChange = 1
        Me.scrlThresoldParam.Location = New System.Drawing.Point(131, 4)
        Me.scrlThresoldParam.Name = "scrlThresoldParam"
        Me.scrlThresoldParam.Size = New System.Drawing.Size(253, 26)
        Me.scrlThresoldParam.TabIndex = 2
        '
        'txtThresholdMax
        '
        Me.txtThresholdMax.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtThresholdMax.AutoSize = True
        Me.txtThresholdMax.Location = New System.Drawing.Point(392, 8)
        Me.txtThresholdMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtThresholdMax.Name = "txtThresholdMax"
        Me.txtThresholdMax.Size = New System.Drawing.Size(32, 17)
        Me.txtThresholdMax.TabIndex = 3
        Me.txtThresholdMax.Text = "100"
        '
        'txtThreshVal
        '
        Me.txtThreshVal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtThreshVal.Enabled = False
        Me.txtThreshVal.Location = New System.Drawing.Point(443, 6)
        Me.txtThreshVal.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtThreshVal.Name = "txtThreshVal"
        Me.txtThreshVal.Size = New System.Drawing.Size(99, 22)
        Me.txtThreshVal.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 671)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Binarization Demo  -  http://www.gdpicture.com"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.tableLayoutPanel2.ResumeLayout(false)
        Me.tableLayoutPanel2.PerformLayout
        Me.TableLayoutPanel3.ResumeLayout(false)
        Me.scroll3Panel.ResumeLayout(false)
        Me.scroll3Panel.PerformLayout
        Me.scroll2Panel.ResumeLayout(false)
        Me.scroll2Panel.PerformLayout
        Me.scroll1Panel.ResumeLayout(false)
        Me.scroll1Panel.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Binarization As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GdViewer1 As GdPicture14.GdViewer
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents scroll3Panel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents scroll2Panel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents scroll1Panel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtThresholdMin As System.Windows.Forms.Label
    Friend WithEvents scrlKernelParam As System.Windows.Forms.HScrollBar
    Friend WithEvents scrlContrastParam As System.Windows.Forms.HScrollBar
    Friend WithEvents scrlThresoldParam As System.Windows.Forms.HScrollBar
    Friend WithEvents txtThresholdMax As System.Windows.Forms.Label
    Friend WithEvents txtKernelVal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMinDifVal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtThreshVal As System.Windows.Forms.TextBox


End Class
