using GdPicture14.WEB;
using System.Web;
using System.Web.Http;

namespace DocuViewareREST
{
    public class WebApiApplication : HttpApplication
    {
        public static readonly int SESSION_TIMEOUT = 20; //Set to 20 minutes. Use -1 to handle DocuVieware session timeout through ASP.NET session mechanism.
        private static readonly bool STICKY_SESSION = true; //Set false to use DocuVieware on Servers Farm with non sticky sessions.
        private const DocuViewareSessionStateMode DOCUVIEWARE_SESSION_STATE_MODE = DocuViewareSessionStateMode.InProc; //Set DocuViewareSessionStateMode.File is STICKY_SESSION is False.

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            DocuViewareManager.SetupConfiguration(STICKY_SESSION, DOCUVIEWARE_SESSION_STATE_MODE, GetCacheDirectory());
            DocuViewareLicensing.RegisterKEY(""); //Unlocking DocuVieware. Please insert your demo or commercial license key here.
            DocuViewareEventsHandler.NewDocumentLoaded += NewDocumentLoadedHandler;
        }

        private static string GetCacheDirectory()
        {
            return HttpRuntime.AppDomainAppPath + "\\Cache";
        }

        private static void NewDocumentLoadedHandler(object sender, NewDocumentLoadedEventArgs e)
        {
            e.docuVieware.PagePreload = e.docuVieware.PageCount <= 50 ? PagePreloadMode.AllPages : PagePreloadMode.AdjacentPages;
        }
    }
}
