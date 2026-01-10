namespace GenericCountMethodString
{
    public class Program
    {
        public static int CountGreaterThan<T>(List<Box<T>> list, Box<T> element) where T : IComparable<T>
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(new Box<string>(input));
            }

            string comparisonValue = Console.ReadLine();
            Box<string> comparisonBox = new Box<string>(comparisonValue);

            int count = CountGreaterThan(list, comparisonBox);
            Console.WriteLine(count);
        }
    }
}