using GdPicture14;


namespace Segmenter
{
    public sealed class Document
    {

        private readonly GdPictureImaging _gdPictureImaging;



        public int ImageId { get; private set; }


        public bool IsOpen
        {
            get { return ImageId > 0; }
        }

  

        public Document(GdPictureImaging gdPictureImaging)
        {
            _gdPictureImaging = gdPictureImaging;
        }


        public bool Load(string filePath, float pdfRasterizationResolution)
        {
            // In case the document is a pdf, it is required to rasterize the page.

            if (GdPictureDocumentUtilities.GetDocumentFormat(filePath) == GdPicture14.DocumentFormat.DocumentFormatPDF)
            {
                using (GdPicturePDF gdPicturePdf = new GdPicturePDF())
                {
                    if (gdPicturePdf.LoadFromFile(filePath, false) == GdPictureStatus.OK)
                    {
                        ImageId = gdPicturePdf.RenderPageToGdPictureImageEx(pdfRasterizationResolution, true);
                        gdPicturePdf.CloseDocument();
                    }
                }
            }
            else
            {
                ImageId = _gdPictureImaging.CreateGdPictureImageFromFile(filePath);
            }

            if (ImageId == 0)
            {
                return false;
            }

            return true;
        }



        public void Close()
        {
            if (ImageId != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(ImageId);
                ImageId = 0;
            }
        }
    }
}