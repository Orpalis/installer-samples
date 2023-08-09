using GdPicture14;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Image_Processing
{
    public partial class FrmMain
    {
        private void frmMain_Load(object sender, EventArgs e)
        {
            LicenseManager oLicenceManager = new LicenseManager();
            oLicenceManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            tcLeftPanel.Appearance = TabAppearance.FlatButtons;
            tcLeftPanel.ItemSize = new Size(0, 1);
            tcLeftPanel.SizeMode = TabSizeMode.Fixed;
            SelectSnapIn(1, "Image properties");

            Dictionary<ZoomMode, string> zoomModes = new Dictionary<ZoomMode, string>
            {
                {ZoomMode.Zoom50, "50%"},
                {ZoomMode.Zoom100, "100%"},
                {ZoomMode.Zoom150, "150%"},
                {ZoomMode.Zoom200, "200%"},
                {ZoomMode.ZoomSelectedArea, "Zoom to selected area"},
                {ZoomMode.ZoomFitToViewer, "Fit to viewer"},
                {ZoomMode.ZoomFitWidth, "Fit to viewer width"},
                {ZoomMode.ZoomFitHeight, "Fit to viewer height"}
            };
            foreach (var item in zoomModes)
            {
                cbZoom.Items.Add(item.Value);
            }

            foreach (var item in _interPolationModes)
            {
                cbResampling.Items.Add(item.Value);
            }
            cbResampling.SelectedIndex = 6;

            foreach (var item in _pixelConversions)
            {
                cbPixelConversion.Items.Add(item.Value);
            }
            cbPixelConversion.SelectedIndex = -1;

            foreach (var item in _swapColors)
            {
                cbSwapColor.Items.Add(item.Value);
            }
            cbSwapColor.SelectedIndex = -1;

            foreach (var item in _directEffects)
            {
                cbDirectEffects.Items.Add(item.Value);
            }
            cbDirectEffects.SelectedIndex = -1;

            foreach (var item in _configurableEffects)
            {
                cbConfigurableEffects.Items.Add(item.Value);
            }
            cbConfigurableEffects.SelectedIndex = -1;

            foreach (var item in _convolutionMatrixFilters)
            {
                cbConvolutionMatrix.Items.Add(item.Value);
            }
            cbConvolutionMatrix.SelectedIndex = -1;

            UpdateMainUi();
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private enum ZoomMode
        {
            Zoom50,
            Zoom100,
            Zoom150,
            Zoom200,
            ZoomSelectedArea,
            ZoomFitToViewer,
            ZoomFitWidth,
            ZoomFitHeight
        }

        private readonly Dictionary<InterpolationMode, string> _interPolationModes = new Dictionary<InterpolationMode, string>
        {
            {InterpolationMode.Low, "Low"},
            {InterpolationMode.High, "High"},
            {InterpolationMode.Bilinear, "Bilinear"},
            {InterpolationMode.Bicubic, "Bicubic"},
            {InterpolationMode.NearestNeighbor, "Nearest Neighbor"},
            {InterpolationMode.HighQualityBilinear, "High Quality Bilinear"},
            {InterpolationMode.HighQualityBicubic, "High Quality Bicubic"}
        };

        private readonly Dictionary<int, string> _pixelConversions = new Dictionary<int, string>
        {
            {0, "1-bit per pixel (Linear)"},
            {1, "1-bit per pixel (Adaptive)"},
            {2, "1-bit per pixel (Nearest color)"},
            {3, "1-bit per pixel (Ordered dither)"},
            {4, "1-bit per pixel (Burke)"},
            {5, "1-bit per pixel (Stucki)"},
            {6, "1-bit per pixel (Floyd Steinberg)"},
            {7, "1-bit per pixel (Sauvola)"},
            {8, "1-bit per pixel (Bradley)"},
            {9, "4-bits per pixel (Indexed)"},
            {10, "4-bits per pixel (Quantized)"},
            {11, "8-bits per pixel (Grayscale)"},
            {12, "8-bits per pixel (Color)"},
            {13, "16-bits per pixel (RGB555)"},
            {14, "16-bits per pixel (RGB565)"},
            {15, "24-bits per pixel (RGB)"},
            {16, "32-bits per pixel (RGB)"},
            {17, "32-bits per pixel (ARGB)"},
            {18, "32-bits per pixel (PARGB)"},
            {19, "48-bits per pixel (RGB)"},
            {20, "64-bits per pixel (ARGB)"},
            {21, "64-bits per pixel (PARGB)"}
        };

        private readonly Dictionary<int, string> _swapColors = new Dictionary<int, string>
        {
            {0, "RGB to BGR"},
            {1, "RGB to BRG"},
            {2, "RGB to GBR"},
            {3, "RGB to GRB"},
            {4, "RGB to RBG"}
        };

        private readonly Dictionary<int, string> _directEffects = new Dictionary<int, string>
        {
            {0, "Add noise"},
            {1, "Aqua"},
            {2, "Blur"},
            {3, "Connected contour"},
            {4, "Contour"},
            {5, "Diffuse"},
            {6, "Diffuse more"},
            {7, "Dilate"},
            {8, "Edge detect (Prewitt)"},
            {9, "Edge detect (Sobel)"},
            {10, "Edge enhance"},
            {11, "Emboss"},
            {12, "Emboss more"},
            {13, "Engrave"},
            {14, "Engrave more"},
            {15, "Equalize intensity"},
            {16, "Erode"},
            {17, "Fire"},
            {18, "Grayscale"},
            {19, "Mirror rounded"},
            {20, "Negative"},
            {21, "Pixelize"},
            {22, "Red eyes correction"},
            {23, "Relief"},
            {24, "Scan line"},
            {25, "Sepia"},
            {26, "Sharpen"},
            {27, "Sharpen more"},
            {28, "Smooth"},
            {29, "Stretch contrast"}
        };

        private readonly Dictionary<int, string> _configurableEffects = new Dictionary<int, string>
        {
            {0, "Colorize"},
            {1, "Flood fill"},
            {2, "Gaussian blur"},
            {3, "Halo"},
            {4, "Max"},
            {5, "Median"},
            {6, "Min"},
            {7, "Remove background chromakey"},
            {8, "Soften"},
            {9, "Substract background"},
            {10, "Swirl"},
            {11, "Twirl"},
            {12, "Waves (horizontal)"},
            {13, "Waves (vertical)"}
        };

        private readonly Dictionary<int, string> _convolutionMatrixFilters = new Dictionary<int, string> {
            {0, "Sharpen"},
            {1, "Blur"},
            {2, "Edge Enhance"},
            {3, "Edge Detect"},
            {4, "Emboss"}
        };

        private readonly GdPictureImaging _gdPictureImaging = new GdPictureImaging();
        private int _currentImage;
        private int _currentAdjustmentPreview;
        private int _currentRotationPreview;
        private int _currentColorChannelsPreview;
        private int _currentEffectsPreview;

        private void UpdateMainUi()
        {
            Text = "GdPicture.NET " + typeof(GdPictureImaging).Assembly.GetName().Version + " - Image Processing Demo";
            if (GdViewer1.PageCount == 0)
            {
                btnClose.Enabled = false;
                btnPrint.Enabled = false;
                btnSave.Enabled = false;
                btnCopyToClipboard.Enabled = false;
                btnFirstPage.Enabled = false;
                btnPreviousPage.Enabled = false;
                tbCurrentPage.Enabled = false;
                lblPageCount.Enabled = false;
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
                btnZoomOut.Enabled = false;
                cbZoom.Enabled = false;
                btnZoomIn.Enabled = false;
                btnFitPage.Enabled = false;
                btnFitWidth.Enabled = false;
                cbZoom.SelectedIndex = -1;
                tbCurrentPage.Text = "0";
                lblPageCount.Text = "/ 0";
                rotationPeviewViewer.Visible = false;
                adjustPeviewViewer.Enabled = false;
                pTransform.Enabled = false;
                pAdjustment.Enabled = false;
                pImageProperties.Enabled = false;
                pColorOperations.Enabled = false;
                lblImageInfo.Text = "Ready";
                cbPixelConversion.SelectedIndex = -1;
                cbResampling.SelectedIndex = 6;
                pEffects.Enabled = false;
            }
            else
            {
                btnClose.Enabled = true;
                btnPrint.Enabled = true;
                btnSave.Enabled = true;
                btnCopyToClipboard.Enabled = true;
                btnFirstPage.Enabled = true;
                btnPreviousPage.Enabled = true;
                tbCurrentPage.Enabled = true;
                lblPageCount.Enabled = true;
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
                btnZoomOut.Enabled = true;
                cbZoom.Enabled = true;
                btnZoomIn.Enabled = true;
                btnFitPage.Enabled = true;
                btnFitWidth.Enabled = true;
                UpdateaNavigationToolbar();
                pTransform.Enabled = true;
                pAdjustment.Enabled = true;
                pImageProperties.Enabled = true;
                pColorOperations.Enabled = true;
                pEffects.Enabled = true;
            }
            ResetAdjustmentValues();
            PopulateImageProperties();
            ResetSizeValues();
            ResetRotationValues();
            ResetColorOperationsValues();
            ResetEffectsValues();
        }

        private void UpdateaNavigationToolbar()
        {
            int currentPage = GdViewer1.CurrentPage;
            tbCurrentPage.Text = currentPage.ToString();
            lblPageCount.Text = "/ " + GdViewer1.PageCount;
            if (currentPage == 1)
            {
                btnFirstPage.Enabled = false;
                btnPreviousPage.Enabled = false;
            }
            else
            {
                btnFirstPage.Enabled = true;
                btnPreviousPage.Enabled = true;
            }
            if (currentPage == GdViewer1.PageCount)
            {
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
            }
            else
            {
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
            }
            cbZoom.Text = string.Format(CultureInfo.InvariantCulture, "{0:#0.##%}", GdViewer1.Zoom);

            lblImageInfo.Text = "Horizontal resolution: " + (Math.Round(GdViewer1.HorizontalResolution, 2)).ToString().Trim() + " DPI  -  " +
                "Vertical resolution: " + (Math.Round(GdViewer1.VerticalResolution, 2)).ToString().Trim() + " DPI";

            lblImageSize.Text = (_gdPictureImaging.GetWidth(_currentImage)).ToString().Trim() + " × " + (_gdPictureImaging.GetHeight(_currentImage)).ToString().Trim();
        }

        private void CloseDocument()
        {
            GdViewer1.CloseDocument();
            ThumbnailEx1.LoadFromGdViewer(GdViewer1);
            if (_currentImage != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_currentImage);
                _currentImage = 0;
            }
            if (_currentAdjustmentPreview != 0)
            {
                rotationPeviewViewer.Image = null;
                _gdPictureImaging.ReleaseGdPictureImage(_currentAdjustmentPreview);
                _currentAdjustmentPreview = 0;
            }
            if (_currentRotationPreview != 0)
            {
                adjustPeviewViewer.Image = null;
                _gdPictureImaging.ReleaseGdPictureImage(_currentRotationPreview);
                _currentRotationPreview = 0;
            }
            if (_currentColorChannelsPreview != 0)
            {
                colorChannelPreviewViewer.Image = null;
                _gdPictureImaging.ReleaseGdPictureImage(_currentColorChannelsPreview);
                _currentColorChannelsPreview = 0;
            }
            if (_currentEffectsPreview != 0)
            {
                GdViewer2.CloseDocument();
                _gdPictureImaging.ReleaseGdPictureImage(_currentEffectsPreview);
                _currentEffectsPreview = 0;
            }
            UpdateMainUi();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            CloseDocument();

            GdViewer1.ZoomMode = ViewerZoomMode.ZoomMode100;
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter;

            _currentImage = _gdPictureImaging.CreateGdPictureImageFromFile("");
            GdPictureStatus status = _gdPictureImaging.GetStat();
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show(this, "Cannot open file : " + status, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (_currentImage != 0)
            {
                GdViewer1.DisplayFromGdPictureImage(_currentImage);
                ThumbnailEx1.LoadFromGdViewer(GdViewer1);
                GdViewer1.Focus();
            }
            UpdateMainUi();
        }

        private void GdViewer1_PageChanged()
        {
            UpdateaNavigationToolbar();
            if (tcLeftPanel.SelectedTab == tpAdjustment)
            {
                ResetAdjustmentValues();
            }
            else if (tcLeftPanel.SelectedTab == tpColorOperations)
            {
                ResetColorOperationsValues();
            }
            else if (tcLeftPanel.SelectedTab == tpEffects)
            {
                ResetEffectsValues();
            }
            else if (tcLeftPanel.SelectedTab == tpTransform)
            {
                ResetRotationValues();
                ResetSizeValues();
            }
        }

        private void ChangeZoomValue()
        {
            if (cbZoom.SelectedIndex != -1)
            {
                switch (((ZoomMode)cbZoom.SelectedIndex))
                {
                    case ZoomMode.Zoom50:
                        GdViewer1.Zoom = 50.0F / 100;
                        break;
                    case ZoomMode.Zoom100:
                        GdViewer1.Zoom = 100.0F / 100;
                        break;
                    case ZoomMode.Zoom150:
                        GdViewer1.Zoom = 150.0F / 100;
                        break;
                    case ZoomMode.Zoom200:
                        GdViewer1.Zoom = 250.0F / 100;
                        break;
                    case ZoomMode.ZoomSelectedArea:
                        if (GdViewer1.IsRect())
                        {
                            GdViewer1.ZoomRect();
                        }
                        else
                        {
                            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection;
                            GdViewer1.Focus();
                        }
                        break;
                    case ZoomMode.ZoomFitToViewer:
                        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
                        break;
                    case ZoomMode.ZoomFitWidth:
                        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
                        break;
                    case ZoomMode.ZoomFitHeight:
                        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeHeightViewer;
                        break;
                }
            }
            else
            {
                float zoom;
                if (float.TryParse(Regex.Replace(cbZoom.Text, "[^0-9,.]", ""), out zoom))
                {
                    GdViewer1.Zoom = zoom;
                }
            }
            UpdateaNavigationToolbar();
        }

        private void cbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeZoomValue();
        }

        private void GdViewer1_AfterZoomChange()
        {
            UpdateaNavigationToolbar();
            if (GdViewer1.MouseMode == ViewerMouseMode.MouseModeAreaZooming)
            {
                GdViewer1.MouseMode = ViewerMouseMode.MouseModePan;
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomOUT();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomIN();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (frmAbout frmAbout = new frmAbout())
            {
                frmAbout.ShowDialog(this);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (GdViewer1.PageCount == 0)
            {
                return;
            }
            using (frmPrint f = new frmPrint(GdViewer1))
            {
                f.ShowDialog(this);
                if (f.DialogResult != DialogResult.OK)
                {
                    return;
                }
                frmPrint.PrintSettings printSettings = f.printConfiguration;
                if (!GdViewer1.PrintSetActivePrinter(printSettings.Printer))
                {
                    return;
                }
                GdViewer1.PrintSetDocumentName("GdPicture Print Job " + DateTime.Now.ToString("yyyy-MM-dd HH\\mm"));
                GdViewer1.PrintSetAlignment(printSettings.PrintAlignment);
                switch (printSettings.Orientation)
                {
                    case frmPrint.PrintOrientation.AutoDetection:
                        GdViewer1.PrintSetAutoRotation(true);
                        break;
                    case frmPrint.PrintOrientation.Portrait:
                        GdViewer1.PrintSetAutoRotation(false);
                        GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationPortrait);
                        break;
                    case frmPrint.PrintOrientation.Paysage:
                        GdViewer1.PrintSetAutoRotation(false);
                        GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationLandscape);
                        break;
                }
                GdViewer1.PrintSetCopies(printSettings.Copies);
                if (printSettings.Copies > 1)
                {
                    GdViewer1.PrintSetCollate(printSettings.Collate);
                }
                switch (printSettings.PagesToPrint)
                {
                    case frmPrint.PagesToPrint.All:
                        GdViewer1.PrintSetFromToPage(1, GdViewer1.PageCount);
                        GdViewer1.Print(printSettings.PrintSize);
                        break;
                    case frmPrint.PagesToPrint.Current:
                        GdViewer1.PrintSetFromToPage(GdViewer1.CurrentPage, GdViewer1.CurrentPage);
                        GdViewer1.Print(printSettings.PrintSize);
                        break;
                    case frmPrint.PagesToPrint.Selection:
                        string range = GetSelectedItemAsRange();
                        if (!string.IsNullOrWhiteSpace(range))
                        {
                            GdViewer1.PrintSetPageSelection(range);
                            GdViewer1.Print(printSettings.PrintSize);
                        }
                        break;
                    case frmPrint.PagesToPrint.Range:
                        if (!string.IsNullOrEmpty(printSettings.PageRange))
                        {
                            if (printSettings.PageRange.Contains("-"))
                            {
                                int pageStart = 0;
                                if (int.TryParse(Convert.ToString(printSettings.PageRange.Split('-')[0]), out pageStart))
                                {
                                    int pageEnd = 0;
                                    if (int.TryParse(Convert.ToString(printSettings.PageRange.Split('-')[1]), out pageEnd))
                                    {
                                        if (pageEnd < pageStart)
                                        {
                                            GdViewer1.PrintSetFromToPage(pageEnd, pageStart);
                                            GdViewer1.Print(printSettings.PrintSize);
                                        }
                                        else
                                        {
                                            GdViewer1.PrintSetFromToPage(pageStart, pageEnd);
                                            GdViewer1.Print(printSettings.PrintSize);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                int page = 0;
                                if (int.TryParse(printSettings.PageRange, out page))
                                {
                                    GdViewer1.PrintSetFromToPage(page, page);
                                    GdViewer1.Print(printSettings.PrintSize);
                                }
                                else
                                {
                                    MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
        }

        private void cbZoom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ChangeZoomValue();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseDocument();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (frmSettings frmSettings = new frmSettings(GdViewer1))
            {
                frmSettings.ShowDialog(this);
            }

            ThumbnailEx1.PdfIncreaseTextContrast = GdViewer1.PdfIncreaseTextContrast;
            UpdateaNavigationToolbar();
        }

        private void btnFitWidth_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
        }

        private void btnFitPage_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
        }

        private void SelectSnapIn(int num, string title)
        {
            tcLeftPanel.SelectedIndex = num;
            lblSnapInPanel.Text = title;
            for (int i = 0; i <= pSnapInButtons.Controls.Count - 1; i++)
            {
                if (i == num)
                {
                    pSnapInButtons.Controls[i].BackColor = SystemColors.Control;
                    ((Button)(pSnapInButtons.Controls[i])).FlatAppearance.BorderColor = SystemColors.Control;
                }
                else
                {
                    pSnapInButtons.Controls[i].BackColor = SystemColors.AppWorkspace;
                    ((Button)(pSnapInButtons.Controls[i])).FlatAppearance.BorderColor = SystemColors.AppWorkspace;
                }
            }
        }

        private void btnSnapInImageProperties_Click(object sender, EventArgs e)
        {
            SelectSnapIn(1, "Image properties");
        }

        private void btnSnapInAdjustment_Click(object sender, EventArgs e)
        {
            CreateAdjustmentPreviewImage();
            DisplayAdjustmentPreviewImage();
            SelectSnapIn(2, "Adjustment");
        }

        private void btnSnapInTransform_Click(object sender, EventArgs e)
        {
            CreateRotationPreviewImage();
            DisplayRotationPreviewImage();
            SelectSnapIn(3, "Transform");
        }

        private void btnSnapInColorOperations_Click(object sender, EventArgs e)
        {
            CreateColorChannelsPreviewImage();
            DisplayColorChannelsPreviewImage();
            SelectSnapIn(4, "Color operations");
        }

        private void btnSnapInEffects_Click(object sender, EventArgs e)
        {
            CreateEffectsPreviewImage();
            DisplayEffectsPreviewImage();
            SelectSnapIn(5, "Effects");
        }

        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeDefault;
            DefaultToolStripMenuItem.Checked = true;
            AreaSelectionToolStripMenuItem.Checked = false;
            PanToolStripMenuItem.Checked = false;
            AreaZoomingToolStripMenuItem.Checked = false;
            MagnifierToolStripMenuItem.Checked = false;
            GdViewer1.Focus();
        }

        private void AreaSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection;
            DefaultToolStripMenuItem.Checked = false;
            AreaSelectionToolStripMenuItem.Checked = true;
            PanToolStripMenuItem.Checked = false;
            AreaZoomingToolStripMenuItem.Checked = false;
            MagnifierToolStripMenuItem.Checked = false;
            GdViewer1.Focus();
        }

        private void PanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModePan;
            DefaultToolStripMenuItem.Checked = false;
            AreaSelectionToolStripMenuItem.Checked = false;
            PanToolStripMenuItem.Checked = true;
            AreaZoomingToolStripMenuItem.Checked = false;
            MagnifierToolStripMenuItem.Checked = false;
            GdViewer1.Focus();
        }

        private void AreaZoomingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming;
            DefaultToolStripMenuItem.Checked = false;
            AreaSelectionToolStripMenuItem.Checked = false;
            PanToolStripMenuItem.Checked = false;
            AreaZoomingToolStripMenuItem.Checked = true;
            MagnifierToolStripMenuItem.Checked = false;
            GdViewer1.Focus();
        }

        private void MagnifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeMagnifier;
            DefaultToolStripMenuItem.Checked = false;
            AreaSelectionToolStripMenuItem.Checked = false;
            PanToolStripMenuItem.Checked = false;
            AreaZoomingToolStripMenuItem.Checked = false;
            MagnifierToolStripMenuItem.Checked = true;
            GdViewer1.Focus();
        }

        private void tbBrightness_ValueChanged(object sender, EventArgs e)
        {
            lblBrightness.Text = tbBrightness.Value.ToString();
            ChangeAdjustementValues();
        }

        private void tbContrast_ValueChanged(object sender, EventArgs e)
        {
            lblContrast.Text = tbContrast.Value.ToString();
            ChangeAdjustementValues();
        }

        private void tbSaturation_ValueChanged(object sender, EventArgs e)
        {
            lblSaturation.Text = tbSaturation.Value.ToString();
            ChangeAdjustementValues();
        }

        private void tbGamma_ValueChanged(object sender, EventArgs e)
        {
            lblGamma.Text = tbGamma.Value.ToString();
            ChangeAdjustementValues();
        }

        private void tbRed_ValueChanged(object sender, EventArgs e)
        {
            lblRed.Text = tbRed.Value.ToString();
            ChangeAdjustementValues();
        }

        private void tbGreen_ValueChanged(object sender, EventArgs e)
        {
            lblGreen.Text = tbGreen.Value.ToString();
            ChangeAdjustementValues();
        }

        private void tbBlue_ValueChanged(object sender, EventArgs e)
        {
            lblBlue.Text = tbBlue.Value.ToString();
            ChangeAdjustementValues();
        }

        private void ResetAdjustmentValues()
        {
            tbBrightness.Value = 0;
            tbContrast.Value = 0;
            tbSaturation.Value = 0;
            tbGamma.Value = 0;
            tbRed.Value = 0;
            tbGreen.Value = 0;
            tbBlue.Value = 0;
            ChangeAdjustementValues();
        }

        private void ChangeAdjustementValues()
        {
            CreateAdjustmentPreviewImage();
            if (_currentAdjustmentPreview == 0) return;
            if (_gdPictureImaging.SetBCSG(_currentAdjustmentPreview, tbBrightness.Value, tbContrast.Value, tbSaturation.Value, tbGamma.Value) == GdPictureStatus.OK)
            {
                _gdPictureImaging.AdjustRGB(_currentAdjustmentPreview, tbRed.Value, tbGreen.Value, tbBlue.Value);
            }
            DisplayAdjustmentPreviewImage();
        }

        private void CreateAdjustmentPreviewImage()
        {
            if (_currentImage == 0)
            {
                return;
            }
            if (_currentAdjustmentPreview != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_currentAdjustmentPreview);
                adjustPeviewViewer.Image = null;
                _currentAdjustmentPreview = 0;
            }
            _currentAdjustmentPreview = _gdPictureImaging.CreateThumbnailHQ(_currentImage, adjustPeviewViewer.Width, adjustPeviewViewer.Height, Color.Transparent);
        }

        private void DisplayAdjustmentPreviewImage()
        {
            if (_currentAdjustmentPreview != 0)
            {
                adjustPeviewViewer.Image = _gdPictureImaging.GetBitmapFromGdPictureImage(_currentAdjustmentPreview);
                adjustPeviewViewer.Visible = true;
            }
            else
            {
                adjustPeviewViewer.Visible = false;
            }
        }

        private void pAdjustPreview_Resize(object sender, EventArgs e)
        {
            ChangeAdjustementValues();
        }

        private void btnApplyAdjustment_Click(object sender, EventArgs e)
        {
            if (_currentImage == 0) return;
            if (
                _gdPictureImaging.SetBCSG(_currentImage, tbBrightness.Value, tbContrast.Value, tbSaturation.Value,
                    tbGamma.Value) != GdPictureStatus.OK) return;
            if (_gdPictureImaging.AdjustRGB(_currentImage, tbRed.Value, tbGreen.Value, tbBlue.Value) !=
                GdPictureStatus.OK) return;
            GdViewer1.Redraw();
            CreateAdjustmentPreviewImage();
            ResetAdjustmentValues();
        }

        private void btnResetAdjustment_Click(object sender, EventArgs e)
        {
            ResetAdjustmentValues();
        }

        private void btnImportFromClipboard_Click(object sender, EventArgs e)
        {
            CloseDocument();
            _currentImage = _gdPictureImaging.CreateGdPictureImageFromClipboard();
            if (_currentImage == 0)
            {
                MessageBox.Show("There is no bitmap in the clipboard");
            }
            else
            {
                GdViewer1.DisplayFromGdPictureImage(_currentImage);
            }
            UpdateMainUi();
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            _gdPictureImaging.CopyToClipboard(_currentImage);
        }

        private void PopulateImageProperties()
        {
            tvImageProperties.Nodes.Clear();
            if (_currentImage == 0)
            {
                return;
            }

            TreeNode tnGlobals = new TreeNode("Globals properties");
            tnGlobals.Nodes.Add("Bit depth: " + _gdPictureImaging.GetBitDepth(_currentImage));
            tnGlobals.Nodes.Add("Height: " + _gdPictureImaging.GetHeight(_currentImage) + " px");
            tnGlobals.Nodes.Add("Width: " + _gdPictureImaging.GetWidth(_currentImage) + " px");
            tnGlobals.Nodes.Add("Height: " + _gdPictureImaging.GetHeightInches(_currentImage) + " inches");
            tnGlobals.Nodes.Add("Width: " + _gdPictureImaging.GetWidthInches(_currentImage) + " inches");
            tnGlobals.Nodes.Add("Color space: " + _gdPictureImaging.GetImageColorSpace(_currentImage).ToString().Replace("ImageColorSpace", ""));
            tnGlobals.Nodes.Add("Image format: " + _gdPictureImaging.GetImageFormat(_currentImage).ToString().Replace("DocumentFormat", ""));
            tnGlobals.Nodes.Add("Pixel format: " + _gdPictureImaging.GetPixelFormat(_currentImage).ToString().Replace("Format", ""));
            tnGlobals.Nodes.Add("Tiff compression: " + _gdPictureImaging.GetTiffCompression(_currentImage).ToString().Replace("TiffCompression", ""));
            tnGlobals.Nodes.Add("Horizontal resolution: " + _gdPictureImaging.GetHorizontalResolution(_currentImage) + " DPI");
            tnGlobals.Nodes.Add("Vertical resolution: " + _gdPictureImaging.GetVerticalResolution(_currentImage) + " DPI");
            tnGlobals.Nodes.Add("Pixel format has alpha component: " + _gdPictureImaging.IsPixelFormatHasAlpha(_currentImage));
            tnGlobals.Nodes.Add("Pixel format is indexed: " + _gdPictureImaging.IsPixelFormatIndexed(_currentImage));
            tvImageProperties.Nodes.Add(tnGlobals);
            tnGlobals.Expand();

            TreeNode tnExifs = new TreeNode("EXIF tags");
            for (var i = 1; i <= _gdPictureImaging.TagCount(_currentImage); i++)
            {
                TreeNode tnExifTag = new TreeNode(_gdPictureImaging.TagGetName(_currentImage, Convert.ToInt32(i)) + ": " + _gdPictureImaging.TagGetValueString(_currentImage, Convert.ToInt32(i)));
                tnExifs.Nodes.Add(tnExifTag);
            }
            tvImageProperties.Nodes.Add(tnExifs);

            TreeNode tnIptc = new TreeNode("IPTC tags");
            for (var i = 1; i <= _gdPictureImaging.IPTCCount(_currentImage); i++)
            {
                TreeNode tnIptcTag = new TreeNode(_gdPictureImaging.IPTCGetID(_currentImage, Convert.ToInt32(i)) + ": " + _gdPictureImaging.IPTCGetValueString(_currentImage, Convert.ToInt32(i)));
                tnIptc.Nodes.Add(tnIptcTag);
            }
            tvImageProperties.Nodes.Add(tnIptc);
        }

        private void GdViewer1_MouseMove(object sender, MouseEventArgs e)
        {
            lblMousePosition.Text = GdViewer1.GetMouseLeftInDocument() + ", " + Convert.ToString(GdViewer1.GetMouseTopInDocument());
        }

        private void ResetSizeValues()
        {
            nWidth.Value = 1;
            nHeight.Value = 1;
            nDocumentWidth.Value = 1;
            nDocumentHeight.Value = 1;
            nHorizontalResolution.Value = 1;
            nVerticalResolution.Value = 1;
            nScalePercent.Value = 100;
            chkKeepAspectRatio.Checked = true;
            cbResampling.SelectedIndex = 6;
            rbScalePercent.Checked = true;
            if (_currentImage != 0)
            {
                nWidth.Value = _gdPictureImaging.GetWidth(_currentImage);
                nHeight.Value = _gdPictureImaging.GetHeight(_currentImage);
                nDocumentWidth.Value = Convert.ToDecimal(_gdPictureImaging.GetWidthInches(_currentImage));
                nDocumentHeight.Value = Convert.ToDecimal(_gdPictureImaging.GetHeightInches(_currentImage));
                nHorizontalResolution.Value = Convert.ToDecimal(_gdPictureImaging.GetHorizontalResolution(_currentImage));
                nVerticalResolution.Value = Convert.ToDecimal(_gdPictureImaging.GetVerticalResolution(_currentImage));
            }
        }

        private void btnResetSize_Click(object sender, EventArgs e)
        {
            ResetSizeValues();
        }

        private void rbScalePercent_CheckedChanged(object sender, EventArgs e)
        {
            nScalePercent.Enabled = rbScalePercent.Checked;
            chkKeepAspectRatio.Enabled = !rbScalePercent.Checked;
            gpPixelDimensions.Enabled = !rbScalePercent.Checked;
            gpDocumentSize.Enabled = !rbScalePercent.Checked;
        }

        private void nScalePercent_ValueChanged(object sender, EventArgs e)
        {
            UpdateScalePercentValue();
        }

        private void nScalePercent_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateScalePercentValue();
        }

        private void UpdateScalePercentValue()
        {
            if (_currentImage == 0) return;
            int originalWidth = _gdPictureImaging.GetWidth(_currentImage);
            int originalHeight = _gdPictureImaging.GetHeight(_currentImage);
            nWidth.Value = Math.Max(nWidth.Minimum, originalWidth * (nScalePercent.Value / 100));
            nHeight.Value = Math.Max(nHeight.Minimum, originalHeight * (nScalePercent.Value / 100));
            nDocumentWidth.Value = Math.Max(nDocumentWidth.Minimum, nWidth.Value / nHorizontalResolution.Value);
            nDocumentHeight.Value = Math.Max(nDocumentHeight.Minimum, nHeight.Value / nVerticalResolution.Value);
        }

        private void nWidth_ValueChanged(object sender, EventArgs e)
        {
            UpdateWidthValue();
        }

        private void nWidth_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateWidthValue();
        }

        private void UpdateWidthValue()
        {
            if (_currentImage == 0 || !chkKeepAspectRatio.Checked || !rbResize.Checked) return;
            int originalWidth = _gdPictureImaging.GetWidth(_currentImage);
            int originalHeight = _gdPictureImaging.GetHeight(_currentImage);
            nHeight.Value = Math.Max(nHeight.Minimum, originalHeight * (nWidth.Value / originalWidth));
            nDocumentWidth.Value = Math.Max(nDocumentWidth.Minimum, nWidth.Value / nHorizontalResolution.Value);
        }

        private void nHeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateHeightValue();
        }

        private void nHeight_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateHeightValue();
        }

        private void UpdateHeightValue()
        {
            if (_currentImage == 0 || !chkKeepAspectRatio.Checked || !rbResize.Checked) return;
            int originalWidth = _gdPictureImaging.GetWidth(_currentImage);
            int originalHeight = _gdPictureImaging.GetHeight(_currentImage);
            nWidth.Value = Math.Max(nWidth.Minimum, originalWidth * (nHeight.Value / originalHeight));
            nDocumentHeight.Value = Math.Max(nDocumentHeight.Minimum, nHeight.Value / nVerticalResolution.Value);
        }

        private void nHorizontalResolution_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateHorizontalValue();
        }

        private void nHorizontalResolution_ValueChanged(object sender, EventArgs e)
        {
            UpdateHorizontalValue();
        }

        private void UpdateHorizontalValue()
        {
            if (rbResize.Checked)
            {
                nDocumentWidth.Value = Math.Max(nDocumentWidth.Minimum, nWidth.Value / nHorizontalResolution.Value);
            }
        }

        private void nVerticalResolution_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateVerticalValue();
        }

        private void nVerticalResolution_ValueChanged(object sender, EventArgs e)
        {
            UpdateVerticalValue();
        }

        private void UpdateVerticalValue()
        {
            if (rbResize.Checked)
            {
                nDocumentHeight.Value = Math.Max(nDocumentHeight.Minimum, nHeight.Value / nVerticalResolution.Value);
            }
        }

        private void nDocumentWidth_ValueChanged(object sender, EventArgs e)
        {
            UpdateDocumentWidthValue();
        }

        private void nDocumentWidth_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateDocumentWidthValue();
        }

        private void UpdateDocumentWidthValue()
        {
            if (rbResize.Checked)
            {
                nWidth.Value = Math.Max(nWidth.Minimum, nHorizontalResolution.Value * nDocumentWidth.Value);
            }
        }

        private void nDocumentHeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateDocumentHeightValue();
        }

        private void nDocumentHeight_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateDocumentHeightValue();
        }

        private void UpdateDocumentHeightValue()
        {
            if (rbResize.Checked)
            {
                nHeight.Value = Math.Max(nHeight.Minimum, nVerticalResolution.Value * nDocumentHeight.Value);
            }
        }

        private void btnApplySize_Click(object sender, EventArgs e)
        {
            GdPictureStatus status = default(GdPictureStatus);
            if (rbScalePercent.Checked)
            {
                status = _gdPictureImaging.Scale(_currentImage, (float)nScalePercent.Value, _interPolationModes.ElementAt(cbResampling.SelectedIndex).Key);
            }
            else
            {
                int currentWidth = _gdPictureImaging.GetWidth(_currentImage);
                int currentHeight = _gdPictureImaging.GetHeight(_currentImage);
                status = GdPictureStatus.OK;
                if (currentWidth != (int)nWidth.Value || currentHeight != (int)nHeight.Value)
                {
                    status = _gdPictureImaging.Resize(_currentImage, (int)nWidth.Value, (int)nHeight.Value, _interPolationModes.ElementAt(cbResampling.SelectedIndex).Key);
                }
                if (status == GdPictureStatus.OK)
                {
                    _gdPictureImaging.SetHorizontalResolution(_currentImage, (float)nHorizontalResolution.Value);
                    _gdPictureImaging.SetVerticalResolution(_currentImage, (float)nVerticalResolution.Value);
                }
            }
            if (status == GdPictureStatus.OK)
            {
                UpdateMainUi();
                GdViewer1.Redraw();
            }
            else
            {
                MessageBox.Show(this, "Error resizing image: " + status, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApplyRotation_Click(object sender, EventArgs e)
        {
            GdPictureStatus status = default(GdPictureStatus);
            status = ApplyRotationValues(_currentImage);
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show(this, "Error rotating image: " + _gdPictureImaging.GetStat(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GdViewer1.Redraw();
                UpdateMainUi();
                ResetRotationValues();
                CreateRotationPreviewImage();
                DisplayRotationPreviewImage();
            }
        }

        private void nRotationAngle_ValueChanged(object sender, EventArgs e)
        {
            ChangeCustomRotationValues();
        }

        private void nRotationAngle_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeCustomRotationValues();
        }

        private void CreateRotationPreviewImage()
        {
            if (_currentImage == 0)
            {
                return;
            }
            if (_currentRotationPreview != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_currentRotationPreview);
                rotationPeviewViewer.Image = null;
            }

            int currentWidth = _gdPictureImaging.GetWidth(_currentImage);
            int currentHeight = _gdPictureImaging.GetHeight(_currentImage);
            if (rotationPeviewViewer.Width < rotationPeviewViewer.Height)
            {
                int newHeight = (int)(currentHeight / ((double)currentWidth / rotationPeviewViewer.Width));
                _currentRotationPreview = _gdPictureImaging.CreateThumbnailHQ(_currentImage, rotationPeviewViewer.Width, newHeight, Color.Transparent);
            }
            else
            {
                int newWidth = (int)(currentWidth / ((double)currentHeight / rotationPeviewViewer.Height));
                _currentRotationPreview = _gdPictureImaging.CreateThumbnailHQ(_currentImage, newWidth, rotationPeviewViewer.Height, Color.Transparent);
            }
        }

        private void DisplayRotationPreviewImage()
        {
            if (_currentRotationPreview != 0)
            {
                rotationPeviewViewer.Image = _gdPictureImaging.GetBitmapFromGdPictureImage(_currentRotationPreview);
                rotationPeviewViewer.Visible = true;
            }
            else
            {
                rotationPeviewViewer.Visible = false;
            }
        }

        private void ChangeCustomRotationValues()
        {
            CreateRotationPreviewImage();
            if (_currentRotationPreview == 0) return;
            GdPictureStatus status = ApplyRotationValues(_currentRotationPreview);
            if (status == GdPictureStatus.OK)
            {
                if (!chkKeepImageDimensionRotation.Checked)
                {
                    int currentWidth = _gdPictureImaging.GetWidth(_currentRotationPreview);
                    int currentHeight = _gdPictureImaging.GetHeight(_currentRotationPreview);
                    if (rotationPeviewViewer.Width < rotationPeviewViewer.Height)
                    {
                        int newHeight = (int)(currentHeight / ((double)currentWidth / rotationPeviewViewer.Width));
                        _gdPictureImaging.Resize(_currentRotationPreview, rotationPeviewViewer.Width, newHeight, InterpolationMode.HighQualityBicubic);
                    }
                    else
                    {
                        int newWidth = (int)(currentWidth / ((double)currentHeight / rotationPeviewViewer.Height));
                        _gdPictureImaging.Resize(_currentRotationPreview, newWidth, rotationPeviewViewer.Height, InterpolationMode.HighQualityBicubic);
                    }
                }
            }
            DisplayRotationPreviewImage();
        }

        private GdPictureStatus ApplyRotationValues(int image)
        {
            GdPictureStatus status = GdPictureStatus.Aborted;
            if (rbRotateCustomAngle.Checked)
            {
                if (chkKeepImageDimensionRotation.Checked)
                {
                    status = chkRotateFromCenter.Checked ? _gdPictureImaging.RotateAnglePreserveDimensionsCenterBackColor(image, (float)nRotationAngle.Value, pbRotationBackColor.BackColor) : _gdPictureImaging.RotateAnglePreserveDimensionsBackColor(image, (float)nRotationAngle.Value, pbRotationBackColor.BackColor);
                }
                else
                {
                    status = _gdPictureImaging.RotateAngleBackColor(image, (float)nRotationAngle.Value, pbRotationBackColor.BackColor);
                }
            }
            else if (rbRotateLeft.Checked)
            {
                status = _gdPictureImaging.Rotate(image, RotateFlipType.Rotate270FlipNone);
            }
            else if (rbRotateRight.Checked)
            {
                status = _gdPictureImaging.Rotate(image, RotateFlipType.Rotate90FlipNone);
            }
            else if (rbFlipHorizontal.Checked)
            {
                status = _gdPictureImaging.Rotate(image, RotateFlipType.RotateNoneFlipX);
            }
            else if (rbFlipVertical.Checked)
            {
                status = _gdPictureImaging.Rotate(image, RotateFlipType.RotateNoneFlipY);
            }
            return status;
        }

        private void pRotationPreview_Resize(object sender, EventArgs e)
        {
            ChangeCustomRotationValues();
        }

        private void ResetRotationValues()
        {
            nRotationAngle.Value = 0;
            chkRotateFromCenter.Checked = true;
            chkKeepImageDimensionRotation.Checked = true;
            pbRotationBackColor.BackColor = Color.Black;
            rbRotateCustomAngle.Checked = false;
            rbRotateLeft.Checked = false;
            rbRotateRight.Checked = false;
            rbFlipVertical.Checked = false;
            rbFlipHorizontal.Checked = false;
            UpdateRotationUi();
            ChangeCustomRotationValues();
        }

        private void chkKeepImageDimensionRotation_CheckedChanged(object sender, EventArgs e)
        {
            chkRotateFromCenter.Enabled = chkKeepImageDimensionRotation.Checked;
            ChangeCustomRotationValues();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pbRotationBackColor.BackColor = colorDialog.Color;
                }
            }

        }

        private void btnApplyPixelConversion_Click(object sender, EventArgs e)
        {
            if (_currentImage == 0)
            {
                return;
            }
            GdPictureStatus status = default(GdPictureStatus);
            switch (cbPixelConversion.SelectedIndex)
            {
                case 0: // 1-bit per pixel (Linear)
                    status = _gdPictureImaging.ConvertTo1Bpp(_currentImage);
                    break;
                case 1: // 1-bit per pixel (Otsu)
                    status = _gdPictureImaging.ConvertTo1BppAT(_currentImage);
                    break;
                case 2: // 1-bit per pixel (Nearest color)
                    status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.NearestColor);
                    break;
                case 3: // 1-bit per pixel (Ordered Dither)
                    status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.OrderedDither);
                    break;
                case 4: // 1-bit per pixel (Burke)
                    status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.Burke);
                    break;
                case 5: // 1-bit per pixel (Stucki)
                    status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.Stucki);
                    break;
                case 6: // 1-bit per pixel (Floyd Steinberg)
                    status = _gdPictureImaging.FxBlackNWhite(_currentImage, BitonalReduction.FloydSteinberg);
                    break;
                case 7: // 1-bit per pixel (Sauvola)
                    status = _gdPictureImaging.ConvertTo1BppSauvola(_currentImage, 0.35F);
                    break;
                case 8: // 1-bit per pixel (Bradley)
                    status = _gdPictureImaging.ConvertTo1BppBradley(_currentImage, 38);
                    break;
                case 9: // 4-bits per pixel (indexed)
                    status = _gdPictureImaging.ConvertTo4Bpp16(_currentImage);
                    break;
                case 10: // 4-bits per pixel (quantized)
                    status = _gdPictureImaging.ConvertTo4BppQ(_currentImage);
                    break;
                case 11: // 8-bits per pixel (Grayscale)
                    status = _gdPictureImaging.ConvertTo8BppGrayScale(_currentImage);
                    break;
                case 12: // 8-bits per pixel (Color)
                    status = _gdPictureImaging.ConvertTo8BppQ(_currentImage);
                    break;
                case 13: // 16-bits per pixel (RGB555)
                    status = _gdPictureImaging.ConvertTo16BppRGB555(_currentImage);
                    break;
                case 14: // 16-bits per pixel (RGB565)
                    status = _gdPictureImaging.ConvertTo16BppRGB565(_currentImage);
                    break;
                case 15: // 24-bits per pixel (RGB)
                    status = _gdPictureImaging.ConvertTo24BppRGB(_currentImage);
                    break;
                case 16: // 32-bits per pixel (RGB)
                    status = _gdPictureImaging.ConvertTo32BppRGB(_currentImage);
                    break;
                case 17: // 32-bits per pixel (ARGB)
                    status = _gdPictureImaging.ConvertTo32BppARGB(_currentImage);
                    break;
                case 18: // 32-bits per pixel (PARGB)
                    status = _gdPictureImaging.ConvertTo32BppPARGB(_currentImage);
                    break;
                case 19: // 48-bits per pixel (RGB)
                    status = _gdPictureImaging.ConvertTo64BppARGB(_currentImage);
                    break;
                case 20: // 64-bits per pixel (ARGB)
                    status = _gdPictureImaging.ConvertTo64BppARGB(_currentImage);
                    break;
                case 21: // 64-bits per pixel (PARGB)
                    status = _gdPictureImaging.ConvertTo64BppPARGB(_currentImage);
                    break;
            }
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show(this, "Error: " + _gdPictureImaging.GetStat(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GdViewer1.Redraw();
                UpdateMainUi();
            }
        }

        private void tbScaleRed_ValueChanged(object sender, EventArgs e)
        {
            lblScaleRed.Text = ((tbScaleRed.Value - 100) + (tbScaleRed.Value - 100) % 100) + "%";
            ChangeColorChannelsValues();
        }

        private void tbScaleGreen_ValueChanged(object sender, EventArgs e)
        {
            lblScaleGreen.Text = ((tbScaleGreen.Value - 100) + (tbScaleGreen.Value - 100) % 100) + "%";
            ChangeColorChannelsValues();
        }

        private void tbScaleBlue_ValueChanged(object sender, EventArgs e)
        {
            lblScaleBlue.Text = ((tbScaleBlue.Value - 100) + (tbScaleBlue.Value - 100) % 100) + "%";
            ChangeColorChannelsValues();
        }

        private void pColorChannelsViewer_Resize(object sender, EventArgs e)
        {
            ChangeColorChannelsValues();
        }

        private void rbSwapColor_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColorChannelsManipulationUi();
            ChangeColorChannelsValues();
        }

        private void rbKeepComponent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColorChannelsManipulationUi();
            ChangeColorChannelsValues();
        }

        private void rbScaleComponent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColorChannelsManipulationUi();
            ChangeColorChannelsValues();
        }

        private void rbRemoveComponent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColorChannelsManipulationUi();
            ChangeColorChannelsValues();
        }

        private void UpdateColorChannelsManipulationUi()
        {
            pSwapColors.Enabled = rbSwapColor.Checked;
            pKeepComponent.Enabled = rbKeepComponent.Checked;
            pScaleColors.Enabled = rbScaleComponent.Checked;
            pRemoveComponent.Enabled = rbRemoveComponent.Checked;
        }

        private void CreateColorChannelsPreviewImage()
        {
            if (_currentImage == 0)
            {
                return;
            }
            if (_currentColorChannelsPreview != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_currentColorChannelsPreview);
                colorChannelPreviewViewer.Image = null;
            }
            _currentColorChannelsPreview = _gdPictureImaging.CreateThumbnailHQ(_currentImage, colorChannelPreviewViewer.Width, colorChannelPreviewViewer.Height, Color.Transparent);
        }

        private void DisplayColorChannelsPreviewImage()
        {
            if (_currentColorChannelsPreview != 0)
            {
                colorChannelPreviewViewer.Image = _gdPictureImaging.GetBitmapFromGdPictureImage(_currentColorChannelsPreview);
                colorChannelPreviewViewer.Visible = true;
            }
            else
            {
                colorChannelPreviewViewer.Visible = false;
            }
        }

        private void ChangeColorChannelsValues()
        {
            CreateColorChannelsPreviewImage();
            if (_currentColorChannelsPreview == 0) return;
            ApplyColorChannelsValues(_currentColorChannelsPreview);
            DisplayColorChannelsPreviewImage();
        }

        private GdPictureStatus ApplyColorChannelsValues(int image)
        {
            GdPictureStatus status = GdPictureStatus.Aborted;
            if (rbSwapColor.Checked)
            {
                switch (cbSwapColor.SelectedIndex)
                {
                    case 0:
                        status = _gdPictureImaging.SwapColorsRGBtoBGR(image);
                        break;
                    case 1:
                        status = _gdPictureImaging.SwapColorsRGBtoBRG(image);
                        break;
                    case 2:
                        status = _gdPictureImaging.SwapColorsRGBtoGBR(image);
                        break;
                    case 3:
                        status = _gdPictureImaging.SwapColorsRGBtoGRB(image);
                        break;
                    case 4:
                        status = _gdPictureImaging.SwapColorsRGBtoRBG(image);
                        break;
                }
            }
            else if (rbKeepComponent.Checked)
            {
                if (rbKeepBlue.Checked)
                {
                    status = _gdPictureImaging.KeepBlueComponent(image);
                }
                else if (rbKeepGreen.Checked)
                {
                    status = _gdPictureImaging.KeepGreenComponent(image);
                }
                else if (rbKeepRed.Checked)
                {
                    status = _gdPictureImaging.KeepRedComponent(image);
                }
            }
            else if (rbScaleComponent.Checked)
            {
                status = _gdPictureImaging.ScaleBlueComponent(image, (float)((double)tbScaleBlue.Value / 100));
                if (status != GdPictureStatus.OK) return status;
                status = _gdPictureImaging.ScaleGreenComponent(image, (float)((double)tbScaleGreen.Value / 100));
                if (status == GdPictureStatus.OK)
                {
                    status = _gdPictureImaging.ScaleRedComponent(image, (float)((double)tbScaleRed.Value / 100));
                }
            }
            else if (rbRemoveComponent.Checked)
            {
                if (rbRemoveBlue.Checked)
                {
                    status = _gdPictureImaging.RemoveBlueComponent(image);
                }
                else if (rbRemoveGreen.Checked)
                {
                    status = _gdPictureImaging.RemoveGreenComponent(image);
                }
                else if (rbRemoveRed.Checked)
                {
                    status = _gdPictureImaging.RemoveRedComponent(image);
                }
            }
            return status;
        }

        private void btnResetColorChannels_Click(object sender, EventArgs e)
        {
            ResetColorOperationsValues();
            ChangeColorChannelsValues();
        }

        private void btnApplyColorChannels_Click(object sender, EventArgs e)
        {
            GdPictureStatus status = ApplyColorChannelsValues(_currentImage);
            if (status != GdPictureStatus.OK) return;
            GdViewer1.Redraw();
            UpdateMainUi();
            CreateColorChannelsPreviewImage();
            DisplayColorChannelsPreviewImage();
        }

        private void rbKeepRed_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColorChannelsValues();
        }

        private void rbKeepGreen_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColorChannelsValues();
        }

        private void rbKeepBlue_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColorChannelsValues();
        }

        private void rbRemoveRed_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColorChannelsValues();
        }

        private void rbRemoveGreen_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColorChannelsValues();
        }

        private void rbRemoveBlue_CheckedChanged(object sender, EventArgs e)
        {
            ChangeColorChannelsValues();
        }

        private void cbSwapColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeColorChannelsValues();
        }

        private void ResetColorOperationsValues()
        {
            rbSwapColor.Checked = true;
            cbSwapColor.SelectedIndex = -1;
            tbScaleRed.Value = 100;
            tbScaleGreen.Value = 100;
            tbScaleBlue.Value = 100;
            rbRemoveBlue.Checked = false;
            rbRemoveGreen.Checked = false;
            rbRemoveBlue.Checked = false;
            rbKeepBlue.Checked = false;
            rbKeepGreen.Checked = false;
            rbKeepRed.Checked = false;
            rbSwapColor.Checked = true;
            ChangeColorChannelsValues();
        }

        private void ResetEffectsValues()
        {
            cbDirectEffects.SelectedIndex = -1;
            cbConfigurableEffects.SelectedIndex = -1;
            cbConvolutionMatrix.SelectedIndex = -1;
            rbDirectEffects.Checked = true;
            nHueEffect.Value = 50;
            nSaturationEffect.Value = 50;
            nLuminosityEffect.Value = 25;
            nKernelSizeEffect.Value = 1;
            if (_currentImage == 0)
            {
                nLeftEffect.Value = 1;
            }
            else
            {
                nLeftEffect.Value = (decimal)(Math.Round(Convert.ToDouble((double)_gdPictureImaging.GetWidth(_currentImage) / 2)));
            }
            if (_currentImage == 0)
            {
                nTopEffect.Value = 1;
            }
            else
            {
                nTopEffect.Value = (decimal)(Math.Round((double)_gdPictureImaging.GetHeight(_currentImage) / 2));
            }
            nRadiusEffect.Value = 15;
            nWidthEffect.Value = 20;
            nHeightEffect.Value = 15;
            cbComponentEffect.SelectedIndex = 0;
            nVariationEffect.Value = 240;
            nMinKeyValueEffect.Value = 50;
            nSoftenValueEffect.Value = 25;
            nRollingBallSizeEffect.Value = 50;
            chkLightBackgroundEffect.Checked = true;
            nFactorEffect.Value = 30;
            nFloodFillEffectXStart.Value = 1;
            nFloodFillEffectYStart.Value = 1;
            pbFloodFillEffectColor.BackColor = Color.Black;
        }

        private void CreateEffectsPreviewImage()
        {
            if (_currentImage == 0)
            {
                return;
            }
            if (_currentEffectsPreview != 0)
            {
                GdViewer2.CloseDocument();
                _gdPictureImaging.ReleaseGdPictureImage(_currentEffectsPreview);
                if (GdViewer1.IsRect())
                {
                    int roiLeft = 0;
                    int roiWidth = 0;
                    int roiTop = 0;
                    int roiHeight = 0;
                    GdViewer1.GetRectCoordinatesOnDocument(ref roiLeft, ref roiTop, ref roiWidth, ref roiHeight);
                    if (roiHeight != 0 & roiWidth != 0)
                    {
                        _gdPictureImaging.SetROI(roiLeft, roiTop, roiWidth, roiHeight);
                    }
                }
                else
                {
                    _gdPictureImaging.ResetROI();
                }
            }
            _currentEffectsPreview = _gdPictureImaging.CreateClonedGdPictureImage(_currentImage);
        }

        private void DisplayEffectsPreviewImage()
        {
            if (_currentEffectsPreview != 0)
            {
                GdViewer2.DisplayFromGdPictureImage(_currentEffectsPreview);
            }
            else
            {
                GdViewer2.CloseDocument();
            }
        }

        private void ChangeEffectsValues()
        {
            CreateEffectsPreviewImage();
            if (_currentEffectsPreview == 0) return;
            ApplyEffectValues(_currentEffectsPreview);
            DisplayEffectsPreviewImage();
        }

        private void pEffectsPreview_Resize(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void btnResetEffects_Click(object sender, EventArgs e)
        {
            ResetEffectsValues();
        }

        private void btnApplyEffects_Click(object sender, EventArgs e)
        {
            if (GdViewer1.IsRect())
            {
                int roiLeft = 0;
                int roiWidth = 0;
                int roiTop = 0;
                int roiHeight = 0;
                GdViewer1.GetRectCoordinatesOnDocument(ref roiLeft, ref roiTop, ref roiWidth, ref roiHeight);
                if (roiHeight != 0 & roiWidth != 0)
                {
                    _gdPictureImaging.SetROI(roiLeft, roiTop, roiWidth, roiHeight);
                }
            }
            else
            {
                _gdPictureImaging.ResetROI();
            }
            GdPictureStatus status = ApplyEffectValues(_currentImage);
            if (status != GdPictureStatus.OK) return;
            GdViewer1.Redraw();
            UpdateMainUi();
            _gdPictureImaging.ResetROI();
            GdViewer1.ClearRect();
            CreateEffectsPreviewImage();
            DisplayEffectsPreviewImage();
        }

        private GdPictureStatus ApplyEffectValues(int image)
        {
            GdPictureStatus status = GdPictureStatus.Aborted;
            if (rbDirectEffects.Checked)
            {
                switch (cbDirectEffects.SelectedIndex)
                {
                    case 0: // Add noise
                        status = _gdPictureImaging.FxAddNoise(image);
                        break;
                    case 1: // Aqua
                        status = _gdPictureImaging.FxAqua(image);
                        break;
                    case 2: // Blur
                        status = _gdPictureImaging.FxBlur(image);
                        break;
                    case 3: // Connected contour
                        status = _gdPictureImaging.FxConnectedContour(image);
                        break;
                    case 4: // Contour
                        status = _gdPictureImaging.FxContour(image);
                        break;
                    case 5: // Diffuse
                        status = _gdPictureImaging.FxDiffuse(image);
                        break;
                    case 6: // Diffuse more
                        status = _gdPictureImaging.FxDiffuseMore(image);
                        break;
                    case 7: // Dilate
                        status = _gdPictureImaging.FxDilate(image);
                        break;
                    case 8: // Edge detect (Prewitt)
                        status = _gdPictureImaging.FxPrewittEdgeDetect(image);
                        break;
                    case 9: // Edge detect (Sobel)
                        status = _gdPictureImaging.FxSobelEdgeDetect(image);
                        break;
                    case 10: // Edge enhance
                        status = _gdPictureImaging.FxEdgeEnhance(image);
                        break;
                    case 11: // Emboss
                        status = _gdPictureImaging.FxEmboss(image);
                        break;
                    case 12: // Emboss more
                        status = _gdPictureImaging.FxEmbossMore(image);
                        break;
                    case 13: // Engrave
                        status = _gdPictureImaging.FxEngrave(image);
                        break;
                    case 14: // Engrave more
                        status = _gdPictureImaging.FxEngraveMore(image);
                        break;
                    case 15: // Equalize intensity
                        status = _gdPictureImaging.FxEqualizeIntensity(image);
                        break;
                    case 16: // Erode
                        status = _gdPictureImaging.FxErode(image);
                        break;
                    case 17: // Fire
                        status = _gdPictureImaging.FxFire(image);
                        break;
                    case 18: // Grayscale
                        status = _gdPictureImaging.FxGrayscale(image);
                        break;
                    case 19: // Mirror rounded
                        status = _gdPictureImaging.FxMirrorRounded(image);
                        break;
                    case 20: // Negative
                        status = _gdPictureImaging.FxNegative(image);
                        break;
                    case 21: // Pixelize
                        status = _gdPictureImaging.FxPixelize(image);
                        break;
                    case 22: // Red eyes correction
                        status = _gdPictureImaging.FxRedEyesCorrection(image);
                        break;
                    case 23: // Relief
                        status = _gdPictureImaging.FxRelief(image);
                        break;
                    case 24: // Scan line
                        status = _gdPictureImaging.FxScanLine(image);
                        break;
                    case 25: // Sepia
                        status = _gdPictureImaging.FxSepia(image);
                        break;
                    case 26: // Sharpen
                        status = _gdPictureImaging.FxSharpen(image);
                        break;
                    case 27: // Sharpen more
                        status = _gdPictureImaging.FxSharpenMore(image);
                        break;
                    case 28: // Smooth
                        status = _gdPictureImaging.FxSmooth(image);
                        break;
                    case 29: // Stretch contrast
                        status = _gdPictureImaging.FxStretchContrast(image);
                        break;
                }
            }
            else if (rbConfigurableEffects.Checked)
            {
                switch (cbConfigurableEffects.SelectedIndex)
                {
                    case 0: // Colorize
                        status = _gdPictureImaging.FxColorize(image, (float)nHueEffect.Value, (float)nSaturationEffect.Value, (float)nLuminosityEffect.Value);
                        break;
                    case 1: // Flood fill
                        status = _gdPictureImaging.FloodFill(image, (int)nFloodFillEffectXStart.Value, (int)nFloodFillEffectYStart.Value, pbFloodFillEffectColor.BackColor);
                        break;
                    case 2: // Gaussian blur
                        status = _gdPictureImaging.FxGaussian(image, (int)nKernelSizeEffect.Value);
                        break;
                    case 3: // Halo
                        status = _gdPictureImaging.FxHalo(image, (int)nLeftEffect.Value, (int)nTopEffect.Value, (int)nRadiusEffect.Value);
                        break;
                    case 4: // Max
                        status = _gdPictureImaging.FxMax(image, (int)nKernelSizeEffect.Value);
                        break;
                    case 5: // Median
                        status = _gdPictureImaging.FxMedian(image, (int)nKernelSizeEffect.Value);
                        break;
                    case 6: // Min
                        status = _gdPictureImaging.FxMin(image, (int)nKernelSizeEffect.Value);
                        break;
                    case 7: // Remove background chromakey
                        status = _gdPictureImaging.fxRemoveBackgroundChromaKey(image, (ColorKey)cbComponentEffect.SelectedIndex, (int)nVariationEffect.Value, (int)nMinKeyValueEffect.Value);
                        break;
                    case 8: // Soften
                        status = _gdPictureImaging.FxSoften(image, (int)nSoftenValueEffect.Value);
                        break;
                    case 9: // Substract background
                        status = _gdPictureImaging.FxSubtractBackground(image, (int)nRollingBallSizeEffect.Value, chkLightBackgroundEffect.Checked);
                        break;
                    case 10: // Swirl
                        status = _gdPictureImaging.FxSwirl(image, (float)nFactorEffect.Value);
                        break;
                    case 11: // Twirl
                        status = _gdPictureImaging.FxTwirl(image, (float)nFactorEffect.Value);
                        break;
                    case 12: // Waves (horizontal)
                        status = _gdPictureImaging.FxhWaves(image, (int)nWidthEffect.Value, (int)nHeightEffect.Value);
                        break;
                    case 13: // Waves (vertical)
                        status = _gdPictureImaging.FxvWaves(image, (int)nWidthEffect.Value, (int)nHeightEffect.Value);
                        break;
                }
            }
            else if (rbConvolutionMatrix.Checked)
            {
                switch (cbConvolutionMatrix.SelectedIndex)
                {
                    case 0: // Sharpen
                        // Convolution matrix for sharpen filter is :
                        //  0 -1  0
                        // -1  5 -1
                        //  0 -1  0
                        float[,] sharpen = { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
                        status = _gdPictureImaging.FxConvolution(image, sharpen, true);
                        break;
                    case 1: // Blur
                        // Convolution matrix for blur filter is :
                        //  1  1  1
                        //  1  1  1
                        //  1  1  1
                        float[,] blur = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
                        status = _gdPictureImaging.FxConvolution(image, blur, true);
                        break;
                    case 2: // Edge Enhance
                        // Convolution matrix for edge enhance filter is :
                        //  0  0  0
                        // -1  1  0
                        //  0  0  0
                        float[,] enhance = { { 0, 0, 0 }, { -1, 1, 0 }, { 0, 0, 0 } };
                        status = _gdPictureImaging.FxConvolution(image, enhance, true);
                        break;
                    case 3: // Edge Detect
                        // Convolution matrix for edge detect filter is :
                        //  0  1  0
                        //  1 -4  1
                        //  0  1  0
                        float[,] detect = { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
                        status = _gdPictureImaging.FxConvolution(image, detect, true);
                        break;
                    case 4: // Emboss
                        // Convolution matrix for emboss filter is :
                        // -2 -1  0
                        // -1  1  1
                        //  0  1  2
                        float[,] emboss = { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } };
                        status = _gdPictureImaging.FxConvolution(image, emboss, true);
                        break;
                }
            }
            return status;
        }

        private void cbEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void rbDirectEffects_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEffectsUi();
        }

        private void rbConfigurableEffects_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEffectsUi();
        }

        private void UpdateEffectsUi()
        {
            pDirectEffects.Enabled = rbDirectEffects.Checked;
            cbConvolutionMatrix.Enabled = rbConvolutionMatrix.Checked;
            cbConvolutionMatrix.SelectedIndex = -1;
            cbDirectEffects.SelectedIndex = -1;
            pConfigurableEffects.Enabled = rbConfigurableEffects.Checked;
            cbConfigurableEffects.SelectedIndex = -1;
            UpdateConfigurableEffectUi();
        }

        private void cbConfigurableEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateConfigurableEffectUi();
            ChangeEffectsValues();
        }

        private void UpdateConfigurableEffectUi()
        {
            pColorizeEffect.Enabled = false;
            pKernelSizeEffect.Enabled = false;
            pHaloEffect.Enabled = false;
            pWavesEffect.Enabled = false;
            pRemoveBackgroundChromokeyEffect.Enabled = false;
            pSoftenValueEffect.Enabled = false;
            pSubstractBackgroundEffect.Enabled = false;
            pFactorEffect.Enabled = false;
            pFloodFillEffect.Enabled = false;
            switch (cbConfigurableEffects.SelectedIndex)
            {
                case 0: // Colorize
                    pColorizeEffect.Enabled = true;
                    break;
                case 1: // Flood fill
                    pFloodFillEffect.Enabled = true;
                    break;
                case 2: // Gaussian blur
                    pKernelSizeEffect.Enabled = true;
                    nKernelSizeEffect.Maximum = 10;
                    break;
                case 3: // Halo
                    pHaloEffect.Enabled = true;
                    break;
                case 4: // Max
                    pKernelSizeEffect.Enabled = true;
                    if (_currentImage == 0)
                    {
                        nKernelSizeEffect.Maximum = 1;
                    }
                    else
                    {
                        nKernelSizeEffect.Maximum = (decimal)((double)_gdPictureImaging.GetWidth(_currentImage) / 2);
                    }
                    break;
                case 5: // Median
                    pKernelSizeEffect.Enabled = true;
                    nKernelSizeEffect.Maximum = 60;
                    break;
                case 6: // Min
                    pKernelSizeEffect.Enabled = true;
                    if (_currentImage == 0)
                    {
                        nKernelSizeEffect.Maximum = 1;
                    }
                    else
                    {
                        nKernelSizeEffect.Maximum = (decimal)((double)_gdPictureImaging.GetWidth(_currentImage) / 2);
                    }
                    break;
                case 7: // Remove background chromakey
                    pRemoveBackgroundChromokeyEffect.Enabled = true;
                    break;
                case 8: // Soften
                    pSoftenValueEffect.Enabled = true;
                    break;
                case 9: // Substract background
                    pSubstractBackgroundEffect.Enabled = true;
                    break;
                case 10: // Swirl
                    pFactorEffect.Enabled = true;
                    break;
                case 11: // Twirl
                    pFactorEffect.Enabled = true;
                    break;
                case 12: // Waves (horizontal)
                    pWavesEffect.Enabled = true;
                    break;
                case 13: // Waves (vertical)
                    pWavesEffect.Enabled = true;
                    break;
            }
        }

        private void nHueEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nSaturationEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nLuminosityEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nKernelSizeEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nLeftEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nTopEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nRadiusEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nWidthEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nHeightEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void cbComponentEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nVariationEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nMinKeyValueEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nSoftenValueEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nRollingBallSizeEffect_ValueChanged(object sender, EventArgs e)
        {
            if (nRollingBallSizeEffect.Value > 900) nRollingBallSizeEffect.Value = 900;
            ChangeEffectsValues();
        }

        private void chkLightBackgroundEffect_CheckedChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nFactorEffect_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void chkRotateFromCenter_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCustomRotationValues();
        }

        private void pbFloodFillEffectColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pbFloodFillEffectColor.BackColor = colorDialog.Color;
                }
            }

        }

        private void nFloodFillEffectXStart_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nFloodFillEffectYStart_ValueChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void pbFloodFillEffectColor_BackColorChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nHueEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nSaturationEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nLuminosityEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nKernelSizeEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nLeftEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nTopEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nRadiusEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nWidthEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nHeightEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nVariationEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nMinKeyValueEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nSoftenValueEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nRollingBallSizeEffect_KeyUp(object sender, KeyEventArgs e)
        {
            //ChangeEffectsValues();
        }

        private void nFactorEffect_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nFloodFillEffectXStart_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void nFloodFillEffectYStart_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeEffectsValues();
        }

        private void rbRotateLeft_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRotationUi();
        }

        private void rbRotateRight_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRotationUi();
        }

        private void rbFlipHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRotationUi();
        }

        private void rbFlipVertical_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRotationUi();
        }

        private void rbRotateCustomAngle_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRotationUi();
        }

        private void UpdateRotationUi()
        {
            chkRotateFromCenter.Enabled = rbRotateCustomAngle.Checked;
            chkKeepImageDimensionRotation.Enabled = rbRotateCustomAngle.Checked;
            lblCustomRotationBackgroundColor.Enabled = rbRotateCustomAngle.Checked;
            pbRotationBackColor.Enabled = rbRotateCustomAngle.Checked;
            nRotationAngle.Enabled = rbRotateCustomAngle.Checked;
            ChangeCustomRotationValues();
        }

        private void pbRotationBackColor_BackColorChanged(object sender, EventArgs e)
        {
            ChangeCustomRotationValues();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (frmSave f = new frmSave(_currentImage))
            {
                f.ShowDialog(this);
            }

        }

        private void btnSnapInThumbnails_Click(object sender, EventArgs e)
        {
            SelectSnapIn(0, "Thumbnails");
        }

        private void GdViewer1_TransferEnded(GdPictureStatus status, bool Download)
        {
            GdViewer1.Focus();
            ThumbnailEx1.LoadFromGdViewer(GdViewer1);
            UpdateMainUi();
        }

        private void SmallThumbnailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new Size(64, 64);
            SmallThumbnailsToolStripMenuItem1.Checked = true;
            MediumThumbnailsToolStripMenuItem1.Checked = false;
            LargeThumbnailsToolStripMenuItem1.Checked = false;
        }

        private void MediumThumbnailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new Size(128, 128);
            SmallThumbnailsToolStripMenuItem1.Checked = false;
            MediumThumbnailsToolStripMenuItem1.Checked = true;
            LargeThumbnailsToolStripMenuItem1.Checked = false;
        }

        private void LargeThumbnailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new Size(256, 256);
            SmallThumbnailsToolStripMenuItem1.Checked = false;
            MediumThumbnailsToolStripMenuItem1.Checked = false;
            LargeThumbnailsToolStripMenuItem1.Checked = true;
        }

        private string GetSelectedItemAsRange()
        {
            int count = 0;
            for (int i = 0; i <= ThumbnailEx1.ItemCount - 1; i++)
            {
                if (ThumbnailEx1.GetItemCheckState(i) == true)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                if (MessageBox.Show("No page has been selected, do you want to save all pages?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i <= ThumbnailEx1.ItemCount - 1; i++)
                    {
                        ThumbnailEx1.SetItemCheckState(i, true);
                    }
                    count = ThumbnailEx1.ItemCount;
                }
            }
            if (count > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i <= ThumbnailEx1.ItemCount; i++)
                {
                    if (ThumbnailEx1.GetItemCheckState(i) != true) continue;
                    if (sb.Length != 0)
                    {
                        sb.Append(";");
                    }
                    sb.Append(i + 1);
                }

                return sb.ToString();
            }
            return "";
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            GdViewer1.DisplayFirstPage();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            GdViewer1.DisplayPreviousPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            GdViewer1.DisplayNextPage();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            GdViewer1.DisplayLastPage();
        }

        private void tbCurrentPage_Leave(object sender, EventArgs e)
        {
            int page = 0;
            if (!int.TryParse(tbCurrentPage.Text, out page)) return;
            if (!(page > 0 & page <= GdViewer1.PageCount)) return;
            GdViewer1.DisplayPage(page);
            UpdateaNavigationToolbar();
        }

        private void rbConvolutionMatrix_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEffectsUi();
        }

        private void cbConvolutionMatrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeEffectsValues();
        }
    }

}
