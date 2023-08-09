using angular15_rest_core.DocuViewareCustomActions;
using GdPicture14.WEB;
using Microsoft.Net.Http.Headers;

namespace angular15_rest_core
{
    public class Globals
    {
        private static readonly string m_rootDirectory = Directory.GetCurrentDirectory();
        public static readonly int SESSION_TIMEOUT = 20; //Set to 20 minutes. use -1 to handle DocuVieware session timeout through asp.net session mechanism.
        public const bool STICKY_SESSION = true; //Set false to use DocuVieware on Servers Farm witn non sticky sessions.
        public const DocuViewareSessionStateMode DOCUVIEWARE_SESSION_STATE_MODE = DocuViewareSessionStateMode.File; //Set DocuViewareSessionStateMode.File is STICKY_SESSION is False.


        public static string GetCacheDirectory()
        {
            return m_rootDirectory + "\\cache";
        }


        public static string GetDocumentsDirectory()
        {
            return m_rootDirectory + "\\documents";
        }


        public static string BuildDocuViewareControlSessionID(HttpContext HttpContext, string clientID)
        {
            if (HttpContext.Session.GetString("DocuViewareInit") == null)
            {
                HttpContext.Session.SetString("DocuViewareInit", "true");
            }

            return HttpContext.Session.Id + clientID;
        }


        public static DocuViewareLocale GetDocuViewareLocale(HttpRequest request)
        {
            if (request != null)
            {
                IList<StringWithQualityHeaderValue> acceptLanguage = request.GetTypedHeaders().AcceptLanguage;

                if (acceptLanguage != null)
                {
                    foreach (StringWithQualityHeaderValue language in acceptLanguage)
                    {
                        object docuviewareLocale;
                        if (Enum.TryParse(typeof(DocuViewareLocale), language.Value.Value, true, out docuviewareLocale))
                        {
                            return (DocuViewareLocale)docuviewareLocale;
                        }
                    }
                }
            }

            return DocuViewareLocale.En;
        }


        public static void CustomActionDispatcher(object sender, CustomActionEventArgs e)
        {
            switch (e.actionName)
            {
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
                case "addTimestamp":
                case "addSignature":
                    LeaveRequestApprovalDemo.HandleAnnotationAction(e);
                    break;
            }
        }
    }
}
