using System;
using System.Collections.Generic;
using System.Linq;
using NLog;

namespace MyHomeWork
{

    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();

        [MyAttribute (Name = "Bla-Bla-Bla", Number = 666)]
        static void Main(string[] args)
        {

            //log.Debug("Debug");
            //log.Error("Error1");
            //log.Trace("Trace!!!!!!");

            Book book1 = new Book("роман", "Война и мир", "Л.Н.Толстой");

            book1.PrintName();
            book1.Publish();
            book1.MarkRead();

            // в случае обработки исключения(неправильный ввод года, месяца или дня) не печатается статус книги
            PrintStatusIfCorrectInput(book1);
            

            Book book2 = new Book("детектив", "Под прицелом", "М.Н.Маринина");

            book2.PrintName();
            book2.Publish();

            // в случае обработки исключения(неправильный ввод года, месяца или дня) не печатается статус книги
            PrintStatusIfCorrectInput(book2);
                       
            
            Journal journal1 = new Journal("Maksim", "Иванов Иван Иванович");

            journal1.PrintName();
            journal1.Publish();

            PrintStatus(journal1);

            Journal journal2 = new Journal("Elle", "Петров Петр Петрович");

            journal2.PrintName();
            journal2.Publish();
            journal2.MarkRead();

            PrintStatus(journal2);

            //работа с коллекцией b объектов класса Book, сортировка объектов коллекции b по полю Author
            
            List<Book> b = new List<Book>();
            b.Add(book1);
            b.Add(book2);

            var sortBook = from a in b
                           orderby a.Title
                           select a;

            foreach (Book a in sortBook)
                Console.WriteLine(a.Title);

            

            var sortBook2 = 
                b.OrderBy(z => z.Genre)
                .Where(z => z.Genre == "роман");

            foreach (Book a in sortBook2)
                Console.WriteLine(a.Genre);

            Console.ReadKey();
        }

        private static void PrintStatus(PrintedProduct printedProduct)
        {
            if (printedProduct.IsRead)
            {
                Console.WriteLine("Статус - прочитан(а)");
            }
            else
            {
                Console.WriteLine("Статус - не прочитан(а)");
            }
            Console.WriteLine();
        }

        private static void PrintStatusIfCorrectInput(Book x)
        {
            if ((x.PrintYear != 0) && (x.PrintMounth != 0) && (x.PrintDay != 0))
            {
                PrintStatus(x);
            }
        }
    }
}
