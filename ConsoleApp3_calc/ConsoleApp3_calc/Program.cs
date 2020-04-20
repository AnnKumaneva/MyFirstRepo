﻿using System;
class Calc
{
    static void Main(string[] args)
    {

        char answer = 'y';

        while (answer == 'y')
        {
            
            double a, b, c;
            string n;

            Console.WriteLine("Введите первое число:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите символ операции:");
            Console.WriteLine("'+' если сложение;");
            Console.WriteLine("'-' если вычитание; ");
            Console.WriteLine("'*' если умножение ");
            Console.WriteLine("'/' если деление. ");

            n = Console.ReadLine();

            while (n != "+" && n != "-" && n != "/" && n != "*")
            {
                Console.WriteLine("Символ операции введен неверно! Повторите ввод символа операции!");
                n = Console.ReadLine();

            }
            Console.WriteLine("Введите второе число:");
            b = double.Parse(Console.ReadLine());

            switch (n)
            {
                case "+":
                    c = a + b;
                    Console.WriteLine();
                    Console.WriteLine(a + "+" + b + "=" + c);
                    break;

                case "-":
                    c = a - b;
                    Console.WriteLine();
                    Console.WriteLine(a + "-" + b + "=" + c);
                    break;

                case "*":
                    c = a * b;
                    Console.WriteLine();
                    Console.WriteLine(a + "*" + b + "=" + c);
                    break;

                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    else
                    {
                        c = a / b;
                        Console.WriteLine();
                        Console.WriteLine(a + "/" + b + "=" + c);
                    };
                    break;


            }
            Console.ReadLine();
            Console.WriteLine("Продолжить работу с калькулятором? (y/n)");
            answer = Convert.ToChar(Console.ReadLine());
        }
    }
}