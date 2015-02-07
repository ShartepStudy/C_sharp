using System;
using System.IO;
using System.Text;
using System.Threading;

namespace converter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var t1 = new Thread(() => convert("1111", "2222"));
            var t2 = new Thread(() => convert("4444", "3333"));
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }

        static void convert(String name1, String name2)
        {
            for (int i = 0; i < 100; ++i)
                Console.WriteLine("{0}, {1} ", name1, name2);
        }

    }
}
