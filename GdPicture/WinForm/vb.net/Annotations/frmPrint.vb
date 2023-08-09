Option Explicit On
Option Infer On
Option Strict On

Imports System
Imports GdPicture14

Public Class frmPrint

    Enum PrintOrientation
        AutoDetection
        Portrait
        Paysage
    End Enum

    Enum PagesToPrint
        All
        Selection
        Current
        Range
    End Enum

    Public Structure PrintSettings
        Public Printer As String
        Public Copies As Short
        Public Collate As Boolean
        Public PrintSize As PrintSizeOption
        Public PrintAlignment As PrintAlignment
        Public Orientation As PrintOrientation
        Public PagesToPrint As PagesToPrint
        Public PageRange As String
    End Structure

    Private m_printSettings As PrintSettings
    Private ReadOnly m_owner As GdViewer

    Public ReadOnly Property printConfiguration() As PrintSettings
        Get
            Return m_printSettings
        End Get
    End Property


    Private ReadOnly m_isSelectionPartial As Boolean
    Private ReadOnly m_isEmptySelection As Boolean

    Public Sub New(ByVal owner As GdViewer)
        InitializeComponent()
        m_owner = owner
    End Sub

    Private Sub frmPrint_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cmbPrinterList.Items.Clear()
        For i As Integer = 1 To m_owner.PrintGetPrintersCount()
            Dim printerName As String = m_owner.PrintGetPrinterName(i)
            cmbPrinterList.Items.Add(printerName)
            If printerName = m_owner.PrintGetActivePrinter() Then
                cmbPrinterList.SelectedIndex = cmbPrinterList.Items.IndexOf(printerName)
            End If
        Next i

        cmbPrintSize.Items.Add("Actual size") '0 = PrintSizeOptionActual
        cmbPrintSize.Items.Add("Fit to page") '1 = PrintSizeOptionFit, default
        cmbPrintSize.Items.Add("Shrink oversized pages") '2 = PrintSizeOptionShrinkOversized
        cmbPrintSize.SelectedIndex = 2

        cmbPrintAlignment.Items.Add("Middle left") '0 = PrintAlignmentMiddleLeft
        cmbPrintAlignment.Items.Add("Middle right") '1 = PrintAlignmentMiddleRight
        cmbPrintAlignment.Items.Add("Middle center") '2 = PrintAlignmentMiddleCenter
        cmbPrintAlignment.Items.Add("Default") '3 = PrintAlignmentDefault
        cmbPrintAlignment.Items.Add("Top left") '4 = PrintAlignmentTopLeft
        cmbPrintAlignment.Items.Add("Top right") '5 = PrintAlignmentTopRight
        cmbPrintAlignment.Items.Add("Top center") '6 = PrintAlignmentTopCenter
        cmbPrintAlignment.Items.Add("Bottom left") '7 = PrintAlignmentBottomLeft
        cmbPrintAlignment.Items.Add("Bottom right") '8 = PrintAlignmentBottomRight
        cmbPrintAlignment.Items.Add("Bottom center") '9 = PrintAlignmentBottomCenter
        cmbPrintAlignment.SelectedIndex = 2

        If m_isEmptySelection Then
            rbPageRangeSelection.Enabled = False
        Else
            If m_isSelectionPartial Then
                rbPageRangeSelection.Checked = True
            End If
        End If
        txtPageRangeStart.Enabled = False
        txtPageRangeEnd.Enabled = False
        txtPageRangeStart.Text = "1"
        txtPageRangeEnd.Text = m_owner.PageCount.ToString()

        btnPrint.DialogResult = Windows.Forms.DialogResult.OK
        btnCancel.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnPrinterProperties_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrinterProperties.Click
        Dim status As GdPictureStatus = m_owner.PrintShowPrinterSettingsDialog(Me.Handle)
        If status <> GdPictureStatus.OK Then
            'todo: handle error
        End If
    End Sub

    Private Sub cmbPrinterList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbPrinterList.SelectedIndexChanged
        m_owner.PrintSetActivePrinter(cmbPrinterList.Text)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub rbPageRangeAll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbPageRangeAll.CheckedChanged
        rbPageRangeGeneric_CheckedChanged()
    End Sub

    Private Sub rbPageRangeSelection_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbPageRangeSelection.CheckedChanged
        rbPageRangeGeneric_CheckedChanged()
    End Sub

    Private Sub rbPageRangeCurrent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbPageRangeCurrent.CheckedChanged
        rbPageRangeGeneric_CheckedChanged()
    End Sub

    Private Sub rbPageRangePages_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbPageRangePages.CheckedChanged
        rbPageRangeGeneric_CheckedChanged()
    End Sub

    Private Sub rbPageRangeGeneric_CheckedChanged()
        If rbPageRangePages.Checked Then
            txtPageRangeStart.Enabled = True
            txtPageRangeEnd.Enabled = True
        Else
            txtPageRangeStart.Enabled = False
            txtPageRangeEnd.Enabled = False
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        m_printSettings.Printer = cmbPrinterList.Text
        m_printSettings.Copies = CShort(numCopies.Value)
        m_printSettings.Collate = chkCollate.Checked
        m_printSettings.PrintSize = CType(cmbPrintSize.SelectedIndex, PrintSizeOption)
        m_printSettings.PrintAlignment = CType(cmbPrintAlignment.SelectedIndex, PrintAlignment)

        If rbOrientationAutomatic.Checked Then
            m_printSettings.Orientation = PrintOrientation.AutoDetection
        ElseIf rbOrientationPortrait.Checked Then
            m_printSettings.Orientation = PrintOrientation.Portrait
        ElseIf rbOrientationLandscape.Checked Then
            m_printSettings.Orientation = PrintOrientation.Paysage
        End If

        If rbPageRangeAll.Checked Then
            m_printSettings.PagesToPrint = PagesToPrint.All
        ElseIf rbPageRangeSelection.Checked Then
            m_printSettings.PagesToPrint = PagesToPrint.Selection
        ElseIf rbPageRangeCurrent.Checked Then
            m_printSettings.PagesToPrint = PagesToPrint.Current
        ElseIf rbPageRangePages.Checked Then
            m_printSettings.PagesToPrint = PagesToPrint.Range
            m_printSettings.PageRange = txtPageRangeStart.Text & "-" & txtPageRangeEnd.Text
        End If
    End Sub

End Class