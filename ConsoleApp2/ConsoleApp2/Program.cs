﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.Write("Введите строку символов:");
            n = Console.ReadLine();
            Console.WriteLine("Строка четных символов:");
            for (int i = 0; i < n.Length; i++)
            {
                if (i % 2 == 1)
                    Console.Write(n[i] + " ");

            }
            Console.ReadLine();
        }
    }
}