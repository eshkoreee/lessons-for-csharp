namespace lesson31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray =
            {
                {2,45,12,51,51 },
                {6,7,8,3,1 },
                {1,5,65,78,13 },
                {6,3,151,5,65 }

            };
            foreach (var i in myArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
