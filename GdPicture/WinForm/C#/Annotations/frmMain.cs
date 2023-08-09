using GdPicture14;
using GdPicture14.Annotations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Annotations
{
    public partial class frmMain
    {
        public frmMain()
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

        private int _currentSearchOccurence = 0;
        private bool _toggleGamma = true;
        private bool _annotationEditorMode = true;

        private void frmMain_Load(object sender, EventArgs e)
        {
            LicenseManager oLicenceManager = new LicenseManager();
            oLicenceManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            BookmarksTree1.GdViewer = GdViewer1;
            AnnotationEditor1.InitFromAnnotationManager(GdViewer1.GetAnnotationManager());

            tcLeftPanel.Appearance = TabAppearance.FlatButtons;
            tcLeftPanel.ItemSize = new Size(0, 1);
            tcLeftPanel.SizeMode = TabSizeMode.Fixed;
            SelectSnapIn(3, "Annotations");

            Dictionary<ZoomMode, string> zoomModes = new Dictionary<ZoomMode, string>() {
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

            ToolTip btnRectangleHighlighterTooltip = new ToolTip();
            btnRectangleHighlighterTooltip.SetToolTip(btnAnnotationHighlightedRectangle, "Rectangle highlighter");
            ToolTip btnFreehandHighlighterTooltip = new ToolTip();
            btnFreehandHighlighterTooltip.SetToolTip(btnAnnotationHighlighter, "Freehand highlighter");
            ToolTip btnRectangleTooltip = new ToolTip();
            btnRectangleTooltip.SetToolTip(btnAnnotationRectangle, "Rectangle");
            ToolTip btnFilledRectangleTooltip = new ToolTip();
            btnFilledRectangleTooltip.SetToolTip(btnAnnotationFilledRectangle, "Filled rectangle");
            ToolTip btnEllipseTooltip = new ToolTip();
            btnEllipseTooltip.SetToolTip(btnAnnotationEllipse, "Ellipse");
            ToolTip btnFilledEllipseTooltip = new ToolTip();
            btnFilledEllipseTooltip.SetToolTip(btnAnnotationFilledEllipse, "Filled ellipse");
            ToolTip btnImageTooltip = new ToolTip();
            btnImageTooltip.SetToolTip(btnAnnotationImage, "Image");
            ToolTip btnStampTooltip = new ToolTip();
            btnStampTooltip.SetToolTip(btnAnnotationRubberStamp, "Rubber stamp");
            ToolTip btnLineTooltip = new ToolTip();
            btnLineTooltip.SetToolTip(btnAnnotationLine, "Line");
            ToolTip btnConnectedLinesTooltip = new ToolTip();
            btnConnectedLinesTooltip.SetToolTip(btnAnnotationConnectedLines, "Connected lines");
            ToolTip btnArrowTooltip = new ToolTip();
            btnArrowTooltip.SetToolTip(btnAnnotationArrow, "Arrow");
            ToolTip btnTextTooltip = new ToolTip();
            btnTextTooltip.SetToolTip(btnAnnotationText, "Text");
            ToolTip btnStickyNoteTooltip = new ToolTip();
            btnStickyNoteTooltip.SetToolTip(btnAnnotationStickyNote, "Sticky note");
            ToolTip btnFreehandTooltip = new ToolTip();
            btnFreehandTooltip.SetToolTip(btnAnnotationFreehand, "Freehand drawing");
            ToolTip btnLinkTooltip = new ToolTip();
            btnLinkTooltip.SetToolTip(btnAnnotationLink, "Link");
            ToolTip btnPolygonTooltip = new ToolTip();
            btnPolygonTooltip.SetToolTip(btnAnnotationPolygon, "Polygon");
            ToolTip btnFreehandPolygonTooltip = new ToolTip();
            btnFreehandPolygonTooltip.SetToolTip(btnAnnotationFreehandPolygon, "Freehand polygon");
            ToolTip btnRulerTooltip = new ToolTip();
            btnRulerTooltip.SetToolTip(btnAnnotationRuler, "Ruler");
            ToolTip btnPolyrulerTooltip = new ToolTip();
            btnPolyrulerTooltip.SetToolTip(btnAnnotationPolyRuler, "Polygon ruler");

            rbAllPages.Checked = true;
            ImageList imageListSearchResults = new ImageList();
            imageListSearchResults.ImageSize = new Size(20, 20);
            imageListSearchResults.Images.Add(My.Resources.Resources.search_result);
            lstSearchResults.LargeImageList = imageListSearchResults;
            lstSearchResults.Groups.Add(new ListViewGroup("SearchResult", "Search result"));

            pGamma.Visible = false;
            tbGamma.Value = (int)(GdViewer1.Gamma * 10);
            lblGamma.Text = "Current gamma: " + GdViewer1.Gamma + " (default: 1)";

            ResetSearch();
            UpdateMainUi();
        }

        private void UpdateMainUi()
        {
            Text = "GdPicture.NET " + typeof(GdPictureImaging).Assembly.GetName().Version + " - Annotations Demo";

            if (GdViewer1.PageCount == 0)
            {
                btnClose.Enabled = false;
                btnPrint.Enabled = false;
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
                btnAdjustGamma.Enabled = false;
                btnRotateLeft.Enabled = false;
                btnRotateRight.Enabled = false;
                btnFlipX.Enabled = false;
                btnFlipY.Enabled = false;
                tbCurrentPage.Text = "0";
                lblPageCount.Text = "/ 0";
                cbZoom.SelectedIndex = -1;
                tbSearch.Text = "";
                pSearch.Enabled = false;
                pAnnotations.Enabled = false;
            }
            else
            {
                btnClose.Enabled = true;
                btnPrint.Enabled = true;
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
                btnAdjustGamma.Enabled = true;
                btnRotateLeft.Enabled = true;
                btnRotateRight.Enabled = true;
                btnFlipX.Enabled = true;
                btnFlipY.Enabled = true;
                UpdateaNavigationToolbar();
                pSearch.Enabled = true;
                pAnnotations.Enabled = true;
            }
            GdViewer1.SetAnnotationEditorMode(_annotationEditorMode);
            if (_annotationEditorMode)
            {
                btnSetAnnotationEditorMode.Image = (Image)(My.Resources.Resources.ResourceManager.GetObject("document_unlock"));
                btnSetAnnotationEditorMode.Text = "Click to lock annotations";
            }
            else
            {
                btnSetAnnotationEditorMode.Image = (Image)(My.Resources.Resources.ResourceManager.GetObject("document_lock"));
                btnSetAnnotationEditorMode.Text = "Click to unlock annotations";
            }
            ResetSearch();
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
            GdViewer1.CloseDocument();
            ThumbnailEx1.ClearAllItems();
            UpdateMainUi();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            CloseDocument();

            GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer;
            GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter;

            using (frmOpen frmOpen = new frmOpen(GdViewer1))
            {
                frmOpen.ShowDialog(this);
            }

            GdViewer1.Focus();
            ThumbnailEx1.LoadFromGdViewer(GdViewer1);
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

        private void cbZoom_TextUpdate(object sender, EventArgs e)
        {
            ChangeZoomValue();
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
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.Rotate90FlipNone);
        }

        private void btnFlipX_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.RotateNoneFlipX);
        }

        private void btnFlipY_Click(object sender, EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.RotateNoneFlipY);
        }

        private void GdViewer1_TransferEnded(GdPictureStatus status, bool download)
        {
            GdViewer1.Focus();
            ThumbnailEx1.LoadFromGdViewer(GdViewer1);
            UpdateMainUi();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((GdViewer1.GetDocumentType() != DocumentType.DocumentTypePDF & GdViewer1.GetDocumentType() != DocumentType.DocumentTypeTXT) || string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                return;
            }

            ResetSearch();
            int page = 0;
            bool found = false;
            page = rbAllPages.Checked ? 1 : GdViewer1.CurrentPage;
            bool finish = false;
            int countResults = 0;

            Cursor = Cursors.WaitCursor;
            searchProgressBar.Value = 1;
            searchProgressBar.Maximum = GdViewer1.PageCount;
            searchProgressBar.Visible = true;

            List<ListViewItem> items = new List<ListViewItem>();

            while (!finish)
            {
                lblSearchResults.Text = "Find results for page " + page + " of " + GdViewer1.PageCount;
                searchProgressBar.Increment(1);
                lblSearchResults.Invalidate();
                lblSearchResults.Update();
                lblSearchResults.Refresh();
                searchProgressBar.Invalidate();
                searchProgressBar.Update();
                searchProgressBar.Refresh();
                int count = GetSearchResultCount(page, tbSearch.Text);
                if (count > 0)
                {
                    found = true;
                    ListViewItem item = new ListViewItem(new string[] {"Page " + page, count + " occurence(s) found"}, 0)
                    {
                        Name = "Page" + page,
                        Tag = page,
                        Group = lstSearchResults.Groups[0]
                    };
                    items.Add(item);
                }
                countResults += count;
                page++;
                finish = rbCurrentPage.Checked || page > GdViewer1.PageCount;
            }

            lstSearchResults.Items.AddRange(items.ToArray());

            lstSearchResults.Groups[0].Header = "Search results (" + countResults + ")";
            Cursor = Cursors.Default;

            lblSearchResults.Text = "";
            searchProgressBar.Visible = false;

            if (!found)
            {
                MessageBox.Show("No match found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetSearchResultCount(int page, string searchedTerm)
        {
            return GdViewer1.GetTextOccurrenceCount(page, searchedTerm, chkCaseSensitive.Checked, chkWholeWord.Checked);
        }

        private void ResetSearch()
        {
            btnFindPrevious.Enabled = !string.IsNullOrWhiteSpace(tbSearch.Text);
            btnFindNext.Enabled = !string.IsNullOrWhiteSpace(tbSearch.Text);
            btnSearch.Enabled = !string.IsNullOrWhiteSpace(tbSearch.Text);
            lstSearchResults.Items.Clear();
            GdViewer1.RemoveAllRegions();
            _currentSearchOccurence = 0;
            lblSearchResults.Text = "";
        }

        private void chkWholeWord_CheckedChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void chkCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void rbCurrentPage_CheckedChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void rbAllPages_CheckedChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void cbZoom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ChangeZoomValue();
        }

        private void lstSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedItems.Count == 0) return;
            GdViewer1.RemoveAllRegions();
            ListViewItem item = lstSearchResults.SelectedItems[0];
            int page = Convert.ToInt32(item.Tag);
            if (GdViewer1.CurrentPage != page)
            {
                GdViewer1.DisplayPage(page);
            }
            int occurence = 1;
            float occurenceLeft = 0;
            float occurenceTop = 0;
            float occurenceWidth = 0;
            float occurenceHeight = 0;
            while (GdViewer1.SearchText(page, tbSearch.Text, occurence, chkCaseSensitive.Checked, chkWholeWord.Checked, ref occurenceLeft, ref occurenceTop, ref occurenceWidth, ref occurenceHeight))
            {
                AddSearchRegion(occurence, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight, occurence == 1);
                occurence++;
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            Search(true);
        }

        private void btnFindPrevious_Click(object sender, EventArgs e)
        {
            Search(false);
        }

        private void AddSearchRegion(int occurence, float leftCoordinate, float topCoordinate, float regionWidth, float regionheight, bool ensureVisibility)
        {
            int searchRegion = GdViewer1.AddRegionInches("SearchResult" + Convert.ToString(occurence), leftCoordinate, topCoordinate, regionWidth, regionheight, ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Yellow);
            GdViewer1.SetRegionEditable(searchRegion, false);
            if (ensureVisibility)
            {
                GdViewer1.EnsureRegionVisibility(searchRegion);
            }
        }

        private bool Search(bool ascending)
        {
            bool go = true;
            int page = GdViewer1.CurrentPage;
            bool found = false;
            int newOccurence = 0;
            float occurenceLeft = 0;
            float occurenceTop = 0;
            float occurenceWidth = 0;
            float occurenceHeight = 0;
            if (ascending)
            {
                newOccurence = _currentSearchOccurence + 1;
            }
            else
            {
                newOccurence = _currentSearchOccurence - 1;
            }
            while (go)
            {
                if (GdViewer1.SearchText(page, tbSearch.Text, newOccurence, chkCaseSensitive.Checked, chkWholeWord.Checked, ref occurenceLeft, ref occurenceTop, ref occurenceWidth, ref occurenceHeight))
                {
                    if (page != GdViewer1.CurrentPage)
                    {
                        GdViewer1.DisplayPage(page);
                    }
                    GdViewer1.RemoveAllRegions();
                    AddSearchRegion(newOccurence, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight, true);
                    _currentSearchOccurence = newOccurence;
                    found = true;
                    go = false;
                }
                else
                {
                    if (rbAllPages.Checked)
                    {
                        if (ascending)
                        {
                            page++;
                            newOccurence = 1;
                        }
                        else
                        {
                            page--;
                            newOccurence = GetSearchResultCount(page, tbSearch.Text);
                        }
                        if (page == 0 | page > GdViewer1.PageCount)
                        {
                            go = false;
                        }
                    }
                    else
                    {
                        go = false;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show(this, "No match found !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return found;
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

        private void tbGamma_Scroll(object sender, EventArgs e)
        {
            GdViewer1.Gamma = (float)((double)tbGamma.Value / 10);
            lblGamma.Text = "Current gamma: " + GdViewer1.Gamma + " (default: 1)";
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

        private void btnSnapInBookmarks_Click(object sender, EventArgs e)
        {
            SelectSnapIn(1, "Bookmarks");
        }

        private void btnSnapInSearch_Click(object sender, EventArgs e)
        {
            SelectSnapIn(2, "Search");
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

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            pGamma.Visible = _toggleGamma;
            _toggleGamma = !_toggleGamma;
        }

        private void btnSnapInAnnotations_Click(object sender, EventArgs e)
        {
            SelectSnapIn(3, "Annotations");
        }

        private void btnAnnotationHighlightedRectangle_Click(object sender, EventArgs e)
        {
            GdViewer1.AddRectangleHighlighterAnnotInteractive(Color.Yellow);
        }

        private void btnAnnotationHighlighter_Click(object sender, EventArgs e)
        {
            GdViewer1.AddFreeHandHighlighterAnnotInteractive(Color.Yellow, (float)(0.1));
        }

        private void btnAnnotationRectangle_Click(object sender, EventArgs e)
        {
            GdViewer1.AddRectangleAnnotInteractive(false, true, default(Color), Color.Black, (float)(0.02), 1);
        }

        private void btnAnnotationFilledRectangle_Click(object sender, EventArgs e)
        {
            GdViewer1.AddRectangleAnnotInteractive(true, true, Color.Red, Color.Black, (float)(0.01), 1);
        }

        private void btnAnnotationEllipse_Click(object sender, EventArgs e)
        {
            GdViewer1.AddEllipseAnnotInteractive(false, true, Color.Red, Color.Black, (float)(0.02), 1);
        }

        private void btnAnnotationFilledEllipse_Click(object sender, EventArgs e)
        {
            GdViewer1.AddEllipseAnnotInteractive(true, true, Color.Red, Color.Black, (float)(0.01), 1);
        }

        private void btnAnnotationImage_Click(object sender, EventArgs e)
        {
            GdViewer1.AddEmbeddedImageAnnotInteractive("", false, Color.White, (float)(0.02), 1);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show("Can\'t load bitmap");
            }
        }

        private void btnAnnotationRubberStamp_Click(object sender, EventArgs e)
        {
            GdViewer1.AddRubberStampAnnotInteractive("APPROVED" + Environment.NewLine + "By John Smith", Color.FromArgb(255, 65, 106, 28), "Arial", System.Drawing.FontStyle.Bold, Color.FromArgb(255, 65, 106, 28), (float)(0.2), (float)(0.8), 20);
        }

        private void btnAnnotationLine_Click(object sender, EventArgs e)
        {
            GdViewer1.AddLineAnnotInteractive(Color.Black, (float)(0.02), System.Drawing.Drawing2D.LineCap.Flat, System.Drawing.Drawing2D.LineCap.Flat, 1);
        }

        private void btnAnnotationConnectedLines_Click(object sender, EventArgs e)
        {
            GdViewer1.AddConnectedLinesAnnotInteractive(Color.Black, (float)(0.02), 1);
        }

        private void btnAnnotationArrow_Click(object sender, EventArgs e)
        {
            GdViewer1.AddLineArrowAnnotInteractive(Color.Black, (float)(0.02), 5, 7, true, 1);
        }

        private void btnAnnotationText_Click(object sender, EventArgs e)
        {
            GdViewer1.AddTextAnnotationInteractive("APPROVED" + Environment.NewLine + "By John Smith", Color.Black, "Arial", System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, 12, true, Color.Red, Color.White, 1, 0);
        }

        private void btnAnnotationStickyNote_Click(object sender, EventArgs e)
        {
            GdViewer1.AddStickyNoteAnnotationInteractive("APPROVED" + Environment.NewLine + "By John Smith", Color.Black, "Arial", System.Drawing.FontStyle.Regular, 20, 1, 0);
        }

        private void btnAnnotationFreehand_Click(object sender, EventArgs e)
        {
            GdViewer1.AddFreeHandAnnotInteractive(Color.Black, (float)(0.02), System.Drawing.Drawing2D.LineCap.Flat, System.Drawing.Drawing2D.LineCap.Flat, 1, true);
        }

        private void btnAnnotationLink_Click(object sender, EventArgs e)
        {
            GdViewer1.AddLinkAnnotationInteractive("GdPicture Website", "http://www.gdpicture.com", Color.Blue, Color.Red, "Arial", System.Drawing.FontStyle.Underline, (System.Drawing.FontStyle)(System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Bold), 1, 0);
        }

        private void btnAnnotationPolygon_Click(object sender, EventArgs e)
        {
            GdViewer1.AddPolygonAnnotInteractive(Color.Black, (float)(0.02), Color.Red, 1);
        }

        private void btnAnnotationFreehandPolygon_Click(object sender, EventArgs e)
        {
            GdViewer1.AddFreeHandPolygonAnnotInteractive(Color.Black, (float)(0.02), Color.Red, 1);
        }

        private void btnAnnotationRuler_Click(object sender, EventArgs e)
        {
            GdViewer1.AddRulerAnnotInteractive(Color.Black, (float)(0.02), 1, Annotation.UnitMode.Inch);
        }

        private void btnAnnotationPolyRuler_Click(object sender, EventArgs e)
        {
            GdViewer1.AddPolyRulerAnnotInteractive(Color.Black, (float)(0.02), 1, Annotation.UnitMode.Inch);
        }

        private void GdViewer1_OnCustomAnnotationPaint(AnnotationCustom annot, Graphics g)
        {
            switch (annot.ModelID)
            {
                case 1: //triangle annotation, previously defined by the AddCustomAnnotInteractive() function.
                    using (System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
                    {
                        gp.AddLine(new PointF(annot.Left - annot.Width / 2, annot.Top + annot.Height / 2), new PointF(annot.Left, annot.Top - annot.Height / 2));
                        gp.AddLine(new PointF(annot.Left, annot.Top - annot.Height / 2), new PointF(annot.Left + annot.Width / 2, annot.Top + annot.Height / 2));
                        gp.CloseFigure();
                        g.DrawPath(new Pen(Brushes.Red, (float)(0.1)), gp);
                    }

                    break;
                case 2: //cross annotation, previously defined by the AddCustomAnnotInteractive() function.
                    g.DrawLine(new Pen(Brushes.Red, (float)(0.1)), new PointF(annot.Left - annot.Width / 2, annot.Top - annot.Height / 2), new PointF(annot.Left + annot.Width / 2, annot.Top + annot.Height / 2));
                    g.DrawLine(new Pen(Brushes.Red, (float)(0.1)), new PointF(annot.Left - annot.Width / 2, annot.Top + annot.Height / 2), new PointF(annot.Left + annot.Width / 2, annot.Top - annot.Height / 2));
                    break;
            }
        }

        private void btnCustomAnnotation1_Click(object sender, EventArgs e)
        {
            GdViewer1.AddCustomAnnotInteractive(1);
        }

        private void btnCustomAnnotation2_Click(object sender, EventArgs e)
        {
            GdViewer1.AddCustomAnnotInteractive(2);
        }

        private void btnLoadAnnotationsFromXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Load Annotations from XMP file";
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.Filter = "XMP|*.xmp";
            if (openFileDialog1.ShowDialog(this) != DialogResult.OK) return;
            string filePath = openFileDialog1.FileName;
            if (GdViewer1.LoadAnnotationsFromXMP(filePath) != GdPictureStatus.OK)
            {
                MessageBox.Show("Can\'t load annotations from " + filePath);
            }
        }

        private void SaveCurrentPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Save Annotations As XMP",
                CheckFileExists = false,
                OverwritePrompt = false,
                Filter = "XMP|*.xmp"
            };

            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK) return;
            string filePath = saveFileDialog1.FileName;
            if (GdViewer1.SaveAnnotationsToXMP(filePath) == GdPictureStatus.OK)
            {
                MessageBox.Show("Annotations succefully saved as XMP in " + filePath);
            }
            else
            {
                MessageBox.Show("Can\'t save annotations in " + filePath);
            }
        }

        private void SaveAllPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Save Annotations As XMP",
                CheckFileExists = false,
                OverwritePrompt = false,
                Filter = "XMP|*.xmp"
            };

            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK) return;
            string filePath = saveFileDialog1.FileName;
            if (GdViewer1.SaveAnnotationsToXMPEx(filePath) == GdPictureStatus.OK)
            {
                MessageBox.Show("Annotations succefully saved as XMP in " + filePath);
            }
            else
            {
                MessageBox.Show("Can\'t save annotations in " + filePath);
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            GdViewer1.BurnAnnotationsToPage(true);
        }

        private void RemoveSelectedAnnotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedAnnotation();
        }

        private void RemoveSelectedAnnotation()
        {
            int selectedAnnotIdx = GdViewer1.GetSelectedAnnotationIdx();
            if (selectedAnnotIdx != -1)
            {
                GdViewer1.DeleteAnnotation(selectedAnnotIdx);
            }
        }

        private void RemoveAllAnnotationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAllAnnotations();
        }

        private void RemoveAllAnnotations()
        {
            while (GdViewer1.GetAnnotationCount() > 0)
            {
                GdViewer1.DeleteAnnotation(0);
            }
        }

        private void btnSetAnnotationEditorMode_Click(object sender, EventArgs e)
        {
            _annotationEditorMode = !_annotationEditorMode;
            UpdateMainUi();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Save Annotated Document",
                CheckFileExists = false,
                OverwritePrompt = false,
                Filter = "PDF|*.pdf|TIFF Image|*.tif|JPEG|*.jpg"
            };
            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK) return;
            string filePath = saveFileDialog1.FileName;
            switch (saveFileDialog1.FilterIndex)
            {
                case 1: //PDF
                    if (GdViewer1.SaveDocumentToPDF(saveFileDialog1.FileName) == GdPictureStatus.OK)
                    {
                        MessageBox.Show("Document successfully saved as PDF in " + filePath);
                    }
                    else
                    {
                        MessageBox.Show("Cannot save document in " + filePath);
                    }
                    break;
                case 2: //TIFF
                    if (GdViewer1.SaveDocumentToTIFF(saveFileDialog1.FileName, TiffCompression.TiffCompressionAUTO) == GdPictureStatus.OK)
                    {
                        MessageBox.Show("Document successfully saved as TIFF in " + filePath);
                    }
                    else
                    {
                        MessageBox.Show("Can\'t save document in " + filePath);
                    }
                    break;
                case 3: //JPEG
                    if (GdViewer1.SaveDocumentToJPEG(saveFileDialog1.FileName, 75) == GdPictureStatus.OK)
                    {
                        MessageBox.Show("Document successfully saved as JPEG in " + filePath);
                    }
                    else
                    {
                        MessageBox.Show("Can\'t save document in " + filePath);
                    }
                    break;
            }
        }
    }
}
