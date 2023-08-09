VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.2#0"; "mscomctl.OCX"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TabCtl32.Ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "ComDlg32.OCX"
Object = "{B5893B58-701E-4110-9871-1DA14CF9C1DC}#14.1#0"; "GdPicture.NET.14.tlb"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   10245
   ClientLeft      =   750
   ClientTop       =   1455
   ClientWidth     =   15960
   LinkTopic       =   "Form1"
   ScaleHeight     =   10245
   ScaleWidth      =   15960
   WindowState     =   2  'Maximized
   Begin MSComDlg.CommonDialog ColorDialog1 
      Left            =   1800
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComDlg.CommonDialog OpenFileDialog1 
      Left            =   1200
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComctlLib.StatusBar StatusStrip 
      Align           =   2  'Align Bottom
      Height          =   255
      Left            =   0
      TabIndex        =   12
      Top             =   9990
      Width           =   15960
      _ExtentX        =   28152
      _ExtentY        =   450
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   2
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   1
            Object.Width           =   25056
            Key             =   "ToolStripStatusLabel1"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
         EndProperty
      EndProperty
   End
   Begin MSComDlg.CommonDialog SaveFileDialog1 
      Left            =   600
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   0
      Top             =   -120
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   32
      ImageHeight     =   32
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   24
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":0000
            Key             =   "tsHighlightedRectangle"
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":04CD
            Key             =   "tsFreeHandHighlighter"
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":0A6F
            Key             =   "tsRectangle"
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":0F90
            Key             =   "tsFilledRectangle"
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":1482
            Key             =   "tsEllipse"
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":1A1F
            Key             =   "tsFilledEllipse"
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":1F63
            Key             =   "tsEmbeddedImage"
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":2549
            Key             =   "tsRubberStamp"
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":2AC4
            Key             =   "tsLine"
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":2FE9
            Key             =   "tsConnectedLines"
         EndProperty
         BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":356E
            Key             =   "tsLineArraw"
         EndProperty
         BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":3AB8
            Key             =   "tsText"
         EndProperty
         BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":40D8
            Key             =   "tsStickyNote"
         EndProperty
         BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":468E
            Key             =   "tsFreeHand"
         EndProperty
         BeginProperty ListImage15 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":4CAD
            Key             =   "tsLink"
         EndProperty
         BeginProperty ListImage16 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":51A7
            Key             =   "tsPolygon"
         EndProperty
         BeginProperty ListImage17 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":56E1
            Key             =   "fsFreeHandPolygon"
         EndProperty
         BeginProperty ListImage18 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":5C77
            Key             =   "tsRuler"
         EndProperty
         BeginProperty ListImage19 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":61C6
            Key             =   "tsTriangle"
         EndProperty
         BeginProperty ListImage20 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":6869
            Key             =   "tsCross"
         EndProperty
         BeginProperty ListImage21 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":6F3B
            Key             =   "tsFirst"
         EndProperty
         BeginProperty ListImage22 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":80F1
            Key             =   "tsPrevious"
         EndProperty
         BeginProperty ListImage23 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":91EE
            Key             =   "tsNext"
         EndProperty
         BeginProperty ListImage24 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":A312
            Key             =   "tsLast"
         EndProperty
      EndProperty
   End
   Begin VB.PictureBox Picture3 
      Height          =   10335
      Left            =   19920
      ScaleHeight     =   10275
      ScaleWidth      =   4395
      TabIndex        =   3
      Top             =   240
      Width           =   4455
      Begin GdPicture_NET_14Ctl.AnnotationEditor AnnotationEditor1 
         Height          =   7215
         Left            =   120
         TabIndex        =   20
         Top             =   120
         Width           =   4095
         BackColor       =   "-2147483633"
         Location        =   "8, 8"
         Name            =   "AnnotationEditor"
         Size            =   "273, 481"
         Object.TabIndex        =   "0"
      End
      Begin VB.PictureBox Picture5 
         Height          =   2415
         Left            =   120
         ScaleHeight     =   2355
         ScaleWidth      =   4035
         TabIndex        =   8
         Top             =   7680
         Width           =   4095
         Begin VB.TextBox txtText 
            Height          =   645
            Left            =   1200
            MultiLine       =   -1  'True
            TabIndex        =   17
            Text            =   "Form1.frx":B4DF
            Top             =   1320
            Width           =   2775
         End
         Begin VB.PictureBox btFillingColor 
            BackColor       =   &H000000FF&
            Height          =   495
            Left            =   2760
            ScaleHeight     =   435
            ScaleWidth      =   1035
            TabIndex        =   15
            Top             =   840
            Width           =   1095
         End
         Begin VB.PictureBox btStrokingColor 
            Appearance      =   0  'Flat
            BackColor       =   &H00000000&
            ForeColor       =   &H80000008&
            Height          =   495
            Left            =   2760
            ScaleHeight     =   465
            ScaleWidth      =   1065
            TabIndex        =   14
            Top             =   360
            Width           =   1095
         End
         Begin VB.ListBox nupLineWidth 
            Height          =   255
            ItemData        =   "Form1.frx":B4F6
            Left            =   2760
            List            =   "Form1.frx":B503
            TabIndex        =   13
            Top             =   120
            Width           =   1095
         End
         Begin VB.Label Label4 
            Caption         =   "Default Text :"
            Height          =   255
            Left            =   240
            TabIndex        =   16
            Top             =   1320
            Width           =   2655
         End
         Begin VB.Label Label3 
            Caption         =   "Default Filling Color:"
            Height          =   255
            Left            =   240
            TabIndex        =   11
            Top             =   960
            Width           =   2655
         End
         Begin VB.Label Label2 
            Caption         =   "Default Stroking Color"
            Height          =   255
            Left            =   240
            TabIndex        =   10
            Top             =   480
            Width           =   2655
         End
         Begin VB.Label Label1 
            Caption         =   "Default line width (in inches)"
            Height          =   255
            Left            =   240
            TabIndex        =   9
            Top             =   120
            Width           =   2175
         End
      End
   End
   Begin VB.PictureBox Picture1 
      Height          =   10455
      Left            =   0
      ScaleHeight     =   10395
      ScaleWidth      =   5355
      TabIndex        =   1
      Top             =   240
      Width           =   5415
      Begin TabDlg.SSTab SSTab1 
         Height          =   8775
         Left            =   120
         TabIndex        =   2
         Top             =   240
         Width           =   5055
         _ExtentX        =   8916
         _ExtentY        =   15478
         _Version        =   393216
         Tabs            =   2
         Tab             =   1
         TabHeight       =   520
         TabCaption(0)   =   "Bookmarks"
         TabPicture(0)   =   "Form1.frx":B519
         Tab(0).ControlEnabled=   0   'False
         Tab(0).Control(0)=   "BookmarksTree1"
         Tab(0).ControlCount=   1
         TabCaption(1)   =   "Thumbnails"
         TabPicture(1)   =   "Form1.frx":B535
         Tab(1).ControlEnabled=   -1  'True
         Tab(1).Control(0)=   "ThumbnailEx1"
         Tab(1).Control(0).Enabled=   0   'False
         Tab(1).ControlCount=   1
         Begin GdPicture_NET_14Ctl.BookmarksTree BookmarksTree1 
            Height          =   8055
            Left            =   -74760
            TabIndex        =   19
            Top             =   480
            Width           =   4455
            ItemHeight      =   "20"
            FontSize        =   "10"
            DisableZoomDestination=   "False"
            FontName        =   "Helvetica"
            BackColor       =   "-2147483633"
            Location        =   "-4984, 32"
            Name            =   "BookmarksTree"
            Size            =   "297, 537"
            Object.TabIndex        =   "0"
         End
         Begin GdPicture_NET_14Ctl.ThumbnailEx ThumbnailEx1 
            Height          =   8175
            Left            =   120
            TabIndex        =   21
            Top             =   480
            Width           =   4815
            PdfRasterizerEngine=   "PdfRasterizerEngineHybrid"
            DefaultItemTextPrefix=   ""
            PdfIncreaseTextContrast=   "False"
            RotateExif      =   "True"
            OwnDrop         =   "False"
            PauseThumbsLoading=   "False"
            DisplayAnnotations=   "True"
            PreloadAllItems =   "True"
            ThumbnailBackColor=   "16777215"
            SelectedThumbnailBackColor=   "-14245670"
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
            AllowMoveItems  =   "False"
            AllowDropFiles  =   "False"
            LockGdViewerEvents=   "False"
            HotTracking     =   "False"
            BackColor       =   "-2147483633"
            Location        =   "8, 32"
            Name            =   "ThumbnailEx"
            Size            =   "321, 545"
            Object.TabIndex        =   "0"
         End
      End
   End
   Begin VB.PictureBox Picture2 
      Height          =   10455
      Left            =   5280
      ScaleHeight     =   10395
      ScaleWidth      =   14595
      TabIndex        =   0
      Top             =   240
      Width           =   14655
      Begin GdPicture_NET_14Ctl.GdViewer GdViewer1 
         Height          =   8175
         Left            =   240
         TabIndex        =   18
         Top             =   720
         Width           =   14175
         BackColor       =   "0"
         EnableDeferredPainting=   "True"
         PageDisplayMode =   "MultiplePagesView"
         EnableTextSelection=   "True"
         PdfRasterizerEngine=   "PdfRasterizerEngineHybrid"
         AnnotationResizeRotateHandlesScale=   "1"
         AnnotationDropShadow=   "False"
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
         ContinuousViewMode=   "True"
         MouseButtonForMouseMode=   "MouseButtonLeft"
         ForeColor       =   "Black"
         Location        =   "16, 48"
         Name            =   "GdViewer"
         Size            =   "945, 545"
         Object.TabIndex        =   "0"
      End
      Begin MSComctlLib.Toolbar Toolbar2 
         Height          =   630
         Left            =   720
         TabIndex        =   5
         Top             =   9000
         Width           =   5235
         _ExtentX        =   9234
         _ExtentY        =   1111
         ButtonWidth     =   1032
         ButtonHeight    =   1005
         Appearance      =   1
         ImageList       =   "ImageList1"
         HotImageList    =   "ImageList1"
         _Version        =   393216
         BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
            NumButtons      =   5
            BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsFirst"
               ImageKey        =   "tsFirst"
            EndProperty
            BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsPrevious"
               ImageKey        =   "tsPrevious"
               BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
                  NumButtonMenus  =   1
                  BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  EndProperty
               EndProperty
            EndProperty
            BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   4
               Object.Width           =   1612
            EndProperty
            BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsNext"
               ImageKey        =   "tsNext"
            EndProperty
            BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsLast"
               ImageKey        =   "tsLast"
               Object.Width           =   1e-4
               BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
                  NumButtonMenus  =   1
                  BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  EndProperty
               EndProperty
            EndProperty
         EndProperty
         Begin VB.PictureBox Picture4 
            Height          =   615
            Left            =   1320
            ScaleHeight     =   555
            ScaleWidth      =   1275
            TabIndex        =   6
            Top             =   0
            Width           =   1335
            Begin VB.Label lblCurrentPage 
               Alignment       =   2  'Center
               Caption         =   "0 / 0"
               Height          =   375
               Left            =   120
               TabIndex        =   7
               Top             =   120
               Width           =   1095
            End
         End
      End
      Begin MSComctlLib.Toolbar Toolbar1 
         Height          =   630
         Left            =   240
         TabIndex        =   4
         Top             =   0
         Width           =   14535
         _ExtentX        =   25638
         _ExtentY        =   1111
         ButtonWidth     =   1032
         ButtonHeight    =   1005
         Appearance      =   1
         ImageList       =   "ImageList1"
         DisabledImageList=   "ImageList1"
         HotImageList    =   "ImageList1"
         _Version        =   393216
         BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
            NumButtons      =   18
            BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsHighlightedRectangle"
               ImageKey        =   "tsHighlightedRectangle"
            EndProperty
            BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsFreeHandHighlighter"
               ImageKey        =   "tsFreeHandHighlighter"
            EndProperty
            BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsRectangle"
               ImageKey        =   "tsRectangle"
            EndProperty
            BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsFilledRectangle"
               ImageKey        =   "tsFilledRectangle"
               BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
                  NumButtonMenus  =   1
                  BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  EndProperty
               EndProperty
            EndProperty
            BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsEllipse"
               ImageKey        =   "tsEllipse"
            EndProperty
            BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsFilledEllipse"
               ImageKey        =   "tsFilledEllipse"
            EndProperty
            BeginProperty Button7 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsEmbeddedImage"
               ImageKey        =   "tsEmbeddedImage"
            EndProperty
            BeginProperty Button8 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsRubberStamp"
               ImageKey        =   "tsRubberStamp"
            EndProperty
            BeginProperty Button9 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsLine"
               ImageKey        =   "tsLine"
            EndProperty
            BeginProperty Button10 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsConnectedLines"
               ImageKey        =   "tsConnectedLines"
            EndProperty
            BeginProperty Button11 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsLineArraw"
               ImageKey        =   "tsLineArraw"
            EndProperty
            BeginProperty Button12 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsText"
               ImageKey        =   "tsText"
            EndProperty
            BeginProperty Button13 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsStickyNote"
               ImageKey        =   "tsStickyNote"
            EndProperty
            BeginProperty Button14 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsFreeHand"
               ImageKey        =   "tsFreeHand"
            EndProperty
            BeginProperty Button15 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsLink"
               ImageKey        =   "tsLink"
            EndProperty
            BeginProperty Button16 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsPolygon"
               ImageKey        =   "tsPolygon"
            EndProperty
            BeginProperty Button17 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "fsFreeHandPolygon"
               ImageKey        =   "fsFreeHandPolygon"
            EndProperty
            BeginProperty Button18 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "tsRuler"
               ImageKey        =   "tsRuler"
            EndProperty
         EndProperty
      End
   End
   Begin VB.Menu FileToolStripMenuItem 
      Caption         =   "File"
      Begin VB.Menu OpenToolStripMenuItem 
         Caption         =   "Open..."
      End
      Begin VB.Menu ToolStripMenuItem10 
         Caption         =   "Print..."
      End
      Begin VB.Menu SaveToolStripMenuItem 
         Caption         =   "Save..."
      End
      Begin VB.Menu CloseToolStripMenuItem 
         Caption         =   "Close"
      End
      Begin VB.Menu ExitToolStripMenuItem 
         Caption         =   "Exit"
      End
   End
   Begin VB.Menu viewToolStripMenuItem 
      Caption         =   "View"
      Begin VB.Menu PageToolStripMenuItem 
         Caption         =   "Page"
         Begin VB.Menu GotoFirstPageToolStripMenuItem 
            Caption         =   "Goto First Page"
         End
         Begin VB.Menu GotoPreviousPageToolStripMenuItem 
            Caption         =   "Goto Previous Page"
         End
         Begin VB.Menu GotoNextPageToolStripMenuItem 
            Caption         =   "Goto Next Page"
         End
         Begin VB.Menu GotoLastPageToolStripMenuItem 
            Caption         =   "Goto Last page"
         End
      End
      Begin VB.Menu ThumbnailsSizeToolStripMenuItem 
         Caption         =   "Thumbnails Size"
         Begin VB.Menu Small64X64ToolStripMenuItem 
            Caption         =   "Small (64 x 64)"
         End
         Begin VB.Menu Medium128X128ToolStripMenuItem 
            Caption         =   "Medium (128 x 128)"
         End
         Begin VB.Menu Large256256ToolStripMenuItem 
            Caption         =   "Large (256 * 256)"
            Checked         =   -1  'True
         End
      End
      Begin VB.Menu enableDropShadowToolStripMenuItem 
         Caption         =   "Enable Drop Shadow"
      End
   End
   Begin VB.Menu ToolStripMenuItem9 
      Caption         =   "Annotations"
      Begin VB.Menu ShowPageTextToolStripMenuItem 
         Caption         =   "Remove Selected Annotation"
         Shortcut        =   {DEL}
      End
      Begin VB.Menu RemoveAllAnnotationsToolStripMenuItem 
         Caption         =   "Remove All Annotations"
         Shortcut        =   +{DEL}
      End
      Begin VB.Menu SaveInXMPFormatToolStripMenuItem 
         Caption         =   "Save in XMP Format (current page) ..."
      End
      Begin VB.Menu saveInXMPFormatallPagesToolStripMenuItem 
         Caption         =   "Save in XMP Format (all pages) ..."
      End
      Begin VB.Menu LoadFromXMLFileToolStripMenuItem 
         Caption         =   "Load from XML File"
      End
      Begin VB.Menu BurnAnnotationToPageToolStripMenuItem 
         Caption         =   "Burn Annotation To Page"
      End
      Begin VB.Menu HQAnnotationRenderingToolStripMenuItem 
         Caption         =   "HQ Annotation Rendering"
         Checked         =   -1  'True
      End
   End
   Begin VB.Menu RotationToolStripMenuItem 
      Caption         =   "Rotation"
      Begin VB.Menu Rotate90ToolStripMenuItem 
         Caption         =   "Rotate 90?"
      End
      Begin VB.Menu Rotate180ToolStripMenuItem 
         Caption         =   "Rotate 180?"
      End
      Begin VB.Menu Rotate270ToolStripMenuItem 
         Caption         =   "Rotate 270?"
      End
   End
   Begin VB.Menu ZoomToolStripMenuItem 
      Caption         =   "Zoom"
      Begin VB.Menu ToolStripMenuItem6 
         Caption         =   "50 %"
      End
      Begin VB.Menu ToolStripMenuItem2 
         Caption         =   "100 %"
      End
      Begin VB.Menu ToolStripMenuItem3 
         Caption         =   "150 %"
      End
      Begin VB.Menu ToolStripMenuItem4 
         Caption         =   "200 %"
      End
      Begin VB.Menu ToolStripMenuItem1 
         Caption         =   "-"
      End
      Begin VB.Menu ZoomINToolStripMenuItem 
         Caption         =   "Zoom IN"
      End
      Begin VB.Menu ZoomOUTToolStripMenuItem 
         Caption         =   "Zoom OUT"
      End
      Begin VB.Menu ToolStripMenuItem5 
         Caption         =   "-"
      End
      Begin VB.Menu FitToViewerToolStripMenuItem 
         Caption         =   "Best Fit "
      End
      Begin VB.Menu FitToHeightToolStripMenuItem 
         Caption         =   "Fit To Height"
      End
      Begin VB.Menu FitToWidthToolStripMenuItem 
         Caption         =   "Fit To Width"
      End
   End
   Begin VB.Menu MouseModeToolStripMenuItem 
      Caption         =   "Mouse Options"
      Begin VB.Menu LeftClickToolStripMenuItem 
         Caption         =   "Left Click"
         Begin VB.Menu PanToolStripMenuItem 
            Caption         =   "Pan"
            Checked         =   -1  'True
         End
         Begin VB.Menu AutoZoomToolStripMenuItem 
            Caption         =   "Auto Zoom"
         End
         Begin VB.Menu ToolStripMenuItem8 
            Caption         =   "Area Selection"
         End
         Begin VB.Menu NothingToolStripMenuItem 
            Caption         =   "Nothing"
         End
      End
      Begin VB.Menu WhellToolStripMenuItem 
         Caption         =   "Mouse Wheel"
         Begin VB.Menu ZoomChangingToolStripMenuItem 
            Caption         =   "Zoom Changing"
            Checked         =   -1  'True
         End
         Begin VB.Menu PageScrollingToolStripMenuItem 
            Caption         =   "Page Scrolling"
         End
         Begin VB.Menu PageChangingToolStripMenuItem 
            Caption         =   "Page Changing"
         End
      End
   End
   Begin VB.Menu EditorModeToolStripMenuItem 
      Caption         =   "Editor Mode"
      Begin VB.Menu EnabledToolStripMenuItem 
         Caption         =   "Enabled"
         Checked         =   -1  'True
      End
      Begin VB.Menu DisabledToolStripMenuItem 
         Caption         =   "Disabled"
      End
   End
   Begin VB.Menu ToolStripMenuItem7 
      Caption         =   "About"
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
'Note :
' if you have problems with the Microsoft Common Control 6.0
' run the following in elevated command prompt
'
'cd C:\Windows\System32\
'regtlib msdatsrc.tlb
' or
'cd C:\Windows\SysWOW64\
'regtlib msdatsrc.tlb
'
'http://stackoverflow.com/questions/11982719/vb6-ide-cannot-load-mscomctl-ocx-after-update-kb-2687323
  Dim m_FillingColor As OLE_COLOR
  Dim m_StrokingColor As OLE_COLOR
  Dim m_LineWidth As Double

