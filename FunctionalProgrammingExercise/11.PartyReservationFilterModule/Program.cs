using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partyPeople = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<Filter> filters = new List<Filter>();

            string input = Console.ReadLine();
            while (input != "Print")
            {
                string[] filterInfo = input.Split(";",StringSplitOptions.RemoveEmptyEntries);
                string command = filterInfo[0];
                if (command == "Add filter")
                {
                    Filter current = new Filter(filterInfo[1], filterInfo[2]);
                    filters.Add(current);
                }
                else if (command == "Remove filter")
                {
                    filters.RemoveAll(f => f.Type == filterInfo[1] && f.Parameter == filterInfo[2]);   
                }

                input = Console.ReadLine();
            }
            foreach (Filter item in filters)
            {
                 partyPeople.RemoveAll(MyPredicate(item.Type, item.Parameter));
            }
            Console.WriteLine(string.Join(" ",partyPeople));
        }
        private static Predicate<string> MyPredicate(string key, string param)
        {
            switch (key)
            {
                case "Starts with":
                    return n => n.StartsWith(param);
                case "Ends with":
                    return n => n.EndsWith(param);
                case "Length":
                    return n => n.Length == int.Parse(param);
                case "Contains":
                    return n => n.Contains(param);
                default:
                    throw new NotImplementedException();
            }
        }
    }
    
}
class Filter
{
    public Filter(string type,string param)
    {
        Type = type;
        Parameter = param;
    }
    public string Type { get; set; }
    public string Parameter { get; set; }
}
  
