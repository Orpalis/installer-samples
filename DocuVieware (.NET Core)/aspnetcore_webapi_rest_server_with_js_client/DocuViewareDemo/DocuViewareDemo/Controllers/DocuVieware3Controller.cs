using Microsoft.AspNetCore.Mvc;
using GdPicture14.WEB;
using System.Net.Http;
using System.Net;
namespace DocuViewareNetCore.Controllers
{
    [Route("api/docuvieware3")]
    public class DocuVieware3Controller : Controller
    {
        [HttpGet("ping")]
        public string ping()
        {
            return "pong";
        }

        [HttpPost("baserequest")]
        public string baserequest([FromBody] object jsonString)
        {
            return DocuViewareControllerActionsHandler.baserequest(jsonString);
        }

        [HttpGet("print")]
        public IActionResult Print(string sessionID, string pageRange, bool printAnnotations)
        {
            DocuViewareControllerActionsHandler.print(sessionID, pageRange, printAnnotations, out string fileName, out HttpStatusCode statusCode, out string reasonPhrase, out byte[] content, out string contentType);
            if (statusCode == HttpStatusCode.OK)
            {
                return File(content, contentType, fileName);
            }
            else
            {
                return StatusCode((int)statusCode, reasonPhrase);
            }
        }

        [HttpGet("save")]
        public IActionResult Save(string sessionID, string fileName, string format, string pageRange, bool dropAnnotations, bool flattenAnnotations)
        {
            DocuViewareControllerActionsHandler.save(sessionID, ref fileName, format, pageRange, dropAnnotations, flattenAnnotations, out HttpStatusCode statusCode, out string reasonPhrase, out byte[] content, out string contentType);
            if (statusCode == HttpStatusCode.OK)
            {
                return File(content, contentType, fileName);
            }
            else
            {
                return StatusCode((int)statusCode, reasonPhrase);
            }
        }


        [HttpGet("twainservicesetupdownload")]
        public IActionResult TwainServiceSetupDownload(string sessionID)
        {
            DocuViewareControllerActionsHandler.twainservicesetupdownload(sessionID, out HttpStatusCode statusCode, out byte[] content, out string contentType, out string fileName, out string reasonPhrase);
            if (statusCode == HttpStatusCode.OK)
            {
                return File(content, contentType, fileName);
            }
            else
            {
                return StatusCode((int)statusCode, reasonPhrase);
            }
        }
        
        
       [HttpGet("getresource")]
        public IActionResult GetResource(string resourceID, string version)
        {
            DocuViewareControllerActionsHandler.getresource(resourceID, version, out HttpStatusCode statusCode, out byte[] content, out string contentType, out string fileName, out string reasonPhrase);
            if (statusCode == HttpStatusCode.OK)
            {
                return File(content, contentType, fileName);
            }
            else
            {
                return StatusCode((int)statusCode, reasonPhrase);
            }
        }
        

        [HttpPost("formfieldupdate")]
        public string FormfieldUpdate([FromBody] object jsonString)
        {
            return DocuViewareControllerActionsHandler.formfieldupdate(jsonString);
        }


        [HttpPost("annotupdate")]
        public string AnnotUpdate([FromBody] object jsonString)
        {
            return DocuViewareControllerActionsHandler.annotupdate(jsonString);
        }


        [HttpPost("loadfromfile")]
        public string LoadFromFile([FromBody] object jsonString)
        {
            return DocuViewareControllerActionsHandler.loadfromfile(jsonString);
        }


        [HttpPost("loadfromfilemultipart")]
        public string LoadFromFileMultipart()
        {
            return DocuViewareControllerActionsHandler.loadfromfilemultipart(Request);
        }
    }
}