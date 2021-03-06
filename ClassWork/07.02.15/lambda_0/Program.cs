﻿using System;
using System.IO;


/* Лямбда выражения, это более лучшая замена анонимным методам, которая основываются на новом синтаксисе.
   Во всех лямбда выражениях должен быть лямбда оператор =>. Этот оператор разделяет выражение на две части.

В левой части – параметры (может быть несколько);
В правой части – тело метода;
 
Есть еще такие понятия, как одиночные и блочные лямбда выражения.
Все просто, если у нас после цикла for или оператора if включается одна строчка кода,
то незачем включать эту строку в фигурные скобки. Это относится к одиночным лямбда выражениям,
но если в выражение несколько строчек, нужно захватить этот блок в фигурные скобки.

     Использование лямбда выражения можно разделить на три этапа:

- Определения делегата, совместимого с лямбда-выражением.
- Создание экземпляра делегата, которому присваивается лямбда-выражение.
- Использование выражения, которое происходит при обращение к делегату.

*/

// Одиночные лямбда-выражения:

class TestClass
{
    delegate int Pow(int change);

    static void Main()
    {
        Pow pow = change => change * change;

        Console.WriteLine(pow(10));
    }
}
