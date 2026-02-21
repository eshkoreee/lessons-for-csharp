using System.Diagnostics.CodeAnalysis;

namespace lesson54
{
    //enum (перечесления)

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
               ConsoleKey key = Console.ReadKey().Key;

                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key}\tKey code{keyCode}");

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("вы нажали enter!");
                }
                
                
                    
                
            }
        }
    }
}
