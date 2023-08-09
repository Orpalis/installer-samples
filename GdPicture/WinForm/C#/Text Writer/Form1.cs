using GdPicture14; 

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GdPicture14;

namespace Projet1
{
    internal partial class Form1 : System.Windows.Forms.Form 
    { 
       
        
        private string POS_INDICATOR = System.Convert.ToString( System.Convert.ToChar( 32 ) ) + System.Convert.ToChar( 182 ); 
        private int m_ImageID, _nClonedImageID; 
        private int _nStartPosX, _nStartPosY; 
        private bool _bCursorEnabled; 
        private string _sText; 
        private string _sFontName;
        private System.Drawing.FontStyle _fFontStyle; 
        private GdPictureImaging oGdPictureImaging = new GdPictureImaging(); 
        public   System.Windows.Forms.Label oCursor; 
        
        
        
        
        
        private void btZoomIN_Click( System.Object eventSender, System.EventArgs eventArgs ) 
        {
            if (GdViewer1.ZoomIN() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Zoom In");
        } 
        
        
        
        private void btZoomOUT_Click( System.Object eventSender, System.EventArgs eventArgs ) 
        {
            if (GdViewer1.ZoomOUT() != GdPictureStatus.OK)
                MessageBox.Show("Cannot Zoom OUT"); 
        } 
        
        
        
        private void Form1_Load( System.Object eventSender, System.EventArgs eventArgs ) 
        { 
            this.oCursor = new System.Windows.Forms.Label(); 
            oCursor.BackColor = System.Drawing.SystemColors.ActiveCaption; 
            oCursor.Location = new System.Drawing.Point( 645, 500 ); 
            oCursor.Name = "oCursor"; 
            oCursor.Size = new System.Drawing.Size( 1, 10 ); 
            oCursor.TabIndex = 0; 
            
            GdViewer1.Controls.Add( oCursor ); 
            oCursor.Visible = false; 
            _bCursorEnabled = false;

            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            GdViewer1.ZoomMode = ViewerZoomMode.ZoomMode100; 
            m_ImageID = oGdPictureImaging.CreateNewGdPictureImage( 800, 500, 32, Color.White );
            if (m_ImageID == 0)
            {
                MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
                return;
            }
            if (GdViewer1.DisplayFromGdPictureImage(m_ImageID) != GdPictureStatus.OK)
                MessageBox.Show("Cannot Display Message");
            GdViewer1.Cursor = Cursors.IBeam; 
            GdViewer1.KeepDocumentPosition = true; 
            GdViewer1.MouseMode = ViewerMouseMode.MouseModeDefault; 
            _sFontName = "Arial"; 
            
            
        } 
        
        
        
        private void Form1_FormClosed( System.Object eventSender, System.Windows.Forms.FormClosedEventArgs eventArgs ) 
        { 
            oGdPictureImaging.ReleaseGdPictureImage( m_ImageID ); 
        } 
        
        
        
        
        private void BurnText( string sText, bool bBurnPosIndicator ) 
        { 
            if ( _nClonedImageID != 0 )
            { 
                oGdPictureImaging.ReleaseGdPictureImage( _nClonedImageID ); 
            } 
            _nClonedImageID = oGdPictureImaging.CreateClonedGdPictureImage( m_ImageID );
            if (_nClonedImageID == 0)
            {
                MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
                return;
            }
            
            if ( bBurnPosIndicator )
            { 
                sText = sText + POS_INDICATOR; 
            }
            if (sText == null)
                return;
            if(oGdPictureImaging.DrawText( _nClonedImageID, sText, _nStartPosX, _nStartPosY, 
                int.Parse( txtFontSize.Text ), _fFontStyle, Color.Black, _sFontName, true ) != GdPictureStatus.OK)
                MessageBox.Show("Error: "+ oGdPictureImaging.GetStat().ToString()); 
            
            if(GdViewer1.DisplayFromGdPictureImage( _nClonedImageID )!= GdPictureStatus.OK)
                MessageBox.Show("Cannot Display Message"); 
        } 
        
        
        
        private void MoveCursor() 
        { 
            int nCursorX = 0, nCursorY = 0; 
            float nTextWidth = 0, nTextHeight = 0; 
            string sCurrentLineOfText = null; 
            int nCurrentLineOfTextPos = 0; 
            float nLineHeight = 0; 
            
            nCurrentLineOfTextPos = Strings.InStrRev( _sText, System.Convert.ToString( System.Convert.ToChar( 10 ) ) + System.Convert.ToChar( 13 ), -1, (Microsoft.VisualBasic.CompareMethod)(0) ); 
            if ( nCurrentLineOfTextPos > 0 ) 
            { 
                sCurrentLineOfText = _sText.Substring( nCurrentLineOfTextPos + 1 ); 
            } 
            else 
            { 
                sCurrentLineOfText = _sText; 
            } 
            
            nTextWidth = oGdPictureImaging.GetTextWidth( m_ImageID, sCurrentLineOfText, _sFontName, int.Parse( txtFontSize.Text ), _fFontStyle ); 
            nTextHeight = oGdPictureImaging.GetTextHeight( m_ImageID, _sText + POS_INDICATOR, _sFontName, int.Parse( txtFontSize.Text ), _fFontStyle ); 
            nLineHeight = oGdPictureImaging.GetTextHeight( m_ImageID, sCurrentLineOfText + POS_INDICATOR, _sFontName, int.Parse( txtFontSize.Text ), _fFontStyle ); 
            
            GdViewer1.CoordDocumentToViewer( System.Convert.ToInt32( _nStartPosX + nTextWidth ), _nStartPosY, ref nCursorX, ref nCursorY ); 
            oCursor.Left = nCursorX; 
            oCursor.Top = System.Convert.ToInt32( nCursorY + ( ( nTextHeight - nLineHeight ) * GdViewer1.Zoom ) ); 
            oCursor.Height = System.Convert.ToInt32( nLineHeight * GdViewer1.Zoom ); 
        } 
        
        
        
        private void SaveState() 
        { 
            BurnText( _sText, false ); 
            oCursor.Visible = false; 
            _bCursorEnabled = false; 
            _sText = ""; 
            if ( _nClonedImageID != 0 ) 
            { 
                oGdPictureImaging.ReleaseGdPictureImage( m_ImageID ); 
                m_ImageID = _nClonedImageID; 
                _nClonedImageID = 0; 
                if(GdViewer1.DisplayFromGdPictureImage( m_ImageID )!= GdPictureStatus.OK)
                MessageBox.Show("Cannot Display Message"); 
            } 
        } 
        
        
        private void gdviewer1_Leave( object sender, System.EventArgs e ) 
        { 
            SaveState(); 
        } 
        
        
        private void Timer1_Tick( System.Object eventSender, System.EventArgs eventArgs ) 
        { 
            if ( _bCursorEnabled ) 
            { 
                oCursor.Visible = !( oCursor.Visible ); 
            } 
        } 
        
        
        private void GdViewer1_KeyPress( object sender, System.Windows.Forms.KeyPressEventArgs e ) 
        { 
            if ( _bCursorEnabled ) 
            { 
                
                if ( System.Convert.ToInt32( e.KeyChar ) != 9 ) 
                { // Exclude TAB
                
                    switch ( System.Convert.ToInt32( e.KeyChar ) ) 
                    {
                        case 8:
                            if ( _sText.Length > 0 ) 
                            { 
                                if ( char.Parse( _sText.Substring( _sText.Length-1 ) ) == System.Convert.ToChar( 13 ) ) 
                                { 
                                    if ( _sText.Length - 3 > 0 ) 
                                    { 
                                        _sText = Strings.Mid( _sText, 1, _sText.Length - 3 ); 
                                    } 
                                    else 
                                    { 
                                        _sText = ""; 
                                    } 
                                } 
                                else 
                                { 
                                    _sText = Strings.Mid( _sText, 1, _sText.Length - 1 ); 
                                } 
                            } 
                            break;
                        case 13:
                            _sText = _sText + System.Convert.ToChar( 10 ) + System.Convert.ToChar( 13 ); 
                            break;
                        default:
                            _sText = _sText + e.KeyChar; 
                            break;
                    }
                    
                    BurnText( _sText, true ); 
                } 
            } 
        } 
        
        
        
        private void GdViewer1_MouseDown( object sender, System.Windows.Forms.MouseEventArgs e ) 
        { 
            SaveState();

            _fFontStyle = FontStyle.Regular; 
            if ( System.Convert.ToDouble( chkBold.CheckState ) == 1 )
            {
                _fFontStyle = _fFontStyle | FontStyle.Bold; 
            } 
            if ( System.Convert.ToDouble( chkItalic.CheckState ) == 1 )
            {
                _fFontStyle = _fFontStyle | FontStyle.Italic; 
            } 
            if ( System.Convert.ToDouble( chkUnderlined.CheckState ) == 1 )
            {
                _fFontStyle = _fFontStyle | FontStyle.Underline; 
            } 
            
            GdViewer1.CoordViewerToDocument( e.X, e.Y, ref _nStartPosX, ref _nStartPosY ); 
            
            if ( _nStartPosX >= 0 & _nStartPosY >= 0 & _nStartPosX < oGdPictureImaging.GetWidth( m_ImageID ) & _nStartPosY < oGdPictureImaging.GetHeight( m_ImageID ) ) 
            { 
                _bCursorEnabled = true; 
                BurnText( "", true ); 
                MoveCursor(); 
            } 
        } 
        
        
        private void GdViewer1_PageDisplayed() 
        { 
            MoveCursor(); 
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
