namespace lesson80
{
    public static class Extensions
    {

        public static void Foo(this ILogger logger)
        {
            Console.WriteLine("Foo");
        }
    }
}