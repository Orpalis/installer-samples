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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDPI = New System.Windows.Forms.TextBox()
        Me.chkIncSave = New System.Windows.Forms.CheckBox()
        Me.chkMultithread = New System.Windows.Forms.CheckBox()
        Me.cmbLang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 206)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(804, 46)
        Me.ProgressBar1.TabIndex = 0
        '
        'btStartOCR
        '
        Me.btStartOCR.Location = New System.Drawing.Point(825, 206)
        Me.btStartOCR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btStartOCR.Name = "btStartOCR"
        Me.btStartOCR.Size = New System.Drawing.Size(142, 46)
        Me.btStartOCR.TabIndex = 1
        Me.btStartOCR.Text = "Start !"
        Me.btStartOCR.UseVisualStyleBackColor = True
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(145, 16)
        Me.txtInputFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.ReadOnly = True
        Me.txtInputFile.Size = New System.Drawing.Size(756, 26)
        Me.txtInputFile.TabIndex = 2
        '
        'btBrowsInput
        '
        Me.btBrowsInput.Location = New System.Drawing.Point(909, 16)
        Me.btBrowsInput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btBrowsInput.Name = "btBrowsInput"
        Me.btBrowsInput.Size = New System.Drawing.Size(58, 26)
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
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input file:"
        '
        'Language
        '
        Me.Language.AutoSize = True
        Me.Language.Location = New System.Drawing.Point(13, 97)
        Me.Language.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Language.Name = "Language"
        Me.Language.Size = New System.Drawing.Size(85, 20)
        Me.Language.TabIndex = 8
        Me.Language.Text = "Language:"
        '
        'btBrowsOCRDict
        '
        Me.btBrowsOCRDict.Location = New System.Drawing.Point(909, 57)
        Me.btBrowsOCRDict.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btBrowsOCRDict.Name = "btBrowsOCRDict"
        Me.btBrowsOCRDict.Size = New System.Drawing.Size(58, 26)
        Me.btBrowsOCRDict.TabIndex = 12
        Me.btBrowsOCRDict.Text = "..."
        Me.btBrowsOCRDict.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Dictionary path:"
        '
        'txtDictsPath
        '
        Me.txtDictsPath.Location = New System.Drawing.Point(145, 57)
        Me.txtDictsPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDictsPath.Name = "txtDictsPath"
        Me.txtDictsPath.ReadOnly = True
        Me.txtDictsPath.Size = New System.Drawing.Size(756, 26)
        Me.txtDictsPath.TabIndex = 10
        Me.txtDictsPath.Text = "C:\Program Files\GdPicture.NET 14\Redist\OCR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "DPI:"
        '
        'txtDPI
        '
        Me.txtDPI.Location = New System.Drawing.Point(145, 130)
        Me.txtDPI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.Size = New System.Drawing.Size(48, 26)
        Me.txtDPI.TabIndex = 16
        Me.txtDPI.Text = "200"
        '
        'chkIncSave
        '
        Me.chkIncSave.AutoSize = True
        Me.chkIncSave.Location = New System.Drawing.Point(333, 172)
        Me.chkIncSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkIncSave.Name = "chkIncSave"
        Me.chkIncSave.Size = New System.Drawing.Size(199, 24)
        Me.chkIncSave.TabIndex = 30
        Me.chkIncSave.Text = "Use incremental saving"
        Me.chkIncSave.UseVisualStyleBackColor = True
        '
        'chkMultithread
        '
        Me.chkMultithread.AutoSize = True
        Me.chkMultithread.Checked = True
        Me.chkMultithread.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMultithread.Location = New System.Drawing.Point(145, 172)
        Me.chkMultithread.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkMultithread.Name = "chkMultithread"
        Me.chkMultithread.Size = New System.Drawing.Size(180, 24)
        Me.chkMultithread.TabIndex = 31
        Me.chkMultithread.Text = "Use multiple threads"
        Me.chkMultithread.UseVisualStyleBackColor = True
        '
        'cmbLang
        '
        Me.cmbLang.FormattingEnabled = True
        Me.cmbLang.Location = New System.Drawing.Point(145, 94)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.Size = New System.Drawing.Size(180, 28)
        Me.cmbLang.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(634, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "You can combine languages using the + operator, ex: ""eng+spa"" for English and Spa" &
    "nish"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 267)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbLang)
        Me.Controls.Add(Me.chkMultithread)
        Me.Controls.Add(Me.chkIncSave)
        Me.Controls.Add(Me.txtDPI)
        Me.Controls.Add(Me.Label2)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET PDF to PDF/OCR Sample  -  http://www.gdpicture.com"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDPI As System.Windows.Forms.TextBox
    Friend WithEvents chkIncSave As System.Windows.Forms.CheckBox
    Friend WithEvents chkMultithread As CheckBox
    Friend WithEvents cmbLang As ComboBox
    Friend WithEvents Label3 As Label
End Class
