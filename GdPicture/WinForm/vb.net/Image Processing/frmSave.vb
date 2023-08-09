Option Strict On
Option Explicit On

Imports System.IO
Imports GdPicture14

Public Class frmSave

    Private ReadOnly _image As Integer

    Public Sub New(ByVal image As Integer)
        InitializeComponent()
        _image = image
    End Sub

    Private ReadOnly _exportFormat As New List(Of KeyValuePair(Of Integer, String)) From {
        New KeyValuePair(Of Integer, String)(0, "Windows or OS/2 bitmap (.bmp)"),
        New KeyValuePair(Of Integer, String)(1, "High Dynamic Range (.webp)"),
        New KeyValuePair(Of Integer, String)(2, "Graphics Interchange Format (.gif)"),
        New KeyValuePair(Of Integer, String)(3, "JBIG2 (.jbig2)"),
        New KeyValuePair(Of Integer, String)(4, "JPEG (.jpg)"),
        New KeyValuePair(Of Integer, String)(5, "JPEG-2000 (.jp2)"),
        New KeyValuePair(Of Integer, String)(6, "JPEG-2000 Codestream (.j2k)"),
        New KeyValuePair(Of Integer, String)(7, "Portable Document Format (.pdf)"),
        New KeyValuePair(Of Integer, String)(8, "Portable Network Graphics (.png)"),
        New KeyValuePair(Of Integer, String)(9, "Truevision TARGA (.tga)"),
        New KeyValuePair(Of Integer, String)(10, "Tagged Image File (.tif)"),
        New KeyValuePair(Of Integer, String)(11, "Google WebP (.webp)"),
        New KeyValuePair(Of Integer, String)(12, "Windows Metafile (.wmf)"),
        New KeyValuePair(Of Integer, String)(13, "X PixMap (.xpm)")
    }

    Private ReadOnly _exrCompression As New List(Of KeyValuePair(Of ExrCompression, String)) From {
        New KeyValuePair(Of ExrCompression, String)(ExrCompression.ExrCompressionDefault, "Half with piz-based wavelet compression"),
        New KeyValuePair(Of ExrCompression, String)(ExrCompression.ExrCompressionFloat, "Float instead of as half (not recommended)"),
        New KeyValuePair(Of ExrCompression, String)(ExrCompression.ExrCompressionNone, "No compression"),
        New KeyValuePair(Of ExrCompression, String)(ExrCompression.ExrCompressionZip, "Zlib compression, in blocks of 16 scan lines"),
        New KeyValuePair(Of ExrCompression, String)(ExrCompression.ExrCompressionPiz, "Piz-based wavelet compression"),
        New KeyValuePair(Of ExrCompression, String)(ExrCompression.ExrCompressionPxr24, "Lossy 24-bit float compression"),
        New KeyValuePair(Of ExrCompression, String)(ExrCompression.ExrCompressionB44, "Lossy 44% float compression"),
        New KeyValuePair(Of ExrCompression, String)(ExrCompression.ExrCompressionLC, "One luminance and two chroma channels")
    }

    Private ReadOnly _tiffCompression As New List(Of KeyValuePair(Of TiffCompression, String)) From {
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionNONE, "No compression"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionRLE, "CCITT modified Huffman RLE"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionCCITT3, "CCITT Group 3 fax encoding"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionCCITT4, "CCITT Group 4 fax encoding"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionLZW, "Lempel-Ziv and Welch (LZW)"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionJPEG, "JPEG DCT compression"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionADOBEDEFLATE, "Deflate compression,as recognized by Adobe"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionNEXT, "NeXT 2-bit RLE"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionCCITTRLEW, "#1 w/ word alignment"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionPACKBITS, "Macintosh RLE"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionTHUNDERSCAN, "ThunderScan RLE"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionDEFLATE, "Deflate compression"),
        New KeyValuePair(Of TiffCompression, String)(TiffCompression.TiffCompressionAUTO, "Automatic compression")
    }

    Private Sub frmSave_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        txtDestinationFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        cbDocumentFormat.ValueMember = "Key"
        cbDocumentFormat.DisplayMember = "Value"
        cbDocumentFormat.DataSource = _exportFormat
        cbDocumentFormat.SelectedValue = 4

        cbExrCompression.ValueMember = "Key"
        cbExrCompression.DisplayMember = "Value"
        cbExrCompression.DataSource = _exrCompression
        cbExrCompression.SelectedValue = ExrCompression.ExrCompressionDefault

        cbTiffCompression.ValueMember = "Key"
        cbTiffCompression.DisplayMember = "Value"
        cbTiffCompression.DataSource = _tiffCompression
        cbTiffCompression.SelectedValue = TiffCompression.TiffCompressionAUTO
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As EventArgs) Handles btnBrowse.Click
        Dim folderBrowseDialog As New FolderBrowserDialog()
        If folderBrowseDialog.ShowDialog() = DialogResult.OK Then
            txtDestinationFolder.Text = folderBrowseDialog.SelectedPath
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As EventArgs) Handles btnSave.Click
        Dim outputPath As String = Path.Combine(txtDestinationFolder.Text, "Image_Processing_Demo_" & DateTime.Now.ToString("yyyy-MM-dd_HHmmss"))
        Dim status As GdPictureStatus
        Using gdPictureImaging As New GdPictureImaging()
            Select Case cbDocumentFormat.SelectedIndex
                Case 0
                    outputPath += ".bmp"
                    status = gdPictureImaging.SaveAsBMP(_image, outputPath)
                Case 1
                    outputPath += ".webp"
                    status = gdPictureImaging.SaveAsEXR(_image, outputPath, CType(cbExrCompression.SelectedValue, ExrCompression))
                Case 2
                    outputPath += ".gif"
                    status = gdPictureImaging.SaveAsGIF(_image, outputPath)
                Case 3
                    outputPath += ".jbig2"
                    status = gdPictureImaging.SaveAsJBIG2(_image, outputPath)
                Case 4
                    outputPath += ".jpg"
                    status = gdPictureImaging.SaveAsJPEG(_image, outputPath, CInt(nJpegQuality.Value), chkProgressive.Checked)
                Case 5
                    outputPath += ".jp2"
                    status = gdPictureImaging.SaveAsJP2(_image, outputPath, CInt(nJ2kRate.Value))
                Case 6
                    outputPath += ".j2k"
                    status = gdPictureImaging.SaveAsJ2K(_image, outputPath, CInt(nJ2kRate.Value))
                Case 7
                    outputPath += ".pdf"
                    status = gdPictureImaging.SaveAsPDF(_image, outputPath, False, "Image Export", "Image Processing Demo", "Image Export", "", "GdPicture.NET")
                Case 8
                    outputPath += ".png"
                    status = gdPictureImaging.SaveAsPNG(_image, outputPath, CInt(nPngCompressionLevel.Value), chkPngInterlaced.Checked)
                Case 9
                    outputPath += ".tga"
                    status = gdPictureImaging.SaveAsTGA(_image, outputPath)
                Case 10
                    outputPath += ".tif"
                    status = gdPictureImaging.SaveAsTIFF(_image, outputPath, chkTiffCmyk.Checked, CType(cbTiffCompression.SelectedValue, TiffCompression), CInt(nJpegQuality.Value))
                Case 11
                    outputPath += ".webp"
                    status = gdPictureImaging.SaveAsWEBP(_image, outputPath, 75, 6)
                Case 12
                    outputPath += ".wmf"
                    status = gdPictureImaging.SaveAsWMF(_image, outputPath)
                Case 13
                    outputPath += ".xpm"
                    status = gdPictureImaging.SaveAsXPM(_image, outputPath)
            End Select
            If status <> GdPictureStatus.OK Then
                MessageBox.Show("An error occured: " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("The image has been saved as " + outputPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
        Me.Close()
    End Sub

    Private Sub cbDocumentFormat_ValueMemberChanged(sender As System.Object, e As EventArgs) Handles cbDocumentFormat.SelectedIndexChanged
        Select Case cbDocumentFormat.SelectedIndex
            Case 0
                grpCompressionOptions.Enabled = False
            Case 1
                grpCompressionOptions.Enabled = True
                cbExrCompression.Enabled = True
                nJ2kRate.Enabled = False
                nJpegQuality.Enabled = False
                chkProgressive.Enabled = False
                nPngCompressionLevel.Enabled = False
                chkPngInterlaced.Enabled = False
                cbTiffCompression.Enabled = False
                chkTiffCmyk.Enabled = False
            Case 2
                grpCompressionOptions.Enabled = False
            Case 3
                grpCompressionOptions.Enabled = False
            Case 4
                grpCompressionOptions.Enabled = True
                cbExrCompression.Enabled = False
                nJ2kRate.Enabled = False
                nJpegQuality.Enabled = True
                chkProgressive.Enabled = True
                nPngCompressionLevel.Enabled = False
                chkPngInterlaced.Enabled = False
                cbTiffCompression.Enabled = False
                chkTiffCmyk.Enabled = False
            Case 5
                grpCompressionOptions.Enabled = True
                cbExrCompression.Enabled = False
                nJ2kRate.Enabled = True
                nJpegQuality.Enabled = False
                chkProgressive.Enabled = False
                nPngCompressionLevel.Enabled = False
                chkPngInterlaced.Enabled = False
                cbTiffCompression.Enabled = False
                chkTiffCmyk.Enabled = False
            Case 6
                grpCompressionOptions.Enabled = True
                cbExrCompression.Enabled = False
                nJ2kRate.Enabled = True
                nJpegQuality.Enabled = False
                chkProgressive.Enabled = False
                nPngCompressionLevel.Enabled = False
                chkPngInterlaced.Enabled = False
                cbTiffCompression.Enabled = False
                chkTiffCmyk.Enabled = False
            Case 7
                grpCompressionOptions.Enabled = False
            Case 8
                grpCompressionOptions.Enabled = True
                cbExrCompression.Enabled = False
                nJ2kRate.Enabled = False
                nJpegQuality.Enabled = False
                chkProgressive.Enabled = False
                nPngCompressionLevel.Enabled = True
                chkPngInterlaced.Enabled = True
                cbTiffCompression.Enabled = False
                chkTiffCmyk.Enabled = False
            Case 9
                grpCompressionOptions.Enabled = False
            Case 10
                grpCompressionOptions.Enabled = True
                cbExrCompression.Enabled = False
                nJ2kRate.Enabled = False
                nJpegQuality.Enabled = False
                chkProgressive.Enabled = False
                nPngCompressionLevel.Enabled = False
                chkPngInterlaced.Enabled = False
                cbTiffCompression.Enabled = True
                chkTiffCmyk.Enabled = True
            Case 11
                grpCompressionOptions.Enabled = False
            Case 12
                grpCompressionOptions.Enabled = False
            Case 13
                grpCompressionOptions.Enabled = False
        End Select
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class