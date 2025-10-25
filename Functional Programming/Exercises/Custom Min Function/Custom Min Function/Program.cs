class CustomMinFunction
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        Func<int[], int> findMin = nums => nums.Min();

        Console.WriteLine(findMin(numbers));
    }
}
