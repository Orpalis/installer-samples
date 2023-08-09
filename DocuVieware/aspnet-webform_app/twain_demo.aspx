<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="twain_demo.aspx.cs" Inherits="DocuVieware_webform_app_demo.TwainAcquisitionDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head>
    <title>DocuVieware - TWAIN Acquisition Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />
    <link href="style/twain_acquisition.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="information_container">
            <!-- Demo explanations -->
            <p>
                TWAIN acquisition can be done from the dedicated snap-in but also from a dialog window triggered by a dedicated toolbar button.<br />
                This demo application shows both options.
            </p>
            <p>The very first time, DocuVieware will require the installation of a small software to connect to the TWAIN devices. This is a one-time step, once it has been installed it is silently started with Windows.</p>
            <p>DocuVieware will then be able to trigger the device driver window so you can choose the acquisition settings you need.</p>
            <p>Once the acquisition process is complete, you can handle the document like any other supported document format and click the "Generate PDF" button to download the resulat as a PDF/A-1b standard compliant document allowing long term archiving.</p>
        </div>
        <div id="application_container">
            <div id="toolbar_container">
                <!-- Toolbar -->
                <asp:Button ID="btnGeneratePdf" OnClick="btnGeneratePdf_Click" runat="server" Text="Generate PDF/A" />
            </div>
            <div id="viewer_container">
                <cc1:DocuVieware ID="DocuVieware1" runat="server"
                    Height="100%"
                    Width="100%"
                    SinglePageView="False"
                    ForceScrollBars="False"
                    AllowedExportFormats="*"
                    MaxUploadSize="52428800"
                    CollapsedSnapIn="True"
                    EnableMouseModeButtons="False"
                    EnableFileUploadButton="False"
                    EnableLoadFromUriButton="False"
                    EnablePrintButton="True"
                    EnableSaveButton="True"
                    ShowThumbnailsSnapIn="True"
                    ShowBookmarksSnapIn="False"
                    ShowTextSearchSnapIn="False"
                    ShowAnnotationsSnapIn="True"
                    EnableTwainAcquisitionButton="True"
                    EnableThumbnailDragDrop="True" />
            </div>
        </div>
    </form>
</body>
</html>
