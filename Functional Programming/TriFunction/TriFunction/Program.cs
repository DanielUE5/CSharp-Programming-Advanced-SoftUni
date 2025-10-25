class TriFunction
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine().Split(' ').ToList();

        string result = FindFirstName(names, (name, threshold) => GetCharacterSum(name) >= threshold, N);

        Console.WriteLine(result);
    }

    static string FindFirstName(List<string> names, Func<string, int, bool> criteria, int threshold)
    {
        foreach (var name in names)
        {
            if (criteria(name, threshold))
            {
                return name; 
            }
        }
        return null; 
    }

    static int GetCharacterSum(string name)
    {
        return name.Sum(c => (int)c); 
    }
}
