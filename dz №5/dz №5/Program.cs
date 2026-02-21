using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// проверка введенного числа на четность

namespace dz__5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 1)
            {
                Console.WriteLine("число не четное");
            }
            else
            {
                Console.WriteLine("число четное");

            }
        }
    }
}
        
    

