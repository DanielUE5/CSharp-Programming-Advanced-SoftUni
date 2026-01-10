namespace Tuple;

public class Program
{
    public static void Main()
    {
        string[] personInfo = Console.ReadLine().Split(new[] { ' ' }, 3);
        string fullName = $"{personInfo[0]} {personInfo[1]}";
        string address = personInfo[2];
        Tuple<string, string> personTuple = new Tuple<string, string>(fullName, address);
        Console.WriteLine(personTuple.ToString());


        string[] beerInfo = Console.ReadLine().Split();
        string name = beerInfo[0];
        int beerAmount = int.Parse(beerInfo[1]);
        Tuple<string, int> beerTuple = new Tuple<string, int>(name, beerAmount);
        Console.WriteLine(beerTuple.ToString());


        string[] numbers = Console.ReadLine().Split();
        int integer = int.Parse(numbers[0]);
        double doubleNumber = double.Parse(numbers[1]);
        Tuple<int, double> numberTuple = new Tuple<int, double>(integer, doubleNumber);
        Console.WriteLine(numberTuple.ToString());
    }
}