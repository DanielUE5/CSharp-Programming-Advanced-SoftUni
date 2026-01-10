using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    private readonly List<T> elements;

    public Stack()
    {
        elements = new List<T>();
    }

    public void Push(params T[] items)
    {
        foreach (var item in items)
        {
            elements.Add(item);
        }
    }

    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("No elements");
        }

        T item = elements[^1];
        elements.RemoveAt(elements.Count - 1);
        return item;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = elements.Count - 1; i >= 0; i--)
        {
            yield return elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}