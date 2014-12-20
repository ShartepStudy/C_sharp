using System;

class Person
{
    public Person(string fName, string lName)
    {
        firstName = fName;
        lastName = lName;
    }

    public string firstName;
    public string lastName;
}

// Collection of Person objects. This class 
// implements IEnumerable so that it can be used 
// with ForEach syntax. 

class People
{
    private Person[] _people;

    public People(Person[] pArray)
    {
        _people = new Person[pArray.Length];

        for (int i = 0; i < pArray.Length; i++)
        {
            _people[i] = pArray[i];
        }
    }

    public PeopleEnum GetEnumerator()
    {
        return new PeopleEnum(_people);
    }

}

class PeopleEnum
{
    public Person[] _people;

    // Enumerators are positioned before the first element 
    // until the first MoveNext() call. 

    int position = -1;

    public PeopleEnum(Person[] list)
    {
        _people = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < _people.Length);
    }

    public Person Current
    {
        get
        {
            return _people[position];
        }
    }
}

class Program
{
    static void Main()
    {
        Person[] peopleArray = new Person[3]
        {
            new Person("Алексей", "Горячев"),
            new Person("Вероника", "Жукова"),
            new Person("Геннадий", "Приходько"),
        };

        People peopleList = new People(peopleArray);

        foreach (Person p in peopleList)
            Console.WriteLine(p.firstName + " " + p.lastName);

    }
}