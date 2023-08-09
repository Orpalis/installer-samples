Imports GdPicture14

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
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.txtPenSize = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtAlpha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GdViewer1
        '
        Me.GdViewer1.AllowDrop = True
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
        Me.GdViewer1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.GdViewer1.DisplayQualityAuto = False
        Me.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.GdViewer1.EnableDeferredPainting = False
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
        Me.GdViewer1.Location = New System.Drawing.Point(8, 119)
        Me.GdViewer1.LockViewer = False
        Me.GdViewer1.MagnifierHeight = 90
        Me.GdViewer1.MagnifierWidth = 160
        Me.GdViewer1.MagnifierZoomX = 2.0!
        Me.GdViewer1.MagnifierZoomY = 2.0!
        Me.GdViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModeDefault
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
        Me.GdViewer1.SilentMode = False
        Me.GdViewer1.Size = New System.Drawing.Size(1279, 789)
        Me.GdViewer1.TabIndex = 31
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 1.0R
        Me.GdViewer1.ZoomCenterAtMousePosition = False
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100
        Me.GdViewer1.ZoomStep = 25
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(8, 79)
        Me.Command3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(81, 33)
        Me.Command3.TabIndex = 30
        Me.Command3.Text = "Clear"
        Me.Command3.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(1181, 76)
        Me.Command2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(49, 33)
        Me.Command2.TabIndex = 29
        Me.Command2.Text = "-"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(1237, 76)
        Me.Command1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(49, 33)
        Me.Command1.TabIndex = 28
        Me.Command1.Text = "+"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'txtPenSize
        '
        Me.txtPenSize.AcceptsReturn = True
        Me.txtPenSize.BackColor = System.Drawing.SystemColors.Window
        Me.txtPenSize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPenSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPenSize.Location = New System.Drawing.Point(344, 7)
        Me.txtPenSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPenSize.MaxLength = 0
        Me.txtPenSize.Name = "txtPenSize"
        Me.txtPenSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPenSize.Size = New System.Drawing.Size(37, 22)
        Me.txtPenSize.TabIndex = 27
        Me.txtPenSize.Text = "5"
        '
        'txtBlue
        '
        Me.txtBlue.AcceptsReturn = True
        Me.txtBlue.BackColor = System.Drawing.SystemColors.Window
        Me.txtBlue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBlue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBlue.Location = New System.Drawing.Point(189, 10)
        Me.txtBlue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBlue.MaxLength = 0
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBlue.Size = New System.Drawing.Size(45, 22)
        Me.txtBlue.TabIndex = 24
        Me.txtBlue.Text = "255"
        '
        'txtGreen
        '
        Me.txtGreen.AcceptsReturn = True
        Me.txtGreen.BackColor = System.Drawing.SystemColors.Window
        Me.txtGreen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGreen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGreen.Location = New System.Drawing.Point(131, 10)
        Me.txtGreen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGreen.MaxLength = 0
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGreen.Size = New System.Drawing.Size(45, 22)
        Me.txtGreen.TabIndex = 22
        Me.txtGreen.Text = "120"
        '
        'txtRed
        '
        Me.txtRed.AcceptsReturn = True
        Me.txtRed.BackColor = System.Drawing.SystemColors.Window
        Me.txtRed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRed.Location = New System.Drawing.Point(72, 10)
        Me.txtRed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRed.MaxLength = 0
        Me.txtRed.Name = "txtRed"
        Me.txtRed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRed.Size = New System.Drawing.Size(45, 22)
        Me.txtRed.TabIndex = 20
        Me.txtRed.Text = "120"
        '
        'txtAlpha
        '
        Me.txtAlpha.AcceptsReturn = True
        Me.txtAlpha.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlpha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAlpha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAlpha.Location = New System.Drawing.Point(13, 10)
        Me.txtAlpha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAlpha.MaxLength = 0
        Me.txtAlpha.Name = "txtAlpha"
        Me.txtAlpha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAlpha.Size = New System.Drawing.Size(45, 22)
        Me.txtAlpha.TabIndex = 18
        Me.txtAlpha.Text = "255"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(275, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Pen Size:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(195, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Blue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(131, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Green"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(80, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Alpha"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 914)
        Me.Controls.Add(Me.GdViewer1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.txtPenSize)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtGreen)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.txtAlpha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Real time line drawing Sample  -  http://www.gdpicture.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GdViewer1 As GdViewer
    Public WithEvents Command3 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents txtPenSize As System.Windows.Forms.TextBox
    Public WithEvents txtBlue As System.Windows.Forms.TextBox
    Public WithEvents txtGreen As System.Windows.Forms.TextBox
    Public WithEvents txtRed As System.Windows.Forms.TextBox
    Public WithEvents txtAlpha As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
End Class
