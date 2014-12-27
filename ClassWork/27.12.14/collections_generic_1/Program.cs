using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCallection
{
    class Program
    {
        // Пример использования обобщенного списка
        static void ListExample()
        {
            //Коллекция для хранения целых чисел
            List<int> li = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                li.Add(rnd.Next(100));
            Console.WriteLine("Int collection: ");
            //при обращении к элементам коллекции возвращается резульnат типа int
            foreach (int i in li) Console.Write("{0} ", i);
            Console.WriteLine();
            Console.WriteLine("String collection: ");
            //Коллекция для хранения строк
            List<string> ls = new List<string>();
            ls.Add("Hello");
            ls.Add("from");
            ls.Add("generics");
            //при обращении к элементам коллекции возвращается резульат типа string
            foreach (string s in ls) Console.Write("{0} ", s);
            Console.WriteLine();
        }

        // Пример использования обобщенного словаря
        static void DictionaryExample()
        {
            //Свовать для хранения пар: название группы - количество студентов
            Dictionary<string, int> gr = new Dictionary<string, int>();
            //добавление значений в список
            gr["Kaminskij"] = 12;
            gr.Add("Umanskij", 11);
            gr.Add("Barsegyan", 8);
            gr.Add("Kopytchenko", 7);

            //изменение значения
            gr["Kaminskij"] = 11;

            //вывод всех элементов словаря
            Console.WriteLine("Dictionary Content: ");
            foreach (KeyValuePair<string, int> p in gr)
                Console.WriteLine("{0} {1}", p.Key, p.Value);

            //удаление по значению ключа
            gr.Remove("Umanskij");

            //попытка добавления существующего ключа
            try
            {
                gr.Add("Barsegyan", 12);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            //попытка обращения к несуществующему ключу
            try
            {
                Console.WriteLine(gr["Kolesnikov"]);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            //проверка существования ключа и получение зачнения
            int val;
            if (gr.TryGetValue("Kolesnikov", out val)) Console.WriteLine(val);
            else Console.WriteLine("Key not found");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("List<T> example");
            Console.WriteLine("-------------------");
            ListExample();
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("Dictionary<TKey, TValue> example");
            Console.WriteLine("-------------------");
            DictionaryExample();
        }
    }
}