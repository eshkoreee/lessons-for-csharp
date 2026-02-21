using static lesson79.IFirstInterface;

namespace lesson79
{
    /*
     * явная реализация интерфейсов
     */
    interface IFirstInterface
    {
        void Action();
        interface ISecondInterface
        {
            void Action();
        }
    }
    class MyClass : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("MyClass Action...");
        }
    }
    public class MyOtherClass : IFirstInterface,ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("MyOtherClass IFirstInterface Action...");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine("MyOtherClass ISecondInterface Action...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            //Foo(myClass);
            //Bar(myClass);
            MyOtherClass myOtherClass = new MyOtherClass();
            //Foo(myOtherClass);
            //Bar(myOtherClass);
            //((IFirstInterface)myOtherClass).Action();// можно и ISecondInterface(небезопасно)
            if(myOtherClass is IFirstInterface firstInterface)//безопасно
            {
                firstInterface.Action();
            }
        }
        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }
        static void Bar (ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
}
