
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;



namespace Annotations
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
            this.tpThumbnails = new System.Windows.Forms.TabPage();
            this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.thumbnailPanelToolstrip = new System.Windows.Forms.ToolStrip();
            this.btnThumbSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.LargeThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ThumbnailEx1 = new GdPicture14.ThumbnailEx();
            this.tpBookmarks = new System.Windows.Forms.TabPage();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.BookmarksTree1 = new GdPicture14.BookmarksTree();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.pSearch = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.lstSearchResults = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel3 = new System.Windows.Forms.Panel();
            this.searchProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.chkWholeWord = new System.Windows.Forms.CheckBox();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCurrentPage = new System.Windows.Forms.RadioButton();
            this.rbAllPages = new System.Windows.Forms.RadioButton();
            this.btnFindPrevious = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.tpAnnotations = new System.Windows.Forms.TabPage();
            this.pAnnotations = new System.Windows.Forms.Panel();
            this.ToolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.annotationsToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnLoadAnnotationsFromXMP = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAnnotations = new System.Windows.Forms.ToolStripDropDownButton();
            this.SaveAllAnnotationsToXMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCurrentAnnotationToXMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveAnnotations = new System.Windows.Forms.ToolStripDropDownButton();
            this.RemoveAllAnnotationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveSelectedAnnotationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBurnAnnotations = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSetAnnotationEditorMode = new System.Windows.Forms.ToolStripButton();
            this.AnnotationEditor1 = new GdPicture14.AnnotationEditor();
            this.Panel10 = new System.Windows.Forms.Panel();
            this.pBtnCustomAnnotations = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCustomAnnotation1 = new System.Windows.Forms.Button();
            this.btnCustomAnnotation2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.pBtnAnnotations = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnnotationHighlightedRectangle = new System.Windows.Forms.Button();
            this.btnAnnotationHighlighter = new System.Windows.Forms.Button();
            this.btnAnnotationRectangle = new System.Windows.Forms.Button();
            this.btnAnnotationFilledRectangle = new System.Windows.Forms.Button();
            this.btnAnnotationEllipse = new System.Windows.Forms.Button();
            this.btnAnnotationFilledEllipse = new System.Windows.Forms.Button();
            this.btnAnnotationImage = new System.Windows.Forms.Button();
            this.btnAnnotationRubberStamp = new System.Windows.Forms.Button();
            this.btnAnnotationLine = new System.Windows.Forms.Button();
            this.btnAnnotationConnectedLines = new System.Windows.Forms.Button();
            this.btnAnnotationArrow = new System.Windows.Forms.Button();
            this.btnAnnotationText = new System.Windows.Forms.Button();
            this.btnAnnotationStickyNote = new System.Windows.Forms.Button();
            this.btnAnnotationFreehand = new System.Windows.Forms.Button();
            this.btnAnnotationLink = new System.Windows.Forms.Button();
            this.btnAnnotationPolygon = new System.Windows.Forms.Button();
            this.btnAnnotationFreehandPolygon = new System.Windows.Forms.Button();
            this.btnAnnotationRuler = new System.Windows.Forms.Button();
            this.btnAnnotationPolyRuler = new System.Windows.Forms.Button();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.lblSnapInPanel = new System.Windows.Forms.Label();
            this.pSnapInButtons = new System.Windows.Forms.Panel();
            this.btnSnapInThumbnails = new System.Windows.Forms.Button();
            this.btnSnapInBookmarks = new System.Windows.Forms.Button();
            this.btnSnapInSearch = new System.Windows.Forms.Button();
            this.btnSnapInAnnotations = new System.Windows.Forms.Button();
            this.pGamma = new System.Windows.Forms.Panel();
            this.lblGamma = new System.Windows.Forms.Label();
            this.tbGamma = new System.Windows.Forms.TrackBar();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMouseMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.DefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaZoomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MagnifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirstPage = new System.Windows.Forms.ToolStripButton();
            this.btnPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.tbCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnLastPage = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.cbZoom = new System.Windows.Forms.ToolStripComboBox();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFitWidth = new System.Windows.Forms.ToolStripButton();
            this.btnFitPage = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdjustGamma = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRotateLeft = new System.Windows.Forms.ToolStripButton();
            this.btnRotateRight = new System.Windows.Forms.ToolStripButton();
            this.btnFlipX = new System.Windows.Forms.ToolStripButton();
            this.btnFlipY = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.pMain = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.tpAnnotations.SuspendLayout();
            this.pAnnotations.SuspendLayout();
            this.ToolStripContainer2.BottomToolStripPanel.SuspendLayout();
            this.ToolStripContainer2.ContentPanel.SuspendLayout();
            this.ToolStripContainer2.SuspendLayout();
            this.annotationsToolStrip.SuspendLayout();
            this.Panel10.SuspendLayout();
            this.pBtnCustomAnnotations.SuspendLayout();
            this.pBtnAnnotations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.pSnapInButtons.SuspendLayout();
            this.pGamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).BeginInit();
            this.statusbar.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLeftPanel
            // 
            this.tcLeftPanel.Controls.Add(this.tpThumbnails);
            this.tcLeftPanel.Controls.Add(this.tpBookmarks);
            this.tcLeftPanel.Controls.Add(this.tpSearch);
            this.tcLeftPanel.Controls.Add(this.tpAnnotations);
            this.tcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLeftPanel.Location = new System.Drawing.Point(0, 49);
            this.tcLeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tcLeftPanel.Multiline = true;
            this.tcLeftPanel.Name = "tcLeftPanel";
            this.tcLeftPanel.Padding = new System.Drawing.Point(0, 0);
            this.tcLeftPanel.SelectedIndex = 0;
            this.tcLeftPanel.Size = new System.Drawing.Size(318, 1014);
            this.tcLeftPanel.TabIndex = 1;
            // 
            // tpThumbnails
            // 
            this.tpThumbnails.BackColor = System.Drawing.SystemColors.Control;
            this.tpThumbnails.Controls.Add(this.ToolStripContainer1);
            this.tpThumbnails.Location = new System.Drawing.Point(4, 54);
            this.tpThumbnails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpThumbnails.Name = "tpThumbnails";
            this.tpThumbnails.Size = new System.Drawing.Size(310, 956);
            this.tpThumbnails.TabIndex = 0;
            this.tpThumbnails.Text = "Thumbnails";
            // 
            // ToolStripContainer1
            // 
            // 
            // ToolStripContainer1.BottomToolStripPanel
            // 
            this.ToolStripContainer1.BottomToolStripPanel.Controls.Add(this.thumbnailPanelToolstrip);
            // 
            // ToolStripContainer1.ContentPanel
            // 
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.ThumbnailEx1);
            this.ToolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(310, 887);
            this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.ToolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            this.ToolStripContainer1.Size = new System.Drawing.Size(310, 956);
            this.ToolStripContainer1.TabIndex = 1;
            this.ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // thumbnailPanelToolstrip
            // 
            this.thumbnailPanelToolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thumbnailPanelToolstrip.Dock = System.Windows.Forms.DockStyle.None;
            this.thumbnailPanelToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.thumbnailPanelToolstrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.thumbnailPanelToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThumbSize});
            this.thumbnailPanelToolstrip.Location = new System.Drawing.Point(0, 0);
            this.thumbnailPanelToolstrip.Name = "thumbnailPanelToolstrip";
            this.thumbnailPanelToolstrip.Padding = new System.Windows.Forms.Padding(0);
            this.thumbnailPanelToolstrip.Size = new System.Drawing.Size(310, 31);
            this.thumbnailPanelToolstrip.Stretch = true;
            this.thumbnailPanelToolstrip.TabIndex = 0;
            // 
            // btnThumbSize
            // 
            this.btnThumbSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThumbSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LargeThumbnailsToolStripMenuItem1,
            this.MediumThumbnailsToolStripMenuItem1,
            this.SmallThumbnailsToolStripMenuItem1});
            this.btnThumbSize.Image = ((System.Drawing.Image)(resources.GetObject("btnThumbSize.Image")));
            this.btnThumbSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThumbSize.Name = "btnThumbSize";
            this.btnThumbSize.Size = new System.Drawing.Size(42, 28);
            this.btnThumbSize.Text = "btnThumbnailSize";
            this.btnThumbSize.ToolTipText = "Thumbnail size";
            // 
            // LargeThumbnailsToolStripMenuItem1
            // 
            this.LargeThumbnailsToolStripMenuItem1.Checked = true;
            this.LargeThumbnailsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LargeThumbnailsToolStripMenuItem1.Name = "LargeThumbnailsToolStripMenuItem1";
            this.LargeThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(256, 30);
            this.LargeThumbnailsToolStripMenuItem1.Text = "Large thumbnails";
            this.LargeThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.LargeThumbnailsToolStripMenuItem1_Click);
            // 
            // MediumThumbnailsToolStripMenuItem1
            // 
            this.MediumThumbnailsToolStripMenuItem1.Name = "MediumThumbnailsToolStripMenuItem1";
            this.MediumThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(256, 30);
            this.MediumThumbnailsToolStripMenuItem1.Text = "Medium thumbnails";
            this.MediumThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.MediumThumbnailsToolStripMenuItem1_Click);
            // 
            // SmallThumbnailsToolStripMenuItem1
            // 
            this.SmallThumbnailsToolStripMenuItem1.Name = "SmallThumbnailsToolStripMenuItem1";
            this.SmallThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(256, 30);
            this.SmallThumbnailsToolStripMenuItem1.Text = "Small thumbnails";
            this.SmallThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.SmallThumbnailsToolStripMenuItem1_Click);
            // 
            // ThumbnailEx1
            // 
            this.ThumbnailEx1.AllowDropFiles = false;
            this.ThumbnailEx1.AllowMoveItems = false;
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
            this.ThumbnailEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThumbnailEx1.MultiSelect = false;
            this.ThumbnailEx1.Name = "ThumbnailEx1";
            this.ThumbnailEx1.OwnDrop = false;
            this.ThumbnailEx1.PauseThumbsLoading = false;
            this.ThumbnailEx1.PdfIncreaseTextContrast = false;
            this.ThumbnailEx1.PreloadAllItems = true;
            this.ThumbnailEx1.RotateExif = true;
            this.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ThumbnailEx1.ShowText = true;
            this.ThumbnailEx1.Size = new System.Drawing.Size(310, 887);
            this.ThumbnailEx1.TabIndex = 0;
            this.ThumbnailEx1.TextMarginLeft = 0;
            this.ThumbnailEx1.TextMarginTop = 0;
            this.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical;
            this.ThumbnailEx1.ThumbnailBorder = true;
            this.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Black;
            this.ThumbnailEx1.ThumbnailSize = new System.Drawing.Size(256, 256);
            this.ThumbnailEx1.ThumbnailSpacing = new System.Drawing.Size(0, 0);
            this.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            // 
            // tpBookmarks
            // 
            this.tpBookmarks.BackColor = System.Drawing.SystemColors.Control;
            this.tpBookmarks.Controls.Add(this.Panel5);
            this.tpBookmarks.Location = new System.Drawing.Point(4, 54);
            this.tpBookmarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBookmarks.Name = "tpBookmarks";
            this.tpBookmarks.Size = new System.Drawing.Size(493, 930);
            this.tpBookmarks.TabIndex = 1;
            this.tpBookmarks.Text = "Bookmarks";
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.BookmarksTree1);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(493, 930);
            this.Panel5.TabIndex = 1;
            // 
            // BookmarksTree1
            // 
            this.BookmarksTree1.BackColor = System.Drawing.SystemColors.Control;
            this.BookmarksTree1.DisableZoomDestination = false;
            this.BookmarksTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookmarksTree1.FontName = "Helvetica";
            this.BookmarksTree1.FontSize = 10F;
            this.BookmarksTree1.GdViewer = null;
            this.BookmarksTree1.ItemHeight = 20;
            this.BookmarksTree1.Location = new System.Drawing.Point(0, 0);
            this.BookmarksTree1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookmarksTree1.Name = "BookmarksTree1";
            this.BookmarksTree1.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.BookmarksTree1.Size = new System.Drawing.Size(493, 930);
            this.BookmarksTree1.TabIndex = 0;
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tpSearch.Controls.Add(this.pSearch);
            this.tpSearch.Location = new System.Drawing.Point(4, 54);
            this.tpSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(493, 930);
            this.tpSearch.TabIndex = 2;
            this.tpSearch.Text = "Search";
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.SystemColors.Control;
            this.pSearch.Controls.Add(this.Panel4);
            this.pSearch.Controls.Add(this.Panel3);
            this.pSearch.Controls.Add(this.Panel2);
            this.pSearch.Controls.Add(this.Panel1);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pSearch.Name = "pSearch";
            this.pSearch.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.pSearch.Size = new System.Drawing.Size(493, 930);
            this.pSearch.TabIndex = 0;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.lstSearchResults);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(15, 435);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(463, 480);
            this.Panel4.TabIndex = 17;
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.lstSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSearchResults.FullRowSelect = true;
            this.lstSearchResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstSearchResults.Location = new System.Drawing.Point(0, 0);
            this.lstSearchResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSearchResults.MultiSelect = false;
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(463, 480);
            this.lstSearchResults.TabIndex = 10;
            this.lstSearchResults.UseCompatibleStateImageBehavior = false;
            this.lstSearchResults.View = System.Windows.Forms.View.Tile;
            this.lstSearchResults.SelectedIndexChanged += new System.EventHandler(this.lstSearchResults_SelectedIndexChanged);
            // 
            // Panel3
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
            this.Panel3.Location = new System.Drawing.Point(15, 97);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(463, 338);
            this.Panel3.TabIndex = 16;
            // 
            // searchProgressBar
            // 
            this.searchProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchProgressBar.Location = new System.Drawing.Point(0, 323);
            this.searchProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchProgressBar.Minimum = 1;
            this.searchProgressBar.Name = "searchProgressBar";
            this.searchProgressBar.Size = new System.Drawing.Size(463, 15);
            this.searchProgressBar.TabIndex = 15;
            this.searchProgressBar.Value = 1;
            this.searchProgressBar.Visible = false;
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(9, 294);
            this.lblSearchResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(119, 20);
            this.lblSearchResults.TabIndex = 14;
            this.lblSearchResults.Text = "Find result from";
            // 
            // chkWholeWord
            // 
            this.chkWholeWord.AutoSize = true;
            this.chkWholeWord.Location = new System.Drawing.Point(4, 5);
            this.chkWholeWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWholeWord.Name = "chkWholeWord";
            this.chkWholeWord.Size = new System.Drawing.Size(162, 24);
            this.chkWholeWord.TabIndex = 1;
            this.chkWholeWord.Text = "Match whole word";
            this.chkWholeWord.UseVisualStyleBackColor = true;
            this.chkWholeWord.CheckedChanged += new System.EventHandler(this.chkWholeWord_CheckedChanged);
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(4, 40);
            this.chkCaseSensitive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(117, 24);
            this.chkCaseSensitive.TabIndex = 2;
            this.chkCaseSensitive.Text = "Match case";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            this.chkCaseSensitive.CheckedChanged += new System.EventHandler(this.chkCaseSensitive_CheckedChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rbCurrentPage);
            this.GroupBox2.Controls.Add(this.rbAllPages);
            this.GroupBox2.Location = new System.Drawing.Point(4, 75);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(282, 108);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search in";
            // 
            // rbCurrentPage
            // 
            this.rbCurrentPage.AutoSize = true;
            this.rbCurrentPage.Location = new System.Drawing.Point(9, 29);
            this.rbCurrentPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCurrentPage.Name = "rbCurrentPage";
            this.rbCurrentPage.Size = new System.Drawing.Size(124, 24);
            this.rbCurrentPage.TabIndex = 3;
            this.rbCurrentPage.TabStop = true;
            this.rbCurrentPage.Text = "current page";
            this.rbCurrentPage.UseVisualStyleBackColor = true;
            this.rbCurrentPage.CheckedChanged += new System.EventHandler(this.rbCurrentPage_CheckedChanged);
            // 
            // rbAllPages
            // 
            this.rbAllPages.AutoSize = true;
            this.rbAllPages.Location = new System.Drawing.Point(9, 65);
            this.rbAllPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAllPages.Name = "rbAllPages";
            this.rbAllPages.Size = new System.Drawing.Size(97, 24);
            this.rbAllPages.TabIndex = 4;
            this.rbAllPages.TabStop = true;
            this.rbAllPages.Text = "all pages";
            this.rbAllPages.UseVisualStyleBackColor = true;
            this.rbAllPages.CheckedChanged += new System.EventHandler(this.rbAllPages_CheckedChanged);
            // 
            // btnFindPrevious
            // 
            this.btnFindPrevious.Location = new System.Drawing.Point(4, 192);
            this.btnFindPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindPrevious.Name = "btnFindPrevious";
            this.btnFindPrevious.Size = new System.Drawing.Size(136, 35);
            this.btnFindPrevious.TabIndex = 13;
            this.btnFindPrevious.Text = "Find previous";
            this.btnFindPrevious.UseVisualStyleBackColor = true;
            this.btnFindPrevious.Click += new System.EventHandler(this.btnFindPrevious_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(4, 237);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search All";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(150, 192);
            this.btnFindNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(136, 35);
            this.btnFindNext.TabIndex = 12;
            this.btnFindNext.Text = "Find next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.tbSearch);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(15, 55);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(463, 42);
            this.Panel2.TabIndex = 15;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(463, 26);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.lblSearchFor);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(15, 15);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(463, 40);
            this.Panel1.TabIndex = 14;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(4, 5);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(30, 31);
            this.PictureBox1.TabIndex = 11;
            this.PictureBox1.TabStop = false;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(44, 11);
            this.lblSearchFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(83, 20);
            this.lblSearchFor.TabIndex = 8;
            this.lblSearchFor.Text = "Search for";
            // 
            // tpAnnotations
            // 
            this.tpAnnotations.Controls.Add(this.pAnnotations);
            this.tpAnnotations.Location = new System.Drawing.Point(4, 54);
            this.tpAnnotations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAnnotations.Name = "tpAnnotations";
            this.tpAnnotations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAnnotations.Size = new System.Drawing.Size(310, 956);
            this.tpAnnotations.TabIndex = 3;
            this.tpAnnotations.Text = "Annotations";
            this.tpAnnotations.UseVisualStyleBackColor = true;
            // 
            // pAnnotations
            // 
            this.pAnnotations.Controls.Add(this.ToolStripContainer2);
            this.pAnnotations.Controls.Add(this.Panel10);
            this.pAnnotations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAnnotations.Location = new System.Drawing.Point(4, 5);
            this.pAnnotations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pAnnotations.Name = "pAnnotations";
            this.pAnnotations.Size = new System.Drawing.Size(302, 946);
            this.pAnnotations.TabIndex = 4;
            // 
            // ToolStripContainer2
            // 
            // 
            // ToolStripContainer2.BottomToolStripPanel
            // 
            this.ToolStripContainer2.BottomToolStripPanel.Controls.Add(this.annotationsToolStrip);
            // 
            // ToolStripContainer2.ContentPanel
            // 
            this.ToolStripContainer2.ContentPanel.Controls.Add(this.AnnotationEditor1);
            this.ToolStripContainer2.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToolStripContainer2.ContentPanel.Size = new System.Drawing.Size(302, 239);
            this.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer2.LeftToolStripPanelVisible = false;
            this.ToolStripContainer2.Location = new System.Drawing.Point(0, 676);
            this.ToolStripContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToolStripContainer2.Name = "ToolStripContainer2";
            this.ToolStripContainer2.RightToolStripPanelVisible = false;
            this.ToolStripContainer2.Size = new System.Drawing.Size(302, 270);
            this.ToolStripContainer2.TabIndex = 9;
            this.ToolStripContainer2.Text = "ToolStripContainer2";
            this.ToolStripContainer2.TopToolStripPanelVisible = false;
            // 
            // annotationsToolStrip
            // 
            this.annotationsToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.annotationsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.annotationsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.annotationsToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.annotationsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadAnnotationsFromXMP,
            this.btnSaveAnnotations,
            this.btnRemoveAnnotations,
            this.btnBurnAnnotations,
            this.ToolStripSeparator7,
            this.btnSetAnnotationEditorMode});
            this.annotationsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.annotationsToolStrip.Name = "annotationsToolStrip";
            this.annotationsToolStrip.Size = new System.Drawing.Size(302, 31);
            this.annotationsToolStrip.Stretch = true;
            this.annotationsToolStrip.TabIndex = 4;
            // 
            // btnLoadAnnotationsFromXMP
            // 
            this.btnLoadAnnotationsFromXMP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadAnnotationsFromXMP.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadAnnotationsFromXMP.Image")));
            this.btnLoadAnnotationsFromXMP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadAnnotationsFromXMP.Name = "btnLoadAnnotationsFromXMP";
            this.btnLoadAnnotationsFromXMP.Size = new System.Drawing.Size(28, 28);
            this.btnLoadAnnotationsFromXMP.Text = "Load from XMP file";
            this.btnLoadAnnotationsFromXMP.Click += new System.EventHandler(this.btnLoadAnnotationsFromXML_Click);
            // 
            // btnSaveAnnotations
            // 
            this.btnSaveAnnotations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAnnotations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAllAnnotationsToXMPToolStripMenuItem,
            this.SaveCurrentAnnotationToXMPToolStripMenuItem});
            this.btnSaveAnnotations.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAnnotations.Image")));
            this.btnSaveAnnotations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAnnotations.Name = "btnSaveAnnotations";
            this.btnSaveAnnotations.Size = new System.Drawing.Size(42, 28);
            this.btnSaveAnnotations.Text = "Save annotations...";
            // 
            // SaveAllAnnotationsToXMPToolStripMenuItem
            // 
            this.SaveAllAnnotationsToXMPToolStripMenuItem.Name = "SaveAllAnnotationsToXMPToolStripMenuItem";
            this.SaveAllAnnotationsToXMPToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.SaveAllAnnotationsToXMPToolStripMenuItem.Text = "Save all annotations to XMP";
            this.SaveAllAnnotationsToXMPToolStripMenuItem.Click += new System.EventHandler(this.SaveAllPagesToolStripMenuItem_Click);
            // 
            // SaveCurrentAnnotationToXMPToolStripMenuItem
            // 
            this.SaveCurrentAnnotationToXMPToolStripMenuItem.Name = "SaveCurrentAnnotationToXMPToolStripMenuItem";
            this.SaveCurrentAnnotationToXMPToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.SaveCurrentAnnotationToXMPToolStripMenuItem.Text = "Save current annotation to XMP";
            this.SaveCurrentAnnotationToXMPToolStripMenuItem.Click += new System.EventHandler(this.SaveCurrentPageToolStripMenuItem_Click);
            // 
            // btnRemoveAnnotations
            // 
            this.btnRemoveAnnotations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveAnnotations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveAllAnnotationsToolStripMenuItem1,
            this.RemoveSelectedAnnotationToolStripMenuItem1});
            this.btnRemoveAnnotations.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAnnotations.Image")));
            this.btnRemoveAnnotations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveAnnotations.Name = "btnRemoveAnnotations";
            this.btnRemoveAnnotations.Size = new System.Drawing.Size(42, 28);
            this.btnRemoveAnnotations.Text = "Remove annotations...";
            // 
            // RemoveAllAnnotationsToolStripMenuItem1
            // 
            this.RemoveAllAnnotationsToolStripMenuItem1.Name = "RemoveAllAnnotationsToolStripMenuItem1";
            this.RemoveAllAnnotationsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.RemoveAllAnnotationsToolStripMenuItem1.Size = new System.Drawing.Size(393, 30);
            this.RemoveAllAnnotationsToolStripMenuItem1.Text = "Remove all annotations";
            this.RemoveAllAnnotationsToolStripMenuItem1.Click += new System.EventHandler(this.RemoveAllAnnotationsToolStripMenuItem_Click);
            // 
            // RemoveSelectedAnnotationToolStripMenuItem1
            // 
            this.RemoveSelectedAnnotationToolStripMenuItem1.Name = "RemoveSelectedAnnotationToolStripMenuItem1";
            this.RemoveSelectedAnnotationToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.RemoveSelectedAnnotationToolStripMenuItem1.Size = new System.Drawing.Size(393, 30);
            this.RemoveSelectedAnnotationToolStripMenuItem1.Text = "Remove selected annotation";
            this.RemoveSelectedAnnotationToolStripMenuItem1.Click += new System.EventHandler(this.RemoveSelectedAnnotationToolStripMenuItem_Click);
            // 
            // btnBurnAnnotations
            // 
            this.btnBurnAnnotations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBurnAnnotations.Image = ((System.Drawing.Image)(resources.GetObject("btnBurnAnnotations.Image")));
            this.btnBurnAnnotations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBurnAnnotations.Name = "btnBurnAnnotations";
            this.btnBurnAnnotations.Size = new System.Drawing.Size(28, 28);
            this.btnBurnAnnotations.Text = "Burn annotations";
            this.btnBurnAnnotations.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSetAnnotationEditorMode
            // 
            this.btnSetAnnotationEditorMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetAnnotationEditorMode.Image = ((System.Drawing.Image)(resources.GetObject("btnSetAnnotationEditorMode.Image")));
            this.btnSetAnnotationEditorMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetAnnotationEditorMode.Name = "btnSetAnnotationEditorMode";
            this.btnSetAnnotationEditorMode.Size = new System.Drawing.Size(28, 28);
            this.btnSetAnnotationEditorMode.Text = "ToolStripButton1";
            this.btnSetAnnotationEditorMode.Click += new System.EventHandler(this.btnSetAnnotationEditorMode_Click);
            // 
            // AnnotationEditor1
            // 
            this.AnnotationEditor1.BackColor = System.Drawing.SystemColors.Control;
            this.AnnotationEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnnotationEditor1.Location = new System.Drawing.Point(0, 0);
            this.AnnotationEditor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnnotationEditor1.Name = "AnnotationEditor1";
            this.AnnotationEditor1.Size = new System.Drawing.Size(302, 239);
            this.AnnotationEditor1.TabIndex = 3;
            // 
            // Panel10
            // 
            this.Panel10.AutoSize = true;
            this.Panel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel10.BackColor = System.Drawing.SystemColors.Control;
            this.Panel10.Controls.Add(this.pBtnCustomAnnotations);
            this.Panel10.Controls.Add(this.Label1);
            this.Panel10.Controls.Add(this.pBtnAnnotations);
            this.Panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel10.Location = new System.Drawing.Point(0, 0);
            this.Panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel10.Name = "Panel10";
            this.Panel10.Size = new System.Drawing.Size(302, 676);
            this.Panel10.TabIndex = 7;
            // 
            // pBtnCustomAnnotations
            // 
            this.pBtnCustomAnnotations.AutoSize = true;
            this.pBtnCustomAnnotations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pBtnCustomAnnotations.Controls.Add(this.btnCustomAnnotation1);
            this.pBtnCustomAnnotations.Controls.Add(this.btnCustomAnnotation2);
            this.pBtnCustomAnnotations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBtnCustomAnnotations.Location = new System.Drawing.Point(0, 598);
            this.pBtnCustomAnnotations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBtnCustomAnnotations.Name = "pBtnCustomAnnotations";
            this.pBtnCustomAnnotations.Size = new System.Drawing.Size(302, 78);
            this.pBtnCustomAnnotations.TabIndex = 8;
            // 
            // btnCustomAnnotation1
            // 
            this.btnCustomAnnotation1.AutoSize = true;
            this.btnCustomAnnotation1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustomAnnotation1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCustomAnnotation1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCustomAnnotation1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomAnnotation1.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomAnnotation1.Image")));
            this.btnCustomAnnotation1.Location = new System.Drawing.Point(22, 23);
            this.btnCustomAnnotation1.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnCustomAnnotation1.Name = "btnCustomAnnotation1";
            this.btnCustomAnnotation1.Size = new System.Drawing.Size(32, 32);
            this.btnCustomAnnotation1.TabIndex = 14;
            this.btnCustomAnnotation1.UseVisualStyleBackColor = false;
            this.btnCustomAnnotation1.Click += new System.EventHandler(this.btnCustomAnnotation1_Click);
            // 
            // btnCustomAnnotation2
            // 
            this.btnCustomAnnotation2.AutoSize = true;
            this.btnCustomAnnotation2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustomAnnotation2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCustomAnnotation2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCustomAnnotation2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomAnnotation2.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomAnnotation2.Image")));
            this.btnCustomAnnotation2.Location = new System.Drawing.Point(98, 23);
            this.btnCustomAnnotation2.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnCustomAnnotation2.Name = "btnCustomAnnotation2";
            this.btnCustomAnnotation2.Size = new System.Drawing.Size(32, 32);
            this.btnCustomAnnotation2.TabIndex = 15;
            this.btnCustomAnnotation2.UseVisualStyleBackColor = false;
            this.btnCustomAnnotation2.Click += new System.EventHandler(this.btnCustomAnnotation2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(0, 546);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.Label1.Size = new System.Drawing.Size(187, 52);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Custom annotations";
            // 
            // pBtnAnnotations
            // 
            this.pBtnAnnotations.AutoSize = true;
            this.pBtnAnnotations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationHighlightedRectangle);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationHighlighter);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationRectangle);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationFilledRectangle);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationEllipse);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationFilledEllipse);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationImage);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationRubberStamp);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationLine);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationConnectedLines);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationArrow);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationText);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationStickyNote);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationFreehand);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationLink);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationPolygon);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationFreehandPolygon);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationRuler);
            this.pBtnAnnotations.Controls.Add(this.btnAnnotationPolyRuler);
            this.pBtnAnnotations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBtnAnnotations.Location = new System.Drawing.Point(0, 0);
            this.pBtnAnnotations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBtnAnnotations.Name = "pBtnAnnotations";
            this.pBtnAnnotations.Size = new System.Drawing.Size(302, 546);
            this.pBtnAnnotations.TabIndex = 1;
            // 
            // btnAnnotationHighlightedRectangle
            // 
            this.btnAnnotationHighlightedRectangle.AutoSize = true;
            this.btnAnnotationHighlightedRectangle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationHighlightedRectangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationHighlightedRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationHighlightedRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationHighlightedRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationHighlightedRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationHighlightedRectangle.Image")));
            this.btnAnnotationHighlightedRectangle.Location = new System.Drawing.Point(22, 23);
            this.btnAnnotationHighlightedRectangle.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationHighlightedRectangle.Name = "btnAnnotationHighlightedRectangle";
            this.btnAnnotationHighlightedRectangle.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationHighlightedRectangle.TabIndex = 16;
            this.btnAnnotationHighlightedRectangle.UseVisualStyleBackColor = false;
            this.btnAnnotationHighlightedRectangle.Click += new System.EventHandler(this.btnAnnotationHighlightedRectangle_Click);
            // 
            // btnAnnotationHighlighter
            // 
            this.btnAnnotationHighlighter.AutoSize = true;
            this.btnAnnotationHighlighter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationHighlighter.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationHighlighter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationHighlighter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationHighlighter.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationHighlighter.Image")));
            this.btnAnnotationHighlighter.Location = new System.Drawing.Point(98, 23);
            this.btnAnnotationHighlighter.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationHighlighter.Name = "btnAnnotationHighlighter";
            this.btnAnnotationHighlighter.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationHighlighter.TabIndex = 17;
            this.btnAnnotationHighlighter.UseVisualStyleBackColor = false;
            this.btnAnnotationHighlighter.Click += new System.EventHandler(this.btnAnnotationHighlighter_Click);
            // 
            // btnAnnotationRectangle
            // 
            this.btnAnnotationRectangle.AutoSize = true;
            this.btnAnnotationRectangle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationRectangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationRectangle.Image")));
            this.btnAnnotationRectangle.Location = new System.Drawing.Point(174, 23);
            this.btnAnnotationRectangle.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationRectangle.Name = "btnAnnotationRectangle";
            this.btnAnnotationRectangle.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationRectangle.TabIndex = 0;
            this.btnAnnotationRectangle.UseVisualStyleBackColor = false;
            this.btnAnnotationRectangle.Click += new System.EventHandler(this.btnAnnotationRectangle_Click);
            // 
            // btnAnnotationFilledRectangle
            // 
            this.btnAnnotationFilledRectangle.AutoSize = true;
            this.btnAnnotationFilledRectangle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationFilledRectangle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationFilledRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationFilledRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationFilledRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationFilledRectangle.Image")));
            this.btnAnnotationFilledRectangle.Location = new System.Drawing.Point(22, 101);
            this.btnAnnotationFilledRectangle.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationFilledRectangle.Name = "btnAnnotationFilledRectangle";
            this.btnAnnotationFilledRectangle.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationFilledRectangle.TabIndex = 1;
            this.btnAnnotationFilledRectangle.UseVisualStyleBackColor = false;
            this.btnAnnotationFilledRectangle.Click += new System.EventHandler(this.btnAnnotationFilledRectangle_Click);
            // 
            // btnAnnotationEllipse
            // 
            this.btnAnnotationEllipse.AutoSize = true;
            this.btnAnnotationEllipse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationEllipse.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationEllipse.Image")));
            this.btnAnnotationEllipse.Location = new System.Drawing.Point(98, 101);
            this.btnAnnotationEllipse.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationEllipse.Name = "btnAnnotationEllipse";
            this.btnAnnotationEllipse.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationEllipse.TabIndex = 2;
            this.btnAnnotationEllipse.UseVisualStyleBackColor = false;
            this.btnAnnotationEllipse.Click += new System.EventHandler(this.btnAnnotationEllipse_Click);
            // 
            // btnAnnotationFilledEllipse
            // 
            this.btnAnnotationFilledEllipse.AutoSize = true;
            this.btnAnnotationFilledEllipse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationFilledEllipse.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationFilledEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationFilledEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationFilledEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationFilledEllipse.Image")));
            this.btnAnnotationFilledEllipse.Location = new System.Drawing.Point(174, 101);
            this.btnAnnotationFilledEllipse.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationFilledEllipse.Name = "btnAnnotationFilledEllipse";
            this.btnAnnotationFilledEllipse.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationFilledEllipse.TabIndex = 3;
            this.btnAnnotationFilledEllipse.UseVisualStyleBackColor = false;
            this.btnAnnotationFilledEllipse.Click += new System.EventHandler(this.btnAnnotationFilledEllipse_Click);
            // 
            // btnAnnotationImage
            // 
            this.btnAnnotationImage.AutoSize = true;
            this.btnAnnotationImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationImage.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationImage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationImage.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationImage.Image")));
            this.btnAnnotationImage.Location = new System.Drawing.Point(22, 179);
            this.btnAnnotationImage.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationImage.Name = "btnAnnotationImage";
            this.btnAnnotationImage.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationImage.TabIndex = 4;
            this.btnAnnotationImage.UseVisualStyleBackColor = false;
            this.btnAnnotationImage.Click += new System.EventHandler(this.btnAnnotationImage_Click);
            // 
            // btnAnnotationRubberStamp
            // 
            this.btnAnnotationRubberStamp.AutoSize = true;
            this.btnAnnotationRubberStamp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationRubberStamp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationRubberStamp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationRubberStamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationRubberStamp.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationRubberStamp.Image")));
            this.btnAnnotationRubberStamp.Location = new System.Drawing.Point(98, 179);
            this.btnAnnotationRubberStamp.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationRubberStamp.Name = "btnAnnotationRubberStamp";
            this.btnAnnotationRubberStamp.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationRubberStamp.TabIndex = 5;
            this.btnAnnotationRubberStamp.UseVisualStyleBackColor = false;
            this.btnAnnotationRubberStamp.Click += new System.EventHandler(this.btnAnnotationRubberStamp_Click);
            // 
            // btnAnnotationLine
            // 
            this.btnAnnotationLine.AutoSize = true;
            this.btnAnnotationLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationLine.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationLine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationLine.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationLine.Image")));
            this.btnAnnotationLine.Location = new System.Drawing.Point(174, 179);
            this.btnAnnotationLine.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationLine.Name = "btnAnnotationLine";
            this.btnAnnotationLine.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationLine.TabIndex = 6;
            this.btnAnnotationLine.UseVisualStyleBackColor = false;
            this.btnAnnotationLine.Click += new System.EventHandler(this.btnAnnotationLine_Click);
            // 
            // btnAnnotationConnectedLines
            // 
            this.btnAnnotationConnectedLines.AutoSize = true;
            this.btnAnnotationConnectedLines.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationConnectedLines.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationConnectedLines.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationConnectedLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationConnectedLines.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationConnectedLines.Image")));
            this.btnAnnotationConnectedLines.Location = new System.Drawing.Point(22, 257);
            this.btnAnnotationConnectedLines.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationConnectedLines.Name = "btnAnnotationConnectedLines";
            this.btnAnnotationConnectedLines.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationConnectedLines.TabIndex = 7;
            this.btnAnnotationConnectedLines.UseVisualStyleBackColor = false;
            this.btnAnnotationConnectedLines.Click += new System.EventHandler(this.btnAnnotationConnectedLines_Click);
            // 
            // btnAnnotationArrow
            // 
            this.btnAnnotationArrow.AutoSize = true;
            this.btnAnnotationArrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationArrow.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationArrow.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationArrow.Image")));
            this.btnAnnotationArrow.Location = new System.Drawing.Point(98, 257);
            this.btnAnnotationArrow.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationArrow.Name = "btnAnnotationArrow";
            this.btnAnnotationArrow.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationArrow.TabIndex = 8;
            this.btnAnnotationArrow.UseVisualStyleBackColor = false;
            this.btnAnnotationArrow.Click += new System.EventHandler(this.btnAnnotationArrow_Click);
            // 
            // btnAnnotationText
            // 
            this.btnAnnotationText.AutoSize = true;
            this.btnAnnotationText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationText.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationText.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationText.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationText.Image")));
            this.btnAnnotationText.Location = new System.Drawing.Point(174, 257);
            this.btnAnnotationText.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationText.Name = "btnAnnotationText";
            this.btnAnnotationText.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationText.TabIndex = 9;
            this.btnAnnotationText.UseVisualStyleBackColor = false;
            this.btnAnnotationText.Click += new System.EventHandler(this.btnAnnotationText_Click);
            // 
            // btnAnnotationStickyNote
            // 
            this.btnAnnotationStickyNote.AutoSize = true;
            this.btnAnnotationStickyNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationStickyNote.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationStickyNote.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationStickyNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationStickyNote.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationStickyNote.Image")));
            this.btnAnnotationStickyNote.Location = new System.Drawing.Point(22, 335);
            this.btnAnnotationStickyNote.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationStickyNote.Name = "btnAnnotationStickyNote";
            this.btnAnnotationStickyNote.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationStickyNote.TabIndex = 10;
            this.btnAnnotationStickyNote.UseVisualStyleBackColor = false;
            this.btnAnnotationStickyNote.Click += new System.EventHandler(this.btnAnnotationStickyNote_Click);
            // 
            // btnAnnotationFreehand
            // 
            this.btnAnnotationFreehand.AutoSize = true;
            this.btnAnnotationFreehand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationFreehand.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationFreehand.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationFreehand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationFreehand.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationFreehand.Image")));
            this.btnAnnotationFreehand.Location = new System.Drawing.Point(98, 335);
            this.btnAnnotationFreehand.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationFreehand.Name = "btnAnnotationFreehand";
            this.btnAnnotationFreehand.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationFreehand.TabIndex = 11;
            this.btnAnnotationFreehand.UseVisualStyleBackColor = false;
            this.btnAnnotationFreehand.Click += new System.EventHandler(this.btnAnnotationFreehand_Click);
            // 
            // btnAnnotationLink
            // 
            this.btnAnnotationLink.AutoSize = true;
            this.btnAnnotationLink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationLink.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationLink.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationLink.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationLink.Image")));
            this.btnAnnotationLink.Location = new System.Drawing.Point(174, 335);
            this.btnAnnotationLink.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationLink.Name = "btnAnnotationLink";
            this.btnAnnotationLink.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationLink.TabIndex = 12;
            this.btnAnnotationLink.UseVisualStyleBackColor = false;
            this.btnAnnotationLink.Click += new System.EventHandler(this.btnAnnotationLink_Click);
            // 
            // btnAnnotationPolygon
            // 
            this.btnAnnotationPolygon.AutoSize = true;
            this.btnAnnotationPolygon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationPolygon.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationPolygon.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationPolygon.Image")));
            this.btnAnnotationPolygon.Location = new System.Drawing.Point(22, 413);
            this.btnAnnotationPolygon.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationPolygon.Name = "btnAnnotationPolygon";
            this.btnAnnotationPolygon.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationPolygon.TabIndex = 13;
            this.btnAnnotationPolygon.UseVisualStyleBackColor = false;
            this.btnAnnotationPolygon.Click += new System.EventHandler(this.btnAnnotationPolygon_Click);
            // 
            // btnAnnotationFreehandPolygon
            // 
            this.btnAnnotationFreehandPolygon.AutoSize = true;
            this.btnAnnotationFreehandPolygon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationFreehandPolygon.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationFreehandPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationFreehandPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationFreehandPolygon.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationFreehandPolygon.Image")));
            this.btnAnnotationFreehandPolygon.Location = new System.Drawing.Point(98, 413);
            this.btnAnnotationFreehandPolygon.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationFreehandPolygon.Name = "btnAnnotationFreehandPolygon";
            this.btnAnnotationFreehandPolygon.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationFreehandPolygon.TabIndex = 14;
            this.btnAnnotationFreehandPolygon.UseVisualStyleBackColor = false;
            this.btnAnnotationFreehandPolygon.Click += new System.EventHandler(this.btnAnnotationFreehandPolygon_Click);
            // 
            // btnAnnotationRuler
            // 
            this.btnAnnotationRuler.AutoSize = true;
            this.btnAnnotationRuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationRuler.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationRuler.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationRuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationRuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationRuler.Image")));
            this.btnAnnotationRuler.Location = new System.Drawing.Point(174, 413);
            this.btnAnnotationRuler.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationRuler.Name = "btnAnnotationRuler";
            this.btnAnnotationRuler.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationRuler.TabIndex = 15;
            this.btnAnnotationRuler.UseVisualStyleBackColor = false;
            this.btnAnnotationRuler.Click += new System.EventHandler(this.btnAnnotationRuler_Click);
            // 
            // btnAnnotationPolyRuler
            // 
            this.btnAnnotationPolyRuler.AutoSize = true;
            this.btnAnnotationPolyRuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnotationPolyRuler.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnnotationPolyRuler.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnnotationPolyRuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnotationPolyRuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnotationPolyRuler.Image")));
            this.btnAnnotationPolyRuler.Location = new System.Drawing.Point(22, 491);
            this.btnAnnotationPolyRuler.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.btnAnnotationPolyRuler.Name = "btnAnnotationPolyRuler";
            this.btnAnnotationPolyRuler.Size = new System.Drawing.Size(32, 32);
            this.btnAnnotationPolyRuler.TabIndex = 18;
            this.btnAnnotationPolyRuler.UseVisualStyleBackColor = false;
            this.btnAnnotationPolyRuler.Click += new System.EventHandler(this.btnAnnotationPolyRuler_Click);
            // 
            // scMain
            // 
            this.scMain.BackColor = System.Drawing.SystemColors.Control;
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.scMain.Panel1.Controls.Add(this.Panel6);
            this.scMain.Panel1MinSize = 256;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pGamma);
            this.scMain.Panel2.Controls.Add(this.GdViewer1);
            this.scMain.Panel2MinSize = 200;
            this.scMain.Size = new System.Drawing.Size(1896, 1065);
            this.scMain.SplitterDistance = 368;
            this.scMain.SplitterWidth = 6;
            this.scMain.TabIndex = 2;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.Panel9);
            this.Panel6.Controls.Add(this.pSnapInButtons);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(0, 0);
            this.Panel6.Margin = new System.Windows.Forms.Padding(0);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(366, 1063);
            this.Panel6.TabIndex = 2;
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.SystemColors.Control;
            this.Panel9.Controls.Add(this.tcLeftPanel);
            this.Panel9.Controls.Add(this.Panel7);
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel9.Location = new System.Drawing.Point(48, 0);
            this.Panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(318, 1063);
            this.Panel9.TabIndex = 5;
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.SystemColors.Control;
            this.Panel7.Controls.Add(this.lblSnapInPanel);
            this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel7.Location = new System.Drawing.Point(0, 0);
            this.Panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(318, 49);
            this.Panel7.TabIndex = 6;
            // 
            // lblSnapInPanel
            // 
            this.lblSnapInPanel.AutoSize = true;
            this.lblSnapInPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnapInPanel.Location = new System.Drawing.Point(9, 12);
            this.lblSnapInPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnapInPanel.Name = "lblSnapInPanel";
            this.lblSnapInPanel.Size = new System.Drawing.Size(113, 22);
            this.lblSnapInPanel.TabIndex = 0;
            this.lblSnapInPanel.Text = "Thumbnails";
            // 
            // pSnapInButtons
            // 
            this.pSnapInButtons.AutoSize = true;
            this.pSnapInButtons.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pSnapInButtons.Controls.Add(this.btnSnapInThumbnails);
            this.pSnapInButtons.Controls.Add(this.btnSnapInBookmarks);
            this.pSnapInButtons.Controls.Add(this.btnSnapInSearch);
            this.pSnapInButtons.Controls.Add(this.btnSnapInAnnotations);
            this.pSnapInButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSnapInButtons.Location = new System.Drawing.Point(0, 0);
            this.pSnapInButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pSnapInButtons.Name = "pSnapInButtons";
            this.pSnapInButtons.Size = new System.Drawing.Size(48, 1063);
            this.pSnapInButtons.TabIndex = 4;
            // 
            // btnSnapInThumbnails
            // 
            this.btnSnapInThumbnails.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInThumbnails.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSnapInThumbnails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInThumbnails.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInThumbnails.Image")));
            this.btnSnapInThumbnails.Location = new System.Drawing.Point(0, 0);
            this.btnSnapInThumbnails.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInThumbnails.Name = "btnSnapInThumbnails";
            this.btnSnapInThumbnails.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInThumbnails.TabIndex = 0;
            this.btnSnapInThumbnails.UseVisualStyleBackColor = false;
            this.btnSnapInThumbnails.Click += new System.EventHandler(this.btnSnapInThumbnails_Click);
            // 
            // btnSnapInBookmarks
            // 
            this.btnSnapInBookmarks.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInBookmarks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInBookmarks.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInBookmarks.Image")));
            this.btnSnapInBookmarks.Location = new System.Drawing.Point(0, 48);
            this.btnSnapInBookmarks.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInBookmarks.Name = "btnSnapInBookmarks";
            this.btnSnapInBookmarks.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInBookmarks.TabIndex = 1;
            this.btnSnapInBookmarks.UseVisualStyleBackColor = false;
            this.btnSnapInBookmarks.Click += new System.EventHandler(this.btnSnapInBookmarks_Click);
            // 
            // btnSnapInSearch
            // 
            this.btnSnapInSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInSearch.Image")));
            this.btnSnapInSearch.Location = new System.Drawing.Point(0, 95);
            this.btnSnapInSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInSearch.Name = "btnSnapInSearch";
            this.btnSnapInSearch.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInSearch.TabIndex = 2;
            this.btnSnapInSearch.UseVisualStyleBackColor = false;
            this.btnSnapInSearch.Click += new System.EventHandler(this.btnSnapInSearch_Click);
            // 
            // btnSnapInAnnotations
            // 
            this.btnSnapInAnnotations.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInAnnotations.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInAnnotations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInAnnotations.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInAnnotations.Image")));
            this.btnSnapInAnnotations.Location = new System.Drawing.Point(0, 145);
            this.btnSnapInAnnotations.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInAnnotations.Name = "btnSnapInAnnotations";
            this.btnSnapInAnnotations.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInAnnotations.TabIndex = 3;
            this.btnSnapInAnnotations.UseVisualStyleBackColor = false;
            this.btnSnapInAnnotations.Click += new System.EventHandler(this.btnSnapInAnnotations_Click);
            // 
            // pGamma
            // 
            this.pGamma.AutoSize = true;
            this.pGamma.BackColor = System.Drawing.SystemColors.Control;
            this.pGamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGamma.Controls.Add(this.lblGamma);
            this.pGamma.Controls.Add(this.tbGamma);
            this.pGamma.Location = new System.Drawing.Point(4, 5);
            this.pGamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pGamma.Name = "pGamma";
            this.pGamma.Size = new System.Drawing.Size(474, 113);
            this.pGamma.TabIndex = 1;
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGamma.Location = new System.Drawing.Point(4, 65);
            this.lblGamma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(111, 20);
            this.lblGamma.TabIndex = 1;
            this.lblGamma.Text = "Current value: ";
            // 
            // tbGamma
            // 
            this.tbGamma.Location = new System.Drawing.Point(4, 0);
            this.tbGamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGamma.Maximum = 50;
            this.tbGamma.Minimum = 1;
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(464, 69);
            this.tbGamma.TabIndex = 0;
            this.tbGamma.Value = 1;
            this.tbGamma.Scroll += new System.EventHandler(this.tbGamma_Scroll);
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDropFile = false;
            this.GdViewer1.AnimateGIF = false;
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
            this.GdViewer1.Gamma = 1F;
            this.GdViewer1.HQAnnotationRendering = true;
            this.GdViewer1.IgnoreDocumentResolution = false;
            this.GdViewer1.KeepDocumentPosition = false;
            this.GdViewer1.Location = new System.Drawing.Point(0, 0);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
            this.GdViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.GdViewer1.ScrollLargeChange = ((short)(50));
            this.GdViewer1.ScrollSmallChange = ((short)(1));
            this.GdViewer1.SilentMode = true;
            this.GdViewer1.Size = new System.Drawing.Size(1520, 1063);
            this.GdViewer1.TabIndex = 0;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            this.GdViewer1.OnCustomAnnotationPaint += new GdPicture14.GdViewer.OnCustomAnnotationPaintEventHandler(this.GdViewer1_OnCustomAnnotationPaint);
            this.GdViewer1.TransferEnded += new GdPicture14.GdViewer.TransferEndedEventHandler(this.GdViewer1_TransferEnded);
            this.GdViewer1.AfterZoomChange += new GdPicture14.GdViewer.AfterZoomChangeEventHandler(this.GdViewer1_AfterZoomChange);
            this.GdViewer1.PageChanged += new GdPicture14.GdViewer.PageChangedEventHandler(this.GdViewer1_PageChanged);
            // 
            // statusbar
            // 
            this.statusbar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.statusbar.Location = new System.Drawing.Point(0, 1100);
            this.statusbar.Name = "statusbar";
            this.statusbar.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusbar.Size = new System.Drawing.Size(1896, 22);
            this.statusbar.TabIndex = 3;
            this.statusbar.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.ToolStripSeparator9,
            this.btnClose,
            this.btnPrint,
            this.btnSave,
            this.ToolStripSeparator3,
            this.btnSettings,
            this.ToolStripSeparator8,
            this.btnMouseMode,
            this.ToolStripSeparator6,
            this.btnFirstPage,
            this.btnPreviousPage,
            this.tbCurrentPage,
            this.lblPageCount,
            this.btnNextPage,
            this.btnLastPage,
            this.ToolStripSeparator1,
            this.btnZoomOut,
            this.cbZoom,
            this.btnZoomIn,
            this.ToolStripSeparator2,
            this.btnFitWidth,
            this.btnFitPage,
            this.ToolStripSeparator5,
            this.btnAdjustGamma,
            this.ToolStripSeparator10,
            this.btnRotateLeft,
            this.btnRotateRight,
            this.btnFlipX,
            this.btnFlipY,
            this.ToolStripSeparator4,
            this.btnAbout});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.mainToolStrip.Size = new System.Drawing.Size(1896, 35);
            this.mainToolStrip.TabIndex = 5;
            this.mainToolStrip.Text = "ToolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(182, 32);
            this.btnOpen.Text = "Open document";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 35);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 32);
            this.btnClose.Text = "Close document";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(28, 32);
            this.btnPrint.Text = "Print document";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(28, 32);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(28, 32);
            this.btnSettings.Text = "Viewer settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 35);
            // 
            // btnMouseMode
            // 
            this.btnMouseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMouseMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefaultToolStripMenuItem,
            this.AreaSelectionToolStripMenuItem,
            this.PanToolStripMenuItem,
            this.AreaZoomingToolStripMenuItem,
            this.MagnifierToolStripMenuItem});
            this.btnMouseMode.Image = ((System.Drawing.Image)(resources.GetObject("btnMouseMode.Image")));
            this.btnMouseMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMouseMode.Name = "btnMouseMode";
            this.btnMouseMode.Size = new System.Drawing.Size(42, 32);
            this.btnMouseMode.Text = "Mouse mode";
            // 
            // DefaultToolStripMenuItem
            // 
            this.DefaultToolStripMenuItem.CheckOnClick = true;
            this.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem";
            this.DefaultToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.DefaultToolStripMenuItem.Text = "Default";
            this.DefaultToolStripMenuItem.Click += new System.EventHandler(this.DefaultToolStripMenuItem_Click);
            // 
            // AreaSelectionToolStripMenuItem
            // 
            this.AreaSelectionToolStripMenuItem.CheckOnClick = true;
            this.AreaSelectionToolStripMenuItem.Name = "AreaSelectionToolStripMenuItem";
            this.AreaSelectionToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.AreaSelectionToolStripMenuItem.Text = "Area selection";
            this.AreaSelectionToolStripMenuItem.Click += new System.EventHandler(this.AreaSelectionToolStripMenuItem_Click);
            // 
            // PanToolStripMenuItem
            // 
            this.PanToolStripMenuItem.Checked = true;
            this.PanToolStripMenuItem.CheckOnClick = true;
            this.PanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PanToolStripMenuItem.Name = "PanToolStripMenuItem";
            this.PanToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.PanToolStripMenuItem.Text = "Pan";
            this.PanToolStripMenuItem.Click += new System.EventHandler(this.PanToolStripMenuItem_Click);
            // 
            // AreaZoomingToolStripMenuItem
            // 
            this.AreaZoomingToolStripMenuItem.CheckOnClick = true;
            this.AreaZoomingToolStripMenuItem.Name = "AreaZoomingToolStripMenuItem";
            this.AreaZoomingToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.AreaZoomingToolStripMenuItem.Text = "Area zooming";
            this.AreaZoomingToolStripMenuItem.Click += new System.EventHandler(this.AreaZoomingToolStripMenuItem_Click);
            // 
            // MagnifierToolStripMenuItem
            // 
            this.MagnifierToolStripMenuItem.CheckOnClick = true;
            this.MagnifierToolStripMenuItem.Name = "MagnifierToolStripMenuItem";
            this.MagnifierToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.MagnifierToolStripMenuItem.Text = "Magnifier";
            this.MagnifierToolStripMenuItem.Click += new System.EventHandler(this.MagnifierToolStripMenuItem_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.Image")));
            this.btnFirstPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(28, 32);
            this.btnFirstPage.Text = "Go to first page";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.Image")));
            this.btnPreviousPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(28, 32);
            this.btnPreviousPage.Text = "Go to previous page";
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.Size = new System.Drawing.Size(58, 35);
            this.tbCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCurrentPage.Leave += new System.EventHandler(this.tbCurrentPage_Leave);
            // 
            // lblPageCount
            // 
            this.lblPageCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(37, 32);
            this.lblPageCount.Text = "/ X";
            // 
            // btnNextPage
            // 
            this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(28, 32);
            this.btnNextPage.Text = "Go to next page";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnLastPage.Image")));
            this.btnLastPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(28, 32);
            this.btnLastPage.Text = "Go to last page";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(28, 32);
            this.btnZoomOut.Text = "Zoom out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // cbZoom
            // 
            this.cbZoom.DropDownWidth = 200;
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(110, 35);
            this.cbZoom.SelectedIndexChanged += new System.EventHandler(this.cbZoom_SelectedIndexChanged);
            this.cbZoom.Validating += new System.ComponentModel.CancelEventHandler(this.cbZoom_Validating);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(28, 32);
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // btnFitWidth
            // 
            this.btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFitWidth.Image = ((System.Drawing.Image)(resources.GetObject("btnFitWidth.Image")));
            this.btnFitWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitWidth.Name = "btnFitWidth";
            this.btnFitWidth.Size = new System.Drawing.Size(28, 32);
            this.btnFitWidth.Text = "Adjust to page width";
            this.btnFitWidth.Click += new System.EventHandler(this.btnFitWidth_Click);
            // 
            // btnFitPage
            // 
            this.btnFitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFitPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFitPage.Image")));
            this.btnFitPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFitPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitPage.Name = "btnFitPage";
            this.btnFitPage.Size = new System.Drawing.Size(28, 32);
            this.btnFitPage.Text = "Adjust to whole page";
            this.btnFitPage.Click += new System.EventHandler(this.btnFitPage_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // btnAdjustGamma
            // 
            this.btnAdjustGamma.CheckOnClick = true;
            this.btnAdjustGamma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdjustGamma.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjustGamma.Image")));
            this.btnAdjustGamma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdjustGamma.Name = "btnAdjustGamma";
            this.btnAdjustGamma.Size = new System.Drawing.Size(28, 32);
            this.btnAdjustGamma.Text = "Adjust gamma";
            this.btnAdjustGamma.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(6, 35);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateLeft.Image")));
            this.btnRotateLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(28, 32);
            this.btnRotateLeft.Text = "Rotate left";
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateRight.Image")));
            this.btnRotateRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRotateRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(28, 32);
            this.btnRotateRight.Text = "Rotate right";
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnFlipX
            // 
            this.btnFlipX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFlipX.Image = ((System.Drawing.Image)(resources.GetObject("btnFlipX.Image")));
            this.btnFlipX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFlipX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFlipX.Name = "btnFlipX";
            this.btnFlipX.Size = new System.Drawing.Size(28, 32);
            this.btnFlipX.Text = "Vertical flip";
            this.btnFlipX.Click += new System.EventHandler(this.btnFlipX_Click);
            // 
            // btnFlipY
            // 
            this.btnFlipY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFlipY.Image = ((System.Drawing.Image)(resources.GetObject("btnFlipY.Image")));
            this.btnFlipY.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFlipY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFlipY.Name = "btnFlipY";
            this.btnFlipY.Size = new System.Drawing.Size(28, 32);
            this.btnFlipY.Text = "Horizontal flip";
            this.btnFlipY.Click += new System.EventHandler(this.btnFlipY_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(28, 32);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.scMain);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 35);
            this.pMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1896, 1065);
            this.pMain.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1122);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.statusbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GdPicture .NET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.tpAnnotations.ResumeLayout(false);
            this.pAnnotations.ResumeLayout(false);
            this.pAnnotations.PerformLayout();
            this.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer2.BottomToolStripPanel.PerformLayout();
            this.ToolStripContainer2.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer2.ResumeLayout(false);
            this.ToolStripContainer2.PerformLayout();
            this.annotationsToolStrip.ResumeLayout(false);
            this.annotationsToolStrip.PerformLayout();
            this.Panel10.ResumeLayout(false);
            this.Panel10.PerformLayout();
            this.pBtnCustomAnnotations.ResumeLayout(false);
            this.pBtnCustomAnnotations.PerformLayout();
            this.pBtnAnnotations.ResumeLayout(false);
            this.pBtnAnnotations.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.pSnapInButtons.ResumeLayout(false);
            this.pGamma.ResumeLayout(false);
            this.pGamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).EndInit();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.pMain.ResumeLayout(false);
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
		internal System.Windows.Forms.TabPage tpAnnotations;
		internal System.Windows.Forms.Button btnSnapInAnnotations;
		internal System.Windows.Forms.Button btnAnnotationRectangle;
		internal System.Windows.Forms.FlowLayoutPanel pBtnAnnotations;
		internal System.Windows.Forms.Button btnAnnotationHighlightedRectangle;
		internal System.Windows.Forms.Button btnAnnotationHighlighter;
		internal System.Windows.Forms.Button btnAnnotationFilledRectangle;
		internal System.Windows.Forms.Button btnAnnotationEllipse;
		internal System.Windows.Forms.Button btnAnnotationFilledEllipse;
		internal System.Windows.Forms.Button btnAnnotationImage;
		internal System.Windows.Forms.Button btnAnnotationRubberStamp;
		internal System.Windows.Forms.Button btnAnnotationLine;
		internal System.Windows.Forms.Button btnAnnotationConnectedLines;
		internal System.Windows.Forms.Button btnAnnotationArrow;
		internal System.Windows.Forms.Button btnAnnotationText;
		internal System.Windows.Forms.Button btnAnnotationStickyNote;
		internal System.Windows.Forms.Button btnAnnotationFreehand;
		internal System.Windows.Forms.Button btnAnnotationLink;
		internal System.Windows.Forms.Button btnAnnotationPolygon;
		internal System.Windows.Forms.Button btnAnnotationFreehandPolygon;
		internal System.Windows.Forms.Button btnAnnotationRuler;
		internal GdPicture14.AnnotationEditor AnnotationEditor1;
		internal System.Windows.Forms.Panel pAnnotations;
		internal System.Windows.Forms.FlowLayoutPanel pBtnCustomAnnotations;
		internal System.Windows.Forms.Button btnCustomAnnotation1;
		internal System.Windows.Forms.Button btnCustomAnnotation2;
		internal System.Windows.Forms.Panel Panel10;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ToolStrip annotationsToolStrip;
		internal System.Windows.Forms.ToolStripButton btnLoadAnnotationsFromXMP;
		internal System.Windows.Forms.ToolStripButton btnBurnAnnotations;
		internal System.Windows.Forms.ToolStripDropDownButton btnSaveAnnotations;
		internal System.Windows.Forms.ToolStripMenuItem SaveAllAnnotationsToXMPToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SaveCurrentAnnotationToXMPToolStripMenuItem;
		internal System.Windows.Forms.ToolStripDropDownButton btnRemoveAnnotations;
		internal System.Windows.Forms.ToolStripMenuItem RemoveAllAnnotationsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem RemoveSelectedAnnotationToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripContainer ToolStripContainer2;
		internal System.Windows.Forms.Button btnAnnotationPolyRuler;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
		internal System.Windows.Forms.ToolStripButton btnSetAnnotationEditorMode;
		internal System.Windows.Forms.ToolStripButton btnSave;
		
	}
	
}
