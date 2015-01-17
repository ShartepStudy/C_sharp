using System;

class Program
{
    public enum ResultCode
    {
        Success,
        Warning,
        Error
    }

    public static int ResultCodeFromDataSource()
    {
        //return 0;
        return -4;
    }

    public static ResultCode PerformAction()
    {
        // вызываем какой-то метод, который возвращает int.
        int result = ResultCodeFromDataSource();

        if (!Enum.IsDefined(typeof(ResultCode), result))
        {
            throw new InvalidOperationException("Enum out of range!");
        }

        // это удастся, даже если результат < 0 или > 2.
        return (ResultCode)result;
    }

    static void Main()
    {
        ResultCode result = PerformAction();

        switch (result)
        {
            case ResultCode.Success:
                Console.WriteLine("выполняется код для успешного результата");
                break;

            case ResultCode.Warning:
                Console.WriteLine("выполняется код для предупреждения");
                break;

            case ResultCode.Error:
                Console.WriteLine("выполняется код для ошибки");
                break;
        }
    }
}
