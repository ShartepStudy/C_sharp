using System;
using System.Text;
using System.IO;

namespace DirectoryAndFile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** Информация о директории ***");
            Console.Write("\nВведите путь к директории: ");
            string path = Console.ReadLine();

            DirectoryInfo di = new DirectoryInfo(path);

            if (di.Exists)
            {
                Console.WriteLine("\nПолное имя: " + di.FullName);
                Console.WriteLine("Атрибуты: " + di.Attributes);

                Console.WriteLine("\n\n*** Поиск файлов в директории ***");
                Console.Write("\nВведите шаблон для поиска:");
                string pattern = Console.ReadLine();

                try
                {
                    FileInfo[] files = di.GetFiles(pattern);
                    Console.WriteLine();
                    foreach (FileInfo f in files)
                    {
                        Console.WriteLine("{0,-30} {1}", f.Name, f.Length);
                    }

                    Console.WriteLine("__________________________");
                    Console.WriteLine("Всего: " + files.Length);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                Console.WriteLine("Директория не найдена");

            ////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n*** Создание директории ***");
            Console.Write("\nВведите путь к директории: ");
            path = Console.ReadLine();

            try
            {
                Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            ////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n*** Информация о дисках ***\n");

            try
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo d in drives)
                {
                    if (d.IsReady)
                        Console.WriteLine("{0,-5} {1} байт", d.Name, d.TotalSize);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}