using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.IO;

namespace DotNetConsoleApp
{
    class Program
    {
        class Myclass : IComparable
        {

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
        }
        struct WhiteRabbit
        {
            public string Name { get; set; }
            public DateTime Time { get; set; }

            public override string ToString()
            {
                return Name + " " + Time.TimeOfDay.ToString();
            }
        }

        class RabbitComparer : IComparer<WhiteRabbit>
        {
            public int Compare(WhiteRabbit x, WhiteRabbit y)
            {
                int result = 0;

                if (x.Time < y.Time)
                    result = -1;
                if (x.Time > y.Time)
                    result = 1;
                if (x.Time == y.Time)
                    result = 0;

                return result;
            }
        }

        static void Main(string[] args)
        {
            WhiteRabbit[] rabbitsArray = new WhiteRabbit[]
            {
                new WhiteRabbit(){Name="Roger", Time=DateTime.Now},
                new WhiteRabbit(){Name="Buggs", Time = DateTime.Now.AddMinutes(+2)},
                new WhiteRabbit(){Name="Buggs", Time = DateTime.Now.AddMinutes(-2)}
            };

            List<WhiteRabbit> rabbits = new List<WhiteRabbit>();
            rabbits.Add(new WhiteRabbit() { Name = "James", Time = DateTime.Now.AddMinutes(-2) });
            rabbits.AddRange(rabbitsArray);

            rabbits.Sort(new RabbitComparer());
            
            foreach (WhiteRabbit rabbit in rabbits)
            {
                Console.WriteLine(rabbit);
            }

            Array.Sort(rabbitsArray, new RabbitComparer());
            foreach (var rab in rabbitsArray)
            {
                Console.WriteLine(rab);
            }

        }
    }


}