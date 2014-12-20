using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_3
{
    interface Shaurmable
    {
        double HowMuchMeat
        {
            get;
        }
    }

    class Cat : Shaurmable
    {
        public double weight = 15;

        public double HowMuchMeat
        {
            get
            {
                return weight * 0.57;
            }
        }
    }

    class Dog : Shaurmable
    {
        public double weight = 45;

        public double HowMuchMeat
        {
            get
            {
                return weight * 0.67;
            }
        }
    }

    class Bird : Shaurmable
    {
        public double weight = 3;

        public double HowMuchMeat
        {
            get
            {
                return weight * 0.86;
            }
        }
    }

    class Program
    {
        static double MakeShaurma(Shaurmable smth)
        {
            return smth.HowMuchMeat;
        }

        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Bird bird = new Bird();

            double kg_meat = MakeShaurma(bird) + MakeShaurma(dog) + MakeShaurma(cat);
            Console.WriteLine(kg_meat);
        }
    }
}
