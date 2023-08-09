using System.Drawing;
using GdPicture14;

namespace Ocr
{
    public class Document
    {
        /// <summary>
        /// The constructor initializes members to their default values.
        /// </summary>
        public Document(GdPictureImaging gdPictureImaging, GdPictureOCR gdPictureOcr)
        {
            _gdPictureImaging = gdPictureImaging;
            _gdPictureOcr = gdPictureOcr;
            ImageId = -1;
            _ocrResultId = "";
        }

        /// <summary>
        /// Load document loads the document.
        /// </summary>
        /// <param name="filePath">The path to the file to load.</param>        
        /// <param name="pdfRasterizationResolution">The resolution for the rasterization of the pdfs.</param>
        /// <returns>true of the load succeeds otherwise returns false.</returns>
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

            // Take into accourant the rotation information stored within the exif tags.

            GdPictureRotateFlipType rotateFlipType = _gdPictureImaging.TagGetExifRotation(ImageId);
            if (rotateFlipType != GdPictureRotateFlipType.GdPictureRotateNoneFlipNone)
            {
                _gdPictureImaging.Rotate(ImageId, (RotateFlipType)rotateFlipType);
                _gdPictureImaging.TagDeleteAll(ImageId);
            }

            return true;
        }

        /// <summary>
        /// Close closes the current document if one.
        /// </summary>
        public void Close()
        {
            DiscardOcrResult();
            if (ImageId != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(ImageId);
                ImageId = 0;
            }
        }

        /// <summary>
        /// DiscardOcrResult discards the current ocr result.
        /// </summary>
        public void DiscardOcrResult()
        {
            if (!string.IsNullOrWhiteSpace(_ocrResultId))
            {
                _gdPictureOcr.ReleaseOCRResult(_ocrResultId);
                _ocrResultId = "";
            }
        }

        /// <summary>
        /// The identifier for the current image.
        /// </summary>
        public int ImageId { get; private set; }

        /// <summary>
        /// The identifier for the ocr result.
        /// </summary>
        public string OcrResultId
        {
            get { return _ocrResultId; }
            set
            {
                DiscardOcrResult();
                _ocrResultId = value;
            }
        }

        /// <summary>
        /// The flag indicates whether a document is open or not.
        /// </summary>
        public bool IsOpen
        {
            get { return ImageId > 0; }
        }

        /// <summary>
        /// The flag indicates whether a document has been recognized or not.
        /// </summary>
        public bool HasOcr
        {
            get { return !string.IsNullOrWhiteSpace(_ocrResultId); }
        }

        /// <summary>
        /// The boxes surrounding the blocks.
        /// </summary>
        public Rectangle[] BlocksBoundingBoxes
        {
            get { return HasOcr ? Utilities.GetBlocksBoundingBoxes(_ocrResultId, _gdPictureOcr) : null; }
        }

        /// <summary>
        /// The boxes surrounding the paragraphs.
        /// </summary>
        public Rectangle[] ParagraphsBoundingBoxes
        {
            get { return HasOcr ? Utilities.GetParagraphsBoundingBoxes(_ocrResultId, _gdPictureOcr) : null; }
        }

        /// <summary>
        /// The boxes surrounding the text lines.
        /// </summary>
        public Rectangle[] TextLinesBoundingBoxes
        {
            get { return HasOcr ? Utilities.GetTextLinesBoundingBoxes(_ocrResultId, _gdPictureOcr) : null; }
        }

        /// <summary>
        /// The boxes surrounding the words.
        /// </summary>
        public Rectangle[] WordsBoundingBoxes
        {
            get { return HasOcr ? Utilities.GetWordsBoundingBoxes(_ocrResultId, _gdPictureOcr) : null; }
        }

        /// <summary>
        /// The boxes surrounding the characters.
        /// </summary>
        public Rectangle[] CharactersBoundingBoxes
        {
            get { return HasOcr ? Utilities.GetCharactersBoundingBoxesSimplified(_ocrResultId, _gdPictureOcr) : null; }
        }

        /// <summary>
        /// The last OCR result.
        /// </summary>
        public string OCRResult
        {
            get { return HasOcr ? _gdPictureOcr.GetOCRResultText(_ocrResultId) : null; }
        }

        /// <summary>
        /// GdPictureImaging instance.
        /// </summary>
        private readonly GdPictureImaging _gdPictureImaging;

        /// <summary>
        /// GdPictureOcr instance.
        /// </summary>
        private readonly GdPictureOCR _gdPictureOcr;

        /// <summary>
        /// The identifier for the ocr result.
        /// </summary>
        private string _ocrResultId;
    }
}
