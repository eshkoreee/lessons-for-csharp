namespace lesson63
{
    /*
     * ключевое слово static
     * 
     * статические поля класса
     */
    class MyClass
    {
        private static int b;

        public void SetB(int b)
        {
            MyClass.b = b;
        }

        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            myClass1.SetB(9);

            MyClass myClass2 = new MyClass();
            myClass2.PrintB();
        }
    }
}
