using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            CustomBool bTrue = new CustomBool(CustomBool.s_true);
            CustomBool bNull = new CustomBool(CustomBool.s_null);
            CustomBool bFalse = new CustomBool(CustomBool.s_false);

            Console.WriteLine("bTrue && bNull is {0}", bTrue && bNull);
            Console.WriteLine("bTrue && bFalse is {0}", bTrue && bFalse);
            Console.WriteLine("bTrue && bTrue is {0}", bTrue && bTrue);
            Console.WriteLine();

            Console.WriteLine("bTrue || bNull is {0}", bTrue || bNull);
            Console.WriteLine("bFalse || bFalse is {0}", bFalse || bFalse);
            Console.WriteLine("bTrue || bFalse is {0}", bTrue || bFalse);
            Console.WriteLine();

            Console.WriteLine("!bTrue is {0}", !bTrue);
            Console.WriteLine("!bFalse is {0}", !bFalse);
            Console.WriteLine("!bNull is {0}", !bNull);
        }
    }
}