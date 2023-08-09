using System;
using System.IO;
using GdPicture14;
using GdPicture14.WEB;

namespace aspnet_mvc_razor_app
{
    public class TwainAcquisitionDemo
    {
        /// <summary>
        /// Entry point for the custom action handler
        /// </summary>
        public static void HandleTwainGeneratePdfaAction(CustomActionEventArgs e)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                GdPictureStatus status = e.docuVieware.SaveAsPDF(PdfConformance.PDF_A_1b, memoryStream, "*", false);
                if (status == GdPictureStatus.OK)
                {
                    e.result = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
                }
                else
                {
                    e.message = new DocuViewareMessage("Error saving the document : " + status, icon: DocuViewareMessageIcon.Error);
                }
            }      
        }
    }
}