<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMultipleOMRFieldDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.numberOfFieldsPerQuestion = New System.Windows.Forms.NumericUpDown
        Me.numberOfQuestions = New System.Windows.Forms.NumericUpDown
        Me.numberOfRectanglesPanel = New System.Windows.Forms.TableLayoutPanel
        Me.rectanglesLeftLabel = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numberOfFieldsPerQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfQuestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.numberOfRectanglesPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(354, 103)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(88, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Number of Fields Per Question"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number of Questions"
        '
        'numberOfFieldsPerQuestion
        '
        Me.numberOfFieldsPerQuestion.Location = New System.Drawing.Point(204, 78)
        Me.numberOfFieldsPerQuestion.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numberOfFieldsPerQuestion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numberOfFieldsPerQuestion.Name = "numberOfFieldsPerQuestion"
        Me.numberOfFieldsPerQuestion.Size = New System.Drawing.Size(120, 24)
        Me.numberOfFieldsPerQuestion.TabIndex = 5
        Me.numberOfFieldsPerQuestion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numberOfQuestions
        '
        Me.numberOfQuestions.Location = New System.Drawing.Point(204, 29)
        Me.numberOfQuestions.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.numberOfQuestions.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numberOfQuestions.Name = "numberOfQuestions"
        Me.numberOfQuestions.Size = New System.Drawing.Size(120, 24)
        Me.numberOfQuestions.TabIndex = 4
        Me.numberOfQuestions.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numberOfRectanglesPanel
        '
        Me.numberOfRectanglesPanel.BackColor = System.Drawing.Color.Transparent
        Me.numberOfRectanglesPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.numberOfRectanglesPanel.ColumnCount = 6
        Me.numberOfRectanglesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.numberOfRectanglesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.numberOfRectanglesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.numberOfRectanglesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.numberOfRectanglesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.numberOfRectanglesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237.0!))
        Me.numberOfRectanglesPanel.Controls.Add(Me.rectanglesLeftLabel, 3, 0)
        Me.numberOfRectanglesPanel.Location = New System.Drawing.Point(0, 0)
        Me.numberOfRectanglesPanel.Name = "numberOfRectanglesPanel"
        Me.numberOfRectanglesPanel.RowCount = 1
        Me.numberOfRectanglesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.numberOfRectanglesPanel.Size = New System.Drawing.Size(200, 100)
        Me.numberOfRectanglesPanel.TabIndex = 0
        '
        'rectanglesLeftLabel
        '
        Me.rectanglesLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rectanglesLeftLabel.AutoSize = True
        Me.rectanglesLeftLabel.BackColor = System.Drawing.Color.Transparent
        Me.rectanglesLeftLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rectanglesLeftLabel.Location = New System.Drawing.Point(320, 41)
        Me.rectanglesLeftLabel.Name = "rectanglesLeftLabel"
        Me.rectanglesLeftLabel.Size = New System.Drawing.Size(16, 17)
        Me.rectanglesLeftLabel.TabIndex = 3
        Me.rectanglesLeftLabel.Text = "0"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label2.Location = New System.Drawing.Point(204, 192)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(106, 17)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Rectangles Left:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numberOfQuestions)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.numberOfFieldsPerQuestion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 139)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'AddMultipleOMRFieldDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(536, 172)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddMultipleOMRFieldDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Multiple OMR Field"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.numberOfFieldsPerQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfQuestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.numberOfRectanglesPanel.ResumeLayout(False)
        Me.numberOfRectanglesPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numberOfFieldsPerQuestion As System.Windows.Forms.NumericUpDown
    Friend WithEvents numberOfQuestions As System.Windows.Forms.NumericUpDown
    Friend WithEvents numberOfRectanglesPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rectanglesLeftLabel As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
