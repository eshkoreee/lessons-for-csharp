namespace lesson46
{
    /*
     *  Ключевое слово Params
     */
    
    internal class Program
    {
       
        static int Sum(params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
