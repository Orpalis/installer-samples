VERSION 5.00
Begin VB.Form frmAbout 
   Caption         =   "About"
   ClientHeight    =   2415
   ClientLeft      =   11250
   ClientTop       =   5055
   ClientWidth     =   8400
   LinkTopic       =   "Form2"
   ScaleHeight     =   2415
   ScaleWidth      =   8400
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   1245
      Left            =   360
      Picture         =   "frmAbout.frx":0000
      ScaleHeight     =   1215
      ScaleWidth      =   3000
      TabIndex        =   0
      Top             =   360
      Width           =   3030
   End
   Begin VB.Label LinkLabel3 
      Caption         =   "http://www.gdpicture.com"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   255
      Left            =   2880
      TabIndex        =   5
      Top             =   1800
      Width           =   4215
   End
   Begin VB.Label Label3 
      Caption         =   "CBased on GdPicture Imaging SDK"
      Height          =   255
      Left            =   240
      TabIndex        =   4
      Top             =   1800
      Width           =   2535
   End
   Begin VB.Label LinkLabel2 
      Caption         =   "http://www.orpalis.com"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   255
      Left            =   3720
      TabIndex        =   3
      Top             =   1320
      Width           =   4215
   End
   Begin VB.Label Label2 
      Caption         =   "Copyright 2011 - ORPALIS"
      Height          =   255
      Left            =   3720
      TabIndex        =   2
      Top             =   960
      Width           =   4455
   End
   Begin VB.Label Label1 
      Caption         =   "GdPicture XMP Annotations Demo, for PDF, TIFF an JPEG."
      Height          =   255
      Left            =   3720
      TabIndex        =   1
      Top             =   360
      Width           =   4455
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function ShellExecute Lib "shell32.dll" _
                 Alias "ShellExecuteA" ( _
                 ByVal hwnd As Long, _
                 ByVal lpOperation As String, _
                 ByVal lpFile As String, _
                 ByVal lpParameters As String, _
                 ByVal lpDirectory As String, _
                 ByVal nShowCmd As Long) As Long

Private Sub LinkTo(lbl As Label)
  Dim iRet As Long
  iRet = ShellExecute(Me.hwnd, vbNullString, _
               lbl.Caption, vbNullString, _
               App.Path, vbNormalFocus)

End Sub
Private Sub LinkLabel2_Click()
  LinkTo LinkLabel2
End Sub

Private Sub LinkLabel3_Click()
  LinkTo LinkLabel3
End Sub
