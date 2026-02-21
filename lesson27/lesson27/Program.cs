namespace lesson27
    /*
     * как работать с массивами на самом деле
     */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 111, 10, 4, 99, 49, 64, 77, 4, 42, 5 };

            int resunt = myArray.Where(i => i < 70).FirstOrDefault();
        }
    }
}
