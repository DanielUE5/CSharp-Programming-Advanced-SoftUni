using System;
using System.Collections.Generic;

namespace ComparingObjects;
public class Person : IComparable<Person>
{
    public string Name { get; }
    public int Age { get; }
    public string Town { get; }

    public Person(string name, int age, string town)
    {
        Name = name;
        Age = age;
        Town = town;
    }

    public int CompareTo(Person other)
    {
        int nameComparison = Name.CompareTo(other.Name);
        if (nameComparison != 0) return nameComparison;

        int ageComparison = Age.CompareTo(other.Age);
        if (ageComparison != 0) return ageComparison;

        return Town.CompareTo(other.Town);
    }
}