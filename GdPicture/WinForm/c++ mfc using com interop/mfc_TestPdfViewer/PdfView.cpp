#include "stdafx.h"
#include "PdfView.h"
#include "MainFrm.h"
#include "ChildFrm.h"
#include "CObject0.h"
#include "CGdViewer0.h"
#include "CGdViewer0.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

BEGIN_MESSAGE_MAP(CPdfViewApp, CWinApp)
	ON_COMMAND(ID_FILE_OPEN, OnFileOpen)
	ON_COMMAND(ID_FILE_PRINT, &CPdfViewApp::OnFilePrint)
END_MESSAGE_MAP()

CPdfViewApp theApp;

BOOL CPdfViewApp::InitInstance()
{
	InitCommonControls();

	CWinApp::InitInstance();

	if (!AfxOleInit())
	{
		AfxMessageBox(IDP_OLE_INIT_FAILED);
		return FALSE;
	}

	AfxEnableControlContainer();

	CMDIFrameWnd* pFrame = new CMainFrame;

	if (!pFrame)
		return FALSE;

	m_pMainWnd = pFrame;

	if (!pFrame->LoadFrame(IDR_MAINFRAME))
		return FALSE;

	HINSTANCE hInst = AfxGetResourceHandle();
	m_hMDIMenu  = ::LoadMenu(hInst, MAKEINTRESOURCE(IDR_PdfViewTYPE));
	m_hMDIAccel = ::LoadAccelerators(hInst, MAKEINTRESOURCE(IDR_PdfViewTYPE));

	pFrame->ShowWindow(m_nCmdShow);
	pFrame->UpdateWindow();

	return TRUE;
}

int CPdfViewApp::ExitInstance()
{
	if (m_hMDIMenu != NULL)
		FreeResource(m_hMDIMenu);

	if (m_hMDIAccel != NULL)
		FreeResource(m_hMDIAccel);

	return CWinApp::ExitInstance();
}

void CPdfViewApp::OnFileOpen()
{
	CFileDialog fd(TRUE, "Pdf|*.pdf");

	if (fd.DoModal() == IDOK)
	{
		CMainFrame* pFrame = STATIC_DOWNCAST(CMainFrame, m_pMainWnd);
		CChildFrame *childFrame = (CChildFrame *)pFrame->CreateNewChild(RUNTIME_CLASS(CChildFrame),
					IDR_PdfViewTYPE, m_hMDIMenu, m_hMDIAccel);

		childFrame->m_wndView.Open(fd.GetPathName());
	}
}

void CPdfViewApp::OnFilePrint()
{
	// TODO: Add your command handler code here
	CMainFrame* pFrame = STATIC_DOWNCAST(CMainFrame, m_pMainWnd);

	CChildFrame *childFrame = (CChildFrame *)pFrame->MDIGetActive(NULL);

	childFrame->m_wndView.Print();
}