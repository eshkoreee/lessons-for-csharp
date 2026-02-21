namespace dz__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            for (int i = 0; i < myArray.Length; i++)
            {
                int a = int.Parse(Console.ReadLine());
                myArray[i] = a;
            }
            Console.Clear();
            Console.WriteLine("ваш массив содержит цифры");
            for (int i = 0; i < myArray.Length; i++)
            {
                
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
