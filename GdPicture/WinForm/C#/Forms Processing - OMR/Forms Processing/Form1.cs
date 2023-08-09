using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

using System.Drawing.Drawing2D;
using System.IO;
using GdPicture14;


namespace Csharp_Forms_Processing
{
	public partial class Form1
	{
		public Form1()
		{
			
			oGUIManager = new GUIManager(this);
			
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Form1 defaultInstance;
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
		
		public GdPictureImaging oGdPictureImaging = new GdPictureImaging();
		private GUIManager oGUIManager; 
		
		public void Form1_Load(System.Object sender, System.EventArgs e)
		{
            LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
			formViewer.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
			imagesViewer.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
		}
		
		public void formSetUpButton_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.OpenFormSetUP();
		}
		
		public void processFormsButton_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.OpenProcessForms();
		}
		
		public void loadFormButton_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.LoadTemplateForm();
		}
		
		public void checkORCircle_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			oGUIManager.CheckOrCircle_CheckedChanged();
		}
		
		public void oval_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			oGUIManager.Oval_CheckedChanged();
		}
		
		public void hasCharacter_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			oGUIManager.HasCharacter_CheckedChanged();
		}
		
		public void useConfidence_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			oGUIManager.UseConfidence_CheckedChanged();
		}
		
		public void sensitivity_Scroll(System.Object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			oGUIManager.Sensitivity_Scroll();
		}
		
		public void minConfidenceValue_ValueChanged(System.Object sender, System.EventArgs e)
		{
			oGUIManager.MinConfidenceValue_Changed();
		}
		
		public void selectAnchorButton_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.SelectAnchor();
		}
		
		public void formViewer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			oGUIManager.MouseUP();
		}
		
		public void formViewer_RegionEditedByUser(int RegionID)
		{
			oGUIManager.RegionEditedByUser(RegionID);
		}
		
		public void addFieldsButton_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.AddFields();
		}
		
		public void loadImagesButton_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.LoadImagesButton_Click();
		}
		
		public void clearImagesButton_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.ClearFilledForms();
		}
		
		public void ListBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			oGUIManager.ListBox1_SelectedIndexChanged();
		}
		
		public void omrImagesButton_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.OMRImagesButton_Click();
		}
		
		public void NewProjectToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.NewProject();
		}
		
		public void CloseProjectToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.CloseProject();
		}
		
		public void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		
		public void addSingleFieldButon_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.AddSingleField();
		}
		
		public void addMultipleFieldsButton_Click(System.Object sender, System.EventArgs e)
		{
			oGUIManager.AddMultipleFields();
		}
		
		
	}
	
}
