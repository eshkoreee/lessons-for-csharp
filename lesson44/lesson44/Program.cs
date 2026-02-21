

namespace lesson44
{

    /*
     *   Ключевое слово out
     *   разница между ref и out
     */
    internal class Program
    {
        static void Foo(ref int value)
        { 
            Console.WriteLine(value);
        }
        // метод out в отличии от ref требует обязательное требование = присвоение значения.
        // присваивать значение нужно обязательно даже если это было сделано еще вне метода.
        public static void Bar(out int value)
        { 
            value = 0;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a;
            
            string str = Console.ReadLine();

            int.TryParse(str, out int result);
            
            Bar(out a);
            
        }
    }
}
