using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GdPicture14;

namespace CSharp_PDFSigner
{
    public partial class frmNewFunctions : Form
    {
        string m_caption = "PDF Signer";
        string m_PdfFileName ="";
        GdPicturePDF oGdPicturePdf = new GdPicturePDF();
        PdfSignatureMode m_SignatureMode = PdfSignatureMode.PdfSignatureModeAdobePPKMS;
        PdfSignatureCertificationLevel m_CertLevel = PdfSignatureCertificationLevel.NoChanges;
        PdfSignatureHash m_Hash = PdfSignatureHash.SHA256;
        TextAlignment m_AlignHorz = TextAlignment.TextAlignmentNear;
        TextAlignment m_AlignVert = TextAlignment.TextAlignmentCenter;

        public frmNewFunctions(string FileName)
        {
            InitializeComponent();
            m_PdfFileName = FileName;
            oGdPicturePdf.LoadFromFile(m_PdfFileName, true);
            Viewer1.DisplayFromFile(m_PdfFileName);
        }

        private void frmNewFunctions_Load(object sender, EventArgs e)
        {
            txtPFXFileName.Text = Properties.Settings.Default.PFXFileName;
            txtPFXPassword.Text = Properties.Settings.Default.PFXPassword;
            txtCertSerialNumber.Text = Properties.Settings.Default.SerialNumber;
            txtProviderName.Text = Properties.Settings.Default.ProviderName;
            txtContainerKeyName.Text = Properties.Settings.Default.ContainerKeyName;
            txtPinCode.Text = Properties.Settings.Default.PinCode;

            chkVisibleSignature.Checked = Properties.Settings.Default.VisibleSignature;

            txtLeft.Text = Properties.Settings.Default.SigLeft.ToString();
            txtBottom.Text = Properties.Settings.Default.SigBottom.ToString();
            txtWidth.Text = Properties.Settings.Default.SigWidth.ToString();
            txtHeight.Text = Properties.Settings.Default.SigHeight.ToString();

            txtSignerName.Text = Properties.Settings.Default.SignerName;
            txtSignerReason.Text = Properties.Settings.Default.SignerReason;
            txtSignerLocation.Text = Properties.Settings.Default.SignerLocation;
            txtSignerContact.Text = Properties.Settings.Default.SignerContactInfo;

            txtTSServer.Text = Properties.Settings.Default.TSServer;
            txtTSUser.Text = Properties.Settings.Default.TSUser;
            txtTSPassword.Text = Properties.Settings.Default.TSPassword;

            txtStamp.Text = Properties.Settings.Default.ImageStampFileName;

            txtSignerText.Text = Properties.Settings.Default.SignerText;
            txtFontName.Text = Properties.Settings.Default.TextFontName;
            txtFontSize.Text = Properties.Settings.Default.TextFontSize.ToString();
            pctFontColor.BackColor = Properties.Settings.Default.TextFontColor;
            chkFontBold.Checked = Properties.Settings.Default.TextFontBold;
            chkFontItalic.Checked = Properties.Settings.Default.TextFontItalic;
            m_AlignHorz = Properties.Settings.Default.TextAmignHorz;
            switch (m_AlignHorz)
            {
                case TextAlignment.TextAlignmentCenter:
                    optAlignHorzCenter.Checked = true;
                    break;
                case TextAlignment.TextAlignmentFar:
                    optAlignHorzFar.Checked = true;
                    break;
                default:
                    //case TextAlignment.TextAlignmentNear:
                    optAlignHorzNear.Checked = true;
                    break;
            }
            m_AlignVert = Properties.Settings.Default.TextAmignVert;
            switch (m_AlignVert)
            {
                case TextAlignment.TextAlignmentNear:
                    optAlignVertNear.Checked = true;
                    break;
                case TextAlignment.TextAlignmentFar:
                    optAlignVertFar.Checked = true;
                    break;
                default:
                    //case TextAlignment.TextAlignmentCenter:
                    optAlignVertCenter.Checked = true;
                    break;
            }

            chkShowText.Checked = Properties.Settings.Default.ShowText;
            chkShowValidationMark.Checked = Properties.Settings.Default.ShowValidationMark;
            chkLinearize.Checked = Properties.Settings.Default.Linearize;

            m_CertLevel = Properties.Settings.Default.SigCertificationLevel;
            switch (m_CertLevel)
            {
                case PdfSignatureCertificationLevel.NoChanges:
                    optLvl2.Checked = true;
                    break;
                case PdfSignatureCertificationLevel.FormFilling:
                    optLvl3.Checked = true;
                    break;
                case PdfSignatureCertificationLevel.FormFillingAndAnnotations:
                    optLvl4.Checked = true;
                    break;
                default:
                    //case PdfSignatureCertificationLevel.NotCertified:
                    optLvl1.Checked = true;
                    break;
            }
            m_SignatureMode = Properties.Settings.Default.SignatureMode;
            switch (m_SignatureMode)
            {
                case PdfSignatureMode.PdfSignatureModeAdobePPKMS:
                    optSigType1.Checked = true;
                    break;
                case PdfSignatureMode.PdfSignatureModeAdobePPKLite:
                    optSigType2.Checked = true;
                    break;
                default:
                    //case PdfSignatureMode.SignatureModeAdobeCADES:
                    optSigType3.Checked = true;
                    break;
            }
            m_Hash = Properties.Settings.Default.SignatureHash;
            switch (m_Hash)
            {
                case PdfSignatureHash.SHA512:
                    optSHA512.Checked = true;
                    break;
                case PdfSignatureHash.SHA224:
                    optSHA224.Checked = true;
                    break;
                case PdfSignatureHash.SHA384:
                    optSHA384.Checked = true;
                    break;
                default:
                    //case PdfSignatureHash.SHA256:
                    optSHA256.Checked = true;
                    break;
            }
            ShowVisibleSinature();
            ShowText();
        }

