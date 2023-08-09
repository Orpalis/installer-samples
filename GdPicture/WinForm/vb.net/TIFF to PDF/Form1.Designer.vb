<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.btStart = New System.Windows.Forms.Button()
        Me.btBrowsDstFolder = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDstFolder = New System.Windows.Forms.TextBox()
        Me.btBrowsSrcFile = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.chkPdfa = New System.Windows.Forms.CheckBox()
        Me.chkEnableColorDetection = New System.Windows.Forms.CheckBox()
        Me.chkEnableMRC = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(17, 199)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(775, 25)
        Me.ProgressBar1.TabIndex = 42
        Me.ProgressBar1.Visible = False
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(800, 183)
        Me.btStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(193, 41)
        Me.btStart.TabIndex = 41
        Me.btStart.Text = "Start !"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'btBrowsDstFolder
        '
        Me.btBrowsDstFolder.Location = New System.Drawing.Point(741, 62)
        Me.btBrowsDstFolder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btBrowsDstFolder.Name = "btBrowsDstFolder"
        Me.btBrowsDstFolder.Size = New System.Drawing.Size(47, 25)
        Me.btBrowsDstFolder.TabIndex = 40
        Me.btBrowsDstFolder.Text = "..."
        Me.btBrowsDstFolder.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Destination folder:"
        '
        'txtDstFolder
        '
        Me.txtDstFolder.Location = New System.Drawing.Point(144, 62)
        Me.txtDstFolder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDstFolder.Name = "txtDstFolder"
        Me.txtDstFolder.ReadOnly = True
        Me.txtDstFolder.Size = New System.Drawing.Size(588, 22)
        Me.txtDstFolder.TabIndex = 38
        '
        'btBrowsSrcFile
        '
        Me.btBrowsSrcFile.Location = New System.Drawing.Point(741, 30)
        Me.btBrowsSrcFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btBrowsSrcFile.Name = "btBrowsSrcFile"
        Me.btBrowsSrcFile.Size = New System.Drawing.Size(47, 25)
        Me.btBrowsSrcFile.TabIndex = 37
        Me.btBrowsSrcFile.Text = "..."
        Me.btBrowsSrcFile.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Input file:"
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(144, 30)
        Me.txtInputFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.ReadOnly = True
        Me.txtInputFile.Size = New System.Drawing.Size(588, 22)
        Me.txtInputFile.TabIndex = 35
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'chkPdfa
        '
        Me.chkPdfa.AutoSize = True
        Me.chkPdfa.Location = New System.Drawing.Point(17, 111)
        Me.chkPdfa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPdfa.Name = "chkPdfa"
        Me.chkPdfa.Size = New System.Drawing.Size(134, 21)
        Me.chkPdfa.TabIndex = 43
        Me.chkPdfa.Text = "Generate PDF/A"
        Me.chkPdfa.UseVisualStyleBackColor = True
        '
        'chkEnableColorDetection
        '
        Me.chkEnableColorDetection.AutoSize = True
        Me.chkEnableColorDetection.Location = New System.Drawing.Point(17, 134)
        Me.chkEnableColorDetection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkEnableColorDetection.Name = "chkEnableColorDetection"
        Me.chkEnableColorDetection.Size = New System.Drawing.Size(175, 21)
        Me.chkEnableColorDetection.TabIndex = 44
        Me.chkEnableColorDetection.Text = "Enable Color Detection"
        Me.chkEnableColorDetection.UseVisualStyleBackColor = True
        '
        'chkEnableMRC
        '
        Me.chkEnableMRC.AutoSize = True
        Me.chkEnableMRC.Location = New System.Drawing.Point(17, 161)
        Me.chkEnableMRC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkEnableMRC.Name = "chkEnableMRC"
        Me.chkEnableMRC.Size = New System.Drawing.Size(290, 21)
        Me.chkEnableMRC.TabIndex = 45
        Me.chkEnableMRC.Text = "Enable Mixed Raster Compression (MRC)"
        Me.chkEnableMRC.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 235)
        Me.Controls.Add(Me.chkEnableMRC)
        Me.Controls.Add(Me.chkEnableColorDetection)
        Me.Controls.Add(Me.chkPdfa)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.btBrowsDstFolder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDstFolder)
        Me.Controls.Add(Me.btBrowsSrcFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInputFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - TIFF to PDF Demo  -  http://www.gdpicture.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents btBrowsDstFolder As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDstFolder As System.Windows.Forms.TextBox
    Friend WithEvents btBrowsSrcFile As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInputFile As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkPdfa As CheckBox
    Friend WithEvents chkEnableColorDetection As CheckBox
    Friend WithEvents chkEnableMRC As CheckBox
End Class
