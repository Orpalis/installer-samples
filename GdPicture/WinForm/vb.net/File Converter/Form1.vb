Imports System.IO
Imports GdPicture14
Public Class Form1

    Private m_Status As GdPictureStatus 'Variable to monitor functions Success or Failure
    Private m_SrcImageID As Integer ' Variable to hold the image
    Private m_DestImageID As Integer 'Variable to hold the dist image in case of multipage dist image

    Private oGdPicturePDF As New GdPicturePDF 'Variable to hold a source pdf file
    Private oGdPictureImaging As New GdPictureImaging ' GdPictureImaging object for loading and saving images
    Private m_DestPDF As New GdPicturePDF ' Variable to hold a destination pdf file

    Private m_InputExtension As String 'Variable to hold input format
    Private m_OutPutExtension As String 'Variable to hold output format
    Private m_Name As String 'Variable to hold input and output file name

    Private m_DestinationFolder As String 'Path of Folder to be saved in
    Private m_DestinationPath As String 'Full Path of Destination
    Private m_SourcePath As String 'Full Path of Source

    Private m_IsSourceMultiPage As Boolean 'Whether source file is a multipage file
    Private m_IsDestMultiPage As Boolean 'Whether destination file can be a multipage file

    Private Delegate Sub SaveMethod() 'Delegate to call appropriate single save method
    Private SaveDel As SaveMethod 'Single Save delegate instance

    Private Delegate Sub CreateMultiPageFile() 'Delegate to create a multipage file
    Private CreateMultiDel As CreateMultiPageFile 'Create multipage file delegate instance

    Private Delegate Sub AddToMultiPageFile() 'Delegate to add image to a multipage file
    Private AddToMultiDel As AddToMultiPageFile 'Single Save delegate instance

    Private Delegate Sub CloseMultiPageFile() 'Delegate to close a multipage file
    Private CloseMultiDel As CloseMultiPageFile 'Close multipage file delegate instance

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key. 
    End Sub

    'Whether input file is supported in application, if so, load it
    Private Function LoadImageAndCheckSupport() As Boolean
        oGdPictureImaging.ReleaseGdPictureImage(m_SrcImageID)
        m_InputExtension = Path.GetExtension(m_SourcePath)
        m_Name = Path.GetFileNameWithoutExtension(m_SourcePath)
        Dim Success As Boolean = True
        m_IsSourceMultiPage = False
        Dim ext As String = m_InputExtension.ToLower()
        Select Case ext
            Case ".tif", ".tiff"
                m_SrcImageID = oGdPictureImaging.CreateGdPictureImageFromFile(m_SourcePath)
                If m_SrcImageID = 0 Then
                    MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString())
                    Success = False
                Else
                    If oGdPictureImaging.TiffIsMultiPage(m_SrcImageID) Then
                        m_IsSourceMultiPage = True
                    End If
                End If
            Case ".pdf"
                oGdPicturePDF.LoadFromFile(m_SourcePath, False)
                If oGdPicturePDF.GetStat() <> GdPictureStatus.OK Then
                    MessageBox.Show("Error: " + oGdPicturePDF.GetStat().ToString())
                    Success = False
                Else
                    If oGdPicturePDF.GetPageCount() > 1 Then
                        m_IsSourceMultiPage = True
                    End If
                End If
            Case ".bmp", ".png", ".exr", ".jpg", ".j2k", ".jp2", ".pbm", ".tga", ".wbmp", ".wmf", ".xpm"
                m_SrcImageID = oGdPictureImaging.CreateGdPictureImageFromFile(m_SourcePath)
                If m_SrcImageID = 0 Then
                    MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString())
                    Success = False
                End If
            Case ".gif"
                m_SrcImageID = oGdPictureImaging.CreateGdPictureImageFromFile(m_SourcePath)
                If m_SrcImageID = 0 Then
                    MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString())
                    Success = False
                Else
                    If oGdPictureImaging.GifIsMultiFrame(m_SrcImageID) Then
                        m_IsSourceMultiPage = True
                    End If
                End If
            Case ".jb2"
                m_SrcImageID = oGdPictureImaging.CreateGdPictureImageFromFile(m_SourcePath)
                If m_SrcImageID = 0 Then
                    MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString())
                    Success = False
                Else
                    If oGdPictureImaging.JBIG2IsMultiPage(m_SrcImageID) Then
                        m_IsSourceMultiPage = True
                    End If
                End If
            Case Else
                MessageBox.Show("File type is not supported!")
                Success = False
        End Select
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        Return Success
    End Function

    Private Sub ChooseInputFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseInputFile.Click
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            m_SourcePath = OpenFileDialog1.FileName
            If Not LoadImageAndCheckSupport() Then
                TextBox1.Text = ""
                m_InputExtension = ""
                m_Name = ""
                Return
            End If
            TextBox1.Text = OpenFileDialog1.FileName
            m_SourcePath = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        m_IsDestMultiPage = False
        SaveDel = Nothing
        CreateMultiDel = Nothing
        AddToMultiDel = Nothing
        CloseMultiDel = Nothing

        Select Case ComboBox1.SelectedItem
            Case "TIF"
                m_OutPutExtension = ".tif"
                m_IsDestMultiPage = True
                If m_IsSourceMultiPage Then
                    CreateMultiDel = New CreateMultiPageFile(AddressOf CreateMultiPageTIFF)
                    AddToMultiDel = New AddToMultiPageFile(AddressOf AddToMultiTIFF)
                    CloseMultiDel = New CloseMultiPageFile(AddressOf CloseMultiTIFF)
                Else
                    SaveDel = New SaveMethod(AddressOf SaveToSingleTIFF)
                End If
            Case "JPEG"
                m_OutPutExtension = ".jpg"
                SaveDel = New SaveMethod(AddressOf SaveToJPEG)
            Case "PDF"
                m_OutPutExtension = ".pdf"
                m_IsDestMultiPage = True
                If m_IsSourceMultiPage Then
                    CreateMultiDel = New CreateMultiPageFile(AddressOf CreateMultiPagePDF)
                    AddToMultiDel = New AddToMultiPageFile(AddressOf AddToMultiPDF)
                    CloseMultiDel = New CloseMultiPageFile(AddressOf CloseMultiPDF)
                Else
                    SaveDel = New SaveMethod(AddressOf SaveToSinglePDF)
                End If
            Case "BMP"
                m_OutPutExtension = ".bmp"
                SaveDel = New SaveMethod(AddressOf SaveToBMP)
            Case "EXR"
                m_OutPutExtension = ".exr"
                SaveDel = New SaveMethod(AddressOf SaveToEXR)
            Case "J2K"
                m_OutPutExtension = ".j2k"
                SaveDel = New SaveMethod(AddressOf SaveToJ2K)
            Case "JP2"
                m_OutPutExtension = ".JP2"
                SaveDel = New SaveMethod(AddressOf SaveToJP2)
            Case "PBM"
                m_OutPutExtension = ".pbm"
                SaveDel = New SaveMethod(AddressOf SaveToPBM)
            Case "TGA"
                m_OutPutExtension = ".tga"
                SaveDel = New SaveMethod(AddressOf SaveToTGA)
            Case "WBMP"
                m_OutPutExtension = ".wbmp"
                SaveDel = New SaveMethod(AddressOf SaveToWBMP)
            Case "WMF"
                m_OutPutExtension = ".wmf"
                SaveDel = New SaveMethod(AddressOf SaveToWMF)
            Case "XMP"
                m_OutPutExtension = ".xmp"
                SaveDel = New SaveMethod(AddressOf SaveToXMP)
            Case "GIF"
                m_OutPutExtension = ".gif"
                m_IsDestMultiPage = True
                If m_IsSourceMultiPage Then
                    CreateMultiDel = New CreateMultiPageFile(AddressOf CreateMultiPageGIF)
                    AddToMultiDel = New AddToMultiPageFile(AddressOf AddToMultiGIF)
                    CloseMultiDel = New CloseMultiPageFile(AddressOf CloseMultiGIF)
                Else
                    SaveDel = New SaveMethod(AddressOf SaveToSingleGIF)
                End If
            Case "PNG"
                m_OutPutExtension = ".png"
                SaveDel = New SaveMethod(AddressOf SaveToPNG)
            Case "JBIG2"
                m_OutPutExtension = ".jb2"
                m_IsDestMultiPage = True
                If m_IsSourceMultiPage Then
                    CreateMultiDel = New CreateMultiPageFile(AddressOf CreateMultiPageJBIG2)
                    AddToMultiDel = New AddToMultiPageFile(AddressOf AddToMultiJBIG2)
                    CloseMultiDel = New CloseMultiPageFile(AddressOf CloseMultiJBIG2)
                Else
                    SaveDel = New SaveMethod(AddressOf SaveToSingleJBIG2)
                End If
        End Select
    End Sub

    Private Sub ChooseDestinationFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChooseDestinationFolder.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            m_DestinationFolder = FolderBrowserDialog1.SelectedPath
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        Else
            m_DestinationFolder = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Function CheckIfAllDataIsAvailable() As Boolean
        Dim IsAvailable = True
        If m_InputExtension = "" Then
            MessageBox.Show("No file has been loaded!")
            IsAvailable = False
        End If
        If m_DestinationFolder = "" Then
            MessageBox.Show("Destination folder has not been selected!")
            IsAvailable = False
        End If
        If m_OutPutExtension = "" Then
            MessageBox.Show("Please choose output format!")
            IsAvailable = False
        End If
        If m_InputExtension = m_OutPutExtension Then
            MessageBox.Show("Source and output formats are the same!")
            IsAvailable = False
        End If
        Return IsAvailable
    End Function


    Private Sub Convert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Convert.Click
        If Not CheckIfAllDataIsAvailable() Then
            Return
        End If
        If m_IsSourceMultiPage Then
            If m_IsDestMultiPage Then
                MultiToMulti()
            Else
                MultiToSplit()
            End If
        Else
            m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + m_OutPutExtension)
            SingleToSingle()
        End If
    End Sub

    'Calling the SaveImage Delegate function
    Private Sub SaveImage()
        SaveDel.Invoke()
    End Sub

    'Method to convert any single image to any single image extension including a single page pdf
    Private Sub SingleToSingle()

        ProgressBar1.Maximum = 1
        ProgressBar1.Value = 0
        If m_InputExtension = ".pdf" Then
            oGdPicturePDF.SelectPage(1)
            m_SrcImageID = oGdPicturePDF.RenderPageToGdPictureImage(200, True)
            If m_SrcImageID <> 0 Then
                SaveImage()
            Else
                MessageBox.Show("Error: " + oGdPicturePDF.GetStat().ToString())
            End If
        Else
            SaveImage()
        End If
        ProgressBar1.Value = 1
    End Sub

    'Method to split any multipage file to single images of any extenstion
    Private Sub MultiToSplit()
        If m_InputExtension = ".pdf" Then
            Dim NumberOfPages As Integer = oGdPicturePDF.GetPageCount()
            ProgressBar1.Maximum = NumberOfPages
            For i As Integer = 1 To NumberOfPages
                oGdPicturePDF.SelectPage(i)
                m_SrcImageID = oGdPicturePDF.RenderPageToGdPictureImage(200, True)
                If m_SrcImageID <> 0 Then
                    m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + "_Split_" + i.ToString() + m_OutPutExtension)
                    SaveImage()
                    If m_Status <> GdPictureStatus.OK Then
                        m_Status = GdPictureStatus.OK
                        ProgressBar1.Value = 0
                        Return
                    End If
                Else
                    MessageBox.Show("Error: " + oGdPicturePDF.GetStat().ToString())
                    Exit Sub
                End If
                oGdPictureImaging.ReleaseGdPictureImage(m_SrcImageID)
                ProgressBar1.Value = i
                Application.DoEvents()
            Next
        ElseIf m_InputExtension = ".tif" Then
            Dim NumberOfPages As Integer = oGdPictureImaging.TiffGetPageCount(m_SrcImageID)
            ProgressBar1.Maximum = NumberOfPages
            For i As Integer = 1 To NumberOfPages
                oGdPictureImaging.TiffSelectPage(m_SrcImageID, i)
                m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + "_Split_" + i.ToString() + m_OutPutExtension)
                SaveImage()
                If m_Status <> GdPictureStatus.OK Then
                    m_Status = GdPictureStatus.OK
                    ProgressBar1.Value = 0
                    Exit Sub
                End If
            Next
        ElseIf m_InputExtension = ".gif" Then
            Dim NumberOfPages As Integer = oGdPictureImaging.GifGetFrameCount(m_SrcImageID)
            ProgressBar1.Maximum = NumberOfPages
            For i As Integer = 1 To NumberOfPages
                oGdPictureImaging.GifSelectFrame(m_SrcImageID, i)
                m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + "_Split_" + i.ToString() + m_OutPutExtension)
                SaveImage()
                If m_Status <> GdPictureStatus.OK Then
                    m_Status = GdPictureStatus.OK
                    ProgressBar1.Value = 0
                    Return
                End If
                ProgressBar1.Value = i
                Application.DoEvents()
            Next
        Else
            Dim NumberOfPages As Integer = oGdPictureImaging.JBIG2GetPageCount(m_SrcImageID)
            ProgressBar1.Maximum = NumberOfPages
            For i As Integer = 1 To NumberOfPages 
                oGdPictureImaging.JBIG2SelectPage(m_SrcImageID, i)
                m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + "_Split_" + i.ToString() + m_OutPutExtension)
                SaveImage()
                If m_Status <> GdPictureStatus.OK Then
                    m_Status = GdPictureStatus.OK
                    ProgressBar1.Value = 0
                    Return
                End If
                ProgressBar1.Value = i
                Application.DoEvents()
            Next
        End If
    End Sub


    'Method to save any multipage file to another multipage file
    Private Sub MultiToMulti()
        If m_InputExtension = ".pdf" Then
            Dim NumberOfPages As Integer = oGdPicturePDF.GetPageCount()
            ProgressBar1.Maximum = NumberOfPages
            For i As Integer = 1 To NumberOfPages
                oGdPicturePDF.SelectPage(i)
                m_SrcImageID = oGdPicturePDF.RenderPageToGdPictureImage(200, True)
                If m_SrcImageID <> 0 Then
                    If i = 1 Then
                        CreateMultiDel.Invoke()
                        If m_Status <> GdPictureStatus.OK Then
                            MessageBox.Show("Error: " + m_Status.ToString())
                            m_Status = GdPictureStatus.OK ' Reinitialize Status for next run
                            Exit Sub
                        End If
                    Else
                        AddToMultiDel.Invoke()
                        If m_Status <> GdPictureStatus.OK Then
                            MessageBox.Show("Error: " + m_Status.ToString())
                            CloseMultiDel.Invoke() 'Release file from memory
                            m_Status = GdPictureStatus.OK ' Reinitialize Status for next run
                            Exit Sub
                        End If
                    End If
                Else
                    MessageBox.Show("Error: " + oGdPicturePDF.GetStat().ToString())
                    m_Status = oGdPicturePDF.GetStat()
                    m_Status = GdPictureStatus.OK ' Reinitialize Status for next run
                    Exit Sub
                End If
                oGdPictureImaging.ReleaseGdPictureImage(m_SrcImageID)
                ProgressBar1.Value = i
                Application.DoEvents()
            Next
            CloseMultiDel.Invoke()
        ElseIf m_InputExtension = ".tif" Then
            Dim NumberOfPages As Integer = oGdPictureImaging.TiffGetPageCount(m_SrcImageID)
            ProgressBar1.Maximum = NumberOfPages
            For i As Integer = 1 To NumberOfPages
                oGdPictureImaging.TiffSelectPage(m_SrcImageID, i)
                If i = 1 Then
                    CreateMultiDel.Invoke()
                    If m_Status <> GdPictureStatus.OK Then
                        MessageBox.Show("Error: " + m_Status.ToString())
                        m_Status = GdPictureStatus.OK ' Reinitialize Status for next run
                        Exit Sub
                    End If
                Else
                    AddToMultiDel.Invoke()
                    If m_Status <> GdPictureStatus.OK Then
                        MessageBox.Show("Error: " + m_Status.ToString())
                        m_Status = GdPictureStatus.OK ' Reinitialize Status for next run
                        CloseMultiDel.Invoke() 'Release file from memory
                        Exit Sub
                    End If
                End If
                ProgressBar1.Value = i
                Application.DoEvents()
            Next
            CloseMultiDel.Invoke()

        ElseIf m_InputExtension = ".gif" Then
            Dim NumberOfPages As Integer = oGdPictureImaging.GifGetFrameCount(m_SrcImageID)
            ProgressBar1.Maximum = NumberOfPages
            For i As Integer = 1 To NumberOfPages
                oGdPictureImaging.GifSelectFrame(m_SrcImageID, i)
                If i = 1 Then
                    CreateMultiDel.Invoke()
                    If m_Status <> GdPictureStatus.OK Then
                        MessageBox.Show("Error: " + m_Status.ToString())
                        m_Status = GdPictureStatus.OK ' Reinitialize Status for next run
                        Exit Sub
                    End If
                Else
                    AddToMultiDel.Invoke()
                    If m_Status <> GdPictureStatus.OK Then
                        MessageBox.Show("Error: " + m_Status.ToString())
                        CloseMultiDel.Invoke() 'Release file from memory
                        m_Status = GdPictureStatus.OK ' Reinitialize Status for next run
                        Exit Sub
                    End If
                End If
                ProgressBar1.Value = i
                Application.DoEvents()
            Next
            CloseMultiDel.Invoke()
        Else
            Dim NumberOfPages As Integer = oGdPictureImaging.JBIG2GetPageCount(m_SrcImageID)
            ProgressBar1.Maximum = NumberOfPages
            For i As Integer = 1 To NumberOfPages
                oGdPictureImaging.JBIG2SelectPage(m_SrcImageID, i)
                If i = 1 Then
                    CreateMultiDel.Invoke()
                    If m_Status <> GdPictureStatus.OK Then
                        MessageBox.Show("Error: " + m_Status.ToString())
                        m_Status = GdPictureStatus.OK ' Reinitialize Status for next run
                        Exit Sub
                    End If
                Else
                    AddToMultiDel.Invoke()
                    If m_Status <> GdPictureStatus.OK Then
                        MessageBox.Show("Error: " + m_Status.ToString())
                        CloseMultiDel.Invoke() 'Release file from memory
                        m_Status = GdPictureStatus.OK ' Reinitialize Status for next run
                        Exit Sub
                    End If
                End If
                ProgressBar1.Value = i
                Application.DoEvents()
            Next
            CloseMultiDel.Invoke()
        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''
    'Methods for Saving Single Images
    ''''''''''''''''''''''''''''''''''''''''''''''''
    'Save BMP file
    Private Sub SaveToBMP()
        Dim Status As GdPictureStatus = oGdPictureImaging.SaveAsBMP(m_SrcImageID, m_DestinationPath)
        If Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + Status.ToString())
        End If
    End Sub

    'Save single page TIFF file
    Private Sub SaveToSingleTIFF()
        m_Status = oGdPictureImaging.SaveAsTIFF(m_SrcImageID, m_DestinationPath, TiffCompression.TiffCompressionAUTO)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save single frame GIF file
    Private Sub SaveToSingleGIF()
        m_Status = oGdPictureImaging.SaveAsGIF(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save single page JBIG2 file
    Private Sub SaveToSingleJBIG2()
        m_Status = oGdPictureImaging.SaveAsJBIG2(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save single page PDF file
    Private Sub SaveToSinglePDF()
        m_Status = oGdPictureImaging.SaveAsPDF(m_SrcImageID, m_DestinationPath, False, m_Name, "GdPicture", _
                                                            "", "", "GdPicture File Converter")
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save JPEG file
    Private Sub SaveToJPEG()
        m_Status = oGdPictureImaging.SaveAsJPEG(m_SrcImageID, m_DestinationPath, 75)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save PNG file
    Private Sub SaveToPNG()
        m_Status = oGdPictureImaging.SaveAsPNG(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save EXR file
    Private Sub SaveToEXR()
        m_Status = oGdPictureImaging.SaveAsEXR(m_SrcImageID, m_DestinationPath, ExrCompression.ExrCompressionDefault)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save J2K file
    Private Sub SaveToJ2K()
        m_Status = oGdPictureImaging.SaveAsJ2K(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save JP2 file
    Private Sub SaveToJP2()
        m_Status = oGdPictureImaging.SaveAsJP2(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save PBM file
    Private Sub SaveToPBM()
        m_Status = oGdPictureImaging.SaveAsPBM(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save TGA file
    Private Sub SaveToTGA()
        m_Status = oGdPictureImaging.SaveAsTGA(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save WBMP file
    Private Sub SaveToWBMP()
        m_Status = oGdPictureImaging.SaveAsWBMP(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save WMF file
    Private Sub SaveToWMF()
        m_Status = oGdPictureImaging.SaveAsWMF(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    'Save XMP file
    Private Sub SaveToXMP()
        m_Status = oGdPictureImaging.SaveAsXPM(m_SrcImageID, m_DestinationPath)
        If m_Status <> GdPictureStatus.OK Then
            MessageBox.Show("error: " + m_Status.ToString())
        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''
    'Methods for Creating Multipage Files
    ''''''''''''''''''''''''''''''''''''''''''''''''
    'Create MultiPage Tiff
    Private Sub CreateMultiPageTIFF()
        m_DestImageID = oGdPictureImaging.CreateClonedGdPictureImage(m_SrcImageID) 'This image must be released at the end of the multipage TIFF generation !!
        If m_DestImageID = 0 Then
            m_Status = oGdPictureImaging.GetStat()
        End If
        m_Status = oGdPictureImaging.TiffSaveAsMultiPageFile(m_DestImageID, _
                                                                                  Path.Combine(m_DestinationFolder, _
                                                                                               m_Name + m_OutPutExtension), _
                                                                                  TiffCompression.TiffCompressionAUTO)
    End Sub

    'Create MultiPage PDF
    Private Sub CreateMultiPagePDF()
        m_Status = m_DestPDF.NewPDF()
        If m_Status <> GdPictureStatus.OK Then
            Exit Sub
        End If
        AddToMultiPDF()
    End Sub

    'Create MultiPage JBIG2
    Private Sub CreateMultiPageJBIG2()
        m_DestImageID = oGdPictureImaging.CreateClonedGdPictureImage(m_SrcImageID) 'This image must be released at the end of the multipage TIFF generation !!
        If m_DestImageID = 0 Then
            m_Status = oGdPictureImaging.GetStat()
        End If
        m_Status = oGdPictureImaging.JBIG2SaveAsMultiPageFile(m_DestImageID, _
                                                                                  Path.Combine(m_DestinationFolder, _
                                                                                               m_Name + m_OutPutExtension))
    End Sub

    'Create MultiPage GIF
    Private Sub CreateMultiPageGIF()
        m_DestImageID = oGdPictureImaging.GifCreateMultiFrameFromGdPictureImage(m_SrcImageID) 'This image must be released at the end of the multipage TIFF generation !!
        If m_DestImageID = 0 Then
            m_Status = oGdPictureImaging.GetStat()
        End If
    End Sub


    ''''''''''''''''''''''''''''''''''''''''''''''''
    'Methods for Adding pages to Multipage Files
    ''''''''''''''''''''''''''''''''''''''''''''''''
    'Add page to MultiPage Tiff
    Private Sub AddToMultiTIFF()
        m_Status = oGdPictureImaging.TiffAddToMultiPageFile(m_DestImageID, m_SrcImageID)
    End Sub

    'Add page to MultiPage PDF
    Private Sub AddToMultiPDF()
        Dim image_res_name As String = m_DestPDF.AddImageFromGdPictureImage(m_SrcImageID, False, True)
    End Sub

    'Add frame to MultiFrame Gif
    Private Sub AddToMultiGIF()
        m_Status = oGdPictureImaging.GifAppendFrameFromGdPictureImage(m_DestImageID, m_SrcImageID)
    End Sub

    'Add page to MultiPage Jbig2
    Private Sub AddToMultiJBIG2()
        m_Status = oGdPictureImaging.JBIG2AddToMultiPageFile(m_DestImageID, m_SrcImageID)
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''
    'Methods for Closing Multipage Files
    ''''''''''''''''''''''''''''''''''''''''''''''''
    'Close MultiPage Tiff
    Private Sub CloseMultiTIFF()
        oGdPictureImaging.TiffCloseMultiPageFile(m_DestImageID)
        oGdPictureImaging.ReleaseGdPictureImage(m_DestImageID)
    End Sub

    'Close MultiPage PDF
    Private Sub CloseMultiPDF()
        If m_Status = GdPictureStatus.OK Then 'If Last Add frame process succeeded
            m_DestPDF.SaveToFile(Path.Combine(m_DestinationFolder, m_Name + m_OutPutExtension))
        End If
        m_DestPDF.CloseDocument()
    End Sub

    'Close MultiFrame Gif
    Private Sub CloseMultiGIF()
        If m_Status = GdPictureStatus.OK Then 'If Last Add frame process succeeded
            oGdPictureImaging.GifSaveMultiFrameToFile(m_DestImageID, Path.Combine(m_DestinationFolder, m_Name + m_OutPutExtension))
        End If
        oGdPictureImaging.ReleaseGdPictureImage(m_DestImageID)
    End Sub

    'Close MultiPage Tiff
    Private Sub CloseMultiJBIG2()
        oGdPictureImaging.JBIG2CloseMultiPageFile(m_DestImageID)
        oGdPictureImaging.ReleaseGdPictureImage(m_DestImageID)
    End Sub
End Class

