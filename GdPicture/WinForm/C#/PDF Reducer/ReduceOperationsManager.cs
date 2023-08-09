using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using pdfReducer.Parameters;
using pdfReducer.Requests;
using pdfReducer.Utilities;
using PassportPDF.Api;
using PassportPDF.Model;
using System.IO.Compression;

namespace pdfReducer
{
#if CLOUD_VERSION

    internal struct FileToProcess //todo: move into separate file
    {
        public readonly string InputFilePath;

        public readonly string OutputFileName;


        public FileToProcess(string inputFilePath, string outputFileName)
        {
            InputFilePath = inputFilePath;
            OutputFileName = outputFileName;
        }
    }

    internal sealed class ReduceOperationsManager
    {
        private readonly List<FileToProcess> _filesToProcess = new List<FileToProcess>();

        private readonly object _locker = new object();

        private bool _cancellationPending = false;

        private ManualResetEvent _waitHandle = new ManualResetEvent(true);

        private string _destinationFolder;

        private PDFReduceParameters _reduceParameters;

        public delegate void ErrorDelegate(string errorMessage);
        public delegate void ReduceCompletionDelegate(PDFReduceResponse response, string fileName, float inputSize, float outputSize);
        public delegate void WorkCompletionDelegate(int workerNumber);
        public delegate void ProgressDelegate(int threadNumber, string fileName, int retries);
        public delegate void PauseDelegate(int workerNumber);

        public ProgressDelegate UploadOperationStartEventHandler;
        public ProgressDelegate ReduceOperationStartEventHandler;
        public ProgressDelegate DownloadOperationStartEventHandler;

        public WorkCompletionDelegate WorkCompletionEventHandler;
        public ReduceCompletionDelegate ReduceOperationCompletionEventHandler;

        public PauseDelegate WorkPauseEventHandler;

        public ErrorDelegate ErrorEventHandler;

        public bool WorkPaused { get; private set; }


        public void Feed(List<FileToProcess> filesToProcess)
        {
            lock (_locker)
            {
                _filesToProcess.AddRange(filesToProcess);
            }
        }


        public void Start(int workerCount, string destinationFolder, ApplicationConfiguration applicationConfiguration)
        {
            lock (_locker)
            {
                _cancellationPending = false;
            }

            PDFApi apiInstance = new PDFApi(Globals.API_SERVER_URI);
            apiInstance.Configuration.AddDefaultHeader("X-PassportPDF-API-Key", ApplicationConfiguration.API_KEY);
            apiInstance.Configuration.Timeout = Globals.SuggestedClientTimeout;

            if (!destinationFolder.EndsWith("\\"))
            {
                destinationFolder += "\\";
            }
            _destinationFolder = destinationFolder;

            for (int i = 1; i <= workerCount; i++)
            {
                int workerNumber = i;
                // Launch the workers.
                Thread thread = new Thread(() => this.Process(apiInstance, workerNumber, applicationConfiguration));
                thread.Start();
            }
        }


        public bool PauseWork()
        {
            lock (_locker)
            {
                if (_filesToProcess.Count > 0)
                {
                    WorkPaused = true;
                    _waitHandle.Reset();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public void ResumeWork()
        {
            lock (_locker)
            {
                WorkPaused = false;
                _waitHandle.Set();
            }
        }


        public void AbortWork()
        {
            lock (_locker)
            {
                _cancellationPending = true;
                _filesToProcess.Clear();
                if (WorkPaused)
                {
                    // Resume worker threads so they can exit
                    ResumeWork();
                }
            }
        }


        private bool PickFile(out FileToProcess file)
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
                    file = default(FileToProcess);
                    return false;
                }
            }
        }


        private static async void TryCloseDocumentAsync(PDFApi apiInstance, string fileID)
        {
            if (string.IsNullOrWhiteSpace(fileID))
            {
                throw new ArgumentNullException("FileID");
            }

            PDFCloseDocumentParameters closeDocumentParameters = new PDFCloseDocumentParameters(fileID);

            try
            {
                await apiInstance.CloseDocumentAsync(closeDocumentParameters); //we do not want to stop the process by waiting such response.
            }
            catch
            {
                return;
            }
        }


