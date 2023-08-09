using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace document_recognition
{
    partial class Form1 
    { 
        
        // Form overrides dispose to clean up the component list.
        [ System.Diagnostics.DebuggerNonUserCode() ]
        protected override void Dispose( bool disposing ) 
        { 
            try 
            { 
                if ( disposing && components != null ) 
                { 
                    components.Dispose(); 
                } 
            } 
            finally 
            { 
                base.Dispose( disposing ); 
            } 
        } 
        
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components; 
        
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstTemplatesView = new System.Windows.Forms.ListView();
            this.colTemplateName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTemplateID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTemplateImgCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSaveADRConfig = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btLoadADRConfig = new System.Windows.Forms.Button();
            this.btNewTemplate = new System.Windows.Forms.Button();
            this.btAddTemplateImage = new System.Windows.Forms.Button();
            this.btDeleteTemplate = new System.Windows.Forms.Button();
            this.btClearConfig = new System.Windows.Forms.Button();
            this.btIdentifyDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTemplatesView
            // 
            this.lstTemplatesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTemplateName,
            this.colTemplateID,
            this.colTemplateImgCount});
            this.lstTemplatesView.FullRowSelect = true;
            this.lstTemplatesView.GridLines = true;
            this.lstTemplatesView.HideSelection = false;
            this.lstTemplatesView.Location = new System.Drawing.Point(21, 54);
            this.lstTemplatesView.Margin = new System.Windows.Forms.Padding(4);
            this.lstTemplatesView.MultiSelect = false;
            this.lstTemplatesView.Name = "lstTemplatesView";
            this.lstTemplatesView.Size = new System.Drawing.Size(543, 368);
            this.lstTemplatesView.TabIndex = 0;
            this.lstTemplatesView.UseCompatibleStateImageBehavior = false;
            this.lstTemplatesView.View = System.Windows.Forms.View.Details;
            // 
            // colTemplateName
            // 
            this.colTemplateName.Text = "Template Name";
            this.colTemplateName.Width = 256;
            // 
            // colTemplateID
            // 
            this.colTemplateID.Text = "ID";
            this.colTemplateID.Width = 67;
            // 
            // colTemplateImgCount
            // 
            this.colTemplateImgCount.Text = "Image Count";
            this.colTemplateImgCount.Width = 79;
            // 
            // btSaveADRConfig
            // 
            this.btSaveADRConfig.Location = new System.Drawing.Point(415, 431);
            this.btSaveADRConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btSaveADRConfig.Name = "btSaveADRConfig";
            this.btSaveADRConfig.Size = new System.Drawing.Size(152, 42);
            this.btSaveADRConfig.TabIndex = 1;
            this.btSaveADRConfig.Text = "Save config. to file";
            this.btSaveADRConfig.UseVisualStyleBackColor = true;
            this.btSaveADRConfig.Click += new System.EventHandler(this.btSaveADRConfig_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(169, 17);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "ADR Templates Overview";
            // 
            // btLoadADRConfig
            // 
            this.btLoadADRConfig.Location = new System.Drawing.Point(255, 431);
            this.btLoadADRConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadADRConfig.Name = "btLoadADRConfig";
            this.btLoadADRConfig.Size = new System.Drawing.Size(152, 42);
            this.btLoadADRConfig.TabIndex = 3;
            this.btLoadADRConfig.Text = "Load config. from file";
            this.btLoadADRConfig.UseVisualStyleBackColor = true;
            this.btLoadADRConfig.Click += new System.EventHandler(this.btLoadADRConfig_Click);
            // 
            // btNewTemplate
            // 
            this.btNewTemplate.Location = new System.Drawing.Point(584, 54);
            this.btNewTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.btNewTemplate.Name = "btNewTemplate";
            this.btNewTemplate.Size = new System.Drawing.Size(157, 39);
            this.btNewTemplate.TabIndex = 4;
            this.btNewTemplate.Text = "Create new template";
            this.btNewTemplate.UseVisualStyleBackColor = true;
            this.btNewTemplate.Click += new System.EventHandler(this.btNewTemplate_Click);
            // 
            // btAddTemplateImage
            // 
            this.btAddTemplateImage.Location = new System.Drawing.Point(584, 101);
            this.btAddTemplateImage.Margin = new System.Windows.Forms.Padding(4);
            this.btAddTemplateImage.Name = "btAddTemplateImage";
            this.btAddTemplateImage.Size = new System.Drawing.Size(157, 54);
            this.btAddTemplateImage.TabIndex = 5;
            this.btAddTemplateImage.Text = "add image to template";
            this.btAddTemplateImage.UseVisualStyleBackColor = true;
            this.btAddTemplateImage.Click += new System.EventHandler(this.btAddTemplateImage_Click);
            // 
            // btDeleteTemplate
            // 
            this.btDeleteTemplate.Location = new System.Drawing.Point(584, 162);
            this.btDeleteTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteTemplate.Name = "btDeleteTemplate";
            this.btDeleteTemplate.Size = new System.Drawing.Size(157, 39);
            this.btDeleteTemplate.TabIndex = 6;
            this.btDeleteTemplate.Text = "Delete template";
            this.btDeleteTemplate.UseVisualStyleBackColor = true;
            this.btDeleteTemplate.Click += new System.EventHandler(this.btDeleteTemplate_Click);
            // 
            // btClearConfig
            // 
            this.btClearConfig.Location = new System.Drawing.Point(21, 431);
            this.btClearConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btClearConfig.Name = "btClearConfig";
            this.btClearConfig.Size = new System.Drawing.Size(152, 42);
            this.btClearConfig.TabIndex = 7;
            this.btClearConfig.Text = "Clear config.";
            this.btClearConfig.UseVisualStyleBackColor = true;
            this.btClearConfig.Click += new System.EventHandler(this.btClearConfig_Click);
            // 
            // btIdentifyDocument
            // 
            this.btIdentifyDocument.Location = new System.Drawing.Point(21, 517);
            this.btIdentifyDocument.Margin = new System.Windows.Forms.Padding(4);
            this.btIdentifyDocument.Name = "btIdentifyDocument";
            this.btIdentifyDocument.Size = new System.Drawing.Size(720, 89);
            this.btIdentifyDocument.TabIndex = 8;
            this.btIdentifyDocument.Text = "Identify Document...";
            this.btIdentifyDocument.UseVisualStyleBackColor = true;
            this.btIdentifyDocument.Click += new System.EventHandler(this.btIdentifyDocument_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 619);
            this.Controls.Add(this.btIdentifyDocument);
            this.Controls.Add(this.btClearConfig);
            this.Controls.Add(this.btDeleteTemplate);
            this.Controls.Add(this.btAddTemplateImage);
            this.Controls.Add(this.btNewTemplate);
            this.Controls.Add(this.btLoadADRConfig);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btSaveADRConfig);
            this.Controls.Add(this.lstTemplatesView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GdPicture.NET - Document Recognition Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal  System.Windows.Forms.ListView lstTemplatesView; 
        internal  System.Windows.Forms.ColumnHeader colTemplateName; 
        internal  System.Windows.Forms.ColumnHeader colTemplateID; 
        internal  System.Windows.Forms.ColumnHeader colTemplateImgCount; 
        internal  System.Windows.Forms.Button btSaveADRConfig; 
        internal  System.Windows.Forms.Label Label1; 
        internal  System.Windows.Forms.Button btLoadADRConfig; 
        internal  System.Windows.Forms.Button btNewTemplate; 
        internal  System.Windows.Forms.Button btAddTemplateImage; 
        internal  System.Windows.Forms.Button btDeleteTemplate; 
        internal  System.Windows.Forms.Button btClearConfig; 
        internal  System.Windows.Forms.Button btIdentifyDocument; 


        
    } 
    
    
} 
