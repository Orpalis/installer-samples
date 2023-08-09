
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;



namespace Image_Processing
{
	
	partial class frmSettings : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnableDeferredPainting = new System.Windows.Forms.CheckBox();
            this.chkIgnoreDocumentResolution = new System.Windows.Forms.CheckBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPageDisplayMode = new System.Windows.Forms.ComboBox();
            this.txtZoomStep = new System.Windows.Forms.NumericUpDown();
            this.cbMouseWheelMode = new System.Windows.Forms.ComboBox();
            this.cbDocumentPosition = new System.Windows.Forms.ComboBox();
            this.cbDocumentAlignment = new System.Windows.Forms.ComboBox();
            this.chkEnableMenu = new System.Windows.Forms.CheckBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbDisplayQuality = new System.Windows.Forms.ComboBox();
            this.chkContinuousViewMode = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.chkHQAnnotationsRendering = new System.Windows.Forms.CheckBox();
            this.chkAnnotationsDropShadow = new System.Windows.Forms.CheckBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.chkEnableICM = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoomStep)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.chkEnableDeferredPainting);
            this.GroupBox1.Controls.Add(this.chkIgnoreDocumentResolution);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.cbPageDisplayMode);
            this.GroupBox1.Controls.Add(this.txtZoomStep);
            this.GroupBox1.Controls.Add(this.cbMouseWheelMode);
            this.GroupBox1.Controls.Add(this.cbDocumentPosition);
            this.GroupBox1.Controls.Add(this.cbDocumentAlignment);
            this.GroupBox1.Controls.Add(this.chkEnableMenu);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cbDisplayQuality);
            this.GroupBox1.Controls.Add(this.chkContinuousViewMode);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(18, 18);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(436, 455);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "General options";
            // 
            // chkEnableDeferredPainting
            // 
            this.chkEnableDeferredPainting.AutoSize = true;
            this.chkEnableDeferredPainting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEnableDeferredPainting.Location = new System.Drawing.Point(9, 418);
            this.chkEnableDeferredPainting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEnableDeferredPainting.Name = "chkEnableDeferredPainting";
            this.chkEnableDeferredPainting.Size = new System.Drawing.Size(209, 24);
            this.chkEnableDeferredPainting.TabIndex = 9;
            this.chkEnableDeferredPainting.Text = "Enable deferred painting";
            this.chkEnableDeferredPainting.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreDocumentResolution
            // 
            this.chkIgnoreDocumentResolution.AutoSize = true;
            this.chkIgnoreDocumentResolution.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIgnoreDocumentResolution.Location = new System.Drawing.Point(9, 382);
            this.chkIgnoreDocumentResolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIgnoreDocumentResolution.Name = "chkIgnoreDocumentResolution";
            this.chkIgnoreDocumentResolution.Size = new System.Drawing.Size(229, 24);
            this.chkIgnoreDocumentResolution.TabIndex = 8;
            this.chkIgnoreDocumentResolution.Text = "Ignore document resolution";
            this.chkIgnoreDocumentResolution.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(9, 147);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(104, 20);
            this.Label8.TabIndex = 22;
            this.Label8.Text = "Display mode";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(174, 305);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(30, 31);
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // cbPageDisplayMode
            // 
            this.cbPageDisplayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPageDisplayMode.FormattingEnabled = true;
            this.cbPageDisplayMode.Location = new System.Drawing.Point(174, 143);
            this.cbPageDisplayMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPageDisplayMode.Name = "cbPageDisplayMode";
            this.cbPageDisplayMode.Size = new System.Drawing.Size(193, 28);
            this.cbPageDisplayMode.TabIndex = 3;
            // 
            // txtZoomStep
            // 
            this.txtZoomStep.Location = new System.Drawing.Point(104, 28);
            this.txtZoomStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZoomStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtZoomStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtZoomStep.Name = "txtZoomStep";
            this.txtZoomStep.Size = new System.Drawing.Size(118, 26);
            this.txtZoomStep.TabIndex = 0;
            this.txtZoomStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMouseWheelMode
            // 
            this.cbMouseWheelMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMouseWheelMode.FormattingEnabled = true;
            this.cbMouseWheelMode.Location = new System.Drawing.Point(174, 263);
            this.cbMouseWheelMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMouseWheelMode.Name = "cbMouseWheelMode";
            this.cbMouseWheelMode.Size = new System.Drawing.Size(158, 28);
            this.cbMouseWheelMode.TabIndex = 6;
            // 
            // cbDocumentPosition
            // 
            this.cbDocumentPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentPosition.FormattingEnabled = true;
            this.cbDocumentPosition.Location = new System.Drawing.Point(174, 223);
            this.cbDocumentPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDocumentPosition.Name = "cbDocumentPosition";
            this.cbDocumentPosition.Size = new System.Drawing.Size(158, 28);
            this.cbDocumentPosition.TabIndex = 5;
            // 
            // cbDocumentAlignment
            // 
            this.cbDocumentAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentAlignment.FormattingEnabled = true;
            this.cbDocumentAlignment.Location = new System.Drawing.Point(174, 183);
            this.cbDocumentAlignment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDocumentAlignment.Name = "cbDocumentAlignment";
            this.cbDocumentAlignment.Size = new System.Drawing.Size(158, 28);
            this.cbDocumentAlignment.TabIndex = 4;
            // 
            // chkEnableMenu
            // 
            this.chkEnableMenu.AutoSize = true;
            this.chkEnableMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEnableMenu.Location = new System.Drawing.Point(9, 346);
            this.chkEnableMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEnableMenu.Name = "chkEnableMenu";
            this.chkEnableMenu.Size = new System.Drawing.Size(206, 24);
            this.chkEnableMenu.TabIndex = 7;
            this.chkEnableMenu.Text = "Enable contextual menu";
            this.chkEnableMenu.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 311);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(133, 20);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Background color";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 267);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(146, 20);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Mouse wheel mode";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 227);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(142, 20);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Document position";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 187);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(156, 20);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Document alignment";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 107);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 20);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Display quality";
            // 
            // cbDisplayQuality
            // 
            this.cbDisplayQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisplayQuality.FormattingEnabled = true;
            this.cbDisplayQuality.Location = new System.Drawing.Point(174, 103);
            this.cbDisplayQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDisplayQuality.Name = "cbDisplayQuality";
            this.cbDisplayQuality.Size = new System.Drawing.Size(158, 28);
            this.cbDisplayQuality.TabIndex = 2;
            // 
            // chkContinuousViewMode
            // 
            this.chkContinuousViewMode.AutoSize = true;
            this.chkContinuousViewMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkContinuousViewMode.Location = new System.Drawing.Point(9, 65);
            this.chkContinuousViewMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkContinuousViewMode.Name = "chkContinuousViewMode";
            this.chkContinuousViewMode.Size = new System.Drawing.Size(194, 24);
            this.chkContinuousViewMode.TabIndex = 1;
            this.chkContinuousViewMode.Text = "Continuous view mode";
            this.chkContinuousViewMode.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 31);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Zoom step";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(788, 483);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(112, 35);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.chkHQAnnotationsRendering);
            this.GroupBox2.Controls.Add(this.chkAnnotationsDropShadow);
            this.GroupBox2.Location = new System.Drawing.Point(464, 18);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(436, 128);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Annotations options";
            // 
            // chkHQAnnotationsRendering
            // 
            this.chkHQAnnotationsRendering.AutoSize = true;
            this.chkHQAnnotationsRendering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHQAnnotationsRendering.Location = new System.Drawing.Point(9, 65);
            this.chkHQAnnotationsRendering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHQAnnotationsRendering.Name = "chkHQAnnotationsRendering";
            this.chkHQAnnotationsRendering.Size = new System.Drawing.Size(218, 24);
            this.chkHQAnnotationsRendering.TabIndex = 1;
            this.chkHQAnnotationsRendering.Text = "HQ annotations rendering";
            this.chkHQAnnotationsRendering.UseVisualStyleBackColor = true;
            // 
            // chkAnnotationsDropShadow
            // 
            this.chkAnnotationsDropShadow.AutoSize = true;
            this.chkAnnotationsDropShadow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnotationsDropShadow.Location = new System.Drawing.Point(9, 29);
            this.chkAnnotationsDropShadow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAnnotationsDropShadow.Name = "chkAnnotationsDropShadow";
            this.chkAnnotationsDropShadow.Size = new System.Drawing.Size(216, 24);
            this.chkAnnotationsDropShadow.TabIndex = 0;
            this.chkAnnotationsDropShadow.Text = "Annotations drop shadow";
            this.chkAnnotationsDropShadow.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.chkEnableICM);
            this.GroupBox3.Location = new System.Drawing.Point(18, 483);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Size = new System.Drawing.Size(436, 71);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Image viewing options";
            // 
            // chkEnableICM
            // 
            this.chkEnableICM.AutoSize = true;
            this.chkEnableICM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEnableICM.Location = new System.Drawing.Point(9, 29);
            this.chkEnableICM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEnableICM.Name = "chkEnableICM";
            this.chkEnableICM.Size = new System.Drawing.Size(118, 24);
            this.chkEnableICM.TabIndex = 0;
            this.chkEnableICM.Text = "Enable ICM";
            this.chkEnableICM.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 569);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnApply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Viewer settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoomStep)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.CheckBox chkEnableMenu;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox cbDisplayQuality;
		internal System.Windows.Forms.CheckBox chkContinuousViewMode;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.NumericUpDown txtZoomStep;
		internal System.Windows.Forms.ComboBox cbMouseWheelMode;
		internal System.Windows.Forms.ComboBox cbDocumentPosition;
		internal System.Windows.Forms.ComboBox cbDocumentAlignment;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Button btnApply;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.CheckBox chkHQAnnotationsRendering;
		internal System.Windows.Forms.CheckBox chkAnnotationsDropShadow;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.CheckBox chkEnableICM;
		internal System.Windows.Forms.CheckBox chkIgnoreDocumentResolution;
        internal CheckBox chkEnableDeferredPainting;
        internal Label Label8;
        internal ComboBox cbPageDisplayMode;
    }
	
}
