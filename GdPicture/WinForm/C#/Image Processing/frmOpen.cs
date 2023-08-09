using GdPicture14;
using System;
using System.IO;
using System.Windows.Forms;

namespace Image_Processing
{
    public partial class frmOpen
    {

        private readonly GdViewer _owner;

        public frmOpen(GdViewer owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        private void UpdateUi()
        {
            if (rbOpenFromFile.Checked)
            {
                pOpenFromFile.Enabled = true;
                pOpenFromHTTP.Enabled = false;
                pOpenFromFTP.Enabled = false;
            }
            else if (rbOpenFromHTTP.Checked)
            {
                pOpenFromFile.Enabled = false;
                pOpenFromHTTP.Enabled = true;
                pOpenFromFTP.Enabled = false;
            }
            else if (rbOpenFromFTP.Checked)
            {
                pOpenFromFile.Enabled = false;
                pOpenFromHTTP.Enabled = false;
                pOpenFromFTP.Enabled = true;
            }
            else if (rbOpenFromClipboard.Checked)
            {
                pOpenFromFile.Enabled = false;
                pOpenFromHTTP.Enabled = false;
                pOpenFromFTP.Enabled = false;
            }
        }

        private void frmOpen_Load(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                rbOpenFromClipboard.Checked = true;
            }
            else
            {
                rbOpenFromFile.Checked = true;
            }
        }

        private void rbOpenFromFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpenFromFile.Checked)
            {
                UpdateUi();
            }
        }

        private void rbOpenFromFTP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpenFromFTP.Checked)
            {
                UpdateUi();
            }
        }

        private void rbOpenFromHTTP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpenFromHTTP.Checked)
            {
                UpdateUi();
            }
        }

        private void rbOpenFromClipboard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpenFromClipboard.Checked)
            {
                UpdateUi();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (rbOpenFromFile.Checked)
            {
                if (!string.IsNullOrWhiteSpace(tbFile.Text) && File.Exists(tbFile.Text))
                {
                    GdPictureStatus status = _owner.DisplayFromFile(tbFile.Text);
                    if (status == GdPictureStatus.OK)
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("Error during file loading: " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You must select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (rbOpenFromFTP.Checked)
            {
                int port = 0;
                if (!string.IsNullOrWhiteSpace(tbHost.Text) && !string.IsNullOrWhiteSpace(tbPort.Text)
                    && int.TryParse(tbPort.Text, out port) && !string.IsNullOrWhiteSpace(tbPath.Text))
                {
                    GdPictureStatus status = _owner.DisplayFromFTP(tbHost.Text, tbPath.Text, tbLogin.Text, tbPassword.Text, port);
                    if (status == GdPictureStatus.OK)
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("FTP Error: " + _owner.GetLastTransferError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You must enter all data for FTP connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbOpenFromHTTP.Checked)
            {
                Uri uri = null;
                if (!string.IsNullOrWhiteSpace(tbOpenFromHTTP.Text) && Uri.TryCreate(tbOpenFromHTTP.Text, UriKind.Absolute, out uri))
                {
                    GdPictureStatus status = _owner.DisplayFromHTTP(uri.ToString(), "", "");
                    if (status == GdPictureStatus.OK)
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("HTTP Error: " + _owner.GetLastTransferError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You must specify an URI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbOpenFromClipboard.Checked)
            {
                if (Clipboard.ContainsImage())
                {
                    GdPictureStatus status = _owner.DisplayFromClipboard();
                    if (status == GdPictureStatus.OK)
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("Error: " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("There is no image in clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (ok)
            {
                Close();
            }
        }

        private void btOpenFromFile_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbFile.Text = OpenFileDialog1.FileName;
            }
        }
    }
}