Private Function GdPictureColor(RGBColor As OLE_COLOR)
  Dim Red As Long
  Dim Green As Long
  Dim Blue As Long
  Red = RGBColor Mod &H100&
  Green = (RGBColor And &HFF00FF00) / &H100&
  Blue = (RGBColor And &HFF0000) / &H10000
  GdPictureColor = GdViewer1.ARGBI(255, Red, Green, Blue)
End Function


Private Sub CloseDocument()
        GdViewer1.CloseDocument
        GdViewer1.ZoomMode = ViewerZoomMode_ZoomModeWidthViewer
        GdViewer1.DocumentAlignment = ViewerDocumentAlignment_DocumentAlignmentTopCenter
        ThumbnailEx1.ClearAllItems
        ShowCurrentPage
End Sub

Private Sub ShowCurrentPage()
    If GdViewer1.CurrentPage <> 0 Then
        lblCurrentPage.Caption = CStr(GdViewer1.CurrentPage) + " / " + CStr(GdViewer1.pageCount)
    Else
        lblCurrentPage.Caption = ""
    End If
End Sub


Private Sub AutoZoomToolStripMenuItem_Click()
  
  GdViewer1.MouseMode = ViewerMouseMode_MouseModeAreaZooming
  PanToolStripMenuItem.Checked = False
  AutoZoomToolStripMenuItem.Checked = True
  ToolStripMenuItem8.Checked = False
  NothingToolStripMenuItem.Checked = False
  
