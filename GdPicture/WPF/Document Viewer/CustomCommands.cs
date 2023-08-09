using System.Windows.Input;

namespace DocumentViewer
{
    class CustomCommands
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

        public static readonly RoutedUICommand Settings = new RoutedUICommand
          (
                  "Settings",
                  "Settings",
                  typeof(CustomCommands),
                  null
          );

        public static readonly RoutedUICommand Print = new RoutedUICommand
           (
                   "Print",
                   "Print",
                   typeof(CustomCommands),
                   new InputGestureCollection()
                                {
                                        new KeyGesture(Key.P, ModifierKeys.Control)
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

        #region "MouseMode Custom Commands"
        public static readonly RoutedUICommand MouseModePan = new RoutedUICommand
                     (
                             "MouseModePan",
                             "MouseModePan",
                             typeof(CustomCommands),
                             null
                     );

        public static readonly RoutedUICommand MouseModeAreaZooming = new RoutedUICommand
                      (
                              "MouseModeAreaZooming",
                              "MouseModeAreaZooming",
                              typeof(CustomCommands),
                              null
                      );

        public static readonly RoutedUICommand MouseModeAreaSelection = new RoutedUICommand
                      (
                              "MouseModeAreaSelection",
                              "MouseModeAreaSelection",
                              typeof(CustomCommands),
                              null
                      );

        public static readonly RoutedUICommand MouseModeMagnifier = new RoutedUICommand
                      (
                              "MouseModeMagnifier",
                              "MouseModeMagnifier",
                              typeof(CustomCommands),
                              null
                      );

        public static readonly RoutedUICommand MouseModeDefault = new RoutedUICommand
                      (
                              "MouseModeDefault",
                              "MouseModeDefault",
                              typeof(CustomCommands),
                              null
                      );
        #endregion

        #region "Page Navigation Custom Commands"
        public static readonly RoutedUICommand FirstPage = new RoutedUICommand
                (
                        "FirstPage",
                        "FirstPage",
                        typeof(CustomCommands),
                        null
                );

        public static readonly RoutedUICommand LastPage = new RoutedUICommand
                (
                        "LastPage",
                        "LastPage",
                        typeof(CustomCommands),
                        null
                );


        public static readonly RoutedUICommand PreviousPage = new RoutedUICommand
                (
                        "PreviousPage",
                        "PreviousPage",
                        typeof(CustomCommands),
                        null
                );


        public static readonly RoutedUICommand NextPage = new RoutedUICommand
                (
                        "NextPage",
                        "NextPage",
                        typeof(CustomCommands),
                        null
                );
        #endregion

        #region "Thumbnail Size Custom Commands"
        public static readonly RoutedUICommand SmallThumb = new RoutedUICommand
            (
                    "SmallThumb",
                    "SmallThumb",
                    typeof(CustomCommands),
                    null
            );

        public static readonly RoutedUICommand MediumThumb = new RoutedUICommand
             (
                     "MediumThumb",
                     "MediumThumb",
                     typeof(CustomCommands),
                     null
             );

        public static readonly RoutedUICommand LargeThumb = new RoutedUICommand
             (
                     "LargeThumb",
                     "LargeThumb",
                     typeof(CustomCommands),
                     null
             );
        #endregion

        #region"Search"
        public static readonly RoutedUICommand Search = new RoutedUICommand
            (
                    "Search",
                    "Search",
                    typeof(CustomCommands),
                    null
            );
        public static readonly RoutedUICommand SearchNext = new RoutedUICommand
            (
                    "SearchNext",
                    "SearchNext",
                    typeof(CustomCommands),
                    null
            );
        public static readonly RoutedUICommand SearchPrevious = new RoutedUICommand
            (
                    "SearchPrevious",
                    "SearchPrevious",
                    typeof(CustomCommands),
                    null
            );
        #endregion

        #region"Snapin"
        public static readonly RoutedUICommand ThumbnailsPanel = new RoutedUICommand
            (
                    "ThumbnailsPanel",
                    "ThumbnailsPanel",
                    typeof(CustomCommands),
                    null
            );
        public static readonly RoutedUICommand BookmarksPanel = new RoutedUICommand
            (
                    "BookmarksPanel",
                    "BookmarksPanel",
                    typeof(CustomCommands),
                    null
            );
        public static readonly RoutedUICommand SearchPanel = new RoutedUICommand
            (
                    "SearchPanel",
                    "SearchPanel",
                    typeof(CustomCommands),
                    null
            );
        #endregion


        #region "Zoom Custom Commands"
        public static readonly RoutedUICommand ZoomIN = new RoutedUICommand
                  (
                          "ZoomIN",
                          "ZoomIN",
                          typeof(CustomCommands),
                          null
                  );

        public static readonly RoutedUICommand ZoomOUT = new RoutedUICommand
                  (
                          "ZoomOUT",
                          "ZoomOUT",
                          typeof(CustomCommands),
                          null
                  );

        public static readonly RoutedUICommand ZoomBestFit = new RoutedUICommand
                    (
                            "ZoomBestFit",
                            "ZoomBestFit",
                            typeof(CustomCommands),
                            null
                    );

        public static readonly RoutedUICommand ZoomWidthFit = new RoutedUICommand
                    (
                            "ZoomWidthFit",
                            "ZoomWidthFit",
                            typeof(CustomCommands),
                            null
                    );

        public static readonly RoutedUICommand RotateRight = new RoutedUICommand
              (
                      "RotateRight",
                      "RotateRight",
                      typeof(CustomCommands),
                      null
              );


        public static readonly RoutedUICommand RotateLeft = new RoutedUICommand
               (
                       "RotateLeft",
                       "RotateLeft",
                       typeof(CustomCommands),
                       null
               );

        public static readonly RoutedUICommand FlipX = new RoutedUICommand
               (
                       "FlipX",
                       "FlipX",
                       typeof(CustomCommands),
                       null
               );

        public static readonly RoutedUICommand FlipY = new RoutedUICommand
               (
                       "FlipY",
                       "FlipY",
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
        #endregion
    }
}
