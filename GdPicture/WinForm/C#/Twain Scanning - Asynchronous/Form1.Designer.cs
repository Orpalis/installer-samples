using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;



namespace async_scanning
{
	public partial class Form1 : System.Windows.Forms.Form
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
            this.Button1 = new System.Windows.Forms.Button();
            this.chkUseFeeder = new System.Windows.Forms.CheckBox();
            this.chkGenLog = new System.Windows.Forms.CheckBox();
            this.chkEnableIndicator = new System.Windows.Forms.CheckBox();
            this.chkHideGUI = new System.Windows.Forms.CheckBox();
            this.chkDuplex = new System.Windows.Forms.CheckBox();
            this.chkTwain19 = new System.Windows.Forms.CheckBox();
            this.chkModalUI = new System.Windows.Forms.CheckBox();
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMemTransfer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 35);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(495, 111);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Asynchronous acquisition";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // chkUseFeeder
            // 
            this.chkUseFeeder.AutoSize = true;
            this.chkUseFeeder.Location = new System.Drawing.Point(181, 199);
            this.chkUseFeeder.Name = "chkUseFeeder";
            this.chkUseFeeder.Size = new System.Drawing.Size(107, 17);
            this.chkUseFeeder.TabIndex = 1;
            this.chkUseFeeder.Text = "Scan from feeder";
            this.chkUseFeeder.UseVisualStyleBackColor = true;
            // 
            // chkGenLog
            // 
            this.chkGenLog.AutoSize = true;
            this.chkGenLog.Location = new System.Drawing.Point(12, 12);
            this.chkGenLog.Name = "chkGenLog";
            this.chkGenLog.Size = new System.Drawing.Size(95, 17);
            this.chkGenLog.TabIndex = 2;
            this.chkGenLog.Text = "Generate LOG";
            this.chkGenLog.UseVisualStyleBackColor = true;
            // 
            // chkEnableIndicator
            // 
            this.chkEnableIndicator.AutoSize = true;
            this.chkEnableIndicator.Location = new System.Drawing.Point(12, 245);
            this.chkEnableIndicator.Name = "chkEnableIndicator";
            this.chkEnableIndicator.Size = new System.Drawing.Size(103, 17);
            this.chkEnableIndicator.TabIndex = 3;
            this.chkEnableIndicator.Text = "Enable Indicator";
            this.chkEnableIndicator.UseVisualStyleBackColor = true;
            // 
            // chkHideGUI
            // 
            this.chkHideGUI.AutoSize = true;
            this.chkHideGUI.Location = new System.Drawing.Point(12, 222);
            this.chkHideGUI.Name = "chkHideGUI";
            this.chkHideGUI.Size = new System.Drawing.Size(105, 17);
            this.chkHideGUI.TabIndex = 4;
            this.chkHideGUI.Text = "Hide device GUI";
            this.chkHideGUI.UseVisualStyleBackColor = true;
            // 
            // chkDuplex
            // 
            this.chkDuplex.AutoSize = true;
            this.chkDuplex.Location = new System.Drawing.Point(181, 222);
            this.chkDuplex.Name = "chkDuplex";
            this.chkDuplex.Size = new System.Drawing.Size(59, 17);
            this.chkDuplex.TabIndex = 5;
            this.chkDuplex.Text = "Duplex";
            this.chkDuplex.UseVisualStyleBackColor = true;
            // 
            // chkTwain19
            // 
            this.chkTwain19.AutoSize = true;
            this.chkTwain19.Location = new System.Drawing.Point(113, 12);
            this.chkTwain19.Name = "chkTwain19";
            this.chkTwain19.Size = new System.Drawing.Size(110, 17);
            this.chkTwain19.TabIndex = 7;
            this.chkTwain19.Text = "Force TWAIN 1.9";
            this.chkTwain19.UseVisualStyleBackColor = true;
            // 
            // chkModalUI
            // 
            this.chkModalUI.AutoSize = true;
            this.chkModalUI.Checked = true;
            this.chkModalUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModalUI.Location = new System.Drawing.Point(12, 199);
            this.chkModalUI.Name = "chkModalUI";
            this.chkModalUI.Size = new System.Drawing.Size(69, 17);
            this.chkModalUI.TabIndex = 8;
            this.chkModalUI.Text = "Modal UI";
            this.chkModalUI.UseVisualStyleBackColor = true;
            // 
            // txtWorkingDir
            // 
            this.txtWorkingDir.Location = new System.Drawing.Point(111, 156);
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.txtWorkingDir.Size = new System.Drawing.Size(396, 20);
            this.txtWorkingDir.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Working directory:";
            // 
            // chkMemTransfer
            // 
            this.chkMemTransfer.AutoSize = true;
            this.chkMemTransfer.Checked = true;
            this.chkMemTransfer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMemTransfer.Location = new System.Drawing.Point(181, 245);
            this.chkMemTransfer.Name = "chkMemTransfer";
            this.chkMemTransfer.Size = new System.Drawing.Size(159, 17);
            this.chkMemTransfer.TabIndex = 11;
            this.chkMemTransfer.Text = "Favor memory transfer mode";
            this.chkMemTransfer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 274);
            this.Controls.Add(this.chkMemTransfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWorkingDir);
            this.Controls.Add(this.chkModalUI);
            this.Controls.Add(this.chkTwain19);
            this.Controls.Add(this.chkDuplex);
            this.Controls.Add(this.chkHideGUI);
            this.Controls.Add(this.chkEnableIndicator);
            this.Controls.Add(this.chkGenLog);
            this.Controls.Add(this.chkUseFeeder);
            this.Controls.Add(this.Button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GdPicture.NET - Asynchronous TWAIN Scanning Demo  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.CheckBox chkUseFeeder;
		internal System.Windows.Forms.CheckBox chkGenLog;
		internal System.Windows.Forms.CheckBox chkEnableIndicator;
		internal System.Windows.Forms.CheckBox chkHideGUI;
		internal System.Windows.Forms.CheckBox chkDuplex;
		internal System.Windows.Forms.CheckBox chkTwain19;
		internal System.Windows.Forms.CheckBox chkModalUI;
        private TextBox txtWorkingDir;
        private Label label1;
        internal CheckBox chkMemTransfer;
    }
	
}
