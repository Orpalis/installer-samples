using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using GdPicture14;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace OMR
{
    public partial class Form1
    {
        public GdPictureImaging m_GdPictureImaging = new GdPictureImaging();
        public int m_TemplateImg = 0;
        public int m_ROILeft;
        public int m_ROITop;
        public int m_ROIWidth;
        public int m_ROIHeight;
        public int m_CurrentImage;

        public IntPtr m_TemplateAnchor = IntPtr.Zero;

        public int m_AnchorLeft;
        public int m_AnchorTop;
        public int m_AnchorWidth;
        public int m_AnchorHeight;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
        }

        private void ListBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (ListBox1.SelectedIndex != -1)
            {
                if (m_CurrentImage != 0)
                {
                    m_GdPictureImaging.ReleaseGdPictureImage(m_CurrentImage);
                }
                GdViewer1.CloseDocument();
                GdViewer1.RemoveAllRegions();
                m_CurrentImage = m_GdPictureImaging.CreateGdPictureImageFromFile(ListBox1.Items[ListBox1.SelectedIndex].ToString());
                if (m_CurrentImage != 0)
                {
                    if (GdViewer1.DisplayFromGdPictureImage(m_CurrentImage) != GdPictureStatus.OK)
                        MessageBox.Show("Error: " + GdViewer1.GetStat().ToString());
                    FindAnchor();
                }
                else
                {
                    MessageBox.Show("No Image was loaded");
                }
            }
        }


        private void FindAnchor()
        {
            int anchor_left = 0;
            int anchor_top = 0;
            int anchor_width = 0;
            int anchor_height = 0;
            double accuracy = 0;
            OMRMode Mode = OMRMode.FavorQuality;
            if (this.CheckBox1.Checked)
            {
                Mode = OMRMode.FavorSpeed;
            }

            GdPictureStatus status = m_GdPictureImaging.FindAnchor(m_CurrentImage, m_TemplateAnchor, Mode, m_ROILeft, m_ROITop, m_ROIWidth, m_ROIHeight, ref anchor_left, ref anchor_top, ref anchor_width, ref anchor_height, ref accuracy);

            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("error: " + status.ToString());
            }
            GdViewer1.AddRegion("anchor", anchor_left, anchor_top, anchor_width, anchor_height, ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Blue);
            Text = "Accuracy: " + accuracy.ToString() + "%";
        }



        private void Button2_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer2.MouseMode = ViewerMouseMode.MouseModeAreaSelection;
            if (m_TemplateImg != 0)
            {
                m_GdPictureImaging.ReleaseGdPictureImage(m_TemplateImg);
                GdViewer2.CloseDocument();
            }
            m_TemplateImg = m_GdPictureImaging.CreateGdPictureImageFromFile("");
            if (m_TemplateImg != 0)
            {
                if (GdViewer2.DisplayFromGdPictureImage(m_TemplateImg) != GdPictureStatus.OK)
                    MessageBox.Show("Error: " + GdViewer2.GetStat().ToString());
            }
            else
            {
                MessageBox.Show("No Image was loaded");
            }
        }


        private void GdViewer2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (GdViewer2.IsRect())
            {
                GdViewer2.RemoveAllRegions();
                GdViewer2.GetRectCoordinatesOnDocument(ref m_AnchorLeft, ref m_AnchorTop, ref m_AnchorWidth, ref m_AnchorHeight);
                int regID = GdViewer2.AddRegion("anchor", m_AnchorLeft, m_AnchorTop, m_AnchorWidth, m_AnchorHeight, ForegroundMixMode.ForegroundMixModeMASKPEN, Color.Green);
                GdViewer2.SetRegionBorderWidth(regID, 1);
                GdViewer2.SetRegionBorderColor(regID, Color.Blue);
                if (GdViewer2.Redraw() != GdPictureStatus.OK)
                    MessageBox.Show("Cannot Draw. Error: " + GdViewer2.GetStat().ToString());
                GdViewer2.MouseMode = ViewerMouseMode.MouseModePan;
                ShowRegionSize();
            }
        }


        private void TabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (TabControl1.SelectedIndex != 0)
            {
                if (m_TemplateImg == 0)
                {
                    MessageBox.Show("Please load a template image before navigating to another tab.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TabControl1.SelectedIndex = 0;
                }
                else
                {
                    if (GdViewer2.RegionCount() == 0)
                    {
                        MessageBox.Show("Please draw an anchor on the template image before navigating to another tab.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TabControl1.SelectedIndex = 0;
                    }
                    else
                    {
                        // Generating the anchor template
                        int RegID = GdViewer2.GetRegionID(1);
                        m_AnchorLeft = System.Convert.ToInt32(GdViewer2.GetRegionLeft(RegID) * GdViewer2.HorizontalResolution);
                        m_AnchorTop = System.Convert.ToInt32(GdViewer2.GetRegionTop(RegID) * GdViewer2.VerticalResolution);
                        m_AnchorWidth = System.Convert.ToInt32(GdViewer2.GetRegionWidth(RegID) * GdViewer2.HorizontalResolution);
                        m_AnchorHeight = System.Convert.ToInt32(GdViewer2.GetRegionHeight(RegID) * GdViewer2.VerticalResolution);

                        m_ROIWidth = System.Convert.ToInt32(System.Convert.ToDouble(NumericUpDown1.Value) / 25.4 * GdViewer2.HorizontalResolution);
                        m_ROIHeight = System.Convert.ToInt32(System.Convert.ToDouble(NumericUpDown2.Value) / 25.4 * GdViewer2.VerticalResolution);
                        m_ROILeft = System.Convert.ToInt32((m_AnchorLeft + m_AnchorWidth / 2) - (m_ROIWidth / 2));
                        m_ROITop = System.Convert.ToInt32((m_AnchorTop + m_AnchorHeight / 2) - (m_ROIHeight / 2));


                        if (m_TemplateAnchor != IntPtr.Zero)
                        {
                            m_GdPictureImaging.DeleteAnchorTemplate(m_TemplateAnchor);
                        }


                        m_TemplateAnchor = m_GdPictureImaging.CreateAnchorTemplate(m_TemplateImg, m_AnchorLeft, m_AnchorTop, m_AnchorWidth, m_AnchorHeight);
                        if (m_TemplateAnchor != IntPtr.Zero)
                        {
                            if (m_CurrentImage != 0)
                            { // Refresh current image if any

                                GdViewer1.RemoveAllRegions();
                                FindAnchor();
                            }
                            else
                            {
                                MessageBox.Show("No Image loaded");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Anchor Template Could Not be created. Error: "
                                + m_GdPictureImaging.GetStat().ToString());
                        }
                    }
                }
            }
        }


        private void TabControl1_Selecting(System.Object sender, System.Windows.Forms.TabControlCancelEventArgs e)
        {
            if (!(e.TabPage.Enabled))
            {
                e.Cancel = true;
            }
        }


        private void GdViewer2_RegionEditedByUser(int RegionID)
        {
            ShowRegionSize();
        }

        private void ShowRegionSize()
        {
            int RegionID = GdViewer2.GetRegionID(1);
            int AWidth = System.Convert.ToInt32(Math.Round(GdViewer2.GetRegionWidth(RegionID) * 25.4));
            int AHeight = System.Convert.ToInt32(Math.Round(GdViewer2.GetRegionHeight(RegionID) * 25.4));

            if (NumericUpDown1.Value < AWidth)
            {
                NumericUpDown1.Value = System.Convert.ToDecimal(Math.Round(AWidth * 1.1));
            }
            if (NumericUpDown2.Value < AHeight)
            {
                NumericUpDown2.Value = System.Convert.ToDecimal(Math.Round(AHeight * 1.1));
            }
            Text = "Anchor width: " + AWidth.ToString() + " mm" + " - Anchor height: " + AHeight.ToString() + " mm";
        }


        private void Button3_Click(System.Object sender, System.EventArgs e)
        {
            ListBox1.Items.Clear();
            GdViewer1.CloseDocument();
            if (m_CurrentImage != 0)
            {
                m_GdPictureImaging.ReleaseGdPictureImage(m_CurrentImage);
                m_CurrentImage = 0;
            }
        }


        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            GdViewer1.DisplayQuality = DisplayQuality.DisplayQualityLow;
            for (int i = 0; i <= this.ListBox1.Items.Count - 1; i++)
            {
                this.ListBox1.SelectedIndex = i;
                Application.DoEvents();
            }
            GdViewer1.DisplayQuality = DisplayQuality.DisplayQualityBicubicHQ;
        }


        private void Button4_Click(System.Object sender, System.EventArgs e)
        {
            OpenFileDialog1.Multiselect = true;
            OpenFileDialog1.ShowDialog(this);
            foreach (string item in OpenFileDialog1.FileNames)
            {
                if (GdPictureDocumentUtilities.GetDocumentFormatFromFileName(item) != GdPicture14.DocumentFormat.DocumentFormatUNKNOWN)
                {
                    ListBox1.Items.Add(item);
                }
            }
        }
    }
}
