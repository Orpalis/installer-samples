using System;
using System.Windows.Forms;



namespace barcode_recognition
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.Run(new MainForm());
        }

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RemoveHorizontalLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveVerticalLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageEnhancementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.MedianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoDeskewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RepairCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate90DegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label2 = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Command2 = new System.Windows.Forms.Button();
            this.Command3 = new System.Windows.Forms.Button();
            this.lbImageInfo = new System.Windows.Forms.Label();
            this.chkDetect1D = new System.Windows.Forms.CheckBox();
            this.chkDetectDataMatrix = new System.Windows.Forms.CheckBox();
            this.chkDetectQRCode = new System.Windows.Forms.CheckBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.pan1Dtypes = new System.Windows.Forms.Panel();
            this.chkUseCorrupted = new System.Windows.Forms.CheckBox();
            this.chkAdd2 = new System.Windows.Forms.CheckBox();
            this.chkAdd5 = new System.Windows.Forms.CheckBox();
            this.chkUPCE = new System.Windows.Forms.CheckBox();
            this.chkEAN8 = new System.Windows.Forms.CheckBox();
            this.chkUPCA = new System.Windows.Forms.CheckBox();
            this.chkEAN13 = new System.Windows.Forms.CheckBox();
            this.chkCODE93 = new System.Windows.Forms.CheckBox();
            this.chkCode128 = new System.Windows.Forms.CheckBox();
            this.chkDataLogic2of5 = new System.Windows.Forms.CheckBox();
            this.chkBcdMatrix = new System.Windows.Forms.CheckBox();
            this.chkCodeabar = new System.Windows.Forms.CheckBox();
            this.chkCode39 = new System.Windows.Forms.CheckBox();
            this.chkMatrix2of5 = new System.Windows.Forms.CheckBox();
            this.chkIata2of5 = new System.Windows.Forms.CheckBox();
            this.chkInterleaved2of5 = new System.Windows.Forms.CheckBox();
            this.chkInverted2of5 = new System.Windows.Forms.CheckBox();
            this.chkIndustrial2of5 = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.nupBcCount = new System.Windows.Forms.NumericUpDown();
            this.chkHQDetection = new System.Windows.Forms.CheckBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lbPage = new System.Windows.Forms.Label();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.chkDetectPDF417 = new System.Windows.Forms.CheckBox();
            this.chkDetectMicroQRCode = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDetectMaxicode = new System.Windows.Forms.CheckBox();
            this.chkDetectAztec = new System.Windows.Forms.CheckBox();
            this.chkDetectPathCode = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuStrip1.SuspendLayout();
            this.pan1Dtypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBcCount)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveHorizontalLinesToolStripMenuItem
            // 
            this.RemoveHorizontalLinesToolStripMenuItem.Name = "RemoveHorizontalLinesToolStripMenuItem";
            this.RemoveHorizontalLinesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.RemoveHorizontalLinesToolStripMenuItem.Text = "Remove horizontal lines";
            this.RemoveHorizontalLinesToolStripMenuItem.Click += new System.EventHandler(this.RemoveHorizontalLinesToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem12
            // 
            this.ToolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HorizontalToolStripMenuItem,
            this.VerticalToolStripMenuItem});
            this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
            this.ToolStripMenuItem12.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem12.Text = "Fill Holes";
            // 
            // HorizontalToolStripMenuItem
            // 
            this.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem";
            this.HorizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.HorizontalToolStripMenuItem.Text = "Horizontal";
            this.HorizontalToolStripMenuItem.Click += new System.EventHandler(this.HorizontalToolStripMenuItem_Click);
            // 
            // VerticalToolStripMenuItem
            // 
            this.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem";
            this.VerticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.VerticalToolStripMenuItem.Text = "Vertical";
            this.VerticalToolStripMenuItem.Click += new System.EventHandler(this.VerticalToolStripMenuItem_Click);
            // 
            // RemoveVerticalLinesToolStripMenuItem
            // 
            this.RemoveVerticalLinesToolStripMenuItem.Name = "RemoveVerticalLinesToolStripMenuItem";
            this.RemoveVerticalLinesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.RemoveVerticalLinesToolStripMenuItem.Text = "Remove vertical lines";
            this.RemoveVerticalLinesToolStripMenuItem.Click += new System.EventHandler(this.RemoveVerticalLinesToolStripMenuItem_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(170, 46);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(191, 17);
            this.CheckBox1.TabIndex = 20;
            this.CheckBox1.Text = "Don\'t draw barcodes bounding box";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // ToolStripMenuItem7
            // 
            this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
            this.ToolStripMenuItem7.Size = new System.Drawing.Size(105, 22);
            this.ToolStripMenuItem7.Text = "300%";
            this.ToolStripMenuItem7.Click += new System.EventHandler(this.ToolStripMenuItem7_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ImageEnhancementToolStripMenuItem,
            this.StartToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.MenuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.MenuStrip1.TabIndex = 18;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ReloadLastToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.OpenToolStripMenuItem.Text = "Open...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ReloadLastToolStripMenuItem
            // 
            this.ReloadLastToolStripMenuItem.Name = "ReloadLastToolStripMenuItem";
            this.ReloadLastToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ReloadLastToolStripMenuItem.Text = "Reload Last";
            this.ReloadLastToolStripMenuItem.Click += new System.EventHandler(this.ReloadLastToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ImageEnhancementToolStripMenuItem
            // 
            this.ImageEnhancementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem9,
            this.MedianToolStripMenuItem,
            this.SmoothToolStripMenuItem,
            this.AutoDeskewToolStripMenuItem,
            this.RepairCharactersToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.ToolStripMenuItem4,
            this.ToolStripMenuItem12,
            this.RemoveVerticalLinesToolStripMenuItem,
            this.RemoveHorizontalLinesToolStripMenuItem,
            this.ScaleToolStripMenuItem,
            this.ThresholdToolStripMenuItem,
            this.Rotate90DegToolStripMenuItem});
            this.ImageEnhancementToolStripMenuItem.Name = "ImageEnhancementToolStripMenuItem";
            this.ImageEnhancementToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ImageEnhancementToolStripMenuItem.Text = "Image Enhancement";
            // 
            // ToolStripMenuItem9
            // 
            this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
            this.ToolStripMenuItem9.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem9.Text = "Despeckle...";
            this.ToolStripMenuItem9.Click += new System.EventHandler(this.ToolStripMenuItem9_Click);
            // 
            // MedianToolStripMenuItem
            // 
            this.MedianToolStripMenuItem.Name = "MedianToolStripMenuItem";
            this.MedianToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.MedianToolStripMenuItem.Text = "Median";
            this.MedianToolStripMenuItem.Click += new System.EventHandler(this.MedianToolStripMenuItem_Click);
            // 
            // SmoothToolStripMenuItem
            // 
            this.SmoothToolStripMenuItem.Name = "SmoothToolStripMenuItem";
            this.SmoothToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.SmoothToolStripMenuItem.Text = "Smooth";
            this.SmoothToolStripMenuItem.Click += new System.EventHandler(this.SmoothToolStripMenuItem_Click);
            // 
            // AutoDeskewToolStripMenuItem
            // 
            this.AutoDeskewToolStripMenuItem.Name = "AutoDeskewToolStripMenuItem";
            this.AutoDeskewToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.AutoDeskewToolStripMenuItem.Text = "Auto Deskew";
            this.AutoDeskewToolStripMenuItem.Click += new System.EventHandler(this.AutoDeskewToolStripMenuItem_Click);
            // 
            // RepairCharactersToolStripMenuItem
            // 
            this.RepairCharactersToolStripMenuItem.Name = "RepairCharactersToolStripMenuItem";
            this.RepairCharactersToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.RepairCharactersToolStripMenuItem.Text = "Dilate Characters";
            this.RepairCharactersToolStripMenuItem.Click += new System.EventHandler(this.RepairCharactersToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem3.Text = "Erode Characters";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(200, 22);
            this.ToolStripMenuItem4.Text = "Remove Isolated Dots";
            this.ToolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // ScaleToolStripMenuItem
            // 
            this.ScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem11,
            this.ToolStripMenuItem10,
            this.ToolStripMenuItem5,
            this.ToolStripMenuItem6,
            this.ToolStripMenuItem7});
            this.ScaleToolStripMenuItem.Name = "ScaleToolStripMenuItem";
            this.ScaleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ScaleToolStripMenuItem.Text = "Scale";
            // 
            // ToolStripMenuItem11
            // 
            this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
            this.ToolStripMenuItem11.Size = new System.Drawing.Size(105, 22);
            this.ToolStripMenuItem11.Text = "50 %";
            this.ToolStripMenuItem11.Click += new System.EventHandler(this.ToolStripMenuItem11_Click);
            // 
            // ToolStripMenuItem10
            // 
            this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
            this.ToolStripMenuItem10.Size = new System.Drawing.Size(105, 22);
            this.ToolStripMenuItem10.Text = "75 %";
            this.ToolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(105, 22);
            this.ToolStripMenuItem5.Text = "150 %";
            this.ToolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(105, 22);
            this.ToolStripMenuItem6.Text = "200%";
            this.ToolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuItem6_Click);
            // 
            // ThresholdToolStripMenuItem
            // 
            this.ThresholdToolStripMenuItem.Name = "ThresholdToolStripMenuItem";
            this.ThresholdToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ThresholdToolStripMenuItem.Text = "Threshold";
            this.ThresholdToolStripMenuItem.Click += new System.EventHandler(this.ThresholdToolStripMenuItem_Click);
            // 
            // Rotate90DegToolStripMenuItem
            // 
            this.Rotate90DegToolStripMenuItem.Name = "Rotate90DegToolStripMenuItem";
            this.Rotate90DegToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.Rotate90DegToolStripMenuItem.Text = "Rotate 90 deg";
            this.Rotate90DegToolStripMenuItem.Click += new System.EventHandler(this.Rotate90DegToolStripMenuItem_Click);
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.StartToolStripMenuItem.Text = "Start !";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(356, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(301, 13);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Draw a rectangle with the mouse around 1 or several barcode.";
            // 
            // Command2
            // 
            this.Command2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Command2.BackColor = System.Drawing.SystemColors.Control;
            this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command2.Location = new System.Drawing.Point(977, 4);
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command2.Size = new System.Drawing.Size(33, 25);
            this.Command2.TabIndex = 15;
            this.Command2.Text = "+";
            this.Command2.UseVisualStyleBackColor = false;
            this.Command2.Click += new System.EventHandler(this.Command2_Click);
            // 
            // Command3
            // 
            this.Command3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Command3.BackColor = System.Drawing.SystemColors.Control;
            this.Command3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command3.Location = new System.Drawing.Point(929, 4);
            this.Command3.Name = "Command3";
            this.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command3.Size = new System.Drawing.Size(33, 25);
            this.Command3.TabIndex = 16;
            this.Command3.Text = "-";
            this.Command3.UseVisualStyleBackColor = false;
            this.Command3.Click += new System.EventHandler(this.Command3_Click);
            // 
            // lbImageInfo
            // 
            this.lbImageInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbImageInfo.AutoSize = true;
            this.lbImageInfo.Location = new System.Drawing.Point(3, 10);
            this.lbImageInfo.Name = "lbImageInfo";
            this.lbImageInfo.Size = new System.Drawing.Size(65, 13);
            this.lbImageInfo.TabIndex = 21;
            this.lbImageInfo.Text = "Image info...";
            // 
            // chkDetect1D
            // 
            this.chkDetect1D.AutoSize = true;
            this.chkDetect1D.Location = new System.Drawing.Point(411, 46);
            this.chkDetect1D.Name = "chkDetect1D";
            this.chkDetect1D.Size = new System.Drawing.Size(120, 17);
            this.chkDetect1D.TabIndex = 22;
            this.chkDetect1D.Text = "Detect 1D bar code";
            this.chkDetect1D.UseVisualStyleBackColor = true;
            this.chkDetect1D.CheckedChanged += new System.EventHandler(this.chkDetect1D_CheckedChanged);
            // 
            // chkDetectDataMatrix
            // 
            this.chkDetectDataMatrix.AutoSize = true;
            this.chkDetectDataMatrix.Location = new System.Drawing.Point(569, 46);
            this.chkDetectDataMatrix.Name = "chkDetectDataMatrix";
            this.chkDetectDataMatrix.Size = new System.Drawing.Size(132, 17);
            this.chkDetectDataMatrix.TabIndex = 23;
            this.chkDetectDataMatrix.Text = "Detect 2D Data Matrix";
            this.chkDetectDataMatrix.UseVisualStyleBackColor = true;
            // 
            // chkDetectQRCode
            // 
            this.chkDetectQRCode.AutoSize = true;
            this.chkDetectQRCode.Location = new System.Drawing.Point(411, 70);
            this.chkDetectQRCode.Name = "chkDetectQRCode";
            this.chkDetectQRCode.Size = new System.Drawing.Size(122, 17);
            this.chkDetectQRCode.TabIndex = 24;
            this.chkDetectQRCode.Text = "Detect 2D QR Code";
            this.chkDetectQRCode.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(944, 49);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(41, 20);
            this.TextBox1.TabIndex = 25;
            this.TextBox1.Text = "200";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(910, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(28, 13);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "DPI:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(885, 26);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(111, 13);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Extra PDF Options";
            // 
            // pan1Dtypes
            // 
            this.pan1Dtypes.BackColor = System.Drawing.SystemColors.Control;
            this.pan1Dtypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan1Dtypes.Controls.Add(this.chkUseCorrupted);
            this.pan1Dtypes.Controls.Add(this.chkAdd2);
            this.pan1Dtypes.Controls.Add(this.chkAdd5);
            this.pan1Dtypes.Controls.Add(this.chkUPCE);
            this.pan1Dtypes.Controls.Add(this.chkEAN8);
            this.pan1Dtypes.Controls.Add(this.chkUPCA);
            this.pan1Dtypes.Controls.Add(this.chkEAN13);
            this.pan1Dtypes.Controls.Add(this.chkCODE93);
            this.pan1Dtypes.Controls.Add(this.chkCode128);
            this.pan1Dtypes.Controls.Add(this.chkDataLogic2of5);
            this.pan1Dtypes.Controls.Add(this.chkBcdMatrix);
            this.pan1Dtypes.Controls.Add(this.chkCodeabar);
            this.pan1Dtypes.Controls.Add(this.chkCode39);
            this.pan1Dtypes.Controls.Add(this.chkMatrix2of5);
            this.pan1Dtypes.Controls.Add(this.chkIata2of5);
            this.pan1Dtypes.Controls.Add(this.chkInterleaved2of5);
            this.pan1Dtypes.Controls.Add(this.chkInverted2of5);
            this.pan1Dtypes.Controls.Add(this.chkIndustrial2of5);
            this.pan1Dtypes.Location = new System.Drawing.Point(3, 20);
            this.pan1Dtypes.Name = "pan1Dtypes";
            this.pan1Dtypes.Size = new System.Drawing.Size(1020, 112);
            this.pan1Dtypes.TabIndex = 30;
            // 
            // chkUseCorrupted
            // 
            this.chkUseCorrupted.AutoSize = true;
            this.chkUseCorrupted.Location = new System.Drawing.Point(332, 79);
            this.chkUseCorrupted.Name = "chkUseCorrupted";
            this.chkUseCorrupted.Size = new System.Drawing.Size(171, 17);
            this.chkUseCorrupted.TabIndex = 18;
            this.chkUseCorrupted.Text = "Also returns corrupted barcode";
            this.chkUseCorrupted.UseVisualStyleBackColor = true;
            // 
            // chkAdd2
            // 
            this.chkAdd2.AutoSize = true;
            this.chkAdd2.Location = new System.Drawing.Point(117, 77);
            this.chkAdd2.Name = "chkAdd2";
            this.chkAdd2.Size = new System.Drawing.Size(51, 17);
            this.chkAdd2.TabIndex = 17;
            this.chkAdd2.Text = "Add2";
            this.chkAdd2.UseVisualStyleBackColor = true;
            // 
            // chkAdd5
            // 
            this.chkAdd5.AutoSize = true;
            this.chkAdd5.Location = new System.Drawing.Point(17, 77);
            this.chkAdd5.Name = "chkAdd5";
            this.chkAdd5.Size = new System.Drawing.Size(51, 17);
            this.chkAdd5.TabIndex = 16;
            this.chkAdd5.Text = "Add5";
            this.chkAdd5.UseVisualStyleBackColor = true;
            // 
            // chkUPCE
            // 
            this.chkUPCE.AutoSize = true;
            this.chkUPCE.Location = new System.Drawing.Point(332, 53);
            this.chkUPCE.Name = "chkUPCE";
            this.chkUPCE.Size = new System.Drawing.Size(55, 17);
            this.chkUPCE.TabIndex = 15;
            this.chkUPCE.Text = "UPCE";
            this.chkUPCE.UseVisualStyleBackColor = true;
            // 
            // chkEAN8
            // 
            this.chkEAN8.AutoSize = true;
            this.chkEAN8.Location = new System.Drawing.Point(17, 53);
            this.chkEAN8.Name = "chkEAN8";
            this.chkEAN8.Size = new System.Drawing.Size(54, 17);
            this.chkEAN8.TabIndex = 14;
            this.chkEAN8.Text = "EAN8";
            this.chkEAN8.UseVisualStyleBackColor = true;
            // 
            // chkUPCA
            // 
            this.chkUPCA.AutoSize = true;
            this.chkUPCA.Location = new System.Drawing.Point(223, 53);
            this.chkUPCA.Name = "chkUPCA";
            this.chkUPCA.Size = new System.Drawing.Size(55, 17);
            this.chkUPCA.TabIndex = 13;
            this.chkUPCA.Text = "UPCA";
            this.chkUPCA.UseVisualStyleBackColor = true;
            // 
            // chkEAN13
            // 
            this.chkEAN13.AutoSize = true;
            this.chkEAN13.Location = new System.Drawing.Point(117, 53);
            this.chkEAN13.Name = "chkEAN13";
            this.chkEAN13.Size = new System.Drawing.Size(60, 17);
            this.chkEAN13.TabIndex = 12;
            this.chkEAN13.Text = "EAN13";
            this.chkEAN13.UseVisualStyleBackColor = true;
            // 
            // chkCODE93
            // 
            this.chkCODE93.AutoSize = true;
            this.chkCODE93.Location = new System.Drawing.Point(429, 53);
            this.chkCODE93.Name = "chkCODE93";
            this.chkCODE93.Size = new System.Drawing.Size(63, 17);
            this.chkCODE93.TabIndex = 11;
            this.chkCODE93.Text = "Code93";
            this.chkCODE93.UseVisualStyleBackColor = true;
            // 
            // chkCode128
            // 
            this.chkCode128.AutoSize = true;
            this.chkCode128.Location = new System.Drawing.Point(429, 30);
            this.chkCode128.Name = "chkCode128";
            this.chkCode128.Size = new System.Drawing.Size(69, 17);
            this.chkCode128.TabIndex = 9;
            this.chkCode128.Text = "Code128";
            this.chkCode128.UseVisualStyleBackColor = true;
            // 
            // chkDataLogic2of5
            // 
            this.chkDataLogic2of5.AutoSize = true;
            this.chkDataLogic2of5.Location = new System.Drawing.Point(332, 30);
            this.chkDataLogic2of5.Name = "chkDataLogic2of5";
            this.chkDataLogic2of5.Size = new System.Drawing.Size(96, 17);
            this.chkDataLogic2of5.TabIndex = 8;
            this.chkDataLogic2of5.Text = "DataLogic2of5";
            this.chkDataLogic2of5.UseVisualStyleBackColor = true;
            // 
            // chkBcdMatrix
            // 
            this.chkBcdMatrix.AutoSize = true;
            this.chkBcdMatrix.Location = new System.Drawing.Point(223, 30);
            this.chkBcdMatrix.Name = "chkBcdMatrix";
            this.chkBcdMatrix.Size = new System.Drawing.Size(73, 17);
            this.chkBcdMatrix.TabIndex = 7;
            this.chkBcdMatrix.Text = "BcdMatrix";
            this.chkBcdMatrix.UseVisualStyleBackColor = true;
            // 
            // chkCodeabar
            // 
            this.chkCodeabar.AutoSize = true;
            this.chkCodeabar.Location = new System.Drawing.Point(117, 30);
            this.chkCodeabar.Name = "chkCodeabar";
            this.chkCodeabar.Size = new System.Drawing.Size(72, 17);
            this.chkCodeabar.TabIndex = 6;
            this.chkCodeabar.Text = "Codeabar";
            this.chkCodeabar.UseVisualStyleBackColor = true;
            // 
            // chkCode39
            // 
            this.chkCode39.AutoSize = true;
            this.chkCode39.Location = new System.Drawing.Point(17, 30);
            this.chkCode39.Name = "chkCode39";
            this.chkCode39.Size = new System.Drawing.Size(63, 17);
            this.chkCode39.TabIndex = 5;
            this.chkCode39.Text = "Code39";
            this.chkCode39.UseVisualStyleBackColor = true;
            // 
            // chkMatrix2of5
            // 
            this.chkMatrix2of5.AutoSize = true;
            this.chkMatrix2of5.Location = new System.Drawing.Point(429, 7);
            this.chkMatrix2of5.Name = "chkMatrix2of5";
            this.chkMatrix2of5.Size = new System.Drawing.Size(75, 17);
            this.chkMatrix2of5.TabIndex = 4;
            this.chkMatrix2of5.Text = "Matrix2of5";
            this.chkMatrix2of5.UseVisualStyleBackColor = true;
            // 
            // chkIata2of5
            // 
            this.chkIata2of5.AutoSize = true;
            this.chkIata2of5.Location = new System.Drawing.Point(332, 7);
            this.chkIata2of5.Name = "chkIata2of5";
            this.chkIata2of5.Size = new System.Drawing.Size(65, 17);
            this.chkIata2of5.TabIndex = 3;
            this.chkIata2of5.Text = "Iata2of5";
            this.chkIata2of5.UseVisualStyleBackColor = true;
            // 
            // chkInterleaved2of5
            // 
            this.chkInterleaved2of5.AutoSize = true;
            this.chkInterleaved2of5.Location = new System.Drawing.Point(223, 7);
            this.chkInterleaved2of5.Name = "chkInterleaved2of5";
            this.chkInterleaved2of5.Size = new System.Drawing.Size(100, 17);
            this.chkInterleaved2of5.TabIndex = 2;
            this.chkInterleaved2of5.Text = "Interleaved2of5";
            this.chkInterleaved2of5.UseVisualStyleBackColor = true;
            // 
            // chkInverted2of5
            // 
            this.chkInverted2of5.AutoSize = true;
            this.chkInverted2of5.Location = new System.Drawing.Point(117, 7);
            this.chkInverted2of5.Name = "chkInverted2of5";
            this.chkInverted2of5.Size = new System.Drawing.Size(86, 17);
            this.chkInverted2of5.TabIndex = 1;
            this.chkInverted2of5.Text = "Inverted2of5";
            this.chkInverted2of5.UseVisualStyleBackColor = true;
            // 
            // chkIndustrial2of5
            // 
            this.chkIndustrial2of5.AutoSize = true;
            this.chkIndustrial2of5.Location = new System.Drawing.Point(17, 7);
            this.chkIndustrial2of5.Name = "chkIndustrial2of5";
            this.chkIndustrial2of5.Size = new System.Drawing.Size(89, 17);
            this.chkIndustrial2of5.TabIndex = 0;
            this.chkIndustrial2of5.Text = "Industrial2of5";
            this.chkIndustrial2of5.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(19, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(224, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Expected barcode count (use 0 for unknown):";
            // 
            // nupBcCount
            // 
            this.nupBcCount.Location = new System.Drawing.Point(22, 91);
            this.nupBcCount.Name = "nupBcCount";
            this.nupBcCount.Size = new System.Drawing.Size(57, 20);
            this.nupBcCount.TabIndex = 19;
            // 
            // chkHQDetection
            // 
            this.chkHQDetection.AutoSize = true;
            this.chkHQDetection.Checked = true;
            this.chkHQDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHQDetection.Location = new System.Drawing.Point(22, 46);
            this.chkHQDetection.Name = "chkHQDetection";
            this.chkHQDetection.Size = new System.Drawing.Size(132, 17);
            this.chkHQDetection.TabIndex = 31;
            this.chkHQDetection.Text = "High Quality Detection";
            this.chkHQDetection.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Button1.Location = new System.Drawing.Point(860, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(55, 25);
            this.Button1.TabIndex = 32;
            this.Button1.Text = "->";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Button2.Location = new System.Drawing.Point(709, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(55, 25);
            this.Button2.TabIndex = 33;
            this.Button2.Text = "<-";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(9, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(90, 13);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Global Options";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(399, 26);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(109, 13);
            this.Label6.TabIndex = 35;
            this.Label6.Text = "Engines Selection";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(3, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(107, 13);
            this.Label7.TabIndex = 36;
            this.Label7.Text = "1D Engine Option";
            // 
            // lbPage
            // 
            this.lbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPage.AutoSize = true;
            this.lbPage.Location = new System.Drawing.Point(797, 10);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(57, 13);
            this.lbPage.TabIndex = 37;
            this.lbPage.Text = "1/1";
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
            this.GdViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.GdViewer1.Location = new System.Drawing.Point(3, 138);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
            this.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection;
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
            this.GdViewer1.RectBorderColor = System.Drawing.Color.Maroon;
            this.GdViewer1.RectBorderSize = 1;
            this.GdViewer1.RectIsEditable = true;
            this.GdViewer1.RegionsAreEditable = true;
            this.GdViewer1.RenderGdPictureAnnots = true;
            this.GdViewer1.ScrollBars = true;
            this.GdViewer1.ScrollLargeChange = ((short)(50));
            this.GdViewer1.ScrollSmallChange = ((short)(1));
            this.GdViewer1.SilentMode = false;
            this.GdViewer1.Size = new System.Drawing.Size(1026, 358);
            this.GdViewer1.TabIndex = 19;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 0.001D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            this.GdViewer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GdViewer1_MouseUp);
            // 
            // chkDetectPDF417
            // 
            this.chkDetectPDF417.AutoSize = true;
            this.chkDetectPDF417.Location = new System.Drawing.Point(569, 70);
            this.chkDetectPDF417.Name = "chkDetectPDF417";
            this.chkDetectPDF417.Size = new System.Drawing.Size(162, 17);
            this.chkDetectPDF417.TabIndex = 38;
            this.chkDetectPDF417.Text = "Detect 2D PDF417 bar code";
            this.chkDetectPDF417.UseVisualStyleBackColor = true;
            // 
            // chkDetectMicroQRCode
            // 
            this.chkDetectMicroQRCode.AutoSize = true;
            this.chkDetectMicroQRCode.Location = new System.Drawing.Point(411, 92);
            this.chkDetectMicroQRCode.Name = "chkDetectMicroQRCode";
            this.chkDetectMicroQRCode.Size = new System.Drawing.Size(151, 17);
            this.chkDetectMicroQRCode.TabIndex = 39;
            this.chkDetectMicroQRCode.Text = "Detect 2D Micro QR Code";
            this.chkDetectMicroQRCode.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1032F));
            this.TableLayoutPanel1.Controls.Add(this.pan1Dtypes, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.GdViewer1, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 127);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 4;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1026, 538);
            this.TableLayoutPanel1.TabIndex = 40;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 7;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.TableLayoutPanel2.Controls.Add(this.lbImageInfo, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.Label2, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.Button2, 2, 0);
            this.TableLayoutPanel2.Controls.Add(this.lbPage, 3, 0);
            this.TableLayoutPanel2.Controls.Add(this.Button1, 4, 0);
            this.TableLayoutPanel2.Controls.Add(this.Command3, 5, 0);
            this.TableLayoutPanel2.Controls.Add(this.Command2, 6, 0);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 500);
            this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(1026, 34);
            this.TableLayoutPanel2.TabIndex = 37;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.chkDetectMaxicode);
            this.GroupBox1.Controls.Add(this.chkDetectAztec);
            this.GroupBox1.Controls.Add(this.chkDetectPathCode);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.chkDetectMicroQRCode);
            this.GroupBox1.Controls.Add(this.chkDetect1D);
            this.GroupBox1.Controls.Add(this.chkDetectPDF417);
            this.GroupBox1.Controls.Add(this.chkDetectDataMatrix);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.chkDetectQRCode);
            this.GroupBox1.Controls.Add(this.nupBcCount);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.chkHQDetection);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox1.Location = new System.Drawing.Point(3, 1);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.GroupBox1.Size = new System.Drawing.Size(1020, 122);
            this.GroupBox1.TabIndex = 41;
            this.GroupBox1.TabStop = false;
            // 
            // chkDetectMaxicode
            // 
            this.chkDetectMaxicode.AutoSize = true;
            this.chkDetectMaxicode.Location = new System.Drawing.Point(737, 70);
            this.chkDetectMaxicode.Name = "chkDetectMaxicode";
            this.chkDetectMaxicode.Size = new System.Drawing.Size(125, 17);
            this.chkDetectMaxicode.TabIndex = 42;
            this.chkDetectMaxicode.Text = "Detect 2D MaxiCode";
            this.chkDetectMaxicode.UseVisualStyleBackColor = true;
            this.chkDetectMaxicode.CheckedChanged += new System.EventHandler(this.chkDetectMaxicode_CheckedChanged);
            // 
            // chkDetectAztec
            // 
            this.chkDetectAztec.AutoSize = true;
            this.chkDetectAztec.Location = new System.Drawing.Point(569, 92);
            this.chkDetectAztec.Margin = new System.Windows.Forms.Padding(2);
            this.chkDetectAztec.Name = "chkDetectAztec";
            this.chkDetectAztec.Size = new System.Drawing.Size(133, 17);
            this.chkDetectAztec.TabIndex = 41;
            this.chkDetectAztec.Text = "Detect 2D Aztec Code";
            this.chkDetectAztec.UseVisualStyleBackColor = true;
            this.chkDetectAztec.CheckedChanged += new System.EventHandler(this.chkDetectAztec_CheckedChanged);
            // 
            // chkDetectPathCode
            // 
            this.chkDetectPathCode.AutoSize = true;
            this.chkDetectPathCode.Location = new System.Drawing.Point(737, 46);
            this.chkDetectPathCode.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.chkDetectPathCode.Name = "chkDetectPathCode";
            this.chkDetectPathCode.Size = new System.Drawing.Size(117, 17);
            this.chkDetectPathCode.TabIndex = 40;
            this.chkDetectPathCode.Text = "Detect Patch Code";
            this.chkDetectPathCode.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 1;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.Controls.Add(this.GroupBox1, 0, 0);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 1);
            this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 1;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(1026, 124);
            this.TableLayoutPanel3.TabIndex = 42;
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.ColumnCount = 1;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel4.Controls.Add(this.TableLayoutPanel3, 0, 0);
            this.TableLayoutPanel4.Controls.Add(this.TableLayoutPanel1, 0, 1);
            this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel4.Location = new System.Drawing.Point(0, 24);
            this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 2;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.91892F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.08108F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(1032, 666);
            this.TableLayoutPanel4.TabIndex = 43;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 690);
            this.Controls.Add(this.TableLayoutPanel4);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "GdPicture.NET Barcode Recognition Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.pan1Dtypes.ResumeLayout(false);
            this.pan1Dtypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBcCount)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal GdPicture14.GdViewer GdViewer1;
        internal System.Windows.Forms.ToolStripMenuItem RemoveHorizontalLinesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem12;
        internal System.Windows.Forms.ToolStripMenuItem HorizontalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem VerticalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RemoveVerticalLinesToolStripMenuItem;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem7;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ImageEnhancementToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem9;
        internal System.Windows.Forms.ToolStripMenuItem DespeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem Despeckle5x5xToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AutoDeskewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RepairCharactersToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
        internal System.Windows.Forms.ToolStripMenuItem ScaleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem11;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem10;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem6;
        internal System.Windows.Forms.Label Label2;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button Command2;
        public System.Windows.Forms.Button Command3;
        internal System.Windows.Forms.Label lbImageInfo;
        internal System.Windows.Forms.CheckBox chkDetect1D;
        internal System.Windows.Forms.CheckBox chkDetectDataMatrix;
        internal System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        internal System.Windows.Forms.CheckBox chkDetectQRCode;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ToolStripMenuItem MedianToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ThresholdToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SmoothToolStripMenuItem;
        internal System.Windows.Forms.Panel pan1Dtypes;
        internal System.Windows.Forms.CheckBox chkIndustrial2of5;
        internal System.Windows.Forms.CheckBox chkHQDetection;
        internal System.Windows.Forms.CheckBox chkInverted2of5;
        internal System.Windows.Forms.CheckBox chkAdd2;
        internal System.Windows.Forms.CheckBox chkAdd5;
        internal System.Windows.Forms.CheckBox chkUPCE;
        internal System.Windows.Forms.CheckBox chkEAN8;
        internal System.Windows.Forms.CheckBox chkUPCA;
        internal System.Windows.Forms.CheckBox chkEAN13;
        internal System.Windows.Forms.CheckBox chkCODE93;
        internal System.Windows.Forms.CheckBox chkCode128;
        internal System.Windows.Forms.CheckBox chkDataLogic2of5;
        internal System.Windows.Forms.CheckBox chkBcdMatrix;
        internal System.Windows.Forms.CheckBox chkCodeabar;
        internal System.Windows.Forms.CheckBox chkCode39;
        internal System.Windows.Forms.CheckBox chkMatrix2of5;
        internal System.Windows.Forms.CheckBox chkIata2of5;
        internal System.Windows.Forms.CheckBox chkInterleaved2of5;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.CheckBox chkUseCorrupted;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lbPage;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown nupBcCount;
        internal System.Windows.Forms.ToolStripMenuItem Rotate90DegToolStripMenuItem;
        internal System.Windows.Forms.CheckBox chkDetectPDF417;
        internal System.Windows.Forms.CheckBox chkDetectMicroQRCode;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
        internal System.Windows.Forms.CheckBox chkDetectPathCode;
        internal ToolStripMenuItem ReloadLastToolStripMenuItem;
        private System.ComponentModel.IContainer components;
        private CheckBox chkDetectAztec;
        private CheckBox chkDetectMaxicode;
    }

}
