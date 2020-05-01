using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeWork
{
    class Book : Printed_Product, IPublishable
    {
        private int printYear;
        private int printMounth;
        private int printDay;

        public string Author { get; set; }
        public string Genre { get; set; }

        public Book (string genre, string title, string author)
        {
            this.Genre = genre;
            Title = title;
            this.Author = author;
        }
        public override void MarkRead()
        {
            IsRead = true;
        }

        public override void PrintName()
        {
            Console.WriteLine(Genre + " " + Title + " " + Author);
        }

        public void Publish()
        {
            Console.Write("Введите год издания:");
            printYear = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц издания:");
            printMounth = int.Parse(Console.ReadLine());

            Console.Write("Введите день издания:");
            printDay = int.Parse(Console.ReadLine());

            Console.Write(Genre + " " + Title + " " + Author + " напечатан(а): ");

            Console.Write(printDay + "." + printMounth + "." + printYear);
            Console.WriteLine();
        }

        private static void PrintStatus(Book book1)
        {
            if (book1.IsRead)
            {
                Console.WriteLine("Статус - прочитан(а)");
            }
            else
            {
                Console.WriteLine("Статус - не прочитан(а)");
            }
        }
    }
}
