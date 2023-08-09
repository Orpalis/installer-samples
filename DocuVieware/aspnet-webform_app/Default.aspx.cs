using GdPicture14.WEB;
using System;

namespace DocuVieware_webform_app_demo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dvVersion.Text = DocuViewareManager.GetVersion();
        }
    }
}