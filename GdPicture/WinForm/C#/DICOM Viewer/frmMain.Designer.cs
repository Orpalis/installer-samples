using System.Windows.Forms;

namespace GdPicture_DICOM_Viewer
{
	public partial class frmMain : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				GdViewer1.CloseDocument();
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoFirstPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoPreviousPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoNextPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoLastPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MouseModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThumbnailsSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Small64X64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Medium128X128ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Large256256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LevelWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableWindowLevelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ThumbnailEx1 = new GdPicture14.ThumbnailEx();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.PageToolStripMenuItem,
            this.RotationToolStripMenuItem,
            this.MouseModeToolStripMenuItem,
            this.animateToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1371, 28);
            this.MenuStrip1.TabIndex = 4;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.OpenDirectoryToolStripMenuItem,
            this.ToolStripMenuItem10,
            this.ToolStripMenuProperties,
            this.CloseToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.OpenToolStripMenuItem.Text = "Open Single File...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // OpenDirectoryToolStripMenuItem
            // 
            this.OpenDirectoryToolStripMenuItem.Name = "OpenDirectoryToolStripMenuItem";
            this.OpenDirectoryToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.OpenDirectoryToolStripMenuItem.Text = "Open Directory...";
            this.OpenDirectoryToolStripMenuItem.Click += new System.EventHandler(this.OpenDirectoryToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem10
            // 
            this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
            this.ToolStripMenuItem10.Size = new System.Drawing.Size(201, 26);
            this.ToolStripMenuItem10.Text = "Print...";
            this.ToolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
            // 
            // ToolStripMenuProperties
            // 
            this.ToolStripMenuProperties.Name = "ToolStripMenuProperties";
            this.ToolStripMenuProperties.Size = new System.Drawing.Size(201, 26);
            this.ToolStripMenuProperties.Text = "Properties...";
            this.ToolStripMenuProperties.Click += new System.EventHandler(this.ToolStripMenuItem11_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // PageToolStripMenuItem
            // 
            this.PageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GotoFirstPageToolStripMenuItem,
            this.GotoPreviousPageToolStripMenuItem,
            this.GotoNextPageToolStripMenuItem,
            this.GotoLastPageToolStripMenuItem});
            this.PageToolStripMenuItem.Name = "PageToolStripMenuItem";
            this.PageToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.PageToolStripMenuItem.Text = "Frames";
            // 
            // GotoFirstPageToolStripMenuItem
            // 
            this.GotoFirstPageToolStripMenuItem.Name = "GotoFirstPageToolStripMenuItem";
            this.GotoFirstPageToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.GotoFirstPageToolStripMenuItem.Text = "Goto First Frame";
            this.GotoFirstPageToolStripMenuItem.Click += new System.EventHandler(this.GotoFirstPageToolStripMenuItem_Click);
            // 
            // GotoPreviousPageToolStripMenuItem
            // 
            this.GotoPreviousPageToolStripMenuItem.Name = "GotoPreviousPageToolStripMenuItem";
            this.GotoPreviousPageToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.GotoPreviousPageToolStripMenuItem.Text = "Goto Previous Frame";
            this.GotoPreviousPageToolStripMenuItem.Click += new System.EventHandler(this.GotoPreviousPageToolStripMenuItem_Click);
            // 
            // GotoNextPageToolStripMenuItem
            // 
            this.GotoNextPageToolStripMenuItem.Name = "GotoNextPageToolStripMenuItem";
            this.GotoNextPageToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.GotoNextPageToolStripMenuItem.Text = "Goto Next Frame";
            this.GotoNextPageToolStripMenuItem.Click += new System.EventHandler(this.GotoNextPageToolStripMenuItem_Click);
            // 
            // GotoLastPageToolStripMenuItem
            // 
            this.GotoLastPageToolStripMenuItem.Name = "GotoLastPageToolStripMenuItem";
            this.GotoLastPageToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.GotoLastPageToolStripMenuItem.Text = "Goto Last Frame";
            this.GotoLastPageToolStripMenuItem.Click += new System.EventHandler(this.GotoLastPageToolStripMenuItem_Click);
            // 
            // RotationToolStripMenuItem
            // 
            this.RotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rotate90ToolStripMenuItem,
            this.Rotate180ToolStripMenuItem,
            this.Rotate270ToolStripMenuItem,
            this.FlipXToolStripMenuItem,
            this.FlipYToolStripMenuItem});
            this.RotationToolStripMenuItem.Name = "RotationToolStripMenuItem";
            this.RotationToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.RotationToolStripMenuItem.Text = "Rotation";
            // 
            // Rotate90ToolStripMenuItem
            // 
            this.Rotate90ToolStripMenuItem.Name = "Rotate90ToolStripMenuItem";
            this.Rotate90ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.Rotate90ToolStripMenuItem.Text = "Rotate 90°";
            this.Rotate90ToolStripMenuItem.Click += new System.EventHandler(this.Rotate90ToolStripMenuItem_Click);
            // 
            // Rotate180ToolStripMenuItem
            // 
            this.Rotate180ToolStripMenuItem.Name = "Rotate180ToolStripMenuItem";
            this.Rotate180ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.Rotate180ToolStripMenuItem.Text = "Rotate 180°";
            this.Rotate180ToolStripMenuItem.Click += new System.EventHandler(this.Rotate180ToolStripMenuItem_Click);
            // 
            // Rotate270ToolStripMenuItem
            // 
            this.Rotate270ToolStripMenuItem.Name = "Rotate270ToolStripMenuItem";
            this.Rotate270ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.Rotate270ToolStripMenuItem.Text = "Rotate 270°";
            this.Rotate270ToolStripMenuItem.Click += new System.EventHandler(this.Rotate270ToolStripMenuItem_Click);
            // 
            // FlipXToolStripMenuItem
            // 
            this.FlipXToolStripMenuItem.Name = "FlipXToolStripMenuItem";
            this.FlipXToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.FlipXToolStripMenuItem.Text = "Flip X";
            this.FlipXToolStripMenuItem.Click += new System.EventHandler(this.FlipXToolStripMenuItem_Click);
            // 
            // FlipYToolStripMenuItem
            // 
            this.FlipYToolStripMenuItem.Name = "FlipYToolStripMenuItem";
            this.FlipYToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.FlipYToolStripMenuItem.Text = "Flip Y";
            this.FlipYToolStripMenuItem.Click += new System.EventHandler(this.FlipYToolStripMenuItem_Click);
            // 
            // MouseModeToolStripMenuItem
            // 
            this.MouseModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThumbnailsSizeToolStripMenuItem,
            this.LevelWindowsToolStripMenuItem,
            this.EnableWindowLevelingToolStripMenuItem});
            this.MouseModeToolStripMenuItem.Name = "MouseModeToolStripMenuItem";
            this.MouseModeToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.MouseModeToolStripMenuItem.Text = "Options";
            // 
            // ThumbnailsSizeToolStripMenuItem
            // 
            this.ThumbnailsSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Small64X64ToolStripMenuItem,
            this.Medium128X128ToolStripMenuItem,
            this.Large256256ToolStripMenuItem});
            this.ThumbnailsSizeToolStripMenuItem.Name = "ThumbnailsSizeToolStripMenuItem";
            this.ThumbnailsSizeToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.ThumbnailsSizeToolStripMenuItem.Text = "Thumbnails Size";
            // 
            // Small64X64ToolStripMenuItem
            // 
            this.Small64X64ToolStripMenuItem.Name = "Small64X64ToolStripMenuItem";
            this.Small64X64ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Small64X64ToolStripMenuItem.Text = "Small (64 x 64)";
            this.Small64X64ToolStripMenuItem.Click += new System.EventHandler(this.Small64X64ToolStripMenuItem_Click);
            // 
            // Medium128X128ToolStripMenuItem
            // 
            this.Medium128X128ToolStripMenuItem.Name = "Medium128X128ToolStripMenuItem";
            this.Medium128X128ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Medium128X128ToolStripMenuItem.Text = "Medium (128 x 128)";
            this.Medium128X128ToolStripMenuItem.Click += new System.EventHandler(this.Medium128X128ToolStripMenuItem_Click);
            // 
            // Large256256ToolStripMenuItem
            // 
            this.Large256256ToolStripMenuItem.Checked = true;
            this.Large256256ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Large256256ToolStripMenuItem.Name = "Large256256ToolStripMenuItem";
            this.Large256256ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Large256256ToolStripMenuItem.Text = "Large (256 * 256)";
            this.Large256256ToolStripMenuItem.Click += new System.EventHandler(this.Large256256ToolStripMenuItem_Click);
            // 
            // LevelWindowsToolStripMenuItem
            // 
            this.LevelWindowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreDefaultToolStripMenuItem});
            this.LevelWindowsToolStripMenuItem.Name = "LevelWindowsToolStripMenuItem";
            this.LevelWindowsToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.LevelWindowsToolStripMenuItem.Text = "Level Window";
            // 
            // RestoreDefaultToolStripMenuItem
            // 
            this.RestoreDefaultToolStripMenuItem.Name = "RestoreDefaultToolStripMenuItem";
            this.RestoreDefaultToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.RestoreDefaultToolStripMenuItem.Text = "Restore Default";
            this.RestoreDefaultToolStripMenuItem.Click += new System.EventHandler(this.RestoreDefaultToolStripMenuItem_Click);
            // 
            // EnableWindowLevelingToolStripMenuItem
            // 
            this.EnableWindowLevelingToolStripMenuItem.Checked = true;
            this.EnableWindowLevelingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableWindowLevelingToolStripMenuItem.Name = "EnableWindowLevelingToolStripMenuItem";
            this.EnableWindowLevelingToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.EnableWindowLevelingToolStripMenuItem.Text = "Enable Window Leveling";
            this.EnableWindowLevelingToolStripMenuItem.Click += new System.EventHandler(this.EnableWindowLevelingToolStripMenuItem_Click);
            // 
            // animateToolStripMenuItem
            // 
            this.animateToolStripMenuItem.Name = "animateToolStripMenuItem";
            this.animateToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.animateToolStripMenuItem.Text = "Animate";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 678);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1371, 25);
            this.StatusStrip1.TabIndex = 0;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(75, 20);
            this.ToolStripStatusLabel1.Text = "Welcome!";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 28);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.ThumbnailEx1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.GdViewer1);
            this.SplitContainer1.Size = new System.Drawing.Size(1371, 650);
            this.SplitContainer1.SplitterDistance = 204;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 9;
            // 
            // ThumbnailEx1
            // 
            this.ThumbnailEx1.AllowDropFiles = false;
            this.ThumbnailEx1.AllowMoveItems = false;
            this.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control;
            this.ThumbnailEx1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.ThumbnailEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThumbnailEx1.MultiSelect = false;
            this.ThumbnailEx1.Name = "ThumbnailEx1";
            this.ThumbnailEx1.OwnDrop = false;
            this.ThumbnailEx1.PauseThumbsLoading = false;
            this.ThumbnailEx1.PdfIncreaseTextContrast = false;
            this.ThumbnailEx1.PreloadAllItems = true;
            this.ThumbnailEx1.RotateExif = true;
            this.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ThumbnailEx1.ShowText = true;
            this.ThumbnailEx1.Size = new System.Drawing.Size(204, 650);
            this.ThumbnailEx1.TabIndex = 1;
            this.ThumbnailEx1.TextMarginLeft = 0;
            this.ThumbnailEx1.TextMarginTop = 0;
            this.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical;
            this.ThumbnailEx1.ThumbnailBorder = true;
            this.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Black;
            this.ThumbnailEx1.ThumbnailSize = new System.Drawing.Size(256, 256);
            this.ThumbnailEx1.ThumbnailSpacing = new System.Drawing.Size(0, 0);
            this.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            this.ThumbnailEx1.ItemSelectionChanged += new GdPicture14.ThumbnailEx.ItemSelectionChangedEventHandler(this.ThumbnailEx1_ItemSelectionChanged);
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDropFile = false;
            this.GdViewer1.AnimateGIF = false;
            this.GdViewer1.AnnotationDropShadow = true;
            this.GdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.GdViewer1.AnnotationResizeRotateHandlesScale = 1F;
            this.GdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewer1.BackColor = System.Drawing.Color.Black;
            this.GdViewer1.BackgroundImage = null;
            this.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GdViewer1.ContinuousViewMode = false;
            this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.GdViewer1.DisplayQualityAuto = false;
            this.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer1.EnableDeferredPainting = true;
            this.GdViewer1.EnabledProgressBar = true;
            this.GdViewer1.EnableICM = false;
            this.GdViewer1.EnableMenu = false;
            this.GdViewer1.EnableMouseWheel = true;
            this.GdViewer1.EnableTextSelection = true;
            this.GdViewer1.ForceScrollBars = false;
            this.GdViewer1.ForeColor = System.Drawing.Color.Black;
            this.GdViewer1.Gamma = 1F;
            this.GdViewer1.HQAnnotationRendering = true;
            this.GdViewer1.IgnoreDocumentResolution = false;
            this.GdViewer1.KeepDocumentPosition = true;
            this.GdViewer1.Location = new System.Drawing.Point(0, 0);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
            this.GdViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModeDefault;
            this.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeVerticalScroll;
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
            this.GdViewer1.Size = new System.Drawing.Size(1162, 650);
            this.GdViewer1.TabIndex = 3;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            this.GdViewer1.PageDisplayed += new GdPicture14.GdViewer.PageDisplayedEventHandler(this.GdViewer1_PageDisplayed);
            this.GdViewer1.Paint += new System.Windows.Forms.PaintEventHandler(this.GdViewer1_Paint);
            this.GdViewer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GdViewer1_MouseMove);
            this.GdViewer1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.GdViewer1_MouseWheel);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 703);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "GdPicture.NET DICOM Viewer Sample  -  http://www.gdpicture.com";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem10;
		internal System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem PageToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem GotoFirstPageToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem GotoPreviousPageToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem GotoNextPageToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem GotoLastPageToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RotationToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem Rotate90ToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem Rotate180ToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem Rotate270ToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FlipXToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MouseModeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuProperties;
		internal System.Windows.Forms.ToolStripMenuItem ThumbnailsSizeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem Small64X64ToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem Medium128X128ToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem Large256256ToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OpenDirectoryToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FlipYToolStripMenuItem;
		internal System.Windows.Forms.StatusStrip StatusStrip1;
		internal System.Windows.Forms.SplitContainer SplitContainer1;
		internal GdPicture14.ThumbnailEx ThumbnailEx1;
		internal GdPicture14.GdViewer GdViewer1;
		internal System.Windows.Forms.ToolStripMenuItem LevelWindowsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem RestoreDefaultToolStripMenuItem;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripMenuItem EnableWindowLevelingToolStripMenuItem;
        private ToolStripMenuItem animateToolStripMenuItem;
	}
	
}
