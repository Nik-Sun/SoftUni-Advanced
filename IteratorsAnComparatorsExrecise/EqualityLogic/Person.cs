using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person :IComparable<Person> 
    {
        public string  Name { get; set; }
        public int Age { get; set; }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo( Person other)
        {
            if (Name.CompareTo(other.Name) == 0)
            {
                if (Age.CompareTo(other.Age) == 0)
                {
                    return 0;
                }
                return Age.CompareTo(other.Age);
            }
            return Name.CompareTo(other.Name);
        }

        
    }
}
