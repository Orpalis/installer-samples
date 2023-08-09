using System;
using GdPicture14;
using System.Windows.Forms;
using System.Text;


namespace MICR
{
    public partial class frmMain : Form
    {
        private readonly GdPictureImaging _gdPictureImaging = new GdPictureImaging();

        private int _imageId;

        private int _initialImageId;


        public frmMain()
        {
            InitializeComponent();
        }


        public void frmMain_Load(object sender, EventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
            ComboBoxWhiteList.SelectedIndex = 1;
            ComboBoxContext.SelectedIndex = 1;
            ComboBoxFont.SelectedIndex = 1;
        }


        public void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            CloseNativeImage();
            _imageId = _gdPictureImaging.CreateGdPictureImageFromFile("");

            if (_imageId != 0)
            {

                TextBoxResults.Text = "size: " + _gdPictureImaging.GetWidth(_imageId) + " * " + _gdPictureImaging.GetHeight(_imageId) + "\r\n" +
                "resolution: " + _gdPictureImaging.GetHorizontalResolution(_imageId) + " / " + _gdPictureImaging.GetVerticalResolution(_imageId) +
                "\r\n" + "bit depth: " + _gdPictureImaging.GetBitDepth(_imageId);
                _initialImageId = _gdPictureImaging.CreateClonedGdPictureImage(_imageId);
                GdViewer1.DisplayFromGdPictureImage(_imageId);
            }
        }


        public void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            CloseNativeImage();
        }


        private void CloseNativeImage()
        {
            GdViewer1.CloseDocument();
            if (_imageId != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_imageId);
                _imageId = 0;
            }

            if (_initialImageId != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_initialImageId);
            }

        }


        private void Revert()
        {
            if (_imageId != 0 && _initialImageId != 0)
            {
                GdViewer1.CloseDocument();
                _gdPictureImaging.ReleaseGdPictureImage(_imageId);
                _imageId = _gdPictureImaging.CreateClonedGdPictureImage(_initialImageId);
                GdViewer1.DisplayFromGdPictureImage(_imageId);
            }
        }


        public void ToolStripMenuItemAutoDeskew_Click(object sender, EventArgs e)
        {
            _gdPictureImaging.AutoDeskew(_imageId);
            GdViewer1.DisplayFromGdPictureImage(_imageId);
        }


        public void ToolStripMenuItemRotate90_Click(object sender, EventArgs e)
        {
            _gdPictureImaging.Rotate(_imageId, System.Drawing.RotateFlipType.Rotate90FlipNone);
            GdViewer1.DisplayFromGdPictureImage(_imageId);
        }


        public void ToolStripMenuItemResetToInput_Click(object sender, EventArgs e)
        {
            Revert();
        }


        public void ComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFont.SelectedIndex == 1)
            {
                ComboBoxWhiteList.SelectedIndex = 2;
            }
            else
            {
                ComboBoxWhiteList.SelectedIndex = 0;
            }
        }


        public void ToolStripMenuItemStart_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.RemoveAllRegions();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            StringBuilder result = new StringBuilder(_gdPictureImaging.MICRDoMICR(_imageId, (MICRFont)ComboBoxFont.SelectedIndex, 
                (MICRContext)ComboBoxContext.SelectedIndex, ComboBoxWhiteList.Text, (int)NumericUpDownExpectedItems.Value).Length);

            result = result.Replace(System.Convert.ToString('\0'), "?");
            sw.Stop();
            GdPictureStatus status = _gdPictureImaging.GetStat();

            if (status == GdPictureStatus.OK)
            {

                //Drawing bounding boxes
                int count = _gdPictureImaging.MICRGetSymbolsCount();
                float minAcc = 100;
                float maxAcc = 0;
                float accAccumulator = 0;
                int itemsRetained = 0;
                StringBuilder sb = new StringBuilder();


                for (int i = 1; i <= count; i++)
                {
                    float accuracy = _gdPictureImaging.MICRGetSymbolConfidence(i, 1);

                    if (accuracy >= (double)NumericUpDownMinAccuracy.Value)
                    {
                        itemsRetained++;
                        result.Append(_gdPictureImaging.MICRGetSymbolValue(i, 1));
                        minAcc = Math.Min((short)minAcc, (short)accuracy);
                        maxAcc = Math.Max((short)maxAcc, (short)accuracy);

                        accAccumulator += accuracy;
                        GdViewer1.AddRegion(i.ToString(), _gdPictureImaging.MICRGetSymbolLeft(i), _gdPictureImaging.MICRGetSymbolTop(i),
                            _gdPictureImaging.MICRGetSymbolRight(i) - _gdPictureImaging.MICRGetSymbolLeft(i),
                            _gdPictureImaging.MICRGetSymbolBottom(i) - _gdPictureImaging.MICRGetSymbolTop(i),
                            ForegroundMixMode.ForegroundMixModeMASKNOTPEN, System.Drawing.Color.Yellow);
                    }

                }
                GdViewer1.Redraw();
                sb.Append("Count: " + itemsRetained + "\r\n" + "Elapsed: " + Math.Round(sw.Elapsed.TotalMilliseconds, 2) + " ms."
                    + "\r\n" + "Confidence. Min: " + Math.Round(minAcc, 2) + "%. " + "Max: " + Math.Round(maxAcc, 2) + "%. " +
                    "Avg: " + Math.Round(accAccumulator / itemsRetained, 2) + "%. " + "\r\n" + "Result: " + result);

                sb.Append("\r\n" + "\r\n" + "=======================" + "\r\n" + "Details:" + "\r\n" + "=======================" + "\r\n");
                for (int i = 1; i <= count; i++)
                {

                    if (_gdPictureImaging.MICRGetSymbolConfidence(i, 1) >= (double)NumericUpDownMinAccuracy.Value)
                    {

                        string candidate1 = _gdPictureImaging.MICRGetSymbolValue(i, 1);
                        string candidate2 = _gdPictureImaging.MICRGetSymbolValue(i, 2);

                        if (char.Parse(candidate1) == '\0')
                        {
                            candidate1 = "#undef";
                        }

                        if (char.Parse(candidate2) == '\0')
                        {
                            candidate2 = "#undef";
                        }

                        string symbolDetails = "(" + i + ") " + "Candidate 1: \'" + candidate1 + "\' (" + 
                            Math.Round(_gdPictureImaging.MICRGetSymbolConfidence(i, 1), 1) +
                            "%). " + "Candidate 2: \'" + candidate2 + "\' (" +
                            Math.Round(_gdPictureImaging.MICRGetSymbolConfidence(i, 2), 1) + "%).";

                        sb.Append(symbolDetails + "\r\n");
                    }
                }
                TextBoxResults.Text = sb.ToString();
            }
            else
            {
                TextBoxResults.Text = "Error: " + status;
            }
        }
    }
}
