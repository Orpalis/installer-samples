using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GdPicture14;
using Ocr.Properties;
using System.Collections.Generic;
using System.Diagnostics;
using GdPicture14.Imaging;

namespace Ocr
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The constructor initializes members to their default values.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitialText = Text;
            LoadSettings();
        }

        /// <summary>
        /// The GdPicture license is initialized as soon as the form is loaded.
        /// The language list is populated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LicenseManager licenseManager = new LicenseManager();
            licenseManager.RegisterKEY("XXX");
            //Please replace XXX by a valid demo or commercial key.

            _gdPictureImaging = new GdPictureImaging();
            _gdPictureOcr = new GdPictureOCR();
            _document = new Document(_gdPictureImaging, _gdPictureOcr);

            if (tbResouceFolder.Text.Length == 0)
            {
                tbResouceFolder.Text = licenseManager.GetRedistPath() + "OCR\\";
            }

            OCRLanguage resourceLanguage;
            if (Enum.TryParse<OCRLanguage>(Settings.Default.Language, out resourceLanguage))
            {
                UpdateLanguages(tbResouceFolder.Text, new OCRLanguage[] { resourceLanguage });
            }
            else
            {
                UpdateLanguages(tbResouceFolder.Text, new OCRLanguage[] { OCRLanguage.English });
            }

            UpdateControlsDocumentClosed();
        }

        /// <summary>
        /// The settings are saved when the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        /// The LoadSettings method loads the settings and updates the controls.
        /// </summary>
        private void LoadSettings(bool updateResourceFolder = true)
        {
            if (updateResourceFolder)
            {
                tbResouceFolder.Text = Settings.Default.ResourceFolder;
            }
            chkEnableVigorousDespeckle.Checked = Settings.Default.EnableVigorousDespeckle;
            cbDeskew.Checked = Settings.Default.Deskew;
            chkEnablePreprocessing.Checked = Settings.Default.EnablePreprocessing;
            cbDetectOrientation.Checked = Settings.Default.DetectOrientation;
            cbContext.SelectedIndex = Settings.Default.Context;
            cbMode.SelectedIndex = Settings.Default.Mode;
            cbCharacterSet.SelectedIndex = Settings.Default.CharacterSet;
            cbKeepLineBreaks.Checked = Settings.Default.KeepLineBreaks;
            cbFormat.SelectedIndex = Settings.Default.OutputFormat;
            txtBlackList.Text = Settings.Default.CharBlackList;
        }

        private void ResetSettings()
        {
            Settings.Default.Reset();

            LoadSettings(false);
        }

        /// <summary>
        /// The SaveSettings method updates the settings with the content of the control and saves the settings.
        /// </summary>
        private void SaveSettings()
        {
            Settings.Default.ResourceFolder = tbResouceFolder.Text;
            OCRLanguage[] languages = SelectedLanguages();
            if (languages == null)
            {
                Settings.Default.Language = "";
            }
            else
            {
                Settings.Default.Language = languages[0].ToString();
                for (int i = 1; i < languages.Length; i++)
                {
                    Settings.Default.Language += "|";
                    Settings.Default.Language += languages[i];
                }
            }

            Settings.Default.EnableVigorousDespeckle = chkEnableVigorousDespeckle.Checked;
            Settings.Default.Deskew = cbDeskew.Checked;
            Settings.Default.EnablePreprocessing = chkEnablePreprocessing.Checked;
            Settings.Default.DetectOrientation = cbDetectOrientation.Checked;
            Settings.Default.Context = cbContext.SelectedIndex;
            Settings.Default.Mode = cbMode.SelectedIndex;
            Settings.Default.CharacterSet = cbCharacterSet.SelectedIndex;
            Settings.Default.KeepLineBreaks = cbKeepLineBreaks.Checked;
            Settings.Default.OutputFormat = cbFormat.SelectedIndex;
            Settings.Default.CharBlackList = txtBlackList.Text;
            Settings.Default.Save();
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }

        /// <summary>
        /// Open and display a file selected by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _document.Close();
                UpdateControlsDocumentClosed();
                gdViewer1.ZoomMode = ViewerZoomMode.ZoomModeFitToViewer;
                Cursor.Current = Cursors.WaitCursor;
                bool bSuccess = _document.Load(openFileDialog.FileName, PdfRasterizationResolution);
                Cursor.Current = Cursors.Default;
                if (bSuccess)
                {
                    UpdateControlsDocumentLoaded();
                }
                else
                {
                    MessageBox.Show("Failed to load " + openFileDialog.FileName, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Close the current document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _document.Close();
            UpdateControlsDocumentClosed();
        }

        /// <summary>
        /// Close the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _document.Close();
            UpdateControlsDocumentClosed();
            Close();
        }

        /// <summary>
        /// Adjust the zoom level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gdViewer1.ZoomIN();
        }

        /// <summary>
        /// Adjust the zoom level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gdViewer1.ZoomOUT();
        }

        /// <summary>
        /// Adjust the zoom level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            gdViewer1.IgnoreDocumentResolution = false;
            gdViewer1.Zoom = 1;
        }

        /// <summary>
        /// Adjust the zoom level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ignoreResolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gdViewer1.IgnoreDocumentResolution = true;
            gdViewer1.Zoom = 1;
        }

        /// <summary>
        /// Rotate the document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rotateRight90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.Rotate(_document.ImageId,
                    RotateFlipType.Rotate90FlipNone);
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }
                gdViewer1.Redraw();
            }
        }

        /// <summary>
        /// Rotate the document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rotateLeft90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.Rotate(_document.ImageId,
                    RotateFlipType.Rotate270FlipNone);
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
            }
        }

        /// <summary>
        /// Rotate the document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                GdPictureStatus errorCode = _gdPictureImaging.Rotate(_document.ImageId,
                    RotateFlipType.Rotate180FlipNone);
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
            }
        }

        /// <summary>
        /// Corrects the skew angle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deskewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.AutoDeskew(_document.ImageId);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
            }
        }

        /// <summary>
        /// Change the folder with the resources.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseResourceFolder_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = tbResouceFolder.Text
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbResouceFolder.Text = folderBrowserDialog.SelectedPath;
                UpdateLanguages(tbResouceFolder.Text, SelectedLanguages());
            }
        }


        private void StartOCR(int roiLeft, int roiTop, int roiWidth, int roiHeight)
        {
            SetOcrParameters(roiLeft, roiTop, roiWidth, roiHeight);
            Cursor.Current = Cursors.WaitCursor;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            _document.OcrResultId = _gdPictureOcr.RunOCR(_ocrSpecialContext);
            stopWatch.Stop();
            if (_gdPictureOcr.GetStat() == GdPictureStatus.OK)
            {
                this.Text = InitialText + " - Elapsed: " + stopWatch.Elapsed.ToString() + ". Average confidence: " + _gdPictureOcr.GetAverageWordConfidence(_document.OcrResultId) + " %";

            }
            else
            {
                this.Text = InitialText;
            }
            Cursor.Current = Cursors.Default;

            UpdateControlsOcrResultCreated();
        }

        /// <summary>
        /// Runs the ocr.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();
                StartOCR(0, 0, 0, 0);
            }
        }

        /// <summary>
        /// Runs the ocr for the selected zone.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readzoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                if (gdViewer1.IsRect())
                {
                    _document.DiscardOcrResult();
                    UpdateControlsOcrResultDiscarded();

                    int left = 0;
                    int top = 0;
                    int width = 0;
                    int height = 0;
                    gdViewer1.GetRectCoordinatesOnDocument(ref left, ref top, ref width, ref height);

                    StartOCR(left, top, width, height);
                }
                else
                {
                    MessageBox.Show("Please draw a region of interest into the viewer in order to specify the zone to read.");
                }
            }
        }

        /// <summary>
        /// Refresh the displayed information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }

        /// <summary>
        /// Refresh the displayed information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paragraphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }

        /// <summary>
        /// Refresh the displayed information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }

        /// <summary>
        /// Refresh the displayed information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }

        /// <summary>
        /// Refresh the displayed information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBoxes();
        }

        /// <summary>
        /// Clear the selected languages.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            lbLanguages.ClearSelected();
        }

        /// <summary>
        /// Save the Ocr result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_document.HasOcr)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    switch (cbFormat.SelectedIndex)
                    {
                        case 0:
                        case 1:
                            saveFileDialog.Filter = "Text Files | *.txt";
                            break;

                        case 2:
                            saveFileDialog.Filter = "Html Files | *.html";
                            break;

                        // case 3:
                        default:
                            saveFileDialog.Filter = "Word Document | *.docx";
                            break;
                    }

                    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        GdPictureStatus status;

                        switch (cbFormat.SelectedIndex)
                        {
                            case 0:
                                status = _gdPictureOcr.SaveAsText(_document.OcrResultId, saveFileDialog.FileName,
                                    OCROutputTextFormat.Utf8, cbKeepLineBreaks.Checked);
                                break;
                            case 1:
                                status = _gdPictureOcr.SaveAsText(_document.OcrResultId, saveFileDialog.FileName,
                                    OCROutputTextFormat.Utf16, cbKeepLineBreaks.Checked);
                                break;

                            case 2:
                                status = _gdPictureOcr.SaveAsHTML(_document.OcrResultId, saveFileDialog.FileName,
                                    cbKeepLineBreaks.Checked);
                                break;

                            // case 3:
                            default:
                                status = _gdPictureOcr.SaveAsDOCX(_document.OcrResultId, saveFileDialog.FileName,
                                    cbKeepLineBreaks.Checked);
                                break;
                        }

                        Cursor.Current = Cursors.Default;
                        if (status != GdPictureStatus.OK)
                        {
                            DisplayError(status);
                        }
                        else
                        {
                            Process.Start(saveFileDialog.FileName);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Updates the languages proposed to the user
        /// </summary>
        private void UpdateLanguages(string resourceFolder, OCRLanguage[] selectedLanguages)
        {
            lbLanguages.Items.Clear();

            _gdPictureOcr.ResourceFolder = resourceFolder;
            IList<OCRLanguage> languages = _gdPictureOcr.GetAvailableLanguages();
            if (languages != null)
            {
                foreach (OCRLanguage language in languages)
                {
                    int index = lbLanguages.Items.Add(language);
                    if (selectedLanguages != null && selectedLanguages.Contains(language))
                    {
                        lbLanguages.SetSelected(index, true);
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves the selected languages.
        /// </summary>
        /// <returns></returns>
        private OCRLanguage[] SelectedLanguages()
        {
            if (lbLanguages.SelectedItems.Count == 0)
            {
                return null;
            }

            OCRLanguage[] languages = new OCRLanguage[lbLanguages.SelectedItems.Count];
            int index = 0;
            foreach (var selectedItem in lbLanguages.SelectedItems)
            {
                languages[index++] = (OCRLanguage)Enum.Parse(typeof(OCRLanguage), selectedItem.ToString());
            }
            return languages;
        }

        /// <summary>
        /// Displays the boxes.
        /// </summary>
        private void DisplayBoxes()
        {
            Rectangle[] blocks = blocksToolStripMenuItem.Checked ? _document.BlocksBoundingBoxes : null;
            Rectangle[] paragraphs = paragraphsToolStripMenuItem.Checked ? _document.ParagraphsBoundingBoxes : null;
            Rectangle[] textLines = textLinesToolStripMenuItem.Checked ? _document.TextLinesBoundingBoxes : null;
            Rectangle[] words = wordsToolStripMenuItem.Checked ? _document.WordsBoundingBoxes : null;
            Rectangle[] characters = charactersToolStripMenuItem.Checked ? _document.CharactersBoundingBoxes : null;

            Utilities.MarkRegions(gdViewer1, blocks, paragraphs, textLines, words, characters,
                _gdPictureImaging.GetHorizontalResolution(_document.ImageId),
                _gdPictureImaging.GetVerticalResolution(_document.ImageId));
        }

        /// <summary>
        /// Displays the error message corresponding to the provided code.
        /// </summary>
        /// <param name="errorCode"></param>
        private void DisplayError(GdPictureStatus errorCode)
        {
            MessageBox.Show("The operation failed with error code " + errorCode.ToString(), "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// GetCharacterSet retrieves the characters for the selected character set.
        /// </summary>
        /// <returns>The characters.</returns>
        private string GetCharacterSet()
        {
            switch (cbCharacterSet.SelectedIndex)
            {
                case 1:
                    return "0123456789.,";
                default:
                    return "";
            }
        }

        /// <summary>
        /// SetOcrParameters sends the character recognition parameters to the engine.
        /// </summary>
        private void SetOcrParameters(int roiLeft, int roiTop, int roiWidth, int roiHeight)
        {
            _gdPictureOcr.SetImage(_document.ImageId);

            if (cbContext.SelectedIndex <= 10)
            {
                _gdPictureOcr.Context = OcrContextMap[cbContext.SelectedIndex];

                _gdPictureOcr.ResetSelectedDictionaries();
                OCRLanguage[] selectedLanguages = SelectedLanguages();

                if (selectedLanguages != null)
                {
                    foreach (OCRLanguage language in selectedLanguages)
                    {
                        _gdPictureOcr.AddLanguage(language);
                    }
                }
                else
                {
                    //using english by default.
                    _gdPictureOcr.AddLanguage(OCRLanguage.English);
                }

                _gdPictureOcr.CharacterSet = GetCharacterSet();
                _gdPictureOcr.CharacterBlackList = txtBlackList.Text;
                _ocrSpecialContext = OCRSpecialContext.None;
            }
            else
            {
                //special context
                if (cbContext.SelectedIndex == 11)
                {
                    _ocrSpecialContext = OCRSpecialContext.OneOrTwoNumerics;
                }
                else if (cbContext.SelectedIndex == 12)
                {
                    _ocrSpecialContext = OCRSpecialContext.SingleLineNumerics;
                }
                else if (cbContext.SelectedIndex == 13)
                {
                    _ocrSpecialContext = OCRSpecialContext.MRZ;
                }
                else if (cbContext.SelectedIndex == 14)
                {
                    _ocrSpecialContext = OCRSpecialContext.MICRLineE13B;
                }
                else if (cbContext.SelectedIndex == 15)
                {
                    _ocrSpecialContext = OCRSpecialContext.MICRLineCMC7;
                }
                else if (cbContext.SelectedIndex == 16)
                {
                    _ocrSpecialContext = OCRSpecialContext.NumericLineML;
                }
                else if (cbContext.SelectedIndex == 17)
                {
                    _ocrSpecialContext = OCRSpecialContext.AlphaNumAllCapsML;
                }
                else if (cbContext.SelectedIndex == 18)
                {
                    _ocrSpecialContext = OCRSpecialContext.HandwrittenNumericBoxML;
                }
            }

            _gdPictureOcr.EnableVigorousDespeckle = chkEnableVigorousDespeckle.Checked;
            _gdPictureOcr.ResourceFolder = tbResouceFolder.Text;
            _gdPictureOcr.EnableOrientationDetection = cbDetectOrientation.Checked;
            _gdPictureOcr.EnableSkewDetection = cbDeskew.Checked;
            _gdPictureOcr.EnablePreprocessing = chkEnablePreprocessing.Checked;
            _gdPictureOcr.OCRMode = OcrModeMap[cbMode.SelectedIndex];

            _gdPictureOcr.SetROI(roiLeft, roiTop, roiWidth, roiHeight);
        }

        /// <summary>
        /// UpdateControlsOcrResultCreated updates the controls after the ocr result has been created.
        /// </summary>
        private void UpdateControlsOcrResultCreated()
        {
            if (!_document.HasOcr)
            {
                DisplayError(_gdPictureOcr.GetStat());
            }
            else
            {
                DisplayBoxes();
                rtbText.Text = _document.OCRResult;
                btnSave.Enabled = true;
            }
        }

        /// <summary>
        /// UpdateControlsOcrResultDiscarded updates the controls after the ocr result has been discarded.
        /// </summary>
        private void UpdateControlsOcrResultDiscarded()
        {
            rtbText.Text = "";
            gdViewer1.RemoveAllRegions();
            btnSave.Enabled = false;
        }

        /// <summary>
        /// UpdateControlsDocumentLoaded updates the controls after the document has been loaded.
        /// </summary>
        private void UpdateControlsDocumentLoaded()
        {
            gdViewer1.DisplayFromGdPictureImage(_document.ImageId);

            closeToolStripMenuItem.Enabled = true;
            viewToolStripMenuItem.Enabled = true;
            rotateToolStripMenuItem.Enabled = true;
            imageEnhancementToolStripMenuItem.Enabled = true;
            ocrToolStripMenuItem.Enabled = true;
            updateImageInfo();
        }

        /// <summary>
        /// UpdateControlsDocumentClosed updates the controls after the document has been closed.
        /// </summary>
        private void UpdateControlsDocumentClosed()
        {
            this.Text = InitialText;
            UpdateControlsOcrResultDiscarded();
            gdViewer1.CloseDocument();

            closeToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;
            rotateToolStripMenuItem.Enabled = false;
            imageEnhancementToolStripMenuItem.Enabled = false;
            ocrToolStripMenuItem.Enabled = false;
            updateImageInfo();
        }

        /// <summary>
        /// GdPictureImaging instance.
        /// </summary>
        private GdPictureImaging _gdPictureImaging;

        /// <summary>
        /// GdPictureOcr instance.
        /// </summary>
        private GdPictureOCR _gdPictureOcr;

        private OCRSpecialContext _ocrSpecialContext = OCRSpecialContext.None;

        /// <summary>
        /// The current document.
        /// </summary>
        private Document _document;

        /// <summary>
        /// The rasterization when loading the image from a pdf.
        /// </summary>
        private const int PdfRasterizationResolution = 300;

        private readonly string InitialText;

        /// <summary>
        /// The map to obtain the context based on the selected item within the combo box.
        /// </summary>
        private static readonly OCRContext[] OcrContextMap =
        {
            OCRContext.OCRContextDocument,
            OCRContext.OCRContextSingleColumn,
            OCRContext.OCRContextSingleBlock,
            OCRContext.OCRContextSingleBlockVertical,
            OCRContext.OCRContextSingleLine,
            OCRContext.OCRContextSingleWord,
            OCRContext.OCRContextSingleWordCircle,
            OCRContext.OCRContextSingleChar,
            OCRContext.OCRContextSparseText,
            OCRContext.OCRContextRawLine,
            OCRContext.OCRContextSegmentationOnly
        };

        /// <summary>
        /// The map to obtain the mode based on the selected item within the combo box.
        /// </summary>
        private static readonly OCRMode[] OcrModeMap =
        {
            OCRMode.FavorAccuracy,
            OCRMode.FavorSpeed
        };

        private void bitonalDespeckleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                if (_gdPictureImaging.GetBitDepth(_document.ImageId) != 1)
                {
                    MessageBox.Show("This operation can be performed  on 1bpp image only.");
                    return;
                }

                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = GdPictureStatus.OK;
                errorCode = _gdPictureImaging.FxBitonalDespeckleAdvanced(_document.ImageId, DespeckleType.FourConnected, 5);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
            }
        }


        private void scaleTo300DPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.Scale(_document.ImageId, (300F / _gdPictureImaging.GetVerticalResolution(_document.ImageId)) * 100, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
                updateImageInfo();
            }
        }

        private void scaleTo200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.Scale(_document.ImageId, 200, System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
                updateImageInfo();
            }
        }


        private void automaticRotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();
                SetOcrParameters(0, 0, _gdPictureImaging.GetWidth(_document.ImageId), _gdPictureImaging.GetHeight(_document.ImageId));
                Cursor.Current = Cursors.WaitCursor;
                _gdPictureOcr.SetImage(_document.ImageId);
                int orientationAngle = _gdPictureOcr.GetOrientation();
                GdPictureStatus errorCode = _gdPictureOcr.GetStat();
                if (errorCode == GdPictureStatus.OK && orientationAngle != 0)
                {
                    int correctOrientationAngle = 360 - orientationAngle;
                    errorCode = _gdPictureImaging.RotateAngle(_document.ImageId, (float)correctOrientationAngle);
                }

                Cursor.Current = Cursors.Default;

                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
            }
        }

        private void eraseBlackBordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.DeleteBlackBorders(_document.ImageId, 0, false);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
            }
        }

        private void removePunchHolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.RemoveHolePunch(_document.ImageId);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
            }
        }

        private void automaticCleanupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.RemoveHolePunch(_document.ImageId);

                if (errorCode == GdPictureStatus.OK)
                {
                    errorCode = _gdPictureImaging.DeleteBlackBorders(_document.ImageId, 0, false);
                    if (errorCode == GdPictureStatus.OK)
                    {
                        errorCode = _gdPictureImaging.AutoDeskew(_document.ImageId);

                        //todo: implement a correct generic despeckle.
                    }
                }

                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
                updateImageInfo();
            }
        }

        private void sauvolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.ConvertTo1BppSauvola(_document.ImageId, 0.35F);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
                updateImageInfo();
            }
        }

        private void otsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.ConvertTo1BppAT(_document.ImageId, 50);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
                updateImageInfo();
            }
        }

        private void bradleyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.ConvertTo1BppBradley(_document.ImageId, 38);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
                updateImageInfo();
            }
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_document.IsOpen)
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();

                Cursor.Current = Cursors.WaitCursor;
                GdPictureStatus errorCode = _gdPictureImaging.FxDespeckle(_document.ImageId);
                Cursor.Current = Cursors.Default;
                if (errorCode != GdPictureStatus.OK)
                {
                    DisplayError(errorCode);
                }

                gdViewer1.Redraw();
            }
        }


        private void updateImageInfo()
        {
            if (_document.IsOpen)
            {
                tsImageInfo.Text = "Image properties :: width: " + _gdPictureImaging.GetWidth(_document.ImageId).ToString() + "." +
                                   " height: " + _gdPictureImaging.GetHeight(_document.ImageId).ToString() + "." +
                                   " horizontal resolution: " + _gdPictureImaging.GetHorizontalResolution(_document.ImageId).ToString() + " dpi." +
                                   " vertical resolution: " + _gdPictureImaging.GetVerticalResolution(_document.ImageId).ToString() + " dpi." +
                                   " bit depth: " + _gdPictureImaging.GetBitDepth(_document.ImageId) + " bpp.";
            }
            else
            {
                tsImageInfo.Text = "";
            }
        }

        private void keyValuePairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_document.IsOpen)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(_document.OcrResultId))
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();
                StartOCR(0, 0, 0, 0);
            }

            if (string.IsNullOrWhiteSpace(_document.OcrResultId))
            {
                return;
            }

            string result = _gdPictureOcr.GetKeyValuePairsData(_document.OcrResultId).Replace("\r", "");
            rtbText.Text = result;

            gdViewer1.RemoveAllRegions();

            float horizontalResolution = _gdPictureImaging.GetHorizontalResolution(_document.ImageId);
            float verticalResolution = _gdPictureImaging.GetVerticalResolution(_document.ImageId);

            for (int i = 0; i < _gdPictureOcr.GetKeyValuePairCount(_document.OcrResultId); i++)
            {
                _gdPictureOcr.GetKeyValuePairKeyRect(_document.OcrResultId, i, out int kl, out int kt, out int kw, out int kh);
                _gdPictureOcr.GetKeyValuePairValueRect(_document.OcrResultId, i, out int vl, out int vt, out int vw, out int vh);

                if (kw != 0)
                {
                    int regionId = gdViewer1.AddRegionInches("", kl / horizontalResolution,
                      kt / verticalResolution, kw / horizontalResolution,
                      kh / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED,
                      Color.Red);
                    gdViewer1.SetRegionEditable(regionId, false);
                    gdViewer1.SetRegionBorderWidth(regionId, 2);
                    gdViewer1.SetRegionBorderColor(regionId, Color.Red);
                }

                if (vw != 0)
                {
                    int regionId = gdViewer1.AddRegionInches("", vl / horizontalResolution,
                      vt / verticalResolution, vw / horizontalResolution,
                      vh / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED,
                      Color.Blue);
                    gdViewer1.SetRegionEditable(regionId, false);
                    gdViewer1.SetRegionBorderWidth(regionId, 2);
                    gdViewer1.SetRegionBorderColor(regionId, Color.Blue);
                }

                if (kw != 0 && vw != 0)
                {
                    GdPictureRectangleF union = GdPictureRectangleF.RectUnion(kl, kt, kl + kw, kt + kh, vl, vt, vl + vw, vt + vh);

                    union = union.AddMargins(7);

                    int regionId = gdViewer1.AddRegionInches("", union.Left / horizontalResolution,
                    union.Top / verticalResolution, union.Width / horizontalResolution,
                    union.Height / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED,
                    Color.Green);
                    gdViewer1.SetRegionEditable(regionId, false);
                    gdViewer1.SetRegionBorderWidth(regionId, 3);
                    gdViewer1.SetRegionBorderColor(regionId, Color.Green);
                }

            }
        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_document.IsOpen)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(_document.OcrResultId))
            {
                _document.DiscardOcrResult();
                UpdateControlsOcrResultDiscarded();
                StartOCR(0, 0, 0, 0);
            }

            if (string.IsNullOrWhiteSpace(_document.OcrResultId))
            {
                return;
            }

            gdViewer1.RemoveAllRegions();

            float horizontalResolution = _gdPictureImaging.GetHorizontalResolution(_document.ImageId);
            float verticalResolution = _gdPictureImaging.GetVerticalResolution(_document.ImageId);

            for (int i = 0; i < _gdPictureOcr.GetTableCount(_document.OcrResultId); i++)
            {
                {
                    int colCount = _gdPictureOcr.GetTableColumnCount(_document.OcrResultId, i);

                    if (colCount != 0)
                    {
                        for (int colIdx = 0; colIdx < colCount; colIdx++)
                        {
#if DRAW_TABLE_CELLS
                            int rowCount = _gdPictureOcr.GetTableRowCount(_document.OcrResultId, i);

                            if (rowCount != 0)
                            {
                                for (int rowIdx = 0; rowIdx < rowCount; rowIdx++)
                                {
                                    //drawing cells

                                    _gdPictureOcr.GetTableCellRect(_document.OcrResultId, i, colIdx, rowIdx, out int celll, out int cellt, out int cellw, out int cellh);

                                    int cellRegionId = gdViewer1.AddRegionInches("", celll / horizontalResolution,
                                cellt / verticalResolution, cellw / horizontalResolution,
                                cellh / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED,
                                Color.Red);
                                    gdViewer1.SetRegionEditable(cellRegionId, false);
                                    gdViewer1.SetRegionBorderWidth(cellRegionId, 2);
                                    gdViewer1.SetRegionBorderColor(cellRegionId, Color.DarkSalmon);
                                }
                            }
#else


                            _gdPictureOcr.GetTableColumnRect(_document.OcrResultId, i, colIdx, out int cl, out int ct, out int cw, out int ch);

                            int regionId = gdViewer1.AddRegionInches("", cl / horizontalResolution,
                        ct / verticalResolution, cw / horizontalResolution,
                        ch / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED,
                        Color.Red);
                            gdViewer1.SetRegionEditable(regionId, false);
                            gdViewer1.SetRegionBorderWidth(regionId, 2);
                            gdViewer1.SetRegionBorderColor(regionId, Color.Green);
#endif
                        }
                    }
                }

                {
#if !DRAW_TABLE_CELLS
                    int rowCount = _gdPictureOcr.GetTableRowCount(_document.OcrResultId, i);

                    if (rowCount != 0)
                    {
                        for (int rowIdx = 0; rowIdx < rowCount; rowIdx++)
                        {
                            _gdPictureOcr.GetTableRowRect(_document.OcrResultId, i, rowIdx, out int rl, out int rt, out int rw, out int rh);

                            int regionId = gdViewer1.AddRegionInches("", rl / horizontalResolution,
                        rt / verticalResolution, rw / horizontalResolution,
                        rh / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED,
                        Color.Red);
                            gdViewer1.SetRegionEditable(regionId, false);
                            gdViewer1.SetRegionBorderWidth(regionId, 2);
                            gdViewer1.SetRegionBorderColor(regionId, Color.Green);
                        }
                    }
#endif
                }

#if !DRAW_TABLE_CELLS

                _gdPictureOcr.GetTableRect(_document.OcrResultId, i, out int tl, out int tt, out int tw, out int th);
                {

                    int regionId = gdViewer1.AddRegionInches("", tl / horizontalResolution,
                      tt / verticalResolution, tw / horizontalResolution,
                      th / verticalResolution, ForegroundMixMode.ForegroundMixModeUNDEFINED,
                      Color.Red);
                    gdViewer1.SetRegionEditable(regionId, false);
                    gdViewer1.SetRegionBorderWidth(regionId, 2);
                    gdViewer1.SetRegionBorderColor(regionId, Color.Red);
                }
#endif

            }
        }
    }
}
