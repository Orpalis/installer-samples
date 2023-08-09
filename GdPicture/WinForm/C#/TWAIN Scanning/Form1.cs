using GdPicture14;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace twain_sample
{
    internal partial class Form1 : System.Windows.Forms.Form
    {

        public GdPictureImaging m_GdPictureImaging = new GdPictureImaging();

        private void Form1_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            //Check for 64-bit mode app running
            if (IntPtr.Size == 8)
            {
                MessageBox.Show("Warning: The application is running in 64-bit mode. To be able to handle 32-bit TWAIN drivers you will have to target it to 32-bit mode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXX"); //Please, replace XXX by a valid demo or commercial license key.

            m_GdPictureImaging.TwainImagePreview += TwainImagePreview;

            // You can set the language of the Twain UI here by selecting the language and the country you prefer.
            //oGdPictureImaging.TwainSetApplicationInfo(14, 0, TwainLanguage.TWLG_GER, TwainCountry.TWCY_GERMANY, oLicenseManager.GetVersion().ToString(), "Orpalis", "GdPicture", "GdPicture.NET");
        }


        private void TwainImagePreview(int ImageID, int Reserved)
        {
            ApplyImageFilters(ImageID);

            if (chkPreview.CheckState == CheckState.Checked)
            {
                GdViewer1.DisplayFromGdPictureImage(ImageID);
                GdViewer1.CloseDocument(true);
                Application.DoEvents();
            }
        }
        

        private void Command1_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            // Here we will scan in a 1bpp ccitt4 & 200 DPI from adf to multipage tif file
            int nImageCount = 0;
            int ImageID = 0;
            int MultiPageID = 0;

            if (m_GdPictureImaging.TwainOpenDefaultSource(this.Handle))
            {
                nImageCount = 0;

                InitScanConfig();

                m_GdPictureImaging.TwainSetAutoFeed(true); // Set AutoFeed Enabled
                m_GdPictureImaging.TwainSetAutoScan(true); // To  achieve the maximum scanning rate

                m_GdPictureImaging.TwainSetResolution(200);
                m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_BW); // Black & White
                m_GdPictureImaging.TwainSetBitDepth(1); //  1 bpp
                do
                {
                    ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(this.Handle);
                    if (ImageID != 0)
                    {
                        nImageCount = nImageCount + 1;

                        if (this.chkRemoveBlankPages.Checked)
                        {
                            if (m_GdPictureImaging.IsBlank(ImageID, 99, true))
                            {
                                m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                                ImageID = 0;
                            }
                        }

                        if (ImageID != 0)
                        {
                            if (nImageCount == 1)
                            {
                                MultiPageID = ImageID;
                                m_GdPictureImaging.TiffSaveAsMultiPageFile(MultiPageID, @"multipage.tif", TiffCompression.TiffCompressionCCITT4);
                            }
                            else
                            {
                                m_GdPictureImaging.TiffAddToMultiPageFile(MultiPageID, ImageID);
                                m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                            }
                        }

                    }
                }
                while (m_GdPictureImaging.TwainGetState() > TwainStatus.TWAIN_SOURCE_ENABLED);

                m_GdPictureImaging.TiffCloseMultiPageFile(MultiPageID);
                m_GdPictureImaging.TwainCloseSource();
                MessageBox.Show("Done !");
            }
            else
            {
                MessageBox.Show("can't open default source, twain state is: " + m_GdPictureImaging.TwainGetState().ToString());
            }

        }



        private void Command10_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            m_GdPictureImaging.TwainCloseSourceManager(this.Handle);
        }


        private void Command11_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            m_GdPictureImaging.TwainUnloadSourceManager(this.Handle);
        }


        private void Command12_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            // Here we will scan in a 1bpp  form adf to multiple page pdf file
            int ImageID = 0;
            GdPicturePDF oGdPicturePDF = new GdPicturePDF();

            if (m_GdPictureImaging.TwainOpenDefaultSource(this.Handle))
            {

                InitScanConfig();

                m_GdPictureImaging.TwainSetAutoFeed(true); // Set AutoFeed Enabled
                m_GdPictureImaging.TwainSetAutoScan(true); // To  achieve the maximum scanning rate

                m_GdPictureImaging.TwainSetResolution(200);
                m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_BW); // Black & White
                m_GdPictureImaging.TwainSetBitDepth(1); //  1 bpp

                oGdPicturePDF.NewPDF();

                do
                {
                    ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(this.Handle);
                    if (ImageID != 0)
                    {
                        if (this.chkRemoveBlankPages.Checked)
                        {
                            if (m_GdPictureImaging.IsBlank(ImageID, 99, true))
                            {
                                m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                                ImageID = 0;
                            }
                        }

                        if (ImageID != 0)
                        {
                            oGdPicturePDF.AddImageFromGdPictureImage(ImageID, false, true);
                            m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                        }

                    }
                }
                while (m_GdPictureImaging.TwainGetState() > TwainStatus.TWAIN_SOURCE_ENABLED);
                oGdPicturePDF.SaveToFile("output.pdf");
                oGdPicturePDF.CloseDocument();

                m_GdPictureImaging.TwainCloseSource();
                MessageBox.Show("Done !");
            }
            else
            {
                MessageBox.Show("can't open default source, twain state is: " + m_GdPictureImaging.TwainGetState().ToString());
            }

        }


        private void Command2_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            // Here we will scan in a 24bpp  & 300 DPI from ADF into separate jpeg files
            int nImageCount = 0;
            int ImageID = 0;


            if (m_GdPictureImaging.TwainOpenDefaultSource(this.Handle))
            {
                nImageCount = 0;

                InitScanConfig();

                m_GdPictureImaging.TwainSetAutoFeed(true); // Set AutoFeed Enabled
                m_GdPictureImaging.TwainSetAutoScan(true); // To  achieve the maximum scanning rate

                m_GdPictureImaging.TwainSetResolution(300);
                m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_RGB); // RGB
                m_GdPictureImaging.TwainSetBitDepth(24); //  24 bpp

                do
                {
                    ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(this.Handle);
                    if (ImageID != 0)
                    {
                        if (this.chkRemoveBlankPages.Checked)
                        {
                            if (m_GdPictureImaging.IsBlank(ImageID, 99, true))
                            {
                                m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                                ImageID = 0;
                            }
                        }

                        if (ImageID != 0)
                        {
                            nImageCount = nImageCount + 1;
                            m_GdPictureImaging.SaveAsJPEG(ImageID, @"image" + nImageCount.ToString().Trim() + ".jpg", 75);
                            m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                        }

                    }

                }
                while (m_GdPictureImaging.TwainGetState() > TwainStatus.TWAIN_SOURCE_ENABLED);

                m_GdPictureImaging.TwainCloseSource();
                MessageBox.Show("Done !");
            }
            else
            {
                MessageBox.Show("can't open default source, twain state is: " + m_GdPictureImaging.TwainGetState().ToString());
            }

        }



        private void Command3_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            // Here we will scan in a 24bpp & 300 DPI PDF file
            int ImageID = 0;

            if (m_GdPictureImaging.TwainOpenDefaultSource(this.Handle))
            {

                InitScanConfig();

                m_GdPictureImaging.TwainSetResolution(300);
                m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_RGB); // RGB
                m_GdPictureImaging.TwainSetBitDepth(24); //  24 bpp

                ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(this.Handle);
                if (ImageID != 0)
                {
                    if (this.chkRemoveBlankPages.Checked)
                    {
                        if (m_GdPictureImaging.IsBlank(ImageID, 99, true))
                        {
                            m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                            ImageID = 0;
                        }
                    }

                    if (ImageID != 0)
                    {
                        m_GdPictureImaging.SaveAsPDF(ImageID, @"acquire.pdf", true, "", "", "", "", "");
                        m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                    }

                }

                m_GdPictureImaging.TwainCloseSource();
                MessageBox.Show("Done !");
            }
            else
            {
                MessageBox.Show("can't open default source, twain state is: " + m_GdPictureImaging.TwainGetState().ToString());
            }

        }



        private void Command4_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            // Here we will scan in a 24bpp  & 300 DPI  jpeg file
            int ImageID = 0;

            if (m_GdPictureImaging.TwainOpenDefaultSource(this.Handle))
            {

                InitScanConfig();

                m_GdPictureImaging.TwainSetResolution(300);
                m_GdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_RGB); // RGB
                m_GdPictureImaging.TwainSetBitDepth(24); //  24 bpp
                m_GdPictureImaging.TwainSetAutoFeed(false); //we only want one page.

                ImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(this.Handle);
                if (ImageID != 0)
                {
                    if (this.chkRemoveBlankPages.Checked)
                    {
                        if (m_GdPictureImaging.IsBlank(ImageID, 99, true))
                        {
                            m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                            ImageID = 0;
                        }
                    }

                    if (ImageID != 0)
                    {
                        m_GdPictureImaging.SaveAsJPEG(ImageID, @"acquire.jpg", 90);
                        m_GdPictureImaging.ReleaseGdPictureImage(ImageID);
                    }

                }

                m_GdPictureImaging.TwainCloseSource();
                MessageBox.Show("Done !");
            }
            else
            {
                MessageBox.Show("can't open default source, twain state is: " + m_GdPictureImaging.TwainGetState().ToString());
            }
        }


        private void Command5_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            m_GdPictureImaging.TwainSelectSource(this.Handle);
        }


        private void Command6_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (m_GdPictureImaging.TwainGetState() < TwainStatus.TWAIN_SOURCE_OPEN)
            {
                MessageBox.Show("You need to open a source first !");
            }
            else
            {
                m_GdPictureImaging.TwainShowSetupDialogSource(this.Handle);
            }
        }


        private void Command7_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            MessageBox.Show(m_GdPictureImaging.TwainGetState().ToString());
        }


        private void Command8_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            if (!(m_GdPictureImaging.TwainOpenDefaultSource(this.Handle)))
            {
                MessageBox.Show("Can't open default source !");
            }
        }


        private void Command9_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            m_GdPictureImaging.TwainCloseSource();
        }



        private void InitScanConfig()
        {
            m_GdPictureImaging.TwainSetHideUI(chkHideUI.CheckState == CheckState.Checked);
            m_GdPictureImaging.TwainSetIndicators(chkIndicator.CheckState == CheckState.Checked);
            if (chkAutoBrightness.CheckState == CheckState.Checked)
            {
                m_GdPictureImaging.TwainSetAutoBrightness(true);
            }
            else
            {
                m_GdPictureImaging.TwainSetAutoBrightness(false);
                m_GdPictureImaging.TwainSetBrightness(HBrightness.Value);
            }
            m_GdPictureImaging.TwainSetContrast(HContrast.Value);
            m_GdPictureImaging.TwainEnableDuplex(chkDuplex.CheckState == CheckState.Checked);
        }



        private void ApplyImageFilters(int ImageID) 
        {
            if (this.ChkNeg.CheckState == CheckState.Checked)
            {
                m_GdPictureImaging.FxNegative(ImageID);
            }

            if (this.chkRemoveDots.CheckState == CheckState.Checked & m_GdPictureImaging.GetBitDepth(ImageID) == 1)
            {
                m_GdPictureImaging.FxBitonalRemoveIsolatedDots2x2(ImageID);
            }

            if (this.chkRotate90.CheckState == CheckState.Checked & this.chkRotate180.CheckState == CheckState.Checked)
            {
                m_GdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate270FlipNone);
            }
            else
            {
                if (this.chkRotate90.CheckState == CheckState.Checked)
                {
                    m_GdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate90FlipNone);
                }
                if (this.chkRotate180.CheckState == CheckState.Checked)
                {
                    m_GdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate180FlipNone);
                }
            }

            if (this.chkAutoDesk.CheckState == CheckState.Checked)
            {
                m_GdPictureImaging.AutoDeskew(ImageID, 12, Color.White, 0.25F, false);
            }

            if (this.ChkAutoCrop.CheckState == CheckState.Checked)
            {
                m_GdPictureImaging.CropBlackBordersEx(ImageID);
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_GdPictureImaging.TwainUnloadSourceManager(this.Handle);
        }

    }

}
