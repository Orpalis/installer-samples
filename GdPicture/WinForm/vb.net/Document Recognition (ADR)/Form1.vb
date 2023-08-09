Option Explicit On
Option Strict On

Imports GdPicture14

Public Class Form1
    Private m_GdPictureImaging As New GdPictureImaging

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
    End Sub

    Private Sub reloadCurrentADRConfig()
        lstTemplatesView.BeginUpdate()
        If lstTemplatesView.Items.Count > 0 Then lstTemplatesView.Items.Clear()
        Dim templateCount As Integer = m_GdPictureImaging.ADRGetTemplateCount()
        If templateCount > 0 Then
            For i As Integer = 1 To templateCount
                Dim templateID As Integer = m_GdPictureImaging.ADRGetTemplateID(i)
                Dim templateName As String = m_GdPictureImaging.ADRGetTemplateTag(templateID)
                Dim imageCount As Integer = m_GdPictureImaging.ADRGetTemplateImageCount(templateID)

                addTemplateItem(templateName, templateID, imageCount)
            Next
        Else
            MessageBox.Show("No template available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        lstTemplatesView.EndUpdate()
    End Sub

    Private Sub addTemplateItem(ByVal templateName As String, ByVal templateID As Integer, ByVal imageCount As Integer)
        Dim templateItem As New ListViewItem
        templateItem.Text = templateName
        templateItem.SubItems.Add(templateID.ToString())
        templateItem.SubItems.Add(imageCount.ToString())
        Me.lstTemplatesView.Items.Add(templateItem)
    End Sub

    Private Sub addTemplateImage(ByVal templateID As Integer)
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog With {.Multiselect = True}
        If (openFileDialog1.ShowDialog = DialogResult.OK) Then
            Dim fileAdded As Boolean = False
            For Each file As String In openFileDialog1.FileNames
                Dim imageId As Integer = m_GdPictureImaging.CreateGdPictureImageFromFile(file)
                If (imageId <> 0) Then
                    If (m_GdPictureImaging.ADRAddGdPictureImageToTemplate(templateID, imageId) = GdPictureStatus.OK) Then
                        reloadCurrentADRConfig()
                        fileAdded = True
                    Else
                        MessageBox.Show("Error adding " & file & " to the template. Status: " & m_GdPictureImaging.GetStat(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit For
                    End If
                    m_GdPictureImaging.ReleaseGdPictureImage(imageId)
                Else
                    MessageBox.Show(("Can't open " & file), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit For
                End If
            Next
            If fileAdded Then
                MessageBox.Show("Image(s) added!")
            End If
        End If
    End Sub

    Private Sub clearCurrentConfig()
        Me.lstTemplatesView.Items.Clear()
        m_GdPictureImaging.ADRStartNewTemplateConfig()
    End Sub
    
    Private Sub Form1_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Leave
        m_GdPictureImaging.Dispose()
    End Sub

    Private Sub btNewTemplate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btNewTemplate.Click
        Dim templateName As String = InputBox("Template Name: ")
        If templateName <> "" Then
            Dim templateID As Integer = m_GdPictureImaging.ADRCreateTemplateEmpty()
            m_GdPictureImaging.ADRSetTemplateTag(templateID, templateName)
            addTemplateItem(templateName, templateID, 0)
            If MessageBox.Show("Do you want to add one or more images to this template? (recommended)", "Please add image to template", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                addTemplateImage(templateID)
            End If
        End If
    End Sub

    Private Sub btClearConfig_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btClearConfig.Click
        clearCurrentConfig()
    End Sub

    Private Sub btLoadADRConfig_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btLoadADRConfig.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "ADR config | *.dat"
            If ofd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                clearCurrentConfig()
                If m_GdPictureImaging.ADRLoadTemplateConfig(ofd.FileName) Then
                    reloadCurrentADRConfig()
                Else
                    MessageBox.Show("Error loading template config. Status: " + m_GdPictureImaging.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

    Private Sub btDeleteTemplate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btDeleteTemplate.Click
        If lstTemplatesView.SelectedItems.Count = 1 Then
            Dim listItem As ListViewItem = lstTemplatesView.SelectedItems(0)
            Dim templateID As Integer = CInt(listItem.SubItems(1).Text)
            m_GdPictureImaging.ADRDeleteTemplate(templateID)
            lstTemplatesView.Items.Remove(listItem)
        Else
            MessageBox.Show("Please first select a template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btSaveADRConfig_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSaveADRConfig.Click
        Using sfd As New SaveFileDialog()
            sfd.Filter = "ADR config | *.dat"
            If sfd.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If m_GdPictureImaging.ADRSaveTemplateConfig(sfd.FileName) Then
                    MessageBox.Show("Config saved!")
                Else
                    MessageBox.Show("Error saving template config. Status: " + m_GdPictureImaging.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

    Private Sub btAddTemplateImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAddTemplateImage.Click
        If lstTemplatesView.SelectedItems.Count = 1 Then
            Dim listItem As ListViewItem = lstTemplatesView.SelectedItems(0)
            Dim templateID As Integer = CInt(listItem.SubItems(1).Text)
            addTemplateImage(templateID)
        Else
            MessageBox.Show("Please first select a template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btIdentifyDocument_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btIdentifyDocument.Click
        If m_GdPictureImaging.ADRGetTemplateCount() > 0 Then
            Dim bTemplateConfigOK As Boolean = True

            For i As Integer = 1 To m_GdPictureImaging.ADRGetTemplateCount
                Dim templateID As Integer = m_GdPictureImaging.ADRGetTemplateID(i)
                If m_GdPictureImaging.ADRGetTemplateImageCount(templateID) = 0 Then
                    MessageBox.Show("Please assign image(s) to template ID: " & templateID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    bTemplateConfigOK = False
                    Exit For
                End If
            Next

            If bTemplateConfigOK Then
                Dim ImageID As Integer = m_GdPictureImaging.CreateGdPictureImageFromFile("")
                If ImageID <> 0 Then
                    Dim closerTemplateID As Integer = m_GdPictureImaging.ADRGetCloserTemplateForGdPictureImage(ImageID)
                    If closerTemplateID <> 0 Then
                        Dim templateName As String = m_GdPictureImaging.ADRGetTemplateTag(closerTemplateID)
                        Dim accuracy As Double = Math.Round(m_GdPictureImaging.ADRGetLastConfidence(), 2)
                        If MessageBox.Show("Template identified: " + templateName + " (" + closerTemplateID.ToString + ")" + Chr(13) +
                         "Accuracy: " + accuracy.ToString() + Chr(13) + Chr(13) +
                         "Do you want to get extended results?", "results", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                            Dim fullResults As String = ""

                            For i As Integer = 1 To m_GdPictureImaging.ADRGetTemplateCount()
                                Dim templateID As Integer = m_GdPictureImaging.ADRGetTemplateID(i)
                                templateName = m_GdPictureImaging.ADRGetTemplateTag(templateID)
                                accuracy = Math.Round(m_GdPictureImaging.ADRGetLastConfidenceFromTemplate(templateID), 2)
                                fullResults += "Accuracy: " + accuracy.ToString + " Template: " + templateName + " (" + templateID.ToString + ")" + Chr(13)
                            Next

                            MessageBox.Show(fullResults)
                        End If

                    Else
                        MessageBox.Show("Error during template matching. Status: " + m_GdPictureImaging.GetStat().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    m_GdPictureImaging.ReleaseGdPictureImage(ImageID)
                Else
                    MessageBox.Show("Can't open selected image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please first create template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
