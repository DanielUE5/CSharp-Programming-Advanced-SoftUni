namespace Threeuple
{
    public class Program
    {
        public static void Main()
        {
            string[] personInfo = Console.ReadLine().Split(new[] { ' ' }, 4);
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string address = personInfo[2];
            string town = personInfo[3];
            Threeuple<string, string, string> personThreeuple = new Threeuple<string, string, string>(fullName, address, town);
            Console.WriteLine(personThreeuple.ToString());


            string[] beerInfo = Console.ReadLine().Split();
            string name = beerInfo[0];
            int beerLiters = int.Parse(beerInfo[1]);
            bool isDrunk = beerInfo[2].ToLower() == "drunk";
            Threeuple<string, int, bool> beerThreeuple = new Threeuple<string, int, bool>(name, beerLiters, isDrunk);
            Console.WriteLine(beerThreeuple.ToString());


            string[] bankInfo = Console.ReadLine().Split();
            string accountHolder = bankInfo[0];
            double balance = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];
            Threeuple<string, double, string> bankThreeuple = new Threeuple<string, double, string>(accountHolder, balance, bankName);
            Console.WriteLine(bankThreeuple.ToString());
        }
    }
}
