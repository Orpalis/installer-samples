<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtImageStampPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCertPath = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCertPass = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.lbLocation = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSignerName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContactInfo = New System.Windows.Forms.TextBox()
        Me.chkValidationMark = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optCertLevelFormFillAnnot = New System.Windows.Forms.RadioButton()
        Me.optCertLevelFormFill = New System.Windows.Forms.RadioButton()
        Me.optCertLevelNoChanges = New System.Windows.Forms.RadioButton()
        Me.optCertLevelNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optHash384 = New System.Windows.Forms.RadioButton()
        Me.optHash224 = New System.Windows.Forms.RadioButton()
        Me.optHash512 = New System.Windows.Forms.RadioButton()
        Me.optHash256 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTSPassword = New System.Windows.Forms.TextBox()
        Me.txtTSUser = New System.Windows.Forms.TextBox()
        Me.txtTSServer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkLinearize = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optModeCADES = New System.Windows.Forms.RadioButton()
        Me.optModePPKLITE = New System.Windows.Forms.RadioButton()
        Me.optModePPKMS = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(493, 203)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 31)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtImageStampPath
        '
        Me.txtImageStampPath.Location = New System.Drawing.Point(16, 207)
        Me.txtImageStampPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImageStampPath.Name = "txtImageStampPath"
        Me.txtImageStampPath.Size = New System.Drawing.Size(471, 22)
        Me.txtImageStampPath.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 186)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select image file:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Select certificate file from P12 (required):"
        '
        'txtCertPath
        '
        Me.txtCertPath.Location = New System.Drawing.Point(16, 30)
        Me.txtCertPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCertPath.Name = "txtCertPath"
        Me.txtCertPath.Size = New System.Drawing.Size(471, 22)
        Me.txtCertPath.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(493, 26)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Set certificate password (required):"
        '
        'txtCertPass
        '
        Me.txtCertPass.Location = New System.Drawing.Point(16, 78)
        Me.txtCertPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCertPass.Name = "txtCertPass"
        Me.txtCertPass.Size = New System.Drawing.Size(471, 22)
        Me.txtCertPass.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(181, 532)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(365, 73)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Open PDF to sign ..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(565, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(636, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Draw a rectangle over the displayed document, where you want to place the signatu" &
    "re."
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
        Me.GdViewer1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GdViewer1.BackgroundImage = Nothing
        Me.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GdViewer1.ContinuousViewMode = True
        Me.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityAutomatic
        Me.GdViewer1.DisplayQualityAuto = True
        Me.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentTopLeft
        Me.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionTopLeft
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
        Me.GdViewer1.Location = New System.Drawing.Point(571, 98)
        Me.GdViewer1.LockViewer = False
        Me.GdViewer1.MagnifierHeight = 90
        Me.GdViewer1.MagnifierWidth = 160
        Me.GdViewer1.MagnifierZoomX = 2.0!
        Me.GdViewer1.MagnifierZoomY = 2.0!
        Me.GdViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection
        Me.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModePageChange
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
        Me.GdViewer1.Size = New System.Drawing.Size(653, 593)
        Me.GdViewer1.TabIndex = 24
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 1.0R
        Me.GdViewer1.ZoomCenterAtMousePosition = False
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer1.ZoomStep = 25
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(499, 654)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 38)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(441, 654)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 38)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "-"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 57)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Reason:"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(165, 52)
        Me.txtReason.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(359, 22)
        Me.txtReason.TabIndex = 3
        '
        'lbLocation
        '
        Me.lbLocation.AutoSize = True
        Me.lbLocation.Location = New System.Drawing.Point(5, 85)
        Me.lbLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLocation.Name = "lbLocation"
        Me.lbLocation.Size = New System.Drawing.Size(66, 17)
        Me.lbLocation.TabIndex = 4
        Me.lbLocation.Text = "Location:"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(165, 82)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(359, 22)
        Me.txtLocation.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Signer's name:"
        '
        'txtSignerName
        '
        Me.txtSignerName.Location = New System.Drawing.Point(165, 22)
        Me.txtSignerName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSignerName.Name = "txtSignerName"
        Me.txtSignerName.Size = New System.Drawing.Size(359, 22)
        Me.txtSignerName.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 114)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Contact info:"
        '
        'txtContactInfo
        '
        Me.txtContactInfo.Location = New System.Drawing.Point(165, 112)
        Me.txtContactInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContactInfo.Name = "txtContactInfo"
        Me.txtContactInfo.Size = New System.Drawing.Size(359, 22)
        Me.txtContactInfo.TabIndex = 7
        '
        'chkValidationMark
        '
        Me.chkValidationMark.AutoSize = True
        Me.chkValidationMark.Location = New System.Drawing.Point(183, 503)
        Me.chkValidationMark.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkValidationMark.Name = "chkValidationMark"
        Me.chkValidationMark.Size = New System.Drawing.Size(164, 21)
        Me.chkValidationMark.TabIndex = 16
        Me.chkValidationMark.Text = "Apply validation mark"
        Me.chkValidationMark.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optCertLevelFormFillAnnot)
        Me.GroupBox1.Controls.Add(Me.optCertLevelFormFill)
        Me.GroupBox1.Controls.Add(Me.optCertLevelNoChanges)
        Me.GroupBox1.Controls.Add(Me.optCertLevelNone)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 106)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(333, 78)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Certification level"
        '
        'optCertLevelFormFillAnnot
        '
        Me.optCertLevelFormFillAnnot.AutoSize = True
        Me.optCertLevelFormFillAnnot.Location = New System.Drawing.Point(120, 48)
        Me.optCertLevelFormFillAnnot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optCertLevelFormFillAnnot.Name = "optCertLevelFormFillAnnot"
        Me.optCertLevelFormFillAnnot.Size = New System.Drawing.Size(209, 21)
        Me.optCertLevelFormFillAnnot.TabIndex = 3
        Me.optCertLevelFormFillAnnot.TabStop = True
        Me.optCertLevelFormFillAnnot.Text = "Form Filling And Annotations"
        Me.optCertLevelFormFillAnnot.UseVisualStyleBackColor = True
        '
        'optCertLevelFormFill
        '
        Me.optCertLevelFormFill.AutoSize = True
        Me.optCertLevelFormFill.Location = New System.Drawing.Point(120, 21)
        Me.optCertLevelFormFill.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optCertLevelFormFill.Name = "optCertLevelFormFill"
        Me.optCertLevelFormFill.Size = New System.Drawing.Size(101, 21)
        Me.optCertLevelFormFill.TabIndex = 2
        Me.optCertLevelFormFill.TabStop = True
        Me.optCertLevelFormFill.Text = "Form Filling"
        Me.optCertLevelFormFill.UseVisualStyleBackColor = True
        '
        'optCertLevelNoChanges
        '
        Me.optCertLevelNoChanges.AutoSize = True
        Me.optCertLevelNoChanges.Location = New System.Drawing.Point(7, 48)
        Me.optCertLevelNoChanges.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optCertLevelNoChanges.Name = "optCertLevelNoChanges"
        Me.optCertLevelNoChanges.Size = New System.Drawing.Size(107, 21)
        Me.optCertLevelNoChanges.TabIndex = 1
        Me.optCertLevelNoChanges.TabStop = True
        Me.optCertLevelNoChanges.Text = "No Changes"
        Me.optCertLevelNoChanges.UseVisualStyleBackColor = True
        '
        'optCertLevelNone
        '
        Me.optCertLevelNone.AutoSize = True
        Me.optCertLevelNone.Location = New System.Drawing.Point(7, 21)
        Me.optCertLevelNone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optCertLevelNone.Name = "optCertLevelNone"
        Me.optCertLevelNone.Size = New System.Drawing.Size(63, 21)
        Me.optCertLevelNone.TabIndex = 0
        Me.optCertLevelNone.TabStop = True
        Me.optCertLevelNone.Text = "None"
        Me.optCertLevelNone.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optHash384)
        Me.GroupBox2.Controls.Add(Me.optHash224)
        Me.GroupBox2.Controls.Add(Me.optHash512)
        Me.GroupBox2.Controls.Add(Me.optHash256)
        Me.GroupBox2.Location = New System.Drawing.Point(356, 106)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(191, 78)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hash algorithm"
        '
        'optHash384
        '
        Me.optHash384.AutoSize = True
        Me.optHash384.Location = New System.Drawing.Point(99, 48)
        Me.optHash384.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optHash384.Name = "optHash384"
        Me.optHash384.Size = New System.Drawing.Size(86, 21)
        Me.optHash384.TabIndex = 3
        Me.optHash384.TabStop = True
        Me.optHash384.Text = "SHA-384"
        Me.optHash384.UseVisualStyleBackColor = True
        '
        'optHash224
        '
        Me.optHash224.AutoSize = True
        Me.optHash224.Location = New System.Drawing.Point(99, 21)
        Me.optHash224.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optHash224.Name = "optHash224"
        Me.optHash224.Size = New System.Drawing.Size(86, 21)
        Me.optHash224.TabIndex = 2
        Me.optHash224.TabStop = True
        Me.optHash224.Text = "SHA-224"
        Me.optHash224.UseVisualStyleBackColor = True
        '
        'optHash512
        '
        Me.optHash512.AutoSize = True
        Me.optHash512.Location = New System.Drawing.Point(8, 48)
        Me.optHash512.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optHash512.Name = "optHash512"
        Me.optHash512.Size = New System.Drawing.Size(86, 21)
        Me.optHash512.TabIndex = 1
        Me.optHash512.TabStop = True
        Me.optHash512.Text = "SHA-512"
        Me.optHash512.UseVisualStyleBackColor = True
        '
        'optHash256
        '
        Me.optHash256.AutoSize = True
        Me.optHash256.Location = New System.Drawing.Point(8, 21)
        Me.optHash256.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optHash256.Name = "optHash256"
        Me.optHash256.Size = New System.Drawing.Size(86, 21)
        Me.optHash256.TabIndex = 0
        Me.optHash256.TabStop = True
        Me.optHash256.Text = "SHA-256"
        Me.optHash256.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtTSPassword)
        Me.GroupBox3.Controls.Add(Me.txtTSUser)
        Me.GroupBox3.Controls.Add(Me.txtTSServer)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 236)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(532, 110)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Timestamp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Timestamp server (url):"
        '
        'txtTSPassword
        '
        Me.txtTSPassword.Location = New System.Drawing.Point(167, 78)
        Me.txtTSPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTSPassword.Name = "txtTSPassword"
        Me.txtTSPassword.Size = New System.Drawing.Size(359, 22)
        Me.txtTSPassword.TabIndex = 5
        '
        'txtTSUser
        '
        Me.txtTSUser.Location = New System.Drawing.Point(167, 49)
        Me.txtTSUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTSUser.Name = "txtTSUser"
        Me.txtTSUser.Size = New System.Drawing.Size(359, 22)
        Me.txtTSUser.TabIndex = 3
        '
        'txtTSServer
        '
        Me.txtTSServer.Location = New System.Drawing.Point(167, 21)
        Me.txtTSServer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTSServer.Name = "txtTSServer"
        Me.txtTSServer.Size = New System.Drawing.Size(359, 22)
        Me.txtTSServer.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(568, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Document Preview"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(565, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(521, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "The signing process will start automatically using all provided settings."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtLocation)
        Me.GroupBox4.Controls.Add(Me.lbLocation)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtContactInfo)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtSignerName)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtReason)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 352)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(531, 144)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Signature information (at least one setting is required)"
        '
        'chkLinearize
        '
        Me.chkLinearize.AutoSize = True
        Me.chkLinearize.Location = New System.Drawing.Point(377, 503)
        Me.chkLinearize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkLinearize.Name = "chkLinearize"
        Me.chkLinearize.Size = New System.Drawing.Size(170, 21)
        Me.chkLinearize.TabIndex = 17
        Me.chkLinearize.Text = "Linearize when saving"
        Me.chkLinearize.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optModeCADES)
        Me.GroupBox5.Controls.Add(Me.optModePPKLITE)
        Me.GroupBox5.Controls.Add(Me.optModePPKMS)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 502)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(161, 103)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Signature mode"
        '
        'optModeCADES
        '
        Me.optModeCADES.AutoSize = True
        Me.optModeCADES.Location = New System.Drawing.Point(8, 75)
        Me.optModeCADES.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optModeCADES.Name = "optModeCADES"
        Me.optModeCADES.Size = New System.Drawing.Size(75, 21)
        Me.optModeCADES.TabIndex = 2
        Me.optModeCADES.TabStop = True
        Me.optModeCADES.Text = "CADES"
        Me.optModeCADES.UseVisualStyleBackColor = True
        '
        'optModePPKLITE
        '
        Me.optModePPKLITE.AutoSize = True
        Me.optModePPKLITE.Location = New System.Drawing.Point(8, 48)
        Me.optModePPKLITE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optModePPKLITE.Name = "optModePPKLITE"
        Me.optModePPKLITE.Size = New System.Drawing.Size(85, 21)
        Me.optModePPKLITE.TabIndex = 1
        Me.optModePPKLITE.TabStop = True
        Me.optModePPKLITE.Text = "PPKLITE"
        Me.optModePPKLITE.UseVisualStyleBackColor = True
        '
        'optModePPKMS
        '
        Me.optModePPKMS.AutoSize = True
        Me.optModePPKMS.Location = New System.Drawing.Point(8, 21)
        Me.optModePPKMS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optModePPKMS.Name = "optModePPKMS"
        Me.optModePPKMS.Size = New System.Drawing.Size(76, 21)
        Me.optModePPKMS.TabIndex = 0
        Me.optModePPKMS.TabStop = True
        Me.optModePPKMS.Text = "PPKMS"
        Me.optModePPKMS.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 704)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.chkLinearize)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkValidationMark)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GdViewer1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCertPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCertPath)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImageStampPath)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Digitally Sign PDF Sample  -  http://www.gdpicture.com"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtImageStampPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCertPath As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCertPass As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GdViewer1 As GdPicture14.GdViewer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents lbLocation As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSignerName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtContactInfo As System.Windows.Forms.TextBox
    Friend WithEvents chkValidationMark As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optCertLevelFormFillAnnot As RadioButton
    Friend WithEvents optCertLevelFormFill As RadioButton
    Friend WithEvents optCertLevelNoChanges As RadioButton
    Friend WithEvents optCertLevelNone As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optHash384 As RadioButton
    Friend WithEvents optHash224 As RadioButton
    Friend WithEvents optHash512 As RadioButton
    Friend WithEvents optHash256 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTSPassword As TextBox
    Friend WithEvents txtTSUser As TextBox
    Friend WithEvents txtTSServer As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkLinearize As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents optModePPKMS As RadioButton
    Friend WithEvents optModeCADES As RadioButton
    Friend WithEvents optModePPKLITE As RadioButton
End Class
