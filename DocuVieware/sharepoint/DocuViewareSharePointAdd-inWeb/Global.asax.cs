using GdPicture14.WEB;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DocuViewareSharePointAdd_inWeb
{
    public class MvcApplication : HttpApplication
    {
        public const int SESSION_TIMEOUT = 20; //Set to 20 minutes. use -1 to handle DocuVieware session timeout through asp.net session mechanism.
        private const bool STICKY_SESSION = true; //Set false to use DocuVieware on Servers Farm witn non sticky sessions.
        private const DocuViewareSessionStateMode DOCUVIEWARE_SESSION_STATE_MODE = DocuViewareSessionStateMode.InProc; //Set DocuViewareSessionStateMode.File is STICKY_SESSION is False.

        public static string GetCacheDirectory()
        {
            return HttpRuntime.AppDomainAppPath + "\\Cache";
        }

        protected void Application_Start()
        {
            try
            {
                Assembly.Load("GdPicture.NET.14.WEB.DocuVieware");
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new System.IO.FileNotFoundException(" The system cannot find the DocuVieware assembly. Please set the Copy Local Property of the GdPicture.NET.14.WEB.DocuVieware reference to true. More information: https://msdn.microsoft.com/en-us/library/t1zz5y8c(v=vs.100).aspx");
            }

            DocuViewareLicensing.RegisterKEY(""); //Unlocking DocuVieware. Please set your demo or commercial license key here.
            DocuViewareManager.SetupConfiguration(STICKY_SESSION, DOCUVIEWARE_SESSION_STATE_MODE, GetCacheDirectory());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
