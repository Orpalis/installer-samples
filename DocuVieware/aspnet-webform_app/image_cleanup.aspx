<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="image_cleanup.aspx.cs" Inherits="DocuVieware_webform_app_demo.ImageCleanupDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html>
<head>
    <title>DocuVieware - Image Cleanup Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />
    <link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href="style/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="style/image_cleanup.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-3.1.0.min.js"></script>
    <script src="js/jquery-ui-1.12.0.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/image_cleanup.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <nav id="navigation" role="navigation">
            <div class="toggle-button navigation-close">
                <i>
                    <svg width="26" height="26" viewBox="0 0 512 512">
                        <g>
                            <path d="M369.283,503.953H30.224c-7.197,0-13.034-5.836-13.034-13.033V67.981c0-7.204,5.837-13.041,13.034-13.041h254.901l5.663,26.088H43.271v396.845h312.966v-229.21l26.094,44.204V490.92C382.33,498.117,376.48,503.953,369.283,503.953z" />
                            <polyline points="94.525,189.333 197.776,189.333 197.776,161.206 94.525,161.206" />
                            <polyline points="94.525,293.455 261.68,293.455 261.68,265.329 94.525,265.329" />
                            <polyline points="94.525,397.585 294.489,397.585 294.489,369.459 94.525,369.459" />
                            <polygon points="385.394,156.062 494.247,97.049 373.72,125.409 395.899,50.663 354.877,116.977 295.849,8.115 324.223,128.643 249.483,106.436 315.776,147.486 206.923,206.5 327.45,178.133 305.271,252.886 346.279,186.565 405.308,295.434 376.947,174.905 451.687,197.106" />
                        </g>
                    </svg>
                </i>
            </div>
            <div class="toggle-button navigation-open">
                <i>
                    <svg width="26" height="26" viewBox="0 0 512 512">
                        <g>
                            <path d="M369.283,503.953H30.224c-7.197,0-13.034-5.836-13.034-13.033V67.981c0-7.204,5.837-13.041,13.034-13.041h254.901l5.663,26.088H43.271v396.845h312.966v-229.21l26.094,44.204V490.92C382.33,498.117,376.48,503.953,369.283,503.953z" />
                            <polyline points="94.525,189.333 197.776,189.333 197.776,161.206 94.525,161.206" />
                            <polyline points="94.525,293.455 261.68,293.455 261.68,265.329 94.525,265.329" />
                            <polyline points="94.525,397.585 294.489,397.585 294.489,369.459 94.525,369.459" />
                            <polygon points="385.394,156.062 494.247,97.049 373.72,125.409 395.899,50.663 354.877,116.977 295.849,8.115 324.223,128.643 249.483,106.436 315.776,147.486 206.923,206.5 327.45,178.133 305.271,252.886 346.279,186.565 405.308,295.434 376.947,174.905 451.687,197.106" />
                        </g>
                    </svg>
                </i>
            </div>
            <div class="pts pbs line" id="container">
                <p class="style-title">Operations</p>
                <div class="filters">
                    <div id="btn_RemoveBlackBorders" class="filter" title="Erase Black Borders" onclick="return applyFilter('automaticRemoveBlackBorders');">
                        <div class="icon">
                            <svg width="100%" height="100%" viewBox="0 0 512 512">
                                <g>
                                    <path opacity="0.25" fill="none" stroke="#969696" stroke-width="32.5429" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" d="M491.889,256c0,130.279-105.609,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                    <g>
                                        <defs>
                                            <path id="SVGID_1_" d="M491.889,256c0,130.279-105.609,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                        </defs>
                                        <clipPath id="SVGID_2_">
                                            <use xlink:href="#SVGID_1_" overflow="visible" />
                                        </clipPath>
                                        <rect x="-19.502" y="-26.091" clip-path="url(#SVGID_2_)" fill="#1C84D1" width="543.091" height="543.103" />
                                        <g clip-path="url(#SVGID_2_)">
                                            <rect x="85.51" y="174.791" opacity="0.15" width="487.598" height="705.384" />
                                            <g>
                                                <rect x="101.58" y="140.003" fill="#FFFFFF" width="344.228" height="497.963" />
                                                <g>
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="330.176" y1="201.079" x2="411.966" y2="201.079" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="176.312" y1="241.265" x2="235.682" y2="241.265" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="176.312" y1="281.445" x2="411.966" y2="281.445" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="176.312" y1="321.627" x2="411.966" y2="321.627" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="176.312" y1="361.813" x2="411.966" y2="361.813" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="176.312" y1="401.998" x2="411.966" y2="401.998" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="176.312" y1="442.185" x2="411.966" y2="442.185" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="352.517" y1="482.369" x2="411.966" y2="482.369" />
                                                </g>
                                                <rect x="223.473" y="92.74" opacity="0.15" width="344.228" height="497.964" />
                                                <rect x="100.118" y="139.997" fill="#1B2828" width="340.801" height="21.543" />
                                                <rect x="239.855" y="63.412" fill="#FFFFFF" width="344.222" height="497.964" />
                                                <g>
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="458.82" y1="140.003" x2="540.618" y2="140.003" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="304.952" y1="180.188" x2="364.339" y2="180.188" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="304.952" y1="220.375" x2="540.618" y2="220.375" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="304.952" y1="260.556" x2="540.618" y2="260.556" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="304.952" y1="300.741" x2="540.618" y2="300.741" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="304.952" y1="340.927" x2="540.618" y2="340.927" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="304.952" y1="381.108" x2="540.618" y2="381.108" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="21.5856" stroke-miterlimit="10" x1="481.163" y1="421.294" x2="540.618" y2="421.294" />
                                                </g>
                                                <rect x="100.118" y="147.079" fill="#1B2828" width="21.41" height="341.33" />
                                                <g>
                                                    <line fill="none" stroke="#EF3400" stroke-width="21.5856" stroke-miterlimit="10" x1="144.929" y1="256" x2="83.068" y2="317.866" />
                                                    <line fill="none" stroke="#EF3400" stroke-width="21.5856" stroke-miterlimit="10" x1="144.929" y1="317.866" x2="83.068" y2="256" />
                                                </g>
                                            </g>
                                        </g>
                                    </g>
                                    <path fill="none" stroke="#FFFFFF" stroke-width="10.8476" stroke-miterlimit="10" d="M491.889,256c0,130.279-105.609,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                </g>
                            </svg>
                        </div>
                        <span class="filter_name">Erase Black Borders</span>
                    </div>
                    <div id="btn_AutoDeskew" class="filter" title="Auto deskew" onclick="return applyFilter('autoDeskew');">
                        <div class="icon">
                            <svg width="100%" height="100%" viewBox="0 0 512 512">
                                <g>
                                    <path opacity="0.25" fill="none" stroke="#969696" stroke-width="32.5429" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" enable-background="new    " d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                    <g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_1_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_2_">
                                                <use xlink:href="#SVGID_1_" overflow="visible" />
                                            </clipPath>
                                            <rect x="-19.502" y="-26.091" clip-path="url(#SVGID_2_)" fill="#1C84D1" width="543.091" height="543.103" />
                                        </g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_3_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_4_">
                                                <use xlink:href="#SVGID_3_" overflow="visible" />
                                            </clipPath>
                                            <rect x="-6.896" y="30.104" clip-path="url(#SVGID_4_)" fill="#1C84D1" width="567.747" height="444.22" />
                                            <g clip-path="url(#SVGID_4_)">
                                                <polygon opacity="0.15" points="578.372,595.691 221.307,638.009 164.458,158.337 521.533,116.023" />
                                                <g>
                                                    <rect x="247.19" y="121.794" opacity="0.15" width="359.562" height="483.024" />
                                                    <g>
                                                        <g>
                                                            <polyline fill="none" stroke="#FFFFFF" stroke-width="6.2309" stroke-miterlimit="10" points="578.006,592.598 578.372,595.691 575.278,596.058" />
                                                            <line fill="none" stroke="#FFFFFF" stroke-width="6.2309" stroke-miterlimit="10" stroke-dasharray="6.3095,12.6191" x1="562.747" y1="597.543" x2="230.666" y2="636.899" />
                                                            <polyline fill="none" stroke="#FFFFFF" stroke-width="6.2309" stroke-miterlimit="10" points="224.4,637.643 221.307,638.009 220.94,634.915" />
                                                            <line fill="none" stroke="#FFFFFF" stroke-width="6.2309" stroke-miterlimit="10" stroke-dasharray="6.1922,12.3844" x1="219.482" y1="622.617" x2="165.553" y2="167.58" />
                                                            <polyline fill="none" stroke="#FFFFFF" stroke-width="6.2309" stroke-miterlimit="10" points="164.825,161.431 164.458,158.337 167.552,157.97" />
                                                            <line fill="none" stroke="#FFFFFF" stroke-width="6.2309" stroke-miterlimit="10" stroke-dasharray="6.3097,12.6194" x1="180.083" y1="156.485" x2="512.174" y2="117.133" />
                                                            <polyline fill="none" stroke="#FFFFFF" stroke-width="6.2309" stroke-miterlimit="10" points="518.439,116.39 521.533,116.023 521.899,119.117" />
                                                            <line fill="none" stroke="#FFFFFF" stroke-width="6.2309" stroke-miterlimit="10" stroke-dasharray="6.1921,12.3842" x1="523.357" y1="131.416" x2="577.276" y2="586.448" />
                                                        </g>
                                                    </g>
                                                    <rect x="263.269" y="103.665" fill="#FFFFFF" width="359.56" height="483.027" />
                                                    <g>
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="18.6926" stroke-miterlimit="10" x1="493.416" y1="195.4" x2="566.135" y2="195.4" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="18.6926" stroke-miterlimit="10" x1="319.966" y1="237.377" x2="381.992" y2="237.377" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="18.6926" stroke-miterlimit="10" x1="319.966" y1="279.355" x2="566.135" y2="279.355" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="18.6926" stroke-miterlimit="10" x1="319.966" y1="321.329" x2="566.135" y2="321.329" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="18.6926" stroke-miterlimit="10" x1="319.966" y1="363.304" x2="566.135" y2="363.304" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="18.6926" stroke-miterlimit="10" x1="319.966" y1="405.282" x2="566.135" y2="405.282" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="18.6926" stroke-miterlimit="10" x1="319.966" y1="447.257" x2="566.135" y2="447.257" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="18.6926" stroke-miterlimit="10" x1="504.029" y1="489.229" x2="566.135" y2="489.229" />
                                                    </g>
                                                    <g>
                                                        <path fill="#FF5743" d="M331.896,406.595H222.628V236.065L331.896,406.595z M292.375,384.972l-48.134-75.114v75.114H292.375z" />
                                                    </g>
                                                </g>
                                            </g>
                                        </g>
                                    </g>
                                    <path fill="none" stroke="#FFFFFF" stroke-width="10.8476" stroke-miterlimit="10" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                </g>
                            </svg>
                        </div>
                        <span class="filter_name">Auto Deskew</span>
                    </div>
                    <div id="btn_HolePunchRemoval" class="filter" title="Remove punch hole" onclick="return applyFilter('punchHoleRemoval');">
                        <div class="icon">
                            <svg width="100%" height="100%" viewBox="0 0 512 512">
                                <g>

                                    <path opacity="0.25" fill="none" stroke="#969696" stroke-width="32.5429" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" enable-background="new" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                    <g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_1_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_2_">
                                                <use xlink:href="#SVGID_1_" overflow="visible" />
                                            </clipPath>
                                            <rect x="-19.502" y="-26.091" clip-path="url(#SVGID_2_)" fill="#1C84D1" width="543.091" height="543.103" />
                                        </g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_3_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_4_">
                                                <use xlink:href="#SVGID_3_" overflow="visible" />
                                            </clipPath>
                                            <rect x="-6.896" y="30.104" clip-path="url(#SVGID_4_)" fill="#1C84D1" width="567.747" height="444.22" />
                                            <g clip-path="url(#SVGID_4_)">
                                                <rect x="146.054" y="148.074" opacity="0.15" width="399.624" height="567.936" />
                                                <rect x="171.773" y="114.62" fill="#FFFFFF" width="392.589" height="567.938" />
                                                <path fill="#1C84D1" d="M221.208,186.897c0,5.282-4.273,9.562-9.551,9.562c-5.285,0-9.562-4.28-9.562-9.562c0-5.276,4.277-9.555,9.562-9.555C216.935,177.342,221.208,181.621,221.208,186.897z" />
                                                <path fill="#1C84D1" d="M221.208,382.577c0,5.277-4.273,9.565-9.551,9.565c-5.285,0-9.562-4.288-9.562-9.565c0-5.278,4.277-9.56,9.562-9.56C216.935,373.018,221.208,377.299,221.208,382.577z" />
                                                <path fill="#1C84D1" d="M211.657,207.588c-5.285,0-9.562,4.28-9.562,9.56v14.862h0.069c0.366,4.948,4.451,8.859,9.493,8.859c5.031,0,9.116-3.912,9.479-8.859h0.073v-14.862C221.208,211.868,216.935,207.588,211.657,207.588z" />
                                                <path fill="#1C84D1" d="M221.208,283.035c0,5.283-4.273,9.563-9.551,9.563c-5.285,0-9.562-4.28-9.562-9.563c0-5.273,4.277-9.555,9.562-9.555C216.935,273.48,221.208,277.762,221.208,283.035z" />
                                                <path fill="#1C84D1" d="M211.657,303.728c-5.285,0-9.562,4.279-9.562,9.555v14.869h0.069c0.366,4.946,4.451,8.859,9.493,8.859c5.031,0,9.116-3.913,9.479-8.859h0.073v-14.869C221.208,308.007,216.935,303.728,211.657,303.728z" />
                                                <g>
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.3796" stroke-miterlimit="10" x1="421.506" y1="201.976" x2="514.793" y2="201.976" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.3796" stroke-miterlimit="10" x1="246.02" y1="247.81" x2="313.745" y2="247.81" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.3796" stroke-miterlimit="10" x1="246.02" y1="293.639" x2="514.793" y2="293.639" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.3796" stroke-miterlimit="10" x1="246.02" y1="339.471" x2="514.793" y2="339.471" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.3796" stroke-miterlimit="10" x1="246.02" y1="385.3" x2="514.793" y2="385.3" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.3796" stroke-miterlimit="10" x1="246.02" y1="431.132" x2="514.793" y2="431.132" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.3796" stroke-miterlimit="10" x1="246.02" y1="476.961" x2="514.793" y2="476.961" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.3796" stroke-miterlimit="10" x1="446.988" y1="522.793" x2="514.793" y2="522.793" />
                                                </g>
                                                <g>
                                                    <line fill="none" stroke="#EF3400" stroke-width="17.3796" stroke-miterlimit="10" x1="232.986" y1="171.167" x2="183.181" y2="220.975" />
                                                    <line fill="none" stroke="#EF3400" stroke-width="17.3796" stroke-miterlimit="10" x1="232.986" y1="220.975" x2="183.181" y2="171.167" />
                                                </g>
                                            </g>
                                        </g>
                                    </g>
                                    <path fill="none" stroke="#FFFFFF" stroke-width="10.8476" stroke-miterlimit="10" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                </g>
                            </svg>
                        </div>
                        <span class="filter_name">Punch Hole Removal</span>
                    </div>
                    <div id="btn_Negative" class="filter" title="Negative" onclick="return applyFilter('negative');">
                        <div class="icon">
                            <svg width="100%" height="100%" viewBox="0 0 512 512">
                                <g>

                                    <path opacity="0.25" fill="none" stroke="#969696" stroke-width="32.5429" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" enable-background="new" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                    <g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_1_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_2_">
                                                <use xlink:href="#SVGID_1_" overflow="visible" />
                                            </clipPath>
                                            <rect x="-19.502" y="-26.091" clip-path="url(#SVGID_2_)" fill="#1C84D1" width="543.091" height="543.103" />
                                        </g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_3_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_4_">
                                                <use xlink:href="#SVGID_3_" overflow="visible" />
                                            </clipPath>
                                            <rect x="-6.896" y="30.104" clip-path="url(#SVGID_4_)" fill="#1C84D1" width="567.747" height="444.22" />
                                            <rect x="56.029" y="263.961" opacity="0.15" clip-path="url(#SVGID_4_)" width="154.561" height="291.614" />
                                            <rect x="73.185" y="246.778" clip-path="url(#SVGID_4_)" width="201.583" height="291.62" />
                                            <g clip-path="url(#SVGID_4_)">
                                                <line fill="none" stroke="#FFFFFF" stroke-width="7.5639" stroke-miterlimit="10" x1="201.418" y1="291.634" x2="249.31" y2="291.634" />
                                                <line fill="none" stroke="#FFFFFF" stroke-width="7.5639" stroke-miterlimit="10" x1="111.309" y1="315.165" x2="146.088" y2="315.165" />
                                                <line fill="none" stroke="#FFFFFF" stroke-width="7.5639" stroke-miterlimit="10" x1="111.309" y1="338.696" x2="249.31" y2="338.696" />
                                                <line fill="none" stroke="#FFFFFF" stroke-width="7.5639" stroke-miterlimit="10" x1="111.309" y1="362.232" x2="249.31" y2="362.232" />
                                                <line fill="none" stroke="#FFFFFF" stroke-width="7.5639" stroke-miterlimit="10" x1="111.309" y1="385.77" x2="249.31" y2="385.77" />
                                                <line fill="none" stroke="#FFFFFF" stroke-width="7.5639" stroke-miterlimit="10" x1="111.309" y1="409.3" x2="249.31" y2="409.3" />
                                                <line fill="none" stroke="#FFFFFF" stroke-width="7.5639" stroke-miterlimit="10" x1="111.309" y1="432.831" x2="249.31" y2="432.831" />
                                                <line fill="none" stroke="#FFFFFF" stroke-width="7.5639" stroke-miterlimit="10" x1="214.498" y1="456.361" x2="249.31" y2="456.361" />
                                            </g>
                                            <g clip-path="url(#SVGID_4_)">
                                                <rect x="228.763" y="263.961" opacity="0.15" width="217.619" height="291.614" />
                                                <rect x="254.398" y="246.778" fill="#FFFFFF" width="201.572" height="291.62" />
                                                <g>
                                                    <line fill="none" stroke="#000000" stroke-width="7.5639" stroke-miterlimit="10" x1="382.622" y1="291.634" x2="430.524" y2="291.634" />
                                                    <line fill="none" stroke="#000000" stroke-width="7.5639" stroke-miterlimit="10" x1="292.519" y1="315.165" x2="327.297" y2="315.165" />
                                                    <line fill="none" stroke="#000000" stroke-width="7.5639" stroke-miterlimit="10" x1="292.519" y1="338.696" x2="430.524" y2="338.696" />
                                                    <line fill="none" stroke="#000000" stroke-width="7.5639" stroke-miterlimit="10" x1="292.519" y1="362.232" x2="430.524" y2="362.232" />
                                                    <line fill="none" stroke="#000000" stroke-width="7.5639" stroke-miterlimit="10" x1="292.519" y1="385.77" x2="430.524" y2="385.77" />
                                                    <line fill="none" stroke="#000000" stroke-width="7.5639" stroke-miterlimit="10" x1="292.519" y1="409.3" x2="430.524" y2="409.3" />
                                                    <line fill="none" stroke="#000000" stroke-width="7.5639" stroke-miterlimit="10" x1="292.519" y1="432.831" x2="430.524" y2="432.831" />
                                                    <line fill="none" stroke="#000000" stroke-width="7.5639" stroke-miterlimit="10" x1="395.707" y1="456.361" x2="430.524" y2="456.361" />
                                                </g>
                                            </g>
                                            <path clip-path="url(#SVGID_4_)" d="M298.743,159.219c0,25.124-20.368,45.491-45.486,45.491c-25.123,0-45.486-20.368-45.486-45.491c0-25.118,20.364-45.486,45.486-45.486C278.375,113.732,298.743,134.101,298.743,159.219z" />
                                            <path clip-path="url(#SVGID_4_)" fill="#FFFFFF" d="M253.257,125.002c18.892,0,34.216,15.323,34.216,34.216c0,18.898-15.324,34.216-34.216,34.216" />
                                        </g>
                                    </g>
                                    <path fill="none" stroke="#FFFFFF" stroke-width="10.8476" stroke-miterlimit="10" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                </g>
                            </svg>
                        </div>
                        <span class="filter_name">Negative</span>
                    </div>
                    <div id="btn_Despeckle" class="filter" title="Despeckle" onclick="return applyFilter('despeckle');">
                        <div class="icon">
                            <svg width="100%" height="100%" viewBox="0 0 512 512">
                                <g>
                                    <path opacity="0.25" fill="none" stroke="#969696" stroke-width="32.5429" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" enable-background="new" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                    <g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_1_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_2_">
                                                <use xlink:href="#SVGID_1_" overflow="visible" />
                                            </clipPath>
                                            <rect x="-19.502" y="-26.091" clip-path="url(#SVGID_2_)" fill="#1C84D1" width="543.091" height="543.103" />
                                        </g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_3_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_4_">
                                                <use xlink:href="#SVGID_3_" overflow="visible" />
                                            </clipPath>
                                            <g clip-path="url(#SVGID_4_)">
                                                <g>
                                                    <rect x="1637.098" y="604.527" opacity="0.15" width="71.235" height="103.053" />
                                                    <rect x="1640.488" y="598.457" fill="#FFFFFF" width="71.235" height="103.053" />
                                                    <g>
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1685.803" y1="614.309" x2="1702.73" y2="614.309" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="622.625" x2="1666.248" y2="622.625" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="630.941" x2="1702.73" y2="630.941" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="639.258" x2="1702.73" y2="639.258" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="647.572" x2="1702.73" y2="647.572" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="655.89" x2="1702.73" y2="655.89" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="664.205" x2="1702.73" y2="664.205" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1690.426" y1="672.521" x2="1702.73" y2="672.521" />
                                                    </g>
                                                    <g>
                                                        <circle fill="#DFFFFE" cx="1651.149" cy="653.323" r="23.516" />
                                                        <circle fill="none" stroke="#00AE64" stroke-width="3.9798" stroke-miterlimit="10" cx="1651.149" cy="653.323" r="23.516" />
                                                        <rect x="1662.759" y="673.098" transform="matrix(0.8399 -0.5427 0.5427 0.8399 -99.983 1011.9003)" fill="#00AE64" width="5.348" height="4.697" />
                                                        <path fill="#00AE64" d="M1671.859,678.12l21.506,33.304c1.225,1.898,0.68,4.434-1.219,5.659l0,0c-1.898,1.226-4.433,0.681-5.659-1.218l-21.505-33.305" />
                                                        <g>
                                                            <defs>
                                                                <circle id="SVGID_5_" cx="1651.148" cy="653.323" r="22.003" />
                                                            </defs>
                                                            <clipPath id="SVGID_6_">
                                                                <use xlink:href="#SVGID_5_" overflow="visible" />
                                                            </clipPath>
                                                            <line opacity="0.15" clip-path="url(#SVGID_6_)" fill="none" stroke="#000000" stroke-width="9.2861" stroke-miterlimit="10" x1="1649.912" y1="644.127" x2="1681.371" y2="644.127" />
                                                            <line opacity="0.15" clip-path="url(#SVGID_6_)" fill="none" stroke="#000000" stroke-width="9.2861" stroke-miterlimit="10" x1="1649.912" y1="658.78" x2="1681.371" y2="658.78" />
                                                        </g>
                                                        <path d="M1636.787,643.929c-0.65,1.156-1.212,0.505-0.613,1.774c0.271,0.571,0.646,1.448,1.413,1.381c0.093-0.412,0.36-0.793,0.347-1.221c-0.019-0.562-0.335-0.566-0.474-0.969c-0.104-0.302-0.08-0.684-0.005-0.972c-0.171,0.039-0.166-0.38-0.291-0.286L1636.787,643.929z" />
                                                        <path d="M1640.686,659.784c-0.76,0.049-1.306-0.261-0.77,0.595c0.166,0.264,0.461,0.584,0.756,0.65c0.039-0.457,0.98-0.838,0.145-1.113" />
                                                        <path d="M1654.877,650.98c-0.941-0.404-1.699-0.362-1.9,0.715c-0.071,0.375-0.213,0.41,0.014,0.679c0.324,0.383,1.277,0.3,1.68,0.122c0.228-0.101,1.119-0.541,1.179-0.688c0.188-0.459-0.319-0.842-0.71-0.895" />
                                                        <path d="M1659.082,663.924c-0.518,0.518-0.771,0.961-1.512,0.906c-0.748-0.055-0.84-0.268-1.553,0.229c0.691,0.286,3.027,0.913,2.735-0.479" />
                                                        <path d="M1653.234,658.93c-0.242-0.262-0.172-0.762-0.649-0.649c-0.032,0.104-0.034,0.335-0.001,0.442c0.082,0.004,0.168,0.021,0.25,0.02c0.017,0.292,0.256,0.463,0.452,0.646c0.019-0.102,0.03-0.224,0.015-0.327" />
                                                        <path d="M1648.568,633.637c-0.792,0.127-1.131,0.55-1.594,1.095c-0.301,0.351-0.9,1.29,0.101,1.079c0.374-0.078,0.854-0.87,1.181-1.125c0.258-0.202,0.691-0.373,0.576-0.853" />
                                                        <path d="M1659.869,637.184c0.438,0.018,0.949-0.232,1.419-0.379c0.015,0.22,0.095,0.431,0.239,0.577c-0.311,0.192-0.465-0.11-0.759-0.136c-0.342-0.029-0.651,0.08-0.899,0.201" />
                                                        <path d="M1656.65,671.348c-0.75,0.481-1.539,0.703-2.422,0.729c-0.273,0.008-1.301-0.139-1.513,0.205c-0.413,0.672,1.009,0.814,1.427,0.77c0.355-0.037,0.703-0.34,0.993-0.396c0.245-0.048,0.643,0.119,0.864,0.013c0.414-0.202,0.361-0.676,0.584-1.057" />
                                                        <path d="M1636.218,665.631c-0.523,0.223-1.831-0.322-1.333,0.533c0.477,0.813,0.826,0.24,1.168-0.02c0.215-0.16,0.459-0.113,0.561-0.447" />
                                                        <path d="M1645.285,648.944c-0.039,0.063-0.066,0.132-0.08,0.205c0.375,0.182,0.699,2.226,1.131,0.781C1646.622,648.973,1646.088,648.947,1645.285,648.944" />
                                                        <path d="M1634.051,653.938c-0.271,0.153-1.157,0.748-0.264,0.789c0.507,0.023,0.521-0.319,0.657-0.658" />
                                                        <path d="M1635.494,652.558c0.193,0.022,0.387,0.094,0.593,0.08c-0.05,0.083-0.104,0.035-0.196,0.052" />
                                                        <path d="M1639.043,650.98c0.117-0.021,0.303,0.057,0.447,0.006c0.084,0.225,0.109,0.47,0.068,0.709c-0.262,0.027-0.238-0.105-0.252-0.32" />
                                                        <path d="M1642.985,667.471c-0.192,0.096-0.358,0.225-0.538,0.262c0.504,0.344,1.055,0.35,0.801-0.393" />
                                                        <path d="M1655.337,653.084c0.671-0.407,1.069-0.653,1.831-0.664c-0.553,0.279-1.004,0.382-1.504,0.729" />
                                                        <path d="M1662.629,650.521c1.006,0,2,0.002,3.014,0c0.811-0.002,1.976-0.19,2.721,0.057c-0.363,0.623-2.077,0.336-2.65,0.336c-1.029,0-2.057,0-3.084,0" />
                                                    </g>
                                                </g>
                                                <g>
                                                    <line fill="none" stroke="#EF3400" stroke-width="3.9798" stroke-miterlimit="10" x1="1655.303" y1="659.979" x2="1643.897" y2="671.385" />
                                                    <line fill="none" stroke="#EF3400" stroke-width="3.9798" stroke-miterlimit="10" x1="1655.303" y1="671.385" x2="1643.897" y2="659.979" />
                                                </g>
                                            </g>
                                            <g clip-path="url(#SVGID_4_)">
                                                <g>
                                                    <rect x="161.425" y="99.646" opacity="0.15" width="315.449" height="456.344" />
                                                    <rect x="176.439" y="72.765" fill="#FFFFFF" width="315.449" height="456.344" />
                                                    <g>
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.6235" stroke-miterlimit="10" x1="377.104" y1="142.96" x2="452.064" y2="142.96" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.6235" stroke-miterlimit="10" x1="236.092" y1="179.787" x2="290.511" y2="179.787" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.6235" stroke-miterlimit="10" x1="236.092" y1="216.614" x2="452.064" y2="216.614" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.6235" stroke-miterlimit="10" x1="236.092" y1="253.441" x2="452.064" y2="253.441" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.6235" stroke-miterlimit="10" x1="236.092" y1="290.26" x2="452.064" y2="290.26" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.6235" stroke-miterlimit="10" x1="236.092" y1="327.092" x2="452.064" y2="327.092" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.6235" stroke-miterlimit="10" x1="236.092" y1="363.914" x2="452.064" y2="363.914" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="17.6235" stroke-miterlimit="10" x1="397.576" y1="400.742" x2="452.064" y2="400.742" />
                                                    </g>
                                                    <g>
                                                        <path fill="#DFFFFE" d="M311.13,259.236c31.197,48.312,17.315,112.773-30.993,143.971c-48.317,31.196-112.774,17.323-143.971-30.989c-31.201-48.313-17.319-112.774,30.993-143.971C215.473,197.05,279.933,210.923,311.13,259.236z" />
                                                        <path fill="none" stroke="#00AE64" stroke-width="17.6235" stroke-miterlimit="10" d="M311.13,259.236c31.197,48.312,17.315,112.773-30.993,143.971c-48.317,31.196-112.774,17.323-143.971-30.989c-31.201-48.313-17.319-112.774,30.993-143.971C215.473,197.05,279.933,210.923,311.13,259.236z" />
                                                        <polygon fill="#00AE64" points="302.481,416.007 282.589,428.859 271.319,411.38 291.212,398.536" />
                                                        <path fill="#00AE64" d="M315.359,425.534l95.233,147.478c5.423,8.406,3.01,19.633-5.396,25.061l0,0c-8.407,5.427-19.629,3.014-25.061-5.393l-95.229-147.482" />
                                                        <g>
                                                            <defs>
                                                                <path id="SVGID_7_" d="M305.499,262.873c29.19,45.204,16.2,105.513-29.008,134.703c-45.204,29.186-105.505,16.204-134.699-29c-29.182-45.199-16.199-105.508,29-134.699C215.991,204.688,276.31,217.669,305.499,262.873z" />
                                                            </defs>
                                                            <clipPath id="SVGID_8_">
                                                                <use xlink:href="#SVGID_7_" overflow="visible" />
                                                            </clipPath>
                                                            <line opacity="0.15" clip-path="url(#SVGID_8_)" fill="none" stroke="#000000" stroke-width="41.1215" stroke-miterlimit="10" x1="218.171" y1="275.004" x2="357.479" y2="275.004" />
                                                            <line opacity="0.15" clip-path="url(#SVGID_8_)" fill="none" stroke="#000000" stroke-width="41.1215" stroke-miterlimit="10" x1="218.171" y1="339.893" x2="357.479" y2="339.893" />
                                                        </g>
                                                        <path d="M160.05,274.125c-2.88,5.121-5.366,2.236-2.716,7.857c1.198,2.53,2.863,6.414,6.258,6.115c0.411-1.824,1.596-3.512,1.535-5.405c-0.082-2.491-1.483-2.509-2.098-4.29c-0.458-1.336-0.354-3.027-0.021-4.303c-0.757,0.173-0.735-1.682-1.288-1.268L160.05,274.125z" />
                                                        <path d="M177.313,344.338c-3.364,0.216-5.782-1.155-3.408,2.634c0.735,1.167,2.041,2.586,3.348,2.88c0.173-2.024,4.342-3.711,0.64-4.93" />
                                                        <path d="M240.157,305.353c-4.17-1.79-7.525-1.604-8.416,3.165c-0.315,1.661-0.943,1.816,0.061,3.006c1.436,1.695,5.656,1.328,7.438,0.541c1.008-0.445,4.957-2.396,5.221-3.045c0.834-2.032-1.414-3.728-3.145-3.961" />
                                                        <path d="M258.778,362.669c-2.293,2.292-3.417,4.256-6.695,4.014c-3.312-0.242-3.719-1.186-6.875,1.016c3.062,1.268,13.405,4.044,12.112-2.123" />
                                                        <path d="M232.883,340.554c-1.072-1.159-0.761-3.373-2.876-2.876c-0.143,0.463-0.151,1.483-0.004,1.959c0.363,0.018,0.744,0.096,1.107,0.087c0.073,1.293,1.133,2.05,2.002,2.862c0.082-0.449,0.134-0.99,0.064-1.448" />
                                                        <path d="M212.221,228.55c-3.507,0.562-5.008,2.435-7.058,4.848c-1.332,1.553-3.987,5.713,0.445,4.778c1.656-0.346,3.784-3.853,5.229-4.981c1.142-0.896,3.062-1.651,2.551-3.775" />
                                                        <path d="M262.264,244.256c1.941,0.078,4.203-1.029,6.283-1.678c0.064,0.973,0.419,1.907,1.06,2.557c-1.375,0.852-2.059-0.489-3.36-0.602c-1.514-0.13-2.884,0.354-3.982,0.891" />
                                                        <path d="M248.01,395.544c-3.321,2.132-6.815,3.113-10.725,3.226c-1.211,0.035-5.761-0.613-6.698,0.908c-1.83,2.976,4.467,3.606,6.317,3.408c1.574-0.165,3.114-1.505,4.398-1.756c1.085-0.212,2.846,0.527,3.827,0.056c1.834-0.895,1.6-2.992,2.586-4.679" />
                                                        <path d="M157.528,370.229c-2.317,0.985-8.107-1.428-5.902,2.361c2.11,3.602,3.658,1.063,5.172-0.087c0.951-0.709,2.033-0.502,2.482-1.98" />
                                                        <path d="M197.682,296.336c-0.173,0.281-0.294,0.584-0.354,0.908c1.66,0.805,3.096,9.855,5.008,3.459C203.602,296.461,201.236,296.35,197.682,296.336" />
                                                        <path d="M147.933,318.447c-1.202,0.679-5.124,3.312-1.167,3.494c2.244,0.104,2.309-1.414,2.91-2.915" />
                                                        <path d="M154.324,312.336c0.856,0.1,1.713,0.416,2.625,0.355c-0.221,0.367-0.458,0.155-0.869,0.229" />
                                                        <path d="M170.04,305.353c0.519-0.095,1.34,0.251,1.98,0.026c0.371,0.994,0.484,2.08,0.303,3.139c-1.159,0.121-1.056-0.467-1.116-1.418" />
                                                        <path d="M187.497,378.376c-0.852,0.424-1.587,0.994-2.383,1.158c2.232,1.522,4.671,1.549,3.547-1.738" />
                                                        <path d="M242.193,314.668c2.971-1.804,4.735-2.894,8.108-2.941c-2.447,1.236-4.445,1.691-6.66,3.227" />
                                                        <path d="M274.484,303.32c4.454,0,8.856,0.008,13.345,0c3.59-0.009,8.749-0.844,12.049,0.25c-1.609,2.76-9.198,1.488-11.736,1.488c-4.559,0-9.107,0-13.657,0" />
                                                    </g>
                                                </g>
                                                <g>
                                                    <line fill="none" stroke="#EF3400" stroke-width="17.6235" stroke-miterlimit="10" x1="242.042" y1="345.198" x2="191.536" y2="395.708" />
                                                    <line fill="none" stroke="#EF3400" stroke-width="17.6235" stroke-miterlimit="10" x1="242.042" y1="395.708" x2="191.536" y2="345.198" />
                                                </g>
                                            </g>
                                        </g>
                                    </g>
                                    <path fill="none" stroke="#FFFFFF" stroke-width="10.8476" stroke-miterlimit="10" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                </g>
                            </svg>
                        </div>
                        <span class="filter_name">Despeckle</span>
                    </div>
                    <div id="btn_RotateM90" class="filter" title="Rotate -90°" onclick="return applyFilter('rotate-90');">
                        <div class="icon">
                            <svg width="100%" height="100%" viewBox="0 0 512 512">
                                <g>
                                    <path opacity="0.25" fill="none" stroke="#969696" stroke-width="32.5429" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" enable-background="new" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                    <g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_1_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_2_">
                                                <use xlink:href="#SVGID_1_" overflow="visible" />
                                            </clipPath>
                                            <rect x="-19.502" y="-26.091" clip-path="url(#SVGID_2_)" fill="#1C84D1" width="543.091" height="543.103" />
                                        </g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_3_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_4_">
                                                <use xlink:href="#SVGID_3_" overflow="visible" />
                                            </clipPath>
                                            <g clip-path="url(#SVGID_4_)">
                                                <g>
                                                    <rect x="1637.098" y="604.527" opacity="0.15" width="71.235" height="103.053" />
                                                    <rect x="1640.488" y="598.457" fill="#FFFFFF" width="71.235" height="103.053" />
                                                    <g>
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1685.803" y1="614.309" x2="1702.73" y2="614.309" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="622.625" x2="1666.248" y2="622.625" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="630.941" x2="1702.73" y2="630.941" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="639.258" x2="1702.73" y2="639.258" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="647.572" x2="1702.73" y2="647.572" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="655.89" x2="1702.73" y2="655.89" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="664.205" x2="1702.73" y2="664.205" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1690.426" y1="672.521" x2="1702.73" y2="672.521" />
                                                    </g>
                                                    <g>
                                                        <circle fill="#DFFFFE" cx="1651.149" cy="653.323" r="23.516" />
                                                        <circle fill="none" stroke="#00AE64" stroke-width="3.9798" stroke-miterlimit="10" cx="1651.149" cy="653.323" r="23.516" />
                                                        <rect x="1662.759" y="673.098" transform="matrix(0.8399 -0.5427 0.5427 0.8399 -99.983 1011.9003)" fill="#00AE64" width="5.348" height="4.697" />
                                                        <path fill="#00AE64" d="M1671.859,678.12l21.506,33.304c1.225,1.898,0.68,4.434-1.219,5.659l0,0c-1.898,1.226-4.433,0.681-5.659-1.218l-21.505-33.305" />
                                                        <g>
                                                            <defs>
                                                                <circle id="SVGID_5_" cx="1651.148" cy="653.323" r="22.003" />
                                                            </defs>
                                                            <clipPath id="SVGID_6_">
                                                                <use xlink:href="#SVGID_5_" overflow="visible" />
                                                            </clipPath>
                                                            <line opacity="0.15" clip-path="url(#SVGID_6_)" fill="none" stroke="#000000" stroke-width="9.2861" stroke-miterlimit="10" x1="1649.912" y1="644.127" x2="1681.371" y2="644.127" />
                                                            <line opacity="0.15" clip-path="url(#SVGID_6_)" fill="none" stroke="#000000" stroke-width="9.2861" stroke-miterlimit="10" x1="1649.912" y1="658.78" x2="1681.371" y2="658.78" />
                                                        </g>
                                                        <path d="M1636.787,643.929c-0.65,1.156-1.212,0.505-0.613,1.774c0.271,0.571,0.646,1.448,1.413,1.381c0.093-0.412,0.36-0.793,0.347-1.221c-0.019-0.562-0.335-0.566-0.474-0.969c-0.104-0.302-0.08-0.684-0.005-0.972c-0.171,0.039-0.166-0.38-0.291-0.286L1636.787,643.929z" />
                                                        <path d="M1640.686,659.784c-0.76,0.049-1.306-0.261-0.77,0.595c0.166,0.264,0.461,0.584,0.756,0.65c0.039-0.457,0.98-0.838,0.145-1.113" />
                                                        <path d="M1654.877,650.98c-0.941-0.404-1.699-0.362-1.9,0.715c-0.071,0.375-0.213,0.41,0.014,0.679c0.324,0.383,1.277,0.3,1.68,0.122c0.228-0.101,1.119-0.541,1.179-0.688c0.188-0.459-0.319-0.842-0.71-0.895" />
                                                        <path d="M1659.082,663.924c-0.518,0.518-0.771,0.961-1.512,0.906c-0.748-0.055-0.84-0.268-1.553,0.229c0.691,0.286,3.027,0.913,2.735-0.479" />
                                                        <path d="M1653.234,658.93c-0.242-0.262-0.172-0.762-0.649-0.649c-0.032,0.104-0.034,0.335-0.001,0.442c0.082,0.004,0.168,0.021,0.25,0.02c0.017,0.292,0.256,0.463,0.452,0.646c0.019-0.102,0.03-0.224,0.015-0.327" />
                                                        <path d="M1648.568,633.637c-0.792,0.127-1.131,0.55-1.594,1.095c-0.301,0.351-0.9,1.29,0.101,1.079c0.374-0.078,0.854-0.87,1.181-1.125c0.258-0.202,0.691-0.373,0.576-0.853" />
                                                        <path d="M1659.869,637.184c0.438,0.018,0.949-0.232,1.419-0.379c0.015,0.22,0.095,0.431,0.239,0.577c-0.311,0.192-0.465-0.11-0.759-0.136c-0.342-0.029-0.651,0.08-0.899,0.201" />
                                                        <path d="M1656.65,671.348c-0.75,0.481-1.539,0.703-2.422,0.729c-0.273,0.008-1.301-0.139-1.513,0.205c-0.413,0.672,1.009,0.814,1.427,0.77c0.355-0.037,0.703-0.34,0.993-0.396c0.245-0.048,0.643,0.119,0.864,0.013c0.414-0.202,0.361-0.676,0.584-1.057" />
                                                        <path d="M1636.218,665.631c-0.523,0.223-1.831-0.322-1.333,0.533c0.477,0.813,0.826,0.24,1.168-0.02c0.215-0.16,0.459-0.113,0.561-0.447" />
                                                        <path d="M1645.285,648.944c-0.039,0.063-0.066,0.132-0.08,0.205c0.375,0.182,0.699,2.226,1.131,0.781C1646.622,648.973,1646.088,648.947,1645.285,648.944" />
                                                        <path d="M1634.051,653.938c-0.271,0.153-1.157,0.748-0.264,0.789c0.507,0.023,0.521-0.319,0.657-0.658" />
                                                        <path d="M1635.494,652.558c0.193,0.022,0.387,0.094,0.593,0.08c-0.05,0.083-0.104,0.035-0.196,0.052" />
                                                        <path d="M1639.043,650.98c0.117-0.021,0.303,0.057,0.447,0.006c0.084,0.225,0.109,0.47,0.068,0.709c-0.262,0.027-0.238-0.105-0.252-0.32" />
                                                        <path d="M1642.985,667.471c-0.192,0.096-0.358,0.225-0.538,0.262c0.504,0.344,1.055,0.35,0.801-0.393" />
                                                        <path d="M1655.337,653.084c0.671-0.407,1.069-0.653,1.831-0.664c-0.553,0.279-1.004,0.382-1.504,0.729" />
                                                        <path d="M1662.629,650.521c1.006,0,2,0.002,3.014,0c0.811-0.002,1.976-0.19,2.721,0.057c-0.363,0.623-2.077,0.336-2.65,0.336c-1.029,0-2.057,0-3.084,0" />
                                                    </g>
                                                </g>
                                                <g>
                                                    <line fill="none" stroke="#EF3400" stroke-width="3.9798" stroke-miterlimit="10" x1="1655.303" y1="659.979" x2="1643.897" y2="671.385" />
                                                    <line fill="none" stroke="#EF3400" stroke-width="3.9798" stroke-miterlimit="10" x1="1655.303" y1="671.385" x2="1643.897" y2="659.979" />
                                                </g>
                                            </g>
                                            <g clip-path="url(#SVGID_4_)">
                                                <polygon opacity="0.15" points="461.112,305.353 463.557,555.601 127.393,558.899 124.938,308.653" />
                                                <g>
                                                    <g>
                                                        <polyline fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" points="458.944,305.374 461.112,305.353 461.134,307.521" />
                                                        <line fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" stroke-dasharray="4.3915,8.783" x1="461.22" y1="316.304" x2="463.492" y2="549.042" />
                                                        <polyline fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" points="463.535,553.433 463.557,555.601 461.389,555.622" />
                                                        <line fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" stroke-dasharray="4.3097,8.6193" x1="452.77" y1="555.706" x2="133.871" y2="558.835" />
                                                        <polyline fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" points="129.562,558.878 127.393,558.899 127.372,556.731" />
                                                        <line fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" stroke-dasharray="4.3914,8.7829" x1="127.286" y1="547.948" x2="125.002" y2="315.214" />
                                                        <polyline fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" points="124.959,310.821 124.938,308.653 127.106,308.632" />
                                                        <line fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" stroke-dasharray="4.3098,8.6196" x1="135.726" y1="308.548" x2="454.635" y2="305.415" />
                                                    </g>
                                                </g>
                                                <rect x="62.167" y="242.533" opacity="0.15" width="250.26" height="336.185" />
                                                <rect x="43.998" y="236.226" fill="#FFFFFF" width="250.26" height="336.184" />
                                                <g>
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="204.182" y1="300.073" x2="254.791" y2="300.073" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="83.465" y1="329.29" x2="126.63" y2="329.29" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="83.465" y1="358.505" x2="254.791" y2="358.505" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="83.465" y1="387.718" x2="254.791" y2="387.718" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="83.465" y1="416.933" x2="254.791" y2="416.933" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="83.465" y1="446.144" x2="254.791" y2="446.144" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="83.465" y1="475.364" x2="254.791" y2="475.364" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="211.573" y1="504.575" x2="254.791" y2="504.575" />
                                                </g>
                                                <g>
                                                    <g>
                                                        <polygon fill="#FF5743" points="227.967,175.382 208.218,206.327 188.468,175.382 						" />
                                                    </g>
                                                    <text transform="matrix(1 0 0 1 232.1514 197.4478)" fill="#FFFFFF" font-family="'Montserrat-Regular'" font-size="46.3335">-90°</text>
                                                    <g>
                                                        <path fill="#FF5743" d="M198.719,180.301c0,0,0.069-1.327,0.199-3.813c0.068-0.727,0.145-1.539,0.229-2.432c0.086-0.894,0.175-1.879,0.338-2.851c0.155-0.992,0.296-2.062,0.498-3.194c0.229-1.127,0.472-2.325,0.728-3.591c1.138-5.034,3.068-11.038,6.222-17.464c3.143-6.42,7.637-13.201,13.63-19.561c6.025-6.314,13.6-12.167,22.533-16.534c8.908-4.379,19.171-7.222,29.891-7.797c10.709-0.599,21.849,1.028,32.275,5.064c10.418,4.021,19.987,10.466,27.738,18.561c7.712,8.137,13.598,17.914,17.036,28.289c3.452,10.364,4.479,21.283,3.414,31.444c-1.054,10.307-4.23,19.848-8.748,28.032c-4.509,8.194-10.309,14.974-16.408,20.26c-6.149,5.252-12.558,9.061-18.538,11.637c-5.986,2.583-11.488,4.063-16.067,4.866c-4.584,0.814-8.236,0.967-10.712,1.084c-2.479,0.002-3.803,0.004-3.803,0.004s1.319-0.069,3.793-0.199c2.461-0.244,6.083-0.582,10.573-1.62c4.483-1.025,9.824-2.765,15.54-5.588c5.712-2.814,11.738-6.84,17.393-12.193c5.608-5.387,10.801-12.15,14.658-20.105c3.868-7.921,6.365-17.079,6.843-26.548c0.509-9.586-0.975-19.448-4.575-28.682c-3.593-9.224-9.336-17.693-16.532-24.549c-7.239-6.814-15.914-12.002-25.095-15.012c-9.172-3.019-18.813-3.9-27.852-2.924c-9.057,0.958-17.492,3.792-24.687,7.802c-7.215,4.002-13.181,9.144-17.827,14.54c-4.611,5.443-7.95,11.1-10.197,16.371c-2.253,5.277-3.541,10.115-4.232,14.144c-0.15,1.011-0.292,1.967-0.426,2.868c-0.113,0.902-0.175,1.754-0.26,2.542c-0.097,0.807-0.112,1.48-0.141,2.106c-0.031,0.625-0.061,1.193-0.086,1.702c-0.002,2.467-0.003,3.782-0.003,3.782L198.719,180.301z" />
                                                    </g>
                                                </g>
                                            </g>
                                        </g>
                                    </g>
                                    <path fill="none" stroke="#FFFFFF" stroke-width="10.8476" stroke-miterlimit="10" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                </g>
                            </svg>
                        </div>
                        <span class="filter_name">Rotate Page -90°</span>
                    </div>
                    <div id="btn_RotateP90" class="filter" title="Rotate +90°" onclick="return applyFilter('rotate+90');">
                        <div class="icon">
                            <svg width="100%" height="100%" viewBox="0 0 512 512">
                                <g>
                                    <path opacity="0.25" fill="none" stroke="#969696" stroke-width="32.5429" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" enable-background="new" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                    <g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_1_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_2_">
                                                <use xlink:href="#SVGID_1_" overflow="visible" />
                                            </clipPath>
                                            <rect x="-19.502" y="-26.091" clip-path="url(#SVGID_2_)" fill="#1C84D1" width="543.091" height="543.103" />
                                        </g>
                                        <g>
                                            <defs>
                                                <path id="SVGID_3_" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                            </defs>
                                            <clipPath id="SVGID_4_">
                                                <use xlink:href="#SVGID_3_" overflow="visible" />
                                            </clipPath>
                                            <g clip-path="url(#SVGID_4_)">
                                                <g>
                                                    <rect x="1637.098" y="604.527" opacity="0.15" width="71.235" height="103.053" />
                                                    <rect x="1640.488" y="598.457" fill="#FFFFFF" width="71.235" height="103.053" />
                                                    <g>
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1685.803" y1="614.309" x2="1702.73" y2="614.309" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="622.625" x2="1666.248" y2="622.625" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="630.941" x2="1702.73" y2="630.941" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="639.258" x2="1702.73" y2="639.258" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="647.572" x2="1702.73" y2="647.572" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="655.89" x2="1702.73" y2="655.89" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1653.959" y1="664.205" x2="1702.73" y2="664.205" />
                                                        <line opacity="0.15" fill="none" stroke="#000000" stroke-width="3.9798" stroke-miterlimit="10" x1="1690.426" y1="672.521" x2="1702.73" y2="672.521" />
                                                    </g>
                                                    <g>
                                                        <circle fill="#DFFFFE" cx="1651.149" cy="653.323" r="23.516" />
                                                        <circle fill="none" stroke="#00AE64" stroke-width="3.9798" stroke-miterlimit="10" cx="1651.149" cy="653.323" r="23.516" />
                                                        <rect x="1662.759" y="673.098" transform="matrix(0.8399 -0.5427 0.5427 0.8399 -99.983 1011.9003)" fill="#00AE64" width="5.348" height="4.697" />
                                                        <path fill="#00AE64" d="M1671.859,678.12l21.506,33.304c1.225,1.898,0.68,4.434-1.219,5.659l0,0c-1.898,1.226-4.433,0.681-5.659-1.218l-21.505-33.305" />
                                                        <g>
                                                            <defs>
                                                                <circle id="SVGID_5_" cx="1651.148" cy="653.323" r="22.003" />
                                                            </defs>
                                                            <clipPath id="SVGID_6_">
                                                                <use xlink:href="#SVGID_5_" overflow="visible" />
                                                            </clipPath>

                                                            <line opacity="0.15" clip-path="url(#SVGID_6_)" fill="none" stroke="#000000" stroke-width="9.2861" stroke-miterlimit="10" x1="1649.912" y1="644.127" x2="1681.371" y2="644.127" />

                                                            <line opacity="0.15" clip-path="url(#SVGID_6_)" fill="none" stroke="#000000" stroke-width="9.2861" stroke-miterlimit="10" x1="1649.912" y1="658.78" x2="1681.371" y2="658.78" />
                                                        </g>
                                                        <path d="M1636.787,643.929c-0.65,1.156-1.212,0.505-0.613,1.774c0.271,0.571,0.646,1.448,1.413,1.381c0.093-0.412,0.36-0.793,0.347-1.221c-0.019-0.562-0.335-0.566-0.474-0.969c-0.104-0.302-0.08-0.684-0.005-0.972c-0.171,0.039-0.166-0.38-0.291-0.286L1636.787,643.929z" />
                                                        <path d="M1640.686,659.784c-0.76,0.049-1.306-0.261-0.77,0.595c0.166,0.264,0.461,0.584,0.756,0.65c0.039-0.457,0.98-0.838,0.145-1.113" />
                                                        <path d="M1654.877,650.98c-0.941-0.404-1.699-0.362-1.9,0.715c-0.071,0.375-0.213,0.41,0.014,0.679c0.324,0.383,1.277,0.3,1.68,0.122c0.228-0.101,1.119-0.541,1.179-0.688c0.188-0.459-0.319-0.842-0.71-0.895" />
                                                        <path d="M1659.082,663.924c-0.518,0.518-0.771,0.961-1.512,0.906c-0.748-0.055-0.84-0.268-1.553,0.229c0.691,0.286,3.027,0.913,2.735-0.479" />
                                                        <path d="M1653.234,658.93c-0.242-0.262-0.172-0.762-0.649-0.649c-0.032,0.104-0.034,0.335-0.001,0.442c0.082,0.004,0.168,0.021,0.25,0.02c0.017,0.292,0.256,0.463,0.452,0.646c0.019-0.102,0.03-0.224,0.015-0.327" />
                                                        <path d="M1648.568,633.637c-0.792,0.127-1.131,0.55-1.594,1.095c-0.301,0.351-0.9,1.29,0.101,1.079c0.374-0.078,0.854-0.87,1.181-1.125c0.258-0.202,0.691-0.373,0.576-0.853" />
                                                        <path d="M1659.869,637.184c0.438,0.018,0.949-0.232,1.419-0.379c0.015,0.22,0.095,0.431,0.239,0.577c-0.311,0.192-0.465-0.11-0.759-0.136c-0.342-0.029-0.651,0.08-0.899,0.201" />
                                                        <path d="M1656.65,671.348c-0.75,0.481-1.539,0.703-2.422,0.729c-0.273,0.008-1.301-0.139-1.513,0.205c-0.413,0.672,1.009,0.814,1.427,0.77c0.355-0.037,0.703-0.34,0.993-0.396c0.245-0.048,0.643,0.119,0.864,0.013c0.414-0.202,0.361-0.676,0.584-1.057" />
                                                        <path d="M1636.218,665.631c-0.523,0.223-1.831-0.322-1.333,0.533c0.477,0.813,0.826,0.24,1.168-0.02c0.215-0.16,0.459-0.113,0.561-0.447" />
                                                        <path d="M1645.285,648.944c-0.039,0.063-0.066,0.132-0.08,0.205c0.375,0.182,0.699,2.226,1.131,0.781C1646.622,648.973,1646.088,648.947,1645.285,648.944" />
                                                        <path d="M1634.051,653.938c-0.271,0.153-1.157,0.748-0.264,0.789c0.507,0.023,0.521-0.319,0.657-0.658" />
                                                        <path d="M1635.494,652.558c0.193,0.022,0.387,0.094,0.593,0.08c-0.05,0.083-0.104,0.035-0.196,0.052" />
                                                        <path d="M1639.043,650.98c0.117-0.021,0.303,0.057,0.447,0.006c0.084,0.225,0.109,0.47,0.068,0.709c-0.262,0.027-0.238-0.105-0.252-0.32" />
                                                        <path d="M1642.985,667.471c-0.192,0.096-0.358,0.225-0.538,0.262c0.504,0.344,1.055,0.35,0.801-0.393" />
                                                        <path d="M1655.337,653.084c0.671-0.407,1.069-0.653,1.831-0.664c-0.553,0.279-1.004,0.382-1.504,0.729" />
                                                        <path d="M1662.629,650.521c1.006,0,2,0.002,3.014,0c0.811-0.002,1.976-0.19,2.721,0.057c-0.363,0.623-2.077,0.336-2.65,0.336c-1.029,0-2.057,0-3.084,0" />
                                                    </g>
                                                </g>
                                                <g>
                                                    <line fill="none" stroke="#EF3400" stroke-width="3.9798" stroke-miterlimit="10" x1="1655.303" y1="659.979" x2="1643.897" y2="671.385" />
                                                    <line fill="none" stroke="#EF3400" stroke-width="3.9798" stroke-miterlimit="10" x1="1655.303" y1="671.385" x2="1643.897" y2="659.979" />
                                                </g>
                                            </g>
                                            <g clip-path="url(#SVGID_4_)">
                                                <polygon opacity="0.15" points="404.074,303.737 406.518,553.985 70.354,557.284 67.899,307.038 				" />
                                                <g>
                                                    <g>
                                                        <polyline fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" points="401.906,303.759 404.074,303.737 404.096,305.905" />
                                                        <line fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" stroke-dasharray="4.3915,8.783" x1="404.182" y1="314.688" x2="406.453" y2="547.426" />
                                                        <polyline fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" points="406.496,551.817 406.518,553.985 404.35,554.007" />
                                                        <line fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" stroke-dasharray="4.3097,8.6193" x1="395.73" y1="554.091" x2="76.832" y2="557.221" />
                                                        <polyline fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" points="72.523,557.263 70.354,557.284 70.333,555.116" />
                                                        <line fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" stroke-dasharray="4.3915,8.7829" x1="70.247" y1="546.333" x2="67.964" y2="313.598" />
                                                        <polyline fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" points="67.921,309.206 67.899,307.038 70.068,307.017" />
                                                        <line fill="none" stroke="#FFFFFF" stroke-width="4.3367" stroke-miterlimit="10" stroke-dasharray="4.3098,8.6196" x1="78.687" y1="306.933" x2="397.596" y2="303.801" />
                                                    </g>
                                                </g>
                                                <rect x="177.822" y="242.633" opacity="0.15" width="250.26" height="336.184" />
                                                <rect x="195.127" y="236.226" fill="#FFFFFF" width="250.26" height="336.184" />
                                                <g>

                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="355.311" y1="300.073" x2="405.92" y2="300.073" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="234.594" y1="329.29" x2="277.76" y2="329.29" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="234.594" y1="358.505" x2="405.92" y2="358.505" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="234.594" y1="387.718" x2="405.92" y2="387.718" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="234.594" y1="416.933" x2="405.92" y2="416.933" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="234.594" y1="446.144" x2="405.92" y2="446.144" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="234.594" y1="475.364" x2="405.92" y2="475.364" />
                                                    <line opacity="0.15" fill="none" stroke="#000000" stroke-width="13.01" stroke-miterlimit="10" x1="362.702" y1="504.575" x2="405.92" y2="504.575" />
                                                </g>
                                                <text transform="matrix(1 0 0 1 186.6152 197.4478)" fill="#FFFFFF" font-family="'Montserrat-Regular'" font-size="46.3335">+90°</text>
                                                <g>
                                                    <g>
                                                        <polygon fill="#FF5743" points="297.923,175.382 317.672,206.327 337.422,175.382" />
                                                    </g>
                                                    <g>
                                                        <path fill="#FF5743" d="M309.829,180.74c0,0-0.001-1.315-0.003-3.782c-0.025-0.508-0.055-1.077-0.086-1.702c-0.028-0.625-0.044-1.299-0.141-2.106c-0.085-0.788-0.146-1.64-0.26-2.542c-0.134-0.9-0.275-1.857-0.426-2.868c-0.691-4.029-1.979-8.867-4.232-14.144c-2.247-5.271-5.586-10.928-10.197-16.371c-4.646-5.396-10.612-10.538-17.827-14.54c-7.194-4.009-15.63-6.843-24.687-7.801c-9.038-0.977-18.68-0.095-27.852,2.924c-9.181,3.009-17.855,8.197-25.095,15.012c-7.196,6.856-12.939,15.325-16.532,24.548c-3.601,9.235-5.084,19.096-4.575,28.683c0.478,9.47,2.975,18.628,6.843,26.548c3.858,7.955,9.05,14.718,14.658,20.105c5.654,5.354,11.681,9.379,17.392,12.193c5.717,2.823,11.058,4.562,15.541,5.588c4.49,1.038,8.112,1.376,10.573,1.62c2.474,0.13,3.793,0.199,3.793,0.199s-1.323-0.001-3.803-0.004c-2.476-0.118-6.128-0.27-10.712-1.084c-4.578-0.804-10.08-2.283-16.067-4.867c-5.98-2.576-12.389-6.385-18.538-11.637c-6.1-5.286-11.9-12.065-16.409-20.26c-4.518-8.184-7.695-17.725-8.748-28.032c-1.065-10.161-0.038-21.081,3.414-31.444c3.439-10.375,9.325-20.152,17.036-28.289c7.751-8.095,17.32-14.539,27.739-18.561c10.426-4.036,21.565-5.663,32.274-5.064c10.72,0.575,20.982,3.418,29.891,7.797c8.934,4.367,16.508,10.22,22.533,16.534c5.993,6.36,10.487,13.141,13.63,19.561c3.153,6.426,5.084,12.43,6.222,17.464c0.256,1.266,0.499,2.464,0.728,3.591c0.202,1.132,0.343,2.202,0.498,3.194c0.163,0.972,0.252,1.958,0.338,2.851c0.084,0.894,0.16,1.705,0.229,2.432c0.13,2.487,0.199,3.813,0.199,3.813L309.829,180.74z" />
                                                    </g>
                                                </g>
                                            </g>
                                        </g>
                                    </g>
                                    <path fill="none" stroke="#FFFFFF" stroke-width="10.8476" stroke-miterlimit="10" d="M491.889,256c0,130.279-105.608,235.889-235.883,235.889C125.728,491.889,20.111,386.279,20.111,256c0-130.277,105.616-235.889,235.895-235.889C386.279,20.111,491.889,125.723,491.889,256z" />
                                </g>
                            </svg>
                        </div>
                        <span class="filter_name">Rotate Page +90°</span>
                    </div>
                </div>
            </div>
        </nav>
        <cc1:DocuVieware ID="DocuVieware1" runat="server"
            Height="100%"
            Width="100%"
            EmbedJQuery="False"
            SinglePageView="True"
            ForceScrollBars="False"
            AllowedExportFormats="*"
            MaxUploadSize="52428800"
            CollapsedSnapIn="False"
            ShowAnnotationsSnapIn="False"
            EnableRotateButtons="False"
            EnableMultipleThumbnailSelection="True"
            EnableTwainAcquisitionButton="True"
            EnableFormFieldsEdition="False"
            EnableThumbnailDragDrop="True" />
    </form>
</body>
</html>
