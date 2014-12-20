using System;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            MultiDimensional obj = new MultiDimensional(2, 3);

            for (Int32 i = 0; i < obj.Rows; i++)
            {
                for (Int32 j = 0; j < obj.Cols; j++)
                {
                    obj[i, j] = i + j;

                    Console.Write(obj[i, j].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}