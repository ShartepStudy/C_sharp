using System;
using System.Threading;

namespace Lesson_5_Delegate_E3
{
    //delegate int SomeDelegate(int x);

    //class Program
    //{
    //    static void Main(string[] args) {
    //        SomeDelegate sd = SquareNumber; // Создаем делегат
    //        Console.WriteLine("Перед вызовом SquareNumber");
    //        int res = sd(10);          
    //        Console.WriteLine("Возвращаемcя в главный метод");
    //        Console.WriteLine(res);
    //        Console.ReadLine();
    //    }

    //    static int SquareNumber(int a) {
    //        Console.WriteLine("SquareNumber вызван. Обработка..");
    //        Thread.Sleep(2000);
    //        return a * a;
    //    }
    //}

    delegate int SomeDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            SomeDelegate sd = SquareNumber; // Создаем делегат
            Console.WriteLine("Перед вызовом SquareNumber");
            IAsyncResult asyncRes = sd.BeginInvoke(10, null, null);
            Console.WriteLine("Возвращаемcя в главный метод");
            int res = sd.EndInvoke(asyncRes);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        static int SquareNumber(int a)
        {
            Console.WriteLine("SquareNumber вызван. Обработка..");
            Thread.Sleep(2000);
            return a * a;
        }
    }
}