class PredicateParty
{
    static void Main()
    {
        List<string> guests = Console.ReadLine().Split(' ').ToList();

        string command;
        while ((command = Console.ReadLine()) != "Party!")
        {
            string[] commandParts = command.Split(' ');
            string action = commandParts[0]; 
            string criteria = commandParts[1]; 

            if (action == "Remove")
            {
                RemoveGuests(guests, criteria, commandParts);
            }
            else if (action == "Double")
            {
                DoubleGuests(guests, criteria, commandParts);
            }
        }

        PrintGuests(guests);
    }

    static void RemoveGuests(List<string> guests, string criteria, string[] commandParts)
    {
        if (criteria == "StartsWith")
        {
            string prefix = commandParts[2];
            guests.RemoveAll(name => name.StartsWith(prefix));
        }
        else if (criteria == "EndsWith")
        {
            string suffix = commandParts[2];
            guests.RemoveAll(name => name.EndsWith(suffix));
        }
        else if (criteria == "Length")
        {
            int length = int.Parse(commandParts[2]);
            guests.RemoveAll(name => name.Length == length);
        }
    }

    static void DoubleGuests(List<string> guests, string criteria, string[] commandParts)
    {
        if (criteria == "StartsWith")
        {
            string prefix = commandParts[2];
            List<string> toDouble = guests.Where(name => name.StartsWith(prefix)).ToList();
            guests.AddRange(toDouble);
        }
        else if (criteria == "EndsWith")
        {
            string suffix = commandParts[2];
            List<string> toDouble = guests.Where(name => name.EndsWith(suffix)).ToList();
            guests.AddRange(toDouble);
        }
        else if (criteria == "Length")
        {
            int length = int.Parse(commandParts[2]);
            List<string> toDouble = guests.Where(name => name.Length == length).ToList();
            guests.AddRange(toDouble);
        }
    }

    static void PrintGuests(List<string> guests)
    {
        if (guests.Count == 0)
        {
            Console.WriteLine("Nobody is going to the party!");
        }
        else
        {
            Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
        }
    }
}
