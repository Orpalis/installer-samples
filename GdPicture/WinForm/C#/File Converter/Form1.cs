// VBConversions Note: VB project level imports
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
// End of VB project level imports

using System.IO;
using GdPicture14;

namespace Csharp_File_Converter
{
	public partial class Form1
	{
		public Form1()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Form1 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Form1 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Form1();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		
		private GdPictureStatus m_Status; //Variable to monitor functions Success or Failure
		private int m_SrcImageID; // Variable to hold the image
		private int m_DestImageID; //Variable to hold the dist image in case of multipage dist image
		
		private GdPicturePDF oGdPicturePDF = new GdPicturePDF(); //Variable to hold a source pdf file
		private GdPictureImaging oGdPictureImaging = new GdPictureImaging(); // GdPictureImaging object for loading and saving images
		private GdPicturePDF m_DestPDF = new GdPicturePDF(); // Variable to hold a destination pdf file
		
		private string m_InputExtension; //Variable to hold input format
		private string m_OutPutExtension; //Variable to hold output format
		private string m_Name; //Variable to hold input and output file name
		
		private string m_DestinationFolder; //Path of Folder to be saved in
		private string m_DestinationPath; //Full Path of Destination
		private string m_SourcePath; //Full Path of Source
		
		private bool m_IsSourceMultiPage; //Whether source file is a multipage file
		private bool m_IsDestMultiPage; //Whether destination file can be a multipage file
		
		private delegate void SaveMethod(); //Delegate to call appropriate single save method
		private SaveMethod SaveDel; //Single Save delegate instance
		
		private delegate void CreateMultiPageFile(); //Delegate to create a multipage file
		private CreateMultiPageFile CreateMultiDel; //Create multipage file delegate instance
		
		private delegate void AddToMultiPageFile(); //Delegate to add image to a multipage file
		private AddToMultiPageFile AddToMultiDel; //Single Save delegate instance
		
		private delegate void CloseMultiPageFile(); //Delegate to close a multipage file
		private CloseMultiPageFile CloseMultiDel; //Close multipage file delegate instance
		
		public void Form1_Load(System.Object sender, System.EventArgs e)
		{
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
		}
		
		//Whether input file is supported in application, if so, load it
		private bool LoadImageAndCheckSupport()
		{
			oGdPictureImaging.ReleaseGdPictureImage(m_SrcImageID);
			m_InputExtension = Path.GetExtension(m_SourcePath);
			m_Name = Path.GetFileNameWithoutExtension(m_SourcePath);
			bool Success = true;
			m_IsSourceMultiPage = false;
			string ext = m_InputExtension.ToLower();
			switch (ext)
			{
				case ".tif":
				case ".tiff":
					m_SrcImageID = oGdPictureImaging.CreateGdPictureImageFromFile(m_SourcePath);
					if (m_SrcImageID == 0)
					{
						MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
						Success = false;
					}
					else
					{
						if (oGdPictureImaging.TiffIsMultiPage(m_SrcImageID))
						{
							m_IsSourceMultiPage = true;
						}
					}
					break;
				case ".pdf":
					oGdPicturePDF.LoadFromFile(m_SourcePath, false);
					if (oGdPicturePDF.GetStat() != GdPictureStatus.OK)
					{
						MessageBox.Show("Error: " + oGdPicturePDF.GetStat().ToString());
						Success = false;
					}
					else
					{
						if (oGdPicturePDF.GetPageCount() > 1)
						{
							m_IsSourceMultiPage = true;
						}
					}
					break;
				case ".bmp":
				case ".png":
				case ".exr":
				case ".jpg":
				case ".j2k":
				case ".jp2":
				case ".pbm":
				case ".tga":
				case ".wbmp":
				case ".wmf":
				case ".xpm":
					m_SrcImageID = oGdPictureImaging.CreateGdPictureImageFromFile(m_SourcePath);
					if (m_SrcImageID == 0)
					{
						MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
						Success = false;
					}
					break;
				case ".gif":
					m_SrcImageID = oGdPictureImaging.CreateGdPictureImageFromFile(m_SourcePath);
					if (m_SrcImageID == 0)
					{
						MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
						Success = false;
					}
					else
					{
						if (oGdPictureImaging.GifIsMultiFrame(m_SrcImageID))
						{
							m_IsSourceMultiPage = true;
						}
					}
					break;
				case ".jb2":
					m_SrcImageID = oGdPictureImaging.CreateGdPictureImageFromFile(m_SourcePath);
					if (m_SrcImageID == 0)
					{
						MessageBox.Show("Error: " + oGdPictureImaging.GetStat().ToString());
						Success = false;
					}
					else
					{
						if (oGdPictureImaging.JBIG2IsMultiPage(m_SrcImageID))
						{
							m_IsSourceMultiPage = true;
						}
					}
					break;
				default:
					MessageBox.Show("File type is not supported!");
					Success = false;
					break;
			}
			ComboBox1_SelectedIndexChanged(null, null);
			return Success;
		}
		
