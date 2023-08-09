using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using GdPicture14;
namespace Csharp_Binarization.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _ImageSrc;
        private int _ClonedImage;
        private GdPictureImaging _oGdPictureImaging = new GdPictureImaging();
        private BitonalReduction _btReduction;
        private bool _lockEvents = false;
        private int _previous = -1;


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

            _ImageSrc = _oGdPictureImaging.CreateGdPictureImageFromFile("");
            if (System.Convert.ToDouble(_oGdPictureImaging.GetStat()) == 0)
            {
                GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
                GdViewer1.DisplayFromGdPictureImage(_ImageSrc);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            oSaveFileDialog.Filter = "TIFF Image|*.tif";
            if (oSaveFileDialog.ShowDialog() == true)
            {
                string FilePath = oSaveFileDialog.FileName;
                if (_oGdPictureImaging.SaveAsTIFF(_ClonedImage, oSaveFileDialog.FileName, TiffCompression.TiffCompressionCCITT4) == GdPictureStatus.OK)
                {
                    MessageBox.Show("Document succefully saved as Tiff in " + FilePath);
                }
                else
                {
                    MessageBox.Show("Can't save document in " + FilePath + " Error: " + _oGdPictureImaging.GetStat().ToString());
                }
            }
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

        private void CloseImage()
        {
            if (_ImageSrc != 0)
            {
                _oGdPictureImaging.ReleaseGdPictureImage(_ImageSrc);
                _ImageSrc = 0;
            }
            if (_ClonedImage != 0)
            {
                _oGdPictureImaging.ReleaseGdPictureImage(_ClonedImage);
                _ClonedImage = 0;
            }
            GdViewer1.CloseDocument();
            comboBox1.SelectedIndex = 0;
        }


        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _lockEvents = true;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    parametersBox.Visibility = System.Windows.Visibility.Hidden;
                    _previous = 0;
                    break;
                case 1:
                    // change threshold parameters
                    if (_previous != 1)
                    {
                        lbl1.Content = "Threshold";
                        sldThreshold.Minimum = 1;
                        sldThreshold.Maximum = 254;
                        sldThreshold.Value = 128;
                        txtThreshold.Text = sldThreshold.Value.ToString();
                        parametersBox.Visibility = System.Windows.Visibility.Visible;
                        lbl2.Visibility = Visibility.Hidden;
                        lbl3.Visibility = Visibility.Hidden;
                        sldCont.Visibility = Visibility.Hidden;
                        sldSmooth.Visibility = Visibility.Hidden;
                        txtCont.Visibility = Visibility.Hidden;
                        txtSmooth.Visibility = Visibility.Hidden;
                    }
                    _previous = 1;
                    break;
                case 2:
                    // change threshold parameters
                    if (_previous != 2)
                    {
                        lbl1.Content = "Threshold";
                        sldThreshold.Minimum = 0;
                        sldThreshold.Maximum = 100;
                        sldThreshold.Value = 50;
                        txtThreshold.Text = sldThreshold.Value.ToString();
                        parametersBox.Visibility = System.Windows.Visibility.Visible;
                        lbl2.Visibility = Visibility.Hidden;
                        lbl3.Visibility = Visibility.Hidden;
                        sldCont.Visibility = Visibility.Hidden;
                        sldSmooth.Visibility = Visibility.Hidden;
                        txtCont.Visibility = Visibility.Hidden;
                        txtSmooth.Visibility = Visibility.Hidden;
                    }
                    _previous = 2;
                    break;
                case 3:
                    parametersBox.Visibility = System.Windows.Visibility.Hidden;
                    _previous = 3;
                    _btReduction = BitonalReduction.OrderedDither;
                    break;
                case 4:
                    if (_previous != 4)
                    {
                        lbl1.Content = "PalWeight";
                        sldThreshold.Minimum = 0;
                        sldThreshold.Maximum = 255;
                        sldThreshold.Value = 15;
                        txtThreshold.Text = sldThreshold.Value.ToString();
                        parametersBox.Visibility = System.Windows.Visibility.Visible;
                        lbl2.Visibility = Visibility.Hidden;
                        lbl3.Visibility = Visibility.Hidden;
                        sldCont.Visibility = Visibility.Hidden;
                        sldSmooth.Visibility = Visibility.Hidden;
                        txtCont.Visibility = Visibility.Hidden;
                        txtSmooth.Visibility = Visibility.Hidden;
                    }
                    _previous = 4;
                    _btReduction = BitonalReduction.Burke;
                    break;
                case 5:
                    if (_previous != 5)
                    {
                        lbl1.Content = "PalWeight";
                        sldThreshold.Minimum = 0;
                        sldThreshold.Maximum = 255;
                        sldThreshold.Value = 15;
                        txtThreshold.Text = sldThreshold.Value.ToString();
                        parametersBox.Visibility = System.Windows.Visibility.Visible;
                        lbl2.Visibility = Visibility.Hidden;
                        lbl3.Visibility = Visibility.Hidden;
                        sldCont.Visibility = Visibility.Hidden;
                        sldSmooth.Visibility = Visibility.Hidden;
                        txtCont.Visibility = Visibility.Hidden;
                        txtSmooth.Visibility = Visibility.Hidden;
                    }
                    _previous = 5;
                    _btReduction = BitonalReduction.Stucki;
                    break;
                case 6:
                    if (_previous != 6)
                    {
                        lbl1.Content = "PalWeight";
                        sldThreshold.Minimum = 0;
                        sldThreshold.Maximum = 255;
                        sldThreshold.Value = 15;
                        txtThreshold.Text = sldThreshold.Value.ToString();
                        parametersBox.Visibility = System.Windows.Visibility.Visible;
                        lbl2.Visibility = Visibility.Hidden;
                        lbl3.Visibility = Visibility.Hidden;
                        sldCont.Visibility = Visibility.Hidden;
                        sldSmooth.Visibility = Visibility.Hidden;
                        txtCont.Visibility = Visibility.Hidden;
                        txtSmooth.Visibility = Visibility.Hidden;
                    }
                    _previous = 6;
                    _btReduction = BitonalReduction.FloydSteinberg;
                    break;
                case 7:
                    if (_previous != 7)
                    {
                        lbl1.Content = "Factor";
                        sldThreshold.Minimum = 0;
                        sldThreshold.Maximum = 100;
                        sldThreshold.Value = 35;
                        txtThreshold.Text = (string)(Math.Round((double)sldThreshold.Value / 100, 2).ToString());
                        parametersBox.Visibility = System.Windows.Visibility.Visible;
                        lbl2.Visibility = Visibility.Visible;
                        lbl3.Visibility = Visibility.Visible;
                        sldCont.Visibility = Visibility.Visible;
                        sldSmooth.Visibility = Visibility.Visible;
                        txtCont.Visibility = Visibility.Visible;
                        txtSmooth.Visibility = Visibility.Visible;
                    }
                    _previous = 7;
                    break;
            }

            _lockEvents = false;

            if (_ImageSrc != 0)
            {
                doThreshold();
            }
        }

        private void doThreshold()
        {

            if (comboBox1.SelectedIndex > 0 && comboBox1.SelectedIndex <= 7)
            {
                if (_ClonedImage != 0)
                {
                    _oGdPictureImaging.ReleaseGdPictureImage(_ClonedImage);
                }
                if (_ImageSrc != 0)
                {
                    _ClonedImage = _oGdPictureImaging.CreateClonedGdPictureImage(_ImageSrc);
                    if (_ClonedImage == 0)
                    {
                        MessageBox.Show("Error : " + _oGdPictureImaging.GetStat().ToString());
                        return;
                    }
                }

                switch (comboBox1.SelectedIndex)
                {
                    case 1:
                        _oGdPictureImaging.ConvertTo1Bpp(_ClonedImage, System.Convert.ToByte(sldThreshold.Value));
                        break;
                    case 2:
                        _oGdPictureImaging.ConvertTo1BppAT(_ClonedImage, (int)sldThreshold.Value);
                        break;
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        if (_oGdPictureImaging.FxBlackNWhite(_ClonedImage, _btReduction, (int)sldThreshold.Value) == GdPictureStatus.OK)
                        {
                            _oGdPictureImaging.ConvertTo1BppFast(_ClonedImage);
                        }
                        break;
                    case 7:
                        _oGdPictureImaging.ConvertTo1BppSauvola(_ClonedImage, (float)sldThreshold.Value / 100.0F, (int)sldCont.Value, (int)sldSmooth.Value);
                        break;
                }


                if (_oGdPictureImaging.GetStat() == GdPictureStatus.OK)
                {
                    if (GdViewer1.DisplayFromGdPictureImage(_ClonedImage) != GdPictureStatus.OK)
                    {
                        MessageBox.Show("The Image cannot be displayed");
                    }
                }
                else
                {
                    MessageBox.Show("Can't binarize image. Error: " + _oGdPictureImaging.GetStat().ToString());
                }
            }

        }

        private void sldThreshold_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue != e.OldValue)
            {
                if (comboBox1.SelectedIndex == 7)
                {
                    txtThreshold.Text = ((int)(Math.Round((double)sldThreshold.Value / 100, 2))).ToString();
                }
                else
                {
                    txtThreshold.Text = e.NewValue.ToString();
                }
                if (!(_lockEvents))
                {
                    doThreshold();
                }
            }
        }

        private void sldCont_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue != e.OldValue)
            {
                txtCont.Text = ((int)e.NewValue).ToString();
                if (!(_lockEvents))
                {
                    doThreshold();
                }
            }
        }

        private void sldSmooth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue != e.OldValue)
            {
                txtSmooth.Text = ((int)e.NewValue).ToString();
                if (!(_lockEvents))
                {
                    doThreshold();
                }
            }
        }

    }
}
