using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    public class Program
    {
        public static void Main()
        {
            //Person p1 = new Person();
            //p1.Name = "Peter";
            //p1.Age = 20;

            //Person p2 = new Person { Name = "George", Age = 18 };

            //Person p3 = new Person("Jose", 43);

            Family family = new Family();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person currentMember = new Person(data[0], int.Parse(data[1]));
                family.AddMember(currentMember);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
