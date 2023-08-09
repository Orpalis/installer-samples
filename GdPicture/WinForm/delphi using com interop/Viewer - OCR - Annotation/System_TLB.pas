unit System_TLB;

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
// Type Lib: C:\Windows\Microsoft.NET\Framework\v2.0.50727\System.tlb (2)
// LIBID: {BEE4BFEC-6683-3E67-9167-3C0CBC68F40A}
// LCID: 0
// Helpfile: 
// HelpString: 
// DepndLst: 
//   (1) v2.0 stdole, (C:\Windows\system32\stdole2.tlb)
//   (2) v2.0 mscorlib, (C:\Windows\Microsoft.NET\Framework\v2.0.50727\mscorlib.tlb)
// Parent TypeLibrary:
//   (0) v6.5 GdPicture_NET, (C:\Program Files\GdPicture.NET\Redist\COM Interop\GdPicture.NET.tlb)
// Errors:
//   Hint: Parameter 'property' of IEventBindingService.GetEvent changed to 'property_'
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
  SystemMajorVersion = 2;
  SystemMinorVersion = 0;

  LIBID_System: TGUID = '{BEE4BFEC-6683-3E67-9167-3C0CBC68F40A}';

  IID__CodeDomProvider: TGUID = '{61059E8D-1DD2-3F4B-A4C5-D566B8968FFB}';
  IID__TypeConverter: TGUID = '{05241989-96C5-3BF9-AB9B-37E261C1B8F8}';
  IID__CodeTypeMember: TGUID = '{8068AE1D-26CB-3DB6-97CD-ED83DE116C5A}';
  IID_ITypeDescriptorContext: TGUID = '{5CBAE170-8759-3B8A-B919-E12FB86AD1F3}';
  IID__CodeArgumentReferenceExpression: TGUID = '{A52B85C6-5370-35C9-A04A-04A92013862C}';
  IID__CodeExpression: TGUID = '{AD377794-864F-3421-9FB8-C684BBC1BC02}';
  IID__CodeArrayCreateExpression: TGUID = '{F7955E55-7F3B-3277-AA0C-F62AA615676D}';
  IID__CodeTypeReference: TGUID = '{B6D972C6-022B-3F91-9655-E288E9D32C55}';
  IID__CodeExpressionCollection: TGUID = '{AF72CC74-2275-362A-9141-A4A79D596F39}';
  IID__CodeArrayIndexerExpression: TGUID = '{732748F5-5256-327B-A7E5-2000B07F21B3}';
  IID__CodeAssignStatement: TGUID = '{E2024DE0-DC21-305D-8761-6C31F2177FB0}';
  IID__CodeStatement: TGUID = '{B125774D-EF66-382B-878D-2D916999B0D2}';
  IID__CodeAttachEventStatement: TGUID = '{F7BC47E9-706C-3AA7-B1BA-8AB95188FA11}';
  IID__CodeEventReferenceExpression: TGUID = '{35872687-5A11-34D7-85AB-865830A3BDEE}';
  IID__CodeAttributeArgument: TGUID = '{02EFD952-FF8C-3B72-8C33-739A506D53D9}';
  IID__CodeAttributeArgumentCollection: TGUID = '{FE84E484-A7EC-3D15-B5E2-EDC2DE2DB42E}';
  IID__CodeAttributeDeclaration: TGUID = '{EF72D021-2C6D-3E33-9442-574BFD6E0871}';
  IID__CodeAttributeDeclarationCollection: TGUID = '{7E9ACA22-637C-3F88-A931-AAF36A4F9A6B}';
  IID__CodeBaseReferenceExpression: TGUID = '{45E29CA6-670A-3B13-9557-4E5903056BF3}';
  IID__CodeBinaryOperatorExpression: TGUID = '{A22929C9-D301-3F5B-98B7-844FDBA1DEDF}';
  IID__CodeCastExpression: TGUID = '{90BED8ED-21E3-31FE-8F02-C929BA4FB0AC}';
  IID__CodeCatchClause: TGUID = '{609C7788-BDB0-364C-92E3-FC16AC613430}';
  IID__CodeStatementCollection: TGUID = '{4B9A5032-4B8C-3DE6-997C-C38B4B3AF26A}';
  IID__CodeCatchClauseCollection: TGUID = '{FF5E1CD9-0478-34A4-9B9C-7C80BCB1A725}';
  IID__CodeChecksumPragma: TGUID = '{7EB20114-E822-358C-BDAB-DCF9E5090F23}';
  IID__CodeDirective: TGUID = '{767E752E-2315-35CF-9652-7FC46AE870D3}';
  IID__CodeComment: TGUID = '{C94F39B3-436F-3711-9CB0-91C6299B62A2}';
  IID__CodeObject: TGUID = '{EE499EFD-22E2-3740-A64A-2AB010099C01}';
  IID__CodeCommentStatement: TGUID = '{0C13F8B9-F2E0-3918-A33E-3E491BDC529E}';
  IID__CodeCommentStatementCollection: TGUID = '{E34CEB72-8F86-333D-AEDA-069221DF6A1A}';
  IID__CodeCompileUnit: TGUID = '{6F20C263-AF67-380F-A482-9A21F7599748}';
  IID__CodeNamespaceCollection: TGUID = '{F5E54F16-ADE3-3B5D-8B05-1F9803557905}';
  IID__CodeDirectiveCollection: TGUID = '{EEFBDD27-4904-3E90-ACFC-624164CB45DD}';
  IID__CodeConditionStatement: TGUID = '{69904B31-5FB5-39BF-83B0-5DDFA1F26D71}';
  IID__CodeConstructor: TGUID = '{5A33C771-806E-337D-AE1F-66B523FC49BF}';
  IID__CodeMemberMethod: TGUID = '{95C2EE26-4247-3DDC-8056-97353F10DE8F}';
  IID__CodeDefaultValueExpression: TGUID = '{EA9E1DD2-EF9A-3570-AE1A-2F625F594C3B}';
  IID__CodeDelegateCreateExpression: TGUID = '{D14E12C1-E1D1-3B74-A3AF-021A5A268FBE}';
  IID__CodeDelegateInvokeExpression: TGUID = '{6F6C3482-8900-36EA-B621-943534E82C73}';
  IID__CodeDirectionExpression: TGUID = '{11EDAF3B-144E-32C8-8BE0-81D40A950656}';
  IID__CodeEntryPointMethod: TGUID = '{7CD4EF19-27EB-399E-8ED2-C6647A99C03E}';
  IID__CodeExpressionStatement: TGUID = '{CEA240AF-60C5-3C69-9DA1-DA3F9A6D7B3C}';
  IID__CodeFieldReferenceExpression: TGUID = '{82D57B2B-C639-32A0-89B4-62A0C29DD64E}';
  IID__CodeGotoStatement: TGUID = '{8F1BAED9-52EC-3545-9CF0-6ED71A76A5CA}';
  IID__CodeIndexerExpression: TGUID = '{C92C323F-8601-34D4-A2D6-F5E2653DB456}';
  IID__CodeIterationStatement: TGUID = '{B16F7137-C0E7-3ECF-9652-FB1EA947E44E}';
  IID__CodeLabeledStatement: TGUID = '{56699CCA-FD8D-3AD2-9643-149BAD87FD60}';
  IID__CodeLinePragma: TGUID = '{1B52DED6-92F3-3B4F-851C-AB1F647582A3}';
  IID__CodeMemberEvent: TGUID = '{E1A7EA9F-5D43-3FA9-AFBC-9A2BFDA84B65}';
  IID__CodeTypeReferenceCollection: TGUID = '{68A04561-D0A0-3EEB-B904-462DC4EB5531}';
  IID__CodeMemberField: TGUID = '{EEF50D17-7AA6-3E14-96C6-DD90FE5BAA1E}';
  IID__CodeParameterDeclarationExpressionCollection: TGUID = '{05192769-7D6A-3C8C-94C2-DFA668F61088}';
  IID__CodeTypeParameterCollection: TGUID = '{6E814F1F-C349-3766-B55D-87C9B0232B20}';
  IID__CodeMemberProperty: TGUID = '{802E2ACC-A7F8-3CA9-9114-F49998BEBE6E}';
  IID__CodeMethodInvokeExpression: TGUID = '{FFE1F142-85CF-3353-8512-EE73775E9C4C}';
  IID__CodeMethodReferenceExpression: TGUID = '{CBDF02F4-A9F4-33C0-8B24-275008890DCB}';
  IID__CodeMethodReturnStatement: TGUID = '{851D821B-1E0C-3E91-832D-BA593523F566}';
  IID__CodeNamespace: TGUID = '{31ED1DCB-C007-3F96-8809-4D5E3540A7C1}';
  IID__CodeTypeDeclarationCollection: TGUID = '{BE0ECED3-5F0D-310A-B352-7D1ADF28F8EC}';
  IID__CodeNamespaceImportCollection: TGUID = '{4C545457-76D7-3C56-B277-6A9E86D1046F}';
  IID__CodeNamespaceImport: TGUID = '{34418787-726B-3E74-AEED-C01397FC707D}';
  IID__CodeObjectCreateExpression: TGUID = '{CFE5E5E9-745F-348B-A7E6-38A46D1A20E0}';
  IID__CodeParameterDeclarationExpression: TGUID = '{EE96565B-2B1A-33C6-BA07-B63158F1C8C4}';
  IID__CodePrimitiveExpression: TGUID = '{175BB49A-4CBE-38B3-8C6C-1B0145EDABB7}';
  IID__CodePropertyReferenceExpression: TGUID = '{F8D64802-F9B7-3095-A641-D31E6E9F87B1}';
  IID__CodePropertySetValueReferenceExpression: TGUID = '{2EE13FA1-8A02-3573-9AC9-4FEBD2CEAB45}';
  IID__CodeRegionDirective: TGUID = '{26AE5CC6-CCFD-3906-8B68-16E5EEFABB10}';
  IID__CodeRemoveEventStatement: TGUID = '{853BC437-CA6E-375D-BCBB-818E917D9691}';
  IID__CodeSnippetCompileUnit: TGUID = '{C7D34CF6-CF82-38B0-BF67-EB36DA63AE6E}';
  IID__CodeSnippetExpression: TGUID = '{9F3E3CD1-8082-31E9-851C-3E177E56A87B}';
  IID__CodeSnippetStatement: TGUID = '{B4B00613-C48B-3FA9-B8F6-A527EC6F21C3}';
  IID__CodeSnippetTypeMember: TGUID = '{575BF8D0-7A9D-39EB-81F9-AA2BEBA890FA}';
  IID__CodeThisReferenceExpression: TGUID = '{3B4A1A6B-8E65-355D-B93A-E6AB753B2401}';
  IID__CodeThrowExceptionStatement: TGUID = '{12350E95-6F4E-30F0-9343-72F1C64380A0}';
  IID__CodeTryCatchFinallyStatement: TGUID = '{8FD0F76A-29BF-3982-8335-C9B44ABF31C3}';
  IID__CodeTypeConstructor: TGUID = '{261AD877-0F22-33DE-9A3A-31F5DA424B30}';
  IID__CodeTypeDeclaration: TGUID = '{7AA363E1-FA53-31EB-BE4A-1EB4838264F3}';
  IID__CodeTypeMemberCollection: TGUID = '{F943231E-6192-33A0-9CA3-D6ED0E4F323D}';
  IID__CodeTypeDelegate: TGUID = '{455090AB-5C44-3F4F-8EED-CCC90A3112B5}';
  IID__CodeTypeOfExpression: TGUID = '{12CBCE8E-75FF-312F-81B9-7FBC6212090B}';
  IID__CodeTypeParameter: TGUID = '{B6ED2127-296F-3B31-AEB5-E2101E98D746}';
  IID__CodeTypeReferenceExpression: TGUID = '{726BB04D-2C4C-3E3D-A01A-31448DB063DD}';
  IID__CodeVariableDeclarationStatement: TGUID = '{4192A87C-5C57-3879-8624-AF5CA2ED9EB2}';
  IID__CodeVariableReferenceExpression: TGUID = '{54B54936-A71C-3A45-B982-2C484E7BCF86}';
  IID__Component: TGUID = '{06565C0F-C465-37DE-896F-9864BC0BFC96}';
  IID__AttributeCollection: TGUID = '{6F971E04-B06A-3DD0-B6F5-622826693454}';
  IID__PropertyDescriptor: TGUID = '{FE5060F8-212F-3A4F-8FA8-DB2E14588C49}';
  IID_IComponent: TGUID = '{B86E59F2-F1E2-389D-B5F1-C55307C8106E}';
  IID_ISite: TGUID = '{C4E1006A-9D98-3E96-A07E-921725135C28}';
  IID_IContainer: TGUID = '{61D9C50C-4AAD-3539-AF82-4F36C19D77C8}';
  IID__ComponentCollection: TGUID = '{42F00C62-F454-3A38-AF9E-35D4E2BDFDAC}';
  IID__EventDescriptor: TGUID = '{95B6A563-4A39-37A2-91D7-04B8ECDD1B66}';
  IID__EventDescriptorCollection: TGUID = '{4C933253-83F2-35B6-961A-0780FF1BAF7C}';
  IID__MemberDescriptor: TGUID = '{F55EFA91-812E-3C6E-998F-3598E93FB8A7}';
  IID__MarshalByValueComponent: TGUID = '{35F38044-2017-3E05-BA83-1B87CC0D49C7}';
  IID_IDesigner: TGUID = '{6EEF3D0D-305A-3DF4-9830-8C2B40E1C4BF}';
  IID_IDesignerHost: TGUID = '{EEC98CD8-EF5B-3B60-82C9-86F616F6BB20}';
  IID__CommandID: TGUID = '{FC50598B-2406-33D2-BA9A-CFBEA52BC05A}';
  IID__ComponentChangedEventArgs: TGUID = '{A8FEF1C6-D434-3686-A4DE-B68E8EABB509}';
  IID__ComponentChangedEventHandler: TGUID = '{0451C390-1F90-341D-9278-B9FF2636D67D}';
  IID__ComponentChangingEventArgs: TGUID = '{B78CBAA3-37DF-31C9-ABD2-CDCB1A7FBA9F}';
  IID__ComponentChangingEventHandler: TGUID = '{7F8C2DA3-D337-334F-92E9-87BE9BDC6070}';
  IID__ComponentEventArgs: TGUID = '{438E8DCF-6875-305F-8CA5-40DBB15782A6}';
  IID__ComponentEventHandler: TGUID = '{290B355D-80D3-3AFA-96AB-B4D395729374}';
  IID__ComponentRenameEventArgs: TGUID = '{DA5D7739-9522-3E28-9AB7-7C2D7D27C63A}';
  IID__ComponentRenameEventHandler: TGUID = '{BA2DF049-DA87-3BD1-97B0-7904B59ADF7E}';
  IID__DesignerTransactionCloseEventArgs: TGUID = '{3924A637-C2C4-3558-945F-279B5AC39ED9}';
  IID__DesignerTransactionCloseEventHandler: TGUID = '{4543D155-EE6A-3529-BC8D-CF0E866B6B0B}';
  IID__DesignerVerb: TGUID = '{7C41B90E-52FB-3E54-8B03-EBE0BF172C84}';
  IID__MenuCommand: TGUID = '{1FF238CE-6190-3750-A34F-05F02B7315A6}';
  IID__DesignerVerbCollection: TGUID = '{AC3BDDA4-25B8-3321-A1C0-7C37BBF2DDED}';
  IID_IComponentChangeService: TGUID = '{2FEF0210-9EBD-32C0-9BFD-24841AC0FCF7}';
  IID_IServiceContainer: TGUID = '{6BA96B42-7FDD-3223-BF52-7FE677B92815}';
  IID_IEventBindingService: TGUID = '{1A19D89E-F4FE-3E8E-B7EC-05D4E592F3F6}';
  IID_IMenuCommandService: TGUID = '{DF651C5D-783E-3789-901F-A962B7587E69}';
  IID_IRootDesigner: TGUID = '{2CC5E562-6C14-34A6-9D0B-E6FF949AE8FB}';
  IID_ISelectionService: TGUID = '{297A65BE-5080-3F7F-AD19-B0D05D6F2327}';
  IID__ServiceCreatorCallback: TGUID = '{BE380BEC-79F2-3876-B510-FA2FE43B7EB7}';
  IID__DesignerLoader: TGUID = '{43BE964C-1B4A-3D1F-9D94-8185A1E6CB7B}';
  IID__PerformanceCounterManager: TGUID = '{A9809E7D-42F8-3284-82CF-AB5F863A29AA}';
  IID__WebHeaderCollection: TGUID = '{B97E84F2-FAB2-340D-8D49-2AC85CF5C0EC}';
  IID__WebClient: TGUID = '{85B4A627-7552-3AA6-8A1C-A213C5788FEC}';
  IID__StandardOleMarshalObject: TGUID = '{05F3D6C7-D4D1-37EB-AC35-63347B838A23}';
  CLASS_CodeDomProvider: TGUID = '{5FAD3639-1A4D-3BDC-A4A5-C59E36165F5B}';
  CLASS_TypeConverter: TGUID = '{75992C48-BF7A-3B44-AC68-A946CFFDB2BF}';
  CLASS_CodeTypeMember: TGUID = '{69DCE654-E184-38E5-BFD6-E0EB6F592A11}';
  CLASS_CodeArgumentReferenceExpression: TGUID = '{3E3F971A-A80D-3468-A9EB-3113CE46D13A}';
  CLASS_CodeExpression: TGUID = '{F4267FE0-72E6-34E2-9093-17DEA43078C1}';
  CLASS_CodeArrayCreateExpression: TGUID = '{24B3BCED-984A-340B-923C-C9B39D94D5A9}';
  CLASS_CodeTypeReference: TGUID = '{F3DE25AC-25ED-374C-8805-4B6456FA0CB2}';
  CLASS_CodeExpressionCollection: TGUID = '{26D06C1F-81BA-33C3-BDE2-49747AA83A11}';
  CLASS_CodeArrayIndexerExpression: TGUID = '{8C0BC333-6F03-3228-8B5C-31C8627DAAB3}';
  CLASS_CodeAssignStatement: TGUID = '{E4350CAA-27C9-320E-AC79-71294ABDA592}';
  CLASS_CodeStatement: TGUID = '{10A98D9F-994D-3762-89B4-2116A95063EE}';
  CLASS_CodeAttachEventStatement: TGUID = '{1AB6B26C-A339-3B51-9308-44CA3A05F873}';
  CLASS_CodeEventReferenceExpression: TGUID = '{E396945B-2690-377E-A992-12775D444CD7}';
  CLASS_CodeAttributeArgument: TGUID = '{06E6FAA2-7623-396A-B9F1-75D31A17CF27}';
  CLASS_CodeAttributeArgumentCollection: TGUID = '{424720CD-671F-329D-80DF-FA8BCD9EA9CD}';
  CLASS_CodeAttributeDeclaration: TGUID = '{C0BA0202-2FF3-3E0A-952A-B570B1371DB2}';
  CLASS_CodeAttributeDeclarationCollection: TGUID = '{3A8E937E-C560-3779-A423-B645BAD276A1}';
  CLASS_CodeBaseReferenceExpression: TGUID = '{3A9E7044-FBD0-3E23-82AE-F0DFB86C0C4E}';
  CLASS_CodeBinaryOperatorExpression: TGUID = '{30776C84-E88E-330D-8CE2-B5BF1E48427D}';
  CLASS_CodeCastExpression: TGUID = '{DE2AE793-C1C1-3C33-8B9C-0D8F90301860}';
  CLASS_CodeCatchClause: TGUID = '{548F7954-B3FD-39E0-9A30-9D8FC9443C0E}';
  CLASS_CodeStatementCollection: TGUID = '{A531374E-FA08-36C6-AF96-31C684EEFC08}';
  CLASS_CodeCatchClauseCollection: TGUID = '{2077ECF3-61C8-3CC5-9E45-721189A88E03}';
  CLASS_CodeChecksumPragma: TGUID = '{E1845F73-C0CC-3B6B-B913-6E43F42D8BA1}';
  CLASS_CodeDirective: TGUID = '{6B405F7D-01CA-3595-A65B-34CB0168ACA0}';
  CLASS_CodeComment: TGUID = '{F3E7E9C5-E63A-3F3B-A4F8-096E82664819}';
  CLASS_CodeObject: TGUID = '{88D0C986-398A-3A31-9349-B0736357C40B}';
  CLASS_CodeCommentStatement: TGUID = '{F69F43D6-EF83-3723-8839-519D2421E927}';
  CLASS_CodeCommentStatementCollection: TGUID = '{C12A8292-F24A-3BA8-94E6-EB3206D225E2}';
  CLASS_CodeCompileUnit: TGUID = '{25A5D609-4D61-3C52-A3E1-49EF93066FD1}';
  CLASS_CodeNamespaceCollection: TGUID = '{D4985194-80E5-36FE-8B95-8CD2E35E5FF5}';
  CLASS_CodeDirectiveCollection: TGUID = '{ED78C3FA-AB56-353C-98BB-9280D3404C81}';
  CLASS_CodeConditionStatement: TGUID = '{1BA2DE2F-EE39-3628-968F-0E12705013C4}';
  CLASS_CodeConstructor: TGUID = '{2A7A02A4-408D-32C6-B5E2-BC4B57399B0C}';
  CLASS_CodeMemberMethod: TGUID = '{812E9B72-2CCC-364B-9EB8-DA8F4EAE724F}';
  CLASS_CodeDefaultValueExpression: TGUID = '{5AECB7A2-5797-3BFF-9B86-FC4CB9AE4F41}';
  CLASS_CodeDelegateCreateExpression: TGUID = '{92FB692E-211C-33DA-BE48-05B690D3F00B}';
  CLASS_CodeDelegateInvokeExpression: TGUID = '{D79B10B1-16A3-3A23-A606-CE1227F3765A}';
  CLASS_CodeDirectionExpression: TGUID = '{5FEA4BE0-D7FC-3DAF-877E-16F181F18BAE}';
  CLASS_CodeEntryPointMethod: TGUID = '{DFF5C8A1-425F-305D-AE85-10C9DD7704C3}';
  CLASS_CodeExpressionStatement: TGUID = '{ABC8FC89-D640-32FC-9E9F-04410010E5EC}';
  CLASS_CodeFieldReferenceExpression: TGUID = '{E2F01F29-A264-387B-AE29-A273AC89EEE7}';
  CLASS_CodeGotoStatement: TGUID = '{148E03E0-C74E-3D67-BD3A-B27995F9AC49}';
  CLASS_CodeIndexerExpression: TGUID = '{4D19B9BB-0979-38BE-B438-29997E58C2D1}';
  CLASS_CodeIterationStatement: TGUID = '{421C8130-0316-3993-801D-E6BE3A159BAA}';
  CLASS_CodeLabeledStatement: TGUID = '{4975B127-5464-3E9E-B4AA-D6DF3721189A}';
  CLASS_CodeLinePragma: TGUID = '{17575EA6-BE56-381E-88E7-74B376743E77}';
  CLASS_CodeMemberEvent: TGUID = '{E401E3C7-2646-37C7-A37A-BA115D000FAA}';
  CLASS_CodeTypeReferenceCollection: TGUID = '{3F2E333C-9A04-33AC-95C7-7B0015BEB345}';
  CLASS_CodeMemberField: TGUID = '{ACDCDF3A-21DC-37E3-9253-CD26CAEC0B58}';
  CLASS_CodeParameterDeclarationExpressionCollection: TGUID = '{7FD9E7C0-B133-302F-A3A1-42167780CB62}';
  CLASS_CodeTypeParameterCollection: TGUID = '{6019C9D4-84CB-33BC-9E79-25F21172C33B}';
  CLASS_CodeMemberProperty: TGUID = '{D459C868-9174-353A-BB17-F2166E83FE24}';
  CLASS_CodeMethodInvokeExpression: TGUID = '{62AC67B4-2088-3DB7-9A80-154EFE9C6CAF}';
  CLASS_CodeMethodReferenceExpression: TGUID = '{36AE2637-C0A4-3214-8A93-AEE1CABD540E}';
  CLASS_CodeMethodReturnStatement: TGUID = '{031A6B24-BFAA-3D76-B6DA-59C9C469A0FB}';
  CLASS_CodeNamespace: TGUID = '{DD1C0C7A-BC95-339A-8321-9DBF4803CAF4}';
  CLASS_CodeTypeDeclarationCollection: TGUID = '{A0BD9913-B07D-32C3-8DF1-AA998B3FB10E}';
  CLASS_CodeNamespaceImportCollection: TGUID = '{7A168834-5605-30DB-8274-6B21E621A955}';
  CLASS_CodeNamespaceImport: TGUID = '{B0B32470-44A6-3DBC-BDB2-CE024F966088}';
  CLASS_CodeObjectCreateExpression: TGUID = '{F3BA98C3-39CF-3C2D-ADA5-75BD63D7AF08}';
  CLASS_CodeParameterDeclarationExpression: TGUID = '{6ACD3B02-EF29-31B9-8958-45B47BAD4A00}';
  CLASS_CodePrimitiveExpression: TGUID = '{6C1E6791-0558-3CD3-AAB8-C90A2B03EF5F}';
  CLASS_CodePropertyReferenceExpression: TGUID = '{9703F066-9C59-32C4-86B2-570E97AB75F2}';
  CLASS_CodePropertySetValueReferenceExpression: TGUID = '{395C1A4D-AABB-3415-B527-8CB694777B84}';
  CLASS_CodeRegionDirective: TGUID = '{932861EC-65C4-30F0-905D-905B9CE98979}';
  CLASS_CodeRemoveEventStatement: TGUID = '{F38B3709-9B63-32E6-9CFB-07991C40717F}';
  CLASS_CodeSnippetCompileUnit: TGUID = '{AF2DF285-73D3-3623-AEAB-1CDBCF75A9D0}';
  CLASS_CodeSnippetExpression: TGUID = '{509AF058-A0E5-32E6-AE00-15F8209D31F9}';
  CLASS_CodeSnippetStatement: TGUID = '{880287BC-D3A4-3113-B8D1-6538B7C19E97}';
  CLASS_CodeSnippetTypeMember: TGUID = '{0FAC5DAB-AD52-38BF-854E-FD3059369C44}';
  CLASS_CodeThisReferenceExpression: TGUID = '{21206362-562F-3F08-8F06-4BCFD2C95F29}';
  CLASS_CodeThrowExceptionStatement: TGUID = '{A2F81DED-8536-3C27-9759-BA3EAC94D0A2}';
  CLASS_CodeTryCatchFinallyStatement: TGUID = '{CB3BF2D6-DB22-31DF-A6F4-E3707972E10C}';
  CLASS_CodeTypeConstructor: TGUID = '{7544623F-E6DE-3918-9E10-29AAF16E560B}';
  CLASS_CodeTypeDeclaration: TGUID = '{2B708A48-52D8-3049-9565-6BA42EE2BE17}';
  CLASS_CodeTypeMemberCollection: TGUID = '{85D435C5-7AF6-30E9-8A0B-C978737C2849}';
  CLASS_CodeTypeDelegate: TGUID = '{6FBC1E34-565D-3721-B5C0-5C796540481F}';
  CLASS_CodeTypeOfExpression: TGUID = '{FB6A595A-B5DD-3361-8842-70E806D73573}';
  CLASS_CodeTypeParameter: TGUID = '{E5E30108-7A5B-398F-B50C-09793C6299E1}';
  CLASS_CodeTypeReferenceExpression: TGUID = '{8871C106-C8BA-37A0-ADE2-E4AEBEC7E3C9}';
  CLASS_CodeVariableDeclarationStatement: TGUID = '{943B4474-D661-344E-AD1B-1A1F3C8EA01A}';
  CLASS_CodeVariableReferenceExpression: TGUID = '{39ABD141-93AE-397A-9E98-6F2E50124CEC}';
  CLASS_component: TGUID = '{B3B21824-D0F3-3815-847F-228660E2A20E}';
  CLASS_AttributeCollection: TGUID = '{4309D526-F739-3BE3-B89C-4F6DDE852C14}';
  CLASS_PropertyDescriptor: TGUID = '{D40E4E6F-4692-3438-B4CC-7E423473B2C1}';
  CLASS_ComponentCollection: TGUID = '{9653003F-5A61-33CB-86E6-1BA38CED5DF8}';
  CLASS_EventDescriptor: TGUID = '{52964536-AFDA-35C2-8C8B-903C2519AD4E}';
  CLASS_EventDescriptorCollection: TGUID = '{C657A06C-7655-32F7-8CC8-9A3BDC803487}';
  CLASS_MemberDescriptor: TGUID = '{670B0D04-DAD1-39A7-9043-B0B58CCB46E6}';
  CLASS_MarshalByValueComponent: TGUID = '{F3FA95A9-C5F9-3EF9-80C6-91275015C770}';
  CLASS_CommandID: TGUID = '{E60178F7-1512-389F-9CA6-084DF14CF596}';
  CLASS_ComponentChangedEventArgs: TGUID = '{06CBA6E8-112A-32BA-A7BF-7DCFE0404931}';
  CLASS_ComponentChangedEventHandler: TGUID = '{01157188-EB62-312D-AEA6-14332A2AEBF9}';
  CLASS_ComponentChangingEventArgs: TGUID = '{834C5649-9074-33F5-AB36-716D4AE08E9E}';
  CLASS_ComponentChangingEventHandler: TGUID = '{D296EB38-ADD4-3FBE-8CF5-03CBD74DDB74}';
  CLASS_ComponentEventArgs: TGUID = '{CB919E0F-1205-37EC-AC02-38B51390629F}';
  CLASS_ComponentEventHandler: TGUID = '{C001B07F-6B98-359A-8F0A-652F82BD81E1}';
  CLASS_ComponentRenameEventArgs: TGUID = '{F41E1B27-1C7C-3620-9662-BF72882E3F7E}';
  CLASS_ComponentRenameEventHandler: TGUID = '{819762B6-DC8A-3A36-B063-82BC2EE44168}';
  CLASS_DesignerTransactionCloseEventArgs: TGUID = '{C5D1EAB9-E039-399E-A709-9A0A7107A610}';
  CLASS_DesignerTransactionCloseEventHandler: TGUID = '{54BF09CE-0DB6-3D92-AA2D-546AD897EF59}';
  CLASS_DesignerVerb: TGUID = '{5231CCD9-DABB-3FDE-AD29-8FD3D382C248}';
  CLASS_MenuCommand: TGUID = '{5C719461-3A18-33D0-B3E1-33F169085C21}';
  CLASS_DesignerVerbCollection: TGUID = '{67114ED5-9F2A-3A0A-8C7A-746FDA064488}';
  CLASS_ServiceCreatorCallback: TGUID = '{E90ADE71-CAC0-3F72-834E-CD39F93670EE}';
  CLASS_DesignerLoader: TGUID = '{AD44E49C-2DED-33BD-83A6-9EB9C6C66F39}';
  CLASS_PerformanceCounterManager: TGUID = '{82840BE1-D273-11D2-B94A-00600893B17A}';
  CLASS_WebHeaderCollection: TGUID = '{430D1273-C3E9-3632-9988-389C81849C00}';
  CLASS_WebClient: TGUID = '{7D458845-B4B8-30CB-B2AD-FC4960FCDF81}';
  CLASS_StandardOleMarshalObject: TGUID = '{0EF62602-E19F-3DF5-BE17-A43AAF6BA008}';

