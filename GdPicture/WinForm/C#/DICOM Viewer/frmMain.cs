using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using GdPicture14;
using System.IO;

namespace GdPicture_DICOM_Viewer
{
    public partial class frmMain : Form
    {
        private enum OpenMode
        {
            OpenModeUnknown = 0,
            OpenModeFile = 1,
            OpenModeFolder = 2
        }

        private enum MouseMode
        {
            MouseModeDefault = 0,
            MouseModeWindowLeveling = 1
        }

        private readonly GdPictureImaging _gdPictureImaging;

        private int _nativeImageId;

        private OpenMode _openMode = OpenMode.OpenModeUnknown;

        private MouseMode _mouseMode = MouseMode.MouseModeWindowLeveling;

        private int _windowWidth;

        private int _windowLevel;

        private Timer _timer;

        private int _imagesCount;


        public frmMain()
        {
            _gdPictureImaging = new GdPictureImaging();
            InitializeComponent();
        }


        public int NativeImageId
        {
            get
            {
                return _nativeImageId;
            }
        }


        public void frmMain_Load(System.Object sender, System.EventArgs e)
        {
            LicenseManager licenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            licenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
            SplitContainer1.SplitterDistance = 620;
            _timer = new Timer();
            //If you need to set a different animation speed, this is the value you want to change (in milliseconds)
            //_timer.Interval = 1000;
            _timer.Tick += new EventHandler(DispatcherTimer_Tick);
        }


        public void OpenToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CloseDocument();

            OpenFileDialog fdl = new OpenFileDialog();
            fdl.Filter = "DICOM files (*.dcm)|*.dcm|All files (*.*)|*.*";
            if (fdl.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = fdl.FileName;
                if (GdPictureDocumentUtilities.GetDocumentFormat(filePath) == GdPicture14.DocumentFormat.DocumentFormatDICOM)
                {
                    _nativeImageId = _gdPictureImaging.CreateGdPictureImageFromFile(filePath);
                    if (_nativeImageId != 0)
                    {
                        _imagesCount = Math.Max(_gdPictureImaging.DicomGetPageCount(_nativeImageId), 1);
                        _openMode = OpenMode.OpenModeFile;
                        GdViewer1.DisplayFromGdPictureImage(_nativeImageId);
                        ThumbnailEx1.LoadFromGdPictureImage(_nativeImageId);
                        GdViewer1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Unable to open the selected DICOM file, the error is: " + _gdPictureImaging.GetStat(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("The selected file was not recognized as a DICOM file", "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }


        public void OpenDirectoryToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CloseDocument();

            FolderBrowserDialog fdl = new FolderBrowserDialog();
            if (fdl.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string folderPath = fdl.SelectedPath;
                List<string> inputFiles = new List<string>();
                FileInfo[] fifs = new DirectoryInfo(folderPath).GetFiles();

                //list the names of all files in the specified directory
                foreach (FileInfo fif in fifs)
                {
                    string currentFile = fif.FullName;
                    if (GdPictureDocumentUtilities.GetDocumentFormat(currentFile) == GdPicture14.DocumentFormat.DocumentFormatDICOM)
                    {
                        inputFiles.Add(currentFile);
                    }
                }

                if (inputFiles.Count > 0)
                {
                    _imagesCount = inputFiles.Count;
                    _openMode = OpenMode.OpenModeFolder;
                    ThumbnailEx1.LoadFromFiles(inputFiles.ToArray());
                    ThumbnailEx1.SelectItem(0);
                    GdViewer1.Focus();
                }
                else
                {
                    MessageBox.Show("The selected folder does not include any recognized DICOM file", "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
        }


        public void ThumbnailEx1_ItemSelectionChanged(int Idx, bool Selected)
        {
            if (Selected)
            {
                switch (_openMode)
                {
                    case OpenMode.OpenModeFile:
                        _gdPictureImaging.DicomSelectPage(_nativeImageId, Idx + 1);

                        if (_mouseMode == MouseMode.MouseModeWindowLeveling)
                        {
                            if (_windowWidth != 0 && (_windowWidth != _gdPictureImaging.DicomGetDefaultWindowWidth(_nativeImageId) || _windowLevel != _gdPictureImaging.DicomGetDefaultWindowLevel(_nativeImageId)))
                            {
                                _gdPictureImaging.DicomSetWindowLevel(_nativeImageId, _windowWidth, _windowLevel);
                            }
                        }
                        GdViewer1.Redraw();
                        break;
                    case OpenMode.OpenModeFolder:
                        string srcPath = ThumbnailEx1.GetItemFileSource(Idx);
                        GdViewer1.CloseDocument();
                        _gdPictureImaging.ReleaseGdPictureImage(_nativeImageId);
                        _nativeImageId = _gdPictureImaging.CreateGdPictureImageFromFile(srcPath);
                        if (_nativeImageId != 0)
                        {
                            if (_mouseMode == MouseMode.MouseModeWindowLeveling)
                            {
                                if (_windowWidth != 0 && (_windowWidth != _gdPictureImaging.DicomGetDefaultWindowWidth(_nativeImageId) || _windowLevel != _gdPictureImaging.DicomGetDefaultWindowLevel(_nativeImageId)))
                                {
                                    _gdPictureImaging.DicomSetWindowLevel(_nativeImageId, _windowWidth, _windowLevel);
                                }
                            }
                            GdViewer1.DisplayFromGdPictureImage(_nativeImageId);
                        }
                        else
                        {
                            MessageBox.Show("Image could not be loaded", _gdPictureImaging.GetStat().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        break;
                }
            }
        }


        public void CloseToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CloseDocument();
        }


        public void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            Close();
        }


        public void GotoFirstPageToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ThumbnailEx1.SelectItem(0);
        }


        private int GetSelectedItemIdx()
        {
            for (int i = 0; i <= ThumbnailEx1.ItemCount - 1; i++)
            {
                if (ThumbnailEx1.GetItemSelectState(i))
                {
                    return i;
                }
            }

            return -1;
        }


        private void DisplayFrame(int frame)
        {
            ThumbnailEx1.SelectItem(frame - 1);
        }


        private void DisplayNext()
        {
            if (_imagesCount > 1)
            {
                int selectedIdx = GetSelectedItemIdx();
                if (selectedIdx + 1 < _imagesCount)
                {
                    ThumbnailEx1.SelectItem(selectedIdx + 1);
                }
                else
                {
                    DisplayFrame(1);
                }
            }
        }


        private void DisplayPrevious()
        {
            if (_imagesCount > 1)
            {
                ThumbnailEx1.SelectItem(GetSelectedItemIdx() - 1);
            }
        }


        public void GotoPreviousPageToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ThumbnailEx1.SelectItem(GetSelectedItemIdx() - 1);
        }


        public void GotoNextPageToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ThumbnailEx1.SelectItem(GetSelectedItemIdx() + 1);
        }


        public void GotoLastPageToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ThumbnailEx1.SelectItem(ThumbnailEx1.ItemCount - 1);
        }


