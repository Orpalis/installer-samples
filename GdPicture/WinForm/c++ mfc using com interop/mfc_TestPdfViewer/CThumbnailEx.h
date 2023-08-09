// Machine generated IDispatch wrapper class(es) created with Add Class from Typelib Wizard

#import "C:\\GdPicture.NET 14\\Redist\\COM Interop\\GdPicture.NET.14.tlb" no_namespace
// CThumbnailEx wrapper class

class CThumbnailEx : public COleDispatchDriver
{
public:
	CThumbnailEx() {} // Calls COleDispatchDriver default constructor
	CThumbnailEx(LPDISPATCH pDispatch) : COleDispatchDriver(pDispatch) {}
	CThumbnailEx(const CThumbnailEx& dispatchSrc) : COleDispatchDriver(dispatchSrc) {}

	// Attributes
public:

	// Operations
public:


	// IThumbnailEx methods
public:
	BOOL get_HotTracking()
	{
		BOOL result;
		InvokeHelper(0x1, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_HotTracking(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x1, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	CString get_DefaultItemTextPrefix()
	{
		CString result;
		InvokeHelper(0x3, DISPATCH_PROPERTYGET, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	void put_DefaultItemTextPrefix(LPCTSTR newValue)
	{
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x3, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_PdfIncreaseTextContrast()
	{
		BOOL result;
		InvokeHelper(0x4, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PdfIncreaseTextContrast(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x4, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_RotateExif()
	{
		BOOL result;
		InvokeHelper(0x5, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_RotateExif(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x5, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_OwnDrop()
	{
		BOOL result;
		InvokeHelper(0x6, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_OwnDrop(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x6, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_PauseThumbsLoading()
	{
		BOOL result;
		InvokeHelper(0x7, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PauseThumbsLoading(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x7, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_PreloadAllItems()
	{
		BOOL result;
		InvokeHelper(0x8, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_PreloadAllItems(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x8, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_AllItemsLoaded()
	{
		BOOL result;
		InvokeHelper(0x9, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	long get_ThumbnailBackColor()
	{
		long result;
		InvokeHelper(0xa, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_ThumbnailBackColor(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xa, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_SelectedThumbnailBackColor()
	{
		long result;
		InvokeHelper(0xb, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_SelectedThumbnailBackColor(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xb, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_HorizontalTextAlignment()
	{
		long result;
		InvokeHelper(0xc, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_HorizontalTextAlignment(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xc, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_VerticalTextAlignment()
	{
		long result;
		InvokeHelper(0xd, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_VerticalTextAlignment(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xd, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_ThumbnailBorder()
	{
		BOOL result;
		InvokeHelper(0xe, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_ThumbnailBorder(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0xe, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_ThumbnailAlignment()
	{
		long result;
		InvokeHelper(0xf, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_ThumbnailAlignment(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xf, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_ItemCount()
	{
		long result;
		InvokeHelper(0x10, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL get_CheckBoxes()
	{
		BOOL result;
		InvokeHelper(0x11, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_CheckBoxes(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x11, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_CheckBoxesMarginLeft()
	{
		long result;
		InvokeHelper(0x12, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_CheckBoxesMarginLeft(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x12, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_CheckBoxesMarginTop()
	{
		long result;
		InvokeHelper(0x13, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_CheckBoxesMarginTop(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x13, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_TextMarginLeft()
	{
		long result;
		InvokeHelper(0x14, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_TextMarginLeft(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x14, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_TextMarginTop()
	{
		long result;
		InvokeHelper(0x15, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_TextMarginTop(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x15, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_Multiselect()
	{
		BOOL result;
		InvokeHelper(0x16, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_Multiselect(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x16, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_AllowMoveItems()
	{
		BOOL result;
		InvokeHelper(0x17, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_AllowMoveItems(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x17, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_AllowDropFiles()
	{
		BOOL result;
		InvokeHelper(0x18, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_AllowDropFiles(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x18, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_LockGdViewerEvents()
	{
		BOOL result;
		InvokeHelper(0x19, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_LockGdViewerEvents(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x19, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long get_BackColor()
	{
		long result;
		InvokeHelper(0x1a, DISPATCH_PROPERTYGET, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void put_BackColor(long newValue)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1a, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_ShowText()
	{
		BOOL result;
		InvokeHelper(0x1b, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_ShowText(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x1b, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	BOOL get_DisplayAnnotations()
	{
		BOOL result;
		InvokeHelper(0x1c, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_DisplayAnnotations(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x1c, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}
	long AddItemFromFile(LPCTSTR FilePath)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x1d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath);
		return result;
	}
	long AddItemFromGdPictureImage(long ImageID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageID);
		return result;
	}
	long AddItemFromGdPictureImage_2(long ImageID, LPCTSTR Text)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x1f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageID, Text);
		return result;
	}
	long ARGBI(unsigned char Alpha, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x20, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Alpha, Red, Green, Blue);
		return result;
	}
	void ClearAllItems()
	{
		InvokeHelper(0x21, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void Dispose()
	{
		InvokeHelper(0x22, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void EnsureVisibleItem(long ItemIdx)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x23, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, ItemIdx);
	}
	long FindNearestItem(long Direction, long X, long Y)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_I4;
		InvokeHelper(0x24, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Direction, X, Y);
		return result;
	}
	long GetItemAt(long X, long Y)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x25, DISPATCH_METHOD, VT_I4, (void*)&result, parms, X, Y);
		return result;
	}
	long GetItemBitmap(long ItemIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x26, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ItemIdx);
		return result;
	}
	BOOL GetItemCheckState(long ItemIdx)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x27, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, ItemIdx);
		return result;
	}
	CString GetItemFileSource(long ItemIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x28, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, ItemIdx);
		return result;
	}
	BOOL GetItemFocusState(long ItemIdx)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x29, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, ItemIdx);
		return result;
	}
	BOOL GetItemSelectState(long ItemIdx)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x2a, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, ItemIdx);
		return result;
	}
	VARIANT GetItemTag(long ItemIdx)
	{
		VARIANT result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x2b, DISPATCH_METHOD, VT_VARIANT, (void*)&result, parms, ItemIdx);
		return result;
	}
	CString GetItemText(long ItemIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x2c, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, ItemIdx);
		return result;
	}
	long InsertItemFromFile(LPCTSTR FilePath, long Position)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4;
		InvokeHelper(0x2d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, Position);
		return result;
	}
	long InsertItemFromGdPictureImage(long ImageID, LPCTSTR Text, long Position)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_I4;
		InvokeHelper(0x2e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageID, Text, Position);
		return result;
	}
	long LoadFromDirectory(LPCTSTR Path, BOOL IncludeSubFolders)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL;
		InvokeHelper(0x2f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Path, IncludeSubFolders);
		return result;
	}
	long LoadFromDirectory_2(LPCTSTR Path, BOOL IncludeSubFolders, LPCTSTR SearchPattern)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL VTS_BSTR;
		InvokeHelper(0x30, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Path, IncludeSubFolders, SearchPattern);
		return result;
	}
	long LoadFromDirectory_3(LPCTSTR Path, BOOL IncludeSubFolders, LPCTSTR SearchPatterns)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL VTS_BSTR;
		InvokeHelper(0x31, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Path, IncludeSubFolders, SearchPatterns);
		return result;
	}
	long LoadFromFiles(SAFEARRAY * Files)
	{
		long result;
		static BYTE parms[] = VTS_NONE;
		InvokeHelper(0x32, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Files);
		return result;
	}
	long LoadFromGdPictureImage(long ImageID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x33, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageID);
		return result;
	}
	long LoadFromGdPicturePDF(LPDISPATCH PDF)
	{
		long result;
		static BYTE parms[] = VTS_DISPATCH;
		InvokeHelper(0x34, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PDF);
		return result;
	}
	long LoadFromGdViewer(VARIANT& GdViewer)
	{
		long result;
		static BYTE parms[] = VTS_VARIANT;
		InvokeHelper(0x35, DISPATCH_METHOD, VT_I4, (void*)&result, parms, &GdViewer);
		return result;
	}
	void LoadNewThumbnails()
	{
		InvokeHelper(0x36, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void MoveItem(long ItemIdx, long dstIdx)
	{
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x37, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, ItemIdx, dstIdx);
	}
	void RedrawItem(long ItemIdx)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x38, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, ItemIdx);
	}
	void Refresh()
	{
		InvokeHelper(0x39, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long ReleaseGdPictureImage(long ImageID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x3a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageID);
		return result;
	}
	void ReloadThumbnails()
	{
		InvokeHelper(0x3b, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	void RemoveItem(long ItemIdx)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x3c, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, ItemIdx);
	}
	long SelectItem(long ItemIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x3d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ItemIdx);
		return result;
	}
	long SetItemBackgroundColor(long ItemIdx, long Color)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x3e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ItemIdx, Color);
		return result;
	}
	long SetItemBitmap(long ItemIdx, long ImageID)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x3f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ItemIdx, ImageID);
		return result;
	}
	long SetItemCheckState(long ItemIdx, BOOL Checked)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x40, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ItemIdx, Checked);
		return result;
	}
	long SetItemSelectState(long ItemIdx, BOOL Selected)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x41, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ItemIdx, Selected);
		return result;
	}
	long SetItemsFont(LPCTSTR FontName, float FontSize, long FontStyle)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_I4;
		InvokeHelper(0x42, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FontName, FontSize, FontStyle);
		return result;
	}
	void SetItemsSize(long Width, long Height)
	{
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x43, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Width, Height);
	}
	void SetItemsSpacing(long Horizontal, long Vertical)
	{
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x44, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Horizontal, Vertical);
	}
	long SetItemTag(long ItemIdx, VARIANT& Tag)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_VARIANT;
		InvokeHelper(0x45, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ItemIdx, &Tag);
		return result;
	}
	long SetItemText(long ItemIdx, LPCTSTR Text)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x46, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ItemIdx, Text);
		return result;
	}
	void SwapItemsBitmap(long Item1Idx, long Item2Idx)
	{
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x47, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Item1Idx, Item2Idx);
	}
	void SwapItemsBitmap_2(long Item1Idx, long Item2Idx, BOOL SwapText)
	{
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_BOOL;
		InvokeHelper(0x48, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Item1Idx, Item2Idx, SwapText);
	}
	void ReleaseEventsTarget()
	{
		InvokeHelper(0x49, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long SetItemToolTipText(long ItemIdx, LPCTSTR ToolTipText)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x4a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ItemIdx, ToolTipText);
		return result;
	}
	long LoadAllItems()
	{
		long result;
		InvokeHelper(0x4b, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long UnselectAllItems()
	{
		long result;
		InvokeHelper(0x4c, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL get_DefaultItemCheckState()
	{
		BOOL result;
		InvokeHelper(0x4d, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void put_DefaultItemCheckState(BOOL newValue)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x4d, DISPATCH_PROPERTYPUT, VT_EMPTY, nullptr, parms, newValue);
	}

	// IThumbnailEx properties
public:

};
