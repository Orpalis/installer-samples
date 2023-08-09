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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstDevices = New System.Windows.Forms.ListBox()
        Me.chkRemoveDots = New System.Windows.Forms.CheckBox()
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.chkAutoDesk = New System.Windows.Forms.CheckBox()
        Me.chkRotate180 = New System.Windows.Forms.CheckBox()
        Me.chkRotate90 = New System.Windows.Forms.CheckBox()
        Me.Command12 = New System.Windows.Forms.Button()
        Me.chkHideUI = New System.Windows.Forms.CheckBox()
        Me.ChkAutoCrop = New System.Windows.Forms.CheckBox()
        Me.ChkNeg = New System.Windows.Forms.CheckBox()
        Me.Command6 = New System.Windows.Forms.Button()
        Me.chkPreview = New System.Windows.Forms.CheckBox()
        Me.Command4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Line2 = New System.Windows.Forms.Label()
        Me.chkRemoveHP = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(14, 700)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 1)
        Me.Label3.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 682)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Examples :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 1)
        Me.Label1.TabIndex = 68
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 17)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "WIA Devices:"
        '
        'lstDevices
        '
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.ItemHeight = 16
        Me.lstDevices.Location = New System.Drawing.Point(16, 45)
        Me.lstDevices.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(508, 84)
        Me.lstDevices.TabIndex = 66
        '
        'chkRemoveDots
        '
        Me.chkRemoveDots.BackColor = System.Drawing.SystemColors.Control
        Me.chkRemoveDots.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRemoveDots.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRemoveDots.Location = New System.Drawing.Point(254, 303)
        Me.chkRemoveDots.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRemoveDots.Name = "chkRemoveDots"
        Me.chkRemoveDots.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRemoveDots.Size = New System.Drawing.Size(234, 23)
        Me.chkRemoveDots.TabIndex = 65
        Me.chkRemoveDots.Text = "Remove isolated dots"
        Me.chkRemoveDots.UseVisualStyleBackColor = False
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
        Me.GdViewer1.Location = New System.Drawing.Point(550, 9)
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
        Me.GdViewer1.Size = New System.Drawing.Size(940, 883)
        Me.GdViewer1.TabIndex = 64
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 0.001R
        Me.GdViewer1.ZoomCenterAtMousePosition = False
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer1.ZoomStep = 25
        '
        'chkAutoDesk
        '
        Me.chkAutoDesk.BackColor = System.Drawing.SystemColors.Control
        Me.chkAutoDesk.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAutoDesk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAutoDesk.Location = New System.Drawing.Point(20, 303)
        Me.chkAutoDesk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAutoDesk.Name = "chkAutoDesk"
        Me.chkAutoDesk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAutoDesk.Size = New System.Drawing.Size(122, 23)
        Me.chkAutoDesk.TabIndex = 63
        Me.chkAutoDesk.Text = "Auto Deskew"
        Me.chkAutoDesk.UseVisualStyleBackColor = False
        '
        'chkRotate180
        '
        Me.chkRotate180.BackColor = System.Drawing.SystemColors.Control
        Me.chkRotate180.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRotate180.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRotate180.Location = New System.Drawing.Point(254, 268)
        Me.chkRotate180.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRotate180.Name = "chkRotate180"
        Me.chkRotate180.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRotate180.Size = New System.Drawing.Size(170, 23)
        Me.chkRotate180.TabIndex = 61
        Me.chkRotate180.Text = "Rotate 180°"
        Me.chkRotate180.UseVisualStyleBackColor = False
        '
        'chkRotate90
        '
        Me.chkRotate90.BackColor = System.Drawing.SystemColors.Control
        Me.chkRotate90.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRotate90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRotate90.Location = New System.Drawing.Point(254, 234)
        Me.chkRotate90.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRotate90.Name = "chkRotate90"
        Me.chkRotate90.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRotate90.Size = New System.Drawing.Size(170, 23)
        Me.chkRotate90.TabIndex = 60
        Me.chkRotate90.Text = "Rotate 90°"
        Me.chkRotate90.UseVisualStyleBackColor = False
        '
        'Command12
        '
        Me.Command12.BackColor = System.Drawing.SystemColors.Control
        Me.Command12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command12.Location = New System.Drawing.Point(258, 781)
        Me.Command12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Command12.Name = "Command12"
        Me.Command12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command12.Size = New System.Drawing.Size(238, 55)
        Me.Command12.TabIndex = 59
        Me.Command12.Text = "Demo 5: Scan all document feeder  into multipage PDF"
        Me.Command12.UseVisualStyleBackColor = False
        '
        'chkHideUI
        '
        Me.chkHideUI.BackColor = System.Drawing.SystemColors.Control
        Me.chkHideUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHideUI.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHideUI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkHideUI.Location = New System.Drawing.Point(438, 143)
        Me.chkHideUI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkHideUI.Name = "chkHideUI"
        Me.chkHideUI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHideUI.Size = New System.Drawing.Size(86, 21)
        Me.chkHideUI.TabIndex = 57
        Me.chkHideUI.Text = "Hide UI"
        Me.chkHideUI.UseVisualStyleBackColor = False
        '
        'ChkAutoCrop
        '
        Me.ChkAutoCrop.BackColor = System.Drawing.SystemColors.Control
        Me.ChkAutoCrop.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkAutoCrop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkAutoCrop.Location = New System.Drawing.Point(20, 268)
        Me.ChkAutoCrop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkAutoCrop.Name = "ChkAutoCrop"
        Me.ChkAutoCrop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkAutoCrop.Size = New System.Drawing.Size(210, 23)
        Me.ChkAutoCrop.TabIndex = 56
        Me.ChkAutoCrop.Text = "Remove Black Borders"
        Me.ChkAutoCrop.UseVisualStyleBackColor = False
        '
        'ChkNeg
        '
        Me.ChkNeg.BackColor = System.Drawing.SystemColors.Control
        Me.ChkNeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkNeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkNeg.Location = New System.Drawing.Point(20, 234)
        Me.ChkNeg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNeg.Name = "ChkNeg"
        Me.ChkNeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkNeg.Size = New System.Drawing.Size(170, 23)
        Me.ChkNeg.TabIndex = 55
        Me.ChkNeg.Text = "Negative "
        Me.ChkNeg.UseVisualStyleBackColor = False
        '
        'Command6
        '
        Me.Command6.BackColor = System.Drawing.SystemColors.Control
        Me.Command6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command6.Location = New System.Drawing.Point(16, 138)
        Me.Command6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Command6.Name = "Command6"
        Me.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command6.Size = New System.Drawing.Size(136, 26)
        Me.Command6.TabIndex = 53
        Me.Command6.Text = "Source setup..."
        Me.Command6.UseVisualStyleBackColor = False
        '
        'chkPreview
        '
        Me.chkPreview.BackColor = System.Drawing.SystemColors.Control
        Me.chkPreview.Checked = True
        Me.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPreview.Location = New System.Drawing.Point(1402, 900)
        Me.chkPreview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPreview.Name = "chkPreview"
        Me.chkPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPreview.Size = New System.Drawing.Size(86, 21)
        Me.chkPreview.TabIndex = 52
        Me.chkPreview.Text = "Preview"
        Me.chkPreview.UseVisualStyleBackColor = False
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(12, 719)
        Me.Command4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(238, 55)
        Me.Command4.TabIndex = 51
        Me.Command4.Text = "Demo 1: Scan one document to jpeg file (acquire.jpg)"
        Me.Command4.UseVisualStyleBackColor = False
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(12, 781)
        Me.Command3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(238, 55)
        Me.Command3.TabIndex = 50
        Me.Command3.Text = "Demo 2: Scan one document to pdf file (acquire.pdf)"
        Me.Command3.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(258, 719)
        Me.Command2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(238, 55)
        Me.Command2.TabIndex = 49
        Me.Command2.Text = "Demo 4: Scan all document feeder (ADF) into jpeg files"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(12, 844)
        Me.Command1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(238, 55)
        Me.Command1.TabIndex = 48
        Me.Command1.Text = "Demo 3: Scan all document feeder (ADF) into multipage TIFF image multipage.tif"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 203)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(120, 17)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Image Processing"
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line2.Location = New System.Drawing.Point(14, 223)
        Me.Line2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(512, 1)
        Me.Line2.TabIndex = 62
        '
        'chkRemoveHP
        '
        Me.chkRemoveHP.BackColor = System.Drawing.SystemColors.Control
        Me.chkRemoveHP.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRemoveHP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRemoveHP.Location = New System.Drawing.Point(20, 335)
        Me.chkRemoveHP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRemoveHP.Name = "chkRemoveHP"
        Me.chkRemoveHP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRemoveHP.Size = New System.Drawing.Size(210, 23)
        Me.chkRemoveHP.TabIndex = 71
        Me.chkRemoveHP.Text = "Remove Hole Punches"
        Me.chkRemoveHP.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1502, 545)
        Me.Controls.Add(Me.chkRemoveHP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lstDevices)
        Me.Controls.Add(Me.chkRemoveDots)
        Me.Controls.Add(Me.GdViewer1)
        Me.Controls.Add(Me.chkAutoDesk)
        Me.Controls.Add(Me.chkRotate180)
        Me.Controls.Add(Me.chkRotate90)
        Me.Controls.Add(Me.Command12)
        Me.Controls.Add(Me.chkHideUI)
        Me.Controls.Add(Me.ChkAutoCrop)
        Me.Controls.Add(Me.ChkNeg)
        Me.Controls.Add(Me.Command6)
        Me.Controls.Add(Me.chkPreview)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Line2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - WIA Acquisition Sample  -  http://www.gdpicture.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lstDevices As System.Windows.Forms.ListBox
    Public WithEvents chkRemoveDots As System.Windows.Forms.CheckBox
    Friend WithEvents GdViewer1 As GdViewer
    Public WithEvents chkAutoDesk As System.Windows.Forms.CheckBox
    Public WithEvents chkRotate180 As System.Windows.Forms.CheckBox
    Public WithEvents chkRotate90 As System.Windows.Forms.CheckBox
    Public WithEvents Command12 As System.Windows.Forms.Button
    Public WithEvents chkHideUI As System.Windows.Forms.CheckBox
    Public WithEvents ChkAutoCrop As System.Windows.Forms.CheckBox
    Public WithEvents ChkNeg As System.Windows.Forms.CheckBox
    Public WithEvents Command6 As System.Windows.Forms.Button
    Public WithEvents chkPreview As System.Windows.Forms.CheckBox
    Public WithEvents Command4 As System.Windows.Forms.Button
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Command3 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents chkRemoveHP As System.Windows.Forms.CheckBox
End Class
