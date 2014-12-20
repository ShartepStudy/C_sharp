using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iclonable
{
    class Monster : ICloneable
    {
        string name;
        int health, ammo;

        public Monster(int health, int ammo, string name)
        {
            this.health = health;
            this.ammo = ammo;
            this.name = name;
        }
        public Monster ShallowClone() // поверхностная копия
        {
            return (Monster)this.MemberwiseClone();
        }

        public object Clone() // пользовательская копия
        {
            return new Monster(this.health, this.ammo, "Клон " + this.name);
        }

        virtual public void Passport()
        {
            Console.WriteLine("Monster {0} \t health = {1} ammo = {2}", name, health, ammo);
        }
    }

    class Program
    {
        static void Main()
        {
            Monster Andrew = new Monster(70, 80, "Андрей");
            Monster X = Andrew;
            Monster Y = Andrew.ShallowClone();
            Monster Z = (Monster)Andrew.Clone();
        }
    }
}
