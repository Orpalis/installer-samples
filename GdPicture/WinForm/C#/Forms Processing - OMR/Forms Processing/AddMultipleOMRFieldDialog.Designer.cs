using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;


namespace Csharp_Forms_Processing
{
	public partial class AddMultipleOMRFieldDialog : System.Windows.Forms.Form
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
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new System.Windows.Forms.Button();
			this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.numberOfFieldsPerQuestion = new System.Windows.Forms.NumericUpDown();
			this.numberOfQuestions = new System.Windows.Forms.NumericUpDown();
			this.numberOfRectanglesPanel = new System.Windows.Forms.TableLayoutPanel();
			this.rectanglesLeftLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.numberOfFieldsPerQuestion).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.numberOfQuestions).BeginInit();
			this.numberOfRectanglesPanel.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//TableLayoutPanel1
			//
			this.TableLayoutPanel1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float) (50.0F)));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float) (50.0F)));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(354, 103);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float) (50.0F)));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(170, 36);
			this.TableLayoutPanel1.TabIndex = 0;
			//
			//OK_Button
			//
			this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OK_Button.Location = new System.Drawing.Point(3, 4);
			this.OK_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.Size = new System.Drawing.Size(78, 28);
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			//
			//Cancel_Button
			//
			this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Location = new System.Drawing.Point(88, 4);
			this.Cancel_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(78, 28);
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "Cancel";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Label4.Location = new System.Drawing.Point(6, 80);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(194, 17);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Number of Fields Per Question";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Label3.Location = new System.Drawing.Point(6, 29);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(138, 17);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Number of Questions";
			//
			//numberOfFieldsPerQuestion
			//
			this.numberOfFieldsPerQuestion.Location = new System.Drawing.Point(204, 78);
			this.numberOfFieldsPerQuestion.Maximum = new decimal(new int[] {50, 0, 0, 0});
			this.numberOfFieldsPerQuestion.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.numberOfFieldsPerQuestion.Name = "numberOfFieldsPerQuestion";
			this.numberOfFieldsPerQuestion.Size = new System.Drawing.Size(120, 24);
			this.numberOfFieldsPerQuestion.TabIndex = 5;
			this.numberOfFieldsPerQuestion.Value = new decimal(new int[] {1, 0, 0, 0});
			//
			//numberOfQuestions
			//
			this.numberOfQuestions.Location = new System.Drawing.Point(204, 29);
			this.numberOfQuestions.Maximum = new decimal(new int[] {400, 0, 0, 0});
			this.numberOfQuestions.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.numberOfQuestions.Name = "numberOfQuestions";
			this.numberOfQuestions.Size = new System.Drawing.Size(120, 24);
			this.numberOfQuestions.TabIndex = 4;
			this.numberOfQuestions.Value = new decimal(new int[] {1, 0, 0, 0});
			//
			//numberOfRectanglesPanel
			//
			this.numberOfRectanglesPanel.BackColor = System.Drawing.Color.Transparent;
			this.numberOfRectanglesPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
			this.numberOfRectanglesPanel.ColumnCount = 6;
			this.numberOfRectanglesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (112.0F)));
			this.numberOfRectanglesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (80.0F)));
			this.numberOfRectanglesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (113.0F)));
			this.numberOfRectanglesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (43.0F)));
			this.numberOfRectanglesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (173.0F)));
			this.numberOfRectanglesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (237.0F)));
			this.numberOfRectanglesPanel.Controls.Add(this.rectanglesLeftLabel, 3, 0);
			this.numberOfRectanglesPanel.Location = new System.Drawing.Point(0, 0);
			this.numberOfRectanglesPanel.Name = "numberOfRectanglesPanel";
			this.numberOfRectanglesPanel.RowCount = 1;
			this.numberOfRectanglesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float) (20.0F)));
			this.numberOfRectanglesPanel.Size = new System.Drawing.Size(200, 100);
			this.numberOfRectanglesPanel.TabIndex = 0;
			//
			//rectanglesLeftLabel
			//
			this.rectanglesLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.rectanglesLeftLabel.AutoSize = true;
			this.rectanglesLeftLabel.BackColor = System.Drawing.Color.Transparent;
			this.rectanglesLeftLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.rectanglesLeftLabel.Location = new System.Drawing.Point(320, 41);
			this.rectanglesLeftLabel.Name = "rectanglesLeftLabel";
			this.rectanglesLeftLabel.Size = new System.Drawing.Size(16, 17);
			this.rectanglesLeftLabel.TabIndex = 3;
			this.rectanglesLeftLabel.Text = "0";
			//
			//label2
			//
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(204, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Rectangles Left:";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.numberOfQuestions);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.numberOfFieldsPerQuestion);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Location = new System.Drawing.Point(12, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(339, 139);
			this.GroupBox1.TabIndex = 8;
			this.GroupBox1.TabStop = false;
			//
			//AddMultipleOMRFieldDialog
			//
			this.AcceptButton = this.OK_Button;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			this.ClientSize = new System.Drawing.Size(536, 172);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddMultipleOMRFieldDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Multiple OMR Field";
			this.TableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.numberOfFieldsPerQuestion).EndInit();
			((System.ComponentModel.ISupportInitialize) this.numberOfQuestions).EndInit();
			this.numberOfRectanglesPanel.ResumeLayout(false);
			this.numberOfRectanglesPanel.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.Button OK_Button;
		internal System.Windows.Forms.Button Cancel_Button;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.NumericUpDown numberOfFieldsPerQuestion;
		internal System.Windows.Forms.NumericUpDown numberOfQuestions;
		internal System.Windows.Forms.TableLayoutPanel numberOfRectanglesPanel;
		internal System.Windows.Forms.Label rectanglesLeftLabel;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		
	}
	
}
