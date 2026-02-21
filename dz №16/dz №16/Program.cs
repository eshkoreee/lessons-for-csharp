namespace dz__15
{
    internal class Program
    {

        static int Sum(int[] myArray, int Index = 0)
        {
            
            if (Index < myArray.Length)
            {
                i += myArray[o];
                Index++;
                Sum(myArray);
            }
            return i;
            
        }
       static void Main(string[] args)
       {
            int[] myArray = { 1, 3, 8, 77, 5 };
            int o = 0;
            int i = 0;

            int c = Sum(myArray);

            Console.WriteLine("сумма чисел массива равно " + i);
       }
    }
}
