using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace dz__1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("конвертер долларов в рубли");
            Console.WriteLine("выберите количество конвертируемой валюты");

            double dollar = double.Parse(Console.ReadLine());

            double ruble = dollar * 82.36;

            Console.WriteLine(dollar + " долларов в рублях будет " + ruble);

        }
    }
}
