using System;
using System.IO;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;
using System.Diagnostics;
using System.Windows.Media;

using GdPicture14;



namespace DicomViewer
{
    public partial class MainWindow : Window
    {
        internal int getNativeImage()
        {
            return m_ImageID;
        }

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

        private GdPictureImaging m_GdPictureImaging = new GdPictureImaging();
        private int m_ImageID;
        private int m_ImagesCount;
        private OpenMode m_openMode = OpenMode.OpenModeUnknown;
        private MouseMode m_mouseMode = MouseMode.MouseModeDefault;

        private float m_ww; //Current windows width
        private float m_wl; //Current windows level
        private bool m_animating;


  
        private DispatcherTimer m_dispatcherTimer;
        private Stopwatch m_stopwatch = new Stopwatch();
        private long m_TickCount;

        public List<string> InputFiles=new List<string>();
        public List<int> CachedBitmaps =new List<int>();



        public MainWindow()
        {
            InitializeComponent();

            new GdPicture14.LicenseManager().RegisterKEY("XXX"); //Please replace XXX by a valid demo or commercial key

            sliderSpeed.Value = Config.speed; //we should use databinding
            ThumbnailEx1.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 58, 58, 58));
            CloseDocument();//to reset UI
            m_dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            m_dispatcherTimer.Tick += new EventHandler(m_dispatcherTimer_Tick);

