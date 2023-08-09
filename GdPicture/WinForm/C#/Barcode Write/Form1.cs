using System;
using System.Drawing;
using System.Windows.Forms;
using GdPicture14;

namespace barcode_write
{
    public partial class Form1 : Form
    {
        private GdPictureImaging oGdPictureImaging = new GdPictureImaging();
        private int backImage;

        public Form1()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            LicenseManager oLicenceManager = new LicenseManager();
            oLicenceManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            comboBox1.SelectedIndex = 0;

            backImage = this.oGdPictureImaging.CreateNewGdPictureImage(600, 400, 32, Color.White);
            if (backImage != 0)
            {
                if (gdViewer1.DisplayFromGdPictureImage(backImage) != GdPictureStatus.OK)
                    MessageBox.Show("Cannot Didplay Image. Error: " + gdViewer1.GetStat().ToString());
            }
            else
            {
                MessageBox.Show("Image Could Not Be Created. Error: " + oGdPictureImaging.GetStat().ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Clear image
            oGdPictureImaging.ClearImage(backImage, oGdPictureImaging.ARGB(255, 255, 255));

            // Get text string, which is meant to be encoded
            string data = textBox1.Text;
            int fillColor = oGdPictureImaging.ARGBI(255, 255, 0, 0);
            int backColor = oGdPictureImaging.ARGBI(255, 255, 255, 255);

            if (comboBox1.SelectedIndex < 4)
            {
                int dstLeft = 50;
                int dstTop = 50;
                int dstWidth = 300;
                int dstHeight = 80;
                Barcode1DWriterType barcodeType;

                switch (comboBox1.SelectedIndex) 
                {
                    case 1: barcodeType = Barcode1DWriterType.Barcode1DWriterCode128; break;        // Code128
                    case 2: barcodeType = Barcode1DWriterType.Barcode1DWriterEAN13; break;          // EAN13
                    case 3: barcodeType = Barcode1DWriterType.Barcode1DWriterUPCVersionA; break;    // UPCA
                    default: barcodeType = Barcode1DWriterType.Barcode1DWriterStandard2of5; break;  // Standard 2of5
                }

                oGdPictureImaging.Barcode1DWrite(backImage, barcodeType, data, dstLeft, dstTop, dstWidth, dstHeight, oGdPictureImaging.ARGB(0, 0, 0));
            }

            if (comboBox1.SelectedIndex == 4)   // DataMatrix
            {
                int moduleSize = 8;
                int quietZoneSize = 4;
                BarcodeDataMatrixEncodingMode encodingMode = BarcodeDataMatrixEncodingMode.BarcodeDataMatrixEncodingModeUndefined;
                BarcodeDataMatrixVersion dmVersion = BarcodeDataMatrixVersion.BarcodeDataMatrixVersionAuto;

                if (oGdPictureImaging.BarcodeDataMatrixGetSize(
                    data, encodingMode, ref dmVersion,
                    quietZoneSize, moduleSize,
                    out int width, out int height) == GdPictureStatus.OK)
                {
                    oGdPictureImaging.BarcodeDataMatrixWrite(
                        backImage, data, encodingMode, ref dmVersion, quietZoneSize, moduleSize,
                        50, 50, 0, fillColor, backColor);
                }
            }

            if (comboBox1.SelectedIndex == 5)   // PDF-417
            {
                int moduleWidth = 4;
                int rowHeight = 10;
                int quietZoneSize = 4;
                int rows = 0;
                int cols = 0;
                BarcodePDF417EncodingMode encodingMode = BarcodePDF417EncodingMode.BarcodePDF417EncodingModeUndefined;
                BarcodePDF417ErrorCorrectionLevel ecc = BarcodePDF417ErrorCorrectionLevel.BarcodePDF417ErrorCorrectionLevelAuto;

                if (oGdPictureImaging.BarcodePDF417GetSize(
                    data, encodingMode,
                    ref ecc, ref rows, ref cols,
                    quietZoneSize, moduleWidth, rowHeight,
                    out int width, out int height) == GdPictureStatus.OK)
                {
                    oGdPictureImaging.BarcodePDF417Write(
                        backImage, data, encodingMode, ecc, rows, cols, quietZoneSize,
                        moduleWidth, rowHeight, 50, 50, 0, fillColor, backColor);
                }
            }

            if (comboBox1.SelectedIndex == 6)   // QRCODE
            {
                int moduleSize = 4;
                int quietZoneSize = 4;
                BarcodeQRErrorCorrectionLevel correctionLevel = BarcodeQRErrorCorrectionLevel.BarcodeQRErrorCorrectionLevelH;
                BarcodeQREncodingMode encodingMode = BarcodeQREncodingMode.BarcodeQREncodingModeUndefined;

                int qrCodeVer = 0;
                int codeSize = oGdPictureImaging.BarcodeQRGetSize(
                    data, encodingMode, correctionLevel, out qrCodeVer,
                    quietZoneSize, moduleSize);

                oGdPictureImaging.BarcodeQRWrite(
                    backImage, data, encodingMode, correctionLevel, qrCodeVer,
                    quietZoneSize, moduleSize, 0, 0, 0, fillColor, backColor);
            }

            gdViewer1.Redraw();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Save barcode to PNG file
            if (oGdPictureImaging.SaveAsPNG(backImage, "") != GdPictureStatus.OK)
            {
                MessageBox.Show("Image Could Not Be Saved. Error: " + oGdPictureImaging.GetStat().ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            oGdPictureImaging.ReleaseGdPictureImage(backImage);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) textBox1.Text = "123456";         // Standard 2of5
            if (comboBox1.SelectedIndex == 2) textBox1.Text = "111575999466";   // EAN13
            if (comboBox1.SelectedIndex == 3) textBox1.Text = "11155588855";    // UPCA
        }
    }
}
