using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using pdfReducer.Utilities;
using GdPicture14;

namespace pdfReducer
{
    public partial class frmMain
    {
        #region Fields

        private readonly PDFReducerWorkerManager _workerManager = new PDFReducerWorkerManager();
        private int _fileCount;
        private bool _UILocked = false;
        private string _cmdRunText;
        private Stopwatch _stopWatch = new Stopwatch();
        #endregion //Fields

        #region Startup

        public frmMain()
        {
            new GdPicture14.LicenseManager().RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            try
            {
                this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            }
            catch
            {
                this.ShowIcon = false;
            }

            InitializeComponent();

            _updateThreadProgressLogsEventHandler = UpdateThreadProgressLogs;
            _updateThreadStatusLogsEventHandler = UpdateThreadStatusLogs;
            _warningEventHandler = UpdateWarningLogs;
            _errorsEventHandler = UpdateErrorsLogs;
            ratioUpdateEventHandler = UpdateReductionRatio;
            workCompletionEventHandler = CleanupThread;

            // Subscribe from workers events
            _workerManager.WorkerProgressEventHandler += OnWorkerThreadProgress;
            _workerManager.WarningEventHandler += OnWorkerThreadWarning;
            _workerManager.ErrorEventHandler += OnWorkerThreadError;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            UnlockUi();
            UpdateMainUI();

            LoadCustomConfig();
            txtSourcePath.Text = Globals.ApplicationConfiguration.InputPath;
            txtDestFolder.Text = Globals.ApplicationConfiguration.OutputPath;
            cboMaxProcesses.SelectedIndex = Globals.MaxThreads - 1;
        }

        #endregion //Startup

        #region UI update controller

        // Log update delegates
        private delegate void UpdateUITextDelegate(string text);
        private delegate void UpdateWorkerProgressDelegate(int threadNumber, string updatedCaption, int processedFilesCount);

        // Reduction ratio update delegate
        private delegate void RatioUpdateDelegate(double updatedRatio);

        // Work completion delegate
        private delegate void WorkCompletionDelegate(int threadNumber, PDFReducerStats stats);
        // Log updates event handlers
        private readonly UpdateWorkerProgressDelegate _updateThreadProgressLogsEventHandler;
        private readonly UpdateUITextDelegate _updateThreadStatusLogsEventHandler;
        private readonly UpdateUITextDelegate _warningEventHandler;
        private readonly UpdateUITextDelegate _errorsEventHandler;

        // Ratio update event handler
        private readonly RatioUpdateDelegate ratioUpdateEventHandler;

        // Work completion event handler
        private readonly WorkCompletionDelegate workCompletionEventHandler;



        private void OnWorkerThreadProgress(PDFReducerWorkerManager.WorkerProgressStatus progressStatus, int workerNumber, string fileName, PDFReducerStats stats)
        {
            if (progressStatus == PDFReducerWorkerManager.WorkerProgressStatus.WorkComplete)
            {
                if (InvokeRequired)
                {
                    Invoke(workCompletionEventHandler, workerNumber, stats);
                }
                else
                {
                    CleanupThread(workerNumber, stats);
                }
            }
            else if (progressStatus == PDFReducerWorkerManager.WorkerProgressStatus.ReductionRatioUpdate)
            {
                if (InvokeRequired)
                {
                    Invoke(ratioUpdateEventHandler, stats.ReductionRatio);
                }
                else
                {
                    UpdateReductionRatio(stats.ReductionRatio);
                }
            }
            else if (progressStatus == PDFReducerWorkerManager.WorkerProgressStatus.FileProcessingCompletion)
            {
                string logMessage = string.Format("Done - {0} ({1}% of input)", fileName, stats.ReductionRatio);

                if (InvokeRequired)
                {
                    Invoke(_updateThreadStatusLogsEventHandler, logMessage);
                }
                else
                {
                    UpdateThreadStatusLogs(logMessage);
                }
            }
            else
            {
                string threadCaption = string.Empty;

                switch (progressStatus)
                {
                    case PDFReducerWorkerManager.WorkerProgressStatus.Idle:
                        threadCaption = "Idle (no work)";
                        break;
                    case PDFReducerWorkerManager.WorkerProgressStatus.WorkStart:
                        threadCaption = "Starting...";
                        break;
                    case PDFReducerWorkerManager.WorkerProgressStatus.FileProcessingStart:
                        threadCaption = string.Format("Processing {0}", fileName);
                        break;
                    case PDFReducerWorkerManager.WorkerProgressStatus.FileProcessingCompletion:
                        threadCaption = string.Format("Done - {0} ({1}% of input)", fileName, stats.ReductionRatio);
                        break;
                    case PDFReducerWorkerManager.WorkerProgressStatus.Exit:
                        threadCaption = string.Format("Exiting...");
                        break;
                }

                if (InvokeRequired)
                {
                    Invoke(_updateThreadProgressLogsEventHandler, workerNumber, threadCaption, stats.ProcessedFilesCount);
                }
                else
                {
                    UpdateThreadProgressLogs(workerNumber, threadCaption, stats.ProcessedFilesCount);
                }
            }
        }


