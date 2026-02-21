namespace lesson43
{
    /*
     *  Ключевое слово ref
     *  
     *  передача аргументов по ссылке
     */
    internal class Program
    {
        static void Foo(ref int a)
        {
            a = -5;
        }
        static void Bar(ref int[] Arr)
        {
           Arr = new int[10];
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6 };
            int a = 5;
            Foo(ref a)
            Bar(ref myArray);
            Console.WriteLine(myArray.Length);
        }
    }
}
