using System;
using System.IO;

class TestClass
{
    delegate int Fibo(int step);

    static void Main()
    {
        Fibo fib = null;
        fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;
        for (int i = 0; ; i++)
            Console.WriteLine(i + " = " + fib(i) + ", ");
    }
}