End Sub

Private Sub btFillingColor_Click()
  GdViewer1.CancelLastAnnotInteractiveAdd
  ColorDialog1.Flags = cdlCCRGBInit
  ColorDialog1.Color = m_FillingColor
  On Error Resume Next
    ColorDialog1.ShowColor
    If Not Err Then
      m_FillingColor = ColorDialog1.Color
      btFillingColor.BackColor = m_FillingColor
    End If
  On Error GoTo 0

End Sub

Private Sub btStrokingColor_Click()
  GdViewer1.CancelLastAnnotInteractiveAdd
  ColorDialog1.Flags = cdlCCRGBInit
  ColorDialog1.Color = m_StrokingColor
  On Error Resume Next
    ColorDialog1.ShowColor
    If Not Err Then
      m_StrokingColor = ColorDialog1.Color
      btStrokingColor.BackColor = m_FillingColor
    End If
  On Error GoTo 0

End Sub

Private Sub BurnAnnotationToPageToolStripMenuItem_Click()
  GdViewer1.BurnAnnotationsToPage (True)
End Sub

Private Sub CloseToolStripMenuItem_Click()
  CloseDocument
End Sub

Private Sub DisabledToolStripMenuItem_Click()
  GdViewer1.SetAnnotationEditorMode False
  Toolbar1.Enabled = False
  EnabledToolStripMenuItem.Checked = False
  DisabledToolStripMenuItem.Checked = True

