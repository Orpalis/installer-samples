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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.chkUnderlined = New System.Windows.Forms.CheckBox()
        Me.btZoomIN = New System.Windows.Forms.Button()
        Me.btZoomOUT = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.txtFontSize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default
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
        Me.GdViewer1.Location = New System.Drawing.Point(7, 9)
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
        Me.GdViewer1.RegionsAreEditable = True
        Me.GdViewer1.RenderGdPictureAnnots = True
        Me.GdViewer1.ScrollBars = True
        Me.GdViewer1.ScrollLargeChange = CType(50, Short)
        Me.GdViewer1.ScrollSmallChange = CType(1, Short)
        Me.GdViewer1.SilentMode = False
        Me.GdViewer1.Size = New System.Drawing.Size(1207, 635)
        Me.GdViewer1.TabIndex = 18
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 1.0R
        Me.GdViewer1.ZoomCenterAtMousePosition = False
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100
        Me.GdViewer1.ZoomStep = 25
        '
        'chkUnderlined
        '
        Me.chkUnderlined.BackColor = System.Drawing.SystemColors.Control
        Me.chkUnderlined.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUnderlined.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUnderlined.Location = New System.Drawing.Point(11, 740)
        Me.chkUnderlined.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkUnderlined.Name = "chkUnderlined"
        Me.chkUnderlined.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUnderlined.Size = New System.Drawing.Size(105, 18)
        Me.chkUnderlined.TabIndex = 16
        Me.chkUnderlined.TabStop = False
        Me.chkUnderlined.Text = "Underlined"
        Me.chkUnderlined.UseVisualStyleBackColor = False
        '
        'btZoomIN
        '
        Me.btZoomIN.BackColor = System.Drawing.SystemColors.Control
        Me.btZoomIN.Cursor = System.Windows.Forms.Cursors.Default
        Me.btZoomIN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btZoomIN.Location = New System.Drawing.Point(1184, 651)
        Me.btZoomIN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btZoomIN.Name = "btZoomIN"
        Me.btZoomIN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btZoomIN.Size = New System.Drawing.Size(31, 23)
        Me.btZoomIN.TabIndex = 14
        Me.btZoomIN.TabStop = False
        Me.btZoomIN.Text = "+"
        Me.btZoomIN.UseVisualStyleBackColor = False
        '
        'btZoomOUT
        '
        Me.btZoomOUT.BackColor = System.Drawing.SystemColors.Control
        Me.btZoomOUT.Cursor = System.Windows.Forms.Cursors.Default
        Me.btZoomOUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btZoomOUT.Location = New System.Drawing.Point(1149, 651)
        Me.btZoomOUT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btZoomOUT.Name = "btZoomOUT"
        Me.btZoomOUT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btZoomOUT.Size = New System.Drawing.Size(31, 23)
        Me.btZoomOUT.TabIndex = 15
        Me.btZoomOUT.TabStop = False
        Me.btZoomOUT.Text = "-"
        Me.btZoomOUT.UseVisualStyleBackColor = False
        '
        'chkItalic
        '
        Me.chkItalic.BackColor = System.Drawing.SystemColors.Control
        Me.chkItalic.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkItalic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkItalic.Location = New System.Drawing.Point(11, 715)
        Me.chkItalic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkItalic.Size = New System.Drawing.Size(65, 18)
        Me.chkItalic.TabIndex = 13
        Me.chkItalic.TabStop = False
        Me.chkItalic.Text = "Italic"
        Me.chkItalic.UseVisualStyleBackColor = False
        '
        'chkBold
        '
        Me.chkBold.BackColor = System.Drawing.SystemColors.Control
        Me.chkBold.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBold.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBold.Location = New System.Drawing.Point(11, 686)
        Me.chkBold.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBold.Size = New System.Drawing.Size(76, 23)
        Me.chkBold.TabIndex = 12
        Me.chkBold.TabStop = False
        Me.chkBold.Text = "Bold"
        Me.chkBold.UseVisualStyleBackColor = False
        '
        'txtFontSize
        '
        Me.txtFontSize.AcceptsReturn = True
        Me.txtFontSize.BackColor = System.Drawing.SystemColors.Window
        Me.txtFontSize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFontSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFontSize.Location = New System.Drawing.Point(83, 651)
        Me.txtFontSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFontSize.MaxLength = 0
        Me.txtFontSize.Name = "txtFontSize"
        Me.txtFontSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFontSize.Size = New System.Drawing.Size(45, 22)
        Me.txtFontSize.TabIndex = 11
        Me.txtFontSize.TabStop = False
        Me.txtFontSize.Text = "9"
        Me.txtFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(11, 656)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Font Size :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(525, 656)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(200, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Click on the viewer to write text"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 766)
        Me.Controls.Add(Me.GdViewer1)
        Me.Controls.Add(Me.chkUnderlined)
        Me.Controls.Add(Me.btZoomIN)
        Me.Controls.Add(Me.btZoomOUT)
        Me.Controls.Add(Me.chkItalic)
        Me.Controls.Add(Me.chkBold)
        Me.Controls.Add(Me.txtFontSize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Text Writter Sample  -  http://www.gdpicture.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GdViewer1 As GdViewer
    Public WithEvents chkUnderlined As System.Windows.Forms.CheckBox
    Public WithEvents btZoomIN As System.Windows.Forms.Button
    Public WithEvents btZoomOUT As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents chkItalic As System.Windows.Forms.CheckBox
    Public WithEvents chkBold As System.Windows.Forms.CheckBox
    Public WithEvents txtFontSize As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Timer1 As System.Windows.Forms.Timer
End Class
