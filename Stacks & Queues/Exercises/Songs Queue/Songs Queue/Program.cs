class SongsQueue
{
    static void Main(string[] args)
    {
        Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", "));

        while (songsQueue.Count > 0)
        {
            string command = Console.ReadLine();

            if (command == "Play")
            {
                songsQueue.Dequeue();
            }
            else if (command.StartsWith("Add"))
            {
                string songToAdd = command.Substring(4);
                if (songsQueue.Contains(songToAdd))
                {
                    Console.WriteLine($"{songToAdd} is already contained!");
                }
                else
                {
                    songsQueue.Enqueue(songToAdd);
                }
            }
            else if (command == "Show")
            {
                Console.WriteLine(string.Join(", ", songsQueue));
            }
        }

        Console.WriteLine("No more songs!");
    }
}
