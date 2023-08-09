using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using GdPicture.OCR.Plugins;
using GdPicture14;



namespace PDF_TO_PDF_OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly GdPicturePDF _nativePdf = new GdPicturePDF();
        private bool _cancellationPending;
        private Stopwatch _stopwatch = new Stopwatch();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXX"); //Please, replace XXX by a valid demo or commercial license key.

            txtDictsPath.Text = oLicenseManager.GetRedistPath() + "OCR\\";

            _nativePdf.OcrPagesProgress += this.OcrPagesProgress;
            _nativePdf.BeforePageOcr += this.BeforePageOcr;
            _nativePdf.OcrPagesDone += this.OcrPagesDone;
            _nativePdf.PageBitmapOcrReady += this.PageBitmapOcrReady;

            //GdPictureTesseract.AttachPlugin(_nativePdf); //Uncomment to use GdPicture OCR as external engine.
#if USE_OMNIPAGE_OCR
            OmniPage.AttachPlugin(_nativePdf);//Uncomment to use OmniPage OCR as external engine.
#endif
        }


        private void txtDictsPath_TextChanged(object sender, System.EventArgs e)
        {
            cmbLang.Items.Clear();
            if (Directory.Exists(txtDictsPath.Text))
            {
                DirectoryInfo d = new DirectoryInfo(txtDictsPath.Text);
                FileInfo[] files = d.GetFiles("*.traineddata");
                foreach (FileInfo file in files)
                {
                    cmbLang.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
                }
            }
        }


        private void PageBitmapOcrReady(int PageNo, int ImageID)
        {
            //we're doing nothing yet.
        }



        private void BeforePageOcr(int pageNo, ref bool cancel)
        {
            //we're doing nothing yet.
        }


        private void OcrPagesProgress(GdPictureStatus status, int pageNo, int processed, int count, ref bool cancel)
        {
            ProgressBar1.Maximum = count;
            ProgressBar1.Value = processed;

            if (status != GdPictureStatus.OK)
            {
                if (!_cancellationPending)
                {
                    if (MessageBox.Show("An error occured on page " + pageNo + ". Do you want to cancel the process? Status: " + status, "error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        cancel = true;
                        _cancellationPending = true;
                    }
                }
            }
        }


        private void OcrPagesDone(GdPictureStatus status)
        {
            if (status == GdPictureStatus.OK)
            {
                _stopwatch.Stop();
                string outputFilePath = txtInputFile.Text.Substring(0, txtInputFile.Text.Length - 4) + "_ocr.pdf";

                status = chkIncSave.Checked ? _nativePdf.SaveToFileInc(outputFilePath) : _nativePdf.SaveToFile(outputFilePath, true);

                if (status != GdPictureStatus.OK)
                {
                    MessageBox.Show("Can't save file " + outputFilePath + " . Error: " + status);
                }
                else
                {
                    Process.Start(outputFilePath);
                }
                MessageBox.Show("Done! Please check file " + outputFilePath + "\r\nEllaped: " + _stopwatch.Elapsed.ToString());
            }
            else
            {
                MessageBox.Show("An error occured. Status: " + status);
            }

            _nativePdf.CloseDocument();
            UnlockUi();
        }


        private void LockUi()
        {
            this.Enabled = false;
            ProgressBar1.Visible = true;
            ProgressBar1.Value = 0;
        }


        private void UnlockUi()
        {
            this.Enabled = true;
            ProgressBar1.Visible = false;
        }


        private void btStartOCR_Click(object sender, System.EventArgs e)
        {
            string inputFilePath = txtInputFile.Text;

            if (!string.IsNullOrEmpty(inputFilePath))
            {
                if (!string.IsNullOrEmpty(cmbLang.Text))
                {
                    bool documentLoaded = false;
                    float resolution = float.Parse(txtDPI.Text);

                    if (GdPictureDocumentUtilities.GetDocumentFormat(inputFilePath) != GdPicture14.DocumentFormat.DocumentFormatPDF)
                    {
                        //converting input file to PDF.
                        using (GdPictureDocumentConverter gdpictureDocumentConverter = new GdPictureDocumentConverter())
                        {
                            if (gdpictureDocumentConverter.LoadFromFile(inputFilePath) == GdPictureStatus.OK)
                            {
                                string tmpFilePath = Path.GetTempFileName();
                                Stream stream = File.Create(tmpFilePath, 4096, FileOptions.DeleteOnClose);

                                if (gdpictureDocumentConverter.SaveAsPDF(stream, PdfConformance.PDF1_5) != GdPictureStatus.OK)
                                {
                                    MessageBox.Show("Can't convert file to PDF: " + inputFilePath);
                                    return;
                                }

                                _nativePdf.LoadFromStream(stream, true);
                                documentLoaded = true;
                            }
                            else
                            {
                                MessageBox.Show("Can't open input document: " + inputFilePath);
                                return;
                            }
                        }
                    }

                    if (documentLoaded || _nativePdf.LoadFromFile(inputFilePath, false) == GdPictureStatus.OK)
                    {
                        if (_nativePdf.IsEncrypted())
                        {   //PDF is encrypted, try to decrypt by using empty password
                            if (_nativePdf.SetPassword("") == GdPictureStatus.OK)
                            {
                                MessageBox.Show("This PDF is password protected", "operation cancelled", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                _nativePdf.CloseDocument();
                                return;
                            }
                        }

                        LockUi();
                        _cancellationPending = false;

                        int threadCount = chkMultithread.Checked ? 0 : 1;
                        OCRMode ocrMode = chkFavorSpeed.Checked ? OCRMode.FavorSpeed : OCRMode.FavorAccuracy;

                        _stopwatch.Restart(); //go go go!
                        _nativePdf.SetOcrPageOrientationDetection(chkEnablePageOrientationDetection.Checked);
                        _nativePdf.OcrPages("*", threadCount, cmbLang.Text, txtDictsPath.Text, "", resolution, ocrMode, 0, false);
                    }
                    else
                    {
                        MessageBox.Show("Can't open file: " + inputFilePath);
                    }
                }
                else
                {
                    MessageBox.Show("Please, select a language to recognize.");
                }
            }
            else
            {
                MessageBox.Show("Please, select a file to convert.");
            }
        }


        private void btBrowsInput_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Multiselect = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtInputFile.Text = openFileDialog1.FileName;
                }
            }
        }


        private void btBrowsOCRDict_Click(object sender, System.EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog())
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtDictsPath.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }
    }
}