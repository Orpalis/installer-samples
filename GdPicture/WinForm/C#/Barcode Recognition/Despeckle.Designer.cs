namespace barcode_recognition
{
    partial class Despeckle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDespeckleMode = new System.Windows.Forms.ComboBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.lblDespeckleType = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtThresholdMin = new System.Windows.Forms.Label();
            this.scrlStrengthParam = new System.Windows.Forms.HScrollBar();
            this.txtThresholdMax = new System.Windows.Forms.Label();
            this.txtStrengthVal = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel7.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDespeckleMode
            // 
            this.cmbDespeckleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDespeckleMode.FormattingEnabled = true;
            this.cmbDespeckleMode.Location = new System.Drawing.Point(120, 18);
            this.cmbDespeckleMode.Name = "cmbDespeckleMode";
            this.cmbDespeckleMode.Size = new System.Drawing.Size(285, 28);
            this.cmbDespeckleMode.TabIndex = 9;
            this.cmbDespeckleMode.SelectedIndexChanged += new System.EventHandler(this.cmbDespeckleMode_SelectedIndexChanged);
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(4, 5);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(100, 35);
            this.OK_Button.TabIndex = 3;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(114, 5);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(100, 35);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // lblDespeckleType
            // 
            this.lblDespeckleType.AutoSize = true;
            this.lblDespeckleType.Location = new System.Drawing.Point(30, 21);
            this.lblDespeckleType.Name = "lblDespeckleType";
            this.lblDespeckleType.Size = new System.Drawing.Size(49, 20);
            this.lblDespeckleType.TabIndex = 11;
            this.lblDespeckleType.Text = "Mode";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(437, 140);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(219, 45);
            this.TableLayoutPanel1.TabIndex = 10;
            // 
            // TableLayoutPanel7
            // 
            this.TableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableLayoutPanel7.ColumnCount = 5;
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.28925F));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.71074F));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.TableLayoutPanel7.Controls.Add(this.Label15, 0, 0);
            this.TableLayoutPanel7.Controls.Add(this.txtThresholdMin, 1, 0);
            this.TableLayoutPanel7.Controls.Add(this.scrlStrengthParam, 2, 0);
            this.TableLayoutPanel7.Controls.Add(this.txtThresholdMax, 3, 0);
            this.TableLayoutPanel7.Controls.Add(this.txtStrengthVal, 4, 0);
            this.TableLayoutPanel7.Location = new System.Drawing.Point(9, 9);
            this.TableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TableLayoutPanel7.Name = "TableLayoutPanel7";
            this.TableLayoutPanel7.RowCount = 1;
            this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TableLayoutPanel7.Size = new System.Drawing.Size(612, 38);
            this.TableLayoutPanel7.TabIndex = 7;
            // 
            // Label15
            // 
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(4, 9);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(71, 20);
            this.Label15.TabIndex = 0;
            this.Label15.Text = "Strength";
            // 
            // txtThresholdMin
            // 
            this.txtThresholdMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtThresholdMin.AutoSize = true;
            this.txtThresholdMin.Location = new System.Drawing.Point(83, 9);
            this.txtThresholdMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtThresholdMin.Name = "txtThresholdMin";
            this.txtThresholdMin.Size = new System.Drawing.Size(18, 20);
            this.txtThresholdMin.TabIndex = 1;
            this.txtThresholdMin.Text = "0";
            // 
            // scrlStrengthParam
            // 
            this.scrlStrengthParam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scrlStrengthParam.LargeChange = 1;
            this.scrlStrengthParam.Location = new System.Drawing.Point(120, 6);
            this.scrlStrengthParam.Name = "scrlStrengthParam";
            this.scrlStrengthParam.Size = new System.Drawing.Size(285, 26);
            this.scrlStrengthParam.TabIndex = 2;
            this.scrlStrengthParam.Value = 5;
            this.scrlStrengthParam.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlStrengthParam_Scroll);
            // 
            // txtThresholdMax
            // 
            this.txtThresholdMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtThresholdMax.AutoSize = true;
            this.txtThresholdMax.Location = new System.Drawing.Point(415, 9);
            this.txtThresholdMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtThresholdMax.Name = "txtThresholdMax";
            this.txtThresholdMax.Size = new System.Drawing.Size(36, 20);
            this.txtThresholdMax.TabIndex = 3;
            this.txtThresholdMax.Text = "100";
            // 
            // txtStrengthVal
            // 
            this.txtStrengthVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStrengthVal.Enabled = false;
            this.txtStrengthVal.Location = new System.Drawing.Point(472, 6);
            this.txtStrengthVal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStrengthVal.Name = "txtStrengthVal";
            this.txtStrengthVal.Size = new System.Drawing.Size(110, 26);
            this.txtStrengthVal.TabIndex = 99;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Controls.Add(this.TableLayoutPanel4, 0, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(13, 52);
            this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(638, 63);
            this.TableLayoutPanel2.TabIndex = 12;
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.ColumnCount = 1;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel4.Controls.Add(this.TableLayoutPanel7, 0, 0);
            this.TableLayoutPanel4.Location = new System.Drawing.Point(4, 3);
            this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 1;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.24675F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.75325F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(630, 57);
            this.TableLayoutPanel4.TabIndex = 3;
            // 
            // Despeckle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 202);
            this.Controls.Add(this.cmbDespeckleMode);
            this.Controls.Add(this.lblDespeckleType);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.TableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Despeckle";
            this.ShowInTaskbar = false;
            this.Text = "Despeckle";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel7.ResumeLayout(false);
            this.TableLayoutPanel7.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDespeckleMode;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label lblDespeckleType;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel7;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label txtThresholdMin;
        internal System.Windows.Forms.HScrollBar scrlStrengthParam;
        internal System.Windows.Forms.Label txtThresholdMax;
        internal System.Windows.Forms.TextBox txtStrengthVal;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
    }
}