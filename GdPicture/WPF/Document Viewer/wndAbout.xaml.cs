using System.Windows;

namespace DocumentViewer
{
    /// <summary>
    /// Interaction logic for wndAbout.xaml
    /// </summary>
    public partial class wndAbout : Window
    {
        public wndAbout()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
