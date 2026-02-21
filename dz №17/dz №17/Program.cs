namespace dz__17
{
    internal class Program
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;

            int result = Sum (myArray, i + 1);

            return myArray[i] + result;
        }
        static void Main(string[] args)
        {
            
            int i = 561;
            char[] myArray = i.ToString().ToCharArray();
            int[] intArray = myArray.Select(c => (int)char.GetNumericValue(c)).ToArray();
            int result = Sum(intArray);
            Console.WriteLine(result);


        }
    }
}
