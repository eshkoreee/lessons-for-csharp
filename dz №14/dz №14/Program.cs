namespace dz__14
{
    internal class Program
    {
        static void Resize(ref int[] myArray, ref int size)
        {
            for (int i = 0; i < myArray.Length; i++)
            {

                if (i == size - 1)
                { continue; }
                else {
                    Console.WriteLine(myArray[i]);
                }
            }
        }
       
        static void Main(string[] args)
        {
            int[] myArray = { 1, 3, 5, 7, 9, 11};
            Console.Write("введите какой элемент хоитите удалить ");
            int Index = int.Parse(Console.ReadLine());
            Resize(ref myArray, ref Index);
        }
    }
}
