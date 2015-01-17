using System;
using System.Threading;

enum State : short { STOP = 12, WAIT = 14, GO = 10, BLINK = 0 };

class Program
{
    static void Main()
    {
        Console.Title = "Светофор";
        Console.CursorVisible = false;

        State svetofor = State.STOP; // initial state of traffic light

        while (true)
        {
            Console.BackgroundColor = (ConsoleColor)(svetofor); // Cannot implicitly convert type 'State' to 'System.ConsoleColor'. An explicit conversion exists (are you missing a cast?)
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)(15 - svetofor);

            Console.WriteLine("\n\t" + svetofor);

            if (svetofor == State.STOP)
            {
                Thread.Sleep(4000);
                svetofor = State.WAIT;
            }
            else if (svetofor == State.WAIT)
            {
                Thread.Sleep(2000);
                svetofor = State.GO;
            }
            else if (svetofor == State.GO)
            {
                Thread.Sleep(4000);
                svetofor = State.BLINK;
            }
            else if (svetofor == State.BLINK)
            {
                svetofor = State.BLINK;
                for (int i = 0; i < 3; i++)
                {
                    Console.BackgroundColor = (ConsoleColor)(State.BLINK);
                    Console.Clear();
                    Thread.Sleep(300);
                    Console.BackgroundColor = (ConsoleColor)(State.GO); // Cannot implicitly convert type 'State' to 'System.ConsoleColor'. An explicit conversion exists (are you missing a cast?)
                    Console.Clear();
                    Console.ForegroundColor = (ConsoleColor)(15 - State.GO);
                    Console.WriteLine("\n\t" + State.GO);
                    Thread.Sleep(300);
                }
                svetofor = State.STOP;
            }
            Console.Clear();
        }
    }
}