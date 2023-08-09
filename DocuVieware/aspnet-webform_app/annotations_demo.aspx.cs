using System;
using System.IO;

namespace DocuVieware_webform_app_demo
{
    public partial class AnnotationsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DocuVieware1.Timeout = Global.SESSION_TIMEOUT;
            if (!IsPostBack)
            {
                DocuVieware1.LoadFromStream(new FileStream(Global.GetDocumentsDirectory() + @"\st_exupery_le_petit_prince.pdf", FileMode.Open, FileAccess.Read), true, "st_exupery_le_petit_prince.pdf");
            }
        }
    }
}