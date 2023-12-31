﻿using GdPicture14.WEB;
using GdPicture14;
using Newtonsoft.Json;

namespace angular15_rest_core.DocuViewareCustomActions
{
    public sealed class RegionOfInterest
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }

    internal class ImageCleanupActionParameters
    {
        public int[] Pages { get; set; }
        public RegionOfInterest Roi { get; set; }
    }

    public class ImageCleanupDemo
    {
        private static DocuViewareMessage GetErrorMessage(string message)
        {
            return new DocuViewareMessage(message, null, 2500, 300, 300, false, "130%", "normal", "#FFFFFF", "none", "none", "48px", DocuViewareMessageIcon.Error);
        }

        public static void HandleImageCleanupAction(CustomActionEventArgs e)
        {
            if (e.docuVieware.PageCount > 0)
            {
                if (e.docuVieware.GetDocumentType() == DocumentType.DocumentTypeBitmap)
                {
                    int imageId;
                    GdPictureStatus status = e.docuVieware.GetNativeImage(out imageId);
                    if (status == GdPictureStatus.OK)
                    {
                        status = GdPictureStatus.GenericError;
                        using (GdPictureImaging gdPictureImaging = new GdPictureImaging())
                        {
                            ImageCleanupActionParameters cleanupParameters = JsonConvert.DeserializeObject<ImageCleanupActionParameters>(e.args.ToString());
                            if (cleanupParameters.Roi != null && cleanupParameters.Roi.Width > 0 && cleanupParameters.Roi.Height > 0)
                            {
                                gdPictureImaging.SetROI((int)Math.Round(cleanupParameters.Roi.Left * gdPictureImaging.GetHorizontalResolution(imageId), 0),
                                    (int)Math.Round(cleanupParameters.Roi.Top * gdPictureImaging.GetVerticalResolution(imageId), 0),
                                    (int)Math.Round(cleanupParameters.Roi.Width * gdPictureImaging.GetHorizontalResolution(imageId), 0),
                                    (int)Math.Round(cleanupParameters.Roi.Height * gdPictureImaging.GetVerticalResolution(imageId), 0));
                            }
                            if (e.actionName != "punchHoleRemoval" || (e.actionName == "punchHoleRemoval" && gdPictureImaging.GetBitDepth(imageId) == 1))
                            {
                                foreach (var page in cleanupParameters.Pages)
                                {
                                    status = gdPictureImaging.SelectPage(imageId, page);
                                    if (status == GdPictureStatus.OK)
                                    {
                                        switch (e.actionName)
                                        {
                                            case "automaticRemoveBlackBorders":
                                                status = gdPictureImaging.DeleteBlackBorders(imageId, 10, false);
                                                break;
                                            case "autoDeskew":
                                                status = gdPictureImaging.AutoDeskew(imageId);
                                                break;
                                            case "punchHoleRemoval":
                                                status = gdPictureImaging.RemoveHolePunch(imageId, HolePunchMargins.MarginLeft | HolePunchMargins.MarginRight | HolePunchMargins.MarginBottom | HolePunchMargins.MarginTop);
                                                break;
                                            case "negative":
                                                status = gdPictureImaging.FxNegative(imageId);
                                                break;
                                            case "despeckle":
                                                status = gdPictureImaging.FxDespeckle(imageId);
                                                break;
                                            case "rotate-90":
                                                status = gdPictureImaging.RotateAngle(imageId, 270);
                                                break;
                                            case "rotate+90":
                                                status = gdPictureImaging.RotateAngle(imageId, 90);
                                                break;
                                        }
                                        if (status != GdPictureStatus.OK)
                                        {
                                            e.message = GetErrorMessage("Error during apply filter: " + status + " on page " + page);
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        e.message = GetErrorMessage("Error during page selection: " + status + ".");
                                        break;
                                    }
                                }
                                if (status == GdPictureStatus.OK)
                                {
                                    status = e.docuVieware.RedrawPages(cleanupParameters.Pages);
                                    e.message = status == GdPictureStatus.OK ? new DocuViewareMessage("Filter successfuly applied.", icon: DocuViewareMessageIcon.Ok) : GetErrorMessage("Error during redraw pages : " + status + ".");
                                }
                            }
                            else
                            {
                                e.message = GetErrorMessage("Your image must be 1 bit-depth to apply this filter!");
                            }
                        }
                    }
                    else
                    {
                        e.message = GetErrorMessage("Error during get native image : " + status + ".");
                    }
                }
                else
                {
                    e.message = GetErrorMessage("Only raster formats are supported!");
                }
            }
            else
            {
                e.message = GetErrorMessage("Please open an image first." + ".");
            }
        }
    }
}
