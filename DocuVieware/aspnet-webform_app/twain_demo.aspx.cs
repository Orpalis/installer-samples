using System;
using System.IO;
using GdPicture14;

namespace DocuVieware_webform_app_demo
{
    public partial class TwainAcquisitionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnGeneratePdf_Click(object sender, EventArgs e)
        {
          using (MemoryStream memoryStream = new MemoryStream())
            {
                GdPictureStatus status = DocuVieware1.SaveAsPDF(PdfConformance.PDF_A_1b, memoryStream, "*", false);
                if(status == GdPictureStatus.OK)
                { 
                    Response.Clear();
                    Response.AddHeader("Content-Disposition", "attachment; filename=archive.pdf");
                    Response.AddHeader("Content-Length", memoryStream.Length.ToString());
                    Response.ContentType = "application/octet-stream";
                    Response.BinaryWrite(memoryStream.ToArray());
                }
            }  
        }
    }
}