// *********************************************************************//
// Declaration of Enumerations defined in Type Library                    
// *********************************************************************//
// Constants for enum CodeBinaryOperatorType
type
  CodeBinaryOperatorType = TOleEnum;
const
  CodeBinaryOperatorType_Add = $00000000;
  CodeBinaryOperatorType_Assign = $00000005;
  CodeBinaryOperatorType_BitwiseAnd = $0000000A;
  CodeBinaryOperatorType_BitwiseOr = $00000009;
  CodeBinaryOperatorType_BooleanAnd = $0000000C;
  CodeBinaryOperatorType_BooleanOr = $0000000B;
  CodeBinaryOperatorType_Divide = $00000003;
  CodeBinaryOperatorType_GreaterThan = $0000000F;
  CodeBinaryOperatorType_GreaterThanOrEqual = $00000010;
  CodeBinaryOperatorType_IdentityEquality = $00000007;
  CodeBinaryOperatorType_IdentityInequality = $00000006;
  CodeBinaryOperatorType_LessThan = $0000000D;
  CodeBinaryOperatorType_LessThanOrEqual = $0000000E;
  CodeBinaryOperatorType_Modulus = $00000004;
  CodeBinaryOperatorType_Multiply = $00000002;
  CodeBinaryOperatorType_Subtract = $00000001;
  CodeBinaryOperatorType_ValueEquality = $00000008;

// Constants for enum FieldDirection
type
  FieldDirection = TOleEnum;
const
  FieldDirection_In = $00000000;
  FieldDirection_Out = $00000001;
  FieldDirection_Ref = $00000002;

// Constants for enum CodeRegionMode
type
  CodeRegionMode = TOleEnum;
const
  CodeRegionMode_End = $00000002;
  CodeRegionMode_None = $00000000;
  CodeRegionMode_Start = $00000001;

// Constants for enum MemberAttributes
type
  MemberAttributes = TOleEnum;
const
  MemberAttributes_Abstract = $00000001;
  MemberAttributes_AccessMask = $0000F000;
  MemberAttributes_Assembly = $00001000;
  MemberAttributes_Const = $00000005;
  MemberAttributes_Family = $00003000;
  MemberAttributes_FamilyAndAssembly = $00002000;
  MemberAttributes_FamilyOrAssembly = $00004000;
  MemberAttributes_Final = $00000002;
  MemberAttributes_New = $00000010;
  MemberAttributes_Overloaded = $00000100;
  MemberAttributes_Override = $00000004;
  MemberAttributes_Private = $00005000;
  MemberAttributes_Public = $00006000;
  MemberAttributes_ScopeMask = $0000000F;
  MemberAttributes_Static = $00000003;
  MemberAttributes_VTableMask = $000000F0;

// Constants for enum CodeTypeReferenceOptions
type
  CodeTypeReferenceOptions = TOleEnum;
const
  CodeTypeReferenceOptions_GenericTypeParameter = $00000002;
  CodeTypeReferenceOptions_GlobalReference = $00000001;

// Constants for enum DesignerSerializationVisibility
type
  DesignerSerializationVisibility = TOleEnum;
const
  DesignerSerializationVisibility_Content = $00000002;
  DesignerSerializationVisibility_Hidden = $00000000;
  DesignerSerializationVisibility_Visible = $00000001;

// Constants for enum ViewTechnology
type
  ViewTechnology = TOleEnum;
const
  ViewTechnology_Default = $00000002;
  ViewTechnology_Passthrough = $00000000;
  ViewTechnology_WindowsForms = $00000001;

// Constants for enum SelectionTypes
type
  SelectionTypes = TOleEnum;
const
  SelectionTypes_Add = $00000040;
  SelectionTypes_Auto = $00000001;
  SelectionTypes_Click = $00000010;
  SelectionTypes_MouseDown = $00000004;
  SelectionTypes_MouseUp = $00000008;
  SelectionTypes_Normal = $00000001;
  SelectionTypes_Primary = $00000010;
  SelectionTypes_Remove = $00000080;
  SelectionTypes_Replace = $00000002;
  SelectionTypes_Toggle = $00000020;
  SelectionTypes_Valid = $0000001F;

type

// *********************************************************************//
// Forward declaration of types defined in TypeLibrary                    
// *********************************************************************//
  _CodeDomProvider = interface;
  _CodeDomProviderDisp = dispinterface;
  _TypeConverter = interface;
  _TypeConverterDisp = dispinterface;
  _CodeTypeMember = interface;
  _CodeTypeMemberDisp = dispinterface;
  ITypeDescriptorContext = interface;
  ITypeDescriptorContextDisp = dispinterface;
  _CodeArgumentReferenceExpression = interface;
  _CodeArgumentReferenceExpressionDisp = dispinterface;
  _CodeExpression = interface;
  _CodeExpressionDisp = dispinterface;
  _CodeArrayCreateExpression = interface;
  _CodeArrayCreateExpressionDisp = dispinterface;
  _CodeTypeReference = interface;
  _CodeTypeReferenceDisp = dispinterface;
  _CodeExpressionCollection = interface;
  _CodeExpressionCollectionDisp = dispinterface;
  _CodeArrayIndexerExpression = interface;
  _CodeArrayIndexerExpressionDisp = dispinterface;
  _CodeAssignStatement = interface;
  _CodeAssignStatementDisp = dispinterface;
  _CodeStatement = interface;
  _CodeStatementDisp = dispinterface;
  _CodeAttachEventStatement = interface;
  _CodeAttachEventStatementDisp = dispinterface;
  _CodeEventReferenceExpression = interface;
  _CodeEventReferenceExpressionDisp = dispinterface;
  _CodeAttributeArgument = interface;
  _CodeAttributeArgumentDisp = dispinterface;
  _CodeAttributeArgumentCollection = interface;
  _CodeAttributeArgumentCollectionDisp = dispinterface;
  _CodeAttributeDeclaration = interface;
  _CodeAttributeDeclarationDisp = dispinterface;
  _CodeAttributeDeclarationCollection = interface;
  _CodeAttributeDeclarationCollectionDisp = dispinterface;
  _CodeBaseReferenceExpression = interface;
  _CodeBaseReferenceExpressionDisp = dispinterface;
  _CodeBinaryOperatorExpression = interface;
  _CodeBinaryOperatorExpressionDisp = dispinterface;
  _CodeCastExpression = interface;
  _CodeCastExpressionDisp = dispinterface;
  _CodeCatchClause = interface;
  _CodeCatchClauseDisp = dispinterface;
  _CodeStatementCollection = interface;
  _CodeStatementCollectionDisp = dispinterface;
  _CodeCatchClauseCollection = interface;
  _CodeCatchClauseCollectionDisp = dispinterface;
  _CodeChecksumPragma = interface;
  _CodeChecksumPragmaDisp = dispinterface;
  _CodeDirective = interface;
  _CodeDirectiveDisp = dispinterface;
  _CodeComment = interface;
  _CodeCommentDisp = dispinterface;
  _CodeObject = interface;
  _CodeObjectDisp = dispinterface;
  _CodeCommentStatement = interface;
  _CodeCommentStatementDisp = dispinterface;
  _CodeCommentStatementCollection = interface;
  _CodeCommentStatementCollectionDisp = dispinterface;
  _CodeCompileUnit = interface;
  _CodeCompileUnitDisp = dispinterface;
  _CodeNamespaceCollection = interface;
  _CodeNamespaceCollectionDisp = dispinterface;
  _CodeDirectiveCollection = interface;
  _CodeDirectiveCollectionDisp = dispinterface;
  _CodeConditionStatement = interface;
  _CodeConditionStatementDisp = dispinterface;
  _CodeConstructor = interface;
  _CodeConstructorDisp = dispinterface;
  _CodeMemberMethod = interface;
  _CodeMemberMethodDisp = dispinterface;
  _CodeDefaultValueExpression = interface;
  _CodeDefaultValueExpressionDisp = dispinterface;
  _CodeDelegateCreateExpression = interface;
  _CodeDelegateCreateExpressionDisp = dispinterface;
  _CodeDelegateInvokeExpression = interface;
  _CodeDelegateInvokeExpressionDisp = dispinterface;
  _CodeDirectionExpression = interface;
  _CodeDirectionExpressionDisp = dispinterface;
  _CodeEntryPointMethod = interface;
  _CodeEntryPointMethodDisp = dispinterface;
  _CodeExpressionStatement = interface;
  _CodeExpressionStatementDisp = dispinterface;
  _CodeFieldReferenceExpression = interface;
  _CodeFieldReferenceExpressionDisp = dispinterface;
  _CodeGotoStatement = interface;
  _CodeGotoStatementDisp = dispinterface;
  _CodeIndexerExpression = interface;
  _CodeIndexerExpressionDisp = dispinterface;
  _CodeIterationStatement = interface;
  _CodeIterationStatementDisp = dispinterface;
  _CodeLabeledStatement = interface;
  _CodeLabeledStatementDisp = dispinterface;
  _CodeLinePragma = interface;
  _CodeLinePragmaDisp = dispinterface;
  _CodeMemberEvent = interface;
  _CodeMemberEventDisp = dispinterface;
  _CodeTypeReferenceCollection = interface;
  _CodeTypeReferenceCollectionDisp = dispinterface;
  _CodeMemberField = interface;
  _CodeMemberFieldDisp = dispinterface;
  _CodeParameterDeclarationExpressionCollection = interface;
  _CodeParameterDeclarationExpressionCollectionDisp = dispinterface;
  _CodeTypeParameterCollection = interface;
  _CodeTypeParameterCollectionDisp = dispinterface;
  _CodeMemberProperty = interface;
  _CodeMemberPropertyDisp = dispinterface;
  _CodeMethodInvokeExpression = interface;
  _CodeMethodInvokeExpressionDisp = dispinterface;
  _CodeMethodReferenceExpression = interface;
  _CodeMethodReferenceExpressionDisp = dispinterface;
  _CodeMethodReturnStatement = interface;
  _CodeMethodReturnStatementDisp = dispinterface;
  _CodeNamespace = interface;
  _CodeNamespaceDisp = dispinterface;
  _CodeTypeDeclarationCollection = interface;
  _CodeTypeDeclarationCollectionDisp = dispinterface;
  _CodeNamespaceImportCollection = interface;
  _CodeNamespaceImportCollectionDisp = dispinterface;
  _CodeNamespaceImport = interface;
  _CodeNamespaceImportDisp = dispinterface;
  _CodeObjectCreateExpression = interface;
  _CodeObjectCreateExpressionDisp = dispinterface;
  _CodeParameterDeclarationExpression = interface;
  _CodeParameterDeclarationExpressionDisp = dispinterface;
  _CodePrimitiveExpression = interface;
  _CodePrimitiveExpressionDisp = dispinterface;
  _CodePropertyReferenceExpression = interface;
  _CodePropertyReferenceExpressionDisp = dispinterface;
  _CodePropertySetValueReferenceExpression = interface;
  _CodePropertySetValueReferenceExpressionDisp = dispinterface;
  _CodeRegionDirective = interface;
  _CodeRegionDirectiveDisp = dispinterface;
  _CodeRemoveEventStatement = interface;
  _CodeRemoveEventStatementDisp = dispinterface;
  _CodeSnippetCompileUnit = interface;
  _CodeSnippetCompileUnitDisp = dispinterface;
  _CodeSnippetExpression = interface;
  _CodeSnippetExpressionDisp = dispinterface;
  _CodeSnippetStatement = interface;
  _CodeSnippetStatementDisp = dispinterface;
  _CodeSnippetTypeMember = interface;
  _CodeSnippetTypeMemberDisp = dispinterface;
  _CodeThisReferenceExpression = interface;
  _CodeThisReferenceExpressionDisp = dispinterface;
  _CodeThrowExceptionStatement = interface;
  _CodeThrowExceptionStatementDisp = dispinterface;
  _CodeTryCatchFinallyStatement = interface;
  _CodeTryCatchFinallyStatementDisp = dispinterface;
  _CodeTypeConstructor = interface;
  _CodeTypeConstructorDisp = dispinterface;
  _CodeTypeDeclaration = interface;
  _CodeTypeDeclarationDisp = dispinterface;
  _CodeTypeMemberCollection = interface;
  _CodeTypeMemberCollectionDisp = dispinterface;
  _CodeTypeDelegate = interface;
  _CodeTypeDelegateDisp = dispinterface;
  _CodeTypeOfExpression = interface;
  _CodeTypeOfExpressionDisp = dispinterface;
  _CodeTypeParameter = interface;
  _CodeTypeParameterDisp = dispinterface;
  _CodeTypeReferenceExpression = interface;
  _CodeTypeReferenceExpressionDisp = dispinterface;
  _CodeVariableDeclarationStatement = interface;
  _CodeVariableDeclarationStatementDisp = dispinterface;
  _CodeVariableReferenceExpression = interface;
  _CodeVariableReferenceExpressionDisp = dispinterface;
  _Component = interface;
  _ComponentDisp = dispinterface;
  _AttributeCollection = interface;
  _AttributeCollectionDisp = dispinterface;
  _PropertyDescriptor = interface;
  _PropertyDescriptorDisp = dispinterface;
  IComponent = interface;
  IComponentDisp = dispinterface;
  ISite = interface;
  ISiteDisp = dispinterface;
  IContainer = interface;
  IContainerDisp = dispinterface;
  _ComponentCollection = interface;
  _ComponentCollectionDisp = dispinterface;
  _EventDescriptor = interface;
  _EventDescriptorDisp = dispinterface;
  _EventDescriptorCollection = interface;
  _EventDescriptorCollectionDisp = dispinterface;
  _MemberDescriptor = interface;
  _MemberDescriptorDisp = dispinterface;
  _MarshalByValueComponent = interface;
  _MarshalByValueComponentDisp = dispinterface;
  IDesigner = interface;
  IDesignerDisp = dispinterface;
  IDesignerHost = interface;
  IDesignerHostDisp = dispinterface;
  _CommandID = interface;
  _CommandIDDisp = dispinterface;
  _ComponentChangedEventArgs = interface;
  _ComponentChangedEventArgsDisp = dispinterface;
  _ComponentChangedEventHandler = interface;
  _ComponentChangedEventHandlerDisp = dispinterface;
  _ComponentChangingEventArgs = interface;
  _ComponentChangingEventArgsDisp = dispinterface;
  _ComponentChangingEventHandler = interface;
  _ComponentChangingEventHandlerDisp = dispinterface;
  _ComponentEventArgs = interface;
  _ComponentEventArgsDisp = dispinterface;
  _ComponentEventHandler = interface;
  _ComponentEventHandlerDisp = dispinterface;
  _ComponentRenameEventArgs = interface;
  _ComponentRenameEventArgsDisp = dispinterface;
  _ComponentRenameEventHandler = interface;
  _ComponentRenameEventHandlerDisp = dispinterface;
  _DesignerTransactionCloseEventArgs = interface;
  _DesignerTransactionCloseEventArgsDisp = dispinterface;
  _DesignerTransactionCloseEventHandler = interface;
  _DesignerTransactionCloseEventHandlerDisp = dispinterface;
  _DesignerVerb = interface;
  _DesignerVerbDisp = dispinterface;
  _MenuCommand = interface;
  _MenuCommandDisp = dispinterface;
  _DesignerVerbCollection = interface;
  _DesignerVerbCollectionDisp = dispinterface;
  IComponentChangeService = interface;
  IComponentChangeServiceDisp = dispinterface;
  IServiceContainer = interface;
  IServiceContainerDisp = dispinterface;
  IEventBindingService = interface;
  IEventBindingServiceDisp = dispinterface;
  IMenuCommandService = interface;
  IMenuCommandServiceDisp = dispinterface;
  IRootDesigner = interface;
  IRootDesignerDisp = dispinterface;
  ISelectionService = interface;
  ISelectionServiceDisp = dispinterface;
  _ServiceCreatorCallback = interface;
  _ServiceCreatorCallbackDisp = dispinterface;
  _DesignerLoader = interface;
  _DesignerLoaderDisp = dispinterface;
  _PerformanceCounterManager = interface;
  _PerformanceCounterManagerDisp = dispinterface;
  _WebHeaderCollection = interface;
  _WebHeaderCollectionDisp = dispinterface;
  _WebClient = interface;
  _WebClientDisp = dispinterface;
  _StandardOleMarshalObject = interface;
  _StandardOleMarshalObjectDisp = dispinterface;

// *********************************************************************//
// Declaration of CoClasses defined in Type Library                       
// (NOTE: Here we map each CoClass to its Default Interface)              
// *********************************************************************//
  CodeDomProvider = _CodeDomProvider;
  TypeConverter = _TypeConverter;
  CodeTypeMember = _CodeTypeMember;
  CodeArgumentReferenceExpression = _CodeArgumentReferenceExpression;
  CodeExpression = _CodeExpression;
  CodeArrayCreateExpression = _CodeArrayCreateExpression;
  CodeTypeReference = _CodeTypeReference;
  CodeExpressionCollection = _CodeExpressionCollection;
  CodeArrayIndexerExpression = _CodeArrayIndexerExpression;
  CodeAssignStatement = _CodeAssignStatement;
  CodeStatement = _CodeStatement;
  CodeAttachEventStatement = _CodeAttachEventStatement;
  CodeEventReferenceExpression = _CodeEventReferenceExpression;
  CodeAttributeArgument = _CodeAttributeArgument;
  CodeAttributeArgumentCollection = _CodeAttributeArgumentCollection;
  CodeAttributeDeclaration = _CodeAttributeDeclaration;
  CodeAttributeDeclarationCollection = _CodeAttributeDeclarationCollection;
  CodeBaseReferenceExpression = _CodeBaseReferenceExpression;
  CodeBinaryOperatorExpression = _CodeBinaryOperatorExpression;
  CodeCastExpression = _CodeCastExpression;
  CodeCatchClause = _CodeCatchClause;
  CodeStatementCollection = _CodeStatementCollection;
  CodeCatchClauseCollection = _CodeCatchClauseCollection;
  CodeChecksumPragma = _CodeChecksumPragma;
  CodeDirective = _CodeDirective;
  CodeComment = _CodeComment;
  CodeObject = _CodeObject;
  CodeCommentStatement = _CodeCommentStatement;
  CodeCommentStatementCollection = _CodeCommentStatementCollection;
  CodeCompileUnit = _CodeCompileUnit;
  CodeNamespaceCollection = _CodeNamespaceCollection;
  CodeDirectiveCollection = _CodeDirectiveCollection;
  CodeConditionStatement = _CodeConditionStatement;
  CodeConstructor = _CodeConstructor;
  CodeMemberMethod = _CodeMemberMethod;
  CodeDefaultValueExpression = _CodeDefaultValueExpression;
  CodeDelegateCreateExpression = _CodeDelegateCreateExpression;
  CodeDelegateInvokeExpression = _CodeDelegateInvokeExpression;
  CodeDirectionExpression = _CodeDirectionExpression;
  CodeEntryPointMethod = _CodeEntryPointMethod;
  CodeExpressionStatement = _CodeExpressionStatement;
  CodeFieldReferenceExpression = _CodeFieldReferenceExpression;
  CodeGotoStatement = _CodeGotoStatement;
  CodeIndexerExpression = _CodeIndexerExpression;
  CodeIterationStatement = _CodeIterationStatement;
  CodeLabeledStatement = _CodeLabeledStatement;
  CodeLinePragma = _CodeLinePragma;
  CodeMemberEvent = _CodeMemberEvent;
  CodeTypeReferenceCollection = _CodeTypeReferenceCollection;
  CodeMemberField = _CodeMemberField;
  CodeParameterDeclarationExpressionCollection = _CodeParameterDeclarationExpressionCollection;
  CodeTypeParameterCollection = _CodeTypeParameterCollection;
  CodeMemberProperty = _CodeMemberProperty;
  CodeMethodInvokeExpression = _CodeMethodInvokeExpression;
  CodeMethodReferenceExpression = _CodeMethodReferenceExpression;
  CodeMethodReturnStatement = _CodeMethodReturnStatement;
  CodeNamespace = _CodeNamespace;
  CodeTypeDeclarationCollection = _CodeTypeDeclarationCollection;
  CodeNamespaceImportCollection = _CodeNamespaceImportCollection;
  CodeNamespaceImport = _CodeNamespaceImport;
  CodeObjectCreateExpression = _CodeObjectCreateExpression;
  CodeParameterDeclarationExpression = _CodeParameterDeclarationExpression;
  CodePrimitiveExpression = _CodePrimitiveExpression;
  CodePropertyReferenceExpression = _CodePropertyReferenceExpression;
  CodePropertySetValueReferenceExpression = _CodePropertySetValueReferenceExpression;
  CodeRegionDirective = _CodeRegionDirective;
  CodeRemoveEventStatement = _CodeRemoveEventStatement;
  CodeSnippetCompileUnit = _CodeSnippetCompileUnit;
  CodeSnippetExpression = _CodeSnippetExpression;
  CodeSnippetStatement = _CodeSnippetStatement;
  CodeSnippetTypeMember = _CodeSnippetTypeMember;
  CodeThisReferenceExpression = _CodeThisReferenceExpression;
  CodeThrowExceptionStatement = _CodeThrowExceptionStatement;
  CodeTryCatchFinallyStatement = _CodeTryCatchFinallyStatement;
  CodeTypeConstructor = _CodeTypeConstructor;
  CodeTypeDeclaration = _CodeTypeDeclaration;
  CodeTypeMemberCollection = _CodeTypeMemberCollection;
  CodeTypeDelegate = _CodeTypeDelegate;
  CodeTypeOfExpression = _CodeTypeOfExpression;
  CodeTypeParameter = _CodeTypeParameter;
  CodeTypeReferenceExpression = _CodeTypeReferenceExpression;
  CodeVariableDeclarationStatement = _CodeVariableDeclarationStatement;
  CodeVariableReferenceExpression = _CodeVariableReferenceExpression;
  component = _Component;
  AttributeCollection = _AttributeCollection;
  PropertyDescriptor = _PropertyDescriptor;
  ComponentCollection = _ComponentCollection;
  EventDescriptor = _EventDescriptor;
  EventDescriptorCollection = _EventDescriptorCollection;
  MemberDescriptor = _MemberDescriptor;
  MarshalByValueComponent = _MarshalByValueComponent;
  CommandID = _CommandID;
  ComponentChangedEventArgs = _ComponentChangedEventArgs;
  ComponentChangedEventHandler = _ComponentChangedEventHandler;
  ComponentChangingEventArgs = _ComponentChangingEventArgs;
  ComponentChangingEventHandler = _ComponentChangingEventHandler;
  ComponentEventArgs = _ComponentEventArgs;
  ComponentEventHandler = _ComponentEventHandler;
  ComponentRenameEventArgs = _ComponentRenameEventArgs;
  ComponentRenameEventHandler = _ComponentRenameEventHandler;
  DesignerTransactionCloseEventArgs = _DesignerTransactionCloseEventArgs;
  DesignerTransactionCloseEventHandler = _DesignerTransactionCloseEventHandler;
  DesignerVerb = _DesignerVerb;
  MenuCommand = _MenuCommand;
  DesignerVerbCollection = _DesignerVerbCollection;
  ServiceCreatorCallback = _ServiceCreatorCallback;
  DesignerLoader = _DesignerLoader;
  PerformanceCounterManager = _PerformanceCounterManager;
  WebHeaderCollection = _WebHeaderCollection;
  WebClient = _WebClient;
  StandardOleMarshalObject = _StandardOleMarshalObject;


// *********************************************************************//
// Interface: _CodeDomProvider
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {61059E8D-1DD2-3F4B-A4C5-D566B8968FFB}
// *********************************************************************//
  _CodeDomProvider = interface(IDispatch)
    ['{61059E8D-1DD2-3F4B-A4C5-D566B8968FFB}']
  end;

// *********************************************************************//
// DispIntf:  _CodeDomProviderDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {61059E8D-1DD2-3F4B-A4C5-D566B8968FFB}
// *********************************************************************//
  _CodeDomProviderDisp = dispinterface
    ['{61059E8D-1DD2-3F4B-A4C5-D566B8968FFB}']
  end;

// *********************************************************************//
// Interface: _TypeConverter
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {05241989-96C5-3BF9-AB9B-37E261C1B8F8}
// *********************************************************************//
  _TypeConverter = interface(IDispatch)
    ['{05241989-96C5-3BF9-AB9B-37E261C1B8F8}']
  end;

// *********************************************************************//
// DispIntf:  _TypeConverterDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {05241989-96C5-3BF9-AB9B-37E261C1B8F8}
// *********************************************************************//
  _TypeConverterDisp = dispinterface
    ['{05241989-96C5-3BF9-AB9B-37E261C1B8F8}']
  end;

