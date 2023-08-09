using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfReducer
{
    internal sealed class FileToProcess
    {
        public string InputFileName { get; }

        public string OutputFileName { get;  }


        public FileToProcess(string inputFileName, string outputFileName)
        {
            InputFileName = inputFileName;
            OutputFileName = outputFileName;
        }
    }
}
