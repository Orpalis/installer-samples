using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Data;
using System.Collections.Generic;



namespace Csharp_Forms_Processing
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processFormsButton = new System.Windows.Forms.Button();
            this.formSetUpButton = new System.Windows.Forms.Button();
            this.TableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.processFormsPanel = new System.Windows.Forms.Panel();
            this.processFormsTableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.omrImagesButton = new System.Windows.Forms.Button();
            this.clearImagesButton = new System.Windows.Forms.Button();
            this.loadImagesButton = new System.Windows.Forms.Button();
            this.imagesViewer = new GdPicture14.GdViewer();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.formSetUpPanel = new System.Windows.Forms.Panel();
            this.formSetUpTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.drawRectanglesButton = new System.Windows.Forms.Button();
            this.addFieldsButton = new System.Windows.Forms.Button();
            this.selectAnchorButton = new System.Windows.Forms.Button();
            this.loadFormButton = new System.Windows.Forms.Button();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.hasCharacter = new System.Windows.Forms.CheckBox();
            this.oval = new System.Windows.Forms.RadioButton();
            this.checkORCircle = new System.Windows.Forms.RadioButton();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.useConfidence = new System.Windows.Forms.CheckBox();
            this.confidenceGroup = new System.Windows.Forms.GroupBox();
            this.sensitivityValue = new System.Windows.Forms.Label();
            this.minConfidenceValue = new System.Windows.Forms.NumericUpDown();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.sensitivity = new System.Windows.Forms.HScrollBar();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.formViewer = new GdPicture14.GdViewer();
            this.addFieldsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.Label9 = new System.Windows.Forms.Label();
            this.totalNumberOfFieldsLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.addMultipleFieldsButton = new System.Windows.Forms.Button();
            this.addSingleFieldButon = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.TableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.MenuStrip1.SuspendLayout();
            this.TableLayoutPanelButtons.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.processFormsPanel.SuspendLayout();
            this.processFormsTableLayoutPanel5.SuspendLayout();
            this.TableLayoutPanel5.SuspendLayout();
            this.TableLayoutPanel6.SuspendLayout();
            this.formSetUpPanel.SuspendLayout();
            this.formSetUpTableLayoutPanel.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.settingsTableLayoutPanel.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.confidenceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minConfidenceValue)).BeginInit();
            this.addFieldsPanel.SuspendLayout();
            this.TableLayoutPanel10.SuspendLayout();
            this.TableLayoutPanel9.SuspendLayout();
            this.TableLayoutPanel7.SuspendLayout();
            this.TableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1562, 28);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ZToolStripMenuItem
            // 
            this.ZToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProjectToolStripMenuItem,
            this.CloseProjectToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.ZToolStripMenuItem.Name = "ZToolStripMenuItem";
            this.ZToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.ZToolStripMenuItem.Text = "File";
            // 
            // NewProjectToolStripMenuItem
            // 
            this.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem";
            this.NewProjectToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.NewProjectToolStripMenuItem.Text = "New Project";
            this.NewProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItem_Click);
            // 
            // CloseProjectToolStripMenuItem
            // 
            this.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem";
            this.CloseProjectToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.CloseProjectToolStripMenuItem.Text = "Close Project";
            this.CloseProjectToolStripMenuItem.Click += new System.EventHandler(this.CloseProjectToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TableLayoutPanelButtons
            // 
            this.TableLayoutPanelButtons.ColumnCount = 1;
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelButtons.Controls.Add(this.TableLayoutPanel1, 0, 0);
            this.TableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelButtons.Location = new System.Drawing.Point(0, 28);
            this.TableLayoutPanelButtons.Name = "TableLayoutPanelButtons";
            this.TableLayoutPanelButtons.RowCount = 1;
            this.TableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelButtons.Size = new System.Drawing.Size(1562, 75);
            this.TableLayoutPanelButtons.TabIndex = 1;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.processFormsButton, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.formSetUpButton, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1556, 69);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // processFormsButton
            // 
            this.processFormsButton.BackColor = System.Drawing.Color.Teal;
            this.processFormsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processFormsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.processFormsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.processFormsButton.Location = new System.Drawing.Point(781, 3);
            this.processFormsButton.Name = "processFormsButton";
            this.processFormsButton.Size = new System.Drawing.Size(772, 63);
            this.processFormsButton.TabIndex = 1;
            this.processFormsButton.Text = "Stage Two: Process Forms";
            this.processFormsButton.UseVisualStyleBackColor = false;
            this.processFormsButton.Visible = false;
            this.processFormsButton.Click += new System.EventHandler(this.processFormsButton_Click);
            // 
            // formSetUpButton
            // 
            this.formSetUpButton.BackColor = System.Drawing.Color.Teal;
            this.formSetUpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSetUpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.formSetUpButton.Location = new System.Drawing.Point(3, 3);
            this.formSetUpButton.Name = "formSetUpButton";
            this.formSetUpButton.Size = new System.Drawing.Size(772, 63);
            this.formSetUpButton.TabIndex = 0;
            this.formSetUpButton.Text = "Stage One: Form Set Up";
            this.formSetUpButton.UseVisualStyleBackColor = false;
            this.formSetUpButton.Visible = false;
            this.formSetUpButton.Click += new System.EventHandler(this.formSetUpButton_Click);
            // 
            // TableLayoutPanelData
            // 
            this.TableLayoutPanelData.ColumnCount = 1;
            this.TableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelData.Location = new System.Drawing.Point(0, 103);
            this.TableLayoutPanelData.Name = "TableLayoutPanelData";
            this.TableLayoutPanelData.RowCount = 1;
            this.TableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelData.Size = new System.Drawing.Size(1562, 647);
            this.TableLayoutPanelData.TabIndex = 2;
            // 
            // processFormsPanel
            // 
            this.processFormsPanel.Controls.Add(this.processFormsTableLayoutPanel5);
            this.processFormsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processFormsPanel.Location = new System.Drawing.Point(3, 3);
            this.processFormsPanel.Name = "processFormsPanel";
            this.processFormsPanel.Size = new System.Drawing.Size(1361, 641);
            this.processFormsPanel.TabIndex = 0;
            // 
            // processFormsTableLayoutPanel5
            // 
            this.processFormsTableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.processFormsTableLayoutPanel5.ColumnCount = 3;
            this.processFormsTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.processFormsTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processFormsTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.processFormsTableLayoutPanel5.Controls.Add(this.TableLayoutPanel5, 0, 0);
            this.processFormsTableLayoutPanel5.Controls.Add(this.imagesViewer, 1, 0);
            this.processFormsTableLayoutPanel5.Controls.Add(this.resultsTextBox, 2, 0);
            this.processFormsTableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processFormsTableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.processFormsTableLayoutPanel5.Name = "processFormsTableLayoutPanel5";
            this.processFormsTableLayoutPanel5.RowCount = 1;
            this.processFormsTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.processFormsTableLayoutPanel5.Size = new System.Drawing.Size(1361, 641);
            this.processFormsTableLayoutPanel5.TabIndex = 0;
            // 
            // TableLayoutPanel5
            // 
            this.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.TableLayoutPanel5.ColumnCount = 1;
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel5.Controls.Add(this.ListBox1, 0, 0);
            this.TableLayoutPanel5.Controls.Add(this.TableLayoutPanel6, 0, 1);
            this.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel5.Location = new System.Drawing.Point(6, 6);
            this.TableLayoutPanel5.Name = "TableLayoutPanel5";
            this.TableLayoutPanel5.RowCount = 2;
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.TableLayoutPanel5.Size = new System.Drawing.Size(294, 629);
            this.TableLayoutPanel5.TabIndex = 0;
            // 
            // ListBox1
            // 
            this.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(6, 6);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(282, 389);
            this.ListBox1.TabIndex = 0;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // TableLayoutPanel6
            // 
            this.TableLayoutPanel6.ColumnCount = 1;
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel6.Controls.Add(this.omrImagesButton, 0, 2);
            this.TableLayoutPanel6.Controls.Add(this.clearImagesButton, 0, 1);
            this.TableLayoutPanel6.Controls.Add(this.loadImagesButton, 0, 0);
            this.TableLayoutPanel6.Location = new System.Drawing.Point(6, 404);
            this.TableLayoutPanel6.Name = "TableLayoutPanel6";
            this.TableLayoutPanel6.RowCount = 3;
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.TableLayoutPanel6.Size = new System.Drawing.Size(281, 217);
            this.TableLayoutPanel6.TabIndex = 1;
            // 
            // omrImagesButton
            // 
            this.omrImagesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.omrImagesButton.Location = new System.Drawing.Point(3, 145);
            this.omrImagesButton.Name = "omrImagesButton";
            this.omrImagesButton.Size = new System.Drawing.Size(275, 69);
            this.omrImagesButton.TabIndex = 2;
            this.omrImagesButton.Text = "OMR Images";
            this.omrImagesButton.UseVisualStyleBackColor = true;
            this.omrImagesButton.Click += new System.EventHandler(this.omrImagesButton_Click);
            // 
            // clearImagesButton
            // 
            this.clearImagesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearImagesButton.Location = new System.Drawing.Point(3, 74);
            this.clearImagesButton.Name = "clearImagesButton";
            this.clearImagesButton.Size = new System.Drawing.Size(275, 65);
            this.clearImagesButton.TabIndex = 1;
            this.clearImagesButton.Text = "Clear Images";
            this.clearImagesButton.UseVisualStyleBackColor = true;
            this.clearImagesButton.Click += new System.EventHandler(this.clearImagesButton_Click);
            // 
            // loadImagesButton
            // 
            this.loadImagesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadImagesButton.Location = new System.Drawing.Point(3, 3);
            this.loadImagesButton.Name = "loadImagesButton";
            this.loadImagesButton.Size = new System.Drawing.Size(275, 65);
            this.loadImagesButton.TabIndex = 0;
            this.loadImagesButton.Text = "Load Images";
            this.loadImagesButton.UseVisualStyleBackColor = true;
            this.loadImagesButton.Click += new System.EventHandler(this.loadImagesButton_Click);
            // 
            // imagesViewer
            // 
            this.imagesViewer.AllowDropFile = false;
            this.imagesViewer.AnimateGIF = false;
            this.imagesViewer.AnnotationDropShadow = true;
            this.imagesViewer.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.imagesViewer.AnnotationResizeRotateHandlesScale = 1F;
            this.imagesViewer.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.imagesViewer.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.imagesViewer.BackColor = System.Drawing.Color.Black;
            this.imagesViewer.BackgroundImage = null;
            this.imagesViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imagesViewer.ContinuousViewMode = true;
            this.imagesViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.imagesViewer.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.imagesViewer.DisplayQualityAuto = false;
            this.imagesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesViewer.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.imagesViewer.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.imagesViewer.EnableDeferredPainting = true;
            this.imagesViewer.EnabledProgressBar = true;
            this.imagesViewer.EnableICM = false;
            this.imagesViewer.EnableMenu = false;
            this.imagesViewer.EnableMouseWheel = true;
            this.imagesViewer.EnableTextSelection = true;
            this.imagesViewer.ForceScrollBars = false;
            this.imagesViewer.ForeColor = System.Drawing.Color.Black;
            this.imagesViewer.Gamma = 1F;
            this.imagesViewer.HQAnnotationRendering = true;
            this.imagesViewer.IgnoreDocumentResolution = false;
            this.imagesViewer.KeepDocumentPosition = false;
            this.imagesViewer.Location = new System.Drawing.Point(309, 6);
            this.imagesViewer.LockViewer = false;
            this.imagesViewer.MagnifierHeight = 90;
            this.imagesViewer.MagnifierWidth = 160;
            this.imagesViewer.MagnifierZoomX = 2F;
            this.imagesViewer.MagnifierZoomY = 2F;
            this.imagesViewer.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.imagesViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.imagesViewer.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
            this.imagesViewer.Name = "imagesViewer";
            this.imagesViewer.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView;
            this.imagesViewer.PdfDisplayFormField = true;
            this.imagesViewer.PdfEnableFileLinks = true;
            this.imagesViewer.PdfEnableLinks = true;
            this.imagesViewer.PdfIncreaseTextContrast = false;
            this.imagesViewer.PdfShowDialogForPassword = true;
            this.imagesViewer.PdfShowOpenFileDialogForDecryption = true;
            this.imagesViewer.PdfVerifyDigitalCertificates = false;
            this.imagesViewer.RectBorderColor = System.Drawing.Color.Black;
            this.imagesViewer.RectBorderSize = 1;
            this.imagesViewer.RectIsEditable = true;
            this.imagesViewer.RegionsAreEditable = true;
            this.imagesViewer.RenderGdPictureAnnots = true;
            this.imagesViewer.ScrollBars = true;
            this.imagesViewer.ScrollLargeChange = ((short)(50));
            this.imagesViewer.ScrollSmallChange = ((short)(1));
            this.imagesViewer.SilentMode = true;
            this.imagesViewer.Size = new System.Drawing.Size(702, 629);
            this.imagesViewer.TabIndex = 0;
            this.imagesViewer.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.imagesViewer.Zoom = 1D;
            this.imagesViewer.ZoomCenterAtMousePosition = false;
            this.imagesViewer.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100;
            this.imagesViewer.ZoomStep = 25;
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resultsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsTextBox.Location = new System.Drawing.Point(1020, 6);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(335, 629);
            this.resultsTextBox.TabIndex = 1;
            this.resultsTextBox.Text = "";
            // 
            // formSetUpPanel
            // 
            this.formSetUpPanel.Controls.Add(this.formSetUpTableLayoutPanel);
            this.formSetUpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSetUpPanel.Location = new System.Drawing.Point(3, 3);
            this.formSetUpPanel.Name = "formSetUpPanel";
            this.formSetUpPanel.Size = new System.Drawing.Size(1361, 641);
            this.formSetUpPanel.TabIndex = 0;
            // 
            // formSetUpTableLayoutPanel
            // 
            this.formSetUpTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.formSetUpTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.formSetUpTableLayoutPanel.ColumnCount = 1;
            this.formSetUpTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1385F));
            this.formSetUpTableLayoutPanel.Controls.Add(this.TableLayoutPanel2, 0, 0);
            this.formSetUpTableLayoutPanel.Controls.Add(this.TableLayoutPanel3, 0, 2);
            this.formSetUpTableLayoutPanel.Controls.Add(this.addFieldsPanel, 0, 1);
            this.formSetUpTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSetUpTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.formSetUpTableLayoutPanel.Name = "formSetUpTableLayoutPanel";
            this.formSetUpTableLayoutPanel.RowCount = 3;
            this.formSetUpTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.formSetUpTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.formSetUpTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.formSetUpTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formSetUpTableLayoutPanel.Size = new System.Drawing.Size(1361, 641);
            this.formSetUpTableLayoutPanel.TabIndex = 0;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 4;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel2.Controls.Add(this.drawRectanglesButton, 3, 0);
            this.TableLayoutPanel2.Controls.Add(this.addFieldsButton, 2, 0);
            this.TableLayoutPanel2.Controls.Add(this.selectAnchorButton, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.loadFormButton, 0, 0);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(1379, 41);
            this.TableLayoutPanel2.TabIndex = 0;
            // 
            // drawRectanglesButton
            // 
            this.drawRectanglesButton.BackColor = System.Drawing.Color.Teal;
            this.drawRectanglesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawRectanglesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drawRectanglesButton.Location = new System.Drawing.Point(1035, 3);
            this.drawRectanglesButton.Name = "drawRectanglesButton";
            this.drawRectanglesButton.Size = new System.Drawing.Size(341, 35);
            this.drawRectanglesButton.TabIndex = 3;
            this.drawRectanglesButton.Text = "4. Draw Rectangles";
            this.drawRectanglesButton.UseVisualStyleBackColor = false;
            this.drawRectanglesButton.Visible = false;
            // 
            // addFieldsButton
            // 
            this.addFieldsButton.BackColor = System.Drawing.Color.Teal;
            this.addFieldsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addFieldsButton.Location = new System.Drawing.Point(691, 3);
            this.addFieldsButton.Name = "addFieldsButton";
            this.addFieldsButton.Size = new System.Drawing.Size(338, 35);
            this.addFieldsButton.TabIndex = 2;
            this.addFieldsButton.Text = "3. Add Fields";
            this.addFieldsButton.UseVisualStyleBackColor = false;
            this.addFieldsButton.Visible = false;
            this.addFieldsButton.Click += new System.EventHandler(this.addFieldsButton_Click);
            // 
            // selectAnchorButton
            // 
            this.selectAnchorButton.BackColor = System.Drawing.Color.Teal;
            this.selectAnchorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAnchorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selectAnchorButton.Location = new System.Drawing.Point(347, 3);
            this.selectAnchorButton.Name = "selectAnchorButton";
            this.selectAnchorButton.Size = new System.Drawing.Size(338, 35);
            this.selectAnchorButton.TabIndex = 1;
            this.selectAnchorButton.Text = "2. Select Anchor";
            this.selectAnchorButton.UseVisualStyleBackColor = false;
            this.selectAnchorButton.Visible = false;
            this.selectAnchorButton.Click += new System.EventHandler(this.selectAnchorButton_Click);
            // 
            // loadFormButton
            // 
            this.loadFormButton.BackColor = System.Drawing.Color.Teal;
            this.loadFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadFormButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loadFormButton.Location = new System.Drawing.Point(3, 3);
            this.loadFormButton.Name = "loadFormButton";
            this.loadFormButton.Size = new System.Drawing.Size(338, 35);
            this.loadFormButton.TabIndex = 0;
            this.loadFormButton.Text = "1. Load Form";
            this.loadFormButton.UseVisualStyleBackColor = false;
            this.loadFormButton.Click += new System.EventHandler(this.loadFormButton_Click);
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.TableLayoutPanel3.ColumnCount = 2;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel3.Controls.Add(this.settingsTableLayoutPanel, 0, 0);
            this.TableLayoutPanel3.Controls.Add(this.formViewer, 1, 0);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(6, 105);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 1;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(1349, 534);
            this.TableLayoutPanel3.TabIndex = 2;
            // 
            // settingsTableLayoutPanel
            // 
            this.settingsTableLayoutPanel.ColumnCount = 1;
            this.settingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTableLayoutPanel.Controls.Add(this.GroupBox1, 0, 0);
            this.settingsTableLayoutPanel.Controls.Add(this.TableLayoutPanel4, 0, 1);
            this.settingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsTableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
            this.settingsTableLayoutPanel.RowCount = 2;
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.80077F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.19923F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settingsTableLayoutPanel.Size = new System.Drawing.Size(400, 522);
            this.settingsTableLayoutPanel.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.hasCharacter);
            this.GroupBox1.Controls.Add(this.oval);
            this.GroupBox1.Controls.Add(this.checkORCircle);
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(389, 159);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Fields\' Type";
            // 
            // hasCharacter
            // 
            this.hasCharacter.AutoSize = true;
            this.hasCharacter.BackColor = System.Drawing.Color.Transparent;
            this.hasCharacter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hasCharacter.Location = new System.Drawing.Point(26, 114);
            this.hasCharacter.Name = "hasCharacter";
            this.hasCharacter.Size = new System.Drawing.Size(121, 21);
            this.hasCharacter.TabIndex = 2;
            this.hasCharacter.Text = "Has Character";
            this.hasCharacter.UseVisualStyleBackColor = false;
            this.hasCharacter.CheckedChanged += new System.EventHandler(this.hasCharacter_CheckedChanged);
            // 
            // oval
            // 
            this.oval.AutoSize = true;
            this.oval.BackColor = System.Drawing.Color.Transparent;
            this.oval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oval.Location = new System.Drawing.Point(26, 60);
            this.oval.Name = "oval";
            this.oval.Size = new System.Drawing.Size(58, 21);
            this.oval.TabIndex = 1;
            this.oval.Text = "Oval";
            this.oval.UseVisualStyleBackColor = false;
            this.oval.CheckedChanged += new System.EventHandler(this.oval_CheckedChanged);
            // 
            // checkORCircle
            // 
            this.checkORCircle.AutoSize = true;
            this.checkORCircle.BackColor = System.Drawing.Color.Transparent;
            this.checkORCircle.Checked = true;
            this.checkORCircle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkORCircle.Location = new System.Drawing.Point(26, 33);
            this.checkORCircle.Name = "checkORCircle";
            this.checkORCircle.Size = new System.Drawing.Size(151, 21);
            this.checkORCircle.TabIndex = 0;
            this.checkORCircle.TabStop = true;
            this.checkORCircle.Text = "Circle or Check Box";
            this.checkORCircle.UseVisualStyleBackColor = false;
            this.checkORCircle.CheckedChanged += new System.EventHandler(this.checkORCircle_CheckedChanged);
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanel4.ColumnCount = 1;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel4.Controls.Add(this.useConfidence, 0, 0);
            this.TableLayoutPanel4.Controls.Add(this.confidenceGroup, 0, 1);
            this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 169);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 2;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.28572F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.71429F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(394, 171);
            this.TableLayoutPanel4.TabIndex = 2;
            // 
            // useConfidence
            // 
            this.useConfidence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.useConfidence.AutoSize = true;
            this.useConfidence.BackColor = System.Drawing.Color.Transparent;
            this.useConfidence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.useConfidence.Location = new System.Drawing.Point(4, 10);
            this.useConfidence.Name = "useConfidence";
            this.useConfidence.Size = new System.Drawing.Size(130, 21);
            this.useConfidence.TabIndex = 0;
            this.useConfidence.Text = "Use Confidence";
            this.useConfidence.UseVisualStyleBackColor = false;
            this.useConfidence.CheckedChanged += new System.EventHandler(this.useConfidence_CheckedChanged);
            // 
            // confidenceGroup
            // 
            this.confidenceGroup.Controls.Add(this.sensitivityValue);
            this.confidenceGroup.Controls.Add(this.minConfidenceValue);
            this.confidenceGroup.Controls.Add(this.Label8);
            this.confidenceGroup.Controls.Add(this.Label7);
            this.confidenceGroup.Controls.Add(this.sensitivity);
            this.confidenceGroup.Controls.Add(this.Label6);
            this.confidenceGroup.Controls.Add(this.Label5);
            this.confidenceGroup.Enabled = false;
            this.confidenceGroup.Location = new System.Drawing.Point(4, 45);
            this.confidenceGroup.Name = "confidenceGroup";
            this.confidenceGroup.Size = new System.Drawing.Size(385, 122);
            this.confidenceGroup.TabIndex = 1;
            this.confidenceGroup.TabStop = false;
            // 
            // sensitivityValue
            // 
            this.sensitivityValue.AutoSize = true;
            this.sensitivityValue.Location = new System.Drawing.Point(82, 24);
            this.sensitivityValue.Name = "sensitivityValue";
            this.sensitivityValue.Size = new System.Drawing.Size(24, 17);
            this.sensitivityValue.TabIndex = 6;
            this.sensitivityValue.Text = "50";
            // 
            // minConfidenceValue
            // 
            this.minConfidenceValue.Location = new System.Drawing.Point(256, 91);
            this.minConfidenceValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minConfidenceValue.Name = "minConfidenceValue";
            this.minConfidenceValue.Size = new System.Drawing.Size(120, 22);
            this.minConfidenceValue.TabIndex = 5;
            this.minConfidenceValue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.minConfidenceValue.ValueChanged += new System.EventHandler(this.minConfidenceValue_ValueChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label8.Location = new System.Drawing.Point(7, 93);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(256, 17);
            this.Label8.TabIndex = 4;
            this.Label8.Text = "Minimum Confidence To Consider Filled";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label7.Location = new System.Drawing.Point(307, 51);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(32, 17);
            this.Label7.TabIndex = 3;
            this.Label7.Text = "100";
            // 
            // sensitivity
            // 
            this.sensitivity.LargeChange = 2;
            this.sensitivity.Location = new System.Drawing.Point(74, 51);
            this.sensitivity.Name = "sensitivity";
            this.sensitivity.Size = new System.Drawing.Size(230, 21);
            this.sensitivity.TabIndex = 2;
            this.sensitivity.Value = 50;
            this.sensitivity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sensitivity_Scroll);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label6.Location = new System.Drawing.Point(55, 51);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(16, 17);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "0";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label5.Location = new System.Drawing.Point(7, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 17);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Sensitivity";
            // 
            // formViewer
            // 
            this.formViewer.AllowDropFile = false;
            this.formViewer.AnimateGIF = false;
            this.formViewer.AnnotationDropShadow = true;
            this.formViewer.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.formViewer.AnnotationResizeRotateHandlesScale = 1F;
            this.formViewer.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.formViewer.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.formViewer.BackColor = System.Drawing.Color.Black;
            this.formViewer.BackgroundImage = null;
            this.formViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.formViewer.ContinuousViewMode = true;
            this.formViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.formViewer.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.formViewer.DisplayQualityAuto = false;
            this.formViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formViewer.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.formViewer.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.formViewer.EnableDeferredPainting = true;
            this.formViewer.EnabledProgressBar = true;
            this.formViewer.EnableICM = false;
            this.formViewer.EnableMenu = false;
            this.formViewer.EnableMouseWheel = true;
            this.formViewer.EnableTextSelection = true;
            this.formViewer.ForceScrollBars = false;
            this.formViewer.ForeColor = System.Drawing.Color.Black;
            this.formViewer.Gamma = 1F;
            this.formViewer.HQAnnotationRendering = true;
            this.formViewer.IgnoreDocumentResolution = false;
            this.formViewer.KeepDocumentPosition = false;
            this.formViewer.Location = new System.Drawing.Point(415, 6);
            this.formViewer.LockViewer = false;
            this.formViewer.MagnifierHeight = 90;
            this.formViewer.MagnifierWidth = 160;
            this.formViewer.MagnifierZoomX = 2F;
            this.formViewer.MagnifierZoomY = 2F;
            this.formViewer.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.formViewer.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.formViewer.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
            this.formViewer.Name = "formViewer";
            this.formViewer.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView;
            this.formViewer.PdfDisplayFormField = true;
            this.formViewer.PdfEnableFileLinks = true;
            this.formViewer.PdfEnableLinks = true;
            this.formViewer.PdfIncreaseTextContrast = false;
            this.formViewer.PdfShowDialogForPassword = true;
            this.formViewer.PdfShowOpenFileDialogForDecryption = true;
            this.formViewer.PdfVerifyDigitalCertificates = false;
            this.formViewer.RectBorderColor = System.Drawing.Color.Black;
            this.formViewer.RectBorderSize = 1;
            this.formViewer.RectIsEditable = true;
            this.formViewer.RegionsAreEditable = true;
            this.formViewer.RenderGdPictureAnnots = true;
            this.formViewer.ScrollBars = true;
            this.formViewer.ScrollLargeChange = ((short)(50));
            this.formViewer.ScrollSmallChange = ((short)(1));
            this.formViewer.SilentMode = true;
            this.formViewer.Size = new System.Drawing.Size(928, 522);
            this.formViewer.TabIndex = 0;
            this.formViewer.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.formViewer.Zoom = 1D;
            this.formViewer.ZoomCenterAtMousePosition = false;
            this.formViewer.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100;
            this.formViewer.ZoomStep = 25;
            this.formViewer.RegionEditedByUser += new GdPicture14.GdViewer.RegionEditedByUserEventHandler(this.formViewer_RegionEditedByUser);
            this.formViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formViewer_MouseUp);
            // 
            // addFieldsPanel
            // 
            this.addFieldsPanel.ColumnCount = 4;
            this.addFieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.addFieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.addFieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.addFieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.addFieldsPanel.Controls.Add(this.TableLayoutPanel10, 3, 0);
            this.addFieldsPanel.Controls.Add(this.Label1, 0, 0);
            this.addFieldsPanel.Controls.Add(this.Label2, 1, 0);
            this.addFieldsPanel.Controls.Add(this.TableLayoutPanel9, 2, 0);
            this.addFieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFieldsPanel.Location = new System.Drawing.Point(6, 59);
            this.addFieldsPanel.Name = "addFieldsPanel";
            this.addFieldsPanel.RowCount = 1;
            this.addFieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addFieldsPanel.Size = new System.Drawing.Size(1379, 37);
            this.addFieldsPanel.TabIndex = 3;
            this.addFieldsPanel.Visible = false;
            // 
            // TableLayoutPanel10
            // 
            this.TableLayoutPanel10.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.TableLayoutPanel10.ColumnCount = 2;
            this.TableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.TableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.TableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel10.Controls.Add(this.Label9, 0, 0);
            this.TableLayoutPanel10.Controls.Add(this.totalNumberOfFieldsLabel, 1, 0);
            this.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableLayoutPanel10.Location = new System.Drawing.Point(1035, 3);
            this.TableLayoutPanel10.Name = "TableLayoutPanel10";
            this.TableLayoutPanel10.RowCount = 1;
            this.TableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel10.Size = new System.Drawing.Size(338, 31);
            this.TableLayoutPanel10.TabIndex = 9;
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(6, 7);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(155, 17);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Total Number of Fields:";
            // 
            // totalNumberOfFieldsLabel
            // 
            this.totalNumberOfFieldsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalNumberOfFieldsLabel.AutoSize = true;
            this.totalNumberOfFieldsLabel.Location = new System.Drawing.Point(182, 7);
            this.totalNumberOfFieldsLabel.Name = "totalNumberOfFieldsLabel";
            this.totalNumberOfFieldsLabel.Size = new System.Drawing.Size(16, 17);
            this.totalNumberOfFieldsLabel.TabIndex = 5;
            this.totalNumberOfFieldsLabel.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 17);
            this.Label1.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(347, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 17);
            this.Label2.TabIndex = 1;
            // 
            // TableLayoutPanel9
            // 
            this.TableLayoutPanel9.ColumnCount = 2;
            this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel9.Controls.Add(this.addMultipleFieldsButton, 0, 0);
            this.TableLayoutPanel9.Controls.Add(this.addSingleFieldButon, 0, 0);
            this.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel9.Location = new System.Drawing.Point(691, 3);
            this.TableLayoutPanel9.Name = "TableLayoutPanel9";
            this.TableLayoutPanel9.RowCount = 1;
            this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel9.Size = new System.Drawing.Size(338, 31);
            this.TableLayoutPanel9.TabIndex = 2;
            // 
            // addMultipleFieldsButton
            // 
            this.addMultipleFieldsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMultipleFieldsButton.Location = new System.Drawing.Point(172, 3);
            this.addMultipleFieldsButton.Name = "addMultipleFieldsButton";
            this.addMultipleFieldsButton.Size = new System.Drawing.Size(163, 25);
            this.addMultipleFieldsButton.TabIndex = 6;
            this.addMultipleFieldsButton.Text = "Add Multiple Fields";
            this.addMultipleFieldsButton.UseVisualStyleBackColor = true;
            this.addMultipleFieldsButton.Click += new System.EventHandler(this.addMultipleFieldsButton_Click);
            // 
            // addSingleFieldButon
            // 
            this.addSingleFieldButon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addSingleFieldButon.Location = new System.Drawing.Point(3, 3);
            this.addSingleFieldButon.Name = "addSingleFieldButon";
            this.addSingleFieldButon.Size = new System.Drawing.Size(163, 25);
            this.addSingleFieldButon.TabIndex = 5;
            this.addSingleFieldButon.Text = "Add Single Field";
            this.addSingleFieldButon.UseVisualStyleBackColor = true;
            this.addSingleFieldButon.Click += new System.EventHandler(this.addSingleFieldButon_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // TableLayoutPanel7
            // 
            this.TableLayoutPanel7.ColumnCount = 4;
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel7.Controls.Add(this.Button1, 3, 0);
            this.TableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel7.Name = "TableLayoutPanel7";
            this.TableLayoutPanel7.RowCount = 1;
            this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.TableLayoutPanel7.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Teal;
            this.Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button1.Location = new System.Drawing.Point(153, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(44, 94);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "4. Draw Rectangles";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Visible = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Teal;
            this.Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button2.Location = new System.Drawing.Point(685, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(335, 8);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "3. Settings...";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Visible = false;
            // 
            // TableLayoutPanel8
            // 
            this.TableLayoutPanel8.ColumnCount = 4;
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel8.Controls.Add(this.Button3, 3, 0);
            this.TableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel8.Name = "TableLayoutPanel8";
            this.TableLayoutPanel8.RowCount = 1;
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel8.Size = new System.Drawing.Size(200, 100);
            this.TableLayoutPanel8.TabIndex = 0;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Teal;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button3.Location = new System.Drawing.Point(153, 3);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(44, 94);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "4. Draw Rectangles";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Visible = false;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Teal;
            this.Button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button4.Location = new System.Drawing.Point(685, 3);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(335, 8);
            this.Button4.TabIndex = 2;
            this.Button4.Text = "3. Settings...";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1562, 750);
            this.Controls.Add(this.TableLayoutPanelData);
            this.Controls.Add(this.TableLayoutPanelButtons);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Form1";
            this.Text = "GdPicture.NET - Forms Processing Demo  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.TableLayoutPanelButtons.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.processFormsPanel.ResumeLayout(false);
            this.processFormsTableLayoutPanel5.ResumeLayout(false);
            this.TableLayoutPanel5.ResumeLayout(false);
            this.TableLayoutPanel6.ResumeLayout(false);
            this.formSetUpPanel.ResumeLayout(false);
            this.formSetUpTableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.settingsTableLayoutPanel.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TableLayoutPanel4.ResumeLayout(false);
            this.TableLayoutPanel4.PerformLayout();
            this.confidenceGroup.ResumeLayout(false);
            this.confidenceGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minConfidenceValue)).EndInit();
            this.addFieldsPanel.ResumeLayout(false);
            this.addFieldsPanel.PerformLayout();
            this.TableLayoutPanel10.ResumeLayout(false);
            this.TableLayoutPanel10.PerformLayout();
            this.TableLayoutPanel9.ResumeLayout(false);
            this.TableLayoutPanel7.ResumeLayout(false);
            this.TableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanelButtons;
		internal System.Windows.Forms.ToolStripMenuItem ZToolStripMenuItem;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button processFormsButton;
		internal System.Windows.Forms.Button formSetUpButton;
		internal System.Windows.Forms.ToolStripMenuItem NewProjectToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CloseProjectToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanelData;
		internal System.Windows.Forms.Panel formSetUpPanel;
		internal System.Windows.Forms.TableLayoutPanel formSetUpTableLayoutPanel;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
		internal System.Windows.Forms.Button drawRectanglesButton;
		internal System.Windows.Forms.Button addFieldsButton;
		internal System.Windows.Forms.Button selectAnchorButton;
		internal System.Windows.Forms.Button loadFormButton;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
		internal System.Windows.Forms.TableLayoutPanel settingsTableLayoutPanel;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.CheckBox hasCharacter;
		internal System.Windows.Forms.RadioButton oval;
		internal System.Windows.Forms.RadioButton checkORCircle;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
		internal System.Windows.Forms.CheckBox useConfidence;
		internal System.Windows.Forms.GroupBox confidenceGroup;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.HScrollBar sensitivity;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.NumericUpDown minConfidenceValue;
		internal GdPicture14.GdViewer formViewer;
		internal System.Windows.Forms.Label sensitivityValue;
		internal System.Windows.Forms.Panel processFormsPanel;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel5;
		internal System.Windows.Forms.ListBox ListBox1;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel6;
		internal System.Windows.Forms.Button omrImagesButton;
		internal System.Windows.Forms.Button clearImagesButton;
		internal System.Windows.Forms.Button loadImagesButton;
		internal GdPicture14.GdViewer imagesViewer;
		internal System.Windows.Forms.RichTextBox resultsTextBox;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel7;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel8;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.TableLayoutPanel addFieldsPanel;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel9;
		internal System.Windows.Forms.Button addMultipleFieldsButton;
		internal System.Windows.Forms.Button addSingleFieldButon;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel10;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label totalNumberOfFieldsLabel;
		internal System.Windows.Forms.TableLayoutPanel processFormsTableLayoutPanel5;
		
	}
	
}
