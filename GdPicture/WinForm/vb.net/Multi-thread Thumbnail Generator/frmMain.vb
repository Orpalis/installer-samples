Imports System.IO

Public Class frmMain
    Private Class ThreadItem
        Private _Caption As String
        Private _Worker As clsWorkerThread


        Public Sub New(ByVal Caption As String, ByVal Worker As clsWorkerThread)
            Me.Caption = Caption
            Me.Worker = Worker
        End Sub


        Public Overrides Function ToString() As String
            Return _Caption
        End Function


        Public Property Caption() As String
            Get
                Return _Caption
            End Get
            Set(ByVal value As String)
                If String.IsNullOrEmpty(value) Then
                    Throw New ArgumentNullException("Caption")
                End If
                _Caption = value
            End Set
        End Property


        Public Property Worker() As clsWorkerThread
            Get
                Return _Worker
            End Get
            Set(ByVal value As clsWorkerThread)
                If value Is Nothing Then
                    Throw New ArgumentNullException("Worker")
                End If
                _Worker = value
            End Set
        End Property
    End Class



    Dim FileCount As Integer


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BuildMutliProcessList()

        Dim path As String
        txtSourceFolder.Text = ""
        txtDestFolder.Text = ""

        path = My.Settings.LastInPath
        If Not String.IsNullOrEmpty(path) Then txtSourceFolder.Text = path

        path = My.Settings.LastOutPath
        If Not String.IsNullOrEmpty(path) Then txtDestFolder.Text = path
    End Sub


    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cmdRun.Text <> "Start Batch" Then
            e.Cancel = True
        End If

        If cmdRun.Text = "Stop" Then
            cmdRun.Text = "Please Wait"
            cmdRun.Enabled = False
            clsWorkerThread.files.Clear()
            tmrCloseTimer.Enabled = True
        End If
    End Sub


    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.LastInPath = txtSourceFolder.Text
        My.Settings.LastOutPath = txtDestFolder.Text
        My.Settings.Save()
    End Sub


    Private Sub BuildMutliProcessList()
        Dim MaxProcesses As Integer = 4 'Max number of simutaneous Processes
        Dim Counter As Integer = 1
        Dim cboText As String = ""
        While Counter <= MaxProcesses
            If Counter = 1 Then
                cboText = "Single Process"
            Else
                cboText = "Multi Process"
            End If
            cboMaxProcesses.Items.Add(Counter & " - " & cboText)

            Counter = Counter * 2
        End While
    End Sub


    Public Sub UIUpdateThreads(ByVal ThreadID As Integer, ByVal strText As String)
        SyncLock clsWorkerThread.SyncLockObj
            For i As Integer = 0 To lstThreads.Items.Count - 1
                Dim item As ThreadItem = CType(lstThreads.Items(i), ThreadItem)
                If item.Worker.ThreadId = ThreadID Then
                    item.Caption = "Thread " & ThreadID & ": " & strText
                    lstThreads.Items(i) = item
                    Exit For
                End If
            Next
            prgProgress.Value = clsWorkerThread.ProcessedCount
        End SyncLock
    End Sub


    Public Sub UIUpdateErrLog(ByVal ThreadID As Integer, ByVal strText As String)
        SyncLock clsWorkerThread.SyncLockObj
            lstErrLog.Items.Add("Thread " & ThreadID & ": " & strText)
            TabErrors.Text = "Errors (" & lstErrLog.Items.Count & ")"
        End SyncLock
    End Sub


    Public Sub UIUpdateProcessLog(ByVal ThreadID As Integer, ByVal strText As String)
        SyncLock clsWorkerThread.SyncLockObj
            lstProcessLog.Items.Add("Thread " & ThreadID & ": " & strText)
            TabProcessLogs.Text = "Logs (" & lstProcessLog.Items.Count & ")"
        End SyncLock
    End Sub


    Public Sub CleanUpThreads(ByVal ThreadNo As Integer, ByVal strText As String)
        SyncLock clsWorkerThread.SyncLockObj
            For i As Integer = lstThreads.Items.Count - 1 To 0 Step -1
                Dim item As ThreadItem = CType(lstThreads.Items(i), ThreadItem)
                If item.Worker.ThreadId = ThreadNo Then
                    lstThreads.Items.RemoveAt(i)
                    Exit For
                End If
            Next

            If lstThreads.Items.Count = 0 Then
                cmdRun.Enabled = True
                cmdRun.Text = "Start Batch"

                If clsWorkerThread.ProcessedCount = FileCount Then
                    MsgBox("Batch Complete, please check the error log for any errors", MsgBoxStyle.Information, "Batch Complete")
                End If
            End If
        End SyncLock
    End Sub


    Private Sub ResetApp()
        clsWorkerThread.ProcessedCount = 0
        lstThreads.Items.Clear()
        lstErrLog.Items.Clear()
        lstProcessLog.Items.Clear()
        TabErrors.Text = "Errors"
        TabProcessLogs.Text = "Logs"
        FileCount = 0
    End Sub


    Private Sub cmdRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRun.Click
        Dim LaunchThreadCount As Integer
        Dim tmparr() As String

        If cmdRun.Text = "Start Batch" Then
            Call ResetApp()

            If txtSourceFolder.Text = "" Then
                MsgBox("There must be a source path", MsgBoxStyle.Exclamation, "User Input")
                Exit Sub
            End If

            If Not My.Computer.FileSystem.DirectoryExists(txtSourceFolder.Text) Then
                MsgBox("Source path does not exist", MsgBoxStyle.Exclamation, "User Input")
                Exit Sub
            End If

            If Not My.Computer.FileSystem.DirectoryExists(txtDestFolder.Text) Then
                MsgBox("Destination path does not exist", MsgBoxStyle.Exclamation, "User Input")
                Exit Sub
            End If

            If cboMaxProcesses.SelectedIndex = -1 Then
                MsgBox("You must select how many threads to run", MsgBoxStyle.Exclamation, "User Input")
                Exit Sub
            End If

            My.Settings.LastInPath = txtSourceFolder.Text
            My.Settings.LastOutPath = txtDestFolder.Text
            My.Settings.Save()

            cmdRun.Text = "Stop"
            tmparr = Split(cboMaxProcesses.SelectedItem, " ")
            LaunchThreadCount = Int(tmparr(0))

            Application.DoEvents()

            Try
                clsWorkerThread.CollectFiles(txtSourceFolder.Text, txtDestFolder.Text, chkRecursive.Checked)
                FileCount = clsWorkerThread.files.Count
            Catch ex As System.Exception
                MsgBox("An exception occured while building a list to process, the error was : " & ex.Message, MsgBoxStyle.Exclamation, "Program Error")
                cmdRun.Text = "Start Batch"
                Exit Sub
            End Try

            prgProgress.Value = 0
            prgProgress.Minimum = 0
            prgProgress.Maximum = FileCount

            Application.DoEvents()

            If FileCount = 0 Then
                cmdRun.Text = "Start Batch"
                MsgBox("No files found to process", MsgBoxStyle.Information, "Batch Process")
                Exit Sub
            End If

            For i As Integer = 1 To LaunchThreadCount
                Dim item As ThreadItem = _
                    New ThreadItem("Thread " & i & ": IDLE (Waiting for work)", _
                                   New clsWorkerThread(i))
                lstThreads.Items.Add(item)
                item.Worker.StartProcessBatch()
            Next
        Else
            cmdRun.Enabled = False
            cmdRun.Text = "Please Wait"

            SyncLock clsWorkerThread.SyncLockObj
                clsWorkerThread.files.Clear()
            End SyncLock
        End If
    End Sub


    Private Sub cmdBrowseSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseSource.Click
        FldBrowse.SelectedPath = IIf(String.IsNullOrEmpty(txtSourceFolder.Text), Directory.GetCurrentDirectory(), txtSourceFolder.Text)
        If FldBrowse.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSourceFolder.Text = FldBrowse.SelectedPath
        End If
    End Sub


    Private Sub cmdBrowseDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseDest.Click
        FldBrowse.SelectedPath = IIf(String.IsNullOrEmpty(txtDestFolder.Text), Directory.GetCurrentDirectory(), txtDestFolder.Text)
        If FldBrowse.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDestFolder.Text = FldBrowse.SelectedPath
        End If
    End Sub


    Private Sub tmrCloseTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCloseTimer.Tick
        If cmdRun.Text = "Start Batch" Then
            End
        End If
    End Sub
End Class
