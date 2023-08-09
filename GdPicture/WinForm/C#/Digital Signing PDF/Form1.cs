using System;
using System.Windows.Forms;
using GdPicture14;

namespace CSharp_PDFSigner
{
    public partial class Form1 : Form
    {
        string m_FileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GdPicture14.LicenseManager oLicenceManager = new GdPicture14.LicenseManager(); //Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.
            oLicenceManager.RegisterKEY("XXX");//Please, replace XXX by a valid demo or commercial license key. 

            cmdSIgnaturePanel.Enabled = false;

        }



        private void cmdNewFunction_Click(object sender, EventArgs e)
        {
            frmNewFunctions frmNewFunct = new frmNewFunctions(m_FileName);
            frmNewFunct.ShowDialog(this);
        }

        private void cmdParcPdf_Click(object sender, EventArgs e)
        {
            FileDialog FD = new OpenFileDialog();
            FD.Filter = "Pdf files|*.pdf|All files|*.*";
            FD.ShowDialog();
            if (FD.FileName == "")
                return;
            m_FileName = FD.FileName;
            txtPdfFileName.Text = m_FileName;


            if (GdViewer1.DisplayFromFile(m_FileName) == GdPictureStatus.OK)
            {
                GdViewer1.Visible = true;
                DocumentType Document = GdViewer1.GetDocumentType();
                if (Document != DocumentType.DocumentTypePDF)
                {
                    MessageBox.Show("The file is not a PDF document.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    cmdSIgnaturePanel.Enabled = true;
                }

            }

        }
    }
}
