VERSION 5.00
Object = "{B5893B58-701E-4110-9871-1DA14CF9C1DC}#14.0#0"; "mscoree.dll"
Begin VB.Form Form1 
   Caption         =   "ActiveX TWAIN Acquisition Sample - http://www.gdpicture.com "
   ClientHeight    =   8220
   ClientLeft      =   2145
   ClientTop       =   2340
   ClientWidth     =   13470
   LinkTopic       =   "Form1"
   ScaleHeight     =   8220
   ScaleWidth      =   13470
   Begin GdPicture_NET_14Ctl.GdViewer GdViewer1 
      Height          =   6015
      Left            =   5640
      TabIndex        =   35
      Top             =   120
      Width           =   7575
      BackColor       =   "0"
      EnableTextSelection=   "True"
      PdfRasterizerEngine=   "PdfRasterizerEngineHybrid"
      AnnotationDropShadow=   "False"
      AllowDropFile   =   "False"
      HQAnnotationRendering=   "True"
      EnableICM       =   "False"
      ZoomCenterAtMousePosition=   "False"
      EnabledProgressBar=   "True"
      PdfShowDialogForPassword=   "True"
      PdfShowOpenFileDialogForDecryption=   "True"
      PdfEnableFileLinks=   "True"
      PdfIncreaseTextContrast=   "False"
      PdfVerifyDigitalCertificates=   "False"
      ScrollBars      =   "True"
      ForceScrollBars =   "False"
      EnableMenu      =   "True"
      Zoom            =   "1"
      ViewRotation    =   "RotateNoneFlipNone"
      MouseMode       =   "MouseModePan"
      MagnifierWidth  =   "160"
      MagnifierHeight =   "90"
      MagnifierZoomX  =   "2"
      MagnifierZoomY  =   "2"
      ZoomStep        =   "25"
      RectBorderSize  =   "1"
      ScrollSmallChange=   "1"
      ScrollLargeChange=   "50"
      SilentMode      =   "True"
      IgnoreDocumentResolution=   "False"
      LockViewer      =   "False"
      ZoomMode        =   "ZoomModeFitToViewer"
      EnableMouseWheel=   "True"
      DocumentAlignment=   "DocumentAlignmentMiddleCenter"
      DocumentPosition=   "DocumentPositionMiddleCenter"
      AnimateGIF      =   "True"
      DisplayQuality  =   "DisplayQualityAutomatic"
      DisplayQualityAuto=   "True"
      PdfDisplayFormField=   "True"
      PdfEnableLinks  =   "True"
      KeepDocumentPosition=   "False"
      MouseWheelMode  =   "MouseWheelModeZoom"
      Gamma           =   "1"
      RectIsEditable  =   "True"
      RegionsAreEditable=   "True"
      ContinuousViewMode=   "True"
      MouseButtonForMouseMode=   "MouseButtonLeft"
      ForeColor       =   "Black"
      Location        =   "376, 8"
      Name            =   "GdViewer"
      Size            =   "505, 401"
      Object.TabIndex        =   "0"
   End
   Begin VB.CommandButton Command12 
      Caption         =   "Demo 5: Scan all document feeder  into multipage PDF"
      Height          =   615
      Left            =   10680
      TabIndex        =   34
      Top             =   6960
      Width           =   2535
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Demo 4: Scan all document feeder (ADF) into jpeg files"
      Height          =   615
      Left            =   8040
      TabIndex        =   33
      Top             =   6960
      Width           =   2535
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Demo 3: Scan all document feeder (ADF) into multipage TIFF image multipage.tif"
      Height          =   615
      Left            =   5400
      TabIndex        =   32
      Top             =   6960
      Width           =   2535
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Demo 2: Scan one document to pdf file (acquire.pdf)"
      Height          =   615
      Left            =   2760
      TabIndex        =   31
      Top             =   6960
      Width           =   2535
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Demo 1: Scan one document to jpeg file (acquire.jpg)"
      Height          =   615
      Left            =   120
      TabIndex        =   30
      Top             =   6960
      Width           =   2535
   End
   Begin VB.CheckBox chkPreview 
      Caption         =   "Preview"
      Height          =   255
      Left            =   5640
      TabIndex        =   29
      Top             =   6360
      Value           =   1  'Checked
      Width           =   2055
   End
   Begin VB.CheckBox chkRemoveDots 
      Caption         =   "Remove isolated dots"
      Height          =   255
      Left            =   3360
      TabIndex        =   28
      Top             =   6120
      Width           =   2055
   End
   Begin VB.CheckBox chkRotate180 
      Caption         =   "Rotate 180°"
      Height          =   255
      Left            =   3360
      TabIndex        =   27
      Top             =   5880
      Width           =   1695
   End
   Begin VB.CheckBox chkRotate90 
      Caption         =   "Rotate 90°"
      Height          =   255
      Left            =   3360
      TabIndex        =   26
      Top             =   5640
      Width           =   1695
   End
   Begin VB.CheckBox chkRemoveBlankPages 
      Caption         =   "Discard blank pages"
      Height          =   255
      Left            =   120
      TabIndex        =   25
      Top             =   6360
      Width           =   2175
   End
   Begin VB.CheckBox chkAutoDesk 
      Caption         =   "Auto Deskew"
      Height          =   255
      Left            =   120
      TabIndex        =   24
      Top             =   6120
      Width           =   2175
   End
   Begin VB.CheckBox ChkAutoCrop 
      Caption         =   "Remove Black Borders"
      Height          =   255
      Left            =   120
      TabIndex        =   23
      Top             =   5880
      Width           =   2175
   End
   Begin VB.CheckBox chkNeg 
      Caption         =   "Negative"
      Height          =   255
      Left            =   120
      TabIndex        =   22
      Top             =   5640
      Width           =   1695
   End
   Begin VB.CheckBox chkHideUI 
      Alignment       =   1  'Right Justify
      Caption         =   "Hide UI"
      Height          =   255
      Left            =   3480
      TabIndex        =   21
      Top             =   5160
      Value           =   1  'Checked
      Width           =   2055
   End
   Begin VB.CheckBox chkDuplex 
      Caption         =   "Enable Duplex"
      Height          =   255
      Left            =   120
      TabIndex        =   20
      Top             =   5160
      Value           =   1  'Checked
      Width           =   1695
   End
   Begin VB.CheckBox chkIndicator 
      Alignment       =   1  'Right Justify
      Caption         =   "Show Progress Indicator"
      Height          =   255
      Left            =   3480
      TabIndex        =   19
      Top             =   4920
      Width           =   2055
   End
   Begin VB.HScrollBar HContrast 
      Height          =   255
      Left            =   120
      Max             =   1000
      Min             =   -1000
      TabIndex        =   15
      Top             =   4440
      Width           =   5415
   End
   Begin VB.CheckBox chkAutoBrightness 
      Caption         =   "Auto-Brightness"
      Height          =   255
      Left            =   120
      TabIndex        =   13
      Top             =   3840
      Value           =   1  'Checked
      Width           =   1695
   End
   Begin VB.HScrollBar HBrightness 
      Height          =   255
      Left            =   120
      Max             =   1000
      Min             =   -1000
      TabIndex        =   9
      Top             =   3360
      Width           =   5415
   End
   Begin VB.CommandButton Command7 
      Caption         =   "Show TWAIN State"
      Height          =   375
      Left            =   1800
      TabIndex        =   6
      Top             =   2040
      Width           =   2415
   End
   Begin VB.CommandButton Command11 
      Caption         =   "Unload source manager"
      Height          =   375
      Left            =   3000
      TabIndex        =   5
      Top             =   1440
      Width           =   2415
   End
   Begin VB.CommandButton Command6 
      Caption         =   "Source SETUP..."
      Height          =   375
      Left            =   360
      TabIndex        =   4
      Top             =   1440
      Width           =   2415
   End
   Begin VB.CommandButton Command10 
      Caption         =   "Close source manager"
      Height          =   375
      Left            =   3000
      TabIndex        =   3
      Top             =   960
      Width           =   2415
   End
   Begin VB.CommandButton Command8 
      Caption         =   "Open selected source"
      Height          =   375
      Left            =   360
      TabIndex        =   2
      Top             =   960
      Width           =   2415
   End
   Begin VB.CommandButton Command9 
      Caption         =   "Close source"
      Height          =   375
      Left            =   3000
      TabIndex        =   1
      Top             =   480
      Width           =   2415
   End
   Begin VB.CommandButton Command5 
      Caption         =   "Select source"
      Height          =   375
      Left            =   360
      TabIndex        =   0
      Top             =   480
      Width           =   2415
   End
   Begin VB.Line Line3 
      X1              =   120
      X2              =   13200
      Y1              =   6720
      Y2              =   6720
   End
   Begin VB.Line Line2 
      X1              =   120
      X2              =   5400
      Y1              =   5520
      Y2              =   5520
   End
   Begin VB.Label Label9 
      Alignment       =   1  'Right Justify
      Caption         =   "+1000"
      Height          =   255
      Left            =   4920
      TabIndex        =   18
      Top             =   4680
      Width           =   615
   End
   Begin VB.Label Label8 
      Alignment       =   2  'Center
      Caption         =   "0"
      Height          =   255
      Left            =   2520
      TabIndex        =   17
      Top             =   4680
      Width           =   615
   End
   Begin VB.Label Label7 
      Caption         =   "-1000"
      Height          =   255
      Left            =   120
      TabIndex        =   16
      Top             =   4680
      Width           =   615
   End
   Begin VB.Label Label6 
      Caption         =   "Contrast"
      Height          =   255
      Left            =   120
      TabIndex        =   14
      Top             =   4200
      Width           =   855
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
      Caption         =   "+1000"
      Height          =   255
      Left            =   4920
      TabIndex        =   12
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      Caption         =   "0"
      Height          =   255
      Left            =   2520
      TabIndex        =   11
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label Label3 
      Caption         =   "-1000"
      Height          =   255
      Left            =   120
      TabIndex        =   10
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label Label2 
      Caption         =   "Brightness"
      Height          =   255
      Left            =   120
      TabIndex        =   8
      Top             =   3120
      Width           =   855
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "Basic device configuration"
      Height          =   255
      Left            =   1680
      TabIndex        =   7
      Top             =   2760
      Width           =   2895
   End
   Begin VB.Line Line1 
      X1              =   120
      X2              =   5400
      Y1              =   2640
      Y2              =   2640
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim oGdPictureImaging As New GdPictureImaging

