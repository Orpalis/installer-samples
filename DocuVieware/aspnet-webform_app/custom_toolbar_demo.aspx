<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="custom_toolbar_demo.aspx.cs" Inherits="DocuVieware_webform_app_demo.CustomToolbarDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head>
    <title>DocuVieware - Custom Toolbar Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />

    <link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="style/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="style/custom_toolbar.css" rel="stylesheet" type="text/css" />

    <script src="js/jquery-3.1.0.min.js"></script>
    <script src="js/jquery-ui-1.12.0.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/custom_toolbar.js"></script>
</head>
<body>
    <div id="header">
        <div id="logo-header">
            <a href="/">
                <img src="img/docuvieware-logo-home-x2.png" width="310" height="50" class="logo" alt="DocuVieware Logo" />
            </a>
        </div>
        <div id="header-desc">
            <h1>Universal HTML5 Viewer and Document Management Kit</h1>
            <p class="version">
                Custom Toolbar Demo • Version:
                <asp:Label ID="dvVersion" runat="server" Text="[VERSION]"></asp:Label>
            </p>
        </div>
    </div>
    <div id="main" class="container" role="main">
        <form id="form1" runat="server">
            <div>
                <div class="dv-viewer">
                    <cc1:DocuVieware ID="DocuVieware1" runat="server"
                        Height="768px"
                        Width="1140px"
                        SinglePageView="False"
                        ToolbarBackColor="#F0F0F0"
                        ShowToolbar="false"
                        ShowThumbnails="false"
                        OpenZoomMode="ZoomModeFitToViewer"
                        EmbedJQuery="false"
                        CollapsedSnapIn="True"
                        EnableMultipleThumbnailSelection="True"
                        EnableMouseModeButtons="False"
                        EnableTwainAcquisitionButton="False"
                        EnableFormFieldsEdition="True" />
                    <div class="toolbar_hover">
                        <div class="toolbar_container">
                            <div class="line" id="document_uri_area">
                                <input id="document_uri" type="text" value="" name="document_uri" class="left" placeholder="Enter document URI..." />
                                <div class="left">
                                    <div id="bt_go" class="uri_item left mls" onclick="loadFromUri();">
                                        <svg viewBox="0 0 512 512">
                                            <path d="M 256.00,0.00C 114.615,0.00,0.00,114.615,0.00,256.00s 114.615,256.00, 256.00,256.00s 256.00-114.615, 256.00-256.00S 397.385,0.00, 256.00,0.00z M 208.00,416.00L 102.00,278.00l 47.00-49.00l 59.00,75.00 l 185.00-151.00l 23.00,23.00L 208.00,416.00z"></path>
                                        </svg>
                                    </div>
                                    <div id="bt_cancel" class="uri_item left mls" onclick="$('#document_uri_area').slideUp();">
                                        <svg viewBox="0 0 512 512">
                                            <path d="M 368.00,0.00L 144.00,0.00 L0.00,144.00l0.00,224.00 l 144.00,144.00l 224.00,0.00 l 144.00-144.00L 512.00,144.00 L 368.00,0.00z M 392.897,368.006l-24.892,24.891c-6.846,6.845-18.046,6.845-24.89,0.00 L 256.00,305.779l-87.115,87.117c-6.845,6.844-18.046,6.844-24.89,0.00l-24.891-24.892c-6.845-6.846-6.845-18.046,0.00-24.89L 206.22,256.00 l-87.116-87.115c-6.845-6.845-6.845-18.046,0.00-24.89l 24.891-24.891c 6.844-6.845, 18.045-6.845, 24.89,0.00L 256.00,206.22l 87.116-87.116 c 6.844-6.845, 18.044-6.845, 24.89,0.00l 24.891,24.891c 6.845,6.844, 6.845,18.045,0.00,24.89L 305.781,256.00l 87.116,87.116 C 399.741,349.96, 399.741,361.16, 392.897,368.006zM 512.00,368.00"></path>
                                        </svg>
                                    </div>
                                </div>
                            </div>
                            <div class="toolbar_buttons">
                                <!-- load from file button -->
                                <div class="toolbar_item" onclick="loadFromFile();">
                                    <svg width="28" height="28" viewBox="0 0 512 512">
                                        <path d="M 480.00,128.00 L 32.00,128.00 L 64.00,64.00 L 240.00,64.00 L 256.00,96.00 L 464.00,96.00 ZM0.00,160.00l 32.00,320.00l 448.00,0.00 l 32.00-320.00L0.00,160.00 z M 288.00,352.00l0.00,95.508 l-64.00,0.00 L 224.00,352.00 L 112.00,352.00 l 144.00-144.00l 144.00,144.00L 288.00,352.00 z"></path>
                                    </svg>
                                </div>
                                <!-- load from uri button -->
                                <div class="toolbar_item" onclick="$('#document_uri_area').slideDown();">
                                    <svg width="28" height="28" viewBox="0 0 512 512">
                                        <path d="M 445.502,180.03C 443.881,115.681, 391.273,64.00, 326.571,64.00c-37.896,0.00-71.633,17.747-93.427,45.366 c-12.221-15.799-31.345-25.98-52.854-25.98c-36.905,0.00-66.821,29.937-66.821,66.861c0.00,3.218, 0.24,6.38, 0.682,9.477 c-5.611-1.012-11.383-1.569-17.285-1.569C 43.367,158.154,0.00,201.548,0.00,255.076C0.00,308.607, 43.367,352.00, 96.865,352.00l 49.88,0.00 L 256.00,461.255 L 365.255,352.00l 59.741,0.00 l0.00-0.006 C 473.065,351.902, 512.00,312.888, 512.00,264.771C 512.00,223.726, 483.661,189.321, 445.502,180.03z M 256.00,416.00l-96.00-96.00 l 64.00,0.00 l0.00-96.00 l 64.00,0.00 l0.00,96.00 l 64.00,0.00 L 256.00,416.00z"></path>
                                    </svg>
                                </div>
                                <!-- print button -->
                                <div class="toolbar_item" id="bt_print" style="display: none;">
                                    <svg width="28" height="28" viewBox="0 0 512 512">
                                        <path d="M 510.225,384.049l-12.449-224.098C 496.799,142.378, 481.60,128.00, 464.00,128.00l-80.00,0.00 L 384.00,0.00 L 128.00,0.00 l0.00,128.00 L 48.00,128.00 c-17.601,0.00-32.799,14.378-33.775,31.951L 1.775,384.049C 0.799,401.622, 14.40,416.00, 32.00,416.00l 70.40,0.00 L 64.00,512.00l 384.00,0.00 l-38.40-96.00L 480.00,416.00 C 497.60,416.00, 511.20,401.622, 510.225,384.049z M 160.00,32.00l 192.00,0.00 l0.00,96.00 L 160.00,128.00 L 160.00,32.00 z M 111.265,480.00l 38.40-96.00l 212.67,0.00 l 38.40,96.00L 111.265,480.00 z M 448.00,224.00l-32.00,0.00 l0.00-64.00 l 32.00,0.00 L 448.00,224.00 z"></path>
                                    </svg>
                                </div>
                                <!-- group separator -->
                                <div class="group_separator"></div>
                                <!-- page previous button -->
                                <div class="toolbar_item" id="bt_select_page_prev" onclick="if(isEnabled($(this))){previousPage()};">
                                    <svg width="28" height="28" viewBox="0 0 512 512">
                                        <path d="M 256.001,0.00L0.00,256.00L 160.00,256.00L 160.00,511.999L 352.00,512.00L 352.00,256.00L 512.00,256.00 z"></path>
                                    </svg>
                                </div>
                                <!-- page next button -->
                                <div class="toolbar_item" id="bt_select_page_next" onclick="if(isEnabled($(this))){nextPage()};">
                                    <svg width="28" height="28" viewBox="0 0 512 512">
                                        <path d="M 256.00,512.00L 512.00,256.00L 352.00,256.00L 352.00,0.001L 160.00,0.00L 160.00,256.00L0.00,256.00 z"></path>
                                    </svg>
                                </div>
                                <!-- page navigation textbox -->
                                <div class="page_navigation">
                                    <input type="text" name="current_page" onchange="changePage(parseInt(this.value));" value="0" />&nbsp;/&nbsp;<span id="sp_page_count">0</span>
                                </div>
                                <!-- group separator -->
                                <div class="group_separator"></div>
                                <!-- zoom out button -->
                                <div class="toolbar_item" id="bt_zoom_out" onclick="if(isEnabled($(this))){zoomOut()};">
                                    <svg width="28" height="28" viewBox="0 0 512 512">
                                        <path d="M0.00,208.00l0.00,96.00 c0.00,8.836, 7.164,16.00, 16.00,16.00l 480.00,0.00 c 8.836,0.00, 16.00-7.164, 16.00-16.00l0.00-96.00 c0.00-8.836-7.164-16.00-16.00-16.00L 16.00,192.00 C 7.164,192.00,0.00,199.164,0.00,208.00z"></path>
                                    </svg>
                                </div>
                                <!-- zoom in button -->
                                <div class="toolbar_item" id="bt_zoom_in" onclick="if(isEnabled($(this))){zoomIn()};">
                                    <svg width="28" height="28" viewBox="0 0 512 512">
                                        <path d="M 496.00,192.00L 320.00,192.00 L 320.00,16.00 c0.00-8.836-7.164-16.00-16.00-16.00l-96.00,0.00 c-8.836,0.00-16.00,7.164-16.00,16.00l0.00,176.00 L 16.00,192.00 c-8.836,0.00-16.00,7.164-16.00,16.00l0.00,96.00 c0.00,8.836, 7.164,16.00, 16.00,16.00l 176.00,0.00 l0.00,176.00 c0.00,8.836, 7.164,16.00, 16.00,16.00l 96.00,0.00 c 8.836,0.00, 16.00-7.164, 16.00-16.00L 320.00,320.00 l 176.00,0.00 c 8.836,0.00, 16.00-7.164, 16.00-16.00l0.00-96.00 C 512.00,199.164, 504.836,192.00, 496.00,192.00z"></path>
                                    </svg>
                                </div>
                                <span class="stretch"></span>
                            </div>
                        </div>
                    </div>
                    <div id="zoom_level">
                        <span id="zoom_level_value"></span>&nbsp;%
                    </div>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
