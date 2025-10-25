class FindEvensOrOdds
{
    static void Main()
    {
        int[] bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int lowerBound = bounds[0];
        int upperBound = bounds[1];

        string command = Console.ReadLine();

        Predicate<int> filter;

        if (command == "even")
        {
            filter = number => number % 2 == 0;  
        }
        else if (command == "odd")
        {
            filter = number => number % 2 != 0;  
        }
        else
        {
            throw new ArgumentException("Invalid command");
        }

        List<int> result = new List<int>();
        for (int i = lowerBound; i <= upperBound; i++)
        {
            if (filter(i))
            {
                result.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
