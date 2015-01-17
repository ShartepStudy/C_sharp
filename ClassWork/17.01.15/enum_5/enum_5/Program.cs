using System;

class Program
{
    public enum MessagingOptions
    {
        None = 0,
        Buffered = 0x01,
        Persistent = 0x02,
        Durable = 0x04,
        Broadcast = 0x08
    }

    static void Main()
    {
        string optionsString = "Persistent";

        // можно использовать Enum.Parse, который вызывает исключение, если встретит что-то, что ему не понравится
        var result = (MessagingOptions)Enum.Parse(typeof(MessagingOptions), optionsString);

        if (result == MessagingOptions.Persistent)
        {
            Console.WriteLine("It works!");
        }

        ///////////////////////////////////////////////

        optionsString = "Persistent, Buffered";

        result = (MessagingOptions)Enum.Parse(typeof(MessagingOptions), optionsString);

        if (result.HasFlag(MessagingOptions.Persistent) && result.HasFlag(MessagingOptions.Buffered))
        {
            Console.WriteLine("It works!");
        }

        ///////////////////////////////////////////////

        optionsString = "3"; // "3" представляет собой сочетание Buffered (0x01) и Persistent (0x02)

        result = (MessagingOptions)Enum.Parse(typeof(MessagingOptions), optionsString);

        if (result.HasFlag(MessagingOptions.Persistent) && result.HasFlag(MessagingOptions.Buffered))
        {
            Console.WriteLine("It works again!");
        }

        ///////////////////////////////////////////////

        optionsString = "Persistent, Buf3fered";

        // Попытка разбора возвращает true в случае успеха, и результат в параметре out 
        if (Enum.TryParse(optionsString, out result))
        {
            if (result.HasFlag(MessagingOptions.Persistent) && result.HasFlag(MessagingOptions.Buffered))
            {
                Console.WriteLine("It works!");
            }
        }
        else
        {
            Console.WriteLine("Oops!\n\n");
        }

        ///////////////////////////////////////////////

        MessagingOptions value = MessagingOptions.Buffered | MessagingOptions.Persistent;

        // общий формат, который используется по умолчанию
        Console.WriteLine("Default    : " + value);

        // формат флагов
        Console.WriteLine("F (flags)  : " + value.ToString("F"));

        // целочисленный формат
        Console.WriteLine("D (num)    : " + value.ToString("D"));

        // шестнадцатеричный формат
        Console.WriteLine("X (hex)    : " + value.ToString("X"));

    }
}
