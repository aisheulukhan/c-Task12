using System;
using System.Collections.Generic;
using System.Text;

namespace PrintFileTask.Models
{
    public class PrintFile<T>
        where T : IPrintable
    {
        public void Print(T file)
        {
            file.Print();
        }
        


    }
}
