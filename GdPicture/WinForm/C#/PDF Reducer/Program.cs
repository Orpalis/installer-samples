using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Reflection;
using GdPicture14;
using pdfReducer.Utilities;


namespace pdfReducer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            Application.Run(new frmMain());
        }
    }
}