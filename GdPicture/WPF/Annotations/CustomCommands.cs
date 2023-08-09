using System.Windows.Input;

namespace Csharp_Annotations.WPF
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

        public static readonly RoutedUICommand Save = new RoutedUICommand
          (
                  "Save",
                  "Save",
                  typeof(CustomCommands),
                  new InputGestureCollection()
                                {
                                        new KeyGesture(Key.S, ModifierKeys.Control)
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

        #region "Document Position Custom Commands"
        public static readonly RoutedUICommand PositionML = new RoutedUICommand
                (
                        "PositionML",
                        "PositionML",
                        typeof(CustomCommands),
                        null
                );


        public static readonly RoutedUICommand PositionMC = new RoutedUICommand
                (
                        "PositionMC",
                        "PositionMC",
                        typeof(CustomCommands),
                        null
                );

        public static readonly RoutedUICommand PositionMR = new RoutedUICommand
                (
                        "PositionMR",
                        "PositionMR",
                        typeof(CustomCommands),
                        null
                );
        
        public static readonly RoutedUICommand PositionTL = new RoutedUICommand
                (
                        "PositionTL",
                        "PositionTL",
                        typeof(CustomCommands),
                        null
                );

        public static readonly RoutedUICommand PositionTC = new RoutedUICommand
                (
                        "PositionTC",
                        "PositionTC",
                        typeof(CustomCommands),
                        null
                );

        public static readonly RoutedUICommand PositionTR = new RoutedUICommand
                (
                        "PositionTR",
                        "PositionTR",
                        typeof(CustomCommands),
                        null
                );

        public static readonly RoutedUICommand PositionBL = new RoutedUICommand
                (
                        "PositionBL",
                        "PositionBL",
                        typeof(CustomCommands),
                        null
                );

         public static readonly RoutedUICommand PositionBR = new RoutedUICommand
                (
                        "PositionBR",
                        "PositionBR",
                        typeof(CustomCommands),
                        null
                );

         public static readonly RoutedUICommand PositionBC= new RoutedUICommand
                (
                        "PositionBC",
                        "PositionBC",
                        typeof(CustomCommands),
                        null
                );
        #endregion

        #region "Document Alignment Custom Commands"
         public static readonly RoutedUICommand AlignmentML = new RoutedUICommand
                 (
                         "AlignmentML",
                         "AlignmentML",
                         typeof(CustomCommands),
                         null
                 );


         public static readonly RoutedUICommand AlignmentMC = new RoutedUICommand
                 (
                         "AlignmentMC",
                         "AlignmentMC",
                         typeof(CustomCommands),
                         null
                 );

         public static readonly RoutedUICommand AlignmentMR = new RoutedUICommand
                 (
                         "AlignmentMR",
                         "AlignmentMR",
                         typeof(CustomCommands),
                         null
                 );

         public static readonly RoutedUICommand AlignmentTL = new RoutedUICommand
                 (
                         "AlignmentTL",
                         "AlignmentTL",
                         typeof(CustomCommands),
                         null
                 );

         public static readonly RoutedUICommand AlignmentTC = new RoutedUICommand
                 (
                         "AlignmentTC",
                         "AlignmentTC",
                         typeof(CustomCommands),
                         null
                 );

         public static readonly RoutedUICommand AlignmentTR = new RoutedUICommand
                 (
                         "AlignmentTR",
                         "AlignmentTR",
                         typeof(CustomCommands),
                         null
                 );

         public static readonly RoutedUICommand AlignmentBL = new RoutedUICommand
                 (
                         "AlignmentBL",
                         "AlignmentBL",
                         typeof(CustomCommands),
                         null
                 );

         public static readonly RoutedUICommand AlignmentBR = new RoutedUICommand
                (
                        "AlignmentBR",
                        "AlignmentBR",
                        typeof(CustomCommands),
                        null
                );

         public static readonly RoutedUICommand AlignmentBC = new RoutedUICommand
                (
                        "AlignmentBC",
                        "AlignmentBC",
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

         public static readonly RoutedUICommand ExLargeThumb = new RoutedUICommand
              (
                      "ExLargeThumb",
                      "ExLargeThumb",
                      typeof(CustomCommands),
                      null
              );
        #endregion

        #region "Rotation Custom Commands"
         public static readonly RoutedUICommand Rotate90 = new RoutedUICommand
               (
                       "Rotate90",
                       "Rotate90",
                       typeof(CustomCommands),
                       null
               );

         public static readonly RoutedUICommand Rotate180 = new RoutedUICommand
                (
                        "Rotate180",
                        "Rotate180",
                        typeof(CustomCommands),
                        null
                );


         public static readonly RoutedUICommand Rotate270 = new RoutedUICommand
                (
                        "Rotate270",
                        "Rotate270",
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

         public static readonly RoutedUICommand ViewRotate90 = new RoutedUICommand
                (
                        "ViewRotate90",
                        "ViewRotate90",
                        typeof(CustomCommands),
                        null
                );

         public static readonly RoutedUICommand ViewRotate180 = new RoutedUICommand
                (
                        "ViewRotate180",
                        "ViewRotate180",
                        typeof(CustomCommands),
                        null
                );


         public static readonly RoutedUICommand ViewRotate270 = new RoutedUICommand
                (
                        "ViewRotate270",
                        "ViewRotate270",
                        typeof(CustomCommands),
                        null
                );

         public static readonly RoutedUICommand ViewFlipX = new RoutedUICommand
                (
                        "ViewFlipX",
                        "ViewFlipX",
                        typeof(CustomCommands),
                        null
                );

         public static readonly RoutedUICommand ViewFlipY = new RoutedUICommand
                (
                        "ViewFlipY",
                        "ViewFlipY",
                        typeof(CustomCommands),
                        null
                );
        #endregion

        #region "Zoom Custom Commands"
         public static readonly RoutedUICommand Zoom50 = new RoutedUICommand
                 (
                         "Zoom50",
                         "Zoom50",
                         typeof(CustomCommands),
                         null
                 );

         public static readonly RoutedUICommand Zoom100 = new RoutedUICommand
                 (
                         "Zoom100",
                         "Zoom100",
                         typeof(CustomCommands),
                         null
                 );

         public static readonly RoutedUICommand Zoom150 = new RoutedUICommand
                 (
                         "Zoom150",
                         "Zoom150",
                         typeof(CustomCommands),
                         null
                 );

         public static readonly RoutedUICommand Zoom200 = new RoutedUICommand
                 (
                         "Zoom200",
                         "Zoom200",
                         typeof(CustomCommands),
                         null
                 );

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

         public static readonly RoutedUICommand ZoomHeightFit = new RoutedUICommand
                     (
                             "ZoomHeightFit",
                             "ZoomHeightFit",
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
        #endregion

        #region "MouseMode Custom Commands"
         public static readonly RoutedUICommand MousePan = new RoutedUICommand
                      (
                              "MousePan",
                              "MousePan",
                              typeof(CustomCommands),
                              null
                      );

         public static readonly RoutedUICommand MouseAutoZoom = new RoutedUICommand
                       (
                               "MouseAutoZoom",
                               "MouseAutoZoom",
                               typeof(CustomCommands),
                               null
                       );

         public static readonly RoutedUICommand MouseAreaSelection = new RoutedUICommand
                       (
                               "MouseAreaSelection",
                               "MouseAreaSelection",
                               typeof(CustomCommands),
                               null
                       );

         public static readonly RoutedUICommand MouseMagnifier = new RoutedUICommand
                       (
                               "MouseMagnifier",
                               "MouseMagnifier",
                               typeof(CustomCommands),
                               null
                       );

         public static readonly RoutedUICommand MouseNothing = new RoutedUICommand
                       (
                               "MouseNothing",
                               "MouseNothing",
                               typeof(CustomCommands),
                               null
                       );
        #endregion

        #region "MouseWheel Mode Custom Commands"
        public static readonly RoutedUICommand MouseWheelZoom = new RoutedUICommand
                       (
                               "MouseWheelZoom",
                               "MouseWheelZoom",
                               typeof(CustomCommands),
                               null
                       );

        public static readonly RoutedUICommand MouseWheelVerticalScroll = new RoutedUICommand
                       (
                               "MouseWheelVerticalScroll",
                               "MouseWheelVerticalScroll",
                               typeof(CustomCommands),
                               null
                       );

        public static readonly RoutedUICommand MouseWheelPageChange = new RoutedUICommand
                       (
                               "MouseWheelPageChange",
                               "MouseWheelPageChange",
                               typeof(CustomCommands),
                               null
                       );

        #endregion

        #region "Render Engine Custom Commands"
        public static readonly RoutedUICommand RenderEngineGDI = new RoutedUICommand
                       (
                               "RenderEngineGDI",
                               "RenderEngineGDI",
                               typeof(CustomCommands),
                               null
                       );

        public static readonly RoutedUICommand RenderEngineWPF = new RoutedUICommand
                       (
                               "RenderEngineWPF",
                               "RenderEngineWPF",
                               typeof(CustomCommands),
                               null
                       );

        public static readonly RoutedUICommand RenderEngineHYBRID = new RoutedUICommand
                       (
                               "RenderEngineHYBRID",
                               "RenderEngineHYBRID",
                               typeof(CustomCommands),
                               null
                       );
        #endregion

        #region "Editor Mode Custom Command"
        public static readonly RoutedUICommand EditorMode = new RoutedUICommand
                      (
                              "EditorMode",
                              "EditorMode",
                              typeof(CustomCommands),
                              null
                      );
        #endregion

        #region Annotations Menu Items Custom Commands"
        public static readonly RoutedUICommand RemoveSelected = new RoutedUICommand
         (
                 "RemoveSelected",
                 "RemoveSelected",
                 typeof(CustomCommands),
                 new InputGestureCollection()
                                {
                                        new KeyGesture(Key.Delete)
                                }
         );

        public static readonly RoutedUICommand RemoveAll = new RoutedUICommand
        (
                "RemoveAll",
                "RemoveAll",
                typeof(CustomCommands),
                new InputGestureCollection()
                                {
                                        new KeyGesture(Key.Delete, ModifierKeys.Control)
                                }
        );

        public static readonly RoutedUICommand SaveCurrent = new RoutedUICommand
        (
                "SaveCurrent",
                "SaveCurrent",
                typeof(CustomCommands),
                null
        );

        public static readonly RoutedUICommand SaveAll = new RoutedUICommand
       (
               "SaveAll",
               "SaveAll",
               typeof(CustomCommands),
              null
       );

        public static readonly RoutedUICommand LoadFromXML = new RoutedUICommand
       (
               "LoadFromXML",
               "LoadFromXML",
               typeof(CustomCommands),
               null
       );
        public static readonly RoutedUICommand BurnAnnotations = new RoutedUICommand
       (
               "BurnAnnotations",
               "BurnAnnotations",
               typeof(CustomCommands),
              null
       );
        #endregion
    }
}
