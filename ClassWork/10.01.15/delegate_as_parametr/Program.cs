using System;

class Program
{
    delegate void Postal(String pointA, String pointB);

    static void Main()
    {
        Postal John;
        String p1 = "Дубаи";
        String p2 = "Токио";

        John = By_Car;
        John(p1, p2);

        John = By_Airplane;
        John(p1, p2);

        John = By_Internet;
        John(p1, p2);
    }

    static void By_Car(String point1, String point2)
    {
        Console.WriteLine("Везу почту на машине из {0} в {1}.", point1, point2);
    }
    static void By_Airplane(String point1, String point2)
    {
        Console.WriteLine("Лечу в самолёте из {0} в {1}.", point1, point2);
    }
    static void By_Internet(String point1, String point2)
    {
        Console.WriteLine("Отправляю почту через интернет из {0} в {1}.", point1, point2);
    }
}