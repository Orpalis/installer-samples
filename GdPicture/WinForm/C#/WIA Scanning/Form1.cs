using GdPicture14; 
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace wia_sample
{
    public partial class Form1  
    { 
        
        private GdPictureImaging oGdPictureImaging = new GdPictureImaging(); 
 
        private void Form1_Load(System.Object eventSender, System.EventArgs eventArgs) 
        {
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
            DisplayWIADevices(); 
        } 
        
        
        
        private void DisplayWIADevices() 
        { 
            for (int i=1; i <= oGdPictureImaging.WiaGetSourceCount(); i++) 
            { 
                this.lstDevices.Items.Add(oGdPictureImaging.WiaGetSourceName(i) + " - " + oGdPictureImaging.WiaGetSourceType(i).ToString()); 
            } 
        } 
        
        
        
        private bool OpenSelectedSource() 
        { 
            if (lstDevices.Items.Count > 0) 
            { 
                int ItemIdx = lstDevices.SelectedIndex; 
                
                if (ItemIdx >= 0) 
                { 
                    bool Success = oGdPictureImaging.WiaOpenSource(oGdPictureImaging.WiaGetSourceID(ItemIdx + 1)); 
                    if (!(Success))
                    { 
                        MessageBox.Show("Can't open selected WIA device"); 
                    } 
                    return Success; 
                } 
                else 
                { 
                    MessageBox.Show("Please, select a WIA device first !"); 
                    return false; 
                } 
            } 
            else 
            { 
                MessageBox.Show("No WIA Device available !"); 
            } 
            return false;
        } 
        
        
        
        private void Command1_Click(System.Object eventSender, System.EventArgs eventArgs) 
        { 
            int nImageCount = 0; 
            int ImageID = 0; 
            int MultiPageID = 0; 
            
            if (OpenSelectedSource()) 
            { 
                nImageCount = 0;
                if (chkHideUI.CheckState == CheckState.Unchecked) 
                { 
                    oGdPictureImaging.WiaShowSetupDialogSource(); 
                } 
                oGdPictureImaging.WiaSelectFeeder(true); 
                
                   do 
                { 
                    ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage(); 
                    if (ImageID != 0) 
                    { 
                        nImageCount = nImageCount + 1; 
                        ApplyImageFilters(ImageID); 
                        if (chkPreview.CheckState == CheckState.Checked)
                        { 
                            DisplayImage(ImageID); 
                        } 
                         if (nImageCount == 1) 
                        { 
                            MultiPageID = ImageID; 
                             oGdPictureImaging.TiffSaveAsMultiPageFile(MultiPageID,  @"multipage.tif", TiffCompression.TiffCompressionCCITT4); 
                        } 
                        else 
                        { 
                            oGdPictureImaging.TiffAddToMultiPageFile(MultiPageID, ImageID); 
                            oGdPictureImaging.ReleaseGdPictureImage(ImageID); 
                        } 
                    } 
                } 
                while (oGdPictureImaging.WiaGetLastError() == WiaStatus.WIA_OK); 
                oGdPictureImaging.TiffCloseMultiPageFile(MultiPageID); 
                MessageBox.Show("Done. WIA status: " + oGdPictureImaging.WiaGetLastError().ToString()); 
                oGdPictureImaging.WiaCloseSource(); 
            } 
        } 
        
        
        
        private void Command12_Click(System.Object eventSender, System.EventArgs eventArgs) 
        { 
            int ImageID = 0; 
            GdPicturePDF oGdPicturePDF = new GdPicturePDF();
            
            if (OpenSelectedSource()) 
            {
                if (chkHideUI.CheckState == CheckState.Unchecked) 
                { 
                    oGdPictureImaging.WiaShowSetupDialogSource(); 
                } 
                
                oGdPictureImaging.WiaSelectFeeder(true);

                oGdPicturePDF.NewPDF(); 
                
                do 
                { 
                    ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage(); 
                    if (ImageID != 0) 
                    { 
                        ApplyImageFilters(ImageID); 
                        if (chkPreview.CheckState == CheckState.Checked)
                        { 
                            DisplayImage(ImageID); 
                        }
                        oGdPicturePDF.AddImageFromGdPictureImage(ImageID, false, true); 
                        oGdPictureImaging.ReleaseGdPictureImage(ImageID); 
                    } 
                } 
                while (oGdPictureImaging.WiaGetLastError() == WiaStatus.WIA_OK);
                oGdPicturePDF.SaveToFile("output.pdf");
                MessageBox.Show("Done. WIA status: " + oGdPictureImaging.WiaGetLastError().ToString()); 
                oGdPictureImaging.WiaCloseSource(); 
            } 
        } 
        
        
        
        private void Command2_Click(System.Object eventSender, System.EventArgs eventArgs) 
        { 
            int nImageCount = 0; 
            int ImageID = 0; 
            

            if (OpenSelectedSource()) 
            { 
                nImageCount = 0;
                if (chkHideUI.CheckState == CheckState.Unchecked) 
                { 
                    oGdPictureImaging.WiaShowSetupDialogSource(); 
                } 
                
                do 
                { 
                    ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage(); 
                    if (ImageID != 0) 
                    { 
                        ApplyImageFilters(ImageID); 
                        if (chkPreview.CheckState == CheckState.Checked)
                        { 
                            DisplayImage(ImageID); 
                        } 
                        nImageCount = nImageCount + 1;
                        oGdPictureImaging.SaveAsJPEG(ImageID, @"image" + nImageCount.ToString().Trim() + ".jpg", 75); 
                        oGdPictureImaging.ReleaseGdPictureImage(ImageID); 
                    } 
                } 
                while (oGdPictureImaging.WiaGetLastError() == WiaStatus.WIA_OK); 
                MessageBox.Show("Done. WIA status: " + oGdPictureImaging.WiaGetLastError().ToString()); 
                oGdPictureImaging.WiaCloseSource(); 
            } 
        } 
        
        
        
        private void Command3_Click(System.Object eventSender, System.EventArgs eventArgs) 
        { 
            int ImageID = 0; 
            
            if (OpenSelectedSource()) 
            { 
                if (chkHideUI.CheckState == CheckState.Unchecked) 
                { 
                    oGdPictureImaging.WiaShowSetupDialogSource(); 
                } 
                
                oGdPictureImaging.WiaSelectFeeder(false); 
                
                ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage(); 
                if (ImageID != 0) 
                { 
                    ApplyImageFilters(ImageID); 
                    if (chkPreview.CheckState == CheckState.Checked)
                    { 
                        DisplayImage(ImageID); 
                    } 
                    oGdPictureImaging.SaveAsPDF(ImageID, @"acquire.pdf", true, "", "", "", "", ""); 
                    oGdPictureImaging.ReleaseGdPictureImage(ImageID); 
                } 
                MessageBox.Show("Done. WIA status: " + oGdPictureImaging.WiaGetLastError().ToString()); 
                oGdPictureImaging.WiaCloseSource(); 
            } 
        } 
        
        
        
        private void Command4_Click(System.Object eventSender, System.EventArgs eventArgs) 
        { 
            int ImageID = 0; 
            
            if (OpenSelectedSource()) 
            {
                if (chkHideUI.CheckState == CheckState.Unchecked) 
                { 
                    oGdPictureImaging.WiaShowSetupDialogSource(); 
                } 
                
                oGdPictureImaging.WiaSelectFeeder(false); 
                
                ImageID = oGdPictureImaging.WiaAcquireToGdPictureImage(); 
                if (ImageID != 0) 
                { 
                    ApplyImageFilters(ImageID); 
                    if (chkPreview.CheckState == CheckState.Checked)
                    { 
                        DisplayImage(ImageID); 
                    } 
                    oGdPictureImaging.SaveAsJPEG(ImageID, @"acquire.jpg", 90); 
                    oGdPictureImaging.ReleaseGdPictureImage(ImageID); 
                } 
                MessageBox.Show("Done. WIA status: " + oGdPictureImaging.WiaGetLastError().ToString()); 
                oGdPictureImaging.WiaCloseSource(); 
            } 
        } 
        
        
        
        
        private void Command6_Click(System.Object eventSender, System.EventArgs eventArgs) 
        { 
            if (OpenSelectedSource()) 
            { 
                oGdPictureImaging.WiaShowSetupDialogSource(); 
            } 
        } 
        
        
        
        
        private void DisplayImage(int ImageID) 
        { 
            GdViewer1.DisplayFromGdPictureImage(ImageID); 
            GdViewer1.CloseDocument(true); 
            System.Windows.Forms.Application.DoEvents(); 
        } 
        
        
        
        
        private void ApplyImageFilters(int ImageID) 
        {
            if (this.ChkNeg.CheckState == CheckState.Checked)
            { 
                oGdPictureImaging.FxNegative(ImageID); 
            } 
            
            if (this.chkRemoveDots.CheckState == CheckState.Checked & oGdPictureImaging.GetBitDepth(ImageID) == 1) 
            { 
                oGdPictureImaging.FxBitonalRemoveIsolatedDots2x2(ImageID); 
            }

            if (this.chkRotate90.CheckState == CheckState.Checked & this.chkRotate180.CheckState == CheckState.Checked) 
            { 
                oGdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate270FlipNone); 
            } 
            else 
            {
                if (this.chkRotate90.CheckState == CheckState.Checked)
                { 
                    oGdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate90FlipNone); 
                }
                if (this.chkRotate180.CheckState == CheckState.Checked)
                { 
                    oGdPictureImaging.Rotate(ImageID, RotateFlipType.Rotate180FlipNone); 
                } 
            }

            if (this.chkAutoDesk.CheckState == CheckState.Checked)
            { 
                oGdPictureImaging.AutoDeskew(ImageID, 12, Color.White, 0.25F, false); 
            }

            if (this.ChkAutoCrop.CheckState == CheckState.Checked)
            { 
                oGdPictureImaging.CropBlackBordersEx(ImageID); 
            } 
        } 
   
    } 
    
} 
