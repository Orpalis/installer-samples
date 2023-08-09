using GdPicture14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
namespace DocumentViewer
{
    /// <summary>
    /// Interaction logic for wndSettings.xaml
    /// </summary>
    public partial class wndSettings : Window
    {
        private readonly Dictionary<ViewerMouseWheelMode, string> _mouseWheelModes = new Dictionary<ViewerMouseWheelMode, string> {
			{ViewerMouseWheelMode.MouseWheelModeZoom, "Zoom"},
			{ViewerMouseWheelMode.MouseWheelModeVerticalScroll, "Scroll"},
			{ViewerMouseWheelMode.MouseWheelModePageChange, "Page change"}
		};
        private readonly Dictionary<ViewerDocumentAlignment, string> _documentAlignments = new Dictionary<ViewerDocumentAlignment, string> {
			{ViewerDocumentAlignment.DocumentAlignmentBottomCenter, "Bottom center"},
			{ViewerDocumentAlignment.DocumentAlignmentBottomLeft, "Bottom left"},
			{ViewerDocumentAlignment.DocumentAlignmentBottomRight, "Bottom right"},
			{ViewerDocumentAlignment.DocumentAlignmentMiddleCenter, "Middle center"},
			{ViewerDocumentAlignment.DocumentAlignmentMiddleLeft, "Middle left"},
			{ViewerDocumentAlignment.DocumentAlignmentMiddleRight, "Middle right"},
			{ViewerDocumentAlignment.DocumentAlignmentTopCenter, "Top center"},
			{ViewerDocumentAlignment.DocumentAlignmentTopLeft, "Top left"},
			{ViewerDocumentAlignment.DocumentAlignmentTopRight, "Top right"}
		};
        private readonly Dictionary<ViewerDocumentPosition, string> _documentPositions = new Dictionary<ViewerDocumentPosition, string> {
			{ViewerDocumentPosition.DocumentPositionBottomCenter, "Bottom center"},
			{ViewerDocumentPosition.DocumentPositionBottomLeft, "Bottom left"},
			{ViewerDocumentPosition.DocumentPositionBottomRight, "Bottom right"},
			{ViewerDocumentPosition.DocumentPositionMiddleCenter, "Middle center"},
			{ViewerDocumentPosition.DocumentPositionMiddleLeft, "Middle left"},
			{ViewerDocumentPosition.DocumentPositionMiddleRight, "Middle right"},
			{ViewerDocumentPosition.DocumentPositionTopCenter, "Top center"},
			{ViewerDocumentPosition.DocumentPositionTopLeft, "Top left"},
			{ViewerDocumentPosition.DocumentPositionTopRight, "Top right"}
		};
        private readonly Dictionary<BitmapScalingMode, string> _displayQualities = new Dictionary<BitmapScalingMode, string> {
			{BitmapScalingMode.NearestNeighbor, "Nearest Neighbor"},
			{BitmapScalingMode.LowQuality, "Low Quality"},
			{BitmapScalingMode.Fant, "Fant"}
		};

        private int _zoomStep;
        private readonly GdPicture14.WPF.GdViewer _gdViewer;
        private readonly GdPicture14.WPF.ThumbnailEx _thumbnailEx;

        public wndSettings(GdPicture14.WPF.GdViewer gdViewer, GdPicture14.WPF.ThumbnailEx thumbnailEx)
        {
            InitializeComponent();
            _zoomStep = 1;
            _gdViewer = gdViewer;
            _thumbnailEx = thumbnailEx;
        }

        #region "numeric up and down"
        private void btnZoomStepUp_Click(object sender, RoutedEventArgs e)
        {
            if (_zoomStep < 1000) _zoomStep++;
            txtZoomStep.Text = _zoomStep.ToString();
        }

        private void btnZoomStepDown_Click(object sender, RoutedEventArgs e)
        {
            if (_zoomStep > 1) _zoomStep--;
            txtZoomStep.Text = _zoomStep.ToString();
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }

        private void txtZoomStep_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool handled = !IsTextAllowed(e.Text);
            e.Handled = handled;

        }

