using System;
using System.IO;

namespace PathExample
{
    class Program
    {
        static void Main()
        {
            string p = @"D:\1\2\3\4\5.txt"; // какой-то абстрактный путь к файлу!

            Console.WriteLine(Path.GetDirectoryName(p));
            Console.WriteLine(Path.ChangeExtension(p, ".mp3"));
            Console.WriteLine(Path.GetExtension(p));
            Console.WriteLine(Path.GetFileName(p));
            Console.WriteLine(Path.GetFullPath(p));
            Console.WriteLine(Path.GetInvalidFileNameChars());
            Console.WriteLine(Path.GetPathRoot(p));
            Console.WriteLine(Path.GetRandomFileName());
            Console.WriteLine(Path.GetTempFileName());
            Console.WriteLine(Path.IsPathRooted(p));
            Console.WriteLine(Path.HasExtension(p));
        }
    }
}