using System;
using System.IO;

/* Лямбда-выражение — это анонимная функция, которую можно использовать для создания таких типов как делегаты.
 * С помощью лямбда-выражений можно написать локальные функции, которые затем можно передавать в другие функции
 * в качестве аргументов или возвращать из них в качестве значения */

// Блочные лямбда-выражения:

class TestClass
{
    delegate int Pow(int chis, int step);

    static void Main()
    {
        Pow result = (chis, step) =>
        {
            int res = 0;
            if (step == 0) res = 1;
            else
            {
                int ans = 1;
                for (int i = 0; i < step; i++)
                {
                    ans *= chis;
                }
                res = ans;
            }
            return res;
        };

        Console.WriteLine(result(2, 5));
    }
}