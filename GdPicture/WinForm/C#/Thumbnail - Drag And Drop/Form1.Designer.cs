using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace thumbnail_drag_drop
{
    partial class Form1 : System.Windows.Forms.Form 
    {
        public Form1()
        {
            InitializeComponent(); 

        } 
        
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
            this.Button1 = new System.Windows.Forms.Button();
            this.ThumbnailEx2 = new GdPicture14.ThumbnailEx();
            this.ThumbnailEx1 = new GdPicture14.ThumbnailEx();
            this.chkMoveAfter = new System.Windows.Forms.CheckBox();
            this.chkIncludeSubfolders = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(16, 678);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(368, 63);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Load From Directory...";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ThumbnailEx2
            // 
            this.ThumbnailEx2.AllowDrop = true;
            this.ThumbnailEx2.AllowDropFiles = false;
            this.ThumbnailEx2.AllowMoveItems = false;
            this.ThumbnailEx2.BackColor = System.Drawing.SystemColors.Control;
            this.ThumbnailEx2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ThumbnailEx2.CheckBoxes = false;
            this.ThumbnailEx2.CheckBoxesMarginLeft = 0;
            this.ThumbnailEx2.CheckBoxesMarginTop = 0;
            this.ThumbnailEx2.DefaultItemTextPrefix = "Page ";
            this.ThumbnailEx2.DisplayAnnotations = true;
            this.ThumbnailEx2.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            this.ThumbnailEx2.HotTracking = false;
            this.ThumbnailEx2.Location = new System.Drawing.Point(769, 15);
            this.ThumbnailEx2.LockGdViewerEvents = false;
            this.ThumbnailEx2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThumbnailEx2.MultiSelect = true;
            this.ThumbnailEx2.Name = "ThumbnailEx2";
            this.ThumbnailEx2.OwnDrop = true;
            this.ThumbnailEx2.PauseThumbsLoading = false;
            this.ThumbnailEx2.PdfIncreaseTextContrast = false;
            this.ThumbnailEx2.PreloadAllItems = true;
            this.ThumbnailEx2.RotateExif = true;
            this.ThumbnailEx2.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ThumbnailEx2.ShowText = true;
            this.ThumbnailEx2.Size = new System.Drawing.Size(732, 655);
            this.ThumbnailEx2.TabIndex = 1;
            this.ThumbnailEx2.TextMarginLeft = 0;
            this.ThumbnailEx2.TextMarginTop = 0;
            this.ThumbnailEx2.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical;
            this.ThumbnailEx2.ThumbnailBorder = true;
            this.ThumbnailEx2.ThumbnailForeColor = System.Drawing.Color.Black;
            this.ThumbnailEx2.ThumbnailSize = new System.Drawing.Size(128, 128);
            this.ThumbnailEx2.ThumbnailSpacing = new System.Drawing.Size(0, 0);
            this.ThumbnailEx2.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            this.ThumbnailEx2.DragDrop += new System.Windows.Forms.DragEventHandler(this.ThumbnailEx2_DragDrop);
            this.ThumbnailEx2.DragEnter += new System.Windows.Forms.DragEventHandler(this.ThumbnailEx2_DragEnter);
            this.ThumbnailEx2.DragOver += new System.Windows.Forms.DragEventHandler(this.ThumbnailEx2_DragOver);
            // 
            // ThumbnailEx1
            // 
            this.ThumbnailEx1.AllowDrop = true;
            this.ThumbnailEx1.AllowDropFiles = false;
            this.ThumbnailEx1.AllowMoveItems = false;
            this.ThumbnailEx1.BackColor = System.Drawing.SystemColors.Control;
            this.ThumbnailEx1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ThumbnailEx1.CheckBoxes = false;
            this.ThumbnailEx1.CheckBoxesMarginLeft = 0;
            this.ThumbnailEx1.CheckBoxesMarginTop = 0;
            this.ThumbnailEx1.DefaultItemTextPrefix = "Page ";
            this.ThumbnailEx1.DisplayAnnotations = true;
            this.ThumbnailEx1.HorizontalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            this.ThumbnailEx1.HotTracking = false;
            this.ThumbnailEx1.Location = new System.Drawing.Point(16, 15);
            this.ThumbnailEx1.LockGdViewerEvents = false;
            this.ThumbnailEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThumbnailEx1.MultiSelect = true;
            this.ThumbnailEx1.Name = "ThumbnailEx1";
            this.ThumbnailEx1.OwnDrop = true;
            this.ThumbnailEx1.PauseThumbsLoading = false;
            this.ThumbnailEx1.PdfIncreaseTextContrast = false;
            this.ThumbnailEx1.PreloadAllItems = true;
            this.ThumbnailEx1.RotateExif = true;
            this.ThumbnailEx1.SelectedThumbnailBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ThumbnailEx1.ShowText = true;
            this.ThumbnailEx1.Size = new System.Drawing.Size(732, 655);
            this.ThumbnailEx1.TabIndex = 0;
            this.ThumbnailEx1.TextMarginLeft = 0;
            this.ThumbnailEx1.TextMarginTop = 0;
            this.ThumbnailEx1.ThumbnailAlignment = GdPicture14.ThumbnailAlignment.ThumbnailAlignmentVertical;
            this.ThumbnailEx1.ThumbnailBorder = true;
            this.ThumbnailEx1.ThumbnailForeColor = System.Drawing.Color.Black;
            this.ThumbnailEx1.ThumbnailSize = new System.Drawing.Size(128, 128);
            this.ThumbnailEx1.ThumbnailSpacing = new System.Drawing.Size(0, 0);
            this.ThumbnailEx1.VerticalTextAlignment = GdPicture14.TextAlignment.TextAlignmentCenter;
            this.ThumbnailEx1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ThumbnailEx1_DragDrop);
            this.ThumbnailEx1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ThumbnailEx1_DragEnter);
            this.ThumbnailEx1.DragOver += new System.Windows.Forms.DragEventHandler(this.ThumbnailEx1_DragOver);
            // 
            // chkMoveAfter
            // 
            this.chkMoveAfter.AutoSize = true;
            this.chkMoveAfter.Location = new System.Drawing.Point(392, 678);
            this.chkMoveAfter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMoveAfter.Name = "chkMoveAfter";
            this.chkMoveAfter.Size = new System.Drawing.Size(170, 21);
            this.chkMoveAfter.TabIndex = 3;
            this.chkMoveAfter.Text = "Move after destination";
            this.chkMoveAfter.UseVisualStyleBackColor = true;
            // 
            // chkIncludeSubfolders
            // 
            this.chkIncludeSubfolders.AutoSize = true;
            this.chkIncludeSubfolders.Location = new System.Drawing.Point(392, 706);
            this.chkIncludeSubfolders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            this.chkIncludeSubfolders.Size = new System.Drawing.Size(145, 21);
            this.chkIncludeSubfolders.TabIndex = 4;
            this.chkIncludeSubfolders.Text = "Include subfolders";
            this.chkIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 770);
            this.Controls.Add(this.chkIncludeSubfolders);
            this.Controls.Add(this.chkMoveAfter);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ThumbnailEx2);
            this.Controls.Add(this.ThumbnailEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "GdPicture.NET - Thumbnail drag & drop Demo  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal GdPicture14.ThumbnailEx ThumbnailEx1; 
        internal GdPicture14.ThumbnailEx ThumbnailEx2; 
        internal System.Windows.Forms.Button Button1; 
        internal System.Windows.Forms.CheckBox chkMoveAfter; 
        internal System.Windows.Forms.CheckBox chkIncludeSubfolders; 
        
    } 
    
    
} 
