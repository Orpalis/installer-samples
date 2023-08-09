<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.cmdParcInputFile = New System.Windows.Forms.Button()
        Me.cmdGo = New System.Windows.Forms.Button()
        Me.cmdParcOutputFile = New System.Windows.Forms.Button()
        Me.txtOutputFile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLandscape = New System.Windows.Forms.RadioButton()
        Me.radPortrait = New System.Windows.Forms.RadioButton()
        Me.txtTextSize = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBottomMargin = New System.Windows.Forms.TextBox()
        Me.txtRightMargin = New System.Windows.Forms.TextBox()
        Me.txtTopMargin = New System.Windows.Forms.TextBox()
        Me.txtLeftMargin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPapers = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text File"
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(99, 26)
        Me.txtInputFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.Size = New System.Drawing.Size(624, 22)
        Me.txtInputFile.TabIndex = 1
        '
        'cmdParcInputFile
        '
        Me.cmdParcInputFile.Location = New System.Drawing.Point(732, 30)
        Me.cmdParcInputFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdParcInputFile.Name = "cmdParcInputFile"
        Me.cmdParcInputFile.Size = New System.Drawing.Size(47, 22)
        Me.cmdParcInputFile.TabIndex = 2
        Me.cmdParcInputFile.Text = "..."
        Me.cmdParcInputFile.UseVisualStyleBackColor = True
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(265, 411)
        Me.cmdGo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(253, 73)
        Me.cmdGo.TabIndex = 3
        Me.cmdGo.Text = "Convert"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'cmdParcOutputFile
        '
        Me.cmdParcOutputFile.Location = New System.Drawing.Point(732, 69)
        Me.cmdParcOutputFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdParcOutputFile.Name = "cmdParcOutputFile"
        Me.cmdParcOutputFile.Size = New System.Drawing.Size(47, 22)
        Me.cmdParcOutputFile.TabIndex = 6
        Me.cmdParcOutputFile.Text = "..."
        Me.cmdParcOutputFile.UseVisualStyleBackColor = True
        '
        'txtOutputFile
        '
        Me.txtOutputFile.Location = New System.Drawing.Point(99, 65)
        Me.txtOutputFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOutputFile.Name = "txtOutputFile"
        Me.txtOutputFile.Size = New System.Drawing.Size(624, 22)
        Me.txtOutputFile.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pdf File"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 491)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(741, 26)
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radLandscape)
        Me.GroupBox1.Controls.Add(Me.radPortrait)
        Me.GroupBox1.Controls.Add(Me.txtTextSize)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cboPapers)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 128)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(716, 256)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PDF page format"
        '
        'radLandscape
        '
        Me.radLandscape.AutoSize = True
        Me.radLandscape.Location = New System.Drawing.Point(503, 60)
        Me.radLandscape.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radLandscape.Name = "radLandscape"
        Me.radLandscape.Size = New System.Drawing.Size(99, 21)
        Me.radLandscape.TabIndex = 16
        Me.radLandscape.Text = "Landscape"
        Me.radLandscape.UseVisualStyleBackColor = True
        '
        'radPortrait
        '
        Me.radPortrait.AutoSize = True
        Me.radPortrait.Checked = True
        Me.radPortrait.Location = New System.Drawing.Point(389, 60)
        Me.radPortrait.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radPortrait.Name = "radPortrait"
        Me.radPortrait.Size = New System.Drawing.Size(75, 21)
        Me.radPortrait.TabIndex = 15
        Me.radPortrait.TabStop = True
        Me.radPortrait.Text = "Portrait"
        Me.radPortrait.UseVisualStyleBackColor = True
        '
        'txtTextSize
        '
        Me.txtTextSize.Location = New System.Drawing.Point(175, 218)
        Me.txtTextSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTextSize.Name = "txtTextSize"
        Me.txtTextSize.Size = New System.Drawing.Size(111, 22)
        Me.txtTextSize.TabIndex = 14
        Me.txtTextSize.Text = "10"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 226)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Text Size in points"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBottomMargin)
        Me.GroupBox2.Controls.Add(Me.txtRightMargin)
        Me.GroupBox2.Controls.Add(Me.txtTopMargin)
        Me.GroupBox2.Controls.Add(Me.txtLeftMargin)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 103)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(620, 94)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Margins in millimeters"
        '
        'txtBottomMargin
        '
        Me.txtBottomMargin.Location = New System.Drawing.Point(396, 62)
        Me.txtBottomMargin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBottomMargin.Name = "txtBottomMargin"
        Me.txtBottomMargin.Size = New System.Drawing.Size(111, 22)
        Me.txtBottomMargin.TabIndex = 15
        Me.txtBottomMargin.Text = "0"
        '
        'txtRightMargin
        '
        Me.txtRightMargin.Location = New System.Drawing.Point(396, 34)
        Me.txtRightMargin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRightMargin.Name = "txtRightMargin"
        Me.txtRightMargin.Size = New System.Drawing.Size(111, 22)
        Me.txtRightMargin.TabIndex = 14
        Me.txtRightMargin.Text = "0"
        '
        'txtTopMargin
        '
        Me.txtTopMargin.Location = New System.Drawing.Point(139, 62)
        Me.txtTopMargin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTopMargin.Name = "txtTopMargin"
        Me.txtTopMargin.Size = New System.Drawing.Size(111, 22)
        Me.txtTopMargin.TabIndex = 13
        Me.txtTopMargin.Text = "0"
        '
        'txtLeftMargin
        '
        Me.txtLeftMargin.Location = New System.Drawing.Point(139, 34)
        Me.txtLeftMargin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLeftMargin.Name = "txtLeftMargin"
        Me.txtLeftMargin.Size = New System.Drawing.Size(111, 22)
        Me.txtLeftMargin.TabIndex = 12
        Me.txtLeftMargin.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 65)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Bottom  margin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Right margin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Top margin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Left margin"
        '
        'cboPapers
        '
        Me.cboPapers.FormattingEnabled = True
        Me.cboPapers.Location = New System.Drawing.Point(153, 20)
        Me.cboPapers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPapers.Name = "cboPapers"
        Me.cboPapers.Size = New System.Drawing.Size(452, 24)
        Me.cboPapers.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Paper Size"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 532)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cmdParcOutputFile)
        Me.Controls.Add(Me.txtOutputFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.cmdParcInputFile)
        Me.Controls.Add(Me.txtInputFile)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Text File to PDF Demo  -  http://www.gdpicture.com"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInputFile As System.Windows.Forms.TextBox
    Friend WithEvents cmdParcInputFile As System.Windows.Forms.Button
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents cmdParcOutputFile As System.Windows.Forms.Button
    Friend WithEvents txtOutputFile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPapers As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTextSize As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBottomMargin As System.Windows.Forms.TextBox
    Friend WithEvents txtRightMargin As System.Windows.Forms.TextBox
    Friend WithEvents txtTopMargin As System.Windows.Forms.TextBox
    Friend WithEvents txtLeftMargin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents radLandscape As System.Windows.Forms.RadioButton
    Friend WithEvents radPortrait As System.Windows.Forms.RadioButton

End Class
