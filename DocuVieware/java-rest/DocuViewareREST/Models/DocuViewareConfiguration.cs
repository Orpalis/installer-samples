namespace DocuViewareREST.Models
{
    /// <summary>
    /// This is the description of the configuration we will be sending from client
    /// </summary>
    public class DocuViewareConfiguration
    {
        public string SessionId;
        public string ControlId;
        public bool AllowPrint;
        public bool EnablePrintButton;
        public bool AllowUpload;
        public bool EnableFileUploadButton;
        public bool CollapsedSnapIn;
        public bool ShowAnnotationsSnapIn;
        public bool EnableRotateButtons;
        public bool EnableZoomButtons;
        public bool EnablePageViewButtons;
        public bool EnableMultipleThumbnailSelection;
        public bool EnableMouseModeButtons;
        public bool EnableFormFieldsEdition;
        public bool EnableTwainAcquisitionButton;
    }
}