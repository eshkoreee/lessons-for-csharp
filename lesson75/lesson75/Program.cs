using System.Threading.Channels;

namespace lesson75
{
    /*
     * Полиморфизм
     * 
     * виртуальные методы
     * 
     * virtual
     * override
     */
    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("двигатель запущен!");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("я машина, я еду");
        }
    }
    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }
    class SportCar : Car 
    {
        protected override void StartEngine()
        {
            Console.WriteLine("рон дон дон!");
        }
        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("я еду очень быстро!");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Drive(new SportCar());
        }
    }
}
