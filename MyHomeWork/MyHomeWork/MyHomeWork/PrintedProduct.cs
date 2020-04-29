using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeWork
{
    public abstract class Printed_Product
    {
        static public string Title;
        string PrintingHouse;
        int Page;
        double Cost;
        public bool IsRead;
        public abstract void MarkRead();
        public abstract void PrintName();
    }
}
