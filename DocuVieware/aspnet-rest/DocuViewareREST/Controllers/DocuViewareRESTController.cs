using DocuViewareREST.Models;
using GdPicture14.WEB;
using System;
using System.IO;
using System.Linq;
using System.Web.Http;

namespace DocuViewareREST.Controllers
{
    public class DocuViewareRESTController : ApiController
    {
        /// <summary>
        /// This POST request will return the control markup that corresponds to the provided session and configuration.
        /// </summary>
        /// <param name="controlConfiguration">A DocuViewareConfiguration object</param>
        /// <returns>A DocuViewareRESTOutputResponse JSON object that contains all the control HTML to include in the client page.</returns>
        [HttpPost]
        [Route("api/DocuViewareREST/GetDocuViewareControl")]
        public DocuViewareRESTOutputResponse GetDocuViewareControl(DocuViewareConfiguration controlConfiguration)
        {
            if (!DocuViewareManager.IsSessionAlive(controlConfiguration.SessionId))
            {
                if (!string.IsNullOrEmpty(controlConfiguration.SessionId) && !string.IsNullOrEmpty(controlConfiguration.ControlId))
                {
                    DocuViewareManager.CreateDocuViewareSession(controlConfiguration.SessionId, controlConfiguration.ControlId, WebApiApplication.SESSION_TIMEOUT);
                }
                else
                {
                    throw new Exception("Invalid session identifier and/or invalid control identifier.");
                }
            }

            using (DocuVieware docuVieware = new DocuVieware(controlConfiguration.SessionId))
            {
                docuVieware.AllowPrint = controlConfiguration.AllowPrint;
                docuVieware.EnablePrintButton = controlConfiguration.EnablePrintButton;
                docuVieware.AllowUpload = controlConfiguration.AllowUpload;
                docuVieware.EnableFileUploadButton = controlConfiguration.EnableFileUploadButton;
                docuVieware.CollapsedSnapIn = controlConfiguration.CollapsedSnapIn;
                docuVieware.ShowAnnotationsSnapIn = controlConfiguration.ShowAnnotationsSnapIn;
                docuVieware.EnableRotateButtons = controlConfiguration.EnableRotateButtons;
                docuVieware.EnableZoomButtons = controlConfiguration.EnableZoomButtons;
                docuVieware.EnablePageViewButtons = controlConfiguration.EnablePageViewButtons;
                docuVieware.EnableMultipleThumbnailSelection = controlConfiguration.EnableMultipleThumbnailSelection;
                docuVieware.EnableMouseModeButtons = controlConfiguration.EnableMouseModeButtons;
                docuVieware.EnableFormFieldsEdition = controlConfiguration.EnableFormFieldsEdition;
                docuVieware.EnableTwainAcquisitionButton = controlConfiguration.EnableTwainAcquisitionButton;
                docuVieware.Locale = (DocuViewareLocale)Enum.Parse(typeof(DocuViewareLocale), controlConfiguration.Locale.First().ToString().ToUpper() + controlConfiguration.Locale.Substring(1));
                docuVieware.MaxUploadSize = 36700160; // 35MB

                using (StringWriter controlOutput = new StringWriter())
                {
                    docuVieware.RenderControl(controlOutput);
                    DocuViewareRESTOutputResponse output = new DocuViewareRESTOutputResponse
                    {
                        HtmlContent = controlOutput.ToString()
                    };
                    return output;
                }
            }
        }
    }
}
