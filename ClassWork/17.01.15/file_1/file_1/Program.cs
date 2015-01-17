using System;
using System.Text;
using System.IO;

namespace StreamWriterAndReader
{
    class Program
    {
        static void Main()
        {
            FileStream fs = new FileStream("file.txt", FileMode.Create, FileAccess.ReadWrite);

            StreamWriter sw = new StreamWriter(fs);

            sw.AutoFlush = true;

            string writeText = "test ";
            sw.Write(writeText);

            int number = 25;
            sw.Write(number);

            // sw.Dispose(); // сохранить данные на диск, закрыть поток

            fs.Seek(0, SeekOrigin.Begin);

            StreamReader sr = new StreamReader(fs);
            string readText = sr.ReadToEnd();
            Console.WriteLine(readText);

            fs.Close();
        }
    }
}