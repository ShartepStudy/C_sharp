using System;
using System.Threading;

class ThreadTest
{
    static void Main() // приоритетный поток
    {
        Thread t = new Thread(WriteY);
//        t.IsBackground = true;
        t.Start();              // Выполнить WriteY в новом потоке
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("x"); // Все время печатать 'x'
            Thread.Sleep(73);
        }
    }

    static void WriteY() // фоновый поток
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("y"); // Все время печатать 'y'
            Thread.Sleep(41);
        }
    }
}