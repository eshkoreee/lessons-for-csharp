using lesson71_2;
using System.Threading.Channels;
namespace lesson71_3
    {
    public class Security : Employee
    {
        public void Guard()
        {
            Console.WriteLine("Я охраняю");
        }
    }
    
    }
