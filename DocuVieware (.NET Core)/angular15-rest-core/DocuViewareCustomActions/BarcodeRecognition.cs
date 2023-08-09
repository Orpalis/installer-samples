using GdPicture14.WEB;
using GdPicture14;
using Newtonsoft.Json;
using System.Drawing;

namespace angular15_rest_core.DocuViewareCustomActions
{
    /// <summary>
    /// This class is used to serialize and send the result of the recognition client side
    /// </summary>
    [Serializable]
    internal class BarcodeResult
    {
        public string Data { get; }
        public string Symbology { get; }
        public RectangleF Box { get; }

        public BarcodeResult(string symbology, string data, RectangleF box)
        {
            Symbology = symbology;
            Data = data;
            Box = box;
        }
    }
    /// <summary>
    /// This class is used to cast the incoming serialized parameters
    /// </summary>
    internal class BarcodeRecognitionActionParameters
    {
        public bool ReadLinear { get; }
        public bool ReadQrcode { get; }
        public bool ReadMicroQrcode { get; }
        public bool ReadDatamatrix { get; }
        public bool ReadPdf417 { get; }
        public bool ReadAztec { get; }

        public BarcodeRecognitionActionParameters(bool readLinear, bool readQrcode, bool readMicroQrcode, bool readDatamatrix, bool readPdf417, bool readAztec)
        {
            ReadLinear = readLinear;
            ReadQrcode = readQrcode;
            ReadMicroQrcode = readMicroQrcode;
            ReadDatamatrix = readDatamatrix;
            ReadPdf417 = readPdf417;
            ReadAztec = readAztec;
        }
    }

    internal static class BarcodeRecognitionDemo
    {
        /// <summary>
        /// Entry point for the custom action handler
        /// </summary>
        public static void HandleBarCodeRecognitionAction(CustomActionEventArgs e)
        {
            BarcodeRecognitionActionParameters readerParameters = JsonConvert.DeserializeObject<BarcodeRecognitionActionParameters>(e.args.ToString());
            if (readerParameters.ReadDatamatrix || readerParameters.ReadLinear || readerParameters.ReadMicroQrcode || readerParameters.ReadPdf417 || readerParameters.ReadQrcode || readerParameters.ReadAztec)
            {
                int imageId = 0;
                bool disposeImage = false;
                GdPictureStatus status;
                // First we need to know what kind of document we are dealing with
                switch (e.docuVieware.GetDocumentType())
                {
                    // If it is an image...
                    case DocumentType.DocumentTypeBitmap:
                        status = e.docuVieware.GetNativeImage(out imageId);
                        break;
                    // If it is a PDF document...
                    case DocumentType.DocumentTypePDF:
                        status = e.docuVieware.GetNativePDF(out GdPicturePDF gdPicturePdf);
                        if (status == GdPictureStatus.OK)
                        {
                            // ...we need to rasterize it to obtain an actual image
                            imageId = gdPicturePdf.RenderPageToGdPictureImageEx(200, false);
                            disposeImage = true;
                        }
                        break;
                    default:
                        status = GdPictureStatus.Aborted;
                        break;
                }
                if (status == GdPictureStatus.OK)
                {
                    // We can proceed with the barcode recognition...
                    List<BarcodeResult> result = BarcodeRecognition(imageId, readerParameters, disposeImage);
                    // ...and return the results
                    e.result = result;
                }
                else
                {
                    e.message = new DocuViewareMessage("Cannot obtain native image. Status is: " + status + ".", icon: DocuViewareMessageIcon.Error);
                }
            }
            else
            {
                e.message = new DocuViewareMessage("No barcode symbology has been selected.", icon: DocuViewareMessageIcon.Error);
            }
        }

        /// <summary>
        /// Based on the received parameters we are going to read the corresponding symbologies
        /// </summary>
        private static List<BarcodeResult> BarcodeRecognition(int imageId, BarcodeRecognitionActionParameters readerParameters, bool disposeImage)
        {
            List<BarcodeResult> result = new List<BarcodeResult>();
            using (GdPictureImaging gdPictureImaging = new GdPictureImaging())
            {
                float resolution = gdPictureImaging.GetHorizontalResolution(imageId);

                if (readerParameters.ReadMicroQrcode)
                {
                    ReadQrCode(imageId, gdPictureImaging, resolution, result);
                }
                if (readerParameters.ReadMicroQrcode)
                {
                    ReadMicroQrCode(imageId, gdPictureImaging, resolution, result);
                }
                if (readerParameters.ReadPdf417)
                {
                    ReadPdf417(imageId, gdPictureImaging, resolution, result);
                }
                if (readerParameters.ReadDatamatrix)
                {
                    ReadDatamatrix(imageId, gdPictureImaging, resolution, result);
                }
                if (readerParameters.ReadLinear)
                {
                    ReadLinear(imageId, gdPictureImaging, resolution, result);
                }
                if (readerParameters.ReadAztec)
                {
                    ReadAztec(imageId, gdPictureImaging, resolution, result);
                }

                if (disposeImage)
                {
                    gdPictureImaging.ReleaseGdPictureImage(imageId);
                }
            }
            return result;
        }

