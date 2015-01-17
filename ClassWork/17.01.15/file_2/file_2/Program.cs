using System;
using System.IO;

namespace BinaryWriterAndReader
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите путь к файлу: ");

            string path = Console.ReadLine();

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);

            BinaryWriter bw = new BinaryWriter(fs);

            double d = 3.14159;
            int i = 2015;
            string s = "some text";

            bw.Write(d);
            bw.Write(i);
            bw.Write(s);

            bw.Flush();

            fs.Seek(0, SeekOrigin.Begin);

            BinaryReader br = new BinaryReader(fs);

            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());

            fs.Close();

        }
    }
}