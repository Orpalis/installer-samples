using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Win32;
using GdPicture14;

    
namespace Csharp_OMR___Anchor_Sample.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public GdPictureImaging m_GdPictureImaging = new GdPictureImaging();
        public int m_TemplateImg = 0;
        public int m_ROILeft;
        public int m_ROITop;
        public int m_ROIWidth;
        public int m_ROIHeight;
        public int m_CurrentImage;

        public IntPtr m_TemplateAnchorID = IntPtr.Zero;

        public double m_AnchorLeft;
        public double m_AnchorTop;
        public double m_AnchorWidth;
        public double m_AnchorHeight;
        private int m_PreviousTab = 0;
        private double m_SearchWidth = 30;
        private double m_SearchHeight = 30;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LicenseManager oLicenceManager = new LicenseManager(); //Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.
            oLicenceManager.RegisterKEY("XXXX");//Please, replace XXXX by a valid demo or commercial license key. 
        }

        private void wCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            int val;
            bool result = Int32.TryParse(wCount.Text, out val);
            if (result)
                m_SearchWidth = val;
            else
            {
                MessageBox.Show("Please enter a valid number");
                wCount.Text = "0";
                m_SearchWidth = 0;
            }
        }

        private void wUp_Click(object sender, RoutedEventArgs e)
        {
            m_SearchWidth++;
            wCount.Text = m_SearchWidth.ToString();
        }

        private void wDown_Click(object sender, RoutedEventArgs e)
        {
            if (m_SearchWidth > 0)
            {
                m_SearchWidth--;
                wCount.Text = m_SearchWidth.ToString();
            }
        }

        private void hCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            int val;
            bool result = Int32.TryParse(hCount.Text, out val);
            if (result)
                m_SearchHeight= val;
            else
            {
                MessageBox.Show("Please enter a valid number");
                wCount.Text = "0";
                m_SearchHeight = 0;
            }
        }

        private void hUp_Click(object sender, RoutedEventArgs e)
        {
            m_SearchHeight++;
            hCount.Text = m_SearchHeight.ToString();
        }

        private void hDown_Click(object sender, RoutedEventArgs e)
        {
            if (m_SearchHeight > 0)
            {
                m_SearchHeight--;
                hCount.Text = m_SearchHeight.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void GdViewer2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (GdViewer2.IsRect())
            {
                GdViewer2.RemoveAllRegions();
                GdViewer2.GetRectCoordinatesOnDocumentInch(ref m_AnchorLeft, ref m_AnchorTop, ref m_AnchorWidth, ref m_AnchorHeight);
                int regID = GdViewer2.AddRegion("anchor", m_AnchorLeft, m_AnchorTop, m_AnchorWidth, m_AnchorHeight, Colors.Green, GdPicture14.WPF.GdViewer.RegionFillMode.Multiply);
                GdViewer2.SetRegionBorderWidth(regID, 1);
                GdViewer2.SetRegionBorderColor(regID, Colors.Blue);
                if (GdViewer2.Redraw() != GdPictureStatus.OK)
                    MessageBox.Show("Cannot Draw. Error: " + GdViewer2.GetStat().ToString());
                GdViewer2.MouseMode = ViewerMouseMode.MouseModePan;
                ShowRegionSize();
                GdViewer2.ClearRect();
            }
        }

        private void ShowRegionSize() 
        { 
            int RegionID = GdViewer2.GetRegionID( 1 ); 
            int AWidth = (int)( Math.Round( GdViewer2.GetRegionWidth( RegionID ) * 25.4 ) );
            int AHeight = (int)(Math.Round(GdViewer2.GetRegionHeight(RegionID) * 25.4)); 
            
            if ( m_SearchWidth < AWidth )
            {
                m_SearchWidth = Math.Round(AWidth * 1.1); 
                wCount.Text = m_SearchWidth.ToString(); 
            } 
            if ( m_SearchHeight < AHeight )
            {
                m_SearchHeight = Math.Round(AHeight * 1.1);
                hCount.Text = m_SearchHeight.ToString(); 
            } 
            this.Title = "Anchor width: " +  AWidth.ToString() + " mm" + " - Anchor height: " + AHeight.ToString() + " mm"; 
        }


        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (TabControl1.SelectedIndex == 1)
            {
                if (m_PreviousTab == 1) return;

                m_PreviousTab = 1;
                if (m_TemplateImg == 0)
                {
                    MessageBox.Show("Please load a template image before navigating to another tab.", "Not allowed", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    TabControl1.SelectedIndex = 0;
                }
                else
                {
                    if (GdViewer2.RegionCount() == 0)
                    {
                        MessageBox.Show("Please draw an anchor on the template image before navigating to another tab.", "Not allowed", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        TabControl1.SelectedIndex = 0;
                    }
                    else
                    {
                        // Generating the anchor template
                        int RegID = GdViewer2.GetRegionID(1);
                        m_AnchorLeft = (int)(GdViewer2.GetRegionLeft(RegID) * GdViewer2.PageHorizontalResolution);
                        m_AnchorTop = (int)(GdViewer2.GetRegionTop(RegID) * GdViewer2.PageVerticalResolution);
                        m_AnchorWidth = (int)(GdViewer2.GetRegionWidth(RegID) * GdViewer2.PageHorizontalResolution);
                        m_AnchorHeight = (int)(GdViewer2.GetRegionHeight(RegID) * GdViewer2.PageVerticalResolution);

                        m_ROIWidth = (int)(m_SearchWidth / 25.4 * GdViewer2.PageHorizontalResolution);
                        m_ROIHeight = (int)(m_SearchHeight / 25.4 * GdViewer2.PageVerticalResolution);
                        m_ROILeft = (int)((m_AnchorLeft + m_AnchorWidth / 2) - (m_ROIWidth / 2));
                        m_ROITop = (int)((m_AnchorTop + m_AnchorHeight / 2) - (m_ROIHeight / 2));


                        if (m_TemplateAnchorID != IntPtr.Zero)
                        {
                            m_GdPictureImaging.DeleteAnchorTemplate(m_TemplateAnchorID);
                        }


                        m_TemplateAnchorID = m_GdPictureImaging.CreateAnchorTemplate(m_TemplateImg, (int)m_AnchorLeft, (int)m_AnchorTop, (int)m_AnchorWidth, (int)m_AnchorHeight);
                        if (m_TemplateAnchorID != IntPtr.Zero)
                        {
                            if (m_CurrentImage != 0)
                            { // Refresh current image if any

                                GdViewer1.RemoveAllRegions();
                                FindAnchor();
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
            else if (ListBox1.SelectedIndex == 0)
                m_PreviousTab = 0;
        }

        private void FindAnchor()
        {
            int anchor_left = 0;
            int anchor_top = 0;
            int anchor_width = 0;
            int anchor_height = 0;
            double accuracy = 0;
            OMRMode Mode = OMRMode.FavorQuality;
            
            if (CheckBox1.IsChecked == true)
            {
                Mode = OMRMode.FavorSpeed;
            }

            GdPictureStatus status = m_GdPictureImaging.FindAnchor(m_CurrentImage, m_TemplateAnchorID, Mode, m_ROILeft, m_ROITop, m_ROIWidth, m_ROIHeight, ref anchor_left, ref anchor_top, ref anchor_width, ref anchor_height, ref accuracy);

            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("error: " + status.ToString());
            }
            GdViewer1.AddRegion("anchor", (double)anchor_left / GdViewer2.PageHorizontalResolution, (double)anchor_top / GdViewer2.PageVerticalResolution, (double)anchor_width / GdViewer2.PageHorizontalResolution, (double)anchor_height / GdViewer2.PageVerticalResolution, Colors.Blue, GdPicture14.WPF.GdViewer.RegionFillMode.Multiply);
            this.Title= "Accuracy: " + accuracy.ToString() + "%";
        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox1.SelectedIndex != -1)
            {

                if (m_CurrentImage != 0)
                {
                    m_GdPictureImaging.ReleaseGdPictureImage(m_CurrentImage);
                }
                GdViewer1.CloseDocument();
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Multiselect = true;
            OpenFileDialog1.ShowDialog(this);
            foreach (string item in OpenFileDialog1.FileNames)
            {
                if (GdPictureDocumentUtilities.GetDocumentFormat(item) != GdPicture14.DocumentFormat.DocumentFormatUNKNOWN)
                {
                    ListBox1.Items.Add(item);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();
            GdViewer1.CloseDocument();
            if (m_CurrentImage != 0)
            {
                m_GdPictureImaging.ReleaseGdPictureImage(m_CurrentImage);
                m_CurrentImage = 0;
            } 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GdViewer1.BitmapScalingMode = BitmapScalingMode.Linear;
            for (int i = 0; i <= this.ListBox1.Items.Count - 1; i++)
            {
                this.ListBox1.SelectedIndex = i;
                DoEvents();
            }
            GdViewer1.BitmapScalingMode = BitmapScalingMode.HighQuality;
        }

        public void DoEvents()
        {
            DispatcherFrame frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background, new DispatcherOperationCallback(ExitFrame), frame);
            Dispatcher.PushFrame(frame);
        }

        public object ExitFrame(Object f)
        {
            DispatcherFrame temp = (DispatcherFrame)f;
            temp.Continue = false;
            return null;
        }

        private void GdViewer2_RegionEdited(object sender, GdPicture14.WPF.GdViewer.RegionEditedEventArgs e)
        {
            ShowRegionSize();
        }
        
    }
}
