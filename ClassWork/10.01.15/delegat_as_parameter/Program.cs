using System;

class Program
{
    delegate string Action(int money);

    static string Work(int money, Action invoke)
    {
        return invoke(money) + " гривен";
    }
    static string ByTheYear(int money)
    {
        return (money * 365).ToString();
    }

    static string ByTheWeek(int money)
    {
        return (money * 7).ToString();
    }

    static void Main()
    {
        Console.WriteLine(Work(100, ByTheYear));
        Console.WriteLine(Work(100, ByTheWeek));
    }
}