using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator;
public class ListyIterator<T>
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
}
