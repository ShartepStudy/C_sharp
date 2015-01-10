using System;
using System.IO;

class TestClass
{
    delegate void Anonim2(int start, int finish);

    static void Main()
    {
        // теперь аноним. метод с параметрами  
        Anonim2 anonim2 = delegate(int a, int b)
        {
            for (int i = a; i <= b; i++)
                Console.Write("Бегун сейчас на {0} километре." +
                     " До финиша осталось {1}\n", i, b - i);
        };

        anonim2(1, 7);
    }
}