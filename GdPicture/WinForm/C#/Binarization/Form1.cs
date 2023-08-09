using GdPicture14;
using System;
using System.Windows.Forms;

namespace Binarization
{
    public partial class FormBinarizationDemo : Form
    {
        private int _originImageId;

        private int _clonedImageId;

        private readonly GdPictureImaging _oGdPictureImaging = new GdPictureImaging();

        private BitonalReduction _bitonalReduction;

        private bool _lockEvents = false;

        private int _previousComboBoxIndex = -1;


        public FormBinarizationDemo()
        {
            InitializeComponent();
        }


        private void FormBinarizationDemo_Load(object sender, EventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
            scroll1Panel.Visible = false;
            scroll2Panel.Visible = false;
            scroll3Panel.Visible = false;
        }


        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            CloseImage();

            _originImageId = _oGdPictureImaging.CreateGdPictureImageFromFile(""); //Providing an empty string prompts the user to select a file.
            GdPictureStatus gdPictureStatus;
            if ((gdPictureStatus = _oGdPictureImaging.GetStat()) != GdPictureStatus.OK)
            {
                MessageBox.Show(gdPictureStatus.ToString(), "Image could not be loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
                GdViewer1.DisplayFromGdPictureImage(_originImageId);
            }
        }


        private void ComboBoxBinarizationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _lockEvents = true;
            switch (ComboBoxBinarizationMode.SelectedIndex)
            {

                case 0: //None
                    scroll1Panel.Visible = false;
                    scroll2Panel.Visible = false;
                    scroll3Panel.Visible = false;
                    _previousComboBoxIndex = 0;
                    break;
                case 1: //Linear
                    // change threshold parameters
                    if (_previousComboBoxIndex != 1)
                    {
                        LabelThreshold.Text = "Threshold";
                        LabelThresholdMin.Text = "1";
                        LabelThresholdMax.Text = "254";
                        HScrollBarThreshold.Minimum = 1;
                        HScrollBarThreshold.Maximum = 254;
                        HScrollBarThreshold.Value = 128;
                        TextBoxThresholdVal.Text = HScrollBarThreshold.Value.ToString();
                        scroll1Panel.Visible = true;
                        scroll2Panel.Visible = false;
                        scroll3Panel.Visible = false;
                    }
                    _previousComboBoxIndex = 1;
                    break;
                case 2: //Adaptive
                    if (_previousComboBoxIndex != 2)
                    {
                        LabelThresholdMin.Text = "0";
                        LabelThreshold.Text = "Threshold";
                        LabelThresholdMax.Text = "100";
                        HScrollBarThreshold.Minimum = 0;
                        HScrollBarThreshold.Maximum = 100;
                        HScrollBarThreshold.Value = 50;
                        TextBoxThresholdVal.Text = HScrollBarThreshold.Value.ToString();
                        scroll1Panel.Visible = true;
                        scroll2Panel.Visible = false;
                        scroll3Panel.Visible = false;
                    }
                    _previousComboBoxIndex = 2;
                    break;
                case 3: //Order Dither
                    scroll1Panel.Visible = false;
                    scroll2Panel.Visible = false;
                    scroll3Panel.Visible = false;
                    _previousComboBoxIndex = 3;
                    _bitonalReduction = BitonalReduction.OrderedDither;
                    break;
                case 4: //Burke
                    if (_previousComboBoxIndex != 4)
                    {
                        LabelThreshold.Text = "PalWeight";
                        LabelThresholdMax.Text = "255";
                        HScrollBarThreshold.Minimum = 1;
                        LabelThresholdMin.Text = "1";
                        HScrollBarThreshold.Maximum = 255;
                        HScrollBarThreshold.Value = 15;
                        TextBoxThresholdVal.Text = HScrollBarThreshold.Value.ToString();
                        scroll1Panel.Visible = true;
                        scroll2Panel.Visible = false;
                        scroll3Panel.Visible = false;
                    }
                    _previousComboBoxIndex = 4;
                    _bitonalReduction = BitonalReduction.Burke;
                    break;
                case 5: //Stucki
                    if (_previousComboBoxIndex != 5)
                    {
                        LabelThreshold.Text = "PalWeight";
                        LabelThresholdMax.Text = "255";
                        HScrollBarThreshold.Minimum = 1;
                        LabelThresholdMin.Text = "1";
                        HScrollBarThreshold.Maximum = 255;
                        HScrollBarThreshold.Value = 15;
                        TextBoxThresholdVal.Text = HScrollBarThreshold.Value.ToString();
                        scroll1Panel.Visible = true;
                        scroll2Panel.Visible = false;
                        scroll3Panel.Visible = false;
                    }
                    _previousComboBoxIndex = 5;
                    _bitonalReduction = BitonalReduction.Stucki;
                    break;
                case 6: //Floyd Steinberg
                    if (_previousComboBoxIndex != 6)
                    {
                        LabelThreshold.Text = "PalWeight";
                        LabelThresholdMin.Text = "1";
                        LabelThresholdMax.Text = "255";
                        HScrollBarThreshold.Minimum = 1;
                        HScrollBarThreshold.Maximum = 255;
                        HScrollBarThreshold.Value = 15;
                        TextBoxThresholdVal.Text = HScrollBarThreshold.Value.ToString();
                        scroll1Panel.Visible = true;
                        scroll2Panel.Visible = false;
                        scroll3Panel.Visible = false;
                    }
                    _previousComboBoxIndex = 6;
                    _bitonalReduction = BitonalReduction.FloydSteinberg;
                    break;
                case 7: //Sauvola
                    if (_previousComboBoxIndex != 7)
                    {
                        LabelThreshold.Text = "Factor";
                        LabelThresholdMax.Text = "1";
                        LabelThresholdMin.Text = "0";
                        HScrollBarThreshold.Minimum = 0;
                        HScrollBarThreshold.Maximum = 100;
                        HScrollBarThreshold.Value = 35;
                        TextBoxThresholdVal.Text = Math.Round(((float)HScrollBarThreshold.Value / 100), 2).ToString();
                        scroll1Panel.Visible = true;
                        scroll2Panel.Visible = true;
                        scroll3Panel.Visible = true;
                    }
                    _previousComboBoxIndex = 7;
                    break;
                case 8: //Bradley
                    if (_previousComboBoxIndex != 8)
                    {
                        LabelThreshold.Text = "Threshold";
                        LabelThresholdMax.Text = "0";
                        LabelThresholdMin.Text = "254";
                        HScrollBarThreshold.Minimum = 0;
                        HScrollBarThreshold.Maximum = 254;
                        HScrollBarThreshold.Value = 38;
                        TextBoxThresholdVal.Text = HScrollBarThreshold.Value.ToString();
                        scroll1Panel.Visible = true;
                        scroll2Panel.Visible = false;
                        scroll3Panel.Visible = false;
                    }
                    _previousComboBoxIndex = 8;
                    break;
            }

