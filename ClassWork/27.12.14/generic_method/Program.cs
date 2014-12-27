using System;

namespace GenericMethod
{
    class Program
    {
        // The where clause is used to specify constraints on the types that can be used as arguments
        // for a type parameter defined in a generic declaration. For example, you can declare such that
        // the type parameter T implements the IComparable<T> interface:

        // http://msdn.microsoft.com/en-us/library/6b0scde8(v=vs.80).aspx

        static T MaxElem<T>(T[] a) where T : IComparable
        {
            T m = a[0];
            foreach (T t in a)
            {
                if (t.CompareTo(m) > 0) m = t;
            }
            return m;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 9, 11 };
            double[] b = new double[] { 2.0, 3.9, 5.4 };
            Console.WriteLine(MaxElem<int>(a));
            Console.WriteLine(MaxElem(a));
            Console.WriteLine(MaxElem(b));
        }
    }
}