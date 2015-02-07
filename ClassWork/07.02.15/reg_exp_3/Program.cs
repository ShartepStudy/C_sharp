using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string text = "+38 093 47 37 627";
        //string text = "+38 093 473 76 27";
        //string text = "093 47 37 627";
        //string text = "+38 0934737627";
        //string text = "+38 093 -47 -37 -627";
        //string text = "+38   093    47   37    627";
        //string text = "+38 093-47-37-627";

        //string pattern = "^(\\+\\d{2}\\s+)*\\d{3}\\s*-?(\\d{3}\\s*-?\\d{2}\\s*-?\\d{2}|\\d{2}\\s*-?\\d{2}\\s*-?\\d{3})$";

        string pattern = @"^(\+?\d{2}\s+)?\d{3}\s*-?(\d{3}\s*-?\d{2}\s*-?\d{2}|\d{2}\s*-?\d{2}\s*-?\d{3})$";

        // ^ Соответствие должно начинаться в начале строки.
        // $ Соответствие должно обнаруживаться в конце строки или до символа \n в конце строки.
        // + Соответствует предыдущему элементу один или более раз.
        // * Соответствует предыдущему элементу ноль или более раз.
        // ? Соответствует предыдущему элементу ноль или один раз.
        // { n } Предыдущий элемент повторяется ровно n раз.
        // | Соответствует любому элементу, разделенному вертикальной чертой (|).

        Regex regex = new Regex(pattern);

        Match match = regex.Match(text);

        if (match.Success)
            Console.WriteLine("index:" + match.Index + ", " + match.Value);

    }
}