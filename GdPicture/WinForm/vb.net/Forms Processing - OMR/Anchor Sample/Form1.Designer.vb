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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GdViewer2 = New GdPicture14.GdViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1260, 732)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1252, 703)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Template Designer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer3.Panel1.Controls.Add(Me.NumericUpDown2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GdViewer2)
        Me.SplitContainer3.Size = New System.Drawing.Size(1244, 695)
        Me.SplitContainer3.SplitterDistance = 452
        Me.SplitContainer3.SplitterWidth = 5
        Me.SplitContainer3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 263)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "- height (mm):"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(159, 261)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(79, 22)
        Me.NumericUpDown2.TabIndex = 10
        Me.NumericUpDown2.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 235)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "- width (mm):"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(159, 233)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(79, 22)
        Me.NumericUpDown1.TabIndex = 8
        Me.NumericUpDown1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 203)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Size of the area to search:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "3- Click on the Testing bottom Tab"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(430, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "2- Draw a box around a shape on the Template image (the anchor)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "1- Open an Image (the Template)"
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.Location = New System.Drawing.Point(0, 641)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(452, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Load Template Image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GdViewer2
        '
        Me.GdViewer2.AllowDropFile = False
        Me.GdViewer2.AnimateGIF = False
        Me.GdViewer2.AnnotationDropShadow = true
        Me.GdViewer2.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GdViewer2.AnnotationResizeRotateHandlesScale = 1.0!
        Me.GdViewer2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.GdViewer2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.GdViewer2.BackColor = System.Drawing.Color.Black
        Me.GdViewer2.BackgroundImage = Nothing
        Me.GdViewer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GdViewer2.ContinuousViewMode = True
        Me.GdViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdViewer2.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.GdViewer2.DisplayQualityAuto = False
        Me.GdViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GdViewer2.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.GdViewer2.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.GdViewer2.EnableDeferredPainting = True
        Me.GdViewer2.EnabledProgressBar = True
        Me.GdViewer2.EnableICM = False
        Me.GdViewer2.EnableMenu = True
        Me.GdViewer2.EnableMouseWheel = True
        Me.GdViewer2.EnableTextSelection = True
        Me.GdViewer2.ForceScrollBars = False
        Me.GdViewer2.ForeColor = System.Drawing.Color.Black
        Me.GdViewer2.Gamma = 1.0!
        Me.GdViewer2.HQAnnotationRendering = True
        Me.GdViewer2.IgnoreDocumentResolution = False
        Me.GdViewer2.KeepDocumentPosition = False
        Me.GdViewer2.Location = New System.Drawing.Point(0, 0)
        Me.GdViewer2.LockViewer = False
        Me.GdViewer2.MagnifierHeight = 90
        Me.GdViewer2.MagnifierWidth = 160
        Me.GdViewer2.MagnifierZoomX = 2.0!
        Me.GdViewer2.MagnifierZoomY = 2.0!
        Me.GdViewer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GdViewer2.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.GdViewer2.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
        Me.GdViewer2.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom
        Me.GdViewer2.Name = "GdViewer2"
        Me.GdViewer2.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView
        Me.GdViewer2.PdfDisplayFormField = True
        Me.GdViewer2.PdfEnableFileLinks = True
        Me.GdViewer2.PdfEnableLinks = True
        Me.GdViewer2.PdfIncreaseTextContrast = False
        Me.GdViewer2.PdfShowDialogForPassword = True
        Me.GdViewer2.PdfShowOpenFileDialogForDecryption = True
        Me.GdViewer2.PdfVerifyDigitalCertificates = False
        Me.GdViewer2.RectBorderColor = System.Drawing.Color.Black
        Me.GdViewer2.RectBorderSize = 1
        Me.GdViewer2.RectIsEditable = False
        Me.GdViewer2.RegionsAreEditable = True
        Me.GdViewer2.RenderGdPictureAnnots = True
        Me.GdViewer2.ScrollBars = True
        Me.GdViewer2.ScrollLargeChange = CType(50, Short)
        Me.GdViewer2.ScrollSmallChange = CType(1, Short)
        Me.GdViewer2.SilentMode = True
        Me.GdViewer2.Size = New System.Drawing.Size(787, 695)
        Me.GdViewer2.TabIndex = 0
        Me.GdViewer2.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer2.Zoom = 0.001R
        Me.GdViewer2.ZoomCenterAtMousePosition = False
        Me.GdViewer2.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer2.ZoomStep = 25
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(1252, 703)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Testing"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GdViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1244, 695)
        Me.SplitContainer1.SplitterDistance = 311
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.CheckBox1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Size = New System.Drawing.Size(311, 695)
        Me.SplitContainer2.SplitterDistance = 577
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(311, 577)
        Me.ListBox1.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(4, 7)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 21)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "High Speed Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(311, 39)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Add Images"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.Location = New System.Drawing.Point(0, 39)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(311, 39)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Clear List"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 78)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(311, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Run !"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.GdViewer1.RegionsAreEditable = False
        Me.GdViewer1.RenderGdPictureAnnots = True
        Me.GdViewer1.ScrollBars = True
        Me.GdViewer1.ScrollLargeChange = CType(50, Short)
        Me.GdViewer1.ScrollSmallChange = CType(1, Short)
        Me.GdViewer1.SilentMode = True
        Me.GdViewer1.Size = New System.Drawing.Size(928, 695)
        Me.GdViewer1.TabIndex = 0
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 0.001R
        Me.GdViewer1.ZoomCenterAtMousePosition = False
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer1.ZoomStep = 25
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 732)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - OMR - Anchor Sample  -  http://www.gdpicture.com"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GdViewer1 As GdPicture14.GdViewer
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents GdViewer2 As GdPicture14.GdViewer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
