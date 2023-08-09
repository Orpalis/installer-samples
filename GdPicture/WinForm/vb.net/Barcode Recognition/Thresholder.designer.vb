<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Thresholder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cmbBinarizationMode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.scroll3Panel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.scroll2Panel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.scroll1Panel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMinDifVal = New System.Windows.Forms.TextBox()
        Me.scrlContrastParam = New System.Windows.Forms.HScrollBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtThresholdMin = New System.Windows.Forms.Label()
        Me.scrlThresoldParam = New System.Windows.Forms.HScrollBar()
        Me.txtThresholdMax = New System.Windows.Forms.Label()
        Me.txtThreshVal = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtKernelVal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.scrlKernelParam = New System.Windows.Forms.HScrollBar()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.scroll3Panel.SuspendLayout()
        Me.scroll2Panel.SuspendLayout()
        Me.scroll1Panel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(475, 186)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'cmbBinarizationMode
        '
        Me.cmbBinarizationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBinarizationMode.FormattingEnabled = True
        Me.cmbBinarizationMode.Items.AddRange(New Object() {"Linear" & Global.Microsoft.VisualBasic.ChrW(9), "Adaptive (Modified Bradley)", "Adaptive (Modified Otsu)", "Sauvola"})
        Me.cmbBinarizationMode.Location = New System.Drawing.Point(93, 34)
        Me.cmbBinarizationMode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbBinarizationMode.Name = "cmbBinarizationMode"
        Me.cmbBinarizationMode.Size = New System.Drawing.Size(265, 21)
        Me.cmbBinarizationMode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Binarization"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.scroll3Panel, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.scroll2Panel, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'scroll3Panel
        '
        Me.scroll3Panel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scroll3Panel.ColumnCount = 5
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.27928!))
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.72072!))
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225.0!))
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.scroll3Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.scroll3Panel.Controls.Add(Me.Label5, 1, 0)
        Me.scroll3Panel.Controls.Add(Me.Label3, 0, 0)
        Me.scroll3Panel.Controls.Add(Me.Label7, 3, 0)
        Me.scroll3Panel.Location = New System.Drawing.Point(3, 43)
        Me.scroll3Panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.scroll3Panel.Name = "scroll3Panel"
        Me.scroll3Panel.RowCount = 1
        Me.scroll3Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scroll3Panel.Size = New System.Drawing.Size(94, 34)
        Me.scroll3Panel.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-213, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Smooth Kernel"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-44, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "5"
        '
        'scroll2Panel
        '
        Me.scroll2Panel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scroll2Panel.ColumnCount = 5
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.81818!))
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.scroll2Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.scroll2Panel.Controls.Add(Me.Label4, 1, 0)
        Me.scroll2Panel.Controls.Add(Me.Label2, 0, 0)
        Me.scroll2Panel.Controls.Add(Me.Label6, 3, 0)
        Me.scroll2Panel.Location = New System.Drawing.Point(103, 2)
        Me.scroll2Panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.scroll2Panel.Name = "scroll2Panel"
        Me.scroll2Panel.RowCount = 1
        Me.scroll2Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scroll2Panel.Size = New System.Drawing.Size(94, 16)
        Me.scroll2Panel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-205, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contrast Dif. Min"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-35, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "255"
        '
        'scroll1Panel
        '
        Me.scroll1Panel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scroll1Panel.ColumnCount = 5
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.27928!))
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.72072!))
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225.0!))
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.scroll1Panel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.scroll1Panel.Controls.Add(Me.Label8, 0, 0)
        Me.scroll1Panel.Location = New System.Drawing.Point(3, 80)
        Me.scroll1Panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.scroll1Panel.Name = "scroll1Panel"
        Me.scroll1Panel.RowCount = 1
        Me.scroll1Panel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.scroll1Panel.Size = New System.Drawing.Size(471, 34)
        Me.scroll1Panel.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Threshold"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 68)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(450, 147)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.24675!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.75325!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(440, 131)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel6.ColumnCount = 5
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.78992!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.21008!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.txtMinDifVal, 4, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.scrlContrastParam, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label12, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label14, 3, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 98)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(416, 28)
        Me.TableLayoutPanel6.TabIndex = 3
        Me.TableLayoutPanel6.Visible = False
        '
        'txtMinDifVal
        '
        Me.txtMinDifVal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMinDifVal.Enabled = False
        Me.txtMinDifVal.Location = New System.Drawing.Point(325, 4)
        Me.txtMinDifVal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMinDifVal.Name = "txtMinDifVal"
        Me.txtMinDifVal.Size = New System.Drawing.Size(75, 20)
        Me.txtMinDifVal.TabIndex = 5
        Me.txtMinDifVal.Text = "50"
        '
        'scrlContrastParam
        '
        Me.scrlContrastParam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scrlContrastParam.LargeChange = 1
        Me.scrlContrastParam.Location = New System.Drawing.Point(93, 1)
        Me.scrlContrastParam.Maximum = 255
        Me.scrlContrastParam.Name = "scrlContrastParam"
        Me.scrlContrastParam.Size = New System.Drawing.Size(191, 26)
        Me.scrlContrastParam.TabIndex = 3
        Me.scrlContrastParam.Value = 50
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "0"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 26)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Contrast Dif. Min"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(288, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "255"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel7.ColumnCount = 5
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.04918!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.95082!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtThresholdMin, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.scrlThresoldParam, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtThresholdMax, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtThreshVal, 4, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 11)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(416, 28)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Threshold"
        '
        'txtThresholdMin
        '
        Me.txtThresholdMin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtThresholdMin.AutoSize = True
        Me.txtThresholdMin.Location = New System.Drawing.Point(73, 7)
        Me.txtThresholdMin.Name = "txtThresholdMin"
        Me.txtThresholdMin.Size = New System.Drawing.Size(13, 13)
        Me.txtThresholdMin.TabIndex = 1
        Me.txtThresholdMin.Text = "0"
        '
        'scrlThresoldParam
        '
        Me.scrlThresoldParam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scrlThresoldParam.LargeChange = 1
        Me.scrlThresoldParam.Location = New System.Drawing.Point(90, 1)
        Me.scrlThresoldParam.Maximum = 254
        Me.scrlThresoldParam.Minimum = 1
        Me.scrlThresoldParam.Name = "scrlThresoldParam"
        Me.scrlThresoldParam.Size = New System.Drawing.Size(190, 26)
        Me.scrlThresoldParam.TabIndex = 2
        Me.scrlThresoldParam.Value = 128
        '
        'txtThresholdMax
        '
        Me.txtThresholdMax.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtThresholdMax.AutoSize = True
        Me.txtThresholdMax.Location = New System.Drawing.Point(287, 7)
        Me.txtThresholdMax.Name = "txtThresholdMax"
        Me.txtThresholdMax.Size = New System.Drawing.Size(25, 13)
        Me.txtThresholdMax.TabIndex = 3
        Me.txtThresholdMax.Text = "254"
        '
        'txtThreshVal
        '
        Me.txtThreshVal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtThreshVal.Enabled = False
        Me.txtThreshVal.Location = New System.Drawing.Point(325, 4)
        Me.txtThreshVal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtThreshVal.Name = "txtThreshVal"
        Me.txtThreshVal.Size = New System.Drawing.Size(75, 20)
        Me.txtThreshVal.TabIndex = 4
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.63025!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.36975!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txtKernelVal, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.scrlKernelParam, 2, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 57)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(416, 28)
        Me.TableLayoutPanel5.TabIndex = 2
        Me.TableLayoutPanel5.Visible = False
        '
        'txtKernelVal
        '
        Me.txtKernelVal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtKernelVal.Enabled = False
        Me.txtKernelVal.Location = New System.Drawing.Point(325, 4)
        Me.txtKernelVal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKernelVal.Name = "txtKernelVal"
        Me.txtKernelVal.Size = New System.Drawing.Size(75, 20)
        Me.txtKernelVal.TabIndex = 5
        Me.txtKernelVal.Text = "2"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(74, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 26)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Smooth Kernel"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(287, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "5"
        '
        'scrlKernelParam
        '
        Me.scrlKernelParam.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.scrlKernelParam.LargeChange = 1
        Me.scrlKernelParam.Location = New System.Drawing.Point(93, 1)
        Me.scrlKernelParam.Maximum = 5
        Me.scrlKernelParam.Name = "scrlKernelParam"
        Me.scrlKernelParam.Size = New System.Drawing.Size(190, 26)
        Me.scrlKernelParam.TabIndex = 3
        Me.scrlKernelParam.Value = 2
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(11, 36)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(88, 4)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(631, 225)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBinarizationMode)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Threshold..."
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.scroll3Panel.ResumeLayout(False)
        Me.scroll3Panel.PerformLayout()
        Me.scroll2Panel.ResumeLayout(False)
        Me.scroll2Panel.PerformLayout()
        Me.scroll1Panel.ResumeLayout(False)
        Me.scroll1Panel.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cmbBinarizationMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents scroll3Panel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents scroll2Panel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents scroll1Panel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtKernelVal As System.Windows.Forms.TextBox
    Friend WithEvents scrlKernelParam As System.Windows.Forms.HScrollBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtThresholdMin As System.Windows.Forms.Label
    Friend WithEvents scrlThresoldParam As System.Windows.Forms.HScrollBar
    Friend WithEvents txtThresholdMax As System.Windows.Forms.Label
    Friend WithEvents txtThreshVal As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtMinDifVal As System.Windows.Forms.TextBox
    Friend WithEvents scrlContrastParam As System.Windows.Forms.HScrollBar
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
