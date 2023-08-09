// VBConversions Note: VB project level imports
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
// End of VB project level imports


namespace Csharp_File_Converter
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Form1 : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.ChooseDestinationFolder = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Label4 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.ChooseInputFile = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.Label8 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel6.SuspendLayout();
            this.TableLayoutPanel9.SuspendLayout();
            this.TableLayoutPanel5.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.TableLayoutPanel7.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.TableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TableLayoutPanel1.ColumnCount = 4;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21365F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.4635F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.32482F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel6, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel5, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel4, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1518, 259);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // TableLayoutPanel6
            // 
            this.TableLayoutPanel6.ColumnCount = 1;
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel6.Controls.Add(this.TableLayoutPanel9, 0, 2);
            this.TableLayoutPanel6.Controls.Add(this.Label3, 0, 0);
            this.TableLayoutPanel6.Controls.Add(this.Label7, 0, 1);
            this.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel6.Location = new System.Drawing.Point(757, 6);
            this.TableLayoutPanel6.Name = "TableLayoutPanel6";
            this.TableLayoutPanel6.RowCount = 3;
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.18518F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.81482F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.TableLayoutPanel6.Size = new System.Drawing.Size(477, 274);
            this.TableLayoutPanel6.TabIndex = 6;
            // 
            // TableLayoutPanel9
            // 
            this.TableLayoutPanel9.ColumnCount = 1;
            this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel9.Controls.Add(this.ChooseDestinationFolder, 0, 0);
            this.TableLayoutPanel9.Controls.Add(this.TextBox2, 0, 1);
            this.TableLayoutPanel9.Location = new System.Drawing.Point(3, 135);
            this.TableLayoutPanel9.Name = "TableLayoutPanel9";
            this.TableLayoutPanel9.RowCount = 2;
            this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.02941F));
            this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.97059F));
            this.TableLayoutPanel9.Size = new System.Drawing.Size(470, 136);
            this.TableLayoutPanel9.TabIndex = 3;
            // 
            // ChooseDestinationFolder
            // 
            this.ChooseDestinationFolder.Location = new System.Drawing.Point(3, 3);
            this.ChooseDestinationFolder.Name = "ChooseDestinationFolder";
            this.ChooseDestinationFolder.Size = new System.Drawing.Size(104, 38);
            this.ChooseDestinationFolder.TabIndex = 0;
            this.ChooseDestinationFolder.Text = "Browse...";
            this.ChooseDestinationFolder.UseVisualStyleBackColor = true;
            this.ChooseDestinationFolder.Click += new System.EventHandler(this.ChooseDestinationFolder_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox2.Enabled = false;
            this.TextBox2.Location = new System.Drawing.Point(3, 51);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(462, 22);
            this.TextBox2.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(77, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(322, 34);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "3) Destination Folder:";
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(136, 97);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(205, 17);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Choose destination folder path:";
            // 
            // TableLayoutPanel5
            // 
            this.TableLayoutPanel5.ColumnCount = 1;
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel5.Controls.Add(this.Label4, 0, 0);
            this.TableLayoutPanel5.Controls.Add(this.Convert, 0, 2);
            this.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel5.Location = new System.Drawing.Point(1243, 6);
            this.TableLayoutPanel5.Name = "TableLayoutPanel5";
            this.TableLayoutPanel5.RowCount = 3;
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.18518F));
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.81482F));
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.TableLayoutPanel5.Size = new System.Drawing.Size(269, 274);
            this.TableLayoutPanel5.TabIndex = 5;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(47, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(175, 34);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "4) Convert:";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(3, 135);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(237, 124);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "convert!";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.ColumnCount = 1;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel4.Controls.Add(this.Label1, 0, 0);
            this.TableLayoutPanel4.Controls.Add(this.Label5, 0, 1);
            this.TableLayoutPanel4.Controls.Add(this.TableLayoutPanel7, 0, 2);
            this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 3;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.18518F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.81482F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(402, 274);
            this.TableLayoutPanel4.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(100, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(201, 34);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "1) Input File:";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(97, 97);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(207, 17);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Choose file you wish to convert:";
            // 
            // TableLayoutPanel7
            // 
            this.TableLayoutPanel7.ColumnCount = 1;
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel7.Controls.Add(this.ChooseInputFile, 0, 0);
            this.TableLayoutPanel7.Controls.Add(this.TextBox1, 0, 1);
            this.TableLayoutPanel7.Location = new System.Drawing.Point(3, 135);
            this.TableLayoutPanel7.Name = "TableLayoutPanel7";
            this.TableLayoutPanel7.RowCount = 2;
            this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.02941F));
            this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.97059F));
            this.TableLayoutPanel7.Size = new System.Drawing.Size(395, 136);
            this.TableLayoutPanel7.TabIndex = 2;
            // 
            // ChooseInputFile
            // 
            this.ChooseInputFile.Location = new System.Drawing.Point(3, 3);
            this.ChooseInputFile.Name = "ChooseInputFile";
            this.ChooseInputFile.Size = new System.Drawing.Size(104, 38);
            this.ChooseInputFile.TabIndex = 0;
            this.ChooseInputFile.Text = "Browse...";
            this.ChooseInputFile.UseVisualStyleBackColor = true;
            this.ChooseInputFile.Click += new System.EventHandler(this.ChooseInputFile_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(3, 51);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(388, 22);
            this.TextBox1.TabIndex = 1;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.Label6, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.TableLayoutPanel8, 0, 2);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(417, 6);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 3;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.18518F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.81482F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(331, 274);
            this.TableLayoutPanel2.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(25, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(281, 34);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "2) Output Format :";
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(91, 97);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(148, 17);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Choose output format:";
            // 
            // TableLayoutPanel8
            // 
            this.TableLayoutPanel8.ColumnCount = 1;
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel8.Controls.Add(this.Label8, 0, 0);
            this.TableLayoutPanel8.Controls.Add(this.ComboBox1, 0, 1);
            this.TableLayoutPanel8.Location = new System.Drawing.Point(3, 135);
            this.TableLayoutPanel8.Name = "TableLayoutPanel8";
            this.TableLayoutPanel8.RowCount = 2;
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.70588F));
            this.TableLayoutPanel8.Size = new System.Drawing.Size(321, 136);
            this.TableLayoutPanel8.TabIndex = 3;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(3, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(0, 17);
            this.Label8.TabIndex = 0;
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "TIF",
            "JPEG",
            "PDF",
            "BMP",
            "GIF",
            "PNG",
            "JBIG2",
            "EXR",
            "J2K",
            "JP2",
            "PBM",
            "TGA",
            "WBMP",
            "WMF",
            "XMP"});
            this.ComboBox1.Location = new System.Drawing.Point(3, 51);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(314, 24);
            this.ComboBox1.TabIndex = 1;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 1;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 3;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.TableLayoutPanel3.TabIndex = 0;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(7, 274);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(1247, 23);
            this.ProgressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 303);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1536, 350);
            this.MinimumSize = new System.Drawing.Size(1536, 350);
            this.Name = "Form1";
            this.Text = "GdPicture.NET - File Converter  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel6.ResumeLayout(false);
            this.TableLayoutPanel6.PerformLayout();
            this.TableLayoutPanel9.ResumeLayout(false);
            this.TableLayoutPanel9.PerformLayout();
            this.TableLayoutPanel5.ResumeLayout(false);
            this.TableLayoutPanel5.PerformLayout();
            this.TableLayoutPanel4.ResumeLayout(false);
            this.TableLayoutPanel4.PerformLayout();
            this.TableLayoutPanel7.ResumeLayout(false);
            this.TableLayoutPanel7.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.TableLayoutPanel8.ResumeLayout(false);
            this.TableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel6;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel5;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel7;
		internal System.Windows.Forms.Button ChooseInputFile;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel8;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel9;
		internal System.Windows.Forms.Button ChooseDestinationFolder;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Button Convert;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		
	}
	
}