// *********************************************************************//
// Interface: _CodeTypeMember
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {8068AE1D-26CB-3DB6-97CD-ED83DE116C5A}
// *********************************************************************//
  _CodeTypeMember = interface(IDispatch)
    ['{8068AE1D-26CB-3DB6-97CD-ED83DE116C5A}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeMemberDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {8068AE1D-26CB-3DB6-97CD-ED83DE116C5A}
// *********************************************************************//
  _CodeTypeMemberDisp = dispinterface
    ['{8068AE1D-26CB-3DB6-97CD-ED83DE116C5A}']
  end;

// *********************************************************************//
// Interface: ITypeDescriptorContext
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {5CBAE170-8759-3B8A-B919-E12FB86AD1F3}
// *********************************************************************//
  ITypeDescriptorContext = interface(IDispatch)
    ['{5CBAE170-8759-3B8A-B919-E12FB86AD1F3}']
    function Get_Container: IContainer; safecall;
    function Get_Instance: OleVariant; safecall;
    function Get_PropertyDescriptor: _PropertyDescriptor; safecall;
    function OnComponentChanging: WordBool; safecall;
    procedure OnComponentChanged; safecall;
    property Container: IContainer read Get_Container;
    property Instance: OleVariant read Get_Instance;
    property PropertyDescriptor: _PropertyDescriptor read Get_PropertyDescriptor;
  end;

// *********************************************************************//
// DispIntf:  ITypeDescriptorContextDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {5CBAE170-8759-3B8A-B919-E12FB86AD1F3}
// *********************************************************************//
  ITypeDescriptorContextDisp = dispinterface
    ['{5CBAE170-8759-3B8A-B919-E12FB86AD1F3}']
    property Container: IContainer readonly dispid 1610743808;
    property Instance: OleVariant readonly dispid 1610743809;
    property PropertyDescriptor: _PropertyDescriptor readonly dispid 1610743810;
    function OnComponentChanging: WordBool; dispid 1610743811;
    procedure OnComponentChanged; dispid 1610743812;
  end;

// *********************************************************************//
// Interface: _CodeArgumentReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {A52B85C6-5370-35C9-A04A-04A92013862C}
// *********************************************************************//
  _CodeArgumentReferenceExpression = interface(IDispatch)
    ['{A52B85C6-5370-35C9-A04A-04A92013862C}']
  end;

// *********************************************************************//
// DispIntf:  _CodeArgumentReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {A52B85C6-5370-35C9-A04A-04A92013862C}
// *********************************************************************//
  _CodeArgumentReferenceExpressionDisp = dispinterface
    ['{A52B85C6-5370-35C9-A04A-04A92013862C}']
  end;

// *********************************************************************//
// Interface: _CodeExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {AD377794-864F-3421-9FB8-C684BBC1BC02}
// *********************************************************************//
  _CodeExpression = interface(IDispatch)
    ['{AD377794-864F-3421-9FB8-C684BBC1BC02}']
  end;

// *********************************************************************//
// DispIntf:  _CodeExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {AD377794-864F-3421-9FB8-C684BBC1BC02}
// *********************************************************************//
  _CodeExpressionDisp = dispinterface
    ['{AD377794-864F-3421-9FB8-C684BBC1BC02}']
  end;

// *********************************************************************//
// Interface: _CodeArrayCreateExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F7955E55-7F3B-3277-AA0C-F62AA615676D}
// *********************************************************************//
  _CodeArrayCreateExpression = interface(IDispatch)
    ['{F7955E55-7F3B-3277-AA0C-F62AA615676D}']
  end;

// *********************************************************************//
// DispIntf:  _CodeArrayCreateExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F7955E55-7F3B-3277-AA0C-F62AA615676D}
// *********************************************************************//
  _CodeArrayCreateExpressionDisp = dispinterface
    ['{F7955E55-7F3B-3277-AA0C-F62AA615676D}']
  end;

// *********************************************************************//
// Interface: _CodeTypeReference
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B6D972C6-022B-3F91-9655-E288E9D32C55}
// *********************************************************************//
  _CodeTypeReference = interface(IDispatch)
    ['{B6D972C6-022B-3F91-9655-E288E9D32C55}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeReferenceDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B6D972C6-022B-3F91-9655-E288E9D32C55}
// *********************************************************************//
  _CodeTypeReferenceDisp = dispinterface
    ['{B6D972C6-022B-3F91-9655-E288E9D32C55}']
  end;

// *********************************************************************//
// Interface: _CodeExpressionCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {AF72CC74-2275-362A-9141-A4A79D596F39}
// *********************************************************************//
  _CodeExpressionCollection = interface(IDispatch)
    ['{AF72CC74-2275-362A-9141-A4A79D596F39}']
  end;

// *********************************************************************//
// DispIntf:  _CodeExpressionCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {AF72CC74-2275-362A-9141-A4A79D596F39}
// *********************************************************************//
  _CodeExpressionCollectionDisp = dispinterface
    ['{AF72CC74-2275-362A-9141-A4A79D596F39}']
  end;

// *********************************************************************//
// Interface: _CodeArrayIndexerExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {732748F5-5256-327B-A7E5-2000B07F21B3}
// *********************************************************************//
  _CodeArrayIndexerExpression = interface(IDispatch)
    ['{732748F5-5256-327B-A7E5-2000B07F21B3}']
  end;

// *********************************************************************//
// DispIntf:  _CodeArrayIndexerExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {732748F5-5256-327B-A7E5-2000B07F21B3}
// *********************************************************************//
  _CodeArrayIndexerExpressionDisp = dispinterface
    ['{732748F5-5256-327B-A7E5-2000B07F21B3}']
  end;

// *********************************************************************//
// Interface: _CodeAssignStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {E2024DE0-DC21-305D-8761-6C31F2177FB0}
// *********************************************************************//
  _CodeAssignStatement = interface(IDispatch)
    ['{E2024DE0-DC21-305D-8761-6C31F2177FB0}']
  end;

// *********************************************************************//
// DispIntf:  _CodeAssignStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {E2024DE0-DC21-305D-8761-6C31F2177FB0}
// *********************************************************************//
  _CodeAssignStatementDisp = dispinterface
    ['{E2024DE0-DC21-305D-8761-6C31F2177FB0}']
  end;

// *********************************************************************//
// Interface: _CodeStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B125774D-EF66-382B-878D-2D916999B0D2}
// *********************************************************************//
  _CodeStatement = interface(IDispatch)
    ['{B125774D-EF66-382B-878D-2D916999B0D2}']
  end;

// *********************************************************************//
// DispIntf:  _CodeStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B125774D-EF66-382B-878D-2D916999B0D2}
// *********************************************************************//
  _CodeStatementDisp = dispinterface
    ['{B125774D-EF66-382B-878D-2D916999B0D2}']
  end;

// *********************************************************************//
// Interface: _CodeAttachEventStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F7BC47E9-706C-3AA7-B1BA-8AB95188FA11}
// *********************************************************************//
  _CodeAttachEventStatement = interface(IDispatch)
    ['{F7BC47E9-706C-3AA7-B1BA-8AB95188FA11}']
  end;

// *********************************************************************//
// DispIntf:  _CodeAttachEventStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F7BC47E9-706C-3AA7-B1BA-8AB95188FA11}
// *********************************************************************//
  _CodeAttachEventStatementDisp = dispinterface
    ['{F7BC47E9-706C-3AA7-B1BA-8AB95188FA11}']
  end;

// *********************************************************************//
// Interface: _CodeEventReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {35872687-5A11-34D7-85AB-865830A3BDEE}
// *********************************************************************//
  _CodeEventReferenceExpression = interface(IDispatch)
    ['{35872687-5A11-34D7-85AB-865830A3BDEE}']
  end;

// *********************************************************************//
// DispIntf:  _CodeEventReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {35872687-5A11-34D7-85AB-865830A3BDEE}
// *********************************************************************//
  _CodeEventReferenceExpressionDisp = dispinterface
    ['{35872687-5A11-34D7-85AB-865830A3BDEE}']
  end;

// *********************************************************************//
// Interface: _CodeAttributeArgument
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {02EFD952-FF8C-3B72-8C33-739A506D53D9}
// *********************************************************************//
  _CodeAttributeArgument = interface(IDispatch)
    ['{02EFD952-FF8C-3B72-8C33-739A506D53D9}']
  end;

// *********************************************************************//
// DispIntf:  _CodeAttributeArgumentDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {02EFD952-FF8C-3B72-8C33-739A506D53D9}
// *********************************************************************//
  _CodeAttributeArgumentDisp = dispinterface
    ['{02EFD952-FF8C-3B72-8C33-739A506D53D9}']
  end;

// *********************************************************************//
// Interface: _CodeAttributeArgumentCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FE84E484-A7EC-3D15-B5E2-EDC2DE2DB42E}
// *********************************************************************//
  _CodeAttributeArgumentCollection = interface(IDispatch)
    ['{FE84E484-A7EC-3D15-B5E2-EDC2DE2DB42E}']
  end;

// *********************************************************************//
// DispIntf:  _CodeAttributeArgumentCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FE84E484-A7EC-3D15-B5E2-EDC2DE2DB42E}
// *********************************************************************//
  _CodeAttributeArgumentCollectionDisp = dispinterface
    ['{FE84E484-A7EC-3D15-B5E2-EDC2DE2DB42E}']
  end;

// *********************************************************************//
// Interface: _CodeAttributeDeclaration
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EF72D021-2C6D-3E33-9442-574BFD6E0871}
// *********************************************************************//
  _CodeAttributeDeclaration = interface(IDispatch)
    ['{EF72D021-2C6D-3E33-9442-574BFD6E0871}']
  end;

// *********************************************************************//
// DispIntf:  _CodeAttributeDeclarationDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EF72D021-2C6D-3E33-9442-574BFD6E0871}
// *********************************************************************//
  _CodeAttributeDeclarationDisp = dispinterface
    ['{EF72D021-2C6D-3E33-9442-574BFD6E0871}']
  end;

// *********************************************************************//
// Interface: _CodeAttributeDeclarationCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7E9ACA22-637C-3F88-A931-AAF36A4F9A6B}
// *********************************************************************//
  _CodeAttributeDeclarationCollection = interface(IDispatch)
    ['{7E9ACA22-637C-3F88-A931-AAF36A4F9A6B}']
  end;

// *********************************************************************//
// DispIntf:  _CodeAttributeDeclarationCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7E9ACA22-637C-3F88-A931-AAF36A4F9A6B}
// *********************************************************************//
  _CodeAttributeDeclarationCollectionDisp = dispinterface
    ['{7E9ACA22-637C-3F88-A931-AAF36A4F9A6B}']
  end;

// *********************************************************************//
// Interface: _CodeBaseReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {45E29CA6-670A-3B13-9557-4E5903056BF3}
// *********************************************************************//
  _CodeBaseReferenceExpression = interface(IDispatch)
    ['{45E29CA6-670A-3B13-9557-4E5903056BF3}']
  end;

// *********************************************************************//
// DispIntf:  _CodeBaseReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {45E29CA6-670A-3B13-9557-4E5903056BF3}
// *********************************************************************//
  _CodeBaseReferenceExpressionDisp = dispinterface
    ['{45E29CA6-670A-3B13-9557-4E5903056BF3}']
  end;

// *********************************************************************//
// Interface: _CodeBinaryOperatorExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {A22929C9-D301-3F5B-98B7-844FDBA1DEDF}
// *********************************************************************//
  _CodeBinaryOperatorExpression = interface(IDispatch)
    ['{A22929C9-D301-3F5B-98B7-844FDBA1DEDF}']
  end;

// *********************************************************************//
// DispIntf:  _CodeBinaryOperatorExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {A22929C9-D301-3F5B-98B7-844FDBA1DEDF}
// *********************************************************************//
  _CodeBinaryOperatorExpressionDisp = dispinterface
    ['{A22929C9-D301-3F5B-98B7-844FDBA1DEDF}']
  end;

// *********************************************************************//
// Interface: _CodeCastExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {90BED8ED-21E3-31FE-8F02-C929BA4FB0AC}
// *********************************************************************//
  _CodeCastExpression = interface(IDispatch)
    ['{90BED8ED-21E3-31FE-8F02-C929BA4FB0AC}']
  end;

// *********************************************************************//
// DispIntf:  _CodeCastExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {90BED8ED-21E3-31FE-8F02-C929BA4FB0AC}
// *********************************************************************//
  _CodeCastExpressionDisp = dispinterface
    ['{90BED8ED-21E3-31FE-8F02-C929BA4FB0AC}']
  end;

// *********************************************************************//
// Interface: _CodeCatchClause
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {609C7788-BDB0-364C-92E3-FC16AC613430}
// *********************************************************************//
  _CodeCatchClause = interface(IDispatch)
    ['{609C7788-BDB0-364C-92E3-FC16AC613430}']
  end;

// *********************************************************************//
// DispIntf:  _CodeCatchClauseDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {609C7788-BDB0-364C-92E3-FC16AC613430}
// *********************************************************************//
  _CodeCatchClauseDisp = dispinterface
    ['{609C7788-BDB0-364C-92E3-FC16AC613430}']
  end;

// *********************************************************************//
// Interface: _CodeStatementCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4B9A5032-4B8C-3DE6-997C-C38B4B3AF26A}
// *********************************************************************//
  _CodeStatementCollection = interface(IDispatch)
    ['{4B9A5032-4B8C-3DE6-997C-C38B4B3AF26A}']
  end;

// *********************************************************************//
// DispIntf:  _CodeStatementCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4B9A5032-4B8C-3DE6-997C-C38B4B3AF26A}
// *********************************************************************//
  _CodeStatementCollectionDisp = dispinterface
    ['{4B9A5032-4B8C-3DE6-997C-C38B4B3AF26A}']
  end;

// *********************************************************************//
// Interface: _CodeCatchClauseCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FF5E1CD9-0478-34A4-9B9C-7C80BCB1A725}
// *********************************************************************//
  _CodeCatchClauseCollection = interface(IDispatch)
    ['{FF5E1CD9-0478-34A4-9B9C-7C80BCB1A725}']
  end;

// *********************************************************************//
// DispIntf:  _CodeCatchClauseCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FF5E1CD9-0478-34A4-9B9C-7C80BCB1A725}
// *********************************************************************//
  _CodeCatchClauseCollectionDisp = dispinterface
    ['{FF5E1CD9-0478-34A4-9B9C-7C80BCB1A725}']
  end;

// *********************************************************************//
// Interface: _CodeChecksumPragma
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7EB20114-E822-358C-BDAB-DCF9E5090F23}
// *********************************************************************//
  _CodeChecksumPragma = interface(IDispatch)
    ['{7EB20114-E822-358C-BDAB-DCF9E5090F23}']
  end;

// *********************************************************************//
// DispIntf:  _CodeChecksumPragmaDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7EB20114-E822-358C-BDAB-DCF9E5090F23}
// *********************************************************************//
  _CodeChecksumPragmaDisp = dispinterface
    ['{7EB20114-E822-358C-BDAB-DCF9E5090F23}']
  end;

// *********************************************************************//
// Interface: _CodeDirective
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {767E752E-2315-35CF-9652-7FC46AE870D3}
// *********************************************************************//
  _CodeDirective = interface(IDispatch)
    ['{767E752E-2315-35CF-9652-7FC46AE870D3}']
  end;

// *********************************************************************//
// DispIntf:  _CodeDirectiveDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {767E752E-2315-35CF-9652-7FC46AE870D3}
// *********************************************************************//
  _CodeDirectiveDisp = dispinterface
    ['{767E752E-2315-35CF-9652-7FC46AE870D3}']
  end;

// *********************************************************************//
// Interface: _CodeComment
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {C94F39B3-436F-3711-9CB0-91C6299B62A2}
// *********************************************************************//
  _CodeComment = interface(IDispatch)
    ['{C94F39B3-436F-3711-9CB0-91C6299B62A2}']
  end;

// *********************************************************************//
// DispIntf:  _CodeCommentDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {C94F39B3-436F-3711-9CB0-91C6299B62A2}
// *********************************************************************//
  _CodeCommentDisp = dispinterface
    ['{C94F39B3-436F-3711-9CB0-91C6299B62A2}']
  end;

// *********************************************************************//
// Interface: _CodeObject
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EE499EFD-22E2-3740-A64A-2AB010099C01}
// *********************************************************************//
  _CodeObject = interface(IDispatch)
    ['{EE499EFD-22E2-3740-A64A-2AB010099C01}']
  end;

// *********************************************************************//
// DispIntf:  _CodeObjectDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EE499EFD-22E2-3740-A64A-2AB010099C01}
// *********************************************************************//
  _CodeObjectDisp = dispinterface
    ['{EE499EFD-22E2-3740-A64A-2AB010099C01}']
  end;

// *********************************************************************//
// Interface: _CodeCommentStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {0C13F8B9-F2E0-3918-A33E-3E491BDC529E}
// *********************************************************************//
  _CodeCommentStatement = interface(IDispatch)
    ['{0C13F8B9-F2E0-3918-A33E-3E491BDC529E}']
  end;

// *********************************************************************//
// DispIntf:  _CodeCommentStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {0C13F8B9-F2E0-3918-A33E-3E491BDC529E}
// *********************************************************************//
  _CodeCommentStatementDisp = dispinterface
    ['{0C13F8B9-F2E0-3918-A33E-3E491BDC529E}']
  end;

// *********************************************************************//
// Interface: _CodeCommentStatementCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {E34CEB72-8F86-333D-AEDA-069221DF6A1A}
// *********************************************************************//
  _CodeCommentStatementCollection = interface(IDispatch)
    ['{E34CEB72-8F86-333D-AEDA-069221DF6A1A}']
  end;

// *********************************************************************//
// DispIntf:  _CodeCommentStatementCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {E34CEB72-8F86-333D-AEDA-069221DF6A1A}
// *********************************************************************//
  _CodeCommentStatementCollectionDisp = dispinterface
    ['{E34CEB72-8F86-333D-AEDA-069221DF6A1A}']
  end;

// *********************************************************************//
// Interface: _CodeCompileUnit
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {6F20C263-AF67-380F-A482-9A21F7599748}
// *********************************************************************//
  _CodeCompileUnit = interface(IDispatch)
    ['{6F20C263-AF67-380F-A482-9A21F7599748}']
  end;

// *********************************************************************//
// DispIntf:  _CodeCompileUnitDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {6F20C263-AF67-380F-A482-9A21F7599748}
// *********************************************************************//
  _CodeCompileUnitDisp = dispinterface
    ['{6F20C263-AF67-380F-A482-9A21F7599748}']
  end;

// *********************************************************************//
// Interface: _CodeNamespaceCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F5E54F16-ADE3-3B5D-8B05-1F9803557905}
// *********************************************************************//
  _CodeNamespaceCollection = interface(IDispatch)
    ['{F5E54F16-ADE3-3B5D-8B05-1F9803557905}']
  end;

// *********************************************************************//
// DispIntf:  _CodeNamespaceCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F5E54F16-ADE3-3B5D-8B05-1F9803557905}
// *********************************************************************//
  _CodeNamespaceCollectionDisp = dispinterface
    ['{F5E54F16-ADE3-3B5D-8B05-1F9803557905}']
  end;

// *********************************************************************//
// Interface: _CodeDirectiveCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EEFBDD27-4904-3E90-ACFC-624164CB45DD}
// *********************************************************************//
  _CodeDirectiveCollection = interface(IDispatch)
    ['{EEFBDD27-4904-3E90-ACFC-624164CB45DD}']
  end;

// *********************************************************************//
// DispIntf:  _CodeDirectiveCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EEFBDD27-4904-3E90-ACFC-624164CB45DD}
// *********************************************************************//
  _CodeDirectiveCollectionDisp = dispinterface
    ['{EEFBDD27-4904-3E90-ACFC-624164CB45DD}']
  end;

// *********************************************************************//
// Interface: _CodeConditionStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {69904B31-5FB5-39BF-83B0-5DDFA1F26D71}
// *********************************************************************//
  _CodeConditionStatement = interface(IDispatch)
    ['{69904B31-5FB5-39BF-83B0-5DDFA1F26D71}']
  end;

// *********************************************************************//
// DispIntf:  _CodeConditionStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {69904B31-5FB5-39BF-83B0-5DDFA1F26D71}
// *********************************************************************//
  _CodeConditionStatementDisp = dispinterface
    ['{69904B31-5FB5-39BF-83B0-5DDFA1F26D71}']
  end;

// *********************************************************************//
// Interface: _CodeConstructor
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {5A33C771-806E-337D-AE1F-66B523FC49BF}
// *********************************************************************//
  _CodeConstructor = interface(IDispatch)
    ['{5A33C771-806E-337D-AE1F-66B523FC49BF}']
  end;

// *********************************************************************//
// DispIntf:  _CodeConstructorDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {5A33C771-806E-337D-AE1F-66B523FC49BF}
// *********************************************************************//
  _CodeConstructorDisp = dispinterface
    ['{5A33C771-806E-337D-AE1F-66B523FC49BF}']
  end;

// *********************************************************************//
// Interface: _CodeMemberMethod
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {95C2EE26-4247-3DDC-8056-97353F10DE8F}
// *********************************************************************//
  _CodeMemberMethod = interface(IDispatch)
    ['{95C2EE26-4247-3DDC-8056-97353F10DE8F}']
  end;

// *********************************************************************//
// DispIntf:  _CodeMemberMethodDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {95C2EE26-4247-3DDC-8056-97353F10DE8F}
// *********************************************************************//
  _CodeMemberMethodDisp = dispinterface
    ['{95C2EE26-4247-3DDC-8056-97353F10DE8F}']
  end;

// *********************************************************************//
// Interface: _CodeDefaultValueExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EA9E1DD2-EF9A-3570-AE1A-2F625F594C3B}
// *********************************************************************//
  _CodeDefaultValueExpression = interface(IDispatch)
    ['{EA9E1DD2-EF9A-3570-AE1A-2F625F594C3B}']
  end;

// *********************************************************************//
// DispIntf:  _CodeDefaultValueExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EA9E1DD2-EF9A-3570-AE1A-2F625F594C3B}
// *********************************************************************//
  _CodeDefaultValueExpressionDisp = dispinterface
    ['{EA9E1DD2-EF9A-3570-AE1A-2F625F594C3B}']
  end;

// *********************************************************************//
// Interface: _CodeDelegateCreateExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {D14E12C1-E1D1-3B74-A3AF-021A5A268FBE}
// *********************************************************************//
  _CodeDelegateCreateExpression = interface(IDispatch)
    ['{D14E12C1-E1D1-3B74-A3AF-021A5A268FBE}']
  end;

// *********************************************************************//
// DispIntf:  _CodeDelegateCreateExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {D14E12C1-E1D1-3B74-A3AF-021A5A268FBE}
// *********************************************************************//
  _CodeDelegateCreateExpressionDisp = dispinterface
    ['{D14E12C1-E1D1-3B74-A3AF-021A5A268FBE}']
  end;

// *********************************************************************//
// Interface: _CodeDelegateInvokeExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {6F6C3482-8900-36EA-B621-943534E82C73}
// *********************************************************************//
  _CodeDelegateInvokeExpression = interface(IDispatch)
    ['{6F6C3482-8900-36EA-B621-943534E82C73}']
  end;

// *********************************************************************//
// DispIntf:  _CodeDelegateInvokeExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {6F6C3482-8900-36EA-B621-943534E82C73}
// *********************************************************************//
  _CodeDelegateInvokeExpressionDisp = dispinterface
    ['{6F6C3482-8900-36EA-B621-943534E82C73}']
  end;

// *********************************************************************//
// Interface: _CodeDirectionExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {11EDAF3B-144E-32C8-8BE0-81D40A950656}
// *********************************************************************//
  _CodeDirectionExpression = interface(IDispatch)
    ['{11EDAF3B-144E-32C8-8BE0-81D40A950656}']
  end;

// *********************************************************************//
// DispIntf:  _CodeDirectionExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {11EDAF3B-144E-32C8-8BE0-81D40A950656}
// *********************************************************************//
  _CodeDirectionExpressionDisp = dispinterface
    ['{11EDAF3B-144E-32C8-8BE0-81D40A950656}']
  end;

// *********************************************************************//
// Interface: _CodeEntryPointMethod
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7CD4EF19-27EB-399E-8ED2-C6647A99C03E}
// *********************************************************************//
  _CodeEntryPointMethod = interface(IDispatch)
    ['{7CD4EF19-27EB-399E-8ED2-C6647A99C03E}']
  end;

// *********************************************************************//
// DispIntf:  _CodeEntryPointMethodDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7CD4EF19-27EB-399E-8ED2-C6647A99C03E}
// *********************************************************************//
  _CodeEntryPointMethodDisp = dispinterface
    ['{7CD4EF19-27EB-399E-8ED2-C6647A99C03E}']
  end;

// *********************************************************************//
// Interface: _CodeExpressionStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {CEA240AF-60C5-3C69-9DA1-DA3F9A6D7B3C}
// *********************************************************************//
  _CodeExpressionStatement = interface(IDispatch)
    ['{CEA240AF-60C5-3C69-9DA1-DA3F9A6D7B3C}']
  end;

// *********************************************************************//
// DispIntf:  _CodeExpressionStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {CEA240AF-60C5-3C69-9DA1-DA3F9A6D7B3C}
// *********************************************************************//
  _CodeExpressionStatementDisp = dispinterface
    ['{CEA240AF-60C5-3C69-9DA1-DA3F9A6D7B3C}']
  end;

// *********************************************************************//
// Interface: _CodeFieldReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {82D57B2B-C639-32A0-89B4-62A0C29DD64E}
// *********************************************************************//
  _CodeFieldReferenceExpression = interface(IDispatch)
    ['{82D57B2B-C639-32A0-89B4-62A0C29DD64E}']
  end;

// *********************************************************************//
// DispIntf:  _CodeFieldReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {82D57B2B-C639-32A0-89B4-62A0C29DD64E}
// *********************************************************************//
  _CodeFieldReferenceExpressionDisp = dispinterface
    ['{82D57B2B-C639-32A0-89B4-62A0C29DD64E}']
  end;

// *********************************************************************//
// Interface: _CodeGotoStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {8F1BAED9-52EC-3545-9CF0-6ED71A76A5CA}
// *********************************************************************//
  _CodeGotoStatement = interface(IDispatch)
    ['{8F1BAED9-52EC-3545-9CF0-6ED71A76A5CA}']
  end;

// *********************************************************************//
// DispIntf:  _CodeGotoStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {8F1BAED9-52EC-3545-9CF0-6ED71A76A5CA}
// *********************************************************************//
  _CodeGotoStatementDisp = dispinterface
    ['{8F1BAED9-52EC-3545-9CF0-6ED71A76A5CA}']
  end;

// *********************************************************************//
// Interface: _CodeIndexerExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {C92C323F-8601-34D4-A2D6-F5E2653DB456}
// *********************************************************************//
  _CodeIndexerExpression = interface(IDispatch)
    ['{C92C323F-8601-34D4-A2D6-F5E2653DB456}']
  end;

// *********************************************************************//
// DispIntf:  _CodeIndexerExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {C92C323F-8601-34D4-A2D6-F5E2653DB456}
// *********************************************************************//
  _CodeIndexerExpressionDisp = dispinterface
    ['{C92C323F-8601-34D4-A2D6-F5E2653DB456}']
  end;

// *********************************************************************//
// Interface: _CodeIterationStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B16F7137-C0E7-3ECF-9652-FB1EA947E44E}
// *********************************************************************//
  _CodeIterationStatement = interface(IDispatch)
    ['{B16F7137-C0E7-3ECF-9652-FB1EA947E44E}']
  end;

