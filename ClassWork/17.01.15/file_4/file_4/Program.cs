using System;
using System.Text;
using System.IO;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo root = new DirectoryInfo(@"\\fs\Преподаватели\Загоруйко А\Public\");

            //FileInfo[] files = root.GetFiles();

            //foreach (FileInfo f in files)
            //{
            //    Console.WriteLine(f.Name + " размером в " + f.Length + " байт");
            //    if ((f.Attributes & FileAttributes.Hidden) != 0)
            //    {
            //        Console.WriteLine("Hidden File");
            //    }
            //    Console.WriteLine(f.CreationTime.ToString());
            //    Console.WriteLine();
            //}

            //Console.WriteLine("///////////////////////////////\n");

            //DirectoryInfo[] dirs = root.GetDirectories("*", SearchOption.AllDirectories);

            //foreach (DirectoryInfo d in dirs)
            //{
            //    Console.WriteLine(d.Parent.Name + " \\ " + d.Name);
            //}

            //Console.WriteLine("///////////////////////////////\n");

            FileInfo[] filesToRead = root.GetFiles("*.txt", SearchOption.AllDirectories);

            //foreach (FileInfo f in filesToRead)
            //{
            //    StreamReader tmp = f.OpenText();
            //    string content = tmp.ReadToEnd();
            //    Console.WriteLine(f.Name + ": " + content);
            //    tmp.Close(); // важно! иначе не выйдет сделать MoveTo!
            //}

            //Console.WriteLine("///////////////////////////////\n");

            foreach (FileInfo f in filesToRead)
            {
                try
                {
                    f.MoveTo(root.FullName + @"\txt\" + f.Name);
                }
                catch
                {
                    Console.WriteLine("Oops! Smth wrong!");
                }
            }

            //Console.WriteLine("///////////////////////////////\n");

            //foreach (FileInfo f in filesToRead)
            //{
            //    // f.Delete();
            //}
        }
    }
}