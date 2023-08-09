// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


namespace VB_Text_File_to_PDF
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Form1 : System.Windows.Forms.Form
	{
		
		//Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
		
		//Requise par le Concepteur Windows Form
		private System.ComponentModel.Container components = null;
		
		//REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
		//Elle peut être modifiée à l'aide du Concepteur Windows Form.
		//Ne la modifiez pas à l'aide de l'éditeur de code.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label1 = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.cmdParcInputFile = new System.Windows.Forms.Button();
            this.cmdGo = new System.Windows.Forms.Button();
            this.cmdParcOutputFile = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.radLandscape = new System.Windows.Forms.RadioButton();
            this.radPortrait = new System.Windows.Forms.RadioButton();
            this.txtTextSize = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBottomMargin = new System.Windows.Forms.TextBox();
            this.txtRightMargin = new System.Windows.Forms.TextBox();
            this.txtTopMargin = new System.Windows.Forms.TextBox();
            this.txtLeftMargin = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.cboPapers = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 30);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Text File";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(99, 26);
            this.txtInputFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(624, 22);
            this.txtInputFile.TabIndex = 1;
            // 
            // cmdParcInputFile
            // 
            this.cmdParcInputFile.Location = new System.Drawing.Point(732, 30);
            this.cmdParcInputFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdParcInputFile.Name = "cmdParcInputFile";
            this.cmdParcInputFile.Size = new System.Drawing.Size(47, 22);
            this.cmdParcInputFile.TabIndex = 2;
            this.cmdParcInputFile.Text = "...";
            this.cmdParcInputFile.UseVisualStyleBackColor = true;
            this.cmdParcInputFile.Click += new System.EventHandler(this.cmdParcInputFile_Click);
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(265, 411);
            this.cmdGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(253, 73);
            this.cmdGo.TabIndex = 3;
            this.cmdGo.Text = "Convert";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // cmdParcOutputFile
            // 
            this.cmdParcOutputFile.Location = new System.Drawing.Point(732, 69);
            this.cmdParcOutputFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdParcOutputFile.Name = "cmdParcOutputFile";
            this.cmdParcOutputFile.Size = new System.Drawing.Size(47, 22);
            this.cmdParcOutputFile.TabIndex = 6;
            this.cmdParcOutputFile.Text = "...";
            this.cmdParcOutputFile.UseVisualStyleBackColor = true;
            this.cmdParcOutputFile.Click += new System.EventHandler(this.cmdParcOutputFile_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(99, 65);
            this.txtOutputFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(624, 22);
            this.txtOutputFile.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 69);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 17);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Pdf File";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(16, 491);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(741, 26);
            this.ProgressBar1.TabIndex = 7;
            this.ProgressBar1.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.radLandscape);
            this.GroupBox1.Controls.Add(this.radPortrait);
            this.GroupBox1.Controls.Add(this.txtTextSize);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.cboPapers);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(40, 128);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(716, 256);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "PDF page format";
            // 
            // radLandscape
            // 
            this.radLandscape.AutoSize = true;
            this.radLandscape.Location = new System.Drawing.Point(503, 60);
            this.radLandscape.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLandscape.Name = "radLandscape";
            this.radLandscape.Size = new System.Drawing.Size(99, 21);
            this.radLandscape.TabIndex = 16;
            this.radLandscape.Text = "Landscape";
            this.radLandscape.UseVisualStyleBackColor = true;
            // 
            // radPortrait
            // 
            this.radPortrait.AutoSize = true;
            this.radPortrait.Checked = true;
            this.radPortrait.Location = new System.Drawing.Point(389, 60);
            this.radPortrait.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radPortrait.Name = "radPortrait";
            this.radPortrait.Size = new System.Drawing.Size(75, 21);
            this.radPortrait.TabIndex = 15;
            this.radPortrait.TabStop = true;
            this.radPortrait.Text = "Portrait";
            this.radPortrait.UseVisualStyleBackColor = true;
            // 
            // txtTextSize
            // 
            this.txtTextSize.Location = new System.Drawing.Point(175, 218);
            this.txtTextSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTextSize.Name = "txtTextSize";
            this.txtTextSize.Size = new System.Drawing.Size(111, 22);
            this.txtTextSize.TabIndex = 14;
            this.txtTextSize.Text = "10";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(31, 226);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(123, 17);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Text Size in points";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtBottomMargin);
            this.GroupBox2.Controls.Add(this.txtRightMargin);
            this.GroupBox2.Controls.Add(this.txtTopMargin);
            this.GroupBox2.Controls.Add(this.txtLeftMargin);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Location = new System.Drawing.Point(36, 103);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(620, 94);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Margins in millimeters";
            // 
            // txtBottomMargin
            // 
            this.txtBottomMargin.Location = new System.Drawing.Point(396, 62);
            this.txtBottomMargin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBottomMargin.Name = "txtBottomMargin";
            this.txtBottomMargin.Size = new System.Drawing.Size(111, 22);
            this.txtBottomMargin.TabIndex = 15;
            this.txtBottomMargin.Text = "0";
            // 
            // txtRightMargin
            // 
            this.txtRightMargin.Location = new System.Drawing.Point(396, 34);
            this.txtRightMargin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRightMargin.Name = "txtRightMargin";
            this.txtRightMargin.Size = new System.Drawing.Size(111, 22);
            this.txtRightMargin.TabIndex = 14;
            this.txtRightMargin.Text = "0";
            // 
            // txtTopMargin
            // 
            this.txtTopMargin.Location = new System.Drawing.Point(139, 62);
            this.txtTopMargin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTopMargin.Name = "txtTopMargin";
            this.txtTopMargin.Size = new System.Drawing.Size(111, 22);
            this.txtTopMargin.TabIndex = 13;
            this.txtTopMargin.Text = "0";
            // 
            // txtLeftMargin
            // 
            this.txtLeftMargin.Location = new System.Drawing.Point(139, 34);
            this.txtLeftMargin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLeftMargin.Name = "txtLeftMargin";
            this.txtLeftMargin.Size = new System.Drawing.Size(111, 22);
            this.txtLeftMargin.TabIndex = 12;
            this.txtLeftMargin.Text = "0";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(276, 65);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(103, 17);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Bottom  margin";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(276, 33);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 17);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Right margin";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(40, 65);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 17);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Top margin";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(40, 33);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 17);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Left margin";
            // 
            // cboPapers
            // 
            this.cboPapers.FormattingEnabled = true;
            this.cboPapers.Location = new System.Drawing.Point(153, 20);
            this.cboPapers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPapers.Name = "cboPapers";
            this.cboPapers.Size = new System.Drawing.Size(452, 24);
            this.cboPapers.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(32, 20);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 17);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Paper Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 532);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.cmdParcOutputFile);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.cmdParcInputFile);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "GdPicture.NET - Text File to PDF Demo  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtInputFile;
		internal System.Windows.Forms.Button cmdParcInputFile;
		internal System.Windows.Forms.Button cmdGo;
		internal System.Windows.Forms.Button cmdParcOutputFile;
		internal System.Windows.Forms.TextBox txtOutputFile;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.ComboBox cboPapers;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtTextSize;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.TextBox txtBottomMargin;
		internal System.Windows.Forms.TextBox txtRightMargin;
		internal System.Windows.Forms.TextBox txtTopMargin;
		internal System.Windows.Forms.TextBox txtLeftMargin;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.RadioButton radLandscape;
		internal System.Windows.Forms.RadioButton radPortrait;
		
	}
	
}
