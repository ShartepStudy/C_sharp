using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryFileExample
{
    class Program
    {
        static void Main()
        {
            string path = "";
            while (true)
            {
                Console.WriteLine("Введите путь к папке для поиска:");
                path = Console.ReadLine();
                if (Directory.Exists(path))
                    break;
                else
                    Console.WriteLine("Путь не найден!");
            }

            Console.WriteLine("Введите текст для поиска:");
            List<FileInfo> findFiles = FindFiles(new DirectoryInfo(path), Console.ReadLine());

            if (findFiles != null && findFiles.Count > 0)
            {
                Console.WriteLine("Искомый текст найден в следующих файлах:");
                foreach (var file in findFiles)
                {
                    Console.WriteLine(file.Name);
                }
            }
            else
            {
                Console.WriteLine("Искомый текст не найден");
            }
            Console.ReadLine();
        }



        /// <summary>
        /// Рекурсивно находит все файлы, содержащие необходимый текст
        /// </summary>
        static List<FileInfo> FindFiles(DirectoryInfo dir, string targetText)
        {
            List<FileInfo> result = null;
            if (dir != null)
            {
                result = new List<FileInfo>();
                FileInfo[] files = dir.GetFiles();
                foreach (var file in files)
                {
                    if (CheckFileHasText(file, targetText))
                        result.Add(file);
                }
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (var di in dirs)
                {
                    result.AddRange(FindFiles(di, targetText));
                }
            }
            return result;
        }


        /// <summary>
        /// Проверяет файл на наличие в нем targetText
        /// </summary>
        static bool CheckFileHasText(FileInfo file, string targetText)
        {
            bool result = false;
            try
            {
                using (StreamReader sr = file.OpenText())
                {
                    result = sr.ReadToEnd().Contains(targetText);
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}