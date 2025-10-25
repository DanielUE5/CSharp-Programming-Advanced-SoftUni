class addVAT
{
    static void Main()
    {
        string input = Console.ReadLine();

        double[] prices = input.Split(", ")
                               .Select(double.Parse)
                               .ToArray();

        const double VAT = 0.20;

        var pricesWithVAT = prices.Select(p => p * (1 + VAT))
                                  .Select(p => p.ToString("F2"));

        foreach (var price in pricesWithVAT)
        {
            Console.WriteLine(price);
        }
    }
}
