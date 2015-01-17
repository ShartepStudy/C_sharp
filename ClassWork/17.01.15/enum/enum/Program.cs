using System;

// перечисление - класс, представляющий собой непустой список именованных целочисленных констант, имеющих некоторые значения.

enum DayOfWeek { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

class Program
{
    static void Main()
    {

        Console.ForegroundColor = ConsoleColor.Green;

        DayOfWeek day = DayOfWeek.Thursday;

        for (int i = 0, j = 11; i <= 20; i++, j++)
        {
            Console.WriteLine(j + ", " + day);

            if (day == DayOfWeek.Sunday)
                Console.WriteLine();

            day++;

            if (day > DayOfWeek.Sunday) day = DayOfWeek.Monday;

        }
    }
}