        private void OnWorkerThreadWarning(PDFReducerWarningStatus warningStatus, string fileName, int pageNumber, int pageImageNumber)
        {
            string warningMessage = string.Empty;

            switch (warningStatus)
            {
                case PDFReducerWarningStatus.BlankPageRemovalFailure:
                    warningMessage = string.Format("Could not remove blank page on page {0} of document: {1}", pageNumber, fileName);
                    break;

                case PDFReducerWarningStatus.ColorDetectionFailure:
                    warningMessage = string.Format("Can not detect color of image {0} on page {1} of document: {2}", pageImageNumber, pageNumber, fileName);
                    break;

                case PDFReducerWarningStatus.FileSizeReductionFailure:
                    warningMessage = string.Format("Can not reduce size of document: {0}", fileName);
                    break;
                case PDFReducerWarningStatus.ImageCropFailure:
                    warningMessage = string.Format("Can not crop image {0} on page {1} of document: {2}", pageImageNumber, pageNumber, fileName);
                    break;
                case PDFReducerWarningStatus.ImageExtractionFailure:
                    warningMessage = string.Format("Can not extract image {0} on page {1} of document: {2}", pageImageNumber, pageNumber, fileName);
                    break;
                case PDFReducerWarningStatus.ImageObtentionFailure:
                    warningMessage = string.Format("Can not obtain image {0} resource name on page {1} of document: {2}", pageImageNumber, pageNumber, fileName);
                    break;
                case PDFReducerWarningStatus.ImageReplacementFailure:
                    warningMessage = string.Format("Can not replace image {0} on page {1} of document: {2}", pageImageNumber, pageNumber, fileName);
                    break;
                case PDFReducerWarningStatus.ImageResizeFailure:
                    warningMessage = string.Format("Can not resize image {0} on page {1} of document: {2}", pageImageNumber, pageNumber, fileName);
                    break;
                case PDFReducerWarningStatus.ImageResolutionObtentionFailure:
                    warningMessage = string.Format("Can not obtain resolution of image {0} on page {1} of document: {2}", pageImageNumber, pageNumber, fileName);
                    break;
                case PDFReducerWarningStatus.MRCImageReplacementFailure:
                    warningMessage = string.Format("Can not replace image {0} on page #page_number of document: {1}", pageImageNumber, pageNumber, fileName);
                    break;
                case PDFReducerWarningStatus.OriginalFileDeletionFailure:
                    warningMessage = string.Format("Can not delete original file: {0}", fileName);
                    break;
                case PDFReducerWarningStatus.PageSelectionFailure:
                    warningMessage = string.Format("Can not select page #page_number of document: {0}", fileName);
                    break;
            }

            if (InvokeRequired)
            {
                Invoke(_warningEventHandler, warningMessage);
            }
            else
            {
                UpdateWarningLogs(warningMessage);
            }
        }


