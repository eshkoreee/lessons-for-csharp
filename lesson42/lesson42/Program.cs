
namespace lesson42
{
    /*
     * Оператор условного null ?.
     */
    internal class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            Console.WriteLine("Сумма элементов массива " + (myArray?.Sum()?? 0));
            
        }
    }
}