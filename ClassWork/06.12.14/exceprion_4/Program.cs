using System;
using System.Text;
using System.IO;

class Sample
{
    static void Main(string[] args)
    {
        try
        {
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            int c = 0;
            Console.WriteLine(b / c);
        }
        catch (Exception e)
        { }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("деление на 0!: {0}", e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("надо было ввести число: {0}", e.Message);
        }
        catch
        {
            Console.WriteLine("обожэ нет");
        }
    }
}