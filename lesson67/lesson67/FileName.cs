using Lesson67_1;
namespace lesson67
{
    public partial class Person
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
