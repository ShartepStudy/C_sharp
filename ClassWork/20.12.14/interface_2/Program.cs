using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2
{

    public interface IOpenable
    {
        void Open();
    }

    class Key : IOpenable
    {
        public void Open()
        {
            Console.WriteLine("open the door by the key!");
        }
    }

    class RightLeg : IOpenable
    {
        public void Open()
        {
            Console.WriteLine("open the door by the right leg!");
        }
    }

    class AxeEffect : IOpenable
    {
        public void Open()
        {
            Console.WriteLine("open the door by the axe!");
        }
    }

    class MagneticCard : IOpenable
    {
        public void Open()
        {
            Console.WriteLine("open the door by the pass card!");
        }
    }

    class Program
    {
        static void OpenTheDoorByThe(IOpenable way)
        {
            way.Open();
        }

        static void Main(string[] args)
        {
            Key key = new Key();
            RightLeg leg = new RightLeg();
            AxeEffect axe = new AxeEffect();
            MagneticCard card = new MagneticCard();

            OpenTheDoorByThe(key);
            OpenTheDoorByThe(leg);
            OpenTheDoorByThe(axe);
            OpenTheDoorByThe(card);

        }
    }
}
