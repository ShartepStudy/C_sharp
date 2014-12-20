using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_1
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

    class Teacher : Human
    {
        public override void Work()
        {
            Console.WriteLine("Teacher Work!");
        }
    }

    class Policeman : Human
    {
        public override void Work()
        {
            Console.WriteLine("Policeman Work!");
        }
    }

    class Doctor : Human
    {
        public override void Work()
        {
            Console.WriteLine("Doctor Work!");
        }
    }

 
    class HumanList : IEnumerator
    {
        private Human[] arr = null;
        public HumanList(int size)
        {
            arr = new Human[size];

            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int choice = r.Next(4);
                switch (choice)
                {
                    case 0: arr[i] = new Teacher(); break;
                    case 1: arr[i] = new Doctor(); break;
                    case 2: arr[i] = new Policeman(); break;
                    case 3: arr[i] = new Employee(); break;
                }
            }
        }
        public int Length
        {
            get { return arr.Length; }
        }
        public Human this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        int index = 0;
        public bool MoveNext()
        {
            if (++index >= Length) return false;
            return true;
        }
        public void Reset()
        {
            index = 0;
        }
        public object Current
        {
            get { return this[index]; }
            set { this[index] = (Human)value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Human h = new Employee();
            //h.Work();

            HumanList cr = new HumanList(30);

            foreach (Human it in cr)
                it.Work();
//                it = new Doctor();


        }
    }
}
