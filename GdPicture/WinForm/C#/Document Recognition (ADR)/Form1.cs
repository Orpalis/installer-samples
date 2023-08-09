using GdPicture14;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace document_recognition
{
    public partial class Form1 : Form
    {
        private readonly GdPictureImaging _gdPictureImaging = new GdPictureImaging();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
        }

        private void ReloadCurrentAdrConfig()
        {
            lstTemplatesView.BeginUpdate();
            if (lstTemplatesView.Items.Count > 0)
            {
                lstTemplatesView.Items.Clear();
            }
            int templateCount = _gdPictureImaging.ADRGetTemplateCount();
            if (templateCount > 0)
            {
                for (int i = 1; i <= templateCount; i++)
                {
                    int templateId = _gdPictureImaging.ADRGetTemplateID(i);
                    string templateName = _gdPictureImaging.ADRGetTemplateTag(templateId);
                    int imageCount = _gdPictureImaging.ADRGetTemplateImageCount(templateId);

                    AddTemplateItem(templateName, templateId, imageCount);
                }
            }
            else
            {
                MessageBox.Show("No template available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lstTemplatesView.EndUpdate();
        }

        private void AddTemplateItem(string templateName, int templateID, int imageCount)
        {
            ListViewItem templateItem = new ListViewItem();
            templateItem.Text = templateName;
            templateItem.SubItems.Add(templateID.ToString());
            templateItem.SubItems.Add(imageCount.ToString());
            this.lstTemplatesView.Items.Add(templateItem);
        }

        private void AddTemplateImage(int templateID)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog { Multiselect = true };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool fileAdded = false;
                foreach (string file in openFileDialog1.FileNames)
                {
                    int imageId = _gdPictureImaging.CreateGdPictureImageFromFile(file);
                    if (imageId != 0)
                    {
                        if (_gdPictureImaging.ADRAddGdPictureImageToTemplate(templateID, imageId) == GdPictureStatus.OK)
                        {
                            ReloadCurrentAdrConfig();
                            fileAdded = true;
                        }
                        else
                        {
                            MessageBox.Show("Error adding " + file + " to the template. Status: " + _gdPictureImaging.GetStat(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        _gdPictureImaging.ReleaseGdPictureImage(imageId);
                    }
                    else
                    {
                        MessageBox.Show("Can't open " + file, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (fileAdded)
                {
                    MessageBox.Show("Image(s) added!");
                }
            }
        }

        private void ClearCurrentConfig()
        {
            this.lstTemplatesView.Items.Clear();
            _gdPictureImaging.ADRStartNewTemplateConfig();
        }

        private static DialogResult InputBox(string title, ref string value)
        {
            Form form = new Form();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, 10), form.ClientSize.Height);
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

        private void btNewTemplate_Click(object sender, EventArgs e)
        {
            string templateName = "";
            string value = "";
            if (InputBox("Template Name:", ref value) == DialogResult.OK)
            {
                templateName = value;
            }
            if (templateName != "")
            {
                int templateId = _gdPictureImaging.ADRCreateTemplateEmpty();
                _gdPictureImaging.ADRSetTemplateTag(templateId, templateName);
                AddTemplateItem(templateName, templateId, 0);
                if (MessageBox.Show("Do you want to add one or more images to this template? (recommended)", "Please add image(s) to template", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AddTemplateImage(templateId);
                }
            }
        }

        private void btClearConfig_Click(object sender, EventArgs e)
        {
            ClearCurrentConfig();
        }

        private void btLoadADRConfig_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ADR config | *.dat";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    ClearCurrentConfig();
                    if (_gdPictureImaging.ADRLoadTemplateConfig(openFileDialog.FileName))
                    {
                        ReloadCurrentAdrConfig();
                    }
                    else
                    {
                        MessageBox.Show("Error loading template config. Status: " + _gdPictureImaging.GetStat(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btDeleteTemplate_Click(object sender, EventArgs e)
        {
            if (lstTemplatesView.SelectedItems.Count == 1)
            {
                ListViewItem listItem = lstTemplatesView.SelectedItems[0];
                int templateID = int.Parse(listItem.SubItems[1].Text);
                _gdPictureImaging.ADRDeleteTemplate(templateID);
                lstTemplatesView.Items.Remove(listItem);
            }
            else
            {
                MessageBox.Show("Please first select a template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveADRConfig_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "ADR config | *.dat";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    if (_gdPictureImaging.ADRSaveTemplateConfig(sfd.FileName))
                    {
                        MessageBox.Show("Config saved!");
                    }
                    else
                    {
                        MessageBox.Show("Error saving template config. Status: " + _gdPictureImaging.GetStat(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btAddTemplateImage_Click(object sender, EventArgs e)
        {
            if (lstTemplatesView.SelectedItems.Count == 1)
            {
                ListViewItem listItem = lstTemplatesView.SelectedItems[0];
                int templateID = int.Parse(listItem.SubItems[1].Text);
                AddTemplateImage(templateID);
            }
            else
            {
                MessageBox.Show("Please first select a template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btIdentifyDocument_Click(object sender, EventArgs e)
        {
            if (_gdPictureImaging.ADRGetTemplateCount() > 0)
            {
                bool bTemplateConfigOK = true;

                for (int i = 1; i <= _gdPictureImaging.ADRGetTemplateCount(); i++)
                {
                    int templateID = _gdPictureImaging.ADRGetTemplateID(i);
                    if (_gdPictureImaging.ADRGetTemplateImageCount(templateID) == 0)
                    {
                        MessageBox.Show("Please assign image(s) to template ID: " + templateID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bTemplateConfigOK = false;
                        break;
                    }
                }

                if (bTemplateConfigOK)
                {
                    int ImageID = _gdPictureImaging.CreateGdPictureImageFromFile("");
                    if (ImageID != 0)
                    {
                        int closestTemplateID = _gdPictureImaging.ADRGetCloserTemplateForGdPictureImage(ImageID);
                        if (closestTemplateID != 0)
                        {
                            string templateName = _gdPictureImaging.ADRGetTemplateTag(closestTemplateID);
                            double accuracy = Math.Round(_gdPictureImaging.ADRGetLastConfidence(), 2);
                            if (MessageBox.Show("Template identified: " + templateName + " (" + closestTemplateID + ")" + Convert.ToChar(13) + "Accuracy: " +
                                accuracy + Convert.ToChar(13) + Convert.ToChar(13) + "Do you want to get extended results?", "results",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                string fullResults = "";

                                for (int i = 1; i <= _gdPictureImaging.ADRGetTemplateCount(); i++)
                                {
                                    int templateID = _gdPictureImaging.ADRGetTemplateID(i);
                                    templateName = _gdPictureImaging.ADRGetTemplateTag(templateID);
                                    accuracy = Math.Round(_gdPictureImaging.ADRGetLastConfidenceFromTemplate(templateID), 2);
                                    fullResults += "Accuracy: " + accuracy.ToString() + " Template: " + templateName + " (" + templateID.ToString() + ")" + Convert.ToChar(13);
                                }
                                MessageBox.Show(fullResults);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error during template matching. Status: " + _gdPictureImaging.GetStat().ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        _gdPictureImaging.ReleaseGdPictureImage(ImageID);
                    }
                    else
                    {
                        MessageBox.Show("Can't open selected image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first create template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            _gdPictureImaging.Dispose();
        }
    }
}
