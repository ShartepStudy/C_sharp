using System;
using System.Collections;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        // Represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index.

        SortedList sl = new SortedList();
        Console.WriteLine(sl.Capacity);

        sl.Add("Александр", 1989);
        Console.WriteLine(sl.Capacity);

        sl.Add("Анастасия", 1990);
        sl.Add("Каллистрат", 1895);
        sl.Add("Пульхерия", 1912);
        sl.Add("Спиридон", 1943);
        sl.Add("Прасковья", 1953);

        Console.WriteLine("--------------");

        foreach (string name in sl.GetKeyList())
            Console.WriteLine(name);

        Console.WriteLine("--------------");

        foreach (int age in sl.GetValueList())
            Console.WriteLine(age);

        Console.WriteLine("--------------");

        for (int i = 0; i < sl.Count; i++)
            Console.WriteLine(sl.GetKey(i) + " " + sl.GetByIndex(i));

        Console.WriteLine("--------------");

        //for (int i = 0; i < sl.Count; i++)
        //    sl.RemoveAt(i);

        sl.Clear();
        
        Console.WriteLine("----remAll--------");

        sl.Add(35453, "ksjdfhkjsah");

        for (int i = 0; i < sl.Count; i++)
            Console.WriteLine(sl.GetKey(i) + " " + sl.GetByIndex(i));

    }
}