Imports System.Collections.Generic
Imports System.IO
Imports Thread = System.Threading.Thread
Imports GdPicture14

Public Class clsWorkerThread
    'Lock object for threads to pick off from the list.
    Public Shared SyncLockObj As New Object

    'Structure used to hold data in the list declared above
    Public Structure BatchItems
        Public inPath As String
        Public inFile As String
        Public outPath As String
        Public outFile As String
    End Structure
    'List of files to process (input & output paths)
    Public Shared files As New List(Of BatchItems)

    'Processed Count (for progress bar)
    Public Shared ProcessedCount As Integer


    Public Shared Sub CollectFiles(ByVal inpath As String, ByVal outpath As String, Optional ByVal recursive As Boolean = False)
        SyncLock SyncLockObj
            ProcessedCount = 0
            CollectFiles(inpath, outpath, String.Empty, recursive)
        End SyncLock
    End Sub

    Private Shared Sub CollectFiles(ByVal inpath As String, ByVal outpath As String, ByVal relpath As String, Optional ByVal recursive As Boolean = False)
        Dim OneBatchItem As New clsWorkerThread.BatchItems
        OneBatchItem.inPath = inpath
        OneBatchItem.outPath = outpath

        For Each file As FileInfo In New DirectoryInfo(Path.Combine(inpath, relpath)).GetFiles("*.*")
            OneBatchItem.inFile = Path.Combine(relpath, file.Name)
            OneBatchItem.outFile = Path.Combine(relpath, Path.ChangeExtension(file.Name, "jpg"))
            clsWorkerThread.files.Add(OneBatchItem)
        Next

        If recursive Then
            For Each dir As DirectoryInfo In New DirectoryInfo(Path.Combine(inpath, relpath)).GetDirectories()
                CollectFiles(inpath, outpath, Path.Combine(relpath, dir.Name), recursive)
            Next
        End If
    End Sub

    'Thread numbers
    Private _ThreadId As Integer

    'Delegate sub to call Cross thread GUI Updates
    Delegate Sub UpdateUIHandler( _
        ByVal ThreadID As Integer, _
        ByVal strText As String)


    Public Sub New(ByVal ThreadId As Integer)
        _ThreadId = ThreadId
    End Sub

    Public ReadOnly Property ThreadId()
        Get
            Return _ThreadId
        End Get
    End Property

#Region "    Notification"
    Private Sub NotifyProgress(ByVal text As String)
        Dim MainUI As frmMain = My.Application.OpenForms("frmMain")
        MainUI.Invoke( _
            New UpdateUIHandler(AddressOf MainUI.UIUpdateThreads), _
            New Object() {_ThreadId, text})
    End Sub

    Private Sub NotifyStatus(ByVal text As String)
        Dim MainUI As frmMain = My.Application.OpenForms("frmMain")
        MainUI.Invoke( _
            New UpdateUIHandler(AddressOf MainUI.UIUpdateProcessLog), _
            New Object() {_ThreadId, text})
    End Sub

    Private Sub NotifyError(ByVal text As String)
        Dim MainUI As frmMain = My.Application.OpenForms("frmMain")
        MainUI.Invoke( _
            New UpdateUIHandler(AddressOf MainUI.UIUpdateErrLog), _
            New Object() {_ThreadId, text})
    End Sub

    Private Sub NotifyFinish()
        Dim MainUI As frmMain = My.Application.OpenForms("frmMain")
        MainUI.Invoke(New UpdateUIHandler(AddressOf MainUI.CleanUpThreads), _
                      New Object() {_ThreadId, Nothing})
    End Sub
