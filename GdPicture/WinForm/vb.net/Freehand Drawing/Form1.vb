Option Strict On
Option Explicit On

Imports GdPicture14

Public Class Form1
    Const UNDO_LEVEL As Integer = 10
    Private arImagesUndo(0 To UNDO_LEVEL - 1) As Integer
    Private nUndoIDX As Integer = -1
    Private oGdPictureImaging As New GdPictureImaging
    Private m_NativeImage As Integer
    Private arPoints(2, 2) As Integer
    Private nHits As Integer


    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
         Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.

        m_NativeImage = Me.oGdPictureImaging.CreateNewGdPictureImage(600, 600, 32, Color.White)
        Me.GdViewer1.DisplayFromGdPictureImage(m_NativeImage)
    End Sub


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        GdViewer1.ZoomIN()
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        GdViewer1.ZoomOUT()
    End Sub


    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        Call oGdPictureImaging.ClearImage(m_NativeImage, Color.White)
        GdViewer1.Redraw()
    End Sub


    Private Sub btUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUndo.Click
        nUndoIDX = nUndoIDX - 1
        oGdPictureImaging.ClearImage(m_NativeImage, Color.White)
        Call oGdPictureImaging.DrawGdPictureImage(arImagesUndo(nUndoIDX), m_NativeImage, 0, 0, oGdPictureImaging.GetWidth(m_NativeImage), oGdPictureImaging.GetHeight(m_NativeImage), Drawing2D.InterpolationMode.NearestNeighbor)
        If nUndoIDX = 0 Then Me.btUndo.Enabled = False
        GdViewer1.Redraw()

        Me.btRedo.Enabled = True
    End Sub


    Private Sub btRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRedo.Click
        nUndoIDX = nUndoIDX + 1
        oGdPictureImaging.ClearImage(m_NativeImage, Color.White)
        Call oGdPictureImaging.DrawGdPictureImage(arImagesUndo(nUndoIDX), m_NativeImage, 0, 0, oGdPictureImaging.GetWidth(m_NativeImage), oGdPictureImaging.GetHeight(m_NativeImage), Drawing2D.InterpolationMode.NearestNeighbor)
        If nUndoIDX = UNDO_LEVEL - 1 Then
            Me.btRedo.Enabled = False
        Else
            If arImagesUndo(nUndoIDX + 1) = 0 Then Me.btRedo.Enabled = False
        End If
        GdViewer1.Redraw()

        Me.btUndo.Enabled = True
    End Sub


    Private Sub SaveGraphicState()
        Dim i As Integer

        nUndoIDX = nUndoIDX + 1
        If nUndoIDX > UNDO_LEVEL - 1 Then
            oGdPictureImaging.ReleaseGdPictureImage(arImagesUndo(0))
            For i = 0 To UNDO_LEVEL - 2
                arImagesUndo(i) = arImagesUndo(i + 1)
                nUndoIDX = UNDO_LEVEL - 1
            Next i
        Else
            For i = nUndoIDX + 1 To UNDO_LEVEL - 1
                If arImagesUndo(i) <> 0 Then
                    oGdPictureImaging.ReleaseGdPictureImage(arImagesUndo(i))
                    arImagesUndo(i) = 0
                End If
            Next i
        End If
        arImagesUndo(nUndoIDX) = oGdPictureImaging.CreateClonedGdPictureImage(m_NativeImage)
        If nUndoIDX > 0 Then Me.btUndo.Enabled = True
        Me.btRedo.Enabled = False
    End Sub


    Private Sub GdViewer1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseDown
        arPoints(1, 1) = GdViewer1.GetMouseLeftInDocument
        arPoints(1, 2) = GdViewer1.GetMouseTopInDocument
        Call oGdPictureImaging.DrawFilledCircle(m_NativeImage, arPoints(1, 1), arPoints(1, 2), CInt(Val(txtPenSize.Text)), oGdPictureImaging.ARGB(CByte(Val(txtAlpha.Text)), CByte(Val(txtRed.Text)), CByte(Val(txtGreen.Text)), CByte(Val(txtBlue.Text))), True)
        GdViewer1.Redraw()
    End Sub


    Private Sub GdViewer1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nHits = nHits + 1
            arPoints(2, 1) = GdViewer1.GetMouseLeftInDocument
            arPoints(2, 2) = GdViewer1.GetMouseTopInDocument

            Call oGdPictureImaging.DrawLine(m_NativeImage, arPoints(1, 1), arPoints(1, 2), arPoints(2, 1), arPoints(2, 2), CByte(Val(txtPenSize.Text)), oGdPictureImaging.ARGB(CByte(Val(txtAlpha.Text)), CByte(Val(txtRed.Text)), CByte(Val(txtGreen.Text)), CByte(Val(txtBlue.Text))), True)
            Call oGdPictureImaging.DrawFilledCircle(m_NativeImage, arPoints(2, 1), arPoints(2, 2), CInt(Val(txtPenSize.Text)), oGdPictureImaging.ARGB(CByte(Val(txtAlpha.Text)), CByte(Val(txtRed.Text)), CByte(Val(txtGreen.Text)), CByte(Val(txtBlue.Text))), True)
            If nHits Mod 2 = 0 Then GdViewer1.Redraw()

            arPoints(1, 1) = arPoints(2, 1)
            arPoints(1, 2) = arPoints(2, 2)
        End If
    End Sub


    Private Sub GdViewer1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseUp
        SaveGraphicState()
    End Sub
End Class