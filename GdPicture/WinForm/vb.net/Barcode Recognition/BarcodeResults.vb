Imports System.Collections.Generic

Public Class BarcodeResults

    Private _barcode1DResults As List(Of SingleBarcodeInfo)
    Private _barcode2DResults As List(Of SingleBarcodeInfo)
    Private _barcodeQRResults As List(Of SingleBarcodeInfo)
    Private _barcodePDF417Results As List(Of SingleBarcodeInfo)
    Private _barcodeMicroQRResults As List(Of SingleBarcodeInfo)
    Private _barcodeAztecResults As List(Of SingleBarcodeInfo)
    Private _barcodeMaxicodeResults As List(Of SingleBarcodeInfo)
    Private _patchCodeResults As List(Of SingleBarcodeInfo)

    Private totalBarcodesCount As Integer = 0

    Public Sub New(ByVal barcode1DResults As List(Of SingleBarcodeInfo),
                   ByVal barcode2DResults As List(Of SingleBarcodeInfo),
                   ByVal barcodeQRResults As List(Of SingleBarcodeInfo),
                   ByVal barcodePDF417Results As List(Of SingleBarcodeInfo),
                   ByVal barcodeMicroQRResults As List(Of SingleBarcodeInfo),
                   ByVal barcodeAztecResults As List(Of SingleBarcodeInfo),
                   ByVal barcodeMaxicodeResults As List(Of SingleBarcodeInfo),
                   ByVal PatchCodeResults As List(Of SingleBarcodeInfo))
        InitializeComponent()

        Me._barcode1DResults = barcode1DResults
        Me._barcode2DResults = barcode2DResults
        Me._barcodeQRResults = barcodeQRResults
        Me._barcodePDF417Results = barcodePDF417Results
        Me._barcodeMicroQRResults = barcodeMicroQRResults
        Me._barcodeAztecResults = barcodeAztecResults
        Me._barcodeMaxicodeResults = barcodeMaxicodeResults
        Me._patchCodeResults = PatchCodeResults

        EnableButtons()
    End Sub

    Private Sub EnableButtons()
        Dim populated As Boolean = False
        If Me._barcode1DResults IsNot Nothing AndAlso Me._barcode1DResults.Count > 0 Then
            Me.btn1DBarcode.Text = Me.btn1DBarcode.Text & ": " & Me._barcode1DResults.Count.ToString()
            totalBarcodesCount += Me._barcode1DResults.Count
            Me.btn1DBarcode.Enabled = True
            PopulateList(Me._barcode1DResults)
            populated = True
        End If

        If Me._barcode2DResults IsNot Nothing AndAlso Me._barcode2DResults.Count > 0 Then
            Me.btn2DBarcode.Text = Me.btn2DBarcode.Text & ": " & Me._barcode2DResults.Count.ToString()
            totalBarcodesCount += Me._barcode2DResults.Count
            Me.btn2DBarcode.Enabled = True
            If Not populated Then
                PopulateList(Me._barcode2DResults)
                populated = True
            End If
        End If

        If Me._barcodeQRResults IsNot Nothing AndAlso Me._barcodeQRResults.Count > 0 Then
            Me.btnQRBarcode.Text = Me.btnQRBarcode.Text & ": " & Me._barcodeQRResults.Count.ToString()
            totalBarcodesCount += Me._barcodeQRResults.Count
            Me.btnQRBarcode.Enabled = True
            If Not populated Then
                PopulateList(Me._barcodeQRResults)
                populated = True
            End If
        End If

        If Me._barcodePDF417Results IsNot Nothing AndAlso Me._barcodePDF417Results.Count > 0 Then
            Me.btnPDF417Barcode.Text = Me.btnPDF417Barcode.Text & ": " & Me._barcodePDF417Results.Count.ToString()
            totalBarcodesCount += Me._barcodePDF417Results.Count
            Me.btnPDF417Barcode.Enabled = True
            If Not populated Then
                PopulateList(Me._barcodePDF417Results)
                populated = True
            End If
        End If

        If Me._barcodeMicroQRResults IsNot Nothing AndAlso Me._barcodeMicroQRResults.Count > 0 Then
            Me.btnMicroQRBarcode.Text = Me.btnMicroQRBarcode.Text & ": " & Me._barcodeMicroQRResults.Count.ToString()
            totalBarcodesCount += Me._barcodeMicroQRResults.Count
            Me.btnMicroQRBarcode.Enabled = True
            If Not populated Then
                PopulateList(Me._barcodeMicroQRResults)
                populated = True
            End If
        End If

        If Me._barcodeAztecResults IsNot Nothing AndAlso Me._barcodeAztecResults.Count > 0 Then
            Me.btnAztecBarcode.Text = Me.btnAztecBarcode.Text & ": " & Me._barcodeAztecResults.Count.ToString()
            totalBarcodesCount += Me._barcodeAztecResults.Count
            Me.btnAztecBarcode.Enabled = True
            If Not populated Then
                PopulateList(Me._barcodeAztecResults)
                populated = True
            End If
        End If

        If Me._barcodeMaxicodeResults IsNot Nothing AndAlso Me._barcodeMaxicodeResults.Count > 0 Then
            Me.btnMaxicodeBarcode.Text = Me.btnMaxicodeBarcode.Text & ": " & Me._barcodeMaxicodeResults.Count.ToString()
            totalBarcodesCount += Me._barcodeMaxicodeResults.Count
            Me.btnMaxicodeBarcode.Enabled = True
            If Not populated Then
                PopulateList(Me._barcodeMaxicodeResults)
                populated = True
            End If
        End If

        If Me._patchCodeResults IsNot Nothing AndAlso Me._patchCodeResults.Count > 0 Then
            Me.btnPatchCodeBarcode.Text = Me.btnPatchCodeBarcode.Text & ": " & Me._patchCodeResults.Count.ToString()
            totalBarcodesCount += Me._patchCodeResults.Count
            Me.btnPatchCodeBarcode.Enabled = True
            If Not populated Then
                PopulateList(Me._patchCodeResults)
                populated = True
            End If
        End If

        lblTotalBarcodesCount.Text = lblTotalBarcodesCount.Text & " " & totalBarcodesCount.ToString()
    End Sub

    Private Sub Close_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Form_Closing() Handles Me.FormClosing
        ClearLists()
    End Sub

    Private Sub ClearLists()
        _barcode1DResults.Clear()
        _barcode2DResults.Clear()
        _barcodeQRResults.Clear()
        _barcodePDF417Results.Clear()
        _barcodeMicroQRResults.Clear()
        _barcodeAztecResults.Clear()
        _barcodeMaxicodeResults.Clear()
        _patchCodeResults.Clear()
    End Sub

    Private Sub PopulateList(ByVal barcodesResultsList As List(Of SingleBarcodeInfo))
        resultsList.Controls.Clear()
        For i As Integer = 0 To barcodesResultsList.Count - 1
            resultsList.Controls.Add(barcodesResultsList(i))
        Next
    End Sub

    Private Sub btn1DBarcode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn1DBarcode.Click
        PopulateList(Me._barcode1DResults)
    End Sub

    Private Sub btn2DBarcode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn2DBarcode.Click
        PopulateList(Me._barcode2DResults)
    End Sub

    Private Sub btnQRBarcode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQRBarcode.Click
        PopulateList(Me._barcodeQRResults)
    End Sub

    Private Sub btnPDF417Barcode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPDF417Barcode.Click
        PopulateList(Me._barcodePDF417Results)
    End Sub

    Private Sub btnMicroQRBarcode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMicroQRBarcode.Click
        PopulateList(Me._barcodeMicroQRResults)
    End Sub

    Private Sub btnPatchCodeBarcode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPatchCodeBarcode.Click
        PopulateList(Me._patchCodeResults)
    End Sub

    Private Sub btnAztecBarcode_Click(sender As Object, e As EventArgs) Handles btnAztecBarcode.Click
        PopulateList(Me._barcodeAztecResults)
    End Sub

    Private Sub btnMaxicodeBarcode_Click(sender As Object, e As EventArgs) Handles btnMaxicodeBarcode.Click
        PopulateList(Me._barcodeMaxicodeResults)
    End Sub
End Class