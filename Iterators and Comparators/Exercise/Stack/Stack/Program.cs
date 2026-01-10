public class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            var parts = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                if (parts[0] == "Push")
                {
                    var items = parts.Skip(1).Select(int.Parse).ToArray();
                    stack.Push(items);
                }
                else if (parts[0] == "Pop")
                {
                    stack.Pop();
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}