        private void OnWorkerThreadError(GdPictureStatus status, PDFReducerErrorStatus errorStatus, string fileName, int pageNumber)
        {
            string errorMessage = string.Empty;
            string statusMessage = status != GdPictureStatus.OK ? string.Format(" - Status: {0}", status.ToString()) : string.Empty;

            switch (errorStatus)
            {
                case PDFReducerErrorStatus.DirectoryCreationFailure:
                    errorMessage = string.Format("Can not create output directory for file {0}{1}", fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.DocumentEncrypted:
                    errorMessage = string.Format("Can not process encrypted document: {0}{1}", fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.FileCopyFailure:
                    errorMessage = string.Format("Can not copy file: {0}{1}", fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.FileOpeningFailure:
                    errorMessage = string.Format("Can not open file: {0}{1}", fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.FileOverwriteFailure:
                    errorMessage = string.Format("Can not overwrite file: document {0}{1}", fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.FileSaveFailure:
                    errorMessage = string.Format("Can not save file: {0}{1}", fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.GetPageImagesCount:
                    errorMessage = string.Format("Unable to compute the number of images of the page {0} of document {1}{2}", pageNumber, fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.MRCPostOperationsFailure:
                    errorMessage = string.Format("(MRC) Post operations failed on page {0} of document {1}{2}", pageNumber, fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.PageConversionFailure:
                    errorMessage = string.Format("Can not convert page {0} to PDF on document: {1}{2}", pageNumber, fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.UnexpectedError:
                    errorMessage = string.Format("An unexpected error occured with the file: {0}{1}", fileName, statusMessage);
                    break;
                case PDFReducerErrorStatus.OK:
                    errorMessage = string.Format("An unexpected error occured with the file: {0}{1}", fileName, statusMessage);
                    break;
            }

            if (InvokeRequired)
            {
                Invoke(_errorsEventHandler, errorMessage);
            }
            else
            {
                UpdateErrorsLogs(errorMessage);
            }
        }
        #endregion //UI update controller

        #region View update methods

        private void UpdateMainUI()
        {
            cboMaxProcesses.Items.Clear();

            for (int threadNumber = 1; threadNumber <= Globals.MaxThreads; threadNumber++)
            {
                cboMaxProcesses.Items.Add(string.Format("{0}  {1}", threadNumber, threadNumber == 1 ? "thread" : "threads"));
            }

            cboMaxProcesses.SelectedIndex = 0;
        }


        private void UpdateThreadProgressLogs(int threadNumber, string updatedCaption, int processedFilesCount)
        {
            for (int index = 0; index <= lstThreads.Items.Count - 1; index++)
            {
                ThreadItem item = (ThreadItem)lstThreads.Items[index];

                if (item.WorkerThreadNumber == threadNumber)
                {
                    item.Caption = string.Format("Thread {0}: {1}", threadNumber, updatedCaption);
                    lstThreads.Items[index] = item;
                    break;
                }
            }

            prgProgress.Value = processedFilesCount;
        }


        private void UpdateThreadStatusLogs(string text)
        {
            lstProcessLog.Items.Add(string.Format("{0:r} - {1}", DateTime.Now, text));
            TabProcessLogs.Text = string.Format("Logs ({0})", lstProcessLog.Items.Count);
        }


        private void UpdateWarningLogs(string text)
        {
            lstWarnLog.Items.Add(string.Format("{0:r} - {1}", DateTime.Now, text));
            TabWarnings.Text = string.Format("Warnings ({0})", lstWarnLog.Items.Count);
        }


        private void UpdateErrorsLogs(string text)
        {
            lstErrLog.Items.Add(string.Format("{0:r} - {1}", DateTime.Now, text));
            tabErrors.Text = string.Format("Errors ({0})", lstErrLog.Items.Count);
        }


        private void UpdateReductionRatio(double updatedRatio)
        {
            lbCompRatioPct.Text = Math.Round(updatedRatio, 2) + "%";
        }


        private void CleanupThread(int threadNumber, PDFReducerStats stats)
        {
            for (int i = lstThreads.Items.Count - 1; i >= 0; i += -1)
            {
                ThreadItem item = ((ThreadItem)(lstThreads.Items[i]));
                if (item.WorkerThreadNumber == threadNumber)
                {
                    lstThreads.Items.RemoveAt(i);
                    break;
                }
            }

            if (lstThreads.Items.Count == 0)
            {
                GdPictureDocumentUtilities.ForceGarbageCollection();

                TimeSpan ts = _stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                double percent = stats.InputFilesSize > 0 ? Math.Round(stats.OutputFileSize / stats.InputFilesSize * 100, 2) : 100;
                if (percent == 100 && stats.InputFilesSize > 0)
                {
                    percent = Math.Round(stats.OutputFileSize / stats.InputFilesSize * 100, 4);
                }

                double percentEx = Math.Round(100 - (stats.InputFilesSize > 0 ? stats.OutputFileSize / stats.InputFilesSize * 100 : 100), 2);

                prgProgress.Visible = false;

                lbStatus.Text = string.Format("{0} files processed. Saved space: {1}%", stats.ProcessedFilesCount, percentEx);
                lbStatus.Visible = true;


                string result = string.Format("{0} files processed in {1}. Input size: {2}MB. Output size: {3}MB. ({4}% of input size)", stats.ProcessedFilesCount,
                    elapsedTime, ParsingUtils.ConvertSize(stats.InputFilesSize, "MB"), ParsingUtils.ConvertSize(stats.OutputFileSize, "MB"), percent);

                MessageBox.Show(result, "Process completed", MessageBoxButtons.OK, MessageBoxIcon.Information);


                UnlockUi();
            }
        }


        #endregion //View update methods

        #region Application state update

        private void ResetApp()
        {
            _workerManager.Reset();

            lstThreads.Items.Clear();
            lstWarnLog.Items.Clear();
            lstErrLog.Items.Clear();
            lstProcessLog.Items.Clear();
            TabWarnings.Text = "Warnings";
            tabErrors.Text = "Errors";
            TabProcessLogs.Text = "Logs";
            _fileCount = 0;

            prgProgress.Visible = true;
            lbStatus.Visible = false;
        }


        public void LoadCustomConfig()
        {
            lbSrcFolder.Enabled = true;
            txtSourcePath.Enabled = true;
            cmdBrowseFiles.Enabled = true;
            cmdRun.Visible = true;
            AllowDrop = true;
        }


        private void LockUi()
        {
            _UILocked = true;
            cmdRun.Visible = true;
            _cmdRunText = cmdRun.Text;
            cmdRun.Text = "Stop";
            cmdBrowseDest.Enabled = false;
            cmdBrowseFiles.Enabled = false;
            cmdBrowseFolders.Enabled = false;
            txtSourcePath.ReadOnly = true;
            txtDestFolder.ReadOnly = true;
            cboMaxProcesses.Enabled = false;
            aboutMenuStrip.Enabled = false;
            lbCompRatioPct.Text = "0%";
            lbCompRatio.Visible = true;
            lbCompRatioPct.Visible = true;
            btPause.Visible = true;
            btPause.Text = "\u23F8"; // Unicode "pause" symbol
        }


        private void UnlockUi()
        {
            if (_cmdRunText != null) cmdRun.Text = _cmdRunText;
            _UILocked = false;
            aboutMenuStrip.Enabled = true;
            cboMaxProcesses.Enabled = true;
            cmdRun.Visible = true;
            cmdBrowseDest.Enabled = true;
            cmdBrowseFiles.Enabled = true;
            cmdBrowseFolders.Enabled = true;
            txtSourcePath.ReadOnly = false;
            txtDestFolder.ReadOnly = false;
            lbCompRatio.Visible = false;
            lbCompRatioPct.Visible = false;
            btPause.Visible = false;
        }

        #endregion //Application state update

        #region Reduce operations start

        private void Go(string[] data, bool inputIsFolder)
        {
            LockUi();

            if (!(Directory.Exists(txtDestFolder.Text)))
            {
                MessageBox.Show("Output folder does not exist", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                UnlockUi();
                return;
            }

            ResetApp();
            _stopWatch.Restart();
            List<FileToProcess> filesToProcess;

            try
            {
                filesToProcess = FileUtils.CollectFiles(data, inputIsFolder, Globals.ApplicationConfiguration.OnlyProcessPDF ?
                    new GdPicture14.DocumentFormat[] { GdPicture14.DocumentFormat.DocumentFormatPDF } : Globals.SupportedFormats);
                _fileCount = filesToProcess.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An exception occured while building a files list to process, the error was :{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UnlockUi();
                return;
            }

            prgProgress.Value = 0;
            prgProgress.Minimum = 0;
            prgProgress.Maximum = _fileCount;

            if (_fileCount == 0)
            {
                MessageBox.Show("No input file found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UnlockUi();
                return;
            }

            int selectedThreadCount = int.Parse(((string)cboMaxProcesses.SelectedItem).Split(' ')[0]);
            int threadsToLaunchCount = selectedThreadCount > filesToProcess.Count ? filesToProcess.Count : selectedThreadCount;


            for (int threadNumber = 1; threadNumber <= threadsToLaunchCount; threadNumber++)
            {
                ThreadItem item = new ThreadItem(string.Format("Thread {0}: IDLE (Waiting for work)", threadNumber), threadNumber);
                lstThreads.Items.Add(item);
            }

            // Feed workers and start work
            _workerManager.Feed(filesToProcess);
            _workerManager.Start(threadsToLaunchCount, txtDestFolder.Text, Globals.ApplicationConfiguration.PDFReducerConfiguration);
        }
        #endregion //Reduce operations start

        #region Control interactions event handlers

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.ApplicationConfiguration.InputPath = txtSourcePath.Text;
            Globals.ApplicationConfiguration.OutputPath = txtDestFolder.Text;
        }


        private void cmdBrowseFiles_Click(object sender, EventArgs e)
        {
            fileSelectDlg.Filter = "Any|*.*";


            if (fileSelectDlg.ShowDialog() == DialogResult.OK)
            {
                StringBuilder fileNames = new StringBuilder();
                int count = fileSelectDlg.FileNames.Length;

                for (int i = 0; i < count; i++)
                {
                    if (i > 0)
                    {
                        fileNames.Append("|");
                    }

                    fileNames.Append(fileSelectDlg.FileNames[i]);
                }

                txtSourcePath.Text = fileNames.ToString();
            }

        }


        private void cmdBrowseFolders_Click(object sender, EventArgs e)
        {
            FldBrowse.SelectedPath = Directory.GetCurrentDirectory();
            if (FldBrowse.ShowDialog() == DialogResult.OK)
            {
                txtSourcePath.Text = FldBrowse.SelectedPath;
            }
        }


        private void cmdBrowseDest_Click(object sender, EventArgs e)
        {
            FldBrowse.SelectedPath = Directory.GetCurrentDirectory();
            if (FldBrowse.ShowDialog() == DialogResult.OK)
            {
                txtDestFolder.Text = FldBrowse.SelectedPath;
            }
        }

        private void cmdRun_Click(object sender, EventArgs e)
        {
            bool cancellation = _UILocked;

            if (!cancellation)
            {
                if (txtSourcePath.Text == "")
                {
                    MessageBox.Show("Please select a source directory or one or several source files", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                bool inputIsFolder = Directory.Exists(txtSourcePath.Text);
                string[] files = txtSourcePath.Text.Split('|');

                if (files.Length == 1)
                {
                    if (!inputIsFolder && !(File.Exists(txtSourcePath.Text)))
                    {
                        MessageBox.Show("The specified source file or directory does not exist", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }

                if (inputIsFolder && !files[0].EndsWith("\\"))
                {
                    // Ensure directory path ends with "\"
                    files[0] += "\\";
                }

                Go(files, inputIsFolder);
            }
            else
            {
                cmdRun.Text = "Cancellation";
                _workerManager.AbortWork();
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmOptions options = new frmOptions())
            {
                options.ShowDialog(this);
            }
        }


        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (!_UILocked && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }



        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            if (!_UILocked)
            {
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtSourcePath.Text = string.Join("|", data);
                Go(data, false);
            }
        }


        private void btPause_Click(object sender, EventArgs e)
        {
            if (_workerManager.Paused)
            {
                _workerManager.ResumeWork();
                btPause.Text = "\u23F8"; // Unicode "pause" symbol
            }
            else
            {
                if (_workerManager.PauseWork())
                {
                    btPause.Text = "\u25BA"; // Unicode "play" symbol
                }
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gdpicture.com");
        }
        #endregion //Control interactions event handlers
    }
}