Option Strict On
Option Explicit On

Imports GdPicture14
Imports System.IO

Public Class frmMain

    Friend Function getNativeImage() As Integer
        Return m_ImageID
    End Function

    Private Enum OpenMode
        OpenModeUnknown = 0
        OpenModeFile = 1
        OpenModeFolder = 2
    End Enum

    Private Enum MouseMode
        MouseModeDefault = 0
        MouseModeWindowLeveling = 1
    End Enum

    Private m_GdPictureImaging As New GdPictureImaging
    Private m_ImageID As Integer
    Private m_openMode As OpenMode = OpenMode.OpenModeUnknown
    Private m_mouseMode As MouseMode = MouseMode.MouseModeWindowLeveling

    Private m_ww As Integer 'Current windows width
    Private m_wl As Integer 'Current windows level

    Private m_animating As Boolean
    Private WithEvents m_timer As New Timer
    Private m_stopwatch As New Stopwatch()
    Private m_TickCount As Long
    Private m_ImagesCount As Integer

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
        SplitContainer1.SplitterDistance = 620
        'If you need to set a different animation speed, this is the value you want to change (in milliseconds)
        'm_timer.Interval = 1000
    End Sub


    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        CloseDocument()

        Dim fdl As New OpenFileDialog()
        fdl.Filter = "DICOM files (*.dcm)|*.dcm|All files (*.*)|*.*"
        If fdl.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim filePath As String = fdl.FileName
            If GdPictureDocumentUtilities.GetDocumentFormatFromFileName(filePath) = GdPicture14.DocumentFormat.DocumentFormatDICOM Then
                m_ImageID = m_GdPictureImaging.CreateGdPictureImageFromFile(filePath)
                If m_ImageID <> 0 Then
                    m_ImagesCount = Math.Max(m_GdPictureImaging.DicomGetPageCount(m_ImageID), 1)
                    m_openMode = OpenMode.OpenModeFile
                    GdViewer1.DisplayFromGdPictureImage(m_ImageID)
                    ThumbnailEx1.LoadFromGdPictureImage(m_ImageID)
                    GdViewer1.Focus()
                Else
                    MessageBox.Show("Unable to open the selected DICOM file, the error is: " + m_GdPictureImaging.GetStat().ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Else
                MessageBox.Show("The selected file was not recognized as a DICOM file", "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub


    Private Sub OpenDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDirectoryToolStripMenuItem.Click
        CloseDocument()

        Dim fdl As New FolderBrowserDialog
        If fdl.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim folderPath As String = fdl.SelectedPath
            Dim inputFiles As New List(Of String)
            Dim fifs As FileInfo() = New DirectoryInfo(folderPath).GetFiles()

            'list the names of all files in the specified directory
            For Each fif As IO.FileInfo In fifs
                Dim currentFile As String = fif.FullName
                If GdPictureDocumentUtilities.GetDocumentFormatFromFileName(currentFile) = GdPicture14.DocumentFormat.DocumentFormatDICOM Then
                    inputFiles.Add(currentFile)
                End If
            Next

            If inputFiles.Count > 0 Then
                m_ImagesCount = inputFiles.Count
                m_openMode = OpenMode.OpenModeFolder
                ThumbnailEx1.LoadFromFiles(inputFiles.ToArray())
                ThumbnailEx1.SelectItem(0)
                GdViewer1.Focus()
            Else
                MessageBox.Show("The selected folder does not includes any recognized DICOM file", "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        End If
    End Sub


    Private Sub ThumbnailEx1_ItemSelectionChanged(ByVal Idx As Integer, ByVal Selected As Boolean) Handles ThumbnailEx1.ItemSelectionChanged
        If Selected Then
            Select Case m_openMode
                Case OpenMode.OpenModeFile
                    m_GdPictureImaging.DicomSelectPage(m_ImageID, Idx + 1)

                    If m_mouseMode = MouseMode.MouseModeWindowLeveling Then
                        If m_ww <> 0 And (m_ww <> m_GdPictureImaging.DicomGetDefaultWindowWidth(m_ImageID) Or m_wl <> m_GdPictureImaging.DicomGetDefaultWindowLevel(m_ImageID)) Then
                            m_GdPictureImaging.DicomSetWindowLevel(m_ImageID, m_ww, m_wl)
                        End If
                    End If

                    GdViewer1.Redraw()
                Case OpenMode.OpenModeFolder
                    Dim srcPath As String = ThumbnailEx1.GetItemFileSource(Idx)
                    GdViewer1.CloseDocument()
                    m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID)
                    m_ImageID = m_GdPictureImaging.CreateGdPictureImageFromFile(srcPath)
                    If m_ImageID <> 0 Then
                        If m_mouseMode = MouseMode.MouseModeWindowLeveling Then
                            If m_ww <> 0 And (m_ww <> m_GdPictureImaging.DicomGetDefaultWindowWidth(m_ImageID) Or m_wl <> m_GdPictureImaging.DicomGetDefaultWindowLevel(m_ImageID)) Then
                                m_GdPictureImaging.DicomSetWindowLevel(m_ImageID, m_ww, m_wl)
                            End If
                        End If
                        GdViewer1.DisplayFromGdPictureImage(m_ImageID)
                    Else
                        'todo: handle error
                    End If
            End Select
        End If
    End Sub


    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        CloseDocument()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub GotoFirstPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoFirstPageToolStripMenuItem.Click
        ThumbnailEx1.SelectItem(0)
    End Sub


    Private Function getSelectedItemIdx() As Integer
        For i As Integer = 0 To ThumbnailEx1.ItemCount - 1
            If ThumbnailEx1.GetItemSelectState(i) Then
                Return i
            End If
        Next

        Return -1
    End Function

    Private Sub displayFrame(ByVal frame As Integer)
        ThumbnailEx1.SelectItem(frame - 1)
    End Sub

    Private Sub displayNext()
        If m_ImagesCount > 1 Then
            Dim selectedIdx As Integer = getSelectedItemIdx()
            If selectedIdx + 1 < m_ImagesCount Then
                ThumbnailEx1.SelectItem(selectedIdx + 1)
            Else
                displayFrame(1)
            End If
        End If
    End Sub


    Private Sub displayPrevious()
        If m_ImagesCount > 1 Then
            ThumbnailEx1.SelectItem(getSelectedItemIdx() - 1)
        End If
    End Sub


    Private Sub GotoPreviousPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoPreviousPageToolStripMenuItem.Click
        ThumbnailEx1.SelectItem(getSelectedItemIdx() - 1)
    End Sub


    Private Sub GotoNextPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoNextPageToolStripMenuItem.Click
        ThumbnailEx1.SelectItem(getSelectedItemIdx() + 1)
    End Sub


    Private Sub GotoLastPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoLastPageToolStripMenuItem.Click
        ThumbnailEx1.SelectItem(ThumbnailEx1.ItemCount - 1)
    End Sub


    Private Sub Rotate90ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rotate90ToolStripMenuItem.Click
        GdViewer1.Rotate(RotateFlipType.Rotate90FlipNone)
    End Sub


    Private Sub Rotate180ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rotate180ToolStripMenuItem.Click
        GdViewer1.Rotate(RotateFlipType.Rotate180FlipNone)
    End Sub


    Private Sub Rotate270ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rotate270ToolStripMenuItem.Click
        GdViewer1.Rotate(RotateFlipType.Rotate270FlipNone)
    End Sub


    Private Sub FlipXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlipXToolStripMenuItem.Click
        GdViewer1.Rotate(RotateFlipType.RotateNoneFlipX)
    End Sub


    Private Sub CloseDocument()
        m_ww = 0
        m_wl = 0
        GdViewer1.CloseDocument()
        ThumbnailEx1.ClearAllItems()
        m_openMode = OpenMode.OpenModeUnknown
        Me.StatusStrip1.Text = ""
        If m_ImageID <> 0 Then
            m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID)
            m_ImageID = 0
        End If
        m_ImagesCount = 0
    End Sub


    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        GdViewer1.PrintSetDocumentName("GdPicture Document Viewer Printing")
        GdViewer1.PrintSetAutoRotation(True)
        GdViewer1.PrintDialog(Me)
    End Sub


    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuProperties.Click
        Dim oForm As New frmProperties
        oForm.Show(Me)
    End Sub


    Private Sub Small64X64ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Small64X64ToolStripMenuItem.Click
        ThumbnailEx1.ThumbnailSize = New Size(64, 64)
        Small64X64ToolStripMenuItem.Checked = True
        Medium128X128ToolStripMenuItem.Checked = False
        Large256256ToolStripMenuItem.Checked = False
    End Sub


    Private Sub Medium128X128ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Medium128X128ToolStripMenuItem.Click
        ThumbnailEx1.ThumbnailSize = New Size(128, 128)
        Small64X64ToolStripMenuItem.Checked = False
        Medium128X128ToolStripMenuItem.Checked = True
        Large256256ToolStripMenuItem.Checked = False
    End Sub


    Private Sub Large256256ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Large256256ToolStripMenuItem.Click
        ThumbnailEx1.ThumbnailSize = New Size(256, 256)
        Small64X64ToolStripMenuItem.Checked = False
        Medium128X128ToolStripMenuItem.Checked = False
        Large256256ToolStripMenuItem.Checked = True
    End Sub


    Private Sub GdViewer1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If m_mouseMode = MouseMode.MouseModeWindowLeveling Then

                Dim mouseX As Integer = Math.Max(0, Math.Min(e.X, GdViewer1.Width))
                Dim mouseY As Integer = Math.Max(0, Math.Min(e.Y, GdViewer1.Height))

                Dim newWW As Integer = Math.Max(CInt(m_GdPictureImaging.DicomGetMaxWindowWidth(m_ImageID) / GdViewer1.Width * mouseX), 1)
                Dim wlRange As Single = m_GdPictureImaging.DicomGetMaxWindowLevel(m_ImageID) - m_GdPictureImaging.DicomGetMinWindowLevel(m_ImageID)
                Dim newWL As Integer = CInt(m_GdPictureImaging.DicomGetMinWindowLevel(m_ImageID) + ((wlRange / GdViewer1.Height) * mouseY))
                If newWW <> m_ww Or newWL <> m_wl Then
                    m_ww = newWW
                    m_wl = newWL
                    If m_openMode = OpenMode.OpenModeFile Then
                        'trick: the thumbnail control can change the current used page no
                        m_GdPictureImaging.DicomSelectPage(m_ImageID, getSelectedItemIdx() + 1)
                    End If
                    If m_GdPictureImaging.DicomSetWindowLevel(m_ImageID, m_ww, m_wl) = GdPictureStatus.OK Then
                        GdViewer1.Redraw()
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub GdViewer1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer1.MouseWheel
        If e.Delta < 0 Then
            displayNext()
        Else
            displayPrevious()
        End If
    End Sub


    Private Sub GdViewer1_PageDisplayed() Handles GdViewer1.PageDisplayed
        'GdViewer1.Graphics.DrawString(Trim(Str(GdViewer1.CurrentPage)) & " / " & Trim(Str(GdViewer1.PageCount)), New Font("Arial", 20, Drawing.FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Red, GdViewer1.Width - 100, 10)
        Dim WidthInches, HeightInches As Double

        If GdViewer1.GetDocumentType = DocumentType.DocumentTypePDF Then
            WidthInches = GdViewer1.PdfGetPageWidth / 72
            HeightInches = GdViewer1.PdfGetPageHeight / 72
        Else
            WidthInches = GdViewer1.PageWidth / GdViewer1.HorizontalResolution
            HeightInches = GdViewer1.PageHeight / GdViewer1.VerticalResolution
        End If

        Me.ToolStripStatusLabel1.Text = "Frame No : " + Trim(Str(GdViewer1.CurrentPage)) & " / " & Trim(Str(GdViewer1.PageCount)) + "   -   " +
                               "Zoom : " + Trim(Str(Math.Round(GdViewer1.Zoom * 100, 2))) & "%    -   " +
                               "Image Size (pixels) : " + Trim(Str(GdViewer1.PageWidth)) + " * " + Trim(Str(GdViewer1.PageHeight)) + "   -   " +
                               "Output Pixel Format : " + m_GdPictureImaging.GetPixelFormat(m_ImageID).ToString()
    End Sub


    Private Sub FlipYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlipYToolStripMenuItem.Click
        GdViewer1.Rotate(RotateFlipType.RotateNoneFlipY)
    End Sub


    Private Sub GdViewer1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GdViewer1.Paint
        If m_ImageID <> 0 Then
            If m_mouseMode = MouseMode.MouseModeDefault Or m_ww = 0 Then
                m_ww = CInt(m_GdPictureImaging.DicomGetDefaultWindowWidth(m_ImageID))
                m_wl = CInt(m_GdPictureImaging.DicomGetDefaultWindowLevel(m_ImageID))
            End If

            Using f As New Font("Times New Roman", 20, Drawing.FontStyle.Bold, GraphicsUnit.Pixel)
                Using sf As New StringFormat
                    sf.Alignment = StringAlignment.Far
                    e.Graphics.DrawString("WL: " + m_wl.ToString() + " / WW: " + m_ww.ToString(), f, Brushes.Red, New RectangleF(0, 0, GdViewer1.Width - 10, 50), sf)
                End Using

            End Using
        End If
    End Sub


    Private Sub RestoreDefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreDefaultToolStripMenuItem.Click
        m_ww = CInt(m_GdPictureImaging.DicomGetDefaultWindowWidth(m_ImageID))
        m_wl = CInt(m_GdPictureImaging.DicomGetDefaultWindowLevel(m_ImageID))
        If m_GdPictureImaging.DicomSetWindowLevel(m_ImageID, m_ww, m_wl) = GdPictureStatus.OK Then
            GdViewer1.Redraw()
        End If
    End Sub


    Private Sub EnableWindowLevelingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableWindowLevelingToolStripMenuItem.Click
        EnableWindowLevelingToolStripMenuItem.Checked = Not EnableWindowLevelingToolStripMenuItem.Checked
        If EnableWindowLevelingToolStripMenuItem.Checked Then
            m_mouseMode = MouseMode.MouseModeWindowLeveling
        Else
            m_mouseMode = MouseMode.MouseModeDefault
        End If
    End Sub

    Private Sub AnimateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimateToolStripMenuItem.Click
        If m_animating Then
            endAnimation()
        Else
            startAnimation()
        End If
    End Sub

    Private Sub startAnimation()
        If Not m_animating AndAlso m_ImageID <> 0 Then
            GdViewer1.DisplayQuality = DisplayQuality.DisplayQualityLow
            resetFPS()
            m_TickCount = 0
            m_timer.Start()
            m_animating = True
        End If
    End Sub

    Private Sub endAnimation()
        If m_animating Then
            m_timer.[Stop]()
            m_animating = False
            GdViewer1.DisplayQuality = DisplayQuality.DisplayQualityBicubicHQ
        End If
    End Sub

    Private Sub resetFPS()
        m_TickCount = 0
        m_stopwatch.[Stop]()
        m_stopwatch.Start()
    End Sub

    Private Sub TimerEventProcessor(ByVal sender As Object, ByVal e As EventArgs) Handles m_timer.Tick
        displayNext()
        m_TickCount += 1
    End Sub

End Class