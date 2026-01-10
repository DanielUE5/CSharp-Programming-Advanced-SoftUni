using System;
using System.Collections.Generic;
namespace EqualityLogic;

public class Person : IComparable<Person>
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override bool Equals(object obj)
    {
        if (obj is Person other)
        {
            return string.Equals(Name, other.Name, StringComparison.Ordinal) && Age == other.Age;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }

    public int CompareTo(Person other)
    {
        if (other == null) return 1;
        int nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        return Age.CompareTo(other.Age);
    }
}