using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DicomViewer
{
    public static class Config
    {

        private const int speed_def = 10;
        public static int speed = Properties.Settings.Default.speed;
        public static bool preloadImages = Properties.Settings.Default.preloadImages;


        public static void resetDefault()
        {
            speed = speed_def;
        }

        public static void saveConfig()
        {
            Properties.Settings.Default.speed = speed;
            Properties.Settings.Default.preloadImages = preloadImages;
            Properties.Settings.Default.Save();
        }
    }
}
