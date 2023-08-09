Option Strict On
Option Explicit On


Imports GdPicture14

Public Class Form1
    Dim m_GdPictureImaging As New GdPictureImaging
    Dim m_TemplateImg As Integer = 0
    Dim m_ROILeft As Integer
    Dim m_ROITop As Integer
    Dim m_ROIWidth As Integer
    Dim m_ROIHeight As Integer
    Dim m_CurrentImage As Integer

    Dim m_TemplateAnchor As IntPtr

    Dim m_AnchorLeft As Integer
    Dim m_AnchorTop As Integer
    Dim m_AnchorWidth As Integer
    Dim m_AnchorHeight As Integer



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim licMgr As New GdPicture14.LicenseManager()
        licMgr.RegisterKEY("XXX") 'Please replace XXX by a valid demo or commercial key.
    End Sub



    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            If m_CurrentImage <> 0 Then m_GdPictureImaging.ReleaseGdPictureImage(m_CurrentImage)
            GdViewer1.CloseDocument()
            GdViewer1.RemoveAllRegions()
            m_CurrentImage = m_GdPictureImaging.CreateGdPictureImageFromFile(CStr(ListBox1.Items(ListBox1.SelectedIndex)))
            GdViewer1.DisplayFromGdPictureImage(m_CurrentImage)
            FindAnchor()
        End If
    End Sub

    Private Sub FindAnchor()
        Dim anchor_left As Integer = 0
        Dim anchor_top As Integer = 0
        Dim anchor_width As Integer = 0
        Dim anchor_height As Integer = 0
        Dim accuracy As Double = 0
        Dim Mode As GdPicture14.OMRMode = GdPicture14.OMRMode.FavorQuality
        If Me.CheckBox1.Checked Then Mode = GdPicture14.OMRMode.FavorSpeed

        Dim status As Integer = m_GdPictureImaging.FindAnchor(m_CurrentImage, m_TemplateAnchor, Mode, m_ROILeft, m_ROITop, m_ROIWidth, m_ROIHeight, anchor_left, anchor_top, anchor_width, anchor_height, accuracy)

        If status <> 0 Then MsgBox("error: " & Str(status))
        GdViewer1.AddRegion("anchor", anchor_left, anchor_top, anchor_width, anchor_height, GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Blue)
        Text = "Accuracy: " & Str(accuracy) & "%"
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GdViewer2.MouseMode = GdPicture14.ViewerMouseMode.MouseModeAreaSelection
        If m_TemplateImg <> 0 Then
            m_GdPictureImaging.ReleaseGdPictureImage(m_TemplateImg)
            GdViewer2.CloseDocument()
        End If
        m_TemplateImg = m_GdPictureImaging.CreateGdPictureImageFromFile("")
        If m_TemplateImg <> 0 Then
            GdViewer2.DisplayFromGdPictureImage(m_TemplateImg)
        End If
    End Sub

    Private Sub GdViewer2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GdViewer2.MouseUp
        If GdViewer2.IsRect Then
            GdViewer2.RemoveAllRegions()
            GdViewer2.GetRectCoordinatesOnDocument(m_AnchorLeft, m_AnchorTop, m_AnchorWidth, m_AnchorHeight)
            Dim regID As Integer = GdViewer2.AddRegion("anchor", m_AnchorLeft, m_AnchorTop, m_AnchorWidth, m_AnchorHeight, GdPicture14.ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Green)
            GdViewer2.SetRegionBorderWidth(regID, 1)
            GdViewer2.SetRegionBorderColor(regID, Color.Blue)
            GdViewer2.Redraw()
            GdViewer2.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
            ShowRegionSize()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex <> 0 Then
            If m_TemplateImg = 0 Then
                MessageBox.Show("Please load a template image before navigating to another tab.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TabControl1.SelectedIndex = 0
            Else
                If GdViewer2.RegionCount = 0 Then
                    MessageBox.Show("Please draw an anchor on the template image before navigating to another tab.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TabControl1.SelectedIndex = 0
                Else
                    'Getting the anchor data as 24bpp bitonal area
                    Dim RegID As Integer = GdViewer2.GetRegionID(1)
                    m_AnchorLeft = CInt(GdViewer2.GetRegionLeft(RegID) * GdViewer2.HorizontalResolution)
                    m_AnchorTop = CInt(GdViewer2.GetRegionTop(RegID) * GdViewer2.VerticalResolution)
                    m_AnchorWidth = CInt(GdViewer2.GetRegionWidth(RegID) * GdViewer2.HorizontalResolution)
                    m_AnchorHeight = CInt(GdViewer2.GetRegionHeight(RegID) * GdViewer2.VerticalResolution)

                    m_ROIWidth = CInt(NumericUpDown1.Value / 25.4 * GdViewer2.HorizontalResolution)
                    m_ROIHeight = CInt(NumericUpDown2.Value / 25.4 * GdViewer2.VerticalResolution)
                    m_ROILeft = CInt((m_AnchorLeft + m_AnchorWidth / 2) - (m_ROIWidth / 2))
                    m_ROITop = CInt((m_AnchorTop + m_AnchorHeight / 2) - (m_ROIHeight / 2))

                    If m_TemplateAnchor <> IntPtr.Zero Then
                        m_GdPictureImaging.DeleteAnchorTemplate(m_TemplateAnchor)
                    End If

                    m_TemplateAnchor = m_GdPictureImaging.CreateAnchorTemplate(m_TemplateImg, m_AnchorLeft, m_AnchorTop, m_AnchorWidth, m_AnchorHeight)

                    If m_CurrentImage <> 0 Then 'Refresh current image if any
                        GdViewer1.RemoveAllRegions()
                        FindAnchor()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TabControl1_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl1.Selecting
        If Not e.TabPage.Enabled Then
            e.Cancel = True
        End If
    End Sub

    Private Sub GdViewer2_RegionEditedByUser(ByVal RegionID As Integer) Handles GdViewer2.RegionEditedByUser
        ShowRegionSize()
    End Sub

    Private Sub ShowRegionSize()
        Dim RegionID As Integer = GdViewer2.GetRegionID(1)
        Dim AWidth As Integer = CInt(Math.Round(GdViewer2.GetRegionWidth(RegionID) * 25.4))
        Dim AHeight As Integer = CInt(Math.Round(GdViewer2.GetRegionHeight(RegionID) * 25.4))

        If NumericUpDown1.Value < AWidth Then
            NumericUpDown1.Value = CInt(Math.Round(AWidth * 1.1))
        End If
        If NumericUpDown2.Value < AHeight Then
            NumericUpDown2.Value = CInt(Math.Round(AHeight * 1.1))
        End If
        Text = "Anchor width: " & Str(AWidth) & " mm" & " - Anchor height: " & Str(AHeight) & " mm"
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        GdViewer1.CloseDocument()
        If m_CurrentImage <> 0 Then
            m_GdPictureImaging.ReleaseGdPictureImage(m_CurrentImage)
            m_CurrentImage = 0
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityLow
        For i As Integer = 0 To Me.ListBox1.Items.Count - 1
            Me.ListBox1.SelectedIndex = i
            Application.DoEvents()
        Next
        GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.ShowDialog(Me)
        For Each item As String In OpenFileDialog1.FileNames
            If GdPictureDocumentUtilities.GetDocumentFormat(item) <> GdPicture14.DocumentFormat.DocumentFormatUNKNOWN Then _
               ListBox1.Items.Add(item)
        Next
    End Sub

End Class
