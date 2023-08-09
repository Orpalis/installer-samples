program PDFtoTIFF;

uses
  Forms,
  unitPDFToTiff in 'unitPDFToTiff.pas' {frmPDFtoTIFF},
  GdPicture_NET_14_TLB in 'GdPicture_NET_14_TLB.pas';

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TfrmPDFtoTIFF, frmPDFtoTIFF);
  Application.Run;
end.
 
