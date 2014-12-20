using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{    
    class A
    {
        protected int a;
        protected int b;
        protected int c;
        public A()
        {
            Console.WriteLine("A constructor");
        }
    }
    class B : A
    {
        protected int d;
        public B()
        {
            Console.WriteLine("B constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A test1 = new A();
            B test2 = new B();
        }
    }
}
