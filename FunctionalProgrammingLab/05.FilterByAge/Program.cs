using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            List<(string name, int age)> people = new List<(string name, int age)>();

            for (int i = 0; i < linesCount; i++)
            {
                string[] person = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add((person[0], int.Parse(person[1])));
            }
            string condition = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<(string, int), int, bool> younger = (p, a) => p.Item2 < a;
            Func<(string, int), int, bool> older = (p, a) => p.Item2 >= a;

            switch (condition)
            {
                case "younger":
                    people = people.Where(p => younger(p, ageFilter)).ToList();
                    break;
                case "older":
                    people = people.Where(p => older(p, ageFilter)).ToList();
                    break;
                default:
                    break;
            }

            foreach (var person in people)
            {
                Print(person,format);
            }
        }

        private static void Print((string name, int age) person, string format)
        {
            if (format == "name")
            {
                Console.WriteLine(person.name);
            }
            else if (format == "age")
            {
                Console.WriteLine(person.age);
            }
            else if (format == "name age")
            {
                Console.WriteLine($"{person.name} - {person.age}");
            }
        }
    }
}
