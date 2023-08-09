using GdPicture14;
using System.Drawing;
using System.IO;
using System.Web;

namespace DocuVieware_webform_app_demo
{
    /// <summary>
    /// Summary description for GalleryThumbnails
    /// </summary>
    public class GalleryThumbnails : IHttpHandler
    {
        private const int THUMBNAIL_WIDTH = 120;
        private const int THUMBNAIL_HEIGHT = 170;
        private Color THUMBNAIL_BACKGROUND_COLOR = Color.Transparent;

        public void ProcessRequest(HttpContext context)
        {
            string doc = context.Request.QueryString["doc"];
            if (doc != null)
            {
                string docPath = Global.GetDocumentsDirectory() + "\\" + HttpUtility.UrlDecode(doc);
                string thumbPath = Global.GetCacheDirectory() + "\\" + HttpUtility.UrlDecode(doc) + ".thumb";
                if (File.Exists(thumbPath))
                {
                    byte[] content;
                    //getting thumbnail from cache
                    try
                    {
                        using (FileStream fileStream = new FileStream(thumbPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            content = new byte[fileStream.Length];
                            fileStream.Read(content, 0, (int)fileStream.Length); //safe cast as thumbnail size will never exceed int.maxValue
                        }
                    }
                    catch
                    {//can fail during first concurrent accesses.
                        goto gen_thumb;
                    }
                    context.Response.ContentType = "image/png";
                    context.Response.BinaryWrite(content);
                    context.Response.Flush();
                    return;
                }

            gen_thumb:
                GdPicture14.DocumentFormat documentFormat = GdPicture14.DocumentFormat.DocumentFormatUNKNOWN;
                int thumbnailId = 0;
                int pageCount = 0;
                GdPictureStatus status = GdPictureDocumentUtilities.GetDocumentPreview(docPath, THUMBNAIL_WIDTH, THUMBNAIL_HEIGHT, THUMBNAIL_BACKGROUND_COLOR.ToArgb(), ref documentFormat, ref thumbnailId, ref pageCount);
                if (status == GdPictureStatus.OK)
                {
                    using (GdPictureImaging gdpictureImaging = new GdPictureImaging())
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            try
                            {
                                if (gdpictureImaging.SaveAsStream(thumbnailId, memoryStream, GdPicture14.DocumentFormat.DocumentFormatPNG, 6) == GdPictureStatus.OK)
                                {
                                    byte[] content = memoryStream.ToArray();
                                    context.Response.ContentType = "image/png";
                                    context.Response.BinaryWrite(content);
                                    context.Response.Flush();
                                    //let's cache result
                                    using (FileStream fileStream = new FileStream(thumbPath, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                                    {
                                        fileStream.Write(content, 0, content.Length);
                                    }
                                }
                            }
                            finally
                            {
                                GdPictureDocumentUtilities.DisposeImage(thumbnailId);
                            }
                        }
                    }
                }
            }
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}