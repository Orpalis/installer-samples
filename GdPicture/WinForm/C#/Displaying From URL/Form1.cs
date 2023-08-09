// TRANSINFO: Option Strict On
// TRANSINFO: Option Explicit On

using GdPicture14;
using System.Windows.Forms;

namespace Displaying_From_URL
{
    internal partial class Form1 : System.Windows.Forms.Form
    {
        private void Form1_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
        }


        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.DisplayFromHTTP(this.TextBox1.Text, this.TextBox2.Text, 80);
            if (GdViewer1.GetStat() != GdPictureStatus.OK)
            {
                MessageBox.Show(GdViewer1.GetStat().ToString(), "Image could not be displayed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
