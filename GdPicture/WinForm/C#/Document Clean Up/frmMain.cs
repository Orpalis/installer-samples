using GdPicture14;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DocumentCleanUp
{
    public partial class frmMain
    {
        public frmMain()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (_defaultInstance == null)
                _defaultInstance = this;
        }

        #region Default Instance

        private static frmMain _defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmMain Default
        {
            get
            {
                if (_defaultInstance != null) return _defaultInstance;
                _defaultInstance = new frmMain();
                _defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);

                return _defaultInstance;
            }
            set
            {
                _defaultInstance = value;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            _defaultInstance = null;
        }

        #endregion

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

        private readonly GdPictureImaging _gdPictureImaging = new GdPictureImaging();
        private int _currentImage;
        private int _currentDocumentCleanUpPreview;

        private readonly DocumentCleanUp.DocumentCleanUpEffects _documentCleanUpEffects = new DocumentCleanUp.DocumentCleanUpEffects();
        private readonly BindingList<DocumentCleanUp.ADocumentCleanUpEffect> _documentCleanUpEffectsQueue = new BindingList<DocumentCleanUp.ADocumentCleanUpEffect>();

        private void frmMain_Load(object sender, EventArgs e)
        {
            GdPicture14.LicenseManager oLicenceManager = new GdPicture14.LicenseManager();
            oLicenceManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            tcLeftPanel.Appearance = TabAppearance.FlatButtons;
            tcLeftPanel.ItemSize = new Size(0, 1);
            tcLeftPanel.SizeMode = TabSizeMode.Fixed;
            SelectSnapIn(0, "Thumbnails");

            tbEffectsParameters.Appearance = TabAppearance.FlatButtons;
            tbEffectsParameters.ItemSize = new Size(0, 1);
            tbEffectsParameters.SizeMode = TabSizeMode.Fixed;

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

            List<KeyValuePair<DespeckleType, string>> despeckleForce = new List<KeyValuePair<DespeckleType, string>> {
                new KeyValuePair<DespeckleType, string>(DespeckleType.FourConnected, "Four connected"),
                new KeyValuePair<DespeckleType, string>(DespeckleType.FourConnectedNeighborhood, "Four connected neighborhood"),
                new KeyValuePair<DespeckleType, string>(DespeckleType.FourConnectedWhite, "Four connected white"),
                new KeyValuePair<DespeckleType, string>(DespeckleType.FourConnectedNeighborhoodWhite, "Four connected neighborhood white"),
                new KeyValuePair<DespeckleType, string>(DespeckleType.Connected, "Connected"),
                new KeyValuePair<DespeckleType, string>(DespeckleType.ConnectedNeighborhood, "Connected neighborhood"),
                new KeyValuePair<DespeckleType, string>(DespeckleType.ConnectedWhite, "Connected white"),
                new KeyValuePair<DespeckleType, string>(DespeckleType.ConnectedNeighborhoodWhite, "Connected neighborhood white")
            };
            cbDespeckleType.DisplayMember = "Value";
            cbDespeckleType.ValueMember = "Key";
            cbDespeckleType.DataSource = despeckleForce;

            List<KeyValuePair<ReferencePoint, string>> referencePoints = new List<KeyValuePair<ReferencePoint, string>>
            {
                new KeyValuePair<ReferencePoint, string>(ReferencePoint.ReferencePointBottomLeft, "Bottom Left"),
                new KeyValuePair<ReferencePoint, string>(ReferencePoint.ReferencePointBottomRight, "Bottom Right"),
                new KeyValuePair<ReferencePoint, string>(ReferencePoint.ReferencePointTopLeft, "Top Left"),
                new KeyValuePair<ReferencePoint, string>(ReferencePoint.ReferencePointTopRight, "Top Right")
            };
            cbCropBordersReferencePoint.DisplayMember = "Value";
            cbCropBordersReferencePoint.ValueMember = "Key";
            cbCropBordersReferencePoint.DataSource = referencePoints;

            List<KeyValuePair<ImagingContext, string>> imageContexts = new List<KeyValuePair<ImagingContext, string>>
            {
                new KeyValuePair<ImagingContext, string>(ImagingContext.ContextDocument, "Document"),
                new KeyValuePair<ImagingContext, string>(ImagingContext.ContextPhoto, "Photo")
            };
            cbCropBordersImageContext.DisplayMember = "Value";
            cbCropBordersImageContext.ValueMember = "Key";
            cbCropBordersImageContext.DataSource = imageContexts;

            List<KeyValuePair<HolePunchMargins, string>> punchHoleMargins = new List<KeyValuePair<HolePunchMargins, string>>
            {
                new KeyValuePair<HolePunchMargins, string>(HolePunchMargins.MarginLeft, "Left"),
                new KeyValuePair<HolePunchMargins, string>(HolePunchMargins.MarginTop, "Top"),
                new KeyValuePair<HolePunchMargins, string>(HolePunchMargins.MarginBottom, "Bottom"),
                new KeyValuePair<HolePunchMargins, string>(HolePunchMargins.MarginRight, "Right"),
                new KeyValuePair<HolePunchMargins, string>(HolePunchMargins.MarginLeft | HolePunchMargins.MarginRight, "Left + Right"),
                new KeyValuePair<HolePunchMargins, string>(HolePunchMargins.MarginTop | HolePunchMargins.MarginBottom, "Top + Bottom"),
                new KeyValuePair<HolePunchMargins, string>(HolePunchMargins.MarginTop | HolePunchMargins.MarginBottom | HolePunchMargins.MarginLeft | HolePunchMargins.MarginRight, "All")
            };
            cbRemoveHolePunchEffectMargins.DisplayMember = "Value";
            cbRemoveHolePunchEffectMargins.ValueMember = "Key";
            cbRemoveHolePunchEffectMargins.DataSource = punchHoleMargins;

            List<KeyValuePair<LineRemoveOrientation, string>> lineOrientations = new List<KeyValuePair<LineRemoveOrientation, string>>
            {
                new KeyValuePair<LineRemoveOrientation, string>(LineRemoveOrientation.Horizontal, "Horizontal"),
                new KeyValuePair<LineRemoveOrientation, string>(LineRemoveOrientation.Vertical, "Vertical")
            };
            cbRemoveLinesEffectOrientation.DisplayMember = "Value";
            cbRemoveLinesEffectOrientation.ValueMember = "Key";
            cbRemoveLinesEffectOrientation.DataSource = lineOrientations;

            cbDocumentCleanUpEffects.DataSource = new BindingSource(_documentCleanUpEffects.List, null);
            cbDocumentCleanUpEffects.DisplayMember = "Name";
            cbDocumentCleanUpEffects.SelectedIndex = -1;

            lstEffects.DataSource = new BindingSource(_documentCleanUpEffectsQueue, null);
            lstEffects.DisplayMember = "Name";
            lstEffects.SelectedIndex = -1;

            GdViewer1.RemoveItemMenu(8);
            GdViewer1.RemoveItemMenu(27);

            UpdateMainUi();
        }

        private void UpdateMainUi()
        {
            Text = "GdPicture.NET " + typeof(GdPictureImaging).Assembly.GetName().Version + " - Document Clean Up Demo";
            if (GdViewer1.PageCount == 0)
            {
                btnClose.Enabled = false;
                btnPrint.Enabled = false;
                btnSave.Enabled = false;
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
                btnRotateLeft.Enabled = false;
                btnRotateRight.Enabled = false;
                btnFlipX.Enabled = false;
                btnFlipY.Enabled = false;
                tbCurrentPage.Text = "0";
                lblPageCount.Text = "/ 0";
                cbZoom.SelectedIndex = -1;
                pDocumentCleanUp.Enabled = false;
            }
            else
            {
                btnClose.Enabled = true;
                btnPrint.Enabled = true;
                btnSave.Enabled = true;
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
                btnRotateLeft.Enabled = true;
                btnRotateRight.Enabled = true;
                btnFlipX.Enabled = true;
                btnFlipY.Enabled = true;
                pDocumentCleanUp.Enabled = true;
                UpdateaNavigationToolbar();
            }
        }

        private void UpdateaNavigationToolbar()
        {
            int currentPage = GdViewer1.CurrentPage;
            tbCurrentPage.Text = currentPage.ToString();
            lblPageCount.Text = "/ " + GdViewer1.PageCount.ToString();
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

            btnFlipX.Enabled = GdViewer1.GetDocumentType() == DocumentType.DocumentTypeBitmap;
            btnFlipY.Enabled = GdViewer1.GetDocumentType() == DocumentType.DocumentTypeBitmap;

            double widthInches = 0;
            double heightInches = 0;

            if (GdViewer1.GetDocumentType() == DocumentType.DocumentTypePDF)
            {
                widthInches = GdViewer1.PdfGetPageWidth() / 72;
                heightInches = GdViewer1.PdfGetPageHeight() / 72;
            }
            else
            {
                widthInches = GdViewer1.PageWidth / GdViewer1.HorizontalResolution;
                heightInches = GdViewer1.PageHeight / GdViewer1.VerticalResolution;
            }

            ToolStripStatusLabel1.Text = "Type: " + GetDocumentTypeLabel() + "  -  " +
            "Page Size (inches): " + (Math.Round(widthInches, 2)).ToString().Trim() + " × " + (Math.Round(heightInches, 2)).ToString().Trim() + "  -  " +
            "Page Size (pixels): " + (GdViewer1.PageWidth).ToString().Trim() + " × " + (GdViewer1.PageHeight).ToString().Trim() + "  -  " +
            "Horizontal resolution: " + (Math.Round(GdViewer1.HorizontalResolution, 2)).ToString().Trim() + " DPI  -  " +
            "Vertical resolution: " + (Math.Round(GdViewer1.VerticalResolution, 2)).ToString().Trim() + " DPI";
        }

        private string GetDocumentTypeLabel()
        {
            string result = "";
            switch (GdViewer1.GetDocumentType())
            {
                case DocumentType.DocumentTypeBitmap:
                    result = "Image";
                    break;
                case DocumentType.DocumentTypeMetaFile:
                    result = "Metafile";
                    break;
                case DocumentType.DocumentTypePDF:
                    result = "PDF";
                    break;
                case DocumentType.DocumentTypeSVG:
                    result = "SVG";
                    break;
                case DocumentType.DocumentTypeTXT:
                    result = "Text file";
                    break;
                case DocumentType.DocumentTypeUnknown:
                    result = "Unknown";
                    break;
            }
            return result;
        }

        private void CloseDocument()
        {
            if (_currentImage != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_currentImage);
                _currentImage = 0;
            }
            if (_currentDocumentCleanUpPreview != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_currentDocumentCleanUpPreview);
                _currentDocumentCleanUpPreview = 0;
            }
            GdViewer1.CloseDocument();
            GdViewerPreview.CloseDocument();
            ThumbnailEx1.ClearAllItems();
            UpdateMainUi();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            CloseDocument();

            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeShrinkToViewerWidth;
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter;
            GdViewerPreview.ZoomMode = GdViewer1.ZoomMode;
            GdViewerPreview.DocumentAlignment = GdViewer1.DocumentAlignment;

            _currentImage = _gdPictureImaging.CreateGdPictureImageFromFile("");
            GdPictureStatus status = _gdPictureImaging.GetStat();
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show(this, "Cannot open file : " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (_currentImage != 0)
            {
                GdViewer1.DisplayFromGdPictureImage(_currentImage);
                ThumbnailEx1.LoadFromGdViewer(GdViewer1);
                GdViewer1.Focus();
            }
            UpdateMainUi();
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

        private void GdViewer1_PageChanged()
        {
            UpdateaNavigationToolbar();
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
            GdViewerPreview.Zoom = GdViewer1.Zoom;
            UpdateaNavigationToolbar();
        }

        private void cbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeZoomValue();
        }

        private void GdViewer1_AfterZoomChange()
        {
            UpdateaNavigationToolbar();
            GdViewerPreview.Zoom = GdViewer1.Zoom;
            if (GdViewer1.MouseMode == ViewerMouseMode.MouseModeAreaZooming)
            {
                GdViewer1.MouseMode = ViewerMouseMode.MouseModePan;
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomOUT();
            GdViewerPreview.Zoom = GdViewer1.Zoom;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomIN();
            GdViewerPreview.Zoom = GdViewer1.Zoom;
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

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.Rotate270FlipNone);
            GdViewerPreview.Rotate(RotateFlipType.Rotate270FlipNone);
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.Rotate90FlipNone);
            GdViewerPreview.Rotate(RotateFlipType.Rotate90FlipNone);
        }

        private void btnFlipX_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.RotateNoneFlipX);
            GdViewerPreview.Rotate(RotateFlipType.RotateNoneFlipX);
        }

        private void btnFlipY_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.RotateNoneFlipY);
            GdViewerPreview.Rotate(RotateFlipType.RotateNoneFlipY);
        }

        private void GdViewer1_TransferEnded(GdPictureStatus status, bool download)
        {
            GdViewer1.Focus();
            ThumbnailEx1.LoadFromGdViewer(GdViewer1);
            UpdateMainUi();
        }

        private void cbZoom_Validating(object sender, CancelEventArgs e)
        {
            ChangeZoomValue();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseDocument();
            UpdateMainUi();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (frmSettings frmSettings = new frmSettings(GdViewer1))
            {
                frmSettings.ShowDialog(this);
            }

            GdViewerPreview.DocumentAlignment = GdViewer1.DocumentAlignment;
            GdViewerPreview.DocumentPosition = GdViewer1.DocumentPosition;
            GdViewerPreview.DisplayQuality = GdViewer1.DisplayQuality;
            GdViewerPreview.DisplayQualityAuto = GdViewer1.DisplayQualityAuto;
            GdViewerPreview.BackColor = GdViewer1.BackColor;
            GdViewerPreview.IgnoreDocumentResolution = GdViewer1.IgnoreDocumentResolution;
            GdViewerPreview.AnnotationDropShadow = GdViewer1.AnnotationDropShadow;
            GdViewerPreview.HQAnnotationRendering = GdViewer1.HQAnnotationRendering;
            GdViewerPreview.EnableICM = GdViewer1.EnableICM;

            ThumbnailEx1.PdfIncreaseTextContrast = GdViewer1.PdfIncreaseTextContrast;
            UpdateaNavigationToolbar();
        }

        private void btnFitWidth_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
            GdViewerPreview.ZoomMode = GdViewer1.ZoomMode;
        }

        private void btnFitPage_Click(object sender, EventArgs e)
        {
            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
            GdViewerPreview.ZoomMode = GdViewer1.ZoomMode;
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

        private void btnSnapInThumbnails_Click(object sender, EventArgs e)
        {
            SelectSnapIn(0, "Thumbnails");
        }

        private void btnSnapInDocumentCleanUp_Click(object sender, EventArgs e)
        {
            SelectSnapIn(1, "Document clean up");
        }

        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeDefault;
            GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeDefault;
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
            GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeDefault;
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
            GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeDefault;
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
            GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeDefault;
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
            GdViewerPreview.MouseMode = ViewerMouseMode.MouseModeMagnifier;
            DefaultToolStripMenuItem.Checked = false;
            AreaSelectionToolStripMenuItem.Checked = false;
            PanToolStripMenuItem.Checked = false;
            AreaZoomingToolStripMenuItem.Checked = false;
            MagnifierToolStripMenuItem.Checked = true;
            GdViewer1.Focus();
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

        private void ResetDocumentCleanUpValues()
        {
            _documentCleanUpEffectsQueue.Clear();
            ChangeDocumentCleanUpValues();
            UpdateEffectUi();
        }

        private void CreateDocumentCleanUpPreviewImage()
        {
            if (_currentImage == 0)
            {
                return;
            }
            if (_currentDocumentCleanUpPreview != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_currentDocumentCleanUpPreview);
                GdViewerPreview.CloseDocument();
            }
            _currentDocumentCleanUpPreview = _gdPictureImaging.CreateClonedGdPictureImage(_currentImage);
        }

        private void DisplayDocumentCleanUpPreviewImage()
        {
            if (_currentDocumentCleanUpPreview == 0) return;
            GdViewerPreview.DisplayFromGdPictureImage(_currentDocumentCleanUpPreview);
            GdViewerPreview.SetVScrollBarPosition(GdViewer1.GetVScrollBarPosition());
            GdViewerPreview.SetHScrollBarPosition(GdViewer1.GetHScrollBarPosition());
        }

        private void ChangeDocumentCleanUpValues()
        {
            CreateDocumentCleanUpPreviewImage();
            if (_currentDocumentCleanUpPreview == 0) return;
            ApplyDocumentCleanUpValues(_currentDocumentCleanUpPreview);
            DisplayDocumentCleanUpPreviewImage();
        }

        private void ApplyDocumentCleanUpValues(int image)
        {
            GdPictureStatus status = GdPictureStatus.Aborted;
            foreach (var item in _documentCleanUpEffectsQueue)
            {
                if (item.GetType() == typeof(DocumentCleanUp.AutoDeskewEffect))
                {
                    DocumentCleanUp.AutoDeskewEffectParameters @params = (DocumentCleanUp.AutoDeskewEffectParameters)item.Parameters;
                    status = _gdPictureImaging.AutoDeskew(image, @params.MaxAngleOfResearch, @params.BackColor, @params.AngleStep, @params.Optimistic);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.AutoInvertEffect))
                {
                    if (_gdPictureImaging.IsNegative(image))
                    {
                        _gdPictureImaging.FxNegative(image);
                    }
                }
                else if (item.GetType() == typeof(DocumentCleanUp.AutoTextInvertEffect))
                {
                    DocumentCleanUp.AutoTextInvertEffectParameters @params = (DocumentCleanUp.AutoTextInvertEffectParameters)item.Parameters;
                    status = _gdPictureImaging.AutoTextInvert(image, @params.MinObjectWidth, @params.MinObjectHeight, @params.MinBlackPercent, @params.MaxBlackPercent, @params.FixBackground, @params.ConnectedToLines, @params.MaxLinesThickness);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.CropBlackBordersEffect))
                {
                    DocumentCleanUp.CropBlackBordersEffectParameters @params = (DocumentCleanUp.CropBlackBordersEffectParameters)item.Parameters;
                    status = _gdPictureImaging.CropBlackBorders(image, @params.Confidence, @params.SkipLinesCount);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.CropBlackBordersExEffect))
                {
                    DocumentCleanUp.CropBlackBordersEffectExParameters @params = (DocumentCleanUp.CropBlackBordersEffectExParameters)item.Parameters;
                    status = _gdPictureImaging.CropBlackBordersEx(image, @params.Confidence, @params.SkipLinesCount);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.CropBordersEffect))
                {
                    DocumentCleanUp.CropBordersEffectParameters @params = (DocumentCleanUp.CropBordersEffectParameters)item.Parameters;
                    int tempLeft = @params.Left;
                    int tempTop = @params.Top;
                    int tempWidth = @params.Width;
                    int tempHeight = @params.Height;
                    status = _gdPictureImaging.CropBorders(image, @params.Confidence, @params.PixelReference, ref tempLeft, ref tempTop, ref tempWidth, ref tempHeight, @params.Context);
                    @params.Left = tempLeft;
                    @params.Top = tempTop;
                    @params.Width = tempWidth;
                    @params.Height = tempHeight;
                    if (status == GdPictureStatus.OK)
                    {
                        status = _gdPictureImaging.Crop(image, @params.Left, @params.Top, @params.Width, @params.Height);
                    }
                }
                else if (item.GetType() == typeof(DocumentCleanUp.CropWhiteBordersEffect))
                {
                    DocumentCleanUp.CropWhiteBordersEffectParameters @params = (DocumentCleanUp.CropWhiteBordersEffectParameters)item.Parameters;
                    status = _gdPictureImaging.CropWhiteBorders(image, @params.Confidence, @params.SkipLinesCount);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.DeleteBlackBordersEffect))
                {
                    DocumentCleanUp.DeleteBlackBordersEffectParameters @params = (DocumentCleanUp.DeleteBlackBordersEffectParameters)item.Parameters;
                    status = _gdPictureImaging.DeleteBlackBorders(image, @params.Margin, @params.SkewedBorders);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.DespeckleEffect))
                {
                    status = _gdPictureImaging.FxDespeckle(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.DespeckleMoreEffect))
                {
                    status = _gdPictureImaging.FxDespeckleMore(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.DespeckleAdvancedEffect))
                {
                    DocumentCleanUp.DespeckAdvancedParameters @params = (DocumentCleanUp.DespeckAdvancedParameters)item.Parameters;
                    status = _gdPictureImaging.FxBitonalDespeckleAdvanced(image, @params.DespeckleMode, @params.Strength);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.MedianEffect))
                {
                    DocumentCleanUp.MedianEffectParameters @params = (DocumentCleanUp.MedianEffectParameters)item.Parameters;
                    status = _gdPictureImaging.FxMedian(image, @params.KernelSize);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.RemoveBlobEffect))
                {
                    DocumentCleanUp.RemoveBlobEffectParameters @params = (DocumentCleanUp.RemoveBlobEffectParameters)item.Parameters;
                    status = _gdPictureImaging.RemoveBlob(image, @params.MinBlobWidth, @params.MinBlobHeight, @params.MaxBlobWidth, @params.MaxBlobHeight, @params.MinFillPercent, @params.MaxFillPercent);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.RemoveHolePunchEffect))
                {
                    DocumentCleanUp.RemoveHolePunchEffectParameters @params = (DocumentCleanUp.RemoveHolePunchEffectParameters)item.Parameters;
                    status = _gdPictureImaging.RemoveHolePunch(image, @params.Margins);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.RemoveLinesEffect))
                {
                    DocumentCleanUp.RemoveLinesEffectParameters @params = (DocumentCleanUp.RemoveLinesEffectParameters)item.Parameters;
                    status = _gdPictureImaging.RemoveLines(image, @params.Orientation, @params.MaxLineGap, @params.MaxLineThickness, @params.MinLineLength, @params.MaxInterception, @params.ReConnectBrokenCharacters);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.RemoveStapleMarkEffect))
                {
                    status = _gdPictureImaging.RemoveStapleMark(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalClose8Effect))
                {
                    status = _gdPictureImaging.FxBitonalClose8(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalDespeckleEffect))
                {
                    DocumentCleanUp.BitonalDespeckleEffectParameters @params = (DocumentCleanUp.BitonalDespeckleEffectParameters)item.Parameters;
                    status = _gdPictureImaging.FxBitonalDespeckle(image, @params.FixText);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalDespeckleMoreEffect))
                {
                    DocumentCleanUp.BitonalDespeckleMoreEffectParameters @params = (DocumentCleanUp.BitonalDespeckleMoreEffectParameters)item.Parameters;
                    status = _gdPictureImaging.FxBitonalDespeckleMore(image, @params.FixText);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalOutlineEffect))
                {
                    status = _gdPictureImaging.FxBitonalOutline(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalSkeletonizeEffect))
                {
                    DocumentCleanUp.BitonalSkeletonizeEffectParameters @params = (DocumentCleanUp.BitonalSkeletonizeEffectParameters)item.Parameters;
                    status = _gdPictureImaging.FxBitonalSkeletonize(image, @params.Repetition);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalVigorousDespeckleEffect))
                {
                    DocumentCleanUp.BitonalVigorousDespeckleEffectParameters @params = (DocumentCleanUp.BitonalVigorousDespeckleEffectParameters)item.Parameters;
                    status = _gdPictureImaging.FxBitonalVigorousDespeckle(image, @params.CheckForDotOfI);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalDilateEffect))
                {
                    DocumentCleanUp.BitonalDilateEffectParameters @params = (DocumentCleanUp.BitonalDilateEffectParameters)item.Parameters;
                    status = _gdPictureImaging.FxBitonalDilate(image, @params.KernelSize);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalDilate4Effect))
                {
                    status = _gdPictureImaging.FxBitonalDilate4(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalDilate8Effect))
                {
                    status = _gdPictureImaging.FxBitonalDilate8(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalDilateHEffect))
                {
                    status = _gdPictureImaging.FxBitonalDilateH(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalDilateVEffect))
                {
                    status = _gdPictureImaging.FxBitonalDilateV(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalErodeEffect))
                {
                    DocumentCleanUp.BitonalErodeEffectParameters @params = (DocumentCleanUp.BitonalErodeEffectParameters)item.Parameters;
                    status = _gdPictureImaging.FxBitonalErode(image, @params.KernelSize);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalErode4Effect))
                {
                    status = _gdPictureImaging.FxBitonalErode4(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalErode8Effect))
                {
                    status = _gdPictureImaging.FxBitonalErode8(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalErodeVEffect))
                {
                    status = _gdPictureImaging.FxBitonalErodeV(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalFillHolesHEffect))
                {
                    status = _gdPictureImaging.FxBitonalFillHolesH(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalFillHolesHVEffect))
                {
                    status = _gdPictureImaging.FxBitonalFillHolesHV(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalFillHolesVEffect))
                {
                    status = _gdPictureImaging.FxBitonalFillHolesV(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalOpen8Effect))
                {
                    status = _gdPictureImaging.FxBitonalOpen8(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalRemoveIsolatedDots2X2Effect))
                {
                    status = _gdPictureImaging.FxBitonalRemoveIsolatedDots2x2(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalRemoveIsolatedDots4Effect))
                {
                    status = _gdPictureImaging.FxBitonalRemoveIsolatedDots4(image);
                }
                else if (item.GetType() == typeof(DocumentCleanUp.BitonalRemoveIsolatedDots8Effect))
                {
                    status = _gdPictureImaging.FxBitonalRemoveIsolatedDots8(image);
                }
                if (status != GdPictureStatus.OK)
                {
                    MessageBox.Show(this, "Cannot apply effect " + item.Name + ": " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResetEffects_Click(object sender, EventArgs e)
        {
            ResetDocumentCleanUpValues();
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            _gdPictureImaging.CopyToClipboard(_currentImage);
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
            CreateDocumentCleanUpPreviewImage();
            ApplyDocumentCleanUpValues(_currentDocumentCleanUpPreview);
            _gdPictureImaging.ResetROI();
            GdViewer1.ClearRect();
            DisplayDocumentCleanUpPreviewImage();
            UpdateEffectUi();
        }

        private void lstEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEffectUi();
        }

        private void SplitContainer1_Resize(object sender, EventArgs e)
        {
            SplitContainer1.SplitterDistance = (int)((double)SplitContainer1.Width / 2);
        }

        private void btnAddEffect_Click(object sender, EventArgs e)
        {
            if (cbDocumentCleanUpEffects.SelectedIndex == -1) return;
            _documentCleanUpEffectsQueue.Add(_documentCleanUpEffects.List[cbDocumentCleanUpEffects.SelectedIndex].Clone());
            lstEffects.SelectedIndex = -1;
        }

        private void btnRemoveEffect_Click(object sender, EventArgs e)
        {
            if (lstEffects.SelectedIndex != -1)
            {
                _documentCleanUpEffectsQueue.RemoveAt(lstEffects.SelectedIndex);
            }
        }

        private void btnRemoveAllEffects_Click(object sender, EventArgs e)
        {
            _documentCleanUpEffectsQueue.Clear();
        }

        private void pAutoDeskewBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pAutoDeskewBackColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void GdViewer1_ScrollViewer()
        {
            GdViewerPreview.SetHVScrollBarPosition(GdViewer1.GetHScrollBarPosition(), GdViewer1.GetVScrollBarPosition());
        }

        private void UpdateEffectUi()
        {
            tbEffectsParameters.Visible = lstEffects.SelectedIndex != -1;
            if (lstEffects.SelectedIndex == -1) return;
            DocumentCleanUp.ADocumentCleanUpEffect effect = _documentCleanUpEffectsQueue[lstEffects.SelectedIndex];
            if (effect.GetType() == typeof(DocumentCleanUp.AutoDeskewEffect))
            {
                nAutoDeskewMaxAngleOfResearch.DataBindings.Clear();
                nAutoDeskewMaxAngleOfResearch.DataBindings.Add(new Binding("Value", effect.Parameters, "MaxAngleOfResearch"));
                pAutoDeskewBackColor.DataBindings.Clear();
                pAutoDeskewBackColor.DataBindings.Add("BackColor", effect.Parameters, "BackColor", true, DataSourceUpdateMode.OnPropertyChanged);
                nAutoDeskewAngleStep.DataBindings.Clear();
                nAutoDeskewAngleStep.DataBindings.Add("Value", effect.Parameters, "AngleStep");
                chkAutoDeskewOptimistic.DataBindings.Clear();
                chkAutoDeskewOptimistic.DataBindings.Add("Checked", effect.Parameters, "Optimistic");
                tbEffectsParameters.SelectedTab = tpAutoDeskewParameters;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.AutoTextInvertEffect))
            {
                nAutoInvertTextMinObjectWidth.DataBindings.Clear();
                nAutoInvertTextMinObjectWidth.DataBindings.Add("Value", effect.Parameters, "MinObjectWidth");
                nAutoInvertTextMinObjectHeight.DataBindings.Clear();
                nAutoInvertTextMinObjectHeight.DataBindings.Add("Value", effect.Parameters, "MinObjectHeight");
                nAutoInvertTextMinBlackPercent.DataBindings.Clear();
                nAutoInvertTextMinBlackPercent.DataBindings.Add("Value", effect.Parameters, "MinBlackPercent");
                nAutoInvertTextMaxBlackPercent.DataBindings.Clear();
                nAutoInvertTextMaxBlackPercent.DataBindings.Add("Value", effect.Parameters, "MaxBlackPercent");
                chkAutoTextInvertFixBackground.DataBindings.Clear();
                chkAutoTextInvertFixBackground.DataBindings.Add("Checked", effect.Parameters, "FixBackground");
                chkAutoTextInvertConnectedToLines.DataBindings.Clear();
                chkAutoTextInvertConnectedToLines.DataBindings.Add("Checked", effect.Parameters, "ConnectedToLines");
                nAutoInvertTextMaxLinesThickness.DataBindings.Clear();
                nAutoInvertTextMaxLinesThickness.DataBindings.Add("Value", effect.Parameters, "MaxLinesThickness");
                tbEffectsParameters.SelectedTab = tpAutoTextInvert;
            }
            else if (((effect.GetType() == typeof(DocumentCleanUp.CropBlackBordersEffect)) || (effect.GetType() == typeof(DocumentCleanUp.CropBlackBordersExEffect))) || (effect.GetType() == typeof(DocumentCleanUp.CropWhiteBordersEffect)))
            {
                nCropBlackBordersConfidence.DataBindings.Clear();
                nCropBlackBordersConfidence.DataBindings.Add("Value", effect.Parameters, "Confidence");
                nCropBlackBordersSkipLinesCount.DataBindings.Clear();
                nCropBlackBordersSkipLinesCount.DataBindings.Add("Value", effect.Parameters, "SkipLinesCount");
                tbEffectsParameters.SelectedTab = tpCropBlackBorders;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.CropBordersEffect))
            {
                nCropBordersConfidence.DataBindings.Clear();
                nCropBordersConfidence.DataBindings.Add("Value", effect.Parameters, "Confidence");
                cbCropBordersReferencePoint.DataBindings.Clear();
                cbCropBordersReferencePoint.DataBindings.Add("SelectedValue", effect.Parameters, "PixelReference");
                nCropBordersLeft.DataBindings.Clear();
                nCropBordersLeft.DataBindings.Add("Value", effect.Parameters, "Left");
                nCropBordersTop.DataBindings.Clear();
                nCropBordersTop.DataBindings.Add("Value", effect.Parameters, "Top");
                nCropBordersWidth.DataBindings.Clear();
                nCropBordersWidth.DataBindings.Add("Value", effect.Parameters, "Width");
                nCropBordersHeight.DataBindings.Clear();
                nCropBordersHeight.DataBindings.Add("Value", effect.Parameters, "Height");
                cbCropBordersImageContext.DataBindings.Clear();
                cbCropBordersImageContext.DataBindings.Add("SelectedValue", effect.Parameters, "Context");
                tbEffectsParameters.SelectedTab = tpCropBorders;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.DeleteBlackBordersEffect))
            {
                nDeleteBlackBorderEffectMargin.DataBindings.Clear();
                nDeleteBlackBorderEffectMargin.DataBindings.Add("Value", effect.Parameters, "Margin");
                chkDeleteBlackBordersEffectSkewedBorders.DataBindings.Clear();
                chkDeleteBlackBordersEffectSkewedBorders.DataBindings.Add("Checked", effect.Parameters, "SkewedBorders");
                tbEffectsParameters.SelectedTab = tpDeleteBlackBorders;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.DespeckleAdvancedEffect))
            {
                cbDespeckleType.DataBindings.Clear();
                cbDespeckleType.DataBindings.Add("SelectedValue", effect.Parameters, "DespeckleMode");
                nDespeckleStrength.DataBindings.Clear();
                nDespeckleStrength.DataBindings.Add("Value", effect.Parameters, "Strength");
                tbEffectsParameters.SelectedTab = tpDespeckleAdvanced;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.MedianEffect))
            {
                nMedianEffectKernelSize.DataBindings.Clear();
                nMedianEffectKernelSize.DataBindings.Add("Value", effect.Parameters, "KernelSize");
                tbEffectsParameters.SelectedTab = tpMedian;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.RemoveBlobEffect))
            {
                nRemoveBlobEffectMinBlobWidth.DataBindings.Clear();
                nRemoveBlobEffectMinBlobWidth.DataBindings.Add("Value", effect.Parameters, "MinBlobWidth");
                nRemoveBlobEffectMinBlobHeight.DataBindings.Clear();
                nRemoveBlobEffectMinBlobHeight.DataBindings.Add("Value", effect.Parameters, "MinBlobHeight");
                nRemoveBlobEffectMaxBlobWidth.DataBindings.Clear();
                nRemoveBlobEffectMaxBlobWidth.DataBindings.Add("Value", effect.Parameters, "MaxBlobWidth");
                nRemoveBlobEffectMaxBlobHeight.DataBindings.Clear();
                nRemoveBlobEffectMaxBlobHeight.DataBindings.Add("Value", effect.Parameters, "MaxBlobHeight");
                nRemoveBlobEffectMinFillPercent.DataBindings.Clear();
                nRemoveBlobEffectMinFillPercent.DataBindings.Add("Value", effect.Parameters, "MinFillPercent");
                nRemoveBlobEffectMaxFillPercent.DataBindings.Clear();
                nRemoveBlobEffectMaxFillPercent.DataBindings.Add("Value", effect.Parameters, "MaxFillPercent");
                tbEffectsParameters.SelectedTab = tpRemoveBlob;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.RemoveHolePunchEffect))
            {
                cbRemoveHolePunchEffectMargins.DataBindings.Clear();
                cbRemoveHolePunchEffectMargins.DataBindings.Add("SelectedValue", effect.Parameters, "Margins");
                tbEffectsParameters.SelectedTab = tpRemoveHolePunch;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.RemoveLinesEffect))
            {
                cbRemoveLinesEffectOrientation.DataBindings.Clear();
                cbRemoveLinesEffectOrientation.DataBindings.Add("SelectedValue", effect.Parameters, "Orientation");
                nRemoveLinesEffectMaxLineGap.DataBindings.Clear();
                nRemoveLinesEffectMaxLineGap.DataBindings.Add("Value", effect.Parameters, "MaxLineGap");
                nRemoveLinesEffectMaxLineThickness.DataBindings.Clear();
                nRemoveLinesEffectMaxLineThickness.DataBindings.Add("Value", effect.Parameters, "MaxLineThickness");
                nRemoveLinesEffectMinLineLength.DataBindings.Clear();
                nRemoveLinesEffectMinLineLength.DataBindings.Add("Value", effect.Parameters, "MinLineLength");
                nRemoveLinesEffectMaxInterception.DataBindings.Clear();
                nRemoveLinesEffectMaxInterception.DataBindings.Add("Value", effect.Parameters, "MaxInterception");
                chkRemoveLinesEffectReconnectBrokenCharacters.DataBindings.Clear();
                chkRemoveLinesEffectReconnectBrokenCharacters.DataBindings.Add("Checked", effect.Parameters, "ReConnectBrokenCharacters");
                tbEffectsParameters.SelectedTab = tpRemoveLines;
            }
            else if ((effect.GetType() == typeof(DocumentCleanUp.BitonalDespeckleEffect)) || (effect.GetType() == typeof(DocumentCleanUp.BitonalDespeckleMoreEffect)))
            {
                chkBitonalDespeckleEffectFixText.DataBindings.Clear();
                chkBitonalDespeckleEffectFixText.DataBindings.Add("Checked", effect.Parameters, "FixText");
                tbEffectsParameters.SelectedTab = tpBitonalDespeckle;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.BitonalSkeletonizeEffect))
            {
                nBitonalSkeletonizeEffectRepetition.DataBindings.Clear();
                nBitonalSkeletonizeEffectRepetition.DataBindings.Add("Value", effect.Parameters, "Repetition");
                tbEffectsParameters.SelectedTab = tpBitonalSkeletonize;
            }
            else if (effect.GetType() == typeof(DocumentCleanUp.BitonalVigorousDespeckleEffect))
            {
                chkBitonalVigorousDespeckleEffectCheckForDotOfI.DataBindings.Clear();
                chkBitonalVigorousDespeckleEffectCheckForDotOfI.DataBindings.Add("Checked", effect.Parameters, "CheckForDotOfI");
                tbEffectsParameters.SelectedTab = tpBitonalVigorousDespeckle;
            }
            else if ((effect.GetType() == typeof(DocumentCleanUp.BitonalDilateEffect)) || (effect.GetType() == typeof(DocumentCleanUp.BitonalErodeEffect)))
            {
                nBitonalDilateEffectKernelSize.DataBindings.Clear();
                nBitonalDilateEffectKernelSize.DataBindings.Add("Value", effect.Parameters, "KernelSize");
                tbEffectsParameters.SelectedTab = tpBitonalDilate;
            }
            else
            {
                tbEffectsParameters.Visible = false;
            }
        }

        private void btnMoveEffectUp_Click(object sender, EventArgs e)
        {
            if (lstEffects.SelectedIndex == -1)
            {
                return;
            }
            DocumentCleanUp.ADocumentCleanUpEffect item = _documentCleanUpEffectsQueue[lstEffects.SelectedIndex];
            int index = _documentCleanUpEffectsQueue.IndexOf(item);
            if (index == 0)
            {
                return;
            }
            _documentCleanUpEffectsQueue.RemoveAt(index);
            _documentCleanUpEffectsQueue.Insert(index - 1, item);
            lstEffects.SelectedIndex = -1;
        }

        private void btnMoveEffectDown_Click(object sender, EventArgs e)
        {
            if (lstEffects.SelectedIndex == -1)
            {
                return;
            }
            DocumentCleanUp.ADocumentCleanUpEffect item = _documentCleanUpEffectsQueue[lstEffects.SelectedIndex];
            int index = _documentCleanUpEffectsQueue.IndexOf(item);
            if (index == _documentCleanUpEffectsQueue.Count - 1)
            {
                return;
            }
            _documentCleanUpEffectsQueue.RemoveAt(index);
            _documentCleanUpEffectsQueue.Insert(index + 1, item);
            lstEffects.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (frmSave f = new frmSave(_currentDocumentCleanUpPreview))
            {
                f.ShowDialog(this);
            }
        }
    }
}
