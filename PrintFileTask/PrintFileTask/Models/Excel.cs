using System;
using System.Collections.Generic;
using System.Text;

namespace PrintFileTask.Models
{
    class Excel:IPrintable
    {
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        public string FileName { get; set; }
        public Excel(string filename,int columncolunt, int rowcount)
        {
            FileName = filename;
            ColumnCount = columncolunt;
            RowCount = rowcount;

        }
        public void Print()
        {
            Console.WriteLine($"{FileName} Excel file printed. Columns {ColumnCount}, Rows {RowCount}");
        }
        
    }
}
