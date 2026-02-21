using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 * конвертация строки в число и т д
 * класс convert
 */

namespace lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "1.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            { 
                NumberDecimalSeparator = ".",
            };

            Double a = Convert.ToDouble(str,numberFormatInfo);
            
        }
    }
}
