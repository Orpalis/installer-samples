using GdPicture14;
using GdPicture14.WEB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace DocuViewareCoreDemo
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Version = DocuViewareManager.GetVersion();
            return View();
        }

        public ActionResult Annotations()
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request); 
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            return View();
        }


        public ActionResult ImageCleanup()
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request);
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            return View();
        }


        public ActionResult Twain()
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request);
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            return View();
        }


        public ActionResult BarcodeRecognition()
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request);
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            BarcodeRecognitionViewModel model = new BarcodeRecognitionViewModel { DocuViewareID = "DocuVieware1" };
            model.SnapInHtmlContent = this.RenderViewAsync("_BarcodeRecognitionSnapIn", model).Result;
            return View(model);
        }

        public ActionResult FormFields()
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request);
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            return View();
        }


        public ActionResult StandaloneViewer()
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request);
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            return View();
        }


        public ActionResult CustomViewer()
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request);
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            ViewBag.CollapsedSnapIn = true;
            ViewBag.SnapInPanelDefaultWidth = 280;
            ViewBag.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopLeft;
            ViewBag.DocumentPosition = ViewerDocumentPosition.DocumentPositionMiddleCenter;
            ViewBag.PagePreload = PagePreloadMode.VisiblePages;
            ViewBag.ViewerRotation = GdPictureRotateFlipType.GdPictureRotateNoneFlipNone;
            ViewBag.ShowThumbnailsSnapin = true;
            ViewBag.EnableMultiselect = true;
            ViewBag.ShowSearchSnapin = true;
            ViewBag.ShowAnnotationsSnapin = true;
            ViewBag.ShowBookmarksSnapin = true;
            ViewBag.ShowToolbar = true;
            ViewBag.ShowUploadButton = true;
            ViewBag.ShowLoadFromURIButton = true;
            ViewBag.ShowSaveButton = true;
            ViewBag.ShowPrintButton = true;
            ViewBag.PrintQuality = GdPicture14.WEB.PrintQuality.Medium;
            ViewBag.ShowPageNavigation = true;
            ViewBag.ShowZoomButtons = true;
            ViewBag.ZoomStep = 25;
            ViewBag.ShowRotate = true;
            ViewBag.ShowPageViewToggle = true;
            ViewBag.ShowFitWidth = true;
            ViewBag.ShowFitPage = true;
            ViewBag.ShowZoom100 = true;
            ViewBag.ShowMouseMode = true;
            ViewBag.ShowFullscreen = true;
            ViewBag.ToolbarHeight = 41;
            ViewBag.ButtonSpacing = 4;
            ViewBag.ToolbarBackColor = "#F2F2F2";
            ViewBag.ViewerBackColor = "#565656";
            ViewBag.StrokeColor = "#646464";
            ViewBag.MiscBorderColor = "#DCDCDC";
            ViewBag.HeaderColor = "#213E4E";
            ViewBag.PanelBackColor = "#FFFFFF";
            ViewBag.ActiveSelectedColor = "#0382D4";
            ViewBag.ControlWidth = 1024;
            ViewBag.ControlHeight = 768;
            ViewBag.ThumbnailsWidth = 192;
            ViewBag.ThumbnailsHeight = 256;
            ViewBag.AnnotationDropShadow = true;
            ViewBag.ContinuousDrawingMode = true;
            ViewBag.EnableRectangleHighlighterAnnotationButton = true;
            ViewBag.EnableFreehandHighlighterAnnotationButton = true;
            ViewBag.EnableRubberStampAnnotationButton = true;
            ViewBag.EnableRectangleAnnotationButton = true;
            ViewBag.EnableEllipseAnnotationButton = true;
            ViewBag.EnableLineAnnotationButton = true;
            ViewBag.EnableConnectedLineAnnotationButton = true;
            ViewBag.EnableFreehandAnnotationButton = true;
            ViewBag.EnableLineArrowAnnotationButton = true;
            ViewBag.EnableRulerAnnotationButton = true;
            ViewBag.EnableTextAnnotationButton = true;
            ViewBag.EnableStickyNoteAnnotationButton = true;
            ViewBag.Version = DocuViewareManager.GetVersion();
            return View();
        }


        [HttpPost]
        public ActionResult CustomViewer(IFormCollection settings)
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request);
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            ViewBag.CollapsedSnapIn = settings["collapsed_snapin"] == "on";
            ViewBag.SnapInPanelDefaultWidth = settings["snapin_width"];
            ViewBag.DocumentAlignment = settings["document_alignement"];
            ViewBag.DocumentPosition = settings["document_position"];
            ViewBag.PagePreload = settings["page_preload"];
            ViewBag.ViewerRotation = settings["viewer_rotation"];
            ViewBag.ShowThumbnailsSnapin = settings["show_thumbnails"] == "on";
            ViewBag.EnableMultiselect = settings["enable_multiple_select"] == "on";
            ViewBag.ShowSearchSnapin = settings["show_search"] == "on";
            ViewBag.ShowAnnotationsSnapin = settings["show_annotations"] == "on";
            ViewBag.ShowBookmarksSnapin = settings["show_bookmarks"] == "on";
            ViewBag.ShowToolbar = settings["show_toolbar"] == "on";
            ViewBag.ShowUploadButton = settings["show_uploadfile"] == "on";
            ViewBag.ShowLoadFromURIButton = settings["show_loadfromuri"] == "on";
            ViewBag.ShowSaveButton = settings["show_save"] == "on";
            ViewBag.ShowPrintButton = settings["show_print"] == "on";
            ViewBag.PrintQuality = settings["print_quality"];
            ViewBag.ShowPageNavigation = settings["show_page_nav"] == "on";
            ViewBag.ShowZoomButtons = settings["show_zoom"] == "on";
            ViewBag.ZoomStep = settings["zoom_step"];
            ViewBag.ShowRotate = settings["show_rotate"] == "on";
            ViewBag.ShowPageViewToggle = settings["show_single_page"] == "on";
            ViewBag.ShowFitWidth = settings["show_fit_width"] == "on";
            ViewBag.ShowFitPage = settings["show_fit_page"] == "on";
            ViewBag.ShowZoom100 = settings["show_zoom_100"] == "on";
            ViewBag.ShowMouseMode = settings["show_mouse_mode"] == "on";
            ViewBag.ShowFullscreen = settings["show_fullscreen"] == "on";
            ViewBag.ToolbarHeight = settings["toolbar_height"];
            ViewBag.ButtonSpacing = settings["toolbar_button_spacing"];
            ViewBag.ToolbarBackColor = settings["toolbar_backcolor"];
            ViewBag.ViewerBackColor = settings["viewer_backcolor"];
            ViewBag.StrokeColor = settings["stroke_color"];
            ViewBag.MiscBorderColor = settings["misc_border_color"];
            ViewBag.HeaderColor = settings["header_color"];
            ViewBag.PanelBackColor = settings["panel_backcolor"];
            ViewBag.ActiveSelectedColor = settings["active_selected_color"];
            ViewBag.ControlWidth = settings["control_width"];
            ViewBag.ControlHeight = settings["control_height"];
            ViewBag.ThumbnailsWidth = settings["thumbnail_width"];
            ViewBag.ThumbnailsHeight = settings["thumbnail_height"];
            ViewBag.AnnotationDropShadow = settings["annotation_drop_shadow"] == "on";
            ViewBag.ContinuousDrawingMode = settings["annotation_continious_mode"] == "on";
            ViewBag.EnableRectangleHighlighterAnnotationButton = settings["annotation_highlighter"] == "on";
            ViewBag.EnableFreehandHighlighterAnnotationButton = settings["annotation_freehand_highlighter"] == "on";
            ViewBag.EnableRubberStampAnnotationButton = settings["annotation_rubber_stamp"] == "on";
            ViewBag.EnableRectangleAnnotationButton = settings["annotation_rectangle"] == "on";
            ViewBag.EnableEllipseAnnotationButton = settings["annotation_cricle"] == "on";
            ViewBag.EnableLineAnnotationButton = settings["annotation_line"] == "on";
            ViewBag.EnableConnectedLineAnnotationButton = settings["annotation_connected_line"] == "on";
            ViewBag.EnableFreehandAnnotationButton = settings["annotation_freehand"] == "on";
            ViewBag.EnableLineArrowAnnotationButton = settings["annotation_arrow"] == "on";
            ViewBag.EnableRulerAnnotationButton = settings["annotation_ruler"] == "on";
            ViewBag.EnableTextAnnotationButton = settings["annotation_text"] == "on";
            ViewBag.EnableStickyNoteAnnotationButton = settings["annotation_stickynote"] == "on";
            ViewBag.Version = DocuViewareManager.GetVersion();
            return View();
        }


        public ActionResult CustomToolbar()
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request);
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            ViewBag.Version = DocuViewareManager.GetVersion();
            return View();
        }


        public ActionResult BlogIntegration()
        {
            ViewBag.Locale = Globals.GetDocuViewareLocale(HttpContext.Request);
            ViewBag.SessionID = Globals.BuildDocuViewareControlSessionID(HttpContext, "DocuVieware1");
            ViewBag.Version = DocuViewareManager.GetVersion();
            return View();
        }
    }
}