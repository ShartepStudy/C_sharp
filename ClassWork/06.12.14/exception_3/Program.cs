using System;
using System.Text;
using System.IO;

class Sample
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("до исключения!");
            throw new Exception("бдыщ!");
            Console.WriteLine("после исключения!");
        }
        catch (Exception e)
        {
            Console.WriteLine("произошло исключение: {0}", e.Message);
        }
    }
}