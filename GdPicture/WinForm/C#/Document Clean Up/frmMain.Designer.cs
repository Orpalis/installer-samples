using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;


namespace DocumentCleanUp
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
            this.tpDocumentCleanUp = new System.Windows.Forms.TabPage();
            this.pDocumentCleanUp = new System.Windows.Forms.Panel();
            this.tbEffectsParameters = new System.Windows.Forms.TabControl();
            this.tpAutoDeskewParameters = new System.Windows.Forms.TabPage();
            this.chkAutoDeskewOptimistic = new System.Windows.Forms.CheckBox();
            this.nAutoDeskewAngleStep = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.pAutoDeskewBackColor = new System.Windows.Forms.PictureBox();
            this.nAutoDeskewMaxAngleOfResearch = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.tpAutoTextInvert = new System.Windows.Forms.TabPage();
            this.nAutoInvertTextMaxLinesThickness = new System.Windows.Forms.NumericUpDown();
            this.Label8 = new System.Windows.Forms.Label();
            this.chkAutoTextInvertConnectedToLines = new System.Windows.Forms.CheckBox();
            this.chkAutoTextInvertFixBackground = new System.Windows.Forms.CheckBox();
            this.nAutoInvertTextMaxBlackPercent = new System.Windows.Forms.NumericUpDown();
            this.Label7 = new System.Windows.Forms.Label();
            this.nAutoInvertTextMinBlackPercent = new System.Windows.Forms.NumericUpDown();
            this.Label6 = new System.Windows.Forms.Label();
            this.nAutoInvertTextMinObjectHeight = new System.Windows.Forms.NumericUpDown();
            this.Label5 = new System.Windows.Forms.Label();
            this.nAutoInvertTextMinObjectWidth = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.tpCropBlackBorders = new System.Windows.Forms.TabPage();
            this.nCropBlackBordersSkipLinesCount = new System.Windows.Forms.NumericUpDown();
            this.Label10 = new System.Windows.Forms.Label();
            this.nCropBlackBordersConfidence = new System.Windows.Forms.NumericUpDown();
            this.Label9 = new System.Windows.Forms.Label();
            this.tpCropBorders = new System.Windows.Forms.TabPage();
            this.cbCropBordersImageContext = new System.Windows.Forms.ComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.nCropBordersHeight = new System.Windows.Forms.NumericUpDown();
            this.Label16 = new System.Windows.Forms.Label();
            this.nCropBordersWidth = new System.Windows.Forms.NumericUpDown();
            this.Label15 = new System.Windows.Forms.Label();
            this.nCropBordersTop = new System.Windows.Forms.NumericUpDown();
            this.Label14 = new System.Windows.Forms.Label();
            this.nCropBordersLeft = new System.Windows.Forms.NumericUpDown();
            this.Label13 = new System.Windows.Forms.Label();
            this.cbCropBordersReferencePoint = new System.Windows.Forms.ComboBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.nCropBordersConfidence = new System.Windows.Forms.NumericUpDown();
            this.Label11 = new System.Windows.Forms.Label();
            this.tpDeleteBlackBorders = new System.Windows.Forms.TabPage();
            this.chkDeleteBlackBordersEffectSkewedBorders = new System.Windows.Forms.CheckBox();
            this.nDeleteBlackBorderEffectMargin = new System.Windows.Forms.NumericUpDown();
            this.Label18 = new System.Windows.Forms.Label();
            this.tpMedian = new System.Windows.Forms.TabPage();
            this.nMedianEffectKernelSize = new System.Windows.Forms.NumericUpDown();
            this.Label19 = new System.Windows.Forms.Label();
            this.tpRemoveBlob = new System.Windows.Forms.TabPage();
            this.nRemoveBlobEffectMaxFillPercent = new System.Windows.Forms.NumericUpDown();
            this.Label25 = new System.Windows.Forms.Label();
            this.nRemoveBlobEffectMinFillPercent = new System.Windows.Forms.NumericUpDown();
            this.Label24 = new System.Windows.Forms.Label();
            this.nRemoveBlobEffectMaxBlobHeight = new System.Windows.Forms.NumericUpDown();
            this.Label23 = new System.Windows.Forms.Label();
            this.nRemoveBlobEffectMaxBlobWidth = new System.Windows.Forms.NumericUpDown();
            this.Label22 = new System.Windows.Forms.Label();
            this.nRemoveBlobEffectMinBlobHeight = new System.Windows.Forms.NumericUpDown();
            this.Label21 = new System.Windows.Forms.Label();
            this.nRemoveBlobEffectMinBlobWidth = new System.Windows.Forms.NumericUpDown();
            this.Label20 = new System.Windows.Forms.Label();
            this.tpRemoveLines = new System.Windows.Forms.TabPage();
            this.chkRemoveLinesEffectReconnectBrokenCharacters = new System.Windows.Forms.CheckBox();
            this.nRemoveLinesEffectMaxInterception = new System.Windows.Forms.NumericUpDown();
            this.Label30 = new System.Windows.Forms.Label();
            this.nRemoveLinesEffectMinLineLength = new System.Windows.Forms.NumericUpDown();
            this.Label29 = new System.Windows.Forms.Label();
            this.nRemoveLinesEffectMaxLineThickness = new System.Windows.Forms.NumericUpDown();
            this.Label28 = new System.Windows.Forms.Label();
            this.nRemoveLinesEffectMaxLineGap = new System.Windows.Forms.NumericUpDown();
            this.Label27 = new System.Windows.Forms.Label();
            this.cbRemoveLinesEffectOrientation = new System.Windows.Forms.ComboBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.tpBitonalDespeckle = new System.Windows.Forms.TabPage();
            this.chkBitonalDespeckleEffectFixText = new System.Windows.Forms.CheckBox();
            this.tpBitonalSkeletonize = new System.Windows.Forms.TabPage();
            this.nBitonalSkeletonizeEffectRepetition = new System.Windows.Forms.NumericUpDown();
            this.Label31 = new System.Windows.Forms.Label();
            this.tpBitonalVigorousDespeckle = new System.Windows.Forms.TabPage();
            this.chkBitonalVigorousDespeckleEffectCheckForDotOfI = new System.Windows.Forms.CheckBox();
            this.tpBitonalDilate = new System.Windows.Forms.TabPage();
            this.nBitonalDilateEffectKernelSize = new System.Windows.Forms.NumericUpDown();
            this.Label32 = new System.Windows.Forms.Label();
            this.tpRemoveHolePunch = new System.Windows.Forms.TabPage();
            this.Label35 = new System.Windows.Forms.Label();
            this.cbRemoveHolePunchEffectMargins = new System.Windows.Forms.ComboBox();
            this.tpDespeckleAdvanced = new System.Windows.Forms.TabPage();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.nDespeckleStrength = new System.Windows.Forms.NumericUpDown();
            this.cbDespeckleType = new System.Windows.Forms.ComboBox();
            this.pDirectEffects = new System.Windows.Forms.Panel();
            this.btnMoveEffectDown = new System.Windows.Forms.Button();
            this.btnMoveEffectUp = new System.Windows.Forms.Button();
            this.btnRemoveAllEffects = new System.Windows.Forms.Button();
            this.btnRemoveEffect = new System.Windows.Forms.Button();
            this.lstEffects = new System.Windows.Forms.ListBox();
            this.btnAddEffect = new System.Windows.Forms.Button();
            this.cbDocumentCleanUpEffects = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnApplyEffects = new System.Windows.Forms.Button();
            this.btnResetEffects = new System.Windows.Forms.Button();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.lblSnapInPanel = new System.Windows.Forms.Label();
            this.pSnapInButtons = new System.Windows.Forms.Panel();
            this.btnSnapInThumbnails = new System.Windows.Forms.Button();
            this.btnSnapInDocumentCleanUp = new System.Windows.Forms.Button();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label33 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.GdViewerPreview = new GdPicture14.GdViewer();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label34 = new System.Windows.Forms.Label();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
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
            this.btnRotateLeft = new System.Windows.Forms.ToolStripButton();
            this.btnRotateRight = new System.Windows.Forms.ToolStripButton();
            this.btnFlipX = new System.Windows.Forms.ToolStripButton();
            this.btnFlipY = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.btnImportFromClipboard = new System.Windows.Forms.ToolStripButton();
            this.Label38 = new System.Windows.Forms.Label();
            this.tcLeftPanel.SuspendLayout();
            this.tpThumbnails.SuspendLayout();
            this.ToolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.ToolStripContainer1.ContentPanel.SuspendLayout();
            this.ToolStripContainer1.SuspendLayout();
            this.thumbnailPanelToolstrip.SuspendLayout();
            this.tpDocumentCleanUp.SuspendLayout();
            this.pDocumentCleanUp.SuspendLayout();
            this.tbEffectsParameters.SuspendLayout();
            this.tpAutoDeskewParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoDeskewAngleStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAutoDeskewBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoDeskewMaxAngleOfResearch)).BeginInit();
            this.tpAutoTextInvert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMaxLinesThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMaxBlackPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMinBlackPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMinObjectHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMinObjectWidth)).BeginInit();
            this.tpCropBlackBorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBlackBordersSkipLinesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBlackBordersConfidence)).BeginInit();
            this.tpCropBorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersConfidence)).BeginInit();
            this.tpDeleteBlackBorders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDeleteBlackBorderEffectMargin)).BeginInit();
            this.tpMedian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMedianEffectKernelSize)).BeginInit();
            this.tpRemoveBlob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMaxFillPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMinFillPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMaxBlobHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMaxBlobWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMinBlobHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMinBlobWidth)).BeginInit();
            this.tpRemoveLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveLinesEffectMaxInterception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveLinesEffectMinLineLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveLinesEffectMaxLineThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveLinesEffectMaxLineGap)).BeginInit();
            this.tpBitonalDespeckle.SuspendLayout();
            this.tpBitonalSkeletonize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBitonalSkeletonizeEffectRepetition)).BeginInit();
            this.tpBitonalVigorousDespeckle.SuspendLayout();
            this.tpBitonalDilate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBitonalDilateEffectKernelSize)).BeginInit();
            this.tpRemoveHolePunch.SuspendLayout();
            this.tpDespeckleAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDespeckleStrength)).BeginInit();
            this.pDirectEffects.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.pSnapInButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.pMain.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLeftPanel
            // 
            this.tcLeftPanel.Controls.Add(this.tpThumbnails);
            this.tcLeftPanel.Controls.Add(this.tpDocumentCleanUp);
            this.tcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLeftPanel.Location = new System.Drawing.Point(0, 49);
            this.tcLeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tcLeftPanel.Multiline = true;
            this.tcLeftPanel.Name = "tcLeftPanel";
            this.tcLeftPanel.Padding = new System.Drawing.Point(0, 0);
            this.tcLeftPanel.SelectedIndex = 0;
            this.tcLeftPanel.Size = new System.Drawing.Size(312, 1014);
            this.tcLeftPanel.TabIndex = 1;
            // 
            // tpThumbnails
            // 
            this.tpThumbnails.BackColor = System.Drawing.SystemColors.Control;
            this.tpThumbnails.Controls.Add(this.ToolStripContainer1);
            this.tpThumbnails.Location = new System.Drawing.Point(4, 29);
            this.tpThumbnails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpThumbnails.Name = "tpThumbnails";
            this.tpThumbnails.Size = new System.Drawing.Size(304, 981);
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
            this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(304, 925);
            this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.ToolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            this.ToolStripContainer1.Size = new System.Drawing.Size(304, 981);
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
            this.thumbnailPanelToolstrip.Size = new System.Drawing.Size(304, 31);
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
            this.LargeThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(255, 30);
            this.LargeThumbnailsToolStripMenuItem1.Text = "Large thumbnails";
            this.LargeThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.LargeThumbnailsToolStripMenuItem1_Click);
            // 
            // MediumThumbnailsToolStripMenuItem1
            // 
            this.MediumThumbnailsToolStripMenuItem1.Name = "MediumThumbnailsToolStripMenuItem1";
            this.MediumThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(255, 30);
            this.MediumThumbnailsToolStripMenuItem1.Text = "Medium thumbnails";
            this.MediumThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.MediumThumbnailsToolStripMenuItem1_Click);
            // 
            // SmallThumbnailsToolStripMenuItem1
            // 
            this.SmallThumbnailsToolStripMenuItem1.Name = "SmallThumbnailsToolStripMenuItem1";
            this.SmallThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(255, 30);
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
            this.ThumbnailEx1.DefaultItemTextPrefix = "Page ";
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
            this.ThumbnailEx1.Size = new System.Drawing.Size(304, 925);
            this.ThumbnailEx1.TabIndex = 0;
            this.ThumbnailEx1.TextMarginLeft = 0;
            this.ThumbnailEx1.TextMarginTop = 0;
            this.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical;
            this.ThumbnailEx1.ThumbnailBorder = true;
            this.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Gray;
            this.ThumbnailEx1.ThumbnailSize = new System.Drawing.Size(256, 256);
            this.ThumbnailEx1.ThumbnailSpacing = new System.Drawing.Size(0, 0);
            this.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            // 
            // tpDocumentCleanUp
            // 
            this.tpDocumentCleanUp.BackColor = System.Drawing.SystemColors.Control;
            this.tpDocumentCleanUp.Controls.Add(this.pDocumentCleanUp);
            this.tpDocumentCleanUp.Location = new System.Drawing.Point(4, 29);
            this.tpDocumentCleanUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpDocumentCleanUp.Name = "tpDocumentCleanUp";
            this.tpDocumentCleanUp.Size = new System.Drawing.Size(304, 981);
            this.tpDocumentCleanUp.TabIndex = 1;
            this.tpDocumentCleanUp.Text = "Clean Up";
            // 
            // pDocumentCleanUp
            // 
            this.pDocumentCleanUp.Controls.Add(this.tbEffectsParameters);
            this.pDocumentCleanUp.Controls.Add(this.pDirectEffects);
            this.pDocumentCleanUp.Controls.Add(this.Panel1);
            this.pDocumentCleanUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDocumentCleanUp.Location = new System.Drawing.Point(0, 0);
            this.pDocumentCleanUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pDocumentCleanUp.Name = "pDocumentCleanUp";
            this.pDocumentCleanUp.Size = new System.Drawing.Size(304, 981);
            this.pDocumentCleanUp.TabIndex = 1;
            // 
            // tbEffectsParameters
            // 
            this.tbEffectsParameters.Controls.Add(this.tpAutoDeskewParameters);
            this.tbEffectsParameters.Controls.Add(this.tpAutoTextInvert);
            this.tbEffectsParameters.Controls.Add(this.tpCropBlackBorders);
            this.tbEffectsParameters.Controls.Add(this.tpCropBorders);
            this.tbEffectsParameters.Controls.Add(this.tpDeleteBlackBorders);
            this.tbEffectsParameters.Controls.Add(this.tpMedian);
            this.tbEffectsParameters.Controls.Add(this.tpRemoveBlob);
            this.tbEffectsParameters.Controls.Add(this.tpRemoveLines);
            this.tbEffectsParameters.Controls.Add(this.tpBitonalDespeckle);
            this.tbEffectsParameters.Controls.Add(this.tpBitonalSkeletonize);
            this.tbEffectsParameters.Controls.Add(this.tpBitonalVigorousDespeckle);
            this.tbEffectsParameters.Controls.Add(this.tpBitonalDilate);
            this.tbEffectsParameters.Controls.Add(this.tpRemoveHolePunch);
            this.tbEffectsParameters.Controls.Add(this.tpDespeckleAdvanced);
            this.tbEffectsParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEffectsParameters.Location = new System.Drawing.Point(0, 342);
            this.tbEffectsParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEffectsParameters.Multiline = true;
            this.tbEffectsParameters.Name = "tbEffectsParameters";
            this.tbEffectsParameters.SelectedIndex = 0;
            this.tbEffectsParameters.Size = new System.Drawing.Size(304, 594);
            this.tbEffectsParameters.TabIndex = 6;
            // 
            // tpAutoDeskewParameters
            // 
            this.tpAutoDeskewParameters.Controls.Add(this.chkAutoDeskewOptimistic);
            this.tpAutoDeskewParameters.Controls.Add(this.nAutoDeskewAngleStep);
            this.tpAutoDeskewParameters.Controls.Add(this.Label3);
            this.tpAutoDeskewParameters.Controls.Add(this.Label2);
            this.tpAutoDeskewParameters.Controls.Add(this.pAutoDeskewBackColor);
            this.tpAutoDeskewParameters.Controls.Add(this.nAutoDeskewMaxAngleOfResearch);
            this.tpAutoDeskewParameters.Controls.Add(this.Label1);
            this.tpAutoDeskewParameters.Location = new System.Drawing.Point(4, 204);
            this.tpAutoDeskewParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAutoDeskewParameters.Name = "tpAutoDeskewParameters";
            this.tpAutoDeskewParameters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAutoDeskewParameters.Size = new System.Drawing.Size(296, 386);
            this.tpAutoDeskewParameters.TabIndex = 0;
            this.tpAutoDeskewParameters.Text = "Auto deskew";
            this.tpAutoDeskewParameters.UseVisualStyleBackColor = true;
            // 
            // chkAutoDeskewOptimistic
            // 
            this.chkAutoDeskewOptimistic.AutoSize = true;
            this.chkAutoDeskewOptimistic.Location = new System.Drawing.Point(14, 131);
            this.chkAutoDeskewOptimistic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoDeskewOptimistic.Name = "chkAutoDeskewOptimistic";
            this.chkAutoDeskewOptimistic.Size = new System.Drawing.Size(104, 24);
            this.chkAutoDeskewOptimistic.TabIndex = 8;
            this.chkAutoDeskewOptimistic.Text = "Optimistic";
            this.chkAutoDeskewOptimistic.UseVisualStyleBackColor = true;
            // 
            // nAutoDeskewAngleStep
            // 
            this.nAutoDeskewAngleStep.DecimalPlaces = 2;
            this.nAutoDeskewAngleStep.Location = new System.Drawing.Point(188, 91);
            this.nAutoDeskewAngleStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nAutoDeskewAngleStep.Name = "nAutoDeskewAngleStep";
            this.nAutoDeskewAngleStep.Size = new System.Drawing.Size(78, 26);
            this.nAutoDeskewAngleStep.TabIndex = 7;
            this.nAutoDeskewAngleStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 94);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 20);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Angle step";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 57);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 20);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Back color";
            // 
            // pAutoDeskewBackColor
            // 
            this.pAutoDeskewBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAutoDeskewBackColor.Location = new System.Drawing.Point(188, 49);
            this.pAutoDeskewBackColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pAutoDeskewBackColor.Name = "pAutoDeskewBackColor";
            this.pAutoDeskewBackColor.Size = new System.Drawing.Size(30, 31);
            this.pAutoDeskewBackColor.TabIndex = 4;
            this.pAutoDeskewBackColor.TabStop = false;
            this.pAutoDeskewBackColor.Click += new System.EventHandler(this.pAutoDeskewBackColor_Click);
            // 
            // nAutoDeskewMaxAngleOfResearch
            // 
            this.nAutoDeskewMaxAngleOfResearch.DecimalPlaces = 2;
            this.nAutoDeskewMaxAngleOfResearch.Location = new System.Drawing.Point(188, 9);
            this.nAutoDeskewMaxAngleOfResearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nAutoDeskewMaxAngleOfResearch.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nAutoDeskewMaxAngleOfResearch.Name = "nAutoDeskewMaxAngleOfResearch";
            this.nAutoDeskewMaxAngleOfResearch.Size = new System.Drawing.Size(78, 26);
            this.nAutoDeskewMaxAngleOfResearch.TabIndex = 1;
            this.nAutoDeskewMaxAngleOfResearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 12);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(165, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Max angle of research";
            // 
            // tpAutoTextInvert
            // 
            this.tpAutoTextInvert.Controls.Add(this.nAutoInvertTextMaxLinesThickness);
            this.tpAutoTextInvert.Controls.Add(this.Label8);
            this.tpAutoTextInvert.Controls.Add(this.chkAutoTextInvertConnectedToLines);
            this.tpAutoTextInvert.Controls.Add(this.chkAutoTextInvertFixBackground);
            this.tpAutoTextInvert.Controls.Add(this.nAutoInvertTextMaxBlackPercent);
            this.tpAutoTextInvert.Controls.Add(this.Label7);
            this.tpAutoTextInvert.Controls.Add(this.nAutoInvertTextMinBlackPercent);
            this.tpAutoTextInvert.Controls.Add(this.Label6);
            this.tpAutoTextInvert.Controls.Add(this.nAutoInvertTextMinObjectHeight);
            this.tpAutoTextInvert.Controls.Add(this.Label5);
            this.tpAutoTextInvert.Controls.Add(this.nAutoInvertTextMinObjectWidth);
            this.tpAutoTextInvert.Controls.Add(this.Label4);
            this.tpAutoTextInvert.Location = new System.Drawing.Point(4, 204);
            this.tpAutoTextInvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAutoTextInvert.Name = "tpAutoTextInvert";
            this.tpAutoTextInvert.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAutoTextInvert.Size = new System.Drawing.Size(296, 386);
            this.tpAutoTextInvert.TabIndex = 1;
            this.tpAutoTextInvert.Text = "Auto text invert";
            this.tpAutoTextInvert.UseVisualStyleBackColor = true;
            // 
            // nAutoInvertTextMaxLinesThickness
            // 
            this.nAutoInvertTextMaxLinesThickness.Location = new System.Drawing.Point(156, 240);
            this.nAutoInvertTextMaxLinesThickness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nAutoInvertTextMaxLinesThickness.Name = "nAutoInvertTextMaxLinesThickness";
            this.nAutoInvertTextMaxLinesThickness.Size = new System.Drawing.Size(98, 26);
            this.nAutoInvertTextMaxLinesThickness.TabIndex = 11;
            this.nAutoInvertTextMaxLinesThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(9, 243);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(145, 20);
            this.Label8.TabIndex = 10;
            this.Label8.Text = "Max lines thickness";
            // 
            // chkAutoTextInvertConnectedToLines
            // 
            this.chkAutoTextInvertConnectedToLines.AutoSize = true;
            this.chkAutoTextInvertConnectedToLines.Location = new System.Drawing.Point(14, 205);
            this.chkAutoTextInvertConnectedToLines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoTextInvertConnectedToLines.Name = "chkAutoTextInvertConnectedToLines";
            this.chkAutoTextInvertConnectedToLines.Size = new System.Drawing.Size(167, 24);
            this.chkAutoTextInvertConnectedToLines.TabIndex = 9;
            this.chkAutoTextInvertConnectedToLines.Text = "Connected to lines";
            this.chkAutoTextInvertConnectedToLines.UseVisualStyleBackColor = true;
            // 
            // chkAutoTextInvertFixBackground
            // 
            this.chkAutoTextInvertFixBackground.AutoSize = true;
            this.chkAutoTextInvertFixBackground.Location = new System.Drawing.Point(14, 169);
            this.chkAutoTextInvertFixBackground.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoTextInvertFixBackground.Name = "chkAutoTextInvertFixBackground";
            this.chkAutoTextInvertFixBackground.Size = new System.Drawing.Size(143, 24);
            this.chkAutoTextInvertFixBackground.TabIndex = 8;
            this.chkAutoTextInvertFixBackground.Text = "Fix background";
            this.chkAutoTextInvertFixBackground.UseVisualStyleBackColor = true;
            // 
            // nAutoInvertTextMaxBlackPercent
            // 
            this.nAutoInvertTextMaxBlackPercent.Location = new System.Drawing.Point(156, 129);
            this.nAutoInvertTextMaxBlackPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nAutoInvertTextMaxBlackPercent.Name = "nAutoInvertTextMaxBlackPercent";
            this.nAutoInvertTextMaxBlackPercent.Size = new System.Drawing.Size(98, 26);
            this.nAutoInvertTextMaxBlackPercent.TabIndex = 7;
            this.nAutoInvertTextMaxBlackPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 132);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(137, 20);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Max black percent";
            // 
            // nAutoInvertTextMinBlackPercent
            // 
            this.nAutoInvertTextMinBlackPercent.Location = new System.Drawing.Point(156, 89);
            this.nAutoInvertTextMinBlackPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nAutoInvertTextMinBlackPercent.Name = "nAutoInvertTextMinBlackPercent";
            this.nAutoInvertTextMinBlackPercent.Size = new System.Drawing.Size(98, 26);
            this.nAutoInvertTextMinBlackPercent.TabIndex = 5;
            this.nAutoInvertTextMinBlackPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 92);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(133, 20);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Min black percent";
            // 
            // nAutoInvertTextMinObjectHeight
            // 
            this.nAutoInvertTextMinObjectHeight.Location = new System.Drawing.Point(156, 49);
            this.nAutoInvertTextMinObjectHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nAutoInvertTextMinObjectHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nAutoInvertTextMinObjectHeight.Name = "nAutoInvertTextMinObjectHeight";
            this.nAutoInvertTextMinObjectHeight.Size = new System.Drawing.Size(98, 26);
            this.nAutoInvertTextMinObjectHeight.TabIndex = 3;
            this.nAutoInvertTextMinObjectHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 52);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(129, 20);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Min object height";
            // 
            // nAutoInvertTextMinObjectWidth
            // 
            this.nAutoInvertTextMinObjectWidth.Location = new System.Drawing.Point(156, 9);
            this.nAutoInvertTextMinObjectWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nAutoInvertTextMinObjectWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nAutoInvertTextMinObjectWidth.Name = "nAutoInvertTextMinObjectWidth";
            this.nAutoInvertTextMinObjectWidth.Size = new System.Drawing.Size(98, 26);
            this.nAutoInvertTextMinObjectWidth.TabIndex = 1;
            this.nAutoInvertTextMinObjectWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 12);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(122, 20);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Min object width";
            // 
            // tpCropBlackBorders
            // 
            this.tpCropBlackBorders.Controls.Add(this.nCropBlackBordersSkipLinesCount);
            this.tpCropBlackBorders.Controls.Add(this.Label10);
            this.tpCropBlackBorders.Controls.Add(this.nCropBlackBordersConfidence);
            this.tpCropBlackBorders.Controls.Add(this.Label9);
            this.tpCropBlackBorders.Location = new System.Drawing.Point(4, 204);
            this.tpCropBlackBorders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpCropBlackBorders.Name = "tpCropBlackBorders";
            this.tpCropBlackBorders.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpCropBlackBorders.Size = new System.Drawing.Size(296, 386);
            this.tpCropBlackBorders.TabIndex = 2;
            this.tpCropBlackBorders.Text = "Crop black borders";
            this.tpCropBlackBorders.UseVisualStyleBackColor = true;
            // 
            // nCropBlackBordersSkipLinesCount
            // 
            this.nCropBlackBordersSkipLinesCount.Location = new System.Drawing.Point(141, 49);
            this.nCropBlackBordersSkipLinesCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nCropBlackBordersSkipLinesCount.Name = "nCropBlackBordersSkipLinesCount";
            this.nCropBlackBordersSkipLinesCount.Size = new System.Drawing.Size(78, 26);
            this.nCropBlackBordersSkipLinesCount.TabIndex = 5;
            this.nCropBlackBordersSkipLinesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(9, 52);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(120, 20);
            this.Label10.TabIndex = 4;
            this.Label10.Text = "Skip lines count";
            // 
            // nCropBlackBordersConfidence
            // 
            this.nCropBlackBordersConfidence.DecimalPlaces = 2;
            this.nCropBlackBordersConfidence.Location = new System.Drawing.Point(141, 9);
            this.nCropBlackBordersConfidence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nCropBlackBordersConfidence.Name = "nCropBlackBordersConfidence";
            this.nCropBlackBordersConfidence.Size = new System.Drawing.Size(78, 26);
            this.nCropBlackBordersConfidence.TabIndex = 3;
            this.nCropBlackBordersConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(9, 12);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(90, 20);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "Confidence";
            // 
            // tpCropBorders
            // 
            this.tpCropBorders.Controls.Add(this.Label38);
            this.tpCropBorders.Controls.Add(this.cbCropBordersImageContext);
            this.tpCropBorders.Controls.Add(this.Label17);
            this.tpCropBorders.Controls.Add(this.nCropBordersHeight);
            this.tpCropBorders.Controls.Add(this.Label16);
            this.tpCropBorders.Controls.Add(this.nCropBordersWidth);
            this.tpCropBorders.Controls.Add(this.Label15);
            this.tpCropBorders.Controls.Add(this.nCropBordersTop);
            this.tpCropBorders.Controls.Add(this.Label14);
            this.tpCropBorders.Controls.Add(this.nCropBordersLeft);
            this.tpCropBorders.Controls.Add(this.Label13);
            this.tpCropBorders.Controls.Add(this.cbCropBordersReferencePoint);
            this.tpCropBorders.Controls.Add(this.Label12);
            this.tpCropBorders.Controls.Add(this.nCropBordersConfidence);
            this.tpCropBorders.Controls.Add(this.Label11);
            this.tpCropBorders.Location = new System.Drawing.Point(4, 204);
            this.tpCropBorders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpCropBorders.Name = "tpCropBorders";
            this.tpCropBorders.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpCropBorders.Size = new System.Drawing.Size(296, 386);
            this.tpCropBorders.TabIndex = 3;
            this.tpCropBorders.Text = "Crop borders";
            this.tpCropBorders.UseVisualStyleBackColor = true;
            // 
            // cbCropBordersImageContext
            // 
            this.cbCropBordersImageContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCropBordersImageContext.Enabled = false;
            this.cbCropBordersImageContext.FormattingEnabled = true;
            this.cbCropBordersImageContext.Location = new System.Drawing.Point(142, 251);
            this.cbCropBordersImageContext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCropBordersImageContext.Name = "cbCropBordersImageContext";
            this.cbCropBordersImageContext.Size = new System.Drawing.Size(180, 28);
            this.cbCropBordersImageContext.TabIndex = 17;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(9, 255);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(110, 20);
            this.Label17.TabIndex = 16;
            this.Label17.Text = "Image context";
            // 
            // nCropBordersHeight
            // 
            this.nCropBordersHeight.Enabled = false;
            this.nCropBordersHeight.Location = new System.Drawing.Point(142, 211);
            this.nCropBordersHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nCropBordersHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCropBordersHeight.Name = "nCropBordersHeight";
            this.nCropBordersHeight.Size = new System.Drawing.Size(98, 26);
            this.nCropBordersHeight.TabIndex = 15;
            this.nCropBordersHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(9, 214);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(56, 20);
            this.Label16.TabIndex = 14;
            this.Label16.Text = "Height";
            // 
            // nCropBordersWidth
            // 
            this.nCropBordersWidth.Enabled = false;
            this.nCropBordersWidth.Location = new System.Drawing.Point(142, 171);
            this.nCropBordersWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nCropBordersWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCropBordersWidth.Name = "nCropBordersWidth";
            this.nCropBordersWidth.Size = new System.Drawing.Size(98, 26);
            this.nCropBordersWidth.TabIndex = 13;
            this.nCropBordersWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(9, 174);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(50, 20);
            this.Label15.TabIndex = 12;
            this.Label15.Text = "Width";
            // 
            // nCropBordersTop
            // 
            this.nCropBordersTop.Enabled = false;
            this.nCropBordersTop.Location = new System.Drawing.Point(142, 131);
            this.nCropBordersTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nCropBordersTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCropBordersTop.Name = "nCropBordersTop";
            this.nCropBordersTop.Size = new System.Drawing.Size(98, 26);
            this.nCropBordersTop.TabIndex = 11;
            this.nCropBordersTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(9, 134);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(36, 20);
            this.Label14.TabIndex = 10;
            this.Label14.Text = "Top";
            // 
            // nCropBordersLeft
            // 
            this.nCropBordersLeft.Enabled = false;
            this.nCropBordersLeft.Location = new System.Drawing.Point(142, 91);
            this.nCropBordersLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nCropBordersLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCropBordersLeft.Name = "nCropBordersLeft";
            this.nCropBordersLeft.Size = new System.Drawing.Size(98, 26);
            this.nCropBordersLeft.TabIndex = 9;
            this.nCropBordersLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(9, 94);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(37, 20);
            this.Label13.TabIndex = 8;
            this.Label13.Text = "Left";
            // 
            // cbCropBordersReferencePoint
            // 
            this.cbCropBordersReferencePoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCropBordersReferencePoint.FormattingEnabled = true;
            this.cbCropBordersReferencePoint.Location = new System.Drawing.Point(142, 49);
            this.cbCropBordersReferencePoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCropBordersReferencePoint.Name = "cbCropBordersReferencePoint";
            this.cbCropBordersReferencePoint.Size = new System.Drawing.Size(180, 28);
            this.cbCropBordersReferencePoint.TabIndex = 7;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(9, 54);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(123, 20);
            this.Label12.TabIndex = 6;
            this.Label12.Text = "Reference point";
            // 
            // nCropBordersConfidence
            // 
            this.nCropBordersConfidence.DecimalPlaces = 2;
            this.nCropBordersConfidence.Location = new System.Drawing.Point(142, 9);
            this.nCropBordersConfidence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nCropBordersConfidence.Name = "nCropBordersConfidence";
            this.nCropBordersConfidence.Size = new System.Drawing.Size(78, 26);
            this.nCropBordersConfidence.TabIndex = 5;
            this.nCropBordersConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(9, 12);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(90, 20);
            this.Label11.TabIndex = 4;
            this.Label11.Text = "Confidence";
            // 
            // tpDeleteBlackBorders
            // 
            this.tpDeleteBlackBorders.Controls.Add(this.chkDeleteBlackBordersEffectSkewedBorders);
            this.tpDeleteBlackBorders.Controls.Add(this.nDeleteBlackBorderEffectMargin);
            this.tpDeleteBlackBorders.Controls.Add(this.Label18);
            this.tpDeleteBlackBorders.Location = new System.Drawing.Point(4, 204);
            this.tpDeleteBlackBorders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpDeleteBlackBorders.Name = "tpDeleteBlackBorders";
            this.tpDeleteBlackBorders.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpDeleteBlackBorders.Size = new System.Drawing.Size(296, 386);
            this.tpDeleteBlackBorders.TabIndex = 4;
            this.tpDeleteBlackBorders.Text = "Delete black borders";
            this.tpDeleteBlackBorders.UseVisualStyleBackColor = true;
            // 
            // chkDeleteBlackBordersEffectSkewedBorders
            // 
            this.chkDeleteBlackBordersEffectSkewedBorders.AutoSize = true;
            this.chkDeleteBlackBordersEffectSkewedBorders.Location = new System.Drawing.Point(14, 49);
            this.chkDeleteBlackBordersEffectSkewedBorders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDeleteBlackBordersEffectSkewedBorders.Name = "chkDeleteBlackBordersEffectSkewedBorders";
            this.chkDeleteBlackBordersEffectSkewedBorders.Size = new System.Drawing.Size(150, 24);
            this.chkDeleteBlackBordersEffectSkewedBorders.TabIndex = 11;
            this.chkDeleteBlackBordersEffectSkewedBorders.Text = "Skewed borders";
            this.chkDeleteBlackBordersEffectSkewedBorders.UseVisualStyleBackColor = true;
            // 
            // nDeleteBlackBorderEffectMargin
            // 
            this.nDeleteBlackBorderEffectMargin.Location = new System.Drawing.Point(76, 9);
            this.nDeleteBlackBorderEffectMargin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nDeleteBlackBorderEffectMargin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nDeleteBlackBorderEffectMargin.Name = "nDeleteBlackBorderEffectMargin";
            this.nDeleteBlackBorderEffectMargin.Size = new System.Drawing.Size(98, 26);
            this.nDeleteBlackBorderEffectMargin.TabIndex = 10;
            this.nDeleteBlackBorderEffectMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(9, 12);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(57, 20);
            this.Label18.TabIndex = 1;
            this.Label18.Text = "Margin";
            // 
            // tpMedian
            // 
            this.tpMedian.Controls.Add(this.nMedianEffectKernelSize);
            this.tpMedian.Controls.Add(this.Label19);
            this.tpMedian.Location = new System.Drawing.Point(4, 204);
            this.tpMedian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpMedian.Name = "tpMedian";
            this.tpMedian.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpMedian.Size = new System.Drawing.Size(296, 386);
            this.tpMedian.TabIndex = 5;
            this.tpMedian.Text = "Median";
            this.tpMedian.UseVisualStyleBackColor = true;
            // 
            // nMedianEffectKernelSize
            // 
            this.nMedianEffectKernelSize.Location = new System.Drawing.Point(104, 9);
            this.nMedianEffectKernelSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nMedianEffectKernelSize.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nMedianEffectKernelSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMedianEffectKernelSize.Name = "nMedianEffectKernelSize";
            this.nMedianEffectKernelSize.Size = new System.Drawing.Size(98, 26);
            this.nMedianEffectKernelSize.TabIndex = 12;
            this.nMedianEffectKernelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nMedianEffectKernelSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(9, 12);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(86, 20);
            this.Label19.TabIndex = 11;
            this.Label19.Text = "Kernel size";
            // 
            // tpRemoveBlob
            // 
            this.tpRemoveBlob.Controls.Add(this.nRemoveBlobEffectMaxFillPercent);
            this.tpRemoveBlob.Controls.Add(this.Label25);
            this.tpRemoveBlob.Controls.Add(this.nRemoveBlobEffectMinFillPercent);
            this.tpRemoveBlob.Controls.Add(this.Label24);
            this.tpRemoveBlob.Controls.Add(this.nRemoveBlobEffectMaxBlobHeight);
            this.tpRemoveBlob.Controls.Add(this.Label23);
            this.tpRemoveBlob.Controls.Add(this.nRemoveBlobEffectMaxBlobWidth);
            this.tpRemoveBlob.Controls.Add(this.Label22);
            this.tpRemoveBlob.Controls.Add(this.nRemoveBlobEffectMinBlobHeight);
            this.tpRemoveBlob.Controls.Add(this.Label21);
            this.tpRemoveBlob.Controls.Add(this.nRemoveBlobEffectMinBlobWidth);
            this.tpRemoveBlob.Controls.Add(this.Label20);
            this.tpRemoveBlob.Location = new System.Drawing.Point(4, 204);
            this.tpRemoveBlob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpRemoveBlob.Name = "tpRemoveBlob";
            this.tpRemoveBlob.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpRemoveBlob.Size = new System.Drawing.Size(296, 386);
            this.tpRemoveBlob.TabIndex = 6;
            this.tpRemoveBlob.Text = "Remove blob";
            this.tpRemoveBlob.UseVisualStyleBackColor = true;
            // 
            // nRemoveBlobEffectMaxFillPercent
            // 
            this.nRemoveBlobEffectMaxFillPercent.Location = new System.Drawing.Point(130, 209);
            this.nRemoveBlobEffectMaxFillPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveBlobEffectMaxFillPercent.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nRemoveBlobEffectMaxFillPercent.Name = "nRemoveBlobEffectMaxFillPercent";
            this.nRemoveBlobEffectMaxFillPercent.Size = new System.Drawing.Size(98, 26);
            this.nRemoveBlobEffectMaxFillPercent.TabIndex = 21;
            this.nRemoveBlobEffectMaxFillPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nRemoveBlobEffectMaxFillPercent.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(9, 212);
            this.Label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(114, 20);
            this.Label25.TabIndex = 20;
            this.Label25.Text = "Max fill percent";
            // 
            // nRemoveBlobEffectMinFillPercent
            // 
            this.nRemoveBlobEffectMinFillPercent.Location = new System.Drawing.Point(130, 169);
            this.nRemoveBlobEffectMinFillPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveBlobEffectMinFillPercent.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nRemoveBlobEffectMinFillPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRemoveBlobEffectMinFillPercent.Name = "nRemoveBlobEffectMinFillPercent";
            this.nRemoveBlobEffectMinFillPercent.Size = new System.Drawing.Size(98, 26);
            this.nRemoveBlobEffectMinFillPercent.TabIndex = 19;
            this.nRemoveBlobEffectMinFillPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nRemoveBlobEffectMinFillPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(9, 172);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(110, 20);
            this.Label24.TabIndex = 18;
            this.Label24.Text = "Min fill percent";
            // 
            // nRemoveBlobEffectMaxBlobHeight
            // 
            this.nRemoveBlobEffectMaxBlobHeight.Location = new System.Drawing.Point(130, 129);
            this.nRemoveBlobEffectMaxBlobHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveBlobEffectMaxBlobHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRemoveBlobEffectMaxBlobHeight.Name = "nRemoveBlobEffectMaxBlobHeight";
            this.nRemoveBlobEffectMaxBlobHeight.Size = new System.Drawing.Size(98, 26);
            this.nRemoveBlobEffectMaxBlobHeight.TabIndex = 17;
            this.nRemoveBlobEffectMaxBlobHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(9, 132);
            this.Label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(120, 20);
            this.Label23.TabIndex = 16;
            this.Label23.Text = "Max blob height";
            // 
            // nRemoveBlobEffectMaxBlobWidth
            // 
            this.nRemoveBlobEffectMaxBlobWidth.Location = new System.Drawing.Point(130, 89);
            this.nRemoveBlobEffectMaxBlobWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveBlobEffectMaxBlobWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRemoveBlobEffectMaxBlobWidth.Name = "nRemoveBlobEffectMaxBlobWidth";
            this.nRemoveBlobEffectMaxBlobWidth.Size = new System.Drawing.Size(98, 26);
            this.nRemoveBlobEffectMaxBlobWidth.TabIndex = 15;
            this.nRemoveBlobEffectMaxBlobWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(9, 92);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(113, 20);
            this.Label22.TabIndex = 14;
            this.Label22.Text = "Max blob width";
            // 
            // nRemoveBlobEffectMinBlobHeight
            // 
            this.nRemoveBlobEffectMinBlobHeight.Location = new System.Drawing.Point(130, 49);
            this.nRemoveBlobEffectMinBlobHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveBlobEffectMinBlobHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRemoveBlobEffectMinBlobHeight.Name = "nRemoveBlobEffectMinBlobHeight";
            this.nRemoveBlobEffectMinBlobHeight.Size = new System.Drawing.Size(98, 26);
            this.nRemoveBlobEffectMinBlobHeight.TabIndex = 13;
            this.nRemoveBlobEffectMinBlobHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(9, 52);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(116, 20);
            this.Label21.TabIndex = 12;
            this.Label21.Text = "Min blob height";
            // 
            // nRemoveBlobEffectMinBlobWidth
            // 
            this.nRemoveBlobEffectMinBlobWidth.Location = new System.Drawing.Point(130, 9);
            this.nRemoveBlobEffectMinBlobWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveBlobEffectMinBlobWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRemoveBlobEffectMinBlobWidth.Name = "nRemoveBlobEffectMinBlobWidth";
            this.nRemoveBlobEffectMinBlobWidth.Size = new System.Drawing.Size(98, 26);
            this.nRemoveBlobEffectMinBlobWidth.TabIndex = 11;
            this.nRemoveBlobEffectMinBlobWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(9, 12);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(109, 20);
            this.Label20.TabIndex = 10;
            this.Label20.Text = "Min blob width";
            // 
            // tpRemoveLines
            // 
            this.tpRemoveLines.Controls.Add(this.chkRemoveLinesEffectReconnectBrokenCharacters);
            this.tpRemoveLines.Controls.Add(this.nRemoveLinesEffectMaxInterception);
            this.tpRemoveLines.Controls.Add(this.Label30);
            this.tpRemoveLines.Controls.Add(this.nRemoveLinesEffectMinLineLength);
            this.tpRemoveLines.Controls.Add(this.Label29);
            this.tpRemoveLines.Controls.Add(this.nRemoveLinesEffectMaxLineThickness);
            this.tpRemoveLines.Controls.Add(this.Label28);
            this.tpRemoveLines.Controls.Add(this.nRemoveLinesEffectMaxLineGap);
            this.tpRemoveLines.Controls.Add(this.Label27);
            this.tpRemoveLines.Controls.Add(this.cbRemoveLinesEffectOrientation);
            this.tpRemoveLines.Controls.Add(this.Label26);
            this.tpRemoveLines.Location = new System.Drawing.Point(4, 204);
            this.tpRemoveLines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpRemoveLines.Name = "tpRemoveLines";
            this.tpRemoveLines.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpRemoveLines.Size = new System.Drawing.Size(296, 386);
            this.tpRemoveLines.TabIndex = 7;
            this.tpRemoveLines.Text = "Remove lines";
            this.tpRemoveLines.UseVisualStyleBackColor = true;
            // 
            // chkRemoveLinesEffectReconnectBrokenCharacters
            // 
            this.chkRemoveLinesEffectReconnectBrokenCharacters.AutoSize = true;
            this.chkRemoveLinesEffectReconnectBrokenCharacters.Location = new System.Drawing.Point(14, 211);
            this.chkRemoveLinesEffectReconnectBrokenCharacters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRemoveLinesEffectReconnectBrokenCharacters.Name = "chkRemoveLinesEffectReconnectBrokenCharacters";
            this.chkRemoveLinesEffectReconnectBrokenCharacters.Size = new System.Drawing.Size(245, 24);
            this.chkRemoveLinesEffectReconnectBrokenCharacters.TabIndex = 20;
            this.chkRemoveLinesEffectReconnectBrokenCharacters.Text = "Reconnect broken characters";
            this.chkRemoveLinesEffectReconnectBrokenCharacters.UseVisualStyleBackColor = true;
            // 
            // nRemoveLinesEffectMaxInterception
            // 
            this.nRemoveLinesEffectMaxInterception.Location = new System.Drawing.Point(165, 171);
            this.nRemoveLinesEffectMaxInterception.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveLinesEffectMaxInterception.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRemoveLinesEffectMaxInterception.Name = "nRemoveLinesEffectMaxInterception";
            this.nRemoveLinesEffectMaxInterception.Size = new System.Drawing.Size(98, 26);
            this.nRemoveLinesEffectMaxInterception.TabIndex = 19;
            this.nRemoveLinesEffectMaxInterception.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nRemoveLinesEffectMaxInterception.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(8, 174);
            this.Label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(125, 20);
            this.Label30.TabIndex = 18;
            this.Label30.Text = "Max interception";
            // 
            // nRemoveLinesEffectMinLineLength
            // 
            this.nRemoveLinesEffectMinLineLength.Location = new System.Drawing.Point(166, 131);
            this.nRemoveLinesEffectMinLineLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveLinesEffectMinLineLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRemoveLinesEffectMinLineLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRemoveLinesEffectMinLineLength.Name = "nRemoveLinesEffectMinLineLength";
            this.nRemoveLinesEffectMinLineLength.Size = new System.Drawing.Size(98, 26);
            this.nRemoveLinesEffectMinLineLength.TabIndex = 17;
            this.nRemoveLinesEffectMinLineLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nRemoveLinesEffectMinLineLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(9, 134);
            this.Label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(110, 20);
            this.Label29.TabIndex = 16;
            this.Label29.Text = "Min line length";
            // 
            // nRemoveLinesEffectMaxLineThickness
            // 
            this.nRemoveLinesEffectMaxLineThickness.Location = new System.Drawing.Point(166, 91);
            this.nRemoveLinesEffectMaxLineThickness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveLinesEffectMaxLineThickness.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nRemoveLinesEffectMaxLineThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nRemoveLinesEffectMaxLineThickness.Name = "nRemoveLinesEffectMaxLineThickness";
            this.nRemoveLinesEffectMaxLineThickness.Size = new System.Drawing.Size(98, 26);
            this.nRemoveLinesEffectMaxLineThickness.TabIndex = 15;
            this.nRemoveLinesEffectMaxLineThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(9, 94);
            this.Label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(145, 20);
            this.Label28.TabIndex = 14;
            this.Label28.Text = "Max line thicknesss";
            // 
            // nRemoveLinesEffectMaxLineGap
            // 
            this.nRemoveLinesEffectMaxLineGap.Location = new System.Drawing.Point(166, 51);
            this.nRemoveLinesEffectMaxLineGap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRemoveLinesEffectMaxLineGap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nRemoveLinesEffectMaxLineGap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nRemoveLinesEffectMaxLineGap.Name = "nRemoveLinesEffectMaxLineGap";
            this.nRemoveLinesEffectMaxLineGap.Size = new System.Drawing.Size(98, 26);
            this.nRemoveLinesEffectMaxLineGap.TabIndex = 13;
            this.nRemoveLinesEffectMaxLineGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(9, 54);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(97, 20);
            this.Label27.TabIndex = 12;
            this.Label27.Text = "Max line gap";
            // 
            // cbRemoveLinesEffectOrientation
            // 
            this.cbRemoveLinesEffectOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemoveLinesEffectOrientation.FormattingEnabled = true;
            this.cbRemoveLinesEffectOrientation.Location = new System.Drawing.Point(166, 9);
            this.cbRemoveLinesEffectOrientation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRemoveLinesEffectOrientation.Name = "cbRemoveLinesEffectOrientation";
            this.cbRemoveLinesEffectOrientation.Size = new System.Drawing.Size(180, 28);
            this.cbRemoveLinesEffectOrientation.TabIndex = 9;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(9, 14);
            this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(87, 20);
            this.Label26.TabIndex = 8;
            this.Label26.Text = "Orientation";
            // 
            // tpBitonalDespeckle
            // 
            this.tpBitonalDespeckle.Controls.Add(this.chkBitonalDespeckleEffectFixText);
            this.tpBitonalDespeckle.Location = new System.Drawing.Point(4, 204);
            this.tpBitonalDespeckle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBitonalDespeckle.Name = "tpBitonalDespeckle";
            this.tpBitonalDespeckle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBitonalDespeckle.Size = new System.Drawing.Size(296, 386);
            this.tpBitonalDespeckle.TabIndex = 8;
            this.tpBitonalDespeckle.Text = "Bitonal despeckle";
            this.tpBitonalDespeckle.UseVisualStyleBackColor = true;
            // 
            // chkBitonalDespeckleEffectFixText
            // 
            this.chkBitonalDespeckleEffectFixText.AutoSize = true;
            this.chkBitonalDespeckleEffectFixText.Location = new System.Drawing.Point(9, 9);
            this.chkBitonalDespeckleEffectFixText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBitonalDespeckleEffectFixText.Name = "chkBitonalDespeckleEffectFixText";
            this.chkBitonalDespeckleEffectFixText.Size = new System.Drawing.Size(85, 24);
            this.chkBitonalDespeckleEffectFixText.TabIndex = 0;
            this.chkBitonalDespeckleEffectFixText.Text = "Fix text";
            this.chkBitonalDespeckleEffectFixText.UseVisualStyleBackColor = true;
            // 
            // tpBitonalSkeletonize
            // 
            this.tpBitonalSkeletonize.Controls.Add(this.nBitonalSkeletonizeEffectRepetition);
            this.tpBitonalSkeletonize.Controls.Add(this.Label31);
            this.tpBitonalSkeletonize.Location = new System.Drawing.Point(4, 204);
            this.tpBitonalSkeletonize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBitonalSkeletonize.Name = "tpBitonalSkeletonize";
            this.tpBitonalSkeletonize.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBitonalSkeletonize.Size = new System.Drawing.Size(296, 386);
            this.tpBitonalSkeletonize.TabIndex = 9;
            this.tpBitonalSkeletonize.Text = "Bitonal skeletonize";
            this.tpBitonalSkeletonize.UseVisualStyleBackColor = true;
            // 
            // nBitonalSkeletonizeEffectRepetition
            // 
            this.nBitonalSkeletonizeEffectRepetition.Location = new System.Drawing.Point(100, 9);
            this.nBitonalSkeletonizeEffectRepetition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nBitonalSkeletonizeEffectRepetition.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nBitonalSkeletonizeEffectRepetition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nBitonalSkeletonizeEffectRepetition.Name = "nBitonalSkeletonizeEffectRepetition";
            this.nBitonalSkeletonizeEffectRepetition.Size = new System.Drawing.Size(98, 26);
            this.nBitonalSkeletonizeEffectRepetition.TabIndex = 17;
            this.nBitonalSkeletonizeEffectRepetition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(9, 12);
            this.Label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(82, 20);
            this.Label31.TabIndex = 16;
            this.Label31.Text = "Repetition";
            // 
            // tpBitonalVigorousDespeckle
            // 
            this.tpBitonalVigorousDespeckle.Controls.Add(this.chkBitonalVigorousDespeckleEffectCheckForDotOfI);
            this.tpBitonalVigorousDespeckle.Location = new System.Drawing.Point(4, 204);
            this.tpBitonalVigorousDespeckle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBitonalVigorousDespeckle.Name = "tpBitonalVigorousDespeckle";
            this.tpBitonalVigorousDespeckle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBitonalVigorousDespeckle.Size = new System.Drawing.Size(296, 386);
            this.tpBitonalVigorousDespeckle.TabIndex = 10;
            this.tpBitonalVigorousDespeckle.Text = "Bitonal Vigorous despeckle";
            this.tpBitonalVigorousDespeckle.UseVisualStyleBackColor = true;
            // 
            // chkBitonalVigorousDespeckleEffectCheckForDotOfI
            // 
            this.chkBitonalVigorousDespeckleEffectCheckForDotOfI.AutoSize = true;
            this.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Location = new System.Drawing.Point(9, 9);
            this.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Name = "chkBitonalVigorousDespeckleEffectCheckForDotOfI";
            this.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Size = new System.Drawing.Size(236, 24);
            this.chkBitonalVigorousDespeckleEffectCheckForDotOfI.TabIndex = 1;
            this.chkBitonalVigorousDespeckleEffectCheckForDotOfI.Text = "Detect dots of I and J letters";
            this.chkBitonalVigorousDespeckleEffectCheckForDotOfI.UseVisualStyleBackColor = true;
            // 
            // tpBitonalDilate
            // 
            this.tpBitonalDilate.Controls.Add(this.nBitonalDilateEffectKernelSize);
            this.tpBitonalDilate.Controls.Add(this.Label32);
            this.tpBitonalDilate.Location = new System.Drawing.Point(4, 204);
            this.tpBitonalDilate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBitonalDilate.Name = "tpBitonalDilate";
            this.tpBitonalDilate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBitonalDilate.Size = new System.Drawing.Size(296, 386);
            this.tpBitonalDilate.TabIndex = 11;
            this.tpBitonalDilate.Text = "Bitonal dliate";
            this.tpBitonalDilate.UseVisualStyleBackColor = true;
            // 
            // nBitonalDilateEffectKernelSize
            // 
            this.nBitonalDilateEffectKernelSize.Location = new System.Drawing.Point(104, 9);
            this.nBitonalDilateEffectKernelSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nBitonalDilateEffectKernelSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nBitonalDilateEffectKernelSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nBitonalDilateEffectKernelSize.Name = "nBitonalDilateEffectKernelSize";
            this.nBitonalDilateEffectKernelSize.Size = new System.Drawing.Size(98, 26);
            this.nBitonalDilateEffectKernelSize.TabIndex = 14;
            this.nBitonalDilateEffectKernelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nBitonalDilateEffectKernelSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Location = new System.Drawing.Point(9, 12);
            this.Label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(86, 20);
            this.Label32.TabIndex = 13;
            this.Label32.Text = "Kernel size";
            // 
            // tpRemoveHolePunch
            // 
            this.tpRemoveHolePunch.Controls.Add(this.Label35);
            this.tpRemoveHolePunch.Controls.Add(this.cbRemoveHolePunchEffectMargins);
            this.tpRemoveHolePunch.Location = new System.Drawing.Point(4, 204);
            this.tpRemoveHolePunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpRemoveHolePunch.Name = "tpRemoveHolePunch";
            this.tpRemoveHolePunch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpRemoveHolePunch.Size = new System.Drawing.Size(296, 386);
            this.tpRemoveHolePunch.TabIndex = 12;
            this.tpRemoveHolePunch.Text = "Remove hole punch";
            this.tpRemoveHolePunch.UseVisualStyleBackColor = true;
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(9, 14);
            this.Label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(65, 20);
            this.Label35.TabIndex = 1;
            this.Label35.Text = "Margins";
            // 
            // cbRemoveHolePunchEffectMargins
            // 
            this.cbRemoveHolePunchEffectMargins.FormattingEnabled = true;
            this.cbRemoveHolePunchEffectMargins.Location = new System.Drawing.Point(76, 9);
            this.cbRemoveHolePunchEffectMargins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRemoveHolePunchEffectMargins.Name = "cbRemoveHolePunchEffectMargins";
            this.cbRemoveHolePunchEffectMargins.Size = new System.Drawing.Size(322, 28);
            this.cbRemoveHolePunchEffectMargins.TabIndex = 0;
            // 
            // tpDespeckleAdvanced
            // 
            this.tpDespeckleAdvanced.Controls.Add(this.Label37);
            this.tpDespeckleAdvanced.Controls.Add(this.Label36);
            this.tpDespeckleAdvanced.Controls.Add(this.nDespeckleStrength);
            this.tpDespeckleAdvanced.Controls.Add(this.cbDespeckleType);
            this.tpDespeckleAdvanced.Location = new System.Drawing.Point(4, 204);
            this.tpDespeckleAdvanced.Name = "tpDespeckleAdvanced";
            this.tpDespeckleAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tpDespeckleAdvanced.Size = new System.Drawing.Size(296, 386);
            this.tpDespeckleAdvanced.TabIndex = 13;
            this.tpDespeckleAdvanced.Text = "Despeckle";
            this.tpDespeckleAdvanced.UseVisualStyleBackColor = true;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(11, 20);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(49, 20);
            this.Label37.TabIndex = 7;
            this.Label37.Text = "Mode";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(11, 61);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(71, 20);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "Strength";
            // 
            // nDespeckleStrength
            // 
            this.nDespeckleStrength.Location = new System.Drawing.Point(299, 59);
            this.nDespeckleStrength.Name = "nDespeckleStrength";
            this.nDespeckleStrength.Size = new System.Drawing.Size(76, 26);
            this.nDespeckleStrength.TabIndex = 5;
            // 
            // cbDespeckleType
            // 
            this.cbDespeckleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDespeckleType.FormattingEnabled = true;
            this.cbDespeckleType.Location = new System.Drawing.Point(86, 17);
            this.cbDespeckleType.Name = "cbDespeckleType";
            this.cbDespeckleType.Size = new System.Drawing.Size(289, 28);
            this.cbDespeckleType.TabIndex = 4;
            // 
            // pDirectEffects
            // 
            this.pDirectEffects.AutoSize = true;
            this.pDirectEffects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pDirectEffects.Controls.Add(this.btnMoveEffectDown);
            this.pDirectEffects.Controls.Add(this.btnMoveEffectUp);
            this.pDirectEffects.Controls.Add(this.btnRemoveAllEffects);
            this.pDirectEffects.Controls.Add(this.btnRemoveEffect);
            this.pDirectEffects.Controls.Add(this.lstEffects);
            this.pDirectEffects.Controls.Add(this.btnAddEffect);
            this.pDirectEffects.Controls.Add(this.cbDocumentCleanUpEffects);
            this.pDirectEffects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDirectEffects.Location = new System.Drawing.Point(0, 0);
            this.pDirectEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pDirectEffects.Name = "pDirectEffects";
            this.pDirectEffects.Size = new System.Drawing.Size(304, 342);
            this.pDirectEffects.TabIndex = 4;
            // 
            // btnMoveEffectDown
            // 
            this.btnMoveEffectDown.Location = new System.Drawing.Point(39, 302);
            this.btnMoveEffectDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveEffectDown.Name = "btnMoveEffectDown";
            this.btnMoveEffectDown.Size = new System.Drawing.Size(84, 35);
            this.btnMoveEffectDown.TabIndex = 10;
            this.btnMoveEffectDown.Text = "Down";
            this.btnMoveEffectDown.UseVisualStyleBackColor = true;
            this.btnMoveEffectDown.Click += new System.EventHandler(this.btnMoveEffectDown_Click);
            // 
            // btnMoveEffectUp
            // 
            this.btnMoveEffectUp.Location = new System.Drawing.Point(132, 302);
            this.btnMoveEffectUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveEffectUp.Name = "btnMoveEffectUp";
            this.btnMoveEffectUp.Size = new System.Drawing.Size(84, 35);
            this.btnMoveEffectUp.TabIndex = 9;
            this.btnMoveEffectUp.Text = "Up";
            this.btnMoveEffectUp.UseVisualStyleBackColor = true;
            this.btnMoveEffectUp.Click += new System.EventHandler(this.btnMoveEffectUp_Click);
            // 
            // btnRemoveAllEffects
            // 
            this.btnRemoveAllEffects.Location = new System.Drawing.Point(346, 302);
            this.btnRemoveAllEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveAllEffects.Name = "btnRemoveAllEffects";
            this.btnRemoveAllEffects.Size = new System.Drawing.Size(112, 35);
            this.btnRemoveAllEffects.TabIndex = 8;
            this.btnRemoveAllEffects.Text = "Remove all";
            this.btnRemoveAllEffects.UseVisualStyleBackColor = true;
            this.btnRemoveAllEffects.Click += new System.EventHandler(this.btnRemoveAllEffects_Click);
            // 
            // btnRemoveEffect
            // 
            this.btnRemoveEffect.Location = new System.Drawing.Point(225, 302);
            this.btnRemoveEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveEffect.Name = "btnRemoveEffect";
            this.btnRemoveEffect.Size = new System.Drawing.Size(112, 35);
            this.btnRemoveEffect.TabIndex = 7;
            this.btnRemoveEffect.Text = "Remove";
            this.btnRemoveEffect.UseVisualStyleBackColor = true;
            this.btnRemoveEffect.Click += new System.EventHandler(this.btnRemoveEffect_Click);
            // 
            // lstEffects
            // 
            this.lstEffects.FormattingEnabled = true;
            this.lstEffects.ItemHeight = 20;
            this.lstEffects.Location = new System.Drawing.Point(4, 46);
            this.lstEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEffects.Name = "lstEffects";
            this.lstEffects.Size = new System.Drawing.Size(452, 244);
            this.lstEffects.TabIndex = 6;
            this.lstEffects.SelectedIndexChanged += new System.EventHandler(this.lstEffects_SelectedIndexChanged);
            // 
            // btnAddEffect
            // 
            this.btnAddEffect.Location = new System.Drawing.Point(346, 3);
            this.btnAddEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddEffect.Name = "btnAddEffect";
            this.btnAddEffect.Size = new System.Drawing.Size(112, 35);
            this.btnAddEffect.TabIndex = 3;
            this.btnAddEffect.Text = "Add to list";
            this.btnAddEffect.UseVisualStyleBackColor = true;
            this.btnAddEffect.Click += new System.EventHandler(this.btnAddEffect_Click);
            // 
            // cbDocumentCleanUpEffects
            // 
            this.cbDocumentCleanUpEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentCleanUpEffects.FormattingEnabled = true;
            this.cbDocumentCleanUpEffects.Location = new System.Drawing.Point(4, 5);
            this.cbDocumentCleanUpEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDocumentCleanUpEffects.Name = "cbDocumentCleanUpEffects";
            this.cbDocumentCleanUpEffects.Size = new System.Drawing.Size(332, 28);
            this.cbDocumentCleanUpEffects.TabIndex = 2;
            // 
            // Panel1
            // 
            this.Panel1.AutoSize = true;
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.Controls.Add(this.btnApplyEffects);
            this.Panel1.Controls.Add(this.btnResetEffects);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 936);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(304, 45);
            this.Panel1.TabIndex = 5;
            // 
            // btnApplyEffects
            // 
            this.btnApplyEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyEffects.Location = new System.Drawing.Point(187, 5);
            this.btnApplyEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyEffects.Name = "btnApplyEffects";
            this.btnApplyEffects.Size = new System.Drawing.Size(112, 35);
            this.btnApplyEffects.TabIndex = 0;
            this.btnApplyEffects.Text = "Apply";
            this.btnApplyEffects.UseVisualStyleBackColor = true;
            this.btnApplyEffects.Click += new System.EventHandler(this.btnApplyEffects_Click);
            // 
            // btnResetEffects
            // 
            this.btnResetEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetEffects.Location = new System.Drawing.Point(66, 5);
            this.btnResetEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetEffects.Name = "btnResetEffects";
            this.btnResetEffects.Size = new System.Drawing.Size(112, 35);
            this.btnResetEffects.TabIndex = 1;
            this.btnResetEffects.Text = "Reset";
            this.btnResetEffects.UseVisualStyleBackColor = true;
            this.btnResetEffects.Click += new System.EventHandler(this.btnResetEffects_Click);
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
            this.scMain.Panel2.Controls.Add(this.SplitContainer1);
            this.scMain.Panel2MinSize = 200;
            this.scMain.Size = new System.Drawing.Size(1896, 1065);
            this.scMain.SplitterDistance = 362;
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
            this.Panel6.Size = new System.Drawing.Size(360, 1063);
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
            this.Panel9.Size = new System.Drawing.Size(312, 1063);
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
            this.Panel7.Size = new System.Drawing.Size(312, 49);
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
            this.pSnapInButtons.Controls.Add(this.btnSnapInDocumentCleanUp);
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
            // btnSnapInDocumentCleanUp
            // 
            this.btnSnapInDocumentCleanUp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInDocumentCleanUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInDocumentCleanUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInDocumentCleanUp.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInDocumentCleanUp.Image")));
            this.btnSnapInDocumentCleanUp.Location = new System.Drawing.Point(0, 48);
            this.btnSnapInDocumentCleanUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInDocumentCleanUp.Name = "btnSnapInDocumentCleanUp";
            this.btnSnapInDocumentCleanUp.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInDocumentCleanUp.TabIndex = 1;
            this.btnSnapInDocumentCleanUp.UseVisualStyleBackColor = false;
            this.btnSnapInDocumentCleanUp.Click += new System.EventHandler(this.btnSnapInDocumentCleanUp_Click);
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.IsSplitterFixed = true;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.Panel2);
            this.SplitContainer1.Panel1.Controls.Add(this.Panel3);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.Panel5);
            this.SplitContainer1.Panel2.Controls.Add(this.Panel4);
            this.SplitContainer1.Size = new System.Drawing.Size(1526, 1063);
            this.SplitContainer1.SplitterDistance = 800;
            this.SplitContainer1.SplitterWidth = 6;
            this.SplitContainer1.TabIndex = 1;
            this.SplitContainer1.Resize += new System.EventHandler(this.SplitContainer1_Resize);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.GdViewer1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 49);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(800, 1014);
            this.Panel2.TabIndex = 1;
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDropFile = false;
            this.GdViewer1.AnimateGIF = true;
            this.GdViewer1.AnnotationDropShadow = true;
            this.GdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.GdViewer1.AnnotationResizeRotateHandlesScale = 1F;
            this.GdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GdViewer1.BackgroundImage = null;
            this.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GdViewer1.ContinuousViewMode = false;
            this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityAutomatic;
            this.GdViewer1.DisplayQualityAuto = true;
            this.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer1.EnableDeferredPainting = true;
            this.GdViewer1.EnabledProgressBar = true;
            this.GdViewer1.EnableICM = false;
            this.GdViewer1.EnableMenu = true;
            this.GdViewer1.EnableMouseWheel = true;
            this.GdViewer1.EnableTextSelection = true;
            this.GdViewer1.ForceScrollBars = false;
            this.GdViewer1.ForceTemporaryMode = false;
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
            this.GdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView;
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
            this.GdViewer1.RenderGdPictureAnnots = true;
            this.GdViewer1.ScrollBars = true;
            this.GdViewer1.ScrollLargeChange = ((short)(50));
            this.GdViewer1.ScrollSmallChange = ((short)(1));
            this.GdViewer1.SilentMode = true;
            this.GdViewer1.Size = new System.Drawing.Size(800, 1014);
            this.GdViewer1.TabIndex = 0;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            this.GdViewer1.TransferEnded += new GdPicture14.GdViewer.TransferEndedEventHandler(this.GdViewer1_TransferEnded);
            this.GdViewer1.AfterZoomChange += new GdPicture14.GdViewer.AfterZoomChangeEventHandler(this.GdViewer1_AfterZoomChange);
            this.GdViewer1.ScrollViewer += new GdPicture14.GdViewer.ScrollViewerEventHandler(this.GdViewer1_ScrollViewer);
            this.GdViewer1.PageChanged += new GdPicture14.GdViewer.PageChangedEventHandler(this.GdViewer1_PageChanged);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Label33);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(800, 49);
            this.Panel3.TabIndex = 1;
            // 
            // Label33
            // 
            this.Label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.Location = new System.Drawing.Point(0, 0);
            this.Label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(800, 49);
            this.Label33.TabIndex = 0;
            this.Label33.Text = "BEFORE";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.GdViewerPreview);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel5.Location = new System.Drawing.Point(0, 49);
            this.Panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(720, 1014);
            this.Panel5.TabIndex = 3;
            // 
            // GdViewerPreview
            // 
            this.GdViewerPreview.AllowDropFile = false;
            this.GdViewerPreview.AnimateGIF = true;
            this.GdViewerPreview.AnnotationDropShadow = true;
            this.GdViewerPreview.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.GdViewerPreview.AnnotationResizeRotateHandlesScale = 1F;
            this.GdViewerPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewerPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewerPreview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GdViewerPreview.BackgroundImage = null;
            this.GdViewerPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewerPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GdViewerPreview.ContinuousViewMode = false;
            this.GdViewerPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewerPreview.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityAutomatic;
            this.GdViewerPreview.DisplayQualityAuto = true;
            this.GdViewerPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdViewerPreview.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewerPreview.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewerPreview.EnableDeferredPainting = true;
            this.GdViewerPreview.EnabledProgressBar = true;
            this.GdViewerPreview.EnableICM = false;
            this.GdViewerPreview.EnableMenu = false;
            this.GdViewerPreview.EnableMouseWheel = true;
            this.GdViewerPreview.EnableTextSelection = true;
            this.GdViewerPreview.ForceScrollBars = false;
            this.GdViewerPreview.ForceTemporaryMode = false;
            this.GdViewerPreview.ForeColor = System.Drawing.Color.Black;
            this.GdViewerPreview.Gamma = 1F;
            this.GdViewerPreview.HQAnnotationRendering = true;
            this.GdViewerPreview.IgnoreDocumentResolution = false;
            this.GdViewerPreview.KeepDocumentPosition = false;
            this.GdViewerPreview.Location = new System.Drawing.Point(0, 0);
            this.GdViewerPreview.LockViewer = false;
            this.GdViewerPreview.MagnifierHeight = 90;
            this.GdViewerPreview.MagnifierWidth = 160;
            this.GdViewerPreview.MagnifierZoomX = 2F;
            this.GdViewerPreview.MagnifierZoomY = 2F;
            this.GdViewerPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GdViewerPreview.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdViewerPreview.MouseMode = GdPicture14.ViewerMouseMode.MouseModeDefault;
            this.GdViewerPreview.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeDisabled;
            this.GdViewerPreview.Name = "GdViewerPreview";
            this.GdViewerPreview.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView;
            this.GdViewerPreview.PdfDisplayFormField = true;
            this.GdViewerPreview.PdfEnableFileLinks = true;
            this.GdViewerPreview.PdfEnableLinks = true;
            this.GdViewerPreview.PdfIncreaseTextContrast = false;
            this.GdViewerPreview.PdfShowDialogForPassword = true;
            this.GdViewerPreview.PdfShowOpenFileDialogForDecryption = true;
            this.GdViewerPreview.PdfVerifyDigitalCertificates = false;
            this.GdViewerPreview.RectBorderColor = System.Drawing.Color.Black;
            this.GdViewerPreview.RectBorderSize = 1;
            this.GdViewerPreview.RectIsEditable = true;
            this.GdViewerPreview.RegionsAreEditable = true;
            this.GdViewerPreview.RenderGdPictureAnnots = true;
            this.GdViewerPreview.ScrollBars = true;
            this.GdViewerPreview.ScrollLargeChange = ((short)(50));
            this.GdViewerPreview.ScrollSmallChange = ((short)(1));
            this.GdViewerPreview.SilentMode = true;
            this.GdViewerPreview.Size = new System.Drawing.Size(720, 1014);
            this.GdViewerPreview.TabIndex = 1;
            this.GdViewerPreview.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewerPreview.Zoom = 0.001D;
            this.GdViewerPreview.ZoomCenterAtMousePosition = false;
            this.GdViewerPreview.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewerPreview.ZoomStep = 25;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.Label34);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(720, 49);
            this.Panel4.TabIndex = 2;
            // 
            // Label34
            // 
            this.Label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.Location = new System.Drawing.Point(0, 0);
            this.Label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(720, 49);
            this.Label34.TabIndex = 0;
            this.Label34.Text = "AFTER";
            this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DefaultToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.DefaultToolStripMenuItem.Text = "Default";
            this.DefaultToolStripMenuItem.Click += new System.EventHandler(this.DefaultToolStripMenuItem_Click);
            // 
            // AreaSelectionToolStripMenuItem
            // 
            this.AreaSelectionToolStripMenuItem.CheckOnClick = true;
            this.AreaSelectionToolStripMenuItem.Name = "AreaSelectionToolStripMenuItem";
            this.AreaSelectionToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.AreaSelectionToolStripMenuItem.Text = "Area selection";
            this.AreaSelectionToolStripMenuItem.Click += new System.EventHandler(this.AreaSelectionToolStripMenuItem_Click);
            // 
            // PanToolStripMenuItem
            // 
            this.PanToolStripMenuItem.Checked = true;
            this.PanToolStripMenuItem.CheckOnClick = true;
            this.PanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PanToolStripMenuItem.Name = "PanToolStripMenuItem";
            this.PanToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.PanToolStripMenuItem.Text = "Pan";
            this.PanToolStripMenuItem.Click += new System.EventHandler(this.PanToolStripMenuItem_Click);
            // 
            // AreaZoomingToolStripMenuItem
            // 
            this.AreaZoomingToolStripMenuItem.CheckOnClick = true;
            this.AreaZoomingToolStripMenuItem.Name = "AreaZoomingToolStripMenuItem";
            this.AreaZoomingToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.AreaZoomingToolStripMenuItem.Text = "Area zooming";
            this.AreaZoomingToolStripMenuItem.Click += new System.EventHandler(this.AreaZoomingToolStripMenuItem_Click);
            // 
            // MagnifierToolStripMenuItem
            // 
            this.MagnifierToolStripMenuItem.CheckOnClick = true;
            this.MagnifierToolStripMenuItem.Name = "MagnifierToolStripMenuItem";
            this.MagnifierToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
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
            this.toolStripSeparator7,
            this.btnCopyToClipboard,
            this.btnImportFromClipboard,
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 35);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyToClipboard.Image")));
            this.btnCopyToClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(28, 32);
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnImportFromClipboard
            // 
            this.btnImportFromClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImportFromClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnImportFromClipboard.Image")));
            this.btnImportFromClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportFromClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportFromClipboard.Name = "btnImportFromClipboard";
            this.btnImportFromClipboard.Size = new System.Drawing.Size(28, 32);
            this.btnImportFromClipboard.Text = "Import from clipboard";
            this.btnImportFromClipboard.Click += new System.EventHandler(this.btnImportFromClipboard_Click);
            // 
            // Label38
            // 
            this.Label38.Location = new System.Drawing.Point(9, 309);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(452, 121);
            this.Label38.TabIndex = 19;
            this.Label38.Text = resources.GetString("Label38.Text");
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
            this.tpDocumentCleanUp.ResumeLayout(false);
            this.pDocumentCleanUp.ResumeLayout(false);
            this.pDocumentCleanUp.PerformLayout();
            this.tbEffectsParameters.ResumeLayout(false);
            this.tpAutoDeskewParameters.ResumeLayout(false);
            this.tpAutoDeskewParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoDeskewAngleStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAutoDeskewBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoDeskewMaxAngleOfResearch)).EndInit();
            this.tpAutoTextInvert.ResumeLayout(false);
            this.tpAutoTextInvert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMaxLinesThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMaxBlackPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMinBlackPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMinObjectHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoInvertTextMinObjectWidth)).EndInit();
            this.tpCropBlackBorders.ResumeLayout(false);
            this.tpCropBlackBorders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBlackBordersSkipLinesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBlackBordersConfidence)).EndInit();
            this.tpCropBorders.ResumeLayout(false);
            this.tpCropBorders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCropBordersConfidence)).EndInit();
            this.tpDeleteBlackBorders.ResumeLayout(false);
            this.tpDeleteBlackBorders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDeleteBlackBorderEffectMargin)).EndInit();
            this.tpMedian.ResumeLayout(false);
            this.tpMedian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMedianEffectKernelSize)).EndInit();
            this.tpRemoveBlob.ResumeLayout(false);
            this.tpRemoveBlob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMaxFillPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMinFillPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMaxBlobHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMaxBlobWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMinBlobHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveBlobEffectMinBlobWidth)).EndInit();
            this.tpRemoveLines.ResumeLayout(false);
            this.tpRemoveLines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveLinesEffectMaxInterception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveLinesEffectMinLineLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveLinesEffectMaxLineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRemoveLinesEffectMaxLineGap)).EndInit();
            this.tpBitonalDespeckle.ResumeLayout(false);
            this.tpBitonalDespeckle.PerformLayout();
            this.tpBitonalSkeletonize.ResumeLayout(false);
            this.tpBitonalSkeletonize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBitonalSkeletonizeEffectRepetition)).EndInit();
            this.tpBitonalVigorousDespeckle.ResumeLayout(false);
            this.tpBitonalVigorousDespeckle.PerformLayout();
            this.tpBitonalDilate.ResumeLayout(false);
            this.tpBitonalDilate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBitonalDilateEffectKernelSize)).EndInit();
            this.tpRemoveHolePunch.ResumeLayout(false);
            this.tpRemoveHolePunch.PerformLayout();
            this.tpDespeckleAdvanced.ResumeLayout(false);
            this.tpDespeckleAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDespeckleStrength)).EndInit();
            this.pDirectEffects.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.pSnapInButtons.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal GdPicture14.ThumbnailEx ThumbnailEx1;
		internal System.Windows.Forms.TabControl tcLeftPanel;
		internal System.Windows.Forms.TabPage tpThumbnails;
		internal System.Windows.Forms.TabPage tpDocumentCleanUp;
		internal System.Windows.Forms.SplitContainer scMain;
		internal GdPicture14.GdViewer GdViewer1;
		internal System.Windows.Forms.StatusStrip statusbar;
		internal System.Windows.Forms.Panel pMain;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.Panel pDocumentCleanUp;
		internal System.Windows.Forms.ToolStripContainer ToolStripContainer1;
		internal System.Windows.Forms.ToolStrip thumbnailPanelToolstrip;
		internal System.Windows.Forms.Panel Panel6;
		internal System.Windows.Forms.Button btnSnapInThumbnails;
		internal System.Windows.Forms.Button btnSnapInDocumentCleanUp;
		internal System.Windows.Forms.Panel Panel9;
		internal System.Windows.Forms.Panel pSnapInButtons;
		internal System.Windows.Forms.Panel Panel7;
		internal System.Windows.Forms.Label lblSnapInPanel;
		internal System.Windows.Forms.ToolStripDropDownButton btnThumbSize;
		internal System.Windows.Forms.ToolStripMenuItem LargeThumbnailsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem MediumThumbnailsToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem SmallThumbnailsToolStripMenuItem1;
		internal System.Windows.Forms.Panel pDirectEffects;
		internal System.Windows.Forms.ComboBox cbDocumentCleanUpEffects;
		internal System.Windows.Forms.Button btnResetEffects;
		internal System.Windows.Forms.Button btnApplyEffects;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.ToolStripButton btnOpen;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
		internal System.Windows.Forms.ToolStripButton btnClose;
		internal System.Windows.Forms.ToolStripButton btnPrint;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
		internal System.Windows.Forms.ToolStripButton btnSettings;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
		internal System.Windows.Forms.ToolStripDropDownButton btnMouseMode;
		internal System.Windows.Forms.ToolStripMenuItem DefaultToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AreaSelectionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem PanToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AreaZoomingToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MagnifierToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
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
		internal System.Windows.Forms.ToolStripButton btnFitWidth;
		internal System.Windows.Forms.ToolStripButton btnFitPage;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
		internal System.Windows.Forms.ToolStripButton btnRotateLeft;
		internal System.Windows.Forms.ToolStripButton btnRotateRight;
		internal System.Windows.Forms.ToolStripButton btnFlipX;
		internal System.Windows.Forms.ToolStripButton btnFlipY;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
		internal System.Windows.Forms.ToolStripButton btnAbout;
		internal System.Windows.Forms.ToolStrip mainToolStrip;
		internal System.Windows.Forms.Button btnAddEffect;
		internal System.Windows.Forms.Button btnRemoveAllEffects;
		internal System.Windows.Forms.Button btnRemoveEffect;
		internal System.Windows.Forms.ListBox lstEffects;
		internal System.Windows.Forms.TabControl tbEffectsParameters;
		internal System.Windows.Forms.TabPage tpAutoDeskewParameters;
		internal System.Windows.Forms.TabPage tpAutoTextInvert;
		internal System.Windows.Forms.SplitContainer SplitContainer1;
		internal GdPicture14.GdViewer GdViewerPreview;
		internal System.Windows.Forms.NumericUpDown nAutoDeskewMaxAngleOfResearch;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.PictureBox pAutoDeskewBackColor;
		internal System.Windows.Forms.NumericUpDown nAutoDeskewAngleStep;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.CheckBox chkAutoDeskewOptimistic;
		internal System.Windows.Forms.NumericUpDown nAutoInvertTextMinObjectHeight;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.NumericUpDown nAutoInvertTextMinObjectWidth;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.NumericUpDown nAutoInvertTextMaxBlackPercent;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.NumericUpDown nAutoInvertTextMinBlackPercent;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.CheckBox chkAutoTextInvertFixBackground;
		internal System.Windows.Forms.CheckBox chkAutoTextInvertConnectedToLines;
		internal System.Windows.Forms.NumericUpDown nAutoInvertTextMaxLinesThickness;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TabPage tpCropBlackBorders;
		internal System.Windows.Forms.NumericUpDown nCropBlackBordersConfidence;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.NumericUpDown nCropBlackBordersSkipLinesCount;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TabPage tpCropBorders;
		internal System.Windows.Forms.NumericUpDown nCropBordersConfidence;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.ComboBox cbCropBordersReferencePoint;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.NumericUpDown nCropBordersHeight;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.NumericUpDown nCropBordersWidth;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.NumericUpDown nCropBordersTop;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.NumericUpDown nCropBordersLeft;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.ComboBox cbCropBordersImageContext;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.TabPage tpDeleteBlackBorders;
		internal System.Windows.Forms.NumericUpDown nDeleteBlackBorderEffectMargin;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.CheckBox chkDeleteBlackBordersEffectSkewedBorders;
		internal System.Windows.Forms.TabPage tpMedian;
		internal System.Windows.Forms.NumericUpDown nMedianEffectKernelSize;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.TabPage tpRemoveBlob;
		internal System.Windows.Forms.NumericUpDown nRemoveBlobEffectMaxFillPercent;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.NumericUpDown nRemoveBlobEffectMinFillPercent;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.NumericUpDown nRemoveBlobEffectMaxBlobHeight;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.NumericUpDown nRemoveBlobEffectMaxBlobWidth;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.NumericUpDown nRemoveBlobEffectMinBlobHeight;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.NumericUpDown nRemoveBlobEffectMinBlobWidth;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TabPage tpRemoveLines;
		internal System.Windows.Forms.ComboBox cbRemoveLinesEffectOrientation;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.NumericUpDown nRemoveLinesEffectMaxLineGap;
		internal System.Windows.Forms.Label Label27;
		internal System.Windows.Forms.NumericUpDown nRemoveLinesEffectMaxLineThickness;
		internal System.Windows.Forms.Label Label28;
		internal System.Windows.Forms.NumericUpDown nRemoveLinesEffectMinLineLength;
		internal System.Windows.Forms.Label Label29;
		internal System.Windows.Forms.NumericUpDown nRemoveLinesEffectMaxInterception;
		internal System.Windows.Forms.Label Label30;
		internal System.Windows.Forms.CheckBox chkRemoveLinesEffectReconnectBrokenCharacters;
		internal System.Windows.Forms.TabPage tpBitonalDespeckle;
		internal System.Windows.Forms.CheckBox chkBitonalDespeckleEffectFixText;
		internal System.Windows.Forms.TabPage tpBitonalSkeletonize;
		internal System.Windows.Forms.NumericUpDown nBitonalSkeletonizeEffectRepetition;
		internal System.Windows.Forms.Label Label31;
		internal System.Windows.Forms.TabPage tpBitonalVigorousDespeckle;
		internal System.Windows.Forms.CheckBox chkBitonalVigorousDespeckleEffectCheckForDotOfI;
		internal System.Windows.Forms.TabPage tpBitonalDilate;
		internal System.Windows.Forms.NumericUpDown nBitonalDilateEffectKernelSize;
		internal System.Windows.Forms.Label Label32;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Label Label33;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Label Label34;
		internal System.Windows.Forms.Panel Panel5;
		internal System.Windows.Forms.TabPage tpRemoveHolePunch;
		internal System.Windows.Forms.Label Label35;
		internal System.Windows.Forms.ComboBox cbRemoveHolePunchEffectMargins;
		internal System.Windows.Forms.Button btnMoveEffectUp;
		internal System.Windows.Forms.Button btnMoveEffectDown;
        private ToolStripButton btnSave;
        internal ToolStripSeparator toolStripSeparator7;
        internal ToolStripButton btnCopyToClipboard;
        internal ToolStripButton btnImportFromClipboard;
        private TabPage tpDespeckleAdvanced;
        internal Label Label37;
        internal Label Label36;
        internal NumericUpDown nDespeckleStrength;
        internal ComboBox cbDespeckleType;
        internal Label Label38;
    }
	
}
