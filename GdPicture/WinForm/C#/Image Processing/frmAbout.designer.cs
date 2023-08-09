using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;


namespace Image_Processing
{
	partial class frmAbout : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCopyrightORPALIS = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lblDemoName = new System.Windows.Forms.Label();
            this.lblGdPictureDemo = new System.Windows.Forms.Label();
            this.lblGdPictureWebsite = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(664, 283);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCopyrightORPALIS
            // 
            this.lblCopyrightORPALIS.AutoSize = true;
            this.lblCopyrightORPALIS.Enabled = false;
            this.lblCopyrightORPALIS.Location = new System.Drawing.Point(11, 289);
            this.lblCopyrightORPALIS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyrightORPALIS.Name = "lblCopyrightORPALIS";
            this.lblCopyrightORPALIS.Size = new System.Drawing.Size(181, 17);
            this.lblCopyrightORPALIS.TabIndex = 1;
            this.lblCopyrightORPALIS.Text = "Copyright © 2018 ORPALIS";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(780, 191);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(780, 191);
            this.Panel1.TabIndex = 3;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.Panel2.Controls.Add(this.lblDemoName);
            this.Panel2.Controls.Add(this.lblGdPictureDemo);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 191);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(780, 80);
            this.Panel2.TabIndex = 4;
            // 
            // lblDemoName
            // 
            this.lblDemoName.AutoSize = true;
            this.lblDemoName.Location = new System.Drawing.Point(27, 39);
            this.lblDemoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDemoName.Name = "lblDemoName";
            this.lblDemoName.Size = new System.Drawing.Size(212, 17);
            this.lblDemoName.TabIndex = 1;
            this.lblDemoName.Text = ".NET Winform Image Processing";
            // 
            // lblGdPictureDemo
            // 
            this.lblGdPictureDemo.AutoSize = true;
            this.lblGdPictureDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGdPictureDemo.Location = new System.Drawing.Point(13, 14);
            this.lblGdPictureDemo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGdPictureDemo.Name = "lblGdPictureDemo";
            this.lblGdPictureDemo.Size = new System.Drawing.Size(247, 17);
            this.lblGdPictureDemo.TabIndex = 0;
            this.lblGdPictureDemo.Text = "GdPicture.NET Application Demo";
            // 
            // lblGdPictureWebsite
            // 
            this.lblGdPictureWebsite.AutoSize = true;
            this.lblGdPictureWebsite.Location = new System.Drawing.Point(204, 289);
            this.lblGdPictureWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGdPictureWebsite.Name = "lblGdPictureWebsite";
            this.lblGdPictureWebsite.Size = new System.Drawing.Size(168, 17);
            this.lblGdPictureWebsite.TabIndex = 6;
            this.lblGdPictureWebsite.TabStop = true;
            this.lblGdPictureWebsite.Text = "http://www.gdpicture.com/";
            this.lblGdPictureWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGdPictureWebsite_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 326);
            this.Controls.Add(this.lblGdPictureWebsite);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.lblCopyrightORPALIS);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Label lblCopyrightORPALIS;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label lblDemoName;
		internal System.Windows.Forms.Label lblGdPictureDemo;
		internal System.Windows.Forms.LinkLabel lblGdPictureWebsite;
	}
	
}
