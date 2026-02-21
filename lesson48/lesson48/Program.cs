namespace lesson48
{
    /*
     * Именованые параметры
     */
    internal class Program
    {
        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine("Значение переменной а = " + a);
                Console.WriteLine("Значение переменной b = " + b);
                Console.WriteLine("Значение переменной result = " + result);
            }
            return result;
        }                 
        static void Main(string[] args)
        {
            int firstValue = 5, secondValue = 2;
            int result = Sum(firstValue,secondValue , enableLogging:true);
        }
    }
}
