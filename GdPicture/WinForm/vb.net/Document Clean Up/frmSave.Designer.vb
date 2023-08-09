<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSave))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblDestinationFolder = New System.Windows.Forms.Label()
        Me.txtDestinationFolder = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblDocumentFormat = New System.Windows.Forms.Label()
        Me.cbDocumentFormat = New System.Windows.Forms.ComboBox()
        Me.grpCompressionOptions = New System.Windows.Forms.GroupBox()
        Me.chkTiffCmyk = New System.Windows.Forms.CheckBox()
        Me.cbTiffCompression = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkPngInterlaced = New System.Windows.Forms.CheckBox()
        Me.nPngCompressionLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkProgressive = New System.Windows.Forms.CheckBox()
        Me.nJpegQuality = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nJ2kRate = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExrCompression = New System.Windows.Forms.Label()
        Me.cbExrCompression = New System.Windows.Forms.ComboBox()
        Me.grpCompressionOptions.SuspendLayout()
        CType(Me.nPngCompressionLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nJpegQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nJ2kRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(443, 254)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(362, 254)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblDestinationFolder
        '
        Me.lblDestinationFolder.AutoSize = True
        Me.lblDestinationFolder.Location = New System.Drawing.Point(10, 17)
        Me.lblDestinationFolder.Name = "lblDestinationFolder"
        Me.lblDestinationFolder.Size = New System.Drawing.Size(92, 13)
        Me.lblDestinationFolder.TabIndex = 2
        Me.lblDestinationFolder.Text = "Destination folder:"
        '
        'txtDestinationFolder
        '
        Me.txtDestinationFolder.Location = New System.Drawing.Point(105, 14)
        Me.txtDestinationFolder.Name = "txtDestinationFolder"
        Me.txtDestinationFolder.Size = New System.Drawing.Size(329, 20)
        Me.txtDestinationFolder.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(443, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblDocumentFormat
        '
        Me.lblDocumentFormat.AutoSize = True
        Me.lblDocumentFormat.Location = New System.Drawing.Point(10, 43)
        Me.lblDocumentFormat.Name = "lblDocumentFormat"
        Me.lblDocumentFormat.Size = New System.Drawing.Size(91, 13)
        Me.lblDocumentFormat.TabIndex = 5
        Me.lblDocumentFormat.Text = "Document format:"
        '
        'cbDocumentFormat
        '
        Me.cbDocumentFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumentFormat.FormattingEnabled = True
        Me.cbDocumentFormat.Location = New System.Drawing.Point(105, 40)
        Me.cbDocumentFormat.Name = "cbDocumentFormat"
        Me.cbDocumentFormat.Size = New System.Drawing.Size(228, 21)
        Me.cbDocumentFormat.TabIndex = 6
        '
        'grpCompressionOptions
        '
        Me.grpCompressionOptions.Controls.Add(Me.chkTiffCmyk)
        Me.grpCompressionOptions.Controls.Add(Me.cbTiffCompression)
        Me.grpCompressionOptions.Controls.Add(Me.Label4)
        Me.grpCompressionOptions.Controls.Add(Me.chkPngInterlaced)
        Me.grpCompressionOptions.Controls.Add(Me.nPngCompressionLevel)
        Me.grpCompressionOptions.Controls.Add(Me.Label3)
        Me.grpCompressionOptions.Controls.Add(Me.chkProgressive)
        Me.grpCompressionOptions.Controls.Add(Me.nJpegQuality)
        Me.grpCompressionOptions.Controls.Add(Me.Label2)
        Me.grpCompressionOptions.Controls.Add(Me.nJ2kRate)
        Me.grpCompressionOptions.Controls.Add(Me.Label1)
        Me.grpCompressionOptions.Controls.Add(Me.lblExrCompression)
        Me.grpCompressionOptions.Controls.Add(Me.cbExrCompression)
        Me.grpCompressionOptions.Location = New System.Drawing.Point(13, 73)
        Me.grpCompressionOptions.Name = "grpCompressionOptions"
        Me.grpCompressionOptions.Size = New System.Drawing.Size(505, 175)
        Me.grpCompressionOptions.TabIndex = 7
        Me.grpCompressionOptions.TabStop = False
        Me.grpCompressionOptions.Text = "Compression options"
        '
        'chkTiffCmyk
        '
        Me.chkTiffCmyk.AutoSize = True
        Me.chkTiffCmyk.Location = New System.Drawing.Point(400, 133)
        Me.chkTiffCmyk.Name = "chkTiffCmyk"
        Me.chkTiffCmyk.Size = New System.Drawing.Size(85, 17)
        Me.chkTiffCmyk.TabIndex = 12
        Me.chkTiffCmyk.Text = "CMYK mode"
        Me.chkTiffCmyk.UseVisualStyleBackColor = True
        '
        'cbTiffCompression
        '
        Me.cbTiffCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiffCompression.FormattingEnabled = True
        Me.cbTiffCompression.Location = New System.Drawing.Point(115, 131)
        Me.cbTiffCompression.Name = "cbTiffCompression"
        Me.cbTiffCompression.Size = New System.Drawing.Size(269, 21)
        Me.cbTiffCompression.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "TIFF compression:"
        '
        'chkPngInterlaced
        '
        Me.chkPngInterlaced.AutoSize = True
        Me.chkPngInterlaced.Location = New System.Drawing.Point(227, 106)
        Me.chkPngInterlaced.Name = "chkPngInterlaced"
        Me.chkPngInterlaced.Size = New System.Drawing.Size(73, 17)
        Me.chkPngInterlaced.TabIndex = 9
        Me.chkPngInterlaced.Text = "Interlaced"
        Me.chkPngInterlaced.UseVisualStyleBackColor = True
        '
        'nPngCompressionLevel
        '
        Me.nPngCompressionLevel.Location = New System.Drawing.Point(168, 105)
        Me.nPngCompressionLevel.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nPngCompressionLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nPngCompressionLevel.Name = "nPngCompressionLevel"
        Me.nPngCompressionLevel.Size = New System.Drawing.Size(43, 20)
        Me.nPngCompressionLevel.TabIndex = 8
        Me.nPngCompressionLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nPngCompressionLevel.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PNG compression level:"
        '
        'chkProgressive
        '
        Me.chkProgressive.AutoSize = True
        Me.chkProgressive.Location = New System.Drawing.Point(242, 80)
        Me.chkProgressive.Name = "chkProgressive"
        Me.chkProgressive.Size = New System.Drawing.Size(81, 17)
        Me.chkProgressive.TabIndex = 6
        Me.chkProgressive.Text = "Progressive"
        Me.chkProgressive.UseVisualStyleBackColor = True
        '
        'nJpegQuality
        '
        Me.nJpegQuality.Location = New System.Drawing.Point(168, 79)
        Me.nJpegQuality.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nJpegQuality.Name = "nJpegQuality"
        Me.nJpegQuality.Size = New System.Drawing.Size(58, 20)
        Me.nJpegQuality.TabIndex = 5
        Me.nJpegQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nJpegQuality.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "JPEG quality:"
        '
        'nJ2kRate
        '
        Me.nJ2kRate.Location = New System.Drawing.Point(168, 53)
        Me.nJ2kRate.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.nJ2kRate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nJ2kRate.Name = "nJ2kRate"
        Me.nJ2kRate.Size = New System.Drawing.Size(58, 20)
        Me.nJ2kRate.TabIndex = 3
        Me.nJ2kRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nJ2kRate.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "JPEG-2000 compression rate:"
        '
        'lblExrCompression
        '
        Me.lblExrCompression.AutoSize = True
        Me.lblExrCompression.Location = New System.Drawing.Point(18, 29)
        Me.lblExrCompression.Name = "lblExrCompression"
        Me.lblExrCompression.Size = New System.Drawing.Size(94, 13)
        Me.lblExrCompression.TabIndex = 1
        Me.lblExrCompression.Text = "EXR compression:"
        '
        'cbExrCompression
        '
        Me.cbExrCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbExrCompression.FormattingEnabled = True
        Me.cbExrCompression.Location = New System.Drawing.Point(115, 26)
        Me.cbExrCompression.Name = "cbExrCompression"
        Me.cbExrCompression.Size = New System.Drawing.Size(221, 21)
        Me.cbExrCompression.TabIndex = 0
        '
        'frmSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 287)
        Me.Controls.Add(Me.grpCompressionOptions)
        Me.Controls.Add(Me.cbDocumentFormat)
        Me.Controls.Add(Me.lblDocumentFormat)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtDestinationFolder)
        Me.Controls.Add(Me.lblDestinationFolder)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Save"
        Me.grpCompressionOptions.ResumeLayout(False)
        Me.grpCompressionOptions.PerformLayout()
        CType(Me.nPngCompressionLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nJpegQuality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nJ2kRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblDestinationFolder As System.Windows.Forms.Label
    Friend WithEvents txtDestinationFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblDocumentFormat As System.Windows.Forms.Label
    Friend WithEvents cbDocumentFormat As System.Windows.Forms.ComboBox
    Friend WithEvents grpCompressionOptions As System.Windows.Forms.GroupBox
    Friend WithEvents lblExrCompression As System.Windows.Forms.Label
    Friend WithEvents cbExrCompression As System.Windows.Forms.ComboBox
    Friend WithEvents nJ2kRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkProgressive As System.Windows.Forms.CheckBox
    Friend WithEvents nJpegQuality As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkTiffCmyk As System.Windows.Forms.CheckBox
    Friend WithEvents cbTiffCompression As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkPngInterlaced As System.Windows.Forms.CheckBox
    Friend WithEvents nPngCompressionLevel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
