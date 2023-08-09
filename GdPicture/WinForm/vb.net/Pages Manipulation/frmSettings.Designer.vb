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
        Me.chkEnableDeferredPainting = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbPageDisplayMode = New System.Windows.Forms.ComboBox()
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
        Me.chkPDFVerifyDigitalCertificates = New System.Windows.Forms.CheckBox()
        Me.chkPDFIncreaseTextContrast = New System.Windows.Forms.CheckBox()
        Me.chkPDFEnableLinks = New System.Windows.Forms.CheckBox()
        Me.chkPDFEnableFileLinks = New System.Windows.Forms.CheckBox()
        Me.chkPDFDisplayFormFields = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZoomStep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 296)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General options"
        '
        'chkEnableDeferredPainting
        '
        Me.chkEnableDeferredPainting.AutoSize = True
        Me.chkEnableDeferredPainting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnableDeferredPainting.Location = New System.Drawing.Point(6, 269)
        Me.chkEnableDeferredPainting.Name = "chkEnableDeferredPainting"
        Me.chkEnableDeferredPainting.Size = New System.Drawing.Size(141, 17)
        Me.chkEnableDeferredPainting.TabIndex = 20
        Me.chkEnableDeferredPainting.Text = "Enable deferred painting"
        Me.chkEnableDeferredPainting.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Display mode"
        '
        'cbPageDisplayMode
        '
        Me.cbPageDisplayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPageDisplayMode.FormattingEnabled = True
        Me.cbPageDisplayMode.Location = New System.Drawing.Point(116, 93)
        Me.cbPageDisplayMode.Name = "cbPageDisplayMode"
        Me.cbPageDisplayMode.Size = New System.Drawing.Size(130, 21)
        Me.cbPageDisplayMode.TabIndex = 18
        '
        'chkIgnoreDocumentResolution
        '
        Me.chkIgnoreDocumentResolution.AutoSize = True
        Me.chkIgnoreDocumentResolution.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIgnoreDocumentResolution.Location = New System.Drawing.Point(6, 247)
        Me.chkIgnoreDocumentResolution.Name = "chkIgnoreDocumentResolution"
        Me.chkIgnoreDocumentResolution.Size = New System.Drawing.Size(154, 17)
        Me.chkIgnoreDocumentResolution.TabIndex = 14
        Me.chkIgnoreDocumentResolution.Text = "Ignore document resolution"
        Me.chkIgnoreDocumentResolution.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(116, 198)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txtZoomStep
        '
        Me.txtZoomStep.Location = New System.Drawing.Point(69, 18)
        Me.txtZoomStep.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtZoomStep.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtZoomStep.Name = "txtZoomStep"
        Me.txtZoomStep.Size = New System.Drawing.Size(79, 20)
        Me.txtZoomStep.TabIndex = 0
        Me.txtZoomStep.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbMouseWheelMode
        '
        Me.cbMouseWheelMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMouseWheelMode.FormattingEnabled = True
        Me.cbMouseWheelMode.Location = New System.Drawing.Point(116, 171)
        Me.cbMouseWheelMode.Name = "cbMouseWheelMode"
        Me.cbMouseWheelMode.Size = New System.Drawing.Size(107, 21)
        Me.cbMouseWheelMode.TabIndex = 13
        '
        'cbDocumentPosition
        '
        Me.cbDocumentPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumentPosition.FormattingEnabled = True
        Me.cbDocumentPosition.Location = New System.Drawing.Point(116, 145)
        Me.cbDocumentPosition.Name = "cbDocumentPosition"
        Me.cbDocumentPosition.Size = New System.Drawing.Size(107, 21)
        Me.cbDocumentPosition.TabIndex = 12
        '
        'cbDocumentAlignment
        '
        Me.cbDocumentAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumentAlignment.FormattingEnabled = True
        Me.cbDocumentAlignment.Location = New System.Drawing.Point(116, 119)
        Me.cbDocumentAlignment.Name = "cbDocumentAlignment"
        Me.cbDocumentAlignment.Size = New System.Drawing.Size(107, 21)
        Me.cbDocumentAlignment.TabIndex = 11
        '
        'chkEnableMenu
        '
        Me.chkEnableMenu.AutoSize = True
        Me.chkEnableMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnableMenu.Location = New System.Drawing.Point(6, 225)
        Me.chkEnableMenu.Name = "chkEnableMenu"
        Me.chkEnableMenu.Size = New System.Drawing.Size(140, 17)
        Me.chkEnableMenu.TabIndex = 10
        Me.chkEnableMenu.Text = "Enable contextual menu"
        Me.chkEnableMenu.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Background color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mouse wheel mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Document position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Document alignment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Display quality"
        '
        'cbDisplayQuality
        '
        Me.cbDisplayQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDisplayQuality.FormattingEnabled = True
        Me.cbDisplayQuality.Location = New System.Drawing.Point(116, 67)
        Me.cbDisplayQuality.Name = "cbDisplayQuality"
        Me.cbDisplayQuality.Size = New System.Drawing.Size(107, 21)
        Me.cbDisplayQuality.TabIndex = 3
        '
        'chkContinuousViewMode
        '
        Me.chkContinuousViewMode.AutoSize = True
        Me.chkContinuousViewMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkContinuousViewMode.Location = New System.Drawing.Point(6, 42)
        Me.chkContinuousViewMode.Name = "chkContinuousViewMode"
        Me.chkContinuousViewMode.Size = New System.Drawing.Size(133, 17)
        Me.chkContinuousViewMode.TabIndex = 2
        Me.chkContinuousViewMode.Text = "Continuous view mode"
        Me.chkContinuousViewMode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Zoom step"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(529, 337)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 3
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkHQAnnotationsRendering)
        Me.GroupBox2.Controls.Add(Me.chkAnnotationsDropShadow)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 83)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Annotations options"
        '
        'chkHQAnnotationsRendering
        '
        Me.chkHQAnnotationsRendering.AutoSize = True
        Me.chkHQAnnotationsRendering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHQAnnotationsRendering.Location = New System.Drawing.Point(6, 42)
        Me.chkHQAnnotationsRendering.Name = "chkHQAnnotationsRendering"
        Me.chkHQAnnotationsRendering.Size = New System.Drawing.Size(147, 17)
        Me.chkHQAnnotationsRendering.TabIndex = 1
        Me.chkHQAnnotationsRendering.Text = "HQ annotations rendering"
        Me.chkHQAnnotationsRendering.UseVisualStyleBackColor = True
        '
        'chkAnnotationsDropShadow
        '
        Me.chkAnnotationsDropShadow.AutoSize = True
        Me.chkAnnotationsDropShadow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnnotationsDropShadow.Location = New System.Drawing.Point(6, 19)
        Me.chkAnnotationsDropShadow.Name = "chkAnnotationsDropShadow"
        Me.chkAnnotationsDropShadow.Size = New System.Drawing.Size(146, 17)
        Me.chkAnnotationsDropShadow.TabIndex = 0
        Me.chkAnnotationsDropShadow.Text = "Annotations drop shadow"
        Me.chkAnnotationsDropShadow.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkEnableICM)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 314)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 46)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Image viewing options"
        '
        'chkEnableICM
        '
        Me.chkEnableICM.AutoSize = True
        Me.chkEnableICM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEnableICM.Location = New System.Drawing.Point(6, 19)
        Me.chkEnableICM.Name = "chkEnableICM"
        Me.chkEnableICM.Size = New System.Drawing.Size(81, 17)
        Me.chkEnableICM.TabIndex = 0
        Me.chkEnableICM.Text = "Enable ICM"
        Me.chkEnableICM.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkPDFVerifyDigitalCertificates)
        Me.GroupBox4.Controls.Add(Me.chkPDFIncreaseTextContrast)
        Me.GroupBox4.Controls.Add(Me.chkPDFEnableLinks)
        Me.GroupBox4.Controls.Add(Me.chkPDFEnableFileLinks)
        Me.GroupBox4.Controls.Add(Me.chkPDFDisplayFormFields)
        Me.GroupBox4.Location = New System.Drawing.Point(309, 101)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(291, 184)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PDF viewing options"
        '
        'chkPDFVerifyDigitalCertificates
        '
        Me.chkPDFVerifyDigitalCertificates.AutoSize = True
        Me.chkPDFVerifyDigitalCertificates.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFVerifyDigitalCertificates.Location = New System.Drawing.Point(6, 146)
        Me.chkPDFVerifyDigitalCertificates.Name = "chkPDFVerifyDigitalCertificates"
        Me.chkPDFVerifyDigitalCertificates.Size = New System.Drawing.Size(136, 17)
        Me.chkPDFVerifyDigitalCertificates.TabIndex = 4
        Me.chkPDFVerifyDigitalCertificates.Text = "Verify digital certificates"
        Me.chkPDFVerifyDigitalCertificates.UseVisualStyleBackColor = True
        '
        'chkPDFIncreaseTextContrast
        '
        Me.chkPDFIncreaseTextContrast.AutoSize = True
        Me.chkPDFIncreaseTextContrast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFIncreaseTextContrast.Location = New System.Drawing.Point(6, 96)
        Me.chkPDFIncreaseTextContrast.Name = "chkPDFIncreaseTextContrast"
        Me.chkPDFIncreaseTextContrast.Size = New System.Drawing.Size(128, 17)
        Me.chkPDFIncreaseTextContrast.TabIndex = 3
        Me.chkPDFIncreaseTextContrast.Text = "Increase text contrast"
        Me.chkPDFIncreaseTextContrast.UseVisualStyleBackColor = True
        '
        'chkPDFEnableLinks
        '
        Me.chkPDFEnableLinks.AutoSize = True
        Me.chkPDFEnableLinks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFEnableLinks.Location = New System.Drawing.Point(6, 73)
        Me.chkPDFEnableLinks.Name = "chkPDFEnableLinks"
        Me.chkPDFEnableLinks.Size = New System.Drawing.Size(83, 17)
        Me.chkPDFEnableLinks.TabIndex = 2
        Me.chkPDFEnableLinks.Text = "Enable links"
        Me.chkPDFEnableLinks.UseVisualStyleBackColor = True
        '
        'chkPDFEnableFileLinks
        '
        Me.chkPDFEnableFileLinks.AutoSize = True
        Me.chkPDFEnableFileLinks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFEnableFileLinks.Location = New System.Drawing.Point(6, 50)
        Me.chkPDFEnableFileLinks.Name = "chkPDFEnableFileLinks"
        Me.chkPDFEnableFileLinks.Size = New System.Drawing.Size(99, 17)
        Me.chkPDFEnableFileLinks.TabIndex = 1
        Me.chkPDFEnableFileLinks.Text = "Enable file links"
        Me.chkPDFEnableFileLinks.UseVisualStyleBackColor = True
        '
        'chkPDFDisplayFormFields
        '
        Me.chkPDFDisplayFormFields.AutoSize = True
        Me.chkPDFDisplayFormFields.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPDFDisplayFormFields.Location = New System.Drawing.Point(6, 27)
        Me.chkPDFDisplayFormFields.Name = "chkPDFDisplayFormFields"
        Me.chkPDFDisplayFormFields.Size = New System.Drawing.Size(110, 17)
        Me.chkPDFDisplayFormFields.TabIndex = 0
        Me.chkPDFDisplayFormFields.Text = "Display form fields"
        Me.chkPDFDisplayFormFields.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 370)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnApply)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
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
    Friend WithEvents chkIgnoreDocumentResolution As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnableDeferredPainting As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbPageDisplayMode As ComboBox
End Class
