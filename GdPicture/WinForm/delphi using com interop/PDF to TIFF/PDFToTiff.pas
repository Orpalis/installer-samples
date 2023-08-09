unit PDFToTiff;

interface

uses Windows, Classes, Graphics, Forms, Controls, Menus,
  Dialogs, StdCtrls, Buttons, ExtCtrls, ComCtrls, ImgList, StdActns,
  ActnList, ToolWin;

type
  TfrmPDFtoTIFF = class(TForm)
    OpenDialog: TOpenDialog;
    procedure FileOpen1Execute(Sender: TObject);
  private
    { Déclarations privées }
  public
    { Déclarations publiques }
  end;

var
  frmPDFtoTIFF: TfrmPDFtoTIFF;

implementation

uses about;

{$R *.dfm}


procedure TfrmPDFtoTIFF.FileOpen1Execute(Sender: TObject);
begin
  OpenDialog.Execute;
end;


end.
