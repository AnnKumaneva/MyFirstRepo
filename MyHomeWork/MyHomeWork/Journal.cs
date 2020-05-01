using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeWork
{
    class Journal : Printed_Product, IPublishable
    {
        private int printYear;
        private int printMounth;

        public string Editor { get; set; }
        public string Type { get; set; }

        public Journal(string title, string editor)
        {
            Title = title;
            this.Editor = editor;
        }

        public void Publish()
        {
            Console.Write("Введите год издания:");
            printYear = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц издания:");
            printMounth = int.Parse(Console.ReadLine());

            Console.Write(Title + " " + " напечатан(а): ");

            Console.Write(printMounth + "." + printYear);
            Console.WriteLine();
        }

        public override void MarkRead()
        {
            IsRead = true;
        }

        public override void PrintName()
        {
            Console.WriteLine(Title);
        }
    }
}
