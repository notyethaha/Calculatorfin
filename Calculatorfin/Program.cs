using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorfin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("КАЛЬКУЛЯТОР ОСНОВНЫХ АРИФМЕСТИЧЕСКИХ ОПЕРАЦИЙ");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Для начала работы нажмите ЛЮБУЮ КНОПКУ");
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Пожалуйста, введите первое число:");

                Console.ForegroundColor = ConsoleColor.Green;
                double a = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Введите знак нужной Вам операции: '+' '-' '*' '/'");

                Console.ForegroundColor = ConsoleColor.Green;
                string operation = Console.ReadLine();
                Console.ResetColor();

                Console.WriteLine("Введите второе число:");

                Console.ForegroundColor = ConsoleColor.Green;
                double b = Convert.ToDouble(Console.ReadLine());
                Console.ResetColor();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Итог вычислений " + a + " + " + b + ":");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(a + b);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Для продолжения нажмите ЛЮБУЮ КНОПКУ");
                        Console.ResetColor();

                        break;

                    case "-":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Итог вычислений " + a + " - " + b + ":");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(a - b);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Для продолжения нажмите ЛЮБУЮ КНОПКУ");
                        Console.ResetColor();
                        break;

                    case "*":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Итог вычислений " + a + " * " + b + ":");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(a * b);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Для продолжения нажмите ЛЮБУЮ КНОПКУ");
                        Console.ResetColor();
                        break;

                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Итог вычислений " + a + " / " + b + ":");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(0);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Для продолжения нажмите ЛЮБУЮ КНОПКУ");
                            Console.ResetColor();
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Итог вычислений " + a + " / " + b + ":");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(a / b);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Для продолжения нажмите ЛЮБУЮ КНОПКУ");
                            Console.ResetColor();
                        }

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Извините, такой операции не существует.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Для продолжения нажмите ЛЮБУЮ КНОПКУ");
                        Console.ResetColor();
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
