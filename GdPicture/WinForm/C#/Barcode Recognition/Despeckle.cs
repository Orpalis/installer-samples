using System.Windows.Forms;

using GdPicture14;
using System;

namespace barcode_recognition
{
    public partial class Despeckle : Form
    {
        GdViewer m_GdViewer;

        //Image Identifier to do Despeckle on
        public int m_ClonedImage;

        public Despeckle(GdViewer gdViewer)
        {
            InitializeComponent();
            m_GdViewer = gdViewer;
            foreach (var item in Enum.GetValues(typeof(DespeckleType)))
            {
                cmbDespeckleMode.Items.Add(item);
            }
            cmbDespeckleMode.SelectedItem = Globals.despeckleType;
            scrlStrengthParam.Value = Globals.despeckleStrength;
            txtStrengthVal.Text = Globals.despeckleStrength.ToString();
            DoDespeckle();
        }

        private void DoDespeckle()
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

            Globals.gdPictureImaging.FxBitonalDespeckleAdvanced(m_ClonedImage, (DespeckleType)Enum.Parse(typeof(DespeckleType), cmbDespeckleMode.SelectedItem.ToString()), Globals.despeckleStrength);

            if (Globals.gdPictureImaging.GetStat() == GdPictureStatus.OK)
            {
                if (m_GdViewer.DisplayFromGdPictureImage(m_ClonedImage) != GdPictureStatus.OK)
                {
                    MessageBox.Show("The Image cannot be displayed. Status: " + m_GdViewer.GetStat().ToString());
                }
            }
            else
            {
                MessageBox.Show("Can\'t binarize image. Error: " + Globals.gdPictureImaging.GetStat().ToString());
            }
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
                m_GdViewer.DisplayFromGdPictureImage(Globals.nativeImage);
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbDespeckleMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.despeckleType = (DespeckleType)Enum.Parse(typeof(DespeckleType), cmbDespeckleMode.SelectedItem.ToString());
            DoDespeckle();
        }

        private void scrlStrengthParam_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                txtStrengthVal.Text = e.NewValue.ToString();
                Globals.despeckleStrength = e.NewValue;
                DoDespeckle();
            }
        }
    }
}
