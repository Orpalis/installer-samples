Option Strict On
Option Explicit On

Imports GdPicture14


Public Class Form1

    Private m_ImageID As Integer
    Private m_GdPictureImaging As New GdPictureImaging



    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
    End Sub



    Private Sub releasegdpictureimage()
        If m_ImageID <> 0 Then
            m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID)
            m_ImageID = 0
        End If
        GdViewer1.CloseDocument()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        releasegdpictureimage()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        releasegdpictureimage()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GdViewer1.ZoomIN()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GdViewer1.ZoomOUT()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        releasegdpictureimage()
        m_ImageID = m_GdPictureImaging.CreateGdPictureImageFromFile("")
        If m_ImageID <> 0 Then
            GdViewer1.DisplayFromGdPictureImage(m_ImageID)
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection
        End If
    End Sub

    Private Sub GdViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GdViewer1.Load

    End Sub

    Private Sub GdViewer1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseUp
        If GdViewer1.IsRect Then
            Dim Left, Top, Width, Height As Integer
            GdViewer1.GetRectCoordinatesOnDocument(Left, Top, Width, height)
            Dim Rects(1) As Rectangle
            Dim Result() As Integer

            Rects(0).X = Left
            Rects(0).Y = Top
            Rects(0).Width = Width
            Rects(0).Height = Height
            If DefaultToolStripMenuItem.Checked Then
                Result = m_GdPictureImaging.OMRDetectMarks(m_ImageID, Rects, 1)
            Else
                Result = m_GdPictureImaging.OMRDetectOvalMarks(m_ImageID, Rects, 1)
            End If

            MsgBox("Value: " & Str(Result(0)))
        End If
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultToolStripMenuItem.Click
        DefaultToolStripMenuItem.Checked = Not DefaultToolStripMenuItem.Checked
        OvalToolStripMenuItem.Checked = Not DefaultToolStripMenuItem.Checked
    End Sub

    Private Sub OvalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalToolStripMenuItem.Click
        OvalToolStripMenuItem.Checked = Not OvalToolStripMenuItem.Checked
        DefaultToolStripMenuItem.Checked = Not OvalToolStripMenuItem.Checked
    End Sub
End Class