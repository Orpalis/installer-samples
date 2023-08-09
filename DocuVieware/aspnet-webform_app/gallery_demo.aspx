<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="gallery_demo.aspx.cs" Inherits="DocuVieware_webform_app_demo.GalleryDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head>
    <title>DocuVieware - Gallery Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />
    <link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="style/gallery.css" rel="stylesheet" type="text/css" />
    <script src="js/gallery.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="gallery">
            <div id="gallery_icon_container">
                <div id="gallery_icon">
                    <svg height="100%" width="100%" viewBox="0 0 512 512">
                        <path d="M382.5,139.5v-70h-62v-69h-261v372h62v70h70v70h261v-373H382.5z M81.5,350.5v-328h216v328H81.5z M144.5,420.5v-48h176v-280 h40v328H144.5z M430.5,489.5h-216v-47h168v-281h48V489.5z" />
                        <rect x="104.5" y="194.5" width="168" height="23" />
                        <rect x="103.5" y="243.5" width="168" height="23" />
                        <rect x="104.5" y="292.5" width="84" height="23" />
                        <path d="M104.5,50.5v117h168v-117H104.5z M250.5,146.5h-123v-73h123V146.5z" />
                    </svg>
                </div>
                <span id="gallery_header_title">Document Gallery</span>
            </div>
            <div id="gallery_panel_content">
                <div id="gallery_container" runat="server"></div>
            </div>
        </div>
        <div id="viewer_container">
            <cc1:DocuVieware ID="DocuVieware1" runat="server"
                Height="100%"
                Width="100%"
                SinglePageView="False"
                ForceScrollBars="False"
                AllowedExportFormats="*"
                EnableFileUploadButton="False"
                EnableLoadFromUriButton="False"
                DocumentAlignment="DocumentAlignmentTopLeft"
                EnableMultipleThumbnailSelection="True"
                EnableMouseModeButtons="False"
                EnableTwainAcquisitionButton="False"
                EnableFormFieldsEdition="False" />
        </div>
    </form>
</body>
</html>
