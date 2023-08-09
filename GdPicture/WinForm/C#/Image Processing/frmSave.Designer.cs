
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;



namespace Image_Processing
{
	
	partial class frmSave : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSave));
			this.btnCancel = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(frmSave_Load);
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.lblDestinationFolder = new System.Windows.Forms.Label();
			this.txtDestinationFolder = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			this.lblDocumentFormat = new System.Windows.Forms.Label();
			this.cbDocumentFormat = new System.Windows.Forms.ComboBox();
			this.cbDocumentFormat.SelectedIndexChanged += new System.EventHandler(this.cbDocumentFormat_ValueMemberChanged);
			this.grpCompressionOptions = new System.Windows.Forms.GroupBox();
			this.cbExrCompression = new System.Windows.Forms.ComboBox();
			this.lblExrCompression = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.nJ2kRate = new System.Windows.Forms.NumericUpDown();
			this.Label2 = new System.Windows.Forms.Label();
			this.nJpegQuality = new System.Windows.Forms.NumericUpDown();
			this.chkProgressive = new System.Windows.Forms.CheckBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.nPngCompressionLevel = new System.Windows.Forms.NumericUpDown();
			this.chkPngInterlaced = new System.Windows.Forms.CheckBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.cbTiffCompression = new System.Windows.Forms.ComboBox();
			this.chkTiffCmyk = new System.Windows.Forms.CheckBox();
			this.grpCompressionOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.nJ2kRate).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.nJpegQuality).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.nPngCompressionLevel).BeginInit();
			this.SuspendLayout();
			//
			//btnCancel
			//
			this.btnCancel.Location = new System.Drawing.Point(443, 254);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//btnSave
			//
			this.btnSave.Location = new System.Drawing.Point(362, 254);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			//
			//lblDestinationFolder
			//
			this.lblDestinationFolder.AutoSize = true;
			this.lblDestinationFolder.Location = new System.Drawing.Point(10, 17);
			this.lblDestinationFolder.Name = "lblDestinationFolder";
			this.lblDestinationFolder.Size = new System.Drawing.Size(92, 13);
			this.lblDestinationFolder.TabIndex = 2;
			this.lblDestinationFolder.Text = "Destination folder:";
			//
			//txtDestinationFolder
			//
			this.txtDestinationFolder.Location = new System.Drawing.Point(105, 14);
			this.txtDestinationFolder.Name = "txtDestinationFolder";
			this.txtDestinationFolder.Size = new System.Drawing.Size(329, 20);
			this.txtDestinationFolder.TabIndex = 3;
			//
			//btnBrowse
			//
			this.btnBrowse.Location = new System.Drawing.Point(443, 12);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 4;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			//
			//lblDocumentFormat
			//
			this.lblDocumentFormat.AutoSize = true;
			this.lblDocumentFormat.Location = new System.Drawing.Point(10, 43);
			this.lblDocumentFormat.Name = "lblDocumentFormat";
			this.lblDocumentFormat.Size = new System.Drawing.Size(91, 13);
			this.lblDocumentFormat.TabIndex = 5;
			this.lblDocumentFormat.Text = "Document format:";
			//
			//cbDocumentFormat
			//
			this.cbDocumentFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDocumentFormat.FormattingEnabled = true;
			this.cbDocumentFormat.Location = new System.Drawing.Point(105, 40);
			this.cbDocumentFormat.Name = "cbDocumentFormat";
			this.cbDocumentFormat.Size = new System.Drawing.Size(228, 21);
			this.cbDocumentFormat.TabIndex = 6;
			//
			//grpCompressionOptions
			//
			this.grpCompressionOptions.Controls.Add(this.chkTiffCmyk);
			this.grpCompressionOptions.Controls.Add(this.cbTiffCompression);
			this.grpCompressionOptions.Controls.Add(this.Label4);
			this.grpCompressionOptions.Controls.Add(this.chkPngInterlaced);
			this.grpCompressionOptions.Controls.Add(this.nPngCompressionLevel);
			this.grpCompressionOptions.Controls.Add(this.Label3);
			this.grpCompressionOptions.Controls.Add(this.chkProgressive);
			this.grpCompressionOptions.Controls.Add(this.nJpegQuality);
			this.grpCompressionOptions.Controls.Add(this.Label2);
			this.grpCompressionOptions.Controls.Add(this.nJ2kRate);
			this.grpCompressionOptions.Controls.Add(this.Label1);
			this.grpCompressionOptions.Controls.Add(this.lblExrCompression);
			this.grpCompressionOptions.Controls.Add(this.cbExrCompression);
			this.grpCompressionOptions.Location = new System.Drawing.Point(13, 73);
			this.grpCompressionOptions.Name = "grpCompressionOptions";
			this.grpCompressionOptions.Size = new System.Drawing.Size(505, 175);
			this.grpCompressionOptions.TabIndex = 7;
			this.grpCompressionOptions.TabStop = false;
			this.grpCompressionOptions.Text = "Compression options";
			//
			//cbExrCompression
			//
			this.cbExrCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbExrCompression.FormattingEnabled = true;
			this.cbExrCompression.Location = new System.Drawing.Point(115, 26);
			this.cbExrCompression.Name = "cbExrCompression";
			this.cbExrCompression.Size = new System.Drawing.Size(221, 21);
			this.cbExrCompression.TabIndex = 0;
			//
			//lblExrCompression
			//
			this.lblExrCompression.AutoSize = true;
			this.lblExrCompression.Location = new System.Drawing.Point(18, 29);
			this.lblExrCompression.Name = "lblExrCompression";
			this.lblExrCompression.Size = new System.Drawing.Size(94, 13);
			this.lblExrCompression.TabIndex = 1;
			this.lblExrCompression.Text = "EXR compression:";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(18, 55);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(147, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "JPEG-2000 compression rate:";
			//
			//nJ2kRate
			//
			this.nJ2kRate.Location = new System.Drawing.Point(168, 53);
			this.nJ2kRate.Maximum = new decimal(new int[] {512, 0, 0, 0});
			this.nJ2kRate.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.nJ2kRate.Name = "nJ2kRate";
			this.nJ2kRate.Size = new System.Drawing.Size(58, 20);
			this.nJ2kRate.TabIndex = 3;
			this.nJ2kRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nJ2kRate.Value = new decimal(new int[] {16, 0, 0, 0});
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(18, 81);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(70, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "JPEG quality:";
			//
			//nJpegQuality
			//
			this.nJpegQuality.Location = new System.Drawing.Point(168, 79);
			this.nJpegQuality.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.nJpegQuality.Name = "nJpegQuality";
			this.nJpegQuality.Size = new System.Drawing.Size(58, 20);
			this.nJpegQuality.TabIndex = 5;
			this.nJpegQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nJpegQuality.Value = new decimal(new int[] {75, 0, 0, 0});
			//
			//chkProgressive
			//
			this.chkProgressive.AutoSize = true;
			this.chkProgressive.Location = new System.Drawing.Point(242, 80);
			this.chkProgressive.Name = "chkProgressive";
			this.chkProgressive.Size = new System.Drawing.Size(81, 17);
			this.chkProgressive.TabIndex = 6;
			this.chkProgressive.Text = "Progressive";
			this.chkProgressive.UseVisualStyleBackColor = true;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(18, 107);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(120, 13);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "PNG compression level:";
			//
			//nPngCompressionLevel
			//
			this.nPngCompressionLevel.Location = new System.Drawing.Point(168, 105);
			this.nPngCompressionLevel.Maximum = new decimal(new int[] {9, 0, 0, 0});
			this.nPngCompressionLevel.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.nPngCompressionLevel.Name = "nPngCompressionLevel";
			this.nPngCompressionLevel.Size = new System.Drawing.Size(43, 20);
			this.nPngCompressionLevel.TabIndex = 8;
			this.nPngCompressionLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nPngCompressionLevel.Value = new decimal(new int[] {6, 0, 0, 0});
			//
			//chkPngInterlaced
			//
			this.chkPngInterlaced.AutoSize = true;
			this.chkPngInterlaced.Location = new System.Drawing.Point(227, 106);
			this.chkPngInterlaced.Name = "chkPngInterlaced";
			this.chkPngInterlaced.Size = new System.Drawing.Size(73, 17);
			this.chkPngInterlaced.TabIndex = 9;
			this.chkPngInterlaced.Text = "Interlaced";
			this.chkPngInterlaced.UseVisualStyleBackColor = true;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(18, 134);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(94, 13);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "TIFF compression:";
			//
			//cbTiffCompression
			//
			this.cbTiffCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTiffCompression.FormattingEnabled = true;
			this.cbTiffCompression.Location = new System.Drawing.Point(115, 131);
			this.cbTiffCompression.Name = "cbTiffCompression";
			this.cbTiffCompression.Size = new System.Drawing.Size(269, 21);
			this.cbTiffCompression.TabIndex = 11;
			//
			//chkTiffCmyk
			//
			this.chkTiffCmyk.AutoSize = true;
			this.chkTiffCmyk.Location = new System.Drawing.Point(400, 133);
			this.chkTiffCmyk.Name = "chkTiffCmyk";
			this.chkTiffCmyk.Size = new System.Drawing.Size(85, 17);
			this.chkTiffCmyk.TabIndex = 12;
			this.chkTiffCmyk.Text = "CMYK mode";
			this.chkTiffCmyk.UseVisualStyleBackColor = true;
			//
			//frmSave
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 287);
			this.Controls.Add(this.grpCompressionOptions);
			this.Controls.Add(this.cbDocumentFormat);
			this.Controls.Add(this.lblDocumentFormat);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtDestinationFolder);
			this.Controls.Add(this.lblDestinationFolder);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSave";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Save";
			this.grpCompressionOptions.ResumeLayout(false);
			this.grpCompressionOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.nJ2kRate).EndInit();
			((System.ComponentModel.ISupportInitialize) this.nJpegQuality).EndInit();
			((System.ComponentModel.ISupportInitialize) this.nPngCompressionLevel).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button btnCancel;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.Label lblDestinationFolder;
		internal System.Windows.Forms.TextBox txtDestinationFolder;
		internal System.Windows.Forms.Button btnBrowse;
		internal System.Windows.Forms.Label lblDocumentFormat;
		internal System.Windows.Forms.ComboBox cbDocumentFormat;
		internal System.Windows.Forms.GroupBox grpCompressionOptions;
		internal System.Windows.Forms.Label lblExrCompression;
		internal System.Windows.Forms.ComboBox cbExrCompression;
		internal System.Windows.Forms.NumericUpDown nJ2kRate;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.CheckBox chkProgressive;
		internal System.Windows.Forms.NumericUpDown nJpegQuality;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.CheckBox chkTiffCmyk;
		internal System.Windows.Forms.ComboBox cbTiffCompression;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.CheckBox chkPngInterlaced;
		internal System.Windows.Forms.NumericUpDown nPngCompressionLevel;
		internal System.Windows.Forms.Label Label3;
	}
	
}
