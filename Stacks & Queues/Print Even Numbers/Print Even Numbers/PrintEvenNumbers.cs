public class PrintEvenNumbers
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            queue.Enqueue(arr[i]);
        }

        int evenCount = 0;

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            if (current % 2 == 0)
            {
                evenCount++;

                if (evenCount == 1)
                {
                    Console.Write(current); 
                }
                else
                {
                    Console.Write(", " + current);
                }
            }
        }
        Console.WriteLine();
    }
}
