using System.IO;
using GdPicture14.WEB;

namespace aspnet_mvc_razor_app
{
    public class GalleryDemo
    {
        /// <summary>
        /// Entry point for the custom action handler
        /// </summary>
        public static void HandleLoadDocumentAction(CustomActionEventArgs e)
        {
            string docRef = (string)e.args;
            e.message = new DocuViewareMessage("Displaying " + docRef, icon: DocuViewareMessageIcon.Information);
            e.docuVieware.LoadFromStream(new FileStream(MvcApplication.GetDocumentsDirectory() + "\\" + docRef, FileMode.Open, FileAccess.Read), true, docRef);
        }
    }
}