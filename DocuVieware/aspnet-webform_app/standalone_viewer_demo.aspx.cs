using System;

namespace DocuVieware_webform_app_demo
{
    public partial class StandaloneViewerDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DocuVieware1.Timeout = Global.SESSION_TIMEOUT;

            if (!IsPostBack)
            {
                string src = Request.QueryString["src"];
                if (src != null)
                {
                    if (Uri.IsWellFormedUriString(src, UriKind.Absolute))
                    {
                        DocuVieware1.LoadFromURI(new Uri(src));
                    }
                }
            }
        }
    }
}