using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GdPicture14;

namespace pdfReducer
{
    internal sealed class PDFReducerWorkerManager
    {
        private List<FileToProcess> _filesToProcess;

        private readonly object _locker;

        // Delegate sub to call Cross thread GUI Updates

        public delegate void WarningDelegate(PDFReducerWarningStatus warning, string fileName, int pageNumber, int pageImageNumber);

        public delegate void ErrorDelegate(GdPictureStatus status, PDFReducerErrorStatus error, string fileName, int pageNumber);

        public delegate void WorkerProgressDelegate(WorkerProgressStatus progressStatus, int workerNumber, string fileName, PDFReducerStats stats);

        // Events to be subscribed to by GUIs
        public event WorkerProgressDelegate WorkerProgressEventHandler;
        public event WarningDelegate WarningEventHandler;
        public event ErrorDelegate ErrorEventHandler;

        // Track miscellaneous information to inform UI of reduction efficency
        internal PDFReducerStats Stats { get; }

        // Handles the pause of worker threads
        internal ManualResetEvent WaitHandle { get; }

        // Specifies whether the worker threads must pause their work
        public bool Paused { get; private set; }

        // Specifies whether the worker threads must abort their work
        internal bool Aborted { get; private set; }

        public PDFReducerWorkerManager()
        {
            _filesToProcess = new List<FileToProcess>();
            _locker = new object();
            Stats = new PDFReducerStats();
            WaitHandle = new ManualResetEvent(true);
        }


        public void Feed(List<FileToProcess> filesToProcess)
        {
            lock (_locker)
            {
                _filesToProcess.AddRange(filesToProcess);
            }
        }


        public void Start(int workerCount, string destinationFolder, PDFReducerConfiguration configuration)
        {

            if (Aborted)
            {
                Aborted = false;
            }

            for (int workerNumber = 1; workerNumber <= workerCount; workerNumber++)
            {
                // Launch the workers.
                PDFReducerWorker worker = new PDFReducerWorker(this, workerNumber);
                Thread thread = new Thread(() => worker.ProcessDocuments(configuration, destinationFolder));
                thread.Start();
            }
        }


        public bool PauseWork()
        {
            lock (_locker)
            {
                if (_filesToProcess.Count > 0)
                {
                    Paused = true;
                    WaitHandle.Reset();
                    return true;
                }
                else
                {
                    //Don't pause work if no file has yet to be processed
                    return false;
                }
            }
        }


        public void ResumeWork()
        {
            lock (_locker)
            {
                Paused = false;
                WaitHandle.Set();
            }
        }


        public void AbortWork()
        {
            lock (_locker)
            {
                Aborted = true;
                _filesToProcess.Clear();
                if (Paused)
                {
                    // Resume worker threads so they can exit
                    ResumeWork();
                }
            }
        }


        public void Reset()
        {
            Stats.InputFilesSize = 0;
            Stats.OutputFileSize = 0;
            Stats.ProcessedFilesCount = 0;
            Stats.ReductionRatio = 0;
        }


        internal bool PickFile(out FileToProcess file)
        {
            lock (_locker)
            {
                if (_filesToProcess.Count > 0)
                {
                    file = _filesToProcess[0];
                    _filesToProcess.RemoveAt(0);
                    return true;
                }
                else
                {
                    file = null;
                    return false;
                }
            }
        }


        internal void IncrementProcessedFilesCount()
        {
            lock (_locker)
            {
                Stats.ProcessedFilesCount++;
            }
        }


        internal void UpdateStats(double inputSize, double outputSize)
        {
            lock (_locker)
            {
                Stats.InputFilesSize += inputSize;
                Stats.OutputFileSize += outputSize;
                Stats.ReductionRatio = Math.Round(100 - (inputSize > 0 ? outputSize / inputSize * 100 : 100), 2);
            }
        }


        internal void OnWorkerProgress(WorkerProgressStatus progressStatus, int workerNumber, string fileName = null, PDFReducerStats stats = null)
        {
            WorkerProgressEventHandler?.Invoke(progressStatus, workerNumber, fileName, stats);
        }


        internal void OnWorkerWarning(PDFReducerWarningStatus status, string fileName, int pageNumber, int imageNumber)
        {
            WarningEventHandler?.Invoke(status, fileName, pageNumber, imageNumber);
        }


