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

namespace Csharp_OMR_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int m_ImageID;
        private GdPictureImaging m_GdPictureImaging = new GdPictureImaging(); 

        public MainWindow()
        {
            InitializeComponent();
            defaultOMR.IsChecked = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); // Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); // Please, replace XXXX by a valid demo or commercial license key. 
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
        }

        private void ReleaseGdpictureImage()
        {
            if (m_ImageID != 0)
            {
                m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID);
                m_ImageID = 0;
            }
            GdViewer1.CloseDocument();
        } 

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            ReleaseGdpictureImage();
            m_ImageID = m_GdPictureImaging.CreateGdPictureImageFromFile("");
            if (m_ImageID != 0)
            {
                if (GdViewer1.DisplayFromGdPictureImage(m_ImageID) != GdPictureStatus.OK)
                    MessageBox.Show("Cannot Display Image");
            }
            else
            {
                MessageBox.Show("No Image was loaded");
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            ReleaseGdpictureImage(); 
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ReleaseGdpictureImage(); 
            Close();
        }

        private void GdViewer1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (GdViewer1.IsRect())
            {
                double Left = 0.0, Top = 0.0, Width = 0.0, Height = 0.0;
                GdViewer1.GetRectCoordinatesOnDocumentPixel(ref Left, ref Top, ref Width, ref Height);
                System.Drawing.Rectangle[] Rects = new System.Drawing.Rectangle[2];
                int[] Result = null;

                Rects[0].X = (int)Left;
                Rects[0].Y = (int)Top;
                Rects[0].Width = (int)Width;
                Rects[0].Height = (int)Height;
                if (defaultOMR.IsChecked == true)
                    Result = m_GdPictureImaging.OMRDetectMarks(m_ImageID, Rects, 1);
                else
                    Result = m_GdPictureImaging.OMRDetectOvalMarks(m_ImageID, Rects, 1);

                MessageBox.Show("Value: " + Result[0].ToString());
            } 
        }

        private void defaultOMR_Checked(object sender, RoutedEventArgs e)
        {
            ovalOMR.IsChecked = false;
        }

        private void defaultOMR_Unchecked(object sender, RoutedEventArgs e)
        {
            ovalOMR.IsChecked = true;
        }

        private void ovalOMR_Checked(object sender, RoutedEventArgs e)
        {
            defaultOMR.IsChecked = false;
        }

        private void ovalOMR_Unchecked(object sender, RoutedEventArgs e)
        {
            defaultOMR.IsChecked = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.ZoomIN();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GdViewer1.ZoomOUT();
        }
    }
}
