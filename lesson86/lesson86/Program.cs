namespace lesson86
{
    public class Student
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var student in GetStudentByYield())
            {
                Console.WriteLine(student.Name);
            }
        }

        private static IEnumerable<Student> GetStudentByYield()
        {
            yield return new Student { Name = "Max" };
            yield return new Student { Name = "James" };
            yield return new Student { Name = "Olivia" };
        }
        
}   }
