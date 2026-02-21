using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число 1");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("введите число 2");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("введите число 3");
            int c = int.Parse(Console.ReadLine());
            
            int d = a + b + c;
            Console.WriteLine("сложение " + a + " " + b + " " + c + " равно " + d);
        }
    }
}
