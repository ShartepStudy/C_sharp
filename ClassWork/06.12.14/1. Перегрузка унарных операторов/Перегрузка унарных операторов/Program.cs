using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(10, 10);

            //префиксная и постфиксная формы выполняются одинаково

            // Выводит: "X = 11 Y = 11".
            Console.WriteLine(++point1);

            Point point2 = new Point(10, 10);

            // Выводит: "X = 11 Y = 11".
            Console.WriteLine(point2++);

            // Выводит: "X = 10 Y = 10".
            Console.WriteLine(--point1);

            // Выводит: "X = -10 Y = -10".
            Console.WriteLine(-point1);

            // После выполнения оператора "-", состояние исходного объекта не изменилось.
            // Выводит: "X = 10 Y = 10".
            Console.WriteLine(point1);
        }
    }
}