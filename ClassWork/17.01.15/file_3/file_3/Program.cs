using System;
using System.IO;
using System.Text;

namespace DirectoryExample
{
    class Program
    {
        static void Main()
        {            
            string[] files = Directory.GetFiles(@"D:\");
            foreach (string name in files)
                Console.WriteLine(name);
            Console.WriteLine();

            
            string[] dirs = Directory.GetDirectories(@"D:\");
            foreach (string name in dirs)
                Console.WriteLine(name);
            Console.WriteLine();
            

            string[] drives = Directory.GetLogicalDrives();
            foreach (string name in drives)
                Console.WriteLine(name);
            Console.WriteLine();
            
            string path = "D:\\test";
            Directory.CreateDirectory(path);
            Console.WriteLine(Directory.Exists(path));
            Directory.Delete(path);
            Console.WriteLine(Directory.Exists(path));
            
        }
    }
}
