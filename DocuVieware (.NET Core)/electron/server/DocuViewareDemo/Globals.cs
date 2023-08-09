using GdPicture14;
using GdPicture14.WEB;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocuViewareDemo
{
    public static class Globals
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

        public static void CustomActionHandler(object sender, CustomActionEventArgs e)
        {
            var status = e.docuVieware.GetNativePDF(out GdPicturePDF pdf);

            if (status != GdPictureStatus.OK)
            {
                e.message = new DocuViewareMessage("The document is not a PDF !");
                return;
            }

            switch (e.actionName)
            {
                case "AddSignatureFormField":
                    //The GetSelectionAreaCoordinates return value in Inch
                    pdf.SetMeasurementUnit(PdfMeasurementUnit.PdfMeasurementUnitInch);
                    pdf.SetOrigin(PdfOrigin.PdfOriginTopLeft);

                    var addSignatureFormFieldArgs = JsonSerializer.Deserialize<PostCustomActionModels.AddSignatureFormFieldModel>(
                        e.args.ToString(), 
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true, NumberHandling = JsonNumberHandling.Strict });
                    
                    pdf.AddSignatureFormField(
                        addSignatureFormFieldArgs.Region.Left, 
                        addSignatureFormFieldArgs.Region.Top, 
                        addSignatureFormFieldArgs.Region.Width, 
                        addSignatureFormFieldArgs.Region.Height, 
                        addSignatureFormFieldArgs.FormFieldName);

                    status = pdf.GetStat();

                    if (status != GdPictureStatus.OK)
                    {
                        e.message = new DocuViewareMessage("The signature could not be added");
                        return;
                    }
                    
                    pdf.DrawRectangle(
                        addSignatureFormFieldArgs.Region.Left,
                        addSignatureFormFieldArgs.Region.Top,
                        addSignatureFormFieldArgs.Region.Width,
                        addSignatureFormFieldArgs.Region.Height,
                        false,
                        true);

                    e.docuVieware.RedrawPage();

                    break;
            }
        }
    }

    public static class PostCustomActionModels
    {
        public class AddSignatureFormFieldModel
        {
            public string FormFieldName { get; set; }
            public Region Region { get; set; }
        }

        public class Region
        {
            public float Width { get; set; }
            public float Height { get; set; }
            public float Top { get; set; }
            public float Left { get; set; }
        }
    }
}