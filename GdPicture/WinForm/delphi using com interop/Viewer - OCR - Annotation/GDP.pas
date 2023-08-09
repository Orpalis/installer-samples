unit GDP;

interface

uses
  Windows, Messages, SysUtils, Classes, Controls, Forms, Math,
  Dialogs, GdPicture_NET_14_TLB, StdCtrls, ExtCtrls, ExtDlgs, ComObj, Menus,
  ComCtrls;

type
  TForm1 = class(TForm)
    Panel1: TPanel;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    Button6: TButton;
    Edit1: TEdit;
    Button8: TButton;
    MainMenu1: TMainMenu;
    File1: TMenuItem;
    Open1: TMenuItem;
    Print1: TMenuItem;
    Label1: TLabel;
    Annotations1: TMenuItem;
    Addstamp1: TMenuItem;
    AddNote1: TMenuItem;
    AddHighlighter1: TMenuItem;
    N1: TMenuItem;
    Burnannotationstopage1: TMenuItem;
    Exit1: TMenuItem;
    SaveasPDF1: TMenuItem;
    Label2: TLabel;
    Edit2: TEdit;
    Label3: TLabel;
    Edit3: TEdit;
    Label4: TLabel;
    OCR1: TMenuItem;
    PDF2PDFOCR1: TMenuItem;
    OpenDialog1: TOpenDialog;
    ProgressBar1: TProgressBar;
    IFFPDFOCR1: TMenuItem;
    PDFText1: TMenuItem;
    IFFText1: TMenuItem;
    lbMousePos: TLabel;
    AddFreehandHighlighter1: TMenuItem;
    AddRectangle1: TMenuItem;
    AddEllipse1: TMenuItem;
    AddEmbeddedImage1: TMenuItem;
    AddLine1: TMenuItem;
    AddConnectedLines1: TMenuItem;
    AddLineArrow1: TMenuItem;
    AddText1: TMenuItem;
    AddFreehand1: TMenuItem;
    AddPolygon1: TMenuItem;
    SaveDialog1: TSaveDialog;
    procedure FormCreate(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button6Click(Sender: TObject);
    procedure Button8Click(Sender: TObject);
    procedure FormResize(Sender: TObject);
    procedure Open1Click(Sender: TObject);
    procedure Print1Click(Sender: TObject);
    procedure Label1Click(Sender: TObject);
    procedure Addstamp1Click(Sender: TObject);
    procedure AddNote1Click(Sender: TObject);
    procedure AddHighlighter1Click(Sender: TObject);
    procedure Burnannotationstopage1Click(Sender: TObject);
    procedure Exit1Click(Sender: TObject);
    procedure SaveasPDF1Click(Sender: TObject);
    procedure PDF2PDFOCR1Click(Sender: TObject);
    procedure IFFPDFOCR1Click(Sender: TObject);
    procedure PDFText1Click(Sender: TObject);
    procedure IFFText1Click(Sender: TObject);
    procedure OnViewerMouseMove(ASender: TObject; MouseX: Integer; MouseY: Integer);
    procedure AddFreehandHighlighter1Click(Sender: TObject);
    procedure AddRectangle1Click(Sender: TObject);
    procedure AddEllipse1Click(Sender: TObject);
    procedure AddEmbeddedImage1Click(Sender: TObject);
    procedure AddLine1Click(Sender: TObject);
    procedure AddConnectedLines1Click(Sender: TObject);
    procedure AddLineArrow1Click(Sender: TObject);
    procedure AddText1Click(Sender: TObject);
    procedure AddFreehand1Click(Sender: TObject);
    procedure AddPolygon1Click(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
  private
    { Private declarations }
  public
    GdViewer1: TGDViewer;
    ThumbnailEx1: TThumbnailEx;
    AnnotationEditor1: TAnnotationEditor;
  end;

var
  Form1: TForm1;
  Saved8087CW: Word;

implementation

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
var
  LicenseManager1: LicenseManager;
begin
  //Store original state of FPU
  Saved8087CW := System.Get8087CW;
  GdViewer1 := TGDViewer.Create(Self);
  ThumbnailEx1 := TThumbnailEx.Create(Self);
  ThumbnailEx1.SetItemsSize(256, 256);
  AnnotationEditor1 := TAnnotationEditor.Create(Self);
  Self.InsertControl(GdViewer1);
  Self.InsertControl(ThumbnailEx1);
  Self.InsertControl(AnnotationEditor1);
  GdViewer1.OnAfterZoomChange := Label1Click;
  GdViewer1.OnViewerMouseMove := OnViewerMouseMove;
  LicenseManager1 := CreateComObject(CLASS_LicenseManager)  as LicenseManager;
  LicenseManager1.RegisterKey('XXX'); // Please, replace XXX by a valid demo or commercial KEY
  // changing the Background color.
  GdViewer1.SetBackgroundColor(GdViewer1.ARGBI(255, 50, 100, 120));
  Edit2.Text := LicenseManager1.GetRedistPath() +  '\OCR';
  {
    When calling a C# class exposed via COM Interop, you may receive an "arithmetic overflow" error.

    This is caused by the floating point unit in the CPU; Delphi expects the FPU
    to be in a certain state, and the C# code modifies this, causing an  exception.
    //source: http://groups.google.com/group/microsoft.public.dotnet.framework.interop/browse_thread/thread/300e8f286fcbbddf/ce13a27a1df6ae12?q=c%23+com+initializecomponent+overflow&_done=/groups?q%3Dc%23+com+initializecomponent+overflow%26&_doneTitle=Back+to+Search&&d&pli=1
    }
  // Disable FPU exceptions on 32-bit and 64-bit architectures.
  SetExceptionMask(exAllArithmeticExceptions);
end;

procedure TForm1.FormDestroy(Sender: TObject);
begin
  System.Set8087CW(Saved8087CW); // Default value (with exceptions) is $1372
end;

procedure TForm1.FormResize(Sender: TObject);
begin
  GdViewer1.LockViewer := true;
  GdViewer1.Left := Round(Self.Width * 1 / 3);
  GdViewer1.Top := Panel1.Height + 1;
  GdViewer1.Width := Round(Self.Width * 2 / 3) - 20;
  GdViewer1.Height := Self.Height - Panel1.Height - 60;
  GdViewer1.LockViewer := false;
  GdViewer1.Redraw;
  ThumbnailEx1.Left := 0;
  ThumbnailEx1.Top := Panel1.Height;
  ThumbnailEx1.Height := Round(Self.Height * 2 / 3) - Panel1.Height - 40;
  ThumbnailEx1.Width := Round(Self.Width * 1 / 3);

  AnnotationEditor1.Left := 0;
  AnnotationEditor1.Top := ThumbnailEx1.Top + ThumbnailEx1.Height;
  AnnotationEditor1.Height := Self.Height - AnnotationEditor1.Top - 85;
  AnnotationEditor1.Width := Round(Self.Width * 1 / 3);
  ProgressBar1.Left := 0;
  ProgressBar1.Top := AnnotationEditor1.Top + AnnotationEditor1.Height;
  ProgressBar1.Width := Round(Self.Width * 1 / 3);
end;

procedure TForm1.IFFPDFOCR1Click(Sender: TObject);
var
  FilePath: String;
  GdPictureImaging1: GdPictureImaging;
  GdPicturePDF1: GdPicturePDF;
  X: Integer;
  ImageID: Integer;
  Status: Integer;
  DestPDF: String;
  Lang: String;
  DictPath: String;

begin

  DestPDF := 'pdfocr.pdf';
  Lang := Edit3.Text;
  DictPath := Edit2.Text;

  OpenDialog1.Filter := 'TIFF Document (*.tif)|*.TIF';
  OpenDialog1.Execute(Self.Handle);

  FilePath := OpenDialog1.FileName;
  if FilePath <> '' then
  begin
    GdPictureImaging1 := CreateComObject(CLASS_GdPictureImaging)
      as GdPictureImaging;
    GdPicturePDF1 := CreateComObject(CLASS_GdPicturePDF) as GdPicturePDF;
    ImageID := GdPictureImaging1.CreateGdPictureImageFromFile(FilePath);
    if GdPictureImaging1.GetStat() = 0 then
    begin
      GdPicturePDF1.NewPDF();

      if GdPicturePDF1.NewPDF() = GdPictureStatus_OK then
      begin
        ProgressBar1.Position := 0;
        ProgressBar1.Max := GdPictureImaging1.GetPageCount(ImageID);
        // Now we render all PDF pages to bitmap and we add them to the output PDF OCR
        for X := 1 to GdPictureImaging1.GetPageCount(ImageID) do
        begin
          GdPictureImaging1.TiffSelectPage(ImageID, X);
          GdPicturePDF1.AddImageFromGdPictureImage(ImageID, false, true);
          // Lang, DictPath, '');
          Status := GdPictureImaging1.GetStat();
          if Status <> 0 then
          begin
            MessageBox(0, Pchar('Error adding page ' + inttostr(X)
                  + '. Status: ' + inttostr(Status)), '', 0);
          end
          else
          begin
            Status := GdPicturePDF1.OcrPage(Lang, DictPath, '', 300);
            if Status <> 0 then
            begin
              MessageBox(0, Pchar('Error ocring page ' + inttostr(X)
                    + '. Status: ' + inttostr(Status)), '', 0);
            end;
          end;

          ProgressBar1.Position := X;
        end;
        Status := GdPicturePDF1.SaveToFile(DestPDF);
        if Status <> 0 then
        begin
          MessageBox
            (0, Pchar('Error saving output document. Status: ' + inttostr
                (Status)), '', 0);
        end
        else
          MessageBox(0, Pchar('OK. Document created at ' + DestPDF), '', 0);

        GdPicturePDF1.Dispose();
      end
      else
        MessageBox(0, Pchar('Can not create the file ' + DestPDF), '', 0);
      GdPictureImaging1.ReleaseGdPictureImage(ImageID);
    end
    else
      MessageBox(0, 'Can not open the file', '', 0);
    ProgressBar1.Position := 0;

  end;

end;

procedure TForm1.IFFText1Click(Sender: TObject);
var
  FilePath: String;
  GdPictureImaging1: GdPictureImaging;
  GdPictureOCR1: GdPictureOCR;
  X: Integer;
  ocrResultID: string;
  ImageID: Integer;
  Status: Integer;
  Lang: String;
  DictPath: String;
  Text: String;

begin

  Lang := Edit3.Text;
  DictPath := Edit2.Text;

  OpenDialog1.Filter := 'TIFF Document (*.tif)|*.TIF';
  OpenDialog1.Execute(Self.Handle);

  FilePath := OpenDialog1.FileName;
  if FilePath <> '' then
  begin
    GdPictureImaging1 := CreateComObject(CLASS_GdPictureImaging)
      as GdPictureImaging;
    GdPictureOCR1 := CreateComObject(CLASS_GdPictureOCR) as GdPictureOCR;
    ImageID := GdPictureImaging1.CreateGdPictureImageFromFile(FilePath);
    if GdPictureImaging1.GetStat() = 0 then
    begin
      GdPictureOCR1.AddCustomDictionary(Lang);
      GdPictureOCR1.ResourceFolder := DictPath;
      ProgressBar1.Position := 0;
      ProgressBar1.Max := GdPictureImaging1.GetPageCount(ImageID);
      // Now we render all PDF pages to bitmap and we add them to the output PDF OCR
      for X := 1 to GdPictureImaging1.GetPageCount(ImageID) do
      begin
        GdPictureImaging1.TiffSelectPage(ImageID, X);
        GdPictureOCR1.SetImage(ImageID);
        ocrResultID := GdPictureOCR1.RunOCR();
        Status := GdPictureOCR1.GetStat();
        if Status <> 0 then
        begin
          MessageBox(0, Pchar('Error Ocring page ' + inttostr(X)
                + '. Status: ' + inttostr(Status)), '', 0);
        end
        else
        begin
          // here is a good entry point to extract characters bounding boxes
          Text := GdPictureOCR1.GetOCRResultText(ocrResultID);
          MessageBox(0, Pchar(Text), '', 0);
        end;

        ProgressBar1.Position := X;
      end;
      GdPictureImaging1.ReleaseGdPictureImage(ImageID);
    end
    else
      MessageBox(0, 'Can not open the file', '', 0);
    ProgressBar1.Position := 0;
  end;

end;

procedure TForm1.Label1Click(Sender: TObject);
begin
  Label1.Caption := 'Zoom: ' + FloatToStrF
    (GdViewer1.Zoom * 100, ffNumber, 3, 3) + '%';
end;

procedure TForm1.OnViewerMouseMove(ASender: TObject; MouseX: Integer; MouseY: Integer);
begin
  lbMousePos.Caption := '(' + inttostr(GdViewer1.GetMouseLeftInDocument())
    + ',' + inttostr(GdViewer1.GetMouseTopInDocument()) + ')';
end;

procedure TForm1.Open1Click(Sender: TObject);
begin
  GdViewer1.CloseDocument();
  ThumbnailEx1.ClearAllItems();
  GdViewer1.ZoomMode := 2;
  GdViewer1.DisplayFromFile('');
  ThumbnailEx1.LoadFromGdViewer(GdViewer1.ControlInterface);
  AnnotationEditor1.LoadFromGdViewer(GdViewer1.ControlInterface);
end;

procedure TForm1.PDF2PDFOCR1Click(Sender: TObject);
var
  FilePath: String;
  GdPicturePDF1: GdPicturePDF;

  X: Integer;
  Status: Integer;
  DestPDF: String;
  Lang: String;
  DictPath: String;

begin

  DestPDF := 'pdfocr.pdf';
  Lang := Edit3.Text;
  DictPath := Edit2.Text;

  OpenDialog1.Filter := 'PDF Document (*.pdf)|*.PDF';
  OpenDialog1.Execute(Self.Handle);

  FilePath := OpenDialog1.FileName;
  if FilePath <> '' then
  begin
    GdPicturePDF1 := CreateComObject(CLASS_GdPicturePDF) as GdPicturePDF;

    if GdPicturePDF1.LoadFromFile(FilePath, false) = 0 then
    begin
      ProgressBar1.Position := 0;
      ProgressBar1.Max := GdPicturePDF1.GetPageCount();
      // Now we render all PDF pages to bitmap and we add them to the output PDF OCR
      for X := 1 to GdPicturePDF1.GetPageCount() do
      begin
        GdPicturePDF1.SelectPage(X);
        GdPicturePDF1.OcrPage(Lang, DictPath, '', 300);

        ProgressBar1.Position := X;
      end;
      Status := GdPicturePDF1.SaveToFile(DestPDF);
      if Status <> 0 then
      begin
        MessageBox(0, Pchar('Error saving output document. Status: ' + inttostr
              (Status)), '', 0);
      end
      else
        MessageBox(0, Pchar('OK. Document created at ' + DestPDF), '', 0);
    end
    else
      MessageBox(0, Pchar('Can not create the file ' + DestPDF), '', 0);

    ProgressBar1.Position := 0;
  end;

end;

procedure TForm1.PDFText1Click(Sender: TObject);
var
  FilePath: String;
  GdPicturePDF1: GdPicturePDF;
  GdPictureImaging1: GdPictureImaging;
  GdPictureOCR1: GdPictureOCR;
  X: Integer;
  ocrResultID: string;
  ImageID: Integer;
  Status: Integer;
  Lang: String;
  DictPath: String;
  Text: String;

begin

  Lang := Edit3.Text;
  DictPath := Edit2.Text;

  OpenDialog1.Filter := 'PDF Document (*.pdf)|*.PDF';
  OpenDialog1.Execute(Self.Handle);

  FilePath := OpenDialog1.FileName;
  if FilePath <> '' then
  begin
    GdPicturePDF1 := CreateComObject(CLASS_GdPicturePDF) as GdPicturePDF;
    GdPictureOCR1 := CreateComObject(CLASS_GdPictureOCR) as GdPictureOCR;
    GdPictureImaging1 := CreateComObject(CLASS_GdPictureImaging)
      as GdPictureImaging;

    if GdPicturePDF1.LoadFromFile(FilePath, false) = 0 then
    begin
      ProgressBar1.Position := 0;
      ProgressBar1.Max := GdPicturePDF1.GetPageCount();
      GdPictureOCR1.AddCustomDictionary(Lang);
      GdPictureOCR1.ResourceFolder := DictPath;
      // Now we render all PDF pages to bitmap and we add them to the output PDF OCR
      for X := 1 to GdPicturePDF1.GetPageCount() do
      begin
        GdPicturePDF1.SelectPage(X);
        ImageID := GdPicturePDF1.RenderPageToGdPictureImageEx(200,
          { set False to don't render form fields and annots } true);
        if ImageID <> 0 then
        begin
          GdPictureOCR1.SetImage(ImageID);
          ocrResultID := GdPictureOCR1.RunOCR();
          Status := GdPictureOCR1.GetStat();
          if Status <> 0 then
          begin
            MessageBox(0, Pchar('Error Ocring page ' + inttostr(X)
                  + '. Status: ' + inttostr(Status)), '', 0);
          end
          else
          begin
            // here is a good entry point to extract characters bounding boxes
          Text := GdPictureOCR1.GetOCRResultText(ocrResultID);
            MessageBox(0, Pchar(Text), '', 0);
          end;
          GdPictureImaging1.ReleaseGdPictureImage(ImageID);
        end
        else
          MessageBox(0, Pchar('Error rendering page ' + inttostr(X)
                + '. Status: ' + inttostr(GdPicturePDF1.GetStat())), '', 0);
        ProgressBar1.Position := X;
      end;
    end
    else
      MessageBox(0, 'Can not open the file', '', 0);
    ProgressBar1.Position := 0;
  end;

end;

procedure TForm1.Print1Click(Sender: TObject);
begin
  GdViewer1.PrintDialog();
end;

procedure TForm1.SaveasPDF1Click(Sender: TObject);
begin
  SaveDialog1.Filter := 'PDF Document (*.pdf)|*.pdf';
  if (SaveDialog1.Execute()) then begin;
    if GdViewer1.SaveDocumentToPDF(SaveDialog1.FileName) = 0 then
      MessageBox(0, 'Document saved!', '', 0)
    else
      MessageBox(0, 'Error saving document.', '', 0);
  end;
end;

procedure TForm1.Button4Click(Sender: TObject);
begin
  GdViewer1.DisplayNextPage();
end;

procedure TForm1.Button5Click(Sender: TObject);
begin
  GdViewer1.DisplayLastPage();
end;

procedure TForm1.AddConnectedLines1Click(Sender: TObject);
begin
  GdViewer1.AddConnectedLinesAnnotInteractive
    (GdViewer1.ARGBI(255, 0, 0, 0), 0.1, 1);
end;

procedure TForm1.AddEllipse1Click(Sender: TObject);
begin
  GdViewer1.AddEllipseAnnotInteractive
    (false, true, GdViewer1.ARGBI(255, 0, 0, 0), GdViewer1.ARGBI(255, 0, 0, 0),
    0.2, 1);
end;

procedure TForm1.AddEmbeddedImage1Click(Sender: TObject);
begin
  GdViewer1.AddEmbeddedImageAnnotInteractive_2
    ('', false, GdViewer1.ARGBI(255, 0, 0, 0), 0.2, 1);
end;

procedure TForm1.AddFreehand1Click(Sender: TObject);
begin
  GdViewer1.AddFreeHandAnnotInteractive(GdViewer1.ARGBI(255, 0, 0, 0), 0.1, 1);
end;

procedure TForm1.AddFreehandHighlighter1Click(Sender: TObject);
begin
  GdViewer1.AddFreeHandHighlighterAnnotInteractive
    (GdViewer1.ARGBI(255, 255, 255, 0), 0.2);
end;

procedure TForm1.AddHighlighter1Click(Sender: TObject);
begin
  GdViewer1.AddRectangleHighlighterAnnotInteractive
    (GdViewer1.ARGBI(255, 255, 255, 0));
end;

procedure TForm1.AddLine1Click(Sender: TObject);
begin
  GdViewer1.AddLineAnnotInteractive(GdViewer1.ARGBI(255, 0, 0, 0), 0.1, 1);
end;

procedure TForm1.AddLineArrow1Click(Sender: TObject);
begin
  GdViewer1.AddLineArrowAnnotInteractive(GdViewer1.ARGBI(255, 0, 0, 0), 0.1, 6,
    10, true, 1);
end;

procedure TForm1.AddNote1Click(Sender: TObject);
begin
  GdViewer1.AddStickyNoteAnnotationInteractive('Double click to change text',
    GdViewer1.ARGBI(255, 0, 0, 0), 'Arial', 0, 12, 0.9, 10);
end;

procedure TForm1.AddPolygon1Click(Sender: TObject);
begin
  GdViewer1.AddPolygonAnnotInteractive(GdViewer1.ARGBI(255, 0, 0, 0), 0.01,
    GdViewer1.ARGBI(255, 255, 0, 0), 1);
end;

procedure TForm1.AddRectangle1Click(Sender: TObject);
begin
  GdViewer1.AddRectangleAnnotInteractive
    (false, true, GdViewer1.ARGBI(255, 0, 0, 0), GdViewer1.ARGBI(255, 0, 0, 0),
    0.2, 1);
end;

procedure TForm1.Addstamp1Click(Sender: TObject);
begin
  GdViewer1.AddRubberStampAnnotInteractive
    ('STAMP', GdViewer1.ARGBI(255, 65, 106, 28), 'Arial', 0, GdViewer1.ARGBI
      (255, 65, 106, 28), 0.3, 1, 30);
end;

procedure TForm1.AddText1Click(Sender: TObject);
begin

  GdViewer1.AddTextAnnotationInteractive('Double click to change text',
    GdViewer1.ARGBI(255, 0, 0, 0), 'Arial', 0, 12, true, GdViewer1.ARGBI
      (255, 0, 0, 0), GdViewer1.ARGBI(255, 255, 0, 0), 1, 0);
end;

procedure TForm1.Burnannotationstopage1Click(Sender: TObject);
begin
  GdViewer1.BurnAnnotationsToPage(true);
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
  GdViewer1.DisplayPreviousPage();
end;

procedure TForm1.Button6Click(Sender: TObject);
begin
  GdViewer1.DisplayFirstPage();
end;

procedure TForm1.Button8Click(Sender: TObject);
begin
  GdViewer1.RemoveAllRegions;
  GdViewer1.SearchText(Edit1.Text, 0, false);
end;

procedure TForm1.Exit1Click(Sender: TObject);
begin
  application.terminate;
 end;

end.
