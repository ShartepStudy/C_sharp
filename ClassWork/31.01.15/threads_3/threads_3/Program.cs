using System;
using System.Threading;

public class ThreadWithState
{
    string m_text;
    int m_number;

    ExampleCallback m_callback;

    public ThreadWithState(string text, int number, ExampleCallback callback)
    {
        m_text = text;
        m_number = number;
        m_callback = callback;
    }

    public void ThreadProc()
    {
        Console.WriteLine(m_text);
        if (m_callback != null) m_callback(m_number * 2);
    }
}

public delegate void ExampleCallback(int some);

public class Example
{
    static void ResultCallback(int data)
    {
        Console.WriteLine("Из фонового потока пришло число {0}", data);
    }

    static void Main()
    {
        ThreadWithState tws = new ThreadWithState("Запускается фоновый поток...", 25, ResultCallback);

        Thread t = new Thread(new ThreadStart(tws.ThreadProc));
        t.Start();
        Console.WriteLine("Снова чёт происходит в мейне...");
        t.Join();
        Console.WriteLine("Мейн закончился!");
    }
}