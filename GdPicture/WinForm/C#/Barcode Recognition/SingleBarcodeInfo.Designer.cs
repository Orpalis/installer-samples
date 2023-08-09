

namespace barcode_recognition
{
    public partial class SingleBarcodeInfo : System.Windows.Forms.UserControl
    {

        //UserControl overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer
        private System.ComponentModel.Container components = null;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.BarcodeNumber = new System.Windows.Forms.GroupBox();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.BarcodeNumber.SuspendLayout();
            this.SuspendLayout();
            //
            //BarcodeNumber
            //
            this.BarcodeNumber.Controls.Add(this.Info);
            this.BarcodeNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodeNumber.Location = new System.Drawing.Point(0, 0);
            this.BarcodeNumber.Name = "BarcodeNumber";
            this.BarcodeNumber.Size = new System.Drawing.Size(454, 122);
            this.BarcodeNumber.TabIndex = 0;
            this.BarcodeNumber.TabStop = false;
            //
            //Info
            //
            this.Info.BackColor = System.Drawing.SystemColors.Menu;
            this.Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info.Location = new System.Drawing.Point(3, 16);
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Size = new System.Drawing.Size(448, 103);
            this.Info.TabIndex = 0;
            this.Info.Text = "";
            //
            //SingleBarcodeInfo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0F), (float)(13.0F));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BarcodeNumber);
            this.Name = "SingleBarcodeInfo";
            this.Size = new System.Drawing.Size(454, 122);
            this.BarcodeNumber.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.GroupBox BarcodeNumber;
        internal System.Windows.Forms.RichTextBox Info;

    }

}
