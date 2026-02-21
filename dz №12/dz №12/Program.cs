namespace dz__12
{
    internal class Program
    {
        
        static void Action(string action, ref int[] myArray)
        {
            switch (action)
            {
                case "+":
                    myArray = new int[myArray.Length + 1];
                    break;

                case "-":
                    myArray = new int[myArray.Length - 1];
                    break;

                    default:
                    Console.WriteLine("вы ввели неизвестное действие или символ");
                    break;


            }  
        }
             
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
           
            while (true)
            {

                Console.WriteLine("введите что бы хотите сделать с размером массива");

                Console.WriteLine();

                Console.WriteLine("\t\t\t+ or -");
                string action = Console.ReadLine();
                Action(action, ref myArray);
                Console.WriteLine("теперь размер массива равен " + myArray.Length);
                Console.ReadLine();
                
            }
        }
    }
}
