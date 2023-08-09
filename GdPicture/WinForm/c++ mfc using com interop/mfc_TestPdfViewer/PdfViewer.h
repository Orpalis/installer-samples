#pragma once

#include "CGdViewer0.h"
#include "CGdPicturePDF.h"
#include "CLicenseManager.h"

#define LICENSE_KEY_FOR_PDF_VIEWER "XXX" 

class CPdfViewer : public CWnd
{
public:
	void Open(const char *file);
	void Print();

	//Message functions
	afx_msg int OnCreate(LPCREATESTRUCT lpCreateStruct);
	afx_msg void OnSize(UINT nType, int cx, int cy);



protected:
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);

	DECLARE_MESSAGE_MAP()

// Attributes
private:
	int Get32BitScrollPos(int iBar, CScrollBar* pScrollBar);
	void UpdatePageBarPosition();
public:
	CGdViewer0 m_ctrl;
	long m_lHeight;
	long m_lCurScrollPos;
	CString m_file;
};