        /// <summary>
        /// This is the method to read linear barcode symbology (aka 1D)
        /// </summary>
        private static void ReadLinear(int imageId, GdPictureImaging gdPictureImaging, float resolution, ICollection<BarcodeResult> result)
        {
            if (gdPictureImaging.Barcode1DReaderDoScan(imageId, Barcode1DReaderScanMode.BestQuality, 0, true, 1) != GdPictureStatus.OK) return;
            int barcodeCount = gdPictureImaging.Barcode1DReaderGetBarcodeCount();
            if (barcodeCount > 0)
            {
                for (int i = 1; i <= barcodeCount; i++)
                {
                    RectangleF box = GetBarcodeBoxInches(resolution, gdPictureImaging.Barcode1DReaderGetBarcodeX1(i),
                        gdPictureImaging.Barcode1DReaderGetBarcodeY1(i),
                        gdPictureImaging.Barcode1DReaderGetBarcodeX2(i), gdPictureImaging.Barcode1DReaderGetBarcodeY2(i),
                        gdPictureImaging.Barcode1DReaderGetBarcodeX3(i), gdPictureImaging.Barcode1DReaderGetBarcodeY3(i),
                        gdPictureImaging.Barcode1DReaderGetBarcodeX4(i), gdPictureImaging.Barcode1DReaderGetBarcodeY4(i));
                    result.Add(new BarcodeResult(gdPictureImaging.Barcode1DReaderGetBarcodeType(i).ToString().Substring(15),
                        gdPictureImaging.Barcode1DReaderGetBarcodeValue(i), box));
                }
            }
            gdPictureImaging.Barcode1DReaderClear();
        }

        /// <summary>
        /// This is the method to read Datamatrix symbology
        /// </summary>
        private static void ReadDatamatrix(int imageId, GdPictureImaging gdPictureImaging, float resolution, ICollection<BarcodeResult> result)
        {
            if (gdPictureImaging.BarcodeDataMatrixReaderDoScan(imageId) != GdPictureStatus.OK) return;
            int barcodeCount = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount();
            if (barcodeCount > 0)
            {
                for (int i = 1; i <= barcodeCount; i++)
                {
                    RectangleF box = GetBarcodeBoxInches(resolution, gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX1(i),
                        gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY1(i),
                        gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX2(i),
                        gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY2(i),
                        gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX3(i),
                        gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY3(i),
                        gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX4(i),
                        gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY4(i));
                    result.Add(new BarcodeResult("DataMatrix", gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeValue(i), box));
                }
            }
            gdPictureImaging.BarcodeDataMatrixReaderClear();
        }

        /// <summary>
        /// This is the method to read PDF417 symbology
        /// </summary>
        private static void ReadPdf417(int imageId, GdPictureImaging gdPictureImaging, float resolution, ICollection<BarcodeResult> result)
        {
            if (gdPictureImaging.BarcodePDF417ReaderDoScan(imageId) != GdPictureStatus.OK) return;
            int barcodeCount = gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount();
            if (barcodeCount > 0)
            {
                for (int i = 1; i <= barcodeCount; i++)
                {
                    RectangleF box = GetBarcodeBoxInches(resolution, gdPictureImaging.BarcodePDF417ReaderGetBarcodeX1(i),
                        gdPictureImaging.BarcodePDF417ReaderGetBarcodeY1(i),
                        gdPictureImaging.BarcodePDF417ReaderGetBarcodeX2(i),
                        gdPictureImaging.BarcodePDF417ReaderGetBarcodeY2(i),
                        gdPictureImaging.BarcodePDF417ReaderGetBarcodeX3(i),
                        gdPictureImaging.BarcodePDF417ReaderGetBarcodeY3(i),
                        gdPictureImaging.BarcodePDF417ReaderGetBarcodeX4(i),
                        gdPictureImaging.BarcodePDF417ReaderGetBarcodeY4(i));
                    result.Add(new BarcodeResult("PDF417", gdPictureImaging.BarcodePDF417ReaderGetBarcodeValue(i), box));
                }
            }
            gdPictureImaging.BarcodePDF417ReaderClear();
        }

