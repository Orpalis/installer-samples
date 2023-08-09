Imports GdPicture14
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.HScroll4 = New System.Windows.Forms.HScrollBar()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HScroll3 = New System.Windows.Forms.HScrollBar()
        Me.HScroll2 = New System.Windows.Forms.HScrollBar()
        Me.HScroll1 = New System.Windows.Forms.HScrollBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(718, 666)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GdViewer1
        '
        Me.GdViewer1.AllowDrop = True
        Me.GdViewer1.AllowDropFile = False
        Me.GdViewer1.AnimateGIF = False
        Me.GdViewer1.AnnotationDropShadow = False
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
        Me.GdViewer1.Location = New System.Drawing.Point(5, 33)
        Me.GdViewer1.LockViewer = False
        Me.GdViewer1.MagnifierHeight = 90
        Me.GdViewer1.MagnifierWidth = 160
        Me.GdViewer1.MagnifierZoomX = 2.0!
        Me.GdViewer1.MagnifierZoomY = 2.0!
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
        Me.GdViewer1.Size = New System.Drawing.Size(788, 522)
        Me.GdViewer1.TabIndex = 24
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 0.001R
        Me.GdViewer1.ZoomCenterAtMousePosition = False
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer1.ZoomStep = 25
        '
        'HScroll4
        '
        Me.HScroll4.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScroll4.Location = New System.Drawing.Point(404, 630)
        Me.HScroll4.Maximum = 108
        Me.HScroll4.Minimum = -100
        Me.HScroll4.Name = "HScroll4"
        Me.HScroll4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HScroll4.Size = New System.Drawing.Size(373, 21)
        Me.HScroll4.TabIndex = 21
        Me.HScroll4.TabStop = True
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HScroll3
        '
        Me.HScroll3.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScroll3.Location = New System.Drawing.Point(404, 578)
        Me.HScroll3.Maximum = 109
        Me.HScroll3.Minimum = -99
        Me.HScroll3.Name = "HScroll3"
        Me.HScroll3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HScroll3.Size = New System.Drawing.Size(373, 21)
        Me.HScroll3.TabIndex = 19
        Me.HScroll3.TabStop = True
        '
        'HScroll2
        '
        Me.HScroll2.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScroll2.Location = New System.Drawing.Point(14, 630)
        Me.HScroll2.Maximum = 109
        Me.HScroll2.Minimum = -100
        Me.HScroll2.Name = "HScroll2"
        Me.HScroll2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HScroll2.Size = New System.Drawing.Size(373, 21)
        Me.HScroll2.TabIndex = 17
        Me.HScroll2.TabStop = True
        '
        'HScroll1
        '
        Me.HScroll1.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScroll1.Location = New System.Drawing.Point(14, 578)
        Me.HScroll1.Maximum = 109
        Me.HScroll1.Minimum = -100
        Me.HScroll1.Name = "HScroll1"
        Me.HScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HScroll1.Size = New System.Drawing.Size(373, 21)
        Me.HScroll1.TabIndex = 15
        Me.HScroll1.TabStop = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(402, 610)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Saturation :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(402, 558)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Gamma :"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 610)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Contrast :"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 558)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Brightness :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 697)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GdViewer1)
        Me.Controls.Add(Me.HScroll4)
        Me.Controls.Add(Me.HScroll3)
        Me.Controls.Add(Me.HScroll2)
        Me.Controls.Add(Me.HScroll1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Adjusting gamma, brightness, saturation & contrast Demo  -  http:" &
    "//www.gdpicture.com"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GdViewer1 As GdViewer
    Public WithEvents HScroll4 As System.Windows.Forms.HScrollBar
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents HScroll3 As System.Windows.Forms.HScrollBar
    Public WithEvents HScroll2 As System.Windows.Forms.HScrollBar
    Public WithEvents HScroll1 As System.Windows.Forms.HScrollBar
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
