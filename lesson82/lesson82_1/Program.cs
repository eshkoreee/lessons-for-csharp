using System.Security.Cryptography.X509Certificates;

namespace lesson82_1
{
    interface IPrintable
    {
        void Print();
    }

    public struct Point : IPrintable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY{Y}");
            

        }

             
        
           
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
