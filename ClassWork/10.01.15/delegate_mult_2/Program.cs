using System;

class Program
{
    delegate int Del(int a, int b);

    static int SomeMethod1(int a, int b)
    {
        return 1;
    }
    static int SomeMethod2(int a, int b)
    {
        return 2;
    }
    static int SomeMethod3(int a, int b)
    {
        return 3;
    }

    static void Main()
    {
        Del d = SomeMethod1;

        d += SomeMethod1;
        d += SomeMethod2;
        d += SomeMethod3;

        int res = d(70, 2);

        Console.WriteLine(res);
    }
}