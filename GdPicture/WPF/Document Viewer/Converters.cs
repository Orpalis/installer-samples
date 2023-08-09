using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Data;
using System.Globalization;
using GdPicture14;

namespace DocumentViewer
{
    public class MouseWheelToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            int intValue = System.Convert.ToInt32(value);
            return intValue;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return ViewerMouseWheelMode.MouseWheelModeZoom;
        }
    }

    public class BitmapScalingModeToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            int intValue = System.Convert.ToInt32(value);
            return intValue;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return BitmapScalingMode.Fant;
        }
    }

    public class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            string stringValue = value.ToString();
            return stringValue;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return "";
        }
    }

    
    public class DocumentAlignmentToStringConverter : IValueConverter
    {
        private readonly Dictionary<ViewerDocumentAlignment, string> _documentAlignments = new Dictionary<ViewerDocumentAlignment, string> {
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

        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            string stringValue = _documentAlignments[(ViewerDocumentAlignment)value];
            return stringValue;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return ViewerDocumentAlignment.DocumentAlignmentTopCenter;
        }
    }

    public class DocumentPositionToStringConverter : IValueConverter
    {
        private readonly Dictionary<ViewerDocumentPosition, string> _documentPositions = new Dictionary<ViewerDocumentPosition, string> {
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

        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            string stringValue = _documentPositions[(ViewerDocumentPosition)value];
            return stringValue;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return ViewerDocumentPosition.DocumentPositionMiddleCenter;
        }
    }

     
}
