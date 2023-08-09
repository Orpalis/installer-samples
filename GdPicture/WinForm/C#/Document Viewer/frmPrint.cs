using GdPicture14;
using System;
using System.Windows.Forms;

namespace Document_Viewer
{
    public partial class frmPrint
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

        private PrintSettings _printSettings;
        private readonly GdViewer _owner;

        public PrintSettings printConfiguration
        {
            get
            {
                return _printSettings;
            }
        }

        private bool m_isSelectionPartial;
        private bool m_isEmptySelection;

        public frmPrint(GdViewer owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        private void frmPrint_Load(object sender, EventArgs e)
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
                rbPageRangeSelection.Enabled = false;
            }
            else
            {
                if (m_isSelectionPartial)
                {
                    rbPageRangeSelection.Checked = true;
                }
            }
            txtPageRangeStart.Enabled = false;
            txtPageRangeEnd.Enabled = false;
            txtPageRangeStart.Text = "1";
            txtPageRangeEnd.Text = _owner.PageCount.ToString();

            btnPrint.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void btnPrinterProperties_Click(object sender, EventArgs e)
        {
            GdPictureStatus status = _owner.PrintShowPrinterSettingsDialog(this.Handle);
            if (status != GdPictureStatus.OK)
            {
                //todo: handle error
            }
        }

        private void cmbPrinterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _owner.PrintSetActivePrinter(cmbPrinterList.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbPageRangeAll_CheckedChanged(object sender, EventArgs e)
        {
            rbPageRangeGeneric_CheckedChanged();
        }

        private void rbPageRangeSelection_CheckedChanged(object sender, EventArgs e)
        {
            rbPageRangeGeneric_CheckedChanged();
        }

        private void rbPageRangeCurrent_CheckedChanged(object sender, EventArgs e)
        {
            rbPageRangeGeneric_CheckedChanged();
        }

        private void rbPageRangePages_CheckedChanged(object sender, EventArgs e)
        {
            rbPageRangeGeneric_CheckedChanged();
        }

        private void rbPageRangeGeneric_CheckedChanged()
        {
            if (rbPageRangePages.Checked)
            {
                txtPageRangeStart.Enabled = true;
                txtPageRangeEnd.Enabled = true;
            }
            else
            {
                txtPageRangeStart.Enabled = false;
                txtPageRangeEnd.Enabled = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _printSettings.Printer = cmbPrinterList.Text;
            _printSettings.Copies = (short)numCopies.Value;
            _printSettings.Collate = chkCollate.Checked;
            _printSettings.PrintSize = (PrintSizeOption)cmbPrintSize.SelectedIndex;
            _printSettings.PrintAlignment = (PrintAlignment)cmbPrintAlignment.SelectedIndex;

            if (rbOrientationAutomatic.Checked)
            {
                _printSettings.Orientation = PrintOrientation.AutoDetection;
            }
            else if (rbOrientationPortrait.Checked)
            {
                _printSettings.Orientation = PrintOrientation.Portrait;
            }
            else if (rbOrientationLandscape.Checked)
            {
                _printSettings.Orientation = PrintOrientation.Paysage;
            }

            if (rbPageRangeAll.Checked)
            {
                _printSettings.PagesToPrint = PagesToPrint.All;
            }
            else if (rbPageRangeSelection.Checked)
            {
                _printSettings.PagesToPrint = PagesToPrint.Selection;
            }
            else if (rbPageRangeCurrent.Checked)
            {
                _printSettings.PagesToPrint = PagesToPrint.Current;
            }
            else if (rbPageRangePages.Checked)
            {
                _printSettings.PagesToPrint = PagesToPrint.Range;
                _printSettings.PageRange = txtPageRangeStart.Text + "-" + txtPageRangeEnd.Text;
            }
        }

    }
}
