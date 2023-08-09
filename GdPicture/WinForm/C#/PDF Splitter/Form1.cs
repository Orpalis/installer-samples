using GdPicture14;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace pdf_splitter
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent(); if (transDefaultFormForm1 == null) transDefaultFormForm1 = this;
            base.Load += new System.EventHandler(Form1_Load);

        }

        private void Form1_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            TextBox3.Text = Application.StartupPath + @"\";
        }



        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            OpenFileDialog1.Multiselect = false;
            OpenFileDialog1.Filter = "PDF Document (*.pdf)|*.pdf";
            OpenFileDialog1.FileName = "";

            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBox2.Text = OpenFileDialog1.FileName;
            }
        }



        private void Button2_Click(System.Object sender, System.EventArgs e)
        {

            if (FolderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBox3.Text = FolderBrowserDialog1.SelectedPath + @"\";
            }
        }



        private void Button3_Click(System.Object sender, System.EventArgs e)
        {
            string sImagepath = TextBox2.Text;
            int SplitEach = 0;
            string OutputFolder = TextBox3.Text;
            GdPictureStatus Status = GdPictureStatus.OK;
            GdPicturePDF oGdPicturePDFSrc = new GdPicturePDF();

            Button3.Enabled = false;

            
            try
            {
                // prevent for overflow exception
                SplitEach = Convert.ToInt32(TextBox1.Text);
            }
            catch (Exception)
            {

            }

            if (SplitEach > 0)
            {

                if (oGdPicturePDFSrc.LoadFromFile(sImagepath, false) == GdPictureStatus.OK)
                {

                    // Check for encryption
                    if (oGdPicturePDFSrc.IsEncrypted())
                    {
                        if (oGdPicturePDFSrc.SetPassword("") != GdPictureStatus.OK)
                        {
                            String value = "";
                            String PassWord = "";
                            if (InputBox("", "Enter PDF password:", ref value) == DialogResult.OK)
                            {
                                PassWord = value;
                            }
                            if (oGdPicturePDFSrc.SetPassword(PassWord) != GdPictureStatus.OK)
                            {
                                MessageBox.Show("Can not uncrypt document");
                                oGdPicturePDFSrc.CloseDocument();
                                return;
                            }
                        }
                    }

                    // Checking if the document is  multipage 
                    int PageCount = oGdPicturePDFSrc.GetPageCount();
                    if (PageCount > 1)
                    {
                        // Getting the initial compression scheme
                        int CurrentPage = 0;
                        string OutputFilePath = null;
                        int OutputFileCount = System.Convert.ToInt32(Math.Ceiling((double)PageCount / SplitEach));

                        ProgressBar1.Maximum = PageCount;

                        for (int i = 1; i <= OutputFileCount; i++)
                        {
                            GdPicturePDF oGdPicturePDFDest = new GdPicturePDF();
                            Status = oGdPicturePDFDest.NewPDF();
                            OutputFilePath = OutputFolder + "split" + i.ToString() + ".pdf";

                            for (int j = 1; j <= SplitEach; j++)
                            {
                                CurrentPage = CurrentPage + 1;
                                if (CurrentPage <= PageCount & Status == GdPictureStatus.OK)
                                {
                                    if (oGdPicturePDFDest.ClonePage(oGdPicturePDFSrc, CurrentPage) != GdPictureStatus.OK)
                                        MessageBox.Show("Cannot clone image: " + oGdPicturePDFDest.GetStat().ToString());
                                    ProgressBar1.Value = CurrentPage;
                                    Application.DoEvents();
                                }
                            }
                            if ((oGdPicturePDFDest.RemoveUnusedResources() != GdPictureStatus.OK) ||
                                (oGdPicturePDFDest.SaveToFile(OutputFilePath, true) != GdPictureStatus.OK))
                                MessageBox.Show("Error: " + oGdPicturePDFDest.GetStat().ToString());
                            if (oGdPicturePDFDest.CloseDocument() != GdPictureStatus.OK)
                                MessageBox.Show("Cannot close image: " + oGdPicturePDFDest.GetStat().ToString());
                        }

                        if (Status == GdPictureStatus.OK)
                        {
                            MessageBox.Show("Success !");
                        }
                        else
                        {
                            MessageBox.Show("Error: ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, The PDF is not a multipage document.");
                    }

                    if (oGdPicturePDFSrc.CloseDocument() != GdPictureStatus.OK)
                        MessageBox.Show("Cannot close image: " + oGdPicturePDFSrc.GetStat().ToString());
                }
                else
                {
                    MessageBox.Show("Error, Can't open document: " + sImagepath);
                }
            }
            else
            {
                MessageBox.Show("Error, Incorrect value for split each.");
            }
            Button3.Enabled = true;
        }

        [STAThread]
        public static void Main() { Application.Run(new Form1()); }

        private static Form1 transDefaultFormForm1 = null;
        public static Form1 TransDefaultFormForm1
        {
            get
            {
                if (transDefaultFormForm1 == null)
                {
                    transDefaultFormForm1 = new Form1();
                }
                return transDefaultFormForm1;
            }
        }

        private static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

    }

} 
