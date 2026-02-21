using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
/*
 *  ключевое слово break
 */


namespace lesson20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string q = Console.ReadLine();
                Console.WriteLine(i);
                if (q == "exit")
                    
            { break; }
                
               
            }

            Console.ReadLine();
        }
    }
}
