using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
        public Person(string name,int age,string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Person other)
        {
            if (Name.CompareTo(other.Name) == 0)
            {
                if (Age == other.Age)
                {
                    return Town.CompareTo(other.Town);
                }
                return Age.CompareTo(other.Age);

            }
            return Name.CompareTo(other.Name);
        }
    }
}
