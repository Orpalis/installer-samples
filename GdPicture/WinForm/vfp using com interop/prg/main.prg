application.AutoYield = .F. 
oLicenseManager = CREATEOBJECT("GdPicture14.LicenseManager")
oLicenseManager.RegisterKey("XXX") &&Please, replace XXX by a valid demo or commercial license key.

DO FORM fMain
READ EVENTS
QUIT
