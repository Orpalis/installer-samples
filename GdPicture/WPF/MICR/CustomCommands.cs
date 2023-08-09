using System.Windows.Input;

namespace Csharp_MICR.WPF
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
       
        public static readonly RoutedUICommand Reset = new RoutedUICommand
          (
                  "Reset",
                  "Reset",
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

        public static readonly RoutedUICommand Rotate90 = new RoutedUICommand
          (
                  "Rotate90",
                  "Rotate90",
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
