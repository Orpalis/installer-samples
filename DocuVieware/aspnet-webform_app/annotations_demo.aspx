<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="annotations_demo.aspx.cs" Inherits="DocuVieware_webform_app_demo.AnnotationsDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head>
    <title>DocuVieware - Annotations Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />
    <link rel="stylesheet" href="style/annotations.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <cc1:DocuVieware ID="DocuVieware1" runat="server"
            Height="100%"
            Width="100%"
            DisableAnnotationDrawingModePanel="true"
            SinglePageView="false"
            ForceScrollBars="False"
            AllowedExportFormats="*"
            MaxUploadSize="52428800"
            EnableMultipleThumbnailSelection="True"
            EnableMouseModeButtons="False"
            EnableTwainAcquisitionButton="False"
            EnableFormFieldsEdition="True" />
    </form>
    <script>
        function RegisterOnNewDocumentLoadedOnDocuViewareAPIReady() {
            if (typeof DocuViewareAPI !== 'undefined' && DocuViewareAPI.IsInitialized('DocuVieware1')) {
                DocuViewareAPI.RegisterOnNewDocumentLoaded('DocuVieware1', function () { DocuViewareAPI.SelectAnnotationsSnapIn('DocuVieware1') });
            }
            else {
                setTimeout(function () { RegisterOnNewDocumentLoadedOnDocuViewareAPIReady() }, 10);
            }
        }
        window.onload = function (e) {
            RegisterOnNewDocumentLoadedOnDocuViewareAPIReady();
        }
    </script>
</body>
</html>