            updateTimerInterval();
        }


        private void resetFPS()
        {
            m_TickCount = 0;
            m_stopwatch.Restart();

        }

        private void updateTimerInterval()
        {
            if (m_dispatcherTimer != null)
            {
                m_dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / Config.speed);
            }
        }


        private void m_dispatcherTimer_Tick(object sender, EventArgs e)
        {
            displayNext();
            m_TickCount += 1;
        }

        private void endAnimation()
        {
            if (m_animating)
            {
                m_dispatcherTimer.Stop();
                m_animating = false;
                btAnimate.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 58, 58, 58));
            }
            grdFPS.Visibility = System.Windows.Visibility.Hidden;
            showLabelInfo();

            lbFPS.Text = "";
        }

        private void startAnimation()
        {
            if (!m_animating && m_ImageID != 0)
            {
                resetFPS();
                m_TickCount = 0;
                m_dispatcherTimer.Start();
                m_animating = true;
                btAnimate.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 100, 100, 100));
                lbWindow.Text = "";
                lbFrame.Text = "";
                lbTag.Text = "";
                grdFPS.Visibility = System.Windows.Visibility.Visible;
            }
        }



        private void endAdjustWindow()
        {
            if (m_mouseMode == MouseMode.MouseModeWindowLeveling)
            {
                m_mouseMode = MouseMode.MouseModeDefault;
                btWindowAdjust.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 58, 58, 58));
                doDefaultWindow();
                GdViewer1.Cursor = System.Windows.Input.Cursors.Arrow;
            }
        }

        private void startAdjustWindow()
        {
            if (m_ImageID != 0)
            {
                if (m_mouseMode != MouseMode.MouseModeWindowLeveling)
                {
                    m_mouseMode = MouseMode.MouseModeWindowLeveling;
                    btWindowAdjust.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 100, 100, 100));
                    GdViewer1.Cursor = System.Windows.Input.Cursors.SizeAll;
                }
            }
        }

        private void CloseDocument()
        {
            m_ww = 0;
            m_wl = 0;
            GdViewer1.CloseDocument();
            ThumbnailEx1.ClearAllItems();

            endAnimation();
            lbWindow.Text = "";
            lbFrame.Text = "";
            lbTag.Text = "";

            switch (m_openMode)
            {
                case OpenMode.OpenModeFile:
                    if (m_ImageID != 0)
                    {
                        m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID);
                    }
                    break;
                case OpenMode.OpenModeFolder:
                    if (Config.preloadImages)
                    {
                        for (int i = 0; i < m_ImagesCount; i++)
                        {
                            m_GdPictureImaging.ReleaseGdPictureImage(CachedBitmaps[i]);
                        }
                    }
                    else
                    {
                        if (m_ImageID != 0)
                        {
                            m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID);
                        }
                    }
                    break;
            }

            m_ImageID = 0;
            m_openMode = OpenMode.OpenModeUnknown;
            sbFrames.Value = 0;
            sbFrames.Maximum = 0;
            sbFrames.IsEnabled = false;
            InputFiles.Clear();
            CachedBitmaps.Clear();
            m_ImagesCount = 0;
        }

        private int getSelectedItemIdx()
        {
            for (int i = 0; i < m_ImagesCount; i++)
            {
                if (ThumbnailEx1.GetItemSelectState(i))
                {
                    return i;
                }
            }

            return -1;
        }

        private void displayFrame(int frame)
        {
            ThumbnailEx1.SelectItem(frame - 1);
        }

        private void displayNext()
        {
            if (m_ImagesCount > 1)
            {
                int selectedIdx = getSelectedItemIdx();
                if (selectedIdx + 1 < m_ImagesCount)
                {
                    ThumbnailEx1.SelectItem(selectedIdx + 1);
                }
                else
                {
                    displayFrame(1);
                }
            }
        }

        private void displayPrevious()
        {
            if (m_ImagesCount > 1)
            {
                ThumbnailEx1.SelectItem(getSelectedItemIdx() - 1);
            }
        }

        private void displayLast()
        {
            ThumbnailEx1.SelectItem(m_ImagesCount - 1);
        }

        private void displayFirst()
        {
            ThumbnailEx1.SelectItem(0);
        }

        private void onNewLoaded()
        {
            resetFPS();
            switch (m_openMode)
            {
                case OpenMode.OpenModeFile:
                    GdViewer1.DisplayFromGdPictureImage(m_ImageID);
                    ThumbnailEx1.LoadFromGdPictureImage(m_ImageID);
                    break;
                case OpenMode.OpenModeFolder:

                    ThumbnailEx1.LoadFromFiles(InputFiles.ToArray());
                    ThumbnailEx1.SelectItem(0);
                    break;
            }
            sbFrames.Maximum = m_ImagesCount;
            sbFrames.IsEnabled = true;
            GdViewer1.Focus();
        }


        private void doWindow(float newWW, float newWL)
        {
            m_ww = newWW;
            m_wl = newWL;
            if (m_openMode == OpenMode.OpenModeFile)
            {
                //trick: the thumbnail control can change the current used page no
                m_GdPictureImaging.DicomSelectPage(m_ImageID, getSelectedItemIdx() + 1);
            }

            if (m_GdPictureImaging.DicomGetLastWindowWidth(m_ImageID) != m_ww | newWL != m_GdPictureImaging.DicomGetLastWindowLevel(m_ImageID))
            {
                if (m_GdPictureImaging.DicomSetWindowLevel(m_ImageID, m_ww, m_wl) == GdPictureStatus.OK)
                {
                    GdViewer1.Redraw();
                }
            }
        }


        private void doDefaultWindow()
        {
            if (m_ImageID != 0)
            {
                doWindow(m_GdPictureImaging.DicomGetDefaultWindowWidth(m_ImageID), m_GdPictureImaging.DicomGetDefaultWindowLevel(m_ImageID));
            }
        }

        private void showLabelInfo()
        {
            m_ww = m_GdPictureImaging.DicomGetLastWindowWidth(m_ImageID);
            m_wl = m_GdPictureImaging.DicomGetLastWindowLevel(m_ImageID);

            lbWindow.Text = "WL: " + (Math.Round(m_wl)).ToString() + " / WW: " + (Math.Round(m_ww)).ToString();
            lbTag.Text = "";
            lbTag.TextAlignment = System.Windows.TextAlignment.Right;
            int tagsCount = m_GdPictureImaging.DicomGetTagsCount(m_ImageID);
            for (int i = 0; i < tagsCount; i++)
            {
                int tagEle = m_GdPictureImaging.DicomGetTagElement(m_ImageID, i);
                int tagGroup = m_GdPictureImaging.DicomGetTagGroup(m_ImageID, i);
                if (tagGroup == 0x10 && tagEle == 0x10)
                {//Patient's Name
                    if (lbTag.Text != "") lbTag.Text += Environment.NewLine;
                    lbTag.Text += "Patient's Name: " + m_GdPictureImaging.DicomGetTagValue(m_ImageID, i);
                }
                else if (tagGroup == 0x08 && tagEle == 0x1030)
                {//Study Description:
                    if (lbTag.Text != "") lbTag.Text += Environment.NewLine;
                    lbTag.Text += "Study Description: " + m_GdPictureImaging.DicomGetTagValue(m_ImageID, i);
                }
                else if (tagGroup == 0x20 && tagEle == 0x4000)
                {//Image Comments
                    if (lbTag.Text != "") lbTag.Text += Environment.NewLine;
                    lbTag.Text += "Image Comments: " + m_GdPictureImaging.DicomGetTagValue(m_ImageID, i);
                }
            }
            lbFrame.Text = "Img: " + (getSelectedItemIdx() + 1).ToString() + "/" + m_ImagesCount.ToString();
        }

        #region "GdPicture Events"


        private void GdViewer1_MouseMove(System.Object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (m_mouseMode == MouseMode.MouseModeWindowLeveling)
                {
                    System.Windows.Point p = e.GetPosition(this);
                    int mouseX = Math.Max(0, Math.Min((int)(p.X), (int)GdViewer1.ActualWidth));
                    int mouseY = Math.Max(0, Math.Min((int)(p.Y), (int)GdViewer1.ActualHeight));

                    int newWW = Math.Max((int)(m_GdPictureImaging.DicomGetMaxWindowWidth(m_ImageID) / GdViewer1.ActualWidth * mouseX), 1);
                    float wlRange = m_GdPictureImaging.DicomGetMaxWindowLevel(m_ImageID) - m_GdPictureImaging.DicomGetMinWindowLevel(m_ImageID);
                    int newWL = (int)(m_GdPictureImaging.DicomGetMinWindowLevel(m_ImageID) + ((wlRange / GdViewer1.ActualHeight) * mouseY));
                    doWindow(newWW, newWL);
                }
            }
        }

        private void GdViewer1_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta < 0)
            {
                displayNext();
            }
            else
            {
                displayPrevious();
            }
        }




        #endregion


        #region "Commands"
        private void OpenFileCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenFileCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseDocument();

            OpenFileDialog fdl = new OpenFileDialog();
            fdl.Filter = "DICOM files (*.dcm)|*.dcm|All files (*.*)|*.*";
            if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = fdl.FileName;
                if (GdPictureDocumentUtilities.GetDocumentFormat(filePath) == GdPicture14.DocumentFormat.DocumentFormatDICOM)
                {
                    m_ImageID = m_GdPictureImaging.CreateGdPictureImageFromFile(filePath);
                    if (m_ImageID != 0)
                    {
                        m_ImagesCount = Math.Max(m_GdPictureImaging.DicomGetPageCount(m_ImageID), 1);

                        m_openMode = OpenMode.OpenModeFile;
                        onNewLoaded();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Unable to open the selected DICOM file, the error is: " + m_GdPictureImaging.GetStat().ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The selected file was not recognized as a DICOM file", "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void OpenDirCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenDirCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseDocument();

            FolderBrowserDialog fdl = new FolderBrowserDialog();
            if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderPath = fdl.SelectedPath;
                FileInfo[] fifs = new DirectoryInfo(folderPath).GetFiles();

                //list the names of all files in the specified directory
                foreach (System.IO.FileInfo fif in fifs)
                {
                    string currentFile = fif.FullName;
                    if (GdPictureDocumentUtilities.GetDocumentFormat(currentFile) == GdPicture14.DocumentFormat.DocumentFormatDICOM)
                    {
                        InputFiles.Add(currentFile);
                        if (Config.preloadImages)
                        {
                            CachedBitmaps.Add(0);
                        }
                    }
                }

                if (InputFiles.Count > 0)
                {
                    m_ImagesCount = InputFiles.Count;
                    m_openMode = OpenMode.OpenModeFolder;
                    if (Config.preloadImages)
                    {
                        winLoadingProgression win = new winLoadingProgression();
                        win.Owner = this;
                        win.ShowDialog();
                    }
                    onNewLoaded();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The selected folder does not includes any recognized DICOM file", "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
        }

        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CloseDocument();
            System.Windows.Application.Current.Shutdown();
        }


        private void HelpCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void HelpCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://forums.orpalis.com/dicom-viewer.html");
            }
            catch {/*todo: display link on messagebox?*/ }
        }


        private void AboutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AboutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            winAbout win = new winAbout();
            win.Owner = this;
            win.ShowDialog();
        }


        private void AnimateCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (m_ImageID != 0) && (m_ImagesCount > 1);
        }

        private void AnimateCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (m_animating)
            {
                endAnimation();
            }
            else
            {
                startAnimation();
            }
        }


        private void CaptureCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (m_ImageID != 0);
        }


        private void CaptureCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GdPictureStatus status = GdViewer1.CopyToClipboard();
            if (status == GdPictureStatus.OK)
            {
                System.Windows.Forms.MessageBox.Show("The frame has been copied to the Clipboard.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error copying the frame to the Clipboard. Status: " + status.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AdjustWindowCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (m_ImageID != 0);
        }

        private void AdjustWindowCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (m_mouseMode == MouseMode.MouseModeWindowLeveling)
            {
                endAdjustWindow();
            }
            else
            {
                startAdjustWindow();
            }
        }

        private void DefaultWindowCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (m_ImageID != 0);
        }

        private void DefaultWindowCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            doDefaultWindow();
        }


        private void ViewTagsCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (m_ImageID != 0);
        }

        private void ViewTagsCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            winProperties win = new winProperties();
            win.Owner = this;
            win.ShowDialog();
        }
        #endregion

        #region "UI Events"
        private void sliderFPS_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int newVal = (int)sliderSpeed.Value;
            if (newVal != Config.speed)
            {
                Config.speed = newVal;
                resetFPS();
                updateTimerInterval();
            }
        }
        

        private void sbFrames_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            displayFrame((int)e.NewValue);
        }

        private void WindowMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Config.saveConfig();
        }

        #endregion

        private void ThumbnailEx1_ItemSelectionChanged(object sender, GdPicture14.WPF.ThumbnailEx.ItemSelectionChangedEventArgs e)
        {
            if (e.Selected)
            {
                sbFrames.Value = e.Idx + 1;
                switch (m_openMode)
                {
                    case OpenMode.OpenModeFile:
                        m_GdPictureImaging.DicomSelectPage(m_ImageID, e.Idx + 1);

                        if (m_mouseMode == MouseMode.MouseModeWindowLeveling)
                        {
                            if (m_ww != 0)
                            {
                                doWindow(m_ww, m_wl);
                            }
                            else
                            {
                                doDefaultWindow();
                            }
                        }
                        else
                        {
                            doDefaultWindow();
                        }

                        GdViewer1.Redraw();
                        break;
                    case OpenMode.OpenModeFolder:
                        GdViewer1.CloseDocument();
                        if (Config.preloadImages)
                        {
                            m_ImageID = CachedBitmaps[e.Idx];
                        }
                        else
                        {
                            string srcPath = InputFiles[e.Idx];

                            m_GdPictureImaging.ReleaseGdPictureImage(m_ImageID);
                            CachedBitmaps[e.Idx] = 0;
                            m_ImageID = m_GdPictureImaging.CreateGdPictureImageFromFile(srcPath);
                        }
                        if (m_ImageID != 0)
                        {
                            if (m_mouseMode == MouseMode.MouseModeWindowLeveling)
                            {
                                if (m_ww != 0)
                                {
                                    doWindow(m_ww, m_wl);
                                }
                                else
                                {
                                    doDefaultWindow();
                                }
                            }
                            else
                            {
                                doDefaultWindow();
                            }
                            GdViewer1.DisplayFromGdPictureImage(m_ImageID);
                        }
                        else
                        {
                            //todo: handle error
                        }
                        break;
                }
            }
        }

        private void GdViewer1_PageDisplayed(object sender, GdPicture14.WPF.GdViewer.PageDisplayedEventArgs e)
        {
            double WidthInches;
            double HeightInches;

            WidthInches = GdViewer1.PageInchWidth;
            HeightInches = GdViewer1.PageInchHeight;

            if (m_ImageID != 0)
            {

                if (m_animating)
                {
                    if (m_TickCount > 0)
                    {
                        double fps = (double)Math.Round((double)m_TickCount / m_stopwatch.Elapsed.TotalSeconds, 1);
                        lbFPS.Text = "FPS: " + fps.ToString();
                    }
                }
                else
                {
                    showLabelInfo();
                }
            }
        }
    }
}
