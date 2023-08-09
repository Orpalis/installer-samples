using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GdPicture14;

namespace twain_sample
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
               bool fTerminateCalled = false; 
                if ( !( fTerminateCalled ) ) 
                { 
                    fTerminateCalled = true; 
                } 
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
        public   System.Windows.Forms.CheckBox chkRotate180; 
        public   System.Windows.Forms.CheckBox chkRotate90; 
        public   System.Windows.Forms.Button Command12; 
        public   System.Windows.Forms.CheckBox chkIndicator; 
        public   System.Windows.Forms.CheckBox chkHideUI; 
        public   System.Windows.Forms.CheckBox ChkAutoCrop; 
        public   System.Windows.Forms.CheckBox ChkNeg; 
        public   System.Windows.Forms.Button Command11; 
        public   System.Windows.Forms.Button Command10; 
        public   System.Windows.Forms.Button Command9; 
        public   System.Windows.Forms.Button Command8; 
        public   System.Windows.Forms.Button Command7; 
        public   System.Windows.Forms.Button Command6; 
        public   System.Windows.Forms.Button Command5; 
        public   System.Windows.Forms.CheckBox chkDuplex; 
        public   System.Windows.Forms.CheckBox chkAutoBrightness; 
        public   System.Windows.Forms.HScrollBar HContrast; 
        public   System.Windows.Forms.HScrollBar HBrightness; 
        public   System.Windows.Forms.CheckBox chkPreview; 
        public   System.Windows.Forms.Button Command4; 
        public   System.Windows.Forms.Button Command3; 
        public   System.Windows.Forms.Button Command2; 
        public   System.Windows.Forms.Button Command1; 
        public   System.Windows.Forms.Label Line3; 
        public   System.Windows.Forms.Label Label9; 
        public   System.Windows.Forms.Label Line2; 
        public   System.Windows.Forms.Label Label8; 
        public   System.Windows.Forms.Label Line1; 
        public   System.Windows.Forms.Label Label7; 
        public   System.Windows.Forms.Label Label6; 
        public   System.Windows.Forms.Label Label5; 
        public   System.Windows.Forms.Label Label4; 
        public   System.Windows.Forms.Label Label3; 
        public   System.Windows.Forms.Label Label2; 
        public   System.Windows.Forms.Label Label1; 
        public   System.Windows.Forms.Label Brightness; 
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkRotate180 = new System.Windows.Forms.CheckBox();
            this.chkRotate90 = new System.Windows.Forms.CheckBox();
            this.Command12 = new System.Windows.Forms.Button();
            this.chkIndicator = new System.Windows.Forms.CheckBox();
            this.chkHideUI = new System.Windows.Forms.CheckBox();
            this.ChkAutoCrop = new System.Windows.Forms.CheckBox();
            this.ChkNeg = new System.Windows.Forms.CheckBox();
            this.Command11 = new System.Windows.Forms.Button();
            this.Command10 = new System.Windows.Forms.Button();
            this.Command9 = new System.Windows.Forms.Button();
            this.Command8 = new System.Windows.Forms.Button();
            this.Command7 = new System.Windows.Forms.Button();
            this.Command6 = new System.Windows.Forms.Button();
            this.Command5 = new System.Windows.Forms.Button();
            this.chkDuplex = new System.Windows.Forms.CheckBox();
            this.chkAutoBrightness = new System.Windows.Forms.CheckBox();
            this.HContrast = new System.Windows.Forms.HScrollBar();
            this.HBrightness = new System.Windows.Forms.HScrollBar();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.Command4 = new System.Windows.Forms.Button();
            this.Command3 = new System.Windows.Forms.Button();
            this.Command2 = new System.Windows.Forms.Button();
            this.Command1 = new System.Windows.Forms.Button();
            this.Line3 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Line1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Brightness = new System.Windows.Forms.Label();
            this.chkAutoDesk = new System.Windows.Forms.CheckBox();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.chkRemoveDots = new System.Windows.Forms.CheckBox();
            this.chkRemoveBlankPages = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkRotate180
            // 
            this.chkRotate180.BackColor = System.Drawing.SystemColors.Control;
            this.chkRotate180.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRotate180.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRotate180.Location = new System.Drawing.Point(188, 441);
            this.chkRotate180.Name = "chkRotate180";
            this.chkRotate180.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRotate180.Size = new System.Drawing.Size(128, 19);
            this.chkRotate180.TabIndex = 34;
            this.chkRotate180.Text = "Rotate 180°";
            this.chkRotate180.UseVisualStyleBackColor = false;
            // 
            // chkRotate90
            // 
            this.chkRotate90.BackColor = System.Drawing.SystemColors.Control;
            this.chkRotate90.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRotate90.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRotate90.Location = new System.Drawing.Point(188, 416);
            this.chkRotate90.Name = "chkRotate90";
            this.chkRotate90.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRotate90.Size = new System.Drawing.Size(128, 19);
            this.chkRotate90.TabIndex = 33;
            this.chkRotate90.Text = "Rotate 90°";
            this.chkRotate90.UseVisualStyleBackColor = false;
            // 
            // Command12
            // 
            this.Command12.BackColor = System.Drawing.SystemColors.Control;
            this.Command12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command12.Location = new System.Drawing.Point(740, 523);
            this.Command12.Name = "Command12";
            this.Command12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command12.Size = new System.Drawing.Size(178, 45);
            this.Command12.TabIndex = 32;
            this.Command12.Text = "Demo 5: Scan all pages into a multipage PDF";
            this.Command12.UseVisualStyleBackColor = false;
            this.Command12.Click += new System.EventHandler(this.Command12_Click);
            // 
            // chkIndicator
            // 
            this.chkIndicator.BackColor = System.Drawing.SystemColors.Control;
            this.chkIndicator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIndicator.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkIndicator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkIndicator.Location = new System.Drawing.Point(220, 334);
            this.chkIndicator.Name = "chkIndicator";
            this.chkIndicator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkIndicator.Size = new System.Drawing.Size(164, 17);
            this.chkIndicator.TabIndex = 31;
            this.chkIndicator.Text = "Show Progress Indicator";
            this.chkIndicator.UseVisualStyleBackColor = false;
            // 
            // chkHideUI
            // 
            this.chkHideUI.BackColor = System.Drawing.SystemColors.Control;
            this.chkHideUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHideUI.Checked = true;
            this.chkHideUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHideUI.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkHideUI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkHideUI.Location = new System.Drawing.Point(320, 358);
            this.chkHideUI.Name = "chkHideUI";
            this.chkHideUI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkHideUI.Size = new System.Drawing.Size(64, 17);
            this.chkHideUI.TabIndex = 30;
            this.chkHideUI.Text = "Hide UI";
            this.chkHideUI.UseVisualStyleBackColor = false;
            // 
            // ChkAutoCrop
            // 
            this.ChkAutoCrop.BackColor = System.Drawing.SystemColors.Control;
            this.ChkAutoCrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChkAutoCrop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChkAutoCrop.Location = new System.Drawing.Point(6, 441);
            this.ChkAutoCrop.Name = "ChkAutoCrop";
            this.ChkAutoCrop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkAutoCrop.Size = new System.Drawing.Size(158, 19);
            this.ChkAutoCrop.TabIndex = 27;
            this.ChkAutoCrop.Text = "Remove Black Borders";
            this.ChkAutoCrop.UseVisualStyleBackColor = false;
            // 
            // ChkNeg
            // 
            this.ChkNeg.BackColor = System.Drawing.SystemColors.Control;
            this.ChkNeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChkNeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChkNeg.Location = new System.Drawing.Point(6, 416);
            this.ChkNeg.Name = "ChkNeg";
            this.ChkNeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkNeg.Size = new System.Drawing.Size(128, 19);
            this.ChkNeg.TabIndex = 26;
            this.ChkNeg.Text = "Negative ";
            this.ChkNeg.UseVisualStyleBackColor = false;
            // 
            // Command11
            // 
            this.Command11.BackColor = System.Drawing.SystemColors.Control;
            this.Command11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command11.Location = new System.Drawing.Point(220, 96);
            this.Command11.Name = "Command11";
            this.Command11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command11.Size = new System.Drawing.Size(154, 35);
            this.Command11.TabIndex = 23;
            this.Command11.Text = "Unload source manager";
            this.Command11.UseVisualStyleBackColor = false;
            this.Command11.Click += new System.EventHandler(this.Command11_Click);
            // 
            // Command10
            // 
            this.Command10.BackColor = System.Drawing.SystemColors.Control;
            this.Command10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command10.Location = new System.Drawing.Point(220, 52);
            this.Command10.Name = "Command10";
            this.Command10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command10.Size = new System.Drawing.Size(154, 35);
            this.Command10.TabIndex = 22;
            this.Command10.Text = "Close source manager";
            this.Command10.UseVisualStyleBackColor = false;
            this.Command10.Click += new System.EventHandler(this.Command10_Click);
            // 
            // Command9
            // 
            this.Command9.BackColor = System.Drawing.SystemColors.Control;
            this.Command9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command9.Location = new System.Drawing.Point(220, 8);
            this.Command9.Name = "Command9";
            this.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command9.Size = new System.Drawing.Size(154, 35);
            this.Command9.TabIndex = 21;
            this.Command9.Text = "Close source";
            this.Command9.UseVisualStyleBackColor = false;
            this.Command9.Click += new System.EventHandler(this.Command9_Click);
            // 
            // Command8
            // 
            this.Command8.BackColor = System.Drawing.SystemColors.Control;
            this.Command8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command8.Location = new System.Drawing.Point(20, 52);
            this.Command8.Name = "Command8";
            this.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command8.Size = new System.Drawing.Size(154, 35);
            this.Command8.TabIndex = 20;
            this.Command8.Text = "Open selected source";
            this.Command8.UseVisualStyleBackColor = false;
            this.Command8.Click += new System.EventHandler(this.Command8_Click);
            // 
            // Command7
            // 
            this.Command7.BackColor = System.Drawing.SystemColors.Control;
            this.Command7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command7.Location = new System.Drawing.Point(118, 144);
            this.Command7.Name = "Command7";
            this.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command7.Size = new System.Drawing.Size(154, 35);
            this.Command7.TabIndex = 19;
            this.Command7.Text = "Show TWAIN State";
            this.Command7.UseVisualStyleBackColor = false;
            this.Command7.Click += new System.EventHandler(this.Command7_Click);
            // 
            // Command6
            // 
            this.Command6.BackColor = System.Drawing.SystemColors.Control;
            this.Command6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command6.Location = new System.Drawing.Point(20, 96);
            this.Command6.Name = "Command6";
            this.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command6.Size = new System.Drawing.Size(154, 35);
            this.Command6.TabIndex = 18;
            this.Command6.Text = "Source SETUP...";
            this.Command6.UseVisualStyleBackColor = false;
            this.Command6.Click += new System.EventHandler(this.Command6_Click);
            // 
            // Command5
            // 
            this.Command5.BackColor = System.Drawing.SystemColors.Control;
            this.Command5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command5.Location = new System.Drawing.Point(20, 8);
            this.Command5.Name = "Command5";
            this.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command5.Size = new System.Drawing.Size(154, 35);
            this.Command5.TabIndex = 17;
            this.Command5.Text = "Select source";
            this.Command5.UseVisualStyleBackColor = false;
            this.Command5.Click += new System.EventHandler(this.Command5_Click);
            // 
            // chkDuplex
            // 
            this.chkDuplex.BackColor = System.Drawing.SystemColors.Control;
            this.chkDuplex.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkDuplex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkDuplex.Location = new System.Drawing.Point(6, 358);
            this.chkDuplex.Name = "chkDuplex";
            this.chkDuplex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkDuplex.Size = new System.Drawing.Size(147, 17);
            this.chkDuplex.TabIndex = 16;
            this.chkDuplex.Text = "Enable Duplex";
            this.chkDuplex.UseVisualStyleBackColor = false;
            // 
            // chkAutoBrightness
            // 
            this.chkAutoBrightness.BackColor = System.Drawing.SystemColors.Control;
            this.chkAutoBrightness.Checked = true;
            this.chkAutoBrightness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoBrightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAutoBrightness.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAutoBrightness.Location = new System.Drawing.Point(6, 263);
            this.chkAutoBrightness.Name = "chkAutoBrightness";
            this.chkAutoBrightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAutoBrightness.Size = new System.Drawing.Size(158, 17);
            this.chkAutoBrightness.TabIndex = 15;
            this.chkAutoBrightness.Text = "Auto-Brightness";
            this.chkAutoBrightness.UseVisualStyleBackColor = false;
            // 
            // HContrast
            // 
            this.HContrast.Cursor = System.Windows.Forms.Cursors.Default;
            this.HContrast.LargeChange = 1;
            this.HContrast.Location = new System.Drawing.Point(6, 298);
            this.HContrast.Maximum = 1000;
            this.HContrast.Minimum = -1000;
            this.HContrast.Name = "HContrast";
            this.HContrast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HContrast.Size = new System.Drawing.Size(378, 21);
            this.HContrast.TabIndex = 10;
            this.HContrast.TabStop = true;
            // 
            // HBrightness
            // 
            this.HBrightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.HBrightness.LargeChange = 1;
            this.HBrightness.Location = new System.Drawing.Point(6, 223);
            this.HBrightness.Maximum = 1000;
            this.HBrightness.Minimum = -1000;
            this.HBrightness.Name = "HBrightness";
            this.HBrightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HBrightness.Size = new System.Drawing.Size(378, 21);
            this.HBrightness.TabIndex = 5;
            this.HBrightness.TabStop = true;
            // 
            // chkPreview
            // 
            this.chkPreview.BackColor = System.Drawing.SystemColors.Control;
            this.chkPreview.Checked = true;
            this.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPreview.Location = new System.Drawing.Point(398, 482);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPreview.Size = new System.Drawing.Size(153, 17);
            this.chkPreview.TabIndex = 4;
            this.chkPreview.Text = "Preview";
            this.chkPreview.UseVisualStyleBackColor = false;
            // 
            // Command4
            // 
            this.Command4.BackColor = System.Drawing.SystemColors.Control;
            this.Command4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command4.Location = new System.Drawing.Point(6, 523);
            this.Command4.Name = "Command4";
            this.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command4.Size = new System.Drawing.Size(178, 45);
            this.Command4.TabIndex = 3;
            this.Command4.Text = "Demo 1: Scan one page to jpeg file (acquire.jpg)";
            this.Command4.UseVisualStyleBackColor = false;
            this.Command4.Click += new System.EventHandler(this.Command4_Click);
            // 
            // Command3
            // 
            this.Command3.BackColor = System.Drawing.SystemColors.Control;
            this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command3.Location = new System.Drawing.Point(188, 523);
            this.Command3.Name = "Command3";
            this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command3.Size = new System.Drawing.Size(178, 45);
            this.Command3.TabIndex = 2;
            this.Command3.Text = "Demo 2: Scan one page to pdf file (acquire.pdf)";
            this.Command3.UseVisualStyleBackColor = false;
            this.Command3.Click += new System.EventHandler(this.Command3_Click);
            // 
            // Command2
            // 
            this.Command2.BackColor = System.Drawing.SystemColors.Control;
            this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command2.Location = new System.Drawing.Point(554, 523);
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command2.Size = new System.Drawing.Size(178, 45);
            this.Command2.TabIndex = 1;
            this.Command2.Text = "Demo 4: Scan all page in jpeg files";
            this.Command2.UseVisualStyleBackColor = false;
            this.Command2.Click += new System.EventHandler(this.Command2_Click);
            // 
            // Command1
            // 
            this.Command1.BackColor = System.Drawing.SystemColors.Control;
            this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command1.Location = new System.Drawing.Point(370, 523);
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command1.Size = new System.Drawing.Size(178, 45);
            this.Command1.TabIndex = 0;
            this.Command1.Text = "Demo 3: Scan all page in multipage TIFF image multipage.tif";
            this.Command1.UseVisualStyleBackColor = false;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.SystemColors.WindowText;
            this.Line3.Location = new System.Drawing.Point(10, 382);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(370, 1);
            this.Line3.TabIndex = 37;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(112, 388);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(135, 13);
            this.Label9.TabIndex = 25;
            this.Label9.Text = "Some image filters / effects";
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.SystemColors.WindowText;
            this.Line2.Location = new System.Drawing.Point(6, 515);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(924, 1);
            this.Line2.TabIndex = 38;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(116, 196);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(132, 13);
            this.Label8.TabIndex = 24;
            this.Label8.Text = "Basic device configuration";
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.SystemColors.WindowText;
            this.Line1.Location = new System.Drawing.Point(10, 190);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(370, 1);
            this.Line1.TabIndex = 39;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(360, 318);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(31, 13);
            this.Label7.TabIndex = 14;
            this.Label7.Text = "1000";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(6, 324);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(34, 13);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "-1000";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(190, 324);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(13, 13);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "0";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(6, 284);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(46, 13);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Contrast";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(360, 249);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(31, 13);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "1000";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(6, 249);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(34, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "-1000";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(190, 249);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(13, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "0";
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = true;
            this.Brightness.BackColor = System.Drawing.Color.Transparent;
            this.Brightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.Brightness.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Brightness.Location = new System.Drawing.Point(6, 209);
            this.Brightness.Name = "Brightness";
            this.Brightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Brightness.Size = new System.Drawing.Size(56, 13);
            this.Brightness.TabIndex = 6;
            this.Brightness.Text = "Brightness";
            // 
            // chkAutoDesk
            // 
            this.chkAutoDesk.BackColor = System.Drawing.SystemColors.Control;
            this.chkAutoDesk.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAutoDesk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAutoDesk.Location = new System.Drawing.Point(6, 466);
            this.chkAutoDesk.Name = "chkAutoDesk";
            this.chkAutoDesk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAutoDesk.Size = new System.Drawing.Size(92, 19);
            this.chkAutoDesk.TabIndex = 40;
            this.chkAutoDesk.Text = "Auto Deskew";
            this.chkAutoDesk.UseVisualStyleBackColor = false;
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDrop = true;
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
            this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer1.DrawPageBorders = true;
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
            this.GdViewer1.Location = new System.Drawing.Point(398, 8);
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
            this.GdViewer1.SilentMode = false;
            this.GdViewer1.Size = new System.Drawing.Size(532, 468);
            this.GdViewer1.TabIndex = 41;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            // 
            // chkRemoveDots
            // 
            this.chkRemoveDots.BackColor = System.Drawing.SystemColors.Control;
            this.chkRemoveDots.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRemoveDots.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRemoveDots.Location = new System.Drawing.Point(188, 466);
            this.chkRemoveDots.Name = "chkRemoveDots";
            this.chkRemoveDots.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRemoveDots.Size = new System.Drawing.Size(176, 19);
            this.chkRemoveDots.TabIndex = 42;
            this.chkRemoveDots.Text = "Remove isolated dots";
            this.chkRemoveDots.UseVisualStyleBackColor = false;
            // 
            // chkRemoveBlankPages
            // 
            this.chkRemoveBlankPages.BackColor = System.Drawing.SystemColors.Control;
            this.chkRemoveBlankPages.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRemoveBlankPages.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRemoveBlankPages.Location = new System.Drawing.Point(6, 491);
            this.chkRemoveBlankPages.Name = "chkRemoveBlankPages";
            this.chkRemoveBlankPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRemoveBlankPages.Size = new System.Drawing.Size(176, 19);
            this.chkRemoveBlankPages.TabIndex = 43;
            this.chkRemoveBlankPages.Text = "Discard blank pages";
            this.chkRemoveBlankPages.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(939, 582);
            this.Controls.Add(this.chkRemoveBlankPages);
            this.Controls.Add(this.chkRemoveDots);
            this.Controls.Add(this.GdViewer1);
            this.Controls.Add(this.chkAutoDesk);
            this.Controls.Add(this.chkRotate180);
            this.Controls.Add(this.chkRotate90);
            this.Controls.Add(this.Command12);
            this.Controls.Add(this.chkIndicator);
            this.Controls.Add(this.chkHideUI);
            this.Controls.Add(this.ChkAutoCrop);
            this.Controls.Add(this.ChkNeg);
            this.Controls.Add(this.Command11);
            this.Controls.Add(this.Command10);
            this.Controls.Add(this.Command9);
            this.Controls.Add(this.Command8);
            this.Controls.Add(this.Command7);
            this.Controls.Add(this.Command6);
            this.Controls.Add(this.Command5);
            this.Controls.Add(this.chkDuplex);
            this.Controls.Add(this.chkAutoBrightness);
            this.Controls.Add(this.HContrast);
            this.Controls.Add(this.HBrightness);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.Command4);
            this.Controls.Add(this.Command3);
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Brightness);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(4, 30);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gdpicture.NET - TWAIN Acquisition Sample  -  http://www.gdpicture.com";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        public   System.Windows.Forms.CheckBox chkAutoDesk; 
        internal   GdViewer GdViewer1; 
        public   System.Windows.Forms.CheckBox chkRemoveDots; 
        #endregion 
        public CheckBox chkRemoveBlankPages;
    } 
    
} 
