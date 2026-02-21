using System.Buffers;

namespace lesson_49
{
    /*
     * Рекурсия
     * 
     * Методы и стек
     * 
     * Переполнение стека
     */
    internal class Program
    {
        static void Foo(int i)
        { 
        if(i >= 3)
        return;

            i++;

            Foo(i);
        }
        static void Main(string[] args)
        {
            
            Foo(5);
        }
    }
}
