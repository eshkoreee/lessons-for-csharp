using System.Net.Http.Headers;

namespace lesson51
{
    //"ядерный ганди" и арифметическое переполнение
    internal class Program
    {
        static void Main(string[] args)
        {
            byte aggression = 1;

            byte democracyModifier = 2;

            aggression = checked((byte)(aggression - democracyModifier)); //сужающее преобразование данных
            Console.WriteLine(aggression);
        }
    }
}
