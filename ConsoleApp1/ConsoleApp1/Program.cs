﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите число элементов массива:");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int [ n ];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите arr[{0}]", i);
                arr[i] = int.Parse(Console.ReadLine());    
                
                if (arr[i] % 2 == 0)
                { sum = sum + arr[i]; }
                
            }
            Console.ReadLine();
            Console.WriteLine("Сумма четных чисел массива = " + sum);

        }
    }
}
