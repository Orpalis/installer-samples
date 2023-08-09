using System;
using GdPicture14;



namespace MICR
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAutoDeskew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRotate90 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemResetToInput = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelMinAccuracy = new System.Windows.Forms.Label();
            this.NumericUpDownMinAccuracy = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxFont = new System.Windows.Forms.ComboBox();
            this.LabelFont = new System.Windows.Forms.Label();
            this.ComboBoxContext = new System.Windows.Forms.ComboBox();
            this.LabelContext = new System.Windows.Forms.Label();
            this.ComboBoxWhiteList = new System.Windows.Forms.ComboBox();
            this.LabelExpectedItems = new System.Windows.Forms.Label();
            this.NumericUpDownExpectedItems = new System.Windows.Forms.NumericUpDown();
            this.LabelWhiteList = new System.Windows.Forms.Label();
            this.TextBoxResults = new System.Windows.Forms.TextBox();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMinAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownExpectedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextBoxResults);
            this.splitContainer1.Size = new System.Drawing.Size(1139, 593);
            this.splitContainer1.SplitterDistance = 436;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.GdViewer1);
            this.splitContainer2.Panel1.Controls.Add(this.MenuStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.LabelMinAccuracy);
            this.splitContainer2.Panel2.Controls.Add(this.NumericUpDownMinAccuracy);
            this.splitContainer2.Panel2.Controls.Add(this.ComboBoxFont);
            this.splitContainer2.Panel2.Controls.Add(this.LabelFont);
            this.splitContainer2.Panel2.Controls.Add(this.ComboBoxContext);
            this.splitContainer2.Panel2.Controls.Add(this.LabelContext);
            this.splitContainer2.Panel2.Controls.Add(this.ComboBoxWhiteList);
            this.splitContainer2.Panel2.Controls.Add(this.LabelExpectedItems);
            this.splitContainer2.Panel2.Controls.Add(this.NumericUpDownExpectedItems);
            this.splitContainer2.Panel2.Controls.Add(this.LabelWhiteList);
            this.splitContainer2.Size = new System.Drawing.Size(1139, 436);
            this.splitContainer2.SplitterDistance = 410;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 3;
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDropFile = false;
            this.GdViewer1.AnimateGIF = false;
            this.GdViewer1.AnnotationDropShadow = true;
            this.GdViewer1.AnnotationEnableMultiSelect = true;
            this.GdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.GdViewer1.AnnotationResizeRotateHandlesScale = 1F;
            this.GdViewer1.AnnotationSelectionLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewer1.BackColor = System.Drawing.Color.Black;
            this.GdViewer1.BackgroundImage = null;
            this.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewer1.ClipAnnotsToPageBounds = true;
            this.GdViewer1.ClipRegionsToPageBounds = true;
            this.GdViewer1.ContinuousViewMode = true;
            this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.GdViewer1.DisplayQualityAuto = false;
            this.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer1.DrawPageBorders = true;
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
            this.GdViewer1.Location = new System.Drawing.Point(0, 24);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
            this.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
            this.GdViewer1.Name = "GdViewer1";
            this.GdViewer1.PageBordersColor = System.Drawing.Color.Black;
            this.GdViewer1.PageBordersPenSize = 1;
            this.GdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView;
            this.GdViewer1.PdfDisplayFormField = true;
            this.GdViewer1.PdfEnableFileLinks = true;
            this.GdViewer1.PdfEnableLinks = true;
            this.GdViewer1.PdfIncreaseTextContrast = false;
            this.GdViewer1.PdfShowDialogForPassword = true;
            this.GdViewer1.PdfShowOpenFileDialogForDecryption = true;
            this.GdViewer1.PdfVerifyDigitalCertificates = false;
            this.GdViewer1.PreserveViewRotation = true;
            this.GdViewer1.RectBorderColor = System.Drawing.Color.Black;
            this.GdViewer1.RectBorderSize = 1;
            this.GdViewer1.RectIsEditable = true;
            this.GdViewer1.RegionsAreEditable = true;
            this.GdViewer1.RenderGdPictureAnnots = true;
            this.GdViewer1.ScrollBars = true;
            this.GdViewer1.ScrollLargeChange = ((short)(50));
            this.GdViewer1.ScrollSmallChange = ((short)(1));
            this.GdViewer1.SilentMode = true;
            this.GdViewer1.Size = new System.Drawing.Size(1139, 386);
            this.GdViewer1.TabIndex = 1;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemEdit,
            this.ToolStripMenuItemStart});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1139, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpen,
            this.ToolStripMenuItemClose,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenuItemFile.Text = "File";
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemOpen.Text = "Open...";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemClose.Text = "Close";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemExit.Text = "Exit";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAutoDeskew,
            this.ToolStripMenuItemRotate90,
            this.ToolStripMenuItemResetToInput});
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(39, 20);
            this.ToolStripMenuItemEdit.Text = "Edit";
            // 
            // ToolStripMenuItemAutoDeskew
            // 
            this.ToolStripMenuItemAutoDeskew.Name = "ToolStripMenuItemAutoDeskew";
            this.ToolStripMenuItemAutoDeskew.Size = new System.Drawing.Size(147, 22);
            this.ToolStripMenuItemAutoDeskew.Text = "Auto-Deskew";
            this.ToolStripMenuItemAutoDeskew.Click += new System.EventHandler(this.ToolStripMenuItemAutoDeskew_Click);
            // 
            // ToolStripMenuItemRotate90
            // 
            this.ToolStripMenuItemRotate90.Name = "ToolStripMenuItemRotate90";
            this.ToolStripMenuItemRotate90.Size = new System.Drawing.Size(147, 22);
            this.ToolStripMenuItemRotate90.Text = "Rotate 90";
            this.ToolStripMenuItemRotate90.Click += new System.EventHandler(this.ToolStripMenuItemRotate90_Click);
            // 
            // ToolStripMenuItemResetToInput
            // 
            this.ToolStripMenuItemResetToInput.Name = "ToolStripMenuItemResetToInput";
            this.ToolStripMenuItemResetToInput.Size = new System.Drawing.Size(147, 22);
            this.ToolStripMenuItemResetToInput.Text = "Reset to Input";
            this.ToolStripMenuItemResetToInput.Click += new System.EventHandler(this.ToolStripMenuItemResetToInput_Click);
            // 
            // ToolStripMenuItemStart
            // 
            this.ToolStripMenuItemStart.Name = "ToolStripMenuItemStart";
            this.ToolStripMenuItemStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemStart.Size = new System.Drawing.Size(46, 20);
            this.ToolStripMenuItemStart.Text = "Start!";
            this.ToolStripMenuItemStart.Click += new System.EventHandler(this.ToolStripMenuItemStart_Click);
            // 
            // LabelMinAccuracy
            // 
            this.LabelMinAccuracy.AutoSize = true;
            this.LabelMinAccuracy.Location = new System.Drawing.Point(893, 7);
            this.LabelMinAccuracy.Name = "LabelMinAccuracy";
            this.LabelMinAccuracy.Size = new System.Drawing.Size(74, 13);
            this.LabelMinAccuracy.TabIndex = 10;
            this.LabelMinAccuracy.Text = "Min accuracy:";
            // 
            // NumericUpDownMinAccuracy
            // 
            this.NumericUpDownMinAccuracy.Location = new System.Drawing.Point(973, 4);
            this.NumericUpDownMinAccuracy.Name = "NumericUpDownMinAccuracy";
            this.NumericUpDownMinAccuracy.Size = new System.Drawing.Size(44, 20);
            this.NumericUpDownMinAccuracy.TabIndex = 9;
            this.NumericUpDownMinAccuracy.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // ComboBoxFont
            // 
            this.ComboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFont.FormattingEnabled = true;
            this.ComboBoxFont.Items.AddRange(new object[] {
            "CMC7",
            "E13B"});
            this.ComboBoxFont.Location = new System.Drawing.Point(798, 2);
            this.ComboBoxFont.Name = "ComboBoxFont";
            this.ComboBoxFont.Size = new System.Drawing.Size(84, 21);
            this.ComboBoxFont.TabIndex = 8;
            this.ComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFont_SelectedIndexChanged);
            // 
            // LabelFont
            // 
            this.LabelFont.AutoSize = true;
            this.LabelFont.Location = new System.Drawing.Point(761, 6);
            this.LabelFont.Name = "LabelFont";
            this.LabelFont.Size = new System.Drawing.Size(31, 13);
            this.LabelFont.TabIndex = 7;
            this.LabelFont.Text = "Font:";
            // 
            // ComboBoxContext
            // 
            this.ComboBoxContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxContext.FormattingEnabled = true;
            this.ComboBoxContext.Items.AddRange(new object[] {
            "Document",
            "Line Finding"});
            this.ComboBoxContext.Location = new System.Drawing.Point(603, 2);
            this.ComboBoxContext.Name = "ComboBoxContext";
            this.ComboBoxContext.Size = new System.Drawing.Size(144, 21);
            this.ComboBoxContext.TabIndex = 6;
            // 
            // LabelContext
            // 
            this.LabelContext.AutoSize = true;
            this.LabelContext.Location = new System.Drawing.Point(552, 6);
            this.LabelContext.Name = "LabelContext";
            this.LabelContext.Size = new System.Drawing.Size(46, 13);
            this.LabelContext.TabIndex = 5;
            this.LabelContext.Text = "Context:";
            // 
            // ComboBoxWhiteList
            // 
            this.ComboBoxWhiteList.FormattingEnabled = true;
            this.ComboBoxWhiteList.Items.AddRange(new object[] {
            "0123456789/<#>^",
            "0123456789/<#>^ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "0123456789ABCD"});
            this.ComboBoxWhiteList.Location = new System.Drawing.Point(70, 3);
            this.ComboBoxWhiteList.Name = "ComboBoxWhiteList";
            this.ComboBoxWhiteList.Size = new System.Drawing.Size(315, 21);
            this.ComboBoxWhiteList.TabIndex = 4;
            // 
            // LabelExpectedItems
            // 
            this.LabelExpectedItems.AutoSize = true;
            this.LabelExpectedItems.Location = new System.Drawing.Point(403, 7);
            this.LabelExpectedItems.Name = "LabelExpectedItems";
            this.LabelExpectedItems.Size = new System.Drawing.Size(83, 13);
            this.LabelExpectedItems.TabIndex = 3;
            this.LabelExpectedItems.Text = "Expected Items:";
            // 
            // NumericUpDownExpectedItems
            // 
            this.NumericUpDownExpectedItems.Location = new System.Drawing.Point(492, 4);
            this.NumericUpDownExpectedItems.Name = "NumericUpDownExpectedItems";
            this.NumericUpDownExpectedItems.Size = new System.Drawing.Size(44, 20);
            this.NumericUpDownExpectedItems.TabIndex = 2;
            // 
            // LabelWhiteList
            // 
            this.LabelWhiteList.AutoSize = true;
            this.LabelWhiteList.Location = new System.Drawing.Point(7, 7);
            this.LabelWhiteList.Name = "LabelWhiteList";
            this.LabelWhiteList.Size = new System.Drawing.Size(57, 13);
            this.LabelWhiteList.TabIndex = 0;
            this.LabelWhiteList.Text = "White List:";
            // 
            // TextBoxResults
            // 
            this.TextBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxResults.Location = new System.Drawing.Point(0, 0);
            this.TextBoxResults.Multiline = true;
            this.TextBoxResults.Name = "TextBoxResults";
            this.TextBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxResults.Size = new System.Drawing.Size(1139, 153);
            this.TextBoxResults.TabIndex = 0;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "Open...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 593);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "frmMain";
            this.Text = "GdPicture.NET - MICR Demo  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMinAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownExpectedItems)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private GdPicture14.GdViewer GdViewer1;
        private System.Windows.Forms.Label LabelMinAccuracy;
        private System.Windows.Forms.NumericUpDown NumericUpDownMinAccuracy;
        private System.Windows.Forms.ComboBox ComboBoxFont;
        private System.Windows.Forms.Label LabelFont;
        private System.Windows.Forms.ComboBox ComboBoxContext;
        private System.Windows.Forms.Label LabelContext;
        private System.Windows.Forms.ComboBox ComboBoxWhiteList;
        private System.Windows.Forms.Label LabelExpectedItems;
        private System.Windows.Forms.NumericUpDown NumericUpDownExpectedItems;
        private System.Windows.Forms.Label LabelWhiteList;
        private System.Windows.Forms.TextBox TextBoxResults;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAutoDeskew;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRotate90;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemResetToInput;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStart;

        #endregion

    }

}
