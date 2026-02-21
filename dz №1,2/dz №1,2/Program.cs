using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz__1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("напишите число 1");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("напишите число 2");
            double b = double.Parse(Console.ReadLine());

            double c = (a + b) / 2;

            Console.WriteLine("ответ равен " + c);
        }
    }
}
