using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GdPicture14;
namespace Displaying_From_URL
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
        public System.Windows.Forms.Button Command3; 
        public System.Windows.Forms.Button Command2; 
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Command3 = new System.Windows.Forms.Button();
            this.Command2 = new System.Windows.Forms.Button();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Command3
            // 
            this.Command3.BackColor = System.Drawing.SystemColors.Control;
            this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command3.Location = new System.Drawing.Point(1001, 753);
            this.Command3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command3.Name = "Command3";
            this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command3.Size = new System.Drawing.Size(28, 23);
            this.Command3.TabIndex = 3;
            this.Command3.Text = "-";
            this.Command3.UseVisualStyleBackColor = false;
            // 
            // Command2
            // 
            this.Command2.BackColor = System.Drawing.SystemColors.Control;
            this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command2.Location = new System.Drawing.Point(1033, 753);
            this.Command2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command2.Size = new System.Drawing.Size(28, 23);
            this.Command2.TabIndex = 2;
            this.Command2.Text = "+";
            this.Command2.UseVisualStyleBackColor = false;
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDrop = true;
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
            this.GdViewer1.ContinuousViewMode = true;
            this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.GdViewer1.DisplayQualityAuto = false;
            this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer1.EnableDeferredPainting = true;
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
            this.GdViewer1.Location = new System.Drawing.Point(12, 81);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
            this.GdViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.GdViewer1.Size = new System.Drawing.Size(1049, 665);
            this.GdViewer1.TabIndex = 11;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 11);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 17);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "HOST:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 39);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 17);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "PATH:";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(12, 753);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(981, 28);
            this.ProgressBar1.TabIndex = 14;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(104, 7);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(339, 22);
            this.TextBox1.TabIndex = 15;
            this.TextBox1.Text = "www.gdpicture.com";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(104, 36);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(515, 22);
            this.TextBox2.TabIndex = 16;
            this.TextBox2.Text = "/images/nature.jpg";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(961, 7);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 53);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "Load !";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 793);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GdViewer1);
            this.Controls.Add(this.Command3);
            this.Controls.Add(this.Command2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(4, 30);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "GdPicture.NET - Displaying From URL Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal GdViewer GdViewer1; 
        internal System.Windows.Forms.Label Label1; 
        internal System.Windows.Forms.Label Label2; 
        internal System.Windows.Forms.ProgressBar ProgressBar1; 
        internal System.Windows.Forms.TextBox TextBox1; 
        internal System.Windows.Forms.TextBox TextBox2; 
        internal System.Windows.Forms.Button Button1; 
        #endregion 
    } 
    
} 
