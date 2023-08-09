Option Strict On
Option Explicit On

Imports GdPicture14

Public Class Form1

    Private WithEvents m_GdPictureImaging As New GdPictureImaging



    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'Check for 64-bit mode app running
        If IntPtr.Size = 8 Then
            MessageBox.Show("Warning: The application is running in 64-bit mode. To be able to handle 32-bit TWAIN drivers you will have to target it to 32-bit mode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key. 

        m_GdPictureImaging.TwainLogStart("gdpicture_twain.log")
        DisplayTwainDevices()
    End Sub


    Private Sub TwainImagePreview(ImageID As Integer, Reserved As Integer) Handles m_GdPictureImaging.TwainImagePreview
        ApplyImageFilters(ImageID)

        If chkPreview.CheckState = 1 Then
            Call GdViewer1.DisplayFromGdPictureImage(ImageID)
            GdViewer1.CloseDocument(True)
            System.Windows.Forms.Application.DoEvents()
        End If
    End Sub


    Private Sub Form1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        m_GdPictureImaging.TwainUnloadSourceManager(Me.Handle)
        m_GdPictureImaging.TwainLogStop()
    End Sub


    Private Sub DisplayTwainDevices()
        For i As Integer = 1 To m_GdPictureImaging.TwainGetSourceCount(Me.Handle)
            Me.lstDevices.Items.Add(m_GdPictureImaging.TwainGetSourceName(Me.Handle, i))
        Next
    End Sub


    Private Function OpenSelectedSource() As Boolean
        If lstDevices.Items.Count > 0 Then
            Dim ItemIdx As Integer = lstDevices.SelectedIndex

            If ItemIdx >= 0 Then
                Dim Success As Boolean = m_GdPictureImaging.TwainOpenSource(Me.Handle, CStr(lstDevices.Items.Item(ItemIdx)))
                If Not Success Then MsgBox("Can't open selected TWAIN device")
                Return Success
            Else
                MsgBox("Please, select a TWAIN device first !")
                Return False
            End If
        Else
            MsgBox("No TWAIN Device available !")
        End If
    End Function


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        'Here we will scan in a 1bpp ccitt4 & 200 DPI from adf to multipage tif file
        Dim nImageCount As Integer
        Dim ImageID As Integer
        Dim MultiPageID As Integer

        If OpenSelectedSource() Then
            nImageCount = 0

            m_GdPictureImaging.TwainSetHideUI(CBool(chkHideUI.CheckState))
            m_GdPictureImaging.TwainSetIndicators(CBool(chkIndicator.CheckState))

            m_GdPictureImaging.TwainSetAutoFeed(True) 'Set AutoFeed Enabled
            m_GdPictureImaging.TwainSetAutoScan(True) 'To  achieve the maximum scanning rate

            m_GdPictureImaging.TwainSetResolution(200)
            m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_BW) 'Black & White
            m_GdPictureImaging.TwainSetBitDepth(1) ' 1 bpp
            Do
                ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(Me.Handle)
                If ImageID <> 0 Then
                    nImageCount = nImageCount + 1
                    If Me.chkRemoveBlankPages.Checked Then
                        If m_GdPictureImaging.IsBlank(ImageID, 99) Then
                            m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                            ImageID = 0
                        End If
                    End If
                    If ImageID <> 0 Then

                        If nImageCount = 1 Then
                            MultiPageID = ImageID
                            Call m_GdPictureImaging.TiffSaveAsMultiPageFile(MultiPageID, My.Application.Info.DirectoryPath & "\multipage.tif", TiffCompression.TiffCompressionCCITT4)
                        Else
                            m_GdPictureImaging.TiffAddToMultiPageFile(MultiPageID, ImageID)
                            m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                        End If
                    End If
                End If
            Loop While m_GdPictureImaging.TwainGetState > TwainStatus.TWAIN_SOURCE_ENABLED

            m_GdPictureImaging.TiffCloseMultiPageFile(MultiPageID)
            m_GdPictureImaging.TwainCloseSource()
            MsgBox("Done !")
        End If

    End Sub


    Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command12.Click
        'Here we will scan in a 1bpp  form adf to multiple page pdf file
        Dim ImageID As Integer
        Dim oGdPicturePDF As New GdPicturePDF

        If OpenSelectedSource() Then
            m_GdPictureImaging.TwainSetHideUI(CBool(chkHideUI.CheckState))
            m_GdPictureImaging.TwainSetIndicators(CBool(chkIndicator.CheckState))

            m_GdPictureImaging.TwainSetAutoFeed(True) 'Set AutoFeed Enabled
            m_GdPictureImaging.TwainSetAutoScan(True) 'To  achieve the maximum scanning rate
            m_GdPictureImaging.TwainSetResolution(200)
            m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_BW) 'Black & White
            m_GdPictureImaging.TwainSetBitDepth(1) ' 1 bpp

            oGdPicturePDF.NewPDF()

            Do
                ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(Me.Handle)
                If ImageID <> 0 Then
                    If Me.chkRemoveBlankPages.Checked Then
                        If m_GdPictureImaging.IsBlank(ImageID, 99) Then
                            m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                            ImageID = 0
                        End If
                    End If
                    If ImageID <> 0 Then
                        Call oGdPicturePDF.AddImageFromGdPictureImage(ImageID, False, True)
                        m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                    End If
                End If
            Loop While m_GdPictureImaging.TwainGetState > TwainStatus.TWAIN_SOURCE_ENABLED
            oGdPicturePDF.SaveToFile("output.pdf")
            oGdPicturePDF.CloseDocument()

            Call m_GdPictureImaging.TwainCloseSource()
            MsgBox("Done !")
        End If

    End Sub


    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        'Here we will scan in a 24bpp  & 300 DPI from ADF into separate jpeg files
        Dim nImageCount As Integer
        Dim ImageID As Integer


        If OpenSelectedSource() Then
            nImageCount = 0

            m_GdPictureImaging.TwainSetHideUI(CBool(chkHideUI.CheckState))
            m_GdPictureImaging.TwainSetIndicators(CBool(chkIndicator.CheckState))

            m_GdPictureImaging.TwainSetAutoFeed(True) 'Set AutoFeed Enabled
            m_GdPictureImaging.TwainSetAutoScan(True) 'To  achieve the maximum scanning rate
            m_GdPictureImaging.TwainSetResolution(300)
            m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_RGB) 'RGB
            m_GdPictureImaging.TwainSetBitDepth(24) ' 24 bpp

            Do
                ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(Me.Handle)
                If ImageID <> 0 Then
                    If Me.chkRemoveBlankPages.Checked Then
                        If m_GdPictureImaging.IsBlank(ImageID, 99) Then
                            m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                            ImageID = 0
                        End If
                    End If
                    If ImageID <> 0 Then
                        nImageCount = nImageCount + 1
                        Call m_GdPictureImaging.SaveAsJPEG(ImageID, My.Application.Info.DirectoryPath & "\image" & Trim(Str(nImageCount)) & ".jpg", 75)
                        Call m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                    End If
                End If
            Loop While m_GdPictureImaging.TwainGetState > TwainStatus.TWAIN_SOURCE_ENABLED

            Call m_GdPictureImaging.TwainCloseSource()
            MsgBox("Done !")
        End If

    End Sub


    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        'Here we will scan in a 24bpp & 300 DPI PDF file
        Dim ImageID As Integer

        If OpenSelectedSource() Then
            m_GdPictureImaging.TwainSetHideUI(CBool(chkHideUI.CheckState))
            m_GdPictureImaging.TwainSetIndicators(CBool(chkIndicator.CheckState))

            m_GdPictureImaging.TwainSetResolution(300)
            m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_RGB) 'RGB
            m_GdPictureImaging.TwainSetBitDepth(24) ' 24 bpp

            ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(Me.Handle)
            If ImageID <> 0 Then
                If Me.chkRemoveBlankPages.Checked Then
                    If m_GdPictureImaging.IsBlank(ImageID, 99) Then
                        m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                        ImageID = 0
                    End If
                End If
                If ImageID <> 0 Then
                    Call m_GdPictureImaging.SaveAsPDF(ImageID, My.Application.Info.DirectoryPath & "\acquire.pdf", True, "", "", "", "", "")
                    Call m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                End If

            End If

            Call m_GdPictureImaging.TwainCloseSource()
            MsgBox("Done !")
        End If

    End Sub


    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        'Here we will scan in a 24bpp  & 300 DPI  jpeg file
        Dim ImageID As Integer

        If OpenSelectedSource() Then
            m_GdPictureImaging.TwainSetHideUI(CBool(chkHideUI.CheckState))
            m_GdPictureImaging.TwainSetIndicators(CBool(chkIndicator.CheckState))

            m_GdPictureImaging.TwainSetResolution(300)
            m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_RGB) 'RGB
            m_GdPictureImaging.TwainSetBitDepth(24) ' 24 bpp

            ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(Me.Handle)
            If ImageID <> 0 Then
                If Me.chkRemoveBlankPages.Checked Then
                    If m_GdPictureImaging.IsBlank(ImageID, 99) Then
                        m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                        ImageID = 0
                    End If
                End If
                If ImageID <> 0 Then
                    Call m_GdPictureImaging.SaveAsJPEG(ImageID, My.Application.Info.DirectoryPath & "\acquire.jpg", 90)
                    Call m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                End If
            End If

            Call m_GdPictureImaging.TwainCloseSource()
            MsgBox("Done !")
        End If
    End Sub



    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
        If OpenSelectedSource() Then
            m_GdPictureImaging.TwainSetModalUI(True)
            m_GdPictureImaging.TwainShowSetupDialogSource(Me.Handle)
        End If
    End Sub



    Private Sub ApplyImageFilters(ByVal ImageID As Integer)

        If Me.ChkNeg.CheckState = 1 Then m_GdPictureImaging.FxNegative(ImageID)

        If Me.chkRemoveDots.CheckState = 1 And m_GdPictureImaging.GetBitDepth(ImageID) = 1 Then
            m_GdPictureImaging.FxBitonalRemoveIsolatedDots2x2(ImageID)
        End If

        If Me.chkRotate90.CheckState = 1 And Me.chkRotate180.CheckState = 1 Then
            m_GdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate270FlipNone)
        Else
            If Me.chkRotate90.CheckState = 1 Then Call m_GdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate90FlipNone)
            If Me.chkRotate180.CheckState = 1 Then Call m_GdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate180FlipNone)
        End If

        If Me.chkRemoveHP.CheckState = 1 And m_GdPictureImaging.GetBitDepth(ImageID) = 1 Then
            m_GdPictureImaging.RemoveHolePunch(ImageID)
        End If

        If Me.chkAutoDesk.CheckState = 1 Then Call m_GdPictureImaging.AutoDeskew(ImageID, 12, Color.White, 0.25, False)

        If Me.ChkAutoCrop.CheckState = 1 Then Call m_GdPictureImaging.CropBlackBordersEx(ImageID)
    End Sub

End Class