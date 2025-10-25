class KnightsOfHonor
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] names = input.Split(' ');

        Action<string> printSirName = name => Console.WriteLine($"Sir {name}");

        foreach (var name in names)
        {
            printSirName(name);
        }
    }
}
