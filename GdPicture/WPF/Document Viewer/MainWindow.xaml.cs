using GdPicture14;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.ComponentModel;

namespace DocumentViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {

        private enum ZoomMode
        {
            Zoom50,
            Zoom100,
            Zoom150,
            Zoom200,
            ZoomSelectedArea,
            ZoomFitToViewer,
            ZoomFitWidth,
            ZoomFitHeight
        }

        private int _currentSearchOccurence;

        public MainWindow()
        {
            InitializeComponent();

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GdPicture14.LicenseManager oLicenceManager = new GdPicture14.LicenseManager();
            oLicenceManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
            this.DataContext = this;
            BookmarksTree1.GdViewer = GdViewer1;
            SelectSnapIn(0);
            ResetSearch();
            UpdateMainUi();
        }

        #region "Dependancy properties for multi-Window level binding"
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewerDocumentPosition MouseWheelMode
        {
            get { return (ViewerDocumentPosition)GetValue(DocumentPositionProperty); }
            set { SetValue(DocumentPositionProperty, value);
            OnPropertyChanged("MouseWheelMode");
                }
        }
        public static readonly DependencyProperty MouseWheelModeProperty = DependencyProperty.Register("MouseWheelMode", typeof(ViewerMouseWheelMode), typeof(MainWindow), new UIPropertyMetadata(ViewerMouseWheelMode.MouseWheelModeZoom));


        public ViewerDocumentAlignment DocumentAlignment
        {
            get { return (ViewerDocumentAlignment)GetValue(DocumentAlignmentProperty); }
            set
            {
                SetValue(DocumentAlignmentProperty, value);
                OnPropertyChanged("DocumentAlignment");
            }
        }
        public static readonly DependencyProperty DocumentAlignmentProperty = DependencyProperty.Register("DocumentAlignment", typeof(ViewerDocumentAlignment), typeof(MainWindow), new UIPropertyMetadata(ViewerDocumentAlignment.DocumentAlignmentMiddleCenter));


        public BitmapScalingMode ScalingMode
        {
            get { return (BitmapScalingMode)GetValue(ScalingModeProperty); }
            set
            {
                SetValue(ScalingModeProperty, value);
                OnPropertyChanged("ScalingMode");
            }
        }
        public static readonly DependencyProperty ScalingModeProperty = DependencyProperty.Register("ScalingMode", typeof(BitmapScalingMode), typeof(MainWindow), new UIPropertyMetadata(BitmapScalingMode.Fant));

        public ViewerDocumentPosition DocumentPosition
        {
            get { return (ViewerDocumentPosition)GetValue(DocumentPositionProperty); }
            set
            {
                SetValue(DocumentPositionProperty, value);
                OnPropertyChanged("DocumentPosition");
            }
        }
        public static readonly DependencyProperty DocumentPositionProperty = DependencyProperty.Register("DocumentPosition", typeof(ViewerDocumentPosition), typeof(MainWindow), new UIPropertyMetadata(ViewerDocumentPosition.DocumentPositionMiddleCenter));

        public int ZoomStep
        {
            get { return (int)GetValue(ZoomStepProperty); }
            set
            {
                SetValue(ZoomStepProperty, value);
                OnPropertyChanged("ZoomStep");
            }
        }
        public static readonly DependencyProperty ZoomStepProperty = DependencyProperty.Register("ZoomStep", typeof(int), typeof(MainWindow), new UIPropertyMetadata(25));

        public bool ContinuousViewMode
        {
            get { return (bool)GetValue(ContinuousViewModeProperty); }
            set
            {
                SetValue(ContinuousViewModeProperty, value);
                OnPropertyChanged("ContinuousViewMode");
            }
        }
        public static readonly DependencyProperty ContinuousViewModeProperty = DependencyProperty.Register("ContinuousViewMode", typeof(bool), typeof(MainWindow), new UIPropertyMetadata(true));

