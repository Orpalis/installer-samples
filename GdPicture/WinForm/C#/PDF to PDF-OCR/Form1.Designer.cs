namespace PDF_TO_PDF_OCR
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label3 = new System.Windows.Forms.Label();
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.chkMultithread = new System.Windows.Forms.CheckBox();
            this.chkIncSave = new System.Windows.Forms.CheckBox();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btBrowsOCRDict = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtDictsPath = new System.Windows.Forms.TextBox();
            this.Language = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btBrowsInput = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btStartOCR = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkFavorSpeed = new System.Windows.Forms.CheckBox();
            this.chkEnablePageOrientationDetection = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(220, 62);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(427, 13);
            this.Label3.TabIndex = 48;
            this.Label3.Text = "You can combine languages using the + operator, ex: \"eng+spa\" for English and Spa" +
    "nish";
            // 
            // cmbLang
            // 
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.Location = new System.Drawing.Point(96, 60);
            this.cmbLang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.Size = new System.Drawing.Size(121, 21);
            this.cmbLang.TabIndex = 47;
            this.cmbLang.Text = "eng";
            // 
            // chkMultithread
            // 
            this.chkMultithread.AutoSize = true;
            this.chkMultithread.Checked = true;
            this.chkMultithread.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMultithread.Location = new System.Drawing.Point(96, 110);
            this.chkMultithread.Name = "chkMultithread";
            this.chkMultithread.Size = new System.Drawing.Size(121, 17);
            this.chkMultithread.TabIndex = 46;
            this.chkMultithread.Text = "Use multiple threads";
            this.chkMultithread.UseVisualStyleBackColor = true;
            // 
            // chkIncSave
            // 
            this.chkIncSave.AutoSize = true;
            this.chkIncSave.Location = new System.Drawing.Point(326, 133);
            this.chkIncSave.Name = "chkIncSave";
            this.chkIncSave.Size = new System.Drawing.Size(136, 17);
            this.chkIncSave.TabIndex = 45;
            this.chkIncSave.Text = "Use incremental saving";
            this.chkIncSave.UseVisualStyleBackColor = true;
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(96, 83);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(33, 20);
            this.txtDPI.TabIndex = 44;
            this.txtDPI.Text = "300";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(28, 13);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "DPI:";
            // 
            // btBrowsOCRDict
            // 
            this.btBrowsOCRDict.Location = new System.Drawing.Point(605, 36);
            this.btBrowsOCRDict.Name = "btBrowsOCRDict";
            this.btBrowsOCRDict.Size = new System.Drawing.Size(39, 17);
            this.btBrowsOCRDict.TabIndex = 42;
            this.btBrowsOCRDict.Text = "...";
            this.btBrowsOCRDict.UseVisualStyleBackColor = true;
            this.btBrowsOCRDict.Click += new System.EventHandler(this.btBrowsOCRDict_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 38);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(81, 13);
            this.Label4.TabIndex = 41;
            this.Label4.Text = "Dictionary path:";
            // 
            // txtDictsPath
            // 
            this.txtDictsPath.Location = new System.Drawing.Point(96, 36);
            this.txtDictsPath.Name = "txtDictsPath";
            this.txtDictsPath.ReadOnly = true;
            this.txtDictsPath.Size = new System.Drawing.Size(505, 20);
            this.txtDictsPath.TabIndex = 40;
            this.txtDictsPath.Text = "D:\\GdPicture.NET 14\\Redist\\OCR";
            this.txtDictsPath.TextChanged += new System.EventHandler(this.txtDictsPath_TextChanged);
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(8, 62);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(58, 13);
            this.Language.TabIndex = 39;
            this.Language.Text = "Language:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "Input file:";
            // 
            // btBrowsInput
            // 
            this.btBrowsInput.Location = new System.Drawing.Point(605, 9);
            this.btBrowsInput.Name = "btBrowsInput";
            this.btBrowsInput.Size = new System.Drawing.Size(39, 17);
            this.btBrowsInput.TabIndex = 37;
            this.btBrowsInput.Text = "...";
            this.btBrowsInput.UseVisualStyleBackColor = true;
            this.btBrowsInput.Click += new System.EventHandler(this.btBrowsInput_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(96, 9);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(505, 20);
            this.txtInputFile.TabIndex = 36;
            // 
            // btStartOCR
            // 
            this.btStartOCR.Location = new System.Drawing.Point(549, 168);
            this.btStartOCR.Name = "btStartOCR";
            this.btStartOCR.Size = new System.Drawing.Size(95, 30);
            this.btStartOCR.TabIndex = 35;
            this.btStartOCR.Text = "Start !";
            this.btStartOCR.UseVisualStyleBackColor = true;
            this.btStartOCR.Click += new System.EventHandler(this.btStartOCR_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(7, 168);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(536, 30);
            this.ProgressBar1.TabIndex = 34;
            // 
            // chkFavorSpeed
            // 
            this.chkFavorSpeed.AutoSize = true;
            this.chkFavorSpeed.Location = new System.Drawing.Point(326, 110);
            this.chkFavorSpeed.Name = "chkFavorSpeed";
            this.chkFavorSpeed.Size = new System.Drawing.Size(87, 17);
            this.chkFavorSpeed.TabIndex = 49;
            this.chkFavorSpeed.Text = "Favor Speed";
            this.chkFavorSpeed.UseVisualStyleBackColor = true;
            // 
            // chkEnablePageOrientationDetection
            // 
            this.chkEnablePageOrientationDetection.AutoSize = true;
            this.chkEnablePageOrientationDetection.Checked = true;
            this.chkEnablePageOrientationDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnablePageOrientationDetection.Location = new System.Drawing.Point(96, 133);
            this.chkEnablePageOrientationDetection.Name = "chkEnablePageOrientationDetection";
            this.chkEnablePageOrientationDetection.Size = new System.Drawing.Size(224, 17);
            this.chkEnablePageOrientationDetection.TabIndex = 50;
            this.chkEnablePageOrientationDetection.Text = "Enable page orientation detection (slower)";
            this.chkEnablePageOrientationDetection.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 206);
            this.Controls.Add(this.chkEnablePageOrientationDetection);
            this.Controls.Add(this.chkFavorSpeed);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cmbLang);
            this.Controls.Add(this.chkMultithread);
            this.Controls.Add(this.chkIncSave);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btBrowsOCRDict);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtDictsPath);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btBrowsInput);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.btStartOCR);
            this.Controls.Add(this.ProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "GdPicture.NET Any document to PDF/OCR Sample  -  https://gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cmbLang;
        internal System.Windows.Forms.CheckBox chkMultithread;
        internal System.Windows.Forms.CheckBox chkIncSave;
        internal System.Windows.Forms.TextBox txtDPI;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btBrowsOCRDict;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtDictsPath;
        internal System.Windows.Forms.Label Language;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btBrowsInput;
        internal System.Windows.Forms.TextBox txtInputFile;
        internal System.Windows.Forms.Button btStartOCR;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.CheckBox chkFavorSpeed;
        internal System.Windows.Forms.CheckBox chkEnablePageOrientationDetection;
    }
}

