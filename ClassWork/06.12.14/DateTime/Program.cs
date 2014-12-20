using System;
using System.Text;
using System.IO;

class Sample
{
    public static int CalculateAge(DateTime BirthDate)
    {
        int YearsPassed = DateTime.Now.Year - BirthDate.Year;
        if (DateTime.Now.Month < BirthDate.Month || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day))
        {
            YearsPassed--;
        }
        return YearsPassed;
    }

    public static void Main()
    {
        Console.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);

        DateTime d = new DateTime(1989, 10, 3);
        Console.WriteLine(CalculateAge(d));

        double unixTime = (DateTime.Now - new DateTime(1970, 1, 1)).TotalSeconds;
        Console.WriteLine(unixTime);
    }
}