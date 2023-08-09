using System;
using System.Windows.Forms;

namespace Document_Viewer
{
	public partial class frmAbout
	{
		public frmAbout()
		{
			InitializeComponent();
		}

	    private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	    private void lblGdPictureWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.gdpicture.com/");
		}
	}
}
