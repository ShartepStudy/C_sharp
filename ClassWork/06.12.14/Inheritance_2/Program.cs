using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    public class Human
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        protected int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Human()
        {
            Console.WriteLine("Human 1 constructor!");
        }

        public Human(string name, string lastname, int age = 18)
        {
            Console.WriteLine("Human 2 constructor!");
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }

        public void Work()
        {
            // какой-то метод  
        }
    }

    class Employee : Human
    {
        private string profession;
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public Employee()
        {
            Console.WriteLine("Employee 1 constructor!");
        }

        public Employee(string name, string lastname, int age, string profession) : base(name, lastname, age)
        {
            Console.WriteLine("Employee 2 constructor!");
            this.profession = profession;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Human ninja = new Human();
            //Human agent = new Human("James", "Bond", 30);
            //Console.WriteLine(); //////////////////////////
            //Employee worker = new Employee();
            //Console.WriteLine(); //////////////////////////
            Employee George = new Employee("Дядя", "Жора", 42, "мясник");
            Console.WriteLine(); //////////////////////////
            Console.WriteLine(George.Name + " " + George.Lastname + ", " + George.Profession);
        }
    }
}
