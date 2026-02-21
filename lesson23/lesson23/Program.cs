using System;
using System.Threading.Tasks;
/*
 * Тернарный оператор
 * 
 * [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_false]
 */

namespace lesson23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;

            //string enteredPasswrord = Console.ReadLine();

            //accessAllowed = enteredPasswrord == storedPassword ? true : false;

             //Console.WriteLine(accessAllowed);
             int inputData = int.Parse(Console.ReadLine());
            int outputdata = inputData < 0 ? 0 : inputData;
            Console.WriteLine(outputdata);

        }
    }
}
