using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OldestFamilyMember
{
    public class Family
    {
        private readonly List<Person> _members = new List<Person>();

        public void AddMember(Person member)
            => _members.Add(member);

        public Person GetOldestMember()
            => _members.OrderByDescending(p => p.Age).First();
    }
}
