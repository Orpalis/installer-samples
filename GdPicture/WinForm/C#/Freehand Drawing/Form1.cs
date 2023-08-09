
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

        private GdPictureImaging oGdPictureImaging = new GdPictureImaging(); 
        private const int UNDO_LEVEL = 10; 
        private int[] _arImagesUndo = new int[ UNDO_LEVEL - 1 + 1 ]; 
        private int _nUndoIDX = -1; 
        private int m_NativeImage; 
        private int[,] _arPoints = new int[ 3, 3 ]; 
        private int _nHits;

        private void Form1_Load(System.Object eventSender, System.EventArgs eventArgs)
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
            m_NativeImage = this.oGdPictureImaging.CreateNewGdPictureImage(600, 600, 32, Color.White);
            if (m_NativeImage != 0)
            {
                if (GdViewer1.DisplayFromGdPictureImage(m_NativeImage) != GdPictureStatus.OK)
                    MessageBox.Show("Cannot Didplay Image. Error: " + GdViewer1.GetStat().ToString());
            }
            else 
            {
                MessageBox.Show("Image Could Not be created. Error:" + oGdPictureImaging.GetStat().ToString());
            }
        } 
        
        
        private void Command1_Click( System.Object eventSender, System.EventArgs eventArgs ) 
        {
            if (GdViewer1.ZoomIN() != GdPictureStatus.OK)
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString()); 
        } 
        
        
        private void Command2_Click( System.Object eventSender, System.EventArgs eventArgs ) 
        {
            if (GdViewer1.ZoomOUT() != GdPictureStatus.OK)
                MessageBox.Show("Error: " + GdViewer1.GetStat().ToString());
        } 
        
        
        private void Command3_Click( System.Object eventSender, System.EventArgs eventArgs ) 
        { 
            if( oGdPictureImaging.ClearImage( m_NativeImage, Color.White ) != GdPictureStatus.OK)
                    MessageBox.Show(" Error: " + oGdPictureImaging.GetStat().ToString()); 
            if( GdViewer1.Redraw()!= GdPictureStatus.OK)
                    MessageBox.Show("Cannot Didplay Image. Error: " + GdViewer1.GetStat().ToString()); 
        } 
        
        
        private void btUndo_Click( System.Object sender, System.EventArgs e ) 
        { 
            _nUndoIDX = _nUndoIDX - 1; 
            if(oGdPictureImaging.ClearImage( m_NativeImage, Color.White )!= GdPictureStatus.OK)
                    MessageBox.Show(" Error: " + oGdPictureImaging.GetStat().ToString());

            if (oGdPictureImaging.DrawGdPictureImage(_arImagesUndo[_nUndoIDX], m_NativeImage, 0, 0, 
                                                        oGdPictureImaging.GetWidth(m_NativeImage), oGdPictureImaging.GetHeight(m_NativeImage), 
                                                        System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor) != GdPictureStatus.OK)
                    MessageBox.Show(" Error: " + oGdPictureImaging.GetStat().ToString()); 
            if ( _nUndoIDX == 0 )
            { 
                this.btUndo.Enabled = false; 
            }
            if (GdViewer1.Redraw() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Didplay Image. Error: " + GdViewer1.GetStat().ToString()); 
            
            this.btRedo.Enabled = true; 
        } 
        
        
        private void btRedo_Click( System.Object sender, System.EventArgs e ) 
        { 
            _nUndoIDX = _nUndoIDX + 1; 
            if(oGdPictureImaging.ClearImage( m_NativeImage, Color.White )!= GdPictureStatus.OK)
                    MessageBox.Show(" Error: " + oGdPictureImaging.GetStat().ToString());
            if(oGdPictureImaging.DrawGdPictureImage(_arImagesUndo[_nUndoIDX], m_NativeImage, 0, 0,
                                                    oGdPictureImaging.GetWidth(m_NativeImage),
                                                    oGdPictureImaging.GetHeight(m_NativeImage),
                                                    System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor) != GdPictureStatus.OK)
                MessageBox.Show(" Error: " + oGdPictureImaging.GetStat().ToString());
            if ( _nUndoIDX == UNDO_LEVEL - 1 ) 
            { 
                this.btRedo.Enabled = false; 
            } 
            else 
            { 
                if ( _arImagesUndo[ _nUndoIDX + 1 ] == 0 )
                { 
                    this.btRedo.Enabled = false; 
                } 
            }
            if (GdViewer1.Redraw() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Didplay Image. Error: " + GdViewer1.GetStat().ToString()); 
            
            this.btUndo.Enabled = true; 
        } 
        
        
        private void SaveGraphicState() 
        { 
            int i = 0; 
            
            _nUndoIDX = _nUndoIDX + 1; 
            if ( _nUndoIDX > UNDO_LEVEL - 1 ) 
            { 
                oGdPictureImaging.ReleaseGdPictureImage( _arImagesUndo[ 0 ] ); 
                for ( i=0; i <= UNDO_LEVEL - 2; i++ ) 
                { 
                    _arImagesUndo[ i ] = _arImagesUndo[ i + 1 ]; 
                    _nUndoIDX = UNDO_LEVEL - 1; 
                } 
            } 
            else 
            { 
                for ( i=_nUndoIDX + 1; i <= UNDO_LEVEL - 1; i++ ) 
                { 
                    if ( _arImagesUndo[ i ] != 0 ) 
                    { 
                        oGdPictureImaging.ReleaseGdPictureImage( _arImagesUndo[ i ] ); 
                        _arImagesUndo[ i ] = 0; 
                    } 
                } 
            } 
            _arImagesUndo[ _nUndoIDX ] = oGdPictureImaging.CreateClonedGdPictureImage( m_NativeImage );
            if (_arImagesUndo[_nUndoIDX] == 0)
            {
                MessageBox.Show("Image Could Not be Cloned. Error: " + oGdPictureImaging.GetStat().ToString());
            }
            if ( _nUndoIDX > 0 )
            { 
                this.btUndo.Enabled = true; 
            } 
            this.btRedo.Enabled = false; 
        } 
        
        
        private void GdViewer1_MouseDown( object sender, System.Windows.Forms.MouseEventArgs e ) 
        { 
            _arPoints[ 1, 1 ] = GdViewer1.GetMouseLeftInDocument(); 
            _arPoints[ 1, 2 ] = GdViewer1.GetMouseTopInDocument(); 
            if(oGdPictureImaging.DrawFilledCircle( m_NativeImage, _arPoints[ 1, 1 ], _arPoints[ 1, 2 ], 
                System.Convert.ToInt32(  txtPenSize.Text ), 
                oGdPictureImaging.ARGB( System.Convert.ToByte( txtAlpha.Text  ),
                System.Convert.ToByte( txtRed.Text  ), 
                System.Convert.ToByte( txtGreen.Text), 
                System.Convert.ToByte( txtBlue.Text )), true )!= GdPictureStatus.OK)
                MessageBox.Show(" Error: " + oGdPictureImaging.GetStat().ToString());
            if (GdViewer1.Redraw() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Didplay Image. Error: " + GdViewer1.GetStat().ToString()); 
        } 
        
        
        private void GdViewer1_MouseMove( object sender, System.Windows.Forms.MouseEventArgs e ) 
        { 
            if ( e.Button == System.Windows.Forms.MouseButtons.Left ) 
            { 
  
               _nHits = _nHits + 1; 
               _arPoints[ 2, 1 ] = GdViewer1.GetMouseLeftInDocument(); 
               _arPoints[ 2, 2 ] = GdViewer1.GetMouseTopInDocument();

               if (oGdPictureImaging.DrawLine(m_NativeImage, _arPoints[1, 1], _arPoints[1, 2], _arPoints[2, 1], _arPoints[2, 2], 
                   System.Convert.ToInt32(txtPenSize.Text),
                   oGdPictureImaging.ARGB(System.Convert.ToByte(txtAlpha.Text),
                   System.Convert.ToByte(txtRed.Text), 
                   System.Convert.ToByte(txtGreen.Text), 
                   System.Convert.ToByte(txtBlue.Text)), true) != GdPictureStatus.OK)
                   MessageBox.Show(" Error: " + oGdPictureImaging.GetStat().ToString());
               if( oGdPictureImaging.DrawFilledCircle( m_NativeImage, _arPoints[ 2, 1 ], _arPoints[ 2, 2 ], 
                   System.Convert.ToInt32(txtPenSize.Text),
                   oGdPictureImaging.ARGB(System.Convert.ToByte(txtAlpha.Text),
                   System.Convert.ToByte(txtRed.Text), 
                   System.Convert.ToByte(txtGreen.Text), 
                   System.Convert.ToByte(txtBlue.Text)), true) != GdPictureStatus.OK)
                   MessageBox.Show(" Error: " + oGdPictureImaging.GetStat().ToString());
               if ( _nHits % 2 == 0 )
               {
                   if (GdViewer1.Redraw() != GdPictureStatus.OK)
                       MessageBox.Show("Cannot Didplay Image. Error: " + GdViewer1.GetStat().ToString()); 
               } 
                    
               _arPoints[ 1, 1 ] = _arPoints[ 2, 1 ]; 
               _arPoints[ 1, 2 ] = _arPoints[ 2, 2 ]; 
            } 
        } 
        
        
        private void GdViewer1_MouseUp( object sender, System.Windows.Forms.MouseEventArgs e ) 
        { 
            SaveGraphicState(); 
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
