using System;
using System.Threading;

class OneAtATimePlease
{
    // Используем уникальное имя приложения,
    // например, с добавлением имени компании
    static Mutex mutex = new Mutex(false, "OneAtATimeDemo");

    static void Main()
    {
        // Ожидаем получения мьютекса 5 сек – если уже есть запущенный
        // экземпляр приложения - завершаемся.
        if (!mutex.WaitOne(TimeSpan.FromSeconds(5)))
        {
            Console.WriteLine("В системе запущен другой экземпляр программы!");
            return;
        }

        try
        {
            Console.WriteLine("Работаем - нажмите Enter для выхода...");
            Console.ReadLine();
        }
        finally { mutex.ReleaseMutex(); }
    }
}