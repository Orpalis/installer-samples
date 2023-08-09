Option Strict On
Option Explicit On

Imports GdPicture14

Public Class Form1
    Private POS_INDICATOR As String = Chr(32) & Chr(182)
    Private ImageID, nClonedImageID As Integer
    Private nStartPosX, nStartPosY As Integer
    Private bCursorEnabled As Boolean
    Private sText As String
    Private sFontName As String
    Private FontStyle As FontStyle
    Private nFontHeight As Integer
    Private oGdPictureImaging As New GdPictureImaging
    Public WithEvents oCursor As System.Windows.Forms.Label


    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.

        Me.oCursor = New System.Windows.Forms.Label
        oCursor.BackColor = System.Drawing.SystemColors.ActiveCaption
        oCursor.Location = New System.Drawing.Point(645, 500)
        oCursor.Name = "oCursor"
        oCursor.Size = New System.Drawing.Size(1, 10)
        oCursor.TabIndex = 0

        GdViewer1.Controls.Add(oCursor)
        oCursor.Visible = False
        bCursorEnabled = False


        GdViewer1.ZoomMode = ViewerZoomMode.ZoomMode100
        ImageID = oGdPictureImaging.CreateNewGdPictureImage(800, 500, 32, Color.White)
        GdViewer1.DisplayFromGdPictureImage(ImageID)
        GdViewer1.Cursor = Cursors.IBeam
        GdViewer1.KeepDocumentPosition = True
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeDefault
        sFontName = "Arial"
    End Sub


    Private Sub btZoomIN_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btZoomIN.Click
        GdViewer1.ZoomIN()
    End Sub


    Private Sub btZoomOUT_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btZoomOUT.Click
        GdViewer1.ZoomOUT()
    End Sub


    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        oGdPictureImaging.ReleaseGdPictureImage(ImageID)
    End Sub


    Private Sub BurnText(ByVal sText As String, ByVal bBurnPosIndicator As Boolean)
        If nClonedImageID <> 0 Then oGdPictureImaging.ReleaseGdPictureImage(nClonedImageID)
        nClonedImageID = oGdPictureImaging.CreateClonedGdPictureImage(ImageID)

        If bBurnPosIndicator Then sText = sText & POS_INDICATOR
        Call oGdPictureImaging.DrawText(nClonedImageID, sText, nStartPosX, nStartPosY, CInt(txtFontSize.Text), FontStyle, Color.Black, sFontName, True)

        GdViewer1.DisplayFromGdPictureImage(nClonedImageID)
    End Sub


    Private Sub MoveCursor()
        Dim nCursorX, nCursorY As Integer
        Dim nTextWidth, nTextHeight As Single
        Dim sCurrentLineOfText As String
        Dim nCurrentLineOfTextPos As Integer
        Dim nLineHeight As Single

        nCurrentLineOfTextPos = InStrRev(sText, Chr(10) & Chr(13))
        If nCurrentLineOfTextPos > 0 Then
            sCurrentLineOfText = Mid(sText, nCurrentLineOfTextPos + 2)
        Else
            sCurrentLineOfText = sText
        End If

        nTextWidth = oGdPictureImaging.GetTextWidth(ImageID, sCurrentLineOfText, sFontName, CInt(txtFontSize.Text), FontStyle)
        nTextHeight = oGdPictureImaging.GetTextHeight(ImageID, sText & POS_INDICATOR, sFontName, CInt(txtFontSize.Text), FontStyle)
        nLineHeight = oGdPictureImaging.GetTextHeight(ImageID, sCurrentLineOfText & POS_INDICATOR, sFontName, CInt(txtFontSize.Text), FontStyle)

        Call GdViewer1.CoordDocumentToViewer(CInt(nStartPosX + nTextWidth), nStartPosY, nCursorX, nCursorY)
        oCursor.Left = nCursorX
        oCursor.Top = CInt(nCursorY + ((nTextHeight - nLineHeight) * GdViewer1.Zoom))
        oCursor.Height = CInt(nLineHeight * GdViewer1.Zoom)
    End Sub


    Private Sub SaveState()
        Call BurnText(sText, False)
        oCursor.Visible = False
        bCursorEnabled = False
        sText = ""
        If nClonedImageID <> 0 Then
            oGdPictureImaging.ReleaseGdPictureImage(ImageID)
            ImageID = nClonedImageID
            nClonedImageID = 0
            GdViewer1.DisplayFromGdPictureImage(ImageID)
        End If
    End Sub


    Private Sub gdviewer1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GdViewer1.Leave
        SaveState()
    End Sub


    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        If bCursorEnabled Then
            oCursor.Visible = Not oCursor.Visible
        End If
    End Sub


    Private Sub GdViewer1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GdViewer1.KeyPress
        If bCursorEnabled Then

            If Asc(e.KeyChar) <> 9 Then 'Exclude TAB
                Select Case Asc(e.KeyChar)
                    Case 8
                        If Len(sText) > 0 Then
                            If Mid(sText, Len(sText)) = Chr(13) Then
                                If Len(sText) - 3 > 0 Then
                                    sText = Mid(sText, 1, Len(sText) - 3)
                                Else
                                    sText = ""
                                End If
                            Else
                                sText = Mid(sText, 1, Len(sText) - 1)
                            End If
                        End If
                    Case 13
                        sText = sText & Chr(10) & Chr(13)
                    Case Else
                        sText = sText & e.KeyChar
                End Select
                Call BurnText(sText, True)
            End If
        End If
    End Sub


    Private Sub GdViewer1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseDown
        SaveState()

        FontStyle = FontStyle.Regular
        If chkBold.CheckState = 1 Then FontStyle = FontStyle Or FontStyle.Bold
        If chkItalic.CheckState = 1 Then FontStyle = FontStyle Or FontStyle.Italic
        If chkUnderlined.CheckState = 1 Then FontStyle = FontStyle Or FontStyle.Underline

        Call GdViewer1.CoordViewerToDocument(e.X, e.Y, nStartPosX, nStartPosY)

        If nStartPosX >= 0 And nStartPosY >= 0 And nStartPosX < oGdPictureImaging.GetWidth(ImageID) And nStartPosY < oGdPictureImaging.GetHeight(ImageID) Then
            bCursorEnabled = True
            Call BurnText("", True)
            Call MoveCursor()
        End If
    End Sub


    Private Sub GdViewer1_PageDisplayed() Handles GdViewer1.PageDisplayed
        MoveCursor()
    End Sub
End Class