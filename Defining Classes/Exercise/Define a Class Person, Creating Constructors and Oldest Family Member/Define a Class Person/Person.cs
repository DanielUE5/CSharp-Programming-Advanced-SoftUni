using System.Net.Sockets;


namespace OldestFamilyMember
{
    public class Person
    {
        private string name;
        private int age;

        public Person() 
            : this(1)
        { 
        
        }

        public Person(int age)
            : this("No name", age)
        {

        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
    }
}