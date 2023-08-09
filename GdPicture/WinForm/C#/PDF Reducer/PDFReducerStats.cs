using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfReducer
{
    internal sealed class PDFReducerStats
    {
        public int ProcessedFilesCount { get; set; }

        public double InputFilesSize { get; set; }

        public double OutputFileSize { get; set; }

        public double ReductionRatio { get; set; }
    }
}