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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkUseFeeder = New System.Windows.Forms.CheckBox()
        Me.chkGenLog = New System.Windows.Forms.CheckBox()
        Me.chkEnableIndicator = New System.Windows.Forms.CheckBox()
        Me.chkHideGUI = New System.Windows.Forms.CheckBox()
        Me.chkDuplex = New System.Windows.Forms.CheckBox()
        Me.chkTwain19 = New System.Windows.Forms.CheckBox()
        Me.chkModalUI = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 43)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(537, 137)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Asynchronous acquisition"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkUseFeeder
        '
        Me.chkUseFeeder.AutoSize = True
        Me.chkUseFeeder.Location = New System.Drawing.Point(241, 187)
        Me.chkUseFeeder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkUseFeeder.Name = "chkUseFeeder"
        Me.chkUseFeeder.Size = New System.Drawing.Size(139, 21)
        Me.chkUseFeeder.TabIndex = 1
        Me.chkUseFeeder.Text = "Scan from feeder"
        Me.chkUseFeeder.UseVisualStyleBackColor = True
        '
        'chkGenLog
        '
        Me.chkGenLog.AutoSize = True
        Me.chkGenLog.Location = New System.Drawing.Point(16, 15)
        Me.chkGenLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkGenLog.Name = "chkGenLog"
        Me.chkGenLog.Size = New System.Drawing.Size(124, 21)
        Me.chkGenLog.TabIndex = 2
        Me.chkGenLog.Text = "Generate LOG"
        Me.chkGenLog.UseVisualStyleBackColor = True
        '
        'chkEnableIndicator
        '
        Me.chkEnableIndicator.AutoSize = True
        Me.chkEnableIndicator.Location = New System.Drawing.Point(16, 244)
        Me.chkEnableIndicator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkEnableIndicator.Name = "chkEnableIndicator"
        Me.chkEnableIndicator.Size = New System.Drawing.Size(132, 21)
        Me.chkEnableIndicator.TabIndex = 3
        Me.chkEnableIndicator.Text = "Enable Indicator"
        Me.chkEnableIndicator.UseVisualStyleBackColor = True
        '
        'chkHideGUI
        '
        Me.chkHideGUI.AutoSize = True
        Me.chkHideGUI.Location = New System.Drawing.Point(16, 215)
        Me.chkHideGUI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkHideGUI.Name = "chkHideGUI"
        Me.chkHideGUI.Size = New System.Drawing.Size(134, 21)
        Me.chkHideGUI.TabIndex = 4
        Me.chkHideGUI.Text = "Hide Device GUI"
        Me.chkHideGUI.UseVisualStyleBackColor = True
        '
        'chkDuplex
        '
        Me.chkDuplex.AutoSize = True
        Me.chkDuplex.Location = New System.Drawing.Point(241, 215)
        Me.chkDuplex.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkDuplex.Name = "chkDuplex"
        Me.chkDuplex.Size = New System.Drawing.Size(73, 21)
        Me.chkDuplex.TabIndex = 5
        Me.chkDuplex.Text = "Duplex"
        Me.chkDuplex.UseVisualStyleBackColor = True
        '
        'chkTwain19
        '
        Me.chkTwain19.AutoSize = True
        Me.chkTwain19.Location = New System.Drawing.Point(151, 15)
        Me.chkTwain19.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkTwain19.Name = "chkTwain19"
        Me.chkTwain19.Size = New System.Drawing.Size(138, 21)
        Me.chkTwain19.TabIndex = 7
        Me.chkTwain19.Text = "Force TWAIN 1.9"
        Me.chkTwain19.UseVisualStyleBackColor = True
        '
        'chkModalUI
        '
        Me.chkModalUI.AutoSize = True
        Me.chkModalUI.Checked = True
        Me.chkModalUI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkModalUI.Location = New System.Drawing.Point(16, 187)
        Me.chkModalUI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkModalUI.Name = "chkModalUI"
        Me.chkModalUI.Size = New System.Drawing.Size(85, 21)
        Me.chkModalUI.TabIndex = 8
        Me.chkModalUI.Text = "Modal UI"
        Me.chkModalUI.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 279)
        Me.Controls.Add(Me.chkModalUI)
        Me.Controls.Add(Me.chkTwain19)
        Me.Controls.Add(Me.chkDuplex)
        Me.Controls.Add(Me.chkHideGUI)
        Me.Controls.Add(Me.chkEnableIndicator)
        Me.Controls.Add(Me.chkGenLog)
        Me.Controls.Add(Me.chkUseFeeder)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Asynchronous TWAIN scanning Demo  -  http://www.gdpicture.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkUseFeeder As System.Windows.Forms.CheckBox
    Friend WithEvents chkGenLog As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnableIndicator As System.Windows.Forms.CheckBox
    Friend WithEvents chkHideGUI As System.Windows.Forms.CheckBox
    Friend WithEvents chkDuplex As System.Windows.Forms.CheckBox
    Friend WithEvents chkTwain19 As System.Windows.Forms.CheckBox
    Friend WithEvents chkModalUI As System.Windows.Forms.CheckBox

End Class
