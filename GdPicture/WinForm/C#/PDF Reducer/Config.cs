using System.Windows.Forms;
using System;
using System.Reflection;
//using GdPicture.Internal.PDF.Reducer;
using GdPicture14;

namespace pdfReducer
{
    [Serializable]
    [ObfuscationAttribute(Exclude = true)]
    internal sealed class ApplicationConfiguration
    {
        public PDFReducerConfiguration PDFReducerConfiguration { get; }

        [NonSerialized]
        public int MaxThreads = Environment.ProcessorCount;

        public string InputPath { get; set; }
        public string OutputPath { get; set; }
        public bool ExportLogs { get; set; }
        public bool OnlyProcessPDF { get; set; } = Globals.ONLY_PROCESS_PDF_DEFAULT;
        public bool ProcessSubFolders { get; set; } = Globals.PROCESS_SUBFOLDERS_DEFAULT;
        public string InputFileFormats { get; set; }

        public ApplicationConfiguration()
        {
            PDFReducerConfiguration = new PDFReducerConfiguration();
        }
    }
}