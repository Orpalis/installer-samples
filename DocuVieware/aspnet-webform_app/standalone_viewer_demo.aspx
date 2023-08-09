<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="standalone_viewer_demo.aspx.cs" Inherits="DocuVieware_webform_app_demo.StandaloneViewerDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head>
    <title>DocuVieware - Standalone Viewer Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />
    <link href="style/standalone_viewer.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <cc1:DocuVieware ID="DocuVieware1" runat="server"
            Height="100%"
            Width="100%"
            SinglePageView="False"
            ForceScrollBars="False"
            AllowedExportFormats="*"
            MaxUploadSize="52428800"
            CollapsedSnapIn="True"
            EnableMouseModeButtons="False"
            EnableFormFieldsEdition="True" />
    </form>
</body>
</html>
