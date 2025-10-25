class FashionBoutique
{
    static void Main(string[] args)
    {
        Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

        int rackCapacity = int.Parse(Console.ReadLine());

        int currentRackCapacity = rackCapacity; 
        int racksUsed = 1; 

        while (clothes.Count > 0)
        {
            int currentCloth = clothes.Peek();

            if (currentCloth <= currentRackCapacity)
            {
                currentRackCapacity -= currentCloth;
                clothes.Pop();
            }
            else
            { 
                racksUsed++;
                currentRackCapacity = rackCapacity; 
            }
        }

        Console.WriteLine(racksUsed);
    }
}
