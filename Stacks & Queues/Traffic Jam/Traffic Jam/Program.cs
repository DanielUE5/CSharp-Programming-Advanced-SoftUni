int passedCars = int.Parse(Console.ReadLine());
string input  = Console.ReadLine();

Queue<string> trafficJam = new Queue<string>(passedCars);

int allPassedCars = 0;

while (input != "end")
{
    if (input != "green")
    {
        trafficJam.Enqueue(input);
    }
    else if (input == "green")
    {
        int currentPass = passedCars;
        while (trafficJam.Count > 0 && currentPass > 0)
        {
            Console.WriteLine($"{trafficJam.Dequeue()} passed!  ");
            currentPass--;
            allPassedCars++;
        }
    }

    input = Console.ReadLine();
}

Console.WriteLine($"{allPassedCars} cars passed the crossroads.");

