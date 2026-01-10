using CustomDoublyLinkedList;

namespace CustomLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var intList = new CustomDoublyLinkedList<int>();
            intList.AddFirst(10);
            intList.AddLast(20);
            intList.AddFirst(5);
            intList.AddLast(25);

            Console.WriteLine("Current Integer List:");
            intList.ForEach(Console.WriteLine);

            Console.WriteLine($"Removed First: {intList.RemoveFirst()}");
            Console.WriteLine($"Removed Last: {intList.RemoveLast()}");

            Console.WriteLine("Integer List After Removals:");
            intList.ForEach(Console.WriteLine);

            var stringList = new CustomDoublyLinkedList<string>();
            stringList.AddFirst("Hello");
            stringList.AddLast("World");
            stringList.AddFirst("C#");
            stringList.AddLast("Programming");

            Console.WriteLine("Current String List:");
            stringList.ForEach(Console.WriteLine);

            Console.WriteLine($"Removed First: {stringList.RemoveFirst()}");
            Console.WriteLine($"Removed Last: {stringList.RemoveLast()}");

            Console.WriteLine("String List After Removals:");
            stringList.ForEach(Console.WriteLine);
        }
    }
}