        internal void OnWorkerError(GdPictureStatus status, PDFReducerErrorStatus error, string fileName, int pageNumber)
        {
            ErrorEventHandler?.Invoke(status, error, fileName, pageNumber);
        }


        public enum WorkerProgressStatus
        {
            Idle = 1,
            WorkStart = 2,
            FileProcessingStart = 3,
            PageProcessingStart = 4,
            FileProcessingCompletion = 5,
            ReductionRatioUpdate = 6,
            Exit = 7,
            WorkComplete = 8
        }


        private sealed class PDFReducerWorker
        {
            private readonly PDFReducerWorkerManager _owner;

            private readonly int _workerId;


            public PDFReducerWorker(PDFReducerWorkerManager owner, int workerId)
            {
                _owner = owner;
                _workerId = workerId;
            }


            public void ProcessDocuments(PDFReducerConfiguration configuration, string destinationFolder)
            {
                _owner.OnWorkerProgress(WorkerProgressStatus.WorkStart, _workerId, stats: _owner.Stats);
                FileToProcess fileToProcess;
                bool mustProcess = _owner.PickFile(out  fileToProcess);
                GdPicturePDFReducer pdfReducer = new GdPicturePDFReducer();
                pdfReducer.PDFReducerConfiguration = configuration;

                while (mustProcess)
                {
                    string outputFilePath = Path.Combine(destinationFolder, fileToProcess.OutputFileName);
                    _owner.OnWorkerProgress(WorkerProgressStatus.FileProcessingStart, _workerId, fileToProcess.InputFileName, _owner.Stats);

                    GdPictureStatus status = pdfReducer.ProcessDocument(fileToProcess.InputFileName, outputFilePath);

                    if (status == GdPictureStatus.OK)
                    {
                        int warningCount = pdfReducer.GetWarningCount();

                        for (int warningIndex = 0; warningIndex < warningCount; warningIndex++)
                        {
                            _owner.OnWorkerWarning(pdfReducer.GetReducerWarningStat(warningIndex), fileToProcess.InputFileName,
                                pdfReducer.GetReducerWarningPageNumber(warningIndex), pdfReducer.GetReducerWarningImageNumber(warningIndex));
                        }

                        float inputSize = new FileInfo(fileToProcess.InputFileName).Length;
                        float outputSize = new FileInfo(outputFilePath).Length;
                        double reductionPercentage = Math.Round(inputSize > 0 ? (double)outputSize / inputSize * 100 : 100, 2);

                        if (reductionPercentage == 100)
                        {
                            reductionPercentage = Math.Round(inputSize > 0 ? (double)outputSize / inputSize * 100 : 100, 4);
                        }

                        _owner.UpdateStats(inputSize, outputSize);
                        _owner.OnWorkerProgress(WorkerProgressStatus.ReductionRatioUpdate, _workerId, stats: _owner.Stats);
                        _owner.OnWorkerProgress(WorkerProgressStatus.FileProcessingCompletion, _workerId, fileToProcess.InputFileName,
                            new PDFReducerStats() { InputFilesSize = inputSize, OutputFileSize = outputSize, ReductionRatio = reductionPercentage });
                    }
                    else
                    {
                        _owner.OnWorkerError(status, pdfReducer.GetReducerStat(), fileToProcess.InputFileName, pdfReducer.GetReducerErrorPageNumber()); ;
                    }

                    _owner.IncrementProcessedFilesCount();

                    if ((mustProcess = !_owner.Aborted && _owner.PickFile(out fileToProcess)) && _owner.Paused)
                    {
                        // If work remains but pause has been requested, pause the thread until work resume is requested
                        _owner?.OnWorkerProgress(WorkerProgressStatus.Idle, _workerId, stats: _owner.Stats);
                        _owner.WaitHandle.WaitOne();

                        // If work abortion has been requested while pausing, don't keep processing
                        if (_owner.Aborted)
                        {
                            mustProcess = false;
                        }
                    }
                }

                _owner.OnWorkerProgress(WorkerProgressStatus.WorkComplete, _workerId, stats: _owner.Stats);
            }
        }
    }
}
