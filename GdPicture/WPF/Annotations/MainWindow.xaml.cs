using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Forms;
using GdPicture14;

namespace Csharp_Annotations.WPF
{
    public partial class MainWindow : Window
    {
        private Color m_StrokingColor = Colors.Black;
        private Color m_FillingColor = Colors.Red;
        private float m_LineWidth = 0.020f;
        public string m_Password = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseManager oLicenceManager = new LicenseManager(); //Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.
            oLicenceManager.RegisterKEY("XXXX");//Please, replace XXXX by a valid demo or commercial license key. 
            BookmarksTree1.GdViewer = GdViewer1;
            annotationEditor1.InitFromAnnotationManager(GdViewer1.GetAnnotationManager());
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
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
            GdPictureStatus status = GdViewer1.DisplayFromFile("");
            if (status == GdPictureStatus.OK)
            {
                GdViewer1.Focus();
                ThumbnailEx1.LoadFromGdViewer(GdViewer1);
                ShowPageCount();
            }
            else
            {
                System.Windows.MessageBox.Show("Can not open file. Status: " + status.ToString());
            }
        }

        private void ShowPageCount()
        {
            if (GdViewer1.CurrentPage != 0)
                labelCurrentPage.Content = GdViewer1.CurrentPage.ToString() + "/" + GdViewer1.PageCount.ToString();
            else
                labelCurrentPage.Content = "";
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
            GdViewer1.PrintDialog(PrintSizeOption.PrintSizeOptionShrinkOversized, this);
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
            Microsoft.Win32.SaveFileDialog SaveFileDialog1 = new Microsoft.Win32.SaveFileDialog();

            SaveFileDialog1.Title = "Save Annotated Document";
            SaveFileDialog1.CheckFileExists = false;
            SaveFileDialog1.OverwritePrompt = false;
            SaveFileDialog1.Filter = "PDF|*.pdf|TIFF Image|*.tif|JPEG|*.jpg";
            if (SaveFileDialog1.ShowDialog(this) == true)
            {
                string FilePath = SaveFileDialog1.FileName;
                switch (SaveFileDialog1.FilterIndex)
                {
                    case 1:
                        if (GdViewer1.SaveDocumentToPDF(SaveFileDialog1.FileName) == GdPictureStatus.OK)
                        {
                            System.Windows.MessageBox.Show("Document succefully saved as PDF in " + FilePath);
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Can't save document in " + FilePath);
                        }
                        break;
                    case 2:
                        if (GdViewer1.SaveDocumentToTIFF(SaveFileDialog1.FileName, TiffCompression.TiffCompressionAUTO) == GdPictureStatus.OK)
                        {
                            System.Windows.MessageBox.Show("Document succefully saved as TIFF in " + FilePath);
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Can't save document in " + FilePath);
                        }
                        break;
                    case 3:
                        if (GdViewer1.SaveDocumentToJPEG(SaveFileDialog1.FileName, 75) == GdPictureStatus.OK)
                        {
                            System.Windows.MessageBox.Show("Document succefully saved as JPEG in " + FilePath);
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Can't save document in " + FilePath);
                        }
                        break;
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
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
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
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
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
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
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
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }
        #endregion


        private void CloseDocument()
        {
            GdViewer1.CloseDocument();
            ThumbnailEx1.ClearAllItems();
            statusLabel.Content = "";
            ShowPageCount();
        }


        #region "Rotation"

        private void RotateCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                e.CanExecute = true;
        }

        private void Rotate90Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotatePage(GdPictureRotateFlipType.GdPictureRotate90FlipNone);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void Rotate180Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotatePage(GdPictureRotateFlipType.GdPictureRotate180FlipNone);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void Rotate270Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotatePage(GdPictureRotateFlipType.GdPictureRotate270FlipNone);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void FlipXCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotatePage(GdPictureRotateFlipType.GdPictureRotateNoneFlipX);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void FlipYCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotatePage(GdPictureRotateFlipType.GdPictureRotateNoneFlipY);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void ViewRotate90Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotateView(GdPictureRotateFlipType.GdPictureRotate90FlipNone);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void ViewRotate180Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotateView(GdPictureRotateFlipType.GdPictureRotate180FlipNone);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void ViewRotate270Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotateView(GdPictureRotateFlipType.GdPictureRotate270FlipNone);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void ViewFlipXCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotateView(GdPictureRotateFlipType.GdPictureRotateNoneFlipX);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void ViewFlipYCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotateView(GdPictureRotateFlipType.GdPictureRotateNoneFlipY);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
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
                System.Windows.MessageBox.Show("Cannot Zoom IN");
        }

