class ActionPart
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] names = input.Split(' ');

        Action<string> printName = name => Console.WriteLine(name);

        foreach (var name in names)
        {
            printName(name);
        }
    }
}
