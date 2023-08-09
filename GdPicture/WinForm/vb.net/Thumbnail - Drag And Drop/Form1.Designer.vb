<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ThumbnailEx2 = New GdPicture14.ThumbnailEx()
        Me.ThumbnailEx1 = New GdPicture14.ThumbnailEx()
        Me.chkMoveAfter = New System.Windows.Forms.CheckBox()
        Me.chkIncludeSubfolders = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 678)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(368, 63)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Load From Directory..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ThumbnailEx2
        '
        Me.ThumbnailEx2.AllowDrop = True
        Me.ThumbnailEx2.AllowDropFiles = False
        Me.ThumbnailEx2.AllowMoveItems = False
        Me.ThumbnailEx2.BackColor = System.Drawing.SystemColors.Control
        Me.ThumbnailEx2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ThumbnailEx2.CheckBoxes = False
        Me.ThumbnailEx2.CheckBoxesMarginLeft = 0
        Me.ThumbnailEx2.CheckBoxesMarginTop = 0
        Me.ThumbnailEx2.DefaultItemTextPrefix = "Page "
        Me.ThumbnailEx2.DisplayAnnotations = True
        Me.ThumbnailEx2.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        Me.ThumbnailEx2.HotTracking = False
        Me.ThumbnailEx2.Location = New System.Drawing.Point(769, 15)
        Me.ThumbnailEx2.LockGdViewerEvents = False
        Me.ThumbnailEx2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ThumbnailEx2.MultiSelect = True
        Me.ThumbnailEx2.Name = "ThumbnailEx2"
        Me.ThumbnailEx2.OwnDrop = True
        Me.ThumbnailEx2.PauseThumbsLoading = False
        Me.ThumbnailEx2.PdfIncreaseTextContrast = False
        Me.ThumbnailEx2.PreloadAllItems = True
        Me.ThumbnailEx2.RotateExif = True
        Me.ThumbnailEx2.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThumbnailEx2.ShowText = True
        Me.ThumbnailEx2.Size = New System.Drawing.Size(732, 655)
        Me.ThumbnailEx2.TabIndex = 1
        Me.ThumbnailEx2.TextMarginLeft = 0
        Me.ThumbnailEx2.TextMarginTop = 0
        Me.ThumbnailEx2.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical
        Me.ThumbnailEx2.ThumbnailBorder = True
        Me.ThumbnailEx2.ThumbnailForeColor = System.Drawing.Color.Black
        Me.ThumbnailEx2.ThumbnailSize = New System.Drawing.Size(128, 128)
        Me.ThumbnailEx2.ThumbnailSpacing = New System.Drawing.Size(0, 0)
        Me.ThumbnailEx2.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        '
        'ThumbnailEx1
        '
        Me.ThumbnailEx1.AllowDrop = True
        Me.ThumbnailEx1.AllowDropFiles = False
        Me.ThumbnailEx1.AllowMoveItems = False
        Me.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control
        Me.ThumbnailEx1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ThumbnailEx1.CheckBoxes = False
        Me.ThumbnailEx1.CheckBoxesMarginLeft = 0
        Me.ThumbnailEx1.CheckBoxesMarginTop = 0
        Me.ThumbnailEx1.DefaultItemTextPrefix = "Page "
        Me.ThumbnailEx1.DisplayAnnotations = True
        Me.ThumbnailEx1.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        Me.ThumbnailEx1.HotTracking = False
        Me.ThumbnailEx1.Location = New System.Drawing.Point(16, 15)
        Me.ThumbnailEx1.LockGdViewerEvents = False
        Me.ThumbnailEx1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ThumbnailEx1.MultiSelect = True
        Me.ThumbnailEx1.Name = "ThumbnailEx1"
        Me.ThumbnailEx1.OwnDrop = True
        Me.ThumbnailEx1.PauseThumbsLoading = False
        Me.ThumbnailEx1.PdfIncreaseTextContrast = False
        Me.ThumbnailEx1.PreloadAllItems = True
        Me.ThumbnailEx1.RotateExif = True
        Me.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThumbnailEx1.ShowText = True
        Me.ThumbnailEx1.Size = New System.Drawing.Size(732, 655)
        Me.ThumbnailEx1.TabIndex = 0
        Me.ThumbnailEx1.TextMarginLeft = 0
        Me.ThumbnailEx1.TextMarginTop = 0
        Me.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical
        Me.ThumbnailEx1.ThumbnailBorder = True
        Me.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Black
        Me.ThumbnailEx1.ThumbnailSize = New System.Drawing.Size(128, 128)
        Me.ThumbnailEx1.ThumbnailSpacing = New System.Drawing.Size(0, 0)
        Me.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        '
        'chkMoveAfter
        '
        Me.chkMoveAfter.AutoSize = True
        Me.chkMoveAfter.Location = New System.Drawing.Point(392, 678)
        Me.chkMoveAfter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMoveAfter.Name = "chkMoveAfter"
        Me.chkMoveAfter.Size = New System.Drawing.Size(170, 21)
        Me.chkMoveAfter.TabIndex = 3
        Me.chkMoveAfter.Text = "Move after destination"
        Me.chkMoveAfter.UseVisualStyleBackColor = True
        '
        'chkIncludeSubfolders
        '
        Me.chkIncludeSubfolders.AutoSize = True
        Me.chkIncludeSubfolders.Location = New System.Drawing.Point(392, 706)
        Me.chkIncludeSubfolders.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkIncludeSubfolders.Name = "chkIncludeSubfolders"
        Me.chkIncludeSubfolders.Size = New System.Drawing.Size(145, 21)
        Me.chkIncludeSubfolders.TabIndex = 4
        Me.chkIncludeSubfolders.Text = "Include subfolders"
        Me.chkIncludeSubfolders.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1520, 770)
        Me.Controls.Add(Me.chkIncludeSubfolders)
        Me.Controls.Add(Me.chkMoveAfter)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ThumbnailEx2)
        Me.Controls.Add(Me.ThumbnailEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Thumbnail drag & drop Demo  -  http://www.gdpicture.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ThumbnailEx1 As GdPicture14.ThumbnailEx
    Friend WithEvents ThumbnailEx2 As GdPicture14.ThumbnailEx
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkMoveAfter As System.Windows.Forms.CheckBox
    Friend WithEvents chkIncludeSubfolders As System.Windows.Forms.CheckBox

End Class
