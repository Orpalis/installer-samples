using GdPicture14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PagesManipulation
{
    public partial class frmSettings
    {

        private readonly GdViewer _owner;

        private readonly Dictionary<ViewerMouseWheelMode, string> _mouseWheelModes = new Dictionary<ViewerMouseWheelMode, string>
        {
            {ViewerMouseWheelMode.MouseWheelModeZoom, "Zoom"},
            {ViewerMouseWheelMode.MouseWheelModeVerticalScroll, "Scroll"},
            {ViewerMouseWheelMode.MouseWheelModePageChange, "Page change"}
        };
        private readonly Dictionary<ViewerDocumentAlignment, string> _documentAlignments = new Dictionary<ViewerDocumentAlignment, string>
        {
            {ViewerDocumentAlignment.DocumentAlignmentBottomCenter, "Bottom center"},
            {ViewerDocumentAlignment.DocumentAlignmentBottomLeft, "Bottom left"},
            {ViewerDocumentAlignment.DocumentAlignmentBottomRight, "Bottom right"},
            {ViewerDocumentAlignment.DocumentAlignmentMiddleCenter, "Middle center"},
            {ViewerDocumentAlignment.DocumentAlignmentMiddleLeft, "Middle left"},
            {ViewerDocumentAlignment.DocumentAlignmentMiddleRight, "Middle right"},
            {ViewerDocumentAlignment.DocumentAlignmentTopCenter, "Top center"},
            {ViewerDocumentAlignment.DocumentAlignmentTopLeft, "Top left"},
            {ViewerDocumentAlignment.DocumentAlignmentTopRight, "Top right"}
        };
        private readonly Dictionary<ViewerDocumentPosition, string> _documentPositions = new Dictionary<ViewerDocumentPosition, string>
        {
            {ViewerDocumentPosition.DocumentPositionBottomCenter, "Bottom center"},
            {ViewerDocumentPosition.DocumentPositionBottomLeft, "Bottom left"},
            {ViewerDocumentPosition.DocumentPositionBottomRight, "Bottom right"},
            {ViewerDocumentPosition.DocumentPositionMiddleCenter, "Middle center"},
            {ViewerDocumentPosition.DocumentPositionMiddleLeft, "Middle left"},
            {ViewerDocumentPosition.DocumentPositionMiddleRight, "Middle right"},
            {ViewerDocumentPosition.DocumentPositionTopCenter, "Top center"},
            {ViewerDocumentPosition.DocumentPositionTopLeft, "Top left"},
            {ViewerDocumentPosition.DocumentPositionTopRight, "Top right"}
        };
        private readonly Dictionary<DisplayQuality, string> _displayQualities = new Dictionary<DisplayQuality, string>
        {
            {DisplayQuality.DisplayQualityLow, "Low"},
            {DisplayQuality.DisplayQualityBilinear, "Bilinear"},
            {DisplayQuality.DisplayQualityBicubic, "Bicubic"},
            {DisplayQuality.DisplayQualityBilinearHQ, "Bilinear HQ"},
            {DisplayQuality.DisplayQualityBicubicHQ, "Bicubic HQ"},
            {DisplayQuality.DisplayQualityAutomatic, "Automatic"}
        };

        private readonly Dictionary<PageDisplayMode, string> _pageDisplayModes = new Dictionary<PageDisplayMode, string>
        {
            {PageDisplayMode.MultiplePagesView, "Multiple pages" },
            {PageDisplayMode.SinglePageView, "Single page" }
        };

        public frmSettings(GdViewer owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            foreach (var item in _mouseWheelModes)
            {
                cbMouseWheelMode.Items.Add(item.Value);
            }
            foreach (var item in _documentAlignments)
            {
                cbDocumentAlignment.Items.Add(item.Value);
            }
            foreach (var item in _documentPositions)
            {
                cbDocumentPosition.Items.Add(item.Value);
            }
            foreach (var item in _displayQualities)
            {
                cbDisplayQuality.Items.Add(item.Value);
            }

            foreach (var item in _pageDisplayModes)
            {
                cbPageDisplayMode.Items.Add(item.Value);
            }

            cbMouseWheelMode.SelectedIndex = Convert.ToInt32(_owner.MouseWheelMode);
            cbDocumentAlignment.SelectedItem = _documentAlignments[_owner.DocumentAlignment];
            cbDocumentPosition.SelectedItem = _documentPositions[_owner.DocumentPosition];
            cbDisplayQuality.SelectedItem = _displayQualities[_owner.DisplayQuality];
            cbPageDisplayMode.SelectedItem = _pageDisplayModes[_owner.PageDisplayMode];
            txtZoomStep.Text = (_owner.ZoomStep).ToString();
            chkContinuousViewMode.Checked = _owner.ContinuousViewMode;
            chkEnableMenu.Checked = _owner.EnableMenu;
            PictureBox1.BackColor = _owner.BackColor;
            chkIgnoreDocumentResolution.Checked = _owner.IgnoreDocumentResolution;
            chkEnableDeferredPainting.Checked = _owner.EnableDeferredPainting;

            chkAnnotationsDropShadow.Checked = _owner.AnnotationDropShadow;
            chkHQAnnotationsRendering.Checked = _owner.HQAnnotationRendering;

            chkEnableICM.Checked = _owner.EnableICM;

            chkPDFDisplayFormFields.Checked = _owner.PdfDisplayFormField;
            chkPDFEnableFileLinks.Checked = _owner.PdfEnableFileLinks;
            chkPDFEnableLinks.Checked = _owner.PdfEnableLinks;
            chkPDFIncreaseTextContrast.Checked = _owner.PdfIncreaseTextContrast;
            chkPDFVerifyDigitalCertificates.Checked = _owner.PdfVerifyDigitalCertificates;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    PictureBox1.BackColor = colorDialog.Color;
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            _owner.MouseWheelMode = _mouseWheelModes.FirstOrDefault(x => x.Value.Contains(cbMouseWheelMode.SelectedItem.ToString())).Key;
            _owner.DocumentAlignment = _documentAlignments.FirstOrDefault(x => x.Value.Contains(cbDocumentAlignment.SelectedItem.ToString())).Key;
            _owner.DocumentPosition = _documentPositions.FirstOrDefault(x => x.Value.Contains(cbDocumentPosition.SelectedItem.ToString())).Key;
            _owner.DisplayQuality = _displayQualities.FirstOrDefault(x => x.Value.Contains(cbDisplayQuality.SelectedItem.ToString())).Key;
            _owner.PageDisplayMode = _pageDisplayModes.FirstOrDefault(x => x.Value.Contains(cbPageDisplayMode.SelectedItem.ToString())).Key;
            _owner.ZoomStep = int.Parse(txtZoomStep.Text);
            _owner.ContinuousViewMode = chkContinuousViewMode.Checked;
            _owner.EnableMenu = chkEnableMenu.Checked;
            _owner.BackColor = PictureBox1.BackColor;
            _owner.IgnoreDocumentResolution = chkIgnoreDocumentResolution.Checked;
            _owner.EnableDeferredPainting = chkEnableDeferredPainting.Checked;

            _owner.AnnotationDropShadow = chkAnnotationsDropShadow.Checked;
            _owner.HQAnnotationRendering = chkHQAnnotationsRendering.Checked;

            _owner.EnableICM = chkEnableICM.Checked;

            _owner.PdfDisplayFormField = chkPDFDisplayFormFields.Checked;
            _owner.PdfEnableFileLinks = chkPDFEnableFileLinks.Checked;
            _owner.PdfEnableLinks = chkPDFEnableLinks.Checked;
            _owner.PdfIncreaseTextContrast = chkPDFIncreaseTextContrast.Checked;
            _owner.PdfVerifyDigitalCertificates = chkPDFVerifyDigitalCertificates.Checked;

            Close();
        }
    }
}
