Imports GdPicture14

Friend Class Document

    ReadOnly _gdPictureImaging As GdPictureImaging

    Public Property ImageId As Integer

    Public Sub New(ByVal gdPictureImaging As GdPictureImaging)
        _gdPictureImaging = gdPictureImaging
        ImageId = -1
    End Sub

    Public Function Load(ByVal filePath As String, ByVal pdfRasterizationResolution As Single) As Boolean
        'In case the document is a pdf, it is required to rasterize the page.
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

        Return True
    End Function

    Public ReadOnly Property IsOpen As Boolean
        Get
            Return (ImageId > 0)
        End Get
    End Property

    Public Sub Close()
        If ImageId <> 0 Then
            _gdPictureImaging.ReleaseGdPictureImage(ImageId)
            ImageId = 0
        End If
    End Sub

End Class