// *********************************************************************//
// DispIntf:  _CodeIterationStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B16F7137-C0E7-3ECF-9652-FB1EA947E44E}
// *********************************************************************//
  _CodeIterationStatementDisp = dispinterface
    ['{B16F7137-C0E7-3ECF-9652-FB1EA947E44E}']
  end;

// *********************************************************************//
// Interface: _CodeLabeledStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {56699CCA-FD8D-3AD2-9643-149BAD87FD60}
// *********************************************************************//
  _CodeLabeledStatement = interface(IDispatch)
    ['{56699CCA-FD8D-3AD2-9643-149BAD87FD60}']
  end;

// *********************************************************************//
// DispIntf:  _CodeLabeledStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {56699CCA-FD8D-3AD2-9643-149BAD87FD60}
// *********************************************************************//
  _CodeLabeledStatementDisp = dispinterface
    ['{56699CCA-FD8D-3AD2-9643-149BAD87FD60}']
  end;

// *********************************************************************//
// Interface: _CodeLinePragma
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {1B52DED6-92F3-3B4F-851C-AB1F647582A3}
// *********************************************************************//
  _CodeLinePragma = interface(IDispatch)
    ['{1B52DED6-92F3-3B4F-851C-AB1F647582A3}']
  end;

// *********************************************************************//
// DispIntf:  _CodeLinePragmaDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {1B52DED6-92F3-3B4F-851C-AB1F647582A3}
// *********************************************************************//
  _CodeLinePragmaDisp = dispinterface
    ['{1B52DED6-92F3-3B4F-851C-AB1F647582A3}']
  end;

// *********************************************************************//
// Interface: _CodeMemberEvent
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {E1A7EA9F-5D43-3FA9-AFBC-9A2BFDA84B65}
// *********************************************************************//
  _CodeMemberEvent = interface(IDispatch)
    ['{E1A7EA9F-5D43-3FA9-AFBC-9A2BFDA84B65}']
  end;

// *********************************************************************//
// DispIntf:  _CodeMemberEventDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {E1A7EA9F-5D43-3FA9-AFBC-9A2BFDA84B65}
// *********************************************************************//
  _CodeMemberEventDisp = dispinterface
    ['{E1A7EA9F-5D43-3FA9-AFBC-9A2BFDA84B65}']
  end;

// *********************************************************************//
// Interface: _CodeTypeReferenceCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {68A04561-D0A0-3EEB-B904-462DC4EB5531}
// *********************************************************************//
  _CodeTypeReferenceCollection = interface(IDispatch)
    ['{68A04561-D0A0-3EEB-B904-462DC4EB5531}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeReferenceCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {68A04561-D0A0-3EEB-B904-462DC4EB5531}
// *********************************************************************//
  _CodeTypeReferenceCollectionDisp = dispinterface
    ['{68A04561-D0A0-3EEB-B904-462DC4EB5531}']
  end;

// *********************************************************************//
// Interface: _CodeMemberField
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EEF50D17-7AA6-3E14-96C6-DD90FE5BAA1E}
// *********************************************************************//
  _CodeMemberField = interface(IDispatch)
    ['{EEF50D17-7AA6-3E14-96C6-DD90FE5BAA1E}']
  end;

// *********************************************************************//
// DispIntf:  _CodeMemberFieldDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EEF50D17-7AA6-3E14-96C6-DD90FE5BAA1E}
// *********************************************************************//
  _CodeMemberFieldDisp = dispinterface
    ['{EEF50D17-7AA6-3E14-96C6-DD90FE5BAA1E}']
  end;

// *********************************************************************//
// Interface: _CodeParameterDeclarationExpressionCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {05192769-7D6A-3C8C-94C2-DFA668F61088}
// *********************************************************************//
  _CodeParameterDeclarationExpressionCollection = interface(IDispatch)
    ['{05192769-7D6A-3C8C-94C2-DFA668F61088}']
  end;

// *********************************************************************//
// DispIntf:  _CodeParameterDeclarationExpressionCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {05192769-7D6A-3C8C-94C2-DFA668F61088}
// *********************************************************************//
  _CodeParameterDeclarationExpressionCollectionDisp = dispinterface
    ['{05192769-7D6A-3C8C-94C2-DFA668F61088}']
  end;

