using System.Collections.Generic;

namespace barcode_recognition
{

    public partial class BarcodeResults
    {

        private List<SingleBarcodeInfo> _barcode1DResults;
        private List<SingleBarcodeInfo> _barcode2DResults;
        private List<SingleBarcodeInfo> _barcodeQRResults;
        private List<SingleBarcodeInfo> _barcodePDF417Results;
        private List<SingleBarcodeInfo> _barcodeMicroQRResults;
        private List<SingleBarcodeInfo> _barcodeAztecResults;
        private List<SingleBarcodeInfo> _barcodeMaxicodeResults;
        private List<SingleBarcodeInfo> _patchCodeResults;

        private int _totalBarcodesCount = 0;

        public BarcodeResults(List<SingleBarcodeInfo> barcode1DResults, List<SingleBarcodeInfo> barcode2DResults,
            List<SingleBarcodeInfo> barcodeQrResults, List<SingleBarcodeInfo> barcodePDF417Results, List<SingleBarcodeInfo> barcodeMicroQrResults,
            List<SingleBarcodeInfo> barcodeAztecResults, List<SingleBarcodeInfo> barcodeMaxicodeResults, List<SingleBarcodeInfo> patchCodeResults)
        {
            InitializeComponent();

            this._barcode1DResults = barcode1DResults;
            this._barcode2DResults = barcode2DResults;
            this._barcodeQRResults = barcodeQrResults;
            this._barcodePDF417Results = barcodePDF417Results;
            this._barcodeMicroQRResults = barcodeMicroQrResults;
            this._barcodeAztecResults = barcodeAztecResults;
            this._patchCodeResults = patchCodeResults;
            this._barcodeMaxicodeResults = barcodeMaxicodeResults;

            EnableButtons();
        }

        private void EnableButtons()
        {
            bool populated = false;
            if (this._barcode1DResults != null && this._barcode1DResults.Count > 0)
            {
                this.btn1DBarcode.Text = this.btn1DBarcode.Text + ": " + this._barcode1DResults.Count;
                _totalBarcodesCount += this._barcode1DResults.Count;
                this.btn1DBarcode.Enabled = true;
                PopulateList(this._barcode1DResults);
                populated = true;
            }

            if (this._barcode2DResults != null && this._barcode2DResults.Count > 0)
            {
                this.btn2DBarcode.Text = this.btn2DBarcode.Text + ": " + this._barcode2DResults.Count;
                _totalBarcodesCount += this._barcode2DResults.Count;
                this.btn2DBarcode.Enabled = true;
                if (!populated)
                {
                    PopulateList(this._barcode2DResults);
                    populated = true;
                }
            }

            if (this._barcodeQRResults != null && this._barcodeQRResults.Count > 0)
            {
                this.btnQRBarcode.Text = this.btnQRBarcode.Text + ": " + this._barcodeQRResults.Count;
                _totalBarcodesCount += this._barcodeQRResults.Count;
                this.btnQRBarcode.Enabled = true;
                if (!populated)
                {
                    PopulateList(this._barcodeQRResults);
                    populated = true;
                }
            }

            if (this._barcodePDF417Results != null && this._barcodePDF417Results.Count > 0)
            {
                this.btnPDF417Barcode.Text = this.btnPDF417Barcode.Text + ": " + this._barcodePDF417Results.Count;
                _totalBarcodesCount += this._barcodePDF417Results.Count;
                this.btnPDF417Barcode.Enabled = true;
                if (!populated)
                {
                    PopulateList(this._barcodePDF417Results);
                    populated = true;
                }
            }

            if (this._barcodeMicroQRResults != null && this._barcodeMicroQRResults.Count > 0)
            {
                this.btnMicroQRBarcode.Text = this.btnMicroQRBarcode.Text + ": " + this._barcodeMicroQRResults.Count;
                _totalBarcodesCount += this._barcodeMicroQRResults.Count;
                this.btnMicroQRBarcode.Enabled = true;
                if (!populated)
                {
                    PopulateList(this._barcodeMicroQRResults);
                    populated = true;
                }
            }

            if (this._barcodeAztecResults != null && this._barcodeAztecResults.Count > 0)
            {
                this.btnAztecBarcode.Text = this.btnAztecBarcode.Text + ": " + this._barcodeAztecResults.Count;
                _totalBarcodesCount += this._barcodeAztecResults.Count;
                this.btnAztecBarcode.Enabled = true;
                if (!populated)
                {
                    PopulateList(this._barcodeAztecResults);
                    populated = true;
                }
            }

            if (this._barcodeMaxicodeResults != null && this._barcodeMaxicodeResults.Count > 0)
            {
                this.btnMaxicodeBarcode.Text = this.btnMaxicodeBarcode.Text + ": " + this._barcodeMaxicodeResults.Count;
                _totalBarcodesCount += this._barcodeMaxicodeResults.Count;
                this.btnMaxicodeBarcode.Enabled = true;
                if (!populated)
                {
                    PopulateList(this._barcodeMaxicodeResults);
                    populated = true;
                }
            }

            if (this._patchCodeResults != null && this._patchCodeResults.Count > 0)
            {
                this.btnPatchCodeBarcode.Text = this.btnPatchCodeBarcode.Text + ": " + this._patchCodeResults.Count;
                _totalBarcodesCount += this._patchCodeResults.Count;
                this.btnPatchCodeBarcode.Enabled = true;
                if (!populated)
                {
                    PopulateList(this._patchCodeResults);
                    populated = true;
                }
            }

            lblTotalBarcodesCount.Text = lblTotalBarcodesCount.Text + " " + _totalBarcodesCount;
        }

        private void Close_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Form_Closing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            ClearLists();
        }

        private void ClearLists()
        {
            _barcode1DResults.Clear();
            _barcode2DResults.Clear();
            _barcodeQRResults.Clear();
            _barcodePDF417Results.Clear();
            _barcodeMicroQRResults.Clear();
            _barcodeAztecResults.Clear();
            _barcodeMaxicodeResults.Clear();
            _patchCodeResults.Clear();
        }

        private void PopulateList(List<SingleBarcodeInfo> barcodesResultsList)
        {
            resultsList.Controls.Clear();
            for (int i = 0; i <= barcodesResultsList.Count - 1; i++)
            {
                resultsList.Controls.Add(barcodesResultsList[i]);
            }
        }

        private void btn1DBarcode_Click(object sender, System.EventArgs e)
        {
            PopulateList(this._barcode1DResults);
        }

        private void btn2DBarcode_Click(object sender, System.EventArgs e)
        {
            PopulateList(this._barcode2DResults);
        }

        private void btnQRBarcode_Click(object sender, System.EventArgs e)
        {
            PopulateList(this._barcodeQRResults);
        }

        private void btnPDF417Barcode_Click(object sender, System.EventArgs e)
        {
            PopulateList(this._barcodePDF417Results);
        }

        private void btnMicroQRBarcode_Click(object sender, System.EventArgs e)
        {
            PopulateList(this._barcodeMicroQRResults);
        }

        private void btnPatchCodeBarcode_Click(object sender, System.EventArgs e)
        {
            PopulateList(this._patchCodeResults);
        }

        private void btnAztecBarcode_Click(object sender, System.EventArgs e)
        {
            PopulateList(this._barcodeAztecResults);
        }

        private void btnMaxicodeBarcode_Click(object sender, System.EventArgs e)
        {
            PopulateList(this._barcodeMaxicodeResults);
        }
    }
}
