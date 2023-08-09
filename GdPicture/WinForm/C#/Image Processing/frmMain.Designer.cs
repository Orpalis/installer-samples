
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;



namespace Image_Processing
{
	
	partial class FrmMain : System.Windows.Forms.Form
	{
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.Run(new FrmMain());
		}
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tcLeftPanel = new System.Windows.Forms.TabControl();
            this.tpThumbnails = new System.Windows.Forms.TabPage();
            this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.thumbnailPanelToolstrip = new System.Windows.Forms.ToolStrip();
            this.btnThumbSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.LargeThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallThumbnailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ThumbnailEx1 = new GdPicture14.ThumbnailEx();
            this.tpImageProperties = new System.Windows.Forms.TabPage();
            this.pImageProperties = new System.Windows.Forms.Panel();
            this.tvImageProperties = new System.Windows.Forms.TreeView();
            this.tpAdjustment = new System.Windows.Forms.TabPage();
            this.pAdjustment = new System.Windows.Forms.Panel();
            this.pAdjustPreview = new System.Windows.Forms.Panel();
            this.adjustPeviewViewer = new System.Windows.Forms.PictureBox();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.btnResetAdjustment = new System.Windows.Forms.Button();
            this.btnApplyAdjustment = new System.Windows.Forms.Button();
            this.gpBlue = new System.Windows.Forms.GroupBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.gpGreen = new System.Windows.Forms.GroupBox();
            this.lblGreen = new System.Windows.Forms.Label();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.gpRed = new System.Windows.Forms.GroupBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.gpGamma = new System.Windows.Forms.GroupBox();
            this.lblGamma = new System.Windows.Forms.Label();
            this.tbGamma = new System.Windows.Forms.TrackBar();
            this.pbGamma = new System.Windows.Forms.PictureBox();
            this.gpSaturation = new System.Windows.Forms.GroupBox();
            this.lblSaturation = new System.Windows.Forms.Label();
            this.tbSaturation = new System.Windows.Forms.TrackBar();
            this.pbSaturation = new System.Windows.Forms.PictureBox();
            this.gpContrast = new System.Windows.Forms.GroupBox();
            this.lblContrast = new System.Windows.Forms.Label();
            this.tbContrast = new System.Windows.Forms.TrackBar();
            this.pbContrast = new System.Windows.Forms.PictureBox();
            this.grpBrightness = new System.Windows.Forms.GroupBox();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.pbBrightness = new System.Windows.Forms.PictureBox();
            this.tpTransform = new System.Windows.Forms.TabPage();
            this.pTransform = new System.Windows.Forms.Panel();
            this.gpRotation = new System.Windows.Forms.GroupBox();
            this.pCustomAngle = new System.Windows.Forms.Panel();
            this.pRotationPreview = new System.Windows.Forms.Panel();
            this.rotationPeviewViewer = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.rbFlipVertical = new System.Windows.Forms.RadioButton();
            this.rbFlipHorizontal = new System.Windows.Forms.RadioButton();
            this.rbRotateCustomAngle = new System.Windows.Forms.RadioButton();
            this.rbRotateRight = new System.Windows.Forms.RadioButton();
            this.pbRotationBackColor = new System.Windows.Forms.PictureBox();
            this.rbRotateLeft = new System.Windows.Forms.RadioButton();
            this.chkKeepImageDimensionRotation = new System.Windows.Forms.CheckBox();
            this.lblCustomRotationBackgroundColor = new System.Windows.Forms.Label();
            this.chkRotateFromCenter = new System.Windows.Forms.CheckBox();
            this.nRotationAngle = new System.Windows.Forms.NumericUpDown();
            this.btnApplyRotation = new System.Windows.Forms.Button();
            this.gpImageSize = new System.Windows.Forms.GroupBox();
            this.btnResetSize = new System.Windows.Forms.Button();
            this.btnApplySize = new System.Windows.Forms.Button();
            this.gpDocumentSize = new System.Windows.Forms.GroupBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.nVerticalResolution = new System.Windows.Forms.NumericUpDown();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.nHorizontalResolution = new System.Windows.Forms.NumericUpDown();
            this.nDocumentHeight = new System.Windows.Forms.NumericUpDown();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.nDocumentWidth = new System.Windows.Forms.NumericUpDown();
            this.Label9 = new System.Windows.Forms.Label();
            this.gpPixelDimensions = new System.Windows.Forms.GroupBox();
            this.nHeight = new System.Windows.Forms.NumericUpDown();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.nWidth = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.chkKeepAspectRatio = new System.Windows.Forms.CheckBox();
            this.rbResize = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.nScalePercent = new System.Windows.Forms.NumericUpDown();
            this.rbScalePercent = new System.Windows.Forms.RadioButton();
            this.cbResampling = new System.Windows.Forms.ComboBox();
            this.lblResampling = new System.Windows.Forms.Label();
            this.tpColorOperations = new System.Windows.Forms.TabPage();
            this.pColorOperations = new System.Windows.Forms.Panel();
            this.gpColorChannelsManipulation = new System.Windows.Forms.GroupBox();
            this.pColorChannelsViewer = new System.Windows.Forms.Panel();
            this.colorChannelPreviewViewer = new System.Windows.Forms.PictureBox();
            this.pColorManipulation = new System.Windows.Forms.Panel();
            this.btnResetColorChannels = new System.Windows.Forms.Button();
            this.btnApplyColorChannels = new System.Windows.Forms.Button();
            this.pRemoveComponent = new System.Windows.Forms.Panel();
            this.rbRemoveBlue = new System.Windows.Forms.RadioButton();
            this.rbRemoveGreen = new System.Windows.Forms.RadioButton();
            this.rbRemoveRed = new System.Windows.Forms.RadioButton();
            this.rbRemoveComponent = new System.Windows.Forms.RadioButton();
            this.pScaleColors = new System.Windows.Forms.Panel();
            this.pScaleBlue = new System.Windows.Forms.Panel();
            this.lblScaleBlue = new System.Windows.Forms.Label();
            this.tbScaleBlue = new System.Windows.Forms.TrackBar();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.pScaleRed = new System.Windows.Forms.Panel();
            this.lblScaleRed = new System.Windows.Forms.Label();
            this.tbScaleRed = new System.Windows.Forms.TrackBar();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pScaleGreen = new System.Windows.Forms.Panel();
            this.lblScaleGreen = new System.Windows.Forms.Label();
            this.tbScaleGreen = new System.Windows.Forms.TrackBar();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.rbScaleComponent = new System.Windows.Forms.RadioButton();
            this.pKeepComponent = new System.Windows.Forms.Panel();
            this.rbKeepBlue = new System.Windows.Forms.RadioButton();
            this.rbKeepGreen = new System.Windows.Forms.RadioButton();
            this.rbKeepRed = new System.Windows.Forms.RadioButton();
            this.rbKeepComponent = new System.Windows.Forms.RadioButton();
            this.pSwapColors = new System.Windows.Forms.Panel();
            this.cbSwapColor = new System.Windows.Forms.ComboBox();
            this.rbSwapColor = new System.Windows.Forms.RadioButton();
            this.gpPixelFormat = new System.Windows.Forms.GroupBox();
            this.btnApplyPixelConversion = new System.Windows.Forms.Button();
            this.cbPixelConversion = new System.Windows.Forms.ComboBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.tpEffects = new System.Windows.Forms.TabPage();
            this.pEffects = new System.Windows.Forms.Panel();
            this.pEffectsPreview = new System.Windows.Forms.Panel();
            this.GdViewer2 = new GdPicture14.GdViewer();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.pConfigurableEffects = new System.Windows.Forms.Panel();
            this.pFloodFillEffect = new System.Windows.Forms.Panel();
            this.pbFloodFillEffectColor = new System.Windows.Forms.PictureBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.nFloodFillEffectYStart = new System.Windows.Forms.NumericUpDown();
            this.nFloodFillEffectXStart = new System.Windows.Forms.NumericUpDown();
            this.Label19 = new System.Windows.Forms.Label();
            this.pFactorEffect = new System.Windows.Forms.Panel();
            this.nFactorEffect = new System.Windows.Forms.NumericUpDown();
            this.lblFactorEffect = new System.Windows.Forms.Label();
            this.pSubstractBackgroundEffect = new System.Windows.Forms.Panel();
            this.chkLightBackgroundEffect = new System.Windows.Forms.CheckBox();
            this.nRollingBallSizeEffect = new System.Windows.Forms.NumericUpDown();
            this.lblRollingBallSizeEffect = new System.Windows.Forms.Label();
            this.pSoftenValueEffect = new System.Windows.Forms.Panel();
            this.nSoftenValueEffect = new System.Windows.Forms.NumericUpDown();
            this.lblSoftenValueEffect = new System.Windows.Forms.Label();
            this.pRemoveBackgroundChromokeyEffect = new System.Windows.Forms.Panel();
            this.nMinKeyValueEffect = new System.Windows.Forms.NumericUpDown();
            this.lblMinKeyValueEffect = new System.Windows.Forms.Label();
            this.nVariationEffect = new System.Windows.Forms.NumericUpDown();
            this.lblVariationEffect = new System.Windows.Forms.Label();
            this.cbComponentEffect = new System.Windows.Forms.ComboBox();
            this.lblComponentEffect = new System.Windows.Forms.Label();
            this.pWavesEffect = new System.Windows.Forms.Panel();
            this.nHeightEffect = new System.Windows.Forms.NumericUpDown();
            this.lblHeightEffect = new System.Windows.Forms.Label();
            this.nWidthEffect = new System.Windows.Forms.NumericUpDown();
            this.lblWidthEffect = new System.Windows.Forms.Label();
            this.pHaloEffect = new System.Windows.Forms.Panel();
            this.lblRadiusEffect = new System.Windows.Forms.Label();
            this.lblTopEffect = new System.Windows.Forms.Label();
            this.nRadiusEffect = new System.Windows.Forms.NumericUpDown();
            this.nTopEffect = new System.Windows.Forms.NumericUpDown();
            this.nLeftEffect = new System.Windows.Forms.NumericUpDown();
            this.lblLeftEffect = new System.Windows.Forms.Label();
            this.pKernelSizeEffect = new System.Windows.Forms.Panel();
            this.nKernelSizeEffect = new System.Windows.Forms.NumericUpDown();
            this.lblKernelSizeEffect = new System.Windows.Forms.Label();
            this.pColorizeEffect = new System.Windows.Forms.Panel();
            this.nLuminosityEffect = new System.Windows.Forms.NumericUpDown();
            this.lblLuminosityEffect = new System.Windows.Forms.Label();
            this.nSaturationEffect = new System.Windows.Forms.NumericUpDown();
            this.lblSaturationEffect = new System.Windows.Forms.Label();
            this.nHueEffect = new System.Windows.Forms.NumericUpDown();
            this.lblHueEffect = new System.Windows.Forms.Label();
            this.cbConfigurableEffects = new System.Windows.Forms.ComboBox();
            this.rbConfigurableEffects = new System.Windows.Forms.RadioButton();
            this.pDirectEffects = new System.Windows.Forms.Panel();
            this.cbDirectEffects = new System.Windows.Forms.ComboBox();
            this.rbDirectEffects = new System.Windows.Forms.RadioButton();
            this.btnResetEffects = new System.Windows.Forms.Button();
            this.btnApplyEffects = new System.Windows.Forms.Button();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.lblSnapInPanel = new System.Windows.Forms.Label();
            this.pSnapInButtons = new System.Windows.Forms.Panel();
            this.btnSnapInThumbnails = new System.Windows.Forms.Button();
            this.btnSnapInImageProperties = new System.Windows.Forms.Button();
            this.btnSnapInAdjustment = new System.Windows.Forms.Button();
            this.btnSnapInTransform = new System.Windows.Forms.Button();
            this.btnSnapInColorOperations = new System.Windows.Forms.Button();
            this.btnSnapInEffects = new System.Windows.Forms.Button();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.lblImageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.btnImportFromClipboard = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMouseMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.DefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AreaZoomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MagnifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirstPage = new System.Windows.Forms.ToolStripButton();
            this.btnPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.tbCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnLastPage = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.cbZoom = new System.Windows.Forms.ToolStripComboBox();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFitWidth = new System.Windows.Forms.ToolStripButton();
            this.btnFitPage = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.pMain = new System.Windows.Forms.Panel();
            this.rbConvolutionMatrix = new System.Windows.Forms.RadioButton();
            this.cbConvolutionMatrix = new System.Windows.Forms.ComboBox();
            this.tcLeftPanel.SuspendLayout();
            this.tpThumbnails.SuspendLayout();
            this.ToolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.ToolStripContainer1.ContentPanel.SuspendLayout();
            this.ToolStripContainer1.SuspendLayout();
            this.thumbnailPanelToolstrip.SuspendLayout();
            this.tpImageProperties.SuspendLayout();
            this.pImageProperties.SuspendLayout();
            this.tpAdjustment.SuspendLayout();
            this.pAdjustment.SuspendLayout();
            this.pAdjustPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustPeviewViewer)).BeginInit();
            this.Panel8.SuspendLayout();
            this.gpBlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            this.gpGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            this.gpRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            this.gpGamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGamma)).BeginInit();
            this.gpSaturation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaturation)).BeginInit();
            this.gpContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrast)).BeginInit();
            this.grpBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrightness)).BeginInit();
            this.tpTransform.SuspendLayout();
            this.pTransform.SuspendLayout();
            this.gpRotation.SuspendLayout();
            this.pCustomAngle.SuspendLayout();
            this.pRotationPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationPeviewViewer)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotationBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRotationAngle)).BeginInit();
            this.gpImageSize.SuspendLayout();
            this.gpDocumentSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVerticalResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHorizontalResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDocumentHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDocumentWidth)).BeginInit();
            this.gpPixelDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScalePercent)).BeginInit();
            this.tpColorOperations.SuspendLayout();
            this.pColorOperations.SuspendLayout();
            this.gpColorChannelsManipulation.SuspendLayout();
            this.pColorChannelsViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorChannelPreviewViewer)).BeginInit();
            this.pColorManipulation.SuspendLayout();
            this.pRemoveComponent.SuspendLayout();
            this.pScaleColors.SuspendLayout();
            this.pScaleBlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.pScaleRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.pScaleGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.pKeepComponent.SuspendLayout();
            this.pSwapColors.SuspendLayout();
            this.gpPixelFormat.SuspendLayout();
            this.tpEffects.SuspendLayout();
            this.pEffects.SuspendLayout();
            this.pEffectsPreview.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.pConfigurableEffects.SuspendLayout();
            this.pFloodFillEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloodFillEffectColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFloodFillEffectYStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFloodFillEffectXStart)).BeginInit();
            this.pFactorEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFactorEffect)).BeginInit();
            this.pSubstractBackgroundEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRollingBallSizeEffect)).BeginInit();
            this.pSoftenValueEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoftenValueEffect)).BeginInit();
            this.pRemoveBackgroundChromokeyEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinKeyValueEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVariationEffect)).BeginInit();
            this.pWavesEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHeightEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidthEffect)).BeginInit();
            this.pHaloEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRadiusEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTopEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLeftEffect)).BeginInit();
            this.pKernelSizeEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nKernelSizeEffect)).BeginInit();
            this.pColorizeEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLuminosityEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSaturationEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHueEffect)).BeginInit();
            this.pDirectEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.pSnapInButtons.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLeftPanel
            // 
            this.tcLeftPanel.Controls.Add(this.tpThumbnails);
            this.tcLeftPanel.Controls.Add(this.tpImageProperties);
            this.tcLeftPanel.Controls.Add(this.tpAdjustment);
            this.tcLeftPanel.Controls.Add(this.tpTransform);
            this.tcLeftPanel.Controls.Add(this.tpColorOperations);
            this.tcLeftPanel.Controls.Add(this.tpEffects);
            this.tcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLeftPanel.Location = new System.Drawing.Point(0, 49);
            this.tcLeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tcLeftPanel.Multiline = true;
            this.tcLeftPanel.Name = "tcLeftPanel";
            this.tcLeftPanel.Padding = new System.Drawing.Point(0, 0);
            this.tcLeftPanel.SelectedIndex = 0;
            this.tcLeftPanel.Size = new System.Drawing.Size(338, 1320);
            this.tcLeftPanel.TabIndex = 1;
            // 
            // tpThumbnails
            // 
            this.tpThumbnails.Controls.Add(this.ToolStripContainer1);
            this.tpThumbnails.Location = new System.Drawing.Point(4, 54);
            this.tpThumbnails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpThumbnails.Name = "tpThumbnails";
            this.tpThumbnails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpThumbnails.Size = new System.Drawing.Size(330, 956);
            this.tpThumbnails.TabIndex = 5;
            this.tpThumbnails.Text = "Thumbnails";
            this.tpThumbnails.UseVisualStyleBackColor = true;
            // 
            // ToolStripContainer1
            // 
            // 
            // ToolStripContainer1.BottomToolStripPanel
            // 
            this.ToolStripContainer1.BottomToolStripPanel.Controls.Add(this.thumbnailPanelToolstrip);
            // 
            // ToolStripContainer1.ContentPanel
            // 
            this.ToolStripContainer1.ContentPanel.Controls.Add(this.ThumbnailEx1);
            this.ToolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(322, 877);
            this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStripContainer1.Location = new System.Drawing.Point(4, 5);
            this.ToolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToolStripContainer1.Name = "ToolStripContainer1";
            this.ToolStripContainer1.Size = new System.Drawing.Size(322, 946);
            this.ToolStripContainer1.TabIndex = 2;
            this.ToolStripContainer1.Text = "ToolStripContainer1";
            // 
            // thumbnailPanelToolstrip
            // 
            this.thumbnailPanelToolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thumbnailPanelToolstrip.Dock = System.Windows.Forms.DockStyle.None;
            this.thumbnailPanelToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.thumbnailPanelToolstrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.thumbnailPanelToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThumbSize});
            this.thumbnailPanelToolstrip.Location = new System.Drawing.Point(0, 0);
            this.thumbnailPanelToolstrip.Name = "thumbnailPanelToolstrip";
            this.thumbnailPanelToolstrip.Padding = new System.Windows.Forms.Padding(0);
            this.thumbnailPanelToolstrip.Size = new System.Drawing.Size(322, 31);
            this.thumbnailPanelToolstrip.Stretch = true;
            this.thumbnailPanelToolstrip.TabIndex = 0;
            // 
            // btnThumbSize
            // 
            this.btnThumbSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThumbSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LargeThumbnailsToolStripMenuItem1,
            this.MediumThumbnailsToolStripMenuItem1,
            this.SmallThumbnailsToolStripMenuItem1});
            this.btnThumbSize.Image = ((System.Drawing.Image)(resources.GetObject("btnThumbSize.Image")));
            this.btnThumbSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThumbSize.Name = "btnThumbSize";
            this.btnThumbSize.Size = new System.Drawing.Size(42, 28);
            this.btnThumbSize.Text = "btnThumbnailSize";
            this.btnThumbSize.ToolTipText = "Thumbnail size";
            // 
            // LargeThumbnailsToolStripMenuItem1
            // 
            this.LargeThumbnailsToolStripMenuItem1.Checked = true;
            this.LargeThumbnailsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LargeThumbnailsToolStripMenuItem1.Name = "LargeThumbnailsToolStripMenuItem1";
            this.LargeThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(256, 30);
            this.LargeThumbnailsToolStripMenuItem1.Text = "Large thumbnails";
            this.LargeThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.LargeThumbnailsToolStripMenuItem1_Click);
            // 
            // MediumThumbnailsToolStripMenuItem1
            // 
            this.MediumThumbnailsToolStripMenuItem1.Name = "MediumThumbnailsToolStripMenuItem1";
            this.MediumThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(256, 30);
            this.MediumThumbnailsToolStripMenuItem1.Text = "Medium thumbnails";
            this.MediumThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.MediumThumbnailsToolStripMenuItem1_Click);
            // 
            // SmallThumbnailsToolStripMenuItem1
            // 
            this.SmallThumbnailsToolStripMenuItem1.Name = "SmallThumbnailsToolStripMenuItem1";
            this.SmallThumbnailsToolStripMenuItem1.Size = new System.Drawing.Size(256, 30);
            this.SmallThumbnailsToolStripMenuItem1.Text = "Small thumbnails";
            this.SmallThumbnailsToolStripMenuItem1.Click += new System.EventHandler(this.SmallThumbnailsToolStripMenuItem1_Click);
            // 
            // ThumbnailEx1
            // 
            this.ThumbnailEx1.AllowDropFiles = false;
            this.ThumbnailEx1.AllowMoveItems = false;
            this.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control;
            this.ThumbnailEx1.CheckBoxes = false;
            this.ThumbnailEx1.CheckBoxesMarginLeft = 0;
            this.ThumbnailEx1.CheckBoxesMarginTop = 0;
            this.ThumbnailEx1.DisplayAnnotations = true;
            this.ThumbnailEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbnailEx1.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            this.ThumbnailEx1.HotTracking = false;
            this.ThumbnailEx1.Location = new System.Drawing.Point(0, 0);
            this.ThumbnailEx1.LockGdViewerEvents = false;
            this.ThumbnailEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThumbnailEx1.MultiSelect = false;
            this.ThumbnailEx1.Name = "ThumbnailEx1";
            this.ThumbnailEx1.OwnDrop = false;
            this.ThumbnailEx1.PauseThumbsLoading = false;
            this.ThumbnailEx1.PdfIncreaseTextContrast = false;
            this.ThumbnailEx1.PreloadAllItems = true;
            this.ThumbnailEx1.RotateExif = true;
            this.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ThumbnailEx1.ShowText = true;
            this.ThumbnailEx1.Size = new System.Drawing.Size(322, 877);
            this.ThumbnailEx1.TabIndex = 0;
            this.ThumbnailEx1.TextMarginLeft = 0;
            this.ThumbnailEx1.TextMarginTop = 0;
            this.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical;
            this.ThumbnailEx1.ThumbnailBorder = true;
            this.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Black;
            this.ThumbnailEx1.ThumbnailSize = new System.Drawing.Size(256, 256);
            this.ThumbnailEx1.ThumbnailSpacing = new System.Drawing.Size(0, 0);
            this.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            // 
            // tpImageProperties
            // 
            this.tpImageProperties.BackColor = System.Drawing.SystemColors.Control;
            this.tpImageProperties.Controls.Add(this.pImageProperties);
            this.tpImageProperties.Location = new System.Drawing.Point(4, 54);
            this.tpImageProperties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpImageProperties.Name = "tpImageProperties";
            this.tpImageProperties.Size = new System.Drawing.Size(523, 930);
            this.tpImageProperties.TabIndex = 0;
            this.tpImageProperties.Text = "Image properties";
            // 
            // pImageProperties
            // 
            this.pImageProperties.Controls.Add(this.tvImageProperties);
            this.pImageProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImageProperties.Location = new System.Drawing.Point(0, 0);
            this.pImageProperties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pImageProperties.Name = "pImageProperties";
            this.pImageProperties.Size = new System.Drawing.Size(523, 930);
            this.pImageProperties.TabIndex = 3;
            // 
            // tvImageProperties
            // 
            this.tvImageProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvImageProperties.Location = new System.Drawing.Point(0, 0);
            this.tvImageProperties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvImageProperties.Name = "tvImageProperties";
            this.tvImageProperties.Size = new System.Drawing.Size(523, 930);
            this.tvImageProperties.TabIndex = 0;
            // 
            // tpAdjustment
            // 
            this.tpAdjustment.BackColor = System.Drawing.SystemColors.Control;
            this.tpAdjustment.Controls.Add(this.pAdjustment);
            this.tpAdjustment.Location = new System.Drawing.Point(4, 54);
            this.tpAdjustment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAdjustment.Name = "tpAdjustment";
            this.tpAdjustment.Size = new System.Drawing.Size(523, 930);
            this.tpAdjustment.TabIndex = 1;
            this.tpAdjustment.Text = "Adjustment";
            // 
            // pAdjustment
            // 
            this.pAdjustment.Controls.Add(this.pAdjustPreview);
            this.pAdjustment.Controls.Add(this.Panel8);
            this.pAdjustment.Controls.Add(this.gpBlue);
            this.pAdjustment.Controls.Add(this.gpGreen);
            this.pAdjustment.Controls.Add(this.gpRed);
            this.pAdjustment.Controls.Add(this.gpGamma);
            this.pAdjustment.Controls.Add(this.gpSaturation);
            this.pAdjustment.Controls.Add(this.gpContrast);
            this.pAdjustment.Controls.Add(this.grpBrightness);
            this.pAdjustment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAdjustment.Location = new System.Drawing.Point(0, 0);
            this.pAdjustment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pAdjustment.Name = "pAdjustment";
            this.pAdjustment.Size = new System.Drawing.Size(523, 930);
            this.pAdjustment.TabIndex = 1;
            // 
            // pAdjustPreview
            // 
            this.pAdjustPreview.Controls.Add(this.adjustPeviewViewer);
            this.pAdjustPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAdjustPreview.Location = new System.Drawing.Point(0, 700);
            this.pAdjustPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pAdjustPreview.Name = "pAdjustPreview";
            this.pAdjustPreview.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pAdjustPreview.Size = new System.Drawing.Size(523, 181);
            this.pAdjustPreview.TabIndex = 1;
            this.pAdjustPreview.Resize += new System.EventHandler(this.pAdjustPreview_Resize);
            // 
            // adjustPeviewViewer
            // 
            this.adjustPeviewViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adjustPeviewViewer.Location = new System.Drawing.Point(0, 8);
            this.adjustPeviewViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adjustPeviewViewer.Name = "adjustPeviewViewer";
            this.adjustPeviewViewer.Size = new System.Drawing.Size(523, 173);
            this.adjustPeviewViewer.TabIndex = 0;
            this.adjustPeviewViewer.TabStop = false;
            // 
            // Panel8
            // 
            this.Panel8.AutoSize = true;
            this.Panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel8.Controls.Add(this.btnResetAdjustment);
            this.Panel8.Controls.Add(this.btnApplyAdjustment);
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel8.Location = new System.Drawing.Point(0, 881);
            this.Panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel8.Name = "Panel8";
            this.Panel8.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Panel8.Size = new System.Drawing.Size(523, 49);
            this.Panel8.TabIndex = 8;
            // 
            // btnResetAdjustment
            // 
            this.btnResetAdjustment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetAdjustment.Location = new System.Drawing.Point(284, 9);
            this.btnResetAdjustment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetAdjustment.Name = "btnResetAdjustment";
            this.btnResetAdjustment.Size = new System.Drawing.Size(112, 35);
            this.btnResetAdjustment.TabIndex = 1;
            this.btnResetAdjustment.Text = "Reset";
            this.btnResetAdjustment.UseVisualStyleBackColor = true;
            this.btnResetAdjustment.Click += new System.EventHandler(this.btnResetAdjustment_Click);
            // 
            // btnApplyAdjustment
            // 
            this.btnApplyAdjustment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyAdjustment.Location = new System.Drawing.Point(406, 9);
            this.btnApplyAdjustment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyAdjustment.Name = "btnApplyAdjustment";
            this.btnApplyAdjustment.Size = new System.Drawing.Size(112, 35);
            this.btnApplyAdjustment.TabIndex = 0;
            this.btnApplyAdjustment.Text = "Apply";
            this.btnApplyAdjustment.UseVisualStyleBackColor = true;
            this.btnApplyAdjustment.Click += new System.EventHandler(this.btnApplyAdjustment_Click);
            // 
            // gpBlue
            // 
            this.gpBlue.Controls.Add(this.lblBlue);
            this.gpBlue.Controls.Add(this.tbBlue);
            this.gpBlue.Controls.Add(this.pbBlue);
            this.gpBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpBlue.Location = new System.Drawing.Point(0, 600);
            this.gpBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBlue.Name = "gpBlue";
            this.gpBlue.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBlue.Size = new System.Drawing.Size(523, 100);
            this.gpBlue.TabIndex = 6;
            this.gpBlue.TabStop = false;
            this.gpBlue.Text = "Blue";
            // 
            // lblBlue
            // 
            this.lblBlue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBlue.Location = new System.Drawing.Point(52, 75);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(467, 20);
            this.lblBlue.TabIndex = 1;
            this.lblBlue.Text = "0";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlue
            // 
            this.tbBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlue.Location = new System.Drawing.Point(52, 24);
            this.tbBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Minimum = -255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(467, 71);
            this.tbBlue.TabIndex = 0;
            this.tbBlue.TickFrequency = 0;
            this.tbBlue.ValueChanged += new System.EventHandler(this.tbBlue_ValueChanged);
            // 
            // pbBlue
            // 
            this.pbBlue.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbBlue.Image = ((System.Drawing.Image)(resources.GetObject("pbBlue.Image")));
            this.pbBlue.Location = new System.Drawing.Point(4, 24);
            this.pbBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(48, 71);
            this.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBlue.TabIndex = 3;
            this.pbBlue.TabStop = false;
            // 
            // gpGreen
            // 
            this.gpGreen.Controls.Add(this.lblGreen);
            this.gpGreen.Controls.Add(this.tbGreen);
            this.gpGreen.Controls.Add(this.pbGreen);
            this.gpGreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpGreen.Location = new System.Drawing.Point(0, 500);
            this.gpGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpGreen.Name = "gpGreen";
            this.gpGreen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpGreen.Size = new System.Drawing.Size(523, 100);
            this.gpGreen.TabIndex = 5;
            this.gpGreen.TabStop = false;
            this.gpGreen.Text = "Green";
            // 
            // lblGreen
            // 
            this.lblGreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGreen.Location = new System.Drawing.Point(52, 75);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(467, 20);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "0";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGreen
            // 
            this.tbGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGreen.Location = new System.Drawing.Point(52, 24);
            this.tbGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Minimum = -255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(467, 71);
            this.tbGreen.TabIndex = 0;
            this.tbGreen.TickFrequency = 0;
            this.tbGreen.ValueChanged += new System.EventHandler(this.tbGreen_ValueChanged);
            // 
            // pbGreen
            // 
            this.pbGreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbGreen.Image = ((System.Drawing.Image)(resources.GetObject("pbGreen.Image")));
            this.pbGreen.Location = new System.Drawing.Point(4, 24);
            this.pbGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(48, 71);
            this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGreen.TabIndex = 3;
            this.pbGreen.TabStop = false;
            // 
            // gpRed
            // 
            this.gpRed.Controls.Add(this.lblRed);
            this.gpRed.Controls.Add(this.tbRed);
            this.gpRed.Controls.Add(this.pbRed);
            this.gpRed.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpRed.Location = new System.Drawing.Point(0, 400);
            this.gpRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpRed.Name = "gpRed";
            this.gpRed.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpRed.Size = new System.Drawing.Size(523, 100);
            this.gpRed.TabIndex = 7;
            this.gpRed.TabStop = false;
            this.gpRed.Text = "Red";
            // 
            // lblRed
            // 
            this.lblRed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRed.Location = new System.Drawing.Point(52, 75);
            this.lblRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(467, 20);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "0";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRed
            // 
            this.tbRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRed.Location = new System.Drawing.Point(52, 24);
            this.tbRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRed.Maximum = 255;
            this.tbRed.Minimum = -255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(467, 71);
            this.tbRed.TabIndex = 0;
            this.tbRed.TickFrequency = 0;
            this.tbRed.ValueChanged += new System.EventHandler(this.tbRed_ValueChanged);
            // 
            // pbRed
            // 
            this.pbRed.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbRed.Image = ((System.Drawing.Image)(resources.GetObject("pbRed.Image")));
            this.pbRed.Location = new System.Drawing.Point(4, 24);
            this.pbRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(48, 71);
            this.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRed.TabIndex = 3;
            this.pbRed.TabStop = false;
            // 
            // gpGamma
            // 
            this.gpGamma.Controls.Add(this.lblGamma);
            this.gpGamma.Controls.Add(this.tbGamma);
            this.gpGamma.Controls.Add(this.pbGamma);
            this.gpGamma.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpGamma.Location = new System.Drawing.Point(0, 300);
            this.gpGamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpGamma.Name = "gpGamma";
            this.gpGamma.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpGamma.Size = new System.Drawing.Size(523, 100);
            this.gpGamma.TabIndex = 4;
            this.gpGamma.TabStop = false;
            this.gpGamma.Text = "Gamma";
            // 
            // lblGamma
            // 
            this.lblGamma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGamma.Location = new System.Drawing.Point(52, 75);
            this.lblGamma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(467, 20);
            this.lblGamma.TabIndex = 1;
            this.lblGamma.Text = "0";
            this.lblGamma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGamma
            // 
            this.tbGamma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGamma.Location = new System.Drawing.Point(52, 24);
            this.tbGamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGamma.Maximum = 100;
            this.tbGamma.Minimum = -100;
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(467, 71);
            this.tbGamma.TabIndex = 0;
            this.tbGamma.TickFrequency = 0;
            this.tbGamma.ValueChanged += new System.EventHandler(this.tbGamma_ValueChanged);
            // 
            // pbGamma
            // 
            this.pbGamma.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbGamma.Image = ((System.Drawing.Image)(resources.GetObject("pbGamma.Image")));
            this.pbGamma.Location = new System.Drawing.Point(4, 24);
            this.pbGamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbGamma.Name = "pbGamma";
            this.pbGamma.Size = new System.Drawing.Size(48, 71);
            this.pbGamma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGamma.TabIndex = 3;
            this.pbGamma.TabStop = false;
            // 
            // gpSaturation
            // 
            this.gpSaturation.Controls.Add(this.lblSaturation);
            this.gpSaturation.Controls.Add(this.tbSaturation);
            this.gpSaturation.Controls.Add(this.pbSaturation);
            this.gpSaturation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpSaturation.Location = new System.Drawing.Point(0, 200);
            this.gpSaturation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpSaturation.Name = "gpSaturation";
            this.gpSaturation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpSaturation.Size = new System.Drawing.Size(523, 100);
            this.gpSaturation.TabIndex = 3;
            this.gpSaturation.TabStop = false;
            this.gpSaturation.Text = "Saturation";
            // 
            // lblSaturation
            // 
            this.lblSaturation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSaturation.Location = new System.Drawing.Point(52, 75);
            this.lblSaturation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(467, 20);
            this.lblSaturation.TabIndex = 1;
            this.lblSaturation.Text = "0";
            this.lblSaturation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSaturation
            // 
            this.tbSaturation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSaturation.Location = new System.Drawing.Point(52, 24);
            this.tbSaturation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSaturation.Maximum = 100;
            this.tbSaturation.Minimum = -100;
            this.tbSaturation.Name = "tbSaturation";
            this.tbSaturation.Size = new System.Drawing.Size(467, 71);
            this.tbSaturation.TabIndex = 0;
            this.tbSaturation.TickFrequency = 0;
            this.tbSaturation.ValueChanged += new System.EventHandler(this.tbSaturation_ValueChanged);
            // 
            // pbSaturation
            // 
            this.pbSaturation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbSaturation.Image = ((System.Drawing.Image)(resources.GetObject("pbSaturation.Image")));
            this.pbSaturation.Location = new System.Drawing.Point(4, 24);
            this.pbSaturation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbSaturation.Name = "pbSaturation";
            this.pbSaturation.Size = new System.Drawing.Size(48, 71);
            this.pbSaturation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSaturation.TabIndex = 3;
            this.pbSaturation.TabStop = false;
            // 
            // gpContrast
            // 
            this.gpContrast.Controls.Add(this.lblContrast);
            this.gpContrast.Controls.Add(this.tbContrast);
            this.gpContrast.Controls.Add(this.pbContrast);
            this.gpContrast.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpContrast.Location = new System.Drawing.Point(0, 100);
            this.gpContrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpContrast.Name = "gpContrast";
            this.gpContrast.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpContrast.Size = new System.Drawing.Size(523, 100);
            this.gpContrast.TabIndex = 2;
            this.gpContrast.TabStop = false;
            this.gpContrast.Text = "Contrast";
            // 
            // lblContrast
            // 
            this.lblContrast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblContrast.Location = new System.Drawing.Point(52, 75);
            this.lblContrast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(467, 20);
            this.lblContrast.TabIndex = 1;
            this.lblContrast.Text = "0";
            this.lblContrast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbContrast
            // 
            this.tbContrast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContrast.Location = new System.Drawing.Point(52, 24);
            this.tbContrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContrast.Maximum = 100;
            this.tbContrast.Minimum = -100;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(467, 71);
            this.tbContrast.TabIndex = 0;
            this.tbContrast.TickFrequency = 0;
            this.tbContrast.ValueChanged += new System.EventHandler(this.tbContrast_ValueChanged);
            // 
            // pbContrast
            // 
            this.pbContrast.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbContrast.Image = ((System.Drawing.Image)(resources.GetObject("pbContrast.Image")));
            this.pbContrast.Location = new System.Drawing.Point(4, 24);
            this.pbContrast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbContrast.Name = "pbContrast";
            this.pbContrast.Size = new System.Drawing.Size(48, 71);
            this.pbContrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbContrast.TabIndex = 3;
            this.pbContrast.TabStop = false;
            // 
            // grpBrightness
            // 
            this.grpBrightness.Controls.Add(this.tbBrightness);
            this.grpBrightness.Controls.Add(this.lblBrightness);
            this.grpBrightness.Controls.Add(this.pbBrightness);
            this.grpBrightness.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBrightness.Location = new System.Drawing.Point(0, 0);
            this.grpBrightness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBrightness.Name = "grpBrightness";
            this.grpBrightness.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBrightness.Size = new System.Drawing.Size(523, 100);
            this.grpBrightness.TabIndex = 0;
            this.grpBrightness.TabStop = false;
            this.grpBrightness.Text = "Brightness";
            // 
            // tbBrightness
            // 
            this.tbBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBrightness.Location = new System.Drawing.Point(52, 24);
            this.tbBrightness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBrightness.Maximum = 100;
            this.tbBrightness.Minimum = -100;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(467, 51);
            this.tbBrightness.TabIndex = 0;
            this.tbBrightness.TickFrequency = 0;
            this.tbBrightness.ValueChanged += new System.EventHandler(this.tbBrightness_ValueChanged);
            // 
            // lblBrightness
            // 
            this.lblBrightness.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBrightness.Location = new System.Drawing.Point(52, 75);
            this.lblBrightness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(467, 20);
            this.lblBrightness.TabIndex = 1;
            this.lblBrightness.Text = "0";
            this.lblBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBrightness
            // 
            this.pbBrightness.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbBrightness.Image = ((System.Drawing.Image)(resources.GetObject("pbBrightness.Image")));
            this.pbBrightness.Location = new System.Drawing.Point(4, 24);
            this.pbBrightness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbBrightness.Name = "pbBrightness";
            this.pbBrightness.Size = new System.Drawing.Size(48, 71);
            this.pbBrightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBrightness.TabIndex = 2;
            this.pbBrightness.TabStop = false;
            // 
            // tpTransform
            // 
            this.tpTransform.BackColor = System.Drawing.SystemColors.Control;
            this.tpTransform.Controls.Add(this.pTransform);
            this.tpTransform.Location = new System.Drawing.Point(4, 54);
            this.tpTransform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpTransform.Name = "tpTransform";
            this.tpTransform.Size = new System.Drawing.Size(523, 930);
            this.tpTransform.TabIndex = 2;
            this.tpTransform.Text = "Transform";
            // 
            // pTransform
            // 
            this.pTransform.Controls.Add(this.gpRotation);
            this.pTransform.Controls.Add(this.gpImageSize);
            this.pTransform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTransform.Location = new System.Drawing.Point(0, 0);
            this.pTransform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pTransform.Name = "pTransform";
            this.pTransform.Size = new System.Drawing.Size(523, 930);
            this.pTransform.TabIndex = 0;
            // 
            // gpRotation
            // 
            this.gpRotation.Controls.Add(this.pCustomAngle);
            this.gpRotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpRotation.Location = new System.Drawing.Point(0, 568);
            this.gpRotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpRotation.Name = "gpRotation";
            this.gpRotation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpRotation.Size = new System.Drawing.Size(523, 362);
            this.gpRotation.TabIndex = 1;
            this.gpRotation.TabStop = false;
            this.gpRotation.Text = "Rotation";
            // 
            // pCustomAngle
            // 
            this.pCustomAngle.AutoSize = true;
            this.pCustomAngle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pCustomAngle.Controls.Add(this.pRotationPreview);
            this.pCustomAngle.Controls.Add(this.Panel1);
            this.pCustomAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCustomAngle.Location = new System.Drawing.Point(4, 24);
            this.pCustomAngle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pCustomAngle.Name = "pCustomAngle";
            this.pCustomAngle.Size = new System.Drawing.Size(515, 333);
            this.pCustomAngle.TabIndex = 1;
            // 
            // pRotationPreview
            // 
            this.pRotationPreview.Controls.Add(this.rotationPeviewViewer);
            this.pRotationPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRotationPreview.Location = new System.Drawing.Point(0, 166);
            this.pRotationPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pRotationPreview.Name = "pRotationPreview";
            this.pRotationPreview.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pRotationPreview.Size = new System.Drawing.Size(515, 167);
            this.pRotationPreview.TabIndex = 7;
            this.pRotationPreview.Resize += new System.EventHandler(this.pRotationPreview_Resize);
            // 
            // rotationPeviewViewer
            // 
            this.rotationPeviewViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotationPeviewViewer.Location = new System.Drawing.Point(0, 8);
            this.rotationPeviewViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rotationPeviewViewer.Name = "rotationPeviewViewer";
            this.rotationPeviewViewer.Size = new System.Drawing.Size(515, 159);
            this.rotationPeviewViewer.TabIndex = 0;
            this.rotationPeviewViewer.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.AutoSize = true;
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.Controls.Add(this.rbFlipVertical);
            this.Panel1.Controls.Add(this.rbFlipHorizontal);
            this.Panel1.Controls.Add(this.rbRotateCustomAngle);
            this.Panel1.Controls.Add(this.rbRotateRight);
            this.Panel1.Controls.Add(this.pbRotationBackColor);
            this.Panel1.Controls.Add(this.rbRotateLeft);
            this.Panel1.Controls.Add(this.chkKeepImageDimensionRotation);
            this.Panel1.Controls.Add(this.lblCustomRotationBackgroundColor);
            this.Panel1.Controls.Add(this.chkRotateFromCenter);
            this.Panel1.Controls.Add(this.nRotationAngle);
            this.Panel1.Controls.Add(this.btnApplyRotation);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(515, 166);
            this.Panel1.TabIndex = 7;
            // 
            // rbFlipVertical
            // 
            this.rbFlipVertical.Image = ((System.Drawing.Image)(resources.GetObject("rbFlipVertical.Image")));
            this.rbFlipVertical.Location = new System.Drawing.Point(252, 5);
            this.rbFlipVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFlipVertical.Name = "rbFlipVertical";
            this.rbFlipVertical.Size = new System.Drawing.Size(72, 49);
            this.rbFlipVertical.TabIndex = 7;
            this.rbFlipVertical.TabStop = true;
            this.rbFlipVertical.UseVisualStyleBackColor = true;
            this.rbFlipVertical.CheckedChanged += new System.EventHandler(this.rbFlipVertical_CheckedChanged);
            // 
            // rbFlipHorizontal
            // 
            this.rbFlipHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("rbFlipHorizontal.Image")));
            this.rbFlipHorizontal.Location = new System.Drawing.Point(171, 5);
            this.rbFlipHorizontal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFlipHorizontal.Name = "rbFlipHorizontal";
            this.rbFlipHorizontal.Size = new System.Drawing.Size(72, 49);
            this.rbFlipHorizontal.TabIndex = 6;
            this.rbFlipHorizontal.TabStop = true;
            this.rbFlipHorizontal.UseVisualStyleBackColor = true;
            this.rbFlipHorizontal.CheckedChanged += new System.EventHandler(this.rbFlipHorizontal_CheckedChanged);
            // 
            // rbRotateCustomAngle
            // 
            this.rbRotateCustomAngle.AutoSize = true;
            this.rbRotateCustomAngle.Location = new System.Drawing.Point(9, 57);
            this.rbRotateCustomAngle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRotateCustomAngle.Name = "rbRotateCustomAngle";
            this.rbRotateCustomAngle.Size = new System.Drawing.Size(132, 24);
            this.rbRotateCustomAngle.TabIndex = 11;
            this.rbRotateCustomAngle.TabStop = true;
            this.rbRotateCustomAngle.Text = "Custom angle";
            this.rbRotateCustomAngle.UseVisualStyleBackColor = true;
            this.rbRotateCustomAngle.CheckedChanged += new System.EventHandler(this.rbRotateCustomAngle_CheckedChanged);
            // 
            // rbRotateRight
            // 
            this.rbRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("rbRotateRight.Image")));
            this.rbRotateRight.Location = new System.Drawing.Point(90, 5);
            this.rbRotateRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRotateRight.Name = "rbRotateRight";
            this.rbRotateRight.Size = new System.Drawing.Size(72, 49);
            this.rbRotateRight.TabIndex = 5;
            this.rbRotateRight.TabStop = true;
            this.rbRotateRight.UseVisualStyleBackColor = true;
            this.rbRotateRight.CheckedChanged += new System.EventHandler(this.rbRotateRight_CheckedChanged);
            // 
            // pbRotationBackColor
            // 
            this.pbRotationBackColor.BackColor = System.Drawing.Color.Black;
            this.pbRotationBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRotationBackColor.Location = new System.Drawing.Point(152, 128);
            this.pbRotationBackColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbRotationBackColor.Name = "pbRotationBackColor";
            this.pbRotationBackColor.Size = new System.Drawing.Size(30, 31);
            this.pbRotationBackColor.TabIndex = 10;
            this.pbRotationBackColor.TabStop = false;
            this.pbRotationBackColor.BackColorChanged += new System.EventHandler(this.pbRotationBackColor_BackColorChanged);
            this.pbRotationBackColor.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // rbRotateLeft
            // 
            this.rbRotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("rbRotateLeft.Image")));
            this.rbRotateLeft.Location = new System.Drawing.Point(9, 5);
            this.rbRotateLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRotateLeft.Name = "rbRotateLeft";
            this.rbRotateLeft.Size = new System.Drawing.Size(72, 49);
            this.rbRotateLeft.TabIndex = 4;
            this.rbRotateLeft.TabStop = true;
            this.rbRotateLeft.UseVisualStyleBackColor = true;
            this.rbRotateLeft.CheckedChanged += new System.EventHandler(this.rbRotateLeft_CheckedChanged);
            // 
            // chkKeepImageDimensionRotation
            // 
            this.chkKeepImageDimensionRotation.AutoSize = true;
            this.chkKeepImageDimensionRotation.Checked = true;
            this.chkKeepImageDimensionRotation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepImageDimensionRotation.Location = new System.Drawing.Point(9, 94);
            this.chkKeepImageDimensionRotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKeepImageDimensionRotation.Name = "chkKeepImageDimensionRotation";
            this.chkKeepImageDimensionRotation.Size = new System.Drawing.Size(156, 24);
            this.chkKeepImageDimensionRotation.TabIndex = 9;
            this.chkKeepImageDimensionRotation.Text = "Keep dimensions";
            this.chkKeepImageDimensionRotation.UseVisualStyleBackColor = true;
            this.chkKeepImageDimensionRotation.CheckedChanged += new System.EventHandler(this.chkKeepImageDimensionRotation_CheckedChanged);
            // 
            // lblCustomRotationBackgroundColor
            // 
            this.lblCustomRotationBackgroundColor.AutoSize = true;
            this.lblCustomRotationBackgroundColor.Location = new System.Drawing.Point(4, 135);
            this.lblCustomRotationBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomRotationBackgroundColor.Name = "lblCustomRotationBackgroundColor";
            this.lblCustomRotationBackgroundColor.Size = new System.Drawing.Size(137, 20);
            this.lblCustomRotationBackgroundColor.TabIndex = 8;
            this.lblCustomRotationBackgroundColor.Text = "Background color:";
            // 
            // chkRotateFromCenter
            // 
            this.chkRotateFromCenter.AutoSize = true;
            this.chkRotateFromCenter.Checked = true;
            this.chkRotateFromCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRotateFromCenter.Location = new System.Drawing.Point(177, 94);
            this.chkRotateFromCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRotateFromCenter.Name = "chkRotateFromCenter";
            this.chkRotateFromCenter.Size = new System.Drawing.Size(181, 24);
            this.chkRotateFromCenter.TabIndex = 7;
            this.chkRotateFromCenter.Text = "Rotation from center";
            this.chkRotateFromCenter.UseVisualStyleBackColor = true;
            this.chkRotateFromCenter.CheckedChanged += new System.EventHandler(this.chkRotateFromCenter_CheckedChanged);
            // 
            // nRotationAngle
            // 
            this.nRotationAngle.DecimalPlaces = 1;
            this.nRotationAngle.Location = new System.Drawing.Point(142, 57);
            this.nRotationAngle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRotationAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nRotationAngle.Name = "nRotationAngle";
            this.nRotationAngle.Size = new System.Drawing.Size(92, 26);
            this.nRotationAngle.TabIndex = 5;
            this.nRotationAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nRotationAngle.ValueChanged += new System.EventHandler(this.nRotationAngle_ValueChanged);
            this.nRotationAngle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nRotationAngle_KeyUp);
            // 
            // btnApplyRotation
            // 
            this.btnApplyRotation.Location = new System.Drawing.Point(381, 126);
            this.btnApplyRotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyRotation.Name = "btnApplyRotation";
            this.btnApplyRotation.Size = new System.Drawing.Size(112, 35);
            this.btnApplyRotation.TabIndex = 6;
            this.btnApplyRotation.Text = "Apply";
            this.btnApplyRotation.UseVisualStyleBackColor = true;
            this.btnApplyRotation.Click += new System.EventHandler(this.btnApplyRotation_Click);
            // 
            // gpImageSize
            // 
            this.gpImageSize.Controls.Add(this.btnResetSize);
            this.gpImageSize.Controls.Add(this.btnApplySize);
            this.gpImageSize.Controls.Add(this.gpDocumentSize);
            this.gpImageSize.Controls.Add(this.gpPixelDimensions);
            this.gpImageSize.Controls.Add(this.chkKeepAspectRatio);
            this.gpImageSize.Controls.Add(this.rbResize);
            this.gpImageSize.Controls.Add(this.Label1);
            this.gpImageSize.Controls.Add(this.nScalePercent);
            this.gpImageSize.Controls.Add(this.rbScalePercent);
            this.gpImageSize.Controls.Add(this.cbResampling);
            this.gpImageSize.Controls.Add(this.lblResampling);
            this.gpImageSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpImageSize.Location = new System.Drawing.Point(0, 0);
            this.gpImageSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpImageSize.Name = "gpImageSize";
            this.gpImageSize.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpImageSize.Size = new System.Drawing.Size(523, 568);
            this.gpImageSize.TabIndex = 0;
            this.gpImageSize.TabStop = false;
            this.gpImageSize.Text = "Image size";
            // 
            // btnResetSize
            // 
            this.btnResetSize.Location = new System.Drawing.Point(192, 512);
            this.btnResetSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetSize.Name = "btnResetSize";
            this.btnResetSize.Size = new System.Drawing.Size(112, 35);
            this.btnResetSize.TabIndex = 10;
            this.btnResetSize.Text = "Reset";
            this.btnResetSize.UseVisualStyleBackColor = true;
            this.btnResetSize.Click += new System.EventHandler(this.btnResetSize_Click);
            // 
            // btnApplySize
            // 
            this.btnApplySize.Location = new System.Drawing.Point(314, 512);
            this.btnApplySize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplySize.Name = "btnApplySize";
            this.btnApplySize.Size = new System.Drawing.Size(112, 35);
            this.btnApplySize.TabIndex = 9;
            this.btnApplySize.Text = "Apply";
            this.btnApplySize.UseVisualStyleBackColor = true;
            this.btnApplySize.Click += new System.EventHandler(this.btnApplySize_Click);
            // 
            // gpDocumentSize
            // 
            this.gpDocumentSize.Controls.Add(this.Label12);
            this.gpDocumentSize.Controls.Add(this.Label13);
            this.gpDocumentSize.Controls.Add(this.nVerticalResolution);
            this.gpDocumentSize.Controls.Add(this.Label11);
            this.gpDocumentSize.Controls.Add(this.Label10);
            this.gpDocumentSize.Controls.Add(this.nHorizontalResolution);
            this.gpDocumentSize.Controls.Add(this.nDocumentHeight);
            this.gpDocumentSize.Controls.Add(this.Label6);
            this.gpDocumentSize.Controls.Add(this.Label7);
            this.gpDocumentSize.Controls.Add(this.Label8);
            this.gpDocumentSize.Controls.Add(this.nDocumentWidth);
            this.gpDocumentSize.Controls.Add(this.Label9);
            this.gpDocumentSize.Location = new System.Drawing.Point(44, 306);
            this.gpDocumentSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpDocumentSize.Name = "gpDocumentSize";
            this.gpDocumentSize.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpDocumentSize.Size = new System.Drawing.Size(382, 197);
            this.gpDocumentSize.TabIndex = 8;
            this.gpDocumentSize.TabStop = false;
            this.gpDocumentSize.Text = "Document size";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(280, 152);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(81, 20);
            this.Label12.TabIndex = 12;
            this.Label12.Text = "pixels/inch";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(26, 152);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(135, 20);
            this.Label13.TabIndex = 11;
            this.Label13.Text = "Vertical resolution";
            // 
            // nVerticalResolution
            // 
            this.nVerticalResolution.Location = new System.Drawing.Point(170, 149);
            this.nVerticalResolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nVerticalResolution.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nVerticalResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nVerticalResolution.Name = "nVerticalResolution";
            this.nVerticalResolution.Size = new System.Drawing.Size(102, 26);
            this.nVerticalResolution.TabIndex = 10;
            this.nVerticalResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nVerticalResolution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nVerticalResolution.ValueChanged += new System.EventHandler(this.nVerticalResolution_ValueChanged);
            this.nVerticalResolution.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nVerticalResolution_KeyUp);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(280, 112);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(81, 20);
            this.Label11.TabIndex = 9;
            this.Label11.Text = "pixels/inch";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(8, 112);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(154, 20);
            this.Label10.TabIndex = 8;
            this.Label10.Text = "Horizontal resolution";
            // 
            // nHorizontalResolution
            // 
            this.nHorizontalResolution.Location = new System.Drawing.Point(170, 109);
            this.nHorizontalResolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nHorizontalResolution.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nHorizontalResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHorizontalResolution.Name = "nHorizontalResolution";
            this.nHorizontalResolution.Size = new System.Drawing.Size(102, 26);
            this.nHorizontalResolution.TabIndex = 7;
            this.nHorizontalResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nHorizontalResolution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHorizontalResolution.ValueChanged += new System.EventHandler(this.nHorizontalResolution_ValueChanged);
            this.nHorizontalResolution.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nHorizontalResolution_KeyUp);
            // 
            // nDocumentHeight
            // 
            this.nDocumentHeight.DecimalPlaces = 2;
            this.nDocumentHeight.Location = new System.Drawing.Point(170, 69);
            this.nDocumentHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nDocumentHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nDocumentHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nDocumentHeight.Name = "nDocumentHeight";
            this.nDocumentHeight.Size = new System.Drawing.Size(102, 26);
            this.nDocumentHeight.TabIndex = 6;
            this.nDocumentHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nDocumentHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDocumentHeight.ValueChanged += new System.EventHandler(this.nDocumentHeight_ValueChanged);
            this.nDocumentHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nDocumentHeight_KeyUp);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(280, 72);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(55, 20);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "inches";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(104, 72);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(60, 20);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Height:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(280, 32);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(55, 20);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "inches";
            // 
            // nDocumentWidth
            // 
            this.nDocumentWidth.DecimalPlaces = 2;
            this.nDocumentWidth.Location = new System.Drawing.Point(170, 29);
            this.nDocumentWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nDocumentWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nDocumentWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nDocumentWidth.Name = "nDocumentWidth";
            this.nDocumentWidth.Size = new System.Drawing.Size(102, 26);
            this.nDocumentWidth.TabIndex = 1;
            this.nDocumentWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nDocumentWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDocumentWidth.ValueChanged += new System.EventHandler(this.nDocumentWidth_ValueChanged);
            this.nDocumentWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nDocumentWidth_KeyUp);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(104, 32);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(54, 20);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Width:";
            // 
            // gpPixelDimensions
            // 
            this.gpPixelDimensions.Controls.Add(this.nHeight);
            this.gpPixelDimensions.Controls.Add(this.Label5);
            this.gpPixelDimensions.Controls.Add(this.Label4);
            this.gpPixelDimensions.Controls.Add(this.Label3);
            this.gpPixelDimensions.Controls.Add(this.nWidth);
            this.gpPixelDimensions.Controls.Add(this.Label2);
            this.gpPixelDimensions.Location = new System.Drawing.Point(44, 175);
            this.gpPixelDimensions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpPixelDimensions.Name = "gpPixelDimensions";
            this.gpPixelDimensions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpPixelDimensions.Size = new System.Drawing.Size(382, 122);
            this.gpPixelDimensions.TabIndex = 7;
            this.gpPixelDimensions.TabStop = false;
            this.gpPixelDimensions.Text = "Pixel dimensions";
            // 
            // nHeight
            // 
            this.nHeight.Location = new System.Drawing.Point(170, 72);
            this.nHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHeight.Name = "nHeight";
            this.nHeight.Size = new System.Drawing.Size(102, 26);
            this.nHeight.TabIndex = 6;
            this.nHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHeight.ValueChanged += new System.EventHandler(this.nHeight_ValueChanged);
            this.nHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nHeight_KeyUp);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(280, 75);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 20);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "pixels";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(99, 75);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(60, 20);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Height:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(280, 35);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 20);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "pixels";
            // 
            // nWidth
            // 
            this.nWidth.Location = new System.Drawing.Point(170, 32);
            this.nWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWidth.Name = "nWidth";
            this.nWidth.Size = new System.Drawing.Size(102, 26);
            this.nWidth.TabIndex = 1;
            this.nWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWidth.ValueChanged += new System.EventHandler(this.nWidth_ValueChanged);
            this.nWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nWidth_KeyUp);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(104, 35);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 20);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Width:";
            // 
            // chkKeepAspectRatio
            // 
            this.chkKeepAspectRatio.AutoSize = true;
            this.chkKeepAspectRatio.Checked = true;
            this.chkKeepAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepAspectRatio.Location = new System.Drawing.Point(44, 140);
            this.chkKeepAspectRatio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKeepAspectRatio.Name = "chkKeepAspectRatio";
            this.chkKeepAspectRatio.Size = new System.Drawing.Size(159, 24);
            this.chkKeepAspectRatio.TabIndex = 6;
            this.chkKeepAspectRatio.Text = "Keep aspect ratio";
            this.chkKeepAspectRatio.UseVisualStyleBackColor = true;
            // 
            // rbResize
            // 
            this.rbResize.AutoSize = true;
            this.rbResize.Location = new System.Drawing.Point(14, 105);
            this.rbResize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbResize.Name = "rbResize";
            this.rbResize.Size = new System.Drawing.Size(149, 24);
            this.rbResize.TabIndex = 5;
            this.rbResize.TabStop = true;
            this.rbResize.Text = "By absolute size";
            this.rbResize.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(261, 68);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(23, 20);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "%";
            // 
            // nScalePercent
            // 
            this.nScalePercent.Location = new System.Drawing.Point(164, 65);
            this.nScalePercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nScalePercent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nScalePercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nScalePercent.Name = "nScalePercent";
            this.nScalePercent.Size = new System.Drawing.Size(88, 26);
            this.nScalePercent.TabIndex = 3;
            this.nScalePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nScalePercent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nScalePercent.ValueChanged += new System.EventHandler(this.nScalePercent_ValueChanged);
            this.nScalePercent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nScalePercent_KeyUp);
            // 
            // rbScalePercent
            // 
            this.rbScalePercent.AutoSize = true;
            this.rbScalePercent.Checked = true;
            this.rbScalePercent.Location = new System.Drawing.Point(14, 65);
            this.rbScalePercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbScalePercent.Name = "rbScalePercent";
            this.rbScalePercent.Size = new System.Drawing.Size(137, 24);
            this.rbScalePercent.TabIndex = 2;
            this.rbScalePercent.TabStop = true;
            this.rbScalePercent.Text = "By percentage";
            this.rbScalePercent.UseVisualStyleBackColor = true;
            this.rbScalePercent.CheckedChanged += new System.EventHandler(this.rbScalePercent_CheckedChanged);
            // 
            // cbResampling
            // 
            this.cbResampling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResampling.FormattingEnabled = true;
            this.cbResampling.Location = new System.Drawing.Point(116, 23);
            this.cbResampling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbResampling.Name = "cbResampling";
            this.cbResampling.Size = new System.Drawing.Size(232, 28);
            this.cbResampling.TabIndex = 1;
            // 
            // lblResampling
            // 
            this.lblResampling.AutoSize = true;
            this.lblResampling.Location = new System.Drawing.Point(9, 28);
            this.lblResampling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResampling.Name = "lblResampling";
            this.lblResampling.Size = new System.Drawing.Size(97, 20);
            this.lblResampling.TabIndex = 0;
            this.lblResampling.Text = "Resampling:";
            // 
            // tpColorOperations
            // 
            this.tpColorOperations.Controls.Add(this.pColorOperations);
            this.tpColorOperations.Location = new System.Drawing.Point(4, 54);
            this.tpColorOperations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpColorOperations.Name = "tpColorOperations";
            this.tpColorOperations.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpColorOperations.Size = new System.Drawing.Size(523, 930);
            this.tpColorOperations.TabIndex = 3;
            this.tpColorOperations.Text = "Color operations";
            this.tpColorOperations.UseVisualStyleBackColor = true;
            // 
            // pColorOperations
            // 
            this.pColorOperations.Controls.Add(this.gpColorChannelsManipulation);
            this.pColorOperations.Controls.Add(this.gpPixelFormat);
            this.pColorOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pColorOperations.Location = new System.Drawing.Point(4, 5);
            this.pColorOperations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pColorOperations.Name = "pColorOperations";
            this.pColorOperations.Size = new System.Drawing.Size(515, 920);
            this.pColorOperations.TabIndex = 1;
            // 
            // gpColorChannelsManipulation
            // 
            this.gpColorChannelsManipulation.Controls.Add(this.pColorChannelsViewer);
            this.gpColorChannelsManipulation.Controls.Add(this.pColorManipulation);
            this.gpColorChannelsManipulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpColorChannelsManipulation.Location = new System.Drawing.Point(0, 78);
            this.gpColorChannelsManipulation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpColorChannelsManipulation.Name = "gpColorChannelsManipulation";
            this.gpColorChannelsManipulation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpColorChannelsManipulation.Size = new System.Drawing.Size(515, 842);
            this.gpColorChannelsManipulation.TabIndex = 1;
            this.gpColorChannelsManipulation.TabStop = false;
            this.gpColorChannelsManipulation.Text = "Color channels manipulation";
            // 
            // pColorChannelsViewer
            // 
            this.pColorChannelsViewer.Controls.Add(this.colorChannelPreviewViewer);
            this.pColorChannelsViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pColorChannelsViewer.Location = new System.Drawing.Point(4, 713);
            this.pColorChannelsViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pColorChannelsViewer.Name = "pColorChannelsViewer";
            this.pColorChannelsViewer.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pColorChannelsViewer.Size = new System.Drawing.Size(507, 124);
            this.pColorChannelsViewer.TabIndex = 13;
            this.pColorChannelsViewer.Resize += new System.EventHandler(this.pColorChannelsViewer_Resize);
            // 
            // colorChannelPreviewViewer
            // 
            this.colorChannelPreviewViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorChannelPreviewViewer.Location = new System.Drawing.Point(0, 8);
            this.colorChannelPreviewViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorChannelPreviewViewer.Name = "colorChannelPreviewViewer";
            this.colorChannelPreviewViewer.Size = new System.Drawing.Size(507, 116);
            this.colorChannelPreviewViewer.TabIndex = 0;
            this.colorChannelPreviewViewer.TabStop = false;
            // 
            // pColorManipulation
            // 
            this.pColorManipulation.AutoSize = true;
            this.pColorManipulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pColorManipulation.Controls.Add(this.btnResetColorChannels);
            this.pColorManipulation.Controls.Add(this.btnApplyColorChannels);
            this.pColorManipulation.Controls.Add(this.pRemoveComponent);
            this.pColorManipulation.Controls.Add(this.rbRemoveComponent);
            this.pColorManipulation.Controls.Add(this.pScaleColors);
            this.pColorManipulation.Controls.Add(this.rbScaleComponent);
            this.pColorManipulation.Controls.Add(this.pKeepComponent);
            this.pColorManipulation.Controls.Add(this.rbKeepComponent);
            this.pColorManipulation.Controls.Add(this.pSwapColors);
            this.pColorManipulation.Controls.Add(this.rbSwapColor);
            this.pColorManipulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pColorManipulation.Location = new System.Drawing.Point(4, 24);
            this.pColorManipulation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pColorManipulation.Name = "pColorManipulation";
            this.pColorManipulation.Size = new System.Drawing.Size(507, 689);
            this.pColorManipulation.TabIndex = 12;
            // 
            // btnResetColorChannels
            // 
            this.btnResetColorChannels.Location = new System.Drawing.Point(240, 649);
            this.btnResetColorChannels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetColorChannels.Name = "btnResetColorChannels";
            this.btnResetColorChannels.Size = new System.Drawing.Size(112, 35);
            this.btnResetColorChannels.TabIndex = 16;
            this.btnResetColorChannels.Text = "Reset";
            this.btnResetColorChannels.UseVisualStyleBackColor = true;
            this.btnResetColorChannels.Click += new System.EventHandler(this.btnResetColorChannels_Click);
            // 
            // btnApplyColorChannels
            // 
            this.btnApplyColorChannels.Location = new System.Drawing.Point(362, 649);
            this.btnApplyColorChannels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyColorChannels.Name = "btnApplyColorChannels";
            this.btnApplyColorChannels.Size = new System.Drawing.Size(112, 35);
            this.btnApplyColorChannels.TabIndex = 15;
            this.btnApplyColorChannels.Text = "Apply";
            this.btnApplyColorChannels.UseVisualStyleBackColor = true;
            this.btnApplyColorChannels.Click += new System.EventHandler(this.btnApplyColorChannels_Click);
            // 
            // pRemoveComponent
            // 
            this.pRemoveComponent.AutoSize = true;
            this.pRemoveComponent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pRemoveComponent.Controls.Add(this.rbRemoveBlue);
            this.pRemoveComponent.Controls.Add(this.rbRemoveGreen);
            this.pRemoveComponent.Controls.Add(this.rbRemoveRed);
            this.pRemoveComponent.Location = new System.Drawing.Point(38, 534);
            this.pRemoveComponent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pRemoveComponent.Name = "pRemoveComponent";
            this.pRemoveComponent.Size = new System.Drawing.Size(87, 100);
            this.pRemoveComponent.TabIndex = 14;
            // 
            // rbRemoveBlue
            // 
            this.rbRemoveBlue.AutoSize = true;
            this.rbRemoveBlue.Location = new System.Drawing.Point(4, 71);
            this.rbRemoveBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRemoveBlue.Name = "rbRemoveBlue";
            this.rbRemoveBlue.Size = new System.Drawing.Size(66, 24);
            this.rbRemoveBlue.TabIndex = 5;
            this.rbRemoveBlue.TabStop = true;
            this.rbRemoveBlue.Text = "Blue";
            this.rbRemoveBlue.UseVisualStyleBackColor = true;
            this.rbRemoveBlue.CheckedChanged += new System.EventHandler(this.rbRemoveBlue_CheckedChanged);
            // 
            // rbRemoveGreen
            // 
            this.rbRemoveGreen.AutoSize = true;
            this.rbRemoveGreen.Location = new System.Drawing.Point(4, 35);
            this.rbRemoveGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRemoveGreen.Name = "rbRemoveGreen";
            this.rbRemoveGreen.Size = new System.Drawing.Size(79, 24);
            this.rbRemoveGreen.TabIndex = 4;
            this.rbRemoveGreen.TabStop = true;
            this.rbRemoveGreen.Text = "Green";
            this.rbRemoveGreen.UseVisualStyleBackColor = true;
            this.rbRemoveGreen.CheckedChanged += new System.EventHandler(this.rbRemoveGreen_CheckedChanged);
            // 
            // rbRemoveRed
            // 
            this.rbRemoveRed.AutoSize = true;
            this.rbRemoveRed.Location = new System.Drawing.Point(4, 0);
            this.rbRemoveRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRemoveRed.Name = "rbRemoveRed";
            this.rbRemoveRed.Size = new System.Drawing.Size(64, 24);
            this.rbRemoveRed.TabIndex = 3;
            this.rbRemoveRed.TabStop = true;
            this.rbRemoveRed.Text = "Red";
            this.rbRemoveRed.UseVisualStyleBackColor = true;
            this.rbRemoveRed.CheckedChanged += new System.EventHandler(this.rbRemoveRed_CheckedChanged);
            // 
            // rbRemoveComponent
            // 
            this.rbRemoveComponent.AutoSize = true;
            this.rbRemoveComponent.Location = new System.Drawing.Point(4, 498);
            this.rbRemoveComponent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRemoveComponent.Name = "rbRemoveComponent";
            this.rbRemoveComponent.Size = new System.Drawing.Size(177, 24);
            this.rbRemoveComponent.TabIndex = 13;
            this.rbRemoveComponent.TabStop = true;
            this.rbRemoveComponent.Text = "Remove component";
            this.rbRemoveComponent.UseVisualStyleBackColor = true;
            this.rbRemoveComponent.CheckedChanged += new System.EventHandler(this.rbRemoveComponent_CheckedChanged);
            // 
            // pScaleColors
            // 
            this.pScaleColors.AutoSize = true;
            this.pScaleColors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pScaleColors.Controls.Add(this.pScaleBlue);
            this.pScaleColors.Controls.Add(this.pScaleRed);
            this.pScaleColors.Controls.Add(this.pScaleGreen);
            this.pScaleColors.Location = new System.Drawing.Point(38, 268);
            this.pScaleColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pScaleColors.Name = "pScaleColors";
            this.pScaleColors.Size = new System.Drawing.Size(436, 222);
            this.pScaleColors.TabIndex = 12;
            // 
            // pScaleBlue
            // 
            this.pScaleBlue.Controls.Add(this.lblScaleBlue);
            this.pScaleBlue.Controls.Add(this.tbScaleBlue);
            this.pScaleBlue.Controls.Add(this.PictureBox2);
            this.pScaleBlue.Location = new System.Drawing.Point(0, 152);
            this.pScaleBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pScaleBlue.Name = "pScaleBlue";
            this.pScaleBlue.Size = new System.Drawing.Size(432, 65);
            this.pScaleBlue.TabIndex = 9;
            // 
            // lblScaleBlue
            // 
            this.lblScaleBlue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblScaleBlue.Location = new System.Drawing.Point(48, 45);
            this.lblScaleBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScaleBlue.Name = "lblScaleBlue";
            this.lblScaleBlue.Size = new System.Drawing.Size(384, 20);
            this.lblScaleBlue.TabIndex = 1;
            this.lblScaleBlue.Text = "0";
            this.lblScaleBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbScaleBlue
            // 
            this.tbScaleBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbScaleBlue.Location = new System.Drawing.Point(48, 0);
            this.tbScaleBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbScaleBlue.Maximum = 500;
            this.tbScaleBlue.Minimum = -300;
            this.tbScaleBlue.Name = "tbScaleBlue";
            this.tbScaleBlue.Size = new System.Drawing.Size(384, 65);
            this.tbScaleBlue.TabIndex = 0;
            this.tbScaleBlue.TickFrequency = 0;
            this.tbScaleBlue.Value = 100;
            this.tbScaleBlue.ValueChanged += new System.EventHandler(this.tbScaleBlue_ValueChanged);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(48, 65);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox2.TabIndex = 3;
            this.PictureBox2.TabStop = false;
            // 
            // pScaleRed
            // 
            this.pScaleRed.Controls.Add(this.lblScaleRed);
            this.pScaleRed.Controls.Add(this.tbScaleRed);
            this.pScaleRed.Controls.Add(this.PictureBox1);
            this.pScaleRed.Location = new System.Drawing.Point(0, 0);
            this.pScaleRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pScaleRed.Name = "pScaleRed";
            this.pScaleRed.Size = new System.Drawing.Size(432, 65);
            this.pScaleRed.TabIndex = 8;
            // 
            // lblScaleRed
            // 
            this.lblScaleRed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblScaleRed.Location = new System.Drawing.Point(48, 45);
            this.lblScaleRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScaleRed.Name = "lblScaleRed";
            this.lblScaleRed.Size = new System.Drawing.Size(384, 20);
            this.lblScaleRed.TabIndex = 1;
            this.lblScaleRed.Text = "0";
            this.lblScaleRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbScaleRed
            // 
            this.tbScaleRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbScaleRed.Location = new System.Drawing.Point(48, 0);
            this.tbScaleRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbScaleRed.Maximum = 500;
            this.tbScaleRed.Minimum = -300;
            this.tbScaleRed.Name = "tbScaleRed";
            this.tbScaleRed.Size = new System.Drawing.Size(384, 65);
            this.tbScaleRed.TabIndex = 0;
            this.tbScaleRed.TickFrequency = 0;
            this.tbScaleRed.Value = 100;
            this.tbScaleRed.ValueChanged += new System.EventHandler(this.tbScaleRed_ValueChanged);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(48, 65);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // pScaleGreen
            // 
            this.pScaleGreen.Controls.Add(this.lblScaleGreen);
            this.pScaleGreen.Controls.Add(this.tbScaleGreen);
            this.pScaleGreen.Controls.Add(this.PictureBox3);
            this.pScaleGreen.Location = new System.Drawing.Point(0, 74);
            this.pScaleGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pScaleGreen.Name = "pScaleGreen";
            this.pScaleGreen.Size = new System.Drawing.Size(432, 65);
            this.pScaleGreen.TabIndex = 10;
            // 
            // lblScaleGreen
            // 
            this.lblScaleGreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblScaleGreen.Location = new System.Drawing.Point(48, 45);
            this.lblScaleGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScaleGreen.Name = "lblScaleGreen";
            this.lblScaleGreen.Size = new System.Drawing.Size(384, 20);
            this.lblScaleGreen.TabIndex = 1;
            this.lblScaleGreen.Text = "0";
            this.lblScaleGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbScaleGreen
            // 
            this.tbScaleGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbScaleGreen.Location = new System.Drawing.Point(48, 0);
            this.tbScaleGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbScaleGreen.Maximum = 500;
            this.tbScaleGreen.Minimum = -300;
            this.tbScaleGreen.Name = "tbScaleGreen";
            this.tbScaleGreen.Size = new System.Drawing.Size(384, 65);
            this.tbScaleGreen.TabIndex = 0;
            this.tbScaleGreen.TickFrequency = 0;
            this.tbScaleGreen.Value = 100;
            this.tbScaleGreen.ValueChanged += new System.EventHandler(this.tbScaleGreen_ValueChanged);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(0, 0);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(48, 65);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox3.TabIndex = 3;
            this.PictureBox3.TabStop = false;
            // 
            // rbScaleComponent
            // 
            this.rbScaleComponent.AutoSize = true;
            this.rbScaleComponent.Location = new System.Drawing.Point(4, 232);
            this.rbScaleComponent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbScaleComponent.Name = "rbScaleComponent";
            this.rbScaleComponent.Size = new System.Drawing.Size(158, 24);
            this.rbScaleComponent.TabIndex = 4;
            this.rbScaleComponent.TabStop = true;
            this.rbScaleComponent.Text = "Scale component";
            this.rbScaleComponent.UseVisualStyleBackColor = true;
            this.rbScaleComponent.CheckedChanged += new System.EventHandler(this.rbScaleComponent_CheckedChanged);
            // 
            // pKeepComponent
            // 
            this.pKeepComponent.AutoSize = true;
            this.pKeepComponent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pKeepComponent.Controls.Add(this.rbKeepBlue);
            this.pKeepComponent.Controls.Add(this.rbKeepGreen);
            this.pKeepComponent.Controls.Add(this.rbKeepRed);
            this.pKeepComponent.Location = new System.Drawing.Point(38, 117);
            this.pKeepComponent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pKeepComponent.Name = "pKeepComponent";
            this.pKeepComponent.Size = new System.Drawing.Size(87, 104);
            this.pKeepComponent.TabIndex = 3;
            // 
            // rbKeepBlue
            // 
            this.rbKeepBlue.AutoSize = true;
            this.rbKeepBlue.Location = new System.Drawing.Point(4, 75);
            this.rbKeepBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKeepBlue.Name = "rbKeepBlue";
            this.rbKeepBlue.Size = new System.Drawing.Size(66, 24);
            this.rbKeepBlue.TabIndex = 2;
            this.rbKeepBlue.TabStop = true;
            this.rbKeepBlue.Text = "Blue";
            this.rbKeepBlue.UseVisualStyleBackColor = true;
            this.rbKeepBlue.CheckedChanged += new System.EventHandler(this.rbKeepBlue_CheckedChanged);
            // 
            // rbKeepGreen
            // 
            this.rbKeepGreen.AutoSize = true;
            this.rbKeepGreen.Location = new System.Drawing.Point(4, 40);
            this.rbKeepGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKeepGreen.Name = "rbKeepGreen";
            this.rbKeepGreen.Size = new System.Drawing.Size(79, 24);
            this.rbKeepGreen.TabIndex = 1;
            this.rbKeepGreen.TabStop = true;
            this.rbKeepGreen.Text = "Green";
            this.rbKeepGreen.UseVisualStyleBackColor = true;
            this.rbKeepGreen.CheckedChanged += new System.EventHandler(this.rbKeepGreen_CheckedChanged);
            // 
            // rbKeepRed
            // 
            this.rbKeepRed.AutoSize = true;
            this.rbKeepRed.Location = new System.Drawing.Point(4, 5);
            this.rbKeepRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKeepRed.Name = "rbKeepRed";
            this.rbKeepRed.Size = new System.Drawing.Size(64, 24);
            this.rbKeepRed.TabIndex = 0;
            this.rbKeepRed.TabStop = true;
            this.rbKeepRed.Text = "Red";
            this.rbKeepRed.UseVisualStyleBackColor = true;
            this.rbKeepRed.CheckedChanged += new System.EventHandler(this.rbKeepRed_CheckedChanged);
            // 
            // rbKeepComponent
            // 
            this.rbKeepComponent.AutoSize = true;
            this.rbKeepComponent.Location = new System.Drawing.Point(4, 82);
            this.rbKeepComponent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKeepComponent.Name = "rbKeepComponent";
            this.rbKeepComponent.Size = new System.Drawing.Size(155, 24);
            this.rbKeepComponent.TabIndex = 2;
            this.rbKeepComponent.TabStop = true;
            this.rbKeepComponent.Text = "Keep component";
            this.rbKeepComponent.UseVisualStyleBackColor = true;
            this.rbKeepComponent.CheckedChanged += new System.EventHandler(this.rbKeepComponent_CheckedChanged);
            // 
            // pSwapColors
            // 
            this.pSwapColors.AutoSize = true;
            this.pSwapColors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pSwapColors.Controls.Add(this.cbSwapColor);
            this.pSwapColors.Location = new System.Drawing.Point(38, 31);
            this.pSwapColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pSwapColors.Name = "pSwapColors";
            this.pSwapColors.Size = new System.Drawing.Size(188, 38);
            this.pSwapColors.TabIndex = 11;
            // 
            // cbSwapColor
            // 
            this.cbSwapColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwapColor.FormattingEnabled = true;
            this.cbSwapColor.Location = new System.Drawing.Point(4, 5);
            this.cbSwapColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSwapColor.Name = "cbSwapColor";
            this.cbSwapColor.Size = new System.Drawing.Size(180, 28);
            this.cbSwapColor.TabIndex = 1;
            this.cbSwapColor.SelectedIndexChanged += new System.EventHandler(this.cbSwapColor_SelectedIndexChanged);
            // 
            // rbSwapColor
            // 
            this.rbSwapColor.AutoSize = true;
            this.rbSwapColor.Location = new System.Drawing.Point(4, 5);
            this.rbSwapColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSwapColor.Name = "rbSwapColor";
            this.rbSwapColor.Size = new System.Drawing.Size(120, 24);
            this.rbSwapColor.TabIndex = 0;
            this.rbSwapColor.TabStop = true;
            this.rbSwapColor.Text = "Swap colors";
            this.rbSwapColor.UseVisualStyleBackColor = true;
            this.rbSwapColor.CheckedChanged += new System.EventHandler(this.rbSwapColor_CheckedChanged);
            // 
            // gpPixelFormat
            // 
            this.gpPixelFormat.Controls.Add(this.btnApplyPixelConversion);
            this.gpPixelFormat.Controls.Add(this.cbPixelConversion);
            this.gpPixelFormat.Controls.Add(this.Label16);
            this.gpPixelFormat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpPixelFormat.Location = new System.Drawing.Point(0, 0);
            this.gpPixelFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpPixelFormat.Name = "gpPixelFormat";
            this.gpPixelFormat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpPixelFormat.Size = new System.Drawing.Size(515, 78);
            this.gpPixelFormat.TabIndex = 0;
            this.gpPixelFormat.TabStop = false;
            this.gpPixelFormat.Text = "Pixel format conversion";
            // 
            // btnApplyPixelConversion
            // 
            this.btnApplyPixelConversion.Location = new System.Drawing.Point(376, 25);
            this.btnApplyPixelConversion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyPixelConversion.Name = "btnApplyPixelConversion";
            this.btnApplyPixelConversion.Size = new System.Drawing.Size(112, 35);
            this.btnApplyPixelConversion.TabIndex = 2;
            this.btnApplyPixelConversion.Text = "Apply";
            this.btnApplyPixelConversion.UseVisualStyleBackColor = true;
            this.btnApplyPixelConversion.Click += new System.EventHandler(this.btnApplyPixelConversion_Click);
            // 
            // cbPixelConversion
            // 
            this.cbPixelConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPixelConversion.FormattingEnabled = true;
            this.cbPixelConversion.Location = new System.Drawing.Point(106, 26);
            this.cbPixelConversion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPixelConversion.Name = "cbPixelConversion";
            this.cbPixelConversion.Size = new System.Drawing.Size(259, 28);
            this.cbPixelConversion.TabIndex = 1;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(9, 32);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(86, 20);
            this.Label16.TabIndex = 0;
            this.Label16.Text = "Convert to:";
            // 
            // tpEffects
            // 
            this.tpEffects.Controls.Add(this.pEffects);
            this.tpEffects.Location = new System.Drawing.Point(4, 54);
            this.tpEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpEffects.Name = "tpEffects";
            this.tpEffects.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpEffects.Size = new System.Drawing.Size(330, 1262);
            this.tpEffects.TabIndex = 4;
            this.tpEffects.Text = "Effects";
            this.tpEffects.UseVisualStyleBackColor = true;
            // 
            // pEffects
            // 
            this.pEffects.Controls.Add(this.pEffectsPreview);
            this.pEffects.Controls.Add(this.Panel3);
            this.pEffects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEffects.Location = new System.Drawing.Point(4, 5);
            this.pEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pEffects.Name = "pEffects";
            this.pEffects.Size = new System.Drawing.Size(322, 1252);
            this.pEffects.TabIndex = 0;
            // 
            // pEffectsPreview
            // 
            this.pEffectsPreview.Controls.Add(this.GdViewer2);
            this.pEffectsPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEffectsPreview.Location = new System.Drawing.Point(0, 1015);
            this.pEffectsPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pEffectsPreview.Name = "pEffectsPreview";
            this.pEffectsPreview.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pEffectsPreview.Size = new System.Drawing.Size(322, 237);
            this.pEffectsPreview.TabIndex = 14;
            this.pEffectsPreview.Resize += new System.EventHandler(this.pEffectsPreview_Resize);
            // 
            // GdViewer2
            // 
            this.GdViewer2.AllowDropFile = false;
            this.GdViewer2.AnimateGIF = true;
            this.GdViewer2.AnnotationDropShadow = true;
            this.GdViewer2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewer2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewer2.BackColor = System.Drawing.SystemColors.Control;
            this.GdViewer2.BackgroundImage = null;
            this.GdViewer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewer2.ContinuousViewMode = false;
            this.GdViewer2.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.GdViewer2.DisplayQualityAuto = true;
            this.GdViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdViewer2.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer2.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer2.EnabledProgressBar = false;
            this.GdViewer2.EnableICM = false;
            this.GdViewer2.EnableMenu = false;
            this.GdViewer2.EnableMouseWheel = false;
            this.GdViewer2.EnableTextSelection = false;
            this.GdViewer2.ForceScrollBars = false;
            this.GdViewer2.ForeColor = System.Drawing.Color.Black;
            this.GdViewer2.Gamma = 1F;
            this.GdViewer2.HQAnnotationRendering = true;
            this.GdViewer2.IgnoreDocumentResolution = false;
            this.GdViewer2.KeepDocumentPosition = false;
            this.GdViewer2.Location = new System.Drawing.Point(0, 8);
            this.GdViewer2.LockViewer = false;
            this.GdViewer2.MagnifierHeight = 90;
            this.GdViewer2.MagnifierWidth = 160;
            this.GdViewer2.MagnifierZoomX = 2F;
            this.GdViewer2.MagnifierZoomY = 2F;
            this.GdViewer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GdViewer2.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonNone;
            this.GdViewer2.MouseMode = GdPicture14.ViewerMouseMode.MouseModeDefault;
            this.GdViewer2.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeDisabled;
            this.GdViewer2.Name = "GdViewer2";
            this.GdViewer2.PdfDisplayFormField = true;
            this.GdViewer2.PdfEnableFileLinks = true;
            this.GdViewer2.PdfEnableLinks = true;
            this.GdViewer2.PdfIncreaseTextContrast = false;
            this.GdViewer2.PdfShowDialogForPassword = true;
            this.GdViewer2.PdfShowOpenFileDialogForDecryption = true;
            this.GdViewer2.PdfVerifyDigitalCertificates = false;
            this.GdViewer2.RectBorderColor = System.Drawing.Color.Black;
            this.GdViewer2.RectBorderSize = 1;
            this.GdViewer2.RectIsEditable = false;
            this.GdViewer2.RegionsAreEditable = false;
            this.GdViewer2.ScrollBars = true;
            this.GdViewer2.ScrollLargeChange = ((short)(50));
            this.GdViewer2.ScrollSmallChange = ((short)(1));
            this.GdViewer2.SilentMode = true;
            this.GdViewer2.Size = new System.Drawing.Size(322, 229);
            this.GdViewer2.TabIndex = 0;
            this.GdViewer2.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer2.Zoom = 1D;
            this.GdViewer2.ZoomCenterAtMousePosition = false;
            this.GdViewer2.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer2.ZoomStep = 25;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.cbConvolutionMatrix);
            this.Panel3.Controls.Add(this.rbConvolutionMatrix);
            this.Panel3.Controls.Add(this.pConfigurableEffects);
            this.Panel3.Controls.Add(this.rbConfigurableEffects);
            this.Panel3.Controls.Add(this.pDirectEffects);
            this.Panel3.Controls.Add(this.rbDirectEffects);
            this.Panel3.Controls.Add(this.btnResetEffects);
            this.Panel3.Controls.Add(this.btnApplyEffects);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(322, 1015);
            this.Panel3.TabIndex = 0;
            // 
            // pConfigurableEffects
            // 
            this.pConfigurableEffects.AutoSize = true;
            this.pConfigurableEffects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pConfigurableEffects.Controls.Add(this.pFloodFillEffect);
            this.pConfigurableEffects.Controls.Add(this.pFactorEffect);
            this.pConfigurableEffects.Controls.Add(this.pSubstractBackgroundEffect);
            this.pConfigurableEffects.Controls.Add(this.pSoftenValueEffect);
            this.pConfigurableEffects.Controls.Add(this.pRemoveBackgroundChromokeyEffect);
            this.pConfigurableEffects.Controls.Add(this.pWavesEffect);
            this.pConfigurableEffects.Controls.Add(this.pHaloEffect);
            this.pConfigurableEffects.Controls.Add(this.pKernelSizeEffect);
            this.pConfigurableEffects.Controls.Add(this.pColorizeEffect);
            this.pConfigurableEffects.Controls.Add(this.cbConfigurableEffects);
            this.pConfigurableEffects.Location = new System.Drawing.Point(33, 114);
            this.pConfigurableEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pConfigurableEffects.Name = "pConfigurableEffects";
            this.pConfigurableEffects.Size = new System.Drawing.Size(441, 616);
            this.pConfigurableEffects.TabIndex = 6;
            // 
            // pFloodFillEffect
            // 
            this.pFloodFillEffect.AutoSize = true;
            this.pFloodFillEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pFloodFillEffect.Controls.Add(this.pbFloodFillEffectColor);
            this.pFloodFillEffect.Controls.Add(this.Label17);
            this.pFloodFillEffect.Controls.Add(this.Label18);
            this.pFloodFillEffect.Controls.Add(this.nFloodFillEffectYStart);
            this.pFloodFillEffect.Controls.Add(this.nFloodFillEffectXStart);
            this.pFloodFillEffect.Controls.Add(this.Label19);
            this.pFloodFillEffect.Location = new System.Drawing.Point(4, 572);
            this.pFloodFillEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pFloodFillEffect.Name = "pFloodFillEffect";
            this.pFloodFillEffect.Size = new System.Drawing.Size(403, 39);
            this.pFloodFillEffect.TabIndex = 7;
            // 
            // pbFloodFillEffectColor
            // 
            this.pbFloodFillEffectColor.BackColor = System.Drawing.Color.Black;
            this.pbFloodFillEffectColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFloodFillEffectColor.Location = new System.Drawing.Point(369, 3);
            this.pbFloodFillEffectColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbFloodFillEffectColor.Name = "pbFloodFillEffectColor";
            this.pbFloodFillEffectColor.Size = new System.Drawing.Size(30, 31);
            this.pbFloodFillEffectColor.TabIndex = 11;
            this.pbFloodFillEffectColor.TabStop = false;
            this.pbFloodFillEffectColor.BackColorChanged += new System.EventHandler(this.pbFloodFillEffectColor_BackColorChanged);
            this.pbFloodFillEffectColor.Click += new System.EventHandler(this.pbFloodFillEffectColor_Click);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(314, 8);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(46, 20);
            this.Label17.TabIndex = 6;
            this.Label17.Text = "Color";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(159, 8);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(56, 20);
            this.Label18.TabIndex = 5;
            this.Label18.Text = "Y start";
            // 
            // nFloodFillEffectYStart
            // 
            this.nFloodFillEffectYStart.Location = new System.Drawing.Point(224, 5);
            this.nFloodFillEffectYStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nFloodFillEffectYStart.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nFloodFillEffectYStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFloodFillEffectYStart.Name = "nFloodFillEffectYStart";
            this.nFloodFillEffectYStart.Size = new System.Drawing.Size(81, 26);
            this.nFloodFillEffectYStart.TabIndex = 3;
            this.nFloodFillEffectYStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nFloodFillEffectYStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFloodFillEffectYStart.ValueChanged += new System.EventHandler(this.nFloodFillEffectYStart_ValueChanged);
            this.nFloodFillEffectYStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nFloodFillEffectYStart_KeyUp);
            // 
            // nFloodFillEffectXStart
            // 
            this.nFloodFillEffectXStart.Location = new System.Drawing.Point(69, 5);
            this.nFloodFillEffectXStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nFloodFillEffectXStart.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nFloodFillEffectXStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFloodFillEffectXStart.Name = "nFloodFillEffectXStart";
            this.nFloodFillEffectXStart.Size = new System.Drawing.Size(81, 26);
            this.nFloodFillEffectXStart.TabIndex = 2;
            this.nFloodFillEffectXStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nFloodFillEffectXStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFloodFillEffectXStart.ValueChanged += new System.EventHandler(this.nFloodFillEffectXStart_ValueChanged);
            this.nFloodFillEffectXStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nFloodFillEffectXStart_KeyUp);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(4, 8);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(56, 20);
            this.Label19.TabIndex = 0;
            this.Label19.Text = "X start";
            // 
            // pFactorEffect
            // 
            this.pFactorEffect.AutoSize = true;
            this.pFactorEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pFactorEffect.Controls.Add(this.nFactorEffect);
            this.pFactorEffect.Controls.Add(this.lblFactorEffect);
            this.pFactorEffect.Location = new System.Drawing.Point(4, 529);
            this.pFactorEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pFactorEffect.Name = "pFactorEffect";
            this.pFactorEffect.Size = new System.Drawing.Size(159, 34);
            this.pFactorEffect.TabIndex = 8;
            // 
            // nFactorEffect
            // 
            this.nFactorEffect.DecimalPlaces = 2;
            this.nFactorEffect.Location = new System.Drawing.Point(74, 3);
            this.nFactorEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nFactorEffect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFactorEffect.Name = "nFactorEffect";
            this.nFactorEffect.Size = new System.Drawing.Size(81, 26);
            this.nFactorEffect.TabIndex = 7;
            this.nFactorEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nFactorEffect.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nFactorEffect.ValueChanged += new System.EventHandler(this.nFactorEffect_ValueChanged);
            this.nFactorEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nFactorEffect_KeyUp);
            // 
            // lblFactorEffect
            // 
            this.lblFactorEffect.AutoSize = true;
            this.lblFactorEffect.Location = new System.Drawing.Point(3, 6);
            this.lblFactorEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactorEffect.Name = "lblFactorEffect";
            this.lblFactorEffect.Size = new System.Drawing.Size(55, 20);
            this.lblFactorEffect.TabIndex = 6;
            this.lblFactorEffect.Text = "Factor";
            // 
            // pSubstractBackgroundEffect
            // 
            this.pSubstractBackgroundEffect.AutoSize = true;
            this.pSubstractBackgroundEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pSubstractBackgroundEffect.Controls.Add(this.chkLightBackgroundEffect);
            this.pSubstractBackgroundEffect.Controls.Add(this.nRollingBallSizeEffect);
            this.pSubstractBackgroundEffect.Controls.Add(this.lblRollingBallSizeEffect);
            this.pSubstractBackgroundEffect.Location = new System.Drawing.Point(4, 485);
            this.pSubstractBackgroundEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pSubstractBackgroundEffect.Name = "pSubstractBackgroundEffect";
            this.pSubstractBackgroundEffect.Size = new System.Drawing.Size(384, 36);
            this.pSubstractBackgroundEffect.TabIndex = 7;
            // 
            // chkLightBackgroundEffect
            // 
            this.chkLightBackgroundEffect.AutoSize = true;
            this.chkLightBackgroundEffect.Checked = true;
            this.chkLightBackgroundEffect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLightBackgroundEffect.Location = new System.Drawing.Point(222, 6);
            this.chkLightBackgroundEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLightBackgroundEffect.Name = "chkLightBackgroundEffect";
            this.chkLightBackgroundEffect.Size = new System.Drawing.Size(158, 24);
            this.chkLightBackgroundEffect.TabIndex = 9;
            this.chkLightBackgroundEffect.Text = "Light background";
            this.chkLightBackgroundEffect.UseVisualStyleBackColor = true;
            this.chkLightBackgroundEffect.CheckedChanged += new System.EventHandler(this.chkLightBackgroundEffect_CheckedChanged);
            // 
            // nRollingBallSizeEffect
            // 
            this.nRollingBallSizeEffect.Location = new System.Drawing.Point(132, 5);
            this.nRollingBallSizeEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRollingBallSizeEffect.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nRollingBallSizeEffect.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nRollingBallSizeEffect.Name = "nRollingBallSizeEffect";
            this.nRollingBallSizeEffect.Size = new System.Drawing.Size(81, 26);
            this.nRollingBallSizeEffect.TabIndex = 8;
            this.nRollingBallSizeEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nRollingBallSizeEffect.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nRollingBallSizeEffect.ValueChanged += new System.EventHandler(this.nRollingBallSizeEffect_ValueChanged);
            this.nRollingBallSizeEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nRollingBallSizeEffect_KeyUp);
            // 
            // lblRollingBallSizeEffect
            // 
            this.lblRollingBallSizeEffect.AutoSize = true;
            this.lblRollingBallSizeEffect.Location = new System.Drawing.Point(4, 8);
            this.lblRollingBallSizeEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRollingBallSizeEffect.Name = "lblRollingBallSizeEffect";
            this.lblRollingBallSizeEffect.Size = new System.Drawing.Size(117, 20);
            this.lblRollingBallSizeEffect.TabIndex = 0;
            this.lblRollingBallSizeEffect.Text = "Rolling ball size";
            // 
            // pSoftenValueEffect
            // 
            this.pSoftenValueEffect.AutoSize = true;
            this.pSoftenValueEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pSoftenValueEffect.Controls.Add(this.nSoftenValueEffect);
            this.pSoftenValueEffect.Controls.Add(this.lblSoftenValueEffect);
            this.pSoftenValueEffect.Location = new System.Drawing.Point(4, 440);
            this.pSoftenValueEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pSoftenValueEffect.Name = "pSoftenValueEffect";
            this.pSoftenValueEffect.Size = new System.Drawing.Size(154, 36);
            this.pSoftenValueEffect.TabIndex = 6;
            // 
            // nSoftenValueEffect
            // 
            this.nSoftenValueEffect.Location = new System.Drawing.Point(69, 5);
            this.nSoftenValueEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nSoftenValueEffect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSoftenValueEffect.Name = "nSoftenValueEffect";
            this.nSoftenValueEffect.Size = new System.Drawing.Size(81, 26);
            this.nSoftenValueEffect.TabIndex = 7;
            this.nSoftenValueEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nSoftenValueEffect.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nSoftenValueEffect.ValueChanged += new System.EventHandler(this.nSoftenValueEffect_ValueChanged);
            this.nSoftenValueEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nSoftenValueEffect_KeyUp);
            // 
            // lblSoftenValueEffect
            // 
            this.lblSoftenValueEffect.AutoSize = true;
            this.lblSoftenValueEffect.Location = new System.Drawing.Point(3, 8);
            this.lblSoftenValueEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoftenValueEffect.Name = "lblSoftenValueEffect";
            this.lblSoftenValueEffect.Size = new System.Drawing.Size(50, 20);
            this.lblSoftenValueEffect.TabIndex = 0;
            this.lblSoftenValueEffect.Text = "Value";
            // 
            // pRemoveBackgroundChromokeyEffect
            // 
            this.pRemoveBackgroundChromokeyEffect.AutoSize = true;
            this.pRemoveBackgroundChromokeyEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pRemoveBackgroundChromokeyEffect.Controls.Add(this.nMinKeyValueEffect);
            this.pRemoveBackgroundChromokeyEffect.Controls.Add(this.lblMinKeyValueEffect);
            this.pRemoveBackgroundChromokeyEffect.Controls.Add(this.nVariationEffect);
            this.pRemoveBackgroundChromokeyEffect.Controls.Add(this.lblVariationEffect);
            this.pRemoveBackgroundChromokeyEffect.Controls.Add(this.cbComponentEffect);
            this.pRemoveBackgroundChromokeyEffect.Controls.Add(this.lblComponentEffect);
            this.pRemoveBackgroundChromokeyEffect.Location = new System.Drawing.Point(4, 309);
            this.pRemoveBackgroundChromokeyEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pRemoveBackgroundChromokeyEffect.Name = "pRemoveBackgroundChromokeyEffect";
            this.pRemoveBackgroundChromokeyEffect.Size = new System.Drawing.Size(247, 117);
            this.pRemoveBackgroundChromokeyEffect.TabIndex = 5;
            // 
            // nMinKeyValueEffect
            // 
            this.nMinKeyValueEffect.Location = new System.Drawing.Point(105, 86);
            this.nMinKeyValueEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nMinKeyValueEffect.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nMinKeyValueEffect.Name = "nMinKeyValueEffect";
            this.nMinKeyValueEffect.Size = new System.Drawing.Size(81, 26);
            this.nMinKeyValueEffect.TabIndex = 6;
            this.nMinKeyValueEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nMinKeyValueEffect.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nMinKeyValueEffect.ValueChanged += new System.EventHandler(this.nMinKeyValueEffect_ValueChanged);
            this.nMinKeyValueEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nMinKeyValueEffect_KeyUp);
            // 
            // lblMinKeyValueEffect
            // 
            this.lblMinKeyValueEffect.AutoSize = true;
            this.lblMinKeyValueEffect.Location = new System.Drawing.Point(4, 89);
            this.lblMinKeyValueEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinKeyValueEffect.Name = "lblMinKeyValueEffect";
            this.lblMinKeyValueEffect.Size = new System.Drawing.Size(75, 20);
            this.lblMinKeyValueEffect.TabIndex = 5;
            this.lblMinKeyValueEffect.Text = "Min value";
            // 
            // nVariationEffect
            // 
            this.nVariationEffect.Location = new System.Drawing.Point(105, 46);
            this.nVariationEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nVariationEffect.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nVariationEffect.Name = "nVariationEffect";
            this.nVariationEffect.Size = new System.Drawing.Size(81, 26);
            this.nVariationEffect.TabIndex = 4;
            this.nVariationEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nVariationEffect.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nVariationEffect.ValueChanged += new System.EventHandler(this.nVariationEffect_ValueChanged);
            this.nVariationEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nVariationEffect_KeyUp);
            // 
            // lblVariationEffect
            // 
            this.lblVariationEffect.AutoSize = true;
            this.lblVariationEffect.Location = new System.Drawing.Point(4, 49);
            this.lblVariationEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariationEffect.Name = "lblVariationEffect";
            this.lblVariationEffect.Size = new System.Drawing.Size(72, 20);
            this.lblVariationEffect.TabIndex = 2;
            this.lblVariationEffect.Text = "Variation";
            // 
            // cbComponentEffect
            // 
            this.cbComponentEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComponentEffect.FormattingEnabled = true;
            this.cbComponentEffect.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red"});
            this.cbComponentEffect.Location = new System.Drawing.Point(105, 5);
            this.cbComponentEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbComponentEffect.Name = "cbComponentEffect";
            this.cbComponentEffect.Size = new System.Drawing.Size(138, 28);
            this.cbComponentEffect.TabIndex = 1;
            this.cbComponentEffect.SelectedIndexChanged += new System.EventHandler(this.cbComponentEffect_SelectedIndexChanged);
            // 
            // lblComponentEffect
            // 
            this.lblComponentEffect.AutoSize = true;
            this.lblComponentEffect.Location = new System.Drawing.Point(4, 9);
            this.lblComponentEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComponentEffect.Name = "lblComponentEffect";
            this.lblComponentEffect.Size = new System.Drawing.Size(92, 20);
            this.lblComponentEffect.TabIndex = 0;
            this.lblComponentEffect.Text = "Component";
            // 
            // pWavesEffect
            // 
            this.pWavesEffect.AutoSize = true;
            this.pWavesEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pWavesEffect.Controls.Add(this.nHeightEffect);
            this.pWavesEffect.Controls.Add(this.lblHeightEffect);
            this.pWavesEffect.Controls.Add(this.nWidthEffect);
            this.pWavesEffect.Controls.Add(this.lblWidthEffect);
            this.pWavesEffect.Location = new System.Drawing.Point(4, 265);
            this.pWavesEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pWavesEffect.Name = "pWavesEffect";
            this.pWavesEffect.Size = new System.Drawing.Size(303, 36);
            this.pWavesEffect.TabIndex = 4;
            // 
            // nHeightEffect
            // 
            this.nHeightEffect.Location = new System.Drawing.Point(218, 5);
            this.nHeightEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nHeightEffect.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nHeightEffect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHeightEffect.Name = "nHeightEffect";
            this.nHeightEffect.Size = new System.Drawing.Size(81, 26);
            this.nHeightEffect.TabIndex = 5;
            this.nHeightEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nHeightEffect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHeightEffect.ValueChanged += new System.EventHandler(this.nHeightEffect_ValueChanged);
            this.nHeightEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nHeightEffect_KeyUp);
            // 
            // lblHeightEffect
            // 
            this.lblHeightEffect.AutoSize = true;
            this.lblHeightEffect.Location = new System.Drawing.Point(156, 8);
            this.lblHeightEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeightEffect.Name = "lblHeightEffect";
            this.lblHeightEffect.Size = new System.Drawing.Size(56, 20);
            this.lblHeightEffect.TabIndex = 4;
            this.lblHeightEffect.Text = "Height";
            // 
            // nWidthEffect
            // 
            this.nWidthEffect.Location = new System.Drawing.Point(66, 5);
            this.nWidthEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nWidthEffect.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nWidthEffect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWidthEffect.Name = "nWidthEffect";
            this.nWidthEffect.Size = new System.Drawing.Size(81, 26);
            this.nWidthEffect.TabIndex = 3;
            this.nWidthEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nWidthEffect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWidthEffect.ValueChanged += new System.EventHandler(this.nWidthEffect_ValueChanged);
            this.nWidthEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nWidthEffect_KeyUp);
            // 
            // lblWidthEffect
            // 
            this.lblWidthEffect.AutoSize = true;
            this.lblWidthEffect.Location = new System.Drawing.Point(4, 8);
            this.lblWidthEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidthEffect.Name = "lblWidthEffect";
            this.lblWidthEffect.Size = new System.Drawing.Size(50, 20);
            this.lblWidthEffect.TabIndex = 0;
            this.lblWidthEffect.Text = "Width";
            // 
            // pHaloEffect
            // 
            this.pHaloEffect.AutoSize = true;
            this.pHaloEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pHaloEffect.Controls.Add(this.lblRadiusEffect);
            this.pHaloEffect.Controls.Add(this.lblTopEffect);
            this.pHaloEffect.Controls.Add(this.nRadiusEffect);
            this.pHaloEffect.Controls.Add(this.nTopEffect);
            this.pHaloEffect.Controls.Add(this.nLeftEffect);
            this.pHaloEffect.Controls.Add(this.lblLeftEffect);
            this.pHaloEffect.Location = new System.Drawing.Point(4, 215);
            this.pHaloEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pHaloEffect.Name = "pHaloEffect";
            this.pHaloEffect.Size = new System.Drawing.Size(433, 36);
            this.pHaloEffect.TabIndex = 3;
            // 
            // lblRadiusEffect
            // 
            this.lblRadiusEffect.AutoSize = true;
            this.lblRadiusEffect.Location = new System.Drawing.Point(279, 8);
            this.lblRadiusEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadiusEffect.Name = "lblRadiusEffect";
            this.lblRadiusEffect.Size = new System.Drawing.Size(59, 20);
            this.lblRadiusEffect.TabIndex = 6;
            this.lblRadiusEffect.Text = "Radius";
            // 
            // lblTopEffect
            // 
            this.lblTopEffect.AutoSize = true;
            this.lblTopEffect.Location = new System.Drawing.Point(141, 8);
            this.lblTopEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopEffect.Name = "lblTopEffect";
            this.lblTopEffect.Size = new System.Drawing.Size(36, 20);
            this.lblTopEffect.TabIndex = 5;
            this.lblTopEffect.Text = "Top";
            // 
            // nRadiusEffect
            // 
            this.nRadiusEffect.Location = new System.Drawing.Point(348, 5);
            this.nRadiusEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nRadiusEffect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRadiusEffect.Name = "nRadiusEffect";
            this.nRadiusEffect.Size = new System.Drawing.Size(81, 26);
            this.nRadiusEffect.TabIndex = 4;
            this.nRadiusEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nRadiusEffect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRadiusEffect.ValueChanged += new System.EventHandler(this.nRadiusEffect_ValueChanged);
            this.nRadiusEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nRadiusEffect_KeyUp);
            // 
            // nTopEffect
            // 
            this.nTopEffect.Location = new System.Drawing.Point(189, 5);
            this.nTopEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nTopEffect.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nTopEffect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTopEffect.Name = "nTopEffect";
            this.nTopEffect.Size = new System.Drawing.Size(81, 26);
            this.nTopEffect.TabIndex = 3;
            this.nTopEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nTopEffect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTopEffect.ValueChanged += new System.EventHandler(this.nTopEffect_ValueChanged);
            this.nTopEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nTopEffect_KeyUp);
            // 
            // nLeftEffect
            // 
            this.nLeftEffect.Location = new System.Drawing.Point(51, 5);
            this.nLeftEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nLeftEffect.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nLeftEffect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLeftEffect.Name = "nLeftEffect";
            this.nLeftEffect.Size = new System.Drawing.Size(81, 26);
            this.nLeftEffect.TabIndex = 2;
            this.nLeftEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nLeftEffect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLeftEffect.ValueChanged += new System.EventHandler(this.nLeftEffect_ValueChanged);
            this.nLeftEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nLeftEffect_KeyUp);
            // 
            // lblLeftEffect
            // 
            this.lblLeftEffect.AutoSize = true;
            this.lblLeftEffect.Location = new System.Drawing.Point(4, 8);
            this.lblLeftEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeftEffect.Name = "lblLeftEffect";
            this.lblLeftEffect.Size = new System.Drawing.Size(37, 20);
            this.lblLeftEffect.TabIndex = 0;
            this.lblLeftEffect.Text = "Left";
            // 
            // pKernelSizeEffect
            // 
            this.pKernelSizeEffect.AutoSize = true;
            this.pKernelSizeEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pKernelSizeEffect.Controls.Add(this.nKernelSizeEffect);
            this.pKernelSizeEffect.Controls.Add(this.lblKernelSizeEffect);
            this.pKernelSizeEffect.Location = new System.Drawing.Point(4, 171);
            this.pKernelSizeEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pKernelSizeEffect.Name = "pKernelSizeEffect";
            this.pKernelSizeEffect.Size = new System.Drawing.Size(181, 36);
            this.pKernelSizeEffect.TabIndex = 2;
            // 
            // nKernelSizeEffect
            // 
            this.nKernelSizeEffect.Location = new System.Drawing.Point(96, 5);
            this.nKernelSizeEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nKernelSizeEffect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nKernelSizeEffect.Name = "nKernelSizeEffect";
            this.nKernelSizeEffect.Size = new System.Drawing.Size(81, 26);
            this.nKernelSizeEffect.TabIndex = 1;
            this.nKernelSizeEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nKernelSizeEffect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nKernelSizeEffect.ValueChanged += new System.EventHandler(this.nKernelSizeEffect_ValueChanged);
            this.nKernelSizeEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nKernelSizeEffect_KeyUp);
            // 
            // lblKernelSizeEffect
            // 
            this.lblKernelSizeEffect.AutoSize = true;
            this.lblKernelSizeEffect.Location = new System.Drawing.Point(4, 8);
            this.lblKernelSizeEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKernelSizeEffect.Name = "lblKernelSizeEffect";
            this.lblKernelSizeEffect.Size = new System.Drawing.Size(86, 20);
            this.lblKernelSizeEffect.TabIndex = 0;
            this.lblKernelSizeEffect.Text = "Kernel size";
            // 
            // pColorizeEffect
            // 
            this.pColorizeEffect.AutoSize = true;
            this.pColorizeEffect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pColorizeEffect.Controls.Add(this.nLuminosityEffect);
            this.pColorizeEffect.Controls.Add(this.lblLuminosityEffect);
            this.pColorizeEffect.Controls.Add(this.nSaturationEffect);
            this.pColorizeEffect.Controls.Add(this.lblSaturationEffect);
            this.pColorizeEffect.Controls.Add(this.nHueEffect);
            this.pColorizeEffect.Controls.Add(this.lblHueEffect);
            this.pColorizeEffect.Location = new System.Drawing.Point(4, 46);
            this.pColorizeEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pColorizeEffect.Name = "pColorizeEffect";
            this.pColorizeEffect.Size = new System.Drawing.Size(181, 116);
            this.pColorizeEffect.TabIndex = 1;
            // 
            // nLuminosityEffect
            // 
            this.nLuminosityEffect.DecimalPlaces = 2;
            this.nLuminosityEffect.Location = new System.Drawing.Point(96, 85);
            this.nLuminosityEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nLuminosityEffect.Name = "nLuminosityEffect";
            this.nLuminosityEffect.Size = new System.Drawing.Size(81, 26);
            this.nLuminosityEffect.TabIndex = 5;
            this.nLuminosityEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nLuminosityEffect.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nLuminosityEffect.ValueChanged += new System.EventHandler(this.nLuminosityEffect_ValueChanged);
            this.nLuminosityEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nLuminosityEffect_KeyUp);
            // 
            // lblLuminosityEffect
            // 
            this.lblLuminosityEffect.AutoSize = true;
            this.lblLuminosityEffect.Location = new System.Drawing.Point(3, 88);
            this.lblLuminosityEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuminosityEffect.Name = "lblLuminosityEffect";
            this.lblLuminosityEffect.Size = new System.Drawing.Size(84, 20);
            this.lblLuminosityEffect.TabIndex = 4;
            this.lblLuminosityEffect.Text = "Luminosity";
            // 
            // nSaturationEffect
            // 
            this.nSaturationEffect.DecimalPlaces = 2;
            this.nSaturationEffect.Location = new System.Drawing.Point(96, 45);
            this.nSaturationEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nSaturationEffect.Name = "nSaturationEffect";
            this.nSaturationEffect.Size = new System.Drawing.Size(81, 26);
            this.nSaturationEffect.TabIndex = 3;
            this.nSaturationEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nSaturationEffect.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nSaturationEffect.ValueChanged += new System.EventHandler(this.nSaturationEffect_ValueChanged);
            this.nSaturationEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nSaturationEffect_KeyUp);
            // 
            // lblSaturationEffect
            // 
            this.lblSaturationEffect.AutoSize = true;
            this.lblSaturationEffect.Location = new System.Drawing.Point(4, 48);
            this.lblSaturationEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaturationEffect.Name = "lblSaturationEffect";
            this.lblSaturationEffect.Size = new System.Drawing.Size(83, 20);
            this.lblSaturationEffect.TabIndex = 2;
            this.lblSaturationEffect.Text = "Saturation";
            // 
            // nHueEffect
            // 
            this.nHueEffect.DecimalPlaces = 2;
            this.nHueEffect.Location = new System.Drawing.Point(96, 5);
            this.nHueEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nHueEffect.Name = "nHueEffect";
            this.nHueEffect.Size = new System.Drawing.Size(81, 26);
            this.nHueEffect.TabIndex = 1;
            this.nHueEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nHueEffect.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nHueEffect.ValueChanged += new System.EventHandler(this.nHueEffect_ValueChanged);
            this.nHueEffect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nHueEffect_KeyUp);
            // 
            // lblHueEffect
            // 
            this.lblHueEffect.AutoSize = true;
            this.lblHueEffect.Location = new System.Drawing.Point(4, 8);
            this.lblHueEffect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHueEffect.Name = "lblHueEffect";
            this.lblHueEffect.Size = new System.Drawing.Size(39, 20);
            this.lblHueEffect.TabIndex = 0;
            this.lblHueEffect.Text = "Hue";
            // 
            // cbConfigurableEffects
            // 
            this.cbConfigurableEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConfigurableEffects.FormattingEnabled = true;
            this.cbConfigurableEffects.Location = new System.Drawing.Point(4, 5);
            this.cbConfigurableEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbConfigurableEffects.Name = "cbConfigurableEffects";
            this.cbConfigurableEffects.Size = new System.Drawing.Size(247, 28);
            this.cbConfigurableEffects.TabIndex = 0;
            this.cbConfigurableEffects.SelectedIndexChanged += new System.EventHandler(this.cbConfigurableEffects_SelectedIndexChanged);
            // 
            // rbConfigurableEffects
            // 
            this.rbConfigurableEffects.AutoSize = true;
            this.rbConfigurableEffects.Location = new System.Drawing.Point(4, 78);
            this.rbConfigurableEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbConfigurableEffects.Name = "rbConfigurableEffects";
            this.rbConfigurableEffects.Size = new System.Drawing.Size(177, 24);
            this.rbConfigurableEffects.TabIndex = 5;
            this.rbConfigurableEffects.TabStop = true;
            this.rbConfigurableEffects.Text = "Configurable effects";
            this.rbConfigurableEffects.UseVisualStyleBackColor = true;
            this.rbConfigurableEffects.CheckedChanged += new System.EventHandler(this.rbConfigurableEffects_CheckedChanged);
            // 
            // pDirectEffects
            // 
            this.pDirectEffects.AutoSize = true;
            this.pDirectEffects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pDirectEffects.Controls.Add(this.cbDirectEffects);
            this.pDirectEffects.Location = new System.Drawing.Point(33, 28);
            this.pDirectEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pDirectEffects.Name = "pDirectEffects";
            this.pDirectEffects.Size = new System.Drawing.Size(188, 38);
            this.pDirectEffects.TabIndex = 4;
            // 
            // cbDirectEffects
            // 
            this.cbDirectEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirectEffects.FormattingEnabled = true;
            this.cbDirectEffects.Location = new System.Drawing.Point(4, 5);
            this.cbDirectEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDirectEffects.Name = "cbDirectEffects";
            this.cbDirectEffects.Size = new System.Drawing.Size(180, 28);
            this.cbDirectEffects.TabIndex = 2;
            this.cbDirectEffects.SelectedIndexChanged += new System.EventHandler(this.cbEffects_SelectedIndexChanged);
            // 
            // rbDirectEffects
            // 
            this.rbDirectEffects.AutoSize = true;
            this.rbDirectEffects.Location = new System.Drawing.Point(4, 5);
            this.rbDirectEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDirectEffects.Name = "rbDirectEffects";
            this.rbDirectEffects.Size = new System.Drawing.Size(129, 24);
            this.rbDirectEffects.TabIndex = 3;
            this.rbDirectEffects.TabStop = true;
            this.rbDirectEffects.Text = "Direct effects";
            this.rbDirectEffects.UseVisualStyleBackColor = true;
            this.rbDirectEffects.CheckedChanged += new System.EventHandler(this.rbDirectEffects_CheckedChanged);
            // 
            // btnResetEffects
            // 
            this.btnResetEffects.Location = new System.Drawing.Point(33, 950);
            this.btnResetEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetEffects.Name = "btnResetEffects";
            this.btnResetEffects.Size = new System.Drawing.Size(112, 35);
            this.btnResetEffects.TabIndex = 1;
            this.btnResetEffects.Text = "Reset";
            this.btnResetEffects.UseVisualStyleBackColor = true;
            this.btnResetEffects.Click += new System.EventHandler(this.btnResetEffects_Click);
            // 
            // btnApplyEffects
            // 
            this.btnApplyEffects.Location = new System.Drawing.Point(154, 950);
            this.btnApplyEffects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyEffects.Name = "btnApplyEffects";
            this.btnApplyEffects.Size = new System.Drawing.Size(112, 35);
            this.btnApplyEffects.TabIndex = 0;
            this.btnApplyEffects.Text = "Apply";
            this.btnApplyEffects.UseVisualStyleBackColor = true;
            this.btnApplyEffects.Click += new System.EventHandler(this.btnApplyEffects_Click);
            // 
            // scMain
            // 
            this.scMain.BackColor = System.Drawing.SystemColors.Control;
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.scMain.Panel1.Controls.Add(this.Panel6);
            this.scMain.Panel1MinSize = 256;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.GdViewer1);
            this.scMain.Panel2MinSize = 200;
            this.scMain.Size = new System.Drawing.Size(1896, 1371);
            this.scMain.SplitterDistance = 388;
            this.scMain.SplitterWidth = 6;
            this.scMain.TabIndex = 2;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.Panel9);
            this.Panel6.Controls.Add(this.pSnapInButtons);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(0, 0);
            this.Panel6.Margin = new System.Windows.Forms.Padding(0);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(386, 1369);
            this.Panel6.TabIndex = 2;
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.SystemColors.Control;
            this.Panel9.Controls.Add(this.tcLeftPanel);
            this.Panel9.Controls.Add(this.Panel7);
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel9.Location = new System.Drawing.Point(48, 0);
            this.Panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(338, 1369);
            this.Panel9.TabIndex = 5;
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.SystemColors.Control;
            this.Panel7.Controls.Add(this.lblSnapInPanel);
            this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel7.Location = new System.Drawing.Point(0, 0);
            this.Panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(338, 49);
            this.Panel7.TabIndex = 6;
            // 
            // lblSnapInPanel
            // 
            this.lblSnapInPanel.AutoSize = true;
            this.lblSnapInPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnapInPanel.Location = new System.Drawing.Point(9, 12);
            this.lblSnapInPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnapInPanel.Name = "lblSnapInPanel";
            this.lblSnapInPanel.Size = new System.Drawing.Size(159, 22);
            this.lblSnapInPanel.TabIndex = 0;
            this.lblSnapInPanel.Text = "Image properties";
            // 
            // pSnapInButtons
            // 
            this.pSnapInButtons.AutoSize = true;
            this.pSnapInButtons.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pSnapInButtons.Controls.Add(this.btnSnapInThumbnails);
            this.pSnapInButtons.Controls.Add(this.btnSnapInImageProperties);
            this.pSnapInButtons.Controls.Add(this.btnSnapInAdjustment);
            this.pSnapInButtons.Controls.Add(this.btnSnapInTransform);
            this.pSnapInButtons.Controls.Add(this.btnSnapInColorOperations);
            this.pSnapInButtons.Controls.Add(this.btnSnapInEffects);
            this.pSnapInButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSnapInButtons.Location = new System.Drawing.Point(0, 0);
            this.pSnapInButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pSnapInButtons.Name = "pSnapInButtons";
            this.pSnapInButtons.Size = new System.Drawing.Size(48, 1369);
            this.pSnapInButtons.TabIndex = 4;
            // 
            // btnSnapInThumbnails
            // 
            this.btnSnapInThumbnails.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInThumbnails.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSnapInThumbnails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInThumbnails.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInThumbnails.Image")));
            this.btnSnapInThumbnails.Location = new System.Drawing.Point(0, 0);
            this.btnSnapInThumbnails.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInThumbnails.Name = "btnSnapInThumbnails";
            this.btnSnapInThumbnails.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInThumbnails.TabIndex = 5;
            this.btnSnapInThumbnails.UseVisualStyleBackColor = false;
            this.btnSnapInThumbnails.Click += new System.EventHandler(this.btnSnapInThumbnails_Click);
            // 
            // btnSnapInImageProperties
            // 
            this.btnSnapInImageProperties.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInImageProperties.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSnapInImageProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInImageProperties.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInImageProperties.Image")));
            this.btnSnapInImageProperties.Location = new System.Drawing.Point(0, 48);
            this.btnSnapInImageProperties.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInImageProperties.Name = "btnSnapInImageProperties";
            this.btnSnapInImageProperties.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInImageProperties.TabIndex = 0;
            this.btnSnapInImageProperties.UseVisualStyleBackColor = false;
            this.btnSnapInImageProperties.Click += new System.EventHandler(this.btnSnapInImageProperties_Click);
            // 
            // btnSnapInAdjustment
            // 
            this.btnSnapInAdjustment.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInAdjustment.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInAdjustment.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInAdjustment.Image")));
            this.btnSnapInAdjustment.Location = new System.Drawing.Point(0, 95);
            this.btnSnapInAdjustment.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInAdjustment.Name = "btnSnapInAdjustment";
            this.btnSnapInAdjustment.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInAdjustment.TabIndex = 1;
            this.btnSnapInAdjustment.UseVisualStyleBackColor = false;
            this.btnSnapInAdjustment.Click += new System.EventHandler(this.btnSnapInAdjustment_Click);
            // 
            // btnSnapInTransform
            // 
            this.btnSnapInTransform.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInTransform.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInTransform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInTransform.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInTransform.Image")));
            this.btnSnapInTransform.Location = new System.Drawing.Point(0, 143);
            this.btnSnapInTransform.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInTransform.Name = "btnSnapInTransform";
            this.btnSnapInTransform.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInTransform.TabIndex = 2;
            this.btnSnapInTransform.UseVisualStyleBackColor = false;
            this.btnSnapInTransform.Click += new System.EventHandler(this.btnSnapInTransform_Click);
            // 
            // btnSnapInColorOperations
            // 
            this.btnSnapInColorOperations.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInColorOperations.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInColorOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInColorOperations.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInColorOperations.Image")));
            this.btnSnapInColorOperations.Location = new System.Drawing.Point(0, 191);
            this.btnSnapInColorOperations.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInColorOperations.Name = "btnSnapInColorOperations";
            this.btnSnapInColorOperations.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInColorOperations.TabIndex = 3;
            this.btnSnapInColorOperations.UseVisualStyleBackColor = false;
            this.btnSnapInColorOperations.Click += new System.EventHandler(this.btnSnapInColorOperations_Click);
            // 
            // btnSnapInEffects
            // 
            this.btnSnapInEffects.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSnapInEffects.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnapInEffects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapInEffects.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapInEffects.Image")));
            this.btnSnapInEffects.Location = new System.Drawing.Point(0, 238);
            this.btnSnapInEffects.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnapInEffects.Name = "btnSnapInEffects";
            this.btnSnapInEffects.Size = new System.Drawing.Size(48, 49);
            this.btnSnapInEffects.TabIndex = 4;
            this.btnSnapInEffects.UseVisualStyleBackColor = false;
            this.btnSnapInEffects.Click += new System.EventHandler(this.btnSnapInEffects_Click);
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDropFile = false;
            this.GdViewer1.AnimateGIF = true;
            this.GdViewer1.AnnotationDropShadow = true;
            this.GdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GdViewer1.BackgroundImage = null;
            this.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewer1.ContinuousViewMode = true;
            this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.GdViewer1.DisplayQualityAuto = true;
            this.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer1.EnabledProgressBar = true;
            this.GdViewer1.EnableICM = false;
            this.GdViewer1.EnableMenu = true;
            this.GdViewer1.EnableMouseWheel = true;
            this.GdViewer1.EnableTextSelection = true;
            this.GdViewer1.ForceScrollBars = false;
            this.GdViewer1.ForeColor = System.Drawing.Color.Black;
            this.GdViewer1.Gamma = 1F;
            this.GdViewer1.HQAnnotationRendering = true;
            this.GdViewer1.IgnoreDocumentResolution = false;
            this.GdViewer1.KeepDocumentPosition = false;
            this.GdViewer1.Location = new System.Drawing.Point(0, 0);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
            this.GdViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
            this.GdViewer1.Name = "GdViewer1";
            this.GdViewer1.PdfDisplayFormField = true;
            this.GdViewer1.PdfEnableFileLinks = true;
            this.GdViewer1.PdfEnableLinks = true;
            this.GdViewer1.PdfIncreaseTextContrast = false;
            this.GdViewer1.PdfShowDialogForPassword = true;
            this.GdViewer1.PdfShowOpenFileDialogForDecryption = true;
            this.GdViewer1.PdfVerifyDigitalCertificates = false;
            this.GdViewer1.RectBorderColor = System.Drawing.Color.Black;
            this.GdViewer1.RectBorderSize = 1;
            this.GdViewer1.RectIsEditable = true;
            this.GdViewer1.RegionsAreEditable = true;
            this.GdViewer1.ScrollBars = true;
            this.GdViewer1.ScrollLargeChange = ((short)(50));
            this.GdViewer1.ScrollSmallChange = ((short)(1));
            this.GdViewer1.SilentMode = true;
            this.GdViewer1.Size = new System.Drawing.Size(1500, 1369);
            this.GdViewer1.TabIndex = 0;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 1D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer;
            this.GdViewer1.ZoomStep = 25;
            this.GdViewer1.TransferEnded += new GdPicture14.GdViewer.TransferEndedEventHandler(this.GdViewer1_TransferEnded);
            this.GdViewer1.AfterZoomChange += new GdPicture14.GdViewer.AfterZoomChangeEventHandler(this.GdViewer1_AfterZoomChange);
            this.GdViewer1.PageChanged += new GdPicture14.GdViewer.PageChangedEventHandler(this.GdViewer1_PageChanged);
            this.GdViewer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GdViewer1_MouseMove);
            // 
            // statusbar
            // 
            this.statusbar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblImageInfo,
            this.lblImageSize,
            this.lblMousePosition});
            this.statusbar.Location = new System.Drawing.Point(0, 1406);
            this.statusbar.Name = "statusbar";
            this.statusbar.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusbar.Size = new System.Drawing.Size(1896, 22);
            this.statusbar.TabIndex = 3;
            this.statusbar.Text = "StatusStrip1";
            // 
            // lblImageInfo
            // 
            this.lblImageInfo.Name = "lblImageInfo";
            this.lblImageInfo.Size = new System.Drawing.Size(1673, 17);
            this.lblImageInfo.Spring = true;
            this.lblImageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = false;
            this.lblImageSize.Image = ((System.Drawing.Image)(resources.GetObject("lblImageSize.Image")));
            this.lblImageSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(100, 17);
            // 
            // lblMousePosition
            // 
            this.lblMousePosition.AutoSize = false;
            this.lblMousePosition.Image = ((System.Drawing.Image)(resources.GetObject("lblMousePosition.Image")));
            this.lblMousePosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMousePosition.Name = "lblMousePosition";
            this.lblMousePosition.Size = new System.Drawing.Size(100, 17);
            this.lblMousePosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.ToolStripSeparator9,
            this.btnClose,
            this.btnPrint,
            this.btnSave,
            this.ToolStripSeparator3,
            this.btnCopyToClipboard,
            this.btnImportFromClipboard,
            this.ToolStripSeparator1,
            this.btnSettings,
            this.ToolStripSeparator8,
            this.btnMouseMode,
            this.toolStripSeparator4,
            this.btnFirstPage,
            this.btnPreviousPage,
            this.tbCurrentPage,
            this.lblPageCount,
            this.btnNextPage,
            this.btnLastPage,
            this.ToolStripSeparator6,
            this.btnZoomOut,
            this.cbZoom,
            this.btnZoomIn,
            this.ToolStripSeparator2,
            this.btnFitWidth,
            this.btnFitPage,
            this.ToolStripSeparator5,
            this.btnAbout});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.mainToolStrip.Size = new System.Drawing.Size(1896, 35);
            this.mainToolStrip.TabIndex = 5;
            this.mainToolStrip.Text = "ToolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(147, 32);
            this.btnOpen.Text = "Open image";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 35);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 32);
            this.btnClose.Text = "Close document";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(28, 32);
            this.btnPrint.Text = "Print document";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(28, 32);
            this.btnSave.Text = "Save image";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyToClipboard.Image")));
            this.btnCopyToClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(28, 32);
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnImportFromClipboard
            // 
            this.btnImportFromClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImportFromClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnImportFromClipboard.Image")));
            this.btnImportFromClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportFromClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportFromClipboard.Name = "btnImportFromClipboard";
            this.btnImportFromClipboard.Size = new System.Drawing.Size(28, 32);
            this.btnImportFromClipboard.Text = "Import from clipboard";
            this.btnImportFromClipboard.Click += new System.EventHandler(this.btnImportFromClipboard_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(28, 32);
            this.btnSettings.Text = "Viewer settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 35);
            // 
            // btnMouseMode
            // 
            this.btnMouseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMouseMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefaultToolStripMenuItem,
            this.AreaSelectionToolStripMenuItem,
            this.PanToolStripMenuItem,
            this.AreaZoomingToolStripMenuItem,
            this.MagnifierToolStripMenuItem});
            this.btnMouseMode.Image = ((System.Drawing.Image)(resources.GetObject("btnMouseMode.Image")));
            this.btnMouseMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMouseMode.Name = "btnMouseMode";
            this.btnMouseMode.Size = new System.Drawing.Size(42, 32);
            this.btnMouseMode.Text = "Mouse mode";
            // 
            // DefaultToolStripMenuItem
            // 
            this.DefaultToolStripMenuItem.CheckOnClick = true;
            this.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem";
            this.DefaultToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.DefaultToolStripMenuItem.Text = "Default";
            this.DefaultToolStripMenuItem.Click += new System.EventHandler(this.DefaultToolStripMenuItem_Click);
            // 
            // AreaSelectionToolStripMenuItem
            // 
            this.AreaSelectionToolStripMenuItem.CheckOnClick = true;
            this.AreaSelectionToolStripMenuItem.Name = "AreaSelectionToolStripMenuItem";
            this.AreaSelectionToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.AreaSelectionToolStripMenuItem.Text = "Area selection";
            this.AreaSelectionToolStripMenuItem.Click += new System.EventHandler(this.AreaSelectionToolStripMenuItem_Click);
            // 
            // PanToolStripMenuItem
            // 
            this.PanToolStripMenuItem.Checked = true;
            this.PanToolStripMenuItem.CheckOnClick = true;
            this.PanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PanToolStripMenuItem.Name = "PanToolStripMenuItem";
            this.PanToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.PanToolStripMenuItem.Text = "Pan";
            this.PanToolStripMenuItem.Click += new System.EventHandler(this.PanToolStripMenuItem_Click);
            // 
            // AreaZoomingToolStripMenuItem
            // 
            this.AreaZoomingToolStripMenuItem.CheckOnClick = true;
            this.AreaZoomingToolStripMenuItem.Name = "AreaZoomingToolStripMenuItem";
            this.AreaZoomingToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.AreaZoomingToolStripMenuItem.Text = "Area zooming";
            this.AreaZoomingToolStripMenuItem.Click += new System.EventHandler(this.AreaZoomingToolStripMenuItem_Click);
            // 
            // MagnifierToolStripMenuItem
            // 
            this.MagnifierToolStripMenuItem.CheckOnClick = true;
            this.MagnifierToolStripMenuItem.Name = "MagnifierToolStripMenuItem";
            this.MagnifierToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.MagnifierToolStripMenuItem.Text = "Magnifier";
            this.MagnifierToolStripMenuItem.Click += new System.EventHandler(this.MagnifierToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.Image")));
            this.btnFirstPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(28, 32);
            this.btnFirstPage.Text = "Go to first page";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.Image")));
            this.btnPreviousPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(28, 32);
            this.btnPreviousPage.Text = "Go to previous page";
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.Size = new System.Drawing.Size(58, 35);
            this.tbCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCurrentPage.Leave += new System.EventHandler(this.tbCurrentPage_Leave);
            // 
            // lblPageCount
            // 
            this.lblPageCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(37, 32);
            this.lblPageCount.Text = "/ X";
            // 
            // btnNextPage
            // 
            this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(28, 32);
            this.btnNextPage.Text = "Go to next page";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnLastPage.Image")));
            this.btnLastPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(28, 32);
            this.btnLastPage.Text = "Go to last page";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(28, 32);
            this.btnZoomOut.Text = "Zoom out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // cbZoom
            // 
            this.cbZoom.DropDownWidth = 200;
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(110, 35);
            this.cbZoom.SelectedIndexChanged += new System.EventHandler(this.cbZoom_SelectedIndexChanged);
            this.cbZoom.Validating += new System.ComponentModel.CancelEventHandler(this.cbZoom_Validating);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(28, 32);
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // btnFitWidth
            // 
            this.btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFitWidth.Image = ((System.Drawing.Image)(resources.GetObject("btnFitWidth.Image")));
            this.btnFitWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitWidth.Name = "btnFitWidth";
            this.btnFitWidth.Size = new System.Drawing.Size(28, 32);
            this.btnFitWidth.Text = "Adjust to page width";
            this.btnFitWidth.Click += new System.EventHandler(this.btnFitWidth_Click);
            // 
            // btnFitPage
            // 
            this.btnFitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFitPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFitPage.Image")));
            this.btnFitPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFitPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFitPage.Name = "btnFitPage";
            this.btnFitPage.Size = new System.Drawing.Size(28, 32);
            this.btnFitPage.Text = "Adjust to whole page";
            this.btnFitPage.Click += new System.EventHandler(this.btnFitPage_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(28, 32);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.scMain);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 35);
            this.pMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1896, 1371);
            this.pMain.TabIndex = 6;
            // 
            // rbConvolutionMatrix
            // 
            this.rbConvolutionMatrix.AutoSize = true;
            this.rbConvolutionMatrix.Location = new System.Drawing.Point(5, 739);
            this.rbConvolutionMatrix.Name = "rbConvolutionMatrix";
            this.rbConvolutionMatrix.Size = new System.Drawing.Size(205, 24);
            this.rbConvolutionMatrix.TabIndex = 7;
            this.rbConvolutionMatrix.TabStop = true;
            this.rbConvolutionMatrix.Text = "Convolution matrix filters";
            this.rbConvolutionMatrix.UseVisualStyleBackColor = true;
            this.rbConvolutionMatrix.CheckedChanged += new System.EventHandler(this.rbConvolutionMatrix_CheckedChanged);
            // 
            // cbConvolutionMatrix
            // 
            this.cbConvolutionMatrix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConvolutionMatrix.FormattingEnabled = true;
            this.cbConvolutionMatrix.Location = new System.Drawing.Point(33, 769);
            this.cbConvolutionMatrix.Name = "cbConvolutionMatrix";
            this.cbConvolutionMatrix.Size = new System.Drawing.Size(184, 28);
            this.cbConvolutionMatrix.TabIndex = 8;
            this.cbConvolutionMatrix.SelectedIndexChanged += new System.EventHandler(this.cbConvolutionMatrix_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1428);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.statusbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GdPicture .NET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcLeftPanel.ResumeLayout(false);
            this.tpThumbnails.ResumeLayout(false);
            this.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer1.ResumeLayout(false);
            this.ToolStripContainer1.PerformLayout();
            this.thumbnailPanelToolstrip.ResumeLayout(false);
            this.thumbnailPanelToolstrip.PerformLayout();
            this.tpImageProperties.ResumeLayout(false);
            this.pImageProperties.ResumeLayout(false);
            this.tpAdjustment.ResumeLayout(false);
            this.pAdjustment.ResumeLayout(false);
            this.pAdjustment.PerformLayout();
            this.pAdjustPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adjustPeviewViewer)).EndInit();
            this.Panel8.ResumeLayout(false);
            this.gpBlue.ResumeLayout(false);
            this.gpBlue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            this.gpGreen.ResumeLayout(false);
            this.gpGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            this.gpRed.ResumeLayout(false);
            this.gpRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            this.gpGamma.ResumeLayout(false);
            this.gpGamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGamma)).EndInit();
            this.gpSaturation.ResumeLayout(false);
            this.gpSaturation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaturation)).EndInit();
            this.gpContrast.ResumeLayout(false);
            this.gpContrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrast)).EndInit();
            this.grpBrightness.ResumeLayout(false);
            this.grpBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrightness)).EndInit();
            this.tpTransform.ResumeLayout(false);
            this.pTransform.ResumeLayout(false);
            this.gpRotation.ResumeLayout(false);
            this.gpRotation.PerformLayout();
            this.pCustomAngle.ResumeLayout(false);
            this.pCustomAngle.PerformLayout();
            this.pRotationPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rotationPeviewViewer)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotationBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRotationAngle)).EndInit();
            this.gpImageSize.ResumeLayout(false);
            this.gpImageSize.PerformLayout();
            this.gpDocumentSize.ResumeLayout(false);
            this.gpDocumentSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVerticalResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHorizontalResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDocumentHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDocumentWidth)).EndInit();
            this.gpPixelDimensions.ResumeLayout(false);
            this.gpPixelDimensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScalePercent)).EndInit();
            this.tpColorOperations.ResumeLayout(false);
            this.pColorOperations.ResumeLayout(false);
            this.gpColorChannelsManipulation.ResumeLayout(false);
            this.gpColorChannelsManipulation.PerformLayout();
            this.pColorChannelsViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorChannelPreviewViewer)).EndInit();
            this.pColorManipulation.ResumeLayout(false);
            this.pColorManipulation.PerformLayout();
            this.pRemoveComponent.ResumeLayout(false);
            this.pRemoveComponent.PerformLayout();
            this.pScaleColors.ResumeLayout(false);
            this.pScaleBlue.ResumeLayout(false);
            this.pScaleBlue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.pScaleRed.ResumeLayout(false);
            this.pScaleRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.pScaleGreen.ResumeLayout(false);
            this.pScaleGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.pKeepComponent.ResumeLayout(false);
            this.pKeepComponent.PerformLayout();
            this.pSwapColors.ResumeLayout(false);
            this.gpPixelFormat.ResumeLayout(false);
            this.gpPixelFormat.PerformLayout();
            this.tpEffects.ResumeLayout(false);
            this.pEffects.ResumeLayout(false);
            this.pEffectsPreview.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.pConfigurableEffects.ResumeLayout(false);
            this.pConfigurableEffects.PerformLayout();
            this.pFloodFillEffect.ResumeLayout(false);
            this.pFloodFillEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFloodFillEffectColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFloodFillEffectYStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFloodFillEffectXStart)).EndInit();
            this.pFactorEffect.ResumeLayout(false);
            this.pFactorEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFactorEffect)).EndInit();
            this.pSubstractBackgroundEffect.ResumeLayout(false);
            this.pSubstractBackgroundEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRollingBallSizeEffect)).EndInit();
            this.pSoftenValueEffect.ResumeLayout(false);
            this.pSoftenValueEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoftenValueEffect)).EndInit();
            this.pRemoveBackgroundChromokeyEffect.ResumeLayout(false);
            this.pRemoveBackgroundChromokeyEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinKeyValueEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVariationEffect)).EndInit();
            this.pWavesEffect.ResumeLayout(false);
            this.pWavesEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHeightEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidthEffect)).EndInit();
            this.pHaloEffect.ResumeLayout(false);
            this.pHaloEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRadiusEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTopEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLeftEffect)).EndInit();
            this.pKernelSizeEffect.ResumeLayout(false);
            this.pKernelSizeEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nKernelSizeEffect)).EndInit();
            this.pColorizeEffect.ResumeLayout(false);
            this.pColorizeEffect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLuminosityEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSaturationEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHueEffect)).EndInit();
            this.pDirectEffects.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.pSnapInButtons.ResumeLayout(false);
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TabControl tcLeftPanel;
		internal System.Windows.Forms.TabPage tpImageProperties;
		internal System.Windows.Forms.TabPage tpAdjustment;
		internal System.Windows.Forms.SplitContainer scMain;
		internal GdPicture14.GdViewer GdViewer1;
		internal System.Windows.Forms.StatusStrip statusbar;
		internal System.Windows.Forms.ToolStrip mainToolStrip;
		internal System.Windows.Forms.Panel pMain;
		internal System.Windows.Forms.ToolStripButton btnOpen;
		internal System.Windows.Forms.ToolStripButton btnClose;
		internal System.Windows.Forms.ToolStripButton btnPrint;
		internal System.Windows.Forms.ToolStripButton btnAbout;
		internal System.Windows.Forms.ToolStripStatusLabel lblImageInfo;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
		internal System.Windows.Forms.TabPage tpTransform;
		internal System.Windows.Forms.ToolStripButton btnZoomOut;
		internal System.Windows.Forms.ToolStripComboBox cbZoom;
		internal System.Windows.Forms.ToolStripButton btnZoomIn;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.Panel pAdjustment;
		internal System.Windows.Forms.ToolStripButton btnSettings;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
		internal System.Windows.Forms.ToolStripButton btnFitWidth;
		internal System.Windows.Forms.ToolStripButton btnFitPage;
		internal System.Windows.Forms.Panel Panel6;
		internal System.Windows.Forms.Button btnSnapInImageProperties;
		internal System.Windows.Forms.Button btnSnapInTransform;
		internal System.Windows.Forms.Button btnSnapInAdjustment;
		internal System.Windows.Forms.Panel Panel9;
		internal System.Windows.Forms.Panel pSnapInButtons;
		internal System.Windows.Forms.Panel Panel7;
		internal System.Windows.Forms.Label lblSnapInPanel;
		internal System.Windows.Forms.ToolStripDropDownButton btnMouseMode;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
		internal System.Windows.Forms.ToolStripMenuItem DefaultToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AreaSelectionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem PanToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AreaZoomingToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MagnifierToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
		internal System.Windows.Forms.GroupBox grpBrightness;
		internal System.Windows.Forms.Label lblBrightness;
		internal System.Windows.Forms.TrackBar tbBrightness;
		internal System.Windows.Forms.Panel pAdjustPreview;
		internal System.Windows.Forms.GroupBox gpSaturation;
		internal System.Windows.Forms.Label lblSaturation;
		internal System.Windows.Forms.TrackBar tbSaturation;
		internal System.Windows.Forms.GroupBox gpContrast;
		internal System.Windows.Forms.Label lblContrast;
		internal System.Windows.Forms.TrackBar tbContrast;
		internal System.Windows.Forms.GroupBox gpGamma;
		internal System.Windows.Forms.Label lblGamma;
		internal System.Windows.Forms.TrackBar tbGamma;
		internal System.Windows.Forms.GroupBox gpBlue;
		internal System.Windows.Forms.Label lblBlue;
		internal System.Windows.Forms.TrackBar tbBlue;
		internal System.Windows.Forms.GroupBox gpGreen;
		internal System.Windows.Forms.Label lblGreen;
		internal System.Windows.Forms.TrackBar tbGreen;
		internal System.Windows.Forms.GroupBox gpRed;
		internal System.Windows.Forms.Label lblRed;
		internal System.Windows.Forms.TrackBar tbRed;
		internal System.Windows.Forms.Panel Panel8;
		internal System.Windows.Forms.Button btnResetAdjustment;
		internal System.Windows.Forms.Button btnApplyAdjustment;
		internal System.Windows.Forms.PictureBox pbBrightness;
		internal System.Windows.Forms.PictureBox pbBlue;
		internal System.Windows.Forms.PictureBox pbGreen;
		internal System.Windows.Forms.PictureBox pbRed;
		internal System.Windows.Forms.PictureBox pbGamma;
		internal System.Windows.Forms.PictureBox pbSaturation;
		internal System.Windows.Forms.PictureBox pbContrast;
		internal System.Windows.Forms.ToolStripButton btnImportFromClipboard;
		internal System.Windows.Forms.ToolStripButton btnCopyToClipboard;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripButton btnSave;
		internal System.Windows.Forms.Panel pImageProperties;
		internal System.Windows.Forms.TreeView tvImageProperties;
		internal System.Windows.Forms.ToolStripStatusLabel lblImageSize;
		internal System.Windows.Forms.ToolStripStatusLabel lblMousePosition;
		internal System.Windows.Forms.Panel pTransform;
		internal System.Windows.Forms.GroupBox gpImageSize;
		internal System.Windows.Forms.NumericUpDown nScalePercent;
		internal System.Windows.Forms.RadioButton rbScalePercent;
		internal System.Windows.Forms.ComboBox cbResampling;
		internal System.Windows.Forms.Label lblResampling;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.RadioButton rbResize;
		internal System.Windows.Forms.CheckBox chkKeepAspectRatio;
		internal System.Windows.Forms.GroupBox gpPixelDimensions;
		internal System.Windows.Forms.NumericUpDown nHeight;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.NumericUpDown nWidth;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.GroupBox gpDocumentSize;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.NumericUpDown nHorizontalResolution;
		internal System.Windows.Forms.NumericUpDown nDocumentHeight;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.NumericUpDown nDocumentWidth;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.NumericUpDown nVerticalResolution;
		internal System.Windows.Forms.Button btnResetSize;
		internal System.Windows.Forms.Button btnApplySize;
		internal System.Windows.Forms.GroupBox gpRotation;
		internal System.Windows.Forms.NumericUpDown nRotationAngle;
		internal System.Windows.Forms.Button btnApplyRotation;
		internal System.Windows.Forms.Panel pCustomAngle;
		internal System.Windows.Forms.Panel pRotationPreview;
		internal System.Windows.Forms.PictureBox rotationPeviewViewer;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label lblCustomRotationBackgroundColor;
		internal System.Windows.Forms.CheckBox chkRotateFromCenter;
		internal System.Windows.Forms.CheckBox chkKeepImageDimensionRotation;
		internal System.Windows.Forms.PictureBox pbRotationBackColor;
		internal System.Windows.Forms.Button btnSnapInColorOperations;
		internal System.Windows.Forms.TabPage tpColorOperations;
		internal System.Windows.Forms.GroupBox gpPixelFormat;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.ComboBox cbPixelConversion;
		internal System.Windows.Forms.Button btnApplyPixelConversion;
		internal System.Windows.Forms.Panel pColorOperations;
		internal System.Windows.Forms.GroupBox gpColorChannelsManipulation;
		internal System.Windows.Forms.RadioButton rbSwapColor;
		internal System.Windows.Forms.RadioButton rbKeepComponent;
		internal System.Windows.Forms.ComboBox cbSwapColor;
		internal System.Windows.Forms.Panel pKeepComponent;
		internal System.Windows.Forms.RadioButton rbKeepBlue;
		internal System.Windows.Forms.RadioButton rbKeepGreen;
		internal System.Windows.Forms.RadioButton rbKeepRed;
		internal System.Windows.Forms.RadioButton rbScaleComponent;
		internal System.Windows.Forms.Panel pScaleRed;
		internal System.Windows.Forms.Label lblScaleRed;
		internal System.Windows.Forms.TrackBar tbScaleRed;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Panel pScaleGreen;
		internal System.Windows.Forms.Label lblScaleGreen;
		internal System.Windows.Forms.TrackBar tbScaleGreen;
		internal System.Windows.Forms.PictureBox PictureBox3;
		internal System.Windows.Forms.Panel pScaleBlue;
		internal System.Windows.Forms.Label lblScaleBlue;
		internal System.Windows.Forms.TrackBar tbScaleBlue;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.Panel pSwapColors;
		internal System.Windows.Forms.Panel pColorManipulation;
		internal System.Windows.Forms.Panel pScaleColors;
		internal System.Windows.Forms.Panel pRemoveComponent;
		internal System.Windows.Forms.RadioButton rbRemoveComponent;
		internal System.Windows.Forms.Button btnApplyColorChannels;
		internal System.Windows.Forms.Button btnResetColorChannels;
		internal System.Windows.Forms.Panel pColorChannelsViewer;
		internal System.Windows.Forms.PictureBox colorChannelPreviewViewer;
		internal System.Windows.Forms.RadioButton rbRemoveBlue;
		internal System.Windows.Forms.RadioButton rbRemoveGreen;
		internal System.Windows.Forms.RadioButton rbRemoveRed;
		internal System.Windows.Forms.Button btnSnapInEffects;
		internal System.Windows.Forms.TabPage tpEffects;
		internal System.Windows.Forms.Panel pEffects;
		internal System.Windows.Forms.Panel pEffectsPreview;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Button btnResetEffects;
		internal System.Windows.Forms.Button btnApplyEffects;
		internal System.Windows.Forms.ComboBox cbDirectEffects;
		internal System.Windows.Forms.Panel pDirectEffects;
		internal System.Windows.Forms.RadioButton rbDirectEffects;
		internal System.Windows.Forms.RadioButton rbConfigurableEffects;
		internal System.Windows.Forms.Panel pConfigurableEffects;
		internal System.Windows.Forms.ComboBox cbConfigurableEffects;
		internal System.Windows.Forms.Panel pColorizeEffect;
		internal System.Windows.Forms.NumericUpDown nSaturationEffect;
		internal System.Windows.Forms.Label lblSaturationEffect;
		internal System.Windows.Forms.NumericUpDown nHueEffect;
		internal System.Windows.Forms.Label lblHueEffect;
		internal System.Windows.Forms.NumericUpDown nLuminosityEffect;
		internal System.Windows.Forms.Label lblLuminosityEffect;
		internal System.Windows.Forms.Panel pKernelSizeEffect;
		internal System.Windows.Forms.NumericUpDown nKernelSizeEffect;
		internal System.Windows.Forms.Label lblKernelSizeEffect;
		internal System.Windows.Forms.Panel pHaloEffect;
		internal System.Windows.Forms.Label lblRadiusEffect;
		internal System.Windows.Forms.Label lblTopEffect;
		internal System.Windows.Forms.NumericUpDown nRadiusEffect;
		internal System.Windows.Forms.NumericUpDown nTopEffect;
		internal System.Windows.Forms.NumericUpDown nLeftEffect;
		internal System.Windows.Forms.Label lblLeftEffect;
		internal System.Windows.Forms.Panel pWavesEffect;
		internal System.Windows.Forms.NumericUpDown nHeightEffect;
		internal System.Windows.Forms.Label lblHeightEffect;
		internal System.Windows.Forms.NumericUpDown nWidthEffect;
		internal System.Windows.Forms.Label lblWidthEffect;
		internal System.Windows.Forms.Panel pRemoveBackgroundChromokeyEffect;
		internal System.Windows.Forms.ComboBox cbComponentEffect;
		internal System.Windows.Forms.Label lblComponentEffect;
		internal System.Windows.Forms.NumericUpDown nMinKeyValueEffect;
		internal System.Windows.Forms.Label lblMinKeyValueEffect;
		internal System.Windows.Forms.NumericUpDown nVariationEffect;
		internal System.Windows.Forms.Label lblVariationEffect;
		internal System.Windows.Forms.Panel pSoftenValueEffect;
		internal System.Windows.Forms.NumericUpDown nSoftenValueEffect;
		internal System.Windows.Forms.Label lblSoftenValueEffect;
		internal System.Windows.Forms.Panel pSubstractBackgroundEffect;
		internal System.Windows.Forms.CheckBox chkLightBackgroundEffect;
		internal System.Windows.Forms.NumericUpDown nRollingBallSizeEffect;
		internal System.Windows.Forms.Label lblRollingBallSizeEffect;
		internal System.Windows.Forms.Panel pFactorEffect;
		internal System.Windows.Forms.NumericUpDown nFactorEffect;
		internal System.Windows.Forms.Label lblFactorEffect;
		internal System.Windows.Forms.Panel pFloodFillEffect;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.NumericUpDown nFloodFillEffectYStart;
		internal System.Windows.Forms.NumericUpDown nFloodFillEffectXStart;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.PictureBox pbFloodFillEffectColor;
		internal System.Windows.Forms.RadioButton rbFlipVertical;
		internal System.Windows.Forms.RadioButton rbFlipHorizontal;
		internal System.Windows.Forms.RadioButton rbRotateRight;
		internal System.Windows.Forms.RadioButton rbRotateLeft;
		internal System.Windows.Forms.RadioButton rbRotateCustomAngle;
		internal System.Windows.Forms.PictureBox adjustPeviewViewer;
		internal GdPicture14.GdViewer GdViewer2;
        internal Button btnSnapInThumbnails;
        private TabPage tpThumbnails;
        internal ToolStripContainer ToolStripContainer1;
        internal ToolStrip thumbnailPanelToolstrip;
        internal ToolStripDropDownButton btnThumbSize;
        internal ToolStripMenuItem LargeThumbnailsToolStripMenuItem1;
        internal ToolStripMenuItem MediumThumbnailsToolStripMenuItem1;
        internal ToolStripMenuItem SmallThumbnailsToolStripMenuItem1;
        internal GdPicture14.ThumbnailEx ThumbnailEx1;
        internal ToolStripSeparator toolStripSeparator4;
        internal ToolStripButton btnFirstPage;
        internal ToolStripButton btnPreviousPage;
        internal ToolStripTextBox tbCurrentPage;
        internal ToolStripLabel lblPageCount;
        internal ToolStripButton btnNextPage;
        internal ToolStripButton btnLastPage;
        private ComboBox cbConvolutionMatrix;
        private RadioButton rbConvolutionMatrix;
    }
	
}
