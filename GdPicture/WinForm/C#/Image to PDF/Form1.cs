using GdPicture14;
using System;
using System.IO;
using System.Windows.Forms;


namespace Image2PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void Form1_Load(Object sender, EventArgs e)
        {
            LicenseManager licenseManager = new LicenseManager();
            licenseManager.RegisterKEY("XXX"); //Please replace XXX by a valid commercial or demo key.
            cmbPDFConformance.SelectedIndex = 9; // PDF 1.5.
        }


        public void Button1_Click(Object sender, EventArgs e)
        {
            OpenFileDialog1.Multiselect = false;
            OpenFileDialog1.Filter = "Image File|*.*";
            OpenFileDialog1.FileName = "";

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = OpenFileDialog1.FileName;
            }
        }


        public void Button2_Click(Object sender, EventArgs e)
        {
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDstFolder.Text = FolderBrowserDialog1.SelectedPath + "\\";
            }
        }


        public void Button3_Click(Object sender, EventArgs e)
        {
            try
            {
                ProgressBar1.Value = 0;
                ProgressBar1.Visible = true;

                using (GdPictureImaging gdpictureImaging = new GdPictureImaging())
                {
                    if (string.IsNullOrWhiteSpace(txtInputFile.Text))
                    {
                        MessageBox.Show("Please select an input image.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtDstFolder.Text))
                    {
                        MessageBox.Show("Please select a valid destination folder.");
                        return;
                    }

                    int imageID = gdpictureImaging.CreateGdPictureImageFromFile(txtInputFile.Text);

                    if (imageID == 0)
                    {
                        MessageBox.Show("Error: " + gdpictureImaging.GetStat().ToString());
                        gdpictureImaging.ReleaseGdPictureImage(imageID);

                        return;
                    }

                    int pageCount = gdpictureImaging.GetPageCount(imageID);

                    ProgressBar1.Maximum = pageCount;

                    using (GdPicturePDF gdpicturePDF = new GdPicturePDF())
                    {
                        gdpicturePDF.NewPDF(GetSelectedConformance());
                        gdpicturePDF.SetCompressionForBitonalImage(PdfCompression.PdfCompressionJBIG2);
                        gdpicturePDF.SetCompressionForColorImage(PdfCompression.PdfCompressionJPEG);

                        for (int pageNo = 1; pageNo <= pageCount; pageNo++)
                        {
                            gdpictureImaging.SelectPage(imageID, pageNo);
                            gdpicturePDF.AddImageFromGdPictureImage(imageID, false, true);

                            if (gdpicturePDF.GetStat() != GdPictureStatus.OK)
                            {
                                MessageBox.Show("Error adding bitmap to the PDF. Status: " + gdpicturePDF.GetStat().ToString());
                                gdpicturePDF.CloseDocument();
                                gdpictureImaging.ReleaseGdPictureImage(imageID);

                                return;
                            }

                            ProgressBar1.Value = pageNo;
                            Application.DoEvents();
                        }

                        string dstFile = txtDstFolder.Text + Path.GetFileNameWithoutExtension(txtInputFile.Text) + ".pdf";

                        gdpicturePDF.SaveToFile(dstFile);

                        if (gdpicturePDF.GetStat() != GdPictureStatus.OK)
                        {
                            MessageBox.Show("Error saving PDF. Status: " + gdpicturePDF.GetStat().ToString());
                        }
                        else
                        {
                            MessageBox.Show(dstFile + " has been successfully  created.");
                        }

                        gdpicturePDF.CloseDocument();
                        gdpictureImaging.ReleaseGdPictureImage(imageID);
                    }
                }
            }
            finally
            {
                ProgressBar1.Visible = false;
            }
        }


        private PdfConformance GetSelectedConformance()
        {
            switch (cmbPDFConformance.SelectedIndex)
            {
                case 0: return PdfConformance.PDF_A_1a;
                case 1: return PdfConformance.PDF_A_1b;
                case 2: return PdfConformance.PDF_A_2a;
                case 3: return PdfConformance.PDF_A_2b;
                case 4: return PdfConformance.PDF_A_2u;
                case 5: return PdfConformance.PDF_A_3a;
                case 6: return PdfConformance.PDF_A_3b;
                case 7: return PdfConformance.PDF_A_3u;
                case 8: return PdfConformance.PDF1_4;
                case 9: return PdfConformance.PDF1_5;
                case 10: return PdfConformance.PDF1_6;
                case 11: return PdfConformance.PDF1_7;
                case 12: return PdfConformance.PDF2_0;
                case 13: return PdfConformance.PDF_UA_1;
                default: throw new System.InvalidOperationException();
            }
        }
    }
}