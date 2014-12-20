using System;
using System.Text;
using System.IO;

class Sample
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 0;
        int res = 0;

        try
        {
            res = a / b;            
        }
        catch (SystemException)
        {
            Console.WriteLine("получится бесконечность.");
        }
        finally
        {
            if (b == 0) Console.WriteLine("переменную типа int на ноль лучше не делить!");
            else Console.WriteLine(a + " / " + b + " = " + res);
        }
        Console.WriteLine(10.0 / 0);
    }
}