End Sub

Private Sub enableDropShadowToolStripMenuItem_Click()
    enableDropShadowToolStripMenuItem.Checked = (enableDropShadowToolStripMenuItem.Checked = False)
    GdViewer1.AnnotationDropShadow = enableDropShadowToolStripMenuItem.Checked
End Sub

Private Sub EnabledToolStripMenuItem_Click()
  GdViewer1.SetAnnotationEditorMode True
  Toolbar1.Enabled = True
  EnabledToolStripMenuItem.Checked = True
  DisabledToolStripMenuItem.Checked = False

End Sub

Private Sub ExitToolStripMenuItem_Click()
  CloseDocument
  Unload Me
End Sub

Private Sub FitToHeightToolStripMenuItem_Click()
  GdViewer1.ZoomMode = ViewerZoomMode_ZoomModeHeightViewer
End Sub

Private Sub FitToViewerToolStripMenuItem_Click()
  GdViewer1.ZoomMode = ViewerZoomMode_ZoomModeFitToViewer
End Sub

Private Sub FitToWidthToolStripMenuItem_Click()
  GdViewer1.ZoomMode = ViewerZoomMode_ZoomModeWidthViewer
End Sub

Private Sub Form_Load()
  Dim sPnt As Single
  Dim oLicenseManager As New LicenseManager
  oLicenseManager.RegisterKEY ("XXX") 'Please, replace XXX by a valid demo or commercial license key.
  
  'init vars
  GdViewer1.MouseMode = ViewerMouseMode_MouseModePan
  GdViewer1.SetAnnotationEditorMode True
  ThumbnailEx1.SetItemsSize 256, 256
  m_FillingColor = vbRed
  m_StrokingColor = vbBlack
  nupLineWidth.Clear
  For sPnt = 0 To 10 Step 0.01
    nupLineWidth.AddItem Format(sPnt, "00.00")
  Next
  m_LineWidth = 0.02
