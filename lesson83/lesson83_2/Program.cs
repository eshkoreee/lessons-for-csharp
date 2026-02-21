using System.Runtime.CompilerServices;

namespace lesson83_2
{
    public class MyList<T>
    {
        private T[] _Array = Array.Empty<T>();

        public T this[int index]
        {
            get
            {
                return _Array[index]; 
            }
            set
            {
                _Array[index] = value; 
            }
        }

    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            
        }
    }
}
