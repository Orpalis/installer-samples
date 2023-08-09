
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;



namespace Annotations
{
	
	partial class frmPrint : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
			this.cmbPrintAlignment = new System.Windows.Forms.ComboBox();
			base.Load += new System.EventHandler(frmPrint_Load);
			this.chkCollate = new System.Windows.Forms.CheckBox();
			this.rbPageRangeSelection = new System.Windows.Forms.RadioButton();
			this.rbPageRangeSelection.CheckedChanged += new System.EventHandler(this.rbPageRangeSelection_CheckedChanged);
			this.rbPageRangeAll = new System.Windows.Forms.RadioButton();
			this.rbPageRangeAll.CheckedChanged += new System.EventHandler(this.rbPageRangeAll_CheckedChanged);
			this.txtPageRangeEnd = new System.Windows.Forms.TextBox();
			this.lblPageRangeTo = new System.Windows.Forms.Label();
			this.txtPageRangeStart = new System.Windows.Forms.TextBox();
			this.rbPageRangePages = new System.Windows.Forms.RadioButton();
			this.rbPageRangePages.CheckedChanged += new System.EventHandler(this.rbPageRangePages_CheckedChanged);
			this.lblPrintAlignment = new System.Windows.Forms.Label();
			this.grpPageRange = new System.Windows.Forms.GroupBox();
			this.rbPageRangeCurrent = new System.Windows.Forms.RadioButton();
			this.rbPageRangeCurrent.CheckedChanged += new System.EventHandler(this.rbPageRangeCurrent_CheckedChanged);
			this.rbOrientationLandscape = new System.Windows.Forms.RadioButton();
			this.rbOrientationPortrait = new System.Windows.Forms.RadioButton();
			this.rbOrientationAutomatic = new System.Windows.Forms.RadioButton();
			this.cmbPrintSize = new System.Windows.Forms.ComboBox();
			this.btnPrinterProperties = new System.Windows.Forms.Button();
			this.btnPrinterProperties.Click += new System.EventHandler(this.btnPrinterProperties_Click);
			this.lblPrintSize = new System.Windows.Forms.Label();
			this.cmbPrinterList = new System.Windows.Forms.ComboBox();
			this.cmbPrinterList.SelectedIndexChanged += new System.EventHandler(this.cmbPrinterList_SelectedIndexChanged);
			this.lblCopies = new System.Windows.Forms.Label();
			this.lblPrinter = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			this.grpOrientation = new System.Windows.Forms.GroupBox();
			this.numCopies = new System.Windows.Forms.NumericUpDown();
			this.grpPageRange.SuspendLayout();
			this.grpOrientation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.numCopies).BeginInit();
			this.SuspendLayout();
			//
			//cmbPrintAlignment
			//
			this.cmbPrintAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPrintAlignment.FormattingEnabled = true;
			this.cmbPrintAlignment.Location = new System.Drawing.Point(138, 93);
			this.cmbPrintAlignment.Name = "cmbPrintAlignment";
			this.cmbPrintAlignment.Size = new System.Drawing.Size(198, 21);
			this.cmbPrintAlignment.TabIndex = 24;
			//
			//chkCollate
			//
			this.chkCollate.AutoSize = true;
			this.chkCollate.Location = new System.Drawing.Point(205, 43);
			this.chkCollate.Name = "chkCollate";
			this.chkCollate.Size = new System.Drawing.Size(58, 17);
			this.chkCollate.TabIndex = 22;
			this.chkCollate.Text = "Collate";
			this.chkCollate.UseVisualStyleBackColor = true;
			//
			//rbPageRangeSelection
			//
			this.rbPageRangeSelection.AutoSize = true;
			this.rbPageRangeSelection.Enabled = false;
			this.rbPageRangeSelection.Location = new System.Drawing.Point(13, 45);
			this.rbPageRangeSelection.Name = "rbPageRangeSelection";
			this.rbPageRangeSelection.Size = new System.Drawing.Size(100, 17);
			this.rbPageRangeSelection.TabIndex = 13;
			this.rbPageRangeSelection.TabStop = true;
			this.rbPageRangeSelection.Text = "Checked pages";
			this.rbPageRangeSelection.UseVisualStyleBackColor = true;
			//
			//rbPageRangeAll
			//
			this.rbPageRangeAll.AutoSize = true;
			this.rbPageRangeAll.Checked = true;
			this.rbPageRangeAll.Location = new System.Drawing.Point(13, 21);
			this.rbPageRangeAll.Name = "rbPageRangeAll";
			this.rbPageRangeAll.Size = new System.Drawing.Size(36, 17);
			this.rbPageRangeAll.TabIndex = 12;
			this.rbPageRangeAll.TabStop = true;
			this.rbPageRangeAll.Text = "All";
			this.rbPageRangeAll.UseVisualStyleBackColor = true;
			//
			//txtPageRangeEnd
			//
			this.txtPageRangeEnd.Location = new System.Drawing.Point(169, 68);
			this.txtPageRangeEnd.Name = "txtPageRangeEnd";
			this.txtPageRangeEnd.Size = new System.Drawing.Size(42, 20);
			this.txtPageRangeEnd.TabIndex = 17;
			//
			//lblPageRangeTo
			//
			this.lblPageRangeTo.AutoSize = true;
			this.lblPageRangeTo.Location = new System.Drawing.Point(146, 73);
			this.lblPageRangeTo.Name = "lblPageRangeTo";
			this.lblPageRangeTo.Size = new System.Drawing.Size(16, 13);
			this.lblPageRangeTo.TabIndex = 16;
			this.lblPageRangeTo.Text = "to";
			this.lblPageRangeTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			//txtPageRangeStart
			//
			this.txtPageRangeStart.Location = new System.Drawing.Point(98, 68);
			this.txtPageRangeStart.Name = "txtPageRangeStart";
			this.txtPageRangeStart.Size = new System.Drawing.Size(42, 20);
			this.txtPageRangeStart.TabIndex = 16;
			//
			//rbPageRangePages
			//
			this.rbPageRangePages.AutoSize = true;
			this.rbPageRangePages.Location = new System.Drawing.Point(13, 69);
			this.rbPageRangePages.Name = "rbPageRangePages";
			this.rbPageRangePages.Size = new System.Drawing.Size(78, 17);
			this.rbPageRangePages.TabIndex = 15;
			this.rbPageRangePages.TabStop = true;
			this.rbPageRangePages.Text = "Pages from";
			this.rbPageRangePages.UseVisualStyleBackColor = true;
			//
			//lblPrintAlignment
			//
			this.lblPrintAlignment.AutoSize = true;
			this.lblPrintAlignment.Location = new System.Drawing.Point(10, 96);
			this.lblPrintAlignment.Name = "lblPrintAlignment";
			this.lblPrintAlignment.Size = new System.Drawing.Size(53, 13);
			this.lblPrintAlignment.TabIndex = 31;
			this.lblPrintAlignment.Text = "Alignment";
			//
			//grpPageRange
			//
			this.grpPageRange.Controls.Add(this.txtPageRangeEnd);
			this.grpPageRange.Controls.Add(this.lblPageRangeTo);
			this.grpPageRange.Controls.Add(this.txtPageRangeStart);
			this.grpPageRange.Controls.Add(this.rbPageRangePages);
			this.grpPageRange.Controls.Add(this.rbPageRangeCurrent);
			this.grpPageRange.Controls.Add(this.rbPageRangeSelection);
			this.grpPageRange.Controls.Add(this.rbPageRangeAll);
			this.grpPageRange.Location = new System.Drawing.Point(234, 120);
			this.grpPageRange.Name = "grpPageRange";
			this.grpPageRange.Size = new System.Drawing.Size(288, 100);
			this.grpPageRange.TabIndex = 28;
			this.grpPageRange.TabStop = false;
			this.grpPageRange.Text = "Page range";
			//
			//rbPageRangeCurrent
			//
			this.rbPageRangeCurrent.AutoSize = true;
			this.rbPageRangeCurrent.Location = new System.Drawing.Point(149, 21);
			this.rbPageRangeCurrent.Name = "rbPageRangeCurrent";
			this.rbPageRangeCurrent.Size = new System.Drawing.Size(86, 17);
			this.rbPageRangeCurrent.TabIndex = 14;
			this.rbPageRangeCurrent.TabStop = true;
			this.rbPageRangeCurrent.Text = "Current page";
			this.rbPageRangeCurrent.UseVisualStyleBackColor = true;
			//
			//rbOrientationLandscape
			//
			this.rbOrientationLandscape.AutoSize = true;
			this.rbOrientationLandscape.Location = new System.Drawing.Point(13, 68);
			this.rbOrientationLandscape.Name = "rbOrientationLandscape";
			this.rbOrientationLandscape.Size = new System.Drawing.Size(78, 17);
			this.rbOrientationLandscape.TabIndex = 10;
			this.rbOrientationLandscape.Text = "Landscape";
			this.rbOrientationLandscape.UseVisualStyleBackColor = true;
			//
			//rbOrientationPortrait
			//
			this.rbOrientationPortrait.AutoSize = true;
			this.rbOrientationPortrait.Location = new System.Drawing.Point(13, 45);
			this.rbOrientationPortrait.Name = "rbOrientationPortrait";
			this.rbOrientationPortrait.Size = new System.Drawing.Size(58, 17);
			this.rbOrientationPortrait.TabIndex = 9;
			this.rbOrientationPortrait.Text = "Portrait";
			this.rbOrientationPortrait.UseVisualStyleBackColor = true;
			//
			//rbOrientationAutomatic
			//
			this.rbOrientationAutomatic.AutoSize = true;
			this.rbOrientationAutomatic.Checked = true;
			this.rbOrientationAutomatic.Location = new System.Drawing.Point(13, 22);
			this.rbOrientationAutomatic.Name = "rbOrientationAutomatic";
			this.rbOrientationAutomatic.Size = new System.Drawing.Size(72, 17);
			this.rbOrientationAutomatic.TabIndex = 8;
			this.rbOrientationAutomatic.TabStop = true;
			this.rbOrientationAutomatic.Text = "Automatic";
			this.rbOrientationAutomatic.UseVisualStyleBackColor = true;
			//
			//cmbPrintSize
			//
			this.cmbPrintSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPrintSize.FormattingEnabled = true;
			this.cmbPrintSize.Location = new System.Drawing.Point(138, 66);
			this.cmbPrintSize.Name = "cmbPrintSize";
			this.cmbPrintSize.Size = new System.Drawing.Size(198, 21);
			this.cmbPrintSize.TabIndex = 23;
			//
			//btnPrinterProperties
			//
			this.btnPrinterProperties.Location = new System.Drawing.Point(415, 11);
			this.btnPrinterProperties.Name = "btnPrinterProperties";
			this.btnPrinterProperties.Size = new System.Drawing.Size(107, 23);
			this.btnPrinterProperties.TabIndex = 21;
			this.btnPrinterProperties.Text = "Properties";
			this.btnPrinterProperties.UseVisualStyleBackColor = true;
			//
			//lblPrintSize
			//
			this.lblPrintSize.AutoSize = true;
			this.lblPrintSize.Location = new System.Drawing.Point(10, 69);
			this.lblPrintSize.Name = "lblPrintSize";
			this.lblPrintSize.Size = new System.Drawing.Size(49, 13);
			this.lblPrintSize.TabIndex = 29;
			this.lblPrintSize.Text = "Print size";
			//
			//cmbPrinterList
			//
			this.cmbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPrinterList.FormattingEnabled = true;
			this.cmbPrinterList.Location = new System.Drawing.Point(138, 12);
			this.cmbPrinterList.Name = "cmbPrinterList";
			this.cmbPrinterList.Size = new System.Drawing.Size(271, 21);
			this.cmbPrinterList.TabIndex = 20;
			//
			//lblCopies
			//
			this.lblCopies.AutoSize = true;
			this.lblCopies.Location = new System.Drawing.Point(10, 41);
			this.lblCopies.Name = "lblCopies";
			this.lblCopies.Size = new System.Drawing.Size(39, 13);
			this.lblCopies.TabIndex = 27;
			this.lblCopies.Text = "Copies";
			//
			//lblPrinter
			//
			this.lblPrinter.AutoSize = true;
			this.lblPrinter.Location = new System.Drawing.Point(10, 15);
			this.lblPrinter.Name = "lblPrinter";
			this.lblPrinter.Size = new System.Drawing.Size(37, 13);
			this.lblPrinter.TabIndex = 25;
			this.lblPrinter.Text = "Printer";
			//
			//btnCancel
			//
			this.btnCancel.Location = new System.Drawing.Point(447, 236);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 32;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//btnPrint
			//
			this.btnPrint.Location = new System.Drawing.Point(363, 236);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(74, 23);
			this.btnPrint.TabIndex = 30;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = true;
			//
			//grpOrientation
			//
			this.grpOrientation.Controls.Add(this.rbOrientationLandscape);
			this.grpOrientation.Controls.Add(this.rbOrientationPortrait);
			this.grpOrientation.Controls.Add(this.rbOrientationAutomatic);
			this.grpOrientation.Location = new System.Drawing.Point(13, 120);
			this.grpOrientation.Name = "grpOrientation";
			this.grpOrientation.Size = new System.Drawing.Size(200, 100);
			this.grpOrientation.TabIndex = 26;
			this.grpOrientation.TabStop = false;
			this.grpOrientation.Text = "Orientation";
			//
			//numCopies
			//
			this.numCopies.Location = new System.Drawing.Point(138, 39);
			this.numCopies.Name = "numCopies";
			this.numCopies.Size = new System.Drawing.Size(61, 20);
			this.numCopies.TabIndex = 33;
			this.numCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numCopies.Value = new decimal(new int[] {1, 0, 0, 0});
			//
			//frmPrint
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 273);
			this.Controls.Add(this.numCopies);
			this.Controls.Add(this.cmbPrintAlignment);
			this.Controls.Add(this.chkCollate);
			this.Controls.Add(this.lblPrintAlignment);
			this.Controls.Add(this.grpPageRange);
			this.Controls.Add(this.cmbPrintSize);
			this.Controls.Add(this.btnPrinterProperties);
			this.Controls.Add(this.lblPrintSize);
			this.Controls.Add(this.cmbPrinterList);
			this.Controls.Add(this.lblCopies);
			this.Controls.Add(this.lblPrinter);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.grpOrientation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPrint";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Print";
			this.grpPageRange.ResumeLayout(false);
			this.grpPageRange.PerformLayout();
			this.grpOrientation.ResumeLayout(false);
			this.grpOrientation.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.numCopies).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.ComboBox cmbPrintAlignment;
		internal System.Windows.Forms.CheckBox chkCollate;
		internal System.Windows.Forms.RadioButton rbPageRangeSelection;
		internal System.Windows.Forms.RadioButton rbPageRangeAll;
		internal System.Windows.Forms.TextBox txtPageRangeEnd;
		internal System.Windows.Forms.Label lblPageRangeTo;
		internal System.Windows.Forms.TextBox txtPageRangeStart;
		internal System.Windows.Forms.RadioButton rbPageRangePages;
		internal System.Windows.Forms.Label lblPrintAlignment;
		internal System.Windows.Forms.GroupBox grpPageRange;
		internal System.Windows.Forms.RadioButton rbPageRangeCurrent;
		internal System.Windows.Forms.RadioButton rbOrientationLandscape;
		internal System.Windows.Forms.RadioButton rbOrientationPortrait;
		internal System.Windows.Forms.RadioButton rbOrientationAutomatic;
		internal System.Windows.Forms.ComboBox cmbPrintSize;
		internal System.Windows.Forms.Button btnPrinterProperties;
		internal System.Windows.Forms.Label lblPrintSize;
		internal System.Windows.Forms.ComboBox cmbPrinterList;
		internal System.Windows.Forms.Label lblCopies;
		internal System.Windows.Forms.Label lblPrinter;
		internal System.Windows.Forms.Button btnCancel;
		internal System.Windows.Forms.Button btnPrint;
		internal System.Windows.Forms.GroupBox grpOrientation;
		internal System.Windows.Forms.NumericUpDown numCopies;
	}
	
}
