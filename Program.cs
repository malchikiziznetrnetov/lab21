﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите действие: +, -, *, /, e - выйти");
            bool checker = true;
            while (checker == true)
            {
                try
                {
                    char symbol = char.Parse(Console.ReadLine());
                    switch (symbol)
                    {
<<<<<<< HEAD
                        case '+':
                            Console.WriteLine($"Результат {a + b}");
=======
                        case '-':
                            Console.WriteLine($"Результат {a - b}");
>>>>>>> substract
                            break;
                        default:
                            Console.WriteLine("Выберите действие: +, -, *, /, e - выйти");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
