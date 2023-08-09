Imports GdPicture14

Namespace Ocr

    Public Class Document

        Public Sub New(ByVal gdPictureImaging As GdPictureImaging, ByVal gdPictureOcr As GdPictureOCR)
            _gdPictureImaging = gdPictureImaging
            _gdPictureOcr = gdPictureOcr
            ImageId = -1
            _ocrResultId = ""
        End Sub

        Public Function Load(ByVal filePath As String, ByVal detectOrientation As Boolean, ByVal deskew As Boolean, ByVal pdfRasterizationResolution As Single) As Boolean
            If GdPictureDocumentUtilities.GetDocumentFormat(filePath) = GdPicture14.DocumentFormat.DocumentFormatPDF Then
                Using gdPicturePdf As GdPicturePDF = New GdPicturePDF()
                    If gdPicturePdf.LoadFromFile(filePath, False) = GdPictureStatus.OK Then
                        ImageId = gdPicturePdf.RenderPageToGdPictureImageEx(pdfRasterizationResolution, True)
                        gdPicturePdf.CloseDocument()
                    End If
                End Using
            Else
                ImageId = _gdPictureImaging.CreateGdPictureImageFromFile(filePath)
            End If

            If ImageId = 0 Then
                Return False
            End If

            Dim rotateFlipType As GdPictureRotateFlipType = _gdPictureImaging.TagGetExifRotation(ImageId)
            If rotateFlipType <> GdPictureRotateFlipType.GdPictureRotateNoneFlipNone Then
                _gdPictureImaging.Rotate(ImageId, CType(rotateFlipType, RotateFlipType))
                _gdPictureImaging.TagDeleteAll(ImageId)
            End If

            If detectOrientation Then
                _gdPictureOcr.SetImage(ImageId)
                Dim orientationAngle As Integer = _gdPictureOcr.GetOrientation()
                If orientationAngle <> 0 Then
                    Dim correctOrientationAngle As Integer = 360 - orientationAngle
                    _gdPictureImaging.RotateAngle(ImageId, CSng(correctOrientationAngle))
                End If
            End If

            If deskew Then
                _gdPictureImaging.AutoDeskew(ImageId)
            End If

            Return True
        End Function

        Public Sub Close()
            DiscardOcrResult()
            If ImageId <> 0 Then
                _gdPictureImaging.ReleaseGdPictureImage(ImageId)
                ImageId = 0
            End If
        End Sub

        Public Sub DiscardOcrResult()
            If Not String.IsNullOrWhiteSpace(_ocrResultId) Then
                _gdPictureOcr.ReleaseOCRResult(_ocrResultId)
                _ocrResultId = ""
            End If
        End Sub

        Public Property ImageId As Integer

        Public Property OcrResultId As String
            Get
                Return _ocrResultId
            End Get

            Set(ByVal value As String)
                DiscardOcrResult()
                _ocrResultId = value
            End Set
        End Property

        Public Property IsOpen As Boolean
            Get
                Return ImageId > 0
            End Get
            Private Set(value As Boolean)
            End Set
        End Property

        Public Property HasOcr As Boolean
            Get
                Return Not String.IsNullOrWhiteSpace(_ocrResultId)
            End Get
            Private Set(value As Boolean)
            End Set
        End Property

        Public Property BlocksBoundingBoxes As Rectangle()
            Get
                Return If(HasOcr, Utilities.GetBlocksBoundingBoxes(_ocrResultId, _gdPictureOcr), Nothing)
            End Get
            Private Set(value As Rectangle())
            End Set
        End Property

        Public Property ParagraphsBoundingBoxes As Rectangle()
            Get
                Return If(HasOcr, Utilities.GetParagraphsBoundingBoxes(_ocrResultId, _gdPictureOcr), Nothing)
            End Get
            Private Set(value As Rectangle())
            End Set
        End Property

        Public Property TextLinesBoundingBoxes As Rectangle()
            Get
                Return If(HasOcr, Utilities.GetTextLinesBoundingBoxes(_ocrResultId, _gdPictureOcr), Nothing)
            End Get
            Private Set(value As Rectangle())
            End Set
        End Property

        Public Property WordsBoundingBoxes As Rectangle()
            Get
                Return If(HasOcr, Utilities.GetWordsBoundingBoxes(_ocrResultId, _gdPictureOcr), Nothing)
            End Get
            Private Set(value As Rectangle())
            End Set
        End Property

        Public Property CharactersBoundingBoxes As Rectangle()
            Get
                Return If(HasOcr, Utilities.GetCharactersBoundingBoxesSimplified(_ocrResultId, _gdPictureOcr), Nothing)
            End Get
            Private Set(value As Rectangle())
            End Set
        End Property

        Public Property OCRResult As String
            Get
                Return If(HasOcr, _gdPictureOcr.GetOCRResultText(_ocrResultId), Nothing)
            End Get
            Private Set(value As String)
            End Set
        End Property

        Private ReadOnly _gdPictureImaging As GdPictureImaging

        Private ReadOnly _gdPictureOcr As GdPictureOCR

        Private _ocrResultId As String
    End Class
End Namespace
