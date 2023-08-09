using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GdPicture14;

namespace adjust
{
    
    partial class Form1  
    { 
        #region '"Windows Form Designer generated code "' 
        [ System.Diagnostics.DebuggerNonUserCode() ]
        public Form1() : base() 
        { 
            
            // This call is required by the Windows Form Designer.
            InitializeComponent(); 

        } 
        // Form overrides dispose to clean up the component list.
        [ System.Diagnostics.DebuggerNonUserCode() ]
        protected override void Dispose( bool Disposing ) 
        { 
            if ( Disposing ) 
            { 
                if ( !( components == null ) ) 
                { 
                    components.Dispose(); 
                } 
            } 
            base.Dispose( Disposing ); 
        } 
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components; 
        public System.Windows.Forms.HScrollBar HScrollBarSaturation; 
        public System.Windows.Forms.HScrollBar HScrollBarGamma; 
        public System.Windows.Forms.HScrollBar HScrollBarContrast; 
        public System.Windows.Forms.HScrollBar HScrollBarBrightness; 
        public System.Windows.Forms.Label LabelSaturation; 
        public System.Windows.Forms.Label LabelGamma; 
        public System.Windows.Forms.Label LabelContrast; 
        public System.Windows.Forms.Label LabelBrightness; 
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HScrollBarSaturation = new System.Windows.Forms.HScrollBar();
            this.HScrollBarGamma = new System.Windows.Forms.HScrollBar();
            this.HScrollBarContrast = new System.Windows.Forms.HScrollBar();
            this.HScrollBarBrightness = new System.Windows.Forms.HScrollBar();
            this.LabelSaturation = new System.Windows.Forms.Label();
            this.LabelGamma = new System.Windows.Forms.Label();
            this.LabelContrast = new System.Windows.Forms.Label();
            this.LabelBrightness = new System.Windows.Forms.Label();
            this.MenuStripFile = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.GdVieware1 = new GdPicture14.GdViewer();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.MenuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // HScrollBarSaturation
            // 
            this.HScrollBarSaturation.Cursor = System.Windows.Forms.Cursors.Default;
            this.HScrollBarSaturation.Location = new System.Drawing.Point(404, 624);
            this.HScrollBarSaturation.Maximum = 108;
            this.HScrollBarSaturation.Minimum = -100;
            this.HScrollBarSaturation.Name = "HScrollBarSaturation";
            this.HScrollBarSaturation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HScrollBarSaturation.Size = new System.Drawing.Size(373, 21);
            this.HScrollBarSaturation.TabIndex = 8;
            this.HScrollBarSaturation.TabStop = true;
            this.HScrollBarSaturation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarSaturation_Scroll);
            // 
            // HScrollBarGamma
            // 
            this.HScrollBarGamma.Cursor = System.Windows.Forms.Cursors.Default;
            this.HScrollBarGamma.Location = new System.Drawing.Point(404, 572);
            this.HScrollBarGamma.Maximum = 109;
            this.HScrollBarGamma.Minimum = -99;
            this.HScrollBarGamma.Name = "HScrollBarGamma";
            this.HScrollBarGamma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HScrollBarGamma.Size = new System.Drawing.Size(373, 21);
            this.HScrollBarGamma.TabIndex = 6;
            this.HScrollBarGamma.TabStop = true;
            this.HScrollBarGamma.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarGamma_Scroll);
            // 
            // HScrollBarContrast
            // 
            this.HScrollBarContrast.Cursor = System.Windows.Forms.Cursors.Default;
            this.HScrollBarContrast.Location = new System.Drawing.Point(14, 624);
            this.HScrollBarContrast.Maximum = 109;
            this.HScrollBarContrast.Minimum = -100;
            this.HScrollBarContrast.Name = "HScrollBarContrast";
            this.HScrollBarContrast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HScrollBarContrast.Size = new System.Drawing.Size(373, 21);
            this.HScrollBarContrast.TabIndex = 4;
            this.HScrollBarContrast.TabStop = true;
            this.HScrollBarContrast.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarContrast_Scroll);
            // 
            // HScrollBarBrightness
            // 
            this.HScrollBarBrightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.HScrollBarBrightness.Location = new System.Drawing.Point(14, 572);
            this.HScrollBarBrightness.Maximum = 109;
            this.HScrollBarBrightness.Minimum = -100;
            this.HScrollBarBrightness.Name = "HScrollBarBrightness";
            this.HScrollBarBrightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HScrollBarBrightness.Size = new System.Drawing.Size(373, 21);
            this.HScrollBarBrightness.TabIndex = 2;
            this.HScrollBarBrightness.TabStop = true;
            this.HScrollBarBrightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarBrightness_Scroll);
            // 
            // LabelSaturation
            // 
            this.LabelSaturation.AutoSize = true;
            this.LabelSaturation.BackColor = System.Drawing.Color.Transparent;
            this.LabelSaturation.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSaturation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelSaturation.Location = new System.Drawing.Point(402, 604);
            this.LabelSaturation.Name = "LabelSaturation";
            this.LabelSaturation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelSaturation.Size = new System.Drawing.Size(61, 13);
            this.LabelSaturation.TabIndex = 9;
            this.LabelSaturation.Text = "Saturation :";
            // 
            // LabelGamma
            // 
            this.LabelGamma.AutoSize = true;
            this.LabelGamma.BackColor = System.Drawing.Color.Transparent;
            this.LabelGamma.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGamma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelGamma.Location = new System.Drawing.Point(402, 552);
            this.LabelGamma.Name = "LabelGamma";
            this.LabelGamma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelGamma.Size = new System.Drawing.Size(49, 13);
            this.LabelGamma.TabIndex = 7;
            this.LabelGamma.Text = "Gamma :";
            // 
            // LabelContrast
            // 
            this.LabelContrast.AutoSize = true;
            this.LabelContrast.BackColor = System.Drawing.Color.Transparent;
            this.LabelContrast.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelContrast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelContrast.Location = new System.Drawing.Point(12, 604);
            this.LabelContrast.Name = "LabelContrast";
            this.LabelContrast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelContrast.Size = new System.Drawing.Size(52, 13);
            this.LabelContrast.TabIndex = 5;
            this.LabelContrast.Text = "Contrast :";
            // 
            // LabelBrightness
            // 
            this.LabelBrightness.AutoSize = true;
            this.LabelBrightness.BackColor = System.Drawing.Color.Transparent;
            this.LabelBrightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelBrightness.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelBrightness.Location = new System.Drawing.Point(12, 552);
            this.LabelBrightness.Name = "LabelBrightness";
            this.LabelBrightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelBrightness.Size = new System.Drawing.Size(62, 13);
            this.LabelBrightness.TabIndex = 3;
            this.LabelBrightness.Text = "Brightness :";
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile});
            this.MenuStripFile.Location = new System.Drawing.Point(0, 0);
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(800, 24);
            this.MenuStripFile.TabIndex = 12;
            this.MenuStripFile.Text = "MenuStrip1";
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
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.StripMenuItemOpenTool_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemClose.Text = "Close";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemExit.Text = "Exit";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // GdVieware1
            // 
            this.GdVieware1.AllowDrop = true;
            this.GdVieware1.AllowDropFile = false;
            this.GdVieware1.AnimateGIF = false;
            this.GdVieware1.AnnotationDropShadow = true;
            this.GdVieware1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.GdVieware1.AnnotationResizeRotateHandlesScale = 1F;
            this.GdVieware1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdVieware1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdVieware1.BackColor = System.Drawing.Color.Black;
            this.GdVieware1.BackgroundImage = null;
            this.GdVieware1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdVieware1.ContinuousViewMode = true;
            this.GdVieware1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdVieware1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.GdVieware1.DisplayQualityAuto = false;
            this.GdVieware1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdVieware1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdVieware1.EnableDeferredPainting = false;
            this.GdVieware1.EnabledProgressBar = true;
            this.GdVieware1.EnableICM = false;
            this.GdVieware1.EnableMenu = true;
            this.GdVieware1.EnableMouseWheel = true;
            this.GdVieware1.EnableTextSelection = true;
            this.GdVieware1.ForceScrollBars = false;
            this.GdVieware1.ForeColor = System.Drawing.Color.Black;
            this.GdVieware1.Gamma = 1F;
            this.GdVieware1.HQAnnotationRendering = true;
            this.GdVieware1.IgnoreDocumentResolution = false;
            this.GdVieware1.KeepDocumentPosition = false;
            this.GdVieware1.Location = new System.Drawing.Point(5, 27);
            this.GdVieware1.LockViewer = false;
            this.GdVieware1.MagnifierHeight = 90;
            this.GdVieware1.MagnifierWidth = 160;
            this.GdVieware1.MagnifierZoomX = 2F;
            this.GdVieware1.MagnifierZoomY = 2F;
            this.GdVieware1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdVieware1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.GdVieware1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
            this.GdVieware1.Name = "GdVieware1";
            this.GdVieware1.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView;
            this.GdVieware1.PdfDisplayFormField = true;
            this.GdVieware1.PdfEnableFileLinks = true;
            this.GdVieware1.PdfEnableLinks = true;
            this.GdVieware1.PdfIncreaseTextContrast = false;
            this.GdVieware1.PdfShowDialogForPassword = true;
            this.GdVieware1.PdfShowOpenFileDialogForDecryption = true;
            this.GdVieware1.PdfVerifyDigitalCertificates = false;
            this.GdVieware1.RectBorderColor = System.Drawing.Color.Black;
            this.GdVieware1.RectBorderSize = 1;
            this.GdVieware1.RectIsEditable = true;
            this.GdVieware1.RegionsAreEditable = true;
            this.GdVieware1.RenderGdPictureAnnots = true;
            this.GdVieware1.ScrollBars = true;
            this.GdVieware1.ScrollLargeChange = ((short)(50));
            this.GdVieware1.ScrollSmallChange = ((short)(1));
            this.GdVieware1.SilentMode = false;
            this.GdVieware1.Size = new System.Drawing.Size(788, 522);
            this.GdVieware1.TabIndex = 13;
            this.GdVieware1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdVieware1.Zoom = 0.001D;
            this.GdVieware1.ZoomCenterAtMousePosition = false;
            this.GdVieware1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdVieware1.ZoomStep = 25;
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(699, 5);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(94, 19);
            this.ButtonReset.TabIndex = 14;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.GdVieware1);
            this.Controls.Add(this.HScrollBarSaturation);
            this.Controls.Add(this.HScrollBarGamma);
            this.Controls.Add(this.HScrollBarContrast);
            this.Controls.Add(this.HScrollBarBrightness);
            this.Controls.Add(this.LabelSaturation);
            this.Controls.Add(this.LabelGamma);
            this.Controls.Add(this.LabelContrast);
            this.Controls.Add(this.LabelBrightness);
            this.Controls.Add(this.MenuStripFile);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(4, 30);
            this.MainMenuStrip = this.MenuStripFile;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "GdPicture.NET - Adjusting Gamma - Brightness - Contrast & Saturation Sample  -  h" +
    "ttp://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStripFile.ResumeLayout(false);
            this.MenuStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal System.Windows.Forms.MenuStrip MenuStripFile; 
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile; 
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen; 
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose; 
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit; 
        internal GdViewer GdVieware1; 
        #endregion 
        private Button ButtonReset;
    } 
    
} 
