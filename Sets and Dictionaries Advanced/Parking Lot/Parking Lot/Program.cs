using System.Text.RegularExpressions;

internal class ParkingLot
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();

        HashSet<string> set = new HashSet<string>();

        while (input != "END")
        {

            string[] inputParams = Regex.Split(input, ", ");

            if (inputParams[0] == "IN")
            {
                set.Add(inputParams[1]);
            }
            else
            {
                set.Remove(inputParams[1]);
            }

            input = Console.ReadLine();
        }

        if (set.Count == 0)
        {
            Console.WriteLine("Parking Lot is Empty");
        }
        else
        {
            foreach (var car in set)
            {
                Console.WriteLine(car);
            }
        }
    }
}