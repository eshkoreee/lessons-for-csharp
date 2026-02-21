using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace lesson88
{
    // delegates (делегаты)
     
    internal class Program
    {
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> mathOperation = Sum;

            var result = mathOperation(5, 10);

            
        }
    }
}
