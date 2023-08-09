using GdPicture14;
using System.Drawing;
using System.Windows.Forms;

namespace thumbnail_drag_drop
{
    public partial class Form1
    {
        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            ThumbnailEx1.AllowDrop = true;
            ThumbnailEx1.OwnDrop = true;

            ThumbnailEx2.AllowDrop = true;
            ThumbnailEx2.OwnDrop = true;
        }



        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ThumbnailEx1.LoadFromDirectory(folderBrowserDialog.SelectedPath, chkIncludeSubfolders.Checked);
                }
            }

        }



        private void PerformDragDrop(ThumbnailEx sender, ThumbnailEx receiver, int x, int y)
        {
            int itemDestIdx = 0;

            if (receiver.ItemCount > 0)
            {
                Point pDest = receiver.PointToClient(new Point(x, y));
                itemDestIdx = receiver.GetItemAt(pDest.X, pDest.Y);
                if (itemDestIdx == -1)
                {
                    return; // we should never reach this point
                }
            }

            for (int i = sender.ItemCount - 1; i >= 0; i += -1)
            {
                if (sender.GetItemSelectState(i)) // If item is selected
                {
                    int itemBitmap = sender.GetItemBitmap(i);
                    if (itemBitmap != 0)
                    {
                        bool insert = true;
                        string itemText = sender.GetItemText(i);
                        if (receiver.ItemCount > 0)
                        {
                            if (chkMoveAfter.Checked)
                            {
                                if (itemDestIdx == receiver.ItemCount - 1)
                                {
                                    insert = false;
                                }
                                else
                                {
                                    itemDestIdx += 1;
                                }
                            }
                        }
                        else
                        {
                            insert = false;
                        }

                        GdPictureStatus status = insert ? receiver.InsertItemFromGdPictureImage(itemBitmap, itemText, itemDestIdx) : 
                            receiver.AddItemFromGdPictureImage(itemBitmap, itemText);

                        if (status == GdPictureStatus.OK)
                        {
                            sender.RemoveItem(i);
                        }
                        else
                        {
                            MessageBox.Show("Error, can't add item " + i);
                        }
                        sender.ReleaseGdPictureImage(itemBitmap);
                    }
                    else
                    {
                        MessageBox.Show("Error, can't export item bitmap for index " + i);
                    }
                }
            }
        }


        // For avoiding duplicated code purposes.
        private void SetDragEffect(ThumbnailEx thumbnailEx, object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (sender is ThumbnailEx)
            {
                Point pDest = thumbnailEx.PointToClient(new Point(e.X, e.Y));
                if (thumbnailEx.ItemCount == 0 | thumbnailEx.GetItemAt(pDest.X, pDest.Y) != -1)
                {
                    e.Effect = DragDropEffects.Move;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }



        private void ThumbnailEx1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            PerformDragDrop(ThumbnailEx2, ThumbnailEx1, e.X, e.Y);
        }



        private void ThumbnailEx1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            SetDragEffect(ThumbnailEx1, sender, e);
        }



        private void ThumbnailEx1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            SetDragEffect(ThumbnailEx1, sender, e);
        }



        private void ThumbnailEx2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            PerformDragDrop(ThumbnailEx1, ThumbnailEx2, e.X, e.Y);
        }



        private void ThumbnailEx2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            SetDragEffect(ThumbnailEx2, sender, e);
        }



        private void ThumbnailEx2_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            SetDragEffect(ThumbnailEx2, sender, e);
        }

    }

}
