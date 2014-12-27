using System;
using System.Collections;
using System.Collections.Generic;

namespace Interfaces
{
    class Monster
    {
        string name;
        int health, ammo;

        public Monster(int health, int ammo, string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }

        public int Ammo
        {
            get { return ammo; }
            set
            {
                if (value > 0) ammo = value;
                else ammo = 0;
            }
        }

        public string Name
        {
            get { return name; }
        }

        virtual public void Passport()
        {
            Console.WriteLine("Monster {0} \t health = {1} ammo = {2}", name, health, ammo);
        }

        public class SortByName : IComparer<Monster>
        {
            //int IComparer.Compare(object ob1, object ob2)
            //{
            //    Monster m1 = (Monster)ob1;
            //    Monster m2 = (Monster)ob2;
            //    return String.Compare(m1.Name, m2.Name);
            //}
            //public int Compare(Monster x, Monster y)
            //{
            //    throw new NotImplementedException();
            //}
            int IComparer<Monster>.Compare(Monster x, Monster y)
            {
                return String.Compare(x.Name, x.Name);
            }
        }

        public class SortByAmmo : IComparer<Monster>
        {
            //int IComparer.Compare(object ob1, object ob2)
            //{
            //    Monster m1 = (Monster)ob1;
            //    Monster m2 = (Monster)ob2;
            //    if (m1.Ammo > m2.Ammo) return 1;
            //    if (m1.Ammo < m2.Ammo) return -1;
            //    return 0;
            //}
            int IComparer<Monster>.Compare(Monster x, Monster y)
            {
                if (x.Ammo > y.Ammo) return 1;
                if (x.Ammo < y.Ammo) return -1;
                return 0;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Monster[] crowd = new Monster[3];

            crowd[0] = new Monster(50, 50, "Иван");
            crowd[1] = new Monster(80, 80, "Пётр");
            crowd[2] = new Monster(40, 10, "Света");

            Console.WriteLine("Сортировка по имени:");
            Array.Sort(crowd, new Monster.SortByName());
            foreach (Monster elem in crowd) elem.Passport();

            Console.WriteLine("\n\nСортировка по вооружению:");
            Array.Sort(crowd, new Monster.SortByAmmo());
            foreach (Monster elem in crowd) elem.Passport();
        }
    }
}