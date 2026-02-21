namespace lesson_31._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,]
           {
                {2,45,12,51,51 },
                {6,7,8,3,1 },
                {1,5,65,78,13 },
                {6,3,151,5,65 }

            };
            
            

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y,x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