        public bool EnableMenu
        {
            get { return (bool)GetValue(EnableMenuProperty); }
            set
            {
                SetValue(EnableMenuProperty, value);
                OnPropertyChanged("EnableMenu");
            }
        }
        public static readonly DependencyProperty EnableMenuProperty = DependencyProperty.Register("EnableMenu", typeof(bool), typeof(MainWindow), new UIPropertyMetadata(true));


        public bool DisplayFormfields
        {
            get { return (bool)GetValue(DisplayFormfieldsProperty); }
            set
            {
                SetValue(DisplayFormfieldsProperty, value);
                OnPropertyChanged("DisplayFormfields");
            }
        }
        public static readonly DependencyProperty DisplayFormfieldsProperty = DependencyProperty.Register("DisplayFormfields", typeof(bool), typeof(MainWindow), new UIPropertyMetadata(true));

        public bool EnableFileLinks
        {
            get { return (bool)GetValue(EnableFileLinksProperty); }
            set
            {
                SetValue(EnableFileLinksProperty, value);
                OnPropertyChanged("EnableFileLinks");
            }
        }
        public static readonly DependencyProperty EnableFileLinksProperty = DependencyProperty.Register("EnableFileLinks", typeof(bool), typeof(MainWindow), new UIPropertyMetadata(true));


        public bool EnableLinks
        {
            get { return (bool)GetValue(EnableLinksProperty); }
            set
            {
                SetValue(EnableLinksProperty, value);
                OnPropertyChanged("EnableLinks");
            }
        }
        public static readonly DependencyProperty EnableLinksProperty = DependencyProperty.Register("EnableLinks", typeof(bool), typeof(MainWindow), new UIPropertyMetadata(true));


            

        public bool VerifyDigitalCertificates
        {
            get { return (bool)GetValue(VerifyDigitalCertificatesProperty); }
            set
            {
                SetValue(VerifyDigitalCertificatesProperty, value);
                OnPropertyChanged("VerifyDigitalCertificates");
            }
        }
        public static readonly DependencyProperty VerifyDigitalCertificatesProperty = DependencyProperty.Register("VerifyDigitalCertificates", typeof(bool), typeof(MainWindow), new UIPropertyMetadata(true));

        public bool IncreaseTextContrast
        {
            get { return (bool)GetValue(IncreaseTextContrastProperty); }
            set
            {
                SetValue(IncreaseTextContrastProperty, value);
                OnPropertyChanged("IncreaseTextContrast");
            }
        }
        public static readonly DependencyProperty IncreaseTextContrastProperty = DependencyProperty.Register("IncreaseTextContrast", typeof(bool), typeof(MainWindow), new UIPropertyMetadata(false));

        public bool EnableICM
        {
            get { return (bool)GetValue(EnableICMProperty); }
            set
            {
                SetValue(EnableICMProperty, value);
                OnPropertyChanged("EnableICM");
            }
        }
        public static readonly DependencyProperty EnableICMProperty = DependencyProperty.Register("EnableICM", typeof(bool), typeof(MainWindow), new UIPropertyMetadata(false));

        

        #endregion

        #region "File Menu"
        private void OpenFileCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenFileCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseDocument();

            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter;


            wndOpen open = new wndOpen(GdViewer1);
            open.Owner = Application.Current.MainWindow;
            open.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            open.ShowDialog();

