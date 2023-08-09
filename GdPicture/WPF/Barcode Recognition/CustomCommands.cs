using System.Windows.Input;

namespace Csharp_Barcode_Recognition.WPF
{
    public static class CustomCommands
    {

        #region "File Menu Custom Commands"

        public static readonly RoutedUICommand OpenFile = new RoutedUICommand
                (
                        "OpenFile",
                        "OpenFile",
                        typeof(CustomCommands),
                        new InputGestureCollection()
                                {
                                        new KeyGesture(Key.O, ModifierKeys.Control)
                                }
                );


        public static readonly RoutedUICommand Exit = new RoutedUICommand
            (
                    "Exit",
                    "Exit",
                    typeof(CustomCommands),
                    new InputGestureCollection()
                                {
                                        new KeyGesture(Key.F4, ModifierKeys.Alt)
                                }
            );

        public static readonly RoutedUICommand Close = new RoutedUICommand
          (
                  "Close",
                  "Close",
                  typeof(CustomCommands),
                 null
          );

        #endregion

        #region "Image Processing Custom Commands"
        public static readonly RoutedUICommand Despeckle = new RoutedUICommand
          (
                  "Despeckle",
                  "Despeckle",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand Median = new RoutedUICommand
          (
                  "Median",
                  "Median",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand Smooth = new RoutedUICommand
          (
                  "Smooth",
                  "Smooth",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand AutoDeskew = new RoutedUICommand
          (
                  "AutoDeskew",
                  "AutoDeskew",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand Dilate = new RoutedUICommand
          (
                  "Dilate",
                  "Dilate",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand Erode = new RoutedUICommand
          (
                  "Erode",
                  "Erode",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand RemoveDots = new RoutedUICommand
          (
                  "RemoveDots",
                  "RemoveDots",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand FillHolesMenu = new RoutedUICommand
          (
                  "FillHolesMenu",
                  "FillHolesMenu",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand FillHHoles = new RoutedUICommand
          (
                  "FillHHoles",
                  "FillHHoles",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand FillVHoles = new RoutedUICommand
          (
                  "FillVHoles",
                  "FillVHoles",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand RemoveVLines = new RoutedUICommand
          (
                  "RemoveVLines",
                  "RemoveVLines",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand RemoveHLines = new RoutedUICommand
          (
                  "RemoveHLines",
                  "RemoveHLines",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand Threshold = new RoutedUICommand
          (
                  "Threshold",
                  "Threshold",
                  typeof(CustomCommands),
                 null
          );

        public static readonly RoutedUICommand Rotate = new RoutedUICommand
          (
                  "Rotate",
                  "Rotate",
                  typeof(CustomCommands),
                 null
          );

        #endregion

        #region "Scale Custom Commands"
        public static readonly RoutedUICommand ScaleMenu = new RoutedUICommand
                 (
                         "Scale50",
                         "Scale50",
                         typeof(CustomCommands),
                         null
                 );

        public static readonly RoutedUICommand Scale50 = new RoutedUICommand
                 (
                         "Scale50",
                         "Scale50",
                         typeof(CustomCommands),
                         null
                 );

        public static readonly RoutedUICommand Scale75 = new RoutedUICommand
                (
                        "Scale75",
                        "Scale75",
                        typeof(CustomCommands),
                        null
                );

        public static readonly RoutedUICommand Scale150 = new RoutedUICommand
                (
                        "Scale150",
                        "Scale150",
                        typeof(CustomCommands),
                        null
                );

        public static readonly RoutedUICommand Scale200 = new RoutedUICommand
                (
                        "Scale200",
                        "Scale200",
                        typeof(CustomCommands),
                        null
                );

        public static readonly RoutedUICommand Scale300 = new RoutedUICommand
                 (
                         "Scale300",
                         "Scale300",
                         typeof(CustomCommands),
                         null
                 );

        #endregion

        public static readonly RoutedUICommand Start = new RoutedUICommand
          (
                  "Start",
                  "Start",
                  typeof(CustomCommands),
                 null
          );

    }
}
