Option Strict On
Option Explicit On

Imports GdPicture14

Public Class Form1
    Private ImageSrc As Integer
    Private ClonedImage As Integer
    Private Stat As Integer
    Private oGdPictureImaging As New GdPictureImaging



    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New  GdPicture14.LicenseManager 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
    End Sub



    Private Sub HScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll1.Scroll
        If eventArgs.NewValue <> eventArgs.OldValue Then
            HScroll2.Value = 0
            HScroll3.Value = 0
            HScroll4.Value = 0

            If ImageSrc <> 0 Then
                System.Windows.Forms.Application.DoEvents()
                If ClonedImage <> 0 Then
                    oGdPictureImaging.ReleaseGdPictureImage(ClonedImage)
                    ClonedImage = 0
                End If
                ClonedImage = oGdPictureImaging.CreateClonedGdPictureImage(ImageSrc)
                Stat = oGdPictureImaging.RotateAngle(ClonedImage, HScroll1.Value)
                If Stat = 0 Then
                    GdViewer1.DisplayFromGdPictureImage(ClonedImage)
                Else
                    MsgBox("Error No: " & Str(Stat))
                End If
            End If
        End If
    End Sub


    Private Sub HScroll2_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll2.Scroll
        If eventArgs.NewValue <> eventArgs.OldValue Then
            HScroll1.Value = 0
            HScroll3.Value = 0
            HScroll4.Value = 0
            If ImageSrc <> 0 Then
                System.Windows.Forms.Application.DoEvents()
                If ClonedImage <> 0 Then
                    oGdPictureImaging.ReleaseGdPictureImage(ClonedImage)
                    ClonedImage = 0
                End If
                ClonedImage = oGdPictureImaging.CreateClonedGdPictureImage(ImageSrc)
                Stat = oGdPictureImaging.RotateAnglePreserveDimensionsCenter(ClonedImage, HScroll2.Value)
                If Stat = 0 Then
                    GdViewer1.DisplayFromGdPictureImage(ClonedImage)
                Else
                    MsgBox("Error No: " & Str(Stat))
                End If
            End If
        End If
    End Sub


    Private Sub HScroll3_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll3.Scroll
        If eventArgs.NewValue <> eventArgs.OldValue Then
            HScroll1.Value = 0
            HScroll2.Value = 0
            HScroll4.Value = 0
            If ImageSrc <> 0 Then
                System.Windows.Forms.Application.DoEvents()
                If ClonedImage <> 0 Then
                    oGdPictureImaging.ReleaseGdPictureImage(ClonedImage)
                    ClonedImage = 0
                End If
                ClonedImage = oGdPictureImaging.CreateClonedGdPictureImage(ImageSrc)
                Stat = oGdPictureImaging.RotateAnglePreserveDimensions(ClonedImage, HScroll3.Value)
                If Stat = 0 Then
                    GdViewer1.DisplayFromGdPictureImage(ClonedImage)
                Else
                    MsgBox("Error No: " & Str(Stat))
                End If
            End If
        End If
    End Sub


    Private Sub HScroll4_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll4.Scroll
        If eventArgs.NewValue <> eventArgs.OldValue Then
            HScroll1.Value = 0
            HScroll2.Value = 0
            HScroll3.Value = 0
            If ImageSrc <> 0 Then
                System.Windows.Forms.Application.DoEvents()
                If ClonedImage <> 0 Then
                    oGdPictureImaging.ReleaseGdPictureImage(ClonedImage)
                    ClonedImage = 0
                End If
                ClonedImage = oGdPictureImaging.CreateClonedGdPictureImage(ImageSrc)
                Stat = oGdPictureImaging.RotateAngleBackColor(ClonedImage, HScroll4.Value, Color.White)
                If Stat = 0 Then
                    GdViewer1.DisplayFromGdPictureImage(ClonedImage)
                Else
                    MsgBox("Error No: " & Str(Stat))
                End If
            End If
        End If
    End Sub


    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Call CloseImage()

        ImageSrc = oGdPictureImaging.CreateGdPictureImageFromFile("")
        If oGdPictureImaging.GetStat = 0 Then
            GdViewer1.DisplayFromGdPictureImage(ImageSrc)
        End If
    End Sub


    Private Sub CloseImage()
        If ImageSrc <> 0 Then
            oGdPictureImaging.ReleaseGdPictureImage(ImageSrc)
            ImageSrc = 0
        End If
        If ClonedImage <> 0 Then
            oGdPictureImaging.ReleaseGdPictureImage(ClonedImage)
            ClonedImage = 0
        End If
        GdViewer1.CloseDocument()
    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        CloseImage()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        CloseImage()
        Me.Close()
    End Sub
End Class