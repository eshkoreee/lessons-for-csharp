using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * вложенные циклы
 */

namespace lesson22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("цикл 1 итерация №:" + i);
                for (int e = 0; e <= 5; e++)
                {
                    Console.WriteLine("\tцикл 2 итерация №:" + e);
                    for (int q = 0; q <=  2; q++)
                    {
                        Console.WriteLine("\t\tцикл 3 итерация №:" + e);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