// *********************************************************************//
// Interface: _CodeTypeParameterCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {6E814F1F-C349-3766-B55D-87C9B0232B20}
// *********************************************************************//
  _CodeTypeParameterCollection = interface(IDispatch)
    ['{6E814F1F-C349-3766-B55D-87C9B0232B20}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeParameterCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {6E814F1F-C349-3766-B55D-87C9B0232B20}
// *********************************************************************//
  _CodeTypeParameterCollectionDisp = dispinterface
    ['{6E814F1F-C349-3766-B55D-87C9B0232B20}']
  end;

// *********************************************************************//
// Interface: _CodeMemberProperty
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {802E2ACC-A7F8-3CA9-9114-F49998BEBE6E}
// *********************************************************************//
  _CodeMemberProperty = interface(IDispatch)
    ['{802E2ACC-A7F8-3CA9-9114-F49998BEBE6E}']
  end;

// *********************************************************************//
// DispIntf:  _CodeMemberPropertyDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {802E2ACC-A7F8-3CA9-9114-F49998BEBE6E}
// *********************************************************************//
  _CodeMemberPropertyDisp = dispinterface
    ['{802E2ACC-A7F8-3CA9-9114-F49998BEBE6E}']
  end;

// *********************************************************************//
// Interface: _CodeMethodInvokeExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FFE1F142-85CF-3353-8512-EE73775E9C4C}
// *********************************************************************//
  _CodeMethodInvokeExpression = interface(IDispatch)
    ['{FFE1F142-85CF-3353-8512-EE73775E9C4C}']
  end;

// *********************************************************************//
// DispIntf:  _CodeMethodInvokeExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FFE1F142-85CF-3353-8512-EE73775E9C4C}
// *********************************************************************//
  _CodeMethodInvokeExpressionDisp = dispinterface
    ['{FFE1F142-85CF-3353-8512-EE73775E9C4C}']
  end;

// *********************************************************************//
// Interface: _CodeMethodReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {CBDF02F4-A9F4-33C0-8B24-275008890DCB}
// *********************************************************************//
  _CodeMethodReferenceExpression = interface(IDispatch)
    ['{CBDF02F4-A9F4-33C0-8B24-275008890DCB}']
  end;

// *********************************************************************//
// DispIntf:  _CodeMethodReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {CBDF02F4-A9F4-33C0-8B24-275008890DCB}
// *********************************************************************//
  _CodeMethodReferenceExpressionDisp = dispinterface
    ['{CBDF02F4-A9F4-33C0-8B24-275008890DCB}']
  end;

// *********************************************************************//
// Interface: _CodeMethodReturnStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {851D821B-1E0C-3E91-832D-BA593523F566}
// *********************************************************************//
  _CodeMethodReturnStatement = interface(IDispatch)
    ['{851D821B-1E0C-3E91-832D-BA593523F566}']
  end;

// *********************************************************************//
// DispIntf:  _CodeMethodReturnStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {851D821B-1E0C-3E91-832D-BA593523F566}
// *********************************************************************//
  _CodeMethodReturnStatementDisp = dispinterface
    ['{851D821B-1E0C-3E91-832D-BA593523F566}']
  end;

// *********************************************************************//
// Interface: _CodeNamespace
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {31ED1DCB-C007-3F96-8809-4D5E3540A7C1}
// *********************************************************************//
  _CodeNamespace = interface(IDispatch)
    ['{31ED1DCB-C007-3F96-8809-4D5E3540A7C1}']
  end;

// *********************************************************************//
// DispIntf:  _CodeNamespaceDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {31ED1DCB-C007-3F96-8809-4D5E3540A7C1}
// *********************************************************************//
  _CodeNamespaceDisp = dispinterface
    ['{31ED1DCB-C007-3F96-8809-4D5E3540A7C1}']
  end;

// *********************************************************************//
// Interface: _CodeTypeDeclarationCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {BE0ECED3-5F0D-310A-B352-7D1ADF28F8EC}
// *********************************************************************//
  _CodeTypeDeclarationCollection = interface(IDispatch)
    ['{BE0ECED3-5F0D-310A-B352-7D1ADF28F8EC}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeDeclarationCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {BE0ECED3-5F0D-310A-B352-7D1ADF28F8EC}
// *********************************************************************//
  _CodeTypeDeclarationCollectionDisp = dispinterface
    ['{BE0ECED3-5F0D-310A-B352-7D1ADF28F8EC}']
  end;

// *********************************************************************//
// Interface: _CodeNamespaceImportCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4C545457-76D7-3C56-B277-6A9E86D1046F}
// *********************************************************************//
  _CodeNamespaceImportCollection = interface(IDispatch)
    ['{4C545457-76D7-3C56-B277-6A9E86D1046F}']
  end;

// *********************************************************************//
// DispIntf:  _CodeNamespaceImportCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4C545457-76D7-3C56-B277-6A9E86D1046F}
// *********************************************************************//
  _CodeNamespaceImportCollectionDisp = dispinterface
    ['{4C545457-76D7-3C56-B277-6A9E86D1046F}']
  end;

// *********************************************************************//
// Interface: _CodeNamespaceImport
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {34418787-726B-3E74-AEED-C01397FC707D}
// *********************************************************************//
  _CodeNamespaceImport = interface(IDispatch)
    ['{34418787-726B-3E74-AEED-C01397FC707D}']
  end;

// *********************************************************************//
// DispIntf:  _CodeNamespaceImportDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {34418787-726B-3E74-AEED-C01397FC707D}
// *********************************************************************//
  _CodeNamespaceImportDisp = dispinterface
    ['{34418787-726B-3E74-AEED-C01397FC707D}']
  end;

// *********************************************************************//
// Interface: _CodeObjectCreateExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {CFE5E5E9-745F-348B-A7E6-38A46D1A20E0}
// *********************************************************************//
  _CodeObjectCreateExpression = interface(IDispatch)
    ['{CFE5E5E9-745F-348B-A7E6-38A46D1A20E0}']
  end;

// *********************************************************************//
// DispIntf:  _CodeObjectCreateExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {CFE5E5E9-745F-348B-A7E6-38A46D1A20E0}
// *********************************************************************//
  _CodeObjectCreateExpressionDisp = dispinterface
    ['{CFE5E5E9-745F-348B-A7E6-38A46D1A20E0}']
  end;

// *********************************************************************//
// Interface: _CodeParameterDeclarationExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EE96565B-2B1A-33C6-BA07-B63158F1C8C4}
// *********************************************************************//
  _CodeParameterDeclarationExpression = interface(IDispatch)
    ['{EE96565B-2B1A-33C6-BA07-B63158F1C8C4}']
  end;

// *********************************************************************//
// DispIntf:  _CodeParameterDeclarationExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {EE96565B-2B1A-33C6-BA07-B63158F1C8C4}
// *********************************************************************//
  _CodeParameterDeclarationExpressionDisp = dispinterface
    ['{EE96565B-2B1A-33C6-BA07-B63158F1C8C4}']
  end;

// *********************************************************************//
// Interface: _CodePrimitiveExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {175BB49A-4CBE-38B3-8C6C-1B0145EDABB7}
// *********************************************************************//
  _CodePrimitiveExpression = interface(IDispatch)
    ['{175BB49A-4CBE-38B3-8C6C-1B0145EDABB7}']
  end;

// *********************************************************************//
// DispIntf:  _CodePrimitiveExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {175BB49A-4CBE-38B3-8C6C-1B0145EDABB7}
// *********************************************************************//
  _CodePrimitiveExpressionDisp = dispinterface
    ['{175BB49A-4CBE-38B3-8C6C-1B0145EDABB7}']
  end;

// *********************************************************************//
// Interface: _CodePropertyReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F8D64802-F9B7-3095-A641-D31E6E9F87B1}
// *********************************************************************//
  _CodePropertyReferenceExpression = interface(IDispatch)
    ['{F8D64802-F9B7-3095-A641-D31E6E9F87B1}']
  end;

// *********************************************************************//
// DispIntf:  _CodePropertyReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F8D64802-F9B7-3095-A641-D31E6E9F87B1}
// *********************************************************************//
  _CodePropertyReferenceExpressionDisp = dispinterface
    ['{F8D64802-F9B7-3095-A641-D31E6E9F87B1}']
  end;

// *********************************************************************//
// Interface: _CodePropertySetValueReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {2EE13FA1-8A02-3573-9AC9-4FEBD2CEAB45}
// *********************************************************************//
  _CodePropertySetValueReferenceExpression = interface(IDispatch)
    ['{2EE13FA1-8A02-3573-9AC9-4FEBD2CEAB45}']
  end;

// *********************************************************************//
// DispIntf:  _CodePropertySetValueReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {2EE13FA1-8A02-3573-9AC9-4FEBD2CEAB45}
// *********************************************************************//
  _CodePropertySetValueReferenceExpressionDisp = dispinterface
    ['{2EE13FA1-8A02-3573-9AC9-4FEBD2CEAB45}']
  end;

// *********************************************************************//
// Interface: _CodeRegionDirective
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {26AE5CC6-CCFD-3906-8B68-16E5EEFABB10}
// *********************************************************************//
  _CodeRegionDirective = interface(IDispatch)
    ['{26AE5CC6-CCFD-3906-8B68-16E5EEFABB10}']
  end;

// *********************************************************************//
// DispIntf:  _CodeRegionDirectiveDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {26AE5CC6-CCFD-3906-8B68-16E5EEFABB10}
// *********************************************************************//
  _CodeRegionDirectiveDisp = dispinterface
    ['{26AE5CC6-CCFD-3906-8B68-16E5EEFABB10}']
  end;

// *********************************************************************//
// Interface: _CodeRemoveEventStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {853BC437-CA6E-375D-BCBB-818E917D9691}
// *********************************************************************//
  _CodeRemoveEventStatement = interface(IDispatch)
    ['{853BC437-CA6E-375D-BCBB-818E917D9691}']
  end;

// *********************************************************************//
// DispIntf:  _CodeRemoveEventStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {853BC437-CA6E-375D-BCBB-818E917D9691}
// *********************************************************************//
  _CodeRemoveEventStatementDisp = dispinterface
    ['{853BC437-CA6E-375D-BCBB-818E917D9691}']
  end;

// *********************************************************************//
// Interface: _CodeSnippetCompileUnit
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {C7D34CF6-CF82-38B0-BF67-EB36DA63AE6E}
// *********************************************************************//
  _CodeSnippetCompileUnit = interface(IDispatch)
    ['{C7D34CF6-CF82-38B0-BF67-EB36DA63AE6E}']
  end;

// *********************************************************************//
// DispIntf:  _CodeSnippetCompileUnitDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {C7D34CF6-CF82-38B0-BF67-EB36DA63AE6E}
// *********************************************************************//
  _CodeSnippetCompileUnitDisp = dispinterface
    ['{C7D34CF6-CF82-38B0-BF67-EB36DA63AE6E}']
  end;

// *********************************************************************//
// Interface: _CodeSnippetExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {9F3E3CD1-8082-31E9-851C-3E177E56A87B}
// *********************************************************************//
  _CodeSnippetExpression = interface(IDispatch)
    ['{9F3E3CD1-8082-31E9-851C-3E177E56A87B}']
  end;

// *********************************************************************//
// DispIntf:  _CodeSnippetExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {9F3E3CD1-8082-31E9-851C-3E177E56A87B}
// *********************************************************************//
  _CodeSnippetExpressionDisp = dispinterface
    ['{9F3E3CD1-8082-31E9-851C-3E177E56A87B}']
  end;

// *********************************************************************//
// Interface: _CodeSnippetStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B4B00613-C48B-3FA9-B8F6-A527EC6F21C3}
// *********************************************************************//
  _CodeSnippetStatement = interface(IDispatch)
    ['{B4B00613-C48B-3FA9-B8F6-A527EC6F21C3}']
  end;

// *********************************************************************//
// DispIntf:  _CodeSnippetStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B4B00613-C48B-3FA9-B8F6-A527EC6F21C3}
// *********************************************************************//
  _CodeSnippetStatementDisp = dispinterface
    ['{B4B00613-C48B-3FA9-B8F6-A527EC6F21C3}']
  end;

// *********************************************************************//
// Interface: _CodeSnippetTypeMember
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {575BF8D0-7A9D-39EB-81F9-AA2BEBA890FA}
// *********************************************************************//
  _CodeSnippetTypeMember = interface(IDispatch)
    ['{575BF8D0-7A9D-39EB-81F9-AA2BEBA890FA}']
  end;

// *********************************************************************//
// DispIntf:  _CodeSnippetTypeMemberDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {575BF8D0-7A9D-39EB-81F9-AA2BEBA890FA}
// *********************************************************************//
  _CodeSnippetTypeMemberDisp = dispinterface
    ['{575BF8D0-7A9D-39EB-81F9-AA2BEBA890FA}']
  end;

// *********************************************************************//
// Interface: _CodeThisReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {3B4A1A6B-8E65-355D-B93A-E6AB753B2401}
// *********************************************************************//
  _CodeThisReferenceExpression = interface(IDispatch)
    ['{3B4A1A6B-8E65-355D-B93A-E6AB753B2401}']
  end;

// *********************************************************************//
// DispIntf:  _CodeThisReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {3B4A1A6B-8E65-355D-B93A-E6AB753B2401}
// *********************************************************************//
  _CodeThisReferenceExpressionDisp = dispinterface
    ['{3B4A1A6B-8E65-355D-B93A-E6AB753B2401}']
  end;

// *********************************************************************//
// Interface: _CodeThrowExceptionStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {12350E95-6F4E-30F0-9343-72F1C64380A0}
// *********************************************************************//
  _CodeThrowExceptionStatement = interface(IDispatch)
    ['{12350E95-6F4E-30F0-9343-72F1C64380A0}']
  end;

// *********************************************************************//
// DispIntf:  _CodeThrowExceptionStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {12350E95-6F4E-30F0-9343-72F1C64380A0}
// *********************************************************************//
  _CodeThrowExceptionStatementDisp = dispinterface
    ['{12350E95-6F4E-30F0-9343-72F1C64380A0}']
  end;

// *********************************************************************//
// Interface: _CodeTryCatchFinallyStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {8FD0F76A-29BF-3982-8335-C9B44ABF31C3}
// *********************************************************************//
  _CodeTryCatchFinallyStatement = interface(IDispatch)
    ['{8FD0F76A-29BF-3982-8335-C9B44ABF31C3}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTryCatchFinallyStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {8FD0F76A-29BF-3982-8335-C9B44ABF31C3}
// *********************************************************************//
  _CodeTryCatchFinallyStatementDisp = dispinterface
    ['{8FD0F76A-29BF-3982-8335-C9B44ABF31C3}']
  end;

// *********************************************************************//
// Interface: _CodeTypeConstructor
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {261AD877-0F22-33DE-9A3A-31F5DA424B30}
// *********************************************************************//
  _CodeTypeConstructor = interface(IDispatch)
    ['{261AD877-0F22-33DE-9A3A-31F5DA424B30}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeConstructorDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {261AD877-0F22-33DE-9A3A-31F5DA424B30}
// *********************************************************************//
  _CodeTypeConstructorDisp = dispinterface
    ['{261AD877-0F22-33DE-9A3A-31F5DA424B30}']
  end;

// *********************************************************************//
// Interface: _CodeTypeDeclaration
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7AA363E1-FA53-31EB-BE4A-1EB4838264F3}
// *********************************************************************//
  _CodeTypeDeclaration = interface(IDispatch)
    ['{7AA363E1-FA53-31EB-BE4A-1EB4838264F3}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeDeclarationDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7AA363E1-FA53-31EB-BE4A-1EB4838264F3}
// *********************************************************************//
  _CodeTypeDeclarationDisp = dispinterface
    ['{7AA363E1-FA53-31EB-BE4A-1EB4838264F3}']
  end;

// *********************************************************************//
// Interface: _CodeTypeMemberCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F943231E-6192-33A0-9CA3-D6ED0E4F323D}
// *********************************************************************//
  _CodeTypeMemberCollection = interface(IDispatch)
    ['{F943231E-6192-33A0-9CA3-D6ED0E4F323D}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeMemberCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F943231E-6192-33A0-9CA3-D6ED0E4F323D}
// *********************************************************************//
  _CodeTypeMemberCollectionDisp = dispinterface
    ['{F943231E-6192-33A0-9CA3-D6ED0E4F323D}']
  end;

// *********************************************************************//
// Interface: _CodeTypeDelegate
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {455090AB-5C44-3F4F-8EED-CCC90A3112B5}
// *********************************************************************//
  _CodeTypeDelegate = interface(IDispatch)
    ['{455090AB-5C44-3F4F-8EED-CCC90A3112B5}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeDelegateDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {455090AB-5C44-3F4F-8EED-CCC90A3112B5}
// *********************************************************************//
  _CodeTypeDelegateDisp = dispinterface
    ['{455090AB-5C44-3F4F-8EED-CCC90A3112B5}']
  end;

// *********************************************************************//
// Interface: _CodeTypeOfExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {12CBCE8E-75FF-312F-81B9-7FBC6212090B}
// *********************************************************************//
  _CodeTypeOfExpression = interface(IDispatch)
    ['{12CBCE8E-75FF-312F-81B9-7FBC6212090B}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeOfExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {12CBCE8E-75FF-312F-81B9-7FBC6212090B}
// *********************************************************************//
  _CodeTypeOfExpressionDisp = dispinterface
    ['{12CBCE8E-75FF-312F-81B9-7FBC6212090B}']
  end;

// *********************************************************************//
// Interface: _CodeTypeParameter
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B6ED2127-296F-3B31-AEB5-E2101E98D746}
// *********************************************************************//
  _CodeTypeParameter = interface(IDispatch)
    ['{B6ED2127-296F-3B31-AEB5-E2101E98D746}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeParameterDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B6ED2127-296F-3B31-AEB5-E2101E98D746}
// *********************************************************************//
  _CodeTypeParameterDisp = dispinterface
    ['{B6ED2127-296F-3B31-AEB5-E2101E98D746}']
  end;

// *********************************************************************//
// Interface: _CodeTypeReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {726BB04D-2C4C-3E3D-A01A-31448DB063DD}
// *********************************************************************//
  _CodeTypeReferenceExpression = interface(IDispatch)
    ['{726BB04D-2C4C-3E3D-A01A-31448DB063DD}']
  end;

// *********************************************************************//
// DispIntf:  _CodeTypeReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {726BB04D-2C4C-3E3D-A01A-31448DB063DD}
// *********************************************************************//
  _CodeTypeReferenceExpressionDisp = dispinterface
    ['{726BB04D-2C4C-3E3D-A01A-31448DB063DD}']
  end;

// *********************************************************************//
// Interface: _CodeVariableDeclarationStatement
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4192A87C-5C57-3879-8624-AF5CA2ED9EB2}
// *********************************************************************//
  _CodeVariableDeclarationStatement = interface(IDispatch)
    ['{4192A87C-5C57-3879-8624-AF5CA2ED9EB2}']
  end;

// *********************************************************************//
// DispIntf:  _CodeVariableDeclarationStatementDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4192A87C-5C57-3879-8624-AF5CA2ED9EB2}
// *********************************************************************//
  _CodeVariableDeclarationStatementDisp = dispinterface
    ['{4192A87C-5C57-3879-8624-AF5CA2ED9EB2}']
  end;

// *********************************************************************//
// Interface: _CodeVariableReferenceExpression
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {54B54936-A71C-3A45-B982-2C484E7BCF86}
// *********************************************************************//
  _CodeVariableReferenceExpression = interface(IDispatch)
    ['{54B54936-A71C-3A45-B982-2C484E7BCF86}']
  end;

// *********************************************************************//
// DispIntf:  _CodeVariableReferenceExpressionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {54B54936-A71C-3A45-B982-2C484E7BCF86}
// *********************************************************************//
  _CodeVariableReferenceExpressionDisp = dispinterface
    ['{54B54936-A71C-3A45-B982-2C484E7BCF86}']
  end;

// *********************************************************************//
// Interface: _Component
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {06565C0F-C465-37DE-896F-9864BC0BFC96}
// *********************************************************************//
  _Component = interface(IDispatch)
    ['{06565C0F-C465-37DE-896F-9864BC0BFC96}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {06565C0F-C465-37DE-896F-9864BC0BFC96}
// *********************************************************************//
  _ComponentDisp = dispinterface
    ['{06565C0F-C465-37DE-896F-9864BC0BFC96}']
  end;

// *********************************************************************//
// Interface: _AttributeCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {6F971E04-B06A-3DD0-B6F5-622826693454}
// *********************************************************************//
  _AttributeCollection = interface(IDispatch)
    ['{6F971E04-B06A-3DD0-B6F5-622826693454}']
  end;

// *********************************************************************//
// DispIntf:  _AttributeCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {6F971E04-B06A-3DD0-B6F5-622826693454}
// *********************************************************************//
  _AttributeCollectionDisp = dispinterface
    ['{6F971E04-B06A-3DD0-B6F5-622826693454}']
  end;

// *********************************************************************//
// Interface: _PropertyDescriptor
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FE5060F8-212F-3A4F-8FA8-DB2E14588C49}
// *********************************************************************//
  _PropertyDescriptor = interface(IDispatch)
    ['{FE5060F8-212F-3A4F-8FA8-DB2E14588C49}']
  end;

// *********************************************************************//
// DispIntf:  _PropertyDescriptorDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FE5060F8-212F-3A4F-8FA8-DB2E14588C49}
// *********************************************************************//
  _PropertyDescriptorDisp = dispinterface
    ['{FE5060F8-212F-3A4F-8FA8-DB2E14588C49}']
  end;

// *********************************************************************//
// Interface: IComponent
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {B86E59F2-F1E2-389D-B5F1-C55307C8106E}
// *********************************************************************//
  IComponent = interface(IDispatch)
    ['{B86E59F2-F1E2-389D-B5F1-C55307C8106E}']
    function Get_Site: ISite; safecall;
    procedure _Set_Site(const pRetVal: ISite); safecall;
    procedure add_Disposed(const value: _EventHandler); safecall;
    procedure remove_Disposed(const value: _EventHandler); safecall;
    property Site: ISite read Get_Site write _Set_Site;
  end;

// *********************************************************************//
// DispIntf:  IComponentDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {B86E59F2-F1E2-389D-B5F1-C55307C8106E}
// *********************************************************************//
  IComponentDisp = dispinterface
    ['{B86E59F2-F1E2-389D-B5F1-C55307C8106E}']
    property Site: ISite dispid 1610743808;
    procedure add_Disposed(const value: _EventHandler); dispid 1610743810;
    procedure remove_Disposed(const value: _EventHandler); dispid 1610743811;
  end;

// *********************************************************************//
// Interface: ISite
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {C4E1006A-9D98-3E96-A07E-921725135C28}
// *********************************************************************//
  ISite = interface(IDispatch)
    ['{C4E1006A-9D98-3E96-A07E-921725135C28}']
    function Get_component: IComponent; safecall;
    function Get_Container: IContainer; safecall;
    function Get_DesignMode: WordBool; safecall;
    function Get_name: WideString; safecall;
    procedure Set_name(const pRetVal: WideString); safecall;
    property component: IComponent read Get_component;
    property Container: IContainer read Get_Container;
    property DesignMode: WordBool read Get_DesignMode;
    property name: WideString read Get_name write Set_name;
  end;

// *********************************************************************//
// DispIntf:  ISiteDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {C4E1006A-9D98-3E96-A07E-921725135C28}
// *********************************************************************//
  ISiteDisp = dispinterface
    ['{C4E1006A-9D98-3E96-A07E-921725135C28}']
    property component: IComponent readonly dispid 1610743808;
    property Container: IContainer readonly dispid 1610743809;
    property DesignMode: WordBool readonly dispid 1610743810;
    property name: WideString dispid 1610743811;
  end;

// *********************************************************************//
// Interface: IContainer
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {61D9C50C-4AAD-3539-AF82-4F36C19D77C8}
// *********************************************************************//
  IContainer = interface(IDispatch)
    ['{61D9C50C-4AAD-3539-AF82-4F36C19D77C8}']
    procedure Add(const component: IComponent); safecall;
    procedure Add_2(const component: IComponent; const name: WideString); safecall;
    function Get_Components: _ComponentCollection; safecall;
    procedure Remove(const component: IComponent); safecall;
    property Components: _ComponentCollection read Get_Components;
  end;

// *********************************************************************//
// DispIntf:  IContainerDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {61D9C50C-4AAD-3539-AF82-4F36C19D77C8}
// *********************************************************************//
  IContainerDisp = dispinterface
    ['{61D9C50C-4AAD-3539-AF82-4F36C19D77C8}']
    procedure Add(const component: IComponent); dispid 1610743808;
    procedure Add_2(const component: IComponent; const name: WideString); dispid 1610743809;
    property Components: _ComponentCollection readonly dispid 1610743810;
    procedure Remove(const component: IComponent); dispid 1610743811;
  end;

// *********************************************************************//
// Interface: _ComponentCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {42F00C62-F454-3A38-AF9E-35D4E2BDFDAC}
// *********************************************************************//
  _ComponentCollection = interface(IDispatch)
    ['{42F00C62-F454-3A38-AF9E-35D4E2BDFDAC}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {42F00C62-F454-3A38-AF9E-35D4E2BDFDAC}
// *********************************************************************//
  _ComponentCollectionDisp = dispinterface
    ['{42F00C62-F454-3A38-AF9E-35D4E2BDFDAC}']
  end;

// *********************************************************************//
// Interface: _EventDescriptor
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {95B6A563-4A39-37A2-91D7-04B8ECDD1B66}
// *********************************************************************//
  _EventDescriptor = interface(IDispatch)
    ['{95B6A563-4A39-37A2-91D7-04B8ECDD1B66}']
  end;

// *********************************************************************//
// DispIntf:  _EventDescriptorDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {95B6A563-4A39-37A2-91D7-04B8ECDD1B66}
// *********************************************************************//
  _EventDescriptorDisp = dispinterface
    ['{95B6A563-4A39-37A2-91D7-04B8ECDD1B66}']
  end;

// *********************************************************************//
// Interface: _EventDescriptorCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4C933253-83F2-35B6-961A-0780FF1BAF7C}
// *********************************************************************//
  _EventDescriptorCollection = interface(IDispatch)
    ['{4C933253-83F2-35B6-961A-0780FF1BAF7C}']
  end;

// *********************************************************************//
// DispIntf:  _EventDescriptorCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4C933253-83F2-35B6-961A-0780FF1BAF7C}
// *********************************************************************//
  _EventDescriptorCollectionDisp = dispinterface
    ['{4C933253-83F2-35B6-961A-0780FF1BAF7C}']
  end;

// *********************************************************************//
// Interface: _MemberDescriptor
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F55EFA91-812E-3C6E-998F-3598E93FB8A7}
// *********************************************************************//
  _MemberDescriptor = interface(IDispatch)
    ['{F55EFA91-812E-3C6E-998F-3598E93FB8A7}']
  end;

// *********************************************************************//
// DispIntf:  _MemberDescriptorDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {F55EFA91-812E-3C6E-998F-3598E93FB8A7}
// *********************************************************************//
  _MemberDescriptorDisp = dispinterface
    ['{F55EFA91-812E-3C6E-998F-3598E93FB8A7}']
  end;

// *********************************************************************//
// Interface: _MarshalByValueComponent
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {35F38044-2017-3E05-BA83-1B87CC0D49C7}
// *********************************************************************//
  _MarshalByValueComponent = interface(IDispatch)
    ['{35F38044-2017-3E05-BA83-1B87CC0D49C7}']
  end;

// *********************************************************************//
// DispIntf:  _MarshalByValueComponentDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {35F38044-2017-3E05-BA83-1B87CC0D49C7}
// *********************************************************************//
  _MarshalByValueComponentDisp = dispinterface
    ['{35F38044-2017-3E05-BA83-1B87CC0D49C7}']
  end;

// *********************************************************************//
// Interface: IDesigner
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {6EEF3D0D-305A-3DF4-9830-8C2B40E1C4BF}
// *********************************************************************//
  IDesigner = interface(IDispatch)
    ['{6EEF3D0D-305A-3DF4-9830-8C2B40E1C4BF}']
    function Get_component: IComponent; safecall;
    function Get_Verbs: _DesignerVerbCollection; safecall;
    procedure DoDefaultAction; safecall;
    procedure Initialize(const component: IComponent); safecall;
    property component: IComponent read Get_component;
    property Verbs: _DesignerVerbCollection read Get_Verbs;
  end;

// *********************************************************************//
// DispIntf:  IDesignerDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {6EEF3D0D-305A-3DF4-9830-8C2B40E1C4BF}
// *********************************************************************//
  IDesignerDisp = dispinterface
    ['{6EEF3D0D-305A-3DF4-9830-8C2B40E1C4BF}']
    property component: IComponent readonly dispid 1610743808;
    property Verbs: _DesignerVerbCollection readonly dispid 1610743809;
    procedure DoDefaultAction; dispid 1610743810;
    procedure Initialize(const component: IComponent); dispid 1610743811;
  end;

// *********************************************************************//
// Interface: IDesignerHost
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {EEC98CD8-EF5B-3B60-82C9-86F616F6BB20}
// *********************************************************************//
  IDesignerHost = interface(IDispatch)
    ['{EEC98CD8-EF5B-3B60-82C9-86F616F6BB20}']
    function Get_Loading: WordBool; safecall;
    function Get_InTransaction: WordBool; safecall;
    function Get_Container: IContainer; safecall;
    function Get_RootComponent: IComponent; safecall;
    function Get_RootComponentClassName: WideString; safecall;
    function Get_TransactionDescription: WideString; safecall;
    procedure add_Activated(const value: _EventHandler); safecall;
    procedure remove_Activated(const value: _EventHandler); safecall;
    procedure add_Deactivated(const value: _EventHandler); safecall;
    procedure remove_Deactivated(const value: _EventHandler); safecall;
    procedure add_LoadComplete(const value: _EventHandler); safecall;
    procedure remove_LoadComplete(const value: _EventHandler); safecall;
    procedure add_TransactionClosed(const value: _DesignerTransactionCloseEventHandler); safecall;
    procedure remove_TransactionClosed(const value: _DesignerTransactionCloseEventHandler); safecall;
    procedure add_TransactionClosing(const value: _DesignerTransactionCloseEventHandler); safecall;
    procedure remove_TransactionClosing(const value: _DesignerTransactionCloseEventHandler); safecall;
    procedure add_TransactionOpened(const value: _EventHandler); safecall;
    procedure remove_TransactionOpened(const value: _EventHandler); safecall;
    procedure add_TransactionOpening(const value: _EventHandler); safecall;
    procedure remove_TransactionOpening(const value: _EventHandler); safecall;
    procedure Activate; safecall;
    function CreateComponent(const componentClass: _Type): IComponent; safecall;
    function CreateComponent_2(const componentClass: _Type; const name: WideString): IComponent; safecall;
    function CreateTransaction: IUnknown; safecall;
    function CreateTransaction_2(const description: WideString): IUnknown; safecall;
    procedure DestroyComponent(const component: IComponent); safecall;
    function GetDesigner(const component: IComponent): IDesigner; safecall;
    function GetType(const typeName: WideString): _Type; safecall;
    property Loading: WordBool read Get_Loading;
    property InTransaction: WordBool read Get_InTransaction;
    property Container: IContainer read Get_Container;
    property RootComponent: IComponent read Get_RootComponent;
    property RootComponentClassName: WideString read Get_RootComponentClassName;
    property TransactionDescription: WideString read Get_TransactionDescription;
  end;

// *********************************************************************//
// DispIntf:  IDesignerHostDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {EEC98CD8-EF5B-3B60-82C9-86F616F6BB20}
// *********************************************************************//
  IDesignerHostDisp = dispinterface
    ['{EEC98CD8-EF5B-3B60-82C9-86F616F6BB20}']
    property Loading: WordBool readonly dispid 1610743808;
    property InTransaction: WordBool readonly dispid 1610743809;
    property Container: IContainer readonly dispid 1610743810;
    property RootComponent: IComponent readonly dispid 1610743811;
    property RootComponentClassName: WideString readonly dispid 1610743812;
    property TransactionDescription: WideString readonly dispid 1610743813;
    procedure add_Activated(const value: _EventHandler); dispid 1610743814;
    procedure remove_Activated(const value: _EventHandler); dispid 1610743815;
    procedure add_Deactivated(const value: _EventHandler); dispid 1610743816;
    procedure remove_Deactivated(const value: _EventHandler); dispid 1610743817;
    procedure add_LoadComplete(const value: _EventHandler); dispid 1610743818;
    procedure remove_LoadComplete(const value: _EventHandler); dispid 1610743819;
    procedure add_TransactionClosed(const value: _DesignerTransactionCloseEventHandler); dispid 1610743820;
    procedure remove_TransactionClosed(const value: _DesignerTransactionCloseEventHandler); dispid 1610743821;
    procedure add_TransactionClosing(const value: _DesignerTransactionCloseEventHandler); dispid 1610743822;
    procedure remove_TransactionClosing(const value: _DesignerTransactionCloseEventHandler); dispid 1610743823;
    procedure add_TransactionOpened(const value: _EventHandler); dispid 1610743824;
    procedure remove_TransactionOpened(const value: _EventHandler); dispid 1610743825;
    procedure add_TransactionOpening(const value: _EventHandler); dispid 1610743826;
    procedure remove_TransactionOpening(const value: _EventHandler); dispid 1610743827;
    procedure Activate; dispid 1610743828;
    function CreateComponent(const componentClass: _Type): IComponent; dispid 1610743829;
    function CreateComponent_2(const componentClass: _Type; const name: WideString): IComponent; dispid 1610743830;
    function CreateTransaction: IUnknown; dispid 1610743831;
    function CreateTransaction_2(const description: WideString): IUnknown; dispid 1610743832;
    procedure DestroyComponent(const component: IComponent); dispid 1610743833;
    function GetDesigner(const component: IComponent): IDesigner; dispid 1610743834;
    function GetType(const typeName: WideString): _Type; dispid 1610743835;
  end;

// *********************************************************************//
// Interface: _CommandID
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FC50598B-2406-33D2-BA9A-CFBEA52BC05A}
// *********************************************************************//
  _CommandID = interface(IDispatch)
    ['{FC50598B-2406-33D2-BA9A-CFBEA52BC05A}']
  end;

// *********************************************************************//
// DispIntf:  _CommandIDDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {FC50598B-2406-33D2-BA9A-CFBEA52BC05A}
// *********************************************************************//
  _CommandIDDisp = dispinterface
    ['{FC50598B-2406-33D2-BA9A-CFBEA52BC05A}']
  end;

// *********************************************************************//
// Interface: _ComponentChangedEventArgs
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {A8FEF1C6-D434-3686-A4DE-B68E8EABB509}
// *********************************************************************//
  _ComponentChangedEventArgs = interface(IDispatch)
    ['{A8FEF1C6-D434-3686-A4DE-B68E8EABB509}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentChangedEventArgsDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {A8FEF1C6-D434-3686-A4DE-B68E8EABB509}
// *********************************************************************//
  _ComponentChangedEventArgsDisp = dispinterface
    ['{A8FEF1C6-D434-3686-A4DE-B68E8EABB509}']
  end;

// *********************************************************************//
// Interface: _ComponentChangedEventHandler
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {0451C390-1F90-341D-9278-B9FF2636D67D}
// *********************************************************************//
  _ComponentChangedEventHandler = interface(IDispatch)
    ['{0451C390-1F90-341D-9278-B9FF2636D67D}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentChangedEventHandlerDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {0451C390-1F90-341D-9278-B9FF2636D67D}
// *********************************************************************//
  _ComponentChangedEventHandlerDisp = dispinterface
    ['{0451C390-1F90-341D-9278-B9FF2636D67D}']
  end;

// *********************************************************************//
// Interface: _ComponentChangingEventArgs
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B78CBAA3-37DF-31C9-ABD2-CDCB1A7FBA9F}
// *********************************************************************//
  _ComponentChangingEventArgs = interface(IDispatch)
    ['{B78CBAA3-37DF-31C9-ABD2-CDCB1A7FBA9F}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentChangingEventArgsDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B78CBAA3-37DF-31C9-ABD2-CDCB1A7FBA9F}
// *********************************************************************//
  _ComponentChangingEventArgsDisp = dispinterface
    ['{B78CBAA3-37DF-31C9-ABD2-CDCB1A7FBA9F}']
  end;

// *********************************************************************//
// Interface: _ComponentChangingEventHandler
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7F8C2DA3-D337-334F-92E9-87BE9BDC6070}
// *********************************************************************//
  _ComponentChangingEventHandler = interface(IDispatch)
    ['{7F8C2DA3-D337-334F-92E9-87BE9BDC6070}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentChangingEventHandlerDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7F8C2DA3-D337-334F-92E9-87BE9BDC6070}
// *********************************************************************//
  _ComponentChangingEventHandlerDisp = dispinterface
    ['{7F8C2DA3-D337-334F-92E9-87BE9BDC6070}']
  end;

// *********************************************************************//
// Interface: _ComponentEventArgs
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {438E8DCF-6875-305F-8CA5-40DBB15782A6}
// *********************************************************************//
  _ComponentEventArgs = interface(IDispatch)
    ['{438E8DCF-6875-305F-8CA5-40DBB15782A6}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentEventArgsDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {438E8DCF-6875-305F-8CA5-40DBB15782A6}
// *********************************************************************//
  _ComponentEventArgsDisp = dispinterface
    ['{438E8DCF-6875-305F-8CA5-40DBB15782A6}']
  end;

// *********************************************************************//
// Interface: _ComponentEventHandler
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {290B355D-80D3-3AFA-96AB-B4D395729374}
// *********************************************************************//
  _ComponentEventHandler = interface(IDispatch)
    ['{290B355D-80D3-3AFA-96AB-B4D395729374}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentEventHandlerDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {290B355D-80D3-3AFA-96AB-B4D395729374}
// *********************************************************************//
  _ComponentEventHandlerDisp = dispinterface
    ['{290B355D-80D3-3AFA-96AB-B4D395729374}']
  end;

// *********************************************************************//
// Interface: _ComponentRenameEventArgs
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {DA5D7739-9522-3E28-9AB7-7C2D7D27C63A}
// *********************************************************************//
  _ComponentRenameEventArgs = interface(IDispatch)
    ['{DA5D7739-9522-3E28-9AB7-7C2D7D27C63A}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentRenameEventArgsDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {DA5D7739-9522-3E28-9AB7-7C2D7D27C63A}
// *********************************************************************//
  _ComponentRenameEventArgsDisp = dispinterface
    ['{DA5D7739-9522-3E28-9AB7-7C2D7D27C63A}']
  end;

// *********************************************************************//
// Interface: _ComponentRenameEventHandler
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {BA2DF049-DA87-3BD1-97B0-7904B59ADF7E}
// *********************************************************************//
  _ComponentRenameEventHandler = interface(IDispatch)
    ['{BA2DF049-DA87-3BD1-97B0-7904B59ADF7E}']
  end;

// *********************************************************************//
// DispIntf:  _ComponentRenameEventHandlerDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {BA2DF049-DA87-3BD1-97B0-7904B59ADF7E}
// *********************************************************************//
  _ComponentRenameEventHandlerDisp = dispinterface
    ['{BA2DF049-DA87-3BD1-97B0-7904B59ADF7E}']
  end;

// *********************************************************************//
// Interface: _DesignerTransactionCloseEventArgs
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {3924A637-C2C4-3558-945F-279B5AC39ED9}
// *********************************************************************//
  _DesignerTransactionCloseEventArgs = interface(IDispatch)
    ['{3924A637-C2C4-3558-945F-279B5AC39ED9}']
  end;

// *********************************************************************//
// DispIntf:  _DesignerTransactionCloseEventArgsDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {3924A637-C2C4-3558-945F-279B5AC39ED9}
// *********************************************************************//
  _DesignerTransactionCloseEventArgsDisp = dispinterface
    ['{3924A637-C2C4-3558-945F-279B5AC39ED9}']
  end;

// *********************************************************************//
// Interface: _DesignerTransactionCloseEventHandler
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4543D155-EE6A-3529-BC8D-CF0E866B6B0B}
// *********************************************************************//
  _DesignerTransactionCloseEventHandler = interface(IDispatch)
    ['{4543D155-EE6A-3529-BC8D-CF0E866B6B0B}']
  end;

// *********************************************************************//
// DispIntf:  _DesignerTransactionCloseEventHandlerDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {4543D155-EE6A-3529-BC8D-CF0E866B6B0B}
// *********************************************************************//
  _DesignerTransactionCloseEventHandlerDisp = dispinterface
    ['{4543D155-EE6A-3529-BC8D-CF0E866B6B0B}']
  end;

// *********************************************************************//
// Interface: _DesignerVerb
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7C41B90E-52FB-3E54-8B03-EBE0BF172C84}
// *********************************************************************//
  _DesignerVerb = interface(IDispatch)
    ['{7C41B90E-52FB-3E54-8B03-EBE0BF172C84}']
  end;

// *********************************************************************//
// DispIntf:  _DesignerVerbDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {7C41B90E-52FB-3E54-8B03-EBE0BF172C84}
// *********************************************************************//
  _DesignerVerbDisp = dispinterface
    ['{7C41B90E-52FB-3E54-8B03-EBE0BF172C84}']
  end;

// *********************************************************************//
// Interface: _MenuCommand
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {1FF238CE-6190-3750-A34F-05F02B7315A6}
// *********************************************************************//
  _MenuCommand = interface(IDispatch)
    ['{1FF238CE-6190-3750-A34F-05F02B7315A6}']
  end;

// *********************************************************************//
// DispIntf:  _MenuCommandDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {1FF238CE-6190-3750-A34F-05F02B7315A6}
// *********************************************************************//
  _MenuCommandDisp = dispinterface
    ['{1FF238CE-6190-3750-A34F-05F02B7315A6}']
  end;

// *********************************************************************//
// Interface: _DesignerVerbCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {AC3BDDA4-25B8-3321-A1C0-7C37BBF2DDED}
// *********************************************************************//
  _DesignerVerbCollection = interface(IDispatch)
    ['{AC3BDDA4-25B8-3321-A1C0-7C37BBF2DDED}']
  end;

// *********************************************************************//
// DispIntf:  _DesignerVerbCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {AC3BDDA4-25B8-3321-A1C0-7C37BBF2DDED}
// *********************************************************************//
  _DesignerVerbCollectionDisp = dispinterface
    ['{AC3BDDA4-25B8-3321-A1C0-7C37BBF2DDED}']
  end;

// *********************************************************************//
// Interface: IComponentChangeService
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {2FEF0210-9EBD-32C0-9BFD-24841AC0FCF7}
// *********************************************************************//
  IComponentChangeService = interface(IDispatch)
    ['{2FEF0210-9EBD-32C0-9BFD-24841AC0FCF7}']
    procedure add_ComponentAdded(const value: _ComponentEventHandler); safecall;
    procedure remove_ComponentAdded(const value: _ComponentEventHandler); safecall;
    procedure add_ComponentAdding(const value: _ComponentEventHandler); safecall;
    procedure remove_ComponentAdding(const value: _ComponentEventHandler); safecall;
    procedure add_ComponentChanged(const value: _ComponentChangedEventHandler); safecall;
    procedure remove_ComponentChanged(const value: _ComponentChangedEventHandler); safecall;
    procedure add_ComponentChanging(const value: _ComponentChangingEventHandler); safecall;
    procedure remove_ComponentChanging(const value: _ComponentChangingEventHandler); safecall;
    procedure add_ComponentRemoved(const value: _ComponentEventHandler); safecall;
    procedure remove_ComponentRemoved(const value: _ComponentEventHandler); safecall;
    procedure add_ComponentRemoving(const value: _ComponentEventHandler); safecall;
    procedure remove_ComponentRemoving(const value: _ComponentEventHandler); safecall;
    procedure add_ComponentRename(const value: _ComponentRenameEventHandler); safecall;
    procedure remove_ComponentRename(const value: _ComponentRenameEventHandler); safecall;
    procedure OnComponentChanged(component: OleVariant; const member: _MemberDescriptor; 
                                 oldValue: OleVariant; newValue: OleVariant); safecall;
    procedure OnComponentChanging(component: OleVariant; const member: _MemberDescriptor); safecall;
  end;

// *********************************************************************//
// DispIntf:  IComponentChangeServiceDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {2FEF0210-9EBD-32C0-9BFD-24841AC0FCF7}
// *********************************************************************//
  IComponentChangeServiceDisp = dispinterface
    ['{2FEF0210-9EBD-32C0-9BFD-24841AC0FCF7}']
    procedure add_ComponentAdded(const value: _ComponentEventHandler); dispid 1610743808;
    procedure remove_ComponentAdded(const value: _ComponentEventHandler); dispid 1610743809;
    procedure add_ComponentAdding(const value: _ComponentEventHandler); dispid 1610743810;
    procedure remove_ComponentAdding(const value: _ComponentEventHandler); dispid 1610743811;
    procedure add_ComponentChanged(const value: _ComponentChangedEventHandler); dispid 1610743812;
    procedure remove_ComponentChanged(const value: _ComponentChangedEventHandler); dispid 1610743813;
    procedure add_ComponentChanging(const value: _ComponentChangingEventHandler); dispid 1610743814;
    procedure remove_ComponentChanging(const value: _ComponentChangingEventHandler); dispid 1610743815;
    procedure add_ComponentRemoved(const value: _ComponentEventHandler); dispid 1610743816;
    procedure remove_ComponentRemoved(const value: _ComponentEventHandler); dispid 1610743817;
    procedure add_ComponentRemoving(const value: _ComponentEventHandler); dispid 1610743818;
    procedure remove_ComponentRemoving(const value: _ComponentEventHandler); dispid 1610743819;
    procedure add_ComponentRename(const value: _ComponentRenameEventHandler); dispid 1610743820;
    procedure remove_ComponentRename(const value: _ComponentRenameEventHandler); dispid 1610743821;
    procedure OnComponentChanged(component: OleVariant; const member: _MemberDescriptor; 
                                 oldValue: OleVariant; newValue: OleVariant); dispid 1610743822;
    procedure OnComponentChanging(component: OleVariant; const member: _MemberDescriptor); dispid 1610743823;
  end;

// *********************************************************************//
// Interface: IServiceContainer
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {6BA96B42-7FDD-3223-BF52-7FE677B92815}
// *********************************************************************//
  IServiceContainer = interface(IDispatch)
    ['{6BA96B42-7FDD-3223-BF52-7FE677B92815}']
    procedure AddService(const serviceType: _Type; serviceInstance: OleVariant); safecall;
    procedure AddService_2(const serviceType: _Type; serviceInstance: OleVariant; promote: WordBool); safecall;
    procedure AddService_3(const serviceType: _Type; const callback: _ServiceCreatorCallback); safecall;
    procedure AddService_4(const serviceType: _Type; const callback: _ServiceCreatorCallback; 
                           promote: WordBool); safecall;
    procedure RemoveService(const serviceType: _Type); safecall;
    procedure RemoveService_2(const serviceType: _Type; promote: WordBool); safecall;
  end;

// *********************************************************************//
// DispIntf:  IServiceContainerDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {6BA96B42-7FDD-3223-BF52-7FE677B92815}
// *********************************************************************//
  IServiceContainerDisp = dispinterface
    ['{6BA96B42-7FDD-3223-BF52-7FE677B92815}']
    procedure AddService(const serviceType: _Type; serviceInstance: OleVariant); dispid 1610743808;
    procedure AddService_2(const serviceType: _Type; serviceInstance: OleVariant; promote: WordBool); dispid 1610743809;
    procedure AddService_3(const serviceType: _Type; const callback: _ServiceCreatorCallback); dispid 1610743810;
    procedure AddService_4(const serviceType: _Type; const callback: _ServiceCreatorCallback; 
                           promote: WordBool); dispid 1610743811;
    procedure RemoveService(const serviceType: _Type); dispid 1610743812;
    procedure RemoveService_2(const serviceType: _Type; promote: WordBool); dispid 1610743813;
  end;

// *********************************************************************//
// Interface: IEventBindingService
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {1A19D89E-F4FE-3E8E-B7EC-05D4E592F3F6}
// *********************************************************************//
  IEventBindingService = interface(IDispatch)
    ['{1A19D89E-F4FE-3E8E-B7EC-05D4E592F3F6}']
    function CreateUniqueMethodName(const component: IComponent; const e: _EventDescriptor): WideString; safecall;
    function GetCompatibleMethods(const e: _EventDescriptor): ICollection; safecall;
    function GetEvent(const property_: _PropertyDescriptor): _EventDescriptor; safecall;
    function GetEventProperties(const events: _EventDescriptorCollection): IUnknown; safecall;
    function GetEventProperty(const e: _EventDescriptor): _PropertyDescriptor; safecall;
    function ShowCode: WordBool; safecall;
    function ShowCode_2(lineNumber: Integer): WordBool; safecall;
    function ShowCode_3(const component: IComponent; const e: _EventDescriptor): WordBool; safecall;
  end;

// *********************************************************************//
// DispIntf:  IEventBindingServiceDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {1A19D89E-F4FE-3E8E-B7EC-05D4E592F3F6}
// *********************************************************************//
  IEventBindingServiceDisp = dispinterface
    ['{1A19D89E-F4FE-3E8E-B7EC-05D4E592F3F6}']
    function CreateUniqueMethodName(const component: IComponent; const e: _EventDescriptor): WideString; dispid 1610743808;
    function GetCompatibleMethods(const e: _EventDescriptor): ICollection; dispid 1610743809;
    function GetEvent(const property_: _PropertyDescriptor): _EventDescriptor; dispid 1610743810;
    function GetEventProperties(const events: _EventDescriptorCollection): IUnknown; dispid 1610743811;
    function GetEventProperty(const e: _EventDescriptor): _PropertyDescriptor; dispid 1610743812;
    function ShowCode: WordBool; dispid 1610743813;
    function ShowCode_2(lineNumber: Integer): WordBool; dispid 1610743814;
    function ShowCode_3(const component: IComponent; const e: _EventDescriptor): WordBool; dispid 1610743815;
  end;

// *********************************************************************//
// Interface: IMenuCommandService
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {DF651C5D-783E-3789-901F-A962B7587E69}
// *********************************************************************//
  IMenuCommandService = interface(IDispatch)
    ['{DF651C5D-783E-3789-901F-A962B7587E69}']
    function Get_Verbs: _DesignerVerbCollection; safecall;
    procedure AddCommand(const command: _MenuCommand); safecall;
    procedure AddVerb(const verb: _DesignerVerb); safecall;
    function FindCommand(const CommandID: _CommandID): _MenuCommand; safecall;
    function GlobalInvoke(const CommandID: _CommandID): WordBool; safecall;
    procedure RemoveCommand(const command: _MenuCommand); safecall;
    procedure RemoveVerb(const verb: _DesignerVerb); safecall;
    procedure ShowContextMenu(const menuID: _CommandID; x: Integer; y: Integer); safecall;
    property Verbs: _DesignerVerbCollection read Get_Verbs;
  end;

// *********************************************************************//
// DispIntf:  IMenuCommandServiceDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {DF651C5D-783E-3789-901F-A962B7587E69}
// *********************************************************************//
  IMenuCommandServiceDisp = dispinterface
    ['{DF651C5D-783E-3789-901F-A962B7587E69}']
    property Verbs: _DesignerVerbCollection readonly dispid 1610743808;
    procedure AddCommand(const command: _MenuCommand); dispid 1610743809;
    procedure AddVerb(const verb: _DesignerVerb); dispid 1610743810;
    function FindCommand(const CommandID: _CommandID): _MenuCommand; dispid 1610743811;
    function GlobalInvoke(const CommandID: _CommandID): WordBool; dispid 1610743812;
    procedure RemoveCommand(const command: _MenuCommand); dispid 1610743813;
    procedure RemoveVerb(const verb: _DesignerVerb); dispid 1610743814;
    procedure ShowContextMenu(const menuID: _CommandID; x: Integer; y: Integer); dispid 1610743815;
  end;

// *********************************************************************//
// Interface: IRootDesigner
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {2CC5E562-6C14-34A6-9D0B-E6FF949AE8FB}
// *********************************************************************//
  IRootDesigner = interface(IDispatch)
    ['{2CC5E562-6C14-34A6-9D0B-E6FF949AE8FB}']
    function Get_SupportedTechnologies: PSafeArray; safecall;
    function GetView(technology: ViewTechnology): OleVariant; safecall;
    property SupportedTechnologies: PSafeArray read Get_SupportedTechnologies;
  end;

// *********************************************************************//
// DispIntf:  IRootDesignerDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {2CC5E562-6C14-34A6-9D0B-E6FF949AE8FB}
// *********************************************************************//
  IRootDesignerDisp = dispinterface
    ['{2CC5E562-6C14-34A6-9D0B-E6FF949AE8FB}']
    property SupportedTechnologies: {??PSafeArray}OleVariant readonly dispid 1610743808;
    function GetView(technology: ViewTechnology): OleVariant; dispid 1610743809;
  end;

// *********************************************************************//
// Interface: ISelectionService
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {297A65BE-5080-3F7F-AD19-B0D05D6F2327}
// *********************************************************************//
  ISelectionService = interface(IDispatch)
    ['{297A65BE-5080-3F7F-AD19-B0D05D6F2327}']
    function Get_PrimarySelection: OleVariant; safecall;
    function Get_SelectionCount: Integer; safecall;
    procedure add_SelectionChanged(const value: _EventHandler); safecall;
    procedure remove_SelectionChanged(const value: _EventHandler); safecall;
    procedure add_SelectionChanging(const value: _EventHandler); safecall;
    procedure remove_SelectionChanging(const value: _EventHandler); safecall;
    function GetComponentSelected(component: OleVariant): WordBool; safecall;
    function GetSelectedComponents: ICollection; safecall;
    procedure SetSelectedComponents(const Components: ICollection); safecall;
    procedure SetSelectedComponents_2(const Components: ICollection; selectionType: SelectionTypes); safecall;
    property PrimarySelection: OleVariant read Get_PrimarySelection;
    property SelectionCount: Integer read Get_SelectionCount;
  end;

// *********************************************************************//
// DispIntf:  ISelectionServiceDisp
// Flags:     (4416) Dual OleAutomation Dispatchable
// GUID:      {297A65BE-5080-3F7F-AD19-B0D05D6F2327}
// *********************************************************************//
  ISelectionServiceDisp = dispinterface
    ['{297A65BE-5080-3F7F-AD19-B0D05D6F2327}']
    property PrimarySelection: OleVariant readonly dispid 1610743808;
    property SelectionCount: Integer readonly dispid 1610743809;
    procedure add_SelectionChanged(const value: _EventHandler); dispid 1610743810;
    procedure remove_SelectionChanged(const value: _EventHandler); dispid 1610743811;
    procedure add_SelectionChanging(const value: _EventHandler); dispid 1610743812;
    procedure remove_SelectionChanging(const value: _EventHandler); dispid 1610743813;
    function GetComponentSelected(component: OleVariant): WordBool; dispid 1610743814;
    function GetSelectedComponents: ICollection; dispid 1610743815;
    procedure SetSelectedComponents(const Components: ICollection); dispid 1610743816;
    procedure SetSelectedComponents_2(const Components: ICollection; selectionType: SelectionTypes); dispid 1610743817;
  end;

// *********************************************************************//
// Interface: _ServiceCreatorCallback
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {BE380BEC-79F2-3876-B510-FA2FE43B7EB7}
// *********************************************************************//
  _ServiceCreatorCallback = interface(IDispatch)
    ['{BE380BEC-79F2-3876-B510-FA2FE43B7EB7}']
  end;

// *********************************************************************//
// DispIntf:  _ServiceCreatorCallbackDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {BE380BEC-79F2-3876-B510-FA2FE43B7EB7}
// *********************************************************************//
  _ServiceCreatorCallbackDisp = dispinterface
    ['{BE380BEC-79F2-3876-B510-FA2FE43B7EB7}']
  end;

// *********************************************************************//
// Interface: _DesignerLoader
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {43BE964C-1B4A-3D1F-9D94-8185A1E6CB7B}
// *********************************************************************//
  _DesignerLoader = interface(IDispatch)
    ['{43BE964C-1B4A-3D1F-9D94-8185A1E6CB7B}']
  end;

// *********************************************************************//
// DispIntf:  _DesignerLoaderDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {43BE964C-1B4A-3D1F-9D94-8185A1E6CB7B}
// *********************************************************************//
  _DesignerLoaderDisp = dispinterface
    ['{43BE964C-1B4A-3D1F-9D94-8185A1E6CB7B}']
  end;

// *********************************************************************//
// Interface: _PerformanceCounterManager
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {A9809E7D-42F8-3284-82CF-AB5F863A29AA}
// *********************************************************************//
  _PerformanceCounterManager = interface(IDispatch)
    ['{A9809E7D-42F8-3284-82CF-AB5F863A29AA}']
  end;

// *********************************************************************//
// DispIntf:  _PerformanceCounterManagerDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {A9809E7D-42F8-3284-82CF-AB5F863A29AA}
// *********************************************************************//
  _PerformanceCounterManagerDisp = dispinterface
    ['{A9809E7D-42F8-3284-82CF-AB5F863A29AA}']
  end;

// *********************************************************************//
// Interface: _WebHeaderCollection
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B97E84F2-FAB2-340D-8D49-2AC85CF5C0EC}
// *********************************************************************//
  _WebHeaderCollection = interface(IDispatch)
    ['{B97E84F2-FAB2-340D-8D49-2AC85CF5C0EC}']
  end;

// *********************************************************************//
// DispIntf:  _WebHeaderCollectionDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {B97E84F2-FAB2-340D-8D49-2AC85CF5C0EC}
// *********************************************************************//
  _WebHeaderCollectionDisp = dispinterface
    ['{B97E84F2-FAB2-340D-8D49-2AC85CF5C0EC}']
  end;

// *********************************************************************//
// Interface: _WebClient
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {85B4A627-7552-3AA6-8A1C-A213C5788FEC}
// *********************************************************************//
  _WebClient = interface(IDispatch)
    ['{85B4A627-7552-3AA6-8A1C-A213C5788FEC}']
  end;

// *********************************************************************//
// DispIntf:  _WebClientDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {85B4A627-7552-3AA6-8A1C-A213C5788FEC}
// *********************************************************************//
  _WebClientDisp = dispinterface
    ['{85B4A627-7552-3AA6-8A1C-A213C5788FEC}']
  end;

// *********************************************************************//
// Interface: _StandardOleMarshalObject
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {05F3D6C7-D4D1-37EB-AC35-63347B838A23}
// *********************************************************************//
  _StandardOleMarshalObject = interface(IDispatch)
    ['{05F3D6C7-D4D1-37EB-AC35-63347B838A23}']
  end;

// *********************************************************************//
// DispIntf:  _StandardOleMarshalObjectDisp
// Flags:     (4432) Hidden Dual OleAutomation Dispatchable
// GUID:      {05F3D6C7-D4D1-37EB-AC35-63347B838A23}
// *********************************************************************//
  _StandardOleMarshalObjectDisp = dispinterface
    ['{05F3D6C7-D4D1-37EB-AC35-63347B838A23}']
  end;

// *********************************************************************//
// The Class CoCodeDomProvider provides a Create and CreateRemote method to          
// create instances of the default interface _CodeDomProvider exposed by              
// the CoClass CodeDomProvider. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeDomProvider = class
    class function Create: _CodeDomProvider;
    class function CreateRemote(const MachineName: string): _CodeDomProvider;
  end;

// *********************************************************************//
// The Class CoTypeConverter provides a Create and CreateRemote method to          
// create instances of the default interface _TypeConverter exposed by              
// the CoClass TypeConverter. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoTypeConverter = class
    class function Create: _TypeConverter;
    class function CreateRemote(const MachineName: string): _TypeConverter;
  end;

// *********************************************************************//
// The Class CoCodeTypeMember provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeMember exposed by              
// the CoClass CodeTypeMember. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeMember = class
    class function Create: _CodeTypeMember;
    class function CreateRemote(const MachineName: string): _CodeTypeMember;
  end;

// *********************************************************************//
// The Class CoCodeArgumentReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeArgumentReferenceExpression exposed by              
// the CoClass CodeArgumentReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeArgumentReferenceExpression = class
    class function Create: _CodeArgumentReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodeArgumentReferenceExpression;
  end;

// *********************************************************************//
// The Class CoCodeExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeExpression exposed by              
// the CoClass CodeExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeExpression = class
    class function Create: _CodeExpression;
    class function CreateRemote(const MachineName: string): _CodeExpression;
  end;

// *********************************************************************//
// The Class CoCodeArrayCreateExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeArrayCreateExpression exposed by              
// the CoClass CodeArrayCreateExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeArrayCreateExpression = class
    class function Create: _CodeArrayCreateExpression;
    class function CreateRemote(const MachineName: string): _CodeArrayCreateExpression;
  end;

// *********************************************************************//
// The Class CoCodeTypeReference provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeReference exposed by              
// the CoClass CodeTypeReference. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeReference = class
    class function Create: _CodeTypeReference;
    class function CreateRemote(const MachineName: string): _CodeTypeReference;
  end;

// *********************************************************************//
// The Class CoCodeExpressionCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeExpressionCollection exposed by              
// the CoClass CodeExpressionCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeExpressionCollection = class
    class function Create: _CodeExpressionCollection;
    class function CreateRemote(const MachineName: string): _CodeExpressionCollection;
  end;

// *********************************************************************//
// The Class CoCodeArrayIndexerExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeArrayIndexerExpression exposed by              
// the CoClass CodeArrayIndexerExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeArrayIndexerExpression = class
    class function Create: _CodeArrayIndexerExpression;
    class function CreateRemote(const MachineName: string): _CodeArrayIndexerExpression;
  end;

// *********************************************************************//
// The Class CoCodeAssignStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeAssignStatement exposed by              
// the CoClass CodeAssignStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeAssignStatement = class
    class function Create: _CodeAssignStatement;
    class function CreateRemote(const MachineName: string): _CodeAssignStatement;
  end;

// *********************************************************************//
// The Class CoCodeStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeStatement exposed by              
// the CoClass CodeStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeStatement = class
    class function Create: _CodeStatement;
    class function CreateRemote(const MachineName: string): _CodeStatement;
  end;

// *********************************************************************//
// The Class CoCodeAttachEventStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeAttachEventStatement exposed by              
// the CoClass CodeAttachEventStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeAttachEventStatement = class
    class function Create: _CodeAttachEventStatement;
    class function CreateRemote(const MachineName: string): _CodeAttachEventStatement;
  end;

// *********************************************************************//
// The Class CoCodeEventReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeEventReferenceExpression exposed by              
// the CoClass CodeEventReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeEventReferenceExpression = class
    class function Create: _CodeEventReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodeEventReferenceExpression;
  end;

// *********************************************************************//
// The Class CoCodeAttributeArgument provides a Create and CreateRemote method to          
// create instances of the default interface _CodeAttributeArgument exposed by              
// the CoClass CodeAttributeArgument. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeAttributeArgument = class
    class function Create: _CodeAttributeArgument;
    class function CreateRemote(const MachineName: string): _CodeAttributeArgument;
  end;

// *********************************************************************//
// The Class CoCodeAttributeArgumentCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeAttributeArgumentCollection exposed by              
// the CoClass CodeAttributeArgumentCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeAttributeArgumentCollection = class
    class function Create: _CodeAttributeArgumentCollection;
    class function CreateRemote(const MachineName: string): _CodeAttributeArgumentCollection;
  end;

// *********************************************************************//
// The Class CoCodeAttributeDeclaration provides a Create and CreateRemote method to          
// create instances of the default interface _CodeAttributeDeclaration exposed by              
// the CoClass CodeAttributeDeclaration. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeAttributeDeclaration = class
    class function Create: _CodeAttributeDeclaration;
    class function CreateRemote(const MachineName: string): _CodeAttributeDeclaration;
  end;

// *********************************************************************//
// The Class CoCodeAttributeDeclarationCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeAttributeDeclarationCollection exposed by              
// the CoClass CodeAttributeDeclarationCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeAttributeDeclarationCollection = class
    class function Create: _CodeAttributeDeclarationCollection;
    class function CreateRemote(const MachineName: string): _CodeAttributeDeclarationCollection;
  end;

// *********************************************************************//
// The Class CoCodeBaseReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeBaseReferenceExpression exposed by              
// the CoClass CodeBaseReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeBaseReferenceExpression = class
    class function Create: _CodeBaseReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodeBaseReferenceExpression;
  end;

// *********************************************************************//
// The Class CoCodeBinaryOperatorExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeBinaryOperatorExpression exposed by              
// the CoClass CodeBinaryOperatorExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeBinaryOperatorExpression = class
    class function Create: _CodeBinaryOperatorExpression;
    class function CreateRemote(const MachineName: string): _CodeBinaryOperatorExpression;
  end;

// *********************************************************************//
// The Class CoCodeCastExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeCastExpression exposed by              
// the CoClass CodeCastExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeCastExpression = class
    class function Create: _CodeCastExpression;
    class function CreateRemote(const MachineName: string): _CodeCastExpression;
  end;

// *********************************************************************//
// The Class CoCodeCatchClause provides a Create and CreateRemote method to          
// create instances of the default interface _CodeCatchClause exposed by              
// the CoClass CodeCatchClause. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeCatchClause = class
    class function Create: _CodeCatchClause;
    class function CreateRemote(const MachineName: string): _CodeCatchClause;
  end;

// *********************************************************************//
// The Class CoCodeStatementCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeStatementCollection exposed by              
// the CoClass CodeStatementCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeStatementCollection = class
    class function Create: _CodeStatementCollection;
    class function CreateRemote(const MachineName: string): _CodeStatementCollection;
  end;

// *********************************************************************//
// The Class CoCodeCatchClauseCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeCatchClauseCollection exposed by              
// the CoClass CodeCatchClauseCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeCatchClauseCollection = class
    class function Create: _CodeCatchClauseCollection;
    class function CreateRemote(const MachineName: string): _CodeCatchClauseCollection;
  end;

// *********************************************************************//
// The Class CoCodeChecksumPragma provides a Create and CreateRemote method to          
// create instances of the default interface _CodeChecksumPragma exposed by              
// the CoClass CodeChecksumPragma. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeChecksumPragma = class
    class function Create: _CodeChecksumPragma;
    class function CreateRemote(const MachineName: string): _CodeChecksumPragma;
  end;

// *********************************************************************//
// The Class CoCodeDirective provides a Create and CreateRemote method to          
// create instances of the default interface _CodeDirective exposed by              
// the CoClass CodeDirective. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeDirective = class
    class function Create: _CodeDirective;
    class function CreateRemote(const MachineName: string): _CodeDirective;
  end;

// *********************************************************************//
// The Class CoCodeComment provides a Create and CreateRemote method to          
// create instances of the default interface _CodeComment exposed by              
// the CoClass CodeComment. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeComment = class
    class function Create: _CodeComment;
    class function CreateRemote(const MachineName: string): _CodeComment;
  end;

// *********************************************************************//
// The Class CoCodeObject provides a Create and CreateRemote method to          
// create instances of the default interface _CodeObject exposed by              
// the CoClass CodeObject. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeObject = class
    class function Create: _CodeObject;
    class function CreateRemote(const MachineName: string): _CodeObject;
  end;

// *********************************************************************//
// The Class CoCodeCommentStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeCommentStatement exposed by              
// the CoClass CodeCommentStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeCommentStatement = class
    class function Create: _CodeCommentStatement;
    class function CreateRemote(const MachineName: string): _CodeCommentStatement;
  end;

// *********************************************************************//
// The Class CoCodeCommentStatementCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeCommentStatementCollection exposed by              
// the CoClass CodeCommentStatementCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeCommentStatementCollection = class
    class function Create: _CodeCommentStatementCollection;
    class function CreateRemote(const MachineName: string): _CodeCommentStatementCollection;
  end;

// *********************************************************************//
// The Class CoCodeCompileUnit provides a Create and CreateRemote method to          
// create instances of the default interface _CodeCompileUnit exposed by              
// the CoClass CodeCompileUnit. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeCompileUnit = class
    class function Create: _CodeCompileUnit;
    class function CreateRemote(const MachineName: string): _CodeCompileUnit;
  end;

// *********************************************************************//
// The Class CoCodeNamespaceCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeNamespaceCollection exposed by              
// the CoClass CodeNamespaceCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeNamespaceCollection = class
    class function Create: _CodeNamespaceCollection;
    class function CreateRemote(const MachineName: string): _CodeNamespaceCollection;
  end;

// *********************************************************************//
// The Class CoCodeDirectiveCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeDirectiveCollection exposed by              
// the CoClass CodeDirectiveCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeDirectiveCollection = class
    class function Create: _CodeDirectiveCollection;
    class function CreateRemote(const MachineName: string): _CodeDirectiveCollection;
  end;

// *********************************************************************//
// The Class CoCodeConditionStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeConditionStatement exposed by              
// the CoClass CodeConditionStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeConditionStatement = class
    class function Create: _CodeConditionStatement;
    class function CreateRemote(const MachineName: string): _CodeConditionStatement;
  end;

// *********************************************************************//
// The Class CoCodeConstructor provides a Create and CreateRemote method to          
// create instances of the default interface _CodeConstructor exposed by              
// the CoClass CodeConstructor. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeConstructor = class
    class function Create: _CodeConstructor;
    class function CreateRemote(const MachineName: string): _CodeConstructor;
  end;

// *********************************************************************//
// The Class CoCodeMemberMethod provides a Create and CreateRemote method to          
// create instances of the default interface _CodeMemberMethod exposed by              
// the CoClass CodeMemberMethod. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeMemberMethod = class
    class function Create: _CodeMemberMethod;
    class function CreateRemote(const MachineName: string): _CodeMemberMethod;
  end;

// *********************************************************************//
// The Class CoCodeDefaultValueExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeDefaultValueExpression exposed by              
// the CoClass CodeDefaultValueExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeDefaultValueExpression = class
    class function Create: _CodeDefaultValueExpression;
    class function CreateRemote(const MachineName: string): _CodeDefaultValueExpression;
  end;

// *********************************************************************//
// The Class CoCodeDelegateCreateExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeDelegateCreateExpression exposed by              
// the CoClass CodeDelegateCreateExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeDelegateCreateExpression = class
    class function Create: _CodeDelegateCreateExpression;
    class function CreateRemote(const MachineName: string): _CodeDelegateCreateExpression;
  end;

// *********************************************************************//
// The Class CoCodeDelegateInvokeExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeDelegateInvokeExpression exposed by              
// the CoClass CodeDelegateInvokeExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeDelegateInvokeExpression = class
    class function Create: _CodeDelegateInvokeExpression;
    class function CreateRemote(const MachineName: string): _CodeDelegateInvokeExpression;
  end;

// *********************************************************************//
// The Class CoCodeDirectionExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeDirectionExpression exposed by              
// the CoClass CodeDirectionExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeDirectionExpression = class
    class function Create: _CodeDirectionExpression;
    class function CreateRemote(const MachineName: string): _CodeDirectionExpression;
  end;

// *********************************************************************//
// The Class CoCodeEntryPointMethod provides a Create and CreateRemote method to          
// create instances of the default interface _CodeEntryPointMethod exposed by              
// the CoClass CodeEntryPointMethod. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeEntryPointMethod = class
    class function Create: _CodeEntryPointMethod;
    class function CreateRemote(const MachineName: string): _CodeEntryPointMethod;
  end;

// *********************************************************************//
// The Class CoCodeExpressionStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeExpressionStatement exposed by              
// the CoClass CodeExpressionStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeExpressionStatement = class
    class function Create: _CodeExpressionStatement;
    class function CreateRemote(const MachineName: string): _CodeExpressionStatement;
  end;

// *********************************************************************//
// The Class CoCodeFieldReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeFieldReferenceExpression exposed by              
// the CoClass CodeFieldReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeFieldReferenceExpression = class
    class function Create: _CodeFieldReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodeFieldReferenceExpression;
  end;

// *********************************************************************//
// The Class CoCodeGotoStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeGotoStatement exposed by              
// the CoClass CodeGotoStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeGotoStatement = class
    class function Create: _CodeGotoStatement;
    class function CreateRemote(const MachineName: string): _CodeGotoStatement;
  end;

// *********************************************************************//
// The Class CoCodeIndexerExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeIndexerExpression exposed by              
// the CoClass CodeIndexerExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeIndexerExpression = class
    class function Create: _CodeIndexerExpression;
    class function CreateRemote(const MachineName: string): _CodeIndexerExpression;
  end;

// *********************************************************************//
// The Class CoCodeIterationStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeIterationStatement exposed by              
// the CoClass CodeIterationStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeIterationStatement = class
    class function Create: _CodeIterationStatement;
    class function CreateRemote(const MachineName: string): _CodeIterationStatement;
  end;

// *********************************************************************//
// The Class CoCodeLabeledStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeLabeledStatement exposed by              
// the CoClass CodeLabeledStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeLabeledStatement = class
    class function Create: _CodeLabeledStatement;
    class function CreateRemote(const MachineName: string): _CodeLabeledStatement;
  end;

// *********************************************************************//
// The Class CoCodeLinePragma provides a Create and CreateRemote method to          
// create instances of the default interface _CodeLinePragma exposed by              
// the CoClass CodeLinePragma. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeLinePragma = class
    class function Create: _CodeLinePragma;
    class function CreateRemote(const MachineName: string): _CodeLinePragma;
  end;

// *********************************************************************//
// The Class CoCodeMemberEvent provides a Create and CreateRemote method to          
// create instances of the default interface _CodeMemberEvent exposed by              
// the CoClass CodeMemberEvent. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeMemberEvent = class
    class function Create: _CodeMemberEvent;
    class function CreateRemote(const MachineName: string): _CodeMemberEvent;
  end;

// *********************************************************************//
// The Class CoCodeTypeReferenceCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeReferenceCollection exposed by              
// the CoClass CodeTypeReferenceCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeReferenceCollection = class
    class function Create: _CodeTypeReferenceCollection;
    class function CreateRemote(const MachineName: string): _CodeTypeReferenceCollection;
  end;

// *********************************************************************//
// The Class CoCodeMemberField provides a Create and CreateRemote method to          
// create instances of the default interface _CodeMemberField exposed by              
// the CoClass CodeMemberField. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeMemberField = class
    class function Create: _CodeMemberField;
    class function CreateRemote(const MachineName: string): _CodeMemberField;
  end;

// *********************************************************************//
// The Class CoCodeParameterDeclarationExpressionCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeParameterDeclarationExpressionCollection exposed by              
// the CoClass CodeParameterDeclarationExpressionCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeParameterDeclarationExpressionCollection = class
    class function Create: _CodeParameterDeclarationExpressionCollection;
    class function CreateRemote(const MachineName: string): _CodeParameterDeclarationExpressionCollection;
  end;

// *********************************************************************//
// The Class CoCodeTypeParameterCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeParameterCollection exposed by              
// the CoClass CodeTypeParameterCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeParameterCollection = class
    class function Create: _CodeTypeParameterCollection;
    class function CreateRemote(const MachineName: string): _CodeTypeParameterCollection;
  end;

// *********************************************************************//
// The Class CoCodeMemberProperty provides a Create and CreateRemote method to          
// create instances of the default interface _CodeMemberProperty exposed by              
// the CoClass CodeMemberProperty. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeMemberProperty = class
    class function Create: _CodeMemberProperty;
    class function CreateRemote(const MachineName: string): _CodeMemberProperty;
  end;

// *********************************************************************//
// The Class CoCodeMethodInvokeExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeMethodInvokeExpression exposed by              
// the CoClass CodeMethodInvokeExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeMethodInvokeExpression = class
    class function Create: _CodeMethodInvokeExpression;
    class function CreateRemote(const MachineName: string): _CodeMethodInvokeExpression;
  end;

// *********************************************************************//
// The Class CoCodeMethodReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeMethodReferenceExpression exposed by              
// the CoClass CodeMethodReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeMethodReferenceExpression = class
    class function Create: _CodeMethodReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodeMethodReferenceExpression;
  end;

// *********************************************************************//
// The Class CoCodeMethodReturnStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeMethodReturnStatement exposed by              
// the CoClass CodeMethodReturnStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeMethodReturnStatement = class
    class function Create: _CodeMethodReturnStatement;
    class function CreateRemote(const MachineName: string): _CodeMethodReturnStatement;
  end;

// *********************************************************************//
// The Class CoCodeNamespace provides a Create and CreateRemote method to          
// create instances of the default interface _CodeNamespace exposed by              
// the CoClass CodeNamespace. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeNamespace = class
    class function Create: _CodeNamespace;
    class function CreateRemote(const MachineName: string): _CodeNamespace;
  end;

// *********************************************************************//
// The Class CoCodeTypeDeclarationCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeDeclarationCollection exposed by              
// the CoClass CodeTypeDeclarationCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeDeclarationCollection = class
    class function Create: _CodeTypeDeclarationCollection;
    class function CreateRemote(const MachineName: string): _CodeTypeDeclarationCollection;
  end;

// *********************************************************************//
// The Class CoCodeNamespaceImportCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeNamespaceImportCollection exposed by              
// the CoClass CodeNamespaceImportCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeNamespaceImportCollection = class
    class function Create: _CodeNamespaceImportCollection;
    class function CreateRemote(const MachineName: string): _CodeNamespaceImportCollection;
  end;

// *********************************************************************//
// The Class CoCodeNamespaceImport provides a Create and CreateRemote method to          
// create instances of the default interface _CodeNamespaceImport exposed by              
// the CoClass CodeNamespaceImport. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeNamespaceImport = class
    class function Create: _CodeNamespaceImport;
    class function CreateRemote(const MachineName: string): _CodeNamespaceImport;
  end;

// *********************************************************************//
// The Class CoCodeObjectCreateExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeObjectCreateExpression exposed by              
// the CoClass CodeObjectCreateExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeObjectCreateExpression = class
    class function Create: _CodeObjectCreateExpression;
    class function CreateRemote(const MachineName: string): _CodeObjectCreateExpression;
  end;

// *********************************************************************//
// The Class CoCodeParameterDeclarationExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeParameterDeclarationExpression exposed by              
// the CoClass CodeParameterDeclarationExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeParameterDeclarationExpression = class
    class function Create: _CodeParameterDeclarationExpression;
    class function CreateRemote(const MachineName: string): _CodeParameterDeclarationExpression;
  end;

// *********************************************************************//
// The Class CoCodePrimitiveExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodePrimitiveExpression exposed by              
// the CoClass CodePrimitiveExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodePrimitiveExpression = class
    class function Create: _CodePrimitiveExpression;
    class function CreateRemote(const MachineName: string): _CodePrimitiveExpression;
  end;

// *********************************************************************//
// The Class CoCodePropertyReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodePropertyReferenceExpression exposed by              
// the CoClass CodePropertyReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodePropertyReferenceExpression = class
    class function Create: _CodePropertyReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodePropertyReferenceExpression;
  end;

// *********************************************************************//
// The Class CoCodePropertySetValueReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodePropertySetValueReferenceExpression exposed by              
// the CoClass CodePropertySetValueReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodePropertySetValueReferenceExpression = class
    class function Create: _CodePropertySetValueReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodePropertySetValueReferenceExpression;
  end;

// *********************************************************************//
// The Class CoCodeRegionDirective provides a Create and CreateRemote method to          
// create instances of the default interface _CodeRegionDirective exposed by              
// the CoClass CodeRegionDirective. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeRegionDirective = class
    class function Create: _CodeRegionDirective;
    class function CreateRemote(const MachineName: string): _CodeRegionDirective;
  end;

// *********************************************************************//
// The Class CoCodeRemoveEventStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeRemoveEventStatement exposed by              
// the CoClass CodeRemoveEventStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeRemoveEventStatement = class
    class function Create: _CodeRemoveEventStatement;
    class function CreateRemote(const MachineName: string): _CodeRemoveEventStatement;
  end;

// *********************************************************************//
// The Class CoCodeSnippetCompileUnit provides a Create and CreateRemote method to          
// create instances of the default interface _CodeSnippetCompileUnit exposed by              
// the CoClass CodeSnippetCompileUnit. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeSnippetCompileUnit = class
    class function Create: _CodeSnippetCompileUnit;
    class function CreateRemote(const MachineName: string): _CodeSnippetCompileUnit;
  end;

// *********************************************************************//
// The Class CoCodeSnippetExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeSnippetExpression exposed by              
// the CoClass CodeSnippetExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeSnippetExpression = class
    class function Create: _CodeSnippetExpression;
    class function CreateRemote(const MachineName: string): _CodeSnippetExpression;
  end;

// *********************************************************************//
// The Class CoCodeSnippetStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeSnippetStatement exposed by              
// the CoClass CodeSnippetStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeSnippetStatement = class
    class function Create: _CodeSnippetStatement;
    class function CreateRemote(const MachineName: string): _CodeSnippetStatement;
  end;

// *********************************************************************//
// The Class CoCodeSnippetTypeMember provides a Create and CreateRemote method to          
// create instances of the default interface _CodeSnippetTypeMember exposed by              
// the CoClass CodeSnippetTypeMember. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeSnippetTypeMember = class
    class function Create: _CodeSnippetTypeMember;
    class function CreateRemote(const MachineName: string): _CodeSnippetTypeMember;
  end;

// *********************************************************************//
// The Class CoCodeThisReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeThisReferenceExpression exposed by              
// the CoClass CodeThisReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeThisReferenceExpression = class
    class function Create: _CodeThisReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodeThisReferenceExpression;
  end;

// *********************************************************************//
// The Class CoCodeThrowExceptionStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeThrowExceptionStatement exposed by              
// the CoClass CodeThrowExceptionStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeThrowExceptionStatement = class
    class function Create: _CodeThrowExceptionStatement;
    class function CreateRemote(const MachineName: string): _CodeThrowExceptionStatement;
  end;

// *********************************************************************//
// The Class CoCodeTryCatchFinallyStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTryCatchFinallyStatement exposed by              
// the CoClass CodeTryCatchFinallyStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTryCatchFinallyStatement = class
    class function Create: _CodeTryCatchFinallyStatement;
    class function CreateRemote(const MachineName: string): _CodeTryCatchFinallyStatement;
  end;

// *********************************************************************//
// The Class CoCodeTypeConstructor provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeConstructor exposed by              
// the CoClass CodeTypeConstructor. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeConstructor = class
    class function Create: _CodeTypeConstructor;
    class function CreateRemote(const MachineName: string): _CodeTypeConstructor;
  end;

// *********************************************************************//
// The Class CoCodeTypeDeclaration provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeDeclaration exposed by              
// the CoClass CodeTypeDeclaration. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeDeclaration = class
    class function Create: _CodeTypeDeclaration;
    class function CreateRemote(const MachineName: string): _CodeTypeDeclaration;
  end;

// *********************************************************************//
// The Class CoCodeTypeMemberCollection provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeMemberCollection exposed by              
// the CoClass CodeTypeMemberCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeMemberCollection = class
    class function Create: _CodeTypeMemberCollection;
    class function CreateRemote(const MachineName: string): _CodeTypeMemberCollection;
  end;

// *********************************************************************//
// The Class CoCodeTypeDelegate provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeDelegate exposed by              
// the CoClass CodeTypeDelegate. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeDelegate = class
    class function Create: _CodeTypeDelegate;
    class function CreateRemote(const MachineName: string): _CodeTypeDelegate;
  end;

// *********************************************************************//
// The Class CoCodeTypeOfExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeOfExpression exposed by              
// the CoClass CodeTypeOfExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeOfExpression = class
    class function Create: _CodeTypeOfExpression;
    class function CreateRemote(const MachineName: string): _CodeTypeOfExpression;
  end;

// *********************************************************************//
// The Class CoCodeTypeParameter provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeParameter exposed by              
// the CoClass CodeTypeParameter. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeParameter = class
    class function Create: _CodeTypeParameter;
    class function CreateRemote(const MachineName: string): _CodeTypeParameter;
  end;

// *********************************************************************//
// The Class CoCodeTypeReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeTypeReferenceExpression exposed by              
// the CoClass CodeTypeReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeTypeReferenceExpression = class
    class function Create: _CodeTypeReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodeTypeReferenceExpression;
  end;

// *********************************************************************//
// The Class CoCodeVariableDeclarationStatement provides a Create and CreateRemote method to          
// create instances of the default interface _CodeVariableDeclarationStatement exposed by              
// the CoClass CodeVariableDeclarationStatement. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeVariableDeclarationStatement = class
    class function Create: _CodeVariableDeclarationStatement;
    class function CreateRemote(const MachineName: string): _CodeVariableDeclarationStatement;
  end;

// *********************************************************************//
// The Class CoCodeVariableReferenceExpression provides a Create and CreateRemote method to          
// create instances of the default interface _CodeVariableReferenceExpression exposed by              
// the CoClass CodeVariableReferenceExpression. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCodeVariableReferenceExpression = class
    class function Create: _CodeVariableReferenceExpression;
    class function CreateRemote(const MachineName: string): _CodeVariableReferenceExpression;
  end;

// *********************************************************************//
// The Class Cocomponent provides a Create and CreateRemote method to          
// create instances of the default interface _Component exposed by              
// the CoClass component. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  Cocomponent = class
    class function Create: _Component;
    class function CreateRemote(const MachineName: string): _Component;
  end;

// *********************************************************************//
// The Class CoAttributeCollection provides a Create and CreateRemote method to          
// create instances of the default interface _AttributeCollection exposed by              
// the CoClass AttributeCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoAttributeCollection = class
    class function Create: _AttributeCollection;
    class function CreateRemote(const MachineName: string): _AttributeCollection;
  end;

// *********************************************************************//
// The Class CoPropertyDescriptor provides a Create and CreateRemote method to          
// create instances of the default interface _PropertyDescriptor exposed by              
// the CoClass PropertyDescriptor. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoPropertyDescriptor = class
    class function Create: _PropertyDescriptor;
    class function CreateRemote(const MachineName: string): _PropertyDescriptor;
  end;

// *********************************************************************//
// The Class CoComponentCollection provides a Create and CreateRemote method to          
// create instances of the default interface _ComponentCollection exposed by              
// the CoClass ComponentCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoComponentCollection = class
    class function Create: _ComponentCollection;
    class function CreateRemote(const MachineName: string): _ComponentCollection;
  end;

// *********************************************************************//
// The Class CoEventDescriptor provides a Create and CreateRemote method to          
// create instances of the default interface _EventDescriptor exposed by              
// the CoClass EventDescriptor. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoEventDescriptor = class
    class function Create: _EventDescriptor;
    class function CreateRemote(const MachineName: string): _EventDescriptor;
  end;

// *********************************************************************//
// The Class CoEventDescriptorCollection provides a Create and CreateRemote method to          
// create instances of the default interface _EventDescriptorCollection exposed by              
// the CoClass EventDescriptorCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoEventDescriptorCollection = class
    class function Create: _EventDescriptorCollection;
    class function CreateRemote(const MachineName: string): _EventDescriptorCollection;
  end;

// *********************************************************************//
// The Class CoMemberDescriptor provides a Create and CreateRemote method to          
// create instances of the default interface _MemberDescriptor exposed by              
// the CoClass MemberDescriptor. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoMemberDescriptor = class
    class function Create: _MemberDescriptor;
    class function CreateRemote(const MachineName: string): _MemberDescriptor;
  end;

// *********************************************************************//
// The Class CoMarshalByValueComponent provides a Create and CreateRemote method to          
// create instances of the default interface _MarshalByValueComponent exposed by              
// the CoClass MarshalByValueComponent. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoMarshalByValueComponent = class
    class function Create: _MarshalByValueComponent;
    class function CreateRemote(const MachineName: string): _MarshalByValueComponent;
  end;

// *********************************************************************//
// The Class CoCommandID provides a Create and CreateRemote method to          
// create instances of the default interface _CommandID exposed by              
// the CoClass CommandID. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoCommandID = class
    class function Create: _CommandID;
    class function CreateRemote(const MachineName: string): _CommandID;
  end;

// *********************************************************************//
// The Class CoComponentChangedEventArgs provides a Create and CreateRemote method to          
// create instances of the default interface _ComponentChangedEventArgs exposed by              
// the CoClass ComponentChangedEventArgs. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoComponentChangedEventArgs = class
    class function Create: _ComponentChangedEventArgs;
    class function CreateRemote(const MachineName: string): _ComponentChangedEventArgs;
  end;

// *********************************************************************//
// The Class CoComponentChangedEventHandler provides a Create and CreateRemote method to          
// create instances of the default interface _ComponentChangedEventHandler exposed by              
// the CoClass ComponentChangedEventHandler. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoComponentChangedEventHandler = class
    class function Create: _ComponentChangedEventHandler;
    class function CreateRemote(const MachineName: string): _ComponentChangedEventHandler;
  end;

// *********************************************************************//
// The Class CoComponentChangingEventArgs provides a Create and CreateRemote method to          
// create instances of the default interface _ComponentChangingEventArgs exposed by              
// the CoClass ComponentChangingEventArgs. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoComponentChangingEventArgs = class
    class function Create: _ComponentChangingEventArgs;
    class function CreateRemote(const MachineName: string): _ComponentChangingEventArgs;
  end;

// *********************************************************************//
// The Class CoComponentChangingEventHandler provides a Create and CreateRemote method to          
// create instances of the default interface _ComponentChangingEventHandler exposed by              
// the CoClass ComponentChangingEventHandler. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoComponentChangingEventHandler = class
    class function Create: _ComponentChangingEventHandler;
    class function CreateRemote(const MachineName: string): _ComponentChangingEventHandler;
  end;

// *********************************************************************//
// The Class CoComponentEventArgs provides a Create and CreateRemote method to          
// create instances of the default interface _ComponentEventArgs exposed by              
// the CoClass ComponentEventArgs. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoComponentEventArgs = class
    class function Create: _ComponentEventArgs;
    class function CreateRemote(const MachineName: string): _ComponentEventArgs;
  end;

// *********************************************************************//
// The Class CoComponentEventHandler provides a Create and CreateRemote method to          
// create instances of the default interface _ComponentEventHandler exposed by              
// the CoClass ComponentEventHandler. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoComponentEventHandler = class
    class function Create: _ComponentEventHandler;
    class function CreateRemote(const MachineName: string): _ComponentEventHandler;
  end;

// *********************************************************************//
// The Class CoComponentRenameEventArgs provides a Create and CreateRemote method to          
// create instances of the default interface _ComponentRenameEventArgs exposed by              
// the CoClass ComponentRenameEventArgs. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoComponentRenameEventArgs = class
    class function Create: _ComponentRenameEventArgs;
    class function CreateRemote(const MachineName: string): _ComponentRenameEventArgs;
  end;

// *********************************************************************//
// The Class CoComponentRenameEventHandler provides a Create and CreateRemote method to          
// create instances of the default interface _ComponentRenameEventHandler exposed by              
// the CoClass ComponentRenameEventHandler. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoComponentRenameEventHandler = class
    class function Create: _ComponentRenameEventHandler;
    class function CreateRemote(const MachineName: string): _ComponentRenameEventHandler;
  end;

// *********************************************************************//
// The Class CoDesignerTransactionCloseEventArgs provides a Create and CreateRemote method to          
// create instances of the default interface _DesignerTransactionCloseEventArgs exposed by              
// the CoClass DesignerTransactionCloseEventArgs. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoDesignerTransactionCloseEventArgs = class
    class function Create: _DesignerTransactionCloseEventArgs;
    class function CreateRemote(const MachineName: string): _DesignerTransactionCloseEventArgs;
  end;

// *********************************************************************//
// The Class CoDesignerTransactionCloseEventHandler provides a Create and CreateRemote method to          
// create instances of the default interface _DesignerTransactionCloseEventHandler exposed by              
// the CoClass DesignerTransactionCloseEventHandler. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoDesignerTransactionCloseEventHandler = class
    class function Create: _DesignerTransactionCloseEventHandler;
    class function CreateRemote(const MachineName: string): _DesignerTransactionCloseEventHandler;
  end;

// *********************************************************************//
// The Class CoDesignerVerb provides a Create and CreateRemote method to          
// create instances of the default interface _DesignerVerb exposed by              
// the CoClass DesignerVerb. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoDesignerVerb = class
    class function Create: _DesignerVerb;
    class function CreateRemote(const MachineName: string): _DesignerVerb;
  end;

// *********************************************************************//
// The Class CoMenuCommand provides a Create and CreateRemote method to          
// create instances of the default interface _MenuCommand exposed by              
// the CoClass MenuCommand. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoMenuCommand = class
    class function Create: _MenuCommand;
    class function CreateRemote(const MachineName: string): _MenuCommand;
  end;

// *********************************************************************//
// The Class CoDesignerVerbCollection provides a Create and CreateRemote method to          
// create instances of the default interface _DesignerVerbCollection exposed by              
// the CoClass DesignerVerbCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoDesignerVerbCollection = class
    class function Create: _DesignerVerbCollection;
    class function CreateRemote(const MachineName: string): _DesignerVerbCollection;
  end;

// *********************************************************************//
// The Class CoServiceCreatorCallback provides a Create and CreateRemote method to          
// create instances of the default interface _ServiceCreatorCallback exposed by              
// the CoClass ServiceCreatorCallback. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoServiceCreatorCallback = class
    class function Create: _ServiceCreatorCallback;
    class function CreateRemote(const MachineName: string): _ServiceCreatorCallback;
  end;

// *********************************************************************//
// The Class CoDesignerLoader provides a Create and CreateRemote method to          
// create instances of the default interface _DesignerLoader exposed by              
// the CoClass DesignerLoader. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoDesignerLoader = class
    class function Create: _DesignerLoader;
    class function CreateRemote(const MachineName: string): _DesignerLoader;
  end;

// *********************************************************************//
// The Class CoPerformanceCounterManager provides a Create and CreateRemote method to          
// create instances of the default interface _PerformanceCounterManager exposed by              
// the CoClass PerformanceCounterManager. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoPerformanceCounterManager = class
    class function Create: _PerformanceCounterManager;
    class function CreateRemote(const MachineName: string): _PerformanceCounterManager;
  end;

// *********************************************************************//
// The Class CoWebHeaderCollection provides a Create and CreateRemote method to          
// create instances of the default interface _WebHeaderCollection exposed by              
// the CoClass WebHeaderCollection. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoWebHeaderCollection = class
    class function Create: _WebHeaderCollection;
    class function CreateRemote(const MachineName: string): _WebHeaderCollection;
  end;

// *********************************************************************//
// The Class CoWebClient provides a Create and CreateRemote method to          
// create instances of the default interface _WebClient exposed by              
// the CoClass WebClient. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoWebClient = class
    class function Create: _WebClient;
    class function CreateRemote(const MachineName: string): _WebClient;
  end;

// *********************************************************************//
// The Class CoStandardOleMarshalObject provides a Create and CreateRemote method to          
// create instances of the default interface _StandardOleMarshalObject exposed by              
// the CoClass StandardOleMarshalObject. The functions are intended to be used by             
// clients wishing to automate the CoClass objects exposed by the         
// server of this typelibrary.                                            
// *********************************************************************//
  CoStandardOleMarshalObject = class
    class function Create: _StandardOleMarshalObject;
    class function CreateRemote(const MachineName: string): _StandardOleMarshalObject;
  end;

implementation

uses ComObj;

class function CoCodeDomProvider.Create: _CodeDomProvider;
begin
  Result := CreateComObject(CLASS_CodeDomProvider) as _CodeDomProvider;
end;

class function CoCodeDomProvider.CreateRemote(const MachineName: string): _CodeDomProvider;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeDomProvider) as _CodeDomProvider;
end;

class function CoTypeConverter.Create: _TypeConverter;
begin
  Result := CreateComObject(CLASS_TypeConverter) as _TypeConverter;
end;

class function CoTypeConverter.CreateRemote(const MachineName: string): _TypeConverter;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_TypeConverter) as _TypeConverter;
end;

class function CoCodeTypeMember.Create: _CodeTypeMember;
begin
  Result := CreateComObject(CLASS_CodeTypeMember) as _CodeTypeMember;
end;

class function CoCodeTypeMember.CreateRemote(const MachineName: string): _CodeTypeMember;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeMember) as _CodeTypeMember;
end;

class function CoCodeArgumentReferenceExpression.Create: _CodeArgumentReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodeArgumentReferenceExpression) as _CodeArgumentReferenceExpression;
end;

class function CoCodeArgumentReferenceExpression.CreateRemote(const MachineName: string): _CodeArgumentReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeArgumentReferenceExpression) as _CodeArgumentReferenceExpression;
end;

class function CoCodeExpression.Create: _CodeExpression;
begin
  Result := CreateComObject(CLASS_CodeExpression) as _CodeExpression;
end;

class function CoCodeExpression.CreateRemote(const MachineName: string): _CodeExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeExpression) as _CodeExpression;
end;

class function CoCodeArrayCreateExpression.Create: _CodeArrayCreateExpression;
begin
  Result := CreateComObject(CLASS_CodeArrayCreateExpression) as _CodeArrayCreateExpression;
end;

class function CoCodeArrayCreateExpression.CreateRemote(const MachineName: string): _CodeArrayCreateExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeArrayCreateExpression) as _CodeArrayCreateExpression;
end;

