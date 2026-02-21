using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 * конвертация строки
 * parse и tryparse
 */

namespace lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "5.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."

            };
            double a = double.Parse(str, numberFormatInfo);
        }
    }
}
