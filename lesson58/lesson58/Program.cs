

namespace lesson58
{
    // Инкапсуляция
    class Gun
    {
        public Gun(bool isloaded)
        {
            _isLoaded = true;
            this._isLoaded = isloaded;
        }
        private bool _isLoaded;
    private void Reload()
        {
            Console.WriteLine("Заряжаю...");
              
            _isLoaded = true;

            Console.WriteLine("Заряжено!");
        }
        public void Shoot()
        {
            if(!_isLoaded)
            {

                Console.WriteLine("Орудие не заряжено");
                Reload();
            }
            Console.WriteLine("Пыщ - Пыщ \n");
            _isLoaded = false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(true);
            gun.Shoot();
            
        }
    }
}
