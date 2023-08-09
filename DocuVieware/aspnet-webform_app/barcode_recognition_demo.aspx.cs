using GdPicture14;
using GdPicture14.WEB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.UI.HtmlControls;

namespace DocuVieware_webform_app_demo
{
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

    internal class BarcodeRecognitionActionParameters
    {
        public bool ReadLinear { get; }
        public bool ReadQrCode { get; }
        public bool ReadMicroQrCode { get; }
        public bool ReadDatamatrix { get; }
        public bool ReadPdf417 { get; }
        public bool ReadAztec { get; }
        public bool ReadMaxiCode { get; set;}

        public BarcodeRecognitionActionParameters(bool readLinear, bool readQrCode, bool readMicroQrCode, bool readDatamatrix, bool readPdf417, bool readAztec, bool readMaxiCode)
        {
            ReadLinear = readLinear;
            ReadQrCode = readQrCode;
            ReadMicroQrCode = readMicroQrCode;
            ReadDatamatrix = readDatamatrix;
            ReadPdf417 = readPdf417;
            ReadAztec = readAztec;
            ReadMaxiCode = readMaxiCode;
        }
    }

    internal static class BarcodeUtilities
    {
        private static RectangleF GetBarcodeBoxInches(float resolution, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            float left = Math.Min(Math.Min(Math.Min(x1, x2), x3), x4) / resolution;
            float top = Math.Min(Math.Min(Math.Min(y1, y2), y3), y4) / resolution;
            float right = Math.Max(Math.Max(Math.Max(x1, x2), x3), x4) / resolution;
            float bottom = Math.Max(Math.Max(Math.Max(y1, y2), y3), y4) / resolution;

            return new RectangleF(left, top, right - left, bottom - top);
        }

        public static List<BarcodeResult> BarcodeRecognition(int imageId, BarcodeRecognitionActionParameters readerParameters, bool disposeImage)
        {
            List<BarcodeResult> result = new List<BarcodeResult>();

            using (GdPictureImaging gdPictureImaging = new GdPictureImaging())
            {
                float resolution = gdPictureImaging.GetHorizontalResolution(imageId);
                if (readerParameters.ReadQrCode)
                {
                    if (gdPictureImaging.BarcodeQRReaderDoScan(imageId) == GdPictureStatus.OK)
                    {
                        int barcodeCount = gdPictureImaging.BarcodeQRReaderGetBarcodeCount();
                        if (barcodeCount > 0)
                        {
                            for (int i = 1; i <= barcodeCount; i++)
                            {
                                RectangleF box = GetBarcodeBoxInches(resolution,
                                    gdPictureImaging.BarcodeQRReaderGetBarcodeX1(i), gdPictureImaging.BarcodeQRReaderGetBarcodeY1(i),
                                    gdPictureImaging.BarcodeQRReaderGetBarcodeX2(i), gdPictureImaging.BarcodeQRReaderGetBarcodeY2(i),
                                    gdPictureImaging.BarcodeQRReaderGetBarcodeX3(i), gdPictureImaging.BarcodeQRReaderGetBarcodeY3(i),
                                    gdPictureImaging.BarcodeQRReaderGetBarcodeX4(i), gdPictureImaging.BarcodeQRReaderGetBarcodeY4(i));
                                result.Add(new BarcodeResult("QrCode", gdPictureImaging.BarcodeQRReaderGetBarcodeValue(i), box));
                            }
                        }
                        gdPictureImaging.BarcodeQRReaderClear();
                    }
                }

                if (readerParameters.ReadMicroQrCode)
                {
                    if (gdPictureImaging.BarcodeMicroQRReaderDoScan(imageId) == GdPictureStatus.OK)
                    {
                        int barcodeCount = gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount();
                        if (barcodeCount > 0)
                        {
                            for (int i = 1; i <= barcodeCount; i++)
                            {
                                RectangleF box = GetBarcodeBoxInches(resolution,
                                    gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX1(i), gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY1(i),
                                    gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX2(i), gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY2(i),
                                    gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX3(i), gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY3(i),
                                    gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX4(i), gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY4(i));
                                result.Add(new BarcodeResult("Micro QrCode", gdPictureImaging.BarcodeMicroQRReaderGetBarcodeValue(i), box));
                            }
                        }
                        gdPictureImaging.BarcodeMicroQRReaderClear();
                    }
                }

                if (readerParameters.ReadPdf417)
                {
                    if (gdPictureImaging.BarcodePDF417ReaderDoScan(imageId) == GdPictureStatus.OK)
                    {
                        int barcodeCount = gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount();
                        if (barcodeCount > 0)
                        {
                            for (int i = 1; i <= barcodeCount; i++)
                            {
                                RectangleF box = GetBarcodeBoxInches(resolution,
                                    gdPictureImaging.BarcodePDF417ReaderGetBarcodeX1(i), gdPictureImaging.BarcodePDF417ReaderGetBarcodeY1(i),
                                    gdPictureImaging.BarcodePDF417ReaderGetBarcodeX2(i), gdPictureImaging.BarcodePDF417ReaderGetBarcodeY2(i),
                                    gdPictureImaging.BarcodePDF417ReaderGetBarcodeX3(i), gdPictureImaging.BarcodePDF417ReaderGetBarcodeY3(i),
                                    gdPictureImaging.BarcodePDF417ReaderGetBarcodeX4(i), gdPictureImaging.BarcodePDF417ReaderGetBarcodeY4(i));
                                result.Add(new BarcodeResult("PDF417", gdPictureImaging.BarcodePDF417ReaderGetBarcodeValue(i), box));
                            }
                        }
                        gdPictureImaging.BarcodePDF417ReaderClear();
                    }
                }

                if (readerParameters.ReadAztec)
                {
                    if (gdPictureImaging.BarcodeAztecReaderDoScan(imageId) == GdPictureStatus.OK)
                    {
                        int barcodeCount = gdPictureImaging.BarcodeAztecReaderGetBarcodeCount();
                        if (barcodeCount > 0)
                        {
                            for (int i = 1; i <= barcodeCount; i++)
                            {
                                RectangleF box = GetBarcodeBoxInches(resolution,
                                    gdPictureImaging.BarcodeAztecReaderGetBarcodeX1(i), gdPictureImaging.BarcodeAztecReaderGetBarcodeY1(i),
                                    gdPictureImaging.BarcodeAztecReaderGetBarcodeX2(i), gdPictureImaging.BarcodeAztecReaderGetBarcodeY2(i),
                                    gdPictureImaging.BarcodeAztecReaderGetBarcodeX3(i), gdPictureImaging.BarcodeAztecReaderGetBarcodeY3(i),
                                    gdPictureImaging.BarcodeAztecReaderGetBarcodeX4(i), gdPictureImaging.BarcodeAztecReaderGetBarcodeY4(i));
                                result.Add(new BarcodeResult("Aztec", gdPictureImaging.BarcodeAztecReaderGetBarcodeValue(i), box));
                            }
                        }
                        gdPictureImaging.BarcodeAztecReaderClear();
                    }
                }

                if (readerParameters.ReadDatamatrix)
                {
                    if (gdPictureImaging.BarcodeDataMatrixReaderDoScan(imageId) == GdPictureStatus.OK)
                    {
                        int barcodeCount = gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount();
                        if (barcodeCount > 0)
                        {
                            for (int i = 1; i <= barcodeCount; i++)
                            {
                                RectangleF box = GetBarcodeBoxInches(resolution,
                                    gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX1(i), gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY1(i),
                                    gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX2(i), gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY2(i),
                                    gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX3(i), gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY3(i),
                                    gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX4(i), gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY4(i));
                                result.Add(new BarcodeResult("Datamatrix", gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeValue(i), box));
                            }
                        }
                        gdPictureImaging.BarcodeDataMatrixReaderClear();
                    }
                }

                if (readerParameters.ReadLinear)
                {
                    if (gdPictureImaging.Barcode1DReaderDoScan(imageId) == GdPictureStatus.OK)
                    {
                        int barcodeCount = gdPictureImaging.Barcode1DReaderGetBarcodeCount();
                        if (barcodeCount > 0)
                        {
                            for (int i = 1; i <= barcodeCount; i++)
                            {
                                RectangleF box = GetBarcodeBoxInches(resolution,
                                    gdPictureImaging.Barcode1DReaderGetBarcodeX1(i), gdPictureImaging.Barcode1DReaderGetBarcodeY1(i),
                                    gdPictureImaging.Barcode1DReaderGetBarcodeX2(i), gdPictureImaging.Barcode1DReaderGetBarcodeY2(i),
                                    gdPictureImaging.Barcode1DReaderGetBarcodeX3(i), gdPictureImaging.Barcode1DReaderGetBarcodeY3(i),
                                    gdPictureImaging.Barcode1DReaderGetBarcodeX4(i), gdPictureImaging.Barcode1DReaderGetBarcodeY4(i));
                                result.Add(new BarcodeResult(gdPictureImaging.Barcode1DReaderGetBarcodeType(i).ToString().Substring(15), gdPictureImaging.Barcode1DReaderGetBarcodeValue(i), box));
                            }
                        }
                        gdPictureImaging.Barcode1DReaderClear();
                    }
                }
                if (readerParameters.ReadMaxiCode)
                {
                    if (gdPictureImaging.BarcodeMaxiCodeReaderDoScan(imageId) == GdPictureStatus.OK)
                    {
                        int barcodeCount = gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeCount();
                        if (barcodeCount > 0)
                        {
                            for (int i = 1; i <= barcodeCount; i++)
                            {
                                RectangleF box = GetBarcodeBoxInches(resolution,
                                    gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX1(i), gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY1(i),
                                    gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX2(i), gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY2(i),
                                    gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX3(i), gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY3(i),
                                    gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX4(i), gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY4(i));
                                result.Add(new BarcodeResult("MaxiCode", gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeValue(i), box));
                            }
                        }
                        gdPictureImaging.BarcodeMaxiCodeReaderClear();
                    }
                }
                if (disposeImage)
                {
                    gdPictureImaging.ReleaseGdPictureImage(imageId);
                }
            }
            return result;
        }
    }

    public partial class BarcodeRecognitionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DocuVieware1.Timeout = Global.SESSION_TIMEOUT;

