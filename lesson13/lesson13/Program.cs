using System;

/*
 * Конструкция if else
 */

/*
  
                   if (утверждение или выражение)
                   {
                       действие 1;
                   }
                   else
                   {
                       действие 2;
                   }

*/

namespace lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int a = int.Parse(Console.ReadLine());

            if (a == 5)
            {
                Console.WriteLine("a ровно 5");
            }
            else 
            {
                Console.WriteLine("а не равно 5");
            }
        }
    }
}
