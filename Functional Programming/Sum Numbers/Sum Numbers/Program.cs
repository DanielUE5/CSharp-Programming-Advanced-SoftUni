class SumNumbers
{
    static void Main()
    {

        string input = Console.ReadLine();

        var numbers = input
            .Split(", ")                             
            .Select(int.Parse)                      
            .ToArray();                              

        int count = numbers.Length;
        int sum = numbers.Sum();

        Console.WriteLine(count);
        Console.WriteLine(sum);
    }
}
