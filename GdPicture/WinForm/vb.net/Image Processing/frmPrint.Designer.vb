<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.cmbPrintAlignment = New System.Windows.Forms.ComboBox()
        Me.chkCollate = New System.Windows.Forms.CheckBox()
        Me.rbPageRangeSelection = New System.Windows.Forms.RadioButton()
        Me.rbPageRangeAll = New System.Windows.Forms.RadioButton()
        Me.txtPageRangeEnd = New System.Windows.Forms.TextBox()
        Me.lblPageRangeTo = New System.Windows.Forms.Label()
        Me.txtPageRangeStart = New System.Windows.Forms.TextBox()
        Me.rbPageRangePages = New System.Windows.Forms.RadioButton()
        Me.lblPrintAlignment = New System.Windows.Forms.Label()
        Me.grpPageRange = New System.Windows.Forms.GroupBox()
        Me.rbPageRangeCurrent = New System.Windows.Forms.RadioButton()
        Me.rbOrientationLandscape = New System.Windows.Forms.RadioButton()
        Me.rbOrientationPortrait = New System.Windows.Forms.RadioButton()
        Me.rbOrientationAutomatic = New System.Windows.Forms.RadioButton()
        Me.cmbPrintSize = New System.Windows.Forms.ComboBox()
        Me.btnPrinterProperties = New System.Windows.Forms.Button()
        Me.lblPrintSize = New System.Windows.Forms.Label()
        Me.cmbPrinterList = New System.Windows.Forms.ComboBox()
        Me.lblCopies = New System.Windows.Forms.Label()
        Me.lblPrinter = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grpOrientation = New System.Windows.Forms.GroupBox()
        Me.numCopies = New System.Windows.Forms.NumericUpDown()
        Me.grpPageRange.SuspendLayout()
        Me.grpOrientation.SuspendLayout()
        CType(Me.numCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbPrintAlignment
        '
        Me.cmbPrintAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrintAlignment.FormattingEnabled = True
        Me.cmbPrintAlignment.Location = New System.Drawing.Point(138, 93)
        Me.cmbPrintAlignment.Name = "cmbPrintAlignment"
        Me.cmbPrintAlignment.Size = New System.Drawing.Size(198, 21)
        Me.cmbPrintAlignment.TabIndex = 24
        '
        'chkCollate
        '
        Me.chkCollate.AutoSize = True
        Me.chkCollate.Location = New System.Drawing.Point(205, 43)
        Me.chkCollate.Name = "chkCollate"
        Me.chkCollate.Size = New System.Drawing.Size(58, 17)
        Me.chkCollate.TabIndex = 22
        Me.chkCollate.Text = "Collate"
        Me.chkCollate.UseVisualStyleBackColor = True
        '
        'rbPageRangeSelection
        '
        Me.rbPageRangeSelection.AutoSize = True
        Me.rbPageRangeSelection.Enabled = False
        Me.rbPageRangeSelection.Location = New System.Drawing.Point(13, 45)
        Me.rbPageRangeSelection.Name = "rbPageRangeSelection"
        Me.rbPageRangeSelection.Size = New System.Drawing.Size(100, 17)
        Me.rbPageRangeSelection.TabIndex = 13
        Me.rbPageRangeSelection.TabStop = True
        Me.rbPageRangeSelection.Text = "Checked pages"
        Me.rbPageRangeSelection.UseVisualStyleBackColor = True
        '
        'rbPageRangeAll
        '
        Me.rbPageRangeAll.AutoSize = True
        Me.rbPageRangeAll.Checked = True
        Me.rbPageRangeAll.Location = New System.Drawing.Point(13, 21)
        Me.rbPageRangeAll.Name = "rbPageRangeAll"
        Me.rbPageRangeAll.Size = New System.Drawing.Size(36, 17)
        Me.rbPageRangeAll.TabIndex = 12
        Me.rbPageRangeAll.TabStop = True
        Me.rbPageRangeAll.Text = "All"
        Me.rbPageRangeAll.UseVisualStyleBackColor = True
        '
        'txtPageRangeEnd
        '
        Me.txtPageRangeEnd.Location = New System.Drawing.Point(169, 68)
        Me.txtPageRangeEnd.Name = "txtPageRangeEnd"
        Me.txtPageRangeEnd.Size = New System.Drawing.Size(42, 20)
        Me.txtPageRangeEnd.TabIndex = 17
        '
        'lblPageRangeTo
        '
        Me.lblPageRangeTo.AutoSize = True
        Me.lblPageRangeTo.Location = New System.Drawing.Point(146, 73)
        Me.lblPageRangeTo.Name = "lblPageRangeTo"
        Me.lblPageRangeTo.Size = New System.Drawing.Size(16, 13)
        Me.lblPageRangeTo.TabIndex = 16
        Me.lblPageRangeTo.Text = "to"
        Me.lblPageRangeTo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPageRangeStart
        '
        Me.txtPageRangeStart.Location = New System.Drawing.Point(98, 68)
        Me.txtPageRangeStart.Name = "txtPageRangeStart"
        Me.txtPageRangeStart.Size = New System.Drawing.Size(42, 20)
        Me.txtPageRangeStart.TabIndex = 16
        '
        'rbPageRangePages
        '
        Me.rbPageRangePages.AutoSize = True
        Me.rbPageRangePages.Enabled = False
        Me.rbPageRangePages.Location = New System.Drawing.Point(13, 69)
        Me.rbPageRangePages.Name = "rbPageRangePages"
        Me.rbPageRangePages.Size = New System.Drawing.Size(78, 17)
        Me.rbPageRangePages.TabIndex = 15
        Me.rbPageRangePages.TabStop = True
        Me.rbPageRangePages.Text = "Pages from"
        Me.rbPageRangePages.UseVisualStyleBackColor = True
        '
        'lblPrintAlignment
        '
        Me.lblPrintAlignment.AutoSize = True
        Me.lblPrintAlignment.Location = New System.Drawing.Point(10, 96)
        Me.lblPrintAlignment.Name = "lblPrintAlignment"
        Me.lblPrintAlignment.Size = New System.Drawing.Size(53, 13)
        Me.lblPrintAlignment.TabIndex = 31
        Me.lblPrintAlignment.Text = "Alignment"
        '
        'grpPageRange
        '
        Me.grpPageRange.Controls.Add(Me.txtPageRangeEnd)
        Me.grpPageRange.Controls.Add(Me.lblPageRangeTo)
        Me.grpPageRange.Controls.Add(Me.txtPageRangeStart)
        Me.grpPageRange.Controls.Add(Me.rbPageRangePages)
        Me.grpPageRange.Controls.Add(Me.rbPageRangeCurrent)
        Me.grpPageRange.Controls.Add(Me.rbPageRangeSelection)
        Me.grpPageRange.Controls.Add(Me.rbPageRangeAll)
        Me.grpPageRange.Location = New System.Drawing.Point(234, 120)
        Me.grpPageRange.Name = "grpPageRange"
        Me.grpPageRange.Size = New System.Drawing.Size(288, 100)
        Me.grpPageRange.TabIndex = 28
        Me.grpPageRange.TabStop = False
        Me.grpPageRange.Text = "Page range"
        '
        'rbPageRangeCurrent
        '
        Me.rbPageRangeCurrent.AutoSize = True
        Me.rbPageRangeCurrent.Enabled = False
        Me.rbPageRangeCurrent.Location = New System.Drawing.Point(149, 21)
        Me.rbPageRangeCurrent.Name = "rbPageRangeCurrent"
        Me.rbPageRangeCurrent.Size = New System.Drawing.Size(86, 17)
        Me.rbPageRangeCurrent.TabIndex = 14
        Me.rbPageRangeCurrent.TabStop = True
        Me.rbPageRangeCurrent.Text = "Current page"
        Me.rbPageRangeCurrent.UseVisualStyleBackColor = True
        '
        'rbOrientationLandscape
        '
        Me.rbOrientationLandscape.AutoSize = True
        Me.rbOrientationLandscape.Location = New System.Drawing.Point(13, 68)
        Me.rbOrientationLandscape.Name = "rbOrientationLandscape"
        Me.rbOrientationLandscape.Size = New System.Drawing.Size(78, 17)
        Me.rbOrientationLandscape.TabIndex = 10
        Me.rbOrientationLandscape.Text = "Landscape"
        Me.rbOrientationLandscape.UseVisualStyleBackColor = True
        '
        'rbOrientationPortrait
        '
        Me.rbOrientationPortrait.AutoSize = True
        Me.rbOrientationPortrait.Location = New System.Drawing.Point(13, 45)
        Me.rbOrientationPortrait.Name = "rbOrientationPortrait"
        Me.rbOrientationPortrait.Size = New System.Drawing.Size(58, 17)
        Me.rbOrientationPortrait.TabIndex = 9
        Me.rbOrientationPortrait.Text = "Portrait"
        Me.rbOrientationPortrait.UseVisualStyleBackColor = True
        '
        'rbOrientationAutomatic
        '
        Me.rbOrientationAutomatic.AutoSize = True
        Me.rbOrientationAutomatic.Checked = True
        Me.rbOrientationAutomatic.Location = New System.Drawing.Point(13, 22)
        Me.rbOrientationAutomatic.Name = "rbOrientationAutomatic"
        Me.rbOrientationAutomatic.Size = New System.Drawing.Size(72, 17)
        Me.rbOrientationAutomatic.TabIndex = 8
        Me.rbOrientationAutomatic.TabStop = True
        Me.rbOrientationAutomatic.Text = "Automatic"
        Me.rbOrientationAutomatic.UseVisualStyleBackColor = True
        '
        'cmbPrintSize
        '
        Me.cmbPrintSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrintSize.FormattingEnabled = True
        Me.cmbPrintSize.Location = New System.Drawing.Point(138, 66)
        Me.cmbPrintSize.Name = "cmbPrintSize"
        Me.cmbPrintSize.Size = New System.Drawing.Size(198, 21)
        Me.cmbPrintSize.TabIndex = 23
        '
        'btnPrinterProperties
        '
        Me.btnPrinterProperties.Location = New System.Drawing.Point(415, 11)
        Me.btnPrinterProperties.Name = "btnPrinterProperties"
        Me.btnPrinterProperties.Size = New System.Drawing.Size(107, 23)
        Me.btnPrinterProperties.TabIndex = 21
        Me.btnPrinterProperties.Text = "Properties"
        Me.btnPrinterProperties.UseVisualStyleBackColor = True
        '
        'lblPrintSize
        '
        Me.lblPrintSize.AutoSize = True
        Me.lblPrintSize.Location = New System.Drawing.Point(10, 69)
        Me.lblPrintSize.Name = "lblPrintSize"
        Me.lblPrintSize.Size = New System.Drawing.Size(49, 13)
        Me.lblPrintSize.TabIndex = 29
        Me.lblPrintSize.Text = "Print size"
        '
        'cmbPrinterList
        '
        Me.cmbPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrinterList.FormattingEnabled = True
        Me.cmbPrinterList.Location = New System.Drawing.Point(138, 12)
        Me.cmbPrinterList.Name = "cmbPrinterList"
        Me.cmbPrinterList.Size = New System.Drawing.Size(271, 21)
        Me.cmbPrinterList.TabIndex = 20
        '
        'lblCopies
        '
        Me.lblCopies.AutoSize = True
        Me.lblCopies.Location = New System.Drawing.Point(10, 41)
        Me.lblCopies.Name = "lblCopies"
        Me.lblCopies.Size = New System.Drawing.Size(39, 13)
        Me.lblCopies.TabIndex = 27
        Me.lblCopies.Text = "Copies"
        '
        'lblPrinter
        '
        Me.lblPrinter.AutoSize = True
        Me.lblPrinter.Location = New System.Drawing.Point(10, 15)
        Me.lblPrinter.Name = "lblPrinter"
        Me.lblPrinter.Size = New System.Drawing.Size(37, 13)
        Me.lblPrinter.TabIndex = 25
        Me.lblPrinter.Text = "Printer"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(447, 236)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(363, 236)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 23)
        Me.btnPrint.TabIndex = 30
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'grpOrientation
        '
        Me.grpOrientation.Controls.Add(Me.rbOrientationLandscape)
        Me.grpOrientation.Controls.Add(Me.rbOrientationPortrait)
        Me.grpOrientation.Controls.Add(Me.rbOrientationAutomatic)
        Me.grpOrientation.Location = New System.Drawing.Point(13, 120)
        Me.grpOrientation.Name = "grpOrientation"
        Me.grpOrientation.Size = New System.Drawing.Size(200, 100)
        Me.grpOrientation.TabIndex = 26
        Me.grpOrientation.TabStop = False
        Me.grpOrientation.Text = "Orientation"
        '
        'numCopies
        '
        Me.numCopies.Location = New System.Drawing.Point(138, 39)
        Me.numCopies.Name = "numCopies"
        Me.numCopies.Size = New System.Drawing.Size(61, 20)
        Me.numCopies.TabIndex = 33
        Me.numCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 273)
        Me.Controls.Add(Me.numCopies)
        Me.Controls.Add(Me.cmbPrintAlignment)
        Me.Controls.Add(Me.chkCollate)
        Me.Controls.Add(Me.lblPrintAlignment)
        Me.Controls.Add(Me.grpPageRange)
        Me.Controls.Add(Me.cmbPrintSize)
        Me.Controls.Add(Me.btnPrinterProperties)
        Me.Controls.Add(Me.lblPrintSize)
        Me.Controls.Add(Me.cmbPrinterList)
        Me.Controls.Add(Me.lblCopies)
        Me.Controls.Add(Me.lblPrinter)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grpOrientation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print"
        Me.grpPageRange.ResumeLayout(False)
        Me.grpPageRange.PerformLayout()
        Me.grpOrientation.ResumeLayout(False)
        Me.grpOrientation.PerformLayout()
        CType(Me.numCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPrintAlignment As System.Windows.Forms.ComboBox
    Friend WithEvents chkCollate As System.Windows.Forms.CheckBox
    Friend WithEvents rbPageRangeSelection As System.Windows.Forms.RadioButton
    Friend WithEvents rbPageRangeAll As System.Windows.Forms.RadioButton
    Friend WithEvents txtPageRangeEnd As System.Windows.Forms.TextBox
    Friend WithEvents lblPageRangeTo As System.Windows.Forms.Label
    Friend WithEvents txtPageRangeStart As System.Windows.Forms.TextBox
    Friend WithEvents rbPageRangePages As System.Windows.Forms.RadioButton
    Friend WithEvents lblPrintAlignment As System.Windows.Forms.Label
    Friend WithEvents grpPageRange As System.Windows.Forms.GroupBox
    Friend WithEvents rbPageRangeCurrent As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrientationLandscape As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrientationPortrait As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrientationAutomatic As System.Windows.Forms.RadioButton
    Friend WithEvents cmbPrintSize As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrinterProperties As System.Windows.Forms.Button
    Friend WithEvents lblPrintSize As System.Windows.Forms.Label
    Friend WithEvents cmbPrinterList As System.Windows.Forms.ComboBox
    Friend WithEvents lblCopies As System.Windows.Forms.Label
    Friend WithEvents lblPrinter As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents grpOrientation As System.Windows.Forms.GroupBox
    Friend WithEvents numCopies As System.Windows.Forms.NumericUpDown
End Class
