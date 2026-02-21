using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ввод данных в консоль
 */

namespace lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;

            data = Console.ReadLine();

            Console.WriteLine("Привет " + data + "!!!");
        }
    }
}
