using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GdPicture14;

namespace Projet1
{
    [ global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated() ]
    partial class Form1  
    { 
        #region '"Windows Form Designer generated code "' 
        
        // Form overrides dispose to clean up the component list.
        [ System.Diagnostics.DebuggerNonUserCode() ]

        public Form1() : base()
        {

            // This call is required by the Windows Form Designer.
            InitializeComponent(); 
           
        } 


        
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
        public System.Windows.Forms.CheckBox chkUnderlined; 
        public System.Windows.Forms.Button btZoomOUT; 
        public System.Windows.Forms.Button btZoomIN; 
        public System.Windows.Forms.Timer Timer1; 
        public System.Windows.Forms.CheckBox chkItalic; 
        public System.Windows.Forms.CheckBox chkBold; 
        public System.Windows.Forms.TextBox txtFontSize; 
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
            this.chkUnderlined = new System.Windows.Forms.CheckBox();
            this.btZoomOUT = new System.Windows.Forms.Button();
            this.btZoomIN = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.SuspendLayout();
            // 
            // chkUnderlined
            // 
            this.chkUnderlined.BackColor = System.Drawing.SystemColors.Control;
            this.chkUnderlined.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUnderlined.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUnderlined.Location = new System.Drawing.Point(11, 746);
            this.chkUnderlined.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUnderlined.Name = "chkUnderlined";
            this.chkUnderlined.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUnderlined.Size = new System.Drawing.Size(105, 18);
            this.chkUnderlined.TabIndex = 7;
            this.chkUnderlined.TabStop = false;
            this.chkUnderlined.Text = "Underlined";
            this.chkUnderlined.UseVisualStyleBackColor = false;
            // 
            // btZoomOUT
            // 
            this.btZoomOUT.BackColor = System.Drawing.SystemColors.Control;
            this.btZoomOUT.Cursor = System.Windows.Forms.Cursors.Default;
            this.btZoomOUT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btZoomOUT.Location = new System.Drawing.Point(1149, 657);
            this.btZoomOUT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btZoomOUT.Name = "btZoomOUT";
            this.btZoomOUT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btZoomOUT.Size = new System.Drawing.Size(31, 23);
            this.btZoomOUT.TabIndex = 6;
            this.btZoomOUT.TabStop = false;
            this.btZoomOUT.Text = "-";
            this.btZoomOUT.UseVisualStyleBackColor = false;
            this.btZoomOUT.Click += new System.EventHandler(this.btZoomOUT_Click);
            // 
            // btZoomIN
            // 
            this.btZoomIN.BackColor = System.Drawing.SystemColors.Control;
            this.btZoomIN.Cursor = System.Windows.Forms.Cursors.Default;
            this.btZoomIN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btZoomIN.Location = new System.Drawing.Point(1184, 657);
            this.btZoomIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btZoomIN.Name = "btZoomIN";
            this.btZoomIN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btZoomIN.Size = new System.Drawing.Size(31, 23);
            this.btZoomIN.TabIndex = 5;
            this.btZoomIN.TabStop = false;
            this.btZoomIN.Text = "+";
            this.btZoomIN.UseVisualStyleBackColor = false;
            this.btZoomIN.Click += new System.EventHandler(this.btZoomIN_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // chkItalic
            // 
            this.chkItalic.BackColor = System.Drawing.SystemColors.Control;
            this.chkItalic.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkItalic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkItalic.Location = new System.Drawing.Point(11, 721);
            this.chkItalic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkItalic.Size = new System.Drawing.Size(65, 18);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.TabStop = false;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = false;
            // 
            // chkBold
            // 
            this.chkBold.BackColor = System.Drawing.SystemColors.Control;
            this.chkBold.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkBold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkBold.Location = new System.Drawing.Point(11, 692);
            this.chkBold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBold.Name = "chkBold";
            this.chkBold.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBold.Size = new System.Drawing.Size(76, 23);
            this.chkBold.TabIndex = 2;
            this.chkBold.TabStop = false;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = false;
            // 
            // txtFontSize
            // 
            this.txtFontSize.AcceptsReturn = true;
            this.txtFontSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtFontSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFontSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFontSize.Location = new System.Drawing.Point(83, 657);
            this.txtFontSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFontSize.MaxLength = 0;
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFontSize.Size = new System.Drawing.Size(45, 22);
            this.txtFontSize.TabIndex = 1;
            this.txtFontSize.TabStop = false;
            this.txtFontSize.Text = "9";
            this.txtFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(525, 662);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(200, 17);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Click on the viewer to write text";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(11, 662);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(75, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Font Size :";
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
            this.GdViewer1.Location = new System.Drawing.Point(7, 15);
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
            this.GdViewer1.Size = new System.Drawing.Size(1207, 635);
            this.GdViewer1.TabIndex = 9;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 1D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100;
            this.GdViewer1.ZoomStep = 25;
            this.GdViewer1.PageDisplayed += new GdPicture14.GdViewer.PageDisplayedEventHandler(this.GdViewer1_PageDisplayed);
            this.GdViewer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GdViewer1_KeyPress);
            this.GdViewer1.Leave += new System.EventHandler(this.gdviewer1_Leave);
            this.GdViewer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GdViewer1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1224, 778);
            this.Controls.Add(this.GdViewer1);
            this.Controls.Add(this.chkUnderlined);
            this.Controls.Add(this.btZoomOUT);
            this.Controls.Add(this.btZoomIN);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(4, 30);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GdPicture.NET - Text Writter Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal   GdViewer GdViewer1; 
        #endregion 
    } 
    
} 
