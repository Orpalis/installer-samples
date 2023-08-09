Option Strict On
Option Explicit On

Imports GdPicture14

Public Class Form1
    Private m_oGdPicturePDF As GdPicturePDF
    Private m_PageContent As String


    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
    End Sub


    Private Sub HScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll1.Scroll
        If eventArgs.NewValue <> eventArgs.OldValue Then
            If m_oGdPicturePDF IsNot Nothing Then
                Dim rotation As Single = eventArgs.NewValue
                If rotation <> 0 Then
                    m_oGdPicturePDF.SetPageContent(m_PageContent) 'restoring initial page content

                    If rotation > 0 Then 'Note: function takes anti clockwise rotation in the range [0 - 360]
                        m_oGdPicturePDF.RotatePageEx(360 - rotation)
                    Else
                        m_oGdPicturePDF.RotatePageEx(-rotation)
                    End If

                    GdViewer1.Redraw()
                End If
            End If
        End If
    End Sub


    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Call CloseDocument()

        Using ofd As New OpenFileDialog
            ofd.Filter = "PDF Files (*.pdf)|*.pdf"
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                m_oGdPicturePDF = New GdPicturePDF()
                If m_oGdPicturePDF.LoadFromFile(ofd.FileName, False) = GdPictureStatus.OK Then
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
                    GdViewer1.DisplayFromGdPicturePDF(m_oGdPicturePDF)
                Else
                    CloseDocument()
                End If
            End If
        End Using
    End Sub


    Private Sub CloseDocument()
        If m_oGdPicturePDF IsNot Nothing Then
            m_oGdPicturePDF.Dispose()
            GdViewer1.CloseDocument()
            m_oGdPicturePDF = Nothing
            m_PageContent = ""
        End If
    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        CloseDocument()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        CloseDocument()
        Me.Close()
    End Sub


    Private Sub GdViewer1_PageChanged() Handles GdViewer1.PageChanged
        If GdViewer1.CurrentPage <> 0 Then
            m_PageContent = m_oGdPicturePDF.GetPageContent()
            HScroll1.Value = 0
        End If
    End Sub


    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If m_oGdPicturePDF IsNot Nothing Then
            Using ofs As New SaveFileDialog
                ofs.Filter = "PDF Files (*.pdf)|*.pdf"
                If ofs.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    m_oGdPicturePDF.SaveToFile(ofs.FileName)
                End If

            End Using
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GdViewer1.DisplayFirstPage()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GdViewer1.DisplayNextPage()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GdViewer1.DisplayLastPage()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GdViewer1.DisplayPreviousPage()
    End Sub
End Class