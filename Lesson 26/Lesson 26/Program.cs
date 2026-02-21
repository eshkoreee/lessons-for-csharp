using System.Globalization;

namespace Lesson_26
{
    /*
     * Массивы и циклы
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 3, 2, 55, 8 };

          

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]); 
            }

            Console.ReadLine();
        }
    }
}
