class TruckTour
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Queue<(int petrol, int distance)> petrolPumps = new Queue<(int, int)>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int petrol = int.Parse(input[0]);
            int distance = int.Parse(input[1]);
            petrolPumps.Enqueue((petrol, distance));
        }

        int startIndex = 0;
        int totalPetrol = 0;    
        int currentPetrol = 0;  

        for (int i = 0; i < n; i++)
        {
            var currentPump = petrolPumps.Dequeue();
            int petrol = currentPump.petrol;
            int distance = currentPump.distance;

            currentPetrol += petrol - distance;

            if (currentPetrol < 0)
            {
                startIndex = i + 1;
                totalPetrol += currentPetrol;
                currentPetrol = 0;
            }

            petrolPumps.Enqueue(currentPump);
        }

        Console.WriteLine(startIndex);
    }
}
