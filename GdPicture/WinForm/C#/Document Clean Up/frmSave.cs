using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using GdPicture14;

namespace DocumentCleanUp
{
    public partial class frmSave
    {

        private readonly int _image;

        public frmSave(int image)
        {
            InitializeComponent();
            _image = image;
        }

        private readonly List<KeyValuePair<int, string>> _exportFormat = new List<KeyValuePair<int, string>>
        {
				new KeyValuePair<int, string>(0, "Windows or OS/2 bitmap (.bmp)"),
				new KeyValuePair<int, string>(1, "High Dynamic Range (.webp)"),
				new KeyValuePair<int, string>(2, "Graphics Interchange Format (.gif)"),
				new KeyValuePair<int, string>(3, "JBIG2 (.jbig2)"),
				new KeyValuePair<int, string>(4, "JPEG (.jpg)"),
				new KeyValuePair<int, string>(5, "JPEG-2000 (.jp2)"),
				new KeyValuePair<int, string>(6, "JPEG-2000 Codestream (.j2k)"),
				new KeyValuePair<int, string>(7, "Portable Document Format (.pdf)"),
				new KeyValuePair<int, string>(8, "Portable Network Graphics (.png)"),
				new KeyValuePair<int, string>(9, "Truevision TARGA (.tga)"),
				new KeyValuePair<int, string>(10, "Tagged Image File (.tif)"),
				new KeyValuePair<int, string>(11, "Google WebP (.webp)"),
				new KeyValuePair<int, string>(12, "Windows Metafile (.wmf)"),
				new KeyValuePair<int, string>(13, "X PixMap (.xpm)")
			};

        private readonly List<KeyValuePair<ExrCompression, string>> _exrCompression = new List<KeyValuePair<ExrCompression, string>>
        {
				new KeyValuePair<ExrCompression, string>(ExrCompression.ExrCompressionDefault, "Half with piz-based wavelet compression"),
				new KeyValuePair<ExrCompression, string>(ExrCompression.ExrCompressionFloat, "Float instead of as half (not recommended)"),
				new KeyValuePair<ExrCompression, string>(ExrCompression.ExrCompressionNone, "No compression"),
				new KeyValuePair<ExrCompression, string>(ExrCompression.ExrCompressionZip, "Zlib compression, in blocks of 16 scan lines"),
				new KeyValuePair<ExrCompression, string>(ExrCompression.ExrCompressionPiz, "Piz-based wavelet compression"),
				new KeyValuePair<ExrCompression, string>(ExrCompression.ExrCompressionPxr24, "Lossy 24-bit float compression"),
				new KeyValuePair<ExrCompression, string>(ExrCompression.ExrCompressionB44, "Lossy 44% float compression"),
				new KeyValuePair<ExrCompression, string>(ExrCompression.ExrCompressionLC, "One luminance and two chroma channels")
			};

        private readonly List<KeyValuePair<TiffCompression, string>> _tiffCompression = new List<KeyValuePair<TiffCompression, string>>
        {
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionNONE, "No compression"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionRLE, "CCITT modified Huffman RLE"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionCCITT3, "CCITT Group 3 fax encoding"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionCCITT4, "CCITT Group 4 fax encoding"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionLZW, "Lempel-Ziv and Welch (LZW)"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionJPEG, "JPEG DCT compression"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionADOBEDEFLATE, "Deflate compression,as recognized by Adobe"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionNEXT, "NeXT 2-bit RLE"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionCCITTRLEW, "#1 w/ word alignment"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionPACKBITS, "Macintosh RLE"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionTHUNDERSCAN, "ThunderScan RLE"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionDEFLATE, "Deflate compression"),
				new KeyValuePair<TiffCompression, string>(TiffCompression.TiffCompressionAUTO, "Automatic compression")
			};

