<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Despeckle
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbDespeckleMode = New System.Windows.Forms.ComboBox()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lblDespeckleType = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtThresholdMin = New System.Windows.Forms.Label()
        Me.scrlStrengthParam = New System.Windows.Forms.HScrollBar()
        Me.txtThresholdMax = New System.Windows.Forms.Label()
        Me.txtStrengthVal = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel7.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.TableLayoutPanel4.SuspendLayout
        Me.SuspendLayout
        '
        'cmbDespeckleMode
        '
        Me.cmbDespeckleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDespeckleMode.FormattingEnabled = true
        Me.cmbDespeckleMode.Location = New System.Drawing.Point(120, 18)
        Me.cmbDespeckleMode.Name = "cmbDespeckleMode"
        Me.cmbDespeckleMode.Size = New System.Drawing.Size(285, 28)
        Me.cmbDespeckleMode.TabIndex = 9
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 3
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 4
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblDespeckleType
        '
        Me.lblDespeckleType.AutoSize = true
        Me.lblDespeckleType.Location = New System.Drawing.Point(30, 21)
        Me.lblDespeckleType.Name = "lblDespeckleType"
        Me.lblDespeckleType.Size = New System.Drawing.Size(49, 20)
        Me.lblDespeckleType.TabIndex = 11
        Me.lblDespeckleType.Text = "Mode"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(437, 140)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel7.ColumnCount = 5
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.28925!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.71074!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtThresholdMin, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.scrlStrengthParam, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtThresholdMax, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtStrengthVal, 4, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(9, 9)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(612, 38)
        Me.TableLayoutPanel7.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = true
        Me.Label15.Location = New System.Drawing.Point(4, 9)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Strength"
        '
        'txtThresholdMin
        '
        Me.txtThresholdMin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtThresholdMin.AutoSize = true
        Me.txtThresholdMin.Location = New System.Drawing.Point(83, 9)
        Me.txtThresholdMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtThresholdMin.Name = "txtThresholdMin"
        Me.txtThresholdMin.Size = New System.Drawing.Size(18, 20)
        Me.txtThresholdMin.TabIndex = 1
        Me.txtThresholdMin.Text = "0"
        '
        'scrlStrengthParam
        '
        Me.scrlStrengthParam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scrlStrengthParam.LargeChange = 1
        Me.scrlStrengthParam.Location = New System.Drawing.Point(120, 6)
        Me.scrlStrengthParam.Name = "scrlStrengthParam"
        Me.scrlStrengthParam.Size = New System.Drawing.Size(285, 26)
        Me.scrlStrengthParam.TabIndex = 2
        Me.scrlStrengthParam.Value = 5
        '
        'txtThresholdMax
        '
        Me.txtThresholdMax.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtThresholdMax.AutoSize = true
        Me.txtThresholdMax.Location = New System.Drawing.Point(415, 9)
        Me.txtThresholdMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtThresholdMax.Name = "txtThresholdMax"
        Me.txtThresholdMax.Size = New System.Drawing.Size(36, 20)
        Me.txtThresholdMax.TabIndex = 3
        Me.txtThresholdMax.Text = "100"
        '
        'txtStrengthVal
        '
        Me.txtStrengthVal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtStrengthVal.Enabled = false
        Me.txtStrengthVal.Location = New System.Drawing.Point(472, 6)
        Me.txtStrengthVal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtStrengthVal.Name = "txtStrengthVal"
        Me.txtStrengthVal.Size = New System.Drawing.Size(110, 26)
        Me.txtStrengthVal.TabIndex = 99
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(13, 52)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(638, 63)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(4, 3)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.24675!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.75325!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(630, 57)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'Despeckle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 202)
        Me.Controls.Add(Me.cmbDespeckleMode)
        Me.Controls.Add(Me.lblDespeckleType)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Despeckle"
        Me.ShowInTaskbar = false
        Me.Text = "Despeckle"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel7.ResumeLayout(false)
        Me.TableLayoutPanel7.PerformLayout
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel4.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents cmbDespeckleMode As ComboBox
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Private WithEvents lblDespeckleType As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents txtThresholdMin As Label
    Friend WithEvents scrlStrengthParam As HScrollBar
    Friend WithEvents txtThresholdMax As Label
    Friend WithEvents txtStrengthVal As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
End Class
