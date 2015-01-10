using System;
using System.IO;

class TestClass
{
    delegate void Anonim(); // сигнатура делегата  

    static void Main()
    {
       
        // используем анонимный метод   
        Anonim anonim = delegate
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\");
            foreach (DirectoryInfo d in dir.GetDirectories())
                Console.WriteLine(d.Name);
        };

        anonim(); // запускаем 
    }
}