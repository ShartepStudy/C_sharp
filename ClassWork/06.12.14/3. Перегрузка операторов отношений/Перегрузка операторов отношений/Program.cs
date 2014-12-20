using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 0);
            Point point3 = new Point(1, 1);

            // Выводит: "True".
            Console.WriteLine("point1 == point2: {0}", point1 == point2);

            // Выводит: "False".
            Console.WriteLine("point1 == point3: {0}", point1 == point3);
        }
    }
}