        private void frmNewFunctions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PFXFileName = txtPFXFileName.Text;
            Properties.Settings.Default.PFXPassword = txtPFXPassword.Text;
            Properties.Settings.Default.SerialNumber = txtCertSerialNumber.Text;
            Properties.Settings.Default.ProviderName = txtProviderName.Text;
            Properties.Settings.Default.ContainerKeyName = txtContainerKeyName.Text;
            Properties.Settings.Default.PinCode = txtPinCode.Text;

            Properties.Settings.Default.TSServer = txtTSServer.Text;
            Properties.Settings.Default.TSUser = txtTSUser.Text;
            Properties.Settings.Default.TSPassword = txtTSPassword.Text;

            Properties.Settings.Default.VisibleSignature = chkVisibleSignature.Checked;
            Properties.Settings.Default.SignerName = txtSignerName.Text;
            Properties.Settings.Default.SignerReason = txtSignerReason.Text;
            Properties.Settings.Default.SignerLocation = txtSignerLocation.Text;
            Properties.Settings.Default.SignerContactInfo = txtSignerContact.Text;

            Properties.Settings.Default.ImageStampFileName = txtStamp.Text;

            Properties.Settings.Default.SignerText = txtSignerText.Text;
            Properties.Settings.Default.TextFontName = txtFontName.Text;
            Properties.Settings.Default.TextFontSize = float.Parse(txtFontSize.Text);
            Properties.Settings.Default.TextFontColor = lblFontColor.ForeColor;
            Properties.Settings.Default.TextFontBold = chkFontBold.Checked;
            Properties.Settings.Default.TextFontItalic = chkFontItalic.Checked;
            Properties.Settings.Default.TextAmignHorz = m_AlignHorz;
            Properties.Settings.Default.TextAmignVert = m_AlignVert;

            Properties.Settings.Default.ShowText = chkShowText.Checked;
            Properties.Settings.Default.ShowValidationMark = chkShowValidationMark.Checked;
            Properties.Settings.Default.Linearize = chkLinearize.Checked;
            Properties.Settings.Default.SigLeft = float.Parse(txtLeft.Text);
            Properties.Settings.Default.SigBottom = float.Parse(txtBottom.Text);
            Properties.Settings.Default.SigWidth = float.Parse(txtWidth.Text);
            Properties.Settings.Default.SigHeight = float.Parse(txtHeight.Text);

            Properties.Settings.Default.SigCertificationLevel = m_CertLevel;
            Properties.Settings.Default.SignatureMode = m_SignatureMode;
            Properties.Settings.Default.SignatureHash = m_Hash;

            Properties.Settings.Default.Save();
        }

        private void chkVisibleSignature_CheckedChanged(object sender, EventArgs e)
        {
            ShowVisibleSinature();
        }

        private void chkShowText_CheckedChanged(object sender, EventArgs e)
        {
            ShowText();
        }

        private void optAlignHorzNear_CheckedChanged(object sender, EventArgs e)
        {
            m_AlignHorz = TextAlignment.TextAlignmentNear;
        }

        private void optAlignHorzCenter_CheckedChanged(object sender, EventArgs e)
        {
            m_AlignHorz = TextAlignment.TextAlignmentCenter;
        }

        private void optAlignHorzFar_CheckedChanged(object sender, EventArgs e)
        {
            m_AlignHorz = TextAlignment.TextAlignmentFar;
        }

        private void optAlignVertNear_CheckedChanged(object sender, EventArgs e)
        {
            m_AlignVert = TextAlignment.TextAlignmentNear;
        }