            GdViewer1.Focus();
            ThumbnailEx1.LoadFromGdViewer(GdViewer1);
            UpdateMainUi();
        }

        private void SettingsCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SettingsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            wndSettings settings = new wndSettings(GdViewer1, ThumbnailEx1)
            {
                DataContext = this
            };
            settings.Owner = Application.Current.MainWindow;
            settings.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            settings.ShowDialog();
        }

        private void PrintCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1 != null)
                if (GdViewer1.PageCount > 0)
                    e.CanExecute = true;
        }

        private void PrintCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            wndPrint print = new wndPrint(GdViewer1);
            print.Owner = Application.Current.MainWindow;
            print.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            print.ShowDialog();
            if (print.DialogResult != true)
            {
                return;
            }
            wndPrint.PrintSettings printSettings = print.printConfiguration;
            if (!GdViewer1.PrintSetActivePrinter(printSettings.Printer))
            {
                return;
            }
            GdViewer1.PrintSetDocumentName("GdPicture Print Job " + DateTime.Now.ToString("yyyy-MM-dd HH\\mm"));
            GdViewer1.PrintSetAlignment(printSettings.PrintAlignment);
            switch (printSettings.Orientation)
            {
                case wndPrint.PrintOrientation.AutoDetection:
                    GdViewer1.PrintSetAutoRotation(true);
                    break;
                case wndPrint.PrintOrientation.Portrait:
                    GdViewer1.PrintSetAutoRotation(false);
                    GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationPortrait);
                    break;
                case wndPrint.PrintOrientation.Paysage:
                    GdViewer1.PrintSetAutoRotation(false);
                    GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationLandscape);
                    break;
            }
            GdViewer1.PrintSetCopies(printSettings.Copies);
            if (printSettings.Copies > 1)
            {
                GdViewer1.PrintSetCollate(printSettings.Collate);
            }
            switch (printSettings.PagesToPrint)
            {
                case wndPrint.PagesToPrint.All:
                    GdViewer1.PrintSetFromToPage(1, GdViewer1.PageCount);
                    GdViewer1.Print(printSettings.PrintSize);
                    break;
                case wndPrint.PagesToPrint.Current:
                    GdViewer1.PrintSetFromToPage(GdViewer1.CurrentPage, GdViewer1.CurrentPage);
                    GdViewer1.Print(printSettings.PrintSize);
                    break;
                case wndPrint.PagesToPrint.Selection:
                    string range = GetSelectedItemAsRange();
                    if (!string.IsNullOrWhiteSpace(range))
                    {
                        GdViewer1.PrintSetPageSelection(range);
                        GdViewer1.Print(printSettings.PrintSize);
                    }
                    break;
                case wndPrint.PagesToPrint.Range:
                    if (!string.IsNullOrEmpty(printSettings.PageRange))
                    {
                        if (printSettings.PageRange.Contains("-"))
                        {
                            int pageStart = 0;
                            if (int.TryParse(Convert.ToString(printSettings.PageRange.Split('-')[0]), out pageStart))
                            {
                                int pageEnd = 0;
                                if (int.TryParse(Convert.ToString(printSettings.PageRange.Split('-')[1]), out pageEnd))
                                {
                                    if (pageEnd < pageStart)
                                    {
                                        GdViewer1.PrintSetFromToPage(pageEnd, pageStart);
                                        GdViewer1.Print(printSettings.PrintSize);
                                    }
                                    else
                                    {
                                        GdViewer1.PrintSetFromToPage(pageStart, pageEnd);
                                        GdViewer1.Print(printSettings.PrintSize);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Page range is invalid.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Page range is invalid.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            int page = 0;
                            if (int.TryParse(printSettings.PageRange, out page))
                            {
                                GdViewer1.PrintSetFromToPage(page, page);
                                GdViewer1.Print(printSettings.PrintSize);
                            }
                            else
                            {
                                MessageBox.Show("Page range is invalid.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Page range is invalid.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
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

        //MouseMode
        #region "Mouse Mode"

        private void UncheckMouseMode()
        {
            miDefault.IsChecked = false;
            miAreaSelection.IsChecked = false;
            miPan.IsChecked = false;
            miAreaZooming.IsChecked = false;
            miMagnifier.IsChecked = false;
        }

        private void MouseModeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void MouseModePanCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModePan;
            UncheckMouseMode();
            miPan.IsChecked = true;
        }

        private void MouseModeAreaZoomingCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming;
            UncheckMouseMode();
            miAreaZooming.IsChecked = true;
        }

        private void MouseModeAreaSelectionCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection;
            UncheckMouseMode();
            miAreaSelection.IsChecked = true;
        }

        private void MouseModeMagnifierCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeMagnifier;
            UncheckMouseMode();
            miMagnifier.IsChecked = true;
        }

        private void MouseModeDefaultCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeDefault;
            UncheckMouseMode();
            miDefault.IsChecked = true;
        }
        #endregion//Mouse Mode Commands

        #region "Page Navigation"

        private void FirstPageCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1 != null)
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
            if (GdViewer1 != null)
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
            if (GdViewer1 != null)
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
            if (GdViewer1 != null)
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
        #endregion//Page Navigation Commands

        #region "Zoom"
        private void ZoomCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1 != null)
                if (GdViewer1.PageCount > 0)
                    e.CanExecute = true;
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

        private void ZoomWidthFitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
        }
        #endregion//Zooming Commands

        #region "Rotation"
        private void RotateCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (GdViewer1 != null)
                if (GdViewer1.PageCount > 0)
                    e.CanExecute = true;
        }

        private void RotateRightCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotatePage(GdPictureRotateFlipType.GdPictureRotate90FlipNone);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void RotateLeftCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotatePage(GdPictureRotateFlipType.GdPictureRotate270FlipNone);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void FlipXCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotatePage(GdPictureRotateFlipType.GdPictureRotateNoneFlipX);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }

        private void FlipYCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdViewer1.RotatePage(GdPictureRotateFlipType.GdPictureRotateNoneFlipY);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + GdViewer1.GetStat());
            }
        }
        #endregion//Rotation

        #region "Gamma"
        private void AboutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AboutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            wndAbout about = new wndAbout();
            about.ShowDialog();
        }
        #endregion
        #endregion

        #region "Private Methods"
        private void SelectSnapIn(int num)
        {
            tcTabs.SelectedIndex = num;
            btnThumbnails.SetResourceReference(
    Control.BackgroundProperty,
    SystemColors.AppWorkspaceBrushKey);
            btnBookmarks.SetResourceReference(
    Control.BackgroundProperty,
    SystemColors.AppWorkspaceBrushKey);
            btnSearchPanel.SetResourceReference(
    Control.BackgroundProperty,
    SystemColors.AppWorkspaceBrushKey);
            switch (num)
            {
                case 0:
                    btnThumbnails.SetResourceReference(
     Control.BackgroundProperty,
     SystemColors.ControlBrushKey);
                    break;
                case 1:
                    btnBookmarks.SetResourceReference(
     Control.BackgroundProperty,
     SystemColors.ControlBrushKey);
                    break;
                case 2:
                    btnSearchPanel.SetResourceReference(
     Control.BackgroundProperty,
     SystemColors.ControlBrushKey);
                    break;
            }
        }
        private void UpdateMainUi()
        {
            this.Title = "GdPicture.NET " + string.Format(CultureInfo.InvariantCulture, "{0:##.#\\.##}", GdViewer1.GetVersion()) + " - Document Viewer Demo";
            if (GdViewer1.PageCount == 0)
            {
                tbCurrentPage.Text = "0";
                lblPageCount.Content = "/ 0";
                Size textSize = MeasureString("/ " + GdViewer1.PageCount.ToString());
                lblPageCount.Content = "/ " + GdViewer1.PageCount;
                GridLength gl = new GridLength(textSize.Width, GridUnitType.Pixel);
                pageCountColumn.Width = gl;
                cbZoom.SelectedIndex = -1;
                tbSearch.Text = "";
                gridSearch.IsEnabled = false;
            }
            else
            {
                UpdateaNavigationToolbar();
                gridSearch.IsEnabled = GdViewer1.GetDocumentType() != DocumentType.DocumentTypeUnknown;
            }
            ResetSearch();
        }

        private Size MeasureString(string candidate)
        {
            var formattedText = new FormattedText(
                candidate,
                CultureInfo.CurrentUICulture,
                FlowDirection.LeftToRight,
                new Typeface(this.lblPageCount.FontFamily, this.lblPageCount.FontStyle, this.lblPageCount.FontWeight, this.lblPageCount.FontStretch),
                this.lblPageCount.FontSize,
                Brushes.Black);

            return new Size(formattedText.Width + 15, formattedText.Height);
        }

        private void UpdateaNavigationToolbar()
        {
            int currentPage = GdViewer1.CurrentPage;
            tbCurrentPage.Text = currentPage.ToString();
            Size textSize = MeasureString("/ " + GdViewer1.PageCount.ToString());
            lblPageCount.Content = "/ " + GdViewer1.PageCount;
            GridLength gl = new GridLength(textSize.Width, GridUnitType.Pixel);
            pageCountColumn.Width = gl;

            cbZoom.Text = string.Format(CultureInfo.InvariantCulture, "{0:#0.##%}", GdViewer1.Zoom);


            this.lblStatus.Content = "Type: " + GetDocumentTypeLabel() + "  -  " +
                                        "Page Size (inches) : " + Math.Round(GdViewer1.PageInchHeight, 2).ToString() + " * " + Math.Round(GdViewer1.PageInchWidth, 2).ToString() + "   -   " +
                                        "Page Size (pixels) : " + GdViewer1.PagePixelHeight.ToString() + " * " + GdViewer1.PagePixelWidth.ToString() + "   -   " +
                                        "Horizontal resolution : " + Math.Round(GdViewer1.PageHorizontalResolution, 2).ToString() + " DPI   -   " +
                                        "Vertical resolution : " + Math.Round(GdViewer1.PageVerticalResolution, 2).ToString() + " DPI";
        }

        private string GetDocumentTypeLabel()
        {
            return GdViewer1.GetDocumentType().ToString().Replace("DocumentType", "");
        }

        private void CloseDocument()
        {
            GdViewer1.CloseDocument();
            ThumbnailEx1.ClearAllItems();
            UpdateMainUi();
        }

        private void ChangeZoomValue()
        {
            if (cbZoom.SelectedIndex != -1)
            {
                if (((ZoomMode)cbZoom.SelectedIndex) == ZoomMode.Zoom50)
                {
                    GdViewer1.Zoom = 50.0F / 100;
                }
                else if (((ZoomMode)cbZoom.SelectedIndex) == ZoomMode.Zoom100)
                {
                    GdViewer1.Zoom = 100.0F / 100;
                }
                else if (((ZoomMode)cbZoom.SelectedIndex) == ZoomMode.Zoom150)
                {
                    GdViewer1.Zoom = 150.0F / 100;
                }
                else if (((ZoomMode)cbZoom.SelectedIndex) == ZoomMode.Zoom200)
                {
                    GdViewer1.Zoom = 250.0F / 100;
                }
                else if (((ZoomMode)cbZoom.SelectedIndex) == ZoomMode.ZoomSelectedArea)
                {
                    if (GdViewer1.IsRect())
                    {
                        GdViewer1.ZoomRect();
                    }
                }
                else if (((ZoomMode)cbZoom.SelectedIndex) == ZoomMode.ZoomFitToViewer)
                {
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
                }
                else if (((ZoomMode)cbZoom.SelectedIndex) == ZoomMode.ZoomFitWidth)
                {
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
                }
                else if (((ZoomMode)cbZoom.SelectedIndex) == ZoomMode.ZoomFitHeight)
                {
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeHeightViewer;
                }
            }
            else
            {
                int zoom = 0;
                if (Int32.TryParse(Regex.Replace(cbZoom.Text, "[^0-9,.]", ""), out zoom))
                {
                    GdViewer1.Zoom = Convert.ToDouble(zoom) / 100;
                }
            }
            UpdateaNavigationToolbar();
        }

        private string GetSelectedItemAsRange()
        {
            int count = 0;
            for (int i = 0; i <= ThumbnailEx1.ItemCount - 1; i++)
            {
                if (ThumbnailEx1.GetItemCheckState(i))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                if (MessageBox.Show("No page has been selected, do you want to save all pages?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    for (int i = 0; i <= ThumbnailEx1.ItemCount - 1; i++)
                    {
                        ThumbnailEx1.SetItemCheckState(i, true);
                    }
                    count = ThumbnailEx1.ItemCount;
                }
            }
            if (count > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i <= ThumbnailEx1.ItemCount; i++)
                {
                    if (ThumbnailEx1.GetItemCheckState(i))
                    {
                        if (sb.Length != 0)
                        {
                            sb.Append(";");
                        }
                        sb.Append(i + 1);
                    }
                }

                return sb.ToString();
            }
            return "";
        }
        #endregion
        //Creation of a Dropdown Button in WPF: Utilizing the ContextMenu of the Button with the Image
        private void btnMouseMode_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }


        #region "Thumbnail Size"

        private void UncheckThumbnailSize()
        {
            miSmallThumbnails.IsChecked = false;
            miMediumThumbnails.IsChecked = false;
            miLargeThumbnails.IsChecked = false;
        }

        private void ThumbnailSizeCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SmallThumbCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new System.Windows.Size(64, 64);
            UncheckThumbnailSize();
            miSmallThumbnails.IsChecked = true;

        }

        private void MediumThumbCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new System.Windows.Size(128, 128);
            UncheckThumbnailSize();
            miMediumThumbnails.IsChecked = true;
        }

        private void LargeThumbCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new System.Windows.Size(256, 256);
            UncheckThumbnailSize();
            miLargeThumbnails.IsChecked = true;

        }
        #endregion

        #region "Snapin Panels"

        private void Snapin_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ThumbnailsPanelCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SelectSnapIn(0);
        }

        private void BookmarksPanelCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SelectSnapIn(1);
        }

        private void SearchPanelCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SelectSnapIn(2);
        }
        #endregion
        #region "Search"

        private void ResetSearch()
        {
            lstSearchResults.Items.Clear();
            GdViewer1.RemoveAllRegions();
            _currentSearchOccurence = 0;
        }

        private void SearchCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !string.IsNullOrWhiteSpace(tbSearch.Text); ;
        }

        private delegate void UpdateProgressBarDelegate(
        System.Windows.DependencyProperty dp, Object value);

        private void SearchNextCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Search(true);
        }

        private void SearchPreviousCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Search(false);
        }

        private void SearchCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                return;
            }

            ResetSearch();
            int page = 0;
            bool found = false;
            if (rbAllPages.IsChecked == true)
            {
                page = 1;
            }
            else
            {
                page = GdViewer1.CurrentPage;
            }
            bool finish = false;
            int countResults = 0;
            Cursor = Cursors.Wait;
            searchProgressBar.Value = 1;
            searchProgressBar.Maximum = GdViewer1.PageCount;
            stSearchProgress.Visibility = System.Windows.Visibility.Visible;

            UpdateProgressBarDelegate updatePbDelegate =
       new UpdateProgressBarDelegate(searchProgressBar.SetValue);
            double value = searchProgressBar.Value;
            while (!finish)
            {
                lblSearchResults.Text = "Find results for page " + page + " of " + GdViewer1.PageCount;
                value++;
                Dispatcher.Invoke(updatePbDelegate,
           System.Windows.Threading.DispatcherPriority.Background,
           new object[] { ProgressBar.ValueProperty, value });
                ;


                int count = GetSearchResultCount(page, tbSearch.Text);
                if (count > 0)
                {
                    found = true;
                    String content = "Page " + page + ", ";
                    content += count + " occurence(s) found";
                    ListViewItem item = new ListViewItem();
                    item.Content = content;
                    item.Name = "Page" + page;
                    item.Tag = page;
                    lstSearchResults.Items.Add(item);
                }
                countResults += count;
                page++;
                finish = rbCurrentPage.IsChecked == true || page > GdViewer1.PageCount;
            }

            Cursor = Cursors.Arrow;

            lblSearchResults.Text = "";
            stSearchProgress.Visibility = System.Windows.Visibility.Hidden;

            if (!found)
            {
                MessageBox.Show("No match found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private bool Search(bool ascending)
        {
            bool go = true;
            int page = GdViewer1.CurrentPage;
            bool found = false;
            int newOccurence = 0;
            double occurenceLeft = 0;
            double occurenceTop = 0;
            double occurenceWidth = 0;
            double occurenceHeight = 0;
            if (ascending)
            {
                newOccurence = _currentSearchOccurence + 1;
            }
            else
            {
                newOccurence = _currentSearchOccurence - 1;
            }
            while (go)
            {
                if (GdViewer1.SearchText(page, tbSearch.Text, newOccurence, chkCaseSensitive.IsChecked == true, chkWholeWord.IsChecked == true, ref occurenceLeft, ref occurenceTop, ref occurenceWidth, ref occurenceHeight))
                {
                    if (page != GdViewer1.CurrentPage)
                    {
                        GdViewer1.DisplayPage(page);
                    }
                    GdViewer1.RemoveAllRegions();
                    AddSearchRegion(newOccurence, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight, true);
                    _currentSearchOccurence = newOccurence;
                    found = true;
                    go = false;
                }
                else
                {
                    if (rbAllPages.IsChecked == true)
                    {
                        if (ascending)
                        {
                            page++;
                            newOccurence = 1;
                        }
                        else
                        {
                            page--;
                            newOccurence = GetSearchResultCount(page, tbSearch.Text);
                        }
                        if (page == 0 | page > GdViewer1.PageCount)
                        {
                            go = false;
                        }
                    }
                    else
                    {
                        go = false;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show(this, "No match found !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return found;
        }

        private void AddSearchRegion(int occurence, double leftCoordinate, double topCoordinate, double regionWidth, double regionheight, bool ensureVisibility)
        {
            int searchRegion = GdViewer1.AddRegion("SearchResult" + Convert.ToString(occurence), leftCoordinate, topCoordinate, regionWidth, regionheight, Colors.Yellow, GdPicture14.WPF.GdViewer.RegionFillMode.Multiply);
            GdViewer1.SetRegionEditable(searchRegion, false);
            if (ensureVisibility)
            {
                GdViewer1.EnsureRegionVisibility(searchRegion);
            }
        }

        private void lstSearchResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstSearchResults.SelectedItems.Count != 0)
            {
                GdViewer1.RemoveAllRegions();
                ListViewItem item = (ListViewItem)lstSearchResults.SelectedItems[0];
                int page = Convert.ToInt32(item.Tag);
                if (GdViewer1.CurrentPage != page)
                {
                    GdViewer1.DisplayPage(page);
                }
                int occurence = 1;
                double occurenceLeft = 0;
                double occurenceTop = 0;
                double occurenceWidth = 0;
                double occurenceHeight = 0;
                while (GdViewer1.SearchText(page, tbSearch.Text, occurence, chkCaseSensitive.IsChecked == true, chkWholeWord.IsChecked == true, ref occurenceLeft, ref occurenceTop, ref occurenceWidth, ref occurenceHeight))
                {
                    AddSearchRegion(occurence, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight, occurence == 1);
                    occurence++;
                }
            }
        }

        private int GetSearchResultCount(int page, string searchedTerm)
        {
            return GdViewer1.GetTextOccurrenceCount(page, searchedTerm, chkCaseSensitive.IsChecked == true, chkWholeWord.IsChecked == true);
        }
        #endregion//search

        #region "GdViewer Events"
        private void GdViewer1_PageChanged(object sender, GdPicture14.WPF.GdViewer.PageChangedEventArgs e)
        {
            UpdateaNavigationToolbar();
        }

        private void GdViewer1_TransferEnded(object sender, GdPicture14.WPF.GdViewer.TransferEndedEventArgs e)
        {
            GdViewer1.Focus();
            ThumbnailEx1.LoadFromGdViewer(GdViewer1);
            UpdateMainUi();
        }

        private void GdViewer1_ZoomChanged(object sender, GdPicture14.WPF.GdViewer.ZoomChangedEventArgs e)
        {
            UpdateaNavigationToolbar();
        }
        #endregion


        private void tbCurrentPage_TextChanged(object sender, TextChangedEventArgs e)
        {
            int page = 0;
            if (int.TryParse(tbCurrentPage.Text, out page))
            {
                if (page > 0 & page <= GdViewer1.PageCount)
                {
                    GdViewer1.DisplayPage(page);
                    UpdateaNavigationToolbar();
                }
            }
        }

        private void cbZoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeZoomValue();
        }

    }
}
