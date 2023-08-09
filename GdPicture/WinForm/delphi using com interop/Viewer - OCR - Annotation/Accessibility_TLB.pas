unit Accessibility_TLB;

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
// Type Lib: oleacc.dll (1)
// LIBID: {1EA4DBF0-3C3B-11CF-810C-00AA00389B71}
// LCID: 0
// Helpfile: 
// HelpString: 
// DepndLst: 
//   (1) v2.0 stdole, (C:\Windows\system32\stdole2.tlb)
// Parent TypeLibrary:
//   (0) v6.5 GdPicture_NET, (C:\Program Files\GdPicture.NET\Redist\COM Interop\GdPicture.NET.tlb)
// Errors:
//   Hint: Parameter 'var' of IAccPropServices.SetPropValue changed to 'var_'
//   Hint: Parameter 'var' of IAccPropServices.SetHwndProp changed to 'var_'
//   Hint: Parameter 'var' of IAccPropServices.SetHmenuProp changed to 'var_'
// ************************************************************************ //
{$TYPEDADDRESS OFF} // Unit must be compiled without type-checked pointers. 
{$WARN SYMBOL_PLATFORM OFF}
{$WRITEABLECONST ON}
{$VARPROPSETTER ON}
interface

uses Windows, ActiveX, Classes, Graphics, OleServer, StdVCL, Variants;
  

// *********************************************************************//
// GUIDS declared in the TypeLibrary. Following prefixes are used:        
//   Type Libraries     : LIBID_xxxx                                      
//   CoClasses          : CLASS_xxxx                                      
//   DISPInterfaces     : DIID_xxxx                                       
//   Non-DISP interfaces: IID_xxxx                                        
// *********************************************************************//
const
  // TypeLibrary Major and minor versions
  AccessibilityMajorVersion = 1;
  AccessibilityMinorVersion = 1;

  LIBID_Accessibility: TGUID = '{1EA4DBF0-3C3B-11CF-810C-00AA00389B71}';

  IID_IAccessible: TGUID = '{618736E0-3C3D-11CF-810C-00AA00389B71}';
  IID_IAccessibleHandler: TGUID = '{03022430-ABC4-11D0-BDE2-00AA001A1953}';
  IID_IAccIdentity: TGUID = '{7852B78D-1CFD-41C1-A615-9C0C85960B5F}';
  IID_IAccPropServer: TGUID = '{76C0DBBB-15E0-4E7B-B61B-20EEEA2001E0}';
  IID_IAccPropServices: TGUID = '{6E26E776-04F0-495D-80E4-3330352E3169}';
  CLASS_CAccPropServices: TGUID = '{B5F8350B-0548-48B1-A6EE-88BD00B4A5E7}';

// *********************************************************************//
// Declaration of Enumerations defined in Type Library                    
// *********************************************************************//
// Constants for enum AnnoScope
type
  AnnoScope = TOleEnum;
const
  ANNO_THIS = $00000000;
  ANNO_CONTAINER = $00000001;

type

// *********************************************************************//
// Forward declaration of types defined in TypeLibrary                    
// *********************************************************************//
  IAccessible = interface;
  IAccessibleDisp = dispinterface;
  IAccessibleHandler = interface;
  IAccIdentity = interface;
  IAccPropServer = interface;
  IAccPropServices = interface;

// *********************************************************************//
// Declaration of CoClasses defined in Type Library                       
// (NOTE: Here we map each CoClass to its Default Interface)              
// *********************************************************************//
  CAccPropServices = IAccPropServices;


// *********************************************************************//
// Declaration of structures, unions and aliases.                         
// *********************************************************************//
  wireHWND = ^_RemotableHandle; 
  wireHMENU = ^_RemotableHandle; 
  PByte1 = ^Byte; {*}
  PUserType1 = ^TGUID; {*}


  __MIDL_IWinTypes_0009 = record
    case Integer of
      0: (hInproc: Integer);
      1: (hRemote: Integer);
  end;

  _RemotableHandle = packed record
    fContext: Integer;
    u: __MIDL_IWinTypes_0009;
  end;


