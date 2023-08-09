using GdPicture14.WEB;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using GdPicture14;
using PrintQuality = GdPicture14.WEB.PrintQuality;

namespace DocuVieware_webform_app_demo
{
    public partial class CustomViewerDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DocuVieware1.Timeout = Global.SESSION_TIMEOUT;

            if (!IsPostBack)
            {
                collapsed_snapin.Checked = DocuVieware1.CollapsedSnapIn;
                snapin_width.Text = Regex.Replace(DocuVieware1.SnapInPanelDefaultWidth.ToString(), "[^0-9]", "");
                switch (DocuVieware1.DocumentAlignment)
                {
                    case ViewerDocumentAlignment.DocumentAlignmentBottomCenter:
                        document_alignement.SelectedIndex = 0;
                        break;
                    case ViewerDocumentAlignment.DocumentAlignmentBottomLeft:
                        document_alignement.SelectedIndex = 1;
                        break;
                    case ViewerDocumentAlignment.DocumentAlignmentBottomRight:
                        document_alignement.SelectedIndex = 2;
                        break;
                    case ViewerDocumentAlignment.DocumentAlignmentMiddleCenter:
                        document_alignement.SelectedIndex = 3;
                        break;
                    case ViewerDocumentAlignment.DocumentAlignmentMiddleLeft:
                        document_alignement.SelectedIndex = 4;
                        break;
                    case ViewerDocumentAlignment.DocumentAlignmentMiddleRight:
                        document_alignement.SelectedIndex = 5;
                        break;
                    case ViewerDocumentAlignment.DocumentAlignmentTopCenter:
                        document_alignement.SelectedIndex = 6;
                        break;
                    case ViewerDocumentAlignment.DocumentAlignmentTopLeft:
                        document_alignement.SelectedIndex = 7;
                        break;
                    case ViewerDocumentAlignment.DocumentAlignmentTopRight:
                        document_alignement.SelectedIndex = 8;
                        break;
                }
                if (DocuVieware1.SinglePageView)
                {
                    switch (DocuVieware1.DocumentPosition)
                    {
                        case ViewerDocumentPosition.DocumentPositionBottomCenter:
                            document_position.SelectedIndex = 0;
                            break;
                        case ViewerDocumentPosition.DocumentPositionBottomLeft:
                            document_position.SelectedIndex = 1;
                            break;
                        case ViewerDocumentPosition.DocumentPositionBottomRight:
                            document_position.SelectedIndex = 2;
                            break;
                        case ViewerDocumentPosition.DocumentPositionMiddleCenter:
                            document_position.SelectedIndex = 3;
                            break;
                        case ViewerDocumentPosition.DocumentPositionMiddleLeft:
                            document_position.SelectedIndex = 4;
                            break;
                        case ViewerDocumentPosition.DocumentPositionMiddleRight:
                            document_position.SelectedIndex = 5;
                            break;
                        case ViewerDocumentPosition.DocumentPositionTopCenter:
                            document_position.SelectedIndex = 6;
                            break;
                        case ViewerDocumentPosition.DocumentPositionTopLeft:
                            document_position.SelectedIndex = 7;
                            break;
                        case ViewerDocumentPosition.DocumentPositionTopRight:
                            document_position.SelectedIndex = 8;
                            break;
                    }
                }
                else //Only ViewerDocumentPosition.DocumentPositionMiddleCenter is supported when SinglePageView is False
                {
                    document_position.SelectedIndex = 3;
                }
                switch (DocuVieware1.PagePreload)
                {
                    case PagePreloadMode.AdjacentPages:
                        page_preload.SelectedIndex = 0;
                        break;
                    case PagePreloadMode.AllPages:
                        page_preload.SelectedIndex = 1;
                        break;
                    case PagePreloadMode.VisiblePages:
                        page_preload.SelectedIndex = 2;
                        break;
                }
                switch (DocuVieware1.ViewRotation)
                {
                    case GdPictureRotateFlipType.GdPictureRotate180FlipNone:
                        viewer_rotation.SelectedIndex = 0;
                        break;
                    case GdPictureRotateFlipType.GdPictureRotate270FlipNone:
                        viewer_rotation.SelectedIndex = 1;
                        break;
                    case GdPictureRotateFlipType.GdPictureRotate90FlipNone:
                        viewer_rotation.SelectedIndex = 2;
                        break;
                    case GdPictureRotateFlipType.GdPictureRotateNoneFlipNone:
                        viewer_rotation.SelectedIndex = 3;
                        break;
                    case GdPictureRotateFlipType.GdPictureRotateNoneFlipX:
                        viewer_rotation.SelectedIndex = 4;
                        break;
                    case GdPictureRotateFlipType.GdPictureRotateNoneFlipY:
                        viewer_rotation.SelectedIndex = 5;
                        break;
                }
                control_height.Text = Regex.Replace(DocuVieware1.Height.ToString(), "[^0-9]", "");
                control_width.Text = Regex.Replace(DocuVieware1.Width.ToString(), "[^0-9]", "");
                show_toolbar.Checked = DocuVieware1.ShowToolbar;
                show_thumbnails.Checked = DocuVieware1.ShowThumbnailsSnapIn;
                enable_multiple_select.Checked = DocuVieware1.EnableMultipleThumbnailSelection;
                show_annotations.Checked = DocuVieware1.ShowAnnotationsSnapIn;
                show_bookmarks.Checked = DocuVieware1.ShowBookmarksSnapIn;
                show_search.Checked = DocuVieware1.ShowTextSearchSnapIn;
                stroke_color.Value = ColorTranslator.ToHtml(DocuVieware1.StrokeColor);
                toolbar_backcolor.Value = ColorTranslator.ToHtml(DocuVieware1.ToolbarBackColor);
                viewer_backcolor.Value = ColorTranslator.ToHtml(DocuVieware1.ViewerBackColor);
                misc_border_color.Value = ColorTranslator.ToHtml(DocuVieware1.MiscBorderColor);
                header_color.Value = ColorTranslator.ToHtml(DocuVieware1.HeaderColor);
                panel_backcolor.Value = ColorTranslator.ToHtml(DocuVieware1.PanelBackColor);
                active_selected_color.Value = ColorTranslator.ToHtml(DocuVieware1.ActiveSelectedColor);
                thumbnail_height.Text = DocuVieware1.ThumbnailHeight.ToString();
                thumbnail_width.Text = DocuVieware1.ThumbnailWidth.ToString();
                show_uploadfile.Checked = DocuVieware1.EnableFileUploadButton;
                show_save.Checked = DocuVieware1.EnableSaveButton;
                show_loadfromuri.Checked = DocuVieware1.EnableLoadFromUriButton;
                show_print.Checked = DocuVieware1.EnablePrintButton;
                switch (DocuVieware1.PrintQuality)
                {
                    case PrintQuality.High:
                        print_quality.SelectedIndex = 0;
                        break;
                    case PrintQuality.Low:
                        print_quality.SelectedIndex = 1;
                        break;
                    case PrintQuality.Medium:
                        print_quality.SelectedIndex = 2;
                        break;
                    case PrintQuality.VeryHigh:
                        print_quality.SelectedIndex = 3;
                        break;
                }
                show_page_nav.Checked = DocuVieware1.EnablePagesNavigationButtons;
                show_zoom.Checked = DocuVieware1.EnableZoomButtons;
                zoom_step.Text = Regex.Replace(DocuVieware1.ZoomStep.ToString(), "[^0-9]", "");
                show_rotate.Checked = DocuVieware1.EnableRotateButtons;
                show_single_page.Checked = DocuVieware1.EnablePageViewButtons;
                show_fit_width.Checked = DocuVieware1.EnableFitWidthButton;
                show_fit_page.Checked = DocuVieware1.EnableFitPageButton;
                show_zoom_100.Checked = DocuVieware1.EnableZoom100Button;
                show_mouse_mode.Checked = DocuVieware1.EnableMouseModeButtons;
                show_fullscreen.Checked = DocuVieware1.EnableFullScreenButton;
                toolbar_height.Text = DocuVieware1.ToolbarHeight.ToString();
                toolbar_button_spacing.Text = DocuVieware1.ToolbarButtonsSpacing.ToString();
                annotation_drop_shadow.Checked = DocuVieware1.AnnotationDropShadow;
                annotation_continious_mode.Checked = DocuVieware1.FreeHandContinuousDrawingMode;
                annotation_highlighter.Checked = DocuVieware1.EnableRectangleHighlighterAnnotationButton;
                annotation_freehand_highlighter.Checked = DocuVieware1.EnableFreehandHighlighterAnnotationButton;
                annotation_rubber_stamp.Checked = DocuVieware1.EnableRubberStampAnnotationButton;
                annotation_rectangle.Checked = DocuVieware1.EnableRectangleAnnotationButton;
                annotation_cricle.Checked = DocuVieware1.EnableEllipseAnnotationButton;
                annotation_line.Checked = DocuVieware1.EnableLineAnnotationButton;
                annotation_connected_line.Checked = DocuVieware1.EnableConnectedLineAnnotationButton;
                annotation_freehand.Checked = DocuVieware1.EnableFreehandAnnotationButton;
                annotation_arrow.Checked = DocuVieware1.EnableLineArrowAnnotationButton;
                annotation_ruler.Checked = DocuVieware1.EnableRulerAnnotationButton;
                annotation_text.Checked = DocuVieware1.EnableTextAnnotationButton;
                annotation_stickynote.Checked = DocuVieware1.EnableStickyNoteAnnotationButton;
            }
            dvVersion.Text = DocuViewareManager.GetVersion();
        }

        protected void submitLayout_Click(object sender, EventArgs e)
        {
            DocuVieware1.CollapsedSnapIn = collapsed_snapin.Checked;
            DocuVieware1.SnapInPanelDefaultWidth = Convert.ToInt32(snapin_width.Text);
            switch (document_alignement.SelectedIndex)
            {
                case 0:
                    DocuVieware1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentBottomCenter;
                    break;
                case 1:
                    DocuVieware1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentBottomLeft;
                    break;
                case 2:
                    DocuVieware1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentBottomRight;
                    break;
                case 3:
                    DocuVieware1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
                    break;
                case 4:
                    DocuVieware1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentMiddleLeft;
                    break;
                case 5:
                    DocuVieware1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentMiddleRight;
                    break;
                case 6:
                    DocuVieware1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter;
                    break;
                case 7:
                    DocuVieware1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopLeft;
                    break;
                case 8:
                    DocuVieware1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopRight;
                    break;
            }
            if (DocuVieware1.SinglePageView)
            {
                switch (document_position.SelectedIndex)
                {
                    case 0:
                        DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionBottomCenter;
                        break;
                    case 1:
                        DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionBottomLeft;
                        break;
                    case 2:
                        DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionBottomRight;
                        break;
                    case 3:
                        DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionMiddleCenter;
                        break;
                    case 4:
                        DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionMiddleLeft;
                        break;
                    case 5:
                        DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionMiddleRight;
                        break;
                    case 6:
                        DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionTopCenter;
                        break;
                    case 7:
                        DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionTopLeft;
                        break;
                    case 8:
                        DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionTopRight;
                        break;
                }
            }
            else //Only ViewerDocumentPosition.DocumentPositionMiddleCenter is supported when SinglePageView is False
            {
                DocuVieware1.DocumentPosition = ViewerDocumentPosition.DocumentPositionMiddleCenter;
            }
            switch (page_preload.SelectedIndex)
            {
                case 0:
                    DocuVieware1.PagePreload = PagePreloadMode.AdjacentPages;
                    break;
                case 1:
                    DocuVieware1.PagePreload = PagePreloadMode.AllPages;
                    break;
                case 2:
                    DocuVieware1.PagePreload = PagePreloadMode.VisiblePages;
                    break;
            }
            switch (viewer_rotation.SelectedIndex)
            {
                case 0:
                    DocuVieware1.ViewRotation = GdPictureRotateFlipType.GdPictureRotate180FlipNone;
                    break;
                case 1:
                    DocuVieware1.ViewRotation = GdPictureRotateFlipType.GdPictureRotate270FlipNone;
                    break;
                case 2:
                    DocuVieware1.ViewRotation = GdPictureRotateFlipType.GdPictureRotate90FlipNone;
                    break;
                case 3:
                    DocuVieware1.ViewRotation = GdPictureRotateFlipType.GdPictureRotateNoneFlipNone;
                    break;
                case 4:
                    DocuVieware1.ViewRotation = GdPictureRotateFlipType.GdPictureRotateNoneFlipX;
                    break;
                case 5:
                    DocuVieware1.ViewRotation = GdPictureRotateFlipType.GdPictureRotateNoneFlipY;
                    break;
            }
            DocuVieware1.Height = Convert.ToInt32(control_height.Text);
            DocuVieware1.Width = Convert.ToInt32(control_width.Text);
            DocuVieware1.ShowToolbar = show_toolbar.Checked;
            DocuVieware1.ShowThumbnailsSnapIn = show_thumbnails.Checked;
            DocuVieware1.EnableMultipleThumbnailSelection = enable_multiple_select.Checked;
            DocuVieware1.ShowTextSearchSnapIn = show_search.Checked;
            DocuVieware1.ShowBookmarksSnapIn = show_bookmarks.Checked;
            DocuVieware1.ShowAnnotationsSnapIn = show_annotations.Checked;
            DocuVieware1.StrokeColor = ColorTranslator.FromHtml(stroke_color.Value);
            DocuVieware1.ToolbarBackColor = ColorTranslator.FromHtml(toolbar_backcolor.Value);
            DocuVieware1.ViewerBackColor = ColorTranslator.FromHtml(viewer_backcolor.Value);
            DocuVieware1.MiscBorderColor = ColorTranslator.FromHtml(misc_border_color.Value);
            DocuVieware1.HeaderColor = ColorTranslator.FromHtml(header_color.Value);
            DocuVieware1.PanelBackColor = ColorTranslator.FromHtml(panel_backcolor.Value);
            DocuVieware1.ActiveSelectedColor = ColorTranslator.FromHtml(active_selected_color.Value);
            DocuVieware1.ThumbnailHeight = Convert.ToInt32(thumbnail_height.Text);
            DocuVieware1.ThumbnailWidth = Convert.ToInt32(thumbnail_width.Text);
            DocuVieware1.EnableFileUploadButton = show_uploadfile.Checked;
            DocuVieware1.EnableLoadFromUriButton = show_loadfromuri.Checked;
            DocuVieware1.EnableSaveButton = show_save.Checked;
            DocuVieware1.EnablePrintButton = show_print.Checked;
            switch (print_quality.SelectedIndex)
            {
                case 0:
                    DocuVieware1.PrintQuality = PrintQuality.High;
                    break;
                case 1:
                    DocuVieware1.PrintQuality = PrintQuality.Low;
                    break;
                case 2:
                    DocuVieware1.PrintQuality = PrintQuality.Medium;
                    break;
                case 3:
                    DocuVieware1.PrintQuality = PrintQuality.VeryHigh;
                    break;
            }
            DocuVieware1.EnablePagesNavigationButtons = show_page_nav.Checked;
            DocuVieware1.EnableZoomButtons = show_zoom.Checked;
            DocuVieware1.ZoomStep = Convert.ToInt32(zoom_step.Text);
            DocuVieware1.EnableRotateButtons = show_rotate.Checked;
            DocuVieware1.EnablePageViewButtons = show_single_page.Checked;
            DocuVieware1.EnableFitWidthButton = show_fit_width.Checked;
            DocuVieware1.EnableFitPageButton = show_fit_page.Checked;
            DocuVieware1.EnableZoom100Button = show_zoom_100.Checked;
            DocuVieware1.EnableMouseModeButtons = show_mouse_mode.Checked;
            DocuVieware1.EnableFullScreenButton = show_fullscreen.Checked;
            if (Convert.ToInt32(toolbar_height.Text) < 48)
            {
                toolbar_height.Text = "48";
            }
            DocuVieware1.ToolbarHeight = Convert.ToInt32(toolbar_height.Text);
            DocuVieware1.ToolbarButtonsSpacing = Convert.ToInt32(toolbar_button_spacing.Text);
            DocuVieware1.AnnotationDropShadow = annotation_drop_shadow.Checked;
            DocuVieware1.FreeHandContinuousDrawingMode = annotation_continious_mode.Checked;
            DocuVieware1.EnableRectangleHighlighterAnnotationButton = annotation_highlighter.Checked;
            DocuVieware1.EnableFreehandHighlighterAnnotationButton = annotation_freehand_highlighter.Checked;
            DocuVieware1.EnableRubberStampAnnotationButton = annotation_rubber_stamp.Checked;
            DocuVieware1.EnableRectangleAnnotationButton = annotation_rectangle.Checked;
            DocuVieware1.EnableEllipseAnnotationButton = annotation_cricle.Checked;
            DocuVieware1.EnableLineAnnotationButton = annotation_line.Checked;
            DocuVieware1.EnableConnectedLineAnnotationButton = annotation_connected_line.Checked;
            DocuVieware1.EnableFreehandAnnotationButton = annotation_freehand.Checked;
            DocuVieware1.EnableLineArrowAnnotationButton = annotation_arrow.Checked;
            DocuVieware1.EnableRulerAnnotationButton = annotation_ruler.Checked;
            DocuVieware1.EnableTextAnnotationButton = annotation_text.Checked;
            DocuVieware1.EnableStickyNoteAnnotationButton = annotation_stickynote.Checked;
        }
    }
}