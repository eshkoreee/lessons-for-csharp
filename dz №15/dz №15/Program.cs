



namespace dz__15
{
    internal class Program
    {
        static int i = 0;
        static void MyArray(int[] myArray)
        {
           
            if (i < myArray.Length)
            {

                Console.WriteLine(myArray[i]);
                i++;
                MyArray(myArray);
            }
           return;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 32, 5 };
            MyArray(myArray);
            
        }
    }
}