class function CoCodeTypeReference.Create: _CodeTypeReference;
begin
  Result := CreateComObject(CLASS_CodeTypeReference) as _CodeTypeReference;
end;

class function CoCodeTypeReference.CreateRemote(const MachineName: string): _CodeTypeReference;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeReference) as _CodeTypeReference;
end;

class function CoCodeExpressionCollection.Create: _CodeExpressionCollection;
begin
  Result := CreateComObject(CLASS_CodeExpressionCollection) as _CodeExpressionCollection;
end;

class function CoCodeExpressionCollection.CreateRemote(const MachineName: string): _CodeExpressionCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeExpressionCollection) as _CodeExpressionCollection;
end;

class function CoCodeArrayIndexerExpression.Create: _CodeArrayIndexerExpression;
begin
  Result := CreateComObject(CLASS_CodeArrayIndexerExpression) as _CodeArrayIndexerExpression;
end;

class function CoCodeArrayIndexerExpression.CreateRemote(const MachineName: string): _CodeArrayIndexerExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeArrayIndexerExpression) as _CodeArrayIndexerExpression;
end;

class function CoCodeAssignStatement.Create: _CodeAssignStatement;
begin
  Result := CreateComObject(CLASS_CodeAssignStatement) as _CodeAssignStatement;
