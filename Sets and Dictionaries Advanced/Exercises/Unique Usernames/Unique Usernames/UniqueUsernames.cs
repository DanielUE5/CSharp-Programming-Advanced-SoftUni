class UniqueUsernames
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        HashSet<string> uniqueUsernames = new HashSet<string>();
        List<string> orderedUsernames = new List<string>();

        for (int i = 0; i < count; i++)
        {
            string username = Console.ReadLine().Trim();

            if (uniqueUsernames.Add(username)) 
            {
                orderedUsernames.Add(username);
            }
        }

        foreach (string username in orderedUsernames)
        {
            Console.WriteLine(username);
        }
    }
}
