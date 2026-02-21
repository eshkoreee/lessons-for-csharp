namespace lesson78
{
    public interface IWeapon
    {
        void Fire();
    }

     

    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Пыщ!");
        }
    }

    class LaserGun
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                
        }
    }
}
