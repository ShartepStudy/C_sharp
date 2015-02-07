using System;
using System.IO;

class TestClass
{
    delegate int Sum(int a, int b);

    static void Main()
    {
        Sum sum = (first, second) => first + second;

        Console.WriteLine(sum(10, 15));
    }
}