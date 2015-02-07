using System;
using System.Threading;

class ThreadTest
{
    static int x = 0;    // Статическое поле, разделяемое потоками
    static object locker = new object();
    static void Main()
    {
        new Thread(F1).Start();
        new Thread(F2).Start();
        Thread.Sleep(80);
        Console.WriteLine(x);
    }

    static void F1()
    {
        for (int i = 0; i < 1000000; i++)
            lock (locker) // эксклюзивная блокировка на время чтения и записи разделяемых полей!
                x++;
    }

    static void F2()
    {
        for (int i = 0; i < 1000000; i++)
            lock (locker)
                 x--;
    }
}

/*
Monitor.Enter(locker);
try 
{
  ...
}

finally { Monitor.Exit(locker); }  
*/