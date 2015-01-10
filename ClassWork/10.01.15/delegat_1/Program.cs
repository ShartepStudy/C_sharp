using System;
using System.Threading;

/*

делегат - это объект, который хранит ссылку на метод, и может вызывать его при помощи этой ссылки.

использование делегатов можно описать четырьмя шагами:

1. определение методов с отпределённой сигнатурой
2. определение делегата с сигнатурой, точно соответствующей сигнатуре методов
3. создание объекта делегата и связывание его с методами
4. вызов связанного метода с помощью объекта делегата

*/

class Program
{
    static void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    static void Div(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    delegate void CalculateSum(int x, int y);

    static void Main(string[] args)
    {
        CalculateSum test = new CalculateSum(Sum);
        //CalculateSum test = Sum;
        test += Div;
        test(5, 7);
    }
}