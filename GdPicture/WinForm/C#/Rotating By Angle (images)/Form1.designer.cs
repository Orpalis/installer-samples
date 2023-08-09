using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GdPicture14;

namespace anglerotation
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
        public System.Windows.Forms.ToolTip ToolTip1; 
        public System.Windows.Forms.HScrollBar HScroll4; 
        public System.Windows.Forms.HScrollBar HScroll3; 
        public System.Windows.Forms.HScrollBar HScroll2; 
        public System.Windows.Forms.HScrollBar HScroll1; 
        public System.Windows.Forms.Label Label4; 
        public System.Windows.Forms.Label Label3; 
        public System.Windows.Forms.Label Label2; 
        public System.Windows.Forms.Label Label1; 
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HScroll4 = new System.Windows.Forms.HScrollBar();
            this.HScroll3 = new System.Windows.Forms.HScrollBar();
            this.HScroll2 = new System.Windows.Forms.HScrollBar();
            this.HScroll1 = new System.Windows.Forms.HScrollBar();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HScroll4
            // 
            this.HScroll4.Cursor = System.Windows.Forms.Cursors.Default;
            this.HScroll4.Location = new System.Drawing.Point(404, 624);
            this.HScroll4.Maximum = 180;
            this.HScroll4.Minimum = -180;
            this.HScroll4.Name = "HScroll4";
            this.HScroll4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HScroll4.Size = new System.Drawing.Size(373, 21);
            this.HScroll4.TabIndex = 8;
            this.HScroll4.TabStop = true;
            this.HScroll4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScroll4_Scroll);
            // 
            // HScroll3
            // 
            this.HScroll3.Cursor = System.Windows.Forms.Cursors.Default;
            this.HScroll3.Location = new System.Drawing.Point(404, 572);
            this.HScroll3.Maximum = 180;
            this.HScroll3.Minimum = -180;
            this.HScroll3.Name = "HScroll3";
            this.HScroll3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HScroll3.Size = new System.Drawing.Size(373, 21);
            this.HScroll3.TabIndex = 6;
            this.HScroll3.TabStop = true;
            this.HScroll3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScroll3_Scroll);
            // 
            // HScroll2
            // 
            this.HScroll2.Cursor = System.Windows.Forms.Cursors.Default;
            this.HScroll2.Location = new System.Drawing.Point(14, 624);
            this.HScroll2.Maximum = 180;
            this.HScroll2.Minimum = -180;
            this.HScroll2.Name = "HScroll2";
            this.HScroll2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HScroll2.Size = new System.Drawing.Size(373, 21);
            this.HScroll2.TabIndex = 4;
            this.HScroll2.TabStop = true;
            this.HScroll2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScroll2_Scroll);
            // 
            // HScroll1
            // 
            this.HScroll1.Cursor = System.Windows.Forms.Cursors.Default;
            this.HScroll1.Location = new System.Drawing.Point(14, 572);
            this.HScroll1.Maximum = 180;
            this.HScroll1.Minimum = -180;
            this.HScroll1.Name = "HScroll1";
            this.HScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HScroll1.Size = new System.Drawing.Size(373, 21);
            this.HScroll1.TabIndex = 2;
            this.HScroll1.TabStop = true;
            this.HScroll1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScroll1_Scroll);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(402, 604);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(115, 13);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "RotateAngleBackColor";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(402, 552);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(162, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "RotateAnglePreserveDimensions";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(12, 604);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(193, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "RotateAnglePreserveDimensionsCenter";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(12, 552);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(66, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "RotateAngle";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip1.TabIndex = 12;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.OpenToolStripMenuItem.Text = "Open...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDrop = true;
            this.GdViewer1.AllowDropFile = false;
            this.GdViewer1.AnimateGIF = false;
            this.GdViewer1.AnnotationDropShadow = true;
            this.GdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.GdViewer1.AnnotationResizeRotateHandlesScale = 1F;
            this.GdViewer1.AnnotationSelectionLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewer1.BackColor = System.Drawing.Color.Black;
            this.GdViewer1.BackgroundImage = null;
            this.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewer1.ContinuousViewMode = true;
            this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.GdViewer1.DisplayQualityAuto = false;
            this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer1.EnableDeferredPainting = false;
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
            this.GdViewer1.Location = new System.Drawing.Point(5, 27);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
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
            this.GdViewer1.SilentMode = false;
            this.GdViewer1.Size = new System.Drawing.Size(788, 522);
            this.GdViewer1.TabIndex = 13;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.GdViewer1);
            this.Controls.Add(this.HScroll4);
            this.Controls.Add(this.HScroll3);
            this.Controls.Add(this.HScroll2);
            this.Controls.Add(this.HScroll1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.MenuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(4, 30);
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "GdPicture.NET - Angle Rotation Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal   System.Windows.Forms.MenuStrip MenuStrip1; 
        internal   System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem; 
        internal   System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem; 
        internal   System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem; 
        internal   System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem; 
        internal   GdViewer GdViewer1; 
        #endregion 
    } 
    
} 
