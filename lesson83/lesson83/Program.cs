namespace lesson83
{
    /*
     * Обобщения (generics)
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 5;

            Console.WriteLine($"a = {a}\t b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}\t b = {b}");
            int resilt = Foo<int>();
        }
        static void Swap<TValue>(ref TValue a, ref TValue b)
        {
            TValue temp = a;
            a = b; 
            b = temp;
        }
        static TValue Foo<TValue>()
        {

            return default(TValue);
        }
    }
}
