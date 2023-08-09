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
            base.Load += new System.EventHandler( Form1_Load ); 
          

        } 
        
        private int _imageSrc; 
        private int _clonedImage; 
        private GdPictureStatus _stat; 
        private GdPictureImaging oGdPictureImaging = new GdPictureImaging(); 
        
        
        
        private void Form1_Load( System.Object eventSender, System.EventArgs eventArgs ) 
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
        } 
        
        
        private void HScroll1_Scroll( System.Object eventSender, System.Windows.Forms.ScrollEventArgs eventArgs ) 
        { 
            ProcessFilter(); 
        } 
        
     
        private void HScroll3_Scroll( System.Object eventSender, System.Windows.Forms.ScrollEventArgs eventArgs ) 
        { 
            ProcessFilter(); 
        } 
        
        
        private void ProcessFilter() 
        { 
            if ( _imageSrc != 0 ) 
            { 
                if ( _clonedImage != 0 ) 
                { 
                    oGdPictureImaging.ReleaseGdPictureImage( _clonedImage ); 
                    _clonedImage = 0; 
                } 
                _clonedImage = oGdPictureImaging.CreateClonedGdPictureImage32BppPARGB( _imageSrc );
                if (_clonedImage == 0)
                {
                    MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
                    return;
                }
                switch ( cmbKey.Text ) 
                {
                    case "Blue":
                        _stat = oGdPictureImaging.fxRemoveBackgroundChromaKey( _clonedImage, ColorKey.ColorKeyBlue, HSThreshold.Value, HSMinVal.Value ); 
                        break;
                    case "Green":
                        _stat = oGdPictureImaging.fxRemoveBackgroundChromaKey( _clonedImage, ColorKey.ColorKeyGreen, HSThreshold.Value, HSMinVal.Value ); 
                        break;
                    case "Red":
                        _stat = oGdPictureImaging.fxRemoveBackgroundChromaKey( _clonedImage, ColorKey.ColorKeyRed, HSThreshold.Value, HSMinVal.Value ); 
                        break;
                }
 
                if ( _stat  != GdPictureStatus.OK ) 
                {
                    MessageBox.Show("Error No: " + _stat.ToString());     
                } 
                else 
                {
                    if (GdViewer1.DisplayFromGdPictureImage(_clonedImage) != GdPictureStatus.OK)
                        MessageBox.Show("Cannot Display Image. Error: " + GdViewer1.GetStat().ToString());
                } 
            } 
        } 
        
        
        
        private void OpenToolStripMenuItem_Click( System.Object sender, System.EventArgs e ) 
        {
            ReleaseGdpictureImage(); 
            
            _imageSrc = oGdPictureImaging.CreateGdPictureImageFromFile( "" ); 
            if ( System.Convert.ToDouble( oGdPictureImaging.GetStat() ) == 0 ) 
            { 
                
                if ( ( oGdPictureImaging.GetWidth( _imageSrc ) * oGdPictureImaging.GetHeight( _imageSrc ) ) > ( GdViewer1.Width * GdViewer1.Height ) ) 
                { 
                    // Resizing the image to viewer height to maximize performances
                    if(oGdPictureImaging.ResizeWidthRatio( _imageSrc, GdViewer1.Width, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic )!= GdPictureStatus.OK)
                        MessageBox.Show("Image could not be resized to fit viewer. Reason: " + oGdPictureImaging.GetStat().ToString()) ; 
                } 
                ProcessFilter(); 
            } 
        } 
        
        
        private void ReleaseGdpictureImage() 
        { 
            if ( _imageSrc != 0 ) 
            { 
                oGdPictureImaging.ReleaseGdPictureImage( _imageSrc ); 
                _imageSrc = 0; 
            } 
            if ( _clonedImage != 0 ) 
            { 
                oGdPictureImaging.ReleaseGdPictureImage( _clonedImage ); 
                _clonedImage = 0; 
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
        
        
        
        private void cmbKey_SelectedIndexChanged( System.Object sender, System.EventArgs e ) 
        { 
            ProcessFilter(); 
        } 
        
        
        private void Button1_Click( System.Object sender, System.EventArgs e ) 
        { 
            HSThreshold.Value = 240; 
            HSMinVal.Value = 25; 
            ProcessFilter(); 
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
