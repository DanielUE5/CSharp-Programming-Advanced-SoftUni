string input = Console.ReadLine();

Stack<int> indexes = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        indexes.Push(i);
    }
    else if (input[i] == ')')
    {
        int lastOpenBrackets = indexes.Pop();
        string results = input.Substring(lastOpenBrackets, i - lastOpenBrackets + 1);
        Console.WriteLine(results);
    }
}