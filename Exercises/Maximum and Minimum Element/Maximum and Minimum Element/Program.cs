internal class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();
        Stack<int> swap = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int code = query[0];

            if (code == 1)
            {
                int number = query[1];
                stack.Push(number);
            }
            else if (code == 2)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else if (code == 3)
            {
                if (stack.Count > 0)
                {
                    int maxElement = int.MinValue;

                    while (stack.Count > 0)
                    {
                        int currentElement = stack.Pop();
                        swap.Push(currentElement);

                        if (currentElement > maxElement)
                        {
                            maxElement = currentElement;
                        }
                    }

                    while (swap.Count > 0)
                    {
                        stack.Push(swap.Pop());
                    }

                    Console.WriteLine(maxElement);
                }
            }
            else if (code == 4)
            {
                if (stack.Count > 0)
                {
                    int minElement = int.MaxValue;

                    while (stack.Count > 0)
                    {
                        int currentElement = stack.Pop();
                        swap.Push(currentElement);

                        if (currentElement < minElement)
                        {
                            minElement = currentElement;
                        }
                    }

                    while (swap.Count > 0)
                    {
                        stack.Push(swap.Pop());
                    }
                    Console.WriteLine(minElement);
                }
            }
        }

        if (stack.Count > 0)
        {
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