            _lockEvents = false;

            if (_originImageId != 0)
            {
                DoThreshold();
            }
        }


        private void DoThreshold()
        {

            if (ComboBoxBinarizationMode.SelectedIndex > 0 && ComboBoxBinarizationMode.SelectedIndex <= 8)
            {
                if (_clonedImageId != 0)
                {
                    _oGdPictureImaging.ReleaseGdPictureImage(_clonedImageId);
                }
                if (_originImageId != 0)
                {
                    _clonedImageId = _oGdPictureImaging.CreateClonedGdPictureImage(_originImageId);
                    if (_clonedImageId == 0)
                    {
                        MessageBox.Show(_oGdPictureImaging.GetStat().ToString(), "Image could not be cloned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                switch (ComboBoxBinarizationMode.SelectedIndex)
                {
                    case 1:
                        _oGdPictureImaging.ConvertTo1Bpp(_clonedImageId, Convert.ToByte(HScrollBarThreshold.Value));
                        break;
                    case 2:
                        _oGdPictureImaging.ConvertTo1BppAT(_clonedImageId, HScrollBarThreshold.Value);
                        break;
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        if (_oGdPictureImaging.FxBlackNWhite(_clonedImageId, _bitonalReduction, HScrollBarThreshold.Value) == GdPictureStatus.OK)
                        {
                            _oGdPictureImaging.ConvertTo1BppFast(_clonedImageId);
                        }
                        break;
                    case 7:
                        _oGdPictureImaging.ConvertTo1BppSauvola(_clonedImageId, HScrollBarThreshold.Value / 100.0F, HScrollBarContrastDif.Value, HScrollBarSmoothKernel.Value);
                        break;
                    case 8:
                        _oGdPictureImaging.ConvertTo1BppBradley(_clonedImageId, (byte)HScrollBarThreshold.Value);
                        break;
                }

                if (_oGdPictureImaging.GetStat() == GdPictureStatus.OK)
                {
                    if (GdViewer1.DisplayFromGdPictureImage(_clonedImageId) != GdPictureStatus.OK)
                    {
                        MessageBox.Show(_oGdPictureImaging.GetStat().ToString(), "Image could not be displayed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(_oGdPictureImaging.GetStat().ToString(), "Image could not be binarized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void HScrollBarThreshold_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                if (ComboBoxBinarizationMode.SelectedIndex == 7)
                {
                    TextBoxThresholdVal.Text = Math.Round(((float)HScrollBarThreshold.Value / 100), 2).ToString();
                }
                else
                {
                    TextBoxThresholdVal.Text = e.NewValue.ToString();
                }

                if (!(_lockEvents))
                {
                    DoThreshold();
                }
            }
        }


        private void HScrollBarContrastDif_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                TextBoxContrastDifVal.Text = e.NewValue.ToString();
                if (!(_lockEvents))
                {
                    DoThreshold();
                }
            }
        }


        private void HScrollBarSmoothKernel_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                TextBoxSmoothKernelVal.Text = e.NewValue.ToString();
                if (!(_lockEvents))
                {
                    DoThreshold();
                }
            }
        }


        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            oSaveFileDialog.Filter = "TIFF Image|*.tif";
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = oSaveFileDialog.FileName;
                if (_oGdPictureImaging.SaveAsTIFF(_clonedImageId, oSaveFileDialog.FileName, TiffCompression.TiffCompressionCCITT4) == GdPictureStatus.OK)
                {
                    MessageBox.Show("Document successfully saved as Tiff in " + filePath);
                }
                else
                {
                    MessageBox.Show(_oGdPictureImaging.GetStat().ToString(), "Could not save document in " + filePath, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void CloseImage()
        {
            if (_originImageId != 0)
            {
                _oGdPictureImaging.ReleaseGdPictureImage(_originImageId);
                _originImageId = 0;
            }
            if (_clonedImageId != 0)
            {
                _oGdPictureImaging.ReleaseGdPictureImage(_clonedImageId);
                _clonedImageId = 0;
            }
            GdViewer1.CloseDocument();
            ComboBoxBinarizationMode.SelectedIndex = 0;
        }


        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            CloseImage();
        }


        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            CloseImage();
            Close();
        }
    }
}
