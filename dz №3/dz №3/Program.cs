using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * калькулятор на основе switch
 */

namespace dz__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("добро пожаловать в калькулятор!");
            Console.WriteLine("пожайлуста выберите действие = плюс, минус, делить, умножить");
            string действие = Console.ReadLine();
            Console.Clear();
            switch (действие)
            {
                case "плюс":
                    {
                        Console.WriteLine("выберите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("выберите второе число");
                        double b = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("сложение " + a + " и " + b + " будет " + (a + b));
                    }
                    break;
                case "минус":
                    {
                        Console.WriteLine("выберите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("выберите второе число");
                        double b = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("вычитание " + a + " и " + b + " будет " + (a - b));
                    }
                    break;
                case "делить":
                    {
                        Console.WriteLine("выберите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("выберите второе число");
                        double b = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("деление " + a + " и " + b + " будет " + (a / b));
                    }
                    break;
                case "умножить":
                    {
                        Console.WriteLine("выберите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("выберите второе число");
                        double b = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("умножение " + a + " и " + b + " будет " + (a * b));
                    }
                    break;
                default: Console.WriteLine("ошибка: вы ввели неизвестный символ!");
                    break;
            }
        }
    }
}
