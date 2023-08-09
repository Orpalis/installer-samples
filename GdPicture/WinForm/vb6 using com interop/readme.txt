1 - Open vb6 project (probably requires Admin mode on Windows 8 and higher)
2 - Add reference to GdPicture.NET: Project / References ... / Browse... / Select "\GdPicture.NET 14\Redist\COM Interop\GdPicture.NET.14.tlb"



To create a GdPictureImaging object:
--------------------------------------------
Dim Obj As New GdPictureImaging
Dim ImageID As Long
ImageID = Obj.CreateGdPictureImageFromFile("")