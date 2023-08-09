
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;



namespace Image_Processing
{
	
	partial class frmOpen : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpen));
			this.pOpenFromFile = new System.Windows.Forms.Panel();
			base.Load += new System.EventHandler(frmOpen_Load);
			this.btOpenFromFile = new System.Windows.Forms.Button();
			this.btOpenFromFile.Click += new System.EventHandler(this.btOpenFromFile_Click);
			this.tbFile = new System.Windows.Forms.TextBox();
			this.rbOpenFromFile = new System.Windows.Forms.RadioButton();
			this.rbOpenFromFile.CheckedChanged += new System.EventHandler(this.rbOpenFromFile_CheckedChanged);
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.rbOpenFromHTTP = new System.Windows.Forms.RadioButton();
			this.rbOpenFromHTTP.CheckedChanged += new System.EventHandler(this.rbOpenFromHTTP_CheckedChanged);
			this.pOpenFromHTTP = new System.Windows.Forms.Panel();
			this.tbOpenFromHTTP = new System.Windows.Forms.TextBox();
			this.rbOpenFromFTP = new System.Windows.Forms.RadioButton();
			this.rbOpenFromFTP.CheckedChanged += new System.EventHandler(this.rbOpenFromFTP_CheckedChanged);
			this.pOpenFromFTP = new System.Windows.Forms.Panel();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.lblLogin = new System.Windows.Forms.Label();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.lblPath = new System.Windows.Forms.Label();
			this.tbPort = new System.Windows.Forms.TextBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.tbHost = new System.Windows.Forms.TextBox();
			this.lblHost = new System.Windows.Forms.Label();
			this.rbOpenFromClipboard = new System.Windows.Forms.RadioButton();
			this.rbOpenFromClipboard.CheckedChanged += new System.EventHandler(this.rbOpenFromClipboard_CheckedChanged);
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.PictureBox3 = new System.Windows.Forms.PictureBox();
			this.PictureBox4 = new System.Windows.Forms.PictureBox();
			this.pOpenFromFile.SuspendLayout();
			this.pOpenFromHTTP.SuspendLayout();
			this.pOpenFromFTP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).BeginInit();
			this.SuspendLayout();
			//
			//pOpenFromFile
			//
			this.pOpenFromFile.AutoSize = true;
			this.pOpenFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pOpenFromFile.Controls.Add(this.btOpenFromFile);
			this.pOpenFromFile.Controls.Add(this.tbFile);
			this.pOpenFromFile.Location = new System.Drawing.Point(13, 36);
			this.pOpenFromFile.Name = "pOpenFromFile";
			this.pOpenFromFile.Size = new System.Drawing.Size(475, 27);
			this.pOpenFromFile.TabIndex = 0;
			//
			//btOpenFromFile
			//
			this.btOpenFromFile.Location = new System.Drawing.Point(397, 1);
			this.btOpenFromFile.Name = "btOpenFromFile";
			this.btOpenFromFile.Size = new System.Drawing.Size(75, 23);
			this.btOpenFromFile.TabIndex = 1;
			this.btOpenFromFile.Text = "Browse...";
			this.btOpenFromFile.UseVisualStyleBackColor = true;
			//
			//tbFile
			//
			this.tbFile.Location = new System.Drawing.Point(3, 3);
			this.tbFile.Name = "tbFile";
			this.tbFile.ReadOnly = true;
			this.tbFile.Size = new System.Drawing.Size(388, 20);
			this.tbFile.TabIndex = 0;
			//
			//rbOpenFromFile
			//
			this.rbOpenFromFile.AutoSize = true;
			this.rbOpenFromFile.Location = new System.Drawing.Point(42, 13);
			this.rbOpenFromFile.Name = "rbOpenFromFile";
			this.rbOpenFromFile.Size = new System.Drawing.Size(90, 17);
			this.rbOpenFromFile.TabIndex = 1;
			this.rbOpenFromFile.TabStop = true;
			this.rbOpenFromFile.Text = "Open from file";
			this.rbOpenFromFile.UseVisualStyleBackColor = true;
			//
			//rbOpenFromHTTP
			//
			this.rbOpenFromHTTP.AutoSize = true;
			this.rbOpenFromHTTP.Location = new System.Drawing.Point(42, 80);
			this.rbOpenFromHTTP.Name = "rbOpenFromHTTP";
			this.rbOpenFromHTTP.Size = new System.Drawing.Size(106, 17);
			this.rbOpenFromHTTP.TabIndex = 2;
			this.rbOpenFromHTTP.TabStop = true;
			this.rbOpenFromHTTP.Text = "Open from HTTP";
			this.rbOpenFromHTTP.UseVisualStyleBackColor = true;
			//
			//pOpenFromHTTP
			//
			this.pOpenFromHTTP.AutoSize = true;
			this.pOpenFromHTTP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pOpenFromHTTP.Controls.Add(this.tbOpenFromHTTP);
			this.pOpenFromHTTP.Location = new System.Drawing.Point(16, 108);
			this.pOpenFromHTTP.Name = "pOpenFromHTTP";
			this.pOpenFromHTTP.Size = new System.Drawing.Size(471, 23);
			this.pOpenFromHTTP.TabIndex = 3;
			//
			//tbOpenFromHTTP
			//
			this.tbOpenFromHTTP.Location = new System.Drawing.Point(0, 0);
			this.tbOpenFromHTTP.Name = "tbOpenFromHTTP";
			this.tbOpenFromHTTP.Size = new System.Drawing.Size(468, 20);
			this.tbOpenFromHTTP.TabIndex = 0;
			this.tbOpenFromHTTP.Text = "http://nssdcftp.gsfc.nasa.gov/photo_gallery/hi-res/planetary/jupiter/hst_jupiter_" + 
				"9929a1.tiff";
			//
			//rbOpenFromFTP
			//
			this.rbOpenFromFTP.AutoSize = true;
			this.rbOpenFromFTP.Location = new System.Drawing.Point(42, 146);
			this.rbOpenFromFTP.Name = "rbOpenFromFTP";
			this.rbOpenFromFTP.Size = new System.Drawing.Size(97, 17);
			this.rbOpenFromFTP.TabIndex = 4;
			this.rbOpenFromFTP.TabStop = true;
			this.rbOpenFromFTP.Text = "Open from FTP";
			this.rbOpenFromFTP.UseVisualStyleBackColor = true;
			//
			//pOpenFromFTP
			//
			this.pOpenFromFTP.AutoSize = true;
			this.pOpenFromFTP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pOpenFromFTP.Controls.Add(this.tbPassword);
			this.pOpenFromFTP.Controls.Add(this.lblPassword);
			this.pOpenFromFTP.Controls.Add(this.tbLogin);
			this.pOpenFromFTP.Controls.Add(this.lblLogin);
			this.pOpenFromFTP.Controls.Add(this.tbPath);
			this.pOpenFromFTP.Controls.Add(this.lblPath);
			this.pOpenFromFTP.Controls.Add(this.tbPort);
			this.pOpenFromFTP.Controls.Add(this.lblPort);
			this.pOpenFromFTP.Controls.Add(this.tbHost);
			this.pOpenFromFTP.Controls.Add(this.lblHost);
			this.pOpenFromFTP.Location = new System.Drawing.Point(13, 169);
			this.pOpenFromFTP.Name = "pOpenFromFTP";
			this.pOpenFromFTP.Size = new System.Drawing.Size(475, 79);
			this.pOpenFromFTP.TabIndex = 5;
			//
			//tbPassword
			//
			this.tbPassword.Location = new System.Drawing.Point(294, 56);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = (char)42;
			this.tbPassword.Size = new System.Drawing.Size(178, 20);
			this.tbPassword.TabIndex = 9;
			this.tbPassword.Text = "Anonymous";
			//
			//lblPassword
			//
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(235, 59);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 8;
			this.lblPassword.Text = "Password";
			//
			//tbLogin
			//
			this.tbLogin.Location = new System.Drawing.Point(39, 56);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(178, 20);
			this.tbLogin.TabIndex = 7;
			this.tbLogin.Text = "Anonymous";
			//
			//lblLogin
			//
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(4, 59);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(33, 13);
			this.lblLogin.TabIndex = 6;
			this.lblLogin.Text = "Login";
			//
			//tbPath
			//
			this.tbPath.Location = new System.Drawing.Point(39, 30);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(433, 20);
			this.tbPath.TabIndex = 5;
			this.tbPath.Text = "/design/processor/datashts/325567.pdf";
			//
			//lblPath
			//
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(4, 33);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(29, 13);
			this.lblPath.TabIndex = 4;
			this.lblPath.Text = "Path";
			//
			//tbPort
			//
			this.tbPort.Location = new System.Drawing.Point(419, 3);
			this.tbPort.Name = "tbPort";
			this.tbPort.Size = new System.Drawing.Size(53, 20);
			this.tbPort.TabIndex = 3;
			this.tbPort.Text = "21";
			this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//lblPort
			//
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(387, 7);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(26, 13);
			this.lblPort.TabIndex = 2;
			this.lblPort.Text = "Port";
			//
			//tbHost
			//
			this.tbHost.Location = new System.Drawing.Point(39, 4);
			this.tbHost.Name = "tbHost";
			this.tbHost.Size = new System.Drawing.Size(342, 20);
			this.tbHost.TabIndex = 1;
			this.tbHost.Text = "ftp://download.intel.com";
			//
			//lblHost
			//
			this.lblHost.AutoSize = true;
			this.lblHost.Location = new System.Drawing.Point(3, 7);
			this.lblHost.Name = "lblHost";
			this.lblHost.Size = new System.Drawing.Size(29, 13);
			this.lblHost.TabIndex = 0;
			this.lblHost.Text = "Host";
			//
			//rbOpenFromClipboard
			//
			this.rbOpenFromClipboard.AutoSize = true;
			this.rbOpenFromClipboard.Location = new System.Drawing.Point(42, 269);
			this.rbOpenFromClipboard.Name = "rbOpenFromClipboard";
			this.rbOpenFromClipboard.Size = new System.Drawing.Size(120, 17);
			this.rbOpenFromClipboard.TabIndex = 6;
			this.rbOpenFromClipboard.TabStop = true;
			this.rbOpenFromClipboard.Text = "Open from clipboard";
			this.rbOpenFromClipboard.UseVisualStyleBackColor = true;
			//
			//btnCancel
			//
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(413, 293);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 34;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//btnOpen
			//
			this.btnOpen.Location = new System.Drawing.Point(333, 293);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(74, 23);
			this.btnOpen.TabIndex = 33;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			//
			//PictureBox1
			//
			this.PictureBox1.Image = (System.Drawing.Image) (resources.GetObject("PictureBox1.Image"));
			this.PictureBox1.Location = new System.Drawing.Point(16, 10);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(20, 20);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 35;
			this.PictureBox1.TabStop = false;
			//
			//PictureBox2
			//
			this.PictureBox2.Image = (System.Drawing.Image) (resources.GetObject("PictureBox2.Image"));
			this.PictureBox2.Location = new System.Drawing.Point(16, 77);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(20, 20);
			this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox2.TabIndex = 36;
			this.PictureBox2.TabStop = false;
			//
			//PictureBox3
			//
			this.PictureBox3.Image = (System.Drawing.Image) (resources.GetObject("PictureBox3.Image"));
			this.PictureBox3.Location = new System.Drawing.Point(16, 143);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new System.Drawing.Size(20, 20);
			this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox3.TabIndex = 37;
			this.PictureBox3.TabStop = false;
			//
			//PictureBox4
			//
			this.PictureBox4.Image = (System.Drawing.Image) (resources.GetObject("PictureBox4.Image"));
			this.PictureBox4.Location = new System.Drawing.Point(16, 266);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new System.Drawing.Size(20, 20);
			this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox4.TabIndex = 38;
			this.PictureBox4.TabStop = false;
			//
			//frmOpen
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(503, 331);
			this.Controls.Add(this.PictureBox4);
			this.Controls.Add(this.PictureBox3);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.rbOpenFromClipboard);
			this.Controls.Add(this.pOpenFromFTP);
			this.Controls.Add(this.rbOpenFromFTP);
			this.Controls.Add(this.pOpenFromHTTP);
			this.Controls.Add(this.rbOpenFromHTTP);
			this.Controls.Add(this.rbOpenFromFile);
			this.Controls.Add(this.pOpenFromFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmOpen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Open";
			this.pOpenFromFile.ResumeLayout(false);
			this.pOpenFromFile.PerformLayout();
			this.pOpenFromHTTP.ResumeLayout(false);
			this.pOpenFromHTTP.PerformLayout();
			this.pOpenFromFTP.ResumeLayout(false);
			this.pOpenFromFTP.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Panel pOpenFromFile;
		internal System.Windows.Forms.Button btOpenFromFile;
		internal System.Windows.Forms.TextBox tbFile;
		internal System.Windows.Forms.RadioButton rbOpenFromFile;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.RadioButton rbOpenFromHTTP;
		internal System.Windows.Forms.Panel pOpenFromHTTP;
		internal System.Windows.Forms.TextBox tbOpenFromHTTP;
		internal System.Windows.Forms.RadioButton rbOpenFromFTP;
		internal System.Windows.Forms.Panel pOpenFromFTP;
		internal System.Windows.Forms.TextBox tbPort;
		internal System.Windows.Forms.Label lblPort;
		internal System.Windows.Forms.TextBox tbHost;
		internal System.Windows.Forms.Label lblHost;
		internal System.Windows.Forms.TextBox tbPath;
		internal System.Windows.Forms.Label lblPath;
		internal System.Windows.Forms.TextBox tbLogin;
		internal System.Windows.Forms.Label lblLogin;
		internal System.Windows.Forms.TextBox tbPassword;
		internal System.Windows.Forms.Label lblPassword;
		internal System.Windows.Forms.RadioButton rbOpenFromClipboard;
		internal System.Windows.Forms.Button btnCancel;
		internal System.Windows.Forms.Button btnOpen;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.PictureBox PictureBox3;
		internal System.Windows.Forms.PictureBox PictureBox4;
	}
	
}
