using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace pdf_splitter
{
    partial class Form1 : System.Windows.Forms.Form 
    { 
        
        // Form overrides dispose to clean up the component list.
        [ System.Diagnostics.DebuggerNonUserCode() ]
        protected override void Dispose( bool disposing ) 
        { 
            if ( disposing && components != null ) 
            { 
                components.Dispose(); 
            } 
            base.Dispose( disposing ); 
        } 
        
        
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components; 
        
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() 
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label8 = new System.Windows.Forms.Label();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(12, 16);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(493, 31);
            this.Label8.TabIndex = 32;
            this.Label8.Text = "PDF Splitter - http://www.gdpicture.com";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(19, 251);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(775, 25);
            this.ProgressBar1.TabIndex = 28;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(864, 238);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(193, 41);
            this.Button3.TabIndex = 27;
            this.Button3.Text = "Start !";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(747, 126);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(47, 25);
            this.Button2.TabIndex = 26;
            this.Button2.Text = "...";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(19, 132);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(123, 17);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "Destination folder:";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(149, 127);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new System.Drawing.Size(588, 22);
            this.TextBox3.TabIndex = 24;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(747, 94);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(47, 25);
            this.Button1.TabIndex = 23;
            this.Button1.Text = "...";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(19, 100);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 17);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Input file:";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(149, 95);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(588, 22);
            this.TextBox2.TabIndex = 21;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(1004, 100);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 17);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "page.";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(931, 95);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(64, 22);
            this.TextBox1.TabIndex = 19;
            this.TextBox1.Text = "2";
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(847, 100);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 17);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Split each:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 288);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "GdPicture.NET - PDF Splitter Sample  -  http://www.gdpicture.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        } 
        
        internal  System.Windows.Forms.Label Label8; 
        internal  System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1; 
        internal  System.Windows.Forms.OpenFileDialog OpenFileDialog1; 
        internal  System.Windows.Forms.ProgressBar ProgressBar1; 
        internal  System.Windows.Forms.Button Button3; 
        internal  System.Windows.Forms.Button Button2; 
        public  System.Windows.Forms.ToolTip ToolTip1; 
        internal  System.Windows.Forms.Label Label4; 
        internal  System.Windows.Forms.TextBox TextBox3; 
        internal  System.Windows.Forms.Button Button1; 
        internal  System.Windows.Forms.Label Label3; 
        internal  System.Windows.Forms.TextBox TextBox2; 
        internal  System.Windows.Forms.Label Label2; 
        internal  System.Windows.Forms.TextBox TextBox1; 
        internal  System.Windows.Forms.Label Label1; 
    } 
    
    
} 
