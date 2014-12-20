using System;
using System.Text;
using System.IO;

class Sample
{
    static void f4()
    {
        throw new Exception("опача!");
    }
    static void f3()
    {
        f4();
    }
    static void f2()
    {
        f3();
    }
    static void f1()
    {
        f2();
    }
    static void Main(string[] args)
    {
        try
        {
            f1();
        }
        catch (Exception e)
        {
            Console.WriteLine("main: {0} \n {1}", e.Message, e.StackTrace);
        }
    }
}