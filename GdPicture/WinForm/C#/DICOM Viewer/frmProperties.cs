using System;
using System.Windows.Forms;
using GdPicture14;

namespace GdPicture_DICOM_Viewer
{
    public partial class frmProperties : Form
    {
        public frmProperties()
        {
            InitializeComponent();
        }

        private void frmProperties_Load(object sender, EventArgs e)
        {
            int imageId = ((frmMain)Form.ActiveForm).NativeImageId;
            using (GdPictureImaging oGdPictureImaging = new GdPictureImaging())
            {
                int tagsCount = oGdPictureImaging.DicomGetTagsCount(imageId);
                for (int i = 0; i <= tagsCount - 1; i++)
                {
                    string tagID = "<" + String.Format("{0:X}", (oGdPictureImaging.DicomGetTagGroup(imageId, i))).PadLeft(4, '0') + "," + String.Format("{0:X}", (oGdPictureImaging.DicomGetTagElement(imageId, i))).PadLeft(4, '0') + ">";
                    DataGridView1.Rows.Add(new object[] { tagID, oGdPictureImaging.DicomGetTagDescription(imageId, i), oGdPictureImaging.DicomGetTagValue(imageId, i) });
                }
            }
        }
    }
}
