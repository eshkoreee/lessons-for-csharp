namespace lesson47
{
    /*
     *  Необязательные параметры методов
     */
    internal class Program
    {
        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine("Значение переменной = " + a);
                Console.WriteLine("Значение переменной = " + b);
                Console.WriteLine("Значение переменной = " + result);
                
            }
            return result;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 5;
            Sum(a, b,true);
        }
    }
}