        private void frmSave_Load(object sender, EventArgs e)
        {
            txtDestinationFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            cbDocumentFormat.ValueMember = "Key";
            cbDocumentFormat.DisplayMember = "Value";
            cbDocumentFormat.DataSource = _exportFormat;
            cbDocumentFormat.SelectedValue = 4;

            cbExrCompression.ValueMember = "Key";
            cbExrCompression.DisplayMember = "Value";
            cbExrCompression.DataSource = _exrCompression;
            cbExrCompression.SelectedValue = ExrCompression.ExrCompressionDefault;

            cbTiffCompression.ValueMember = "Key";
            cbTiffCompression.DisplayMember = "Value";
            cbTiffCompression.DataSource = _tiffCompression;
            cbTiffCompression.SelectedValue = TiffCompression.TiffCompressionAUTO;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowseDialog = new FolderBrowserDialog();
            if (folderBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestinationFolder.Text = folderBrowseDialog.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string outputPath = Path.Combine(txtDestinationFolder.Text, "Image_Processing_Demo_" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss"));
            GdPictureStatus status = default(GdPictureStatus);
            using (GdPictureImaging gdPictureImaging = new GdPictureImaging())
            {
                switch (cbDocumentFormat.SelectedIndex)
                {
                    case 0:
                        outputPath += ".bmp";
                        status = gdPictureImaging.SaveAsBMP(_image, outputPath);
                        break;
                    case 1:
                        outputPath += ".webp";
                        status = gdPictureImaging.SaveAsEXR(_image, outputPath, (ExrCompression)cbExrCompression.SelectedValue);
                        break;
                    case 2:
                        outputPath += ".gif";
                        status = gdPictureImaging.SaveAsGIF(_image, outputPath);
                        break;
                    case 3:
                        outputPath += ".jbig2";
                        status = gdPictureImaging.SaveAsJBIG2(_image, outputPath);
                        break;
                    case 4:
                        outputPath += ".jpg";
                        status = gdPictureImaging.SaveAsJPEG(_image, outputPath, (int)nJpegQuality.Value, chkProgressive.Checked);
                        break;
                    case 5:
                        outputPath += ".jp2";
                        status = gdPictureImaging.SaveAsJP2(_image, outputPath, (int)nJ2kRate.Value);
                        break;
                    case 6:
                        outputPath += ".j2k";
                        status = gdPictureImaging.SaveAsJ2K(_image, outputPath, (int)nJ2kRate.Value);
                        break;
                    case 7:
                        outputPath += ".pdf";
                        status = gdPictureImaging.SaveAsPDF(_image, outputPath, false, "Image Export", "Image Processing Demo", "Image Export", "", "GdPicture.NET");
                        break;
                    case 8:
                        outputPath += ".png";
                        status = gdPictureImaging.SaveAsPNG(_image, outputPath, (int)nPngCompressionLevel.Value, chkPngInterlaced.Checked);
                        break;
                    case 9:
                        outputPath += ".tga";
                        status = gdPictureImaging.SaveAsTGA(_image, outputPath);
                        break;
                    case 10:
                        outputPath += ".tif";
                        status = gdPictureImaging.SaveAsTIFF(_image, outputPath, chkTiffCmyk.Checked, (TiffCompression)cbTiffCompression.SelectedValue, (int)nJpegQuality.Value);
                        break;
                    case 11:
                        outputPath += ".webp";
                        status = gdPictureImaging.SaveAsWEBP(_image, outputPath, 75, 6);
                        break;
                    case 12:
                        outputPath += ".wmf";
                        status = gdPictureImaging.SaveAsWMF(_image, outputPath);
                        break;
                    case 13:
                        outputPath += ".xpm";
                        status = gdPictureImaging.SaveAsXPM(_image, outputPath);
                        break;
                }
                if (status != GdPictureStatus.OK)
                {
                    MessageBox.Show("An error occured: " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("The image has been saved as " + outputPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Close();
        }

        private void cbDocumentFormat_ValueMemberChanged(object sender, EventArgs e)
        {
            switch (cbDocumentFormat.SelectedIndex)
            {
                case 0:
                    grpCompressionOptions.Enabled = false;
                    break;
                case 1:
                    grpCompressionOptions.Enabled = true;
                    cbExrCompression.Enabled = true;
                    nJ2kRate.Enabled = false;
                    nJpegQuality.Enabled = false;
                    chkProgressive.Enabled = false;
                    nPngCompressionLevel.Enabled = false;
                    chkPngInterlaced.Enabled = false;
                    cbTiffCompression.Enabled = false;
                    chkTiffCmyk.Enabled = false;
                    break;
                case 2:
                    grpCompressionOptions.Enabled = false;
                    break;
                case 3:
                    grpCompressionOptions.Enabled = false;
                    break;
                case 4:
                    grpCompressionOptions.Enabled = true;
                    cbExrCompression.Enabled = false;
                    nJ2kRate.Enabled = false;
                    nJpegQuality.Enabled = true;
                    chkProgressive.Enabled = true;
                    nPngCompressionLevel.Enabled = false;
                    chkPngInterlaced.Enabled = false;
                    cbTiffCompression.Enabled = false;
                    chkTiffCmyk.Enabled = false;
                    break;
                case 5:
                    grpCompressionOptions.Enabled = true;
                    cbExrCompression.Enabled = false;
                    nJ2kRate.Enabled = true;
                    nJpegQuality.Enabled = false;
                    chkProgressive.Enabled = false;
                    nPngCompressionLevel.Enabled = false;
                    chkPngInterlaced.Enabled = false;
                    cbTiffCompression.Enabled = false;
                    chkTiffCmyk.Enabled = false;
                    break;
                case 6:
                    grpCompressionOptions.Enabled = true;
                    cbExrCompression.Enabled = false;
                    nJ2kRate.Enabled = true;
                    nJpegQuality.Enabled = false;
                    chkProgressive.Enabled = false;
                    nPngCompressionLevel.Enabled = false;
                    chkPngInterlaced.Enabled = false;
                    cbTiffCompression.Enabled = false;
                    chkTiffCmyk.Enabled = false;
                    break;
                case 7:
                    grpCompressionOptions.Enabled = false;
                    break;
                case 8:
                    grpCompressionOptions.Enabled = true;
                    cbExrCompression.Enabled = false;
                    nJ2kRate.Enabled = false;
                    nJpegQuality.Enabled = false;
                    chkProgressive.Enabled = false;
                    nPngCompressionLevel.Enabled = true;
                    chkPngInterlaced.Enabled = true;
                    cbTiffCompression.Enabled = false;
                    chkTiffCmyk.Enabled = false;
                    break;
                case 9:
                    grpCompressionOptions.Enabled = false;
                    break;
                case 10:
                    grpCompressionOptions.Enabled = true;
                    cbExrCompression.Enabled = false;
                    nJ2kRate.Enabled = false;
                    nJpegQuality.Enabled = false;
                    chkProgressive.Enabled = false;
                    nPngCompressionLevel.Enabled = false;
                    chkPngInterlaced.Enabled = false;
                    cbTiffCompression.Enabled = true;
                    chkTiffCmyk.Enabled = true;
                    break;
                case 11:
                    grpCompressionOptions.Enabled = false;
                    break;
                case 12:
                    grpCompressionOptions.Enabled = false;
                    break;
                case 13:
                    grpCompressionOptions.Enabled = false;
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
