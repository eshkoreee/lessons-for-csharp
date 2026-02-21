namespace lesson70
{
    /*
     * синтаксис инициализации объектов
     */
    class Cat
    {
        public int age {  get; set; }
        public string name { get; set; }
        public Cat()
        {

        }
        public Cat(string name )
        {
            this.name = name;
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            //cat1.age = 3;
            //cat1.name = "барсик";

            Cat cat2 = new Cat();
            
        }
    }
}
