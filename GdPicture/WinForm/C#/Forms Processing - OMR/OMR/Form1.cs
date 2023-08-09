using GdPicture14; 
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace adjust
{
    public partial class Form1  
    { 
        public Form1() 
        { 
            InitializeComponent();if (transDefaultFormForm1 == null)	transDefaultFormForm1 = this;
           
        } 
        
        private int m_ImageID; 
        private GdPictureImaging m_GdPictureImaging = new GdPictureImaging(); 
        
        
        
        private void Form1_Load( System.Object eventSender, System.EventArgs eventArgs ) 
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
        } 
        
 
        private void ReleaseGdpictureImage() 
        { 
            if ( m_ImageID != 0 ) 
            { 
                m_GdPictureImaging.ReleaseGdPictureImage( m_ImageID ); 
                m_ImageID = 0; 
            } 
            GdViewer1.CloseDocument(); 
        } 
        
        
        private void CloseToolStripMenuItem_Click( System.Object sender, System.EventArgs e ) 
        {
            ReleaseGdpictureImage(); 
        } 
        
        
        private void ExitToolStripMenuItem_Click( System.Object sender, System.EventArgs e ) 
        {
            ReleaseGdpictureImage(); 
            this.Close(); 
        } 
        
        
        private void Button1_Click( System.Object sender, System.EventArgs e ) 
        { 
            if(GdViewer1.ZoomIN() != GdPictureStatus.OK)
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString()); 
        } 
        
        
        private void Button2_Click( System.Object sender, System.EventArgs e ) 
        {
            if (GdViewer1.ZoomOUT() != GdPictureStatus.OK)
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString()); 
        } 
        

        private void OpenToolStripMenuItem_Click( System.Object sender, System.EventArgs e ) 
        {
            ReleaseGdpictureImage(); 
            m_ImageID = m_GdPictureImaging.CreateGdPictureImageFromFile( "" );
            if (m_ImageID != 0)
            {
                if (GdViewer1.DisplayFromGdPictureImage(m_ImageID) != GdPictureStatus.OK)
                    MessageBox.Show("Cannot Display Image");
                GdViewer1.MouseMode = ViewerMouseMode.MouseModeAreaSelection;
            }
            else
            {
                MessageBox.Show("No Image was loaded");
            }
        } 
        
        
        
        private void GdViewer1_MouseUp( object sender, System.Windows.Forms.MouseEventArgs e ) 
        { 
            if ( GdViewer1.IsRect() ) 
            { 
                int Left = 0, Top = 0, Width = 0, Height = 0; 
                GdViewer1.GetRectCoordinatesOnDocument( ref Left, ref Top, ref Width, ref Height ); 
                Rectangle[] Rects = new Rectangle[ 2 ]; 
                int[] Result = null; 
                
                Rects[ 0 ].X = Left; 
                Rects[ 0 ].Y = Top; 
                Rects[ 0 ].Width = Width; 
                Rects[ 0 ].Height = Height;
                if(defaultToolStripMenuItem.Checked)
                    Result = m_GdPictureImaging.OMRDetectMarks( m_ImageID, Rects, 1 ); 
                else
                    Result = m_GdPictureImaging.OMRDetectOvalMarks(m_ImageID, Rects, 1);
                MessageBox.Show("Value: " + Result[0].ToString());

            } 
        } 
        
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

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultToolStripMenuItem.Checked = !defaultToolStripMenuItem.Checked;
            ovalToolStripMenuItem.Checked = !ovalToolStripMenuItem.Checked;
        }

        private void ovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultToolStripMenuItem.Checked = !defaultToolStripMenuItem.Checked;
            ovalToolStripMenuItem.Checked = !ovalToolStripMenuItem.Checked;
        } 
    } 
    
} 
