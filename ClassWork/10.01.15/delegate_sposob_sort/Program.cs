using System;

class Program
{
    public delegate Boolean Comparer(Object elem1, Object elem2);

    static class BubbleSorter
    {
        static public void Sort(Object[] array, Comparer comparer)
        {
            for (Int32 i = 0; i < array.Length; i++)
            {
                for (Int32 j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[j], array[i]))
                    {
                        Object buffer = array[i];
                        array[i] = array[j];
                        array[j] = buffer;
                    }
                }
            }
        }
    }

    public struct Person
    {
        public String FirstName;
        public String LastName;
        public DateTime Birthday;

        public Person(String FirstName, String LastName, DateTime Birthday)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
        }

        public override String ToString()
        {
            return String.Format(
                "Имя: {0,-10} Фамилия: {1,-10} Дата рождения: {2:dd.MM.yyyy}.",
                FirstName, LastName, Birthday);
        }
    }

    static public Boolean PersonBirthdayComparer(Object person1, Object person2)
    {
        return ((Person)person1).Birthday < ((Person)person2).Birthday;
    }

    static void Main(string[] args)
    {

        Object[] persons = {
                                   new Person("Даниэль", "Барсегян", new DateTime(1995, 10, 8)),
                                   new Person("Виталий", "Здерка", new DateTime(1984, 6, 14)),
                                   new Person("Дмитрий", "Каминский", new DateTime(1988, 7, 1)),
                                   new Person("Ренат", "Каримов", new DateTime(1994, 1, 1)),
                                   new Person("Александр", "Копытченко", new DateTime(1984, 11, 6)),
                                   new Person("Игорь", "Попов", new DateTime(1993, 5, 11))
                               };


        Console.WriteLine("Несортированный список:\n");
        foreach (Object person in persons) Console.WriteLine(person);

        Console.WriteLine("\nСортированный список:\n");
        BubbleSorter.Sort(persons, new Comparer(PersonBirthdayComparer));
        foreach (Object person in persons) Console.WriteLine(person);

        Console.WriteLine("\n");
    }
}