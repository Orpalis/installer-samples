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
using GdPicture14;

namespace Csharp_Display_From_URL.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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

        private void ZoomOut_Click(object sender, RoutedEventArgs e)
        {
            if (GdViewer1.ZoomOUT() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Zoom Out"); 
        }

        private void ZoomIn_Click(object sender, RoutedEventArgs e)
        {
            if (GdViewer1.ZoomIN() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Zoom In"); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GdViewer1.DisplayFromHTTP(txtHost.Text, txtPath.Text, 80);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString());
            } 
        }

        private void GdViewer1_DataReceived(object sender, GdPicture14.WPF.GdViewer.DataReceivedEventArgs e)
        {
            prgBar.Value = System.Convert.ToInt32(e.PercentProgress);
        } 
    }
}
