using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * Условный оператор switch
 */

namespace lesson15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                    case 1:
                    case 2:
                    {
                        Console.WriteLine("вы ввели число 1 или 2");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("ошибка вы ввели неизвестное число");
                    }
                        break;
            }
        }
    }
}
