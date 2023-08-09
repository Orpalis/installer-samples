Option Strict On
Option Explicit On

Imports GdPicture14


Public Class Form1

    Private _sourceImage As Integer
    Private _clonedImage As Integer
    Private _gdPictureStatus As GdPictureStatus
    Private ReadOnly _gdPictureImaging As New GdPictureImaging

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
    End Sub

    Private Sub HScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HSMinVal.Scroll
        ProcessFilter()
    End Sub

    Private Sub HScroll3_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HSThreshold.Scroll
        ProcessFilter()
    End Sub

    Private Sub ProcessFilter()
        If _sourceImage <> 0 Then
            If _clonedImage <> 0 Then
                _gdPictureImaging.ReleaseGdPictureImage(_clonedImage)
                _clonedImage = 0
            End If

            _clonedImage = _gdPictureImaging.CreateClonedGdPictureImage32BppPARGB(_sourceImage)
            Select Case cmbKey.Text
                Case "Blue"
                    _gdPictureStatus = _gdPictureImaging.fxRemoveBackgroundChromaKey(_clonedImage, ColorKey.ColorKeyBlue, HSThreshold.Value, HSMinVal.Value)
                Case "Green"
                    _gdPictureStatus = _gdPictureImaging.fxRemoveBackgroundChromaKey(_clonedImage, ColorKey.ColorKeyGreen, HSThreshold.Value, HSMinVal.Value)
                Case "Red"
                    _gdPictureStatus = _gdPictureImaging.fxRemoveBackgroundChromaKey(_clonedImage, ColorKey.ColorKeyRed, HSThreshold.Value, HSMinVal.Value)
            End Select

            If _gdPictureStatus = 0 Then
                GdViewer1.DisplayFromGdPictureImage(_clonedImage)
            Else
                MsgBox("Error No: " & _gdPictureStatus.ToString)
            End If
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Call releasegdpictureimage()

        _sourceImage = _gdPictureImaging.CreateGdPictureImageFromFile("")
        If _gdPictureImaging.GetStat = 0 Then

            If (_gdPictureImaging.GetWidth(_sourceImage) * _gdPictureImaging.GetHeight(_sourceImage)) > (GdViewer1.Width * GdViewer1.Height) Then
                'Resizing the image to viewer height to maximize performances
                _gdPictureImaging.ResizeWidthRatio(_sourceImage, GdViewer1.Width, Drawing2D.InterpolationMode.HighQualityBicubic)
            End If
            ProcessFilter()
        End If
    End Sub

    Private Sub ReleaseGdPictureImage()
        If _sourceImage <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_sourceImage)
            _sourceImage = 0
        End If
        If _clonedImage <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_clonedImage)
            _clonedImage = 0
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

    Private Sub cmbKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKey.SelectedIndexChanged
        ProcessFilter()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HSThreshold.Value = 240
        HSMinVal.Value = 25
        ProcessFilter()
    End Sub
End Class