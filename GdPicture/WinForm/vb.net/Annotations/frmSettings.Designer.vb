<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkIgnoreDocumentResolution = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtZoomStep = New System.Windows.Forms.NumericUpDown()
        Me.cbMouseWheelMode = New System.Windows.Forms.ComboBox()
        Me.cbDocumentPosition = New System.Windows.Forms.ComboBox()
        Me.cbDocumentAlignment = New System.Windows.Forms.ComboBox()
        Me.chkEnableMenu = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbDisplayQuality = New System.Windows.Forms.ComboBox()
        Me.chkContinuousViewMode = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkHQAnnotationsRendering = New System.Windows.Forms.CheckBox()
        Me.chkAnnotationsDropShadow = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkEnableICM = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPDFRenderingEngine = New System.Windows.Forms.ComboBox()
        Me.chkPDFVerifyDigitalCertificates = New System.Windows.Forms.CheckBox()
        Me.chkPDFIncreaseTextContrast = New System.Windows.Forms.CheckBox()
        Me.chkPDFEnableLinks = New System.Windows.Forms.CheckBox()
        Me.chkPDFEnableFileLinks = New System.Windows.Forms.CheckBox()
        Me.chkPDFDisplayFormFields = New System.Windows.Forms.CheckBox()
        Me.chkEnableDeferredPainting = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbPageDisplayMode = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtZoomStep,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox4.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkEnableDeferredPainting)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbPageDisplayMode)
        Me.GroupBox1.Controls.Add(Me.chkIgnoreDocumentResolution)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtZoomStep)
        Me.GroupBox1.Controls.Add(Me.cbMouseWheelMode)
        Me.GroupBox1.Controls.Add(Me.cbDocumentPosition)
        Me.GroupBox1.Controls.Add(Me.cbDocumentAlignment)
        Me.GroupBox1.Controls.Add(Me.chkEnableMenu)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbDisplayQuality)
        Me.GroupBox1.Controls.Add(Me.chkContinuousViewMode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(436, 456)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "General options"
        '
        'chkIgnoreDocumentResolution
        '
        Me.chkIgnoreDocumentResolution.AutoSize = true
        Me.chkIgnoreDocumentResolution.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIgnoreDocumentResolution.Location = New System.Drawing.Point(9, 380)
        Me.chkIgnoreDocumentResolution.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkIgnoreDocumentResolution.Name = "chkIgnoreDocumentResolution"
        Me.chkIgnoreDocumentResolution.Size = New System.Drawing.Size(229, 24)
        Me.chkIgnoreDocumentResolution.TabIndex = 8
        Me.chkIgnoreDocumentResolution.Text = "Ignore document resolution"
        Me.chkIgnoreDocumentResolution.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(174, 305)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 31)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = false
        '
        'txtZoomStep
        '
        Me.txtZoomStep.Location = New System.Drawing.Point(104, 28)
        Me.txtZoomStep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtZoomStep.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtZoomStep.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtZoomStep.Name = "txtZoomStep"
        Me.txtZoomStep.Size = New System.Drawing.Size(118, 26)
        Me.txtZoomStep.TabIndex = 0
        Me.txtZoomStep.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbMouseWheelMode
        '
        Me.cbMouseWheelMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMouseWheelMode.FormattingEnabled = true
        Me.cbMouseWheelMode.Location = New System.Drawing.Point(174, 263)
        Me.cbMouseWheelMode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbMouseWheelMode.Name = "cbMouseWheelMode"
        Me.cbMouseWheelMode.Size = New System.Drawing.Size(158, 28)
        Me.cbMouseWheelMode.TabIndex = 6
        '
        'cbDocumentPosition
        '
        Me.cbDocumentPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumentPosition.FormattingEnabled = true
        Me.cbDocumentPosition.Location = New System.Drawing.Point(174, 223)
        Me.cbDocumentPosition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbDocumentPosition.Name = "cbDocumentPosition"
        Me.cbDocumentPosition.Size = New System.Drawing.Size(158, 28)
        Me.cbDocumentPosition.TabIndex = 5
        '
        'cbDocumentAlignment
        '
        Me.cbDocumentAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumentAlignment.FormattingEnabled = true
        Me.cbDocumentAlignment.Location = New System.Drawing.Point(174, 183)
        Me.cbDocumentAlignment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbDocumentAlignment.Name = "cbDocumentAlignment"
        Me.cbDocumentAlignment.Size = New System.Drawing.Size(158, 28)
        Me.cbDocumentAlignment.TabIndex = 4
        '
        'chkEnableMenu
        '
        Me.chkEnableMenu.AutoSize = true
        Me.chkEnableMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnableMenu.Location = New System.Drawing.Point(9, 346)
        Me.chkEnableMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkEnableMenu.Name = "chkEnableMenu"
        Me.chkEnableMenu.Size = New System.Drawing.Size(206, 24)
        Me.chkEnableMenu.TabIndex = 7
        Me.chkEnableMenu.Text = "Enable contextual menu"
        Me.chkEnableMenu.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(9, 311)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Background color"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(9, 267)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mouse wheel mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(9, 227)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Document position"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(9, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Document alignment"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(9, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Display quality"
        '
        'cbDisplayQuality
        '
        Me.cbDisplayQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDisplayQuality.FormattingEnabled = true
        Me.cbDisplayQuality.Location = New System.Drawing.Point(174, 103)
        Me.cbDisplayQuality.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbDisplayQuality.Name = "cbDisplayQuality"
        Me.cbDisplayQuality.Size = New System.Drawing.Size(158, 28)
        Me.cbDisplayQuality.TabIndex = 2
        '
        'chkContinuousViewMode
        '
        Me.chkContinuousViewMode.AutoSize = true
        Me.chkContinuousViewMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkContinuousViewMode.Location = New System.Drawing.Point(9, 65)
        Me.chkContinuousViewMode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkContinuousViewMode.Name = "chkContinuousViewMode"
        Me.chkContinuousViewMode.Size = New System.Drawing.Size(194, 24)
        Me.chkContinuousViewMode.TabIndex = 1
        Me.chkContinuousViewMode.Text = "Continuous view mode"
        Me.chkContinuousViewMode.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Zoom step"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(793, 520)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(112, 35)
        Me.btnApply.TabIndex = 99
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkHQAnnotationsRendering)
        Me.GroupBox2.Controls.Add(Me.chkAnnotationsDropShadow)
        Me.GroupBox2.Location = New System.Drawing.Point(464, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(436, 128)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Annotations options"
        '
        'chkHQAnnotationsRendering
        '
        Me.chkHQAnnotationsRendering.AutoSize = true
        Me.chkHQAnnotationsRendering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHQAnnotationsRendering.Location = New System.Drawing.Point(9, 65)
        Me.chkHQAnnotationsRendering.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkHQAnnotationsRendering.Name = "chkHQAnnotationsRendering"
        Me.chkHQAnnotationsRendering.Size = New System.Drawing.Size(218, 24)
        Me.chkHQAnnotationsRendering.TabIndex = 1
        Me.chkHQAnnotationsRendering.Text = "HQ annotations rendering"
        Me.chkHQAnnotationsRendering.UseVisualStyleBackColor = true
        '
        'chkAnnotationsDropShadow
        '
        Me.chkAnnotationsDropShadow.AutoSize = true
        Me.chkAnnotationsDropShadow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnnotationsDropShadow.Location = New System.Drawing.Point(9, 29)
        Me.chkAnnotationsDropShadow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkAnnotationsDropShadow.Name = "chkAnnotationsDropShadow"
        Me.chkAnnotationsDropShadow.Size = New System.Drawing.Size(216, 24)
        Me.chkAnnotationsDropShadow.TabIndex = 0
        Me.chkAnnotationsDropShadow.Text = "Annotations drop shadow"
        Me.chkAnnotationsDropShadow.UseVisualStyleBackColor = true
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkEnableICM)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 484)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(436, 71)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Image viewing options"
        '
        'chkEnableICM
        '
        Me.chkEnableICM.AutoSize = true
        Me.chkEnableICM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnableICM.Location = New System.Drawing.Point(9, 29)
        Me.chkEnableICM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkEnableICM.Name = "chkEnableICM"
        Me.chkEnableICM.Size = New System.Drawing.Size(118, 24)
        Me.chkEnableICM.TabIndex = 0
        Me.chkEnableICM.Text = "Enable ICM"
        Me.chkEnableICM.UseVisualStyleBackColor = true
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cbPDFRenderingEngine)
        Me.GroupBox4.Controls.Add(Me.chkPDFVerifyDigitalCertificates)
        Me.GroupBox4.Controls.Add(Me.chkPDFIncreaseTextContrast)
        Me.GroupBox4.Controls.Add(Me.chkPDFEnableLinks)
        Me.GroupBox4.Controls.Add(Me.chkPDFEnableFileLinks)
        Me.GroupBox4.Controls.Add(Me.chkPDFDisplayFormFields)
        Me.GroupBox4.Location = New System.Drawing.Point(464, 155)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(436, 283)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "PDF viewing options"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(12, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PDF rasterizer engine"
        '
        'cbPDFRenderingEngine
        '
        Me.cbPDFRenderingEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPDFRenderingEngine.FormattingEnabled = true
        Me.cbPDFRenderingEngine.Location = New System.Drawing.Point(183, 182)
        Me.cbPDFRenderingEngine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbPDFRenderingEngine.Name = "cbPDFRenderingEngine"
        Me.cbPDFRenderingEngine.Size = New System.Drawing.Size(180, 28)
        Me.cbPDFRenderingEngine.TabIndex = 4
        '
        'chkPDFVerifyDigitalCertificates
        '
        Me.chkPDFVerifyDigitalCertificates.AutoSize = true
        Me.chkPDFVerifyDigitalCertificates.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFVerifyDigitalCertificates.Location = New System.Drawing.Point(9, 225)
        Me.chkPDFVerifyDigitalCertificates.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPDFVerifyDigitalCertificates.Name = "chkPDFVerifyDigitalCertificates"
        Me.chkPDFVerifyDigitalCertificates.Size = New System.Drawing.Size(201, 24)
        Me.chkPDFVerifyDigitalCertificates.TabIndex = 5
        Me.chkPDFVerifyDigitalCertificates.Text = "Verify digital certificates"
        Me.chkPDFVerifyDigitalCertificates.UseVisualStyleBackColor = true
        '
        'chkPDFIncreaseTextContrast
        '
        Me.chkPDFIncreaseTextContrast.AutoSize = true
        Me.chkPDFIncreaseTextContrast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFIncreaseTextContrast.Location = New System.Drawing.Point(9, 148)
        Me.chkPDFIncreaseTextContrast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPDFIncreaseTextContrast.Name = "chkPDFIncreaseTextContrast"
        Me.chkPDFIncreaseTextContrast.Size = New System.Drawing.Size(189, 24)
        Me.chkPDFIncreaseTextContrast.TabIndex = 3
        Me.chkPDFIncreaseTextContrast.Text = "Increase text contrast"
        Me.chkPDFIncreaseTextContrast.UseVisualStyleBackColor = true
        '
        'chkPDFEnableLinks
        '
        Me.chkPDFEnableLinks.AutoSize = true
        Me.chkPDFEnableLinks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFEnableLinks.Location = New System.Drawing.Point(9, 112)
        Me.chkPDFEnableLinks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPDFEnableLinks.Name = "chkPDFEnableLinks"
        Me.chkPDFEnableLinks.Size = New System.Drawing.Size(120, 24)
        Me.chkPDFEnableLinks.TabIndex = 2
        Me.chkPDFEnableLinks.Text = "Enable links"
        Me.chkPDFEnableLinks.UseVisualStyleBackColor = true
        '
        'chkPDFEnableFileLinks
        '
        Me.chkPDFEnableFileLinks.AutoSize = true
        Me.chkPDFEnableFileLinks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFEnableFileLinks.Location = New System.Drawing.Point(9, 77)
        Me.chkPDFEnableFileLinks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPDFEnableFileLinks.Name = "chkPDFEnableFileLinks"
        Me.chkPDFEnableFileLinks.Size = New System.Drawing.Size(144, 24)
        Me.chkPDFEnableFileLinks.TabIndex = 1
        Me.chkPDFEnableFileLinks.Text = "Enable file links"
        Me.chkPDFEnableFileLinks.UseVisualStyleBackColor = true
        '
        'chkPDFDisplayFormFields
        '
        Me.chkPDFDisplayFormFields.AutoSize = true
        Me.chkPDFDisplayFormFields.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFDisplayFormFields.Location = New System.Drawing.Point(9, 42)
        Me.chkPDFDisplayFormFields.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkPDFDisplayFormFields.Name = "chkPDFDisplayFormFields"
        Me.chkPDFDisplayFormFields.Size = New System.Drawing.Size(163, 24)
        Me.chkPDFDisplayFormFields.TabIndex = 0
        Me.chkPDFDisplayFormFields.Text = "Display form fields"
        Me.chkPDFDisplayFormFields.UseVisualStyleBackColor = true
        '
        'chkEnableDeferredPainting
        '
        Me.chkEnableDeferredPainting.AutoSize = true
        Me.chkEnableDeferredPainting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnableDeferredPainting.Location = New System.Drawing.Point(9, 414)
        Me.chkEnableDeferredPainting.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkEnableDeferredPainting.Name = "chkEnableDeferredPainting"
        Me.chkEnableDeferredPainting.Size = New System.Drawing.Size(209, 24)
        Me.chkEnableDeferredPainting.TabIndex = 9
        Me.chkEnableDeferredPainting.Text = "Enable deferred painting"
        Me.chkEnableDeferredPainting.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(9, 147)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Display mode"
        '
        'cbPageDisplayMode
        '
        Me.cbPageDisplayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPageDisplayMode.FormattingEnabled = true
        Me.cbPageDisplayMode.Location = New System.Drawing.Point(174, 143)
        Me.cbPageDisplayMode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbPageDisplayMode.Name = "cbPageDisplayMode"
        Me.cbPageDisplayMode.Size = New System.Drawing.Size(193, 28)
        Me.cbPageDisplayMode.TabIndex = 3
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 569)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnApply)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Viewer settings"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtZoomStep,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEnableMenu As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbDisplayQuality As System.Windows.Forms.ComboBox
    Friend WithEvents chkContinuousViewMode As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtZoomStep As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbMouseWheelMode As System.Windows.Forms.ComboBox
    Friend WithEvents cbDocumentPosition As System.Windows.Forms.ComboBox
    Friend WithEvents cbDocumentAlignment As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkHQAnnotationsRendering As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnnotationsDropShadow As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEnableICM As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPDFIncreaseTextContrast As System.Windows.Forms.CheckBox
    Friend WithEvents chkPDFEnableLinks As System.Windows.Forms.CheckBox
    Friend WithEvents chkPDFEnableFileLinks As System.Windows.Forms.CheckBox
    Friend WithEvents chkPDFDisplayFormFields As System.Windows.Forms.CheckBox
    Friend WithEvents chkPDFVerifyDigitalCertificates As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbPDFRenderingEngine As System.Windows.Forms.ComboBox
    Friend WithEvents chkIgnoreDocumentResolution As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnableDeferredPainting As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbPageDisplayMode As ComboBox
End Class
