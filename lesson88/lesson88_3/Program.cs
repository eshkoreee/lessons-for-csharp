using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson88_3
{
    //делегаты и лямбда выражений
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = numbers.Where(number => number % 2 == 0);// => лямбда выражения
            //вместо отдельного метода мы описали логику прям в передаваемом значении

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
        
    }
}
