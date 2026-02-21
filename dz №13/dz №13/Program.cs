namespace dz__13
{
    internal class Program
    {
        static int a = 0;
        static void Insert(ref int[] myArray, ref int Index, ref int value)
        {
            int[] newArray = new int[myArray.Length + 1];
            newArray[Index] = value;

            for (int i = 0; i < Index; i++)
                newArray[i] = myArray[i];

            for (int i = Index; i < myArray.Length; i++)
                newArray[i + 1] = myArray[i];

            myArray = newArray;
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }
        static void AddFirst(ref int[] array, ref int Index, int value)
        {
            Insert(ref array, ref Index, ref value);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5 };

            Console.Write("введите индекс: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("введите цифру: ");
            int value = int.Parse(Console.ReadLine());
            //Insert(ref myArray,ref index,ref value);
            AddFirst(ref myArray, ref a, -5);
        }
    }
}
