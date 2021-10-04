using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person member)
        {
            members.Add(member);
        }
        public Person GetOldestMember()
        {
            int maxAge = int.MinValue;
            foreach (Person person in members)
            {
                if (maxAge < person.Age)
                {
                    maxAge = person.Age;
                }
            }
            return members[members.FindIndex(m=> m.Age == maxAge)];
        }
        public void PrintPeopleAbove30()
        {
            foreach (Person person in members.Where(p => p.Age >30).OrderBy(p=> p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
