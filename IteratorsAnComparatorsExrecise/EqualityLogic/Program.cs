using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            SortedSet<Person> peopleSorted = new SortedSet<Person>();
            HashSet<Person> peopleHash = new HashSet<Person>(new PersonEqualityComparer());
            
            for (int i = 0; i < linesCount; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                peopleSorted.Add(person);
                peopleHash.Add(person);
                
            }

            Console.WriteLine(peopleSorted.Count);
            Console.WriteLine(peopleHash.Count);
        }
    }
}
