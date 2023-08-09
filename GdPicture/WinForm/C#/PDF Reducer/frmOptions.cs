using System;
using System.Windows.Forms;
using GdPicture14;

namespace pdfReducer
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();

            cmbImageQuality.Items.AddRange(new object[] { "Low", "Medium", "High", "Very High" });
            cmbPreferredVersion.Items.AddRange(new object[] { "Retain existing", "1.4", "1.5", "1.6", "1.7" });
        }


        private void LoadConfig()
        {
            chkEnableColorDetection.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableColorDetection;
            chkCharRepair.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableCharRepair;
            chkRecompressImages.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.RecompressImages;
            cmbImageQuality.SelectedIndex = (int)Globals.ApplicationConfiguration.PDFReducerConfiguration.ImageQuality;
            chkPackDocument.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.PackDocument;
            chkDownscaleImages.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.DownscaleImages;
            nuDownscaleResolution.Value = Globals.ApplicationConfiguration.PDFReducerConfiguration.DownscaleResolution;
            nuBackgroundImageResolution.Value = Globals.ApplicationConfiguration.PDFReducerConfiguration.DownscaleResolutionMRC;

            chkFastWebView.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.FastWebView;
            chkRemoveAnnotations.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveAnnotations;
            chkRemoveBookmarks.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveBookmarks;
            chkRemoveFormFields.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveFormFields;
            chkRemoveHyperlinks.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveHyperlinks;
            chkRemoveEmbeddedFiles.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveEmbeddedFiles;

            cmbPreferredVersion.SelectedItem = cmbPreferredVersion.Items[(int)Globals.ApplicationConfiguration.PDFReducerConfiguration.OutputFormat];
            chkJPEG2000.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableJPEG2000;
            chkUseMRC.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableMRC;
            chkKeepWriteAcessTime.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.KeepOriginalLastWriteAcessTime;
            chkPreserveSmoothing.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.PreserveSmoothing;
            chkPackFonts.Checked = Globals.ApplicationConfiguration.PDFReducerConfiguration.PackFonts;
            chkOnlyPdf.Checked = Globals.ApplicationConfiguration.OnlyProcessPDF;

            // Check whether mutually exclusive options should be disabled
            chkCharRepair.Enabled = Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableColorDetection;
            cmbImageQuality.Enabled = Globals.ApplicationConfiguration.PDFReducerConfiguration.RecompressImages;
            nuDownscaleResolution.Enabled = Globals.ApplicationConfiguration.PDFReducerConfiguration.DownscaleImages;
            lbDpi.Enabled = Globals.ApplicationConfiguration.PDFReducerConfiguration.DownscaleImages;
            lbResolution.Enabled = Globals.ApplicationConfiguration.PDFReducerConfiguration.DownscaleImages;
            chkPreserveSmoothing.Enabled = Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableMRC;
            lbBackgroundImageResolution.Enabled = Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableMRC;
            lbDpi2.Enabled = Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableMRC;
            nuBackgroundImageResolution.Enabled = Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableMRC;
        }


        private void frmOptions_Load(object sender, EventArgs e)
        {
            try
            {
                LoadConfig();
            }
            catch
            {
                LoadConfig();
            }
        }


        private void btReset_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }


        private void btApply_click(object sender, EventArgs e)
        {
            Globals.ApplicationConfiguration.OnlyProcessPDF = chkOnlyPdf.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.KeepOriginalLastWriteAcessTime = chkKeepWriteAcessTime.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableColorDetection = chkEnableColorDetection.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.RecompressImages = chkRecompressImages.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.ImageQuality = (PDFReducerImageQuality)cmbImageQuality.SelectedIndex;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.PackDocument = chkPackDocument.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.DownscaleImages = chkDownscaleImages.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.DownscaleResolution = (int)nuDownscaleResolution.Value;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.DownscaleResolutionMRC = (int)nuBackgroundImageResolution.Value;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.FastWebView = chkFastWebView.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveAnnotations = chkRemoveAnnotations.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveBookmarks = chkRemoveBookmarks.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveFormFields = chkRemoveFormFields.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveEmbeddedFiles = chkRemoveEmbeddedFiles.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.RemoveHyperlinks = chkRemoveHyperlinks.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.OutputFormat = (PDFReducerPDFVersion)cmbPreferredVersion.SelectedIndex;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableJPEG2000 = chkJPEG2000.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableMRC = chkUseMRC.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.EnableCharRepair = chkCharRepair.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.PreserveSmoothing = chkPreserveSmoothing.Checked;
            Globals.ApplicationConfiguration.PDFReducerConfiguration.PackFonts = chkPackFonts.Checked;

            Dispose();
        }


        private void chkEnableColorDetection_CheckedChanged(object sender, EventArgs e)
        {
            chkCharRepair.Enabled = chkEnableColorDetection.Checked;
        }


        private void chkUseMRC_CheckedChanged(object sender, EventArgs e)
        {
            chkPreserveSmoothing.Enabled = chkUseMRC.Checked;
            nuBackgroundImageResolution.Enabled = chkUseMRC.Checked;
            lbBackgroundImageResolution.Enabled = chkUseMRC.Checked;
            lbDpi2.Enabled = chkUseMRC.Checked;
        }


        private void chkDownscaleImages_CheckedChanged(object sender, EventArgs e)
        {
            nuDownscaleResolution.Enabled = chkDownscaleImages.Checked;
            lbDpi.Enabled = chkDownscaleImages.Checked;
            lbResolution.Enabled = chkDownscaleImages.Checked;
        }


        private void chkRecompressImages_CheckedChanged(object sender, EventArgs e)
        {
            cmbImageQuality.Enabled = chkRecompressImages.Checked;
        }
    }
}