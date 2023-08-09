unit unitPDFToTiff;

interface

uses
  Windows, Messages, SysUtils, Classes, Controls, Forms, Math,
  Dialogs, GdPicture_NET_14_TLB, StdCtrls, ExtCtrls, ExtDlgs, ComObj, Menus,
  ComCtrls;

type
  TfrmPDFtoTIFF = class(TForm)
    OpenDialog: TOpenDialog;
    Label1: TLabel;
    txtFileName: TEdit;
    cmdFind: TButton;
    cmdConvert: TButton;
    procedure FileOpen1Execute(Sender: TObject);
    procedure cmdFindClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure FormResize(Sender: TObject);
    procedure cmdConvertClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
    GdViewer1: TGDViewer;
  end;

var
  frmPDFtoTIFF: TfrmPDFtoTIFF;

implementation

// uses about;
{$R *.dfm}

procedure TfrmPDFtoTIFF.FormCreate(Sender: TObject);
var
  LicenseManager1: Variant;

begin
  GdViewer1 := TGDViewer.Create(Self);
  Self.InsertControl(GdViewer1);
  LicenseManager1 := CreateOleObject('GdPicture14.LicenseManager');
  LicenseManager1.RegisterKey('XXX'); // Please, replace XXX by a valid demo or commercial KEY

  GdViewer1.SetBackgroundColor(GdViewer1.ARGBI(255, 50, 100, 120));
  // changing the Background color.

  {
    When calling a C# class exposed via COM Interop, you may receive an "arithmetic overflow" error.

    This is caused by the floating point unit in the CPU; Delphi expects the FPU
    to be in a certain state, and the C# code modifies this, causing an  exception.
    //source: http://groups.google.com/group/microsoft.public.dotnet.framework.interop/browse_thread/thread/300e8f286fcbbddf/ce13a27a1df6ae12?q=c%23+com+initializecomponent+overflow&_done=/groups?q%3Dc%23+com+initializecomponent+overflow%26&_doneTitle=Back+to+Search&&d&pli=1
    }
  // Disable FPU exceptions on 32-bit and 64-bit architectures.
  SetExceptionMask(exAllArithmeticExceptions);

end;

procedure TfrmPDFtoTIFF.FormResize(Sender: TObject);
begin
  GdViewer1.LockViewer := true;
  GdViewer1.Left := 1;
  GdViewer1.Top := 50;
  GdViewer1.Width := Self.Width - 10;
  GdViewer1.Height := Self.Height - 100;
  GdViewer1.LockViewer := false;
  GdViewer1.Redraw;

end;

procedure TfrmPDFtoTIFF.cmdConvertClick(Sender: TObject);
var
  GdPictureImaging1: GdPictureImaging;
  GdPicturePDF1: GdPicturePDF;
  Status: Integer;
  I: Integer;
  ImagePageId: Integer;
  TiffImageID: Integer;
begin
  GdPictureImaging1 := CreateComObject(CLASS_GdPictureImaging)
    as GdPictureImaging;
  GdPicturePDF1 := CreateComObject(CLASS_GdPicturePDF) as GdPicturePDF;
  Status := GdPicturePDF1.LoadFromFile(txtFileName.Text, false);
  if Status <> 0 then
  begin
    MessageBox(0, Pchar('Error loading file. Status: ' + inttostr(Status)), '',
      0);
  end
  else
  begin
    for I := 1 to GdPicturePDF1.GetPageCount do
    begin
      Status := GdPicturePDF1.SelectPage(I);
      if Status = 0 then
      begin
        ImagePageId := GdPicturePDF1.RenderPageToGdPictureImage(200, true);
        Status := GdPicturePDF1.GetStat();
        if Status = 0 then
        begin

          if I = 1 then
          begin
            TiffImageID := ImagePageId;
            Status := GdPictureImaging1.TiffSaveAsMultiPageFile
              (ImagePageId, 'test.tif', TiffCompression_TiffCompressionAUTO);
          end
          else
          begin
            Status := GdPictureImaging1.TiffAddToMultiPageFile_2
              (TiffImageID, ImagePageId, TiffCompression_TiffCompressionAUTO);
              GdPictureImaging1.ReleaseGdPictureImage(ImagePageId);
          end;
        end;
      end;
      if status <> 0 then break;

    end;
    GdPictureImaging1.TiffCloseMultiPageFile(TiffImageID);
    GdPictureImaging1.ReleaseGdPictureImage(TiffImageID);

    if Status <> 0 then
      MessageBox(0, Pchar('Error saving file. Status: ' + inttostr(Status)),
        '', 0)
    else
      MessageBox(0, Pchar('Done, file saved. (' + GetCurrentDir + '\test.tif)')
          , '', 0);
  end;
end;

procedure TfrmPDFtoTIFF.cmdFindClick(Sender: TObject);
begin
  if OpenDialog.Execute then
  begin
    txtFileName.Text := OpenDialog.FileName;
    GdViewer1.CloseDocument();
    GdViewer1.DisplayFromFile(txtFileName.Text);
  end;

end;

procedure TfrmPDFtoTIFF.FileOpen1Execute(Sender: TObject);
begin
  OpenDialog.Execute;
end;

end.
