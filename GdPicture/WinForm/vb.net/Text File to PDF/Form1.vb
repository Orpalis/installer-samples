Imports GdPicture14

Public Class Form1

    'a structure to hold size of each type of paper
    Structure Paper
        Public _PaperName As String
        Public _paperWidth As Single
        Public _paperHeight As Single
    End Structure

    'init Global variables
    Dim oGdPicturePdf As New GdPicture14.GdPicturePDF
    Dim _posY As Single
    Dim _fontID As String
    Dim _pageWidth As Single = 215.9
    Dim _pageHeight As Single = 279.4
    Dim _textSize As Single = 10
    Dim _leftMargin As Single = 0
    Dim _rightMargin As Single = 0
    Dim _topMargin As Single = 0
    Dim _bottomMargin As Single
    Const _InterlineInMM As Single = 1
    Const _TabLenght As Integer = 8
    Dim _lineHeight As Single
    Dim _avaibleWidth As Single = _pageWidth
    Dim _avaibleHeight As Single = _pageHeight


    Dim Papers As New Collection

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
        'create papers collection
        Dim paper As New Paper
        paper._PaperName = "Letter"
        paper._PaperWidth = 215.9
        paper._paperHeight = 279.4
        Papers.Add(paper, paper._PaperName)
        paper = New Paper
        paper._PaperName = "Legal"
        paper._PaperWidth = 215.9
        paper._paperHeight = 355.6
        Papers.Add(paper, paper._PaperName)
        paper = New Paper
        paper._PaperName = "A3"
        paper._PaperWidth = 297
        paper._paperHeight = 420
        Papers.Add(paper, paper._PaperName)
        paper = New Paper
        paper._PaperName = "A4"
        paper._PaperWidth = 210
        paper._paperHeight = 297
        Papers.Add(paper, paper._PaperName)

        'add papers to cboPapers
        For i As Integer = 1 To Papers.Count
            paper = Papers(i)
            cboPapers.Items.Add(paper._PaperName)
        Next
        paper = Papers(1)
        cboPapers.Text = paper._PaperName

    End Sub


    Private Sub cmdParcInputFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdParcInputFile.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "Text files|*.txt|All files|*.*"
        fileDialog.ShowDialog()
        If fileDialog.FileName = "" Then
            Exit Sub
        End If
        txtInputFile.Text = fileDialog.FileName
    End Sub

    Private Sub cmdParcOutputFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdParcOutputFile.Click
        Dim fileDialog As New SaveFileDialog
        fileDialog.DefaultExt = "pdf"
        fileDialog.Filter = "Pdf files|*.Pdf|All files|*.*"
        fileDialog.ShowDialog()
        If fileDialog.FileName = "" Then
            Exit Sub
        End If
        txtOutputFile.Text = fileDialog.FileName
    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        Dim currentLine As String = ""
        Dim fileContent As String

        If txtInputFile.Text = "" Then
            MessageBox.Show("Set the text file to be converted")
            Exit Sub
        End If
        If txtOutputFile.Text = "" Then
            MessageBox.Show("Set the Pdf filename")
            Exit Sub
        End If
        If System.IO.File.Exists(txtInputFile.Text) = False Then
            MessageBox.Show("The text file does not exist")
            Exit Sub
        End If

        'landscape or portrait mode
        If radLandscape.Checked Then
            _pageWidth = Papers(cboPapers.Text)._paperHeight
            _pageHeight = Papers(cboPapers.Text)._paperWidth
        Else
            _pageWidth = Papers(cboPapers.Text)._paperWidth
            _pageHeight = Papers(cboPapers.Text)._paperHeight
        End If

        'margins of page
        _leftMargin = Single.Parse(txtLeftMargin.Text)
        _rightMargin = Single.Parse(txtRightMargin.Text)
        _topMargin = Single.Parse(txtTopMargin.Text)
        _bottomMargin = Single.Parse(txtBottomMargin.Text)

        'text size
        _textSize = Single.Parse(txtTextSize.Text)

        'calculating width and height of area to draw
        _avaibleWidth = _pageWidth - _leftMargin - _rightMargin
        _avaibleHeight = _pageHeight - _bottomMargin

        If _avaibleHeight < 10 Or _avaibleWidth < 10 Then
            MessageBox.Show("Area too small to write on, please make margins smaller, or pick a larger paper size")
            Exit Sub
        End If

        ProgressBar1.Visible = True

        'read the content of the text file in a string
        fileContent = My.Computer.FileSystem.ReadAllText(txtInputFile.Text, System.Text.Encoding.Default)

        'clear all line feed
        fileContent = fileContent.Replace(vbCrLf, vbCr) 'replace CR+LF to a single CR
        fileContent = fileContent.Replace(vbLf, vbCr)   'replace LF to CR
        'now filecontent as only CR as lines separator


        ProgressBar1.Maximum = fileContent.Length

        'let start a new pdf
        Dim status As GdPictureStatus = oGdPicturePdf.NewPDF()
        If status <> GdPictureStatus.OK Then
            MessageBox.Show("Error creating a new PDF : " + status.ToString())
            Exit Sub
        End If

        'add a font
        _fontID = oGdPicturePdf.AddStandardFont(PdfStandardFont.PdfStandardFontCourier)

        'set coordinates origin and measurement
        oGdPicturePdf.SetOrigin(PdfOrigin.PdfOriginTopLeft)
        oGdPicturePdf.SetMeasurementUnit(PdfMeasurementUnit.PdfMeasurementUnitMillimeter)

        'create the first page
        status = oGdPicturePdf.NewPage(_pageWidth, _pageHeight)
        If status <> GdPictureStatus.OK Then
            MessageBox.Show("Error creating the first page for the pdf : " + status.ToString())
            ProgressBar1.Visible = False
            Exit Sub
        End If

        _lineHeight = oGdPicturePdf.GetTextHeight(_fontID, _textSize) + _InterlineInMM

        oGdPicturePdf.SetTextSize(_textSize)

        _posY = _topMargin + _lineHeight  ' the y position for text is the base line

        ' make an analisys of the fileContent, Word by Word
        Do While fileContent <> ""
            'get word
            Dim singleWord As String = GetsingleWord(fileContent)
            ProgressBar1.Value = ProgressBar1.Maximum - fileContent.Length
            Application.DoEvents()
            If singleWord = vbCr Then
                'we got a carraige return, draw the current line 
                status = DrawText(currentLine)
                If status <> GdPictureStatus.OK Then
                    MessageBox.Show("Error: " + status.ToString())
                    Exit Sub
                End If
            ElseIf singleWord = vbFormFeed Then
                'we got a form feed, draw the current line 
                status = DrawText(currentLine)
                If status <> GdPictureStatus.OK Then
                    MessageBox.Show("Error: " + status.ToString())
                    Exit Sub
                End If
                _posY += _pageHeight 'to force a new page
            ElseIf singleWord = vbTab Then
                'we got a tabulation, add white space while currentLine.Length is not modulo _TabLenght
                Do
                    currentLine += " "
                Loop While Not (currentLine.Length Mod _TabLenght = 0)
            Else
                If oGdPicturePdf.GetTextWidth(_fontID, 10, currentLine + singleWord) > _avaibleWidth Then
                    'the current line + the wordcan not be drawn on a single line
                    'so draw the current line
                    status = DrawText(currentLine)
                    If status <> GdPictureStatus.OK Then
                        MessageBox.Show("Error: " + status.ToString())
                        Exit Sub
                    End If
                    'set current line to the word
                    currentLine = singleWord
                Else
                    'the current line + the word can be drawn on a single line 
                    'add the word  to the current line
                    currentLine += singleWord
                End If
            End If
        Loop

        'finish the last line
        status = DrawText(currentLine)
        If status <> GdPictureStatus.OK Then
            MessageBox.Show("Error: " + status.ToString())
            Exit Sub
        End If
        status = oGdPicturePdf.SaveToFile(txtOutputFile.Text, False)
        ProgressBar1.Visible = False
        If status <> GdPictureStatus.OK Then
            MessageBox.Show("Error saving the PDF : " + status.ToString())
        Else
            MessageBox.Show("Done")
        End If
    End Sub

    Private Function DrawText(ByRef TextToDraw As String) As GdPictureStatus
        Dim status As GdPictureStatus = GdPictureStatus.OK
        If Trim(TextToDraw) <> "" Then
            'control if the text can be drawn on current page
            If _posY >= _avaibleHeight Then
                status = oGdPicturePdf.NewPage(_pageWidth, _pageHeight)
                If status <> GdPictureStatus.OK Then
                    ProgressBar1.Visible = False
                    MessageBox.Show("Error creating a new page for the pdf : " + status.ToString())
                    Return status
                Else
                    _posY = _topMargin + _lineHeight
                    oGdPicturePdf.SetTextSize(_textSize)
                End If
            End If
            'draw the text
            status = oGdPicturePdf.DrawText(_fontID, _LeftMargin, _posY, TextToDraw)
            If status <> GdPictureStatus.OK Then
                ProgressBar1.Visible = False
                MessageBox.Show("Error drawing a text on the page : " + status.ToString())
                Return status
            Else
                TextToDraw = ""
                _posY += _lineHeight
            End If
        Else
            'empty line : do not change y position
            TextToDraw = ""
        End If
        Return status
    End Function

    Private Function GetsingleWord(ByRef Buffer As String) As String
        'return the first word in buffer or a CR or a FF
        Dim singleCar As String
        Dim posX As Integer = 0
        Dim singleWord As String
        'get the first char
        singleCar = Buffer.Substring(posX, 1)
        'check if we have a carriage return or a Line Feed
        If singleCar = vbCr Or singleCar = vbFormFeed Or singleCar = vbTab Then
            posX += 1
            Buffer = Buffer.Substring(posX)
            Return singleCar
        End If
        'search the end of the word
        'preserve leading blanks
        Do While singleCar = " " And posX < Buffer.Length
            posX += 1
            If posX < Buffer.Length Then
                singleCar = Buffer.Substring(posX, 1)
            End If
        Loop
        'loop while not end of Word
        Do While (singleCar <> " " And singleCar <> vbCr And singleCar <> vbFormFeed And singleCar <> vbTab) And posX < Buffer.Length
            posX += 1
            If posX < Buffer.Length Then
                singleCar = Buffer.Substring(posX, 1)
            End If
        Loop
        'get the word
        singleWord = Buffer.Substring(0, posX)
        'crop buffer
        Buffer = Buffer.Substring(posX)
        Return singleWord
    End Function

End Class
