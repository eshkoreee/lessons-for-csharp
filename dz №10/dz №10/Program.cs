namespace dz__10
{
    internal class Program
    {
        static string PrintLine(string q)
        {
            Console.WriteLine("вы получили " + q);
            return q;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите символы которые хотите получить");
            string a = Console.ReadLine();
            Console.Clear();
            PrintLine(a);
        }
    }
}
