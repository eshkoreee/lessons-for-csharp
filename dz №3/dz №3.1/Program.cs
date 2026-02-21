using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * калькулятор на основе if
 */

namespace dz__3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("добро пожаловать в калькулятор!");
            Console.WriteLine("пожайлуста выберите действие = плюс, минус, делить, умножить");
            string действие = Console.ReadLine();
            Console.Clear();

            if (действие == "плюс")
            {
                Console.WriteLine("выберите первое число");
                double a = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("выберите второе число");
                double b = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("сложение " + a + " и " + b + " будет " + (a + b));
            }
            if (действие == "минус")
            {
                Console.WriteLine("выберите первое число");
                double a = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("выберите второе число");
                double b = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("вычитание " + a + " и " + b + " будет " + (a + b));
            }
            if (действие == "делить")
            {
                Console.WriteLine("выберите первое число");
                double a = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("выберите второе число");
                double b = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("деление " + a + " и " + b + " будет " + (a + b));
            }
            if (действие == "умножить")
            {
                Console.WriteLine("выберите первое число");
                double a = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("выберите второе число");
                double b = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("умножение " + a + " и " + b + " будет " + (a + b));
            }
            else { Console.WriteLine("ошибка: неизвестный символ!"); }
        }
    }
}
