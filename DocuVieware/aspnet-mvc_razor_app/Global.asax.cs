using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using GdPicture14.WEB;
using System.Reflection;

namespace aspnet_mvc_razor_app
{
    public class MvcApplication : HttpApplication
    {
        public static readonly int SESSION_TIMEOUT = 20; //Set to 20 minutes. use -1 to handle DocuVieware session timeout through asp.net session mechanism.
        private const bool STICKY_SESSION = true; //Set false to use DocuVieware on Servers Farm witn non sticky sessions.
        private const DocuViewareSessionStateMode DOCUVIEWARE_SESSION_STATE_MODE = DocuViewareSessionStateMode.InProc; //Set DocuViewareSessionStateMode.File is STICKY_SESSION is False.

        public static string GetCacheDirectory()
        {
            return HttpRuntime.AppDomainAppPath + "\\cache";
        }

        public static string GetDocumentsDirectory()
        {
            return HttpRuntime.AppDomainAppPath + "\\documents";
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

            DocuViewareManager.SetupConfiguration(STICKY_SESSION, DOCUVIEWARE_SESSION_STATE_MODE, GetCacheDirectory());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            DocuViewareLicensing.RegisterKEY(""); //Unlocking DocuVieware. Please set your demo or commercial license key here.
            DocuViewareEventsHandler.NewDocumentLoaded += NewDocumentLoadedHandler;
            DocuViewareEventsHandler.CustomAction += CustomActionDispatcher;
        }

        private static void NewDocumentLoadedHandler(object sender, NewDocumentLoadedEventArgs e)
        {
            e.docuVieware.PagePreload = e.docuVieware.PageCount <= 50 ? PagePreloadMode.AllPages : PagePreloadMode.AdjacentPages;
        }

        private static void CustomActionDispatcher(object sender, CustomActionEventArgs e)
        {
            switch (e.actionName)
            {
                case "load":
                    GalleryDemo.HandleLoadDocumentAction(e);
                    break;
                case "automaticRemoveBlackBorders":
                case "autoDeskew":
                case "punchHoleRemoval":
                case "negative":
                case "despeckle":
                case "rotate-90":
                case "rotate+90":
                    ImageCleanupDemo.HandleImageCleanupAction(e);
                    break;
                case "barcodeRecognition":
                    BarcodeRecognitionDemo.HandleBarCodeRecognitionAction(e);
                    break;
                case "Calculate":
                case "SaveAsPdf":
                    FormFieldsDemo.HandleFormFieldsAction(e);
                    break;
                case "generatePDFA":
                    TwainAcquisitionDemo.HandleTwainGeneratePdfaAction(e);
                    break;
                case "addTimestamp":
                case "addSignature":
                    LeaveRequestApprovalDemo.HandleAnnotationAction(e);
                    break;
            }
        }
    }
}