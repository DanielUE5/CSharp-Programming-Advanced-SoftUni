using ComparingObjects;
namespace ComparingObjects;

public class Program
{
    public static void Main()
    {
        var people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var parts = input.Split();
            var name = parts[0];
            var age = int.Parse(parts[1]);
            var town = parts[2];

            people.Add(new Person(name, age, town));
        }

        int targetIndex = int.Parse(Console.ReadLine()) - 1;
        var targetPerson = people[targetIndex];

        int equalCount = 0;
        foreach (var person in people)
        {
            if (targetPerson.CompareTo(person) == 0)
            {
                equalCount++;
            }
        }

        int notEqualCount = people.Count - equalCount;
        if (equalCount > 1)
        {
            Console.WriteLine($"{equalCount} {notEqualCount} {people.Count}");
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}