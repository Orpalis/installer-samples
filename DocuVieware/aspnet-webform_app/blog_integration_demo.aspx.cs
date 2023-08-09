using GdPicture14.WEB;
using System;

namespace DocuVieware_webform_app_demo
{
    public partial class BlogIntegrationDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DocuVieware1.Timeout = Global.SESSION_TIMEOUT;

            if (!IsPostBack)
            {
                DocuVieware1.LoadFromURI(new Uri("http://www.st.ewi.tudelft.nl/~arie/papers/klint.pdf"));
                dvVersion.Text = DocuViewareManager.GetVersion();
            }
        }
    }
}