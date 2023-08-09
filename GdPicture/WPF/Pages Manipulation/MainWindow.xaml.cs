using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using GdPicture14;

namespace Csharp_Pages_Manipulation.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string m_Password = "";
        private GdPictureImaging m_GdPictureImaging = new GdPictureImaging();
        private GdPicture14.DocumentFormat m_DocumentFormat;
        private int m_NativeImage;
        private GdPicturePDF m_NativePDF = new GdPicturePDF();

        public MainWindow()
        {
            InitializeComponent();
            ThumbnailEx1.AllowMoveItems = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseManager oLicenceManager = new LicenseManager(); //Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.
            oLicenceManager.RegisterKEY("XXXX");//Please, replace XXXX by a valid demo or commercial license key. 
            BookmarksTree1.GdViewer = GdViewer1;
            AlignmentMC.IsChecked = true;
            PositionMC.IsChecked = true;
        }

        #region "File Menu"
        private void OpenFileCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenFileCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseDocument();
            bool openOK = false;
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "PDF|*.pdf|TIFF Image|*.tif";
            if (openFD.ShowDialog(this) == true)
            {
                string filePath = openFD.FileName;
                GdPicture14.DocumentFormat docFormat = GdPictureDocumentUtilities.GetDocumentFormat(filePath);
                if (docFormat == GdPicture14.DocumentFormat.DocumentFormatPDF)
                {
                    // We use the GdPicturePDF class to handle the document
                    if (m_NativePDF.LoadFromFile(filePath, false) == GdPictureStatus.OK)
                    {
                        m_DocumentFormat = GdPicture14.DocumentFormat.DocumentFormatPDF;
                        if (GdViewer1.DisplayFromGdPicturePDF(m_NativePDF) != GdPictureStatus.OK)
                            MessageBox.Show("Image Cannot be displayed");
                        openOK = true;
                    }
                    else
                    {
                        MessageBox.Show("Cannot load image: " + m_NativePDF.GetStat().ToString());
                    }

                }
                else
                {
                    // We use the GdPictureImaging class to handle the document as an editable multipage tiff image
                    m_NativeImage = m_GdPictureImaging.TiffCreateMultiPageFromFile(filePath);
                    if (m_NativeImage != 0)
                    {
                        m_DocumentFormat = GdPicture14.DocumentFormat.DocumentFormatTIFF;
                        if (GdViewer1.DisplayFromGdPictureImage(m_NativeImage) != GdPictureStatus.OK)
                            MessageBox.Show("Image Cannot be displayed");
                        openOK = true;
                    }
                    else
                    {
                        MessageBox.Show("Image Cannot be loaded: " + m_GdPictureImaging.GetStat().ToString());
                    }
                }
                if (openOK)
                {
                    GdViewer1.Focus();
                    ThumbnailEx1.LoadFromGdViewer(GdViewer1);
                    ShowCurrentPage();
                }
            }
        }


        private void ShowCurrentPage()
        {
            if (GdViewer1.CurrentPage != 0)
                labelCurrentPage.Content = GdViewer1.CurrentPage.ToString() + "/" + GdViewer1.PageCount.ToString();
            else
                labelCurrentPage.Content = "";
        }

        private void PropertiesCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                if (GdViewer1.GetDocumentType() == DocumentType.DocumentTypePDF)
                    e.CanExecute = true;
        }

        private void PropertiesCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            wndProperties pr = new wndProperties();
            pr.Show();
        }

        private void PrintCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void PrintCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.PrintSetDocumentName("GdPicture Document Viewer Printing");
            GdViewer1.PrintSetAutoRotation(true);
            GdViewer1.PrintSetAlignment(PrintAlignment.PrintAlignmentMiddleCenter);
            GdViewer1.PrintDialog(PrintSizeOption.PrintSizeOptionShrinkOversized, this); ;
        }

        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

            if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatPDF)
            {
                SaveFileDialog1.DefaultExt = "pdf";
                SaveFileDialog1.Filter = "PDF|*.pdf";
                if (SaveFileDialog1.ShowDialog(this) == true)
                {
                    if (m_NativePDF.SaveToFileInc(SaveFileDialog1.FileName) == GdPictureStatus.OK)
                    {
                        MessageBox.Show("Document succefully saved");
                    }
                    else
                    {
                        MessageBox.Show("Can't save document. Status: " + m_NativePDF.GetStat().ToString());
                    }
                }
            }
            else
            {
                if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatTIFF)
                {
                    SaveFileDialog1.DefaultExt = "tif";
                    SaveFileDialog1.Filter = "TIFF Image|*.tif";
                    if (SaveFileDialog1.ShowDialog(this) == true)
                    {
                        if (m_GdPictureImaging.TiffSaveMultiPageToFile(m_NativeImage, SaveFileDialog1.FileName, TiffCompression.TiffCompressionAUTO) == GdPictureStatus.OK)
                        {
                            MessageBox.Show("Document succefully saved");
                        }
                        else
                        {
                            MessageBox.Show("Can't save document. Status: " + m_GdPictureImaging.GetStat().ToString());
                        }
                    }
                }
            }
        }

        private void CloseCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseDocument();
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Page Navigation"


        private void DeleteSelectedPageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void DeleteSelectedPageCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatPDF)
            {
                int pageNo = m_NativePDF.GetCurrentPage();
                if (m_NativePDF.DeletePage(pageNo) != GdPictureStatus.OK)
                    MessageBox.Show("Error: " + m_NativePDF.GetStat().ToString());
                ThumbnailEx1.RemoveItem(pageNo - 1);
            }
            else
            {
                if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatTIFF)
                {
                    int pageNo = m_GdPictureImaging.TiffGetCurrentPage(m_NativeImage);
                    if (m_GdPictureImaging.TiffDeletePage(m_NativeImage, pageNo) != GdPictureStatus.OK)
                        MessageBox.Show("Error: " + m_GdPictureImaging.GetStat().ToString());
                    ThumbnailEx1.RemoveItem(pageNo - 1);
                }
            }
            if (GdViewer1.Redraw() != GdPictureStatus.OK)
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString());

            ShowCurrentPage();
        }

        private void FirstPageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0 && GdViewer1.CurrentPage != 1)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void FirstPageCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.DisplayFirstPage();
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void PreviousPageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0 && GdViewer1.CurrentPage > 1)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void PreviousPageCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.DisplayPreviousPage();
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void NextPageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0 && GdViewer1.CurrentPage != GdViewer1.PageCount)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void NextPageCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.DisplayNextPage();
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void LastPageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0 && GdViewer1.CurrentPage != GdViewer1.PageCount)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

        private void LastPageCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.DisplayLastPage();
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }
        #endregion

        private void CloseDocument()
        {
            GdViewer1.CloseDocument();
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter;
            ThumbnailEx1.ClearAllItems();
            if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatTIFF)
            {
                m_GdPictureImaging.ReleaseGdPictureImage(m_NativeImage);
                m_NativeImage = 0;
            }
            else
            {
                if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatPDF)
                {
                    m_NativePDF.CloseDocument();
                }
            }
            m_DocumentFormat = GdPicture14.DocumentFormat.DocumentFormatUNKNOWN;
            ShowCurrentPage();
            txtSearch.IsEnabled = false;
            statusLabel.Content = "";
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                GdViewer1.RemoveAllRegions();
                if (!(GdViewer1.SearchText(txtSearch.Text, 0, false)))
                {
                    MessageBox.Show("Not found !");
                }
            }
        }

        private void GdViewer1_PDFPasswordRequest(ref string PassWord)
        {
            m_Password = "";
            inputBox iB = new inputBox();
            bool? result = iB.ShowDialog();
            if (result == true)
            {
                PassWord = m_Password;
            }
        }


        #region "Page Text"

        private void PageTextCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                if (GdViewer1.GetDocumentType() == DocumentType.DocumentTypePDF)
                    e.CanExecute = true;
        }

        private void PageTextCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show(GdViewer1.GetPageText());
        }

        private void AreaTextCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                if (GdViewer1.GetDocumentType() == DocumentType.DocumentTypePDF)
                    if (GdViewer1.IsRect())
                        e.CanExecute = true;
        }

        private void AreaTextCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            double top = 0, left = 0, width = 0, height = 0;
            GdViewer1.GetRectCoordinatesOnDocumentInch(ref left, ref top, ref width, ref height);
            MessageBox.Show(GdViewer1.GetPageTextArea(GdViewer1.CurrentPage, left, top, width, height));
        }
        #endregion

        #region "Rotation"

        private void RotateCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                e.CanExecute = true;
        }

        private void Rotate90Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RemoveAllRegions();
            if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatPDF)
            {
                if (m_NativePDF.RotatePage(90) != GdPictureStatus.OK)
                    MessageBox.Show("Error: " + m_NativePDF.GetStat().ToString());
            }
            else
            {
                if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatTIFF)
                {
                    if (m_GdPictureImaging.Rotate(m_NativeImage, System.Drawing.RotateFlipType.Rotate90FlipNone) != GdPictureStatus.OK)
                        MessageBox.Show("Error: " + m_GdPictureImaging.GetStat().ToString());
                }
            }
            if (GdViewer1.Redraw() != GdPictureStatus.OK)
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString());
            ThumbnailEx1.RedrawItem(GdViewer1.CurrentPage - 1);
        }

        private void Rotate180Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RemoveAllRegions();
            if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatPDF)
            {
                if (m_NativePDF.RotatePage(180) != GdPictureStatus.OK)
                    MessageBox.Show("Error: " + m_NativePDF.GetStat().ToString());
            }
            else
            {
                if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatTIFF)
                {
                    if (m_GdPictureImaging.Rotate(m_NativeImage, System.Drawing.RotateFlipType.Rotate180FlipNone) != GdPictureStatus.OK)
                        MessageBox.Show("Error: " + m_GdPictureImaging.GetStat().ToString());
                }
            }
            if (GdViewer1.Redraw() != GdPictureStatus.OK)
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString());
            ThumbnailEx1.RedrawItem(GdViewer1.CurrentPage - 1);
        }

        private void Rotate270Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RemoveAllRegions();
            if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatPDF)
            {
                if (m_NativePDF.RotatePage(270) != GdPictureStatus.OK)
                    MessageBox.Show("Error: " + m_NativePDF.GetStat().ToString());
            }
            else
            {
                if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatTIFF)
                {
                    if (m_GdPictureImaging.Rotate(m_NativeImage, System.Drawing.RotateFlipType.Rotate270FlipNone) != GdPictureStatus.OK)
                        MessageBox.Show("Error: " + m_GdPictureImaging.GetStat().ToString());
                }
            }
            if (GdViewer1.Redraw() != GdPictureStatus.OK)
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString());
            ThumbnailEx1.RedrawItem(GdViewer1.CurrentPage - 1);
        }

        #endregion

        #region "Zoom"

        private void ZoomCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                e.CanExecute = true;
        }

        private void Zoom50Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.Zoom = 0.5;
        }

        private void Zoom100Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.Zoom = 1.0;
        }

        private void Zoom150Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.Zoom = 1.5;
        }

        private void Zoom200Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.Zoom = 2.0;
        }

        private void ZoomINCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (GdViewer1.ZoomIN() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Zoom IN");
        }

        private void ZoomOUTCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (GdViewer1.ZoomOUT() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Zoom OUT");
        }

        private void ZoomBestFitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
        }

        private void ZoomHeightFitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeHeightViewer;
        }

        private void ZoomWidthFitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
        }
        #endregion


        #region "Mouse Mode"

        private void UncheckMouseMode()
        {
            panMenuItem.IsChecked = false;
            autoZoomMenuItem.IsChecked = false;
            areaSelectionMenuItem.IsChecked = false;
            magnifierMenuItem.IsChecked = false;
            nothingMenuItem.IsChecked = false;
        }

        private void MouseModeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void MousePanCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModePan;
            UncheckMouseMode();
            panMenuItem.IsChecked = true;
        }

        private void MouseAutoZoomCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming;
            UncheckMouseMode();
            autoZoomMenuItem.IsChecked = true;
        }

        private void MouseAreaSelectionCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection;
            UncheckMouseMode();
            areaSelectionMenuItem.IsChecked = true;
        }

        private void MouseMagnifierCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeMagnifier;
            UncheckMouseMode();
            magnifierMenuItem.IsChecked = true;
        }

        private void MouseNothingCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeDefault;
            UncheckMouseMode();
            nothingMenuItem.IsChecked = true;
        }
        #endregion

        #region "Mouse Wheel"

        private void UncheckMouseWheel()
        {
            zoomChangingMenuItem.IsChecked = false;
            pageScrollingMenuItem.IsChecked = false;
            pageChangingMenuItem.IsChecked = false;
        }
        private void MouseWheelCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void MouseWheelZoomCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseWheelMode = ViewerMouseWheelMode.MouseWheelModeZoom;
            UncheckMouseWheel();
            zoomChangingMenuItem.IsChecked = true;
        }

        private void MouseWheelVerticalScrollCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseWheelMode = ViewerMouseWheelMode.MouseWheelModeVerticalScroll;
            UncheckMouseWheel();
            pageScrollingMenuItem.IsChecked = true;
        }

        private void MouseWheelPageChangeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseWheelMode = ViewerMouseWheelMode.MouseWheelModePageChange;
            UncheckMouseWheel();
            pageChangingMenuItem.IsChecked = true;
        }
        #endregion

        #region "Thumbnail Size"

        private void UncheckThumbnailSize()
        {
            smallThumbnailsMenuItem.IsChecked = false;
            mediumThumbnailsMenuItem.IsChecked = false;
            largeThumbnailsMenuItem.IsChecked = false;
            extralargeThumbnailsMenuItem.IsChecked = false;
        }

        private void ThumbnailSizeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SmallThumbCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new System.Windows.Size(64, 64);
            UncheckThumbnailSize();
            smallThumbnailsMenuItem.IsChecked = true;

        }

        private void MediumThumbCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new System.Windows.Size(128, 128);
            UncheckThumbnailSize();
            mediumThumbnailsMenuItem.IsChecked = true;
        }

        private void LargeThumbCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new System.Windows.Size(256, 256);
            UncheckThumbnailSize();
            largeThumbnailsMenuItem.IsChecked = true;

        }

        private void ExLargeThumbCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new System.Windows.Size(512, 512);
            UncheckThumbnailSize();
            extralargeThumbnailsMenuItem.IsChecked = true;
        }

        #endregion

        private void textSearch_LostFocus(object sender, System.EventArgs e)
        {
            txtSearch.Text = "Find...";
        }

        private void textSearch_GotFocus(object sender, System.EventArgs e)
        {
            if (txtSearch.Text == "Find...")
            {
                txtSearch.Text = "";
            }
        }


        #region "Document Alignment"

        private void RemoveAlignmentCheck()
        {
            AlignmentML.IsChecked = false;
            AlignmentMC.IsChecked = false;
            AlignmentMR.IsChecked = false;
            AlignmentTL.IsChecked = false;
            AlignmentTC.IsChecked = false;
            AlignmentTR.IsChecked = false;
            AlignmentBL.IsChecked = false;
            AlignmentBC.IsChecked = false;
            AlignmentBR.IsChecked = false;
        }

        private void DocumentAlignmentCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AlignmentMLCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemoveAlignmentCheck();
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentMiddleLeft;
            AlignmentML.IsChecked = true;
        }

        private void AlignmentMCCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemoveAlignmentCheck();
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            AlignmentMC.IsChecked = true;
        }


        private void AlignmentMRCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemoveAlignmentCheck();
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentMiddleRight;
            AlignmentMR.IsChecked = true;
        }

        private void AlignmentTLCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemoveAlignmentCheck();
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopLeft;
            AlignmentTL.IsChecked = true;
        }

        private void AlignmentTCCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemoveAlignmentCheck();
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter;
            AlignmentTC.IsChecked = true;
        }


        private void AlignmentTRCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemoveAlignmentCheck();
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopRight;
            AlignmentTR.IsChecked = true;
        }

        private void AlignmentBLCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemoveAlignmentCheck();
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentBottomLeft;
            AlignmentBL.IsChecked = true;
        }

        private void AlignmentBCCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemoveAlignmentCheck();
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentBottomCenter;
            AlignmentBC.IsChecked = true;
        }


        private void AlignmentBRCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemoveAlignmentCheck();
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentBottomRight;
            AlignmentBR.IsChecked = true;
        }
        #endregion

        #region "Document Position"

        private void RemovePositionCheck()
        {
            PositionML.IsChecked = false;
            PositionMC.IsChecked = false;
            PositionMR.IsChecked = false;
            PositionTL.IsChecked = false;
            PositionTC.IsChecked = false;
            PositionTR.IsChecked = false;
            PositionBL.IsChecked = false;
            PositionBC.IsChecked = false;
            PositionBR.IsChecked = false;
        }

        private void DocumentPositionCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void PositionMLCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemovePositionCheck();
            GdViewer1.DocumentPosition = ViewerDocumentPosition.DocumentPositionMiddleLeft;
            PositionML.IsChecked = true;
        }

        private void PositionMCCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemovePositionCheck();
            GdViewer1.DocumentPosition = ViewerDocumentPosition.DocumentPositionMiddleCenter;
            PositionMC.IsChecked = true;
        }


        private void PositionMRCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemovePositionCheck();
            GdViewer1.DocumentPosition = ViewerDocumentPosition.DocumentPositionMiddleRight;
            PositionMR.IsChecked = true;
        }

        private void PositionTLCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemovePositionCheck();
            GdViewer1.DocumentPosition = ViewerDocumentPosition.DocumentPositionTopLeft;
            PositionTL.IsChecked = true;
        }

        private void PositionTCCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemovePositionCheck();
            GdViewer1.DocumentPosition = ViewerDocumentPosition.DocumentPositionTopCenter;
            PositionTC.IsChecked = true;
        }


        private void PositionTRCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemovePositionCheck();
            GdViewer1.DocumentPosition = ViewerDocumentPosition.DocumentPositionTopRight;
            PositionTR.IsChecked = true;
        }

        private void PositionBLCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemovePositionCheck();
            GdViewer1.DocumentPosition = ViewerDocumentPosition.DocumentPositionBottomLeft;
            PositionBL.IsChecked = true;
        }

        private void PositionBCCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemovePositionCheck();
            GdViewer1.DocumentPosition = ViewerDocumentPosition.DocumentPositionBottomCenter;
            PositionBC.IsChecked = true;
        }


        private void PositionBRCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RemovePositionCheck();
            GdViewer1.DocumentPosition = ViewerDocumentPosition.DocumentPositionBottomRight;
            PositionBR.IsChecked = true;
        }
        #endregion

        #region "Render Engine"

        private void UncheckRenderEngine()
        {
            gdipRendering.IsChecked = false;
            wpfRendering.IsChecked = false;
            hybridRendering.IsChecked = false;
        }

        private void RenderEngineCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void RenderEngineGDICommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            UncheckRenderEngine();
            gdipRendering.IsChecked = true;
        }


        private void RenderEngineWPFCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            UncheckRenderEngine();
            wpfRendering.IsChecked = true;
        }


        private void RenderEngineHYBRIDCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            UncheckRenderEngine();
            hybridRendering.IsChecked = true;
        }
        #endregion


        private void GdViewer1_PageChanged(object sender, GdPicture14.WPF.GdViewer.PageChangedEventArgs e)
        {
            GdViewer1.RemoveAllRegions();
            ShowCurrentPage();
        }

        private void GdViewer1_PageDisplayed(object sender, GdPicture14.WPF.GdViewer.PageDisplayedEventArgs e)
        {
            this.statusLabel.Content = "Page No : " + GdViewer1.CurrentPage.ToString() + " / " + GdViewer1.PageCount.ToString() +
                                       "   -   " +
                                       "Page Size (inches) : " + Math.Round(GdViewer1.PageInchHeight, 2).ToString() + " * " + Math.Round(GdViewer1.PageInchWidth, 2).ToString() +
                                       "   -   " + "Page Size (pixels) : " + GdViewer1.PagePixelHeight.ToString() + " * " + GdViewer1.PagePixelWidth.ToString() +
                                       "   -   " + "Horizontal resolution : " + Math.Round(GdViewer1.PageHorizontalResolution, 2).ToString() + " dpi   -   " +
                                       "Vertical resolution : " + Math.Round(GdViewer1.PageVerticalResolution, 2).ToString() + " dpi";

        }

        private void ThumbnailEx1_ItemMoved(object sender, GdPicture14.WPF.ThumbnailEx.ItemMovedEventArgs e)
        {
            if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatPDF)
            {
                if (m_NativePDF.MovePage(e.srcIdx + 1, e.dstIdx + 1) != GdPictureStatus.OK)
                    MessageBox.Show("Error: " + m_NativePDF.GetStat().ToString());
            }
            else
            {
                if (m_DocumentFormat == GdPicture14.DocumentFormat.DocumentFormatTIFF)
                {
                    if (m_GdPictureImaging.TiffMovePage(m_NativeImage, e.srcIdx + 1, e.dstIdx + 1) != GdPictureStatus.OK)
                        MessageBox.Show("Error: " + m_GdPictureImaging.GetStat().ToString());
                }
            }
        }
    }
}
