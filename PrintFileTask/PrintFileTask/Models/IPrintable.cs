using System;
using System.Collections.Generic;
using System.Text;

namespace PrintFileTask.Models
{
    public interface IPrintable
    {
        public string FileName { get; set; }
        public void Print();
    }
}
