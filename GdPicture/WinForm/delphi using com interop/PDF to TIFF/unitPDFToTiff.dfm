object frmPDFtoTIFF: TfrmPDFtoTIFF
  Left = 197
  Top = 111
  Caption = 'Create TIFF from PDF'
  ClientHeight = 544
  ClientWidth = 982
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -13
  Font.Name = 'System'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  OnResize = FormResize
  PixelsPerInch = 96
  TextHeight = 16
  object Label1: TLabel
    Left = 24
    Top = 16
    Width = 119
    Height = 16
    Caption = 'PDF file to convert'
  end
  object txtFileName: TEdit
    Left = 149
    Top = 13
    Width = 609
    Height = 24
    TabOrder = 0
  end
  object cmdFind: TButton
    Left = 764
    Top = 13
    Width = 57
    Height = 25
    Caption = '...'
    TabOrder = 1
    OnClick = cmdFindClick
  end
  object cmdConvert: TButton
    Left = 827
    Top = 8
    Width = 134
    Height = 33
    Caption = 'Convert to TIFF'
    TabOrder = 2
    OnClick = cmdConvertClick
  end
  object OpenDialog: TOpenDialog
    DefaultExt = 'pdf'
    Filter = 'Pdf files (*.pdf)|*.*|All|*.*'
    Left = 16
    Top = 56
  end
end
