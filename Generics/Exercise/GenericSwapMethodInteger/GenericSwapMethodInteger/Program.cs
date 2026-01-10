namespace GenericSwapMethodInteger
{
    public class Program
    {
        public static void Swap<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> list = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list.Add(new Box<int>(input));
            }

            string[] indexes = Console.ReadLine().Split();
            int index1 = int.Parse(indexes[0]);
            int index2 = int.Parse(indexes[1]);

            Swap(list, index1, index2);

            foreach (var box in list)
            {
                Console.WriteLine(box.ToString());
            }
        }
    }
}
