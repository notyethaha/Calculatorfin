using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorfin
{
    internal class Program
    {
        static void OpperationEnd()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Для продолжения нажмите ЛЮБУЮ КНОПКУ");
            Console.ResetColor();
        }

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

                try
                {
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
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();

                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine("Итог вычислений " + a + " + " + b + ":");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(a + b);
                            OpperationEnd();

                            break;

                        case "-":
                            Console.WriteLine("Итог вычислений " + a + " - " + b + ":");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(a - b);
                            OpperationEnd();
                            break;

                        case "*":
                            Console.WriteLine("Итог вычислений " + a + " * " + b + ":");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(a * b);
                            OpperationEnd();
                            break;

                        case "/":
                            if (b == 0)
                            {
                                Console.WriteLine("Итог вычислений " + a + " / " + b + ":");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(0);
                                OpperationEnd();
                            }

                            else
                            {
                                Console.WriteLine("Итог вычислений " + a + " / " + b + ":");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(a / b);
                                OpperationEnd();
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
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Пожалуйста, проверьте корректность введённых данных!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Для продолжения нажмите ЛЮБУЮ КНОПКУ");
                    Console.ResetColor();
                }
                 Console.ReadKey();

            }
        }
    }
}
