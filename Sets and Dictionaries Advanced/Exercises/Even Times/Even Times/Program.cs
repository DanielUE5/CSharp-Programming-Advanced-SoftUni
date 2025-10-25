class EvenTimes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<int, int> numberCounts = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (numberCounts.ContainsKey(num))
            {
                numberCounts[num]++;
            }
            else
            {
                numberCounts[num] = 1;
            }
        }

        foreach (var kvp in numberCounts)
        {
            if (kvp.Value % 2 == 0)
            {
                Console.WriteLine(kvp.Key);
                break;
            }
        }
    }
}
