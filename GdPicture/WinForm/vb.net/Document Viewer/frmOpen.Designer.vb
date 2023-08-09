<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpen))
        Me.pOpenFromFile = New System.Windows.Forms.Panel()
        Me.btOpenFromFile = New System.Windows.Forms.Button()
        Me.tbFile = New System.Windows.Forms.TextBox()
        Me.rbOpenFromFile = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rbOpenFromHTTP = New System.Windows.Forms.RadioButton()
        Me.pOpenFromHTTP = New System.Windows.Forms.Panel()
        Me.tbOpenFromHTTP = New System.Windows.Forms.TextBox()
        Me.rbOpenFromFTP = New System.Windows.Forms.RadioButton()
        Me.pOpenFromFTP = New System.Windows.Forms.Panel()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.tbHost = New System.Windows.Forms.TextBox()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.rbOpenFromClipboard = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pOpenFromFile.SuspendLayout()
        Me.pOpenFromHTTP.SuspendLayout()
        Me.pOpenFromFTP.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pOpenFromFile
        '
        Me.pOpenFromFile.AutoSize = True
        Me.pOpenFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pOpenFromFile.Controls.Add(Me.btOpenFromFile)
        Me.pOpenFromFile.Controls.Add(Me.tbFile)
        Me.pOpenFromFile.Location = New System.Drawing.Point(17, 44)
        Me.pOpenFromFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pOpenFromFile.Name = "pOpenFromFile"
        Me.pOpenFromFile.Size = New System.Drawing.Size(633, 33)
        Me.pOpenFromFile.TabIndex = 0
        '
        'btOpenFromFile
        '
        Me.btOpenFromFile.Location = New System.Drawing.Point(529, 1)
        Me.btOpenFromFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btOpenFromFile.Name = "btOpenFromFile"
        Me.btOpenFromFile.Size = New System.Drawing.Size(100, 28)
        Me.btOpenFromFile.TabIndex = 1
        Me.btOpenFromFile.Text = "Browse..."
        Me.btOpenFromFile.UseVisualStyleBackColor = True
        '
        'tbFile
        '
        Me.tbFile.Location = New System.Drawing.Point(4, 4)
        Me.tbFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbFile.Name = "tbFile"
        Me.tbFile.ReadOnly = True
        Me.tbFile.Size = New System.Drawing.Size(516, 22)
        Me.tbFile.TabIndex = 0
        '
        'rbOpenFromFile
        '
        Me.rbOpenFromFile.AutoSize = True
        Me.rbOpenFromFile.Location = New System.Drawing.Point(56, 16)
        Me.rbOpenFromFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbOpenFromFile.Name = "rbOpenFromFile"
        Me.rbOpenFromFile.Size = New System.Drawing.Size(118, 21)
        Me.rbOpenFromFile.TabIndex = 1
        Me.rbOpenFromFile.TabStop = True
        Me.rbOpenFromFile.Text = "Open from file"
        Me.rbOpenFromFile.UseVisualStyleBackColor = True
        '
        'rbOpenFromHTTP
        '
        Me.rbOpenFromHTTP.AutoSize = True
        Me.rbOpenFromHTTP.Location = New System.Drawing.Point(56, 98)
        Me.rbOpenFromHTTP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbOpenFromHTTP.Name = "rbOpenFromHTTP"
        Me.rbOpenFromHTTP.Size = New System.Drawing.Size(137, 21)
        Me.rbOpenFromHTTP.TabIndex = 2
        Me.rbOpenFromHTTP.TabStop = True
        Me.rbOpenFromHTTP.Text = "Open from HTTP"
        Me.rbOpenFromHTTP.UseVisualStyleBackColor = True
        '
        'pOpenFromHTTP
        '
        Me.pOpenFromHTTP.AutoSize = True
        Me.pOpenFromHTTP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pOpenFromHTTP.Controls.Add(Me.tbOpenFromHTTP)
        Me.pOpenFromHTTP.Location = New System.Drawing.Point(21, 133)
        Me.pOpenFromHTTP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pOpenFromHTTP.Name = "pOpenFromHTTP"
        Me.pOpenFromHTTP.Size = New System.Drawing.Size(627, 26)
        Me.pOpenFromHTTP.TabIndex = 3
        '
        'tbOpenFromHTTP
        '
        Me.tbOpenFromHTTP.Location = New System.Drawing.Point(0, 0)
        Me.tbOpenFromHTTP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbOpenFromHTTP.Name = "tbOpenFromHTTP"
        Me.tbOpenFromHTTP.Size = New System.Drawing.Size(623, 22)
        Me.tbOpenFromHTTP.TabIndex = 0
        Me.tbOpenFromHTTP.Text = "http://download.bitsdujour.com/software/screenshot/orpalis-pdf-ocr-desktop-editio" &
    "n-dbigw.png"
        '
        'rbOpenFromFTP
        '
        Me.rbOpenFromFTP.AutoSize = True
        Me.rbOpenFromFTP.Location = New System.Drawing.Point(56, 180)
        Me.rbOpenFromFTP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbOpenFromFTP.Name = "rbOpenFromFTP"
        Me.rbOpenFromFTP.Size = New System.Drawing.Size(126, 21)
        Me.rbOpenFromFTP.TabIndex = 4
        Me.rbOpenFromFTP.TabStop = True
        Me.rbOpenFromFTP.Text = "Open from FTP"
        Me.rbOpenFromFTP.UseVisualStyleBackColor = True
        '
        'pOpenFromFTP
        '
        Me.pOpenFromFTP.AutoSize = True
        Me.pOpenFromFTP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pOpenFromFTP.Controls.Add(Me.tbPassword)
        Me.pOpenFromFTP.Controls.Add(Me.lblPassword)
        Me.pOpenFromFTP.Controls.Add(Me.tbLogin)
        Me.pOpenFromFTP.Controls.Add(Me.lblLogin)
        Me.pOpenFromFTP.Controls.Add(Me.tbPath)
        Me.pOpenFromFTP.Controls.Add(Me.lblPath)
        Me.pOpenFromFTP.Controls.Add(Me.tbPort)
        Me.pOpenFromFTP.Controls.Add(Me.lblPort)
        Me.pOpenFromFTP.Controls.Add(Me.tbHost)
        Me.pOpenFromFTP.Controls.Add(Me.lblHost)
        Me.pOpenFromFTP.Location = New System.Drawing.Point(17, 208)
        Me.pOpenFromFTP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pOpenFromFTP.Name = "pOpenFromFTP"
        Me.pOpenFromFTP.Size = New System.Drawing.Size(632, 95)
        Me.pOpenFromFTP.TabIndex = 5
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(392, 69)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(236, 22)
        Me.tbPassword.TabIndex = 9
        Me.tbPassword.Text = "Anonymous"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(313, 73)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password"
        '
        'tbLogin
        '
        Me.tbLogin.Location = New System.Drawing.Point(52, 69)
        Me.tbLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(236, 22)
        Me.tbLogin.TabIndex = 7
        Me.tbLogin.Text = "Anonymous"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(5, 73)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(43, 17)
        Me.lblLogin.TabIndex = 6
        Me.lblLogin.Text = "Login"
        '
        'tbPath
        '
        Me.tbPath.Location = New System.Drawing.Point(52, 37)
        Me.tbPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(576, 22)
        Me.tbPath.TabIndex = 5
        Me.tbPath.Text = "/design/processor/datashts/325567.pdf"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(5, 41)
        Me.lblPath.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(37, 17)
        Me.lblPath.TabIndex = 4
        Me.lblPath.Text = "Path"
        '
        'tbPort
        '
        Me.tbPort.Location = New System.Drawing.Point(559, 4)
        Me.tbPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(69, 22)
        Me.tbPort.TabIndex = 3
        Me.tbPort.Text = "21"
        Me.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(516, 9)
        Me.lblPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(34, 17)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "Port"
        '
        'tbHost
        '
        Me.tbHost.Location = New System.Drawing.Point(52, 5)
        Me.tbHost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbHost.Name = "tbHost"
        Me.tbHost.Size = New System.Drawing.Size(455, 22)
        Me.tbHost.TabIndex = 1
        Me.tbHost.Text = "ftp://download.intel.com"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(4, 9)
        Me.lblHost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(37, 17)
        Me.lblHost.TabIndex = 0
        Me.lblHost.Text = "Host"
        '
        'rbOpenFromClipboard
        '
        Me.rbOpenFromClipboard.AutoSize = True
        Me.rbOpenFromClipboard.Location = New System.Drawing.Point(56, 331)
        Me.rbOpenFromClipboard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbOpenFromClipboard.Name = "rbOpenFromClipboard"
        Me.rbOpenFromClipboard.Size = New System.Drawing.Size(158, 21)
        Me.rbOpenFromClipboard.TabIndex = 6
        Me.rbOpenFromClipboard.TabStop = True
        Me.rbOpenFromClipboard.Text = "Open from clipboard"
        Me.rbOpenFromClipboard.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(551, 361)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(444, 361)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(99, 28)
        Me.btnOpen.TabIndex = 33
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(21, 95)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(21, 176)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(21, 327)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'frmOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(671, 407)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.rbOpenFromClipboard)
        Me.Controls.Add(Me.pOpenFromFTP)
        Me.Controls.Add(Me.rbOpenFromFTP)
        Me.Controls.Add(Me.pOpenFromHTTP)
        Me.Controls.Add(Me.rbOpenFromHTTP)
        Me.Controls.Add(Me.rbOpenFromFile)
        Me.Controls.Add(Me.pOpenFromFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Open"
        Me.pOpenFromFile.ResumeLayout(False)
        Me.pOpenFromFile.PerformLayout()
        Me.pOpenFromHTTP.ResumeLayout(False)
        Me.pOpenFromHTTP.PerformLayout()
        Me.pOpenFromFTP.ResumeLayout(False)
        Me.pOpenFromFTP.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pOpenFromFile As System.Windows.Forms.Panel
    Friend WithEvents btOpenFromFile As System.Windows.Forms.Button
    Friend WithEvents tbFile As System.Windows.Forms.TextBox
    Friend WithEvents rbOpenFromFile As System.Windows.Forms.RadioButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents rbOpenFromHTTP As System.Windows.Forms.RadioButton
    Friend WithEvents pOpenFromHTTP As System.Windows.Forms.Panel
    Friend WithEvents tbOpenFromHTTP As System.Windows.Forms.TextBox
    Friend WithEvents rbOpenFromFTP As System.Windows.Forms.RadioButton
    Friend WithEvents pOpenFromFTP As System.Windows.Forms.Panel
    Friend WithEvents tbPort As System.Windows.Forms.TextBox
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents tbHost As System.Windows.Forms.TextBox
    Friend WithEvents lblHost As System.Windows.Forms.Label
    Friend WithEvents tbPath As System.Windows.Forms.TextBox
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents tbLogin As System.Windows.Forms.TextBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents rbOpenFromClipboard As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
