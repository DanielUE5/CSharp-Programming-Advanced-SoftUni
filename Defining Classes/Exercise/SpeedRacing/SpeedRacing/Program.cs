using SpeedRacing;

int n = int.Parse(Console.ReadLine());

Dictionary<string, Car> carByModel = new Dictionary<string, Car>();
for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    Car car = new Car(data[0], double.Parse(data[1]), double.Parse(data[2]));
    carByModel[car.Model] = car;
}

string command = Console.ReadLine();
while (command != "End")
{
    string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (data[0] == "Drive")
    {
        string model = data[1];
        double distance = double.Parse(data[2]);

        if (!carByModel[model].Travel(distance))
            Console.WriteLine("Insufficient fuel for the drive");
    }
    command = Console.ReadLine();
}

foreach (Car car in carByModel.Values)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
}
