using lesson55Test;
namespace lesson55
{
    enum Color
    {
        Red,
        Green,
        Orange,
        Yellow,
        Blue
    }
    
    internal class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.firstname = "Мартин";
            student.middlename = "игорьевич";
            student.lastname = "дугин";
            student.age = 19;
            student.id = Guid.NewGuid();
            student.group = "QWERTY_1";
            return student;

        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            string fullName = firstStudent.GetFullName();
            Console.WriteLine(fullName);
            
        }

    }
}
