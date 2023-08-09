#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"       // main symbols

class CPdfViewApp : public CWinApp
{
public:
	virtual BOOL InitInstance();
	virtual int ExitInstance();

protected:
	HMENU m_hMDIMenu;
	HACCEL m_hMDIAccel;

public:
	afx_msg void OnFileOpen();

	DECLARE_MESSAGE_MAP()
	afx_msg void OnFilePrint();
};

extern CPdfViewApp theApp;
