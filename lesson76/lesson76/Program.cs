namespace lesson76
{
    /*
     *  полиморфизм
     *  
     *  абстрактный класс
     *  
     *  абстрактный метод
     *  
     *  абстрактное свойство
     */
    public interface IHasInfo
    {
        void ShowInfo();
    }

    public interface IWeapon
    {
        void Fire();
    }

  
    public interface IThrowingWeapon : IWeapon
    {
        void Throw();
    }

    abstract class Weapon : IHasInfo, IWeapon
    {
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name}");
        }
    }

    
    class Knife : IThrowingWeapon, IHasInfo
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Хыщ!");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: Вжух!");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name}: Я нож!");
        }
    }

    class LaserGun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Пиу");
        }
    }

    class Bow : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Чпуньк");
        }
    }

    class Gun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Пыщ");
        }
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }

    class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("Йа коробко александрович!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            // Используем IWeapon как тип массива
            IWeapon[] inventory = { new Gun(), new LaserGun(), new Bow(), new Knife() };

            foreach (IWeapon weapon in inventory)  // исправил тип
            {
                // Проверяем, реализует ли объект IHasInfo
                if (weapon is IHasInfo hasInfo)
                {
                    player.CheckInfo(hasInfo);
                }

                player.Fire(weapon);

                // Если это метательное оружие, можно и бросить
                if (weapon is IThrowingWeapon throwingWeapon)
                {
                    throwingWeapon.Throw();
                }

                Console.WriteLine();
            }

            player.CheckInfo(new Box());
        }
    }
}