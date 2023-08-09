<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DocuVieware_webform_app_demo.Default" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>DocuVieware HTML5 Viewer & Document Management Kit - Online Demos.</title>
    <link rel="icon" href="favicon.ico" />

    <link href="style/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="style/styles.css" rel="stylesheet" type="text/css" />
    <link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />

    <script src="js/jquery-3.1.0.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/demo_navigation.js"></script>
</head>
<body>
    <div class="container-fluid header-slider">
        <div id="header">
            <a href="/">
                <img src="img/docuvieware-logo-home-x2.png" width="310" height="50" class="logo" alt="DocuVieware Logo" />
            </a>
            <div id="header-desc">
                <h1>Universal HTML5 Viewer and Document Management Kit</h1>
                <br />
                <p class="version">
                    Online Demo • Version:
                    <asp:Label ID="dvVersion" runat="server" Text="[VERSION]"></asp:Label>
                </p>
            </div>
        </div>
        <!-- slider -->
        <div class="row slider">
            <div class="header-sep">
                <img src="img/header-sep.png" width="30" height="15" alt="View content demos">
            </div>
            <!-- 1 -  ANNOTATIONS -->
            <div id="annotations" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-annotation.png" alt="Annotation" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>Annotations Demo</h1>
                    <p>Add, edit or remove rubber-stamps, sticky notes, freehand, text, redaction and more...</p>
                    <a href="annotations_demo.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /ANNOTATIONS -->

            <!-- 2 - GALLERY -->
            <div id="gallery" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-gallery.png" alt="Gallery Docuvieware" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>Gallery Demo</h1>
                    <p>A gallery of various sample documents that you can view on-the-fly.</p>
                    <a href="gallery_demo.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /GALLERY -->

            <!-- 3 - IMAGE CLEANUP -->
            <div id="image-cleanup" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-cleanup.png" alt="Filters" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>Image Cleanup Demo</h1>
                    <p>Clean your images, remove black borders, punch holes, despeckle, deskew and more.</p>
                    <a href="image_cleanup.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /IMAGE CLEANUP -->

            <!-- 4 - TWAIN -->
            <div id="twain" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-twain.png" alt="TWAIN Acquisition Docuvieware" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>TWAIN Acquisition Demo</h1>
                    <p>Acquire documents from a local TWAIN scanning device.</p>
                    <a href="twain_demo.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /TWAIN -->

            <!-- 5 - BARCODES -->
            <div id="barcodes" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-barcodes.png" alt="Online Barcode Recognition" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>Online Barcode Recognition Demo</h1>
                    <p>Recognize QrCode, Micro QrCode, Datamatrix, PDF417 and linear barcode symbols from PDF and images.</p>
                    <a href="barcode_recognition_demo.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /BARCODES -->

            <!-- 6 - FORM FIELDS -->
            <div id="formfields" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-formfields.png" alt="PDF Form Fields Docuvieware" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>PDF Form Fields Demo</h1>
                    <p>Interact with PDF forms to fill or change values to retrieve and process them server side.</p>
                    <a href="formfields_demo.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /FORM FIELDS -->

            <!-- 7 - STANDALONE -->
            <div id="standalone" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-standalone.png" alt="Standalone" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>Standalone Viewer Demo</h1>
                    <p>Plain and simple document and image viewer. Powerful yet easy to use.</p>
                    <a href="standalone_viewer_demo.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /STANDALONE -->

            <!-- 8 -  CUSTOMIZABLE VIEWER -->
            <div id="customizable-viewer" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-customizable-viewer.png" alt="Customizable Viewer" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>Customizable Viewer Demo</h1>
                    <p>Customize your own viewer in a trice!</p>
                    <a href="custom_viewer_demo.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /CUSTOM VIEWER -->

            <!-- 9 - CUSTOM TOOLBAR-->
            <div id="toolbar" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-toolbar.png" alt="Custom Toolbar" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>Using Custom Toolbar Demo</h1>
                    <p>Build and use your own toolbar to control the viewer.</p>
                    <a href="custom_toolbar_demo.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /CUSTOM TOOLBAR -->

            <!-- 10 - BLOG -->
            <div id="blog" class="slider-panel">
                <div class="img-slider col-md-6 col-xs-12">
                    <img src="img/slider-blog.png" alt="Integration blog Docuvieware" width="645" height="558" class="img-responsive img-align-slider">
                </div>
                <div class="texte-desc-slider col-md-6 col-xs-12">
                    <h1>Blog Integration Demo</h1>
                    <p>See how it can be integrated in an existing content.</p>
                    <a href="blog_integration_demo.aspx" target="_blank" class="btn btn-lg btn-slider" title="Launch Docuvieware">&rarr; Launch</a>
                </div>
            </div>
            <!-- /BLOG -->

        </div>
    </div>
    <!-- /slider -->
    <!-- thumbnails -->
    <div class="container mosaic">
        <div class="row tnbs">
            <div class="tnb tnb-active col-lg-4 col-sm-6">
                <a href="#" id="link-annotations" class="slider-button" data-slider="annotations">
                    <img src="img/tnb-1-annotations.jpg" alt="Annotations" width="370" height="212" class="img-responsive">
                    <h2>Annotations Demo</h2>
                </a>
            </div>
            <div class="tnb col-lg-4 col-sm-6">
                <a href="#" id="link-gallery" class="slider-button" data-slider="gallery">
                    <img src="img/tnb-6-gallery.jpg" alt="Gallery Demo" width="370" height="212" class="img-responsive">
                    <h2>Gallery Demo</h2>
                </a>
            </div>
            <div class="tnb col-lg-4 col-sm-6">
                <a href="#" id="link-imagecleanup" class="slider-button" data-slider="image-cleanup">
                    <img src="img/tnb-7-cleanup.jpg" alt="Image Cleanup" width="370" height="212" class="img-responsive">
                    <h2>Image Cleanup Demo</h2>
                </a>
            </div>
            <div class="tnb col-lg-4 col-sm-6">
                <a href="#" id="link-twain" class="slider-button" data-slider="twain">
                    <img src="img/tnb-10-twain.png" alt="TWAIN Acquisition Demo" width="370" height="212" class="img-responsive">
                    <h2>TWAIN Acquisition Demo</h2>
                </a>
            </div>
            <div class="tnb col-lg-4 col-sm-6">
                <a href="#" id="link-barcodes" class="slider-button" data-slider="barcodes">
                    <img src="img/tnb-8-barcodes.png" alt="Online Barcodes Recognition Demo" width="370" height="212" class="img-responsive">
                    <h2>Online Barcodes Recognition Demo</h2>
                </a>
            </div>
            <div class="tnb col-lg-4 col-sm-6">
                <a href="#" id="link-formfields" class="slider-button" data-slider="formfields">
                    <img src="img/tnb-9-formfields.png" alt="PDF Form Fields Demo" width="370" height="212" class="img-responsive">
                    <h2>PDF Form Fields Demo</h2>
                </a>
            </div>
            <div class="tnb col-lg-4 col-sm-6">
                <a href="#" id="link-standalone" class="slider-button" data-slider="standalone">
                    <img src="img/tnb-2-standalone.jpg" alt="Standalone Viewer Demo" width="370" height="212" class="img-responsive">
                    <h2>Standalone Viewer Demo</h2>
                </a>
            </div>
            <div class="tnb col-lg-4 col-sm-6">
                <a href="#" id="link-customizable-viewer" class="slider-button" data-slider="customizable-viewer">
                    <img src="img/tnb-3-customizable-viewer.jpg" alt="Customizable Viewer Demo" width="370" height="212" class="img-responsive">
                    <h2>Customizable Viewer Demo</h2>
                </a>
            </div>
            <div class="tnb col-lg-4 col-sm-6">
                <a href="#" id="link-toolbar" class="slider-button" data-slider="toolbar">
                    <img src="img/tnb-4-toolbar.jpg" alt="Using Custom Toolbar" width="370" height="212" class="img-responsive">
                    <h2>Using Custom Toolbar Demo</h2>
                </a>
            </div>
            <div class="tnb col-lg-4 col-sm-6">
                <a href="#" id="link-blog" class="slider-button" data-slider="blog">
                    <img src="img/tnb-5-blog.jpg" alt="Blog Integration Demo" width="370" height="212" class="img-responsive">
                    <h2>Blog Integration Demo</h2>
                </a>
            </div>

        </div>
        <!-- /row tnbs -->
    </div>
    <!-- /container fluid mosaic -->
    <div class="footer footer-bg">
        <div class="container">
            <div class="all-browsers col-lg-4 col-xs-12">
                <p class="compatible">
                    Works in all modern browsers and devices
                </p>
                <ul class="browsers">
                    <li>
                        <img src="img/safari.jpg" width="25" height="25" alt="Safari"></li>
                    <li>
                        <img src="img/chrome.jpg" width="25" height="25" alt="Google Chrome"></li>
                    <li>
                        <img src="img/explorer.jpg" width="25" height="25" alt="Microsoft Internet Explorer"></li>
                    <li>
                        <img src="img/opera.jpg" width="25" height="25" alt="Opera"></li>
                    <li>
                        <img src="img/mozilla-firefox.jpg" width="25" height="25" alt="Mozilla Firefox"></li>
                </ul>
            </div>
            <div class="credits-div col-lg-4 col-xs-12">
                <span class="credits-orpalis">
                    <img src="img/orpalis-logo-footer.png" alt="Logo ORPALIS" width="25" height="23" class="img-logo-orpalis">
                    © Copyright 2003-2016 <a href="http://www.orpalis.com" target="_blank">ORPALIS.</a> All rights reserved.
                    <a href="http://www.orpalis.com/contact/" target="_blank"> <span class="glyphicon glyphicon-envelope"></span>Contact us.</a>
                </span>
            </div>
        </div>
    </div>
</body>
</html>
