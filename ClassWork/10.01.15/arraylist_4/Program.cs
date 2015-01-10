using System;
using System.Collections;

namespace ArraList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();

            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            DisplayAL(myAL);

            //т.к. ArrayList хранит ссылки на Object, 
            //то в одной коллекции можно хранить элементы разных типов
            myAL.Add(1);
            myAL.Add(2);
            myAL.Add(3);

            DisplayAL(myAL);

            //добавление элементов из другой коллекции
            float[] arr = { 2.3f, 6.3f, 7.1f, 6.2f, 3.4f };
            myAL.AddRange(arr);

            DisplayAL(myAL);

            //Удаление всех элементов из коллекции
            myAL.Clear();

            DisplayAL(myAL);

            //вставка по указанному индексу
            myAL.Insert(0, "The");
            myAL.Insert(1, "fox");
            myAL.Insert(2, "jumps");
            myAL.Insert(3, "over");
            myAL.Insert(4, "the");
            myAL.Insert(5, "dog");

            DisplayAL(myAL);

            //удаление диапазона значений
            myAL.RemoveRange(2, 4);

            DisplayAL(myAL);

            //изменение порядка на обратный
            myAL.Reverse();

            DisplayAL(myAL);

            //Задает значение емкости, равное действительному количеству элементов
            myAL.TrimToSize();

            DisplayAL(myAL);

            //сортировка
            string[] strings = { "cat", "dog", "bird", "pig", "tiger", "lion" };
            myAL.AddRange(strings);
            myAL.Sort();

            DisplayAL(myAL);

            myAL.Sort(new ComparerBySize());

            DisplayAL(myAL);


        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }

        // Displays the properties and values of the ArrayList.
        public static void DisplayAL(ArrayList myAL)
        {
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");
            PrintValues(myAL);
        }

        class ComparerBySize : IComparer
        {
            public int Compare(Object x, Object y)
            {
                string str1 = (string)x;
                string str2 = (string)y;

                return str1.Length.CompareTo(str2.Length);
            }
        }
    }

}