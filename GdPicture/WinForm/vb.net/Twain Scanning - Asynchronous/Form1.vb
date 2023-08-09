Option Strict On
Option Explicit On


Imports GdPicture14

Public Class Form1

    Private m_GdPictureImaging As New GdPictureImaging
    Private WithEvents m_BackGroundWorker As New System.ComponentModel.BackgroundWorker
    Private m_scanFolder As String = My.Application.Info.DirectoryPath

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Check for 64-bit mode app running
        If IntPtr.Size = 8 Then
            MessageBox.Show("Warning: The application is running in 64-bit mode. To be able to handle 32-bit TWAIN drivers you will have to target it to 32-bit mode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXX") 'Please, replace XXX by a valid demo or commercial license key. 

        m_BackGroundWorker.WorkerReportsProgress = True
        m_BackGroundWorker.WorkerSupportsCancellation = False ' I suggest this
    End Sub


    Private Sub m_BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles m_BackGroundWorker.DoWork 
        Dim hwnd As IntPtr = IntPtr.Zero 'To enfore the TWAIN controler to create its own windows proxy in this SAME thread.

        If m_GdPictureImaging.TwainSelectSource(hwnd) Then
            If m_GdPictureImaging.TwainOpenDefaultSource(hwnd) Then
                Dim scanCount As Integer = 0
                Dim useFeeder As Boolean = chkUseFeeder.Checked
                Dim duplex As Boolean = chkDuplex.Checked
                Dim showDeviceUI As Boolean = chkHideGUI.Checked
                Dim showDeviceProgress As Boolean = chkEnableIndicator.Checked

                m_GdPictureImaging.TwainSetHideUI(showDeviceUI)
                m_GdPictureImaging.TwainSetIndicators(showDeviceProgress)
                m_GdPictureImaging.TwainSelectFeeder(useFeeder)

                If useFeeder Then
                    m_GdPictureImaging.TwainSetAutoFeed(True)
                    m_GdPictureImaging.TwainSetAutoScan(True)
                End If

                m_GdPictureImaging.TwainEnableDuplex(duplex)

                Do
                    If Not m_BackGroundWorker.CancellationPending Then
                        Dim ImageID As Integer = m_GdPictureImaging.TwainAcquireToGdPictureImage(hwnd)
                        If ImageID <> 0 Then
                            scanCount += 1
                            m_BackGroundWorker.ReportProgress(scanCount, ImageID)
                        End If
                        If Not useFeeder Then
                            Exit Do 'we exit here in case of fladbed source acquisition
                        End If
                    Else
                        Exit Do
                    End If
                Loop While m_GdPictureImaging.TwainGetState > TwainStatus.TWAIN_SOURCE_ENABLED

                If scanCount > 0 Then
                    MessageBox.Show(scanCount.ToString() + " pages have been acquired in: " + m_scanFolder)
                Else
                    MessageBox.Show("Operation failed cancelled. Please check status!")
                End If
                m_GdPictureImaging.TwainCloseSource()
            Else
                MessageBox.Show("Unable to open the default TWAIN source. " + Chr(13) + _
                                "Result code: " + m_GdPictureImaging.TwainGetLastResultCode.ToString() + Chr(13) + _
                                "Condition code: " + m_GdPictureImaging.TwainGetLastConditionCode.ToString())
            End If
        Else
            MessageBox.Show("Operation cancelled - no source selected")
        End If
        m_GdPictureImaging.TwainUnloadSourceManager(hwnd)
    End Sub


    Private Sub m_BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles m_BackGroundWorker.ProgressChanged
        Dim ImageID As Integer = CInt(e.UserState)
        Call m_GdPictureImaging.SaveAsJPEG(ImageID, m_scanFolder + "\image" & Trim(Str(e.ProgressPercentage)) + ".jpg", 75)
        Call m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not m_BackGroundWorker.IsBusy Then
            If chkGenLog.Checked Then
                m_GdPictureImaging.TwainLogStart("c:\gdpicture_twain.log")
            End If

            m_GdPictureImaging.TwainSetModalUI(chkModalUI.Checked)


            If chkTwain19.Checked Then
                m_GdPictureImaging.TwainSetDSMPath("c:\windows\twain_32.dll")
            Else
                m_GdPictureImaging.TwainSetDSMPath("") 'the higehr DSM will be automatically loaded
            End If

            m_BackGroundWorker.RunWorkerAsync() 'do the scan

        Else
            MessageBox.Show("Backgroung worker is currently busy!")
        End If
    End Sub
End Class