Private Sub Form_Load()
  Dim oLicenseManager As New LicenseManager  'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
  oLicenseManager.RegisterKEY ("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
    End Sub


Private Function GdPictureColor(RGBColor As OLE_COLOR)
  Dim Red As Long
  Dim Green As Long
  Dim Blue As Long
  Red = RGBColor Mod &H100&
  Green = (RGBColor And &HFF00FF00) / &H100&
  Blue = (RGBColor And &HFF0000) / &H10000
  GdPictureColor = GdViewer1.ARGBI(255, Red, Green, Blue)
End Function

Private Sub InitScanConfig()

  oGdPictureImaging.TwainSetHideUI chkHideUI = 1
  oGdPictureImaging.TwainSetIndicators chkIndicator = 1
  If chkAutoBrightness Then
      oGdPictureImaging.TwainSetAutoBrightness True
  Else
      oGdPictureImaging.TwainSetAutoBrightness False
      oGdPictureImaging.TwainSetBrightness HBrightness.Value
  End If
  oGdPictureImaging.TwainSetContrast HContrast.Value
  oGdPictureImaging.TwainEnableDuplex chkDuplex
End Sub

Private Sub ApplyImageFilters(ByRef ImageId As Long)  'Note: we use Byref to eventually remove the page and set its ID to 0 in case of blank page

  If chkRemoveBlankPages Then
      If oGdPictureImaging.IsBlank_3(ImageId, 99, True) Then
          oGdPictureImaging.ReleaseGdPictureImage ImageId
          ImageId = 0
          Exit Sub
      End If
  End If

  If chkNeg Then
      oGdPictureImaging.FxNegative ImageId
  End If

  If chkRemoveDots And oGdPictureImaging.GetBitDepth(ImageId) = 1 Then
      oGdPictureImaging.FxBitonalRemoveIsolatedDots2x2 ImageId
  End If

  If chkRotate90 And chkRotate180 Then
      oGdPictureImaging.Rotate ImageId, RotateFlipType_Rotate270FlipNone
  Else
      If chkRotate90 Then
          oGdPictureImaging.Rotate ImageId, RotateFlipType_Rotate90FlipNone
      End If
      If chkRotate180 Then
          oGdPictureImaging.Rotate ImageId, RotateFlipType_Rotate180FlipNone
      End If
  End If

  If chkAutoDesk Then
      oGdPictureImaging.AutoDeskew_3 ImageId, 12, GdPictureColor(vbWhite), 0.25, False
  End If

  If ChkAutoCrop Then
      oGdPictureImaging.CropBlackBordersEx ImageId
  End If
End Sub

Private Sub DisplayImage(ImageId As Long)
  GdViewer1.DisplayFromGdPictureImage ImageId
  GdViewer1.CloseDocument_2 True
  DoEvents
End Sub

Private Sub Command1_Click()
'             Here we will scan in a 1bpp ccitt4 & 200 DPI from adf to multipage tif file
  Dim nImageCount As Long
  Dim ImageId As Long
  Dim MultiPageID  As Long
  
  nImageCount = 0
  ImageId = 0
  MultiPageID = 0

  If oGdPictureImaging.TwainOpenDefaultSource(Me.hWnd) Then
    nImageCount = 0

    InitScanConfig

    oGdPictureImaging.TwainSetAutoFeed True ' Set AutoFeed Enabled
    oGdPictureImaging.TwainSetAutoScan True ' To  achieve the maximum scanning rate

    oGdPictureImaging.TwainSetResolution 200
    oGdPictureImaging.TwainSetPixelType TwainPixelType_TWPT_BW ' Black & White
    oGdPictureImaging.TwainSetBitDepth 1 '  1 bpp
    Do
      ImageId = oGdPictureImaging.TwainAcquireToGdPictureImage(Me.hWnd)
      If ImageId <> 0 Then
          nImageCount = nImageCount + 1
          ApplyImageFilters (ImageId)
          If ImageId <> 0 Then
              If chkPreview Then
                  DisplayImage ImageId
              End If
              If nImageCount = 1 Then
                  MultiPageID = ImageId
                  oGdPictureImaging.TiffSaveAsMultiPageFile MultiPageID, "multipage.tif", TiffCompression_TiffCompressionCCITT4
              Else
                  oGdPictureImaging.TiffAddToMultiPageFile MultiPageID, ImageId
                  oGdPictureImaging.ReleaseGdPictureImage ImageId
              End If
          End If
      End If
    Loop While (oGdPictureImaging.TwainGetState() > TwainStatus_TWAIN_SOURCE_ENABLED)

    oGdPictureImaging.TiffCloseMultiPageFile MultiPageID
    oGdPictureImaging.TwainCloseSource
    MsgBox "Done !"
  Else
    MsgBox "can't open default source, twain state is: " + CStr(oGdPictureImaging.TwainGetState())
  End If
End Sub

Private Sub Command10_Click()
  oGdPictureImaging.TwainCloseSourceManager Me.hWnd
End Sub

Private Sub Command11_Click()
  oGdPictureImaging.TwainUnloadSourceManager Me.hWnd
End Sub

Private Sub Command12_Click()
  ' Here we will scan in a 1bpp  form adf to multiple page pdf file
  Dim ImageId As Long
  ImageId = 0
  Dim oGdPicturePDF As New GdPicturePDF

  If oGdPictureImaging.TwainOpenDefaultSource(Me.hWnd) Then
    InitScanConfig

    oGdPictureImaging.TwainSetAutoFeed True ' Set AutoFeed Enabled
    oGdPictureImaging.TwainSetAutoScan True  ' To  achieve the maximum scanning rate
    oGdPictureImaging.TwainSetResolution 200
    oGdPictureImaging.TwainSetPixelType TwainPixelType_TWPT_BW ' Black & White
    oGdPictureImaging.TwainSetBitDepth 1 '  1 bpp

    oGdPicturePDF.NewPDF

    Do
      ImageId = oGdPictureImaging.TwainAcquireToGdPictureImage(Me.hWnd)
      If ImageId <> 0 Then
        ApplyImageFilters ImageId
        If ImageId <> 0 Then
          If chkPreview Then
              DisplayImage ImageId
          End If
          oGdPicturePDF.AddImageFromGdPictureImage ImageId, False, True
          oGdPictureImaging.ReleaseGdPictureImage ImageId
        End If
      End If
    Loop While (oGdPictureImaging.TwainGetState() > TwainStatus_TWAIN_SOURCE_ENABLED)
    oGdPicturePDF.SaveToFile "output.pdf"
    oGdPicturePDF.CloseDocument

    oGdPictureImaging.TwainCloseSource
    MsgBox "Done !"
  Else
    MsgBox "can't open default source, twain state is: " + CStr(oGdPictureImaging.TwainGetState())
  End If

End Sub

Private Sub Command2_Click()
  ' Here we will scan in a 24bpp  & 300 DPI from ADF into separate jpeg files
  Dim nImageCount As Long
  Dim ImageId As Long


  If oGdPictureImaging.TwainOpenDefaultSource(Me.hWnd) Then
      nImageCount = 0

      InitScanConfig

      oGdPictureImaging.TwainSetAutoFeed True ' Set AutoFeed Enabled
      oGdPictureImaging.TwainSetAutoScan True ' To  achieve the maximum scanning rate

      oGdPictureImaging.TwainSetResolution 300
      oGdPictureImaging.TwainSetPixelType TwainPixelType_TWPT_RGB ' RGB
      oGdPictureImaging.TwainSetBitDepth 24 '  24 bpp

      Do
          ImageId = oGdPictureImaging.TwainAcquireToGdPictureImage(Me.hWnd)
          If ImageId <> 0 Then
              ApplyImageFilters ImageId
              If ImageId <> 0 Then
                  If chkPreview Then
                      DisplayImage ImageId
                  End If
                  nImageCount = nImageCount + 1
                  oGdPictureImaging.SaveAsJPEG_2 ImageId, "image" + CStr(nImageCount) + ".jpg", 75
                  oGdPictureImaging.ReleaseGdPictureImage ImageId
              End If

          End If

      Loop While oGdPictureImaging.TwainGetState() > TwainStatus_TWAIN_SOURCE_ENABLED

      oGdPictureImaging.TwainCloseSource
      MsgBox "Done !"
  Else
      MsgBox "can't open default source, twain state is: " + CStr(oGdPictureImaging.TwainGetState())
  End If

End Sub

Private Sub Command3_Click()
  ' Here we will scan in a 24bpp & 300 DPI PDF file
  Dim ImageId As Long

  If oGdPictureImaging.TwainOpenDefaultSource(Me.hWnd) Then
      InitScanConfig

      oGdPictureImaging.TwainSetResolution 300
      oGdPictureImaging.TwainSetPixelType TwainPixelType_TWPT_RGB  ' RGB
      oGdPictureImaging.TwainSetBitDepth 24 '  24 bpp

      ImageId = oGdPictureImaging.TwainAcquireToGdPictureImage(Me.hWnd)
      If ImageId <> 0 Then
          ApplyImageFilters ImageId
          If ImageId <> 0 Then
              If chkPreview Then
                  DisplayImage ImageId
              End If
              oGdPictureImaging.SaveAsPDF ImageId, "acquire.pdf", True, "", "", "", "", ""
              oGdPictureImaging.ReleaseGdPictureImage ImageId
          End If
      End If

      oGdPictureImaging.TwainCloseSource
      MsgBox "Done !"
  Else
      MsgBox "can't open default source, twain state is: " + CStr(oGdPictureImaging.TwainGetState())
  End If
End Sub

Private Sub Command4_Click()
  ' Here we will scan in a 24bpp  & 300 DPI  jpeg file
  Dim ImageId As Long

  If oGdPictureImaging.TwainOpenDefaultSource(Me.hWnd) Then

      InitScanConfig

      oGdPictureImaging.TwainSetResolution 300
      oGdPictureImaging.TwainSetPixelType TwainPixelType_TWPT_RGB ' RGB
      oGdPictureImaging.TwainSetBitDepth 24 '  24 bpp

      ImageId = oGdPictureImaging.TwainAcquireToGdPictureImage(Me.hWnd)
      If ImageId <> 0 Then
          ApplyImageFilters ImageId
          If ImageId <> 0 Then
              If chkPreview Then
                  DisplayImage ImageId
              End If
              oGdPictureImaging.SaveAsJPEG_2 ImageId, "acquire.jpg", 90
              oGdPictureImaging.ReleaseGdPictureImage ImageId
          End If

      End If
      oGdPictureImaging.TwainCloseSource
      MsgBox "Done !"
  Else
      MsgBox "can't open default source, twain state is: " + CStr(oGdPictureImaging.TwainGetState())
  End If

End Sub

Private Sub Command5_Click()
  oGdPictureImaging.TwainSelectSource (Me.hWnd)
End Sub

Private Sub Command6_Click()
  If oGdPictureImaging.TwainGetState < TwainStatus_TWAIN_SOURCE_OPEN Then
      MsgBox "You need to open a source first !"
  Else
      oGdPictureImaging.TwainShowSetupDialogSource Me.hWnd
  End If
End Sub

Private Sub Command7_Click()
  MsgBox CStr(oGdPictureImaging.TwainGetState())
End Sub

Private Sub Command8_Click()
  If Not (oGdPictureImaging.TwainOpenDefaultSource(Me.hWnd)) Then
      MsgBox "Can't open default source !"
  End If
End Sub

Private Sub Command9_Click()
  oGdPictureImaging.TwainCloseSource
End Sub



Private Sub Form_Unload(Cancel As Integer)
  oGdPictureImaging.TwainUnloadSourceManager Me.hWnd
End Sub
