namespace lesson50
{
    // преобразование и приведение примитивных типов в С#

    internal class Program
    {
        static void Foo(float value)
        { Console.WriteLine(value); }
        static void Main(string[] args)
        {
            double a = 5;
            // буква F поясняет компилятору что переменная b имеет тип не double а float
            float b = 2.5F;
            

            //Foo((float));
        }
    }
}
