object Form1: TForm1
  Left = 448
  Top = 184
  Caption = 'Form1'
  ClientHeight = 712
  ClientWidth = 913
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  OnResize = FormResize
  PixelsPerInch = 96
  TextHeight = 13
  object Label3: TLabel
    Left = 426
    Top = 51
    Width = 51
    Height = 13
    Caption = 'Language:'
    OnClick = Label1Click
  end
  object Panel1: TPanel
    Left = 0
    Top = 0
    Width = 913
    Height = 97
    Align = alTop
    TabOrder = 0
    object Label1: TLabel
      Left = 575
      Top = 13
      Width = 47
      Height = 13
      Caption = 'Zoom: 0%'
      OnClick = Label1Click
    end
    object Label2: TLabel
      Left = 9
      Top = 51
      Width = 70
      Height = 13
      Caption = 'OCR dict path:'
      OnClick = Label1Click
    end
    object Label4: TLabel
      Left = 483
      Top = 74
      Width = 240
      Height = 13
      Caption = '"spa" for spain, "eng" for english, "fra" for french...'
      OnClick = Label1Click
    end
    object lbMousePos: TLabel
      Left = 9
      Top = 71
      Width = 26
      Height = 13
      Caption = '(X, Y)'
      OnClick = Label1Click
    end
    object Button3: TButton
      Left = 96
      Top = 8
      Width = 75
      Height = 25
      Caption = '<'
      TabOrder = 0
      OnClick = Button3Click
    end
    object Button4: TButton
      Left = 184
      Top = 8
      Width = 75
      Height = 25
      Caption = '>'
      TabOrder = 1
      OnClick = Button4Click
    end
    object Button5: TButton
      Left = 272
      Top = 8
      Width = 75
      Height = 25
      Caption = '>>'
      TabOrder = 2
      OnClick = Button5Click
    end
    object Button6: TButton
      Left = 8
      Top = 8
      Width = 75
      Height = 25
      Caption = '<<'
      TabOrder = 3
      OnClick = Button6Click
    end
    object Edit1: TEdit
      Left = 368
      Top = 8
      Width = 129
      Height = 21
      TabOrder = 4
    end
    object Button8: TButton
      Left = 503
      Top = 6
      Width = 65
      Height = 25
      Caption = 'Search'
      TabOrder = 5
      OnClick = Button8Click
    end
    object Edit2: TEdit
      Left = 91
      Top = 47
      Width = 329
      Height = 21
      TabOrder = 6
    end
  end
  object Edit3: TEdit
    Left = 483
    Top = 47
    Width = 329
    Height = 21
    TabOrder = 1
    Text = 'eng'
  end
  object ProgressBar1: TProgressBar
    Left = 0
    Top = 686
    Width = 237
    Height = 25
    TabOrder = 2
  end
  object MainMenu1: TMainMenu
    Left = 24
    Top = 624
    object File1: TMenuItem
      Caption = 'File'
      object Open1: TMenuItem
        Caption = 'Open'
        OnClick = Open1Click
      end
      object Print1: TMenuItem
        Caption = 'Print...'
        OnClick = Print1Click
      end
      object SaveasPDF1: TMenuItem
        Caption = 'Save as PDF...'
        OnClick = SaveasPDF1Click
      end
      object Exit1: TMenuItem
        Caption = 'Exit'
        OnClick = Exit1Click
      end
    end
    object Annotations1: TMenuItem
      Caption = 'Annotations'
      object Addstamp1: TMenuItem
        Caption = 'Add stamp'
        OnClick = Addstamp1Click
      end
      object AddNote1: TMenuItem
        Caption = 'Add Note'
        OnClick = AddNote1Click
      end
      object AddHighlighter1: TMenuItem
        Caption = 'Add Highlighter'
        OnClick = AddHighlighter1Click
      end
      object AddFreehandHighlighter1: TMenuItem
        Caption = 'Add Freehand Highlighter'
        OnClick = AddFreehandHighlighter1Click
      end
      object AddRectangle1: TMenuItem
        Caption = 'Add Rectangle'
        OnClick = AddRectangle1Click
      end
      object AddEllipse1: TMenuItem
        Caption = 'Add Ellipse'
        OnClick = AddEllipse1Click
      end
      object AddEmbeddedImage1: TMenuItem
        Caption = 'Add Embedded Image'
        OnClick = AddEmbeddedImage1Click
      end
      object AddLine1: TMenuItem
        Caption = 'Add Line'
        OnClick = AddLine1Click
      end
      object AddConnectedLines1: TMenuItem
        Caption = 'Add Connected Lines'
        OnClick = AddConnectedLines1Click
      end
      object AddLineArrow1: TMenuItem
        Caption = 'Add Line Arrow'
        OnClick = AddLineArrow1Click
      end
      object AddText1: TMenuItem
        Caption = 'Add Text'
        OnClick = AddText1Click
      end
      object AddFreehand1: TMenuItem
        Caption = 'Add Free hand'
        OnClick = AddFreehand1Click
      end
      object AddPolygon1: TMenuItem
        Caption = 'Add Polygon'
        OnClick = AddPolygon1Click
      end
      object N1: TMenuItem
        Caption = '-'
      end
      object Burnannotationstopage1: TMenuItem
        Caption = 'Burn annotations to page'
        OnClick = Burnannotationstopage1Click
      end
    end
    object OCR1: TMenuItem
      Caption = 'OCR'
      object PDF2PDFOCR1: TMenuItem
        Caption = 'PDF->PDF/OCR'
        OnClick = PDF2PDFOCR1Click
      end
      object IFFPDFOCR1: TMenuItem
        Caption = 'TIFF->PDF/OCR'
        OnClick = IFFPDFOCR1Click
      end
      object PDFText1: TMenuItem
        Caption = 'PDF->Text'
        OnClick = PDFText1Click
      end
      object IFFText1: TMenuItem
        Caption = 'TIFF->Text'
        OnClick = IFFText1Click
      end
    end
  end
  object OpenDialog1: TOpenDialog
    Left = 88
    Top = 624
  end
  object SaveDialog1: TSaveDialog
    Left = 160
    Top = 624
  end
end
