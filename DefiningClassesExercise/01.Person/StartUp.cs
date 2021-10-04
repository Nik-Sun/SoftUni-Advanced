using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < peopleCount; i++)
            {
                string[] personData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personData[0],int.Parse(personData[1]));
                family.AddMember(person);
            }
            family.PrintPeopleAbove30();
        }
    }
}
