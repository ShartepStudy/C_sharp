using System;
using System.Collections;
using System.Text;

namespace Lesson_5_AnonymousMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(100);
            st.Push(200);
            st.Push(300);

            foreach (int i in st)
                Console.WriteLine(i);

            Console.WriteLine("-------");
            st.Pop();
            foreach (int i in st)
                Console.WriteLine(i);

            Console.WriteLine("-------");
            int last = (int)st.Peek();

            Console.WriteLine(last);

            Console.WriteLine("-------");
            Console.WriteLine(st.Contains(1));
            Console.WriteLine(st.Contains(100));
            Console.WriteLine("-------");

            st.Clear();
            Console.WriteLine(st.Count);
        }
    }
}