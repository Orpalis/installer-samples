using GdPicture14;
using GdPicture14.WEB;
using System;
using System.IO;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace DocuVieware_webform_app_demo
{
    public partial class GalleryDemo : System.Web.UI.Page
    {
        public static void HandleLoadAction(CustomActionEventArgs e)
        {
            string docRef = (string)e.args;
            e.message = new DocuViewareMessage("Displaying " + docRef, icon: DocuViewareMessageIcon.Information);
            e.docuVieware.LoadFromStream(new FileStream(Global.GetDocumentsDirectory() + "\\" + docRef, FileMode.Open, FileAccess.Read), true, docRef);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DocuVieware1.Timeout = Global.SESSION_TIMEOUT;

            bool firstDoc = true;
            foreach (string doc in Directory.GetFiles(Global.GetDocumentsDirectory()))
            {
                GdPicture14.DocumentFormat documentFormat = GdPicture14.DocumentFormat.DocumentFormatUNKNOWN;
                int pageCount = 0;
                GdPictureStatus status = GdPictureDocumentUtilities.GetDocumentPreview(doc, ref documentFormat, ref pageCount);

                if (documentFormat != GdPicture14.DocumentFormat.DocumentFormatUNKNOWN)
                {
                    using (HtmlGenericControl thumbnailContainer = new HtmlGenericControl("div"))
                    {
                        thumbnailContainer.Attributes["class"] = "thumbnail_container";
                        using (ImageButton btn = new ImageButton())
                        {
                            btn.ImageUrl = "galleryThumbnails.ashx?doc=" + HttpUtility.UrlEncode(Path.GetFileName(doc));
                            btn.Attributes["class"] = "thumbnail_button";
                            btn.OnClientClick = "loadDocument('" + HttpUtility.UrlEncode(Path.GetFileName(doc)) + "', this);return false;";
                            if (firstDoc)
                            {
                                if (DocuVieware1.LoadFromStream(new FileStream(doc, FileMode.Open, FileAccess.Read), true, Path.GetFileName(doc)) == GdPictureStatus.OK)
                                {
                                    thumbnailContainer.Attributes["class"] += " item-selected";
                                    firstDoc = false;
                                }
                            }
                            thumbnailContainer.Controls.Add(btn);
                        }
                        using (HtmlGenericControl titleThumbnail = new HtmlGenericControl("div"))
                        {
                            titleThumbnail.InnerHtml = documentFormat.ToString().Replace("DocumentFormat", "") + " file<br />" + pageCount + " page" + (pageCount > 1 ? "s" : "");
                            thumbnailContainer.Controls.Add(titleThumbnail);
                        }
                        gallery_container.Controls.Add(thumbnailContainer);
                    }
                }
            }
        }
    }
}