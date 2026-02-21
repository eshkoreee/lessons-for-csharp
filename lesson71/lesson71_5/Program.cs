using lesson71_4;
using lesson71;
namespace lesson71_5
{
     class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher { FirstName = "Мартин", LastName = "Дугин" };
            Student student = new Student { FirstName = "Кей", LastName = "Альтос" };
            
            Person[] people = {  student , teacher};
            PrintPersons(people)
        }

        static void PrintPersons(Person[] people)
        {
            foreach (var Person in people)
            {
                Person.PrintFullName();
            }
        }
    }
}
