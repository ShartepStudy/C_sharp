﻿using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ConsoleApplication8
{
    /*
     
      Магические слова “сериализация” и “десериализация” имеют отношение к магии сохранения состояния объекта.
      Сериализация имеет прямое отношение к сохранению состояния объекта в файле или памяти, а десериализация -
      к восстановлению состояния объекта соответственно. Примеров, когда это может пригодиться, неимоверное множество.
      Начиная от сохранения пользовательских настроек и заканчивая сохранением промежуточного состояния объекта.
     
      Для осуществления магии (де)сериализации .NET предлагает нам 3 родных варианта (не считая самостоятельной реализации механизма сериализации):
      - Сериализация в двоичный формат (BinnaryFormatter)
      - Сериализация в формат SOAP (SoapFormatter)
      - Сериализация в формат XML (XmlSerializer)

     Чтобы сделать объект сериализируемым нужно снабдить каждый связанный с ним класс или структуру аттрибутом [Serializable].
     Если есть поля, которые по какой-то причине нужно исключить из сериализации, их необходимо пометить аттрибутом [NonSerialized].
     
    */

    // http://msdn.microsoft.com/ru-ru/library/z0w1kczw.aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-1

    [Serializable]
    public class Human
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [NonSerialized]
        public int age;
    }

    [Serializable]
    public class SuperHero : Human
    {
        // http://hitfounder.livejournal.com/19773.html
        public bool isEvil { get; set; }
        public Ability superpower = new Ability();
    }

    [Serializable]
    public class Ability
    {
        public bool isUnique;
        public string[] abilities;
    }

    /*
       Сериализация в двоичный формат с помощью BinaryFormatter
       BinaryFormatter сохраняет состояние объекта в двоичном формате. Сериализируются все поля, вне зависимости от их
       области видимости. Исключение составляют поля помеченные аттрибутом [NonSerialized]. Помимо сохранения данных полей,
       BinaryFormatter также сохраняет полное квалифицированное имя каждого типа, полное имя сборки, где он определен,
       сюда входит информация об имени и версии.
    */

    class Program
    {
        static void Main(string[] args)
        {
            SuperHero SuperHero = new SuperHero();
            SuperHero.Name = "Invisible Sharpshooter";
            SuperHero.age = 25;
            SuperHero.isEvil = false;
            SuperHero.superpower.abilities = new string[] { "sharp eye", "invisibility", "telekinesis", "acid generation", "sonic scream", "resurrection", "time manipulation" };
            SuperHero.superpower.isUnique = true;

            SuperHero SuperHero2 = new SuperHero();
            SuperHero2.Name = "Invisible Batman";
            SuperHero2.age = 20;
            SuperHero2.isEvil = false;
            SuperHero2.superpower.abilities = new string[] { "flying", "eating" };
            SuperHero2.superpower.isUnique = false;

            //Сохраняем состояние объекта SuperHero в двоичном формате
//            BinaryFormatter formatter = new BinaryFormatter();
            XmlSerializer formatter = new XmlSerializer(SuperHero.GetType());
            using (var fStream = new FileStream("SuperHeroInfo.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fStream, SuperHero);
//                formatter.Serialize(fStream, SuperHero2);
            }

            using (var fStream = File.OpenRead("SuperHeroInfo.xml"))
            {
                SuperHero newSuperHero = (SuperHero)formatter.Deserialize(fStream);

                Console.WriteLine("Name:\t\t" + newSuperHero.Name);
                Console.WriteLine("Age:\t\t" + newSuperHero.age);
                Console.WriteLine("Is Evil:\t" + newSuperHero.isEvil);
                Console.WriteLine("Is Unique:\t" + newSuperHero.superpower.isUnique);
                Console.WriteLine("\nSkills List:");

                foreach (string skill in newSuperHero.superpower.abilities)
                {
                    Console.WriteLine("\t" + skill);
                }

                Console.WriteLine("\n\n\n\n");   

                //newSuperHero = (SuperHero)formatter.Deserialize(fStream);

                //Console.WriteLine("Name:\t\t" + newSuperHero.Name);
                //Console.WriteLine("Age:\t\t" + newSuperHero.age);
                //Console.WriteLine("Is Evil:\t" + newSuperHero.isEvil);
                //Console.WriteLine("Is Unique:\t" + newSuperHero.superpower.isUnique);
                //Console.WriteLine("\nSkills List:");

                //foreach (string skill in newSuperHero.superpower.abilities)
                //{
                //    Console.WriteLine("\t" + skill);
                //}
            }
        }
    }
}