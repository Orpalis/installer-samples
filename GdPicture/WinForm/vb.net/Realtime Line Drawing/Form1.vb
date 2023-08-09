Option Strict On
Option Explicit On

Imports GdPicture14

Public Class Form1

    Dim m_NativeImage As Integer
    Dim m_TmpImage As Integer
    Dim m_StartX As Integer
    Dim m_StartY As Integer
    Dim oGdPictureImaging As New GdPictureImaging




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
        m_NativeImage = oGdPictureImaging.CreateNewGdPictureImage(600, 600, 32, Color.White)
        GdViewer1.DisplayFromGdPictureImage(m_NativeImage)
    End Sub




    Private Sub Command2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command2.Click
        GdViewer1.ZoomOUT()
    End Sub


    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        GdViewer1.ZoomIN()
    End Sub


    Private Sub Command3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command3.Click
        Call oGdPictureImaging.ClearImage(m_NativeImage, Color.White)
        GdViewer1.Redraw()
    End Sub


    Private Sub GdViewer1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseDown
        m_StartX = GdViewer1.GetMouseLeftInDocument
        m_StartY = GdViewer1.GetMouseTopInDocument
    End Sub


    Private Sub GdViewer1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If m_TmpImage <> 0 Then oGdPictureImaging.ReleaseGdPictureImage(m_TmpImage)
            m_TmpImage = oGdPictureImaging.CreateClonedGdPictureImage(m_NativeImage)
            Call oGdPictureImaging.DrawLine(m_TmpImage, m_StartX, m_StartY, GdViewer1.GetMouseLeftInDocument, GdViewer1.GetMouseTopInDocument, CInt(Val(Me.txtPenSize.Text)), oGdPictureImaging.ARGB(CByte(Val(Me.txtAlpha.Text)), CByte(Val(Me.txtRed.Text)), CByte(Val(Me.txtGreen.Text)), CByte(Val(Me.txtBlue.Text))), True)
            GdViewer1.DisplayFromGdPictureImage(m_TmpImage)
        End If
    End Sub


    Private Sub GdViewer1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseUp
        If m_TmpImage <> 0 Then
            oGdPictureImaging.ReleaseGdPictureImage(m_NativeImage)
            m_NativeImage = m_TmpImage
            m_TmpImage = 0
        End If
    End Sub
End Class