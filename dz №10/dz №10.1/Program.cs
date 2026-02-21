namespace dz__10._1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("введите какое число хотите найти");
            int c = int.Parse(Console.ReadLine());
            int d = -1;

            int[] myArray = { 1, 2, 3, 4, 5 };

            d = Indeks(myArray,c,d);

            if (d == -1)
            {
                Console.WriteLine("число не найдено!");
            }
            else
            {
                Console.WriteLine("число " + d + " было найдено");

            }

        }
        static int Indeks(int[] myArray,int c,int b)
        {                     
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == c)
                {
                    b = myArray[i];
                }
            }
            return b;
        }
    }
}
