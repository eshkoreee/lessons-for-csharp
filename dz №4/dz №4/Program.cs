using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int even = 0;
            int odd = 0;
            
            int limit = int.Parse(Console.ReadLine());
            while (count < limit) 
            { 
            count++;
                if (count % 2 == 1)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("в числе " + limit + " четных " + even + " а нечетных " + odd);
        }
    }
}
