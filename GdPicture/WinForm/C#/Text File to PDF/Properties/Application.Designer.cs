// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.1008
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------



namespace VB_Text_File_to_PDF
{
	namespace My
	{
		
		//REMARQUE : ce fichier étant généré automatiquement, ne le modifiez pas directement. Pour apporter des modifications,
		// ou si vous rencontrez des erreurs de build dans ce fichier, accédez au Concepteur de projets
		// (allez dans les propriétés du projet ou double-cliquez sur le noeud My project dans
		// l'Explorateur de solutions), puis apportez vos modifications sous l'onglet Application.
		//
		public partial class MyApplication : global::Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{
			[STAThread]
			static void Main()
			{
				(new MyApplication()).Run(new string[] {});
			}
			
			[global::System.Diagnostics.DebuggerStepThrough()]public MyApplication() : base(global::Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
			{
				
				
				
				this.IsSingleInstance = false;
				this.EnableVisualStyles = true;
				this.SaveMySettingsOnExit = true;
				this.ShutdownStyle = global::Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;
			}
			
			[global::System.Diagnostics.DebuggerStepThroughAttribute()]protected override void OnCreateMainForm()
			{
				this.MainForm = global::VB_Text_File_to_PDF.Form1.Default;
			}
		}
	}
	
}