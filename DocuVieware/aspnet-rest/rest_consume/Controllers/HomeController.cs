using System.IO;
using System.Web.Mvc;
using System.Net;
using System.Web.Script.Serialization;
using rest_consume.Models;

namespace rest_consume.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://localhost:65088/api/DocuViewareREST/GetDocuViewareControl");
            request.Method = "POST";
            request.ContentType = "application/json";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                string json = serializer.Serialize(new DocuViewareConfiguration
                {
                    SessionId = "mySessionId",
                    ControlId = "DocuVieware1",
                    AllowPrint = true,
                    EnablePrintButton = true,
                    AllowUpload = true,
                    EnableFileUploadButton = true,
                    CollapsedSnapIn = true,
                    ShowAnnotationsSnapIn = true,
                    EnableRotateButtons = true,
                    EnableZoomButtons = true,
                    EnablePageViewButtons = true,
                    EnableMultipleThumbnailSelection = true,
                    EnableMouseModeButtons = true,
                    EnableFormFieldsEdition = true,
                    EnableTwainAcquisitionButton = true,
                    Locale = !string.IsNullOrEmpty(Request.UserLanguages[0]) ? Request.UserLanguages[0].Substring(0, 2) : ""
                });
                sw.Write(json);
                sw.Flush();
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            DocuViewareRESTOutputResponse output;
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                output = serializer.Deserialize<DocuViewareRESTOutputResponse>(sr.ReadToEnd());
            }
            ViewBag.docuViewareControlHtml = output.HtmlContent;

            return View();
        }
    }
}