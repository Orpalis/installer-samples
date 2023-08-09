<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCopyrightORPALIS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDemoName = New System.Windows.Forms.Label()
        Me.lblGdPictureDemo = New System.Windows.Forms.Label()
        Me.lblGdPictureWebsite = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(664, 283)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCopyrightORPALIS
        '
        Me.lblCopyrightORPALIS.AutoSize = True
        Me.lblCopyrightORPALIS.Enabled = False
        Me.lblCopyrightORPALIS.Location = New System.Drawing.Point(11, 289)
        Me.lblCopyrightORPALIS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCopyrightORPALIS.Name = "lblCopyrightORPALIS"
        Me.lblCopyrightORPALIS.Size = New System.Drawing.Size(181, 17)
        Me.lblCopyrightORPALIS.TabIndex = 1
        Me.lblCopyrightORPALIS.Text = "Copyright © 2018 ORPALIS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(780, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 191)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.lblDemoName)
        Me.Panel2.Controls.Add(Me.lblGdPictureDemo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 191)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 80)
        Me.Panel2.TabIndex = 4
        '
        'lblDemoName
        '
        Me.lblDemoName.AutoSize = True
        Me.lblDemoName.Location = New System.Drawing.Point(27, 39)
        Me.lblDemoName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDemoName.Name = "lblDemoName"
        Me.lblDemoName.Size = New System.Drawing.Size(216, 17)
        Me.lblDemoName.TabIndex = 1
        Me.lblDemoName.Text = ".NET Winform Annotations Demo"
        '
        'lblGdPictureDemo
        '
        Me.lblGdPictureDemo.AutoSize = True
        Me.lblGdPictureDemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGdPictureDemo.Location = New System.Drawing.Point(13, 14)
        Me.lblGdPictureDemo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGdPictureDemo.Name = "lblGdPictureDemo"
        Me.lblGdPictureDemo.Size = New System.Drawing.Size(247, 17)
        Me.lblGdPictureDemo.TabIndex = 0
        Me.lblGdPictureDemo.Text = "GdPicture.NET Application Demo"
        '
        'lblGdPictureWebsite
        '
        Me.lblGdPictureWebsite.AutoSize = True
        Me.lblGdPictureWebsite.Location = New System.Drawing.Point(204, 289)
        Me.lblGdPictureWebsite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGdPictureWebsite.Name = "lblGdPictureWebsite"
        Me.lblGdPictureWebsite.Size = New System.Drawing.Size(168, 17)
        Me.lblGdPictureWebsite.TabIndex = 6
        Me.lblGdPictureWebsite.TabStop = True
        Me.lblGdPictureWebsite.Text = "http://www.gdpicture.com/"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 326)
        Me.Controls.Add(Me.lblGdPictureWebsite)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblCopyrightORPALIS)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblCopyrightORPALIS As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblDemoName As System.Windows.Forms.Label
    Friend WithEvents lblGdPictureDemo As System.Windows.Forms.Label
    Friend WithEvents lblGdPictureWebsite As System.Windows.Forms.LinkLabel
End Class
