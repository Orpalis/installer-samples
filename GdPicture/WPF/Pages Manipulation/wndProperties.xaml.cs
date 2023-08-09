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
using System.Windows.Shapes;

namespace Csharp_Pages_Manipulation.WPF
{
    /// <summary>
    /// Interaction logic for wndProperties.xaml
    /// </summary>
    public partial class wndProperties : Window
    {
        public wndProperties()
        {
            InitializeComponent();
            this.Loaded += wndProperties_Loaded;
        }

        void wndProperties_Loaded(object sender, RoutedEventArgs e)
        {
            txtApplication.Text = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetCreator();
            txtAuthor.Text = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetAuthor();
            txtCreated.Text = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetCreationDate();
            txtKeywords.Text = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetKeywords();
            string meta = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetMetadata();
            StringBuilder sb = new StringBuilder(meta);
            sb.Replace("\r", "\r\n");
            txtMetadata.Text = sb.ToString();
            txtModified.Text = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetModificationDate();
            txtProducer.Text = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetProducer();
            txtSubject.Text = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetSubject();
            txtTitle.Text = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetTitle();
            txtVersion.Text = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetVersion();
            string encryption = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).GdViewer1.PdfGetEncryptionScheme().ToString();

            txtEncryption.Text = encryption.Replace("PdfEncryption", "");
        }

    }
}
