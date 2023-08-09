Option Strict On
Option Explicit On

Imports System.IO
Imports GdPicture14

Public Class frmOpen

    Private ReadOnly m_owner As GdViewer

    Public Sub New(ByVal owner As GdViewer)
        InitializeComponent()
        m_owner = owner
    End Sub

    Private Sub UpdateUi()
        If rbOpenFromFile.Checked Then
            pOpenFromFile.Enabled = True
            pOpenFromHTTP.Enabled = False
            pOpenFromFTP.Enabled = False
        ElseIf rbOpenFromHTTP.Checked Then
            pOpenFromFile.Enabled = False
            pOpenFromHTTP.Enabled = True
            pOpenFromFTP.Enabled = False
        ElseIf rbOpenFromFTP.Checked Then
            pOpenFromFile.Enabled = False
            pOpenFromHTTP.Enabled = False
            pOpenFromFTP.Enabled = True
        ElseIf rbOpenFromClipboard.Checked Then
            pOpenFromFile.Enabled = False
            pOpenFromHTTP.Enabled = False
            pOpenFromFTP.Enabled = False
        End If
    End Sub

    Private Sub frmOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Clipboard.ContainsImage() Then
            rbOpenFromClipboard.Checked = True
        Else
            rbOpenFromFile.Checked = True
        End If
    End Sub

    Private Sub rbOpenFromFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOpenFromFile.CheckedChanged
        If rbOpenFromFile.Checked Then
            updateUI()
        End If
    End Sub

    Private Sub rbOpenFromFTP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOpenFromFTP.CheckedChanged
        If rbOpenFromFTP.Checked Then
            updateUI()
        End If
    End Sub

    Private Sub rbOpenFromHTTP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOpenFromHTTP.CheckedChanged
        If rbOpenFromHTTP.Checked Then
            updateUI()
        End If
    End Sub

    Private Sub rbOpenFromClipboard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOpenFromClipboard.CheckedChanged
        If rbOpenFromClipboard.Checked Then
            updateUI()
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim ok As Boolean = False
        If rbOpenFromFile.Checked Then
            If Not String.IsNullOrWhiteSpace(tbFile.Text) And File.Exists(tbFile.Text) Then
                Dim status As GdPictureStatus = m_owner.DisplayFromFile(tbFile.Text)
                If status = GdPictureStatus.OK Then
                    ok = True
                Else
                    MessageBox.Show("Error during file loading: " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("You must select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        ElseIf rbOpenFromFTP.Checked Then
            Dim port As Integer
            If Not String.IsNullOrWhiteSpace(tbHost.Text) And Not String.IsNullOrWhiteSpace(tbPort.Text) _
                And Integer.TryParse(tbPort.Text, port) And Not String.IsNullOrWhiteSpace(tbPath.Text) Then
                Dim status As GdPictureStatus = m_owner.DisplayFromFTP(tbHost.Text, tbPath.Text, tbLogin.Text, tbPassword.Text, port)
                If status = GdPictureStatus.OK Then
                    ok = True
                Else
                    MessageBox.Show("FTP Error: " + m_owner.GetLastTransferError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("You must enter all data for FTP connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf rbOpenFromHTTP.Checked Then
            Dim uri As Uri = Nothing
            If Not String.IsNullOrWhiteSpace(tbOpenFromHTTP.Text) And System.Uri.TryCreate(tbOpenFromHTTP.Text, UriKind.Absolute, uri) Then
                Dim status As GdPictureStatus = m_owner.DisplayFromHTTP(uri.ToString(), "", "")
                If status = GdPictureStatus.OK Then
                    ok = True
                Else
                    MessageBox.Show("HTTP Error: " + m_owner.GetLastTransferError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("You must specify an URI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf rbOpenFromClipboard.Checked Then
            If Clipboard.ContainsImage() Then
                Dim status As GdPictureStatus = m_owner.DisplayFromClipboard()
                If status = GdPictureStatus.OK Then
                    ok = True
                Else
                    MessageBox.Show("Error: " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("There is no image in clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If ok Then
            Me.Close()
        End If
    End Sub

    Private Sub btOpenFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpenFromFile.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If (result = DialogResult.OK) Then
            tbFile.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class