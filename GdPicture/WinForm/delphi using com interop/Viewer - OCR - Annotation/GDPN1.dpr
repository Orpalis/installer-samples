program GDPN1;

uses
  Forms,
  GDP in 'GDP.pas' {Form1},
  GdPicture_NET_14_TLB in 'GdPicture_NET_14_TLB.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