        public void Rotate90ToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.Rotate90FlipNone);
        }


        public void Rotate180ToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.Rotate180FlipNone);
        }


        public void Rotate270ToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.Rotate270FlipNone);
        }


        public void FlipXToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.RotateNoneFlipX);
        }


        private void CloseDocument()
        {
            _windowWidth = 0;
            _windowLevel = 0;
            GdViewer1.CloseDocument();
            ThumbnailEx1.ClearAllItems();
            _openMode = OpenMode.OpenModeUnknown;
            this.StatusStrip1.Text = "";
            if (_nativeImageId != 0)
            {
                _gdPictureImaging.ReleaseGdPictureImage(_nativeImageId);
                _nativeImageId = 0;
            }
            _imagesCount = 0;
        }


        public void ToolStripMenuItem10_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.PrintSetDocumentName("GdPicture Document Viewer Printing");
            GdViewer1.PrintDialog(this);
        }


        public void ToolStripMenuItem11_Click(System.Object sender, System.EventArgs e)
        {
            frmProperties oForm = new frmProperties();
            oForm.Show(this);
        }


        public void Small64X64ToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new Size(64, 64);
            Small64X64ToolStripMenuItem.Checked = true;
            Medium128X128ToolStripMenuItem.Checked = false;
            Large256256ToolStripMenuItem.Checked = false;
        }


        public void Medium128X128ToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new Size(128, 128);
            Small64X64ToolStripMenuItem.Checked = false;
            Medium128X128ToolStripMenuItem.Checked = true;
            Large256256ToolStripMenuItem.Checked = false;
        }


        public void Large256256ToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            ThumbnailEx1.ThumbnailSize = new Size(256, 256);
            Small64X64ToolStripMenuItem.Checked = false;
            Medium128X128ToolStripMenuItem.Checked = false;
            Large256256ToolStripMenuItem.Checked = true;
        }


        public void GdViewer1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (_mouseMode == MouseMode.MouseModeWindowLeveling)
                {

                    int mouseX = Math.Max(0, Math.Min(e.X, GdViewer1.Width));
                    int mouseY = Math.Max(0, Math.Min(e.Y, GdViewer1.Height));

                    int newWW = Math.Max((int)(_gdPictureImaging.DicomGetMaxWindowWidth(_nativeImageId) / GdViewer1.Width * mouseX), 1);
                    float wlRange = _gdPictureImaging.DicomGetMaxWindowLevel(_nativeImageId) - _gdPictureImaging.DicomGetMinWindowLevel(_nativeImageId);
                    int newWL = (int)(_gdPictureImaging.DicomGetMinWindowLevel(_nativeImageId) + ((wlRange / GdViewer1.Height) * mouseY));
                    if (newWW != _windowWidth | newWL != _windowLevel)
                    {
                        _windowWidth = newWW;
                        _windowLevel = newWL;
                        if (_openMode == OpenMode.OpenModeFile)
                        {
                            //trick: the thumbnail control can change the current used page no
                            _gdPictureImaging.DicomSelectPage(_nativeImageId, GetSelectedItemIdx() + 1);
                        }
                        if (_gdPictureImaging.DicomSetWindowLevel(_nativeImageId, _windowWidth, _windowLevel) == GdPictureStatus.OK)
                        {
                            GdViewer1.Redraw();
                        }
                    }
                }
            }
        }


        public void GdViewer1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                DisplayNext();
            }
            else
            {
                DisplayPrevious();
            }
        }


        public void GdViewer1_PageDisplayed()
        {
            ToolStripStatusLabel1.Text = "Frame No : " + GdViewer1.CurrentPage.ToString().Trim() + " / " + GdViewer1.PageCount.ToString().Trim() + "   -   " + "Zoom : " +
                Math.Round(GdViewer1.Zoom * 100, 2).ToString().Trim() + ("%    -   " + "Image Size (pixels) : " + GdViewer1.PageWidth.ToString().Trim() + " * " +
                GdViewer1.PageHeight.ToString().Trim() + "   -   " + "Output Pixel Format : " + _gdPictureImaging.GetPixelFormat(_nativeImageId));
        }


        public void FlipYToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.Rotate(RotateFlipType.RotateNoneFlipY);
        }


        public void GdViewer1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (_nativeImageId != 0)
            {
                if (_mouseMode == MouseMode.MouseModeDefault | _windowWidth == 0)
                {
                    _windowWidth = (int)(_gdPictureImaging.DicomGetDefaultWindowWidth(_nativeImageId));
                    _windowLevel = (int)(_gdPictureImaging.DicomGetDefaultWindowLevel(_nativeImageId));
                }

                using (Font f = new Font("Times New Roman", 20, System.Drawing.FontStyle.Bold, GraphicsUnit.Pixel))
                {
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString("WL: " + _windowLevel + " / WW: " + _windowWidth, f, Brushes.Red, new RectangleF(0, 0, GdViewer1.Width - 10, 50), sf);
                    }
                }
            }
        }


        public void RestoreDefaultToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            _windowWidth = (int)(_gdPictureImaging.DicomGetDefaultWindowWidth(_nativeImageId));
            _windowLevel = (int)(_gdPictureImaging.DicomGetDefaultWindowLevel(_nativeImageId));
            if (_gdPictureImaging.DicomSetWindowLevel(_nativeImageId, _windowWidth, _windowLevel) == GdPictureStatus.OK)
            {
                GdViewer1.Redraw();
            }
        }


        public void EnableWindowLevelingToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            EnableWindowLevelingToolStripMenuItem.Checked = !EnableWindowLevelingToolStripMenuItem.Checked;
            if (EnableWindowLevelingToolStripMenuItem.Checked)
            {
                _mouseMode = MouseMode.MouseModeWindowLeveling;
            }
            else
            {
                _mouseMode = MouseMode.MouseModeDefault;
            }
        }


        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            DisplayNext();
        }
    }
}
