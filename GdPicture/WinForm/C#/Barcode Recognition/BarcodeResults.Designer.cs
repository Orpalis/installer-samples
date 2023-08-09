

namespace barcode_recognition
{
public 	partial class BarcodeResults : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.btn1DBarcode = new System.Windows.Forms.Button();
            this.btn2DBarcode = new System.Windows.Forms.Button();
            this.btnQRBarcode = new System.Windows.Forms.Button();
            this.btnPDF417Barcode = new System.Windows.Forms.Button();
            this.btnMicroQRBarcode = new System.Windows.Forms.Button();
            this.btnPatchCodeBarcode = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalBarcodesCount = new System.Windows.Forms.Label();
            this.resultsList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAztecBarcode = new System.Windows.Forms.Button();
            this.btnMaxicodeBarcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1DBarcode
            // 
            this.btn1DBarcode.Enabled = false;
            this.btn1DBarcode.Location = new System.Drawing.Point(526, 26);
            this.btn1DBarcode.Name = "btn1DBarcode";
            this.btn1DBarcode.Size = new System.Drawing.Size(226, 60);
            this.btn1DBarcode.TabIndex = 0;
            this.btn1DBarcode.Text = "1D bar codes";
            this.btn1DBarcode.UseVisualStyleBackColor = true;
            this.btn1DBarcode.Click += new System.EventHandler(this.btn1DBarcode_Click);
            // 
            // btn2DBarcode
            // 
            this.btn2DBarcode.Enabled = false;
            this.btn2DBarcode.Location = new System.Drawing.Point(525, 89);
            this.btn2DBarcode.Name = "btn2DBarcode";
            this.btn2DBarcode.Size = new System.Drawing.Size(226, 60);
            this.btn2DBarcode.TabIndex = 1;
            this.btn2DBarcode.Text = "Data Matrix bar codes";
            this.btn2DBarcode.UseVisualStyleBackColor = true;
            this.btn2DBarcode.Click += new System.EventHandler(this.btn2DBarcode_Click);
            // 
            // btnQRBarcode
            // 
            this.btnQRBarcode.Enabled = false;
            this.btnQRBarcode.Location = new System.Drawing.Point(526, 152);
            this.btnQRBarcode.Name = "btnQRBarcode";
            this.btnQRBarcode.Size = new System.Drawing.Size(226, 60);
            this.btnQRBarcode.TabIndex = 2;
            this.btnQRBarcode.Text = "QR Codes";
            this.btnQRBarcode.UseVisualStyleBackColor = true;
            this.btnQRBarcode.Click += new System.EventHandler(this.btnQRBarcode_Click);
            // 
            // btnPDF417Barcode
            // 
            this.btnPDF417Barcode.Enabled = false;
            this.btnPDF417Barcode.Location = new System.Drawing.Point(526, 215);
            this.btnPDF417Barcode.Name = "btnPDF417Barcode";
            this.btnPDF417Barcode.Size = new System.Drawing.Size(226, 60);
            this.btnPDF417Barcode.TabIndex = 3;
            this.btnPDF417Barcode.Text = "PDF417 bar codes";
            this.btnPDF417Barcode.UseVisualStyleBackColor = true;
            this.btnPDF417Barcode.Click += new System.EventHandler(this.btnPDF417Barcode_Click);
            // 
            // btnMicroQRBarcode
            // 
            this.btnMicroQRBarcode.Enabled = false;
            this.btnMicroQRBarcode.Location = new System.Drawing.Point(526, 278);
            this.btnMicroQRBarcode.Name = "btnMicroQRBarcode";
            this.btnMicroQRBarcode.Size = new System.Drawing.Size(226, 60);
            this.btnMicroQRBarcode.TabIndex = 4;
            this.btnMicroQRBarcode.Text = "Micro QR Codes";
            this.btnMicroQRBarcode.UseVisualStyleBackColor = true;
            this.btnMicroQRBarcode.Click += new System.EventHandler(this.btnMicroQRBarcode_Click);
            // 
            // btnPatchCodeBarcode
            // 
            this.btnPatchCodeBarcode.Enabled = false;
            this.btnPatchCodeBarcode.Location = new System.Drawing.Point(525, 470);
            this.btnPatchCodeBarcode.Name = "btnPatchCodeBarcode";
            this.btnPatchCodeBarcode.Size = new System.Drawing.Size(226, 60);
            this.btnPatchCodeBarcode.TabIndex = 5;
            this.btnPatchCodeBarcode.Text = "Patch Codes";
            this.btnPatchCodeBarcode.UseVisualStyleBackColor = true;
            this.btnPatchCodeBarcode.Click += new System.EventHandler(this.btnPatchCodeBarcode_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(16, 536);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(735, 52);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // lblTotalBarcodesCount
            // 
            this.lblTotalBarcodesCount.AutoSize = true;
            this.lblTotalBarcodesCount.Location = new System.Drawing.Point(14, 9);
            this.lblTotalBarcodesCount.Name = "lblTotalBarcodesCount";
            this.lblTotalBarcodesCount.Size = new System.Drawing.Size(170, 13);
            this.lblTotalBarcodesCount.TabIndex = 8;
            this.lblTotalBarcodesCount.Text = "Total Number of Barcodes Found: ";
            // 
            // resultsList
            // 
            this.resultsList.AutoScroll = true;
            this.resultsList.Location = new System.Drawing.Point(17, 26);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(503, 504);
            this.resultsList.TabIndex = 10;
            // 
            // btnAztecBarcode
            // 
            this.btnAztecBarcode.Enabled = false;
            this.btnAztecBarcode.Location = new System.Drawing.Point(526, 341);
            this.btnAztecBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.btnAztecBarcode.Name = "btnAztecBarcode";
            this.btnAztecBarcode.Size = new System.Drawing.Size(226, 60);
            this.btnAztecBarcode.TabIndex = 11;
            this.btnAztecBarcode.Text = "Aztec Codes";
            this.btnAztecBarcode.UseVisualStyleBackColor = true;
            this.btnAztecBarcode.Click += new System.EventHandler(this.btnAztecBarcode_Click);
            // 
            // btnMaxicodeBarcode
            // 
            this.btnMaxicodeBarcode.Enabled = false;
            this.btnMaxicodeBarcode.Location = new System.Drawing.Point(525, 405);
            this.btnMaxicodeBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaxicodeBarcode.Name = "btnMaxicodeBarcode";
            this.btnMaxicodeBarcode.Size = new System.Drawing.Size(226, 60);
            this.btnMaxicodeBarcode.TabIndex = 12;
            this.btnMaxicodeBarcode.Text = "MaxiCodes";
            this.btnMaxicodeBarcode.UseVisualStyleBackColor = true;
            this.btnMaxicodeBarcode.Click += new System.EventHandler(this.btnMaxicodeBarcode_Click);
            // 
            // BarcodeResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 596);
            this.Controls.Add(this.btnMaxicodeBarcode);
            this.Controls.Add(this.btnAztecBarcode);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.lblTotalBarcodesCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPatchCodeBarcode);
            this.Controls.Add(this.btnMicroQRBarcode);
            this.Controls.Add(this.btnPDF417Barcode);
            this.Controls.Add(this.btnQRBarcode);
            this.Controls.Add(this.btn2DBarcode);
            this.Controls.Add(this.btn1DBarcode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeResults";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BarcodeResults";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button btn1DBarcode;
		internal System.Windows.Forms.Button btn2DBarcode;
		internal System.Windows.Forms.Button btnQRBarcode;
		internal System.Windows.Forms.Button btnPDF417Barcode;
		internal System.Windows.Forms.Button btnMicroQRBarcode;
        internal System.Windows.Forms.Button btnAztecBarcode;
        internal System.Windows.Forms.Button btnPatchCodeBarcode;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Label lblTotalBarcodesCount;
		internal System.Windows.Forms.FlowLayoutPanel resultsList;
        private System.Windows.Forms.Button btnMaxicodeBarcode;
    }
	
}
