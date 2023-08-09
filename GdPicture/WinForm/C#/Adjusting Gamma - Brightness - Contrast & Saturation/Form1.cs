using GdPicture14;
using System;
using System.Windows.Forms;

namespace adjust
{
    internal partial class Form1 : Form
    {
        private int _originalImageId;

        private readonly GdPictureImaging _oGdPictureImaging = new GdPictureImaging();


        private void Form1_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
        }


        private void StripMenuItemOpenTool_Click(System.Object sender, System.EventArgs e)
        {
            ReleaseGdPictureImage();
            ResetBars();

            _originalImageId = _oGdPictureImaging.CreateGdPictureImageFromFile(""); //Providing an empty string prompts the user to select a file.
            if (_originalImageId != 0)
            {
                GdPictureStatus gdPictureStatus;
                if ((gdPictureStatus = GdVieware1.DisplayFromGdPictureImage(_originalImageId)) != GdPictureStatus.OK)
                {
                    MessageBox.Show(gdPictureStatus.ToString(), "Image could not be displayed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(_oGdPictureImaging.GetStat().ToString(), "Image could not be loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Apply()
        {
            if (_originalImageId != 0)
            {
                //Cloning the image to perform modifications on a copy so that the original one remains unaltered.
                int clonedImageId = _oGdPictureImaging.CreateClonedGdPictureImage(_originalImageId);
                if (clonedImageId != 0)
                {
                    //Changing the value of the calling scrollbar accordingly to the scroll of the user.
                    //Adjusting the brightness, the contrast, the saturation and the gamma of the image.
                    GdPictureStatus gdPictureStatus = _oGdPictureImaging.SetBCSG(clonedImageId,
                        HScrollBarBrightness.Value, HScrollBarContrast.Value,
                        HScrollBarGamma.Value, HScrollBarSaturation.Value);

                    if (gdPictureStatus == GdPictureStatus.OK)
                    {
                        if ((gdPictureStatus = GdVieware1.DisplayFromGdPictureImage(clonedImageId)) != GdPictureStatus.OK)
                        {
                            MessageBox.Show(gdPictureStatus.ToString(), "Image could not be displayed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(gdPictureStatus.ToString(), "BCSG could not be adjusted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Deleting the cloned image from memory.
                    _oGdPictureImaging.ReleaseGdPictureImage(clonedImageId);
                }
                else
                {
                    MessageBox.Show(_oGdPictureImaging.GetStat().ToString(), "Image could not be cloned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ScrollBarBrightness_Scroll(System.Object eventSender, ScrollEventArgs eventArgs)
        {
            if (eventArgs.OldValue != eventArgs.NewValue)
            {
                Apply();
            }
        }


        private void ScrollBarContrast_Scroll(System.Object eventSender, ScrollEventArgs eventArgs)
        {
            if (eventArgs.OldValue != eventArgs.NewValue)
            {
                Apply();
            }
        }


        private void ScrollBarGamma_Scroll(System.Object eventSender, ScrollEventArgs eventArgs)
        {
            if (eventArgs.OldValue != eventArgs.NewValue)
            {
                Apply();
            }
        }


        private void ScrollBarSaturation_Scroll(System.Object eventSender, ScrollEventArgs eventArgs)
        {
            if (eventArgs.OldValue != eventArgs.NewValue)
            {
                Apply();
            }
        }


        private void ResetBars()
        {
            HScrollBarSaturation.Value = 0;
            HScrollBarGamma.Value = 0;
            HScrollBarContrast.Value = 0;
            HScrollBarBrightness.Value = 0;
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            GdPictureStatus gdPictureStatus;
            if ((gdPictureStatus = GdVieware1.DisplayFromGdPictureImage(_originalImageId)) != GdPictureStatus.OK)
            {
                System.Windows.Forms.MessageBox.Show(gdPictureStatus.ToString(), "Image could not be displayed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetBars();
        }


        private void ReleaseGdPictureImage()
        {
            if (_originalImageId != 0)
            {
                //Deleting the image from memory.
                _oGdPictureImaging.ReleaseGdPictureImage(_originalImageId);
                _originalImageId = 0;
            }
            //Clearing the viewer.
            GdVieware1.CloseDocument();
        }


        private void CloseToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ReleaseGdPictureImage();
            ResetBars();
        }


        private void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ReleaseGdPictureImage();
            Close();
        }
    }
}