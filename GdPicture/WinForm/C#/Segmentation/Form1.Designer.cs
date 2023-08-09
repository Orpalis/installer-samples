namespace Segmenter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreResolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.blocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paragraphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.chkShowBitmap = new System.Windows.Forms.ToolStripMenuItem();
            this.chkShowText = new System.Windows.Forms.ToolStripMenuItem();
            this.chkShowLines = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateRight90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLeft90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageEnhancementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticCleanupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.removePunchHolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseBlackBordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deskewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitonalDespeckleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleTo300DPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleTo200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bradleyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SegmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedComponents4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedComponents8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lKMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsImageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gdViewer1 = new GdPicture14.GdViewer();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.imageEnhancementToolStripMenuItem,
            this.SegmentationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ignoreResolutionToolStripMenuItem,
            this.toolStripSeparator1,
            this.blocksToolStripMenuItem,
            this.paragraphsToolStripMenuItem,
            this.textLinesToolStripMenuItem,
            this.wordsToolStripMenuItem,
            this.charactersToolStripMenuItem,
            this.toolStripMenuItem3,
            this.chkShowBitmap,
            this.chkShowText,
            this.chkShowLines});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom &in";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom &out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem2.Text = "&100%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ignoreResolutionToolStripMenuItem
            // 
            this.ignoreResolutionToolStripMenuItem.Name = "ignoreResolutionToolStripMenuItem";
            this.ignoreResolutionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ignoreResolutionToolStripMenuItem.Text = "100% (ignore resolution)";
            this.ignoreResolutionToolStripMenuItem.Click += new System.EventHandler(this.ignoreResolutionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // blocksToolStripMenuItem
            // 
            this.blocksToolStripMenuItem.Checked = true;
            this.blocksToolStripMenuItem.CheckOnClick = true;
            this.blocksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blocksToolStripMenuItem.Name = "blocksToolStripMenuItem";
            this.blocksToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.blocksToolStripMenuItem.Text = "&Blocks";
            this.blocksToolStripMenuItem.Click += new System.EventHandler(this.blocksToolStripMenuItem_Click);
            // 
            // paragraphsToolStripMenuItem
            // 
            this.paragraphsToolStripMenuItem.Checked = true;
            this.paragraphsToolStripMenuItem.CheckOnClick = true;
            this.paragraphsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.paragraphsToolStripMenuItem.Name = "paragraphsToolStripMenuItem";
            this.paragraphsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.paragraphsToolStripMenuItem.Text = "&Paragraphs";
            this.paragraphsToolStripMenuItem.Click += new System.EventHandler(this.paragraphsToolStripMenuItem_Click);
            // 
            // textLinesToolStripMenuItem
            // 
            this.textLinesToolStripMenuItem.Checked = true;
            this.textLinesToolStripMenuItem.CheckOnClick = true;
            this.textLinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.textLinesToolStripMenuItem.Name = "textLinesToolStripMenuItem";
            this.textLinesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.textLinesToolStripMenuItem.Text = "Text &lines";
            this.textLinesToolStripMenuItem.Click += new System.EventHandler(this.textLinesToolStripMenuItem_Click);
            // 
            // wordsToolStripMenuItem
            // 
            this.wordsToolStripMenuItem.Checked = true;
            this.wordsToolStripMenuItem.CheckOnClick = true;
            this.wordsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem";
            this.wordsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.wordsToolStripMenuItem.Text = "&Words";
            this.wordsToolStripMenuItem.Click += new System.EventHandler(this.wordsToolStripMenuItem_Click);
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Checked = true;
            this.charactersToolStripMenuItem.CheckOnClick = true;
            this.charactersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.charactersToolStripMenuItem.Text = "&Characters";
            this.charactersToolStripMenuItem.Click += new System.EventHandler(this.charactersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(200, 6);
            // 
            // chkShowBitmap
            // 
            this.chkShowBitmap.Checked = true;
            this.chkShowBitmap.CheckOnClick = true;
            this.chkShowBitmap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowBitmap.Name = "chkShowBitmap";
            this.chkShowBitmap.Size = new System.Drawing.Size(203, 22);
            this.chkShowBitmap.Text = "Bitmap";
            this.chkShowBitmap.Click += new System.EventHandler(this.chkShowBitmap_Click);
            // 
            // chkShowText
            // 
            this.chkShowText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkShowText.Checked = true;
            this.chkShowText.CheckOnClick = true;
            this.chkShowText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowText.Name = "chkShowText";
            this.chkShowText.Size = new System.Drawing.Size(203, 22);
            this.chkShowText.Text = "Text";
            this.chkShowText.Click += new System.EventHandler(this.chkShowText_Click);
            // 
            // chkShowLines
            // 
            this.chkShowLines.Checked = true;
            this.chkShowLines.CheckOnClick = true;
            this.chkShowLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowLines.Name = "chkShowLines";
            this.chkShowLines.Size = new System.Drawing.Size(203, 22);
            this.chkShowLines.Text = "Lines";
            this.chkShowLines.Click += new System.EventHandler(this.chkShowLines_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateRight90ToolStripMenuItem,
            this.rotateLeft90ToolStripMenuItem,
            this.rotate180ToolStripMenuItem});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.rotateToolStripMenuItem.Text = "&Rotate";
            // 
            // rotateRight90ToolStripMenuItem
            // 
            this.rotateRight90ToolStripMenuItem.Name = "rotateRight90ToolStripMenuItem";
            this.rotateRight90ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.rotateRight90ToolStripMenuItem.Text = "Rotate &right 90°";
            this.rotateRight90ToolStripMenuItem.Click += new System.EventHandler(this.rotateRight90ToolStripMenuItem_Click);
            // 
            // rotateLeft90ToolStripMenuItem
            // 
            this.rotateLeft90ToolStripMenuItem.Name = "rotateLeft90ToolStripMenuItem";
            this.rotateLeft90ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.rotateLeft90ToolStripMenuItem.Text = "Rotate &left 90°";
            this.rotateLeft90ToolStripMenuItem.Click += new System.EventHandler(this.rotateLeft90ToolStripMenuItem_Click);
            // 
            // rotate180ToolStripMenuItem
            // 
            this.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            this.rotate180ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.rotate180ToolStripMenuItem.Text = "Rotate &180°";
            this.rotate180ToolStripMenuItem.Click += new System.EventHandler(this.rotate180ToolStripMenuItem_Click);
            // 
            // imageEnhancementToolStripMenuItem
            // 
            this.imageEnhancementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automaticCleanupToolStripMenuItem,
            this.toolStripMenuItem1,
            this.removePunchHolesToolStripMenuItem,
            this.eraseBlackBordersToolStripMenuItem,
            this.deskewToolStripMenuItem,
            this.bitonalDespeckleToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.scaleTo300DPIToolStripMenuItem,
            this.scaleTo200ToolStripMenuItem,
            this.thresholdToolStripMenuItem});
            this.imageEnhancementToolStripMenuItem.Name = "imageEnhancementToolStripMenuItem";
            this.imageEnhancementToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.imageEnhancementToolStripMenuItem.Text = "Image &Enhancement";
            // 
            // automaticCleanupToolStripMenuItem
            // 
            this.automaticCleanupToolStripMenuItem.Name = "automaticCleanupToolStripMenuItem";
            this.automaticCleanupToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.automaticCleanupToolStripMenuItem.Text = "Automatic Document Clean-up";
            this.automaticCleanupToolStripMenuItem.Click += new System.EventHandler(this.automaticCleanupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
            // 
            // removePunchHolesToolStripMenuItem
            // 
            this.removePunchHolesToolStripMenuItem.Name = "removePunchHolesToolStripMenuItem";
            this.removePunchHolesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.removePunchHolesToolStripMenuItem.Text = "Remove Punch Holes";
            this.removePunchHolesToolStripMenuItem.Click += new System.EventHandler(this.removePunchHolesToolStripMenuItem_Click);
            // 
            // eraseBlackBordersToolStripMenuItem
            // 
            this.eraseBlackBordersToolStripMenuItem.Name = "eraseBlackBordersToolStripMenuItem";
            this.eraseBlackBordersToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.eraseBlackBordersToolStripMenuItem.Text = "Erase Black Borders";
            this.eraseBlackBordersToolStripMenuItem.Click += new System.EventHandler(this.eraseBlackBordersToolStripMenuItem_Click);
            // 
            // deskewToolStripMenuItem
            // 
            this.deskewToolStripMenuItem.Name = "deskewToolStripMenuItem";
            this.deskewToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.deskewToolStripMenuItem.Text = "Automatic Deskew";
            this.deskewToolStripMenuItem.Click += new System.EventHandler(this.deskewToolStripMenuItem_Click);
            // 
            // bitonalDespeckleToolStripMenuItem
            // 
            this.bitonalDespeckleToolStripMenuItem.Name = "bitonalDespeckleToolStripMenuItem";
            this.bitonalDespeckleToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.bitonalDespeckleToolStripMenuItem.Text = "Bitonal Despeckle";
            this.bitonalDespeckleToolStripMenuItem.Click += new System.EventHandler(this.bitonalDespeckleToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.medianToolStripMenuItem.Text = "Median ";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // scaleTo300DPIToolStripMenuItem
            // 
            this.scaleTo300DPIToolStripMenuItem.Name = "scaleTo300DPIToolStripMenuItem";
            this.scaleTo300DPIToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.scaleTo300DPIToolStripMenuItem.Text = "Scale to 300 DPI";
            this.scaleTo300DPIToolStripMenuItem.Click += new System.EventHandler(this.scaleTo300DPIToolStripMenuItem_Click);
            // 
            // scaleTo200ToolStripMenuItem
            // 
            this.scaleTo200ToolStripMenuItem.Name = "scaleTo200ToolStripMenuItem";
            this.scaleTo200ToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.scaleTo200ToolStripMenuItem.Text = "Scale to 200 %";
            this.scaleTo200ToolStripMenuItem.Click += new System.EventHandler(this.scaleTo200ToolStripMenuItem_Click);
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvolaToolStripMenuItem,
            this.otsuToolStripMenuItem,
            this.bradleyToolStripMenuItem,
            this.wanToolStripMenuItem});
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.thresholdToolStripMenuItem.Text = "Threshold";
            // 
            // sauvolaToolStripMenuItem
            // 
            this.sauvolaToolStripMenuItem.Name = "sauvolaToolStripMenuItem";
            this.sauvolaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sauvolaToolStripMenuItem.Text = "Sauvola";
            this.sauvolaToolStripMenuItem.Click += new System.EventHandler(this.sauvolaToolStripMenuItem_Click);
            // 
            // otsuToolStripMenuItem
            // 
            this.otsuToolStripMenuItem.Name = "otsuToolStripMenuItem";
            this.otsuToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.otsuToolStripMenuItem.Text = "Otsu";
            this.otsuToolStripMenuItem.Click += new System.EventHandler(this.otsuToolStripMenuItem_Click);
            // 
            // bradleyToolStripMenuItem
            // 
            this.bradleyToolStripMenuItem.Name = "bradleyToolStripMenuItem";
            this.bradleyToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.bradleyToolStripMenuItem.Text = "Bradley";
            this.bradleyToolStripMenuItem.Click += new System.EventHandler(this.bradleyToolStripMenuItem_Click);
            // 
            // wanToolStripMenuItem
            // 
            this.wanToolStripMenuItem.Name = "wanToolStripMenuItem";
            this.wanToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.wanToolStripMenuItem.Text = "Wan";
            this.wanToolStripMenuItem.Click += new System.EventHandler(this.wanToolStripMenuItem_Click);
            // 
            // SegmentationToolStripMenuItem
            // 
            this.SegmentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.connectedComponents4ToolStripMenuItem,
            this.connectedComponents8ToolStripMenuItem,
            this.wordToolStripMenuItem});
            this.SegmentationToolStripMenuItem.Name = "SegmentationToolStripMenuItem";
            this.SegmentationToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.SegmentationToolStripMenuItem.Text = "Segmentation";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.readToolStripMenuItem.Text = "Page Layout";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // connectedComponents4ToolStripMenuItem
            // 
            this.connectedComponents4ToolStripMenuItem.Name = "connectedComponents4ToolStripMenuItem";
            this.connectedComponents4ToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.connectedComponents4ToolStripMenuItem.Text = "Connected components - 4";
            this.connectedComponents4ToolStripMenuItem.Click += new System.EventHandler(this.connectedComponents4ToolStripMenuItem_Click);
            // 
            // connectedComponents8ToolStripMenuItem
            // 
            this.connectedComponents8ToolStripMenuItem.Name = "connectedComponents8ToolStripMenuItem";
            this.connectedComponents8ToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.connectedComponents8ToolStripMenuItem.Text = "Connected components - 8";
            this.connectedComponents8ToolStripMenuItem.Click += new System.EventHandler(this.connectedComponents8ToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastMethodToolStripMenuItem,
            this.lKMethodToolStripMenuItem});
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.wordToolStripMenuItem.Text = "Word";
            // 
            // fastMethodToolStripMenuItem
            // 
            this.fastMethodToolStripMenuItem.Name = "fastMethodToolStripMenuItem";
            this.fastMethodToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fastMethodToolStripMenuItem.Text = "Fast method";
            this.fastMethodToolStripMenuItem.Click += new System.EventHandler(this.fastMethodToolStripMenuItem_Click);
            // 
            // lKMethodToolStripMenuItem
            // 
            this.lKMethodToolStripMenuItem.Name = "lKMethodToolStripMenuItem";
            this.lKMethodToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.lKMethodToolStripMenuItem.Text = "LK method";
            this.lKMethodToolStripMenuItem.Click += new System.EventHandler(this.lKMethodToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsImageInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(822, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsImageInfo
            // 
            this.tsImageInfo.Name = "tsImageInfo";
            this.tsImageInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.gdViewer1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 666);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // gdViewer1
            // 
            this.gdViewer1.AllowDropFile = false;
            this.gdViewer1.AnimateGIF = false;
            this.gdViewer1.AnnotationDropShadow = true;
            this.gdViewer1.AnnotationEnableMultiSelect = true;
            this.gdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.gdViewer1.AnnotationResizeRotateHandlesScale = 1F;
            this.gdViewer1.AnnotationSelectionLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.gdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.gdViewer1.BackColor = System.Drawing.Color.LightGray;
            this.gdViewer1.BackgroundImage = null;
            this.gdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gdViewer1.ClipAnnotsToPageBounds = true;
            this.gdViewer1.ClipRegionsToPageBounds = true;
            this.gdViewer1.ContinuousViewMode = true;
            this.gdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.gdViewer1.DisplayQualityAuto = false;
            this.gdViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.gdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.gdViewer1.DrawPageBorders = true;
            this.gdViewer1.EnableDeferredPainting = true;
            this.gdViewer1.EnabledProgressBar = true;
            this.gdViewer1.EnableICM = false;
            this.gdViewer1.EnableMenu = true;
            this.gdViewer1.EnableMouseWheel = true;
            this.gdViewer1.EnableTextSelection = true;
            this.gdViewer1.ForceScrollBars = false;
            this.gdViewer1.ForceTemporaryMode = false;
            this.gdViewer1.ForeColor = System.Drawing.Color.Black;
            this.gdViewer1.Gamma = 1F;
            this.gdViewer1.HQAnnotationRendering = true;
            this.gdViewer1.IgnoreDocumentResolution = false;
            this.gdViewer1.KeepDocumentPosition = false;
            this.gdViewer1.Location = new System.Drawing.Point(2, 2);
            this.gdViewer1.LockViewer = false;
            this.gdViewer1.MagnifierHeight = 90;
            this.gdViewer1.MagnifierWidth = 160;
            this.gdViewer1.MagnifierZoomX = 2F;
            this.gdViewer1.MagnifierZoomY = 2F;
            this.gdViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.gdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.gdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.gdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
            this.gdViewer1.Name = "gdViewer1";
            this.gdViewer1.PageBordersColor = System.Drawing.Color.Black;
            this.gdViewer1.PageBordersPenSize = 1;
            this.gdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.MultiplePagesView;
            this.gdViewer1.PdfDisplayFormField = true;
            this.gdViewer1.PdfEnableFileLinks = true;
            this.gdViewer1.PdfEnableLinks = true;
            this.gdViewer1.PdfIncreaseTextContrast = false;
            this.gdViewer1.PdfShowDialogForPassword = true;
            this.gdViewer1.PdfShowOpenFileDialogForDecryption = true;
            this.gdViewer1.PdfVerifyDigitalCertificates = false;
            this.gdViewer1.PreserveViewRotation = true;
            this.gdViewer1.RectBorderColor = System.Drawing.Color.Black;
            this.gdViewer1.RectBorderSize = 1;
            this.gdViewer1.RectIsEditable = true;
            this.gdViewer1.RegionsAreEditable = true;
            this.gdViewer1.RenderGdPictureAnnots = true;
            this.tableLayoutPanel1.SetRowSpan(this.gdViewer1, 3);
            this.gdViewer1.ScrollBars = true;
            this.gdViewer1.ScrollLargeChange = ((short)(50));
            this.gdViewer1.ScrollSmallChange = ((short)(1));
            this.gdViewer1.SilentMode = true;
            this.gdViewer1.Size = new System.Drawing.Size(818, 640);
            this.gdViewer1.TabIndex = 0;
            this.gdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.gdViewer1.Zoom = 1D;
            this.gdViewer1.ZoomCenterAtMousePosition = false;
            this.gdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100;
            this.gdViewer1.ZoomStep = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "GdPicture.NET Segmentation Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ignoreResolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateRight90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateLeft90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageEnhancementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deskewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SegmentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem blocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paragraphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem bitonalDespeckleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleTo300DPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleTo200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseBlackBordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePunchHolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticCleanupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bradleyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private GdPicture14.GdViewer gdViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsImageInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem chkShowBitmap;
        private System.Windows.Forms.ToolStripMenuItem chkShowText;
        private System.Windows.Forms.ToolStripMenuItem chkShowLines;
        private System.Windows.Forms.ToolStripMenuItem wanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedComponents4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedComponents8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lKMethodToolStripMenuItem;
    }
}

