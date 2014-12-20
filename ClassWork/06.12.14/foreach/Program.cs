using System;
//using Enumerator.

class AlexEnumerator
{
    public int Current
    {
        get;
        private set;
    }

    private int step;

    public bool MoveNext()
    {
        if (step >= 5) return false;
        Current = step++;
        return true;
    }
}

class MyCollection
{
    public AlexEnumerator GetEnumerator()
    {
        return new AlexEnumerator();
    }
}

class Program
{
    static void Main()
    {
        MyCollection collection = new MyCollection();

        foreach (int item in collection)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        ////////////////////////////////////////////////

        for (var tmp = collection.GetEnumerator(); tmp.MoveNext(); )
        {
            int item = tmp.Current;

            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}