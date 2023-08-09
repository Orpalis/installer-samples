using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GdPicture14;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace VB_Text_File_to_PDF
{
    public partial class Form1
    {
        #region Default Instance

        private static Form1 _defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static Form1 Default
        {
            get
            {
                if (_defaultInstance == null)
                {
                    _defaultInstance = new Form1();
                    _defaultInstance.FormClosed += defaultInstance_FormClosed;
                }

                return _defaultInstance;
            }
        }

        private static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            _defaultInstance = null;
        }

        #endregion

        private Form1()
        {
            InitializeComponent();

            //Added to support default instance behavior in C#
            if (_defaultInstance == null)
            {
                _defaultInstance = this;
            }
        }

        /// <summary>
        /// To hold the size of each type of paper.
        /// </summary>
        private struct Paper
        {
            public string PaperName;
            public float PaperWidth;
            public float PaperHeight;
        }

        private readonly GdPicturePDF _gdPicturePdf = new GdPicturePDF();
        private float _posY;
        private string _fontId;
        private float _leftMargin;
        private float _rightMargin;
        private float _topMargin;
        private float _bottomMargin;
        private float _lineHeight;
        private float _availableWidth = 215.9F;
        private float _availableHeight = 279.4F;
        private float _pageWidth = 215.9F;
        private float _pageHeight = 279.4F;
        private float _textSize = 10;

        private const float InterlineInMm = 1;
        private const int TabLenght = 8;

        private readonly Collection _papers = new Collection();

        public void Form1_Load(object sender, EventArgs e)
        {
            LicenseManager licenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            licenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.

            // Create papers collection.
            Paper paper = new Paper
            {
                PaperName = "Letter",
                PaperWidth = 215.9F,
                PaperHeight = 279.4F
            };
            _papers.Add(paper, paper.PaperName);
            paper = new Paper
            {
                PaperName = "Legal",
                PaperWidth = 215.9F,
                PaperHeight = 355.6F
            };
            _papers.Add(paper, paper.PaperName);
            paper = new Paper
            {
                PaperName = "A3",
                PaperWidth = 297,
                PaperHeight = 420
            };
            _papers.Add(paper, paper.PaperName);
            paper = new Paper
            {
                PaperName = "A4",
                PaperWidth = 210,
                PaperHeight = 297
            };
            _papers.Add(paper, paper.PaperName);

            // Add papers to cboPapers.
            for (int i = 1; i <= _papers.Count; i++)
            {
                paper = (Paper)_papers[i];
                cboPapers.Items.Add(paper.PaperName);
            }
            paper = (Paper)_papers[1];
            cboPapers.Text = paper.PaperName;
        }


        public void cmdParcInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files|*.txt|All files|*.*";
            fileDialog.ShowDialog();
            if (fileDialog.FileName == "")
            {
                return;
            }
            txtInputFile.Text = fileDialog.FileName;
        }

        public void cmdParcOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.DefaultExt = "pdf";
            fileDialog.Filter = "Pdf files|*.Pdf|All files|*.*";
            fileDialog.ShowDialog();
            if (fileDialog.FileName == "")
            {
                return;
            }
            txtOutputFile.Text = fileDialog.FileName;
        }

        public void cmdGo_Click(object sender, EventArgs e)
        {
            string currentLine = "";
            string fileContent = default(string);

            if (txtInputFile.Text == "")
            {
                MessageBox.Show("Set the text file to be converted");
                return;
            }
            if (txtOutputFile.Text == "")
            {
                MessageBox.Show("Set the Pdf filename");
                return;
            }
            if (File.Exists(txtInputFile.Text) == false)
            {
                MessageBox.Show("The text file does not exist");
                return;
            }

            Paper p = (Paper)_papers[cboPapers.Text];

            // Landscape or portrait mode
            if (radLandscape.Checked)
            {
                _pageWidth = p.PaperHeight;
                _pageHeight = p.PaperWidth;
            }
            else
            {
                _pageWidth = p.PaperWidth;
                _pageHeight = p.PaperHeight;
            }

            // Margins of page
            _leftMargin = float.Parse(txtLeftMargin.Text);
            _rightMargin = float.Parse(txtRightMargin.Text);
            _topMargin = float.Parse(txtTopMargin.Text);
            _bottomMargin = float.Parse(txtBottomMargin.Text);

            // Text size
            _textSize = float.Parse(txtTextSize.Text);

            // Calculate width and height of area to draw.
            _availableWidth = _pageWidth - _leftMargin - _rightMargin;
            _availableHeight = _pageHeight - _bottomMargin;

            if (_availableHeight < 10 | _availableWidth < 10)
            {
                MessageBox.Show("Area too small to write on, please make margins smaller, or pick a larger paper size");
                return;
            }

            ProgressBar1.Visible = true;

            // Read the content of the text file in a string/
            fileContent = (new ServerComputer()).FileSystem.ReadAllText(txtInputFile.Text, Encoding.Default);

            // Clear all line feed.
            fileContent = fileContent.Replace("\r\n", Constants.vbCr); //replace CR+LF to a single CR
            fileContent = fileContent.Replace(Constants.vbLf, Constants.vbCr); //replace LF to CR
                                                                               //now filecontent has only CR as lines separator


            ProgressBar1.Maximum = fileContent.Length;

            // Let us create a new pdf.
            GdPictureStatus status = _gdPicturePdf.NewPDF();
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("Error creating a new PDF : " + status);
                return;
            }

            // Add a font.
            _fontId = _gdPicturePdf.AddStandardFont(PdfStandardFont.PdfStandardFontCourier);

            // Set coordinates origin and measurement.
            _gdPicturePdf.SetOrigin(PdfOrigin.PdfOriginTopLeft);
            _gdPicturePdf.SetMeasurementUnit(PdfMeasurementUnit.PdfMeasurementUnitMillimeter);

            // Create the first page.
            status = _gdPicturePdf.NewPage(_pageWidth, _pageHeight);
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("Error creating the first page for the pdf : " + status);
                ProgressBar1.Visible = false;
                return;
            }

            _lineHeight = _gdPicturePdf.GetTextHeight(_fontId, _textSize) + InterlineInMm;

            _gdPicturePdf.SetTextSize(_textSize);

            _posY = _topMargin + _lineHeight; // The y position for text is the base line.

            // Proceed with an analisys of the file content, word by word.
            while (fileContent != "")
            {
                // Get word
                string singleWord = GetSingleWord(ref fileContent);
                ProgressBar1.Value = ProgressBar1.Maximum - fileContent.Length;
                Application.DoEvents();
                if (singleWord == Constants.vbCr)
                {
                    // We have a Carriage Return, draw the current line.
                    status = DrawText(ref currentLine);
                    if (status != GdPictureStatus.OK)
                    {
                        MessageBox.Show("Error: " + status);
                        return;
                    }
                }
                else if (singleWord == Constants.vbFormFeed)
                {
                    // We have a form feed, draw the current line.
                    status = DrawText(ref currentLine);
                    if (status != GdPictureStatus.OK)
                    {
                        MessageBox.Show("Error: " + status);
                        return;
                    }
                    _posY += _pageHeight; //to force a new page
                }
                else if (singleWord == "\t")
                {
                    // We have a tabulation, add white space until the next tab.
                    do
                    {
                        currentLine += " ";
                    } while (currentLine.Length % TabLenght != 0);
                }
                else
                {
                    if (_gdPicturePdf.GetTextWidth(_fontId, 10, currentLine + singleWord) > _availableWidth)
                    {
                        // The current line + the word can not be drawn on a single line,
                        // draw the current line.
                        status = DrawText(ref currentLine);
                        if (status != GdPictureStatus.OK)
                        {
                            MessageBox.Show("Error: " + status);
                            return;
                        }
                        // Set current line to the word.
                        currentLine = singleWord;
                    }
                    else
                    {
                        // The current line + the word can be drawn on a single line,
                        // add the word  to the current line.
                        currentLine += singleWord;
                    }
                }
            }

            // Draw the last line.
            status = DrawText(ref currentLine);
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("Error: " + status);
                return;
            }
            status = _gdPicturePdf.SaveToFile(txtOutputFile.Text, false);
            ProgressBar1.Visible = false;
            if (status != GdPictureStatus.OK)
            {
                MessageBox.Show("Error saving the PDF : " + status);
            }
            else
            {
                MessageBox.Show("Done");
            }
        }

        private GdPictureStatus DrawText(ref string textToDraw)
        {
            GdPictureStatus status = GdPictureStatus.OK;
            if (textToDraw.Trim() != "")
            {
                // Control whether the text can be drawn on the current page.
                if (_posY >= _availableHeight)
                {
                    status = _gdPicturePdf.NewPage(_pageWidth, _pageHeight);
                    if (status != GdPictureStatus.OK)
                    {
                        ProgressBar1.Visible = false;
                        MessageBox.Show("Error creating a new page for the pdf : " + status);
                        return status;
                    }
                    _posY = _topMargin + _lineHeight;
                    _gdPicturePdf.SetTextSize(_textSize);
                }
                // Draw the text.
                status = _gdPicturePdf.DrawText(_fontId, _leftMargin, _posY, textToDraw);
                if (status != GdPictureStatus.OK)
                {
                    ProgressBar1.Visible = false;
                    MessageBox.Show("Error drawing a text on the page : " + status);
                    return status;
                }
                textToDraw = "";
                _posY += _lineHeight;
            }
            else
            {
                // Empty line : do not change y position.
                textToDraw = "";
            }
            return status;
        }

        private string GetSingleWord(ref string Buffer)
        {
            // Return the first word in buffer or a CR or a FF.
            string singleChar;
            int posX = 0;
            string singleWord;
            // Get the first char
            singleChar = Buffer.Substring(posX, 1);
            // Check if we have a Carriage Return or a Line Feed.
            if (singleChar == Constants.vbCr || singleChar == Constants.vbFormFeed || singleChar == "\t")
            {
                posX++;
                Buffer = Buffer.Substring(posX);
                return singleChar;
            }
            // Search the end of the word.
            // Preserve leading blanks.
            while (singleChar == " " && posX < Buffer.Length)
            {
                posX++;
                if (posX < Buffer.Length)
                {
                    singleChar = Buffer.Substring(posX, 1);
                }
            }
            // Loop until end of word.
            while (singleChar != " " && singleChar != Constants.vbCr && singleChar != Constants.vbFormFeed && singleChar != "\t" && posX < Buffer.Length)
            {
                posX++;
                if (posX < Buffer.Length)
                {
                    singleChar = Buffer.Substring(posX, 1);
                }
            }
            // Get the word
            singleWord = Buffer.Substring(0, posX);
            // Crop buffer
            Buffer = Buffer.Substring(posX);
            return singleWord;
        }
    }
}
