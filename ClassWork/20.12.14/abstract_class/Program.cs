using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    class Program
    {
        abstract class Animal
        {
            protected string name;

            public abstract void Move();
            public virtual void Noize()
            {
                Console.WriteLine("Some noizing.");
            }
        }

        class Dog : Animal
        {
            public override void Move()
            {
                Console.WriteLine("Run, dog, run!");
            }
            public override void Noize()
            {
                Console.WriteLine("Woof-woof-woof!");
            }
            public void Secure()
            {
                Console.WriteLine("The dog is guarding.");
            }
        }


        static void Main(string[] args)
        {
            Animal Rex = new Dog();
            Rex.Move();
            Rex.Noize();
        }
    }
}
