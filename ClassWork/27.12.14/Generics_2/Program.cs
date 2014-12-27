using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace DotNetConsoleApp
{
    abstract class RadioactiveMaterial
    {
        public int RadioactivePower { get; set; }
    }

    class Uranium : RadioactiveMaterial
    {
        public override string ToString()
        {
            return "Some uranium";
        }
    }

    class Cat
    {
        public override string ToString()
        {
            return "some Cat";
        }
    }
    class Orange_Cat : RadioactiveMaterial
    {
        public override string ToString()
        {
            return "some Cat";
        }
    }

    class Box<T>
    {
        protected T innerObject;

        public Box()
        {

        }
        public Box(T innerObject)
        {
            this.innerObject = innerObject;
        }

        public T InnerObject
        {
            get { return innerObject; }
            set { innerObject = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine(innerObject.ToString() + " in the box.");
        }

        public override string ToString()
        {
            return "The box with " + innerObject + " inside";
        }
    }

    class RadioactiveBox<T> : Box<T>
    where T : RadioactiveMaterial
    {
        public RadioactiveBox(T innerMaterial) : base(innerMaterial)
        {}
        public override string ToString()
        {
            return "The radioactive box with " + innerObject + " with RP of " + InnerObject.RadioactivePower + " inside";
        }
    }

    class FourthReactor : Box<Uranium>
    {
        public FourthReactor()
        {
            this.InnerObject = null;
        }
        public FourthReactor(Uranium uran)
        {
            this.InnerObject = uran;
        }

        public override string ToString()
        {
            return base.ToString() + " But this is the reactor.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box<Uranium> b = new Box<Uranium>(new Uranium() { RadioactivePower = 8999 });
            Console.WriteLine(b);

            Box<Box<Uranium>> b2 = new Box<Box<Uranium>>(new Box<Uranium>(new Uranium()));
            Console.WriteLine(b2);

            FourthReactor reactor = new FourthReactor(new Uranium());
            Console.WriteLine(reactor);
            
            Box<Cat> b3 = new Box<Cat>(new Cat());
            Console.WriteLine(b3);

            RadioactiveBox<Orange_Cat> b4 = new RadioactiveBox<Orange_Cat>(new Orange_Cat() { RadioactivePower = 500 });
            Console.WriteLine(b4);

        }
    }
}