End Sub

Private Sub Form_Resize()
  Picture1.Move 0, 0, 5415, ScaleHeight
  Picture2.Move 5415, 0, ScaleWidth - 5415 * 2, ScaleHeight
  Picture3.Move ScaleWidth - 5415, 0, 5415, ScaleHeight
  SSTab1.Height = ScaleHeight - 250
  BookmarksTree1.Height = ScaleHeight - 750
  ThumbnailEx1.Height = ScaleHeight - 750
  AnnotationEditor1.Move 0, 0, Picture3.Width, ScaleHeight - 3000
  GdViewer1.Move 55, Toolbar1.Height + 55, Picture2.Width - 110, Picture2.Height - 110 - Toolbar1.Height * 2
  Picture5.Move 0, Picture3.Height - 3000, Picture3.Width
  Toolbar1.Move 0, 0, Picture2.Width
  Toolbar2.Move 0, ScaleHeight - 750, Picture2.Width
End Sub


Private Sub GdViewer1_PageChanged()
  ShowCurrentPage
End Sub

Private Sub GdViewer1_PageDisplayed()
  Dim WidthInches As Double
  Dim HeightInches As Double
  
  WidthInches = 0
  HeightInches = 0
  If GdViewer1.GetDocumentType() = DocumentType_DocumentTypePDF Then
      WidthInches = GdViewer1.PdfGetPageWidth() / 72
      HeightInches = GdViewer1.PdfGetPageHeight() / 72
  Else
      WidthInches = GdViewer1.PageWidth / GdViewer1.HorizontalResolution
      HeightInches = GdViewer1.PageHeight / GdViewer1.VerticalResolution
  End If
  StatusStrip.Panels("ToolStripStatusLabel1").Text = _
        "Page No : " + CStr(GdViewer1.CurrentPage) + _
        " / " + CStr(GdViewer1.pageCount) + _
        "   -   " + "Zoom : " + CStr(Round(GdViewer1.Zoom * 100, 2)) + _
        "%    -   " + "Page Size (inches) : " + CStr(Round(WidthInches, 2)) + _
        " * " + CStr(Round(HeightInches, 2)) + _
        "   -   " + "Page Size (pixels) : " + CStr(GdViewer1.PageWidth) + _
        " * " + CStr(GdViewer1.PageHeight) + _
        "   -   " + "Horizontal resolution : " + CStr(Round(GdViewer1.HorizontalResolution, 2)) + _
        " dpi   -   " + "Vertical resolution : " + CStr(Round(GdViewer1.VerticalResolution, 2)) + _
        " dpi"
