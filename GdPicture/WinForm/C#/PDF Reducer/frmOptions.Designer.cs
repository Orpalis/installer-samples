namespace pdfReducer
{
    partial class frmOptions
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
            this.btReset = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabOutputFormat = new System.Windows.Forms.TabPage();
            this.chkKeepWriteAcessTime = new System.Windows.Forms.CheckBox();
            this.cmbPreferredVersion = new System.Windows.Forms.ComboBox();
            this.lbPreferredVersion = new System.Windows.Forms.Label();
            this.chkFastWebView = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabContentRemoval = new System.Windows.Forms.TabPage();
            this.chkRemoveHyperlinks = new System.Windows.Forms.CheckBox();
            this.chkPackDocument = new System.Windows.Forms.CheckBox();
            this.lbDocumentContent = new System.Windows.Forms.Label();
            this.lbInteractiveContent = new System.Windows.Forms.Label();
            this.chkRemoveEmbeddedFiles = new System.Windows.Forms.CheckBox();
            this.chkRemoveBookmarks = new System.Windows.Forms.CheckBox();
            this.chkRemoveFormFields = new System.Windows.Forms.CheckBox();
            this.chkRemoveAnnotations = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabBitmap = new System.Windows.Forms.TabPage();
            this.chkRecompressImages = new System.Windows.Forms.CheckBox();
            this.chkDownscaleImages = new System.Windows.Forms.CheckBox();
            this.chkJPEG2000 = new System.Windows.Forms.CheckBox();
            this.cmbImageQuality = new System.Windows.Forms.ComboBox();
            this.lbDpi = new System.Windows.Forms.Label();
            this.nuDownscaleResolution = new System.Windows.Forms.NumericUpDown();
            this.lbResolution = new System.Windows.Forms.Label();
            this.lbQuality = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabCompression = new System.Windows.Forms.TabPage();
            this.chkPackFonts = new System.Windows.Forms.CheckBox();
            this.lbFonts = new System.Windows.Forms.Label();
            this.lbDpi2 = new System.Windows.Forms.Label();
            this.nuBackgroundImageResolution = new System.Windows.Forms.NumericUpDown();
            this.lbBackgroundImageResolution = new System.Windows.Forms.Label();
            this.lbMrc = new System.Windows.Forms.Label();
            this.lbColorDetection = new System.Windows.Forms.Label();
            this.chkPreserveSmoothing = new System.Windows.Forms.CheckBox();
            this.chkUseMRC = new System.Windows.Forms.CheckBox();
            this.chkCharRepair = new System.Windows.Forms.CheckBox();
            this.chkEnableColorDetection = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.chkOnlyPdf = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabOutputFormat.SuspendLayout();
            this.tabContentRemoval.SuspendLayout();
            this.tabBitmap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownscaleResolution)).BeginInit();
            this.tabCompression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuBackgroundImageResolution)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btReset
            // 
            this.btReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btReset.Location = new System.Drawing.Point(296, 252);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(103, 31);
            this.btReset.TabIndex = 8;
            this.btReset.Text = "Reset to default";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btApply
            // 
            this.btApply.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btApply.Location = new System.Drawing.Point(405, 252);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(90, 31);
            this.btApply.TabIndex = 7;
            this.btApply.Text = "Apply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(3, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 1);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // tabOutputFormat
            // 
            this.tabOutputFormat.Controls.Add(this.chkKeepWriteAcessTime);
            this.tabOutputFormat.Controls.Add(this.cmbPreferredVersion);
            this.tabOutputFormat.Controls.Add(this.lbPreferredVersion);
            this.tabOutputFormat.Controls.Add(this.chkFastWebView);
            this.tabOutputFormat.Controls.Add(this.panel5);
            this.tabOutputFormat.Location = new System.Drawing.Point(4, 22);
            this.tabOutputFormat.Name = "tabOutputFormat";
            this.tabOutputFormat.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutputFormat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabOutputFormat.Size = new System.Drawing.Size(486, 217);
            this.tabOutputFormat.TabIndex = 3;
            this.tabOutputFormat.Text = "Output Format";
            this.tabOutputFormat.UseVisualStyleBackColor = true;
            // 
            // chkKeepWriteAcessTime
            // 
            this.chkKeepWriteAcessTime.AutoSize = true;
            this.chkKeepWriteAcessTime.Location = new System.Drawing.Point(15, 63);
            this.chkKeepWriteAcessTime.Name = "chkKeepWriteAcessTime";
            this.chkKeepWriteAcessTime.Size = new System.Drawing.Size(184, 17);
            this.chkKeepWriteAcessTime.TabIndex = 4;
            this.chkKeepWriteAcessTime.Text = "Keep last access and edition time";
            this.chkKeepWriteAcessTime.UseVisualStyleBackColor = true;
            // 
            // cmbPreferredVersion
            // 
            this.cmbPreferredVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreferredVersion.FormattingEnabled = true;
            this.cmbPreferredVersion.Location = new System.Drawing.Point(108, 10);
            this.cmbPreferredVersion.Name = "cmbPreferredVersion";
            this.cmbPreferredVersion.Size = new System.Drawing.Size(100, 21);
            this.cmbPreferredVersion.TabIndex = 3;
            // 
            // lbPreferredVersion
            // 
            this.lbPreferredVersion.AutoSize = true;
            this.lbPreferredVersion.Location = new System.Drawing.Point(15, 15);
            this.lbPreferredVersion.Name = "lbPreferredVersion";
            this.lbPreferredVersion.Size = new System.Drawing.Size(90, 13);
            this.lbPreferredVersion.TabIndex = 2;
            this.lbPreferredVersion.Text = "Preferred version:";
            // 
            // chkFastWebView
            // 
            this.chkFastWebView.AutoSize = true;
            this.chkFastWebView.Location = new System.Drawing.Point(15, 40);
            this.chkFastWebView.Name = "chkFastWebView";
            this.chkFastWebView.Size = new System.Drawing.Size(127, 17);
            this.chkFastWebView.TabIndex = 1;
            this.chkFastWebView.Text = "Enable fast web view";
            this.chkFastWebView.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(480, 211);
            this.panel5.TabIndex = 18;
            // 
            // tabContentRemoval
            // 
            this.tabContentRemoval.Controls.Add(this.chkRemoveHyperlinks);
            this.tabContentRemoval.Controls.Add(this.chkPackDocument);
            this.tabContentRemoval.Controls.Add(this.lbDocumentContent);
            this.tabContentRemoval.Controls.Add(this.lbInteractiveContent);
            this.tabContentRemoval.Controls.Add(this.chkRemoveEmbeddedFiles);
            this.tabContentRemoval.Controls.Add(this.chkRemoveBookmarks);
            this.tabContentRemoval.Controls.Add(this.chkRemoveFormFields);
            this.tabContentRemoval.Controls.Add(this.chkRemoveAnnotations);
            this.tabContentRemoval.Controls.Add(this.panel4);
            this.tabContentRemoval.Location = new System.Drawing.Point(4, 22);
            this.tabContentRemoval.Name = "tabContentRemoval";
            this.tabContentRemoval.Padding = new System.Windows.Forms.Padding(3);
            this.tabContentRemoval.Size = new System.Drawing.Size(486, 217);
            this.tabContentRemoval.TabIndex = 4;
            this.tabContentRemoval.Text = "Content Removal";
            this.tabContentRemoval.UseVisualStyleBackColor = true;
            // 
            // chkRemoveHyperlinks
            // 
            this.chkRemoveHyperlinks.AutoSize = true;
            this.chkRemoveHyperlinks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkRemoveHyperlinks.Location = new System.Drawing.Point(35, 81);
            this.chkRemoveHyperlinks.Name = "chkRemoveHyperlinks";
            this.chkRemoveHyperlinks.Size = new System.Drawing.Size(116, 17);
            this.chkRemoveHyperlinks.TabIndex = 11;
            this.chkRemoveHyperlinks.Text = "Remove hyperlinks";
            this.chkRemoveHyperlinks.UseVisualStyleBackColor = true;
            // 
            // chkPackDocument
            // 
            this.chkPackDocument.AutoSize = true;
            this.chkPackDocument.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkPackDocument.Location = new System.Drawing.Point(35, 172);
            this.chkPackDocument.Name = "chkPackDocument";
            this.chkPackDocument.Size = new System.Drawing.Size(137, 17);
            this.chkPackDocument.TabIndex = 10;
            this.chkPackDocument.Text = "Discard unused objects";
            this.chkPackDocument.UseVisualStyleBackColor = true;
            // 
            // lbDocumentContent
            // 
            this.lbDocumentContent.AutoSize = true;
            this.lbDocumentContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDocumentContent.Location = new System.Drawing.Point(15, 106);
            this.lbDocumentContent.Name = "lbDocumentContent";
            this.lbDocumentContent.Size = new System.Drawing.Size(98, 13);
            this.lbDocumentContent.TabIndex = 9;
            this.lbDocumentContent.Text = "Document content:";
            // 
            // lbInteractiveContent
            // 
            this.lbInteractiveContent.AutoSize = true;
            this.lbInteractiveContent.Location = new System.Drawing.Point(15, 15);
            this.lbInteractiveContent.Name = "lbInteractiveContent";
            this.lbInteractiveContent.Size = new System.Drawing.Size(99, 13);
            this.lbInteractiveContent.TabIndex = 8;
            this.lbInteractiveContent.Text = "Interactive content:";
            // 
            // chkRemoveEmbeddedFiles
            // 
            this.chkRemoveEmbeddedFiles.AutoSize = true;
            this.chkRemoveEmbeddedFiles.Location = new System.Drawing.Point(35, 149);
            this.chkRemoveEmbeddedFiles.Name = "chkRemoveEmbeddedFiles";
            this.chkRemoveEmbeddedFiles.Size = new System.Drawing.Size(140, 17);
            this.chkRemoveEmbeddedFiles.TabIndex = 7;
            this.chkRemoveEmbeddedFiles.Text = "Remove embedded files";
            this.chkRemoveEmbeddedFiles.UseVisualStyleBackColor = true;
            // 
            // chkRemoveBookmarks
            // 
            this.chkRemoveBookmarks.AutoSize = true;
            this.chkRemoveBookmarks.Location = new System.Drawing.Point(35, 126);
            this.chkRemoveBookmarks.Name = "chkRemoveBookmarks";
            this.chkRemoveBookmarks.Size = new System.Drawing.Size(121, 17);
            this.chkRemoveBookmarks.TabIndex = 6;
            this.chkRemoveBookmarks.Text = "Remove bookmarks";
            this.chkRemoveBookmarks.UseVisualStyleBackColor = true;
            // 
            // chkRemoveFormFields
            // 
            this.chkRemoveFormFields.AutoSize = true;
            this.chkRemoveFormFields.Location = new System.Drawing.Point(35, 35);
            this.chkRemoveFormFields.Name = "chkRemoveFormFields";
            this.chkRemoveFormFields.Size = new System.Drawing.Size(113, 17);
            this.chkRemoveFormFields.TabIndex = 4;
            this.chkRemoveFormFields.Text = "Remove formfields";
            this.chkRemoveFormFields.UseVisualStyleBackColor = true;
            // 
            // chkRemoveAnnotations
            // 
            this.chkRemoveAnnotations.AutoSize = true;
            this.chkRemoveAnnotations.Location = new System.Drawing.Point(35, 58);
            this.chkRemoveAnnotations.Name = "chkRemoveAnnotations";
            this.chkRemoveAnnotations.Size = new System.Drawing.Size(124, 17);
            this.chkRemoveAnnotations.TabIndex = 5;
            this.chkRemoveAnnotations.Text = "Remove annotations";
            this.chkRemoveAnnotations.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(480, 211);
            this.panel4.TabIndex = 18;
            // 
            // tabBitmap
            // 
            this.tabBitmap.Controls.Add(this.chkRecompressImages);
            this.tabBitmap.Controls.Add(this.chkDownscaleImages);
            this.tabBitmap.Controls.Add(this.chkJPEG2000);
            this.tabBitmap.Controls.Add(this.cmbImageQuality);
            this.tabBitmap.Controls.Add(this.lbDpi);
            this.tabBitmap.Controls.Add(this.nuDownscaleResolution);
            this.tabBitmap.Controls.Add(this.lbResolution);
            this.tabBitmap.Controls.Add(this.lbQuality);
            this.tabBitmap.Controls.Add(this.panel3);
            this.tabBitmap.Location = new System.Drawing.Point(4, 22);
            this.tabBitmap.Name = "tabBitmap";
            this.tabBitmap.Padding = new System.Windows.Forms.Padding(3);
            this.tabBitmap.Size = new System.Drawing.Size(486, 217);
            this.tabBitmap.TabIndex = 2;
            this.tabBitmap.Text = "Images";
            this.tabBitmap.UseVisualStyleBackColor = true;
            // 
            // chkRecompressImages
            // 
            this.chkRecompressImages.AutoSize = true;
            this.chkRecompressImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkRecompressImages.Location = new System.Drawing.Point(15, 15);
            this.chkRecompressImages.Name = "chkRecompressImages";
            this.chkRecompressImages.Size = new System.Drawing.Size(121, 17);
            this.chkRecompressImages.TabIndex = 8;
            this.chkRecompressImages.Text = "Recompress images";
            this.chkRecompressImages.UseVisualStyleBackColor = true;
            this.chkRecompressImages.CheckedChanged += new System.EventHandler(this.chkRecompressImages_CheckedChanged);
            // 
            // chkDownscaleImages
            // 
            this.chkDownscaleImages.AutoSize = true;
            this.chkDownscaleImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkDownscaleImages.Location = new System.Drawing.Point(15, 85);
            this.chkDownscaleImages.Name = "chkDownscaleImages";
            this.chkDownscaleImages.Size = new System.Drawing.Size(115, 17);
            this.chkDownscaleImages.TabIndex = 7;
            this.chkDownscaleImages.Text = "Downscale images";
            this.chkDownscaleImages.UseVisualStyleBackColor = true;
            this.chkDownscaleImages.CheckedChanged += new System.EventHandler(this.chkDownscaleImages_CheckedChanged);
            // 
            // chkJPEG2000
            // 
            this.chkJPEG2000.AutoSize = true;
            this.chkJPEG2000.Location = new System.Drawing.Point(15, 62);
            this.chkJPEG2000.Name = "chkJPEG2000";
            this.chkJPEG2000.Size = new System.Drawing.Size(333, 17);
            this.chkJPEG2000.TabIndex = 6;
            this.chkJPEG2000.Text = "Enable JPEG2000 for high definition images (PDF 1.5 and higher)";
            this.chkJPEG2000.UseVisualStyleBackColor = true;
            // 
            // cmbImageQuality
            // 
            this.cmbImageQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageQuality.FormattingEnabled = true;
            this.cmbImageQuality.Location = new System.Drawing.Point(93, 35);
            this.cmbImageQuality.Name = "cmbImageQuality";
            this.cmbImageQuality.Size = new System.Drawing.Size(94, 21);
            this.cmbImageQuality.TabIndex = 5;
            // 
            // lbDpi
            // 
            this.lbDpi.AutoSize = true;
            this.lbDpi.Location = new System.Drawing.Point(185, 110);
            this.lbDpi.Name = "lbDpi";
            this.lbDpi.Size = new System.Drawing.Size(21, 13);
            this.lbDpi.TabIndex = 4;
            this.lbDpi.Text = "dpi";
            // 
            // nuDownscaleResolution
            // 
            this.nuDownscaleResolution.Location = new System.Drawing.Point(126, 105);
            this.nuDownscaleResolution.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nuDownscaleResolution.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuDownscaleResolution.Name = "nuDownscaleResolution";
            this.nuDownscaleResolution.Size = new System.Drawing.Size(50, 20);
            this.nuDownscaleResolution.TabIndex = 3;
            this.nuDownscaleResolution.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lbResolution
            // 
            this.lbResolution.AutoSize = true;
            this.lbResolution.Location = new System.Drawing.Point(12, 110);
            this.lbResolution.Name = "lbResolution";
            this.lbResolution.Size = new System.Drawing.Size(111, 13);
            this.lbResolution.TabIndex = 2;
            this.lbResolution.Text = "Downscale resolution:";
            // 
            // lbQuality
            // 
            this.lbQuality.AutoSize = true;
            this.lbQuality.Location = new System.Drawing.Point(12, 38);
            this.lbQuality.Name = "lbQuality";
            this.lbQuality.Size = new System.Drawing.Size(72, 13);
            this.lbQuality.TabIndex = 0;
            this.lbQuality.Text = "Image quality:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(480, 211);
            this.panel3.TabIndex = 18;
            // 
            // tabCompression
            // 
            this.tabCompression.Controls.Add(this.chkPackFonts);
            this.tabCompression.Controls.Add(this.lbFonts);
            this.tabCompression.Controls.Add(this.lbDpi2);
            this.tabCompression.Controls.Add(this.nuBackgroundImageResolution);
            this.tabCompression.Controls.Add(this.lbBackgroundImageResolution);
            this.tabCompression.Controls.Add(this.lbMrc);
            this.tabCompression.Controls.Add(this.lbColorDetection);
            this.tabCompression.Controls.Add(this.chkPreserveSmoothing);
            this.tabCompression.Controls.Add(this.chkUseMRC);
            this.tabCompression.Controls.Add(this.chkCharRepair);
            this.tabCompression.Controls.Add(this.chkEnableColorDetection);
            this.tabCompression.Controls.Add(this.panel2);
            this.tabCompression.Location = new System.Drawing.Point(4, 22);
            this.tabCompression.Name = "tabCompression";
            this.tabCompression.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompression.Size = new System.Drawing.Size(486, 217);
            this.tabCompression.TabIndex = 0;
            this.tabCompression.Text = "Compression";
            this.tabCompression.UseVisualStyleBackColor = true;
            // 
            // chkPackFonts
            // 
            this.chkPackFonts.AutoSize = true;
            this.chkPackFonts.Location = new System.Drawing.Point(35, 35);
            this.chkPackFonts.Name = "chkPackFonts";
            this.chkPackFonts.Size = new System.Drawing.Size(92, 17);
            this.chkPackFonts.TabIndex = 27;
            this.chkPackFonts.Text = "Optimize fonts";
            this.chkPackFonts.UseVisualStyleBackColor = true;
            // 
            // lbFonts
            // 
            this.lbFonts.AutoSize = true;
            this.lbFonts.Location = new System.Drawing.Point(15, 15);
            this.lbFonts.Name = "lbFonts";
            this.lbFonts.Size = new System.Drawing.Size(33, 13);
            this.lbFonts.TabIndex = 26;
            this.lbFonts.Text = "Fonts";
            // 
            // lbDpi2
            // 
            this.lbDpi2.AutoSize = true;
            this.lbDpi2.Location = new System.Drawing.Point(241, 186);
            this.lbDpi2.Name = "lbDpi2";
            this.lbDpi2.Size = new System.Drawing.Size(21, 13);
            this.lbDpi2.TabIndex = 25;
            this.lbDpi2.Text = "dpi";
            // 
            // nuBackgroundImageResolution
            // 
            this.nuBackgroundImageResolution.Location = new System.Drawing.Point(185, 184);
            this.nuBackgroundImageResolution.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nuBackgroundImageResolution.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuBackgroundImageResolution.Name = "nuBackgroundImageResolution";
            this.nuBackgroundImageResolution.Size = new System.Drawing.Size(50, 20);
            this.nuBackgroundImageResolution.TabIndex = 24;
            this.nuBackgroundImageResolution.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbBackgroundImageResolution
            // 
            this.lbBackgroundImageResolution.AutoSize = true;
            this.lbBackgroundImageResolution.Location = new System.Drawing.Point(32, 186);
            this.lbBackgroundImageResolution.Name = "lbBackgroundImageResolution";
            this.lbBackgroundImageResolution.Size = new System.Drawing.Size(141, 13);
            this.lbBackgroundImageResolution.TabIndex = 23;
            this.lbBackgroundImageResolution.Text = "Background layer resolution:";
            // 
            // lbMrc
            // 
            this.lbMrc.AutoSize = true;
            this.lbMrc.Location = new System.Drawing.Point(15, 125);
            this.lbMrc.Name = "lbMrc";
            this.lbMrc.Size = new System.Drawing.Size(145, 13);
            this.lbMrc.TabIndex = 19;
            this.lbMrc.Text = "MRC (Mixed Raster Content):";
            // 
            // lbColorDetection
            // 
            this.lbColorDetection.AutoSize = true;
            this.lbColorDetection.Location = new System.Drawing.Point(15, 60);
            this.lbColorDetection.Name = "lbColorDetection";
            this.lbColorDetection.Size = new System.Drawing.Size(81, 13);
            this.lbColorDetection.TabIndex = 18;
            this.lbColorDetection.Text = "Color detection:";
            // 
            // chkPreserveSmoothing
            // 
            this.chkPreserveSmoothing.AutoSize = true;
            this.chkPreserveSmoothing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkPreserveSmoothing.Location = new System.Drawing.Point(35, 166);
            this.chkPreserveSmoothing.Name = "chkPreserveSmoothing";
            this.chkPreserveSmoothing.Size = new System.Drawing.Size(119, 17);
            this.chkPreserveSmoothing.TabIndex = 17;
            this.chkPreserveSmoothing.Text = "Preserve smoothing";
            this.chkPreserveSmoothing.UseVisualStyleBackColor = true;
            // 
            // chkUseMRC
            // 
            this.chkUseMRC.AutoSize = true;
            this.chkUseMRC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkUseMRC.Location = new System.Drawing.Point(35, 143);
            this.chkUseMRC.Name = "chkUseMRC";
            this.chkUseMRC.Size = new System.Drawing.Size(253, 17);
            this.chkUseMRC.TabIndex = 16;
            this.chkUseMRC.Text = "Enable MRC (Mixed raster content) compression";
            this.chkUseMRC.UseVisualStyleBackColor = true;
            this.chkUseMRC.CheckedChanged += new System.EventHandler(this.chkUseMRC_CheckedChanged);
            // 
            // chkCharRepair
            // 
            this.chkCharRepair.AutoSize = true;
            this.chkCharRepair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCharRepair.Location = new System.Drawing.Point(35, 100);
            this.chkCharRepair.Name = "chkCharRepair";
            this.chkCharRepair.Size = new System.Drawing.Size(213, 17);
            this.chkCharRepair.TabIndex = 8;
            this.chkCharRepair.Text = "Apply character repairing after threshold";
            this.chkCharRepair.UseVisualStyleBackColor = true;
            // 
            // chkEnableColorDetection
            // 
            this.chkEnableColorDetection.AutoSize = true;
            this.chkEnableColorDetection.Location = new System.Drawing.Point(35, 77);
            this.chkEnableColorDetection.Name = "chkEnableColorDetection";
            this.chkEnableColorDetection.Size = new System.Drawing.Size(132, 17);
            this.chkEnableColorDetection.TabIndex = 0;
            this.chkEnableColorDetection.Text = "Enable color detection";
            this.chkEnableColorDetection.UseVisualStyleBackColor = true;
            this.chkEnableColorDetection.CheckedChanged += new System.EventHandler(this.chkEnableColorDetection_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(480, 211);
            this.panel2.TabIndex = 28;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabCompression);
            this.tabControl1.Controls.Add(this.tabBitmap);
            this.tabControl1.Controls.Add(this.tabContentRemoval);
            this.tabControl1.Controls.Add(this.tabOutputFormat);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 243);
            this.tabControl1.TabIndex = 3;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.chkOnlyPdf);
            this.tabGeneral.Controls.Add(this.panel1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(486, 217);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // chkOnlyPdf
            // 
            this.chkOnlyPdf.AutoSize = true;
            this.chkOnlyPdf.Location = new System.Drawing.Point(15, 15);
            this.chkOnlyPdf.Name = "chkOnlyPdf";
            this.chkOnlyPdf.Size = new System.Drawing.Size(132, 17);
            this.chkOnlyPdf.TabIndex = 0;
            this.chkOnlyPdf.Text = "Only process PDF files";
            this.chkOnlyPdf.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(480, 211);
            this.panel1.TabIndex = 17;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 286);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabOutputFormat.ResumeLayout(false);
            this.tabOutputFormat.PerformLayout();
            this.tabContentRemoval.ResumeLayout(false);
            this.tabContentRemoval.PerformLayout();
            this.tabBitmap.ResumeLayout(false);
            this.tabBitmap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownscaleResolution)).EndInit();
            this.tabCompression.ResumeLayout(false);
            this.tabCompression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuBackgroundImageResolution)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btReset;
        internal System.Windows.Forms.Button btApply;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabOutputFormat;
        private System.Windows.Forms.CheckBox chkKeepWriteAcessTime;
        private System.Windows.Forms.ComboBox cmbPreferredVersion;
        private System.Windows.Forms.Label lbPreferredVersion;
        private System.Windows.Forms.CheckBox chkFastWebView;
        private System.Windows.Forms.TabPage tabContentRemoval;
        private System.Windows.Forms.CheckBox chkRemoveHyperlinks;
        private System.Windows.Forms.CheckBox chkPackDocument;
        private System.Windows.Forms.Label lbDocumentContent;
        private System.Windows.Forms.Label lbInteractiveContent;
        private System.Windows.Forms.CheckBox chkRemoveEmbeddedFiles;
        private System.Windows.Forms.CheckBox chkRemoveBookmarks;
        private System.Windows.Forms.CheckBox chkRemoveFormFields;
        private System.Windows.Forms.CheckBox chkRemoveAnnotations;
        private System.Windows.Forms.TabPage tabBitmap;
        private System.Windows.Forms.CheckBox chkRecompressImages;
        private System.Windows.Forms.CheckBox chkDownscaleImages;
        private System.Windows.Forms.CheckBox chkJPEG2000;
        private System.Windows.Forms.ComboBox cmbImageQuality;
        private System.Windows.Forms.Label lbDpi;
        private System.Windows.Forms.NumericUpDown nuDownscaleResolution;
        private System.Windows.Forms.Label lbResolution;
        private System.Windows.Forms.Label lbQuality;
        private System.Windows.Forms.TabPage tabCompression;
        private System.Windows.Forms.CheckBox chkPackFonts;
        private System.Windows.Forms.Label lbFonts;
        private System.Windows.Forms.Label lbDpi2;
        private System.Windows.Forms.NumericUpDown nuBackgroundImageResolution;
        private System.Windows.Forms.Label lbBackgroundImageResolution;
        private System.Windows.Forms.Label lbMrc;
        private System.Windows.Forms.Label lbColorDetection;
        private System.Windows.Forms.CheckBox chkPreserveSmoothing;
        private System.Windows.Forms.CheckBox chkUseMRC;
        private System.Windows.Forms.CheckBox chkCharRepair;
        private System.Windows.Forms.CheckBox chkEnableColorDetection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.CheckBox chkOnlyPdf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}