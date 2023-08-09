using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace pdfReducer
{
    partial class frmMain : System.Windows.Forms.Form
    {


        // Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
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


        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lbSrcFolder = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.lbDstFolder = new System.Windows.Forms.Label();
            this.txtDestFolder = new System.Windows.Forms.TextBox();
            this.cmdBrowseDest = new System.Windows.Forms.Button();
            this.lbThreads = new System.Windows.Forms.Label();
            this.cboMaxProcesses = new System.Windows.Forms.ComboBox();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.FldBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.TabProcessLogs = new System.Windows.Forms.TabPage();
            this.lstProcessLog = new System.Windows.Forms.ListBox();
            this.TabWarnings = new System.Windows.Forms.TabPage();
            this.lstWarnLog = new System.Windows.Forms.ListBox();
            this.TabStatus = new System.Windows.Forms.TabPage();
            this.lstThreads = new System.Windows.Forms.ListBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabErrors = new System.Windows.Forms.TabPage();
            this.lstErrLog = new System.Windows.Forms.ListBox();
            this.cmdRun = new System.Windows.Forms.Button();
            this.aboutMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCompRatio = new System.Windows.Forms.Label();
            this.lbCompRatioPct = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.fileSelectDlg = new System.Windows.Forms.OpenFileDialog();
            this.btPause = new System.Windows.Forms.Button();
            this.cmdBrowseFolders = new System.Windows.Forms.Button();
            this.cmdBrowseFiles = new System.Windows.Forms.Button();
            this.TabProcessLogs.SuspendLayout();
            this.TabWarnings.SuspendLayout();
            this.TabStatus.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabErrors.SuspendLayout();
            this.aboutMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSrcFolder
            // 
            this.lbSrcFolder.AutoSize = true;
            this.lbSrcFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSrcFolder.Location = new System.Drawing.Point(35, 34);
            this.lbSrcFolder.Name = "lbSrcFolder";
            this.lbSrcFolder.Size = new System.Drawing.Size(44, 13);
            this.lbSrcFolder.TabIndex = 0;
            this.lbSrcFolder.Text = "Source:";
            this.lbSrcFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(85, 34);
            this.txtSourcePath.MaxLength = 999999999;
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(356, 20);
            this.txtSourcePath.TabIndex = 1;
            this.txtSourcePath.WordWrap = false;
            // 
            // lbDstFolder
            // 
            this.lbDstFolder.AutoSize = true;
            this.lbDstFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDstFolder.Location = new System.Drawing.Point(16, 61);
            this.lbDstFolder.Name = "lbDstFolder";
            this.lbDstFolder.Size = new System.Drawing.Size(63, 13);
            this.lbDstFolder.TabIndex = 2;
            this.lbDstFolder.Text = "Destination:";
            this.lbDstFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDestFolder
            // 
            this.txtDestFolder.Location = new System.Drawing.Point(85, 61);
            this.txtDestFolder.Name = "txtDestFolder";
            this.txtDestFolder.Size = new System.Drawing.Size(356, 20);
            this.txtDestFolder.TabIndex = 3;
            // 
            // cmdBrowseDest
            // 
            this.cmdBrowseDest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdBrowseDest.Location = new System.Drawing.Point(445, 59);
            this.cmdBrowseDest.Name = "cmdBrowseDest";
            this.cmdBrowseDest.Size = new System.Drawing.Size(50, 24);
            this.cmdBrowseDest.TabIndex = 5;
            this.cmdBrowseDest.Text = "......";
            this.cmdBrowseDest.UseVisualStyleBackColor = true;
            this.cmdBrowseDest.Click += new System.EventHandler(this.cmdBrowseDest_Click);
            // 
            // lbThreads
            // 
            this.lbThreads.AutoSize = true;
            this.lbThreads.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbThreads.Location = new System.Drawing.Point(30, 89);
            this.lbThreads.Name = "lbThreads";
            this.lbThreads.Size = new System.Drawing.Size(49, 13);
            this.lbThreads.TabIndex = 7;
            this.lbThreads.Text = "Threads:";
            this.lbThreads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboMaxProcesses
            // 
            this.cboMaxProcesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaxProcesses.FormattingEnabled = true;
            this.cboMaxProcesses.Location = new System.Drawing.Point(85, 89);
            this.cboMaxProcesses.Name = "cboMaxProcesses";
            this.cboMaxProcesses.Size = new System.Drawing.Size(143, 21);
            this.cboMaxProcesses.TabIndex = 8;
            // 
            // prgProgress
            // 
            this.prgProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgProgress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prgProgress.Location = new System.Drawing.Point(3, 353);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(494, 20);
            this.prgProgress.TabIndex = 12;
            this.prgProgress.Visible = false;
            // 
            // FldBrowse
            // 
            this.FldBrowse.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // TabProcessLogs
            // 
            this.TabProcessLogs.Controls.Add(this.lstProcessLog);
            this.TabProcessLogs.Location = new System.Drawing.Point(4, 22);
            this.TabProcessLogs.Name = "TabProcessLogs";
            this.TabProcessLogs.Padding = new System.Windows.Forms.Padding(3);
            this.TabProcessLogs.Size = new System.Drawing.Size(488, 186);
            this.TabProcessLogs.TabIndex = 2;
            this.TabProcessLogs.Text = "Logs";
            this.TabProcessLogs.UseVisualStyleBackColor = true;
            // 
            // lstProcessLog
            // 
            this.lstProcessLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProcessLog.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.lstProcessLog.FormattingEnabled = true;
            this.lstProcessLog.IntegralHeight = false;
            this.lstProcessLog.ItemHeight = 14;
            this.lstProcessLog.Location = new System.Drawing.Point(3, 3);
            this.lstProcessLog.Name = "lstProcessLog";
            this.lstProcessLog.Size = new System.Drawing.Size(482, 180);
            this.lstProcessLog.TabIndex = 1;
            // 
            // TabWarnings
            // 
            this.TabWarnings.Controls.Add(this.lstWarnLog);
            this.TabWarnings.Location = new System.Drawing.Point(4, 22);
            this.TabWarnings.Name = "TabWarnings";
            this.TabWarnings.Padding = new System.Windows.Forms.Padding(3);
            this.TabWarnings.Size = new System.Drawing.Size(488, 186);
            this.TabWarnings.TabIndex = 1;
            this.TabWarnings.Text = "Warnings";
            this.TabWarnings.UseVisualStyleBackColor = true;
            // 
            // lstWarnLog
            // 
            this.lstWarnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWarnLog.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.lstWarnLog.FormattingEnabled = true;
            this.lstWarnLog.IntegralHeight = false;
            this.lstWarnLog.ItemHeight = 14;
            this.lstWarnLog.Location = new System.Drawing.Point(3, 3);
            this.lstWarnLog.Name = "lstWarnLog";
            this.lstWarnLog.Size = new System.Drawing.Size(482, 180);
            this.lstWarnLog.TabIndex = 0;
            // 
            // TabStatus
            // 
            this.TabStatus.Controls.Add(this.lstThreads);
            this.TabStatus.Location = new System.Drawing.Point(4, 22);
            this.TabStatus.Name = "TabStatus";
            this.TabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.TabStatus.Size = new System.Drawing.Size(488, 186);
            this.TabStatus.TabIndex = 0;
            this.TabStatus.Text = "Status";
            this.TabStatus.UseVisualStyleBackColor = true;
            // 
            // lstThreads
            // 
            this.lstThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstThreads.FormattingEnabled = true;
            this.lstThreads.IntegralHeight = false;
            this.lstThreads.Location = new System.Drawing.Point(3, 3);
            this.lstThreads.Name = "lstThreads";
            this.lstThreads.Size = new System.Drawing.Size(482, 180);
            this.lstThreads.TabIndex = 11;
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabStatus);
            this.TabControl1.Controls.Add(this.TabWarnings);
            this.TabControl1.Controls.Add(this.tabErrors);
            this.TabControl1.Controls.Add(this.TabProcessLogs);
            this.TabControl1.Location = new System.Drawing.Point(3, 140);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(496, 212);
            this.TabControl1.TabIndex = 13;
            // 
            // tabErrors
            // 
            this.tabErrors.Controls.Add(this.lstErrLog);
            this.tabErrors.Location = new System.Drawing.Point(4, 22);
            this.tabErrors.Name = "tabErrors";
            this.tabErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrors.Size = new System.Drawing.Size(488, 186);
            this.tabErrors.TabIndex = 3;
            this.tabErrors.Text = "Errors";
            this.tabErrors.UseVisualStyleBackColor = true;
            // 
            // lstErrLog
            // 
            this.lstErrLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstErrLog.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.lstErrLog.FormattingEnabled = true;
            this.lstErrLog.IntegralHeight = false;
            this.lstErrLog.ItemHeight = 14;
            this.lstErrLog.Location = new System.Drawing.Point(3, 3);
            this.lstErrLog.Name = "lstErrLog";
            this.lstErrLog.Size = new System.Drawing.Size(482, 180);
            this.lstErrLog.TabIndex = 1;
            // 
            // cmdRun
            // 
            this.cmdRun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdRun.Location = new System.Drawing.Point(232, 88);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(90, 23);
            this.cmdRun.TabIndex = 28;
            this.cmdRun.Text = "Start batch";
            this.cmdRun.UseVisualStyleBackColor = true;
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // aboutMenuStrip
            // 
            this.aboutMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.aboutMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.aboutMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.aboutMenuStrip.Name = "aboutMenuStrip";
            this.aboutMenuStrip.Size = new System.Drawing.Size(500, 24);
            this.aboutMenuStrip.TabIndex = 29;
            this.aboutMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.aboutToolStripMenuItem.Text = "?";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbCompRatio
            // 
            this.lbCompRatio.AutoSize = true;
            this.lbCompRatio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCompRatio.Location = new System.Drawing.Point(356, 94);
            this.lbCompRatio.Name = "lbCompRatio";
            this.lbCompRatio.Size = new System.Drawing.Size(73, 13);
            this.lbCompRatio.TabIndex = 30;
            this.lbCompRatio.Text = "Saved space:";
            // 
            // lbCompRatioPct
            // 
            this.lbCompRatioPct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbCompRatioPct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCompRatioPct.Location = new System.Drawing.Point(426, 88);
            this.lbCompRatioPct.Name = "lbCompRatioPct";
            this.lbCompRatioPct.Size = new System.Drawing.Size(74, 24);
            this.lbCompRatioPct.TabIndex = 31;
            this.lbCompRatioPct.Text = "99.99%";
            this.lbCompRatioPct.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbStatus.Location = new System.Drawing.Point(7, 356);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(23, 13);
            this.lbStatus.TabIndex = 32;
            this.lbStatus.Text = "idle";
            this.lbStatus.Visible = false;
            // 
            // fileSelectDlg
            // 
            this.fileSelectDlg.Filter = "PDF|*.pdf";
            this.fileSelectDlg.Multiselect = true;
            // 
            // btPause
            // 
            this.btPause.Font = new System.Drawing.Font("Arial", 12F);
            this.btPause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btPause.Location = new System.Drawing.Point(324, 88);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(26, 23);
            this.btPause.TabIndex = 34;
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // cmdBrowseFolders
            // 
            this.cmdBrowseFolders.BackgroundImage = global::pdfReducer.Properties.Resources.add_folder;
            this.cmdBrowseFolders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBrowseFolders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdBrowseFolders.Location = new System.Drawing.Point(471, 32);
            this.cmdBrowseFolders.Name = "cmdBrowseFolders";
            this.cmdBrowseFolders.Size = new System.Drawing.Size(24, 24);
            this.cmdBrowseFolders.TabIndex = 35;
            this.cmdBrowseFolders.UseVisualStyleBackColor = true;
            this.cmdBrowseFolders.Click += new System.EventHandler(this.cmdBrowseFolders_Click);
            // 
            // cmdBrowseFiles
            // 
            this.cmdBrowseFiles.BackgroundImage = global::pdfReducer.Properties.Resources.add_file;
            this.cmdBrowseFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBrowseFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdBrowseFiles.Location = new System.Drawing.Point(445, 32);
            this.cmdBrowseFiles.Name = "cmdBrowseFiles";
            this.cmdBrowseFiles.Size = new System.Drawing.Size(24, 24);
            this.cmdBrowseFiles.TabIndex = 4;
            this.cmdBrowseFiles.UseVisualStyleBackColor = true;
            this.cmdBrowseFiles.Click += new System.EventHandler(this.cmdBrowseFiles_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 377);
            this.Controls.Add(this.cmdBrowseFolders);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbCompRatioPct);
            this.Controls.Add(this.lbCompRatio);
            this.Controls.Add(this.aboutMenuStrip);
            this.Controls.Add(this.cmdRun);
            this.Controls.Add(this.lbThreads);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.cboMaxProcesses);
            this.Controls.Add(this.cmdBrowseDest);
            this.Controls.Add(this.cmdBrowseFiles);
            this.Controls.Add(this.txtDestFolder);
            this.Controls.Add(this.lbDstFolder);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.lbSrcFolder);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(516, 416);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " GdPicture.NET PDF Reducer SDK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.TabProcessLogs.ResumeLayout(false);
            this.TabWarnings.ResumeLayout(false);
            this.TabStatus.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.tabErrors.ResumeLayout(false);
            this.aboutMenuStrip.ResumeLayout(false);
            this.aboutMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.Label lbSrcFolder;
        internal System.Windows.Forms.TextBox txtSourcePath;
        internal System.Windows.Forms.Label lbDstFolder;
        internal System.Windows.Forms.TextBox txtDestFolder;
        internal System.Windows.Forms.Button cmdBrowseFiles;
        internal System.Windows.Forms.Button cmdBrowseDest;
        internal System.Windows.Forms.Label lbThreads;
        internal System.Windows.Forms.ComboBox cboMaxProcesses;
        internal System.Windows.Forms.ProgressBar prgProgress;
        internal System.Windows.Forms.FolderBrowserDialog FldBrowse;
        internal System.Windows.Forms.TabPage TabProcessLogs;
        internal System.Windows.Forms.ListBox lstProcessLog;
        internal System.Windows.Forms.TabPage TabWarnings;
        internal System.Windows.Forms.ListBox lstWarnLog;
        internal System.Windows.Forms.TabPage TabStatus;
        internal System.Windows.Forms.ListBox lstThreads;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.Button cmdRun;
        private MenuStrip aboutMenuStrip;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private Label lbCompRatio;
        private Label lbCompRatioPct;
        internal ListBox lstErrLog;
        private Label lbStatus;
        internal TabPage tabErrors;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem frenchToolStripMenuItem;
        private OpenFileDialog fileSelectDlg;
        private Button btPause;
        internal Button cmdBrowseFolders;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
