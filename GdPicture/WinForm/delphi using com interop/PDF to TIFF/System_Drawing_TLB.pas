unit System_Drawing_TLB;

// ************************************************************************ //
// WARNING                                                                    
// -------                                                                    
// The types declared in this file were generated from data read from a       
// Type Library. If this type library is explicitly or indirectly (via        
// another type library referring to this type library) re-imported, or the   
// 'Refresh' command of the Type Library Editor activated while editing the   
// Type Library, the contents of this file will be regenerated and all        
// manual modifications will be lost.                                         
// ************************************************************************ //

// PASTLWTR : 1.2
// File generated on 07/12/2009 11:06:23 from Type Library described below.

// ************************************************************************  //
// Type Lib: C:\Windows\Microsoft.NET\Framework\v2.0.50727\System.Drawing.tlb (1)
// LIBID: {D37E2A3E-8545-3A39-9F4F-31827C9124AB}
// LCID: 0
// Helpfile: 
// HelpString: System.Drawing.dll
// DepndLst: 
//   (1) v2.0 stdole, (C:\Windows\system32\stdole2.tlb)
//   (2) v2.0 mscorlib, (C:\Windows\Microsoft.NET\Framework\v2.0.50727\mscorlib.tlb)
// Parent TypeLibrary:
//   (0) v6.5 GdPicture_NET, (C:\Program Files\GdPicture.NET\Redist\COM Interop\GdPicture.NET.tlb)
// ************************************************************************ //
{$TYPEDADDRESS OFF} // Unit must be compiled without type-checked pointers. 
{$WARN SYMBOL_PLATFORM OFF}
{$WRITEABLECONST ON}
{$VARPROPSETTER ON}
interface

uses Windows, ActiveX, Classes, Graphics, mscorlib_TLB, OleServer, StdVCL, Variants;
  


// *********************************************************************//
// GUIDS declared in the TypeLibrary. Following prefixes are used:        
//   Type Libraries     : LIBID_xxxx                                      
//   CoClasses          : CLASS_xxxx                                      
//   DISPInterfaces     : DIID_xxxx                                       
//   Non-DISP interfaces: IID_xxxx                                        
// *********************************************************************//
const
  // TypeLibrary Major and minor versions
  System_DrawingMajorVersion = 2;
  System_DrawingMinorVersion = 0;

  LIBID_System_Drawing: TGUID = '{D37E2A3E-8545-3A39-9F4F-31827C9124AB}';

  IID__Image: TGUID = '{2948EBCD-5E0A-3184-9A87-37D3258C0D98}';
  IID__Bitmap: TGUID = '{F86086E0-A89E-3EBE-B036-79BF72354656}';
  IID__Font: TGUID = '{BC28F4B1-B9AB-3DD8-A471-5B7AE757F8F9}';
  CLASS_Image: TGUID = '{451DBF16-B46B-3B4F-993C-EFD8B01553A0}';
  CLASS_Bitmap: TGUID = '{6549E875-8857-35A3-94A2-C3D574DDEB1D}';
  CLASS_Font: TGUID = '{091B628B-3473-38BF-9A98-4F9DB4FB61F8}';

// *********************************************************************//
// Declaration of Enumerations defined in Type Library                    
// *********************************************************************//
// Constants for enum CopyPixelOperation
type
  CopyPixelOperation = TOleEnum;
const
  CopyPixelOperation_Blackness = $00000042;
  CopyPixelOperation_CaptureBlt = $40000000;
  CopyPixelOperation_DestinationInvert = $00550009;
  CopyPixelOperation_MergeCopy = $00C000CA;
  CopyPixelOperation_MergePaint = $00BB0226;
  CopyPixelOperation_NoMirrorBitmap = $80000000;
  CopyPixelOperation_NotSourceCopy = $00330008;
  CopyPixelOperation_NotSourceErase = $001100A6;
  CopyPixelOperation_PatCopy = $00F00021;
  CopyPixelOperation_PatInvert = $005A0049;
  CopyPixelOperation_PatPaint = $00FB0A09;
  CopyPixelOperation_SourceAnd = $008800C6;
  CopyPixelOperation_SourceCopy = $00CC0020;
  CopyPixelOperation_SourceErase = $00440328;
  CopyPixelOperation_SourceInvert = $00660046;
  CopyPixelOperation_SourcePaint = $00EE0086;
  CopyPixelOperation_Whiteness = $00FF0062;

