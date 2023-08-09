Option Explicit On
Option Strict On

Imports GdPicture14

Public Class Despeckle

    Private m_GdViewer As GdViewer

    'Image Identifier to do Despeckle on
    Public m_ClonedImage As Integer

    Public Sub New(gdViewer As GdViewer)
        InitializeComponent()
        m_GdViewer = gdViewer
        cmbDespeckleMode.Items.AddRange([Enum].GetNames(GetType(DespeckleType)))

        cmbDespeckleMode.SelectedIndex = Convert.ToInt32(Globals.despeckleType)

        scrlStrengthParam.Value = Globals.despeckleStrength
        txtStrengthVal.Text = Globals.despeckleStrength.ToString()
        DoDespeckle()
    End Sub

    Private Sub DoDespeckle()
        If m_ClonedImage <> 0 Then
            Globals.gdPictureImaging.ReleaseGdPictureImage(m_ClonedImage)
        End If
        If Globals.nativeImage <> 0 Then
            m_ClonedImage = Globals.gdPictureImaging.CreateClonedGdPictureImage(Globals.nativeImage)
            If m_ClonedImage = 0 Then
                MessageBox.Show("Error cloning input image: " + Globals.gdPictureImaging.GetStat().ToString())
                Return
            End If
        End If

        Globals.gdPictureImaging.FxBitonalDespeckleAdvanced(m_ClonedImage, CType([Enum].Parse(GetType(DespeckleType), cmbDespeckleMode.SelectedItem.ToString()), DespeckleType), Globals.despeckleStrength)

        If Globals.gdPictureImaging.GetStat() = GdPictureStatus.OK Then
            If m_GdViewer.DisplayFromGdPictureImage(m_ClonedImage) <> GdPictureStatus.OK Then
                MessageBox.Show("The Image cannot be displayed. Status: " + m_GdViewer.GetStat().ToString())
            End If
        Else
            MessageBox.Show("Can't binarize image. Error: " + Globals.gdPictureImaging.GetStat().ToString())
        End If
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        If m_ClonedImage <> 0 Then
            Globals.gdPictureImaging.ReleaseGdPictureImage(Globals.nativeImage)
            Globals.nativeImage = m_ClonedImage
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        If m_ClonedImage <> 0 Then
            Globals.gdPictureImaging.ReleaseGdPictureImage(m_ClonedImage)
            m_GdViewer.DisplayFromGdPictureImage(Globals.nativeImage)
        End If
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmbDespeckleMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDespeckleMode.SelectedIndexChanged
        Globals.despeckleType = CType([Enum].Parse(GetType(DespeckleType), cmbDespeckleMode.SelectedItem.ToString()), DespeckleType)
        DoDespeckle()
    End Sub

    Private Sub scrlStrengthParam_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlStrengthParam.Scroll
        If e.NewValue <> e.OldValue Then
            txtStrengthVal.Text = e.NewValue.ToString()
            Globals.despeckleStrength = e.NewValue
            DoDespeckle()
        End If
    End Sub
End Class