// Machine generated IDispatch wrapper class(es) created with Add Class from Typelib Wizard

#import "C:\\GdPicture.NET 14\\Redist\\COM Interop\\GdPicture.NET.14.tlb" raw_interfaces_only
// CLicenseManager wrapper class

class CLicenseManager : public COleDispatchDriver
{
public:
	CLicenseManager() {} // Calls COleDispatchDriver default constructor
	CLicenseManager(LPDISPATCH pDispatch) : COleDispatchDriver(pDispatch) {}
	CLicenseManager(const CLicenseManager& dispatchSrc) : COleDispatchDriver(dispatchSrc) {}

	// Attributes
public:

	// Operations
public:


	// ILicenseManager methods
public:
	BOOL RegisterKEY(LPCTSTR Key)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x1, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Key);
		return result;
	}
	double GetVersion()
	{
		double result;
		InvokeHelper(0x2, DISPATCH_METHOD, VT_R8, (void*)&result, nullptr);
		return result;
	}
	CString GetRedistPath()
	{
		CString result;
		InvokeHelper(0x3, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}

	// ILicenseManager properties
public:

};
