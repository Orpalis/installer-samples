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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btStartOCR = New System.Windows.Forms.Button()
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.btBrowsInput = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Language = New System.Windows.Forms.Label()
        Me.btBrowsOCRDict = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDictsPath = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.chkMultithread = New System.Windows.Forms.CheckBox()
        Me.cmbLang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkFavorAccuracy = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 159)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(536, 30)
        Me.ProgressBar1.TabIndex = 0
        '
        'btStartOCR
        '
        Me.btStartOCR.Location = New System.Drawing.Point(550, 159)
        Me.btStartOCR.Name = "btStartOCR"
        Me.btStartOCR.Size = New System.Drawing.Size(95, 30)
        Me.btStartOCR.TabIndex = 1
        Me.btStartOCR.Text = "Start !"
        Me.btStartOCR.UseVisualStyleBackColor = True
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(97, 10)
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.ReadOnly = True
        Me.txtInputFile.Size = New System.Drawing.Size(505, 20)
        Me.txtInputFile.TabIndex = 2
        '
        'btBrowsInput
        '
        Me.btBrowsInput.Location = New System.Drawing.Point(606, 10)
        Me.btBrowsInput.Name = "btBrowsInput"
        Me.btBrowsInput.Size = New System.Drawing.Size(39, 17)
        Me.btBrowsInput.TabIndex = 3
        Me.btBrowsInput.Text = "..."
        Me.btBrowsInput.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input file:"
        '
        'Language
        '
        Me.Language.AutoSize = True
        Me.Language.Location = New System.Drawing.Point(9, 63)
        Me.Language.Name = "Language"
        Me.Language.Size = New System.Drawing.Size(58, 13)
        Me.Language.TabIndex = 8
        Me.Language.Text = "Language:"
        '
        'btBrowsOCRDict
        '
        Me.btBrowsOCRDict.Location = New System.Drawing.Point(606, 37)
        Me.btBrowsOCRDict.Name = "btBrowsOCRDict"
        Me.btBrowsOCRDict.Size = New System.Drawing.Size(39, 17)
        Me.btBrowsOCRDict.TabIndex = 12
        Me.btBrowsOCRDict.Text = "..."
        Me.btBrowsOCRDict.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Dictionary path:"
        '
        'txtDictsPath
        '
        Me.txtDictsPath.Location = New System.Drawing.Point(97, 37)
        Me.txtDictsPath.Name = "txtDictsPath"
        Me.txtDictsPath.Size = New System.Drawing.Size(505, 20)
        Me.txtDictsPath.TabIndex = 10
        Me.txtDictsPath.Text = "C:\Program Files\GdPicture.NET 12\Redist\OCR"
        '
        'chkMultithread
        '
        Me.chkMultithread.AutoSize = True
        Me.chkMultithread.Checked = True
        Me.chkMultithread.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMultithread.Location = New System.Drawing.Point(97, 92)
        Me.chkMultithread.Name = "chkMultithread"
        Me.chkMultithread.Size = New System.Drawing.Size(121, 17)
        Me.chkMultithread.TabIndex = 31
        Me.chkMultithread.Text = "Use multiple threads"
        Me.chkMultithread.UseVisualStyleBackColor = True
        '
        'cmbLang
        '
        Me.cmbLang.FormattingEnabled = True
        Me.cmbLang.Location = New System.Drawing.Point(97, 61)
        Me.cmbLang.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.Size = New System.Drawing.Size(121, 21)
        Me.cmbLang.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(427, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "You can combine languages using the + operator, ex: ""eng+spa"" for English and Spa" &
    "nish"
        '
        'chkFavorAccuracy
        '
        Me.chkFavorAccuracy.AutoSize = True
        Me.chkFavorAccuracy.Location = New System.Drawing.Point(97, 115)
        Me.chkFavorAccuracy.Name = "chkFavorAccuracy"
        Me.chkFavorAccuracy.Size = New System.Drawing.Size(139, 17)
        Me.chkFavorAccuracy.TabIndex = 34
        Me.chkFavorAccuracy.Text = "Favor accuracy (slower)"
        Me.chkFavorAccuracy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 196)
        Me.Controls.Add(Me.chkFavorAccuracy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbLang)
        Me.Controls.Add(Me.chkMultithread)
        Me.Controls.Add(Me.btBrowsOCRDict)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDictsPath)
        Me.Controls.Add(Me.Language)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btBrowsInput)
        Me.Controls.Add(Me.txtInputFile)
        Me.Controls.Add(Me.btStartOCR)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET TIFF to PDF/OCR Sample  -  http://www.gdpicture.com"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btStartOCR As System.Windows.Forms.Button
    Friend WithEvents txtInputFile As System.Windows.Forms.TextBox
    Friend WithEvents btBrowsInput As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Language As System.Windows.Forms.Label
    Friend WithEvents btBrowsOCRDict As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDictsPath As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkMultithread As CheckBox
    Friend WithEvents cmbLang As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkFavorAccuracy As CheckBox
End Class
