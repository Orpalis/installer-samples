VERSION 5.00
Object = "{B5893B58-701E-4110-9871-1DA14CF9C1DC}#14.2#0"; "mscoree.dll"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   10725
   ClientLeft      =   225
   ClientTop       =   870
   ClientWidth     =   14475
   LinkTopic       =   "Form1"
   ScaleHeight     =   10725
   ScaleWidth      =   14475
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin GdPicture_NET_14Ctl.GdViewer GdViewer1 
      Height          =   4215
      Left            =   4920
      TabIndex        =   0
      Top             =   1680
      Width           =   3615
      BackColor       =   "0"
      EnableDeferredPainting=   "True"
      PageDisplayMode =   "MultiplePagesView"
      EnableTextSelection=   "True"
      PreserveViewRotation=   "True"
      AnnotationResizeRotateHandlesScale=   "1"
      AnnotationDropShadow=   "False"
      AnnotationEnableMultiSelect=   "True"
      AllowDropFile   =   "False"
      HQAnnotationRendering=   "True"
      RenderGdPictureAnnots=   "True"
      EnableICM       =   "False"
      ZoomCenterAtMousePosition=   "False"
      EnabledProgressBar=   "True"
      DrawPageBorders =   "True"
      PageBordersPenSize=   "1"
      PageBordersColor=   "-16777216"
      PdfShowDialogForPassword=   "True"
      PdfShowOpenFileDialogForDecryption=   "True"
      PdfEnableFileLinks=   "True"
      PdfIncreaseTextContrast=   "False"
      PdfVerifyDigitalCertificates=   "False"
      ScrollBars      =   "True"
      ForceScrollBars =   "False"
      EnableMenu      =   "True"
      EnableFuzzySearch=   "False"
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
      ForceTemporaryMode=   "False"
      IgnoreDocumentResolution=   "False"
      LockViewer      =   "False"
      ZoomMode        =   "ZoomMode100"
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
      ClipRegionsToPageBounds=   "True"
      ClipAnnotsToPageBounds=   "True"
      ContinuousViewMode=   "True"
      MouseButtonForMouseMode=   "MouseButtonLeft"
      ForeColor       =   "Black"
      Location        =   "328, 112"
      Name            =   "GdViewer"
      Size            =   "241, 281"
      Object.TabIndex        =   "0"
   End
   Begin GdPicture_NET_14Ctl.AnnotationEditor AnnotationEditor1 
      Height          =   4575
      Left            =   10440
      TabIndex        =   1
      Top             =   2400
      Width           =   3375
      BackColor       =   "-2147483633"
      Location        =   "696, 160"
      Name            =   "AnnotationEditor"
      Size            =   "225, 305"
      Object.TabIndex        =   "0"
   End
   Begin GdPicture_NET_14Ctl.ThumbnailEx ThumbnailEx1 
      Height          =   4455
      Left            =   960
      TabIndex        =   2
      Top             =   1200
      Width           =   2055
      DefaultItemTextPrefix=   ""
      PdfIncreaseTextContrast=   "False"
      RotateExif      =   "True"
      OwnDrop         =   "False"
      PauseThumbsLoading=   "False"
      DisplayAnnotations=   "True"
      PreloadAllItems =   "True"
      ThumbnailBackColor=   "8421504"
      SelectedThumbnailBackColor=   "16750899"
      SelectedThumbnailBackColorAlpha=   "100"
      EnableDropShadow=   "True"
      HorizontalTextAlignment=   "TextAlignmentCenter"
      VerticalTextAlignment=   "TextAlignmentCenter"
      ThumbnailBorder =   "False"
      ThumbnailAlignment=   "ThumbnailAlignmentVertical"
      ShowText        =   "True"
      CheckBoxes      =   "False"
      CheckBoxesMarginLeft=   "0"
      CheckBoxesMarginTop=   "0"
      TextMarginLeft  =   "0"
      TextMarginTop   =   "0"
      MultiSelect     =   "False"
      DefaultItemCheckState=   "False"
      AllowMoveItems  =   "False"
      AllowDropFiles  =   "False"
      LockGdViewerEvents=   "False"
      HotTracking     =   "False"
      BackColor       =   "-2147483633"
      Location        =   "64, 80"
      Name            =   "ThumbnailEx"
      Size            =   "137, 297"
      Object.TabIndex        =   "0"
   End
   Begin VB.Menu msFile 
      Caption         =   "File"
      Begin VB.Menu mnOpen 
         Caption         =   "Open"
      End
      Begin VB.Menu mnTwain 
         Caption         =   "Acquire from TWAIN"
      End
      Begin VB.Menu mnClose 
         Caption         =   "Close"
      End
      Begin VB.Menu mnSaveJpg 
         Caption         =   "Save to Jpeg..."
      End
      Begin VB.Menu mnSavePDF 
         Caption         =   "Save to Pdf..."
      End
      Begin VB.Menu mnSaveTiff 
         Caption         =   "Save To Tiff..."
      End
      Begin VB.Menu mnSeeyou 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu mnExtras 
      Caption         =   "Extras"
      Begin VB.Menu mnConvert 
         Caption         =   "Convert Image To PDF using GdPictureImaging"
      End
      Begin VB.Menu mnpdf2tif 
         Caption         =   "Convert PDF to TIFF"
      End
   End
   Begin VB.Menu mnAnnotations 
      Caption         =   "Annotations"
      Begin VB.Menu mnAddStickyNote 
         Caption         =   "Add Sticky Note"
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private m_NativeImageID As Long
Private m_GdPictureImaging As New GdPictureImaging

