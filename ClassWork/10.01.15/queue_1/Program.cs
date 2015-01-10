using System;
using System.Collections;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        Queue q = new Queue();
        for (int i = 1; i <= 5; i++)
        {
            q.Enqueue(i * 10);
            Console.WriteLine(q.Dequeue());
        }

        Console.WriteLine("-----");
        Console.WriteLine(q.Count);
        Console.WriteLine("-----");

        for (int i = 1; i <= 5; i++)
            q.Enqueue(i * 10);

        Console.WriteLine(q.Peek());
        Console.WriteLine("-----");

        foreach (int i in q)
            Console.WriteLine(i);
    }
}
