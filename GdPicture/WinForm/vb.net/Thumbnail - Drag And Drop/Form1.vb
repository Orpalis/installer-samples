Option Explicit On
Option Strict On
Option Infer On

Imports GdPicture14


Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oLicenseManager As New GdPicture14.LicenseManager() 'Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
        oLicenseManager.RegisterKEY("XXXX") 'Please, replace XXXX by a valid demo or commercial license key.

        ThumbnailEx1.AllowDrop = True
        ThumbnailEx1.OwnDrop = True

        ThumbnailEx2.AllowDrop = True
        ThumbnailEx2.OwnDrop = True
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ThumbnailEx1.LoadFromDirectory(folderBrowserDialog.SelectedPath, chkIncludeSubfolders.Checked)
            End If
        End Using
    End Sub


    Private Sub performDragDrop(ByVal sender As ThumbnailEx, ByVal receiver As ThumbnailEx, ByVal X As Integer, ByVal Y As Integer)
        Dim itemDestIdx As Integer = 0

        If receiver.ItemCount > 0 Then
            Dim pDest As Point = receiver.PointToClient(New Point(X, Y))
            itemDestIdx = receiver.GetItemAt(pDest.X, pDest.Y)
            If (itemDestIdx = -1) Then
                Return 'we should never reach this point
            End If
        End If

        For i As Integer = sender.ItemCount - 1 To 0 Step -1
            If sender.GetItemSelectState(i) Then
                Dim itemBitmap As Integer = sender.GetItemBitmap(i)
                If itemBitmap <> 0 Then
                    Dim insert As Boolean = True
                    Dim status As GdPictureStatus
                    Dim itemText As String = sender.GetItemText(i)
                    If receiver.ItemCount > 0 Then
                        If chkMoveAfter.Checked Then
                            If itemDestIdx = receiver.ItemCount - 1 Then
                                insert = False
                            Else
                                itemDestIdx += 1
                            End If
                        End If
                    Else
                        insert = False
                    End If

                    If insert Then
                        status = receiver.InsertItemFromGdPictureImage(itemBitmap, itemText, itemDestIdx)
                    Else
                        status = receiver.AddItemFromGdPictureImage(itemBitmap, itemText)
                    End If
                    If status = GdPictureStatus.OK Then
                        sender.RemoveItem(i)
                    Else
                        MessageBox.Show("Error, can't add item " + i.ToString())
                    End If
                    sender.ReleaseGdPictureImage(itemBitmap)
                Else
                    MessageBox.Show("Error, can't export item bitmap for index " + i.ToString())
                End If

            End If
        Next
    End Sub

    'Not super sexy. For avoiding duplicated code purpose.
    Private Sub setDragEffect(ByVal thumbnailEx As ThumbnailEx, ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If sender.GetType Is GetType(ThumbnailEx) Then
            Dim pDest As Point = thumbnailEx.PointToClient(New Point(e.X, e.Y))
            If thumbnailEx.ItemCount = 0 Or thumbnailEx.GetItemAt(pDest.X, pDest.Y) <> -1 Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub


    Private Sub ThumbnailEx1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ThumbnailEx1.DragDrop
        performDragDrop(ThumbnailEx2, ThumbnailEx1, e.X, e.Y)
    End Sub


    Private Sub ThumbnailEx1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ThumbnailEx1.DragEnter
        setDragEffect(ThumbnailEx1, sender, e)
    End Sub


    Private Sub ThumbnailEx1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ThumbnailEx1.DragOver
        setDragEffect(ThumbnailEx1, sender, e)
    End Sub


    Private Sub ThumbnailEx2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ThumbnailEx2.DragDrop
        performDragDrop(ThumbnailEx1, ThumbnailEx2, e.X, e.Y)
    End Sub


    Private Sub ThumbnailEx2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ThumbnailEx2.DragEnter
        setDragEffect(ThumbnailEx2, sender, e)
    End Sub


    Private Sub ThumbnailEx2_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ThumbnailEx2.DragOver
        setDragEffect(ThumbnailEx2, sender, e)
    End Sub
End Class
