class SortEvenNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();

        var result = input
            .Split(", ")
            .Select(int.Parse)
            .Where(n => n % 2 == 0)
            .OrderBy(n => n)
            .ToList();

        Console.WriteLine(string.Join(", ", result));
    }
}
