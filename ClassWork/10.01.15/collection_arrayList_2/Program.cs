using System;
using System.Collections;

public class Tester
{
    public static void Main()
    {
        ArrayList week = new ArrayList(new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" });
        ArrayList workweek = new ArrayList(week.GetRange(0, 5));
        foreach (string day in workweek)
            Console.WriteLine(day);
        Console.WriteLine("//////////////////");
        week.Sort();
        foreach (string day in week)
            Console.WriteLine(day);
    }
}