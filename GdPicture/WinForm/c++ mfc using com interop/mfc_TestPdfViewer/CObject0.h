// CObject0.h  : Declaration of ActiveX Control wrapper class(es) created by Microsoft Visual C++

#pragma once

/////////////////////////////////////////////////////////////////////////////
// CObject0

class CObject0 : public COleDispatchDriver
{
public:
	CObject0() {}		// Calls COleDispatchDriver default constructor
	CObject0(LPDISPATCH pDispatch) : COleDispatchDriver(pDispatch) {}
	CObject0(const CObject0& dispatchSrc) : COleDispatchDriver(dispatchSrc) {}

// Attributes
public:

// Operations
public:

	CString get_ToString()
	{
		CString result;
		InvokeHelper(0x0, DISPATCH_PROPERTYGET, VT_BSTR, (void*)&result, NULL);
		return result;
	}
	BOOL Equals(VARIANT obj)
	{
		BOOL result;
		static BYTE parms[] = VTS_VARIANT ;
		InvokeHelper(0x60020001, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, &obj);
		return result;
	}
	long GetHashCode()
	{
		long result;
		InvokeHelper(0x60020002, DISPATCH_METHOD, VT_I4, (void*)&result, NULL);
		return result;
	}
	LPUNKNOWN GetType()
	{
		LPUNKNOWN result;
		InvokeHelper(0x60020003, DISPATCH_METHOD, VT_UNKNOWN, (void*)&result, NULL);
		return result;
	}


};
