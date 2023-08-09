using GdPicture14;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace Csharp_async_Twain_Scanning.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BackgroundWorker m_backGroundWorker = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
        private GdPictureImaging m_gdpictureImaging = new GdPictureImaging();
        private bool m_useFeeder; //todo: use dependency property instead.
        private bool m_duplex; //todo: use dependency property instead.
        private bool m_hideDeviceUI; //todo: use dependency property instead.
        private bool m_favorMemortTransfer = true; //todo: use dependency property instead.
        private bool m_enableDeviceIndicator; //todo: use dependency property instead.

        public MainWindow()
        {
            InitializeComponent();

            GdPicture14.LicenseManager oLicenseManager = new GdPicture14.LicenseManager();
            oLicenseManager.RegisterKEY("XXX"); //Please, replace XXX by a valid demo or commercial license key.

            m_backGroundWorker.DoWork += new DoWorkEventHandler(m_backGroundWorker_DoWork);
            m_backGroundWorker.ProgressChanged += new ProgressChangedEventHandler(m_backGroundWorker_ProgressChanged);
            txtWorkingDir.Text = System.AppDomain.CurrentDomain.BaseDirectory;
            //Check for 64-bit mode app running
            if (IntPtr.Size == 8)
            {
                MessageBox.Show("Warning: The application is running in 64-bit mode. To be able to handle 32-bit TWAIN drivers you will have to target it to 32-bit mode.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!m_backGroundWorker.IsBusy)
            {
                if (chkGenLog.IsChecked != null && chkGenLog.IsChecked.Value)
                {
                    m_gdpictureImaging.TwainLogStart("gdpicture_twain.log");
                }

                m_gdpictureImaging.TwainSetModalUI(chkModalUI.IsChecked != null && chkModalUI.IsChecked.Value);


                if (chkTwain19.IsChecked != null && chkTwain19.IsChecked.Value)
                {
                    m_gdpictureImaging.TwainSetDSMPath("c:\\windows\\twain_32.dll");
                }
                else
                {
                    m_gdpictureImaging.TwainSetDSMPath(""); //the latest available DSM will be automatically selected
                }


                m_backGroundWorker.RunWorkerAsync(); //do the scan
            }
            else
            {
                MessageBox.Show("Backgroung worker is currently busy!");
            }
        }


        public void m_backGroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            IntPtr hwnd = IntPtr.Zero; //To enfore the TWAIN controller to create its own windows proxy in the background worker thread.

            if (m_gdpictureImaging.TwainSelectSource(hwnd))
            {
                if (m_gdpictureImaging.TwainOpenDefaultSource(hwnd))
                {
                    int scanCount = 0;

                    m_gdpictureImaging.TwainSetHideUI(m_hideDeviceUI);
                    m_gdpictureImaging.TwainSetIndicators(m_enableDeviceIndicator);
                    m_gdpictureImaging.TwainSelectFeeder(m_useFeeder);

                    if (m_useFeeder)
                    {
                        m_gdpictureImaging.TwainSetAutoFeed(true);
                        m_gdpictureImaging.TwainSetAutoScan(true);
                    }

                    m_gdpictureImaging.TwainEnableDuplex(m_duplex);

                    m_gdpictureImaging.TwainEnableMemoryTransferMode(m_favorMemortTransfer);

                    if (m_favorMemortTransfer)
                    {//enabling compression to reach maximum transfer rate.
                        m_gdpictureImaging.TwainSetCompression(TwainCompression.TWCP_JPEG);
                    }

                    do
                    {
                        if (!m_backGroundWorker.CancellationPending)
                        {
                            int imageId = m_gdpictureImaging.TwainAcquireToGdPictureImage(hwnd);

                            if (imageId != 0)
                            {
                                scanCount++;
                                m_backGroundWorker.ReportProgress(scanCount, imageId);
                            }
                        }
                        else
                        {
                            break;
                        }
                    } while (m_gdpictureImaging.TwainGetState() > TwainStatus.TWAIN_SOURCE_ENABLED);

                    if (scanCount > 0)
                    {
                        MessageBox.Show(scanCount + " page(s) acquired");
                    }
                    else
                    {
                        MessageBox.Show("Operation failed or cancelled. Twain status: " + m_gdpictureImaging.TwainGetState().ToString() + "\r\nGdPicture status: " + m_gdpictureImaging.GetStat().ToString());
                    }
                    m_gdpictureImaging.TwainCloseSource();
                }
                else
                {
                    MessageBox.Show("Unable to open the default TWAIN source. " + '\r' + "Result code: " + m_gdpictureImaging.TwainGetLastResultCode() +
                        '\r' + "Condition code: " + m_gdpictureImaging.TwainGetLastConditionCode());
                }
            }
            else
            {
                MessageBox.Show("Operation cancelled - no source selected");
            }

            m_gdpictureImaging.TwainUnloadSourceManager(hwnd);
        }


        public void m_backGroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            int ImageID = Convert.ToInt32(e.UserState);
            int imageNo = e.ProgressPercentage;
            string workingDir = txtWorkingDir.Text;
            //note: here we use 1 thread per image saving to maximize transfer rate.

            Thread t = new Thread(() =>
            {
                using (GdPictureImaging gdpictureImaging = new GdPictureImaging()) //note: it is a good practice to use one GdPictureImaging object per thread.
                {
                    int imageBitDepth = gdpictureImaging.GetBitDepth(ImageID);

                    if (imageBitDepth == 1)
                    {
                        string dstPath = workingDir + "\\image" + imageNo.ToString() + ".tif";
                        GdPictureStatus status = gdpictureImaging.SaveAsTIFF(ImageID, dstPath, TiffCompression.TiffCompressionCCITT4);
                        if (status != GdPictureStatus.OK)
                        {
                            MessageBox.Show("Error saving image to " + dstPath + ". Status: " + status.ToString());
                        }
                    }
                    else
                    {
                        string dstPath = workingDir + "\\image" + imageNo.ToString() + ".jpg";
                        GdPictureStatus status = gdpictureImaging.SaveAsJPEG(ImageID, dstPath, 75);
                        if (status != GdPictureStatus.OK)
                        {
                            MessageBox.Show("Error saving image to " + dstPath + ". Status: " + status.ToString());
                        }
                    }
                    gdpictureImaging.ReleaseGdPictureImage(ImageID);
                }
            }
          );
            t.Start();
        }

        private void chkUseFeeder_Checked(object sender, RoutedEventArgs e)
        {
            m_useFeeder = true;
        }

        private void chkUseFeeder_Unchecked(object sender, RoutedEventArgs e)
        {
            m_useFeeder = false;
        }

        private void chkDuplex_Checked(object sender, RoutedEventArgs e)
        {
            m_duplex = true;
        }

        private void chkDuplex_Unchecked(object sender, RoutedEventArgs e)
        {
            m_duplex = false;
        }

        private void chkHideGUI_Checked(object sender, RoutedEventArgs e)
        {
            m_hideDeviceUI = true;
        }

        private void chkHideGUI_Unchecked(object sender, RoutedEventArgs e)
        {
            m_hideDeviceUI = false;
        }

        private void chkEnableIndicator_Checked(object sender, RoutedEventArgs e)
        {
            m_enableDeviceIndicator = true;
        }

        private void chkEnableIndicator_Unchecked(object sender, RoutedEventArgs e)
        {
            m_enableDeviceIndicator = false;
        }

        private void chkMemTransfer_Checked(object sender, RoutedEventArgs e)
        {
            m_favorMemortTransfer = true;
        }

        private void chkMemTransfer_Unchecked(object sender, RoutedEventArgs e)
        {
            m_favorMemortTransfer = false;
        }
    }
}
