namespace lesson71
{
    /*
     * наследование в ооп
     */
    public class Person
    {
        public int a;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"Меня зовут {FirstName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { FirstName = "Кей", LastName = "Альтос"};
            student.Learn();
            
            PrintFullName(student);

        }
        static void PrintFullName(Person person)
        {
            Console.WriteLine($"Фамилия: {person.LastName}\t Имя: {person.FirstName}");
        }
    }
    public class Student : Person
    {
        public void  Learn()
        {
            Console.WriteLine("Я учусь!");
        }
    }
}
