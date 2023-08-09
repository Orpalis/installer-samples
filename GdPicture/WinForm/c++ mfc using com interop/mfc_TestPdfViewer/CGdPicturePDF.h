// Machine generated IDispatch wrapper class(es) created with Add Class from Typelib Wizard

#import "C:\\GdPicture.NET 14\\Redist\\COM Interop\\GdPicture.NET.14.tlb" raw_interfaces_only
// CGdPicturePDF wrapper class

class CGdPicturePDF : public COleDispatchDriver
{
public:
	CGdPicturePDF() {} // Calls COleDispatchDriver default constructor
	CGdPicturePDF(LPDISPATCH pDispatch) : COleDispatchDriver(pDispatch) {}
	CGdPicturePDF(const CGdPicturePDF& dispatchSrc) : COleDispatchDriver(dispatchSrc) {}

	// Attributes
public:

	// Operations
public:


	// IGdPicturePDF methods
public:
	long AddCheckBoxFormField(float Left, float Top, float Width, float Height, LPCTSTR FieldName, long Style, BOOL Checked, unsigned char CheckMarkRed, unsigned char CheckMarkGreen, unsigned char CheckMarkBlue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_I4 VTS_BOOL VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, Style, Checked, CheckMarkRed, CheckMarkGreen, CheckMarkBlue);
		return result;
	}
	long AddCheckBoxFormField_2(float Left, float Top, float Width, float Height, LPCTSTR FieldName, long Style, BOOL Checked, unsigned char CheckMarkCyan, unsigned char CheckMarkMagenta, unsigned char CheckMarkYellow, unsigned char CheckMarkBlack)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_I4 VTS_BOOL VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x2, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, Style, Checked, CheckMarkCyan, CheckMarkMagenta, CheckMarkYellow, CheckMarkBlack);
		return result;
	}
	long AddCircleAnnotation(float Left, float Top, float Width, float Height, LPCTSTR Title, LPCTSTR Contents, float LineWidth, long LineStyle, float LineDashOn, float LineDashOff, float Opacity, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_R4 VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x3, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Title, Contents, LineWidth, LineStyle, LineDashOn, LineDashOff, Opacity, Red, Green, Blue);
		return result;
	}
	long AddComboFormField(float Left, float Top, float Width, float Height, LPCTSTR FieldName, LPCTSTR FontResName, float FontSize, unsigned char TextRed, unsigned char TextGreen, unsigned char TextBlue, BOOL Sorted)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_BOOL;
		InvokeHelper(0x4, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, FontResName, FontSize, TextRed, TextGreen, TextBlue, Sorted);
		return result;
	}
	long AddComboFormField_2(float Left, float Top, float Width, float Height, LPCTSTR FieldName, LPCTSTR FontResName, float FontSize, unsigned char TextCyan, unsigned char TextMagenta, unsigned char TextYellow, unsigned char TextBlack, BOOL Sorted)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_BOOL;
		InvokeHelper(0x5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, FontResName, FontSize, TextCyan, TextMagenta, TextYellow, TextBlack, Sorted);
		return result;
	}
	long AddCurveToPath1(float X1, float Y1, float X3, float Y3)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x6, DISPATCH_METHOD, VT_I4, (void*)&result, parms, X1, Y1, X3, Y3);
		return result;
	}
	long AddCurveToPath2(float X2, float Y2, float X3, float Y3)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, X2, Y2, X3, Y3);
		return result;
	}
	long AddCurveToPath3(float X1, float Y1, float X2, float Y2, float X3, float Y3)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x8, DISPATCH_METHOD, VT_I4, (void*)&result, parms, X1, Y1, X2, Y2, X3, Y3);
		return result;
	}
	long AddEllipseToPath(float CenterX, float CenterY, float Width, float Height)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, CenterX, CenterY, Width, Height);
		return result;
	}
	CString AddFontFromFileU(LPCTSTR FilePath, LPCTSTR FontName, long CharSet, BOOL Bold, BOOL Italic)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0xa, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FilePath, FontName, CharSet, Bold, Italic);
		return result;
	}
	long AddFormFieldItem(long FieldId, LPCTSTR Text)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0xb, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Text);
		return result;
	}
	long AddFormFieldItem_2(long FieldId, LPCTSTR Text, LPCTSTR Value)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_BSTR;
		InvokeHelper(0xc, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Text, Value);
		return result;
	}
	long AddFreeTextAnnotation(float Left, float Top, float Width, float Height, BOOL Borders, LPCTSTR Title, LPCTSTR Subject, LPCTSTR Contents, LPCTSTR FontResName, float FontSize, unsigned char FontColorRed, unsigned char FontColorGreen, unsigned char FontColorBlue, unsigned char FillColorRed, unsigned char FillColorGreen, unsigned char FillColorBlue, float Opacity)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_BSTR VTS_BSTR VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_R4;
		InvokeHelper(0xd, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Borders, Title, Subject, Contents, FontResName, FontSize, FontColorRed, FontColorGreen, FontColorBlue, FillColorRed, FillColorGreen, FillColorBlue, Opacity);
		return result;
	}
	long AddFreeTextAnnotation_2(float Left, float Top, float Width, float Height, BOOL Borders, LPCTSTR Title, LPCTSTR Subject, LPCTSTR Contents, LPCTSTR FontResName, float FontSize, unsigned char FontColorCyan, unsigned char FontColorMagenta, unsigned char FontColorYellow, unsigned char FontColorBlack, unsigned char FillColorCyan, unsigned char FillColorMagenta, unsigned char FillColorYellow, unsigned char FillColorBlack, float Opacity)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_BSTR VTS_BSTR VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_R4;
		InvokeHelper(0xe, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Borders, Title, Subject, Contents, FontResName, FontSize, FontColorCyan, FontColorMagenta, FontColorYellow, FontColorBlack, FillColorCyan, FillColorMagenta, FillColorYellow, FillColorBlack, Opacity);
		return result;
	}
	long AddGraphicsToPath(LPUNKNOWN GraphicsPath)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN;
		InvokeHelper(0xf, DISPATCH_METHOD, VT_I4, (void*)&result, parms, GraphicsPath);
		return result;
	}
	CString AddImageFromGdPictureImage(long ImageID, BOOL ImageMask, BOOL DrawImage)
	{
		CString result;
		static BYTE parms[] = VTS_I4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x10, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, ImageID, ImageMask, DrawImage);
		return result;
	}
	long AddImageFromGdPictureImage_2(long ImageID, long AvancedCompression)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x11, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageID, AvancedCompression);
		return result;
	}
	CString AddJpegImageFromFile(LPCTSTR FilePath)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x12, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FilePath);
		return result;
	}
	CString AddJpegImageFromIStream(LPUNKNOWN Stream)
	{
		CString result;
		static BYTE parms[] = VTS_UNKNOWN;
		InvokeHelper(0x13, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, Stream);
		return result;
	}
	long AddLineAnnotation(float StartX, float StartY, float DstX, float DstY, LPCTSTR Title, LPCTSTR Contents, long StartCap, long EndCap, BOOL ShowContent, float LineWidth, long LineStyle, float LineDashOn, float LineDashOff, float Opacity, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_I4 VTS_I4 VTS_BOOL VTS_R4 VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x14, DISPATCH_METHOD, VT_I4, (void*)&result, parms, StartX, StartY, DstX, DstY, Title, Contents, StartCap, EndCap, ShowContent, LineWidth, LineStyle, LineDashOn, LineDashOff, Opacity, Red, Green, Blue);
		return result;
	}
	long AddLineToPath(float DstX, float DstY)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4;
		InvokeHelper(0x15, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DstX, DstY);
		return result;
	}
	long AddLinkAnnotation(float Left, float Top, float Width, float Height, BOOL Borders, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x16, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Borders, Red, Green, Blue);
		return result;
	}
	long AddLinkAnnotation_2(float Left, float Top, float Width, float Height, BOOL Borders, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x17, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Borders, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long AddLinkToPageAnnotation(float Left, float Top, float Width, float Height, long PageNum, float DstLeft, float DstTop, BOOL Borders, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_I4 VTS_R4 VTS_R4 VTS_BOOL VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x18, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, PageNum, DstLeft, DstTop, Borders, Red, Green, Blue);
		return result;
	}
	long AddLinkToWebAnnotation(float Left, float Top, float Width, float Height, LPCTSTR Uri, BOOL Borders, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BOOL VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x19, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Uri, Borders, Red, Green, Blue);
		return result;
	}
	long AddListFormField(float Left, float Top, float Width, float Height, LPCTSTR FieldName, LPCTSTR FontResName, float FontSize, unsigned char TextRed, unsigned char TextGreen, unsigned char TextBlue, BOOL Sorted, BOOL Multiselect)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x1a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, FontResName, FontSize, TextRed, TextGreen, TextBlue, Sorted, Multiselect);
		return result;
	}
	long AddListFormField_2(float Left, float Top, float Width, float Height, LPCTSTR FieldName, LPCTSTR FontResName, float FontSize, unsigned char TextCyan, unsigned char TextMagenta, unsigned char TextYellow, unsigned char TextBlack, BOOL Sorted, BOOL Multiselect)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x1b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, FontResName, FontSize, TextCyan, TextMagenta, TextYellow, TextBlack, Sorted, Multiselect);
		return result;
	}
	long AddPageLabelsRange(long StartPage, long Style, LPCTSTR Prefix, long NumPortion)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_BSTR VTS_I4;
		InvokeHelper(0x1c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, StartPage, Style, Prefix, NumPortion);
		return result;
	}
	long AddPageRotation(long Angle)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Angle);
		return result;
	}
	long AddPushButtonFormField(float Left, float Top, float Width, float Height, LPCTSTR FieldName, LPCTSTR Caption, LPCTSTR FontResName, float FontSize, unsigned char TextRed, unsigned char TextGreen, unsigned char TextBlue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, Caption, FontResName, FontSize, TextRed, TextGreen, TextBlue);
		return result;
	}
	long AddPushButtonFormField_2(float Left, float Top, float Width, float Height, LPCTSTR FieldName, LPCTSTR Caption, LPCTSTR FontResName, float FontSize, unsigned char TextCyan, unsigned char TextMagenta, unsigned char TextYellow, unsigned char TextBlack)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, Caption, FontResName, FontSize, TextCyan, TextMagenta, TextYellow, TextBlack);
		return result;
	}
	long AddRadioButtonFormField(float Left, float Top, float Width, float Height, LPCTSTR GroupName, LPCTSTR FieldName, long Style, unsigned char CheckMarkRed, unsigned char CheckMarkGreen, unsigned char CheckMarkBlue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x20, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, GroupName, FieldName, Style, CheckMarkRed, CheckMarkGreen, CheckMarkBlue);
		return result;
	}
	long AddRadioButtonFormField_2(float Left, float Top, float Width, float Height, LPCTSTR GroupName, LPCTSTR FieldName, long Style, unsigned char CheckMarkCyan, unsigned char CheckMarkMagenta, unsigned char CheckMarkYellow, unsigned char CheckMarkBlack)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x21, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, GroupName, FieldName, Style, CheckMarkCyan, CheckMarkMagenta, CheckMarkYellow, CheckMarkBlack);
		return result;
	}
	long AddRotationAt(float Angle, float AtX, float AtY)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x22, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Angle, AtX, AtY);
		return result;
	}
	long AddSignatureFormField(float Left, float Top, float Width, float Height, LPCTSTR FieldName)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR;
		InvokeHelper(0x23, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName);
		return result;
	}
	long AddSquareAnnotation(float Left, float Top, float Width, float Height, LPCTSTR Title, LPCTSTR Contents, float LineWidth, long LineStyle, float LineDashOn, float LineDashOff, float Opacity, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_R4 VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x24, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Title, Contents, LineWidth, LineStyle, LineDashOn, LineDashOff, Opacity, Red, Green, Blue);
		return result;
	}
	long AddStampAnnotation(float Left, float Top, float Width, float Height, LPCTSTR Title, LPCTSTR Contents, long StampStyle, float Opacity, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_I4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x25, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Title, Contents, StampStyle, Opacity, Red, Green, Blue);
		return result;
	}
	CString AddStandardFont(long StdFont)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x26, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, StdFont);
		return result;
	}
	long AddStickyNoteAnnotation(long IconName, float Left, float Top, LPCTSTR Author, LPCTSTR Subject, LPCTSTR Contents, float Opacity, BOOL OpenPopup, unsigned char Red, unsigned char Green, unsigned char Blue, float PopupLeft, float PopupTop, float PopupWidth, float PopupHeight)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_BSTR VTS_R4 VTS_BOOL VTS_UI1 VTS_UI1 VTS_UI1 VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x27, DISPATCH_METHOD, VT_I4, (void*)&result, parms, IconName, Left, Top, Author, Subject, Contents, Opacity, OpenPopup, Red, Green, Blue, PopupLeft, PopupTop, PopupWidth, PopupHeight);
		return result;
	}
	long AddTextFormField(float Left, float Top, float Width, float Height, LPCTSTR FieldName, LPCTSTR Text, BOOL MultiLines, LPCTSTR FontResName, float FontSize, unsigned char TextRed, unsigned char TextGreen, unsigned char TextBlue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_BOOL VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x28, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, Text, MultiLines, FontResName, FontSize, TextRed, TextGreen, TextBlue);
		return result;
	}
	long AddTextFormField_2(float Left, float Top, float Width, float Height, LPCTSTR FieldName, LPCTSTR Text, BOOL MultiLines, LPCTSTR FontResName, float FontSize, unsigned char TextCyan, unsigned char TextMagenta, unsigned char TextYellow, unsigned char TextBlack)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BSTR VTS_BSTR VTS_BOOL VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x29, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, FieldName, Text, MultiLines, FontResName, FontSize, TextCyan, TextMagenta, TextYellow, TextBlack);
		return result;
	}
	long AddTransformationMatrix(float a, float b, float c, float d, float e, float f)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x2a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, a, b, c, d, e, f);
		return result;
	}
	CString AddTrueTypeFont(LPCTSTR FontName, BOOL Bold, BOOL Italic, BOOL Embedded)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL VTS_BOOL VTS_BOOL;
		InvokeHelper(0x2b, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FontName, Bold, Italic, Embedded);
		return result;
	}
	CString AddTrueTypeFontFromFile(LPCTSTR FilePath, BOOL Bold, BOOL Italic, BOOL Embedded)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL VTS_BOOL VTS_BOOL;
		InvokeHelper(0x2c, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FilePath, Bold, Italic, Embedded);
		return result;
	}
	CString AddTrueTypeFontFromFileU(LPCTSTR FilePath, LPCTSTR FileName, BOOL Bold, BOOL Italic, BOOL EnableSubset)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BOOL VTS_BOOL VTS_BOOL;
		InvokeHelper(0x2d, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FilePath, FileName, Bold, Italic, EnableSubset);
		return result;
	}
	CString AddTrueTypeFontU(LPCTSTR FontName, long CharSet, BOOL Bold, BOOL Italic)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x2e, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FontName, CharSet, Bold, Italic);
		return result;
	}
	CString AddTrueTypeFontU_2(LPCTSTR FontName, BOOL Bold, BOOL Italic, BOOL EnableSubset)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL VTS_BOOL VTS_BOOL;
		InvokeHelper(0x2f, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FontName, Bold, Italic, EnableSubset);
		return result;
	}
	long ApplySignature(LPCTSTR OutputFileName, long SignatureMode, BOOL Linearization)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL;
		InvokeHelper(0x30, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OutputFileName, SignatureMode, Linearization);
		return result;
	}
	long AttachTagToAnnotation(long TagID, long AnnotationIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x31, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, AnnotationIdx);
		return result;
	}
	long AttachTagToFormField(long TagID, long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x32, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, FieldId);
		return result;
	}
	float AutoDeskew(float MaxAngleOfResearch, BOOL Optimistic)
	{
		float result;
		static BYTE parms[] = VTS_R4 VTS_BOOL;
		InvokeHelper(0x33, DISPATCH_METHOD, VT_R4, (void*)&result, parms, MaxAngleOfResearch, Optimistic);
		return result;
	}
	long BeginMarkedContent(LPCTSTR StructType)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x34, DISPATCH_METHOD, VT_I4, (void*)&result, parms, StructType);
		return result;
	}
	long BeginMarkedContentSequence(long TagID, LPCTSTR StructType)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x35, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, StructType);
		return result;
	}
	long BeginOCGMarkedContent(long OCGId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x36, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId);
		return result;
	}
	long BeginPath(float DstX, float DstY)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4;
		InvokeHelper(0x37, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DstX, DstY);
		return result;
	}
	CString BeginXObjectForm(float Width, float Height)
	{
		CString result;
		static BYTE parms[] = VTS_R4 VTS_R4;
		InvokeHelper(0x38, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, Width, Height);
		return result;
	}
	long ClearPageContent()
	{
		long result;
		InvokeHelper(0x39, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ClipPath()
	{
		long result;
		InvokeHelper(0x3a, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ClipPathOdd()
	{
		long result;
		InvokeHelper(0x3b, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ClonePage(long pageNo)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x3c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, pageNo);
		return result;
	}
	long ClonePage_2(LPDISPATCH FromPDF, long pageNo)
	{
		long result;
		static BYTE parms[] = VTS_DISPATCH VTS_I4;
		InvokeHelper(0x3d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FromPDF, pageNo);
		return result;
	}
	long CloseAndFillAndStrokePath()
	{
		long result;
		InvokeHelper(0x3e, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long CloseAndFillAndStrokePathOdd()
	{
		long result;
		InvokeHelper(0x3f, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long CloseAndStrokePath()
	{
		long result;
		InvokeHelper(0x40, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long CloseDocument()
	{
		long result;
		InvokeHelper(0x41, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ClosePath()
	{
		long result;
		InvokeHelper(0x42, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ConvertToPDFA(LPCTSTR FilePath, long Conformance, BOOL AllowVectorization, BOOL AllowRasterization)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x43, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, Conformance, AllowVectorization, AllowRasterization);
		return result;
	}
	long CreateFromText(long Conformance, float PageWidth, float PageHeight, float MarginLeft, float MarginTop, float MarginRight, float MarginBottom, long TextAlignment, LPCTSTR Text, float TextSize, LPCTSTR FontName, BOOL FontBold, BOOL FontItalic, BOOL Embedded, BOOL UseFontBbox)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_I4 VTS_BSTR VTS_R4 VTS_BSTR VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL;
		InvokeHelper(0x44, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Conformance, PageWidth, PageHeight, MarginLeft, MarginTop, MarginRight, MarginBottom, TextAlignment, Text, TextSize, FontName, FontBold, FontItalic, Embedded, UseFontBbox);
		return result;
	}
	long DeleteCustomPDFInformation(LPCTSTR Key)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x45, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Key);
		return result;
	}
	long DeleteEmbeddedFile(long FileIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x46, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FileIdx);
		return result;
	}
	long DeleteFormFieldItem(long FieldId, long ItemIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x47, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ItemIdx);
		return result;
	}
	long DeleteImage(LPCTSTR ImageResName)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x48, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageResName);
		return result;
	}
	long DeleteOCG(long OCGId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x49, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId);
		return result;
	}
	long DeleteOCG_2(long OCGId, BOOL RemoveContent)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x26a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId, RemoveContent);
		return result;
	}
	long DeletePage(long pageNo)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x4a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, pageNo);
		return result;
	}
	long DeletePageLabels()
	{
		long result;
		InvokeHelper(0x4b, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long DeletePageLabelsRange(long LabelingRangeIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x4c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LabelingRangeIdx);
		return result;
	}
	long DeletePagePrivateTag(LPCTSTR Tag)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x4d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Tag);
		return result;
	}
	long DeletePageThumbnailImage()
	{
		long result;
		InvokeHelper(0x4e, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void Dispose()
	{
		InvokeHelper(0x4f, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long DrawArc(float Left, float Top, float Radius, float StartAngle, float EndAngle, BOOL Close, BOOL Fill, BOOL Stroke)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_BOOL VTS_BOOL;
		InvokeHelper(0x51, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Radius, StartAngle, EndAngle, Close, Fill, Stroke);
		return result;
	}
	long DrawBarcode1D(long BarcodeType, LPCTSTR Data, float DstX, float DstY, float DstWidth, float DstHeight, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x52, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BarcodeType, Data, DstX, DstY, DstWidth, DstHeight, Red, Green, Blue);
		return result;
	}
	long DrawBarcode1D_2(long BarcodeType, LPCTSTR Data, float DstX, float DstY, float DstWidth, float DstHeight, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x53, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BarcodeType, Data, DstX, DstY, DstWidth, DstHeight, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long DrawBarcodeAztec(LPCTSTR Data, long Version, long EccPercent, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x54, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, Version, EccPercent, QuietZone, ModuleSize, DstX, DstY, Red, Green, Blue);
		return result;
	}
	long DrawBarcodeAztec_2(LPCTSTR Data, long Version, long EccPercent, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x55, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, Version, EccPercent, QuietZone, ModuleSize, DstX, DstY, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long DrawBarcodeAztec_3(LPCTSTR Data, long Version, long EccPercent, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char FillColorR, unsigned char FillColorG, unsigned char FillColorB, unsigned char BackColorR, unsigned char BackColorG, unsigned char BackColorB)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x56, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, Version, EccPercent, QuietZone, ModuleSize, DstX, DstY, FillColorR, FillColorG, FillColorB, BackColorR, BackColorG, BackColorB);
		return result;
	}
	long DrawBarcodeAztec_4(LPCTSTR Data, long Version, long EccPercent, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char FillColorC, unsigned char FillColorM, unsigned char FillColorY, unsigned char FillColorK, unsigned char BackColorC, unsigned char BackColorM, unsigned char BackColorY, unsigned char BackColorK)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x57, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, Version, EccPercent, QuietZone, ModuleSize, DstX, DstY, FillColorC, FillColorM, FillColorY, FillColorK, BackColorC, BackColorM, BackColorY, BackColorK);
		return result;
	}
	long DrawBarcodeDataMatrix(LPCTSTR Data, long EncodingMode, long Version, long ModuleSize, float DstX, float DstY, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x58, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, Version, ModuleSize, DstX, DstY, Red, Green, Blue);
		return result;
	}
	long DrawBarcodeDataMatrix_2(LPCTSTR Data, long EncodingMode, long Version, long ModuleSize, float DstX, float DstY, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x59, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, Version, ModuleSize, DstX, DstY, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long DrawBarcodeDataMatrix_3(LPCTSTR Data, long EncodingMode, long Version, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char FillColorR, unsigned char FillColorG, unsigned char FillColorB, unsigned char BackColorR, unsigned char BackColorG, unsigned char BackColorB)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x5a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, Version, QuietZone, ModuleSize, DstX, DstY, FillColorR, FillColorG, FillColorB, BackColorR, BackColorG, BackColorB);
		return result;
	}
	long DrawBarcodeDataMatrix_4(LPCTSTR Data, long EncodingMode, long Version, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char FillColorC, unsigned char FillColorM, unsigned char FillColorY, unsigned char FillColorK, unsigned char BackColorC, unsigned char BackColorM, unsigned char BackColorY, unsigned char BackColorK)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x5b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, Version, QuietZone, ModuleSize, DstX, DstY, FillColorC, FillColorM, FillColorY, FillColorK, BackColorC, BackColorM, BackColorY, BackColorK);
		return result;
	}
	long DrawBarcodeMicroMicroQrCode(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Version, long ModuleSize, float DstX, float DstY, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x5c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Version, ModuleSize, DstX, DstY, Red, Green, Blue);
		return result;
	}
	long DrawBarcodeMicroMicroQrCode_2(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Version, long ModuleSize, float DstX, float DstY, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x5d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Version, ModuleSize, DstX, DstY, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long DrawBarcodeMicroMicroQrCode_3(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Version, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char FillColorR, unsigned char FillColorG, unsigned char FillColorB, unsigned char BackColorR, unsigned char BackColorG, unsigned char BackColorB)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x5e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Version, QuietZone, ModuleSize, DstX, DstY, FillColorR, FillColorG, FillColorB, BackColorR, BackColorG, BackColorB);
		return result;
	}
	long DrawBarcodeMicroMicroQrCode_4(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Version, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char FillColorC, unsigned char FillColorM, unsigned char FillColorY, unsigned char FillColorK, unsigned char BackColorC, unsigned char BackColorM, unsigned char BackColorY, unsigned char BackColorK)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x5f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Version, QuietZone, ModuleSize, DstX, DstY, FillColorC, FillColorM, FillColorY, FillColorK, BackColorC, BackColorM, BackColorY, BackColorK);
		return result;
	}
	long DrawBarcodePDF417(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Rows, long Cols, long ModuleWidth, long RowHeight, float DstX, float DstY, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x60, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Rows, Cols, ModuleWidth, RowHeight, DstX, DstY, Red, Green, Blue);
		return result;
	}
	long DrawBarcodePDF417_2(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Rows, long Cols, long ModuleWidth, long RowHeight, float DstX, float DstY, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x61, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Rows, Cols, ModuleWidth, RowHeight, DstX, DstY, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long DrawBarcodePDF417_3(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Rows, long Cols, long QuietZone, long ModuleWidth, long RowHeight, float DstX, float DstY, unsigned char FillColorR, unsigned char FillColorG, unsigned char FillColorB, unsigned char BackColorR, unsigned char BackColorG, unsigned char BackColorB)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x62, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Rows, Cols, QuietZone, ModuleWidth, RowHeight, DstX, DstY, FillColorR, FillColorG, FillColorB, BackColorR, BackColorG, BackColorB);
		return result;
	}
	long DrawBarcodePDF417_4(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Rows, long Cols, long QuietZone, long ModuleWidth, long RowHeight, float DstX, float DstY, unsigned char FillColorC, unsigned char FillColorM, unsigned char FillColorY, unsigned char FillColorK, unsigned char BackColorC, unsigned char BackColorM, unsigned char BackColorY, unsigned char BackColorK)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x63, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Rows, Cols, QuietZone, ModuleWidth, RowHeight, DstX, DstY, FillColorC, FillColorM, FillColorY, FillColorK, BackColorC, BackColorM, BackColorY, BackColorK);
		return result;
	}
	long DrawBarcodeQrCode(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Version, long ModuleSize, float DstX, float DstY, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x64, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Version, ModuleSize, DstX, DstY, Red, Green, Blue);
		return result;
	}
	long DrawBarcodeQrCode_2(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Version, long ModuleSize, float DstX, float DstY, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x65, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Version, ModuleSize, DstX, DstY, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long DrawBarcodeQrCode_3(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Version, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char FillColorR, unsigned char FillColorG, unsigned char FillColorB, unsigned char BackColorR, unsigned char BackColorG, unsigned char BackColorB)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x66, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Version, QuietZone, ModuleSize, DstX, DstY, FillColorR, FillColorG, FillColorB, BackColorR, BackColorG, BackColorB);
		return result;
	}
	long DrawBarcodeQrCode_4(LPCTSTR Data, long EncodingMode, long ErrorCorrectionLevel, long Version, long QuietZone, long ModuleSize, float DstX, float DstY, unsigned char FillColorC, unsigned char FillColorM, unsigned char FillColorY, unsigned char FillColorK, unsigned char BackColorC, unsigned char BackColorM, unsigned char BackColorY, unsigned char BackColorK)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x67, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Data, EncodingMode, ErrorCorrectionLevel, Version, QuietZone, ModuleSize, DstX, DstY, FillColorC, FillColorM, FillColorY, FillColorK, BackColorC, BackColorM, BackColorY, BackColorK);
		return result;
	}
	long DrawCircle(float CenterX, float CenterY, float Radius, BOOL Fill, BOOL Stroke)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x68, DISPATCH_METHOD, VT_I4, (void*)&result, parms, CenterX, CenterY, Radius, Fill, Stroke);
		return result;
	}
	long DrawEllipse(float CenterX, float CenterY, float Width, float Height, BOOL Fill, BOOL Stroke)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x69, DISPATCH_METHOD, VT_I4, (void*)&result, parms, CenterX, CenterY, Width, Height, Fill, Stroke);
		return result;
	}
	long DrawImage(LPCTSTR ImageResName, float DstX, float DstY, float Width, float Height)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x6a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageResName, DstX, DstY, Width, Height);
		return result;
	}
	long DrawLine(float StartX, float StartY, float DstX, float DstY)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x6b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, StartX, StartY, DstX, DstY);
		return result;
	}
	long DrawPage(LPDISPATCH SrcPDF, long SrcPage, float DstX, float DstY, float DstWidth, float DstHeight)
	{
		long result;
		static BYTE parms[] = VTS_DISPATCH VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x6c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SrcPDF, SrcPage, DstX, DstY, DstWidth, DstHeight);
		return result;
	}
	long DrawPie(float Left, float Top, float Radius, float StartAngle, float EndAngle, BOOL Fill, BOOL Stroke)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x6d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Radius, StartAngle, EndAngle, Fill, Stroke);
		return result;
	}
	long DrawRectangle(float Left, float Top, float Width, float Height, BOOL Fill, BOOL Stroke)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x6e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Fill, Stroke);
		return result;
	}
	long DrawRotatedText(LPCTSTR FontResName, float DstX, float DstY, LPCTSTR Text, float Angle)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_BSTR VTS_R4;
		InvokeHelper(0x6f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FontResName, DstX, DstY, Text, Angle);
		return result;
	}
	long DrawRoundedRectangle(float Left, float Top, float Width, float Height, float Radius, BOOL Fill, BOOL Stroke)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x70, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Radius, Fill, Stroke);
		return result;
	}
	long DrawText(LPCTSTR FontResName, float DstX, float DstY, LPCTSTR Text)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_BSTR;
		InvokeHelper(0x71, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FontResName, DstX, DstY, Text);
		return result;
	}
	long DrawTextBox(LPCTSTR FontResName, float Left, float Top, float Right, float Bottom, long HorizontalAlignment, long VerticalAlignment, LPCTSTR Text)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_I4 VTS_I4 VTS_BSTR;
		InvokeHelper(0x72, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FontResName, Left, Top, Right, Bottom, HorizontalAlignment, VerticalAlignment, Text);
		return result;
	}
	long DrawTextBox_2(LPCTSTR FontResName, float Left, float Top, float Right, float Bottom, long HorizontalAlignment, long VerticalAlignment, LPCTSTR Text, BOOL UseFontBbox)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_I4 VTS_I4 VTS_BSTR VTS_BOOL;
		InvokeHelper(0x73, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FontResName, Left, Top, Right, Bottom, HorizontalAlignment, VerticalAlignment, Text, UseFontBbox);
		return result;
	}
	long DrawTextUnderline(LPCTSTR FontResName, float DstX, float DstY, LPCTSTR Text, unsigned char Red, unsigned char Green, unsigned char Blue, float LineWidth)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_BSTR VTS_UI1 VTS_UI1 VTS_UI1 VTS_R4;
		InvokeHelper(0x74, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FontResName, DstX, DstY, Text, Red, Green, Blue, LineWidth);
		return result;
	}
	long DrawWrappedText(LPCTSTR FontResName, float Left, float Top, float Right, float Bottom, long HorizontalAlignment, LPCTSTR Text, BOOL UseFontBbox, long * StartPos)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_I4 VTS_BSTR VTS_BOOL VTS_PI4;
		InvokeHelper(0x75, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FontResName, Left, Top, Right, Bottom, HorizontalAlignment, Text, UseFontBbox, StartPos);
		return result;
	}
	long DrawXObjectForm(LPCTSTR ResourceName, float DstX, float DstY, float ScaleX, float ScaleY)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x76, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ResourceName, DstX, DstY, ScaleX, ScaleY);
		return result;
	}
	long DuplicatePage(long count)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x77, DISPATCH_METHOD, VT_I4, (void*)&result, parms, count);
		return result;
	}
	long EmbedFile(LPCTSTR FilePath, LPCTSTR Description)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR;
		InvokeHelper(0x78, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, Description);
		return result;
	}
	long EmbedFile_2(LPUNKNOWN Stream, LPCTSTR FileTitle, LPCTSTR Description)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN VTS_BSTR VTS_BSTR;
		InvokeHelper(0x266, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Stream, FileTitle, Description);
		return result;
	}
	void EnableCompression(BOOL Compress)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x79, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Compress);
	}
	long EndMarkedContent()
	{
		long result;
		InvokeHelper(0x7a, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long EndOCGMarkedContent()
	{
		long result;
		InvokeHelper(0x7b, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long EndPath()
	{
		long result;
		InvokeHelper(0x7c, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long EndXObjectForm()
	{
		long result;
		InvokeHelper(0x7d, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ExtractEmbeddedFile(long FileIdx, SAFEARRAY * * Data)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UNKNOWN;
		InvokeHelper(0x7e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FileIdx, Data);
		return result;
	}
	long ExtractPageImage(long ImageNo)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x7f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageNo);
		return result;
	}
	long FillAndStrokePath()
	{
		long result;
		InvokeHelper(0x80, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long FillAndStrokePathOdd()
	{
		long result;
		InvokeHelper(0x81, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long FillPath()
	{
		long result;
		InvokeHelper(0x82, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long FillPathOdd()
	{
		long result;
		InvokeHelper(0x83, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long FlattenFormFields()
	{
		long result;
		InvokeHelper(0x84, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long FlattenFormFields_2(long pageNo)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x267, DISPATCH_METHOD, VT_I4, (void*)&result, parms, pageNo);
		return result;
	}
	long FlipPage(BOOL FlipX, BOOL FlipY)
	{
		long result;
		static BYTE parms[] = VTS_BOOL VTS_BOOL;
		InvokeHelper(0x85, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FlipX, FlipY);
		return result;
	}
	BOOL FormFieldHasBackgroundColor(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x86, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL FormFieldHasBackgroundColor_2(long FieldId, long ChildIdx)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x87, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	BOOL FormFieldHasBorderColor(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x88, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL FormFieldHasBorderColor_2(long FieldId, long ChildIdx)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x89, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	CString GetActionJavaScript(long ActionID)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x8a, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, ActionID);
		return result;
	}
	long GetActionLaunchDestination(long ActionID, BSTR * FileName, BSTR * DefaultDirectory, BSTR * Parameters, long * Operation, BOOL * NewWindow)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PBSTR VTS_PBSTR VTS_PBSTR VTS_PI4 VTS_PBOOL;
		InvokeHelper(0x8b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ActionID, FileName, DefaultDirectory, Parameters, Operation, NewWindow);
		return result;
	}
	long GetActionPageDestination(long ActionID, long * DestinationType, long * Page, float * Left, float * Bottom, float * Right, float * Top, float * Zoom)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PI4 VTS_PI4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4;
		InvokeHelper(0x8c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ActionID, DestinationType, Page, Left, Bottom, Right, Top, Zoom);
		return result;
	}
	long GetActionRemotePageDestination(long ActionID, long * DestinationType, BSTR * FilePath, BOOL * NewWindow, long * Page, float * Left, float * Bottom, float * Right, float * Top, float * Zoom)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PI4 VTS_PBSTR VTS_PBOOL VTS_PI4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4;
		InvokeHelper(0x8d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ActionID, DestinationType, FilePath, NewWindow, Page, Left, Bottom, Right, Top, Zoom);
		return result;
	}
	long GetActionType(long ActionID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x8e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ActionID);
		return result;
	}
	CString GetActionURI(long ActionID)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x8f, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, ActionID);
		return result;
	}
	long GetAnnotationActionID(long AnnotationIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x90, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	CString GetAnnotationContents(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x91, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	long GetAnnotationCount()
	{
		long result;
		InvokeHelper(0x92, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetAnnotationFlags(long AnnotationIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x93, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	CString GetAnnotationName(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x94, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	unsigned char GetAnnotationOpacity(long AnnotationIdx)
	{
		unsigned char result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x95, DISPATCH_METHOD, VT_UI1, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	long GetAnnotationRect(long AnnotationIdx, float * Left, float * Top, float * Width, float * Height)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4;
		InvokeHelper(0x96, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Left, Top, Width, Height);
		return result;
	}
	CString GetAnnotationSubject(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x97, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	CString GetAnnotationSubType(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x98, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	CString GetAnnotationTitle(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x99, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	CString GetAnnotationType(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x9a, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	CString GetAuthor()
	{
		CString result;
		InvokeHelper(0x9b, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long GetBookmarkActionID(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x9c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	long GetBookmarkChildCount(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x9d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	long GetBookmarkCount()
	{
		long result;
		InvokeHelper(0x9e, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetBookmarkFirstChildID(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x9f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	long GetBookmarkNextID(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xa0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	long GetBookmarkParentID(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xa1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	long GetBookmarkPrevID(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xa2, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	long GetBookmarkRootID()
	{
		long result;
		InvokeHelper(0xa3, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetBookmarkTextAttribute(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xa4, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	CString GetBookmarkTitle(long BookmarkID)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xa5, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, BookmarkID);
		return result;
	}
	CString GetCreationDate()
	{
		CString result;
		InvokeHelper(0xa6, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString GetCreator()
	{
		CString result;
		InvokeHelper(0xa7, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long GetCurrentPage()
	{
		long result;
		InvokeHelper(0xa8, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetCustomPDFInformation(LPCTSTR Key)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0xa9, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, Key);
		return result;
	}
	CString GetCustomPDFInformationKeys(LPCTSTR Separator)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0xaa, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, Separator);
		return result;
	}
	long GetEmbeddedFileCount()
	{
		long result;
		InvokeHelper(0xab, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetEmbeddedFileCreationDate(long FileIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xac, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FileIdx);
		return result;
	}
	CString GetEmbeddedFileDescription(long FileIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xad, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FileIdx);
		return result;
	}
	CString GetEmbeddedFileModificationDate(long FileIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xae, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FileIdx);
		return result;
	}
	CString GetEmbeddedFileName(long FileIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xaf, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FileIdx);
		return result;
	}
	long GetEmbeddedFileSize(long FileIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xb0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FileIdx);
		return result;
	}
	CString GetEmbeddedFileTitle(long FileIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xb1, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FileIdx);
		return result;
	}
	long GetEncryptionMode()
	{
		long result;
		InvokeHelper(0xb2, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetEncryptionScheme()
	{
		long result;
		InvokeHelper(0xb3, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetFileAttachmentAnnotCreationDate(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xb4, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	CString GetFileAttachmentAnnotFileDescription(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xb5, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	CString GetFileAttachmentAnnotFileName(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xb6, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	long GetFileAttachmentAnnotFileSize(long AnnotationIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xb7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	CString GetFileAttachmentAnnotModificationDate(long AnnotationIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xb8, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	long GetFontCount()
	{
		long result;
		InvokeHelper(0xb9, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetFontEncoding(long FontIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xba, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FontIdx);
		return result;
	}
	CString GetFontName(long FontIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xbb, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FontIdx);
		return result;
	}
	CString GetFontType(long FontIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xbc, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FontIdx);
		return result;
	}
	long GetFormFieldActionID(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xbd, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldAlternateTitle(long FieldId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xbe, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId);
		return result;
	}
	long GetFormFieldBorderStyle(long FieldId, float * BorderWidth, long * BorderStyle, float * DashOn, float * DashOff)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PR4 VTS_PI4 VTS_PR4 VTS_PR4;
		InvokeHelper(0xbf, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, BorderWidth, BorderStyle, DashOn, DashOff);
		return result;
	}
	long GetFormFieldBorderStyle_2(long FieldId, long ChildIdx, float * BorderWidth, long * BorderStyle, float * DashOn, float * DashOff)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_PR4 VTS_PI4 VTS_PR4 VTS_PR4;
		InvokeHelper(0xc0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, BorderWidth, BorderStyle, DashOn, DashOff);
		return result;
	}
	long GetFormFieldCheckBoxStyle(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xc1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	long GetFormFieldCheckBoxStyle_2(long FieldId, long ChildIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0xc2, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	BOOL GetFormFieldChecked(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xc3, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldChecked_2(long FieldId, long ChildIdx)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0xc4, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	long GetFormFieldChildCount(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xc5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	long GetFormFieldChildID(long FieldId, long FieldIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0xc6, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, FieldIdx);
		return result;
	}
	long GetFormFieldCloneNumber(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xc7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldComb(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xc8, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldDefaultChecked(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xc9, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldDefaultChecked_2(long FieldId, long ChildIdx)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0xca, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	CString GetFormFieldDefaultValue(long FieldId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xcb, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldDoNotScroll(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xcc, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldDoNotSpellCheck(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xcd, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldFileSelect(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xce, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldFontName(long FieldId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xcf, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId);
		return result;
	}
	long GetFormFieldFontProperties(long FieldId, BSTR * FontFamily, long * FontStyle, BOOL * IsStdFont)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PBSTR VTS_PI4 VTS_PBOOL;
		InvokeHelper(0xd0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, FontFamily, FontStyle, IsStdFont);
		return result;
	}
	float GetFormFieldFontSize(long FieldId)
	{
		float result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xd1, DISPATCH_METHOD, VT_R4, (void*)&result, parms, FieldId);
		return result;
	}
	float GetFormFieldFontSize_2(long FieldId, long ChildIdx)
	{
		float result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0xd2, DISPATCH_METHOD, VT_R4, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	CString GetFormFieldFullTitle(long FieldId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xd3, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldFullTitleWithCloneNumber(long FieldId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xd4, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId);
		return result;
	}
	long GetFormFieldId(long FieldIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xd5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldIdx);
		return result;
	}
	BOOL GetFormFieldItemCommit(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xd6, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	long GetFormFieldItemCount(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xd7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldItemEdit(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xd8, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldItemSort(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xd9, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldItemText(long FieldId, long ItemIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0xda, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId, ItemIdx);
		return result;
	}
	CString GetFormFieldItemValue(long FieldId, long ItemIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0xdb, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId, ItemIdx);
		return result;
	}
	long GetFormFieldLocation(long FieldId, float * Left, float * Top, float * Right, float * Bottom)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4;
		InvokeHelper(0xdc, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Left, Top, Right, Bottom);
		return result;
	}
	long GetFormFieldMaxLen(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xdd, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldMultiLine(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xde, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldMultiSelect(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xdf, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldNormalCaption(long FieldId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xe0, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldOnStateName(long FieldId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xe1, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldOnStateName_2(long FieldId, long ChildIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0xe2, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	long GetFormFieldPage(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xe3, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldPassword(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xe4, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldRadioInUnison(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xe5, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldReadOnly(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xe6, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldRequired(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xe7, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	BOOL GetFormFieldRichText(long FieldId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xe8, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FieldId);
		return result;
	}
	long GetFormFieldRotation(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xe9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	long GetFormFieldsCount()
	{
		long result;
		InvokeHelper(0xea, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL GetFormFieldsNeedAppearances()
	{
		BOOL result;
		InvokeHelper(0xeb, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	long GetFormFieldTextAlignment(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xec, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldTitle(long FieldId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xed, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId);
		return result;
	}
	long GetFormFieldType(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xee, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldValue(long FieldId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xef, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetFormFieldValue_2(long FieldId, LPCTSTR Separator)
	{
		CString result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0xf0, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldId, Separator);
		return result;
	}
	long GetFormFieldVisibility(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xf1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	CString GetInputFilePath()
	{
		CString result;
		InvokeHelper(0xf2, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString GetKeywords()
	{
		CString result;
		InvokeHelper(0xf3, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long GetMeasurementUnit()
	{
		long result;
		InvokeHelper(0xf8, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetMetadata()
	{
		CString result;
		InvokeHelper(0xf9, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString GetModificationDate()
	{
		CString result;
		InvokeHelper(0xfa, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	VARIANT GetObjectInterop()
	{
		VARIANT result;
		InvokeHelper(0xfc, DISPATCH_METHOD, VT_VARIANT, (void*)&result, nullptr);
		return result;
	}
	long GetOCG(long OCGIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xfd, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGIdx);
		return result;
	}
	long GetOCGCount()
	{
		long result;
		InvokeHelper(0xfe, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetOCGExportState(long OCGId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0xff, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId);
		return result;
	}
	BOOL GetOCGIntentView(long OCGId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x100, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, OCGId);
		return result;
	}
	BOOL GetOCGLockedState(long OCGId)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x101, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, OCGId);
		return result;
	}
	long GetOCGPrintState(long OCGId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x102, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId);
		return result;
	}
	CString GetOCGTitle(long OCGId)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x103, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, OCGId);
		return result;
	}
	long GetOCGViewState(long OCGId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x104, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId);
		return result;
	}
	double GetOCGZoomMax(long OCGId)
	{
		double result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x105, DISPATCH_METHOD, VT_R8, (void*)&result, parms, OCGId);
		return result;
	}
	double GetOCGZoomMin(long OCGId)
	{
		double result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x106, DISPATCH_METHOD, VT_R8, (void*)&result, parms, OCGId);
		return result;
	}
	long GetOrigin()
	{
		long result;
		InvokeHelper(0x107, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetPageBox(long PageBox, float * Left, float * Top, float * Right, float * Bottom)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4;
		InvokeHelper(0x108, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageBox, Left, Top, Right, Bottom);
		return result;
	}
	CString GetPageContent()
	{
		CString result;
		InvokeHelper(0x109, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long GetPageCount()
	{
		long result;
		InvokeHelper(0x10a, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	float GetPageHeight()
	{
		float result;
		InvokeHelper(0x10b, DISPATCH_METHOD, VT_R4, (void*)&result, nullptr);
		return result;
	}
	long GetPageImageBitDepth(long ImageIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x10c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageIdx);
		return result;
	}
	long GetPageImageColorSpace(long ImageIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x10d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageIdx);
		return result;
	}
	long GetPageImageCoordinates(long ImageIdx, float * x0, float * y0, float * X1, float * Y1, float * X2, float * Y2)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4;
		InvokeHelper(0x10e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageIdx, x0, y0, X1, Y1, X2, Y2);
		return result;
	}
	long GetPageImageCount()
	{
		long result;
		InvokeHelper(0x10f, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	SAFEARRAY * GetPageImageFilters(long ImageIdx)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x110, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, ImageIdx);
	}
	long GetPageImageMaskMode(long ImageIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x111, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageIdx);
		return result;
	}
	CString GetPageImageResName(long ImageIdx)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x112, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, ImageIdx);
		return result;
	}
	long GetPageImageResolution(long ImageIdx, float * HorizontalResolution, float * VerticalResolution)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PR4 VTS_PR4;
		InvokeHelper(0x113, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageIdx, HorizontalResolution, VerticalResolution);
		return result;
	}
	long GetPageImageSize(long ImageIdx, long * Width, long * Height)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PI4 VTS_PI4;
		InvokeHelper(0x114, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageIdx, Width, Height);
		return result;
	}
	CString GetPageLabel(long pageNo)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x115, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, pageNo);
		return result;
	}
	long GetPageLabelsRange(long LabelingRangeIdx, long * StartPage, long * Style, BSTR * Prefix, long * NumPortion)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PI4 VTS_PI4 VTS_PBSTR VTS_PI4;
		InvokeHelper(0x116, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LabelingRangeIdx, StartPage, Style, Prefix, NumPortion);
		return result;
	}
	long GetPageLabelsRangeCount()
	{
		long result;
		InvokeHelper(0x117, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetPageLinkAnnotationIdx(long LinkIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x118, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LinkIdx);
		return result;
	}
	long GetPageLinksCount()
	{
		long result;
		InvokeHelper(0x119, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetPageMetadata()
	{
		CString result;
		InvokeHelper(0x11a, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString GetPagePrivateTag(LPCTSTR Tag)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x11b, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, Tag);
		return result;
	}
	long GetPageRotation()
	{
		long result;
		InvokeHelper(0x11c, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetPageText()
	{
		CString result;
		InvokeHelper(0x11d, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString GetPageTextArea(float Left, float Top, float Width, float Height)
	{
		CString result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x11e, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, Left, Top, Width, Height);
		return result;
	}
	CString GetPageTextWithCoords(LPCTSTR FieldSeparator)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x11f, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldSeparator);
		return result;
	}
	CString GetPageTextWithCoordsEx(LPCTSTR FieldSeparator)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x120, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldSeparator);
		return result;
	}
	long GetPageThumbnail(long Width, long Height, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x121, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Width, Height, Red, Green, Blue);
		return result;
	}
	float GetPageUserUnit()
	{
		float result;
		InvokeHelper(0x123, DISPATCH_METHOD, VT_R4, (void*)&result, nullptr);
		return result;
	}
	float GetPageWidth()
	{
		float result;
		InvokeHelper(0x124, DISPATCH_METHOD, VT_R4, (void*)&result, nullptr);
		return result;
	}
	long GetPDFAConformance()
	{
		long result;
		InvokeHelper(0x125, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetProducer()
	{
		CString result;
		InvokeHelper(0x126, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	BOOL GetRight(long Right)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x127, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Right);
		return result;
	}
	long GetSignatureCount()
	{
		long result;
		InvokeHelper(0x128, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetSignatureProperties(long SignatureIdx, BSTR * SignatureName, BSTR * SignatureReason, BSTR * SignatureLocation, BSTR * SignatureContactInfo, BSTR * SignatureDate, float * StampLeft, float * StampTop, float * StampWidth, float * StampHeight, long * StampPage, BOOL * DocumentValid, BOOL * CertificateValid, BSTR * CertificateFriendlyName, BSTR * CertificateIssuer, DATE * CertificateNotBefore, DATE * CertificateNotAfter, BSTR * CertificateSubject, long * CertificateVersion, DATE * SigningTime, long * SignatureLevel)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_PBSTR VTS_PBSTR VTS_PBSTR VTS_PBSTR VTS_PBSTR VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4 VTS_PI4 VTS_PBOOL VTS_PBOOL VTS_PBSTR VTS_PBSTR VTS_PDATE VTS_PDATE VTS_PBSTR VTS_PI4 VTS_PDATE VTS_PI4;
		InvokeHelper(0x129, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SignatureIdx, SignatureName, SignatureReason, SignatureLocation, SignatureContactInfo, SignatureDate, StampLeft, StampTop, StampWidth, StampHeight, StampPage, DocumentValid, CertificateValid, CertificateFriendlyName, CertificateIssuer, CertificateNotBefore, CertificateNotAfter, CertificateSubject, CertificateVersion, SigningTime, SignatureLevel);
		return result;
	}
	long GetStat()
	{
		long result;
		InvokeHelper(0x12a, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString GetSubject()
	{
		CString result;
		InvokeHelper(0x12b, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long GetTagRootID()
	{
		long result;
		InvokeHelper(0x12c, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	float GetTextHeight(LPCTSTR FontResName, float TextSize)
	{
		float result;
		static BYTE parms[] = VTS_BSTR VTS_R4;
		InvokeHelper(0x12d, DISPATCH_METHOD, VT_R4, (void*)&result, parms, FontResName, TextSize);
		return result;
	}
	float GetTextHeight_2(LPCTSTR FontResName, float TextSize, BOOL UseFontBox)
	{
		float result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_BOOL;
		InvokeHelper(0x12e, DISPATCH_METHOD, VT_R4, (void*)&result, parms, FontResName, TextSize, UseFontBox);
		return result;
	}
	float GetTextWidth(LPCTSTR FontResName, float TextSize, LPCTSTR Text)
	{
		float result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_BSTR;
		InvokeHelper(0x12f, DISPATCH_METHOD, VT_R4, (void*)&result, parms, FontResName, TextSize, Text);
		return result;
	}
	CString GetTitle()
	{
		CString result;
		InvokeHelper(0x130, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	CString GetVersion()
	{
		CString result;
		InvokeHelper(0x131, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long GetViewerLayoutMode()
	{
		long result;
		InvokeHelper(0x132, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetViewerNonFullScreenPageMode()
	{
		long result;
		InvokeHelper(0x133, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetViewerOpenActionID()
	{
		long result;
		InvokeHelper(0x134, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long GetViewerPageMode()
	{
		long result;
		InvokeHelper(0x135, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL GetViewerPreference(long Preference)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x136, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Preference);
		return result;
	}
	float GetWrappedTextHeight(LPCTSTR FontResName, float Left, float Top, float Right, float Bottom, long HorizontalAlignment, LPCTSTR Text, BOOL UseFontBbox, long * StartPos)
	{
		float result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_I4 VTS_BSTR VTS_BOOL VTS_PI4;
		InvokeHelper(0x137, DISPATCH_METHOD, VT_R4, (void*)&result, parms, FontResName, Left, Top, Right, Bottom, HorizontalAlignment, Text, UseFontBbox, StartPos);
		return result;
	}
	long GetWrappedTextLineCount(LPCTSTR FontResName, float Width, long HorizontalAlignment, LPCTSTR Text, BOOL UseFontBbox)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_R4 VTS_I4 VTS_BSTR VTS_BOOL;
		InvokeHelper(0x138, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FontResName, Width, HorizontalAlignment, Text, UseFontBbox);
		return result;
	}
	long GuessPageTextRotation()
	{
		long result;
		InvokeHelper(0x139, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL HasXFAFormFields()
	{
		BOOL result;
		InvokeHelper(0x13a, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	long IncreaseVersion(float Version)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x13b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Version);
		return result;
	}
	long InsertPage(float PageWidth, float PageHeight, long pageNo)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_I4;
		InvokeHelper(0x140, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageWidth, PageHeight, pageNo);
		return result;
	}
	long InsertPage_2(long PageSize, long pageNo)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x141, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageSize, pageNo);
		return result;
	}
	BOOL IsEncrypted()
	{
		BOOL result;
		InvokeHelper(0x142, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL IsFontEmbedded(long FontIdx)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x143, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, FontIdx);
		return result;
	}
	BOOL IsLinearized()
	{
		BOOL result;
		InvokeHelper(0x144, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL IsOwnerPassword()
	{
		BOOL result;
		InvokeHelper(0x145, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL IsPageImage()
	{
		BOOL result;
		InvokeHelper(0x146, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL IsPageImage_2(long * ImageID, BOOL AutoRotate)
	{
		BOOL result;
		static BYTE parms[] = VTS_PI4 VTS_BOOL;
		InvokeHelper(0x147, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, ImageID, AutoRotate);
		return result;
	}
	BOOL IsPageImage_3(BOOL IgnoreHiddenText)
	{
		BOOL result;
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x148, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, IgnoreHiddenText);
		return result;
	}
	long IsPortFolio(BOOL * Portfolio, long * FirstFileIdx, long * ViewMode)
	{
		long result;
		static BYTE parms[] = VTS_PBOOL VTS_PI4 VTS_PI4;
		InvokeHelper(0x149, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Portfolio, FirstFileIdx, ViewMode);
		return result;
	}
	long LoadFromFile(LPCTSTR FilePath, BOOL LoadInMemory)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL;
		InvokeHelper(0x14a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, LoadInMemory);
		return result;
	}
	long LoadFromFileEx(LPCTSTR FilePath, BOOL OpenReadWrite)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL;
		InvokeHelper(0x14b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, OpenReadWrite);
		return result;
	}
	long LoadFromIStream(LPUNKNOWN Stream)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN;
		InvokeHelper(0x14c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Stream);
		return result;
	}
	long MapStructureType(LPCTSTR NewStructType, LPCTSTR ExistingStructType)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR;
		InvokeHelper(0x14d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, NewStructType, ExistingStructType);
		return result;
	}
	long Merge2Documents(LPCTSTR SrcDoc1, LPCTSTR SrcDoc2, LPCTSTR DstDoc)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR;
		InvokeHelper(0x14e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SrcDoc1, SrcDoc2, DstDoc);
		return result;
	}
	LPDISPATCH Merge2Documents_2(LPDISPATCH SrcDoc1, LPDISPATCH SrcDoc2)
	{
		LPDISPATCH result;
		static BYTE parms[] = VTS_DISPATCH VTS_DISPATCH;
		InvokeHelper(0x14f, DISPATCH_METHOD, VT_DISPATCH, (void*)&result, parms, SrcDoc1, SrcDoc2);
		return result;
	}
	long MergeDocuments(SAFEARRAY * * SrcDocPath, LPCTSTR DstDoc)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN VTS_BSTR;
		InvokeHelper(0x150, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SrcDocPath, DstDoc);
		return result;
	}
	LPDISPATCH MergeDocuments_2(SAFEARRAY * * SrcDoc)
	{
		LPDISPATCH result;
		static BYTE parms[] = VTS_UNKNOWN;
		InvokeHelper(0x151, DISPATCH_METHOD, VT_DISPATCH, (void*)&result, parms, SrcDoc);
		return result;
	}
	LPDISPATCH MergeDocuments_3(SAFEARRAY * * SrcDoc, long Options)
	{
		LPDISPATCH result;
		static BYTE parms[] = VTS_UNKNOWN VTS_I4;
		InvokeHelper(0x152, DISPATCH_METHOD, VT_DISPATCH, (void*)&result, parms, SrcDoc, Options);
		return result;
	}
	long MoveBookmark(long BookmarkID, long BookmarkDestID, BOOL Before)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_BOOL;
		InvokeHelper(0x153, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID, BookmarkDestID, Before);
		return result;
	}
	long MoveBookmarkDown(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x154, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	long MoveBookmarkUp(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x155, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	long MovePage(long pageNo, long Destination)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x156, DISPATCH_METHOD, VT_I4, (void*)&result, parms, pageNo, Destination);
		return result;
	}
	long NewActionGoTo(long DestinationType, long Page, float Left, float Right, float Bottom, float Top, float Zoom)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x157, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DestinationType, Page, Left, Right, Bottom, Top, Zoom);
		return result;
	}
	long NewActionGoToR(long DestinationType, LPCTSTR FilePath, BOOL NewWindow, long Page, float Left, float Right, float Bottom, float Top, float Zoom)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_BOOL VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x158, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DestinationType, FilePath, NewWindow, Page, Left, Right, Bottom, Top, Zoom);
		return result;
	}
	long NewActionJavaScript(LPCTSTR JavaScript)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x159, DISPATCH_METHOD, VT_I4, (void*)&result, parms, JavaScript);
		return result;
	}
	long NewActionLaunch(LPCTSTR FileName, LPCTSTR DefaultDirectory, LPCTSTR Parameters, long Operation, BOOL NewWindow)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR VTS_I4 VTS_BOOL;
		InvokeHelper(0x15a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FileName, DefaultDirectory, Parameters, Operation, NewWindow);
		return result;
	}
	long NewActionNamed(long Name)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x15b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Name);
		return result;
	}
	long NewActionURI(LPCTSTR Uri, BOOL IsMap)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL;
		InvokeHelper(0x15c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Uri, IsMap);
		return result;
	}
	long NewBookmark(long ParentBookmarkID, LPCTSTR Title)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x15d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ParentBookmarkID, Title);
		return result;
	}
	long NewOCG(LPCTSTR Title)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x15e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Title);
		return result;
	}
	long NewPage(float PageWidth, float PageHeight)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4;
		InvokeHelper(0x15f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageWidth, PageHeight);
		return result;
	}
	long NewPage_2(long PageSize)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x160, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageSize);
		return result;
	}
	long NewPDF()
	{
		long result;
		InvokeHelper(0x161, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long NewPDF_3(long Conformance)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x162, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Conformance);
		return result;
	}
	long NewTag(long ParentTagID, LPCTSTR StructType)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x163, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ParentTagID, StructType);
		return result;
	}
	long NormalizePage()
	{
		long result;
		InvokeHelper(0x164, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long OcrPage(LPCTSTR Dictionary, LPCTSTR DictionaryPath, LPCTSTR CharWhiteList, float DPI)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR VTS_R4;
		InvokeHelper(0x165, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Dictionary, DictionaryPath, CharWhiteList, DPI);
		return result;
	}
	long OcrPages(LPCTSTR PageRange, long ThreadCount, LPCTSTR Dictionary, LPCTSTR DictionaryPath, LPCTSTR CharWhiteList, float DPI)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BSTR VTS_BSTR VTS_BSTR VTS_R4;
		InvokeHelper(0x166, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageRange, ThreadCount, Dictionary, DictionaryPath, CharWhiteList, DPI);
		return result;
	}
	long OcrPages_4(LPCTSTR PageRange, long ThreadCount, LPCTSTR Dictionary, LPCTSTR DictionaryPath, LPCTSTR CharWhiteList, float DPI, long OCRMode, long TimeoutMillisec, BOOL Sync)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BSTR VTS_BSTR VTS_BSTR VTS_R4 VTS_I4 VTS_I4 VTS_BOOL;
		InvokeHelper(0x169, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageRange, ThreadCount, Dictionary, DictionaryPath, CharWhiteList, DPI, OCRMode, TimeoutMillisec, Sync);
		return result;
	}
	long PackFonts()
	{
		long result;
		InvokeHelper(0x16b, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL PageHasShape()
	{
		BOOL result;
		InvokeHelper(0x16c, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL PageHasText()
	{
		BOOL result;
		InvokeHelper(0x16d, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL PageHasText_2(BOOL IgnoreHiddenText)
	{
		BOOL result;
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x16e, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, IgnoreHiddenText);
		return result;
	}
	long PortFolioCreate(LPCTSTR FirstFileNameToShow, long ViewMode)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4;
		InvokeHelper(0x16f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FirstFileNameToShow, ViewMode);
		return result;
	}
	long PortFolioCreate_2(long FirstFileToShowIdx, long ViewMode)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x170, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FirstFileToShowIdx, ViewMode);
		return result;
	}
	long PortFolioDelete()
	{
		long result;
		InvokeHelper(0x171, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long Print()
	{
		long result;
		InvokeHelper(0x172, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL PrintDialog()
	{
		BOOL result;
		InvokeHelper(0x173, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	BOOL PrintDialogFit()
	{
		BOOL result;
		InvokeHelper(0x174, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	long PrintFit()
	{
		long result;
		InvokeHelper(0x175, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString PrintGetActivePrinter()
	{
		CString result;
		InvokeHelper(0x176, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long PrintGetAlignment()
	{
		long result;
		InvokeHelper(0x177, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL PrintGetCollate()
	{
		BOOL result;
		InvokeHelper(0x178, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	long PrintGetColorMode()
	{
		long result;
		InvokeHelper(0x179, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	short PrintGetCopies()
	{
		short result;
		InvokeHelper(0x17a, DISPATCH_METHOD, VT_I2, (void*)&result, nullptr);
		return result;
	}
	CString PrintGetDocumentName()
	{
		CString result;
		InvokeHelper(0x17b, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	long PrintGetDuplexMode()
	{
		long result;
		InvokeHelper(0x17c, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	CString PrintGetLastError()
	{
		CString result;
		InvokeHelper(0x17d, DISPATCH_METHOD, VT_BSTR, (void*)&result, nullptr);
		return result;
	}
	void PrintGetMargins(float * LeftMargin, float * TopMargin)
	{
		static BYTE parms[] = VTS_PR4 VTS_PR4;
		InvokeHelper(0x17e, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, LeftMargin, TopMargin);
	}
	long PrintGetOrientation()
	{
		long result;
		InvokeHelper(0x17f, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long PrintGetPaperBin()
	{
		long result;
		InvokeHelper(0x180, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	float PrintGetPaperHeight()
	{
		float result;
		InvokeHelper(0x181, DISPATCH_METHOD, VT_R4, (void*)&result, nullptr);
		return result;
	}
	long PrintGetPaperSize()
	{
		long result;
		InvokeHelper(0x182, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	float PrintGetPaperWidth()
	{
		float result;
		InvokeHelper(0x183, DISPATCH_METHOD, VT_R4, (void*)&result, nullptr);
		return result;
	}
	CString PrintGetPrinterName(long PrinterNo)
	{
		CString result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x184, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, PrinterNo);
		return result;
	}
	long PrintGetPrintersCount()
	{
		long result;
		InvokeHelper(0x185, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	LPUNKNOWN PrintGetPrinterSettings()
	{
		LPUNKNOWN result;
		InvokeHelper(0x186, DISPATCH_METHOD, VT_UNKNOWN, (void*)&result, nullptr);
		return result;
	}
	long PrintGetQuality()
	{
		long result;
		InvokeHelper(0x187, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long PrintGetStat()
	{
		long result;
		InvokeHelper(0x188, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void PrintInterop()
	{
		InvokeHelper(0x189, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	BOOL PrintSetActivePrinter(LPCTSTR PrinterName)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x18a, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, PrinterName);
		return result;
	}
	long PrintSetAlignment(long ImageAlignment)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x18b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageAlignment);
		return result;
	}
	long PrintSetAutoRotation(BOOL AutoRotation)
	{
		long result;
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x18c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AutoRotation);
		return result;
	}
	long PrintSetCollate(BOOL Collate)
	{
		long result;
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x18d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Collate);
		return result;
	}
	long PrintSetColorMode(long ColorMode)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x18e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ColorMode);
		return result;
	}
	long PrintSetCopies(short Copies)
	{
		long result;
		static BYTE parms[] = VTS_I2;
		InvokeHelper(0x18f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Copies);
		return result;
	}
	long PrintSetDocumentName(LPCTSTR DocumentName)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x190, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DocumentName);
		return result;
	}
	long PrintSetDuplexMode(long DuplexMode)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x191, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DuplexMode);
		return result;
	}
	long PrintSetFromToPage(long FromPage, long ToPage)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x192, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FromPage, ToPage);
		return result;
	}
	long PrintSetOrientation(long Orientation)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x193, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Orientation);
		return result;
	}
	long PrintSetPageSelection(LPCTSTR CustomRange)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x194, DISPATCH_METHOD, VT_I4, (void*)&result, parms, CustomRange);
		return result;
	}
	BOOL PrintSetPaperBin(long PaperBin)
	{
		BOOL result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x195, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, PaperBin);
		return result;
	}
	BOOL PrintSetPaperBin_2(LPUNKNOWN PaperBin)
	{
		BOOL result;
		static BYTE parms[] = VTS_UNKNOWN;
		InvokeHelper(0x196, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, PaperBin);
		return result;
	}
	long PrintSetPreRasterization(BOOL PreRasterization)
	{
		long result;
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x197, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PreRasterization);
		return result;
	}
	long PrintSetPreRasterizationDPI(float DPI)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x265, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DPI);
		return result;
	}
	long PrintSetPrinterSettings(LPUNKNOWN PS)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN;
		InvokeHelper(0x198, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PS);
		return result;
	}
	long PrintSetQuality(long Quality)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x199, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Quality);
		return result;
	}
	long PrintSetShowPrintingProgress(BOOL Show)
	{
		long result;
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x19a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Show);
		return result;
	}
	long PrintSetStdPaperSize(long PaperSize)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x19b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PaperSize);
		return result;
	}
	long PrintSetUserPaperSize(float PaperWidth, float PaperHeight)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4;
		InvokeHelper(0x19c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PaperWidth, PaperHeight);
		return result;
	}
	long PrintShowPrinterSettingsDialog(long HANDLE)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x19d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, HANDLE);
		return result;
	}
	long RemoveAnnotation(long AnnotationIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x19e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	long RemoveBookmark(long BookmarkID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x19f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID);
		return result;
	}
	long RemoveBookmarks()
	{
		long result;
		InvokeHelper(0x1a0, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long RemoveFormField(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1a1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	long RemoveFormFields()
	{
		long result;
		InvokeHelper(0x1a2, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long RemoveJavaScript(long Options)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1a3, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Options);
		return result;
	}
	long RemovePageLink(long LinkIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1a4, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LinkIdx);
		return result;
	}
	long RemovePageLinks()
	{
		long result;
		InvokeHelper(0x1a5, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long RemoveSignature(long SignatureIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1a6, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SignatureIdx);
		return result;
	}
	long RemoveUnusedResources()
	{
		long result;
		InvokeHelper(0x1a7, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long RenderPageToGdPictureImage(float DPI, BOOL RenderFormFields)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_BOOL;
		InvokeHelper(0x1a8, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DPI, RenderFormFields);
		return result;
	}
	long RenderPageToGdPictureImageEx(float DPI, BOOL RenderFormFields)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_BOOL;
		InvokeHelper(0x1a9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DPI, RenderFormFields);
		return result;
	}
	long RenderPageToGdPictureImageEx_2(float DPI, BOOL RenderFormFields, long PixelFormat)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_BOOL VTS_I4;
		InvokeHelper(0x1aa, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DPI, RenderFormFields, PixelFormat);
		return result;
	}
	long RenderPageToGdPictureImage_2(float DPI, BOOL RenderFormFields, long PixelFormat)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_BOOL VTS_I4;
		InvokeHelper(0x1ab, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DPI, RenderFormFields, PixelFormat);
		return result;
	}
	long RenderPageToGdPictureImage_3(float DPI, BOOL RenderFormFields, BOOL KeepTransparency)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x1ac, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DPI, RenderFormFields, KeepTransparency);
		return result;
	}
	long ReplaceImage(LPCTSTR ImageResName, long ImageID, BOOL ImageMask)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL;
		InvokeHelper(0x1ad, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageResName, ImageID, ImageMask);
		return result;
	}
	long ReplaceImageMRC(LPCTSTR ImageResName, long ImageID)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4;
		InvokeHelper(0x1ae, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageResName, ImageID);
		return result;
	}
	long ReplaceImage_2(LPCTSTR ImageResName, long ImageID, BOOL ImageMask, BOOL CheckSize)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL;
		InvokeHelper(0x1af, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageResName, ImageID, ImageMask, CheckSize);
		return result;
	}
	long ResetFormFieldCheckedState(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1b0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	long ResetFormFieldDefaultCheckedState(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1b1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	long ResetGraphicsState()
	{
		long result;
		InvokeHelper(0x1b2, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ResizePage(float NewPageWidth, float NewPageHeight)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4;
		InvokeHelper(0x1b3, DISPATCH_METHOD, VT_I4, (void*)&result, parms, NewPageWidth, NewPageHeight);
		return result;
	}
	long RestoreGraphicsState()
	{
		long result;
		InvokeHelper(0x1b4, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long RotatePage(long Rotation)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1b5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Rotation);
		return result;
	}
	long RotatePageEx(float Angle)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x1b6, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Angle);
		return result;
	}
	long RotatePages(long Rotation)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1b7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Rotation);
		return result;
	}
	long SaveGraphicsState()
	{
		long result;
		InvokeHelper(0x1b8, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SaveToFile(LPCTSTR FilePath)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x1b9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath);
		return result;
	}
	long SaveToFileInc(LPCTSTR FilePath)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x1ba, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath);
		return result;
	}
	long SaveToFile_2(LPCTSTR FilePath, BOOL PackDocument)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL;
		InvokeHelper(0x1bb, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, PackDocument);
		return result;
	}
	long SaveToFile_3(LPCTSTR FilePath, BOOL PackDocument, BOOL Linearize)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BOOL VTS_BOOL;
		InvokeHelper(0x1bc, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, PackDocument, Linearize);
		return result;
	}
	long SaveToFile_4(LPCTSTR FilePath, long EncryptionScheme, LPCTSTR UserPass, LPCTSTR OwnerPass, BOOL CanPrint, BOOL CanCopy, BOOL CanModify, BOOL CanAddNotes, BOOL CanFillFields, BOOL CanCopyAccess, BOOL CanAssemble, BOOL CanPrintFull)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BSTR VTS_BSTR VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL;
		InvokeHelper(0x1bd, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FilePath, EncryptionScheme, UserPass, OwnerPass, CanPrint, CanCopy, CanModify, CanAddNotes, CanFillFields, CanCopyAccess, CanAssemble, CanPrintFull);
		return result;
	}
	long SaveToIStream(LPUNKNOWN Stream, BOOL PackDocument)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN VTS_BOOL;
		InvokeHelper(0x1be, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Stream, PackDocument);
		return result;
	}
	long SaveToIStreamInc(LPUNKNOWN Stream)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN;
		InvokeHelper(0x1bf, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Stream);
		return result;
	}
	long SaveToIStream_2(LPUNKNOWN Stream, long EncryptionScheme, LPCTSTR UserPass, LPCTSTR OwnerPass, BOOL CanPrint, BOOL CanCopy, BOOL CanModify, BOOL CanAddNotes, BOOL CanFillFields, BOOL CanCopyAccess, BOOL CanAssemble, BOOL CanPrintFull)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN VTS_I4 VTS_BSTR VTS_BSTR VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL VTS_BOOL;
		InvokeHelper(0x1c0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Stream, EncryptionScheme, UserPass, OwnerPass, CanPrint, CanCopy, CanModify, CanAddNotes, CanFillFields, CanCopyAccess, CanAssemble, CanPrintFull);
		return result;
	}
	long ScalePage(float ScaleX, float ScaleY)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4;
		InvokeHelper(0x1c1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ScaleX, ScaleY);
		return result;
	}
	BOOL SearchText(LPCTSTR Text, long Occurrence, BOOL CaseSensitive, BOOL WholeWords, float * Left, float * Top, float * Width, float * Height)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4;
		InvokeHelper(0x1c2, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Text, Occurrence, CaseSensitive, WholeWords, Left, Top, Width, Height);
		return result;
	}
	BOOL SearchText_2(LPCTSTR Text, long Occurrence, BOOL CaseSensitive, BOOL WholeWords, BOOL OrdinalComparison, float * Left, float * Top, float * Width, float * Height)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL VTS_BOOL VTS_PR4 VTS_PR4 VTS_PR4 VTS_PR4;
		InvokeHelper(0x1c3, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Text, Occurrence, CaseSensitive, WholeWords, OrdinalComparison, Left, Top, Width, Height);
		return result;
	}
	long SelectPage(long pageNo)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1c4, DISPATCH_METHOD, VT_I4, (void*)&result, parms, pageNo);
		return result;
	}
	long SetAnnotationAction(long AnnotationIdx, long ActionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x1c5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, ActionID);
		return result;
	}
	long SetAnnotationColor(long AnnotationIdx, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1c6, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Red, Green, Blue);
		return result;
	}
	long SetAnnotationColor_2(long AnnotationIdx, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1c7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetAnnotationContents(long AnnotationIdx, LPCTSTR Contents)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x1c8, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Contents);
		return result;
	}
	long SetAnnotationFillColor(long AnnotationIdx, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1c9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Red, Green, Blue);
		return result;
	}
	long SetAnnotationFillColor_2(long AnnotationIdx, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1ca, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetAnnotationFlags(long AnnotationIdx, long Flags)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x1cb, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Flags);
		return result;
	}
	long SetAnnotationName(long AnnotationIdx, LPCTSTR Name)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x1cc, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Name);
		return result;
	}
	long SetAnnotationOpacity(long AnnotationIdx, unsigned char Opacity)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1;
		InvokeHelper(0x1cd, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Opacity);
		return result;
	}
	long SetAnnotationRect(long AnnotationIdx, float Left, float Top, float Width, float Height)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x1ce, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Left, Top, Width, Height);
		return result;
	}
	long SetAnnotationSubject(long AnnotationIdx, LPCTSTR Subject)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x1cf, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Subject);
		return result;
	}
	long SetAnnotationTitle(long AnnotationIdx, LPCTSTR Title)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x1d0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx, Title);
		return result;
	}
	void SetAuthor(LPCTSTR Author)
	{
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x1d1, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Author);
	}
	long SetBlendMode(long BlendMode)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1d2, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BlendMode);
		return result;
	}
	long SetBookmarkAction(long BookmarkID, long ActionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x1d3, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID, ActionID);
		return result;
	}
	long SetBookmarkColor(long BookmarkID, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1d4, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID, Red, Green, Blue);
		return result;
	}
	long SetBookmarkColor_2(long BookmarkID, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1d5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetBookmarkTextAttribute(long BookmarkID, long Attribute)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x1d6, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID, Attribute);
		return result;
	}
	long SetBookmarkTitle(long BookmarkID, LPCTSTR Title)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x1d7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, BookmarkID, Title);
		return result;
	}
	long SetCertificate(LPCTSTR CertPath, LPCTSTR PFXPassword)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR;
		InvokeHelper(0x1d8, DISPATCH_METHOD, VT_I4, (void*)&result, parms, CertPath, PFXPassword);
		return result;
	}
	void SetCompressionForBitonalImage(long Compression)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1d9, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Compression);
	}
	void SetCompressionForColorImage(long Compression)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x1da, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Compression);
	}
	void SetCreator(LPCTSTR Creator)
	{
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x1db, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Creator);
	}
	long SetCustomPDFInformation(LPCTSTR Key, LPCTSTR Value)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR;
		InvokeHelper(0x1dc, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Key, Value);
		return result;
	}
	long SetFillAlpha(unsigned char Alpha)
	{
		long result;
		static BYTE parms[] = VTS_UI1;
		InvokeHelper(0x1dd, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Alpha);
		return result;
	}
	long SetFillColor(unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1de, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Red, Green, Blue);
		return result;
	}
	long SetFillColor_2(unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1df, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetFormFieldAction(long FieldId, long ActionID)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x1e0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ActionID);
		return result;
	}
	long SetFormFieldAlternateTitle(long FieldId, LPCTSTR AlternateTitle)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x1e1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, AlternateTitle);
		return result;
	}
	long SetFormFieldBackgroundColor(long FieldId, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1e2, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Red, Green, Blue);
		return result;
	}
	long SetFormFieldBackgroundColor_2(long FieldId, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1e3, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetFormFieldBackgroundColor_3(long FieldId, long ChildIdx, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1e4, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, Red, Green, Blue);
		return result;
	}
	long SetFormFieldBackgroundColor_4(long FieldId, long ChildIdx, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1e5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetFormFieldBorderColor(long FieldId, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1e6, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Red, Green, Blue);
		return result;
	}
	long SetFormFieldBorderColor_2(long FieldId, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1e7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetFormFieldBorderColor_3(long FieldId, long ChildIdx, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1e8, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, Red, Green, Blue);
		return result;
	}
	long SetFormFieldBorderColor_4(long FieldId, long ChildIdx, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1e9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetFormFieldBorderStyle(long FieldId, float BorderWidth, long BorderStyle, float DashOn, float DashOff)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_I4 VTS_R4 VTS_R4;
		InvokeHelper(0x1ea, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, BorderWidth, BorderStyle, DashOn, DashOff);
		return result;
	}
	long SetFormFieldBorderStyle_2(long FieldId, long ChildIdx, float BorderWidth, long BorderStyle, float DashOn, float DashOff)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_R4 VTS_I4 VTS_R4 VTS_R4;
		InvokeHelper(0x1eb, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, BorderWidth, BorderStyle, DashOn, DashOff);
		return result;
	}
	long SetFormFieldCheckBoxStyle(long FieldId, long CheckStyle)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x1ec, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, CheckStyle);
		return result;
	}
	long SetFormFieldCheckBoxStyle_2(long FieldId, long ChildIdx, long CheckStyle)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_I4;
		InvokeHelper(0x1ed, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, CheckStyle);
		return result;
	}
	long SetFormFieldChecked(long FieldId, BOOL Checked)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x1ee, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Checked);
		return result;
	}
	long SetFormFieldChecked_2(long FieldId, long ChildIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x1ef, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	long SetFormFieldComb(long FieldId, BOOL Comb)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x1f0, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Comb);
		return result;
	}
	long SetFormFieldDefaultChecked(long FieldId, BOOL Checked)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x1f1, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Checked);
		return result;
	}
	long SetFormFieldDefaultChecked_2(long FieldId, long ChildIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x1f2, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	long SetFormFieldDefaultValue(long FieldId, LPCTSTR DefaultValue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x1f3, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, DefaultValue);
		return result;
	}
	long SetFormFieldDoNotScroll(long FieldId, BOOL DoNotScroll)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x1f4, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, DoNotScroll);
		return result;
	}
	long SetFormFieldDoNotSpellCheck(long FieldId, BOOL SpellCheck)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x1f5, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, SpellCheck);
		return result;
	}
	long SetFormFieldFileSelect(long FieldId, BOOL FileSelect)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x1f6, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, FileSelect);
		return result;
	}
	long SetFormFieldFontColor(long FieldId, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1f7, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Red, Green, Blue);
		return result;
	}
	long SetFormFieldFontColor_2(long FieldId, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1f8, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetFormFieldFontColor_3(long FieldId, long ChildIdx, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1f9, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, Red, Green, Blue);
		return result;
	}
	long SetFormFieldFontColor_4(long FieldId, long ChildIdx, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x1fa, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetFormFieldFontResName(long FieldId, LPCTSTR FontResName)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x1fb, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, FontResName);
		return result;
	}
	long SetFormFieldFontSize(long FieldId, float FontSize)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4;
		InvokeHelper(0x1fc, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, FontSize);
		return result;
	}
	long SetFormFieldFontSize_2(long FieldId, long ChildIdx, float FontSize)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_R4;
		InvokeHelper(0x1fd, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, FontSize);
		return result;
	}
	long SetFormFieldItemCommit(long FieldId, BOOL Commit)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x1fe, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Commit);
		return result;
	}
	long SetFormFieldItemEdit(long FieldId, BOOL Editable)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x1ff, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Editable);
		return result;
	}
	long SetFormFieldItemSort(long FieldId, BOOL Sorted)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x200, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Sorted);
		return result;
	}
	long SetFormFieldLocation(long FieldId, float Left, float Top, float Right, float Bottom)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x201, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Left, Top, Right, Bottom);
		return result;
	}
	long SetFormFieldMaxLen(long FieldId, long MaxLen)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x202, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, MaxLen);
		return result;
	}
	long SetFormFieldMultiLine(long FieldId, BOOL MultiLine)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x203, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, MultiLine);
		return result;
	}
	long SetFormFieldMultiSelect(long FieldId, BOOL Multiselect)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x204, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Multiselect);
		return result;
	}
	long SetFormFieldNoBackgroundColor(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x205, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	long SetFormFieldNoBackgroundColor_2(long FieldId, long ChildIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x206, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	long SetFormFieldNoBorderColor(long FieldId)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x207, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId);
		return result;
	}
	long SetFormFieldNoBorderColor_2(long FieldId, long ChildIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x208, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx);
		return result;
	}
	long SetFormFieldNormalCaption(long FieldId, LPCTSTR NormalCaption)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x209, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, NormalCaption);
		return result;
	}
	long SetFormFieldOnStateName(long FieldId, LPCTSTR OnStateName)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x20a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, OnStateName);
		return result;
	}
	long SetFormFieldOnStateName_2(long FieldId, long ChildIdx, LPCTSTR OnStateName)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4 VTS_BSTR;
		InvokeHelper(0x20b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ChildIdx, OnStateName);
		return result;
	}
	long SetFormFieldOptional(long FieldId, long OCGId)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x20c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, OCGId);
		return result;
	}
	long SetFormFieldPassword(long FieldId, BOOL Password)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x20d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Password);
		return result;
	}
	long SetFormFieldRadioInUnison(long FieldId, BOOL Unison)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x20e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Unison);
		return result;
	}
	long SetFormFieldReadOnly(long FieldId, BOOL ROnly)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x20f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, ROnly);
		return result;
	}
	long SetFormFieldRequired(long FieldId, BOOL Required)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x210, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Required);
		return result;
	}
	long SetFormFieldRichText(long FieldId, BOOL RichText)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x211, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, RichText);
		return result;
	}
	long SetFormFieldRotation(long FieldId, long Rotation)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x212, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Rotation);
		return result;
	}
	long SetFormFieldsNeedAppearances(BOOL NeedAppearances)
	{
		long result;
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x213, DISPATCH_METHOD, VT_I4, (void*)&result, parms, NeedAppearances);
		return result;
	}
	long SetFormFieldTextAlignment(long FieldId, long TextAlign)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x214, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, TextAlign);
		return result;
	}
	long SetFormFieldTitle(long FieldId, LPCTSTR Title)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x215, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Title);
		return result;
	}
	long SetFormFieldValue(long FieldId, LPCTSTR Value)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x216, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Value);
		return result;
	}
	long SetFormFieldValue_2(long FieldId, LPCTSTR Value, LPCTSTR Separator)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_BSTR;
		InvokeHelper(0x217, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Value, Separator);
		return result;
	}
	long SetFormFieldVisibility(long FieldId, long Visibility)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x218, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FieldId, Visibility);
		return result;
	}
	long SetImageOptional(LPCTSTR ImageResName, long OCGId)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_I4;
		InvokeHelper(0x219, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ImageResName, OCGId);
		return result;
	}
	void SetJpeg2000Quality(long Quality)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x21a, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Quality);
	}
	void SetJpegQuality(long Quality)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x21b, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Quality);
	}
	void SetKeywords(LPCTSTR Keywords)
	{
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x21c, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Keywords);
	}
	long SetLanguage(LPCTSTR Language)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x21d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Language);
		return result;
	}
	long SetLineAlpha(unsigned char Alpha)
	{
		long result;
		static BYTE parms[] = VTS_UI1;
		InvokeHelper(0x21e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Alpha);
		return result;
	}
	long SetLineCapStyle(long LineCap)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x21f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LineCap);
		return result;
	}
	long SetLineColor(unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x220, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Red, Green, Blue);
		return result;
	}
	long SetLineColor_2(unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black)
	{
		long result;
		static BYTE parms[] = VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x221, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Cyan, Magenta, Yellow, Black);
		return result;
	}
	long SetLineDash(float DashOn, float DashOff)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4;
		InvokeHelper(0x222, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DashOn, DashOff);
		return result;
	}
	long SetLineDash_2(SAFEARRAY * * DashPattern)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN;
		InvokeHelper(0x223, DISPATCH_METHOD, VT_I4, (void*)&result, parms, DashPattern);
		return result;
	}
	long SetLineJoinStyle(long LineJoin)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x224, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LineJoin);
		return result;
	}
	long SetLineNoDash()
	{
		long result;
		InvokeHelper(0x225, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SetLineWidth(float LineWidth)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x226, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LineWidth);
		return result;
	}
	void SetMeasurementUnit(long UnitMode)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x227, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, UnitMode);
	}
	long SetMetadata(LPCTSTR XMP)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x228, DISPATCH_METHOD, VT_I4, (void*)&result, parms, XMP);
		return result;
	}
	void SetMRCImageBackgroundResolution(float Resolution)
	{
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x229, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Resolution);
	}
	void SetMRCPreserveSmoothing(BOOL PreserveSmoothing)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x22a, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, PreserveSmoothing);
	}
	long SetOCGExportState(long OCGId, long ExportState)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x22b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId, ExportState);
		return result;
	}
	long SetOCGLockedState(long OCGId, BOOL Locked)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x22c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId, Locked);
		return result;
	}
	long SetOCGPrintState(long OCGId, long PrintState)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x22d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId, PrintState);
		return result;
	}
	long SetOCGTitle(long OCGId, LPCTSTR Title)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x22e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId, Title);
		return result;
	}
	long SetOCGViewState(long OCGId, long ViewState)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x22f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId, ViewState);
		return result;
	}
	long SetOCGZoomMax(long OCGId, float ZoomMax)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4;
		InvokeHelper(0x230, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId, ZoomMax);
		return result;
	}
	long SetOCGZoomMin(long OCGId, float ZoomMin)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4;
		InvokeHelper(0x231, DISPATCH_METHOD, VT_I4, (void*)&result, parms, OCGId, ZoomMin);
		return result;
	}
	void SetOrigin(long Origin)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x232, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Origin);
	}
	long SetPageBox(long PageBox, float Left, float Top, float Right, float Bottom)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x233, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageBox, Left, Top, Right, Bottom);
		return result;
	}
	long SetPageContent(LPCTSTR Content)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x234, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Content);
		return result;
	}
	long SetPageLabelsRangeNumPortion(long LabelingRangeIdx, long NumPortion)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x235, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LabelingRangeIdx, NumPortion);
		return result;
	}
	long SetPageLabelsRangePrefix(long LabelingRangeIdx, LPCTSTR Prefix)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x236, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LabelingRangeIdx, Prefix);
		return result;
	}
	long SetPageLabelsRangeStartPage(long LabelingRangeIdx, long StartPage)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x237, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LabelingRangeIdx, StartPage);
		return result;
	}
	long SetPageLabelsRangeStyle(long LabelingRangeIdx, long Style)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x238, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LabelingRangeIdx, Style);
		return result;
	}
	long SetPageMetadata(LPCTSTR XMP)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x239, DISPATCH_METHOD, VT_I4, (void*)&result, parms, XMP);
		return result;
	}
	long SetPagePrivateTag(LPCTSTR Tag, LPCTSTR Content)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR;
		InvokeHelper(0x23a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Tag, Content);
		return result;
	}
	void SetPageUserUnit(float UserUnit)
	{
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x23b, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, UserUnit);
	}
	long SetPassword(LPCTSTR Password)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x23c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Password);
		return result;
	}
	long SetPrependContentMode(BOOL Enable)
	{
		long result;
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x23d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Enable);
		return result;
	}
	void SetProducer(LPCTSTR Producer)
	{
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x23e, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Producer);
	}
	long SetSignatureCertificateFromP12(LPCTSTR CertPath, LPCTSTR PFXPassword)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR;
		InvokeHelper(0x23f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, CertPath, PFXPassword);
		return result;
	}
	long SetSignatureCertificateFromSmartCard(LPCTSTR ProviderName, LPCTSTR KeyContainerName, LPCTSTR PinCode)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR;
		InvokeHelper(0x240, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ProviderName, KeyContainerName, PinCode);
		return result;
	}
	long SetSignatureCertificateFromSmartCardBySerialNumber(LPCTSTR SerialNumber, LPCTSTR PinCode)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR;
		InvokeHelper(0x241, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SerialNumber, PinCode);
		return result;
	}
	long SetSignatureCertificateFromStore(LPCTSTR SerialNumber)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x242, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SerialNumber);
		return result;
	}
	long SetSignatureCertificationLevel(long Level)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x243, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Level);
		return result;
	}
	long SetSignatureHash(long hashAlg)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x244, DISPATCH_METHOD, VT_I4, (void*)&result, parms, hashAlg);
		return result;
	}
	long SetSignatureInfo(LPCTSTR Name, LPCTSTR Reason, LPCTSTR Location, LPCTSTR ContactInfo)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR VTS_BSTR;
		InvokeHelper(0x245, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Name, Reason, Location, ContactInfo);
		return result;
	}
	long SetSignaturePos(float StampLeft, float StampBottom, float StampWidth, float StampHeight)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x246, DISPATCH_METHOD, VT_I4, (void*)&result, parms, StampLeft, StampBottom, StampWidth, StampHeight);
		return result;
	}
	long SetSignaturePosFromPlaceHolder(long SignatureIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x247, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SignatureIdx);
		return result;
	}
	long SetSignaturePosFromPlaceHolder_2(LPCTSTR SignatureName)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x248, DISPATCH_METHOD, VT_I4, (void*)&result, parms, SignatureName);
		return result;
	}
	long SetSignatureStampImage(LPCTSTR StampResName)
	{
		long result;
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x249, DISPATCH_METHOD, VT_I4, (void*)&result, parms, StampResName);
		return result;
	}
	long SetSignatureText(LPCTSTR Text, LPCTSTR FontResName, float FontSize, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black, long AlignHorz, long AlignVert, BOOL ShowText)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_I4 VTS_I4 VTS_BOOL;
		InvokeHelper(0x24a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Text, FontResName, FontSize, Cyan, Magenta, Yellow, Black, AlignHorz, AlignVert, ShowText);
		return result;
	}
	long SetSignatureText_2(LPCTSTR Text, LPCTSTR FontResName, float FontSize, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black, long AlignHorz, long AlignVert, long TextDecorationStyle, BOOL ShowText)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_I4 VTS_I4 VTS_I4 VTS_BOOL;
		InvokeHelper(0x27d, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Text, FontResName, FontSize, Cyan, Magenta, Yellow, Black, AlignHorz, AlignVert, TextDecorationStyle, ShowText);
		return result;
	}
	long SetSignatureTimestampInfo(LPCTSTR TSURL, LPCTSTR TSUsername, LPCTSTR TSUserpass)
	{
		long result;
		static BYTE parms[] = VTS_BSTR VTS_BSTR VTS_BSTR;
		InvokeHelper(0x24b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TSURL, TSUsername, TSUserpass);
		return result;
	}
	long SetSignatureValidationMark(BOOL ShowValidationMark)
	{
		long result;
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x24c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ShowValidationMark);
		return result;
	}
	void SetSubject(LPCTSTR Subject)
	{
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x24d, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Subject);
	}
	long SetTagActualText(long TagID, LPCTSTR ActualText)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x24e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, ActualText);
		return result;
	}
	long SetTagAlternateDescription(long TagID, LPCTSTR AlternateDescription)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x24f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, AlternateDescription);
		return result;
	}
	long SetTagAttribute(long TagID, LPCTSTR Key, LPCTSTR Value)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_BSTR;
		InvokeHelper(0x250, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, Key, Value);
		return result;
	}
	long SetTagAttribute_2(long TagID, LPCTSTR Key, SAFEARRAY * * Value)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_UNKNOWN;
		InvokeHelper(0x251, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, Key, Value);
		return result;
	}
	long SetTagAttribute_3(long TagID, LPCTSTR Key, double Value)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_R8;
		InvokeHelper(0x252, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, Key, Value);
		return result;
	}
	long SetTagAttribute_4(long TagID, LPCTSTR Key, SAFEARRAY * * Value)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR VTS_UNKNOWN;
		InvokeHelper(0x253, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, Key, Value);
		return result;
	}
	long SetTagLanguage(long TagID, LPCTSTR Language)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x254, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, Language);
		return result;
	}
	long SetTagTitle(long TagID, LPCTSTR Title)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BSTR;
		InvokeHelper(0x255, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TagID, Title);
		return result;
	}
	long SetTextCharSpacing(float CharSpacing)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x256, DISPATCH_METHOD, VT_I4, (void*)&result, parms, CharSpacing);
		return result;
	}
	void SetTextExtractionOptions(long Options)
	{
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x257, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Options);
	}
	long SetTextMode(long TextMode)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x258, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TextMode);
		return result;
	}
	long SetTextRise(float Rise)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x259, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Rise);
		return result;
	}
	long SetTextScaling(float Scaling)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x25a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Scaling);
		return result;
	}
	long SetTextSize(float TextSize)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x25b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TextSize);
		return result;
	}
	long SetTextWordSpacing(float WordSpacing)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x25c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, WordSpacing);
		return result;
	}
	void SetTitle(LPCTSTR Title)
	{
		static BYTE parms[] = VTS_BSTR;
		InvokeHelper(0x25d, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Title);
	}
	long SetViewerLayoutMode(long LayoutMode)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x25e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, LayoutMode);
		return result;
	}
	long SetViewerNonFullScreenPageMode(long NonFullScreenPageMode)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x25f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, NonFullScreenPageMode);
		return result;
	}
	long SetViewerOpenAction(long ActionID)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x260, DISPATCH_METHOD, VT_I4, (void*)&result, parms, ActionID);
		return result;
	}
	long SetViewerPageMode(long PageMode)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x261, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageMode);
		return result;
	}
	long SetViewerPreference(long Preference, BOOL Enable)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_BOOL;
		InvokeHelper(0x262, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Preference, Enable);
		return result;
	}
	long StrokePath()
	{
		long result;
		InvokeHelper(0x263, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SwapPages(long Page1, long Page2)
	{
		long result;
		static BYTE parms[] = VTS_I4 VTS_I4;
		InvokeHelper(0x264, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Page1, Page2);
		return result;
	}
	long FlattenAnnotation(long AnnotationIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x268, DISPATCH_METHOD, VT_I4, (void*)&result, parms, AnnotationIdx);
		return result;
	}
	void ReleaseEventsTarget()
	{
		InvokeHelper(0x269, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long MergePages(SAFEARRAY * * Pages, BOOL RemovePages)
	{
		long result;
		static BYTE parms[] = VTS_UNKNOWN VTS_BOOL;
		InvokeHelper(0x26b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Pages, RemovePages);
		return result;
	}
	void SetOverrideOcrEngine(BOOL Override)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x26c, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Override);
	}
	BOOL GetOverrideOcrEngine()
	{
		BOOL result;
		InvokeHelper(0x26d, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	void SetOcrPageOrientationDetection(BOOL Enabled)
	{
		static BYTE parms[] = VTS_BOOL;
		InvokeHelper(0x26e, DISPATCH_METHOD, VT_EMPTY, nullptr, parms, Enabled);
	}
	long AddRedactionRegion(float Left, float Top, float Width, float Height)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x26f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height);
		return result;
	}
	long AddRedactionRegion_2(float Left, float Top, float Width, float Height, unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x275, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Red, Green, Blue);
		return result;
	}
	long AddRedactionRegion_3(float Left, float Top, float Width, float Height, unsigned char Red, unsigned char Green, unsigned char Blue, unsigned char Alpha)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x276, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Red, Green, Blue, Alpha);
		return result;
	}
	long ApplyRedaction()
	{
		long result;
		InvokeHelper(0x270, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	void ClearRedactionRegions()
	{
		InvokeHelper(0x271, DISPATCH_METHOD, VT_EMPTY, nullptr, nullptr);
	}
	long Repair()
	{
		long result;
		InvokeHelper(0x272, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long RemoveHiddenText()
	{
		long result;
		InvokeHelper(0x273, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ClearCachedResources()
	{
		long result;
		InvokeHelper(0x274, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long DeletePagePieceInfo()
	{
		long result;
		InvokeHelper(0x277, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	BOOL HasInvisibleText()
	{
		BOOL result;
		InvokeHelper(0x278, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	long RemoveAllText()
	{
		long result;
		InvokeHelper(0x279, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long SetTextDecorationStyle(long TextDecorationStyle)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x27a, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TextDecorationStyle);
		return result;
	}
	long SetTextUnderlineWidth(float TextDecorationLineWidth)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x27b, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TextDecorationLineWidth);
		return result;
	}
	long SetTextUnderlineColor(unsigned char Red, unsigned char Green, unsigned char Blue)
	{
		long result;
		static BYTE parms[] = VTS_UI1 VTS_UI1 VTS_UI1;
		InvokeHelper(0x27c, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Red, Green, Blue);
		return result;
	}
	long SetTextUnderlineStyle(long TextUnderlineStyle)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x27e, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TextUnderlineStyle);
		return result;
	}
	long SetTextUnderlineDistance(float TextUnderlineDistance)
	{
		long result;
		static BYTE parms[] = VTS_R4;
		InvokeHelper(0x27f, DISPATCH_METHOD, VT_I4, (void*)&result, parms, TextUnderlineDistance);
		return result;
	}
	long RemoveTextArea(float Left, float Top, float Width, float Height)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4;
		InvokeHelper(0x280, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height);
		return result;
	}
	CString GetPageTextWithCoords_2(LPCTSTR FieldSeparator, long Options)
	{
		CString result;
		static BYTE parms[] = VTS_BSTR VTS_I4;
		InvokeHelper(0x281, DISPATCH_METHOD, VT_BSTR, (void*)&result, parms, FieldSeparator, Options);
		return result;
	}
	long FlattenVisibleOCGs()
	{
		long result;
		InvokeHelper(0x282, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}
	long ClonePages(LPDISPATCH FromPDF, LPCTSTR PageRange)
	{
		long result;
		static BYTE parms[] = VTS_DISPATCH VTS_BSTR;
		InvokeHelper(0x283, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FromPDF, PageRange);
		return result;
	}
	BOOL SearchText_3(LPCTSTR Text, long Occurrence, BOOL CaseSensitive, BOOL WholeWords, BOOL OrdinalComparison, SAFEARRAY * * BoundingBoxes)
	{
		BOOL result;
		static BYTE parms[] = VTS_BSTR VTS_I4 VTS_BOOL VTS_BOOL VTS_BOOL VTS_UNKNOWN;
		InvokeHelper(0x284, DISPATCH_METHOD, VT_BOOL, (void*)&result, parms, Text, Occurrence, CaseSensitive, WholeWords, OrdinalComparison, BoundingBoxes);
		return result;
	}
	long RemovePageBox(long PageBox)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x285, DISPATCH_METHOD, VT_I4, (void*)&result, parms, PageBox);
		return result;
	}
	BOOL IsTagged()
	{
		BOOL result;
		InvokeHelper(0x286, DISPATCH_METHOD, VT_BOOL, (void*)&result, nullptr);
		return result;
	}
	long UnembedFont(long FontIdx)
	{
		long result;
		static BYTE parms[] = VTS_I4;
		InvokeHelper(0x287, DISPATCH_METHOD, VT_I4, (void*)&result, parms, FontIdx);
		return result;
	}
	long AddFileAttachmentAnnot(float Left, float Top, float Width, float Height, SAFEARRAY * * Data, LPCTSTR FileName, LPCTSTR Title, LPCTSTR Description, unsigned char Red, unsigned char Green, unsigned char Blue, float Opacity, long AnnotIcon)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_UNKNOWN VTS_BSTR VTS_BSTR VTS_BSTR VTS_UI1 VTS_UI1 VTS_UI1 VTS_R4 VTS_I4;
		InvokeHelper(0x288, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Data, FileName, Title, Description, Red, Green, Blue, Opacity, AnnotIcon);
		return result;
	}
	long AddFileAttachmentAnnot_2(float Left, float Top, float Width, float Height, SAFEARRAY * * Data, LPCTSTR FileName, LPCTSTR Title, LPCTSTR Description, unsigned char Cyan, unsigned char Magenta, unsigned char Yellow, unsigned char Black, float Opacity, long AnnotIcon)
	{
		long result;
		static BYTE parms[] = VTS_R4 VTS_R4 VTS_R4 VTS_R4 VTS_UNKNOWN VTS_BSTR VTS_BSTR VTS_BSTR VTS_UI1 VTS_UI1 VTS_UI1 VTS_UI1 VTS_R4 VTS_I4;
		InvokeHelper(0x289, DISPATCH_METHOD, VT_I4, (void*)&result, parms, Left, Top, Width, Height, Data, FileName, Title, Description, Cyan, Magenta, Yellow, Black, Opacity, AnnotIcon);
		return result;
	}
	long RemoveXFAFormFieldsData()
	{
		long result;
		InvokeHelper(0x28a, DISPATCH_METHOD, VT_I4, (void*)&result, nullptr);
		return result;
	}

	// IGdPicturePDF properties
public:

};
