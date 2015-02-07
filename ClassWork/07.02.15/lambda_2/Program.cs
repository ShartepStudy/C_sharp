using System;
using System.IO;

class TestClass
{
    // сигнатура делегата  
    // совместимого с лямбда-выражением.  
    delegate int LambdaDelegate(ref int step);

    static void Main()
    {
        LambdaDelegate lambdaDel = (ref int a) => ++a;

        int step = 1;
        int finish = 7;

        while (step <= finish)
        {
            Console.Write("Бегун сейчас на {0} километре." +
                 " До финиша осталось {1}\n", step, finish - step);
            //step = lambdaDel(step);
            lambdaDel(ref step);
        }
    }
}