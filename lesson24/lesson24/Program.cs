using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * массивы
 * 
 * Одномерные массивы
 * 
 * Тип_елементов_массива [] имя_массива;
 */

namespace lesson24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;

            myArray = new int[5];

            myArray[1] = 1;
            myArray[0] = 11;

            int a = myArray[0];
            Console.WriteLine(myArray.Length);
        }
    }
}
