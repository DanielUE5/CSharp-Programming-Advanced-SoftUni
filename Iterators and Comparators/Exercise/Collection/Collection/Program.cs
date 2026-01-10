using Collection;
namespace Collection;
public class Program
{
    public static void Main()
    {
        ListyIterator<string> listyIterator = null;

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            var parts = command.Split();
            var action = parts[0];

            try
            {
                switch (action)
                {
                    case "Create":
                        listyIterator = new ListyIterator<string>(parts.Skip(1).ToArray());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                    case "PrintAll":
                        listyIterator.PrintAll();
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