// *********************************************************************//
// Interface: IAccessible
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {618736E0-3C3D-11CF-810C-00AA00389B71}
// *********************************************************************//
  IAccessible = interface(IDispatch)
    ['{618736E0-3C3D-11CF-810C-00AA00389B71}']
    function Get_accParent: IDispatch; safecall;
    function Get_accChildCount: Integer; safecall;
    function Get_accChild(varChild: OleVariant): IDispatch; safecall;
    function Get_accName(varChild: OleVariant): WideString; safecall;
    function Get_accValue(varChild: OleVariant): WideString; safecall;
    function Get_accDescription(varChild: OleVariant): WideString; safecall;
    function Get_accRole(varChild: OleVariant): OleVariant; safecall;
    function Get_accState(varChild: OleVariant): OleVariant; safecall;
    function Get_accHelp(varChild: OleVariant): WideString; safecall;
    function Get_accHelpTopic(out pszHelpFile: WideString; varChild: OleVariant): Integer; safecall;
    function Get_accKeyboardShortcut(varChild: OleVariant): WideString; safecall;
    function Get_accFocus: OleVariant; safecall;
    function Get_accSelection: OleVariant; safecall;
    function Get_accDefaultAction(varChild: OleVariant): WideString; safecall;
    procedure accSelect(flagsSelect: Integer; varChild: OleVariant); safecall;
    procedure accLocation(out pxLeft: Integer; out pyTop: Integer; out pcxWidth: Integer; 
                          out pcyHeight: Integer; varChild: OleVariant); safecall;
    function accNavigate(navDir: Integer; varStart: OleVariant): OleVariant; safecall;
    function accHitTest(xLeft: Integer; yTop: Integer): OleVariant; safecall;
    procedure accDoDefaultAction(varChild: OleVariant); safecall;
    procedure Set_accName(varChild: OleVariant; const pszName: WideString); safecall;
    procedure Set_accValue(varChild: OleVariant; const pszValue: WideString); safecall;
    property accParent: IDispatch read Get_accParent;
    property accChildCount: Integer read Get_accChildCount;
    property accChild[varChild: OleVariant]: IDispatch read Get_accChild;
    property accName[varChild: OleVariant]: WideString read Get_accName write Set_accName;
    property accValue[varChild: OleVariant]: WideString read Get_accValue write Set_accValue;
    property accDescription[varChild: OleVariant]: WideString read Get_accDescription;
    property accRole[varChild: OleVariant]: OleVariant read Get_accRole;
    property accState[varChild: OleVariant]: OleVariant read Get_accState;
    property accHelp[varChild: OleVariant]: WideString read Get_accHelp;
    property accHelpTopic[out pszHelpFile: WideString; varChild: OleVariant]: Integer read Get_accHelpTopic;
    property accKeyboardShortcut[varChild: OleVariant]: WideString read Get_accKeyboardShortcut;
    property accFocus: OleVariant read Get_accFocus;
    property accSelection: OleVariant read Get_accSelection;
    property accDefaultAction[varChild: OleVariant]: WideString read Get_accDefaultAction;
  end;

// *********************************************************************//
// DispIntf:  IAccessibleDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {618736E0-3C3D-11CF-810C-00AA00389B71}
// *********************************************************************//
  IAccessibleDisp = dispinterface
    ['{618736E0-3C3D-11CF-810C-00AA00389B71}']
    property accParent: IDispatch readonly dispid -5000;
    property accChildCount: Integer readonly dispid -5001;
    property accChild[varChild: OleVariant]: IDispatch readonly dispid -5002;
    property accName[varChild: OleVariant]: WideString dispid -5003;
    property accValue[varChild: OleVariant]: WideString dispid -5004;
    property accDescription[varChild: OleVariant]: WideString readonly dispid -5005;
    property accRole[varChild: OleVariant]: OleVariant readonly dispid -5006;
    property accState[varChild: OleVariant]: OleVariant readonly dispid -5007;
    property accHelp[varChild: OleVariant]: WideString readonly dispid -5008;
    property accHelpTopic[out pszHelpFile: WideString; varChild: OleVariant]: Integer readonly dispid -5009;
    property accKeyboardShortcut[varChild: OleVariant]: WideString readonly dispid -5010;
    property accFocus: OleVariant readonly dispid -5011;
    property accSelection: OleVariant readonly dispid -5012;
    property accDefaultAction[varChild: OleVariant]: WideString readonly dispid -5013;
    procedure accSelect(flagsSelect: Integer; varChild: OleVariant); dispid -5014;
    procedure accLocation(out pxLeft: Integer; out pyTop: Integer; out pcxWidth: Integer; 
                          out pcyHeight: Integer; varChild: OleVariant); dispid -5015;
    function accNavigate(navDir: Integer; varStart: OleVariant): OleVariant; dispid -5016;
    function accHitTest(xLeft: Integer; yTop: Integer): OleVariant; dispid -5017;
    procedure accDoDefaultAction(varChild: OleVariant); dispid -5018;
  end;

// *********************************************************************//
// Interface: IAccessibleHandler
// Flags:     (272) Hidden OleAutomation
// GUID:      {03022430-ABC4-11D0-BDE2-00AA001A1953}
// *********************************************************************//
  IAccessibleHandler = interface(IUnknown)
    ['{03022430-ABC4-11D0-BDE2-00AA001A1953}']
    procedure AccessibleObjectFromID(hwnd: Integer; lObjectID: Integer; 
                                     out pIAccessible: IAccessible); safecall;
  end;

