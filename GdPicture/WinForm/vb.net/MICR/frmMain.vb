Imports System.Windows.Forms
Imports System.Text
Imports GdPicture14

Public Class frmMain
    Private sw As New System.Diagnostics.Stopwatch()
    Private _GdPictureImaging As New GdPictureImaging()
    Private _ImageID As Integer = 0
    Private _InitialImageID As Integer = 0


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
        cmbWhiteList.SelectedIndex = 1
        cmbContext.SelectedIndex = 1
        cmbFont.SelectedIndex = 1
    End Sub


    Private Sub openToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
        CloseNativeImage()
        _ImageID = _GdPictureImaging.CreateGdPictureImageFromFile("")

        If _ImageID <> 0 Then

            txtResults.Text = "size: " + _GdPictureImaging.GetWidth(_ImageID).ToString() + " * " + _GdPictureImaging.GetHeight(_ImageID).ToString() + vbCrLf + _
                              "resolution: " + _GdPictureImaging.GetHorizontalResolution(_ImageID).ToString() + " / " + _GdPictureImaging.GetVerticalResolution(_ImageID).ToString() + vbCrLf + _
                              "bit depth: " + _GdPictureImaging.GetBitDepth(_ImageID).ToString()
            _InitialImageID = _GdPictureImaging.CreateClonedGdPictureImage(_ImageID)
            gdViewer1.DisplayFromGdPictureImage(_ImageID)
        End If
    End Sub


    Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
        Application.Exit()
    End Sub


    Private Sub closeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeToolStripMenuItem.Click
        CloseNativeImage()
    End Sub


    Private Sub CloseNativeImage()
        gdViewer1.CloseDocument()
        If _ImageID <> 0 Then
            _GdPictureImaging.ReleaseGdPictureImage(_ImageID)
            _ImageID = 0
        End If

        If _InitialImageID <> 0 Then
            _GdPictureImaging.ReleaseGdPictureImage(_InitialImageID)
        End If

    End Sub


    Private Sub Revert()
        If _ImageID <> 0 AndAlso _InitialImageID <> 0 Then
            gdViewer1.CloseDocument()
            _GdPictureImaging.ReleaseGdPictureImage(_ImageID)
            _ImageID = _GdPictureImaging.CreateClonedGdPictureImage(_InitialImageID)
            gdViewer1.DisplayFromGdPictureImage(_ImageID)
        End If
    End Sub


    Private Sub autoDeskewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles autoDeskewToolStripMenuItem.Click
        _GdPictureImaging.AutoDeskew(_ImageID)
        gdViewer1.DisplayFromGdPictureImage(_ImageID)
    End Sub

    Private Sub Rotate90ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Rotate90ToolStripMenuItem.Click
        _GdPictureImaging.Rotate(_ImageID, Drawing.RotateFlipType.Rotate90FlipNone)
        gdViewer1.DisplayFromGdPictureImage(_ImageID)
    End Sub

    Private Sub ResetToInputToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ResetToInputToolStripMenuItem.Click
        Revert()
    End Sub

    Private Sub cmbFont_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbFont.SelectedIndexChanged
        If cmbFont.SelectedIndex = 1 Then
            cmbWhiteList.SelectedIndex = 2
        Else
            cmbWhiteList.SelectedIndex = 0
        End If
    End Sub

    Private Sub testsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles testsToolStripMenuItem.Click
        gdViewer1.RemoveAllRegions()
        Dim sw As New System.Diagnostics.Stopwatch()
        sw.Start()

        Dim result As New StringBuilder(_GdPictureImaging.MICRDoMICR(_ImageID, CType(cmbFont.SelectedIndex, MICRFont), CType(cmbContext.SelectedIndex, MICRContext), cmbWhiteList.Text, CInt(nupdownSymbols.Value)).Length)

        result = result.Replace(Chr(0), "?")
        sw.Stop()
        Dim status As GdPictureStatus = _GdPictureImaging.GetStat()

        If status = GdPictureStatus.OK Then

            'Drawin bounding boxes
            Dim count As Integer = _GdPictureImaging.MICRGetSymbolsCount
            Dim minAcc As Single = 100
            Dim maxAcc As Single = 0
            Dim accAccumulator As Single = 0
            Dim itemsRetained As Integer = 0
            Dim sb As New StringBuilder()


            For i As Integer = 1 To count
                Dim accuracy As Single = _GdPictureImaging.MICRGetSymbolConfidence(i, 1)

                If accuracy >= nupMinAcc.Value Then
                    itemsRetained += 1
                    result.Append(_GdPictureImaging.MICRGetSymbolValue(i, 1))
                    minAcc = Math.Min(minAcc, accuracy)
                    maxAcc = Math.Max(maxAcc, accuracy)

                    accAccumulator += accuracy
                    gdViewer1.AddRegion(i.ToString(), _GdPictureImaging.MICRGetSymbolLeft(i), _
                                                              _GdPictureImaging.MICRGetSymbolTop(i), _
                                                              _GdPictureImaging.MICRGetSymbolRight(i) - _GdPictureImaging.MICRGetSymbolLeft(i), _
                                                              _GdPictureImaging.MICRGetSymbolBottom(i) - _GdPictureImaging.MICRGetSymbolTop(i), ForegroundMixMode.ForegroundMixModeMASKNOTPEN, Drawing.Color.Yellow)
                End If

            Next
            gdViewer1.Redraw()
            sb.Append("Count: " + itemsRetained.ToString() + vbCrLf + _
                              "Elapsed: " + (Math.Round(sw.Elapsed.TotalMilliseconds, 2)).ToString() + " ms." + vbCrLf + _
                              "Confidence. Min: " + (Math.Round(minAcc, 2)).ToString() + "%. " + "Max: " + (Math.Round(maxAcc, 2)).ToString() + "%. " + "Avg: " + (Math.Round(accAccumulator / itemsRetained, 2)).ToString() + "%. " + vbCrLf + _
                              "Result: " + result.ToString)

            sb.Append(vbCrLf + vbCrLf + _
                               "=======================" + vbCrLf + _
                               "Details:" + vbCrLf + _
                               "=======================" + vbCrLf)
            For i As Integer = 1 To count

                If _GdPictureImaging.MICRGetSymbolConfidence(i, 1) >= nupMinAcc.Value Then

                    Dim candidate1 As String = _GdPictureImaging.MICRGetSymbolValue(i, 1)
                    Dim candidate2 As String = _GdPictureImaging.MICRGetSymbolValue(i, 2)

                    If candidate1 = Chr(0) Then
                        candidate1 = "#undef"
                    End If

                    If candidate2 = Chr(0) Then
                        candidate2 = "#undef"
                    End If

                    Dim symbolDetails As String = "(" + i.ToString() + ") " + "Candidate 1: '" + candidate1 + "' (" + (Math.Round(_GdPictureImaging.MICRGetSymbolConfidence(i, 1), 1)).ToString() + "%). " + _
                                                                              "Candidate 2: '" + candidate2 + "' (" + (Math.Round(_GdPictureImaging.MICRGetSymbolConfidence(i, 2), 1)).ToString() + "%)."

                    sb.Append(symbolDetails + vbCrLf)
                End If
            Next
            txtResults.Text = sb.ToString()
        Else
            txtResults.Text = "Error: " + status.ToString()
        End If
    End Sub
End Class