using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();
            while (input != "END")
            {
                string[] personInfo = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(personInfo[0],int.Parse(personInfo[1]),personInfo[2]);
                people.Add(person);
                input = Console.ReadLine();
            }

            int personToCheckIndex = int.Parse(Console.ReadLine()) - 1;
            
            int matches = 0;
            Person personToCheck = people[personToCheckIndex];
            foreach (Person person in people)
            {
                if (person.CompareTo(personToCheck) == 0)
                {
                    matches++;
                }
            }
            if (matches > 1)
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
            
        }
    }
}
