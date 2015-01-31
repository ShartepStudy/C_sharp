using System;
using System.Threading;
using System.Diagnostics; // Process!

class ThreadTest
{
    static void Main()
    {

        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;

        // От ProcessPriorityClass.High один шаг до наивысшего приоритета процесса – Realtime.
        // Устанавливая приоритет процесса в Realtime, вы говорите операционной системе, что хотите,
        // чтобы ваш процесс никогда не вытеснялся. Если ваша программа случайно попадет в бесконечный цикл,
        // операционная система может быть полностью заблокирована. Спасти вас в этом случае сможет только
        // кнопка выключения питания. По этой причине ProcessPriorityClass.High считается максимальным
        // приоритетом процесса, пригодным к употреблению.

        Thread t = new Thread(new ThreadStart(Go));
        t.IsBackground = false; // основной поток!
        t.Start();

        Thread.Sleep(500);
        Console.WriteLine("main is over!");
    }

    static void Go()
    {
        Thread.Sleep(2500);
        Console.WriteLine("thread is over!");
    }

}