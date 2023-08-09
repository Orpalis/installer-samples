CLicenseManager oLicenseManager;
oLicenseManager.CreateDispatch(L"GdPicture14.LicenseManager");
oLicenseManager.RegisterKEY(L"XXX"); // Please, replace XXXX by a valid demo or commercial license key.

CGdPictureImaging oGdPictureImaging;
oGdPictureImaging.CreateDispatch(L"GdPicture14.GdPictureImaging");
long ImageID = oGdPictureImaging.CreateGdPictureImageFromFile(L"c:\test.tif");
oGdPictureImaging.SaveAsPDF(ImageID, L"c:\test.pdf", FALSE, L"", L"", L"", L"", L"");
oGdPictureImaging.ReleaseGdPictureImage(ImageID);
oGdPictureImaging.Dispose();