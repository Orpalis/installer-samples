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
using GdPicture14;
namespace Csharp_MICR.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        private GdPictureImaging _GdPictureImaging = new GdPictureImaging();
        private int _ImageID = 0;
        private int _InitialImageID = 0;
        private int _expectedItems = 35;
        private int _minAccuracy = 75;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); // Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); // Please, replace XXXX by a valid demo or commercial license key. 
            gdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
            cmbWhiteList.SelectedIndex = 0;
            cmbContext.SelectedIndex = 1;
            cmbFont.SelectedIndex = 0;
        }

        #region "File Menu"
        private void OpenFileCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenFileCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseNativeImage();
            _ImageID = _GdPictureImaging.CreateGdPictureImageFromFile("");

            if (_ImageID != 0)
            {

                txtResults.Text = (string)("size: " + _GdPictureImaging.GetWidth(_ImageID).ToString() + " * " + _GdPictureImaging.GetHeight(_ImageID).ToString() + "\r\n" + "resolution: " + _GdPictureImaging.GetHorizontalResolution(_ImageID).ToString() + " / " + _GdPictureImaging.GetVerticalResolution(_ImageID).ToString() + "\r\n" + "bit depth: " + _GdPictureImaging.GetBitDepth(_ImageID).ToString());
                _InitialImageID = _GdPictureImaging.CreateClonedGdPictureImage(_ImageID);
                gdViewer1.DisplayFromGdPictureImage(_ImageID);
            }
        }

        private void CloseNativeImage()
        {
            gdViewer1.CloseDocument();
            if (_ImageID != 0)
            {
                _GdPictureImaging.ReleaseGdPictureImage(_ImageID);
                _ImageID = 0;
            }

            if (_InitialImageID != 0)
            {
                _GdPictureImaging.ReleaseGdPictureImage(_InitialImageID);
            }

        }

        private void CloseCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseNativeImage();
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
        #endregion

        private void Revert()
        {
            if (_ImageID != 0 && _InitialImageID != 0)
            {
                gdViewer1.CloseDocument();
                _GdPictureImaging.ReleaseGdPictureImage(_ImageID);
                _ImageID = _GdPictureImaging.CreateClonedGdPictureImage(_InitialImageID);
                gdViewer1.DisplayFromGdPictureImage(_ImageID);
            }
        }

        #region "Image Processing"
        private void FiltersCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (_ImageID != 0)
                e.CanExecute = true;
        }

        private void AutoDeskewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _GdPictureImaging.AutoDeskew(_ImageID);
            gdViewer1.DisplayFromGdPictureImage(_ImageID);
        }

        private void Rotate90Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _GdPictureImaging.Rotate(_ImageID, System.Drawing.RotateFlipType.Rotate90FlipNone);
            gdViewer1.DisplayFromGdPictureImage(_ImageID);

        }

        private void ResetCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Revert();
        }

        private void StartCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            gdViewer1.RemoveAllRegions();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            StringBuilder result = new StringBuilder(_GdPictureImaging.MICRDoMICR(_ImageID, (MICRFont)cmbFont.SelectedIndex, (MICRContext)cmbContext.SelectedIndex, cmbWhiteList.Text, _expectedItems).Length);

            result = result.Replace(System.Convert.ToString('\0'), "?");
            sw.Stop();
            GdPictureStatus status = _GdPictureImaging.GetStat();

            if (status == GdPictureStatus.OK)
            {

                //Drawin bounding boxes
                int count = _GdPictureImaging.MICRGetSymbolsCount();
                float minAcc = 100;
                float maxAcc = 0;
                float accAccumulator = 0;
                int itemsRetained = 0;
                StringBuilder sb = new StringBuilder();


                for (int i = 1; i <= count; i++)
                {
                    float accuracy = _GdPictureImaging.MICRGetSymbolConfidence(i, 1);

                    if (accuracy >= (double)_minAccuracy)
                    {
                        itemsRetained++;
                        result.Append(_GdPictureImaging.MICRGetSymbolValue(i, 1));
                        minAcc = Math.Min((short)minAcc, (short)accuracy);
                        maxAcc = Math.Max((short)maxAcc, (short)accuracy);

                        accAccumulator += accuracy;
                        gdViewer1.AddRegion(i.ToString(), (double)_GdPictureImaging.MICRGetSymbolLeft(i) / gdViewer1.PageHorizontalResolution, 
                                            (double)_GdPictureImaging.MICRGetSymbolTop(i) / gdViewer1.PageVerticalResolution, 
                                            (double)(_GdPictureImaging.MICRGetSymbolRight(i) - _GdPictureImaging.MICRGetSymbolLeft(i)) / gdViewer1.PageHorizontalResolution, 
                                            (double)(_GdPictureImaging.MICRGetSymbolBottom(i) - _GdPictureImaging.MICRGetSymbolTop(i)) / gdViewer1.PageVerticalResolution, 
                                            Colors.Yellow, GdPicture14.WPF.GdViewer.RegionFillMode.Multiply);
                    }

                }
                gdViewer1.Redraw();
                sb.Append("Count: " + itemsRetained.ToString() + "\r\n" + "Elapsed: " + (Math.Round(sw.Elapsed.TotalMilliseconds, 2)).ToString() + " ms." + "\r\n" + "Confidence. Min: " + (Math.Round(minAcc, 2)).ToString() + "%. " + "Max: " + (Math.Round(maxAcc, 2)).ToString() + "%. " + "Avg: " + (Math.Round(accAccumulator / itemsRetained, 2)).ToString() + "%. " + "\r\n" + "Result: " + result.ToString());

                sb.Append("\r\n" + "\r\n" + "=======================" + "\r\n" + "Details:" + "\r\n" + "=======================" + "\r\n");
                for (int i = 1; i <= count; i++)
                {

                    if (_GdPictureImaging.MICRGetSymbolConfidence(i, 1) >= (double)_minAccuracy)
                    {

                        string candidate1 = _GdPictureImaging.MICRGetSymbolValue(i, 1);
                        string candidate2 = _GdPictureImaging.MICRGetSymbolValue(i, 2);

                        if (char.Parse(candidate1) == '\0')
                        {
                            candidate1 = "#undef";
                        }

                        if (char.Parse(candidate2) == '\0')
                        {
                            candidate2 = "#undef";
                        }

                        string symbolDetails = "(" + i.ToString() + ") " + "Candidate 1: \'" + candidate1 + "\' (" + (Math.Round(_GdPictureImaging.MICRGetSymbolConfidence(i, 1), 1)).ToString() + "%). " + "Candidate 2: \'" + candidate2 + "\' (" + (Math.Round(_GdPictureImaging.MICRGetSymbolConfidence(i, 2), 1)).ToString() + "%).";

                        sb.Append(symbolDetails + "\r\n");
                    }
                }
                txtResults.Text = sb.ToString();
            }
            else
            {
                txtResults.Text = "Error: " + status.ToString();
            }
        }
        #endregion
        private void cmbFont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFont.SelectedIndex == 1)
            {
                cmbWhiteList.SelectedIndex = 2;
            }
        }

        private void symDown_Click(object sender, RoutedEventArgs e)
        {
            if (_expectedItems > 0)
            {
                _expectedItems--;
                nupdownSymbols.Text = _expectedItems.ToString();
            }
        }

        private void symUp_Click(object sender, RoutedEventArgs e)
        {
            _expectedItems++;
            nupdownSymbols.Text = _expectedItems.ToString();
        }

        private void nupminDown_Click(object sender, RoutedEventArgs e)
        {
            if (_minAccuracy > 0)
            {
                _minAccuracy--;
                nupminAcc.Text = _minAccuracy.ToString();
            }
        }

        private void nupminUp_Click(object sender, RoutedEventArgs e)
        {
            _minAccuracy++;
            nupminAcc.Text = _minAccuracy.ToString();
        }

    }
}
