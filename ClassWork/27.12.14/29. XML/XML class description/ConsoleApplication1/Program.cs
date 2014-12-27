using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using System.Runtime.Remoting;

namespace ConsoleApplication1
{
    class Program
    {
        public class MyClass
        {
            public static int number;
            public string str;
            static int count = 5;

            public MyClass() { }

            public int Number
            {
                get { return number; }
                set { number = value; }
            }

            public string Str
            {
                get { return str; }
                set { str = value; }
            }

            public static void ShowStatic(string str)
            {
                Console.WriteLine(str + ":" + count);
            }

            public void Show(string str2)
            {
                Console.WriteLine("число: {0}, строка: {1} {2}", number, str, str2);
            }

        }
        static void Main()
        {
            MyClass ob = new MyClass();
            ob.Number = 10;
            ob.Str = "World";
            ob.Show("проверка");
            MyClass.ShowStatic("Hello");

            #region Запись
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(@"D:\Class.xml", System.Text.Encoding.Unicode);
                writer.Formatting = Formatting.Indented; 
                writer.WriteStartDocument();
                Type t = typeof(MyClass);
                writer.WriteStartElement(typeof(MyClass).Name);
                writer.WriteAttributeString("Тип", "Класс");

                MethodInfo[] mi = t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                foreach (MethodInfo m in mi)
                {
                    writer.WriteStartElement(m.Name);
                    writer.WriteAttributeString("Член", "Метод");
                    writer.WriteAttributeString("Возвращаемый_тип", m.ReturnType.Name);
                    if (m.IsStatic) writer.WriteAttributeString("Статический", "Да");
                    else writer.WriteAttributeString("Статический", "Нет");
                    if (m.IsPublic) writer.WriteAttributeString("Доступ", "public");
                    if (m.IsPrivate) writer.WriteAttributeString("Доступ", "private");
                    MethodBody mb = m.GetMethodBody();

                    ParameterInfo[] pi = m.GetParameters();

                    for (int i = 0; i < pi.Length; i++)
                        writer.WriteElementString(pi[i].ParameterType.Name, pi[i].Name);
                    writer.WriteEndElement();
                }

                FieldInfo[] fi = t.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                foreach (FieldInfo f in fi)
                {
                    writer.WriteStartElement(f.Name);
                    writer.WriteAttributeString("Член", "Поле");
                    writer.WriteAttributeString("Тип_данных", f.FieldType.Name);
                    if (f.IsStatic) writer.WriteAttributeString("Статический", "Да");
                    else writer.WriteAttributeString("Статический", "Нет");
                    if (f.IsPublic) writer.WriteAttributeString("Доступ", "public");
                    if (f.IsPrivate) writer.WriteAttributeString("Доступ", "private");
                    writer.WriteEndElement();
                }
            }

            finally
            {
                if (writer != null)
                    writer.Close();
            }
            #endregion


            #region Чтение

            XmlTextReader reader = null;
            List<string> methodName = new List<string>();
            string className = null;

            try
            {
                reader = new XmlTextReader(@"D:\Class.xml");
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.GetAttribute("Тип") == "Класс")
                    {
                        Console.WriteLine("Класс " + reader.Name);
                        className = reader.Name;
                    }
                    if (reader.NodeType == XmlNodeType.Element && reader.GetAttribute("Член") == "Метод")
                    {
                        Console.WriteLine("Метод " + reader.Name);
                        methodName.Add(reader.Name);
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            #endregion

            #region запуск нужного метода

            if (className != "MyClass") 
            {
                Console.WriteLine("В XML файле незнакомое название класса ");
                return;
            }
            Assembly asm = Assembly.GetExecutingAssembly(); 
            Type[] types = asm.GetTypes();
            foreach (Type type in types)
            {
                if (type.Name == className)
                {
                    ConstructorInfo ci = type.GetConstructor(Type.EmptyTypes);
                    object Tt = ci.Invoke(null);
                    object[] args = new object[1];
                    args[0] = "Новая строка";
                    Tt.GetType().GetMethod("Show").Invoke(Tt, args);
                }
            }
        }
    }
}

            #endregion



//object foo = Activator.CreateInstance(null, "Foo"); 
//foo.GetType().GetMethod("Hello").Invoke(foo, null);


