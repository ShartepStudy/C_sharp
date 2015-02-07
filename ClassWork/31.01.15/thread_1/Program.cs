using System;
using System.Threading;

class ThreadTest
{
    static void Main()
    {
        new Thread(Go).Start();      // Выполнить Go() в фоновом потоке
        Go();                        // Выполнить Go() в главном потоке
    }

    static void Go()
    {
        for (int cycles = 0; cycles < 5; cycles++)
            Console.Write("@ ");
    }
}