        private void optAlignVertCenter_CheckedChanged(object sender, EventArgs e)
        {
            m_AlignVert = TextAlignment.TextAlignmentCenter;
        }

        private void optAlignVertFar_CheckedChanged(object sender, EventArgs e)
        {
            m_AlignVert = TextAlignment.TextAlignmentFar;
        }

        private void cmdParcPfx_Click(object sender, EventArgs e)
        {
            FileDialog FD = new OpenFileDialog();
            FD.Filter = "Pfx or P12 files|*.pfx;*.p12|All files|*.*";
            if (FD.ShowDialog() == DialogResult.OK)
                txtPFXFileName.Text = FD.FileName;
        }

        private void cmdParcStamp_Click(object sender, EventArgs e)
        {
            FileDialog FD = new OpenFileDialog();
            FD.Filter = "Image files|*.bmp;*.jpg;*.tif|All files|*.*";
            if (FD.ShowDialog() == DialogResult.OK)
                txtStamp.Text = FD.FileName;
        }

        private void cmdParcFont_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            System.Drawing.FontStyle fntStyle = new System.Drawing.FontStyle();
            fntStyle = System.Drawing.FontStyle.Regular;
            if ((chkFontBold.Checked) && (chkFontItalic.Checked))
                fntStyle = System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic;
            else if (chkFontBold.Checked)
                fntStyle = System.Drawing.FontStyle.Bold;
            else
                fntStyle = System.Drawing.FontStyle.Italic;
            FD.Font = new Font(txtFontName.Text, float.Parse(txtFontSize.Text), fntStyle);
            FD.Color = lblFontColor.ForeColor;
            FD.ShowColor = true;
            if (FD.ShowDialog() == DialogResult.OK)
            {
                txtFontName.Text = FD.Font.Name;
                txtFontSize.Text = FD.Font.Size.ToString();
                pctFontColor.BackColor = FD.Color;
                chkFontBold.Checked = FD.Font.Bold;
                chkFontItalic.Checked = FD.Font.Italic;
            }
        }

        private void optSigType1_CheckedChanged(object sender, EventArgs e)
        {
            m_SignatureMode = PdfSignatureMode.PdfSignatureModeAdobePPKMS;
        }

        private void optSigType2_CheckedChanged(object sender, EventArgs e)
        {
            m_SignatureMode = PdfSignatureMode.PdfSignatureModeAdobePPKLite;
        }

        private void optSigType3_CheckedChanged(object sender, EventArgs e)
        {
            m_SignatureMode = PdfSignatureMode.PdfSignatureModeAdobeCADES;
        }

        private void optLvl1_CheckedChanged(object sender, EventArgs e)
        {
            m_CertLevel = PdfSignatureCertificationLevel.NotCertified;
        }

        private void optLvl2_CheckedChanged(object sender, EventArgs e)
        {
            m_CertLevel = PdfSignatureCertificationLevel.NoChanges;
        }

        private void optLvl3_CheckedChanged(object sender, EventArgs e)
        {
            m_CertLevel = PdfSignatureCertificationLevel.FormFilling;
        }

        private void optLvl4_CheckedChanged(object sender, EventArgs e)
        {
            m_CertLevel = PdfSignatureCertificationLevel.FormFillingAndAnnotations;
        }

        private void optSHA256_CheckedChanged(object sender, EventArgs e)
        {
            m_Hash = PdfSignatureHash.SHA256;
        }

        private void optSHA384_CheckedChanged(object sender, EventArgs e)
        {
            m_Hash = PdfSignatureHash.SHA384;
        }

        private void optSHA512_CheckedChanged(object sender, EventArgs e)
        {
            m_Hash = PdfSignatureHash.SHA512;
        }
        private void optSHA224_CheckedChanged(object sender, EventArgs e)
        {
            m_Hash = PdfSignatureHash.SHA224;
        }

        private void ShowVisibleSinature()
        {
            if (chkVisibleSignature.Checked)
            {
                grpValidationMark.Visible = true;
            }
            else
            {
                grpValidationMark.Visible = false;
            }
        }

        private void ShowText()
        {
            if (chkShowText.Checked)
            {
                grpShowText.Visible = true;
            }
            else
            {
                grpShowText.Visible = false;
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            GdPictureStatus status = GdPictureStatus.OK;

            oGdPicturePdf.SetOrigin(PdfOrigin.PdfOriginTopLeft);
            oGdPicturePdf.SetMeasurementUnit(PdfMeasurementUnit.PdfMeasurementUnitPoint);

            // Step 1 : Set up the certificate, your digital ID file.
            // This is the mandatory step, it is recommended as the first step.
            switch (tabCerticate.SelectedIndex)
            {
                case 0:
                    status = oGdPicturePdf.SetSignatureCertificateFromP12(txtPFXFileName.Text, txtPFXPassword.Text);
                    break;
                case 1:
                    status = oGdPicturePdf.SetSignatureCertificateFromStore(txtCertSerialNumber.Text);
                    break;
                case 2:
                    status = oGdPicturePdf.SetSignatureCertificateFromSmartCard(txtProviderName.Text, txtCertSerialNumber.Text, txtPinCode.Text);
                    break;
            }
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("The error occurs while setting up the certificate.\nStatus: " + status.ToString(), m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Step 2 : Set the signature information. At least one parameter must be set, others may stay empty.
            status = oGdPicturePdf.SetSignatureInfo(txtSignerName.Text, txtSignerReason.Text, txtSignerLocation.Text, txtSignerContact.Text);
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("The error occurs while setting up the signature information.\nStatus: " + status.ToString(), m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Optional steps.

            // Step 3a : Set the signature's location on the current page. If this step is ommited, the signature will be invisble.            if (chkVisibleSignature.Checked)
            status = oGdPicturePdf.SetSignaturePos(float.Parse(txtLeft.Text), float.Parse(txtBottom.Text), float.Parse(txtWidth.Text), float.Parse(txtHeight.Text));
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("The error occurs while setting up the signature position.\nStatus: " + status.ToString(), m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            // Step 3b : Set the icon that represents the validity of the signature.
            status = oGdPicturePdf.SetSignatureValidationMark(chkShowValidationMark.Checked);
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("The error occurs while setting up the validation mark.\nStatus: " + status.ToString(), m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            // Step 3c : Set the image to be displayed within the signature's bounding box. The image will not be drawn if the signature is invisible.
            if (txtStamp.Text != "")
            {
                Bitmap btmap = new Bitmap(txtStamp.Text);
                if (btmap != null)
                {
                    string ImageResName = oGdPicturePdf.AddImageFromBitmap(btmap, false, false);
                    status = oGdPicturePdf.GetStat();
                    if (status != GdPictureStatus.OK)
                    {
                        MessageBox.Show("The error occurs while creating the image from the bitmap.\nStatus: " + status.ToString(), m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        status = oGdPicturePdf.SetSignatureStampImage(ImageResName);
                        if (status != GdPictureStatus.OK)
                        {
                            MessageBox.Show("The error occurs while setting up the image stamp.\nStatus: " + status.ToString(), m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The error occurs while creating a bitmap from the image file.", m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            // Step 3d : Set the text to be displayed within the signature's bounding box. The text will not be drawn if the signature is invisible.
            if (chkShowText.Checked)
            {
                string FontResName = "";
                if (txtFontName.Text != "")
                {
                    FontResName = oGdPicturePdf.AddFontFromFileU("", txtFontName.Text, FontCharSet.ANSI_CHARSET, chkFontBold.Checked, chkFontItalic.Checked);
                    status = oGdPicturePdf.GetStat();
                    if (status != GdPictureStatus.OK)
                    {
                        MessageBox.Show("The error occurs while loading the font file.\nStatus: " + status.ToString() +
                            "\nThe standard font is used instead.", m_caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                float FontSize = float.Parse(txtFontSize.Text);
                status = oGdPicturePdf.SetSignatureText(txtSignerText.Text, FontResName, FontSize, pctFontColor.BackColor, m_AlignHorz, m_AlignVert, true);
                if (status != GdPictureStatus.OK)
                {
                    MessageBox.Show("The error occurs while setting the text.\nStatus: " + status.ToString(), m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            // Step 4a : Set the signature certification level.
            status = oGdPicturePdf.SetSignatureCertificationLevel(m_CertLevel);
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("The error occurs while setting the certification level.\nStatus: " + status.ToString(), m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Step 4b : Set the hash algorithm.
            status = oGdPicturePdf.SetSignatureHash(m_Hash);
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("The error occurs while setting the hash.\nStatus: " + status.ToString() +
                    "\nThe default setting is used instead.", m_caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Step 4c : Set the timestamp information.
            status = oGdPicturePdf.SetSignatureTimestampInfo(txtTSServer.Text, txtTSUser.Text, txtTSPassword.Text);
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("The error occurs while setting the timestamp.\nStatus: " + status.ToString(), m_caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Step 5 : Apply the signature - sign. This is the mandatory step, it must be the last one. All other optional steps may be done in any order.
            string OutputFileName = m_PdfFileName.Replace(".pdf", "_signed.pdf");
            status = oGdPicturePdf.ApplySignature(OutputFileName, m_SignatureMode, chkLinearize.Checked);
            MessageBox.Show("The signature is applied with the status: " + status.ToString() +
                "\nPlease preview the signed document beside.", m_caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Viewer1.DisplayFromFile(OutputFileName);
        }
    }
}
