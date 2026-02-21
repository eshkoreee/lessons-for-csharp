namespace lesson64
{
    /*
     * ключевое слово static
     * 
     * Статические методы класса
     * 
     * Статические свойства класса
     */
    class MyClass
    {
        public MyClass() 
        {
            counter++;
        }
        private static int counter;

        public static int Counter    
        {
            get { return counter; }
            private set { counter = value; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            

            
        }
    }
}