Private Sub Form_Load()
 Dim oLic As New LicenseManager
 Call oLic.RegisterKEY("XXX")  'Please replace XXXX by a valid demo or commercial license KEY
  
 AnnotationEditor1.LoadFromGdViewer (GdViewer1.GetObject())
End Sub


Private Sub Form_Resize()
    If Me.Height > 1000 And Me.Width > 300 Then
        ThumbnailEx1.Left = 1
        ThumbnailEx1.Top = 1
        ThumbnailEx1.Width = Me.Width / 5
        ThumbnailEx1.Height = Me.Height - 1000
        ThumbnailEx1.Visible = True
        
        GdViewer1.Left = Me.Width / 5
        GdViewer1.Top = 1
        GdViewer1.Width = Me.Width * 3 / 5 - 300
        GdViewer1.Height = Me.Height - 1000
        GdViewer1.Visible = True
        
        AnnotationEditor1.Left = Me.Width * 4 / 5
        AnnotationEditor1.Top = 1
        AnnotationEditor1.Width = Me.Width / 5 - 300
        AnnotationEditor1.Height = Me.Height - 1000
        AnnotationEditor1.Visible = True
    End If
End Sub


Private Sub mnAddStickyNote_Click()
Call GdViewer1.AddStickyNoteAnnotationInteractive("Sticky Note", GdViewer1.ARGBI(255, 0, 0, 0), "Arial", FontStyle_Regular, 10, 1, 10)
End Sub


Private Sub mnClose_Click()
CloseNativeDocument
End Sub


Private Sub CloseNativeDocument()
ThumbnailEx1.ClearAllItems
Call GdViewer1.CloseDocument
If m_NativeImageID <> 0 Then
   m_GdPictureImaging.ReleaseGdPictureImage (m_NativeImageID)
   m_NativeImageID = 0
End If
End Sub


Private Sub mnConvert_Click()
  Dim m_GdPictureImaging As New GdPictureImaging
  Dim ImageID As Long

  ImageID = m_GdPictureImaging.CreateGdPictureImageFromFile("")
  Call m_GdPictureImaging.SaveAsPDF(ImageID, App.Path & "\output.pdf", True, "Title", "Author", "Subject", "KeyWords", "Creator")
  m_GdPictureImaging.ReleaseGdPictureImage (ImageID)
End Sub


Private Sub mnOpen_Click()
  CloseNativeDocument
  Call GdViewer1.DisplayFromFile("")
  ThumbnailEx1.LoadFromGdViewer (GdViewer1.GetObject())
End Sub

Private Sub mnpdf2tif_Click()
 Dim FileIn As String
 Dim FileOut As String
 Dim oGdPicturePDF As New GdPicturePDF
 Dim X As Integer
 Dim ImageID As Integer
 Dim TiffID As Integer
 Dim PageCount As Integer
 
 FileIn = "c:\test.pdf"
 FileOut = "c:\test.tif"
 PageCount = 0
 If oGdPicturePDF.LoadFromFile(FileIn, False) = GdPictureStatus_OK Then
   For X = 1 To oGdPicturePDF.GetPageCount()
      oGdPicturePDF.SelectPage (X)
      ImageID = oGdPicturePDF.RenderPageToGdPictureImageEx(200, True)
      If ImageID <> 0 Then
         PageCount = PageCount + 1
         If PageCount = 1 Then
            TiffID = ImageID
            Call m_GdPictureImaging.TiffSaveAsMultiPageFile(TiffID, FileOut, TiffCompression_TiffCompressionAUTO)
         Else
            Call m_GdPictureImaging.TiffAddToMultiPageFile(TiffID, ImageID)
         End If
         m_GdPictureImaging.ReleaseGdPictureImage (ImageID)
      Else
        MsgBox "Error rendering page " & Str(X)
      End If
   Next X
   m_GdPictureImaging.TiffCloseMultiPageFile (TiffID)
   MsgBox "Done!"
 Else
    MsgBox "can't open " + FileIn
 End If

End Sub


Private Sub mnSaveJpg_Click()
  Call GdViewer1.SaveDocumentToJPEG("", 72)
End Sub

Private Sub mnSavePDF_Click()
Call GdViewer1.SaveDocumentToPDF("")
End Sub

Private Sub mnSaveTiff_Click()
Call GdViewer1.SaveDocumentToTIFF("", TiffCompression_TiffCompressionAUTO)
End Sub

Private Sub mnSeeyou_Click()
  End
End Sub


Private Sub mnTwain_Click()
  CloseNativeDocument
  m_GdPictureImaging.TwainSelectSource (Me.hWnd)
  m_GdPictureImaging.TwainOpenDefaultSource (Me.hWnd)
  m_NativeImageID = m_GdPictureImaging.TwainAcquireToGdPictureImage(Me.hWnd)
  GdViewer1.DisplayFromGdPictureImage (m_NativeImageID)
  ThumbnailEx1.LoadFromGdViewer (GdViewer1.GetObject())
End Sub
