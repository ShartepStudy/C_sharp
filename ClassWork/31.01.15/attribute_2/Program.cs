
public class AlexAttribute : Attribute // создаём собственный атрибут наследуясь от стандартного класса
{
     public int Count { get; set; } // создаём своё свойство которое будет содержать атрибут
     // можно описать несколько свойств но для примера создаётся только одно
}



[AlexAttribute{ Count = 5 }]
public class Some
{
     public void Test()
     {
          Type type = this.GetType(); // получение описания типа
          if (Attribute.IsDefined(type, typeof(AlexAttribute))) // проверка на существование атрибута
          {
              var attributeValue = Attribute.GetCustomAttribute(type, typeof(AlexAttribute)) as AlexAttribute; // получаем значение атрибута
              Console.WriteLine(attributeValue.Count); // используем значение атрибута для формирования результата
          }
     }
}