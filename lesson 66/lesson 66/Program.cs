using lesson66_2;
using lesson66_1_extensions;
namespace lesson_66
{

    /*
     * Extension методы (метод расширения) (расширяющие методы)
     */
   
    internal class Program
    {          
        static void Main(string[] args)
        {
            Student student = new Student() { FirstName = "Мартин", LastName = "Дугин"};

            string fullName = student.GetFullName();
        }
    }
}
