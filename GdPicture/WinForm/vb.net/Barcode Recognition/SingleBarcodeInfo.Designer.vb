<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleBarcodeInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BarcodeNumber = New System.Windows.Forms.GroupBox()
        Me.Info = New System.Windows.Forms.RichTextBox()
        Me.BarcodeNumber.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarcodeNumber
        '
        Me.BarcodeNumber.Controls.Add(Me.Info)
        Me.BarcodeNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarcodeNumber.Location = New System.Drawing.Point(0, 0)
        Me.BarcodeNumber.Name = "BarcodeNumber"
        Me.BarcodeNumber.Size = New System.Drawing.Size(454, 122)
        Me.BarcodeNumber.TabIndex = 0
        Me.BarcodeNumber.TabStop = False
        '
        'Info
        '
        Me.Info.BackColor = System.Drawing.SystemColors.Menu
        Me.Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Info.Location = New System.Drawing.Point(3, 16)
        Me.Info.Name = "Info"
        Me.Info.ReadOnly = True
        Me.Info.Size = New System.Drawing.Size(448, 103)
        Me.Info.TabIndex = 0
        Me.Info.Text = ""
        '
        'SingleBarcodeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BarcodeNumber)
        Me.Name = "SingleBarcodeInfo"
        Me.Size = New System.Drawing.Size(454, 122)
        Me.BarcodeNumber.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarcodeNumber As System.Windows.Forms.GroupBox
    Friend WithEvents Info As System.Windows.Forms.RichTextBox

End Class
