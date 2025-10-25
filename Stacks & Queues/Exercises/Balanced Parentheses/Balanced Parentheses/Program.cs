class BalancedParentheses
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Console.WriteLine(IsBalanced(input) ? "YES" : "NO");
    }

    static bool IsBalanced(string sequence)
    {
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> pairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach (char ch in sequence)
        {
            if (pairs.ContainsKey(ch))
            {
                stack.Push(ch);
            }

            else if (pairs.ContainsValue(ch))
            {
                if (stack.Count == 0 || pairs[stack.Pop()] != ch)
                {
                    return false; 
                }
            }
        }

        return stack.Count == 0;
    }
}
