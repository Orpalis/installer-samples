using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System;

using GdPicture14;



namespace anglerotation
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }
        private GdPicturePDF m_oGdPicturePDF;
        private string m_PageContent;


        public void Form1_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
        }


        public void HScroll1_Scroll(System.Object eventSender, System.Windows.Forms.ScrollEventArgs eventArgs)
        {
            if (eventArgs.NewValue != eventArgs.OldValue)
            {
                if (m_oGdPicturePDF != null)
                {
                    float rotation = eventArgs.NewValue;
                    if (rotation != 0)
                    {
                        m_oGdPicturePDF.SetPageContent(m_PageContent); //restoring initial page content

                        if (rotation > 0) //Note: function takes anti clockwise rotation in the range [0 - 360]
                            m_oGdPicturePDF.RotatePageEx(360 - rotation);
                        else
                            m_oGdPicturePDF.RotatePageEx(-rotation);

                        GdViewer1.Redraw();
                    }
                }
            }
        }


        public void OpenToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CloseDocument();

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files (*.pdf)|*.pdf";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    m_oGdPicturePDF = new GdPicturePDF();
                    if (m_oGdPicturePDF.LoadFromFile(ofd.FileName, false) == GdPictureStatus.OK)
                    {
                        GdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
                        GdViewer1.DisplayFromGdPicturePDF(m_oGdPicturePDF);
                    }
                    else
                    {
                        CloseDocument();
                    }
                }
            }

        }


        private void CloseDocument()
        {
            if (m_oGdPicturePDF != null)
            {
                m_oGdPicturePDF.Dispose();
                GdViewer1.CloseDocument();
                m_oGdPicturePDF = null;
                m_PageContent = "";
            }
        }


        public void CloseToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CloseDocument();
        }


        public void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            CloseDocument();
            this.Close();
        }


        public void GdViewer1_PageChanged()
        {
            if (GdViewer1.CurrentPage != 0)
            {
                m_PageContent = m_oGdPicturePDF.GetPageContent();
                HScroll1.Value = 0;
            }
        }


        public void SaveToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            if (m_oGdPicturePDF != null)
            {
                using (SaveFileDialog ofs = new SaveFileDialog())
                {
                    ofs.Filter = "PDF Files (*.pdf)|*.pdf";
                    if (ofs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        m_oGdPicturePDF.SaveToFile(ofs.FileName);
                    }

                }

            }
        }


        public void Button1_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.DisplayFirstPage();
        }


        public void Button4_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.DisplayNextPage();
        }


        public void Button3_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.DisplayLastPage();
        }


        public void Button2_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.DisplayPreviousPage();
        }
    }
}
