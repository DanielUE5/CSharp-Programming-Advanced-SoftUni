class ReverseAndExclude
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int n = int.Parse(Console.ReadLine());

        Predicate<int> isDivisibleByN = number => number % n == 0;

        numbers.Reverse();

        List<int> result = numbers.Where(num => !isDivisibleByN(num)).ToList();

        Console.WriteLine(string.Join(" ", result));
    }
}
