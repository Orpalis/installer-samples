using GdPicture14;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace Segmenter
{
    public partial class Form1 : Form
    {
        private GdPictureImaging _gdPictureImaging;
        private GdPictureSegmenter _gdPictureSegmenter;
        private Document _document;
        private string _resultID;
        private const int PDF_RASTERIZATION_RESOLUTION = 300;
        private readonly string _initialText;


        public Form1()
        {
            InitializeComponent();
            _initialText = Text;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LicenseManager licenseManager = new LicenseManager();
            licenseManager.RegisterKEY("XXX"); //Please replace XXX by a valid demo or commercial key.

            _gdPictureImaging = new GdPictureImaging();
            _gdPictureSegmenter = new GdPictureSegmenter();
            _document = new Document(_gdPictureImaging);
            UpdateControlsDocumentClosed();
            gdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection;
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _document.Close();
                UpdateControlsDocumentClosed();
                gdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
                Cursor.Current = Cursors.WaitCursor;
                bool bSuccess = _document.Load(openFileDialog.FileName, PDF_RASTERIZATION_RESOLUTION);
                Cursor.Current = Cursors.Default;
                if (bSuccess)
                {
                    UpdateControlsDocumentLoaded();
                }
                else
                {
                    MessageBox.Show("Failed to load " + openFileDialog.FileName, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _document.Close();
            UpdateControlsDocumentClosed();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _document.Close();
            UpdateControlsDocumentClosed();
            Close();
        }


        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gdViewer1.ZoomIN();
        }


        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gdViewer1.ZoomOUT();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            gdViewer1.IgnoreDocumentResolution = false;
            gdViewer1.Zoom = 1;
        }


        private void ignoreResolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gdViewer1.IgnoreDocumentResolution = true;
            gdViewer1.Zoom = 1;
        }


        private void rotateRight90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.Rotate(_document.ImageId,
                    RotateFlipType.Rotate90FlipNone);
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void rotateLeft90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.Rotate(_document.ImageId,
                    RotateFlipType.Rotate270FlipNone);
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.Rotate(_document.ImageId,
                    RotateFlipType.Rotate180FlipNone);
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void deskewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.AutoDeskew(_document.ImageId);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void StartSegmentation(SegmentationMode segMode)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    Stopwatch stopWatch = new Stopwatch();

                    ReleaseResult();

                    int roiLeft = 0,
                        roiTop = 0,
                        roiWidth = _gdPictureImaging.GetWidth(_document.ImageId),
                        roiHeight = _gdPictureImaging.GetHeight(_document.ImageId);
                    if (gdViewer1.IsRect())
                    {
                        gdViewer1.GetRectCoordinatesOnDocument(ref roiLeft, ref roiTop, ref roiWidth, ref roiHeight);
                    }

                    _gdPictureSegmenter.SetROI(roiLeft, roiTop, roiWidth, roiHeight);

                    _gdPictureSegmenter.SegmentationMode = segMode;
                    stopWatch.Start();
                    _resultID = _gdPictureSegmenter.RunSegmentation();
                    stopWatch.Stop();
                    GdPictureStatus status = _gdPictureSegmenter.GetStat();

                    if (status == GdPictureStatus.OK)
                    {
                        this.Text = _initialText + " - Elapsed: " + Math.Round(stopWatch.Elapsed.TotalMilliseconds, 1).ToString() + " ms.";
                    }
                    else
                    {
                        this.Text = _initialText;
                        MessageBox.Show("An error occured. Status: " + status.ToString());
                    }
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }

                UpdateControlsSegmentationResultCreated();
            }
        }


        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartSegmentation(SegmentationMode.PageLayout);
        }


        private void connectedComponents4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blocksToolStripMenuItem.Checked = true;
            StartSegmentation(SegmentationMode.ConnectedComponents4);
        }


        private void connectedComponents8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blocksToolStripMenuItem.Checked = true;
            StartSegmentation(SegmentationMode.ConnectedComponents8);
        }


        private void fastMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordsToolStripMenuItem.Checked = true;
            charactersToolStripMenuItem.Checked = true;
            string wordValue = Microsoft.VisualBasic.Interaction.InputBox("Please enter the word value", "Word value", _gdPictureSegmenter.InputValue);

            if (!string.IsNullOrWhiteSpace(wordValue))
            {
                _gdPictureSegmenter.InputValue = wordValue;
                StartSegmentation(SegmentationMode.WordLayout);
            }
        }


        private void lKMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordsToolStripMenuItem.Checked = true;
            charactersToolStripMenuItem.Checked = true;

            string wordValue = Microsoft.VisualBasic.Interaction.InputBox("Please enter the word value", "Word value", _gdPictureSegmenter.InputValue);

            if (!string.IsNullOrWhiteSpace(wordValue))
            {
                _gdPictureSegmenter.InputValue = wordValue;
                StartSegmentation(SegmentationMode.WordLayoutLK);
            }
        }


        private void blocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }


        private void paragraphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }


        private void textLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }


        private void wordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }


        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }


        private void DisplayBoxes()
        {
            Utilities.MarkRegions(_gdPictureSegmenter, _resultID, gdViewer1,
                                   blocksToolStripMenuItem.Checked,
                                   paragraphsToolStripMenuItem.Checked,
                                   textLinesToolStripMenuItem.Checked,
                                   wordsToolStripMenuItem.Checked,
                                   charactersToolStripMenuItem.Checked,
                                   chkShowText.Checked,
                                   chkShowBitmap.Checked,
                                   chkShowLines.Checked,
                                   _gdPictureImaging.GetHorizontalResolution(_document.ImageId),
                                   _gdPictureImaging.GetVerticalResolution(_document.ImageId));
        }


        private void DisplayError(GdPictureStatus errorCode)
        {
            MessageBox.Show("The operation failed with error code " + errorCode.ToString(), "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }


        private void UpdateControlsSegmentationResultCreated()
        {
            DisplayBoxes();
        }


        private void UpdateControlsSegmentationResultDiscarded()
        {
            gdViewer1.RemoveAllRegions();
        }


        private void UpdateControlsDocumentLoaded()
        {
            gdViewer1.DisplayFromGdPictureImage(_document.ImageId);

            closeToolStripMenuItem.Enabled = true;
            viewToolStripMenuItem.Enabled = true;
            rotateToolStripMenuItem.Enabled = true;
            imageEnhancementToolStripMenuItem.Enabled = true;
            SegmentationToolStripMenuItem.Enabled = true;
            UpdateImageInfo();
        }


        private void UpdateControlsDocumentClosed()
        {
            this.Text = _initialText;
            UpdateControlsSegmentationResultDiscarded();
            gdViewer1.CloseDocument();

            closeToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;
            rotateToolStripMenuItem.Enabled = false;
            imageEnhancementToolStripMenuItem.Enabled = false;
            SegmentationToolStripMenuItem.Enabled = false;
            UpdateImageInfo();
        }


        private void bitonalDespeckleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                if (_gdPictureImaging.GetBitDepth(_document.ImageId) != 1)
                {
                    MessageBox.Show("This operation can be performed  on 1bpp image only.");
                    return;
                }

                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.FxBitonalDespeckleAdvanced(_document.ImageId, DespeckleType.FourConnected, 5);

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void scaleTo300DPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.Scale(_document.ImageId, (300F / _gdPictureImaging.GetVerticalResolution(_document.ImageId)) * 100, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void scaleTo200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.Scale(_document.ImageId, 200, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void eraseBlackBordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.DeleteBlackBorders(_document.ImageId, 0, false);

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void removePunchHolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.RemoveHolePunch(_document.ImageId);

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void automaticCleanupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.RemoveHolePunch(_document.ImageId);

                if (errorCode == GdPictureStatus.OK)
                {
                    errorCode = _gdPictureImaging.DeleteBlackBorders(_document.ImageId, 0, false);
                    if (errorCode == GdPictureStatus.OK)
                    {
                        errorCode = _gdPictureImaging.AutoDeskew(_document.ImageId);

                        //todo: implement a correct generic despeckle.
                    }
                }

                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void sauvolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.ConvertTo1BppSauvola(_document.ImageId, 0.35F);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void otsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.ConvertTo1BppAT(_document.ImageId, 50);

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void bradleyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.ConvertTo1BppBradley(_document.ImageId, 38);

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void wanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.ConvertTo1BppWAN(_document.ImageId, 51);

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                ReleaseResult();
                UpdateControlsSegmentationResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.FxDespeckle(_document.ImageId);

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                UpdateImageInfo();
            }
        }


        private void UpdateImageInfo()
        {
            if (_document.IsOpen)
            {
                gdViewer1.ClearRect();
                gdViewer1.Redraw();
                _gdPictureSegmenter.SetImage(_document.ImageId);
                tsImageInfo.Text = "Image properties :: width: " + _gdPictureImaging.GetWidth(_document.ImageId).ToString() + "." +
                                   " height: " + _gdPictureImaging.GetHeight(_document.ImageId).ToString() + "." +
                                   " horizontal resolution: " + _gdPictureImaging.GetHorizontalResolution(_document.ImageId).ToString() + " dpi." +
                                   " vertical resolution: " + _gdPictureImaging.GetVerticalResolution(_document.ImageId).ToString() + " dpi." +
                                   " bit depth: " + _gdPictureImaging.GetBitDepth(_document.ImageId) + " bpp.";
            }
            else
            {
                tsImageInfo.Text = "";
            }
        }


        private void ReleaseResult()
        {
            if (!string.IsNullOrWhiteSpace(_resultID))
            {
                _gdPictureSegmenter.ReleaseSegmentationResult(_resultID);
                _resultID = null;
            }
        }


        private void chkShowBitmap_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }


        private void chkShowText_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }


        private void chkShowLines_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }
    }
}