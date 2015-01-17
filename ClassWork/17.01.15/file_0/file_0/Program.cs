using System;
using System.IO;
using System.Text;

namespace FileStreamExample
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();

            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);

            Console.WriteLine("Введите строку для записи в файл:");
            string writeText = Console.ReadLine();

            byte[] writeBytes = Encoding.UTF8.GetBytes(writeText); // преобразование строки в массив байт

            fs.Write(writeBytes, 0, writeBytes.Length);

            fs.Flush(); // сохраняем данные на диск

            fs.Seek(0, SeekOrigin.Begin); // устанавливаем курсор в начало файла

            byte[] readBytes = new byte[fs.Length];

            fs.Read(readBytes, 0, readBytes.Length);

            string readText = Encoding.UTF8.GetString(readBytes);

            Console.WriteLine("Данные, прочитанные из файла: {0}", readText);

            //int f = 158;
            //byte[] myInt = BitConverter.GetBytes(f);
            //fs.Write(myInt, 0, myInt.Length);
            //fs.Flush(); // сохраняем данные на диск
        }
    }
}
