using System.Runtime.CompilerServices;

namespace lesson69_2
{
    /*
     * const и readonly
     */
    class MyClass
    {
        public readonly double a;

        public static readonly double b;//в отличии от const readonly не делает переменную неявно статическим

        public const string My_ERROR = "some error"; //дефолт условием для названия константы это написание имени капсом
        static MyClass()
        {
            b = 3;
        }
        public MyClass(int a)
        {
            this.a = a;
        }
        public void Foo()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(My_ERROR);
        }
    }
     class Program
     {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(4);
            myClass.Foo();
        }
     }
}
