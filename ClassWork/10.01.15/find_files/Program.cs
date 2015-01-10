using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;
using System.Security.Permissions;


class Program
{
    static SortedList mass = new SortedList();
    static int countFiles = 0;
    static int countExtensions = 0;
    static int[] values;
    static string[] keys;

    public static void FileSearchFunction(string Dir)
    {
        System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo(Dir);
        System.IO.DirectoryInfo[] SubDir;
        try
        {
            SubDir = DI.GetDirectories();
        }
        catch
        {
            return;
        }
        for (int i = 0; i < SubDir.Length; ++i)
            FileSearchFunction(SubDir[i].FullName);
        System.IO.FileInfo[] FI = DI.GetFiles();

        foreach (FileInfo f in FI)
        {
            FileSecurity fs = new FileSecurity();
            f.SetAccessControl(fs);

            //Console.WriteLine(f.Name + " " + f.Length + "B");
            int indexPoint = f.Name.LastIndexOf('.');
            if (indexPoint == -1)
            {
                if (mass[" "] == null)
                {
                    mass[" "] = 1;
                    countExtensions++;
                }
                else
                {
                    int a = (int)mass[" "];
                    a++;
                    mass[" "] = a;
                }
            }
            else
            {
                string path = f.Name.Substring(f.Name.LastIndexOf('.') + 1);
                path = path.ToLower();
                if (mass[path] == null)
                {
                    mass[path] = 1;
                    countExtensions++;
                }
                else
                {
                    int a = (int)mass[path];
                    a++;
                    mass[path] = a;
                }
            }
            countFiles++;
        }

    }


    static void Main(string[] args)
    {

        //
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //

        string bigPath = @"c:\php\";
        FileSearchFunction(bigPath);


        values = new int[countExtensions];
        mass.GetValueList().CopyTo(values, 0);
        keys = new string[countExtensions];
        mass.GetKeyList().CopyTo(keys, 0);
        Array.Sort(values, keys);
        Array.Reverse(values);
        Array.Reverse(keys);

        if (countExtensions > 50)
            countExtensions = 50;

        Console.WriteLine(" Всего файлов: " + countFiles + "\n");
        for (int i = 0; i < countExtensions; i++)
        {
            Console.WriteLine(keys[i] + "\t" + values[i] + "\t" + Math.Round((double)values[i] * 100 / countFiles, 4) + "%");
        }

        //for (int i = 0; i < mass.Count; i++)
        //    Console.WriteLine(mass.GetKey(i) + " " + mass.GetByIndex(i)); 



    }
}