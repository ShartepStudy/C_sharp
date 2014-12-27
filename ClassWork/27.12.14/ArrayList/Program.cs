using System;
using System.Collections;

public class Tester
{
    public static void Main()
    {
        /* любой набор данных или объектов можно назвать коллекцией.
 массив - это тоже коллекция, но её размер нельзя изменить при необходимости.

 каждый объект в коллекции называется элементом.
 бывают коллекции, которые хранят элементы как простой список значений.
 к ним относится класс ArrayList, Queue, Stack.
 а некоторые хранят данные как список пар "ключ-значение". их ещё называют словарями.
 примером такой коллекции является класс HashTable. */

        //ArrayList.

        ArrayList arr = new ArrayList();
        arr.Add("1");
        Console.WriteLine(arr.Capacity);

        arr.Add("2");
        arr.Add("3");
        arr.Add(4);
        arr.Add(5);
        Console.WriteLine(arr.Capacity);

        arr.AddRange(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine(arr.Capacity);
        Console.WriteLine(arr.Count);

        arr.TrimToSize();
        
        Console.WriteLine(arr.Capacity);

        int a = Convert.ToInt32(arr[0]);
        Console.WriteLine(a);
        Console.WriteLine(arr[5]);
        Console.WriteLine();
        Console.WriteLine();

        foreach(string el in arr)
        {
            Console.WriteLine(el);
        }
    }
}