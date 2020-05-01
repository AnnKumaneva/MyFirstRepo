using System;
using System.Collections.Generic;
using System.Linq;

namespace MyHomeWork
{

	class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("роман", "Война и мир", "Л.Н.Толстой");

            book1.PrintName();
            book1.Publish();
            book1.MarkRead();

            PrintStatus(book1);

            Book book2 = new Book("детектив", "Под прицелом", "М.Н.Маринина");

            book2.PrintName();
            book2.Publish();

            PrintStatus(book2);


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
                           orderby a.Author
                           select a;

            foreach (Book a in sortBook)
                Console.WriteLine(a.Author);

            Console.ReadKey();
        }

        private static void PrintStatus(Printed_Product printedProduct)
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
    }
}
