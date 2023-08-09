using GdPicture14;
using GdPicture14.Annotations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace barcode_recognition
{
    public partial class MainForm
    {
        private MainForm()
        {
            InitializeComponent();
        }

        private string _lastLoadedFilePath = "";

        private void Form1_Load(object eventSender, EventArgs eventArgs)
        {
            LicenseManager oLicenseManager = new LicenseManager();
            oLicenseManager.RegisterKEY("XXX"); //Please, replace XXXX by a valid demo or commercial license key.
            pan1Dtypes.Visible = false;
            Label7.Visible = false;
        }

        private void Command2_Click(object eventSender, EventArgs eventArgs)
        {
            GdViewer1.ZoomIN();
        }

        private void Command3_Click(object eventSender, EventArgs eventArgs)
        {
            GdViewer1.ZoomOUT();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AutoDeskewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.AutoDeskew(Globals.nativeImage);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private static string SelectOneFileOpenDialog(IWin32Window owner)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (owner == null)
            {
                openFile.ShowDialog();
            }
            else
            {
                openFile.ShowDialog(owner);
            }

            return openFile.FileName;
        }

        private void RenderPdfPage(int pageNo)
        {
            if (Globals.nativeImage != 0)
            {
                Globals.gdPictureImaging.ReleaseGdPictureImage(Globals.nativeImage);
                Globals.nativeImage = 0;
            }
            Globals.gdPicturePDF.SelectPage(pageNo);
            Globals.gdPicturePDF.SetForceRasterizerInterpolation(true);
            Globals.nativeImage = Globals.gdPicturePDF.RenderPageToGdPictureImageEx(float.Parse(TextBox1.Text), true);

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = SelectOneFileOpenDialog(this);

            if (!string.IsNullOrEmpty(filePath))
            {
                LoadFile(filePath);
            }
        }

        private void LoadFile(string filePath)
        {
            CloseCurrentImage();
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;

            if (GdPictureDocumentUtilities.GetDocumentFormat(filePath) == GdPicture14.DocumentFormat.DocumentFormatPDF)
            {
                // For barcode recognition, make sure a higher interpolation mode is used
                Globals.gdPicturePDF.SetForceRasterizerInterpolation(true);

                if (Globals.gdPicturePDF.LoadFromFile(filePath, false) == GdPictureStatus.OK)
                {
                    Globals.docSourceType = DocumentType.DocumentTypePDF;
                    RenderPdfPage(1);
                    _lastLoadedFilePath = filePath;
                }
            }
            else
            {
                Globals.docSourceType = DocumentType.DocumentTypeBitmap;
                Globals.nativeImage = Globals.gdPictureImaging.CreateGdPictureImageFromFile(filePath);
            }

            if (Globals.nativeImage != 0)
            {
                _lastLoadedFilePath = filePath;
                GdViewer1.DisplayFromGdPictureImage(Globals.nativeImage);
                ShowImageInfo();
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentImage();
        }

        private void CloseCurrentImage()
        {
            if (Globals.nativeImage != 0)
            {
                Globals.gdPictureImaging.ReleaseGdPictureImage(Globals.nativeImage);
                GdViewer1.CloseDocument();
                Globals.nativeImage = 0;
            }
            if (Globals.docSourceType == DocumentType.DocumentTypePDF)
            {
                Globals.gdPicturePDF.CloseDocument();
            }
            Globals.docSourceType = DocumentType.DocumentTypeUnknown;
        }

        private void RepairCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetROI();
            Globals.gdPictureImaging.FxBitonalDilate4(Globals.nativeImage);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void SetROI()
        {
            int leftArea = 0;
            int topArea = 0;
            int widthArea = 0;
            int heightArea = 0;

            if (GdViewer1.IsRect())
            {
                GdViewer1.GetRectCoordinatesOnDocument(ref leftArea, ref topArea, ref widthArea, ref heightArea);
                Globals.gdPictureImaging.SetROI(leftArea, topArea, widthArea, heightArea);
            }
            else
            {
                Globals.gdPictureImaging.ResetROI();
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SetROI();
            Globals.gdPictureImaging.FxBitonalErode4(Globals.nativeImage);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SetROI();
            Globals.gdPictureImaging.FxBitonalRemoveIsolatedDots4(Globals.nativeImage);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.Scale(Globals.nativeImage, 200, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.Scale(Globals.nativeImage, 300, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void ShowImageInfo()
        {
            if (Globals.nativeImage != 0)
            {
                if (Globals.docSourceType == DocumentType.DocumentTypePDF)
                {
                    lbPage.Text = Globals.gdPicturePDF.GetCurrentPage() + "/" + Globals.gdPicturePDF.GetPageCount();
                }
                else
                {
                    lbPage.Text = GdViewer1.CurrentPage + "/" + GdViewer1.PageCount;
                }

                lbImageInfo.Text = "Bit depth: " + Globals.gdPictureImaging.GetBitDepth(Globals.nativeImage) + " DPI: " + Globals.gdPictureImaging.GetVerticalResolution(Globals.nativeImage);
            }
            else
            {
                lbPage.Text = "0 / 0";
                lbImageInfo.Text = "";
            }

        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.Scale(Globals.nativeImage, 150, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }


        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.Scale(Globals.nativeImage, 75, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.Scale(Globals.nativeImage, 50, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void HorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetROI();
            Globals.gdPictureImaging.FxBitonalFillHolesH(Globals.nativeImage);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void VerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetROI();
            Globals.gdPictureImaging.FxBitonalFillHolesV(Globals.nativeImage);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void DrawBoundingBox(Color color, int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
        {
            PointF[] points =
            {
                new PointF(x1 / GdViewer1.HorizontalResolution, y1 / GdViewer1.VerticalResolution),
                new PointF(x2 / GdViewer1.HorizontalResolution, y2 / GdViewer1.VerticalResolution),
                new PointF(x3 / GdViewer1.HorizontalResolution, y3 / GdViewer1.VerticalResolution),
                new PointF(x4 / GdViewer1.HorizontalResolution, y4 / GdViewer1.VerticalResolution),
                new PointF(x1 / GdViewer1.HorizontalResolution, y1 / GdViewer1.VerticalResolution)
            };

            var annotation = GdViewer1.GetAnnotationManager().AddConnectedLinesAnnot(color, points);
            annotation.BorderWidth = 5 / GdViewer1.HorizontalResolution;
            annotation.Tag = "##barcode##";
            annotation.CanEdit = false;
            annotation.CanMove = false;
            annotation.CanResize = false;
            annotation.CanRotate = false;
            annotation.CanSelect = false;
            GdViewer1.GetAnnotationManager().SaveAnnotationsToPage();
        }

        private void ClearBoundingBoxes()
        {
            int i = GdViewer1.GetAnnotationCount();
            while (i > 0)
            {
                Annotation annotation = GdViewer1.GetAnnotationFromIdx(i - 1);
                if (annotation.Tag == "##barcode##")
                {
                    GdViewer1.DeleteAnnotation(i - 1);
                }
                i -= 1;
            }
            GdViewer1.SaveAnnotationsToPage();
        }

        private void Recognition()
        {
            if (!chkDetect1D.Checked && !chkDetectDataMatrix.Checked && !chkDetectQRCode.Checked && !chkDetectPDF417.Checked 
                && !chkDetectMicroQRCode.Checked && !chkDetectAztec.Checked && !chkDetectPathCode.Checked && !chkDetectMaxicode.Checked)
            {
                MessageBox.Show("Please select a barcode symbology to detect");
                return;
            }

            List<SingleBarcodeInfo> barcode1DResults = new List<SingleBarcodeInfo>();
            List<SingleBarcodeInfo> barcode2DResults = new List<SingleBarcodeInfo>();
            List<SingleBarcodeInfo> barcodeQrResults = new List<SingleBarcodeInfo>();
            List<SingleBarcodeInfo> barcodePDF417Results = new List<SingleBarcodeInfo>();
            List<SingleBarcodeInfo> barcodeMicroQrResults = new List<SingleBarcodeInfo>();
            List<SingleBarcodeInfo> barcodeAztecResults = new List<SingleBarcodeInfo>();
            List<SingleBarcodeInfo> barcodeMaxicodeResults = new List<SingleBarcodeInfo>();
            List<SingleBarcodeInfo> patchCodeResults = new List<SingleBarcodeInfo>();

            int barcodeCount = 0;
            int pccount = 0;
            int leftArea = 0;
            int topArea = 0;
            int widthArea = 0;
            int heightArea = 0;

            int expectedCount = (int)this.nupBcCount.Value;


            if (GdViewer1.IsRect())
            {
                GdViewer1.GetRectCoordinatesOnDocument(ref leftArea, ref topArea, ref widthArea, ref heightArea);
                Globals.gdPictureImaging.SetROI(leftArea, topArea, widthArea, heightArea);
            }
            else
            {
                Globals.gdPictureImaging.ResetROI();
            }

            ClearBoundingBoxes();

            if (chkDetect1D.Checked)
            {
                Barcode1DReaderType barcodeTypes = default(Barcode1DReaderType);

                if (chkIndustrial2of5.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderIndustrial2of5;
                }
                if (chkInverted2of5.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderInverted2of5;
                }
                if (chkInterleaved2of5.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderInterleaved2of5;
                }
                if (chkIata2of5.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderIata2of5;
                }
                if (chkMatrix2of5.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderMatrix2of5;
                }
                if (chkCode39.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderCode39;
                }
                if (chkCodeabar.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderCodeabar;
                }
                if (chkBcdMatrix.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderBcdMatrix;
                }
                if (chkDataLogic2of5.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderDataLogic2of5;
                }
                if (chkCode128.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderCode128;
                }

                if (chkCODE93.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderCODE93;
                }
                if (chkEAN13.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderEAN13;
                }
                if (chkUPCA.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderUPCA;
                }
                if (chkEAN8.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderEAN8;
                }
                if (chkUPCE.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderUPCE;
                }
                if (chkAdd5.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderADD5;
                }
                if (chkAdd2.Checked)
                {
                    barcodeTypes = barcodeTypes | Barcode1DReaderType.Barcode1DReaderADD2;
                }

                Barcode1DReaderScanMode scanMode = chkHQDetection.Checked ? Barcode1DReaderScanMode.BestQuality : Barcode1DReaderScanMode.BestSpeed;
                Globals.gdPictureImaging.Barcode1DReaderDoScan(Globals.nativeImage, scanMode, barcodeTypes, chkUseCorrupted.Checked, expectedCount);

                int foundBarcodeCount = Globals.gdPictureImaging.Barcode1DReaderGetBarcodeCount();

                if (foundBarcodeCount > 0)
                {
                    for (int i = 1; i <= Globals.gdPictureImaging.Barcode1DReaderGetBarcodeCount(); i++)
                    {
                        barcodeCount++;
                        SingleBarcodeInfo singleBarcodeInfo = new SingleBarcodeInfo();
                        singleBarcodeInfo.BarcodeNumber.Text = i + " / " + Globals.gdPictureImaging.Barcode1DReaderGetBarcodeCount();
                        singleBarcodeInfo.Info.Text += "------------------------------------------------" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Type: " + Globals.gdPictureImaging.Barcode1DReaderGetBarcodeType(i) + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Value: " + Globals.gdPictureImaging.Barcode1DReaderGetBarcodeValue(i) + "\r\n";
                        singleBarcodeInfo.Info.Text += "Checksum: " + Globals.gdPictureImaging.Barcode1DReaderBarcodeHasChecksum(i) + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Angle: " + Globals.gdPictureImaging.Barcode1DReaderGetBarcodeSkewAngle(i) + "\r\n" + "\r\n";

                        barcode1DResults.Add(singleBarcodeInfo);
                    }
                    expectedCount -= foundBarcodeCount;
                }

                if (CheckBox1.Checked == false) //Drawing bounding boxes
                {
                    GdViewer1.LockViewer = true;
                    for (int i = 1; i <= Globals.gdPictureImaging.Barcode1DReaderGetBarcodeCount(); i++)
                    {
                        int x1 = Globals.gdPictureImaging.Barcode1DReaderGetBarcodeX1(i) + leftArea;
                        int x2 = Globals.gdPictureImaging.Barcode1DReaderGetBarcodeX2(i) + leftArea;
                        int x3 = Globals.gdPictureImaging.Barcode1DReaderGetBarcodeX3(i) + leftArea;
                        int x4 = Globals.gdPictureImaging.Barcode1DReaderGetBarcodeX4(i) + leftArea;

                        int y1 = Globals.gdPictureImaging.Barcode1DReaderGetBarcodeY1(i) + topArea;
                        int y2 = Globals.gdPictureImaging.Barcode1DReaderGetBarcodeY2(i) + topArea;
                        int y3 = Globals.gdPictureImaging.Barcode1DReaderGetBarcodeY3(i) + topArea;
                        int y4 = Globals.gdPictureImaging.Barcode1DReaderGetBarcodeY4(i) + topArea;

                        DrawBoundingBox(Color.Red, x1, x2, x3, x4, y1, y2, y3, y4);
                    }
                    GdViewer1.LockViewer = false;
                    GdViewer1.Redraw();
                }
                Globals.gdPictureImaging.Barcode1DReaderClear();
            }

            if (chkDetectDataMatrix.Checked)
            {
                BarcodeDataMatrixReaderScanMode scanMode = chkHQDetection.Checked ? BarcodeDataMatrixReaderScanMode.BestQuality : BarcodeDataMatrixReaderScanMode.BestSpeed;
                Globals.gdPictureImaging.BarcodeDataMatrixReaderDoScan(Globals.nativeImage, scanMode, expectedCount);

                int foundBarcodeCount = Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount();
                if (foundBarcodeCount > 0)
                {
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount(); i++)
                    {
                        barcodeCount++;
                        SingleBarcodeInfo singleBarcodeInfo = new SingleBarcodeInfo();
                        singleBarcodeInfo.BarcodeNumber.Text = i + " / " + Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount();
                        singleBarcodeInfo.Info.Text += "------------------------------------------------" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Type: 2D - Datamatrix" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Rows: " + (Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeRows(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "Barcode Columns: " + (Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeColumns(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "Barcode Value: " + (Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeValue(i) + "\r\n" + "\r\n");

                        barcode2DResults.Add(singleBarcodeInfo);
                    }
                    expectedCount -= foundBarcodeCount;
                }

                if (CheckBox1.Checked == false) //Drawing bounding boxes
                {
                    GdViewer1.LockViewer = true;
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount(); i++)
                    {
                        int x1 = Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX1(i) + leftArea;
                        int x2 = Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX2(i) + leftArea;
                        int x3 = Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX3(i) + leftArea;
                        int x4 = Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX4(i) + leftArea;

                        int y1 = Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY1(i) + topArea;
                        int y2 = Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY2(i) + topArea;
                        int y3 = Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY3(i) + topArea;
                        int y4 = Globals.gdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY4(i) + topArea;

                        DrawBoundingBox(Color.Blue, x1, x2, x3, x4, y1, y2, y3, y4);
                    }
                    GdViewer1.LockViewer = false;
                    GdViewer1.Redraw();
                }

                Globals.gdPictureImaging.BarcodeDataMatrixReaderClear();
            }

            if (chkDetectQRCode.Checked)
            {
                BarcodeQRReaderScanMode scanMode = chkHQDetection.Checked ? BarcodeQRReaderScanMode.BestQuality : BarcodeQRReaderScanMode.BestSpeed;
                Globals.gdPictureImaging.BarcodeQRReaderDoScan(Globals.nativeImage, scanMode, expectedCount);

                int foundBarcodeCount = Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeCount();
                if (foundBarcodeCount > 0)
                {
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeCount(); i++)
                    {
                        barcodeCount++;
                        SingleBarcodeInfo singleBarcodeInfo = new SingleBarcodeInfo();
                        singleBarcodeInfo.BarcodeNumber.Text = i + " / " + Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeCount();
                        singleBarcodeInfo.Info.Text += "------------------------------------------------" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Type: 2D - qr" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Confidence: " + (Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeConfidence(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "Barcode Version: " + (Globals.gdPictureImaging.BarcodeQRReaderGetVersion(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "Barcode Value: " + (Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeValue(i) + "\r\n" + "\r\n");

                        barcodeQrResults.Add(singleBarcodeInfo);
                    }
                }

                if (CheckBox1.Checked == false) //Drawing bounding boxes
                {
                    GdViewer1.LockViewer = true;
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeCount(); i++)
                    {
                        int x1 = Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeX1(i) + leftArea;
                        int x2 = Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeX2(i) + leftArea;
                        int x3 = Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeX3(i) + leftArea;
                        int x4 = Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeX4(i) + leftArea;

                        int y1 = Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeY1(i) + topArea;
                        int y2 = Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeY2(i) + topArea;
                        int y3 = Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeY3(i) + topArea;
                        int y4 = Globals.gdPictureImaging.BarcodeQRReaderGetBarcodeY4(i) + topArea;

                        DrawBoundingBox(Color.Green, x1, x2, x3, x4, y1, y2, y3, y4);
                    }
                    GdViewer1.LockViewer = false;
                    GdViewer1.Redraw();
                }

                Globals.gdPictureImaging.BarcodeQRReaderClear();
            }

            if (chkDetectMicroQRCode.Checked)
            {
                BarcodeQRReaderScanMode scanMode = chkHQDetection.Checked ? BarcodeQRReaderScanMode.BestQuality : BarcodeQRReaderScanMode.BestSpeed;
                Globals.gdPictureImaging.BarcodeMicroQRReaderDoScan(Globals.nativeImage, scanMode, expectedCount);

                int foundBarcodeCount = Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount();
                if (foundBarcodeCount > 0)
                {
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount(); i++)
                    {
                        barcodeCount++;
                        SingleBarcodeInfo singleBarcodeInfo = new SingleBarcodeInfo();
                        singleBarcodeInfo.BarcodeNumber.Text = i + " / " + Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount();
                        singleBarcodeInfo.Info.Text += "------------------------------------------------" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Type: 2D - micro qr" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Confidence: " + (Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeConfidence(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "Barcode Version: " + (Globals.gdPictureImaging.BarcodeMicroQRReaderGetVersion(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "Barcode Value: " + (Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeValue(i) + "\r\n" + "\r\n");

                        barcodeMicroQrResults.Add(singleBarcodeInfo);
                    }
                }

                if (CheckBox1.Checked == false) //Drawing bounding boxes
                {
                    GdViewer1.LockViewer = true;
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount(); i++)
                    {
                        int x1 = Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX1(i) + leftArea;
                        int x2 = Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX2(i) + leftArea;
                        int x3 = Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX3(i) + leftArea;
                        int x4 = Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeX4(i) + leftArea;

                        int y1 = Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY1(i) + topArea;
                        int y2 = Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY2(i) + topArea;
                        int y3 = Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY3(i) + topArea;
                        int y4 = Globals.gdPictureImaging.BarcodeMicroQRReaderGetBarcodeY4(i) + topArea;

                        DrawBoundingBox(Color.Green, x1, x2, x3, x4, y1, y2, y3, y4);
                    }
                    GdViewer1.LockViewer = false;
                    GdViewer1.Redraw();
                }

                Globals.gdPictureImaging.BarcodeMicroQRReaderClear();
            }

            if (chkDetectPDF417.Checked)
            {
                BarcodePDF417ReaderScanMode scanMode = chkHQDetection.Checked ? BarcodePDF417ReaderScanMode.BestQuality : BarcodePDF417ReaderScanMode.BestSpeed;
                Globals.gdPictureImaging.BarcodePDF417ReaderDoScan(Globals.nativeImage, scanMode, expectedCount);

                int foundBarcodeCount = Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount();
                if (foundBarcodeCount > 0)
                {
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount(); i++)
                    {
                        barcodeCount++;
                        SingleBarcodeInfo singleBarcodeInfo = new SingleBarcodeInfo();
                        singleBarcodeInfo.BarcodeNumber.Text = i + " / " + Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount();
                        singleBarcodeInfo.Info.Text += "------------------------------------------------" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Type: 2D - PDF417" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Rows: " + (Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeRows(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "Barcode Columns: " + (Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeColumns(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "Accuracy: " + (Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeConfidence(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "Barcode Value: " + (Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeValue(i) + "\r\n" + "\r\n");

                        barcodePDF417Results.Add(singleBarcodeInfo);
                    }
                    expectedCount -= foundBarcodeCount;
                }

                if (CheckBox1.Checked == false) //Drawing bounding boxes
                {
                    GdViewer1.LockViewer = true;
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeCount(); i++)
                    {
                        int x1 = Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeX1(i) + leftArea;
                        int x2 = Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeX2(i) + leftArea;
                        int x3 = Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeX3(i) + leftArea;
                        int x4 = Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeX4(i) + leftArea;

                        int y1 = Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeY1(i) + topArea;
                        int y2 = Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeY2(i) + topArea;
                        int y3 = Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeY3(i) + topArea;
                        int y4 = Globals.gdPictureImaging.BarcodePDF417ReaderGetBarcodeY4(i) + topArea;

                        DrawBoundingBox(Color.Violet, x1, x2, x3, x4, y1, y2, y3, y4);
                    }
                    GdViewer1.LockViewer = false;
                    GdViewer1.Redraw();
                }

                Globals.gdPictureImaging.BarcodePDF417ReaderClear();
            }

            if (chkDetectAztec.Checked)
            {
                BarcodeAztecReaderScanMode scanMode = chkHQDetection.Checked ? BarcodeAztecReaderScanMode.BestQuality : BarcodeAztecReaderScanMode.BestSpeed;
                Globals.gdPictureImaging.BarcodeAztecReaderDoScan(Globals.nativeImage, scanMode, expectedCount);

                int foundBarcodeCount = Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeCount();
                if (foundBarcodeCount > 0)
                {
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeCount(); i++)
                    {
                        barcodeCount++;
                        SingleBarcodeInfo singleBarcodeInfo = new SingleBarcodeInfo();
                        singleBarcodeInfo.BarcodeNumber.Text = i + " / " + Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeCount();
                        singleBarcodeInfo.Info.Text += "------------------------------------------------" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Type: 2D - Aztec" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Value: " + (Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeValue(i) + "\r\n" + "\r\n");

                        barcodeAztecResults.Add(singleBarcodeInfo);
                    }
                    expectedCount -= foundBarcodeCount;
                }

                if (CheckBox1.Checked == false) //Drawing bounding boxes
                {
                    GdViewer1.LockViewer = true;
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeCount(); i++)
                    {
                        int x1 = Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeX1(i) + leftArea;
                        int x2 = Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeX2(i) + leftArea;
                        int x3 = Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeX3(i) + leftArea;
                        int x4 = Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeX4(i) + leftArea;

                        int y1 = Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeY1(i) + topArea;
                        int y2 = Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeY2(i) + topArea;
                        int y3 = Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeY3(i) + topArea;
                        int y4 = Globals.gdPictureImaging.BarcodeAztecReaderGetBarcodeY4(i) + topArea;

                        DrawBoundingBox(Color.OrangeRed, x1, x2, x3, x4, y1, y2, y3, y4);
                    }
                    GdViewer1.LockViewer = false;
                    GdViewer1.Redraw();
                }

                Globals.gdPictureImaging.BarcodeAztecReaderClear();
            }

            if (chkDetectMaxicode.Checked)
            {
                BarcodeMaxiCodeReaderScanMode scanMode = chkHQDetection.Checked ? BarcodeMaxiCodeReaderScanMode.BestQuality : BarcodeMaxiCodeReaderScanMode.BestSpeed;
                Globals.gdPictureImaging.BarcodeMaxiCodeReaderDoScan(Globals.nativeImage, scanMode, expectedCount);

                int foundBarcodeCount = Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeCount();
                if (foundBarcodeCount > 0)
                {
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeCount(); i++)
                    {
                        barcodeCount++;
                        SingleBarcodeInfo singleBarcodeInfo = new SingleBarcodeInfo();
                        singleBarcodeInfo.BarcodeNumber.Text = i + " / " + Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeCount();
                        singleBarcodeInfo.Info.Text += "------------------------------------------------" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Type: 2D - Maxicode" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Barcode Value: " + (Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeValue(i) + "\r\n" + "\r\n");

                        barcodeMaxicodeResults.Add(singleBarcodeInfo);
                    }
                    expectedCount -= foundBarcodeCount;
                }

                if (CheckBox1.Checked == false) //Drawing bounding boxes
                {
                    GdViewer1.LockViewer = true;
                    for (int i = 1; i <= Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeCount(); i++)
                    {
                        int x1 = Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX1(i) + leftArea;
                        int x2 = Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX2(i) + leftArea;
                        int x3 = Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX3(i) + leftArea;
                        int x4 = Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeX4(i) + leftArea;

                        int y1 = Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY1(i) + topArea;
                        int y2 = Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY2(i) + topArea;
                        int y3 = Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY3(i) + topArea;
                        int y4 = Globals.gdPictureImaging.BarcodeMaxiCodeReaderGetBarcodeY4(i) + topArea;

                        DrawBoundingBox(Color.OrangeRed, x1, x2, x3, x4, y1, y2, y3, y4);
                    }
                    GdViewer1.LockViewer = false;
                    GdViewer1.Redraw();
                }

                Globals.gdPictureImaging.BarcodeMaxiCodeReaderClear();
            }

            if (chkDetectPathCode.Checked)
            {
                Globals.gdPictureImaging.PatchCodeReaderDoScan(Globals.nativeImage);

                int foundBarcodeCount = Globals.gdPictureImaging.PatchCodeReaderGetCodeCount();
                if (foundBarcodeCount > 0)
                {
                    for (int i = 1; i <= Globals.gdPictureImaging.PatchCodeReaderGetCodeCount(); i++)
                    {
                        pccount++;
                        SingleBarcodeInfo singleBarcodeInfo = new SingleBarcodeInfo();
                        singleBarcodeInfo.BarcodeNumber.Text = i + " / " + Globals.gdPictureImaging.PatchCodeReaderGetCodeCount();
                        singleBarcodeInfo.Info.Text += "------------------------------------------------" + "\r\n";
                        singleBarcodeInfo.Info.Text += "Patchcode Type: " + (Globals.gdPictureImaging.PatchCodeReaderGetCodeType(i) + "\r\n");
                        singleBarcodeInfo.Info.Text += "\r\n";

                        patchCodeResults.Add(singleBarcodeInfo);
                    }
                }

                if (CheckBox1.Checked == false) //Drawing bounding boxes
                {
                    GdViewer1.LockViewer = true;
                    for (int i = 1; i <= Globals.gdPictureImaging.PatchCodeReaderGetCodeCount(); i++)
                    {
                        int x1 = Globals.gdPictureImaging.PatchCodeReaderGetCodeX1(i) + leftArea;
                        int x2 = Globals.gdPictureImaging.PatchCodeReaderGetCodeX2(i) + leftArea;
                        int x3 = Globals.gdPictureImaging.PatchCodeReaderGetCodeX3(i) + leftArea;
                        int x4 = Globals.gdPictureImaging.PatchCodeReaderGetCodeX4(i) + leftArea;

                        int y1 = Globals.gdPictureImaging.PatchCodeReaderGetCodeY1(i) + topArea;
                        int y2 = Globals.gdPictureImaging.PatchCodeReaderGetCodeY2(i) + topArea;
                        int y3 = Globals.gdPictureImaging.PatchCodeReaderGetCodeY3(i) + topArea;
                        int y4 = Globals.gdPictureImaging.PatchCodeReaderGetCodeY4(i) + topArea;

                        DrawBoundingBox(Color.Orange, x1, x2, x3, x4, y1, y2, y3, y4);
                    }
                    GdViewer1.LockViewer = false;
                    GdViewer1.Redraw();
                }

                Globals.gdPictureImaging.PatchCodeReaderClear();
            }

            if (pccount > 0 | barcodeCount > 0)
            {
                BarcodeResults barcodeResults = new BarcodeResults(barcode1DResults, barcode2DResults, barcodeQrResults, barcodePDF417Results, barcodeMicroQrResults, barcodeAztecResults, barcodeMaxicodeResults, patchCodeResults);
                barcodeResults.Show();
            }
            else
            {
                MessageBox.Show("No barcodes were detected!");
            }
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void GdViewer1_MouseUp(object sender, MouseEventArgs e)
        {
            if (GdViewer1.IsRect())
            {
                Recognition();
                GdViewer1.ClearRect();
            }
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recognition();
        }

        private void MedianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.FxMedian(Globals.nativeImage, 1);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void SmoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.FxSmooth(Globals.nativeImage);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void chkDetect1D_CheckedChanged(object sender, EventArgs e)
        {
            pan1Dtypes.Visible = chkDetect1D.Checked;
            Label7.Visible = pan1Dtypes.Visible;
        }


        private void chkDetectMaxicode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Globals.docSourceType == DocumentType.DocumentTypePDF) //special case for PDF
            {
                RenderPdfPage(Globals.gdPicturePDF.GetCurrentPage() + 1);
                GdViewer1.DisplayFromGdPictureImage(Globals.nativeImage);
            }
            else
            {
                GdViewer1.DisplayNextPage();
            }
            ShowImageInfo();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Globals.docSourceType == DocumentType.DocumentTypePDF) //special case for PDF
            {
                RenderPdfPage(Globals.gdPicturePDF.GetCurrentPage() - 1);
                GdViewer1.DisplayFromGdPictureImage(Globals.nativeImage);
            }
            else
            {
                GdViewer1.DisplayPreviousPage();
            }
            ShowImageInfo();
        }

        private void Rotate90DegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.Rotate(Globals.nativeImage, RotateFlipType.Rotate90FlipNone);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void RemoveVerticalLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.RemoveLines(Globals.nativeImage, LineRemoveOrientation.Vertical);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void RemoveHorizontalLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.gdPictureImaging.RemoveLines(Globals.nativeImage, LineRemoveOrientation.Horizontal);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void ThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.gdPictureImaging.GetBitDepth(Globals.nativeImage) == 1)
            {
                MessageBox.Show("Image is already bitonal");
                return;
            }
            if (Globals.nativeImage != 0)
            {
                Thresholder binarizationDialog = new Thresholder(this);
                if (binarizationDialog.ShowDialog() == DialogResult.OK)
                {
                    ShowImageInfo();
                }
            }
        }

        private void ReloadLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_lastLoadedFilePath))
            {
                LoadFile(_lastLoadedFilePath);
            }
        }

        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (Globals.nativeImage == 0)
            {
                return;
            }
            if (Globals.gdPictureImaging.GetBitDepth(Globals.nativeImage) != 1)
            {
                MessageBox.Show("Image needs to be binarized first");
                return;
            }
            using (Despeckle despeckle = new Despeckle(GdViewer1))
            {
                despeckle.ShowDialog(this);
            }
        }

        private void chkDetectAztec_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
