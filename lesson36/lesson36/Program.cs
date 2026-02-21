using System.Threading.Channels;

namespace lesson36
    /*
     * перегрузка методов
     */
{
    internal class Program
    {
        /// <summary>
        /// возвращает сумму 2 целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a,int b)
        {
            return a + b;
        }
        static int Sum(int a, int b,int c)
        {
            return a + b + c;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int result = Sum(2, 3, 4);
            Console.WriteLine();
        }
    }
}