        private void txtZoomStep_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtZoomStep.Text != "" && txtZoomStep.Text != "-" && txtZoomStep.Text != " ")
            {
                if (int.Parse(txtZoomStep.Text) > 1000)
                    txtZoomStep.Text = "1000";
                else if (int.Parse(txtZoomStep.Text) < 1)
                    txtZoomStep.Text = "1";
                _zoomStep = int.Parse(txtZoomStep.Text);
            }
        }
        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in _mouseWheelModes)
            {
                cbMouseWheelMode.Items.Add(item.Value);
            }
            foreach (var item in _documentAlignments)
            {
                cbDocumentAlignment.Items.Add(item.Value);
            }
            foreach (var item in _documentPositions)
            {
                cbDocumentPosition.Items.Add(item.Value);
            }
            foreach (var item in _displayQualities)
            {
                cbBitmapScalingMode.Items.Add(item.Value);
            }


            cbMouseWheelMode.SelectedIndex = Convert.ToInt32(_gdViewer.MouseWheelMode);
            cbDocumentAlignment.SelectedItem = _documentAlignments[_gdViewer.DocumentAlignment];
            cbDocumentPosition.SelectedItem = _documentPositions[_gdViewer.DocumentPosition];
            cbBitmapScalingMode.SelectedIndex = Convert.ToInt32(_gdViewer.BitmapScalingMode);
            txtZoomStep.Text = (_gdViewer.ZoomStep).ToString();
            chkContinuousViewMode.IsChecked = _gdViewer.ContinuousViewMode;
            chkEnableMenu.IsChecked = _gdViewer.EnableMenu;
            btnBackgroundColor.Background = _gdViewer.Background;

            chkEnableICM.IsChecked = _gdViewer.EnableICM;

            chkPDFDisplayFormFields.IsChecked = _gdViewer.PdfDisplayFormField;
            chkPDFEnableFileLinks.IsChecked = _gdViewer.PdfEnableFileLinks;
            chkPDFEnableLinks.IsChecked = _gdViewer.PdfEnableLinks;
            chkPDFIncreaseTextContrast.IsChecked = _gdViewer.PdfIncreaseTextContrast;
            chkPDFVerifyDigitalCertificates.IsChecked = _gdViewer.PdfVerifyDigitalCertificates;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _gdViewer.MouseWheelMode = _mouseWheelModes.FirstOrDefault(x => x.Value.Contains(cbMouseWheelMode.SelectedItem.ToString())).Key;
            _gdViewer.DocumentAlignment = _documentAlignments.FirstOrDefault(x => x.Value.Contains(cbDocumentAlignment.SelectedItem.ToString())).Key;
            _gdViewer.DocumentPosition = _documentPositions.FirstOrDefault(x => x.Value.Contains(cbDocumentPosition.SelectedItem.ToString())).Key;
            _gdViewer.BitmapScalingMode = _displayQualities.FirstOrDefault(x => x.Value.Contains(cbBitmapScalingMode.SelectedItem.ToString())).Key;
            _gdViewer.ZoomStep = int.Parse(txtZoomStep.Text);
            _gdViewer.ContinuousViewMode = (chkContinuousViewMode.IsChecked == true);
            _gdViewer.EnableMenu = (chkEnableMenu.IsChecked == true);
            _gdViewer.Background = btnBackgroundColor.Background;

            _gdViewer.EnableICM = (chkEnableICM.IsChecked == true);

            _gdViewer.PdfDisplayFormField = (chkPDFDisplayFormFields.IsChecked == true);
            _gdViewer.PdfEnableFileLinks = (chkPDFEnableFileLinks.IsChecked == true);
            _gdViewer.PdfEnableLinks = (chkPDFEnableLinks.IsChecked == true);
            _gdViewer.PdfIncreaseTextContrast = (chkPDFIncreaseTextContrast.IsChecked == true);
            _gdViewer.PdfVerifyDigitalCertificates = (chkPDFVerifyDigitalCertificates.IsChecked == true);

            _thumbnailEx.PdfIncreaseTextContrast = _gdViewer.PdfIncreaseTextContrast;

            Close();
        }

        private void btnBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            ColorPicker oColorPicker = new ColorPicker();
            oColorPicker.ShowDialog();
            btnBackgroundColor.Background = new SolidColorBrush(oColorPicker.BackColor);
        }


    }
}
