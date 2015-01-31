using System;
using System.Threading;

class ThreadTest
{
    static void Main()
    {
        Thread t = new Thread(new ThreadStart(Go));
        t.Start();   // Выполнить Go() в новом потоке.
        Go();        // Одновременно запустить Go() в главном потоке.
        Thread x = new Thread(Go);
        Thread y = new Thread(delegate() { Console.WriteLine("hello!"); });

        // кстати, поток, который закончил исполнение, не может быть начат заново.

        /////////////////////////////////////////////////////////////////////////////

        Thread z = new Thread(Func);
        //Thread z = new Thread(new ParameterizedThreadStart(Func));
        z.Start(true); // == Func(true) ... попробуй t.Start(true); :)
        Func(false);

        ///////////////////////////////////////////////////////////////////////////
        ParameterizedThreadStart del = new ParameterizedThreadStart(WriteText);
        del += Goo;
        Thread b = new Thread(WriteText);
        b.Start("Alex!!!");

        string text = "Before!";
        Thread a = new Thread(delegate() { WriteText(text); });
        //text = "After!";
        a.Start();
    }

    static void Go()
    {
        Console.WriteLine("hello!");
    }

    static void Func(object upperCase)
    {
        bool upper = (bool)upperCase;
        Console.WriteLine(upper ? "FUNC!" : "func!");
    }

    static void WriteText(string text)
    {
        Console.WriteLine(text);
    }
    static void WriteText(object text)
    {
        Console.WriteLine(text);
    }

    static void Goo(object o)
    {
        Console.WriteLine("hello!");
    }

}
