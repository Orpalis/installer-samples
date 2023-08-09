using DocuViewareBlazor.Component.Helpers;
using GdPicture14.WEB;

namespace DocuViewareBlazor.Component.Configuration
{
    public class DocuViewareConfiguration
    {
        public string LicenseKey { get; set; } = string.Empty;

        /// <summary>
        /// Set false to use DocuVieware on Servers Farm with non sticky sessions.
        /// </summary>
        public bool StickySession { get; set; } = true;

        /// <summary>
        /// Set DocuViewareSessionStateMode.File if STICKY_SESSION is False.
        /// </summary>
        public DocuViewareSessionStateMode SessionMode { get; set; } = DocuViewareSessionStateMode.InProc;

        public string CacheDirectory { get; set; } = DocuviewareGlobals.GetCacheDirectory();
        /// <summary>
        /// Set to 20 minutes. use -1 to handle DocuVieware session timeout through asp.net session mechanism.
        /// </summary>
        public int SessionTimeout { get; set; } = 20;

        // Not supported yet, we have to find a way to dynamicly register controller at runtime with custom routes
        // so internal for now
        internal string ControllerRoute { get; set; } = "api/docuvieware3";
        public string ApplicationURI { get; set; } = "/";
    }
}
