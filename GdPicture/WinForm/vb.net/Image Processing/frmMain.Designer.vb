<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.tcLeftPanel = New System.Windows.Forms.TabControl()
        Me.tpThumbnails = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.thumbnailPanelToolstrip = New System.Windows.Forms.ToolStrip()
        Me.btnThumbSize = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LargeThumbnailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumThumbnailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallThumbnailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThumbnailEx1 = New GdPicture14.ThumbnailEx()
        Me.tpImageProperties = New System.Windows.Forms.TabPage()
        Me.pImageProperties = New System.Windows.Forms.Panel()
        Me.tvImageProperties = New System.Windows.Forms.TreeView()
        Me.tpAdjustment = New System.Windows.Forms.TabPage()
        Me.pAdjustment = New System.Windows.Forms.Panel()
        Me.pAdjustPreview = New System.Windows.Forms.Panel()
        Me.adjustPeviewViewer = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnResetAdjustment = New System.Windows.Forms.Button()
        Me.btnApplyAdjustment = New System.Windows.Forms.Button()
        Me.gpBlue = New System.Windows.Forms.GroupBox()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.tbBlue = New System.Windows.Forms.TrackBar()
        Me.pbBlue = New System.Windows.Forms.PictureBox()
        Me.gpGreen = New System.Windows.Forms.GroupBox()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.tbGreen = New System.Windows.Forms.TrackBar()
        Me.pbGreen = New System.Windows.Forms.PictureBox()
        Me.gpRed = New System.Windows.Forms.GroupBox()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.tbRed = New System.Windows.Forms.TrackBar()
        Me.pbRed = New System.Windows.Forms.PictureBox()
        Me.gpGamma = New System.Windows.Forms.GroupBox()
        Me.lblGamma = New System.Windows.Forms.Label()
        Me.tbGamma = New System.Windows.Forms.TrackBar()
        Me.pbGamma = New System.Windows.Forms.PictureBox()
        Me.gpSaturation = New System.Windows.Forms.GroupBox()
        Me.lblSaturation = New System.Windows.Forms.Label()
        Me.tbSaturation = New System.Windows.Forms.TrackBar()
        Me.pbSaturation = New System.Windows.Forms.PictureBox()
        Me.gpContrast = New System.Windows.Forms.GroupBox()
        Me.lblContrast = New System.Windows.Forms.Label()
        Me.tbContrast = New System.Windows.Forms.TrackBar()
        Me.pbContrast = New System.Windows.Forms.PictureBox()
        Me.grpBrightness = New System.Windows.Forms.GroupBox()
        Me.tbBrightness = New System.Windows.Forms.TrackBar()
        Me.lblBrightness = New System.Windows.Forms.Label()
        Me.pbBrightness = New System.Windows.Forms.PictureBox()
        Me.tpTransform = New System.Windows.Forms.TabPage()
        Me.pTransform = New System.Windows.Forms.Panel()
        Me.gpRotation = New System.Windows.Forms.GroupBox()
        Me.pCustomAngle = New System.Windows.Forms.Panel()
        Me.pRotationPreview = New System.Windows.Forms.Panel()
        Me.rotationPeviewViewer = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbFlipVertical = New System.Windows.Forms.RadioButton()
        Me.rbFlipHorizontal = New System.Windows.Forms.RadioButton()
        Me.rbRotateCustomAngle = New System.Windows.Forms.RadioButton()
        Me.rbRotateRight = New System.Windows.Forms.RadioButton()
        Me.pbRotationBackColor = New System.Windows.Forms.PictureBox()
        Me.rbRotateLeft = New System.Windows.Forms.RadioButton()
        Me.chkKeepImageDimensionRotation = New System.Windows.Forms.CheckBox()
        Me.lblCustomRotationBackgroundColor = New System.Windows.Forms.Label()
        Me.chkRotateFromCenter = New System.Windows.Forms.CheckBox()
        Me.nRotationAngle = New System.Windows.Forms.NumericUpDown()
        Me.btnApplyRotation = New System.Windows.Forms.Button()
        Me.gpImageSize = New System.Windows.Forms.GroupBox()
        Me.btnResetSize = New System.Windows.Forms.Button()
        Me.btnApplySize = New System.Windows.Forms.Button()
        Me.gpDocumentSize = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.nVerticalResolution = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nHorizontalResolution = New System.Windows.Forms.NumericUpDown()
        Me.nDocumentHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nDocumentWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gpPixelDimensions = New System.Windows.Forms.GroupBox()
        Me.nHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkKeepAspectRatio = New System.Windows.Forms.CheckBox()
        Me.rbResize = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nScalePercent = New System.Windows.Forms.NumericUpDown()
        Me.rbScalePercent = New System.Windows.Forms.RadioButton()
        Me.cbResampling = New System.Windows.Forms.ComboBox()
        Me.lblResampling = New System.Windows.Forms.Label()
        Me.tpColorOperations = New System.Windows.Forms.TabPage()
        Me.pColorOperations = New System.Windows.Forms.Panel()
        Me.gpColorChannelsManipulation = New System.Windows.Forms.GroupBox()
        Me.pColorChannelsViewer = New System.Windows.Forms.Panel()
        Me.colorChannelPreviewViewer = New System.Windows.Forms.PictureBox()
        Me.pColorManipulation = New System.Windows.Forms.Panel()
        Me.btnResetColorChannels = New System.Windows.Forms.Button()
        Me.btnApplyColorChannels = New System.Windows.Forms.Button()
        Me.pRemoveComponent = New System.Windows.Forms.Panel()
        Me.rbRemoveBlue = New System.Windows.Forms.RadioButton()
        Me.rbRemoveGreen = New System.Windows.Forms.RadioButton()
        Me.rbRemoveRed = New System.Windows.Forms.RadioButton()
        Me.rbRemoveComponent = New System.Windows.Forms.RadioButton()
        Me.pScaleColors = New System.Windows.Forms.Panel()
        Me.pScaleBlue = New System.Windows.Forms.Panel()
        Me.lblScaleBlue = New System.Windows.Forms.Label()
        Me.tbScaleBlue = New System.Windows.Forms.TrackBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pScaleRed = New System.Windows.Forms.Panel()
        Me.lblScaleRed = New System.Windows.Forms.Label()
        Me.tbScaleRed = New System.Windows.Forms.TrackBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pScaleGreen = New System.Windows.Forms.Panel()
        Me.lblScaleGreen = New System.Windows.Forms.Label()
        Me.tbScaleGreen = New System.Windows.Forms.TrackBar()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.rbScaleComponent = New System.Windows.Forms.RadioButton()
        Me.pKeepComponent = New System.Windows.Forms.Panel()
        Me.rbKeepBlue = New System.Windows.Forms.RadioButton()
        Me.rbKeepGreen = New System.Windows.Forms.RadioButton()
        Me.rbKeepRed = New System.Windows.Forms.RadioButton()
        Me.rbKeepComponent = New System.Windows.Forms.RadioButton()
        Me.pSwapColors = New System.Windows.Forms.Panel()
        Me.cbSwapColor = New System.Windows.Forms.ComboBox()
        Me.rbSwapColor = New System.Windows.Forms.RadioButton()
        Me.gpPixelFormat = New System.Windows.Forms.GroupBox()
        Me.btnApplyPixelConversion = New System.Windows.Forms.Button()
        Me.cbPixelConversion = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tpEffects = New System.Windows.Forms.TabPage()
        Me.pEffects = New System.Windows.Forms.Panel()
        Me.pEffectsPreview = New System.Windows.Forms.Panel()
        Me.GdViewer2 = New GdPicture14.GdViewer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pConfigurableEffects = New System.Windows.Forms.Panel()
        Me.pFloodFillEffect = New System.Windows.Forms.Panel()
        Me.pbFloodFillEffectColor = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nFloodFillEffectYStart = New System.Windows.Forms.NumericUpDown()
        Me.nFloodFillEffectXStart = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.pFactorEffect = New System.Windows.Forms.Panel()
        Me.nFactorEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblFactorEffect = New System.Windows.Forms.Label()
        Me.pSubstractBackgroundEffect = New System.Windows.Forms.Panel()
        Me.chkLightBackgroundEffect = New System.Windows.Forms.CheckBox()
        Me.nRollingBallSizeEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblRollingBallSizeEffect = New System.Windows.Forms.Label()
        Me.pSoftenValueEffect = New System.Windows.Forms.Panel()
        Me.nSoftenValueEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblSoftenValueEffect = New System.Windows.Forms.Label()
        Me.pRemoveBackgroundChromokeyEffect = New System.Windows.Forms.Panel()
        Me.nMinKeyValueEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblMinKeyValueEffect = New System.Windows.Forms.Label()
        Me.nVariationEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblVariationEffect = New System.Windows.Forms.Label()
        Me.cbComponentEffect = New System.Windows.Forms.ComboBox()
        Me.lblComponentEffect = New System.Windows.Forms.Label()
        Me.pWavesEffect = New System.Windows.Forms.Panel()
        Me.nHeightEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblHeightEffect = New System.Windows.Forms.Label()
        Me.nWidthEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblWidthEffect = New System.Windows.Forms.Label()
        Me.pHaloEffect = New System.Windows.Forms.Panel()
        Me.lblRadiusEffect = New System.Windows.Forms.Label()
        Me.lblTopEffect = New System.Windows.Forms.Label()
        Me.nRadiusEffect = New System.Windows.Forms.NumericUpDown()
        Me.nTopEffect = New System.Windows.Forms.NumericUpDown()
        Me.nLeftEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblLeftEffect = New System.Windows.Forms.Label()
        Me.pKernelSizeEffect = New System.Windows.Forms.Panel()
        Me.nKernelSizeEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblKernelSizeEffect = New System.Windows.Forms.Label()
        Me.pColorizeEffect = New System.Windows.Forms.Panel()
        Me.nLuminosityEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblLuminosityEffect = New System.Windows.Forms.Label()
        Me.nSaturationEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblSaturationEffect = New System.Windows.Forms.Label()
        Me.nHueEffect = New System.Windows.Forms.NumericUpDown()
        Me.lblHueEffect = New System.Windows.Forms.Label()
        Me.cbConfigurableEffects = New System.Windows.Forms.ComboBox()
        Me.rbConfigurableEffects = New System.Windows.Forms.RadioButton()
        Me.pDirectEffects = New System.Windows.Forms.Panel()
        Me.cbDirectEffects = New System.Windows.Forms.ComboBox()
        Me.rbDirectEffects = New System.Windows.Forms.RadioButton()
        Me.btnResetEffects = New System.Windows.Forms.Button()
        Me.btnApplyEffects = New System.Windows.Forms.Button()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblSnapInPanel = New System.Windows.Forms.Label()
        Me.pSnapInButtons = New System.Windows.Forms.Panel()
        Me.btnSnapInThumbnails = New System.Windows.Forms.Button()
        Me.btnSnapInImageProperties = New System.Windows.Forms.Button()
        Me.btnSnapInAdjustment = New System.Windows.Forms.Button()
        Me.btnSnapInTransform = New System.Windows.Forms.Button()
        Me.btnSnapInColorOperations = New System.Windows.Forms.Button()
        Me.btnSnapInEffects = New System.Windows.Forms.Button()
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.statusbar = New System.Windows.Forms.StatusStrip()
        Me.lblImageInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblImageSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMousePosition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCopyToClipboard = New System.Windows.Forms.ToolStripButton()
        Me.btnImportFromClipboard = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnMouseMode = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaZoomingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagnifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFirstPage = New System.Windows.Forms.ToolStripButton()
        Me.btnPreviousPage = New System.Windows.Forms.ToolStripButton()
        Me.tbCurrentPage = New System.Windows.Forms.ToolStripTextBox()
        Me.lblPageCount = New System.Windows.Forms.ToolStripLabel()
        Me.btnNextPage = New System.Windows.Forms.ToolStripButton()
        Me.btnLastPage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.cbZoom = New System.Windows.Forms.ToolStripComboBox()
        Me.btnZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFitWidth = New System.Windows.Forms.ToolStripButton()
        Me.btnFitPage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAbout = New System.Windows.Forms.ToolStripButton()
        Me.pMain = New System.Windows.Forms.Panel()
        Me.rbConvolutionMatrix = New System.Windows.Forms.RadioButton()
        Me.cbConvolutionMatrix = New System.Windows.Forms.ComboBox()
        Me.tcLeftPanel.SuspendLayout
        Me.tpThumbnails.SuspendLayout
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout
        Me.ToolStripContainer1.ContentPanel.SuspendLayout
        Me.ToolStripContainer1.SuspendLayout
        Me.thumbnailPanelToolstrip.SuspendLayout
        Me.tpImageProperties.SuspendLayout
        Me.pImageProperties.SuspendLayout
        Me.tpAdjustment.SuspendLayout
        Me.pAdjustment.SuspendLayout
        Me.pAdjustPreview.SuspendLayout
        CType(Me.adjustPeviewViewer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel8.SuspendLayout
        Me.gpBlue.SuspendLayout
        CType(Me.tbBlue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbBlue,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gpGreen.SuspendLayout
        CType(Me.tbGreen,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbGreen,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gpRed.SuspendLayout
        CType(Me.tbRed,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbRed,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gpGamma.SuspendLayout
        CType(Me.tbGamma,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbGamma,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gpSaturation.SuspendLayout
        CType(Me.tbSaturation,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbSaturation,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gpContrast.SuspendLayout
        CType(Me.tbContrast,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbContrast,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpBrightness.SuspendLayout
        CType(Me.tbBrightness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbBrightness,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpTransform.SuspendLayout
        Me.pTransform.SuspendLayout
        Me.gpRotation.SuspendLayout
        Me.pCustomAngle.SuspendLayout
        Me.pRotationPreview.SuspendLayout
        CType(Me.rotationPeviewViewer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        CType(Me.pbRotationBackColor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nRotationAngle,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gpImageSize.SuspendLayout
        Me.gpDocumentSize.SuspendLayout
        CType(Me.nVerticalResolution,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nHorizontalResolution,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nDocumentHeight,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nDocumentWidth,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gpPixelDimensions.SuspendLayout
        CType(Me.nHeight,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nWidth,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nScalePercent,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tpColorOperations.SuspendLayout
        Me.pColorOperations.SuspendLayout
        Me.gpColorChannelsManipulation.SuspendLayout
        Me.pColorChannelsViewer.SuspendLayout
        CType(Me.colorChannelPreviewViewer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pColorManipulation.SuspendLayout
        Me.pRemoveComponent.SuspendLayout
        Me.pScaleColors.SuspendLayout
        Me.pScaleBlue.SuspendLayout
        CType(Me.tbScaleBlue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pScaleRed.SuspendLayout
        CType(Me.tbScaleRed,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pScaleGreen.SuspendLayout
        CType(Me.tbScaleGreen,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pKeepComponent.SuspendLayout
        Me.pSwapColors.SuspendLayout
        Me.gpPixelFormat.SuspendLayout
        Me.tpEffects.SuspendLayout
        Me.pEffects.SuspendLayout
        Me.pEffectsPreview.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.pConfigurableEffects.SuspendLayout
        Me.pFloodFillEffect.SuspendLayout
        CType(Me.pbFloodFillEffectColor,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nFloodFillEffectYStart,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nFloodFillEffectXStart,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pFactorEffect.SuspendLayout
        CType(Me.nFactorEffect,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pSubstractBackgroundEffect.SuspendLayout
        CType(Me.nRollingBallSizeEffect,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pSoftenValueEffect.SuspendLayout
        CType(Me.nSoftenValueEffect,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pRemoveBackgroundChromokeyEffect.SuspendLayout
        CType(Me.nMinKeyValueEffect,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nVariationEffect,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pWavesEffect.SuspendLayout
        CType(Me.nHeightEffect,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nWidthEffect,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pHaloEffect.SuspendLayout
        CType(Me.nRadiusEffect,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nTopEffect,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nLeftEffect,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pKernelSizeEffect.SuspendLayout
        CType(Me.nKernelSizeEffect,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pColorizeEffect.SuspendLayout
        CType(Me.nLuminosityEffect,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nSaturationEffect,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nHueEffect,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pDirectEffects.SuspendLayout
        CType(Me.scMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.scMain.Panel1.SuspendLayout
        Me.scMain.Panel2.SuspendLayout
        Me.scMain.SuspendLayout
        Me.Panel6.SuspendLayout
        Me.Panel9.SuspendLayout
        Me.Panel7.SuspendLayout
        Me.pSnapInButtons.SuspendLayout
        Me.statusbar.SuspendLayout
        Me.mainToolStrip.SuspendLayout
        Me.pMain.SuspendLayout
        Me.SuspendLayout
        '
        'tcLeftPanel
        '
        Me.tcLeftPanel.Controls.Add(Me.tpThumbnails)
        Me.tcLeftPanel.Controls.Add(Me.tpImageProperties)
        Me.tcLeftPanel.Controls.Add(Me.tpAdjustment)
        Me.tcLeftPanel.Controls.Add(Me.tpTransform)
        Me.tcLeftPanel.Controls.Add(Me.tpColorOperations)
        Me.tcLeftPanel.Controls.Add(Me.tpEffects)
        Me.tcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcLeftPanel.Location = New System.Drawing.Point(0, 49)
        Me.tcLeftPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.tcLeftPanel.Multiline = true
        Me.tcLeftPanel.Name = "tcLeftPanel"
        Me.tcLeftPanel.Padding = New System.Drawing.Point(0, 0)
        Me.tcLeftPanel.SelectedIndex = 0
        Me.tcLeftPanel.Size = New System.Drawing.Size(338, 1396)
        Me.tcLeftPanel.TabIndex = 1
        '
        'tpThumbnails
        '
        Me.tpThumbnails.Controls.Add(Me.ToolStripContainer1)
        Me.tpThumbnails.Location = New System.Drawing.Point(4, 54)
        Me.tpThumbnails.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpThumbnails.Name = "tpThumbnails"
        Me.tpThumbnails.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpThumbnails.Size = New System.Drawing.Size(330, 956)
        Me.tpThumbnails.TabIndex = 5
        Me.tpThumbnails.Text = "Thumbnails"
        Me.tpThumbnails.UseVisualStyleBackColor = true
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.thumbnailPanelToolstrip)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ThumbnailEx1)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(322, 890)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(4, 5)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(322, 946)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'thumbnailPanelToolstrip
        '
        Me.thumbnailPanelToolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.thumbnailPanelToolstrip.Dock = System.Windows.Forms.DockStyle.None
        Me.thumbnailPanelToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.thumbnailPanelToolstrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.thumbnailPanelToolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThumbSize})
        Me.thumbnailPanelToolstrip.Location = New System.Drawing.Point(0, 0)
        Me.thumbnailPanelToolstrip.Name = "thumbnailPanelToolstrip"
        Me.thumbnailPanelToolstrip.Padding = New System.Windows.Forms.Padding(0)
        Me.thumbnailPanelToolstrip.Size = New System.Drawing.Size(322, 31)
        Me.thumbnailPanelToolstrip.Stretch = true
        Me.thumbnailPanelToolstrip.TabIndex = 0
        '
        'btnThumbSize
        '
        Me.btnThumbSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnThumbSize.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LargeThumbnailsToolStripMenuItem1, Me.MediumThumbnailsToolStripMenuItem1, Me.SmallThumbnailsToolStripMenuItem1})
        Me.btnThumbSize.Image = CType(resources.GetObject("btnThumbSize.Image"),System.Drawing.Image)
        Me.btnThumbSize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThumbSize.Name = "btnThumbSize"
        Me.btnThumbSize.Size = New System.Drawing.Size(42, 28)
        Me.btnThumbSize.Text = "btnThumbnailSize"
        Me.btnThumbSize.ToolTipText = "Thumbnail size"
        '
        'LargeThumbnailsToolStripMenuItem1
        '
        Me.LargeThumbnailsToolStripMenuItem1.Checked = true
        Me.LargeThumbnailsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LargeThumbnailsToolStripMenuItem1.Name = "LargeThumbnailsToolStripMenuItem1"
        Me.LargeThumbnailsToolStripMenuItem1.Size = New System.Drawing.Size(256, 30)
        Me.LargeThumbnailsToolStripMenuItem1.Text = "Large thumbnails"
        '
        'MediumThumbnailsToolStripMenuItem1
        '
        Me.MediumThumbnailsToolStripMenuItem1.Name = "MediumThumbnailsToolStripMenuItem1"
        Me.MediumThumbnailsToolStripMenuItem1.Size = New System.Drawing.Size(256, 30)
        Me.MediumThumbnailsToolStripMenuItem1.Text = "Medium thumbnails"
        '
        'SmallThumbnailsToolStripMenuItem1
        '
        Me.SmallThumbnailsToolStripMenuItem1.Name = "SmallThumbnailsToolStripMenuItem1"
        Me.SmallThumbnailsToolStripMenuItem1.Size = New System.Drawing.Size(256, 30)
        Me.SmallThumbnailsToolStripMenuItem1.Text = "Small thumbnails"
        '
        'ThumbnailEx1
        '
        Me.ThumbnailEx1.AllowDropFiles = false
        Me.ThumbnailEx1.AllowMoveItems = false
        Me.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control
        Me.ThumbnailEx1.CheckBoxes = false
        Me.ThumbnailEx1.CheckBoxesMarginLeft = 0
        Me.ThumbnailEx1.CheckBoxesMarginTop = 0
        Me.ThumbnailEx1.DisplayAnnotations = true
        Me.ThumbnailEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThumbnailEx1.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        Me.ThumbnailEx1.HotTracking = false
        Me.ThumbnailEx1.Location = New System.Drawing.Point(0, 0)
        Me.ThumbnailEx1.LockGdViewerEvents = false
        Me.ThumbnailEx1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ThumbnailEx1.MultiSelect = false
        Me.ThumbnailEx1.Name = "ThumbnailEx1"
        Me.ThumbnailEx1.OwnDrop = false
        Me.ThumbnailEx1.PauseThumbsLoading = false
        Me.ThumbnailEx1.PdfIncreaseTextContrast = false
        Me.ThumbnailEx1.PreloadAllItems = true
        Me.ThumbnailEx1.RotateExif = true
        Me.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(CType(CType(51,Byte),Integer), CType(CType(153,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.ThumbnailEx1.ShowText = true
        Me.ThumbnailEx1.Size = New System.Drawing.Size(322, 890)
        Me.ThumbnailEx1.TabIndex = 0
        Me.ThumbnailEx1.TextMarginLeft = 0
        Me.ThumbnailEx1.TextMarginTop = 0
        Me.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical
        Me.ThumbnailEx1.ThumbnailBorder = true
        Me.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Black
        Me.ThumbnailEx1.ThumbnailSize = New System.Drawing.Size(256, 256)
        Me.ThumbnailEx1.ThumbnailSpacing = New System.Drawing.Size(0, 0)
        Me.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        '
        'tpImageProperties
        '
        Me.tpImageProperties.BackColor = System.Drawing.SystemColors.Control
        Me.tpImageProperties.Controls.Add(Me.pImageProperties)
        Me.tpImageProperties.Location = New System.Drawing.Point(4, 54)
        Me.tpImageProperties.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpImageProperties.Name = "tpImageProperties"
        Me.tpImageProperties.Size = New System.Drawing.Size(330, 956)
        Me.tpImageProperties.TabIndex = 0
        Me.tpImageProperties.Text = "Image properties"
        '
        'pImageProperties
        '
        Me.pImageProperties.Controls.Add(Me.tvImageProperties)
        Me.pImageProperties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pImageProperties.Location = New System.Drawing.Point(0, 0)
        Me.pImageProperties.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pImageProperties.Name = "pImageProperties"
        Me.pImageProperties.Size = New System.Drawing.Size(330, 956)
        Me.pImageProperties.TabIndex = 3
        '
        'tvImageProperties
        '
        Me.tvImageProperties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvImageProperties.Location = New System.Drawing.Point(0, 0)
        Me.tvImageProperties.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tvImageProperties.Name = "tvImageProperties"
        Me.tvImageProperties.Size = New System.Drawing.Size(330, 956)
        Me.tvImageProperties.TabIndex = 0
        '
        'tpAdjustment
        '
        Me.tpAdjustment.BackColor = System.Drawing.SystemColors.Control
        Me.tpAdjustment.Controls.Add(Me.pAdjustment)
        Me.tpAdjustment.Location = New System.Drawing.Point(4, 54)
        Me.tpAdjustment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpAdjustment.Name = "tpAdjustment"
        Me.tpAdjustment.Size = New System.Drawing.Size(330, 956)
        Me.tpAdjustment.TabIndex = 1
        Me.tpAdjustment.Text = "Adjustment"
        '
        'pAdjustment
        '
        Me.pAdjustment.Controls.Add(Me.pAdjustPreview)
        Me.pAdjustment.Controls.Add(Me.Panel8)
        Me.pAdjustment.Controls.Add(Me.gpBlue)
        Me.pAdjustment.Controls.Add(Me.gpGreen)
        Me.pAdjustment.Controls.Add(Me.gpRed)
        Me.pAdjustment.Controls.Add(Me.gpGamma)
        Me.pAdjustment.Controls.Add(Me.gpSaturation)
        Me.pAdjustment.Controls.Add(Me.gpContrast)
        Me.pAdjustment.Controls.Add(Me.grpBrightness)
        Me.pAdjustment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pAdjustment.Location = New System.Drawing.Point(0, 0)
        Me.pAdjustment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pAdjustment.Name = "pAdjustment"
        Me.pAdjustment.Size = New System.Drawing.Size(330, 956)
        Me.pAdjustment.TabIndex = 1
        '
        'pAdjustPreview
        '
        Me.pAdjustPreview.Controls.Add(Me.adjustPeviewViewer)
        Me.pAdjustPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pAdjustPreview.Location = New System.Drawing.Point(0, 700)
        Me.pAdjustPreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pAdjustPreview.Name = "pAdjustPreview"
        Me.pAdjustPreview.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.pAdjustPreview.Size = New System.Drawing.Size(330, 207)
        Me.pAdjustPreview.TabIndex = 1
        '
        'adjustPeviewViewer
        '
        Me.adjustPeviewViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adjustPeviewViewer.Location = New System.Drawing.Point(0, 8)
        Me.adjustPeviewViewer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.adjustPeviewViewer.Name = "adjustPeviewViewer"
        Me.adjustPeviewViewer.Size = New System.Drawing.Size(330, 199)
        Me.adjustPeviewViewer.TabIndex = 0
        Me.adjustPeviewViewer.TabStop = false
        '
        'Panel8
        '
        Me.Panel8.AutoSize = true
        Me.Panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel8.Controls.Add(Me.btnResetAdjustment)
        Me.Panel8.Controls.Add(Me.btnApplyAdjustment)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 907)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.Panel8.Size = New System.Drawing.Size(330, 49)
        Me.Panel8.TabIndex = 8
        '
        'btnResetAdjustment
        '
        Me.btnResetAdjustment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnResetAdjustment.Location = New System.Drawing.Point(91, 9)
        Me.btnResetAdjustment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnResetAdjustment.Name = "btnResetAdjustment"
        Me.btnResetAdjustment.Size = New System.Drawing.Size(112, 35)
        Me.btnResetAdjustment.TabIndex = 1
        Me.btnResetAdjustment.Text = "Reset"
        Me.btnResetAdjustment.UseVisualStyleBackColor = true
        '
        'btnApplyAdjustment
        '
        Me.btnApplyAdjustment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnApplyAdjustment.Location = New System.Drawing.Point(213, 9)
        Me.btnApplyAdjustment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApplyAdjustment.Name = "btnApplyAdjustment"
        Me.btnApplyAdjustment.Size = New System.Drawing.Size(112, 35)
        Me.btnApplyAdjustment.TabIndex = 0
        Me.btnApplyAdjustment.Text = "Apply"
        Me.btnApplyAdjustment.UseVisualStyleBackColor = true
        '
        'gpBlue
        '
        Me.gpBlue.Controls.Add(Me.lblBlue)
        Me.gpBlue.Controls.Add(Me.tbBlue)
        Me.gpBlue.Controls.Add(Me.pbBlue)
        Me.gpBlue.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpBlue.Location = New System.Drawing.Point(0, 600)
        Me.gpBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpBlue.Name = "gpBlue"
        Me.gpBlue.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpBlue.Size = New System.Drawing.Size(330, 100)
        Me.gpBlue.TabIndex = 6
        Me.gpBlue.TabStop = false
        Me.gpBlue.Text = "Blue"
        '
        'lblBlue
        '
        Me.lblBlue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBlue.Location = New System.Drawing.Point(52, 75)
        Me.lblBlue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(274, 20)
        Me.lblBlue.TabIndex = 1
        Me.lblBlue.Text = "0"
        Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbBlue
        '
        Me.tbBlue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbBlue.Location = New System.Drawing.Point(52, 24)
        Me.tbBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBlue.Maximum = 255
        Me.tbBlue.Minimum = -255
        Me.tbBlue.Name = "tbBlue"
        Me.tbBlue.Size = New System.Drawing.Size(274, 71)
        Me.tbBlue.TabIndex = 0
        Me.tbBlue.TickFrequency = 0
        '
        'pbBlue
        '
        Me.pbBlue.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbBlue.Image = CType(resources.GetObject("pbBlue.Image"),System.Drawing.Image)
        Me.pbBlue.Location = New System.Drawing.Point(4, 24)
        Me.pbBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbBlue.Name = "pbBlue"
        Me.pbBlue.Size = New System.Drawing.Size(48, 71)
        Me.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbBlue.TabIndex = 3
        Me.pbBlue.TabStop = false
        '
        'gpGreen
        '
        Me.gpGreen.Controls.Add(Me.lblGreen)
        Me.gpGreen.Controls.Add(Me.tbGreen)
        Me.gpGreen.Controls.Add(Me.pbGreen)
        Me.gpGreen.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpGreen.Location = New System.Drawing.Point(0, 500)
        Me.gpGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpGreen.Name = "gpGreen"
        Me.gpGreen.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpGreen.Size = New System.Drawing.Size(330, 100)
        Me.gpGreen.TabIndex = 5
        Me.gpGreen.TabStop = false
        Me.gpGreen.Text = "Green"
        '
        'lblGreen
        '
        Me.lblGreen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblGreen.Location = New System.Drawing.Point(52, 75)
        Me.lblGreen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(274, 20)
        Me.lblGreen.TabIndex = 1
        Me.lblGreen.Text = "0"
        Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbGreen
        '
        Me.tbGreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbGreen.Location = New System.Drawing.Point(52, 24)
        Me.tbGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbGreen.Maximum = 255
        Me.tbGreen.Minimum = -255
        Me.tbGreen.Name = "tbGreen"
        Me.tbGreen.Size = New System.Drawing.Size(274, 71)
        Me.tbGreen.TabIndex = 0
        Me.tbGreen.TickFrequency = 0
        '
        'pbGreen
        '
        Me.pbGreen.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbGreen.Image = CType(resources.GetObject("pbGreen.Image"),System.Drawing.Image)
        Me.pbGreen.Location = New System.Drawing.Point(4, 24)
        Me.pbGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbGreen.Name = "pbGreen"
        Me.pbGreen.Size = New System.Drawing.Size(48, 71)
        Me.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbGreen.TabIndex = 3
        Me.pbGreen.TabStop = false
        '
        'gpRed
        '
        Me.gpRed.Controls.Add(Me.lblRed)
        Me.gpRed.Controls.Add(Me.tbRed)
        Me.gpRed.Controls.Add(Me.pbRed)
        Me.gpRed.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpRed.Location = New System.Drawing.Point(0, 400)
        Me.gpRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpRed.Name = "gpRed"
        Me.gpRed.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpRed.Size = New System.Drawing.Size(330, 100)
        Me.gpRed.TabIndex = 7
        Me.gpRed.TabStop = false
        Me.gpRed.Text = "Red"
        '
        'lblRed
        '
        Me.lblRed.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblRed.Location = New System.Drawing.Point(52, 75)
        Me.lblRed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(274, 20)
        Me.lblRed.TabIndex = 1
        Me.lblRed.Text = "0"
        Me.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbRed
        '
        Me.tbRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbRed.Location = New System.Drawing.Point(52, 24)
        Me.tbRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbRed.Maximum = 255
        Me.tbRed.Minimum = -255
        Me.tbRed.Name = "tbRed"
        Me.tbRed.Size = New System.Drawing.Size(274, 71)
        Me.tbRed.TabIndex = 0
        Me.tbRed.TickFrequency = 0
        '
        'pbRed
        '
        Me.pbRed.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbRed.Image = CType(resources.GetObject("pbRed.Image"),System.Drawing.Image)
        Me.pbRed.Location = New System.Drawing.Point(4, 24)
        Me.pbRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbRed.Name = "pbRed"
        Me.pbRed.Size = New System.Drawing.Size(48, 71)
        Me.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbRed.TabIndex = 3
        Me.pbRed.TabStop = false
        '
        'gpGamma
        '
        Me.gpGamma.Controls.Add(Me.lblGamma)
        Me.gpGamma.Controls.Add(Me.tbGamma)
        Me.gpGamma.Controls.Add(Me.pbGamma)
        Me.gpGamma.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpGamma.Location = New System.Drawing.Point(0, 300)
        Me.gpGamma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpGamma.Name = "gpGamma"
        Me.gpGamma.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpGamma.Size = New System.Drawing.Size(330, 100)
        Me.gpGamma.TabIndex = 4
        Me.gpGamma.TabStop = false
        Me.gpGamma.Text = "Gamma"
        '
        'lblGamma
        '
        Me.lblGamma.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblGamma.Location = New System.Drawing.Point(52, 75)
        Me.lblGamma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGamma.Name = "lblGamma"
        Me.lblGamma.Size = New System.Drawing.Size(274, 20)
        Me.lblGamma.TabIndex = 1
        Me.lblGamma.Text = "0"
        Me.lblGamma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbGamma
        '
        Me.tbGamma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbGamma.Location = New System.Drawing.Point(52, 24)
        Me.tbGamma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbGamma.Maximum = 100
        Me.tbGamma.Minimum = -100
        Me.tbGamma.Name = "tbGamma"
        Me.tbGamma.Size = New System.Drawing.Size(274, 71)
        Me.tbGamma.TabIndex = 0
        Me.tbGamma.TickFrequency = 0
        '
        'pbGamma
        '
        Me.pbGamma.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbGamma.Image = CType(resources.GetObject("pbGamma.Image"),System.Drawing.Image)
        Me.pbGamma.Location = New System.Drawing.Point(4, 24)
        Me.pbGamma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbGamma.Name = "pbGamma"
        Me.pbGamma.Size = New System.Drawing.Size(48, 71)
        Me.pbGamma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbGamma.TabIndex = 3
        Me.pbGamma.TabStop = false
        '
        'gpSaturation
        '
        Me.gpSaturation.Controls.Add(Me.lblSaturation)
        Me.gpSaturation.Controls.Add(Me.tbSaturation)
        Me.gpSaturation.Controls.Add(Me.pbSaturation)
        Me.gpSaturation.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpSaturation.Location = New System.Drawing.Point(0, 200)
        Me.gpSaturation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpSaturation.Name = "gpSaturation"
        Me.gpSaturation.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpSaturation.Size = New System.Drawing.Size(330, 100)
        Me.gpSaturation.TabIndex = 3
        Me.gpSaturation.TabStop = false
        Me.gpSaturation.Text = "Saturation"
        '
        'lblSaturation
        '
        Me.lblSaturation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSaturation.Location = New System.Drawing.Point(52, 75)
        Me.lblSaturation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaturation.Name = "lblSaturation"
        Me.lblSaturation.Size = New System.Drawing.Size(274, 20)
        Me.lblSaturation.TabIndex = 1
        Me.lblSaturation.Text = "0"
        Me.lblSaturation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbSaturation
        '
        Me.tbSaturation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSaturation.Location = New System.Drawing.Point(52, 24)
        Me.tbSaturation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSaturation.Maximum = 100
        Me.tbSaturation.Minimum = -100
        Me.tbSaturation.Name = "tbSaturation"
        Me.tbSaturation.Size = New System.Drawing.Size(274, 71)
        Me.tbSaturation.TabIndex = 0
        Me.tbSaturation.TickFrequency = 0
        '
        'pbSaturation
        '
        Me.pbSaturation.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbSaturation.Image = CType(resources.GetObject("pbSaturation.Image"),System.Drawing.Image)
        Me.pbSaturation.Location = New System.Drawing.Point(4, 24)
        Me.pbSaturation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbSaturation.Name = "pbSaturation"
        Me.pbSaturation.Size = New System.Drawing.Size(48, 71)
        Me.pbSaturation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSaturation.TabIndex = 3
        Me.pbSaturation.TabStop = false
        '
        'gpContrast
        '
        Me.gpContrast.Controls.Add(Me.lblContrast)
        Me.gpContrast.Controls.Add(Me.tbContrast)
        Me.gpContrast.Controls.Add(Me.pbContrast)
        Me.gpContrast.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpContrast.Location = New System.Drawing.Point(0, 100)
        Me.gpContrast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpContrast.Name = "gpContrast"
        Me.gpContrast.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpContrast.Size = New System.Drawing.Size(330, 100)
        Me.gpContrast.TabIndex = 2
        Me.gpContrast.TabStop = false
        Me.gpContrast.Text = "Contrast"
        '
        'lblContrast
        '
        Me.lblContrast.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblContrast.Location = New System.Drawing.Point(52, 75)
        Me.lblContrast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContrast.Name = "lblContrast"
        Me.lblContrast.Size = New System.Drawing.Size(274, 20)
        Me.lblContrast.TabIndex = 1
        Me.lblContrast.Text = "0"
        Me.lblContrast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbContrast
        '
        Me.tbContrast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbContrast.Location = New System.Drawing.Point(52, 24)
        Me.tbContrast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbContrast.Maximum = 100
        Me.tbContrast.Minimum = -100
        Me.tbContrast.Name = "tbContrast"
        Me.tbContrast.Size = New System.Drawing.Size(274, 71)
        Me.tbContrast.TabIndex = 0
        Me.tbContrast.TickFrequency = 0
        '
        'pbContrast
        '
        Me.pbContrast.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbContrast.Image = CType(resources.GetObject("pbContrast.Image"),System.Drawing.Image)
        Me.pbContrast.Location = New System.Drawing.Point(4, 24)
        Me.pbContrast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbContrast.Name = "pbContrast"
        Me.pbContrast.Size = New System.Drawing.Size(48, 71)
        Me.pbContrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbContrast.TabIndex = 3
        Me.pbContrast.TabStop = false
        '
        'grpBrightness
        '
        Me.grpBrightness.Controls.Add(Me.tbBrightness)
        Me.grpBrightness.Controls.Add(Me.lblBrightness)
        Me.grpBrightness.Controls.Add(Me.pbBrightness)
        Me.grpBrightness.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpBrightness.Location = New System.Drawing.Point(0, 0)
        Me.grpBrightness.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpBrightness.Name = "grpBrightness"
        Me.grpBrightness.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpBrightness.Size = New System.Drawing.Size(330, 100)
        Me.grpBrightness.TabIndex = 0
        Me.grpBrightness.TabStop = false
        Me.grpBrightness.Text = "Brightness"
        '
        'tbBrightness
        '
        Me.tbBrightness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbBrightness.Location = New System.Drawing.Point(52, 24)
        Me.tbBrightness.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbBrightness.Maximum = 100
        Me.tbBrightness.Minimum = -100
        Me.tbBrightness.Name = "tbBrightness"
        Me.tbBrightness.Size = New System.Drawing.Size(274, 51)
        Me.tbBrightness.TabIndex = 0
        Me.tbBrightness.TickFrequency = 0
        '
        'lblBrightness
        '
        Me.lblBrightness.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBrightness.Location = New System.Drawing.Point(52, 75)
        Me.lblBrightness.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrightness.Name = "lblBrightness"
        Me.lblBrightness.Size = New System.Drawing.Size(274, 20)
        Me.lblBrightness.TabIndex = 1
        Me.lblBrightness.Text = "0"
        Me.lblBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbBrightness
        '
        Me.pbBrightness.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbBrightness.Image = CType(resources.GetObject("pbBrightness.Image"),System.Drawing.Image)
        Me.pbBrightness.Location = New System.Drawing.Point(4, 24)
        Me.pbBrightness.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbBrightness.Name = "pbBrightness"
        Me.pbBrightness.Size = New System.Drawing.Size(48, 71)
        Me.pbBrightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbBrightness.TabIndex = 2
        Me.pbBrightness.TabStop = false
        '
        'tpTransform
        '
        Me.tpTransform.BackColor = System.Drawing.SystemColors.Control
        Me.tpTransform.Controls.Add(Me.pTransform)
        Me.tpTransform.Location = New System.Drawing.Point(4, 54)
        Me.tpTransform.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpTransform.Name = "tpTransform"
        Me.tpTransform.Size = New System.Drawing.Size(330, 956)
        Me.tpTransform.TabIndex = 2
        Me.tpTransform.Text = "Transform"
        '
        'pTransform
        '
        Me.pTransform.Controls.Add(Me.gpRotation)
        Me.pTransform.Controls.Add(Me.gpImageSize)
        Me.pTransform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTransform.Location = New System.Drawing.Point(0, 0)
        Me.pTransform.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pTransform.Name = "pTransform"
        Me.pTransform.Size = New System.Drawing.Size(330, 956)
        Me.pTransform.TabIndex = 0
        '
        'gpRotation
        '
        Me.gpRotation.Controls.Add(Me.pCustomAngle)
        Me.gpRotation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpRotation.Location = New System.Drawing.Point(0, 568)
        Me.gpRotation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpRotation.Name = "gpRotation"
        Me.gpRotation.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpRotation.Size = New System.Drawing.Size(330, 388)
        Me.gpRotation.TabIndex = 1
        Me.gpRotation.TabStop = false
        Me.gpRotation.Text = "Rotation"
        '
        'pCustomAngle
        '
        Me.pCustomAngle.AutoSize = true
        Me.pCustomAngle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pCustomAngle.Controls.Add(Me.pRotationPreview)
        Me.pCustomAngle.Controls.Add(Me.Panel1)
        Me.pCustomAngle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCustomAngle.Location = New System.Drawing.Point(4, 24)
        Me.pCustomAngle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pCustomAngle.Name = "pCustomAngle"
        Me.pCustomAngle.Size = New System.Drawing.Size(322, 359)
        Me.pCustomAngle.TabIndex = 1
        '
        'pRotationPreview
        '
        Me.pRotationPreview.Controls.Add(Me.rotationPeviewViewer)
        Me.pRotationPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pRotationPreview.Location = New System.Drawing.Point(0, 166)
        Me.pRotationPreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pRotationPreview.Name = "pRotationPreview"
        Me.pRotationPreview.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.pRotationPreview.Size = New System.Drawing.Size(322, 193)
        Me.pRotationPreview.TabIndex = 7
        '
        'rotationPeviewViewer
        '
        Me.rotationPeviewViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rotationPeviewViewer.Location = New System.Drawing.Point(0, 8)
        Me.rotationPeviewViewer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rotationPeviewViewer.Name = "rotationPeviewViewer"
        Me.rotationPeviewViewer.Size = New System.Drawing.Size(322, 185)
        Me.rotationPeviewViewer.TabIndex = 0
        Me.rotationPeviewViewer.TabStop = false
        '
        'Panel1
        '
        Me.Panel1.AutoSize = true
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.rbFlipVertical)
        Me.Panel1.Controls.Add(Me.rbFlipHorizontal)
        Me.Panel1.Controls.Add(Me.rbRotateCustomAngle)
        Me.Panel1.Controls.Add(Me.rbRotateRight)
        Me.Panel1.Controls.Add(Me.pbRotationBackColor)
        Me.Panel1.Controls.Add(Me.rbRotateLeft)
        Me.Panel1.Controls.Add(Me.chkKeepImageDimensionRotation)
        Me.Panel1.Controls.Add(Me.lblCustomRotationBackgroundColor)
        Me.Panel1.Controls.Add(Me.chkRotateFromCenter)
        Me.Panel1.Controls.Add(Me.nRotationAngle)
        Me.Panel1.Controls.Add(Me.btnApplyRotation)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 166)
        Me.Panel1.TabIndex = 7
        '
        'rbFlipVertical
        '
        Me.rbFlipVertical.Image = CType(resources.GetObject("rbFlipVertical.Image"),System.Drawing.Image)
        Me.rbFlipVertical.Location = New System.Drawing.Point(252, 5)
        Me.rbFlipVertical.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbFlipVertical.Name = "rbFlipVertical"
        Me.rbFlipVertical.Size = New System.Drawing.Size(72, 49)
        Me.rbFlipVertical.TabIndex = 7
        Me.rbFlipVertical.TabStop = true
        Me.rbFlipVertical.UseVisualStyleBackColor = true
        '
        'rbFlipHorizontal
        '
        Me.rbFlipHorizontal.Image = CType(resources.GetObject("rbFlipHorizontal.Image"),System.Drawing.Image)
        Me.rbFlipHorizontal.Location = New System.Drawing.Point(171, 5)
        Me.rbFlipHorizontal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbFlipHorizontal.Name = "rbFlipHorizontal"
        Me.rbFlipHorizontal.Size = New System.Drawing.Size(72, 49)
        Me.rbFlipHorizontal.TabIndex = 6
        Me.rbFlipHorizontal.TabStop = true
        Me.rbFlipHorizontal.UseVisualStyleBackColor = true
        '
        'rbRotateCustomAngle
        '
        Me.rbRotateCustomAngle.AutoSize = true
        Me.rbRotateCustomAngle.Location = New System.Drawing.Point(9, 57)
        Me.rbRotateCustomAngle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbRotateCustomAngle.Name = "rbRotateCustomAngle"
        Me.rbRotateCustomAngle.Size = New System.Drawing.Size(132, 24)
        Me.rbRotateCustomAngle.TabIndex = 11
        Me.rbRotateCustomAngle.TabStop = true
        Me.rbRotateCustomAngle.Text = "Custom angle"
        Me.rbRotateCustomAngle.UseVisualStyleBackColor = true
        '
        'rbRotateRight
        '
        Me.rbRotateRight.Image = CType(resources.GetObject("rbRotateRight.Image"),System.Drawing.Image)
        Me.rbRotateRight.Location = New System.Drawing.Point(90, 5)
        Me.rbRotateRight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbRotateRight.Name = "rbRotateRight"
        Me.rbRotateRight.Size = New System.Drawing.Size(72, 49)
        Me.rbRotateRight.TabIndex = 5
        Me.rbRotateRight.TabStop = true
        Me.rbRotateRight.UseVisualStyleBackColor = true
        '
        'pbRotationBackColor
        '
        Me.pbRotationBackColor.BackColor = System.Drawing.Color.Black
        Me.pbRotationBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbRotationBackColor.Location = New System.Drawing.Point(152, 128)
        Me.pbRotationBackColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbRotationBackColor.Name = "pbRotationBackColor"
        Me.pbRotationBackColor.Size = New System.Drawing.Size(30, 31)
        Me.pbRotationBackColor.TabIndex = 10
        Me.pbRotationBackColor.TabStop = false
        '
        'rbRotateLeft
        '
        Me.rbRotateLeft.Image = CType(resources.GetObject("rbRotateLeft.Image"),System.Drawing.Image)
        Me.rbRotateLeft.Location = New System.Drawing.Point(9, 5)
        Me.rbRotateLeft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbRotateLeft.Name = "rbRotateLeft"
        Me.rbRotateLeft.Size = New System.Drawing.Size(72, 49)
        Me.rbRotateLeft.TabIndex = 4
        Me.rbRotateLeft.TabStop = true
        Me.rbRotateLeft.UseVisualStyleBackColor = true
        '
        'chkKeepImageDimensionRotation
        '
        Me.chkKeepImageDimensionRotation.AutoSize = true
        Me.chkKeepImageDimensionRotation.Checked = true
        Me.chkKeepImageDimensionRotation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeepImageDimensionRotation.Location = New System.Drawing.Point(9, 94)
        Me.chkKeepImageDimensionRotation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkKeepImageDimensionRotation.Name = "chkKeepImageDimensionRotation"
        Me.chkKeepImageDimensionRotation.Size = New System.Drawing.Size(156, 24)
        Me.chkKeepImageDimensionRotation.TabIndex = 9
        Me.chkKeepImageDimensionRotation.Text = "Keep dimensions"
        Me.chkKeepImageDimensionRotation.UseVisualStyleBackColor = true
        '
        'lblCustomRotationBackgroundColor
        '
        Me.lblCustomRotationBackgroundColor.AutoSize = true
        Me.lblCustomRotationBackgroundColor.Location = New System.Drawing.Point(4, 135)
        Me.lblCustomRotationBackgroundColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomRotationBackgroundColor.Name = "lblCustomRotationBackgroundColor"
        Me.lblCustomRotationBackgroundColor.Size = New System.Drawing.Size(137, 20)
        Me.lblCustomRotationBackgroundColor.TabIndex = 8
        Me.lblCustomRotationBackgroundColor.Text = "Background color:"
        '
        'chkRotateFromCenter
        '
        Me.chkRotateFromCenter.AutoSize = true
        Me.chkRotateFromCenter.Checked = true
        Me.chkRotateFromCenter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRotateFromCenter.Location = New System.Drawing.Point(177, 94)
        Me.chkRotateFromCenter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkRotateFromCenter.Name = "chkRotateFromCenter"
        Me.chkRotateFromCenter.Size = New System.Drawing.Size(181, 24)
        Me.chkRotateFromCenter.TabIndex = 7
        Me.chkRotateFromCenter.Text = "Rotation from center"
        Me.chkRotateFromCenter.UseVisualStyleBackColor = true
        '
        'nRotationAngle
        '
        Me.nRotationAngle.DecimalPlaces = 1
        Me.nRotationAngle.Location = New System.Drawing.Point(142, 57)
        Me.nRotationAngle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRotationAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nRotationAngle.Name = "nRotationAngle"
        Me.nRotationAngle.Size = New System.Drawing.Size(92, 26)
        Me.nRotationAngle.TabIndex = 5
        Me.nRotationAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnApplyRotation
        '
        Me.btnApplyRotation.Location = New System.Drawing.Point(381, 126)
        Me.btnApplyRotation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApplyRotation.Name = "btnApplyRotation"
        Me.btnApplyRotation.Size = New System.Drawing.Size(112, 35)
        Me.btnApplyRotation.TabIndex = 6
        Me.btnApplyRotation.Text = "Apply"
        Me.btnApplyRotation.UseVisualStyleBackColor = true
        '
        'gpImageSize
        '
        Me.gpImageSize.Controls.Add(Me.btnResetSize)
        Me.gpImageSize.Controls.Add(Me.btnApplySize)
        Me.gpImageSize.Controls.Add(Me.gpDocumentSize)
        Me.gpImageSize.Controls.Add(Me.gpPixelDimensions)
        Me.gpImageSize.Controls.Add(Me.chkKeepAspectRatio)
        Me.gpImageSize.Controls.Add(Me.rbResize)
        Me.gpImageSize.Controls.Add(Me.Label1)
        Me.gpImageSize.Controls.Add(Me.nScalePercent)
        Me.gpImageSize.Controls.Add(Me.rbScalePercent)
        Me.gpImageSize.Controls.Add(Me.cbResampling)
        Me.gpImageSize.Controls.Add(Me.lblResampling)
        Me.gpImageSize.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpImageSize.Location = New System.Drawing.Point(0, 0)
        Me.gpImageSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpImageSize.Name = "gpImageSize"
        Me.gpImageSize.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpImageSize.Size = New System.Drawing.Size(330, 568)
        Me.gpImageSize.TabIndex = 0
        Me.gpImageSize.TabStop = false
        Me.gpImageSize.Text = "Image size"
        '
        'btnResetSize
        '
        Me.btnResetSize.Location = New System.Drawing.Point(192, 512)
        Me.btnResetSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnResetSize.Name = "btnResetSize"
        Me.btnResetSize.Size = New System.Drawing.Size(112, 35)
        Me.btnResetSize.TabIndex = 10
        Me.btnResetSize.Text = "Reset"
        Me.btnResetSize.UseVisualStyleBackColor = true
        '
        'btnApplySize
        '
        Me.btnApplySize.Location = New System.Drawing.Point(314, 512)
        Me.btnApplySize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApplySize.Name = "btnApplySize"
        Me.btnApplySize.Size = New System.Drawing.Size(112, 35)
        Me.btnApplySize.TabIndex = 9
        Me.btnApplySize.Text = "Apply"
        Me.btnApplySize.UseVisualStyleBackColor = true
        '
        'gpDocumentSize
        '
        Me.gpDocumentSize.Controls.Add(Me.Label12)
        Me.gpDocumentSize.Controls.Add(Me.Label13)
        Me.gpDocumentSize.Controls.Add(Me.nVerticalResolution)
        Me.gpDocumentSize.Controls.Add(Me.Label11)
        Me.gpDocumentSize.Controls.Add(Me.Label10)
        Me.gpDocumentSize.Controls.Add(Me.nHorizontalResolution)
        Me.gpDocumentSize.Controls.Add(Me.nDocumentHeight)
        Me.gpDocumentSize.Controls.Add(Me.Label6)
        Me.gpDocumentSize.Controls.Add(Me.Label7)
        Me.gpDocumentSize.Controls.Add(Me.Label8)
        Me.gpDocumentSize.Controls.Add(Me.nDocumentWidth)
        Me.gpDocumentSize.Controls.Add(Me.Label9)
        Me.gpDocumentSize.Location = New System.Drawing.Point(44, 306)
        Me.gpDocumentSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpDocumentSize.Name = "gpDocumentSize"
        Me.gpDocumentSize.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpDocumentSize.Size = New System.Drawing.Size(382, 197)
        Me.gpDocumentSize.TabIndex = 8
        Me.gpDocumentSize.TabStop = false
        Me.gpDocumentSize.Text = "Document size"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(280, 152)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "pixels/inch"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(26, 152)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 20)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Vertical resolution"
        '
        'nVerticalResolution
        '
        Me.nVerticalResolution.Location = New System.Drawing.Point(170, 149)
        Me.nVerticalResolution.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nVerticalResolution.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nVerticalResolution.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nVerticalResolution.Name = "nVerticalResolution"
        Me.nVerticalResolution.Size = New System.Drawing.Size(102, 26)
        Me.nVerticalResolution.TabIndex = 10
        Me.nVerticalResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nVerticalResolution.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(280, 112)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "pixels/inch"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(8, 112)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Horizontal resolution"
        '
        'nHorizontalResolution
        '
        Me.nHorizontalResolution.Location = New System.Drawing.Point(170, 109)
        Me.nHorizontalResolution.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nHorizontalResolution.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nHorizontalResolution.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nHorizontalResolution.Name = "nHorizontalResolution"
        Me.nHorizontalResolution.Size = New System.Drawing.Size(102, 26)
        Me.nHorizontalResolution.TabIndex = 7
        Me.nHorizontalResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nHorizontalResolution.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nDocumentHeight
        '
        Me.nDocumentHeight.DecimalPlaces = 2
        Me.nDocumentHeight.Location = New System.Drawing.Point(170, 69)
        Me.nDocumentHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nDocumentHeight.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nDocumentHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nDocumentHeight.Name = "nDocumentHeight"
        Me.nDocumentHeight.Size = New System.Drawing.Size(102, 26)
        Me.nDocumentHeight.TabIndex = 6
        Me.nDocumentHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nDocumentHeight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(280, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "inches"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(104, 72)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Height:"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(280, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "inches"
        '
        'nDocumentWidth
        '
        Me.nDocumentWidth.DecimalPlaces = 2
        Me.nDocumentWidth.Location = New System.Drawing.Point(170, 29)
        Me.nDocumentWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nDocumentWidth.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nDocumentWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nDocumentWidth.Name = "nDocumentWidth"
        Me.nDocumentWidth.Size = New System.Drawing.Size(102, 26)
        Me.nDocumentWidth.TabIndex = 1
        Me.nDocumentWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nDocumentWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(104, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Width:"
        '
        'gpPixelDimensions
        '
        Me.gpPixelDimensions.Controls.Add(Me.nHeight)
        Me.gpPixelDimensions.Controls.Add(Me.Label5)
        Me.gpPixelDimensions.Controls.Add(Me.Label4)
        Me.gpPixelDimensions.Controls.Add(Me.Label3)
        Me.gpPixelDimensions.Controls.Add(Me.nWidth)
        Me.gpPixelDimensions.Controls.Add(Me.Label2)
        Me.gpPixelDimensions.Location = New System.Drawing.Point(44, 175)
        Me.gpPixelDimensions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpPixelDimensions.Name = "gpPixelDimensions"
        Me.gpPixelDimensions.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpPixelDimensions.Size = New System.Drawing.Size(382, 122)
        Me.gpPixelDimensions.TabIndex = 7
        Me.gpPixelDimensions.TabStop = false
        Me.gpPixelDimensions.Text = "Pixel dimensions"
        '
        'nHeight
        '
        Me.nHeight.Location = New System.Drawing.Point(170, 72)
        Me.nHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nHeight.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nHeight.Name = "nHeight"
        Me.nHeight.Size = New System.Drawing.Size(102, 26)
        Me.nHeight.TabIndex = 6
        Me.nHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nHeight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(280, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "pixels"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(99, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Height:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(280, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "pixels"
        '
        'nWidth
        '
        Me.nWidth.Location = New System.Drawing.Point(170, 32)
        Me.nWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nWidth.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nWidth.Name = "nWidth"
        Me.nWidth.Size = New System.Drawing.Size(102, 26)
        Me.nWidth.TabIndex = 1
        Me.nWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(104, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Width:"
        '
        'chkKeepAspectRatio
        '
        Me.chkKeepAspectRatio.AutoSize = true
        Me.chkKeepAspectRatio.Checked = true
        Me.chkKeepAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeepAspectRatio.Location = New System.Drawing.Point(44, 140)
        Me.chkKeepAspectRatio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkKeepAspectRatio.Name = "chkKeepAspectRatio"
        Me.chkKeepAspectRatio.Size = New System.Drawing.Size(159, 24)
        Me.chkKeepAspectRatio.TabIndex = 6
        Me.chkKeepAspectRatio.Text = "Keep aspect ratio"
        Me.chkKeepAspectRatio.UseVisualStyleBackColor = true
        '
        'rbResize
        '
        Me.rbResize.AutoSize = true
        Me.rbResize.Location = New System.Drawing.Point(14, 105)
        Me.rbResize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbResize.Name = "rbResize"
        Me.rbResize.Size = New System.Drawing.Size(149, 24)
        Me.rbResize.TabIndex = 5
        Me.rbResize.TabStop = true
        Me.rbResize.Text = "By absolute size"
        Me.rbResize.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(261, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "%"
        '
        'nScalePercent
        '
        Me.nScalePercent.Location = New System.Drawing.Point(164, 65)
        Me.nScalePercent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nScalePercent.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nScalePercent.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nScalePercent.Name = "nScalePercent"
        Me.nScalePercent.Size = New System.Drawing.Size(88, 26)
        Me.nScalePercent.TabIndex = 3
        Me.nScalePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nScalePercent.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'rbScalePercent
        '
        Me.rbScalePercent.AutoSize = true
        Me.rbScalePercent.Checked = true
        Me.rbScalePercent.Location = New System.Drawing.Point(14, 65)
        Me.rbScalePercent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbScalePercent.Name = "rbScalePercent"
        Me.rbScalePercent.Size = New System.Drawing.Size(137, 24)
        Me.rbScalePercent.TabIndex = 2
        Me.rbScalePercent.TabStop = true
        Me.rbScalePercent.Text = "By percentage"
        Me.rbScalePercent.UseVisualStyleBackColor = true
        '
        'cbResampling
        '
        Me.cbResampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbResampling.FormattingEnabled = true
        Me.cbResampling.Location = New System.Drawing.Point(116, 23)
        Me.cbResampling.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbResampling.Name = "cbResampling"
        Me.cbResampling.Size = New System.Drawing.Size(232, 28)
        Me.cbResampling.TabIndex = 1
        '
        'lblResampling
        '
        Me.lblResampling.AutoSize = true
        Me.lblResampling.Location = New System.Drawing.Point(9, 28)
        Me.lblResampling.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResampling.Name = "lblResampling"
        Me.lblResampling.Size = New System.Drawing.Size(97, 20)
        Me.lblResampling.TabIndex = 0
        Me.lblResampling.Text = "Resampling:"
        '
        'tpColorOperations
        '
        Me.tpColorOperations.Controls.Add(Me.pColorOperations)
        Me.tpColorOperations.Location = New System.Drawing.Point(4, 54)
        Me.tpColorOperations.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpColorOperations.Name = "tpColorOperations"
        Me.tpColorOperations.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpColorOperations.Size = New System.Drawing.Size(330, 956)
        Me.tpColorOperations.TabIndex = 3
        Me.tpColorOperations.Text = "Color operations"
        Me.tpColorOperations.UseVisualStyleBackColor = true
        '
        'pColorOperations
        '
        Me.pColorOperations.Controls.Add(Me.gpColorChannelsManipulation)
        Me.pColorOperations.Controls.Add(Me.gpPixelFormat)
        Me.pColorOperations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pColorOperations.Location = New System.Drawing.Point(4, 5)
        Me.pColorOperations.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pColorOperations.Name = "pColorOperations"
        Me.pColorOperations.Size = New System.Drawing.Size(322, 946)
        Me.pColorOperations.TabIndex = 1
        '
        'gpColorChannelsManipulation
        '
        Me.gpColorChannelsManipulation.Controls.Add(Me.pColorChannelsViewer)
        Me.gpColorChannelsManipulation.Controls.Add(Me.pColorManipulation)
        Me.gpColorChannelsManipulation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpColorChannelsManipulation.Location = New System.Drawing.Point(0, 78)
        Me.gpColorChannelsManipulation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpColorChannelsManipulation.Name = "gpColorChannelsManipulation"
        Me.gpColorChannelsManipulation.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpColorChannelsManipulation.Size = New System.Drawing.Size(322, 868)
        Me.gpColorChannelsManipulation.TabIndex = 1
        Me.gpColorChannelsManipulation.TabStop = false
        Me.gpColorChannelsManipulation.Text = "Color channels manipulation"
        '
        'pColorChannelsViewer
        '
        Me.pColorChannelsViewer.Controls.Add(Me.colorChannelPreviewViewer)
        Me.pColorChannelsViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pColorChannelsViewer.Location = New System.Drawing.Point(4, 713)
        Me.pColorChannelsViewer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pColorChannelsViewer.Name = "pColorChannelsViewer"
        Me.pColorChannelsViewer.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.pColorChannelsViewer.Size = New System.Drawing.Size(314, 150)
        Me.pColorChannelsViewer.TabIndex = 13
        '
        'colorChannelPreviewViewer
        '
        Me.colorChannelPreviewViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colorChannelPreviewViewer.Location = New System.Drawing.Point(0, 8)
        Me.colorChannelPreviewViewer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.colorChannelPreviewViewer.Name = "colorChannelPreviewViewer"
        Me.colorChannelPreviewViewer.Size = New System.Drawing.Size(314, 142)
        Me.colorChannelPreviewViewer.TabIndex = 0
        Me.colorChannelPreviewViewer.TabStop = false
        '
        'pColorManipulation
        '
        Me.pColorManipulation.AutoSize = true
        Me.pColorManipulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pColorManipulation.Controls.Add(Me.btnResetColorChannels)
        Me.pColorManipulation.Controls.Add(Me.btnApplyColorChannels)
        Me.pColorManipulation.Controls.Add(Me.pRemoveComponent)
        Me.pColorManipulation.Controls.Add(Me.rbRemoveComponent)
        Me.pColorManipulation.Controls.Add(Me.pScaleColors)
        Me.pColorManipulation.Controls.Add(Me.rbScaleComponent)
        Me.pColorManipulation.Controls.Add(Me.pKeepComponent)
        Me.pColorManipulation.Controls.Add(Me.rbKeepComponent)
        Me.pColorManipulation.Controls.Add(Me.pSwapColors)
        Me.pColorManipulation.Controls.Add(Me.rbSwapColor)
        Me.pColorManipulation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pColorManipulation.Location = New System.Drawing.Point(4, 24)
        Me.pColorManipulation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pColorManipulation.Name = "pColorManipulation"
        Me.pColorManipulation.Size = New System.Drawing.Size(314, 689)
        Me.pColorManipulation.TabIndex = 12
        '
        'btnResetColorChannels
        '
        Me.btnResetColorChannels.Location = New System.Drawing.Point(240, 649)
        Me.btnResetColorChannels.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnResetColorChannels.Name = "btnResetColorChannels"
        Me.btnResetColorChannels.Size = New System.Drawing.Size(112, 35)
        Me.btnResetColorChannels.TabIndex = 16
        Me.btnResetColorChannels.Text = "Reset"
        Me.btnResetColorChannels.UseVisualStyleBackColor = true
        '
        'btnApplyColorChannels
        '
        Me.btnApplyColorChannels.Location = New System.Drawing.Point(362, 649)
        Me.btnApplyColorChannels.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApplyColorChannels.Name = "btnApplyColorChannels"
        Me.btnApplyColorChannels.Size = New System.Drawing.Size(112, 35)
        Me.btnApplyColorChannels.TabIndex = 15
        Me.btnApplyColorChannels.Text = "Apply"
        Me.btnApplyColorChannels.UseVisualStyleBackColor = true
        '
        'pRemoveComponent
        '
        Me.pRemoveComponent.AutoSize = true
        Me.pRemoveComponent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pRemoveComponent.Controls.Add(Me.rbRemoveBlue)
        Me.pRemoveComponent.Controls.Add(Me.rbRemoveGreen)
        Me.pRemoveComponent.Controls.Add(Me.rbRemoveRed)
        Me.pRemoveComponent.Location = New System.Drawing.Point(38, 534)
        Me.pRemoveComponent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pRemoveComponent.Name = "pRemoveComponent"
        Me.pRemoveComponent.Size = New System.Drawing.Size(87, 100)
        Me.pRemoveComponent.TabIndex = 14
        '
        'rbRemoveBlue
        '
        Me.rbRemoveBlue.AutoSize = true
        Me.rbRemoveBlue.Location = New System.Drawing.Point(4, 71)
        Me.rbRemoveBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbRemoveBlue.Name = "rbRemoveBlue"
        Me.rbRemoveBlue.Size = New System.Drawing.Size(66, 24)
        Me.rbRemoveBlue.TabIndex = 5
        Me.rbRemoveBlue.TabStop = true
        Me.rbRemoveBlue.Text = "Blue"
        Me.rbRemoveBlue.UseVisualStyleBackColor = true
        '
        'rbRemoveGreen
        '
        Me.rbRemoveGreen.AutoSize = true
        Me.rbRemoveGreen.Location = New System.Drawing.Point(4, 35)
        Me.rbRemoveGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbRemoveGreen.Name = "rbRemoveGreen"
        Me.rbRemoveGreen.Size = New System.Drawing.Size(79, 24)
        Me.rbRemoveGreen.TabIndex = 4
        Me.rbRemoveGreen.TabStop = true
        Me.rbRemoveGreen.Text = "Green"
        Me.rbRemoveGreen.UseVisualStyleBackColor = true
        '
        'rbRemoveRed
        '
        Me.rbRemoveRed.AutoSize = true
        Me.rbRemoveRed.Location = New System.Drawing.Point(4, 0)
        Me.rbRemoveRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbRemoveRed.Name = "rbRemoveRed"
        Me.rbRemoveRed.Size = New System.Drawing.Size(64, 24)
        Me.rbRemoveRed.TabIndex = 3
        Me.rbRemoveRed.TabStop = true
        Me.rbRemoveRed.Text = "Red"
        Me.rbRemoveRed.UseVisualStyleBackColor = true
        '
        'rbRemoveComponent
        '
        Me.rbRemoveComponent.AutoSize = true
        Me.rbRemoveComponent.Location = New System.Drawing.Point(4, 498)
        Me.rbRemoveComponent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbRemoveComponent.Name = "rbRemoveComponent"
        Me.rbRemoveComponent.Size = New System.Drawing.Size(177, 24)
        Me.rbRemoveComponent.TabIndex = 13
        Me.rbRemoveComponent.TabStop = true
        Me.rbRemoveComponent.Text = "Remove component"
        Me.rbRemoveComponent.UseVisualStyleBackColor = true
        '
        'pScaleColors
        '
        Me.pScaleColors.AutoSize = true
        Me.pScaleColors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pScaleColors.Controls.Add(Me.pScaleBlue)
        Me.pScaleColors.Controls.Add(Me.pScaleRed)
        Me.pScaleColors.Controls.Add(Me.pScaleGreen)
        Me.pScaleColors.Location = New System.Drawing.Point(38, 268)
        Me.pScaleColors.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pScaleColors.Name = "pScaleColors"
        Me.pScaleColors.Size = New System.Drawing.Size(436, 222)
        Me.pScaleColors.TabIndex = 12
        '
        'pScaleBlue
        '
        Me.pScaleBlue.Controls.Add(Me.lblScaleBlue)
        Me.pScaleBlue.Controls.Add(Me.tbScaleBlue)
        Me.pScaleBlue.Controls.Add(Me.PictureBox2)
        Me.pScaleBlue.Location = New System.Drawing.Point(0, 152)
        Me.pScaleBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pScaleBlue.Name = "pScaleBlue"
        Me.pScaleBlue.Size = New System.Drawing.Size(432, 65)
        Me.pScaleBlue.TabIndex = 9
        '
        'lblScaleBlue
        '
        Me.lblScaleBlue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblScaleBlue.Location = New System.Drawing.Point(48, 45)
        Me.lblScaleBlue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScaleBlue.Name = "lblScaleBlue"
        Me.lblScaleBlue.Size = New System.Drawing.Size(384, 20)
        Me.lblScaleBlue.TabIndex = 1
        Me.lblScaleBlue.Text = "0"
        Me.lblScaleBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbScaleBlue
        '
        Me.tbScaleBlue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbScaleBlue.Location = New System.Drawing.Point(48, 0)
        Me.tbScaleBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbScaleBlue.Maximum = 500
        Me.tbScaleBlue.Minimum = -300
        Me.tbScaleBlue.Name = "tbScaleBlue"
        Me.tbScaleBlue.Size = New System.Drawing.Size(384, 65)
        Me.tbScaleBlue.TabIndex = 0
        Me.tbScaleBlue.TickFrequency = 0
        Me.tbScaleBlue.Value = 100
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = false
        '
        'pScaleRed
        '
        Me.pScaleRed.Controls.Add(Me.lblScaleRed)
        Me.pScaleRed.Controls.Add(Me.tbScaleRed)
        Me.pScaleRed.Controls.Add(Me.PictureBox1)
        Me.pScaleRed.Location = New System.Drawing.Point(0, 0)
        Me.pScaleRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pScaleRed.Name = "pScaleRed"
        Me.pScaleRed.Size = New System.Drawing.Size(432, 65)
        Me.pScaleRed.TabIndex = 8
        '
        'lblScaleRed
        '
        Me.lblScaleRed.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblScaleRed.Location = New System.Drawing.Point(48, 45)
        Me.lblScaleRed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScaleRed.Name = "lblScaleRed"
        Me.lblScaleRed.Size = New System.Drawing.Size(384, 20)
        Me.lblScaleRed.TabIndex = 1
        Me.lblScaleRed.Text = "0"
        Me.lblScaleRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbScaleRed
        '
        Me.tbScaleRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbScaleRed.Location = New System.Drawing.Point(48, 0)
        Me.tbScaleRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbScaleRed.Maximum = 500
        Me.tbScaleRed.Minimum = -300
        Me.tbScaleRed.Name = "tbScaleRed"
        Me.tbScaleRed.Size = New System.Drawing.Size(384, 65)
        Me.tbScaleRed.TabIndex = 0
        Me.tbScaleRed.TickFrequency = 0
        Me.tbScaleRed.Value = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = false
        '
        'pScaleGreen
        '
        Me.pScaleGreen.Controls.Add(Me.lblScaleGreen)
        Me.pScaleGreen.Controls.Add(Me.tbScaleGreen)
        Me.pScaleGreen.Controls.Add(Me.PictureBox3)
        Me.pScaleGreen.Location = New System.Drawing.Point(0, 74)
        Me.pScaleGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pScaleGreen.Name = "pScaleGreen"
        Me.pScaleGreen.Size = New System.Drawing.Size(432, 65)
        Me.pScaleGreen.TabIndex = 10
        '
        'lblScaleGreen
        '
        Me.lblScaleGreen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblScaleGreen.Location = New System.Drawing.Point(48, 45)
        Me.lblScaleGreen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScaleGreen.Name = "lblScaleGreen"
        Me.lblScaleGreen.Size = New System.Drawing.Size(384, 20)
        Me.lblScaleGreen.TabIndex = 1
        Me.lblScaleGreen.Text = "0"
        Me.lblScaleGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbScaleGreen
        '
        Me.tbScaleGreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbScaleGreen.Location = New System.Drawing.Point(48, 0)
        Me.tbScaleGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbScaleGreen.Maximum = 500
        Me.tbScaleGreen.Minimum = -300
        Me.tbScaleGreen.Name = "tbScaleGreen"
        Me.tbScaleGreen.Size = New System.Drawing.Size(384, 65)
        Me.tbScaleGreen.TabIndex = 0
        Me.tbScaleGreen.TickFrequency = 0
        Me.tbScaleGreen.Value = 100
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 65)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = false
        '
        'rbScaleComponent
        '
        Me.rbScaleComponent.AutoSize = true
        Me.rbScaleComponent.Location = New System.Drawing.Point(4, 232)
        Me.rbScaleComponent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbScaleComponent.Name = "rbScaleComponent"
        Me.rbScaleComponent.Size = New System.Drawing.Size(158, 24)
        Me.rbScaleComponent.TabIndex = 4
        Me.rbScaleComponent.TabStop = true
        Me.rbScaleComponent.Text = "Scale component"
        Me.rbScaleComponent.UseVisualStyleBackColor = true
        '
        'pKeepComponent
        '
        Me.pKeepComponent.AutoSize = true
        Me.pKeepComponent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pKeepComponent.Controls.Add(Me.rbKeepBlue)
        Me.pKeepComponent.Controls.Add(Me.rbKeepGreen)
        Me.pKeepComponent.Controls.Add(Me.rbKeepRed)
        Me.pKeepComponent.Location = New System.Drawing.Point(38, 117)
        Me.pKeepComponent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pKeepComponent.Name = "pKeepComponent"
        Me.pKeepComponent.Size = New System.Drawing.Size(87, 104)
        Me.pKeepComponent.TabIndex = 3
        '
        'rbKeepBlue
        '
        Me.rbKeepBlue.AutoSize = true
        Me.rbKeepBlue.Location = New System.Drawing.Point(4, 75)
        Me.rbKeepBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbKeepBlue.Name = "rbKeepBlue"
        Me.rbKeepBlue.Size = New System.Drawing.Size(66, 24)
        Me.rbKeepBlue.TabIndex = 2
        Me.rbKeepBlue.TabStop = true
        Me.rbKeepBlue.Text = "Blue"
        Me.rbKeepBlue.UseVisualStyleBackColor = true
        '
        'rbKeepGreen
        '
        Me.rbKeepGreen.AutoSize = true
        Me.rbKeepGreen.Location = New System.Drawing.Point(4, 40)
        Me.rbKeepGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbKeepGreen.Name = "rbKeepGreen"
        Me.rbKeepGreen.Size = New System.Drawing.Size(79, 24)
        Me.rbKeepGreen.TabIndex = 1
        Me.rbKeepGreen.TabStop = true
        Me.rbKeepGreen.Text = "Green"
        Me.rbKeepGreen.UseVisualStyleBackColor = true
        '
        'rbKeepRed
        '
        Me.rbKeepRed.AutoSize = true
        Me.rbKeepRed.Location = New System.Drawing.Point(4, 5)
        Me.rbKeepRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbKeepRed.Name = "rbKeepRed"
        Me.rbKeepRed.Size = New System.Drawing.Size(64, 24)
        Me.rbKeepRed.TabIndex = 0
        Me.rbKeepRed.TabStop = true
        Me.rbKeepRed.Text = "Red"
        Me.rbKeepRed.UseVisualStyleBackColor = true
        '
        'rbKeepComponent
        '
        Me.rbKeepComponent.AutoSize = true
        Me.rbKeepComponent.Location = New System.Drawing.Point(4, 82)
        Me.rbKeepComponent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbKeepComponent.Name = "rbKeepComponent"
        Me.rbKeepComponent.Size = New System.Drawing.Size(155, 24)
        Me.rbKeepComponent.TabIndex = 2
        Me.rbKeepComponent.TabStop = true
        Me.rbKeepComponent.Text = "Keep component"
        Me.rbKeepComponent.UseVisualStyleBackColor = true
        '
        'pSwapColors
        '
        Me.pSwapColors.AutoSize = true
        Me.pSwapColors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pSwapColors.Controls.Add(Me.cbSwapColor)
        Me.pSwapColors.Location = New System.Drawing.Point(38, 31)
        Me.pSwapColors.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pSwapColors.Name = "pSwapColors"
        Me.pSwapColors.Size = New System.Drawing.Size(188, 38)
        Me.pSwapColors.TabIndex = 11
        '
        'cbSwapColor
        '
        Me.cbSwapColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSwapColor.FormattingEnabled = true
        Me.cbSwapColor.Location = New System.Drawing.Point(4, 5)
        Me.cbSwapColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbSwapColor.Name = "cbSwapColor"
        Me.cbSwapColor.Size = New System.Drawing.Size(180, 28)
        Me.cbSwapColor.TabIndex = 1
        '
        'rbSwapColor
        '
        Me.rbSwapColor.AutoSize = true
        Me.rbSwapColor.Location = New System.Drawing.Point(4, 5)
        Me.rbSwapColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbSwapColor.Name = "rbSwapColor"
        Me.rbSwapColor.Size = New System.Drawing.Size(120, 24)
        Me.rbSwapColor.TabIndex = 0
        Me.rbSwapColor.TabStop = true
        Me.rbSwapColor.Text = "Swap colors"
        Me.rbSwapColor.UseVisualStyleBackColor = true
        '
        'gpPixelFormat
        '
        Me.gpPixelFormat.Controls.Add(Me.btnApplyPixelConversion)
        Me.gpPixelFormat.Controls.Add(Me.cbPixelConversion)
        Me.gpPixelFormat.Controls.Add(Me.Label16)
        Me.gpPixelFormat.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpPixelFormat.Location = New System.Drawing.Point(0, 0)
        Me.gpPixelFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpPixelFormat.Name = "gpPixelFormat"
        Me.gpPixelFormat.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpPixelFormat.Size = New System.Drawing.Size(322, 78)
        Me.gpPixelFormat.TabIndex = 0
        Me.gpPixelFormat.TabStop = false
        Me.gpPixelFormat.Text = "Pixel format conversion"
        '
        'btnApplyPixelConversion
        '
        Me.btnApplyPixelConversion.Location = New System.Drawing.Point(376, 25)
        Me.btnApplyPixelConversion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApplyPixelConversion.Name = "btnApplyPixelConversion"
        Me.btnApplyPixelConversion.Size = New System.Drawing.Size(112, 35)
        Me.btnApplyPixelConversion.TabIndex = 2
        Me.btnApplyPixelConversion.Text = "Apply"
        Me.btnApplyPixelConversion.UseVisualStyleBackColor = true
        '
        'cbPixelConversion
        '
        Me.cbPixelConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPixelConversion.FormattingEnabled = true
        Me.cbPixelConversion.Location = New System.Drawing.Point(106, 26)
        Me.cbPixelConversion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbPixelConversion.Name = "cbPixelConversion"
        Me.cbPixelConversion.Size = New System.Drawing.Size(259, 28)
        Me.cbPixelConversion.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(9, 32)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Convert to:"
        '
        'tpEffects
        '
        Me.tpEffects.Controls.Add(Me.pEffects)
        Me.tpEffects.Location = New System.Drawing.Point(4, 54)
        Me.tpEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpEffects.Name = "tpEffects"
        Me.tpEffects.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpEffects.Size = New System.Drawing.Size(330, 1338)
        Me.tpEffects.TabIndex = 4
        Me.tpEffects.Text = "Effects"
        Me.tpEffects.UseVisualStyleBackColor = true
        '
        'pEffects
        '
        Me.pEffects.Controls.Add(Me.pEffectsPreview)
        Me.pEffects.Controls.Add(Me.Panel3)
        Me.pEffects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEffects.Location = New System.Drawing.Point(4, 5)
        Me.pEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pEffects.Name = "pEffects"
        Me.pEffects.Size = New System.Drawing.Size(322, 1328)
        Me.pEffects.TabIndex = 0
        '
        'pEffectsPreview
        '
        Me.pEffectsPreview.Controls.Add(Me.GdViewer2)
        Me.pEffectsPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEffectsPreview.Location = New System.Drawing.Point(0, 916)
        Me.pEffectsPreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pEffectsPreview.Name = "pEffectsPreview"
        Me.pEffectsPreview.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.pEffectsPreview.Size = New System.Drawing.Size(322, 412)
        Me.pEffectsPreview.TabIndex = 14
        '
        'GdViewer2
        '
        Me.GdViewer2.AllowDropFile = false
        Me.GdViewer2.AnimateGIF = true
        Me.GdViewer2.AnnotationDropShadow = true
        Me.GdViewer2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.GdViewer2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.GdViewer2.BackColor = System.Drawing.SystemColors.Control
        Me.GdViewer2.BackgroundImage = Nothing
        Me.GdViewer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GdViewer2.ContinuousViewMode = false
        Me.GdViewer2.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.GdViewer2.DisplayQualityAuto = true
        Me.GdViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GdViewer2.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.GdViewer2.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.GdViewer2.EnabledProgressBar = false
        Me.GdViewer2.EnableICM = false
        Me.GdViewer2.EnableMenu = false
        Me.GdViewer2.EnableMouseWheel = false
        Me.GdViewer2.EnableTextSelection = false
        Me.GdViewer2.ForceScrollBars = false
        Me.GdViewer2.ForeColor = System.Drawing.Color.Black
        Me.GdViewer2.Gamma = 1!
        Me.GdViewer2.HQAnnotationRendering = true
        Me.GdViewer2.IgnoreDocumentResolution = false
        Me.GdViewer2.KeepDocumentPosition = false
        Me.GdViewer2.Location = New System.Drawing.Point(0, 8)
        Me.GdViewer2.LockViewer = false
        Me.GdViewer2.MagnifierHeight = 90
        Me.GdViewer2.MagnifierWidth = 160
        Me.GdViewer2.MagnifierZoomX = 2!
        Me.GdViewer2.MagnifierZoomY = 2!
        Me.GdViewer2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GdViewer2.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonNone
        Me.GdViewer2.MouseMode = GdPicture14.ViewerMouseMode.MouseModeDefault
        Me.GdViewer2.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeDisabled
        Me.GdViewer2.Name = "GdViewer2"
        Me.GdViewer2.PdfDisplayFormField = true
        Me.GdViewer2.PdfEnableFileLinks = true
        Me.GdViewer2.PdfEnableLinks = true
        Me.GdViewer2.PdfIncreaseTextContrast = false
        Me.GdViewer2.PdfShowDialogForPassword = true
        Me.GdViewer2.PdfShowOpenFileDialogForDecryption = true
        Me.GdViewer2.PdfVerifyDigitalCertificates = false
        Me.GdViewer2.RectBorderColor = System.Drawing.Color.Black
        Me.GdViewer2.RectBorderSize = 1
        Me.GdViewer2.RectIsEditable = false
        Me.GdViewer2.RegionsAreEditable = false
        Me.GdViewer2.ScrollBars = true
        Me.GdViewer2.ScrollLargeChange = CType(50,Short)
        Me.GdViewer2.ScrollSmallChange = CType(1,Short)
        Me.GdViewer2.SilentMode = true
        Me.GdViewer2.Size = New System.Drawing.Size(322, 404)
        Me.GdViewer2.TabIndex = 0
        Me.GdViewer2.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer2.Zoom = 1R
        Me.GdViewer2.ZoomCenterAtMousePosition = false
        Me.GdViewer2.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer2.ZoomStep = 25
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbConvolutionMatrix)
        Me.Panel3.Controls.Add(Me.rbConvolutionMatrix)
        Me.Panel3.Controls.Add(Me.pConfigurableEffects)
        Me.Panel3.Controls.Add(Me.rbConfigurableEffects)
        Me.Panel3.Controls.Add(Me.pDirectEffects)
        Me.Panel3.Controls.Add(Me.rbDirectEffects)
        Me.Panel3.Controls.Add(Me.btnResetEffects)
        Me.Panel3.Controls.Add(Me.btnApplyEffects)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 916)
        Me.Panel3.TabIndex = 0
        '
        'pConfigurableEffects
        '
        Me.pConfigurableEffects.AutoSize = true
        Me.pConfigurableEffects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pConfigurableEffects.Controls.Add(Me.pFloodFillEffect)
        Me.pConfigurableEffects.Controls.Add(Me.pFactorEffect)
        Me.pConfigurableEffects.Controls.Add(Me.pSubstractBackgroundEffect)
        Me.pConfigurableEffects.Controls.Add(Me.pSoftenValueEffect)
        Me.pConfigurableEffects.Controls.Add(Me.pRemoveBackgroundChromokeyEffect)
        Me.pConfigurableEffects.Controls.Add(Me.pWavesEffect)
        Me.pConfigurableEffects.Controls.Add(Me.pHaloEffect)
        Me.pConfigurableEffects.Controls.Add(Me.pKernelSizeEffect)
        Me.pConfigurableEffects.Controls.Add(Me.pColorizeEffect)
        Me.pConfigurableEffects.Controls.Add(Me.cbConfigurableEffects)
        Me.pConfigurableEffects.Location = New System.Drawing.Point(33, 114)
        Me.pConfigurableEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pConfigurableEffects.Name = "pConfigurableEffects"
        Me.pConfigurableEffects.Size = New System.Drawing.Size(441, 616)
        Me.pConfigurableEffects.TabIndex = 6
        '
        'pFloodFillEffect
        '
        Me.pFloodFillEffect.AutoSize = true
        Me.pFloodFillEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pFloodFillEffect.Controls.Add(Me.pbFloodFillEffectColor)
        Me.pFloodFillEffect.Controls.Add(Me.Label17)
        Me.pFloodFillEffect.Controls.Add(Me.Label18)
        Me.pFloodFillEffect.Controls.Add(Me.nFloodFillEffectYStart)
        Me.pFloodFillEffect.Controls.Add(Me.nFloodFillEffectXStart)
        Me.pFloodFillEffect.Controls.Add(Me.Label19)
        Me.pFloodFillEffect.Location = New System.Drawing.Point(4, 572)
        Me.pFloodFillEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pFloodFillEffect.Name = "pFloodFillEffect"
        Me.pFloodFillEffect.Size = New System.Drawing.Size(403, 39)
        Me.pFloodFillEffect.TabIndex = 7
        '
        'pbFloodFillEffectColor
        '
        Me.pbFloodFillEffectColor.BackColor = System.Drawing.Color.Black
        Me.pbFloodFillEffectColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFloodFillEffectColor.Location = New System.Drawing.Point(369, 3)
        Me.pbFloodFillEffectColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbFloodFillEffectColor.Name = "pbFloodFillEffectColor"
        Me.pbFloodFillEffectColor.Size = New System.Drawing.Size(30, 31)
        Me.pbFloodFillEffectColor.TabIndex = 11
        Me.pbFloodFillEffectColor.TabStop = false
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(314, 8)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 20)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Color"
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Location = New System.Drawing.Point(159, 8)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 20)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Y start"
        '
        'nFloodFillEffectYStart
        '
        Me.nFloodFillEffectYStart.Location = New System.Drawing.Point(224, 5)
        Me.nFloodFillEffectYStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nFloodFillEffectYStart.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nFloodFillEffectYStart.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nFloodFillEffectYStart.Name = "nFloodFillEffectYStart"
        Me.nFloodFillEffectYStart.Size = New System.Drawing.Size(81, 26)
        Me.nFloodFillEffectYStart.TabIndex = 3
        Me.nFloodFillEffectYStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nFloodFillEffectYStart.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nFloodFillEffectXStart
        '
        Me.nFloodFillEffectXStart.Location = New System.Drawing.Point(69, 5)
        Me.nFloodFillEffectXStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nFloodFillEffectXStart.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nFloodFillEffectXStart.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nFloodFillEffectXStart.Name = "nFloodFillEffectXStart"
        Me.nFloodFillEffectXStart.Size = New System.Drawing.Size(81, 26)
        Me.nFloodFillEffectXStart.TabIndex = 2
        Me.nFloodFillEffectXStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nFloodFillEffectXStart.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Location = New System.Drawing.Point(4, 8)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 20)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "X start"
        '
        'pFactorEffect
        '
        Me.pFactorEffect.AutoSize = true
        Me.pFactorEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pFactorEffect.Controls.Add(Me.nFactorEffect)
        Me.pFactorEffect.Controls.Add(Me.lblFactorEffect)
        Me.pFactorEffect.Location = New System.Drawing.Point(4, 529)
        Me.pFactorEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pFactorEffect.Name = "pFactorEffect"
        Me.pFactorEffect.Size = New System.Drawing.Size(159, 34)
        Me.pFactorEffect.TabIndex = 8
        '
        'nFactorEffect
        '
        Me.nFactorEffect.DecimalPlaces = 2
        Me.nFactorEffect.Location = New System.Drawing.Point(74, 3)
        Me.nFactorEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nFactorEffect.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nFactorEffect.Name = "nFactorEffect"
        Me.nFactorEffect.Size = New System.Drawing.Size(81, 26)
        Me.nFactorEffect.TabIndex = 7
        Me.nFactorEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nFactorEffect.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'lblFactorEffect
        '
        Me.lblFactorEffect.AutoSize = true
        Me.lblFactorEffect.Location = New System.Drawing.Point(3, 6)
        Me.lblFactorEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactorEffect.Name = "lblFactorEffect"
        Me.lblFactorEffect.Size = New System.Drawing.Size(55, 20)
        Me.lblFactorEffect.TabIndex = 6
        Me.lblFactorEffect.Text = "Factor"
        '
        'pSubstractBackgroundEffect
        '
        Me.pSubstractBackgroundEffect.AutoSize = true
        Me.pSubstractBackgroundEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pSubstractBackgroundEffect.Controls.Add(Me.chkLightBackgroundEffect)
        Me.pSubstractBackgroundEffect.Controls.Add(Me.nRollingBallSizeEffect)
        Me.pSubstractBackgroundEffect.Controls.Add(Me.lblRollingBallSizeEffect)
        Me.pSubstractBackgroundEffect.Location = New System.Drawing.Point(4, 485)
        Me.pSubstractBackgroundEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pSubstractBackgroundEffect.Name = "pSubstractBackgroundEffect"
        Me.pSubstractBackgroundEffect.Size = New System.Drawing.Size(384, 36)
        Me.pSubstractBackgroundEffect.TabIndex = 7
        '
        'chkLightBackgroundEffect
        '
        Me.chkLightBackgroundEffect.AutoSize = true
        Me.chkLightBackgroundEffect.Checked = true
        Me.chkLightBackgroundEffect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLightBackgroundEffect.Location = New System.Drawing.Point(222, 6)
        Me.chkLightBackgroundEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkLightBackgroundEffect.Name = "chkLightBackgroundEffect"
        Me.chkLightBackgroundEffect.Size = New System.Drawing.Size(158, 24)
        Me.chkLightBackgroundEffect.TabIndex = 9
        Me.chkLightBackgroundEffect.Text = "Light background"
        Me.chkLightBackgroundEffect.UseVisualStyleBackColor = true
        '
        'nRollingBallSizeEffect
        '
        Me.nRollingBallSizeEffect.Location = New System.Drawing.Point(132, 5)
        Me.nRollingBallSizeEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRollingBallSizeEffect.Maximum = New Decimal(New Integer() {1200, 0, 0, 0})
        Me.nRollingBallSizeEffect.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nRollingBallSizeEffect.Name = "nRollingBallSizeEffect"
        Me.nRollingBallSizeEffect.Size = New System.Drawing.Size(81, 26)
        Me.nRollingBallSizeEffect.TabIndex = 8
        Me.nRollingBallSizeEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nRollingBallSizeEffect.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblRollingBallSizeEffect
        '
        Me.lblRollingBallSizeEffect.AutoSize = true
        Me.lblRollingBallSizeEffect.Location = New System.Drawing.Point(4, 8)
        Me.lblRollingBallSizeEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRollingBallSizeEffect.Name = "lblRollingBallSizeEffect"
        Me.lblRollingBallSizeEffect.Size = New System.Drawing.Size(117, 20)
        Me.lblRollingBallSizeEffect.TabIndex = 0
        Me.lblRollingBallSizeEffect.Text = "Rolling ball size"
        '
        'pSoftenValueEffect
        '
        Me.pSoftenValueEffect.AutoSize = true
        Me.pSoftenValueEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pSoftenValueEffect.Controls.Add(Me.nSoftenValueEffect)
        Me.pSoftenValueEffect.Controls.Add(Me.lblSoftenValueEffect)
        Me.pSoftenValueEffect.Location = New System.Drawing.Point(4, 440)
        Me.pSoftenValueEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pSoftenValueEffect.Name = "pSoftenValueEffect"
        Me.pSoftenValueEffect.Size = New System.Drawing.Size(154, 36)
        Me.pSoftenValueEffect.TabIndex = 6
        '
        'nSoftenValueEffect
        '
        Me.nSoftenValueEffect.Location = New System.Drawing.Point(69, 5)
        Me.nSoftenValueEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nSoftenValueEffect.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nSoftenValueEffect.Name = "nSoftenValueEffect"
        Me.nSoftenValueEffect.Size = New System.Drawing.Size(81, 26)
        Me.nSoftenValueEffect.TabIndex = 7
        Me.nSoftenValueEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nSoftenValueEffect.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'lblSoftenValueEffect
        '
        Me.lblSoftenValueEffect.AutoSize = true
        Me.lblSoftenValueEffect.Location = New System.Drawing.Point(3, 8)
        Me.lblSoftenValueEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSoftenValueEffect.Name = "lblSoftenValueEffect"
        Me.lblSoftenValueEffect.Size = New System.Drawing.Size(50, 20)
        Me.lblSoftenValueEffect.TabIndex = 0
        Me.lblSoftenValueEffect.Text = "Value"
        '
        'pRemoveBackgroundChromokeyEffect
        '
        Me.pRemoveBackgroundChromokeyEffect.AutoSize = true
        Me.pRemoveBackgroundChromokeyEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pRemoveBackgroundChromokeyEffect.Controls.Add(Me.nMinKeyValueEffect)
        Me.pRemoveBackgroundChromokeyEffect.Controls.Add(Me.lblMinKeyValueEffect)
        Me.pRemoveBackgroundChromokeyEffect.Controls.Add(Me.nVariationEffect)
        Me.pRemoveBackgroundChromokeyEffect.Controls.Add(Me.lblVariationEffect)
        Me.pRemoveBackgroundChromokeyEffect.Controls.Add(Me.cbComponentEffect)
        Me.pRemoveBackgroundChromokeyEffect.Controls.Add(Me.lblComponentEffect)
        Me.pRemoveBackgroundChromokeyEffect.Location = New System.Drawing.Point(4, 309)
        Me.pRemoveBackgroundChromokeyEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pRemoveBackgroundChromokeyEffect.Name = "pRemoveBackgroundChromokeyEffect"
        Me.pRemoveBackgroundChromokeyEffect.Size = New System.Drawing.Size(247, 117)
        Me.pRemoveBackgroundChromokeyEffect.TabIndex = 5
        '
        'nMinKeyValueEffect
        '
        Me.nMinKeyValueEffect.Location = New System.Drawing.Point(105, 86)
        Me.nMinKeyValueEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nMinKeyValueEffect.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nMinKeyValueEffect.Name = "nMinKeyValueEffect"
        Me.nMinKeyValueEffect.Size = New System.Drawing.Size(81, 26)
        Me.nMinKeyValueEffect.TabIndex = 6
        Me.nMinKeyValueEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nMinKeyValueEffect.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblMinKeyValueEffect
        '
        Me.lblMinKeyValueEffect.AutoSize = true
        Me.lblMinKeyValueEffect.Location = New System.Drawing.Point(4, 89)
        Me.lblMinKeyValueEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinKeyValueEffect.Name = "lblMinKeyValueEffect"
        Me.lblMinKeyValueEffect.Size = New System.Drawing.Size(75, 20)
        Me.lblMinKeyValueEffect.TabIndex = 5
        Me.lblMinKeyValueEffect.Text = "Min value"
        '
        'nVariationEffect
        '
        Me.nVariationEffect.Location = New System.Drawing.Point(105, 46)
        Me.nVariationEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nVariationEffect.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.nVariationEffect.Name = "nVariationEffect"
        Me.nVariationEffect.Size = New System.Drawing.Size(81, 26)
        Me.nVariationEffect.TabIndex = 4
        Me.nVariationEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nVariationEffect.Value = New Decimal(New Integer() {240, 0, 0, 0})
        '
        'lblVariationEffect
        '
        Me.lblVariationEffect.AutoSize = true
        Me.lblVariationEffect.Location = New System.Drawing.Point(4, 49)
        Me.lblVariationEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariationEffect.Name = "lblVariationEffect"
        Me.lblVariationEffect.Size = New System.Drawing.Size(72, 20)
        Me.lblVariationEffect.TabIndex = 2
        Me.lblVariationEffect.Text = "Variation"
        '
        'cbComponentEffect
        '
        Me.cbComponentEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbComponentEffect.FormattingEnabled = true
        Me.cbComponentEffect.Items.AddRange(New Object() {"Blue", "Green", "Red"})
        Me.cbComponentEffect.Location = New System.Drawing.Point(105, 5)
        Me.cbComponentEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbComponentEffect.Name = "cbComponentEffect"
        Me.cbComponentEffect.Size = New System.Drawing.Size(138, 28)
        Me.cbComponentEffect.TabIndex = 1
        '
        'lblComponentEffect
        '
        Me.lblComponentEffect.AutoSize = true
        Me.lblComponentEffect.Location = New System.Drawing.Point(4, 9)
        Me.lblComponentEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComponentEffect.Name = "lblComponentEffect"
        Me.lblComponentEffect.Size = New System.Drawing.Size(92, 20)
        Me.lblComponentEffect.TabIndex = 0
        Me.lblComponentEffect.Text = "Component"
        '
        'pWavesEffect
        '
        Me.pWavesEffect.AutoSize = true
        Me.pWavesEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pWavesEffect.Controls.Add(Me.nHeightEffect)
        Me.pWavesEffect.Controls.Add(Me.lblHeightEffect)
        Me.pWavesEffect.Controls.Add(Me.nWidthEffect)
        Me.pWavesEffect.Controls.Add(Me.lblWidthEffect)
        Me.pWavesEffect.Location = New System.Drawing.Point(4, 265)
        Me.pWavesEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pWavesEffect.Name = "pWavesEffect"
        Me.pWavesEffect.Size = New System.Drawing.Size(303, 36)
        Me.pWavesEffect.TabIndex = 4
        '
        'nHeightEffect
        '
        Me.nHeightEffect.Location = New System.Drawing.Point(218, 5)
        Me.nHeightEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nHeightEffect.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nHeightEffect.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nHeightEffect.Name = "nHeightEffect"
        Me.nHeightEffect.Size = New System.Drawing.Size(81, 26)
        Me.nHeightEffect.TabIndex = 5
        Me.nHeightEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nHeightEffect.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblHeightEffect
        '
        Me.lblHeightEffect.AutoSize = true
        Me.lblHeightEffect.Location = New System.Drawing.Point(156, 8)
        Me.lblHeightEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeightEffect.Name = "lblHeightEffect"
        Me.lblHeightEffect.Size = New System.Drawing.Size(56, 20)
        Me.lblHeightEffect.TabIndex = 4
        Me.lblHeightEffect.Text = "Height"
        '
        'nWidthEffect
        '
        Me.nWidthEffect.Location = New System.Drawing.Point(66, 5)
        Me.nWidthEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nWidthEffect.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nWidthEffect.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nWidthEffect.Name = "nWidthEffect"
        Me.nWidthEffect.Size = New System.Drawing.Size(81, 26)
        Me.nWidthEffect.TabIndex = 3
        Me.nWidthEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nWidthEffect.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblWidthEffect
        '
        Me.lblWidthEffect.AutoSize = true
        Me.lblWidthEffect.Location = New System.Drawing.Point(4, 8)
        Me.lblWidthEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWidthEffect.Name = "lblWidthEffect"
        Me.lblWidthEffect.Size = New System.Drawing.Size(50, 20)
        Me.lblWidthEffect.TabIndex = 0
        Me.lblWidthEffect.Text = "Width"
        '
        'pHaloEffect
        '
        Me.pHaloEffect.AutoSize = true
        Me.pHaloEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pHaloEffect.Controls.Add(Me.lblRadiusEffect)
        Me.pHaloEffect.Controls.Add(Me.lblTopEffect)
        Me.pHaloEffect.Controls.Add(Me.nRadiusEffect)
        Me.pHaloEffect.Controls.Add(Me.nTopEffect)
        Me.pHaloEffect.Controls.Add(Me.nLeftEffect)
        Me.pHaloEffect.Controls.Add(Me.lblLeftEffect)
        Me.pHaloEffect.Location = New System.Drawing.Point(4, 215)
        Me.pHaloEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pHaloEffect.Name = "pHaloEffect"
        Me.pHaloEffect.Size = New System.Drawing.Size(433, 36)
        Me.pHaloEffect.TabIndex = 3
        '
        'lblRadiusEffect
        '
        Me.lblRadiusEffect.AutoSize = true
        Me.lblRadiusEffect.Location = New System.Drawing.Point(279, 8)
        Me.lblRadiusEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRadiusEffect.Name = "lblRadiusEffect"
        Me.lblRadiusEffect.Size = New System.Drawing.Size(59, 20)
        Me.lblRadiusEffect.TabIndex = 6
        Me.lblRadiusEffect.Text = "Radius"
        '
        'lblTopEffect
        '
        Me.lblTopEffect.AutoSize = true
        Me.lblTopEffect.Location = New System.Drawing.Point(141, 8)
        Me.lblTopEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTopEffect.Name = "lblTopEffect"
        Me.lblTopEffect.Size = New System.Drawing.Size(36, 20)
        Me.lblTopEffect.TabIndex = 5
        Me.lblTopEffect.Text = "Top"
        '
        'nRadiusEffect
        '
        Me.nRadiusEffect.Location = New System.Drawing.Point(348, 5)
        Me.nRadiusEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nRadiusEffect.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nRadiusEffect.Name = "nRadiusEffect"
        Me.nRadiusEffect.Size = New System.Drawing.Size(81, 26)
        Me.nRadiusEffect.TabIndex = 4
        Me.nRadiusEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nRadiusEffect.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nTopEffect
        '
        Me.nTopEffect.Location = New System.Drawing.Point(189, 5)
        Me.nTopEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nTopEffect.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nTopEffect.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nTopEffect.Name = "nTopEffect"
        Me.nTopEffect.Size = New System.Drawing.Size(81, 26)
        Me.nTopEffect.TabIndex = 3
        Me.nTopEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nTopEffect.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nLeftEffect
        '
        Me.nLeftEffect.Location = New System.Drawing.Point(51, 5)
        Me.nLeftEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nLeftEffect.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nLeftEffect.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nLeftEffect.Name = "nLeftEffect"
        Me.nLeftEffect.Size = New System.Drawing.Size(81, 26)
        Me.nLeftEffect.TabIndex = 2
        Me.nLeftEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nLeftEffect.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblLeftEffect
        '
        Me.lblLeftEffect.AutoSize = true
        Me.lblLeftEffect.Location = New System.Drawing.Point(4, 8)
        Me.lblLeftEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLeftEffect.Name = "lblLeftEffect"
        Me.lblLeftEffect.Size = New System.Drawing.Size(37, 20)
        Me.lblLeftEffect.TabIndex = 0
        Me.lblLeftEffect.Text = "Left"
        '
        'pKernelSizeEffect
        '
        Me.pKernelSizeEffect.AutoSize = true
        Me.pKernelSizeEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pKernelSizeEffect.Controls.Add(Me.nKernelSizeEffect)
        Me.pKernelSizeEffect.Controls.Add(Me.lblKernelSizeEffect)
        Me.pKernelSizeEffect.Location = New System.Drawing.Point(4, 171)
        Me.pKernelSizeEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pKernelSizeEffect.Name = "pKernelSizeEffect"
        Me.pKernelSizeEffect.Size = New System.Drawing.Size(181, 36)
        Me.pKernelSizeEffect.TabIndex = 2
        '
        'nKernelSizeEffect
        '
        Me.nKernelSizeEffect.Location = New System.Drawing.Point(96, 5)
        Me.nKernelSizeEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nKernelSizeEffect.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nKernelSizeEffect.Name = "nKernelSizeEffect"
        Me.nKernelSizeEffect.Size = New System.Drawing.Size(81, 26)
        Me.nKernelSizeEffect.TabIndex = 1
        Me.nKernelSizeEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nKernelSizeEffect.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblKernelSizeEffect
        '
        Me.lblKernelSizeEffect.AutoSize = true
        Me.lblKernelSizeEffect.Location = New System.Drawing.Point(4, 8)
        Me.lblKernelSizeEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKernelSizeEffect.Name = "lblKernelSizeEffect"
        Me.lblKernelSizeEffect.Size = New System.Drawing.Size(86, 20)
        Me.lblKernelSizeEffect.TabIndex = 0
        Me.lblKernelSizeEffect.Text = "Kernel size"
        '
        'pColorizeEffect
        '
        Me.pColorizeEffect.AutoSize = true
        Me.pColorizeEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pColorizeEffect.Controls.Add(Me.nLuminosityEffect)
        Me.pColorizeEffect.Controls.Add(Me.lblLuminosityEffect)
        Me.pColorizeEffect.Controls.Add(Me.nSaturationEffect)
        Me.pColorizeEffect.Controls.Add(Me.lblSaturationEffect)
        Me.pColorizeEffect.Controls.Add(Me.nHueEffect)
        Me.pColorizeEffect.Controls.Add(Me.lblHueEffect)
        Me.pColorizeEffect.Location = New System.Drawing.Point(4, 46)
        Me.pColorizeEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pColorizeEffect.Name = "pColorizeEffect"
        Me.pColorizeEffect.Size = New System.Drawing.Size(181, 116)
        Me.pColorizeEffect.TabIndex = 1
        '
        'nLuminosityEffect
        '
        Me.nLuminosityEffect.DecimalPlaces = 2
        Me.nLuminosityEffect.Location = New System.Drawing.Point(96, 85)
        Me.nLuminosityEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nLuminosityEffect.Name = "nLuminosityEffect"
        Me.nLuminosityEffect.Size = New System.Drawing.Size(81, 26)
        Me.nLuminosityEffect.TabIndex = 5
        Me.nLuminosityEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nLuminosityEffect.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'lblLuminosityEffect
        '
        Me.lblLuminosityEffect.AutoSize = true
        Me.lblLuminosityEffect.Location = New System.Drawing.Point(3, 88)
        Me.lblLuminosityEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLuminosityEffect.Name = "lblLuminosityEffect"
        Me.lblLuminosityEffect.Size = New System.Drawing.Size(84, 20)
        Me.lblLuminosityEffect.TabIndex = 4
        Me.lblLuminosityEffect.Text = "Luminosity"
        '
        'nSaturationEffect
        '
        Me.nSaturationEffect.DecimalPlaces = 2
        Me.nSaturationEffect.Location = New System.Drawing.Point(96, 45)
        Me.nSaturationEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nSaturationEffect.Name = "nSaturationEffect"
        Me.nSaturationEffect.Size = New System.Drawing.Size(81, 26)
        Me.nSaturationEffect.TabIndex = 3
        Me.nSaturationEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nSaturationEffect.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblSaturationEffect
        '
        Me.lblSaturationEffect.AutoSize = true
        Me.lblSaturationEffect.Location = New System.Drawing.Point(4, 48)
        Me.lblSaturationEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaturationEffect.Name = "lblSaturationEffect"
        Me.lblSaturationEffect.Size = New System.Drawing.Size(83, 20)
        Me.lblSaturationEffect.TabIndex = 2
        Me.lblSaturationEffect.Text = "Saturation"
        '
        'nHueEffect
        '
        Me.nHueEffect.DecimalPlaces = 2
        Me.nHueEffect.Location = New System.Drawing.Point(96, 5)
        Me.nHueEffect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nHueEffect.Name = "nHueEffect"
        Me.nHueEffect.Size = New System.Drawing.Size(81, 26)
        Me.nHueEffect.TabIndex = 1
        Me.nHueEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nHueEffect.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblHueEffect
        '
        Me.lblHueEffect.AutoSize = true
        Me.lblHueEffect.Location = New System.Drawing.Point(4, 8)
        Me.lblHueEffect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHueEffect.Name = "lblHueEffect"
        Me.lblHueEffect.Size = New System.Drawing.Size(39, 20)
        Me.lblHueEffect.TabIndex = 0
        Me.lblHueEffect.Text = "Hue"
        '
        'cbConfigurableEffects
        '
        Me.cbConfigurableEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConfigurableEffects.FormattingEnabled = true
        Me.cbConfigurableEffects.Location = New System.Drawing.Point(4, 5)
        Me.cbConfigurableEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbConfigurableEffects.Name = "cbConfigurableEffects"
        Me.cbConfigurableEffects.Size = New System.Drawing.Size(247, 28)
        Me.cbConfigurableEffects.TabIndex = 0
        '
        'rbConfigurableEffects
        '
        Me.rbConfigurableEffects.AutoSize = true
        Me.rbConfigurableEffects.Location = New System.Drawing.Point(4, 78)
        Me.rbConfigurableEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbConfigurableEffects.Name = "rbConfigurableEffects"
        Me.rbConfigurableEffects.Size = New System.Drawing.Size(177, 24)
        Me.rbConfigurableEffects.TabIndex = 5
        Me.rbConfigurableEffects.TabStop = true
        Me.rbConfigurableEffects.Text = "Configurable effects"
        Me.rbConfigurableEffects.UseVisualStyleBackColor = true
        '
        'pDirectEffects
        '
        Me.pDirectEffects.AutoSize = true
        Me.pDirectEffects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pDirectEffects.Controls.Add(Me.cbDirectEffects)
        Me.pDirectEffects.Location = New System.Drawing.Point(33, 28)
        Me.pDirectEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pDirectEffects.Name = "pDirectEffects"
        Me.pDirectEffects.Size = New System.Drawing.Size(188, 38)
        Me.pDirectEffects.TabIndex = 4
        '
        'cbDirectEffects
        '
        Me.cbDirectEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDirectEffects.FormattingEnabled = true
        Me.cbDirectEffects.Location = New System.Drawing.Point(4, 5)
        Me.cbDirectEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbDirectEffects.Name = "cbDirectEffects"
        Me.cbDirectEffects.Size = New System.Drawing.Size(180, 28)
        Me.cbDirectEffects.TabIndex = 2
        '
        'rbDirectEffects
        '
        Me.rbDirectEffects.AutoSize = true
        Me.rbDirectEffects.Location = New System.Drawing.Point(4, 5)
        Me.rbDirectEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbDirectEffects.Name = "rbDirectEffects"
        Me.rbDirectEffects.Size = New System.Drawing.Size(129, 24)
        Me.rbDirectEffects.TabIndex = 3
        Me.rbDirectEffects.TabStop = true
        Me.rbDirectEffects.Text = "Direct effects"
        Me.rbDirectEffects.UseVisualStyleBackColor = true
        '
        'btnResetEffects
        '
        Me.btnResetEffects.Location = New System.Drawing.Point(33, 866)
        Me.btnResetEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnResetEffects.Name = "btnResetEffects"
        Me.btnResetEffects.Size = New System.Drawing.Size(112, 35)
        Me.btnResetEffects.TabIndex = 1
        Me.btnResetEffects.Text = "Reset"
        Me.btnResetEffects.UseVisualStyleBackColor = true
        '
        'btnApplyEffects
        '
        Me.btnApplyEffects.Location = New System.Drawing.Point(154, 866)
        Me.btnApplyEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApplyEffects.Name = "btnApplyEffects"
        Me.btnApplyEffects.Size = New System.Drawing.Size(112, 35)
        Me.btnApplyEffects.TabIndex = 0
        Me.btnApplyEffects.Text = "Apply"
        Me.btnApplyEffects.UseVisualStyleBackColor = true
        '
        'scMain
        '
        Me.scMain.BackColor = System.Drawing.SystemColors.Control
        Me.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.scMain.Name = "scMain"
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.scMain.Panel1.Controls.Add(Me.Panel6)
        Me.scMain.Panel1MinSize = 256
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.GdViewer1)
        Me.scMain.Panel2MinSize = 200
        Me.scMain.Size = New System.Drawing.Size(1896, 1447)
        Me.scMain.SplitterDistance = 388
        Me.scMain.SplitterWidth = 6
        Me.scMain.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.pSnapInButtons)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(386, 1445)
        Me.Panel6.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Controls.Add(Me.tcLeftPanel)
        Me.Panel9.Controls.Add(Me.Panel7)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(48, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(338, 1445)
        Me.Panel9.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.lblSnapInPanel)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(338, 49)
        Me.Panel7.TabIndex = 6
        '
        'lblSnapInPanel
        '
        Me.lblSnapInPanel.AutoSize = true
        Me.lblSnapInPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblSnapInPanel.Location = New System.Drawing.Point(9, 12)
        Me.lblSnapInPanel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSnapInPanel.Name = "lblSnapInPanel"
        Me.lblSnapInPanel.Size = New System.Drawing.Size(159, 22)
        Me.lblSnapInPanel.TabIndex = 0
        Me.lblSnapInPanel.Text = "Image properties"
        '
        'pSnapInButtons
        '
        Me.pSnapInButtons.AutoSize = true
        Me.pSnapInButtons.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInThumbnails)
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInImageProperties)
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInAdjustment)
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInTransform)
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInColorOperations)
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInEffects)
        Me.pSnapInButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.pSnapInButtons.Location = New System.Drawing.Point(0, 0)
        Me.pSnapInButtons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pSnapInButtons.Name = "pSnapInButtons"
        Me.pSnapInButtons.Size = New System.Drawing.Size(48, 1445)
        Me.pSnapInButtons.TabIndex = 4
        '
        'btnSnapInThumbnails
        '
        Me.btnSnapInThumbnails.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInThumbnails.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSnapInThumbnails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInThumbnails.Image = CType(resources.GetObject("btnSnapInThumbnails.Image"),System.Drawing.Image)
        Me.btnSnapInThumbnails.Location = New System.Drawing.Point(0, 0)
        Me.btnSnapInThumbnails.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInThumbnails.Name = "btnSnapInThumbnails"
        Me.btnSnapInThumbnails.Size = New System.Drawing.Size(48, 49)
        Me.btnSnapInThumbnails.TabIndex = 5
        Me.btnSnapInThumbnails.UseVisualStyleBackColor = false
        '
        'btnSnapInImageProperties
        '
        Me.btnSnapInImageProperties.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInImageProperties.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSnapInImageProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInImageProperties.Image = CType(resources.GetObject("btnSnapInImageProperties.Image"),System.Drawing.Image)
        Me.btnSnapInImageProperties.Location = New System.Drawing.Point(0, 48)
        Me.btnSnapInImageProperties.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInImageProperties.Name = "btnSnapInImageProperties"
        Me.btnSnapInImageProperties.Size = New System.Drawing.Size(48, 49)
        Me.btnSnapInImageProperties.TabIndex = 0
        Me.btnSnapInImageProperties.UseVisualStyleBackColor = false
        '
        'btnSnapInAdjustment
        '
        Me.btnSnapInAdjustment.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInAdjustment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.btnSnapInAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInAdjustment.Image = CType(resources.GetObject("btnSnapInAdjustment.Image"),System.Drawing.Image)
        Me.btnSnapInAdjustment.Location = New System.Drawing.Point(0, 95)
        Me.btnSnapInAdjustment.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInAdjustment.Name = "btnSnapInAdjustment"
        Me.btnSnapInAdjustment.Size = New System.Drawing.Size(48, 49)
        Me.btnSnapInAdjustment.TabIndex = 1
        Me.btnSnapInAdjustment.UseVisualStyleBackColor = false
        '
        'btnSnapInTransform
        '
        Me.btnSnapInTransform.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInTransform.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.btnSnapInTransform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInTransform.Image = CType(resources.GetObject("btnSnapInTransform.Image"),System.Drawing.Image)
        Me.btnSnapInTransform.Location = New System.Drawing.Point(0, 143)
        Me.btnSnapInTransform.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInTransform.Name = "btnSnapInTransform"
        Me.btnSnapInTransform.Size = New System.Drawing.Size(48, 49)
        Me.btnSnapInTransform.TabIndex = 2
        Me.btnSnapInTransform.UseVisualStyleBackColor = false
        '
        'btnSnapInColorOperations
        '
        Me.btnSnapInColorOperations.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInColorOperations.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.btnSnapInColorOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInColorOperations.Image = CType(resources.GetObject("btnSnapInColorOperations.Image"),System.Drawing.Image)
        Me.btnSnapInColorOperations.Location = New System.Drawing.Point(0, 191)
        Me.btnSnapInColorOperations.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInColorOperations.Name = "btnSnapInColorOperations"
        Me.btnSnapInColorOperations.Size = New System.Drawing.Size(48, 49)
        Me.btnSnapInColorOperations.TabIndex = 3
        Me.btnSnapInColorOperations.UseVisualStyleBackColor = false
        '
        'btnSnapInEffects
        '
        Me.btnSnapInEffects.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInEffects.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.btnSnapInEffects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInEffects.Image = CType(resources.GetObject("btnSnapInEffects.Image"),System.Drawing.Image)
        Me.btnSnapInEffects.Location = New System.Drawing.Point(0, 238)
        Me.btnSnapInEffects.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInEffects.Name = "btnSnapInEffects"
        Me.btnSnapInEffects.Size = New System.Drawing.Size(48, 49)
        Me.btnSnapInEffects.TabIndex = 4
        Me.btnSnapInEffects.UseVisualStyleBackColor = false
        '
        'GdViewer1
        '
        Me.GdViewer1.AllowDropFile = false
        Me.GdViewer1.AnimateGIF = true
        Me.GdViewer1.AnnotationDropShadow = true
        Me.GdViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.GdViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.GdViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GdViewer1.BackgroundImage = Nothing
        Me.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GdViewer1.ContinuousViewMode = true
        Me.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.GdViewer1.DisplayQualityAuto = true
        Me.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.GdViewer1.EnabledProgressBar = true
        Me.GdViewer1.EnableICM = false
        Me.GdViewer1.EnableMenu = true
        Me.GdViewer1.EnableMouseWheel = true
        Me.GdViewer1.EnableTextSelection = true
        Me.GdViewer1.ForceScrollBars = false
        Me.GdViewer1.ForeColor = System.Drawing.Color.Black
        Me.GdViewer1.Gamma = 1!
        Me.GdViewer1.HQAnnotationRendering = true
        Me.GdViewer1.IgnoreDocumentResolution = false
        Me.GdViewer1.KeepDocumentPosition = false
        Me.GdViewer1.Location = New System.Drawing.Point(0, 0)
        Me.GdViewer1.LockViewer = false
        Me.GdViewer1.MagnifierHeight = 90
        Me.GdViewer1.MagnifierWidth = 160
        Me.GdViewer1.MagnifierZoomX = 2!
        Me.GdViewer1.MagnifierZoomY = 2!
        Me.GdViewer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
        Me.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom
        Me.GdViewer1.Name = "GdViewer1"
        Me.GdViewer1.PdfDisplayFormField = true
        Me.GdViewer1.PdfEnableFileLinks = true
        Me.GdViewer1.PdfEnableLinks = true
        Me.GdViewer1.PdfIncreaseTextContrast = false
        Me.GdViewer1.PdfShowDialogForPassword = true
        Me.GdViewer1.PdfShowOpenFileDialogForDecryption = true
        Me.GdViewer1.PdfVerifyDigitalCertificates = false
        Me.GdViewer1.RectBorderColor = System.Drawing.Color.Black
        Me.GdViewer1.RectBorderSize = 1
        Me.GdViewer1.RectIsEditable = true
        Me.GdViewer1.RegionsAreEditable = true
        Me.GdViewer1.ScrollBars = true
        Me.GdViewer1.ScrollLargeChange = CType(50,Short)
        Me.GdViewer1.ScrollSmallChange = CType(1,Short)
        Me.GdViewer1.SilentMode = true
        Me.GdViewer1.Size = New System.Drawing.Size(1500, 1445)
        Me.GdViewer1.TabIndex = 0
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 1R
        Me.GdViewer1.ZoomCenterAtMousePosition = false
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer1.ZoomStep = 25
        '
        'statusbar
        '
        Me.statusbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblImageInfo, Me.lblImageSize, Me.lblMousePosition})
        Me.statusbar.Location = New System.Drawing.Point(0, 1482)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.statusbar.Size = New System.Drawing.Size(1896, 22)
        Me.statusbar.TabIndex = 3
        Me.statusbar.Text = "StatusStrip1"
        '
        'lblImageInfo
        '
        Me.lblImageInfo.Name = "lblImageInfo"
        Me.lblImageInfo.Size = New System.Drawing.Size(1673, 17)
        Me.lblImageInfo.Spring = true
        Me.lblImageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblImageSize
        '
        Me.lblImageSize.AutoSize = false
        Me.lblImageSize.Image = CType(resources.GetObject("lblImageSize.Image"),System.Drawing.Image)
        Me.lblImageSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblImageSize.Name = "lblImageSize"
        Me.lblImageSize.Size = New System.Drawing.Size(100, 17)
        '
        'lblMousePosition
        '
        Me.lblMousePosition.AutoSize = false
        Me.lblMousePosition.Image = CType(resources.GetObject("lblMousePosition.Image"),System.Drawing.Image)
        Me.lblMousePosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMousePosition.Name = "lblMousePosition"
        Me.lblMousePosition.Size = New System.Drawing.Size(100, 17)
        Me.lblMousePosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainToolStrip
        '
        Me.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.ToolStripSeparator9, Me.btnClose, Me.btnPrint, Me.btnSave, Me.ToolStripSeparator3, Me.btnCopyToClipboard, Me.btnImportFromClipboard, Me.ToolStripSeparator1, Me.btnSettings, Me.ToolStripSeparator8, Me.btnMouseMode, Me.ToolStripSeparator4, Me.btnFirstPage, Me.btnPreviousPage, Me.tbCurrentPage, Me.lblPageCount, Me.btnNextPage, Me.btnLastPage, Me.ToolStripSeparator6, Me.btnZoomOut, Me.cbZoom, Me.btnZoomIn, Me.ToolStripSeparator2, Me.btnFitWidth, Me.btnFitPage, Me.ToolStripSeparator5, Me.btnAbout})
        Me.mainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainToolStrip.Name = "mainToolStrip"
        Me.mainToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.mainToolStrip.Size = New System.Drawing.Size(1896, 35)
        Me.mainToolStrip.TabIndex = 5
        Me.mainToolStrip.Text = "ToolStrip1"
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"),System.Drawing.Image)
        Me.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(147, 32)
        Me.btnOpen.Text = "Open image"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Margin = New System.Windows.Forms.Padding(5, 0, 10, 0)
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 35)
        '
        'btnClose
        '
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"),System.Drawing.Image)
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 32)
        Me.btnClose.Text = "Close document"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"),System.Drawing.Image)
        Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(28, 32)
        Me.btnPrint.Text = "Print document"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"),System.Drawing.Image)
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(28, 32)
        Me.btnSave.Text = "Save image"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 35)
        '
        'btnCopyToClipboard
        '
        Me.btnCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopyToClipboard.Image = CType(resources.GetObject("btnCopyToClipboard.Image"),System.Drawing.Image)
        Me.btnCopyToClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopyToClipboard.Name = "btnCopyToClipboard"
        Me.btnCopyToClipboard.Size = New System.Drawing.Size(28, 32)
        Me.btnCopyToClipboard.Text = "Copy to clipboard"
        '
        'btnImportFromClipboard
        '
        Me.btnImportFromClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImportFromClipboard.Image = CType(resources.GetObject("btnImportFromClipboard.Image"),System.Drawing.Image)
        Me.btnImportFromClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnImportFromClipboard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImportFromClipboard.Name = "btnImportFromClipboard"
        Me.btnImportFromClipboard.Size = New System.Drawing.Size(28, 32)
        Me.btnImportFromClipboard.Text = "Import from clipboard"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'btnSettings
        '
        Me.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"),System.Drawing.Image)
        Me.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(28, 32)
        Me.btnSettings.Text = "Viewer settings"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 35)
        '
        'btnMouseMode
        '
        Me.btnMouseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMouseMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.AreaSelectionToolStripMenuItem, Me.PanToolStripMenuItem, Me.AreaZoomingToolStripMenuItem, Me.MagnifierToolStripMenuItem})
        Me.btnMouseMode.Image = CType(resources.GetObject("btnMouseMode.Image"),System.Drawing.Image)
        Me.btnMouseMode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMouseMode.Name = "btnMouseMode"
        Me.btnMouseMode.Size = New System.Drawing.Size(42, 32)
        Me.btnMouseMode.Text = "Mouse mode"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.CheckOnClick = true
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(209, 30)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'AreaSelectionToolStripMenuItem
        '
        Me.AreaSelectionToolStripMenuItem.CheckOnClick = true
        Me.AreaSelectionToolStripMenuItem.Name = "AreaSelectionToolStripMenuItem"
        Me.AreaSelectionToolStripMenuItem.Size = New System.Drawing.Size(209, 30)
        Me.AreaSelectionToolStripMenuItem.Text = "Area selection"
        '
        'PanToolStripMenuItem
        '
        Me.PanToolStripMenuItem.Checked = true
        Me.PanToolStripMenuItem.CheckOnClick = true
        Me.PanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PanToolStripMenuItem.Name = "PanToolStripMenuItem"
        Me.PanToolStripMenuItem.Size = New System.Drawing.Size(209, 30)
        Me.PanToolStripMenuItem.Text = "Pan"
        '
        'AreaZoomingToolStripMenuItem
        '
        Me.AreaZoomingToolStripMenuItem.CheckOnClick = true
        Me.AreaZoomingToolStripMenuItem.Name = "AreaZoomingToolStripMenuItem"
        Me.AreaZoomingToolStripMenuItem.Size = New System.Drawing.Size(209, 30)
        Me.AreaZoomingToolStripMenuItem.Text = "Area zooming"
        '
        'MagnifierToolStripMenuItem
        '
        Me.MagnifierToolStripMenuItem.CheckOnClick = true
        Me.MagnifierToolStripMenuItem.Name = "MagnifierToolStripMenuItem"
        Me.MagnifierToolStripMenuItem.Size = New System.Drawing.Size(209, 30)
        Me.MagnifierToolStripMenuItem.Text = "Magnifier"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 35)
        '
        'btnFirstPage
        '
        Me.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFirstPage.Image = CType(resources.GetObject("btnFirstPage.Image"),System.Drawing.Image)
        Me.btnFirstPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(28, 32)
        Me.btnFirstPage.Text = "Go to first page"
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPreviousPage.Image = CType(resources.GetObject("btnPreviousPage.Image"),System.Drawing.Image)
        Me.btnPreviousPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(28, 32)
        Me.btnPreviousPage.Text = "Go to previous page"
        '
        'tbCurrentPage
        '
        Me.tbCurrentPage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbCurrentPage.Name = "tbCurrentPage"
        Me.tbCurrentPage.Size = New System.Drawing.Size(58, 35)
        Me.tbCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPageCount
        '
        Me.lblPageCount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPageCount.Name = "lblPageCount"
        Me.lblPageCount.Size = New System.Drawing.Size(37, 32)
        Me.lblPageCount.Text = "/ X"
        '
        'btnNextPage
        '
        Me.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNextPage.Image = CType(resources.GetObject("btnNextPage.Image"),System.Drawing.Image)
        Me.btnNextPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(28, 32)
        Me.btnNextPage.Text = "Go to next page"
        '
        'btnLastPage
        '
        Me.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLastPage.Image = CType(resources.GetObject("btnLastPage.Image"),System.Drawing.Image)
        Me.btnLastPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(28, 32)
        Me.btnLastPage.Text = "Go to last page"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Margin = New System.Windows.Forms.Padding(5, 0, 10, 0)
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 35)
        '
        'btnZoomOut
        '
        Me.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomOut.Image = CType(resources.GetObject("btnZoomOut.Image"),System.Drawing.Image)
        Me.btnZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(28, 32)
        Me.btnZoomOut.Text = "Zoom out"
        '
        'cbZoom
        '
        Me.cbZoom.DropDownWidth = 200
        Me.cbZoom.Name = "cbZoom"
        Me.cbZoom.Size = New System.Drawing.Size(110, 35)
        '
        'btnZoomIn
        '
        Me.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomIn.Image = CType(resources.GetObject("btnZoomIn.Image"),System.Drawing.Image)
        Me.btnZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(28, 32)
        Me.btnZoomIn.Text = "Zoom In"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 35)
        '
        'btnFitWidth
        '
        Me.btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFitWidth.Image = CType(resources.GetObject("btnFitWidth.Image"),System.Drawing.Image)
        Me.btnFitWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFitWidth.Name = "btnFitWidth"
        Me.btnFitWidth.Size = New System.Drawing.Size(28, 32)
        Me.btnFitWidth.Text = "Adjust to page width"
        '
        'btnFitPage
        '
        Me.btnFitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFitPage.Image = CType(resources.GetObject("btnFitPage.Image"),System.Drawing.Image)
        Me.btnFitPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFitPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFitPage.Name = "btnFitPage"
        Me.btnFitPage.Size = New System.Drawing.Size(28, 32)
        Me.btnFitPage.Text = "Adjust to whole page"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 35)
        '
        'btnAbout
        '
        Me.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"),System.Drawing.Image)
        Me.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(28, 32)
        Me.btnAbout.Text = "About"
        '
        'pMain
        '
        Me.pMain.Controls.Add(Me.scMain)
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(0, 35)
        Me.pMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(1896, 1447)
        Me.pMain.TabIndex = 6
        '
        'rbConvolutionMatrix
        '
        Me.rbConvolutionMatrix.AutoSize = true
        Me.rbConvolutionMatrix.Location = New System.Drawing.Point(5, 747)
        Me.rbConvolutionMatrix.Name = "rbConvolutionMatrix"
        Me.rbConvolutionMatrix.Size = New System.Drawing.Size(205, 24)
        Me.rbConvolutionMatrix.TabIndex = 7
        Me.rbConvolutionMatrix.TabStop = true
        Me.rbConvolutionMatrix.Text = "Convolution matrix filters"
        Me.rbConvolutionMatrix.UseVisualStyleBackColor = true
        '
        'cbConvolutionMatrix
        '
        Me.cbConvolutionMatrix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConvolutionMatrix.FormattingEnabled = true
        Me.cbConvolutionMatrix.Location = New System.Drawing.Point(33, 780)
        Me.cbConvolutionMatrix.Name = "cbConvolutionMatrix"
        Me.cbConvolutionMatrix.Size = New System.Drawing.Size(184, 28)
        Me.cbConvolutionMatrix.TabIndex = 8
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1896, 1504)
        Me.Controls.Add(Me.pMain)
        Me.Controls.Add(Me.mainToolStrip)
        Me.Controls.Add(Me.statusbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GdPicture .NET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tcLeftPanel.ResumeLayout(false)
        Me.tpThumbnails.ResumeLayout(false)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(false)
        Me.ToolStripContainer1.ResumeLayout(false)
        Me.ToolStripContainer1.PerformLayout
        Me.thumbnailPanelToolstrip.ResumeLayout(false)
        Me.thumbnailPanelToolstrip.PerformLayout
        Me.tpImageProperties.ResumeLayout(false)
        Me.pImageProperties.ResumeLayout(false)
        Me.tpAdjustment.ResumeLayout(false)
        Me.pAdjustment.ResumeLayout(false)
        Me.pAdjustment.PerformLayout
        Me.pAdjustPreview.ResumeLayout(false)
        CType(Me.adjustPeviewViewer,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel8.ResumeLayout(false)
        Me.gpBlue.ResumeLayout(false)
        Me.gpBlue.PerformLayout
        CType(Me.tbBlue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbBlue,System.ComponentModel.ISupportInitialize).EndInit
        Me.gpGreen.ResumeLayout(false)
        Me.gpGreen.PerformLayout
        CType(Me.tbGreen,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbGreen,System.ComponentModel.ISupportInitialize).EndInit
        Me.gpRed.ResumeLayout(false)
        Me.gpRed.PerformLayout
        CType(Me.tbRed,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbRed,System.ComponentModel.ISupportInitialize).EndInit
        Me.gpGamma.ResumeLayout(false)
        Me.gpGamma.PerformLayout
        CType(Me.tbGamma,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbGamma,System.ComponentModel.ISupportInitialize).EndInit
        Me.gpSaturation.ResumeLayout(false)
        Me.gpSaturation.PerformLayout
        CType(Me.tbSaturation,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbSaturation,System.ComponentModel.ISupportInitialize).EndInit
        Me.gpContrast.ResumeLayout(false)
        Me.gpContrast.PerformLayout
        CType(Me.tbContrast,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbContrast,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpBrightness.ResumeLayout(false)
        Me.grpBrightness.PerformLayout
        CType(Me.tbBrightness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbBrightness,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpTransform.ResumeLayout(false)
        Me.pTransform.ResumeLayout(false)
        Me.gpRotation.ResumeLayout(false)
        Me.gpRotation.PerformLayout
        Me.pCustomAngle.ResumeLayout(false)
        Me.pCustomAngle.PerformLayout
        Me.pRotationPreview.ResumeLayout(false)
        CType(Me.rotationPeviewViewer,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.pbRotationBackColor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nRotationAngle,System.ComponentModel.ISupportInitialize).EndInit
        Me.gpImageSize.ResumeLayout(false)
        Me.gpImageSize.PerformLayout
        Me.gpDocumentSize.ResumeLayout(false)
        Me.gpDocumentSize.PerformLayout
        CType(Me.nVerticalResolution,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nHorizontalResolution,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nDocumentHeight,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nDocumentWidth,System.ComponentModel.ISupportInitialize).EndInit
        Me.gpPixelDimensions.ResumeLayout(false)
        Me.gpPixelDimensions.PerformLayout
        CType(Me.nHeight,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nWidth,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nScalePercent,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpColorOperations.ResumeLayout(false)
        Me.pColorOperations.ResumeLayout(false)
        Me.gpColorChannelsManipulation.ResumeLayout(false)
        Me.gpColorChannelsManipulation.PerformLayout
        Me.pColorChannelsViewer.ResumeLayout(false)
        CType(Me.colorChannelPreviewViewer,System.ComponentModel.ISupportInitialize).EndInit
        Me.pColorManipulation.ResumeLayout(false)
        Me.pColorManipulation.PerformLayout
        Me.pRemoveComponent.ResumeLayout(false)
        Me.pRemoveComponent.PerformLayout
        Me.pScaleColors.ResumeLayout(false)
        Me.pScaleBlue.ResumeLayout(false)
        Me.pScaleBlue.PerformLayout
        CType(Me.tbScaleBlue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.pScaleRed.ResumeLayout(false)
        Me.pScaleRed.PerformLayout
        CType(Me.tbScaleRed,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.pScaleGreen.ResumeLayout(false)
        Me.pScaleGreen.PerformLayout
        CType(Me.tbScaleGreen,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.pKeepComponent.ResumeLayout(false)
        Me.pKeepComponent.PerformLayout
        Me.pSwapColors.ResumeLayout(false)
        Me.gpPixelFormat.ResumeLayout(false)
        Me.gpPixelFormat.PerformLayout
        Me.tpEffects.ResumeLayout(false)
        Me.pEffects.ResumeLayout(false)
        Me.pEffectsPreview.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.pConfigurableEffects.ResumeLayout(false)
        Me.pConfigurableEffects.PerformLayout
        Me.pFloodFillEffect.ResumeLayout(false)
        Me.pFloodFillEffect.PerformLayout
        CType(Me.pbFloodFillEffectColor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nFloodFillEffectYStart,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nFloodFillEffectXStart,System.ComponentModel.ISupportInitialize).EndInit
        Me.pFactorEffect.ResumeLayout(false)
        Me.pFactorEffect.PerformLayout
        CType(Me.nFactorEffect,System.ComponentModel.ISupportInitialize).EndInit
        Me.pSubstractBackgroundEffect.ResumeLayout(false)
        Me.pSubstractBackgroundEffect.PerformLayout
        CType(Me.nRollingBallSizeEffect,System.ComponentModel.ISupportInitialize).EndInit
        Me.pSoftenValueEffect.ResumeLayout(false)
        Me.pSoftenValueEffect.PerformLayout
        CType(Me.nSoftenValueEffect,System.ComponentModel.ISupportInitialize).EndInit
        Me.pRemoveBackgroundChromokeyEffect.ResumeLayout(false)
        Me.pRemoveBackgroundChromokeyEffect.PerformLayout
        CType(Me.nMinKeyValueEffect,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nVariationEffect,System.ComponentModel.ISupportInitialize).EndInit
        Me.pWavesEffect.ResumeLayout(false)
        Me.pWavesEffect.PerformLayout
        CType(Me.nHeightEffect,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nWidthEffect,System.ComponentModel.ISupportInitialize).EndInit
        Me.pHaloEffect.ResumeLayout(false)
        Me.pHaloEffect.PerformLayout
        CType(Me.nRadiusEffect,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nTopEffect,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nLeftEffect,System.ComponentModel.ISupportInitialize).EndInit
        Me.pKernelSizeEffect.ResumeLayout(false)
        Me.pKernelSizeEffect.PerformLayout
        CType(Me.nKernelSizeEffect,System.ComponentModel.ISupportInitialize).EndInit
        Me.pColorizeEffect.ResumeLayout(false)
        Me.pColorizeEffect.PerformLayout
        CType(Me.nLuminosityEffect,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nSaturationEffect,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nHueEffect,System.ComponentModel.ISupportInitialize).EndInit
        Me.pDirectEffects.ResumeLayout(false)
        Me.scMain.Panel1.ResumeLayout(false)
        Me.scMain.Panel2.ResumeLayout(false)
        CType(Me.scMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.scMain.ResumeLayout(false)
        Me.Panel6.ResumeLayout(false)
        Me.Panel6.PerformLayout
        Me.Panel9.ResumeLayout(false)
        Me.Panel7.ResumeLayout(false)
        Me.Panel7.PerformLayout
        Me.pSnapInButtons.ResumeLayout(false)
        Me.statusbar.ResumeLayout(false)
        Me.statusbar.PerformLayout
        Me.mainToolStrip.ResumeLayout(false)
        Me.mainToolStrip.PerformLayout
        Me.pMain.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tcLeftPanel As System.Windows.Forms.TabControl
    Friend WithEvents tpImageProperties As System.Windows.Forms.TabPage
    Friend WithEvents tpAdjustment As System.Windows.Forms.TabPage
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents GdViewer1 As GdPicture14.GdViewer
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
    Friend WithEvents mainToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents pMain As System.Windows.Forms.Panel
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblImageInfo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tpTransform As System.Windows.Forms.TabPage
    Friend WithEvents btnZoomOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbZoom As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnZoomIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pAdjustment As System.Windows.Forms.Panel
    Friend WithEvents btnSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFitWidth As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFitPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnSnapInImageProperties As System.Windows.Forms.Button
    Friend WithEvents btnSnapInTransform As System.Windows.Forms.Button
    Friend WithEvents btnSnapInAdjustment As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents pSnapInButtons As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblSnapInPanel As System.Windows.Forms.Label
    Friend WithEvents btnMouseMode As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaZoomingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagnifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpBrightness As System.Windows.Forms.GroupBox
    Friend WithEvents lblBrightness As System.Windows.Forms.Label
    Friend WithEvents tbBrightness As System.Windows.Forms.TrackBar
    Friend WithEvents pAdjustPreview As System.Windows.Forms.Panel
    Friend WithEvents gpSaturation As System.Windows.Forms.GroupBox
    Friend WithEvents lblSaturation As System.Windows.Forms.Label
    Friend WithEvents tbSaturation As System.Windows.Forms.TrackBar
    Friend WithEvents gpContrast As System.Windows.Forms.GroupBox
    Friend WithEvents lblContrast As System.Windows.Forms.Label
    Friend WithEvents tbContrast As System.Windows.Forms.TrackBar
    Friend WithEvents gpGamma As System.Windows.Forms.GroupBox
    Friend WithEvents lblGamma As System.Windows.Forms.Label
    Friend WithEvents tbGamma As System.Windows.Forms.TrackBar
    Friend WithEvents gpBlue As System.Windows.Forms.GroupBox
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents tbBlue As System.Windows.Forms.TrackBar
    Friend WithEvents gpGreen As System.Windows.Forms.GroupBox
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents tbGreen As System.Windows.Forms.TrackBar
    Friend WithEvents gpRed As System.Windows.Forms.GroupBox
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents tbRed As System.Windows.Forms.TrackBar
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnResetAdjustment As System.Windows.Forms.Button
    Friend WithEvents btnApplyAdjustment As System.Windows.Forms.Button
    Friend WithEvents pbBrightness As System.Windows.Forms.PictureBox
    Friend WithEvents pbBlue As System.Windows.Forms.PictureBox
    Friend WithEvents pbGreen As System.Windows.Forms.PictureBox
    Friend WithEvents pbRed As System.Windows.Forms.PictureBox
    Friend WithEvents pbGamma As System.Windows.Forms.PictureBox
    Friend WithEvents pbSaturation As System.Windows.Forms.PictureBox
    Friend WithEvents pbContrast As System.Windows.Forms.PictureBox
    Friend WithEvents btnImportFromClipboard As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopyToClipboard As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents pImageProperties As System.Windows.Forms.Panel
    Friend WithEvents tvImageProperties As System.Windows.Forms.TreeView
    Friend WithEvents lblImageSize As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMousePosition As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pTransform As System.Windows.Forms.Panel
    Friend WithEvents gpImageSize As System.Windows.Forms.GroupBox
    Friend WithEvents nScalePercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents rbScalePercent As System.Windows.Forms.RadioButton
    Friend WithEvents cbResampling As System.Windows.Forms.ComboBox
    Friend WithEvents lblResampling As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbResize As System.Windows.Forms.RadioButton
    Friend WithEvents chkKeepAspectRatio As System.Windows.Forms.CheckBox
    Friend WithEvents gpPixelDimensions As System.Windows.Forms.GroupBox
    Friend WithEvents nHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gpDocumentSize As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nHorizontalResolution As System.Windows.Forms.NumericUpDown
    Friend WithEvents nDocumentHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nDocumentWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents nVerticalResolution As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnResetSize As System.Windows.Forms.Button
    Friend WithEvents btnApplySize As System.Windows.Forms.Button
    Friend WithEvents gpRotation As System.Windows.Forms.GroupBox
    Friend WithEvents nRotationAngle As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnApplyRotation As System.Windows.Forms.Button
    Friend WithEvents pCustomAngle As System.Windows.Forms.Panel
    Friend WithEvents pRotationPreview As System.Windows.Forms.Panel
    Friend WithEvents rotationPeviewViewer As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCustomRotationBackgroundColor As System.Windows.Forms.Label
    Friend WithEvents chkRotateFromCenter As System.Windows.Forms.CheckBox
    Friend WithEvents chkKeepImageDimensionRotation As System.Windows.Forms.CheckBox
    Friend WithEvents pbRotationBackColor As System.Windows.Forms.PictureBox
    Friend WithEvents btnSnapInColorOperations As System.Windows.Forms.Button
    Friend WithEvents tpColorOperations As System.Windows.Forms.TabPage
    Friend WithEvents gpPixelFormat As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbPixelConversion As System.Windows.Forms.ComboBox
    Friend WithEvents btnApplyPixelConversion As System.Windows.Forms.Button
    Friend WithEvents pColorOperations As System.Windows.Forms.Panel
    Friend WithEvents gpColorChannelsManipulation As System.Windows.Forms.GroupBox
    Friend WithEvents rbSwapColor As System.Windows.Forms.RadioButton
    Friend WithEvents rbKeepComponent As System.Windows.Forms.RadioButton
    Friend WithEvents cbSwapColor As System.Windows.Forms.ComboBox
    Friend WithEvents pKeepComponent As System.Windows.Forms.Panel
    Friend WithEvents rbKeepBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rbKeepGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbKeepRed As System.Windows.Forms.RadioButton
    Friend WithEvents rbScaleComponent As System.Windows.Forms.RadioButton
    Friend WithEvents pScaleRed As System.Windows.Forms.Panel
    Friend WithEvents lblScaleRed As System.Windows.Forms.Label
    Friend WithEvents tbScaleRed As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pScaleGreen As System.Windows.Forms.Panel
    Friend WithEvents lblScaleGreen As System.Windows.Forms.Label
    Friend WithEvents tbScaleGreen As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pScaleBlue As System.Windows.Forms.Panel
    Friend WithEvents lblScaleBlue As System.Windows.Forms.Label
    Friend WithEvents tbScaleBlue As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pSwapColors As System.Windows.Forms.Panel
    Friend WithEvents pColorManipulation As System.Windows.Forms.Panel
    Friend WithEvents pScaleColors As System.Windows.Forms.Panel
    Friend WithEvents pRemoveComponent As System.Windows.Forms.Panel
    Friend WithEvents rbRemoveComponent As System.Windows.Forms.RadioButton
    Friend WithEvents btnApplyColorChannels As System.Windows.Forms.Button
    Friend WithEvents btnResetColorChannels As System.Windows.Forms.Button
    Friend WithEvents pColorChannelsViewer As System.Windows.Forms.Panel
    Friend WithEvents colorChannelPreviewViewer As System.Windows.Forms.PictureBox
    Friend WithEvents rbRemoveBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rbRemoveGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbRemoveRed As System.Windows.Forms.RadioButton
    Friend WithEvents btnSnapInEffects As System.Windows.Forms.Button
    Friend WithEvents tpEffects As System.Windows.Forms.TabPage
    Friend WithEvents pEffects As System.Windows.Forms.Panel
    Friend WithEvents pEffectsPreview As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnResetEffects As System.Windows.Forms.Button
    Friend WithEvents btnApplyEffects As System.Windows.Forms.Button
    Friend WithEvents cbDirectEffects As System.Windows.Forms.ComboBox
    Friend WithEvents pDirectEffects As System.Windows.Forms.Panel
    Friend WithEvents rbDirectEffects As System.Windows.Forms.RadioButton
    Friend WithEvents rbConfigurableEffects As System.Windows.Forms.RadioButton
    Friend WithEvents pConfigurableEffects As System.Windows.Forms.Panel
    Friend WithEvents cbConfigurableEffects As System.Windows.Forms.ComboBox
    Friend WithEvents pColorizeEffect As System.Windows.Forms.Panel
    Friend WithEvents nSaturationEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSaturationEffect As System.Windows.Forms.Label
    Friend WithEvents nHueEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblHueEffect As System.Windows.Forms.Label
    Friend WithEvents nLuminosityEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLuminosityEffect As System.Windows.Forms.Label
    Friend WithEvents pKernelSizeEffect As System.Windows.Forms.Panel
    Friend WithEvents nKernelSizeEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblKernelSizeEffect As System.Windows.Forms.Label
    Friend WithEvents pHaloEffect As System.Windows.Forms.Panel
    Friend WithEvents lblRadiusEffect As System.Windows.Forms.Label
    Friend WithEvents lblTopEffect As System.Windows.Forms.Label
    Friend WithEvents nRadiusEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents nTopEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents nLeftEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLeftEffect As System.Windows.Forms.Label
    Friend WithEvents pWavesEffect As System.Windows.Forms.Panel
    Friend WithEvents nHeightEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblHeightEffect As System.Windows.Forms.Label
    Friend WithEvents nWidthEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblWidthEffect As System.Windows.Forms.Label
    Friend WithEvents pRemoveBackgroundChromokeyEffect As System.Windows.Forms.Panel
    Friend WithEvents cbComponentEffect As System.Windows.Forms.ComboBox
    Friend WithEvents lblComponentEffect As System.Windows.Forms.Label
    Friend WithEvents nMinKeyValueEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMinKeyValueEffect As System.Windows.Forms.Label
    Friend WithEvents nVariationEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblVariationEffect As System.Windows.Forms.Label
    Friend WithEvents pSoftenValueEffect As System.Windows.Forms.Panel
    Friend WithEvents nSoftenValueEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSoftenValueEffect As System.Windows.Forms.Label
    Friend WithEvents pSubstractBackgroundEffect As System.Windows.Forms.Panel
    Friend WithEvents chkLightBackgroundEffect As System.Windows.Forms.CheckBox
    Friend WithEvents nRollingBallSizeEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRollingBallSizeEffect As System.Windows.Forms.Label
    Friend WithEvents pFactorEffect As System.Windows.Forms.Panel
    Friend WithEvents nFactorEffect As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFactorEffect As System.Windows.Forms.Label
    Friend WithEvents pFloodFillEffect As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents nFloodFillEffectYStart As System.Windows.Forms.NumericUpDown
    Friend WithEvents nFloodFillEffectXStart As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents pbFloodFillEffectColor As System.Windows.Forms.PictureBox
    Friend WithEvents rbFlipVertical As System.Windows.Forms.RadioButton
    Friend WithEvents rbFlipHorizontal As System.Windows.Forms.RadioButton
    Friend WithEvents rbRotateRight As System.Windows.Forms.RadioButton
    Friend WithEvents rbRotateLeft As System.Windows.Forms.RadioButton
    Friend WithEvents rbRotateCustomAngle As System.Windows.Forms.RadioButton
    Friend WithEvents adjustPeviewViewer As System.Windows.Forms.PictureBox
    Friend WithEvents GdViewer2 As GdPicture14.GdViewer
    Friend WithEvents btnSnapInThumbnails As System.Windows.Forms.Button
    Friend WithEvents tpThumbnails As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents thumbnailPanelToolstrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnThumbSize As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LargeThumbnailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumThumbnailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallThumbnailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThumbnailEx1 As GdPicture14.ThumbnailEx
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFirstPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPreviousPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbCurrentPage As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblPageCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnNextPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLastPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents rbConvolutionMatrix As RadioButton
    Friend WithEvents cbConvolutionMatrix As ComboBox
End Class
