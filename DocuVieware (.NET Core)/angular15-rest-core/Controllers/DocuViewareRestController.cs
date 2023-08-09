using angular15_rest_core.Models;
using GdPicture14.WEB;
using Microsoft.AspNetCore.Mvc;

namespace angular15_rest_core.Controllers
{
    [ApiController]
    [Route("api/DocuVieware")]
    public class DocuViewareRestController : ControllerBase
    {
        [HttpPost("[action]")]
        public async Task<ActionResult> GetDocuViewareControl(DocuViewareConfiguration controlConfiguration)
        {
            if (!DocuViewareManager.IsSessionAlive(controlConfiguration.SessionId))
            {
                if (!string.IsNullOrEmpty(controlConfiguration.SessionId) && !string.IsNullOrEmpty(controlConfiguration.ControlId))
                {
                    DocuViewareManager.CreateDocuViewareSession(controlConfiguration.SessionId, controlConfiguration.ControlId, 20);
                }
                else
                {
                    throw new Exception("Invalid session identifier and/or invalid control identifier.");
                }
            }

            using DocuViewareControl docuVieware = new DocuViewareControl(controlConfiguration.SessionId)
            {
                AllowPrint = controlConfiguration.AllowPrint,
                EnablePrintButton = controlConfiguration.EnablePrintButton,
                AllowUpload = controlConfiguration.AllowUpload,
                EnableFileUploadButton = controlConfiguration.EnableFileUploadButton,
                CollapsedSnapIn = controlConfiguration.CollapsedSnapIn,
                ShowAnnotationsSnapIn = controlConfiguration.ShowAnnotationsSnapIn,
                EnableRotateButtons = controlConfiguration.EnableRotateButtons,
                EnableZoomButtons = controlConfiguration.EnableZoomButtons,
                EnablePageViewButtons = controlConfiguration.EnablePageViewButtons,
                EnableMultipleThumbnailSelection = controlConfiguration.EnableMultipleThumbnailSelection,
                EnableMouseModeButtons = controlConfiguration.EnableMouseModeButtons,
                EnableFormFieldsEdition = controlConfiguration.EnableFormFieldsEdition,
                EnableTwainAcquisitionButton = controlConfiguration.EnableTwainAcquisitionButton,
                MaxUploadSize = 36700160 // 35MB
            };

            using StringWriter controlOutput = new StringWriter();
            docuVieware.RenderControl(controlOutput);

            return Ok(new
            {
                HtmlContent = controlOutput.ToString()
            });
        }
    }
}
