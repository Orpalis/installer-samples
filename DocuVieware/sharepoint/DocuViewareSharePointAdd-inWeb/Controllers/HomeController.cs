using DocuViewareSharePointAdd_inWeb.Models;
using GdPicture14;
using GdPicture14.WEB;
using Microsoft.Ajax.Utilities;
using Microsoft.IdentityModel.Protocols.WSTrust;
using Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.Application;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Web.Configuration;
using System.Web.Http.Results;
using System.Web.Mvc;
using File = Microsoft.SharePoint.Client.File;

namespace DocuViewareSharePointAdd_inWeb.Controllers
{
    public class HomeController : Controller
    {
        private static string SP_FOLDER = WebConfigurationManager.AppSettings.Get("defaultFolder");

        [SharePointContextFilter]
        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel { Documents = new List<DocumentItem>() };

            SharePointContext spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);
            using (ClientContext context = spContext.CreateUserClientContextForSPHost())
            {
                model.Title = "Documents";

                // The SharePoint web at the URL.
                Folder folder = context.Web.GetFolderByServerRelativePath(ResourcePath.FromDecodedUrl(SP_FOLDER));

                // We want to retrieve the web's properties.
                context.Load(folder, p => p.Files);

                // Execute the query to the server.
                context.ExecuteQuery();

                if (folder.Files != null)
                {
                    foreach (var document in folder.Files)
                    {
                        DocumentItem item = new DocumentItem
                        {
                            Id = document.UniqueId,
                            Name = document.Name,
                            Url = document.LinkingUrl.ToString()
                        };
                        model.Documents.Add(item);
                    }
                }

                return View(model);
            }
        }

        [SharePointContextFilter]
        public ActionResult DisplayDocument(Guid documentId)
        {

            MemoryStream document = new MemoryStream();
            string fileName;

            SharePointContext spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);
            using (ClientContext context = spContext.CreateUserClientContextForSPHost())
            {
                var file = context.Web.GetFileById(documentId);
                ClientResult<Stream> content = file.OpenBinaryStream();
                context.Load(file, p => p.Name);
                context.ExecuteQuery();

                content.Value.CopyTo(document);
                fileName = file.Name.ToString();
            }

            DocuVieware docuVieware = new DocuVieware
            {
                ID = "Docuvieware1",
                Timeout = MvcApplication.SESSION_TIMEOUT,
                Height = new System.Web.UI.WebControls.Unit("100%"),
                Width = new System.Web.UI.WebControls.Unit("100%"),
                SinglePageView = false,
                ForceScrollBars = false,
                AllowedExportFormats = "*",
                EnableFileUploadButton = false,
                EnableLoadFromUriButton = false,
                EnableMultipleThumbnailSelection = false,
                EnableMouseModeButtons = false,
                EnableTwainAcquisitionButton = false,
                EnableFormFieldsEdition = false,
            };

            docuVieware.AddSaveToSharepointButton();
            docuVieware.LoadFromStream(document, true, fileName);
            return View(new DisplayDocumentViewModel { DocumentId = documentId, Control = docuVieware });
        }

        [HttpPost]
        [SharePointContextFilter]
        public ActionResult SaveToSharepoint(Guid documentId, string dvSessionId)
        {
            var result = new SaveToSharepointResultViewModel();
            try
            {
                if (!DocuViewareManager.IsSessionAlive(dvSessionId))
                {
                    throw new Exception("Invalid session identifier and/or invalid control identifier.");
                }
                using (var dvControl = new DocuVieware(dvSessionId))
                using (var ms = new MemoryStream())
                {
                    var savedFile = dvControl.SaveAsPDF(PdfConformance.PDF1_7, ms);
                    if (savedFile != GdPictureStatus.OK)
                    {
                        throw new Exception("the file could not be used");
                    }

                    //Rewind document stream
                    ms.Seek(0, SeekOrigin.Begin);

                    SharePointContext spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);
                    using (ClientContext context = spContext.CreateUserClientContextForSPHost())
                    {
                        Folder folder = context.Web.GetFolderByServerRelativePath(ResourcePath.FromDecodedUrl(SP_FOLDER));

                        var originalFile = context.Web.GetFileById(documentId);
                        context.Load(originalFile, o => o.ServerRelativeUrl);
                        context.ExecuteQuery();

                        folder.Files.Add(new FileCreationInformation
                        {
                            ContentStream = ms,
                            Overwrite = true,
                            Url = originalFile.ServerRelativeUrl
                        });

                        context.ExecuteQuery();

                        result.Status = System.Web.HttpValidationStatus.Valid;
                        result.Message = $"This file has been successfully saved to '{originalFile.ServerRelativeUrl}'";
                    }
                }
            }
            catch (Exception e)
            {
                result.Status = System.Web.HttpValidationStatus.Invalid;
                result.Message = e.Message;
            }
            return Json(result);
        }
    }
}

static class Utils
{
    public static void AddSaveToSharepointButton(this DocuVieware dvControl)
    {
        var icon = new System.Web.UI.HtmlControls.HtmlGenericControl("svg");
        icon.InnerHtml = "<path d=\"M19 21H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h11l5 5v11a2 2 0 0 1-2 2z\" fill=\"none\" stroke=\"#000\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\"/>    <polyline points=\"7 3 7 8 15 8\" fill=\"none\" stroke=\"#000\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\"/><polyline points=\"17 21 17 13 7 13 7 21\" fill=\"none\" stroke=\"#000\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\"/>";
        dvControl.AddCustomToolbarButton("SP_SAVE", "Save to SharePoint", icon, "SaveOnSharePoint()");
    }
}

