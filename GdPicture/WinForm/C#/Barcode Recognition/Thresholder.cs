using System;
using System.Windows.Forms;
using GdPicture14;


namespace barcode_recognition
{
    public partial class Thresholder
    {
        MainForm m_parentMainForm;

        //Image Identifier to do Threshold on
        private int m_ClonedImage;

        public Thresholder(MainForm FormReference)
        {
            InitializeComponent();
            m_parentMainForm = FormReference;
            cmbBinarizationMode.SelectedIndex = (System.Int32)Globals.binarizationMode;
            updateUI();
            doThreshold();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (m_ClonedImage != 0)
            {
                Globals.gdPictureImaging.ReleaseGdPictureImage(Globals.nativeImage);
                Globals.nativeImage = m_ClonedImage;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            if (m_ClonedImage != 0)
            {
                Globals.gdPictureImaging.ReleaseGdPictureImage(m_ClonedImage);
                m_parentMainForm.GdViewer1.DisplayFromGdPictureImage(Globals.nativeImage);
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThresholdingMode newBinarizationMode = (ThresholdingMode)cmbBinarizationMode.SelectedIndex;
            if (Globals.binarizationMode != newBinarizationMode)
            {
                Globals.binarizationMode = newBinarizationMode;
                updateUI();
                doThreshold();
            }
        }

        private void updateUI()
        {
            switch (Globals.binarizationMode)
            {
                case ThresholdingMode.Linear: //Linear
                                              //change threshold parameters
                    Label15.Text = "Threshold";
                    txtThresholdMax.Text = "254";
                    txtThresholdMin.Text = "1";
                    scrlThresoldParam.Minimum = 1;
                    scrlThresoldParam.Maximum = 254;
                    scrlThresoldParam.Value = 128;
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString();
                    TableLayoutPanel7.Visible = true;
                    TableLayoutPanel5.Visible = false;
                    TableLayoutPanel6.Visible = false;
                    break;

                case ThresholdingMode.Bradley: //Adaptive (Modified Bradley)
                                               //change threshold parameters
                    Label15.Text = "Threshold";
                    txtThresholdMax.Text = "255";
                    txtThresholdMin.Text = "1";
                    scrlThresoldParam.Minimum = 1;
                    scrlThresoldParam.Maximum = 255;
                    scrlThresoldParam.Value = Globals.DEFAULT_BRADLEY_THRESHOLD;
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString();
                    TableLayoutPanel7.Visible = true;
                    TableLayoutPanel5.Visible = false;
                    TableLayoutPanel6.Visible = false;
                    break;

                case ThresholdingMode.Otsu: //Adaptive (Modified Otsu)
                                            //change threshold parameters
                    Label15.Text = "Threshold";
                    txtThresholdMax.Text = "100";
                    scrlThresoldParam.Minimum = 0;
                    txtThresholdMin.Text = "0";
                    scrlThresoldParam.Maximum = 100;
                    scrlThresoldParam.Value = 50;
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString();
                    TableLayoutPanel7.Visible = true;
                    TableLayoutPanel5.Visible = false;
                    TableLayoutPanel6.Visible = false;
                    break;

                case ThresholdingMode.Sauvola: //Sauvola
                                               //change threshold parameters
                    Label15.Text = "Factor";
                    txtThresholdMax.Text = "1";
                    txtThresholdMin.Text = "0";
                    scrlThresoldParam.Minimum = 0;
                    scrlThresoldParam.Maximum = 100;
                    scrlThresoldParam.Value = 35;
                    txtThreshVal.Text = Math.Round((double)scrlThresoldParam.Value / 100, 2).ToString();
                    TableLayoutPanel7.Visible = true;
                    TableLayoutPanel5.Visible = true;
                    TableLayoutPanel6.Visible = true;
                    break;

                case ThresholdingMode.Wan: //Wan
                    Label15.Text = "Threshold";
                    txtThresholdMax.Text = "254";
                    txtThresholdMin.Text = "1";
                    scrlThresoldParam.Minimum = 1;
                    scrlThresoldParam.Maximum = 254;
                    scrlThresoldParam.Value = 51;
                    txtThreshVal.Text = scrlThresoldParam.Value.ToString();
                    TableLayoutPanel7.Visible = true;
                    TableLayoutPanel5.Visible = false;
                    TableLayoutPanel6.Visible = false;
                    break;
            }
        }

        private void scrlThresholdParam_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                if (cmbBinarizationMode.SelectedIndex == 2)
                {
                    txtThreshVal.Text = Math.Round((double)scrlThresoldParam.Value / 100, 2).ToString();
                }
                else
                {
                    txtThreshVal.Text = e.NewValue.ToString();
                }

                Globals.thresholdValue = e.NewValue;
                doThreshold();
            }
        }

        private void scrlKernelParam_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                txtKernelVal.Text = e.NewValue.ToString();
                Globals.smoothKernel = e.NewValue;
                doThreshold();
            }
        }

        private void scrlContrastParam_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                txtMinDifVal.Text = e.NewValue.ToString();
                Globals.contrastMinDif = e.NewValue;
                doThreshold();
            }
        }

        private void doThreshold()
        {
            if (m_ClonedImage != 0)
            {
                Globals.gdPictureImaging.ReleaseGdPictureImage(m_ClonedImage);
            }
            if (Globals.nativeImage != 0)
            {
                m_ClonedImage = Globals.gdPictureImaging.CreateClonedGdPictureImage(Globals.nativeImage);
                if (m_ClonedImage == 0)
                {
                    MessageBox.Show("Error cloning input image: " + Globals.gdPictureImaging.GetStat().ToString());
                    return;
                }
            }

            switch (Globals.binarizationMode)
            {
                case ThresholdingMode.Linear: //Linear
                    Globals.gdPictureImaging.ConvertTo1Bpp(m_ClonedImage, (byte)Globals.thresholdValue);
                    break;
                case ThresholdingMode.Bradley: //Adaptive (Modified Bradley)
                    Globals.gdPictureImaging.ConvertTo1BppBradley(m_ClonedImage, (byte)Globals.thresholdValue);
                    break;
                case ThresholdingMode.Otsu: //Adaptive (Modified Otsu)
                    Globals.gdPictureImaging.ConvertTo1BppAT(m_ClonedImage, Globals.thresholdValue);
                    break;
                case ThresholdingMode.Sauvola: //Sauvola
                    Globals.gdPictureImaging.ConvertTo1BppSauvola(m_ClonedImage, Globals.thresholdValue / 100.0F, Globals.contrastMinDif, Globals.smoothKernel);
                    break;
                case ThresholdingMode.Wan: //Wan
                    Globals.gdPictureImaging.ConvertTo1BppWAN(m_ClonedImage, (byte)Globals.thresholdValue);
                    break;

            }

            if (Globals.gdPictureImaging.GetStat() == GdPictureStatus.OK)
            {
                if (m_parentMainForm.GdViewer1.DisplayFromGdPictureImage(m_ClonedImage) != GdPictureStatus.OK)
                {
                    MessageBox.Show("The Image cannot be displayed. Status: " + m_parentMainForm.GdViewer1.GetStat().ToString());
                }
            }
            else
            {
                MessageBox.Show("Can\'t binarize image. Error: " + Globals.gdPictureImaging.GetStat().ToString());
            }
        }
    }
}
