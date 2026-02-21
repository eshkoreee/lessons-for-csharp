namespace dz__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6];
            
            for (int i = 0; i < myArray.Length; i++)
            {
                int a = int.Parse(Console.ReadLine());
                myArray[i] = a;
            }
            Console.Clear();
            Console.WriteLine("в обратном порядке будет");
            for (int a = myArray.Length - 1; a != -1; a--)
            {
                Console.WriteLine(myArray[a]);
            }
            Console.WriteLine();
            int w = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
               
                if (myArray[i] % 2 == 0)
                {
                    w += myArray[i];
                }
              
            }
            Console.WriteLine("если сложить четные числа в массиве получится " + w);
            Console.WriteLine();
            int minValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                { 
                minValue = myArray[i];
                }
            }
            Console.WriteLine("наименьшее число будет " + minValue);

        }
    }
}
