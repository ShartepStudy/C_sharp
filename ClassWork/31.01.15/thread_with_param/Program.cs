using System;
using System.Threading;

class ThreadWithState
{
    string some_text;
    int some_number;

    public ThreadWithState(string text, int number)
    {
        some_text = text;
        some_number = number;
    }

    public void ThreadProc()
    {
        Thread.Sleep(2000);
        Console.WriteLine(some_text, some_number);
    }
}

public class Example
{
    public static void Main()
    {
        ThreadWithState tws = new ThreadWithState("Ответ на ваш вопрос: {0}.", 42);

        Thread t = new Thread(tws.ThreadProc);
        t.Start();
        Console.WriteLine("Чё-то делаем в мейне, а потом ждём...");
        t.Join();
        Console.WriteLine("Фоновый поток завершился... мейн тоже.");
    }
}