End Sub

Private Sub GotoFirstPageToolStripMenuItem_Click()
  If GdViewer1.DisplayFirstPage <> GdPictureStatus_OK Then
      MsgBox "Error : " + CStr(GdViewer1.GetStat())
  End If
End Sub

Private Sub GotoLastPageToolStripMenuItem_Click()
  If GdViewer1.DisplayLastPage <> GdPictureStatus_OK Then
      MsgBox "Error : " + CStr(GdViewer1.GetStat())
  End If
End Sub

Private Sub GotoNextPageToolStripMenuItem_Click()
  If GdViewer1.DisplayNextPage <> GdPictureStatus_OK Then
      MsgBox "Error : " + CStr(GdViewer1.GetStat())
  End If
End Sub

Private Sub GotoPreviousPageToolStripMenuItem_Click()
  If GdViewer1.DisplayPreviousPage <> GdPictureStatus_OK Then
      MsgBox "Error : " + CStr(GdViewer1.GetStat())
  End If
End Sub

Private Sub HQAnnotationRenderingToolStripMenuItem_Click()
  HQAnnotationRenderingToolStripMenuItem.Checked = HQAnnotationRenderingToolStripMenuItem.Checked = False
  GdViewer1.HQAnnotationRendering = HQAnnotationRenderingToolStripMenuItem.Checked
End Sub

Private Sub Large256256ToolStripMenuItem_Click()
    ThumbnailEx1.SetItemsSize 256, 256
    Small64X64ToolStripMenuItem.Checked = False
    Medium128X128ToolStripMenuItem.Checked = False
    Large256256ToolStripMenuItem.Checked = True
End Sub


Private Sub LoadFromXMLFileToolStripMenuItem_Click()
  OpenFileDialog1.DialogTitle = "Load Annotations from XMP file"
  OpenFileDialog1.Filter = "XMP|*.xmp"
  OpenFileDialog1.DefaultExt = "xmp"
  On Error Resume Next
  OpenFileDialog1.ShowSave
  If Not Err Then
    Dim FilePath As String
    FilePath = OpenFileDialog1.FileName
    If (GdViewer1.LoadAnnotationsFromXMP(FilePath) <> GdPictureStatus_OK) Then
        MsgBox "Can't load annotations from " + FilePath
    End If
  End If
  On Error GoTo 0
End Sub

Private Sub Medium128X128ToolStripMenuItem_Click()
    ThumbnailEx1.SetItemsSize 128, 128
    Small64X64ToolStripMenuItem.Checked = False
    Medium128X128ToolStripMenuItem.Checked = True
    Large256256ToolStripMenuItem.Checked = False
End Sub

Private Sub NothingToolStripMenuItem_Click()
  GdViewer1.MouseMode = ViewerMouseMode_MouseModeDefault
  PanToolStripMenuItem.Checked = False
  AutoZoomToolStripMenuItem.Checked = False
  ToolStripMenuItem8.Checked = False
  NothingToolStripMenuItem.Checked = True

End Sub

Private Sub nupLineWidth_Click()
  Dim lstIndex As Integer
  If lstIndex >= 0 Then
    m_LineWidth = CDbl(nupLineWidth.List(lstIndex))
  End If
End Sub

Private Sub OpenToolStripMenuItem_Click()
    CloseDocument
    GdViewer1.DisplayFromFile ""
    GdViewer1.SetFocus
    ThumbnailEx1.LoadFromGdViewer GdViewer1.GetObject
    BookmarksTree1.LoadFromGdViewer GdViewer1.GetObject
    AnnotationEditor1.LoadFromGdViewer GdViewer1.GetObject
    ShowCurrentPage
End Sub

Private Sub PageChangingToolStripMenuItem_Click()
  GdViewer1.MouseWheelMode = ViewerMouseWheelMode_MouseWheelModePageChange
  PageChangingToolStripMenuItem.Checked = True
  ZoomChangingToolStripMenuItem.Checked = False
  ToolStripMenuItem8.Checked = False
  ToolStripMenuItem10.Checked = False

End Sub

Private Sub PageScrollingToolStripMenuItem_Click()
  GdViewer1.MouseWheelMode = ViewerMouseWheelMode_MouseWheelModeVerticalScroll
  ZoomChangingToolStripMenuItem.Checked = False
  PageScrollingToolStripMenuItem.Checked = True
  PageChangingToolStripMenuItem.Checked = False

End Sub

Private Sub PanToolStripMenuItem_Click()
  GdViewer1.MouseMode = ViewerMouseMode_MouseModePan
  PanToolStripMenuItem.Checked = True
  AutoZoomToolStripMenuItem.Checked = False
  ToolStripMenuItem8.Checked = False
  NothingToolStripMenuItem.Checked = False

End Sub

Private Sub RemoveAllAnnotationsToolStripMenuItem_Click()
    Do While (GdViewer1.GetAnnotationCount() > 0)
        GdViewer1.DeleteAnnotation (0)
    Loop
