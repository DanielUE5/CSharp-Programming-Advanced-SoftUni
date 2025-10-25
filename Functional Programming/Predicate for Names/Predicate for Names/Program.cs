class PredicateForNames
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> names = Console.ReadLine().Split(' ').ToList();

        PrintFilteredNames(names, n);
    }

    static void PrintFilteredNames(List<string> names, int maxLength)
    {
        Func<string, bool> filterByLength = name => name.Length <= maxLength;

        List<string> filteredNames = names.Where(filterByLength).ToList();

        foreach (var name in filteredNames)
        {
            Console.WriteLine(name);
        }
    }
}
