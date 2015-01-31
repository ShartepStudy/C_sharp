using System;
using System.Threading;

class ThreadTest
{
    static int x = 0;    // Статическое поле, разделяемое потоками

    static void Main()
    {
        new Thread(F1).Start();
        new Thread(F2).Start();
        Thread.Sleep(3000);
        Console.WriteLine(x);
    }

    static void F1()
    {
        for (int i = 0; i < 1000000; i++) x++;
    }

    static void F2()
    {
        for (int i = 0; i < 1000000; i++) x--;
    }
}