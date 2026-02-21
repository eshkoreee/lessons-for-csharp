using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Цикл for особенности
 * несколько переменных
 * цикл for в обратном порядке
 * несколько условий
 */

namespace lesson19
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //int i = 0;
            //for (; i < 3; i++)
            //{
            // Console.WriteLine("for_1: " + i);
            //}
            // for (; i < 5; i++)
            // {
            //     Console.WriteLine("for_2: " + i);
            // }
            for (int i = 5,j = 5; i < 10, ; i++,j--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
