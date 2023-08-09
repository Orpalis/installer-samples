using System;


namespace PagesManipulation
{
	partial class frmMain : System.Windows.Forms.Form
	{

        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.Run(new frmMain());
        }
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tcLeftPanel = new System.Windows.Forms.TabControl();
			base.Load += new System.EventHandler(frmMain_Load);
			this.tpThumbnails = new System.Windows.Forms.TabPage();
			this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.thumbnailPanelToolstrip = new System.Windows.Forms.ToolStrip();
			this.btnThumbSize = new System.Windows.Forms.ToolStripDropDownButton();
			this.LargeThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.LargeThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.LargeThumbnailsToolStripMenuItem1_Click);
			this.MediumThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.MediumThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.MediumThumbnailsToolStripMenuItem1_Click);
			this.SmallThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.SmallThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.SmallThumbnailsToolStripMenuItem1_Click);
			this.btnDeleteCurrentPage = new System.Windows.Forms.ToolStripButton();
			this.btnDeleteCurrentPage.Click += new System.EventHandler(this.btnDeleteCurrentPage_Click);
			this.ThumbnailEx1 = new GdPicture14.ThumbnailEx();
			this.ThumbnailEx1.ItemMoved += new GdPicture14.ThumbnailEx.ItemMovedEventHandler(this.ThumbnailEx1_ItemMoved);
			this.tpBookmarks = new System.Windows.Forms.TabPage();
			this.Panel5 = new System.Windows.Forms.Panel();
			this.BookmarksTree1 = new GdPicture14.BookmarksTree();
			this.tpSearch = new System.Windows.Forms.TabPage();
			this.pSearch = new System.Windows.Forms.Panel();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.lstSearchResults = new System.Windows.Forms.ListView();
			this.lstSearchResults.SelectedIndexChanged += new System.EventHandler(this.lstSearchResults_SelectedIndexChanged);
			this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.Panel3 = new System.Windows.Forms.Panel();
			this.searchProgressBar = new System.Windows.Forms.ProgressBar();
			this.lblSearchResults = new System.Windows.Forms.Label();
			this.chkWholeWord = new System.Windows.Forms.CheckBox();
			this.chkWholeWord.CheckedChanged += new System.EventHandler(this.chkWholeWord_CheckedChanged);
			this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
			this.chkCaseSensitive.CheckedChanged += new System.EventHandler(this.chkCaseSensitive_CheckedChanged);
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.rbCurrentPage = new System.Windows.Forms.RadioButton();
			this.rbCurrentPage.CheckedChanged += new System.EventHandler(this.rbCurrentPage_CheckedChanged);
			this.rbAllPages = new System.Windows.Forms.RadioButton();
			this.rbAllPages.CheckedChanged += new System.EventHandler(this.rbAllPages_CheckedChanged);
			this.btnFindPrevious = new System.Windows.Forms.Button();
			this.btnFindPrevious.Click += new System.EventHandler(this.btnFindPrevious_Click);
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			this.btnFindNext = new System.Windows.Forms.Button();
			this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
			this.Panel2 = new System.Windows.Forms.Panel();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			this.Panel1 = new System.Windows.Forms.Panel();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblSearchFor = new System.Windows.Forms.Label();
			this.scMain = new System.Windows.Forms.SplitContainer();
			this.Panel6 = new System.Windows.Forms.Panel();
			this.Panel9 = new System.Windows.Forms.Panel();
			this.Panel7 = new System.Windows.Forms.Panel();
			this.lblSnapInPanel = new System.Windows.Forms.Label();
			this.pSnapInButtons = new System.Windows.Forms.Panel();
			this.btnSnapInThumbnails = new System.Windows.Forms.Button();
			this.btnSnapInThumbnails.Click += new System.EventHandler(this.btnSnapInThumbnails_Click);
			this.btnSnapInBookmarks = new System.Windows.Forms.Button();
			this.btnSnapInBookmarks.Click += new System.EventHandler(this.btnSnapInBookmarks_Click);
			this.btnSnapInSearch = new System.Windows.Forms.Button();
			this.btnSnapInSearch.Click += new System.EventHandler(this.btnSnapInSearch_Click);
			this.pGamma = new System.Windows.Forms.Panel();
			this.lblGamma = new System.Windows.Forms.Label();
			this.tbGamma = new System.Windows.Forms.TrackBar();
			this.tbGamma.Scroll += new System.EventHandler(this.tbGamma_Scroll);
			this.GdViewer1 = new GdPicture14.GdViewer();
			this.GdViewer1.PageChanged += new GdPicture14.GdViewer.PageChangedEventHandler(this.GdViewer1_PageChanged);
			this.GdViewer1.AfterZoomChange += new GdPicture14.GdViewer.AfterZoomChangeEventHandler(this.GdViewer1_AfterZoomChange);
			this.GdViewer1.TransferEnded += new GdPicture14.GdViewer.TransferEndedEventHandler(this.GdViewer1_TransferEnded);
			this.statusbar = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainToolStrip = new System.Windows.Forms.ToolStrip();
			this.btnOpen = new System.Windows.Forms.ToolStripButton();
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnPrint = new System.Windows.Forms.ToolStripButton();
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSettings = new System.Windows.Forms.ToolStripButton();
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.btnMouseMode = new System.Windows.Forms.ToolStripDropDownButton();
			this.DefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DefaultToolStripMenuItem.Click += new System.EventHandler(this.DefaultToolStripMenuItem_Click);
			this.AreaSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AreaSelectionToolStripMenuItem.Click += new System.EventHandler(this.AreaSelectionToolStripMenuItem_Click);
			this.PanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PanToolStripMenuItem.Click += new System.EventHandler(this.PanToolStripMenuItem_Click);
			this.AreaZoomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AreaZoomingToolStripMenuItem.Click += new System.EventHandler(this.AreaZoomingToolStripMenuItem_Click);
			this.MagnifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MagnifierToolStripMenuItem.Click += new System.EventHandler(this.MagnifierToolStripMenuItem_Click);
			this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.btnFirstPage = new System.Windows.Forms.ToolStripButton();
			this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
			this.btnPreviousPage = new System.Windows.Forms.ToolStripButton();
			this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
			this.tbCurrentPage = new System.Windows.Forms.ToolStripTextBox();
			this.tbCurrentPage.Leave += new System.EventHandler(this.tbCurrentPage_Leave);
			this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
			this.btnNextPage = new System.Windows.Forms.ToolStripButton();
			this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
			this.btnLastPage = new System.Windows.Forms.ToolStripButton();
			this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
			this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
			this.cbZoom = new System.Windows.Forms.ToolStripComboBox();
			this.cbZoom.SelectedIndexChanged += new System.EventHandler(this.cbZoom_SelectedIndexChanged);
			this.cbZoom.Validating += new System.ComponentModel.CancelEventHandler(this.cbZoom_TextUpdate);
			this.cbZoom.Validating += new System.ComponentModel.CancelEventHandler(this.cbZoom_Validating);
			this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
			this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnFitWidth = new System.Windows.Forms.ToolStripButton();
			this.btnFitWidth.Click += new System.EventHandler(this.btnFitWidth_Click);
			this.btnFitPage = new System.Windows.Forms.ToolStripButton();
			this.btnFitPage.Click += new System.EventHandler(this.btnFitPage_Click);
			this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnAdjustGamma = new System.Windows.Forms.ToolStripButton();
			this.btnAdjustGamma.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
			this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRotateLeft = new System.Windows.Forms.ToolStripButton();
			this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
			this.btnRotateRight = new System.Windows.Forms.ToolStripButton();
			this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
			this.btnFlipX = new System.Windows.Forms.ToolStripButton();
			this.btnFlipX.Click += new System.EventHandler(this.btnFlipX_Click);
			this.btnFlipY = new System.Windows.Forms.ToolStripButton();
			this.btnFlipY.Click += new System.EventHandler(this.btnFlipY_Click);
			this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnAbout = new System.Windows.Forms.ToolStripButton();
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			this.pMain = new System.Windows.Forms.Panel();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel8 = new System.Windows.Forms.Panel();
			this.Panel10 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.tcLeftPanel.SuspendLayout();
			this.tpThumbnails.SuspendLayout();
			this.ToolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.ToolStripContainer1.ContentPanel.SuspendLayout();
			this.ToolStripContainer1.SuspendLayout();
			this.thumbnailPanelToolstrip.SuspendLayout();
			this.tpBookmarks.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.tpSearch.SuspendLayout();
			this.pSearch.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.scMain).BeginInit();
			this.scMain.Panel1.SuspendLayout();
			this.scMain.Panel2.SuspendLayout();
			this.scMain.SuspendLayout();
			this.Panel6.SuspendLayout();
			this.Panel9.SuspendLayout();
			this.Panel7.SuspendLayout();
			this.pSnapInButtons.SuspendLayout();
			this.pGamma.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.tbGamma).BeginInit();
			this.statusbar.SuspendLayout();
			this.mainToolStrip.SuspendLayout();
			this.pMain.SuspendLayout();
			this.Panel8.SuspendLayout();
			this.Panel10.SuspendLayout();
			this.SuspendLayout();
			//
			//tcLeftPanel
			//
			this.tcLeftPanel.Controls.Add(this.tpThumbnails);
			this.tcLeftPanel.Controls.Add(this.tpBookmarks);
			this.tcLeftPanel.Controls.Add(this.tpSearch);
			this.tcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcLeftPanel.Location = new System.Drawing.Point(0, 32);
			this.tcLeftPanel.Margin = new System.Windows.Forms.Padding(0);
			this.tcLeftPanel.Multiline = true;
			this.tcLeftPanel.Name = "tcLeftPanel";
			this.tcLeftPanel.Padding = new System.Drawing.Point(0, 0);
			this.tcLeftPanel.SelectedIndex = 0;
			this.tcLeftPanel.Size = new System.Drawing.Size(334, 642);
			this.tcLeftPanel.TabIndex = 1;
			//
			//tpThumbnails
			//
			this.tpThumbnails.BackColor = System.Drawing.SystemColors.Control;
			this.tpThumbnails.Controls.Add(this.ToolStripContainer1);
			this.tpThumbnails.Location = new System.Drawing.Point(4, 22);
			this.tpThumbnails.Name = "tpThumbnails";
			this.tpThumbnails.Size = new System.Drawing.Size(326, 616);
			this.tpThumbnails.TabIndex = 0;
			this.tpThumbnails.Text = "Thumbnails";
			//
			//ToolStripContainer1
			//
			//
			//ToolStripContainer1.BottomToolStripPanel
			//
			this.ToolStripContainer1.BottomToolStripPanel.Controls.Add(this.thumbnailPanelToolstrip);
			//
			//ToolStripContainer1.ContentPanel
			//
			this.ToolStripContainer1.ContentPanel.Controls.Add(this.Panel10);
			this.ToolStripContainer1.ContentPanel.Controls.Add(this.Panel8);
			this.ToolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
			this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(326, 591);
			this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.ToolStripContainer1.Name = "ToolStripContainer1";
			this.ToolStripContainer1.Size = new System.Drawing.Size(326, 616);
			this.ToolStripContainer1.TabIndex = 1;
			this.ToolStripContainer1.Text = "ToolStripContainer1";
			//
			//thumbnailPanelToolstrip
			//
			this.thumbnailPanelToolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.thumbnailPanelToolstrip.Dock = System.Windows.Forms.DockStyle.None;
			this.thumbnailPanelToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.thumbnailPanelToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.btnThumbSize, this.btnDeleteCurrentPage});
			this.thumbnailPanelToolstrip.Location = new System.Drawing.Point(0, 0);
			this.thumbnailPanelToolstrip.Name = "thumbnailPanelToolstrip";
			this.thumbnailPanelToolstrip.Padding = new System.Windows.Forms.Padding(0);
			this.thumbnailPanelToolstrip.Size = new System.Drawing.Size(326, 25);
			this.thumbnailPanelToolstrip.Stretch = true;
			this.thumbnailPanelToolstrip.TabIndex = 0;
			//
			//btnThumbSize
			//
			this.btnThumbSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnThumbSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.LargeThumbnailsToolStripMenuItem1, this.MediumThumbnailsToolStripMenuItem1, this.SmallThumbnailsToolStripMenuItem1});
			this.btnThumbSize.Image = (System.Drawing.Image) (resources.GetObject("btnThumbSize.Image"));
			this.btnThumbSize.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnThumbSize.Name = "btnThumbSize";
			this.btnThumbSize.Size = new System.Drawing.Size(29, 22);
			this.btnThumbSize.Text = "btnThumbnailSize";
			this.btnThumbSize.ToolTipText = "Thumbnail size";
			//
			//LargeThumbnailsToolStripMenuItem1
			//
			this.LargeThumbnailsToolStripMenuItem1.Checked = true;
			this.LargeThumbnailsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.LargeThumbnailsToolStripMenuItem1.Name = "LargeThumbnailsToolStripMenuItem1";
			this.LargeThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
			this.LargeThumbnailsToolStripMenuItem1.Text = "Large thumbnails";
			//
			//MediumThumbnailsToolStripMenuItem1
			//
			this.MediumThumbnailsToolStripMenuItem1.Name = "MediumThumbnailsToolStripMenuItem1";
			this.MediumThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
			this.MediumThumbnailsToolStripMenuItem1.Text = "Medium thumbnails";
			//
			//SmallThumbnailsToolStripMenuItem1
			//
			this.SmallThumbnailsToolStripMenuItem1.Name = "SmallThumbnailsToolStripMenuItem1";
			this.SmallThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
			this.SmallThumbnailsToolStripMenuItem1.Text = "Small thumbnails";
			//
			//btnDeleteCurrentPage
			//
			this.btnDeleteCurrentPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDeleteCurrentPage.Image = (System.Drawing.Image) (resources.GetObject("btnDeleteCurrentPage.Image"));
			this.btnDeleteCurrentPage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDeleteCurrentPage.Name = "btnDeleteCurrentPage";
			this.btnDeleteCurrentPage.Size = new System.Drawing.Size(23, 22);
			this.btnDeleteCurrentPage.Text = "Delete current page";
			//
			//ThumbnailEx1
			//
			this.ThumbnailEx1.AllowDropFiles = false;
			this.ThumbnailEx1.AllowMoveItems = true;
			this.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control;
			this.ThumbnailEx1.CheckBoxes = false;
			this.ThumbnailEx1.CheckBoxesMarginLeft = 0;
			this.ThumbnailEx1.CheckBoxesMarginTop = 0;
			this.ThumbnailEx1.DisplayAnnotations = true;
			this.ThumbnailEx1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ThumbnailEx1.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
			this.ThumbnailEx1.HotTracking = false;
			this.ThumbnailEx1.Location = new System.Drawing.Point(0, 0);
			this.ThumbnailEx1.LockGdViewerEvents = false;
			this.ThumbnailEx1.MultiSelect = true;
			this.ThumbnailEx1.Name = "ThumbnailEx1";
			this.ThumbnailEx1.OwnDrop = false;
			this.ThumbnailEx1.PauseThumbsLoading = false;
			this.ThumbnailEx1.PdfIncreaseTextContrast = false;
			this.ThumbnailEx1.PreloadAllItems = false;
			this.ThumbnailEx1.RotateExif = true;
			this.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(51)), System.Convert.ToInt32(System.Convert.ToByte(153)), System.Convert.ToInt32(System.Convert.ToByte(255)));
			this.ThumbnailEx1.ShowText = true;
			this.ThumbnailEx1.Size = new System.Drawing.Size(326, 524);
			this.ThumbnailEx1.TabIndex = 0;
			this.ThumbnailEx1.TextMarginLeft = 0;
			this.ThumbnailEx1.TextMarginTop = 0;
			this.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical;
			this.ThumbnailEx1.ThumbnailBorder = true;
			this.ThumbnailEx1.ThumbnailSize = new System.Drawing.Size(256, 256);
			this.ThumbnailEx1.ThumbnailSpacing = new System.Drawing.Size(0, 0);
			this.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
			//
			//tpBookmarks
			//
			this.tpBookmarks.BackColor = System.Drawing.SystemColors.Control;
			this.tpBookmarks.Controls.Add(this.Panel5);
			this.tpBookmarks.Location = new System.Drawing.Point(4, 22);
			this.tpBookmarks.Name = "tpBookmarks";
			this.tpBookmarks.Size = new System.Drawing.Size(326, 616);
			this.tpBookmarks.TabIndex = 1;
			this.tpBookmarks.Text = "Bookmarks";
			//
			//Panel5
			//
			this.Panel5.Controls.Add(this.BookmarksTree1);
			this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel5.Location = new System.Drawing.Point(0, 0);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new System.Drawing.Size(326, 616);
			this.Panel5.TabIndex = 1;
			//
			//BookmarksTree1
			//
			this.BookmarksTree1.BackColor = System.Drawing.SystemColors.Control;
			this.BookmarksTree1.DisableZoomDestination = false;
			this.BookmarksTree1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BookmarksTree1.FontName = "Helvetica";
			this.BookmarksTree1.FontSize = (float) (10.0F);
			this.BookmarksTree1.GdViewer = null;
			this.BookmarksTree1.ItemHeight = 20;
			this.BookmarksTree1.Location = new System.Drawing.Point(0, 0);
			this.BookmarksTree1.Name = "BookmarksTree1";
			this.BookmarksTree1.Padding = new System.Windows.Forms.Padding(10);
			this.BookmarksTree1.Size = new System.Drawing.Size(326, 616);
			this.BookmarksTree1.TabIndex = 0;
			//
			//tpSearch
			//
			this.tpSearch.BackColor = System.Drawing.SystemColors.Control;
			this.tpSearch.Controls.Add(this.pSearch);
			this.tpSearch.Location = new System.Drawing.Point(4, 22);
			this.tpSearch.Name = "tpSearch";
			this.tpSearch.Size = new System.Drawing.Size(326, 616);
			this.tpSearch.TabIndex = 2;
			this.tpSearch.Text = "Search";
			//
			//pSearch
			//
			this.pSearch.BackColor = System.Drawing.SystemColors.Control;
			this.pSearch.Controls.Add(this.Panel4);
			this.pSearch.Controls.Add(this.Panel3);
			this.pSearch.Controls.Add(this.Panel2);
			this.pSearch.Controls.Add(this.Panel1);
			this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pSearch.Location = new System.Drawing.Point(0, 0);
			this.pSearch.Name = "pSearch";
			this.pSearch.Padding = new System.Windows.Forms.Padding(10);
			this.pSearch.Size = new System.Drawing.Size(326, 616);
			this.pSearch.TabIndex = 0;
			//
			//Panel4
			//
			this.Panel4.Controls.Add(this.lstSearchResults);
			this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel4.Location = new System.Drawing.Point(10, 283);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(306, 323);
			this.Panel4.TabIndex = 17;
			//
			//lstSearchResults
			//
			this.lstSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3});
			this.lstSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstSearchResults.FullRowSelect = true;
			this.lstSearchResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lstSearchResults.Location = new System.Drawing.Point(0, 0);
			this.lstSearchResults.MultiSelect = false;
			this.lstSearchResults.Name = "lstSearchResults";
			this.lstSearchResults.Size = new System.Drawing.Size(306, 323);
			this.lstSearchResults.TabIndex = 10;
			this.lstSearchResults.UseCompatibleStateImageBehavior = false;
			this.lstSearchResults.View = System.Windows.Forms.View.Tile;
			//
			//Panel3
			//
			this.Panel3.Controls.Add(this.searchProgressBar);
			this.Panel3.Controls.Add(this.lblSearchResults);
			this.Panel3.Controls.Add(this.chkWholeWord);
			this.Panel3.Controls.Add(this.chkCaseSensitive);
			this.Panel3.Controls.Add(this.GroupBox2);
			this.Panel3.Controls.Add(this.btnFindPrevious);
			this.Panel3.Controls.Add(this.btnSearch);
			this.Panel3.Controls.Add(this.btnFindNext);
			this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.Panel3.Location = new System.Drawing.Point(10, 63);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(306, 220);
			this.Panel3.TabIndex = 16;
			//
			//searchProgressBar
			//
			this.searchProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.searchProgressBar.Location = new System.Drawing.Point(0, 210);
			this.searchProgressBar.Minimum = 1;
			this.searchProgressBar.Name = "searchProgressBar";
			this.searchProgressBar.Size = new System.Drawing.Size(306, 10);
			this.searchProgressBar.TabIndex = 15;
			this.searchProgressBar.Value = 1;
			this.searchProgressBar.Visible = false;
			//
			//lblSearchResults
			//
			this.lblSearchResults.AutoSize = true;
			this.lblSearchResults.Location = new System.Drawing.Point(6, 191);
			this.lblSearchResults.Name = "lblSearchResults";
			this.lblSearchResults.Size = new System.Drawing.Size(78, 13);
			this.lblSearchResults.TabIndex = 14;
			this.lblSearchResults.Text = "Find result from";
			//
			//chkWholeWord
			//
			this.chkWholeWord.AutoSize = true;
			this.chkWholeWord.Location = new System.Drawing.Point(3, 3);
			this.chkWholeWord.Name = "chkWholeWord";
			this.chkWholeWord.Size = new System.Drawing.Size(113, 17);
			this.chkWholeWord.TabIndex = 1;
			this.chkWholeWord.Text = "Match whole word";
			this.chkWholeWord.UseVisualStyleBackColor = true;
			//
			//chkCaseSensitive
			//
			this.chkCaseSensitive.AutoSize = true;
			this.chkCaseSensitive.Location = new System.Drawing.Point(3, 26);
			this.chkCaseSensitive.Name = "chkCaseSensitive";
			this.chkCaseSensitive.Size = new System.Drawing.Size(82, 17);
			this.chkCaseSensitive.TabIndex = 2;
			this.chkCaseSensitive.Text = "Match case";
			this.chkCaseSensitive.UseVisualStyleBackColor = true;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.rbCurrentPage);
			this.GroupBox2.Controls.Add(this.rbAllPages);
			this.GroupBox2.Location = new System.Drawing.Point(3, 49);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(188, 70);
			this.GroupBox2.TabIndex = 7;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Search in";
			//
			//rbCurrentPage
			//
			this.rbCurrentPage.AutoSize = true;
			this.rbCurrentPage.Location = new System.Drawing.Point(6, 19);
			this.rbCurrentPage.Name = "rbCurrentPage";
			this.rbCurrentPage.Size = new System.Drawing.Size(85, 17);
			this.rbCurrentPage.TabIndex = 3;
			this.rbCurrentPage.TabStop = true;
			this.rbCurrentPage.Text = "current page";
			this.rbCurrentPage.UseVisualStyleBackColor = true;
			//
			//rbAllPages
			//
			this.rbAllPages.AutoSize = true;
			this.rbAllPages.Location = new System.Drawing.Point(6, 42);
			this.rbAllPages.Name = "rbAllPages";
			this.rbAllPages.Size = new System.Drawing.Size(67, 17);
			this.rbAllPages.TabIndex = 4;
			this.rbAllPages.TabStop = true;
			this.rbAllPages.Text = "all pages";
			this.rbAllPages.UseVisualStyleBackColor = true;
			//
			//btnFindPrevious
			//
			this.btnFindPrevious.Location = new System.Drawing.Point(3, 125);
			this.btnFindPrevious.Name = "btnFindPrevious";
			this.btnFindPrevious.Size = new System.Drawing.Size(91, 23);
			this.btnFindPrevious.TabIndex = 13;
			this.btnFindPrevious.Text = "Find previous";
			this.btnFindPrevious.UseVisualStyleBackColor = true;
			//
			//btnSearch
			//
			this.btnSearch.Location = new System.Drawing.Point(3, 154);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 5;
			this.btnSearch.Text = "Search All";
			this.btnSearch.UseVisualStyleBackColor = true;
			//
			//btnFindNext
			//
			this.btnFindNext.Location = new System.Drawing.Point(100, 125);
			this.btnFindNext.Name = "btnFindNext";
			this.btnFindNext.Size = new System.Drawing.Size(91, 23);
			this.btnFindNext.TabIndex = 12;
			this.btnFindNext.Text = "Find next";
			this.btnFindNext.UseVisualStyleBackColor = true;
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.tbSearch);
			this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new System.Drawing.Point(10, 36);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(306, 27);
			this.Panel2.TabIndex = 15;
			//
			//tbSearch
			//
			this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbSearch.Location = new System.Drawing.Point(0, 0);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(306, 20);
			this.tbSearch.TabIndex = 0;
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.lblSearchFor);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new System.Drawing.Point(10, 10);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(306, 26);
			this.Panel1.TabIndex = 14;
			//
			//PictureBox1
			//
			this.PictureBox1.Image = (System.Drawing.Image) (resources.GetObject("PictureBox1.Image"));
			this.PictureBox1.Location = new System.Drawing.Point(3, 3);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(20, 20);
			this.PictureBox1.TabIndex = 11;
			this.PictureBox1.TabStop = false;
			//
			//lblSearchFor
			//
			this.lblSearchFor.AutoSize = true;
			this.lblSearchFor.Location = new System.Drawing.Point(29, 7);
			this.lblSearchFor.Name = "lblSearchFor";
			this.lblSearchFor.Size = new System.Drawing.Size(56, 13);
			this.lblSearchFor.TabIndex = 8;
			this.lblSearchFor.Text = "Search for";
			//
			//scMain
			//
			this.scMain.BackColor = System.Drawing.SystemColors.Control;
			this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.scMain.Location = new System.Drawing.Point(0, 0);
			this.scMain.Name = "scMain";
			//
			//scMain.Panel1
			//
			this.scMain.Panel1.BackColor = System.Drawing.SystemColors.Window;
			this.scMain.Panel1.Controls.Add(this.Panel6);
			this.scMain.Panel1MinSize = 256;
			//
			//scMain.Panel2
			//
			this.scMain.Panel2.Controls.Add(this.pGamma);
			this.scMain.Panel2.Controls.Add(this.GdViewer1);
			this.scMain.Panel2MinSize = 200;
			this.scMain.Size = new System.Drawing.Size(1264, 676);
			this.scMain.SplitterDistance = 368;
			this.scMain.TabIndex = 2;
			//
			//Panel6
			//
			this.Panel6.Controls.Add(this.Panel9);
			this.Panel6.Controls.Add(this.pSnapInButtons);
			this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel6.Location = new System.Drawing.Point(0, 0);
			this.Panel6.Margin = new System.Windows.Forms.Padding(0);
			this.Panel6.Name = "Panel6";
			this.Panel6.Size = new System.Drawing.Size(366, 674);
			this.Panel6.TabIndex = 2;
			//
			//Panel9
			//
			this.Panel9.BackColor = System.Drawing.SystemColors.Control;
			this.Panel9.Controls.Add(this.tcLeftPanel);
			this.Panel9.Controls.Add(this.Panel7);
			this.Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel9.Location = new System.Drawing.Point(32, 0);
			this.Panel9.Name = "Panel9";
			this.Panel9.Size = new System.Drawing.Size(334, 674);
			this.Panel9.TabIndex = 5;
			//
			//Panel7
			//
			this.Panel7.BackColor = System.Drawing.SystemColors.Control;
			this.Panel7.Controls.Add(this.lblSnapInPanel);
			this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.Panel7.Location = new System.Drawing.Point(0, 0);
			this.Panel7.Name = "Panel7";
			this.Panel7.Size = new System.Drawing.Size(334, 32);
			this.Panel7.TabIndex = 6;
			//
			//lblSnapInPanel
			//
			this.lblSnapInPanel.AutoSize = true;
			this.lblSnapInPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblSnapInPanel.Location = new System.Drawing.Point(6, 8);
			this.lblSnapInPanel.Name = "lblSnapInPanel";
			this.lblSnapInPanel.Size = new System.Drawing.Size(82, 15);
			this.lblSnapInPanel.TabIndex = 0;
			this.lblSnapInPanel.Text = "Thumbnails";
			//
			//pSnapInButtons
			//
			this.pSnapInButtons.AutoSize = true;
			this.pSnapInButtons.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pSnapInButtons.Controls.Add(this.btnSnapInThumbnails);
			this.pSnapInButtons.Controls.Add(this.btnSnapInBookmarks);
			this.pSnapInButtons.Controls.Add(this.btnSnapInSearch);
			this.pSnapInButtons.Dock = System.Windows.Forms.DockStyle.Left;
			this.pSnapInButtons.Location = new System.Drawing.Point(0, 0);
			this.pSnapInButtons.Name = "pSnapInButtons";
			this.pSnapInButtons.Size = new System.Drawing.Size(32, 674);
			this.pSnapInButtons.TabIndex = 4;
			//
			//btnSnapInThumbnails
			//
			this.btnSnapInThumbnails.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnSnapInThumbnails.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btnSnapInThumbnails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSnapInThumbnails.Image = (System.Drawing.Image) (resources.GetObject("btnSnapInThumbnails.Image"));
			this.btnSnapInThumbnails.Location = new System.Drawing.Point(0, 0);
			this.btnSnapInThumbnails.Margin = new System.Windows.Forms.Padding(0);
			this.btnSnapInThumbnails.Name = "btnSnapInThumbnails";
			this.btnSnapInThumbnails.Size = new System.Drawing.Size(32, 32);
			this.btnSnapInThumbnails.TabIndex = 0;
			this.btnSnapInThumbnails.UseVisualStyleBackColor = false;
			//
			//btnSnapInBookmarks
			//
			this.btnSnapInBookmarks.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnSnapInBookmarks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
			this.btnSnapInBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSnapInBookmarks.Image = (System.Drawing.Image) (resources.GetObject("btnSnapInBookmarks.Image"));
			this.btnSnapInBookmarks.Location = new System.Drawing.Point(0, 31);
			this.btnSnapInBookmarks.Margin = new System.Windows.Forms.Padding(0);
			this.btnSnapInBookmarks.Name = "btnSnapInBookmarks";
			this.btnSnapInBookmarks.Size = new System.Drawing.Size(32, 32);
			this.btnSnapInBookmarks.TabIndex = 1;
			this.btnSnapInBookmarks.UseVisualStyleBackColor = false;
			//
			//btnSnapInSearch
			//
			this.btnSnapInSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnSnapInSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
			this.btnSnapInSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSnapInSearch.Image = (System.Drawing.Image) (resources.GetObject("btnSnapInSearch.Image"));
			this.btnSnapInSearch.Location = new System.Drawing.Point(0, 62);
			this.btnSnapInSearch.Margin = new System.Windows.Forms.Padding(0);
			this.btnSnapInSearch.Name = "btnSnapInSearch";
			this.btnSnapInSearch.Size = new System.Drawing.Size(32, 32);
			this.btnSnapInSearch.TabIndex = 2;
			this.btnSnapInSearch.UseVisualStyleBackColor = false;
			//
			//pGamma
			//
			this.pGamma.AutoSize = true;
			this.pGamma.BackColor = System.Drawing.SystemColors.Control;
			this.pGamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pGamma.Controls.Add(this.lblGamma);
			this.pGamma.Controls.Add(this.tbGamma);
			this.pGamma.Location = new System.Drawing.Point(3, 3);
			this.pGamma.Name = "pGamma";
			this.pGamma.Size = new System.Drawing.Size(317, 62);
			this.pGamma.TabIndex = 1;
			//
			//lblGamma
			//
			this.lblGamma.AutoSize = true;
			this.lblGamma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblGamma.Location = new System.Drawing.Point(3, 42);
			this.lblGamma.Name = "lblGamma";
			this.lblGamma.Size = new System.Drawing.Size(76, 13);
			this.lblGamma.TabIndex = 1;
			this.lblGamma.Text = "Current value: ";
			//
			//tbGamma
			//
			this.tbGamma.Location = new System.Drawing.Point(3, 0);
			this.tbGamma.Maximum = 50;
			this.tbGamma.Minimum = 1;
			this.tbGamma.Name = "tbGamma";
			this.tbGamma.Size = new System.Drawing.Size(309, 45);
			this.tbGamma.TabIndex = 0;
			this.tbGamma.Value = 1;
			//
			//GdViewer1
			//
			this.GdViewer1.AllowDropFile = false;
			this.GdViewer1.AnimateGIF = true;
			this.GdViewer1.AnnotationDropShadow = true;
			this.GdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.GdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.GdViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.GdViewer1.BackgroundImage = null;
			this.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.GdViewer1.ContinuousViewMode = true;
			this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
			this.GdViewer1.DisplayQualityAuto = true;
			this.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
			this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
			this.GdViewer1.EnabledProgressBar = true;
			this.GdViewer1.EnableICM = false;
			this.GdViewer1.EnableMenu = true;
			this.GdViewer1.EnableMouseWheel = true;
			this.GdViewer1.EnableTextSelection = true;
			this.GdViewer1.ForceScrollBars = false;
			this.GdViewer1.ForeColor = System.Drawing.Color.Black;
			this.GdViewer1.Gamma = (float) (1.0F);
			this.GdViewer1.HQAnnotationRendering = true;
			this.GdViewer1.IgnoreDocumentResolution = false;
			this.GdViewer1.KeepDocumentPosition = false;
			this.GdViewer1.Location = new System.Drawing.Point(0, 0);
			this.GdViewer1.LockViewer = false;
			this.GdViewer1.MagnifierHeight = 90;
			this.GdViewer1.MagnifierWidth = 160;
			this.GdViewer1.MagnifierZoomX = (float) (2.0F);
			this.GdViewer1.MagnifierZoomY = (float) (2.0F);
			this.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
			this.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
			this.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
			this.GdViewer1.Name = "GdViewer1";
			this.GdViewer1.PdfDisplayFormField = true;
			this.GdViewer1.PdfEnableFileLinks = true;
			this.GdViewer1.PdfEnableLinks = true;
			this.GdViewer1.PdfIncreaseTextContrast = false;
			this.GdViewer1.PdfShowDialogForPassword = true;
			this.GdViewer1.PdfShowOpenFileDialogForDecryption = true;
			this.GdViewer1.PdfVerifyDigitalCertificates = false;
			this.GdViewer1.RectBorderColor = System.Drawing.Color.Black;
			this.GdViewer1.RectBorderSize = 1;
			this.GdViewer1.RectIsEditable = true;
			this.GdViewer1.RegionsAreEditable = true;
			this.GdViewer1.ScrollBars = true;
			this.GdViewer1.ScrollLargeChange = (short) (50);
			this.GdViewer1.ScrollSmallChange = (short) (1);
			this.GdViewer1.SilentMode = true;
			this.GdViewer1.Size = new System.Drawing.Size(890, 674);
			this.GdViewer1.TabIndex = 0;
			this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
			this.GdViewer1.Zoom = 0.001D;
			this.GdViewer1.ZoomCenterAtMousePosition = false;
			this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
			this.GdViewer1.ZoomStep = 25;
			//
			//statusbar
			//
			this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripStatusLabel1});
			this.statusbar.Location = new System.Drawing.Point(0, 707);
			this.statusbar.Name = "statusbar";
			this.statusbar.Size = new System.Drawing.Size(1264, 22);
			this.statusbar.TabIndex = 3;
			this.statusbar.Text = "StatusStrip1";
			//
			//ToolStripStatusLabel1
			//
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			//
			//mainToolStrip
			//
			this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.btnOpen, this.ToolStripSeparator9, this.btnClose, this.btnPrint, this.btnSave, this.ToolStripSeparator3, this.btnSettings, this.ToolStripSeparator8, this.btnMouseMode, this.ToolStripSeparator6, this.btnFirstPage, this.btnPreviousPage, this.tbCurrentPage, this.lblPageCount, this.btnNextPage, this.btnLastPage, this.ToolStripSeparator1, this.btnZoomOut, this.cbZoom, this.btnZoomIn, this.ToolStripSeparator2, this.btnFitWidth, this.btnFitPage, this.ToolStripSeparator5, this.btnAdjustGamma, this.ToolStripSeparator10, this.btnRotateLeft, this.btnRotateRight, this.btnFlipX, this.btnFlipY, this.ToolStripSeparator4, this.btnAbout});
			this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
			this.mainToolStrip.Name = "mainToolStrip";
			this.mainToolStrip.Size = new System.Drawing.Size(1264, 31);
			this.mainToolStrip.TabIndex = 5;
			this.mainToolStrip.Text = "ToolStrip1";
			//
			//btnOpen
			//
			this.btnOpen.Font = new System.Drawing.Font("Segoe UI", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btnOpen.Image = (System.Drawing.Image) (resources.GetObject("btnOpen.Image"));
			this.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnOpen.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(130, 28);
			this.btnOpen.Text = "Open document";
			//
			//ToolStripSeparator9
			//
			this.ToolStripSeparator9.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
			this.ToolStripSeparator9.Name = "ToolStripSeparator9";
			this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 31);
			//
			//btnClose
			//
			this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnClose.Image = (System.Drawing.Image) (resources.GetObject("btnClose.Image"));
			this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(28, 28);
			this.btnClose.Text = "Close document";
			//
			//btnPrint
			//
			this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPrint.Image = (System.Drawing.Image) (resources.GetObject("btnPrint.Image"));
			this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(28, 28);
			this.btnPrint.Text = "Print document";
			//
			//ToolStripSeparator3
			//
			this.ToolStripSeparator3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 31);
			//
			//btnSettings
			//
			this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSettings.Image = (System.Drawing.Image) (resources.GetObject("btnSettings.Image"));
			this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(28, 28);
			this.btnSettings.Text = "Viewer settings";
			//
			//ToolStripSeparator8
			//
			this.ToolStripSeparator8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripSeparator8.Name = "ToolStripSeparator8";
			this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 31);
			//
			//btnMouseMode
			//
			this.btnMouseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnMouseMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.DefaultToolStripMenuItem, this.AreaSelectionToolStripMenuItem, this.PanToolStripMenuItem, this.AreaZoomingToolStripMenuItem, this.MagnifierToolStripMenuItem});
			this.btnMouseMode.Image = (System.Drawing.Image) (resources.GetObject("btnMouseMode.Image"));
			this.btnMouseMode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnMouseMode.Name = "btnMouseMode";
			this.btnMouseMode.Size = new System.Drawing.Size(37, 28);
			this.btnMouseMode.Text = "Mouse mode";
			//
			//DefaultToolStripMenuItem
			//
			this.DefaultToolStripMenuItem.CheckOnClick = true;
			this.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem";
			this.DefaultToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.DefaultToolStripMenuItem.Text = "Default";
			//
			//AreaSelectionToolStripMenuItem
			//
			this.AreaSelectionToolStripMenuItem.CheckOnClick = true;
			this.AreaSelectionToolStripMenuItem.Name = "AreaSelectionToolStripMenuItem";
			this.AreaSelectionToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.AreaSelectionToolStripMenuItem.Text = "Area selection";
			//
			//PanToolStripMenuItem
			//
			this.PanToolStripMenuItem.Checked = true;
			this.PanToolStripMenuItem.CheckOnClick = true;
			this.PanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.PanToolStripMenuItem.Name = "PanToolStripMenuItem";
			this.PanToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.PanToolStripMenuItem.Text = "Pan";
			//
			//AreaZoomingToolStripMenuItem
			//
			this.AreaZoomingToolStripMenuItem.CheckOnClick = true;
			this.AreaZoomingToolStripMenuItem.Name = "AreaZoomingToolStripMenuItem";
			this.AreaZoomingToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.AreaZoomingToolStripMenuItem.Text = "Area zooming";
			//
			//MagnifierToolStripMenuItem
			//
			this.MagnifierToolStripMenuItem.CheckOnClick = true;
			this.MagnifierToolStripMenuItem.Name = "MagnifierToolStripMenuItem";
			this.MagnifierToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.MagnifierToolStripMenuItem.Text = "Magnifier";
			//
			//ToolStripSeparator6
			//
			this.ToolStripSeparator6.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
			this.ToolStripSeparator6.Name = "ToolStripSeparator6";
			this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 31);
			//
			//btnFirstPage
			//
			this.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFirstPage.Image = (System.Drawing.Image) (resources.GetObject("btnFirstPage.Image"));
			this.btnFirstPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFirstPage.Name = "btnFirstPage";
			this.btnFirstPage.Size = new System.Drawing.Size(28, 28);
			this.btnFirstPage.Text = "Go to first page";
			//
			//btnPreviousPage
			//
			this.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPreviousPage.Image = (System.Drawing.Image) (resources.GetObject("btnPreviousPage.Image"));
			this.btnPreviousPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPreviousPage.Name = "btnPreviousPage";
			this.btnPreviousPage.Size = new System.Drawing.Size(28, 28);
			this.btnPreviousPage.Text = "Go to previous page";
			//
			//tbCurrentPage
			//
			this.tbCurrentPage.Font = new System.Drawing.Font("Segoe UI", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.tbCurrentPage.Name = "tbCurrentPage";
			this.tbCurrentPage.Size = new System.Drawing.Size(40, 31);
			this.tbCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//lblPageCount
			//
			this.lblPageCount.Font = new System.Drawing.Font("Segoe UI", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblPageCount.Name = "lblPageCount";
			this.lblPageCount.Size = new System.Drawing.Size(25, 28);
			this.lblPageCount.Text = "/ X";
			//
			//btnNextPage
			//
			this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnNextPage.Image = (System.Drawing.Image) (resources.GetObject("btnNextPage.Image"));
			this.btnNextPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNextPage.Name = "btnNextPage";
			this.btnNextPage.Size = new System.Drawing.Size(28, 28);
			this.btnNextPage.Text = "Go to next page";
			//
			//btnLastPage
			//
			this.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnLastPage.Image = (System.Drawing.Image) (resources.GetObject("btnLastPage.Image"));
			this.btnLastPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLastPage.Name = "btnLastPage";
			this.btnLastPage.Size = new System.Drawing.Size(28, 28);
			this.btnLastPage.Text = "Go to last page";
			//
			//ToolStripSeparator1
			//
			this.ToolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 31);
			//
			//btnZoomOut
			//
			this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnZoomOut.Image = (System.Drawing.Image) (resources.GetObject("btnZoomOut.Image"));
			this.btnZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnZoomOut.Name = "btnZoomOut";
			this.btnZoomOut.Size = new System.Drawing.Size(28, 28);
			this.btnZoomOut.Text = "Zoom out";
			//
			//cbZoom
			//
			this.cbZoom.DropDownWidth = 200;
			this.cbZoom.Name = "cbZoom";
			this.cbZoom.Size = new System.Drawing.Size(75, 31);
			//
			//btnZoomIn
			//
			this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnZoomIn.Image = (System.Drawing.Image) (resources.GetObject("btnZoomIn.Image"));
			this.btnZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnZoomIn.Name = "btnZoomIn";
			this.btnZoomIn.Size = new System.Drawing.Size(28, 28);
			this.btnZoomIn.Text = "Zoom In";
			//
			//ToolStripSeparator2
			//
			this.ToolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 31);
			//
			//btnFitWidth
			//
			this.btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFitWidth.Image = (System.Drawing.Image) (resources.GetObject("btnFitWidth.Image"));
			this.btnFitWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFitWidth.Name = "btnFitWidth";
			this.btnFitWidth.Size = new System.Drawing.Size(28, 28);
			this.btnFitWidth.Text = "Adjust to page width";
			//
			//btnFitPage
			//
			this.btnFitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFitPage.Image = (System.Drawing.Image) (resources.GetObject("btnFitPage.Image"));
			this.btnFitPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnFitPage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFitPage.Name = "btnFitPage";
			this.btnFitPage.Size = new System.Drawing.Size(28, 28);
			this.btnFitPage.Text = "Adjust to whole page";
			//
			//ToolStripSeparator5
			//
			this.ToolStripSeparator5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripSeparator5.Name = "ToolStripSeparator5";
			this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 31);
			//
			//btnAdjustGamma
			//
			this.btnAdjustGamma.CheckOnClick = true;
			this.btnAdjustGamma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnAdjustGamma.Image = (System.Drawing.Image) (resources.GetObject("btnAdjustGamma.Image"));
			this.btnAdjustGamma.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdjustGamma.Name = "btnAdjustGamma";
			this.btnAdjustGamma.Size = new System.Drawing.Size(28, 28);
			this.btnAdjustGamma.Text = "Adjust gamma";
			//
			//ToolStripSeparator10
			//
			this.ToolStripSeparator10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripSeparator10.Name = "ToolStripSeparator10";
			this.ToolStripSeparator10.Size = new System.Drawing.Size(6, 31);
			//
			//btnRotateLeft
			//
			this.btnRotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRotateLeft.Image = (System.Drawing.Image) (resources.GetObject("btnRotateLeft.Image"));
			this.btnRotateLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnRotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRotateLeft.Name = "btnRotateLeft";
			this.btnRotateLeft.Size = new System.Drawing.Size(28, 28);
			this.btnRotateLeft.Text = "Rotate left";
			//
			//btnRotateRight
			//
			this.btnRotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRotateRight.Image = (System.Drawing.Image) (resources.GetObject("btnRotateRight.Image"));
			this.btnRotateRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnRotateRight.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRotateRight.Name = "btnRotateRight";
			this.btnRotateRight.Size = new System.Drawing.Size(28, 28);
			this.btnRotateRight.Text = "Rotate right";
			//
			//btnFlipX
			//
			this.btnFlipX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFlipX.Image = (System.Drawing.Image) (resources.GetObject("btnFlipX.Image"));
			this.btnFlipX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnFlipX.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFlipX.Name = "btnFlipX";
			this.btnFlipX.Size = new System.Drawing.Size(28, 28);
			this.btnFlipX.Text = "Vertical flip";
			//
			//btnFlipY
			//
			this.btnFlipY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFlipY.Image = (System.Drawing.Image) (resources.GetObject("btnFlipY.Image"));
			this.btnFlipY.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnFlipY.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFlipY.Name = "btnFlipY";
			this.btnFlipY.Size = new System.Drawing.Size(28, 28);
			this.btnFlipY.Text = "Horizontal flip";
			//
			//ToolStripSeparator4
			//
			this.ToolStripSeparator4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 31);
			//
			//btnAbout
			//
			this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnAbout.Image = (System.Drawing.Image) (resources.GetObject("btnAbout.Image"));
			this.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(28, 28);
			this.btnAbout.Text = "About";
			//
			//pMain
			//
			this.pMain.Controls.Add(this.scMain);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 31);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(1264, 676);
			this.pMain.TabIndex = 6;
			//
			//Label1
			//
			this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (10.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(0, 0);
			this.Label1.Name = "Label1";
			this.Label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.Label1.Size = new System.Drawing.Size(326, 67);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Tip: you can move pages in the current document by dragging items below";
			//
			//Panel8
			//
			this.Panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Panel8.Controls.Add(this.Label1);
			this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.Panel8.Location = new System.Drawing.Point(0, 0);
			this.Panel8.Name = "Panel8";
			this.Panel8.Size = new System.Drawing.Size(326, 67);
			this.Panel8.TabIndex = 2;
			//
			//Panel10
			//
			this.Panel10.Controls.Add(this.ThumbnailEx1);
			this.Panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel10.Location = new System.Drawing.Point(0, 67);
			this.Panel10.Name = "Panel10";
			this.Panel10.Size = new System.Drawing.Size(326, 524);
			this.Panel10.TabIndex = 3;
			//
			//btnSave
			//
			this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSave.Image = (System.Drawing.Image) (resources.GetObject("btnSave.Image"));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(28, 28);
			this.btnSave.Text = "Save document";
			//
			//frmMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 729);
			this.Controls.Add(this.pMain);
			this.Controls.Add(this.mainToolStrip);
			this.Controls.Add(this.statusbar);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "GdPicture .NET";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tcLeftPanel.ResumeLayout(false);
			this.tpThumbnails.ResumeLayout(false);
			this.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.ToolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
			this.ToolStripContainer1.ResumeLayout(false);
			this.ToolStripContainer1.PerformLayout();
			this.thumbnailPanelToolstrip.ResumeLayout(false);
			this.thumbnailPanelToolstrip.PerformLayout();
			this.tpBookmarks.ResumeLayout(false);
			this.Panel5.ResumeLayout(false);
			this.tpSearch.ResumeLayout(false);
			this.pSearch.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.scMain.Panel1.ResumeLayout(false);
			this.scMain.Panel2.ResumeLayout(false);
			this.scMain.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.scMain).EndInit();
			this.scMain.ResumeLayout(false);
			this.Panel6.ResumeLayout(false);
			this.Panel6.PerformLayout();
			this.Panel9.ResumeLayout(false);
			this.Panel7.ResumeLayout(false);
			this.Panel7.PerformLayout();
			this.pSnapInButtons.ResumeLayout(false);
			this.pGamma.ResumeLayout(false);
			this.pGamma.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.tbGamma).EndInit();
			this.statusbar.ResumeLayout(false);
			this.statusbar.PerformLayout();
			this.mainToolStrip.ResumeLayout(false);
			this.mainToolStrip.PerformLayout();
			this.pMain.ResumeLayout(false);
			this.Panel8.ResumeLayout(false);
			this.Panel10.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal GdPicture14.ThumbnailEx ThumbnailEx1;
		internal System.Windows.Forms.TabControl tcLeftPanel;
		internal System.Windows.Forms.TabPage tpThumbnails;
		internal System.Windows.Forms.TabPage tpBookmarks;
		internal System.Windows.Forms.SplitContainer scMain;
		internal GdPicture14.GdViewer GdViewer1;
		internal System.Windows.Forms.StatusStrip statusbar;
		internal System.Windows.Forms.ToolStrip mainToolStrip;
		internal System.Windows.Forms.Panel pMain;
		internal GdPicture14.BookmarksTree BookmarksTree1;
		internal System.Windows.Forms.ToolStripButton btnOpen;
		internal System.Windows.Forms.ToolStripButton btnClose;
		internal System.Windows.Forms.ToolStripButton btnPrint;
		internal System.Windows.Forms.ToolStripButton btnAbout;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
		internal System.Windows.Forms.TabPage tpSearch;
		internal System.Windows.Forms.Panel pSearch;
		internal System.Windows.Forms.RadioButton rbAllPages;
		internal System.Windows.Forms.RadioButton rbCurrentPage;
		internal System.Windows.Forms.CheckBox chkCaseSensitive;
		internal System.Windows.Forms.CheckBox chkWholeWord;
		internal System.Windows.Forms.TextBox tbSearch;
		internal System.Windows.Forms.Button btnSearch;
		internal System.Windows.Forms.Label lblSearchFor;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
		internal System.Windows.Forms.ToolStripButton btnFirstPage;
		internal System.Windows.Forms.ToolStripButton btnPreviousPage;
		internal System.Windows.Forms.ToolStripTextBox tbCurrentPage;
		internal System.Windows.Forms.ToolStripLabel lblPageCount;
		internal System.Windows.Forms.ToolStripButton btnNextPage;
		internal System.Windows.Forms.ToolStripButton btnLastPage;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripButton btnZoomOut;
		internal System.Windows.Forms.ToolStripComboBox cbZoom;
		internal System.Windows.Forms.ToolStripButton btnZoomIn;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.ToolStripButton btnRotateLeft;
		internal System.Windows.Forms.ToolStripButton btnRotateRight;
		internal System.Windows.Forms.ToolStripButton btnFlipX;
		internal System.Windows.Forms.ToolStripButton btnFlipY;
		internal System.Windows.Forms.ListView lstSearchResults;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Button btnFindPrevious;
		internal System.Windows.Forms.Button btnFindNext;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Panel Panel5;
		internal System.Windows.Forms.ToolStripButton btnSettings;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
		internal System.Windows.Forms.Label lblSearchResults;
		internal System.Windows.Forms.ProgressBar searchProgressBar;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
		internal System.Windows.Forms.ToolStripButton btnFitWidth;
		internal System.Windows.Forms.ToolStripButton btnFitPage;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator10;
		internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
		internal System.Windows.Forms.ToolStrip thumbnailPanelToolstrip;
		internal System.Windows.Forms.Panel pGamma;
		internal System.Windows.Forms.TrackBar tbGamma;
		internal System.Windows.Forms.Label lblGamma;
		internal System.Windows.Forms.Panel Panel6;
		internal System.Windows.Forms.Button btnSnapInThumbnails;
		internal System.Windows.Forms.Button btnSnapInSearch;
		internal System.Windows.Forms.Button btnSnapInBookmarks;
		internal System.Windows.Forms.Panel Panel9;
		internal System.Windows.Forms.Panel pSnapInButtons;
		internal System.Windows.Forms.Panel Panel7;
		internal System.Windows.Forms.Label lblSnapInPanel;
		internal System.Windows.Forms.ToolStripDropDownButton btnMouseMode;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
		internal System.Windows.Forms.ToolStripMenuItem DefaultToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AreaSelectionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem PanToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AreaZoomingToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MagnifierToolStripMenuItem;
		internal System.Windows.Forms.ToolStripDropDownButton btnThumbSize;
		internal System.Windows.Forms.ToolStripMenuItem LargeThumbnailsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem MediumThumbnailsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem SmallThumbnailsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
		internal System.Windows.Forms.ToolStripButton btnAdjustGamma;
		internal System.Windows.Forms.ToolStripButton btnDeleteCurrentPage;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Panel Panel10;
		internal System.Windows.Forms.Panel Panel8;
		internal System.Windows.Forms.ToolStripButton btnSave;
		
	}
	
}
