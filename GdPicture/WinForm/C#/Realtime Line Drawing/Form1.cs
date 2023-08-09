using GdPicture14; 
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Project1
{
    internal partial class Form1 : System.Windows.Forms.Form 
    { 
        
        
        public int m_NativeImage; 
        public int m_TmpImage; 
        public int m_StartX; 
        public int m_StartY; 
        public GdPictureImaging oGdPictureImaging = new GdPictureImaging(); 
        
        
        
        
        private void Form1_Load( System.Object sender, System.EventArgs e ) 
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
            m_NativeImage = oGdPictureImaging.CreateNewGdPictureImage( 600, 600, 32, Color.White );
            if (m_NativeImage == 0)
            {
                MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
                return;
            }

            if (GdViewer1.DisplayFromGdPictureImage(m_NativeImage) != GdPictureStatus.OK)
                MessageBox.Show("Cannot Display Document");
        } 
        
        
        
        
        
        private void Command2_Click( System.Object sender, System.EventArgs e ) 
        {
            if (GdViewer1.ZoomOUT() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Zoom OUT"); 
        } 
        
        
        
        private void Command1_Click( System.Object sender, System.EventArgs e ) 
        {
            if (GdViewer1.ZoomIN() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Zoom In"); 
        } 
        
        
        
        private void Command3_Click( System.Object sender, System.EventArgs e ) 
        {
            if (oGdPictureImaging.ClearImage(m_NativeImage, Color.White) != GdPictureStatus.OK)
                MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
            if (GdViewer1.Redraw() != GdPictureStatus.OK)
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString());
        } 
        
        
        
        private void GdViewer1_MouseDown( object sender, System.Windows.Forms.MouseEventArgs e ) 
        { 
            m_StartX = GdViewer1.GetMouseLeftInDocument(); 
            m_StartY = GdViewer1.GetMouseTopInDocument(); 
        } 
        
        
        
        private void GdViewer1_MouseMove( object sender, System.Windows.Forms.MouseEventArgs e ) 
        { 
            if ( e.Button == System.Windows.Forms.MouseButtons.Left ) 
            { 
                if ( m_TmpImage != 0 )
                { 
                    oGdPictureImaging.ReleaseGdPictureImage( m_TmpImage ); 
                } 
                m_TmpImage = oGdPictureImaging.CreateClonedGdPictureImage( m_NativeImage );
                if (m_TmpImage == 0)
                {
                    MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
                    return;
                }
                if(oGdPictureImaging.DrawLine( m_TmpImage, m_StartX, m_StartY,
                                            GdViewer1.GetMouseLeftInDocument(),
                                            GdViewer1.GetMouseTopInDocument(),
                                            System.Convert.ToInt32( this.txtPenSize.Text ), 
                                            oGdPictureImaging.ARGB( System.Convert.ToByte( this.txtAlpha.Text ),
                                            System.Convert.ToByte( this.txtRed.Text ), 
                                            System.Convert.ToByte( this.txtGreen.Text ),
                                            System.Convert.ToByte( this.txtBlue.Text ) ), true )!= GdPictureStatus.OK)
                MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());

            if (GdViewer1.DisplayFromGdPictureImage(m_TmpImage) != GdPictureStatus.OK)
                MessageBox.Show("Cannot Display Document");

            } 
        } 
        
        
        
        private void GdViewer1_MouseUp( object sender, System.Windows.Forms.MouseEventArgs e ) 
        { 
            if ( m_TmpImage != 0 ) 
            { 
                oGdPictureImaging.ReleaseGdPictureImage( m_NativeImage ); 
                m_NativeImage = m_TmpImage; 
                m_TmpImage = 0; 
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
    } 
    
} 
