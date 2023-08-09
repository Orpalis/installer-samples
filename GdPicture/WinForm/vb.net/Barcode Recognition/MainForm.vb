Option Strict On
Option Explicit On

Imports GdPicture14
Imports System.Collections.Generic
Imports GdPicture14.Annotations

Public Class MainForm

    Private _lastLoadedFilePath As String = ""


    Private Sub Form1_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager()
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
        pan1Dtypes.Visible = False
        Label7.Visible = False
    End Sub

    Private Sub Command2_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Command2.Click
        GdViewer1.ZoomIN()
    End Sub

    Private Sub Command3_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Command3.Click
        GdViewer1.ZoomOUT()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AutoDeskewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AutoDeskewToolStripMenuItem.Click
        gdPictureImaging.AutoDeskew(nativeImage)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Function SelectOneFileOpenDialog(ByVal owner As IWin32Window) As String
        Dim openFile As New OpenFileDialog

        If IsNothing(owner) Then
            openFile.ShowDialog()
        Else
            openFile.ShowDialog(owner)
        End If

        Return openFile.FileName
    End Function

    Private Sub RenderPdfPage(ByVal pageNo As Integer)
        If nativeImage <> 0 Then
            gdPictureImaging.ReleaseGdPictureImage(nativeImage)
            nativeImage = 0
        End If
        gdPicturePDF.SelectPage(pageNo)
        gdPicturePDF.SetForceRasterizerInterpolation(True)
        nativeImage = gdPicturePDF.RenderPageToGdPictureImageEx(CSng(Val(TextBox1.Text)), True)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim filePath As String = SelectOneFileOpenDialog(Me)

        If filePath <> "" Then
            LoadFile(filePath)
        End If
    End Sub

    Private Sub LoadFile(ByVal filePath As String)
        CloseCurrentImage()
        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer

        If GdPictureDocumentUtilities.GetDocumentFormat(filePath) = GdPicture14.DocumentFormat.DocumentFormatPDF Then

            If gdPicturePDF.LoadFromFile(filePath, False) = GdPictureStatus.OK Then
                docSourceType = DocumentType.DocumentTypePDF
                RenderPdfPage(1)
                _lastLoadedFilePath = filePath
            End If
        Else
            docSourceType = DocumentType.DocumentTypeBitmap
            nativeImage = gdPictureImaging.CreateGdPictureImageFromFile(filePath)
        End If

        If nativeImage <> 0 Then
            _lastLoadedFilePath = filePath
            GdViewer1.DisplayFromGdPictureImage(nativeImage)
            ShowImageInfo()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseToolStripMenuItem.Click
        CloseCurrentImage()
    End Sub

    Private Sub CloseCurrentImage()
        If nativeImage <> 0 Then
            gdPictureImaging.ReleaseGdPictureImage(nativeImage)
            GdViewer1.CloseDocument()
            nativeImage = 0
        End If
        If docSourceType = DocumentType.DocumentTypePDF Then
            gdPicturePDF.CloseDocument()
        End If
        docSourceType = DocumentType.DocumentTypeUnknown
    End Sub

    Private Sub RepairCharactersToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RepairCharactersToolStripMenuItem.Click
        SetROI()
        gdPictureImaging.FxBitonalDilate4(nativeImage)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub SetROI()
        Dim leftArea As Integer, topArea As Integer, widthArea As Integer, heightArea As Integer

        If GdViewer1.IsRect Then
            Call GdViewer1.GetRectCoordinatesOnDocument(leftArea, topArea, widthArea, heightArea)
            Call gdPictureImaging.SetROI(leftArea, topArea, widthArea, heightArea)
        Else
            gdPictureImaging.ResetROI()
            leftArea = 0
            topArea = 0
            widthArea = 0
            heightArea = 0
        End If
    End Sub



    Private Sub ToolStripMenuItem3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem3.Click
        SetROI()
        gdPictureImaging.FxBitonalErode4(nativeImage)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem4.Click
        SetROI()
        gdPictureImaging.FxBitonalRemoveIsolatedDots4(nativeImage)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem6.Click
        gdPictureImaging.Scale(nativeImage, 200, Drawing2D.InterpolationMode.HighQualityBicubic)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem7.Click
        gdPictureImaging.Scale(nativeImage, 300, Drawing2D.InterpolationMode.HighQualityBicubic)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub ShowImageInfo()
        If nativeImage <> 0 Then
            If docSourceType = DocumentType.DocumentTypePDF Then
                lbPage.Text = gdPicturePDF.GetCurrentPage.ToString + "/" + gdPicturePDF.GetPageCount.ToString
            Else
                lbPage.Text = GdViewer1.CurrentPage.ToString + "/" + GdViewer1.PageCount.ToString
            End If

            lbImageInfo.Text = "Bit depth: " & Str(gdPictureImaging.GetBitDepth(nativeImage)) & " DPI: " & Str(gdPictureImaging.GetVerticalResolution(nativeImage))
        Else
            lbPage.Text = "0 / 0"
            lbImageInfo.Text = ""
        End If

    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem5.Click
        gdPictureImaging.Scale(nativeImage, 150, Drawing2D.InterpolationMode.HighQualityBicubic)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub


    Private Sub ToolStripMenuItem10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem10.Click
        gdPictureImaging.Scale(nativeImage, 75, Drawing2D.InterpolationMode.HighQualityBicubic)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem11.Click
        gdPictureImaging.Scale(nativeImage, 50, Drawing2D.InterpolationMode.HighQualityBicubic)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        SetROI()
        gdPictureImaging.FxBitonalFillHolesH(nativeImage)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles VerticalToolStripMenuItem.Click
        SetROI()
        gdPictureImaging.FxBitonalFillHolesV(nativeImage)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub DrawBoundingBox(color As Color, x1 As Integer, x2 As Integer, x3 As Integer, x4 As Integer, y1 As Integer, y2 As Integer, y3 As Integer, y4 As Integer)
        Dim points As PointF() = {
            New PointF(x1 / GdViewer1.HorizontalResolution, y1 / GdViewer1.VerticalResolution),
            New PointF(x2 / GdViewer1.HorizontalResolution, y2 / GdViewer1.VerticalResolution),
            New PointF(x3 / GdViewer1.HorizontalResolution, y3 / GdViewer1.VerticalResolution),
            New PointF(x4 / GdViewer1.HorizontalResolution, y4 / GdViewer1.VerticalResolution),
            New PointF(x1 / GdViewer1.HorizontalResolution, y1 / GdViewer1.VerticalResolution)
        }

        Dim annotation As AnnotationConnectedLines = GdViewer1.GetAnnotationManager().AddConnectedLinesAnnot(color, points)
        annotation.BorderWidth = 5 / GdViewer1.HorizontalResolution
        annotation.Tag = "##barcode##"
        annotation.CanEdit = False
        annotation.CanMove = False
        annotation.CanResize = False
        annotation.CanRotate = False
        annotation.CanSelect = False
        GdViewer1.GetAnnotationManager().SaveAnnotationsToPage()
    End Sub

    Private Sub ClearBoundingBoxes()
        Dim i As Integer = GdViewer1.GetAnnotationCount()
        While i > 0
            Dim annotation As Annotation = GdViewer1.GetAnnotationFromIdx(i - 1)
            If annotation.Tag = "##barcode##" Then
                GdViewer1.DeleteAnnotation(i - 1)
            End If
            i -= 1
        End While
        GdViewer1.SaveAnnotationsToPage()
    End Sub

    Private Sub Recognition()
        If Not chkDetect1D.Checked And Not chkDetectDataMatrix.Checked And Not chkDetectQRCode.Checked And Not chkDetectPDF417.Checked And Not chkDetectMicroQRCode.Checked And Not chkDetectAztec.Checked And Not chkDetectMaxicode.Checked And Not chkDetectPathCode.Checked Then
            MessageBox.Show("Please select a barcode symbology to detect")
            Return
        End If

        Dim barcode1DResults As List(Of SingleBarcodeInfo) = New List(Of SingleBarcodeInfo)
        Dim barcode2DResults As List(Of SingleBarcodeInfo) = New List(Of SingleBarcodeInfo)
        Dim barcodeQrResults As List(Of SingleBarcodeInfo) = New List(Of SingleBarcodeInfo)
        Dim barcodePdf417Results As List(Of SingleBarcodeInfo) = New List(Of SingleBarcodeInfo)
        Dim barcodeMicroQrResults As List(Of SingleBarcodeInfo) = New List(Of SingleBarcodeInfo)
        Dim barcodeAztecResults As List(Of SingleBarcodeInfo) = New List(Of SingleBarcodeInfo)
        Dim barcodeMaxicodeResults As List(Of SingleBarcodeInfo) = New List(Of SingleBarcodeInfo)
        Dim patchCodeResults As List(Of SingleBarcodeInfo) = New List(Of SingleBarcodeInfo)

        Dim bccount As Integer = 0
        Dim pccount As Integer = 0
        Dim leftArea As Integer, topArea As Integer, widthArea As Integer, heightArea As Integer
        Dim bcfound As Integer
        Dim expectedCount As Integer = CInt(Me.nupBcCount.Value)


        If GdViewer1.IsRect Then
            Call GdViewer1.GetRectCoordinatesOnDocument(leftArea, topArea, widthArea, heightArea)
            Call gdPictureImaging.SetROI(leftArea, topArea, widthArea, heightArea)
        Else
            gdPictureImaging.ResetROI()
            leftArea = 0
            topArea = 0
            widthArea = 0
            heightArea = 0
        End If

        ClearBoundingBoxes()

        If chkDetect1D.Checked Then
            Dim barcodeTypes As Barcode1DReaderType

            If chkIndustrial2of5.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderIndustrial2of5
            If chkInverted2of5.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderInverted2of5
            If chkInterleaved2of5.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderInterleaved2of5
            If chkIata2of5.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderIata2of5
            If chkMatrix2of5.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderMatrix2of5

            If chkCode39.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderCode39
            If chkCodeabar.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderCodeabar
            If chkBcdMatrix.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderBcdMatrix
            If chkDataLogic2of5.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderDataLogic2of5
            If chkCode128.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderCode128

            If chkCODE93.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderCODE93
            If chkEAN13.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderEAN13
            If chkUPCA.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderUPCA
            If chkEAN8.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderEAN8

            If chkUPCE.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderUPCE
            If chkAdd5.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderADD5
            If chkAdd2.Checked Then barcodeTypes = barcodeTypes Or Barcode1DReaderType.Barcode1DReaderADD2

            Dim scanMode As Barcode1DReaderScanMode
            If chkHQDetection.Checked Then
                scanMode = Barcode1DReaderScanMode.BestQuality
            Else
                scanMode = Barcode1DReaderScanMode.BestSpeed
            End If
            gdPictureImaging.Barcode1DReaderDoScan(nativeImage, scanMode, barcodeTypes, False, expectedCount)

            bcfound = gdPictureImaging.Barcode1DReaderGetBarcodeCount

            If bcfound > 0 Then
                For i As Integer = 1 To gdPictureImaging.Barcode1DReaderGetBarcodeCount
                    bccount += 1
                    Dim singleBarcodeInfo As New SingleBarcodeInfo()
                    singleBarcodeInfo.BarcodeNumber.Text = i.ToString() & " / " & gdPictureImaging.Barcode1DReaderGetBarcodeCount.ToString()
                    singleBarcodeInfo.Info.Text += "------------------------------------------------" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Type: " & gdPictureImaging.Barcode1DReaderGetBarcodeType(i).ToString + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Value: " & gdPictureImaging.Barcode1DReaderGetBarcodeValue(i) + vbCrLf
                    singleBarcodeInfo.Info.Text += "Checksum: " & gdPictureImaging.Barcode1DReaderBarcodeHasChecksum(i).ToString + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Angle: " & Str(gdPictureImaging.Barcode1DReaderGetBarcodeSkewAngle(i)) + vbCrLf + vbCrLf

                    barcode1DResults.Add(singleBarcodeInfo)
                Next
                expectedCount -= bcfound
            End If

            If CheckBox1.Checked = False Then 'Drawing bounding boxes
                Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
                GdViewer1.LockViewer = True
                For i As Integer = 1 To gdPictureImaging.Barcode1DReaderGetBarcodeCount
                    x1 = gdPictureImaging.Barcode1DReaderGetBarcodeX1(i) + leftArea
                    x2 = gdPictureImaging.Barcode1DReaderGetBarcodeX2(i) + leftArea
                    x3 = gdPictureImaging.Barcode1DReaderGetBarcodeX3(i) + leftArea
                    x4 = gdPictureImaging.Barcode1DReaderGetBarcodeX4(i) + leftArea

                    y1 = gdPictureImaging.Barcode1DReaderGetBarcodeY1(i) + topArea
                    y2 = gdPictureImaging.Barcode1DReaderGetBarcodeY2(i) + topArea
                    y3 = gdPictureImaging.Barcode1DReaderGetBarcodeY3(i) + topArea
                    y4 = gdPictureImaging.Barcode1DReaderGetBarcodeY4(i) + topArea

                    DrawBoundingBox(Color.Red, x1, x2, x3, x4, y1, y2, y3, y4)
                Next
                GdViewer1.LockViewer = False
                GdViewer1.Redraw()
            End If
            gdPictureImaging.Barcode1DReaderClear()
        End If

        If chkDetectDataMatrix.Checked Then
            Dim scanMode As BarcodeDataMatrixReaderScanMode
            If chkHQDetection.Checked Then
                scanMode = BarcodeDataMatrixReaderScanMode.BestQuality
            Else
                scanMode = BarcodeDataMatrixReaderScanMode.BestSpeed
            End If
            gdPictureImaging.BarcodeDataMatrixReaderDoScan(nativeImage, scanMode, expectedCount)

            bcfound = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount
            If bcfound > 0 Then
                For i As Integer = 1 To gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount
                    bccount += 1
                    Dim singleBarcodeInfo As New SingleBarcodeInfo()
                    singleBarcodeInfo.BarcodeNumber.Text = i.ToString() & " / " & gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount.ToString()
                    singleBarcodeInfo.Info.Text += "------------------------------------------------" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Type: 2D - Datamatrix" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Rows: " & gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeRows(i).ToString() + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Columns: " & gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeColumns(i).ToString() + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Value: " & gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeValue(i) + vbCrLf + vbCrLf

                    barcode2DResults.Add(singleBarcodeInfo)
                Next
                expectedCount -= bcfound
            End If

            If CheckBox1.Checked = False Then 'Drawing bounding boxes
                Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
                GdViewer1.LockViewer = True
                For i As Integer = 1 To gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount
                    x1 = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX1(i) + leftArea
                    x2 = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX2(i) + leftArea
                    x3 = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX3(i) + leftArea
                    x4 = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX4(i) + leftArea

                    y1 = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY1(i) + topArea
                    y2 = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY2(i) + topArea
                    y3 = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY3(i) + topArea
                    y4 = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY4(i) + topArea

                    DrawBoundingBox(Color.Blue, x1, x2, x3, x4, y1, y2, y3, y4)
                Next
                GdViewer1.LockViewer = False
                GdViewer1.Redraw()
            End If

            gdPictureImaging.BarcodeDataMatrixReaderClear()
        End If

        If chkDetectQRCode.Checked Then
            Dim scanMode As BarcodeQRReaderScanMode
            If chkHQDetection.Checked Then
                scanMode = BarcodeQRReaderScanMode.BestQuality
            Else
                scanMode = BarcodeQRReaderScanMode.BestSpeed
            End If
            gdPictureImaging.BarcodeQRReaderDoScan(nativeImage, scanMode, expectedCount)

            bcfound = gdPictureImaging.BarcodeQRReaderGetBarcodeCount
            If bcfound > 0 Then
                For i As Integer = 1 To gdPictureImaging.BarcodeQRReaderGetBarcodeCount
                    bccount += 1
                    Dim singleBarcodeInfo As New SingleBarcodeInfo()
                    singleBarcodeInfo.BarcodeNumber.Text = i.ToString() & " / " & gdPictureImaging.BarcodeQRReaderGetBarcodeCount.ToString()
                    singleBarcodeInfo.Info.Text += "------------------------------------------------" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Type: 2D - qr" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Confidence: " & gdPictureImaging.BarcodeQRReaderGetBarcodeConfidence(i).ToString() + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Version: " & gdPictureImaging.BarcodeQRReaderGetVersion(i).ToString() + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Value: " & gdPictureImaging.BarcodeQRReaderGetBarcodeValue(i) + vbCrLf + vbCrLf

                    barcodeQrResults.Add(singleBarcodeInfo)
                Next
            End If

            If CheckBox1.Checked = False Then 'Drawing bounding boxes
                Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
                GdViewer1.LockViewer = True
                For i As Integer = 1 To gdPictureImaging.BarcodeQRReaderGetBarcodeCount
                    x1 = gdPictureImaging.BarcodeQRReaderGetBarcodeX1(i) + leftArea
                    x2 = gdPictureImaging.BarcodeQRReaderGetBarcodeX2(i) + leftArea
                    x3 = gdPictureImaging.BarcodeQRReaderGetBarcodeX3(i) + leftArea
                    x4 = gdPictureImaging.BarcodeQRReaderGetBarcodeX4(i) + leftArea

                    y1 = gdPictureImaging.BarcodeQRReaderGetBarcodeY1(i) + topArea
                    y2 = gdPictureImaging.BarcodeQRReaderGetBarcodeY2(i) + topArea
                    y3 = gdPictureImaging.BarcodeQRReaderGetBarcodeY3(i) + topArea
                    y4 = gdPictureImaging.BarcodeQRReaderGetBarcodeY4(i) + topArea

                    DrawBoundingBox(Color.Green, x1, x2, x3, x4, y1, y2, y3, y4)
                Next
                GdViewer1.LockViewer = False
                GdViewer1.Redraw()
            End If

            gdPictureImaging.BarcodeQRReaderClear()
        End If

        If chkDetectMicroQRCode.Checked Then
            Dim scanMode As BarcodeQRReaderScanMode
            If chkHQDetection.Checked Then
                scanMode = BarcodeQRReaderScanMode.BestQuality
            Else
                scanMode = BarcodeQRReaderScanMode.BestSpeed
            End If
            gdPictureImaging.BarcodeMicroQRReaderDoScan(nativeImage, scanMode, expectedCount)

            bcfound = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount
            If bcfound > 0 Then
                For i As Integer = 1 To gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount
                    bccount += 1
                    Dim singleBarcodeInfo As New SingleBarcodeInfo()
                    singleBarcodeInfo.BarcodeNumber.Text = i.ToString() & " / " & gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount.ToString()
                    singleBarcodeInfo.Info.Text += "------------------------------------------------" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Type: 2D - micro qr" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Confidence: " & gdPictureImaging.BarcodeMicroQRReaderGetBarcodeConfidence(i).ToString() + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Version: " & gdPictureImaging.BarcodeMicroQRReaderGetVersion(i).ToString() + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Value: " & gdPictureImaging.BarcodeMicroQRReaderGetBarcodeValue(i) + vbCrLf + vbCrLf

                    barcodeMicroQrResults.Add(singleBarcodeInfo)
                Next
            End If

            If CheckBox1.Checked = False Then 'Drawing bounding boxes
                Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
                GdViewer1.LockViewer = True
                For i As Integer = 1 To gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount
                    x1 = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX1(i) + leftArea
                    x2 = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX2(i) + leftArea
                    x3 = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX3(i) + leftArea
                    x4 = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX4(i) + leftArea

                    y1 = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY1(i) + topArea
                    y2 = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY2(i) + topArea
                    y3 = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY3(i) + topArea
                    y4 = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY4(i) + topArea

                    DrawBoundingBox(Color.Green, x1, x2, x3, x4, y1, y2, y3, y4)
                Next
                GdViewer1.LockViewer = False
                GdViewer1.Redraw()
            End If

            gdPictureImaging.BarcodeMicroQRReaderClear()
        End If

        If chkDetectPDF417.Checked Then
            Dim scanMode As BarcodePDF417ReaderScanMode
            If chkHQDetection.Checked Then
                scanMode = BarcodePDF417ReaderScanMode.BestQuality
            Else
                scanMode = BarcodePDF417ReaderScanMode.BestSpeed
            End If
            gdPictureImaging.BarcodePDF417ReaderDoScan(nativeImage, scanMode, expectedCount)

            bcfound = gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount
            If bcfound > 0 Then
                For i As Integer = 1 To gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount
                    bccount += 1
                    Dim singleBarcodeInfo As New SingleBarcodeInfo()
                    singleBarcodeInfo.BarcodeNumber.Text = i.ToString() & " / " & gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount.ToString()
                    singleBarcodeInfo.Info.Text += "------------------------------------------------" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Type: 2D - PDF417" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Rows: " & gdPictureImaging.BarcodePDF417ReaderGetBarcodeRows(i).ToString() + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Columns: " & gdPictureImaging.BarcodePDF417ReaderGetBarcodeColumns(i).ToString() + vbCrLf
                    singleBarcodeInfo.Info.Text += "Accuracy: " & gdPictureImaging.BarcodePDF417ReaderGetBarcodeConfidence(i).ToString() + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Value: " & gdPictureImaging.BarcodePDF417ReaderGetBarcodeValue(i) + vbCrLf + vbCrLf

                    barcodePdf417Results.Add(singleBarcodeInfo)
                Next
                expectedCount -= bcfound
            End If


            If CheckBox1.Checked = False Then 'Drawing bounding boxes
                Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
                GdViewer1.LockViewer = True
                For i As Integer = 1 To gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount
                    x1 = gdPictureImaging.BarcodePDF417ReaderGetBarcodeX1(i) + leftArea
                    x2 = gdPictureImaging.BarcodePDF417ReaderGetBarcodeX2(i) + leftArea
                    x3 = gdPictureImaging.BarcodePDF417ReaderGetBarcodeX3(i) + leftArea
                    x4 = gdPictureImaging.BarcodePDF417ReaderGetBarcodeX4(i) + leftArea

                    y1 = gdPictureImaging.BarcodePDF417ReaderGetBarcodeY1(i) + topArea
                    y2 = gdPictureImaging.BarcodePDF417ReaderGetBarcodeY2(i) + topArea
                    y3 = gdPictureImaging.BarcodePDF417ReaderGetBarcodeY3(i) + topArea
                    y4 = gdPictureImaging.BarcodePDF417ReaderGetBarcodeY4(i) + topArea

                    DrawBoundingBox(Color.Violet, x1, x2, x3, x4, y1, y2, y3, y4)
                Next
                GdViewer1.LockViewer = False
                GdViewer1.Redraw()
            End If

            gdPictureImaging.BarcodePDF417ReaderClear()
        End If

        If chkDetectAztec.Checked Then
            Dim scanMode As BarcodeAztecReaderScanMode
            If chkHQDetection.Checked Then
                scanMode = BarcodeAztecReaderScanMode.BestQuality
            Else
                scanMode = BarcodeAztecReaderScanMode.BestSpeed
            End If
            gdPictureImaging.BarcodeAztecReaderDoScan(nativeImage, scanMode, expectedCount)

            bcfound = gdPictureImaging.BarcodeAztecReaderGetBarcodeCount
            If bcfound > 0 Then
                For i As Integer = 1 To gdPictureImaging.BarcodeAztecReaderGetBarcodeCount
                    bccount += 1
                    Dim singleBarcodeInfo As New SingleBarcodeInfo()
                    singleBarcodeInfo.BarcodeNumber.Text = i.ToString() & " / " & gdPictureImaging.BarcodeAztecReaderGetBarcodeCount.ToString()
                    singleBarcodeInfo.Info.Text += "------------------------------------------------" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Type: 2D - Aztec" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Value: " & gdPictureImaging.BarcodeAztecReaderGetBarcodeValue(i) + vbCrLf + vbCrLf

                    barcodeAztecResults.Add(singleBarcodeInfo)
                Next
                expectedCount -= bcfound
            End If


            If CheckBox1.Checked = False Then 'Drawing bounding boxes
                Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
                GdViewer1.LockViewer = True
                For i As Integer = 1 To gdPictureImaging.BarcodeAztecReaderGetBarcodeCount
                    x1 = gdPictureImaging.BarcodeAztecReaderGetBarcodeX1(i) + leftArea
                    x2 = gdPictureImaging.BarcodeAztecReaderGetBarcodeX2(i) + leftArea
                    x3 = gdPictureImaging.BarcodeAztecReaderGetBarcodeX3(i) + leftArea
                    x4 = gdPictureImaging.BarcodeAztecReaderGetBarcodeX4(i) + leftArea

                    y1 = gdPictureImaging.BarcodeAztecReaderGetBarcodeY1(i) + topArea
                    y2 = gdPictureImaging.BarcodeAztecReaderGetBarcodeY2(i) + topArea
                    y3 = gdPictureImaging.BarcodeAztecReaderGetBarcodeY3(i) + topArea
                    y4 = gdPictureImaging.BarcodeAztecReaderGetBarcodeY4(i) + topArea

                    DrawBoundingBox(Color.OrangeRed, x1, x2, x3, x4, y1, y2, y3, y4)
                Next
                GdViewer1.LockViewer = False
                GdViewer1.Redraw()
            End If

            gdPictureImaging.BarcodeAztecReaderClear()
        End If

        If chkDetectMaxicode.Checked Then
            Dim scanMode As BarcodeMaxiCodeReaderScanMode
            If chkHQDetection.Checked Then
                scanMode = BarcodeMaxiCodeReaderScanMode.BestQuality
            Else
                scanMode = BarcodeMaxiCodeReaderScanMode.BestSpeed
            End If
            gdPictureImaging.BarcodeMaxiCodeReaderDoScan(nativeImage, scanMode, expectedCount)

            bcfound = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeCount
            If bcfound > 0 Then
                For i As Integer = 1 To gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeCount
                    bccount += 1
                    Dim singleBarcodeInfo As New SingleBarcodeInfo()
                    singleBarcodeInfo.BarcodeNumber.Text = i.ToString() & " / " & gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeCount.ToString()
                    singleBarcodeInfo.Info.Text += "------------------------------------------------" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Type: 2D - Aztec" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Barcode Value: " & gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeValue(i) + vbCrLf + vbCrLf

                    barcodeMaxicodeResults.Add(singleBarcodeInfo)
                Next
                expectedCount -= bcfound
            End If


            If CheckBox1.Checked = False Then 'Drawing bounding boxes
                Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
                GdViewer1.LockViewer = True
                For i As Integer = 1 To gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeCount
                    x1 = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX1(i) + leftArea
                    x2 = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX2(i) + leftArea
                    x3 = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX3(i) + leftArea
                    x4 = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX4(i) + leftArea

                    y1 = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY1(i) + topArea
                    y2 = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY2(i) + topArea
                    y3 = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY3(i) + topArea
                    y4 = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY4(i) + topArea

                    DrawBoundingBox(Color.OrangeRed, x1, x2, x3, x4, y1, y2, y3, y4)
                Next
                GdViewer1.LockViewer = False
                GdViewer1.Redraw()
            End If

            gdPictureImaging.BarcodeMaxiCodeReaderClear()
        End If

        If chkDetectPathCode.Checked Then
            gdPictureImaging.PatchCodeReaderDoScan(nativeImage)

            bcfound = gdPictureImaging.PatchCodeReaderGetCodeCount
            If bcfound > 0 Then
                For i As Integer = 1 To gdPictureImaging.PatchCodeReaderGetCodeCount
                    pccount += 1
                    Dim singleBarcodeInfo As New SingleBarcodeInfo()
                    singleBarcodeInfo.BarcodeNumber.Text = i.ToString() & " / " & gdPictureImaging.PatchCodeReaderGetCodeCount.ToString()
                    singleBarcodeInfo.Info.Text += "------------------------------------------------" + vbCrLf
                    singleBarcodeInfo.Info.Text += "Patchcode Type: " & gdPictureImaging.PatchCodeReaderGetCodeType(i).ToString + vbCrLf
                    singleBarcodeInfo.Info.Text += vbCrLf

                    patchCodeResults.Add(singleBarcodeInfo)
                Next
            End If


            If CheckBox1.Checked = False Then 'Drawing bounding boxes
                Dim x1, x2, x3, x4, y1, y2, y3, y4 As Integer
                GdViewer1.LockViewer = True
                For i As Integer = 1 To gdPictureImaging.PatchCodeReaderGetCodeCount
                    x1 = gdPictureImaging.PatchCodeReaderGetCodeX1(i) + leftArea
                    x2 = gdPictureImaging.PatchCodeReaderGetCodeX2(i) + leftArea
                    x3 = gdPictureImaging.PatchCodeReaderGetCodeX3(i) + leftArea
                    x4 = gdPictureImaging.PatchCodeReaderGetCodeX4(i) + leftArea

                    y1 = gdPictureImaging.PatchCodeReaderGetCodeY1(i) + topArea
                    y2 = gdPictureImaging.PatchCodeReaderGetCodeY2(i) + topArea
                    y3 = gdPictureImaging.PatchCodeReaderGetCodeY3(i) + topArea
                    y4 = gdPictureImaging.PatchCodeReaderGetCodeY4(i) + topArea

                    DrawBoundingBox(Color.Orange, x1, x2, x3, x4, y1, y2, y3, y4)
                Next
                GdViewer1.LockViewer = False
                GdViewer1.Redraw()
            End If

            gdPictureImaging.PatchCodeReaderClear()
        End If

        If pccount > 0 Or bccount > 0 Then
            Dim barcodeResults As New BarcodeResults(barcode1DResults, barcode2DResults, barcodeQrResults, barcodePdf417Results, barcodeMicroQrResults, barcodeAztecResults, barcodeMaxicodeResults, patchCodeResults)
            barcodeResults.Show()
        Else
            MessageBox.Show("No barcodes were detected!")
        End If
        GdViewer1.Redraw()
        ShowImageInfo()

    End Sub

    Private Sub GdViewer1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseUp
        If GdViewer1.IsRect Then
            Recognition()
            GdViewer1.ClearRect()
        End If

    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StartToolStripMenuItem.Click
        Recognition()
    End Sub

    Private Sub MedianToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MedianToolStripMenuItem.Click
        gdPictureImaging.FxMedian(nativeImage, 1)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub


    Private Sub SmoothToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SmoothToolStripMenuItem.Click
        gdPictureImaging.FxSmooth(nativeImage)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub chkDetect1D_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDetect1D.CheckedChanged
        pan1Dtypes.Visible = chkDetect1D.Checked
        Label7.Visible = pan1Dtypes.Visible
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If docSourceType = DocumentType.DocumentTypePDF Then 'special case for PDF
            RenderPdfPage(gdPicturePDF.GetCurrentPage + 1)
            GdViewer1.DisplayFromGdPictureImage(nativeImage)
        Else
            GdViewer1.DisplayNextPage()
        End If
        ShowImageInfo()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If docSourceType = DocumentType.DocumentTypePDF Then 'special case for PDF
            RenderPdfPage(gdPicturePDF.GetCurrentPage - 1)
            GdViewer1.DisplayFromGdPictureImage(nativeImage)
        Else
            GdViewer1.DisplayPreviousPage()
        End If
        ShowImageInfo()
    End Sub

    Private Sub Rotate90DegToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Rotate90DegToolStripMenuItem.Click
        gdPictureImaging.Rotate(nativeImage, RotateFlipType.Rotate90FlipNone)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub RemoveVerticalLinesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveVerticalLinesToolStripMenuItem.Click
        gdPictureImaging.RemoveLines(nativeImage, LineRemoveOrientation.Vertical)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub RemoveHorizontalLinesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveHorizontalLinesToolStripMenuItem.Click
        gdPictureImaging.RemoveLines(nativeImage, LineRemoveOrientation.Horizontal)
        GdViewer1.Redraw()
        ShowImageInfo()
    End Sub

    Private Sub ThresholdToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ThresholdToolStripMenuItem.Click
        If gdPictureImaging.GetBitDepth(nativeImage) = 1 Then
            MessageBox.Show("Image is already bitonal")
            Return
        End If
        If nativeImage <> 0 Then
            Dim binarizationDialog As New Thresholder(Me)
            If binarizationDialog.ShowDialog() = DialogResult.OK Then
                ShowImageInfo()
            End If
        End If
    End Sub

    Private Sub ReloadLastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadLastToolStripMenuItem.Click
        If Not String.IsNullOrWhiteSpace(_lastLoadedFilePath) Then
            LoadFile(_lastLoadedFilePath)
        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        If Globals.nativeImage = 0 Then
            Return
        End If
        If gdPictureImaging.GetBitDepth(nativeImage) <> 1 Then
            MessageBox.Show("Image needs to be binarized first")
            Return
        End If
        Using despeckle As New Despeckle(GdViewer1)
            despeckle.ShowDialog(Me)
        End Using
    End Sub

End Class