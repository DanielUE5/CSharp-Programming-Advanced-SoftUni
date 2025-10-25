internal class SoftUniParty
{
    public static void Main()
    {
        HashSet<string> vipGuests = new HashSet<string>();
        HashSet<string> regularGuests = new HashSet<string>();

        var input = Console.ReadLine();

        while (input != "PARTY")
        {
            if (char.IsDigit(input[0])) 
            {
                vipGuests.Add(input);
            }
            else
            {
                regularGuests.Add(input);
            }

            input = Console.ReadLine();
        }

        input = Console.ReadLine();
        while (input != "END")
        {
            if (vipGuests.Contains(input))
            {
                vipGuests.Remove(input);
            }
            else if (regularGuests.Contains(input))
            {
                regularGuests.Remove(input); 
            }

            input = Console.ReadLine();
        }

        int guestsNotArrived = vipGuests.Count + regularGuests.Count;
        Console.WriteLine(guestsNotArrived);

        foreach (var vip in vipGuests)
        {
            Console.WriteLine(vip);
        }

        foreach (var regular in regularGuests)
        {
            Console.WriteLine(regular);
        }
    }
}
