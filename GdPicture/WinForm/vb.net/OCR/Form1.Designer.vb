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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkEnableVigorousDespeckle = New System.Windows.Forms.CheckBox()
        Me.chkLoadMainDict = New System.Windows.Forms.CheckBox()
        Me.chkLoadFreqWordsDict = New System.Windows.Forms.CheckBox()
        Me.tbNonFreqWords = New System.Windows.Forms.TrackBar()
        Me.label9 = New System.Windows.Forms.Label()
        Me.tbNonDictWords = New System.Windows.Forms.TrackBar()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.btnClearSelection = New System.Windows.Forms.Button()
        Me.lbLanguages = New System.Windows.Forms.ListBox()
        Me.cbCharacterSet = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cbMode = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cbContext = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnBrowseResourceFolder = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tbResouceFolder = New System.Windows.Forms.TextBox()
        Me.gdViewer1 = New GdPicture14.GdViewer()
        Me.cbDeskew = New System.Windows.Forms.CheckBox()
        Me.cbDetectOrientation = New System.Windows.Forms.CheckBox()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkEnablePreprocessing = New System.Windows.Forms.CheckBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbFormat = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cbKeepLineBreaks = New System.Windows.Forms.CheckBox()
        Me.rtbText = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsImageInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.readzoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.rotateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotateRight90ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotateLeft90ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rotate180ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imageEnhancementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.deskewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.automaticRotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bitonalDespeckleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.borderRemovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.scaleTo300DPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ocrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.readToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupBox1.SuspendLayout()
        CType(Me.tbNonFreqWords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbNonDictWords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.chkEnableVigorousDespeckle)
        Me.groupBox1.Controls.Add(Me.chkLoadMainDict)
        Me.groupBox1.Controls.Add(Me.chkLoadFreqWordsDict)
        Me.groupBox1.Controls.Add(Me.tbNonFreqWords)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.tbNonDictWords)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.btnClearSelection)
        Me.groupBox1.Controls.Add(Me.lbLanguages)
        Me.groupBox1.Controls.Add(Me.cbCharacterSet)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.cbMode)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.cbContext)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.btnBrowseResourceFolder)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.tbResouceFolder)
        Me.groupBox1.Location = New System.Drawing.Point(2, 77)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Size = New System.Drawing.Size(412, 405)
        Me.groupBox1.TabIndex = 13
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Recognition Options"
        '
        'chkEnableVigorousDespeckle
        '
        Me.chkEnableVigorousDespeckle.AutoSize = True
        Me.chkEnableVigorousDespeckle.Location = New System.Drawing.Point(105, 67)
        Me.chkEnableVigorousDespeckle.Name = "chkEnableVigorousDespeckle"
        Me.chkEnableVigorousDespeckle.Size = New System.Drawing.Size(270, 17)
        Me.chkEnableVigorousDespeckle.TabIndex = 16
        Me.chkEnableVigorousDespeckle.Text = "Try to vigorously remove noise (vigorous despeckle)"
        Me.chkEnableVigorousDespeckle.UseVisualStyleBackColor = True
        '
        'chkLoadMainDict
        '
        Me.chkLoadMainDict.AutoSize = True
        Me.chkLoadMainDict.Checked = True
        Me.chkLoadMainDict.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLoadMainDict.Location = New System.Drawing.Point(9, 304)
        Me.chkLoadMainDict.Margin = New System.Windows.Forms.Padding(2)
        Me.chkLoadMainDict.Name = "chkLoadMainDict"
        Me.chkLoadMainDict.Size = New System.Drawing.Size(123, 17)
        Me.chkLoadMainDict.TabIndex = 2
        Me.chkLoadMainDict.Text = "Load main dictionary"
        Me.chkLoadMainDict.UseVisualStyleBackColor = True
        '
        'chkLoadFreqWordsDict
        '
        Me.chkLoadFreqWordsDict.AutoSize = True
        Me.chkLoadFreqWordsDict.Checked = True
        Me.chkLoadFreqWordsDict.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLoadFreqWordsDict.Location = New System.Drawing.Point(144, 304)
        Me.chkLoadFreqWordsDict.Margin = New System.Windows.Forms.Padding(2)
        Me.chkLoadFreqWordsDict.Name = "chkLoadFreqWordsDict"
        Me.chkLoadFreqWordsDict.Size = New System.Drawing.Size(171, 17)
        Me.chkLoadFreqWordsDict.TabIndex = 3
        Me.chkLoadFreqWordsDict.Text = "Load frequent words dictionary"
        Me.chkLoadFreqWordsDict.UseVisualStyleBackColor = True
        '
        'tbNonFreqWords
        '
        Me.tbNonFreqWords.Location = New System.Drawing.Point(104, 369)
        Me.tbNonFreqWords.Maximum = 100
        Me.tbNonFreqWords.Name = "tbNonFreqWords"
        Me.tbNonFreqWords.Size = New System.Drawing.Size(294, 45)
        Me.tbNonFreqWords.TabIndex = 15
        Me.tbNonFreqWords.Value = 10
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(6, 369)
        Me.label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(88, 36)
        Me.label9.TabIndex = 14
        Me.label9.Text = "Penalty for no frequent words:"
        '
        'tbNonDictWords
        '
        Me.tbNonDictWords.Location = New System.Drawing.Point(104, 330)
        Me.tbNonDictWords.Maximum = 100
        Me.tbNonDictWords.Name = "tbNonDictWords"
        Me.tbNonDictWords.Size = New System.Drawing.Size(294, 45)
        Me.tbNonDictWords.TabIndex = 13
        Me.tbNonDictWords.Value = 15
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(6, 334)
        Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(88, 36)
        Me.label8.TabIndex = 12
        Me.label8.Text = "Penalty for words no in the dict.:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(102, 243)
        Me.label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(151, 13)
        Me.label7.TabIndex = 11
        Me.label7.Text = "Multiple lang. ​​can be selected."
        '
        'btnClearSelection
        '
        Me.btnClearSelection.Location = New System.Drawing.Point(254, 240)
        Me.btnClearSelection.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearSelection.Name = "btnClearSelection"
        Me.btnClearSelection.Size = New System.Drawing.Size(145, 20)
        Me.btnClearSelection.TabIndex = 6
        Me.btnClearSelection.Text = "Clear selection"
        Me.btnClearSelection.UseMnemonic = False
        Me.btnClearSelection.UseVisualStyleBackColor = True
        '
        'lbLanguages
        '
        Me.lbLanguages.FormattingEnabled = True
        Me.lbLanguages.Location = New System.Drawing.Point(104, 141)
        Me.lbLanguages.MultiColumn = True
        Me.lbLanguages.Name = "lbLanguages"
        Me.lbLanguages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbLanguages.Size = New System.Drawing.Size(295, 95)
        Me.lbLanguages.Sorted = True
        Me.lbLanguages.TabIndex = 5
        '
        'cbCharacterSet
        '
        Me.cbCharacterSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCharacterSet.FormattingEnabled = True
        Me.cbCharacterSet.Items.AddRange(New Object() {"Full", "Numeric"})
        Me.cbCharacterSet.Location = New System.Drawing.Point(104, 266)
        Me.cbCharacterSet.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCharacterSet.Name = "cbCharacterSet"
        Me.cbCharacterSet.Size = New System.Drawing.Size(295, 21)
        Me.cbCharacterSet.TabIndex = 4
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(6, 268)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 13)
        Me.label4.TabIndex = 10
        Me.label4.Text = "Character set:"
        '
        'cbMode
        '
        Me.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMode.FormattingEnabled = True
        Me.cbMode.Items.AddRange(New Object() {"Favor accuracy", "Favor speed"})
        Me.cbMode.Location = New System.Drawing.Point(104, 116)
        Me.cbMode.Margin = New System.Windows.Forms.Padding(2)
        Me.cbMode.Name = "cbMode"
        Me.cbMode.Size = New System.Drawing.Size(295, 21)
        Me.cbMode.TabIndex = 3
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 120)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(37, 13)
        Me.label3.TabIndex = 8
        Me.label3.Text = "Mode:"
        '
        'cbContext
        '
        Me.cbContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbContext.FormattingEnabled = True
        Me.cbContext.Items.AddRange(New Object() {"Document", "Single column", "Single block", "Single block vertical", "Single line", "Single word", "Single word circle", "Single character", "Sparse text", "Single text raw line", "Segmentation Only", "OneOrTwoNumerics (Special context)", "Single line of numerics (Special context)", "MRZ (Special context)", "MICR E13C Line (Special context)", "MICR CMC7 Line (Special context)", "NumericLineML (Special context)", "HandwrittenNumericBoxML (Special context)"})
        Me.cbContext.Location = New System.Drawing.Point(104, 89)
        Me.cbContext.Margin = New System.Windows.Forms.Padding(2)
        Me.cbContext.Name = "cbContext"
        Me.cbContext.Size = New System.Drawing.Size(295, 21)
        Me.cbContext.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 92)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Context:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 141)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(58, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Language:"
        '
        'btnBrowseResourceFolder
        '
        Me.btnBrowseResourceFolder.Location = New System.Drawing.Point(254, 42)
        Me.btnBrowseResourceFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowseResourceFolder.Name = "btnBrowseResourceFolder"
        Me.btnBrowseResourceFolder.Size = New System.Drawing.Size(145, 20)
        Me.btnBrowseResourceFolder.TabIndex = 1
        Me.btnBrowseResourceFolder.Text = "Browse..."
        Me.btnBrowseResourceFolder.UseMnemonic = False
        Me.btnBrowseResourceFolder.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(6, 21)
        Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(85, 13)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Resource folder:"
        '
        'tbResouceFolder
        '
        Me.tbResouceFolder.Location = New System.Drawing.Point(104, 21)
        Me.tbResouceFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.tbResouceFolder.Name = "tbResouceFolder"
        Me.tbResouceFolder.ReadOnly = True
        Me.tbResouceFolder.Size = New System.Drawing.Size(295, 20)
        Me.tbResouceFolder.TabIndex = 0
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
        Me.gdViewer1.BackColor = System.Drawing.Color.Gray
        Me.gdViewer1.BackgroundImage = Nothing
        Me.gdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gdViewer1.ClipAnnotsToPageBounds = True
        Me.gdViewer1.ClipRegionsToPageBounds = True
        Me.gdViewer1.ContinuousViewMode = True
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
        Me.gdViewer1.Location = New System.Drawing.Point(418, 2)
        Me.gdViewer1.LockViewer = False
        Me.gdViewer1.MagnifierHeight = 90
        Me.gdViewer1.MagnifierWidth = 160
        Me.gdViewer1.MagnifierZoomX = 2.0!
        Me.gdViewer1.MagnifierZoomY = 2.0!
        Me.gdViewer1.Margin = New System.Windows.Forms.Padding(2)
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
        Me.tableLayoutPanel1.SetRowSpan(Me.gdViewer1, 3)
        Me.gdViewer1.ScrollBars = True
        Me.gdViewer1.ScrollLargeChange = CType(50, Short)
        Me.gdViewer1.ScrollSmallChange = CType(1, Short)
        Me.gdViewer1.SilentMode = True
        Me.gdViewer1.Size = New System.Drawing.Size(408, 168)
        Me.gdViewer1.TabIndex = 0
        Me.gdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.gdViewer1.Zoom = 1.0R
        Me.gdViewer1.ZoomCenterAtMousePosition = False
        Me.gdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100
        Me.gdViewer1.ZoomStep = 25
        '
        'cbDeskew
        '
        Me.cbDeskew.AutoSize = True
        Me.cbDeskew.Checked = True
        Me.cbDeskew.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDeskew.Location = New System.Drawing.Point(9, 20)
        Me.cbDeskew.Margin = New System.Windows.Forms.Padding(2)
        Me.cbDeskew.Name = "cbDeskew"
        Me.cbDeskew.Size = New System.Drawing.Size(134, 17)
        Me.cbDeskew.TabIndex = 0
        Me.cbDeskew.Text = "Enable skew detection"
        Me.cbDeskew.UseVisualStyleBackColor = True
        '
        'cbDetectOrientation
        '
        Me.cbDetectOrientation.AutoSize = True
        Me.cbDetectOrientation.Location = New System.Drawing.Point(9, 41)
        Me.cbDetectOrientation.Margin = New System.Windows.Forms.Padding(2)
        Me.cbDetectOrientation.Name = "cbDetectOrientation"
        Me.cbDetectOrientation.Size = New System.Drawing.Size(158, 17)
        Me.cbDetectOrientation.TabIndex = 1
        Me.cbDetectOrientation.Text = "Enable orientation detection"
        Me.cbDetectOrientation.UseVisualStyleBackColor = True
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox2, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox3, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.gdViewer1, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.rtbText, 1, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 4)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 4
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(822, 421)
        Me.tableLayoutPanel1.TabIndex = 13
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.chkEnablePreprocessing)
        Me.groupBox2.Controls.Add(Me.cbDeskew)
        Me.groupBox2.Controls.Add(Me.cbDetectOrientation)
        Me.groupBox2.Location = New System.Drawing.Point(2, 2)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Size = New System.Drawing.Size(412, 71)
        Me.groupBox2.TabIndex = 14
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Load Options"
        '
        'chkEnablePreprocessing
        '
        Me.chkEnablePreprocessing.AutoSize = True
        Me.chkEnablePreprocessing.Checked = True
        Me.chkEnablePreprocessing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnablePreprocessing.Location = New System.Drawing.Point(181, 20)
        Me.chkEnablePreprocessing.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEnablePreprocessing.Name = "chkEnablePreprocessing"
        Me.chkEnablePreprocessing.Size = New System.Drawing.Size(129, 17)
        Me.chkEnablePreprocessing.TabIndex = 2
        Me.chkEnablePreprocessing.Text = "Enable Preprocessing"
        Me.chkEnablePreprocessing.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btnSave)
        Me.groupBox3.Controls.Add(Me.cbFormat)
        Me.groupBox3.Controls.Add(Me.label6)
        Me.groupBox3.Controls.Add(Me.cbKeepLineBreaks)
        Me.groupBox3.Location = New System.Drawing.Point(2, 174)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox3.Size = New System.Drawing.Size(412, 98)
        Me.groupBox3.TabIndex = 15
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Output Options"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(254, 67)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 20)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save..."
        Me.btnSave.UseMnemonic = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbFormat
        '
        Me.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormat.FormattingEnabled = True
        Me.cbFormat.Items.AddRange(New Object() {"Unicode Text (Utf-8)", "Unicode Text (Utf-16)", "Html", "Office Open Xml (Docx)"})
        Me.cbFormat.Location = New System.Drawing.Point(104, 17)
        Me.cbFormat.Margin = New System.Windows.Forms.Padding(2)
        Me.cbFormat.Name = "cbFormat"
        Me.cbFormat.Size = New System.Drawing.Size(295, 21)
        Me.cbFormat.TabIndex = 11
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(6, 17)
        Me.label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 13)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Format:"
        '
        'cbKeepLineBreaks
        '
        Me.cbKeepLineBreaks.AutoSize = True
        Me.cbKeepLineBreaks.Location = New System.Drawing.Point(9, 42)
        Me.cbKeepLineBreaks.Margin = New System.Windows.Forms.Padding(2)
        Me.cbKeepLineBreaks.Name = "cbKeepLineBreaks"
        Me.cbKeepLineBreaks.Size = New System.Drawing.Size(105, 17)
        Me.cbKeepLineBreaks.TabIndex = 0
        Me.cbKeepLineBreaks.Text = "Keep line breaks"
        Me.cbKeepLineBreaks.UseVisualStyleBackColor = True
        '
        'rtbText
        '
        Me.rtbText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbText.Location = New System.Drawing.Point(419, 175)
        Me.rtbText.Name = "rtbText"
        Me.rtbText.ReadOnly = True
        Me.rtbText.Size = New System.Drawing.Size(406, 221)
        Me.rtbText.TabIndex = 1
        Me.rtbText.Text = ""
        '
        'StatusStrip1
        '
        Me.tableLayoutPanel1.SetColumnSpan(Me.StatusStrip1, 2)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsImageInfo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 399)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(828, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsImageInfo
        '
        Me.tsImageInfo.Name = "tsImageInfo"
        Me.tsImageInfo.Size = New System.Drawing.Size(0, 17)
        '
        'readzoneToolStripMenuItem
        '
        Me.readzoneToolStripMenuItem.Name = "readzoneToolStripMenuItem"
        Me.readzoneToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.readzoneToolStripMenuItem.Text = "Read &zone"
        '
        'menuStrip1
        '
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.viewToolStripMenuItem, Me.rotateToolStripMenuItem, Me.imageEnhancementToolStripMenuItem, Me.ocrToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.menuStrip1.Size = New System.Drawing.Size(822, 24)
        Me.menuStrip1.TabIndex = 12
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
        Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.zoomInToolStripMenuItem, Me.zoomOutToolStripMenuItem, Me.toolStripMenuItem2, Me.ignoreResolutionToolStripMenuItem, Me.toolStripSeparator1, Me.blocksToolStripMenuItem, Me.paragraphsToolStripMenuItem, Me.textLinesToolStripMenuItem, Me.wordsToolStripMenuItem, Me.charactersToolStripMenuItem})
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
        Me.blocksToolStripMenuItem.CheckOnClick = True
        Me.blocksToolStripMenuItem.Name = "blocksToolStripMenuItem"
        Me.blocksToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.blocksToolStripMenuItem.Text = "&Blocks"
        '
        'paragraphsToolStripMenuItem
        '
        Me.paragraphsToolStripMenuItem.CheckOnClick = True
        Me.paragraphsToolStripMenuItem.Name = "paragraphsToolStripMenuItem"
        Me.paragraphsToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.paragraphsToolStripMenuItem.Text = "&Paragraphs"
        '
        'textLinesToolStripMenuItem
        '
        Me.textLinesToolStripMenuItem.CheckOnClick = True
        Me.textLinesToolStripMenuItem.Name = "textLinesToolStripMenuItem"
        Me.textLinesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.textLinesToolStripMenuItem.Text = "Text &lines"
        '
        'wordsToolStripMenuItem
        '
        Me.wordsToolStripMenuItem.Checked = True
        Me.wordsToolStripMenuItem.CheckOnClick = True
        Me.wordsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem"
        Me.wordsToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.wordsToolStripMenuItem.Text = "&Words"
        '
        'charactersToolStripMenuItem
        '
        Me.charactersToolStripMenuItem.CheckOnClick = True
        Me.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem"
        Me.charactersToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.charactersToolStripMenuItem.Text = "&Characters"
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
        Me.imageEnhancementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deskewToolStripMenuItem, Me.automaticRotationToolStripMenuItem, Me.bitonalDespeckleToolStripMenuItem, Me.borderRemovalToolStripMenuItem, Me.scaleTo300DPIToolStripMenuItem})
        Me.imageEnhancementToolStripMenuItem.Name = "imageEnhancementToolStripMenuItem"
        Me.imageEnhancementToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.imageEnhancementToolStripMenuItem.Text = "Image &Enhancement"
        '
        'deskewToolStripMenuItem
        '
        Me.deskewToolStripMenuItem.Name = "deskewToolStripMenuItem"
        Me.deskewToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.deskewToolStripMenuItem.Text = "Automatic Deskew"
        '
        'automaticRotationToolStripMenuItem
        '
        Me.automaticRotationToolStripMenuItem.Name = "automaticRotationToolStripMenuItem"
        Me.automaticRotationToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.automaticRotationToolStripMenuItem.Text = "Automatic Rotation"
        '
        'bitonalDespeckleToolStripMenuItem
        '
        Me.bitonalDespeckleToolStripMenuItem.Name = "bitonalDespeckleToolStripMenuItem"
        Me.bitonalDespeckleToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.bitonalDespeckleToolStripMenuItem.Text = "Bitonal Despeckle"
        '
        'borderRemovalToolStripMenuItem
        '
        Me.borderRemovalToolStripMenuItem.Name = "borderRemovalToolStripMenuItem"
        Me.borderRemovalToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.borderRemovalToolStripMenuItem.Text = "Bitonal Border Removal"
        '
        'scaleTo300DPIToolStripMenuItem
        '
        Me.scaleTo300DPIToolStripMenuItem.Name = "scaleTo300DPIToolStripMenuItem"
        Me.scaleTo300DPIToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.scaleTo300DPIToolStripMenuItem.Text = "Scale to 300 DPI"
        '
        'ocrToolStripMenuItem
        '
        Me.ocrToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.readToolStripMenuItem, Me.readzoneToolStripMenuItem})
        Me.ocrToolStripMenuItem.Name = "ocrToolStripMenuItem"
        Me.ocrToolStripMenuItem.Size = New System.Drawing.Size(38, 22)
        Me.ocrToolStripMenuItem.Text = "&Ocr"
        '
        'readToolStripMenuItem
        '
        Me.readToolStripMenuItem.Name = "readToolStripMenuItem"
        Me.readToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.readToolStripMenuItem.Text = "&Read page"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 445)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET OCR Demo"
        Me.groupBox1.ResumeLayout(false)
        Me.groupBox1.PerformLayout
        CType(Me.tbNonFreqWords,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbNonDictWords,System.ComponentModel.ISupportInitialize).EndInit
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.tableLayoutPanel1.PerformLayout
        Me.groupBox2.ResumeLayout(false)
        Me.groupBox2.PerformLayout
        Me.groupBox3.ResumeLayout(false)
        Me.groupBox3.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents chkLoadMainDict As CheckBox
    Private WithEvents chkLoadFreqWordsDict As CheckBox
    Private WithEvents tbNonFreqWords As TrackBar
    Private WithEvents label9 As Label
    Private WithEvents tbNonDictWords As TrackBar
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents btnClearSelection As Button
    Private WithEvents lbLanguages As ListBox
    Private WithEvents cbCharacterSet As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents cbMode As ComboBox
    Private WithEvents label3 As Label
    Private WithEvents cbContext As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents btnBrowseResourceFolder As Button
    Private WithEvents label5 As Label
    Private WithEvents tbResouceFolder As TextBox
    Private WithEvents gdViewer1 As GdPicture14.GdViewer
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents cbDeskew As CheckBox
    Private WithEvents cbDetectOrientation As CheckBox
    Private WithEvents readzoneToolStripMenuItem As ToolStripMenuItem
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
    Private WithEvents rotateToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotateRight90ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotateLeft90ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rotate180ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents imageEnhancementToolStripMenuItem As ToolStripMenuItem
    Private WithEvents deskewToolStripMenuItem As ToolStripMenuItem
    Private WithEvents automaticRotationToolStripMenuItem As ToolStripMenuItem
    Private WithEvents bitonalDespeckleToolStripMenuItem As ToolStripMenuItem
    Private WithEvents borderRemovalToolStripMenuItem As ToolStripMenuItem
    Private WithEvents scaleTo300DPIToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ocrToolStripMenuItem As ToolStripMenuItem
    Private WithEvents readToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rtbText As RichTextBox
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents btnSave As Button
    Private WithEvents cbFormat As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents cbKeepLineBreaks As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Private WithEvents tsImageInfo As ToolStripStatusLabel
    Friend WithEvents chkEnableVigorousDespeckle As CheckBox
    Private WithEvents chkEnablePreprocessing As CheckBox
End Class
