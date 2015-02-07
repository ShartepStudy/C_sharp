using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string text = "Бла бла бла... Сегодня курс доллара составляет 36.53 грн.";
        Regex regex = new Regex(@"\s\d+\.\d+ грн\."); // (@"\s\d+(\.\d+)? грн\.");

        Match match = regex.Match(text);

        if (match.Success)
        {
            Console.WriteLine("index: " + match.Index + ";" + match.Value);
            //match = match.NextMatch(); // for while
        }

    }
}