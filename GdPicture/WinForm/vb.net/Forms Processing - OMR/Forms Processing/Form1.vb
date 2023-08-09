Option Explicit On
Option Strict On

Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.IO

Imports GdPicture14
Public Class Form1

    Public oGdPictureImaging As New GdPictureImaging
    Private oGUIManager As New GUIManager(Me)
   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.
        formViewer.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
        imagesViewer.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer
    End Sub

    Private Sub formSetUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles formSetUpButton.Click
        oGUIManager.OpenFormSetUP()
    End Sub

    Private Sub processFormsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles processFormsButton.Click
        oGUIManager.OpenProcessForms()
    End Sub

    Private Sub loadFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadFormButton.Click
        oGUIManager.LoadTemplateForm()
    End Sub

    Private Sub checkORCircle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkORCircle.CheckedChanged
        oGUIManager.CheckOrCircle_CheckedChanged()
    End Sub

    Private Sub oval_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oval.CheckedChanged
        oGUIManager.Oval_CheckedChanged()
    End Sub

    Private Sub hasCharacter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hasCharacter.CheckedChanged
        oGUIManager.HasCharacter_CheckedChanged()
    End Sub

    Private Sub useConfidence_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles useConfidence.CheckedChanged
        oGUIManager.UseConfidence_CheckedChanged()
    End Sub

    Private Sub sensitivity_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sensitivity.Scroll
        oGUIManager.Sensitivity_Scroll()
    End Sub

    Private Sub minConfidenceValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minConfidenceValue.ValueChanged
        oGUIManager.MinConfidenceValue_Changed()
    End Sub

    Private Sub selectAnchorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectAnchorButton.Click
        oGUIManager.SelectAnchor()
    End Sub

    Private Sub formViewer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles formViewer.MouseUp
        oGUIManager.MouseUP()
    End Sub

    Private Sub formViewer_RegionEditedByUser(ByVal RegionID As Integer) Handles formViewer.RegionEditedByUser
        oGUIManager.RegionEditedByUser(RegionID)
    End Sub

    Private Sub addFieldsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addFieldsButton.Click
        oGUIManager.AddFields()
    End Sub

    Private Sub loadImagesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadImagesButton.Click
        oGUIManager.LoadImagesButton_Click()
    End Sub

    Private Sub clearImagesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearImagesButton.Click
        oGUIManager.ClearFilledForms()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        oGUIManager.ListBox1_SelectedIndexChanged()
    End Sub

    Private Sub omrImagesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles omrImagesButton.Click
        oGUIManager.OMRImagesButton_Click()
    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProjectToolStripMenuItem.Click
        oGUIManager.NewProject()
    End Sub

    Private Sub CloseProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseProjectToolStripMenuItem.Click
        oGUIManager.CloseProject()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub addSingleFieldButon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addSingleFieldButon.Click
        oGUIManager.AddSingleField()
    End Sub

    Private Sub addMultipleFieldsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addMultipleFieldsButton.Click
        oGUIManager.AddMultipleFields()
    End Sub


End Class
