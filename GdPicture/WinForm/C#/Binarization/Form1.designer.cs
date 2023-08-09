using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace Binarization
{
    partial class FormBinarizationDemo
    {

        /// <summary>
        /// Cleans up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
       
        
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components; 
        
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBinarizationDemo));
            this.MenuStripFile = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GdViewer1 = new GdPicture14.GdViewer();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.scroll3Panel = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxSmoothKernelVal = new System.Windows.Forms.TextBox();
            this.HScrollBarSmoothKernel = new System.Windows.Forms.HScrollBar();
            this.LabelSmoothKernelMin = new System.Windows.Forms.Label();
            this.LabelSmoothKernel = new System.Windows.Forms.Label();
            this.LabelSmoothKernelMax = new System.Windows.Forms.Label();
            this.scroll2Panel = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxContrastDifVal = new System.Windows.Forms.TextBox();
            this.HScrollBarContrastDif = new System.Windows.Forms.HScrollBar();
            this.LabelContrastDifMin = new System.Windows.Forms.Label();
            this.LabelContrastDif = new System.Windows.Forms.Label();
            this.LabelContrastDifMax = new System.Windows.Forms.Label();
            this.scroll1Panel = new System.Windows.Forms.TableLayoutPanel();
            this.LabelThreshold = new System.Windows.Forms.Label();
            this.LabelThresholdMin = new System.Windows.Forms.Label();
            this.HScrollBarThreshold = new System.Windows.Forms.HScrollBar();
            this.LabelThresholdMax = new System.Windows.Forms.Label();
            this.TextBoxThresholdVal = new System.Windows.Forms.TextBox();
            this.ComboBoxBinarizationMode = new System.Windows.Forms.ComboBox();
            this.MenuStripFile.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.scroll3Panel.SuspendLayout();
            this.scroll2Panel.SuspendLayout();
            this.scroll1Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile});
            this.MenuStripFile.Location = new System.Drawing.Point(0, 0);
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.MenuStripFile.Size = new System.Drawing.Size(1108, 26);
            this.MenuStripFile.TabIndex = 0;
            this.MenuStripFile.Text = "MenuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpen,
            this.ToolStripMenuItemClose,
            this.ToolStripMenuItemSave,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(44, 24);
            this.ToolStripMenuItemFile.Text = "File";
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(120, 26);
            this.ToolStripMenuItemOpen.Text = "Open";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(120, 26);
            this.ToolStripMenuItemClose.Text = "Close";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(120, 26);
            this.ToolStripMenuItemSave.Text = "Save";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(120, 26);
            this.ToolStripMenuItemExit.Text = "Exit";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.GdViewer1, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.ComboBoxBinarizationMode, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1108, 645);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // GdViewer1
            // 
            this.GdViewer1.AllowDropFile = false;
            this.GdViewer1.AnimateGIF = false;
            this.GdViewer1.AnnotationDropShadow = true;
            this.GdViewer1.AnnotationResizeRotateHandlesColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.GdViewer1.AnnotationResizeRotateHandlesScale = 1F;
            this.GdViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.GdViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.GdViewer1.BackColor = System.Drawing.Color.Black;
            this.GdViewer1.BackgroundImage = null;
            this.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GdViewer1.ContinuousViewMode = true;
            this.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ;
            this.GdViewer1.DisplayQualityAuto = false;
            this.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter;
            this.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter;
            this.GdViewer1.EnableDeferredPainting = true;
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
            this.GdViewer1.Location = new System.Drawing.Point(6, 54);
            this.GdViewer1.LockViewer = false;
            this.GdViewer1.MagnifierHeight = 90;
            this.GdViewer1.MagnifierWidth = 160;
            this.GdViewer1.MagnifierZoomX = 2F;
            this.GdViewer1.MagnifierZoomY = 2F;
            this.GdViewer1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft;
            this.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan;
            this.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom;
            this.GdViewer1.Name = "GdViewer1";
            this.GdViewer1.PageDisplayMode = GdPicture14.PageDisplayMode.SinglePageView;
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
            this.GdViewer1.RenderGdPictureAnnots = true;
            this.GdViewer1.ScrollBars = true;
            this.GdViewer1.ScrollLargeChange = ((short)(50));
            this.GdViewer1.ScrollSmallChange = ((short)(1));
            this.GdViewer1.SilentMode = true;
            this.GdViewer1.Size = new System.Drawing.Size(1096, 459);
            this.GdViewer1.TabIndex = 0;
            this.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.GdViewer1.Zoom = 1D;
            this.GdViewer1.ZoomCenterAtMousePosition = false;
            this.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomMode100;
            this.GdViewer1.ZoomStep = 25;
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 2;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.Controls.Add(this.scroll3Panel, 0, 1);
            this.TableLayoutPanel3.Controls.Add(this.scroll2Panel, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.scroll1Panel, 0, 0);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(6, 517);
            this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 2;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(1095, 125);
            this.TableLayoutPanel3.TabIndex = 2;
            // 
            // scroll3Panel
            // 
            this.scroll3Panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scroll3Panel.ColumnCount = 5;
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.27928F));
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.72072F));
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.scroll3Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.scroll3Panel.Controls.Add(this.TextBoxSmoothKernelVal, 4, 0);
            this.scroll3Panel.Controls.Add(this.HScrollBarSmoothKernel, 2, 0);
            this.scroll3Panel.Controls.Add(this.LabelSmoothKernelMin, 1, 0);
            this.scroll3Panel.Controls.Add(this.LabelSmoothKernel, 0, 0);
            this.scroll3Panel.Controls.Add(this.LabelSmoothKernelMax, 3, 0);
            this.scroll3Panel.Location = new System.Drawing.Point(4, 77);
            this.scroll3Panel.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.scroll3Panel.Name = "scroll3Panel";
            this.scroll3Panel.RowCount = 1;
            this.scroll3Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scroll3Panel.Size = new System.Drawing.Size(539, 33);
            this.scroll3Panel.TabIndex = 2;
            // 
            // TextBoxSmoothKernelVal
            // 
            this.TextBoxSmoothKernelVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxSmoothKernelVal.Enabled = false;
            this.TextBoxSmoothKernelVal.Location = new System.Drawing.Point(425, 5);
            this.TextBoxSmoothKernelVal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.TextBoxSmoothKernelVal.Name = "TextBoxSmoothKernelVal";
            this.TextBoxSmoothKernelVal.Size = new System.Drawing.Size(99, 22);
            this.TextBoxSmoothKernelVal.TabIndex = 5;
            this.TextBoxSmoothKernelVal.Text = "2";
            // 
            // HScrollBarSmoothKernel
            // 
            this.HScrollBarSmoothKernel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HScrollBarSmoothKernel.LargeChange = 1;
            this.HScrollBarSmoothKernel.Location = new System.Drawing.Point(113, 3);
            this.HScrollBarSmoothKernel.Maximum = 5;
            this.HScrollBarSmoothKernel.Name = "HScrollBarSmoothKernel";
            this.HScrollBarSmoothKernel.Size = new System.Drawing.Size(253, 26);
            this.HScrollBarSmoothKernel.TabIndex = 3;
            this.HScrollBarSmoothKernel.Value = 2;
            this.HScrollBarSmoothKernel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarSmoothKernel_Scroll);
            // 
            // LabelSmoothKernelMin
            // 
            this.LabelSmoothKernelMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelSmoothKernelMin.AutoSize = true;
            this.LabelSmoothKernelMin.Location = new System.Drawing.Point(94, 8);
            this.LabelSmoothKernelMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSmoothKernelMin.Name = "LabelSmoothKernelMin";
            this.LabelSmoothKernelMin.Size = new System.Drawing.Size(15, 17);
            this.LabelSmoothKernelMin.TabIndex = 2;
            this.LabelSmoothKernelMin.Text = "0";
            // 
            // LabelSmoothKernel
            // 
            this.LabelSmoothKernel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelSmoothKernel.AutoSize = true;
            this.LabelSmoothKernel.Location = new System.Drawing.Point(4, 0);
            this.LabelSmoothKernel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSmoothKernel.Name = "LabelSmoothKernel";
            this.LabelSmoothKernel.Size = new System.Drawing.Size(60, 33);
            this.LabelSmoothKernel.TabIndex = 1;
            this.LabelSmoothKernel.Text = "Smooth Kernel";
            // 
            // LabelSmoothKernelMax
            // 
            this.LabelSmoothKernelMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelSmoothKernelMax.AutoSize = true;
            this.LabelSmoothKernelMax.Location = new System.Drawing.Point(374, 8);
            this.LabelSmoothKernelMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSmoothKernelMax.Name = "LabelSmoothKernelMax";
            this.LabelSmoothKernelMax.Size = new System.Drawing.Size(16, 17);
            this.LabelSmoothKernelMax.TabIndex = 4;
            this.LabelSmoothKernelMax.Text = "5";
            // 
            // scroll2Panel
            // 
            this.scroll2Panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scroll2Panel.ColumnCount = 5;
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.scroll2Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.scroll2Panel.Controls.Add(this.TextBoxContrastDifVal, 4, 0);
            this.scroll2Panel.Controls.Add(this.HScrollBarContrastDif, 2, 0);
            this.scroll2Panel.Controls.Add(this.LabelContrastDifMin, 1, 0);
            this.scroll2Panel.Controls.Add(this.LabelContrastDif, 0, 0);
            this.scroll2Panel.Controls.Add(this.LabelContrastDifMax, 3, 0);
            this.scroll2Panel.Location = new System.Drawing.Point(551, 14);
            this.scroll2Panel.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.scroll2Panel.Name = "scroll2Panel";
            this.scroll2Panel.RowCount = 1;
            this.scroll2Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scroll2Panel.Size = new System.Drawing.Size(540, 33);
            this.scroll2Panel.TabIndex = 1;
            // 
            // TextBoxContrastDifVal
            // 
            this.TextBoxContrastDifVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxContrastDifVal.Enabled = false;
            this.TextBoxContrastDifVal.Location = new System.Drawing.Point(436, 5);
            this.TextBoxContrastDifVal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.TextBoxContrastDifVal.Name = "TextBoxContrastDifVal";
            this.TextBoxContrastDifVal.Size = new System.Drawing.Size(88, 22);
            this.TextBoxContrastDifVal.TabIndex = 5;
            this.TextBoxContrastDifVal.Text = "50";
            // 
            // HScrollBarContrastDif
            // 
            this.HScrollBarContrastDif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HScrollBarContrastDif.LargeChange = 1;
            this.HScrollBarContrastDif.Location = new System.Drawing.Point(133, 3);
            this.HScrollBarContrastDif.Maximum = 255;
            this.HScrollBarContrastDif.Name = "HScrollBarContrastDif";
            this.HScrollBarContrastDif.Size = new System.Drawing.Size(247, 26);
            this.HScrollBarContrastDif.TabIndex = 3;
            this.HScrollBarContrastDif.Value = 50;
            this.HScrollBarContrastDif.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarContrastDif_Scroll);
            // 
            // LabelContrastDifMin
            // 
            this.LabelContrastDifMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelContrastDifMin.AutoSize = true;
            this.LabelContrastDifMin.Location = new System.Drawing.Point(113, 8);
            this.LabelContrastDifMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelContrastDifMin.Name = "LabelContrastDifMin";
            this.LabelContrastDifMin.Size = new System.Drawing.Size(16, 17);
            this.LabelContrastDifMin.TabIndex = 2;
            this.LabelContrastDifMin.Text = "0";
            // 
            // LabelContrastDif
            // 
            this.LabelContrastDif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelContrastDif.AutoSize = true;
            this.LabelContrastDif.Location = new System.Drawing.Point(4, 0);
            this.LabelContrastDif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelContrastDif.Name = "LabelContrastDif";
            this.LabelContrastDif.Size = new System.Drawing.Size(90, 33);
            this.LabelContrastDif.TabIndex = 1;
            this.LabelContrastDif.Text = "Contrast Dif. Min";
            // 
            // LabelContrastDifMax
            // 
            this.LabelContrastDifMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelContrastDifMax.AutoSize = true;
            this.LabelContrastDifMax.Location = new System.Drawing.Point(384, 8);
            this.LabelContrastDifMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelContrastDifMax.Name = "LabelContrastDifMax";
            this.LabelContrastDifMax.Size = new System.Drawing.Size(32, 17);
            this.LabelContrastDifMax.TabIndex = 4;
            this.LabelContrastDifMax.Text = "255";
            // 
            // scroll1Panel
            // 
            this.scroll1Panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.scroll1Panel.ColumnCount = 5;
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.scroll1Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.scroll1Panel.Controls.Add(this.LabelThreshold, 0, 0);
            this.scroll1Panel.Controls.Add(this.LabelThresholdMin, 1, 0);
            this.scroll1Panel.Controls.Add(this.HScrollBarThreshold, 2, 0);
            this.scroll1Panel.Controls.Add(this.LabelThresholdMax, 3, 0);
            this.scroll1Panel.Controls.Add(this.TextBoxThresholdVal, 4, 0);
            this.scroll1Panel.Location = new System.Drawing.Point(4, 14);
            this.scroll1Panel.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.scroll1Panel.Name = "scroll1Panel";
            this.scroll1Panel.RowCount = 1;
            this.scroll1Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.scroll1Panel.Size = new System.Drawing.Size(539, 33);
            this.scroll1Panel.TabIndex = 0;
            // 
            // LabelThreshold
            // 
            this.LabelThreshold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelThreshold.AutoSize = true;
            this.LabelThreshold.Location = new System.Drawing.Point(4, 8);
            this.LabelThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThreshold.Name = "LabelThreshold";
            this.LabelThreshold.Size = new System.Drawing.Size(72, 17);
            this.LabelThreshold.TabIndex = 0;
            this.LabelThreshold.Text = "Threshold";
            // 
            // LabelThresholdMin
            // 
            this.LabelThresholdMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelThresholdMin.AutoSize = true;
            this.LabelThresholdMin.Location = new System.Drawing.Point(84, 8);
            this.LabelThresholdMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThresholdMin.Name = "LabelThresholdMin";
            this.LabelThresholdMin.Size = new System.Drawing.Size(16, 17);
            this.LabelThresholdMin.TabIndex = 1;
            this.LabelThresholdMin.Text = "0";
            // 
            // HScrollBarThreshold
            // 
            this.HScrollBarThreshold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HScrollBarThreshold.LargeChange = 1;
            this.HScrollBarThreshold.Location = new System.Drawing.Point(104, 3);
            this.HScrollBarThreshold.Name = "HScrollBarThreshold";
            this.HScrollBarThreshold.Size = new System.Drawing.Size(253, 26);
            this.HScrollBarThreshold.TabIndex = 2;
            this.HScrollBarThreshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarThreshold_Scroll);
            // 
            // LabelThresholdMax
            // 
            this.LabelThresholdMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelThresholdMax.AutoSize = true;
            this.LabelThresholdMax.Location = new System.Drawing.Point(365, 8);
            this.LabelThresholdMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThresholdMax.Name = "LabelThresholdMax";
            this.LabelThresholdMax.Size = new System.Drawing.Size(32, 17);
            this.LabelThresholdMax.TabIndex = 3;
            this.LabelThresholdMax.Text = "100";
            // 
            // TextBoxThresholdVal
            // 
            this.TextBoxThresholdVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxThresholdVal.Enabled = false;
            this.TextBoxThresholdVal.Location = new System.Drawing.Point(416, 5);
            this.TextBoxThresholdVal.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.TextBoxThresholdVal.Name = "TextBoxThresholdVal";
            this.TextBoxThresholdVal.Size = new System.Drawing.Size(99, 22);
            this.TextBoxThresholdVal.TabIndex = 4;
            // 
            // ComboBoxBinarizationMode
            // 
            this.ComboBoxBinarizationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBinarizationMode.FormattingEnabled = true;
            this.ComboBoxBinarizationMode.Items.AddRange(new object[] {
            "None",
            "Linear",
            "Adaptive (Otsu)",
            "Order Dither",
            "Burke",
            "Stucki",
            "Floyd Steinberg",
            "Sauvola",
            "Bradley"});
            this.ComboBoxBinarizationMode.Location = new System.Drawing.Point(6, 3);
            this.ComboBoxBinarizationMode.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.ComboBoxBinarizationMode.Name = "ComboBoxBinarizationMode";
            this.ComboBoxBinarizationMode.Size = new System.Drawing.Size(303, 24);
            this.ComboBoxBinarizationMode.TabIndex = 1;
            this.ComboBoxBinarizationMode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBinarizationMode_SelectedIndexChanged);
            // 
            // FormBinarizationDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 671);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.MenuStripFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripFile;
            this.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.Name = "FormBinarizationDemo";
            this.Text = "GdPicture.NET - Binarization Demo  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.FormBinarizationDemo_Load);
            this.MenuStripFile.ResumeLayout(false);
            this.MenuStripFile.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.scroll3Panel.ResumeLayout(false);
            this.scroll3Panel.PerformLayout();
            this.scroll2Panel.ResumeLayout(false);
            this.scroll2Panel.PerformLayout();
            this.scroll1Panel.ResumeLayout(false);
            this.scroll1Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal System.Windows.Forms.MenuStrip MenuStripFile; 
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile; 
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen; 
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose; 
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave; 
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit; 
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1; 
        private System.Windows.Forms.ComboBox ComboBoxBinarizationMode; 
        internal GdPicture14.GdViewer GdViewer1; 
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3; 
        internal System.Windows.Forms.TableLayoutPanel scroll3Panel; 
        internal System.Windows.Forms.TableLayoutPanel scroll2Panel; 
        internal System.Windows.Forms.TableLayoutPanel scroll1Panel; 
        internal System.Windows.Forms.Label LabelSmoothKernelMin; 
        internal System.Windows.Forms.Label LabelSmoothKernel; 
        internal System.Windows.Forms.Label LabelContrastDifMin; 
        internal System.Windows.Forms.Label LabelContrastDif; 
        internal System.Windows.Forms.Label LabelThreshold; 
        internal System.Windows.Forms.Label LabelThresholdMin; 
        internal System.Windows.Forms.HScrollBar HScrollBarSmoothKernel; 
        internal System.Windows.Forms.HScrollBar HScrollBarContrastDif; 
        internal System.Windows.Forms.HScrollBar HScrollBarThreshold; 
        internal System.Windows.Forms.Label LabelThresholdMax; 
        internal System.Windows.Forms.TextBox TextBoxSmoothKernelVal; 
        internal System.Windows.Forms.Label LabelSmoothKernelMax; 
        internal System.Windows.Forms.TextBox TextBoxContrastDifVal; 
        internal System.Windows.Forms.Label LabelContrastDifMax; 
        internal System.Windows.Forms.TextBox TextBoxThresholdVal;
       
        
        
    } 
    
    
} 