        private void ZoomOUTCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (GdViewer1.ZoomOUT() != GdPictureStatus.OK)
                System.Windows.MessageBox.Show("Cannot Zoom OUT");
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

        private void btStrokingColor_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.CancelLastAnnotInteractiveAdd();
            ColorDialog oColorPicker = new ColorDialog();
            oColorPicker.ShowDialog();

            m_StrokingColor = System.Windows.Media.Color.FromArgb(oColorPicker.Color.A, oColorPicker.Color.R, oColorPicker.Color.G, oColorPicker.Color.B);
            btStrokingColor.Background = new SolidColorBrush(m_StrokingColor);
        }

        private void btFillingColor_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.CancelLastAnnotInteractiveAdd();
            ColorDialog oColorPicker = new ColorDialog();
            oColorPicker.ShowDialog();

            m_FillingColor = System.Windows.Media.Color.FromArgb(oColorPicker.Color.A, oColorPicker.Color.R, oColorPicker.Color.G, oColorPicker.Color.B);
            btFillingColor.Background = new SolidColorBrush(m_FillingColor);
        }

        private void tsHighlightedRectangle_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddRectangleHighlighterAnnotInteractive(Colors.Yellow);
        }

        private void tsFreeHandHighlighter_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddFreeHandHighlighterAnnotInteractive(Colors.Yellow, m_LineWidth);
        }

        private void tsRectangle_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddRectangleAnnotInteractive(false, true, m_FillingColor, m_StrokingColor, m_LineWidth, 1);
        }

        private void tsFilledRectangle_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddRectangleAnnotInteractive(true, true, m_FillingColor, m_StrokingColor, 0.01f, 1);
        }

        private void tsEllipse_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddEllipseAnnotInteractive(false, true, m_FillingColor, m_StrokingColor, m_LineWidth, 1);
        }

        private void tsFilledEllipse_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddEllipseAnnotInteractive(true, true, m_FillingColor, m_StrokingColor, 0.01f, 1);
        }

        private void tsEmbeddedImage_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddEmbeddedImageAnnotInteractive("", false, Colors.White, 0.02f, 1);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                System.Windows.MessageBox.Show("Can't load bitmap");
            }
        }

        private void tsRubberStamp_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddRubberStampAnnotInteractive(txtText.Text, Color.FromArgb(255, 65, 106, 28), "Arial", System.Drawing.FontStyle.Bold, Color.FromArgb(255, 65, 106, 28), 0.2f, 0.8f, 20);
        }

        private void tsLine_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddLineAnnotInteractive(m_StrokingColor, m_LineWidth, PenLineCap.Flat, PenLineCap.Flat, 1);
        }

        private void tsConnectedLines_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddConnectedLinesAnnotInteractive(m_StrokingColor, m_LineWidth, 1);
        }

        private void tsLineArraw_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddLineArrowAnnotInteractive(m_StrokingColor, m_LineWidth, 5, 7, true, 1, false);
        }

        private void tsText_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddTextAnnotationInteractive(txtText.Text, Colors.Black, "Arial", System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, 12, true, m_StrokingColor, m_FillingColor, 1, 0);
        }

        private void tsStickyNote_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddStickyNoteAnnotationInteractive(txtText.Text, Colors.Black, "Arial", System.Drawing.FontStyle.Regular, 20, 1, 0);
        }

        private void tsFreeHand_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddFreeHandAnnotInteractive(m_StrokingColor, m_LineWidth, PenLineCap.Flat, PenLineCap.Flat, 1, true);
        }

        private void tsLink_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddLinkAnnotationInteractive("GdPicture Website", "http://www.gdpicture.com", Colors.Blue, Colors.Red, "Arial", System.Drawing.FontStyle.Underline, System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold, 1, 0);
        }

        private void tsPolygon_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddPolygonAnnotInteractive(m_StrokingColor, m_LineWidth, m_FillingColor, 1);
        }

        private void fsFreeHandPolygon_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddFreeHandPolygonAnnotInteractive(m_StrokingColor, m_LineWidth, m_FillingColor, 1);
        }

        private void tsRuler_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.AddRulerAnnotInteractive(m_StrokingColor, m_LineWidth, 1, GdPicture14.Annotations.Annotation.UnitMode.Inch);
        }



        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            m_LineWidth += 0.01f;
            nupLineWidth.Text = m_LineWidth.ToString();
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            m_LineWidth -= 0.01f;
            if (m_LineWidth < 0.0f) m_LineWidth = 0.0f;
            nupLineWidth.Text = m_LineWidth.ToString();
        }

        private void txtText_TextChanged(object sender, TextChangedEventArgs e)
        {
            GdViewer1.CancelLastAnnotInteractiveAdd();
        }

        #region "Annotations Menu Items"
        private void RemoveSelectedCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            int SelectedAnnotIdx = GdViewer1.GetSelectedAnnotationIdx();
            if (SelectedAnnotIdx != -1)
                e.CanExecute = true;
        }

        private void RemoveSelectedCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            int SelectedAnnotIdx = GdViewer1.GetSelectedAnnotationIdx();
            GdViewer1.DeleteAnnotation(SelectedAnnotIdx);
        }

        private void RemoveAllCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.GetAnnotationCount() > 0)
                e.CanExecute = true;
        }

        private void RemoveAllCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            while (GdViewer1.GetAnnotationCount() > 0)
            {
                GdViewer1.DeleteAnnotation(0);
            }
        }

        private void SaveCurrentCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                e.CanExecute = true;
        }

        private void SaveCurrentCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog SaveFileDialog1 = new Microsoft.Win32.SaveFileDialog();

            SaveFileDialog1.Title = "Save Annotations As XMP";
            SaveFileDialog1.CheckFileExists = false;
            SaveFileDialog1.OverwritePrompt = false;
            SaveFileDialog1.Filter = "XMP|*.xmp";
            if (SaveFileDialog1.ShowDialog(this) == true)
            {
                string FilePath = SaveFileDialog1.FileName;
                if (GdViewer1.SaveAnnotationsToXMP(FilePath) == GdPictureStatus.OK)
                {
                    System.Windows.MessageBox.Show("Annotations succefully saved as XMP in " + FilePath);
                }
                else
                {
                    System.Windows.MessageBox.Show("Can't save annotations in " + FilePath);
                }
            }
        }

        private void SaveAllCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                e.CanExecute = true;
        }

        private void SaveAllCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog SaveFileDialog1 = new Microsoft.Win32.SaveFileDialog();

            SaveFileDialog1.Title = "Save Annotations As XMP";
            SaveFileDialog1.CheckFileExists = false;
            SaveFileDialog1.OverwritePrompt = false;
            SaveFileDialog1.Filter = "XMP|*.xmp";
            if (SaveFileDialog1.ShowDialog(this) == true)
            {
                string FilePath = SaveFileDialog1.FileName;
                if (GdViewer1.SaveAnnotationsToXMPEx(FilePath) == GdPictureStatus.OK)
                {
                    System.Windows.MessageBox.Show("Annotations succefully saved as XMP in " + FilePath);
                }
                else
                {
                    System.Windows.MessageBox.Show("Can't save annotations in " + FilePath);
                }
            }
        }

        private void LoadFromXMLCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                e.CanExecute = true;
        }

        private void LoadFromXMLCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog OpenFileDialog1 = new Microsoft.Win32.OpenFileDialog();

            OpenFileDialog1.Title = "Load Annotations from XMP file";
            OpenFileDialog1.CheckFileExists = false;
            OpenFileDialog1.Filter = "XMP|*.xmp";
            if (OpenFileDialog1.ShowDialog(this) == true)
            {
                string FilePath = OpenFileDialog1.FileName;
                if (GdViewer1.LoadAnnotationsFromXMP(FilePath) != GdPictureStatus.OK)
                {
                    System.Windows.MessageBox.Show("Can't load annotations from " + FilePath);
                }
            }
        }

        private void BurnAnnotationsCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1.PageCount > 0)
                if (GdViewer1.GetAnnotationCount() > 0)
                    e.CanExecute = true;
        }

        private void BurnAnnotationsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.BurnAnnotationsToPage(true);
        }
        #endregion


        #region "Editor Mode"

        private void EditorModeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void EditorModeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.SetAnnotationEditorMode(EditorMode.IsChecked);
            toolBar1.IsEnabled = EditorMode.IsChecked;
        }
        #endregion

        private void GdViewer1_PageChanged(object sender, GdPicture14.WPF.GdViewer.PageChangedEventArgs e)
        {
            GdViewer1.RemoveAllRegions();
            ShowPageCount();
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
    }
}
