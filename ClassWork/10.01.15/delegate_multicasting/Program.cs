using System;

class Program
{
    delegate void Del(int a, int b);

    static void SomeMethod1(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    static void SomeMethod2(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    static void SomeMethod3(int a, int b)
    {
        Console.WriteLine(a * b);
    }
    static void SomeMethod4(int a, int b)
    {
        Console.WriteLine(a / b);
    }
    static void Main()
    {
        Del d = SomeMethod1;
        d += SomeMethod2;
        d += SomeMethod3;
        d += SomeMethod4;
        d -= SomeMethod3;
        d(70, 2);
    }
}