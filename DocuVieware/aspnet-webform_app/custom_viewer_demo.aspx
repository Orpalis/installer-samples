<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="custom_viewer_demo.aspx.cs" Inherits="DocuVieware_webform_app_demo.CustomViewerDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head>
    <title>DocuVieware - Custom Viewer Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />

    <link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="style/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="style/colpick.css" rel="stylesheet" type="text/css" />
    <link href="style/custom_viewer.css" rel="stylesheet" type="text/css" />

    <script src="js/jquery-3.1.0.min.js"></script>
    <script src="js/jquery-ui-1.12.0.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/colpick.js"></script>
    <script src="js/custom_viewer.js"></script>
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
                Custom Viewer Demo • Version:
                <asp:Label ID="dvVersion" runat="server" Text="[VERSION]"></asp:Label>
            </p>
        </div>
    </div>
    <form id="form1" runat="server">
        <nav id="navigation" role="navigation">
            <div class="toggle-button navigation-close">
                <i>
                    <svg width="24" height="24" viewBox="0 0 512 512">
                        <path d="M 257.54,64.00C 92.994,64.00,0.00,173.352,0.00,253.347c0.00,121.887, 109.354,190.477, 200.308,212.956 C 291.27,488.791, 325.48,447.538, 324.022,400.00c-1.771-57.75, 27.073-58.496, 47.52-56.459C 391.973,345.592, 512.00,373.305, 512.00,281.326 C 512.00,167.50, 422.072,64.00, 257.54,64.00z M 224.00,96.00c 17.673,0.00, 32.00,14.327, 32.00,32.00s-14.327,32.00-32.00,32.00s-32.00-14.327-32.00-32.00S 206.327,96.00, 224.00,96.00z M 80.00,288.246c-8.973,0.00-16.246-7.273-16.246-16.246S 71.027,255.754, 80.00,255.754S 96.246,263.027, 96.246,272.00S 88.973,288.246, 80.00,288.246z M 128.00,224.00c-17.673,0.00-32.00-14.327-32.00-32.00s 14.327-32.00, 32.00-32.00s 32.00,14.327, 32.00,32.00S 145.673,224.00, 128.00,224.00z M 256.00,352.00c-35.346,0.00-64.00-21.49-64.00-48.00 s 28.654-48.00, 64.00-48.00c 35.347,0.00, 64.00,21.49, 64.00,48.00S 291.347,352.00, 256.00,352.00z M 368.00,224.00c-26.51,0.00-48.00-21.49-48.00-48.00s 21.49-48.00, 48.00-48.00s 48.00,21.49, 48.00,48.00 S 394.51,224.00, 368.00,224.00z"></path>
                    </svg>
                </i>
            </div>
            <div class="toggle-button navigation-open">
                <i>
                    <svg width="24" height="24" viewBox="0 0 512 512">
                        <path d="M 257.54,64.00C 92.994,64.00,0.00,173.352,0.00,253.347c0.00,121.887, 109.354,190.477, 200.308,212.956 C 291.27,488.791, 325.48,447.538, 324.022,400.00c-1.771-57.75, 27.073-58.496, 47.52-56.459C 391.973,345.592, 512.00,373.305, 512.00,281.326 C 512.00,167.50, 422.072,64.00, 257.54,64.00z M 224.00,96.00c 17.673,0.00, 32.00,14.327, 32.00,32.00s-14.327,32.00-32.00,32.00s-32.00-14.327-32.00-32.00S 206.327,96.00, 224.00,96.00z M 80.00,288.246c-8.973,0.00-16.246-7.273-16.246-16.246S 71.027,255.754, 80.00,255.754S 96.246,263.027, 96.246,272.00S 88.973,288.246, 80.00,288.246z M 128.00,224.00c-17.673,0.00-32.00-14.327-32.00-32.00s 14.327-32.00, 32.00-32.00s 32.00,14.327, 32.00,32.00S 145.673,224.00, 128.00,224.00z M 256.00,352.00c-35.346,0.00-64.00-21.49-64.00-48.00 s 28.654-48.00, 64.00-48.00c 35.347,0.00, 64.00,21.49, 64.00,48.00S 291.347,352.00, 256.00,352.00z M 368.00,224.00c-26.51,0.00-48.00-21.49-48.00-48.00s 21.49-48.00, 48.00-48.00s 48.00,21.49, 48.00,48.00 S 394.51,224.00, 368.00,224.00z"></path>
                    </svg>
                </i>
            </div>
            <div class="pas line" id="container">
                <p class="style-title">Styling Options</p>
                <asp:HiddenField ID="toolbar_backcolor" runat="server" Value="#F2F2F2" />
                <asp:HiddenField ID="viewer_backcolor" runat="server" Value="#565656" />
                <asp:HiddenField ID="stroke_color" runat="server" Value="#646464" />
                <asp:HiddenField ID="misc_border_color" runat="server" Value="#DCDCDC" />
                <asp:HiddenField ID="header_color" runat="server" Value="#213E4E" />
                <asp:HiddenField ID="panel_backcolor" runat="server" Value="#FFFFFF" />
                <asp:HiddenField ID="active_selected_color" runat="server" Value="#0382D4" />
                <ul class="nav nav-tabs">
                    <li class="active"><a data-toggle="tab" href="#sectionBehavior">Behavior</a></li>
                    <li><a data-toggle="tab" href="#sectionB">Color & Size</a></li>
                    <li><a data-toggle="tab" href="#sectionA">Elements</a></li>
                    <li><a data-toggle="tab" href="#sectionAnnotations">Annotations</a></li>
                </ul>
                <div class="tab-content">
                    <div id="sectionBehavior" class="tab-pane active">
                        <div class="line mts pts pls spacer">
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="collapsed_snapin" runat="server" Checked="true" />Snap-in collapsed
                                </label>
                            </div>
                            <div class="line">
                                Snap-in&nbsp;width:&nbsp;<asp:TextBox ID="snapin_width" CssClass="input_dimensions input_thumbnail_dimensions" runat="server" MaxLength="3"></asp:TextBox>&nbsp;pixels
                            </div>
                        </div>
                        <div class="line mts pts pls spacer">
                            <div class="line">
                                <label>
                                    Document alignement:
                                        <asp:DropDownList runat="server" ID="document_alignement">
                                            <asp:ListItem Text="Bottom center" Value="9" />
                                            <asp:ListItem Text="Bottom left" Value="7" />
                                            <asp:ListItem Text="Bottom right" Value="8" />
                                            <asp:ListItem Text="Middle center" Value="2" />
                                            <asp:ListItem Text="Middle left" Value="0" />
                                            <asp:ListItem Text="Middle right" Value="1" />
                                            <asp:ListItem Text="Top center" Value="6" />
                                            <asp:ListItem Text="Top left" Value="4" />
                                            <asp:ListItem Text="Top right" Value="5" />
                                        </asp:DropDownList>
                                </label>
                            </div>
                            <div class="line">
                                <label>
                                    Document position:
                                        <asp:DropDownList runat="server" ID="document_position">
                                            <asp:ListItem Text="Bottom center" Value="9" />
                                            <asp:ListItem Text="Bottom left" Value="7" />
                                            <asp:ListItem Text="Bottom right" Value="8" />
                                            <asp:ListItem Text="Middle center" Value="2" />
                                            <asp:ListItem Text="Middle left" Value="0" />
                                            <asp:ListItem Text="Middle right" Value="1" />
                                            <asp:ListItem Text="Top center" Value="6" />
                                            <asp:ListItem Text="Top left" Value="4" />
                                            <asp:ListItem Text="Top right" Value="5" />
                                        </asp:DropDownList>
                                </label>
                            </div>
                        </div>
                        <div class="line mts pts pls spacer">
                            <div class="line">
                                <label>
                                    Page preload mode:
                                        <asp:DropDownList runat="server" ID="page_preload">
                                            <asp:ListItem Text="Adjacent pages" Value="0" />
                                            <asp:ListItem Text="All pages" Value="1" />
                                            <asp:ListItem Text="Visible page" Value="2" />
                                        </asp:DropDownList>
                                </label>
                            </div>
                        </div>
                        <div class="line mts pts pls spacer">
                            <div class="line">
                                <label>
                                    Viewer rotation:
                                        <asp:DropDownList runat="server" ID="viewer_rotation">
                                            <asp:ListItem Text="180°" Value="0" />
                                            <asp:ListItem Text="270°" Value="1" />
                                            <asp:ListItem Text="90°" Value="2" />
                                            <asp:ListItem Text="No rotation flip none" Value="3" />
                                            <asp:ListItem Text="No rotation flip X" Value="4" />
                                            <asp:ListItem Text="No rotation flip Y" Value="5" />
                                        </asp:DropDownList>
                                </label>
                            </div>
                        </div>
                    </div>
                    <div id="sectionA" class="tab-pane">
                        <div class="line mts pts pls spacer">
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="show_thumbnails" runat="server" Checked="true" />Show thumbnails snap-in
                                </label>
                            </div>
                            <div class="line mls" id="enable_multiple_select_div">
                                <label class="mtn">
                                    <asp:CheckBox ID="enable_multiple_select" runat="server" Checked="true" />Enable multiple selection
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="show_search" runat="server" Checked="true" />Show text search snap-in
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="show_annotations" runat="server" Checked="true" />Show annotations snap-in
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="show_bookmarks" runat="server" Checked="true" />Show bookmarks snap-in
                                </label>
                            </div>
                            <div class="line mini-spacer">
                                <label class="mtn">
                                    <asp:CheckBox ID="show_toolbar" runat="server" Checked="true" />Show toolbar
                                </label>
                            </div>
                            <div id="toolbar_buttons" class="mls">
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_uploadfile" runat="server" Checked="true" />Show upload file button
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_loadfromuri" runat="server" Checked="true" />Show load from URI button
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_save" runat="server" Checked="true" />Show save button
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_print" runat="server" Checked="true" />Show print button
                                    </label>
                                </div>
                                <div class="line mls" id="print_quality_div">
                                    <label>
                                        Print quality:
                                        <asp:DropDownList runat="server" ID="print_quality">
                                            <asp:ListItem Text="High" Value="1" />
                                            <asp:ListItem Text="Low" Value="2" />
                                            <asp:ListItem Text="Medium" Value="3" />
                                            <asp:ListItem Text="Very High" Value="4" />
                                        </asp:DropDownList>
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_page_nav" runat="server" Checked="true" />Show pages navigation buttons
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_zoom" runat="server" Checked="true" />Show zoom buttons
                                    </label>
                                </div>
                                <div class="line mls" id="zoom_step_div">
                                    <label>
                                        Zoom step:
                                        <asp:TextBox ID="zoom_step" CssClass="input_dimensions input_control_dimensions" runat="server" MaxLength="3"></asp:TextBox>
                                        %
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_rotate" runat="server" Checked="true" />Show rotate buttons
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_single_page" runat="server" Checked="true" />Show page view toggle button
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_fit_width" runat="server" Checked="true" />Show fit width button
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_fit_page" runat="server" Checked="true" />Show fit page button
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_zoom_100" runat="server" Checked="true" />Show zoom 100% button
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_mouse_mode" runat="server" Checked="true" />Show mouse modes buttons
                                    </label>
                                </div>
                                <div class="line">
                                    <label class="mtn">
                                        <asp:CheckBox ID="show_fullscreen" runat="server" Checked="true" />Show fullscreen button
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="sectionB" class="tab-pane">
                        <div class="line mts pts pls spacer">
                            <div class="line">
                                Toolbar&nbsp;height:&nbsp;<asp:TextBox ID="toolbar_height" CssClass="input_dimensions input_toolbar_dimensions" runat="server" MaxLength="3">41</asp:TextBox>&nbsp;pixels
                            </div>
                            <div class="line mts">
                                Buttons&nbsp;spacing:&nbsp;<asp:TextBox ID="toolbar_button_spacing" CssClass="input_dimensions input_toolbar_dimensions" runat="server" MaxLength="2">4</asp:TextBox>&nbsp;pixels
                            </div>
                        </div>
                        <div class="line mts pts pls spacer">
                            <div class="line" id="toolbar_bgcolor">
                                <div class="color-box start" data-hidden_val="toolbar_backcolor"></div>
                                <div class="mod">Toolbar base color</div>
                            </div>
                            <div class="line">
                                <div class="color-box start" data-hidden_val="viewer_backcolor"></div>
                                <div class="mod">Viewer background color</div>
                            </div>
                            <div class="line">
                                <div class="color-box start" data-hidden_val="stroke_color"></div>
                                <div class="mod">Stroke color</div>
                            </div>
                            <div class="line">
                                <div class="color-box start" data-hidden_val="misc_border_color"></div>
                                <div class="mod">Misc border color</div>
                            </div>
                            <div class="line">
                                <div class="color-box start" data-hidden_val="header_color"></div>
                                <div class="mod">Header color</div>
                            </div>
                            <div class="line">
                                <div class="color-box start" data-hidden_val="panel_backcolor"></div>
                                <div class="mod">Panel backcolor</div>
                            </div>
                            <div class="line">
                                <div class="color-box start" data-hidden_val="active_selected_color"></div>
                                <div class="mod">Active selected color</div>
                            </div>
                        </div>
                        <div class="line mts pts pls spacer">
                            <div class="line">
                                Control&nbsp;size:&nbsp;<asp:TextBox ID="control_width" CssClass="input_dimensions input_control_dimensions" runat="server" MaxLength="4">1024</asp:TextBox>
                                &nbsp;&times;&nbsp;<asp:TextBox ID="control_height" CssClass="input_dimensions input_control_dimensions" runat="server" MaxLength="4">768</asp:TextBox>
                                &nbsp;pixels
                            </div>
                            <div class="line mts" id="thumbnail_dimensions">
                                Thumbnail&nbsp;size:&nbsp;<asp:TextBox ID="thumbnail_width" CssClass="input_dimensions input_thumbnail_dimensions" runat="server" MaxLength="3">256</asp:TextBox>
                                &nbsp;&times;&nbsp;<asp:TextBox ID="thumbnail_height" CssClass="input_dimensions input_thumbnail_dimensions" runat="server" MaxLength="3">256</asp:TextBox>
                                &nbsp;pixels
                            </div>
                        </div>
                    </div>
                    <div id="sectionAnnotations" class="tab-pane">
                        <div class="line mts pts pls spacer">
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_drop_shadow" runat="server" Checked="true" />Annotation drop shadow
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_continious_mode" runat="server" Checked="true" />Freehand continious mode
                                </label>
                            </div>
                            <div class="line spacer">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_highlighter" runat="server" Checked="true" />Show highlighter button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_freehand_highlighter" runat="server" Checked="true" />Show freehand highlighter button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_rubber_stamp" runat="server" Checked="true" />Show rubber stamp button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_rectangle" runat="server" Checked="true" />Show rectangle button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_cricle" runat="server" Checked="true" />Show circle button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_line" runat="server" Checked="true" />Show line button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_connected_line" runat="server" Checked="true" />Show connected line button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_freehand" runat="server" Checked="true" />Show freehand button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_arrow" runat="server" Checked="true" />Show arrow button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_ruler" runat="server" Checked="true" />Show ruler button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_text" runat="server" Checked="true" />Show text button
                                </label>
                            </div>
                            <div class="line">
                                <label class="mtn">
                                    <asp:CheckBox ID="annotation_stickynote" runat="server" Checked="true" />Show sticky note button
                                </label>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="mts line">
                    <asp:Button ID="submitLayout" CssClass="pas w100" Text="Apply" runat="server" OnClick="submitLayout_Click" />
                </div>
            </div>
        </nav>
        <div class="container">
            <cc1:DocuVieware ID="DocuVieware1" runat="server"
                Height="768px"
                Width="1024px"
                EmbedJQuery="False"
                ToolbarBackColor="#FFFFFF"
                CollapsedSnapIn="True"
                EnableMultipleThumbnailSelection="True"
                EnableTwainAcquisitionButton="False"
                EnableFormFieldsEdition="False" />
        </div>
    </form>
</body>

</html>
