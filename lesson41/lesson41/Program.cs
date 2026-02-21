namespace lesson41
{
    /*
     *      оператор присваивания обьединения со значением null ??=
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            str ??= string.Empty;
            Console.WriteLine(str.Length);

        }
    }
}
