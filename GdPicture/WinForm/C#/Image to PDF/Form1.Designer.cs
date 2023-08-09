namespace Image2PDF
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
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(6, 90);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(427, 33);
            this.ProgressBar1.TabIndex = 42;
            this.ProgressBar1.Visible = false;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(439, 90);
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
            this.txtDstFolder.Location = new System.Drawing.Point(101, 31);
            this.txtDstFolder.Name = "txtDstFolder";
            this.txtDstFolder.ReadOnly = true;
            this.txtDstFolder.Size = new System.Drawing.Size(442, 20);
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
            this.txtInputFile.Location = new System.Drawing.Point(101, 5);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(442, 20);
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
            this.cmbPDFConformance.Location = new System.Drawing.Point(101, 57);
            this.cmbPDFConformance.Name = "cmbPDFConformance";
            this.cmbPDFConformance.Size = new System.Drawing.Size(140, 21);
            this.cmbPDFConformance.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 129);
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
            this.Text = "GdPicture.NET - TIFF to PDF Demo  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }

}
