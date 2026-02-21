using lesson71;
    namespace lesson71_1
{
    public class Person
    {
        public int a;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        static void PrintFullName(Person person)
        {
            Console.WriteLine($"Фамилия: {person.LastName}\t Имя: {person.FirstName}");
        }
    }
}
