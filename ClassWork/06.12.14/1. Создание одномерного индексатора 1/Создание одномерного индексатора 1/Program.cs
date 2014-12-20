using System;

namespace Indexers
{
    class Program
    {
        public static void Main()
        {
            Shop shop = new Shop(3);
            shop[0] = new Laptop("Samsung", 5200);
            shop[1] = new Laptop("Asus", 4700);
            shop[2] = new Laptop("LG", 4300);

            try
            {
                for (Int32 i = 0; i < shop.Length; i++)
                {
                    Console.WriteLine(shop[i].ToString());
                }
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}