using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collection;
public class ListyIterator<T> : IEnumerable<T>
{
    private readonly List<T> elements;
    private int index;

    public ListyIterator(params T[] elements)
    {
        this.elements = elements.ToList();
        this.index = 0;
    }

    public bool Move()
    {
        if (HasNext())
        {
            index++;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        return index < elements.Count - 1;
    }

    public void Print()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(elements[index]);
    }

    public void PrintAll()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(string.Join(" ", elements));
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            yield return elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

