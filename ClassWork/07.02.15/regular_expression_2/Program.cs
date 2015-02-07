using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string text = "Привет, \"Александр\", как у тебя дела? Правда, что тебе \"27\" лет?";

        Regex regex = new Regex("\"[0-9\\sА-яЁё]*\""); // (@"\""[0-9\sА-яЁё]*\""");

        Match match = regex.Match(text);

        while (match.Success)
        {
            Console.WriteLine(match.Index + " " + match.Value);
            match = match.NextMatch();
        }
    }
}