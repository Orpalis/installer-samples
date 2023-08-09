Option Strict On
Option Explicit On

Public Class frmAbout

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lblGdPictureWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblGdPictureWebsite.LinkClicked
        Process.Start("http://www.gdpicture.com/")
    End Sub
End Class