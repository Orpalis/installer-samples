Option Explicit On
Option Strict On
Imports GdPicture14

Public Class Thresholder

    Dim m_parentMainForm As MainForm


    'Image Identifier to do Threshold on
    Public m_ClonedImage As Integer


    Public Sub New(ByRef FormReference As MainForm)
        InitializeComponent()
        m_parentMainForm = FormReference
        cmbBinarizationMode.SelectedIndex = binarizationMode
        updateUI()
        doThreshold()
    End Sub


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        If m_ClonedImage <> 0 Then
            gdPictureImaging.ReleaseGdPictureImage(nativeImage)
            nativeImage = m_ClonedImage
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        If m_ClonedImage <> 0 Then
            gdPictureImaging.ReleaseGdPictureImage(m_ClonedImage)
            m_parentMainForm.GdViewer1.DisplayFromGdPictureImage(nativeImage)
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbBinarizationMode.SelectedIndexChanged
        Dim newBinarizationMode As ThresoldingMode = CType(cmbBinarizationMode.SelectedIndex, ThresoldingMode)
        If binarizationMode <> newBinarizationMode Then
            binarizationMode = newBinarizationMode
            updateUI()
            doThreshold()
        End If
    End Sub


    Private Sub updateUI()
        Select Case binarizationMode
            Case ThresoldingMode.Linear 'Linear
                'change threshold parameters
                Label15.Text = "Threshold"
                txtThresholdMax.Text = "254"
                txtThresholdMin.Text = "1"
                scrlThresoldParam.Minimum = 1
                scrlThresoldParam.Maximum = 254
                scrlThresoldParam.Value = 128
                txtThreshVal.Text = scrlThresoldParam.Value.ToString()
                TableLayoutPanel7.Visible = True
                TableLayoutPanel5.Visible = False
                TableLayoutPanel6.Visible = False

            Case ThresoldingMode.Bradley 'Adaptive (Modified Bradley)
                'change threshold parameters
                Label15.Text = "Threshold"
                txtThresholdMax.Text = "255"
                txtThresholdMin.Text = "1"
                scrlThresoldParam.Minimum = 1
                scrlThresoldParam.Maximum = 255
                scrlThresoldParam.Value = DEFAULT_BRADLEY_THRESOLD
                txtThreshVal.Text = scrlThresoldParam.Value.ToString()
                TableLayoutPanel7.Visible = True
                TableLayoutPanel5.Visible = False
                TableLayoutPanel6.Visible = False

            Case ThresoldingMode.Otsu 'Adaptive (Modified Otsu)
                'change threshold parameters
                Label15.Text = "Threshold"
                txtThresholdMax.Text = "100"
                scrlThresoldParam.Minimum = 0
                txtThresholdMin.Text = "0"
                scrlThresoldParam.Maximum = 100
                scrlThresoldParam.Value = 50
                txtThreshVal.Text = scrlThresoldParam.Value.ToString()
                TableLayoutPanel7.Visible = True
                TableLayoutPanel5.Visible = False
                TableLayoutPanel6.Visible = False

            Case ThresoldingMode.Sauvola 'Sauvola
                'change threshold parameters
                Label15.Text = "Factor"
                txtThresholdMax.Text = "1"
                txtThresholdMin.Text = "0"
                scrlThresoldParam.Minimum = 0
                scrlThresoldParam.Maximum = 100
                scrlThresoldParam.Value = 35
                txtThreshVal.Text = Math.Round((scrlThresoldParam.Value / 100), 2).ToString()
                TableLayoutPanel7.Visible = True
                TableLayoutPanel5.Visible = True
                TableLayoutPanel6.Visible = True

        End Select
    End Sub


    Private Sub scrlThresoldParam_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrlThresoldParam.Scroll
        If e.NewValue <> e.OldValue Then
            If cmbBinarizationMode.SelectedIndex = 2 Then
                txtThreshVal.Text = Math.Round((scrlThresoldParam.Value / 100), 2).ToString()
            Else
                txtThreshVal.Text = e.NewValue.ToString()
            End If

            thresholdValue = e.NewValue
            doThreshold()
        End If
    End Sub


    Private Sub scrlKernelParam_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrlKernelParam.Scroll
        If e.NewValue <> e.OldValue Then
            txtKernelVal.Text = e.NewValue.ToString()
            smoothKernel = e.NewValue
            doThreshold()
        End If
    End Sub


    Private Sub scrlContrastParam_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrlContrastParam.Scroll
        If e.NewValue <> e.OldValue Then
            txtMinDifVal.Text = e.NewValue.ToString()
            contrastMinDif = e.NewValue
            doThreshold()
        End If
    End Sub


    Public Sub doThreshold()
        If m_ClonedImage <> 0 Then
            gdPictureImaging.ReleaseGdPictureImage(m_ClonedImage)
        End If
        If nativeImage <> 0 Then
            m_ClonedImage = gdPictureImaging.CreateClonedGdPictureImage(nativeImage)
            If m_ClonedImage = 0 Then
                MessageBox.Show("Error cloning input image: " + gdPictureImaging.GetStat().ToString())
                Return
            End If
        End If

        Select Case binarizationMode
            Case ThresoldingMode.Linear 'Linear
                gdPictureImaging.ConvertTo1Bpp(m_ClonedImage, CByte(thresholdValue))
            Case ThresoldingMode.Bradley 'Adaptive (Modified Bradley)
                gdPictureImaging.ConvertTo1BppBradley(m_ClonedImage, CByte(thresholdValue))
            Case ThresoldingMode.Otsu 'Adaptive (Modified Otsu)
                gdPictureImaging.ConvertTo1BppAT(m_ClonedImage, thresholdValue)
            Case ThresoldingMode.Sauvola 'Sauvola
                gdPictureImaging.ConvertTo1BppSauvola(m_ClonedImage, thresholdValue / 100.0F, contrastMinDif, smoothKernel)
        End Select

        If gdPictureImaging.GetStat = GdPictureStatus.OK Then
            If m_parentMainForm.GdViewer1.DisplayFromGdPictureImage(m_ClonedImage) <> GdPictureStatus.OK Then
                MessageBox.Show("The Image cannot be displayed. Status: " + m_parentMainForm.GdViewer1.GetStat().ToString())
            End If
        Else
            MessageBox.Show("Can't binarize image. Error: " + gdPictureImaging.GetStat().ToString())
        End If
    End Sub

End Class
