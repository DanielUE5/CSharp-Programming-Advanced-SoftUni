class CountUppercaseWords
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        var uppercaseWords = words.Where(w => !string.IsNullOrEmpty(w) && char.IsUpper(w[0])).ToList();

        foreach (var word in uppercaseWords)
        {
            Console.WriteLine(word);
        }
    }
}