type

// *********************************************************************//
// Forward declaration of types defined in TypeLibrary                    
// *********************************************************************//
  _Image = interface;
  _ImageDisp = dispinterface;
  _Bitmap = interface;
  _BitmapDisp = dispinterface;
  _Font = interface;
  _FontDisp = dispinterface;

// *********************************************************************//
// Declaration of CoClasses defined in Type Library                       
// (NOTE: Here we map each CoClass to its Default Interface)              
// *********************************************************************//
  Image = _Image;
  Bitmap = _Bitmap;
  Font = _Font;


// *********************************************************************//
// Declaration of structures, unions and aliases.                         
// *********************************************************************//
  Point = packed record
    x: Integer;
    y: Integer;
  end;

  Rectangle = packed record
    x: Integer;
    y: Integer;
    width: Integer;
    height: Integer;
  end;

  Size = packed record
    width: Integer;
    height: Integer;
  end;

  PointF = packed record
    x: Single;
    y: Single;
  end;

  SizeF = packed record
    width: Single;
    height: Single;
  end;


// *********************************************************************//
// Interface: _Image
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {2948EBCD-5E0A-3184-9A87-37D3258C0D98}
// *********************************************************************//
  _Image = interface(IDispatch)
    ['{2948EBCD-5E0A-3184-9A87-37D3258C0D98}']
  end;

// *********************************************************************//
// DispIntf:  _ImageDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {2948EBCD-5E0A-3184-9A87-37D3258C0D98}
// *********************************************************************//
  _ImageDisp = dispinterface
    ['{2948EBCD-5E0A-3184-9A87-37D3258C0D98}']
  end;

// *********************************************************************//
// Interface: _Bitmap
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F86086E0-A89E-3EBE-B036-79BF72354656}
// *********************************************************************//
  _Bitmap = interface(IDispatch)
    ['{F86086E0-A89E-3EBE-B036-79BF72354656}']
  end;

// *********************************************************************//
// DispIntf:  _BitmapDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F86086E0-A89E-3EBE-B036-79BF72354656}
// *********************************************************************//
  _BitmapDisp = dispinterface
    ['{F86086E0-A89E-3EBE-B036-79BF72354656}']
  end;

// *********************************************************************//
// Interface: _Font
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {BC28F4B1-B9AB-3DD8-A471-5B7AE757F8F9}
// *********************************************************************//
  _Font = interface(IDispatch)
    ['{BC28F4B1-B9AB-3DD8-A471-5B7AE757F8F9}']
  end;

// *********************************************************************//
// DispIntf:  _FontDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {BC28F4B1-B9AB-3DD8-A471-5B7AE757F8F9}
// *********************************************************************//
  _FontDisp = dispinterface
    ['{BC28F4B1-B9AB-3DD8-A471-5B7AE757F8F9}']
  end;

// *********************************************************************//
// The Class CoImage provides a Create and CreateRemote method to          
// create instances of the default interface _Image exposed by              
// the CoClass Image. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoImage = class
    class function Create: _Image;
    class function CreateRemote(const MachineName: string): _Image;
  end;

// *********************************************************************//
// The Class CoBitmap provides a Create and CreateRemote method to          
// create instances of the default interface _Bitmap exposed by              
// the CoClass Bitmap. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoBitmap = class
    class function Create: _Bitmap;
    class function CreateRemote(const MachineName: string): _Bitmap;
  end;

// *********************************************************************//
// The Class CoFont provides a Create and CreateRemote method to          
// create instances of the default interface _Font exposed by              
// the CoClass Font. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoFont = class
    class function Create: _Font;
    class function CreateRemote(const MachineName: string): _Font;
  end;

implementation

uses ComObj;

class function CoImage.Create: _Image;
begin
  Result := CreateComObject(CLASS_Image) as _Image;
end;

class function CoImage.CreateRemote(const MachineName: string): _Image;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_Image) as _Image;
end;

class function CoBitmap.Create: _Bitmap;
begin
  Result := CreateComObject(CLASS_Bitmap) as _Bitmap;
end;

class function CoBitmap.CreateRemote(const MachineName: string): _Bitmap;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_Bitmap) as _Bitmap;
end;

class function CoFont.Create: _Font;
begin
  Result := CreateComObject(CLASS_Font) as _Font;
end;

class function CoFont.CreateRemote(const MachineName: string): _Font;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_Font) as _Font;
end;

end.
