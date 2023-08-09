using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using GdPicture14;

namespace OMR
{
  
    partial class Form1 : System.Windows.Forms.Form 
    { 
        
        // Form overrides dispose to clean up the component list.
        [ System.Diagnostics.DebuggerNonUserCode() ]
        protected override void Dispose( bool disposing ) 
        { 
            try 
            { 
                if ( disposing && components != null ) 
                { 
                    components.Dispose(); 
                } 
            } 
            finally 
            { 
                base.Dispose( disposing ); 
            } 
        } 
        
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components; 
        
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.SplitContainer3 = new System.Windows.Forms.SplitContainer();
            this.Label6 = new System.Windows.Forms.Label();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Label5 = new System.Windows.Forms.Label();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.GdViewer2 = new GdPicture14.GdViewer();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer3)).BeginInit();
            this.SplitContainer3.Panel1.SuspendLayout();
            this.SplitContainer3.Panel2.SuspendLayout();
            this.SplitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1260, 732);
            this.TabControl1.TabIndex = 2;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            this.TabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl1_Selecting);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.SplitContainer3);
            this.TabPage1.Location = new System.Drawing.Point(4, 4);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage1.Size = new System.Drawing.Size(1252, 703);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Template Designer";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // SplitContainer3
            // 
            this.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer3.Location = new System.Drawing.Point(4, 4);
            this.SplitContainer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplitContainer3.Name = "SplitContainer3";
            // 
            // SplitContainer3.Panel1
            // 
            this.SplitContainer3.Panel1.Controls.Add(this.Label6);
            this.SplitContainer3.Panel1.Controls.Add(this.NumericUpDown2);
            this.SplitContainer3.Panel1.Controls.Add(this.Label5);
            this.SplitContainer3.Panel1.Controls.Add(this.NumericUpDown1);
            this.SplitContainer3.Panel1.Controls.Add(this.Label4);
            this.SplitContainer3.Panel1.Controls.Add(this.Label3);
            this.SplitContainer3.Panel1.Controls.Add(this.Label2);
            this.SplitContainer3.Panel1.Controls.Add(this.Label1);
            this.SplitContainer3.Panel1.Controls.Add(this.Button2);
            // 
            // SplitContainer3.Panel2
            // 
            this.SplitContainer3.Panel2.Controls.Add(this.GdViewer2);
            this.SplitContainer3.Size = new System.Drawing.Size(1244, 695);
            this.SplitContainer3.SplitterDistance = 451;
            this.SplitContainer3.SplitterWidth = 5;
            this.SplitContainer3.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(49, 263);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(96, 17);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "- height (mm):";
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Location = new System.Drawing.Point(159, 261);
            this.NumericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(79, 22);
            this.NumericUpDown2.TabIndex = 10;
            this.NumericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(49, 235);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(89, 17);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "- width (mm):";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(159, 233);
            this.NumericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(79, 22);
            this.NumericUpDown1.TabIndex = 8;
            this.NumericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(29, 203);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(175, 17);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Size of the area to search:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 82);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(225, 17);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "3- Click on the Testing bottom Tab";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 48);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(430, 17);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "2- Draw a box around a shape on the Template image (the anchor)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 18);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(261, 17);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "1- Open an Image (the Template Image)";
            // 
            // Button2
            // 
            this.Button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button2.Location = new System.Drawing.Point(0, 641);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(451, 54);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Load Template Image";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GdViewer2
            // 
            this.GdViewer2.AllowDropFile = false;
            this.GdViewer2.AnimateGIF = false;
            this.GdViewer2.AnnotationDropShadow = true;
            this.GdViewer2.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.GdViewer2.AnnotationResizeRotateHandlesScale = 1F;
            this.GdViewer2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewer2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewer2.BackColor = System.Drawing.Color.Black;
            this.GdViewer2.BackgroundImage = null;
            this.GdViewer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewer2.ContinuousViewMode = true;
            this.GdViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewer2.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.GdViewer2.DisplayQualityAuto = false;
            this.GdViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdViewer2.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer2.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer2.EnableDeferredPainting = true;
            this.GdViewer2.EnabledProgressBar = true;
            this.GdViewer2.EnableICM = false;
            this.GdViewer2.EnableMenu = true;
            this.GdViewer2.EnableMouseWheel = true;
            this.GdViewer2.EnableTextSelection = true;
            this.GdViewer2.ForceScrollBars = false;
            this.GdViewer2.ForeColor = System.Drawing.Color.Black;
            this.GdViewer2.Gamma = 1F;
            this.GdViewer2.HQAnnotationRendering = true;
            this.GdViewer2.IgnoreDocumentResolution = false;
            this.GdViewer2.KeepDocumentPosition = false;
            this.GdViewer2.Location = new System.Drawing.Point(0, 0);
            this.GdViewer2.LockViewer = false;
            this.GdViewer2.MagnifierHeight = 90;
            this.GdViewer2.MagnifierWidth = 160;
            this.GdViewer2.MagnifierZoomX = 2F;
            this.GdViewer2.MagnifierZoomY = 2F;
            this.GdViewer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GdViewer2.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdViewer2.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.GdViewer2.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
            this.GdViewer2.Name = "GdViewer2";
            this.GdViewer2.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView;
            this.GdViewer2.PdfDisplayFormField = true;
            this.GdViewer2.PdfEnableFileLinks = true;
            this.GdViewer2.PdfEnableLinks = true;
            this.GdViewer2.PdfIncreaseTextContrast = false;
            this.GdViewer2.PdfShowDialogForPassword = true;
            this.GdViewer2.PdfShowOpenFileDialogForDecryption = true;
            this.GdViewer2.PdfVerifyDigitalCertificates = false;
            this.GdViewer2.RectBorderColor = System.Drawing.Color.Black;
            this.GdViewer2.RectBorderSize = 1;
            this.GdViewer2.RectIsEditable = false;
            this.GdViewer2.RegionsAreEditable = true;
            this.GdViewer2.RenderGdPictureAnnots = true;
            this.GdViewer2.ScrollBars = true;
            this.GdViewer2.ScrollLargeChange = ((short)(50));
            this.GdViewer2.ScrollSmallChange = ((short)(1));
            this.GdViewer2.SilentMode = true;
            this.GdViewer2.Size = new System.Drawing.Size(788, 695);
            this.GdViewer2.TabIndex = 0;
            this.GdViewer2.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer2.Zoom = 0.001D;
            this.GdViewer2.ZoomCenterAtMousePosition = false;
            this.GdViewer2.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer2.ZoomStep = 25;
            this.GdViewer2.RegionEditedByUser += new GdPicture14.GdViewer.RegionEditedByUserEventHandler(this.GdViewer2_RegionEditedByUser);
            this.GdViewer2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GdViewer2_MouseUp);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.SplitContainer1);
            this.TabPage2.Location = new System.Drawing.Point(4, 4);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabPage2.Size = new System.Drawing.Size(1252, 703);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Testing";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(4, 4);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.SplitContainer2);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.GdViewer1);
            this.SplitContainer1.Size = new System.Drawing.Size(1244, 695);
            this.SplitContainer1.SplitterDistance = 309;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 4;
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SplitContainer2.Name = "SplitContainer2";
            this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.ListBox1);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.CheckBox1);
            this.SplitContainer2.Panel2.Controls.Add(this.Button4);
            this.SplitContainer2.Panel2.Controls.Add(this.Button3);
            this.SplitContainer2.Panel2.Controls.Add(this.Button1);
            this.SplitContainer2.Size = new System.Drawing.Size(309, 695);
            this.SplitContainer2.SplitterDistance = 589;
            this.SplitContainer2.SplitterWidth = 1;
            this.SplitContainer2.TabIndex = 2;
            // 
            // ListBox1
            // 
            this.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox1.IntegralHeight = false;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(0, 0);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(309, 589);
            this.ListBox1.TabIndex = 1;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox1.Location = new System.Drawing.Point(4, 1);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(143, 21);
            this.CheckBox1.TabIndex = 5;
            this.CheckBox1.Text = "High Speed Mode";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            this.Button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button4.Location = new System.Drawing.Point(0, -3);
            this.Button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(309, 36);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "Add Images";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button3.Location = new System.Drawing.Point(0, 33);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(309, 36);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "Clear List";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button1.Location = new System.Drawing.Point(0, 69);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(309, 36);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Run !";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.GdViewer1.ContinuousViewMode = true;
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
            this.GdViewer1.RegionsAreEditable = false;
            this.GdViewer1.RenderGdPictureAnnots = true;
            this.GdViewer1.ScrollBars = true;
            this.GdViewer1.ScrollLargeChange = ((short)(50));
            this.GdViewer1.ScrollSmallChange = ((short)(1));
            this.GdViewer1.SilentMode = true;
            this.GdViewer1.Size = new System.Drawing.Size(930, 695);
            this.GdViewer1.TabIndex = 0;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 732);
            this.Controls.Add(this.TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "GdPicture.NET - OMR - Anchor Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.SplitContainer3.Panel1.ResumeLayout(false);
            this.SplitContainer3.Panel1.PerformLayout();
            this.SplitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer3)).EndInit();
            this.SplitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            this.SplitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        } 
        
        internal  System.Windows.Forms.TabControl TabControl1; 
        internal  System.Windows.Forms.TabPage TabPage1; 
        internal  System.Windows.Forms.TabPage TabPage2; 
        internal  System.Windows.Forms.SplitContainer SplitContainer1; 
        internal  GdViewer GdViewer1; 
        internal  System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem; 
        internal  System.Windows.Forms.OpenFileDialog OpenFileDialog1; 
        internal  System.Windows.Forms.SplitContainer SplitContainer2; 
        internal  System.Windows.Forms.ListBox ListBox1; 
        internal  System.Windows.Forms.Button Button1; 
        internal  System.Windows.Forms.SplitContainer SplitContainer3; 
        internal  GdViewer GdViewer2; 
        internal  System.Windows.Forms.Button Button2; 
        internal  System.Windows.Forms.Label Label3; 
        internal  System.Windows.Forms.Label Label2; 
        internal  System.Windows.Forms.Label Label1; 
        internal  System.Windows.Forms.Label Label6; 
        internal  System.Windows.Forms.NumericUpDown NumericUpDown2; 
        internal  System.Windows.Forms.Label Label5; 
        internal  System.Windows.Forms.NumericUpDown NumericUpDown1; 
        internal  System.Windows.Forms.Label Label4; 
        internal  System.Windows.Forms.Button Button3; 
        internal  System.Windows.Forms.Button Button4; 
        internal  System.Windows.Forms.CheckBox CheckBox1; 
        
    } 
    
    
} 
