using DateModifier;
namespace DateModifier;

public class Program
{
    private static void Main()
    {
    string first = Console.ReadLine();
    string second = Console.ReadLine();

    int diffInDays = DateModifier.CalculateDifferenceInDays(first, second);

        Console.WriteLine(diffInDays);
    }
}