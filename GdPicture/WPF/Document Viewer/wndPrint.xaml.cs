using GdPicture14;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DocumentViewer
{
    /// <summary>
    /// Interaction logic for wndPrint.xaml
    /// </summary>
    public partial class wndPrint : Window
    {

        public enum PrintOrientation
        {
            AutoDetection,
            Portrait,
            Paysage
        }

        public enum PagesToPrint
        {
            All,
            Selection,
            Current,
            Range
        }

        public struct PrintSettings
        {
            public string Printer;
            public short Copies;
            public bool Collate;
            public PrintSizeOption PrintSize;
            public PrintAlignment PrintAlignment;
            public PrintOrientation Orientation;
            public PagesToPrint PagesToPrint;
            public string PageRange;
        }

        public PrintSettings printConfiguration
        {
            get
            {
                return _printSettings;
            }
        }


        private bool m_isSelectionPartial;
        private bool m_isEmptySelection;

        private PrintSettings _printSettings;
        private int _numCopies;
        private readonly GdPicture14.WPF.GdViewer _owner;

        public wndPrint(GdPicture14.WPF.GdViewer owner)
        {
            InitializeComponent();
            _numCopies = 1;
            _owner = owner;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbPrinterList.Items.Clear();
            for (int i = 1; i <= _owner.PrintGetPrintersCount(); i++)
            {
                string printerName = _owner.PrintGetPrinterName(i);
                cmbPrinterList.Items.Add(printerName);
                if (printerName == _owner.PrintGetActivePrinter())
                {
                    cmbPrinterList.SelectedIndex = cmbPrinterList.Items.IndexOf(printerName);
                }
            }

            cmbPrintSize.Items.Add("Actual size"); //0 = PrintSizeOptionActual
            cmbPrintSize.Items.Add("Fit to page"); //1 = PrintSizeOptionFit, default
            cmbPrintSize.Items.Add("Shrink oversized pages"); //2 = PrintSizeOptionShrinkOversized
            cmbPrintSize.SelectedIndex = 2;

            cmbPrintAlignment.Items.Add("Middle left"); //0 = PrintAlignmentMiddleLeft
            cmbPrintAlignment.Items.Add("Middle right"); //1 = PrintAlignmentMiddleRight
            cmbPrintAlignment.Items.Add("Middle center"); //2 = PrintAlignmentMiddleCenter
            cmbPrintAlignment.Items.Add("Default"); //3 = PrintAlignmentDefault
            cmbPrintAlignment.Items.Add("Top left"); //4 = PrintAlignmentTopLeft
            cmbPrintAlignment.Items.Add("Top right"); //5 = PrintAlignmentTopRight
            cmbPrintAlignment.Items.Add("Top center"); //6 = PrintAlignmentTopCenter
            cmbPrintAlignment.Items.Add("Bottom left"); //7 = PrintAlignmentBottomLeft
            cmbPrintAlignment.Items.Add("Bottom right"); //8 = PrintAlignmentBottomRight
            cmbPrintAlignment.Items.Add("Bottom center"); //9 = PrintAlignmentBottomCenter
            cmbPrintAlignment.SelectedIndex = 2;

            if (m_isEmptySelection)
            {
                rbPageRangeSelection.IsEnabled = false;
            }
            else
            {
                if (m_isSelectionPartial)
                {
                    rbPageRangeSelection.IsChecked = true;
                }
            }
            txtPageRangeStart.Text = "1";
            txtPageRangeEnd.Text = _owner.PageCount.ToString();

        }

        private void cmbPrinterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _owner.PrintSetActivePrinter(cmbPrinterList.Text);
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            _printSettings.Printer = cmbPrinterList.Text;
            _printSettings.Copies = (short)_numCopies;
            _printSettings.Collate = (chkCollate.IsChecked == true);
            _printSettings.PrintSize = (PrintSizeOption)cmbPrintSize.SelectedIndex;
            _printSettings.PrintAlignment = (PrintAlignment)cmbPrintAlignment.SelectedIndex;

            if (rbOrientationAutomatic.IsChecked == true)
            {
                _printSettings.Orientation = PrintOrientation.AutoDetection;
            }
            else if (rbOrientationPortrait.IsChecked == true)
            {
                _printSettings.Orientation = PrintOrientation.Portrait;
            }
            else if (rbOrientationLandscape.IsChecked == true)
            {
                _printSettings.Orientation = PrintOrientation.Paysage;
            }

            if (rbPageRangeAll.IsChecked == true)
            {
                _printSettings.PagesToPrint = PagesToPrint.All;
            }
            else if (rbPageRangeSelection.IsChecked == true)
            {
                _printSettings.PagesToPrint = PagesToPrint.Selection;
            }
            else if (rbPageRangeCurrent.IsChecked == true)
            {
                _printSettings.PagesToPrint = PagesToPrint.Current;
            }
            else if (rbPageRangePages.IsChecked == true)
            {
                _printSettings.PagesToPrint = PagesToPrint.Range;
                _printSettings.PageRange = txtPageRangeStart.Text + "-" + txtPageRangeEnd.Text;
            }
            this.DialogResult = true;
            this.Close();
        }

        private void btnPrinterProperties_Click(object sender, RoutedEventArgs e)
        {
            GdPictureStatus status = _owner.PrintShowPrinterSettingsDialog(this);
            if (status != GdPictureStatus.OK)
            {
                //todo: handle error
            }
        }

        private void numCopiesUp_Click(object sender, RoutedEventArgs e)
        {
            _numCopies++;
            numCopies.Text = _numCopies.ToString();
        }

        private void numCopiesDown_Click(object sender, RoutedEventArgs e)
        {
            if (_numCopies > 1) _numCopies--;
            numCopies.Text = _numCopies.ToString();
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
        private void numCopies_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (numCopies.Text != "" && numCopies.Text != " ")
            {
                if (int.Parse(numCopies.Text) < 1)
                    numCopies.Text = "1";
                _numCopies = int.Parse(numCopies.Text);
            }
        }

    }
}