end;

class function CoCodeAssignStatement.CreateRemote(const MachineName: string): _CodeAssignStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeAssignStatement) as _CodeAssignStatement;
end;

class function CoCodeStatement.Create: _CodeStatement;
begin
  Result := CreateComObject(CLASS_CodeStatement) as _CodeStatement;
end;

class function CoCodeStatement.CreateRemote(const MachineName: string): _CodeStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeStatement) as _CodeStatement;
end;

class function CoCodeAttachEventStatement.Create: _CodeAttachEventStatement;
begin
  Result := CreateComObject(CLASS_CodeAttachEventStatement) as _CodeAttachEventStatement;
end;

class function CoCodeAttachEventStatement.CreateRemote(const MachineName: string): _CodeAttachEventStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeAttachEventStatement) as _CodeAttachEventStatement;
end;

class function CoCodeEventReferenceExpression.Create: _CodeEventReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodeEventReferenceExpression) as _CodeEventReferenceExpression;
end;

class function CoCodeEventReferenceExpression.CreateRemote(const MachineName: string): _CodeEventReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeEventReferenceExpression) as _CodeEventReferenceExpression;
end;

class function CoCodeAttributeArgument.Create: _CodeAttributeArgument;
begin
  Result := CreateComObject(CLASS_CodeAttributeArgument) as _CodeAttributeArgument;
end;

class function CoCodeAttributeArgument.CreateRemote(const MachineName: string): _CodeAttributeArgument;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeAttributeArgument) as _CodeAttributeArgument;
end;

class function CoCodeAttributeArgumentCollection.Create: _CodeAttributeArgumentCollection;
begin
  Result := CreateComObject(CLASS_CodeAttributeArgumentCollection) as _CodeAttributeArgumentCollection;
end;

class function CoCodeAttributeArgumentCollection.CreateRemote(const MachineName: string): _CodeAttributeArgumentCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeAttributeArgumentCollection) as _CodeAttributeArgumentCollection;
end;

class function CoCodeAttributeDeclaration.Create: _CodeAttributeDeclaration;
begin
  Result := CreateComObject(CLASS_CodeAttributeDeclaration) as _CodeAttributeDeclaration;
end;

class function CoCodeAttributeDeclaration.CreateRemote(const MachineName: string): _CodeAttributeDeclaration;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeAttributeDeclaration) as _CodeAttributeDeclaration;
end;

class function CoCodeAttributeDeclarationCollection.Create: _CodeAttributeDeclarationCollection;
begin
  Result := CreateComObject(CLASS_CodeAttributeDeclarationCollection) as _CodeAttributeDeclarationCollection;
end;

class function CoCodeAttributeDeclarationCollection.CreateRemote(const MachineName: string): _CodeAttributeDeclarationCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeAttributeDeclarationCollection) as _CodeAttributeDeclarationCollection;
end;

class function CoCodeBaseReferenceExpression.Create: _CodeBaseReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodeBaseReferenceExpression) as _CodeBaseReferenceExpression;
end;

class function CoCodeBaseReferenceExpression.CreateRemote(const MachineName: string): _CodeBaseReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeBaseReferenceExpression) as _CodeBaseReferenceExpression;
end;

class function CoCodeBinaryOperatorExpression.Create: _CodeBinaryOperatorExpression;
begin
  Result := CreateComObject(CLASS_CodeBinaryOperatorExpression) as _CodeBinaryOperatorExpression;
end;

class function CoCodeBinaryOperatorExpression.CreateRemote(const MachineName: string): _CodeBinaryOperatorExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeBinaryOperatorExpression) as _CodeBinaryOperatorExpression;
end;

class function CoCodeCastExpression.Create: _CodeCastExpression;
begin
  Result := CreateComObject(CLASS_CodeCastExpression) as _CodeCastExpression;
end;

class function CoCodeCastExpression.CreateRemote(const MachineName: string): _CodeCastExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeCastExpression) as _CodeCastExpression;
end;

class function CoCodeCatchClause.Create: _CodeCatchClause;
begin
  Result := CreateComObject(CLASS_CodeCatchClause) as _CodeCatchClause;
end;

class function CoCodeCatchClause.CreateRemote(const MachineName: string): _CodeCatchClause;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeCatchClause) as _CodeCatchClause;
end;

class function CoCodeStatementCollection.Create: _CodeStatementCollection;
begin
  Result := CreateComObject(CLASS_CodeStatementCollection) as _CodeStatementCollection;
end;

class function CoCodeStatementCollection.CreateRemote(const MachineName: string): _CodeStatementCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeStatementCollection) as _CodeStatementCollection;
end;

class function CoCodeCatchClauseCollection.Create: _CodeCatchClauseCollection;
begin
  Result := CreateComObject(CLASS_CodeCatchClauseCollection) as _CodeCatchClauseCollection;
end;

class function CoCodeCatchClauseCollection.CreateRemote(const MachineName: string): _CodeCatchClauseCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeCatchClauseCollection) as _CodeCatchClauseCollection;
end;

class function CoCodeChecksumPragma.Create: _CodeChecksumPragma;
begin
  Result := CreateComObject(CLASS_CodeChecksumPragma) as _CodeChecksumPragma;
end;

class function CoCodeChecksumPragma.CreateRemote(const MachineName: string): _CodeChecksumPragma;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeChecksumPragma) as _CodeChecksumPragma;
end;

class function CoCodeDirective.Create: _CodeDirective;
begin
  Result := CreateComObject(CLASS_CodeDirective) as _CodeDirective;
end;

class function CoCodeDirective.CreateRemote(const MachineName: string): _CodeDirective;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeDirective) as _CodeDirective;
end;

class function CoCodeComment.Create: _CodeComment;
begin
  Result := CreateComObject(CLASS_CodeComment) as _CodeComment;
end;

class function CoCodeComment.CreateRemote(const MachineName: string): _CodeComment;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeComment) as _CodeComment;
end;

class function CoCodeObject.Create: _CodeObject;
begin
  Result := CreateComObject(CLASS_CodeObject) as _CodeObject;
end;

class function CoCodeObject.CreateRemote(const MachineName: string): _CodeObject;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeObject) as _CodeObject;
end;

class function CoCodeCommentStatement.Create: _CodeCommentStatement;
begin
  Result := CreateComObject(CLASS_CodeCommentStatement) as _CodeCommentStatement;
end;

class function CoCodeCommentStatement.CreateRemote(const MachineName: string): _CodeCommentStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeCommentStatement) as _CodeCommentStatement;
end;

class function CoCodeCommentStatementCollection.Create: _CodeCommentStatementCollection;
begin
  Result := CreateComObject(CLASS_CodeCommentStatementCollection) as _CodeCommentStatementCollection;
end;

class function CoCodeCommentStatementCollection.CreateRemote(const MachineName: string): _CodeCommentStatementCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeCommentStatementCollection) as _CodeCommentStatementCollection;
end;

class function CoCodeCompileUnit.Create: _CodeCompileUnit;
begin
  Result := CreateComObject(CLASS_CodeCompileUnit) as _CodeCompileUnit;
end;

class function CoCodeCompileUnit.CreateRemote(const MachineName: string): _CodeCompileUnit;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeCompileUnit) as _CodeCompileUnit;
end;

class function CoCodeNamespaceCollection.Create: _CodeNamespaceCollection;
begin
  Result := CreateComObject(CLASS_CodeNamespaceCollection) as _CodeNamespaceCollection;
end;

class function CoCodeNamespaceCollection.CreateRemote(const MachineName: string): _CodeNamespaceCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeNamespaceCollection) as _CodeNamespaceCollection;
end;

class function CoCodeDirectiveCollection.Create: _CodeDirectiveCollection;
begin
  Result := CreateComObject(CLASS_CodeDirectiveCollection) as _CodeDirectiveCollection;
end;

class function CoCodeDirectiveCollection.CreateRemote(const MachineName: string): _CodeDirectiveCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeDirectiveCollection) as _CodeDirectiveCollection;
end;

class function CoCodeConditionStatement.Create: _CodeConditionStatement;
begin
  Result := CreateComObject(CLASS_CodeConditionStatement) as _CodeConditionStatement;
end;

class function CoCodeConditionStatement.CreateRemote(const MachineName: string): _CodeConditionStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeConditionStatement) as _CodeConditionStatement;
end;

class function CoCodeConstructor.Create: _CodeConstructor;
begin
  Result := CreateComObject(CLASS_CodeConstructor) as _CodeConstructor;
end;

class function CoCodeConstructor.CreateRemote(const MachineName: string): _CodeConstructor;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeConstructor) as _CodeConstructor;
end;

class function CoCodeMemberMethod.Create: _CodeMemberMethod;
begin
  Result := CreateComObject(CLASS_CodeMemberMethod) as _CodeMemberMethod;
