using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GdPicture14;

namespace wia_sample
{

    partial class Form1 : System.Windows.Forms.Form 
    { 
        
        // Form overrides dispose to clean up the component list.
        [ System.Diagnostics.DebuggerNonUserCode() ]
        public Form1()
            : base()
        {

            // This call is required by the Windows Form Designer.
            InitializeComponent();

        }
        // Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                bool fTerminateCalled = false;
                if (!(fTerminateCalled))
                {
                    fTerminateCalled = true;
                }
                if (!(components == null))
                {
                    components.Dispose();
                }
            }
            base.Dispose(Disposing);
        } 
        
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components; 
        
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.chkRemoveDots = new System.Windows.Forms.CheckBox();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.chkAutoDesk = new System.Windows.Forms.CheckBox();
            this.chkRotate180 = new System.Windows.Forms.CheckBox();
            this.chkRotate90 = new System.Windows.Forms.CheckBox();
            this.Command12 = new System.Windows.Forms.Button();
            this.chkHideUI = new System.Windows.Forms.CheckBox();
            this.ChkAutoCrop = new System.Windows.Forms.CheckBox();
            this.ChkNeg = new System.Windows.Forms.CheckBox();
            this.Command6 = new System.Windows.Forms.Button();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.Command4 = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Command3 = new System.Windows.Forms.Button();
            this.Command2 = new System.Windows.Forms.Button();
            this.Command1 = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.Label3.Location = new System.Drawing.Point(14, 700);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(512, 1);
            this.Label3.TabIndex = 70;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 682);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 17);
            this.Label2.TabIndex = 69;
            this.Label2.Text = "Examples :";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.Label1.Location = new System.Drawing.Point(14, 27);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(512, 1);
            this.Label1.TabIndex = 68;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(8, 9);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(91, 17);
            this.Label10.TabIndex = 67;
            this.Label10.Text = "WIA Devices:";
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.ItemHeight = 16;
            this.lstDevices.Location = new System.Drawing.Point(16, 45);
            this.lstDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(508, 84);
            this.lstDevices.TabIndex = 66;
            // 
            // chkRemoveDots
            // 
            this.chkRemoveDots.BackColor = System.Drawing.SystemColors.Control;
            this.chkRemoveDots.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRemoveDots.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRemoveDots.Location = new System.Drawing.Point(254, 303);
            this.chkRemoveDots.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRemoveDots.Name = "chkRemoveDots";
            this.chkRemoveDots.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRemoveDots.Size = new System.Drawing.Size(234, 23);
            this.chkRemoveDots.TabIndex = 65;
            this.chkRemoveDots.Text = "Remove isolated dots";
            this.chkRemoveDots.UseVisualStyleBackColor = false;
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
            this.GdViewer1.Location = new System.Drawing.Point(550, 9);
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
            this.GdViewer1.Size = new System.Drawing.Size(940, 883);
            this.GdViewer1.TabIndex = 64;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            // 
            // chkAutoDesk
            // 
            this.chkAutoDesk.BackColor = System.Drawing.SystemColors.Control;
            this.chkAutoDesk.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAutoDesk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAutoDesk.Location = new System.Drawing.Point(20, 303);
            this.chkAutoDesk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAutoDesk.Name = "chkAutoDesk";
            this.chkAutoDesk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAutoDesk.Size = new System.Drawing.Size(122, 23);
            this.chkAutoDesk.TabIndex = 63;
            this.chkAutoDesk.Text = "Auto Deskew";
            this.chkAutoDesk.UseVisualStyleBackColor = false;
            // 
            // chkRotate180
            // 
            this.chkRotate180.BackColor = System.Drawing.SystemColors.Control;
            this.chkRotate180.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRotate180.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRotate180.Location = new System.Drawing.Point(254, 268);
            this.chkRotate180.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRotate180.Name = "chkRotate180";
            this.chkRotate180.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRotate180.Size = new System.Drawing.Size(170, 23);
            this.chkRotate180.TabIndex = 61;
            this.chkRotate180.Text = "Rotate 180?";
            this.chkRotate180.UseVisualStyleBackColor = false;
            // 
            // chkRotate90
            // 
            this.chkRotate90.BackColor = System.Drawing.SystemColors.Control;
            this.chkRotate90.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRotate90.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRotate90.Location = new System.Drawing.Point(254, 234);
            this.chkRotate90.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRotate90.Name = "chkRotate90";
            this.chkRotate90.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRotate90.Size = new System.Drawing.Size(170, 23);
            this.chkRotate90.TabIndex = 60;
            this.chkRotate90.Text = "Rotate 90?";
            this.chkRotate90.UseVisualStyleBackColor = false;
            // 
            // Command12
            // 
            this.Command12.BackColor = System.Drawing.SystemColors.Control;
            this.Command12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command12.Location = new System.Drawing.Point(258, 781);
            this.Command12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command12.Name = "Command12";
            this.Command12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command12.Size = new System.Drawing.Size(238, 55);
            this.Command12.TabIndex = 59;
            this.Command12.Text = "Demo 5: Scan all document feeder  into multipage PDF";
            this.Command12.UseVisualStyleBackColor = false;
            this.Command12.Click += new System.EventHandler(this.Command12_Click);
            // 
            // chkHideUI
            // 
            this.chkHideUI.BackColor = System.Drawing.SystemColors.Control;
            this.chkHideUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHideUI.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkHideUI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkHideUI.Location = new System.Drawing.Point(438, 143);
            this.chkHideUI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHideUI.Name = "chkHideUI";
            this.chkHideUI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkHideUI.Size = new System.Drawing.Size(86, 21);
            this.chkHideUI.TabIndex = 57;
            this.chkHideUI.Text = "Hide UI";
            this.chkHideUI.UseVisualStyleBackColor = false;
            // 
            // ChkAutoCrop
            // 
            this.ChkAutoCrop.BackColor = System.Drawing.SystemColors.Control;
            this.ChkAutoCrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChkAutoCrop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChkAutoCrop.Location = new System.Drawing.Point(20, 268);
            this.ChkAutoCrop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChkAutoCrop.Name = "ChkAutoCrop";
            this.ChkAutoCrop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkAutoCrop.Size = new System.Drawing.Size(210, 23);
            this.ChkAutoCrop.TabIndex = 56;
            this.ChkAutoCrop.Text = "Remove Black Borders";
            this.ChkAutoCrop.UseVisualStyleBackColor = false;
            // 
            // ChkNeg
            // 
            this.ChkNeg.BackColor = System.Drawing.SystemColors.Control;
            this.ChkNeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChkNeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChkNeg.Location = new System.Drawing.Point(20, 234);
            this.ChkNeg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChkNeg.Name = "ChkNeg";
            this.ChkNeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkNeg.Size = new System.Drawing.Size(170, 23);
            this.ChkNeg.TabIndex = 55;
            this.ChkNeg.Text = "Negative ";
            this.ChkNeg.UseVisualStyleBackColor = false;
            // 
            // Command6
            // 
            this.Command6.BackColor = System.Drawing.SystemColors.Control;
            this.Command6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command6.Location = new System.Drawing.Point(16, 138);
            this.Command6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command6.Name = "Command6";
            this.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command6.Size = new System.Drawing.Size(136, 26);
            this.Command6.TabIndex = 53;
            this.Command6.Text = "Source setup...";
            this.Command6.UseVisualStyleBackColor = false;
            this.Command6.Click += new System.EventHandler(this.Command6_Click);
            // 
            // chkPreview
            // 
            this.chkPreview.BackColor = System.Drawing.SystemColors.Control;
            this.chkPreview.Checked = true;
            this.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPreview.Location = new System.Drawing.Point(1402, 900);
            this.chkPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPreview.Size = new System.Drawing.Size(86, 21);
            this.chkPreview.TabIndex = 52;
            this.chkPreview.Text = "Preview";
            this.chkPreview.UseVisualStyleBackColor = false;
            // 
            // Command4
            // 
            this.Command4.BackColor = System.Drawing.SystemColors.Control;
            this.Command4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command4.Location = new System.Drawing.Point(12, 719);
            this.Command4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command4.Name = "Command4";
            this.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command4.Size = new System.Drawing.Size(238, 55);
            this.Command4.TabIndex = 51;
            this.Command4.Text = "Demo 1: Scan one document to jpeg file (acquire.jpg)";
            this.Command4.UseVisualStyleBackColor = false;
            this.Command4.Click += new System.EventHandler(this.Command4_Click);
            // 
            // Command3
            // 
            this.Command3.BackColor = System.Drawing.SystemColors.Control;
            this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command3.Location = new System.Drawing.Point(12, 781);
            this.Command3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command3.Name = "Command3";
            this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command3.Size = new System.Drawing.Size(238, 55);
            this.Command3.TabIndex = 50;
            this.Command3.Text = "Demo 2: Scan one document to pdf file (acquire.pdf)";
            this.Command3.UseVisualStyleBackColor = false;
            this.Command3.Click += new System.EventHandler(this.Command3_Click);
            // 
            // Command2
            // 
            this.Command2.BackColor = System.Drawing.SystemColors.Control;
            this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command2.Location = new System.Drawing.Point(258, 719);
            this.Command2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command2.Size = new System.Drawing.Size(238, 55);
            this.Command2.TabIndex = 49;
            this.Command2.Text = "Demo 4: Scan all document feeder (ADF) into jpeg files";
            this.Command2.UseVisualStyleBackColor = false;
            this.Command2.Click += new System.EventHandler(this.Command12_Click);
            // 
            // Command1
            // 
            this.Command1.BackColor = System.Drawing.SystemColors.Control;
            this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command1.Location = new System.Drawing.Point(12, 844);
            this.Command1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command1.Size = new System.Drawing.Size(238, 55);
            this.Command1.TabIndex = 48;
            this.Command1.Text = "Demo 3: Scan all document feeder (ADF) into multipage TIFF image multipage.tif";
            this.Command1.UseVisualStyleBackColor = false;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(8, 203);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(120, 17);
            this.Label9.TabIndex = 54;
            this.Label9.Text = "Image Processing";
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.SystemColors.WindowText;
            this.Line2.Location = new System.Drawing.Point(14, 223);
            this.Line2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(512, 1);
            this.Line2.TabIndex = 62;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 545);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.chkRemoveDots);
            this.Controls.Add(this.GdViewer1);
            this.Controls.Add(this.chkAutoDesk);
            this.Controls.Add(this.chkRotate180);
            this.Controls.Add(this.chkRotate90);
            this.Controls.Add(this.Command12);
            this.Controls.Add(this.chkHideUI);
            this.Controls.Add(this.ChkAutoCrop);
            this.Controls.Add(this.ChkNeg);
            this.Controls.Add(this.Command6);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.Command4);
            this.Controls.Add(this.Command3);
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Line2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "GdPicture.NET - WIA Acquisition Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        public  System.Windows.Forms.Label Label3; 
        internal  System.Windows.Forms.Label Label2; 
        public  System.Windows.Forms.Label Label1; 
        internal  System.Windows.Forms.Label Label10; 
        internal  System.Windows.Forms.ListBox lstDevices; 
        public  System.Windows.Forms.CheckBox chkRemoveDots; 
        internal  GdViewer GdViewer1; 
        public  System.Windows.Forms.CheckBox chkAutoDesk; 
        public  System.Windows.Forms.CheckBox chkRotate180; 
        public  System.Windows.Forms.CheckBox chkRotate90; 
        public  System.Windows.Forms.Button Command12; 
        public  System.Windows.Forms.CheckBox chkHideUI; 
        public  System.Windows.Forms.CheckBox ChkAutoCrop; 
        public  System.Windows.Forms.CheckBox ChkNeg; 
        public  System.Windows.Forms.Button Command6; 
        public  System.Windows.Forms.CheckBox chkPreview; 
        public  System.Windows.Forms.Button Command4; 
        public  System.Windows.Forms.ToolTip ToolTip1; 
        public  System.Windows.Forms.Button Command3; 
        public  System.Windows.Forms.Button Command2; 
        public  System.Windows.Forms.Button Command1; 
        public  System.Windows.Forms.Label Label9; 
        public  System.Windows.Forms.Label Line2; 
    } 
    
    
} 
