using System;
using System.ComponentModel;
using System.Windows.Forms;
using GdPicture14;
using System.Threading;


namespace async_scanning
{
    public partial class Form1
    {
        private GdPictureImaging _gdPictureImaging = new GdPictureImaging();
        private BackgroundWorker _backGroundWorker = new System.ComponentModel.BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            _backGroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(m_BackgroundWorker_DoWork);
            _backGroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(m_BackgroundWorker_ProgressChanged);
            //Check for 64-bit mode app running
            if (IntPtr.Size == 8)
            {
                chkTwain19.Enabled = false; //no 64-bit version of twain 1.9.
                MessageBox.Show("Warning: The application is running in 64-bit mode. " +
                    "To be able to handle 32-bit TWAIN drivers you will have to target it to 32-bit mode.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void Form1_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            GdPicture14.LicenseManager oLicenseManager = new GdPicture14.LicenseManager();
            oLicenseManager.RegisterKEY("XXX"); //Please, replace XXX by a valid demo or commercial license key.

            txtWorkingDir.Text = Application.StartupPath;
            _backGroundWorker.WorkerReportsProgress = true;
            _backGroundWorker.WorkerSupportsCancellation = false;

            // You can set the language of the Twain UI here by selecting the language and the country you prefer.
            //_gdPictureImaging.TwainSetApplicationInfo(14, 0, TwainLanguage.TWLG_GER, TwainCountry.TWCY_GERMANY, oLicenseManager.GetVersion().ToString(), "Orpalis", "GdPicture", "GdPicture.NET");
        }


        public void m_BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            IntPtr hwnd = IntPtr.Zero; //To enfore the TWAIN controller to create its own windows proxy in the background worker thread.

            if (_gdPictureImaging.TwainSelectSource(hwnd))
            {
                if (_gdPictureImaging.TwainOpenDefaultSource(hwnd))
                {
                    int scanCount = 0;
                    bool useFeeder = chkUseFeeder.Checked;
                    bool duplex = chkDuplex.Checked;
                    bool hideDeviceUI = chkHideGUI.Checked;
                    bool showDeviceProgress = chkEnableIndicator.Checked;
                    bool enableMemoryTransferMode = chkMemTransfer.Checked;

                    _gdPictureImaging.TwainSetHideUI(hideDeviceUI);
                    _gdPictureImaging.TwainSetIndicators(showDeviceProgress);
                    _gdPictureImaging.TwainSelectFeeder(useFeeder);

                    if (useFeeder)
                    {
                        _gdPictureImaging.TwainSetAutoFeed(true);
                        _gdPictureImaging.TwainSetAutoScan(true);
                    }

                    _gdPictureImaging.TwainEnableDuplex(duplex);

                    _gdPictureImaging.TwainEnableMemoryTransferMode(enableMemoryTransferMode);

                    if (enableMemoryTransferMode)
                    {//enabling compression to reach maximum transfer rate.
                        _gdPictureImaging.TwainSetCompression(TwainCompression.TWCP_JPEG);
                    }

                    do
                    {
                        if (!_backGroundWorker.CancellationPending)
                        {
                            int imageId = _gdPictureImaging.TwainAcquireToGdPictureImage(hwnd);

                            if (imageId != 0)
                            {
                                scanCount++;
                                _backGroundWorker.ReportProgress(scanCount, imageId);
                            }
                        }
                        else
                        {
                            break;
                        }
                    } while (_gdPictureImaging.TwainGetState() > TwainStatus.TWAIN_SOURCE_ENABLED);

                    if (scanCount > 0)
                    {
                        MessageBox.Show(scanCount + " page(s) acquired");
                    }
                    else
                    {
                        MessageBox.Show("Operation failed or cancelled. Twain status: " + _gdPictureImaging.TwainGetState().ToString() + "\r\nGdPicture status: " + _gdPictureImaging.GetStat().ToString());
                    }
                    _gdPictureImaging.TwainCloseSource();
                }
                else
                {
                    MessageBox.Show("Unable to open the default TWAIN source. " + '\r' + "Result code: " + _gdPictureImaging.TwainGetLastResultCode() +
                        '\r' + "Condition code: " + _gdPictureImaging.TwainGetLastConditionCode());
                }
            }
            else
            {
                MessageBox.Show("Operation cancelled - no source selected");
            }
            _gdPictureImaging.TwainUnloadSourceManager(hwnd);
        }


        public void m_BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            int imageId = System.Convert.ToInt32(e.UserState);
            int imageNo = e.ProgressPercentage;
            string workingDir = txtWorkingDir.Text;

            //note: here we use 1 thread per image saving to maximize transfer rate.
            Thread t = new Thread(() =>
            {
                using (GdPictureImaging gdpictureImaging = new GdPictureImaging()) //note: it is a good practice to use one GdPictureImaging object per thread.
                {
                    int imageBitDepth = gdpictureImaging.GetBitDepth(imageId);

                    if (imageBitDepth == 1)
                    {
                        string dstPath = workingDir + "\\image" + imageNo + ".tif";

                        GdPictureStatus status = gdpictureImaging.SaveAsTIFF(imageId, dstPath, TiffCompression.TiffCompressionCCITT4);

                        if (status != GdPictureStatus.OK)
                        {
                            MessageBox.Show("Error saving image to " + dstPath + ". Status: " + status);
                        }
                    }
                    else
                    {
                        string dstPath = workingDir + "\\image" + imageNo + ".jpg";
                        GdPictureStatus status = gdpictureImaging.SaveAsJPEG(imageId, dstPath, 75);
                        if (status != GdPictureStatus.OK)
                        {
                            MessageBox.Show("Error saving image to " + dstPath + ". Status: " + status);
                        }
                    }
                    gdpictureImaging.ReleaseGdPictureImage(imageId);
                }
            }
          );
            t.Start();
        }


        public void Button1_Click_1(System.Object sender, System.EventArgs e)
        {
            if (!_backGroundWorker.IsBusy)
            {
                if (chkGenLog.Checked)
                {
                    _gdPictureImaging.TwainLogStart("gdpicture_twain.log");
                }

                _gdPictureImaging.TwainSetModalUI(chkModalUI.Checked);


                if (chkTwain19.Checked)
                {
                    _gdPictureImaging.TwainSetDSMPath("c:\\windows\\twain_32.dll");
                }
                else
                {
                    _gdPictureImaging.TwainSetDSMPath(""); // The latest available DSM will be automatically selected.
                }

                _backGroundWorker.RunWorkerAsync(); // Do the scan.
            }
            else
            {
                MessageBox.Show("Backgroung worker is currently busy!");
            }
        }
    }
}