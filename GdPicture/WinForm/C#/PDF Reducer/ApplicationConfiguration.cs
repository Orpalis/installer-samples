using System.Windows.Forms;
using System;
using System.Reflection;
using GdPicture14;

namespace pdfReducer
{
    [Serializable]
    [ObfuscationAttribute(Exclude = true)]
    internal sealed class ApplicationConfiguration
    {
        public PDFReducerConfiguration PDFReducerConfiguration { get; } = new PDFReducerConfiguration();
        public string InputPath { get; set; }
        public string OutputPath { get; set; }
        public bool OnlyProcessPDF { get; set; }
    }
}