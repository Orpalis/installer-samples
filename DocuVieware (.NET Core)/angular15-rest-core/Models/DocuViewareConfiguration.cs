namespace angular15_rest_core.Models
{
    /// <summary>
    /// This is the description of the configuration we will be sending from client
    /// </summary>
    public class DocuViewareConfiguration
    {
        public string SessionId { get; set; }
        public string ControlId { get; set; }
        public bool AllowPrint { get; set; }
        public bool EnablePrintButton { get; set; }
        public bool AllowUpload { get; set; }
        public bool EnableFileUploadButton { get; set; }
        public bool CollapsedSnapIn { get; set; }
        public bool ShowAnnotationsSnapIn { get; set; }
        public bool EnableRotateButtons { get; set; }
        public bool EnableZoomButtons { get; set; }
        public bool EnablePageViewButtons { get; set; }
        public bool EnableMultipleThumbnailSelection { get; set; }
        public bool EnableMouseModeButtons { get; set; }
        public bool EnableFormFieldsEdition { get; set; }
        public bool EnableTwainAcquisitionButton { get; set; }
    }
}
