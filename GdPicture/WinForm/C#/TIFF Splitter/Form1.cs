using GdPicture14; 
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace TIFFSplitter
{
    internal partial class Form1 : System.Windows.Forms.Form 
    { 
        
        private GdPictureImaging oGdPictureImaging = new GdPictureImaging(); 
        
        
        
        private void Form1_Load( System.Object eventSender, System.EventArgs eventArgs ) 
        { 
            TextBox3.Text = Application.StartupPath + @"\"; 
        } 
        
        
        
        private void Button1_Click( System.Object sender, System.EventArgs e ) 
        { 
            OpenFileDialog1.Multiselect = false; 
            OpenFileDialog1.Filter = "TIFF Image (*.tif)|*.tif"; 
            OpenFileDialog1.FileName = ""; 
            
            if ( OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK ) 
            { 
                TextBox2.Text = OpenFileDialog1.FileName; 
            } 
        } 
        
        
        
        private void Button2_Click( System.Object sender, System.EventArgs e ) 
        { 
            
            if ( FolderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK ) 
            {
                TextBox3.Text = FolderBrowserDialog1.SelectedPath + @"\"; 
            } 
        } 
        
        
        
        private void Button3_Click( System.Object sender, System.EventArgs e ) 
        { 
            string sImagepath = TextBox2.Text; 
            int SplitEach = 0; 
            string OutputFolder = TextBox3.Text; 
            GdPictureStatus Status = GdPictureStatus.OK; 
            
            Button3.Enabled = false;

            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key. 
            try 
            { 
                // prevent for overflow exception
                SplitEach = System.Convert.ToInt32( TextBox1.Text ); 
            } 
            catch ( Exception ex ) 
            { 
                
            } 
            
            if ( SplitEach > 0 ) 
            { 
                oGdPictureImaging.TiffOpenMultiPageForWrite( false ); //  For best performences
                int SrcTiff = oGdPictureImaging.CreateGdPictureImageFromFile( sImagepath ); 
                
                if ( SrcTiff != 0 ) 
                { 
                    // Checking if the image is a multipage tiff
                    if ( oGdPictureImaging.TiffIsMultiPage( SrcTiff ) ) 
                    { 
                        // Getting the initial compression sheme
                        TiffCompression TiffCompression = oGdPictureImaging.GetTiffCompression( SrcTiff ); 
                        int PageCount = oGdPictureImaging.TiffGetPageCount( SrcTiff ); 
                        int CurrentPage = 0; 
                        string OutputFilePath = null; 
                        int OutputFileCount = System.Convert.ToInt32( Math.Ceiling((double) PageCount / SplitEach ) ); 
                        
                        ProgressBar1.Maximum = PageCount; 
                        
                        
                        for ( int i=1; i <= OutputFileCount; i++ ) 
                        { 
                            int TiffOutputID = 0; 
                            
                            OutputFilePath = OutputFolder + "split" + i.ToString() + ".tif"; 
                            
                            for ( int j=1; j <= SplitEach; j++ ) 
                            { 
                                CurrentPage = CurrentPage + 1; 
                                if ( CurrentPage <= PageCount & Status == GdPictureStatus.OK ) 
                                {
                                    if (oGdPictureImaging.TiffSelectPage(SrcTiff, CurrentPage) != GdPictureStatus.OK)
                                        MessageBox.Show("Failed to select page" + CurrentPage.ToString() + oGdPictureImaging.GetStat().ToString());
                                    if ( j == 1 ) 
                                    { 
                                        TiffOutputID = oGdPictureImaging.CreateClonedGdPictureImage( SrcTiff ); // This image must be released at the end of the multipage TIFF generation !!
                                        if (TiffOutputID == 0)
                                        {
                                            MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
                                            return;
                                        }
                                        Status = oGdPictureImaging.TiffSaveAsMultiPageFile( TiffOutputID, OutputFilePath, TiffCompression ); 
                                    } 
                                    else 
                                    { 
                                        Status = oGdPictureImaging.TiffAddToMultiPageFile( TiffOutputID, SrcTiff ); 
                                    } 
                                    ProgressBar1.Value = CurrentPage; 
                                    Application.DoEvents(); 
                                } 
                            } 
                            if(oGdPictureImaging.TiffCloseMultiPageFile( TiffOutputID ) != GdPictureStatus.OK)
                             MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString()); 
                            oGdPictureImaging.ReleaseGdPictureImage( TiffOutputID ); 
                        } 
                        
                        if ( Status == GdPictureStatus.OK ) 
                        { 
                            MessageBox.Show( "Success !" ); 
                        } 
                        else 
                        {
                            MessageBox.Show("Error: " + Status.ToString()); 
                        } 
                    } 
                    else 
                    {
                        MessageBox.Show("Error, The image is not a multipage tiff."); 
                    } 
                    
                    oGdPictureImaging.ReleaseGdPictureImage( SrcTiff ); 
                } 
                else 
                {
                    MessageBox.Show("Error, Can't open image: " + sImagepath); 
                } 
            } 
            else 
            {
                MessageBox.Show("Error, Incorrect value for split each."); 
            } 
            Button3.Enabled = true; 
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
