using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(10, 10);
            Point point2 = new Point(12, 20);
            Vector vector = new Vector(10, 20);

            Console.WriteLine("Point point1: {0}", point1);
            Console.WriteLine("Shift: {0}", point1 + vector);
            Console.WriteLine("Scaling: {0}", point1 * 10);
            Console.WriteLine("Point point2: {0}", point2);
            Console.WriteLine("Distance: {0}", point2 - point1);
            Console.WriteLine("Shift: {0}", point1 + vector);

            Console.WriteLine(10 * point1);
        }
    }
}