End Sub

Private Sub Rotate180ToolStripMenuItem_Click()
  If (GdViewer1.Rotate(RotateFlipType_Rotate180FlipNone) <> GdPictureStatus_OK) Then
      MsgBox "Error : " + CStr(GdViewer1.GetStat())
  End If
End Sub

Private Sub Rotate270ToolStripMenuItem_Click()
  If (GdViewer1.Rotate(RotateFlipType_Rotate270FlipNone) <> GdPictureStatus_OK) Then
      MsgBox "Error : " + CStr(GdViewer1.GetStat())
  End If

End Sub

Private Sub Rotate90ToolStripMenuItem_Click()
  If (GdViewer1.Rotate(RotateFlipType_Rotate90FlipNone) <> GdPictureStatus_OK) Then
      MsgBox "Error : " + CStr(GdViewer1.GetStat())
  End If
End Sub

Private Sub saveInXMPFormatallPagesToolStripMenuItem_Click()
    SaveFileDialog1.DialogTitle = "Save Annotations As XMP"
    SaveFileDialog1.Filter = "XMP|*.xmp"
    SaveFileDialog1.DefaultExt = "xmp"
    On Error Resume Next
    SaveFileDialog1.ShowSave
    If Not Err Then
        Dim FilePath As String
        FilePath = SaveFileDialog1.FileName
        If (GdViewer1.SaveAnnotationsToXMPEx(FilePath) = GdPictureStatus_OK) Then
            MsgBox "Annotations succefully saved as XMP in " + FilePath
        Else
            MsgBox "Can't save annotations in " + FilePath
        End If
    End If
End Sub

Private Sub SaveInXMPFormatToolStripMenuItem_Click()
    SaveFileDialog1.DialogTitle = "Save Annotations As XMP"
    SaveFileDialog1.Filter = "XMP|*.xmp"
    SaveFileDialog1.DefaultExt = "xmp"
    On Error Resume Next
    SaveFileDialog1.ShowSave
    If Not Err Then
        Dim FilePath As String
        FilePath = SaveFileDialog1.FileName
        If (GdViewer1.SaveAnnotationsToXMP(FilePath) = GdPictureStatus_OK) Then
            MsgBox "Annotations succefully saved as XMP in " + FilePath
        Else
            MsgBox "Can't save annotations in " + FilePath
        End If
    End If
    On Error GoTo 0
End Sub

Private Sub SaveToolStripMenuItem_Click()

    SaveFileDialog1.DialogTitle = "Save Annotated Document"
    SaveFileDialog1.Filter = "PDF|*.pdf|TIFF Image|*.tif|JPEG|*.jpg"
    On Error Resume Next
    SaveFileDialog1.ShowSave
    If Not Err Then
      Dim FilePath As String
      FilePath = SaveFileDialog1.FileName
      Select Case SaveFileDialog1.FilterIndex
        Case 1:
          If (GdViewer1.SaveDocumentToPDF(SaveFileDialog1.FileName) = GdPictureStatus_OK) Then
              MsgBox "Document succefully saved as PDF in " + FilePath
          Else
              MsgBox "Can't save document in " + FilePath
          End If
        Case 2:
          If (GdViewer1.SaveDocumentToTIFF(SaveFileDialog1.FileName, TiffCompression_TiffCompressionAUTO) = GdPictureStatus_OK) Then
              MsgBox "Document succefully saved as TIFF in " + FilePath
          Else
              MsgBox "Can't save document in " + FilePath
          End If
        Case 3:
          If (GdViewer1.SaveDocumentToJPEG(SaveFileDialog1.FileName, 75) = GdPictureStatus_OK) Then
              MsgBox "Document succefully saved as JPEG in " + FilePath
          Else
              MsgBox "Can't save document in " + FilePath
          End If
      End Select
    End If
    On Error GoTo 0
End Sub

Private Sub ShowPageTextToolStripMenuItem_Click()
    Dim SelectedAnnotIdx As Long
    SelectedAnnotIdx = GdViewer1.GetSelectedAnnotationIdx
    If SelectedAnnotIdx <> -1 Then
        GdViewer1.DeleteAnnotation SelectedAnnotIdx
    End If
End Sub

