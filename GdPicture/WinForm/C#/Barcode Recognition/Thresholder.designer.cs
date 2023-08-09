namespace barcode_recognition
{
    public partial class Thresholder : System.Windows.Forms.Form
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer
        private System.ComponentModel.Container components = null;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            this.cmbBinarizationMode = new System.Windows.Forms.ComboBox();
            this.cmbBinarizationMode.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.Label1 = new System.Windows.Forms.Label();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.scroll3Panel = new System.Windows.Forms.TableLayoutPanel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.scroll2Panel = new System.Windows.Forms.TableLayoutPanel();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.scroll1Panel = new System.Windows.Forms.TableLayoutPanel();
            this.Label8 = new System.Windows.Forms.Label();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMinDifVal = new System.Windows.Forms.TextBox();
            this.scrlContrastParam = new System.Windows.Forms.HScrollBar();
            this.scrlContrastParam.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlContrastParam_Scroll);
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtThresholdMin = new System.Windows.Forms.Label();
            this.scrlThresoldParam = new System.Windows.Forms.HScrollBar();
            this.scrlThresoldParam.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlThresholdParam_Scroll);
            this.txtThresholdMax = new System.Windows.Forms.Label();
            this.txtThreshVal = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtKernelVal = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.scrlKernelParam = new System.Windows.Forms.HScrollBar();
            this.scrlKernelParam.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlKernelParam_Scroll);
            this.TableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.scroll3Panel.SuspendLayout();
            this.scroll2Panel.SuspendLayout();
            this.scroll1Panel.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.TableLayoutPanel6.SuspendLayout();
            this.TableLayoutPanel7.SuspendLayout();
            this.TableLayoutPanel5.SuspendLayout();
            this.TableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            //
            //TableLayoutPanel1
            //
            this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(475, 186);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 0;
            //
            //OK_Button
            //
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            //
            //Cancel_Button
            //
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            //
            //cmbBinarizationMode
            //
            this.cmbBinarizationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBinarizationMode.FormattingEnabled = true;
            this.cmbBinarizationMode.Items.AddRange(new object[] { "Linear", "Adaptive (Modified Bradley)", "Adaptive (Modified Otsu)", "Sauvola", "Wan" });
            this.cmbBinarizationMode.Location = new System.Drawing.Point(93, 34);
            this.cmbBinarizationMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBinarizationMode.Name = "cmbBinarizationMode";
            this.cmbBinarizationMode.Size = new System.Drawing.Size(265, 21);
            this.cmbBinarizationMode.TabIndex = 1;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Binarization";
            //
            //TableLayoutPanel3
            //
            this.TableLayoutPanel3.ColumnCount = 2;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel3.Controls.Add(this.scroll3Panel, 0, 1);
            this.TableLayoutPanel3.Controls.Add(this.scroll2Panel, 1, 0);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 2;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float)(20.0F)));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float)(20.0F)));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.TableLayoutPanel3.TabIndex = 0;
            //
            //scroll3Panel
            //
            this.scroll3Panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scroll3Panel.ColumnCount = 5;
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(79.27928F)));
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(20.72072F)));
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(225.0F)));
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(44.0F)));
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(98.0F)));
            this.scroll3Panel.Controls.Add(this.Label5, 1, 0);
            this.scroll3Panel.Controls.Add(this.Label3, 0, 0);
            this.scroll3Panel.Controls.Add(this.Label7, 3, 0);
            this.scroll3Panel.Location = new System.Drawing.Point(3, 43);
            this.scroll3Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scroll3Panel.Name = "scroll3Panel";
            this.scroll3Panel.RowCount = 1;
            this.scroll3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.scroll3Panel.Size = new System.Drawing.Size(94, 34);
            this.scroll3Panel.TabIndex = 2;
            //
            //Label5
            //
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(-213, 10);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(1, 13);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "0";
            //
            //Label3
            //
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(3, 10);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(1, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Smooth Kernel";
            //
            //Label7
            //
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(-44, 10);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(13, 13);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "5";
            //
            //scroll2Panel
            //
            this.scroll2Panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scroll2Panel.ColumnCount = 5;
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(81.81818F)));
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(18.18182F)));
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(216.0F)));
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(45.0F)));
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(88.0F)));
            this.scroll2Panel.Controls.Add(this.Label4, 1, 0);
            this.scroll2Panel.Controls.Add(this.Label2, 0, 0);
            this.scroll2Panel.Controls.Add(this.Label6, 3, 0);
            this.scroll2Panel.Location = new System.Drawing.Point(103, 2);
            this.scroll2Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scroll2Panel.Name = "scroll2Panel";
            this.scroll2Panel.RowCount = 1;
            this.scroll2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.scroll2Panel.Size = new System.Drawing.Size(94, 16);
            this.scroll2Panel.TabIndex = 1;
            //
            //Label4
            //
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(-205, 1);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(1, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "0";
            //
            //Label2
            //
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 1);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(1, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Contrast Dif. Min";
            //
            //Label6
            //
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(-35, 1);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(25, 13);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "255";
            //
            //scroll1Panel
            //
            this.scroll1Panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scroll1Panel.ColumnCount = 5;
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(79.27928F)));
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(20.72072F)));
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(225.0F)));
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(44.0F)));
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(98.0F)));
            this.scroll1Panel.Controls.Add(this.Label8, 0, 0);
            this.scroll1Panel.Location = new System.Drawing.Point(3, 80);
            this.scroll1Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scroll1Panel.Name = "scroll1Panel";
            this.scroll1Panel.RowCount = 1;
            this.scroll1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.scroll1Panel.Size = new System.Drawing.Size(471, 34);
            this.scroll1Panel.TabIndex = 0;
            //
            //Label8
            //
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(3, 10);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(54, 13);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Threshold";
            //
            //TableLayoutPanel2
            //
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel2.Controls.Add(this.TableLayoutPanel4, 0, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(10, 68);
            this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(450, 147);
            this.TableLayoutPanel2.TabIndex = 3;
            //
            //TableLayoutPanel4
            //
            this.TableLayoutPanel4.ColumnCount = 1;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel4.Controls.Add(this.TableLayoutPanel6, 0, 2);
            this.TableLayoutPanel4.Controls.Add(this.TableLayoutPanel7, 0, 0);
            this.TableLayoutPanel4.Controls.Add(this.TableLayoutPanel5, 0, 1);
            this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 3;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(53.24675F)));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(46.75325F)));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float)(37.0F)));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(440, 131);
            this.TableLayoutPanel4.TabIndex = 3;
            //
            //TableLayoutPanel6
            //
            this.TableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TableLayoutPanel6.ColumnCount = 5;
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(74.78992F)));
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(25.21008F)));
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(192.0F)));
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(37.0F)));
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(93.0F)));
            this.TableLayoutPanel6.Controls.Add(this.txtMinDifVal, 4, 0);
            this.TableLayoutPanel6.Controls.Add(this.scrlContrastParam, 2, 0);
            this.TableLayoutPanel6.Controls.Add(this.Label12, 1, 0);
            this.TableLayoutPanel6.Controls.Add(this.Label13, 0, 0);
            this.TableLayoutPanel6.Controls.Add(this.Label14, 3, 0);
            this.TableLayoutPanel6.Location = new System.Drawing.Point(3, 98);
            this.TableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutPanel6.Name = "TableLayoutPanel6";
            this.TableLayoutPanel6.RowCount = 1;
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel6.Size = new System.Drawing.Size(416, 28);
            this.TableLayoutPanel6.TabIndex = 3;
            this.TableLayoutPanel6.Visible = false;
            //
            //txtMinDifVal
            //
            this.txtMinDifVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMinDifVal.Enabled = false;
            this.txtMinDifVal.Location = new System.Drawing.Point(325, 4);
            this.txtMinDifVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinDifVal.Name = "txtMinDifVal";
            this.txtMinDifVal.Size = new System.Drawing.Size(75, 20);
            this.txtMinDifVal.TabIndex = 5;
            this.txtMinDifVal.Text = "50";
            //
            //scrlContrastParam
            //
            this.scrlContrastParam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scrlContrastParam.LargeChange = 1;
            this.scrlContrastParam.Location = new System.Drawing.Point(93, 1);
            this.scrlContrastParam.Maximum = 255;
            this.scrlContrastParam.Name = "scrlContrastParam";
            this.scrlContrastParam.Size = new System.Drawing.Size(191, 26);
            this.scrlContrastParam.TabIndex = 3;
            this.scrlContrastParam.Value = 50;
            //
            //Label12
            //
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(73, 7);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(13, 13);
            this.Label12.TabIndex = 2;
            this.Label12.Text = "0";
            //
            //Label13
            //
            this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(3, 1);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(49, 26);
            this.Label13.TabIndex = 1;
            this.Label13.Text = "Contrast Dif. Min";
            //
            //Label14
            //
            this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(288, 7);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(25, 13);
            this.Label14.TabIndex = 4;
            this.Label14.Text = "255";
            //
            //TableLayoutPanel7
            //
            this.TableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TableLayoutPanel7.ColumnCount = 5;
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(77.04918F)));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(22.95082F)));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(194.0F)));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(38.0F)));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(93.0F)));
            this.TableLayoutPanel7.Controls.Add(this.Label15, 0, 0);
            this.TableLayoutPanel7.Controls.Add(this.txtThresholdMin, 1, 0);
            this.TableLayoutPanel7.Controls.Add(this.scrlThresoldParam, 2, 0);
            this.TableLayoutPanel7.Controls.Add(this.txtThresholdMax, 3, 0);
            this.TableLayoutPanel7.Controls.Add(this.txtThreshVal, 4, 0);
            this.TableLayoutPanel7.Location = new System.Drawing.Point(3, 11);
            this.TableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutPanel7.Name = "TableLayoutPanel7";
            this.TableLayoutPanel7.RowCount = 1;
            this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel7.Size = new System.Drawing.Size(416, 28);
            this.TableLayoutPanel7.TabIndex = 0;
            //
            //Label15
            //
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(3, 7);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(54, 13);
            this.Label15.TabIndex = 0;
            this.Label15.Text = "Threshold";
            //
            //txtThresholdMin
            //
            this.txtThresholdMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtThresholdMin.AutoSize = true;
            this.txtThresholdMin.Location = new System.Drawing.Point(73, 7);
            this.txtThresholdMin.Name = "txtThresholdMin";
            this.txtThresholdMin.Size = new System.Drawing.Size(13, 13);
            this.txtThresholdMin.TabIndex = 1;
            this.txtThresholdMin.Text = "0";
            //
            //scrlThresoldParam
            //
            this.scrlThresoldParam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scrlThresoldParam.LargeChange = 1;
            this.scrlThresoldParam.Location = new System.Drawing.Point(90, 1);
            this.scrlThresoldParam.Maximum = 254;
            this.scrlThresoldParam.Minimum = 1;
            this.scrlThresoldParam.Name = "scrlThresoldParam";
            this.scrlThresoldParam.Size = new System.Drawing.Size(190, 26);
            this.scrlThresoldParam.TabIndex = 2;
            this.scrlThresoldParam.Value = 128;
            //
            //txtThresholdMax
            //
            this.txtThresholdMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtThresholdMax.AutoSize = true;
            this.txtThresholdMax.Location = new System.Drawing.Point(287, 7);
            this.txtThresholdMax.Name = "txtThresholdMax";
            this.txtThresholdMax.Size = new System.Drawing.Size(25, 13);
            this.txtThresholdMax.TabIndex = 3;
            this.txtThresholdMax.Text = "254";
            //
            //txtThreshVal
            //
            this.txtThreshVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtThreshVal.Enabled = false;
            this.txtThreshVal.Location = new System.Drawing.Point(325, 4);
            this.txtThreshVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThreshVal.Name = "txtThreshVal";
            this.txtThreshVal.Size = new System.Drawing.Size(75, 20);
            this.txtThreshVal.TabIndex = 4;
            //
            //TableLayoutPanel5
            //
            this.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TableLayoutPanel5.ColumnCount = 5;
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(75.63025F)));
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(24.36975F)));
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(191.0F)));
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(38.0F)));
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)(93.0F)));
            this.TableLayoutPanel5.Controls.Add(this.txtKernelVal, 4, 0);
            this.TableLayoutPanel5.Controls.Add(this.Label9, 1, 0);
            this.TableLayoutPanel5.Controls.Add(this.Label10, 0, 0);
            this.TableLayoutPanel5.Controls.Add(this.Label11, 3, 0);
            this.TableLayoutPanel5.Controls.Add(this.scrlKernelParam, 2, 0);
            this.TableLayoutPanel5.Location = new System.Drawing.Point(3, 57);
            this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutPanel5.Name = "TableLayoutPanel5";
            this.TableLayoutPanel5.RowCount = 1;
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel5.Size = new System.Drawing.Size(416, 28);
            this.TableLayoutPanel5.TabIndex = 2;
            this.TableLayoutPanel5.Visible = false;
            //
            //txtKernelVal
            //
            this.txtKernelVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKernelVal.Enabled = false;
            this.txtKernelVal.Location = new System.Drawing.Point(325, 4);
            this.txtKernelVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKernelVal.Name = "txtKernelVal";
            this.txtKernelVal.Size = new System.Drawing.Size(75, 20);
            this.txtKernelVal.TabIndex = 5;
            this.txtKernelVal.Text = "2";
            //
            //Label9
            //
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(74, 7);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(13, 13);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "0";
            //
            //Label10
            //
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(3, 1);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(46, 26);
            this.Label10.TabIndex = 1;
            this.Label10.Text = "Smooth Kernel";
            //
            //Label11
            //
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(287, 7);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(13, 13);
            this.Label11.TabIndex = 4;
            this.Label11.Text = "5";
            //
            //scrlKernelParam
            //
            this.scrlKernelParam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scrlKernelParam.LargeChange = 1;
            this.scrlKernelParam.Location = new System.Drawing.Point(93, 1);
            this.scrlKernelParam.Maximum = 5;
            this.scrlKernelParam.Name = "scrlKernelParam";
            this.scrlKernelParam.Size = new System.Drawing.Size(190, 26);
            this.scrlKernelParam.TabIndex = 3;
            this.scrlKernelParam.Value = 2;
            //
            //TableLayoutPanel8
            //
            this.TableLayoutPanel8.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.TableLayoutPanel8.ColumnCount = 2;
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)(50.0F)));
            this.TableLayoutPanel8.Controls.Add(this.Button1, 0, 0);
            this.TableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableLayoutPanel8.Name = "TableLayoutPanel8";
            this.TableLayoutPanel8.RowCount = 1;
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float)(20.0F)));
            this.TableLayoutPanel8.Size = new System.Drawing.Size(200, 100);
            this.TableLayoutPanel8.TabIndex = 0;
            //
            //Button1
            //
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button1.Location = new System.Drawing.Point(11, 36);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(78, 28);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "OK";
            //
            //Button2
            //
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(88, 4);
            this.Button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(78, 28);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Cancel";
            //
            //Dialog1
            //
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0F), (float)(13.0F));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(631, 225);
            this.Controls.Add(this.TableLayoutPanel2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmbBinarizationMode);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Threshold...";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.scroll3Panel.ResumeLayout(false);
            this.scroll3Panel.PerformLayout();
            this.scroll2Panel.ResumeLayout(false);
            this.scroll2Panel.PerformLayout();
            this.scroll1Panel.ResumeLayout(false);
            this.scroll1Panel.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel4.ResumeLayout(false);
            this.TableLayoutPanel6.ResumeLayout(false);
            this.TableLayoutPanel6.PerformLayout();
            this.TableLayoutPanel7.ResumeLayout(false);
            this.TableLayoutPanel7.PerformLayout();
            this.TableLayoutPanel5.ResumeLayout(false);
            this.TableLayoutPanel5.PerformLayout();
            this.TableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.ComboBox cmbBinarizationMode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
        internal System.Windows.Forms.TableLayoutPanel scroll3Panel;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TableLayoutPanel scroll2Panel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TableLayoutPanel scroll1Panel;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel5;
        internal System.Windows.Forms.TextBox txtKernelVal;
        internal System.Windows.Forms.HScrollBar scrlKernelParam;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel7;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label txtThresholdMin;
        internal System.Windows.Forms.HScrollBar scrlThresoldParam;
        internal System.Windows.Forms.Label txtThresholdMax;
        internal System.Windows.Forms.TextBox txtThreshVal;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel8;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel6;
        internal System.Windows.Forms.TextBox txtMinDifVal;
        internal System.Windows.Forms.HScrollBar scrlContrastParam;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;

    }

}
