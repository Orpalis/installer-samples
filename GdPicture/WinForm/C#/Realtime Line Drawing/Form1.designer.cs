using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GdPicture14;

namespace Project1
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
        public  System.Windows.Forms.Button Command3; 
        public  System.Windows.Forms.Button Command2; 
        public  System.Windows.Forms.Button Command1; 
        public  System.Windows.Forms.TextBox txtPenSize; 
        public  System.Windows.Forms.TextBox txtBlue; 
        public  System.Windows.Forms.TextBox txtGreen; 
        public  System.Windows.Forms.TextBox txtRed; 
        public  System.Windows.Forms.TextBox txtAlpha; 
        public  System.Windows.Forms.Label Label5; 
        public  System.Windows.Forms.Label Label4; 
        public  System.Windows.Forms.Label Label3; 
        public  System.Windows.Forms.Label Label1; 
        public  System.Windows.Forms.Label Label2; 
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        { 
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Command3 = new System.Windows.Forms.Button();
            this.Command2 = new System.Windows.Forms.Button();
            this.Command1 = new System.Windows.Forms.Button();
            this.txtPenSize = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.SuspendLayout();
            // 
            // Command3
            // 
            this.Command3.BackColor = System.Drawing.SystemColors.Control;
            this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command3.Location = new System.Drawing.Point(8, 76);
            this.Command3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command3.Name = "Command3";
            this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command3.Size = new System.Drawing.Size(81, 33);
            this.Command3.TabIndex = 12;
            this.Command3.Text = "Clear";
            this.Command3.UseVisualStyleBackColor = false;
            this.Command3.Click += new System.EventHandler(this.Command3_Click);
            // 
            // Command2
            // 
            this.Command2.BackColor = System.Drawing.SystemColors.Control;
            this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command2.Location = new System.Drawing.Point(1181, 74);
            this.Command2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command2.Size = new System.Drawing.Size(49, 33);
            this.Command2.TabIndex = 11;
            this.Command2.Text = "-";
            this.Command2.UseVisualStyleBackColor = false;
            this.Command2.Click += new System.EventHandler(this.Command2_Click);
            // 
            // Command1
            // 
            this.Command1.BackColor = System.Drawing.SystemColors.Control;
            this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command1.Location = new System.Drawing.Point(1237, 74);
            this.Command1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command1.Size = new System.Drawing.Size(49, 33);
            this.Command1.TabIndex = 10;
            this.Command1.Text = "+";
            this.Command1.UseVisualStyleBackColor = false;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            // 
            // txtPenSize
            // 
            this.txtPenSize.AcceptsReturn = true;
            this.txtPenSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtPenSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPenSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPenSize.Location = new System.Drawing.Point(344, 5);
            this.txtPenSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPenSize.MaxLength = 0;
            this.txtPenSize.Name = "txtPenSize";
            this.txtPenSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPenSize.Size = new System.Drawing.Size(37, 22);
            this.txtPenSize.TabIndex = 9;
            this.txtPenSize.Text = "5";
            // 
            // txtBlue
            // 
            this.txtBlue.AcceptsReturn = true;
            this.txtBlue.BackColor = System.Drawing.SystemColors.Window;
            this.txtBlue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBlue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBlue.Location = new System.Drawing.Point(189, 7);
            this.txtBlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBlue.MaxLength = 0;
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBlue.Size = new System.Drawing.Size(45, 22);
            this.txtBlue.TabIndex = 6;
            this.txtBlue.Text = "255";
            // 
            // txtGreen
            // 
            this.txtGreen.AcceptsReturn = true;
            this.txtGreen.BackColor = System.Drawing.SystemColors.Window;
            this.txtGreen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGreen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGreen.Location = new System.Drawing.Point(131, 7);
            this.txtGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGreen.MaxLength = 0;
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGreen.Size = new System.Drawing.Size(45, 22);
            this.txtGreen.TabIndex = 4;
            this.txtGreen.Text = "120";
            // 
            // txtRed
            // 
            this.txtRed.AcceptsReturn = true;
            this.txtRed.BackColor = System.Drawing.SystemColors.Window;
            this.txtRed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRed.Location = new System.Drawing.Point(72, 7);
            this.txtRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRed.MaxLength = 0;
            this.txtRed.Name = "txtRed";
            this.txtRed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRed.Size = new System.Drawing.Size(45, 22);
            this.txtRed.TabIndex = 2;
            this.txtRed.Text = "120";
            // 
            // txtAlpha
            // 
            this.txtAlpha.AcceptsReturn = true;
            this.txtAlpha.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlpha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlpha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlpha.Location = new System.Drawing.Point(13, 7);
            this.txtAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlpha.MaxLength = 0;
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlpha.Size = new System.Drawing.Size(45, 22);
            this.txtAlpha.TabIndex = 0;
            this.txtAlpha.Text = "255";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(275, 10);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(68, 17);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Pen Size:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(195, 37);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(36, 17);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Blue";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(131, 37);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(48, 17);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Green";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(80, 37);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(34, 17);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Red";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(16, 37);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(44, 17);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Alpha";
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
            this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Cross;
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
            this.GdViewer1.ForeColor = System.Drawing.Color.Black;
            this.GdViewer1.Gamma = 1F;
            this.GdViewer1.HQAnnotationRendering = true;
            this.GdViewer1.IgnoreDocumentResolution = false;
            this.GdViewer1.KeepDocumentPosition = false;
            this.GdViewer1.Location = new System.Drawing.Point(8, 117);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
            this.GdViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModeDefault;
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
            this.GdViewer1.Size = new System.Drawing.Size(1279, 789);
            this.GdViewer1.TabIndex = 17;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 1D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100;
            this.GdViewer1.ZoomStep = 25;
            this.GdViewer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GdViewer1_MouseDown);
            this.GdViewer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GdViewer1_MouseMove);
            this.GdViewer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GdViewer1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1292, 912);
            this.Controls.Add(this.GdViewer1);
            this.Controls.Add(this.Command3);
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.txtPenSize);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.txtAlpha);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(4, 28);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "GdPicture.NET - Realtime Line Drawing Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal  GdViewer GdViewer1; 
        #endregion 
    } 
    
} 
