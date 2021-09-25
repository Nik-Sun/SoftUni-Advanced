using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partyPeople = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            

            string input = Console.ReadLine();
            while (input != "Party!")
            {
                string[] lineData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                partyPeople = MasterMethod(partyPeople, lineData);

                input = Console.ReadLine();
            }
            Console.WriteLine(partyPeople.Count >0 ?$"{string.Join(", ",partyPeople)} are going to the party!" : "Nobody is going to the party!");
        }

        private static List<string> MasterMethod(List<string> partyPeople, string[] lineData)
        {
            string command = lineData[0];
            string key = lineData[1];
            string param = lineData[2];
            switch (command)
            {
                case "Double":
                    List<string> doubleGuests = partyPeople.FindAll(MyPredicate(key, param));
                    foreach (var item in doubleGuests)
                    {
                        int index = partyPeople.FindIndex(p => p == item);
                        partyPeople.Insert(index,item);
                    }
                    return partyPeople;
                case "Remove":
                    partyPeople.RemoveAll(MyPredicate(key,param));
                    return partyPeople;
                default:
                    return partyPeople;
            }
        }

        private static Predicate<string> MyPredicate(string key, string param)
        {
            switch (key)
            {
                case "StartsWith":
                    return n => n.StartsWith(param);
                case "EndsWith":
                    return n => n.EndsWith(param);
                case "Length":
                    return n => n.Length == int.Parse(param);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
