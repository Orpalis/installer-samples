using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfReducer
{
    internal sealed class ThreadItem
    {
        public int WorkerThreadNumber { get; }

        public string Caption { get; set; }


        public ThreadItem(string caption, int workerThreadNumber)
        {
            Caption = caption;
            WorkerThreadNumber = workerThreadNumber;
        }


        public override string ToString()
        {
            return Caption;
        }
    }
}