Option Explicit On
Option Infer On
Option Strict On

Imports GdPicture14

Namespace DocumentCleanUp

    ' -------------------------------
    ' class definition
    ' -------------------------------

    Public MustInherit Class ADocumentCleanUpEffectParameters
        Public Function Clone() As ADocumentCleanUpEffectParameters
            Return DirectCast(Me.MemberwiseClone(), ADocumentCleanUpEffectParameters)
        End Function
    End Class

    Public MustInherit Class ADocumentCleanUpEffect
        Protected _parameters As ADocumentCleanUpEffectParameters = Nothing
        Public MustOverride ReadOnly Property Name() As String

        Public ReadOnly Property Parameters() As ADocumentCleanUpEffectParameters
            Get
                Return _parameters
            End Get
        End Property

        Public Function Clone() As ADocumentCleanUpEffect
            Dim obj As ADocumentCleanUpEffect = DirectCast(Me.MemberwiseClone(), ADocumentCleanUpEffect)
            If Not obj._parameters Is Nothing Then
                obj._parameters = Me._parameters.Clone()
            End If
            Return obj
        End Function
    End Class

    ' -------------------------------
    ' effects class definition
    ' -------------------------------

    ' Auto deskew
    Public Class AutoDeskewEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property MaxAngleOfResearch As Single = 10
        Public Property BackColor As Color = Color.White
        Public Property AngleStep As Single = 0.25
        Public Property Optimistic As Boolean = True
    End Class

    Public Class AutoDeskewEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New AutoDeskewEffectParameters()
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Auto deskew"
            End Get
        End Property
    End Class

    ' Auto invert negative
    Public Class AutoInvertEffect
        Inherits ADocumentCleanUpEffect

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Auto invert negative"
            End Get
        End Property
    End Class

    ' Auto text invert
    Public Class AutoTextInvertEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property MinObjectWidth As Integer
        Public Property MinObjectHeight As Integer
        Public Property MinBlackPercent As Integer
        Public Property MaxBlackPercent As Integer
        Public Property FixBackground As Boolean
        Public Property ConnectedToLines As Boolean
        Public Property MaxLinesThickness As Integer
    End Class

    Public Class AutoTextInvertEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New AutoTextInvertEffectParameters()
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Auto text invert"
            End Get
        End Property
    End Class

    ' Crop black borders
    Public Class CropBlackBordersEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property Confidence As Single = 75
        Public Property SkipLinesCount As Integer
    End Class

    Public Class CropBlackBordersEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New CropBlackBordersEffectParameters()
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Crop black borders"
            End Get
        End Property
    End Class

    ' Crop black borders
    Public Class CropBlackBordersEffectExParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property Confidence As Single = 75
        Public Property SkipLinesCount As Integer
    End Class

    Public Class CropBlackBordersExEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New CropBlackBordersEffectExParameters()
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Crop black borders extended"
            End Get
        End Property
    End Class

    ' Crop black borders
    Public Class CropBordersEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property Confidence As Single = 75
        Public Property PixelReference As ReferencePoint
        Public Property Left As Integer
        Public Property Top As Integer
        Public Property Width As Integer
        Public Property Height As Integer
        Public Property Context As ImagingContext
    End Class

    Public Class CropBordersEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New CropBordersEffectParameters()
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Crop borders"
            End Get
        End Property
    End Class

    ' Crop white borders
    Public Class CropWhiteBordersEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property Confidence As Single = 99
        Public Property SkipLinesCount As Integer
    End Class

    Public Class CropWhiteBordersEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New CropWhiteBordersEffectParameters()
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Crop white borders"
            End Get
        End Property
    End Class

    ' delete black borders
    Public Class DeleteBlackBordersEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property Margin As Integer = 0
        Public Property SkewedBorders As Boolean = False
    End Class

    Public Class DeleteBlackBordersEffect
        Inherits ADocumentCleanUpEffect

        Public Sub New()
            _parameters = New DeleteBlackBordersEffectParameters()
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Delete black borders"
            End Get
        End Property
    End Class

    ' despeckle
    Public Class DespeckleEffect
        Inherits ADocumentCleanUpEffect

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Despeckle"
            End Get
        End Property
    End Class

    ' despeckle more
    Public Class DespeckleMoreEffect
        Inherits ADocumentCleanUpEffect

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Despeckle more"
            End Get
        End Property
    End Class

    ' Despeckle advanced
    Public Class DespeckAdvancedParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property DespeckleMode As DespeckleType = DespeckleType.FourConnected
        Public Property Strength As Integer = 5
    End Class

    Public Class DespeckleAdvancedEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New DespeckAdvancedParameters()
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Despeckle (advanced)"
            End Get
        End Property
    End Class

    ' median
    Public Class MedianEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property KernelSize As Integer = 1
    End Class

    Public Class MedianEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New MedianEffectParameters()
        End Sub

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Median"
            End Get
        End Property
    End Class

    ' remove blob
    Public Class RemoveBlobEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property MinBlobWidth As Integer = 20
        Public Property MinBlobHeight As Integer = 20
        Public Property MaxBlobWidth As Integer = 100
        Public Property MaxBlobHeight As Integer = 100
        Public Property MinFillPercent As Integer = 75
        Public Property MaxFillPercent As Integer = 100
    End Class

    Public Class RemoveBlobEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New RemoveBlobEffectParameters()
        End Sub
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Remove blob"
            End Get
        End Property
    End Class

    ' remove punch holes
    Public Class RemoveHolePunchEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property Margins As HolePunchMargins = HolePunchMargins.MarginBottom Or HolePunchMargins.MarginLeft Or HolePunchMargins.MarginRight Or HolePunchMargins.MarginTop
    End Class

    Public Class RemoveHolePunchEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New RemoveHolePunchEffectParameters()
        End Sub
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Remove punch holes"
            End Get
        End Property
    End Class

    ' remove lines
    Public Class RemoveLinesEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property Orientation As LineRemoveOrientation = LineRemoveOrientation.Horizontal
        Public Property MaxLineGap As Integer = -1
        Public Property MaxLineThickness As Integer = 8
        Public Property MinLineLength As Integer = 75
        Public Property MaxInterception As Integer = 8
        Public Property ReConnectBrokenCharacters As Boolean = False
    End Class

    Public Class RemoveLinesEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New RemoveLinesEffectParameters
        End Sub
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Remove lines"
            End Get
        End Property
    End Class

    'remove staple mark
    Public Class RemoveStapleMarkEffect
        Inherits ADocumentCleanUpEffect

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Remove staple mark"
            End Get
        End Property
    End Class

    ' bitonal close8
    Public Class BitonalClose8Effect
        Inherits ADocumentCleanUpEffect

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal morphological close"
            End Get
        End Property
    End Class

    ' bitonal despeckle
    Public Class BitonalDespeckleEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property FixText As Boolean
    End Class

    Public Class BitonalDespeckleEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New BitonalDespeckleEffectParameters()
        End Sub
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal despeckle"
            End Get
        End Property
    End Class

    ' bitonal despeckle more
    Public Class BitonalDespeckleMoreEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property FixText As Boolean
    End Class

    Public Class BitonalDespeckleMoreEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New BitonalDespeckleMoreEffectParameters()
        End Sub
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal despeckle more"
            End Get
        End Property
    End Class

    ' bitonal ouline
    Public Class BitonalOutlineEffect
        Inherits ADocumentCleanUpEffect

        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal outline"
            End Get
        End Property
    End Class

    ' bitonal skeletonize
    Public Class BitonalSkeletonizeEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property Repetition As Integer = 4
    End Class

    Public Class BitonalSkeletonizeEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New BitonalSkeletonizeEffectParameters()
        End Sub
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal skeletonize"
            End Get
        End Property
    End Class

    ' bitonal vigorous despeckle
    Public Class BitonalVigorousDespeckleEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property CheckForDotOfI As Boolean = False
    End Class

    Public Class BitonalVigorousDespeckleEffect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New BitonalVigorousDespeckleEffectParameters()
        End Sub
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal vigorous despeckle"
            End Get
        End Property
    End Class

    ' bitonal dilate
    Public Class BitonalDilateEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property KernelSize As Integer = 1
    End Class

    Public Class BitonalDilateEFfect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New BitonalDilateEffectParameters()
        End Sub
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal dilate"
            End Get
        End Property
    End Class

    ' bitonal dilate 4
    Public Class BitonalDilate4EFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal dilate 4 directions"
            End Get
        End Property
    End Class

    ' bitonal dilate 8
    Public Class BitonalDilate8EFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal dilate 8 directions"
            End Get
        End Property
    End Class

    ' bitonal dilate h
    Public Class BitonalDilateHEFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal dilate horizontal"
            End Get
        End Property
    End Class

    ' bitonal dilate v
    Public Class BitonalDilateVEFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal dilate vertical"
            End Get
        End Property
    End Class

    ' bitonal erode
    Public Class BitonalErodeEffectParameters
        Inherits ADocumentCleanUpEffectParameters
        Public Property KernelSize As Integer = 1
    End Class

    Public Class BitonalErodeEFfect
        Inherits ADocumentCleanUpEffect
        Public Sub New()
            _parameters = New BitonalErodeEffectParameters()
        End Sub
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal erode"
            End Get
        End Property
    End Class

    ' bitonal erode 4
    Public Class BitonalErode4EFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal erode 4 directions"
            End Get
        End Property
    End Class

    ' bitonal erode 8
    Public Class BitonalErode8EFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal erode 8 directions"
            End Get
        End Property
    End Class

    ' bitonal erode v
    Public Class BitonalErodeVEFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal erode vertical"
            End Get
        End Property
    End Class

    ' bitonal fill holes horizontal
    Public Class BitonalFillHolesHEFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal fill holes horizontal"
            End Get
        End Property
    End Class

    ' bitonal fill holes horizontal & vertical
    Public Class BitonalFillHolesHVEFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal fill holes horizontal and vertical"
            End Get
        End Property
    End Class

    ' bitonal fill holes vertical
    Public Class BitonalFillHolesVEFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal fill holes vertical"
            End Get
        End Property
    End Class

    ' bitonal open 8
    Public Class BitonalOpen8EFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal morphological open"
            End Get
        End Property
    End Class

    ' bitonal remove isolated dots 2x2
    Public Class BitonalRemoveIsolatedDots2x2EFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal remove isolated dots 2x2"
            End Get
        End Property
    End Class

    ' bitonal remove isolated dots 4
    Public Class BitonalRemoveIsolatedDots4EFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal remove isolated dots 4 directions"
            End Get
        End Property
    End Class

    ' bitonal remove isolated dots 8
    Public Class BitonalRemoveIsolatedDots8EFfect
        Inherits ADocumentCleanUpEffect
        Public Overrides ReadOnly Property Name As String
            Get
                Return "Bitonal remove isolated dots 8 directions"
            End Get
        End Property
    End Class

    ' -------------------------------
    ' effects list
    ' -------------------------------
    Public Class DocumentCleanUpEffects
        Private ReadOnly _list As List(Of ADocumentCleanUpEffect) = New List(Of ADocumentCleanUpEffect)()

        Public Sub New()
            _list.Add(New AutoDeskewEffect())
            _list.Add(New AutoInvertEffect())
            _list.Add(New AutoTextInvertEffect())
            _list.Add(New CropBlackBordersEffect())
            _list.Add(New CropBlackBordersExEffect())
            _list.Add(New CropBordersEffect)
            _list.Add(New CropWhiteBordersEffect)
            _list.Add(New DeleteBlackBordersEffect())
            _list.Add(New DespeckleEffect())
            _list.Add(New DespeckleMoreEffect())
            _list.Add(New DespeckleAdvancedEffect())
            _list.Add(New MedianEffect())
            _list.Add(New RemoveBlobEffect())
            _list.Add(New RemoveHolePunchEffect())
            _list.Add(New RemoveLinesEffect())
            _list.Add(New RemoveStapleMarkEffect())
            _list.Add(New BitonalClose8Effect())
            _list.Add(New BitonalDespeckleEffect())
            _list.Add(New BitonalDespeckleMoreEffect())
            _list.Add(New BitonalOutlineEffect())
            _list.Add(New BitonalSkeletonizeEffect())
            _list.Add(New BitonalVigorousDespeckleEffect())
            _list.Add(New BitonalDilateEFfect())
            _list.Add(New BitonalDilate4EFfect())
            _list.Add(New BitonalDilate8EFfect())
            _list.Add(New BitonalDilateHEFfect())
            _list.Add(New BitonalDilateVEFfect())
            _list.Add(New BitonalErodeEFfect())
            _list.Add(New BitonalErode4EFfect())
            _list.Add(New BitonalErode8EFfect())
            _list.Add(New BitonalErodeVEFfect())
            _list.Add(New BitonalFillHolesHEFfect())
            _list.Add(New BitonalFillHolesHVEFfect())
            _list.Add(New BitonalFillHolesVEFfect())
            _list.Add(New BitonalOpen8EFfect())
            _list.Add(New BitonalRemoveIsolatedDots2x2EFfect())
            _list.Add(New BitonalRemoveIsolatedDots4EFfect())
            _list.Add(New BitonalRemoveIsolatedDots8EFfect())
        End Sub

        Public ReadOnly Property List() As List(Of ADocumentCleanUpEffect)
            Get
                Return _list
            End Get
        End Property
    End Class
End Namespace