        private void Process(PDFApi apiInstance, int workerNumber, ApplicationConfiguration applicationConfiguration)
        {
            FileToProcess fileToProcess;

            while (PickFile(out fileToProcess))
            {
                if (_cancellationPending)
                {
                    break;
                }

                string inputFilePath = fileToProcess.InputFilePath;

                try
                {
                    long inputFileSize = FileUtils.GetFileSize(inputFilePath);
                    bool inputIsPDF = Path.GetExtension(inputFilePath).ToUpper() == ".PDF";

                    if (inputFileSize == 0)
                    {
                        ErrorEventHandler.Invoke("Can't process empty file: " + inputFilePath);
                        continue;
                    }
                    else if (inputFileSize > Globals.MaxAllowedContentLength)
                    {
                        ErrorEventHandler.Invoke("Can't process more than " + Globals.MaxAllowedContentLength.ToString() + " bytes file: " + inputFilePath);
                        continue;
                    }

                    FileStream fileStream = null;

                    try
                    {
                        // Load document on remote server
                        PassportPDFParametersUtilities.GetLoadDocumentMultipartParameters(inputFilePath, applicationConfiguration.PDFReducerConfiguration.OutputVersion, out fileStream, out string conformance, out string fileName);

                        using (FileStream tmpFile = System.IO.File.Create(Path.GetTempFileName(), 4096, System.IO.FileOptions.DeleteOnClose))
                        {
                            using (GZipStream dataStream = new GZipStream(tmpFile, CompressionLevel.Optimal, true))
                            {
                                fileStream.CopyTo(dataStream);
                            }

                            tmpFile.Seek(0, SeekOrigin.Begin);
                            apiInstance.Configuration.Timeout = int.MaxValue; //todo: specify a timeout based on file size.
                            PDFLoadDocumentResponse loadDocumentResponse = PassportPDFRequestsUtilities.SendLoadDocumentMultipartRequest(apiInstance, workerNumber, inputFilePath, fileName, conformance, tmpFile, "Gzip", UploadOperationStartEventHandler);
                            apiInstance.Configuration.Timeout = Globals.SuggestedClientTimeout;

                            if (loadDocumentResponse.Error == null)
                            {
                                // Reduce document
                                PDFReduceParameters reduceParameters = PassportPDFParametersUtilities.GetReduceParameters(applicationConfiguration.PDFReducerConfiguration, loadDocumentResponse.FileID);
                                PDFReduceResponse reduceResponse = PassportPDFRequestsUtilities.SendReduceRequest(apiInstance, reduceParameters, workerNumber, inputFilePath, ReduceOperationStartEventHandler);

                                if (_cancellationPending)
                                {
                                    break;
                                }

                                if (reduceResponse.Error == null)
                                {
                                    // Download reduced document
                                    PDFSaveDocumentParameters saveDocumentParameters = PassportPDFParametersUtilities.GetSaveDocumentParameters(loadDocumentResponse.FileID);
                                    PDFSaveDocumentResponse saveDocumentResponse = PassportPDFRequestsUtilities.SendSaveDocumentRequest(apiInstance, saveDocumentParameters, workerNumber, inputFilePath, DownloadOperationStartEventHandler);

                                    if (_cancellationPending)
                                    {
                                        break;
                                    }

                                    if (saveDocumentResponse.Error == null)
                                    {
                                        string destinationPath = _destinationFolder + fileToProcess.OutputFileName;
                                        bool outputIsInput = FileUtils.AreSamePath(inputFilePath, destinationPath);
                                        bool contentRemoved = (bool)reduceResponse.ContentRemoved;
                                        bool versionChanged = (bool)reduceResponse.VersionChanged;
                                        bool keepProduced = saveDocumentResponse.Data.LongLength < inputFileSize || applicationConfiguration.PDFReducerConfiguration.FastWebView || !inputIsPDF || contentRemoved || versionChanged;

                                        // Save reduced document to output folder
                                        if (keepProduced)
                                        {
                                            FileUtils.SaveFile(saveDocumentResponse.Data, inputFilePath, destinationPath, applicationConfiguration.KeepWriteAndAccessTime);
                                        }
                                        else
                                        {
                                            if (!outputIsInput)
                                            {
                                                string directory = Path.GetDirectoryName(destinationPath);

                                                if (!Directory.Exists(directory))
                                                {
                                                    Directory.CreateDirectory(directory);
                                                }

                                                File.Copy(inputFilePath, destinationPath, true); //todo: check if KeepWriteAndAccessTime is honored
                                            }
                                            else if (applicationConfiguration.DeleteOriginalFileOnSuccess)
                                            {
                                                try
                                                {
                                                    FileUtils.DeleteFileEx(inputFilePath);
                                                }
                                                catch
                                                {
                                                    // todo: warn user that original file could not be deleted.
                                                }
                                            }
                                        }

                                        long outputFileSize = FileUtils.GetFileSize(destinationPath);

                                        if (!keepProduced)
                                        {
                                            if (reduceResponse.WarningsInfo == null)
                                            {
                                                reduceResponse.WarningsInfo = new List<ReduceWarningInfo>();
                                            }

                                            reduceResponse.WarningsInfo.Add(new ReduceWarningInfo(ReduceWarningInfo.WarningCodeEnum.FileSizeReductionFailure));
                                        }

                                        ReduceOperationCompletionEventHandler.Invoke(reduceResponse, inputFilePath, inputFileSize, outputFileSize);
                                    }
                                }
                                else
                                {
                                    string errorMessage = reduceResponse.ErrorInfo.ErrorCode != ReduceErrorInfo.ErrorCodeEnum.OK ? ErrorManager.GetMessageFromReduceActionError(reduceResponse.ErrorInfo, inputFilePath) : ErrorManager.GetMessageFromPassportPDFError(reduceResponse.Error, inputFilePath);

                                    ErrorEventHandler.Invoke(errorMessage);
                                }

                                TryCloseDocumentAsync(apiInstance, loadDocumentResponse.FileID);
                            }
                            else
                            {
                                ErrorEventHandler.Invoke(ErrorManager.GetMessageFromPassportPDFError(loadDocumentResponse.Error, inputFilePath));
                            }
                        }
                    }
                    finally
                    {
                        if (fileStream != null)
                        {
                            fileStream.Dispose();
                        }
                    }
                }
                catch (Exception exception)
                {
                    ErrorEventHandler.Invoke(ErrorManager.GetMessageFromException(exception, inputFilePath));
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                if (WorkPaused && !_cancellationPending)
                {
                    // If pause has been requested, wait for resume signal
                    WorkPauseEventHandler.Invoke(workerNumber);
                    _waitHandle.WaitOne();
                }
            }

            WorkCompletionEventHandler.Invoke(workerNumber);
        }
    }
}
#endif
