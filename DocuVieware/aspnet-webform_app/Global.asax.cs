using GdPicture14.WEB;
using System;
using System.Reflection;
using System.Web;

namespace DocuVieware_webform_app_demo
{
    public sealed class RegionOfInterest
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Global : HttpApplication
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

        private void Application_Start(object sender, EventArgs e)
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
            DocuViewareLicensing.RegisterKEY(""); //Unlocking DocuVieware. Please insert your demo or commercial license key here.
            DocuViewareEventsHandler.CustomAction += CustomActionsHandler;
            DocuViewareEventsHandler.NewDocumentLoaded += NewDocumentLoadedHandler;
            //GdPictureDocumentUtilities.AddFontFolder(@"c:\fonts");
        }

        private static void NewDocumentLoadedHandler(object sender, NewDocumentLoadedEventArgs e)
        {
            e.docuVieware.PagePreload = e.docuVieware.PageCount <= 50 ? PagePreloadMode.AllPages : PagePreloadMode.AdjacentPages;
        }

        private static void CustomActionsHandler(object sender, CustomActionEventArgs e)
        {
            switch (e.actionName)
            {
                case "load":
                    GalleryDemo.HandleLoadAction(e);
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
                    FormfieldsDemo.HandleCalculateAction(e);
                    break;
                case "addTimestamp":
                case "addSignature":
                    LeaveRequestApproval.HandleAnnotationAction(e);
                    break;
            }
        }
    }
}