		public void ChooseInputFile_Click(System.Object sender, System.EventArgs e)
		{
			OpenFileDialog1.Multiselect = false;
			OpenFileDialog1.FileName = "";
			
			if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				m_SourcePath = OpenFileDialog1.FileName;
				if (!LoadImageAndCheckSupport())
				{
					TextBox1.Text = "";
					m_InputExtension = "";
					m_Name = "";
					return ;
				}
				TextBox1.Text = OpenFileDialog1.FileName;
				m_SourcePath = OpenFileDialog1.FileName;
			}
		}
		
		public void ComboBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			m_IsDestMultiPage = false;
			SaveDel = null;
			CreateMultiDel = null;
			AddToMultiDel = null;
			CloseMultiDel = null;
			
			if ((string) ComboBox1.SelectedItem == "TIF")
			{
				m_OutPutExtension = ".tif";
				m_IsDestMultiPage = true;
				if (m_IsSourceMultiPage)
				{
					CreateMultiDel = new CreateMultiPageFile(CreateMultiPageTIFF);
					AddToMultiDel = new AddToMultiPageFile(AddToMultiTIFF);
					CloseMultiDel = new CloseMultiPageFile(CloseMultiTIFF);
				}
				else
				{
					SaveDel = new SaveMethod(SaveToSingleTIFF);
				}
			}
			else if ((string) ComboBox1.SelectedItem == "JPEG")
			{
				m_OutPutExtension = ".jpg";
				SaveDel = new SaveMethod(SaveToJPEG);
			}
			else if ((string) ComboBox1.SelectedItem == "PDF")
			{
				m_OutPutExtension = ".pdf";
				m_IsDestMultiPage = true;
				if (m_IsSourceMultiPage)
				{
					CreateMultiDel = new CreateMultiPageFile(CreateMultiPagePDF);
					AddToMultiDel = new AddToMultiPageFile(AddToMultiPDF);
					CloseMultiDel = new CloseMultiPageFile(CloseMultiPDF);
				}
				else
				{
					SaveDel = new SaveMethod(SaveToSinglePDF);
				}
			}
			else if ((string) ComboBox1.SelectedItem == "BMP")
			{
				m_OutPutExtension = ".bmp";
				SaveDel = new SaveMethod(SaveToBMP);
			}
			else if ((string) ComboBox1.SelectedItem == "EXR")
			{
				m_OutPutExtension = ".exr";
				SaveDel = new SaveMethod(SaveToEXR);
			}
			else if ((string) ComboBox1.SelectedItem == "J2K")
			{
				m_OutPutExtension = ".j2k";
				SaveDel = new SaveMethod(SaveToJ2K);
			}
			else if ((string) ComboBox1.SelectedItem == "JP2")
			{
				m_OutPutExtension = ".JP2";
				SaveDel = new SaveMethod(SaveToJP2);
			}
			else if ((string) ComboBox1.SelectedItem == "PBM")
			{
				m_OutPutExtension = ".pbm";
				SaveDel = new SaveMethod(SaveToPBM);
			}
			else if ((string) ComboBox1.SelectedItem == "TGA")
			{
				m_OutPutExtension = ".tga";
				SaveDel = new SaveMethod(SaveToTGA);
			}
			else if ((string) ComboBox1.SelectedItem == "WBMP")
			{
				m_OutPutExtension = ".wbmp";
				SaveDel = new SaveMethod(SaveToWBMP);
			}
			else if ((string) ComboBox1.SelectedItem == "WMF")
			{
				m_OutPutExtension = ".wmf";
				SaveDel = new SaveMethod(SaveToWMF);
			}
			else if ((string) ComboBox1.SelectedItem == "XMP")
			{
				m_OutPutExtension = ".xmp";
				SaveDel = new SaveMethod(SaveToXMP);
			}
			else if ((string) ComboBox1.SelectedItem == "GIF")
			{
				m_OutPutExtension = ".gif";
				m_IsDestMultiPage = true;
				if (m_IsSourceMultiPage)
				{
					CreateMultiDel = new CreateMultiPageFile(CreateMultiPageGIF);
					AddToMultiDel = new AddToMultiPageFile(AddToMultiGIF);
					CloseMultiDel = new CloseMultiPageFile(CloseMultiGIF);
				}
				else
				{
					SaveDel = new SaveMethod(SaveToSingleGIF);
				}
			}
			else if ((string) ComboBox1.SelectedItem == "PNG")
			{
				m_OutPutExtension = ".png";
				SaveDel = new SaveMethod(SaveToPNG);
			}
			else if ((string) ComboBox1.SelectedItem == "JBIG2")
			{
				m_OutPutExtension = ".jb2";
				m_IsDestMultiPage = true;
				if (m_IsSourceMultiPage)
				{
					CreateMultiDel = new CreateMultiPageFile(CreateMultiPageJBIG2);
					AddToMultiDel = new AddToMultiPageFile(AddToMultiJBIG2);
					CloseMultiDel = new CloseMultiPageFile(CloseMultiJBIG2);
				}
				else
				{
					SaveDel = new SaveMethod(SaveToSingleJBIG2);
				}
			}
		}
		
		public void ChooseDestinationFolder_Click(System.Object sender, System.EventArgs e)
		{
			if (FolderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				m_DestinationFolder = FolderBrowserDialog1.SelectedPath;
				TextBox2.Text = FolderBrowserDialog1.SelectedPath;
			}
			else
			{
				m_DestinationFolder = "";
				TextBox2.Text = "";
			}
		}
		
		private bool CheckIfAllDataIsAvailable()
		{
			var IsAvailable = true;
			if (m_InputExtension == "")
			{
				MessageBox.Show("No file has been loaded!");
				IsAvailable = false;
			}
			if (m_DestinationFolder == "")
			{
				MessageBox.Show("Destination folder has not been selected!");
				IsAvailable = false;
			}
			if (m_OutPutExtension == "")
			{
				MessageBox.Show("Please choose output format!");
				IsAvailable = false;
			}
			if (m_InputExtension == m_OutPutExtension)
			{
				MessageBox.Show("Source and output formats are the same!");
				IsAvailable = false;
			}
			return IsAvailable;
		}
		
		
		public void Convert_Click(System.Object sender, System.EventArgs e)
		{
			if (!CheckIfAllDataIsAvailable())
			{
				return ;
			}
			if (m_IsSourceMultiPage)
			{
				if (m_IsDestMultiPage)
				{
					MultiToMulti();
				}
				else
				{
					MultiToSplit();
				}
			}
			else
			{
				m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + m_OutPutExtension);
				SingleToSingle();
			}
		}
		
		//Calling the SaveImage Delegate function
		private void SaveImage()
		{
			SaveDel.Invoke();
		}
		
		//Method to convert any single image to any single image extension including a single page pdf
		private void SingleToSingle()
		{
			
			ProgressBar1.Maximum = 1;
			ProgressBar1.Value = 0;
            if (m_InputExtension == ".pdf")
			{
				oGdPicturePDF.SelectPage(1);
				m_SrcImageID = oGdPicturePDF.RenderPageToGdPictureImage(200, true);
				if (m_SrcImageID != 0)
				{
					SaveImage();
				}
				else
				{
					MessageBox.Show("Error: " + oGdPicturePDF.GetStat().ToString());
				}
			}
			else
			{
				SaveImage();
			}
			ProgressBar1.Value = 1;
		}
		
		//Method to split any multipage file to single images of any extenstion
		private void MultiToSplit()
		{
			if (m_InputExtension == ".pdf")
			{
				int NumberOfPages = oGdPicturePDF.GetPageCount();
				ProgressBar1.Maximum = NumberOfPages;
				for (int i = 1; i <= NumberOfPages; i++)
				{
					oGdPicturePDF.SelectPage(i);
					m_SrcImageID = oGdPicturePDF.RenderPageToGdPictureImage(200, true);
					if (m_SrcImageID != 0)
					{
						m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + "_Split_" + i.ToString() + m_OutPutExtension);
						SaveImage();
						if (m_Status != GdPictureStatus.OK)
						{
							m_Status = GdPictureStatus.OK;
							ProgressBar1.Value = 0;
							return ;
						}
					}
					else
					{
						MessageBox.Show("Error: " + oGdPicturePDF.GetStat().ToString());
						return;
					}
					oGdPictureImaging.ReleaseGdPictureImage(m_SrcImageID);
					ProgressBar1.Value = i;
					Application.DoEvents();
				}
			}
			else if (m_InputExtension == ".tif")
			{
				int NumberOfPages = oGdPictureImaging.TiffGetPageCount(m_SrcImageID);
				ProgressBar1.Maximum = NumberOfPages;
				for (int i = 1; i <= NumberOfPages; i++)
				{
					oGdPictureImaging.TiffSelectPage(m_SrcImageID, i);
					m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + "_Split_" + i.ToString() + m_OutPutExtension);
					SaveImage();
					if (m_Status != GdPictureStatus.OK)
					{
						m_Status = GdPictureStatus.OK;
						ProgressBar1.Value = 0;
						return;
					}
				}
			}
			else if (m_InputExtension == ".gif")
			{
				int NumberOfPages = oGdPictureImaging.GifGetFrameCount(m_SrcImageID);
				ProgressBar1.Maximum = NumberOfPages;
				for (int i = 1; i <= NumberOfPages; i++)
				{
					oGdPictureImaging.GifSelectFrame(m_SrcImageID, i);
					m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + "_Split_" + i.ToString() + m_OutPutExtension);
					SaveImage();
					if (m_Status != GdPictureStatus.OK)
					{
						m_Status = GdPictureStatus.OK;
						ProgressBar1.Value = 0;
						return ;
					}
					ProgressBar1.Value = i;
					Application.DoEvents();
				}
			}
			else
			{
				int NumberOfPages = oGdPictureImaging.JBIG2GetPageCount(m_SrcImageID);
				ProgressBar1.Maximum = NumberOfPages;
				for (int i = 1; i <= NumberOfPages; i++)
				{
					oGdPictureImaging.JBIG2SelectPage(m_SrcImageID, i);
					m_DestinationPath = Path.Combine(m_DestinationFolder, m_Name + "_Split_" + i.ToString() + m_OutPutExtension);
					SaveImage();
					if (m_Status != GdPictureStatus.OK)
					{
						m_Status = GdPictureStatus.OK;
						ProgressBar1.Value = 0;
						return ;
					}
					ProgressBar1.Value = i;
					Application.DoEvents();
				}
			}
		}
		
		
		//Method to save any multipage file to another multipage file
		private void MultiToMulti()
		{
			if (m_InputExtension == ".pdf")
			{
				int NumberOfPages = oGdPicturePDF.GetPageCount();
				ProgressBar1.Maximum = NumberOfPages;
				for (int i = 1; i <= NumberOfPages; i++)
				{
					oGdPicturePDF.SelectPage(i);
					m_SrcImageID = oGdPicturePDF.RenderPageToGdPictureImage(200, true);
					if (m_SrcImageID != 0)
					{
						if (i == 1)
						{
							CreateMultiDel.Invoke();
							if (m_Status != GdPictureStatus.OK)
							{
								MessageBox.Show("Error: " + m_Status.ToString());
								m_Status = GdPictureStatus.OK; // Reinitialize Status for next run
								return;
							}
						}
						else
						{
							AddToMultiDel.Invoke();
							if (m_Status != GdPictureStatus.OK)
							{
								MessageBox.Show("Error: " + m_Status.ToString());
								CloseMultiDel.Invoke(); //Release file from memory
								m_Status = GdPictureStatus.OK; // Reinitialize Status for next run
								return;
							}
						}
					}
					else
					{
						MessageBox.Show("Error: " + oGdPicturePDF.GetStat().ToString());
						m_Status = oGdPicturePDF.GetStat();
						m_Status = GdPictureStatus.OK; // Reinitialize Status for next run
						return;
					}
					oGdPictureImaging.ReleaseGdPictureImage(m_SrcImageID);
					ProgressBar1.Value = i;
					Application.DoEvents();
				}
				CloseMultiDel.Invoke();
			}
			else if (m_InputExtension == ".tif")
			{
				int NumberOfPages = oGdPictureImaging.TiffGetPageCount(m_SrcImageID);
				ProgressBar1.Maximum = NumberOfPages;
				for (int i = 1; i <= NumberOfPages; i++)
				{
					oGdPictureImaging.TiffSelectPage(m_SrcImageID, i);
					if (i == 1)
					{
						CreateMultiDel.Invoke();
						if (m_Status != GdPictureStatus.OK)
						{
							MessageBox.Show("Error: " + m_Status.ToString());
							m_Status = GdPictureStatus.OK; // Reinitialize Status for next run
							return;
						}
					}
					else
					{
						AddToMultiDel.Invoke();
						if (m_Status != GdPictureStatus.OK)
						{
							MessageBox.Show("Error: " + m_Status.ToString());
							m_Status = GdPictureStatus.OK; // Reinitialize Status for next run
							CloseMultiDel.Invoke(); //Release file from memory
							return;
						}
					}
					ProgressBar1.Value = i;
					Application.DoEvents();
				}
				CloseMultiDel.Invoke();
				
			}
			else if (m_InputExtension == ".gif")
			{
				int NumberOfPages = oGdPictureImaging.GifGetFrameCount(m_SrcImageID);
				ProgressBar1.Maximum = NumberOfPages;
				for (int i = 1; i <= NumberOfPages; i++)
				{
					oGdPictureImaging.GifSelectFrame(m_SrcImageID, i);
					if (i == 1)
					{
						CreateMultiDel.Invoke();
						if (m_Status != GdPictureStatus.OK)
						{
							MessageBox.Show("Error: " + m_Status.ToString());
							m_Status = GdPictureStatus.OK; // Reinitialize Status for next run
							return;
						}
					}
					else
					{
						AddToMultiDel.Invoke();
						if (m_Status != GdPictureStatus.OK)
						{
							MessageBox.Show("Error: " + m_Status.ToString());
							CloseMultiDel.Invoke(); //Release file from memory
							m_Status = GdPictureStatus.OK; // Reinitialize Status for next run
							return;
						}
					}
					ProgressBar1.Value = i;
					Application.DoEvents();
				}
				CloseMultiDel.Invoke();
			}
			else
			{
				int NumberOfPages = oGdPictureImaging.JBIG2GetPageCount(m_SrcImageID);
				ProgressBar1.Maximum = NumberOfPages;
				for (int i = 1; i <= NumberOfPages; i++)
				{
					oGdPictureImaging.JBIG2SelectPage(m_SrcImageID, i);
					if (i == 1)
					{
						CreateMultiDel.Invoke();
						if (m_Status != GdPictureStatus.OK)
						{
							MessageBox.Show("Error: " + m_Status.ToString());
							m_Status = GdPictureStatus.OK; // Reinitialize Status for next run
							return;
						}
					}
					else
					{
						AddToMultiDel.Invoke();
						if (m_Status != GdPictureStatus.OK)
						{
							MessageBox.Show("Error: " + m_Status.ToString());
							CloseMultiDel.Invoke(); //Release file from memory
							m_Status = GdPictureStatus.OK; // Reinitialize Status for next run
							return;
						}
					}
					ProgressBar1.Value = i;
					Application.DoEvents();
				}
				CloseMultiDel.Invoke();
			}
		}
		
		///'''''''''''''''''''''''''''''''''''''''''''''
		//Methods for Saving Single Images
		///'''''''''''''''''''''''''''''''''''''''''''''
		//Save BMP file
		private void SaveToBMP()
		{
			GdPictureStatus Status = oGdPictureImaging.SaveAsBMP(m_SrcImageID, m_DestinationPath);
			if (Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + Status.ToString());
			}
		}
		
		//Save single page TIFF file
		private void SaveToSingleTIFF()
		{
			m_Status = oGdPictureImaging.SaveAsTIFF(m_SrcImageID, m_DestinationPath, TiffCompression.TiffCompressionAUTO);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save single frame GIF file
		private void SaveToSingleGIF()
		{
			m_Status = oGdPictureImaging.SaveAsGIF(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save single page JBIG2 file
		private void SaveToSingleJBIG2()
		{
			m_Status = oGdPictureImaging.SaveAsJBIG2(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save single page PDF file
		private void SaveToSinglePDF()
		{
			m_Status = oGdPictureImaging.SaveAsPDF(m_SrcImageID, m_DestinationPath, false, m_Name, "GdPicture", "", "", "GdPicture File Converter");
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save JPEG file
		private void SaveToJPEG()
		{
			m_Status = oGdPictureImaging.SaveAsJPEG(m_SrcImageID, m_DestinationPath, 75);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save PNG file
		private void SaveToPNG()
		{
			m_Status = oGdPictureImaging.SaveAsPNG(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save EXR file
		private void SaveToEXR()
		{
			m_Status = oGdPictureImaging.SaveAsEXR(m_SrcImageID, m_DestinationPath, ExrCompression.ExrCompressionDefault);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save J2K file
		private void SaveToJ2K()
		{
			m_Status = oGdPictureImaging.SaveAsJ2K(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save JP2 file
		private void SaveToJP2()
		{
			m_Status = oGdPictureImaging.SaveAsJP2(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save PBM file
		private void SaveToPBM()
		{
			m_Status = oGdPictureImaging.SaveAsPBM(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save TGA file
		private void SaveToTGA()
		{
			m_Status = oGdPictureImaging.SaveAsTGA(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save WBMP file
		private void SaveToWBMP()
		{
			m_Status = oGdPictureImaging.SaveAsWBMP(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save WMF file
		private void SaveToWMF()
		{
			m_Status = oGdPictureImaging.SaveAsWMF(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		//Save XMP file
		private void SaveToXMP()
		{
			m_Status = oGdPictureImaging.SaveAsXPM(m_SrcImageID, m_DestinationPath);
			if (m_Status != GdPictureStatus.OK)
			{
				MessageBox.Show("error: " + m_Status.ToString());
			}
		}
		
		///'''''''''''''''''''''''''''''''''''''''''''''
		//Methods for Creating Multipage Files
		///'''''''''''''''''''''''''''''''''''''''''''''
		//Create MultiPage Tiff
		private void CreateMultiPageTIFF()
		{
			m_DestImageID = oGdPictureImaging.CreateClonedGdPictureImage(m_SrcImageID); //This image must be released at the end of the multipage TIFF generation !!
			if (m_DestImageID == 0)
			{
				m_Status = oGdPictureImaging.GetStat();
			}
			m_Status = oGdPictureImaging.TiffSaveAsMultiPageFile(m_DestImageID, Path.Combine(m_DestinationFolder, m_Name + m_OutPutExtension), TiffCompression.TiffCompressionAUTO);
		}
		
		//Create MultiPage PDF
		private void CreateMultiPagePDF()
		{
			m_Status = m_DestPDF.NewPDF();
			if (m_Status != GdPictureStatus.OK)
			{
				return;
			}
			AddToMultiPDF();
		}
		
		//Create MultiPage JBIG2
		private void CreateMultiPageJBIG2()
		{
			m_DestImageID = oGdPictureImaging.CreateClonedGdPictureImage(m_SrcImageID); //This image must be released at the end of the multipage TIFF generation !!
			if (m_DestImageID == 0)
			{
				m_Status = oGdPictureImaging.GetStat();
			}
			m_Status = oGdPictureImaging.JBIG2SaveAsMultiPageFile(m_DestImageID, Path.Combine(m_DestinationFolder, m_Name + m_OutPutExtension));
		}
		
		//Create MultiPage GIF
		private void CreateMultiPageGIF()
		{
			m_DestImageID = oGdPictureImaging.GifCreateMultiFrameFromGdPictureImage(m_SrcImageID); //This image must be released at the end of the multipage TIFF generation !!
			if (m_DestImageID == 0)
			{
				m_Status = oGdPictureImaging.GetStat();
			}
		}
		
		
		///'''''''''''''''''''''''''''''''''''''''''''''
		//Methods for Adding pages to Multipage Files
		///'''''''''''''''''''''''''''''''''''''''''''''
		//Add page to MultiPage Tiff
		private void AddToMultiTIFF()
		{
			m_Status = oGdPictureImaging.TiffAddToMultiPageFile(m_DestImageID, m_SrcImageID);
		}
		
		//Add page to MultiPage PDF
		private void AddToMultiPDF()
		{
			string image_res_name = m_DestPDF.AddImageFromGdPictureImage(m_SrcImageID, false, true);
		}
		
		//Add frame to MultiFrame Gif
		private void AddToMultiGIF()
		{
			m_Status = oGdPictureImaging.GifAppendFrameFromGdPictureImage(m_DestImageID, m_SrcImageID);
		}
		
		//Add page to MultiPage Jbig2
		private void AddToMultiJBIG2()
		{
			m_Status = oGdPictureImaging.JBIG2AddToMultiPageFile(m_DestImageID, m_SrcImageID);
		}
		
		///'''''''''''''''''''''''''''''''''''''''''''''
		//Methods for Closing Multipage Files
		///'''''''''''''''''''''''''''''''''''''''''''''
		//Close MultiPage Tiff
		private void CloseMultiTIFF()
		{
			oGdPictureImaging.TiffCloseMultiPageFile(m_DestImageID);
			oGdPictureImaging.ReleaseGdPictureImage(m_DestImageID);
		}
		
		//Close MultiPage PDF
		private void CloseMultiPDF()
		{
			if (m_Status == GdPictureStatus.OK) //If Last Add frame process succeeded
			{
				m_DestPDF.SaveToFile(Path.Combine(m_DestinationFolder, m_Name + m_OutPutExtension));
			}
			m_DestPDF.CloseDocument();
		}
		
		//Close MultiFrame Gif
		private void CloseMultiGIF()
		{
			if (m_Status == GdPictureStatus.OK) //If Last Add frame process succeeded
			{
				oGdPictureImaging.GifSaveMultiFrameToFile(m_DestImageID, Path.Combine(m_DestinationFolder, m_Name + m_OutPutExtension));
			}
			oGdPictureImaging.ReleaseGdPictureImage(m_DestImageID);
		}
		
		//Close MultiPage Tiff
		private void CloseMultiJBIG2()
		{
			oGdPictureImaging.JBIG2CloseMultiPageFile(m_DestImageID);
			oGdPictureImaging.ReleaseGdPictureImage(m_DestImageID);
		}
	}
	
	
}
