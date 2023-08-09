<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSourceFolder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDestFolder = New System.Windows.Forms.TextBox()
        Me.cmdBrowseSource = New System.Windows.Forms.Button()
        Me.cmdBrowseDest = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMaxProcesses = New System.Windows.Forms.ComboBox()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.lstThreads = New System.Windows.Forms.ListBox()
        Me.prgProgress = New System.Windows.Forms.ProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabStatus = New System.Windows.Forms.TabPage()
        Me.TabErrors = New System.Windows.Forms.TabPage()
        Me.lstErrLog = New System.Windows.Forms.ListBox()
        Me.TabProcessLogs = New System.Windows.Forms.TabPage()
        Me.lstProcessLog = New System.Windows.Forms.ListBox()
        Me.FldBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.chkRecursive = New System.Windows.Forms.CheckBox()
        Me.tmrCloseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabStatus.SuspendLayout()
        Me.TabErrors.SuspendLayout()
        Me.TabProcessLogs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source Folder:"
        '
        'txtSourceFolder
        '
        Me.txtSourceFolder.Location = New System.Drawing.Point(113, 2)
        Me.txtSourceFolder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSourceFolder.Name = "txtSourceFolder"
        Me.txtSourceFolder.Size = New System.Drawing.Size(635, 22)
        Me.txtSourceFolder.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dest Folder:"
        '
        'txtDestFolder
        '
        Me.txtDestFolder.Location = New System.Drawing.Point(113, 31)
        Me.txtDestFolder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDestFolder.Name = "txtDestFolder"
        Me.txtDestFolder.Size = New System.Drawing.Size(635, 22)
        Me.txtDestFolder.TabIndex = 3
        '
        'cmdBrowseSource
        '
        Me.cmdBrowseSource.Location = New System.Drawing.Point(757, 6)
        Me.cmdBrowseSource.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBrowseSource.Name = "cmdBrowseSource"
        Me.cmdBrowseSource.Size = New System.Drawing.Size(79, 23)
        Me.cmdBrowseSource.TabIndex = 4
        Me.cmdBrowseSource.Text = "Browse"
        Me.cmdBrowseSource.UseVisualStyleBackColor = True
        '
        'cmdBrowseDest
        '
        Me.cmdBrowseDest.Location = New System.Drawing.Point(759, 34)
        Me.cmdBrowseDest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBrowseDest.Name = "cmdBrowseDest"
        Me.cmdBrowseDest.Size = New System.Drawing.Size(77, 23)
        Me.cmdBrowseDest.TabIndex = 5
        Me.cmdBrowseDest.Text = "Browse"
        Me.cmdBrowseDest.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Threads:"
        '
        'cboMaxProcesses
        '
        Me.cboMaxProcesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaxProcesses.FormattingEnabled = True
        Me.cboMaxProcesses.Location = New System.Drawing.Point(113, 59)
        Me.cboMaxProcesses.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMaxProcesses.Name = "cboMaxProcesses"
        Me.cboMaxProcesses.Size = New System.Drawing.Size(189, 24)
        Me.cboMaxProcesses.TabIndex = 8
        '
        'cmdRun
        '
        Me.cmdRun.Location = New System.Drawing.Point(312, 59)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(109, 26)
        Me.cmdRun.TabIndex = 9
        Me.cmdRun.Text = "Start Batch"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'lstThreads
        '
        Me.lstThreads.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstThreads.FormattingEnabled = True
        Me.lstThreads.ItemHeight = 16
        Me.lstThreads.Location = New System.Drawing.Point(9, 7)
        Me.lstThreads.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstThreads.Name = "lstThreads"
        Me.lstThreads.Size = New System.Drawing.Size(991, 260)
        Me.lstThreads.TabIndex = 11
        '
        'prgProgress
        '
        Me.prgProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prgProgress.Location = New System.Drawing.Point(1, 416)
        Me.prgProgress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.prgProgress.Name = "prgProgress"
        Me.prgProgress.Size = New System.Drawing.Size(1020, 18)
        Me.prgProgress.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabStatus)
        Me.TabControl1.Controls.Add(Me.TabErrors)
        Me.TabControl1.Controls.Add(Me.TabProcessLogs)
        Me.TabControl1.Location = New System.Drawing.Point(1, 100)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1020, 309)
        Me.TabControl1.TabIndex = 13
        '
        'TabStatus
        '
        Me.TabStatus.Controls.Add(Me.lstThreads)
        Me.TabStatus.Location = New System.Drawing.Point(4, 25)
        Me.TabStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabStatus.Name = "TabStatus"
        Me.TabStatus.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabStatus.Size = New System.Drawing.Size(1012, 280)
        Me.TabStatus.TabIndex = 0
        Me.TabStatus.Text = "Status"
        Me.TabStatus.UseVisualStyleBackColor = True
        '
        'TabErrors
        '
        Me.TabErrors.Controls.Add(Me.lstErrLog)
        Me.TabErrors.Location = New System.Drawing.Point(4, 25)
        Me.TabErrors.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabErrors.Name = "TabErrors"
        Me.TabErrors.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabErrors.Size = New System.Drawing.Size(1012, 280)
        Me.TabErrors.TabIndex = 1
        Me.TabErrors.Text = "Errors"
        Me.TabErrors.UseVisualStyleBackColor = True
        '
        'lstErrLog
        '
        Me.lstErrLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstErrLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstErrLog.FormattingEnabled = True
        Me.lstErrLog.ItemHeight = 17
        Me.lstErrLog.Location = New System.Drawing.Point(9, 7)
        Me.lstErrLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstErrLog.Name = "lstErrLog"
        Me.lstErrLog.Size = New System.Drawing.Size(991, 242)
        Me.lstErrLog.TabIndex = 0
        '
        'TabProcessLogs
        '
        Me.TabProcessLogs.Controls.Add(Me.lstProcessLog)
        Me.TabProcessLogs.Location = New System.Drawing.Point(4, 25)
        Me.TabProcessLogs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabProcessLogs.Name = "TabProcessLogs"
        Me.TabProcessLogs.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabProcessLogs.Size = New System.Drawing.Size(1012, 280)
        Me.TabProcessLogs.TabIndex = 2
        Me.TabProcessLogs.Text = "Logs"
        Me.TabProcessLogs.UseVisualStyleBackColor = True
        '
        'lstProcessLog
        '
        Me.lstProcessLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstProcessLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProcessLog.FormattingEnabled = True
        Me.lstProcessLog.ItemHeight = 17
        Me.lstProcessLog.Location = New System.Drawing.Point(8, 7)
        Me.lstProcessLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstProcessLog.Name = "lstProcessLog"
        Me.lstProcessLog.Size = New System.Drawing.Size(992, 242)
        Me.lstProcessLog.TabIndex = 1
        '
        'FldBrowse
        '
        Me.FldBrowse.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'chkRecursive
        '
        Me.chkRecursive.AutoSize = True
        Me.chkRecursive.Checked = True
        Me.chkRecursive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecursive.Location = New System.Drawing.Point(844, 6)
        Me.chkRecursive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRecursive.Name = "chkRecursive"
        Me.chkRecursive.Size = New System.Drawing.Size(161, 21)
        Me.chkRecursive.TabIndex = 14
        Me.chkRecursive.Text = "Process Sub Folders"
        Me.chkRecursive.UseVisualStyleBackColor = True
        '
        'tmrCloseTimer
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 438)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.prgProgress)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.cboMaxProcesses)
        Me.Controls.Add(Me.cmdBrowseDest)
        Me.Controls.Add(Me.cmdBrowseSource)
        Me.Controls.Add(Me.txtDestFolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSourceFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRecursive)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "GdPicture.NET - Multi-thread Thumbnail Generator Demo  -  http://www.gdpicture.co" &
    "m"
        Me.TabControl1.ResumeLayout(False)
        Me.TabStatus.ResumeLayout(False)
        Me.TabErrors.ResumeLayout(False)
        Me.TabProcessLogs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSourceFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDestFolder As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowseSource As System.Windows.Forms.Button
    Friend WithEvents cmdBrowseDest As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboMaxProcesses As System.Windows.Forms.ComboBox
    Friend WithEvents cmdRun As System.Windows.Forms.Button
    Friend WithEvents lstThreads As System.Windows.Forms.ListBox
    Friend WithEvents prgProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabStatus As System.Windows.Forms.TabPage
    Friend WithEvents TabErrors As System.Windows.Forms.TabPage
    Friend WithEvents lstErrLog As System.Windows.Forms.ListBox
    Friend WithEvents FldBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkRecursive As System.Windows.Forms.CheckBox
    Friend WithEvents tmrCloseTimer As System.Windows.Forms.Timer
    Friend WithEvents TabProcessLogs As System.Windows.Forms.TabPage
    Friend WithEvents lstProcessLog As System.Windows.Forms.ListBox

End Class
