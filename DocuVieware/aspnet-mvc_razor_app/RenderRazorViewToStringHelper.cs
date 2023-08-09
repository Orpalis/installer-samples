using System.IO;
using System.Web.Mvc;

namespace aspnet_mvc_razor_app
{
    public static class RenderRazorViewToStringHelper
    {
        public static string RenderRazorViewToString(this Controller controller, string viewName, object model)
        {
            controller.ViewData.Model = model;
            using (StringWriter stringWriter = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext, viewName);
                ViewContext viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, stringWriter);
                viewResult.View.Render(viewContext, stringWriter);
                viewResult.ViewEngine.ReleaseView(controller.ControllerContext, viewResult.View);
                return stringWriter.GetStringBuilder().ToString();
            }
        }
    }
}