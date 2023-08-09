using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using GdPicture14;

namespace Image2PDFOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly GdPicturePDF _nativePdf = new GdPicturePDF();
        private bool _cancellationPending;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            txtDictsPath.Text = oLicenseManager.GetRedistPath() + "OCR\\";

            _nativePdf.OcrPagesProgress += this.OcrPagesProgress;
            _nativePdf.BeforePageOcr += this.BeforePageOcr;
            _nativePdf.OcrPagesDone += this.OcrPagesDone;
        }

        private void txtDictsPath_TextChanged(object sender, System.EventArgs e)
        {
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


        private void BeforePageOcr(int pageNo, ref bool cancel)
        {
            //anything to do
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
                string outputFilePath = Path.ChangeExtension(txtInputFile.Text, "pdf");

                status = _nativePdf.SaveToFile(outputFilePath);

                if (status != GdPictureStatus.OK)
                {
                    MessageBox.Show("Can't save file " + outputFilePath + " . Error: " + status);
                }
                else
                {
                    Process.Start(outputFilePath);
                }

                MessageBox.Show("Done! Please check file " + outputFilePath);
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
            if (!string.IsNullOrEmpty(txtInputFile.Text))
            {
                if (!string.IsNullOrEmpty(cmbLang.Text))
                {
                    using (GdPictureImaging gdpictureImaging = new GdPictureImaging())
                    {
                        int imageID = gdpictureImaging.CreateGdPictureImageFromFile(txtInputFile.Text);
                        if (gdpictureImaging.GetStat() == GdPictureStatus.OK)
                        {
                            float resolution = System.Math.Max(200, gdpictureImaging.GetVerticalResolution(imageID));
                            _nativePdf.NewPDF(PdfConformance.PDF_A_1b);

                            for (int i = 1; i <= gdpictureImaging.GetPageCount(imageID); i++)
                            {
                                if (gdpictureImaging.SelectPage(imageID, i) == GdPictureStatus.OK)
                                {
                                    _nativePdf.AddImageFromGdPictureImage(imageID, false, true);
                                }
                            }
                            gdpictureImaging.ReleaseGdPictureImage(imageID);

                            LockUi();
                            _cancellationPending = false;

                            int threadCount;
                            if (chkMultithread.Checked)
                            {
                                threadCount = 0;
                                //0 means automatic number of thread computation
                            }
                            else
                            {
                                threadCount = 1;
                            }

                            _nativePdf.OcrPages("*", threadCount, cmbLang.Text, txtDictsPath.Text, "", resolution, chkFavorAccuracy.Checked ? OCRMode.FavorAccuracy : OCRMode.FavorSpeed, 0, false);
                        }
                        else
                        {
                            MessageBox.Show("Can't open file: " + txtInputFile.Text + " status: " + gdpictureImaging.GetStat().ToString());
                        }
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
                openFileDialog1.Filter = "Image File|*.*";
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
