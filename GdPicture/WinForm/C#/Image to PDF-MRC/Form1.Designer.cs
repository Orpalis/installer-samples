namespace Image2PDFMRC
{
    partial class Form1
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



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.btStart = new System.Windows.Forms.Button();
            this.btBrowsDstFolder = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtDstFolder = new System.Windows.Forms.TextBox();
            this.btBrowsSrcFile = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPDFConformance = new System.Windows.Forms.ComboBox();
            this.chkPreserveSmoothing = new System.Windows.Forms.CheckBox();
            this.quality = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundResolution = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(6, 183);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(427, 33);
            this.ProgressBar1.TabIndex = 42;
            this.ProgressBar1.Visible = false;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(439, 183);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(145, 33);
            this.btStart.TabIndex = 41;
            this.btStart.Text = "Start !";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btBrowsDstFolder
            // 
            this.btBrowsDstFolder.Location = new System.Drawing.Point(549, 31);
            this.btBrowsDstFolder.Name = "btBrowsDstFolder";
            this.btBrowsDstFolder.Size = new System.Drawing.Size(35, 20);
            this.btBrowsDstFolder.TabIndex = 40;
            this.btBrowsDstFolder.Text = "...";
            this.btBrowsDstFolder.UseVisualStyleBackColor = true;
            this.btBrowsDstFolder.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(3, 35);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 13);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "Destination folder:";
            // 
            // txtDstFolder
            // 
            this.txtDstFolder.Location = new System.Drawing.Point(121, 31);
            this.txtDstFolder.Name = "txtDstFolder";
            this.txtDstFolder.ReadOnly = true;
            this.txtDstFolder.Size = new System.Drawing.Size(423, 20);
            this.txtDstFolder.TabIndex = 38;
            // 
            // btBrowsSrcFile
            // 
            this.btBrowsSrcFile.Location = new System.Drawing.Point(549, 5);
            this.btBrowsSrcFile.Name = "btBrowsSrcFile";
            this.btBrowsSrcFile.Size = new System.Drawing.Size(35, 20);
            this.btBrowsSrcFile.TabIndex = 37;
            this.btBrowsSrcFile.Text = "...";
            this.btBrowsSrcFile.UseVisualStyleBackColor = true;
            this.btBrowsSrcFile.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(3, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(50, 13);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Input file:";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(121, 5);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(423, 20);
            this.txtInputFile.TabIndex = 35;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Conformance:";
            // 
            // cmbPDFConformance
            // 
            this.cmbPDFConformance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPDFConformance.FormattingEnabled = true;
            this.cmbPDFConformance.Items.AddRange(new object[] {
            "PDF/A-1a",
            "PDF/A-1b",
            "PDF/A-2a",
            "PDF/A-2b",
            "PDF/A-2u",
            "PDF/A-3a",
            "PDF/A-3b",
            "PDF/A-3u",
            "PDF 1.4",
            "PDF 1.5",
            "PDF 1.6",
            "PDF 1.7",
            "PDF 2.0",
            "PDF/UA-1"});
            this.cmbPDFConformance.Location = new System.Drawing.Point(121, 57);
            this.cmbPDFConformance.Name = "cmbPDFConformance";
            this.cmbPDFConformance.Size = new System.Drawing.Size(140, 21);
            this.cmbPDFConformance.TabIndex = 47;
            // 
            // chkPreserveSmoothing
            // 
            this.chkPreserveSmoothing.AutoSize = true;
            this.chkPreserveSmoothing.Location = new System.Drawing.Point(6, 137);
            this.chkPreserveSmoothing.Name = "chkPreserveSmoothing";
            this.chkPreserveSmoothing.Size = new System.Drawing.Size(295, 17);
            this.chkPreserveSmoothing.TabIndex = 48;
            this.chkPreserveSmoothing.Text = "Preserve smoothing (higer quality and lower compression)";
            this.chkPreserveSmoothing.UseVisualStyleBackColor = true;
            // 
            // quality
            // 
            this.quality.Location = new System.Drawing.Point(121, 84);
            this.quality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(45, 20);
            this.quality.TabIndex = 49;
            this.quality.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Background quality:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "[0 (worst) - 100 (better)]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "dpi (use 0 to keep input image resolution).";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Background resolution:";
            // 
            // backgroundResolution
            // 
            this.backgroundResolution.Location = new System.Drawing.Point(121, 109);
            this.backgroundResolution.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.backgroundResolution.Name = "backgroundResolution";
            this.backgroundResolution.Size = new System.Drawing.Size(45, 20);
            this.backgroundResolution.TabIndex = 52;
            this.backgroundResolution.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 225);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.backgroundResolution);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quality);
            this.Controls.Add(this.chkPreserveSmoothing);
            this.Controls.Add(this.cmbPDFConformance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btBrowsDstFolder);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtDstFolder);
            this.Controls.Add(this.btBrowsSrcFile);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "GdPicture.NET - Image to PDF MRC Demo  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundResolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Button btStart;
        internal System.Windows.Forms.Button btBrowsDstFolder;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtDstFolder;
        internal System.Windows.Forms.Button btBrowsSrcFile;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtInputFile;
        internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPDFConformance;
        private System.Windows.Forms.CheckBox chkPreserveSmoothing;
        private System.Windows.Forms.NumericUpDown quality;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown backgroundResolution;
    }

}
