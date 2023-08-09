using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.ComponentModel;
using System.Threading.Tasks;
using GdPicture14;

namespace DicomViewer
{
    public partial class winLoadingProgression : Window
    {
        private BackgroundWorker m_bgWorker;
        private int m_filesCount;
        MainWindow m_winMain;
        private int progress;
        public winLoadingProgression()
        {
            InitializeComponent();
            m_bgWorker = new BackgroundWorker();
            m_bgWorker.WorkerSupportsCancellation = true;
            m_bgWorker.WorkerReportsProgress = true;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            progress = 0;
            m_winMain = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
            m_filesCount = m_winMain.InputFiles.Count;
            pgBar.Maximum = m_filesCount;
            m_bgWorker.DoWork += new DoWorkEventHandler(m_bgWorker_DoWork);
            m_bgWorker.ProgressChanged += new ProgressChangedEventHandler(m_bgWorker_ProgressChanged);
            m_bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_bgWorker_RunWorkerCompleted);

            m_bgWorker.RunWorkerAsync();
        }


        private void m_bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress++;
            pgBar.Value = progress;
            lbStatus.Content = progress.ToString() + " / " + m_filesCount.ToString();
        }


        private void m_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Action<int> curIdx = y =>
             {
                 using (GdPictureImaging oGdPictureImaging = new GdPictureImaging())
                 {
                     int ImageID = oGdPictureImaging.CreateGdPictureImageFromFile(m_winMain.InputFiles[y]);
                     m_winMain.CachedBitmaps[y] = ImageID;
                     m_bgWorker.ReportProgress(0);
                 }
             };
            Parallel.For(0, m_filesCount, curIdx);
        }

        private void m_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }
    }
}
