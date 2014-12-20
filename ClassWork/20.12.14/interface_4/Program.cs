using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface Evil
    {
        void ToptatTsvets();
        void LomatSvetofor();
        void PugatDetej();
        void CreateCriminals();
    }

    interface Good
    {
        void PolivatTsvets();
        void PerevodBabushek();
        void KormitDetej();
        void LovitPrestupnikov();
        void SpasatLudej();
    }

    abstract class SuperHero
    {
        public string name;

        public SuperHero(string name)
        {
            Console.WriteLine(name + " was created!\n");
            this.name = name;
        }

        public void SayHello()
        {
            Console.WriteLine("Hi! I am " + name);
        }

        // public abstract void WearCostume();
    }

    class BatMan : SuperHero, Good
    {
        public BatMan(string name)
            : base(name)
        {

        }

        public void PolivatTsvets()
        {
            Console.WriteLine(name + " polivaet tulips!\n");
        }

        public void PerevodBabushek()
        {
            Console.WriteLine(name + " play with GRANDMA'S!\n");
        }
        public void KormitDetej()
        {
            Console.WriteLine(name + " segodnya prigotovil GRECHKUUU!!!!11\n");
        }
        public void LovitPrestupnikov()
        {

        }
        public void SpasatLudej()
        {

        }
    }

    class SuperMan : SuperHero, Good
    {
        public SuperMan(string name)
            : base(name)
        {

        }

        public void PolivatTsvets()
        {
            Console.WriteLine(name + " polivaet rozochki!\n");
        }

        public void PerevodBabushek()
        {
            Console.WriteLine(name + " sing songs to GRANDMA'S!\n");
        }
        public void KormitDetej()
        {
            Console.WriteLine(name + " segodnya prigotovil MANKUUU!!!!11\n");
        }
        public void LovitPrestupnikov()
        {

        }
        public void SpasatLudej()
        {

        }
    }

    class CatWoman : SuperHero
    {
        public CatWoman(string name)
            : base(name)
        {

        }
    }

    class Rosomaha : SuperHero
    {
        public Rosomaha(string name)
            : base(name)
        {

        }
    }

    class Hulk : SuperHero
    {
        public Hulk(string name)
            : base(name)
        {

        }
    }

    class Loki : SuperHero, Evil
    {
        public Loki(string name)
            : base(name)
        {

        }


    }

    class Thor : SuperHero
    {
        public Thor(string name)
            : base(name)
        {

        }
    }

    class Program
    {

        static void WorkInSanatorij(Good man)
        {
            man.KormitDetej();
            man.PolivatTsvets();
            man.PerevodBabushek();
        }

        static void Main(string[] args)
        {
            //BatMan b = new BatMan("Ivan");
            //SuperMan s = new SuperMan("Semen");
            //CatWoman c = new CatWoman("Olga");
            //Loki l = new Loki("Petr");

            //SuperHero b = new BatMan("Ivan");
            //SuperHero s = new SuperMan("Semen");
            //SuperHero c = new CatWoman("Olga");
            //SuperHero l = new Loki("Petr");

            SuperHero[] mass = new SuperHero[10];

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int r = rand.Next(1, 4);
                if (r == 1) mass[i] = new SuperMan("Alex");
                if (r == 2) mass[i] = new BatMan("Serezha");
                if (r == 3) mass[i] = new CatWoman("Ira");
                if (r == 4) mass[i] = new Thor("Igor");
            }

            BatMan batman = new BatMan("Fedya");
            // batman.PolivatTsvets();

            SuperMan sm = new SuperMan("Vitya Yanukovich");
            WorkInSanatorij(sm);


        }

    }
}
