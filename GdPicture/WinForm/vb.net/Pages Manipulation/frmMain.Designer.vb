<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tcLeftPanel = New System.Windows.Forms.TabControl()
        Me.tpThumbnails = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.thumbnailPanelToolstrip = New System.Windows.Forms.ToolStrip()
        Me.btnThumbSize = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LargeThumbnailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumThumbnailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallThumbnailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeleteCurrentPage = New System.Windows.Forms.ToolStripButton()
        Me.ThumbnailEx1 = New GdPicture14.ThumbnailEx()
        Me.tpBookmarks = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BookmarksTree1 = New GdPicture14.BookmarksTree()
        Me.tpSearch = New System.Windows.Forms.TabPage()
        Me.pSearch = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lstSearchResults = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.searchProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lblSearchResults = New System.Windows.Forms.Label()
        Me.chkWholeWord = New System.Windows.Forms.CheckBox()
        Me.chkCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCurrentPage = New System.Windows.Forms.RadioButton()
        Me.rbAllPages = New System.Windows.Forms.RadioButton()
        Me.btnFindPrevious = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSearchFor = New System.Windows.Forms.Label()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblSnapInPanel = New System.Windows.Forms.Label()
        Me.pSnapInButtons = New System.Windows.Forms.Panel()
        Me.btnSnapInThumbnails = New System.Windows.Forms.Button()
        Me.btnSnapInBookmarks = New System.Windows.Forms.Button()
        Me.btnSnapInSearch = New System.Windows.Forms.Button()
        Me.pGamma = New System.Windows.Forms.Panel()
        Me.lblGamma = New System.Windows.Forms.Label()
        Me.tbGamma = New System.Windows.Forms.TrackBar()
        Me.GdViewer1 = New GdPicture14.GdViewer()
        Me.statusbar = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnMouseMode = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaZoomingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagnifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFirstPage = New System.Windows.Forms.ToolStripButton()
        Me.btnPreviousPage = New System.Windows.Forms.ToolStripButton()
        Me.tbCurrentPage = New System.Windows.Forms.ToolStripTextBox()
        Me.lblPageCount = New System.Windows.Forms.ToolStripLabel()
        Me.btnNextPage = New System.Windows.Forms.ToolStripButton()
        Me.btnLastPage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.cbZoom = New System.Windows.Forms.ToolStripComboBox()
        Me.btnZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFitWidth = New System.Windows.Forms.ToolStripButton()
        Me.btnFitPage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAdjustGamma = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRotateLeft = New System.Windows.Forms.ToolStripButton()
        Me.btnRotateRight = New System.Windows.Forms.ToolStripButton()
        Me.btnFlipX = New System.Windows.Forms.ToolStripButton()
        Me.btnFlipY = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAbout = New System.Windows.Forms.ToolStripButton()
        Me.pMain = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.tcLeftPanel.SuspendLayout()
        Me.tpThumbnails.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.thumbnailPanelToolstrip.SuspendLayout()
        Me.tpBookmarks.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tpSearch.SuspendLayout()
        Me.pSearch.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pSnapInButtons.SuspendLayout()
        Me.pGamma.SuspendLayout()
        CType(Me.tbGamma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusbar.SuspendLayout()
        Me.mainToolStrip.SuspendLayout()
        Me.pMain.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcLeftPanel
        '
        Me.tcLeftPanel.Controls.Add(Me.tpThumbnails)
        Me.tcLeftPanel.Controls.Add(Me.tpBookmarks)
        Me.tcLeftPanel.Controls.Add(Me.tpSearch)
        Me.tcLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcLeftPanel.Location = New System.Drawing.Point(0, 32)
        Me.tcLeftPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.tcLeftPanel.Multiline = True
        Me.tcLeftPanel.Name = "tcLeftPanel"
        Me.tcLeftPanel.Padding = New System.Drawing.Point(0, 0)
        Me.tcLeftPanel.SelectedIndex = 0
        Me.tcLeftPanel.Size = New System.Drawing.Size(334, 642)
        Me.tcLeftPanel.TabIndex = 1
        '
        'tpThumbnails
        '
        Me.tpThumbnails.BackColor = System.Drawing.SystemColors.Control
        Me.tpThumbnails.Controls.Add(Me.ToolStripContainer1)
        Me.tpThumbnails.Location = New System.Drawing.Point(4, 22)
        Me.tpThumbnails.Name = "tpThumbnails"
        Me.tpThumbnails.Size = New System.Drawing.Size(326, 616)
        Me.tpThumbnails.TabIndex = 0
        Me.tpThumbnails.Text = "Thumbnails"
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Panel10)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Panel8)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(326, 591)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(326, 616)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'thumbnailPanelToolstrip
        '
        Me.thumbnailPanelToolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.thumbnailPanelToolstrip.Dock = System.Windows.Forms.DockStyle.None
        Me.thumbnailPanelToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.thumbnailPanelToolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnThumbSize, Me.btnDeleteCurrentPage})
        Me.thumbnailPanelToolstrip.Location = New System.Drawing.Point(0, 0)
        Me.thumbnailPanelToolstrip.Name = "thumbnailPanelToolstrip"
        Me.thumbnailPanelToolstrip.Padding = New System.Windows.Forms.Padding(0)
        Me.thumbnailPanelToolstrip.Size = New System.Drawing.Size(326, 25)
        Me.thumbnailPanelToolstrip.Stretch = True
        Me.thumbnailPanelToolstrip.TabIndex = 0
        '
        'btnThumbSize
        '
        Me.btnThumbSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnThumbSize.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LargeThumbnailsToolStripMenuItem1, Me.MediumThumbnailsToolStripMenuItem1, Me.SmallThumbnailsToolStripMenuItem1})
        Me.btnThumbSize.Image = CType(resources.GetObject("btnThumbSize.Image"), System.Drawing.Image)
        Me.btnThumbSize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnThumbSize.Name = "btnThumbSize"
        Me.btnThumbSize.Size = New System.Drawing.Size(29, 22)
        Me.btnThumbSize.Text = "btnThumbnailSize"
        Me.btnThumbSize.ToolTipText = "Thumbnail size"
        '
        'LargeThumbnailsToolStripMenuItem1
        '
        Me.LargeThumbnailsToolStripMenuItem1.Checked = True
        Me.LargeThumbnailsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LargeThumbnailsToolStripMenuItem1.Name = "LargeThumbnailsToolStripMenuItem1"
        Me.LargeThumbnailsToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.LargeThumbnailsToolStripMenuItem1.Text = "Large thumbnails"
        '
        'MediumThumbnailsToolStripMenuItem1
        '
        Me.MediumThumbnailsToolStripMenuItem1.Name = "MediumThumbnailsToolStripMenuItem1"
        Me.MediumThumbnailsToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.MediumThumbnailsToolStripMenuItem1.Text = "Medium thumbnails"
        '
        'SmallThumbnailsToolStripMenuItem1
        '
        Me.SmallThumbnailsToolStripMenuItem1.Name = "SmallThumbnailsToolStripMenuItem1"
        Me.SmallThumbnailsToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.SmallThumbnailsToolStripMenuItem1.Text = "Small thumbnails"
        '
        'btnDeleteCurrentPage
        '
        Me.btnDeleteCurrentPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeleteCurrentPage.Image = CType(resources.GetObject("btnDeleteCurrentPage.Image"), System.Drawing.Image)
        Me.btnDeleteCurrentPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteCurrentPage.Name = "btnDeleteCurrentPage"
        Me.btnDeleteCurrentPage.Size = New System.Drawing.Size(23, 22)
        Me.btnDeleteCurrentPage.Text = "Delete current page"
        '
        'ThumbnailEx1
        '
        Me.ThumbnailEx1.AllowDropFiles = False
        Me.ThumbnailEx1.AllowMoveItems = True
        Me.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control
        Me.ThumbnailEx1.CheckBoxes = False
        Me.ThumbnailEx1.CheckBoxesMarginLeft = 0
        Me.ThumbnailEx1.CheckBoxesMarginTop = 0
        Me.ThumbnailEx1.DisplayAnnotations = True
        Me.ThumbnailEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThumbnailEx1.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        Me.ThumbnailEx1.HotTracking = False
        Me.ThumbnailEx1.Location = New System.Drawing.Point(0, 0)
        Me.ThumbnailEx1.LockGdViewerEvents = False
        Me.ThumbnailEx1.MultiSelect = True
        Me.ThumbnailEx1.Name = "ThumbnailEx1"
        Me.ThumbnailEx1.OwnDrop = False
        Me.ThumbnailEx1.PauseThumbsLoading = False
        Me.ThumbnailEx1.PdfIncreaseTextContrast = False
        Me.ThumbnailEx1.PreloadAllItems = False
        Me.ThumbnailEx1.RotateExif = True
        Me.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThumbnailEx1.ShowText = True
        Me.ThumbnailEx1.Size = New System.Drawing.Size(326, 524)
        Me.ThumbnailEx1.TabIndex = 0
        Me.ThumbnailEx1.TextMarginLeft = 0
        Me.ThumbnailEx1.TextMarginTop = 0
        Me.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical
        Me.ThumbnailEx1.ThumbnailBorder = True
        Me.ThumbnailEx1.ThumbnailSize = New System.Drawing.Size(256, 256)
        Me.ThumbnailEx1.ThumbnailSpacing = New System.Drawing.Size(0, 0)
        Me.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter
        '
        'tpBookmarks
        '
        Me.tpBookmarks.BackColor = System.Drawing.SystemColors.Control
        Me.tpBookmarks.Controls.Add(Me.Panel5)
        Me.tpBookmarks.Location = New System.Drawing.Point(4, 22)
        Me.tpBookmarks.Name = "tpBookmarks"
        Me.tpBookmarks.Size = New System.Drawing.Size(326, 616)
        Me.tpBookmarks.TabIndex = 1
        Me.tpBookmarks.Text = "Bookmarks"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BookmarksTree1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(326, 616)
        Me.Panel5.TabIndex = 1
        '
        'BookmarksTree1
        '
        Me.BookmarksTree1.BackColor = System.Drawing.SystemColors.Control
        Me.BookmarksTree1.DisableZoomDestination = False
        Me.BookmarksTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookmarksTree1.FontName = "Helvetica"
        Me.BookmarksTree1.FontSize = 10.0!
        Me.BookmarksTree1.GdViewer = Nothing
        Me.BookmarksTree1.ItemHeight = 20
        Me.BookmarksTree1.Location = New System.Drawing.Point(0, 0)
        Me.BookmarksTree1.Name = "BookmarksTree1"
        Me.BookmarksTree1.Padding = New System.Windows.Forms.Padding(10)
        Me.BookmarksTree1.Size = New System.Drawing.Size(326, 616)
        Me.BookmarksTree1.TabIndex = 0
        '
        'tpSearch
        '
        Me.tpSearch.BackColor = System.Drawing.SystemColors.Control
        Me.tpSearch.Controls.Add(Me.pSearch)
        Me.tpSearch.Location = New System.Drawing.Point(4, 22)
        Me.tpSearch.Name = "tpSearch"
        Me.tpSearch.Size = New System.Drawing.Size(326, 616)
        Me.tpSearch.TabIndex = 2
        Me.tpSearch.Text = "Search"
        '
        'pSearch
        '
        Me.pSearch.BackColor = System.Drawing.SystemColors.Control
        Me.pSearch.Controls.Add(Me.Panel4)
        Me.pSearch.Controls.Add(Me.Panel3)
        Me.pSearch.Controls.Add(Me.Panel2)
        Me.pSearch.Controls.Add(Me.Panel1)
        Me.pSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pSearch.Location = New System.Drawing.Point(0, 0)
        Me.pSearch.Name = "pSearch"
        Me.pSearch.Padding = New System.Windows.Forms.Padding(10)
        Me.pSearch.Size = New System.Drawing.Size(326, 616)
        Me.pSearch.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lstSearchResults)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(10, 283)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(306, 323)
        Me.Panel4.TabIndex = 17
        '
        'lstSearchResults
        '
        Me.lstSearchResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstSearchResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSearchResults.FullRowSelect = True
        Me.lstSearchResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstSearchResults.Location = New System.Drawing.Point(0, 0)
        Me.lstSearchResults.MultiSelect = False
        Me.lstSearchResults.Name = "lstSearchResults"
        Me.lstSearchResults.Size = New System.Drawing.Size(306, 323)
        Me.lstSearchResults.TabIndex = 10
        Me.lstSearchResults.UseCompatibleStateImageBehavior = False
        Me.lstSearchResults.View = System.Windows.Forms.View.Tile
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.searchProgressBar)
        Me.Panel3.Controls.Add(Me.lblSearchResults)
        Me.Panel3.Controls.Add(Me.chkWholeWord)
        Me.Panel3.Controls.Add(Me.chkCaseSensitive)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.btnFindPrevious)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.btnFindNext)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(10, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(306, 220)
        Me.Panel3.TabIndex = 16
        '
        'searchProgressBar
        '
        Me.searchProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.searchProgressBar.Location = New System.Drawing.Point(0, 210)
        Me.searchProgressBar.Minimum = 1
        Me.searchProgressBar.Name = "searchProgressBar"
        Me.searchProgressBar.Size = New System.Drawing.Size(306, 10)
        Me.searchProgressBar.TabIndex = 15
        Me.searchProgressBar.Value = 1
        Me.searchProgressBar.Visible = False
        '
        'lblSearchResults
        '
        Me.lblSearchResults.AutoSize = True
        Me.lblSearchResults.Location = New System.Drawing.Point(6, 191)
        Me.lblSearchResults.Name = "lblSearchResults"
        Me.lblSearchResults.Size = New System.Drawing.Size(78, 13)
        Me.lblSearchResults.TabIndex = 14
        Me.lblSearchResults.Text = "Find result from"
        '
        'chkWholeWord
        '
        Me.chkWholeWord.AutoSize = True
        Me.chkWholeWord.Location = New System.Drawing.Point(3, 3)
        Me.chkWholeWord.Name = "chkWholeWord"
        Me.chkWholeWord.Size = New System.Drawing.Size(113, 17)
        Me.chkWholeWord.TabIndex = 1
        Me.chkWholeWord.Text = "Match whole word"
        Me.chkWholeWord.UseVisualStyleBackColor = True
        '
        'chkCaseSensitive
        '
        Me.chkCaseSensitive.AutoSize = True
        Me.chkCaseSensitive.Location = New System.Drawing.Point(3, 26)
        Me.chkCaseSensitive.Name = "chkCaseSensitive"
        Me.chkCaseSensitive.Size = New System.Drawing.Size(82, 17)
        Me.chkCaseSensitive.TabIndex = 2
        Me.chkCaseSensitive.Text = "Match case"
        Me.chkCaseSensitive.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCurrentPage)
        Me.GroupBox2.Controls.Add(Me.rbAllPages)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 70)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search in"
        '
        'rbCurrentPage
        '
        Me.rbCurrentPage.AutoSize = True
        Me.rbCurrentPage.Location = New System.Drawing.Point(6, 19)
        Me.rbCurrentPage.Name = "rbCurrentPage"
        Me.rbCurrentPage.Size = New System.Drawing.Size(85, 17)
        Me.rbCurrentPage.TabIndex = 3
        Me.rbCurrentPage.TabStop = True
        Me.rbCurrentPage.Text = "current page"
        Me.rbCurrentPage.UseVisualStyleBackColor = True
        '
        'rbAllPages
        '
        Me.rbAllPages.AutoSize = True
        Me.rbAllPages.Location = New System.Drawing.Point(6, 42)
        Me.rbAllPages.Name = "rbAllPages"
        Me.rbAllPages.Size = New System.Drawing.Size(67, 17)
        Me.rbAllPages.TabIndex = 4
        Me.rbAllPages.TabStop = True
        Me.rbAllPages.Text = "all pages"
        Me.rbAllPages.UseVisualStyleBackColor = True
        '
        'btnFindPrevious
        '
        Me.btnFindPrevious.Location = New System.Drawing.Point(3, 125)
        Me.btnFindPrevious.Name = "btnFindPrevious"
        Me.btnFindPrevious.Size = New System.Drawing.Size(91, 23)
        Me.btnFindPrevious.TabIndex = 13
        Me.btnFindPrevious.Text = "Find previous"
        Me.btnFindPrevious.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(3, 154)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search All"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnFindNext
        '
        Me.btnFindNext.Location = New System.Drawing.Point(100, 125)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(91, 23)
        Me.btnFindNext.TabIndex = 12
        Me.btnFindNext.Text = "Find next"
        Me.btnFindNext.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(306, 27)
        Me.Panel2.TabIndex = 15
        '
        'tbSearch
        '
        Me.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSearch.Location = New System.Drawing.Point(0, 0)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(306, 20)
        Me.tbSearch.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblSearchFor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 26)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lblSearchFor
        '
        Me.lblSearchFor.AutoSize = True
        Me.lblSearchFor.Location = New System.Drawing.Point(29, 7)
        Me.lblSearchFor.Name = "lblSearchFor"
        Me.lblSearchFor.Size = New System.Drawing.Size(56, 13)
        Me.lblSearchFor.TabIndex = 8
        Me.lblSearchFor.Text = "Search for"
        '
        'scMain
        '
        Me.scMain.BackColor = System.Drawing.SystemColors.Control
        Me.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scMain.Location = New System.Drawing.Point(0, 0)
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
        Me.scMain.Panel2.Controls.Add(Me.pGamma)
        Me.scMain.Panel2.Controls.Add(Me.GdViewer1)
        Me.scMain.Panel2MinSize = 200
        Me.scMain.Size = New System.Drawing.Size(1264, 676)
        Me.scMain.SplitterDistance = 368
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
        Me.Panel6.Size = New System.Drawing.Size(366, 674)
        Me.Panel6.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Controls.Add(Me.tcLeftPanel)
        Me.Panel9.Controls.Add(Me.Panel7)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(32, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(334, 674)
        Me.Panel9.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.lblSnapInPanel)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(334, 32)
        Me.Panel7.TabIndex = 6
        '
        'lblSnapInPanel
        '
        Me.lblSnapInPanel.AutoSize = True
        Me.lblSnapInPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnapInPanel.Location = New System.Drawing.Point(6, 8)
        Me.lblSnapInPanel.Name = "lblSnapInPanel"
        Me.lblSnapInPanel.Size = New System.Drawing.Size(82, 15)
        Me.lblSnapInPanel.TabIndex = 0
        Me.lblSnapInPanel.Text = "Thumbnails"
        '
        'pSnapInButtons
        '
        Me.pSnapInButtons.AutoSize = True
        Me.pSnapInButtons.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInThumbnails)
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInBookmarks)
        Me.pSnapInButtons.Controls.Add(Me.btnSnapInSearch)
        Me.pSnapInButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.pSnapInButtons.Location = New System.Drawing.Point(0, 0)
        Me.pSnapInButtons.Name = "pSnapInButtons"
        Me.pSnapInButtons.Size = New System.Drawing.Size(32, 674)
        Me.pSnapInButtons.TabIndex = 4
        '
        'btnSnapInThumbnails
        '
        Me.btnSnapInThumbnails.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInThumbnails.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSnapInThumbnails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInThumbnails.Image = CType(resources.GetObject("btnSnapInThumbnails.Image"), System.Drawing.Image)
        Me.btnSnapInThumbnails.Location = New System.Drawing.Point(0, 0)
        Me.btnSnapInThumbnails.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInThumbnails.Name = "btnSnapInThumbnails"
        Me.btnSnapInThumbnails.Size = New System.Drawing.Size(32, 32)
        Me.btnSnapInThumbnails.TabIndex = 0
        Me.btnSnapInThumbnails.UseVisualStyleBackColor = False
        '
        'btnSnapInBookmarks
        '
        Me.btnSnapInBookmarks.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInBookmarks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.btnSnapInBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInBookmarks.Image = CType(resources.GetObject("btnSnapInBookmarks.Image"), System.Drawing.Image)
        Me.btnSnapInBookmarks.Location = New System.Drawing.Point(0, 31)
        Me.btnSnapInBookmarks.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInBookmarks.Name = "btnSnapInBookmarks"
        Me.btnSnapInBookmarks.Size = New System.Drawing.Size(32, 32)
        Me.btnSnapInBookmarks.TabIndex = 1
        Me.btnSnapInBookmarks.UseVisualStyleBackColor = False
        '
        'btnSnapInSearch
        '
        Me.btnSnapInSearch.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSnapInSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.btnSnapInSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnapInSearch.Image = CType(resources.GetObject("btnSnapInSearch.Image"), System.Drawing.Image)
        Me.btnSnapInSearch.Location = New System.Drawing.Point(0, 62)
        Me.btnSnapInSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSnapInSearch.Name = "btnSnapInSearch"
        Me.btnSnapInSearch.Size = New System.Drawing.Size(32, 32)
        Me.btnSnapInSearch.TabIndex = 2
        Me.btnSnapInSearch.UseVisualStyleBackColor = False
        '
        'pGamma
        '
        Me.pGamma.AutoSize = True
        Me.pGamma.BackColor = System.Drawing.SystemColors.Control
        Me.pGamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pGamma.Controls.Add(Me.lblGamma)
        Me.pGamma.Controls.Add(Me.tbGamma)
        Me.pGamma.Location = New System.Drawing.Point(3, 3)
        Me.pGamma.Name = "pGamma"
        Me.pGamma.Size = New System.Drawing.Size(317, 62)
        Me.pGamma.TabIndex = 1
        '
        'lblGamma
        '
        Me.lblGamma.AutoSize = True
        Me.lblGamma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblGamma.Location = New System.Drawing.Point(3, 42)
        Me.lblGamma.Name = "lblGamma"
        Me.lblGamma.Size = New System.Drawing.Size(76, 13)
        Me.lblGamma.TabIndex = 1
        Me.lblGamma.Text = "Current value: "
        '
        'tbGamma
        '
        Me.tbGamma.Location = New System.Drawing.Point(3, 0)
        Me.tbGamma.Maximum = 50
        Me.tbGamma.Minimum = 1
        Me.tbGamma.Name = "tbGamma"
        Me.tbGamma.Size = New System.Drawing.Size(309, 45)
        Me.tbGamma.TabIndex = 0
        Me.tbGamma.Value = 1
        '
        'GdViewer1
        '
        Me.GdViewer1.AllowDropFile = False
        Me.GdViewer1.AnimateGIF = True
        Me.GdViewer1.AnnotationDropShadow = true
        Me.GdViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.GdViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.GdViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GdViewer1.BackgroundImage = Nothing
        Me.GdViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GdViewer1.ContinuousViewMode = True
        Me.GdViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdViewer1.DisplayQuality = GdPicture14.DisplayQuality.DisplayQualityBicubicHQ
        Me.GdViewer1.DisplayQualityAuto = True
        Me.GdViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GdViewer1.DocumentAlignment = GdPicture14.ViewerDocumentAlignment.DocumentAlignmentMiddleCenter
        Me.GdViewer1.DocumentPosition = GdPicture14.ViewerDocumentPosition.DocumentPositionMiddleCenter
        Me.GdViewer1.EnabledProgressBar = True
        Me.GdViewer1.EnableICM = False
        Me.GdViewer1.EnableMenu = True
        Me.GdViewer1.EnableMouseWheel = True
        Me.GdViewer1.EnableTextSelection = True
        Me.GdViewer1.ForceScrollBars = False
        Me.GdViewer1.ForeColor = System.Drawing.Color.Black
        Me.GdViewer1.Gamma = 1.0!
        Me.GdViewer1.HQAnnotationRendering = True
        Me.GdViewer1.IgnoreDocumentResolution = False
        Me.GdViewer1.KeepDocumentPosition = False
        Me.GdViewer1.Location = New System.Drawing.Point(0, 0)
        Me.GdViewer1.LockViewer = False
        Me.GdViewer1.MagnifierHeight = 90
        Me.GdViewer1.MagnifierWidth = 160
        Me.GdViewer1.MagnifierZoomX = 2.0!
        Me.GdViewer1.MagnifierZoomY = 2.0!
        Me.GdViewer1.MouseButtonForMouseMode = GdPicture14.MouseButton.MouseButtonLeft
        Me.GdViewer1.MouseMode = GdPicture14.ViewerMouseMode.MouseModePan
        Me.GdViewer1.MouseWheelMode = GdPicture14.ViewerMouseWheelMode.MouseWheelModeZoom
        Me.GdViewer1.Name = "GdViewer1"
        Me.GdViewer1.PdfDisplayFormField = True
        Me.GdViewer1.PdfEnableFileLinks = True
        Me.GdViewer1.PdfEnableLinks = True
        Me.GdViewer1.PdfIncreaseTextContrast = False
        Me.GdViewer1.PdfShowDialogForPassword = True
        Me.GdViewer1.PdfShowOpenFileDialogForDecryption = True
        Me.GdViewer1.PdfVerifyDigitalCertificates = False
        Me.GdViewer1.RectBorderColor = System.Drawing.Color.Black
        Me.GdViewer1.RectBorderSize = 1
        Me.GdViewer1.RectIsEditable = True
        Me.GdViewer1.RegionsAreEditable = True
        Me.GdViewer1.ScrollBars = True
        Me.GdViewer1.ScrollLargeChange = CType(50, Short)
        Me.GdViewer1.ScrollSmallChange = CType(1, Short)
        Me.GdViewer1.SilentMode = True
        Me.GdViewer1.Size = New System.Drawing.Size(890, 674)
        Me.GdViewer1.TabIndex = 0
        Me.GdViewer1.ViewRotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.GdViewer1.Zoom = 0.001R
        Me.GdViewer1.ZoomCenterAtMousePosition = False
        Me.GdViewer1.ZoomMode = GdPicture14.ViewerZoomMode.ZoomModeFitToViewer
        Me.GdViewer1.ZoomStep = 25
        '
        'statusbar
        '
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.statusbar.Location = New System.Drawing.Point(0, 707)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(1264, 22)
        Me.statusbar.TabIndex = 3
        Me.statusbar.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'mainToolStrip
        '
        Me.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.ToolStripSeparator9, Me.btnClose, Me.btnPrint, Me.btnSave, Me.ToolStripSeparator3, Me.btnSettings, Me.ToolStripSeparator8, Me.btnMouseMode, Me.ToolStripSeparator6, Me.btnFirstPage, Me.btnPreviousPage, Me.tbCurrentPage, Me.lblPageCount, Me.btnNextPage, Me.btnLastPage, Me.ToolStripSeparator1, Me.btnZoomOut, Me.cbZoom, Me.btnZoomIn, Me.ToolStripSeparator2, Me.btnFitWidth, Me.btnFitPage, Me.ToolStripSeparator5, Me.btnAdjustGamma, Me.ToolStripSeparator10, Me.btnRotateLeft, Me.btnRotateRight, Me.btnFlipX, Me.btnFlipY, Me.ToolStripSeparator4, Me.btnAbout})
        Me.mainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainToolStrip.Name = "mainToolStrip"
        Me.mainToolStrip.Size = New System.Drawing.Size(1264, 31)
        Me.mainToolStrip.TabIndex = 5
        Me.mainToolStrip.Text = "ToolStrip1"
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(130, 28)
        Me.btnOpen.Text = "Open document"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Margin = New System.Windows.Forms.Padding(5, 0, 10, 0)
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 31)
        '
        'btnClose
        '
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 28)
        Me.btnClose.Text = "Close document"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(28, 28)
        Me.btnPrint.Text = "Print document"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'btnSettings
        '
        Me.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(28, 28)
        Me.btnSettings.Text = "Viewer settings"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'btnMouseMode
        '
        Me.btnMouseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMouseMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.AreaSelectionToolStripMenuItem, Me.PanToolStripMenuItem, Me.AreaZoomingToolStripMenuItem, Me.MagnifierToolStripMenuItem})
        Me.btnMouseMode.Image = CType(resources.GetObject("btnMouseMode.Image"), System.Drawing.Image)
        Me.btnMouseMode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMouseMode.Name = "btnMouseMode"
        Me.btnMouseMode.Size = New System.Drawing.Size(37, 28)
        Me.btnMouseMode.Text = "Mouse mode"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.CheckOnClick = True
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'AreaSelectionToolStripMenuItem
        '
        Me.AreaSelectionToolStripMenuItem.CheckOnClick = True
        Me.AreaSelectionToolStripMenuItem.Name = "AreaSelectionToolStripMenuItem"
        Me.AreaSelectionToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AreaSelectionToolStripMenuItem.Text = "Area selection"
        '
        'PanToolStripMenuItem
        '
        Me.PanToolStripMenuItem.Checked = True
        Me.PanToolStripMenuItem.CheckOnClick = True
        Me.PanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PanToolStripMenuItem.Name = "PanToolStripMenuItem"
        Me.PanToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PanToolStripMenuItem.Text = "Pan"
        '
        'AreaZoomingToolStripMenuItem
        '
        Me.AreaZoomingToolStripMenuItem.CheckOnClick = True
        Me.AreaZoomingToolStripMenuItem.Name = "AreaZoomingToolStripMenuItem"
        Me.AreaZoomingToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AreaZoomingToolStripMenuItem.Text = "Area zooming"
        '
        'MagnifierToolStripMenuItem
        '
        Me.MagnifierToolStripMenuItem.CheckOnClick = True
        Me.MagnifierToolStripMenuItem.Name = "MagnifierToolStripMenuItem"
        Me.MagnifierToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.MagnifierToolStripMenuItem.Text = "Magnifier"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Margin = New System.Windows.Forms.Padding(5, 0, 10, 0)
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'btnFirstPage
        '
        Me.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFirstPage.Image = CType(resources.GetObject("btnFirstPage.Image"), System.Drawing.Image)
        Me.btnFirstPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(28, 28)
        Me.btnFirstPage.Text = "Go to first page"
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPreviousPage.Image = CType(resources.GetObject("btnPreviousPage.Image"), System.Drawing.Image)
        Me.btnPreviousPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(28, 28)
        Me.btnPreviousPage.Text = "Go to previous page"
        '
        'tbCurrentPage
        '
        Me.tbCurrentPage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCurrentPage.Name = "tbCurrentPage"
        Me.tbCurrentPage.Size = New System.Drawing.Size(40, 31)
        Me.tbCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPageCount
        '
        Me.lblPageCount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageCount.Name = "lblPageCount"
        Me.lblPageCount.Size = New System.Drawing.Size(25, 28)
        Me.lblPageCount.Text = "/ X"
        '
        'btnNextPage
        '
        Me.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNextPage.Image = CType(resources.GetObject("btnNextPage.Image"), System.Drawing.Image)
        Me.btnNextPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(28, 28)
        Me.btnNextPage.Text = "Go to next page"
        '
        'btnLastPage
        '
        Me.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLastPage.Image = CType(resources.GetObject("btnLastPage.Image"), System.Drawing.Image)
        Me.btnLastPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(28, 28)
        Me.btnLastPage.Text = "Go to last page"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'btnZoomOut
        '
        Me.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomOut.Image = CType(resources.GetObject("btnZoomOut.Image"), System.Drawing.Image)
        Me.btnZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(28, 28)
        Me.btnZoomOut.Text = "Zoom out"
        '
        'cbZoom
        '
        Me.cbZoom.DropDownWidth = 200
        Me.cbZoom.Name = "cbZoom"
        Me.cbZoom.Size = New System.Drawing.Size(75, 31)
        '
        'btnZoomIn
        '
        Me.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomIn.Image = CType(resources.GetObject("btnZoomIn.Image"), System.Drawing.Image)
        Me.btnZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(28, 28)
        Me.btnZoomIn.Text = "Zoom In"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'btnFitWidth
        '
        Me.btnFitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFitWidth.Image = CType(resources.GetObject("btnFitWidth.Image"), System.Drawing.Image)
        Me.btnFitWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFitWidth.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFitWidth.Name = "btnFitWidth"
        Me.btnFitWidth.Size = New System.Drawing.Size(28, 28)
        Me.btnFitWidth.Text = "Adjust to page width"
        '
        'btnFitPage
        '
        Me.btnFitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFitPage.Image = CType(resources.GetObject("btnFitPage.Image"), System.Drawing.Image)
        Me.btnFitPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFitPage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFitPage.Name = "btnFitPage"
        Me.btnFitPage.Size = New System.Drawing.Size(28, 28)
        Me.btnFitPage.Text = "Adjust to whole page"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'btnAdjustGamma
        '
        Me.btnAdjustGamma.CheckOnClick = True
        Me.btnAdjustGamma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdjustGamma.Image = CType(resources.GetObject("btnAdjustGamma.Image"), System.Drawing.Image)
        Me.btnAdjustGamma.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdjustGamma.Name = "btnAdjustGamma"
        Me.btnAdjustGamma.Size = New System.Drawing.Size(28, 28)
        Me.btnAdjustGamma.Text = "Adjust gamma"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 31)
        '
        'btnRotateLeft
        '
        Me.btnRotateLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRotateLeft.Image = CType(resources.GetObject("btnRotateLeft.Image"), System.Drawing.Image)
        Me.btnRotateLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRotateLeft.Name = "btnRotateLeft"
        Me.btnRotateLeft.Size = New System.Drawing.Size(28, 28)
        Me.btnRotateLeft.Text = "Rotate left"
        '
        'btnRotateRight
        '
        Me.btnRotateRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRotateRight.Image = CType(resources.GetObject("btnRotateRight.Image"), System.Drawing.Image)
        Me.btnRotateRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRotateRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRotateRight.Name = "btnRotateRight"
        Me.btnRotateRight.Size = New System.Drawing.Size(28, 28)
        Me.btnRotateRight.Text = "Rotate right"
        '
        'btnFlipX
        '
        Me.btnFlipX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFlipX.Image = CType(resources.GetObject("btnFlipX.Image"), System.Drawing.Image)
        Me.btnFlipX.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFlipX.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFlipX.Name = "btnFlipX"
        Me.btnFlipX.Size = New System.Drawing.Size(28, 28)
        Me.btnFlipX.Text = "Vertical flip"
        '
        'btnFlipY
        '
        Me.btnFlipY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFlipY.Image = CType(resources.GetObject("btnFlipY.Image"), System.Drawing.Image)
        Me.btnFlipY.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFlipY.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFlipY.Name = "btnFlipY"
        Me.btnFlipY.Size = New System.Drawing.Size(28, 28)
        Me.btnFlipY.Text = "Horizontal flip"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'btnAbout
        '
        Me.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(28, 28)
        Me.btnAbout.Text = "About"
        '
        'pMain
        '
        Me.pMain.Controls.Add(Me.scMain)
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(0, 31)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(1264, 676)
        Me.pMain.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(326, 67)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tip: you can move pages in the current document by dragging items below"
        '
        'Panel8
        '
        Me.Panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(326, 67)
        Me.Panel8.TabIndex = 2
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.ThumbnailEx1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 67)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(326, 524)
        Me.Panel10.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(28, 28)
        Me.btnSave.Text = "Save document"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.pMain)
        Me.Controls.Add(Me.mainToolStrip)
        Me.Controls.Add(Me.statusbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GdPicture .NET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tcLeftPanel.ResumeLayout(False)
        Me.tpThumbnails.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.thumbnailPanelToolstrip.ResumeLayout(False)
        Me.thumbnailPanelToolstrip.PerformLayout()
        Me.tpBookmarks.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.tpSearch.ResumeLayout(False)
        Me.pSearch.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        Me.scMain.Panel2.PerformLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.pSnapInButtons.ResumeLayout(False)
        Me.pGamma.ResumeLayout(False)
        Me.pGamma.PerformLayout()
        CType(Me.tbGamma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.mainToolStrip.ResumeLayout(False)
        Me.mainToolStrip.PerformLayout()
        Me.pMain.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ThumbnailEx1 As GdPicture14.ThumbnailEx
    Friend WithEvents tcLeftPanel As System.Windows.Forms.TabControl
    Friend WithEvents tpThumbnails As System.Windows.Forms.TabPage
    Friend WithEvents tpBookmarks As System.Windows.Forms.TabPage
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents GdViewer1 As GdPicture14.GdViewer
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
    Friend WithEvents mainToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents pMain As System.Windows.Forms.Panel
    Friend WithEvents BookmarksTree1 As GdPicture14.BookmarksTree
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tpSearch As System.Windows.Forms.TabPage
    Friend WithEvents pSearch As System.Windows.Forms.Panel
    Friend WithEvents rbAllPages As System.Windows.Forms.RadioButton
    Friend WithEvents rbCurrentPage As System.Windows.Forms.RadioButton
    Friend WithEvents chkCaseSensitive As System.Windows.Forms.CheckBox
    Friend WithEvents chkWholeWord As System.Windows.Forms.CheckBox
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearchFor As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFirstPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPreviousPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbCurrentPage As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblPageCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnNextPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLastPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnZoomOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbZoom As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnZoomIn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRotateLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRotateRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFlipX As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFlipY As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstSearchResults As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFindPrevious As System.Windows.Forms.Button
    Friend WithEvents btnFindNext As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSearchResults As System.Windows.Forms.Label
    Friend WithEvents searchProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFitWidth As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFitPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents thumbnailPanelToolstrip As System.Windows.Forms.ToolStrip
    Friend WithEvents pGamma As System.Windows.Forms.Panel
    Friend WithEvents tbGamma As System.Windows.Forms.TrackBar
    Friend WithEvents lblGamma As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnSnapInThumbnails As System.Windows.Forms.Button
    Friend WithEvents btnSnapInSearch As System.Windows.Forms.Button
    Friend WithEvents btnSnapInBookmarks As System.Windows.Forms.Button
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
    Friend WithEvents btnThumbSize As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LargeThumbnailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumThumbnailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallThumbnailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAdjustGamma As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleteCurrentPage As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton

End Class
