using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Drawing;
using GdPicture14;
namespace Csharp_Rotate_by_Angle.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _imageSrc;
        private int _clonedImage;
        private GdPictureStatus _stat;
        private GdPictureImaging oGdPictureImaging = new GdPictureImaging();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); // Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); // Please, replace XXXX by a valid demo or commercial license key. 
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            CloseImage();

            _imageSrc = oGdPictureImaging.CreateGdPictureImageFromFile("");
            if (oGdPictureImaging.GetStat() == GdPictureStatus.OK)
            {
                if (GdViewer1.DisplayFromGdPictureImage(_imageSrc) != GdPictureStatus.OK)
                    MessageBox.Show("Cannot Display Image: " + GdViewer1.GetStat().ToString());
            }
        }

        private void CloseImage()
        {
            if (_imageSrc != 0)
            {
                oGdPictureImaging.ReleaseGdPictureImage(_imageSrc);
                _imageSrc = 0;
            }
            if (_clonedImage != 0)
            {
                oGdPictureImaging.ReleaseGdPictureImage(_clonedImage);
                _clonedImage = 0;
            }
            GdViewer1.CloseDocument();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            CloseImage();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            CloseImage();
            Close();
        }

        private void HScroll3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue != e.OldValue)
            {
                HScroll1.Value = 0;
                HScroll2.Value = 0;
                if (_imageSrc != 0)
                {
                    DoEvents();
                    if (_clonedImage != 0)
                    {
                        oGdPictureImaging.ReleaseGdPictureImage(_clonedImage);
                        _clonedImage = 0;
                    }
                    _clonedImage = oGdPictureImaging.CreateClonedGdPictureImage(_imageSrc);
                    if (_clonedImage == 0)
                    {
                        MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
                        return;
                    }
                    _stat = oGdPictureImaging.RotateAnglePreserveDimensions(_clonedImage, (float)HScroll3.Value);
                    if (_stat == GdPictureStatus.OK)
                    {
                        if (GdViewer1.DisplayFromGdPictureImage(_clonedImage) != GdPictureStatus.OK)
                            MessageBox.Show("Cannot Display Image:" + GdViewer1.GetStat().ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error No: " + _stat.ToString());
                    }
                }
            }
        }

        private void HScroll2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue != e.OldValue)
            {
                HScroll1.Value = 0;
                HScroll3.Value = 0;
                if (_imageSrc != 0)
                {
                   DoEvents();
                    if (_clonedImage != 0)
                    {
                        oGdPictureImaging.ReleaseGdPictureImage(_clonedImage);
                        _clonedImage = 0;
                    }
                    _clonedImage = oGdPictureImaging.CreateClonedGdPictureImage(_imageSrc);
                    if (_clonedImage == 0)
                    {
                        MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
                        return;
                    }
                    _stat = oGdPictureImaging.RotateAnglePreserveDimensionsCenter(_clonedImage, (float)HScroll2.Value);
                    if (_stat == GdPictureStatus.OK)
                    {
                        if (GdViewer1.DisplayFromGdPictureImage(_clonedImage) != GdPictureStatus.OK)
                            MessageBox.Show("Cannot Display Image:" + GdViewer1.GetStat().ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error No: " + _stat.ToString());
                    }
                }
            }
        }

        private void HScroll1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue != e.OldValue)
            {
                HScroll2.Value = 0;
                HScroll3.Value = 0;

                if (_imageSrc != 0)
                {
                    DoEvents();
                    if (_clonedImage != 0)
                    {
                        oGdPictureImaging.ReleaseGdPictureImage(_clonedImage);
                        _clonedImage = 0;
                    }
                    _clonedImage = oGdPictureImaging.CreateClonedGdPictureImage(_imageSrc);
                    if (_clonedImage == 0)
                    {
                        MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
                        return;
                    }
                    _stat = oGdPictureImaging.RotateAngle(_clonedImage, (float)HScroll1.Value);
                    if (_stat == GdPictureStatus.OK)
                    {
                        if (GdViewer1.DisplayFromGdPictureImage(_clonedImage) != GdPictureStatus.OK)
                            MessageBox.Show("Cannot Display Image:" + GdViewer1.GetStat().ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error No: " + _stat.ToString());
                    }
                }
            }
        }

        private void DoEvents()
        {
            DispatcherFrame frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background, new DispatcherOperationCallback(ExitFrame), frame);
            Dispatcher.PushFrame(frame);
        }

        private object ExitFrame(object f)
        {
            ((DispatcherFrame)f).Continue = false;

            return null;
        }
    }
}
