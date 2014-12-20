using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            Point point = new Point(2, 2);

            // Выполнение явного преобразования Point в Int32.
            Int32 integer = (Int32)point;

            // Выполнение неявного преобразования Point в Double.
            Double floating = point;

            // Выводит: "2".
            Console.WriteLine("point as Int32: {0}", integer);

            // Выводит: "2.8284".
            Console.WriteLine("point as Double: {0:0.0000}", floating);

            // Выполнение неявного преобразования Int32 в Point.
            point = 5;

            // Выводит: "X = 5 Y = 5".
            Console.WriteLine("point: {0}", point);

            // Выполнение явного преобразования Double в Point.
            point = (Point)2.5;

            // Выводит: "X = 2 Y = 2".
            Console.WriteLine("point: {0}", point);
        }
    }
}