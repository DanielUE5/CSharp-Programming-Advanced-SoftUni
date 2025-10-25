class PeriodicTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> uniqueElements = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] elements = Console.ReadLine().Split();

            foreach (var element in elements)
            {
                uniqueElements.Add(element);
            }
        }

        List<string> sortedElements = new List<string>(uniqueElements);
        sortedElements.Sort();

        Console.WriteLine(string.Join(" ", sortedElements));
    }
}
