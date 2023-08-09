using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pdfReducer.Utilities;

namespace pdfReducer
{
    internal static class Globals
    {
        public static readonly int MaxThreads = Environment.ProcessorCount;

        public static readonly ApplicationConfiguration ApplicationConfiguration = new ApplicationConfiguration();

        // Supported formats list
        public static readonly GdPicture14.DocumentFormat[] SupportedFormats =
            {GdPicture14.DocumentFormat.DocumentFormatPDF ,
            GdPicture14.DocumentFormat.DocumentFormatICO,
            GdPicture14.DocumentFormat.DocumentFormatBMP,
            GdPicture14.DocumentFormat.DocumentFormatWBMP,
            GdPicture14.DocumentFormat.DocumentFormatJPEG,
            GdPicture14.DocumentFormat.DocumentFormatGIF,
            GdPicture14.DocumentFormat.DocumentFormatPNG,
            GdPicture14.DocumentFormat.DocumentFormatTIFF,
            GdPicture14.DocumentFormat.DocumentFormatFAXG3,
            GdPicture14.DocumentFormat.DocumentFormatEXIF,
            GdPicture14.DocumentFormat.DocumentFormatEMF,
            GdPicture14.DocumentFormat.DocumentFormatWMF,
            GdPicture14.DocumentFormat.DocumentFormatJNG,
            GdPicture14.DocumentFormat.DocumentFormatKOALA,
            GdPicture14.DocumentFormat.DocumentFormatIFF,
            GdPicture14.DocumentFormat.DocumentFormatMNG,
            GdPicture14.DocumentFormat.DocumentFormatPCD,
            GdPicture14.DocumentFormat.DocumentFormatPCX,
            GdPicture14.DocumentFormat.DocumentFormatPBM,
            GdPicture14.DocumentFormat.DocumentFormatPBMRAW,
            GdPicture14.DocumentFormat.DocumentFormatPFM,
            GdPicture14.DocumentFormat.DocumentFormatPGM,
            GdPicture14.DocumentFormat.DocumentFormatPGMRAW,
            GdPicture14.DocumentFormat.DocumentFormatPPM,
            GdPicture14.DocumentFormat.DocumentFormatPPMRAW,
            GdPicture14.DocumentFormat.DocumentFormatRAS,
            GdPicture14.DocumentFormat.DocumentFormatTARGA,
            GdPicture14.DocumentFormat.DocumentFormatPSD,
            GdPicture14.DocumentFormat.DocumentFormatCUT,
            GdPicture14.DocumentFormat.DocumentFormatXBM,
            GdPicture14.DocumentFormat.DocumentFormatXPM,
            GdPicture14.DocumentFormat.DocumentFormatDDS,
            GdPicture14.DocumentFormat.DocumentFormatHDR,
            GdPicture14.DocumentFormat.DocumentFormatSGI,
            GdPicture14.DocumentFormat.DocumentFormatEXR,
            GdPicture14.DocumentFormat.DocumentFormatJ2K,
            GdPicture14.DocumentFormat.DocumentFormatJP2,
            GdPicture14.DocumentFormat.DocumentFormatJBIG,
            GdPicture14.DocumentFormat.DocumentFormatPICT,
            GdPicture14.DocumentFormat.DocumentFormatRAW,
            GdPicture14.DocumentFormat.DocumentFormatWEBP,
            GdPicture14.DocumentFormat.DocumentFormatDICOM,
            GdPicture14.DocumentFormat.DocumentFormatJBIG2,
            GdPicture14.DocumentFormat.DocumentFormatMemoryBMP,
            GdPicture14.DocumentFormat.DocumentFormatDOCX,
            GdPicture14.DocumentFormat.DocumentFormatRTF,
            GdPicture14.DocumentFormat.DocumentFormatTXT,
            GdPicture14.DocumentFormat.DocumentFormatODT
        };
    }
}