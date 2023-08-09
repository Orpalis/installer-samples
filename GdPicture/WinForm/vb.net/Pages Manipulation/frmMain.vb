Option Strict On
Option Explicit On

Imports GdPicture14
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Text

Public Class frmMain

    Private Enum ZoomMode
        Zoom50
        Zoom100
        Zoom150
        Zoom200
        ZoomSelectedArea
        ZoomFitToViewer
        ZoomFitWidth
        ZoomFitHeight
    End Enum

    Private _currentSearchOccurence As Integer = 0
    Private _toggleGamma As Boolean = True

    Private ReadOnly _gdPictureImaging As New GdPictureImaging
    Private _documentFormat As GdPicture14.DocumentFormat
    Private _currentImage As Integer
    Private ReadOnly _currentPdf As GdPicturePDF = New GdPicturePDF

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim oLicenceManager As New GdPicture14.LicenseManager()
        oLicenceManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.

        BookmarksTree1.GdViewer = GdViewer1

        tcLeftPanel.Appearance = TabAppearance.FlatButtons
        tcLeftPanel.ItemSize = New Size(0, 1)
        tcLeftPanel.SizeMode = TabSizeMode.Fixed
        SelectSnapIn(0, "Thumbnails")

        Dim zoomModes As New Dictionary(Of ZoomMode, String) From {
            {ZoomMode.Zoom50, "50%"},
            {ZoomMode.Zoom100, "100%"},
            {ZoomMode.Zoom150, "150%"},
            {ZoomMode.Zoom200, "200%"},
            {ZoomMode.ZoomSelectedArea, "Zoom to selected area"},
            {ZoomMode.ZoomFitToViewer, "Fit to viewer"},
            {ZoomMode.ZoomFitWidth, "Fit to viewer width"},
            {ZoomMode.ZoomFitHeight, "Fit to viewer height"}
        }
        For Each item In zoomModes
            cbZoom.Items.Add(item.Value)
        Next

        rbAllPages.Checked = True
        Dim imageListSearchResults As New ImageList
        imageListSearchResults.ImageSize = New Size(20, 20)
        imageListSearchResults.Images.Add(CType(My.Resources.ResourceManager.GetObject("search_result"), Image))
        lstSearchResults.LargeImageList = imageListSearchResults
        lstSearchResults.Groups.Add(New ListViewGroup("SearchResult", "Search result"))

        pGamma.Visible = False
        tbGamma.Value = CInt(GdViewer1.Gamma * 10)
        lblGamma.Text = "Current gamma: " & CStr(GdViewer1.Gamma) & " (default: 1)"

        ResetSearch()
        UpdateMainUi()
    End Sub

    Private Sub UpdateMainUi()
        Me.Text = "GdPicture.NET " & GetType(GdPictureImaging).Assembly.GetName().Version.ToString() & " - Page Manipulation Demo"
        If GdViewer1.PageCount = 0 Then
            btnClose.Enabled = False
            btnPrint.Enabled = False
            btnSave.Enabled = False
            btnFirstPage.Enabled = False
            btnPreviousPage.Enabled = False
            tbCurrentPage.Enabled = False
            lblPageCount.Enabled = False
            btnNextPage.Enabled = False
            btnLastPage.Enabled = False
            btnZoomOut.Enabled = False
            cbZoom.Enabled = False
            btnZoomIn.Enabled = False
            btnFitPage.Enabled = False
            btnFitWidth.Enabled = False
            btnAdjustGamma.Enabled = False
            btnRotateLeft.Enabled = False
            btnRotateRight.Enabled = False
            btnFlipX.Enabled = False
            btnFlipY.Enabled = False
            tbCurrentPage.Text = "0"
            lblPageCount.Text = "/ 0"
            cbZoom.SelectedIndex = -1
            tbSearch.Text = ""
            pSearch.Enabled = False
            btnDeleteCurrentPage.Enabled = False
        Else
            btnClose.Enabled = True
            btnPrint.Enabled = True
            btnSave.Enabled = True
            btnFirstPage.Enabled = True
            btnPreviousPage.Enabled = True
            tbCurrentPage.Enabled = True
            lblPageCount.Enabled = True
            btnNextPage.Enabled = True
            btnLastPage.Enabled = True
            btnZoomOut.Enabled = True
            cbZoom.Enabled = True
            btnZoomIn.Enabled = True
            btnFitPage.Enabled = True
            btnFitWidth.Enabled = True
            btnAdjustGamma.Enabled = True
            btnRotateLeft.Enabled = True
            btnRotateRight.Enabled = True
            btnFlipX.Enabled = True
            btnFlipY.Enabled = True
            btnDeleteCurrentPage.Enabled = True
            UpdateaNavigationToolbar()
            pSearch.Enabled = True
        End If
        ResetSearch()
    End Sub

    Private Sub UpdateaNavigationToolbar()
        Dim currentPage As Integer = GdViewer1.CurrentPage()
        tbCurrentPage.Text = currentPage.ToString()
        lblPageCount.Text = "/ " & GdViewer1.PageCount.ToString()
        If currentPage = 1 Then
            btnFirstPage.Enabled = False
            btnPreviousPage.Enabled = False
        Else
            btnFirstPage.Enabled = True
            btnPreviousPage.Enabled = True
        End If
        If currentPage = GdViewer1.PageCount Then
            btnNextPage.Enabled = False
            btnLastPage.Enabled = False
        Else
            btnNextPage.Enabled = True
            btnLastPage.Enabled = True
        End If
        cbZoom.Text = String.Format(CultureInfo.InvariantCulture, "{0:#0.##%}", GdViewer1.Zoom)

        Dim widthInches, heightInches As Double

        If GdViewer1.GetDocumentType = DocumentType.DocumentTypePDF Then
            widthInches = GdViewer1.PdfGetPageWidth / 72
            heightInches = GdViewer1.PdfGetPageHeight / 72
        Else
            widthInches = GdViewer1.PageWidth / GdViewer1.HorizontalResolution
            heightInches = GdViewer1.PageHeight / GdViewer1.VerticalResolution
        End If

        Me.ToolStripStatusLabel1.Text = "Type: " + GetDocumentTypeLabel() + "  -  " + _
                                        "Page Size (inches): " + Trim(Str(Math.Round(widthInches, 2))) + " × " + Trim(Str(Math.Round(heightInches, 2))) + "  -  " + _
                                        "Page Size (pixels): " + Trim(Str(GdViewer1.PageWidth)) + " × " + Trim(Str(GdViewer1.PageHeight)) + "  -  " + _
                                        "Horizontal resolution: " + Trim(Str(Math.Round(GdViewer1.HorizontalResolution, 2))) + " DPI  -  " + _
                                        "Vertical resolution: " + Trim(Str(Math.Round(GdViewer1.VerticalResolution, 2))) + " DPI"
    End Sub

    Private Function GetDocumentTypeLabel() As String
        Dim result As String = ""
        Select Case GdViewer1.GetDocumentType()
            Case DocumentType.DocumentTypeBitmap
                result = "Image"
            Case DocumentType.DocumentTypeMetaFile
                result = "Metafile"
            Case DocumentType.DocumentTypePDF
                result = "PDF"
            Case DocumentType.DocumentTypeSVG
                result = "SVG"
            Case DocumentType.DocumentTypeTXT
                result = "Text file"
            Case DocumentType.DocumentTypeUnknown
                result = "Unknown"
        End Select
        Return result
    End Function

    Private Sub CloseDocument()
        GdViewer1.CloseDocument()
        ThumbnailEx1.ClearAllItems()
        UpdateMainUi()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOpen.Click
        CloseDocument()

        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer
        GdViewer1.DocumentAlignment = ViewerDocumentAlignment.DocumentAlignmentTopCenter
        Dim openOk As Boolean = False
        Using openFd As OpenFileDialog = New OpenFileDialog()
            openFd.Filter = "PDF|*.pdf|TIFF Image|*.tif"
            If openFd.ShowDialog(Me) = DialogResult.OK Then
                Dim filePath As String = openFd.FileName
                Dim docFormat As GdPicture14.DocumentFormat = GdPictureDocumentUtilities.GetDocumentFormat(filePath)
                If docFormat = GdPicture14.DocumentFormat.DocumentFormatPDF Then
                    'We use the GdPicturePDF class to handle the document
                    If _currentPdf.LoadFromFile(filePath, False) = GdPictureStatus.OK Then
                        _documentFormat = GdPicture14.DocumentFormat.DocumentFormatPDF
                        GdViewer1.DisplayFromGdPicturePDF(_currentPdf)
                        openOk = True
                    End If

                Else
                    'We use the GdPictureImaging class to handle the document as an editable multipage tiff image
                    _currentImage = _gdPictureImaging.TiffCreateMultiPageFromFile(filePath)
                    If _currentImage <> 0 Then
                        _documentFormat = GdPicture14.DocumentFormat.DocumentFormatTIFF
                        GdViewer1.DisplayFromGdPictureImage(_currentImage)
                        openOk = True
                    End If
                End If
            End If
        End Using
        If openOk Then
            GdViewer1.Focus()
            ThumbnailEx1.LoadFromGdViewer(GdViewer1)
        End If
        UpdateMainUi()
    End Sub

    Private Sub btnFirstPage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFirstPage.Click
        GdViewer1.DisplayFirstPage()
    End Sub

    Private Sub btnPreviousPage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPreviousPage.Click
        GdViewer1.DisplayPreviousPage()
    End Sub

    Private Sub btnNextPage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNextPage.Click
        GdViewer1.DisplayNextPage()
    End Sub

    Private Sub btnLastPage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnLastPage.Click
        GdViewer1.DisplayLastPage()
    End Sub

    Private Sub tbCurrentPage_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbCurrentPage.Leave
        Dim page As Integer = 0
        If Integer.TryParse(tbCurrentPage.Text, page) Then
            If page > 0 And page <= GdViewer1.PageCount Then
                GdViewer1.DisplayPage(page)
                UpdateaNavigationToolbar()
            End If
        End If
    End Sub

    Private Sub GdViewer1_PageChanged() Handles GdViewer1.PageChanged
        UpdateaNavigationToolbar()
    End Sub

    Private Sub ChangeZoomValue()
        If cbZoom.SelectedIndex <> -1 Then
            Select Case CType(cbZoom.SelectedIndex, ZoomMode)
                Case ZoomMode.Zoom50
                    GdViewer1.Zoom = 50.0F / 100
                Case ZoomMode.Zoom100
                    GdViewer1.Zoom = 100.0F / 100
                Case ZoomMode.Zoom150
                    GdViewer1.Zoom = 150.0F / 100
                Case ZoomMode.Zoom200
                    GdViewer1.Zoom = 250.0F / 100
                Case ZoomMode.ZoomSelectedArea
                    If GdViewer1.IsRect() Then
                        GdViewer1.ZoomRect()
                    Else
                        GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection
                        GdViewer1.Focus()
                    End If
                Case ZoomMode.ZoomFitToViewer
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
                Case ZoomMode.ZoomFitWidth
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer
                Case ZoomMode.ZoomFitHeight
                    GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeHeightViewer
            End Select
        Else
            If (IsNumeric(Regex.Replace(cbZoom.Text, "[^0-9,.]", ""))) Then
                GdViewer1.Zoom = Val(Regex.Replace(cbZoom.Text, "[^0-9,.]", "")) / 100
            End If
        End If
        UpdateaNavigationToolbar()
    End Sub

    Private Sub cbZoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbZoom.SelectedIndexChanged
        ChangeZoomValue()
    End Sub

    Private Sub GdViewer1_AfterZoomChange() Handles GdViewer1.AfterZoomChange
        UpdateaNavigationToolbar()
        If GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming Then
            GdViewer1.MouseMode = ViewerMouseMode.MouseModePan
        End If
    End Sub

    Private Sub btnZoomOut_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnZoomOut.Click
        GdViewer1.ZoomOUT()
    End Sub

    Private Sub btnZoomIn_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnZoomIn.Click
        GdViewer1.ZoomIN()
    End Sub

    Private Sub cbZoom_TextUpdate(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbZoom.Validating
        ChangeZoomValue()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAbout.Click
        Using frmAbout As New frmAbout()
            frmAbout.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPrint.Click
        If GdViewer1.PageCount = 0 Then
            Return
        End If
        Using f As New frmPrint(GdViewer1)
            f.ShowDialog(Me)
            If f.DialogResult <> DialogResult.OK Then
                Return
            End If
            Dim printSettings As frmPrint.PrintSettings = f.printConfiguration
            If Not GdViewer1.PrintSetActivePrinter(printSettings.Printer) Then
                Return
            End If
            GdViewer1.PrintSetDocumentName("GdPicture Print Job " + DateTime.Now.ToString("yyyy-MM-dd HH\mm"))
            GdViewer1.PrintSetAlignment(printSettings.PrintAlignment)
            Select Case printSettings.Orientation
                Case frmPrint.PrintOrientation.AutoDetection
                    GdViewer1.PrintSetAutoRotation(True)
                    Exit Select
                Case frmPrint.PrintOrientation.Portrait
                    GdViewer1.PrintSetAutoRotation(False)
                    GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationPortrait)
                    Exit Select
                Case frmPrint.PrintOrientation.Paysage
                    GdViewer1.PrintSetAutoRotation(False)
                    GdViewer1.PrintSetOrientation(PrinterOrientation.PrinterOrientationLandscape)
                    Exit Select
            End Select
            GdViewer1.PrintSetCopies(printSettings.Copies)
            If printSettings.Copies > 1 Then
                GdViewer1.PrintSetCollate(printSettings.Collate)
            End If
            Select Case printSettings.PagesToPrint
                Case frmPrint.PagesToPrint.All
                    GdViewer1.PrintSetFromToPage(1, GdViewer1.PageCount)
                    GdViewer1.Print(printSettings.PrintSize)
                    Exit Select
                Case frmPrint.PagesToPrint.Current
                    GdViewer1.PrintSetFromToPage(GdViewer1.CurrentPage, GdViewer1.CurrentPage)
                    GdViewer1.Print(printSettings.PrintSize)
                    Exit Select
                Case frmPrint.PagesToPrint.Selection
                    Dim range As String = GetSelectedItemAsRange()
                    If Not String.IsNullOrWhiteSpace(range) Then
                        GdViewer1.PrintSetPageSelection(range)
                        GdViewer1.Print(printSettings.PrintSize)
                    End If
                    Exit Select
                Case frmPrint.PagesToPrint.Range
                    If printSettings.PageRange IsNot Nothing And printSettings.PageRange <> String.Empty Then
                        If printSettings.PageRange.Contains("-") Then
                            Dim pageStart As Integer = 0
                            If Integer.TryParse(printSettings.PageRange.Split("-"c)(0), pageStart) Then
                                Dim pageEnd As Integer = 0
                                If Integer.TryParse(printSettings.PageRange.Split("-"c)(1), pageEnd) Then
                                    If pageEnd < pageStart Then
                                        GdViewer1.PrintSetFromToPage(pageEnd, pageStart)
                                        GdViewer1.Print(printSettings.PrintSize)
                                    Else
                                        GdViewer1.PrintSetFromToPage(pageStart, pageEnd)
                                        GdViewer1.Print(printSettings.PrintSize)
                                    End If
                                Else
                                    MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                                End If
                            Else
                                MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                            End If
                        Else
                            Dim page As Integer = 0
                            If Integer.TryParse(printSettings.PageRange, page) Then
                                GdViewer1.PrintSetFromToPage(page, page)
                                GdViewer1.Print(printSettings.PrintSize)
                            Else
                                MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                            End If
                        End If
                    Else
                        MessageBox.Show("Page range is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End If
                    Exit Select
            End Select
        End Using
    End Sub

    Private Function GetSelectedItemAsRange() As String
        Dim count As Integer = 0
        For i As Integer = 0 To ThumbnailEx1.ItemCount - 1
            If ThumbnailEx1.GetItemCheckState(i) = True Then
                count += 1
            End If
        Next
        If count = 0 Then
            If MessageBox.Show("No page has been selected, do you want to save all pages?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                For i As Integer = 0 To ThumbnailEx1.ItemCount - 1
                    ThumbnailEx1.SetItemCheckState(i, True)
                Next
                count = ThumbnailEx1.ItemCount
            End If
        End If
        If count > 0 Then
            Dim sb As New StringBuilder
            For i As Integer = 0 To ThumbnailEx1.ItemCount
                If ThumbnailEx1.GetItemCheckState(i) = True Then
                    If sb.Length <> 0 Then
                        sb.Append(";")
                    End If
                    sb.Append(i + 1)
                End If
            Next

            Return sb.ToString()
        Else
            Return ""
        End If
    End Function

    Private Sub btnRotateLeft_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRotateLeft.Click
        GdViewer1.RemoveAllRegions()
        If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatPDF Then
            _currentPdf.RotatePage(90)
        Else
            If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatTIFF Then
                _gdPictureImaging.Rotate(_currentImage, RotateFlipType.Rotate270FlipNone)
            End If
        End If
        GdViewer1.Redraw()
        ThumbnailEx1.RedrawItem(GdViewer1.CurrentPage - 1)
    End Sub

    Private Sub btnRotateRight_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRotateRight.Click
        GdViewer1.RemoveAllRegions()
        If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatPDF Then
            _currentPdf.RotatePage(90)
        Else
            If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatTIFF Then
                _gdPictureImaging.Rotate(_currentImage, RotateFlipType.Rotate90FlipNone)
            End If
        End If
        GdViewer1.Redraw()
        ThumbnailEx1.RedrawItem(GdViewer1.CurrentPage - 1)
    End Sub

    Private Sub btnFlipX_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFlipX.Click
        GdViewer1.RemoveAllRegions()
        If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatPDF Then
            _currentPdf.FlipPage(True, False)
        Else
            If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatTIFF Then
                _gdPictureImaging.Rotate(_currentImage, RotateFlipType.RotateNoneFlipX)
            End If
        End If
        GdViewer1.Redraw()
        ThumbnailEx1.RedrawItem(GdViewer1.CurrentPage - 1)
    End Sub

    Private Sub btnFlipY_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFlipY.Click
        GdViewer1.RemoveAllRegions()
        If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatPDF Then
            _currentPdf.FlipPage(False, True)
        Else
            If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatTIFF Then
                _gdPictureImaging.Rotate(_currentImage, RotateFlipType.RotateNoneFlipY)
            End If
        End If
        GdViewer1.Redraw()
        ThumbnailEx1.RedrawItem(GdViewer1.CurrentPage - 1)
    End Sub

    Private Sub GdViewer1_TransferEnded(ByVal status As GdPictureStatus, ByVal download As System.Boolean) Handles GdViewer1.TransferEnded
        GdViewer1.Focus()
        ThumbnailEx1.LoadFromGdViewer(GdViewer1)
        UpdateMainUi()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSearch.Click
        If (GdViewer1.GetDocumentType() <> DocumentType.DocumentTypePDF And GdViewer1.GetDocumentType() <> DocumentType.DocumentTypeTXT) Or String.IsNullOrWhiteSpace(tbSearch.Text) Then
            Return
        End If

        ResetSearch()
        Dim page As Integer
        Dim found As Boolean = False
        If rbAllPages.Checked Then
            page = 1
        Else
            page = GdViewer1.CurrentPage
        End If
        Dim finish As Boolean = False
        Dim countResults As Integer = 0

        Me.Cursor = Cursors.WaitCursor
        searchProgressBar.Value = 1
        searchProgressBar.Maximum = GdViewer1.PageCount
        searchProgressBar.Visible = True

        Dim items As New List(Of ListViewItem)

        While Not finish
            lblSearchResults.Text = "Find results for page " + page.ToString() + " of " + GdViewer1.PageCount.ToString()
            searchProgressBar.Increment(1)
            lblSearchResults.Invalidate()
            lblSearchResults.Update()
            lblSearchResults.Refresh()
            searchProgressBar.Invalidate()
            searchProgressBar.Update()
            searchProgressBar.Refresh()
            Dim count As Integer = GetSearchResultCount(page, tbSearch.Text)
            If count > 0 Then
                found = True
                Dim item As New ListViewItem(New String() {"Page " + page.ToString(), count.ToString() + " occurence(s) found"}, 0)
                item.Name = "Page" + page.ToString()
                item.Tag = page
                item.Group = lstSearchResults.Groups(0)
                items.Add(item)
            End If
            countResults += count
            page = page + 1
            finish = rbCurrentPage.Checked Or page > GdViewer1.PageCount
        End While

        lstSearchResults.Items.AddRange(items.ToArray())

        lstSearchResults.Groups(0).Header = "Search results (" + countResults.ToString() + ")"
        Me.Cursor = Cursors.Default

        lblSearchResults.Text = ""
        searchProgressBar.Visible = False

        If Not found Then
            MessageBox.Show("No match found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function GetSearchResultCount(ByVal page As Integer, ByVal searchedTerm As String) As Integer
        Return GdViewer1.GetTextOccurrenceCount(page, searchedTerm, chkCaseSensitive.Checked, chkWholeWord.Checked)
    End Function

    Private Sub ResetSearch()
        btnFindPrevious.Enabled = Not String.IsNullOrWhiteSpace(tbSearch.Text)
        btnFindNext.Enabled = Not String.IsNullOrWhiteSpace(tbSearch.Text)
        btnSearch.Enabled = Not String.IsNullOrWhiteSpace(tbSearch.Text)
        lstSearchResults.Items.Clear()
        GdViewer1.RemoveAllRegions()
        _currentSearchOccurence = 0
        lblSearchResults.Text = ""
    End Sub

    Private Sub chkWholeWord_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkWholeWord.CheckedChanged
        ResetSearch()
    End Sub

    Private Sub chkCaseSensitive_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkCaseSensitive.CheckedChanged
        ResetSearch()
    End Sub

    Private Sub rbCurrentPage_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCurrentPage.CheckedChanged
        ResetSearch()
    End Sub

    Private Sub rbAllPages_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbAllPages.CheckedChanged
        ResetSearch()
    End Sub

    Private Sub tbSearch_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbSearch.TextChanged
        ResetSearch()
    End Sub

    Private Sub cbZoom_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbZoom.Validating
        ChangeZoomValue()
    End Sub

    Private Sub lstSearchResults_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstSearchResults.SelectedIndexChanged
        If lstSearchResults.SelectedItems.Count <> 0 Then
            GdViewer1.RemoveAllRegions()
            Dim item As ListViewItem = lstSearchResults.SelectedItems(0)
            Dim page As Integer = CType(item.Tag, Integer)
            If GdViewer1.CurrentPage <> page Then
                GdViewer1.DisplayPage(page)
            End If
            Dim occurence As Integer = 1
            Dim occurenceLeft As Single
            Dim occurenceTop As Single
            Dim occurenceWidth As Single
            Dim occurenceHeight As Single
            While GdViewer1.SearchText(page, tbSearch.Text, occurence, chkCaseSensitive.Checked, chkWholeWord.Checked, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight)
                AddSearchRegion(occurence, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight, occurence = 1)
                occurence = occurence + 1
            End While
        End If
    End Sub

    Private Sub btnFindNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindNext.Click
        Search(True)
    End Sub

    Private Sub btnFindPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindPrevious.Click
        Search(False)
    End Sub

    Private Sub AddSearchRegion(ByVal occurence As Integer, ByVal leftCoordinate As Single, ByVal topCoordinate As Single, ByVal regionWidth As Single, ByVal regionheight As Single, ByVal ensureVisibility As Boolean)
        Dim searchRegion As Integer = GdViewer1.AddRegionInches("SearchResult" & occurence, leftCoordinate, topCoordinate, regionWidth, regionheight, ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Yellow)
        GdViewer1.SetRegionEditable(searchRegion, False)
        If ensureVisibility Then
            GdViewer1.EnsureRegionVisibility(searchRegion)
        End If
    End Sub

    Private Function Search(ByVal ascending As Boolean) As Boolean
        Dim go As Boolean = True
        Dim page As Integer = GdViewer1.CurrentPage
        Dim found As Boolean = False
        Dim newOccurence As Integer
        Dim occurenceLeft As Single
        Dim occurenceTop As Single
        Dim occurenceWidth As Single
        Dim occurenceHeight As Single
        If ascending Then
            newOccurence = _currentSearchOccurence + 1
        Else
            newOccurence = _currentSearchOccurence - 1
        End If
        While go
            If GdViewer1.SearchText(page, tbSearch.Text, newOccurence, chkCaseSensitive.Checked, chkWholeWord.Checked, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight) Then
                If page <> GdViewer1.CurrentPage Then
                    GdViewer1.DisplayPage(page)
                End If
                GdViewer1.RemoveAllRegions()
                AddSearchRegion(newOccurence, occurenceLeft, occurenceTop, occurenceWidth, occurenceHeight, True)
                _currentSearchOccurence = newOccurence
                found = True
                go = False
            Else
                If rbAllPages.Checked Then
                    If ascending Then
                        page = page + 1
                        newOccurence = 1
                    Else
                        page = page - 1
                        newOccurence = GetSearchResultCount(page, tbSearch.Text)
                    End If
                    If page = 0 Or page > GdViewer1.PageCount Then
                        go = False
                    End If
                Else
                    go = False
                End If
            End If
        End While
        If Not found Then
            MessageBox.Show(Me, "No match found !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return found
    End Function

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        CloseDocument()
        UpdateMainUi()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSettings.Click
        Using frmSettings As New frmSettings(GdViewer1)
            frmSettings.ShowDialog(Me)
        End Using
        ThumbnailEx1.PdfIncreaseTextContrast = GdViewer1.PdfIncreaseTextContrast
        UpdateaNavigationToolbar()
    End Sub

    Private Sub btnFitWidth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFitWidth.Click
        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeWidthViewer
    End Sub

    Private Sub btnFitPage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFitPage.Click
        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
    End Sub

    Private Sub tbGamma_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbGamma.Scroll
        GdViewer1.Gamma = CSng(tbGamma.Value / 10)
        lblGamma.Text = "Current gamma: " & CStr(GdViewer1.Gamma) & " (default: 1)"
    End Sub

    Private Sub SelectSnapIn(ByVal num As Integer, ByVal title As String)
        tcLeftPanel.SelectedIndex = num
        lblSnapInPanel.Text = title
        For i As Integer = 0 To pSnapInButtons.Controls.Count - 1
            If i = num Then
                pSnapInButtons.Controls(i).BackColor = SystemColors.Control
                CType(pSnapInButtons.Controls(i), Button).FlatAppearance.BorderColor = SystemColors.Control
            Else
                pSnapInButtons.Controls(i).BackColor = SystemColors.AppWorkspace
                CType(pSnapInButtons.Controls(i), Button).FlatAppearance.BorderColor = SystemColors.AppWorkspace
            End If
        Next
    End Sub

    Private Sub btnSnapInThumbnails_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSnapInThumbnails.Click
        SelectSnapIn(0, "Thumbnails")
    End Sub

    Private Sub btnSnapInBookmarks_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSnapInBookmarks.Click
        SelectSnapIn(1, "Bookmarks")
    End Sub

    Private Sub btnSnapInSearch_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSnapInSearch.Click
        SelectSnapIn(2, "Search")
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles DefaultToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeDefault
        DefaultToolStripMenuItem.Checked = True
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub AreaSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AreaSelectionToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = True
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub PanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles PanToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModePan
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = True
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub AreaZoomingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AreaZoomingToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaZooming
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = True
        MagnifierToolStripMenuItem.Checked = False
        GdViewer1.Focus()
    End Sub

    Private Sub MagnifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MagnifierToolStripMenuItem.Click
        GdViewer1.MouseMode = ViewerMouseMode.MouseModeMagnifier
        DefaultToolStripMenuItem.Checked = False
        AreaSelectionToolStripMenuItem.Checked = False
        PanToolStripMenuItem.Checked = False
        AreaZoomingToolStripMenuItem.Checked = False
        MagnifierToolStripMenuItem.Checked = True
        GdViewer1.Focus()
    End Sub

    Private Sub SmallThumbnailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SmallThumbnailsToolStripMenuItem1.Click
        ThumbnailEx1.ThumbnailSize = New Size(64, 64)
        SmallThumbnailsToolStripMenuItem1.Checked = True
        MediumThumbnailsToolStripMenuItem1.Checked = False
        LargeThumbnailsToolStripMenuItem1.Checked = False
    End Sub

    Private Sub MediumThumbnailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MediumThumbnailsToolStripMenuItem1.Click
        ThumbnailEx1.ThumbnailSize = New Size(128, 128)
        SmallThumbnailsToolStripMenuItem1.Checked = False
        MediumThumbnailsToolStripMenuItem1.Checked = True
        LargeThumbnailsToolStripMenuItem1.Checked = False
    End Sub

    Private Sub LargeThumbnailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles LargeThumbnailsToolStripMenuItem1.Click
        ThumbnailEx1.ThumbnailSize = New Size(256, 256)
        SmallThumbnailsToolStripMenuItem1.Checked = False
        MediumThumbnailsToolStripMenuItem1.Checked = False
        LargeThumbnailsToolStripMenuItem1.Checked = True
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAdjustGamma.Click
        pGamma.Visible = _toggleGamma
        _toggleGamma = Not _toggleGamma
    End Sub

    Private Sub ThumbnailEx1_ItemMoved(ByVal srcIdx As Int32, ByVal dstIdx As Int32) Handles ThumbnailEx1.ItemMoved
        If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatPDF Then
            _currentPdf.MovePage(srcIdx + 1, dstIdx + 1)
        Else
            If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatTIFF Then
                _gdPictureImaging.TiffMovePage(_currentImage, srcIdx + 1, dstIdx + 1)
            End If
        End If
    End Sub

    Private Sub btnDeleteCurrentPage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDeleteCurrentPage.Click
        If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatPDF Then
            Dim pageNo As Integer = _currentPdf.GetCurrentPage
            _currentPdf.DeletePage(pageNo)
            ThumbnailEx1.RemoveItem(pageNo - 1)
        Else
            If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatTIFF Then
                Dim pageNo As Integer = _gdPictureImaging.TiffGetCurrentPage(_currentImage)
                _gdPictureImaging.TiffDeletePage(_currentImage, pageNo)
                ThumbnailEx1.RemoveItem(pageNo - 1)
            End If
        End If
        GdViewer1.Redraw()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim saveFileDialog1 As New SaveFileDialog

        If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatPDF Then
            saveFileDialog1.DefaultExt = "pdf"
            saveFileDialog1.Filter = "PDF|*.pdf"
            If saveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                If _currentPdf.SaveToFileInc(saveFileDialog1.FileName) = GdPictureStatus.OK Then
                    MessageBox.Show(Me, "Document succefully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(Me, "Can't save document. Status: " & _currentPdf.GetStat.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If _documentFormat = GdPicture14.DocumentFormat.DocumentFormatTIFF Then
                saveFileDialog1.DefaultExt = "tif"
                saveFileDialog1.Filter = "TIFF Image|*.tif"
                If saveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                    If _gdPictureImaging.TiffSaveMultiPageToFile(_currentImage, saveFileDialog1.FileName, TiffCompression.TiffCompressionAUTO) = GdPictureStatus.OK Then
                        MessageBox.Show(Me, "Document succefully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show(Me, "Can't save document. Status: " & _gdPictureImaging.GetStat.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub
End Class
