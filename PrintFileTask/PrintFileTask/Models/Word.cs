using System;
using System.Collections.Generic;
using System.Text;

namespace PrintFileTask.Models
{
    class Word :IPrintable
    {
        public int WordCount { get; set; }
        public string FileName { get; set; }
        public Word(string filename, int wordcount)
        {
            FileName = filename;
            WordCount = wordcount;

        }
        public void Print()
        {
            Console.WriteLine($"{FileName} Pdf file printed. Pages {WordCount}");
        }
    }
}
