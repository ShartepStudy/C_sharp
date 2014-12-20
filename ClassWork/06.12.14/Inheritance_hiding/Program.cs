using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_hiding
{
    class Human
    {
        public virtual void Work()
        {
            Console.WriteLine("Human Work!");
        }
    }

    class Employee : Human
    {
        public override void Work()
        {
            Console.WriteLine("Employee Work!");
            //base.Work();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human ninja = new Human();
            ninja.Work();

            Employee worker = new Employee();
            worker.Work();

            Human h = new Employee();
            h.Work();
        }
    }
}