            if (!IsPostBack)
            {
                GenerateAndRegisterCustomSnapIn();
            }
        }

        public static void HandleBarCodeRecognitionAction(CustomActionEventArgs e)
        {
            BarcodeRecognitionActionParameters readerParameters = JsonConvert.DeserializeObject<BarcodeRecognitionActionParameters>(e.args.ToString());
            if (readerParameters.ReadDatamatrix || readerParameters.ReadLinear || readerParameters.ReadMicroQrCode || readerParameters.ReadPdf417 || readerParameters.ReadQrCode)
            {
                int imageId = 0;
                bool disposeImage = false;
                GdPictureStatus status;
                DocumentType documentType = e.docuVieware.GetDocumentType();
                switch (documentType)
                {
                    case DocumentType.DocumentTypeBitmap:
                        status = e.docuVieware.GetNativeImage(out imageId);
                        break;
                    case DocumentType.DocumentTypePDF:
                        status = e.docuVieware.GetNativePDF(out GdPicturePDF gdpicturePdf);
                        if (status == GdPictureStatus.OK)
                        {
                            imageId = gdpicturePdf.RenderPageToGdPictureImageEx(200, false);
                            disposeImage = true;
                        }
                        break;
                    default:
                        status = GdPictureStatus.Aborted;
                        break;
                }

                if (status == GdPictureStatus.OK)
                {   /*detection part*/
                    List<BarcodeResult> result = BarcodeUtilities.BarcodeRecognition(imageId, readerParameters, disposeImage);
                    if (result.Count > 0)
                    {
                        e.result = result;
                    }
                    else
                    {
                        e.message = new DocuViewareMessage("No barcode found.", icon: DocuViewareMessageIcon.Information);
                    }
                }
                else
                {
                    e.message = new DocuViewareMessage("Can not obtain native image. Status is: " + status + ".", icon: DocuViewareMessageIcon.Error);
                }
            }
            else
            {
                e.message = new DocuViewareMessage("No barcode symbology has been selected.", icon: DocuViewareMessageIcon.Error);
            }
        }

        private void GenerateAndRegisterCustomSnapIn()
        {
            using (HtmlGenericControl icon = new HtmlGenericControl("svg"))
            {
                icon.Attributes["viewBox"] = "0 0 512 512";
                icon.InnerHtml = "<g><rect x=\"-0.486\" y=\"43.003\" width=\"215.955\" height=\"26.791\"/><path d=\"M166.746,113.327H-0.486v13.388h148.803C154.104,121.81,160.262,117.331,166.746,113.327z\"/><path d=\"M127.161,148.607H-0.486v58.568h99.232C103.923,185.477,113.766,165.579,127.161,148.607z\"/><path d=\"M94.767,249.188H-0.486v26.786h98.854C96.399,267.301,95.176,258.35,94.767,249.188z\"/><path d=\"M-0.486,366.025v51.078h218.544v-25.781c-21.829-4.112-42.014-12.899-59.466-25.298L-0.486,366.025L-0.486,366.025z\"/><rect x=\"-0.486\" y=\"454.57\" width=\"215.955\" height=\"18.616\"/><path d=\"M109.874,308.636H-0.486v18.423h121.003C116.555,321.197,112.999,315.041,109.874,308.636z\"/><path d=\"M244.299,393.931v113.743h12.512V393.575c-3.513,0.245-7.054,0.38-10.628,0.381C245.551,393.955,244.926,393.938,244.299,393.931z\"/><path d=\"M256.809,91.178V5.868h-12.512V90.82c0.629-0.007,1.254-0.024,1.884-0.024C249.754,90.797,253.298,90.933,256.809,91.178z\"/><path d=\"M482.917,75.128l2.883-0.001h25.408V46.828H485.8V21.413h-28.305v1.441v23.974h-22.528V21.413h-28.291v1.441v23.974v1.441v1.441v22.532h-22.541V49.711v-2.883V21.413H355.83v1.441v23.974v1.441v1.441v22.532v1.442v1.441v22.531h-22.527V75.126v-2.883V49.711v-2.883V21.413h-28.29v1.441v23.974v1.441v1.441v22.532v1.442v1.441v22.531h-13.709c5.682,1.775,11.218,3.879,16.593,6.284c7.887,3.527,15.417,7.708,22.523,12.475c4.413,2.959,8.659,6.146,12.728,9.539c4.448,3.71,8.686,7.666,12.683,11.856c4.092,4.289,7.931,8.818,11.5,13.561h13.922h2.883h25.425v-25.416h22.524v22.533v1.441v1.441v22.534h-25.408v1.441v26.857h28.291v-25.416h22.528h2.883h22.539h2.883h25.408V148.49H485.8h-2.883h-22.539v-22.532h22.539h2.883h25.408V97.66H485.8h-2.883h-22.539V75.128H482.917z\"/><polygon points=\"511.208,481.775 511.208,453.47 485.8,453.47 485.8,430.944 511.208,430.944 511.208,402.641 485.8,402.641 482.917,402.641 460.378,402.641 460.378,380.112 482.917,380.112 485.8,380.112 511.208,380.112 511.208,351.809 485.8,351.809 485.8,329.281 511.208,329.281 511.208,300.989 485.8,300.989 485.8,278.451 511.208,278.451 511.208,250.146 485.8,250.146 482.917,250.146 460.378,250.146 460.378,227.62 482.917,227.62 485.8,227.62 511.208,227.62 511.208,199.321 485.8,199.321 482.917,199.321 457.495,199.321 457.495,200.763 457.495,224.738 432.084,224.738 432.084,226.179 432.084,253.03 457.495,253.03 457.495,275.567 457.495,277.01 457.495,278.451 457.495,300.989 434.967,300.989 434.967,275.567 406.676,275.567 406.676,277.01 406.676,303.872 432.084,303.872 432.084,326.398 432.084,327.84 432.084,329.281 432.084,351.809 432.084,353.251 432.084,354.692 432.084,355.493 448.149,371.561 432.084,387.626 417.069,402.641 400.691,419.02 388.767,430.944 406.676,430.944 409.56,430.944 432.084,430.944 434.967,430.944 457.495,430.944 457.495,453.47 434.967,453.47 432.084,453.47 409.56,453.47 406.676,453.47 384.135,453.47 381.252,453.47 358.714,453.47 358.714,428.063 330.421,428.063 330.421,429.503 330.421,453.47 307.897,453.47 305.016,453.47 279.592,453.47 279.592,454.911 279.592,481.775 \"/><path d=\"M305.126,358.826l15.528,15.529c-12.67,7.176-26.473,12.568-41.063,15.867v12.417v1.441v1.441v25.421h28.306v-25.421h25.407v-18.519l-12.648-12.649L305.126,358.826c4.186-2.123,8.227-4.477,12.139-7.018c2.135-1.387,4.242-2.812,6.289-4.319l4.319,4.319l10.671,10.668l41.655,41.652l0.002-0.002l0.001,0.002l2.796-2.797l17.688-17.688l-0.002-0.002l8.872-8.869l6.019-6.02l0.002-0.002l-6.021-6.02l-10.926-10.923l-25.979-25.976c0,0,0,0,0-0.002l-15.202-15.199c3.855-6.275,7.195-12.899,9.965-19.816l-0.001-0.001c5.992-14.978,9.292-31.321,9.295-48.439c-0.007-38.612-16.768-73.295-43.406-97.19c-15.136-13.576-33.459-23.667-53.715-29.015c-7.357-1.943-14.972-3.26-22.779-3.891c-3.505-0.282-7.048-0.434-10.628-0.434c-0.63,0-1.255,0.014-1.884,0.024c-9.918,0.143-19.566,1.388-28.83,3.622c-10.493,2.53-20.488,6.327-29.82,11.221c-9.738,5.105-18.75,11.405-26.844,18.703c-1.156,1.042-2.294,2.105-3.413,3.189c-0.062,0.061-0.125,0.121-0.188,0.183c-16.286,15.833-28.454,35.879-34.743,58.385c-3.128,11.199-4.808,23.003-4.81,35.202c0,2.285,0.06,4.555,0.177,6.811c0.476,9.215,1.913,18.173,4.201,26.784c3.083,11.604,7.724,22.568,13.685,32.664c3.854,6.526,8.258,12.689,13.153,18.422c15.12,17.713,34.89,31.335,57.431,38.967c4.482,1.519,9.076,2.79,13.761,3.818c8.468,1.859,17.243,2.896,26.24,3.025c0.627,0.009,1.253,0.024,1.882,0.024c0,0,0,0,0.001,0c3.58,0,7.123-0.158,10.628-0.443c4.308-0.349,8.557-0.906,12.736-1.663c12.537-2.269,24.449-6.331,35.469-11.905C305.051,358.863,305.09,358.846,305.126,358.826z M209.086,327.059c-10.202-4.485-19.439-10.758-27.325-18.423c-9.4-9.139-16.861-20.25-21.721-32.662c-3.291-8.406-5.381-17.401-6.069-26.786c-0.166-2.251-0.278-4.517-0.278-6.811c0-12.46,2.493-24.344,6.978-35.202c10.001-24.206,29.986-43.259,54.797-52.022c9.053-3.198,18.746-5.014,28.831-5.217c0.628-0.013,1.252-0.048,1.884-0.048c3.597,0,7.139,0.229,10.628,0.629c46.002,5.29,81.859,44.454,81.86,91.86c0,13.688-3.015,26.678-8.376,38.375l1.09-1.09c-4.682,10.671-11.293,20.3-19.443,28.461c-8.159,8.145-17.791,14.757-28.455,19.438l1.091-1.089c-8.63,3.955-17.968,6.621-27.765,7.754c-3.489,0.404-7.034,0.625-10.629,0.625c-0.631,0-1.255-0.034-1.884-0.047C231.801,334.55,219.905,331.816,209.086,327.059z\"/><polygon points=\"257.029,281.569 257.029,250.622 287.973,250.622 287.973,235.232 286.53,235.232 257.029,235.232 257.029,204.289 256.809,204.289 244.299,204.289 241.636,204.289 241.636,235.232 210.693,235.232 210.693,249.188 210.693,250.622 218.059,250.622 241.636,250.622 241.636,281.569 244.299,281.569 256.809,281.569 \"/></g>";

                using (HtmlGenericControl barcodesSnapInContainer = new HtmlGenericControl("div"))
                {
                    barcodesSnapInContainer.ClientIDMode = System.Web.UI.ClientIDMode.Static;
                    barcodesSnapInContainer.ID = "barcodeRecognitionSnapIn" + DocuVieware1.UniqueID;
                    using (HtmlGenericControl symbologiesContainer = new HtmlGenericControl("div"))
                    {
                        symbologiesContainer.ID = "symbologiesContainer";
                        // Linear barcodes
                        using (HtmlGenericControl linearBarcodesContainer = new HtmlGenericControl("div"))
                        {
                            linearBarcodesContainer.ID = "linearBarcodesContainer" + DocuVieware1.UniqueID;
                            linearBarcodesContainer.Attributes["class"] = "symbology";
                            linearBarcodesContainer.Attributes["title"] = "Detect Linear Barcodes";

                            using (HtmlGenericControl linearBarcodesIconContainer = new HtmlGenericControl("div"))
                            {
                                linearBarcodesIconContainer.Attributes["class"] = "icon";
                                using (HtmlGenericControl linearBarcodesIcon = new HtmlGenericControl("svg"))
                                {
                                    linearBarcodesIcon.Attributes["viewBox"] = "0 0 512 512";
                                    linearBarcodesIcon.InnerHtml = "<path fill=\"#2D85C7\" d=\"M500.206,180.078c-3.114-10.014-6.827-19.764-11.098-29.209c-1.388-3.069-2.849-6.097-4.353-9.1 c-3.278-6.546-6.821-12.936-10.63-19.147c-0.896-1.461-1.798-2.919-2.723-4.361c-2.218-3.46-4.518-6.864-6.896-10.208 c-0.802-1.128-1.615-2.247-2.435-3.361c-0.202-0.275-0.408-0.547-0.611-0.821c-0.646-0.87-1.295-1.736-1.95-2.597 c-0.188-0.247-0.378-0.492-0.567-0.738c-0.721-0.939-1.447-1.873-2.181-2.802c-0.104-0.132-0.209-0.265-0.313-0.397 C409.588,38.231,337.16,0.316,255.871,0.316h0h0c-8.833,0-17.562,0.448-26.165,1.322c-3.567,0.362-7.107,0.815-10.63,1.323v0 c-6.792,0.979-13.498,2.222-20.106,3.722c-3.965,0.9-7.896,1.892-11.789,2.975c-3.579,0.995-7.123,2.071-10.636,3.216v0 c-3.57,1.163-7.105,2.401-10.604,3.715c-3.586,1.347-7.136,2.766-10.643,4.267v0c-11.041,4.726-21.686,10.198-31.863,16.367v0 c-3.602,2.184-7.148,4.452-10.631,6.806v0c-11.312,7.644-21.969,16.181-31.895,25.489v0c-7.526,7.058-14.625,14.563-21.253,22.478v0 c-3.69,4.406-7.232,8.939-10.624,13.59v0c-7.955,10.908-15.078,22.461-21.253,34.581v0c-3.927,7.707-7.466,15.643-10.611,23.775v0 c-6.555,16.955-11.37,34.776-14.193,53.254c-0.647,4.235-1.19,8.503-1.627,12.804c-0.437,4.3-0.767,8.632-0.988,12.993 c-0.221,4.36-0.333,8.75-0.333,13.166c0,32.515,6.08,63.605,17.141,92.217c3.145,8.133,6.684,16.069,10.611,23.775 c6.175,12.119,13.298,23.673,21.253,34.581c3.392,4.65,6.934,9.184,10.624,13.59c6.629,7.915,13.728,15.421,21.253,22.479 c9.926,9.308,20.583,17.845,31.895,25.489c3.483,2.354,7.029,4.622,10.631,6.806c10.177,6.169,20.822,11.642,31.863,16.367 c3.507,1.501,7.057,2.92,10.643,4.268c3.499,1.313,7.034,2.551,10.604,3.715c3.514,1.145,7.058,2.221,10.636,3.216 c10.381,2.887,21.028,5.13,31.895,6.696c3.522,0.507,7.062,0.96,10.63,1.322c8.603,0.874,17.333,1.322,26.166,1.322 c1.913,0,3.819-0.03,5.723-0.072c7.161-0.157,14.249-0.608,21.254-1.342c3.556-0.373,7.087-0.823,10.598-1.34 c7.194-1.059,14.291-2.415,21.277-4.06c3.568-0.84,7.11-1.75,10.619-2.738c10.946-3.081,21.591-6.882,31.89-11.331 c11.053-4.774,21.706-10.298,31.887-16.521c3.604-2.204,7.147-4.496,10.632-6.87c3.607-2.458,7.145-5.009,10.616-7.644 c7.405-5.619,14.498-11.629,21.241-18.005c3.654-3.455,7.202-7.02,10.647-10.683c11.984-12.743,22.68-26.71,31.871-41.702 c3.809-6.211,7.352-12.601,10.63-19.147c17.236-34.424,26.952-73.269,26.952-114.388 C511.708,229.664,507.682,204.111,500.206,180.078z M27.778,319.25V193.064c5.048-18.228,12.228-35.575,21.253-51.763v229.712 C40.006,354.825,32.826,337.478,27.778,319.25z M59.655,388.316V123.999c6.433-9.521,13.542-18.549,21.253-27.018v318.354 C73.196,406.865,66.088,397.837,59.655,388.316z M112.803,444.526V67.79c3.473-2.644,7.012-5.204,10.631-7.656v392.049 C119.815,449.729,116.276,447.17,112.803,444.526z M155.297,470.335V41.982c3.502-1.651,7.05-3.218,10.643-4.7v437.753 C162.347,473.553,158.799,471.986,155.297,470.335z M176.544,479.111V33.206c3.509-1.252,7.054-2.425,10.636-3.513v452.932 C183.598,481.536,180.053,480.363,176.544,479.111z M219.075,489.938V22.379c3.518-0.551,7.063-1.017,10.63-1.412V491.35 C226.138,490.956,222.593,490.49,219.075,489.938z M261.594,492.731V19.587c7.169,0.171,14.255,0.676,21.254,1.474v470.196 C275.849,492.055,268.763,492.56,261.594,492.731z M293.445,489.809V22.509c7.204,1.154,14.304,2.624,21.277,4.415v458.47 C307.749,487.186,300.649,488.654,293.445,489.809z M325.342,482.391V29.926c10.991,3.382,21.641,7.547,31.89,12.425v427.614 C346.982,474.844,336.333,479.009,325.342,482.391z M389.118,451.616V60.7c3.618,2.475,7.161,5.051,10.632,7.717v375.482 C396.279,446.565,392.736,449.142,389.118,451.616z M410.366,435.265V77.052c7.507,6.485,14.6,13.436,21.241,20.802v316.609 C424.966,421.829,417.873,428.78,410.366,435.265z M442.255,401.805V110.512c12.895,16.465,23.656,34.675,31.871,54.21v182.871 C465.911,367.129,455.149,385.339,442.255,401.805z M484.756,316.305V196.01c5.053,19.213,7.755,39.37,7.755,60.147 S489.809,297.091,484.756,316.305z\"/>";
                                    linearBarcodesIconContainer.Controls.Add(linearBarcodesIcon);
                                }
                                linearBarcodesContainer.Controls.Add(linearBarcodesIconContainer);
                            }
                            using (HtmlGenericControl linearBarcodesTitle = new HtmlGenericControl("span"))
                            {
                                linearBarcodesTitle.Attributes["class"] = "symbology_name";
                                linearBarcodesTitle.InnerHtml = "Linear Barcodes";
                                linearBarcodesContainer.Controls.Add(linearBarcodesTitle);
                            }
                            using (HtmlGenericControl linearBarcodesCheckboxContainer = new HtmlGenericControl("div"))
                            {
                                linearBarcodesCheckboxContainer.Attributes["class"] = "checkbox";
                                using (HtmlInputCheckBox linearBarcodesCheckbox = new HtmlInputCheckBox())
                                {
                                    linearBarcodesCheckbox.ID = "chk-linear";
                                    linearBarcodesCheckbox.Name = "linear";
                                    linearBarcodesCheckbox.Checked = true;
                                    linearBarcodesCheckboxContainer.Controls.Add(linearBarcodesCheckbox);
                                }
                                linearBarcodesContainer.Controls.Add(linearBarcodesCheckboxContainer);
                            }
                            symbologiesContainer.Controls.Add(linearBarcodesContainer);
                        }
                        // QR codes
                        using (HtmlGenericControl qrCodesContainer = new HtmlGenericControl("div"))
                        {
                            qrCodesContainer.ID = "QRCodesContainer" + DocuVieware1.UniqueID;
                            qrCodesContainer.Attributes["class"] = "symbology";
                            qrCodesContainer.Attributes["title"] = "Detect QR Codes";

                            using (HtmlGenericControl qrCodesIconContainer = new HtmlGenericControl("div"))
                            {
                                qrCodesIconContainer.Attributes["class"] = "icon";
                                using (HtmlGenericControl qrCodesIcon = new HtmlGenericControl("svg"))
                                {
                                    qrCodesIcon.Attributes["viewBox"] = "0 0 512 512";
                                    qrCodesIcon.InnerHtml = "<g> <rect x=\"203.842\" y=\"378.797\" fill=\"#2481C4\" width=\"0.002\" height=\"0.001\"/> <polygon fill=\"#2481C4\" points=\"298.243,359.835 317.137,359.818 317.137,378.699 336.029,378.699 336.011,359.806 335.98,340.912 317.118,340.924 298.243,340.948 279.35,340.96 279.355,359.842 \"/> <rect x=\"411.481\" y=\"284.206\" fill=\"#2481C4\" width=\"0.003\" height=\"0.006\"/> <polygon fill=\"#2481C4\" points=\"298.274,397.591 298.299,416.485 317.173,416.462 336.049,416.448 336.042,397.562 317.148,397.574 317.137,378.699 298.256,378.722 \"/> <polygon fill=\"#2481C4\" points=\"298.13,208.768 317.005,208.757 316.998,189.87 298.112,189.879 279.23,189.888 260.349,189.913 260.369,208.803 279.25,208.776 \"/> <path fill=\"#2481C4\" d=\"M411.538,359.738v-18.876l-18.894,0.013l-18.881,0.011l-18.895,0.013l0.023,18.881l0.024,18.896 l0.012,18.888l18.877-0.03l18.869-0.012l18.887-0.024l-0.012-18.869L411.538,359.738z M373.788,378.661l-0.019-18.894l18.881-0.012 l0.006,18.893L373.788,378.661z\"/> <polygon fill=\"#2481C4\" points=\"298.066,133.23 279.186,133.25 279.204,152.142 279.224,171.014 298.104,171.005 298.097,152.118 \"/> <polygon fill=\"#2481C4\" points=\"203.685,152.19 222.555,152.182 222.536,133.293 203.661,133.303 \"/> <polygon fill=\"#2481C4\" points=\"373.837,454.193 373.831,435.306 354.956,435.318 354.962,454.199 \"/> <polygon fill=\"#2481C4\" points=\"279.361,378.729 260.492,378.735 260.517,397.616 279.386,397.604 \"/> <rect x=\"354.955\" y=\"435.317\" fill=\"#2481C4\" width=\"0.001\" height=\"0.001\"/> <path fill=\"#2481C4\" d=\"M256,0C114.615,0,0,114.615,0,256s114.615,256,256,256c141.384,0,256-114.615,256-256S397.385,0,256,0z M486.962,204.224l0.005,4.4l-18.882,0.007l-0.03-18.879l15.188-0.015C484.63,194.505,485.871,199.336,486.962,204.224z M445.52,114.243l-15.276,0.013l-18.888,0.019l-0.023-18.89l-0.012-17.938C423.973,88.462,435.446,100.797,445.52,114.243z M392.431,62.61l0.013,13.896v18.887l0.031,18.894l0.012,18.867l18.881-0.004l18.881-0.027l18.876-0.01l9.162-0.005 c3.725,6.118,7.17,12.424,10.339,18.89l-0.61,0.001l-18.868,0.01l-18.868,0.016l-18.889,0.019l-18.88,0.012l-18.901,0.018v-18.881 l-0.013-18.875l-0.022-18.891l-0.025-18.89l-0.012-18.885l-0.003-7.102C380.033,54.275,386.337,58.304,392.431,62.61z M335.756,38.786l14.287-0.004c1.542,0.668,3.077,1.35,4.602,2.05l0.013,16.817l-18.889,0.024l0.024,18.887l-18.875,0.016 l-0.023-18.895l18.874-0.008L335.756,38.786z M316.865,27.258l0.013,11.556l-18.866,0.012l-0.017-15.768 C304.38,24.201,310.669,25.613,316.865,27.258z M298.03,57.699v18.884l-18.882,0.021l-0.019-18.887L298.03,57.699z M238.442,19.991 l2.895-0.001l18.894-0.019v18.882l-18.883,0.009v18.881l-18.881,0.006l0.024,18.894l-18.87,0.013l-0.025-18.891l-0.012-18.875 l-18.886,0.024l-0.011-8.628C201.844,24.871,219.843,21.355,238.442,19.991z M184.811,171.084l-0.012-18.869l-0.025-18.894 l-0.005-18.866l-0.019-18.891l-0.013-18.884l18.887-0.024l0.004,18.885l18.894-0.012l-0.03-18.887l18.875-0.027l18.888-0.006 l0.02,18.888l-18.878,0.012l0.013,18.89l-18.88,0.021l0.005,18.872l18.895-0.024l0.013,18.891l0.012,18.884l-18.881,0.025 l0.019,18.868l-18.881,0.013l-18.895,0.008l-18.881,0.019l-18.881,0.01l-0.019-18.873l18.889-0.009L184.811,171.084z M126.614,57.83l1.445,0l0.019,18.888l0.023,18.891l0.011,18.884l-18.886,0.003l-18.876,0.013l-18.875,0.027l-0.011-6.689 C87.08,88.421,105.695,71.516,126.614,57.83z M53.524,133.418l17.951-0.011l18.875-0.01l18.889-0.024l18.894-0.006l18.88-0.021 l-0.018-18.869l-0.019-18.894l-0.019-18.887V57.807l-0.007-11.884c6.139-3.193,12.436-6.122,18.875-8.778l0.002,1.783l0.013,18.875 l0.011,18.881l0.013,18.891l0.005,18.881l0.024,18.878l0.013,18.884l-18.888,0.009l-18.881,0.018l-18.881,0.012l-18.876,0.006 l-18.875,0.027l-18.894,0.009l-9.393,0.01C46.377,145.844,49.812,139.538,53.524,133.418z M128.169,190.012l-18.887,0.005 l-0.013-18.869l18.889-0.006L128.169,190.012z M33.737,174.538c0.41-1.118,0.841-2.225,1.268-3.334l17.622-0.02l0.006,18.875 l18.888-0.008l0.005,18.887l-18.863,0.016l-0.03-18.895l-18.875,0.024L33.737,174.538z M33.798,246.735l-0.012-18.873l18.881-0.027 l0.012,18.89l0.019,18.873l-18.895,0.007L33.798,246.735z M33.854,303.386l-0.025-18.895l18.87-0.013l18.887-0.007l-0.005-18.881 l18.9-0.024v18.882l0.004,18.888l-18.881,0.031l0.032,18.875l-18.894,0.019l-18.882,0.012L33.854,303.386z M90.498,322.225 l0.018,18.867l-18.869,0.021l-0.013-18.869L90.498,322.225z M126.935,454.382c-20.952-13.659-39.602-30.547-55.253-49.958 l-0.004-6.669l18.881-0.007l18.894-0.013l18.888-0.018v18.889l0.011,18.881l0.019,18.893L126.935,454.382z M147.253,466.235 l-0.008-11.865l-0.006-18.888l-0.011-18.888l-0.031-18.89l-0.005-18.874l-18.869,0.013l-18.888,0.023l-18.882,0.008l-18.881,0.006 l-17.95,0.023c-3.723-6.114-7.167-12.416-10.334-18.878l9.379-0.003l18.887-0.024l18.881-0.014l18.876-0.012l18.888-0.024 l18.881-0.011l18.881-0.014l0.03,18.888v18.862l0.031,18.9l0.006,18.888l0.005,18.881l0.019,18.869l0.001,1.775 C159.707,472.341,153.4,469.422,147.253,466.235z M203.924,486.896c-6.397-1.437-12.698-3.126-18.887-5.069l-0.002-8.612 l18.881-0.013l-0.006-18.881l18.881-0.012l0.013,18.868l-18.888,0.024L203.924,486.896z M222.791,454.309l-0.019-18.887 l18.869-0.02l0.025,18.894L222.791,454.309z M241.697,492.06l-0.023-18.894l18.899-0.013l-0.018-18.881l18.876-0.007l0.005,18.869 l-18.863,0.019l0.014,18.889L241.697,492.06z M449.322,392.527v-13.922l9.143-0.006 C455.579,383.355,452.526,387.999,449.322,392.527z M487.029,307.466l-0.003-4.416l0.947-0.002 C487.676,304.527,487.354,305.997,487.029,307.466z M487.001,265.279l0.007,18.883l-18.877,0.012l-18.887,0.021l0.012,18.887 l-18.875,0.013l0.03,18.893v18.868l18.875-0.013l-0.006-18.868l-0.024-18.895l18.895-0.023l0.006,18.887l15.182-0.005 c-3.791,13.095-8.683,25.721-14.568,37.773l-0.577,0.001l-0.024-18.894l-18.882,0.023l0.024,18.888l-18.881,0.012v18.876 l0.012,18.883l0.023,18.39c-0.151,0.165-0.306,0.327-0.457,0.491l-18.423,0.014l0.018,17.908 c-8.262,7.216-17.032,13.861-26.246,19.887l-11.52,0.005l0.009,7.081c-6.116,3.52-12.412,6.761-18.857,9.732l-0.027-16.809 l-18.875,0.024l0.012,18.875l0.004,5.646c-17.974,6.464-36.952,10.819-56.643,12.757l-0.023-18.366l18.895-0.007l-0.007-18.881 l18.881-0.012l18.882-0.014l-0.024-18.886l18.894-0.02l-0.02-18.886l-18.887,0.018l0.012,18.888l-18.862,0.019l-18.894,0.019 l-18.881,0.006l-0.006-18.882l-18.895,0.007l-0.007-18.889l-18.881,0.024l0.005,18.889l-18.887,0.006l-0.006-18.888l-18.894,0.017 l0.024,18.895h-18.893l-0.019-18.883l18.887-0.013l-0.012-18.865H184.95v-18.876l-0.006-18.887l-18.881,0.018l-18.901,0.006 l-0.006-18.87l18.889-0.006l18.875-0.03h18.875l0.03,18.874l18.876-0.028l0.024,18.894l-18.881,0.018v18.888l18.892-0.024h18.881 l-0.019-18.894l18.881-0.024l-0.013-18.876l18.882-0.019l-0.014-18.868l-18.885,0.011l0.019,18.874l-18.895,0.008l-0.012-18.869 l18.888-0.013v-18.881l18.868-0.024l0.019,18.895l18.887-0.013l-0.024-18.894l18.875-0.024l-0.006-18.888l-18.895,0.022 l-18.881,0.006l-0.006-18.881l-18.895,0.019l-18.881,0.014l-18.863,0.012l-0.019-18.871l-18.877,0.023l0.007,18.871l-18.881,0.007 v18.881l0.007,18.884l-18.87,0.029l-18.887,0.013l0.024,18.889l-18.888,0.012l0.012,18.87l-18.888,0.017l-0.019-18.874 l-0.005-18.882v-18.882l18.887-0.023l18.87-0.014l18.875-0.012l-0.012-18.894l-18.889,0.012l-18.863,0.019l-0.03-18.878 l-0.019-18.876l-18.881,0.012l0.006,18.881l-18.864,0.016L90.423,227.8l-0.005-18.881l18.881-0.009l18.887-0.006l-0.019-18.891 l18.881-0.024l0.013,18.887l18.894-0.003l0.013,18.884l-18.881,0.011v18.878l18.888-0.003l18.894-0.021l-0.019-18.887l18.887-0.012 l-0.024-18.887l18.881-0.009l0.004,18.887l18.895-0.019l18.881-0.012l-0.005-18.881l-18.89,0.003l-0.018-18.891l18.887-0.002 l-0.013-18.876l-0.019-18.887l-0.006-18.881l18.869-0.016l-0.019-18.875l-18.863,0.016L260.27,95.5l18.875-0.013l18.888-0.019 l-0.007-18.884l18.888-0.006l0.006,18.885l18.895-0.022l-0.024-18.879l18.883-0.018l0.029,18.89l0.006,18.887l0.013,18.866 l0.006,18.888l-18.895,0.003l-0.006-18.878l-0.007-18.875l-18.887,0.019l0.007,18.872l0.022,18.894l0.021,18.887l18.874-0.024 l0.03,18.876l18.881-0.009l-0.029-18.878l18.882-0.021l18.889-0.009l18.887-0.003l18.888-0.021l18.888-0.009l0.014,18.87 l0.004,18.89l-18.886,0.003l0.023,18.891l-18.895,0.019l-18.887,0.012l-0.007-18.887l18.875-0.013l-0.012-18.884l-18.881,0.006 l-18.876,0.013l0.006,18.884l-18.876,0.028l-18.881,0.012l0.006,18.881l-18.881,0.028l-18.863,0.009v18.887l0.014,18.868h18.88 l18.882-0.038h18.889l-0.014-18.872l-18.888,0.009l-0.019-18.891l18.888-0.008l18.888-0.021l0.007,18.887l18.894-0.011 l18.875-0.003l0.014,18.871l-18.882,0.006l-18.881,0.011l0.013,18.89l-18.877,0.03v18.882l-18.875,0.005l-18.888,0.007 l0.031,18.894l18.868-0.012l18.881-0.013l18.889-0.024h18.895l18.887-0.023l-0.023-18.881l18.881-0.014l-0.018-18.885 l-18.879,0.005l0.019,18.888l-18.896,0.012l-0.017-18.882l18.891-0.023l-0.019-18.869l18.894-0.02l18.881-0.012l-0.024-18.872 l-18.874,0.016l-0.013-18.894l18.861-0.012l18.901-0.019v18.881l18.888-0.004l-0.006-18.887l3.976-0.002 c1.12,9.341,1.712,18.845,1.712,28.487c0,3.107-0.079,6.196-0.197,9.274L487.001,265.279z M203.782,303.258l18.887-0.023h18.881 l0.011,18.881l-18.894,0.006l-18.875,0.029L203.782,303.258z\"/> </g>";
                                    qrCodesIconContainer.Controls.Add(qrCodesIcon);
                                }
                                qrCodesContainer.Controls.Add(qrCodesIconContainer);
                            }
                            using (HtmlGenericControl qrCodesTitle = new HtmlGenericControl("span"))
                            {
                                qrCodesTitle.Attributes["class"] = "symbology_name";
                                qrCodesTitle.InnerHtml = "QR Codes";
                                qrCodesContainer.Controls.Add(qrCodesTitle);
                            }
                            using (HtmlGenericControl qrCodesCheckboxContainer = new HtmlGenericControl("div"))
                            {
                                qrCodesCheckboxContainer.Attributes["class"] = "checkbox";
                                using (HtmlInputCheckBox qrCodesCheckbox = new HtmlInputCheckBox())
                                {
                                    qrCodesCheckbox.ID = "chk-qr";
                                    qrCodesCheckbox.Name = "qr";
                                    qrCodesCheckbox.Checked = true;
                                    qrCodesCheckboxContainer.Controls.Add(qrCodesCheckbox);
                                }
                                qrCodesContainer.Controls.Add(qrCodesCheckboxContainer);
                            }
                            symbologiesContainer.Controls.Add(qrCodesContainer);
                        }
                        // Micro QR codes
                        using (HtmlGenericControl microQrCodesContainer = new HtmlGenericControl("div"))
                        {
                            microQrCodesContainer.ID = "MicroQRCodesContainer" + DocuVieware1.UniqueID;
                            microQrCodesContainer.Attributes["class"] = "symbology";
                            microQrCodesContainer.Attributes["title"] = "Detect Micro QR Codes";

                            using (HtmlGenericControl microQrCodesIconContainer = new HtmlGenericControl("div"))
                            {
                                microQrCodesIconContainer.Attributes["class"] = "icon";
                                using (HtmlGenericControl microQrCodesIcon = new HtmlGenericControl("svg"))
                                {
                                    microQrCodesIcon.Attributes["viewBox"] = "0 0 512 512";
                                    microQrCodesIcon.InnerHtml = "<g> <g> <path fill=\"#2D85C7\" d=\"M476.995,376.971v-0.797V343.32h-32.848v34.445h-34.445v32.858h32.854h1.592h12.286 c7.592-9.903,14.471-20.378,20.562-31.354v-1.506V376.971z\"/> <path fill=\"#2D85C7\" d=\"M478.586,238.395h29.615c-0.765-11.166-2.239-22.134-4.397-32.858h-25.218V238.395z\"/> <path fill=\"#2D85C7\" d=\"M339.21,31.713V16.088c-10.644-3.762-21.607-6.846-32.848-9.178v24.803H339.21z\"/> <path fill=\"#2D85C7\" d=\"M375.251,66.161h32.861h1.59h14.052c-14.73-13.15-30.995-24.62-48.503-34.088v1.231V66.161z\"/> <path fill=\"#2D85C7\" d=\"M408.112,445.864v-0.794v-32.854h-32.861v32.854v1.592v32.852h0.771 c11.238-6.128,21.958-13.088,32.09-20.78v-12.07V445.864z\"/> <path fill=\"#2D85C7\" d=\"M235.882,481.105v-34.443h-34.445v-34.446v-0.794v-0.797v-32.859h-32.86v34.45h-34.451v32.854h34.451 v34.442h34.451v25.704c16.596,3.404,33.781,5.193,51.384,5.193c5.345,0,10.646-0.186,15.908-0.51v-28.797h-34.438V481.105z\"/> <path fill=\"#2D85C7\" d=\"M135.8,481.105c10.021,5.291,20.429,9.947,31.186,13.885v-13.885H135.8z\"/> <path fill=\"#2D85C7\" d=\"M63.652,377.766H30.984c6.295,11.525,13.465,22.502,21.404,32.859h11.264V377.766z\"/> <path fill=\"#2D85C7\" d=\"M30.785,136.648v32.854v1.591v32.854h32.867h1.59h32.854h1.591h32.848h1.591h32.86h1.591h32.86v-32.854 v-0.795v-0.796v-32.854v-0.796v-0.795V102.2v-0.795v-0.795V67.751v-0.794v-0.796V33.304h-32.86h-1.591h-32.86h-1.591h-1.186 c-16.661,9.227-32.174,20.267-46.278,32.857h13.026h1.591h32.848h1.591h34.451v34.448v1.59v32.857v1.591v34.445h-34.451h-1.591 H99.687h-1.591H63.652v-34.445v-0.796v-0.795v-32.857v-0.795v-0.795V87.696c-12.625,14.298-23.68,30.017-32.867,46.902v0.459 V136.648z\"/> <path fill=\"#2D85C7\" d=\"M306.362,481.105v23.988c11.239-2.332,22.204-5.416,32.848-9.178v-14.812h-32.848V481.105z\"/> <path fill=\"#2D85C7\" d=\"M85.991,446.662c3.931,3.475,7.964,6.835,12.105,10.063v-10.063H85.991z\"/> <rect x=\"340.8\" y=\"377.766\" fill=\"#2D85C7\" width=\"32.862\" height=\"32.859\"/> <polygon fill=\"#2D85C7\" points=\"134.126,341.729 166.986,341.729 166.986,308.874 134.126,308.874 132.535,308.874 99.687,308.874 99.687,341.729 132.535,341.729 \"/> <rect x=\"99.687\" y=\"377.766\" fill=\"#2D85C7\" width=\"32.848\" height=\"32.859\"/> <rect x=\"375.251\" y=\"343.32\" fill=\"#2D85C7\" width=\"32.861\" height=\"32.854\"/> <rect x=\"65.242\" y=\"343.32\" fill=\"#2D85C7\" width=\"32.854\" height=\"32.854\"/> <rect x=\"306.362\" y=\"412.216\" fill=\"#2D85C7\" width=\"32.848\" height=\"32.854\"/> <path fill=\"#2D85C7\" d=\"M30.785,272.839h32.867h1.59h32.854h1.591h32.848h1.591h34.451v34.446h34.451v34.443h34.445v34.444v1.593 v32.858h32.849v-33.653v-0.797h34.449V343.32h-34.449v-34.446h-34.439v-35.24v-0.795h36.029v34.446h32.859v-32.854v-0.798v-0.795 v-32.854h-34.449v-35.243v-0.796h36.041v34.448h32.848v-33.652v-0.796h34.452h1.589h34.451v36.039h-34.451v34.445H340.8v32.854 h32.862h1.589h32.861v-33.651v-0.795h34.443h1.591h32.849v-32.854h-34.438v-34.448v-0.794v-0.796v-33.649v-0.796h34.438v-32.854 v-0.796v-0.795v-2.321c-5.924-10.673-12.59-20.875-19.935-30.537h-12.914h-1.591h-32.854h-1.59h-32.861h-1.589H339.21V67.751 h-32.848h-1.591H270.32V33.304v-0.796v-0.795V2.103c-5.262-0.325-10.563-0.51-15.908-0.51c-5.694,0-11.339,0.207-16.939,0.575 v29.545v1.591v32.857v1.59v32.858v1.59v32.857v1.591v32.854v1.591v32.854v1.59v34.448h-34.445h-1.591h-32.86h-1.591h-32.86h-1.591 H99.687h-1.591H65.242h-1.59H30.785h-1.591H0.517C0.187,245.285,0,250.623,0,256.006c0,5.658,0.205,11.268,0.568,16.833h28.626 H30.785L30.785,272.839z M373.662,135.852v-0.795h36.04v36.036h-36.04V135.852z\"/> <path fill=\"#2D85C7\" d=\"M29.194,308.874H5.517c2.377,11.244,5.497,22.212,9.305,32.854h14.373L29.194,308.874L29.194,308.874z\"/> </g> <path fill=\"#2D85C7\" d=\"M256.003,19.211c130.562,0,236.788,106.225,236.788,236.794c0,130.562-106.226,236.787-236.788,236.787 c-130.569,0-236.794-106.226-236.794-236.787C19.208,125.437,125.434,19.211,256.003,19.211 M256.003,0.002 C114.624,0.002,0,114.616,0,256.006c0,141.385,114.624,255.996,256.003,255.996C397.389,512.002,512,397.391,512,256.006 C512,114.616,397.389,0.002,256.003,0.002z\"/> </g>";
                                    microQrCodesIconContainer.Controls.Add(microQrCodesIcon);
                                }
                                microQrCodesContainer.Controls.Add(microQrCodesIconContainer);
                            }
                            using (HtmlGenericControl microQrCodesTitle = new HtmlGenericControl("span"))
                            {
                                microQrCodesTitle.Attributes["class"] = "symbology_name";
                                microQrCodesTitle.InnerHtml = "Micro QR Codes";
                                microQrCodesContainer.Controls.Add(microQrCodesTitle);
                            }
                            using (HtmlGenericControl microQrCodesCheckboxContainer = new HtmlGenericControl("div"))
                            {
                                microQrCodesCheckboxContainer.Attributes["class"] = "checkbox";
                                using (HtmlInputCheckBox microQrCodesCheckbox = new HtmlInputCheckBox())
                                {
                                    microQrCodesCheckbox.ID = "chk-microqr";
                                    microQrCodesCheckbox.Name = "microqr";
                                    microQrCodesCheckbox.Checked = true;
                                    microQrCodesCheckboxContainer.Controls.Add(microQrCodesCheckbox);
                                }
                                microQrCodesContainer.Controls.Add(microQrCodesCheckboxContainer);
                            }
                            symbologiesContainer.Controls.Add(microQrCodesContainer);
                        }
                        // Datamatrix
                        using (HtmlGenericControl datamatrixContainer = new HtmlGenericControl("div"))
                        {
                            datamatrixContainer.ID = "DatamatrixContainer" + DocuVieware1.UniqueID;
                            datamatrixContainer.Attributes["class"] = "symbology";
                            datamatrixContainer.Attributes["title"] = "Detect Data Matrix Barcodes";

                            using (HtmlGenericControl datamatrixIconContainer = new HtmlGenericControl("div"))
                            {
                                datamatrixIconContainer.Attributes["class"] = "icon";
                                using (HtmlGenericControl datamatrixIcon = new HtmlGenericControl("svg"))
                                {
                                    datamatrixIcon.Attributes["viewBox"] = "0 0 512 512";
                                    datamatrixIcon.InnerHtml = "<g> <rect x=\"255.204\" y=\"371.982\" fill=\"#2481C4\" width=\"27.737\" height=\"27.731\"/> <rect x=\"196.538\" y=\"342.65\" fill=\"#2481C4\" width=\"27.732\" height=\"27.732\"/> <rect x=\"137.873\" y=\"78.648\" fill=\"#2481C4\" width=\"27.732\" height=\"27.733\"/> <rect x=\"284.544\" y=\"78.648\" fill=\"#2481C4\" width=\"27.726\" height=\"27.733\"/> <rect x=\"196.538\" y=\"107.981\" fill=\"#2481C4\" width=\"27.732\" height=\"27.732\"/> <rect x=\"167.205\" y=\"137.314\" fill=\"#2481C4\" width=\"27.733\" height=\"27.733\"/> <polygon fill=\"#2481C4\" points=\"194.938,401.315 165.604,401.315 165.604,371.982 137.873,371.982 137.873,399.715 137.873,401.315 137.873,429.048 165.604,429.048 167.205,429.048 194.938,429.048 196.538,429.048 224.27,429.048 224.27,401.315 196.538,401.315 \"/> <path fill=\"#2481C4\" d=\"M511.984,254.653c-0.001-0.268-0.009-0.535-0.011-0.803c-0.002-0.267-0.007-0.533-0.01-0.799 c0-0.033-0.002-0.066-0.003-0.1c-0.025-2.249-0.081-4.49-0.165-6.724c-0.005-0.122-0.009-0.245-0.014-0.367 c-0.085-2.18-0.197-4.352-0.336-6.518c-0.01-0.154-0.02-0.307-0.029-0.461c-0.143-2.154-0.312-4.301-0.507-6.44 c-0.013-0.143-0.024-0.286-0.037-0.428c-0.205-2.196-0.436-4.383-0.694-6.562c-0.006-0.044-0.01-0.09-0.015-0.134 c-0.032-0.267-0.061-0.535-0.092-0.802c-0.032-0.266-0.059-0.535-0.092-0.8c-0.001-0.009-0.003-0.017-0.004-0.026 c-1.182-9.383-2.885-18.603-5.054-27.642c-0.005-0.021-0.01-0.043-0.015-0.064c-0.064-0.267-0.13-0.533-0.195-0.8 c-0.064-0.267-0.129-0.534-0.195-0.8h0.002c-0.014-0.054-0.029-0.107-0.042-0.161c-2.317-9.352-5.144-18.502-8.458-27.417 c-0.019-0.052-0.036-0.105-0.056-0.157h-0.002c-0.101-0.268-0.204-0.534-0.305-0.801c-0.102-0.267-0.203-0.534-0.306-0.8 c-0.001-0.003-0.003-0.006-0.004-0.009c-0.822-2.164-1.673-4.313-2.552-6.449c-0.053-0.127-0.104-0.255-0.156-0.383 c-0.872-2.107-1.769-4.202-2.694-6.28c-0.025-0.057-0.048-0.114-0.073-0.171c-0.02-0.043-0.039-0.087-0.059-0.13 c-0.235-0.525-0.468-1.052-0.706-1.575c-0.013-0.027-0.024-0.054-0.037-0.082c-0.262-0.573-0.533-1.14-0.8-1.711 c-0.007-0.015-0.015-0.029-0.021-0.044c-0.849-1.825-1.718-3.639-2.607-5.44c-0.01-0.02-0.02-0.039-0.029-0.059 c-0.887-1.794-1.794-3.577-2.721-5.347c-0.01-0.017-0.019-0.035-0.027-0.053c-0.141-0.267-0.28-0.533-0.422-0.8 s-0.28-0.535-0.423-0.801h0.004c-0.034-0.063-0.07-0.125-0.104-0.188c-2.457-4.598-5.048-9.112-7.771-13.536 c-0.254-0.413-0.514-0.821-0.77-1.232c-1.056-1.693-2.13-3.373-3.224-5.04c-0.375-0.571-0.747-1.143-1.126-1.711 c-1.22-1.825-2.459-3.635-3.723-5.427c-0.14-0.197-0.271-0.401-0.41-0.598h-0.004c-0.004-0.006-0.009-0.012-0.013-0.018 c-0.153-0.215-0.31-0.428-0.463-0.643c-0.033-0.046-0.067-0.093-0.101-0.139c-0.191-0.269-0.391-0.532-0.583-0.8 c-0.069-0.095-0.14-0.188-0.209-0.284c-0.969-1.338-1.943-2.671-2.938-3.99c-0.017-0.022-0.032-0.045-0.049-0.067 c-0.265-0.35-0.533-0.694-0.799-1.042c-0.268-0.349-0.534-0.698-0.803-1.046c-0.013-0.017-0.026-0.032-0.039-0.049 c-5.704-7.404-11.798-14.491-18.263-21.221c-0.011-0.011-0.021-0.023-0.032-0.034c-0.259-0.269-0.521-0.533-0.78-0.8 c-0.261-0.268-0.521-0.534-0.782-0.801c-0.034-0.035-0.069-0.068-0.103-0.103c-1.203-1.229-2.418-2.446-3.646-3.651 c-0.106-0.105-0.214-0.209-0.321-0.314c-1.222-1.195-2.453-2.38-3.699-3.551c-0.022-0.021-0.043-0.042-0.065-0.062 c-0.267-0.249-0.532-0.496-0.799-0.744c-0.268-0.248-0.531-0.497-0.8-0.744c-0.02-0.018-0.039-0.035-0.059-0.053 c-7.114-6.564-14.601-12.727-22.425-18.459c-0.022-0.017-0.044-0.034-0.066-0.05c-0.365-0.267-0.729-0.535-1.097-0.8 c-0.366-0.266-0.729-0.537-1.098-0.801c-0.027-0.02-0.055-0.038-0.082-0.058c-0.889-0.636-1.788-1.258-2.686-1.883 c-0.074-0.051-0.147-0.104-0.222-0.155c-0.268-0.186-0.534-0.372-0.802-0.556s-0.531-0.371-0.8-0.554v-0.004 c-0.06-0.041-0.121-0.079-0.18-0.119c-4.142-2.825-8.37-5.529-12.681-8.113c-0.612-0.367-1.228-0.727-1.843-1.089 c-1.492-0.877-2.994-1.74-4.506-2.588c-0.728-0.409-1.453-0.82-2.186-1.222c-1.786-0.979-3.586-1.937-5.397-2.875 c-0.317-0.165-0.629-0.341-0.947-0.504v0.004c-0.266-0.135-0.534-0.262-0.8-0.397c-0.266-0.135-0.534-0.264-0.802-0.398 c-0.02-0.01-0.039-0.019-0.059-0.029c-2.114-1.063-4.246-2.096-6.394-3.102c-0.614-0.288-1.228-0.578-1.845-0.861 c-0.829-0.38-1.659-0.756-2.492-1.128c-1.052-0.47-2.108-0.93-3.167-1.386c-0.553-0.237-1.102-0.481-1.655-0.714 c-0.003-0.001-0.005-0.002-0.007-0.003c-0.648-0.274-1.307-0.532-1.96-0.801c-0.65-0.268-1.303-0.537-1.957-0.8 c-0.018-0.007-0.036-0.014-0.054-0.021c-1.125-0.452-2.254-0.894-3.387-1.33c-0.571-0.221-1.145-0.437-1.718-0.653 c-0.998-0.376-1.995-0.754-2.999-1.118c-0.011-0.004-0.021-0.008-0.032-0.012c-0.267-0.096-0.534-0.186-0.8-0.282 c-0.267-0.095-0.533-0.187-0.801-0.282v-0.004c-0.123-0.044-0.249-0.083-0.373-0.126c-1.941-0.686-3.894-1.348-5.855-1.987 c-0.371-0.121-0.742-0.242-1.114-0.362c-1.741-0.558-3.49-1.097-5.248-1.619c-0.578-0.172-1.155-0.348-1.734-0.516 c-1.528-0.442-3.064-0.864-4.604-1.278c-0.754-0.203-1.504-0.415-2.26-0.611c-1.542-0.4-3.093-0.774-4.646-1.145 c-0.636-0.152-1.265-0.322-1.902-0.469v0.004c-0.012-0.002-0.022-0.005-0.034-0.007c-0.178-0.041-0.356-0.076-0.534-0.117 c-0.078-0.017-0.157-0.033-0.235-0.051c-0.266-0.061-0.532-0.115-0.799-0.174c-0.027-0.006-0.055-0.011-0.081-0.017 c-2.185-0.489-4.381-0.949-6.586-1.382c-0.154-0.03-0.31-0.059-0.464-0.089c-2.116-0.411-4.242-0.796-6.377-1.155 c-0.168-0.028-0.337-0.056-0.506-0.084c-2.157-0.358-4.324-0.689-6.499-0.994c-0.116-0.016-0.232-0.032-0.349-0.048 c-2.267-0.314-4.542-0.599-6.828-0.853c-0.012-0.001-0.024-0.003-0.036-0.004c-0.109-0.012-0.219-0.024-0.328-0.037 c-0.426-0.047-0.848-0.101-1.273-0.146V1.404c-0.078-0.008-0.156-0.013-0.233-0.021c-1.598-0.166-3.203-0.304-4.809-0.44 c-0.607-0.052-1.212-0.114-1.82-0.162c-1.389-0.108-2.785-0.189-4.18-0.274c-0.854-0.053-1.706-0.118-2.562-0.163 c-0.877-0.045-1.759-0.068-2.638-0.104c-3.549-0.148-7.111-0.244-10.696-0.244c-0.268,0-0.533,0.009-0.8,0.01V0.01 c-0.268,0.001-0.533,0.008-0.8,0.01s-0.533,0.008-0.8,0.01c-0.003,0-0.006,0-0.009,0c-2.314,0.021-4.621,0.074-6.92,0.157 c-0.061,0.002-0.121,0.005-0.181,0.007c-2.257,0.083-4.505,0.194-6.747,0.334c-0.074,0.005-0.148,0.01-0.223,0.014 c-2.242,0.143-4.476,0.313-6.702,0.513c-0.057,0.005-0.113,0.01-0.17,0.016c-2.265,0.205-4.521,0.438-6.768,0.701 c-0.004,0-0.008,0.001-0.012,0.001c-0.267,0.031-0.534,0.06-0.801,0.091c-0.251,0.03-0.504,0.056-0.755,0.087 c-0.015,0.001-0.03,0.003-0.044,0.005V1.953c-0.055,0.007-0.11,0.016-0.165,0.022c-6.997,0.87-13.906,2.025-20.716,3.447 c-0.027,0.006-0.054,0.012-0.081,0.018c-2.204,0.461-4.396,0.953-6.578,1.47c-0.064,0.015-0.128,0.028-0.192,0.043v0.004 c-0.268,0.064-0.533,0.131-0.8,0.195s-0.533,0.13-0.8,0.195c-0.007,0.002-0.014,0.004-0.021,0.005 c-10.015,2.452-19.798,5.492-29.312,9.084v-0.003c-0.123,0.046-0.243,0.096-0.366,0.142c-1.494,0.567-2.983,1.142-4.464,1.735 c-0.057,0.023-0.115,0.044-0.172,0.067h0.008c-2.3,0.924-4.582,1.884-6.848,2.873c-0.723,0.316-1.449,0.626-2.169,0.949 c-1.154,0.516-2.299,1.047-3.443,1.58c-0.479,0.223-0.959,0.444-1.437,0.67c-1.298,0.614-2.589,1.24-3.875,1.875 c-0.24,0.119-0.479,0.238-0.719,0.357c-1.964,0.977-3.914,1.978-5.848,3.003v-0.002c-0.053,0.028-0.105,0.057-0.158,0.085 c-3.567,1.894-7.083,3.87-10.546,5.925c-0.243,0.144-0.487,0.287-0.73,0.432c-1.04,0.622-2.075,1.25-3.105,1.886 c-0.431,0.266-0.859,0.536-1.289,0.804c-1.568,0.981-3.124,1.978-4.669,2.991c-0.64,0.42-1.282,0.838-1.918,1.263 c-0.781,0.522-1.557,1.051-2.332,1.582c-0.737,0.504-1.47,1.014-2.201,1.525c-0.701,0.491-1.404,0.979-2.1,1.477 c-0.028,0.02-0.057,0.04-0.085,0.06h0.003c-5.263,3.769-10.374,7.736-15.329,11.883c-0.09,0.075-0.179,0.152-0.269,0.227 c-1.912,1.605-3.799,3.238-5.664,4.897c-0.275,0.245-0.552,0.487-0.826,0.733c-4.712,4.23-9.269,8.629-13.655,13.194h-0.002 c-0.014,0.015-0.027,0.03-0.042,0.044c-1.889,1.967-3.746,3.964-5.571,5.99c-0.087,0.097-0.173,0.196-0.26,0.293 c-1.682,1.872-3.333,3.772-4.96,5.694c-0.205,0.242-0.411,0.484-0.615,0.727c-3.472,4.131-6.817,8.371-10.027,12.718 c-0.019,0.025-0.038,0.048-0.056,0.073v0.003c-2.427,3.29-4.776,6.639-7.047,10.047c-0.251,0.377-0.499,0.757-0.748,1.135 c-1.259,1.912-2.493,3.84-3.702,5.787c-0.126,0.203-0.254,0.405-0.38,0.609c-3.126,5.067-6.078,10.252-8.853,15.545h-0.001 c-0.011,0.021-0.021,0.041-0.031,0.062c-0.733,1.4-1.454,2.807-2.162,4.222c-0.072,0.143-0.142,0.287-0.213,0.43 c-2.116,4.247-4.12,8.559-6.002,12.936c-0.061,0.141-0.125,0.279-0.185,0.419v0.002c-9.168,21.428-15.503,44.356-18.519,68.319 c0,0.002,0,0.005-0.001,0.007c-0.009,0.075-0.017,0.15-0.025,0.225c-0.049,0.389-0.087,0.78-0.134,1.169 c-0.008,0.069-0.016,0.139-0.024,0.208c-0.001,0.006-0.001,0.013-0.002,0.02c-0.268,2.24-0.504,4.488-0.714,6.746 c-0.007,0.081-0.014,0.163-0.021,0.244c-0.203,2.211-0.377,4.431-0.523,6.658c-0.005,0.076-0.01,0.152-0.015,0.229 c-0.146,2.248-0.262,4.504-0.349,6.767c-0.001,0.043-0.003,0.086-0.005,0.129c-0.087,2.301-0.145,4.609-0.171,6.925 c0,0.006,0,0.012,0,0.018c-0.003,0.267-0.008,0.533-0.01,0.799c-0.002,0.24-0.007,0.479-0.009,0.718 c-0.002,0.375-0.014,0.746-0.014,1.121C0.002,255.792,0,255.896,0,255.999c0,0.001,0,0.002,0,0.003c0,0.124,0.004,0.246,0.005,0.37 c0.003,2.489,0.05,4.97,0.125,7.442c0.001,0.047,0.004,0.094,0.005,0.141c0.001,0.048,0.004,0.096,0.005,0.144 c0.208,6.663,0.67,13.262,1.377,19.787c0.003,0.031,0.007,0.062,0.01,0.093c0,0.002,0,0.004,0,0.006 c0.507,4.662,1.143,9.284,1.896,13.868c0.003,0.022,0.006,0.046,0.01,0.069c0.004,0.029,0.009,0.061,0.014,0.089 c0.008,0.05,0.018,0.099,0.026,0.148c0.298,1.8,0.613,3.593,0.949,5.38c0.017,0.088,0.034,0.176,0.05,0.264 c0.34,1.8,0.695,3.594,1.073,5.381c0.006,0.029,0.013,0.059,0.019,0.088c1.834,8.665,4.109,17.166,6.796,25.482 c0.016,0.049,0.031,0.097,0.047,0.146c0.76,2.349,1.552,4.683,2.377,7.001c0.011,0.03,0.022,0.062,0.033,0.093 c2.683,7.525,5.709,14.886,9.059,22.067c0.116,0.249,0.232,0.498,0.349,0.747C50.376,420.41,95.935,465.07,152.181,490.057 c0.345,0.152,0.69,0.307,1.036,0.459c0.26,0.113,0.522,0.224,0.782,0.337c16.929,7.362,34.808,12.946,53.404,16.521 c0.123,0.023,0.246,0.047,0.368,0.07c3.979,0.759,7.989,1.425,12.03,1.997c0.313,0.044,0.627,0.088,0.941,0.132 c3.83,0.527,7.686,0.971,11.567,1.326c0.548,0.051,1.096,0.1,1.645,0.146C241.223,511.665,248.572,512,256,512 c5.997,0,11.941-0.223,17.834-0.629c0.075-0.005,0.15-0.009,0.226-0.014c0.005,0,0.01-0.001,0.015-0.001 c8.22-0.573,16.331-1.539,24.318-2.871c0.021-0.003,0.04-0.006,0.061-0.009c0.044-0.008,0.088-0.015,0.132-0.021 c0.08-0.014,0.159-0.028,0.238-0.042c1.864-0.313,3.722-0.648,5.572-1.003c0.655-0.124,1.312-0.247,1.966-0.376 c0.833-0.166,1.664-0.337,2.495-0.512c1.527-0.318,3.052-0.646,4.568-0.994c4.99-1.144,9.92-2.445,14.794-3.876 c0.084-0.025,0.168-0.05,0.252-0.074c0.033-0.01,0.065-0.021,0.099-0.03c2.021-0.597,4.032-1.217,6.033-1.862 c0.042-0.014,0.085-0.025,0.127-0.039c0.037-0.012,0.073-0.022,0.11-0.034c0.152-0.049,0.303-0.102,0.454-0.151 c3.814-1.241,7.59-2.569,11.323-3.983c0.282-0.106,0.564-0.214,0.847-0.321c1.358-0.521,2.713-1.049,4.061-1.591 c0.512-0.205,1.023-0.408,1.531-0.616c0.346-0.142,0.688-0.288,1.031-0.431c1.083-0.45,2.162-0.907,3.237-1.371 c0.35-0.151,0.701-0.3,1.05-0.452c0.658-0.287,1.315-0.578,1.972-0.87c0.385-0.172,0.773-0.337,1.157-0.511 c0.002-0.001,0.005-0.002,0.007-0.003c0.533-0.24,1.062-0.496,1.591-0.742c0.019-0.009,0.036-0.018,0.055-0.026 c2.319-1.07,4.618-2.176,6.898-3.313c0.124-0.062,0.248-0.122,0.372-0.185c6.965-3.486,13.747-7.279,20.331-11.364 c0.178-0.109,0.354-0.221,0.53-0.331c2.07-1.291,4.122-2.609,6.152-3.958c0.097-0.063,0.193-0.127,0.29-0.19 c4.311-2.872,8.53-5.869,12.651-8.99c0.102-0.076,0.201-0.155,0.302-0.231c1.896-1.439,3.768-2.906,5.62-4.396 c0.23-0.186,0.462-0.37,0.691-0.556c5.909-4.786,11.601-9.828,17.059-15.113c0.22-0.213,0.438-0.428,0.657-0.642 c1.622-1.582,3.224-3.185,4.804-4.81c0.191-0.197,0.386-0.393,0.577-0.591c3.544-3.668,6.981-7.438,10.304-11.312 c0.086-0.101,0.17-0.202,0.256-0.303c1.527-1.787,3.028-3.598,4.508-5.427c0.219-0.271,0.438-0.543,0.656-0.815 c1.483-1.851,2.945-3.719,4.378-5.611c0.048-0.062,0.098-0.122,0.145-0.185c0.068-0.089,0.137-0.177,0.204-0.266 c0.025-0.033,0.05-0.066,0.074-0.101c2.284-3.033,4.498-6.123,6.649-9.26c0.081-0.118,0.166-0.234,0.247-0.354 c0.123-0.177,0.246-0.353,0.367-0.529c0.017-0.024,0.033-0.05,0.05-0.075c3.243-4.776,6.322-9.673,9.243-14.672 c0.093-0.159,0.188-0.315,0.28-0.475c0.839-1.441,1.658-2.895,2.469-4.354c0.117-0.212,0.241-0.42,0.358-0.633 c0.079-0.144,0.157-0.287,0.236-0.431c1.273-2.319,2.518-4.657,3.721-7.02c0.014-0.025,0.027-0.05,0.041-0.075 c0.008-0.016,0.016-0.031,0.022-0.048c0.276-0.542,0.539-1.092,0.812-1.637c1.116-2.233,2.2-4.483,3.252-6.753 c0.105-0.229,0.216-0.453,0.321-0.682c0.132-0.277,0.263-0.555,0.39-0.832c0.034-0.075,0.067-0.149,0.101-0.225 c1.344-2.956,2.621-5.949,3.854-8.965c0.146-0.358,0.299-0.715,0.444-1.074c0.068-0.171,0.139-0.342,0.206-0.513 c0.009-0.022,0.018-0.045,0.026-0.067c0.725-1.81,1.428-3.63,2.112-5.459c0.048-0.127,0.097-0.252,0.145-0.379 c0.681-1.828,1.339-3.666,1.979-5.514c0.042-0.121,0.086-0.241,0.128-0.362c0.643-1.863,1.262-3.737,1.861-5.619 c0.034-0.105,0.069-0.211,0.103-0.316c0.598-1.882,1.172-3.774,1.727-5.676c0.025-0.085,0.054-0.169,0.078-0.255 c0.036-0.121,0.071-0.243,0.106-0.363c1.093-3.78,2.097-7.599,3.018-11.448c0.095-0.395,0.196-0.787,0.288-1.182 c0.335-1.431,0.648-2.868,0.959-4.308c0.101-0.467,0.207-0.932,0.305-1.398c0.31-1.474,0.6-2.953,0.884-4.436 c0.081-0.421,0.164-0.842,0.242-1.264c0.284-1.525,0.553-3.057,0.81-4.592c0.033-0.198,0.072-0.394,0.104-0.592 c0.007-0.041,0.015-0.082,0.021-0.123c0.023-0.146,0.042-0.292,0.066-0.438c0.312-1.912,0.601-3.832,0.869-5.759 c0.026-0.186,0.059-0.37,0.084-0.556c0.013-0.092,0.024-0.183,0.037-0.272c0.014-0.099,0.023-0.199,0.036-0.298 c0.271-2,0.516-4.007,0.739-6.021c0.02-0.174,0.045-0.345,0.063-0.519c0.003-0.021,0.006-0.041,0.008-0.062 c0.029-0.268,0.063-0.533,0.093-0.802c0.027-0.267,0.062-0.531,0.091-0.798c0.005-0.049,0.008-0.098,0.013-0.145 c0.18-1.762,0.332-3.531,0.477-5.303c0.02-0.305,0.049-0.611,0.075-0.919c0.115-1.488,0.202-2.984,0.292-4.479 c0.021-0.376,0.052-0.751,0.072-1.127c0.018-0.319,0.04-0.637,0.06-0.955c0.044-0.854,0.069-1.713,0.104-2.568 c0.04-1.017,0.087-2.031,0.117-3.05c0.013-0.407,0.036-0.812,0.046-1.222c0.056-2.194,0.085-4.396,0.085-6.605 c0-0.001,0-0.002,0-0.003C512.002,255.549,511.987,255.103,511.984,254.653z M448.982,393.018 c-0.917,1.289-1.854,2.562-2.796,3.833c-0.315,0.424-0.629,0.849-0.946,1.271c-4.89,6.5-10.112,12.733-15.632,18.689v-15.495 v-0.802v-0.8v-27.731v-0.801v-0.799V342.65v-0.799v-0.803v-27.732h-29.335v-30.141v-0.798h30.933v29.337h27.731v-27.736v-0.803 v-0.798v-27.726h-29.329v-30.138v-0.8h29.329v-28.532v-0.8h25.601c2.707,10.064,4.777,20.388,6.143,30.935h-0.809h-1.601h-27.733 v27.734h27.733h1.601h2.749c0.012,0.983,0.037,1.963,0.037,2.949c0,9.468-0.573,18.801-1.654,27.979h-1.132v8.42 c-5.72,37.052-20.03,71.269-40.839,100.546C449.016,392.969,448.999,392.993,448.982,393.018z M398.113,445.246 c-0.314,0.237-0.63,0.474-0.945,0.709c-1.374,1.022-2.757,2.035-4.153,3.029c-0.013,0.009-0.025,0.018-0.038,0.026 c-5.479,3.896-11.14,7.549-16.95,10.976h-5.089v-29.339h-29.325v-29.333h-27.737v29.333h-29.327v29.339h-29.34v27.728h27.738h1.602 h19.773c-15.601,3.236-31.761,4.944-48.321,4.944c-32.017,0-62.542-6.372-90.396-17.894v-14.778h-29.333v-29.339h-27.739h-1.601 H96.306c-0.952-0.87-1.895-1.75-2.832-2.636c-0.546-0.517-1.089-1.036-1.63-1.558c-0.798-0.769-1.591-1.542-2.378-2.321 c-0.54-0.535-1.077-1.072-1.612-1.613c-0.789-0.796-1.572-1.599-2.35-2.406c-0.504-0.523-1.007-1.05-1.507-1.578 c-0.81-0.856-1.613-1.72-2.41-2.589c-0.444-0.484-0.888-0.969-1.329-1.457c-0.893-0.989-1.777-1.986-2.654-2.99v-10.185h-8.397 c-14.146-18.157-25.696-38.432-34.108-60.268h14.769v29.334h27.739h1.601h27.726V341.85v-0.803h29.339v-28.533v-0.801h30.934 v29.334h27.733v-27.732v-0.801v-0.801v-27.736h-29.333v-29.326v-0.803v-0.799v-28.536v-0.8h30.934v29.336v1.602v27.726h29.333 v29.337v1.603v27.731h27.732h1.601h29.34v29.334h27.727h1.602h27.737h1.6h27.727h1.601h29.341v29.331v1.602v27.731h15.534 C411.274,434.775,404.837,440.189,398.113,445.246z M312.269,485.909v-26.722v-0.8h30.938v17.679 C333.212,480.031,322.878,483.321,312.269,485.909z M80.102,97.688c0.827-0.918,1.666-1.826,2.507-2.731 c0.612-0.659,1.218-1.322,1.837-1.973c1.401-1.474,2.818-2.933,4.257-4.37c0.537-0.537,1.088-1.06,1.63-1.592 c0.987-0.967,1.976-1.932,2.979-2.882c0.705-0.667,1.418-1.325,2.131-1.984c0.853-0.788,1.71-1.571,2.575-2.347 c41.712-37.426,96.78-60.257,157.186-60.457v0.628v29.335H225.87v27.731h27.732h1.601h27.738V49.315v-0.8v-0.801V20.877 c10.535,1.194,20.86,3.073,30.93,5.604v21.232v1.601v27.731h27.737V49.315v-0.8v-0.801V35.313 c27.012,10.486,51.619,25.785,72.771,44.848c0.451,0.407,0.901,0.814,1.35,1.225c0.951,0.87,1.894,1.749,2.83,2.634 c0.469,0.443,0.937,0.888,1.401,1.335c0.914,0.878,1.821,1.764,2.721,2.657c0.464,0.46,0.926,0.923,1.386,1.388 c0.895,0.902,1.783,1.811,2.663,2.727c0.441,0.459,0.879,0.922,1.315,1.385c4.757,5.035,9.297,10.277,13.602,15.714 c0.702,0.886,1.391,1.784,2.081,2.681c1.49,1.938,2.954,3.899,4.385,5.884c0.339,0.469,0.684,0.935,1.019,1.406 c0.95,1.339,1.886,2.691,2.809,4.051c0.212,0.312,0.421,0.625,0.632,0.937c8.911,13.263,16.505,27.481,22.618,42.462h-14.649 h-1.601h-27.732v29.335h-30.932v-30.136v-0.8h29.334v-27.733v-0.8v-0.801v-27.732h-27.733v29.333h-29.341h-1.602H341.61v-29.333 h-27.737v29.333h-30.93v-29.333h-27.737v29.333h-29.333v27.733h29.333v30.936H224.27v-29.335h-27.732v29.335h-30.934v-29.335 h-27.732v27.735v1.6v29.334h-30.94v-29.334v-0.8v-0.8v-27.735v-0.801v-0.8v-27.733v-0.8v-0.801v-27.732H77.606V100.5 C78.43,99.556,79.263,98.619,80.102,97.688z M372.534,311.717v30.934h-29.326h-1.6H312.27v-29.332h-29.326v-29.34h-29.339v-29.325 H224.27v-30.138v-0.8h30.934v29.336h27.737v-28.536v-0.8h30.93v29.336v1.602v27.726h27.737v-28.528v-0.799h30.926v30.927h-29.326 v27.736H372.534z M341.608,225.317v-29.334v-0.8v-0.8v-28.536v-0.8h30.926v29.336v1.6v29.334H341.608z M79.207,165.047v30.936 h-30.94v-30.136v-0.8H79.207z M19.342,256c0-8.071,0.407-16.046,1.196-23.909v20.959h27.726v-28.536v-0.8h30.94v29.336v1.602 v27.726v1.601v29.338H49.867h-1.601h-21.92C21.78,294.962,19.342,275.768,19.342,256z\"/> </g>";
                                    datamatrixIconContainer.Controls.Add(datamatrixIcon);
                                }
                                datamatrixContainer.Controls.Add(datamatrixIconContainer);
                            }
                            using (HtmlGenericControl datamatrixTitle = new HtmlGenericControl("span"))
                            {
                                datamatrixTitle.Attributes["class"] = "symbology_name";
                                datamatrixTitle.InnerHtml = "Data Matrix";
                                datamatrixContainer.Controls.Add(datamatrixTitle);
                            }
                            using (HtmlGenericControl datamatrixCheckboxContainer = new HtmlGenericControl("div"))
                            {
                                datamatrixCheckboxContainer.Attributes["class"] = "checkbox";
                                using (HtmlInputCheckBox datamatrixCheckbox = new HtmlInputCheckBox())
                                {
                                    datamatrixCheckbox.ID = "chk-datamatrix";
                                    datamatrixCheckbox.Name = "datamatrix";
                                    datamatrixCheckbox.Checked = true;
                                    datamatrixCheckboxContainer.Controls.Add(datamatrixCheckbox);
                                }
                                datamatrixContainer.Controls.Add(datamatrixCheckboxContainer);
                            }
                            symbologiesContainer.Controls.Add(datamatrixContainer);
                        }
                        // PDF417
                        using (HtmlGenericControl pdf147Container = new HtmlGenericControl("div"))
                        {
                            pdf147Container.ID = "pdf417Container" + DocuVieware1.UniqueID;
                            pdf147Container.Attributes["class"] = "symbology";
                            pdf147Container.Attributes["title"] = "Detect PDF417 Barcodes";

                            using (HtmlGenericControl pdf147IconContainer = new HtmlGenericControl("div"))
                            {
                                pdf147IconContainer.Attributes["class"] = "icon";
                                using (HtmlGenericControl pdf147Icon = new HtmlGenericControl("svg"))
                                {
                                    pdf147Icon.Attributes["viewBox"] = "0 0 512 512";
                                    pdf147Icon.InnerHtml = "<g> <polygon fill=\"#2481C4\" points=\"311.947,273.922 311.947,273.122 330.083,273.122 330.083,256.6 330.083,255.8 330.083,255 330.083,238.478 330.083,237.677 330.083,236.876 330.083,220.354 313.549,220.354 313.549,236.876 313.549,238.478 313.549,256.6 295.426,256.6 295.426,273.122 295.426,274.723 295.426,291.244 311.947,291.244 \"/> <polygon fill=\"#2481C4\" points=\"330.083,292.846 313.549,292.846 313.549,310.98 295.426,310.98 295.426,327.496 313.549,327.496 313.549,347.227 295.426,347.227 295.426,363.748 295.426,365.35 295.426,381.877 311.947,381.877 311.947,364.549 311.947,363.748 331.684,363.748 331.684,381.877 348.205,381.877 348.205,365.35 348.205,364.549 348.205,363.748 348.205,347.227 330.083,347.227 330.083,328.297 330.083,327.496 348.205,327.496 348.205,310.98 348.205,310.182 348.205,309.38 348.205,292.846 331.684,292.846 \"/> <polygon fill=\"#2481C4\" points=\"295.426,418.116 295.426,419.717 295.426,436.245 311.947,436.245 311.947,419.717 311.947,418.917 311.947,418.116 311.947,401.602 295.426,401.602 \"/> <polygon fill=\"#2481C4\" points=\"259.177,55.625 259.177,57.226 259.177,73.76 275.714,73.76 275.714,57.226 275.714,56.425 275.714,55.625 275.714,39.103 259.177,39.103 \"/> <rect x=\"313.549\" y=\"383.479\" fill=\"#2481C4\" width=\"16.534\" height=\"16.521\"/> <rect x=\"277.314\" y=\"292.846\" fill=\"#2481C4\" width=\"16.51\" height=\"16.534\"/> <rect x=\"331.684\" y=\"184.104\" fill=\"#2481C4\" width=\"16.521\" height=\"16.515\"/> <rect x=\"313.549\" y=\"165.974\" fill=\"#2481C4\" width=\"16.534\" height=\"16.528\"/> <polygon fill=\"#2481C4\" points=\"330.083,75.361 313.549,75.361 313.549,93.483 295.426,93.483 295.426,109.999 313.549,109.999 313.549,129.723 295.426,129.723 295.426,146.251 295.426,147.852 295.426,164.374 311.947,164.374 311.947,147.051 311.947,146.251 331.684,146.251 331.684,164.374 348.205,164.374 348.205,147.852 348.205,147.051 348.205,146.251 348.205,129.723 330.083,129.723 330.083,110.8 330.083,109.999 348.205,109.999 348.205,93.483 348.205,92.683 348.205,91.882 348.205,75.361 331.684,75.361 \"/> <rect x=\"277.314\" y=\"75.361\" fill=\"#2481C4\" width=\"16.51\" height=\"16.521\"/> <rect x=\"259.177\" y=\"347.227\" fill=\"#2481C4\" width=\"16.537\" height=\"16.521\"/> <rect x=\"259.177\" y=\"419.717\" fill=\"#2481C4\" width=\"16.537\" height=\"16.528\"/> <rect x=\"259.177\" y=\"93.483\" fill=\"#2481C4\" width=\"16.537\" height=\"16.516\"/> <rect x=\"259.177\" y=\"310.98\" fill=\"#2481C4\" width=\"16.537\" height=\"16.516\"/> <rect x=\"259.177\" y=\"129.723\" fill=\"#2481C4\" width=\"16.537\" height=\"16.528\"/> <rect x=\"259.177\" y=\"202.22\" fill=\"#2481C4\" width=\"16.537\" height=\"16.534\"/> <polygon fill=\"#2481C4\" points=\"259.177,273.122 259.177,274.723 259.177,291.244 275.714,291.244 275.714,274.723 275.714,273.922 275.714,273.122 275.714,256.6 259.177,256.6 \"/> <rect x=\"331.684\" y=\"401.602\" fill=\"#2481C4\" width=\"16.521\" height=\"16.516\"/> <rect x=\"367.929\" y=\"401.602\" fill=\"#2481C4\" width=\"16.522\" height=\"16.516\"/> <rect x=\"349.807\" y=\"383.479\" fill=\"#2481C4\" width=\"16.521\" height=\"16.521\"/> <rect x=\"367.929\" y=\"184.104\" fill=\"#2481C4\" width=\"16.522\" height=\"16.515\"/> <rect x=\"349.807\" y=\"165.974\" fill=\"#2481C4\" width=\"16.521\" height=\"16.528\"/> <polygon fill=\"#2481C4\" points=\"367.929,146.251 367.929,147.852 367.929,164.374 386.052,164.374 386.052,182.502 402.586,182.502 404.188,182.502 420.709,182.502 420.709,165.974 402.586,165.974 402.586,147.051 402.586,146.251 420.709,146.251 420.709,129.723 404.188,129.723 402.586,129.723 384.451,129.723 384.451,111.6 367.929,111.6 366.328,111.6 349.807,111.6 349.807,128.122 367.929,128.122 \"/> <polygon fill=\"#2481C4\" points=\"366.328,238.478 366.328,237.677 366.328,236.876 366.328,220.354 349.807,220.354 349.807,236.876 349.807,238.478 349.807,255 366.328,255 \"/> <polygon fill=\"#2481C4\" points=\"440.432,255 456.954,255 456.954,238.478 456.954,237.677 456.954,236.876 456.954,220.354 440.432,220.354 438.832,220.354 422.31,220.354 422.31,236.876 440.432,236.876 \"/> <polygon fill=\"#2481C4\" points=\"402.586,347.227 384.451,347.227 384.451,329.098 367.929,329.098 366.328,329.098 349.807,329.098 349.807,345.625 367.929,345.625 367.929,363.748 367.929,365.35 367.929,381.877 386.052,381.877 386.052,400 402.586,400 404.188,400 420.709,400 420.709,383.479 402.586,383.479 402.586,364.549 402.586,363.748 420.709,363.748 420.709,347.227 404.188,347.227 \"/> <polygon fill=\"#2481C4\" points=\"456.954,310.98 440.432,310.98 438.832,310.98 422.31,310.98 420.709,310.98 402.586,310.98 402.586,292.846 386.052,292.846 386.052,309.38 386.052,310.98 386.052,327.496 402.586,327.496 404.188,327.496 420.709,327.496 422.31,327.496 440.432,327.496 440.432,345.625 456.954,345.625 456.954,328.297 456.954,327.496 475.077,327.496 475.077,310.98 458.555,310.98 \"/> <rect x=\"422.31\" y=\"274.723\" fill=\"#2481C4\" width=\"16.522\" height=\"16.521\"/> <rect x=\"404.188\" y=\"202.22\" fill=\"#2481C4\" width=\"16.521\" height=\"16.534\"/> <polygon fill=\"#2481C4\" points=\"402.586,256.6 386.052,256.6 386.052,273.122 402.586,273.122 404.188,273.122 420.709,273.122 420.709,256.6 404.188,256.6 \"/> <polygon fill=\"#2481C4\" points=\"311.947,202.22 311.947,201.419 311.947,200.619 311.947,184.104 295.426,184.104 295.426,200.619 295.426,202.22 295.426,218.754 311.947,218.754 \"/> <path fill=\"#2481C4\" d=\"M509.663,291.244c1.584-11.516,2.422-23.27,2.422-35.219c0-5.899-0.218-11.748-0.61-17.547h-0.083 c-0.873-12.906-2.702-25.548-5.417-37.859h0.08c-4.062-18.413-10.104-36.078-17.896-52.767h-0.078 c-6.198-13.277-13.5-25.934-21.791-37.853h0.077c-3.947-5.674-8.107-11.189-12.489-16.516h-0.076 c-5.665-6.887-11.689-13.466-18.033-19.723h0.073c-4.359-4.301-8.874-8.447-13.532-12.428v0.06 c-2.147-1.837-4.328-3.637-6.536-5.404c-0.15-0.12-0.298-0.244-0.448-0.363h0.066c-6.734-5.361-13.76-10.368-21.023-15.04 c-0.186-0.12-0.37-0.242-0.557-0.361c-0.579-0.37-1.147-0.755-1.729-1.121h-0.049h-0.002h-0.015c-0.001,0-0.001,0-0.002-0.001 h0.018c-0.238-0.15-0.482-0.29-0.721-0.439c-1.549-0.966-3.107-1.917-4.678-2.851c-0.542-0.323-1.085-0.645-1.629-0.963 c-1.4-0.819-2.812-1.622-4.229-2.415c-0.673-0.377-1.342-0.757-2.018-1.128c-1.282-0.702-2.576-1.385-3.871-2.065 c-0.939-0.495-1.877-0.992-2.823-1.475c-1.691-0.862-3.391-1.71-5.104-2.535c-0.212-0.103-0.42-0.212-0.633-0.314v-0.011 c-5.399-2.581-10.9-4.984-16.501-7.189c-0.007-0.002-0.014-0.005-0.021-0.007v0c0.008,0.002,0.015,0.005,0.021,0.008 c-0.364-0.144-0.733-0.276-1.099-0.418c-1.275-0.496-2.553-0.989-3.839-1.463C317.184,5.57,287.219-0.044,255.94-0.044 C114.548-0.044-0.085,114.583-0.085,255.975c0,111.325,71.053,206.04,170.274,241.302c1.227,0.44,2.458,0.872,3.694,1.291 c4.218,1.427,8.489,2.736,12.802,3.946v0.01c9.829,2.761,19.905,4.926,30.176,6.501c0.076,0.012,0.152,0.023,0.228,0.035 c1.996,0.305,4,0.583,6.01,0.842c0.158,0.02,0.314,0.041,0.472,0.061c1.97,0.25,3.947,0.475,5.931,0.679 c0.184,0.019,0.368,0.038,0.552,0.057c1.993,0.201,3.992,0.378,5.998,0.533c0.153,0.012,0.306,0.023,0.459,0.035 c0.981,0.074,1.958,0.164,2.942,0.228v-0.035c-0.145-0.009-0.288-0.023-0.433-0.033c0.023,0.002,0.047,0.003,0.071,0.005 c0.121,0.008,0.24,0.02,0.361,0.027v0.001c0.278,0.018,0.557,0.03,0.835,0.047c1.507,0.092,3.017,0.172,4.531,0.236 c1.207,0.054,2.416,0.102,3.627,0.139c0.62,0.018,1.241,0.033,1.862,0.047c1.873,0.044,3.749,0.074,5.631,0.074 c1.998,0,3.989-0.029,5.975-0.077c0.971-0.021,1.938-0.06,2.907-0.093c0.876-0.03,1.752-0.06,2.626-0.1 c1.369-0.061,2.734-0.134,4.099-0.216c0.33-0.021,0.66-0.042,0.99-0.062c1.596-0.103,3.188-0.213,4.776-0.344v0.05 c2.744-0.227,5.474-0.499,8.191-0.812h-0.447c3.943-0.445,7.859-0.977,11.746-1.6h0.34c4.983-0.804,9.92-1.751,14.804-2.838v-0.061 c26.483-5.904,51.416-15.911,74.104-29.32v0.091c1.401-0.827,2.797-1.664,4.182-2.519h-0.149 c11.361-6.999,22.133-14.86,32.226-23.494v0.111c4.82-4.12,9.488-8.413,13.989-12.875h-0.125 c11.665-11.559,22.224-24.229,31.504-37.845h0.111c7.474-10.969,14.11-22.55,19.833-34.65h-0.103 c2.623-5.543,5.054-11.195,7.281-16.948v0.259c0.186-0.477,0.363-0.956,0.545-1.434h-0.099 c6.79-17.795,11.649-36.539,14.327-55.982H509.663z M462.647,371.394c-0.003,0.007-0.007,0.013-0.01,0.019 c1.033-1.85,2.045-3.714,3.032-5.592c-0.001,0.001-0.001,0.001-0.001,0.002C464.685,367.693,463.678,369.551,462.647,371.394z M473.94,348.393c-0.479,1.129-0.978,2.247-1.474,3.367c-0.332,0.748-0.659,1.499-0.999,2.243 c-0.367,0.807-0.748,1.606-1.124,2.408c-0.493,1.048-0.984,2.095-1.492,3.134c-0.263,0.54-0.534,1.076-0.802,1.613 c-0.643,1.291-1.29,2.579-1.955,3.855c-0.058,0.112-0.118,0.224-0.177,0.336h-7.363v13.09c1.225-2.017,2.411-4.059,3.574-6.117 c-0.004,0.006-0.007,0.011-0.01,0.017c-1.159,2.053-2.343,4.09-3.564,6.103c-1.026,1.692-2.071,3.373-3.14,5.037h-14.982V400h3.347 c-7.059,9.184-14.77,17.835-23.069,25.888v-6.171h-16.522v16.528h5.133c-9.794,8.347-20.276,15.905-31.345,22.589 c-0.441,0.266-0.889,0.524-1.333,0.788c-1.247,0.742-2.501,1.476-3.763,2.194c-0.823,0.469-1.652,0.929-2.482,1.388 c-0.855,0.476-1.715,0.945-2.577,1.41c-0.495,0.266-0.994,0.524-1.491,0.787v-9.419v-0.801h-0.001v-0.801v-16.535h-16.521v16.535 v1.602v16.521h1.869c-7.024,3.109-14.229,5.885-21.593,8.311v-6.71v-0.801v-0.8v-16.521v-0.801v-0.801v-16.535h-16.534v16.535 v1.602v18.122h-18.123v15.266c-6.485,1.088-13.059,1.916-19.712,2.464v-0.408v-0.8v-16.522h-16.537v16.522v1.601v0.392 c-1.059,0.014-2.114,0.04-3.176,0.04c-5.564,0-11.079-0.207-16.546-0.585v-0.647v-0.8v-16.522v-0.8v-0.8v-16.521v-0.801v-0.801 v-16.535v-0.8v-0.801v-16.528v-0.8v-0.801v-16.515V400.8V400v-16.521v-0.801v-0.801V365.35v-0.801v-0.801v-16.521v-0.801v-0.801 v-16.527v-0.801v-0.801V310.98v-0.801v-0.801v-16.533v-0.802v-0.801v-16.521v-0.802v-0.8V256.6v-0.8V255v-16.522v-0.8v-0.801 v-16.522v-0.8v-0.801V202.22v-0.801v-0.801v-16.515v-0.801v-0.8v-16.528v-0.8v-0.8v-16.522v-0.801v-0.8v-16.528v-0.801v-0.8V111.6 v-0.8v-0.801V93.483v-0.8v-0.801V75.361v-0.8V73.76V57.226v-0.801v-0.8V39.103v-0.801v-0.8V20.974v-0.8v-0.247 c5.468-0.378,10.982-0.585,16.546-0.585c19.85,0,39.125,2.458,57.548,7.061v12.7h-18.123v16.521v1.601V73.76h16.521V56.425v-0.8 h18.136V39.103v-0.801v-0.8v-6.316c22.563,7.431,43.632,18.153,62.625,31.617c0.153,0.11,0.31,0.218,0.463,0.328 c1.354,0.965,2.697,1.947,4.03,2.939c0.38,0.283,0.757,0.57,1.135,0.855c1.255,0.946,2.507,1.898,3.742,2.869 c0.161,0.126,0.318,0.257,0.479,0.384c2.207,1.743,4.375,3.532,6.517,5.351c0.764,0.648,1.53,1.293,2.285,1.952 c0.822,0.716,1.634,1.444,2.446,2.171c0.865,0.776,1.726,1.556,2.58,2.344c0.727,0.67,1.451,1.341,2.17,2.02 c1.059,1.002,2.104,2.017,3.145,3.038c0.504,0.494,1.016,0.98,1.515,1.479c1.503,1.501,2.984,3.025,4.447,4.566 c0.121,0.128,0.238,0.258,0.359,0.386h-5.71h-1.602v-0.001h-18.123V75.361h-16.534v16.521v1.601v16.516h16.534h1.602h16.521h1.602 h18.121v18.123h14.731c4.101,6.373,7.902,12.956,11.389,19.729h-7.997v18.123h-18.123v16.528h16.522h1.601h16.522h1.601h4.327 c5.818,17.823,9.587,36.572,11.007,55.976h-15.334V255v1.602v16.521h15.359c-1.867,26.111-7.969,51.049-17.625,74.133 C474.254,347.635,474.101,348.016,473.94,348.393z M186.686,39.103v16.521v1.601V73.76v1.601v16.521v1.601v16.516v1.601v16.521 v1.601v16.528v1.601v16.522v1.601v16.528v1.601v16.515v1.602v16.534v1.601v16.522v1.601V255v1.602v16.521v1.602v16.521v1.603 v16.533v1.602v16.516v1.602v16.527v1.602v16.521v1.602v16.527v1.602V400v1.602v16.516v1.601v16.528v1.601v16.535v1.602v16.521 v1.601v8.229c-6.711-2.053-13.292-4.401-19.736-7.021v-1.207v-0.803v-0.8v-16.521v-0.801v-0.801v-16.535v-0.8v-0.801v-16.528v-0.8 v-0.801v-16.515V400.8V400v-16.521v-0.801v-0.801V365.35v-0.801v-0.801v-16.521v-0.801v-0.801v-16.527v-0.801v-0.801V310.98v-0.801 v-0.801v-16.533v-0.802v-0.801v-16.521v-0.802v-0.8V256.6v-0.8V255v-16.522v-0.8v-0.801v-16.522v-0.8v-0.801V202.22v-0.801v-0.801 v-16.515v-0.801v-0.8v-16.528v-0.8v-0.8v-16.522v-0.801v-0.8v-16.528v-0.801v-0.8V111.6v-0.8v-0.801V93.483v-0.8v-0.801V75.361 v-0.8V73.76V57.226v-0.801v-0.8V39.103v-0.801v-0.8v-0.816c6.443-2.619,13.024-4.967,19.736-7.02v7.836V39.103z M114.183,75.361 v16.521v1.601v16.516v1.601v16.521v1.601v16.528v1.601v16.522v1.601v16.528v1.601v16.515v1.602v16.534v1.601v16.522v1.601V255 v1.602v16.521v1.602v16.521v1.603v16.533v1.602v16.516v1.602v16.527v1.602v16.521v1.602v16.527v1.602V400v1.602v16.516v1.601 v16.528v1.601v7.627c-6.879-5.158-13.459-10.69-19.73-16.551v-9.206v-0.8v-0.801v-16.516V400.8V400v-16.521v-0.801v-0.801V365.35 v-0.801v-0.801v-16.521v-0.801v-0.801v-16.527v-0.801v-0.801V310.98v-0.801v-0.801v-16.533v-0.802v-0.801v-16.521v-0.802v-0.8 V256.6v-0.8V255v-16.522v-0.8v-0.801v-16.522v-0.8v-0.801V202.22v-0.801v-0.801v-16.515v-0.801v-0.8v-16.528v-0.8v-0.8v-16.522 v-0.801v-0.8v-16.528v-0.801v-0.8V111.6v-0.8v-0.801V93.483v-0.8v-0.801v-8.805c6.271-5.86,12.851-11.393,19.73-16.551v7.233 V75.361z M77.937,411.873C41.46,370.236,19.342,315.704,19.342,256S41.46,141.763,77.937,100.127v9.872v1.601v16.521v1.601v16.528 v1.601v16.522v1.601v16.528v1.601v16.515v1.602v16.534v1.601v16.522v1.601V255v1.602v16.521v1.602v16.521v1.603v16.533v1.602 v16.516v1.602v16.527v1.602v16.521v1.602v16.527v1.602V400v1.602V411.873z M130.711,456.79v-0.807v-0.802v-0.801v-16.535v-0.8 v-0.801v-16.528v-0.8v-0.801v-16.515V400.8V400v-16.521v-0.801v-0.801V365.35v-0.801v-0.801v-16.521v-0.801v-0.801v-16.527v-0.801 v-0.801V310.98v-0.801v-0.801v-16.533v-0.802v-0.801v-16.521v-0.802v-0.8V256.6v-0.8V255v-16.522v-0.8v-0.801v-16.522v-0.8v-0.801 V202.22v-0.801v-0.801v-16.515v-0.801v-0.8v-16.528v-0.8v-0.8v-16.522v-0.801v-0.8v-16.528v-0.801v-0.8V111.6v-0.8v-0.801V93.483 v-0.8v-0.801V75.361v-0.8V73.76V57.226v-0.801v-0.8V55.21c6.378-3.988,12.958-7.68,19.724-11.058v11.473v1.601V73.76v1.601v16.521 v1.601v16.516v1.601v16.521v1.601v16.528v1.601v16.522v1.601v16.528v1.601v16.515v1.602v16.534v1.601v16.522v1.601V255v1.602 v16.521v1.602v16.521v1.603v16.533v1.602v16.516v1.602v16.527v1.602v16.521v1.602v16.527v1.602V400v1.602v16.516v1.601v16.528 v1.601v16.535v1.602v11.864C143.669,464.47,137.089,460.778,130.711,456.79z M330.083,10.886c-1.118-0.337-2.241-0.663-3.364-0.985 c-0.117-0.034-0.233-0.071-0.351-0.104c1.241,0.355,2.48,0.715,3.715,1.087V10.886z M320.475,8.194 c-0.045-0.012-0.09-0.025-0.134-0.037c1.901,0.494,3.797,1.002,5.682,1.538c-0.071-0.021-0.145-0.039-0.216-0.059 C324.037,9.135,322.259,8.658,320.475,8.194z M319.62,7.972c-0.046-0.012-0.093-0.022-0.14-0.034 c-1.969-0.504-3.943-0.993-5.932-1.449V6.487C315.584,6.954,317.605,7.455,319.62,7.972z M208.049,507.497 c0.002,0,0.003,0,0.005,0.001c-0.671-0.127-1.348-0.239-2.017-0.371C206.705,507.259,207.379,507.37,208.049,507.497z M211.842,508.193c0.002,0,0.004,0.001,0.006,0.001c0.757,0.131,1.519,0.253,2.278,0.378c0.005,0.001,0.011,0.002,0.017,0.002 C213.375,508.449,212.607,508.326,211.842,508.193z M218.56,509.267c0.004,0.001,0.009,0.001,0.014,0.002 c0.59,0.086,1.182,0.166,1.774,0.248c0.009,0.001,0.018,0.003,0.026,0.004C219.769,509.437,219.164,509.354,218.56,509.267z M225.348,510.166c0.008,0.001,0.015,0.002,0.023,0.003c0.445,0.053,0.89,0.103,1.335,0.152c0.012,0.002,0.024,0.003,0.037,0.005 C226.278,510.273,225.812,510.222,225.348,510.166z M233.255,510.982c-0.36-0.031-0.72-0.062-1.08-0.096 c0.015,0.002,0.03,0.003,0.045,0.004c0.326,0.03,0.651,0.059,0.977,0.087C233.217,510.979,233.236,510.981,233.255,510.982z\"/> </g> <polygon fill=\"#2481C4\" points=\"239.454,495.626 187.5,490.626 187.5,22.5 239.454,15.5 \"/>";
                                    pdf147IconContainer.Controls.Add(pdf147Icon);
                                }
                                pdf147Container.Controls.Add(pdf147IconContainer);
                            }
                            using (HtmlGenericControl pdf147Title = new HtmlGenericControl("span"))
                            {
                                pdf147Title.Attributes["class"] = "symbology_name";
                                pdf147Title.InnerHtml = "PDF147";
                                pdf147Container.Controls.Add(pdf147Title);
                            }
                            using (HtmlGenericControl pdf147CheckboxContainer = new HtmlGenericControl("div"))
                            {
                                pdf147CheckboxContainer.Attributes["class"] = "checkbox";
                                using (HtmlInputCheckBox pdf147Checkbox = new HtmlInputCheckBox())
                                {
                                    pdf147Checkbox.ID = "chk-pdf417";
                                    pdf147Checkbox.Name = "pdf417";
                                    pdf147Checkbox.Checked = true;
                                    pdf147CheckboxContainer.Controls.Add(pdf147Checkbox);
                                }
                                pdf147Container.Controls.Add(pdf147CheckboxContainer);
                            }
                            symbologiesContainer.Controls.Add(pdf147Container);
                        }
                        // Aztec
                        using (HtmlGenericControl aztecContainer = new HtmlGenericControl("div"))
                        {
                            aztecContainer.ID = "aztecContainer" + DocuVieware1.UniqueID;
                            aztecContainer.Attributes["class"] = "symbology";
                            aztecContainer.Attributes["title"] = "Detect Aztec Barcodes";

                            using (HtmlGenericControl aztecIconContainer = new HtmlGenericControl("div"))
                            {
                                aztecIconContainer.Attributes["class"] = "icon";
                                using (HtmlGenericControl aztecIcon = new HtmlGenericControl("svg"))
                                {
                                    aztecIcon.Attributes["viewBox"] = "0 0 512 512";
                                    aztecIcon.Attributes["fill"] = "#2481C4";
                                    aztecIcon.InnerHtml = "<path d=\"M256 20c31.9 0 62.8 6.2 91.9 18.5 28.1 11.9 53.3 28.9 75 50.6 21.7 21.7 38.7 46.9 50.6 75 12.3 29.1 18.5 60 18.5 91.9s-6.2 62.8-18.5 91.9c-11.9 28.1-28.9 53.3-50.6 75-21.7 21.7-46.9 38.7-75 50.6-29.1 12.3-60 18.5-91.9 18.5s-62.8-6.2-91.9-18.5c-28.1-11.9-53.3-28.9-75-50.6-21.7-21.7-38.7-46.9-50.6-75C26.2 318.8 20 287.9 20 256s6.2-62.8 18.5-91.9c11.9-28.1 28.9-53.3 50.6-75 21.7-21.7 46.9-38.7 75-50.6C193.2 26.2 224.1 20 256 20m0-20C114.6 0 0 114.6 0 256s114.6 256 256 256 256-114.6 256-256S397.4 0 256 0z\"/><path d=\"M243.3 245.7h25.3V271h-25.3z\"/><path d=\"M268.7 195h-76v126.6H319.3V195h-50.6zm25.3 50.7v50.6h-76v-75.9h76v25.3zM66 220.3h25.3V195H40.7v-44.2c-3.1 6.2-5.9 12.5-8.5 18.9-3.3 8.2-6.1 16.7-8.4 25.3-2.3 8.3-4.1 16.7-5.4 25.3h22.3V271H66v-50.7zM18.3 296.3h22.3V271h-25c.5 8.6 1.4 17 2.7 25.3zM91.3 271H66v50.6H23.8c2.4 8.6 5.2 17.1 8.4 25.3h8.5v18.9c1.1 2.2 2.2 4.3 3.3 6.4h22v25.3h25.3v-25.3h25.3v-50.5H91.3v-25.3h25.3V271H91.3zM167.3 397.7H142V423H80.5c3.5 3.7 7.1 7.3 10.8 10.8 5.4 5.1 11.1 9.9 17 14.5H142V423h25.3v-25.3zM167.3 423h25.3v25.3h-25.3zM218 423h25.3v25.3H218zM167.3 473.7v8.5c8.2 3.3 16.7 6.1 25.3 8.4 8.3 2.3 16.7 4.1 25.3 5.4v-22.3h-50.6zM446 321.7h25.3V347H446zM167.3 34.5c-6.4 2.6-12.7 5.4-18.9 8.5-2.2 1.1-4.3 2.2-6.4 3.3v22h25.3V34.5z\"/><path d=\"M471.3 271v-25.3H446V195h25.3v-44.2c-1.1-2.2-2.2-4.3-3.3-6.4h-22v-33.8c-4.6-5.9-9.4-11.5-14.5-17-3.5-3.7-7.1-7.3-10.8-10.8-5.4-5.1-11.1-9.9-16.9-14.5h-8.4v25.3h25.3v50.7H446V195h-76v-25.3h25.3V119H370v25.3h-25.3V119h-25.3V93.7H370V68.3h25.3V62c-8.1-5.8-16.5-11-25.3-15.7-2.1-1.1-4.3-2.3-6.4-3.3h-44.2V26.1c-8.3-2.3-16.7-4.1-25.3-5.4-8.3-1.3-16.8-2.2-25.3-2.7v25h-25.3v25.3H218V20.7c-8.6 1.4-17.1 3.2-25.3 5.4v42.2h-25.3v25.3H142V119h-25.3v25.3H91.3V119h25.3V93.7H91.3V82.8c-3.7 3.5-7.3 7.1-10.8 10.8h10.8V119H59.7c-5.8 8.1-11 16.5-15.7 25.3h47.3v25.3h25.3v50.7H142v25.3h-25.3V271H142v101.3h50.6v25.3H218v-25.3h25.3V423h25.3v25.3H294V423h25.3v-25.3h25.3v-25.3h76V347h-25.3v-25.3h25.3v-25.3h-25.3v25.3H370V271h50.6v25.3h73c1.3-8.3 2.2-16.8 2.7-25.3h-25zM268.7 68.3H294V43h25.3v25.3H294v25.3h-25.3V68.3zm50.6 50.7v25.3H294V119h25.3zM218 119h25.3V93.7h25.3V119h-25.3v25.3H218V119zm-50.7 0h25.3V93.7H218V119h-25.3v25.3h-25.3V119zM294 397.7h-25.3v-25.3H294v25.3zM344.7 195v152H167.4V169.7H344.6V195zm76 50.7h-25.3v-25.3h25.3v25.3zM420.7 372.3H446v25.3h-25.3z\"/><path d=\"M370 397.7h-25.3v75.9h18.9c2.2-1.1 4.3-2.2 6.4-3.3V423h25.3v25.3h8.4c5.9-4.6 11.5-9.4 17-14.5v-36.1H370zM319.3 473.7H294V496c8.6-1.4 17.1-3.2 25.3-5.4 8.6-2.4 17.1-5.2 25.3-8.4v-8.5h-25.3z\"/>";
                                    aztecIconContainer.Controls.Add(aztecIcon);
                                }
                                aztecContainer.Controls.Add(aztecIconContainer);
                            }
                            using (HtmlGenericControl aztecTitle = new HtmlGenericControl("span"))
                            {
                                aztecTitle.Attributes["class"] = "symbology_name";
                                aztecTitle.InnerHtml = "Aztec";
                                aztecContainer.Controls.Add(aztecTitle);
                            }
                            using (HtmlGenericControl aztecCheckboxContainer = new HtmlGenericControl("div"))
                            {
                                aztecCheckboxContainer.Attributes["class"] = "checkbox";
                                using (HtmlInputCheckBox aztecCheckbox = new HtmlInputCheckBox())
                                {
                                    aztecCheckbox.ID = "chk-aztec";
                                    aztecCheckbox.Name = "aztec";
                                    aztecCheckbox.Checked = true;
                                    aztecCheckboxContainer.Controls.Add(aztecCheckbox);
                                }
                                aztecContainer.Controls.Add(aztecCheckboxContainer);
                            }
                            symbologiesContainer.Controls.Add(aztecContainer);
                        }
                        // MaxiCode
                        using (HtmlGenericControl maxiCodeContainer = new HtmlGenericControl("div"))
                        {
                            maxiCodeContainer.ID = "maxicodeContainer" + DocuVieware1.UniqueID;
                            maxiCodeContainer.Attributes["class"] = "symbology";
                            maxiCodeContainer.Attributes["title"] = "Detect Maxi Code Barcodes";

                            using (HtmlGenericControl maxiCodeIconContainer = new HtmlGenericControl("div"))
                            {
                                maxiCodeIconContainer.Attributes["class"] = "icon";
                                using (HtmlGenericControl maxiCodeIcon = new HtmlGenericControl("svg"))
                                {
                                    maxiCodeIcon.Attributes["viewBox"] = "0 0 512 512";
                                    maxiCodeIcon.Attributes["fill"] = "#2481c4";
                                    maxiCodeIcon.InnerHtml = "<path style=\"fill:#2481c4\" d=\"M256 20c31.9 0 62.8 6.2 91.9 18.5 28.1 11.9 53.3 28.9 75 50.6s38.7 46.9 50.6 75c12.3 29.1 18.5 60 18.5 91.9s-6.2 62.8-18.5 91.9c-11.9 28.1-28.9 53.3-50.6 75s-46.9 38.7-75 50.6c-29.1 12.3-60 18.5-91.9 18.5s-62.8-6.2-91.9-18.5c-28.1-11.9-53.3-28.9-75-50.6s-38.7-46.9-50.6-75C26.2 318.8 20 287.9 20 256s6.2-62.8 18.5-91.9c11.9-28.1 28.9-53.3 50.6-75s46.9-38.7 75-50.6C193.2 26.2 224.1 20 256 20m0-20C114.6 0 0 114.6 0 256s114.6 256 256 256 256-114.6 256-256S397.4 0 256 0z\"/><path style=\"fill:#2481c4\" d=\"M247.4 180.1c41.9 0 75.9 34 75.9 75.9 0 41.9-34 75.9-75.9 75.9-41.9 0-75.9-34-75.9-75.9 0-41.9 34-75.9 75.9-75.9zm0 13.2c-34.6 0-62.7 28.1-62.7 62.8 0 34.6 28.1 62.7 62.7 62.7s62.7-28.1 62.7-62.8c0-34.7-28.1-62.7-62.7-62.7z\"/><path style=\"fill:#2481c4\" d=\"M247.4 206.4c27.4 0 49.6 22.2 49.6 49.6 0 27.4-22.2 49.6-49.6 49.6-27.4 0-49.6-22.2-49.6-49.6 0-27.4 22.2-49.6 49.6-49.6zm0 13.1c-20.1 0-36.5 16.3-36.5 36.5 0 20.1 16.3 36.5 36.5 36.5 20.1 0 36.5-16.3 36.5-36.5-.1-20.1-16.4-36.5-36.5-36.5z\"/><path style=\"fill:#2481c4\" d=\"M247.4 232.9c12.8 0 23.1 10.4 23.1 23.1 0 12.8-10.4 23.1-23.1 23.1-12.8 0-23.1-10.4-23.1-23.1 0-12.8 10.3-23.1 23.1-23.1zm0 13.1c-5.5 0-10 4.5-10 10s4.5 10 10 10 10-4.5 10-10-4.5-10-10-10zM264.6 10.2l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM187 25.1l6.1 3.5v6.9L187 39l-6-3.5v-6.9zM204.3 25.1l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM221.5 25.1l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM238.8 25.1l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM143.9 40l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM161.2 40l6 3.5v7l-6 3.5-6-3.5v-7zM178.4 40l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM195.7 40l6 3.5v7l-6 3.5-6.1-3.5v-7zM212.9 40l6 3.5v7l-6 3.5-6-3.5v-7zM247.4 40l6 3.5v7l-6 3.5-6.1-3.5v-7zM281.9 40l6 3.5v7l-6 3.5-6.1-3.5v-7zM316.3 40l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM350.8 40l6 3.5v7l-6 3.5-6-3.5v-7zM135.3 54.9l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM169.8 54.9l6 3.5v7l-6 3.5-6-3.5v-7zM204.3 54.9l6 3.5v7l-6 3.5-6.1-3.5v-7zM238.8 54.9l6 3.5v7l-6 3.5-6.1-3.5v-7zM273.2 54.9l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM307.7 54.9l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM342.2 54.9l6 3.5v7l-6 3.5-6-3.5v-7zM376.7 54.9l6 3.5v7l-6 3.5-6.1-3.5v-7zM83.6 84.8l6 3.5v7l-6 3.4-6-3.4v-7zM118.1 84.8l6 3.5v7l-6 3.4-6-3.4v-7zM152.6 84.8l6 3.5v7l-6 3.4-6.1-3.4v-7zM187 84.8l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM221.5 84.8l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM256 84.8l6 3.5v7l-6 3.4-6-3.4v-7zM290.5 84.8l6 3.5v7l-6 3.4-6.1-3.4v-7zM325 84.8l6 3.5v7l-6 3.4-6.1-3.4v-7zM359.4 84.8l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM393.9 84.8l6 3.5v7l-6 3.4-6-3.4v-7zM428.4 84.8l6 3.5v7l-6 3.4-6-3.4v-7zM92.2 99.7l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM126.7 99.7l6 3.5v7l-6 3.5-6-3.5v-7zM161.2 99.7l6 3.5v7l-6 3.5-6-3.5v-7zM195.7 99.7l6 3.5v7l-6 3.5-6.1-3.5v-7zM230.1 99.7l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM264.6 99.7l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM299.1 99.7l6 3.5v7l-6 3.5-6-3.5v-7zM333.6 99.7l6 3.5v7l-6 3.5-6.1-3.5v-7zM368.1 99.7l6 3.5v7l-6 3.5-6.1-3.5v-7zM402.5 99.7l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM437 99.7l6 3.5v7l-6 3.5-6-3.5v-7zM75 129.6l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM109.5 129.6l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM143.9 129.6l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM178.4 129.6l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM212.9 129.6l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM247.4 129.6l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM281.9 129.6l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM316.3 129.6l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM350.8 129.6l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM385.3 129.6l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM419.8 129.6l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM454.2 129.6l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM66.4 144.5l6 3.5v7l-6 3.5-6.1-3.5v-7zM100.8 144.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM135.3 144.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM169.8 144.5l6 3.5v7l-6 3.5-6-3.5v-7zM187 144.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM204.3 144.5l6 3.5v7l-6 3.5-6.1-3.5v-7zM221.5 144.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM342.2 144.5l6 3.5v7l-6 3.5-6-3.5v-7zM376.7 144.5l6 3.5v7l-6 3.5-6.1-3.5v-7zM411.2 144.5l6 3.5v7l-6 3.5-6.1-3.5v-7zM445.6 144.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM161.2 159.5l6 3.4v7l-6 3.5-6-3.5v-7zM178.4 159.5l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM195.7 159.5l6 3.4v7l-6 3.5-6.1-3.5v-7zM212.9 159.5l6 3.4v7l-6 3.5-6-3.5v-7zM247.4 159.5l6 3.4v7l-6 3.5-6.1-3.5v-7zM264.6 159.5l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM281.9 159.5l6 3.4v7l-6 3.5-6.1-3.5v-7zM350.8 159.5l6 3.4v7l-6 3.5-6-3.5v-7zM49.1 174.4l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM83.6 174.4l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM118.1 174.4l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM152.6 174.4l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM169.8 174.4l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM187 174.4l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM342.2 174.4l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM393.9 174.4l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM428.4 174.4l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM462.9 174.4l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM23.3 189.3l6 3.5v7l-6 3.4-6.1-3.4v-7zM57.8 189.3l6 3.5v7l-6 3.4-6.1-3.4v-7zM92.2 189.3l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM178.4 189.3l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM333.6 189.3l6 3.5v7l-6 3.4-6.1-3.4v-7zM350.8 189.3l6 3.5v7l-6 3.4-6-3.4v-7zM402.5 189.3l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM437 189.3l6 3.5v7l-6 3.4-6-3.4v-7zM471.5 189.3l6 3.5v7l-6 3.4-6-3.4v-7zM325 204.2l6 3.5v7l-6 3.5-6.1-3.5v-7zM342.2 204.2l6 3.5v7l-6 3.5-6-3.5v-7zM359.4 204.2l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM40.5 219.2l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM75 219.2l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM143.9 219.2l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM333.6 219.2l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM368.1 219.2l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM385.3 219.2l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM419.8 219.2l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM454.2 219.2l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM488.7 219.2l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM31.9 234.1l6 3.5v7l-6 3.4-6-3.4v-7zM66.4 234.1l6 3.5v7l-6 3.4-6.1-3.4v-7zM100.8 234.1l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM135.3 234.1l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM152.6 234.1l6 3.5v7l-6 3.4-6.1-3.4v-7zM411.2 234.1l6 3.5v7l-6 3.4-6.1-3.4v-7zM445.6 234.1l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM480.1 234.1l6 3.5v7l-6 3.4-6-3.4v-7zM109.5 249l6 3.5v7l-6 3.5-6.1-3.5v-7zM143.9 249l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM350.8 249l6 3.5v7l-6 3.5-6-3.5v-7zM488.7 249l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM49.1 264l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM83.6 264l6 3.4v7l-6 3.5-6-3.5v-7zM152.6 264l6 3.4v7l-6 3.5-6.1-3.5v-7zM359.4 264l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM393.9 264l6 3.4v7l-6 3.5-6-3.5v-7zM428.4 264l6 3.4v7l-6 3.5-6-3.5v-7zM462.9 264l6 3.4v7l-6 3.5-6.1-3.5v-7zM23.3 278.9l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM57.8 278.9l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM92.2 278.9l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM126.7 278.9l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM161.2 278.9l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM350.8 278.9l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM402.5 278.9l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM437 278.9l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM471.5 278.9l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM118.1 293.8l6 3.5v7l-6 3.5-6-3.5v-7zM325 293.8l6 3.5v7l-6 3.5-6.1-3.5v-7zM342.2 293.8l6 3.5v7l-6 3.5-6-3.5v-7zM359.4 293.8l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM40.5 308.8l6 3.4v7l-6 3.5-6-3.5v-7zM75 308.8l6 3.4v7l-6 3.5-6-3.5v-7zM109.5 308.8l6 3.4v7l-6 3.5-6.1-3.5v-7zM126.7 308.8l6 3.4v7l-6 3.5-6-3.5v-7zM143.9 308.8l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM161.2 308.8l6 3.4v7l-6 3.5-6-3.5v-7zM178.4 308.8l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM333.6 308.8l6 3.4v7l-6 3.5-6.1-3.5v-7zM350.8 308.8l6 3.4v7l-6 3.5-6-3.5v-7zM385.3 308.8l6 3.4v7l-6 3.5-6-3.5v-7zM419.8 308.8l6 3.4v7l-6 3.5-6.1-3.5v-7zM454.2 308.8l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM488.7 308.8l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM31.9 323.7l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM66.4 323.7l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM100.8 323.7l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM135.3 323.7l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM152.6 323.7l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM307.7 323.7l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM325 323.7l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM359.4 323.7l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM411.2 323.7l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM445.6 323.7l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM480.1 323.7l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM143.9 338.6l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM178.4 338.6l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM212.9 338.6l6 3.5v7l-6 3.4-6-3.4v-7zM230.1 338.6l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM247.4 338.6l6 3.5v7l-6 3.4-6.1-3.4v-7zM281.9 338.6l6 3.5v7l-6 3.4-6.1-3.4v-7zM299.1 338.6l6 3.5v7l-6 3.4-6-3.4v-7zM316.3 338.6l6.1 3.5v7l-6.1 3.4-6-3.4v-7zM333.6 338.6l6 3.5v7l-6 3.4-6.1-3.4v-7zM350.8 338.6l6 3.5v7l-6 3.4-6-3.4v-7zM368.1 338.6l6 3.5v7l-6 3.4-6.1-3.4v-7zM49.1 353.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM83.6 353.5l6 3.5v7l-6 3.5-6-3.5v-7zM118.1 353.5l6 3.5v7l-6 3.5-6-3.5v-7zM187 353.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM221.5 353.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM238.8 353.5l6 3.5v7l-6 3.5-6.1-3.5v-7zM256 353.5l6 3.5v7l-6 3.5-6-3.5v-7zM307.7 353.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM325 353.5l6 3.5v7l-6 3.5-6.1-3.5v-7zM342.2 353.5l6 3.5v7l-6 3.5-6-3.5v-7zM359.4 353.5l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM376.7 353.5l6 3.5v7l-6 3.5-6.1-3.5v-7zM393.9 353.5l6 3.5v7l-6 3.5-6-3.5v-7zM428.4 353.5l6 3.5v7l-6 3.5-6-3.5v-7zM462.9 353.5l6 3.5v7l-6 3.5-6.1-3.5v-7zM57.8 368.5l6 3.5v6.9l-6 3.5-6.1-3.5V372zM92.2 368.5l6.1 3.5v6.9l-6.1 3.5-6-3.5V372zM126.7 368.5l6 3.5v6.9l-6 3.5-6-3.5V372zM161.2 368.5l6 3.5v6.9l-6 3.5-6-3.5V372zM195.7 368.5l6 3.5v6.9l-6 3.5-6.1-3.5V372zM230.1 368.5l6.1 3.5v6.9l-6.1 3.5-6-3.5V372zM264.6 368.5l6.1 3.5v6.9l-6.1 3.5-6-3.5V372zM299.1 368.5l6 3.5v6.9l-6 3.5-6-3.5V372zM333.6 368.5l6 3.5v6.9l-6 3.5-6.1-3.5V372zM385.3 368.5l6 3.5v6.9l-6 3.5-6-3.5V372zM402.5 368.5l6.1 3.5v6.9l-6.1 3.5-6-3.5V372zM419.8 368.5l6 3.5v6.9l-6 3.5-6.1-3.5V372zM437 368.5l6 3.5v6.9l-6 3.5-6-3.5V372zM454.2 368.5l6.1 3.5v6.9l-6.1 3.5-6-3.5V372zM359.4 383.4l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM428.4 383.4l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM75 398.3l6 3.5v7l-6 3.5-6-3.5v-7zM109.5 398.3l6 3.5v7l-6 3.5-6.1-3.5v-7zM143.9 398.3l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM178.4 398.3l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM212.9 398.3l6 3.5v7l-6 3.5-6-3.5v-7zM247.4 398.3l6 3.5v7l-6 3.5-6.1-3.5v-7zM281.9 398.3l6 3.5v7l-6 3.5-6.1-3.5v-7zM316.3 398.3l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM368.1 398.3l6 3.5v7l-6 3.5-6.1-3.5v-7zM419.8 398.3l6 3.5v7l-6 3.5-6.1-3.5v-7zM135.3 413.3l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM152.6 413.3l6 3.4v7l-6 3.5-6.1-3.5v-7zM169.8 413.3l6 3.4v7l-6 3.5-6-3.5v-7zM187 413.3l6.1 3.4v7l-6.1 3.5-6-3.5v-7zM342.2 413.3l6 3.4v7l-6 3.5-6-3.5v-7zM411.2 413.3l6 3.4v7l-6 3.5-6.1-3.5v-7zM428.4 413.3l6 3.4v7l-6 3.5-6-3.5v-7zM126.7 428.2l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM143.9 428.2l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM178.4 428.2l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM230.1 428.2l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM247.4 428.2l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM333.6 428.2l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM350.8 428.2l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM368.1 428.2l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM169.8 443.1l6 3.5v7l-6 3.5-6-3.5v-7zM187 443.1l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM307.7 443.1l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM342.2 443.1l6 3.5v7l-6 3.5-6-3.5v-7zM359.4 443.1l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM376.7 443.1l6 3.5v7l-6 3.5-6.1-3.5v-7zM212.9 458l6 3.5v7l-6 3.5-6-3.5v-7zM247.4 458l6 3.5v7l-6 3.5-6.1-3.5v-7zM264.6 458l6.1 3.5v7l-6.1 3.5-6-3.5v-7zM299.1 458l6 3.5v7l-6 3.5-6-3.5v-7zM187 473l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM204.3 473l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM221.5 473l6.1 3.5v6.9l-6.1 3.5-6-3.5v-6.9zM238.8 473l6 3.5v6.9l-6 3.5-6.1-3.5v-6.9zM256 473l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM342.2 473l6 3.5v6.9l-6 3.5-6-3.5v-6.9zM247.4 487.9l6 3.5v7l-6 3.4-6.1-3.4v-7zM281.9 487.9l6 3.5v7l-6 3.4-6.1-3.4v-7z\"/>";
                                    maxiCodeIconContainer.Controls.Add(maxiCodeIcon);
                                }
                                maxiCodeContainer.Controls.Add(maxiCodeIconContainer);
                            }
                            using (HtmlGenericControl maxiCodeTitle = new HtmlGenericControl("span"))
                            {
                                maxiCodeTitle.Attributes["class"] = "symbology_name";
                                maxiCodeTitle.InnerHtml = "Maxi Code";
                                maxiCodeContainer.Controls.Add(maxiCodeTitle);
                            }
                            using (HtmlGenericControl maxiCodeCheckboxContainer = new HtmlGenericControl("div"))
                            {
                                maxiCodeCheckboxContainer.Attributes["class"] = "checkbox";
                                using (HtmlInputCheckBox maxiCodeCheckbox = new HtmlInputCheckBox())
                                {
                                    maxiCodeCheckbox.ID = "chk-maxicode";
                                    maxiCodeCheckbox.Name = "maxicode";
                                    maxiCodeCheckbox.Checked = true;
                                    maxiCodeCheckboxContainer.Controls.Add(maxiCodeCheckbox);
                                }
                                maxiCodeContainer.Controls.Add(maxiCodeCheckboxContainer);
                            }
                            symbologiesContainer.Controls.Add(maxiCodeContainer);
                        }
                        barcodesSnapInContainer.Controls.Add(symbologiesContainer);
                    }
                    using (HtmlGenericControl barcodeRecognitionButtonContainer = new HtmlGenericControl("div"))
                    {
                        barcodeRecognitionButtonContainer.ID = "recognitionButtonContainer";
                        using (HtmlGenericControl barcodeRecognitionButton = new HtmlGenericControl("button"))
                        {
                            barcodeRecognitionButton.ID = "barcodeRecognitionSubmit" + DocuVieware1.UniqueID;
                            barcodeRecognitionButton.InnerHtml = "Start";
                            barcodeRecognitionButton.Attributes["class"] = "btn-valid";
                            barcodeRecognitionButton.Style["background-color"] = ColorTranslator.ToHtml(DocuVieware1.ActiveSelectedColor);
                            barcodeRecognitionButton.Attributes["onclick"] = "barcodeRecognition(); return false;";
                            barcodeRecognitionButtonContainer.Controls.Add(barcodeRecognitionButton);
                        }
                        barcodesSnapInContainer.Controls.Add(barcodeRecognitionButtonContainer);
                    }
                    DocuVieware1.AddCustomSnapIn("barcodeRecognition", "Barcode Recognition", icon, barcodesSnapInContainer, true);
                }
            }
        }
    }
}