using System;
using System.Linq;
namespace CustomComparator;

public class Program
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Array.Sort(numbers, CustomComparator);

        Console.WriteLine(string.Join(" ", numbers));
    }

    public static int CustomComparator(int x, int y)
    {
        if (x % 2 == 0 && y % 2 != 0) return -1;
        if (x % 2 != 0 && y % 2 == 0) return 1;

        return x.CompareTo(y);
    }
}
