using System;

class AlexEnumerator
{
    public int Current
    {
        get;
        private set;
    }

    private int step;
    private int[] m;

    public AlexEnumerator(int[] arr)
    {
        m = arr;
    }

    public bool MoveNext()
    {
        if (step >= m.Length) return false;
        Current = m[step++];
        return true;
    }
}

class MyCollection
{
    int[] arr;

    public MyCollection(int size)
    {
        Random r = new Random();
        arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = r.Next();
        }
    }

    public AlexEnumerator GetEnumerator()
    {
        return new AlexEnumerator(arr);
    }
}

class Program
{
    static void Main()
    {
        MyCollection collection = new MyCollection(10);

        foreach (int item in collection)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        ////////////////////////////////////////////////

        for (AlexEnumerator tmp = collection.GetEnumerator(); tmp.MoveNext(); )
        {
            int item = tmp.Current;

            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}