end;

class function CoCodeMemberMethod.CreateRemote(const MachineName: string): _CodeMemberMethod;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeMemberMethod) as _CodeMemberMethod;
end;

class function CoCodeDefaultValueExpression.Create: _CodeDefaultValueExpression;
begin
  Result := CreateComObject(CLASS_CodeDefaultValueExpression) as _CodeDefaultValueExpression;
end;

class function CoCodeDefaultValueExpression.CreateRemote(const MachineName: string): _CodeDefaultValueExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeDefaultValueExpression) as _CodeDefaultValueExpression;
end;

class function CoCodeDelegateCreateExpression.Create: _CodeDelegateCreateExpression;
begin
  Result := CreateComObject(CLASS_CodeDelegateCreateExpression) as _CodeDelegateCreateExpression;
end;

class function CoCodeDelegateCreateExpression.CreateRemote(const MachineName: string): _CodeDelegateCreateExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeDelegateCreateExpression) as _CodeDelegateCreateExpression;
end;

class function CoCodeDelegateInvokeExpression.Create: _CodeDelegateInvokeExpression;
begin
  Result := CreateComObject(CLASS_CodeDelegateInvokeExpression) as _CodeDelegateInvokeExpression;
end;

class function CoCodeDelegateInvokeExpression.CreateRemote(const MachineName: string): _CodeDelegateInvokeExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeDelegateInvokeExpression) as _CodeDelegateInvokeExpression;
end;

class function CoCodeDirectionExpression.Create: _CodeDirectionExpression;
begin
  Result := CreateComObject(CLASS_CodeDirectionExpression) as _CodeDirectionExpression;
end;

class function CoCodeDirectionExpression.CreateRemote(const MachineName: string): _CodeDirectionExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeDirectionExpression) as _CodeDirectionExpression;
end;

class function CoCodeEntryPointMethod.Create: _CodeEntryPointMethod;
begin
  Result := CreateComObject(CLASS_CodeEntryPointMethod) as _CodeEntryPointMethod;
end;

class function CoCodeEntryPointMethod.CreateRemote(const MachineName: string): _CodeEntryPointMethod;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeEntryPointMethod) as _CodeEntryPointMethod;
end;

class function CoCodeExpressionStatement.Create: _CodeExpressionStatement;
begin
  Result := CreateComObject(CLASS_CodeExpressionStatement) as _CodeExpressionStatement;
end;

class function CoCodeExpressionStatement.CreateRemote(const MachineName: string): _CodeExpressionStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeExpressionStatement) as _CodeExpressionStatement;
end;

class function CoCodeFieldReferenceExpression.Create: _CodeFieldReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodeFieldReferenceExpression) as _CodeFieldReferenceExpression;
end;

class function CoCodeFieldReferenceExpression.CreateRemote(const MachineName: string): _CodeFieldReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeFieldReferenceExpression) as _CodeFieldReferenceExpression;
end;

class function CoCodeGotoStatement.Create: _CodeGotoStatement;
begin
  Result := CreateComObject(CLASS_CodeGotoStatement) as _CodeGotoStatement;
end;

class function CoCodeGotoStatement.CreateRemote(const MachineName: string): _CodeGotoStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeGotoStatement) as _CodeGotoStatement;
end;

class function CoCodeIndexerExpression.Create: _CodeIndexerExpression;
begin
  Result := CreateComObject(CLASS_CodeIndexerExpression) as _CodeIndexerExpression;
end;

class function CoCodeIndexerExpression.CreateRemote(const MachineName: string): _CodeIndexerExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeIndexerExpression) as _CodeIndexerExpression;
end;

class function CoCodeIterationStatement.Create: _CodeIterationStatement;
begin
  Result := CreateComObject(CLASS_CodeIterationStatement) as _CodeIterationStatement;
end;

class function CoCodeIterationStatement.CreateRemote(const MachineName: string): _CodeIterationStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeIterationStatement) as _CodeIterationStatement;
end;

class function CoCodeLabeledStatement.Create: _CodeLabeledStatement;
begin
  Result := CreateComObject(CLASS_CodeLabeledStatement) as _CodeLabeledStatement;
end;

class function CoCodeLabeledStatement.CreateRemote(const MachineName: string): _CodeLabeledStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeLabeledStatement) as _CodeLabeledStatement;
end;

class function CoCodeLinePragma.Create: _CodeLinePragma;
begin
  Result := CreateComObject(CLASS_CodeLinePragma) as _CodeLinePragma;
end;

class function CoCodeLinePragma.CreateRemote(const MachineName: string): _CodeLinePragma;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeLinePragma) as _CodeLinePragma;
end;

class function CoCodeMemberEvent.Create: _CodeMemberEvent;
begin
  Result := CreateComObject(CLASS_CodeMemberEvent) as _CodeMemberEvent;
end;

class function CoCodeMemberEvent.CreateRemote(const MachineName: string): _CodeMemberEvent;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeMemberEvent) as _CodeMemberEvent;
end;

class function CoCodeTypeReferenceCollection.Create: _CodeTypeReferenceCollection;
begin
  Result := CreateComObject(CLASS_CodeTypeReferenceCollection) as _CodeTypeReferenceCollection;
end;

class function CoCodeTypeReferenceCollection.CreateRemote(const MachineName: string): _CodeTypeReferenceCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeReferenceCollection) as _CodeTypeReferenceCollection;
end;

class function CoCodeMemberField.Create: _CodeMemberField;
begin
  Result := CreateComObject(CLASS_CodeMemberField) as _CodeMemberField;
end;

class function CoCodeMemberField.CreateRemote(const MachineName: string): _CodeMemberField;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeMemberField) as _CodeMemberField;
end;

class function CoCodeParameterDeclarationExpressionCollection.Create: _CodeParameterDeclarationExpressionCollection;
begin
  Result := CreateComObject(CLASS_CodeParameterDeclarationExpressionCollection) as _CodeParameterDeclarationExpressionCollection;
end;

class function CoCodeParameterDeclarationExpressionCollection.CreateRemote(const MachineName: string): _CodeParameterDeclarationExpressionCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeParameterDeclarationExpressionCollection) as _CodeParameterDeclarationExpressionCollection;
end;

class function CoCodeTypeParameterCollection.Create: _CodeTypeParameterCollection;
begin
  Result := CreateComObject(CLASS_CodeTypeParameterCollection) as _CodeTypeParameterCollection;
end;

class function CoCodeTypeParameterCollection.CreateRemote(const MachineName: string): _CodeTypeParameterCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeParameterCollection) as _CodeTypeParameterCollection;
end;

class function CoCodeMemberProperty.Create: _CodeMemberProperty;
begin
  Result := CreateComObject(CLASS_CodeMemberProperty) as _CodeMemberProperty;
end;

class function CoCodeMemberProperty.CreateRemote(const MachineName: string): _CodeMemberProperty;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeMemberProperty) as _CodeMemberProperty;
end;

class function CoCodeMethodInvokeExpression.Create: _CodeMethodInvokeExpression;
begin
  Result := CreateComObject(CLASS_CodeMethodInvokeExpression) as _CodeMethodInvokeExpression;
end;

class function CoCodeMethodInvokeExpression.CreateRemote(const MachineName: string): _CodeMethodInvokeExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeMethodInvokeExpression) as _CodeMethodInvokeExpression;
end;

class function CoCodeMethodReferenceExpression.Create: _CodeMethodReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodeMethodReferenceExpression) as _CodeMethodReferenceExpression;
end;

class function CoCodeMethodReferenceExpression.CreateRemote(const MachineName: string): _CodeMethodReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeMethodReferenceExpression) as _CodeMethodReferenceExpression;
end;

class function CoCodeMethodReturnStatement.Create: _CodeMethodReturnStatement;
begin
  Result := CreateComObject(CLASS_CodeMethodReturnStatement) as _CodeMethodReturnStatement;
end;

class function CoCodeMethodReturnStatement.CreateRemote(const MachineName: string): _CodeMethodReturnStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeMethodReturnStatement) as _CodeMethodReturnStatement;
end;

class function CoCodeNamespace.Create: _CodeNamespace;
begin
  Result := CreateComObject(CLASS_CodeNamespace) as _CodeNamespace;
end;

class function CoCodeNamespace.CreateRemote(const MachineName: string): _CodeNamespace;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeNamespace) as _CodeNamespace;
end;

class function CoCodeTypeDeclarationCollection.Create: _CodeTypeDeclarationCollection;
begin
  Result := CreateComObject(CLASS_CodeTypeDeclarationCollection) as _CodeTypeDeclarationCollection;
end;

class function CoCodeTypeDeclarationCollection.CreateRemote(const MachineName: string): _CodeTypeDeclarationCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeDeclarationCollection) as _CodeTypeDeclarationCollection;
end;

class function CoCodeNamespaceImportCollection.Create: _CodeNamespaceImportCollection;
begin
  Result := CreateComObject(CLASS_CodeNamespaceImportCollection) as _CodeNamespaceImportCollection;
end;

class function CoCodeNamespaceImportCollection.CreateRemote(const MachineName: string): _CodeNamespaceImportCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeNamespaceImportCollection) as _CodeNamespaceImportCollection;
end;

class function CoCodeNamespaceImport.Create: _CodeNamespaceImport;
begin
  Result := CreateComObject(CLASS_CodeNamespaceImport) as _CodeNamespaceImport;
end;

class function CoCodeNamespaceImport.CreateRemote(const MachineName: string): _CodeNamespaceImport;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeNamespaceImport) as _CodeNamespaceImport;
end;

class function CoCodeObjectCreateExpression.Create: _CodeObjectCreateExpression;
begin
  Result := CreateComObject(CLASS_CodeObjectCreateExpression) as _CodeObjectCreateExpression;
end;

class function CoCodeObjectCreateExpression.CreateRemote(const MachineName: string): _CodeObjectCreateExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeObjectCreateExpression) as _CodeObjectCreateExpression;
end;

class function CoCodeParameterDeclarationExpression.Create: _CodeParameterDeclarationExpression;
begin
  Result := CreateComObject(CLASS_CodeParameterDeclarationExpression) as _CodeParameterDeclarationExpression;
end;

class function CoCodeParameterDeclarationExpression.CreateRemote(const MachineName: string): _CodeParameterDeclarationExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeParameterDeclarationExpression) as _CodeParameterDeclarationExpression;
end;

class function CoCodePrimitiveExpression.Create: _CodePrimitiveExpression;
begin
  Result := CreateComObject(CLASS_CodePrimitiveExpression) as _CodePrimitiveExpression;
end;

class function CoCodePrimitiveExpression.CreateRemote(const MachineName: string): _CodePrimitiveExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodePrimitiveExpression) as _CodePrimitiveExpression;
end;

class function CoCodePropertyReferenceExpression.Create: _CodePropertyReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodePropertyReferenceExpression) as _CodePropertyReferenceExpression;
end;

class function CoCodePropertyReferenceExpression.CreateRemote(const MachineName: string): _CodePropertyReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodePropertyReferenceExpression) as _CodePropertyReferenceExpression;
end;

class function CoCodePropertySetValueReferenceExpression.Create: _CodePropertySetValueReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodePropertySetValueReferenceExpression) as _CodePropertySetValueReferenceExpression;
end;

class function CoCodePropertySetValueReferenceExpression.CreateRemote(const MachineName: string): _CodePropertySetValueReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodePropertySetValueReferenceExpression) as _CodePropertySetValueReferenceExpression;
end;

class function CoCodeRegionDirective.Create: _CodeRegionDirective;
begin
  Result := CreateComObject(CLASS_CodeRegionDirective) as _CodeRegionDirective;
end;

class function CoCodeRegionDirective.CreateRemote(const MachineName: string): _CodeRegionDirective;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeRegionDirective) as _CodeRegionDirective;
end;

class function CoCodeRemoveEventStatement.Create: _CodeRemoveEventStatement;
begin
  Result := CreateComObject(CLASS_CodeRemoveEventStatement) as _CodeRemoveEventStatement;
end;

class function CoCodeRemoveEventStatement.CreateRemote(const MachineName: string): _CodeRemoveEventStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeRemoveEventStatement) as _CodeRemoveEventStatement;
end;

class function CoCodeSnippetCompileUnit.Create: _CodeSnippetCompileUnit;
begin
  Result := CreateComObject(CLASS_CodeSnippetCompileUnit) as _CodeSnippetCompileUnit;
end;

class function CoCodeSnippetCompileUnit.CreateRemote(const MachineName: string): _CodeSnippetCompileUnit;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeSnippetCompileUnit) as _CodeSnippetCompileUnit;
end;

class function CoCodeSnippetExpression.Create: _CodeSnippetExpression;
begin
  Result := CreateComObject(CLASS_CodeSnippetExpression) as _CodeSnippetExpression;
end;

class function CoCodeSnippetExpression.CreateRemote(const MachineName: string): _CodeSnippetExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeSnippetExpression) as _CodeSnippetExpression;
end;

class function CoCodeSnippetStatement.Create: _CodeSnippetStatement;
begin
  Result := CreateComObject(CLASS_CodeSnippetStatement) as _CodeSnippetStatement;
end;

class function CoCodeSnippetStatement.CreateRemote(const MachineName: string): _CodeSnippetStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeSnippetStatement) as _CodeSnippetStatement;
end;

class function CoCodeSnippetTypeMember.Create: _CodeSnippetTypeMember;
begin
  Result := CreateComObject(CLASS_CodeSnippetTypeMember) as _CodeSnippetTypeMember;
end;

class function CoCodeSnippetTypeMember.CreateRemote(const MachineName: string): _CodeSnippetTypeMember;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeSnippetTypeMember) as _CodeSnippetTypeMember;
end;

class function CoCodeThisReferenceExpression.Create: _CodeThisReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodeThisReferenceExpression) as _CodeThisReferenceExpression;
end;

class function CoCodeThisReferenceExpression.CreateRemote(const MachineName: string): _CodeThisReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeThisReferenceExpression) as _CodeThisReferenceExpression;
end;

class function CoCodeThrowExceptionStatement.Create: _CodeThrowExceptionStatement;
begin
  Result := CreateComObject(CLASS_CodeThrowExceptionStatement) as _CodeThrowExceptionStatement;
end;

class function CoCodeThrowExceptionStatement.CreateRemote(const MachineName: string): _CodeThrowExceptionStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeThrowExceptionStatement) as _CodeThrowExceptionStatement;
end;

class function CoCodeTryCatchFinallyStatement.Create: _CodeTryCatchFinallyStatement;
begin
  Result := CreateComObject(CLASS_CodeTryCatchFinallyStatement) as _CodeTryCatchFinallyStatement;
end;

class function CoCodeTryCatchFinallyStatement.CreateRemote(const MachineName: string): _CodeTryCatchFinallyStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTryCatchFinallyStatement) as _CodeTryCatchFinallyStatement;
end;

class function CoCodeTypeConstructor.Create: _CodeTypeConstructor;
begin
  Result := CreateComObject(CLASS_CodeTypeConstructor) as _CodeTypeConstructor;
end;

class function CoCodeTypeConstructor.CreateRemote(const MachineName: string): _CodeTypeConstructor;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeConstructor) as _CodeTypeConstructor;
end;

class function CoCodeTypeDeclaration.Create: _CodeTypeDeclaration;
begin
  Result := CreateComObject(CLASS_CodeTypeDeclaration) as _CodeTypeDeclaration;
end;

class function CoCodeTypeDeclaration.CreateRemote(const MachineName: string): _CodeTypeDeclaration;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeDeclaration) as _CodeTypeDeclaration;
end;

class function CoCodeTypeMemberCollection.Create: _CodeTypeMemberCollection;
begin
  Result := CreateComObject(CLASS_CodeTypeMemberCollection) as _CodeTypeMemberCollection;
end;

class function CoCodeTypeMemberCollection.CreateRemote(const MachineName: string): _CodeTypeMemberCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeMemberCollection) as _CodeTypeMemberCollection;
end;

class function CoCodeTypeDelegate.Create: _CodeTypeDelegate;
begin
  Result := CreateComObject(CLASS_CodeTypeDelegate) as _CodeTypeDelegate;
end;

class function CoCodeTypeDelegate.CreateRemote(const MachineName: string): _CodeTypeDelegate;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeDelegate) as _CodeTypeDelegate;
end;

class function CoCodeTypeOfExpression.Create: _CodeTypeOfExpression;
begin
  Result := CreateComObject(CLASS_CodeTypeOfExpression) as _CodeTypeOfExpression;
end;

class function CoCodeTypeOfExpression.CreateRemote(const MachineName: string): _CodeTypeOfExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeOfExpression) as _CodeTypeOfExpression;
end;

class function CoCodeTypeParameter.Create: _CodeTypeParameter;
begin
  Result := CreateComObject(CLASS_CodeTypeParameter) as _CodeTypeParameter;
end;

class function CoCodeTypeParameter.CreateRemote(const MachineName: string): _CodeTypeParameter;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeParameter) as _CodeTypeParameter;
end;

class function CoCodeTypeReferenceExpression.Create: _CodeTypeReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodeTypeReferenceExpression) as _CodeTypeReferenceExpression;
end;

class function CoCodeTypeReferenceExpression.CreateRemote(const MachineName: string): _CodeTypeReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeTypeReferenceExpression) as _CodeTypeReferenceExpression;
end;

class function CoCodeVariableDeclarationStatement.Create: _CodeVariableDeclarationStatement;
begin
  Result := CreateComObject(CLASS_CodeVariableDeclarationStatement) as _CodeVariableDeclarationStatement;
end;

class function CoCodeVariableDeclarationStatement.CreateRemote(const MachineName: string): _CodeVariableDeclarationStatement;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeVariableDeclarationStatement) as _CodeVariableDeclarationStatement;
end;

class function CoCodeVariableReferenceExpression.Create: _CodeVariableReferenceExpression;
begin
  Result := CreateComObject(CLASS_CodeVariableReferenceExpression) as _CodeVariableReferenceExpression;
end;

class function CoCodeVariableReferenceExpression.CreateRemote(const MachineName: string): _CodeVariableReferenceExpression;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CodeVariableReferenceExpression) as _CodeVariableReferenceExpression;
end;

class function Cocomponent.Create: _Component;
begin
  Result := CreateComObject(CLASS_component) as _Component;
end;

class function Cocomponent.CreateRemote(const MachineName: string): _Component;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_component) as _Component;
end;

class function CoAttributeCollection.Create: _AttributeCollection;
begin
  Result := CreateComObject(CLASS_AttributeCollection) as _AttributeCollection;
end;

class function CoAttributeCollection.CreateRemote(const MachineName: string): _AttributeCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_AttributeCollection) as _AttributeCollection;
end;

class function CoPropertyDescriptor.Create: _PropertyDescriptor;
begin
  Result := CreateComObject(CLASS_PropertyDescriptor) as _PropertyDescriptor;
end;

class function CoPropertyDescriptor.CreateRemote(const MachineName: string): _PropertyDescriptor;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_PropertyDescriptor) as _PropertyDescriptor;
end;

class function CoComponentCollection.Create: _ComponentCollection;
begin
  Result := CreateComObject(CLASS_ComponentCollection) as _ComponentCollection;
end;

class function CoComponentCollection.CreateRemote(const MachineName: string): _ComponentCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ComponentCollection) as _ComponentCollection;
end;

class function CoEventDescriptor.Create: _EventDescriptor;
begin
  Result := CreateComObject(CLASS_EventDescriptor) as _EventDescriptor;
end;

class function CoEventDescriptor.CreateRemote(const MachineName: string): _EventDescriptor;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_EventDescriptor) as _EventDescriptor;
end;

class function CoEventDescriptorCollection.Create: _EventDescriptorCollection;
begin
  Result := CreateComObject(CLASS_EventDescriptorCollection) as _EventDescriptorCollection;
end;

class function CoEventDescriptorCollection.CreateRemote(const MachineName: string): _EventDescriptorCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_EventDescriptorCollection) as _EventDescriptorCollection;
end;

class function CoMemberDescriptor.Create: _MemberDescriptor;
begin
  Result := CreateComObject(CLASS_MemberDescriptor) as _MemberDescriptor;
end;

class function CoMemberDescriptor.CreateRemote(const MachineName: string): _MemberDescriptor;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_MemberDescriptor) as _MemberDescriptor;
end;

class function CoMarshalByValueComponent.Create: _MarshalByValueComponent;
begin
  Result := CreateComObject(CLASS_MarshalByValueComponent) as _MarshalByValueComponent;
end;

class function CoMarshalByValueComponent.CreateRemote(const MachineName: string): _MarshalByValueComponent;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_MarshalByValueComponent) as _MarshalByValueComponent;
end;

class function CoCommandID.Create: _CommandID;
begin
  Result := CreateComObject(CLASS_CommandID) as _CommandID;
end;

class function CoCommandID.CreateRemote(const MachineName: string): _CommandID;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_CommandID) as _CommandID;
end;

class function CoComponentChangedEventArgs.Create: _ComponentChangedEventArgs;
begin
  Result := CreateComObject(CLASS_ComponentChangedEventArgs) as _ComponentChangedEventArgs;
end;

class function CoComponentChangedEventArgs.CreateRemote(const MachineName: string): _ComponentChangedEventArgs;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ComponentChangedEventArgs) as _ComponentChangedEventArgs;
end;

class function CoComponentChangedEventHandler.Create: _ComponentChangedEventHandler;
begin
  Result := CreateComObject(CLASS_ComponentChangedEventHandler) as _ComponentChangedEventHandler;
end;

class function CoComponentChangedEventHandler.CreateRemote(const MachineName: string): _ComponentChangedEventHandler;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ComponentChangedEventHandler) as _ComponentChangedEventHandler;
end;

class function CoComponentChangingEventArgs.Create: _ComponentChangingEventArgs;
begin
  Result := CreateComObject(CLASS_ComponentChangingEventArgs) as _ComponentChangingEventArgs;
end;

class function CoComponentChangingEventArgs.CreateRemote(const MachineName: string): _ComponentChangingEventArgs;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ComponentChangingEventArgs) as _ComponentChangingEventArgs;
end;

class function CoComponentChangingEventHandler.Create: _ComponentChangingEventHandler;
begin
  Result := CreateComObject(CLASS_ComponentChangingEventHandler) as _ComponentChangingEventHandler;
end;

class function CoComponentChangingEventHandler.CreateRemote(const MachineName: string): _ComponentChangingEventHandler;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ComponentChangingEventHandler) as _ComponentChangingEventHandler;
end;

class function CoComponentEventArgs.Create: _ComponentEventArgs;
begin
  Result := CreateComObject(CLASS_ComponentEventArgs) as _ComponentEventArgs;
end;

class function CoComponentEventArgs.CreateRemote(const MachineName: string): _ComponentEventArgs;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ComponentEventArgs) as _ComponentEventArgs;
end;

class function CoComponentEventHandler.Create: _ComponentEventHandler;
begin
  Result := CreateComObject(CLASS_ComponentEventHandler) as _ComponentEventHandler;
end;

class function CoComponentEventHandler.CreateRemote(const MachineName: string): _ComponentEventHandler;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ComponentEventHandler) as _ComponentEventHandler;
end;

class function CoComponentRenameEventArgs.Create: _ComponentRenameEventArgs;
begin
  Result := CreateComObject(CLASS_ComponentRenameEventArgs) as _ComponentRenameEventArgs;
end;

class function CoComponentRenameEventArgs.CreateRemote(const MachineName: string): _ComponentRenameEventArgs;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ComponentRenameEventArgs) as _ComponentRenameEventArgs;
end;

class function CoComponentRenameEventHandler.Create: _ComponentRenameEventHandler;
begin
  Result := CreateComObject(CLASS_ComponentRenameEventHandler) as _ComponentRenameEventHandler;
end;

class function CoComponentRenameEventHandler.CreateRemote(const MachineName: string): _ComponentRenameEventHandler;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ComponentRenameEventHandler) as _ComponentRenameEventHandler;
end;

class function CoDesignerTransactionCloseEventArgs.Create: _DesignerTransactionCloseEventArgs;
begin
  Result := CreateComObject(CLASS_DesignerTransactionCloseEventArgs) as _DesignerTransactionCloseEventArgs;
end;

class function CoDesignerTransactionCloseEventArgs.CreateRemote(const MachineName: string): _DesignerTransactionCloseEventArgs;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_DesignerTransactionCloseEventArgs) as _DesignerTransactionCloseEventArgs;
end;

class function CoDesignerTransactionCloseEventHandler.Create: _DesignerTransactionCloseEventHandler;
begin
  Result := CreateComObject(CLASS_DesignerTransactionCloseEventHandler) as _DesignerTransactionCloseEventHandler;
end;

class function CoDesignerTransactionCloseEventHandler.CreateRemote(const MachineName: string): _DesignerTransactionCloseEventHandler;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_DesignerTransactionCloseEventHandler) as _DesignerTransactionCloseEventHandler;
end;

class function CoDesignerVerb.Create: _DesignerVerb;
begin
  Result := CreateComObject(CLASS_DesignerVerb) as _DesignerVerb;
end;

class function CoDesignerVerb.CreateRemote(const MachineName: string): _DesignerVerb;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_DesignerVerb) as _DesignerVerb;
end;

class function CoMenuCommand.Create: _MenuCommand;
begin
  Result := CreateComObject(CLASS_MenuCommand) as _MenuCommand;
end;

class function CoMenuCommand.CreateRemote(const MachineName: string): _MenuCommand;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_MenuCommand) as _MenuCommand;
end;

class function CoDesignerVerbCollection.Create: _DesignerVerbCollection;
begin
  Result := CreateComObject(CLASS_DesignerVerbCollection) as _DesignerVerbCollection;
end;

class function CoDesignerVerbCollection.CreateRemote(const MachineName: string): _DesignerVerbCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_DesignerVerbCollection) as _DesignerVerbCollection;
end;

class function CoServiceCreatorCallback.Create: _ServiceCreatorCallback;
begin
  Result := CreateComObject(CLASS_ServiceCreatorCallback) as _ServiceCreatorCallback;
end;

class function CoServiceCreatorCallback.CreateRemote(const MachineName: string): _ServiceCreatorCallback;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_ServiceCreatorCallback) as _ServiceCreatorCallback;
end;

class function CoDesignerLoader.Create: _DesignerLoader;
begin
  Result := CreateComObject(CLASS_DesignerLoader) as _DesignerLoader;
end;

class function CoDesignerLoader.CreateRemote(const MachineName: string): _DesignerLoader;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_DesignerLoader) as _DesignerLoader;
end;

class function CoPerformanceCounterManager.Create: _PerformanceCounterManager;
begin
  Result := CreateComObject(CLASS_PerformanceCounterManager) as _PerformanceCounterManager;
end;

class function CoPerformanceCounterManager.CreateRemote(const MachineName: string): _PerformanceCounterManager;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_PerformanceCounterManager) as _PerformanceCounterManager;
end;

class function CoWebHeaderCollection.Create: _WebHeaderCollection;
begin
  Result := CreateComObject(CLASS_WebHeaderCollection) as _WebHeaderCollection;
end;

class function CoWebHeaderCollection.CreateRemote(const MachineName: string): _WebHeaderCollection;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_WebHeaderCollection) as _WebHeaderCollection;
end;

class function CoWebClient.Create: _WebClient;
begin
  Result := CreateComObject(CLASS_WebClient) as _WebClient;
end;

class function CoWebClient.CreateRemote(const MachineName: string): _WebClient;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_WebClient) as _WebClient;
end;

class function CoStandardOleMarshalObject.Create: _StandardOleMarshalObject;
begin
  Result := CreateComObject(CLASS_StandardOleMarshalObject) as _StandardOleMarshalObject;
end;

class function CoStandardOleMarshalObject.CreateRemote(const MachineName: string): _StandardOleMarshalObject;
begin
  Result := CreateRemoteComObject(MachineName, CLASS_StandardOleMarshalObject) as _StandardOleMarshalObject;
end;

end.
