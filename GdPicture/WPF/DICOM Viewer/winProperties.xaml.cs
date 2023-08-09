using GdPicture14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DicomViewer
{
    class Item
    {
        public string tagID { get; set; }
        public string desc { get; set; }
        public string value { get; set; }
    }

    /// <summary>
    /// Interaction logic for winProperties.xaml
    /// </summary>
    public partial class winProperties : Window
    {
        

        public winProperties()
        {
            InitializeComponent();
            int ImageID = (Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow).getNativeImage();
            using (GdPictureImaging oGdPictureImaging = new GdPictureImaging())
            {
                int tagsCount = oGdPictureImaging.DicomGetTagsCount(ImageID);
                for (int i = 0; i <= tagsCount - 1; i++)
                {
                    int group = oGdPictureImaging.DicomGetTagGroup(ImageID, i);
                    int elem = oGdPictureImaging.DicomGetTagElement(ImageID, i);
                    if (elem != 0 || group != 0)
                    {
                        string TagID = "<" + String.Format("{0:X}", (group)).PadLeft(4, '0') + "," + String.Format("{0:X}", (elem)).PadLeft(4, '0') + ">";
                        grdTags.Items.Add(new Item() { tagID = TagID, desc = oGdPictureImaging.DicomGetTagDescription(ImageID, i), value = oGdPictureImaging.DicomGetTagValue(ImageID, i) });
                    }
                }
            }
        }
    }
}