// *********************************************************************//
// Interface: IAccIdentity
// Flags:     (0)
// GUID:      {7852B78D-1CFD-41C1-A615-9C0C85960B5F}
// *********************************************************************//
  IAccIdentity = interface(IUnknown)
    ['{7852B78D-1CFD-41C1-A615-9C0C85960B5F}']
    procedure GetIdentityString(dwIDChild: LongWord; out ppIDString: PByte1; 
                                out pdwIDStringLen: LongWord); safecall;
  end;

// *********************************************************************//
// Interface: IAccPropServer
// Flags:     (0)
// GUID:      {76C0DBBB-15E0-4E7B-B61B-20EEEA2001E0}
// *********************************************************************//
  IAccPropServer = interface(IUnknown)
    ['{76C0DBBB-15E0-4E7B-B61B-20EEEA2001E0}']
    procedure GetPropValue(var pIDString: Byte; dwIDStringLen: LongWord; idProp: TGUID; 
                           out pvarValue: OleVariant; out pfHasProp: Integer); safecall;
  end;

// *********************************************************************//
// Interface: IAccPropServices
// Flags:     (0)
// GUID:      {6E26E776-04F0-495D-80E4-3330352E3169}
// *********************************************************************//
  IAccPropServices = interface(IUnknown)
    ['{6E26E776-04F0-495D-80E4-3330352E3169}']
    procedure SetPropValue(var pIDString: Byte; dwIDStringLen: LongWord; idProp: TGUID; 
                           var_: OleVariant); safecall;
    procedure SetPropServer(var pIDString: Byte; dwIDStringLen: LongWord; var paProps: TGUID; 
                            cProps: SYSINT; const pServer: IAccPropServer; AnnoScope: AnnoScope); safecall;
    procedure ClearProps(var pIDString: Byte; dwIDStringLen: LongWord; var paProps: TGUID; 
                         cProps: SYSINT); safecall;
    procedure SetHwndProp(var hwnd: _RemotableHandle; idObject: LongWord; idChild: LongWord; 
                          idProp: TGUID; var_: OleVariant); safecall;
    procedure SetHwndPropStr(var hwnd: _RemotableHandle; idObject: LongWord; idChild: LongWord; 
                             idProp: TGUID; str: PWideChar); safecall;
    procedure SetHwndPropServer(var hwnd: _RemotableHandle; idObject: LongWord; idChild: LongWord; 
                                var paProps: TGUID; cProps: SYSINT; const pServer: IAccPropServer; 
                                AnnoScope: AnnoScope); safecall;
    procedure ClearHwndProps(var hwnd: _RemotableHandle; idObject: LongWord; idChild: LongWord; 
                             var paProps: TGUID; cProps: SYSINT); safecall;
    procedure ComposeHwndIdentityString(var hwnd: _RemotableHandle; idObject: LongWord; 
                                        idChild: LongWord; out ppIDString: PByte1; 
                                        out pdwIDStringLen: LongWord); safecall;
    procedure DecomposeHwndIdentityString(var pIDString: Byte; dwIDStringLen: LongWord; 
                                          out phwnd: wireHWND; out pidObject: LongWord; 
                                          out pidChild: LongWord); safecall;
    procedure SetHmenuProp(var hmenu: _RemotableHandle; idChild: LongWord; idProp: TGUID; 
                           var_: OleVariant); safecall;
    procedure SetHmenuPropStr(var hmenu: _RemotableHandle; idChild: LongWord; idProp: TGUID; 
                              str: PWideChar); safecall;
    procedure SetHmenuPropServer(var hmenu: _RemotableHandle; idChild: LongWord; 
                                 var paProps: TGUID; cProps: SYSINT; const pServer: IAccPropServer; 
                                 AnnoScope: AnnoScope); safecall;
    procedure ClearHmenuProps(var hmenu: _RemotableHandle; idChild: LongWord; var paProps: TGUID; 
                              cProps: SYSINT); safecall;
    procedure ComposeHmenuIdentityString(var hmenu: _RemotableHandle; idChild: LongWord; 
                                         out ppIDString: PByte1; out pdwIDStringLen: LongWord); safecall;
    procedure DecomposeHmenuIdentityString(var pIDString: Byte; dwIDStringLen: LongWord; 
                                           out phmenu: wireHMENU; out pidChild: LongWord); safecall;
  end;

// *********************************************************************//
// The Class CoCAccPropServices provides a Create and CreateRemote method to          
// create instances of the default interface IAccPropServices exposed by              
// the CoClass CAccPropServices. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCAccPropServices = class
    class function Create: IAccPropServices;
    class function CreateRemote(const MachineName: string): IAccPropServices;
  end;

implementation

uses ComObj;

class function CoCAccPropServices.Create: IAccPropServices;
begin
  Result := CreateComObject(CLASS_CAccPropServices) as IAccPropServices;
end;

class function CoCAccPropServices.CreateRemote(const MachineName: string): IAccPropServices;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CAccPropServices) as IAccPropServices;
end;

end.
