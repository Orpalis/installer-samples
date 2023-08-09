Option Strict On
Option Explicit On

Imports GdPicture14
Public Class Form1
    Private _sourceImage As Integer
    Private _clonedImage As Integer
    Private _bitonalReduction As BitonalReduction
    Private _lockEvents As Boolean = False
    Private _previous As Integer = -1
    Private ReadOnly _gdPictureImaging As New GdPictureImaging

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
        scroll1Panel.Visible = False
        scroll2Panel.Visible = False
        scroll3Panel.Visible = False
    End Sub

    Private Sub CloseImage()
        If _sourceImage <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_sourceImage)
            _sourceImage = 0
        End If
        If _clonedImage <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(_clonedImage)
            _clonedImage = 0
        End If
        GdViewer1.CloseDocument()
        comboBox1.SelectedIndex = 0
    End Sub

    Private Sub openToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Call CloseImage()

        _sourceImage = _gdPictureImaging.CreateGdPictureImageFromFile("")
        If _gdPictureImaging.GetStat = 0 Then
            GdViewer1.DisplayFromGdPictureImage(_sourceImage)
        End If
    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Call CloseImage()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Call CloseImage()
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim oSaveFileDialog As New SaveFileDialog
        oSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        oSaveFileDialog.Filter = "TIFF Image|*.tif"
        If oSaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim FilePath As String = oSaveFileDialog.FileName
            If _gdPictureImaging.SaveAsTIFF(_clonedImage, oSaveFileDialog.FileName, TiffCompression.TiffCompressionCCITT4) = GdPictureStatus.OK Then
                MessageBox.Show("Document succefully saved as Tiff in " + FilePath)
            Else
                MessageBox.Show("Can't save document in " + FilePath + " Error: " + _gdPictureImaging.GetStat().ToString())
            End If
        End If
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        _lockEvents = True
        Select Case comboBox1.SelectedIndex
            Case 0
                If _previous <> 0 Then
                    scroll1Panel.Visible = False
                    scroll2Panel.Visible = False
                    scroll3Panel.Visible = False
                End If
                _previous = 0
            Case 1 'Linear
                If _previous <> 1 Then
                    'change threshold parameters
                    Label1.Text = "Threshold"
                    txtThresholdMax.Text = "254"
                    txtThresholdMin.Text = "1"
                    scrlThresoldParam.Minimum = 1
                    scrlThresoldParam.Maximum = 254
                    scrlThresoldParam.Value = 128
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString()
                    scroll1Panel.Visible = True
                    scroll2Panel.Visible = False
                    scroll3Panel.Visible = False
                End If
                _previous = 1
            Case 2 'Adaptive (Otsu)
                If _previous <> 2 Then
                    'change threshold parameters
                    Label1.Text = "Threshold"
                    txtThresholdMax.Text = "100"
                    scrlThresoldParam.Minimum = 0
                    txtThresholdMin.Text = "0"
                    scrlThresoldParam.Maximum = 100
                    scrlThresoldParam.Value = 50
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString()
                    scroll1Panel.Visible = True
                    scroll2Panel.Visible = False
                    scroll3Panel.Visible = False
                End If
                _previous = 2
            Case 3 'Order Dither
                If _previous <> 3 Then
                    scroll1Panel.Visible = False
                    scroll2Panel.Visible = False
                    scroll3Panel.Visible = False
                End If
                _previous = 3
                _bitonalReduction = BitonalReduction.OrderedDither
            Case 4 'Burke
                If _previous <> 4 Then
                    Label1.Text = "PalWeight"
                    txtThresholdMin.Text = "1"
                    txtThresholdMax.Text = "255"
                    scrlThresoldParam.Minimum = 1
                    scrlThresoldParam.Maximum = 255
                    scrlThresoldParam.Value = 15
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString()
                    scroll1Panel.Visible = True
                    scroll2Panel.Visible = False
                    scroll3Panel.Visible = False
                End If
                _previous = 4
                _bitonalReduction = BitonalReduction.Burke
            Case 5 'Stucki
                If _previous <> 5 Then
                    Label1.Text = "PalWeight"
                    txtThresholdMin.Text = "1"
                    txtThresholdMax.Text = "255"
                    scrlThresoldParam.Minimum = 1
                    scrlThresoldParam.Maximum = 255
                    scrlThresoldParam.Value = 15
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString()
                    scroll1Panel.Visible = True
                    scroll2Panel.Visible = False
                    scroll3Panel.Visible = False
                End If
                _previous = 5
                _bitonalReduction = BitonalReduction.Stucki
            Case 6 'FloydStienberg
                If _previous <> 6 Then
                    Label1.Text = "PalWeight"
                    txtThresholdMax.Text = "255"
                    scrlThresoldParam.Minimum = 1
                    txtThresholdMin.Text = "1"
                    scrlThresoldParam.Maximum = 255
                    scrlThresoldParam.Value = 15
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString()
                    scroll1Panel.Visible = True
                    scroll2Panel.Visible = False
                    scroll3Panel.Visible = False
                End If
                _previous = 6
                _bitonalReduction = BitonalReduction.FloydSteinberg
            Case 7 'Sauvola
                If _previous <> 7 Then
                    Label1.Text = "Factor"
                    txtThresholdMax.Text = "1"
                    txtThresholdMin.Text = "0"
                    scrlThresoldParam.Minimum = 0
                    scrlThresoldParam.Maximum = 100
                    scrlThresoldParam.Value = 35
                    txtThreshVal.Text = Math.Round((scrlThresoldParam.Value / 100), 2).ToString()
                    scroll1Panel.Visible = True
                    scroll2Panel.Visible = True
                    scroll3Panel.Visible = True
                End If
                _previous = 7
            Case 8 'Bradley
                If _previous <> 8 Then
                    Label1.Text = "Threshold"
                    txtThresholdMax.Text = "0"
                    txtThresholdMin.Text = "254"
                    scrlThresoldParam.Minimum = 0
                    scrlThresoldParam.Maximum = 254
                    scrlThresoldParam.Value = 38
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString()
                    scroll1Panel.Visible = True
                    scroll2Panel.Visible = False
                    scroll3Panel.Visible = False
                End If
                _previous = 8
        End Select
        _lockEvents = False

        If _sourceImage <> 0 Then
            doThreshold()
        End If
    End Sub

    Private Sub DoThreshold()

        If comboBox1.SelectedIndex > 0 AndAlso comboBox1.SelectedIndex <= 8 Then
            If _clonedImage <> 0 Then
                _gdPictureImaging.ReleaseGdPictureImage(_clonedImage)
            End If
            If _sourceImage <> 0 Then
                _clonedImage = _gdPictureImaging.CreateClonedGdPictureImage(_sourceImage)
                If _clonedImage = 0 Then
                    MessageBox.Show("Error : " + _gdPictureImaging.GetStat().ToString())
                    Return
                End If
            End If

            Select Case comboBox1.SelectedIndex
                Case 1 'Linear
                    _gdPictureImaging.ConvertTo1Bpp(_clonedImage, CByte(scrlThresoldParam.Value))
                Case 2 'Adaptive (Otsu)
                    _gdPictureImaging.ConvertTo1BppAT(_clonedImage, scrlThresoldParam.Value)
                Case 3, 4, 5, 6 'dithering methods
                    If _gdPictureImaging.FxBlackNWhite(_clonedImage, _bitonalReduction, scrlThresoldParam.Value) = GdPictureStatus.OK Then
                        _gdPictureImaging.ConvertTo1BppFast(_clonedImage)
                    End If
                Case 7 'Sauvola
                    _gdPictureImaging.ConvertTo1BppSauvola(_clonedImage, scrlThresoldParam.Value / 100.0F, scrlContrastParam.Value, scrlKernelParam.Value)
                Case 8 'Bradley
                    _gdPictureImaging.ConvertTo1BppBradley(_clonedImage, CByte(scrlThresoldParam.Value))
            End Select

            If _gdPictureImaging.GetStat = GdPictureStatus.OK Then
                If GdViewer1.DisplayFromGdPictureImage(_clonedImage) <> GdPictureStatus.OK Then
                    MessageBox.Show("The Image cannot be displayed")
                End If
            Else
                MessageBox.Show("Can't binarize image. Error: " + _gdPictureImaging.GetStat().ToString())
            End If
        End If

    End Sub

    Private Sub scrlThresoldParam_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrlThresoldParam.Scroll
        If e.NewValue <> e.OldValue Then
            If comboBox1.SelectedIndex = 7 Then
                txtThreshVal.Text = Math.Round((scrlThresoldParam.Value / 100), 2).ToString()
            Else
                txtThreshVal.Text = e.NewValue.ToString()
            End If

            If Not _lockEvents Then
                doThreshold()
            End If
        End If
    End Sub

    Private Sub scrlContrastParam_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrlContrastParam.Scroll
        If e.NewValue <> e.OldValue Then
            txtMinDifVal.Text = e.NewValue.ToString()
            If Not _lockEvents Then
                doThreshold()
            End If
        End If
    End Sub

    Private Sub scrlKernelParam_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrlKernelParam.Scroll
        If e.NewValue <> e.OldValue Then
            txtKernelVal.Text = e.NewValue.ToString()
            If Not _lockEvents Then
                doThreshold()
            End If
        End If
    End Sub
End Class