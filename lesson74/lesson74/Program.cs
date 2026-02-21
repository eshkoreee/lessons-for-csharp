namespace lesson74
{
    /*
     * модификатор доступа protected при наследовании
     */
    class A
    {
        public A()
        {
            Console.WriteLine(publicFiled);
            Console.WriteLine(privateFiled);//в конструкторах и методах внутри класса можно использовать все поля
            Console.WriteLine(protectedFiled);
        }
          

        
        

        
        public int publicFiled;

        private int privateFiled;

        protected int protectedFiled;
    }
    class B : A  
    {  
        public B()
        {
            Console.WriteLine(publicFiled);
           // Console.WriteLine(privateFiled); в наследнике поле есть, но таким способом использовать мы его не можем
            Console.WriteLine(protectedFiled);// доступно только в базовом классе и его наследниках
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.publicFiled = 1;//на уровне экземпляра класса доступен только public поле
        }
    }
}
