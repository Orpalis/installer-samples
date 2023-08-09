using GdPicture14.WEB;
using System;

namespace DocuVieware_webform_app_demo
{
    public partial class CustomToolbarDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DocuVieware1.Timeout = Global.SESSION_TIMEOUT;

            dvVersion.Text = DocuViewareManager.GetVersion();
        }
    }
}