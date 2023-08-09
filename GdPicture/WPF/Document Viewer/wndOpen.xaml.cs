using GdPicture14;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace DocumentViewer
{
    /// <summary>
    /// Interaction logic for wndOpen.xaml
    /// </summary>
    public partial class wndOpen : Window
    {
        private readonly GdPicture14.WPF.GdViewer _owner;
        public wndOpen(GdPicture14.WPF.GdViewer owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        private void btnOpenFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                tbFile.Text = openFileDialog.FileName;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            bool ok = false;
            if (rbOpenFromFile.IsChecked == true)
            {
                if (!string.IsNullOrWhiteSpace(tbFile.Text) && File.Exists(tbFile.Text))
                {
                    GdPictureStatus status = _owner.DisplayFromFile(tbFile.Text);
                    if (status == GdPictureStatus.OK)
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("Error during file loading: " + status, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You must select a file", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            else if (rbOpenFromFTP.IsChecked == true)
            {
                int port = 0;
                if (!string.IsNullOrWhiteSpace(tbHost.Text) && !string.IsNullOrWhiteSpace(tbPort.Text)
                    && int.TryParse(tbPort.Text, out port) && !string.IsNullOrWhiteSpace(tbPath.Text))
                {
                    GdPictureStatus status = _owner.DisplayFromFTP(tbHost.Text, tbPath.Text, tbLogin.Text, tbPassword.Password, port);
                    if (status == GdPictureStatus.OK)
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("FTP Error: " + _owner.GetLastTransferError(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You must enter all data for FTP connection", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (rbOpenFromHTTP.IsChecked == true)
            {
                Uri uri = null;
                if (!string.IsNullOrWhiteSpace(tbOpenFromHTTP.Text) && Uri.TryCreate(tbOpenFromHTTP.Text, UriKind.Absolute, out uri))
                {
                    GdPictureStatus status = _owner.DisplayFromHTTP(uri.ToString(), "", "");
                    if (status == GdPictureStatus.OK)
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("HTTP Error: " + _owner.GetLastTransferError(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You must specify an URI", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (rbOpenFromClipboard.IsChecked == true)
            {
                if (Clipboard.ContainsImage())
                {
                    GdPictureStatus status = _owner.DisplayFromClipboard();
                    if (status == GdPictureStatus.OK)
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("Error: " + status, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("There is no image in clipboard", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (ok)
            {
                Close();
            }
        }
    }
}
