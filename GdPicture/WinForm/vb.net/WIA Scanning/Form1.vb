Option Strict On
Option Explicit On

Imports GdPicture14

Public Class Form1

    Private oGdPictureImaging As New GdPictureImaging



    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key. 
        DisplayWIADevices()
    End Sub


    Private Sub DisplayWIADevices()
        For i As Integer = 1 To oGdPictureImaging.WiaGetSourceCount
            Me.lstDevices.Items.Add(oGdPictureImaging.WiaGetSourceName(i) + " - " + oGdPictureImaging.WiaGetSourceType(i).ToString)
        Next
    End Sub


    Private Function OpenSelectedSource() As Boolean
        If lstDevices.Items.Count > 0 Then
            Dim ItemIdx As Integer = lstDevices.SelectedIndex

            If ItemIdx >= 0 Then
                Dim Success As Boolean = oGdPictureImaging.WiaOpenSource(oGdPictureImaging.WiaGetSourceID(ItemIdx + 1))
                If Not Success Then MsgBox("Can't open selected WIA device")
                Return Success
            Else
                MsgBox("Please, select a WIA device first !")
                Return False
            End If
        Else
            MsgBox("No WIA Device available !")
        End If
    End Function


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim nImageCount As Integer
        Dim ImageID As Integer
        Dim MultiPageID As Integer

        If OpenSelectedSource() Then
            nImageCount = 0
            If Not CBool(chkHideUI.CheckState) Then
                oGdPictureImaging.WiaShowSetupDialogSource()
            End If
            oGdPictureImaging.WiaSelectFeeder(True)

            Do
                ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage()
                If ImageID <> 0 Then
                    nImageCount = nImageCount + 1
                    Call ApplyImageFilters(ImageID)
                    If chkPreview.CheckState = 1 Then Call DisplayImage(ImageID)
                    If nImageCount = 1 Then
                        MultiPageID = ImageID
                        Call oGdPictureImaging.TiffSaveAsMultiPageFile(MultiPageID, My.Application.Info.DirectoryPath & "\multipage.tif", TiffCompression.TiffCompressionCCITT4)
                    Else
                        oGdPictureImaging.TiffAddToMultiPageFile(MultiPageID, ImageID)
                        oGdPictureImaging.ReleaseGdPictureImage(ImageID)
                    End If
                End If
            Loop While oGdPictureImaging.WiaGetLastError = WiaStatus.WIA_OK
            oGdPictureImaging.TiffCloseMultiPageFile(MultiPageID)
            MsgBox("Done. WIA status: " + oGdPictureImaging.WiaGetLastError.ToString)
            oGdPictureImaging.WiaCloseSource()
        End If
    End Sub


    Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command12.Click
        Dim ImageID As Integer
        Dim oGdPicturePDF As New GdPicturePDF

        If OpenSelectedSource() Then
            If Not CBool(chkHideUI.CheckState) Then
                oGdPictureImaging.WiaShowSetupDialogSource()
            End If

            oGdPictureImaging.WiaSelectFeeder(True)

            oGdPicturePDF.NewPDF()

            Do
                ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage()
                If ImageID <> 0 Then
                    Call ApplyImageFilters(ImageID)
                    If chkPreview.CheckState = 1 Then Call DisplayImage(ImageID)
                    Call oGdPicturePDF.AddImageFromGdPictureImage(ImageID, False, True)
                    oGdPictureImaging.ReleaseGdPictureImage(ImageID)
                End If
            Loop While oGdPictureImaging.WiaGetLastError = WiaStatus.WIA_OK
            oGdPicturePDF.SaveToFile("output.pdf")
            oGdPicturePDF.CloseDocument()
            MsgBox("Done. WIA status: " + oGdPictureImaging.WiaGetLastError.ToString)
            oGdPictureImaging.WiaCloseSource()
        End If
    End Sub


    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim nImageCount As Integer
        Dim ImageID As Integer


        If OpenSelectedSource() Then
            nImageCount = 0
            If Not CBool(chkHideUI.CheckState) Then
                oGdPictureImaging.WiaShowSetupDialogSource()
            End If

            Do
                ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage()
                If ImageID <> 0 Then
                    Call ApplyImageFilters(ImageID)
                    If chkPreview.CheckState = 1 Then Call DisplayImage(ImageID)
                    nImageCount = nImageCount + 1
                    Call oGdPictureImaging.SaveAsJPEG(ImageID, My.Application.Info.DirectoryPath & "\image" & Trim(Str(nImageCount)) & ".jpg", 75)
                    Call oGdPictureImaging.ReleaseGdPictureImage(ImageID)
                End If
            Loop While oGdPictureImaging.WiaGetLastError = WiaStatus.WIA_OK
            MsgBox("Done. WIA status: " + oGdPictureImaging.WiaGetLastError.ToString)
            oGdPictureImaging.WiaCloseSource()
        End If
    End Sub


    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        Dim ImageID As Integer

        If OpenSelectedSource() Then
            If Not CBool(chkHideUI.CheckState) Then
                oGdPictureImaging.WiaShowSetupDialogSource()
            End If

            oGdPictureImaging.WiaSelectFeeder(False)

            ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage()
            If ImageID <> 0 Then
                Call ApplyImageFilters(ImageID)
                If chkPreview.CheckState = 1 Then Call DisplayImage(ImageID)
                Call oGdPictureImaging.SaveAsPDF(ImageID, My.Application.Info.DirectoryPath & "\acquire.pdf", True, "", "", "", "", "")
                Call oGdPictureImaging.ReleaseGdPictureImage(ImageID)
            End If
            MsgBox("Done. WIA status: " + oGdPictureImaging.WiaGetLastError.ToString)
            oGdPictureImaging.WiaCloseSource()
        End If
    End Sub


    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        Dim ImageID As Integer

        If OpenSelectedSource() Then
            If Not CBool(chkHideUI.CheckState) Then
                oGdPictureImaging.WiaShowSetupDialogSource()
            End If

            oGdPictureImaging.WiaSelectFeeder(False)

            ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage()
            If ImageID <> 0 Then
                Call ApplyImageFilters(ImageID)
                If chkPreview.CheckState = 1 Then Call DisplayImage(ImageID)
                Call oGdPictureImaging.SaveAsJPEG(ImageID, My.Application.Info.DirectoryPath & "\acquire.jpg", 90)
                Call oGdPictureImaging.ReleaseGdPictureImage(ImageID)
            End If
            MsgBox("Done. WIA status: " + oGdPictureImaging.WiaGetLastError.ToString)
            oGdPictureImaging.WiaCloseSource()
        End If
    End Sub



    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
        If OpenSelectedSource() Then
            oGdPictureImaging.WiaShowSetupDialogSource()
        End If
    End Sub



    Private Sub DisplayImage(ByVal ImageID As Integer)
        Call GdViewer1.DisplayFromGdPictureImage(ImageID)
        GdViewer1.CloseDocument(True)
        System.Windows.Forms.Application.DoEvents()
    End Sub



    Private Sub ApplyImageFilters(ByRef ImageID As Integer)
        If Me.ChkNeg.CheckState = 1 Then oGdPictureImaging.FxNegative(ImageID)

        If Me.chkRemoveDots.CheckState = 1 And oGdPictureImaging.GetBitDepth(ImageID) = 1 Then
            oGdPictureImaging.FxBitonalRemoveIsolatedDots2x2(ImageID)
        End If

        If Me.chkRemoveHP.CheckState = 1 And oGdPictureImaging.GetBitDepth(ImageID) = 1 Then
            oGdPictureImaging.RemoveHolePunch(ImageID)
        End If

        If Me.chkRotate90.CheckState = 1 And Me.chkRotate180.CheckState = 1 Then
            oGdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate270FlipNone)
        Else
            If Me.chkRotate90.CheckState = 1 Then Call oGdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate90FlipNone)
            If Me.chkRotate180.CheckState = 1 Then Call oGdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate180FlipNone)
        End If

        If Me.chkAutoDesk.CheckState = 1 Then Call oGdPictureImaging.AutoDeskew(ImageID)

        If Me.ChkAutoCrop.CheckState = 1 Then Call oGdPictureImaging.CropBlackBordersEx(ImageID)
    End Sub

End Class