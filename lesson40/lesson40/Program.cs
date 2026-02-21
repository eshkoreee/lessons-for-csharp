namespace lesson40
{
    /*
     *      оператор null-объединения
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string result;
            string str = "test";
            Console.WriteLine(str ?? "нет данных");
            
        }
    }
}
