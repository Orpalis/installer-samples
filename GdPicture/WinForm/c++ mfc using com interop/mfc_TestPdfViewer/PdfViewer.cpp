#include "stdafx.h"
#include "PdfView.h"
#include "PdfViewer.h"
#include <iostream>

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

BEGIN_MESSAGE_MAP(CPdfViewer, CWnd)
	ON_WM_CREATE()
	ON_WM_SIZE()
	ON_WM_VSCROLL()
	ON_WM_MOUSEWHEEL()

END_MESSAGE_MAP()

BOOL CPdfViewer::PreCreateWindow(CREATESTRUCT& cs)
{
	if (!CWnd::PreCreateWindow(cs))
		return FALSE;

	cs.dwExStyle |= WS_EX_CLIENTEDGE;
	cs.style &= ~WS_BORDER;
	cs.lpszClass = AfxRegisterWndClass(CS_HREDRAW|CS_VREDRAW|CS_DBLCLKS,
		::LoadCursor(NULL, IDC_ARROW), reinterpret_cast<HBRUSH>(COLOR_WINDOW+1), NULL);
//	cs.style |= WS_VSCROLL;

	return TRUE;
}

const int CTRL_ID = 280;

int CPdfViewer::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	HRESULT hr = CoInitialize(NULL);

	// Register the license key
	CLicenseManager oLicenseManager;
	oLicenseManager.CreateDispatch("GdPicture14.LicenseManager" );
	oLicenseManager.RegisterKEY(LICENSE_KEY_FOR_PDF_VIEWER);

	if (CWnd::OnCreate(lpCreateStruct) == -1)
		return -1;
	//Create the control, just make sure to use WS_CHILD and WS_VISIBLE.
	if (!m_ctrl.Create("PdfWnd", WS_CHILD | WS_VISIBLE, CRect(0, 0, 0, 0), this, CTRL_ID))
	{
		AfxMessageBox("Failed to create adobe wnd");
		return -1;
	}

	m_ctrl.put_EnableMenu(true);
	m_ctrl.put_ContinuousViewMode(TRUE);
	m_ctrl.put_MouseWheelMode(2);
	m_ctrl.put_ScrollBars(FALSE);

	m_ctrl.put_EnableMouseWheel(FALSE);
	return 0;
}

void CPdfViewer::OnSize(UINT nType, int cx, int cy)
{
	CWnd::OnSize(nType, cx, cy);

	//Resize the control with the window.
	if (IsWindow(m_ctrl.m_hWnd))
	{
		m_lHeight = cy;
		CRect rc;
		GetClientRect(rc);
		m_ctrl.MoveWindow(rc);
		
	}
}

void CPdfViewer::Open(const char *file)
{
	m_file = file;
	m_ctrl.DisplayFromFile(file);
}

void CPdfViewer::Print()
{
	CGdPicturePDF oGdPicturePDF;
	oGdPicturePDF.CreateDispatch("GdPicture14.GdPicturePDF");
	oGdPicturePDF.LoadFromFile(m_file, TRUE);
	oGdPicturePDF.PrintSetAutoRotation(TRUE);
	oGdPicturePDF.PrintSetShowPrintingProgress(TRUE);
	oGdPicturePDF.PrintSetFromToPage(1, oGdPicturePDF.GetPageCount());

	// Pass the Page Count as Document name to display the page count on the Print Progrsss Dialog.
	CString sPageCountAsDocName;
	long lPageCount(oGdPicturePDF.GetPageCount());
	sPageCountAsDocName.Format("%ld", lPageCount);

	oGdPicturePDF.PrintSetDocumentName(sPageCountAsDocName);
	oGdPicturePDF.PrintDialog();
}



