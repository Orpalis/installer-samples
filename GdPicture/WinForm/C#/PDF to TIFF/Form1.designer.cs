using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace PDF_to_TIFF
{
  
    partial class Form1 : System.Windows.Forms.Form 
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
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(8, 164);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(334, 21);
            this.ProgressBar1.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(458, 155);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(95, 30);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Start !";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(8, 46);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(500, 20);
            this.TextBox1.TabIndex = 2;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(514, 46);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(39, 20);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "...";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Input file:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 83);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(110, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Compression scheme:";
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "AUTO",
            "CCITT3",
            "CCITT4",
            "JPEG",
            "LZW",
            "NONE",
            "RLE",
            "ZIP"});
            this.ComboBox1.Location = new System.Drawing.Point(134, 80);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(91, 21);
            this.ComboBox1.Sorted = true;
            this.ComboBox1.TabIndex = 7;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 115);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Resolution:";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(134, 111);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(47, 20);
            this.TextBox2.TabIndex = 9;
            this.TextBox2.Text = "200";
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 205);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ProgressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GdPicture.NET - PDF to TIFF Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal  System.Windows.Forms.ProgressBar ProgressBar1; 
        internal  System.Windows.Forms.Button Button1; 
        internal  System.Windows.Forms.TextBox TextBox1; 
        internal  System.Windows.Forms.Button Button2; 
        internal  System.Windows.Forms.OpenFileDialog OpenFileDialog1; 
        internal  System.Windows.Forms.Label Label1; 
        internal  System.Windows.Forms.Label Label2; 
        internal  System.Windows.Forms.ComboBox ComboBox1; 
        internal  System.Windows.Forms.Label Label3; 
        internal  System.Windows.Forms.TextBox TextBox2; 
        
    } 
    
    
} 
