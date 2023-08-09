using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GdPicture14;

namespace Thumbnail_WPF___Drag_and_Drop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseManager licenseManager = new LicenseManager();
            licenseManager.RegisterKEY("XXXX"); // Please, replace XXXX by a valid demo or commercial license key. 
            // Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.

            thumbnailExWPF1.AllowDrop = true;
            thumbnailExWPF2.AllowDrop = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    thumbnailExWPF1.LoadFromDirectory(folderBrowserDialog.SelectedPath, (bool)chkIncludeSubfolders.IsChecked);
                }
            }
        }

        private void setDragEffect(GdPicture14.WPF.ThumbnailEx thumbnailEx, object sender, System.Windows.DragEventArgs e)
        {
            if (sender.GetType() == typeof(GdPicture14.WPF.ThumbnailEx))
            {
                if (thumbnailEx.ItemCount == 0 | thumbnailEx.GetItemAt(e.GetPosition(thumbnailEx).X, e.GetPosition(thumbnailEx).Y) != -1)
                {
                    e.Effects = System.Windows.DragDropEffects.Move;
                }
                else
                {
                    e.Effects = System.Windows.DragDropEffects.None;
                }
            }
            else
            {
                e.Effects = System.Windows.DragDropEffects.None;
            }
            e.Handled = true;
        }

        private void performDragDrop(GdPicture14.WPF.ThumbnailEx sender, GdPicture14.WPF.ThumbnailEx receiver, double X, double Y)
        {
            int itemDestIdx = 0;

            if (receiver.ItemCount > 0)
            {
                itemDestIdx = receiver.GetItemAt(X, Y);
                if ((itemDestIdx == -1))
                {
                    return; 
                }
            }

            for (int i = sender.ItemCount - 1; i >= 0; i += -1)
            {
                if (sender.GetItemSelectState(i))
                {
                    
                    BitmapSource itemBitmap = sender.GetItemBitmap(i);
                    if (itemBitmap != null)
                    {
                        bool insert = true;
                        GdPictureStatus status = 0;
                        string itemText = sender.GetItemText(i);
                        if (receiver.ItemCount > 0)
                        {
                            if (chkMoveAfter.IsChecked == true)
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

                        if (insert)
                        {
                         
                            status = receiver.InsertItemFromBitmapSource(itemBitmap, itemText, itemDestIdx);
                        }
                        else
                        {
                            status = receiver.AddItemFromBitmapSource(itemBitmap, itemText);
                        }
                        if (status == GdPictureStatus.OK)
                        {
                            sender.RemoveItem(i);
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Error, can't add item " + i.ToString());
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Error, can't export item bitmap for index " + i.ToString());
                    }

                }
            }
        }

        private void thumbnailExWPF1_DragEnter(object sender, System.Windows.DragEventArgs e)
        {
            setDragEffect(thumbnailExWPF1, sender, e);
        }


        private void thumbnailExWPF1_DragOver(object sender, System.Windows.DragEventArgs e)
        {
            setDragEffect(thumbnailExWPF1, sender, e);
        }

        private void thumbnailExWPF1_Drop(object sender, System.Windows.DragEventArgs e)
        {
            Point p = e.GetPosition(thumbnailExWPF1);
            performDragDrop(thumbnailExWPF2, thumbnailExWPF1, p.X, p.Y); 
        }

        private void thumbnailExWPF2_DragEnter(object sender, System.Windows.DragEventArgs e)
        {
            setDragEffect(thumbnailExWPF2, sender, e);
        }

        private void thumbnailExWPF2_DragOver(object sender, System.Windows.DragEventArgs e)
        {
            setDragEffect(thumbnailExWPF2, sender, e);
        }

        private void thumbnailExWPF2_Drop(object sender, System.Windows.DragEventArgs e)
        {
            Point p = e.GetPosition(thumbnailExWPF2);
            performDragDrop(thumbnailExWPF1, thumbnailExWPF2, p.X, p.Y); 
        }

        

    }
}
