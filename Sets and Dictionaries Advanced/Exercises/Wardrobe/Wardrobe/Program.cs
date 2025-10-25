class Wardrobe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            string color = input[0];
            string[] clothes = input[1].Split(',');

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe[color] = new Dictionary<string, int>();
            }

            foreach (string cloth in clothes)
            {
                if (wardrobe[color].ContainsKey(cloth))
                {
                    wardrobe[color][cloth]++;
                }
                else
                {
                    wardrobe[color][cloth] = 1;
                }
            }
        }

        string[] search = Console.ReadLine().Split();
        string searchColor = search[0];
        string searchClothing = search[1];

        foreach (var color in wardrobe)
        {
            Console.WriteLine($"{color.Key} clothes:");

            foreach (var cloth in color.Value)
            {
                if (color.Key == searchColor && cloth.Key == searchClothing)
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }
        }
    }
}
