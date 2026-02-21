using lesson66_2;

namespace lesson66_1_extensions
{
    static class MyExtensions
    {
        public static string GetFullName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}
