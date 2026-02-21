using lesson70_2;
    namespace lesson70_3
{

    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address address { get; set; }
    }
    class program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "ранд";
            person1.LastName = "ал тор";

            Address address = new Address();
            address.Country = "Андор";
            address.Region = "Двуречье";
            address.City = "Эмондов луг";



            person1.address = address;
            Person person2 = new Person
            {
                FirstName = "ранд",
                LastName = "ал тор",
                address = new Address
                {
                    Country = "Андор",
                    Region = "Двуречье",
                    City = "Эмондов луг",
                }
                
            };
        }
    }
}
