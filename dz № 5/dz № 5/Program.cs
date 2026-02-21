using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz___5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string line = "";
            Console.Write("введите число: ");

            int a = int.Parse(Console.ReadLine());

            for (int count = 0; count <= a; count++)
            {
                line += "# ";
                Console.WriteLine(line);
            }
            Console.WriteLine();
            for (int count = a; count >= 0; count--)
            {
                for (int s = count; s >= 0; s--)
                {                    
                    Console.Write("# ");
                }
                Console.WriteLine();
            }


            for (int count = a; count >= 0; count--)
            {
                for (int s = count,c = a; s >= 0; s--)
                {
                    Console.Write("  ");
                }
                int reshotka = a - count;
                for (int i = reshotka; i >= 0; i--)
                {
                    Console.Write(" #");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            for (int count = a; count >= 0; count--)
            {
            
                int reshotka = a - count;
                for (int i = reshotka; i >= 0; i--)
                {
                    Console.Write("  ");
                }
                
                for (int s = count, c = a; s >= 0; s--)
                {
                    Console.Write(" #");
                }
                
                
                Console.WriteLine();
            }

        }
    }
}