        /// <summary>
        /// This is the method to read Micro QR Code symbology
        /// </summary>
        private static void ReadMicroQrCode(int imageId, GdPictureImaging gdPictureImaging, float resolution, ICollection<BarcodeResult> result)
        {
            if (gdPictureImaging.BarcodeMicroQRReaderDoScan(imageId) != GdPictureStatus.OK) return;
            int barcodeCount = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount();
            if (barcodeCount > 0)
            {
                for (int i = 1; i <= barcodeCount; i++)
                {
                    RectangleF box = GetBarcodeBoxInches(resolution, gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX1(i),
                        gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY1(i),
                        gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX2(i),
                        gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY2(i),
                        gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX3(i),
                        gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY3(i),
                        gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX4(i),
                        gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY4(i));
                    result.Add(new BarcodeResult("Micro QrCode", gdPictureImaging.BarcodeMicroQRReaderGetBarcodeValue(i), box));
                }
            }
            gdPictureImaging.BarcodeMicroQRReaderClear();
        }

        /// <summary>
        /// This is the method to read QR Code symbology
        /// </summary>
        private static void ReadQrCode(int imageId, GdPictureImaging gdPictureImaging, float resolution, ICollection<BarcodeResult> result)
        {
            if (gdPictureImaging.BarcodeQRReaderDoScan(imageId) != GdPictureStatus.OK) return;
            int barcodeCount = gdPictureImaging.BarcodeQRReaderGetBarcodeCount();
            if (barcodeCount > 0)
            {
                for (int i = 1; i <= barcodeCount; i++)
                {
                    RectangleF box = GetBarcodeBoxInches(resolution, gdPictureImaging.BarcodeQRReaderGetBarcodeX1(i),
                        gdPictureImaging.BarcodeQRReaderGetBarcodeY1(i),
                        gdPictureImaging.BarcodeQRReaderGetBarcodeX2(i), gdPictureImaging.BarcodeQRReaderGetBarcodeY2(i),
                        gdPictureImaging.BarcodeQRReaderGetBarcodeX3(i), gdPictureImaging.BarcodeQRReaderGetBarcodeY3(i),
                        gdPictureImaging.BarcodeQRReaderGetBarcodeX4(i), gdPictureImaging.BarcodeQRReaderGetBarcodeY4(i));
                    result.Add(new BarcodeResult("QrCode", gdPictureImaging.BarcodeQRReaderGetBarcodeValue(i), box));
                }
            }
            gdPictureImaging.BarcodeQRReaderClear();
        }

        /// <summary>
        /// This is the method to read Aztec symbology
        /// </summary>
        private static void ReadAztec(int imageId, GdPictureImaging gdPictureImaging, float resolution, ICollection<BarcodeResult> result)
        {
            if (gdPictureImaging.BarcodeAztecReaderDoScan(imageId) != GdPictureStatus.OK) return;
            int barcodeCount = gdPictureImaging.BarcodeAztecReaderGetBarcodeCount();
            if (barcodeCount > 0)
            {
                for (int i = 1; i <= barcodeCount; i++)
                {
                    RectangleF box = GetBarcodeBoxInches(resolution, gdPictureImaging.BarcodeAztecReaderGetBarcodeX1(i),
                        gdPictureImaging.BarcodeAztecReaderGetBarcodeY1(i),
                        gdPictureImaging.BarcodeAztecReaderGetBarcodeX2(i),
                        gdPictureImaging.BarcodeAztecReaderGetBarcodeY2(i),
                        gdPictureImaging.BarcodeAztecReaderGetBarcodeX3(i),
                        gdPictureImaging.BarcodeAztecReaderGetBarcodeY3(i),
                        gdPictureImaging.BarcodeAztecReaderGetBarcodeX4(i),
                        gdPictureImaging.BarcodeAztecReaderGetBarcodeY4(i));
                    result.Add(new BarcodeResult("Aztec", gdPictureImaging.BarcodeAztecReaderGetBarcodeValue(i), box));
                }
            }
            gdPictureImaging.BarcodeAztecReaderClear();
        }

        private static RectangleF GetBarcodeBoxInches(float resolution, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            float left = Math.Min(Math.Min(Math.Min(x1, x2), x3), x4) / resolution;
            float top = Math.Min(Math.Min(Math.Min(y1, y2), y3), y4) / resolution;
            float right = Math.Max(Math.Max(Math.Max(x1, x2), x3), x4) / resolution;
            float bottom = Math.Max(Math.Max(Math.Max(y1, y2), y3), y4) / resolution;
            return new RectangleF(left, top, right - left, bottom - top);
        }
    }
}
