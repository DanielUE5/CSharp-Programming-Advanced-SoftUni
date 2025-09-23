class SimpleCalc
{
    static void Main(string[] args)
    {
        string expression = Console.ReadLine();

        string[] tokens = expression.Split(' ');

        Stack<string> stack = new Stack<string>();
        for (int i = tokens.Length - 1; i >= 0; i--)
        {
            stack.Push(tokens[i]);
        }

        int result = int.Parse(stack.Pop());

        while (stack.Count > 0)
        {
            string operatorSymbol = stack.Pop();

            int number = int.Parse(stack.Pop());

            if (operatorSymbol == "+")
            {
                result += number;
            }
            else if (operatorSymbol == "-")
            {
                result -= number;
            }
        }

        Console.WriteLine(result);
    }
}
