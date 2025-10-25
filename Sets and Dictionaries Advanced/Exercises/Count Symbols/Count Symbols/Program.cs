class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        foreach(var kvp in charCount.OrderBy(k => k.Key))
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}
