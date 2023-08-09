<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BarcodeResults
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
        Me.btn1DBarcode = New Button()
        Me.btn2DBarcode = New Button()
        Me.btnQRBarcode = New Button()
        Me.btnPDF417Barcode = New Button()
        Me.btnMicroQRBarcode = New Button()
        Me.btnPatchCodeBarcode = New Button()
        Me.btnClose = New Button()
        Me.lblTotalBarcodesCount = New Label()
        Me.resultsList = New FlowLayoutPanel()
        Me.btnAztecBarcode = New Button()
        Me.btnMaxicodeBarcode = New Button()
        Me.SuspendLayout()
        '
        'btn1DBarcode
        '
        Me.btn1DBarcode.Enabled = False
        Me.btn1DBarcode.Location = New System.Drawing.Point(526, 26)
        Me.btn1DBarcode.Name = "btn1DBarcode"
        Me.btn1DBarcode.Size = New System.Drawing.Size(226, 54)
        Me.btn1DBarcode.TabIndex = 0
        Me.btn1DBarcode.Text = "1D Barcodes"
        Me.btn1DBarcode.UseVisualStyleBackColor = True
        '
        'btn2DBarcode
        '
        Me.btn2DBarcode.Enabled = False
        Me.btn2DBarcode.Location = New System.Drawing.Point(526, 90)
        Me.btn2DBarcode.Name = "btn2DBarcode"
        Me.btn2DBarcode.Size = New System.Drawing.Size(226, 54)
        Me.btn2DBarcode.TabIndex = 1
        Me.btn2DBarcode.Text = "Data Matrix Barcodes"
        Me.btn2DBarcode.UseVisualStyleBackColor = True
        '
        'btnQRBarcode
        '
        Me.btnQRBarcode.Enabled = False
        Me.btnQRBarcode.Location = New System.Drawing.Point(526, 154)
        Me.btnQRBarcode.Name = "btnQRBarcode"
        Me.btnQRBarcode.Size = New System.Drawing.Size(226, 54)
        Me.btnQRBarcode.TabIndex = 2
        Me.btnQRBarcode.Text = "QR Code Barcodes"
        Me.btnQRBarcode.UseVisualStyleBackColor = True
        '
        'btnPDF417Barcode
        '
        Me.btnPDF417Barcode.Enabled = False
        Me.btnPDF417Barcode.Location = New System.Drawing.Point(526, 218)
        Me.btnPDF417Barcode.Name = "btnPDF417Barcode"
        Me.btnPDF417Barcode.Size = New System.Drawing.Size(226, 54)
        Me.btnPDF417Barcode.TabIndex = 3
        Me.btnPDF417Barcode.Text = "PDF 417 Barcodes"
        Me.btnPDF417Barcode.UseVisualStyleBackColor = True
        '
        'btnMicroQRBarcode
        '
        Me.btnMicroQRBarcode.Enabled = False
        Me.btnMicroQRBarcode.Location = New System.Drawing.Point(526, 282)
        Me.btnMicroQRBarcode.Name = "btnMicroQRBarcode"
        Me.btnMicroQRBarcode.Size = New System.Drawing.Size(226, 54)
        Me.btnMicroQRBarcode.TabIndex = 4
        Me.btnMicroQRBarcode.Text = "Micro QR Barcodes"
        Me.btnMicroQRBarcode.UseVisualStyleBackColor = True
        '
        'btnPatchCodeBarcode
        '
        Me.btnPatchCodeBarcode.Enabled = False
        Me.btnPatchCodeBarcode.Location = New System.Drawing.Point(526, 470)
        Me.btnPatchCodeBarcode.Name = "btnPatchCodeBarcode"
        Me.btnPatchCodeBarcode.Size = New System.Drawing.Size(226, 54)
        Me.btnPatchCodeBarcode.TabIndex = 5
        Me.btnPatchCodeBarcode.Text = "Patch Code"
        Me.btnPatchCodeBarcode.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(17, 539)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(735, 52)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTotalBarcodesCount
        '
        Me.lblTotalBarcodesCount.AutoSize = True
        Me.lblTotalBarcodesCount.Location = New System.Drawing.Point(14, 9)
        Me.lblTotalBarcodesCount.Name = "lblTotalBarcodesCount"
        Me.lblTotalBarcodesCount.Size = New System.Drawing.Size(170, 13)
        Me.lblTotalBarcodesCount.TabIndex = 8
        Me.lblTotalBarcodesCount.Text = "Total Number of Barcodes Found: "
        '
        'resultsList
        '
        Me.resultsList.AutoScroll = True
        Me.resultsList.Location = New System.Drawing.Point(17, 26)
        Me.resultsList.Name = "resultsList"
        Me.resultsList.Size = New System.Drawing.Size(503, 498)
        Me.resultsList.TabIndex = 10
        '
        'btnAztecBarcode
        '
        Me.btnAztecBarcode.Enabled = False
        Me.btnAztecBarcode.Location = New System.Drawing.Point(526, 346)
        Me.btnAztecBarcode.Name = "btnAztecBarcode"
        Me.btnAztecBarcode.Size = New System.Drawing.Size(226, 54)
        Me.btnAztecBarcode.TabIndex = 11
        Me.btnAztecBarcode.Text = "Aztec Barcodes"
        Me.btnAztecBarcode.UseVisualStyleBackColor = True
        '
        'btnMaxicodeBarcode
        '
        Me.btnMaxicodeBarcode.Enabled = False
        Me.btnMaxicodeBarcode.Location = New System.Drawing.Point(526, 410)
        Me.btnMaxicodeBarcode.Name = "btnMaxicodeBarcode"
        Me.btnMaxicodeBarcode.Size = New System.Drawing.Size(226, 54)
        Me.btnMaxicodeBarcode.TabIndex = 12
        Me.btnMaxicodeBarcode.Text = "Maxicodes"
        Me.btnMaxicodeBarcode.UseVisualStyleBackColor = True
        '
        'BarcodeResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 595)
        Me.Controls.Add(Me.btnMaxicodeBarcode)
        Me.Controls.Add(Me.btnAztecBarcode)
        Me.Controls.Add(Me.resultsList)
        Me.Controls.Add(Me.lblTotalBarcodesCount)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPatchCodeBarcode)
        Me.Controls.Add(Me.btnMicroQRBarcode)
        Me.Controls.Add(Me.btnPDF417Barcode)
        Me.Controls.Add(Me.btnQRBarcode)
        Me.Controls.Add(Me.btn2DBarcode)
        Me.Controls.Add(Me.btn1DBarcode)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BarcodeResults"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "BarcodeResults"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1DBarcode As Button
    Friend WithEvents btn2DBarcode As Button
    Friend WithEvents btnQRBarcode As Button
    Friend WithEvents btnPDF417Barcode As Button
    Friend WithEvents btnMicroQRBarcode As Button
    Friend WithEvents btnPatchCodeBarcode As Button
    Friend WithEvents btnAztecBarcode As Button
    Friend WithEvents btnMaxicodeBarcode As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTotalBarcodesCount As Label
    Friend WithEvents resultsList As FlowLayoutPanel
End Class
