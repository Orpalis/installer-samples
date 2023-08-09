<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leave_request_approval.aspx.cs" Inherits="DocuVieware_webform_app_demo.LeaveRequestApproval" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head>
    <title>DocuVieware - Document Approval Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />
    <link rel="stylesheet" href="style/leave_request_approval.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <cc1:DocuVieware ID="DocuVieware1" runat="server"
            Height="100%"
            Width="100%"
            AnnotationDropShadow="False"
            FreeHandContinuousDrawingMode="True"
            DisableAnnotationDrawingModePanel="True" />
    </form>
    <script>
        // This function is called upon "Marker" button click
        function blueMarkerAnnotation() {
            var annotationAppearance = {
                borderWidth: 0.06,
                dashStyle: 0,
                dashCap: 0,
                opacity: 0.9,
                strokeColor: "#104293"
            };
            DocuViewareAPI.AddFreeHandAnnotInteractive("DocuVieware1", annotationAppearance, false);
        }
        // This function is called upon "Timestamp" button click
        function addTimestamp() {
            DocuViewareAPI.PostCustomServerAction("DocuVieware1", true, "addTimestamp");
        }
        // This function is called upon "Signature" button click
        function addSignature() {
            DocuViewareAPI.PostCustomServerAction("DocuVieware1", true, "addSignature");
        }
        // This function is called on window.load event
        function RegisterOnNewDocumentLoadedOnDocuViewareAPIReady() {
            if (typeof DocuViewareAPI !== "undefined" && DocuViewareAPI.IsInitialized("DocuVieware1")) {
                DocuViewareAPI.RegisterOnNewDocumentLoaded("DocuVieware1", function () {
                    DocuViewareAPI.SelectSnapIn("DocuVieware1", "LeaveRequestApprovalSnapIn");
                });
            }
            else {
                setTimeout(function () { RegisterOnNewDocumentLoadedOnDocuViewareAPIReady() }, 10);
            }
        }
        window.onload = function () {
            RegisterOnNewDocumentLoadedOnDocuViewareAPIReady();
        }
    </script>
</body>
</html>