#End Region

    Public Sub StartProcessBatch()
        With New Thread(AddressOf ProcessBatch)
            .Start()
        End With
    End Sub

    Private Shared Function Round(ByVal time As TimeSpan) As TimeSpan
        Return New TimeSpan(time.Days, time.Hours, time.Minutes, time.Seconds + Math.Round(time.Milliseconds / 1000))
    End Function

    Public Sub ProcessBatch()

        NotifyProgress("Starting...")
        Thread.Sleep(200)

        Do While True
            'Create synclock to pick off new work item
            Dim OneBatchItem As New BatchItems
            SyncLock SyncLockObj
                'Check how many files are left to process.... if there is nothing, quit thread
                If files.Count = 0 Then
                    Exit Do
                End If

                'Pick off item
                For Each OneBatchItem In files
                    files.Remove(OneBatchItem)
                    Exit For
                Next
            End SyncLock


            'SyncLock SyncLockObj
            Try
                Dim inFile As String = Path.Combine(OneBatchItem.inPath, OneBatchItem.inFile)
                Dim outFile As String = Path.Combine(OneBatchItem.outPath, Path.GetFileName(OneBatchItem.outFile))
                If True Or Not File.Exists(outFile) Then
                    NotifyProgress("Processing " & OneBatchItem.inFile)

                    Dim time As Date = Date.Now
                    Dim oGdPictureImaging As New GdPictureImaging
                    Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
                    oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
                    If GdPictureDocumentUtilities.GetDocumentFormatFromFileName(inFile) = GdPicture14.DocumentFormat.DocumentFormatPDF Then
                        'PDF mode
                        Dim outPDF As New GdPicturePDF

                        If outPDF.LoadFromFile(inFile, False) = GdPictureStatus.OK Then
                            Dim bUncrypted As Boolean = True
                            If outPDF.IsEncrypted() Then
                                'Try to unencrypt document using empty password
                                bUncrypted = outPDF.SetPassword("")
                            End If
                            If bUncrypted Then
                                outPDF.SelectPage(1)
                                Dim ThumbID As Integer = outPDF.GetPageThumbnail(128, 128, Color.White)
                                If ThumbID <> 0 Then
                                    oGdPictureImaging.SaveAsPNG(ThumbID, outFile)
                                    oGdPictureImaging.ReleaseGdPictureImage(ThumbID)
                                    NotifyStatus("Ok  -" & time.ToString() & ": " & OneBatchItem.inFile & " - Success")
                                Else
                                    NotifyError("Err -" & time.ToString() & ": " & OneBatchItem.inFile & " - Thumbnail creation failed.")
                                End If
                            Else
                                NotifyError("Err-" & OneBatchItem.inFile & " - Password protected document")
                            End If
                            outPDF.CloseDocument()
                        Else
                            NotifyError("Err-" & OneBatchItem.inFile & " - cannot load document")
                        End If
                    Else
                        'ImageMode
                        Dim ImageID As Integer = 0
                        Try
                            ImageID = oGdPictureImaging.CreateGdPictureImageFromFile(inFile)
                            If ImageID <> 0 Then
                                Dim ThumbID As Integer = oGdPictureImaging.CreateThumbnailHQ(ImageID, 128, 128, Color.White)

                                If ThumbID <> 0 Then
                                    oGdPictureImaging.SaveAsPNG(ThumbID, outFile)
                                    oGdPictureImaging.ReleaseGdPictureImage(ThumbID)
                                    NotifyStatus("Ok  -" & time.ToString() & ": " & OneBatchItem.inFile & " - Success")
                                Else
                                    NotifyError("Err -" & time.ToString() & ": " & OneBatchItem.inFile & " - Thumbnail creation failed.")
                                End If
                                oGdPictureImaging.ReleaseGdPictureImage(ImageID)
                            Else
                                NotifyError("Err-" & OneBatchItem.inFile & " - cannot load document")
                            End If
                        Catch ex As Exception
                            NotifyError("Err -" & time.ToString() & ": " & OneBatchItem.inFile & " - Failed: " & ex.Message)
                        End Try
                    End If
                   
                Else
                    NotifyStatus("Skip-" & OneBatchItem.outFile & " - already exists")
                    NotifyError(OneBatchItem.inFile & " - already exists")
                End If
            Catch ex As Exception
                NotifyError(OneBatchItem.inFile & " - " & ex.Message)
            End Try

            SyncLock SyncLockObj
                'Increase the Processed Count
                ProcessedCount = ProcessedCount + 1
            End SyncLock
        Loop

        NotifyProgress("IDLE (No work)")
        Thread.Sleep(200)
        NotifyProgress(" <-- Exiting")
        Thread.Sleep(200)
        NotifyFinish()
    End Sub
End Class
