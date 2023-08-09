using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using GdPicture14.WEB;
using DocuViewareDemo.Models;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace DocuViewareDemo.Controllers
{
    [ApiController]
    [Route("api/DocuVieware")]
    public class DocuViewareController : ControllerBase
    {
        [HttpPost]
        [Route("GetDocuViewareControl")]
        public DocuViewareRESTOutputResponse GetDocuViewareControl(DocuViewareConfiguration controlConfiguration)
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

            using (DocuViewareControl docuVieware = new DocuViewareControl(controlConfiguration.SessionId))
            {
                docuVieware.MaxUploadSize = 36700160; // 35MB
                docuVieware.Locale = controlConfiguration.Lang;

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

        [HttpGet]
        [Route("GetDocuviewareLanguages")]
        public IActionResult GetSupportedLanguages()
        {
            var languages = new List<string>();
            foreach (var lang in Enum.GetValues(typeof(DocuViewareLocale)))
            {
                if ((DocuViewareLocale)lang == DocuViewareLocale.Auto)
                {
                    continue;
                }

                languages.Add($"{(int)lang}|{lang}");
            }
            return Ok(languages);
        }
    }
}
