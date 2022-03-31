using System;
using System.Collections.Generic;
using System.Text;

namespace PrintFileTask.Models
{
    class Pdf:IPrintable
    {
        public int PageCount { get; set; }
        public string FileName { get; set; }
        public Pdf(string filename, int pagecount)
        {
            FileName = filename;
            PageCount = pagecount;

        }
        public void Print()
        {
            Console.WriteLine($"{FileName} Pdf file printed. Pages {PageCount}");
        }
    }
}
