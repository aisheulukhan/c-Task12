using System;

namespace PrintFileTask.Models
{
    class Program
    {

        static void Main(string[] args)
        {
            Word word = new Word("Aaaaa.docs", 100);
            Pdf pdf = new Pdf("Baaa.pdf", 300);
            Excel excel = new Excel("Cccc.xlx", 60, 50);
            PrintFile<IPrintable> printFile = new PrintFile<IPrintable>();
          
            printFile.Print(word);
            printFile.Print(pdf);
            printFile.Print(excel);

            //PrintFile<Word> printw = new PrintFile<Word>();
            //PrintFile<Pdf> printp = new PrintFile<Pdf>();
            //PrintFile<Excel> printe = new PrintFile<Excel>();

            //printw.Print(word);
            //printp.Print(pdf);
            //printe.Print(excel);



        }
    }
}
