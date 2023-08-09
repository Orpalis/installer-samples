using GdPicture14;
using System.Drawing;
using System.Windows.Forms;
namespace anglerotation
{
    internal partial class Form1 : System.Windows.Forms.Form
    {
        private int _originalImage;
        private int _clonedImage;
        private GdPictureStatus _gdPictureStatus;
        private readonly GdPictureImaging _gdPictureImaging = new GdPictureImaging();




        private void Form1_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
        }


        private void HScroll1_Scroll(System.Object eventSender, System.Windows.Forms.ScrollEventArgs eventArgs)
        {
            if (eventArgs.NewValue != eventArgs.OldValue)
            {
                HScroll2.Value = 0;
                HScroll3.Value = 0;
                HScroll4.Value = 0;

                if (_originalImage != 0)
                {
                    System.Windows.Forms.Application.DoEvents();
                    if (_clonedImage != 0)
                    {
                        _gdPictureImaging.ReleaseGdPictureImage(_clonedImage);
                        _clonedImage = 0;
                    }
                    _clonedImage = _gdPictureImaging.CreateClonedGdPictureImage(_originalImage);
                    if (_clonedImage == 0)
                    {
                        MessageBox.Show("Error: " + _gdPictureImaging.GetStat());
                        return;
                    }
                    _gdPictureStatus = _gdPictureImaging.RotateAngle(_clonedImage, HScroll1.Value);
                    if (_gdPictureStatus == GdPictureStatus.OK)
                    {
                        if (GdViewer1.DisplayFromGdPictureImage(_clonedImage) != GdPictureStatus.OK)
                        {
                            MessageBox.Show("Cannot Display Image:" + GdViewer1.GetStat());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error No: " + _gdPictureStatus);
                    }
                }
            }
        }


        private void HScroll2_Scroll(System.Object eventSender, System.Windows.Forms.ScrollEventArgs eventArgs)
        {
            if (eventArgs.NewValue != eventArgs.OldValue)
            {
                HScroll1.Value = 0;
                HScroll3.Value = 0;
                HScroll4.Value = 0;
                if (_originalImage != 0)
                {
                    System.Windows.Forms.Application.DoEvents();
                    if (_clonedImage != 0)
                    {
                        _gdPictureImaging.ReleaseGdPictureImage(_clonedImage);
                        _clonedImage = 0;
                    }
                    _clonedImage = _gdPictureImaging.CreateClonedGdPictureImage(_originalImage);
                    if (_clonedImage == 0)
                    {
                        MessageBox.Show("Error: " + _gdPictureImaging.GetStat());
                        return;
                    }
                    _gdPictureStatus = _gdPictureImaging.RotateAnglePreserveDimensionsCenter(_clonedImage, HScroll2.Value);
                    if (_gdPictureStatus == GdPictureStatus.OK)
                    {
                        if (GdViewer1.DisplayFromGdPictureImage(_clonedImage) != GdPictureStatus.OK)
                            MessageBox.Show("Cannot Display Image:" + GdViewer1.GetStat());
                    }
                    else
                    {
                        MessageBox.Show("Error No: " + _gdPictureStatus);
                    }
                }
            }
        }


        private void HScroll3_Scroll(System.Object eventSender, System.Windows.Forms.ScrollEventArgs eventArgs)
        {
            if (eventArgs.NewValue != eventArgs.OldValue)
            {
                HScroll1.Value = 0;
                HScroll2.Value = 0;
                HScroll4.Value = 0;
                if (_originalImage != 0)
                {
                    System.Windows.Forms.Application.DoEvents();
                    if (_clonedImage != 0)
                    {
                        _gdPictureImaging.ReleaseGdPictureImage(_clonedImage);
                        _clonedImage = 0;
                    }
                    _clonedImage = _gdPictureImaging.CreateClonedGdPictureImage(_originalImage);
                    if (_clonedImage == 0)
                    {
                        MessageBox.Show("Error: " + _gdPictureImaging.GetStat());
                        return;
                    }
                    _gdPictureStatus = _gdPictureImaging.RotateAnglePreserveDimensions(_clonedImage, HScroll3.Value);
                    if (_gdPictureStatus == GdPictureStatus.OK)
                    {
                        if (GdViewer1.DisplayFromGdPictureImage(_clonedImage) != GdPictureStatus.OK)
                        {
                            MessageBox.Show("Cannot Display Image:" + GdViewer1.GetStat());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error No: " + _gdPictureStatus);
                    }
                }
            }
        }


        private void HScroll4_Scroll(System.Object eventSender, System.Windows.Forms.ScrollEventArgs eventArgs)
        {
            if (eventArgs.NewValue != eventArgs.OldValue)
            {
                HScroll1.Value = 0;
                HScroll2.Value = 0;
                HScroll3.Value = 0;
                if (_originalImage != 0)
                {
                    System.Windows.Forms.Application.DoEvents();
                    if (_clonedImage != 0)
                    {
                        _gdPictureImaging.ReleaseGdPictureImage(_clonedImage);
                        _clonedImage = 0;
                    }
                    _clonedImage = _gdPictureImaging.CreateClonedGdPictureImage(_originalImage);
                    if (_clonedImage == 0)
                    {
                        MessageBox.Show("Error: " + _gdPictureImaging.GetStat());
                        return;
                    }
                    _gdPictureStatus = _gdPictureImaging.RotateAngleBackColor(_clonedImage, HScroll4.Value, Color.White);
                    if (_gdPictureStatus == GdPictureStatus.OK)
                    {
                        if (GdViewer1.DisplayFromGdPictureImage(_clonedImage) != GdPictureStatus.OK)
                        {

                            MessageBox.Show("Cannot Display Image:" + GdViewer1.GetStat());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error No: " + _gdPictureStatus);
                    }
                }
            }
        }


        private void OpenToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CloseImage();

            _originalImage = _gdPictureImaging.CreateGdPictureImageFromFile("");
            if (_gdPictureImaging.GetStat() == GdPictureStatus.OK)
            {
                if (GdViewer1.DisplayFromGdPictureImage(_originalImage) != GdPictureStatus.OK)
                {
                    MessageBox.Show("Cannot Display Image: " + GdViewer1.GetStat());
                }
            }
        }


        private void CloseImage()
        {
            if (_originalImage != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_originalImage);
                _originalImage = 0;
            }
            if (_clonedImage != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_clonedImage);
                _clonedImage = 0;
            }
            GdViewer1.CloseDocument();
        }


        private void CloseToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CloseImage();
        }


        private void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CloseImage();
            Close();
        }
    }
}