Private Sub Small64X64ToolStripMenuItem_Click()
    ThumbnailEx1.SetItemsSize 64, 64
    Small64X64ToolStripMenuItem.Checked = True
    Medium128X128ToolStripMenuItem.Checked = False
    Large256256ToolStripMenuItem.Checked = False
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
  Select Case Button.Key
  Case "tsHighlightedRectangle"
      GdViewer1.AddRectangleHighlighterAnnotInteractive GdPictureColor(vbYellow)
  Case "tsFreeHandHighlighter"
      GdViewer1.AddFreeHandHighlighterAnnotInteractive GdPictureColor(m_StrokingColor), m_LineWidth
  Case "tsRectangle"
    GdViewer1.AddRectangleAnnotInteractive False, True, GdPictureColor(m_FillingColor), GdPictureColor(m_StrokingColor), m_LineWidth, 1
  Case "tsFilledRectangle"
    GdViewer1.AddRectangleAnnotInteractive True, True, GdPictureColor(m_FillingColor), GdPictureColor(m_StrokingColor), 0.01, 1
  Case "tsEllipse"
    GdViewer1.AddEllipseAnnotInteractive False, True, GdPictureColor(m_FillingColor), GdPictureColor(m_StrokingColor), m_LineWidth, 1
  Case "tsFilledEllipse"
    GdViewer1.AddEllipseAnnotInteractive True, True, GdPictureColor(m_FillingColor), GdPictureColor(m_StrokingColor), m_LineWidth, 1
  Case "tsEmbeddedImage"
    GdViewer1.AddEmbeddedImageAnnotInteractive_2 "", False, GdPictureColor(vbWhite), 0.02, 1
    If (GdViewer1.GetStat() <> GdPictureStatus_OK) Then
        MsgBox "Can't load bitmap"
    End If
  Case "tsRubberStamp"
    GdViewer1.AddRubberStampAnnotInteractive txtText.Text, GdPictureColor(RGB(65, 106, 28)), "Arial", FontStyle_FontStyleBold, GdPictureColor(RGB(65, 106, 28)), 0.2, 0.8, 20
  Case "tsLine"
    GdViewer1.AddLineAnnotInteractive GdPictureColor(m_StrokingColor), m_LineWidth, 1
  Case "tsConnectedLines"
    GdViewer1.AddConnectedLinesAnnotInteractive GdPictureColor(m_StrokingColor), m_LineWidth, 1
  Case "tsLineArraw"
    GdViewer1.AddLineArrowAnnotInteractive GdPictureColor(m_StrokingColor), m_LineWidth, 5, 7, True, 1
  Case "tsText"
    GdViewer1.AddTextAnnotationInteractive txtText.Text, GdPictureColor(vbBlack), "Arial", FontStyle_FontStyleBoldUnderline, 12, True, GdPictureColor(m_StrokingColor), GdPictureColor(m_FillingColor), 1, 0
  Case "tsStickyNote"
    GdViewer1.AddStickyNoteAnnotationInteractive txtText.Text, GdPictureColor(vbBlack), "Arial", FontStyle_FontStyleRegular, 20, 1, 0
  Case "tsFreeHand"
    GdViewer1.AddFreeHandAnnotInteractive GdPictureColor(m_StrokingColor), m_LineWidth, 1
  Case "tsLink"
    GdViewer1.AddLinkAnnotationInteractive "GdPicture Website", "http://www.gdpicture.com", GdPictureColor(vbBlue), GdPictureColor(vbRed), "Arial", FontStyle_FontStyleUnderline, FontStyle_FontStyleBoldUnderline, 1, 0
  Case "tsPolygon"
    GdViewer1.AddPolygonAnnotInteractive GdPictureColor(m_StrokingColor), m_LineWidth, GdPictureColor(m_FillingColor), 1
  Case "fsFreeHandPolygon"
    GdViewer1.AddFreeHandPolygonAnnotInteractive GdPictureColor(m_StrokingColor), m_LineWidth, GdPictureColor(m_FillingColor), 1
  Case "tsRuler"
    GdViewer1.AddRulerAnnotInteractive GdPictureColor(m_StrokingColor), m_LineWidth, 1, UnitMode_Inch
  Case Else
    MsgBox "Unknown Tool : " & Button.Key
    Debug.Print "  Case " & Button.Key & vbCrLf & "    '"
  End Select
End Sub

Private Sub Toolbar2_ButtonClick(ByVal Button As MSComctlLib.Button)
  Select Case Button.Key
  Case "tsFirst"
    GotoFirstPageToolStripMenuItem_Click
  Case "tsPrevious"
    GotoPreviousPageToolStripMenuItem_Click
  Case "tsNext"
    GotoNextPageToolStripMenuItem_Click
  Case "tsLast"
    GotoLastPageToolStripMenuItem_Click
  Case Else
    MsgBox "Unknown Tool : " & Button.Key
  End Select
End Sub

Private Sub ToolStripMenuItem10_Click()
    GdViewer1.PrintSetDocumentName "GdPicture Document Viewer Printing"
    GdViewer1.PrintSetAutoRotation True
    GdViewer1.PrintDialogFit
End Sub

Private Sub ToolStripMenuItem2_Click()
  GdViewer1.Zoom = 1
End Sub

Private Sub ToolStripMenuItem3_Click()
  GdViewer1.Zoom = 1.5
End Sub

Private Sub ToolStripMenuItem4_Click()
  GdViewer1.Zoom = 2
End Sub

Private Sub ToolStripMenuItem6_Click()
  GdViewer1.Zoom = 0.5
End Sub

Private Sub ToolStripMenuItem7_Click()
  frmAbout.Show vbModal
End Sub

Private Sub ToolStripMenuItem8_Click()
  GdViewer1.MouseMode = ViewerMouseMode_MouseModeAreaSelection
  PanToolStripMenuItem.Checked = False
  AutoZoomToolStripMenuItem.Checked = False
  ToolStripMenuItem8.Checked = True
  NothingToolStripMenuItem.Checked = False

End Sub

Private Sub ZoomChangingToolStripMenuItem_Click()
  GdViewer1.MouseWheelMode = ViewerMouseWheelMode_MouseWheelModeZoom
  ZoomChangingToolStripMenuItem.Checked = True
  PageScrollingToolStripMenuItem.Checked = False
  PageChangingToolStripMenuItem.Checked = False

End Sub

Private Sub ZoomINToolStripMenuItem_Click()
  If (GdViewer1.ZoomIN() <> GdPictureStatus_OK) Then
      MsgBox "Error: " + CStr(GdViewer1.GetStat())
  End If
End Sub

Private Sub ZoomOUTToolStripMenuItem_Click()
  If (GdViewer1.ZoomOUT() <> GdPictureStatus_OK) Then
      MsgBox "Error: " + CStr(GdViewer1.GetStat())
    End If
End Sub
