using System.Windows.Input;

namespace DicomViewer
{
    public static class CustomCommands
    {
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

        public static readonly RoutedUICommand OpenDir = new RoutedUICommand
              (
                      "OpenDir",
                      "OpenDir",
                      typeof(CustomCommands),
                      new InputGestureCollection()
                                {
                                        new KeyGesture(Key.O, ModifierKeys.Alt)
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


        public static readonly RoutedUICommand Help = new RoutedUICommand
           (
                   "Help",
                   "Help",
                   typeof(CustomCommands),
                   null
           );

        public static readonly RoutedUICommand About = new RoutedUICommand
           (
                   "About",
                   "About",
                   typeof(CustomCommands),
                   null
           );

        public static readonly RoutedUICommand Animate = new RoutedUICommand
          (
                  "Animate",
                  "Animate",
                  typeof(CustomCommands),
                  new InputGestureCollection()
                                {
                                        new KeyGesture(Key.A, ModifierKeys.Alt)
                                }
          );

        public static readonly RoutedUICommand Capture = new RoutedUICommand
          (
                  "Capture",
                  "Capture",
                  typeof(CustomCommands),
                  new InputGestureCollection()
                                {
                                        new KeyGesture(Key.C, ModifierKeys.Control)
                                }
          );

        public static readonly RoutedUICommand AdjustWindow = new RoutedUICommand
        (
                "AdjustWindow",
                "AdjustWindow",
                typeof(CustomCommands),
                new InputGestureCollection()
                                {
                                        new KeyGesture(Key.W, ModifierKeys.Control)
                                }
        );

        public static readonly RoutedUICommand DefaultWindow = new RoutedUICommand
       (
               "DefaultWindow",
               "DefaultWindow",
               typeof(CustomCommands),
               new InputGestureCollection()
                                {
                                        new KeyGesture(Key.D, ModifierKeys.Control)
                                }
       );

        public static readonly RoutedUICommand ViewTags = new RoutedUICommand
      (
              "ViewTags",
              "ViewTags",
              typeof(CustomCommands),
              new InputGestureCollection()
                                {
                                        new KeyGesture(Key.T, ModifierKeys.Control)
                                }
      );
    }
}
