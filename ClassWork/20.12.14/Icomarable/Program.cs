using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icomarable
{
    class Monster : IComparable
    {
        string name;
        int health;
        int ammo;

        public Monster(int health, int ammo, string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }

        virtual public void Passport()
        {
            Console.WriteLine("Monster {0} \t health = {1} ammo = {2}", name, health, ammo);
        }

        public int CompareTo(object obj) // реализация интерфейса
        {
            Monster temp = obj as Monster;
            //if (this.ammo > temp.ammo) return 1;
            //if (this.ammo < temp.ammo) return -1;
            //return 0;
            return name.CompareTo(temp.name);
        }

    }

    class Program
    {
        static void Main()
        {
            Monster[] crowd = new Monster[3];

            crowd[0] = new Monster(50, 50, "Кристина");
            crowd[1] = new Monster(80, 80, "Александр");
            crowd[2] = new Monster(40, 10, "Евгений");

            Array.Sort(crowd); // сортировка стала возможной

            foreach (Monster elem in crowd) elem.Passport();
        }
    }
}
