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
        Me.lstTemplatesView = New System.Windows.Forms.ListView()
        Me.colTemplateName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTemplateID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTemplateImgCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btSaveADRConfig = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btLoadADRConfig = New System.Windows.Forms.Button()
        Me.btNewTemplate = New System.Windows.Forms.Button()
        Me.btAddTemplateImage = New System.Windows.Forms.Button()
        Me.btDeleteTemplate = New System.Windows.Forms.Button()
        Me.btClearConfig = New System.Windows.Forms.Button()
        Me.btIdentifyDocument = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstTemplatesView
        '
        Me.lstTemplatesView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTemplateName, Me.colTemplateID, Me.colTemplateImgCount})
        Me.lstTemplatesView.FullRowSelect = True
        Me.lstTemplatesView.GridLines = True
        Me.lstTemplatesView.HideSelection = False
        Me.lstTemplatesView.Location = New System.Drawing.Point(21, 54)
        Me.lstTemplatesView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstTemplatesView.MultiSelect = False
        Me.lstTemplatesView.Name = "lstTemplatesView"
        Me.lstTemplatesView.Size = New System.Drawing.Size(543, 368)
        Me.lstTemplatesView.TabIndex = 0
        Me.lstTemplatesView.UseCompatibleStateImageBehavior = False
        Me.lstTemplatesView.View = System.Windows.Forms.View.Details
        '
        'colTemplateName
        '
        Me.colTemplateName.Text = "Template Name"
        Me.colTemplateName.Width = 256
        '
        'colTemplateID
        '
        Me.colTemplateID.Text = "ID"
        Me.colTemplateID.Width = 67
        '
        'colTemplateImgCount
        '
        Me.colTemplateImgCount.Text = "Image Count"
        Me.colTemplateImgCount.Width = 79
        '
        'btSaveADRConfig
        '
        Me.btSaveADRConfig.Location = New System.Drawing.Point(415, 431)
        Me.btSaveADRConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btSaveADRConfig.Name = "btSaveADRConfig"
        Me.btSaveADRConfig.Size = New System.Drawing.Size(152, 42)
        Me.btSaveADRConfig.TabIndex = 1
        Me.btSaveADRConfig.Text = "Save config. to file"
        Me.btSaveADRConfig.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ADR Templates Overview"
        '
        'btLoadADRConfig
        '
        Me.btLoadADRConfig.Location = New System.Drawing.Point(255, 431)
        Me.btLoadADRConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btLoadADRConfig.Name = "btLoadADRConfig"
        Me.btLoadADRConfig.Size = New System.Drawing.Size(152, 42)
        Me.btLoadADRConfig.TabIndex = 3
        Me.btLoadADRConfig.Text = "Load config. from file"
        Me.btLoadADRConfig.UseVisualStyleBackColor = True
        '
        'btNewTemplate
        '
        Me.btNewTemplate.Location = New System.Drawing.Point(584, 54)
        Me.btNewTemplate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btNewTemplate.Name = "btNewTemplate"
        Me.btNewTemplate.Size = New System.Drawing.Size(157, 39)
        Me.btNewTemplate.TabIndex = 4
        Me.btNewTemplate.Text = "Create new template"
        Me.btNewTemplate.UseVisualStyleBackColor = True
        '
        'btAddTemplateImage
        '
        Me.btAddTemplateImage.Location = New System.Drawing.Point(584, 101)
        Me.btAddTemplateImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btAddTemplateImage.Name = "btAddTemplateImage"
        Me.btAddTemplateImage.Size = New System.Drawing.Size(157, 54)
        Me.btAddTemplateImage.TabIndex = 5
        Me.btAddTemplateImage.Text = "add image to template"
        Me.btAddTemplateImage.UseVisualStyleBackColor = True
        '
        'btDeleteTemplate
        '
        Me.btDeleteTemplate.Location = New System.Drawing.Point(584, 162)
        Me.btDeleteTemplate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btDeleteTemplate.Name = "btDeleteTemplate"
        Me.btDeleteTemplate.Size = New System.Drawing.Size(157, 39)
        Me.btDeleteTemplate.TabIndex = 6
        Me.btDeleteTemplate.Text = "Delete template"
        Me.btDeleteTemplate.UseVisualStyleBackColor = True
        '
        'btClearConfig
        '
        Me.btClearConfig.Location = New System.Drawing.Point(21, 431)
        Me.btClearConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btClearConfig.Name = "btClearConfig"
        Me.btClearConfig.Size = New System.Drawing.Size(152, 42)
        Me.btClearConfig.TabIndex = 7
        Me.btClearConfig.Text = "Clear config."
        Me.btClearConfig.UseVisualStyleBackColor = True
        '
        'btIdentifyDocument
        '
        Me.btIdentifyDocument.Location = New System.Drawing.Point(21, 517)
        Me.btIdentifyDocument.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btIdentifyDocument.Name = "btIdentifyDocument"
        Me.btIdentifyDocument.Size = New System.Drawing.Size(720, 89)
        Me.btIdentifyDocument.TabIndex = 8
        Me.btIdentifyDocument.Text = "Identify Document..."
        Me.btIdentifyDocument.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 619)
        Me.Controls.Add(Me.btIdentifyDocument)
        Me.Controls.Add(Me.btClearConfig)
        Me.Controls.Add(Me.btDeleteTemplate)
        Me.Controls.Add(Me.btAddTemplateImage)
        Me.Controls.Add(Me.btNewTemplate)
        Me.Controls.Add(Me.btLoadADRConfig)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSaveADRConfig)
        Me.Controls.Add(Me.lstTemplatesView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "GdPicture.NET - Document Recognition Sample  -  http://www.gdpicture.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTemplatesView As System.Windows.Forms.ListView
    Friend WithEvents colTemplateName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTemplateID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTemplateImgCount As System.Windows.Forms.ColumnHeader
    Friend WithEvents btSaveADRConfig As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btLoadADRConfig As System.Windows.Forms.Button
    Friend WithEvents btNewTemplate As System.Windows.Forms.Button
    Friend WithEvents btAddTemplateImage As System.Windows.Forms.Button
    Friend WithEvents btDeleteTemplate As System.Windows.Forms.Button
    Friend WithEvents btClearConfig As System.Windows.Forms.Button
    Friend WithEvents btIdentifyDocument As System.Windows.Forms.Button

End Class
