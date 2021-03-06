﻿using System;

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
                foreach (Laptop laptop in shop)
                {
                    Console.WriteLine(laptop.ToString());
                }

                Console.WriteLine();
                Console.WriteLine(shop["LG"]);
                Console.WriteLine();
                Console.WriteLine(shop[4700.0]);

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}