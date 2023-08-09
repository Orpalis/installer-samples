
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Collections;
using System.Windows.Forms;


using GdPicture14;


namespace PDF_to_TIFF
{
	
	public partial class Form1
	{
		public Form1()
		{
			InitializeComponent();
			
			//Added to support default instance behaviour in C#
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
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		
		public void Button2_Click(System.Object sender, System.EventArgs e)
		{
			OpenFileDialog1.FileName = "";
			OpenFileDialog1.Filter = "PDF Document (*.pdf)|*.pdf";
			OpenFileDialog1.Multiselect = false;
			if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				TextBox1.Text = OpenFileDialog1.FileName;
			}
		}
		
		
		public void Form1_Load(System.Object sender, System.EventArgs e)
		{
			LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
			oLicenseManager.RegisterKEY("XXX"); //Please, replace XXX by a valid demo or commercial license key.
			ComboBox1.Text = "AUTO";
		}
		
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (TextBox1.Text != "")
			{
				int multiTiffID = 0;

                TiffCompression compressionScheme ;
				GdPictureStatus status = GdPictureStatus.OK;
				
				switch (ComboBox1.Text)
				{
					case "AUTO":
                    default:
						compressionScheme = TiffCompression.TiffCompressionAUTO;
						break;
					case "JPEG":
						compressionScheme = TiffCompression.TiffCompressionJPEG;
						break;
					case "CCITT3":
						compressionScheme = TiffCompression.TiffCompressionCCITT3;
						break;
					case "CCITT4":
						compressionScheme = TiffCompression.TiffCompressionCCITT4;
						break;
					case "LZW":
						compressionScheme = TiffCompression.TiffCompressionLZW;
						break;
					case "RLE":
						compressionScheme = TiffCompression.TiffCompressionRLE;
						break;
					case "NONE":
						compressionScheme = TiffCompression.TiffCompressionNONE;
						break;
					case "ZIP":
						compressionScheme = GdPicture14.TiffCompression.TiffCompressionDEFLATE;
						break;
				}
				
				
				using (GdPicturePDF oGdPicturePDF = new GdPicturePDF())
				{
					string InputFilePath = TextBox1.Text;
					if (oGdPicturePDF.LoadFromFile(InputFilePath, false) == GdPictureStatus.OK)
					{
						ProgressBar1.Maximum = oGdPicturePDF.GetPageCount();

                        int DPI = int.Parse(TextBox2.Text);
						string OutputFilePath = InputFilePath.Substring(0, InputFilePath.Length - 3) + "tif";
						
						using (GdPictureImaging oGdPictureImaging = new GdPictureImaging())
						{
							for (int i = 1; i <= oGdPicturePDF.GetPageCount(); i++)
							{
								if (status == GdPictureStatus.OK)
								{
									oGdPicturePDF.SelectPage(i);
									int RasterizedPageID = oGdPicturePDF.RenderPageToGdPictureImageEx(DPI, true);
									
									//CCITT3 & CCITT4 compression support only bitonal (1 bpp) images !!
									if (compressionScheme == TiffCompression.TiffCompressionCCITT3 || compressionScheme == TiffCompression.TiffCompressionCCITT4)
									{
										oGdPictureImaging.ConvertTo1BppAT(RasterizedPageID);
									}
									
									if (i == 1)
									{
										multiTiffID = RasterizedPageID; //Warning: this image must be released at the end!!!!
										status = oGdPictureImaging.TiffSaveAsMultiPageFile(multiTiffID, OutputFilePath, compressionScheme);
									}
									else
									{
										status = oGdPictureImaging.TiffAddToMultiPageFile(multiTiffID, RasterizedPageID);
										oGdPictureImaging.ReleaseGdPictureImage(RasterizedPageID);
									}
								}
								ProgressBar1.Value = i;
							}
							
							oGdPictureImaging.TiffCloseMultiPageFile(multiTiffID);
							oGdPictureImaging.ReleaseGdPictureImage(multiTiffID);
						}
						
						
						if (status == GdPictureStatus.OK)
						{
							MessageBox.Show("The image " + OutputFilePath + " has been correctly created");
						}
						else
						{
							MessageBox.Show("Error: " + status.ToString());
						}
						oGdPicturePDF.CloseDocument();
					}
					else
					{
						MessageBox.Show("Can\'t open file: " + InputFilePath);
					}
				}
				
			}
			else
			{
				MessageBox.Show("Please, select a file to convert.");
			}
		}
	}
}
