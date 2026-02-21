namespace lesson34
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Random random = new Random();
            int[,,] myArray = new int[4, 3, 5];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int e = 0; e < myArray.GetLength(1); e++)
                {
                    for (int j = 0; j < myArray.GetLength(2); j++)
                    {
                        myArray[i, e, j] = random.Next(100);
                    }
                }
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page №: " + (i + 1));
                for (int e = 0; e < myArray.GetLength(1); e++)
                {
                    for (int j = 0; j < myArray.GetLength(2); j++)
                    {
                        Console.Write(myArray[i, e, j] + " ");
                    }
                    Console.WriteLine();
                    
                }
                Console.WriteLine("==================================");
            }







        }
    }
}
