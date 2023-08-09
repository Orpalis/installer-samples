// CGdViewer0.h  : Declaration of ActiveX Control wrapper class(es) created by Microsoft Visual C++

#pragma once

/////////////////////////////////////////////////////////////////////////////
// CGdViewer0

class CGdViewer0 : public CWnd
{
protected:
	DECLARE_DYNCREATE(CGdViewer0)
public:
	CLSID const& GetClsid()
	{
		static CLSID const clsid
			= { 0xCC0D923, 0xB9ED, 0x310C, { 0xB4, 0x53, 0xD1, 0xA5, 0x9F, 0x25, 0x71, 0x2C } };
		return clsid;
	}
	virtual BOOL Create(LPCTSTR lpszClassName, LPCTSTR lpszWindowName, DWORD dwStyle,
						const RECT& rect, CWnd* pParentWnd, UINT nID,
						CCreateContext* pContext = nullptr)
	{
		return CreateControl(GetClsid(), lpszWindowName, dwStyle, rect, pParentWnd, nID);
	}

	BOOL Create(LPCTSTR lpszWindowName, DWORD dwStyle, const RECT& rect, CWnd* pParentWnd,
				UINT nID, CFile* pPersist = nullptr, BOOL bStorage = FALSE,
				BSTR bstrLicKey = nullptr)
	{
		return CreateControl(GetClsid(), lpszWindowName, dwStyle, rect, pParentWnd, nID,
		pPersist, bStorage, bstrLicKey);
	}

// Attributes
public:

// Operations
public:

	BOOL get_PdfEnableFileLinks()
	{
		BOOL result;
		InvokeHelper(0x1, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PdfEnableFileLinks(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x1, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_PdfIncreaseTextContrast()
	{
		BOOL result;
		InvokeHelper(0x2, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PdfIncreaseTextContrast(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x2, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_PdfVerifyDigitalCertificates()
	{
		BOOL result;
		InvokeHelper(0x3, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PdfVerifyDigitalCertificates(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x3, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_ScrollBars()
	{
		BOOL result;
		InvokeHelper(0x4, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_ScrollBars(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x4, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_ForceScrollBars()
	{
		BOOL result;
		InvokeHelper(0x5, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_ForceScrollBars(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x5, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_EnableMenu()
	{
		BOOL result;
		InvokeHelper(0x6, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_EnableMenu(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x6, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_ViewRotation()
	{
		long result;
		InvokeHelper(0x7, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_ViewRotation(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x7, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_PageRotation()
	{
		long result;
		InvokeHelper(0x8, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL get_PdfShowOpenFileDialogForDecryption()
	{
		BOOL result;
		InvokeHelper(0x9, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PdfShowOpenFileDialogForDecryption(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x9, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_PageRenderRotation()
	{
		long result;
		InvokeHelper(0xa, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long get_PageWidth()
	{
		long result;
		InvokeHelper(0xb, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long get_PageHeight()
	{
		long result;
		InvokeHelper(0xc, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long get_MouseMode()
	{
		long result;
		InvokeHelper(0xd, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_MouseMode(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xd, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	double get_Zoom()
	{
		double result;
		InvokeHelper(0xe, DISPATCH_PROPERTYGET, VT_R8, (void*)&result, nullptr);
		return result;
	}
	void put_Zoom(double newValue)
	{
		static BYTE parms[] = VTS_R8 ;
		InvokeHelper(0xe, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_PdfShowDialogForPassword()
	{
		BOOL result;
		InvokeHelper(0xf, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PdfShowDialogForPassword(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0xf, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_ZoomCenterAtMousePosition()
	{
		BOOL result;
		InvokeHelper(0x10, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_ZoomCenterAtMousePosition(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x10, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_MagnifierWidth()
	{
		long result;
		InvokeHelper(0x11, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_MagnifierWidth(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x11, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_VScrollVisible()
	{
		BOOL result;
		InvokeHelper(0x12, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL get_HScrollVisible()
	{
		BOOL result;
		InvokeHelper(0x13, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL get_EnableICM()
	{
		BOOL result;
		InvokeHelper(0x14, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_EnableICM(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x14, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_RenderGdPictureAnnots()
	{
		BOOL result;
		InvokeHelper(0x15, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_RenderGdPictureAnnots(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x15, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_HQAnnotationRendering()
	{
		BOOL result;
		InvokeHelper(0x16, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_HQAnnotationRendering(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x16, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_AllowDropFile()
	{
		BOOL result;
		InvokeHelper(0x17, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_AllowDropFile(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x17, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_AnnotationDropShadow()
	{
		BOOL result;
		InvokeHelper(0x18, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_AnnotationDropShadow(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x18, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	float get_AnnotationResizeRotateHandlesScale()
	{
		float result;
		InvokeHelper(0x19, DISPATCH_PROPERTYGET, VT_R4, (void*)&result, nullptr);
		return result;
	}
	void put_AnnotationResizeRotateHandlesScale(float newValue)
	{
		static BYTE parms[] = VTS_R4 ;
		InvokeHelper(0x19, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_EnableTextSelection()
	{
		BOOL result;
		InvokeHelper(0x1b, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_EnableTextSelection(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x1b, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_PageDisplayMode()
	{
		long result;
		InvokeHelper(0x1c, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_PageDisplayMode(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x1c, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_EnableDeferredPainting()
	{
		BOOL result;
		InvokeHelper(0x1d, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_EnableDeferredPainting(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x1d, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_BackColor()
	{
		long result;
		InvokeHelper(0x1e, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_BackColor(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x1e, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_EnabledProgressBar()
	{
		BOOL result;
		InvokeHelper(0x1f, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_EnabledProgressBar(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x1f, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_MagnifierHeight()
	{
		long result;
		InvokeHelper(0x20, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_MagnifierHeight(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x20, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	double get_ZoomMax()
	{
		double result;
		InvokeHelper(0x21, DISPATCH_PROPERTYGET, VT_R8, (void*)&result, nullptr);
		return result;
	}
	float get_MagnifierZoomY()
	{
		float result;
		InvokeHelper(0x22, DISPATCH_PROPERTYGET, VT_R4, (void*)&result, nullptr);
		return result;
	}
	void put_MagnifierZoomY(float newValue)
	{
		static BYTE parms[] = VTS_R4 ;
		InvokeHelper(0x22, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_MouseButtonForMouseMode()
	{
		long result;
		InvokeHelper(0x23, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_MouseButtonForMouseMode(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x23, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_ContinuousViewMode()
	{
		BOOL result;
		InvokeHelper(0x24, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_ContinuousViewMode(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x24, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	float get_MagnifierZoomX()
	{
		float result;
		InvokeHelper(0x25, DISPATCH_PROPERTYGET, VT_R4, (void*)&result, nullptr);
		return result;
	}
	void put_MagnifierZoomX(float newValue)
	{
		static BYTE parms[] = VTS_R4 ;
		InvokeHelper(0x25, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_RectIsEditable()
	{
		BOOL result;
		InvokeHelper(0x26, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_RectIsEditable(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x26, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	float get_Gamma()
	{
		float result;
		InvokeHelper(0x27, DISPATCH_PROPERTYGET, VT_R4, (void*)&result, nullptr);
		return result;
	}
	void put_Gamma(float newValue)
	{
		static BYTE parms[] = VTS_R4 ;
		InvokeHelper(0x27, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_MouseWheelMode()
	{
		long result;
		InvokeHelper(0x28, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_MouseWheelMode(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x28, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_KeepDocumentPosition()
	{
		BOOL result;
		InvokeHelper(0x29, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_KeepDocumentPosition(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x29, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_PdfEnableLinks()
	{
		BOOL result;
		InvokeHelper(0x2a, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PdfEnableLinks(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x2a, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_PdfDisplayFormField()
	{
		BOOL result;
		InvokeHelper(0x2b, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PdfDisplayFormField(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x2b, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_DisplayQualityAuto()
	{
		BOOL result;
		InvokeHelper(0x2c, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_DisplayQualityAuto(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x2c, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_DisplayQuality()
	{
		long result;
		InvokeHelper(0x2d, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_DisplayQuality(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x2d, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_AnimateGIF()
	{
		BOOL result;
		InvokeHelper(0x2e, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_AnimateGIF(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x2e, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_DocumentPosition()
	{
		long result;
		InvokeHelper(0x2f, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_DocumentPosition(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x2f, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_DocumentAlignment()
	{
		long result;
		InvokeHelper(0x30, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_DocumentAlignment(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x30, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_RegionsAreEditable()
	{
		BOOL result;
		InvokeHelper(0x31, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_RegionsAreEditable(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x31, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_ZoomMode()
	{
		long result;
		InvokeHelper(0x32, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_ZoomMode(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x32, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_EnableMouseWheel()
	{
		BOOL result;
		InvokeHelper(0x33, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_EnableMouseWheel(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x33, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_ZoomStep()
	{
		long result;
		InvokeHelper(0x34, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_ZoomStep(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x34, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	short get_ScrollSmallChange()
	{
		short result;
		InvokeHelper(0x35, DISPATCH_PROPERTYGET, VT_I2, (void*)&result, nullptr);
		return result;
	}
	void put_ScrollSmallChange(short newValue)
	{
		static BYTE parms[] = VTS_I2 ;
		InvokeHelper(0x35, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	short get_ScrollLargeChange()
	{
		short result;
		InvokeHelper(0x36, DISPATCH_PROPERTYGET, VT_I2, (void*)&result, nullptr);
		return result;
	}
	void put_ScrollLargeChange(short newValue)
	{
		static BYTE parms[] = VTS_I2 ;
		InvokeHelper(0x36, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	float get_VerticalResolution()
	{
		float result;
		InvokeHelper(0x37, DISPATCH_PROPERTYGET, VT_R4, (void*)&result, nullptr);
		return result;
	}
	float get_HorizontalResolution()
	{
		float result;
		InvokeHelper(0x38, DISPATCH_PROPERTYGET, VT_R4, (void*)&result, nullptr);
		return result;
	}
	long get_RectBorderSize()
	{
		long result;
		InvokeHelper(0x39, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_RectBorderSize(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x39, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_CurrentPage()
	{
		long result;
		InvokeHelper(0x3a, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL get_SilentMode()
	{
		BOOL result;
		InvokeHelper(0x3b, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_SilentMode(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x3b, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_ForceTemporaryMode()
	{
		BOOL result;
		InvokeHelper(0x3c, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_ForceTemporaryMode(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x3c, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_IgnoreDocumentResolution()
	{
		BOOL result;
		InvokeHelper(0x3d, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_IgnoreDocumentResolution(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x3d, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_pageCount()
	{
		long result;
		InvokeHelper(0x3e, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL get_LockViewer()
	{
		BOOL result;
		InvokeHelper(0x3f, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_LockViewer(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x3f, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_DrawPageBorders()
	{
		BOOL result;
		InvokeHelper(0x147, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_DrawPageBorders(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x147, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_PageBordersPenSize()
	{
		long result;
		InvokeHelper(0x148, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_PageBordersPenSize(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x148, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_PageBordersColor()
	{
		long result;
		InvokeHelper(0x149, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_PageBordersColor(long newValue)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x149, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	void AddConnectedLinesAnnotInteractive(long BorderColor, float BorderWidth, float Opacity)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x40, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, Opacity);
	}
	void AddEllipseAnnotInteractive(BOOL Fill, BOOL Stroke, long BackColor, long BorderColor, float BorderWidth, float Opacity)
	{
		static BYTE parms[] = VTS_BOOL VTS_BOOL VTS_I4 VTS_I4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x41, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Fill, Stroke, BackColor, BorderColor, BorderWidth, Opacity);
	}
	void AddEmbeddedImageAnnotInteractive(long ImageID, BOOL Stroke, long BorderColor, float BorderWidth, float Opacity)
	{
		static BYTE parms[] = VTS_I4 VTS_BOOL VTS_I4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x42, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, ImageID, Stroke, BorderColor, BorderWidth, Opacity);
	}
	void AddEmbeddedImageAnnotInteractive_2(LPCTSTR ImagePath, BOOL Stroke, long BorderColor, float BorderWidth, float Opacity)
	{
		static BYTE parms[] = VTS_BSTR VTS_BOOL VTS_I4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x43, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, ImagePath, Stroke, BorderColor, BorderWidth, Opacity);
	}
	void AddFreeHandAnnotInteractive(long BorderColor, float BorderWidth, float Opacity)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x44, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, Opacity);
	}
	void AddFreeHandAnnotInteractive_2(long BorderColor, float BorderWidth, float Opacity, BOOL ContinuousMode)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_BOOL ;
		InvokeHelper(0x45, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, Opacity, ContinuousMode);
	}
	void AddFreeHandHighlighterAnnotInteractive(long BorderColor, float BorderWidth)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 ;
		InvokeHelper(0x46, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth);
	}
	void AddFreeHandHighlighterAnnotInteractive_2(long BorderColor, float BorderWidth, BOOL ContinuousMode)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_BOOL ;
		InvokeHelper(0x47, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, ContinuousMode);
	}
	void AddFreeHandPolygonAnnotInteractive(long BorderColor, float BorderWidth, long BackColor, float Opacity)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_I4 VTS_R4 ;
		InvokeHelper(0x48, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, BackColor, Opacity);
	}
	void AddLineAnnotInteractive(long BorderColor, float BorderWidth, float Opacity)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x49, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, Opacity);
	}
	void AddLineArrowAnnotInteractive(long BorderColor, float BorderWidth, float ArrowWidth, float ArrowHeight, BOOL ArrowFilled, float Opacity)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_R4 ;
		InvokeHelper(0x4a, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, ArrowWidth, ArrowHeight, ArrowFilled, Opacity);
	}
	void AddLineArrowAnnotInteractive_2(long BorderColor, float BorderWidth, float ArrowWidth, float ArrowHeight, BOOL ArrowFilled, float Opacity, BOOL Reversed)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_R4 VTS_BOOL ;
		InvokeHelper(0x4b, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, ArrowWidth, ArrowHeight, ArrowFilled, Opacity, Reversed);
	}
	void AddLinkAnnotationInteractive(LPCTSTR Text, LPCTSTR Link, long ForeColor, long HoverForeColor, LPCTSTR FontName, long FontStyle, long HoverFontStyle, float Opacity, float Rotation)
	{
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_I4 VTS_I4 VTS_BSTR VTS_I4 VTS_I4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x4c, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Text, Link, ForeColor, HoverForeColor, FontName, FontStyle, HoverFontStyle, Opacity, Rotation);
	}
	void AddPolygonAnnotInteractive(long BorderColor, float BorderWidth, long BackColor, float Opacity)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_I4 VTS_R4 ;
		InvokeHelper(0x4d, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, BackColor, Opacity);
	}
	void AddPolyRulerAnnotInteractive(long BorderColor, float BorderWidth, float Opacity, long MeasurementUnit)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_I4 ;
		InvokeHelper(0x4e, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, Opacity, MeasurementUnit);
	}
	void AddRectangleAnnotInteractive(BOOL Fill, BOOL Stroke, long BackColor, long BorderColor, float BorderWidth, float Opacity)
	{
		static BYTE parms[] = VTS_BOOL VTS_BOOL VTS_I4 VTS_I4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x4f, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Fill, Stroke, BackColor, BorderColor, BorderWidth, Opacity);
	}
	void AddRectangleHighlighterAnnotInteractive(long BackColor)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x50, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BackColor);
	}
	long AddRegion(LPCTSTR Name, long Left, long Top, long Width, long Height, long MixMode, long RegionColor)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 ;
		InvokeHelper(0x51, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Name, Left, Top, Width, Height, MixMode, RegionColor);
		return result;
	}
	long AddRegionInches(LPCTSTR Name, float Left, float Top, float Width, float Height, long MixMode, long RegionColor)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_I4 VTS_I4 ;
		InvokeHelper(0x52, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Name, Left, Top, Width, Height, MixMode, RegionColor);
		return result;
	}
	void AddRubberStampAnnotInteractive(LPCTSTR Text, long ForeColor, LPCTSTR FontName, long FontStyle, long BorderColor, float BorderWidth, float Opacity, float Rotation)
	{
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BSTR VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x53, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Text, ForeColor, FontName, FontStyle, BorderColor, BorderWidth, Opacity, Rotation);
	}
	void AddRulerAnnotInteractive(long BorderColor, float BorderWidth, float Opacity, long MeasurementUnit)
	{
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_I4 ;
		InvokeHelper(0x54, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BorderColor, BorderWidth, Opacity, MeasurementUnit);
	}
	void AddStickyNoteAnnotationInteractive(LPCTSTR Text, long ForeColor, LPCTSTR FontName, long FontStyle, float FontSize, float Opacity, float Rotation)
	{
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BSTR VTS_I4 VTS_R4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x55, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Text, ForeColor, FontName, FontStyle, FontSize, Opacity, Rotation);
	}
	void AddTextAnnotationInteractive(LPCTSTR Text, long ForeColor, LPCTSTR FontName, long FontStyle, float FontSize, BOOL Fill, long BorderColor, long BackColor, float Opacity, float Rotation)
	{
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BSTR VTS_I4 VTS_R4 VTS_BOOL VTS_I4 VTS_I4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x56, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Text, ForeColor, FontName, FontStyle, FontSize, Fill, BorderColor, BackColor, Opacity, Rotation);
	}
	long ARGBI(unsigned char Alpha, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 ;
		InvokeHelper(0x57, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Alpha, Red, Green, Blue);
		return result;
	}
	long BurnAnnotationsToPage(BOOL RemoveInitialAnnots)
	{
		long result;
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x58, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RemoveInitialAnnots);
		return result;
	}
	long BurnAnnotationsToPage_2(BOOL RemoveInitialAnnots, long Intent)
	{
		long result;
		static BYTE parms[] = VTS_BOOL VTS_I4 ;
		InvokeHelper(0x59, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RemoveInitialAnnots, Intent);
		return result;
	}
	long BurnAnnotationsToPage_3(BOOL RemoveInitialAnnots, BOOL VectorMode)
	{
		long result;
		static BYTE parms[] = VTS_BOOL VTS_BOOL ;
		InvokeHelper(0x5a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RemoveInitialAnnots, VectorMode);
		return result;
	}
	void CancelLastAnnotInteractiveAdd()
	{
		InvokeHelper(0x5b, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void CenterOnRect()
	{
		InvokeHelper(0x5c, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void Clear()
	{
		InvokeHelper(0x5d, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void ClearRect()
	{
		InvokeHelper(0x5e, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void ClearSelectedText()
	{
		InvokeHelper(0x5f, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void CloseDocument()
	{
		InvokeHelper(0x60, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void CloseDocument_2(BOOL NoCLear)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x61, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, NoCLear);
	}
	void CoordDocumentInchToViewerPixel(double DocumentLeft, double DocumentTop, long * ViewerLeft, long * ViewerTop)
	{
		static BYTE parms[] = VTS_R8 VTS_R8 VTS_PI4 VTS_PI4 ;
		InvokeHelper(0x62, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, DocumentLeft, DocumentTop, ViewerLeft, ViewerTop);
	}
	void CoordDocumentToViewer(long DocumentLeft, long DocumentTop, long * ViewerLeft, long * ViewerTop)
	{
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_PI4 VTS_PI4 ;
		InvokeHelper(0x63, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, DocumentLeft, DocumentTop, ViewerLeft, ViewerTop);
	}
	void CoordViewerPixelToDocumentInch(long ViewerLeft, long ViewerTop, double * DocumentLeft, double * DocumentTop)
	{
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_PR8 VTS_PR8 ;
		InvokeHelper(0x64, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, ViewerLeft, ViewerTop, DocumentLeft, DocumentTop);
	}
	void CoordViewerToDocument(long ViewerLeft, long ViewerTop, long * DocumentLeft, long * DocumentTop)
	{
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_PI4 VTS_PI4 ;
		InvokeHelper(0x65, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, ViewerLeft, ViewerTop, DocumentLeft, DocumentTop);
	}
	long CopyRegionToClipboard(long SrcLeft, long SrcTop, long Width, long Height)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_I4 VTS_I4 ;
		InvokeHelper(0x66, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SrcLeft, SrcTop, Width, Height);
		return result;
	}
	long CopyRegionToGdPictureImage(long SrcLeft, long SrcTop, long Width, long Height)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_I4 VTS_I4 ;
		InvokeHelper(0x67, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SrcLeft, SrcTop, Width, Height);
		return result;
	}
	long CopyToClipboard()
	{
		long result;
		InvokeHelper(0x68, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void DeleteAnnotation(long AnnotationIdx)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x69, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, AnnotationIdx);
	}
	long DisplayFirstPage()
	{
		long result;
		InvokeHelper(0x6a, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long DisplayFromByteArray(SAFEARRAY * * Data)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN ;
		InvokeHelper(0x6b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data);
		return result;
	}
	long DisplayFromClipboard()
	{
		long result;
		InvokeHelper(0x6c, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long DisplayFromFile(LPCTSTR FilePath)
	{
		long result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0x6d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath);
		return result;
	}
	long DisplayFromFile_2(LPCTSTR FilePath, LPCTSTR Password)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR ;
		InvokeHelper(0x6e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, Password);
		return result;
	}
	long DisplayFromFTP(LPCTSTR Host, LPCTSTR Path, LPCTSTR Login, LPCTSTR Password, long FTPPort)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR VTS_BSTR VTS_I4 ;
		InvokeHelper(0x6f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Host, Path, Login, Password, FTPPort);
		return result;
	}
	long DisplayFromFTP_2(LPCTSTR Uri, LPCTSTR Login, LPCTSTR Password)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR ;
		InvokeHelper(0x70, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Uri, Login, Password);
		return result;
	}
	long DisplayFromGdPictureImage(long ImageID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x71, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageID);
		return result;
	}
	long DisplayFromGdPicturePDF(LPDISPATCH PDF)
	{
		long result;
		static BYTE parms[] = VTS_DISPATCH ;
		InvokeHelper(0x72, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PDF);
		return result;
	}
	long DisplayFromHTTP(LPCTSTR Host, LPCTSTR Path, long HTTPPort)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_I4 ;
		InvokeHelper(0x73, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Host, Path, HTTPPort);
		return result;
	}
	void DisplayFromHTTPStop()
	{
		InvokeHelper(0x74, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long DisplayFromHTTP_2(LPCTSTR Uri, LPCTSTR Login, LPCTSTR Password)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR ;
		InvokeHelper(0x75, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Uri, Login, Password);
		return result;
	}
	long DisplayFromIStream(LPUNKNOWN Stream, LPCTSTR Password)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN VTS_BSTR ;
		InvokeHelper(0x76, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Stream, Password);
		return result;
	}
	long DisplayFromString(LPCTSTR Data)
	{
		long result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0x77, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data);
		return result;
	}
	long DisplayLastPage()
	{
		long result;
		InvokeHelper(0x78, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long DisplayNextPage()
	{
		long result;
		InvokeHelper(0x79, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long DisplayPage(long Page)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x7a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Page);
		return result;
	}
	long DisplayPreviousPage()
	{
		long result;
		InvokeHelper(0x7b, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long DisplayTextEditBox(long AnnotationIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x7c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	void Dispose()
	{
		InvokeHelper(0x7d, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long EnsureRegionVisibility(long RegionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x7e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID);
		return result;
	}
	long GetAnnotationCount()
	{
		long result;
		InvokeHelper(0x7f, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	LPDISPATCH GetAnnotationFromIdx(long AnnotationIdx)
	{
		LPDISPATCH result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x80, DISPATCH_METHOD, VT_DISPATCH, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	LPDISPATCH GetAnnotationManager()
	{
		LPDISPATCH result;
		InvokeHelper(0x81, DISPATCH_METHOD, VT_DISPATCH, (void*)&result, nullptr);
		return result;
	}
	void GetDisplayedArea(long * Left, long * Top, long * Width, long * Height)
	{
		static BYTE parms[] = VTS_PI4 VTS_PI4 VTS_PI4 VTS_PI4 ;
		InvokeHelper(0x82, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Left, Top, Width, Height);
	}
	void GetDisplayedAreaInches(float * Left, float * Top, float * Width, float * Height)
	{
		static BYTE parms[] = VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 ;
		InvokeHelper(0x83, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Left, Top, Width, Height);
	}
	long GetDocumentLeft()
	{
		long result;
		InvokeHelper(0x84, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetDocumentTop()
	{
		long result;
		InvokeHelper(0x85, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetDocumentType()
	{
		long result;
		InvokeHelper(0x86, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetHScrollBarMaxPosition()
	{
		long result;
		InvokeHelper(0x87, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetHScrollBarPosition()
	{
		long result;
		InvokeHelper(0x88, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetLastPath()
	{
		CString result;
		InvokeHelper(0x89, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString GetLastTransferError()
	{
		CString result;
		InvokeHelper(0x8a, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long GetMouseLeftInDocument()
	{
		long result;
		InvokeHelper(0x8b, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetMouseTopInDocument()
	{
		long result;
		InvokeHelper(0x8c, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	VARIANT GetObject()
	{
		VARIANT result;
		InvokeHelper(0x8d, DISPATCH_METHOD, VT_VARIANT, (void*)&result, nullptr);
		return result;
	}
	VARIANT GetObjectInterop()
	{
		VARIANT result;
		InvokeHelper(0x8e, DISPATCH_METHOD, VT_VARIANT, (void*)&result, nullptr);
		return result;
	}
	CString GetPageText()
	{
		CString result;
		InvokeHelper(0x8f, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString GetPageTextArea(float Left, float Top, float Width, float Height)
	{
		CString result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x90, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, Left, Top, Width, Height);
		return result;
	}
	CString GetPageTextArea_2(long Page, float Left, float Top, float Width, float Height)
	{
		CString result;
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x91, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, Page, Left, Top, Width, Height);
		return result;
	}
	CString GetPageText_2(long Page)
	{
		CString result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x92, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, Page);
		return result;
	}
	long GetPageThumbnail(long Width, long Height, long Page, long BackColor)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_I4 VTS_I4 ;
		InvokeHelper(0x93, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Width, Height, Page, BackColor);
		return result;
	}
	void GetRectCoordinatesOnDocument(long * Left, long * Top, long * Width, long * Height)
	{
		static BYTE parms[] = VTS_PI4 VTS_PI4 VTS_PI4 VTS_PI4 ;
		InvokeHelper(0x94, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Left, Top, Width, Height);
	}
	void GetRectCoordinatesOnDocumentInches(float * Left, float * Top, float * Width, float * Height)
	{
		static BYTE parms[] = VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 ;
		InvokeHelper(0x95, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Left, Top, Width, Height);
	}
	void GetRectCoordinatesOnViewer(long * Left, long * Top, long * Width, long * Height)
	{
		static BYTE parms[] = VTS_PI4 VTS_PI4 VTS_PI4 VTS_PI4 ;
		InvokeHelper(0x96, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Left, Top, Width, Height);
	}
	long GetRectHeightOnDocument()
	{
		long result;
		InvokeHelper(0x97, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetRectHeightOnViewer()
	{
		long result;
		InvokeHelper(0x98, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetRectLeftOnDocument()
	{
		long result;
		InvokeHelper(0x99, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetRectLeftOnViewer()
	{
		long result;
		InvokeHelper(0x9a, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetRectTopOnDocument()
	{
		long result;
		InvokeHelper(0x9b, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetRectTopOnViewer()
	{
		long result;
		InvokeHelper(0x9c, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetRectWidthOnDocument()
	{
		long result;
		InvokeHelper(0x9d, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetRectWidthOnViewer()
	{
		long result;
		InvokeHelper(0x9e, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetRegionBorderWidth(long RegionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x9f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID);
		return result;
	}
	float GetRegionHeight(long RegionID)
	{
		float result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa0, DISPATCH_METHOD, VT_R4, (void*)&result, parms, RegionID);
		return result;
	}
	long GetRegionHeightPixels(long RegionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID);
		return result;
	}
	long GetRegionID(long RegionNo)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa2, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionNo);
		return result;
	}
	float GetRegionLeft(long RegionID)
	{
		float result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa3, DISPATCH_METHOD, VT_R4, (void*)&result, parms, RegionID);
		return result;
	}
	long GetRegionLeftPixels(long RegionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa4, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID);
		return result;
	}
	long GetRegionMixMode(long RegionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID);
		return result;
	}
	CString GetRegionName(long RegionID)
	{
		CString result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa6, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, RegionID);
		return result;
	}
	long GetRegionPage(long RegionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID);
		return result;
	}
	BOOL GetRegionSelected(long RegionID)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa8, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, RegionID);
		return result;
	}
	float GetRegionTop(long RegionID)
	{
		float result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xa9, DISPATCH_METHOD, VT_R4, (void*)&result, parms, RegionID);
		return result;
	}
	long GetRegionTopPixels(long RegionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xaa, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID);
		return result;
	}
	float GetRegionWidth(long RegionID)
	{
		float result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xab, DISPATCH_METHOD, VT_R4, (void*)&result, parms, RegionID);
		return result;
	}
	long GetRegionWidthPixels(long RegionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xac, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID);
		return result;
	}
	long GetSelectedAnnotationIdx()
	{
		long result;
		InvokeHelper(0xad, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetSelectedText()
	{
		CString result;
		InvokeHelper(0xae, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long GetSelectedTextRegion(long RegionIdx, float * RegionLeft, float * RegionTop, float * RegionWidth, float * RegionHeight)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 ;
		InvokeHelper(0xaf, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionIdx, RegionLeft, RegionTop, RegionWidth, RegionHeight);
		return result;
	}
	long GetSelectedTextRegionsCount()
	{
		long result;
		InvokeHelper(0xb0, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetStat()
	{
		long result;
		InvokeHelper(0xb1, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetTextOccurrenceCount(long Page, LPCTSTR Text, BOOL CaseSensitive, BOOL WholeWords)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_BOOL VTS_BOOL ;
		InvokeHelper(0xb2, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Page, Text, CaseSensitive, WholeWords);
		return result;
	}
	long GetTextOccurrenceCount_2(long Page, LPCTSTR Text, BOOL CaseSensitive, BOOL WholeWords, BOOL OrdinalComparison)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_BOOL VTS_BOOL VTS_BOOL ;
		InvokeHelper(0xb3, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Page, Text, CaseSensitive, WholeWords, OrdinalComparison);
		return result;
	}
	double GetVersion()
	{
		double result;
		InvokeHelper(0xb4, DISPATCH_METHOD, VT_R8, (void*)&result, nullptr);
		return result;
	}
	long GetVScrollBarMaxPosition()
	{
		long result;
		InvokeHelper(0xb5, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetVScrollBarPosition()
	{
		long result;
		InvokeHelper(0xb6, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void GifPlay()
	{
		InvokeHelper(0xb7, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void GifStop()
	{
		InvokeHelper(0xb8, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long HideTextEditBox(BOOL SaveText)
	{
		long result;
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0xb9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SaveText);
		return result;
	}
	long IPTCCount()
	{
		long result;
		InvokeHelper(0xba, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long IPTCGetID(long TagNo)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xbb, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagNo);
		return result;
	}
	CString IPTCGetValueString(long TagNo)
	{
		CString result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xbc, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, TagNo);
		return result;
	}
	BOOL IsAnnotationVisibleAt(long AnnotationIdx, long X, long Y)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_I4 ;
		InvokeHelper(0xbd, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, AnnotationIdx, X, Y);
		return result;
	}
	BOOL IsRect()
	{
		BOOL result;
		InvokeHelper(0xbe, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL IsRectDrawing()
	{
		BOOL result;
		InvokeHelper(0xbf, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL IsRectEditing()
	{
		BOOL result;
		InvokeHelper(0xc0, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	long LoadAnnotationsFromXMP(LPCTSTR FilePath)
	{
		long result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0xc1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath);
		return result;
	}
	CString PdfGetAuthor()
	{
		CString result;
		InvokeHelper(0xc2, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString PdfGetCreationDate()
	{
		CString result;
		InvokeHelper(0xc3, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString PdfGetCreator()
	{
		CString result;
		InvokeHelper(0xc4, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long PdfGetEncryptionScheme()
	{
		long result;
		InvokeHelper(0xc5, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString PdfGetKeywords()
	{
		CString result;
		InvokeHelper(0xc6, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString PdfGetMetadata()
	{
		CString result;
		InvokeHelper(0xc7, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString PdfGetModificationDate()
	{
		CString result;
		InvokeHelper(0xc8, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	double PdfGetPageHeight()
	{
		double result;
		InvokeHelper(0xc9, DISPATCH_METHOD, VT_R8, (void*)&result, nullptr);
		return result;
	}
	double PdfGetPageWidth()
	{
		double result;
		InvokeHelper(0xca, DISPATCH_METHOD, VT_R8, (void*)&result, nullptr);
		return result;
	}
	CString PdfGetProducer()
	{
		CString result;
		InvokeHelper(0xcb, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString PdfGetSubject()
	{
		CString result;
		InvokeHelper(0xcc, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString PdfGetTitle()
	{
		CString result;
		InvokeHelper(0xcd, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString PdfGetVersion()
	{
		CString result;
		InvokeHelper(0xce, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long Print()
	{
		long result;
		InvokeHelper(0xcf, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL PrintDialog()
	{
		BOOL result;
		InvokeHelper(0xd0, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL PrintDialog_2(long PrintSizeMode)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xd1, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, PrintSizeMode);
		return result;
	}
	CString PrintGetActivePrinter()
	{
		CString result;
		InvokeHelper(0xd2, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long PrintGetAlignment()
	{
		long result;
		InvokeHelper(0xd3, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL PrintGetCollate()
	{
		BOOL result;
		InvokeHelper(0xd4, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	long PrintGetColorMode()
	{
		long result;
		InvokeHelper(0xd5, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	short PrintGetCopies()
	{
		short result;
		InvokeHelper(0xd6, DISPATCH_METHOD, VT_I2, (void*)&result, nullptr);
		return result;
	}
	CString PrintGetDocumentName()
	{
		CString result;
		InvokeHelper(0xd7, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long PrintGetDuplexMode()
	{
		long result;
		InvokeHelper(0xd8, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString PrintGetLastError()
	{
		CString result;
		InvokeHelper(0xd9, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long PrintGetMargins(float * LeftMargin, float * TopMargin)
	{
		long result;
		static BYTE parms[] = VTS_PR4 VTS_PR4 ;
		InvokeHelper(0xda, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LeftMargin, TopMargin);
		return result;
	}
	long PrintGetOrientation()
	{
		long result;
		InvokeHelper(0xdb, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long PrintGetPaperBin()
	{
		long result;
		InvokeHelper(0xdc, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	float PrintGetPaperHeight()
	{
		float result;
		InvokeHelper(0xdd, DISPATCH_METHOD, VT_R4, (void*)&result, nullptr);
		return result;
	}
	long PrintGetPaperSize()
	{
		long result;
		InvokeHelper(0xde, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	float PrintGetPaperWidth()
	{
		float result;
		InvokeHelper(0xdf, DISPATCH_METHOD, VT_R4, (void*)&result, nullptr);
		return result;
	}
	CString PrintGetPrinterName(long PrinterNo)
	{
		CString result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xe0, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, PrinterNo);
		return result;
	}
	long PrintGetPrintersCount()
	{
		long result;
		InvokeHelper(0xe1, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	LPUNKNOWN PrintGetPrinterSettings()
	{
		LPUNKNOWN result;
		InvokeHelper(0xe2, DISPATCH_METHOD, VT_UNKNOWN, (void*)&result, nullptr);
		return result;
	}
	long PrintGetQuality()
	{
		long result;
		InvokeHelper(0xe3, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long PrintGetStat()
	{
		long result;
		InvokeHelper(0xe4, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long PrintInterop()
	{
		long result;
		InvokeHelper(0xe5, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long PrintInterop_2()
	{
		long result;
		InvokeHelper(0xe6, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL PrintSetActivePrinter(LPCTSTR PrinterName)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0xe7, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, PrinterName);
		return result;
	}
	long PrintSetAlignment(long ImageAlignment)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xe8, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageAlignment);
		return result;
	}
	long PrintSetAutoRotation(BOOL AutoRotation)
	{
		long result;
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0xe9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AutoRotation);
		return result;
	}
	long PrintSetCollate(BOOL Collate)
	{
		long result;
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0xea, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Collate);
		return result;
	}
	long PrintSetColorMode(long ColorMode)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xeb, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ColorMode);
		return result;
	}
	long PrintSetCopies(short Copies)
	{
		long result;
		static BYTE parms[] = VTS_I2 ;
		InvokeHelper(0xec, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Copies);
		return result;
	}
	long PrintSetDocumentName(LPCTSTR DocumentName)
	{
		long result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0xed, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DocumentName);
		return result;
	}
	long PrintSetDuplexMode(long DuplexMode)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xee, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DuplexMode);
		return result;
	}
	long PrintSetFromToPage(long FromPage, long ToPage)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0xef, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FromPage, ToPage);
		return result;
	}
	long PrintSetOrientation(long Orientation)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xf0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Orientation);
		return result;
	}
	long PrintSetPageSelection(LPCTSTR CustomRange)
	{
		long result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0xf1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, CustomRange);
		return result;
	}
	BOOL PrintSetPaperBin(long PaperBin)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xf2, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, PaperBin);
		return result;
	}
	BOOL PrintSetPaperBin_2(LPUNKNOWN PaperBin)
	{
		BOOL result;
		static BYTE parms[] = VTS_UNKNOWN ;
		InvokeHelper(0xf3, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, PaperBin);
		return result;
	}
	long PrintSetPreRasterization(BOOL PreRasterization)
	{
		long result;
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0xf4, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PreRasterization);
		return result;
	}
	long PrintSetPreRasterizationDPI(float DPI)
	{
		long result;
		static BYTE parms[] = VTS_R4 ;
		InvokeHelper(0x14a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DPI);
		return result;
	}
	long PrintSetPrinterSettings(LPUNKNOWN PS)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN ;
		InvokeHelper(0xf5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PS);
		return result;
	}
	long PrintSetQuality(long Quality)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xf6, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Quality);
		return result;
	}
	long PrintSetShowPrintingProgress(BOOL Show)
	{
		long result;
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0xf7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Show);
		return result;
	}
	long PrintSetStdPaperSize(long PaperSize)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xf8, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PaperSize);
		return result;
	}
	long PrintSetUserPaperSize(float PaperWidth, float PaperHeight)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 ;
		InvokeHelper(0xf9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PaperWidth, PaperHeight);
		return result;
	}
	long PrintShowPrinterSettingsDialog()
	{
		long result;
		InvokeHelper(0xfa, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long PrintShowPrinterSettingsDialog_2(long HANDLE)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xfb, DISPATCH_METHOD, VT_I4, (void*)&result, parms, HANDLE);
		return result;
	}
	long Print_2(long PrintSizeMode)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0xfc, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PrintSizeMode);
		return result;
	}
	long Redraw()
	{
		long result;
		InvokeHelper(0xfd, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void Refresh()
	{
		InvokeHelper(0xfe, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long RegionCount()
	{
		long result;
		InvokeHelper(0xff, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ReleaseGdPictureImage(long ImageID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x100, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageID);
		return result;
	}
	void ReloadAnnotations()
	{
		InvokeHelper(0x101, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long RemoveAllRegions()
	{
		long result;
		InvokeHelper(0x102, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void RemoveItemMenu(long MenuItemIdx)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x103, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, MenuItemIdx);
	}
	long RemoveRegionByID(long RegionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x104, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID);
		return result;
	}
	long RemoveRegionByName(LPCTSTR Name)
	{
		long result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0x105, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Name);
		return result;
	}
	long Rotate(long Rotation)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x106, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Rotation);
		return result;
	}
	long RotateAnnotations(long Angle)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x107, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Angle);
		return result;
	}
	long RotateView(long Rotation)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x108, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Rotation);
		return result;
	}
	long SaveAnnotationsToPage()
	{
		long result;
		InvokeHelper(0x109, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SaveAnnotationsToXMP(LPCTSTR FilePath)
	{
		long result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0x10a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath);
		return result;
	}
	long SaveAnnotationsToXMPEx(LPCTSTR FilePath)
	{
		long result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0x10b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath);
		return result;
	}
	long SaveDocumentToJPEG(LPCTSTR FilePath, long Quality)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 ;
		InvokeHelper(0x10c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, Quality);
		return result;
	}
	long SaveDocumentToJPEG_2(LPCTSTR Uri, LPCTSTR Login, LPCTSTR Password, long Quality)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR VTS_I4 ;
		InvokeHelper(0x10d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Uri, Login, Password, Quality);
		return result;
	}
	long SaveDocumentToPDF(LPCTSTR FilePath)
	{
		long result;
		static BYTE parms[] = VTS_BSTR ;
		InvokeHelper(0x10e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath);
		return result;
	}
	long SaveDocumentToPDF_2(LPCTSTR Uri, LPCTSTR Login, LPCTSTR Password)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR ;
		InvokeHelper(0x10f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Uri, Login, Password);
		return result;
	}
	long SaveDocumentToTIFF(LPCTSTR FilePath, long Compression)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 ;
		InvokeHelper(0x110, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, Compression);
		return result;
	}
	long SaveDocumentToTIFF_2(LPCTSTR Uri, LPCTSTR Login, LPCTSTR Password, long Compression)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR VTS_I4 ;
		InvokeHelper(0x111, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Uri, Login, Password, Compression);
		return result;
	}
	BOOL SearchText(LPCTSTR Text, long Occurrence, BOOL CaseSensitive)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL ;
		InvokeHelper(0x112, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Text, Occurrence, CaseSensitive);
		return result;
	}
	BOOL SearchText_2(LPCTSTR Text, long Occurrence, BOOL CaseSensitive, BOOL WholeWords)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL ;
		InvokeHelper(0x113, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Text, Occurrence, CaseSensitive, WholeWords);
		return result;
	}
	BOOL SearchText_3(long Page, LPCTSTR Text, long Occurrence, BOOL CaseSensitive, float * Left, float * Top, float * Width, float * Height)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_I4 VTS_BOOL VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 ;
		InvokeHelper(0x114, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Page, Text, Occurrence, CaseSensitive, Left, Top, Width, Height);
		return result;
	}
	BOOL SearchText_4(long Page, LPCTSTR Text, long Occurrence, BOOL CaseSensitive, BOOL WholeWords, float * Left, float * Top, float * Width, float * Height)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 ;
		InvokeHelper(0x115, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Page, Text, Occurrence, CaseSensitive, WholeWords, Left, Top, Width, Height);
		return result;
	}
	BOOL SearchText_5(LPCTSTR Text, long Occurrence, BOOL CaseSensitive, BOOL WholeWords, BOOL OrdinalComparison)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL VTS_BOOL ;
		InvokeHelper(0x116, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Text, Occurrence, CaseSensitive, WholeWords, OrdinalComparison);
		return result;
	}
	BOOL SearchText_6(long Page, LPCTSTR Text, long Occurrence, BOOL CaseSensitive, BOOL WholeWords, BOOL OrdinalComparison, float * Left, float * Top, float * Width, float * Height)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL VTS_BOOL VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 ;
		InvokeHelper(0x117, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Page, Text, Occurrence, CaseSensitive, WholeWords, OrdinalComparison, Left, Top, Width, Height);
		return result;
	}
	BOOL SearchTextRegex(LPCTSTR Pattern, long Occurence, BOOL CaseSensitive)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL ;
		InvokeHelper(0x14d, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Pattern, Occurence, CaseSensitive);
		return result;
	}
	long SelectAllText()
	{
		long result;
		InvokeHelper(0x118, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SelectAnnotation(long AnnotationIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x119, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	void SetAnnotationEditorMode(BOOL EditorMode)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x11a, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, EditorMode);
	}
	void SetBackgroundColor(long Color)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x11b, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Color);
	}
	void SetFtpPassiveMode(BOOL PassiveMode)
	{
		static BYTE parms[] = VTS_BOOL ;
		InvokeHelper(0x11c, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, PassiveMode);
	}
	void SetHScrollBarPosition(long NewPos)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x11d, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, NewPos);
	}
	void SetHttpTransferBufferSize(long Buffersize)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x11e, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Buffersize);
	}
	void SetHVScrollBarPosition(long NewPosH, long NewPosV)
	{
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x11f, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, NewPosH, NewPosV);
	}
	void SetItemMenuCaption(long MenuItemIdx, LPCTSTR NewMenuCaption)
	{
		static BYTE parms[] = VTS_I4 VTS_BSTR ;
		InvokeHelper(0x120, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, MenuItemIdx, NewMenuCaption);
	}
	void SetItemMenuEnabled(long MenuItemIdx, BOOL Enable)
	{
		static BYTE parms[] = VTS_I4 VTS_BOOL ;
		InvokeHelper(0x121, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, MenuItemIdx, Enable);
	}
	void SetRectBorderColor(long Color)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x122, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Color);
	}
	void SetRectCoordinatesOnDocument(long Left, long Top, long Width, long Height)
	{
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_I4 VTS_I4 ;
		InvokeHelper(0x123, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Left, Top, Width, Height);
	}
	void SetRectCoordinatesOnDocumentInches(float Left, float Top, float Width, float Height)
	{
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 ;
		InvokeHelper(0x124, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Left, Top, Width, Height);
	}
	void SetRectCoordinatesOnViewer(long Left, long Top, long Width, long Height)
	{
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_I4 VTS_I4 ;
		InvokeHelper(0x125, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Left, Top, Width, Height);
	}
	long SetRegionBorderColor(long RegionID, long BorderColor)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x126, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, BorderColor);
		return result;
	}
	long SetRegionBorderWidth(long RegionID, long BorderWidth)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x127, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, BorderWidth);
		return result;
	}
	long SetRegionColor(long RegionID, long Color)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x128, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Color);
		return result;
	}
	long SetRegionColorSelection(long RegionID, long ColorSelection)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x129, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, ColorSelection);
		return result;
	}
	long SetRegionEditable(long RegionID, BOOL Editable)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL ;
		InvokeHelper(0x12a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Editable);
		return result;
	}
	long SetRegionHeight(long RegionID, float Height)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 ;
		InvokeHelper(0x12b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Height);
		return result;
	}
	long SetRegionHeightPixels(long RegionID, long Height)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x12c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Height);
		return result;
	}
	long SetRegionLeft(long RegionID, float Left)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 ;
		InvokeHelper(0x12d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Left);
		return result;
	}
	long SetRegionLeftPixels(long RegionID, long Left)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x12e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Left);
		return result;
	}
	long SetRegionMixMode(long RegionID, long MixMode)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x12f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, MixMode);
		return result;
	}
	long SetRegionName(long RegionID, LPCTSTR Name)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR ;
		InvokeHelper(0x130, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Name);
		return result;
	}
	long SetRegionPage(long RegionID, long Page)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x131, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Page);
		return result;
	}
	long SetRegionSelected(long RegionID, BOOL Selected)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL ;
		InvokeHelper(0x132, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Selected);
		return result;
	}
	long SetRegionTop(long RegionID, float Top)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 ;
		InvokeHelper(0x133, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Top);
		return result;
	}
	long SetRegionTopPixels(long RegionID, long Top)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x134, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Top);
		return result;
	}
	long SetRegionWidth(long RegionID, float Width)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 ;
		InvokeHelper(0x135, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Width);
		return result;
	}
	long SetRegionWidthPixels(long RegionID, long Width)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 ;
		InvokeHelper(0x136, DISPATCH_METHOD, VT_I4, (void*)&result, parms, RegionID, Width);
		return result;
	}
	void SetVScrollBarPosition(long NewPos)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x137, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, NewPos);
	}
	long SetZoom100()
	{
		long result;
		InvokeHelper(0x138, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SetZoomFitViewer()
	{
		long result;
		InvokeHelper(0x139, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SetZoomHeightViewer()
	{
		long result;
		InvokeHelper(0x13a, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SetZoomShrinkWidthViewer()
	{
		long result;
		InvokeHelper(0x13b, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SetZoomViewer()
	{
		long result;
		InvokeHelper(0x13c, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SetZoomWidthViewer()
	{
		long result;
		InvokeHelper(0x13d, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long TagCount()
	{
		long result;
		InvokeHelper(0x13f, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long TagGetID(long TagNo)
	{
		long result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x140, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagNo);
		return result;
	}
	CString TagGetName(long TagNo)
	{
		CString result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x141, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, TagNo);
		return result;
	}
	CString TagGetValueString(long TagNo)
	{
		CString result;
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x142, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, TagNo);
		return result;
	}
	long ZoomArea(long Left, long Top, long Width, long Height)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_I4 VTS_I4 ;
		InvokeHelper(0x143, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height);
		return result;
	}
	long ZoomIN()
	{
		long result;
		InvokeHelper(0x144, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ZoomOUT()
	{
		long result;
		InvokeHelper(0x145, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ZoomRect()
	{
		long result;
		InvokeHelper(0x146, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void ReleaseEventsTarget()
	{
		InvokeHelper(0x14b, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void AddRedactionAnnotInteractive(long BackColor)
	{
		static BYTE parms[] = VTS_I4 ;
		InvokeHelper(0x14c, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, BackColor);
	}


};
