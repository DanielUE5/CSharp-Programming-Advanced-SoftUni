int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Stack<int> numbers = new Stack<int>(input);


while (true)
{
    string[] commands = Console.ReadLine().Split();
    string command = commands[0].ToLower();

    if (command == "end")
        break;

    if (command == "add")
    {
        int num1 = int.Parse(commands[1]);
        int num2 = int.Parse(commands[2]);

        numbers.Push(num1);
        numbers.Push(num2);
    }
    else if (command == "remove")
    {
        int count = int.Parse(commands[1]);

        if (count <= numbers.Count)
        {
            for (int i = 0; i < count; i++)
            {
                {
                    numbers.Pop();
                }
            }
        }
    }
}
Console.WriteLine($"Sum: {numbers.Sum()}");