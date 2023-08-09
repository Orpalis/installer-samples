Option Explicit On
Option Strict On

Imports GdPicture14



Public Class Form1
    Private caption As String = "PDF Signer"
    Private ReadOnly _gdPicturePdf As New GdPicturePDF
    Private _hasNativePdf As Boolean = False
    Private inputfilename As String = ""
    Private certLevel As PdfSignatureCertificationLevel
    Private hash As PdfSignatureHash
    Private mode As PdfSignatureMode

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.


        txtCertPath.Text = My.Settings.certPath
        txtCertPass.Text = My.Settings.certPass
        txtImageStampPath.Text = My.Settings.stamPath
        certLevel = My.Settings.certLevel
        hash = My.Settings.hash
        mode = My.Settings.mode
        txtTSServer.Text = My.Settings.tsServer
        txtTSUser.Text = My.Settings.tsUser
        txtTSPassword.Text = My.Settings.tsPassword
        txtSignerName.Text = My.Settings.signerName
        txtReason.Text = My.Settings.reason
        txtLocation.Text = My.Settings.location
        txtContactInfo.Text = My.Settings.contact
        chkValidationMark.Checked = My.Settings.validMark
        chkLinearize.Checked = My.Settings.linearize

        Select Case certLevel
            Case PdfSignatureCertificationLevel.NotCertified
                optCertLevelNone.Checked = True
                Exit Select
            Case PdfSignatureCertificationLevel.NoChanges
                optCertLevelNoChanges.Checked = True
                Exit Select
            Case PdfSignatureCertificationLevel.FormFilling
                optCertLevelFormFill.Checked = True
                Exit Select
            Case PdfSignatureCertificationLevel.FormFillingAndAnnotations
                optCertLevelFormFillAnnot.Checked = True
                Exit Select
        End Select

        Select Case hash
            Case PdfSignatureHash.SHA256
                optHash256.Checked = True
                Exit Select
            Case PdfSignatureHash.SHA512
                optHash512.Checked = True
                Exit Select
            Case PdfSignatureHash.SHA224
                optHash224.Checked = True
                Exit Select
            Case PdfSignatureHash.SHA384
                optHash384.Checked = True
                Exit Select
        End Select

        Select Case mode
            Case PdfSignatureMode.PdfSignatureModeAdobePPKMS
                optModePPKMS.Checked = True
                Exit Select
            Case PdfSignatureMode.PdfSignatureModeAdobePPKLite
                optModePPKLITE.Checked = True
                Exit Select
            Case PdfSignatureMode.PdfSignatureModeAdobeCADES
                optModeCADES.Checked = True
                Exit Select
        End Select
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.certPath = txtCertPath.Text
        My.Settings.certPass = txtCertPass.Text
        My.Settings.stamPath = txtImageStampPath.Text
        My.Settings.certLevel = certLevel
        My.Settings.hash = hash
        My.Settings.mode = mode
        My.Settings.tsServer = txtTSServer.Text
        My.Settings.tsUser = txtTSUser.Text
        My.Settings.tsPassword = txtTSPassword.Text
        My.Settings.signerName = txtSignerName.Text
        My.Settings.reason = txtReason.Text
        My.Settings.location = txtLocation.Text
        My.Settings.contact = txtContactInfo.Text
        My.Settings.validMark = chkValidationMark.Checked
        My.Settings.linearize = chkLinearize.Checked
    End Sub

    Private Sub optCertLevelNone_CheckedChanged(sender As Object, e As EventArgs) Handles optCertLevelNone.CheckedChanged
        certLevel = PdfSignatureCertificationLevel.NotCertified
    End Sub

    Private Sub optCertLevelNoChanges_CheckedChanged(sender As Object, e As EventArgs) Handles optCertLevelNoChanges.CheckedChanged
        certLevel = PdfSignatureCertificationLevel.NoChanges
    End Sub

    Private Sub optCertLevelFormFill_CheckedChanged(sender As Object, e As EventArgs) Handles optCertLevelFormFill.CheckedChanged
        certLevel = PdfSignatureCertificationLevel.FormFilling
    End Sub

    Private Sub optCertLevelFormFillAnnot_CheckedChanged(sender As Object, e As EventArgs) Handles optCertLevelFormFillAnnot.CheckedChanged
        certLevel = PdfSignatureCertificationLevel.FormFillingAndAnnotations
    End Sub

    Private Sub optHash256_CheckedChanged(sender As Object, e As EventArgs) Handles optHash256.CheckedChanged
        hash = PdfSignatureHash.SHA256
    End Sub

    Private Sub optHash512_CheckedChanged(sender As Object, e As EventArgs) Handles optHash512.CheckedChanged
        hash = PdfSignatureHash.SHA512
    End Sub

    Private Sub optHash224_CheckedChanged(sender As Object, e As EventArgs) Handles optHash224.CheckedChanged
        hash = PdfSignatureHash.SHA224
    End Sub

    Private Sub optHash384_CheckedChanged(sender As Object, e As EventArgs) Handles optHash384.CheckedChanged
        hash = PdfSignatureHash.SHA384
    End Sub

    Private Sub optModePPKMS_CheckedChanged(sender As Object, e As EventArgs) Handles optModePPKMS.CheckedChanged
        mode = PdfSignatureMode.PdfSignatureModeAdobePPKMS
    End Sub

    Private Sub optModePPKLITE_CheckedChanged(sender As Object, e As EventArgs) Handles optModePPKLITE.CheckedChanged
        mode = PdfSignatureMode.PdfSignatureModeAdobePPKLite
    End Sub

    Private Sub optModeCADES_CheckedChanged(sender As Object, e As EventArgs) Handles optModeCADES.CheckedChanged
        mode = PdfSignatureMode.PdfSignatureModeAdobeCADES
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image | *.*"
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtImageStampPath.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Certificate | *.pfx"
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtCertPath.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GdViewer1.ZoomIN()
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GdViewer1.ZoomOUT()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "PDF | *.pdf"
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim status As GdPictureStatus = ChangeDocument(ofd.FileName)
                If status <> GdPictureStatus.OK Then
                    MessageBox.Show("The selected PDF document can't be loaded." + vbCrLf +
                                    "Status:  " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

    Private Function ChangeDocument(ByVal filepath As String) As GdPictureStatus
        Dim status As GdPictureStatus = GdPictureStatus.OK
        If _hasNativePdf Then
            _gdPicturePdf.CloseDocument()
            GdViewer1.CloseDocument()
        End If
        status = _gdPicturePdf.LoadFromFile(filepath, False)
        If status = GdPictureStatus.OK Then
            ' Set the document's current origin and units for all subsequent manipulations.
            _gdPicturePdf.SetMeasurementUnit(PdfMeasurementUnit.PdfMeasurementUnitPoint)
            _gdPicturePdf.SetOrigin(PdfOrigin.PdfOriginTopLeft)
            ' Display the loaded document.
            GdViewer1.DisplayFromGdPicturePDF(_gdPicturePdf)
            ' Initialize current settings.
            _hasNativePdf = True
            inputfilename = filepath
        Else
            _hasNativePdf = False
            inputfilename = ""
        End If
        Return status
    End Function
    Private Sub GdViewer1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseUp
        If GdViewer1.IsRect() Then

            ' Apply signature settings.

            ' Mandatory steps are step #1 and step #2 and the last step #5.

            ' Step 1 : Set the certificate, your digital ID file.
            Dim status As GdPictureStatus = _gdPicturePdf.SetSignatureCertificateFromP12(txtCertPath.Text, txtCertPass.Text)
            If status <> GdPictureStatus.OK Then
                MessageBox.Show("The error occurs while setting up the certificate." + vbCrLf +
                                "Status: " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                GoTo [error]
            End If

            ' Step 2 : Set the signature information. At least one parameter must be set, others may stay empty.
            status = _gdPicturePdf.SetSignatureInfo(txtSignerName.Text, txtReason.Text, txtLocation.Text, txtContactInfo.Text)
            If status <> GdPictureStatus.OK Then
                MessageBox.Show("The error occurs while setting up the signature information." + vbCrLf +
                                "Status: " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                GoTo [error]
            End If

            ' Optional steps.

            ' Step 3a : Set the signature's location on the current page. If this step is ommited, the signature will be invisble.

            ' Get the coordinates of the rectangle where the signature is placed.
            Dim left, top, width, height As Integer
            GdViewer1.GetRectCoordinatesOnDocument(left, top, width, height)
            ' Set signature position - please be aware of the bottom left point of the signature rectangle.
            status = _gdPicturePdf.SetSignaturePos(left, top + height, width, height)
            If status <> GdPictureStatus.OK Then
                MessageBox.Show("The error occurs while setting up the signature position" + vbCrLf +
                                "Status: " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                GoTo [error]
            End If

            ' Step 3b : Set the text to be displayed within the signature's bounding box. The text will not be drawn if the signature is invisible.
            ' Now the text is automatically builded from the signature information settings.
            status = _gdPicturePdf.SetSignatureText("", "", 12, Color.Black, TextAlignment.TextAlignmentCenter, TextAlignment.TextAlignmentCenter, True)
            If status <> GdPictureStatus.OK Then
                MessageBox.Show("The error occurs while setting up the signature text." + vbCrLf +
                                "Status: " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Step 3c : Set the image to be displayed within the signature's bounding box. The image will not be drawn if the signature is invisible.
            Dim stampPath As String = txtImageStampPath.Text.Trim()
            If stampPath <> "" Then
                Using oGdPictureImaging As New GdPictureImaging
                    Dim imageId As Integer = oGdPictureImaging.CreateGdPictureImageFromFile(stampPath)
                    status = oGdPictureImaging.GetStat()
                    If status = GdPictureStatus.OK Then
                        Dim stampResName As String = _gdPicturePdf.AddImageFromGdPictureImage(imageId, False, False)
                        status = _gdPicturePdf.GetStat()
                        If status = GdPictureStatus.OK Then
                            status = _gdPicturePdf.SetSignatureStampImage(stampResName)
                            If status <> GdPictureStatus.OK Then
                                MessageBox.Show("The error occurs while setting up the signature image stamp." + vbCrLf +
                                                "Status: " + status.ToString() + vbCrLf + "No image stamp is set.", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MessageBox.Show("The error occurs while creating the image stamp." + vbCrLf +
                                            "Status: " + status.ToString() + vbCrLf + "No image stamp is set.", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                        oGdPictureImaging.ReleaseGdPictureImage(imageId)
                    Else
                        MessageBox.Show("The error occurs while creating the image stamp." + vbCrLf +
                                        "Status: " + status.ToString() + vbCrLf + "No image stamp is set.", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End If

            ' Step 3d : Set the icon that represents the validity of the signature.
            status = _gdPicturePdf.SetSignatureValidationMark(chkValidationMark.Checked)
            If status <> GdPictureStatus.OK Then
                MessageBox.Show("The error occurs while setting up the validation mark." + vbCrLf +
                                "Status: " + status.ToString() + vbCrLf + "No validation mark is set.", caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Step 4a : Set the signature certification level.
            status = _gdPicturePdf.SetSignatureCertificationLevel(certLevel)
            If status <> GdPictureStatus.OK Then
                MessageBox.Show("The error occurs while setting the certification level." + vbCrLf +
                                "Status: " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                GoTo [error]
            End If

            ' Step 4b : Set the hash algorithm.
            status = _gdPicturePdf.SetSignatureHash(hash)
            If status <> GdPictureStatus.OK Then
                MessageBox.Show("The error occurs while setting the hash." + vbCrLf +
                                "Status: " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                GoTo [error]
            End If

            ' Step 4c : Set the timestamp information.
            status = _gdPicturePdf.SetSignatureTimestampInfo(txtTSServer.Text, txtTSUser.Text, txtTSPassword.Text)
            If status <> GdPictureStatus.OK Then
                MessageBox.Show("The error occurs while setting the timestamp." + vbCrLf +
                                "Status: " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                GoTo [error]
            End If

            ' Step 5 : The last step - sign. This step must be the last one. All other optional steps may be done in any order.
            Dim outputfilename As String = inputfilename.Replace(".pdf", "_signed.pdf")
            status = _gdPicturePdf.ApplySignature(outputfilename, mode, chkLinearize.Checked)
            If status = GdPictureStatus.OK Then
                status = ChangeDocument(outputfilename)
                If status <> GdPictureStatus.OK Then
                    MessageBox.Show("The signed PDF document can't be loaded." + vbCrLf +
                                    "Status:  " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("The signature is not applied. Status: " + status.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
[error]:
            GdViewer1.ClearRect()
        End If
    End Sub
End Class
