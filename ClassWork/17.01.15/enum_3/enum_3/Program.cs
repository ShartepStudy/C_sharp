using System;
class Program
{
    enum Months : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

    enum MachineState
    {
        PowerOff = 0,
        Running = 5,
        Sleeping = 10,
        Hibernating = Sleeping + 5
    }

    enum Days
    {
        None = 0x0,
        Monday = 0x1,
        Tuesday = 0x2,
        Wednesday = 0x4,
        Thursday = 0x8,
        Friday = 0x10,
        Saturday = 0x20,
        Sunday = 0x40
    }

    static void Main()
    {
        // enum Months : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        Days meetingDays = Days.Tuesday | Days.Thursday;

        /////////////////////////////////////////////////////

        string s = Enum.GetName(typeof(Days), 4);
        Console.WriteLine(s + "\n");

        Console.WriteLine("The values of the Days Enum are:");
        foreach (int i in Enum.GetValues(typeof(Days)))
            Console.Write(i + ", ");
        Console.WriteLine("\n");

        Console.WriteLine("The names of the Days Enum are:");
        foreach (string str in Enum.GetNames(typeof(Days)))
            Console.Write(str + ", ");
        Console.WriteLine("\n");

    }

}
