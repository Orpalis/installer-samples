<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="barcode_recognition_demo.aspx.cs" Inherits="DocuVieware_webform_app_demo.BarcodeRecognitionDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>DocuVieware - Online Barcode Recognition Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="favicon.ico" rel="icon" />
    <link rel="stylesheet" href="style/barcode_recognition_demo.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <cc1:DocuVieware ID="DocuVieware1" runat="server"
            Height="100%"
            Width="100%"
            SinglePageView="True"
            ForceScrollBars="False"
            AllowedExportFormats="*"
            MaxUploadSize="52428800"
            CollapsedSnapIn="True"
            ShowAnnotationsSnapIn="True"
            EnableRotateButtons="False"
            EnableMultipleThumbnailSelection="True"
            EnableMouseModeButtons="True"
            EnableTwainAcquisitionButton="True"
            EnableFormFieldsEdition="False" />
    </form>
    <script>
        function barcodeRecognition() {
            var readingParameters = {
                readlinear: document.getElementById("chk-linear").checked,
                readqrcode: document.getElementById("chk-qr").checked,
                readmicroqrcode: document.getElementById("chk-microqr").checked,
                readdatamatrix: document.getElementById("chk-datamatrix").checked,
                readpdf417: document.getElementById("chk-pdf417").checked,
                readaztec: document.getElementById("chk-aztec").checked,
                readmaxicode: document.getElementById("chk-maxicode").checked
            };
            DocuViewareAPI.PostCustomServerAction("DocuVieware1", true, "barcodeRecognition", readingParameters, function (result) {
                var annots = Array();
                for (var i = 0; i < result.length; i++) {
                    var annot = {
                        type: 8,
                        pageNo: DocuViewareAPI.GetCurrentPage("DocuVieware1"),
                        coordinates: {
                            left: result[i].Box.Left,
                            top: result[i].Box.Top,
                            height: result[i].Box.Height,
                            width: result[i].Box.Width
                        },
                        appearance: {
                            fill: true,
                            fillColor: "#FF0000",
                            stroke: true,
                            strokeColor: "#000000",
                            foreColor: "#000000",
                            fontSize: result[i].Box.Width * 5,
                            text: result[i].Symbology + ": " + result[i].Data,
                            opacity: 0.75
                        }
                    };
                    annots.push(annot);
                }
                DocuViewareAPI.AddAnnot("DocuVieware1", annots);
            });
        }
        function RegisterOnNewDocumentLoadedOnDocuViewareAPIReady() {
            if (typeof DocuViewareAPI !== "undefined" && DocuViewareAPI.IsInitialized("DocuVieware1")) {
                DocuViewareAPI.RegisterOnNewDocumentLoaded("DocuVieware1", function () {
                    DocuViewareAPI.SelectSnapIn("DocuVieware1", "barcodeRecognition");
                });
            }
            else {
                setTimeout(function () { RegisterOnNewDocumentLoadedOnDocuViewareAPIReady() }, 10);
            }
        }
        document.addEventListener("DOMContentLoaded", function () {
            RegisterOnNewDocumentLoadedOnDocuViewareAPIReady();
        }, false);
    </script>
</body>
</html>
