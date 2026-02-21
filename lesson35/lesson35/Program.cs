namespace lesson35
{
    /*
     * функции и методы в с#
     */


    //      модификаторы тип_записанного_значения название_метода(параметры)
    //      {
    //          тело метода   
    //      }

    internal class Program
    {
        static int Sum(int v1, int v2)
        { 
        int result = v1 + v2;
            
            return result;
        }
        static void PrintResult(int result)
        {

            Console.WriteLine("результат сложения " + result);
        }

        static void Main(string[] args)
        {
            int a, b;

            a = int.Parse(Console.ReadLine());  
            b = int.Parse(Console.ReadLine());



            int c = Sum(a, b);
            PrintResult(c);
        }
    }
}
