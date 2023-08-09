using System;
using GdPicture14.WEB;

namespace DocuVieware_webform_app_demo
{
    public partial class diags : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "Version: " +  DocuViewareManager.GetVersion()  + '\n'+ "Session count: " + DocuViewareManager.GetSessionCount();
        }
    }
}