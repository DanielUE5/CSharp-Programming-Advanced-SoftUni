using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Froggy;
public class Lake : IEnumerable<int>
{
    private readonly List<int> stones;

    public Lake(params int[] stones)
    {
        this.stones = stones.ToList();
    }

    public IEnumerator<int> GetEnumerator()
    {
        // First, yield stones at even indices (0-based) in ascending order
        for (int i = 0; i < stones.Count; i += 2)
        {
            yield return stones[i];
        }

        // Then, yield stones at odd indices in descending order
        for (int i = stones.Count - (stones.Count % 2 == 0 ? 1 : 2); i >= 0; i -= 2)
        {
            yield return stones[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}