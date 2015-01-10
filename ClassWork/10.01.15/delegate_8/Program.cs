using System;

class Program
{
    delegate int Del(int a, int b);

    static int SomeMethod1(int a, int b)
    {
        Console.Write("1");
        return 1;
    }
    static int SomeMethod2(int a, int b)
    {
        Console.Write("2");
        return 2;
    }
    static int SomeMethod3(int a, int b)
    {
        Console.WriteLine("3");
        return 3;
    }

    static void Main()
    {
        Del d = null;

        for (int i = 0; i < 100; i++)
        {
            d += SomeMethod1;
            d += SomeMethod2;
            d += SomeMethod3;
        }

        d(1, 2);
    }
}