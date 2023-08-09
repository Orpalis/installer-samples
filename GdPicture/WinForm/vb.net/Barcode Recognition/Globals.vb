Option Strict On
Option Explicit On

Imports GdPicture14


Enum ThresoldingMode
    Linear
    Bradley
    Otsu
    Sauvola
End Enum

Module Globals
    Public Const DEFAULT_BRADLEY_THRESOLD As Integer = 20 'this is the value internally used in GdPicture to threshold barcode images.
    Public binarizationMode As ThresoldingMode = ThresoldingMode.Bradley

    Public DEFAULT_DESPECKLE_TYPE As DespeckleType = DespeckleType.FourConnected
    Public DEFAULT_DESPECKLE_STRENGTH As Integer = 5

    'Parameters for thresholding functions
    Public thresholdValue As Integer = DEFAULT_BRADLEY_THRESOLD
    Public smoothKernel As Integer 'used for sauvola thresholding
    Public contrastMinDif As Integer 'used for sauvola thresholding

    Public despeckleType As DespeckleType = DEFAULT_DESPECKLE_TYPE
    Public despeckleStrength As Integer = DEFAULT_DESPECKLE_STRENGTH

    Public gdPictureImaging As New GdPictureImaging
    Public gdPicturePDF As New GdPicturePDF
    Public nativeImage As Integer
    Public docSourceType As DocumentType
End Module
