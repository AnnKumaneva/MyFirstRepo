using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeWork
{
    class Book : PrintedProduct, IPublishable
    {

       
        public int PrintYear { get; set; }
        public int PrintMounth { get; set; }
        public int PrintDay { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        private static Logger log = LogManager.GetCurrentClassLogger();


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
            
           
            //обработка исключений
            try
            {
                PrintYear = int.Parse(Console.ReadLine());
            }
            catch(Exception x)
            {
                log.Error("Неверный ввод года - не int {0}",x.Source);
                //Console.WriteLine("Error! {0}", x.Message);
                goto Link1;
            }

            Console.Write("Введите месяц издания:");

            //обработка исключений
            try
            {
                PrintMounth = int.Parse(Console.ReadLine());
            }
            catch (Exception x)
            {
                log.Info("Неверный ввод месяца {0}",x.Data);
                //Console.WriteLine("Error! {0}", x.Message);
                goto Link1;
            }

            Console.Write("Введите день издания:");

            //обработка исключений
            try
            {
                PrintDay = int.Parse(Console.ReadLine());
            }
            catch(Exception x)
            {
                Console.WriteLine("Error! {0}", x.Message);
                goto Link1;
            }

    Console.Write(Genre + " " + Title + " " + Author + " напечатан(а): ");

            Console.Write(PrintDay + "." + PrintMounth + "." + PrintYear);
            Link1:
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
