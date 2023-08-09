using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;
using GdPicture14;
using Microsoft.Win32;
using System.Windows.Threading;
using GdPicture14.Annotations;

namespace Csharp_Barcode_Recognition.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("shell32.dll", EntryPoint = "ShellExecuteA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);


        private GdPictureImaging m_GdPictureImaging = new GdPictureImaging();
        private GdPicturePDF m_GdPicturePDF = new GdPicturePDF();
        private int m_ImageID;
        private DocumentType m_DocSourceType;
        private int m_ExpectedCount = 0;
        //ThresholdType:
        //0: Linear(Default)
        //1: Adaptive (Otsu)
        //2: Sauvola
        public int _thresholdType;
        //Parameters for thresholding functions
        public int _thresholdValue = 128;
        public int _smoothKernel;
        public int _contrastMinDif;

        public int _despeckleStrength = 5;
        public DespeckleType _despeckleType = DespeckleType.FourConnected;

        //Image Identifier to do Threshold and Despeckle on
        int _ClonedImage;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseManager oLicenceManager = new LicenseManager(); //Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.
            oLicenceManager.RegisterKEY("XXXX");//Please, replace XXXX by a valid demo or commercial license key. 
        }

        private void renderPdfPage(int pageNo)
        {
            if (m_ImageID != 0)
            {
                m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID);
                m_ImageID = 0;
            }
            m_GdPicturePDF.SelectPage(pageNo);
            m_ImageID = m_GdPicturePDF.RenderPageToGdPictureImageEx(float.Parse(TextBox1.Text), true);
        }

        private void ShowImageInfo()
        {
            if (m_ImageID != 0)
            {
                if (m_DocSourceType == DocumentType.DocumentTypePDF)
                {
                    lbPage.Content = m_GdPicturePDF.GetCurrentPage().ToString() + "/" + m_GdPicturePDF.GetPageCount().ToString();
                }
                else
                {
                    lbPage.Content = GdViewer1.CurrentPage.ToString() + "/" + GdViewer1.PageCount.ToString();
                }

                lbImageInfo.Content = "Bit depth: " + m_GdPictureImaging.GetBitDepth(m_ImageID).ToString() + " DPI: " + m_GdPictureImaging.GetVerticalResolution(m_ImageID).ToString();
            }
            else
            {
                lbPage.Content = "0 / 0";
                lbImageInfo.Content = "";
            }

        }

        private string SelectOneFileOpenDialog(MainWindow owner)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();

            if (owner == null)
            {
                OpenFile.ShowDialog();
            }
            else
            {
                OpenFile.ShowDialog(owner);
            }

            return OpenFile.FileName;
        }

        private void CloseCurrentImage()
        {
            if (m_ImageID != 0)
            {
                m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID);
                GdViewer1.CloseDocument();
                m_ImageID = 0;
            }
            if (m_DocSourceType == DocumentType.DocumentTypePDF)
            {
                m_GdPicturePDF.CloseDocument();
            }
            m_DocSourceType = DocumentType.DocumentTypeUnknown;
        }

        private void SetROI()
        {
            double LeftArea = 0.0;
            double TopArea = 0.0;
            double WidthArea = 0.0;
            double HeightArea = 0.0;

            if (GdViewer1.IsRect())
            {
                GdViewer1.GetRectCoordinatesOnDocumentPixel(ref LeftArea, ref TopArea, ref WidthArea, ref HeightArea);
                m_GdPictureImaging.SetROI((int)LeftArea, (int)TopArea, (int)WidthArea, (int)HeightArea);
            }
            else
            {
                m_GdPictureImaging.ResetROI();
                LeftArea = 0;
                TopArea = 0;
                WidthArea = 0;
                HeightArea = 0;
            }
        }

        private void GdViewer1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (GdViewer1.IsRect())
            {
                Reco();
                GdViewer1.ClearRect();
            }

        }

        #region "File Menu"
        private void OpenFileCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenFileCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseCurrentImage();
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
            string sFilePath = SelectOneFileOpenDialog(this);

            if (sFilePath != "")
            {
                if (GdPictureDocumentUtilities.GetDocumentFormat(sFilePath) == GdPicture14.DocumentFormat.DocumentFormatPDF)
                {

                    if (m_GdPicturePDF.LoadFromFile(sFilePath, false) == GdPictureStatus.OK)
                    {
                        m_DocSourceType = DocumentType.DocumentTypePDF;
                        renderPdfPage(1);
                    }
                }
                else
                {
                    m_DocSourceType = DocumentType.DocumentTypeBitmap;
                    m_ImageID = m_GdPictureImaging.CreateGdPictureImageFromFile(sFilePath);
                }

                if (m_ImageID != 0)
                {
                    GdViewer1.DisplayFromGdPictureImage(m_ImageID);
                    ShowImageInfo();
                }
            }
        }


        private void CloseCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseCurrentImage();
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
        #endregion

        #region "Image Processing"
        private void FiltersCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (m_ImageID != 0)
                e.CanExecute = true;
        }

        private void MedianCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.FxMedian(m_ImageID, 1);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void SmoothCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.FxSmooth(m_ImageID);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void AutoDeskewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.AutoDeskew(m_ImageID);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void DilateCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SetROI();
            m_GdPictureImaging.FxBitonalDilate4(m_ImageID);
            GdViewer1.Redraw();
            ShowImageInfo();
        }


        private void ErodeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SetROI();
            m_GdPictureImaging.FxBitonalErode4(m_ImageID);
            GdViewer1.Redraw();
            ShowImageInfo();
        }


        private void RemoveDotsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SetROI();
            m_GdPictureImaging.FxBitonalRemoveIsolatedDots4(m_ImageID);
            GdViewer1.Redraw();
            ShowImageInfo();
        }


        private void RemoveVLinesCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.RemoveLines(m_ImageID, LineRemoveOrientation.Vertical);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void RemoveHLinesCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.RemoveLines(m_ImageID, LineRemoveOrientation.Horizontal);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void ThresholdCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (m_ImageID != 0)
                if (m_GdPictureImaging.GetBitDepth(m_ImageID) != 1)
                    e.CanExecute = true;
        }

        private void ThresholdCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Window thresholdWindow = new ThresholdDialog(this);
            bool? result = thresholdWindow.ShowDialog();
            if (result == true)
            {
                if (m_ImageID != 0 & _ClonedImage != 0)
                {
                    m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID);
                    m_ImageID = m_GdPictureImaging.CreateClonedGdPictureImage(_ClonedImage);
                    m_GdPictureImaging.ReleaseGdPictureImage(_ClonedImage);
                }

                ShowImageInfo();
            }
            if (GdViewer1.DisplayFromGdPictureImage(m_ImageID) != GdPictureStatus.OK)
            {
                MessageBox.Show("The Image cannot be displayed");
            }
        }

        private void RotateCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.Rotate(m_ImageID, RotateFlipType.Rotate90FlipNone);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void StartCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Reco();
        }

        private void DespeckleCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Window despeckleWindow = new DespeckleDialog(this);
            bool? result = despeckleWindow.ShowDialog();
            if (result == true)
            {
                if (m_ImageID != 0 & _ClonedImage != 0)
                {
                    m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID);
                    m_ImageID = m_GdPictureImaging.CreateClonedGdPictureImage(_ClonedImage);
                    m_GdPictureImaging.ReleaseGdPictureImage(_ClonedImage);
                }

                ShowImageInfo();
            }
            if (GdViewer1.DisplayFromGdPictureImage(m_ImageID) != GdPictureStatus.OK)
            {
                MessageBox.Show("The Image cannot be displayed");
            }
        }

        private void FillHHolesCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SetROI();
            m_GdPictureImaging.FxBitonalFillHolesH(m_ImageID);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void FillVHolesCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SetROI();
            m_GdPictureImaging.FxBitonalFillHolesV(m_ImageID);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void Scale50Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.Scale(m_ImageID, 50, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void Scale75Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.Scale(m_ImageID, 75, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void Scale150Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.Scale(m_ImageID, 100, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void Scale200Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.Scale(m_ImageID, 200, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }

        private void Scale300Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            m_GdPictureImaging.Scale(m_ImageID, 300, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
            GdViewer1.Redraw();
            ShowImageInfo();
        }
        #endregion

        private void nupBcCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            int val;
            bool result = Int32.TryParse(nupBcCount.Text, out val);
            if (result)
                m_ExpectedCount = val;
            else
            {
                MessageBox.Show("Please enter a valid number");
                nupBcCount.Text = "0";
                m_ExpectedCount = 0;
            }
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            m_ExpectedCount++;
            nupBcCount.Text = m_ExpectedCount.ToString();
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            if (m_ExpectedCount > 0)
            {
                m_ExpectedCount--;
                nupBcCount.Text = m_ExpectedCount.ToString();
            }
        }

        private void DrawBoundingBox(Color color, int X1, int X2, int X3, int X4, int Y1, int Y2, int Y3, int Y4)
        {
            PointF[] points =
            {
                new PointF((float)(X1 / GdViewer1.PageHorizontalResolution), (float)(Y1 / GdViewer1.PageVerticalResolution)),
                new PointF((float)(X2 / GdViewer1.PageHorizontalResolution), (float)(Y2 / GdViewer1.PageVerticalResolution)),
                new PointF((float)(X3 / GdViewer1.PageHorizontalResolution), (float)(Y3 / GdViewer1.PageVerticalResolution)),
                new PointF((float)(X4 / GdViewer1.PageHorizontalResolution), (float)(Y4 / GdViewer1.PageVerticalResolution)),
                new PointF((float)(X1 / GdViewer1.PageHorizontalResolution), (float)(Y1 / GdViewer1.PageVerticalResolution))
            };

            var annotation = GdViewer1.GetAnnotationManager().AddConnectedLinesAnnot(color, points);
            annotation.BorderWidth = (float)(5 / GdViewer1.PageHorizontalResolution);
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
                Annotation annot = GdViewer1.GetAnnotationFromIdx(i - 1);
                if (annot.Tag == "##barcode##")
                {
                    GdViewer1.DeleteAnnotation(i - 1);
                }
                i -= 1;
            }
        }

        private void Reco()
        {
            if ((chkDetect1D.IsChecked == false) && (chkDetectDataMatrix.IsChecked == false) && (chkDetectQRCode.IsChecked == false) && (chkDetectPDF417.IsChecked == false) && (chkDetectMicroQRCode.IsChecked == false) && (chkDetectPatchCode.IsChecked == false))
            {
                MessageBox.Show("Please select a barcode symbology to detect");
                return;
            }

            int bccount = 0;
            int pccount = 0;
            double LeftArea = 0.0;
            double TopArea = 0.0;
            double WidthArea = 0.0;
            double HeightArea = 0.0;
            StringBuilder result = new StringBuilder();
            int bcfound = 0;
            int expectedCount = m_ExpectedCount;


            if (GdViewer1.IsRect())
            {
                GdViewer1.GetRectCoordinatesOnDocumentPixel(ref LeftArea, ref TopArea, ref WidthArea, ref HeightArea);
                m_GdPictureImaging.SetROI((int)LeftArea, (int)TopArea, (int)WidthArea, (int)HeightArea);
            }
            else
            {
                m_GdPictureImaging.ResetROI();
                LeftArea = 0;
                TopArea = 0;
                WidthArea = 0;
                HeightArea = 0;
            }

            ClearBoundingBoxes();

            if (chkDetect1D.IsChecked == true)
            {
                Barcode1DReaderType barcodeTypes = default(Barcode1DReaderType);

                if (chkIndustrial2of5.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderIndustrial2of5);
                }
                if (chkInverted2of5.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderInverted2of5);
                }
                if (chkInterleaved2of5.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderInterleaved2of5);
                }
                if (chkIata2of5.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderIata2of5);
                }
                if (chkMatrix2of5.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderMatrix2of5);
                }
                if (chkCODE39.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderCode39);
                }
                if (chkCodeabar.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderCodeabar);
                }
                if (chkBcdMatrix.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderBcdMatrix);
                }
                if (chkDataLogic2of5.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderDataLogic2of5);
                }
                if (chkCode128.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderCode128);
                }

                if (chkCODE39.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderCODE93);
                }
                if (chkEAN13.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderEAN13);
                }
                if (chkUPCA.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderUPCA);
                }
                if (chkEAN8.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderEAN8);
                }

                if (chkUPCE.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderUPCE);
                }
                if (chkAdd5.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderADD5);
                }
                if (chkAdd2.IsChecked == true)
                {
                    barcodeTypes = (Barcode1DReaderType)(barcodeTypes | Barcode1DReaderType.Barcode1DReaderADD2);
                }


                Barcode1DReaderScanMode scanMode = default(Barcode1DReaderScanMode);
                if (chkHQDetection.IsChecked == true)
                {
                    scanMode = Barcode1DReaderScanMode.BestQuality;
                }
                else
                {
                    scanMode = Barcode1DReaderScanMode.BestSpeed;
                }
                m_GdPictureImaging.Barcode1DReaderDoScan(m_ImageID, scanMode, barcodeTypes, false, expectedCount);

                bcfound = m_GdPictureImaging.Barcode1DReaderGetBarcodeCount();
                if (bcfound == 0 && chkUseCorrupted.IsChecked == true) //Good practice: query the barcode reader for corrupted barcode ONLY if the first detect no barcode
                {
                    m_GdPictureImaging.Barcode1DReaderDoScan(m_ImageID, scanMode, barcodeTypes, true, 0);
                    bcfound = m_GdPictureImaging.Barcode1DReaderGetBarcodeCount();
                }
                if (bcfound > 0)
                {
                    for (int i = 1; i <= m_GdPictureImaging.Barcode1DReaderGetBarcodeCount(); i++)
                    {
                        bccount++;
                        result.Append("Barcode No: " + (bccount.ToString() + "\r\n"));
                        result.Append("------------------------------------------------" + "\r\n");
                        result.Append("Barcode Type: " + (m_GdPictureImaging.Barcode1DReaderGetBarcodeType(i).ToString() + "\r\n"));
                        result.Append("Barcode Value: " + (m_GdPictureImaging.Barcode1DReaderGetBarcodeValue(i) + "\r\n"));
                        result.Append("Checksum: " + (m_GdPictureImaging.Barcode1DReaderBarcodeHasChecksum(i).ToString() + "\r\n"));
                        result.Append("Barcode Angle: " + m_GdPictureImaging.Barcode1DReaderGetBarcodeSkewAngle(i).ToString() + "\r\n" + "\r\n");
                    }
                    expectedCount -= bcfound;
                }


                if (CheckBox1.IsChecked == false) //Drawing bounding boxes
                {
                    int X1 = 0;
                    int X2 = 0;
                    int X3 = 0;
                    int X4 = 0;
                    int Y1 = 0;
                    int Y2 = 0;
                    int Y3 = 0;
                    int Y4 = 0;

                    for (int i = 1; i <= m_GdPictureImaging.Barcode1DReaderGetBarcodeCount(); i++)
                    {
                        X1 = m_GdPictureImaging.Barcode1DReaderGetBarcodeX1(i) + (int)LeftArea;
                        X2 = m_GdPictureImaging.Barcode1DReaderGetBarcodeX2(i) + (int)LeftArea;
                        X3 = m_GdPictureImaging.Barcode1DReaderGetBarcodeX3(i) + (int)LeftArea;
                        X4 = m_GdPictureImaging.Barcode1DReaderGetBarcodeX4(i) + (int)LeftArea;

                        Y1 = m_GdPictureImaging.Barcode1DReaderGetBarcodeY1(i) + (int)TopArea;
                        Y2 = m_GdPictureImaging.Barcode1DReaderGetBarcodeY2(i) + (int)TopArea;
                        Y3 = m_GdPictureImaging.Barcode1DReaderGetBarcodeY3(i) + (int)TopArea;
                        Y4 = m_GdPictureImaging.Barcode1DReaderGetBarcodeY4(i) + (int)TopArea;

                        DrawBoundingBox(Color.Red, X1, X2, X3, X4, Y1, Y2, Y3, Y4);
                    }
                    GdViewer1.Redraw();
                }
                m_GdPictureImaging.Barcode1DReaderClear();
            }

            if (chkDetectDataMatrix.IsChecked == true)
            {
                BarcodeDataMatrixReaderScanMode scanMode = default(BarcodeDataMatrixReaderScanMode);
                if (chkHQDetection.IsChecked == true)
                {
                    scanMode = BarcodeDataMatrixReaderScanMode.BestQuality;
                }
                else
                {
                    scanMode = BarcodeDataMatrixReaderScanMode.BestSpeed;
                }
                m_GdPictureImaging.BarcodeDataMatrixReaderDoScan(m_ImageID, scanMode, expectedCount);

                bcfound = m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount();
                if (bcfound > 0)
                {
                    for (int i = 1; i <= m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount(); i++)
                    {
                        bccount++;
                        result.Append("Barcode No: " + (bccount.ToString() + "\r\n"));
                        result.Append("------------------------------------------------" + "\r\n");
                        result.Append("Barcode Type: 2D - Datamatrix" + "\r\n");
                        result.Append("Barcode Rows: " + (m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeRows(i).ToString() + "\r\n"));
                        result.Append("Barcode Columns: " + (m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeColumns(i).ToString() + "\r\n"));
                        result.Append("Barcode Value: " + (m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeValue(i) + "\r\n" + "\r\n"));
                    }
                    expectedCount -= bcfound;
                }


                if (CheckBox1.IsChecked == false) //Drawing bounding boxes
                {
                    int X1 = 0;
                    int X2 = 0;
                    int X3 = 0;
                    int X4 = 0;
                    int Y1 = 0;
                    int Y2 = 0;
                    int Y3 = 0;
                    int Y4 = 0;

                    for (int i = 1; i <= m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeCount(); i++)
                    {
                        X1 = m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX1(i) + (int)LeftArea;
                        X2 = m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX2(i) + (int)LeftArea;
                        X3 = m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX3(i) + (int)LeftArea;
                        X4 = m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeX4(i) + (int)LeftArea;

                        Y1 = m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY1(i) + (int)TopArea;
                        Y2 = m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY2(i) + (int)TopArea;
                        Y3 = m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY3(i) + (int)TopArea;
                        Y4 = m_GdPictureImaging.BarcodeDataMatrixReaderGetBarcodeY4(i) + (int)TopArea;

                        DrawBoundingBox(Color.Blue, X1, X2, X3, X4, Y1, Y2, Y3, Y4);
                    }
                    GdViewer1.Redraw();
                }

                m_GdPictureImaging.BarcodeDataMatrixReaderClear();
            }


            if (chkDetectQRCode.IsChecked == true)
            {
                BarcodeQRReaderScanMode scanMode = default(BarcodeQRReaderScanMode);
                if (chkHQDetection.IsChecked == true)
                {
                    scanMode = BarcodeQRReaderScanMode.BestQuality;
                }
                else
                {
                    scanMode = BarcodeQRReaderScanMode.BestSpeed;
                }
                m_GdPictureImaging.BarcodeQRReaderDoScan(m_ImageID, scanMode, expectedCount);

                bcfound = m_GdPictureImaging.BarcodeQRReaderGetBarcodeCount();
                if (bcfound > 0)
                {
                    for (int i = 1; i <= m_GdPictureImaging.BarcodeQRReaderGetBarcodeCount(); i++)
                    {
                        bccount++;
                        result.Append("Barcode No: " + (bccount.ToString() + "\r\n"));
                        result.Append("------------------------------------------------" + "\r\n");
                        result.Append("Barcode Type: 2D - qr" + "\r\n");
                        result.Append("Barcode Confidence: " + (m_GdPictureImaging.BarcodeQRReaderGetBarcodeConfidence(i).ToString() + "\r\n"));
                        result.Append("Barcode Version: " + (m_GdPictureImaging.BarcodeQRReaderGetVersion(i).ToString() + "\r\n"));
                        result.Append("Barcode Value: " + (m_GdPictureImaging.BarcodeQRReaderGetBarcodeValue(i) + "\r\n" + "\r\n"));
                    }
                }


                if (CheckBox1.IsChecked == false) //Drawing bounding boxes
                {
                    int X1 = 0;
                    int X2 = 0;
                    int X3 = 0;
                    int X4 = 0;
                    int Y1 = 0;
                    int Y2 = 0;
                    int Y3 = 0;
                    int Y4 = 0;

                    for (int i = 1; i <= m_GdPictureImaging.BarcodeQRReaderGetBarcodeCount(); i++)
                    {
                        X1 = m_GdPictureImaging.BarcodeQRReaderGetBarcodeX1(i) + (int)LeftArea;
                        X2 = m_GdPictureImaging.BarcodeQRReaderGetBarcodeX2(i) + (int)LeftArea;
                        X3 = m_GdPictureImaging.BarcodeQRReaderGetBarcodeX3(i) + (int)LeftArea;
                        X4 = m_GdPictureImaging.BarcodeQRReaderGetBarcodeX4(i) + (int)LeftArea;

                        Y1 = m_GdPictureImaging.BarcodeQRReaderGetBarcodeY1(i) + (int)TopArea;
                        Y2 = m_GdPictureImaging.BarcodeQRReaderGetBarcodeY2(i) + (int)TopArea;
                        Y3 = m_GdPictureImaging.BarcodeQRReaderGetBarcodeY3(i) + (int)TopArea;
                        Y4 = m_GdPictureImaging.BarcodeQRReaderGetBarcodeY4(i) + (int)TopArea;

                        DrawBoundingBox(Color.Green, X1, X2, X3, X4, Y1, Y2, Y3, Y4);
                    }
                    GdViewer1.Redraw();
                }

                m_GdPictureImaging.BarcodeQRReaderClear();
            }


            if (chkDetectMicroQRCode.IsChecked == true)
            {
                BarcodeQRReaderScanMode scanMode = default(BarcodeQRReaderScanMode);
                if (chkHQDetection.IsChecked == true)
                {
                    scanMode = BarcodeQRReaderScanMode.BestQuality;
                }
                else
                {
                    scanMode = BarcodeQRReaderScanMode.BestSpeed;
                }
                m_GdPictureImaging.BarcodeMicroQRReaderDoScan(m_ImageID, scanMode, expectedCount);

                bcfound = m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount();
                if (bcfound > 0)
                {
                    for (int i = 1; i <= m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount(); i++)
                    {
                        bccount++;
                        result.Append("Barcode No: " + (bccount.ToString() + "\r\n"));
                        result.Append("------------------------------------------------" + "\r\n");
                        result.Append("Barcode Type: 2D - micro qr" + "\r\n");
                        result.Append("Barcode Confidence: " + (m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeConfidence(i).ToString() + "\r\n"));
                        result.Append("Barcode Version: " + (m_GdPictureImaging.BarcodeMicroQRReaderGetVersion(i).ToString() + "\r\n"));
                        result.Append("Barcode Value: " + (m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeValue(i) + "\r\n" + "\r\n"));
                    }
                }


                if (CheckBox1.IsChecked == false) //Drawing bounding boxes
                {
                    int X1 = 0;
                    int X2 = 0;
                    int X3 = 0;
                    int X4 = 0;
                    int Y1 = 0;
                    int Y2 = 0;
                    int Y3 = 0;
                    int Y4 = 0;

                    for (int i = 1; i <= m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeCount(); i++)
                    {
                        X1 = m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeX1(i) + (int)LeftArea;
                        X2 = m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeX2(i) + (int)LeftArea;
                        X3 = m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeX3(i) + (int)LeftArea;
                        X4 = m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeX4(i) + (int)LeftArea;

                        Y1 = m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeY1(i) + (int)TopArea;
                        Y2 = m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeY2(i) + (int)TopArea;
                        Y3 = m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeY3(i) + (int)TopArea;
                        Y4 = m_GdPictureImaging.BarcodeMicroQRReaderGetBarcodeY4(i) + (int)TopArea;

                        DrawBoundingBox(Color.Green, X1, X2, X3, X4, Y1, Y2, Y3, Y4);
                    }
                    GdViewer1.Redraw();
                }

                m_GdPictureImaging.BarcodeMicroQRReaderClear();
            }



            if (chkDetectPDF417.IsChecked == true)
            {
                BarcodePDF417ReaderScanMode scanMode = default(BarcodePDF417ReaderScanMode);
                if (chkHQDetection.IsChecked == true)
                {
                    scanMode = BarcodePDF417ReaderScanMode.BestQuality;
                }
                else
                {
                    scanMode = BarcodePDF417ReaderScanMode.BestSpeed;
                }
                m_GdPictureImaging.BarcodePDF417ReaderDoScan(m_ImageID, scanMode, expectedCount);

                bcfound = m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeCount();
                if (bcfound > 0)
                {
                    for (int i = 1; i <= m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeCount(); i++)
                    {
                        bccount++;
                        result.Append("Barcode No: " + (bccount.ToString() + "\r\n"));
                        result.Append("------------------------------------------------" + "\r\n");
                        result.Append("Barcode Type: 2D - PDF417" + "\r\n");
                        result.Append("Barcode Rows: " + (m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeRows(i).ToString() + "\r\n"));
                        result.Append("Barcode Columns: " + (m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeColumns(i).ToString() + "\r\n"));
                        result.Append("Accuracy: " + (m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeConfidence(i).ToString() + "\r\n"));
                        result.Append("Barcode Value: " + (m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeValue(i) + "\r\n" + "\r\n"));
                    }
                    expectedCount -= bcfound;
                }


                if (CheckBox1.IsChecked == false) //Drawing bounding boxes
                {
                    int X1 = 0;
                    int X2 = 0;
                    int X3 = 0;
                    int X4 = 0;
                    int Y1 = 0;
                    int Y2 = 0;
                    int Y3 = 0;
                    int Y4 = 0;

                    for (int i = 1; i <= m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeCount(); i++)
                    {
                        X1 = m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeX1(i) + (int)LeftArea;
                        X2 = m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeX2(i) + (int)LeftArea;
                        X3 = m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeX3(i) + (int)LeftArea;
                        X4 = m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeX4(i) + (int)LeftArea;

                        Y1 = m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeY1(i) + (int)TopArea;
                        Y2 = m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeY2(i) + (int)TopArea;
                        Y3 = m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeY3(i) + (int)TopArea;
                        Y4 = m_GdPictureImaging.BarcodePDF417ReaderGetBarcodeY4(i) + (int)TopArea;

                        DrawBoundingBox(Color.Violet, X1, X2, X3, X4, Y1, Y2, Y3, Y4);
                    }
                    GdViewer1.Redraw();
                }

                m_GdPictureImaging.BarcodePDF417ReaderClear();
            }

            if (chkDetectPatchCode.IsChecked == true)
            {
                m_GdPictureImaging.PatchCodeReaderDoScan(m_ImageID);

                bcfound = m_GdPictureImaging.PatchCodeReaderGetCodeCount();
                if (bcfound > 0)
                {
                    for (int i = 1; i <= m_GdPictureImaging.PatchCodeReaderGetCodeCount(); i++)
                    {
                        pccount++;
                        result.Append("Patchcode  No: " + (pccount.ToString() + "\r\n"));
                        result.Append("------------------------------------------------" + "\r\n");
                        result.Append("Patchcode Type: " + (m_GdPictureImaging.PatchCodeReaderGetCodeType(i).ToString() + "\r\n"));
                        result.Append("\r\n");
                    }
                }


                if (CheckBox1.IsChecked == false) //Drawing bounding boxes
                {
                    int X1 = 0;
                    int X2 = 0;
                    int X3 = 0;
                    int X4 = 0;
                    int Y1 = 0;
                    int Y2 = 0;
                    int Y3 = 0;
                    int Y4 = 0;

                    for (int i = 1; i <= m_GdPictureImaging.PatchCodeReaderGetCodeCount(); i++)
                    {
                        X1 = m_GdPictureImaging.PatchCodeReaderGetCodeX1(i) + (int)LeftArea;
                        X2 = m_GdPictureImaging.PatchCodeReaderGetCodeX2(i) + (int)LeftArea;
                        X3 = m_GdPictureImaging.PatchCodeReaderGetCodeX3(i) + (int)LeftArea;
                        X4 = m_GdPictureImaging.PatchCodeReaderGetCodeX4(i) + (int)LeftArea;

                        Y1 = m_GdPictureImaging.PatchCodeReaderGetCodeY1(i) + (int)TopArea;
                        Y2 = m_GdPictureImaging.PatchCodeReaderGetCodeY2(i) + (int)TopArea;
                        Y3 = m_GdPictureImaging.PatchCodeReaderGetCodeY3(i) + (int)TopArea;
                        Y4 = m_GdPictureImaging.PatchCodeReaderGetCodeY4(i) + (int)TopArea;

                        DrawBoundingBox(Color.Orange, X1, X2, X3, X4, Y1, Y2, Y3, Y4);
                    }
                    GdViewer1.Redraw();
                }

                m_GdPictureImaging.PatchCodeReaderClear();
            }


            string resultFilePath = "result.txt";


            if (File.Exists(resultFilePath))
            {
                File.Delete(resultFilePath);
            }
            using (FileStream fs = new FileStream(resultFilePath, FileMode.CreateNew))
            {
                byte[] b = Encoding.Unicode.GetBytes(result.ToString());
                fs.Write(b, 0, b.Length);
            }


            ShellExecute(IntPtr.Zero, "", "result.txt", "", "", 1);
            GdViewer1.Redraw();
            ShowImageInfo();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (m_DocSourceType == DocumentType.DocumentTypePDF) //special case for PDF
            {
                renderPdfPage(m_GdPicturePDF.GetCurrentPage() - 1);
                GdViewer1.DisplayFromGdPictureImage(m_ImageID);
            }
            else
            {
                GdViewer1.DisplayPreviousPage();
            }
            ShowImageInfo();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (m_DocSourceType == DocumentType.DocumentTypePDF) //special case for PDF
            {
                renderPdfPage(m_GdPicturePDF.GetCurrentPage() + 1);
                GdViewer1.DisplayFromGdPictureImage(m_ImageID);
            }
            else
            {
                GdViewer1.DisplayNextPage();
            }
            ShowImageInfo();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GdViewer1.ZoomIN();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GdViewer1.ZoomOUT();
        }

        public void DoEvents()
        {
            DispatcherFrame frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background, new DispatcherOperationCallback(ExitFrame), frame);
            Dispatcher.PushFrame(frame);
        }

        public object ExitFrame(Object f)
        {
            DispatcherFrame temp = (DispatcherFrame)f;
            temp.Continue = false;
            return null;
        }

        public void doDespeckle()
        {
            DoEvents();
            if (_ClonedImage != 0)
            {
                m_GdPictureImaging.ReleaseGdPictureImage(_ClonedImage);
            }
            if (m_ImageID != 0)
            {
                _ClonedImage = m_GdPictureImaging.CreateClonedGdPictureImage(m_ImageID);
                if (_ClonedImage == 0)
                {
                    MessageBox.Show("Error : " + m_GdPictureImaging.GetStat().ToString());
                    return;
                }
            }

            m_GdPictureImaging.FxBitonalDespeckleAdvanced(_ClonedImage, _despeckleType, _despeckleStrength);

            if (m_GdPictureImaging.GetStat() == GdPictureStatus.OK)
            {
                if (GdViewer1.DisplayFromGdPictureImage(_ClonedImage) != GdPictureStatus.OK)
                {
                    MessageBox.Show("The Image cannot be displayed");
                }
            }
            else
            {
                MessageBox.Show("Can\'t binarize image. Error: " + m_GdPictureImaging.GetStat().ToString());
            }
        }

        public void doThreshold()
        {
            DoEvents();
            if (_ClonedImage != 0)
            {
                m_GdPictureImaging.ReleaseGdPictureImage(_ClonedImage);
            }
            if (m_ImageID != 0)
            {
                _ClonedImage = m_GdPictureImaging.CreateClonedGdPictureImage(m_ImageID);
                if (_ClonedImage == 0)
                {
                    MessageBox.Show("Error : " + m_GdPictureImaging.GetStat().ToString());
                    return;
                }
            }

            switch (_thresholdType)
            {
                case 0: //Linear
                    m_GdPictureImaging.ConvertTo1Bpp(_ClonedImage, (byte)_thresholdValue);
                    break;
                case 1: //Adaptive (Otsu)
                    m_GdPictureImaging.ConvertTo1BppAT(_ClonedImage, _thresholdValue);
                    break;
                case 2: //Sauvola
                    m_GdPictureImaging.ConvertTo1BppSauvola(_ClonedImage, _thresholdValue / 100.0F, _contrastMinDif, _smoothKernel);
                    break;
            }

            if (m_GdPictureImaging.GetStat() == GdPictureStatus.OK)
            {
                if (GdViewer1.DisplayFromGdPictureImage(_ClonedImage) != GdPictureStatus.OK)
                {
                    MessageBox.Show("The Image cannot be displayed");
                }
            }
            else
            {
                MessageBox.Show("Can\'t binarize image. Error: " + m_GdPictureImaging.GetStat().ToString());
            }
        }

        private void chkDetect1D_Checked(object sender, RoutedEventArgs e)
        {
            options1DEngine.Visibility = System.Windows.Visibility.Visible;
        }

        private void chkDetect1D_Unchecked(object sender, RoutedEventArgs e)
        {
            options1DEngine.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
